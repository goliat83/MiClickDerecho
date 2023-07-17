Imports System.Globalization
Imports System.Environment
Imports System.IO
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports iTextSharp.text.pdf.draw
Imports System.Threading

Public Class Form_informes
    Dim mes_num As Integer
    Dim mes_num_text As String
    Dim mes_num_text_general As String

    Dim mes_num2 As Integer
    Dim mes_num_text2 As String
    Dim TURNO_SEL As String
    Dim desktop2 As String = Environment.GetFolderPath(SpecialFolder.DesktopDirectory)

    Dim total_ingresos As Long
    Dim total_impuestos As Long
    Dim total_impuestos2 As Long

    Dim total_GASTOS_GASTOS As Long
    Dim total_GASTOS_EGRESOS As Long

    Dim reportando_que As String = ""

    Dim turno_ini As String = ""
    Dim turno_fin As String = ""
    Dim turno_base As String = ""
    Dim turno_total As String = ""

    Dim filtrar_cliente As String = ""

    Dim empleado_sel As String = ""

    Dim ID_CXC_VER As String
    Dim ID_CXP_VER As String


    Dim mousex As Integer = 0
    Dim mousey As Integer = 0
    Dim mouseDown1 As Boolean = False

    Dim total_impuestos_turno As String = "0"

    Public da_GRID_IMPUESTOS As New MySqlDataAdapter
    Public dt_GRID_IMPUESTOS As DataTable

    Public da_contact_filtro As New MySqlDataAdapter
    Public dt_contact_filtro As DataTable

    Public da_combo_inf_egreso As New MySqlDataAdapter
    Public dt_combo_inf_egreso As DataTable

    Public da_combo_inf_ingreso As New MySqlDataAdapter
    Public dt_combo_inf_ingreso As DataTable

    Public DT_CREDITO_GRID_informe As New DataTable
    Public Da_CREDITO_GRID_informe As New MySqlDataAdapter

    Public DT_cartera_GRID_informe As New DataTable
    Public Da_Cartera_GRID_informe As New MySqlDataAdapter

    Public DT_ventas_informe As New DataTable
    Public Da_ventas_informe As New MySqlDataAdapter

    Public DT_compras_informe As New DataTable
    Public Da_compras_informe As New MySqlDataAdapter

    Public DT_bods As New DataTable
    Public Da_bods As New MySqlDataAdapter

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


    Private Sub Form_informes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'EffectOut("Form_informes")

    End Sub

    Private Sub Form_informes_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        NumericUpDown_anno_general.Value = DateTime.Now.Year
        NumericUpDown_anoventa.Value = DateTime.Now.Year
        NumericUpDown_compra.Value = DateTime.Now.Year
        NumericUpDown_egresos.Value = DateTime.Now.Year
        NumericUpDown_rc.Value = DateTime.Now.Year


        ComboBox_periodo_general.SelectedIndex = DateTime.Now.Month - 1

        Timer_load.Enabled = True


    End Sub

    Private Sub combo_fechaVentas_SelectionChangeCommitted(sender As Object, e As EventArgs)

    End Sub
    Private Sub Combo_mesVentas_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Combo_mesVentas.SelectionChangeCommitted

        reportando_que = "periodo: " & Combo_mesVentas.Text

        mes_num = DateTime.ParseExact(Me.Combo_mesVentas.Text, "MMMM", CultureInfo.CurrentCulture).Month
        mes_num_text = CStr(mes_num)
        If mes_num <= 9 Then mes_num_text = "0" & CStr(mes_num)


        TextBox_costoVentas.Text = 0
        TextBox_total_ventas_butas.Text = 0
        TextBox_ventas_anuladas.Text = 0
        TextBox_ventas_devoluciones.Text = 0
        TextBox_ventas_descuentos.Text = 0
        TextBox_ventas_impuestos.Text = 0
        TextBox_ventas_netas.Text = 0


        LOAD_VENTAS_MES()



        Try
            sql = "SELECT distinct FECHA FROM VENTAS 
        where MONTH(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & mes_num_text & "' AND YEAR(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & NumericUpDown_anoventa.Value & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.COMBOBOX_FECHA_VENTAS.DataSource = dt.DefaultView
            Me.COMBOBOX_FECHA_VENTAS.DisplayMember = "FECHA"
            Me.COMBOBOX_FECHA_VENTAS.ValueMember = "FECHA"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        COMBOBOX_FECHA_VENTAS.SelectedItem = Nothing



    End Sub


    Private Sub LOAD_VENTAS_MES()
        Dim FECHA As String
        FECHA = mes_num_text & "/" & CStr(DateTime.Now.Year)

        Dim filtrocliente As String = ""
        If filtrar_cliente = "SI" Then filtrocliente = " and doccliente='" & MetroComboBox2.SelectedValue & "' "

        Try
            ' si debe generar informe por periodo
            If reportando_que.Contains("Fecha:") = False Then
                sql = "SELECT DOCUMENTO, DOCCLIENTE, CLIENTENOM, FECHA, TOTALVENTA, DESCUENTO, baseimpuesto, IMPUESTO, impuesto2, TOTAL, MEDIODEPAGO, EMPLEADO, BODEGA, ESTADO, HORA 
FROM VENTAS where month(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & mes_num_text & "' AND YEAR(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & NumericUpDown_anoventa.Value & "' " & filtrocliente & " ORDER BY DOCUMENTO ASC"
                If CheckBox_items.Checked = True Then
                    sql = "SELECT V.DOCUMENTO, V.DOCCLIENTE, V.CLIENTENOM, V.FECHA, V.TOTALVENTA, V.DESCUENTO, V.baseimpuesto, V.IMPUESTO, V.impuesto2, V.TOTAL, V.MEDIODEPAGO, V.EMPLEADO, V.ESTADO, V.HORA, V.BODEGA, VP.documento, VP.CodProd, VP.Producto, VP.Cantidad, VP.base, VP.imp, VP.imp2, VP.ValorU,VP.ValorTotal,VP.costo
FROM VENTAS V INNER JOIN ventas_prods VP ON V.Documento=VP.Documento 
where month(STR_TO_DATE(v.fecha,'%d/%m/%Y'))='" & mes_num_text & "' AND YEAR(STR_TO_DATE(V.fecha,'%d/%m/%Y'))='" & NumericUpDown_anoventa.Value & "' " & filtrocliente & " order by V.documento asc"
                End If

            End If
            'incluye items



            ' si debe generar informe por fecha
            If reportando_que.Contains("Fecha:") = True Then
                sql = "select DOCUMENTO, DOCCLIENTE, CLIENTENOM, FECHA, TOTALVENTA, DESCUENTO, baseimpuesto, IMPUESTO, impuesto2, TOTAL, MEDIODEPAGO, EMPLEADO, BODEGA, ESTADO, HORA 
from VENTAS WHERE FECHA='" & Me.COMBOBOX_FECHA_VENTAS.Text & "' AND YEAR(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & NumericUpDown_anoventa.Value & "' " & filtrocliente & " order by documento asc"

                If CheckBox_items.Checked = True Then
                    sql = "SELECT V.DOCUMENTO, V.DOCCLIENTE, V.CLIENTENOM, V.FECHA, V.TOTALVENTA, V.DESCUENTO, V.baseimpuesto, V.IMPUESTO, V.impuesto2, V.TOTAL, V.MEDIODEPAGO, V.EMPLEADO, V.ESTADO, V.BODEGA, V.HORA, VP.documento, VP.CodProd, VP.Producto, VP.Cantidad, VP.base, VP.imp, VP.imp2, VP.ValorU,VP.ValorTotal,VP.costo
FROM VENTAS V INNER JOIN ventas_prods VP ON V.Documento=VP.Documento 
where FECHA='" & Me.COMBOBOX_FECHA_VENTAS.Text & "' AND YEAR(STR_TO_DATE(V.fecha,'%d/%m/%Y'))='" & NumericUpDown_anoventa.Value & "' " & filtrocliente & " order by V.documento asc"
                End If

            End If
            'inluye items


            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.grid_VENTAS.DataSource = dt
            Me.grid_VENTAS.Columns(0).HeaderText = "#FACT"
            Me.grid_VENTAS.Columns(0).Width = 80
            Me.grid_VENTAS.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.grid_VENTAS.Columns(1).HeaderText = "DocCliente"
            Me.grid_VENTAS.Columns(1).Width = 60
            Me.grid_VENTAS.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.grid_VENTAS.Columns(2).HeaderText = "Cliente"
            Me.grid_VENTAS.Columns(2).Width = 80
            Me.grid_VENTAS.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.grid_VENTAS.Columns(3).HeaderText = "Fecha"
            Me.grid_VENTAS.Columns(3).Width = 90
            Me.grid_VENTAS.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.grid_VENTAS.Columns(4).HeaderText = "Totalventa"
            Me.grid_VENTAS.Columns(4).Width = 80
            Me.grid_VENTAS.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.grid_VENTAS.Columns(5).HeaderText = "Descuento"
            Me.grid_VENTAS.Columns(5).Width = 80
            Me.grid_VENTAS.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.grid_VENTAS.Columns(6).Visible = False
            Me.grid_VENTAS.Columns(7).HeaderText = "ImpCons"
            Me.grid_VENTAS.Columns(7).Width = 80
            Me.grid_VENTAS.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.grid_VENTAS.Columns(8).HeaderText = "IVA"
            Me.grid_VENTAS.Columns(8).Width = 80
            Me.grid_VENTAS.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.grid_VENTAS.Columns(9).HeaderText = "Total"
            Me.grid_VENTAS.Columns(9).Width = 70
            Me.grid_VENTAS.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.grid_VENTAS.Columns(10).HeaderText = "Medio de Pago"
            Me.grid_VENTAS.Columns(10).Width = 100
            Me.grid_VENTAS.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.grid_VENTAS.Columns(11).HeaderText = "Empleado"
            Me.grid_VENTAS.Columns(11).Width = 150
            Me.grid_VENTAS.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.grid_VENTAS.Columns(12).HeaderText = "Bodega"
            Me.grid_VENTAS.Columns(12).Width = 100
            Me.grid_VENTAS.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.grid_VENTAS.Columns(13).HeaderText = "Estado"
            Me.grid_VENTAS.Columns(13).Width = 100
            Me.grid_VENTAS.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        TextBox_costoVentas.Text = 0
        TextBox_ventas_impuestos.Text = 0
        TextBox_ventas_descuentos.Text = 0
        TextBox_total_ventas_butas.Text = 0
        TextBox_total_ventas_butas.Text = 0
        TextBox_ventas_anuladas.Text = 0
        TextBox_ventas_netas.Text = 0
        total_ingresos = 0

        Try
            For i As Integer = 0 To grid_VENTAS.RowCount - 1
                TextBox_total_ventas_butas.Text = CInt(TextBox_total_ventas_butas.Text) + CInt(grid_VENTAS.Item("totalventa", i).Value)

                'TextBox_total_ventas_butas.Text = CInt(TextBox_total_ventas_butas.Text) + CInt(grid_VENTAS.Item("total", i).Value)
                TextBox_ventas_descuentos.Text = CInt(TextBox_ventas_descuentos.Text) + CInt(grid_VENTAS.Item("descuento", i).Value)

                If grid_VENTAS.Item("ESTADO", i).Value = "ANULADA" Then
                    grid_VENTAS.DefaultCellStyle.BackColor = Color.IndianRed
                    TextBox_ventas_anuladas.Text = CInt(TextBox_ventas_anuladas.Text) + CInt(grid_VENTAS.Item("total", i).Value)
                End If


            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        Try
            sql = "select sum(VENTAS_PRODS.costo) AS costo from ventas left join ventas_prods on ventas.documento=ventas_prods.documento
where ventas.estado<>'ANULADA' AND FECHA='" & Me.COMBOBOX_FECHA_VENTAS.Text & "' AND YEAR(STR_TO_DATE(ventas.fecha,'%d/%m/%Y'))='" & NumericUpDown_anoventa.Value & "' " & filtrocliente & ";"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox_costoVentas.Text = 0

            For Each row As DataRow In dt.Rows
                If Not IsDBNull(CInt(row.Item("costo").ToString)) Then
                    TextBox_costoVentas.Text = CInt(TextBox_costoVentas.Text) + CInt(row.Item("costo").ToString)
                End If
            Next
        Catch ex As Exception

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        Me.TextBox_costoVentas.Text = Format(CDec(Me.TextBox_costoVentas.Text), "##,##0")

        Try
            If reportando_que.Contains("Fecha:") = True Then sql = "SELECT vrpago FROM devoluciones WHERE estado='FINALIZADO' and FECHA='" & COMBOBOX_FECHA_VENTAS.Text & "' AND YEAR(STR_TO_DATE(ventas.fecha,'%d/%m/%Y'))='" & NumericUpDown_anoventa.Value & "' " & filtrocliente & ""
            If reportando_que.Contains("Fecha:") = False Then sql = "SELECT vrpago FROM devoluciones WHERE ESTADO='FINALIZADO' and month(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & mes_num_text & "' AND YEAR(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & NumericUpDown_anoventa.Value & "' " & filtrocliente & ""

            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox_ventas_devoluciones.Text = 0

            For Each row As DataRow In dt.Rows
                If Not IsDBNull(CInt(row.Item("vrpago").ToString)) Then
                    TextBox_ventas_devoluciones.Text = CInt(row.Item("vrpago"))
                End If
            Next
        Catch ex As Exception

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        'consecutivos  dia

        Try
            If reportando_que.Contains("Fecha:") = True Then sql = "sELECT ifnull(min(documento),0) as facini, ifnull(max(documento),0) as facfinal, ifnull(count(documento),0) as facn FROM ventas WHERE 
VENTAS.FECHA='" & COMBOBOX_FECHA_VENTAS.Text & "' AND YEAR(STR_TO_DATE(ventas.fecha,'%d/%m/%Y'))='" & NumericUpDown_anoventa.Value & "' " & filtrocliente & ""
            If reportando_que.Contains("Fecha:") = False Then sql = "sELECT ifnull(min(documento),0) as facini, ifnull(max(documento),0) as facfinal, ifnull(count(documento),0) as facn FROM ventas WHERE 
month(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & mes_num_text & "' AND YEAR(STR_TO_DATE(ventas.fecha,'%d/%m/%Y'))='" & NumericUpDown_anoventa.Value & "' " & filtrocliente & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                Label_ini.Text = row.Item("facini")
                Label_fin.Text = row.Item("facfinal")
                Label_fac_count.Text = row.Item("facn")
            Next
            da.Dispose()
            dt.Dispose()
            conex.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        ' impuestos
        Try

            If reportando_que.Contains("Fecha:") = True Then sql = "SELECT  ventas_prods.ImpNom2 as Impuesto, FORMAT(sum(ventas_prods.valortotal-ventas_prods.impuesto2),0) as Base, FORMAT(sum(ventas_prods.impuesto2),0) as Valor, FORMAT(sum(ventas_prods.valortotal),0) as Total
FROM ventas_prods 
left join ventas on ventas_prods.documento=ventas.documento
where ventas.fecha='" & COMBOBOX_FECHA_VENTAS.Text & "' AND YEAR(STR_TO_DATE(ventas.fecha,'%d/%m/%Y'))='" & NumericUpDown_anoventa.Value & "' " & filtrocliente & " 
and ventas.estado<>'ANULADA'
group by ventas_prods.impnom2"
            If reportando_que.Contains("Fecha:") = False Then sql = "SELECT  ventas_prods.ImpNom2 as Impuesto, FORMAT(sum(ventas_prods.valortotal-ventas_prods.impuesto2),0) as Base, FORMAT(sum(ventas_prods.impuesto2),0) as Valor, FORMAT(sum(ventas_prods.valortotal),0) as Total
FROM ventas_prods 
left join ventas on ventas_prods.documento=ventas.documento
where month(STR_TO_DATE(ventas.fecha,'%d/%m/%Y'))='" & mes_num_text & "' AND YEAR(STR_TO_DATE(ventas.fecha,'%d/%m/%Y'))='" & NumericUpDown_anoventa.Value & "' " & filtrocliente & " and ventas.estado<>'ANULADA' 
group by ventas_prods.impnom2"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            datagrid_imp.DataSource = dt.DefaultView
            Me.datagrid_imp.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagrid_imp.Columns(0).HeaderText = "Impuesto Generado en Ventas"
            Me.datagrid_imp.Columns(0).Width = 250
            TextBox_ventas_impuestos.Text = 0
            For Each row3 As DataRow In dt.Rows
                Dim VALOR As Integer
                VALOR = CStr(row3.Item("valor").ToString.Replace(",", ""))
                If row3.Item("impuesto") <> "NO GRAVADO" Or row3.Item("impuesto") <> "NO" Then TextBox_ventas_impuestos.Text = CInt(TextBox_ventas_impuestos.Text) + CInt(VALOR)
            Next
        Catch ex As Exception
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        ' dev de impuestos
        Try
            If reportando_que.Contains("Fecha:") = False Then sql = "SELECT devoluciones_prods.ImpNom2 as Impuesto, FORMAT(sum(devoluciones_prods.valortotal-devoluciones_prods.impuesto2),0) as Base, FORMAT(sum(devoluciones_prods.impuesto2),0) as Valor, FORMAT(sum(devoluciones_prods.valortotal),0) as Total
FROM devoluciones_prods
left join devoluciones on devoluciones_prods.documento=devoluciones.cons
where month(STR_TO_DATE(devoluciones.fecha,'%d/%m/%Y'))='" & mes_num_text & "' AND YEAR(STR_TO_DATE(devoluciones.fecha,'%d/%m/%Y'))='" & NumericUpDown_anoventa.Value & " " & filtrocliente & "' 
and devoluciones.estado<>'ANULADA'
group by devoluciones_prods.impnom2"
            If reportando_que.Contains("Fecha:") = True Then sql = "SELECT devoluciones_prods.ImpNom2 as Impuesto, FORMAT(sum(devoluciones_prods.valortotal-devoluciones_prods.impuesto2),0) as Base, FORMAT(sum(devoluciones_prods.impuesto2),0) as Valor, FORMAT(sum(devoluciones_prods.valortotal),0) as Total
FROM devoluciones_prods
left join devoluciones on devoluciones_prods.documento=devoluciones.cons
devoluciones.FECHA='" & Me.COMBOBOX_FECHA_VENTAS.Text & "' AND YEAR(STR_TO_DATE(devoluciones.fecha,'%d/%m/%Y'))='" & NumericUpDown_anoventa.Value & " " & filtrocliente & "' 
and devoluciones.estado<>'ANULADA'
group by devoluciones_prods.impnom2"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            datagrid_imp_dev_ventas.DataSource = dt.DefaultView
            Me.datagrid_imp_dev_ventas.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagrid_imp_dev_ventas.Columns(0).HeaderText = "Devoluciones de Impuestos"
            Me.datagrid_imp_dev_ventas.Columns(0).Width = 250
            ' no igualo a cero el total y lo resto
            For Each row3 As DataRow In dt.Rows
                Dim VALOR As Integer
                VALOR = CStr(row3.Item("valor").ToString.Replace(",", ""))
                If row3.Item("impuesto") <> "NO GRAVADO" Or row3.Item("impuesto") <> "NO" Then TextBox_ventas_impuestos.Text = CInt(TextBox_ventas_impuestos.Text) - CInt(VALOR)
            Next
        Catch ex As Exception
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()


        Me.TextBox_total_ventas_butas.Text = Format(CDec(Me.TextBox_total_ventas_butas.Text), "##,##0")
        Me.TextBox_ventas_anuladas.Text = Format(CDec(Me.TextBox_ventas_anuladas.Text), "##,##0")
        Me.TextBox_ventas_devoluciones.Text = Format(CDec(Me.TextBox_ventas_devoluciones.Text), "##,##0")


        Me.TextBox_ventas_netas.Text = Format(CDec(Me.TextBox_total_ventas_butas.Text) - CDec(Me.TextBox_ventas_anuladas.Text) - CDec(Me.TextBox_ventas_devoluciones.Text) - CDec(TextBox_ventas_impuestos.Text), "##,##0")
        Me.TextBox_ventas_netas.Text = Format(CDec(TextBox_ventas_netas.Text) + CDec(TextBox_ventas_descuentos.Text), "##,##0")

        Me.grid_VENTAS.ClearSelection()

        datagrid_imp.ClearSelection()
        datagrid_imp_dev_ventas.ClearSelection()
    End Sub



    Private Sub LOAD_COMPRAS_MES()
        Dim FECHA As String
        FECHA = mes_num_text & "/" & CStr(DateTime.Now.Year)
        Try
            sql = "SELECT * FROM compras where month(STR_TO_DATE(fecha,'%d/%m/%Y'))=" & mes_num_text & " and YEAR(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & NumericUpDown_compra.Value & "' ORDER BY DOCUMENTO ASC"


            ' si debe generar informe por periodo
            If reportando_que.Contains("Fecha:") = False Then
                sql = "SELECT * 
FROM compras where month(STR_TO_DATE(fecha,'%d/%m/%Y'))=" & mes_num_text & " and YEAR(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & NumericUpDown_compra.Value & "' ORDER BY DOCUMENTO ASC"
                If CheckBox_COMPRAS_ITEMS.Checked = True Then
                    sql = "SELECT c.*, cp.documento as factura, cp.codprod, cp.producto, cp.cantidad, cp.base, cp.imp, cp.imp2, cp.imp2, cp.valoru, cp.valortotal
FROM compras c inner join compras_prods cp on c.documento=cp.documento where month(STR_TO_DATE(c.fecha,'%d/%m/%Y'))=" & mes_num_text & " and YEAR(STR_TO_DATE(c.fecha,'%d/%m/%Y'))='" & NumericUpDown_compra.Value & "' ORDER BY c.DOCUMENTO ASC"
                End If

            End If


            ' si debe generar informe por fecha
            If reportando_que.Contains("Fecha:") = True Then
                sql = "select * 
from compras WHERE FECHA='" & Me.Combobox_FECHA_COMPRA.Text & "' AND YEAR(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & NumericUpDown_compra.Value & "' ORDER BY DOCUMENTO ASC"
                If CheckBox_COMPRAS_ITEMS.Checked = True Then
                    sql = "select c.*, cp.documento as factura, cp.codprod, cp.producto, cp.cantidad, cp.base, cp.imp, cp.imp2, cp.imp2, cp.valoru, cp.valortotal
from compras c inner join compras_prods cp on c.documento=cp.documento WHERE c.FECHA='" & Me.Combobox_FECHA_COMPRA.Text & "' AND YEAR(STR_TO_DATE(c.fecha,'%d/%m/%Y'))='" & NumericUpDown_compra.Value & "' ORDER BY c.DOCUMENTO ASC"
                End If



            End If


                da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.Grid_COMPRAS.DataSource = dt
            Me.Grid_COMPRAS.Columns(0).Visible = False
            Me.Grid_COMPRAS.Columns(1).HeaderText = "Compra"
            Me.Grid_COMPRAS.Columns(1).Width = 80
            Me.Grid_COMPRAS.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.Grid_COMPRAS.Columns(2).Visible = False
            Me.Grid_COMPRAS.Columns(3).HeaderText = "Documento"
            Me.Grid_COMPRAS.Columns(3).Width = 80
            Me.Grid_COMPRAS.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.Grid_COMPRAS.Columns(4).HeaderText = "Proveedor"
            Me.Grid_COMPRAS.Columns(4).Width = 80
            Me.Grid_COMPRAS.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.Grid_COMPRAS.Columns(5).HeaderText = "Fecha"
            Me.Grid_COMPRAS.Columns(5).Width = 80
            Me.Grid_COMPRAS.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.Grid_COMPRAS.Columns(6).HeaderText = "Observaciones"
            Me.Grid_COMPRAS.Columns(6).Width = 80
            Me.Grid_COMPRAS.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.Grid_COMPRAS.Columns(7).Visible = False
            Me.Grid_COMPRAS.Columns(8).Visible = False
            Me.Grid_COMPRAS.Columns(9).Visible = False
            Me.Grid_COMPRAS.Columns(10).Visible = False
            Me.Grid_COMPRAS.Columns(11).Visible = False
            Me.Grid_COMPRAS.Columns(12).Visible = False
            Me.Grid_COMPRAS.Columns(13).HeaderText = "Total"
            Me.Grid_COMPRAS.Columns(13).Width = 80
            Me.Grid_COMPRAS.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.Grid_COMPRAS.Columns(14).HeaderText = "Medio de Pago"
            Me.Grid_COMPRAS.Columns(14).Width = 80
            Me.Grid_COMPRAS.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.Grid_COMPRAS.Columns(15).Visible = False
            Me.Grid_COMPRAS.Columns(16).Visible = False
            Me.Grid_COMPRAS.Columns(17).Visible = False
            Me.Grid_COMPRAS.Columns(18).Visible = False
            Me.Grid_COMPRAS.Columns(19).Visible = False
            Me.Grid_COMPRAS.Columns(20).Visible = False
            Me.Grid_COMPRAS.Columns(21).HeaderText = "Estado"
            Me.Grid_COMPRAS.Columns(21).Width = 80
            Me.Grid_COMPRAS.Columns(21).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.Grid_COMPRAS.Columns(22).Visible = False
            Me.Grid_COMPRAS.Columns(23).Visible = False
            Me.Grid_COMPRAS.Columns(24).Visible = False
            Me.Grid_COMPRAS.Columns(25).Visible = False
            Me.Grid_COMPRAS.Columns(26).Visible = False
            Me.Grid_COMPRAS.Columns(27).Visible = False
            Me.Grid_COMPRAS.Columns(28).Visible = False
            Me.Grid_COMPRAS.Columns(29).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()


        total_impuestos = 0
        total_ingresos = 0
        Try
            For i As Integer = 0 To Grid_COMPRAS.RowCount - 1
                total_ingresos = total_ingresos + Grid_COMPRAS.Item("total", i).Value
                total_impuestos = total_impuestos + Grid_COMPRAS.Item("impuesto", i).Value

                If Grid_COMPRAS.Item("ESTADO", i).Value = "ANULADA" Then
                    Grid_COMPRAS.DefaultCellStyle.BackColor = Color.IndianRed
                    TextBox_compras_anuladas.Text = CInt(TextBox_compras_anuladas.Text) + CInt(Grid_COMPRAS.Item("total", i).Value)
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        Me.TextBox_comprasbrutas.Text = total_ingresos
        Me.TextBox_comprasbrutas.Text = Format(CDec(Me.TextBox_comprasbrutas.Text), "##,##0")

        TextBox_compras_anuladas.Text = Format(CDec(Me.TextBox_compras_anuladas.Text), "##,##0")


        ' impuestos
        Try


            If reportando_que.Contains("Fecha:") = False Then sql = "SELECT  compras_prods.ImpNom2 as Impuesto, FORMAT(sum(compras_prods.valortotal-compras_prods.impuesto2),0) as Base, FORMAT(sum(compras_prods.impuesto2),0) as Valor, FORMAT(sum(compras_prods.valortotal),0) as Total
FROM compras_prods 
left join compras on compras_prods.documento=compras.documento
where month(STR_TO_DATE(compras.fecha,'%d/%m/%Y'))='" & mes_num_text & "' AND YEAR(STR_TO_DATE(compras.fecha,'%d/%m/%Y'))='" & NumericUpDown_compra.Value & "' 
and compras.estado<>'ANULADA'
group by compras_prods.impnom2"
            If reportando_que.Contains("Fecha:") = True Then sql = "SELECT  compras_prods.ImpNom2 as Impuesto, FORMAT(sum(compras_prods.valortotal-compras_prods.impuesto2),0) as Base, FORMAT(sum(compras_prods.impuesto2),0) as Valor, FORMAT(sum(compras_prods.valortotal),0) as Total
FROM compras_prods
left join compras on compras_prods.documento=compras.documento
where devoluciones.FECHA='" & Me.Combobox_FECHA_COMPRA.Text & "' AND YEAR(STR_TO_DATE(devoluciones.fecha,'%d/%m/%Y'))='" & NumericUpDown_compra.Value & "' 
and compras.estado<>'ANULADA'
group by compras_prods.impnom2"

            total_impuestos = 0
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            dataGrid_impcompras.DataSource = dt.DefaultView
            For Each row3 As DataRow In dt.Rows
                Dim VALOR As Integer
                VALOR = CStr(row3.Item("valor").ToString.Replace(",", ""))

                If row3.Item("impuesto") <> "NO GRAVADO" Then total_impuestos = total_impuestos + CInt(VALOR)

            Next
        Catch ex As Exception
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        TextBox_total_imp_compras.Text = total_impuestos
        TextBox_total_imp_compras.Text = Format(CDec(Me.TextBox_total_imp_compras.Text), "##,##0")


        dataGrid_impcompras.ClearSelection()


        'devoluciones
        Try
            If reportando_que.Contains("Fecha:") = True Then sql = "SELECT vrpago FROM devolucionesCOMPRAS WHERE estado='FINALIZADO' and FECHA='" & Combobox_FECHA_COMPRA.Text & "' AND YEAR(STR_TO_DATE(ventas.fecha,'%d/%m/%Y'))='" & NumericUpDown_compra.Value & "'"
            If reportando_que.Contains("Fecha:") = False Then sql = "SELECT vrpago FROM devolucionesCOMPRAS WHERE estado='FINALIZADO' and month(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & mes_num_text & "' AND YEAR(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & NumericUpDown_compra.Value & "'"

            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox_compras_devoluciones.Text = 0

            For Each row As DataRow In dt.Rows
                If Not IsDBNull(CInt(row.Item("vrpago").ToString)) Then
                    TextBox_compras_devoluciones.Text = CInt(row.Item("vrpago"))
                End If
            Next
        Catch ex As Exception

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()


        ' dev de impuestos
        Try
            If reportando_que.Contains("Fecha:") = False Then sql = "SELECT devolucionescompras_prods.ImpNom2 as Impuesto, FORMAT(sum(devolucionescompras_prods.valortotal-devolucionescompras_prods.impuesto2),0) as Base, FORMAT(sum(devolucionescompras_prods.impuesto2),0) as Valor, FORMAT(sum(devolucionescompras_prods.valortotal),0) as Total
FROM devolucionescompras_prods
left join devolucionescompras on devolucionescompras_prods.documento=devolucionescompras.cons
where month(STR_TO_DATE(devolucionescompras.fecha,'%d/%m/%Y'))='" & mes_num_text & "' AND YEAR(STR_TO_DATE(devolucionescompras.fecha,'%d/%m/%Y'))='" & NumericUpDown_compra.Value & "' 
and devolucionescompras.estado<>'ANULADA'
group by devolucionescompras_prods.impnom2"
            If reportando_que.Contains("Fecha:") = True Then sql = "SELECT devolucionescompras_prods.ImpNom2 as Impuesto, FORMAT(sum(devolucionescompras_prods.valortotal-devolucionescompras_prods.impuesto2),0) as Base, FORMAT(sum(devolucionescompras_prods.impuesto2),0) as Valor, FORMAT(sum(devolucionescompras_prods.valortotal),0) as Total
FROM devolucionescompras_prods
left join devolucionescompras on devolucionescompras_prods.documento=devolucionescompras.cons
devolucionescompras.FECHA='" & Me.Combobox_FECHA_COMPRA.Text & "' AND YEAR(STR_TO_DATE(devolucionescompras.fecha,'%d/%m/%Y'))='" & NumericUpDown_compra.Value & "' 
and devolucionescompras.estado<>'ANULADA'
group by devolucionescompras_prods.impnom2"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            datagrid_imp_dev_compras.DataSource = dt.DefaultView
            Me.datagrid_imp_dev_compras.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagrid_imp_dev_compras.Columns(0).HeaderText = "Devoluciones de Impuestos"
            Me.datagrid_imp_dev_compras.Columns(0).Width = 250
            ' no igualo a cero el total y lo resto
            For Each row3 As DataRow In dt.Rows
                Dim VALOR As Integer
                VALOR = CStr(row3.Item("valor").ToString.Replace(",", ""))
                If row3.Item("impuesto") <> "NO GRAVADO" Or row3.Item("impuesto") <> "NO" Then TextBox_total_imp_compras.Text = CInt(TextBox_total_imp_compras.Text) - CInt(VALOR)
            Next
        Catch ex As Exception
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()


        Me.TextBox_comprasbrutas.Text = Format(CDec(Me.TextBox_comprasbrutas.Text), "##,##0")
        Me.TextBox_compras_anuladas.Text = Format(CDec(Me.TextBox_compras_anuladas.Text), "##,##0")
        Me.TextBox_compras_devoluciones.Text = Format(CDec(Me.TextBox_compras_devoluciones.Text), "##,##0")


        Me.TextBox_compras_netas.Text = Format(CDec(Me.TextBox_comprasbrutas.Text) - CDec(Me.TextBox_compras_anuladas.Text) - CDec(Me.TextBox_compras_devoluciones.Text) - CDec(TextBox_total_imp_compras.Text), "##,##0")
        Me.TextBox_ventas_netas.Text = Format(CDec(TextBox_ventas_netas.Text) + CDec(TextBox_ventas_descuentos.Text), "##,##0")

        Me.Grid_COMPRAS.ClearSelection()

        dataGrid_impcompras.ClearSelection()
        datagrid_imp_dev_compras.ClearSelection()


    End Sub




    Private Sub Button_guardar_Click(sender As Object, e As EventArgs) Handles Button_guardar.Click
        Try
            Using conex
                ' recuperamos el documento de la base de datos y lo pasamos a un fichero
                Dim drDocumentos As MySqlDataReader
                Dim aBytDocumento() As Byte = Nothing
                Dim oFileStream As FileStream
                Dim lsQuery As String = "Select archivo From resources Where id=1"
                Using loComando As New MySqlCommand(lsQuery, conex)
                    conex.Open()
                    drDocumentos = loComando.ExecuteReader(CommandBehavior.SingleRow)
                End Using
                If drDocumentos.Read() Then
                    aBytDocumento = CType(drDocumentos("archivo"), Byte())
                    '  End If
                    drDocumentos.Close()
                    oFileStream = New FileStream(desktop2 & "\INFORME_VENTAS.xlsx", FileMode.Create, FileAccess.Write)
                    oFileStream.Write(aBytDocumento, 0, aBytDocumento.Length)
                    oFileStream.Close()
                    'MessageBox.Show("Documento generado con éxito", "Generar Documentos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch Exp As Exception
            MessageBox.Show(Exp.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Me.Cursor = Cursors.Default
        GridAExcel(Me.grid_VENTAS)
        Me.Cursor = Cursors.Default
    End Sub

    Function GridAExcel(ByVal ElGrid As DataGridView) As Boolean
        Me.Cursor = Cursors.WaitCursor
        'Creamos las variables
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
        exLibro = exApp.Workbooks.Open(desktop2 & "\INFORME_VENTAS.xlsx", )
        exHoja = exApp.ActiveWorkbook.Sheets(1)
        Try
            'Datos de encabezADO
            exHoja.Cells.Item(2, 1) = "Informe Ventas"


            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = ElGrid.ColumnCount
            Dim NRow As Integer = ElGrid.RowCount
            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(5, i) = ElGrid.Columns(i - 1).Name.ToString
                exHoja.Cells.Item(5, i).HorizontalAlignment = 2
            Next
            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 6, Col + 1) = ElGrid.Rows(Fila).Cells(Col).Value
                    exHoja.Cells.Item(Fila + 6, Col + 1).HorizontalAlignment = 2
                Next
            Next
            'Titulo en negrita, Alineado al centro y que el tamaño de la columna seajuste al texto
            'exHoja.Rows.Item(1).Font.Bold = 1
            'exHoja.Rows.Item(1).HorizontalAlignment = 3
            'exHoja.Columns.AutoFit()

            'Aplicación visible
            exApp.Application.Visible = False
            exLibro.Save()
            exLibro.Close()
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing
            MsgBox("El informe se encuentra en el escritorio.", vbInformation)
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
            Return False
        End Try
        Return True
        Me.Cursor = Cursors.Default
    End Function



    Private Sub Button_export_pdf_ventas_Click(sender As Object, e As EventArgs) Handles Button_export_pdf_ventas.Click
        If Combo_mesVentas.SelectedItem = Nothing And COMBOBOX_FECHA_VENTAS.Text = Nothing Then
            MsgBox("Antes de exportar debe selecionar una fecha.", vbInformation) : Exit Sub
        End If





        Try
            'Intentar generar el documento.
            Dim doc As New Document(PageSize.A4.Rotate, 20, 10, 10, 20)
            'Path que guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Informe de Ventas.pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, file)
            doc.Open()
            ExportarDatosPDF_ventas(doc)
            doc.Close()
            Process.Start(filename)
        Catch ex As Exception
            'Si el intento es fallido, mostrar MsgBox.
            MessageBox.Show("No se puede generar el documento PDF, Cierre los documentos PDF generados anteriormente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub ExportarDatosPDF_ventas(ByVal document As Document)
        'Se crea un objeto PDFTable con el numero de columnas del DataGridView.
        Dim datatable As New PdfPTable(grid_VENTAS.ColumnCount)
        'Se asignan algunas propiedades para el diseño del PDF.
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(grid_VENTAS)
        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
        'Se crea el encabezado en el PDF.
        Dim encabezado As New Paragraph(comex_nombrecomercial, New Font(Font.Name = "Arial Black", 16, Font.Bold))
        Dim encabezado2 As New Paragraph("Informe de Ventas", New Font(Font.Name = "Arial Black", 13, Font.Bold))

        'Se crea el texto abajo del encabezado.

        Dim textoreporte As New Phrase("Periodo: " + reportando_que + Chr(13), New Font(Font.Name = "Arial Narrow", 9, Font.Bold))
        Dim textofacs As New Phrase(Label_fac_count.Text + " Facturas Emitidas, desde:" + Label_ini.Text + " Hasta:" + Label_fin.Text + Chr(13), New Font(Font.Name = "Arial Narrow", 9, Font.Bold))

        Dim texto4 As New Phrase("Total Ventas Brutas:" + Me.TextBox_total_ventas_butas.Text + Chr(13), New Font(Font.Name = "Arial Narrow", 9, Font.Bold))
        Dim texto5 As New Phrase("Total Ventas Anuladas:" + Me.TextBox_ventas_anuladas.Text + Chr(13), New Font(Font.Name = "Arial Narrow", 9, Font.Bold))
        Dim texto6 As New Phrase("Total Devoluciones:" + Me.TextBox_ventas_devoluciones.Text + Chr(13), New Font(Font.Name = "Arial Narrow", 9, Font.Bold))
        Dim texto7 As New Phrase("Total Descuentos:" + Me.TextBox_ventas_descuentos.Text + Chr(13), New Font(Font.Name = "Arial Narrow", 9, Font.Bold))
        Dim texto8 As New Phrase("Total Impuesto:" + Me.TextBox_ventas_impuestos.Text + Chr(13), New Font(Font.Name = "Arial Narrow", 9, Font.Bold))
        Dim texto9 As New Phrase("Ventas Netas:" + Me.TextBox_ventas_netas.Text + Chr(13), New Font(Font.Name = "Arial Narrow", 9, Font.Bold))

        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To grid_VENTAS.ColumnCount - 1
            Dim cell_t As New PdfPCell
            cell_t.Phrase = New Phrase(grid_VENTAS.Columns(i).HeaderText, New Font(Font.Name = "Arial Narrow", 8))
            cell_t.BackgroundColor = BaseColor.LIGHT_GRAY
            datatable.AddCell(cell_t)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1
        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To grid_VENTAS.RowCount - 1
            For j As Integer = 0 To grid_VENTAS.ColumnCount - 1

                Dim cell As New PdfPCell
                cell.Phrase = New Phrase(grid_VENTAS(j, i).Value.ToString, New Font(Font.Name = "Arial Narrow", 7))
                If j = 0 Then cell.HorizontalAlignment = Element.ALIGN_CENTER
                If j = 1 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 2 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 3 Then cell.HorizontalAlignment = Element.ALIGN_CENTER
                If j = 4 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 5 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 6 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 7 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 8 Then cell.HorizontalAlignment = Element.ALIGN_CENTER
                If j = 9 Then cell.HorizontalAlignment = Element.ALIGN_CENTER
                If j = 10 Then cell.HorizontalAlignment = Element.ALIGN_CENTER

                datatable.AddCell(cell)

            Next
            datatable.CompleteRow()
        Next

        Dim datatableIMP As New PdfPTable(datagrid_imp.ColumnCount)


        'Se asignan algunas propiedades para el diseño del PDF.
        datatableIMP.DefaultCell.Padding = 3
        Dim headerwidthsimp As Single() = GetColumnasSize(datagrid_imp)

        datatableIMP.SetWidths(headerwidthsimp)
        datatableIMP.WidthPercentage = 50
        datatableIMP.DefaultCell.BorderWidth = 0
        datatableIMP.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT
        datatableIMP.HorizontalAlignment = Element.ALIGN_LEFT

        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To datagrid_imp.ColumnCount - 1
            Dim HEADERCELLFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 5, iTextSharp.text.Font.BOLD)

            Dim cell_TITLE As New PdfPCell
            cell_TITLE.Phrase = New Phrase(datagrid_imp.Columns(i).HeaderText, FontFactory.GetFont(FontFactory.COURIER_BOLD, 7.5D, iTextSharp.text.Font.BOLD))
            cell_TITLE.HorizontalAlignment = Element.ALIGN_CENTER
            cell_TITLE.BackgroundColor = BaseColor.LIGHT_GRAY
            cell_TITLE.Border = 0

            datatableIMP.AddCell(cell_TITLE)
        Next
        datatableIMP.HeaderRows = 1
        datatableIMP.DefaultCell.BorderWidth = 0
        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To datagrid_imp.RowCount - 1
            For j As Integer = 0 To datagrid_imp.ColumnCount - 1
                Dim cell As New PdfPCell
                cell.Phrase = New Phrase(datagrid_imp(j, i).FormattedValue.ToString, FontFactory.GetFont(FontFactory.COURIER, 7D, iTextSharp.text.Font.BOLD))
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



        Dim datatableIMPdev As New PdfPTable(datagrid_imp_dev_ventas.ColumnCount)


        'Se asignan algunas propiedades para el diseño del PDF.
        datatableIMPdev.DefaultCell.Padding = 3
        Dim headerwidthsimp2 As Single() = GetColumnasSize(datagrid_imp_dev_ventas)

        datatableIMPdev.SetWidths(headerwidthsimp2)
        datatableIMPdev.WidthPercentage = 50
        datatableIMPdev.DefaultCell.BorderWidth = 0
        datatableIMPdev.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT
        datatableIMPdev.HorizontalAlignment = Element.ALIGN_LEFT


        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To datagrid_imp_dev_ventas.ColumnCount - 1
            Dim HEADERCELLFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 5, iTextSharp.text.Font.BOLD)

            Dim cell_TITLE As New PdfPCell
            cell_TITLE.Phrase = New Phrase(datagrid_imp_dev_ventas.Columns(i).HeaderText, FontFactory.GetFont(FontFactory.COURIER_BOLD, 7.5D, iTextSharp.text.Font.BOLD))
            cell_TITLE.HorizontalAlignment = Element.ALIGN_CENTER
            cell_TITLE.BackgroundColor = BaseColor.LIGHT_GRAY
            cell_TITLE.Border = 0

            datatableIMPdev.AddCell(cell_TITLE)
        Next
        datatableIMPdev.HeaderRows = 1
        datatableIMPdev.DefaultCell.BorderWidth = 0
        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To datagrid_imp_dev_ventas.RowCount - 1
            For j As Integer = 0 To datagrid_imp_dev_ventas.ColumnCount - 1
                Dim cell As New PdfPCell
                cell.Phrase = New Phrase(datagrid_imp_dev_ventas(j, i).FormattedValue.ToString, FontFactory.GetFont(FontFactory.COURIER, 7D, iTextSharp.text.Font.BOLD))
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
                datatableIMPdev.AddCell(cell)
            Next
            datatableIMPdev.CompleteRow()
        Next

        Dim texto As New Phrase("Fecha del Reporte:" + Now.Date() + Chr(13), New Font(Font.Name = "Arial Narrow", 9, Font.Bold))
        Dim texto2 As New Phrase("Generado Por:" + usrnom + Chr(13), New Font(Font.Name = "Arial Narrow", 9, Font.Bold))


        If comex_logo <> "" And File.Exists(comex_logo) = True Then
            Dim imagelogogopdf As iTextSharp.text.Image 'Declaracion de una imagen

            imagelogogopdf = iTextSharp.text.Image.GetInstance(comex_logo) 'Dirreccion a la imagen que se hace referencia
            imagelogogopdf.Alignment = Element.ALIGN_RIGHT
            imagelogogopdf.SetAbsolutePosition(580, 490) 'Posicion en el eje cartesiano
            imagelogogopdf.ScaleAbsoluteWidth(200) 'Ancho de la imagen
            imagelogogopdf.ScaleAbsoluteHeight(90) 'Altura de la imagen
            document.Add(imagelogogopdf) ' Agrega la imagen al documento
        End If


        'Se agrega el PDFTable al documento.
        document.Add(encabezado)
        document.Add(encabezado2)

        document.Add(textoreporte)
        document.Add(textofacs)
        document.Add(texto4)
        document.Add(texto5)
        document.Add(texto6)
        document.Add(texto7)
        document.Add(texto8)
        document.Add(texto9)
        datatableIMP.SpacingBefore = 10
        document.Add(datatable)
        document.Add(datatableIMP)
        document.Add(datatableIMPdev)
        document.Add(texto)
        document.Add(texto2)
    End Sub

    Private Sub MetroCombo_MESCOMPRA_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles MetroCombo_MES_COMPRA.SelectionChangeCommitted
        Me.Combobox_FECHA_COMPRA.SelectedItem = Nothing



        mes_num = DateTime.ParseExact(Me.MetroCombo_MES_COMPRA.Text, "MMMM", CultureInfo.CurrentCulture).Month
        mes_num_text = CStr(mes_num)
        If mes_num <= 9 Then mes_num_text = "0" & CStr(mes_num)
        LOAD_COMPRAS_MES()



        Try
            sql = "SELECT distinct FECHA FROM compras 
        where MONTH(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & mes_num_text & "' AND YEAR(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & NumericUpDown_anoventa.Value & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.Combobox_FECHA_COMPRA.DataSource = dt.DefaultView
            Me.Combobox_FECHA_COMPRA.DisplayMember = "FECHA"
            Me.Combobox_FECHA_COMPRA.ValueMember = "FECHA"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        Combobox_FECHA_COMPRA.SelectedItem = Nothing
    End Sub
    Private Sub MetroCombo_FECHACOMPRA_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Combobox_FECHA_COMPRA.SelectionChangeCommitted

        reportando_que = "Fecha: " & Combobox_FECHA_COMPRA.Text

        LOAD_COMPRAS_MES()

        Me.MetroCombo_MES_COMPRA.SelectedItem = Nothing

    End Sub

    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        'funcion para obtener el tamaño de la columnas del datagridview
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function


    Private Sub Button_export_pdf_compras_Click(sender As Object, e As EventArgs)
        Try
            'Intentar generar el documento.
            Dim doc As New Document(PageSize.A4.Rotate, 10, 10, 10, 10)
            'Path que guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Informe de Compras.pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, file)
            doc.Open()
            ExportarDatosPDF_compras(doc)
            doc.Close()
            Process.Start(filename)
        Catch ex As Exception
            'Si el intento es fallido, mostrar MsgBox.
            MessageBox.Show("No se puede generar el documento PDF, Cierre los documentos PDF generados anteriormente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub ExportarDatosPDF_compras(ByVal document As Document)
        'Se crea un objeto PDFTable con el numero de columnas del DataGridView.
        Dim datatable As New PdfPTable(Grid_COMPRAS.ColumnCount)
        'Se asignan algunas propiedades para el diseño del PDF.
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(Grid_COMPRAS)
        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
        'Se crea el encabezado en el PDF.
        Dim encabezado As New Paragraph(comex_nombrecomercial, New Font(Font.Name = "Arial", 20, Font.Bold))
        Dim encabezado2 As New Paragraph("Informe de Compras", New Font(Font.Name = "Arial", 20, Font.Bold))

        'Se crea el texto abajo del encabezado.
        Dim texto As New Phrase("Fecha del Reporte:" + Now.Date(), New Font(Font.Name = "Tahoma", 14, Font.Bold))
        Dim texto2 As New Phrase("Generado Por:" + USR_NOM, New Font(Font.Name = "Tahoma", 14, Font.Bold))

        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To Grid_COMPRAS.ColumnCount - 1
            datatable.AddCell(Grid_COMPRAS.Columns(i).HeaderText)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1
        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To Grid_COMPRAS.RowCount - 1
            For j As Integer = 0 To Grid_COMPRAS.ColumnCount - 1
                datatable.AddCell(Grid_COMPRAS(j, i).Value.ToString())
            Next
            datatable.CompleteRow()
        Next
        'Se agrega el PDFTable al documento.
        document.Add(encabezado)
        document.Add(encabezado2)
        document.Add(texto)


        document.Add(datatable)
    End Sub
    Public Sub ExportarDatosPDF_gastos(ByVal document As Document)
        'Se crea un objeto PDFTable con el numero de columnas del DataGridView.
        Dim datatable As New PdfPTable(Grid_informe_ce.ColumnCount)
        'Se asignan algunas propiedades para el diseño del PDF.
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(Grid_informe_ce)
        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
        'Se crea el encabezado en el PDF.
        Dim encabezado As New Paragraph(comex_nombrecomercial, New Font(Font.Name = "Arial", 14, Font.Bold))
        Dim encabezado2 As New Paragraph("Recibos de gastos", New Font(Font.Name = "Arial", 14, Font.Bold))

        'Se crea el texto abajo del encabezado.
        Dim texto As New Phrase("Fecha del Reporte:" + Now.Date(), New Font(Font.Name = "Tahoma", 12, Font.Bold))
        Dim texto2 As New Phrase("Generado Por:" + USR_NOM, New Font(Font.Name = "Tahoma", 12, Font.Bold))
        Dim texto3 As New Phrase("Periodo Del Reporte:" + MetroComboBox_mes_ce.Text, New Font(Font.Name = "Tahoma", 14, Font.Bold))

        Dim rowFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 6, iTextSharp.text.Font.BOLD)

        datatable.SetWidths({5, 10, 12, 20, 40, 10, 10, 10})

        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To Grid_informe_ce.ColumnCount - 1
            Dim HEADERCELLFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 8, iTextSharp.text.Font.BOLD)
            Dim cell_TITLE As New PdfPCell
            cell_TITLE.Phrase = New Phrase(Grid_informe_ce.Columns(i).HeaderText, HEADERCELLFont)
            cell_TITLE.HorizontalAlignment = Element.ALIGN_CENTER
            cell_TITLE.BackgroundColor = BaseColor.LIGHT_GRAY
            datatable.AddCell(cell_TITLE)
        Next



        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1
        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To Grid_informe_ce.RowCount - 1
            For j As Integer = 0 To Grid_informe_ce.ColumnCount - 1
                Dim cell As New PdfPCell

                cell.Phrase = New Phrase(Grid_informe_ce(j, i).FormattedValue.ToString, rowFont)

                If j = 0 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 1 Then cell.HorizontalAlignment = Element.ALIGN_CENTER
                If j = 2 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 3 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 4 Then cell.HorizontalAlignment = Element.ALIGN_CENTER
                If j = 5 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 6 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 7 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT

                cell.Border = 0
                cell.BorderWidthRight = 0.3F
                cell.BorderColorRight = BaseColor.BLACK
                datatable.AddCell(cell)
            Next
            datatable.CompleteRow()
        Next

        'Se agrega el PDFTable al documento.
        document.Add(encabezado)
        document.Add(encabezado2)
        document.Add(texto)
        document.Add(texto2)
        document.Add(texto3)


        document.Add(datatable)
    End Sub
    Public Sub ExportarDatosPDF_RC(ByVal document As Document)
        'Se crea un objeto PDFTable con el numero de columnas del DataGridView.
        Dim datatable As New PdfPTable(Grid_informe_rc.ColumnCount)
        'Se asignan algunas propiedades para el diseño del PDF.
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(Grid_informe_rc)
        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
        'Se crea el encabezado en el PDF.
        Dim encabezado As New Paragraph(comex_nombrecomercial, New Font(Font.Name = "Arial", 14, Font.Bold))
        Dim encabezado2 As New Paragraph("Recibos de Caja", New Font(Font.Name = "Arial", 14, Font.Bold))

        'Se crea el texto abajo del encabezado.
        Dim texto As New Phrase("Fecha del Reporte:" + Now.Date(), New Font(Font.Name = "Tahoma", 12, Font.Bold))
        Dim texto2 As New Phrase("Generado Por:" + USR_NOM, New Font(Font.Name = "Tahoma", 12, Font.Bold))
        Dim texto3 As New Phrase("Periodo Del Reporte:" + ComboBox_rc_mes.Text, New Font(Font.Name = "Tahoma", 14, Font.Bold))

        Dim rowFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 6, iTextSharp.text.Font.BOLD)


        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To Grid_informe_rc.ColumnCount - 1
            Dim HEADERCELLFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 8, iTextSharp.text.Font.BOLD)
            Dim cell_TITLE As New PdfPCell
            cell_TITLE.Phrase = New Phrase(Grid_informe_rc.Columns(i).HeaderText, HEADERCELLFont)
            cell_TITLE.HorizontalAlignment = Element.ALIGN_CENTER
            cell_TITLE.BackgroundColor = BaseColor.LIGHT_GRAY
            datatable.AddCell(cell_TITLE)
        Next

        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1
        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To Grid_informe_rc.RowCount - 1
            For j As Integer = 0 To Grid_informe_rc.ColumnCount - 1
                Dim cell As New PdfPCell

                cell.Phrase = New Phrase(Grid_informe_rc(j, i).FormattedValue.ToString, rowFont)

                If j = 0 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 1 Then cell.HorizontalAlignment = Element.ALIGN_CENTER
                If j = 2 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 3 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 4 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 5 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 6 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 7 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT

                cell.Border = 0
                cell.BorderWidthRight = 0.3F
                cell.BorderColorRight = BaseColor.BLACK
                datatable.AddCell(cell)
            Next
            datatable.CompleteRow()
        Next

        'Se agrega el PDFTable al documento.
        document.Add(encabezado)
        document.Add(encabezado2)
        document.Add(texto)
        document.Add(texto2)
        document.Add(texto2)


        document.Add(datatable)
    End Sub





    Private Sub MetroComboBox_mes_gastos_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles MetroComboBox_mes_ce.SelectionChangeCommitted

        mes_num = DateTime.ParseExact(Me.MetroComboBox_mes_ce.Text, "MMMM", CultureInfo.CurrentCulture).Month
        mes_num_text = CStr(mes_num)
        If mes_num <= 9 Then mes_num_text = "0" & CStr(mes_num)
        LOAD_gastoS_MES()
    End Sub
    Private Sub LOAD_gastoS_MES()
        Dim FECHA As String
        FECHA = mes_num_text & "/" & CStr(DateTime.Now.Year)

        Dim tipo_comp As String = ""

        tipo_comp = "recibos_egresos"

        Try
            sql = "SELECT Documento, Fecha, Doccliente as DocTercero, ClienteNom AS Tercero, Descripcion, referencia, valor, Concepto, CUENTA, MEDIODEPAGO, CUENTAPAGO, ESTADO FROM " & tipo_comp & " WHERE month(STR_TO_DATE(fecha,'%d/%m/%Y'))=" & mes_num_text & " AND YEAR(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & NumericUpDown_egresos.Value & "'"



            If CheckBox_comprobantes_ce.Checked = True And ComboBox_tipo_egreso.Text <> Nothing Then
                sql = "SELECT Documento, Fecha, Doccliente as DocTercero, ClienteNom as Tercero, Descripcion, referencia, valor, Concepto, CUENTA, MEDIODEPAGO, CUENTAPAGO, ESTADO FROM " & tipo_comp & " WHERE month(STR_TO_DATE(fecha,'%d/%m/%Y'))=" & mes_num_text & " and concepto='" & ComboBox_tipo_egreso.Text & "' AND YEAR(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & NumericUpDown_egresos.Value & "' ORDER BY cons ASC"
            End If


            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.Grid_informe_ce.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        total_ingresos = 0
        Try
            For i As Integer = 0 To Grid_informe_ce.RowCount - 1
                If Grid_informe_ce.Item("ESTADO", i).Value <> "ANULADO" Then
                    total_ingresos = total_ingresos + Grid_informe_ce.Item("VALOR", i).Value
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        Me.TextBox_total_gastos.Text = total_ingresos


        Grid_informe_ce.ClearSelection()



    End Sub
    Private Sub LOAD_gastoS_MES_grafico()
        Dim FECHA As String
        FECHA = mes_num_text & "/" & CStr(DateTime.Now.Year)
        Try
            sql = "SELECT documento, total FROM RECIBOS_EGRESOS WHERE substring(fecha,4,7)  = '" & FECHA & "' ORDER BY cons ASC"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.MetroGrid_gastos_graph.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

    End Sub
    Private Sub Button_exportar_gastos_Click(sender As Object, e As EventArgs) Handles Button_exportar_gastos.Click

        Try
            'sql = "SELECT * FROM gastos WHERE month(STR_TO_DATE(fecha,'%d/%m/%Y'))=" & mes_num_text & " ORDER BY cons ASC"
            If MetroComboBox_mes_ce.SelectedItem = Nothing Then sql = "SELECT Documento as Doc, Fecha, Doccliente as DocCliente, ClienteNom, concepto, referencia, valor, ESTADO FROM recibos_egresos ORDER BY cons ASC"
            If MetroComboBox_mes_ce.SelectedItem <> Nothing Then sql = "SELECT Documento as Doc, Fecha, Doccliente as DocCliente, ClienteNom, concepto, referencia, valor, ESTADO FROM recibos_egresos WHERE month(STR_TO_DATE(fecha,'%d/%m/%Y'))=" & mes_num_text & " ORDER BY cons ASC"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.Grid_informe_ce.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()





        Try
            'Intentar generar el documento.
            Dim doc As New Document(PageSize.A4.Rotate, 10, 10, 10, 10)
            'Path que guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Informe de Gastos.pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, file)
            doc.Open()
            ExportarDatosPDF_gastos(doc)
            doc.Close()
            Process.Start(filename)
        Catch ex As Exception
            'Si el intento es fallido, mostrar MsgBox.
            MessageBox.Show("No se puede generar el documento PDF, Cierre los documentos PDF generados anteriormente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub datagrid_VENTAS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_VENTAS.CellClick
        Dim row_VENTA As DataGridViewRow = grid_VENTAS.CurrentRow
        Try
            ID_VENTA_VER = CInt(row_VENTA.Cells("DOCUMENTO").Value)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub button_crear_Click(sender As Object, e As EventArgs) Handles button_crear.Click
        If ID_VENTA_VER <> "" Then
            If Form_verfactura.Visible = True Then Form_verfactura.BringToFront()
            Form_verfactura.Show(Me)
        End If
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs)
        If ver_cxc <> "" Then
            Form_verfactura.Show()
        End If
    End Sub
















    Private Sub MetroGrid_COMPRAS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid_COMPRAS.CellClick
        Dim row_compra As DataGridViewRow = Grid_COMPRAS.CurrentRow
        ID_compra_VER = CInt(row_compra.Cells("DOCUMENTO").Value)
    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click


        If ID_compra_VER <> "" Then
            FormPedidodeproveedor.Show()

        End If
        Grid_COMPRAS.ClearSelection()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        ID_compra_VER = ID_CXP_VER
        If ID_compra_VER <> "" Then
            FormPedidodeproveedor.Show()
        End If
    End Sub





    Private Sub Form_informes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress


    End Sub

    Private Sub Form_informes_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub



    Private Sub MetroComboBox_mes_gastos_SizeChanged(sender As Object, e As EventArgs) Handles MetroComboBox_mes_ce.SizeChanged

    End Sub

    Private Sub MetroGrid_COMPRAS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid_COMPRAS.CellContentClick

    End Sub

    Private Sub MetroComboBox_mes_general_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub Button_exportarCompras_Click(sender As Object, e As EventArgs) Handles Button_exportarCompras.Click

        If MetroCombo_MES_COMPRA.Text = "" And Combobox_FECHA_COMPRA.Text = "" Then
            MsgBox("Antes de exportar debe selecionar una fecha.", vbInformation) : Exit Sub
        End If

        If MetroCombo_MES_COMPRA.Text <> "" Then
            Try
                sql = "SELECT documento as Compra, doccliente as Documento, clientenom as Proveedor, Fecha, Observaciones, Total, mediodepago as MedioPago, estado FROM compras where month(STR_TO_DATE(fecha,'%d/%m/%Y'))=" & mes_num_text & " ORDER BY DOCUMENTO ASC"
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                da.Fill(dt)
                Me.Grid_COMPRAS.DataSource = dt

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da.Dispose()
            dt.Dispose()
            conex.Close()


            total_impuestos = 0
            total_ingresos = 0
            Try
                For i As Integer = 0 To Grid_COMPRAS.RowCount - 1
                    total_ingresos = total_ingresos + Grid_COMPRAS.Item("total", i).Value
                Next
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
            Me.TextBox_comprasbrutas.Text = total_ingresos
            Me.TextBox_comprasbrutas.Text = Format(CDec(Me.TextBox_comprasbrutas.Text), "##,##0")
        End If

        If Combobox_FECHA_COMPRA.Text <> "" Then
            Try
                sql = "select documento as Compra, doccliente as Documento, clientenom as Proveedor, Fecha, Observaciones, Total, mediodepago as MedioPago, estado as Estado from COMPRAS WHERE fecha='" & Me.Combobox_FECHA_COMPRA.Text & "'"
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                da.Fill(dt)
                Me.Grid_COMPRAS.DataSource = dt

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da.Dispose()
            dt.Dispose()
            conex.Close()

            total_impuestos = 0
            total_ingresos = 0
            Try
                For i As Integer = 0 To Grid_COMPRAS.RowCount - 1
                    total_ingresos = total_ingresos + Grid_COMPRAS.Item("total", i).Value
                Next
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
            Me.Label_totalcompras.Text = total_ingresos
            Me.Label_totalcompras.Text = Format(CDec(Me.Label_totalcompras.Text), "##,##0")
        End If

        Me.Grid_COMPRAS.Columns(0).HeaderText = "Compra"
        Me.Grid_COMPRAS.Columns(0).Width = 80
        Me.Grid_COMPRAS.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.Grid_COMPRAS.Columns(1).HeaderText = "Documento"
        Me.Grid_COMPRAS.Columns(1).Width = 80
        Me.Grid_COMPRAS.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.Grid_COMPRAS.Columns(2).HeaderText = "Proveedor"
        Me.Grid_COMPRAS.Columns(2).Width = 80
        Me.Grid_COMPRAS.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.Grid_COMPRAS.Columns(3).HeaderText = "Fecha"
        Me.Grid_COMPRAS.Columns(3).Width = 80
        Me.Grid_COMPRAS.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.Grid_COMPRAS.Columns(4).HeaderText = "Observaciones"
        Me.Grid_COMPRAS.Columns(4).Width = 80
        Me.Grid_COMPRAS.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.Grid_COMPRAS.Columns(5).HeaderText = "Total"
        Me.Grid_COMPRAS.Columns(5).Width = 80
        Me.Grid_COMPRAS.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.Grid_COMPRAS.Columns(6).HeaderText = "Medio de Pago"
        Me.Grid_COMPRAS.Columns(6).Width = 80
        Me.Grid_COMPRAS.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.Grid_COMPRAS.Columns(7).HeaderText = "Estado"
        Me.Grid_COMPRAS.Columns(7).Width = 80
        Me.Grid_COMPRAS.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft



        Try
            'Intentar generar el documento.
            Dim doc As New Document(PageSize.A4.Rotate, 20, 10, 10, 20)
            'Path que guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Informe de Ventas.pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, file)
            doc.Open()
            ExportarDatosPDF_compras(doc)
            doc.Close()
            Process.Start(filename)
        Catch ex As Exception
            'Si el intento es fallido, mostrar MsgBox.
            MessageBox.Show("No se puede generar el documento PDF, Cierre los documentos PDF generados anteriormente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



        LOAD_COMPRAS_MES()

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub Button_VER_GRAFICO_COMPRAS_Click(sender As Object, e As EventArgs)
        If Grid_COMPRAS.Visible = True Then Grid_COMPRAS.Visible = False : Exit Sub

        If Grid_COMPRAS.Visible = False Then Grid_COMPRAS.Visible = True : Grid_COMPRAS.BringToFront() : Exit Sub
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If ID_gasto_VER <> "" Then
            Form_ce.Show()
        End If
    End Sub

    Private Sub MetroGrid_gastos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid_informe_ce.CellContentClick

    End Sub

    Private Sub MetroGrid_gastos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid_informe_ce.CellClick
        Dim row_gasto As DataGridViewRow = Grid_informe_ce.CurrentRow
        ID_gasto_VER = CInt(row_gasto.Cells("DOCUMENTO").Value)
    End Sub




    Private Sub MetroTabPage10_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub MetroGrid_egresos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub





    Private Sub MetroGrid_imp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub



    Private Sub Panel_titlebar_Paint(sender As Object, e As PaintEventArgs) Handles Panel_titlebar.Paint

    End Sub




    Private Sub COMBOBOX_FECHA_VENTAS_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles COMBOBOX_FECHA_VENTAS.SelectionChangeCommitted
        'GRID_FECHA_VENTAS()
        reportando_que = "Fecha: " & COMBOBOX_FECHA_VENTAS.Text

        LOAD_VENTAS_MES()


    End Sub

    Private Sub COMBOBOX_FECHA_VENTAS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMBOBOX_FECHA_VENTAS.SelectedIndexChanged

    End Sub

    Private Sub Chart_general_Click(sender As Object, e As EventArgs) Handles Chart_general.Click

    End Sub

    Private Sub Button_tab1_Click(sender As Object, e As EventArgs)
        Me.MetroTabPage_ventas.Hide()
        Me.MetroTabPage_compras.Hide()
        Me.MetroTabPage_egresos.Hide()
        Me.MetroTabPage_rc.Hide()

        'MetroTabPage2.Parent = Nothing

        Me.MetroTabPage_general.Show()
        Me.MetroTabPage_general.Parent = Me.MetroTab_informes
        MetroTab_informes.SelectTab(0)
    End Sub



    Private Sub Timer_load_Tick(sender As Object, e As EventArgs) Handles Timer_load.Tick
        Timer_load.Enabled = False

        mes_num = ComboBox_periodo_general.SelectedIndex + 1
        mes_num_text_general = CStr(mes_num)
        If mes_num <= 9 Then mes_num_text_general = "0" & CStr(mes_num)




        ' llenar combo con ctas de cajas y bancos luego hacer un for que lo recorra y sume los saldos para totalizar
        'caja y bancos
        Label5.Text = 0
        Try
            sql = "select cajasybancos.cons, cajasybancos.nombre, IFNULL(SUM(cajaspuc.DEBE)-SUM(cajaspuc.HABER),0) As SALDO 
from cajasybancos
left join cajaspuc on cajasybancos.cons=cajaspuc.codcuenta group by cajasybancos.cons"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows

                Label5.Text = CInt(Label5.Text) + CInt(row.Item("saldo"))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        Me.Label5.Text = Format(CDec(Me.Label5.Text), "##,##0.00")




        'costo inventario desde BODEGA
        Label_costo_inv.Text = 0
        Try
            sql = "SELECT nombrebodega from BODEGAs"

            Da_bods = New MySqlDataAdapter(sql, conex)
            dt_bods = New DataTable
            da_bods.Fill(dt_bods)
            For Each rowb As DataRow In dt_bods.Rows
                Dim bod_nom = rowb.Item("nombrebodega")

                Try
                    sql = "SELECT B.CodProducto, P.Categoria, concat(p.NOMBRE,' ',p.ref,' ',p.presentacion) as nombre, 
replace(replace(replace(format(sum(B.entran)-sum(B.salen),2),'.',':'),',','.'),':',',') as Saldo, P.Presentacion, 
replace(replace(replace(format(avg(B.COSTO),2),'.',':'),',','.'),':',',') AS Costo, 
replace(replace(replace(format((sum(B.entran)-sum(B.salen))*(avg(B.COSTO)),2),'.',':'),',','.'),':',',') as CostoTotal,
p.Valor, p.valor2, p.valor3,
p.Stock, p.Sugerido, P.Maximo, B.Lote, b.Vence
FROM bodega_" & bod_nom & " B, PRODUCTOS P
WHERE B.CODPRODUCTO=P.COD GROUP BY B.CODPRODUCTO, B.LOTE order by saldo"
                    da = New MySqlDataAdapter(sql, conex)
                    dt = New DataTable
                    da.Fill(dt)
                    For Each row As DataRow In dt.Rows
                        Label_costo_inv.Text = CInt(Label_costo_inv.Text) + CInt(row.Item("CostoTotal"))
                    Next

                Catch ex As Exception
                End Try
                da.Dispose()
                dt.Dispose()
                conex.Close()

            Next
        Catch ex As Exception
        End Try

        da_bods.Dispose()
        dt_bods.Dispose()
        conex.Close()
        Me.Label_costo_inv.Text = Format(CDec(Me.Label_costo_inv.Text), "##,##0.00")





        '        Try
        '            sql = "SELECT
        'convert(CONVERT(REPLACE(CAST(B.COSTO AS CHAR),',','.'),decimal(12,2)) * IF(B.DECI='SI', sum(CAST(CONVERT(REPLACE(CAST(B.entran AS CHAR),',','.'),decimal(12,2)) AS DECIMAL(12,2)))-sum(CAST(CONVERT(REPLACE(CAST(B.SALEN AS CHAR),',','.'),decimal(12,2)) AS DECIMAL(12,2))), sum(CAST(B.entran AS CHAR))-sum(CAST(B.SALEN AS CHAR))),decimal(12,2)) as Total
        'FROM bodega_" & comex_bodega_ventas & " B, PRODUCTOS P
        'WHERE B.CODPRODUCTO=P.COD GROUP BY B.CODPRODUCTO, B.LOTE"

        '            da_BODEGAS = New MySqlDataAdapter(sql, conex)
        '            dt_BODEGAS = New DataTable
        '            da_BODEGAS.Fill(dt_BODEGAS)
        '            Me.MetroGrid_costoinv.DataSource = dt_BODEGAS

        '        Catch ex As Exception
        '            MsgBox(ex.Message)
        '            conex.Close()
        '            da.Dispose()
        '            dt_BODEGAS.Dispose()
        '        End Try
        '        conex.Close()
        '        da_BODEGAS.Dispose()
        '        dt_BODEGAS.Dispose()
        '        Me.MetroGrid_costoinv.ClearSelection()
        '        Label_costo_inv.Text = 0
        '        For Each fila As DataGridViewRow In MetroGrid_costoinv.Rows
        '            Label_costo_inv.Text = CInt(Label_costo_inv.Text) + CInt(fila.Cells("total").Value.ToString)
        '        Next
        '        Me.Label_costo_inv.Text = Format(CDec(Me.Label_costo_inv.Text), "##,##0.00")






        '=========================================================================================================================
        'VENTAS
        Try
            sql = "Select sum(total) as total from ventas where estado='DESCARGADO' and month(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & mes_num_text_general & "' and year(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & NumericUpDown_anno_general.Value & "'"
            Da_ventas_informe = New MySqlDataAdapter(sql, conex)
            DT_ventas_informe = New DataTable
            Da_ventas_informe.Fill(DT_ventas_informe)
            Me.MetroGrid_TOTAL_VENTAS.DataSource = DT_ventas_informe

            Me.Label_TOTALVENTAS.Text = "0"
            If Not IsDBNull(MetroGrid_TOTAL_VENTAS.Item("total", 0).Value) Then
                Try
                    For i As Integer = 0 To MetroGrid_TOTAL_VENTAS.RowCount - 1
                        Dim tt As String
                        tt = Convert.ToString(MetroGrid_TOTAL_VENTAS.Item("total", i).Value)
                        If tt = "" Then tt = 0
                        Me.Label_TOTALVENTAS.Text = CInt(Me.Label_TOTALVENTAS.Text) + CInt(tt)
                    Next
                    Me.Label_TOTALVENTAS.Text = Format(CDec(Me.Label_TOTALVENTAS.Text), "##,##0")

                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            conex.Close()
            Da_ventas_informe.Dispose()
            DT_ventas_informe.Dispose()
        End Try
        conex.Close()
        Da_ventas_informe.Dispose()
        DT_ventas_informe.Dispose()

        Me.Label_TOTALVENTAS.Text = Format(CDec(Me.Label_TOTALVENTAS.Text), "##,##0.00")

        '=========================================================================================================================
        'cartera
        Label_total_cxc.Text = 0
        Try
            sql = "SELECT * from carteracredito where tipo='CARTERA' AND MONTH(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & mes_num_text_general & "' AND YEAR(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & NumericUpDown_anno_general.Value & "'"
            Da_Cartera_GRID_informe = New MySqlDataAdapter(sql, conex)
            DT_cartera_GRID_informe = New DataTable
            Da_Cartera_GRID_informe.Fill(DT_cartera_GRID_informe)
            Me.MetroGrid_totalcxc.DataSource = DT_cartera_GRID_informe
            Me.MetroGrid_totalcxc.Columns(0).Visible = False
            Me.MetroGrid_totalcxc.Columns(2).Visible = False
            Me.MetroGrid_totalcxc.Columns(3).Visible = False

            Me.MetroGrid_totalcxc.Columns(6).Visible = False
            Me.MetroGrid_totalcxc.Columns(7).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
            conex.Close()
            Da_Cartera_GRID_informe.Dispose()
            DT_cartera_GRID_informe.Dispose()
        End Try
        conex.Close()
        Da_Cartera_GRID_informe.Dispose()
        DT_cartera_GRID_informe.Dispose()

        MetroGrid_totalcxc.ClearSelection()

        For i As Integer = 0 To MetroGrid_totalcxc.RowCount - 1
            If MetroGrid_totalcxc.Item("ESTADO", i).Value = "PENDIENTE" Then
                Label_total_cxc.Text = CInt(Label_total_cxc.Text) + MetroGrid_totalcxc.Item("SALDO", i).Value

            End If
        Next
        Me.Label_total_cxc.Text = Format(CDec(Me.Label_total_cxc.Text), "##,##0.00")


        '=========================================================================================================================
        'compras
        Try
            sql = "Select sum(CAST(total AS SIGNED)) as total from compras where estado='DESCARGADO' and month(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & mes_num_text_general & "' and year(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & NumericUpDown_anno_general.Value & "'"
            Da_compras_informe = New MySqlDataAdapter(sql, conex)
            DT_compras_informe = New DataTable
            Da_compras_informe.Fill(DT_compras_informe)
            Me.MetroGrid_totalcompras.DataSource = DT_compras_informe
        Catch ex As Exception
            MsgBox(ex.Message)
            conex.Close()
            Da_compras_informe.Dispose()
            DT_compras_informe.Dispose()
        End Try
        conex.Close()
        Da_compras_informe.Dispose()
        DT_compras_informe.Dispose()

        Me.Label_totalcompras.Text = "0"
        If Not IsDBNull(MetroGrid_totalcompras.Item("total", 0).Value) Then
            Try
                For i As Integer = 0 To MetroGrid_totalcompras.RowCount - 1
                    Dim tt As String
                    tt = Convert.ToString(MetroGrid_totalcompras.Item("total", i).Value)
                    If tt = "" Then tt = 0
                    Me.Label_totalcompras.Text = CInt(Me.Label_totalcompras.Text) + CInt(tt)

                Next
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End If
        Me.Label_totalcompras.Text = Format(CDec(Me.Label_totalcompras.Text), "##,##0.00")


        '=========================================================================================================================
        'CREDITO

        Label_total_cxp.Text = 0
        Try
            sql = "SELECT * from carteracredito where tipo='CREDITO' and MONTH(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & mes_num_text_general & "' AND YEAR(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & NumericUpDown_anno_general.Value & "'"
            Da_CREDITO_GRID_informe = New MySqlDataAdapter(sql, conex)
            DT_CREDITO_GRID_informe = New DataTable
            Da_CREDITO_GRID_informe.Fill(DT_CREDITO_GRID_informe)
            Me.MetroGrid_totalcxp.DataSource = DT_CREDITO_GRID_informe
            Me.MetroGrid_totalcxp.Columns(0).Visible = False
            Me.MetroGrid_totalcxp.Columns(2).Visible = False
            Me.MetroGrid_totalcxp.Columns(3).Visible = False

            Me.MetroGrid_totalcxp.Columns(6).Visible = False
            Me.MetroGrid_totalcxp.Columns(7).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
            conex.Close()
            Da_CREDITO_GRID_informe.Dispose()
            DT_CREDITO_GRID_informe.Dispose()
        End Try
        conex.Close()
        Da_CREDITO_GRID_informe.Dispose()
        DT_CREDITO_GRID_informe.Dispose()

        MetroGrid_totalcxp.ClearSelection()

        For i As Integer = 0 To MetroGrid_totalcxp.RowCount - 1
            If MetroGrid_totalcxp.Item("ESTADO", i).Value = "PENDIENTE" Then
                Label_total_cxp.Text = CInt(Label_total_cxp.Text) + MetroGrid_totalcxp.Item("SALDO", i).Value

            End If
        Next
        Me.Label_total_cxp.Text = Format(CDec(Me.Label_total_cxp.Text), "##,##0.00")



        '=========================================================================================================================
        'EGRESOS   
        Try
            sql = "SELECT if(cons<>0,'EGRESOS','EGRESOS') AS COMPROBANTE, concepto, VALOR AS VALOR, if(cons<>0,'0','0') AS DESCUENTO, ESTADO 
FROM recibos_EGRESOS
WHERE month(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & mes_num_text_general & "' AND YEAR(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & NumericUpDown_anno_general.Value & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.MetroGrid_totalgastos.DataSource = dt
            da.Dispose()
            dt.Dispose()
            conex.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Label_total_gastos.Text = "0"
        Try
            For i As Integer = 0 To MetroGrid_totalgastos.RowCount - 1
                If MetroGrid_totalgastos.Item("estado", i).Value <> "ANULADO" And MetroGrid_totalgastos.Item("comprobante", i).Value = "GASTOS" Then
                    Label_total_gastos.Text = CInt(Label_total_gastos.Text) + CInt(MetroGrid_totalgastos.Item("VALOR", i).Value)
                End If
                If MetroGrid_totalgastos.Item("estado", i).Value <> "ANULADO" And MetroGrid_totalgastos.Item("comprobante", i).Value = "EGRESOS" Then
                    Label_total_gastos.Text = CInt(Label_total_gastos.Text) + CInt(MetroGrid_totalgastos.Item("VALOR", i).Value)
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        Me.Label_total_gastos.Text = Format(CDec(Me.Label_total_gastos.Text), "##,##0.00")




        'costo de ventas y utilidad

        Me.Label_utilidad.Text = "0"
        Label_costoVentas.Text = "0"

        Try
            sql = "select sum(VENTAS_PRODS.costo) AS costo from ventas left join ventas_prods on ventas.documento=ventas_prods.documento
where ventas.estado<>'ANULADA' AND month(STR_TO_DATE(ventas.fecha,'%d/%m/%Y'))='" & mes_num_text_general & "' AND YEAR(STR_TO_DATE(ventas.fecha,'%d/%m/%Y'))='" & NumericUpDown_anno_general.Value & "';"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox_costoVentas.Text = 0

            For Each row As DataRow In dt.Rows
                If Not IsDBNull(CInt(row.Item("costo").ToString)) Then
                    Label_costoVentas.Text = CInt(Label_costoVentas.Text) + CInt(row.Item("costo").ToString)
                End If
            Next
        Catch ex As Exception

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        ' utilidad ventas
        Me.Label_utilidad.Text = CInt(Label_TOTALVENTAS.Text) - CInt(Me.Label_costoVentas.Text)

        Me.Label_costoVentas.Text = Format(CDec(Me.Label_costoVentas.Text), "##,##0.00")

        Me.Label_utilidad.Text = Format(CDec(Me.Label_utilidad.Text), "##,##0.00")



        Try
            Chart_general.Series.Clear()
            Chart_general.Series.Add("Ventas")
            Chart_general.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column

            Chart_general.Series(0).Points.AddXY("Ventas", CInt(Label_TOTALVENTAS.Text))

            Chart_general.Series.Add("Costo de Ventas")
            Chart_general.Series(1).Points.AddXY("Costo de Ventas", CInt(Label_costoVentas.Text))

            Chart_general.Series.Add("Compras")
            Chart_general.Series(2).Points.AddXY("Compras", CInt(Label_totalcompras.Text))

            Chart_general.Series.Add("Gastos")
            Chart_general.Series(3).Points.AddXY("Gastos", CInt(Label_total_gastos.Text))

            Chart_general.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try


        Try
            sql = "SELECT documento, nombre FROM proveedores order by nombre"

            da_contact_filtro = New MySqlDataAdapter(sql, conex)
            dt_contact_filtro = New DataTable
            da_contact_filtro.Fill(dt_contact_filtro)
            Me.MetroComboBox2.DataSource = dt_contact_filtro.DefaultView
            Me.MetroComboBox2.DisplayMember = "nombre"
            Me.MetroComboBox2.ValueMember = "documento"
            Me.MetroComboBox2.AutoCompleteSource = AutoCompleteSource.ListItems
            Me.MetroComboBox2.AutoCompleteMode = AutoCompleteMode.Suggest
            Me.MetroComboBox2.SelectedItem = Nothing

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_contact_filtro.Dispose()
        dt_contact_filtro.Dispose()
        conex.Close()

        MetroComboBox2.SelectedIndex = -1

        Button_tab1_Click(Nothing, Nothing)




    End Sub

    Private Sub Label41_Click(sender As Object, e As EventArgs) Handles Label41.Click

    End Sub

    Private Sub CheckBox_comprobantes_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_comprobantes_ce.CheckedChanged

        If CheckBox_comprobantes_ce.Checked = False Then
            ComboBox_tipo_egreso.SelectedItem = Nothing
            ComboBox_tipo_egreso.Enabled = False
        End If

        If CheckBox_comprobantes_ce.Checked = True Then
            ComboBox_tipo_egreso.Enabled = True
            'conceptos de egresos
            Try
                sql = "SELECT cons, documento, CUENTA1 from data_docs where estado='SI' and CODIGO IN('CE','CG') AND padre='NO'"

                da_combo_inf_egreso = New MySqlDataAdapter(sql, conex)
                dt_combo_inf_egreso = New DataTable
                da_combo_inf_egreso.Fill(dt_combo_inf_egreso)
                Me.ComboBox_tipo_egreso.DataSource = dt_combo_inf_egreso.DefaultView
                Me.ComboBox_tipo_egreso.DisplayMember = "DOCUMENTO"
                Me.ComboBox_tipo_egreso.ValueMember = "CONS"
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da_combo_inf_egreso.Dispose()
            dt_combo_inf_egreso.Dispose()
            conex.Close()

            ComboBox_tipo_egreso.SelectedItem = Nothing
        End If

    End Sub

    Private Sub ComboBox_tipo_egreso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_tipo_egreso.SelectedIndexChanged

    End Sub

    Private Sub ComboBox_tipo_egreso_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_tipo_egreso.SelectionChangeCommitted


        If MetroComboBox_mes_ce.Text = Nothing Then Exit Sub


        mes_num = DateTime.ParseExact(Me.MetroComboBox_mes_ce.Text, "MMMM", CultureInfo.CurrentCulture).Month
        mes_num_text = CStr(mes_num)
        If mes_num <= 9 Then mes_num_text = "0" & CStr(mes_num)
        LOAD_gastoS_MES()
    End Sub

    Private Sub TextBox_total_ventas_butas_TextChanged(sender As Object, e As EventArgs) Handles TextBox_total_ventas_butas.TextChanged

    End Sub

    Private Sub TextBox_total_ventas_butas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_total_ventas_butas.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub TextBox_ventas_anuladas_TextChanged(sender As Object, e As EventArgs) Handles TextBox_ventas_anuladas.TextChanged

    End Sub

    Private Sub TextBox_ventas_anuladas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_ventas_anuladas.KeyPress
        e.KeyChar = ""

    End Sub

    Private Sub TextBox_ventas_devoluciones_TextChanged(sender As Object, e As EventArgs) Handles TextBox_ventas_devoluciones.TextChanged

    End Sub

    Private Sub TextBox_ventas_devoluciones_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_ventas_devoluciones.KeyPress
        e.KeyChar = ""

    End Sub

    Private Sub TextBox_ventas_descuentos_TextChanged(sender As Object, e As EventArgs) Handles TextBox_ventas_descuentos.TextChanged

    End Sub

    Private Sub TextBox_ventas_descuentos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_ventas_descuentos.KeyPress
        e.KeyChar = ""

    End Sub

    Private Sub TextBox_ventas_impuestos_TextChanged(sender As Object, e As EventArgs) Handles TextBox_ventas_impuestos.TextChanged

    End Sub

    Private Sub TextBox_ventas_impuestos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_ventas_impuestos.KeyPress
        e.KeyChar = ""

    End Sub

    Private Sub TextBox_ventas_netas_TextChanged(sender As Object, e As EventArgs) Handles TextBox_ventas_netas.TextChanged

    End Sub

    Private Sub TextBox_ventas_netas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_ventas_netas.KeyPress
        e.KeyChar = ""

    End Sub



    Private Sub ComboBox_rc_mes_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_rc_mes.SelectionChangeCommitted
        mes_num = DateTime.ParseExact(Me.ComboBox_rc_mes.Text, "MMMM", CultureInfo.CurrentCulture).Month
        mes_num_text = CStr(mes_num)
        If mes_num <= 9 Then mes_num_text = "0" & CStr(mes_num)
        LOAD_rc_MES()
    End Sub

    Private Sub ComboBox_rc_mes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_rc_mes.SelectedIndexChanged

    End Sub
    Private Sub LOAD_rc_MES()
        Dim FECHA As String
        FECHA = mes_num_text & "/" & CStr(DateTime.Now.Year)

        Dim tipo_comp As String = ""

        tipo_comp = "recibos_caja"

        Try
            sql = "SELECT Documento, Fecha, Doccliente as DocTercero, ClienteNom as Tercero, Descripcion, referencia as Referfencia, valor as Valor, Concepto, Cuenta, MediodePago, CuentaPago FROM " & tipo_comp & " WHERE month(STR_TO_DATE(fecha,'%d/%m/%Y'))=" & mes_num_text & " AND YEAR(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & NumericUpDown_rc.Value & "'"
            If CheckBox_comprobantes_rc.Checked = True And ComboBox_tipo_ingreso.Text <> Nothing Then
                sql = "SELECT Documento, Fecha, Doccliente as DocTercero, ClienteNom as Tercero, Descripcion, referencia as Referfencia, valor as Valor, Concepto, Cuenta, Mediodepago, CuentaPago FROM " & tipo_comp & " WHERE month(STR_TO_DATE(fecha,'%d/%m/%Y'))=" & mes_num_text & " and concepto='" & ComboBox_tipo_ingreso.Text & "' AND YEAR(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & NumericUpDown_rc.Value & "' ORDER BY cons ASC"
            End If
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.Grid_informe_rc.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        total_ingresos = 0
        Try
            For i As Integer = 0 To Grid_informe_rc.RowCount - 1
                total_ingresos = total_ingresos + Grid_informe_rc.Item("VALOR", i).Value
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        Me.TextBox_rc.Text = total_ingresos

        Grid_informe_rc.ClearSelection()

    End Sub

    Private Sub Grid_informe_rc_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid_informe_rc.CellContentClick

    End Sub

    Private Sub Grid_informe_rc_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid_informe_rc.CellClick
        Dim row_rc As DataGridViewRow = Grid_informe_rc.CurrentRow
        ID_rc_VER = CInt(row_rc.Cells("DOCUMENTO").Value)
    End Sub

    Private Sub Button_ver_rc_Click(sender As Object, e As EventArgs) Handles Button_ver_rc.Click
        If ID_rc_VER <> "" Then
            Form_rc.Show()
        End If
    End Sub

    Private Sub Button_exportar_rc_list_Click(sender As Object, e As EventArgs) Handles Button_exportar_rc_list.Click




        Try
            'Intentar generar el documento.
            Dim doc As New Document(PageSize.A4.Rotate, 10, 10, 10, 10)
            'Path que guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Informe de Recibos de Caja.pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, file)
            doc.Open()
            ExportarDatosPDF_RC(doc)
            doc.Close()
            Process.Start(filename)
        Catch ex As Exception
            'Si el intento es fallido, mostrar MsgBox.
            MessageBox.Show("No se puede generar el documento PDF, Cierre los documentos PDF generados anteriormente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroComboBox_mes_ce_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroComboBox_mes_ce.SelectedIndexChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_comprobantes_rc.CheckedChanged
        If CheckBox_comprobantes_rc.Checked = False Then
            ComboBox_tipo_ingreso.SelectedItem = Nothing
            ComboBox_tipo_ingreso.Enabled = False
        End If

        If CheckBox_comprobantes_rc.Checked = True Then
            ComboBox_tipo_ingreso.Enabled = True
            'conceptos de egresos
            Try
                sql = "SELECT cons, documento, CUENTA1 from data_docs where estado='SI' and CODIGO IN('RC') AND padre='NO'"

                da_combo_inf_ingreso = New MySqlDataAdapter(sql, conex)
                dt_combo_inf_ingreso = New DataTable
                da_combo_inf_ingreso.Fill(dt_combo_inf_ingreso)
                Me.ComboBox_tipo_ingreso.DataSource = dt_combo_inf_ingreso.DefaultView
                Me.ComboBox_tipo_ingreso.DisplayMember = "DOCUMENTO"
                Me.ComboBox_tipo_ingreso.ValueMember = "CONS"
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da_combo_inf_ingreso.Dispose()
            dt_combo_inf_ingreso.Dispose()
            conex.Close()

            ComboBox_tipo_ingreso.SelectedItem = Nothing
        End If
    End Sub

    Private Sub ComboBox_tipo_ingreso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_tipo_ingreso.SelectedIndexChanged

    End Sub

    Private Sub ComboBox_tipo_ingreso_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_tipo_ingreso.SelectionChangeCommitted

        If ComboBox_rc_mes.Text = "" Then Exit Sub

        mes_num = DateTime.ParseExact(Me.ComboBox_rc_mes.Text, "MMMM", CultureInfo.CurrentCulture).Month
        mes_num_text = CStr(mes_num)
        If mes_num <= 9 Then mes_num_text = "0" & CStr(mes_num)

        LOAD_rc_MES()

    End Sub

    Private Sub ComboBox_tipo_egreso_SizeChanged(sender As Object, e As EventArgs) Handles ComboBox_tipo_egreso.SizeChanged

    End Sub

    Private Sub MetroCombo_MES_COMPRA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroCombo_MES_COMPRA.SelectedIndexChanged

    End Sub

    Private Sub Combo_mesVentas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_mesVentas.SelectedIndexChanged

    End Sub

    Private Sub Combobox_FECHA_COMPRA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combobox_FECHA_COMPRA.SelectedIndexChanged

    End Sub

    Private Sub Form_informes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub grid_VENTAS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_VENTAS.CellContentClick

    End Sub

    Private Sub TextBox_costoVentas_TextChanged(sender As Object, e As EventArgs) Handles TextBox_costoVentas.TextChanged

    End Sub

    Private Sub TextBox_costoVentas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_costoVentas.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub ComboBox_periodo_general_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_periodo_general.SelectedIndexChanged

    End Sub

    Private Sub ComboBox_periodo_general_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_periodo_general.SelectionChangeCommitted
        Timer_load.Enabled = True
    End Sub

    Private Sub MetroComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroComboBox2.SelectedIndexChanged

    End Sub

    Private Sub MetroComboBox2_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles MetroComboBox2.SelectionChangeCommitted



        filtrar_cliente = "SI"

        LOAD_VENTAS_MES()

    End Sub

    Private Sub MetroTab_informes_DrawItem(sender As Object, e As DrawItemEventArgs) Handles MetroTab_informes.DrawItem

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer_load.Enabled = False
        Timer1.Enabled = False

        MetroTab_informes.SelectTab(MetroTabPage_ventas)
        NumericUpDown_anoventa.Value = DateTime.Now.Year()
        Combo_mesVentas.SelectedIndex = DateTime.Now.Month - 1
        Combo_mesVentas_SelectionChangeCommitted(Nothing, Nothing)
        Thread.Sleep(2000)

        COMBOBOX_FECHA_VENTAS.SelectedItem = DateTime.Now.ToShortDateString.ToString
        COMBOBOX_FECHA_VENTAS_SelectionChangeCommitted(Nothing, Nothing)

        Thread.Sleep(1000)

        COMBOBOX_FECHA_VENTAS_SelectionChangeCommitted(Nothing, Nothing)
    End Sub

    Private Sub Form_informes_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged

    End Sub

    Private Sub NumericUpDown_anoventa_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_anoventa.ValueChanged

    End Sub

    Private Sub Combo_mesVentas_SelectedValueChanged(sender As Object, e As EventArgs) Handles Combo_mesVentas.SelectedValueChanged

    End Sub
End Class