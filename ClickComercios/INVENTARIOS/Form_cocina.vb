Public Class Form_cocina

    Dim ini As Date
    Dim fin As Date
    Dim cons_pedido As String
    Dim sumadias As String
    Dim sumahoras As String
    Dim sumamins As String
    Dim sumatiempos As String

    Dim observaciones As String = ""

    Dim pedido As String = ""
    Dim mesa As String = ""
    Dim mesero As String = ""
    Dim hora() As String


    Private Sub Form_cocina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            sql = "select documento, mesa, mesero, cocina, observaciones from ventas_pre where estado='PENDIENTE' AND COCINA like '%SI%'"
            da_cocina_pedidos = New MySqlDataAdapter(sql, conex)
            dt_cocina_pedidos = New DataTable
            da_cocina_pedidos.Fill(dt_cocina_pedidos)
            Me.datagrid_pedidos.DataSource = dt_cocina_pedidos
            Me.datagrid_pedidos.Columns(3).Visible = False
            Me.datagrid_pedidos.Columns(4).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_cocina_pedidos.Dispose()
        dt_cocina_pedidos.Dispose()
        conex.Close()




        datagrid_pedidos.ClearSelection()

    End Sub

    Private Sub Button_cerrar_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub datagrid_pedidos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_pedidos.CellContentClick

    End Sub

    Private Sub datagrid_pedidos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_pedidos.CellClick

        timer_click.Enabled = False


        Dim row As DataGridViewRow = datagrid_pedidos.CurrentRow

        pedido = row.Cells("documento").Value
        mesa = row.Cells("mesa").Value
        mesero = row.Cells("mesero").Value
        hora = Split(row.Cells("cocina").Value, "|")
        observaciones = row.Cells("observaciones").Value

        Label_observaciones.Text = observaciones

        Try
            sql = "SELECT ventas_prods_temp.*, productos.categoria FROM ventas_prods_temp left join productos on productos.cod=ventas_prods_temp.codprod WHERE ventas_prods_temp.documento = " & CInt(row.Cells("documento").Value) & ""

            da_cocina_prods = New MySqlDataAdapter(sql, conex)
            dt_cocina_prods = New DataTable
            da_cocina_prods.Fill(dt_cocina_prods)
            Me.MetroGrid_prods.DataSource = dt_cocina_prods
            Me.MetroGrid_prods.Columns(0).Visible = False
            Me.MetroGrid_prods.Columns(1).Visible = False
            Me.MetroGrid_prods.Columns(2).Visible = False

            Me.MetroGrid_prods.Columns(3).HeaderText = "Producto"
            'Me.MetroGrid_prods.Columns(3).Width = 400
            Me.MetroGrid_prods.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.MetroGrid_prods.Columns(4).HeaderText = "Cantidad"
            Me.MetroGrid_prods.Columns(4).Width = 50
            Me.MetroGrid_prods.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.MetroGrid_prods.Columns(5).Visible = False
            Me.MetroGrid_prods.Columns(6).Visible = False
            Me.MetroGrid_prods.Columns(7).Visible = False

            Me.MetroGrid_prods.Columns(8).Visible = False
            Me.MetroGrid_prods.Columns(9).Visible = False
            Me.MetroGrid_prods.Columns(10).HeaderText = "Valor/U"
            Me.MetroGrid_prods.Columns(10).Width = 80
            Me.MetroGrid_prods.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.MetroGrid_prods.Columns(11).HeaderText = "TOTAL"
            Me.MetroGrid_prods.Columns(11).Width = 90
            Me.MetroGrid_prods.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.MetroGrid_prods.Columns(10).Visible = False
            Me.MetroGrid_prods.Columns(11).Visible = False

            Me.MetroGrid_prods.Columns(12).Visible = False
            Me.MetroGrid_prods.Columns(13).Visible = False
            Me.MetroGrid_prods.Columns(14).Visible = False
            Me.MetroGrid_prods.Columns(15).Visible = False
            Me.MetroGrid_prods.Columns(16).Visible = False
            Me.MetroGrid_prods.Columns(17).Visible = False
            Me.MetroGrid_prods.Columns(18).Visible = False

            Me.MetroGrid_prods.Columns(19).Visible = False
            Me.MetroGrid_prods.Columns(20).Visible = False
            Me.MetroGrid_prods.Columns(21).Visible = False
            Me.MetroGrid_prods.Columns(22).Visible = False
            Me.MetroGrid_prods.Columns(23).Visible = False
            Me.MetroGrid_prods.Columns(24).Visible = False
            Me.MetroGrid_prods.Columns(25).Visible = False
            Me.MetroGrid_prods.Columns(26).Visible = False

            'Me.MetroGrid_prods.Columns(2).Width = 50
            'Me.MetroGrid_prods.Columns(3).Width = 400

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        da_cocina_prods.Dispose()
        dt_cocina_prods.Dispose()
        conex.Close()


        MetroGrid_prods.ClearSelection()

        timer_click_Tick(Nothing, Nothing)

        timer_click.Enabled = True
    End Sub

    Private Sub button_crear_Click(sender As Object, e As EventArgs) Handles button_crear.Click
        Dim RTA As String

        RTA = MsgBox("Desea Confirmar el pedido?.  " & Chr(13) & Chr(13) & "Pedido #  " & pedido & Chr(13) & "Mesa #  " & mesa & Chr(13) & "Mesero: " & mesero, MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If RTA = 6 Then
            Label5.Text = "OK|" & Label5.Text


            sql = "UPDATE ventas_pre SET cocina='" & Label5.Text & "' WHERE DOCUMENTO='" & CLng(pedido) & "'"
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



            datagrid_pedidos.DataSource = Nothing
            MetroGrid_prods.DataSource = Nothing

            Form_cocina_Load(Nothing, Nothing)

        End If
    End Sub

    Private Sub timer_click_Tick(sender As Object, e As EventArgs) Handles timer_click.Tick




        'ini = CDate(hora(1))
        'fin = DateTime.Now
        'sumadias = (DateDiff("s", ini, fin) \ 86400) Mod 365
        'sumahoras = (DateDiff("s", ini, fin) \ 3600) Mod 24
        'sumamins = (DateDiff("s", ini, fin) \ 60) Mod 60
        'sumatiempos = sumahoras
        'Me.Label5.Text = sumahoras & " Horas " & sumamins & " Mins"


    End Sub

    Private Sub Timer_pedidos_Tick(sender As Object, e As EventArgs) Handles Timer_pedidos.Tick
        Try
            sql = "select documento, mesa, mesero, cocina, observaciones from ventas_pre where estado='PENDIENTE' AND COCINA like '%SI%'"
            da_cocina_pedidos = New MySqlDataAdapter(sql, conex)
            dt_cocina_pedidos = New DataTable
            da_cocina_pedidos.Fill(dt_cocina_pedidos)
            Me.datagrid_pedidos.DataSource = dt_cocina_pedidos
            Me.datagrid_pedidos.Columns(3).Visible = False
            Me.datagrid_pedidos.Columns(4).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_cocina_pedidos.Dispose()
        dt_cocina_pedidos.Dispose()
        conex.Close()

        If datagrid_pedidos.RowCount = 0 Then Exit Sub

        If datagrid_pedidos.CurrentRow.Index < datagrid_pedidos.Rows.Count Then


            datagrid_pedidos.Rows(datagrid_pedidos.CurrentRow.Index).Selected = True


            datagrid_pedidos.CurrentCell = datagrid_pedidos.Item(0, datagrid_pedidos.CurrentRow.Index)

        End If

        datagrid_pedidos_CellClick(Nothing, Nothing)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class