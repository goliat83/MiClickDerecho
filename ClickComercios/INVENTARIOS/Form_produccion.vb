Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class Form_produccion
    Public da_prods_ins As New MySqlDataAdapter
    Public dt_prods_ins As New DataTable

    Public da_prods_proc As New MySqlDataAdapter
    Public dt_prods_proc As New DataTable

    Public da_recetario_produccion As New MySqlDataAdapter
    Public dt_recetario_produccion As New DataTable

    Public da_prod_detalle As New MySqlDataAdapter
    Public dt_prod_detalle As New DataTable

    Public da_saldo_produccion As New MySqlDataAdapter
    Public dt_saldo_produccion As New DataTable

    Public prod_cons As String
    Public prod_cant As String
    Public prod_cant_usada As String
    Public prod_merma As String
    Public prod_desechos As String
    Public prod_desechos_cod As String

    Public prod_costo As String
    Public prod_saldo As String

    Public orden_det_cons As String

    Public orden_cons As String
    Public orden_fecha As String
    Public orden_inicio As String
    Public orden_iniciohr As String

    Public orden_fin As String
    Public orden_finhr As String

    Public orden_prodcod As String
    Public orden_prod As String
    Public orden_prodcant As String
    Public orden_parametro As String
    Public orden_codparametro As String
    Public orden_estado As String
    Public orden_merma As String
    Public orden_desechos As String





    Private Sub Btn_nuevo_mov_Click(sender As Object, e As EventArgs) Handles Btn_nuevo_mov.Click
        Grid_ordenes_detalle.DataSource = Nothing

        Panel6.Visible = False

        Panel_dock.Visible = False
        DataGrid_ordenes.Visible = False
        Panel_KIT.Visible = True

        Label_estado_movimiento.Text = "NUEVO"

        Panel1.Enabled = False
        Panel5.Enabled = False

        ComboBox_ccosto.SelectedItem = Nothing
        ComboBox_Solicitante.SelectedItem = Nothing
        ComboBox_prod_prod.SelectedItem = Nothing
        ComboBox_recetas.SelectedItem = Nothing

        ComboBox_recetas.Enabled = True

        NumericUpDown_cant.Value = 0
        NumericUpDown_solicitado.Value = 0

        Button_guardar.Enabled = True

        Label_fecha.Text = DateTime.Now.ToShortDateString

        consecutivo = 0
        cmd.Connection = conex
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select max(cons) + 1 from OPRODUCCION"
        conex.Open()
        Try
            dr_consecutivos = cmd.ExecuteReader()
            If dr_consecutivos.Read() Then
                consecutivo = dr_consecutivos(0)
            Else
                consecutivo = 1
            End If
        Catch ex As Exception
            consecutivo = 1
            conex.Close()
        End Try
        conex.Close()
        Label_consecutivo.Text = consecutivo

        Button_ini_produccion.Enabled = False
        Button_fin_produccion.Enabled = False

        Label_fecha.Text = DateTime.Now.ToShortDateString
        Label_estado_movimiento.Text = "NUEVO"


        DateTimePicker_ini_fecha.Value = DateTime.Now
        DateTimePicker_ini_hora.Value = DateTime.Now

    End Sub

    Private Sub Form_produccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGrid_ordenes.BringToFront()

    End Sub

    Private Sub Button_cerrar_Click(sender As Object, e As EventArgs) Handles Button_cerrar.Click
        Me.Close()
    End Sub




    Private Sub loads_insumos()
        Me.Cursor = Cursors.WaitCursor

        'LLENADO DE PRODUCTOS COMBO
        Try
            sql = "SELECT COD, CONCAT(NOMBRE,' ',PRESENTACION) AS NOMBRE FROM productos where tipo='INSUMOS' order by nombre"
            da_prods_ins = New MySqlDataAdapter(sql, conex)
            dt_prods_ins = New DataTable
            da_prods_ins.Fill(dt_prods_ins)
            Me.ComboBox_insumos.DataSource = dt_prods_ins.DefaultView
            Me.ComboBox_insumos.DisplayMember = "nombre"
            Me.ComboBox_insumos.ValueMember = "cod"

            Me.ComboBox_insumos.SelectedItem = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_prods_ins.Dispose()
        dt_prods_ins.Dispose()
        conex.Close()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub loads_procesados()
        Me.Cursor = Cursors.WaitCursor

        'LLENADO DE PRODUCTOS COMBO
        Try
            sql = "SELECT * FROM productos where tipo='PROCESADOS' order by nombre"
            da_prods_ins = New MySqlDataAdapter(sql, conex)
            dt_prods_ins = New DataTable
            da_prods_ins.Fill(dt_prods_ins)
            Me.ComboBox_insumos.DataSource = dt_prods_ins.DefaultView
            Me.ComboBox_insumos.DisplayMember = "nombre"
            Me.ComboBox_insumos.ValueMember = "cod"

            Me.ComboBox_insumos.SelectedItem = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_prods_ins.Dispose()
        dt_prods_ins.Dispose()
        conex.Close()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub loads_productos_produccion()
        Me.Cursor = Cursors.WaitCursor

        'LLENADO DE PRODUCTOS COMBO
        Try
            sql = "SELECT cod, concat(nombre,' ',presentacion) as nombre FROM productos where tipo='PROCESADOS' order by nombre"
            da_prods_proc = New MySqlDataAdapter(sql, conex)
            dt_prods_proc = New DataTable
            da_prods_proc.Fill(dt_prods_proc)
            Me.ComboBox_prod_prod.DataSource = dt_prods_proc.DefaultView
            Me.ComboBox_prod_prod.DisplayMember = "nombre"
            Me.ComboBox_prod_prod.ValueMember = "cod"

            Me.ComboBox_prod_prod.SelectedItem = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_prods_proc.Dispose()
        dt_prods_proc.Dispose()
        conex.Close()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub load_combo_recetas()
        Me.Cursor = Cursors.WaitCursor

        Try
            sql = "SELECT COD, CONCAT(nombre,' ',PRESENTACION) as Producto FROM productos WHERE receta='SI' AND COD='" & ComboBox_prod_prod.SelectedValue.ToString & "' ORDER BY NOMBRE DESC"
            da_recetario_produccion = New MySqlDataAdapter(sql, conex)
            dt_recetario_produccion = New DataTable
            da_recetario_produccion.Fill(dt_recetario_produccion)
            ComboBox_recetas.DataSource = dt_recetario_produccion.DefaultView
            Me.ComboBox_recetas.DisplayMember = "producto"
            Me.ComboBox_recetas.ValueMember = "cod"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_recetario_produccion.Dispose()
        dt_recetario_produccion.Dispose()

        Me.Cursor = Cursors.Default

    End Sub
    Private Sub load_receta_data()
        Me.Cursor = Cursors.WaitCursor
        If ComboBox_recetas.Text = "" Then Exit Sub
        Try
            sql = "SELECT CODprod, CONCAT(producto,'........',cantidad) as Producto, cantidad FROM productos_receta WHERE codreceta='" & ComboBox_recetas.SelectedValue.ToString & "' ORDER BY producto DESC"
            da_prods_ins = New MySqlDataAdapter(sql, conex)
            dt_prods_ins = New DataTable
            da_prods_ins.Fill(dt_prods_ins)
            MetroGrid_detalles_receta.DataSource = dt_prods_ins
            ComboBox_insumos.DataSource = dt_prods_ins.DefaultView
            Me.ComboBox_insumos.DisplayMember = "producto"
            Me.ComboBox_insumos.ValueMember = "codprod"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_prods_ins.Dispose()
        dt_prods_ins.Dispose()
        ComboBox_insumos.SelectedItem = Nothing

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Form_produccion_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        'grid ordenes de produccion
        load_ordenes_prod()



        loads_productos_produccion()

        Panel_dock.BringToFront()

    End Sub
    Private Sub load_ordenes_prod()
        Me.DataGrid_ordenes.Refresh()
        Try
            sql = "SELECT cons, fecha, codprod, producto, cantidad, estado FROM oproduccion;"

            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGrid_ordenes.DataSource = dt
            'Me.DataGrid_ordenes.Columns(0).Visible = False
            'Me.DataGrid_ordenes.Columns(1).HeaderText = "#Doc"
            Me.DataGrid_ordenes.Columns(0).Width = 60
            Me.DataGrid_ordenes.Columns(1).Width = 80
            Me.DataGrid_ordenes.Columns(2).Width = 60
            Me.DataGrid_ordenes.Columns(4).Width = 80
            Me.DataGrid_ordenes.Columns(5).Width = 120

            'Me.DataGrid_ordenes.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        DataGrid_ordenes.ClearSelection()
    End Sub
    Private Sub RadioButton_materiaPrima_kit_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_materiaPrima_kit.CheckedChanged
        ComboBox_insumos.DataSource = Nothing

        If RadioButton_materiaPrima_kit.Checked = True Then
            loads_insumos()

        End If

    End Sub
    Private Sub RadioButton_prod_proc_kit_CheckedChanged(sender As Object, e As EventArgs)
        ComboBox_insumos.DataSource = Nothing




    End Sub
    Private Sub RadioButton_productos_CheckedChanged(sender As Object, e As EventArgs)
        ComboBox_insumos.DataSource = Nothing




    End Sub
    Private Sub Button_agregar_kit_Click(sender As Object, e As EventArgs) Handles Button_ini_produccion.Click
        'iniciar produccion

        ComboBox_ccosto.Enabled = False
        ComboBox_Solicitante.Enabled = False
        ComboBox_prod_prod.Enabled = False
        ComboBox_recetas.Enabled = False

        Panel1.Enabled = True
        Panel5.Enabled = True

        Panel1.Enabled = True

        Button_ini_produccion.Enabled = False
        Button_fin_produccion.Enabled = True

        Dim fecha_ini, hora_ini As String
        Dim fecha_fin, hora_fin As String
        fecha_ini = 0
        hora_ini = 0
        fecha_fin = 0
        hora_fin = 0

        fecha_ini = DateTimePicker_ini_fecha.Value.ToShortDateString
        hora_ini = DateTimePicker_ini_hora.Value.ToShortTimeString

        Dim codparametro As String = "", parametro As String = ""
        If ComboBox_recetas.SelectedValue <> Nothing Then
            codparametro = ComboBox_recetas.SelectedValue
            parametro = ComboBox_recetas.Text.ToString
            RadioButton_recetas_CheckedChanged(Nothing, Nothing)

            ComboBox_recetas.DroppedDown = True

        End If

        sql = "update oproduccion set codparametro='" & codparametro & "', parametro='" & parametro & "', inicio='" & fecha_ini & "', iniciohr='" & hora_ini & "', Estado='EN PROCESO' WHERE CONS='" & Label_consecutivo.Text & "'"

        da = New MySqlDataAdapter(sql, conex)
        dt = New DataTable
        Try
            da.Fill(dt)
            MsgBox("Se Inició la Orden de Producción. ", vbInformation)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()

        DateTimePicker_ini_fecha.Enabled = False
        DateTimePicker_ini_hora.Enabled = False

        DateTimePicker_fin_fecha.Enabled = True
        DateTimePicker_fin_hora.Enabled = True

    End Sub
    Private Sub Button_guardar_Click(sender As Object, e As EventArgs) Handles Button_guardar.Click
        If NumericUpDown_solicitado.Value <= 0 Then
            MsgBox("seleccione la canidad.")

            Exit Sub
        End If
        NumericUpDown_solicitado.Enabled = False
        ComboBox_prod_prod.Enabled = False
        ComboBox_Solicitante.Enabled = False
        ComboBox_ccosto.Enabled = False

        ComboBox_recetas.Enabled = True


        Button_guardar.Visible = False

        Button_ini_produccion.Enabled = True
        Button_fin_produccion.Enabled = False

        Panel1.Enabled = False
        'guardo produccion

        NumericUpDown_merma.Value = CDec(prod_merma) * NumericUpDown_solicitado.Value
        NumericUpDown_desechos.Value = CDec(prod_desechos) * NumericUpDown_solicitado.Value


        consecutivo = 0
        cmd.Connection = conex
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select max(cons) + 1 from OPRODUCCION"
        conex.Open()
        Try
            dr_consecutivos = cmd.ExecuteReader()
            If dr_consecutivos.Read() Then
                consecutivo = dr_consecutivos(0)
            Else
                consecutivo = 1
            End If
        Catch ex As Exception
            consecutivo = 1
            conex.Close()
        End Try
        conex.Close()
        Label_consecutivo.Text = consecutivo



        sql = "INSERT INTO oproduccion(Fecha, codprod, producto, Cantidad, codparametro, parametro, Solicitante, ccosto, Estado, merma, desechos, pesounidad) 
 VALUES('" & CStr(Label_fecha.Text) & "','" & ComboBox_prod_prod.SelectedValue & "','" & ComboBox_prod_prod.Text & "','" & NumericUpDown_solicitado.Value & "','" & ComboBox_recetas.SelectedValue & "','" & ComboBox_recetas.Text & "','" & ComboBox_Solicitante.Text & "','" & ComboBox_ccosto.Text & "','PENDIENTE','" & CDec(prod_merma) * NumericUpDown_solicitado.Value & "','" & CDec(prod_desechos) * NumericUpDown_solicitado.Value & "','" & Label_peso_unidad.Text & "')"

        da = New MySqlDataAdapter(sql, conex)
        dt = New DataTable
        Try
            da.Fill(dt)
            MsgBox("Se Guardó la Orden de Producción. ", vbInformation)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()

        Label_estado_movimiento.Text = "PENDIENTE"

        DateTimePicker_ini_fecha.Value = DateTime.Now
        DateTimePicker_ini_hora.Value = DateTime.Now

        DateTimePicker_ini_fecha.Enabled = True
        DateTimePicker_ini_hora.Enabled = True
        Panel5.Enabled = True
    End Sub
    Private Sub Button_Regresar_Click(sender As Object, e As EventArgs) Handles Button_Regresar.Click





        DataGrid_ordenes.Visible = True
        Label_consecutivo.Text = "0"
        Label_fecha.Text = ""

        Panel6.Visible = True

        ComboBox_prod_prod.Enabled = True
        ComboBox_ccosto.Enabled = True
        NumericUpDown_solicitado.Enabled = True
        ComboBox_Solicitante.Enabled = True

        Panel1.Enabled = False
        Panel5.Enabled = False
        Panel_dock.Visible = True

        Button_guardar.Visible = True

        Button_fin_produccion.Enabled = False
        Button_ini_produccion.Enabled = False

        Label_consecutivo.Text = "0"
        Label_fecha.Text = ""

        prod_cons = ""
        prod_desechos_cod = ""
        prod_merma = ""
        prod_desechos = ""
        orden_cons = ""
        ComboBox_insumos.DataSource = Nothing
        Label_saldo_actual.Text = "0"
        Label_costoactual.Text = ""

        ComboBox_recetas.DataSource = Nothing
        ComboBox_insumos.DataSource = Nothing
        Grid_ordenes_detalle.DataSource = Nothing

        load_ordenes_prod()

    End Sub
    Private Sub Button_agregar_prod_Click(sender As Object, e As EventArgs) Handles Button_agregar_prod.Click
        If ComboBox_insumos.Text = "" Then
            MsgBox("seleccione un insumo")
            Exit Sub
        End If
        If NumericUpDown_cant.Value = "0" Then
            MsgBox("seleccione la cantidad")
            Exit Sub
        End If

        Dim CANT_INS_SOLICITADO As String = FormatNumber(CDec(CDec(prod_cant) * NumericUpDown_solicitado.Value), 3)

        Dim CANT_INS_USADO As String = FormatNumber(CDec(NumericUpDown_cant.Value), 2)


        sql = "INSERT INTO oproducciondetalles(op, codprod, insumo, cantidad, cantusada, costo, etapa, empleado, observacion,fechahora)" &
              "VALUES (" & CInt(Me.Label_consecutivo.Text) & ",'" & CStr(Me.ComboBox_insumos.SelectedValue) & "','" & CStr(PROD_NOMBRE) & "',
              '" & FormatNumber(CDec(CDec(prod_cant) * NumericUpDown_solicitado.Value), 2) & "','" & FormatNumber(CDec(NumericUpDown_cant.Value), 2) & "','" & FormatNumber(CDec(CDec(Me.NumericUpDown_cant.Value) * CDec(prod_costo)), 2) & "','" & ComboBox_etapa.Text & "','" & ComboBox_responsable.Text & "','" & Text_observaciones.Text & "','" & DateTime.Now.ToString & "')"
        da = New MySqlDataAdapter(sql, conex)
        dt = New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            MsgBox("error al agregar el detalle de produccion")
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()

        grid_produccion_detalle()

    End Sub
    Private Sub grid_produccion_detalle()
        Try
            sql = "SELECT * FROM oproducciondetalles where op='" & Label_consecutivo.Text & "';"

            da_prod_detalle = New MySqlDataAdapter(sql, conex)
            dt_prod_detalle = New DataTable
            da_prod_detalle.Fill(dt_prod_detalle)
            Me.Grid_ordenes_detalle.DataSource = dt_prod_detalle
            Grid_ordenes_detalle.Columns(0).Visible = False
            Grid_ordenes_detalle.Columns(1).Visible = False
            Grid_ordenes_detalle.Columns(2).Visible = False

            Grid_ordenes_detalle.Columns(3).HeaderText = "Insumo"
            Grid_ordenes_detalle.Columns(3).Width = 300
            Grid_ordenes_detalle.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            Grid_ordenes_detalle.Columns(4).HeaderText = "Cant Req."

            'Grid_ordenes_detalle.Columns(4).Visible = False

            Grid_ordenes_detalle.Columns(7).Visible = False
            Grid_ordenes_detalle.Columns(8).Visible = False
            Grid_ordenes_detalle.Columns(9).Visible = False


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_prod_detalle.Dispose()
        dt_prod_detalle.Dispose()
        conex.Close()

        Label_costo_produccion.Text = 0
        Label_ins_requeridos.Text = 0
        Label_ins_consumidos.Text = 0

        For Each row3 As DataRow In dt_prod_detalle.Rows
            Label_costo_produccion.Text = CInt(Label_costo_produccion.Text) + CDec(row3.Item("costo"))
            Label_ins_requeridos.Text = CInt(Label_ins_requeridos.Text) + CDec(row3.Item("cantidad"))
            Label_ins_consumidos.Text = CInt(Label_ins_consumidos.Text) + CDec(row3.Item("cantusada"))
        Next


        Label_costo_produccion.Text = CInt(Label_costo_produccion.Text)

        TextBox_costo_total.Text = CInt(Label_costo_produccion.Text) + CInt(TextBox_otros_costos.Text)


        Grid_ordenes_detalle.ClearSelection()
    End Sub
    Private Sub button_Quitar_Prod_Click(sender As Object, e As EventArgs) Handles button_Quitar_Prod.Click
        sql = "delete from oproducciondetalles where cons=" & orden_det_cons & ""
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
        orden_det_cons = ""
        grid_produccion_detalle()
    End Sub

    Private Sub Button_agrega_todo_Click(sender As Object, e As EventArgs) Handles Button_agrega_todo.Click
        If RadioButton_recetas.Checked = False Then
            MsgBox("No seleccionó una receta.")
            Exit Sub
        End If

        Try
            For J As Integer = 0 To Me.MetroGrid_detalles_receta.RowCount - 1
                Try
                    sql = "SELECT productos.nombre as nombre, productos_receta.cantidad as cantidad, productos.costo as costo from productos_receta 
        left join productos on productos.cod=productos_receta.codprod
        WHERE productos.cod ='" & CStr(MetroGrid_detalles_receta.Item("codprod", J).Value) & "' and productos_receta.codprod='" & CStr(MetroGrid_detalles_receta.Item("codprod", J).Value) & "'"
                    da = New MySqlDataAdapter(sql, conex)
                    dt = New DataTable
                    da.Fill(dt)
                    NumericUpDown_cant.Value = 0
                    For Each row As DataRow In dt.Rows
                        NumericUpDown_cant.Value = CDec(row.Item("cantidad"))
                        prod_cant = CStr(row.Item("cantidad"))
                        prod_costo = CStr(row.Item("costo"))
                        PROD_NOMBRE = CStr(row.Item("nombre"))
                    Next

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                conex.Close()
                da.Dispose()
                dt.Dispose()

                'op, codprod, insumo, cantidad, cantusada, costo, etapa, empleado, observacion,fechahora

                sql = "INSERT INTO oproducciondetalles(op, codprod, insumo, cantidad, cantusada, costo, etapa, empleado, observacion,fechahora)" &
                             "VALUES (" & CStr(Label_consecutivo.Text) & ",'" & CStr(MetroGrid_detalles_receta.Item("codprod", J).Value) & "','" & PROD_NOMBRE & "','" & CInt(CDec(MetroGrid_detalles_receta.Item("cantidad", J).Value) * CDec(NumericUpDown_solicitado.Value)) & "','" & CInt(CDec(MetroGrid_detalles_receta.Item("cantidad", J).Value) * CDec(NumericUpDown_solicitado.Value)) & "','" & CInt(CDec(MetroGrid_detalles_receta.Item("cantidad", J).Value * CDec(NumericUpDown_solicitado.Value)) * CDec(prod_costo)) & "','','" & usrnom & "','" & Text_observaciones.Text & "','" & DateTime.Now.ToString & "')"
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
            Next
        Catch ex As Exception

        End Try
        grid_produccion_detalle()

    End Sub

    Private Sub DataGrid_ordenes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid_ordenes.CellContentClick

    End Sub

    Private Sub DataGrid_ordenes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid_ordenes.CellClick
        Dim row_mov As DataGridViewRow = DataGrid_ordenes.CurrentRow
        Try
            orden_cons = CLng(row_mov.Cells("cons").Value) ' LLAVE PRINCIPAL

        Catch ex As Exception

        End Try



    End Sub

    Private Sub ComboBox_prod_prod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_prod_prod.SelectedIndexChanged

    End Sub

    Private Sub ComboBox_prod_prod_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_prod_prod.SelectionChangeCommitted
        Try
            sql = "SELECT productos.merma as merma, productos.desechos as desechos, coddesecho from productos 
