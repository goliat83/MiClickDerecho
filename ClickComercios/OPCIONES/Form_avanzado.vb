Imports System.Data.SqlClient
Imports System.Drawing.Text
Imports System.IO
Imports System.Net
Imports System.Data.OleDb
Public Class Form_avanzado


    Dim file_db As String = ""
    Dim tabla_import_export As String
    Dim pfc_avanzado As New PrivateFontCollection

    Public da_tablas As New MySqlDataAdapter
    Public dt_tablas As New DataTable


    Public msda_tablas As New SqlDataAdapter
    Public msdt_tablas As New DataTable

    Private Sub BTN_elim_tabla_Click(sender As Object, e As EventArgs) Handles BTN_elim_tabla.Click

        If Me.ComboBox_tablas.Text = "" Then
            Me.Label_info.Text = "Seleccione una opción del listado."
            Exit Sub
        End If




        If Me.ComboBox_tablas.Text <> "" Then
            Me.Cursor = Cursors.WaitCursor

            sql = "truncate table " & ComboBox_tablas.Text

            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
                Me.Label_info.Text = "Se elimino la información de  ==> " & Me.ComboBox_tablas.Text : Me.Label_info.Visible = True
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()
            Me.Cursor = Cursors.Default

        End If

    End Sub

    Private Sub ComboBox_tablas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_tablas.SelectedIndexChanged

    End Sub



    Private Sub MetroTabPage1_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub Form_avanzado_Shown(sender As Object, e As EventArgs) Handles Me.Shown







    End Sub

    Private Sub Form_avanzado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub





    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox1.Text = "TRUNCATE `ventas`;
TRUNCATE `ventas_credito`;
TRUNCATE `ventas_credito_prods`;
TRUNCATE `ventas_dctos`;
TRUNCATE `ventas_dctos_temp`;
TRUNCATE `ventas_pre`;
TRUNCATE `ventas_prods`;
TRUNCATE `ventas_prods_temp`;
TRUNCATE `turnos`;
TRUNCATE `soportes`;
TRUNCATE `resources`;
TRUNCATE `recibos_nomina`;
TRUNCATE `recibos_egresos`;
TRUNCATE `recibos_caja`;
TRUNCATE `proveedores`;
TRUNCATE `pedidosprov_prods`;
TRUNCATE `pedidosprov`;
TRUNCATE `pedidosclientes_prods`;
TRUNCATE `pedidosclientes`;
TRUNCATE `oproducciondetalles`;
TRUNCATE `oproduccion`;
TRUNCATE `movimientoscuentas`;
TRUNCATE `movimientos_prods`;
TRUNCATE `movimientos`;
TRUNCATE `domicilios`;
TRUNCATE `devolucionescompras_prods`;
TRUNCATE `devolucionescompras`;
TRUNCATE `devoluciones_prods`;
TRUNCATE `devoluciones`;
TRUNCATE `data_cloud`;
TRUNCATE `cotizaciones_prods`;
TRUNCATE `cotizaciones`;
TRUNCATE `comprobantes`;
TRUNCATE `compras_prods`;
TRUNCATE `compras_credito_prods`;
TRUNCATE `compras`;
TRUNCATE `compras_credito`;
TRUNCATE `carteracredito`;
TRUNCATE `cajaspuc`;
TRUNCATE `caja`;
TRUNCATE `bodega_ventas`;
TRUNCATE `bodega_principal`;"

        Exit Sub


        Dim RTA As String
        RTA = MsgBox("Desea realmente eliminar to la información de Empleados, productos, inventarios, gastos, domicilios, compras y ventas?.", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo)
        If RTA = 6 Then
            Me.Cursor = Cursors.WaitCursor
            Me.Cursor = Cursors.WaitCursor
            sql = "
