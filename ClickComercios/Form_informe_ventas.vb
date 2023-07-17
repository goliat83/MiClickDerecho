Imports System.Globalization
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class Form_informe_ventas
    Dim mes_num As Integer
    Dim mes_num_text As String
    Dim mes_num_text_general As String
    Dim reportando_que As String = ""

    Private Sub Combo_mesVentas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_mesVentas.SelectedIndexChanged

    End Sub

    Private Sub Combo_mesVentas_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Combo_mesVentas.SelectionChangeCommitted
        mes_num = DateTime.ParseExact(Me.Combo_mesVentas.Text, "MMMM", CultureInfo.CurrentCulture).Month
        mes_num_text = CStr(mes_num)
        If mes_num <= 9 Then mes_num_text = "0" & CStr(mes_num)
        LOAD_VENTAS_MES()


        reportando_que = Combo_mesVentas.Text

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


    Private Sub COMBOBOX_FECHA_VENTAS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMBOBOX_FECHA_VENTAS.SelectedIndexChanged

    End Sub

    Private Sub COMBOBOX_FECHA_VENTAS_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles COMBOBOX_FECHA_VENTAS.SelectionChangeCommitted
        'GRID_FECHA_VENTAS()
        reportando_que = "Fecha: " & COMBOBOX_FECHA_VENTAS.Text

        LOAD_VENTAS_MES()
    End Sub

    Private Sub LOAD_VENTAS_MES()
        Dim FECHA As String
        FECHA = mes_num_text & "/" & CStr(DateTime.Now.Year)
        Try
            ' si debe generar informe por periodo
            If reportando_que.Contains("Fecha:") = False Then sql = "SELECT DOCUMENTO, DOCCLIENTE, CLIENTENOM, FECHA, TOTALVENTA, DESCUENTO, baseimpuesto, IMPUESTO, impuesto2, TOTAL, MEDIODEPAGO, EMPLEADO, ESTADO 