WHERE cod='" & ComboBox_prod_prod.SelectedValue.ToString & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            NumericUpDown_cant.Value = 0
            For Each row As DataRow In dt.Rows
                prod_merma = CStr(row.Item("merma"))
                prod_desechos = CStr(row.Item("desechos"))
                prod_desechos_cod = CStr(row.Item("coddesecho"))

            Next

            NumericUpDown_cant.Value = CDec(prod_cant) * NumericUpDown_solicitado.Value

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()


        load_combo_recetas()

        ComboBox_recetas.SelectedItem = Nothing

    End Sub

    Private Sub RadioButton_recetas_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_recetas.CheckedChanged
        If ComboBox_recetas.Text.ToString = Nothing Then
            Exit Sub
        End If

        If RadioButton_recetas.Checked = True Then
            load_receta_data()

        End If
    End Sub

    Private Sub ComboBox_insumos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_insumos.SelectedIndexChanged

    End Sub

    Private Sub ComboBox_insumos_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_insumos.SelectionChangeCommitted

        'si arega desde receta
        If RadioButton_recetas.Checked = True Then

            Try
                sql = "SELECT productos.nombre as nombre, productos_receta.cantidad as cantidad, productos.costo as costo, productos.merma as merma, productos.desechos as desechos from productos_receta 
