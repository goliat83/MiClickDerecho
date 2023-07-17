Imports MySql.Data.MySqlClient

Public Class Form_egreso_nomina
    Dim fini, ffin As Date
    Dim sumadias, timetotal As String
    Private Sub Form_egreso_nomina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If comex_logo <> "" Then
            Me.PictureBox1.Image = Image.FromFile("c:\miclickderecho\logo.png")
        End If

        Me.Label10.Text = usrnom
        If num_nomina_global = "" Then
            Me.Cursor = Cursors.WaitCursor
            Me.Label3.Text = DateTime.Now().ToShortDateString
            calcular_consecutivos()
            Me.Label10.Text = usrnom

            ' lleno combo
            Me.ComboBox2.DisplayMember = Nothing
            Me.ComboBox2.ValueMember = Nothing
            Me.ComboBox2.DataSource = Nothing
            sql = "SELECT * from empleados"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
                Me.ComboBox2.DataSource = dt.DefaultView
                Me.ComboBox2.DisplayMember = "nombre"
                Me.ComboBox2.ValueMember = "documento"
            Catch ex As Exception
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        If num_nomina_global <> "" Then
            LinkLabel1.Enabled = False
            Me.TextBox7.Enabled = False
            Me.TextBox9.Enabled = False
            Me.TextBox10.Enabled = False
            Me.TextBox8.Enabled = False
            Me.TextBox11.Enabled = False
            Me.NumericUpDown1.Enabled = False
            Me.ComboBox2.Enabled = False
            Me.ComboBox3.Enabled = False
            Me.TextBox_observ.Enabled = False
            Me.Button1.Enabled = False
            Me.Button3.Enabled = True

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
                Me.TextBox_doc.Text = CStr(dr(3))
                Me.TextBox_observ.Text = CStr(dr(4))
                Me.ComboBox3.Text = CStr(dr(5))
                Me.Label34.Text = CStr(dr(6))
                Me.NumericUpDown1.Value = CStr(dr(7))
                Me.TextBox6.Text = CStr(dr(8))
                Me.TextBox9.Text = CStr(dr(9))
                Me.TextBox11.Text = CStr(dr(10))
                Me.TextBox7.Text = CStr(dr(11))
                Me.TextBox8.Text = CStr(dr(12))
                Me.TextBox10.Text = CStr(dr(13))
                Me.TextBox_total_nomina.Text = CStr(dr(14))
                Me.Label24.Text = CStr(dr(15))
                Me.Label25.Text = CStr(dr(16))
                Me.Label10.Text = CStr(dr(17))

                Me.Label44.Text = CStr(dr(18))
                If Me.Label44.Text = "ANULADO" Then Me.Label44.Visible = True

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            conex.Close()
        End If
    End Sub

    Private Sub Form_egreso_nomina_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Label_comex.Text = comex_nombrecomercial
        Me.Label36.Text = "nit" & comex_nit
        Me.Label7.Text = comex_dircomercio & " - " & comex_tels & "" & comex_ciudad


        If num_nomina_global = "" Then
            ToolTip1.UseFading = True
            ToolTip1.UseAnimation = True
            ToolTip1.ShowAlways = True
            ToolTip1.AutoPopDelay = 2000
            ToolTip1.InitialDelay = 2000
            ToolTip1.IsBalloon = True
            Me.ToolTip1.ToolTipTitle = "Pago de Nómina."
            Me.ToolTip1.Show("Seleccione un empleado para realizar el pago de nomina...", Me.Label12)
        End If

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.TextBox_doc.Text = "" Then MsgBox("Debe elejir un Empleado", vbExclamation) : Exit Sub
        If Me.ComboBox3.Text = "" Then MsgBox("Debe elejir tipo de pago", vbExclamation) : Exit Sub
        If Me.Label24.Text = "0" And Me.Label25.Text = "0" Then MsgBox("Parece que no ha calculado la liquidacion, no se puede guardar.", vbExclamation) : Exit Sub

        Me.Cursor = Cursors.WaitCursor

        calcular_consecutivos()

        ' se guarda
        sql = "INSERT INTO recibos_nomina (num, fecha, egreso, empleado_doc, observaciones, tipo_pago, salario_mensual, dias, basico_devengado, extras_dev, otros_extras_dev, salud_pension, prestamos, otros_dctos, total_devengado, total_descuentos, total_pago, elaboro, estado)" &
              "VALUES (" & CLng(Me.Label43.Text) & ",'" & Me.Label3.Text & "','" & Me.Label5.Text & "','" & Me.TextBox_doc.Text & "','" & Me.TextBox_observ.Text & "','" & Me.ComboBox3.Text & "','" & Me.Label34.Text & "','" & Me.NumericUpDown1.Value & "','" & Me.TextBox6.Text & "','" & Me.TextBox9.Text & "','" & Me.TextBox11.Text & "','" & Me.TextBox7.Text & "','" & Me.TextBox8.Text & "','" & Me.TextBox10.Text & "','" & Me.Label24.Text & "','" & Me.Label25.Text & "','" & Me.TextBox_total_nomina.Text & "','" & Me.Label10.Text & "','VIGENTE')"
        da = New MySqlDataAdapter(sql, conex)
        dt = New DataTable
        Try
            da.Fill(dt)
            ' MsgBox("Se Guardaron los datos del Cliente. ")
        Catch ex As Exception
            If ex.ToString.Contains("Duplicate entry") Then MsgBox("Ya  registrado con ese número de Documento, verifique los datos.", vbExclamation)
            MsgBox(ex.ToString)
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()



        MsgBox("Se registró el comprobante de nomina y se generó el egreso correspondiente.", vbInformation)

        LinkLabel1.Enabled = False
        Me.TextBox7.Enabled = False
        Me.TextBox9.Enabled = False
        Me.TextBox10.Enabled = False
        Me.TextBox8.Enabled = False
        Me.TextBox11.Enabled = False
        Me.NumericUpDown1.Enabled = False
        Me.ComboBox2.Enabled = False
        Me.ComboBox3.Enabled = False
        Me.TextBox_observ.Enabled = False

        Me.Button1.Enabled = False
        Me.Button3.Enabled = True

        Me.Cursor = Cursors.Default

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_dir.KeyPress
        If Char.IsLower(e.KeyChar) Then Me.TextBox_dir.SelectedText = Char.ToUpper(e.KeyChar) : e.Handled = True
    End Sub
    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_observ.KeyPress
        If Char.IsLower(e.KeyChar) Then Me.TextBox_observ.SelectedText = Char.ToUpper(e.KeyChar) : e.Handled = True
    End Sub
    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_total_nomina.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub TextBox12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_doc.KeyPress
        If InStr(1, "0123456789-" & Chr(8) & Chr(13), e.KeyChar) = 0 Then e.KeyChar = ""
    End Sub
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_tels.KeyPress
        If InStr(1, "0123456789- " & Chr(8) & Chr(13), e.KeyChar) = 0 Then e.KeyChar = ""
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        cmd.Connection = conex
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from EMPLEADOS where documento='" & Me.ComboBox2.SelectedValue.ToString & "'"
        conex.Open()
        Try
            dr = cmd.ExecuteReader()
            dr.Read()
            Me.TextBox_doc.Text = CStr(dr(1))
            Me.TextBox_nombre.Text = CStr(dr(2))
            Me.TextBox_dir.Text = CStr(dr(3))
            Me.TextBox_tels.Text = CStr(dr(5))
            Me.Label34.Text = CStr(dr(10))
            Me.TextBox1.Text = CStr(dr(6))
        Catch ex As Exception
            ultimo_recibo_egreso = 0
        End Try
        conex.Close()

        If Me.Label34.Text = "0" Or Me.Label34.Text = "" Then
            ToolTip1.UseFading = True
            ToolTip1.UseAnimation = True
            ToolTip1.ShowAlways = True
            ToolTip1.AutoPopDelay = 2000
            ToolTip1.InitialDelay = 2000
            ToolTip1.IsBalloon = True
            Me.ToolTip1.ToolTipTitle = "Salario Basico Mensual."
            Me.ToolTip1.Show("Parece que el usuario no tiene salario basico asignado, se debe asignar un salario para calcular el pago de nomina...", Me.Label34)
        End If
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

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If Me.TextBox_doc.Text = "" Then MsgBox("Debe elejir un empleado", vbInformation) : Me.ComboBox3.Text = Nothing : Exit Sub
        If Me.Label34.Text = "" Then MsgBox("el empleado seleccionado no tiene asignado sueldo mensual.", vbInformation) : Me.ComboBox3.Text = Nothing : Exit Sub

        If Me.ComboBox3.Text = "Semanal" Then
            Me.NumericUpDown1.Visible = False
            Me.NumericUpDown1.Enabled = False
            Me.NumericUpDown1.Value = 0
            Me.Label32.Visible = False
            Me.TextBox6.Text = CLng(Me.Label34.Text) / 4
        End If

        If Me.ComboBox3.Text = "Quincenal" Then
            Me.NumericUpDown1.Visible = False
            Me.NumericUpDown1.Enabled = False
            Me.NumericUpDown1.Value = 0
            Me.Label32.Visible = False
            Me.TextBox6.Text = CLng(Me.Label34.Text) / 2
        End If

        If Me.ComboBox3.Text = "Mensual" Then
            Me.NumericUpDown1.Visible = False
            Me.NumericUpDown1.Enabled = False
            Me.NumericUpDown1.Value = 0
            Me.Label32.Visible = False
            Me.TextBox6.Text = CLng(Me.Label34.Text)
        End If

        If Me.ComboBox3.Text = "Por Días" Then
            Me.NumericUpDown1.Visible = True
            Me.NumericUpDown1.Enabled = True
            Me.NumericUpDown1.Value = 1
            Me.Label32.Visible = True
            Me.TextBox6.Text = CLng((CLng(Me.Label34.Text) / 30) * (CLng(Me.NumericUpDown1.Value)))
        End If

    End Sub

    Private Sub total_devengado()
        Me.Label24.Text = CLng(Me.TextBox6.Text) + CLng(Me.TextBox9.Text) + CLng(Me.TextBox11.Text)
    End Sub
    Private Sub total_descuentos()
        Me.Label25.Text = CLng(Me.TextBox7.Text) + CLng(Me.TextBox8.Text) + CLng(Me.TextBox10.Text)

    End Sub
    Private Sub calcular_consecutivos()
        Me.Cursor = Cursors.WaitCursor
        Me.Label3.Text = DateTime.Now().ToShortDateString

        'consulto numero de recibo
        cmd.Connection = conex
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select num from recibos_nomina ORDER BY num DESC"
        conex.Open()
        Try
            dr = cmd.ExecuteReader()
            dr.Read()
            ultimo_recibo_egreso_nomina = CLng(dr(0))
        Catch ex As Exception
            ultimo_recibo_egreso_nomina = 0
        End Try
        conex.Close()
        Me.Label43.Text = ultimo_recibo_egreso_nomina + 1

        'consulto numero de recibo
        cmd.Connection = conex
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select id from recibos_egresos ORDER BY id DESC"
        conex.Open()
        Try
            dr = cmd.ExecuteReader()
            dr.Read()
            ultimo_recibo_egreso = CLng(dr(0))
        Catch ex As Exception
            ultimo_recibo_egreso = 0
        End Try
        conex.Close()
        Me.Label5.Text = ultimo_recibo_egreso + 1


    End Sub


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        total_descuentos()
        total_devengado()
        Me.TextBox_total_nomina.Text = CLng(Me.Label24.Text) - CLng(Me.Label25.Text)
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        Me.TextBox6.Text = CLng((CLng(Me.Label34.Text) / 30) * (CLng(Me.NumericUpDown1.Value)))

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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox_nombre.TextChanged

    End Sub

    Private Sub Label38_Click(sender As Object, e As EventArgs) Handles Label_comex.Click

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox_doc_TextChanged(sender As Object, e As EventArgs) Handles TextBox_doc.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
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

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox_nombre.KeyPress
        e.KeyChar = ""

    End Sub
End Class