TRUNCATE `caja`;
TRUNCATE `cajaspuc`;
TRUNCATE `carteracredito`;
TRUNCATE `compras_credito`;
TRUNCATE `compras`;
TRUNCATE `compras_credito_prods`;
TRUNCATE `compras_prods`;
TRUNCATE `comprobantes`;
TRUNCATE `cotizaciones`;
TRUNCATE `cotizaciones_prods`;
TRUNCATE `devoluciones`;
TRUNCATE `devoluciones_prods`;
TRUNCATE `devolucionescompras`;
TRUNCATE `devolucionescompras_prods`;
TRUNCATE `domicilios`;
TRUNCATE `movimientos`;
TRUNCATE `movimientos_prods`;
TRUNCATE `movimientoscuentas`;
TRUNCATE `oproduccion`;
TRUNCATE `oproducciondetalles`;
TRUNCATE `pedidosclientes`;
TRUNCATE `pedidosclientes_prods`;
TRUNCATE `pedidosprov`;
TRUNCATE `pedidosprov_prods`;
TRUNCATE `recibos_caja`;
TRUNCATE `recibos_egresos`;
TRUNCATE `recibos_nomina`;
TRUNCATE `soportes`;
TRUNCATE `turnos`;
TRUNCATE `ventas`;
TRUNCATE `ventas_credito`;
TRUNCATE `ventas_credito_prods`;
TRUNCATE `ventas_DCTOS`;
TRUNCATE `ventas_DCTOS_TEMP`;
TRUNCATE `ventas_pre`;
TRUNCATE `ventas_prods`;
TRUNCATE `ventas_prods_temp`;"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
                Me.Label_info.Text = "Se eliminó toda la información." : Me.Label_info.Visible = True
            Catch ex As Exception
                If ex.ToString.Contains("Duplicate entry") Then MsgBox("Error al eliminar la información solicitada.", vbExclamation)
                MsgBox(ex.ToString)
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button_restore_Click(sender As Object, e As EventArgs) Handles Button_restore.Click
        If adn <> "s" Then
            MsgBox("esta operación solo se puede ejecutar en un equipo servidor")
            Exit Sub
        End If



        If OpenFileDialog_mail.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            file_db = OpenFileDialog_mail.FileName


            Dim RTA As String
            RTA = MsgBox("Advertencia?." & Chr(13) & Chr(13) & "Este proceso Instala los datos por defecto, y elimina toda la información existente en la base de datos principal.", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo)
            If RTA = 6 Then
                Me.Cursor = Cursors.WaitCursor

                Try
                    sql = "drop database miclickdb;"
                    da = New MySqlDataAdapter(sql, conexdb)
                    dt = New DataTable
                    da.Fill(dt)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    conexdbnopass.Close()
                    da.Dispose()
                    dt.Dispose()
                End Try
                conex.Close()
                da.Dispose()
                dt.Dispose()



                Try
                    sql = "CREATE database miclickdb;"
                    da = New MySqlDataAdapter(sql, conexdb)
                    dt = New DataTable
                    da.Fill(dt)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    conexdbnopass.Close()
                    da.Dispose()
                    dt.Dispose()
                End Try
                conex.Close()
                da.Dispose()
                dt.Dispose()

                System.Threading.Thread.Sleep(3000)


                Try
                    Dim myProcess As New Process()

                    myProcess.StartInfo.FileName = "cmd.exe"
                    myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                    myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                    myProcess.StartInfo.UseShellExecute = False
                    myProcess.StartInfo.WorkingDirectory = "C:\MiClick\Datos\mysql\bin"
                    myProcess.StartInfo.RedirectStandardInput = True
                    myProcess.StartInfo.RedirectStandardOutput = True
                    myProcess.Start()
                    Dim myStreamWriter As StreamWriter = myProcess.StandardInput
                    Dim mystreamreader As StreamReader = myProcess.StandardOutput

                    myStreamWriter.WriteLine("mysql -u root -pRadiobemba miclickdb < " & CStr(file_db) & "")

                    myStreamWriter.Close()
                    myProcess.WaitForExit()
                    myProcess.Close()
                Catch ex As Exception
                    Exit Sub
                End Try


                Label_info.Text = "Se importaron los datos correctamente."
            End If
            Me.Cursor = Cursors.Default



        End If



    End Sub













    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)
    End Sub



    Private Sub ComboBox2_SelectionChangeCommitted(sender As Object, e As EventArgs)




    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)


        VERIFICAR_CONEXION_LOCAL()
        If ESTADO_CONEXION_LOCAL = True Then MsgBox("conexión ok.", vbInformation)
        If ESTADO_CONEXION_LOCAL = False Then MsgBox("falló la conexión.", vbExclamation)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)

    End Sub




    Private Sub Button_cerrar_Click(sender As Object, e As EventArgs) Handles Button_cerrar.Click
        Me.Close()

    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        Dim ruta As String = "C:\"

        Dim vari As String
        vari = DateTime.Now.ToShortDateString & DateTime.Now.ToShortTimeString
        vari = vari.Replace("/", "")
        vari = vari.Replace(":", "")
        vari = vari.Replace(".", "")
        vari = vari.Replace(" ", "")


        If Me.ComboBox_tablas.Text = "Productos" Then tabla_import_export = "productos"
        If Me.ComboBox_tablas.Text = "Contactos" Then tabla_import_export = "proveedores"



        Dim rta2 = MsgBox("Pregunta?. " & Chr(13) & Chr(13) & "Se creará una copia de seguridad en este equipo.", MsgBoxStyle.Information + MsgBoxStyle.YesNo)
        Dim PSI As New ProcessStartInfo("C:\xampp\mysql\bin\mysqldump.exe", " -u root -pRadiobemba miclickdb " & tabla_import_export & " -r C:\miclickderecho\backup\BACKUP" & tabla_import_export & vari & ".sql")
        PSI.WindowStyle = ProcessWindowStyle.Minimized 'or ProcessWindowStyle.Normal

        If rta2 = 6 Then
            Cursor.Current = Cursors.WaitCursor
            Process.Start(PSI)
            Cursor.Current = Cursors.Default

        End If


        MsgBox("Se Creó la copia de seguridad correctamente.", vbInformation)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click


        If Me.ComboBox_tablas.Text = "Productos" Then tabla_import_export = "productos"
        If Me.ComboBox_tablas.Text = "Contactos" Then tabla_import_export = "contactos"


        If OpenFileDialog_mail.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            file_db = OpenFileDialog_mail.FileName

            Try
                Cursor.Current = Cursors.WaitCursor
                Dim myProcess As New Process()
                myProcess.StartInfo.FileName = "cmd.exe"
                myProcess.StartInfo.UseShellExecute = False
                myProcess.StartInfo.WorkingDirectory = "C:\xampp\MySQL\bin\"
                myProcess.StartInfo.RedirectStandardInput = True
                myProcess.StartInfo.RedirectStandardOutput = True
                myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
                myProcess.Start()
                Dim myStreamWriter As StreamWriter = myProcess.StandardInput
                Dim mystreamreader As StreamReader = myProcess.StandardOutput
                'myStreamWriter.WriteLine("mysql -u root -p0Radiobemba miclickdb < C:\clickderecho\setup\miclickbd.sql")
                myStreamWriter.WriteLine("mysql -u root -pRadiobemba miclickdb < " & file_db & "")

                myStreamWriter.Close()
                myProcess.WaitForExit()
                myProcess.Close()
                Cursor.Current = Cursors.Default

            Catch ex As Exception
                MsgBox(ex.ToString)
                Cursor.Current = Cursors.Default

            End Try


        End If


    End Sub

    Private Sub MetroTabPage2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs)
        ' INICIA EL BACKGROUNDWORKER
        BackgroundWorker_up_do.WorkerReportsProgress = True
        BackgroundWorker_up_do.WorkerSupportsCancellation = True
        BackgroundWorker_up_do.RunWorkerAsync()

        Me.Cursor = Cursors.WaitCursor
    End Sub

    Private Sub BackgroundWorker_up_do_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker_up_do.DoWork
        My.Computer.Network.DownloadFile("http://www.miclickderecho.com/setups/xamp.zip", "c:\miclickderecho\setup" & NuevaVersion & ".zip", False, 360000)


        If BackgroundWorker_up_do.CancellationPending Then Exit Sub
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

        ' ejemplo
        '        sql = "select distinct TABLE_NAME
        'from information_schema.COLUMNS
        'where COLUMN_NAME in ('nombre_campo_1', 'nombre_campo_2')
        'and TABLE_SCHEMA in ('nombre_base_datos_1', 'nombre_base_datos_2');"

        If ComboBox_tablas.Text <> "" Then
            sql = "SHOW COLUMNS FROM " & Me.ComboBox_tablas.Text
        Else
            Exit Sub
        End If

        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If ComboBox_tablas.Text = Nothing Then
            MsgBox("Seleccione un conjunto de datos.", vbInformation)
            Exit Sub
        End If





        Try
            sql = "select * from " & ComboBox_tablas.Text & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()



    End Sub

    Private Sub ComboBox_tablas_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_tablas.SelectionChangeCommitted

    End Sub


    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click

        '============data comex===============
        Cursor.Current = Cursors.WaitCursor

        sql = "ALTER TABLE `data_comex` ADD COLUMN `costeo` VARCHAR(45) NOT NULL DEFAULT 'PROMEDIO' AFTER `metodoinv`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & "agregar costeo... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar costeo... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "ALTER TABLE `data_comex` ADD COLUMN `fondo` VARCHAR(45) NOT NULL DEFAULT 'AZUL' AFTER `costeo`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar fondo... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar fondo... se omitió"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()


        sql = "ALTER TABLE `data_comex` ADD COLUMN `propina` VARCHAR(45) NOT NULL DEFAULT 'NO' AFTER `fondo`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar propina... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar propina... se omitió"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "ALTER TABLE `data_comex` ADD COLUMN `propinavr` VARCHAR(45) NOT NULL DEFAULT '0' AFTER `propina`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar propinavr... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar propinavr... se omitió"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "ALTER TABLE `data_comex` ADD COLUMN `salones` VARCHAR(45) NOT NULL DEFAULT '1' AFTER `propinavr`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar salones... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar salones... se omitió"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "ALTER TABLE `data_comex` ADD COLUMN `bodventas` VARCHAR(100) NOT NULL DEFAULT 'PRINCIPAL' AFTER `salones`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar bodventas... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar bodventas... se omitió"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "ALTER TABLE `data_comex` ADD COLUMN `bodcompras` VARCHAR(100) NOT NULL DEFAULT 'PRINCIPAL' AFTER `bodventas`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar bodcompras... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar bodcompras... se omitió"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()




        sql = "ALTER TABLE `data_comex` ADD COLUMN `backups` VARCHAR(45) NOT NULL DEFAULT 'Todos Los Días' AFTER `bodcompras`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar backups... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar backups... se omitió"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()


        sql = "ALTER TABLE `data_comex` ADD COLUMN `buscarpor` VARCHAR(45) NOT NULL DEFAULT 'Código' AFTER `backups`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar buscarpor... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar buscarpor... se omitió"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "ALTER TABLE `data_comex` ADD COLUMN `RazonSocial` VARCHAR(100) NOT NULL AFTER `NombreComercial`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & "RazonSocial... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "RazonSocial... se omitió"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()


        sql = "ALTER TABLE `data_comex` DROP COLUMN `bodeventas`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & " ELIMINAR bodEventas... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " ELIMINAR bodEventas... se omitió"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()


        sql = "ALTER TABLE `data_comex` ADD COLUMN `bodproduccion` VARCHAR(100) NOT NULL DEFAULT 'PRINCIPAL' AFTER `bodcompras`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar bodproduccion... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar bodproduccion... se omitió"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()


        sql = "ALTER TABLE `data_comex` ADD COLUMN `PropietarioDoc` VARCHAR(50) NOT NULL AFTER `NombrePropietario`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar PropietarioDoc... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar PropietarioDoc... se omitió"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "ALTER TABLE `data_comex` ADD COLUMN `contador` VARCHAR(50) NOT NULL AFTER `PropietarioDoc`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar contador... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar contador... se omitió"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()


        sql = "ALTER TABLE `data_comex` ADD COLUMN `contadordoc` VARCHAR(45) NOT NULL AFTER `contador`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar contador doc... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar contador doc... se omitió"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "ALTER TABLE `cuentaspuc` ADD COLUMN `descripcion` VARCHAR(200) NOT NULL AFTER `Estado`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar descripcion al puc ... ok"
        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar descripcion al puc ... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()




        sql = "ALTER TABLE `data_comex` ADD COLUMN `Sucursal` VARCHAR(100) NOT NULL AFTER `RazonSocial`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar Sucursal a data comex... ok"
        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar Sucursal a data comex ... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()


        sql = "ALTER TABLE `data_comex` ADD COLUMN `CajaCierre` VARCHAR(45) NOT NULL AFTER `buscarpor`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "agregar caja cierre a data comex.. ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "eagregar caja cierre a data comex... se omitió"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "ALTER TABLE `data_comex` 
