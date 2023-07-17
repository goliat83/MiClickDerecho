Public Class Form_contadocs
    Public da_COMBO_TIPOdocs_MI As MySqlDataAdapter
    Public dt_combo_TIPOdocs_MI As DataTable

    Public da_COMBO_TIPOdocs_CE As MySqlDataAdapter
    Public dt_combo_TIPOdocs_CE As DataTable

    Public da_COMBO_TIPOdocs_RC As MySqlDataAdapter
    Public dt_combo_TIPOdocs_RC As DataTable

    Public da_info_CG As MySqlDataAdapter
    Public dt_info_CG As DataTable

    Public da_info_MI As MySqlDataAdapter
    Public dt_info_MI As DataTable

    Public da_info_CE As MySqlDataAdapter
    Public dt_info_CE As DataTable

    Public da_info_RC As MySqlDataAdapter
    Public dt_info_RC As DataTable

    Public da_cat_ventas As MySqlDataAdapter
    Public dt_cat_ventas As DataTable

    Public da_medios_ventas As MySqlDataAdapter
    Public dt_medios_ventas As DataTable

    Public da_medios_compras As MySqlDataAdapter
    Public dt_medios_compras As DataTable

    Public da_imp_ventas As MySqlDataAdapter
    Public dt_imp_ventas As DataTable

    Public da_imp_compras As MySqlDataAdapter
    Public dt_imp_compras As DataTable


    Dim COD_SEL_MI As String = ""
    Dim COD_SEL_DOCUMENTO_mi As String = ""

    Dim QUE_HACE_MI As String = ""

    Dim agregando_mi = ""

    Dim COD_SEL_CG As String = ""
    Dim COD_SEL_DOCUMENTO_CG As String = ""

    Dim QUE_HACE_CG As String = ""

    Dim agregando_cg = ""

    Dim COD_SEL_CE As String = ""
    Dim COD_SEL_DOCUMENTO_CE As String = ""

    Dim QUE_HACE_CE As String = ""
    Dim agregando_ce = ""

    Dim COD_SEL_RC As String = ""
    Dim COD_SEL_DOCUMENTO_RC As String = ""

    Dim QUE_HACE_RC As String = ""
    Dim agregando_RC = ""






    Private Sub load_MI_data()
        agregando_mi = "SI"
        Try
            sql = "SELECT CONS, documento FROM data_docs WHERE codigo='MI' and padre='NO'"
            da_COMBO_TIPOdocs_MI = New MySqlDataAdapter(sql, conex)
            dt_combo_TIPOdocs_MI = New DataTable
            da_COMBO_TIPOdocs_MI.Fill(dt_combo_TIPOdocs_MI)

            MetroGrid_mi.DataSource = dt_combo_TIPOdocs_MI
            MetroGrid_mi.Columns(0).Visible = False
            Me.MetroGrid_mi.Columns(1).Width = 80
            Me.MetroGrid_mi.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_COMBO_TIPOdocs_MI.Dispose()
        dt_combo_TIPOdocs_MI.Dispose()
        conex.Close()

        MetroGrid_mi.ClearSelection()
        agregando_mi = ""

    End Sub


    Private Sub load_CE_data()
        agregando_ce = "SI"

        Try
            sql = "SELECT CONS, documento FROM data_docs WHERE codigo='CE' and padre='NO'"
            da_COMBO_TIPOdocs_CE = New MySqlDataAdapter(sql, conex)
            dt_combo_TIPOdocs_CE = New DataTable
            da_COMBO_TIPOdocs_CE.Fill(dt_combo_TIPOdocs_CE)

            MetroGrid_CE.DataSource = dt_combo_TIPOdocs_CE
            MetroGrid_CE.Columns(0).Visible = False
            Me.MetroGrid_CE.Columns(1).Width = 80
            Me.MetroGrid_CE.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_COMBO_TIPOdocs_CE.Dispose()
        dt_combo_TIPOdocs_CE.Dispose()
        conex.Close()

        MetroGrid_CE.ClearSelection()
        agregando_ce = ""
    End Sub

    Private Sub load_RC_data()
        agregando_RC = "SI"

        Try
            sql = "SELECT CONS, documento FROM data_docs WHERE codigo='RC' and padre='NO'"
            da_COMBO_TIPOdocs_RC = New MySqlDataAdapter(sql, conex)
            dt_combo_TIPOdocs_RC = New DataTable
            da_COMBO_TIPOdocs_RC.Fill(dt_combo_TIPOdocs_RC)

            MetroGrid_RC.DataSource = dt_combo_TIPOdocs_RC
            MetroGrid_RC.Columns(0).Visible = False
            Me.MetroGrid_RC.Columns(1).Width = 80
            Me.MetroGrid_RC.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_COMBO_TIPOdocs_RC.Dispose()
        dt_combo_TIPOdocs_RC.Dispose()
        conex.Close()

        MetroGrid_RC.ClearSelection()
        agregando_RC = ""
    End Sub
    Private Sub Form_contadocs_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_contadocs_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        load_MI_data()
        load_CE_data()
        load_RC_data()

        MetroGrid_mi.BringToFront()
        MetroGrid_CE.BringToFront()
        MetroGrid_RC.BringToFront()

        MetroGrid_mi.ClearSelection()
        MetroGrid_CE.ClearSelection()

        MetroGrid_RC.ClearSelection()


        Me.MetroTabControl1.SelectTab(0)

        'MetroTabControl1.TabPages("MetroTabPage1").Hide()
        MetroTabControl1.Controls.Remove(MetroTabControl1.TabPages(3))


    End Sub




    Private Sub Button_cerrar_Click(sender As Object, e As EventArgs) Handles Button_cerrar.Click
        Me.Close()

    End Sub



    Private Sub Label24_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button_guardar_CE_Click(sender As Object, e As EventArgs) Handles Button_guardar_CE.Click
        'crear
        If QUE_HACE_CE = "CREAR" Then

            If TextBox_concepto_Ce.Visible = True And TextBox_concepto_Ce.Text = "" Then
                MsgBox("digite el nombre del documento ", vbInformation)
                Exit Sub
            End If

            If TextBox_concepto_Ce.Text = "Entrada" Or TextBox_concepto_Ce.Text = "Salida" Then
                MsgBox("digite el nombre del documento ", vbInformation)
                Exit Sub
            End If


            If RadioButton_ce_no.Checked = False And RadioButton_ce_si.Checked = False Then
                MsgBox("Seleccione estado del documento.", vbInformation)
                Exit Sub
            End If

            Dim estado_documento_CE As String = ""
            If RadioButton_ce_si.Checked = True Then estado_documento_CE = "SI"
            If RadioButton_ce_no.Checked = True Then estado_documento_CE = "NO"

            sql = "INSERT INTO data_docs(codigo,padre,DOCUMENTO,cuenta1,cuenta2,estado) 
