Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO
Imports System.IO.Compression

Public Class Form_install
    Dim descargando As String = ""
    Dim instalando As String = ""
    Dim file_db As String = ""

    Public MSda As SqlDataAdapter  'SQL
    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form_install_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub BackgroundWorker_up_do_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker_up_do.DoWork
        Dim destino As String = ""
        Dim origen As String = ""

        origen = "http://www.miclickderecho.com/setups/pdfviewer.zip"
        destino = "c:\miclick\midata\pdfviewer.zip"

        Try
            My.Computer.Network.DownloadFile _
                (address:=origen,
                destinationFileName:=destino,
                userName:=String.Empty, password:=String.Empty,
                showUI:=False, connectionTimeout:=2400000,
                overwrite:=True)
        Catch ex As Exception
            BackgroundWorker_up_do.CancelAsync()
            MsgBox("se canceló la decarga.", vbExclamation)
        End Try


        If BackgroundWorker_up_do.CancellationPending Then Exit Sub
    End Sub

    Private Sub BackgroundWorker_up_do_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker_up_do.RunWorkerCompleted
        Button_cerrar.Enabled = True


        PictureBox_work.Visible = True : PictureBox_work.Image = My.Resources.oktrans
        Label_work.Text = "la descarga finalizo  correctamente."


        descargando = ""

    End Sub

    Private Sub Form_install_Shown(sender As Object, e As EventArgs) Handles Me.Shown




    End Sub



    Private Sub Timer_vigia_install_Tick(sender As Object, e As EventArgs) Handles Timer_vigia_install.Tick
        Timer_vigia_install.Enabled = False

        BackgroundWorker_instalxamp_fin.WorkerReportsProgress = True
        BackgroundWorker_instalxamp_fin.WorkerSupportsCancellation = True
        BackgroundWorker_instalxamp_fin.RunWorkerAsync()


    End Sub

    Private Sub BackgroundWorker_instalxamp_fin_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker_instalxamp_fin.DoWork

        Dim ejecutandoinstalador As Process() = Process.GetProcessesByName("xampp")
        Label_work.Text = "iniciando vigilando..."

        Do While ejecutandoinstalador.Length <> 0
            Label_work.Text = "esperando que finalice la instalación..."

            ejecutandoinstalador = Process.GetProcessesByName("xampp")

        Loop
        Label_work.Text = "finalizó la instalación!!!"


    End Sub



    Private Sub Button_cerrar_Click(sender As Object, e As EventArgs) Handles Button_cerrar.Click
        Me.Close()
    End Sub



    Private Sub BackgroundWorker_xamp_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker_xamp.RunWorkerCompleted
        Timer_esperar.Enabled = True

    End Sub

    Private Sub Timer_esperar_Tick(sender As Object, e As EventArgs) Handles Timer_esperar.Tick
        Timer_esperar.Enabled = False

    End Sub

    Private Sub BackgroundWorker_instalxamp_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker_instalxamp.ProgressChanged

    End Sub





    Private Sub PictureBox_xamp_ok_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox_datacenter_Install_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If File.Exists("c:\miclick\datos\PDFXVwer.exe") Then
            Dim RTA As String
            RTA = MsgBox("ya existe el archivo se ejecutara el instalador.", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo)
            If RTA = 6 Then
                Me.Cursor = Cursors.WaitCursor
                Process.Start("c:\miclick\anydesk.exe")
                Me.Cursor = Cursors.Default
            End If
            Exit Sub
        End If


        ' INICIA EL BACKGROUNDWORKER
        descargando = "pdfviewer"

        Label_work.Text = "Descargando por favor espere..."
        Label_work.Visible = True
        PictureBox_work.Visible = True : PictureBox_work.Image = My.Resources.loader

        Button_cerrar.Enabled = False

        BackgroundWorker_up_do.WorkerReportsProgress = True
        BackgroundWorker_up_do.WorkerSupportsCancellation = True
        BackgroundWorker_up_do.RunWorkerAsync()


    End Sub

    Private Sub Form_install_Scroll(sender As Object, e As ScrollEventArgs) Handles Me.Scroll

    End Sub



    Private Sub RadioButton_xamp_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton_sql_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

                    myStreamWriter.WriteLine("mysql -u root -pRadiobemba miclickdb < """ & CStr(file_db) & """ ")

                    myStreamWriter.Close()
                    myProcess.WaitForExit()
                    myProcess.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try


                MsgBox("Se instalaron los datos correctamente.", vbInformation)
                Application.Restart()

            End If
            Me.Cursor = Cursors.Default



        End If


    End Sub



    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Form_bkp.Show()

    End Sub
End Class