CHANGE COLUMN `CajaCierre` `CajaCierre` VARCHAR(150) CHARACTER SET 'latin1' COLLATE 'latin1_spanish_ci' NOT NULL ,
ADD COLUMN `CajaVentas` VARCHAR(150) NOT NULL AFTER `CajaCierre`,
ADD COLUMN `BaseCaja` VARCHAR(45) NOT NULL DEFAULT 0 AFTER `CajaVentas`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar y modifica cajaccierre cajaventas basecaja a data comex... ok"
        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar y modifica cajaccierre cajaventas basecaja a data comex... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        Cursor.Current = Cursors.Default






        '============productos===============
        Cursor.Current = Cursors.WaitCursor
        sql = "ALTER TABLE `productos` CHANGE COLUMN `Presentacion` `Presentacion` VARCHAR(45) NOT NULL"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "Presentacion... ok"
        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "Presentacion... NO"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "ALTER TABLE `productos` ADD COLUMN `cocina` VARCHAR(45) NOT NULL AFTER `decimales`"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "cocina... ok"
        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "cocina... NO"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "ALTER TABLE `productos` ADD COLUMN `parrilla` VARCHAR(45) NOT NULL AFTER `cocina`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "parrillA... ok"
        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "parrillA... NO"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()

        sql = "ALTER TABLE `productos` ADD COLUMN `bar` VARCHAR(45) NOT NULL AFTER `parrilla`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "bar... ok"
        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "bar... NO"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()

        sql = "ALTER TABLE `productos` ADD COLUMN `INVIMA` VARCHAR(45) NOT NULL AFTER `BAR`"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "invima... ok"
        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "invima... NO"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "ALTER TABLE `productos` ADD COLUMN `lote` VARCHAR(2) NOT NULL AFTER `INVIMA`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "LOTEte... ok"
        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar lote... NO"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "alter table `productos` ADD COLUMN `vence` VARCHAR(2) NOT NULL AFTER `lote`"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "vence... ok"
        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "vence... no"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        sql = "ALTER TABLE `productos` ADD COLUMN `KIT` VARCHAR(45) NOT NULL AFTER `vence`"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & " kit... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " kit... no"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        sql = "ALTER TABLE `productos` ADD COLUMN `ubicacion` VARCHAR(45) NOT NULL AFTER `kit`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "ubicacion... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "ubicacion... no"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        sql = "ALTER TABLE `productos` ADD COLUMN `maximo` VARCHAR(45) NOT NULL AFTER `ubicacion`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "maximo... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "maximo... no"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        sql = "ALTER TABLE `productos` ADD COLUMN `alerta` VARCHAR(45) NOT NULL AFTER `maximo`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & Chr(13) & " agregar alerta... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & Chr(13) & " agregar alerta... no"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        sql = "ALTER TABLE `productos` ADD COLUMN `sugerido` VARCHAR(45) NOT NULL AFTER `alerta`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & " sugerido bodega... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " sugerido bodega... no"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()

        sql = "ALTER TABLE `productos` ADD COLUMN `receta` VARCHAR(45) NOT NULL DEFAULT 'NO' AFTER `Sugerido`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "receta... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "receta... NO"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()



        sql = "ALTER TABLE `productos` ADD COLUMN `merma` VARCHAR(10) NOT NULL DEFAULT 0 AFTER `receta`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & " MERMA... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " MERMA...NO"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()

        sql = "ALTER TABLE `productos` ADD COLUMN `desechos` VARCHAR(10) NOT NULL DEFAULT 0 AFTER `merma`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "DESECHOS ... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "DESECHOS ... NO"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()

        sql = "ALTER TABLE `productos` CHANGE COLUMN `Costo` `Costo` VARCHAR(15) NOT NULL;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & " MERMA, DESECHOS bar... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " MERMA, DESECHOS bar... NO"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()

        sql = "ALTER TABLE `productos` ADD COLUMN `coddesecho` VARCHAR(45) Not NULL AFTER `desechos`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & " destino desecho... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " destino desecho... NO"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()

        sql = "UPDATE productos_categorias SET TIPO='PRODUCTOS' WHERE TIPO='PRODUCTOS (No Fabricados por la Empresa)';
