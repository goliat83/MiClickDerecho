Imports MySql.Data.MySqlClient

Public Class Form_egreso_nomina_ver
    Dim fini, ffin As Date
    Dim sumadias, timetotal As String
    Private Sub Form_egreso_nomina_Load_ver(sender As Object, e As EventArgs) Handles MyBase.Load

        If comex_logo <> "" Then
            Me.PictureBox1.Image = Image.FromFile("c:\miclickderecho\logo.png")
        End If

        Me.TextBox6.Enabled = False
        If num_nomina_global <> "" Then


            cmd.Connection = conex
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from recibos_nomina where num=" & CLng(num_nomina_global) & ""
            conex.Open()
            Try
                dr = cmd.ExecuteReader()
                dr.Read()
                Me.Label43.Text = CStr(dr(0))
                Me.Label3.Text = CStr(dr(1))
                Me.Label5.Text = CStr(dr(2))
                Me.TextBox_DOC.Text = CStr(dr(3))
                Me.TextBox_OBSERVACION.Text = CStr(dr(4))
                Me.ComboBox3.Text = CStr(dr(5))
                Me.Label_SALARIO.Text = CStr(dr(6))
                Me.NumericUpDown1.Value = CStr(dr(7))
                Me.TextBox6.Text = CStr(dr(8))
                Me.TextBox9.Text = CStr(dr(9))
                Me.TextBox11.Text = CStr(dr(10))
                Me.TextBox7.Text = CStr(dr(11))
                Me.TextBox8.Text = CStr(dr(12))
                Me.TextBox10.Text = CStr(dr(13))
                Me.TextBox5.Text = CStr(dr(14))
                Me.Label24.Text = CStr(dr(15))
                Me.Label25.Text = CStr(dr(16))
                Me.Label10.Text = CStr(dr(17))
                Me.Label44.Text = CStr(dr(18))
                If Me.Label44.Text = "ANULADO" Then Me.Label44.Visible = True
                If Me.ComboBox3.Text = "Por Días" Then Me.Label32.Visible = True : NumericUpDown1.Visible = True
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            conex.Close()

            cmd.Connection = conex
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from EMPLEADOS where documento='" & Me.TextBox_DOC.Text.ToString & "'"
            conex.Open()
            Try
                dr = cmd.ExecuteReader()
                dr.Read()
                Me.TextBox_DOC.Text = CStr(dr(1))
                Me.TextBox_NOMBRE.Text = CStr(dr(2))
                Me.TextBox_DIR.Text = CStr(dr(3))
                Me.TextBox_TEL.Text = CStr(dr(4))
                Me.Label_SALARIO.Text = CStr(dr(10))
            Catch ex As Exception
                ultimo_recibo_egreso = 0
            End Try
            conex.Close()
        End If

        LinkLabel1.Enabled = False
        Me.TextBox7.Enabled = False
        Me.TextBox9.Enabled = False
        Me.TextBox10.Enabled = False
        Me.TextBox8.Enabled = False
        Me.TextBox11.Enabled = False
        Me.NumericUpDown1.Enabled = False
        Me.ComboBox2.Enabled = False
        Me.ComboBox3.Enabled = False
        Me.TextBox_OBSERVACION.Enabled = False
        Me.Button1.Enabled = False
        Me.Button3.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_NOMBRE.KeyPress
        If Char.IsLower(e.KeyChar) Then Me.TextBox_NOMBRE.SelectedText = Char.ToUpper(e.KeyChar) : e.Handled = True
    End Sub
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_DIR.KeyPress
        If Char.IsLower(e.KeyChar) Then Me.TextBox_DIR.SelectedText = Char.ToUpper(e.KeyChar) : e.Handled = True
    End Sub
    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_OBSERVACION.KeyPress
        If Char.IsLower(e.KeyChar) Then Me.TextBox_OBSERVACION.SelectedText = Char.ToUpper(e.KeyChar) : e.Handled = True
    End Sub
    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub TextBox12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_DOC.KeyPress
        If InStr(1, "0123456789-" & Chr(8) & Chr(13), e.KeyChar) = 0 Then e.KeyChar = ""
    End Sub
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_TEL.KeyPress
        If InStr(1, "0123456789- " & Chr(8) & Chr(13), e.KeyChar) = 0 Then e.KeyChar = ""
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub TextBox13_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.KeyChar = ""
    End Sub

    Private Sub TextBox14_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.KeyChar = ""
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Cursor = Cursors.WaitCursor
        Me.Button3.Dispose()
        Me.Button3.Visible = False
        Me.Button1.Dispose()
        Me.Button1.Visible = False
        Me.Button2.Dispose()
        Me.Button2.Visible = False
        Me.Label28.Visible = True
        Me.Label29.Visible = True
        Me.Label35.Visible = True
        Me.Label33.Visible = True
        Me.Label26.Visible = True
        Me.Label27.Visible = True

        Timer1.Enabled = True
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        System.Threading.Thread.Sleep(2500)

        Me.PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Top = 5
        Me.PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Left = 2
        Me.PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Right = 2

        Me.PrintForm1.PrintAction = Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.Print()
        Me.Cursor = Cursors.Default
        Timer1.Enabled = False
        Me.Close()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox_DOC.TextChanged

    End Sub

    Private Sub Form_egreso_nomina_ver_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Label_comex.Text = comex_nombrecomercial
        Me.Label36.Text = "NIT " & comex_nit
        Me.Label7.Text = comex_dircomercio & " - " & comex_tels & " - " & comex_ciudad
    End Sub
End Class