values('CE','NO','" & CStr(TextBox_concepto_Ce.Text) & "','" & CStr(Label_codcuenta_ce.Text & "|" & Label_cuenta_ce.Text) & "', 
'MEDIO DE PAGO',
'" & estado_documento_CE & "')"

            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
                'MsgBox("Se Guardó correctamente. ", vbInformation)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()

        End If


        ' modificar
        If QUE_HACE_CE = "MODIFICAR" Then

            If RadioButton_ce_no.Checked = False And RadioButton_ce_si.Checked = False Then
                MsgBox("Seleccione estado del documento.", vbInformation)
                Exit Sub
            End If

            Dim estado_documento_CE As String = ""
            If RadioButton_ce_si.Checked = True Then estado_documento_CE = "SI"
            If RadioButton_ce_no.Checked = True Then estado_documento_CE = "NO"

            sql = "UPDATE data_docs SET 
cuenta1='" & CStr(Label_codcuenta_ce.Text & "|" & Label_cuenta_ce.Text) & "', 
CUENTA2='MEDIO DE PAGO',
estado='" & estado_documento_CE & "' 
WHERE CONS=" & COD_SEL_CE & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
                'MsgBox("Se Guardó correctamente. ", vbInformation)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()


        End If


        Label_title_Ce.Text = TextBox_concepto_Ce.Text

        load_CE_data()

        Button_select_cta_ce.Visible = False

        Button_regresar_CE.Visible = False
        Button_guardar_CE.Visible = False

        MetroGrid_CE.Enabled = True
        MetroGrid_CE.Visible = True
        MetroGrid_CE.ClearSelection()

        Panel_config_CE.Enabled = False
        FlowLayoutPanel_ce.Visible = True

        COD_SEL_CE = ""
        MetroGrid_CE.Visible = True : MetroGrid_CE.Enabled = True


    End Sub

    Private Sub Button_crear_MI_Click(sender As Object, e As EventArgs) Handles Button_crear_MI.Click
        agregando_mi = "SI"


        QUE_HACE_MI = "CREAR"




        Label26.Text = "Desea crear Entrada o Salida ?."


        MetroGrid_mi.ClearSelection()

        MetroGrid_mi.Enabled = False
        MetroGrid_mi.Visible = False


        TextBox_concepto_mi.Enabled = True
        TextBox_concepto_mi.Visible = True


        FlowLayoutPanel1.Visible = False


        Button_regresar_MI.Visible = True
        Button_guardar_MI.Visible = True

        RadioButton_entrada_MI.Visible = True
        RadioButton_salida_mi.Visible = True

        Button_select_cta_mi.Visible = True

        Panel_config_mi.Enabled = True
    End Sub

    Private Sub Button_guardar_MI_Click(sender As Object, e As EventArgs) Handles Button_guardar_MI.Click


        'crear
        If QUE_HACE_MI = "CREAR" Then

            If TextBox_concepto_mi.Visible = False Then
                MsgBox("Seleccione si desea entrada o salida, haga clic en regresar si desea cancelar.", vbInformation)
                Exit Sub
            End If


            If TextBox_concepto_mi.Visible = True And TextBox_concepto_mi.Text = "" Then
                MsgBox("digite el nombre del documento incluya la palabra ""Entrada"" o ""Salida"" según corresponda.", vbInformation)
                Exit Sub
            End If


            If TextBox_concepto_mi.Text = "Entrada" Or TextBox_concepto_mi.Text = "Salida" Then
                MsgBox("digite el nombre del documento incluya la palabra ""Entrada"" o ""Salida"" según corresponda.", vbInformation)
                Exit Sub
            End If

            If TextBox_concepto_mi.Text = "Traslado de Mercancia" Or
            TextBox_concepto_mi.Text = "Ajuste de Inventario" Or
            TextBox_concepto_mi.Text = "Inventario Inicial" Or
            TextBox_concepto_mi.Text = "Entrada de Mercancia" Or
            TextBox_concepto_mi.Text = "Salida de Mercancia" Then

                MsgBox("los nombres: Inventario Inicial, Entrada de Mercancia, Salida de Mercancia, Ajuste de Inventario y Traslado de Mercancia están reservados para el sistema", vbInformation)
                Exit Sub
            End If

            If TextBox_concepto_mi.Visible = True And TextBox_concepto_mi.Text <> "" Then
                If TextBox_concepto_mi.Text.Contains("Entrada") = False And RadioButton_entrada_MI.Checked = True Then
                    MsgBox("digite el nombre del documento incluya la palabra ""Entrada"" o ""Salida"" según corresponda por ejemplo ""Entrada por Sobrantes"".", vbInformation)
                    Exit Sub
                End If
                If TextBox_concepto_mi.Text.Contains("Salida") = False And RadioButton_salida_mi.Checked = True Then
                    MsgBox("digite el nombre del documento incluya la palabra ""Entrada"" o ""Salida"" según corresponda por ejemplo ""Salida por Vecimiento"".", vbInformation)
                    Exit Sub
                End If
            End If




            Dim autorizacion As String = ""
            If CheckBox_autoriza_MI.Checked = True Then autorizacion = "SI"
            If CheckBox_autoriza_MI.Checked = False Then autorizacion = "NO"
            Dim estado_documento_MI As String = ""
            If RadioButton_MI_si.Checked = True Then estado_documento_MI = "SI"
            If RadioButton_MI_NO.Checked = True Then estado_documento_MI = "NO"

            sql = "INSERT INTO data_docs(codigo,padre,DOCUMENTO,cuenta2,estado,autorizacion) 
