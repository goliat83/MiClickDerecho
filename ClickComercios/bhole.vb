Imports System.IO

Imports System.ComponentModel
Imports System.Text

Module bhole
    Public ExisteXAMP As Boolean = False
    Public ActivoXAMP As Boolean = False


    Private Declare Function GetVersion Lib "kernel32" () As Long

    Public Function GetWinVersion() As String
        Dim Ver As Long
        Dim WinVer As Long
        Ver = GetVersion()
        WinVer = Ver And &HFFFF&
        'retrieve the windows version 
        GetWinVersion = Format((WinVer Mod 256) + ((WinVer \ 256) / 100), "Fixed")
    End Function


    Public Sub ComprobarXamp()
        If castor = "xamp" Then
            '===================xamp instalado======================
            If IO.Directory.Exists("c:\xampp\") Then
                If File.Exists("c:\xampp\apache_start.bat") Then
                    If File.Exists("c:\xampp\uninstall.exe") Then
                        If File.Exists("c:\xampp\xampp-control.exe") Then
                            ExisteXAMP = True
                        End If
                    End If
                End If
            Else
                ExisteXAMP = False
            End If
            'fin xamp instalado =======================================
        End If

        If castor = "portable" Then
            '===================xamp instalado======================
            If IO.Directory.Exists("c:\miclick\Datos\") Then
                If File.Exists("c:\miclick\Datos\usbwebserver.exe") Then
                    ExisteXAMP = True
                End If
            Else
                ExisteXAMP = False
            End If
            'fin xamp instalado =======================================
        End If

        If castor = "mdflocal" Then
            '===================xamp instalado======================
            If IO.Directory.Exists("C:\MiClick\Datos") Then
                If File.Exists("C:\MiClick\Datos\micdb.mdf") Then
                    ExisteXAMP = True
                End If
            Else
                ExisteXAMP = False
            End If
            'fin xamp instalado =======================================
        End If
    End Sub

    Public Sub XampActivo()


        Dim ejecutandoxamp As Process() = Process.GetProcessesByName("xampp-control")
        If castor = "xamp" Then ejecutandoxamp = Process.GetProcessesByName("xampp-control")
        If castor = "portable" Then ejecutandoxamp = Process.GetProcessesByName("USBWebserver V8")

        If ejecutandoxamp.Length > 0 Then
            ActivoXAMP = True
        Else
            ActivoXAMP = False
        End If
    End Sub

    Public Sub get_data_conex_cloud(ByVal COMEX_CLOUDCODE As String)
        Try
            sql = "SELECT * FROM data_cloud WHERE cons ='" & COMEX_CLOUDCODE & "'"
            da = New MySqlDataAdapter(sql, conex_miclick)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                comex_hst = row.Item("data_hst")
                comex_db = row.Item("data_bd")
                comex_usr = row.Item("data_usr")
                comex_psw = row.Item("data_psw")
            Next
        Catch ex As Exception
            MsgBox("no se pudo obtener información de autenticación remota")
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
    End Sub



    Public Sub Centrar(ByVal Objeto As Object)

        ' Centrar un Formulario ...  
        If TypeOf Objeto Is Form Then
            Dim frm As Form = CType(Objeto, Form)
            With Screen.PrimaryScreen.WorkingArea ' Dimensiones de la pantalla sin el TaskBar  
                frm.Top = (.Height - frm.Height) \ 2
                frm.Left = (.Width - frm.Width) \ 2
            End With

            ' Centrar un control dentro del contenedor  
        Else
            ' referencia al control  
            Dim c As Control = CType(Objeto, Control)

            'le  establece el top y el Left dentro del Parent  
            With c
                .Top = (.Parent.ClientSize.Height - c.Height) \ 2
                .Left = (.Parent.ClientSize.Width - c.Width) \ 2
            End With
        End If
    End Sub

    Public Sub elmr_testo(ByRef RutaArchivo As String)
        Dim lineas = File.ReadAllLines(RutaArchivo, Encoding.[UTF8]).ToList()  ' cargo matriz con lineas de texto del txt

        Dim IndiceBorrar As Integer = 0 ' linea que se va a borrar
        Try
            lineas.RemoveAt(IndiceBorrar)

        Catch ex As Exception

        End Try


        File.WriteAllLines(RutaArchivo, lineas)
    End Sub


    Public Sub get_data_auth()
        If File.Exists("c:\miclick\midata.click") = True Then
            Try
                midata = Split(geringa(My.Computer.FileSystem.ReadAllText("c:\miclick\midata.click")), "|")

                comex_lic_tipo = midata(0)
                comex_lic_producto = midata(1)
                comex_lic_freg = midata(2)
                comex_lic_fini = midata(3)
                comex_lic_ffin = midata(4)

                comex_lic_nit = midata(5)
                comex_lic_propietario = midata(6)
                comex_lic_nequipos = midata(7)
                comex_lic_serial = midata(8)
                comex_lic_email = midata(9)
                comex_lic_estado = midata(10)

            Catch ex As Exception
                MsgBox("Error grave leyendo el archivo midata.click, contacte con soporte.")
            End Try
        Else
            MsgBox("no se encontró el archivo midata.click, contacte con soporte www.miclickderecho.com")
        End If
    End Sub


End Module