left join productos on productos.cod=productos_receta.codprod
WHERE codprod ='" & ComboBox_insumos.SelectedValue.ToString & "' and codreceta='" & ComboBox_recetas.SelectedValue.ToString & "'"
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                da.Fill(dt)
                NumericUpDown_cant.Value = 0
                For Each row As DataRow In dt.Rows
                    prod_cant = CStr(row.Item("cantidad"))
                    prod_costo = CStr(row.Item("costo"))
                    PROD_NOMBRE = CStr(row.Item("nombre"))
                Next

                NumericUpDown_cant.Value = CDec(prod_cant) * NumericUpDown_solicitado.Value

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da.Dispose()
            dt.Dispose()
        End If



        'si agrega desde insumos
        If RadioButton_materiaPrima_kit.Checked = True And ComboBox_insumos.SelectedItem.ToString <> Nothing Then
            NumericUpDown_cant.Value = 0
            prod_cant = 0
            Try
                sql = "SELECT nombre as nombre, costo as costo from PRODUCTOS 
WHERE cod ='" & ComboBox_insumos.SelectedValue.ToString & "'"
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                da.Fill(dt)
                NumericUpDown_cant.Value = 0
                For Each row As DataRow In dt.Rows
                    prod_costo = CStr(row.Item("costo"))
                    PROD_NOMBRE = CStr(row.Item("nombre"))
                Next

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da.Dispose()
            dt.Dispose()
        End If




        Try
            sql = "SELECT sum(entran) - sum(salen) as saldo FROM bodega_principal where CodProducto=" & ComboBox_insumos.SelectedValue.ToString & ""
            sql = "select sum(CAST(CONVERT(REPLACE(CAST(entran AS CHAR),',','.'),decimal(12,3)) AS DECIMAL(12,3)))-sum(CAST(CONVERT(REPLACE(CAST(SALEN AS CHAR),',','.'),decimal(12,3)) AS DECIMAL(12,3))) as saldo FROM bodega_principal where CodProducto=" & ComboBox_insumos.SelectedValue.ToString & ""

            da_saldo_produccion = New MySqlDataAdapter(sql, conex)
            dt_saldo_produccion = New DataTable
            da_saldo_produccion.Fill(dt_saldo_produccion)
            For Each row As DataRow In dt_saldo_produccion.Rows
                prod_saldo = row.Item("saldo")
            Next
        Catch ex As Exception
            prod_saldo = 0
        End Try
        da_saldo_produccion.Dispose()
        dt_saldo_produccion.Dispose()
        conex.Close()




        Label_costoactual.Text = prod_costo

        Label_saldo_actual.Text = prod_saldo

    End Sub

    Private Sub Btn_Ver_editar_Click(sender As Object, e As EventArgs) Handles Btn_Ver_editar.Click
        Grid_ordenes_detalle.DataSource = Nothing

        Panel6.Visible = False



        If orden_cons = "" Then
            MsgBox("Seleccione una orden.", vbInformation)
            Exit Sub
        End If

        Button_guardar.Enabled = False

        Panel_dock.Visible = False
        DataGrid_ordenes.Visible = False
        Panel_KIT.Visible = True

        Label_consecutivo.Text = orden_cons
        Try
            sql = "select * from oproduccion where cons='" & orden_cons & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            NumericUpDown_cant.Value = 0
            For Each row As DataRow In dt.Rows

                orden_fecha = CStr(row.Item("fecha"))
                orden_inicio = CStr(row.Item("inicio"))
                orden_iniciohr = CStr(row.Item("iniciohr"))
                orden_fin = CStr(row.Item("fin"))
                orden_finhr = CStr(row.Item("finhr"))
                orden_prodcod = CStr(row.Item("codprod"))
                orden_prod = CStr(row.Item("producto"))
                orden_prodcant = CStr(row.Item("cantidad"))

                orden_codparametro = CStr(row.Item("codparametro"))
                orden_parametro = CStr(row.Item("parametro"))
                orden_estado = CStr(row.Item("estado"))
                orden_merma = CStr(row.Item("merma"))
                orden_desechos = CStr(row.Item("desechos"))
                Label_peso_unidad.Text = CStr(row.Item("pesounidad"))


                If orden_estado = "PROCESADO" Then
                    NumericUpDown_cant_final.Value = CStr(row.Item("cantfinal"))
                    TextBox_otros_costos.Text = CStr(row.Item("otroscostos"))
                    'TextBox_costo_unitario.Text = CStr(row.Item("costounitario"))
                    Panel1.Enabled = False
                End If

            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()

        Me.Cursor = Cursors.WaitCursor
        'cargo las recetas
        Try
            sql = "SELECT COD, CONCAT(nombre,' ',PRESENTACION) as Producto FROM productos WHERE receta='SI' AND COD='" & orden_prodcod & "' ORDER BY NOMBRE DESC"
            da_recetario_produccion = New MySqlDataAdapter(sql, conex)
            dt_recetario_produccion = New DataTable
            da_recetario_produccion.Fill(dt_recetario_produccion)
            ComboBox_recetas.DataSource = dt_recetario_produccion.DefaultView
            Me.ComboBox_recetas.DisplayMember = "producto"
            Me.ComboBox_recetas.ValueMember = "cod"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_recetario_produccion.Dispose()
        dt_recetario_produccion.Dispose()

        Me.Cursor = Cursors.Default

        ComboBox_recetas.SelectedItem = Nothing

        If orden_codparametro = "" Then orden_codparametro = 0
        If orden_codparametro <> 0 Then
            ComboBox_recetas.SelectedValue = orden_codparametro

            RadioButton_recetas.Checked = True
        End If


        Label_fecha.Text = orden_fecha
        Label_estado_movimiento.Text = orden_estado
        ComboBox_prod_prod.SelectedValue = orden_prodcod

        NumericUpDown_merma.Value = orden_merma
        NumericUpDown_desechos.Value = orden_desechos

        'If orden_iniciohr.Contains("a.m.") Then orden_iniciohr = orden_iniciohr.Replace("a.m.", "a. m.")
        'If orden_iniciohr.Contains("p.m.") Then orden_iniciohr = orden_iniciohr.Replace("p.m.", "p. m.")

        'If orden_inicio <> "" Then DateTimePicker_ini_fecha.Value = CDate(orden_inicio)
        'If orden_iniciohr <> "" Then DateTimePicker_ini_hora.Value = CDate(orden_inicio & " " & orden_iniciohr)





        NumericUpDown_solicitado.Value = orden_prodcant
        If orden_estado = "PENDIENTE" Then
            Button_anular.Visible = True
            Button_ini_produccion.Enabled = True
            Button_fin_produccion.Enabled = False
            DateTimePicker_ini_fecha.Enabled = True
            DateTimePicker_ini_hora.Enabled = True
            DateTimePicker_fin_fecha.Enabled = False
            DateTimePicker_fin_hora.Enabled = False
            ComboBox_recetas.Enabled = True
            Panel1.Enabled = False
            ComboBox_prod_prod.Enabled = False
            NumericUpDown_solicitado.Enabled = False

        End If
        If orden_estado = "EN PROCESO" Then
            Button_anular.Visible = True
            Button_ini_produccion.Enabled = False
            Button_fin_produccion.Enabled = True
            ComboBox_prod_prod.Enabled = False
            DateTimePicker_ini_fecha.Enabled = False
            DateTimePicker_ini_hora.Enabled = False
            DateTimePicker_fin_fecha.Enabled = True
            DateTimePicker_fin_hora.Enabled = True
            Panel1.Enabled = True
            NumericUpDown_solicitado.Enabled = False
            ComboBox_recetas.Enabled = False
        End If

        If orden_estado = "PROCESADO" Then
            Button_anular.Visible = True
            Button_ini_produccion.Enabled = False
            Button_fin_produccion.Enabled = False
            ComboBox_prod_prod.Enabled = False
            DateTimePicker_ini_fecha.Enabled = False
            DateTimePicker_ini_hora.Enabled = False
            DateTimePicker_fin_fecha.Enabled = False
            DateTimePicker_fin_hora.Enabled = False
            Panel1.Enabled = False
            NumericUpDown_solicitado.Enabled = False
            ComboBox_recetas.Enabled = False
        End If


        grid_produccion_detalle()
    End Sub

    Private Sub ComboBox_recetas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_recetas.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Grid_ordenes_detalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid_ordenes_detalle.CellContentClick

    End Sub

    Private Sub Grid_ordenes_detalle_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid_ordenes_detalle.CellClick
        Dim row_det As DataGridViewRow = Grid_ordenes_detalle.CurrentRow
        orden_det_cons = CLng(row_det.Cells("cons").Value) ' LLAVE PRINCIPAL
    End Sub

    Private Sub Button_fin_produccion_Click(sender As Object, e As EventArgs) Handles Button_fin_produccion.Click
        If NumericUpDown_cant_final.Value = 0 Then
            MsgBox("Seleccione la cantidad final producida.")
            Exit Sub
        End If


        Dim saldo, prod_entran, prod_salen As String

        ' RETIRO LOS INSUMOS
        Try
            For J As Integer = 0 To Me.Grid_ordenes_detalle.RowCount - 1
                'saldo                 (solo se descargan de inventario los productos)  
                saldo = "0"

                prod_salen = Me.Grid_ordenes_detalle.Item("cantusada", J).Value  ' TOMO LA CANTIDAD DEL GRID Q ESTA RECORRIENDO
                prod_saldo = saldo  ' IGUALDO SALDO PROD CON EL SALDO CALCULADO EN BODEGA PRICIPAL
                prod_saldo = CDec(prod_saldo) - CDec(prod_salen)
                prod_entran = 0 ' POR QUE QUE ES UNA COMPRA

                Try
                    sql = "INSERT INTO bodega_" & comex_bodega_produccion & " (fecha, CodBodega, NomBodega, TipoDocumento, Documento, tercero, Rol, CodProducto, Producto, saldoant, Entran, Salen, Saldo, valoru, valortotal, Empleado, Estado, DECI, COSTO)" &
                            "VALUES ('" & DateTime.Now.ToShortDateString & "',1,'PRINCIPAL','ORDEN DE PRODUCCION'," & CInt(Me.Label_consecutivo.Text) & ",'" & comex_nombrecomercial & "','SALEN'," & CInt(Me.Grid_ordenes_detalle.Item("CODPROD", J).Value) & ",'" & CStr(Me.Grid_ordenes_detalle.Item("INSUMO", J).Value) & "','" & saldo & "','0','" & prod_salen & "','" & prod_saldo & "','" & CInt(Me.Grid_ordenes_detalle.Item("COSTO", J).Value) / prod_salen & "','" & (Me.Grid_ordenes_detalle.Item("COSTO", J).Value) & "','" & usrnom & "','DESCARGADO','SI','" & prod_costo & "')"
                    da = New MySqlDataAdapter(sql, conex)
                    dt = New DataTable
                    da.Fill(dt)

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                conex.Close()
                da.Dispose()
                dt.Dispose()
            Next

            prod_salen = 0
            prod_entran = 0
            prod_saldo = 0


        Catch ex As Exception

        End Try




        'INGRESO EL PROD PROCESADO

        prod_entran = NumericUpDown_cant_final.Value  ' TOMO LA CANTIDAD DEL GRID Q ESTA RECORRIENDO
        prod_saldo = 0  ' IGUALDO SALDO PROD CON EL SALDO CALCULADO EN BODEGA PRICIPAL
        prod_saldo = CDec(prod_saldo) + CDec(prod_entran)
        prod_salen = 0 ' POR QUE QUE ES UNA COMPRA


        Try
            sql = "INSERT INTO bodega_" & comex_bodega_produccion & " (fecha, CodBodega, NomBodega, TipoDocumento, Documento, tercero, Rol, CodProducto, Producto, saldoant, Entran, Salen, Saldo, valoru, valortotal, Empleado, Estado, DECI, COSTO)" &
                    "VALUES ('" & DateTime.Now.ToShortDateString & "',1,'PRINCIPAL','ORDEN DE PRODUCCION'," & CInt(Me.Label_consecutivo.Text) & ",'" & comex_nombrecomercial & "','ENTRAN'," & ComboBox_prod_prod.SelectedValue.ToString & ",'" & ComboBox_prod_prod.Text & "','" & saldo & "','" & prod_entran & "','0','" & prod_saldo & "','" & CInt(TextBox_costo_unitario.Text) & "','" & (CLng(TextBox_costo_total.Text)) & "','" & usrnom & "','DESCARGADO','SI','" & prod_costo & "')"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()


        'si hay desecho lo agrego a bodega
        If CheckBox1.Checked = True Then
            Dim desechados() As String = Split(Label11.Text, "|")

            Try
                saldo = 0
                sql = "SELECT sum(CAST(CONVERT(REPLACE(CAST(entran AS CHAR),',','.'),decimal(12,3)) AS DECIMAL(12,3)))-sum(CAST(CONVERT(REPLACE(CAST(SALEN AS CHAR),',','.'),decimal(12,3)) AS DECIMAL(12,2))) AS SALDO FROM bodega_principal where CodProdUCTO =" & desechados(0) & ""
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                da.Fill(dt)
                For Each row As DataRow In dt.Rows
                    saldo = row.Item("SALDO")
                Next
            Catch ex As Exception
                saldo = 0
            End Try
            conex.Close()
            da.Dispose()
            dt.Dispose()

            prod_entran = NumericUpDown_cant_final.Value  ' TOMO LA CANTIDAD DEL GRID Q ESTA RECORRIENDO
            prod_saldo = saldo  ' IGUALDO SALDO PROD CON EL SALDO CALCULADO EN BODEGA PRICIPAL
            prod_saldo = CDec(prod_saldo) + CDec(prod_entran)
            prod_salen = 0 ' POR QUE QUE ES UNA COMPRA


            Try
                sql = "INSERT INTO bodega_" & comex_bodega_produccion & " (fecha, CodBodega, NomBodega, TipoDocumento, Documento, tercero, Rol, CodProducto, Producto, saldoant, Entran, Salen, Saldo, valoru, valortotal, Empleado, Estado, DECI, COSTO)" &
                        "VALUES ('" & DateTime.Now.ToShortDateString & "',1,'PRINCIPAL','ORDEN DE PRODUCCION'," & CInt(Me.Label_consecutivo.Text) & ",'" & comex_nombrecomercial & "','ENTRAN'," & desechados(0) & ",'" & desechados(1) & "','" & saldo & "','" & prod_entran & "','0','" & prod_saldo & "','0','0','" & usrnom & "','DESCARGADO','SI','0')"
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                da.Fill(dt)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da.Dispose()
            dt.Dispose()
        End If


        ''ACTUALIZO DATOS DE ORDEN DE PRODUCCION

        Panel1.Enabled = False
        Panel5.Enabled = False
        Panel1.Enabled = False
        Button_fin_produccion.Enabled = False

        Dim fecha_fin, hora_fin As String

        fecha_fin = 0
        hora_fin = 0

        fecha_fin = DateTimePicker_fin_fecha.Value.ToShortDateString
        hora_fin = DateTimePicker_fin_hora.Value.ToShortTimeString

        sql = "update oproduccion set cantfinal='" & NumericUpDown_cant_final.Value & "', observacion='" & Text_observaciones.Text & "', fin='" & fecha_fin & "', finhr='" & hora_fin & "', Estado='PROCESADO', costo='" & Label_costo_produccion.Text & "',otroscostos='" & TextBox_otros_costos.Text & "',costototal='" & TextBox_costo_total.Text & "',merma='" & NumericUpDown_merma.Value & "', desechos='" & NumericUpDown_desechos.Value & "', pesounidad='" & Label_peso_unidad.Text & "' WHERE CONS='" & Label_consecutivo.Text & "'"

        da = New MySqlDataAdapter(sql, conex)
        dt = New DataTable
        Try
            da.Fill(dt)
            MsgBox("Se Finalizó la Orden de Producción. ", vbInformation)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()

        'ACTUALIZO EL COSTO DEL PRODUCTO
        sql = "update PRODUCTOS set costo='" & TextBox_costo_unitario.Text & "' WHERE COd='" & ComboBox_prod_prod.SelectedValue.ToString & "'"
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


        DateTimePicker_ini_fecha.Enabled = False
        DateTimePicker_ini_hora.Enabled = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Try


            'Intentar generar el documento.
            Dim doc As New Document(PageSize.A4, 20, 20, 20, 20)


            'Path que guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\Produccion " & Label_consecutivo.Text & ".pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)



            PdfWriter.GetInstance(doc, file)
            doc.Open()
            ExportarDatosPDF_POS(doc)
            doc.Close()
            Process.Start(filename)
        Catch ex As Exception
            'Si el intento es fallido, mostrar MsgBox.
            MessageBox.Show("No se puede generar el documento PDF, Cierre los documentos PDF generados anteriormente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub ExportarDatosPDF_POS(ByVal document As Document)
        Dim CANT_FILAS As Integer = 0
        'Se crea un objeto PDFTable con el numero de columnas del DataGridView.

        Dim datatableIMP As New PdfPTable(Grid_ordenes_detalle.ColumnCount)



        'Se asignan algunas propiedades para el diseño del PDF.
        datatableIMP.DefaultCell.Padding = 3
        Dim headerwidthsimp As Single() = GetColumnasSize(Grid_ordenes_detalle)

        datatableIMP.SetWidths(headerwidthsimp)
        datatableIMP.WidthPercentage = 100
        datatableIMP.DefaultCell.BorderWidth = 0
        datatableIMP.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER



        Dim fontLINE = iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLD)

        Dim encabezadoFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 10, iTextSharp.text.Font.BOLD)
        Dim contentFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 10, iTextSharp.text.Font.BOLD)
        Dim DIRFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 6, iTextSharp.text.Font.BOLD)
        Dim rowFont = iTextSharp.text.FontFactory.GetFont("Times New Roman", 7, iTextSharp.text.Font.NORMAL)
        Dim DIRFont2 = iTextSharp.text.FontFactory.GetFont("Arial Black", 7.5, iTextSharp.text.Font.BOLD)
        Dim DIRFont9 = iTextSharp.text.FontFactory.GetFont("Arial Black", 9.5D, iTextSharp.text.Font.NORMAL)

        Dim FIRMAFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 5, iTextSharp.text.Font.BOLD)
        Dim totalFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 8, iTextSharp.text.Font.BOLD)
        Dim totaltotalFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 9, iTextSharp.text.Font.BOLDITALIC)
        Dim CLIENTEFONT = iTextSharp.text.FontFactory.GetFont("Arial Black", 7, iTextSharp.text.Font.BOLDITALIC)

        'Se crea el encabezado en el PDF.

        Dim encabezadoLINE As New Paragraph("======================================================================================================================", fontLINE)

        encabezadoLINE.Alignment = 0
        encabezadoLINE.Font = fontLINE

        Dim encabezadoLINE2 As New Paragraph("======================================================================================================================", fontLINE)
        Dim encabezadoLINE3 As New Paragraph("____________________________________________________________________________________________________________________________", fontLINE)

        encabezadoLINE2.Alignment = 0
        encabezadoLINE2.Font = fontLINE

        Dim tablahome As New PdfPTable(1)
        tablahome.WidthPercentage = 100
        tablahome.DefaultCell.Padding = 0
        tablahome.DefaultCell.BorderWidth = 0
        tablahome.SpacingBefore = 0
        tablahome.HorizontalAlignment = 0

        Dim cellhome As New PdfPCell
        cellhome.BorderWidth = 0


        cellhome.Phrase = New Phrase(comex_nombrecomercial, FontFactory.GetFont(FontFactory.COURIER_BOLD, 10, iTextSharp.text.Font.NORMAL))
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase(comex_nombrepropietario, FontFactory.GetFont(FontFactory.COURIER_BOLD, 8, iTextSharp.text.Font.NORMAL))
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase("NIT:" & comex_nit & "-" & comex_DV & " " & comex_regimen, FontFactory.GetFont(FontFactory.COURIER_BOLD, 8, iTextSharp.text.Font.NORMAL))
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase("Tels:" & comex_tels & " - " & comex_cels & " " & comex_dircomercio & " " & comex_ciudad, FontFactory.GetFont(FontFactory.COURIER_BOLD, 8, iTextSharp.text.Font.NORMAL))
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()


        Dim encabezado As New Paragraph("ORDEN DE PRODUCCION " + Label_consecutivo.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 10, iTextSharp.text.Font.NORMAL))
        encabezado.Alignment = Element.ALIGN_LEFT

        Dim encabezadotipo As New Paragraph(Label_fecha.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 10, iTextSharp.text.Font.NORMAL))
        encabezadotipo.Alignment = Element.ALIGN_LEFT



        Dim tabla_turno_data As New PdfPTable(2)
        tabla_turno_data.WidthPercentage = 100
        tabla_turno_data.DefaultCell.Padding = 0
        tabla_turno_data.DefaultCell.BorderWidth = 0
        tabla_turno_data.SpacingBefore = 0
        tabla_turno_data.HorizontalAlignment = 0
        Dim cellturno As New PdfPCell
        cellturno.BorderWidth = 0



        cellturno.Phrase = New Phrase("Producto:" + ComboBox_prod_prod.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_LEFT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase("Cant. Solicitada:" + NumericUpDown_solicitado.Value.ToString, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_LEFT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("Receta:" + ComboBox_recetas.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_LEFT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase("Estado:" + Label_estado_movimiento.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_LEFT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("Insumo Requerido:" + Label_ins_requeridos.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_LEFT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase("Insumo Consumido:" + Label_ins_consumidos.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_LEFT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("Inicio Producción:" & DateTimePicker_ini_fecha.Value.ToShortDateString & " " & DateTimePicker_ini_hora.Value.ToShortTimeString, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_LEFT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase("Fin Producción:" & DateTimePicker_fin_fecha.Value.ToShortDateString & " " & DateTimePicker_fin_hora.Value.ToShortTimeString, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_LEFT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea



        cellturno.Phrase = New Phrase("CANTIDAD PRODUCCION FINAL: " + NumericUpDown_cant_final.Value.ToString, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_LEFT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase("Costo Total: $" + TextBox_costo_total.Text & "  Costo Unitario: " & TextBox_costo_unitario.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_LEFT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("=====================================", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_LEFT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase("=====================================", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_LEFT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("Cant. Merma: " & NumericUpDown_merma.Value, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_LEFT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase("Cant. Desechos: " & NumericUpDown_desechos.Value, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_LEFT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("Desechos Producido:", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_LEFT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Label11.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_LEFT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("Peso/Unidad:", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_LEFT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Label_peso_unidad.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_LEFT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea





        Dim encabezado8 As New Paragraph("Detalle de Producción", iTextSharp.text.FontFactory.GetFont("Arial Black", 9, iTextSharp.text.Font.BOLD)) : encabezado8.Alignment = Element.ALIGN_CENTER

        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To Grid_ordenes_detalle.ColumnCount - 1
            Dim HEADERCELLFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 5, iTextSharp.text.Font.BOLD)

            Dim cell_TITLE As New PdfPCell
            cell_TITLE.Phrase = New Phrase(Grid_ordenes_detalle.Columns(i).HeaderText, FontFactory.GetFont(FontFactory.COURIER_BOLD, 7.5D, iTextSharp.text.Font.BOLD))
            cell_TITLE.HorizontalAlignment = Element.ALIGN_CENTER
            cell_TITLE.BackgroundColor = BaseColor.LIGHT_GRAY
            cell_TITLE.Border = 0

            datatableIMP.AddCell(cell_TITLE)
        Next
        datatableIMP.HeaderRows = 1
        datatableIMP.DefaultCell.BorderWidth = 0
        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To Grid_ordenes_detalle.RowCount - 1
            For j As Integer = 0 To Grid_ordenes_detalle.ColumnCount - 1
                Dim cell As New PdfPCell
                cell.Phrase = New Phrase(Grid_ordenes_detalle(j, i).FormattedValue.ToString, FontFactory.GetFont(FontFactory.COURIER, 7D, iTextSharp.text.Font.BOLD))
                If j = 0 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 1 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 2 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 3 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 4 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 5 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 6 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 7 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                cell.Border = 0
                cell.BorderWidthRight = 0.0F
                cell.BorderColorRight = BaseColor.BLACK
                datatableIMP.AddCell(cell)
            Next
            datatableIMP.CompleteRow()
        Next

        Dim encabezado_obs As New Paragraph("Observaciones: " + Text_observaciones.Text, iTextSharp.text.FontFactory.GetFont("Arial Black", 9, iTextSharp.text.Font.BOLD)) : encabezado8.Alignment = Element.ALIGN_CENTER


        Dim tablafirma As New PdfPTable(3)
        tablafirma.WidthPercentage = 100
        tablafirma.DefaultCell.Padding = 0
        tablafirma.DefaultCell.BorderWidth = 0
        tablafirma.SpacingBefore = 0
        tablafirma.HorizontalAlignment = 0

        Dim cellfirma As New PdfPCell
        cellfirma.BorderWidth = 0

        cellfirma.Phrase = New Phrase("______________________________", FontFactory.GetFont(FontFactory.COURIER_BOLD, 8, iTextSharp.text.Font.NORMAL))
        cellfirma.HorizontalAlignment = Element.ALIGN_CENTER
        tablafirma.AddCell(cellfirma) 'primera col

        cellfirma.Phrase = New Phrase("______________________________", FontFactory.GetFont(FontFactory.COURIER_BOLD, 8, iTextSharp.text.Font.NORMAL))
        cellfirma.HorizontalAlignment = Element.ALIGN_CENTER
        tablafirma.AddCell(cellfirma) 'primera col

        cellfirma.Phrase = New Phrase("______________________________", FontFactory.GetFont(FontFactory.COURIER_BOLD, 8, iTextSharp.text.Font.NORMAL))
        cellfirma.HorizontalAlignment = Element.ALIGN_CENTER
        tablafirma.AddCell(cellfirma) ' segunda col
        tablafirma.CompleteRow() ' agrega linea

        cellfirma.Phrase = New Phrase("Elaboró", FontFactory.GetFont(FontFactory.COURIER_BOLD, 8, iTextSharp.text.Font.NORMAL))
        cellfirma.HorizontalAlignment = Element.ALIGN_CENTER
        tablafirma.AddCell(cellfirma) 'primera col

        cellfirma.Phrase = New Phrase("Revisó", FontFactory.GetFont(FontFactory.COURIER_BOLD, 8, iTextSharp.text.Font.NORMAL))
        cellfirma.HorizontalAlignment = Element.ALIGN_CENTER
        tablafirma.AddCell(cellfirma) 'primera col

        cellfirma.Phrase = New Phrase("Autorizó", FontFactory.GetFont(FontFactory.COURIER_BOLD, 8, iTextSharp.text.Font.NORMAL))
        cellfirma.HorizontalAlignment = Element.ALIGN_CENTER
        tablafirma.AddCell(cellfirma) ' segunda col
        tablafirma.CompleteRow() ' agrega linea


        Dim encabezado7 As New Paragraph("Se Imprimió el " + DateTime.Now + Chr(13) + "Por: " + usrnom, DIRFont) : encabezado7.Alignment = 0


        'LOGO
        If comex_logo <> "" Then
            Dim imagelogogopdf As iTextSharp.text.Image 'Declaracion de una imagen

            imagelogogopdf = iTextSharp.text.Image.GetInstance(comex_logo) 'Dirreccion a la imagen que se hace referencia
            imagelogogopdf.Alignment = Element.ALIGN_RIGHT
            imagelogogopdf.SetAbsolutePosition(410, 765) 'Posicion en el eje cartesiano
            imagelogogopdf.ScaleAbsoluteWidth(160) 'Ancho de la imagen
            imagelogogopdf.ScaleAbsoluteHeight(50) 'Altura de la imagen
            document.Add(imagelogogopdf) ' Agrega la imagen al documento
        End If

        encabezado_obs.SpacingBefore = 5
        encabezado_obs.SpacingAfter = 15

        document.Add(encabezadoLINE)
        document.Add(tablahome)
        document.Add(encabezadoLINE2)
        document.Add(encabezado)
        document.Add(encabezadotipo)

        tabla_turno_data.SpacingBefore = 10
        document.Add(tabla_turno_data)

        encabezado8.SpacingAfter = 4
        document.Add(encabezado8)
        document.Add(datatableIMP)
        document.Add(encabezadoLINE3)

        document.Add(encabezado_obs)

        document.Add(tablafirma)

        document.Add(encabezadoLINE3)


        document.Add(encabezado7)
        document.Add(encabezadoLINE)


    End Sub

    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        'funcion para obtener el tamaño de la columnas del datagridview
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function



    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub NumericUpDown_cant_final_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_cant_final.ValueChanged
        Timer_totalizar.Enabled = True

    End Sub



    Private Sub TextBox_otros_costos_TextChanged(sender As Object, e As EventArgs) Handles TextBox_otros_costos.TextChanged
        Timer_totalizar.Enabled = True

    End Sub

    Private Sub Timer_totalizar_Tick(sender As Object, e As EventArgs) Handles Timer_totalizar.Tick

        Timer_totalizar.Enabled = False
        If TextBox_otros_costos.Text = "" Then TextBox_otros_costos.Text = "0"

        TextBox_costo_total.Text = CDec(Label_costo_produccion.Text) + CDec(TextBox_otros_costos.Text)

        If NumericUpDown_cant_final.Value <> 0 Then



            TextBox_costo_unitario.Text = CDec(CDec(TextBox_costo_total.Text) / NumericUpDown_cant_final.Value)
            TextBox_costo_unitario.Text = FormatNumber(TextBox_costo_unitario.Text, 2)
        End If


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Try
            If prod_desechos_cod = "" Then
                Label11.Text = "-"
                Exit Sub
            End If
            sql = "SELECT productos.cod, productos.nombre from productos 
WHERE coddesecho='" & prod_desechos_cod & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                Label11.Text = CStr(row.Item("cod")) & "|" & CStr(row.Item("nombre"))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
    End Sub

    Private Sub Panel_KIT_Paint(sender As Object, e As PaintEventArgs) Handles Panel_KIT.Paint

    End Sub

    Private Sub CheckBox_pesounidad_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_pesounidad.CheckedChanged

        Label_peso_unidad.Text = 0

        If CheckBox_pesounidad.Checked = True Then
            Label_peso_unidad.Text = Math.Round(CDec(Label_ins_consumidos.Text) / CDec(NumericUpDown_cant_final.Value), 2)

        Else
            Label_peso_unidad.Text = 0
        End If
    End Sub

    Private Sub Panel_dock_Paint(sender As Object, e As PaintEventArgs) Handles Panel_dock.Paint

    End Sub

    Private Sub Button_anular_Click(sender As Object, e As EventArgs) Handles Button_anular.Click
        Select Case MessageBox.Show("Confirma la anular esta orden de producción?", "Anular OP.", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            Case DialogResult.Yes
                sql = "dELETE from oproduccion WHERE cons=" & CInt(Label_consecutivo.Text) & ""
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                Try
                    da.Fill(dt)
                    'MsgBox("Tarifa Actualizada.   :).", vbInformation)
                Catch ex As Exception
                    MsgBox("error borrando produccion")
                End Try
                da.Dispose()
                dt.Dispose()
                conex.Close()



                sql = "dELETE from oproducciondetalles WHERE cons=" & CInt(Me.Label_consecutivo.Text) & ""
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                Try
                    da.Fill(dt)
                Catch ex As Exception
                    MsgBox("error borrando detalle d eproduccion")
                End Try
                da.Dispose()
                dt.Dispose()
                conex.Close()



                sql = "dELETE FROM BODEGA_" & comex_bodega_produccion & "  WHERE cons=" & CInt(Me.Label_consecutivo.Text) & " AND TIPODOCUMENTO='ORDEN DE PRODUCCION'"
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                Try
                    da.Fill(dt)
                Catch ex As Exception
                    MsgBox("error borrando produccion en bodega")
                End Try
                da.Dispose()
                dt.Dispose()
                conex.Close()

                Me.Button_anular.Enabled = False
                Me.Label_estado_movimiento.Text = "ANULADA"


                Button_Regresar_Click(Nothing, Nothing)




                Me.Cursor = Cursors.Default
                MsgBox("Se anuló la orden de producción.")

            Case DialogResult.No


        End Select
    End Sub
End Class