UPDATE productos_categorias SET TIPO='PROCESADOS' WHERE TIPO='PRODUCTOS PROCESADOS';
UPDATE productos_categorias SET TIPO='INSUMOS' WHERE TIPO='MATERIA PRIMA';
UPDATE productos SET TIPO='PRODUCTOS' WHERE TIPO='PRODUCTOS (No Fabricados por la Empresa)';
UPDATE productos SET TIPO='PROCESADOS' WHERE TIPO='PRODUCTOS PROCESADOS';
UPDATE productos SET TIPO='INSUMOS' WHERE TIPO='MATERIA PRIMA';"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & " NOMBRE DE CATEGORIAS..... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "NOMBRE DE CATEGORIAS..... NO"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()

        Cursor.Current = Cursors.Default

        '============fin productos===============







        '=============ventas==============

        Cursor.Current = Cursors.WaitCursor

        sql = "ALTER TABLE `ventas` ADD COLUMN `RES` VARCHAR(45) NOT NULL AFTER `Cons`"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & " res... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " res... no"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "ALTER TABLE `ventas` ADD COLUMN `propina` VARCHAR(45) NOT NULL AFTER `deci`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & " propina... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " propina... no"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "ALTER TABLE `ventas` ADD COLUMN `cambio` VARCHAR(45) NOT NULL DEFAULT '0|0' AFTER `propina`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & " cambio... ok"
        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " cambio... no"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        '===========================






        '============ ventas_prods===============
        sql = "ALTER TABLE `ventas_prods` ADD COLUMN `Lote` VARCHAR(45) NOT NULL AFTER `idbodega`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & " Lote... ok"
        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " Lote... no"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()



        sql = "ALTER TABLE `ventas_prods` ADD COLUMN `cta_vender` VARCHAR(100) NOT NULL AFTER `vence`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & " cta_vender... ok"
        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " cta_vender... no"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "alter table `ventas_prods` ADD COLUMN `cta_inventariar` VARCHAR(100) NOT NULL AFTER `cta_vender`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & " cta_inventariar... ok"
        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " cta_inventariar... no"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "alter table `ventas_prods` ADD COLUMN `cta_costear` VARCHAR(100) NOT NULL AFTER `cta_inventariar`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & " cta_costear... ok"
        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " cta_costear... no"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "ALTER TABLE `ventas_prods` ADD COLUMN `cta_devolver` VARCHAR(100) NOT NULL AFTER `cta_costear`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & " cta_devolver... ok"
        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " cta_devolver... ok"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        '================================================




        '===============================   ventas_pre
        sql = "ALTER TABLE `ventas_pre` ADD COLUMN `cocina` VARCHAR(45) NOT NULL AFTER `domiciliovr`"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)

            TextBox1.Text = TextBox1.Text & vbNewLine & "cocina de preventas... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "cocina de preventas... no"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        sql = "ALTER TABLE `ventas_pre` ADD COLUMN `parrilla` VARCHAR(45) NOT NULL AFTER `cocina`"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)

            TextBox1.Text = TextBox1.Text & vbNewLine & " parrilla  preventas... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " parrilla  preventas... no"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        sql = "ALTER TABLE `ventas_pre` ADD COLUMN `bar` VARCHAR(45) NOT NULL AFTER `parrilla`"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)

            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar cocina parrilla bar detalle de preventas... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar cocina parrilla bar detalle de preventas... se omitio"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        sql = "ALTER TABLE `ventas_pre` ADD COLUMN `propina` VARCHAR(45) NOT NULL AFTER `bar`"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)

            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar propina de preventas... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & Chr(13) & " agregar propina de preventas... se omitio"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        sql = "ALTER TABLE `ventas_pre` ADD COLUMN `alerta` VARCHAR(45) NOT NULL AFTER `propina`"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)

            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar alerta de preventas... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar alerta de preventas... se omitio"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        sql = "ALTER TABLE `ventas_pre` ADD COLUMN `Hora` VARCHAR(45) NOT NULL AFTER `alerta`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)

            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar hora de pre venta... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar hora de pre venta... se omitio"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        'fin ventas_pre    ===================================



        ' inicio ventas pre prods =======================

        sql = "ALTER TABLE `ventas_prods_temp` ADD COLUMN `Lote` VARCHAR(45) NOT NULL AFTER `idbodega`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)

            TextBox1.Text = TextBox1.Text & vbNewLine & " lote preventas... ok"


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "ALTER TABLE `ventas_prods_temp` ADD COLUMN `vence` VARCHAR(45) NOT NULL AFTER `Lote`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & " vence preventas... ok"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "ALTER TABLE `ventas_prods_temp` ADD COLUMN `cocina` VARCHAR(45) NOT NULL AFTER `kit`"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)

            TextBox1.Text = TextBox1.Text & vbNewLine & " cocina preventas... ok"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        sql = "ALTER TABLE `ventas_prods_temp` ADD COLUMN `parrilla` VARCHAR(45) NOT NULL AFTER `cocina`"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)

            TextBox1.Text = TextBox1.Text & vbNewLine & " parrilla preventas... ok"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        sql = "ALTER TABLE `ventas_prods_temp` ADD COLUMN `bar` VARCHAR(45) NOT NULL AFTER `parrilla`"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)

            TextBox1.Text = TextBox1.Text & vbNewLine & " bar preventas... ok"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        Cursor.Current = Cursors.Default

        '   fin ventas pre prods===========================





        TextBox1.Text = TextBox1.Text & Chr(13) & " reparando pedidosprov... "



        '============pedidos prov===============
        sql = "ALTER TABLE `pedidosprov` ADD COLUMN `costo` VARCHAR(60) NOT NULL AFTER `mediopago`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "pedidosprov agregar costo... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "pedidosprov agregar costo... se omitió"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "ALTER TABLE `pedidosprov` ADD COLUMN `bodega` VARCHAR(60) NOT NULL AFTER `costo`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "pedidosprov agregar bodega... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "pedidosprov agregar bodega... se omitió"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        '============   fin  pedidos   prov===============

        TextBox1.Text = TextBox1.Text & Chr(13) & " reparando empleados... "


        '=============empleados==============
        sql = "ALTER TABLE `empleados` ADD COLUMN `TipoDoc` VARCHAR(50) NOT NULL AFTER `Documento`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & " tipodoc empleados... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " tipodoc empleados... se omitió"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "ALTER TABLE `empleados` ADD COLUMN `celular` VARCHAR(45) NOT NULL AFTER `Telefono`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & " celular empleados... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " celular empleados... se omitió"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        '=============fin empleados==============



        TextBox1.Text = TextBox1.Text & vbNewLine & " reparando movimientos_prods... "


        '=============movimientos_prods==============

        sql = "ALTER TABLE `movimientos_prods` ADD COLUMN `rol` VARCHAR(6) NOT NULL AFTER `vence`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & " movimientos_prods rol... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " movimientos_prods rol... se omitió"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "ALTER TABLE `movimientos_prods` ADD COLUMN `SaldoAnt` VARCHAR(45) NOT NULL AFTER `rol`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & " movimientos_prods SaldoAnt... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " movimientos_prods SaldoAnt... se omitió"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "ALTER TABLE `movimientos_prods` ADD COLUMN `NuevoSaldo` VARCHAR(45) NOT NULL AFTER `SaldoAnt`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & " movimientos_prods NuevoSaldo... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " movimientos_prods NuevoSaldo... se omitió"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        '=============fin movimientos_prods==============






        '=============otros==============


        Cursor.Current = Cursors.WaitCursor


        sql = "ALTER TABLE `medios_pago` DROP COLUMN `cuenta`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "eliminar cuenta de medios de pago... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "eliminar cuenta de medios de pago... se omitió"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "ALTER TABLE `cuentaspuc` ADD COLUMN `nif` VARCHAR(50) NOT NULL AFTER `descripcion`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar nif al puc... ok"
        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar nif al puc... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()


        sql = "ALTER TABLE `medios_pago` ADD COLUMN `estado` VARCHAR(45) NOT NULL AFTER `cobrar`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "agregar estado a medios_pago.. ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "eagregar estado a medios_pago... se omitió"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()


        sql = "CHANGE COLUMN `Cons` `Cons` INT(11) NOT NULL AUTO_INCREMENT;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "agregar auto increment lic.. ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "agregar auto increment lic... se omitió"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "ALTER TABLE `proveedores` ADD COLUMN `fecha` VARCHAR(45) NOT NULL AFTER `RUTA`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "agregar fecha a proveedor... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "agregar a proveedor... se omitió"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()



        sql = "CREATE TABLE `data_docs_fv` (
  `cons` INT NOT NULL AUTO_INCREMENT,
  `cta_impuestos` VARCHAR(100) NOT NULL,
  `cta_descuentos` VARCHAR(100) NOT NULL,
  `cta_propinas` VARCHAR(100) NOT NULL,
  PRIMARY KEY (`cons`),
  UNIQUE INDEX `idnew_table_UNIQUE` (`cons` ASC))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_spanish_ci;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "agregar tabla data_docs_FV... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "agregar agregar tabla data_docs_FV... se omitió"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()


        sql = "CREATE TABLE `data_docs_fc` (
  `cons` int(11) NOT NULL AUTO_INCREMENT,
  `cta_impuestos` varchar(100) COLLATE utf8_spanish_ci NOT NULL,
  `cta_descuentos` varchar(100) COLLATE utf8_spanish_ci NOT NULL,
  `cta_retenciones` varchar(100) COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`cons`),
  UNIQUE KEY `idnew_table_UNIQUE` (`cons`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "agregar tabla data_docs_Fc... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "agregar agregar tabla data_docs_Fc... se omitió"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "ALTER TABLE `proveedores` 
CHANGE COLUMN `RazonSocial` `RazonSocial` VARCHAR(45) CHARACTER SET 'latin1' NOT NULL AFTER `TipoDocumento`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "agregar prov mover razon... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "agregar prov mover razon... se omitió"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "ALTER TABLE `proveedores` 
CHANGE COLUMN `Nombre` `Nombre1` TEXT CHARACTER SET 'latin1' NOT NULL;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "cambiar a nombre 1... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "cambiar a nombre 1... se omitió"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "ALTER TABLE `proveedores` 
ADD COLUMN `Nombre2` VARCHAR(45) NOT NULL AFTER `Nombre1`,
ADD COLUMN `Apellido1` VARCHAR(45) NOT NULL AFTER `Nombre2`,
ADD COLUMN `Apellido2` VARCHAR(45) NOT NULL AFTER `Apellido1`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "cambiar a nombres y apelldios... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "cambiar a nombres y apelldios... se omitió"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "ALTER TABLE `proveedores` 
ADD COLUMN `Nombre` VARCHAR(150) NOT NULL AFTER `RazonSocial`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "agrega nombre completo... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "agrega nombre completo... se omitió"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "ALTER TABLE `proveedores` 
ADD COLUMN `Nombre` VARCHAR(150) NOT NULL AFTER `RazonSocial`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "agrega nombre completo... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "agrega nombre completo... se omitió"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()




        sql = "update proveedores set nombre=nombre1;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "agrega nombre completo... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "agrega nombre completo... se omitió"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()


        sql = "update proveedores set nombre1='';"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "agrega nombre completo... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "agrega nombre completo... se omitió"

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()



        sql = "ALTER TABLE `proveedores` 
ADD COLUMN `Pais` VARCHAR(45) NOT NULL AFTER `Direccion`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "agrega pais... ok"
        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "agrega pais... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "update proveedores set nombre1=nombre;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "iguala nombre... ok"
        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "iguala nombre... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "ALTER TABLE `proveedores` DROP COLUMN `CodRuta`,DROP COLUMN `RUTA`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "elimina ruta... ok"
        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "elimina ruta... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "ALTER TABLE `proveedores` CHANGE COLUMN `TipoContribuyente` `TipoContribuyente` VARCHAR(45) CHARACTER SET 'latin1' NOT NULL AFTER `TipoDocumento`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "mover TipoContribuyente... ok"
        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "mover TipoContribuyente... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()


        sql = "ALTER TABLE `proveedores` 
ADD COLUMN `Contacto` VARCHAR(150) NOT NULL AFTER `fecha`,
ADD COLUMN `MedioPago` VARCHAR(150) NOT NULL AFTER `Contacto`,
ADD COLUMN `CupoCredito` VARCHAR(45) NOT NULL AFTER `MedioPago`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "agrega contcato,mediopago,cupocredito... ok"
        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "agrega contcato,mediopago,cupocredito... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()


        sql = "ALTER TABLE `proveedores` ADD COLUMN `activo` VARCHAR(2) NOT NULL AFTER `CupoCredito`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "agrega activo... ok"
        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "agrega activo... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()


        sql = "ALTER TABLE `proveedores` 
CHANGE COLUMN `RetefuenteCompras` `agenteretenedor` VARCHAR(2) CHARACTER SET 'latin1' NOT NULL;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "agrega activo... ok"
        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "agrega activo... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "update proveedores set activo='SI';"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "agrega activo... ok"
        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "agrega activo... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()



        sql = "CREATE TABLE `actividadesdian` (
  `Cons` INT NOT NULL AUTO_INCREMENT,
  `Ciudad` VARCHAR(45) NOT NULL,
  `actividad` VARCHAR(45) NOT NULL,
  `base` VARCHAR(45) NOT NULL,
  `tarifa` VARCHAR(45) NOT NULL,
  `cuentaacredita` VARCHAR(45) NOT NULL,
  `cuentadebita` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`Cons`),
  UNIQUE INDEX `Cons_UNIQUE` (`Cons` ASC));"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "crear actividades... ok"
        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "crear actividades... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()


        sql = "ALTER TABLE `proveedores` 
