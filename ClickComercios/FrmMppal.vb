Imports System.ComponentModel
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Imports System.IO
Imports System.Environment
Imports System.Management
Imports System.IO.Compression

Imports System.Threading
Imports System.Threading.Tasks
Imports System.Drawing.Text
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.draw
Imports System.Drawing.Printing
Imports System.Runtime.InteropServices
Imports System.Globalization



Public Class FrmMppal

    Public oldDecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
    Public forceDotCulture As CultureInfo

    Public da_turno_actual As New MySqlDataAdapter
    Public dt_turno_actual As New DataTable

    Public Sub COLOREAR()
        If comex_fondo = "AZUL" Then
            Me.BackColor = Color.FromArgb(164, 187, 212)
            PanelLeft.BackColor = Color.FromArgb(8, 44, 71)
            PanelTop.BackColor = Color.FromArgb(8, 44, 71) '0, 84, 144

            Label_razonsocial.ForeColor = Color.Black
            Label_nombre_comercial.ForeColor = Color.Black
            Label_sucursal.ForeColor = Color.Black

            'Label_msg_ppal2.ForeColor = Color.Black
            'Label_INFO_USER.ForeColor = Color.Black
            'Label57.ForeColor = Color.Black
            'Label20.ForeColor = Color.Black
        End If

        If comex_fondo = "NEGRO" Then
            Me.BackColor = Color.Black
            PanelTop.BackColor = Color.FromArgb(10, 10, 10)
            PanelLeft.BackColor = Color.FromArgb(10, 10, 10)

            PanelTop.BackgroundImage = Nothing

            Label_razonsocial.ForeColor = Color.White
            Label_nombre_comercial.ForeColor = Color.White

            'Label_INFO_USER.ForeColor = Color.White
            'Label57.ForeColor = Color.White
            'Label20.ForeColor = Color.White
        End If

        If comex_fondo = "CLARO" Then
            Me.BackColor = Color.FromArgb(240, 240, 240)
            PanelLeft.BackColor = Color.FromArgb(0, 32, 77)
            PanelTop.BackColor = Color.FromArgb(0, 32, 77)

            Label_razonsocial.ForeColor = Color.Black
            Label_nombre_comercial.ForeColor = Color.Black

            'Label_INFO_USER.ForeColor = Color.Black
            'Label57.ForeColor = Color.Black
            'Label20.ForeColor = Color.Black
        End If
    End Sub
    Private Sub hidetabs()
        tabControlMain.TabPages.Remove(tabPage1)
        tabControlMain.TabPages.Remove(tabPage2)
        tabControlMain.TabPages.Remove(tabPage3)
        tabControlMain.TabPages.Remove(tabPage4)
        tabControlMain.TabPages.Remove(tabPage5)
        tabControlMain.TabPages.Remove(tabPage6)
        tabControlMain.TabPages.Remove(tabPage7)
        tabControlMain.TabPages.Remove(tabPage8)

    End Sub
    Private Sub Timer_turno_Tick(sender As Object, e As EventArgs) Handles Timer_turno.Tick
        Timer_turno.Enabled = False


        Try
            sql = "SELECT * FROM turnos WHERE empleado = '" & usrnom & "' and estado = '" & "ABIERTO" & "'"
            da_turno_actual = New MySqlDataAdapter(sql, conex)
            dt_turno_actual = New DataTable
            da_turno_actual.Fill(dt_turno_actual)
            If dt_turno_actual.Rows.Count > 0 Then
                For Each row As DataRow In dt_turno_actual.Rows
                    turno_actual_global_ID = row.Item("cons")
                    turno_actual_global = row.Item("cons")
                    turno_actualfecha = row.Item("fecha").ToString
                    turno_actual_global_empleado = row.Item("empleado")
                    turno_actual_inicio = row.Item("inicio")
                    turno_actual_caja = row.Item("caja")

                    Me.Label_turno_actual.Text = "Turno Actual:  " & turno_actual_global & ""
                    Me.Label_turno_actual.ForeColor = Color.White
                Next


            Else
                Me.Label_turno_actual.Text = "Turno Actual: No hay turno activo."
                Me.Label_turno_actual.ForeColor = Color.Red
                turno_actual_global_empleado = ""
                turno_actual_global_ID = ""
                turno_actual_global = ""
                turno_actualfecha = ""
                turno_actual_inicio = ""
                turno_actual_fin = ""
                turno_actual_estado = "CERRADO"
                turno_actual_caja = ""
            End If
        Catch ex As Exception
            MsgBox("no se pudo recuperar los datos de turnos. " & Chr(13) & Chr(13) & Strings.Left(ex.Message, 50), vbExclamation)
        End Try
        da_turno_actual.Dispose()
        dt_turno_actual.Dispose()
        conex.Close()
    End Sub



    ' ============== LOAD / SHOW / close ==============
    Private Sub FrmMppal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hidetabs()
        tabControlMain.TabPages.Add(tabPage8)

        forceDotCulture = Application.CurrentCulture.Clone()
        forceDotCulture.NumberFormat.NumberDecimalSeparator = ","
        forceDotCulture.NumberFormat.NumberGroupSeparator = "."
        forceDotCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        forceDotCulture.DateTimeFormat.ShortTimePattern = "h:mm t t"

        Application.CurrentCulture = forceDotCulture

        Me.Label_version.Text = VersionApp()

        'COLOREAR()

        'If File.Exists("C:\miclick\sucursal.txt") = True Then
        '    Label_sucursal.Text = (My.Computer.FileSystem.ReadAllText("C:\miclick\sucursal.txt"))
        '    Label_sucursal.Visible = True : Label_sucursal.SendToBack()

        'Else
        '    MsgBox("no existe el archivo sucursales", vbInformation)
        'End If


        ' logo
        If comex_logo <> "" Then
            If File.Exists(comex_logo) Then
                PictureBox_logo_comercio.Image = System.Drawing.Image.FromFile(comex_logo)
                PictureBox_logo_comercio.Visible = True
            Else
                LabelInfo.Text = "Anteriormmente asignó una imagen logo para mostrar, pero no se encontró el archivo asociado." & vbNewLine &
                       "Por favor elimine o asigne la imgen de logo nuevamente ingresando en: Administración > Configuración General."
                Panel_info.Visible = True
            End If
        Else
            PictureBox_logo_comercio.Image = PictureBox_logo_comercio.InitialImage
        End If


        ' CARGAR AQUI LOS DATOS DE LA SUCURSAL  SI ES SUCURSAL  LAS VARIABLES
        load_data_comex(1)

        Label_nombre_comercial.Text = comex_nombrecomercial
        Label_razonsocial.Text = comex_razonsocial
        Label_sucursal.Text = comex_sucursal

    End Sub

    Private Sub FrmMppal_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        VersionActual = VersionApp()

        Me.Label2.Text = usrnom & " (" & USRCARGO & ")"
        Me.Label3.Text = DateTime.Now.ToLongDateString



        If PERMISO__general(6) = "NO" Then
            Me.ButtonVentasCaja.Visible = False
        End If
        If PERMISO__general(6) = "SI" Then
            Me.ButtonVentasCaja.Visible = True
        End If

        'If PERMISO__general(10) = "NO" Then ' PERMITE opciones de cocina
        '    Label57.Visible = False
        '    Button26.Visible = False
        'Else
        '    Label57.Visible = True
        '    Button26.Visible = True
        'End If


        If Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\") = False Then
            Try
                My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) & "\MiClickDerecho Docs\")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

        comex_annoactual = DateTime.Now.Year.ToString



        ''activacion si no es developer pc
        If SERIAL_DD <> "0000_0000_0100_0000_4CE0_0018_DD8C_9084." Then
            Try
                get_data_auth()
            Catch ex As Exception

            End Try

            Label_TIPOSOFT.Text = comex_lic_producto : Label_TIPOSOFT.Visible = True
            Label_TIPOSOFT.Text = Label_TIPOSOFT.Text.Replace("MiClickDerecho ", "")


            If comex_lic_estado = "Inactiva" Or comex_lic_tipo = "NO" Or (comex_lic_serial <> SERIAL_DD) Then
                Form_activacion.Show()
                PanelLeft.Enabled = False
                Exit Sub
            End If
            If (comex_lic_serial <> SERIAL_DD) Then
                MsgBox("", vbInformation)
                Form_activacion.Show()
                PanelLeft.Enabled = False
            End If
        End If

        Timer_turno.Enabled = True

        btnMenu_Click(Nothing, Nothing)

    End Sub

    Private Sub FrmMppal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        For Each f As Form In Application.OpenForms
            If f.Name <> Me.Name Then
                MsgBox("Aún hay ventanas abiertas, deebe cerrarlas antes de dejar de usar el programa.", vbInformation)
                f.WindowState = vbNormal
                f.BringToFront()
                e.Cancel = True
                Exit Sub
            End If
        Next


        If MessageBox.Show("Seguro deseas dejar el trabajo por ahora?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Exit Sub
        Else
            e.Cancel = True
        End If
    End Sub

    ' ============== LOAD / SHOW / close ==============







    ' ============== botonera ==============
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If PanelLeft.Width = 58 Then
            PanelLeft.Width = 190
            Exit Sub
        End If
        If PanelLeft.Width = 190 Then
            PanelLeft.Width = 58
            Exit Sub
        End If
    End Sub
    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        If PERMISO_1(1) = "NO" Or PERMISO_1(1) = Nothing Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub



        hidetabs()
        tabControlMain.TabPages.Add(tabPage1)


        Exit Sub





        If Me.Label_turno_actual.ForeColor = Color.Red And PERMISO__general(6) = "SI" Then
            If MsgBox("Actualmente no hay un turno de ventas." & Chr(13) & Chr(13) & "Desea iniciar un nuevo turno de ventas?", MsgBoxStyle.Question + vbYesNo, "Mi ClickDerecho") = MsgBoxResult.Yes Then
                Form_caja.Show()
                Exit Sub
            End If
            Exit Sub
        End If

        If Form_sales.Visible = True Then
            Form_sales.BringToFront()
            If Form_sales.WindowState = FormWindowState.Minimized Then Form_sales.WindowState = FormWindowState.Maximized
        Else
            Form_sales.Show(Me)
        End If

        CONTINUE_PREVENTA_COD = 0

        If PERMISO_1(1) = "NO" Or PERMISO_1(1) = Nothing Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub


        If PERMISO__general(10) = "SI" Then ' PERMITE opciones de cocina

        End If


        If PERMISO__general(10) = "NO" Then ' NO PERMITE opciones de cocina

        End If


        If turno_actual_global_ID = "" Then turno_actual_global_ID = "0"


        hidetabs()
        tabControlMain.TabPages.Add(tabPage1)
    End Sub
    Private Sub btnInventario_Click(sender As Object, e As EventArgs) Handles btnInventario.Click
        If PERMISO_1(2) = "NO" Or PERMISO_1(2) = Nothing Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub





        hidetabs()
        tabControlMain.TabPages.Add(tabPage2)
    End Sub
    Private Sub btnComprobantes_Click(sender As Object, e As EventArgs) Handles btnComprobantes.Click

        If PERMISO_1(3) = "NO" Or PERMISO_1(3) = Nothing Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub


        hidetabs()
        tabControlMain.TabPages.Add(tabPage3)
    End Sub
    Private Sub btnContactos_Click(sender As Object, e As EventArgs) Handles btnContactos.Click
        hidetabs()
        tabControlMain.TabPages.Add(tabPage4)
    End Sub
    Private Sub btnConsultas_Click(sender As Object, e As EventArgs) Handles btnConsultas.Click
        If PERMISO_1(5) = "NO" Or PERMISO_1(5) = Nothing Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub


        hidetabs()
        tabControlMain.TabPages.Add(tabPage5)
    End Sub
    Private Sub btnAdministracion_Click(sender As Object, e As EventArgs) Handles btnAdministracion.Click
        If PERMISO_1(7) = "NO" Or PERMISO_1(7) = Nothing Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub


        hidetabs()
        tabControlMain.TabPages.Add(tabPage6)
    End Sub
    Private Sub btnSoporte_Click(sender As Object, e As EventArgs) Handles btnSoporte.Click
        hidetabs()
        tabControlMain.TabPages.Add(tabPage7)
    End Sub
    Private Sub btnCloseVentas_Click(sender As Object, e As EventArgs) Handles btnCloseVentas.Click
        hidetabs()
        tabControlMain.TabPages.Add(tabPage8)
    End Sub
    Private Sub btnCloseInventario_Click(sender As Object, e As EventArgs) Handles btnCloseInventario.Click
        hidetabs()
        tabControlMain.TabPages.Add(tabPage8)
    End Sub
    Private Sub btnCloseComprobantes_Click(sender As Object, e As EventArgs) Handles btnCloseComprobantes.Click
        hidetabs()
        tabControlMain.TabPages.Add(tabPage8)
    End Sub
    Private Sub btnCloseContactos_Click(sender As Object, e As EventArgs) Handles btnCloseContactos.Click
        hidetabs()
        tabControlMain.TabPages.Add(tabPage8)
    End Sub
    Private Sub btnCloseConsultas_Click(sender As Object, e As EventArgs) Handles btnCloseConsultas.Click
        hidetabs()
        tabControlMain.TabPages.Add(tabPage8)
    End Sub
    Private Sub btnCloseAdmin_Click(sender As Object, e As EventArgs) Handles btnCloseAdmin.Click
        hidetabs()
        tabControlMain.TabPages.Add(tabPage8)
    End Sub
    Private Sub btnCloseSoporte_Click(sender As Object, e As EventArgs) Handles btnCloseSoporte.Click
        hidetabs()
        tabControlMain.TabPages.Add(tabPage8)
    End Sub
    Private Sub btnCloseApp_Click(sender As Object, e As EventArgs) Handles btnCloseApp.Click
        Application.Exit()

    End Sub
    ' ============== botonera ==============









    ' ============== botones ventas ==============
    Private Sub ButtonVentasReg_Click(sender As Object, e As EventArgs) Handles ButtonVentasReg.Click
        If PERMISO__general(6) = "SI" Then
            If turno_actual_global = "" Then
                MsgBox("No tiene un turno abierto, debe abrir sun turno para registrar ventas", vbInformation)
                Exit Sub
            End If
        End If

        If Form_sales.Visible = True Then
            If Form_sales.WindowState = FormWindowState.Minimized = True Then Form_sales.WindowState = FormWindowState.Normal

            Form_sales.BringToFront()
            Exit Sub
        End If

        Form_sales.Show(Me)
    End Sub

    Private Sub ButtonVentasBuscar_Click(sender As Object, e As EventArgs) Handles ButtonVentasBuscar.Click
        Form_informes.Show()
        Thread.Sleep(1000)
        Form_informes.Timer1.Enabled = True
        Form_informes.BringToFront()
    End Sub

    Private Sub ButtonVentasCaja_Click(sender As Object, e As EventArgs) Handles ButtonVentasCaja.Click
        If Form_caja.Visible = True Then
            If Form_caja.WindowState = FormWindowState.Minimized = True Then Form_caja.WindowState = FormWindowState.Normal

            Form_caja.BringToFront()
            Exit Sub
        End If

        Form_caja.Show(Me)
    End Sub
    ' ============== botones ventas ==============







    ' ============== botones inventarios ==============
    Private Sub ButtonInvProds_Click(sender As Object, e As EventArgs) Handles ButtonInvProds.Click
        If PERMISO_1(8) = "NO" Or PERMISO_1(8) = Nothing Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub


        'Me.Button_cerrar_panel_almacen_Click(Nothing, Nothing)
        If Form_productos.Visible = True Or Form_produccion.WindowState = FormWindowState.Minimized Then
            If Form_productos.WindowState = FormWindowState.Minimized = True Then Form_productos.WindowState = FormWindowState.Normal

            Form_productos.BringToFront()
            'Form_productos.Checkbox_insumos.Visible = False : Form_productos.Checkbox_insumos.Checked = False
            'Form_productos.Checkbox_procesados.Visible = False : Form_productos.Checkbox_procesados.Checked = False
            Exit Sub
        End If


        Form_productos.Show(Me)
        'Form_productos.Checkbox_insumos.Visible = False
        'Form_productos.Checkbox_procesados.Visible = False
    End Sub

    Private Sub ButtonInvMovs_Click(sender As Object, e As EventArgs) Handles ButtonInvMovs.Click
        If PERMISO_1(12) = "NO" Or PERMISO_1(12) = Nothing Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub

        If Form_movimientos.Visible = True Then
            If Form_movimientos.WindowState = FormWindowState.Minimized = True Then Form_movimientos.WindowState = FormWindowState.Normal
            Form_movimientos.BringToFront()
            Exit Sub
        End If


        'Me.Button_cerrar_panel_almacen_Click(Nothing, Nothing)


        Form_movimientos.Show(Me)
    End Sub

    Private Sub ButtonInvVer_Click(sender As Object, e As EventArgs) Handles ButtonInvVer.Click

        If Form_bodega.Visible = True Then
            If Form_bodega.WindowState = FormWindowState.Minimized = True Then Form_bodega.WindowState = FormWindowState.Normal
            Form_bodega.BringToFront()

            Exit Sub
            End If

        Form_bodega.Show(Me)



    End Sub
    Private Sub ButtonInvCats_Click(sender As Object, e As EventArgs) Handles ButtonInvCats.Click
        'Button_cerrar_panel_almacen_Click(Nothing, Nothing)
        If Form_categorias.Visible = True Then
            If Form_categorias.WindowState = FormWindowState.Minimized = True Then Form_categorias.WindowState = FormWindowState.Normal

            Form_categorias.BringToFront()
            Exit Sub
        End If
        Form_categorias.Show(Me)
    End Sub
    Private Sub ButtonInvPedidos_Click(sender As Object, e As EventArgs) Handles ButtonInvPedidos.Click
        If PERMISO_1(19) = "NO" Or PERMISO_1(19) = Nothing Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub


        If FormPedidodeproveedor.Visible = True Then
            If FormPedidodeproveedor.WindowState = FormWindowState.Minimized = True Then FormPedidodeproveedor.WindowState = FormWindowState.Normal

            FormPedidodeproveedor.BringToFront()
            Exit Sub
        End If


        FormPedidodeproveedor.Show(Me)
    End Sub

    Private Sub ButtonInvDev_Click(sender As Object, e As EventArgs) Handles ButtonInvDev.Click
        If Form_devolucionescompras.Visible = True Then
            Form_devolucionescompras.BringToFront()
            Exit Sub
        End If


        Form_devolucionescompras.Show(Me)
    End Sub

    Private Sub ButtonInvProduccionParametros_Click(sender As Object, e As EventArgs) Handles ButtonInvProduccionParametros.Click

        If Form_producc_opciones.Visible = True Then
            If Form_producc_opciones.WindowState = FormWindowState.Minimized = True Then Form_producc_opciones.WindowState = FormWindowState.Normal

            Form_producc_opciones.BringToFront()
            Exit Sub
        End If


        Form_producc_opciones.Show(Me)
    End Sub

    Private Sub ButtonInvProduccionOrdenes_Click(sender As Object, e As EventArgs) Handles ButtonInvProduccionOrdenes.Click
        If Form_produccion.Visible = True Then
            If Form_produccion.WindowState = FormWindowState.Minimized = True Then Form_produccion.WindowState = FormWindowState.Normal

            Form_produccion.BringToFront()
            Exit Sub
        End If
        Form_produccion.Show(Me)
    End Sub
    ' ============== botones inventarios ==============





    ' ============== botones comprobantes ==============
    Private Sub ButtonCompCXC_Click(sender As Object, e As EventArgs) Handles ButtonCompCXC.Click

        If form_Cartera.Visible = True Then
            If form_Cartera.WindowState = FormWindowState.Minimized = True Then form_Cartera.WindowState = FormWindowState.Normal

            form_Cartera.BringToFront()
            Exit Sub
        End If
        form_Cartera.Show(Me)
    End Sub

    Private Sub ButtonCompGastos_Click(sender As Object, e As EventArgs) Handles ButtonCompGastos.Click
        If PERMISO_1(23) = "NO" Or PERMISO_1(23) = Nothing Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub

        If Form_ce.Visible = True Then
            If Form_ce.WindowState = FormWindowState.Minimized = True Then Form_ce.WindowState = FormWindowState.Normal

            Form_ce.BringToFront()
            Exit Sub
        End If

        Form_ce.Show(Me)
    End Sub

    Private Sub ButtonCompCXP_Click(sender As Object, e As EventArgs) Handles ButtonCompCXP.Click
        If Form_credito.Visible = True Then

            If Form_credito.WindowState = FormWindowState.Minimized = True Then Form_credito.WindowState = FormWindowState.Normal

            Form_credito.BringToFront()
            Exit Sub
        End If
        Form_credito.Show(Me)
    End Sub

    Private Sub ButtonCompReciboCaja_Click(sender As Object, e As EventArgs) Handles ButtonCompReciboCaja.Click
        If Form_rc.Visible = True Then
            If Form_rc.WindowState = FormWindowState.Minimized = True Then Form_rc.WindowState = FormWindowState.Normal

            Form_rc.BringToFront()
            Exit Sub
        End If
        Form_rc.Show(Me)
    End Sub

    Private Sub ButtonCompNotaDebito_Click(sender As Object, e As EventArgs) Handles ButtonCompNotaDebito.Click

    End Sub

    Private Sub ButtonCompNotaCredito_Click(sender As Object, e As EventArgs) Handles ButtonCompNotaCredito.Click

    End Sub
    ' ============== botones comprobantes ==============


    ' ============== botones contactos ==============
    Private Sub ButtonContactos_Click(sender As Object, e As EventArgs) Handles ButtonContactos.Click
        If Form_contactos.Visible = True Then
            If Form_contactos.WindowState = FormWindowState.Minimized = True Then Form_contactos.WindowState = FormWindowState.Normal

            Form_contactos.BringToFront()

            Exit Sub
        End If

        Form_contactos.Show(Me)
    End Sub
    ' ============== botones contactos ==============


    ' ============== botones Consultas ==============
    Private Sub ButtonConsultaTurnos_Click(sender As Object, e As EventArgs) Handles ButtonConsultaTurnos.Click
        If Form_informeTurnos.Visible = True Then
            If Form_informeTurnos.WindowState = FormWindowState.Minimized = True Then Form_informeTurnos.WindowState = FormWindowState.Normal

            Form_informeTurnos.BringToFront()

            Exit Sub
        End If

        Form_informeTurnos.Show(Me)
    End Sub

    Private Sub ButtonConsultaDiario_Click(sender As Object, e As EventArgs) Handles ButtonConsultaDiario.Click

        If Form_inf_diario.Visible = True Then
            If Form_inf_diario.WindowState = FormWindowState.Minimized = True Then Form_inf_diario.WindowState = FormWindowState.Normal

            Form_inf_diario.BringToFront()

            Exit Sub
        End If

        Form_inf_diario.Show(Me)
    End Sub

    Private Sub ButtonConsultaOtras_Click(sender As Object, e As EventArgs) Handles ButtonConsultaOtras.Click
        If Form_informes.Visible = True Then
            If Form_informes.WindowState = FormWindowState.Minimized = True Then Form_informes.WindowState = FormWindowState.Normal

            Form_informes.BringToFront()

            Exit Sub
        End If

        Form_informes.Show(Me)
    End Sub

    ' ============== botones Consultas ==============









    ' ============== botones administracion ==============
    Private Sub ButtonAdminEmpleados_Click(sender As Object, e As EventArgs) Handles ButtonAdminEmpleados.Click
        If Form_empleados.Visible = True Then
            Form_empleados.BringToFront()
            Exit Sub
        End If

        Form_empleados.Show(Me)
    End Sub

    Private Sub ButtonAdminImpuestos_Click(sender As Object, e As EventArgs) Handles ButtonAdminImpuestos.Click
        If PERMISO__general(5) = "SI" Then
            'Form_impuestos.Show()
            Form_impuesto.Show()

        End If
    End Sub

    Private Sub ButtonAdminConceptos_Click(sender As Object, e As EventArgs) Handles ButtonAdminConceptos.Click
        Form_contadocs.Show()

    End Sub

    Private Sub ButtonAdminCajasBancos_Click(sender As Object, e As EventArgs) Handles ButtonAdminCajasBancos.Click
        If Form_cajabancos.Visible = True Then
            Form_cajabancos.BringToFront()
            Exit Sub
        End If

        Form_cajabancos.Show(Me)
    End Sub

    Private Sub ButtonAdminConfiguraciones_Click(sender As Object, e As EventArgs) Handles ButtonAdminConfiguraciones.Click
        If Form_CONFIG.Visible = True Then
            Form_CONFIG.BringToFront()
            Exit Sub
        End If

        Form_CONFIG.Show(Me)
    End Sub
    ' ============== botones administracion ==============





    ' ============== botones soporte ==============
    Private Sub ButtonSoporteEscribir_Click(sender As Object, e As EventArgs) Handles ButtonSoporteEscribir.Click
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

    Private Sub ButtonSoporteRemoto_Click(sender As Object, e As EventArgs) Handles ButtonSoporteRemoto.Click
        If File.Exists("c:\miclick\anydesk.exe") = False Then
            MsgBox("no se encontró la aplicación de soporte remoto")
            Exit Sub
        End If

        Process.Start("c:\miclick\anydesk.exe")
    End Sub

    Private Sub ButtonSoporteAyuda_Click(sender As Object, e As EventArgs) Handles ButtonSoporteAyuda.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            ' System.Diagnostics.Process.Start("C:\Archivos de PRograma\Internet Explorer\iexplorer.exe", "www.google.com")
            Dim pag As String
            pag = "http://www.miclickderecho.com/ayuda.html"
            Shell("Explorer " & pag)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ButtonSoporteBackup_Click(sender As Object, e As EventArgs) Handles ButtonSoporteBackup.Click
        Form_bkp.Show()

    End Sub

    Private Sub ButtonSoporteUpdates_Click(sender As Object, e As EventArgs) Handles ButtonSoporteUpdates.Click
        Form_update.Show()

    End Sub
    ' ============== botones soporte ==============







    Private Sub PictureBoxLogo_Click(sender As Object, e As EventArgs) Handles PictureBoxLogo.Click
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
    End Sub

    Private Sub Button_cocina_Click(sender As Object, e As EventArgs) Handles Button_cocina.Click
        If Form_cocina.Visible = True Then
            Form_cocina.BringToFront()
            Exit Sub
        End If


        Form_cocina.Show(Me)
    End Sub

    Private Sub ButtonVentasDevolucion_Click(sender As Object, e As EventArgs) Handles ButtonVentasDevolucion.Click



        If Form_devoluciones.Visible = True Then
            If Form_devoluciones.WindowState = FormWindowState.Minimized = True Then Form_devoluciones.WindowState = FormWindowState.Normal

            Form_devoluciones.BringToFront()
            Exit Sub
        End If

        Form_devoluciones.Show(Me)
    End Sub

    Private Sub tabPage8_Click(sender As Object, e As EventArgs) Handles tabPage8.Click

    End Sub

    Private Sub Label_razonsocial_Click(sender As Object, e As EventArgs) Handles Label_razonsocial.Click

    End Sub

    Private Sub Button_info_Cerrar_Click(sender As Object, e As EventArgs) Handles Button_info_Cerrar.Click
        Panel_info.Visible = False
    End Sub


End Class