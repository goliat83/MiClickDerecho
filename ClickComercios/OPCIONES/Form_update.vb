Imports System.ComponentModel
Imports System.IO
Imports System.IO.Compression

Public Class Form_update


    Private Sub Form_update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NuevaVersion = "?"
        LabelVactual.Text = VersionActual
        LabelVnueva.Text = "?"

    End Sub

    Private Sub Form_update_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        VERIFICAR_CONEXION_REMOTA()

        If ESTADO_CONEXION_REMOTA = True Then
            Me.PictureBox_up_ok.Image = My.Resources.loading2
            Me.PictureBox_up_ok.Visible = True
            Label_info_update.Text = "Buscando actualizaciones..."
            Label_info_update.Visible = True
            Timer_update.Enabled = True

        End If

        If ESTADO_CONEXION_REMOTA = False Then
            Label_info_update.Visible = True

            Label_info_update.Text = "no esta conectado a internet..."
            Me.PictureBox_up_ok.Image = My.Resources.exclamation
            button_descargar.Visible = True : button_descargar.Text = "Buscar"

        End If

    End Sub



    Private Sub Timer_update_Tick(sender As Object, e As EventArgs) Handles Timer_update.Tick
        Timer_update.Enabled = False


        If ESTADO_CONEXION_REMOTA = True Then
            ' INICIA EL BACKGROUNDWORKER D EB USCAR ACTUIALIZACION
        End If


        If Background_up.IsBusy <> True Then
            Background_up.WorkerReportsProgress = True
            Background_up.WorkerSupportsCancellation = True
            Background_up.RunWorkerAsync()
        End If
    End Sub


    Private Sub Background_up_DoWork(sender As Object, e As DoWorkEventArgs) Handles Background_up.DoWork
        VERIFICAR_CONEXION_REMOTA()

        If ESTADO_CONEXION_REMOTA = True Then

            Try

                buscar_actualizaciones()

            Catch ex As Exception
                button_descargar.Visible = True : button_descargar.Text = "Buscar"
                Label_info_update.Text = "no se pudo conectar con el servidor ...."
                Me.PictureBox_up_ok.Image = My.Resources.exclamation

            Finally

            End Try

        End If

        If Background_up.CancellationPending Then Exit Sub

    End Sub
    Private Sub Background_up_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles Background_up.RunWorkerCompleted

        Dim NV As String = NuevaVersion
        Dim VA As String = VersionActual
        NV = NV.Replace(".", "")
        VA = VA.Replace(".", "")

        If CInt(NV) > CInt(VA) Then

            If NuevaVersion = "" Then Exit Sub
            LabelVnueva.Text = NuevaVersion
            LabelVactual.Text = VersionActual

            'MsgBox("hay actualizacion " & Chr(13) & "*" & SERIAL_DD & "*", vbInformation)
            Label_info_update.Text = "Una nueva actualización está disponible...."
            Panel1.Visible = True
            button_descargar.Visible = True : button_descargar.Text = "Descargar"
            Me.PictureBox_up_ok.Image = My.Resources.oktrans
            Me.PictureBox_up_ok.Visible = True

            Me.Label_info_update.Visible = True

            'Me.PictureBox_up_ok.Image = My.Resources.Informaci
            'Me.PictureBox_up_ok.Visible = True

            'elimina si hay actualizacion
            If File.Exists("c:\miclick\setup.zip") Then
                My.Computer.FileSystem.DeleteFile("c:\miclick\setup.zip")
            End If
            If File.Exists("c:\miclick\setup" & NuevaVersion & ".zip") Then
                My.Computer.FileSystem.DeleteFile("c:\miclick\setup" & NuevaVersion & ".zip")
            End If
            If File.Exists("c:\miclick\setup" & VersionActual & ".zip") Then
                My.Computer.FileSystem.DeleteFile("c:\miclick\setup" & VersionActual & ".zip")
            End If
            If Directory.Exists("c:\miclick\setup\") Then
                Try
                    My.Computer.FileSystem.DeleteDirectory("c:\miclick\setup\", FileIO.DeleteDirectoryOption.DeleteAllContents)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
        Else
            Label_info_update.Text = "no se encontraron actualizaciones."
            Me.PictureBox_up_ok.Image = My.Resources.Informaci
            Me.PictureBox_up_ok.Visible = True
            LabelVnueva.Text = NuevaVersion
            LabelVactual.Text = VersionActual
        End If
    End Sub



    Private Sub button_descargar_Click(sender As Object, e As EventArgs) Handles button_descargar.Click


        If button_descargar.Text = "Descargar" Then
            Label_info_update.Text = "descarganddo actualizacion, por favor espere."

            If File.Exists("c:\miclick\setup" & VersionActual & ".zip") Then
                My.Computer.FileSystem.DeleteFile("c:\miclick\setup" & VersionActual & ".zip")
            End If

            Me.Label_info_update.Text = "Descargando actualización..."
            Me.PictureBox_up_ok.Image = My.Resources.loading2
            Me.PictureBox_up_ok.Visible = True
            button_descargar.Visible = False
            ' INICIA EL BACKGROUNDWORKER
            BackgroundWorker_up_do.WorkerReportsProgress = True
            BackgroundWorker_up_do.WorkerSupportsCancellation = True
            BackgroundWorker_up_do.RunWorkerAsync()

        End If


        If button_descargar.Text = "Instalar" Then
            If Directory.Exists("c:\miclick\setup") = True Then
                My.Computer.FileSystem.DeleteDirectory("c:\miclick\setup", FileIO.DeleteDirectoryOption.DeleteAllContents, FileIO.RecycleOption.SendToRecycleBin)
            End If
            Me.Label_info_update.Text = "Instalando actualización..."

            Me.PictureBox_up_ok.Image = My.Resources.loader1
            Me.PictureBox_up_ok.Visible = True


            ' INICIA EL BACKGROUNDWORKER
            BackgroundWorker_install.WorkerReportsProgress = True
            BackgroundWorker_install.WorkerSupportsCancellation = True
            BackgroundWorker_install.RunWorkerAsync()

        End If


    End Sub

    Private Sub BackgroundWorker_up_do_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker_up_do.DoWork
        Try
            My.Computer.Network.DownloadFile(LinkActualizacion, "c:\miclick\setup" & NuevaVersion & ".zip", False, 360000)

            If BackgroundWorker_up_do.CancellationPending Then Exit Sub
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BackgroundWorker_up_do_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker_up_do.RunWorkerCompleted
        If NuevaVersion <> VersionActual Then
            If NuevaVersion = "" Then Exit Sub
            'MsgBox("hay actualizacion " & Chr(13) & "*" & SERIAL_DD & "*", vbInformation)

            Me.Label_info_update.Visible = True
            Me.Label_info_update.Text = "se completó la descarga ahora puede instalarla."
            Me.PictureBox_up_ok.Image = My.Resources.oktrans
            Me.PictureBox_up_ok.Visible = True
            button_descargar.Text = "Instalar"
            button_descargar.Visible = True
        End If
    End Sub

    Private Sub BackgroundWorker_install_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker_install.DoWork
        Dim extractPath As String = "c:\miclick\setup\"
        Try
            ZipFile.ExtractToDirectory("c:\miclick\setup" & NuevaVersion & ".zip", extractPath)
        Catch ex As Exception
        End Try

        If BackgroundWorker_install.CancellationPending Then Exit Sub
    End Sub

    Private Sub BackgroundWorker_install_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker_install.RunWorkerCompleted
        If File.Exists("c:\miclick\setup" & VersionActual & ".zip") Then
            My.Computer.FileSystem.DeleteFile("c:\miclick\setup" & VersionActual & ".zip")
        End If
        If File.Exists("c:\miclick\setup" & NuevaVersion & ".zip") Then
            My.Computer.FileSystem.DeleteFile("c:\miclick\setup" & NuevaVersion & ".zip")
        End If
        Try
            Process.Start("c:\miclick\setup\setup.exe")

        Catch ex As Exception

        End Try
        End
    End Sub
End Class