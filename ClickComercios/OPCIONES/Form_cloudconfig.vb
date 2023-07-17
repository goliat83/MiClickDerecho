Public Class Form_cloudconfig

    Dim mousex As Integer = 0
    Dim mousey As Integer = 0
    Dim mouseDown1 As Boolean = False

    Private Sub Panel_titlebar_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel_titlebar.MouseDown
        mouseDown1 = True

    End Sub

    Private Sub Panel_titlebar_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel_titlebar.MouseMove
        If mouseDown1 = True Then
            mousex = MousePosition.X - 405
            mousey = MousePosition.Y - 40
            Me.SetDesktopLocation(mousex, mousey)
        End If

    End Sub

    Private Sub Panel_titlebar_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel_titlebar.MouseUp
        mouseDown1 = False

    End Sub


    Private Sub Form_cloudconfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_up.Click
        If Me.ComboBox_DESTINO.Text = "" Or Me.ComboBox_DESTINO.Text = Nothing Then
            Label3.Text = "Seleccione un modulo"

            Exit Sub
        End If

        Panel1.Enabled = False
        Me.Button_up.Visible = False
        Me.Button_down.Visible = False

        Label3.Text = "Actualizando información de la nube ...."

        conex_cloud = New MySqlConnection("data source=" & comex_hst & "; user id=" & comex_usr & "; password='" & comex_psw & "';database=" & comex_db & "; port=3306;Connect Timeout=360")


        Cursor.Current = Cursors.WaitCursor

        Try
            Dim Seleccionados As DataGridViewSelectedRowCollection = datagrid_local.SelectedRows

            For Each item As DataGridViewRow In Seleccionados

                If Me.ComboBox_DESTINO.Text = "Productos" Then sql = "Insert into 