values('MI','NO','" & CStr(TextBox_concepto_mi.Text) & "', 
'" & CStr(Label_codcuenta_mi.Text & "|" & Label_cuenta_mi.Text) & "',
'" & estado_documento_MI & "',
'" & autorizacion & "')"

            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
                'MsgBox("Se Guardó correctamente. ", vbInformation)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()


            load_MI_data()


        End If




        ' modificar
        If QUE_HACE_MI = "MODIFICAR" Then
            If TextBox_concepto_mi.Text = "Traslado de Mercancia" Or
            TextBox_concepto_mi.Text = "Ajuste de Inventario" Or
            TextBox_concepto_mi.Text = "Inventario Inicial" Or
            TextBox_concepto_mi.Text = "Entrada de Mercancia" Or
            TextBox_concepto_mi.Text = "Salida de Mercancia" Then

                MsgBox("los nombres: Inventario Inicial, Entrada de Mercancia, Salida de Mercancia, Ajuste de Inventario y Traslado de Mercancia están reservados para el sistema", vbInformation)
                Exit Sub
            End If


            Dim autorizacion As String = ""
            If CheckBox_autoriza_MI.Checked = True Then autorizacion = "SI"
            If CheckBox_autoriza_MI.Checked = False Then autorizacion = "NO"
            Dim estado_documento_MI As String = ""
            If RadioButton_MI_si.Checked = True Then estado_documento_MI = "SI"
            If RadioButton_MI_NO.Checked = True Then estado_documento_MI = "NO"

            sql = "UPDATE data_docs SET 