FROM VENTAS where month(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & mes_num_text & "' AND YEAR(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & NumericUpDown_anoventa.Value & "' ORDER BY DOCUMENTO ASC"

            ' si debe generar informe por fecha
            If reportando_que.Contains("Fecha:") = True Then sql = "select DOCUMENTO, DOCCLIENTE, CLIENTENOM, FECHA, TOTALVENTA, DESCUENTO, baseimpuesto, IMPUESTO, impuesto2, TOTAL, MEDIODEPAGO, EMPLEADO, ESTADO 
from VENTAS WHERE FECHA='" & Me.COMBOBOX_FECHA_VENTAS.Text & "' AND YEAR(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & NumericUpDown_anoventa.Value & "'"


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
            Me.grid_VENTAS.Columns(12).HeaderText = "Estado"
            Me.grid_VENTAS.Columns(12).Width = 100
            Me.grid_VENTAS.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        TextBox_total_ventas_butas.Text = 0
        TextBox_ventas_anuladas.Text = 0
        TextBox_ventas_netas.Text = 0

        Try
            For i As Integer = 0 To grid_VENTAS.RowCount - 1
                TextBox_total_ventas_butas.Text = CInt(TextBox_total_ventas_butas.Text) + CInt(grid_VENTAS.Item("total", i).Value)

                If grid_VENTAS.Item("ESTADO", i).Value = "ANULADA" Then
                    grid_VENTAS.DefaultCellStyle.BackColor = Color.IndianRed
                    TextBox_ventas_anuladas.Text = CInt(TextBox_ventas_anuladas.Text) + CInt(grid_VENTAS.Item("total", i).Value)
                End If


            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        Try
            If reportando_que.Contains("Fecha:") = True Then sql = "SELECT codcuenta, cuenta, sum(DEBE)-sum(HABER) as saldo FROM cajaspuc WHERE LEFT(CODCUENTA,4)='4175' and FECHA='" & COMBOBOX_FECHA_VENTAS.Text & "' AND YEAR(STR_TO_DATE(ventas.fecha,'%d/%m/%Y'))='" & NumericUpDown_anoventa.Value & "'"
            If reportando_que.Contains("Fecha:") = False Then sql = "SELECT codcuenta, cuenta, sum(DEBE)-sum(HABER) as saldo FROM cajaspuc WHERE LEFT(CODCUENTA,4)='4175' and month(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & mes_num_text & "' AND YEAR(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & NumericUpDown_anoventa.Value & "'"

            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            TextBox_ventas_devoluciones.Text = 0

            For Each row As DataRow In dt.Rows
                If Not IsDBNull(CInt(row.Item("saldo").ToString)) Then
                    TextBox_ventas_devoluciones.Text = CInt(row.Item("saldo"))
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
VENTAS.FECHA='" & COMBOBOX_FECHA_VENTAS.Text & "' AND YEAR(STR_TO_DATE(ventas.fecha,'%d/%m/%Y'))='" & NumericUpDown_anoventa.Value & "'"
            If reportando_que.Contains("Fecha:") = False Then sql = "sELECT ifnull(min(documento),0) as facini, ifnull(max(documento),0) as facfinal, ifnull(count(documento),0) as facn FROM ventas WHERE 
month(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & mes_num_text & "' AND YEAR(STR_TO_DATE(ventas.fecha,'%d/%m/%Y'))='" & NumericUpDown_anoventa.Value & "'"
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
            If reportando_que.Contains("Fecha:") = False Then sql = "SELECT  ventas_prods.ImpNom2 as Impuesto, FORMAT(sum(ventas_prods.valortotal-ventas_prods.impuesto2),0) as Base, FORMAT(sum(ventas_prods.impuesto2),0) as Valor, FORMAT(sum(ventas_prods.valortotal),0) as Total
FROM ventas_prods 
left join ventas on ventas_prods.documento=ventas.documento
where month(STR_TO_DATE(ventas.fecha,'%d/%m/%Y'))='" & mes_num_text & "' AND YEAR(STR_TO_DATE(ventas.fecha,'%d/%m/%Y'))='" & NumericUpDown_anoventa.Value & "' 
and ventas.estado<>'ANULADA'
group by ventas_prods.impnom2"
            If reportando_que.Contains("Fecha:") = True Then sql = "SELECT  ventas_prods.ImpNom2 as Impuesto, FORMAT(sum(ventas_prods.valortotal-ventas_prods.impuesto2),0) as Base, FORMAT(sum(ventas_prods.impuesto2),0) as Valor, FORMAT(sum(ventas_prods.valortotal),0) as Total
FROM ventas_prods
left join ventas on ventas_prods.documento=ventas.documento
where devoluciones.FECHA='" & Me.COMBOBOX_FECHA_VENTAS.Text & "' AND YEAR(STR_TO_DATE(devoluciones.fecha,'%d/%m/%Y'))='" & NumericUpDown_anoventa.Value & "' 
and ventas.estado<>'ANULADA'
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
where month(STR_TO_DATE(devoluciones.fecha,'%d/%m/%Y'))='" & mes_num_text & "' AND YEAR(STR_TO_DATE(devoluciones.fecha,'%d/%m/%Y'))='" & NumericUpDown_anoventa.Value & "' 
and devoluciones.estado<>'ANULADA'
group by devoluciones_prods.impnom2"
            If reportando_que.Contains("Fecha:") = True Then sql = "SELECT devoluciones_prods.ImpNom2 as Impuesto, FORMAT(sum(devoluciones_prods.valortotal-devoluciones_prods.impuesto2),0) as Base, FORMAT(sum(devoluciones_prods.impuesto2),0) as Valor, FORMAT(sum(devoluciones_prods.valortotal),0) as Total
FROM devoluciones_prods
left join devoluciones on devoluciones_prods.documento=devoluciones.cons
devoluciones.FECHA='" & Me.COMBOBOX_FECHA_VENTAS.Text & "' AND YEAR(STR_TO_DATE(devoluciones.fecha,'%d/%m/%Y'))='" & NumericUpDown_anoventa.Value & "' 
and devoluciones.estado<>'ANULADA'
group by devoluciones_prods.impnom2"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            datagrid_imp_dev.DataSource = dt.DefaultView
            Me.datagrid_imp_dev.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagrid_imp_dev.Columns(0).HeaderText = "Devoluciones de Impuestos"
            Me.datagrid_imp_dev.Columns(0).Width = 250
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
        Me.grid_VENTAS.ClearSelection()

        datagrid_imp.ClearSelection()
        datagrid_imp_dev.ClearSelection()
    End Sub

    Private Sub button_crear_Click(sender As Object, e As EventArgs) Handles button_crear.Click
        If ID_VENTA_VER <> "" Then
            Form_verfactura.Show()

        End If
    End Sub

    Private Sub grid_VENTAS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_VENTAS.CellContentClick

    End Sub

    Private Sub grid_VENTAS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_VENTAS.CellClick
        Dim row_VENTA As DataGridViewRow = grid_VENTAS.CurrentRow
        Try
            ID_VENTA_VER = CInt(row_VENTA.Cells("DOCUMENTO").Value)

        Catch ex As Exception

        End Try
    End Sub

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



        Dim datatableIMPdev As New PdfPTable(datagrid_imp_dev.ColumnCount)


        'Se asignan algunas propiedades para el diseño del PDF.
        datatableIMPdev.DefaultCell.Padding = 3
        Dim headerwidthsimp2 As Single() = GetColumnasSize(datagrid_imp_dev)

        datatableIMPdev.SetWidths(headerwidthsimp2)
        datatableIMPdev.WidthPercentage = 50
        datatableIMPdev.DefaultCell.BorderWidth = 0
        datatableIMPdev.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT
        datatableIMPdev.HorizontalAlignment = Element.ALIGN_LEFT


        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To datagrid_imp_dev.ColumnCount - 1
            Dim HEADERCELLFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 5, iTextSharp.text.Font.BOLD)

            Dim cell_TITLE As New PdfPCell
            cell_TITLE.Phrase = New Phrase(datagrid_imp_dev.Columns(i).HeaderText, FontFactory.GetFont(FontFactory.COURIER_BOLD, 7.5D, iTextSharp.text.Font.BOLD))
            cell_TITLE.HorizontalAlignment = Element.ALIGN_CENTER
            cell_TITLE.BackgroundColor = BaseColor.LIGHT_GRAY
            cell_TITLE.Border = 0

            datatableIMPdev.AddCell(cell_TITLE)
        Next
        datatableIMPdev.HeaderRows = 1
        datatableIMPdev.DefaultCell.BorderWidth = 0
        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To datagrid_imp_dev.RowCount - 1
            For j As Integer = 0 To datagrid_imp_dev.ColumnCount - 1
                Dim cell As New PdfPCell
                cell.Phrase = New Phrase(datagrid_imp_dev(j, i).FormattedValue.ToString, FontFactory.GetFont(FontFactory.COURIER, 7D, iTextSharp.text.Font.BOLD))
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

    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        'funcion para obtener el tamaño de la columnas del datagridview
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Me.Close()

    End Sub

    Private Sub Button_min_Click(sender As Object, e As EventArgs) Handles Button_min.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form_informe_ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class