ADD COLUMN `ReteMultiple` VARCHAR(45) NOT NULL AFTER `agenteretenedor`,
ADD COLUMN `EcoActividad` VARCHAR(200) NOT NULL AFTER `ReteMultiple`;
"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "crear retemultiple y actividad... ok"
        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "crear retemultiple y actividad... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()


        sql = "ALTER TABLE `actividadesdian` 
ADD COLUMN `CODIGO` VARCHAR(45) NOT NULL AFTER `Cons`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "crear ACTIVIDADESDIAN... ok"
        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "crear ACTIVIDADES DIAN... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "ALTER TABLE `proveedores` 
ADD COLUMN `Telefono3` VARCHAR(45) NOT NULL AFTER `Telefono2`,
ADD COLUMN `Telefono4` VARCHAR(45) NOT NULL AFTER `Telefono3`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "crear telefonos contacto... ok"
        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "crear telefonos contacto... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()


        Cursor.Current = Cursors.Default

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button_procesar_Click(sender As Object, e As EventArgs) Handles Button_procesar.Click
        Cursor.Current = Cursors.WaitCursor

        sql = TextBox1.Text

        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            MsgBox("ok")
        Catch ex As Exception
            MsgBox("error")
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()


        Cursor.Current = Cursors.Default


    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click



        sql = "SELECT * FROM INFORMATION_SCHEMA.tables WHERE TABLE_SCHEMA like 'miclickdb'"


        Try
            da_tablas = New MySqlDataAdapter(sql, conex)
            dt_tablas = New DataTable
            da_tablas.Fill(dt_tablas)

            ComboBox_tablas.DataSource = dt_tablas.DefaultView
            ComboBox_tablas.DisplayMember = "table_name"
            ComboBox_tablas.ValueMember = "table_name"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_tablas.Dispose()
        dt_tablas.Dispose()
        conex.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click


    End Sub

    Private Sub Button10_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button10_Click_2(sender As Object, e As EventArgs) Handles Button10.Click
        Cursor.Current = Cursors.WaitCursor
        sql = "ALTER TABLE `empleados` ADD COLUMN `autorizador` VARCHAR(2) NOT NULL AFTER `Salario`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & "agregar autorizador... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar autorizador... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        Cursor.Current = Cursors.Default


        Cursor.Current = Cursors.WaitCursor
        sql = "ALTER TABLE `data_docs` ADD COLUMN `autorizacion` VARCHAR(2) NOT NULL AFTER `observaciones`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & "agregar autorizacion... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & " agregar autorizacion... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        Cursor.Current = Cursors.WaitCursor
        sql = "ALTER TABLE cuentaspuc ADD COLUMN `Clase` VARCHAR(45) NOT NULL AFTER `Cuenta`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & "agregar clase al puc... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "agregar clase al puc... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        Cursor.Current = Cursors.Default




        Cursor.Current = Cursors.WaitCursor
        sql = "CREATE TABLE `devoluciones` (
  `Cons` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `Fecha` text CHARACTER SET latin1 NOT NULL,
  `Factura` varchar(45) CHARACTER SET latin1 NOT NULL,
  `CodCliente` varchar(20) CHARACTER SET latin1 NOT NULL,
  `Cliente` text CHARACTER SET latin1 NOT NULL,
  `Observaciones` text CHARACTER SET latin1 NOT NULL,
  `EmpleadoCod` text CHARACTER SET latin1 NOT NULL,
  `Empleado` text CHARACTER SET latin1 NOT NULL,
  `Estado` text CHARACTER SET latin1 NOT NULL,
  `Cargue` varchar(2) CHARACTER SET latin1 NOT NULL,
  `CodCargue` varchar(45) CHARACTER SET latin1 NOT NULL,
  `Ruta` varchar(3) CHARACTER SET latin1 NOT NULL,
  `Descargado` varchar(2) CHARACTER SET latin1 NOT NULL,
  `Facturado` varchar(2) CHARACTER SET latin1 NOT NULL,
  `NroFac` varchar(45) CHARACTER SET latin1 NOT NULL,
  `TipoDev` varchar(45) CHARACTER SET latin1 NOT NULL,
  PRIMARY KEY (`Cons`),
  UNIQUE KEY `Cons` (`Cons`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & "CHECK dev... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "CHECK dev... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        Cursor.Current = Cursors.Default




        Cursor.Current = Cursors.WaitCursor
        sql = "update data_docs set codigo='CE' where codigo='CG' and padre='NO' and activo='SI';"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & "union CG y CE... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "union CG y CE... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        Cursor.Current = Cursors.Default


        Cursor.Current = Cursors.WaitCursor
        sql = "ALTER TABLE `recibos_egresos` 
ADD COLUMN `Mediodepago` VARCHAR(45) NOT NULL AFTER `TipoGasto`;
"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & "mediodepago CE... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "mediodepago CE... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        Cursor.Current = Cursors.Default

        Cursor.Current = Cursors.WaitCursor
        sql = "ALTER TABLE `recibos_caja` 
ADD COLUMN `Mediodepago` VARCHAR(45) NOT NULL AFTER `TipoGasto`;
"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & "mediodepago RC... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "mediodepago RC... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        Cursor.Current = Cursors.Default

        Cursor.Current = Cursors.WaitCursor
        sql = "ALTER TABLE `data_comex` 
ADD COLUMN `balanzacom` VARCHAR(45) NOT NULL AFTER `BaseCaja`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & "balanzacom... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "balanzacom... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub Button11_Click_1(sender As Object, e As EventArgs) Handles Button11.Click
        Dim UP_SQL As String = "DELETE FROM PERMISOS WHERE CODEMPLEADO='1' AND CODEMPLEADO='2';
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('1','VENTAS','Acceso al Modulo Ventas','1','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('2','INVENTARIOS','Acceso al Modulo Inventarios','1','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('3','GASTOS','Acceso al Modulo Gastos','1','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('4','CONTACTOS','Acceso al Modulo Contactos','1','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('5','INFORMES','Acceso al Modulo Informes','1','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('6','CONTABILIDAD','Acceso al Modulo Contabilidad','1','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('7','ADMINISTRACION','Acceso al Modulo Administración','1','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('8','INVENTARIOS','Ver Productos','1','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('9','INVENTARIOS','Crear Productos','1','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('10','INVENTARIOS','Modificar Productos','1','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('11','INVENTARIOS','Eliminar Productos','1','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('12','INVENTARIOS','Ver Movimientos','1','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('13','INVENTARIOS','Crear Movimientos','1','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('14','INVENTARIOS','Modificar Movimientos','1','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('15','INVENTARIOS','Consultar Bodega','1','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('16','INVENTARIOS','Crear Categorias','1','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('17','INVENTARIOS','Modificar Categorias','1','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('18','INVENTARIOS','Eliminar Categorias','1','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('19','INVENTARIOS','Consultar Pedidos a Proveedores','1','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('20','INVENTARIOS','Crear Pedidos a Proveedores','1','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('21','INVENTARIOS','Modificar Pedidos a Proveedores','1','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('22','INVENTARIOS','Eliminar Pedidos a Proveedores','1','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('23','GASTOS','Permitir Registrar Gastos','1','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('24','GASTOS','Permitir Registrar Recibos de Caja','1','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('25','CONTACTOS','Permitir Crear Contactos','1','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('26','CONTACTOS','Permitir Modifcar Contactos','1','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('27','CONTACTOS','Permitir Eliminar Contactos','1','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('28','VENTAS','Acceso al Modulo Cocina','1','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('29','VENTAS','Cambiar Precios en las Ventas','1','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('30','INFORMES','Consultar Turnos de Caja','1','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('31','INFORMES','Consultar Informe Diario','1','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('32','VENTAS','Hacer Descuentos','1','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('33','VENTAS','Modificar el Precio de Venta','1','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('1','VENTAS','Acceso al Modulo Ventas','2','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('2','INVENTARIOS','Acceso al Modulo Inventarios','2','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('3','GASTOS','Acceso al Modulo Gastos','2','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('4','CONTACTOS','Acceso al Modulo Contactos','2','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('5','INFORMES','Acceso al Modulo Informes','2','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('6','CONTABILIDAD','Acceso al Modulo Contabilidad','2','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('7','ADMINISTRACION','Acceso al Modulo Administración','2','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('8','INVENTARIOS','Ver Productos','2','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('9','INVENTARIOS','Crear Productos','2','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('10','INVENTARIOS','Modificar Productos','2','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('11','INVENTARIOS','Eliminar Productos','2','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('12','INVENTARIOS','Ver Movimientos','2','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('13','INVENTARIOS','Crear Movimientos','2','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('14','INVENTARIOS','Modificar Movimientos','2','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('15','INVENTARIOS','Consultar Bodega','2','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('16','INVENTARIOS','Crear Categorias','2','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('17','INVENTARIOS','Modificar Categorias','2','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('18','INVENTARIOS','Eliminar Categorias','2','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('19','INVENTARIOS','Consultar Pedidos a Proveedores','2','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('20','INVENTARIOS','Crear Pedidos a Proveedores','2','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('21','INVENTARIOS','Modificar Pedidos a Proveedores','2','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('22','INVENTARIOS','Eliminar Pedidos a Proveedores','2','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('23','GASTOS','Permitir Registrar Gastos','2','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('24','GASTOS','Permitir Registrar Recibos de Caja','2','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('25','CONTACTOS','Permitir Crear Contactos','2','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('26','CONTACTOS','Permitir Modifcar Contactos','2','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('27','CONTACTOS','Permitir Eliminar Contactos','2','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('28','VENTAS','Acceso al Modulo Cocina','2','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('29','VENTAS','Cambiar Precios en las Ventas','2','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('30','INFORMES','Consultar Turnos de Caja','2','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('31','INFORMES','Consultar Informe Diario','2','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('32','VENTAS','Hacer Descuentos','2','SI');
INSERT INTO `permisos` (`Codigo`,`modulo`,`Permiso`,`CodEmpleado`,`Estado`) VALUES ('33','VENTAS','Modificar el Precio de Venta','2','SI');"
        Dim SCRIPS() As String = Split(UP_SQL, ";")

        Dim index As Integer = 0
        Do
            Cursor.Current = Cursors.WaitCursor
            sql = SCRIPS(index)
            Try
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                da.Fill(dt)
                Me.DataGridView2.DataSource = dt
                TextBox1.Text = TextBox1.Text & vbNewLine & SCRIPS(index)

            Catch ex As Exception
                TextBox1.Text = TextBox1.Text & vbNewLine & SCRIPS(index)
            End Try
            conex.Close()
            da.Dispose()
            dt.Dispose()
            conex.Close()
            Cursor.Current = Cursors.Default
            index += 1
        Loop Until index >= SCRIPS.Count



    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Cursor.Current = Cursors.WaitCursor
        sql = "ALTER TABLE `cuentaspuc` 
ADD COLUMN `tipo` VARCHAR(45) NOT NULL AFTER `Naturaleza`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & "tipopuc... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "tipopuc... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        Cursor.Current = Cursors.Default



        Cursor.Current = Cursors.WaitCursor
        sql = "ALTER TABLE `oproduccion` 
ADD COLUMN `pesounidad` VARCHAR(45) NOT NULL AFTER `desechos`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & "pesounidad... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "pesounidad... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        Cursor.Current = Cursors.Default


        Cursor.Current = Cursors.WaitCursor
        sql = "ALTER TABLE `recibos_egresos` 
ADD COLUMN `Imp` TEXT NOT NULL AFTER `Mediodepago`,
ADD COLUMN `ImpVr` VARCHAR(45) NOT NULL AFTER `Imp`,
ADD COLUMN `Rete` TEXT NOT NULL AFTER `ImpVr`,
ADD COLUMN `ReteVr` VARCHAR(45) NOT NULL AFTER `Rete`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & "imprete egresos... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "imprete egresos... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        Cursor.Current = Cursors.Default

        Cursor.Current = Cursors.WaitCursor
        sql = "ALTER TABLE `recibos_caja` 
ADD COLUMN `Imp` TEXT NOT NULL AFTER `Mediodepago`,
ADD COLUMN `ImpVr` VARCHAR(45) NOT NULL AFTER `Imp`,
ADD COLUMN `Rete` TEXT NOT NULL AFTER `ImpVr`,
ADD COLUMN `ReteVr` VARCHAR(45) NOT NULL AFTER `Rete`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & "imprete caja... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "imprete caja... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        Cursor.Current = Cursors.Default

        Cursor.Current = Cursors.WaitCursor
        sql = "ALTER TABLE `impuestos` 
ADD COLUMN `cuentapuc2` VARCHAR(45) NOT NULL AFTER `cuentapuc`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & "CTA2 imp... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "CTA2 imp... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        Cursor.Current = Cursors.Default

        Cursor.Current = Cursors.WaitCursor
        sql = "ALTER TABLE `recibos_egresos` 
ADD COLUMN `Cuenta` VARCHAR(150) NOT NULL AFTER `TipoGasto`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & "Cuenta egreso... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "Cuenta egreso... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        Cursor.Current = Cursors.Default

        Cursor.Current = Cursors.WaitCursor
        sql = "ALTER TABLE `recibos_caja` 
ADD COLUMN `Cuenta` VARCHAR(150) NOT NULL AFTER `TipoGasto`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & "Cuenta ingresop... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "Cuenta ingreso... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        Cursor.Current = Cursors.Default



        Cursor.Current = Cursors.WaitCursor
        sql = "ALTER TABLE `recibos_caja` 
ADD COLUMN `CuentaPago` VARCHAR(150) NOT NULL AFTER `Mediodepago`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & "Cuentapago ingreso... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "Cuentapago ingreso... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        Cursor.Current = Cursors.Default



        Cursor.Current = Cursors.WaitCursor
        sql = "ALTER TABLE `recibos_egresos` 
ADD COLUMN `CuentaPago` VARCHAR(150) NOT NULL AFTER `Mediodepago`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & "Cuentapago egreso... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "Cuentapago egreso... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Cursor.Current = Cursors.WaitCursor


        sql = "ALTER TABLE `recibos_egresos` 
CHANGE COLUMN `concepto` `descripcion` TEXT CHARACTER SET 'latin1' NOT NULL ,
CHANGE COLUMN `TipoGasto` `Concepto` VARCHAR(45) CHARACTER SET 'latin1' NOT NULL ;
"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & "descripcion concepto egresos... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "descripcion concepto egresos... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "ALTER TABLE `recibos_caja` 
CHANGE COLUMN `concepto` `descripcion` TEXT CHARACTER SET 'latin1' NOT NULL ,
CHANGE COLUMN `TipoGasto` `Concepto` VARCHAR(45) CHARACTER SET 'latin1' NOT NULL ;
"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & "descripcion concepto caja... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "descripcion concepto caja... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()



        sql = "CREATE TABLE `ventas_dctos` (
  `Cons` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `Documento` int(11) NOT NULL,
  `CodProd` int(11) NOT NULL,
  `Producto` text CHARACTER SET latin1 NOT NULL,
  `Cantidad` varchar(15) CHARACTER SET latin1 NOT NULL,
  `Base` int(11) NOT NULL,
  `Imp` int(11) NOT NULL,
  `imp2` int(11) NOT NULL,
  `Impuesto` int(11) NOT NULL,
  `impuesto2` int(11) NOT NULL,
  `ValorU` int(11) NOT NULL,
  `ValorTotal` int(11) NOT NULL,
  `Estado` text CHARACTER SET latin1 NOT NULL,
  `Inventariado` varchar(20) CHARACTER SET latin1 NOT NULL,
  `ImpNom1` varchar(45) CHARACTER SET latin1 NOT NULL,
  `ImpNom2` varchar(45) CHARACTER SET latin1 NOT NULL,
  `deci` varchar(2) CHARACTER SET latin1 NOT NULL,
  `costo` varchar(45) CHARACTER SET latin1 NOT NULL,
  `idbodega` varchar(45) CHARACTER SET latin1 NOT NULL,
  `Lote` varchar(45) CHARACTER SET latin1 NOT NULL,
  `vence` varchar(45) CHARACTER SET latin1 NOT NULL,
  `cta_vender` varchar(100) CHARACTER SET latin1 NOT NULL,
  `cta_inventariar` varchar(100) CHARACTER SET latin1 NOT NULL,
  `cta_costear` varchar(100) CHARACTER SET latin1 NOT NULL,
  `cta_devolver` varchar(100) CHARACTER SET latin1 NOT NULL,
  PRIMARY KEY (`Cons`),
  UNIQUE KEY `Cons` (`Cons`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;
"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & "ventas_dctos... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "ventas_dctos... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        Cursor.Current = Cursors.Default


        Cursor.Current = Cursors.WaitCursor

        sql = "CREATE TABLE `ventas_dctos_temp` (
  `Cons` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `Documento` int(11) NOT NULL,
  `CodProd` int(11) NOT NULL,
  `Producto` text CHARACTER SET latin1 NOT NULL,
  `Cantidad` varchar(15) CHARACTER SET latin1 NOT NULL,
  `Base` int(11) NOT NULL,
  `Imp` int(11) NOT NULL,
  `imp2` int(11) NOT NULL,
  `Impuesto` int(11) NOT NULL,
  `impuesto2` int(11) NOT NULL,
  `ValorU` int(11) NOT NULL,
  `ValorTotal` int(11) NOT NULL,
  `Estado` text CHARACTER SET latin1 NOT NULL,
  `Inventariado` varchar(20) CHARACTER SET latin1 NOT NULL,
  `ImpNom1` varchar(45) CHARACTER SET latin1 NOT NULL,
  `ImpNom2` varchar(45) CHARACTER SET latin1 NOT NULL,
  `deci` varchar(2) CHARACTER SET latin1 NOT NULL,
  `costo` varchar(45) CHARACTER SET latin1 NOT NULL,
  `idbodega` varchar(45) CHARACTER SET latin1 NOT NULL,
  `Lote` varchar(45) CHARACTER SET latin1 NOT NULL,
  `vence` varchar(45) CHARACTER SET latin1 NOT NULL,
  `cta_vender` varchar(100) CHARACTER SET latin1 NOT NULL,
  `cta_inventariar` varchar(100) CHARACTER SET latin1 NOT NULL,
  `cta_costear` varchar(100) CHARACTER SET latin1 NOT NULL,
  `cta_devolver` varchar(100) CHARACTER SET latin1 NOT NULL,
  PRIMARY KEY (`Cons`),
  UNIQUE KEY `Cons` (`Cons`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;
"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & "ventas_dctos... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "ventas_dctos... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        Cursor.Current = Cursors.Default



        Cursor.Current = Cursors.WaitCursor
        sql = "ALTER TABLE `devoluciones` 
ADD COLUMN `mediopago` VARCHAR(100) NOT NULL AFTER `TipoDev`,
ADD COLUMN `vrpago` VARCHAR(45) NOT NULL AFTER `mediopago`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & "mediopago dev... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "mediopago dev... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        Cursor.Current = Cursors.Default



        Cursor.Current = Cursors.WaitCursor
        sql = "ALTER TABLE `devolucionescompras` 
ADD COLUMN `mediopago` VARCHAR(100) NOT NULL AFTER `TipoDev`,
ADD COLUMN `vrpago` VARCHAR(45) NOT NULL AFTER `mediopago`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & "mediopago dev... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "mediopago dev... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        Cursor.Current = Cursors.Default


        Cursor.Current = Cursors.WaitCursor
        sql = "ALTER TABLE `cajasybancos` 
ADD UNIQUE INDEX `Nombre_UNIQUE` (`Nombre` ASC);"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & "Nombre_UNIQUE... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "Nombre_UNIQUE... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        Cursor.Current = Cursors.Default


        Cursor.Current = Cursors.WaitCursor
        sql = "UPDATE pedidosprov_prods 
INNER JOIN pedidosprov
ON pedidosprov_prods.documento = pedidosprov.cons AND pedidosprov.estado='ANULADO'
SET pedidosprov_prods.ESTADO='ANULADO'"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & "confirm. prods anulados... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "confirm. prods anulados... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        Cursor.Current = Cursors.Default


        Cursor.Current = Cursors.WaitCursor
        sql = "ALTER TABLE `lics` CHANGE COLUMN `Activacion` `Activacion` TEXT CHARACTER SET 'latin1' COLLATE 'latin1_spanish_ci' NOT NULL;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & "CHANGE COLUMN Activacion... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "CHANGE COLUMN Activacion... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        Cursor.Current = Cursors.Default



        Cursor.Current = Cursors.WaitCursor
        sql = "ALTER TABLE `productos` ADD COLUMN `ref` VARCHAR(45) NOT NULL AFTER `coddesecho`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & "CHANGE COLUMN ref... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "CHANGE COLUMN ref... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        Cursor.Current = Cursors.Default

        Cursor.Current = Cursors.WaitCursor
        sql = "ALTER TABLE `productos` ADD COLUMN `fav` VARCHAR(45) NOT NULL AFTER `ref`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & "add fav... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "add fav... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()


        sql = "ALTER TABLE `proveedores` 
ADD COLUMN `puntos` INT NOT NULL AFTER `activo`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & "add puntos... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "add puntos... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        Cursor.Current = Cursors.Default


        sql = "CREATE TABLE `zonas` (
  `cons` int(11) NOT NULL AUTO_INCREMENT,
  `Zona` varchar(20) CHARACTER SET latin1 NOT NULL,
  `Descripcion` varchar(150) CHARACTER SET latin1 NOT NULL,
  `Mesas` varchar(2) CHARACTER SET latin1 NOT NULL,
  `Estado` varchar(20) CHARACTER SET latin1 NOT NULL,
  PRIMARY KEY (`cons`),
  UNIQUE KEY `idzonas_UNIQUE` (`cons`),
  UNIQUE KEY `Zona_UNIQUE` (`Zona`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGridView2.DataSource = dt
            TextBox1.Text = TextBox1.Text & vbNewLine & "add zona... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "add zona... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "ALTER TABLE `ventas_pre` 
CHANGE COLUMN `DocCliente` `DocCliente` VARCHAR(20) NOT NULL ;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "CHANGE COLUMN `DocCliente` `DocCliente`... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "CHANGE COLUMN `DocCliente` `DocCliente`... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()




        sql = "ALTER TABLE `turnos` 
ADD COLUMN `Caja` VARCHAR(150) NOT NULL AFTER `Total`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "caja a caja... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "caja a caja... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "ALTER TABLE `data_comex` 
ADD COLUMN `imppos` VARCHAR(100) NOT NULL AFTER `balanzacom`,
ADD COLUMN `impstandard` VARCHAR(100) NOT NULL AFTER `imppos`,
ADD COLUMN `impcomanda` VARCHAR(100) NOT NULL AFTER `impstandard`;
"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "imp noms... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "imp noms... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()


        Cursor.Current = Cursors.Default


    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = “Seleccionar archivos”
            .Filter = “Archivos Excel(*.xls;*.xlsx)|*.xls;*xlsx|Todos los archivos(*.*)|*.*”
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                ImportExcellToDataGridView(.FileName, DataGridView)
            End If
        End With
    End Sub

    Public Function ImportExcellToDataGridView(ByRef path As String, ByVal Datagrid As DataGridView)
        Try
            Dim stConexion As String = ("Provider=Microsoft.ACE.OLEDB.12.0;" & ("Data Source=" & (path & ";Extended Properties=""Excel 12.0;Xml;HDR=YES;IMEX=2"";")))
            Dim cnConex As New OleDbConnection(stConexion)
            Dim Cmd As New OleDbCommand("Select * From [Hoja1$]")
            Dim Ds As New DataSet
            Dim Da As New OleDbDataAdapter
            Dim Dt As New DataTable
            cnConex.Open()
            Cmd.Connection = cnConex
            Da.SelectCommand = Cmd
            Da.Fill(Ds)
            Dt = Ds.Tables(0)
            Datagrid.Columns.Clear()
            Datagrid.DataSource = Dt
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return True
    End Function

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox1.Text = ""

        sql = "update movimientoscuentas set valor=replace(valor,'.','');"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "replace . para decimales ... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "replace . para decimales ... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "update productos set costo=replace(costo,'.','');"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "replace . para decimales prods ... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "replace . para decimales prods ... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()


        sql = "ALTER TABLE `movimientos` 
ADD COLUMN `referencia` VARCHAR(5) NOT NULL AFTER `contabilizado`;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "agregar referencia a movimientos ... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "agregar referencia a movimientos ... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "ALTER TABLE `pedidosprov` 
ADD COLUMN `Turno` INT NOT NULL AFTER `bodega`;
"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "agregar turno a pedprov ... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "agregar turno a pedprov ... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "ALTER TABLE `miclickdb`.`caja` 
CHANGE COLUMN `Turno` `Turno` INT(11) NOT NULL ;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "INT TURNOE IN CAJA ... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "INT TURNOE IN CAJA ... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()


        sql = "update recibos_caja 
left join caja 
on caja.documento=recibos_caja.documento 
and caja.tipodocumento='RECIBO DE CAJA'
set recibos_caja.turno=caja.turno;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "UP #TURNO TO RECIBOS.CAJA ... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "UP #TURNO TO RECIBOS.CAJA ... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        sql = "update recibos_egresos 
left join caja 
on caja.documento=recibos_egresos.documento 
and caja.tipodocumento='COMPROBANTE DE EGRESO'
set recibos_egresos.turno=caja.turno;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "UP #TURNO TO COMP.EGRESOS ... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "UP #TURNO TO COMP.EGRESOS ... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()


        sql = "update pedidosprov 
left join caja 
on caja.documento=pedidosprov.nrofac 
and caja.tipodocumento='COMPRA'
set pedidosprov.turno=caja.turno;"
        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox1.Text = TextBox1.Text & vbNewLine & "UP #TURNO TO PEDIDOS.PROV ... ok"

        Catch ex As Exception
            TextBox1.Text = TextBox1.Text & vbNewLine & "UP #TURNO TO PEDIDOS.PROV ... se omitió"
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
    End Sub
End Class