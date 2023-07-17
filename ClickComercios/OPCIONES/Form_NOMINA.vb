Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class Form_nomina
    Dim mes_num As Integer
    Dim mes_num_text As String
    Private Sub Form_nomina_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_nomina_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Cursor = Cursors.WaitCursor


        mes_num = DateTime.Now.Month()
        mes_num_text = CStr(mes_num)
        If mes_num <= 9 Then mes_num_text = "0" & CStr(mes_num)
        ComboBoX_fechaMES.SelectedIndex = mes_num_text - 1

        ' lleno combo
        Me.ComboBox1.DisplayMember = Nothing
        Me.ComboBox1.ValueMember = Nothing
        Me.ComboBox1.DataSource = Nothing
        sql = "SELECT * from empleados"
        da = New MySqlDataAdapter(sql, conex)
        dt = New DataTable
        Try
            da.Fill(dt)
            Me.ComboBox1.DataSource = dt.DefaultView
            Me.ComboBox1.DisplayMember = "nombre"
            Me.ComboBox1.ValueMember = "documento"
        Catch ex As Exception
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()

        Me.ComboBox1.SelectedIndex = 1


        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        grid_nomina()

    End Sub
    Private Sub grid_nomina()
        sql = "SELECT * FROM recibos_nomina where empleado_DOC='" & Me.ComboBox1.SelectedValue.ToString & "' and month(STR_TO_DATE(fecha,'%d/%m/%Y'))=" & CInt(mes_num_text) & ""
        da = New MySqlDataAdapter(sql, conex)
        dt = New DataTable
        da.Fill(dt)
        Me.DataGridView1.DataSource = dt
        Me.DataGridView1.CurrentCell = Nothing
        Me.datagridview1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.datagridview1.Columns(0).HeaderText = "#Recibo"
        Me.datagridview1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.datagridview1.Columns(0).Width = 80
        Me.datagridview1.Columns(1).HeaderText = "Fecha"
        Me.datagridview1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.datagridview1.Columns(1).Width = 100
        Me.datagridview1.Columns(2).Visible = False
        Me.datagridview1.Columns(3).Visible = False
        Me.datagridview1.Columns(4).HeaderText = "Empleado"
        Me.datagridview1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.datagridview1.Columns(5).Visible = False
        Me.datagridview1.Columns(6).Visible = False
        Me.datagridview1.Columns(7).Visible = False
        Me.datagridview1.Columns(8).Visible = False
        Me.datagridview1.Columns(9).Visible = False
        Me.datagridview1.Columns(10).Visible = False
        Me.datagridview1.Columns(11).Visible = False
        Me.datagridview1.Columns(12).Visible = False
        Me.datagridview1.Columns(13).Visible = False
        Me.datagridview1.Columns(14).Visible = False
        Me.datagridview1.Columns(15).Visible = False
        Me.datagridview1.Columns(16).Visible = False
        Me.datagridview1.Columns(17).Visible = False
        Me.datagridview1.Columns(18).Visible = False
        Me.datagridview1.Columns(19).Visible = False

        da.Dispose()
        dt.Dispose()
        conex.Close()
    End Sub




    Private Sub Button_export_pdf_Click(sender As Object, e As EventArgs) Handles Button_export_pdf.Click
        Form_egreso_nomina.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If num_nomina_global <> "" Then
            Form_egreso_nomina_ver.Show()
        End If
    End Sub

    Private Sub ComboBoX_fechaMES_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoX_fechaMES.SelectedIndexChanged

    End Sub

    Private Sub ComboBoX_fechaMES_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBoX_fechaMES.SelectionChangeCommitted
        mes_num = DateTime.ParseExact(Me.ComboBoX_fechaMES.Text, "MMMM", CultureInfo.CurrentCulture).Month
        mes_num_text = CStr(mes_num)
        If mes_num <= 9 Then mes_num_text = "0" & CStr(mes_num)


        grid_nomina()
    End Sub


    Private Sub datagridview1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridview1.CellClick
        num_nomina_global = ""
        Dim row As DataGridViewRow = datagridview1.CurrentRow
        num_nomina_global = CStr(row.Cells("num").Value)
    End Sub

    Private Sub datagridview1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridview1.CellContentClick

    End Sub

    Private Sub datagridview1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles datagridview1.CellFormatting

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class