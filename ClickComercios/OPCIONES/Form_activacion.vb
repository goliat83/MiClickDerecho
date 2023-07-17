Imports System.IO
Imports System.Text

Public Class Form_activacion
    Dim lic_estado2, lic_tipo2, LIC_SSD_2 As String

    Public da_lics_svr As New MySqlDataAdapter
    Public dt_lics_svr As DataTable

    Public da_cli_svr As New MySqlDataAdapter
    Public dt_cli_svr As DataTable

    Private Sub Form_activacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_activacion_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        get_data_auth()

        Me.Cursor = Cursors.WaitCursor
        VersionActual = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString

        Dim disco As New System.Management.ManagementObject("Win32_PhysicalMedia='\\.\PHYSICALDRIVE0'")

        'buscamos serial des disco duro
        Try
            SERIAL_DD = disco.Properties("SerialNumber").Value.ToString
            SERIAL_DD = Trim(SERIAL_DD)
            Me.Label_ssdd.Text = SERIAL_DD.ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        TextBox_serial.Text = comex_lic_acivetcode

        Label_estado_lic.Text = comex_lic_estado

        Label_tipo_lic.Text = comex_lic_tipo
        Label_producto.Text = comex_lic_producto
        Label_fecha_r.Text = comex_lic_freg
        Label_fecha_v.Text = comex_lic_ffin

        TextBox_doc.Text = comex_lic_nit
        TextBox_razonsocial.Text = comex_lic_propietario
        TextBox_mail.Text = comex_lic_email


        If comex_lic_estado = "" Then
            PictureBox2.Image = My.Resources.exclamation
        End If

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.KeyChar = ""
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button_cerrar_Click(sender As Object, e As EventArgs) Handles Button_cerrar.Click
        Me.Close()
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox_nit_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox_serial_TextChanged(sender As Object, e As EventArgs) Handles TextBox_serial.TextChanged

    End Sub

    Private Sub Button_demo_Click(sender As Object, e As EventArgs)
        VERIFICAR_CONEXION_REMOTA()
        If ESTADO_CONEXION_REMOTA = False Then
            MsgBox("No se detectó conexión a internet, para registrarse y habilitar la licencia demo necesita estar conectado a internet.")
            Exit Sub
        End If


        If ESTADO_CONEXION_REMOTA = True Then
            Dim RTA As String
            RTA = MsgBox("Confirme los datos para el regsitro:" & Chr(13) & Chr(13) & Me.TextBox_doc.Text.ToString & vbNewLine &
                TextBox_razonsocial.Text & vbNewLine &
                TextBox_mail.Text, MsgBoxStyle.Question + MsgBoxStyle.YesNo)

            If RTA = 6 Then

                'seleccione fecha de internet
                Dim fechareg As String = ""
                Dim fechav As String = ""

                sql = "SELECT now() as fechareg, licencias.* FROM LICENCIAS"
                da = New MySqlDataAdapter(sql, conex_miclick)
                dt = New DataTable
                da.Fill(dt)
                For Each row As DataRow In dt.Rows
                    fechareg = row.Item("fechareg")
                Next

                Dim val As String
                val = "Demo|" &
                "MiClickDerecho Comercial|" &
                fechareg & "|" &
                fechareg & "|" &
                fechav & "|" &
                TextBox_doc.Text & "|" &
                TextBox_razonsocial.Text & "|" &
                "1" &
                SERIAL_DD & "|" &
                TextBox_mail.Text & "|" &
                "Pendiente"



                Dim codelic As String = geringo(val)

                My.Computer.FileSystem.DeleteFile("c:\miclick\miadn.click")

                Dim path As String = "c:\miclick\miadn.click"
                Dim fs As FileStream = File.Create(path)
                Dim info As Byte() = New UTF8Encoding(True).GetBytes(codelic)
                fs.Write(info, 0, info.Length)
                fs.Close()

                TextBox_doc.Enabled = False
                TextBox_razonsocial.Enabled = False
                TextBox_mail.Enabled = False
            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox_serial.Text = "" Then
            MsgBox("por favor escriba el serial se activación.", vbInformation)
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor
        VERIFICAR_CONEXION_REMOTA()
        If ESTADO_CONEXION_LOCAL = False Then
            MsgBox("No se detectó conexión a internet.", vbInformation)
            Exit Sub
        End If


        lic_estado2 = ""
        Try
            'leer datos de licencia 
            sql = "SELECT * FROM LICENCIAS where SSD='" & Me.Label_ssdd.Text & "' AND ACTIVACION='" & TextBox_serial.Text & "'"
            da_lics_svr = New MySqlDataAdapter(sql, conex_miclick)   ' conecto a licencias_comex en www.clickderecho.net
            dt_lics_svr = New DataTable
            da_lics_svr.Fill(dt_lics_svr)
            For Each row As DataRow In dt_lics_svr.Rows
                lic_estado2 = row.Item("estado")
                comex_lic_tipo = row.Item("tipo")
                comex_lic_producto = row.Item("software")
                comex_lic_freg = row.Item("fr")
                comex_lic_fini = row.Item("f1")
                comex_lic_ffin = row.Item("f2")
                comex_lic_nit = row.Item("nit")
                comex_lic_nequipos = row.Item("nmaquinas")
                comex_lic_serial = row.Item("ssd")
                comex_lic_estado = row.Item("estado")
            Next
        Catch ex As Exception

        End Try
        conex.Close()
        da_lics_svr.Dispose()
        dt_lics_svr.Dispose()


        If lic_estado2.ToUpper = "ACTIVA" Then
            Try
                sql = "SELECT * FROM CLIENTES WHERE nitDOC='" & comex_lic_nit & "'"
                da_cli_svr = New MySqlDataAdapter(sql, conex_miclick)   ' conecto a licencias_comex en www.clickderecho.net
                dt_cli_svr = New DataTable
                da_cli_svr.Fill(dt_cli_svr)
                For Each row As DataRow In dt_cli_svr.Rows
                    comex_nit = row.Item("nitDOC")
                    comex_DV = row.Item("dv")
                    comex_razonsocial = row.Item("nombre")
                    comex_nombrecomercial = row.Item("NOMBREcomercial")
                    comex_nombrepropietario = row.Item("PROPIETARIO")
                    comex_cels = row.Item("celular")
                    comex_tels = row.Item("telefono")
                    comex_dircomercio = row.Item("direccion")
                    comex_email = row.Item("emaiL")
                    comex_regimen = row.Item("regimenCOMERCIO")

                    comex_lic_email = comex_email
                    comex_lic_regimen = row.Item("regimencomercio")

                Next
            Catch ex As Exception

            End Try
            conex.Close()
            da_cli_svr.Dispose()
            dt_cli_svr.Dispose()


            'elimino licencias
            sql = "truncate table lics"
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
            'inserto nuevas licencias
            For Each row As DataRow In dt_lics_svr.Rows
                sql = "INSERT INTO lics (NIT, Cliente, Tipo, Desde, Hasta, cant, SSDD, Activacion, Estado)" &
                "VALUES ('" & comex_nit & "','" & comex_nombrecomercial & "','" & comex_lic_tipo & "','" & comex_lic_fini & "','" & comex_lic_ffin & "','" & comex_lic_nequipos & "','" & comex_lic_serial & "','" & comex_lic_acivetcode & "','" & comex_lic_estado & "')"
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                Try
                    da.Fill(dt)
                Catch ex As Exception

                End Try
                da.Dispose()
                dt.Dispose()
                conex.Close()
            Next


            'actualizar datos del comercio
            sql = "UPDATE DATA_comex SET nit='" & comex_nit & "', dv='" & comex_DV & "', razonsocial='" & comex_razonsocial & "', nombrecomercial='" & comex_nombrecomercial & "', nombrepropietario='" & comex_nombrepropietario & "', email='" & comex_email & "', telS='" & comex_tels & "', dirCOMERCIO='" & comex_dircomercio & "', REGIMEN='" & comex_regimen & "' WHERE CONS=1"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception

            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()

            'borrar contenido archivo midata.click
            Try
                elmr_testo("C:\miclick\midata.click")
            Catch ex As Exception

            End Try

            Try
                'escibir nueva licencia

                Dim val As String
                val = comex_lic_tipo & "|" &
            comex_lic_producto & "|" &
            comex_lic_freg & "|" &
            comex_lic_fini & "|" &
            comex_lic_ffin & "|" &
            comex_lic_nit & "|" &
            comex_lic_razonsocial & "|" &
            comex_lic_nequipos & "|" &
            comex_lic_serial & "|" &
            comex_lic_email & "|" &
            comex_lic_estado

                My.Computer.FileSystem.WriteAllText("C:\miclick\midata.click", geringo(val), True)

            Catch ex As Exception

            End Try


            Me.TopMost = False

            MsgBox("SE ACTIVO LA LICENCIA GRACIAS POR USAR MiClcikDerecho.", vbInformation)

            Me.Close()

        Else
            Me.TopMost = False

            MsgBox("NO SE PUDO ACTIVAR LA LICENCIA.", vbInformation)
            Me.TopMost = True

        End If
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Form_activacion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If comex_lic_estado.ToString.ToUpper <> "ACTIVA" Then
            End
        End If
    End Sub
End Class