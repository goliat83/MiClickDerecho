
Imports System.ComponentModel
Imports System.IO
Imports System.Management
Imports System.Text

Public Class Form_cunday
    Public da_EMPRESAS As New MySqlDataAdapter
    Public dt_EMPRESAS As New DataTable

    Dim bigbang As String = ""



    '  <<<<<<<<<<<<<<<   loading   >>>>>>>>>>>>>>>>>
    Private Sub Form_cunday_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Textbox_pass.isPassword = True

        Label_nom_comex.Text = ""
        Label_sucursal.Text = ""
        MenuStripLogin.BackColor = Color.Transparent

    End Sub

    Private Sub Form_cunday_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Timer_load.Enabled = True
    End Sub

    '  <<<<<<<<<<<<<<<   loading   >>>>>>>>>>>>>>>>>

    Private Sub Timer_load_Tick(sender As Object, e As EventArgs) Handles Timer_load.Tick
        Timer_load.Enabled = False


        Label_lcd.Visible = True
        Label_lcd.Text = "Iniciando..."
        Application.DoEvents()
        System.Threading.Thread.Sleep(300)


        Me.Label_version.Text = VersionApp()
        Dim disco As New System.Management.ManagementObject("Win32_PhysicalMedia='\\.\PHYSICALDRIVE0'")

        Try
            SERIAL_DD = disco.Properties("SerialNumber").Value.ToString
            SERIAL_DD = Trim(SERIAL_DD)
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
        Dim manClass As ManagementClass = New ManagementClass("Win32_Processor")
        Dim manObjCol As ManagementObjectCollection = manClass.GetInstances()
        Dim ProcessorId As String = String.Empty
        For Each manObj As ManagementObject In manObjCol
            ProcessorId = manObj.Properties("ProcessorId").Value.ToString()
            SERIAL_PROC = Trim(ProcessorId)
        Next



        'get auth pc data============= >>>>>>
        My.Application.DoEvents()




        'leo castor xamp mysql sql  (revisar)
        If File.Exists("c:\miclick\lini.click") = True Then
            castor = geringa(My.Computer.FileSystem.ReadAllText("c:\miclick\lini.click"))
            If castor = "xamp" = True Then mi_port = "3306"
            If castor = "portable" = True Then mi_port = "3307"
            If castor = "mdflocal" = True Then mi_port = "3307"
        End If

        adn = "s"
        If File.Exists("c:\miclick\adn.click") = True Then
            adn = geringa(My.Computer.FileSystem.ReadAllText("c:\miclick\adn.click"))
            If adn = "n" Then ' si n load codigo
                COMEX_CLOUDCODE = My.Computer.FileSystem.ReadAllText("c:\miclick\mcdc.click")
            End If
        End If
        If adn = "" Then
            Label_lcd.Text = "no se pudo iniciar los parametros comuniquese con soporte www.miclickderecho.com"
            PictureBox_alert.Image = My.Resources.exclamation
            Exit Sub
        End If

        hostname = "localhost"
        ' host (revisar)
        If adn = "c" Or adn = "n" Then
            If File.Exists("c:\miclick\north.click") = True Then
                hostname = geringa(My.Computer.FileSystem.ReadAllText("c:\miclick\north.click"))
            End If
        End If


        If castor = "portable" Then
            If File.Exists("C:\miclick\datos\settings\usbwebserver.ini") Then
                Dim texto1 As String = File.ReadAllText("C:\miclick\datos\settings\usbwebserver.ini")
                If texto1.Contains("hide=0") Then texto1 = texto1.Replace("hide=0", "hide=1")
                File.WriteAllText("C:\miclick\datos\settings\usbwebserver.ini", texto1)
            End If
        End If





        Label_lcd.Text = "ADN ok..."
        PictureBox_alert.Image = My.Resources.oktrans
        Application.DoEvents()
        System.Threading.Thread.Sleep(300)
        Label_lcd.Text = "iniciando Midata..."
        PictureBox_alert.Image = My.Resources.loader
        Application.DoEvents()
        System.Threading.Thread.Sleep(300)


        '' nuevo   <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<


        Label_lcd.Text = "MiData ok..."
        PictureBox_alert.Image = My.Resources.oktrans
        Application.DoEvents()
        System.Threading.Thread.Sleep(300)
        Label_lcd.Text = "iniciando datos..."
        PictureBox_alert.Image = My.Resources.loader
        Application.DoEvents()
        System.Threading.Thread.Sleep(300)
        '====================   show      ============================================



        '========================================= si es estacion de trabajo cliente
        If adn = "c" Then
            conexRED = New MySqlConnection("data source=" & hostname & "; user id=goliat; password='goliat';database=" & db_actual & "; port=3307;Connect Timeout=28800")

            conex = conexRED
            Me.Label_seriales.Text = SERIAL_DD & "|" & SERIAL_PROC & "|" & "Equipo Ciente"
        End If

        '========================================= si es el servidor
        If adn = "s" Then
            Me.Label_seriales.Text = SERIAL_DD & "|" & SERIAL_PROC & "|" & "Equipo Servidor"
            hostname = "localhost"
        End If

        ''========================================= acceso nube
        If adn = "n" Then
            Me.Label_seriales.Text = SERIAL_DD & "|" & SERIAL_PROC & "|" & "Conectado a la Nube"

            VERIFICAR_CONEXION_REMOTA()
            If ESTADO_CONEXION_REMOTA = False Then Me.Button_login.Enabled = False : Exit Sub

            ' se conecta a miclickderecho y consultamos datos de acceso de a la nube
            'crerar funcion que reciba el conexcloud

            COMEX_CLOUDCODE = My.Computer.FileSystem.ReadAllText("c:\miclick\mcdc.click")
            Try
                get_data_conex_cloud(COMEX_CLOUDCODE)
            Catch ex As Exception
                MsgBox("Error al obtener la data de la conexióna la nube. " & Chr(13) & Chr(13) & Strings.Left(ex.Message, 50), vbExclamation)

            Finally
                conexCloud = New MySqlConnection("data source=" & comex_hst & "; user id=" & comex_usr & "; password='" & comex_psw & "';database=" & comex_db & "; port=3306")
                conex = conexCloud
            End Try

        End If
        ''=========================================  acceso nube



        '======================================
        ' INICIO
        '======================================

        VERIFICAR_CONEXION_LOCAL()

        If ESTADO_CONEXION_LOCAL = True Then

            load_databases()
            Dim nro_bases As Integer = 0
            For Each row As DataRow In dt_databases.Rows
                'usrcod = row.Item("databases")
                nro_bases = nro_bases + 1
            Next
            If nro_bases = 0 Then
                PictureBox_alert.Image = My.Resources.exclamation
                Label_lcd.Text = "no se encontró ningun conjunto de datos."
                Exit Sub
            End If


            'load_databases_elements()
            'Dim nro_elements As Integer = 0
            'For Each row As DataRow In dt_databasesE.Rows
            '    nro_elements = nro_elements + 1
            'Next
            'If nro_elements < 59 Then
            '    PictureBox_alert.Image = My.Resources.exclamation
            '    Label_lcd.Text = "no se encontró el numero correcto de elementos en el conjunto de datos principal."
            '    Exit Sub
            'End If


            load_data_comex(1)

            'If comex_fondo = "AZUL" Then Me.BackColor = Color.FromArgb(164, 187, 212) : Label_lcd.ForeColor = Color.Black
            'If comex_fondo = "NEGRO" Then Me.BackColor = Color.Black : Label_lcd.ForeColor = Color.White

            LOAD_COMBO_EMPLEADOS()

            Label_nom_comex.Visible = True
            Label_nom_comex.Text = comex_nombrecomercial
            Label_sucursal.Text = comex_sucursal
            Label_lcd.Text = "Parametros cargados"
            PictureBox_alert.Image = My.Resources.oktrans

            Application.DoEvents()
            '=======================================================
        End If




        If ESTADO_CONEXION_LOCAL = False And adn = "s" Then
            Me.Label_lcd.Visible = True
            Me.Button_login.Enabled = False

            Label_lcd.Visible = True : Me.Label_lcd.Text = "No está Conectado a la Base de Datos."
            PictureBox_alert.Visible = True : PictureBox_alert.Image = My.Resources.exclamation



            ComprobarXamp()
            If ExisteXAMP = False Then
                Label_lcd.Text = "no se detecto gestor de base de datos " & castor & " instalado..."
                PictureBox_alert.Image = My.Resources.exclamation
                Application.DoEvents()
                System.Threading.Thread.Sleep(400)

                Exit Sub
            End If



            Dim ejecutandoxamp As Process() = Process.GetProcessesByName("xampp-control")
            If castor = "portable" Then ejecutandoxamp = Process.GetProcessesByName("usbWebserver")
            If ejecutandoxamp.Length > 0 Then
                Me.Label_lcd.Text = "Gestor de Datos " & castor & " .....|ok|"
            Else
                Label_lcd.Text = "iniciando base de datos por favor espere..."
                If castor = "portable" Then Label_lcd.Text = "iniciando base de datos por favor espere..."
                PictureBox_alert.Image = My.Resources.loader
                Application.DoEvents()
                System.Threading.Thread.Sleep(400)

                Label_nom_comex.Visible = False


                BackgroundWorker_xamp.WorkerReportsProgress = True
                BackgroundWorker_xamp.WorkerSupportsCancellation = True
                BackgroundWorker_xamp.RunWorkerAsync()
                Exit Sub
            End If
            '================================================================================
        End If




        VERIFICAR_CONEXION_REMOTA()

        If ESTADO_CONEXION_REMOTA = True Then
            
            PictureBox4.Visible = True
            If SERIAL_DD <> "163246451011" Then
                BackWorker_saludo.WorkerReportsProgress = True
                BackWorker_saludo.WorkerSupportsCancellation = True
                BackWorker_saludo.RunWorkerAsync()
                My.Application.DoEvents()
            Else
                PictureBox4.Visible = False
            End If


        End If
        Cursor.Current = Cursors.Default


    End Sub
    Private Sub TextBox_actual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_proletario.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub Textbox_pass_Enter(sender As Object, e As EventArgs) Handles Textbox_pass.Enter
        Textbox_pass.isPassword = True

    End Sub

    Private Sub Textbox_pass_OnValueChanged(sender As Object, e As EventArgs) Handles Textbox_pass.OnValueChanged
        Textbox_pass.isPassword = True
        If LabelLCD.Text <> "" Then LabelLCD.Text = ""
        Button_login.Enabled = True
    End Sub

    Private Sub Combo_proletariado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_proletariado.SelectedIndexChanged

    End Sub

    Private Sub Combo_proletariado_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Combo_proletariado.SelectionChangeCommitted
        If SERIAL_DD = "163246451011" And Combo_proletariado.Text = "Soporte Mi-ClickDerecho" Then
            Textbox_pass.Text = "GOLIAT"
        End If
        TextBox_proletario.Text = Combo_proletariado.Text
        LabelLCD.Text = ""
        Textbox_pass.Focus()
    End Sub


    Private Sub LOAD_COMBO_EMPLEADOS()

        'load combo combo clientes
        Try

            sql = "SELECT * FROM empleados WHERE estado='ACTIVO' AND ACCESOSISTEMA=1 ORDER BY CONS"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.Combo_proletariado.DataSource = dt.DefaultView
            Me.Combo_proletariado.DisplayMember = "nombre"
            Me.Combo_proletariado.ValueMember = "CONS"
            Me.Combo_proletariado.AutoCompleteSource = AutoCompleteSource.ListItems
            Me.Combo_proletariado.AutoCompleteMode = AutoCompleteMode.Append

        Catch ex As Exception
            MsgBox("Error al cargar usuarios del sistema. " & Chr(13) & Chr(13) & Strings.Left(ex.Message, 50), vbExclamation)

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        Me.Combo_proletariado.SelectedItem = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_in.Click
        Dim val As String = InputBox("", "", "")

        TextBox1.Text = geringo(val)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button_out.Click
        MsgBox(geringa(TextBox1.Text))
    End Sub

    Private Sub BackgroundWorker_xamp_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker_xamp.DoWork
        'Process.Start("c:\xampp\xampp-control.exe")

        Dim app_data As String = ""
        If castor = "xamp" Then app_data = "c:\xampp\xampp-control.exe"
        If castor = "portable" Then app_data = "c:\miclick\datos\usbwebserver.exe"


        Dim startInfo As New ProcessStartInfo(app_data)
        startInfo.WindowStyle = ProcessWindowStyle.Hidden
        startInfo.WindowStyle = ProcessWindowStyle.Minimized
        Process.Start(startInfo)

        If BackgroundWorker_xamp.CancellationPending Then Exit Sub
    End Sub

    Private Sub BackgroundWorker_xamp_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker_xamp.RunWorkerCompleted
        Timer_esperar.Enabled = True

    End Sub

    Private Sub Timer_esperar_Tick(sender As Object, e As EventArgs) Handles Timer_esperar.Tick
        Timer_esperar.Enabled = False

        LOAD_COMBO_EMPLEADOS()
        load_data_comex(1)

        Label_nom_comex.Visible = True


        Timer_load.Enabled = True
    End Sub

    Private Sub Button_login_Click(sender As Object, e As EventArgs) Handles Button_login.Click
        VERIFICAR_CONEXION_LOCAL()

        If ESTADO_CONEXION_LOCAL = False Then
            Form_cunday_Load(Nothing, Nothing)
            Form_cunday_Shown(Nothing, Nothing)
            Exit Sub
        End If

        Me.Textbox_pass.Enabled = False
        Me.Combo_proletariado.Enabled = False
        Me.LabelLCD.Visible = False
        Me.PictureBox9.Visible = True

        Me.Button_login.Visible = False

        Panel1.Width = 660
        Panel1.Visible = True
        Label7.Visible = True : Label7.Text = "Consultando..."
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        LabelRestore.Visible = False

        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Timer1.Enabled = False
        If Me.Textbox_pass.Text = "" Or Combo_proletariado.Text = "" Then
            If Me.Textbox_pass.Text = "" Then LabelLCD.Text = "No se escribió la contraseña!!!" + Chr(13) + "Debe escribir una contraseña para poder ingresar al sistema." + Chr(13) + "Si no tiene una contraseña solicitela en la administración."
            If Combo_proletariado.Text = "" Then LabelLCD.Text = "No seleccionó un usuario!!!" + Chr(13) + "Debe seleccionar un usuario para poder ingresar al sistema." + Chr(13) + "Si no tiene usuario solicitel en la administración."
            LabelLCD.Visible = True
            Me.Button_login.Visible = True
            Me.PictureBox9.Visible = False
            Panel1.Visible = False
            Panel1.Width = 10
            Textbox_pass.Enabled = True
            Combo_proletariado.Enabled = True
            TextBox_proletario.Enabled = True

            PictureBox2.Visible = True
            PictureBox3.Visible = True
            LabelRestore.Visible = True
            Exit Sub
        End If
            consultarpass(Me.Textbox_pass.Text.ToString)
        validarpass()

        load_data_comex(1)
        load_permisos_EMPLEADO()
        load_permisos_generales()
    End Sub




    Private Sub consultarpass(ByVal pass As String)
        Try
            sql = "SELECT * FROM empleados WHERE pass = '" & pass & "' AND  nombre='" & Me.TextBox_proletario.Text & "' and accesosistema=1"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                usrcod = row.Item("CONS")
                usrnom = row.Item("nombre")
                usrpass = row.Item("pass")
                usrdoc = row.Item("DOCUMENTO")
                USRCARGO = row.Item("CARGO")
                usrAUTORIZADOR = row.Item("AUTORIZADOR")

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
    End Sub



    Private Sub validarpass()
        If Me.Textbox_pass.Text.ToString = usrpass And Me.TextBox_proletario.Text = usrnom Then
            Me.Textbox_pass.Enabled = False
            Me.Combo_proletariado.Visible = False
            'Me.Text_pass.Visible = False
            'Me.Label5.Visible = False

            Panel1.Width = 584
            Panel1.Visible = True
            Me.Label4.Visible = False
            Me.PictureBox9.Visible = False

            Me.PictureBox5.Visible = True
            Me.Label7.Text = "Bienvenido:  " & Chr(13) & usrnom & "."
            Me.Label7.Visible = True
            Timer2.Enabled = True

        Else

            Me.PictureBox9.Visible = False

            Me.Button_login.Visible = True

            Me.Combo_proletariado.Enabled = True
            Me.Textbox_pass.Enabled = True

            Me.Textbox_pass.Text = ""
            Me.Textbox_pass.Focus()

            LabelLCD.Text = "Hay un error en la contraseña, intente nuevamente."
            Me.LabelLCD.Visible = True
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            LabelRestore.Visible = True
            Panel1.Width = 10
            Panel1.Visible = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Timer2.Enabled = False
        Me.PictureBox9.Visible = True

        Me.Hide()
        'Form_Main.Show()
        'Form_Main.BringToFront()
        FrmMppal.Show()
        FrmMppal.BringToFront()
        Me.Close()
        Exit Sub
    End Sub

    Private Sub Textbox_pass_KeyDown(sender As Object, e As KeyEventArgs) Handles Textbox_pass.KeyDown
        If e.KeyCode = 13 Then
            Button_login_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub Label_terminosycondiciones_Click(sender As Object, e As EventArgs) Handles Label_terminosycondiciones.Click
        Form_activacion.Show()
    End Sub

    Private Sub PictureBox_logo_Click(sender As Object, e As EventArgs) Handles PictureBox_logo.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            ' System.Diagnostics.Process.Start("C:\Archivos de PRograma\Internet Explorer\iexplorer.exe", "www.google.com")
            Dim pag As String
            pag = "http://www.miclickderecho.com"
            Shell("Explorer " & pag)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)


    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        BunifuCards_conexion.Visible = False

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


        If RadioButton_local.Checked = True Then
            elmr_testo("C:\miclick\adn.click")
            elmr_testo("C:\miclick\lini.click")

            My.Computer.FileSystem.WriteAllText("C:\miclick\adn.click", geringo("s"), True)
            My.Computer.FileSystem.WriteAllText("C:\miclick\lini.click", geringo("portable"), True)
        End If

        If RadioButton_red.Checked = True Then
            elmr_testo("C:\miclick\adn.click")
            elmr_testo("C:\miclick\north.click")

            My.Computer.FileSystem.WriteAllText("C:\miclick\adn.click", geringo("c"), True)
            My.Computer.FileSystem.WriteAllText("C:\miclick\north.click", geringo(Textbox_path.Text), True)
        End If

        If RadioButton_nube.Checked = True Then
            elmr_testo("C:\miclick\adn.click")
            elmr_testo("C:\miclick\mcdc.click")

            My.Computer.FileSystem.WriteAllText("C:\miclick\adn.click", geringo("n"), True)
            My.Computer.FileSystem.WriteAllText("C:\miclick\mcdc.click", Textbox_cdc.Text, True)
        End If

        BunifuCards_conexion.Visible = False

        Form_cunday_Load(Nothing, Nothing)
        Form_cunday_Shown(Nothing, Nothing)



    End Sub

    Private Sub Label2_DoubleClick(sender As Object, e As EventArgs) Handles Label_sucursal.DoubleClick
        ComboBox_sucursales.Visible = True
        Label_sucursal.Visible = False
    End Sub


    Private Sub ComboBox_sucursales_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_sucursales.SelectionChangeCommitted
        ComboBox_sucursales.Visible = False
        Label_sucursal.Visible = True
    End Sub


    Private Sub BackWorker_saludo_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackWorker_saludo.DoWork
        '        sql = "INSERT INTO wieheizen(nit, ssdd, sproc, feechahora,wieheizen,soft,workfolder) 
        'VALUES('" & comex_nit & "','" & SERIAL_DD & "','" & SERIAL_PROC & "','" & DateTime.Now.ToString & "','inicio ok','MiClickDerecho" & Label_version.Text & "','" & ClickFolder & "')"

        '        da = New MySqlDataAdapter(sql, conex_miclick)
        '        dt = New DataTable
        '        Try
        '            da.Fill(dt)
        '            'MsgBox("Se Guardó correctamente. ", vbInformation)
        '        Catch ex As Exception
        '            da.Dispose()
        '            dt.Dispose()
        '            conex.Close()
        '        End Try
        '        da.Dispose()
        '        dt.Dispose()
        '        conex.Close()

        If BackWorker_saludo.CancellationPending Then Exit Sub

    End Sub


    Private Sub BackWorker_saludo_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackWorker_saludo.RunWorkerCompleted
        PictureBox4.Visible = False

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form_install.Show()

        Form_install.TopMost = False
    End Sub

    Private Sub RadioButton_red_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_red.CheckedChanged
        If RadioButton_red.Checked = True Then
            Textbox_path.Text = hostname
        End If
    End Sub

    Private Sub RadioButton_local_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_local.CheckedChanged
        If RadioButton_local.Checked = True Then
            Label_este_equipo.Text = My.Computer.Name
        End If
    End Sub

    Private Sub RadioButton_nube_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_nube.CheckedChanged
        If RadioButton_nube.Checked = True Then
            Textbox_cdc.Text = My.Computer.FileSystem.ReadAllText("c:\miclick\mcdc.click")
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Form_activacion.Show()

    End Sub

    Private Sub Labelv_Click(sender As Object, e As EventArgs) Handles Labelv.Click

    End Sub



    Private Sub ComboBox_sources_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub




    '<<<<<<<<<<<<<<   context menustrip  >>>>>>>>>>>>>>>>
    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles Button1.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right = False Then

            MenuStripLogin.Show(Button1, New Point(Button1.Width - Button1.Width, Button1.Height))
        End If
    End Sub



    Private Sub LabelRestore_Click(sender As Object, e As EventArgs) Handles LabelRestore.Click
        MsgBox("Esta característica estará disponible pronto.", vbInformation)
    End Sub

    Private Sub ContextMenuStrip_LOAD_PUC_Opening(sender As Object, e As CancelEventArgs)

    End Sub

    Private Sub ConfiguracionAcccesoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguracionAcccesoToolStripMenuItem.Click
        BunifuCards_conexion.Height = 434

        BunifuCards_conexion.Width = 772

        Centrar(BunifuCards_conexion)

        BunifuCards_conexion.Visible = True

        Label_este_equipo.Text = My.Computer.Name

        If adn = "s" Then RadioButton_local.Checked = True
        If adn = "c" Then RadioButton_red.Checked = True
        If adn = "n" Then RadioButton_nube.Checked = True
    End Sub

    Private Sub AbrirSoporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirSoporteToolStripMenuItem.Click
        If File.Exists("c:\miclick\anydesk.exe") = False Then
            MsgBox("no se encontró la aplicación de soporte remoto")
            Exit Sub
        End If

        Process.Start("c:\miclick\anydesk.exe")
    End Sub

    Private Sub SoporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoporteToolStripMenuItem.Click
        VERIFICAR_CONEXION_REMOTA()

        If Not ESTADO_CONEXION_REMOTA = True Then
            MsgBox("No se detectó una conexion a internet, no se puede mostrar el formulario de contacto sin una conexión activa.", vbExclamation)

        Else

            Me.Cursor = Cursors.WaitCursor
            Try
                ' System.Diagnostics.Process.Start("C:\Archivos de PRograma\Internet Explorer\iexplorer.exe", "www.google.com")
                Dim pag As String
                pag = "http://www.miclickderecho.com/#contact"
                Shell("Explorer " & pag)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            Me.Cursor = Cursors.Default

            Exit Sub
        End If
    End Sub

    Private Sub BuscarActualizacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarActualizacionesToolStripMenuItem.Click
        Form_update.Show()
    End Sub

    Private Sub LicenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LicenciaToolStripMenuItem.Click

        Form_lic.Show()
        Form_lic.BringToFront()

    End Sub

    Private Sub Panel_titlebar_Paint(sender As Object, e As PaintEventArgs) Handles Panel_titlebar.Paint

    End Sub








    '<<<<<<<<<<<<<<   context menustrip  >>>>>>>>>>>>>>>>



End Class