CUENTA2='" & CStr(Label_codcuenta_mi.Text & "|" & Label_cuenta_mi.Text) & "',
estado='" & estado_documento_MI & "',
AUTORIZACION='" & autorizacion & "'
WHERE CONS=" & COD_SEL_MI & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
                'MsgBox("Se Guardó correctamente. ", vbInformation)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()

            load_MI_data()

        End If



        Button_regresar_MI.Visible = False
        Button_guardar_MI.Visible = False

        MetroGrid_mi.Enabled = True
        MetroGrid_mi.Visible = True
        MetroGrid_mi.ClearSelection()

        Panel_config_mi.Enabled = False
        FlowLayoutPanel1.Visible = True

        COD_SEL_MI = ""

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroTabPage1_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub MetroGrid_mi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid_mi.CellContentClick

    End Sub

    Private Sub MetroGrid_mi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid_mi.CellClick

        Dim row_MI As DataGridViewRow = MetroGrid_mi.CurrentRow

        COD_SEL_MI = CStr(row_MI.Cells("CONS").Value)
        COD_SEL_DOCUMENTO_mi = CStr(row_MI.Cells("DOCUMENTO").Value)
        Dim contacuentas() As String
        Dim contacuenta As String = ""
        Dim estadodoc As String = ""

        Try
            sql = "SELECT documento, cuenta1, cuenta2, observaciones, estado, AUTORIZACION FROM data_docs where cons='" & COD_SEL_MI & "'"
            da_info_MI = New MySqlDataAdapter(sql, conex)
            dt_info_MI = New DataTable
            da_info_MI.Fill(dt_info_MI)
            Label_codcuenta_mi.Text = "-"
            Label_cuenta_mi.Text = "-"
            For Each row As DataRow In dt_info_MI.Rows

                contacuenta = row.Item("cuenta2")
                estadodoc = row.Item("estado")
                TextBox_concepto_mi.Text = row.Item("DOCUMENTO")
                Label_title_mi.Text = row.Item("DOCUMENTO")

                If row.Item("AUTORIZACION") = "" Then CheckBox_autoriza_MI.Checked = False
                If row.Item("AUTORIZACION") = "NO" Then CheckBox_autoriza_MI.Checked = False
                If row.Item("AUTORIZACION") = "SI" Then CheckBox_autoriza_MI.Checked = True

            Next
            contacuentas = Split(contacuenta, "|")

            Label_codcuenta_mi.Text = contacuentas(0)
            Label_cuenta_mi.Text = contacuentas(1)
            If estadodoc = "SI" Then RadioButton_MI_si.Checked = True
            If estadodoc = "NO" Then RadioButton_MI_NO.Checked = True
            If TextBox_concepto_mi.Text.Contains("Salida") = True Then RadioButton_salida_mi.Checked = True
            If TextBox_concepto_mi.Text.Contains("Entrada") = True Then RadioButton_entrada_MI.Checked = True
        Catch ex As Exception
        End Try
        conex.Close()
        da_info_MI.Dispose()
        dt_info_MI.Dispose()
        conex.Close()

    End Sub
    Private Sub MetroGrid_mi_SelectionChanged(sender As Object, e As EventArgs) Handles MetroGrid_mi.SelectionChanged
        If agregando_mi = "SI" Then Exit Sub


        If MetroGrid_mi.RowCount = 0 Then
            Exit Sub
        End If



        If Not IsDBNull(MetroGrid_mi.Item("cons", 0).Value) Then
            Dim row_mi As DataGridViewRow = MetroGrid_mi.CurrentRow

            COD_SEL_MI = CStr(row_mi.Cells("CONS").Value)
            COD_SEL_DOCUMENTO_mi = CStr(row_mi.Cells("DOCUMENTO").Value)
            Dim contacuentas() As String
            Dim contacuenta As String = ""
            Dim estadodoc As String = ""
            Try
                sql = "SELECT documento, cuenta1, cuenta2, observaciones, estado, AUTORIZACION FROM data_docs where cons='" & COD_SEL_MI & "'"
                da_info_MI = New MySqlDataAdapter(sql, conex)
                dt_info_MI = New DataTable
                da_info_MI.Fill(dt_info_MI)
                Label_codcuenta_mi.Text = "-"
                Label_cuenta_mi.Text = "-"
                For Each row As DataRow In dt_info_MI.Rows
                    contacuenta = row.Item("cuenta2")
                    estadodoc = row.Item("estado")
                    TextBox_concepto_mi.Text = row.Item("DOCUMENTO")
                    Label_title_mi.Text = row.Item("DOCUMENTO")
                    If row.Item("AUTORIZACION") = "" Then CheckBox_autoriza_MI.Checked = False
                    If row.Item("AUTORIZACION") = "NO" Then CheckBox_autoriza_MI.Checked = False
                    If row.Item("AUTORIZACION") = "SI" Then CheckBox_autoriza_MI.Checked = True
                Next
                contacuentas = Split(contacuenta, "|")
                Label_codcuenta_mi.Text = contacuentas(0)
                Label_cuenta_mi.Text = contacuentas(1)
                If estadodoc = "SI" Then RadioButton_MI_si.Checked = True
                If estadodoc = "NO" Then RadioButton_MI_NO.Checked = True

                If TextBox_concepto_mi.Text.Contains("Salida") = True Then RadioButton_salida_mi.Checked = True
                If TextBox_concepto_mi.Text.Contains("Entrada") = True Then RadioButton_entrada_MI.Checked = True

            Catch ex As Exception


            End Try
            conex.Close()
            da_info_MI.Dispose()
            dt_info_MI.Dispose()
            conex.Close()

        End If

    End Sub
    Private Sub Button_modificar_MI_Click(sender As Object, e As EventArgs) Handles Button_modificar_MI.Click

        If COD_SEL_MI = "" Then
            MsgBox("Seleccione un documento.", vbInformation)
            Exit Sub
        End If

        QUE_HACE_MI = "MODIFICAR"

        MetroGrid_mi.Enabled = False
        MetroGrid_mi.Visible = False

        TextBox_concepto_mi.Visible = True
        TextBox_concepto_mi.Enabled = True
        Button_select_cta_mi.Visible = True

        ' documentos predeterminados de inventario no d epuedne modificar el nombre
        If TextBox_concepto_mi.Text = "Traslado de Mercancia" Or
            TextBox_concepto_mi.Text = "Ajuste de Inventario" Or
            TextBox_concepto_mi.Text = "Inventario Inicial" Or
            TextBox_concepto_mi.Text = "Entrada de Mercancia" Or
            TextBox_concepto_mi.Text = "Salida de Mercancia" Then
            TextBox_concepto_mi.Enabled = False
        End If


        ' A ESTOS documentos predeterminados de inventario no s epuede cambiar la cuenta
        If TextBox_concepto_mi.Text = "Traslado de Mercancia" Or
            TextBox_concepto_mi.Text = "Ajuste de Inventario" Then
            Button_select_cta_mi.Visible = False
        End If


        Panel_config_mi.Enabled = True


        Button_regresar_MI.Visible = True
        Button_guardar_MI.Visible = True

        FlowLayoutPanel1.Visible = False

    End Sub

    Private Sub RadioButton_entrada_MI_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_entrada_MI.CheckedChanged
        TextBox_concepto_mi.Visible = True
        Label_nom_doc.Visible = True

        Label_nom_doc.Text = "Digite el nombre de la entrada..."

        TextBox_concepto_mi.Text = "Entrada"

    End Sub

    Private Sub RadioButton_salida_mi_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_salida_mi.CheckedChanged
        TextBox_concepto_mi.Visible = True
        Label_nom_doc.Visible = True

        Label_nom_doc.Text = "Digite el nombre de la salida..."
        TextBox_concepto_mi.Text = "Salida"


    End Sub

    Private Sub Button_regresar_MI_Click(sender As Object, e As EventArgs) Handles Button_regresar_MI.Click

        Panel_config_mi.Enabled = False

        MetroGrid_mi.Visible = True : MetroGrid_mi.Enabled = True

        MetroGrid_mi.ClearSelection()

        FlowLayoutPanel1.Visible = True


        RadioButton_entrada_MI.Checked = False
        RadioButton_salida_mi.Checked = False
        TextBox_concepto_mi.Text = ""


        Button_regresar_MI.Visible = False
        Button_guardar_MI.Visible = False
        COD_SEL_MI = ""




        COD_SEL_MI = ""
        COD_SEL_DOCUMENTO_mi = ""

    End Sub



    Private Sub MetroGrid_mi_CellBorderStyleChanged(sender As Object, e As EventArgs) Handles MetroGrid_mi.CellBorderStyleChanged

    End Sub

    Private Sub ComboBox_cta2_MI_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox_cta2_MI_KeyDown(sender As Object, e As KeyEventArgs)

    End Sub



    Private Sub Button_eliminar_mi_Click(sender As Object, e As EventArgs) Handles Button_eliminar_mi.Click


        If COD_SEL_MI = "" Then
            MsgBox("seleccione un documento.")
            Exit Sub
        End If
        If COD_SEL_DOCUMENTO_mi = "Inventario Inicial" Then
            MsgBox("No se puede eliminar este documento, es un documento predeterminado del sistema.")
            Exit Sub
        End If
        If COD_SEL_DOCUMENTO_mi = "Trasldado de Mercancia" Then
            MsgBox("No se puede eliminar este documento, es un documento predeterminado del sistema.")
            Exit Sub
        End If
        If COD_SEL_DOCUMENTO_mi = "Ajuste de Inventario" Then
            MsgBox("No se puede eliminar este documento, es un documento predeterminado del sistema.")
            Exit Sub
        End If

        If COD_SEL_DOCUMENTO_mi = "Entrada de Mercancia" Then
            MsgBox("No se puede eliminar este documento, es un documento predeterminado del sistema.")
            Exit Sub
        End If
        If COD_SEL_DOCUMENTO_mi = "Salida de MErcancia" Then
            MsgBox("No se puede eliminar este documento, es un documento predeterminado del sistema.")
            Exit Sub
        End If

        Dim RTA = MsgBox("Seguro desea borrar el documento? " & Chr(13) & Chr(13) & "", MsgBoxStyle.Question + MsgBoxStyle.YesNo)

        If RTA = 6 Then
            Try
                sql = "DELETE FROM DATA_DOCS WHERE CONS=" & COD_SEL_MI & ""
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                da.Fill(dt)

                MsgBox("Se eliminó el documento.")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da.Dispose()
            dt.Dispose()
            conex.Close()
        End If

        load_MI_data()


    End Sub

    Private Sub MetroTabPage4_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub Button_crear_CE_Click(sender As Object, e As EventArgs) Handles Button_crear_CE.Click
        agregando_ce = "SI"


        QUE_HACE_CE = "CREAR"


        Label_title_Ce.Text = ""
        Label_codcuenta_ce.Text = "-"
        Label_cuenta_ce.Text = "-"
        TextBox_concepto_Ce.Text = ""


        MetroGrid_CE.ClearSelection()

        MetroGrid_CE.Visible = False
        Button_select_cta_ce.Visible = True



        TextBox_concepto_Ce.Visible = True


        FlowLayoutPanel_ce.Visible = False


        Button_regresar_CE.Visible = True
        Button_guardar_CE.Visible = True


        Panel_config_CE.Enabled = True
    End Sub

    Private Sub Button_modificar_CE_Click(sender As Object, e As EventArgs) Handles Button_modificar_CE.Click
        If COD_SEL_CE = "" Then
            MsgBox("Seleccione un documento.", vbInformation)
            Exit Sub
        End If

        QUE_HACE_CE = "MODIFICAR"

        MetroGrid_CE.Enabled = False
        MetroGrid_CE.Visible = False

        Button_select_cta_ce.Visible = True
        TextBox_concepto_Ce.Enabled = True
        Panel_config_CE.Enabled = True
        Button_regresar_CE.Visible = True
        Button_guardar_CE.Visible = True

        FlowLayoutPanel_ce.Visible = False
    End Sub

    Private Sub Button_eliminar_CE_Click(sender As Object, e As EventArgs) Handles Button_eliminar_CE.Click
        If COD_SEL_CE = "" Then
            MsgBox("seleccione un documento.")
            Exit Sub
        End If



        Dim RTA = MsgBox("Seguro desea borrar el documento? " & Chr(13) & Chr(13) & "", MsgBoxStyle.Question + MsgBoxStyle.YesNo)

        If RTA = 6 Then
            Try
                sql = "DELETE FROM DATA_DOCS WHERE CONS=" & COD_SEL_CE & ""
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                da.Fill(dt)

                MsgBox("Se eliminó el documento.")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da.Dispose()
            dt.Dispose()
            conex.Close()
        End If

        load_CE_data()
    End Sub

    Private Sub MetroGrid_CE_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid_CE.CellContentClick

    End Sub

    Private Sub Button_regresar_CE_Click(sender As Object, e As EventArgs) Handles Button_regresar_CE.Click
        Panel_config_CE.Enabled = False

        MetroGrid_CE.Visible = True : MetroGrid_CE.Enabled = True

        MetroGrid_CE.ClearSelection()

        FlowLayoutPanel_ce.Visible = True



        TextBox_concepto_mi.Text = ""
        TextBox_concepto_mi.Visible = False


        Button_regresar_CE.Visible = False
        Button_guardar_CE.Visible = False
        COD_SEL_CE = ""


        Button_select_cta_ce.Visible = False



        COD_SEL_CE = ""
        COD_SEL_DOCUMENTO_CE = ""
    End Sub



    Private Sub MetroGrid_CE_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid_CE.CellClick
        Dim row_cE As DataGridViewRow = MetroGrid_CE.CurrentRow

        COD_SEL_CE = CStr(row_cE.Cells("CONS").Value)
        COD_SEL_DOCUMENTO_CE = CStr(row_cE.Cells("DOCUMENTO").Value)
        Dim contacuentas() As String
        Dim contacuenta As String = ""
        Dim estadodoc As String = ""

        Try
            sql = "SELECT documento, cuenta1, cuenta2, observaciones, estado, AUTORIZACION FROM data_docs where cons='" & COD_SEL_CE & "'"
            da_info_CE = New MySqlDataAdapter(sql, conex)
            dt_info_CE = New DataTable
            da_info_CE.Fill(dt_info_CE)

            For Each row As DataRow In dt_info_CE.Rows
                contacuenta = row.Item("cuenta1")
                estadodoc = row.Item("estado")
                TextBox_concepto_Ce.Text = row.Item("DOCUMENTO")
                Label_title_Ce.Text = row.Item("DOCUMENTO")

                If row.Item("AUTORIZACION") = "" Then CheckBox_autoriza_CE.Checked = False
                If row.Item("AUTORIZACION") = "NO" Then CheckBox_autoriza_CE.Checked = False
                If row.Item("AUTORIZACION") = "SI" Then CheckBox_autoriza_CE.Checked = True
            Next

            contacuentas = Split(contacuenta, "|")
            Label_codcuenta_ce.Text = contacuentas(0)
            Label_cuenta_ce.Text = contacuentas(1)
            If estadodoc = "SI" Then RadioButton_ce_si.Checked = True
            If estadodoc = "NO" Then RadioButton_ce_no.Checked = True


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_info_CE.Dispose()
        dt_info_CE.Dispose()
        conex.Close()
    End Sub

    Private Sub MetroGrid_CE_SelectionChanged(sender As Object, e As EventArgs) Handles MetroGrid_CE.SelectionChanged
        If agregando_ce = "SI" Then Exit Sub


        If MetroGrid_CE.RowCount = 0 Then
            Exit Sub
        End If



        If Not IsDBNull(MetroGrid_CE.Item("cons", 0).Value) Then
            Dim row_ce As DataGridViewRow = MetroGrid_CE.CurrentRow

            COD_SEL_CE = CStr(row_ce.Cells("CONS").Value)
            COD_SEL_DOCUMENTO_CE = CStr(row_ce.Cells("DOCUMENTO").Value)
            Dim contacuentas() As String
            Dim contacuenta As String = ""
            Dim estadodoc As String = ""


            Try
                sql = "SELECT documento, cuenta1, cuenta2, observaciones, estado, AUTORIZACION FROM data_docs where cons='" & COD_SEL_CE & "'"
                da_info_CE = New MySqlDataAdapter(sql, conex)
                dt_info_CE = New DataTable
                da_info_CE.Fill(dt_info_CE)

                For Each row As DataRow In dt_info_CE.Rows

                    contacuenta = row.Item("cuenta1")
                    estadodoc = row.Item("estado")
                    TextBox_concepto_Ce.Text = row.Item("DOCUMENTO")
                    Label_title_Ce.Text = row.Item("DOCUMENTO")

                    If row.Item("AUTORIZACION") = "" Then CheckBox_autoriza_CE.Checked = False
                    If row.Item("AUTORIZACION") = "NO" Then CheckBox_autoriza_CE.Checked = False
                    If row.Item("AUTORIZACION") = "SI" Then CheckBox_autoriza_CE.Checked = True
                Next
                contacuentas = Split(contacuenta, "|")
                Label_codcuenta_ce.Text = contacuentas(0)
                Label_cuenta_ce.Text = contacuentas(1)
                If estadodoc = "SI" Then RadioButton_ce_si.Checked = True
                If estadodoc = "NO" Then RadioButton_ce_no.Checked = True

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da_info_CE.Dispose()
            dt_info_CE.Dispose()
            conex.Close()
        End If
    End Sub

    Private Sub MetroGrid_cats_venta_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub MetroGrid_RC_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid_RC.CellContentClick

    End Sub

    Private Sub MetroGrid_RC_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid_RC.CellClick
        Dim row_RC As DataGridViewRow = MetroGrid_RC.CurrentRow

        COD_SEL_RC = CStr(row_RC.Cells("CONS").Value)
        COD_SEL_DOCUMENTO_RC = CStr(row_RC.Cells("DOCUMENTO").Value)

        Dim contacuentas() As String
        Dim contacuenta As String = ""
        Dim estadodoc As String = ""

        Try
            sql = "SELECT documento, cuenta1, cuenta2, observaciones, estado, AUTORIZACION FROM data_docs where cons='" & COD_SEL_RC & "'"
            da_info_RC = New MySqlDataAdapter(sql, conex)
            dt_info_RC = New DataTable
            da_info_RC.Fill(dt_info_RC)

            For Each row As DataRow In dt_info_RC.Rows
                contacuenta = row.Item("cuenta1")
                TextBox_concepto_rc.Text = row.Item("documento")
                Label_title_RC.Text = row.Item("documento")

                estadodoc = row.Item("estado")

                If row.Item("AUTORIZACION") = "" Then CheckBox_autoriza_rc.Checked = False
                If row.Item("AUTORIZACION") = "NO" Then CheckBox_autoriza_rc.Checked = False
                If row.Item("AUTORIZACION") = "SI" Then CheckBox_autoriza_rc.Checked = True
            Next
            contacuentas = Split(contacuenta, "|")
            Label_codcuenta_rc.Text = contacuentas(0)
            Label_cuenta_rc.Text = contacuentas(1)
            If estadodoc = "SI" Then RadioButton_rc_si.Checked = True
            If estadodoc = "NO" Then RadioButton_rc_no.Checked = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_info_RC.Dispose()
        dt_info_RC.Dispose()
        conex.Close()
    End Sub

    Private Sub MetroGrid_RC_SelectionChanged(sender As Object, e As EventArgs) Handles MetroGrid_RC.SelectionChanged
        If agregando_RC = "SI" Then Exit Sub


        If MetroGrid_RC.RowCount = 0 Then
            Exit Sub
        End If

        Dim contacuentas() As String
        Dim contacuenta As String = ""
        Dim estadodoc As String = ""


        If Not IsDBNull(MetroGrid_RC.Item("cons", 0).Value) Then
            Dim row_rc As DataGridViewRow = MetroGrid_RC.CurrentRow

            COD_SEL_RC = CStr(row_rc.Cells("CONS").Value)
            COD_SEL_DOCUMENTO_RC = CStr(row_rc.Cells("DOCUMENTO").Value)

            Try
                sql = "SELECT documento, cuenta1, cuenta2, observaciones, estado, AUTORIZACION FROM data_docs where cons='" & COD_SEL_RC & "'"
                da_info_RC = New MySqlDataAdapter(sql, conex)
                dt_info_RC = New DataTable
                da_info_RC.Fill(dt_info_RC)



                For Each row As DataRow In dt_info_RC.Rows
                    contacuenta = row.Item("cuenta1")
                    TextBox_concepto_rc.Text = row.Item("documento")
                    Label_title_RC.Text = row.Item("documento")

                    estadodoc = row.Item("estado")

                    If row.Item("AUTORIZACION") = "" Then CheckBox_autoriza_rc.Checked = False
                    If row.Item("AUTORIZACION") = "NO" Then CheckBox_autoriza_rc.Checked = False
                    If row.Item("AUTORIZACION") = "SI" Then CheckBox_autoriza_rc.Checked = True
                Next
                contacuentas = Split(contacuenta, "|")
                Label_codcuenta_rc.Text = contacuentas(0)
                Label_cuenta_rc.Text = contacuentas(1)
                If estadodoc = "SI" Then RadioButton_rc_si.Checked = True
                If estadodoc = "NO" Then RadioButton_rc_no.Checked = True

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da_info_RC.Dispose()
            dt_info_RC.Dispose()
            conex.Close()
        End If
    End Sub

    Private Sub Button_crear_RC_Click(sender As Object, e As EventArgs) Handles Button_crear_RC.Click
        agregando_RC = "SI"


        QUE_HACE_RC = "CREAR"

        RadioButton_rc_si.Checked = False
        RadioButton_rc_no.Checked = False

        Label_title_RC.Text = ""
        Label_codcuenta_rc.Text = "-"
        Label_cuenta_rc.Text = "-"
        TextBox_concepto_rc.Text = ""

        MetroGrid_RC.ClearSelection()

        MetroGrid_RC.Enabled = False
        MetroGrid_RC.Visible = False

        TextBox_concepto_rc.Visible = True
        FlowLayoutPanel_rc.Visible = False
        Button_regresar_RC.Visible = True
        Button_guardar_RC.Visible = True
        Panel_config_RC.Enabled = True
    End Sub

    Private Sub Button_modificar_RC_Click(sender As Object, e As EventArgs) Handles Button_modificar_RC.Click
        If COD_SEL_RC = "" Then
            MsgBox("Seleccione un documento.", vbInformation)
            Exit Sub
        End If

        QUE_HACE_RC = "MODIFICAR"

        MetroGrid_RC.Enabled = False
        MetroGrid_RC.Visible = False


        TextBox_concepto_rc.Enabled = True


        Panel_config_RC.Enabled = True


        Button_regresar_RC.Visible = True
        Button_guardar_RC.Visible = True

        FlowLayoutPanel_rc.Visible = False
    End Sub

    Private Sub Button_eliminar_RC_Click(sender As Object, e As EventArgs) Handles Button_eliminar_RC.Click
        If COD_SEL_RC = "" Then
            MsgBox("seleccione un documento.")
            Exit Sub
        End If



        Dim RTA = MsgBox("Seguro desea borrar el documento? " & Chr(13) & Chr(13) & "", MsgBoxStyle.Question + MsgBoxStyle.YesNo)

        If RTA = 6 Then
            Try
                sql = "DELETE FROM DATA_DOCS WHERE CONS=" & COD_SEL_RC & ""
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                da.Fill(dt)

                MsgBox("Se eliminó el documento.")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da.Dispose()
            dt.Dispose()
            conex.Close()
        End If

        load_RC_data()
    End Sub

    Private Sub Button_guardar_RC_Click(sender As Object, e As EventArgs) Handles Button_guardar_RC.Click
        'crear
        If QUE_HACE_RC = "CREAR" Then

            If TextBox_concepto_rc.Text = "" Then
                MsgBox("digite el nombre del documento ", vbInformation)
                Exit Sub
            End If


            If RadioButton_rc_no.Checked = False And RadioButton_rc_si.Checked = False Then
                MsgBox("Seleccione estado del documento.", vbInformation)
                Exit Sub
            End If

            Dim estado_documento_rc As String = ""
            If RadioButton_rc_si.Checked = True Then estado_documento_rc = "SI"
            If RadioButton_rc_no.Checked = True Then estado_documento_rc = "NO"

            sql = "INSERT INTO data_docs(codigo,padre,DOCUMENTO,cuenta1,cuenta2,estado) 
