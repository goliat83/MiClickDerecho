Imports System.Globalization
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.draw

Public Class Form_comprobantes
    Dim detalle_asiento() As String
    Dim prod_cons, prod_cod, prod_barras, prod_nom, prod_desc, PROD_VALOR_UNITARIO_BASE, prod_valor, prod_valor2, prod_valor3, PROD_CATEGORIA, prod_iva, prod_iva2, PROD_IVATIPO, PROD_IVATIPO2, prod_iva1nom, prod_iva2nom, prod_base, PROD_IVA_VR, PROD_IVA_VR2, prod_stock, prod_imagen, prod_decimal, PROD_INVENTARIADO, PROD_COSTO As String
    Dim mes_num As Integer
    Dim mes_num_text As String
    Dim mes_num_text_general As String
    Dim COD_PUC As String = ""
    Dim COD_asiento As String = ""
    Dim COD_DOC_asiento As String = ""

    Dim COD_comprobante As String = ""

    Dim QUE_HACE As String = ""
    Dim QUE_HACE_asiento As String = ""
    Dim naturaleza As String = ""
    Dim PROD_SALDO, PROD_DEBE, PROD_HABER, PROD_ENTRAN, PROD_SALEN As Integer

    Dim entran, salen, saldo As Integer


    Public da_contact_fitro_CC As New MySqlDataAdapter
    Public dT_contact_fitro_CC As New DataTable


    Dim DOC_TERCERO, NOM_TERCERO As String
    Dim tercero_imp() As String
    Private Sub Form_comprobantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel_comprobantes.Width = 965

    End Sub

    Private Sub Form_comprobantes_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Cursor.Current = Cursors.WaitCursor
        Me.Panel_comprobantes.BringToFront()

        load_combo_cunetaspuc()


        load_combo_docs()

        COMBOBOX_FECHA_FILTRO.Text = ""

        ComboBox_MEs_filtro_comp.SelectedIndex = DateTime.Now.Month - 1
        mes_num = DateTime.ParseExact(Me.ComboBox_MEs_filtro_comp.Text, "MMMM", CultureInfo.CurrentCulture).Month
        mes_num_text_general = CStr(mes_num)
        If mes_num <= 9 Then mes_num_text_general = "0" & CStr(mes_num)

        Cursor.Current = Cursors.Default
    End Sub

    Private Sub load_combo_docs()



        Try
            sql = "SELECT CONS, concat(codigo,'|',documento) as documento FROM data_docs WHERE ESTADO='SI' AND PADRE='NO'"
            da_conta_COMBO1 = New MySqlDataAdapter(sql, conex)
            dT_conta_COMBO1 = New DataTable
            da_conta_COMBO1.Fill(dT_conta_COMBO1)
            Me.MetroComboBox1.DataSource = dT_conta_COMBO1.DefaultView
            Me.MetroComboBox1.DisplayMember = "documento"
            Me.MetroComboBox1.ValueMember = "cons"
            Me.MetroComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems
            Me.MetroComboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



        conex.Close()
        da_conta_COMBO1.Dispose()
        dT_conta_COMBO1.Dispose()
        conex.Close()


        ComboBox_cta_comp_NOMBRE.SelectedItem = Nothing

    End Sub

    Private Sub load_combo_cunetaspuc()



        Try
            sql = "SELECT CONS, CODIGO, CUENTA FROM cuentaspuc"
            da_combo_puc = New MySqlDataAdapter(sql, conex)
            dt_combo_puc = New DataTable
            da_combo_puc.Fill(dt_combo_puc)


            Me.ComboBox_cta_comp.DataSource = dt_combo_puc.DefaultView
            Me.ComboBox_cta_comp.DisplayMember = "CODIGO"
            Me.ComboBox_cta_comp.ValueMember = "CODIGO"
            Me.ComboBox_cta_comp.AutoCompleteSource = AutoCompleteSource.ListItems
            Me.ComboBox_cta_comp.AutoCompleteMode = AutoCompleteMode.Suggest
            Me.ComboBox_cta_comp.SelectedItem = Nothing

            Me.ComboBox_cta_comp_NOMBRE.DataSource = dt_combo_puc.DefaultView
            Me.ComboBox_cta_comp_NOMBRE.DisplayMember = "CUENTA"
            Me.ComboBox_cta_comp_NOMBRE.ValueMember = "CODIGO"
            Me.ComboBox_cta_comp_NOMBRE.AutoCompleteSource = AutoCompleteSource.ListItems
            Me.ComboBox_cta_comp_NOMBRE.AutoCompleteMode = AutoCompleteMode.Suggest
            Me.ComboBox_cta_comp_NOMBRE.SelectedItem = Nothing


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_combo_puc.Dispose()
        dt_combo_puc.Dispose()
        conex.Close()


        ComboBox_cta_comp.SelectedItem = Nothing
    End Sub

    Private Sub Button_nuevo_comp_Click(sender As Object, e As EventArgs) Handles Button_nuevo_comp.Click
        TextBox_comprobante.Text = ""

        'load_combo_cunetaspuc()

        QUE_HACE_asiento = "CREAR"

        MetroGrid_detalle_comprobante.DataSource = Nothing

        Me.COMBO_TERCERO_FILTRO.SelectedItem = Nothing

        Me.Panel_comprobantes.Visible = False
        Me.Panel_general.Visible = False
        Me.Panel_GUARDAR.Visible = True

        TextBox_comprobante.Enabled = True
        TextBox_fecha_comprobante.Enabled = True

        Me.Panel5.Visible = False
        Panel_datos_comprobantes.Visible = True
        TextBox_TIPO_COMPROBANTE.Text = "Comprobante de Contabilidad"
        TextBox_fecha_comprobante.Text = DateTime.Now.ToShortDateString

        TextBox_valor.Enabled = False
        TextBox_OBSERVACION.Enabled = True


        Me.Label_ESTADO.Text = "NUEVO"

        Button_exportar.Enabled = False
        Button_ANULAR.Enabled = False
        Button_guardar.Enabled = True
        Button_MODIFICAR.Enabled = False

        BunifuCards_asiento.Enabled = False
        BunifuCards_TERCERO.Enabled = False
    End Sub

    Private Sub Button_CONSULTAR_MOV_Click(sender As Object, e As EventArgs) Handles Button_CONSULTAR_MOV.Click
        If COD_comprobante = "" Then
            MsgBox("seleccione un coMprobante", vbInformation)
            Exit Sub
        End If

        QUE_HACE_asiento = "CONSULTAR"
        load_combo_cunetaspuc()

        Me.Panel_comprobantes.Visible = False
        Me.Panel_general.Visible = False

        Me.Panel5.Visible = False
        BunifuCards_asiento.Enabled = False
        BunifuCards_asiento.Visible = False

        Button_aagregar_siento.Visible = True
        Button_eliminar_asiento.Visible = True
        Me.Label_ESTADO.Visible = True


        Button_guardar.Enabled = False
        Button_ANULAR.Enabled = False
        Button_MODIFICAR.Enabled = True
        Button_exportar.Enabled = True

        Panel_datos_comprobantes.Visible = True

        ComboBox_cta_comp.Enabled = False
        ComboBox_cta_comp_NOMBRE.Enabled = False

        Me.COMBO_TERCERO_FILTRO.SelectedItem = Nothing


        TextBox_fecha_comprobante.Enabled = False
        TextBox_comprobante.Enabled = False
        TextBox_OBSERVACION.Enabled = False



        Try
            sql = "SELECT * from cajaspuc WHERE documento='" & TextBox_comprobante.Text & "' and tipodoc='" & TextBox_TIPO_COMPROBANTE.Text & "'"
            da_puc_COMP_DET = New MySqlDataAdapter(sql, conex)
            dt_puc_COMP_DET = New DataTable
            da_puc_COMP_DET.Fill(dt_puc_COMP_DET)
            Me.MetroGrid_detalle_comprobante.DataSource = dt_puc_COMP_DET
            Me.MetroGrid_detalle_comprobante.Columns(0).Visible = False

            Me.MetroGrid_detalle_comprobante.Columns(4).Visible = False
            Me.MetroGrid_detalle_comprobante.Columns(5).Visible = False
            Me.MetroGrid_detalle_comprobante.Columns(6).Visible = False
            Me.MetroGrid_detalle_comprobante.Columns(7).Visible = False
            Me.MetroGrid_detalle_comprobante.Columns(8).Visible = False
            Me.MetroGrid_detalle_comprobante.Columns(9).HeaderText = "Débito"
            Me.MetroGrid_detalle_comprobante.Columns(10).HeaderText = "Crédito"
            Me.MetroGrid_detalle_comprobante.Columns(11).Visible = False
            Me.MetroGrid_detalle_comprobante.Columns(13).Visible = False

            Me.MetroGrid_detalle_comprobante.Columns(14).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
            conex.Close()
            da_puc_COMP_DET.Dispose()
            dt_puc_COMP_DET.Dispose()
        End Try
        conex.Close()
        da_puc_COMP_DET.Dispose()
        dt_puc_COMP_DET.Dispose()

        Label_totalHABER.Text = 0
        Label_totalDEBE.Text = 0

        Try
            For i As Integer = 0 To MetroGrid_detalle_comprobante.RowCount - 1
                Label_totalDEBE.Text = CInt(Label_totalDEBE.Text) + CInt(MetroGrid_detalle_comprobante.Item("debe", i).Value)
                Label_totalHABER.Text = CInt(Label_totalHABER.Text) + CInt(MetroGrid_detalle_comprobante.Item("haber", i).Value)
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try


        If TextBox_TIPO_COMPROBANTE.Text = "Comprobante de Contabilidad" And Label_ESTADO.Text = "PENDIENTE" Then
            BunifuCards_asiento.Enabled = True
        End If

        Panel_GUARDAR.Visible = True
        MetroGrid_detalle_comprobante.ClearSelection()


    End Sub

    Private Sub Button_aagregar_siento_Click(sender As Object, e As EventArgs) Handles Button_aagregar_siento.Click

        If Me.COMBO_TERCERO_FILTRO.Text = Nothing Then MsgBox("Debe seleccionar un tercero", vbInformation) : Exit Sub

        If Me.ComboBox_cta_comp.Text = Nothing Then MsgBox("debe seleccionar una cuenta PUC", vbInformation) : Exit Sub

        Dim DETALLE_DOCUMENTO As String = ""


        ' SE SUMA POR EL DEBE
        If (RadioButton_debitar.Checked = True And Strings.Left(ComboBox_cta_comp.Text, 1) = 1) Or
           (RadioButton_debitar.Checked = True And Strings.Left(ComboBox_cta_comp.Text, 1) = 5) Or
           (RadioButton_debitar.Checked = True And Strings.Left(ComboBox_cta_comp.Text, 1) = 6) Then
            'contabilizar=================================================================================
            Try
                saldo = 0
                sql = "SELECT sum(CAST(debe AS SIGNED)) as debe, sum(CAST(haber AS SIGNED)) as haber FROM cajaspuc where left(CODcuenta,4)='" & Strings.Left(ComboBox_cta_comp.Text, 4) & "'"
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                da.Fill(dt)
                For Each row As DataRow In dt.Rows
                    entran = row.Item("debe")
                    salen = row.Item("haber")
                    saldo = CInt(entran) - CInt(salen)
                Next
            Catch ex As Exception
                saldo = 0
            End Try
            conex.Close()
            da.Dispose()
            dt.Dispose()

            PROD_DEBE = CInt(TextBox_valor.Text)  ' TOMO LA CANTIDAD DEL GRID Q ESTA RECORRIENDO
            PROD_SALDO = saldo  ' IGUALDO SALDO PROD CON EL SALDO CALCULADO EN BODEGA PRICIPAL
            PROD_SALDO = CInt(PROD_SALDO) + CInt(PROD_DEBE) ' PROD_ENTRAN   '  ACUMULO
            PROD_HABER = 0 ' POR QUE QUE ES UNA venta
            'REGISTRO EN PUC

            Dim TERCEROO As String = CStr(TXT_DOC_CLIENTE.Text) & "|" & CStr(TXT_NOM_CLIENTE.Text)

            sql = "INSERT INTO cajaspuc(Codcuenta, cuenta, tercero, Fecha, Documento, TipoDoc, Rol, SaldoAnt, debe, haber, Saldo, DETALLE, Estado, annoactual)" &
                           "VALUES ('" & ComboBox_cta_comp.Text & "','" & ComboBox_cta_comp_NOMBRE.Text & "','" & TERCEROO & "','" & DateTime.Now.ToShortDateString & "','" & TextBox_comprobante.Text & "','" & TextBox_TIPO_COMPROBANTE.Text & "','ENTRAN'," & saldo & "," & PROD_DEBE & "," & PROD_HABER & "," & PROD_SALDO & ",'" & DETALLE_DOCUMENTO & "','DESCARGADO','" & comex_annoactual & "')"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()
            '=======================================================
            '=======================================================


            TextBox_valor.Text = "0"

        End If


        'SE RESTA POR EL DEBE
        If (RadioButton_debitar.Checked = True And Strings.Left(ComboBox_cta_comp.Text, 1) = 2) Or
           (RadioButton_debitar.Checked = True And Strings.Left(ComboBox_cta_comp.Text, 1) = 3) Or
           (RadioButton_debitar.Checked = True And Strings.Left(ComboBox_cta_comp.Text, 1) = 4) Then
            'contabilizar=================================================================================
            Try
                saldo = 0
                sql = "SELECT sum(CAST(debe AS SIGNED)) as debe, sum(CAST(haber AS SIGNED)) as haber FROM cajaspuc where left(CODcuenta,4)='" & Strings.Left(ComboBox_cta_comp.Text, 4) & "'"
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                da.Fill(dt)
                For Each row As DataRow In dt.Rows
                    entran = row.Item("debe")
                    salen = row.Item("haber")
                    saldo = CInt(entran) - CInt(salen)
                Next
            Catch ex As Exception
                saldo = 0
            End Try
            conex.Close()
            da.Dispose()
            dt.Dispose()

            PROD_DEBE = CInt(TextBox_valor.Text)  ' TOMO LA CANTIDAD DEL GRID Q ESTA RECORRIENDO
            PROD_SALDO = saldo  ' IGUALDO SALDO PROD CON EL SALDO CALCULADO EN BODEGA PRICIPAL
            PROD_SALDO = CInt(PROD_SALDO) - CInt(PROD_DEBE) ' PROD_ENTRAN   '  ACUMULO
            PROD_HABER = 0 ' POR QUE QUE ES UNA venta
            'REGISTRO EN PUC
            Dim TERCEROO As String = CStr(TXT_DOC_CLIENTE.Text) & "|" & CStr(TXT_NOM_CLIENTE.Text)

            sql = "INSERT INTO cajaspuc(Codcuenta, cuenta, tercero, Fecha, Documento, TipoDoc, Rol, SaldoAnt, debe, haber, Saldo, DETALLE, Estado, annoactual)" &
                           "VALUES ('" & ComboBox_cta_comp.Text & "','" & ComboBox_cta_comp_NOMBRE.Text & "','" & TERCEROO & "','" & DateTime.Now.ToShortDateString & "','" & TextBox_comprobante.Text & "','" & TextBox_TIPO_COMPROBANTE.Text & "','ENTRAN'," & saldo & "," & PROD_DEBE & "," & PROD_HABER & "," & PROD_SALDO & ",'" & DETALLE_DOCUMENTO & "','DESCARGADO','" & comex_annoactual & "')"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()


            TextBox_valor.Text = "0"

        End If


        ' SE LE SUMA POR EL HABER
        If (RadioButton1.Checked = True And Strings.Left(ComboBox_cta_comp.Text, 1) = 2) Or
           (RadioButton1.Checked = True And Strings.Left(ComboBox_cta_comp.Text, 1) = 3) Or
           (RadioButton1.Checked = True And Strings.Left(ComboBox_cta_comp.Text, 1) = 4) Then
            'contabilizar=================================================================================
            Try
                saldo = 0
                sql = "SELECT sum(CAST(debe AS SIGNED)) as debe, sum(CAST(haber AS SIGNED)) as haber FROM cajaspuc where left(CODcuenta,4)='" & Strings.Left(ComboBox_cta_comp.Text, 4) & "'"
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                da.Fill(dt)
                For Each row As DataRow In dt.Rows
                    entran = row.Item("debe")
                    salen = row.Item("haber")
                    saldo = CInt(entran) - CInt(salen)
                Next
            Catch ex As Exception
                saldo = 0
            End Try
            conex.Close()
            da.Dispose()
            dt.Dispose()

            PROD_HABER = CInt(TextBox_valor.Text)  ' TOMO LA CANTIDAD DEL GRID Q ESTA RECORRIENDO
            PROD_SALDO = saldo  ' IGUALDO SALDO PROD CON EL SALDO CALCULADO EN BODEGA PRICIPAL
            PROD_SALDO = CInt(PROD_SALDO) + CInt(PROD_HABER) ' PROD_ENTRAN   '  ACUMULO
            PROD_DEBE = 0 ' POR QUE QUE ES UNA venta
            'REGISTRO EN PUC
            Dim TERCEROO As String = CStr(TXT_DOC_CLIENTE.Text) & "|" & CStr(TXT_NOM_CLIENTE.Text)

            sql = "INSERT INTO cajaspuc(Codcuenta, cuenta, tercero, Fecha, Documento, TipoDoc, Rol, SaldoAnt, debe, haber, Saldo, DETALLE, Estado, annoactual)" &
                           "VALUES ('" & ComboBox_cta_comp.Text & "','" & ComboBox_cta_comp_NOMBRE.Text & "','" & TERCEROO & "','" & DateTime.Now.ToShortDateString & "','" & TextBox_comprobante.Text & "','" & TextBox_TIPO_COMPROBANTE.Text & "','ENTRAN'," & saldo & "," & PROD_DEBE & "," & PROD_HABER & "," & PROD_SALDO & ",'" & DETALLE_DOCUMENTO & "','DESCARGADO','" & comex_annoactual & "')"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()
            '=======================================================



            TextBox_valor.Text = "0"


        End If

        ' SE LE RESTA POR EL HABER
        If (RadioButton1.Checked = True And Strings.Left(ComboBox_cta_comp.Text, 1) = 1) Or
           (RadioButton1.Checked = True And Strings.Left(ComboBox_cta_comp.Text, 1) = 5) Or
           (RadioButton1.Checked = True And Strings.Left(ComboBox_cta_comp.Text, 1) = 6) Then
            'contabilizar=================================================================================
            Try
                saldo = 0
                sql = "SELECT sum(CAST(debe AS SIGNED)) as debe, sum(CAST(haber AS SIGNED)) as haber FROM cajaspuc where left(CODcuenta,4)='" & Strings.Left(ComboBox_cta_comp.Text, 4) & "'"
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                da.Fill(dt)
                For Each row As DataRow In dt.Rows
                    entran = row.Item("debe")
                    salen = row.Item("haber")
                    saldo = CInt(entran) - CInt(salen)
                Next
            Catch ex As Exception
                saldo = 0
            End Try
            conex.Close()
            da.Dispose()
            dt.Dispose()

            PROD_HABER = CInt(TextBox_valor.Text)  ' TOMO LA CANTIDAD DEL GRID Q ESTA RECORRIENDO
            PROD_SALDO = saldo  ' IGUALDO SALDO PROD CON EL SALDO CALCULADO EN BODEGA PRICIPAL
            PROD_SALDO = CInt(PROD_SALDO) - CInt(PROD_HABER) ' PROD_ENTRAN   '  ACUMULO
            PROD_DEBE = 0 ' POR QUE QUE ES UNA venta
            'REGISTRO EN PUC
            Dim TERCEROO As String = CStr(TXT_DOC_CLIENTE.Text) & "|" & CStr(TXT_NOM_CLIENTE.Text)

            sql = "INSERT INTO cajaspuc(Codcuenta, cuenta, tercero, Fecha, Documento, TipoDoc, Rol, SaldoAnt, debe, haber, Saldo, DETALLE, Estado, annoactual)" &
                           "VALUES ('" & ComboBox_cta_comp.Text & "','" & ComboBox_cta_comp_NOMBRE.Text & "','" & TERCEROO & "','" & DateTime.Now.ToShortDateString & "','" & TextBox_comprobante.Text & "','" & TextBox_TIPO_COMPROBANTE.Text & "','ENTRAN'," & saldo & "," & PROD_DEBE & "," & PROD_HABER & "," & PROD_SALDO & ",'" & DETALLE_DOCUMENTO & "','DESCARGADO','" & comex_annoactual & "')"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()

            '=======================================================



            TextBox_valor.Text = "0"

        End If



        Try
            sql = "SELECT * from cajaspuc WHERE documento='" & TextBox_comprobante.Text & "' and tipodoc='" & TextBox_TIPO_COMPROBANTE.Text & "'"
            da_puc_COMP_DET = New MySqlDataAdapter(sql, conex)
            dt_puc_COMP_DET = New DataTable
            da_puc_COMP_DET.Fill(dt_puc_COMP_DET)
            Me.MetroGrid_detalle_comprobante.DataSource = dt_puc_COMP_DET
            Me.MetroGrid_detalle_comprobante.Columns(0).Visible = False

            Me.MetroGrid_detalle_comprobante.Columns(4).Visible = False
            Me.MetroGrid_detalle_comprobante.Columns(5).Visible = False
            Me.MetroGrid_detalle_comprobante.Columns(6).Visible = False
            Me.MetroGrid_detalle_comprobante.Columns(7).Visible = False
            Me.MetroGrid_detalle_comprobante.Columns(8).Visible = False
            Me.MetroGrid_detalle_comprobante.Columns(9).HeaderText = "Débito"
            Me.MetroGrid_detalle_comprobante.Columns(10).HeaderText = "Crédito"
            Me.MetroGrid_detalle_comprobante.Columns(11).Visible = False
            Me.MetroGrid_detalle_comprobante.Columns(13).Visible = False

            Me.MetroGrid_detalle_comprobante.Columns(14).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
            conex.Close()
            da_puc_COMP_DET.Dispose()
            dt_puc_COMP_DET.Dispose()
        End Try
        conex.Close()
        da_puc_COMP_DET.Dispose()
        dt_puc_COMP_DET.Dispose()

        Label_totalHABER.Text = 0
        Label_totalDEBE.Text = 0

        Try
            For i As Integer = 0 To MetroGrid_detalle_comprobante.RowCount - 1
                Label_totalDEBE.Text = CInt(Label_totalDEBE.Text) + CInt(MetroGrid_detalle_comprobante.Item("debe", i).Value)
                Label_totalHABER.Text = CInt(Label_totalHABER.Text) + CInt(MetroGrid_detalle_comprobante.Item("haber", i).Value)
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        MetroGrid_detalle_comprobante.ClearSelection()


        ComboBox_cta_comp.SelectedItem = Nothing
        ComboBox_cta_comp_NOMBRE.SelectedItem = Nothing

    End Sub

    Private Sub MetroGrid_detalle_comprobante_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid_detalle_comprobante.CellContentClick

    End Sub

    Private Sub MetroGrid_detalle_comprobante_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid_detalle_comprobante.CellClick
        Dim row As DataGridViewRow = MetroGrid_detalle_comprobante.CurrentRow
        COD_asiento = CStr(row.Cells("CONS").Value)

        detalle_asiento = Strings.Split(CStr(row.Cells("detalle").Value), "|")



    End Sub

    Private Sub Button_eliminar_asiento_Click(sender As Object, e As EventArgs) Handles Button_eliminar_asiento.Click
        If COD_asiento = "" Then Exit Sub

        Try
            sql = "delete FROM cajaspuc WHERE CONS=" & CInt(COD_asiento) & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()


        If UBound(detalle_asiento) = 3 Then
            Try
                sql = "delete FROM BODEGA_PRINCIPAL WHERE documento=" & CInt(TextBox_comprobante.Text) & " and tipodocumento='Comprobante de Contabilidad' and codproducto='" & detalle_asiento(3) & "'"
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                da.Fill(dt)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da.Dispose()
            dt.Dispose()
            conex.Close()
        End If




        Try
            sql = "SELECT * from cajaspuc WHERE documento='" & TextBox_comprobante.Text & "' and tipodoc='" & TextBox_TIPO_COMPROBANTE.Text & "'"
            da_puc_COMP_DET = New MySqlDataAdapter(sql, conex)
            dt_puc_COMP_DET = New DataTable
            da_puc_COMP_DET.Fill(dt_puc_COMP_DET)
            Me.MetroGrid_detalle_comprobante.DataSource = dt_puc_COMP_DET
            Me.MetroGrid_detalle_comprobante.Columns(0).Visible = False

            Me.MetroGrid_detalle_comprobante.Columns(4).Visible = False
            Me.MetroGrid_detalle_comprobante.Columns(5).Visible = False
            Me.MetroGrid_detalle_comprobante.Columns(6).Visible = False
            Me.MetroGrid_detalle_comprobante.Columns(7).Visible = False
            Me.MetroGrid_detalle_comprobante.Columns(8).Visible = False
            Me.MetroGrid_detalle_comprobante.Columns(9).HeaderText = "Débito"
            Me.MetroGrid_detalle_comprobante.Columns(10).HeaderText = "Crédito"
            Me.MetroGrid_detalle_comprobante.Columns(11).Visible = False
            Me.MetroGrid_detalle_comprobante.Columns(13).Visible = False

            Me.MetroGrid_detalle_comprobante.Columns(14).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
            conex.Close()
            da_puc_COMP_DET.Dispose()
            dt_puc_COMP_DET.Dispose()
        End Try
        conex.Close()
        da_puc_COMP_DET.Dispose()
        dt_puc_COMP_DET.Dispose()

        Label_totalHABER.Text = 0
        Label_totalDEBE.Text = 0

        Try
            For i As Integer = 0 To MetroGrid_detalle_comprobante.RowCount - 1
                Label_totalDEBE.Text = CInt(Label_totalDEBE.Text) + CInt(MetroGrid_detalle_comprobante.Item("debe", i).Value)
                Label_totalHABER.Text = CInt(Label_totalHABER.Text) + CInt(MetroGrid_detalle_comprobante.Item("haber", i).Value)
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        COD_asiento = ""
        MetroGrid_detalle_comprobante.ClearSelection()
    End Sub

    Private Sub TextBox_debe_TextChanged(sender As Object, e As EventArgs)
        TextBox_valor.Text = "0"
    End Sub

    Private Sub TextBox_debe_KeyPress(sender As Object, e As KeyPressEventArgs)
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""

    End Sub

    Private Sub TextBox_haber_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox_haber_KeyPress(sender As Object, e As KeyPressEventArgs)
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""
        If Me.TextBox_valor.Text = "" Then Me.TextBox_valor.Text = "0"



        Me.TextBox_valor.Text = FormatNumber(Me.TextBox_valor.Text, 2)
        Me.TextBox_valor.Select(Me.TextBox_valor.Text.Length, 2)
    End Sub

    Private Sub MetroTabPage2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button_ANULAR_mov_Click(sender As Object, e As EventArgs) Handles Button_ANULAR.Click

        Dim RTA As String
        RTA = MsgBox("Desea anular", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If RTA = 6 Then
            sql = "DELETE FROM cajaspuc WHERE DOCUMENTO='" & TextBox_comprobante.Text & "' AND TIPODOC='" & TextBox_TIPO_COMPROBANTE.Text & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()

            MsgBox("Se eliminaron los registros contables de " & TextBox_TIPO_COMPROBANTE.Text & " " & TextBox_comprobante.Text, vbInformation)


            If TextBox_TIPO_COMPROBANTE.Text = "Comprobante de Contabilidad" Then
                sql = "DELETE FROM comprobantes WHERE cons =" & TextBox_comprobante.Text & ""
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                Try
                    da.Fill(dt)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                da.Dispose()
                dt.Dispose()
                conex.Close()
                MsgBox("Se eliminó el comprobante   No. " & TextBox_comprobante.Text, vbInformation)

            End If



            Button_regresar_comp_Click(Nothing, Nothing)

            MetroGrid_comprobantes.DataSource = Nothing
        End If



    End Sub

    Private Sub ComboBox_MEs_filtro_comp_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub TextBox_BUSCAR_PROV_TextChanged(sender As Object, e As EventArgs) Handles TextBox_BUSCAR_PROV.TextChanged

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub ComboBox_MEs_filtro_comp_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox_MEs_filtro_comp.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub MetroComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Timer_LOAD_COMPROBANTES_Tick(sender As Object, e As EventArgs) Handles Timer_LOAD_COMPROBANTES.Tick
        Timer_LOAD_COMPROBANTES.Enabled = False
        Dim DOCU As String() = Me.MetroComboBox1.Text.Split("|")
        Cursor.Current = Cursors.WaitCursor

        If DOCU(1) <> "Comprobante de Contabilidad" Then
            DOCU(1) = DOCU(1).ToUpper
            Try
                If ComboBox_MEs_filtro_comp.Text <> "" Then sql = "SELECT distinct(documento) as cons, tipodoc, tercero, fecha, ESTADO FROM cajaspuc where tipodoc='" & DOCU(1) & "' and month(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & mes_num_text_general & "' group by DOCUMENTO ORDER BY DOCUMENTO DESC"
                If COMBOBOX_FECHA_FILTRO.Text <> "" Then sql = "SELECT distinct(documento) as cons, tipodoc, tercero, fecha, ESTADO FROM cajaspuc where tipodoc='" & DOCU(1) & "' and fecha='" & COMBOBOX_FECHA_FILTRO.Text & "' group by DOCUMENTO ORDER BY DOCUMENTO DESC"
                da_det_comp = New MySqlDataAdapter(sql, conex)
                dt_det_comp = New DataTable
                da_det_comp.Fill(dt_det_comp)
                Me.MetroGrid_comprobantes.DataSource = dt_det_comp

            Catch ex As Exception
                MsgBox(ex.Message)
                conex.Close()
                da_puc.Dispose()
                dt_det_comp.Dispose()
            End Try
            conex.Close()
            da_det_comp.Dispose()
            dt_det_comp.Dispose()

        End If


        If DOCU(1) = "Comprobante de Contabilidad" Then
            Try
                If ComboBox_MEs_filtro_comp.Text <> "" Then sql = "SELECT * FROM comprobantes WHERE month(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & mes_num_text_general & "' ORDER BY CONS DESC"
                If COMBOBOX_FECHA_FILTRO.Text <> "" Then sql = "SELECT * FROM comprobantes WHERE fecha='" & COMBOBOX_FECHA_FILTRO.Text & "' ORDER BY CONS DESC"
                da_det_comp = New MySqlDataAdapter(sql, conex)
                dt_det_comp = New DataTable
                da_det_comp.Fill(dt_det_comp)
                Me.MetroGrid_comprobantes.DataSource = dt_det_comp

            Catch ex As Exception
                MsgBox(ex.Message)
                conex.Close()
                da_puc.Dispose()
                dt_det_comp.Dispose()
            End Try
            conex.Close()
            da_det_comp.Dispose()
            dt_det_comp.Dispose()
        End If

        MetroGrid_comprobantes.ClearSelection()
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button_exportar.Click


        Try
            sql = "SELECT CodCuenta, Cuenta, tercero, debe, haber, detalle from cajaspuc WHERE documento='" & TextBox_comprobante.Text & "' and tipodoc='" & TextBox_TIPO_COMPROBANTE.Text & "'"
            da_puc_COMP_DET = New MySqlDataAdapter(sql, conex)
            dt_puc_COMP_DET = New DataTable
            da_puc_COMP_DET.Fill(dt_puc_COMP_DET)
            Me.MetroGrid1.DataSource = dt_puc_COMP_DET



        Catch ex As Exception
            MsgBox(ex.Message)
            conex.Close()
            da_puc_COMP_DET.Dispose()
            dt_puc_COMP_DET.Dispose()
        End Try
        conex.Close()
        da_puc_COMP_DET.Dispose()
        dt_puc_COMP_DET.Dispose()

        Label_totalHABER.Text = 0
        Label_totalDEBE.Text = 0

        Try
            For i As Integer = 0 To MetroGrid1.RowCount - 1
                Label_totalDEBE.Text = CInt(Label_totalDEBE.Text) + CInt(MetroGrid1.Item("debe", i).Value)
                Label_totalHABER.Text = CInt(Label_totalHABER.Text) + CInt(MetroGrid1.Item("haber", i).Value)
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        MetroGrid1.ClearSelection()


        Try

            'Intentar generar el documento.
            Dim doc As New Document(PageSize.A4, 10, 20, 10, 10)

            'Path que guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Comprobante " & TextBox_TIPO_COMPROBANTE.Text & " " & TextBox_comprobante.Text & ".pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)

            PdfWriter.GetInstance(doc, file)

            doc.Open()
            ExportarDatosPDF(doc)
            doc.Close()

            Process.Start(filename)

        Catch ex As Exception
            'Si el intento es fallido, mostrar MsgBox.
            MessageBox.Show("No se puede generar el documento PDF, Cierre los documentos PDF generados anteriormente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Dim psi As System.Diagnostics.ProcessStartInfo = New System.Diagnostics.ProcessStartInfo()
        'psi.UseShellExecute = True
        'psi.Verb = "print"
        'psi.FileName = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\factura " & Form_VENTAS_NUEVA.Label_consecutivo.Text & ".pdf"
        'psi.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
        'psi.ErrorDialog = False
        'psi.Arguments = "/p"
        'Dim p As System.Diagnostics.Process = System.Diagnostics.Process.Start(psi)
        'p.WaitForInputIdle()

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

        Timer_LOAD_COMPROBANTES.Enabled = True

    End Sub

    Public Sub ExportarDatosPDF(ByVal document As Document)
        Dim CANT_FILAS As Integer = 0
        'Se crea un objeto PDFTable con el numero de columnas del DataGridView.
        Dim datatable As New PdfPTable(MetroGrid1.ColumnCount)
        'Se asignan algunas propiedades para el diseño del PDF.
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(MetroGrid1)

        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER

        Dim contentFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 12, iTextSharp.text.Font.BOLD)
        Dim DIRFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 6, iTextSharp.text.Font.BOLD)
        Dim rowFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 6, iTextSharp.text.Font.BOLD)

        Dim FIRMAFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 5, iTextSharp.text.Font.BOLD)
        Dim totalFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 8, iTextSharp.text.Font.BOLDITALIC)
        Dim totaltotalFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 9, iTextSharp.text.Font.BOLDITALIC)
        Dim CLIENTEFONT = iTextSharp.text.FontFactory.GetFont("Arial Black", 7, iTextSharp.text.Font.BOLDITALIC)

        'Se crea el encabezado en el PDF.
        Dim PDF_COMEX As New Paragraph(comex_nombrecomercial, contentFont) : PDF_COMEX.Alignment = 2
        PDF_COMEX.Font = contentFont
        Dim PDF_COMEX_DIR As New Paragraph(comex_dircomercio + " " + comex_ciudad + " Tel: " + comex_tels, DIRFont) : PDF_COMEX_DIR.Alignment = 2
        PDF_COMEX_DIR.Font = DIRFont

        Dim PDF_CONSECUTIVO As New Paragraph("No. " & TextBox_comprobante.Text, New Font(Font.Name = "Arial Black", 8, Font.Bold = True)) : PDF_CONSECUTIVO.Alignment = 2
        Dim encabezado As New Paragraph(TextBox_TIPO_COMPROBANTE.Text, New Font(Font.Name = "Arial Black", 8, Font.Bold = True)) : encabezado.Alignment = 2
        Dim encabezado2 As New Paragraph("Fecha:" + TextBox_fecha_comprobante.Text, New Font(Font.Name = "Arial Balck", 8, Font.Bold)) : encabezado2.Alignment = 2

        Dim glue = New Chunk(New VerticalPositionMark())
        Dim texto_CLIENTE As New Paragraph("TERCERO: " + COMBO_TERCERO_FILTRO.Text + Chr(13) & "Documento/NIT: " + TXT_DOC_CLIENTE.Text + Chr(13) + TXT_NOM_CLIENTE.Text, CLIENTEFONT)
        texto_CLIENTE.Add(New Chunk(glue))
        texto_CLIENTE.Add("NIT:" & comex_nit & " " & comex_regimen)
        texto_CLIENTE.SpacingBefore = 5


        Dim texto_dirCLIENTE As New Paragraph("  ", CLIENTEFONT)
        texto_dirCLIENTE.Add(New Chunk(glue))
        texto_dirCLIENTE.Add(" ")


        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To MetroGrid1.ColumnCount - 1
            Dim HEADERCELLFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 8, iTextSharp.text.Font.BOLD)

            Dim cell_TITLE As New PdfPCell
            cell_TITLE.Phrase = New Phrase(MetroGrid1.Columns(i).HeaderText, HEADERCELLFont)
            cell_TITLE.HorizontalAlignment = Element.ALIGN_CENTER
            cell_TITLE.BackgroundColor = BaseColor.LIGHT_GRAY
            datatable.AddCell(cell_TITLE)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 0
        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To MetroGrid1.RowCount - 1
            For j As Integer = 0 To MetroGrid1.ColumnCount - 1
                Dim cell As New PdfPCell
                cell.Phrase = New Phrase(MetroGrid1(j, i).FormattedValue.ToString, rowFont)
                If j = 0 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 1 Then cell.HorizontalAlignment = Element.ALIGN_CENTER
                If j = 2 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 3 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 4 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 5 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 6 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 7 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                cell.Border = 0
                cell.BorderWidthRight = 0.3F
                cell.BorderColorRight = BaseColor.BLACK
                datatable.AddCell(cell)
            Next
            datatable.CompleteRow()
        Next


        '  CONTAR LAS FILAS DE LA GRILLA GENERADA, 
        ' ESTABLECER CUANTAS GRILLAS SE NECESITAN PARA LLEGAR A MEDIA CARTA Y CARTA,
        ' AGRAGAR LLASNECESARIAS PARA LLENAR EL ESPACION Q FALTA
        CANT_FILAS = MetroGrid1.RowCount

        If CANT_FILAS <= (19 - CANT_FILAS) Then
            For i As Integer = 0 To (15 - CANT_FILAS)
                For j As Integer = 0 To MetroGrid1.ColumnCount - 1

                    Dim cell As New PdfPCell
                    cell.Phrase = New Phrase(" ", New Font(Font.Name = "Arial Narrow", 6, Font.Bold = False))
                    If j = 0 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                    If j = 1 Then cell.HorizontalAlignment = Element.ALIGN_CENTER
                    If j = 2 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                    If j = 3 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                    If j = 4 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                    If j = 5 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                    If j = 6 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                    If j = 7 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                    cell.Border = 0
                    cell.Border = 0
                    cell.BorderWidthRight = 0.3F
                    cell.BorderColorRight = BaseColor.BLACK
                    datatable.AddCell(cell)
                Next
                datatable.CompleteRow()
            Next
        End If

        'Dim descuento As New Paragraph("", New Font(Font.Name = "Arial Black", 7, Font.Bold = True))
        'descuento.Add(New Chunk(glue))
        'descuento.Add("Descuento ")
        'descuento.IndentationLeft = 350
        'descuento.Alignment = Element.ALIGN_RIGHT
        'descuento.Add(New Chunk(glue))
        'descuento.Add(TextBox_DESCUENTO.Text & " ")
        'descuento.SpacingBefore = 3

        'Dim subtotal As New Paragraph("", totalFont)
        'subtotal.Add(New Chunk(glue))
        'subtotal.Add("SubTotal ")
        'subtotal.IndentationLeft = 372
        'subtotal.Alignment = Element.ALIGN_RIGHT
        'subtotal.Add(New Chunk(glue))
        'subtotal.Add(Form_VENTAS_NUEVA.TextBox_SUBTOTAL.Text & " ")

        'Dim impuestos As New Paragraph("", totalFont)
        'impuestos.Add(New Chunk(glue))
        'impuestos.Add("Impuestos ")
        'impuestos.IndentationLeft = 347
        'impuestos.Alignment = Element.ALIGN_RIGHT
        'impuestos.Add(New Chunk(glue))
        'impuestos.Add(Form_VENTAS_NUEVA.TextBox_Total_impuestos.Text & " ")

        Dim total_fac As New Paragraph("", totaltotalFont)
        total_fac.Add(New Chunk(glue))
        total_fac.Add("Total Debe =====> $ " & Label_totalDEBE.Text & "  Total Haber: =====> $ " & Label_totalHABER.Text)
        total_fac.IndentationLeft = 300
        total_fac.Alignment = Element.ALIGN_RIGHT
        total_fac.Add(New Chunk(glue))
        total_fac.Add("  ")

        Dim PDF_observaciones As New Paragraph("Observaciones:", FIRMAFont) : PDF_observaciones.Alignment = 0

        'Dim saltoDeLinea = New Paragraph("                                                                                          ")
        Dim saltodelinea As New Paragraph("                            ", FIRMAFont) : saltodelinea.Alignment = 0

        Dim PDF_FIRMACLIENTE As New Paragraph("    FIRMA CLIENTE:____________________                           FIRMA VENDEDOR:________________________", FIRMAFont) : PDF_FIRMACLIENTE.Alignment = 0
        PDF_FIRMACLIENTE.Font = FIRMAFont

        Dim texto2 As New Phrase("    Fecha de Impresión: " + Now.Date(), New Font(Font.Name = "Arial Narrow", 4, Font.Bold))
        Dim texto3 As New Phrase("    Generado Por :" + usrnom, New Font(Font.Name = "Arial Narrow", 4, Font.Bold))

        'LOGO
        If comex_logo <> "" Then
            Dim imagelogogopdf As iTextSharp.text.Image 'Declaracion de una imagen

            imagelogogopdf = iTextSharp.text.Image.GetInstance("c:\miclickderecho\logo.png") 'Dirreccion a la imagen que se hace referencia
            imagelogogopdf.Alignment = Element.ALIGN_RIGHT
            imagelogogopdf.SetAbsolutePosition(10, 785) 'Posicion en el eje cartesiano
            imagelogogopdf.ScaleAbsoluteWidth(140) 'Ancho de la imagen
            imagelogogopdf.ScaleAbsoluteHeight(55) 'Altura de la imagen
            document.Add(imagelogogopdf) ' Agrega la imagen al documento
        End If
        'Se agrega el PDFTable al documento.

        Dim CUADRO1 As iTextSharp.text.Image 'Declaracion de una imagen
        CUADRO1 = iTextSharp.text.Image.GetInstance("c:\miclickderecho\cuadro_para_portadas2.png") 'Dirreccion a la imagen que se hace referencia
        CUADRO1.Alignment = Element.ALIGN_RIGHT
        CUADRO1.SetAbsolutePosition(410, 762) 'Posicion en el eje cartesiano
        CUADRO1.ScaleAbsoluteWidth(168) 'Ancho de la imagen
        CUADRO1.ScaleAbsoluteHeight(43) 'Altura de la imagen
        document.Add(CUADRO1) ' Agrega la imagen al documento

        Dim CUADRO_cliente As iTextSharp.text.Image 'Declaracion de una imagen
        CUADRO_cliente = iTextSharp.text.Image.GetInstance("c:\miclickderecho\cuadro_para_portadas2.png") 'Dirreccion a la imagen que se hace referencia
        CUADRO_cliente.Alignment = Element.ALIGN_LEFT
        CUADRO_cliente.SetAbsolutePosition(5, 714) 'Posicion en el eje cartesiano
        CUADRO_cliente.ScaleAbsoluteWidth(350) 'Ancho de la imagen
        CUADRO_cliente.ScaleAbsoluteHeight(54) 'Altura de la imagen
        document.Add(CUADRO_cliente) ' Agrega la imagen al documento

        'Dim CUADRO_subtotal As iTextSharp.text.Image 'Declaracion de una imagen
        'CUADRO_subtotal = iTextSharp.text.Image.GetInstance("c:\miclickderecho\fondopanel.png") 'Dirreccion a la imagen que se hace referencia
        'CUADRO_subtotal.Alignment = Element.ALIGN_LEFT
        'CUADRO_subtotal.SetAbsolutePosition(6, 500) 'Posicion en el eje cartesiano
        'CUADRO_subtotal.ScaleAbsoluteWidth(574) 'Ancho de la imagen
        'CUADRO_subtotal.ScaleAbsoluteHeight(200) 'Altura de la imagen

        'Dim CUADRO_obs As iTextSharp.text.Image 'Declaracion de una imagen
        'CUADRO_obs = iTextSharp.text.Image.GetInstance("c:\miclickderecho\cuadro_para_portadas2.png") 'Dirreccion a la imagen que se hace referencia
        'CUADRO_obs.Alignment = Element.ALIGN_LEFT
        'CUADRO_obs.SetAbsolutePosition(5, 450) 'Posicion en el eje cartesiano
        'CUADRO_obs.ScaleAbsoluteWidth(574) 'Ancho de la imagen
        'CUADRO_obs.ScaleAbsoluteHeight(40) 'Altura de la imagen

        'document.Add(CUADRO_subtotal) ' Agrega la imagen al documento
        document.Add(PDF_COMEX)
        document.Add(PDF_COMEX_DIR)
        document.Add(encabezado)
        document.Add(PDF_CONSECUTIVO)
        document.Add(encabezado2)
        document.Add(texto_CLIENTE)
        document.Add(texto_dirCLIENTE)
        'document.Add(texto_mailCLIENTE)
        datatable.SpacingBefore = 15
        document.Add(datatable)
        'document.Add(descuento)
        'subtotal.SpacingBefore = 5
        'document.Add(subtotal)
        'document.Add(CUADRO_obs)
        'document.Add(impuestos)
        document.Add(total_fac)
        document.Add(saltodelinea)
        document.Add(PDF_FIRMACLIENTE)
        document.Add(texto2)
        document.Add(texto3)
    End Sub

    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        'funcion para obtener el tamaño de la columnas del datagridview
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function

    Private Sub Button_regresar_comp_Click(sender As Object, e As EventArgs) Handles Button_regresar.Click
        Me.Panel_comprobantes.Visible = True
        Panel5.Visible = True
        Panel_general.Visible = True
        BunifuCards_asiento.Enabled = True
        Panel_GUARDAR.Visible = False


        Panel_datos_comprobantes.Visible = False

        TextBox_comprobante.Text = ""

        Label_ESTADO.Visible = False
        Timer_LOAD_COMPROBANTES.Enabled = True

    End Sub

    Private Sub TextBox_TIPO_COMPROBANTE_TextChanged(sender As Object, e As EventArgs) Handles TextBox_TIPO_COMPROBANTE.TextChanged

    End Sub

    Private Sub Timer_CLIENTE_Tick(sender As Object, e As EventArgs) Handles Timer_CLIENTE.Tick
        Timer_CLIENTE.Enabled = False

    End Sub

    Private Sub TextBox_fecha_comprobante_TextChanged(sender As Object, e As EventArgs) Handles TextBox_fecha_comprobante.TextChanged

    End Sub

    Private Sub TextBox_comprobante_TextChanged(sender As Object, e As EventArgs) Handles TextBox_comprobante.TextChanged

    End Sub

    Private Sub ComboBox_cuentas_pnal_filtro_SelectionChangeCommitted(sender As Object, e As EventArgs)
        dt_combo_puc_filtro.Select("CONS=1")

    End Sub

    Private Sub Button_guardar_Click(sender As Object, e As EventArgs) Handles Button_guardar.Click


        If Label_ESTADO.Text = "NUEVO" Then

            'consecutivo 
            consecutivo = 0
            cmd.Connection = conex
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select max(CONS) +1 from COMPROBANTES"
            conex.Open()
            Try
                dr = cmd.ExecuteReader()
                If dr.Read() Then
                    consecutivo = dr(0)
                Else
                    consecutivo = 1
                End If
            Catch ex As Exception
                consecutivo = 1
                conex.Close()
            End Try
            conex.Close()

            TextBox_comprobante.Text = consecutivo
            sql = "INSERT INTO COMPROBANTES(CONS, fecha, TIPOCOMPROBANTE, OBSERVACIONES, VALOR, EMPLEADO, DOCCRUCE, TIPODOCCRUCE, ESTADO)" &
                    "VALUES ('" & TextBox_comprobante.Text & "','" & TextBox_fecha_comprobante.Text & "','" & TextBox_TIPO_COMPROBANTE.Text & "','" & TextBox_OBSERVACION.Text & "','" & Label_totalDEBE.Text & "','" & usrnom & "','','','GUARDADO')"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                Me.Cursor = Cursors.Default

                MsgBox(ex.ToString)
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()


            BunifuCards_asiento.Enabled = True
            Panel_datos_comprobantes.Visible = True
            Panel5.Visible = False

            Me.Label_ESTADO.Text = "GUARDADO"
            Me.Label_ESTADO.Visible = True


            Button_MODIFICAR_Click(Nothing, Nothing)
            BunifuCards_asiento.Enabled = True
            BunifuCards_TERCERO.Enabled = True

            Exit Sub
        End If


        If Label_ESTADO.Text = "GUARDADO" Then
            sql = "UPDATE COMPROBANTES SET fecha='" & TextBox_fecha_comprobante.Text & "', OBSERVACIONES='" & TextBox_OBSERVACION.Text & "', VALOR='" & Label_totalDEBE.Text & "', ESTADO='GUARDADO' WHERE CONS=" & TextBox_comprobante.Text & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                Me.Cursor = Cursors.Default

                MsgBox(ex.ToString)
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()

            Button_ANULAR.Enabled = False
            Button_guardar.Enabled = False

            TextBox_OBSERVACION.Enabled = False
            BunifuCards_asiento.Visible = False

            MsgBox("Se guardó correctamente.", vbInformation)
            BunifuCards_asiento.Enabled = True
            BunifuCards_TERCERO.Enabled = True
        End If

    End Sub

    Private Sub MetroGrid_comprobantes_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid_comprobantes.CellContentClick

    End Sub

    Private Sub TextBox_nrodoc_KeyPress(sender As Object, e As KeyPressEventArgs)
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles MetroComboBox1.SelectionChangeCommitted




    End Sub

    Private Sub Label_ESTADO_Click(sender As Object, e As EventArgs) Handles Label_ESTADO.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox_OBSERVACION.TextChanged

    End Sub

    Private Sub MetroDateTime3_ValueChanged(sender As Object, e As EventArgs) Handles MetroDateTime3.ValueChanged
        Me.TextBox_fecha_comprobante.Text = MetroDateTime3.Value.ToShortDateString

    End Sub

    Private Sub Button_MODIFICAR_Click(sender As Object, e As EventArgs) Handles Button_MODIFICAR.Click


        TextBox_valor.Enabled = True
        BunifuCards_asiento.Visible = True
        BunifuCards_asiento.Enabled = True
        ComboBox_cta_comp.Enabled = True
        ComboBox_cta_comp_NOMBRE.Enabled = True

        TextBox_OBSERVACION.Enabled = True


        Button_guardar.Enabled = True
        Button_ANULAR.Enabled = True

    End Sub

    Private Sub MetroComboBox_producto_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox_TIPO_COMPROBANTE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_TIPO_COMPROBANTE.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub TextBox_fecha_comprobante_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_fecha_comprobante.KeyPress
        e.KeyChar = ""

    End Sub

    Private Sub TextBox_comprobante_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_comprobante.KeyPress

        e.KeyChar = ""

    End Sub

    Private Sub MetroGrid_comprobantes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid_comprobantes.CellClick
        Dim row As DataGridViewRow = MetroGrid_comprobantes.CurrentRow

        Dim DOCU As String() = Me.MetroComboBox1.Text.Split("|")



        COD_comprobante = CStr(row.Cells("cons").Value)
        TextBox_comprobante.Text = CStr(row.Cells("cons").Value)


        If DOCU(1) = "Comprobante de Contabilidad" Then
            TextBox_TIPO_COMPROBANTE.Text = CStr(row.Cells("tipoCOMPROBANTE").Value)
            TextBox_fecha_comprobante.Text = CStr(row.Cells("fecha").Value)
            Label_ESTADO.Text = CStr(row.Cells("ESTADO").Value)
            TextBox_OBSERVACION.Text = CStr(row.Cells("OBSERVACIONES").Value)

        End If



        If DOCU(1) <> "Comprobante de Contabilidad" Then
            TextBox_TIPO_COMPROBANTE.Text = CStr(row.Cells("tipodoc").Value)
            TextBox_fecha_comprobante.Text = CStr(row.Cells("fecha").Value)
            Label_ESTADO.Text = CStr(row.Cells("ESTADO").Value)
            'TextBox_OBSERVACION.Text = CStr(row.Cells("OBSERVACIONES").Value)

        End If


    End Sub

    Private Sub MetroComboBox_producto_SelectedValueChanged(sender As Object, e As EventArgs)
        Timer_prod_data.Enabled = True

    End Sub

    Private Sub MetroGrid_comprobantes_CancelRowEdit(sender As Object, e As QuestionEventArgs) Handles MetroGrid_comprobantes.CancelRowEdit

    End Sub

    Private Sub TextBox_BUSCAR_PROV_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_BUSCAR_PROV.KeyDown
        If e.KeyCode = "13" Then

            If TextBox_BUSCAR_PROV.Text = "" And RadioButton_NIT_PROV.Checked = True Then

                Exit Sub
            End If


            ''LLENADO contactos
            Try
                If RadioButton_NIT_PROV.Checked = True Then sql = "SELECT documento, nombre FROM proveedores WHERE documento='" & TextBox_BUSCAR_PROV.Text & "'"
                If RadioButton_NOM_PROV.Checked = True Then sql = "SELECT documento, nombre FROM proveedores WHERE nombre like '%" & TextBox_BUSCAR_PROV.Text & "%'"

                da_contact_fitro_CC = New MySqlDataAdapter(sql, conex)
                dT_contact_fitro_CC = New DataTable
                da_contact_fitro_CC.Fill(dT_contact_fitro_CC)
                Me.COMBO_TERCERO_FILTRO.DataSource = dT_contact_fitro_CC.DefaultView
                Me.COMBO_TERCERO_FILTRO.DisplayMember = "nombre"
                Me.COMBO_TERCERO_FILTRO.ValueMember = "documento"
                Me.COMBO_TERCERO_FILTRO.AutoCompleteSource = AutoCompleteSource.ListItems
                Me.COMBO_TERCERO_FILTRO.AutoCompleteMode = AutoCompleteMode.Suggest
                Me.COMBO_TERCERO_FILTRO.SelectedItem = Nothing


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da_contact_fitro_CC.Dispose()
            dT_contact_fitro_CC.Dispose()
            conex.Close()



            COMBO_TERCERO_FILTRO.Focus()

            COMBO_TERCERO_FILTRO.DroppedDown = True

            Cursor.Current = Cursors.Default
        End If
    End Sub

    Private Sub ComboBox_MEs_filtro_comp_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_MEs_filtro_comp.SelectionChangeCommitted
        COMBOBOX_FECHA_FILTRO.Text = ""

        mes_num = DateTime.ParseExact(Me.ComboBox_MEs_filtro_comp.Text, "MMMM", CultureInfo.CurrentCulture).Month
        mes_num_text = CStr(mes_num)
        If mes_num <= 9 Then mes_num_text = "0" & CStr(mes_num)


        'LOAD_VENTAS_MES()



        Try
            sql = "SELECT distinct FECHA FROM COMPROBANTES 
        where MONTH(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & mes_num_text & "' AND YEAR(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & NumericUpDown_anoventa.Value & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.COMBOBOX_FECHA_FILTRO.DataSource = dt.DefaultView
            Me.COMBOBOX_FECHA_FILTRO.DisplayMember = "FECHA"
            Me.COMBOBOX_FECHA_FILTRO.ValueMember = "FECHA"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        COMBOBOX_FECHA_FILTRO.SelectedItem = Nothing

    End Sub
End Class