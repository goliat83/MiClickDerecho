Imports System.ComponentModel

Public Class Form_bkp

    Dim vari As String

    Private Sub button_crear_Click(sender As Object, e As EventArgs) Handles button_crear.Click
        If adn <> "s" Then
            MsgBox("esta opción solo se puede ejecutar en el equipo servidor.")
            Exit Sub
        End If

        Dim ruta As String = "C:\"

        vari = DateTime.Now.ToShortDateString & DateTime.Now.ToShortTimeString
        vari = vari.Replace("/", "")
        vari = vari.Replace(":", "")
        vari = vari.Replace(".", "")
        vari = vari.Replace(" ", "")

        'Dim rta2 = MsgBox("Pregunta?. " & Chr(13) & Chr(13) & "Confirma crear una copia de seguridad?.", MsgBoxStyle.Information + MsgBoxStyle.YesNo)
        Dim rta2 As String = 6
        If rta2 = 6 Then
            button_crear.Visible = False
            PictureBox_loader.Visible = True

            Label_ok.Visible = False
            PictureBox_ok.Visible = False

            BackWorker_bkp.WorkerReportsProgress = True
            BackWorker_bkp.WorkerSupportsCancellation = True
            BackWorker_bkp.RunWorkerAsync()
        End If



    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

        If System.IO.Directory.Exists(Label1.Text) = True Then
            Process.Start("explorer.exe", Label1.Text)
        End If

    End Sub



    Private Sub BackWorker_bkp_DoWork_1(sender As Object, e As DoWorkEventArgs) Handles BackWorker_bkp.DoWork
        Cursor.Current = Cursors.WaitCursor

        Dim myProcess As New Process()

        Try
            myProcess.StartInfo.UseShellExecute = False
            ' You can start any process, HelloWorld is a do-nothing example.
            Dim dump_path As String = ""
            If castor = "xamp" Then dump_path = "C:\xampp\mysql\bin\mysqldump.exe"
            If castor = "portable" Then dump_path = "C:\miclick\datos\mysql\bin\mysqldump.exe"

            myProcess.StartInfo.FileName = dump_path
            If castor = "xamp" Then myProcess.StartInfo.Arguments = " -u root -pRadiobemba miclickdb -r C:\miclickderecho\backup\BACKUP" & CStr(vari) & ".sql"
            If castor = "portable" Then myProcess.StartInfo.Arguments = " -u root -pRadiobemba miclickdb -r C:\miclick\backup\BACKUP" & CStr(vari) & ".sql"
            myProcess.StartInfo.CreateNoWindow = True
            myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            myProcess.Start()
            ' This code assumes the process you are starting will terminate itself. 
            ' Given that is is started without a window so you cannot terminate it 
            ' on the desktop, it must terminate itself or you can do it programmatically
            ' from this application using the Kill method.
        Catch eX As Exception
            MsgBox(eX)
        End Try
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub BackWorker_bkp_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackWorker_bkp.RunWorkerCompleted
        'MsgBox("Se Creó la copia de seguridad correctamente.", vbInformation)
        button_crear.Visible = True

        Label_ok.Visible = True
        PictureBox_ok.Visible = True


        PictureBox_loader.Visible = False
    End Sub

    Private Sub Form_bkp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If castor = "xamp" Then Label1.Text = "C:\miclickderecho\backup\"
        If castor = "portable" Then Label1.Text = "C:\miclick\backup\"

    End Sub
End Class