productos(Cod, CodBarras, Nombre, Presentacion, Descripcion, Categoria, Costo, IVA, IVA2, Valor, Valor2, Valor3, Stock, Inventariado, Estado, imagen, Tipo, IvaTipo, IvaTipo2, ImpId1, ImpId2, ImpNom1, ImpNom2, decimales, cocina, INVIMA)
values(" & item.Cells(0).Value.ToString() & ",'" & item.Cells(1).Value.ToString() & "','" & item.Cells(2).Value.ToString() & "','" & item.Cells(3).Value.ToString() & "',
'" & item.Cells(4).Value.ToString() & "','" & item.Cells(5).Value.ToString() & "'," & item.Cells(6).Value.ToString() & "," & item.Cells(7).Value.ToString() & ",
'" & item.Cells(8).Value.ToString() & "','" & item.Cells(9).Value.ToString() & "'," & item.Cells(10).Value.ToString() & "," & item.Cells(11).Value.ToString() & ",
" & item.Cells(12).Value.ToString() & ",'" & item.Cells(13).Value.ToString() & "','" & item.Cells(14).Value.ToString() & "','" & item.Cells(15).Value.ToString() & "',
'" & item.Cells(16).Value.ToString() & "','" & item.Cells(17).Value.ToString() & "','" & item.Cells(18).Value.ToString() & "','" & item.Cells(19).Value.ToString() & "',
'" & item.Cells(20).Value.ToString() & "','" & item.Cells(21).Value.ToString() & "','" & item.Cells(22).Value.ToString() & "','" & item.Cells(23).Value.ToString() & "',
'" & item.Cells(24).Value.ToString() & "','" & item.Cells(25).Value.ToString() & "')"


                da = New MySqlDataAdapter(sql, conex_cloud)
                dt = New DataTable
                da.Fill(dt)

            Next

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        Cursor.Current = Cursors.Default

        Label3.Text = "Se Actualizó la información de " & Me.ComboBox_DESTINO.Text


        Cursor.Current = Cursors.WaitCursor
        load_remote_data()
        Cursor.Current = Cursors.Default


        Me.Button_up.Visible = False
        Me.Button_down.Visible = False
        Exit Sub







        ' no borrar este codigo porque es el que sirve paea generar rips

        Try
            If Me.ComboBox_DESTINO.Text = "Ventas" Then sql = "truncate table ventas;"
            If Me.ComboBox_DESTINO.Text = "Compras" Then sql = "truncate table compras;"
            If Me.ComboBox_DESTINO.Text = "Gastos" Then sql = "truncate table recibos_gastos;"
            If Me.ComboBox_DESTINO.Text = "Egresos" Then sql = "truncate table recibos_egresos;"
            If Me.ComboBox_DESTINO.Text = "Recibos de Caja" Then sql = "truncate table recibos_caja;"
            If Me.ComboBox_DESTINO.Text = "Contabilidad" Then sql = "truncate table cajaspuc;"

            da = New MySqlDataAdapter(sql, conex_cloud)
            dt = New DataTable
            da.Fill(dt)

        Catch ex As Exception
            MsgBox(ex.Message)
            conex.Close()
            da.Dispose()
            dt.Dispose()
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()

        Dim update_string As String = ""

        Try
            update_string = 0
            If Me.ComboBox_DESTINO.Text = "Ventas" Then update_string = "INSERT INTO ventas (documento,doccliente,clientenom,fecha,TOTAL) VALUES "
            If Me.ComboBox_DESTINO.Text = "Compras" Then update_string = "INSERT INTO compras (documento,doccliente,clientenom,fecha,TOTAL) VALUES "
            If Me.ComboBox_DESTINO.Text = "Gastos" Then update_string = "INSERT INTO recibos_gastos (documento,fecha,doccliente,clientenom,concepto,referencia,valor) VALUES "
            If Me.ComboBox_DESTINO.Text = "Egresos" Then update_string = "INSERT INTO recibos_egresos (documento,fecha,docliente,clientenom,concepto,referencia,valor) VALUES "
            If Me.ComboBox_DESTINO.Text = "Recibos de Caja" Then update_string = "INSERT INTO recibos_caja (documento,fecha,doccliente,clientenom,concepto,referencia,valor) VALUES "
            If Me.ComboBox_DESTINO.Text = "Contablidad" Then update_string = "INSERT INTO cajaspuc (CodCuenta, cuenta, Tercero, Fecha, Documento, TipoDoc, Rol, SaldoAnt, debe, haber, Saldo, detalle, Estado, annoactual) VALUES "

            If Me.datagrid_local.RowCount = 0 Then
                MsgBox("No hay Dator para exportar", vbInformation)

                update_string = ""
                datagrid_local.DataSource = Nothing

                Me.Button_up.Visible = True
                Label3.Text = "Seleccione un modulo"
                Panel1.Enabled = True
                Exit Sub
            End If


            For J As Integer = 0 To Me.datagrid_local.RowCount - 1
                update_string = update_string & "("
                Dim concepto As String = ""
                Dim referencia As String = ""
                Dim detalle As String = ""
                Dim cuenta As String = ""

                If Me.ComboBox_DESTINO.Text = "Gastos" Or Me.ComboBox_DESTINO.Text = "Egresos" Or Me.ComboBox_DESTINO.Text = "Recibos de Caja" Then
                    concepto = datagrid_local.Item("concepto", J).Value.ToString.Replace(",", "")
                    referencia = datagrid_local.Item("referencia", J).Value.ToString.Replace(",", "")
                End If

                If Me.ComboBox_DESTINO.Text = "Contabilidad" Then
                    detalle = datagrid_local.Item("detalle", J).Value.ToString.Replace(",", "")
                    cuenta = datagrid_local.Item("cuenta", J).Value.ToString.Replace(",", "")

                End If

                If Me.ComboBox_DESTINO.Text = "Ventas" Then update_string = update_string & "'" & datagrid_local.Item("documento", J).Value & "','" & datagrid_local.Item("fecha", J).Value & "','" & datagrid_local.Item("doccliente", J).Value & "','" & datagrid_local.Item("clientenom", J).Value & "','" & datagrid_local.Item("total", J).Value & "'"
                If Me.ComboBox_DESTINO.Text = "Compras" Then update_string = update_string & "'" & datagrid_local.Item("documento", J).Value & "','" & datagrid_local.Item("fecha", J).Value & "','" & datagrid_local.Item("doccliente", J).Value & "','" & datagrid_local.Item("clientenom", J).Value & "','" & datagrid_local.Item("total", J).Value & "'"
                If Me.ComboBox_DESTINO.Text = "Gastos" Then update_string = update_string & "'" & datagrid_local.Item("documento", J).Value & "','" & datagrid_local.Item("fecha", J).Value & "','" & datagrid_local.Item("doccliente", J).Value & "','" & datagrid_local.Item("clientenom", J).Value & "','" & concepto & "','" & referencia & "','" & datagrid_local.Item("valor", J).Value & "'"
                If Me.ComboBox_DESTINO.Text = "Egresos" Then update_string = update_string & "'" & datagrid_local.Item("documento", J).Value & "','" & datagrid_local.Item("fecha", J).Value & "','" & datagrid_local.Item("doccliente", J).Value & "','" & datagrid_local.Item("clientenom", J).Value & "','" & concepto & "','" & referencia & "','" & datagrid_local.Item("valor", J).Value & "'"
                If Me.ComboBox_DESTINO.Text = "Recibos de Caja" Then update_string = update_string & "'" & datagrid_local.Item("documento", J).Value & "','" & datagrid_local.Item("fecha", J).Value & "','" & datagrid_local.Item("doccliente", J).Value & "','" & datagrid_local.Item("clientenom", J).Value & "','" & concepto & "','" & referencia & "','" & datagrid_local.Item("valor", J).Value & "'"
                If Me.ComboBox_DESTINO.Text = "Contabilidad" Then update_string = update_string & datagrid_local.Item("codcuenta", J).Value & "','" & cuenta & "','" & datagrid_local.Item("tercero", J).Value.ToString & "','" & datagrid_local.Item("fecha", J).Value & "','" & datagrid_local.Item("documento", J).Value & "','" & datagrid_local.Item("tipodoc", J).Value & "','" & datagrid_local.Item("rol", J).Value & "','" & datagrid_local.Item("saldoant", J).Value & "','" & datagrid_local.Item("debe", J).Value & "','" & datagrid_local.Item("haber", J).Value & ",'" & datagrid_local.Item("saldo", J).Value & "','" & detalle & "','" & datagrid_local.Item("estado", J).Value & "','" & datagrid_local.Item("annoacTual", J).Value & "'"

                update_string = update_string & "),"
            Next
            update_string = update_string.Remove(update_string.Length - 1, 1)
            update_string = update_string & ";"


        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        sql = update_string
        da = New MySqlDataAdapter(sql, conex_cloud)
        dt = New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()

        update_string = ""
        datagrid_local.DataSource = Nothing

        Me.Button_up.Visible = True
        Label3.Text = "Seleccione un modulo."
        Panel1.Enabled = True

    End Sub

    Private Sub ComboBox_DESTINO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_DESTINO.SelectedIndexChanged

    End Sub

    Private Sub ComboBox_DESTINO_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_DESTINO.SelectionChangeCommitted
        Label3.Text = "Cargando Información...."
        Timer1.Enabled = True


    End Sub

    Private Sub load_local_data()

        'cargo data local
        Try
            da_data_local = New MySqlDataAdapter(sql, conex)
            dt_data_local = New DataTable
            da_data_local.Fill(dt_data_local)
            Me.datagrid_local.DataSource = dt_data_local
        Catch ex As Exception
            MsgBox(ex.Message)
            conex.Close()
            da_data_local.Dispose()
            dt_data_local.Dispose()
        End Try
        conex.Close()
        da_data_local.Dispose()
        dt_data_local.Dispose()

        If Me.ComboBox_DESTINO.Text = "Productos" Then
            Me.datagrid_local.Columns(3).Visible = False
            Me.datagrid_local.Columns(4).Visible = False
            Me.datagrid_local.Columns(6).Visible = False
            Me.datagrid_local.Columns(7).Visible = False
            Me.datagrid_local.Columns(8).Visible = False
            Me.datagrid_local.Columns(9).Visible = False
            Me.datagrid_local.Columns(10).Visible = False
            Me.datagrid_local.Columns(11).Visible = False
            Me.datagrid_local.Columns(12).Visible = False
            Me.datagrid_local.Columns(13).Visible = False
            Me.datagrid_local.Columns(14).Visible = False
            Me.datagrid_local.Columns(15).Visible = False
            Me.datagrid_local.Columns(16).Visible = False
            Me.datagrid_local.Columns(17).Visible = False
            Me.datagrid_local.Columns(18).Visible = False
            Me.datagrid_local.Columns(19).Visible = False
            Me.datagrid_local.Columns(20).Visible = False
            Me.datagrid_local.Columns(21).Visible = False
            Me.datagrid_local.Columns(22).Visible = False
            Me.datagrid_local.Columns(23).Visible = False
        End If


        If Me.ComboBox_DESTINO.Text = "Compras" Then

        End If
        If Me.ComboBox_DESTINO.Text = "Gastos" Then

        End If
        If Me.ComboBox_DESTINO.Text = "Egresos" Then

        End If
        If Me.ComboBox_DESTINO.Text = "Recibos de Caja" Then

        End If
        If Me.ComboBox_DESTINO.Text = "Contabilidad" Then

        End If
        If Me.ComboBox_DESTINO.Text = "Ventas" Then

        End If
        Me.datagrid_local.ClearSelection()
    End Sub

    Private Sub load_remote_data()
        If Me.ComboBox_DESTINO.Text = "Ventas" Then sql = "SELECT * FROM ventas"
        If Me.ComboBox_DESTINO.Text = "Compras" Then sql = "SELECT * FROM compras"
        If Me.ComboBox_DESTINO.Text = "Gastos" Then sql = "SELECT * FROM recibos_gastos"
        If Me.ComboBox_DESTINO.Text = "Egresos" Then sql = "SELECT * FROM recibos_egresos"
        If Me.ComboBox_DESTINO.Text = "Recibos de Caja" Then sql = "SELECT * FROM recibos_caja"
        If Me.ComboBox_DESTINO.Text = "Contabilidad" Then sql = "SELECT * FROM cajaspuc"
        If Me.ComboBox_DESTINO.Text = "Productos" Then sql = "SELECT * FROM productos"

        'cargo data_cloud
        conex_cloud = New MySqlConnection("data source=" & comex_hst & "; user id=" & comex_usr & "; password='" & comex_psw & "';database=" & comex_db & "; port=3306")

        Try
            da_data_cloud = New MySqlDataAdapter(sql, conex_cloud)
            dt_data_cloud = New DataTable
            da_data_cloud.Fill(dt_data_cloud)
            Me.datagrid_remoto.DataSource = dt_data_cloud
        Catch ex As Exception
            MsgBox(ex.Message)
            conex_cloud.Close()
            da_data_cloud.Dispose()
            dt_data_cloud.Dispose()
        End Try
        conex_cloud.Close()
        da_data_cloud.Dispose()
        dt_data_cloud.Dispose()

        If Me.ComboBox_DESTINO.Text = "Productos" Then

            Me.datagrid_remoto.Columns(3).Visible = False
            Me.datagrid_remoto.Columns(4).Visible = False
            Me.datagrid_remoto.Columns(6).Visible = False
            Me.datagrid_remoto.Columns(7).Visible = False
            Me.datagrid_remoto.Columns(8).Visible = False
            Me.datagrid_remoto.Columns(9).Visible = False
            Me.datagrid_remoto.Columns(10).Visible = False
            Me.datagrid_remoto.Columns(11).Visible = False
            Me.datagrid_remoto.Columns(12).Visible = False
            Me.datagrid_remoto.Columns(13).Visible = False
            Me.datagrid_remoto.Columns(14).Visible = False
            Me.datagrid_remoto.Columns(15).Visible = False
            Me.datagrid_remoto.Columns(16).Visible = False
            Me.datagrid_remoto.Columns(17).Visible = False
            Me.datagrid_remoto.Columns(18).Visible = False
            Me.datagrid_remoto.Columns(19).Visible = False
            Me.datagrid_remoto.Columns(20).Visible = False
            Me.datagrid_remoto.Columns(21).Visible = False
            Me.datagrid_remoto.Columns(22).Visible = False
            Me.datagrid_remoto.Columns(23).Visible = False
        End If


        If Me.ComboBox_DESTINO.Text = "Compras" Then

        End If
        If Me.ComboBox_DESTINO.Text = "Gastos" Then

        End If
        If Me.ComboBox_DESTINO.Text = "Egresos" Then

        End If
        If Me.ComboBox_DESTINO.Text = "Recibos de Caja" Then

        End If
        If Me.ComboBox_DESTINO.Text = "Contabilidad" Then

        End If
        If Me.ComboBox_DESTINO.Text = "Ventas" Then

        End If

        Me.datagrid_remoto.ClearSelection()

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False

        Label3.Text = ComboBox_DESTINO.Text

        If Me.ComboBox_DESTINO.Text = "" Or Me.ComboBox_DESTINO.Text = Nothing Then
            Label3.Text = "Seleccione un modulo"

            Exit Sub
        End If

        If Me.ComboBox_DESTINO.Text = "Estado de Resultados" Then
            calcular_utilidad()
            Exit Sub
        End If


        load_remote_data()


        load_local_data()









    End Sub

    Private Sub calcular_utilidad()
        'Try
        '    sql = "SELECT codcuenta, cuenta, sum(DEBE)-sum(HABER) as saldo FROM cajaspuc WHERE LEFT(CODCUENTA,4)='4135' and month(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & mes_num_text_general & "' GROUP BY CODCUENTA"
        '    da = New MySqlDataAdapter(sql, conex)
        '    dt = New DataTable
        '    da.Fill(dt)
        '    For Each row As DataRow In dt.Rows
        '        Label_utilidad.Text = CInt(row.Item("saldo") * -1)
        '    Next
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'conex.Close()
        'da.Dispose()
        'dt.Dispose()
        'conex.Close()

        'Try
        '    sql = "SELECT codcuenta, cuenta, sum(DEBE)-sum(HABER) as saldo FROM cajaspuc WHERE LEFT(CODCUENTA,4)='4175' and month(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & mes_num_text_general & "' GROUP BY CODCUENTA"
        '    da = New MySqlDataAdapter(sql, conex)
        '    dt = New DataTable
        '    da.Fill(dt)
        '    For Each row As DataRow In dt.Rows
        '        Label_utilidad.Text = CInt(Label_utilidad.Text) - CInt(row.Item("saldo") * -1)
        '    Next
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'conex.Close()
        'da.Dispose()
        'dt.Dispose()
        'conex.Close()


        'Try
        '    sql = "SELECT codcuenta, cuenta, sum(debe)-sum(haber) AS SALDO FROM cajaspuc WHERE LEFT(CODCUENTA,1)='5' and month(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & mes_num_text_general & "' GROUP BY CODCUENTA"
        '    da = New MySqlDataAdapter(sql, conex)
        '    dt = New DataTable
        '    da.Fill(dt)
        '    For Each row As DataRow In dt.Rows

        '        Label_utilidad.Text = CInt(Label_utilidad.Text) - CInt(row.Item("saldo"))
        '    Next
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'conex.Close()
        'da.Dispose()
        'dt.Dispose()
        'conex.Close()

        'Try
        '    sql = "SELECT codcuenta, cuenta, sum(debe)-sum(haber) AS SALDO FROM cajaspuc WHERE LEFT(CODCUENTA,1)='6' and month(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & mes_num_text_general & "' GROUP BY CODCUENTA"
        '    da = New MySqlDataAdapter(sql, conex)
        '    dt = New DataTable
        '    da.Fill(dt)
        '    For Each row As DataRow In dt.Rows
        '        Label_utilidad.Text = CInt(Label_utilidad.Text) - CInt(row.Item("saldo"))
        '        Label_costoVentas.Text = CInt(row.Item("saldo"))
        '    Next
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'conex.Close()
        'da.Dispose()
        'dt.Dispose()
        'conex.Close()

        'Me.Label_utilidad.Text = Format(CDec(Me.Label_utilidad.Text), "##,##0")
        'Me.Label_costoVentas.Text = Format(CDec(Me.Label_costoVentas.Text), "##,##0")
    End Sub

    Private Sub Button_cerrar_Click(sender As Object, e As EventArgs) Handles Button_cerrar.Click
        Me.Close()
    End Sub

    Private Sub Form_cloudconfig_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub
End Class