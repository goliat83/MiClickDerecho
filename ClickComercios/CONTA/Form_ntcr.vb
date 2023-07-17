Public Class Form_ntcr

    Public da_IMP_ntcr As New MySqlDataAdapter
    Public dT_IMP_ntcr As New DataTable
    Public da_RETE_ntcr As New MySqlDataAdapter
    Public dT_RETE_ntcr As New DataTable

    Public da_contact_fitro_NTCR As New MySqlDataAdapter
    Public dT_contact_fitro_NTCR As New DataTable

    Dim cuenta_puc() As String
    Dim pago() As String
    Dim cod_cuenta_puc As String = ""
    Dim nom_cuenta_puc As String = ""

    Dim cli_nom, cli_tel, cli_dir, cli_doc, cli_dv, cli_mail As String
    Dim QUE_HACE_CLIENTE As String

    Dim IMP_NOMBRE, IMP_PORCENTAJE, IMP_VALOR, IMP_BASE As String
    Dim RETE_NOMBRE, RETE_PORCENTAJE, RETE_VALOR, RETE_BASE As String


    Private Sub Btn_salir_Click(sender As Object, e As EventArgs) Handles Btn_salir.Click
        Me.Close()
    End Sub

    Private Sub Form_ntcr_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_ntcr_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'impuestos
        Try
            sql = "SELECT cons, TIPOIMP, porcentaje, nombre FROM impuestos where tipoimp='PORCENTAJE'"
            da_IMP_ntcr = New MySqlDataAdapter(sql, conex)
            dT_IMP_ntcr = New DataTable
            da_IMP_ntcr.Fill(dT_IMP_ntcr)

            ComboBox_impuestos.DataSource = dT_IMP_ntcr.DefaultView
            ComboBox_impuestos.DisplayMember = "nombre"
            ComboBox_impuestos.ValueMember = "CONS"
        Catch ex As Exception
            Cursor.Current = Cursors.Default

            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_IMP_ntcr.Dispose()
        dT_IMP_ntcr.Dispose()
        conex.Close()
        ComboBox_impuestos.SelectedItem = Nothing

        'retenciones
        Try
            sql = "SELECT cons, TIPOIMP, porcentaje, nombre FROM impuestos where tipoimp='RETENCION'"
            da_RETE_ntcr = New MySqlDataAdapter(sql, conex)
            dT_RETE_ntcr = New DataTable
            da_RETE_ntcr.Fill(dT_RETE_ntcr)

            ComboBox_RETENCIONES.DataSource = dT_RETE_ntcr.DefaultView
            ComboBox_RETENCIONES.DisplayMember = "nombre"
            ComboBox_RETENCIONES.ValueMember = "CONS"
        Catch ex As Exception
            Cursor.Current = Cursors.Default

            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_RETE_ntcr.Dispose()
        dT_RETE_ntcr.Dispose()
        conex.Close()
        ComboBox_RETENCIONES.SelectedItem = Nothing




        Timer_MEDIO_PAGO.Enabled = True

        If ID_gasto_VER <> "" Then
            Timer_VER.Enabled = True
            Exit Sub
        End If

        Btn_nuevo_mov_Click(Nothing, Nothing)
    End Sub

    Private Sub Btn_nuevo_mov_Click(sender As Object, e As EventArgs) Handles Btn_nuevo_mov.Click
        Me.Button3.Visible = False
        Label_consecutivo.Text = ""
        'CONSECUTIVO
        consecutivo = 0
        cmd.Connection = conex
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select max(documento) + 1 from recibos_egresos"
        conex.Open()
        Try
            dr_consecutivos = cmd.ExecuteReader()
            If dr_consecutivos.Read() Then
                consecutivo = dr_consecutivos(0)
            Else
                consecutivo = 1
            End If
        Catch ex As Exception
            consecutivo = 1
            conex.Close()
        End Try
        conex.Close()

        Me.Label_consecutivo.Text = consecutivo
        Me.Label_fecha.Text = DateTime.Now.ToShortDateString
        Me.Label14.Text = usrnom

        FlowLayoutPanel1.Visible = True
        Panel_dock.Visible = False


        Me.Panel_cliente.Enabled = True

        Me.Panel3.Enabled = True
        Button4.Visible = False

        COMBO_NOM_CLIENTE_FILTRO.Enabled = True
    End Sub

    Private Sub ComboBox_tipo_egreso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_tipo_egreso.SelectedIndexChanged

    End Sub

    Private Sub TEXTBOX_BUSCAR_PROV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TEXTBOX_BUSCAR_PROV.KeyPress
        If TEXTBOX_BUSCAR_PROV.Text = "" Then
            TXT_NOM_CLIENTE.Text = ""
            TXT_DOC_CLIENTE.Text = ""
            TXT_TELS_CLIENTE.Text = ""
            TXT_DIR_CLIENTE.Text = ""
        End If
    End Sub

    Private Sub Button_REFRESH_Click_1(sender As Object, e As EventArgs) Handles Button_REFRESH.Click


        Me.TXT_DIR_CLIENTE.Text = ""
        Me.TXT_TELS_CLIENTE.Text = ""
        Me.TXT_DOC_CLIENTE.Text = ""
        Me.TextBox_dv_cliente.Text = ""

        Me.TXT_NOM_CLIENTE.Text = ""
        cli_dir = ""
        cli_tel = ""
        cli_mail = ""
        cli_doc = ""
        cli_nom = ""
        cli_dv = ""

        cli_doc = ""


        Button_SAVE_CLI.Visible = False
        Button_EDIT_CLI.Visible = False
        Button_NUEVO_CLI.Visible = True

        Label_info_cliente.Visible = False

        COMBO_NOM_CLIENTE_FILTRO.Visible = True
        QUE_HACE_CLIENTE = ""



        ''LLENADO contactos
        Try
            sql = "SELECT documento, nombre FROM proveedores"
            da_contact = New MySqlDataAdapter(sql, conex)
            DT_contact = New DataTable
            da_contact.Fill(DT_contact)
            Me.COMBO_NOM_CLIENTE_FILTRO.DataSource = DT_contact.DefaultView
            Me.COMBO_NOM_CLIENTE_FILTRO.DisplayMember = "nombre"
            Me.COMBO_NOM_CLIENTE_FILTRO.ValueMember = "documento"
            Me.COMBO_NOM_CLIENTE_FILTRO.AutoCompleteSource = AutoCompleteSource.ListItems
            Me.COMBO_NOM_CLIENTE_FILTRO.AutoCompleteMode = AutoCompleteMode.Suggest
            Me.COMBO_NOM_CLIENTE_FILTRO.SelectedItem = Nothing


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_contact.Dispose()
        DT_contact.Dispose()
        conex.Close()
        COMBO_NOM_CLIENTE_FILTRO.DroppedDown = True
    End Sub
    Private Sub Button_NUEVO_CLI_Click(sender As Object, e As EventArgs) Handles Button_NUEVO_CLI.Click
        'Form_contactos.Show()
        'Form_contactos.BringToFront()


        Label_info_cliente.Visible = True
        Label_info_cliente.Text = "Registre los Datos del Beneficiario"


        Me.TXT_DIR_CLIENTE.Text = ""
        Me.TXT_TELS_CLIENTE.Text = ""
        Me.TXT_DOC_CLIENTE.Text = ""
        Me.TextBox_dv_cliente.Text = ""

        Me.TXT_NOM_CLIENTE.Text = ""
        cli_dir = ""
        cli_tel = ""
        cli_mail = ""
        cli_doc = ""
        cli_nom = ""
        cli_dv = ""

        COMBO_NOM_CLIENTE_FILTRO.Visible = False

        Me.Button_SAVE_CLI.Visible = True
        Me.Button_EDIT_CLI.Visible = False
        Me.Button_NUEVO_CLI.Visible = False

        Me.TXT_DOC_CLIENTE.Focus()
        QUE_HACE_CLIENTE = "crear"
    End Sub

    Private Sub Button_EDIT_CLI_Click(sender As Object, e As EventArgs) Handles Button_EDIT_CLI.Click
        If TXT_DOC_CLIENTE.Text = "1" Then
            Exit Sub
        End If

        Label_info_cliente.Visible = True
        Label_info_cliente.Text = "Registre los Datos del Beneficiario"


        COMBO_NOM_CLIENTE_FILTRO.Visible = False

        QUE_HACE_CLIENTE = "editar"

        Button_NUEVO_CLI.Visible = False
        Button_EDIT_CLI.Visible = False
        Button_SAVE_CLI.Visible = True
    End Sub

    Private Sub Button_SAVE_CLI_Click(sender As Object, e As EventArgs) Handles Button_SAVE_CLI.Click
        Label_info_cliente.Visible = False

        If TXT_DOC_CLIENTE.Text = "" Then Exit Sub
        If TXT_NOM_CLIENTE.Text = "" Then Exit Sub


        If QUE_HACE_CLIENTE = "crear" Then
            Dim RTA As String
            RTA = MsgBox("Confirma Guardar el Contacto?." _
                & Chr(13) & "=======================================" & Chr(13) &
                "Documento:" & Me.TXT_DOC_CLIENTE.Text & "-" & TextBox_dv_cliente.Text & Chr(13) &
                "Nombre:" & Me.TXT_NOM_CLIENTE.Text & Chr(13) &
                "Teléfono:" & Me.TXT_TELS_CLIENTE.Text & Chr(13) &
                "Dirección:" & Me.TXT_DIR_CLIENTE.Text & Chr(13), MsgBoxStyle.Question + MsgBoxStyle.YesNo)
            If RTA = 6 Then
                ' se guarda
                Dim DOC As String = "", dv As String = "", TIPODOC As String = "", ES_proveedor As String = "", ES_CLIENTE As String = ""
                DOC = TXT_DOC_CLIENTE.Text
                dv = TextBox_dv_cliente.Text
                TIPODOC = "NIT"
                ES_proveedor = "SI"
                ES_CLIENTE = "SI"
                sql = "INSERT INTO proveedores(documento, dv, TIPODOCUMENTO, nombre, telefono, direccion, cliente, PROVEEDOR)" &
                      "VALUES ('" & DOC & "','" & dv & "','" & CStr(TIPODOC) & "','" & CStr(Me.TXT_NOM_CLIENTE.Text) & "','" & CStr(Me.TXT_TELS_CLIENTE.Text) & "','" & CStr(Me.TXT_DIR_CLIENTE.Text) & "','" & ES_CLIENTE & "','" & ES_proveedor & "')"
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                Try
                    da.Fill(dt)
                Catch ex As Exception
                    If ex.ToString.Contains("Duplicate entry") Then MsgBox("Ese documento ya esta registrado en la lista de contactos.", vbExclamation)
                    If ex.ToString.Contains("Duplicata") Then MsgBox("Ese documento ya esta registrado en la lista de contactos.", vbExclamation)

                    'MsgBox(ex.ToString)
                End Try
                da.Dispose()
                dt.Dispose()
                conex.Close()
                Label_info_cliente.Text = "Se Guradó el Contacto."

            End If
        End If

        If QUE_HACE_CLIENTE = "editar" Then
            Dim RTA2 As String
            RTA2 = MsgBox("Confirma Modificar los datos del Contacto?." _
                    & Chr(13) & "=======================================" & Chr(13) &
                    "Nombre:" & Me.TXT_NOM_CLIENTE.Text & Chr(13) &
                    "Documento:" & Me.TXT_DOC_CLIENTE.Text & "-" & Me.TextBox_dv_cliente.Text & Chr(13) &
                    "Teléfono:" & Me.TXT_TELS_CLIENTE.Text & Chr(13) &
                    "Dirección:" & Me.TXT_DIR_CLIENTE.Text & Chr(13), MsgBoxStyle.Question + MsgBoxStyle.YesNo)
            If RTA2 = 6 Then
                ' se guarda
                Dim DOC As String = "", dv As String = "", TIPODOC As String = "", ES_cliente As String = ""
                DOC = TXT_DOC_CLIENTE.Text
                dv = ""
                TIPODOC = "Cédula de Contacto"
                ES_cliente = "SI"

                sql = "update proveedores set documento='" & TXT_DOC_CLIENTE.Text & "', nombre='" & CStr(Me.TXT_NOM_CLIENTE.Text) & "', telefono='" & CStr(Me.TXT_TELS_CLIENTE.Text) & "', direccion='" & CStr(Me.TXT_DIR_CLIENTE.Text) & "', cliente='" & ES_cliente & "' WHERE DOCUMENTO='" & TXT_DOC_CLIENTE.Text & "'"
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                Try
                    da.Fill(dt)

                Catch ex As Exception
                    If ex.ToString.Contains("Duplicate entry") Then MsgBox("Ese documento ya esta registrado en la lista de contactos.", vbExclamation)
                    If ex.ToString.Contains("Duplicata") Then MsgBox("Ese documento ya esta registrado en la lista de contactos.", vbExclamation)

                    'MsgBox(ex.ToString)
                End Try
                da.Dispose()
                dt.Dispose()
                conex.Close()
                Label_info_cliente.Text = "Se Guradó el Contacto."
            End If
        End If



        Button_SAVE_CLI.Visible = False
        Button_EDIT_CLI.Visible = True
        Button_NUEVO_CLI.Visible = True


        COMBO_NOM_CLIENTE_FILTRO.Visible = True

        QUE_HACE_CLIENTE = ""


        'Timer_CLIENTE.Enabled = True
    End Sub

    Private Sub TextBox_valor_OnValueChanged(sender As Object, e As EventArgs) Handles TextBox_valor.OnValueChanged
        totalizar()
    End Sub
    Private Sub totalizar()
        If TextBox_impuestos.Text = "" Then TextBox_impuestos.Text = 0
        If TextBox_retenciones.Text = "" Then TextBox_retenciones.Text = 0

        If IMP_PORCENTAJE = "" Then IMP_PORCENTAJE = 0
        IMP_BASE = CDec(TextBox_valor.Text) / CDec((CDec(IMP_PORCENTAJE) / 100) + 1)
        IMP_VALOR = TextBox_valor.Text - IMP_BASE

        TextBox_imp_a_aplicar.Text = FormatNumber(IMP_VALOR, 2)


        If RETE_PORCENTAJE = "" Then RETE_PORCENTAJE = 0

        RETE_BASE = CDec(TextBox_valor.Text) / CDec((CDec(RETE_PORCENTAJE) / 100) + 1)
        RETE_VALOR = TextBox_valor.Text - RETE_BASE

        TextBox_ret_a_aplicar.Text = FormatNumber(RETE_VALOR, 2)



        TextBox_subtotal.Text = CDec(TextBox_valor.Text) - CDec(TextBox_impuestos.Text)


        TextBox_valorgasto.Text = CDec(TextBox_subtotal.Text) + CDec(TextBox_impuestos.Text) - CDec(TextBox_retenciones.Text)




    End Sub
    Private Sub TEXTBOX_BUSCAR_PROV_KeyDown(sender As Object, e As KeyEventArgs) Handles TEXTBOX_BUSCAR_PROV.KeyDown
        If e.KeyCode = "13" Then

            If TEXTBOX_BUSCAR_PROV.Text = "" Then
                Label_info_cliente.Visible = True
                Label_info_cliente.Text = "debe escribir Documento o Nombre para buscar."
                Exit Sub
            End If


            ''LLENADO COMBO  contactos
            Try
                If IsNumeric(TEXTBOX_BUSCAR_PROV.Text) = True Then sql = "SELECT documento, nombre FROM proveedores WHERE documento='" & TEXTBOX_BUSCAR_PROV.Text & "'"
                If IsNumeric(TEXTBOX_BUSCAR_PROV.Text) = False = True Then sql = "SELECT documento, nombre FROM proveedores WHERE nombre like '%" & TEXTBOX_BUSCAR_PROV.Text & "%'"

                da_contact_fitro_NTCR = New MySqlDataAdapter(sql, conex)
                dT_contact_fitro_NTCR = New DataTable
                da_contact_fitro_NTCR.Fill(dT_contact_fitro_NTCR)
                Me.COMBO_NOM_CLIENTE_FILTRO.DataSource = dT_contact_fitro_NTCR.DefaultView
                Me.COMBO_NOM_CLIENTE_FILTRO.DisplayMember = "nombre"
                Me.COMBO_NOM_CLIENTE_FILTRO.ValueMember = "documento"
                Me.COMBO_NOM_CLIENTE_FILTRO.AutoCompleteSource = AutoCompleteSource.ListItems
                Me.COMBO_NOM_CLIENTE_FILTRO.AutoCompleteMode = AutoCompleteMode.Suggest
                Me.COMBO_NOM_CLIENTE_FILTRO.SelectedItem = Nothing


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da_contact_fitro_NTCR.Dispose()
            dT_contact_fitro_NTCR.Dispose()
            conex.Close()



            COMBO_NOM_CLIENTE_FILTRO.Focus()

            COMBO_NOM_CLIENTE_FILTRO.DroppedDown = True

            Cursor.Current = Cursors.Default
        End If

    End Sub

    Private Sub Timer_cuentapuc_concepto_Tick(sender As Object, e As EventArgs) Handles Timer_cuentapuc_concepto.Tick
        Timer_cuentapuc_concepto.Enabled = False
        If Label_estado_gasto.Text = "DESCARGADO" Then Exit Sub


        If ComboBox_tipo_egreso.Text.Contains("|") = True Then
            cuenta_puc = Split(ComboBox_tipo_egreso.Text, "|")
            Exit Sub
        End If

        Try
            sql = "SELECT * FROM data_docs WHERE CONS='" & ComboBox_tipo_egreso.SelectedValue & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                cuenta_puc = Split(row.Item("CUENTA1"), "|")

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        If ComboBox_tipo_egreso.SelectedValue = Nothing Then Exit Sub
        cod_cuenta_puc = cuenta_puc(0)
        nom_cuenta_puc = cuenta_puc(1)

        TextBox_referencia.Text = ""

        If ComboBox_tipo_egreso.Text = "A Factura de Venta" Then
            If TXT_DOC_CLIENTE.Text = "" Then
                MsgBox("Seleccione el beneficiario.")
                Exit Sub
            End If

            TextBox_referencia.Text = ""

            TextBox_referencia.Enabled = True
            ComboBox_cxp.Visible = True
            ComboBox_cxp.Enabled = True

            Label5.Visible = True
            Try
                sql = "SELECT consecutivo, CONCAT(CONSECUTIVO,' de ',FECHA, ' | $ ', valor) AS FACTURA, saldo FROM carteracredito WHERE tipo='CREDITO' AND CLIENTEDOC='" & TXT_DOC_CLIENTE.Text & "' AND ESTADO='PENDIENTE'"
                da_CXC = New MySqlDataAdapter(sql, conex)
                dt_CXC = New DataTable
                da_CXC.Fill(dt_CXC)
                Me.ComboBox_cxp.DataSource = dt_CXC.DefaultView
                Me.ComboBox_cxp.DisplayMember = "FACTURA"
                Me.ComboBox_cxp.ValueMember = "CONSECUTIVO"
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da_CXC.Dispose()
            dt_CXC.Dispose()
            conex.Close()
        Else
            ComboBox_cxp.Enabled = False
            TextBox_referencia.Enabled = True
        End If

        If ComboBox_tipo_egreso.Text = "A Cuenta Por Cobrar" Then
            If TXT_DOC_CLIENTE.Text = "" Then
                MsgBox("Seleccione el beneficiario.")
                Exit Sub
            End If

            TextBox_referencia.Text = ""

            TextBox_referencia.Enabled = True
            ComboBox_cxp.Visible = True
            ComboBox_cxp.Enabled = True

            Label5.Visible = True
            Try
                sql = "SELECT consecutivo, CONCAT(CONSECUTIVO,' de ',FECHA, ' | $ ', valor) AS FACTURA, saldo FROM carteracredito WHERE tipo='CREDITO' AND CLIENTEDOC='" & TXT_DOC_CLIENTE.Text & "' AND ESTADO='PENDIENTE'"
                da_CXC = New MySqlDataAdapter(sql, conex)
                dt_CXC = New DataTable
                da_CXC.Fill(dt_CXC)
                Me.ComboBox_cxp.DataSource = dt_CXC.DefaultView
                Me.ComboBox_cxp.DisplayMember = "FACTURA"
                Me.ComboBox_cxp.ValueMember = "CONSECUTIVO"
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da_CXC.Dispose()
            dt_CXC.Dispose()
            conex.Close()
        Else
            ComboBox_cxp.Enabled = False
            TextBox_referencia.Enabled = True
        End If



        If ComboBox_tipo_egreso.Text = "A Factura de Compra" Then
            If TXT_DOC_CLIENTE.Text = "" Then
                MsgBox("Seleccione el beneficiario.")
                Exit Sub
            End If

            TextBox_referencia.Text = ""

            TextBox_referencia.Enabled = True
            ComboBox_cxp.Visible = True
            ComboBox_cxp.Enabled = True

            Label5.Visible = True
            Try
                sql = "SELECT consecutivo, CONCAT(CONSECUTIVO,' de ',FECHA, ' | $ ', valor) AS FACTURA, saldo FROM carteracredito WHERE tipo='CREDITO' AND CLIENTEDOC='" & TXT_DOC_CLIENTE.Text & "' AND ESTADO='PENDIENTE'"
                da_CXC = New MySqlDataAdapter(sql, conex)
                dt_CXC = New DataTable
                da_CXC.Fill(dt_CXC)
                Me.ComboBox_cxp.DataSource = dt_CXC.DefaultView
                Me.ComboBox_cxp.DisplayMember = "FACTURA"
                Me.ComboBox_cxp.ValueMember = "CONSECUTIVO"
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da_CXC.Dispose()
            dt_CXC.Dispose()
            conex.Close()
        Else
            ComboBox_cxp.Enabled = False
            TextBox_referencia.Enabled = True
        End If
        If ComboBox_tipo_egreso.Text = "A Cuenta Por Pagar" Then
            If TXT_DOC_CLIENTE.Text = "" Then
                MsgBox("Seleccione el beneficiario.")
                Exit Sub
            End If

            TextBox_referencia.Text = ""

            TextBox_referencia.Enabled = True
            ComboBox_cxp.Visible = True
            ComboBox_cxp.Enabled = True

            Label5.Visible = True
            Try
                sql = "SELECT consecutivo, CONCAT(CONSECUTIVO,' de ',FECHA, ' | $ ', valor) AS FACTURA, saldo FROM carteracredito WHERE tipo='CREDITO' AND CLIENTEDOC='" & TXT_DOC_CLIENTE.Text & "' AND ESTADO='PENDIENTE'"
                da_CXC = New MySqlDataAdapter(sql, conex)
                dt_CXC = New DataTable
                da_CXC.Fill(dt_CXC)
                Me.ComboBox_cxp.DataSource = dt_CXC.DefaultView
                Me.ComboBox_cxp.DisplayMember = "FACTURA"
                Me.ComboBox_cxp.ValueMember = "CONSECUTIVO"
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da_CXC.Dispose()
            dt_CXC.Dispose()
            conex.Close()
        Else
            ComboBox_cxp.Enabled = False
            TextBox_referencia.Enabled = True
        End If
    End Sub

    Private Sub TextBox_valorgasto_TextChanged(sender As Object, e As EventArgs) Handles TextBox_valorgasto.TextChanged

    End Sub

    Private Sub COMBO_NOM_CLIENTE_FILTRO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMBO_NOM_CLIENTE_FILTRO.SelectedIndexChanged

    End Sub

    Private Sub TextBox_impuestos_TextChanged(sender As Object, e As EventArgs) Handles TextBox_impuestos.TextChanged

    End Sub

    Private Sub COMBO_NOM_CLIENTE_FILTRO_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles COMBO_NOM_CLIENTE_FILTRO.SelectionChangeCommitted
        Timer_CLIENTE.Enabled = True
        TEXTBOX_BUSCAR_PROV.Text = ""
        If COMBO_NOM_CLIENTE_FILTRO.SelectedValue <> Nothing Then cli_doc = COMBO_NOM_CLIENTE_FILTRO.SelectedValue.ToString
    End Sub

    Private Sub TextBox_subtotal_TextChanged(sender As Object, e As EventArgs) Handles TextBox_subtotal.TextChanged

    End Sub

    Private Sub Timer_CLIENTE_Tick(sender As Object, e As EventArgs) Handles Timer_CLIENTE.Tick




        Timer_CLIENTE.Enabled = False


        Try
            sql = "SELECT * FROM proveedores where DOCUMENTO='" & CStr(cli_doc) & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt_clientes = New DataTable
            da.Fill(dt_clientes)
            cli_doc = ""
            For Each row As DataRow In dt_clientes.Rows
                cli_nom = row.Item("nombre")
                cli_doc = row.Item("DOCUMENTO")
                cli_tel = row.Item("TELEFONO")
                cli_dir = row.Item("DIRECCION")
                cli_mail = row.Item("email")
                imp_clienteDoc = cli_doc
                imp_clienteDoc = cli_nom
                imp_clienteTel = cli_tel
                ImpClienteDir = cli_dir
                imp_clientemail = cli_mail
            Next

            Me.TXT_DIR_CLIENTE.Text = cli_dir
            Me.TXT_TELS_CLIENTE.Text = cli_tel
            Me.TXT_DOC_CLIENTE.Text = cli_doc
            Me.TXT_NOM_CLIENTE.Text = cli_nom

            If TXT_DOC_CLIENTE.Text = "1" Or TXT_DOC_CLIENTE.Text = "" Then
                Button_EDIT_CLI.Visible = False
            Else
                Button_EDIT_CLI.Visible = True
            End If

        Catch ex As Exception
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()

        COMBO_NOM_CLIENTE_FILTRO.SelectedItem = Nothing

        ComboBox_tipo_egreso_SelectionChangeCommitted(Nothing, Nothing)

    End Sub

    Private Sub ComboBox_tipo_egreso_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_tipo_egreso.SelectionChangeCommitted
        Timer_cuentapuc_concepto.Enabled = True


        TextBox_referencia.Enabled = True
        TextBox_concepto.Enabled = True
        ComboBox_cxp.Enabled = False
        TextBox_valorgasto.Enabled = True
    End Sub

    Private Sub TextBox_valor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_valor.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""

    End Sub

    Private Sub TextBox_valorgasto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_valorgasto.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub TextBox_impuestos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_impuestos.KeyPress
        e.KeyChar = ""

    End Sub

    Private Sub TextBox_subtotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_subtotal.KeyPress
        e.KeyChar = ""

    End Sub
End Class