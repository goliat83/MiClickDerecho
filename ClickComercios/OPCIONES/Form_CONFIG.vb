Imports System.Data.SqlClient
Imports System.IO
Imports System.Net.Mail
Imports System.Threading


Public Class Form_CONFIG
    Dim boton_ok As String = ""

    Dim bodega_Sel As String
    Dim bodega_Sel_cod As String

    Dim cod_mediospagos As String = ""
    Dim mediospago_tipo As String = ""
    Dim mediospago_ESTADO As String = ""

    Dim cod_mediospagos_cuentas As String = ""
    Dim mediospagos_nombre As String = ""

    Dim que_hace As String = ""
    Dim lic_estado2, lic_tipo2, LIC_SSD_2 As String

    Dim regimen_comercio As String

    Dim ruta_logo As String

    Public msda As New SqlDataAdapter
    Public msdt As New DataTable

    Public da_sucursales As New MySqlDataAdapter
    Public dt_sucursales As New DataTable

    Public da_zonas As New MySqlDataAdapter
    Public dt_zonas As New DataTable


    Private Sub Panel3_MouseEnter(sender As Object, e As EventArgs) Handles Panel_info.MouseEnter
        Panel_info.BackColor = Color.SteelBlue
    End Sub

    Private Sub Panel3_MouseLeave(sender As Object, e As EventArgs) Handles Panel_info.MouseLeave
        Panel_info.BackColor = Color.Transparent

    End Sub
    Private Sub label_info_MouseEnter(sender As Object, e As EventArgs) Handles Label_info.MouseEnter
        Panel_info.BackColor = Color.SteelBlue
    End Sub

    Private Sub label_info_MouseLeave(sender As Object, e As EventArgs) Handles Label_info.MouseLeave
        Panel_info.BackColor = Color.Transparent

    End Sub
    Private Sub label_opciones_MouseEnter(sender As Object, e As EventArgs) Handles Label_opciones.MouseEnter
        Panel_opciones.BackColor = Color.SteelBlue
    End Sub

    Private Sub label_opciones_MouseLeave(sender As Object, e As EventArgs) Handles Label_opciones.MouseLeave
        Panel_opciones.BackColor = Color.Transparent

    End Sub

    Private Sub Panel_opciones_MouseEnter(sender As Object, e As EventArgs) Handles Panel_opciones.MouseEnter
        Panel_opciones.BackColor = Color.SteelBlue
    End Sub

    Private Sub Panel_opciones_MouseLeave(sender As Object, e As EventArgs) Handles Panel_opciones.MouseLeave
        Panel_opciones.BackColor = Color.Transparent

    End Sub



    Private Sub label_facturacion_MouseEnter(sender As Object, e As EventArgs) Handles Label_facturacion.MouseEnter
        Panel_facturacion.BackColor = Color.SteelBlue
    End Sub

    Private Sub label_facturacion_MouseLeave(sender As Object, e As EventArgs) Handles Label_facturacion.MouseLeave
        Panel_facturacion.BackColor = Color.Transparent

    End Sub

    Private Sub Panel_facturacion_MouseEnter(sender As Object, e As EventArgs) Handles Panel_facturacion.MouseEnter
        Panel_facturacion.BackColor = Color.SteelBlue
    End Sub

    Private Sub Panel_facturacion_MouseLeave(sender As Object, e As EventArgs) Handles Panel_facturacion.MouseLeave
        Panel_facturacion.BackColor = Color.Transparent

    End Sub

    Private Sub Panel_soporte_MouseEnter(sender As Object, e As EventArgs) Handles Panel_soporte.MouseEnter
        Panel_soporte.BackColor = Color.SteelBlue
    End Sub

    Private Sub Panel_soporte_MouseLeave(sender As Object, e As EventArgs) Handles Panel_soporte.MouseLeave
        Panel_soporte.BackColor = Color.Transparent

    End Sub
    Private Sub label_soporte_MouseEnter(sender As Object, e As EventArgs) Handles Label_soporte.MouseEnter
        Panel_soporte.BackColor = Color.SteelBlue
    End Sub

    Private Sub label_soporte_MouseLeave(sender As Object, e As EventArgs) Handles Label_soporte.MouseLeave
        Panel_soporte.BackColor = Color.Transparent

    End Sub

    Private Sub buscapuerto()
        Try
            cmbPort.Items.Clear()
            For Each puerto As String In My.Computer.Ports.SerialPortNames
                cmbPort.Items.Add(puerto)
            Next
            If cmbPort.Items.Count > 0 Then
                cmbPort.SelectedIndex = 0
            Else
                MsgBox("NO HAY PUERTOS DISPONIBLES EN TU SISTEMA")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Form_CONFIG_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        'oculto el tab
        Me.TabControl_detalle.SelectTab(0)

        Me.MetroTabPage1.Hide()
        Me.MetroTabPage1.Parent = Nothing
        Me.MetroTabPage3.Hide()
        Me.MetroTabPage3.Parent = Nothing
        Me.MetroTabPage5.Hide()
        Me.MetroTabPage5.Parent = Nothing



        If comex_regimen = "Régimen Común" Then Me.RadioButton1.Checked = True
        If comex_regimen = "Régimen Simplificado" Then Me.RadioButton2.Checked = True


        'IMAGEN ==
        If comex_logo <> "" And My.Computer.FileSystem.FileExists(comex_logo) Then PictureBox_LOGO_EMP.Image = Image.FromFile(comex_logo)
        imagepath = comex_logo
        comex_logo = comex_logo

        If comex_logo <> "" And My.Computer.FileSystem.FileExists(comex_logo) Then

            PictureBox_LOGO_EMP.Image = System.Drawing.Image.FromFile(comex_logo)
            FrmMppal.PictureBox_logo_comercio.Image = System.Drawing.Image.FromFile(comex_logo)
            ruta_logo = comex_logo

            Me.Button1.Text = "Quitar Logo"
        Else
            PictureBox_LOGO_EMP.Image = PictureBox_LOGO_EMP.InitialImage
            Me.Button1.Text = "Seleccionar Imagen"
            ruta_logo = ""
            comex_logo = ""
        End If
        '==


        '  DATOS DEL COMERCIO

        TextBox_nit.Text = comex_nit
        TextBox_dv.Text = comex_DV
        TextBox_nom_comercial.Text = comex_nombrecomercial ' nom comercial
        TextBox_razon_social.Text = comex_razonsocial ' razon social
        TextBox_propietario.Text = comex_nombrepropietario
        TextBox_docrepresentante.Text = comex_propietariodoc

        Textbox_dir.Text = comex_dircomercio
        TextBox_cels.Text = comex_cels
        TextBox_tels.Text = comex_tels
        TextBox_mailcorp.Text = comex_email
        '=================================================


        TextBox_res_dian.Text = comex_Resdian
        ComboBox_costeo.Text = comex_costo
        ComboBox_propina.Text = comex_propina
        TextBox_propinavr.Text = comex_propinavr
        ComboBox_bodega_ventas.Text = comex_bodega_ventas
        ComboBox_bodega_compras.Text = comex_bodega_compras
        ComboBox_BodProduccion.Text = comex_bodega_produccion

        Textbox_bod_ventas.Text = comex_bodega_ventas
        Textbox_bod_compras.Text = comex_bodega_compras
        Textbox_bod_prod.Text = comex_bodega_produccion


        ComboBox_backup.Text = comex_backups

        ComboBox_buscarpor.Text = comex_buscarpor

        ComboBox_cajacierre.SelectedValue = comex_cuenta_cierre
        ComboBox_cajaventas.SelectedValue = comex_cuenta_ventas


        If comex_Resdian = "" Then TextBox_res_dian.Enabled = False : Me.CheckBox_DIAN.Checked = False : Me.Panel_dian.Enabled = False
        If comex_Resdian <> "" Then
            TextBox_res_dian.Enabled = True
            Me.CheckBox_DIAN.Checked = True
            Me.Panel_dian.Enabled = True
            TextBox_rango2.Text = comex_intervalo2
            TextBox_rango.Text = comex_intervalo
            TextBox_prefijo.Text = comex_prefijo

        End If
        If comex_fechadian <> "" Then DateTimePicker_fechadian.Value = comex_fechadian

        TextBox_rango.Text = comex_intervalo


        ComboBox_buscarpor.Text = comex_buscarpor

        ComboBox_listaprecios.Text = comex_listaprecios
        ComboBox_formatoPRINT.Text = comex_formatofactura
        ComboBox_listaprecios2.Text = comex_listaprecios2
        ComboBoxciudad.Text = comex_ciudad
        TextBox_mailcorp.Text = comex_email



        If PERMISO__general(1) = "SI" Then CheckBox_asignarventas.Checked = True : Me.ComboBox_tipoempleadoventas.Text = comex_rotulovendedor
        If PERMISO__general(1) = "NO" Then CheckBox_asignarventas.Checked = False : Me.ComboBox_tipoempleadoventas.Text = ""

        If PERMISO__general(3) = "SI" Then CheckBox_factSinSaldo.Checked = True
        If PERMISO__general(3) = "NO" Then CheckBox_factSinSaldo.Checked = False

        If PERMISO__general(4) = "SI" Then CheckBox_domicilios.Checked = True
        If PERMISO__general(4) = "NO" Then CheckBox_domicilios.Checked = False

        If PERMISO__general(6) = "SI" Then CheckBox_turnos.Checked = True
        If PERMISO__general(6) = "NO" Then CheckBox_turnos.Checked = False

        If PERMISO__general(7) = "SI" Then CheckBox__guardarFACTURAS.Checked = True
        If PERMISO__general(7) = "NO" Then CheckBox__guardarFACTURAS.Checked = False

        If PERMISO__general(8) = "SI" Then
            Me.CheckBox_facturaramesas.Checked = True : Me.Label12.Visible = True : NumericUpDown_mesas.Visible = True : Label50.Visible = True : ComboBox_secciones.Visible = True
        End If

        If PERMISO__general(8) = "NO" Then
            Me.CheckBox_facturaramesas.Checked = False : Me.Label12.Visible = False : NumericUpDown_mesas.Visible = False : NumericUpDown_mesas.Value = 0 : Label50.Visible = False : ComboBox_secciones.Visible = False
        End If


        If PERMISO__general(10) = "SI" Then chechbox_cocina.Checked = True
        If PERMISO__general(10) = "NO" Then chechbox_cocina.Checked = False : chechbox_cocina.ChechedOffColor = Color.FromArgb(132, 135, 140)


        'If PERMISO__general(14) = "SI" Then BunifuCheckbox_propina.Checked = True
        'If PERMISO__general(14) = "NO" Then BunifuCheckbox_propina.Checked = False

        If PERMISO__general(15) = "SI" Then BunifuCheckbox1.Checked = True
        If PERMISO__general(15) = "NO" Then BunifuCheckbox1.Checked = False



        If PERMISO__general(16) = "SI" Then BunifuCheckbox_produccion.Checked = True
        If PERMISO__general(16) = "NO" Then BunifuCheckbox_produccion.Checked = False


        For Each printerName As String In System.Drawing.Printing.PrinterSettings.InstalledPrinters()
            ComboBox_imp_pos.Items.Add(printerName)
            ComboBox_imp_standard.Items.Add(printerName)
            ComboBox_imp_comanda.Items.Add(printerName)
        Next



        grid_bodegas()
        cargarSecciones()





    End Sub







    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Quitar Logo" Then

            sql = "UPDATE DATA_COMEX SET logo='' WHERE CONS=1"
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
            ruta_logo = ""
            PictureBox_LOGO_EMP.Image = Nothing
            FrmMppal.PictureBox_logo_comercio.Image = Nothing
            comex_logo = ""
            Button1.Text = "Seleccionar Logo"
            Exit Sub
        End If


        OpenFileDialog1.InitialDirectory = "C:\"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

            'coloco el logo
            PictureBox_LOGO_EMP.Image = Image.FromFile(OpenFileDialog1.FileName)
            FrmMppal.PictureBox_logo_comercio.Image = Image.FromFile(OpenFileDialog1.FileName)

            'alisto para guardar
            ruta_logo = OpenFileDialog1.FileName.ToString.Replace("\", "\\")
            Me.PictureBox_LOGO_EMP.Visible = True

            sql = "UPDATE DATA_COMEX SET logo='" & ruta_logo & "' WHERE CONS=1"
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

            Button1.Text = "Quitar Logo"
        Else
            PictureBox_LOGO_EMP.Image = PictureBox_LOGO_EMP.InitialImage


            ruta_logo = ""
        End If
    End Sub

    Private Sub ACTUALIZAR_PERMISO_GENERAL(ByVal PERMISO As String, ByVal ESTADO As String)
        sql = "UPDATE PERMISOS_GENERALES SET ESTADO='" & CStr(ESTADO) & "' WHERE PERMISO='" & CStr(PERMISO) & "'"
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
    End Sub

    Public Sub ChooseFolder()
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            TextBox_docrepresentante.Text = FolderBrowserDialog1.SelectedPath.ToString
        End If
    End Sub


    Private Sub Button3_Click_1(sender As Object, e As EventArgs)
        ChooseFolder()
        Dim ruta As String
        ruta = TextBox_docrepresentante.Text.Replace("\", "\\")

        sql = "UPDATE DATA_COMEX SET rutaimagenes='" & ruta & "', mostrarimagenes='" & CStr(usar_imagenes.ToString) & "' WHERE cons=1"
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
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.KeyChar = ""
    End Sub

    Private Sub TextBox_nit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_nit.KeyPress
        e.KeyChar = ""
    End Sub


    Private Sub TextBox_dv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_dv.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub MetroButton_send_Click(sender As Object, e As EventArgs) Handles MetroButton_send.Click
        VERIFICAR_CONEXION_REMOTA()
        If ESTADO_CONEXION_REMOTA = False Then
            Me.Label52.ForeColor = Color.Orange : Me.Label52.Visible = True : Me.Label52.Text = "No está Conectado a Internet."
            Me.PictureBox6.Visible = True
            Exit Sub
        End If

        If ESTADO_CONEXION_REMOTA = True Then

            Me.Label52.ForeColor = Color.LimeGreen : Me.Label52.Visible = True : Me.Label52.Text = "Está conectado a internet."
            Me.PictureBox6.Visible = False

            Dim message As New MailMessage
            Dim smtp As New SmtpClient

            message.From = New MailAddress("sistemas@miclickderecho.com")

            message.To.Add("sistemas@miclickderecho.com")
            message.Body = ("Mensaje de Mi-ClickDerecho" & comex_nombrecomercial & Chr(13) &
                            "Asunto:" & Me.MetroText_asunto.Text & Chr(13) &
                            "Mensaje Enviado Por:" + comex_nombrecomercial + " " + comex_email + Chr(13) &
                            "" + comex_tels + " " + Chr(13) + comex_cels + Chr(13) &
                            "" + Me.MetroText_mensaje.Text)
            message.Subject = ("Mensaje de Soporte Mi-ClickDerecho")

            If MetroText_adjunto.Text <> "" Then
                message.Attachments.Add(New Attachment(OpenFileDialog_mail.FileName))
            End If

            message.Priority = MailPriority.High
            smtp.Port = "587"
            smtp.Host = "mail.miclickderecho.com"

            smtp.Credentials = New Net.NetworkCredential("sistemas@miclickderecho.com", "Radiob3mba")
            Try
                smtp.Send(message)
                MsgBox("Se Envió Correctamente el mensaje." & Chr(13) & Chr(13) & "Se envió el mensaje.  " & Chr(13) & Chr(13) & "Gracias por contactarnos.", vbInformation)
            Catch ex As Exception
                'MsgBox(ex.ToString)
                MsgBox("Error al enviar el email.", vbInformation)

            End Try


        End If



    End Sub



    Private Sub MetroButton_adjuntar_Click(sender As Object, e As EventArgs) Handles MetroButton_adjuntar.Click
        If OpenFileDialog_mail.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Me.MetroText_adjunto.Text = OpenFileDialog_mail.FileName
        End If
    End Sub




    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Me.MetroText_adjunto.Text = ""
    End Sub


    Private Sub RichTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) 
        e.KeyChar = ""
    End Sub

    Private Sub ComboBox_listaprecios_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_listaprecios.SelectionChangeCommitted
        sql = "UPDATE DATA_COMEX SET listaprecios='" & Me.ComboBox_listaprecios.Text & "' WHERE cons=1"
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

        comex_listaprecios = Me.ComboBox_listaprecios.Text


    End Sub


    Private Sub ComboBox_listaprecios2_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_listaprecios2.SelectionChangeCommitted
        sql = "UPDATE DATA_COMEX SET listaprecios2='" & Me.ComboBox_listaprecios.Text & "' WHERE cons=1"
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

        comex_listaprecios = Me.ComboBox_listaprecios.Text
    End Sub





    Private Sub MetroText_adjunto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MetroText_adjunto.KeyPress
        e.KeyChar = ""

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click

        If usrnom = "Soporte Mi-ClickDerecho" Then
            Form_avanzado.Show()

        End If


    End Sub





    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        Form_activacion.Show()

    End Sub

    Private Sub TextBox_rango_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_rango.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""

    End Sub


    Private Sub TextBox_rango2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_rango2.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""

    End Sub

    Private Sub CheckBox_asignarventas_OnChange(sender As Object, e As EventArgs) Handles CheckBox_asignarventas.OnChange
        If Me.CheckBox_asignarventas.Checked = True Then Me.Label40.Visible = True : ComboBox_tipoempleadoventas.Visible = True : Button6.Visible = True
        If Me.CheckBox_asignarventas.Checked = False Then Me.Label40.Visible = False : ComboBox_tipoempleadoventas.Visible = False : ComboBox_tipoempleadoventas.Text = Nothing : Button6.Visible = False

        If CheckBox_asignarventas.Checked = True Then
            ACTUALIZAR_PERMISO_GENERAL("Permitir Asignar Ventas", "SI")
            PERMISO__general(1) = "SI"

        ElseIf CheckBox_asignarventas.Checked = False Then
            ACTUALIZAR_PERMISO_GENERAL("Permitir Asignar Ventas", "NO")
            PERMISO__general(1) = "NO"

        End If
    End Sub


    Private Sub CheckBox_facturaramesas_OnChange(sender As Object, e As EventArgs) Handles CheckBox_facturaramesas.OnChange


        If CheckBox_facturaramesas.Checked = True Then
            ACTUALIZAR_PERMISO_GENERAL("Permitir Facturar a Mesas", "SI")
            PERMISO__general(8) = "SI"
            Me.Label12.Visible = True : NumericUpDown_mesas.Visible = True : Label50.Visible = True : Button_ZONA_nueva.Visible = True : ComboBox_secciones.Visible = True
            ComboBox_secciones.Visible = True
            Button_borrar_zona.Visible = True
        ElseIf CheckBox_facturaramesas.Checked = False Then
            ACTUALIZAR_PERMISO_GENERAL("Permitir Facturar a Mesas", "NO")
            PERMISO__general(8) = "NO"
            Me.Label12.Visible = False : NumericUpDown_mesas.Visible = False : NumericUpDown_mesas.Value = 0 : Label50.Visible = False : Button_ZONA_nueva.Visible = False : ComboBox_secciones.Visible = False
            ComboBox_secciones.Visible = False
            Button_borrar_zona.Visible = False
        End If




    End Sub

    Private Sub Label_opciones_Click(sender As Object, e As EventArgs) Handles Label_opciones.Click

        'oculto el tab

        Me.MetroTabPage1.Hide()
        Me.MetroTabPage1.Parent = Nothing
        Me.MetroTabPage2.Hide()
        Me.MetroTabPage2.Parent = Nothing
        Me.MetroTabPage3.Hide()
        Me.MetroTabPage3.Parent = Nothing

        Me.MetroTabPage5.Hide()
        Me.MetroTabPage5.Parent = Nothing



        Me.MetroTabPage1.Show()
        Me.MetroTabPage1.Parent = Me.TabControl_detalle
        Panel6.Dock = DockStyle.Fill
        Panel6.BackColor = Color.White
        Panel6.BringToFront()

        Try
            sql = "SELECT * from bodegas"
            da_bodegas_config = New MySqlDataAdapter(sql, conex)
            dt_bodegas_config = New DataTable
            da_bodegas_config.Fill(dt_bodegas_config)

            MetroGrid_bodegas.DataSource = dt_bodegas_config


        Catch ex As Exception
            MsgBox(ex.Message)
            conex.Close()
            da_bodegas_config.Dispose()
            dt_bodegas_config.Dispose()
        End Try
        conex.Close()
        da_bodegas_config.Dispose()
        dt_bodegas_config.Dispose()

        MetroGrid_bodegas.Columns(0).Visible = False
        MetroGrid_bodegas.Columns(2).Visible = False
        MetroGrid_bodegas.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        MetroGrid_bodegas.Columns(4).Visible = False
        MetroGrid_bodegas.Columns(5).Visible = False
        MetroGrid_bodegas.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        MetroGrid_bodegas.ClearSelection()


        ComboBox_bodega_ventas.SelectedItem = comex_bodega_ventas
        ComboBox_bodega_compras.SelectedItem = comex_bodega_compras
        ComboBox_BodProduccion.SelectedItem = comex_bodega_produccion


        ComboBox_imp_pos.SelectedItem = comex_imppos
        ComboBox_imp_standard.SelectedItem = comex_impstandard
        ComboBox_imp_comanda.SelectedItem = comex_impcomanda

        bodega_Sel = ""
        bodega_Sel_cod = ""
    End Sub
    Private Sub grid_bodegas()
        Try
            sql = "SELECT * from bodegas"
            da_bodegas_config = New MySqlDataAdapter(sql, conex)
            dt_bodegas_config = New DataTable
            da_bodegas_config.Fill(dt_bodegas_config)

            MetroGrid_bodegas.DataSource = dt_bodegas_config



            ComboBox_bodega_ventas.Items.Clear()
            ComboBox_bodega_compras.Items.Clear()
            ComboBox_BodProduccion.Items.Clear()

            For Each row As DataRow In dt_bodegas_config.Rows
                ComboBox_bodega_ventas.Items.Add(row.Item("NombreBodega").ToString)
                ComboBox_bodega_compras.Items.Add(row.Item("NombreBodega").ToString)
                ComboBox_BodProduccion.Items.Add(row.Item("NombreBodega").ToString)
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
            conex.Close()
            da_bodegas_config.Dispose()
            dt_bodegas_config.Dispose()
        End Try
        conex.Close()
        da_bodegas_config.Dispose()
        dt_bodegas_config.Dispose()



    End Sub
    Private Sub Label_info_Click(sender As Object, e As EventArgs) Handles Label_info.Click

        'oculto el tab

        Me.MetroTabPage1.Hide()
        Me.MetroTabPage1.Parent = Nothing
        Me.MetroTabPage2.Hide()
        Me.MetroTabPage2.Parent = Nothing
        Me.MetroTabPage3.Hide()
        Me.MetroTabPage3.Parent = Nothing


        Me.MetroTabPage5.Hide()
        Me.MetroTabPage5.Parent = Nothing



        Me.MetroTabPage2.Show()
        Me.MetroTabPage2.Parent = Me.TabControl_detalle
    End Sub

    Private Sub Label_facturacion_Click(sender As Object, e As EventArgs) Handles Label_facturacion.Click

        'oculto el tab

        Me.MetroTabPage1.Hide()
        Me.MetroTabPage1.Parent = Nothing
        Me.MetroTabPage2.Hide()
        Me.MetroTabPage2.Parent = Nothing
        Me.MetroTabPage3.Hide()
        Me.MetroTabPage3.Parent = Nothing

        Me.MetroTabPage5.Hide()
        Me.MetroTabPage5.Parent = Nothing

        Panel5.BackColor = Color.White
        Panel5.BringToFront()

        Me.MetroTabPage3.Show()
        Me.MetroTabPage3.Parent = Me.TabControl_detalle




        Try
            sql = "SELECT CUENTAPUC, nombre FROM CAJAsYBANCOS where tipo='CAJA' or tipo='BANCO'"
            da_COMBO_cuentas_paracierre = New MySqlDataAdapter(sql, conex)
            dt_COMBO_cuentas_paracierre = New DataTable

            da_COMBO_cuentas_paracierre.Fill(dt_COMBO_cuentas_paracierre)

            Me.ComboBox_cajacierre.DataSource = dt_COMBO_cuentas_paracierre.DefaultView
            Me.ComboBox_cajacierre.DisplayMember = "nombre"
            Me.ComboBox_cajacierre.ValueMember = "CUENTAPUC"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_COMBO_cuentas_paracierre.Dispose()
        dt_COMBO_cuentas_paracierre.Dispose()
        conex.Close()


        Try
            sql = "SELECT CUENTAPUC, nombre FROM CAJAsYBANCOS where tipo='CAJA' or tipo='BANCO'"
            da_COMBO_cuentas_paraabrir = New MySqlDataAdapter(sql, conex)
            dt_COMBO_cuentas_paraabrir = New DataTable
            da_COMBO_cuentas_paraabrir.Fill(dt_COMBO_cuentas_paraabrir)
            Me.ComboBox_cajaventas.DataSource = dt_COMBO_cuentas_paraabrir.DefaultView
            Me.ComboBox_cajaventas.DisplayMember = "nombre"
            Me.ComboBox_cajaventas.ValueMember = "CUENTAPUC"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_COMBO_cuentas_paraabrir.Dispose()
        dt_COMBO_cuentas_paraabrir.Dispose()
        conex.Close()


        'Try
        '    sql = "SELECT cons, zona FROM zonas where estado='ACTIVA'"
        '    da_zonas = New MySqlDataAdapter(sql, conex)
        '    dt_zonas = New DataTable
        '    da_zonas.Fill(dt_zonas)
        '    Me.ComboBox_secciones.DataSource = dt_zonas.DefaultView
        '    Me.ComboBox_secciones.DisplayMember = "zona"
        '    Me.ComboBox_secciones.ValueMember = "cons"
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'conex.Close()
        'da_zonas.Dispose()
        'dt_zonas.Dispose()
        'conex.Close()



        Try
            cargarSecciones()
        Catch ex As Exception
        End Try

        ComboBox_secciones.SelectedItem = Nothing

        'CheckBox_facturaramesas_OnChange(Nothing, Nothing)



        ComboBox_cajaventas.Text = comex_cuenta_ventas
        ComboBox_cajacierre.Text = comex_cuenta_cierre

    End Sub

    Private Sub Label_licencia_Click(sender As Object, e As EventArgs) 

        'oculto el tab

        Me.MetroTabPage1.Hide()
        Me.MetroTabPage1.Parent = Nothing
        Me.MetroTabPage2.Hide()
        Me.MetroTabPage2.Parent = Nothing
        Me.MetroTabPage3.Hide()
        Me.MetroTabPage3.Parent = Nothing

        Me.MetroTabPage5.Hide()
        Me.MetroTabPage5.Parent = Nothing






    End Sub

    Private Sub Label_soporte_Click(sender As Object, e As EventArgs) Handles Label_soporte.Click

        'oculto el tab

        Me.MetroTabPage1.Hide()
        Me.MetroTabPage1.Parent = Nothing
        Me.MetroTabPage2.Hide()
        Me.MetroTabPage2.Parent = Nothing
        Me.MetroTabPage3.Hide()
        Me.MetroTabPage3.Parent = Nothing
        Me.MetroTabPage5.Hide()
        Me.MetroTabPage5.Parent = Nothing

        Panel14.BackColor = Color.White
        Panel14.BringToFront()


        Me.MetroTabPage5.Show()
        Me.MetroTabPage5.Parent = Me.TabControl_detalle


    End Sub

    Private Sub Panel_info_Click(sender As Object, e As EventArgs) Handles Panel_info.Click
        Label_info_Click(Nothing, Nothing)
    End Sub


    Private Sub Panel_opciones_Click(sender As Object, e As EventArgs) Handles Panel_opciones.Click
        Label_opciones_Click(Nothing, Nothing)

    End Sub

    Private Sub Panel_facturacion_Click(sender As Object, e As EventArgs) Handles Panel_facturacion.Click
        Label_facturacion_Click(Nothing, Nothing)

    End Sub

    Private Sub Panel_licencia_Click(sender As Object, e As EventArgs) 
        Label_licencia_Click(Nothing, Nothing)

    End Sub

    Private Sub Panel_soporte_Click(sender As Object, e As EventArgs) Handles Panel_soporte.Click
        Label_soporte_Click(Nothing, Nothing)

    End Sub






    Private Sub CheckBox_DIAN_OnChange(sender As Object, e As EventArgs) Handles CheckBox_DIAN.OnChange
        If Me.CheckBox_DIAN.Checked = True Then
            Me.Panel_dian.Enabled = True
            TextBox_res_dian.Enabled = True

            DateTimePicker_fechadian.Value = DateTime.Now
        End If

        If Me.CheckBox_DIAN.Checked = False Then
            Me.Panel_dian.Enabled = False
            comex_Resdian = ""
            comex_fechadian = ""
            comex_intervalo = ""
            comex_intervalo2 = ""
            comex_prefijo = ""

        End If
    End Sub



    Private Sub Button_guardar_bodega_Click(sender As Object, e As EventArgs) Handles Button_guardar_bodega.Click

        If TextBox7.Text = "" Then
            MsgBox("Escriba el Nombre para la bodega.")
            Exit Sub
        End If

        sql = "CREATE TABLE `bodega_" & TextBox7.Text & "` (
  `Cons` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `Fecha` text CHARACTER SET latin1 NOT NULL,
  `Codbodega` int(11) NOT NULL,
  `NomBodega` text CHARACTER SET latin1 NOT NULL,
  `TipoDocumento` text CHARACTER SET latin1 NOT NULL,
  `Documento` int(11) NOT NULL,
  `tercero` varchar(45) CHARACTER SET latin1 NOT NULL,
  `Rol` text CHARACTER SET latin1 NOT NULL,
  `CodProducto` int(11) NOT NULL,
  `Producto` text CHARACTER SET latin1 NOT NULL,
  `SaldoAnt` varchar(15) CHARACTER SET latin1 NOT NULL,
  `Entran` varchar(15) CHARACTER SET latin1 NOT NULL,
  `Salen` varchar(15) CHARACTER SET latin1 NOT NULL,
  `Saldo` varchar(15) CHARACTER SET latin1 NOT NULL,
  `ValorU` varchar(15) CHARACTER SET latin1 NOT NULL,
  `ValorTotal` varchar(15) CHARACTER SET latin1 NOT NULL,
  `Empleado` text CHARACTER SET latin1 NOT NULL,
  `Estado` text CHARACTER SET latin1 NOT NULL,
  `deci` varchar(2) CHARACTER SET latin1 NOT NULL,
  `costo` varchar(45) CHARACTER SET latin1 NOT NULL,
  `costeado` varchar(45) CHARACTER SET latin1 NOT NULL,
  `lote` varchar(45) CHARACTER SET latin1 NOT NULL,
  `vence` varchar(45) CHARACTER SET latin1 NOT NULL,
  PRIMARY KEY (`Cons`),
  UNIQUE KEY `Cons` (`Cons`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            MsgBox("se creo la bodega correctamente.")
        Catch ex As Exception

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()




        sql = "insert into bodegas(NOMBREBODEGA,ACTIVA) VALUES('" & TextBox7.Text & "','SI')"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            MsgBox("se creo la bodega correctamente.")
        Catch ex As Exception

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()





        MetroGrid_bodegas.Visible = True
        Button_agregar_bodega.Visible = True
        Button_eliminar_bodega.Visible = True


        Button_guardar_bodega.Visible = False
        Button_cancelar_bodega.Visible = False
        Button_guardar_bodega.Visible = False

        grid_bodegas()

    End Sub



    Private Sub Button_eliminar_bodega_Click(sender As Object, e As EventArgs) Handles Button_eliminar_bodega.Click


        Dim rta As String
        rta = MsgBox("Confirma Eliminar la bodega?.", MsgBoxStyle.Question + MsgBoxStyle.YesNo)

        If rta = 6 Then

            sql = "delete from bodegas where  CONS='" & bodega_Sel_cod & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception

            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()


            sql = "drop bodega_" & bodega_Sel & " "
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception

            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()



            Try
                sql = "SELECT * from bodegas"
                da_bodegas_config = New MySqlDataAdapter(sql, conex)
                dt_bodegas_config = New DataTable
                da_bodegas_config.Fill(dt_bodegas_config)

                MetroGrid_bodegas.DataSource = dt_bodegas_config


            Catch ex As Exception
                MsgBox(ex.Message)
                conex.Close()
                da_bodegas_config.Dispose()
                dt_bodegas_config.Dispose()
            End Try
            conex.Close()
            da_bodegas_config.Dispose()
            dt_bodegas_config.Dispose()

        End If

    End Sub

    Private Sub Button_buardar_datos_Click(sender As Object, e As EventArgs) Handles Button_buardar_datos.Click
        Cursor.Current = Cursors.WaitCursor

        If Me.RadioButton1.Checked = True Then
            regimen_comercio = "Régimen Común"
        End If
        If Me.RadioButton2.Checked = True Then
            regimen_comercio = "Régimen Simplificado"
        End If


        sql = "UPDATE DATA_COMEX SET regimen='" & CStr(regimen_comercio) & "', 
NOMBRECOMERCIAL='" & CStr(Me.TextBox_nom_comercial.Text) & "',
RAZONSOCIAL='" & CStr(Me.TextBox_razon_social.Text) & "',
NOMBREPROPIETARIO='" & CStr(Me.TextBox_propietario.Text) & "',  
propietariodoc='" & CStr(Me.TextBox_docrepresentante.Text) & "',   
dirCOMERCIO='" & CStr(Me.Textbox_dir.Text) & "', 
CELS='" & Me.TextBox_cels.Text & "', 
TELS='" & Me.TextBox_tels.Text & "', 
email='" & CStr(Me.TextBox_mailcorp.Text) & "', 
ciudad='" & CStr(ComboBoxciudad.Text) & "', 
sitioweb='" & Me.Textbox_website.Text & "' 
WHERE CONS=1"
        da = New MySqlDataAdapter(sql, conex)
        dt = New DataTable
        Try
            da.Fill(dt)
            MsgBox("Se actualizaron los datos.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("error actualizando los datos intente raparar el moduo comex data.")
            Exit Sub
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()

        Cursor.Current = Cursors.Default



        comex_nombrecomercial = Me.TextBox_nom_comercial.Text
        comex_razonsocial = Me.TextBox_razon_social.Text
        comex_nombrepropietario = TextBox_propietario.Text
        comex_propietariodoc = TextBox_docrepresentante.Text
        comex_dircomercio = Textbox_dir.Text
        comex_cels = TextBox_cels.Text
        comex_tels = TextBox_tels.Text
        comex_regimen = regimen_comercio
        comex_email = Me.TextBox_mailcorp.Text
        comex_ciudad = ComboBoxciudad.Text
        comex_sitioweb = Textbox_website.Text

        'actualizo info del main
        comex_nombrecomercial = FrmMppal.Label_nombre_comercial.Text
        comex_razonsocial = FrmMppal.Label_razonsocial.Text
        comex_sucursal = FrmMppal.Label_sucursal.Text

    End Sub

    Private Sub Form_CONFIG_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel_opciones_Paint(sender As Object, e As PaintEventArgs) Handles Panel_opciones.Paint

    End Sub

    Private Sub Button_cancelar_bodega_Click(sender As Object, e As EventArgs) Handles Button_cancelar_bodega.Click
        MetroGrid_bodegas.Visible = True

        Button_cancelar_bodega.Visible = False
        Button_cancelar_bodega.Visible = False

        Button_agregar_bodega.Visible = True
        Button_eliminar_bodega.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox_bodega_ventas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_bodega_ventas.SelectedIndexChanged

    End Sub

    Private Sub ComboBox_bodega_compras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_bodega_compras.SelectedIndexChanged

    End Sub

    Private Sub chechbox_cocina_OnChange(sender As Object, e As EventArgs) Handles chechbox_cocina.OnChange

        If chechbox_cocina.Checked = True Then
            ACTUALIZAR_PERMISO_GENERAL("Habilitar Opciones de Cocina", "SI")
            PERMISO__general(10) = "SI"
            'Form_Main.Button26.Visible = True
            'Form_Main.Label57.Visible = True
        ElseIf chechbox_cocina.Checked = False Then
            ACTUALIZAR_PERMISO_GENERAL("Habilitar Opciones de Cocina", "NO")
            PERMISO__general(10) = "NO"
            'Form_Main.Button26.Visible = False
            'FrmMppal.Label57.Visible = False
        End If
    End Sub

    Private Sub BunifuCheckbox2_OnChange(sender As Object, e As EventArgs) Handles BunifuCheckbox_produccion.OnChange

        If BunifuCheckbox_produccion.Checked = True Then
            ACTUALIZAR_PERMISO_GENERAL("Modulo de Produccion", "SI")
            PERMISO__general(16) = "SI"

        End If
        If BunifuCheckbox_produccion.Checked = False Then


            ACTUALIZAR_PERMISO_GENERAL("Modulo de Produccion", "NO")
            PERMISO__general(16) = "NO"
        End If


    End Sub



    Private Sub CheckBox_turnos_OnChange(sender As Object, e As EventArgs) Handles CheckBox_turnos.OnChange



        If CheckBox_turnos.Checked = True Then
            ACTUALIZAR_PERMISO_GENERAL("Habilitar Turnos", "SI")
            PERMISO__general(6) = "SI"
        ElseIf CheckBox_turnos.Checked = False Then
            ACTUALIZAR_PERMISO_GENERAL("Habilitar Turnos", "NO")
            PERMISO__general(6) = "NO"
        End If
    End Sub

    Private Sub CheckBox__guardarFACTURAS_OnChange(sender As Object, e As EventArgs) Handles CheckBox__guardarFACTURAS.OnChange

        If CheckBox__guardarFACTURAS.Checked = True Then
            ACTUALIZAR_PERMISO_GENERAL("Guardar Facturas", "SI")
            PERMISO__general(7) = "SI"
        ElseIf CheckBox__guardarFACTURAS.Checked = False Then
            ACTUALIZAR_PERMISO_GENERAL("Guardar Facturas", "NO")
            PERMISO__general(7) = "NO"
        End If
    End Sub




    Private Sub CheckBox_factSinSaldo_OnChange(sender As Object, e As EventArgs) Handles CheckBox_factSinSaldo.OnChange
        'fac sin saldo
        If CheckBox_factSinSaldo.Checked = True Then
            ACTUALIZAR_PERMISO_GENERAL("Facturar Sin Existencias", "SI")
            PERMISO__general(3) = "SI"

        ElseIf CheckBox_factSinSaldo.Checked = False Then
            ACTUALIZAR_PERMISO_GENERAL("Facturar Sin Existencias", "NO")
            PERMISO__general(3) = "NO"

        End If
    End Sub

    Private Sub CheckBox_domicilios_OnChange(sender As Object, e As EventArgs) Handles CheckBox_domicilios.OnChange
        If CheckBox_domicilios.Checked = True Then
            ACTUALIZAR_PERMISO_GENERAL("Domicilios", "SI")
            PERMISO__general(4) = "SI"
        ElseIf CheckBox_domicilios.Checked = False Then
            ACTUALIZAR_PERMISO_GENERAL("Domicilios", "NO")
            PERMISO__general(4) = "NO"
        End If
    End Sub

    Private Sub BunifuCheckbox_propina_OnChange(sender As Object, e As EventArgs)
        'If BunifuCheckbox_propina.Checked = True Then     ' contratos
        '    ACTUALIZAR_PERMISO_GENERAL("Propina Predeterminada", "SI")
        'ElseIf BunifuCheckbox_propina.Checked = False Then
        '    ACTUALIZAR_PERMISO_GENERAL("Propina Predeterminada", "NO")
        'End If
    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        sql = "UPDATE DATA_COMEX SET rotuloempventas='" & ComboBox_tipoempleadoventas.Text & "' WHERE CONS=1"
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

        comex_rotulovendedor = ComboBox_tipoempleadoventas.Text

        Button6.BackgroundImage = My.Resources.oktrans

        boton_ok = "6"
        Timer_save_ok.Enabled = True



    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        sql = "UPDATE DATA_COMEX SET 
resdian='" & TextBox_res_dian.Text & "', 
fechadian='" & DateTimePicker_fechadian.Value.ToShortDateString & "',
prefijo='" & TextBox_prefijo.Text & "', 
intervalo='" & TextBox_rango.Text & "',
intervalofin='" & TextBox_rango2.Text & "'
 WHERE CONS=1"
        da = New MySqlDataAdapter(sql, conex)
        dt = New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            MsgBox("no se pudo actualizar la infromaciòn")

        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()

        comex_Resdian = TextBox_res_dian.Text
        comex_fechadian = DateTimePicker_fechadian.Value.ToShortDateString
        comex_prefijo = TextBox_prefijo.Text
        comex_intervalo = TextBox_rango.Text
        comex_intervalo2 = TextBox_rango2.Text

        MsgBox("Se Actualizó la infromación de resolución.")

    End Sub

    Private Sub ComboBox_formatoPRINT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_formatoPRINT.SelectedIndexChanged

    End Sub

    Private Sub Button_agregar_bodega_Click(sender As Object, e As EventArgs) Handles Button_agregar_bodega.Click
        MetroGrid_bodegas.Visible = False
        Button_agregar_bodega.Visible = False
        Button_eliminar_bodega.Visible = False


        Button_guardar_bodega.Visible = True
        Button_cancelar_bodega.Visible = True
        Button_guardar_bodega.Visible = True


    End Sub

    Private Sub ComboBox_listaprecios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_listaprecios.SelectedIndexChanged

    End Sub

    Private Sub ComboBox_listaprecios2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_listaprecios2.SelectedIndexChanged

    End Sub

    Private Sub ComboBox_propina_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_propina.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        If TextBox_nit.Text = "" Then MsgBox("No se escribió el NIT del comercio.", vbInformation) : Exit Sub


        Me.Cursor = Cursors.WaitCursor
        VERIFICAR_CONEXION_REMOTA()
        If ESTADO_CONEXION_LOCAL = False Then
            MsgBox("No se detectó conexión a internet.", vbInformation)
            Exit Sub
        End If


        lic_estado2 = ""
        Try
            sql = "SELECT * FROM LICENCIAS WHERE nit='" & Me.TextBox_nit.Text & "' and SSD='" & Me.Label18.Text & "' and software='MiClickDerecho' AND ACTIVACION='" & TextBox_docrepresentante.Text & "'"
            da = New MySqlDataAdapter(sql, conex_miclick)   ' conecto a licencias_comex en www.clickderecho.net
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                lic_estado2 = row.Item("estado")

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()

        If lic_estado2 = "ACTIVA" Then
            Try
                sql = "SELECT * FROM CLIENTES WHERE nitDOC='" & Me.TextBox_nit.Text & "' AND software='MiClickDerecho'"
                da = New MySqlDataAdapter(sql, conex_miclick)   ' conecto a licencias_comex en www.clickderecho.net
                dt = New DataTable
                da.Fill(dt)
                For Each row As DataRow In dt.Rows
                    comex_nit = row.Item("nitDOC")
                    comex_DV = row.Item("dv")
                    comex_nombrecomercial = row.Item("NOMBRE")
                    comex_nombrepropietario = row.Item("PROPIETARIO")
                    comex_cels = row.Item("celular")
                    comex_tels = row.Item("telefono")
                    comex_dircomercio = row.Item("direccion")
                    comex_email = row.Item("emaiL")
                    comex_regimen = row.Item("regimenCOMERCIO")

                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da.Dispose()
            dt.Dispose()

            sql = "UPDATE DATA_comex SET nit='" & comex_nit & "', dv='" & comex_DV & "', nombrecomercial='" & comex_nombrecomercial & "', nombrepropietario='" & comex_nombrepropietario & "', email='" & comex_email & "', telS='" & comex_tels & "', dirCOMERCIO='" & comex_dircomercio & "', REGIMEN='" & comex_regimen & "' WHERE CONS=1"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
                ' MsgBox("Tarifa Actualizada.   :).", vbInformation)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()


            sql = "TRUNCATE TABLE LICS"
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



            sql = "INSERT INTO LICS  (NIT, CLIENTE, TIPO, SSDD, ESTADO) VALUES('" & comex_nit & "','" & comex_nombrecomercial & "','" & comex_lic_tipo & "','" & Label18.Text & "','ACTIVO')"
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
            Me.TopMost = False

            Me.SendToBack()

            MsgBox("SE ACTIVO LA LICENCIA CORRECTAMENTE GRACIAS POR USAR MI CLICKDERECHO.", vbInformation)


            End


        Else
            MsgBox("NO SE PUDO ACTIVAR LA LICENCIA.", vbInformation)

        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        sql = "UPDATE DATA_COMEX SET 
propina='" & ComboBox_propina.Text & "',
propinavr='" & TextBox_propinavr.Text & "'
 WHERE CONS=1"
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

        comex_propina = ComboBox_propina.Text
        comex_propinavr = TextBox_propinavr.Text
    End Sub

    Private Sub ComboBox_buscarpor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_buscarpor.SelectedIndexChanged

    End Sub

    Private Sub ComboBox_formatoPRINT_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_formatoPRINT.SelectionChangeCommitted
        sql = "UPDATE DATA_COMEX SET  
formatofactura='" & ComboBox_formatoPRINT.Text & "' WHERE CONS=1"
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


        comex_formatofactura = ComboBox_formatoPRINT.Text

    End Sub

    Private Sub ComboBox_costeo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_costeo.SelectedIndexChanged

    End Sub

    Private Sub ComboBox_propina_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_propina.SelectionChangeCommitted

    End Sub

    Private Sub ComboBox_buscarpor_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_buscarpor.SelectionChangeCommitted
        sql = "UPDATE DATA_COMEX SET 
buscarpor='" & ComboBox_buscarpor.Text & "' WHERE CONS=1"
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

        comex_buscarpor = ComboBox_buscarpor.Text

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub MetroTabPage2_Click(sender As Object, e As EventArgs) Handles MetroTabPage2.Click

    End Sub

    Private Sub ComboBox_fondo_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox_costeo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_costeo.SelectionChangeCommitted
        sql = "UPDATE DATA_COMEX SET costeo='" & ComboBox_costeo.Text & "' WHERE CONS=1"
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

        comex_costo = ComboBox_costeo.Text

    End Sub

    Private Sub MetroComboBox_cuentasparapagos_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub ComboBox_backup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_backup.SelectedIndexChanged

    End Sub

    Private Sub Form_CONFIG_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        load_data_comex(1)
        load_permisos_generales()
    End Sub

    Private Sub MetroGrid_mediospagos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub ComboBox_fondo_SelectionChangeCommitted(sender As Object, e As EventArgs)



        sql = "UPDATE DATA_COMEX SET fondo='" & comex_fondo & "' WHERE CONS=1"
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
    End Sub

    Private Sub RadioButton_efectivo_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox_cajacierre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_cajacierre.SelectedIndexChanged

    End Sub

    Private Sub ComboBox_cajaventas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_cajaventas.SelectedIndexChanged

    End Sub

    Private Sub ComboBox_backup_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_backup.SelectionChangeCommitted
        sql = "UPDATE DATA_COMEX SET BACKUPs='" & ComboBox_backup.Text & "' WHERE CONS=1"
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

        comex_backups = ComboBox_backup.Text
    End Sub

    Private Sub BunifuCards2_Paint(sender As Object, e As PaintEventArgs) Handles BunifuCards2.Paint

    End Sub




    Private Sub ComboBox_tipoempleadoventas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_tipoempleadoventas.SelectedIndexChanged

    End Sub

    Private Sub ComboBox_cajacierre_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_cajacierre.SelectionChangeCommitted
        sql = "UPDATE DATA_COMEX SET cajacierre='" & ComboBox_cajacierre.Text & "' WHERE CONS=1"
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

        comex_cuenta_cierre = ComboBox_cajacierre.Text
    End Sub

    Private Sub Timer_save_ok_Tick(sender As Object, e As EventArgs) Handles Timer_save_ok.Tick
        Timer_save_ok.Enabled = False

        If boton_ok = "6" Then
            Button6.BackgroundImage = My.Resources.save_icon_5427
        End If

    End Sub

    Private Sub BunifuCheckbox1_OnChange(sender As Object, e As EventArgs) Handles BunifuCheckbox1.OnChange
        If BunifuCheckbox1.Checked = True Then
            ACTUALIZAR_PERMISO_GENERAL("Imprimir Leyenda Propina", "SI")
            PERMISO__general(15) = "SI"
        End If

        If BunifuCheckbox1.Checked = False Then
            ACTUALIZAR_PERMISO_GENERAL("Imprimir Leyenda Propina", "NO")
            PERMISO__general(15) = "NO"
        End If
    End Sub

    Private Sub ComboBox_cajaventas_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_cajaventas.SelectionChangeCommitted
        sql = "UPDATE DATA_COMEX SET cajaventas='" & ComboBox_cajaventas.Text & "' WHERE CONS=1"
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

        comex_cuenta_ventas = ComboBox_cajaventas.Text
    End Sub

    Private Sub btnconectar_Click(sender As Object, e As EventArgs) Handles btnconectar.Click
        Try
            With SPpuerto
                .BaudRate = 9600
                .DataBits = 8
                .Parity = IO.Ports.Parity.None
                .StopBits = 1
                .PortName = cmbPort.Text
                .Open()

                If .IsOpen Then
                    lblestado.Text = "CONECTADO"
                Else
                    MsgBox("CONEXION FALLIDA!", MsgBoxStyle.Critical)
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btndesconectar_Click(sender As Object, e As EventArgs) Handles btndesconectar.Click
        SPpuerto.Close()
        lblestado.Text = "DESCONECTADO"
    End Sub

    Private Sub SPpuerto_DataReceived(sender As Object, e As Ports.SerialDataReceivedEventArgs) Handles SPpuerto.DataReceived
        Dim buffer As String
        buffer = SPpuerto.ReadExisting
        'txtrecibe.Text = buffer & vbCrLf

        Dim peso_string As String = CStr(buffer)
        peso_string = Strings.Right(peso_string, 3)
        txtrecibe.Text = txtrecibe.Text &
            Chr(13) & peso_string



    End Sub

    Private Sub btnenviar_Click(sender As Object, e As EventArgs) Handles btnenviar.Click
        If SPpuerto.IsOpen Then
            SPpuerto.WriteLine(txtenvia.Text)
        Else
            MsgBox("NO ESTAS CONECTADO", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        buscapuerto()

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        sql = "UPDATE DATA_COMEX SET 
balanzacom='" & cmbPort.Text & "'
WHERE CONS=1"
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

        comex_bodega_ventas = ComboBox_bodega_ventas.Text
    End Sub

    Private Sub MetroGrid_bodegas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid_bodegas.CellContentClick

    End Sub

    Private Sub ComboBox_tipoempleadoventas_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_tipoempleadoventas.SelectionChangeCommitted

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If bodega_Sel = "" Then
            MsgBox("debe seleccionar una bodega.")

            Exit Sub
        End If



        Select Case MessageBox.Show("Seguro desea eliminar los datos de la bodega seleccionada? " & vbNewLine & vbNewLine &
                                    "Eliminará el inventario actual y la información del kardex." & vbNewLine & vbNewLine &
                                    "Esta opción no se puede deshacer.",
                                    "Eliminar Datos de Bodega", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            Case DialogResult.Yes
                sql = "truncate table bodega_" & bodega_Sel

                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                Try
                    da.Fill(dt)
                    MsgBox("Se eliminó la información de  la bodega: " & bodega_Sel)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                da.Dispose()
                dt.Dispose()
                conex.Close()
                bodega_Sel = ""
                bodega_Sel_cod = ""
            Case DialogResult.No
                bodega_Sel = ""
                bodega_Sel_cod = ""
        End Select
        MetroGrid_bodegas.ClearSelection()

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub TextBox_nom_comercial_OnValueChanged(sender As Object, e As EventArgs) Handles TextBox_nom_comercial.OnValueChanged

    End Sub

    Private Sub TextBox_razon_social_OnValueChanged(sender As Object, e As EventArgs) Handles TextBox_razon_social.OnValueChanged

    End Sub

    Private Sub ComboBox_formatoPRINT_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox_formatoPRINT.SelectedValueChanged

    End Sub

    Private Sub MetroGrid_bodegas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid_bodegas.CellClick
        Dim row As DataGridViewRow = MetroGrid_bodegas.CurrentRow
        bodega_Sel_cod = CStr(row.Cells("cons").Value)
        bodega_Sel = CStr(row.Cells("nombrebodega").Value)

    End Sub

    Private Sub TextBox_razon_social_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_razon_social.KeyPress

    End Sub

    Private Sub TextBox_razon_social_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_razon_social.KeyDown

    End Sub

    Private Sub MetroTabPage1_Click(sender As Object, e As EventArgs) Handles MetroTabPage1.Click

    End Sub

    Private Sub TextBox_nom_comercial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_nom_comercial.KeyPress

    End Sub

    Private Sub BunifuCards5_Paint(sender As Object, e As PaintEventArgs) Handles BunifuCards5.Paint

    End Sub

    Private Sub TextBox_nom_comercial_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_nom_comercial.KeyDown

    End Sub

    Private Sub ComboBox_BodProduccion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_BodProduccion.SelectedIndexChanged

    End Sub

    Private Sub ComboBox_bodega_ventas_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_bodega_ventas.SelectionChangeCommitted

        Textbox_bod_ventas.Text = ComboBox_bodega_ventas.Text


        sql = "UPDATE DATA_COMEX SET 
bodventas='" & ComboBox_bodega_ventas.Text & "'
WHERE CONS=1"
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

        comex_bodega_ventas = ComboBox_bodega_ventas.Text
        Textbox_bod_ventas.Text = ComboBox_bodega_ventas.Text

    End Sub

    Private Sub Textbox_dir_OnValueChanged(sender As Object, e As EventArgs) Handles Textbox_dir.OnValueChanged

    End Sub

    Private Sub Textbox_bod_ventas_OnValueChanged(sender As Object, e As EventArgs) Handles Textbox_bod_ventas.OnValueChanged

    End Sub

    Private Sub ComboBox_bodega_compras_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_bodega_compras.SelectionChangeCommitted
        Textbox_bod_compras.Text = ComboBox_bodega_compras.Text


        sql = "UPDATE DATA_COMEX SET 
bodcompras='" & ComboBox_bodega_compras.Text & "'
WHERE CONS=1"
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

        comex_bodega_compras = ComboBox_bodega_compras.Text
        Textbox_bod_compras.Text = ComboBox_bodega_compras.Text

    End Sub

    Private Sub Textbox_bod_compras_OnValueChanged(sender As Object, e As EventArgs) Handles Textbox_bod_compras.OnValueChanged

    End Sub

    Private Sub ComboBox_BodProduccion_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_BodProduccion.SelectionChangeCommitted

        sql = "UPDATE DATA_COMEX SET 
bodproduccion='" & ComboBox_BodProduccion.Text & "'
WHERE CONS=1"
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

        comex_bodega_produccion = ComboBox_BodProduccion.Text

        Textbox_bod_prod.Text = ComboBox_BodProduccion.Text

    End Sub

    Private Sub Textbox_bod_prod_OnValueChanged(sender As Object, e As EventArgs) Handles Textbox_bod_prod.OnValueChanged

    End Sub

    Private Sub Textbox_bod_ventas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Textbox_bod_ventas.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub Textbox_bod_compras_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Textbox_bod_compras.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs)
        Form_activacion.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NumericUpDown_mesas_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_mesas.ValueChanged

    End Sub



    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button_probar_pos_Click(sender As Object, e As EventArgs) Handles Button_probar_pos.Click
        If ComboBox_imp_pos.Text <> "" Then
            MsgBox("Seleccione una impresora.")
            Exit Sub
        End If



        Dim impresosaPredt As String = ComboBox_imp_pos.Text

        Process.Start("C:\Program Files\Tracker Software\PDF Viewer\pdfxcview.exe", " /print:printer=""" & impresosaPredt & """ """ & Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\factura " & 1 & ".pdf" & """")

    End Sub

    Private Sub Button_probar_standard_Click(sender As Object, e As EventArgs) Handles Button_probar_standard.Click
        If ComboBox_imp_standard.Text <> "" Then
            MsgBox("Seleccione una impresora.")
            Exit Sub

        End If

        Dim impresosaPredt As String = ComboBox_imp_standard.Text

        Process.Start("C:\Program Files\Tracker Software\PDF Viewer\pdfxcview.exe", " /print:printer=""" & impresosaPredt & """ """ & Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\factura " & 1 & ".pdf" & """")

    End Sub

    Private Sub Button_probar_comanda_Click(sender As Object, e As EventArgs) Handles Button_probar_comanda.Click
        If ComboBox_imp_comanda.Text <> "" Then
            MsgBox("Seleccione una impresora.")
            Exit Sub

        End If

        Dim impresosaPredt As String = ComboBox_imp_comanda.Text

        Process.Start("C:\Program Files\Tracker Software\PDF Viewer\pdfxcview.exe", " /print:printer=""" & impresosaPredt & """ """ & Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\factura " & 1 & ".pdf" & """")

    End Sub

    Private Sub ComboBox_imp_pos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_imp_pos.SelectedIndexChanged

    End Sub

    Private Sub Textbox_bod_prod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Textbox_bod_prod.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub ComboBox_imp_standard_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_imp_standard.SelectedIndexChanged

    End Sub

    Private Sub ComboBox_imp_comanda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_imp_comanda.SelectedIndexChanged

    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress

        If InStr(1, "ABCDEFGHIJKLMNOPQRSTUVWXYZ" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""

    End Sub

    Private Sub ComboBox_imp_pos_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_imp_pos.SelectionChangeCommitted
        sql = "UPDATE DATA_COMEX SET imppos='" & ComboBox_imp_pos.Text & "' WHERE CONS=1"
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
    End Sub

    Private Sub Panel10_Paint(sender As Object, e As PaintEventArgs) 

    End Sub



    Private Sub ComboBox_imp_standard_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_imp_standard.SelectionChangeCommitted
        sql = "UPDATE DATA_COMEX SET impstandard='" & ComboBox_imp_standard.Text & "' WHERE CONS=1"
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
    End Sub

    Private Sub ComboBox_imp_comanda_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_imp_comanda.SelectionChangeCommitted


        sql = "UPDATE DATA_COMEX SET impcomanda='" & ComboBox_imp_comanda.Text & "' WHERE CONS=1"
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


    End Sub

    Private Sub Button_borrar_zona_Click(sender As Object, e As EventArgs) Handles Button_borrar_zona.Click
        Try
            sql = "delete from zonas WHERE cons='" & Me.ComboBox_secciones.SelectedValue & "'"
            da = New MySqlDataAdapter(sql, conex)   ' conecto a licencias_comex en www.clickderecho.net
            dt = New DataTable
            da.Fill(dt)

        Catch ex As Exception
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()

        cargarSecciones()

    End Sub

    Private Sub ComboBox_secciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_secciones.SelectedIndexChanged

    End Sub

    Private Sub NumericUpDown_mesas_VisibleChanged(sender As Object, e As EventArgs) Handles NumericUpDown_mesas.VisibleChanged

    End Sub

    Private Sub BunifuCheckbox2_OnChange_1(sender As Object, e As EventArgs) Handles BunifuCheckbox2.OnChange

    End Sub

    Private Sub Panel11_Paint(sender As Object, e As PaintEventArgs) Handles Panel11.Paint

    End Sub

    Private Sub Button_zona_guardar_Click(sender As Object, e As EventArgs) Handles Button_zona_guardar.Click


        If TextBox_zona_nom.Text = "" Then
            Exit Sub

        End If

        sql = "insert into zonas (zona, mesas, ESTADO) values('" & TextBox_zona_nom.Text & "','" & NumericUpDown_mesas.Validate & "','ACTIVA')"
        da = New MySqlDataAdapter(sql, conex)
        dt = New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            If ex.ToString.Contains("duplicate") = True Then
                MsgBox("ya existe una zona con ese nombre, por favor escriba un nombre diferente.")
                da.Dispose()
                dt.Dispose()
                conex.Close()
            End If
            Exit Sub
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()



        Try
            cargarSecciones()
        Catch ex As Exception
        End Try


        Button_zona_guardar.Visible = False
        NumericUpDown_mesas.Visible = True : NumericUpDown_mesas.Enabled = False
        TextBox_zona_nom.Visible = False : TextBox_zona_nom.Enabled = False

        ComboBox_secciones.Visible = True

        Button_ZONA_nueva.Visible = True
        Button_borrar_zona.Visible = True
        Button_zona_cancelar.Visible = False




    End Sub



    Private Sub Button_ZONA_nueva_Click(sender As Object, e As EventArgs) Handles Button_ZONA_nueva.Click
        Button_zona_guardar.Visible = True
        NumericUpDown_mesas.Visible = True : NumericUpDown_mesas.Enabled = True
        TextBox_zona_nom.Visible = True : TextBox_zona_nom.Enabled = True

        ComboBox_secciones.Visible = False

        Button_ZONA_nueva.Visible = False
        Button_borrar_zona.Visible = False
        Button_zona_cancelar.Visible = True
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Button_zona_cancelar_Click(sender As Object, e As EventArgs) Handles Button_zona_cancelar.Click
        Button_zona_cancelar.Visible = False
        Button_zona_guardar.Visible = False
        Button_ZONA_nueva.Visible = True
        Button_borrar_zona.Visible = True
        ComboBox_secciones.Visible = True
        TextBox_nueva_seccion.Visible = False
        NumericUpDown_mesas.Enabled = False

    End Sub



    Private Sub cargarSecciones()
        Try
            sql = "SELECT cons, zona from zonas"
            da_zonas = New MySqlDataAdapter(sql, conex)
            dt_zonas = New DataTable
            da_zonas.Fill(dt_zonas)

            ComboBox_secciones.DataSource = dt_zonas.DefaultView
            ComboBox_secciones.DisplayMember = "zona"
            ComboBox_secciones.ValueMember = "CONS"

        Catch ex As Exception
            Cursor.Current = Cursors.Default
        End Try
        conex.Close()
        da_zonas.Dispose()
        dt_zonas.Dispose()
        conex.Close()
    End Sub

    Private Sub ComboBox_secciones_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_secciones.SelectionChangeCommitted
        NumericUpDown_mesas.Value = 0
        Try
            sql = "select mesas from zonas WHERE cons='" & Me.ComboBox_secciones.SelectedValue & "'"
            da = New MySqlDataAdapter(sql, conex)   ' conecto a licencias_comex en www.clickderecho.net
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                NumericUpDown_mesas.Value = row.Item("mesas")
            Next
        Catch ex As Exception
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
    End Sub
End Class