values('RC','NO','" & CStr(TextBox_concepto_rc.Text) & "','" & CStr(Label_codcuenta_rc.Text & "|" & Label_cuenta_rc.Text) & "', 
'MEDIO DE PAGO',
'" & estado_documento_rc & "')"

            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
                'MsgBox("Se Guardó correctamente. ", vbInformation)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()
            Label_title_RC.Text = TextBox_concepto_rc.Text

        End If


        ' modificar
        If QUE_HACE_RC = "MODIFICAR" Then

            If RadioButton_rc_no.Checked = False And RadioButton_rc_si.Checked = False Then
                MsgBox("Seleccione estado del documento.", vbInformation)
                Exit Sub
            End If

            Dim estado_documento_rc As String = ""
            If RadioButton_rc_si.Checked = True Then estado_documento_rc = "SI"
            If RadioButton_rc_no.Checked = True Then estado_documento_rc = "NO"

            sql = "UPDATE data_docs SET
documento='" & CStr(TextBox_concepto_rc.Text) & "', 
cuenta1='" & CStr(Label_codcuenta_rc.Text & "|" & Label_cuenta_rc.Text) & "', 
CUENTA2='MEDIO DE PAGO',
estado='" & estado_documento_rc & "' 
WHERE CONS=" & COD_SEL_RC & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
                'MsgBox("Se Guardó correctamente. ", vbInformation)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()
            Label_title_RC.Text = TextBox_concepto_rc.Text

        End If

        load_RC_data()


        Button_regresar_RC.Visible = False
        Button_guardar_RC.Visible = False

        MetroGrid_RC.Enabled = True
        MetroGrid_RC.Visible = True
        MetroGrid_RC.ClearSelection()

        Panel_config_RC.Enabled = False
        FlowLayoutPanel_rc.Visible = True

        COD_SEL_RC = ""
        MetroGrid_RC.Visible = True : MetroGrid_RC.Enabled = True
    End Sub

    Private Sub Button_regresar_RC_Click(sender As Object, e As EventArgs) Handles Button_regresar_RC.Click


        Panel_config_RC.Enabled = False

        MetroGrid_RC.Enabled = True
        MetroGrid_RC.Visible = True
        MetroGrid_RC.ClearSelection()

        FlowLayoutPanel_rc.Visible = True



        TextBox_concepto_mi.Text = ""
        TextBox_concepto_mi.Visible = False


        Button_regresar_RC.Visible = False
        Button_guardar_RC.Visible = False
        COD_SEL_RC = ""



        COD_SEL_RC = ""
        COD_SEL_DOCUMENTO_RC = ""

    End Sub



    Private Sub TextBox_concepto_rc_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox_concepto_rc_LostFocus(sender As Object, e As EventArgs)
        Label_title_RC.Text = TextBox_concepto_rc.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button_select_cta_rc.Click
        Button_select_cta_rc.Text = "Seleccionando..."
        Panel_config_RC.Enabled = False
        Form_puc_Select.Show()

    End Sub

    Private Sub Button_select_cta_ce_Click(sender As Object, e As EventArgs) Handles Button_select_cta_ce.Click

        Button_select_cta_ce.Text = "Seleccionando..."
        Panel_config_CE.Enabled = False
        Form_puc_Select.Show()

    End Sub

    Private Sub Button_select_cta_mi_Click(sender As Object, e As EventArgs) Handles Button_select_cta_mi.Click
        Button_select_cta_mi.Text = "Seleccionando..."
        Panel_config_mi.Enabled = False
        Form_puc_Select.Show()
    End Sub

    Private Sub Panel_config_mi_Paint(sender As Object, e As PaintEventArgs) Handles Panel_config_mi.Paint

    End Sub

    Private Sub label_codcuenta_rc_OnValueChanged(sender As Object, e As EventArgs) Handles label_codcuenta_rc.OnValueChanged

    End Sub


    Private Sub Button13_Click_1(sender As Object, e As EventArgs) Handles Button13.Click
        Form_puc.Show()

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Form_comprobantes.Show()

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Form_Informescontables.Show()
    End Sub
End Class