Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.draw

Public Class Form_inf_diario
    Public da_INGRESOS As New MySqlDataAdapter
    Public dt_INGRESOS As DataTable

    Public da_EGRESOS As New MySqlDataAdapter
    Public dt_EGRESOS As DataTable


    Public da_AGRUPACION As New MySqlDataAdapter
    Public dt_AGRUPACION As DataTable
    Dim alto_pag As Integer = 0


    Dim diario_TTAL_VENTAS As String
    Dim diario_TTAL_OTROSINGRESOS As String
    Dim diario_TTAL_GASTOS As String
    Dim diario_TTAL_EGRESOS As String
    Dim diario_TTAL_DESCUENTOS As String
    Dim diario_TTAL_PROPINAS As String
    Dim diario_TTAL_IMPUESTOS As String
    Dim diario_TTAL_VENTA_NETA As String
    Dim diario_TTAL_VENTA_TOTAL As String
    Dim diario_TTAL_TOTAL_TURNO As String

    Private Sub Buttonsalir_Click(sender As Object, e As EventArgs) Handles Buttonsalir.Click
        Me.Close()

    End Sub

    Private Sub DateTimePicker_diario_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker_diario.ValueChanged

        Me.DataGrid_diario.DataSource = Nothing
        MetroGrid1.DataSource = Nothing
        MetroGrid2.DataSource = Nothing
        MetroGrid_det_ventas.DataSource = Nothing
        MetroGrid_IMPTURNO.DataSource = Nothing
        Label_VENTAS.Text = 0
        Label_DESCUENTOS.Text = 0
        Label_PROPINAS.Text = 0
        Label_total_imp.Text = 0
        Label_gastos.Text = 0

        Label_ini.Text = "0"
        Label_fin.Text = "0"
        Label_fac_count.Text = "0"


        load_informe_diario()





    End Sub

    Private Sub load_informe_diario()
        'consecutivos  dia

        Try
            sql = "sELECT ifnull(min(documento),0) as facini, ifnull(max(documento),0) as facfinal, ifnull(count(documento),0) as facn FROM ventas WHERE 
DATE_FORMAT(STR_TO_DATE(VENTAS.FECHA,'%d/%m/%Y'),'%d/%m/%Y')='" & DateTimePicker_diario.Value.ToString("dd/MM/yyyy") & "'"
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


        'INGRESOS   dia
        Try
            sql = "SELECT ventas.tipodocumento as COMPROBANTE, ventas.totalventa AS VALOR, ventas.descuento AS DESCUENTO, VENTAS.ESTADO AS ESTADO
FROM ventas
WHERE 
DATE_FORMAT(STR_TO_DATE(VENTAS.FECHA,'%d/%m/%Y'),'%d/%m/%Y')='" & DateTimePicker_diario.Value.ToString("dd/MM/yyyy") & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGrid_diario.DataSource = dt
            da.Dispose()
            dt.Dispose()
            conex.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Label_ventas.Text = 0
        Label_descuentos.Text = 0
        Try
            For i As Integer = 0 To DataGrid_diario.RowCount - 1
                If DataGrid_diario.Item("estado", i).Value <> "ANULADO" Or DataGrid_diario.Item("estado", i).Value <> "ANULADA" Then
                    Label_ventas.Text = CInt(Label_ventas.Text) + CInt(DataGrid_diario.Item("VALOR", i).Value)
                    Label_descuentos.Text = CInt(Label_descuentos.Text) + CInt(DataGrid_diario.Item("DESCUENTO", i).Value)
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try


        ' impuestos
        Try
            sql = "SELECT  ventas_prods.ImpNom2 as impuesto, FORMAT(sum(ventas_prods.valortotal-ventas_prods.impuesto2),0) as Base, FORMAT(sum(ventas_prods.impuesto2),0) as Valor, FORMAT(sum(ventas_prods.valortotal),0) as Total
FROM ventas_prods
left join ventas on ventas_prods.documento=ventas.documento
where DATE_FORMAT(STR_TO_DATE(ventas.FECHA,'%d/%m/%Y'),'%d/%m/%Y')='" & DateTimePicker_diario.Value.ToString("dd/MM/yyyy") & "'
group by ventas_prods.impnom2"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            MetroGrid_IMPTURNO.DataSource = dt.DefaultView
            Label_total_imp.Text = "0"
            For Each row3 As DataRow In dt.Rows
                Dim VALOR As Integer
                VALOR = CStr(row3.Item("valor").ToString.Replace(",", ""))

                If row3.Item("impuesto") <> "NO GRAVADO" Or row3.Item("impuesto") <> "NO" Then Label_total_imp.Text = CInt(Label_total_imp.Text) + CInt(VALOR)

            Next
            diario_TTAL_IMPUESTOS = Label_total_imp.Text
        Catch ex As Exception
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()



        ' otros ingresos del dia
        Try
            sql = "SELECT if(cons<>0,'RECIBO DE CAJA','GASTOS') AS COMPROBANTE, CONCEPTO, VALOR AS VALOR, if(cons<>0,'0','0') AS DESCUENTO, ESTADO 
FROM recibos_CAJA 
WHERE DATE_FORMAT(STR_TO_DATE(fecha,'%d/%m/%Y'),'%d/%m/%Y')='" & DateTimePicker_diario.Value.ToString("dd/MM/yyyy") & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.MetroGrid1.DataSource = dt
            da.Dispose()
            dt.Dispose()
            conex.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        diario_TTAL_OTROSINGRESOS = "0"
        Try
            For i As Integer = 0 To MetroGrid1.RowCount - 1
                If MetroGrid1.Item("estado", i).Value <> "ANULADO" Or MetroGrid1.Item("estado", i).Value <> "ANULADA" Then
                    diario_TTAL_OTROSINGRESOS = CInt(diario_TTAL_OTROSINGRESOS) + CInt(MetroGrid1.Item("VALOR", i).Value)
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try




        'EGRESOS   dia
        Try
            sql = "SELECT if(cons<>0,'EGRESOS','EGRESOS') AS COMPROBANTE, CONCEPTO, VALOR AS VALOR, if(cons<>0,'0','0') AS DESCUENTO, ESTADO 
FROM recibos_EGRESOS
WHERE DATE_FORMAT(STR_TO_DATE(FECHA,'%d/%m/%Y'),'%d/%m/%Y')='" & DateTimePicker_diario.Value.ToString("dd/MM/yyyy") & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.MetroGrid1.DataSource = dt
            da.Dispose()
            dt.Dispose()
            conex.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Label_gastos.Text = "0"
        Label_egresos.Text = "0"

        Try
            For i As Integer = 0 To MetroGrid1.RowCount - 1
                If MetroGrid1.Item("estado", i).Value <> "ANULADO" And MetroGrid1.Item("comprobante", i).Value = "GASTOS" Then
                    Label_gastos.Text = CInt(Label_gastos.Text) + CInt(MetroGrid1.Item("VALOR", i).Value)
                End If
                If MetroGrid1.Item("estado", i).Value <> "ANULADO" And MetroGrid1.Item("comprobante", i).Value = "EGRESOS" Then
                    Label_egresos.Text = CInt(Label_egresos.Text) + CInt(MetroGrid1.Item("VALOR", i).Value)
                End If
            Next
            diario_TTAL_EGRESOS = Label_egresos.Text
            diario_TTAL_GASTOS = Label_gastos.Text
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try





        'PROPINAS
        Try
            sql = "SELECT SUM(PROPINA) AS PROPINA FROM ventas WHERE DATE_FORMAT(STR_TO_DATE(FECHA,'%d/%m/%Y'),'%d/%m/%Y')='" & DateTimePicker_diario.Value.ToString("dd/MM/yyyy") & "' AND ESTADO<>'ANULADA'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Label_propinas.Text = "0"
            For Each row3 As DataRow In dt.Rows
                If row3.Item("PROPINA").ToString <> "" Then
                    Label_propinas.Text = CInt(Label_propinas.Text) + CInt(row3.Item("PROPINA"))
                End If
            Next
            da.Dispose()
            dt.Dispose()
            conex.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try





        'DETALLE DE VENTAS


        Try
            sql = "SELECT ventas.documento, concat(ventas.DocCliente,' ', ventas.ClienteNom) as Cliente, 
ventas_prods.CodProd, ventas_prods.Producto, ventas_prods.cantidad,
ventas.Salon, ventas.Mesa, ventas.Mesero, VENTAS_PRODS.VALORU FROM ventas
inner join ventas_prods 
on ventas.documento=ventas_prods.documento 
WHERE date_format(str_to_date(ventas.FECHA,'%d/%m/%Y'),'%d/%m/%Y')='" & DateTimePicker_diario.Value.ToString("dd/MM/yyyy") & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.MetroGrid_det_ventas.DataSource = dt

            da.Dispose()
            dt.Dispose()
            conex.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


        'QUITO LA COMA ,
        diario_TTAL_IMPUESTOS = diario_TTAL_IMPUESTOS.Replace(",", "")

        diario_TTAL_DESCUENTOS = Label_descuentos.Text

        Label_ventas.Text = CInt(Label_ventas.Text) - CInt(diario_TTAL_IMPUESTOS)
        Label_otros_ingresos.Text = diario_TTAL_OTROSINGRESOS
        Label_venta_neta.Text = CInt(Label_ventas.Text) + CInt(diario_TTAL_OTROSINGRESOS) + CInt(diario_TTAL_DESCUENTOS)
        Label_total_imp.Text = diario_TTAL_IMPUESTOS

        Label_venta_total.Text = CInt(Label_venta_neta.Text) + CInt(Label_total_imp.Text)

        Label_propinas.Text = diario_TTAL_PROPINAS
        Label_gastos.Text = diario_TTAL_GASTOS
        Label_egresos.Text = diario_TTAL_EGRESOS

        Label_TOTAL_TOTAL.Text = CInt(Label_venta_total.Text) - (CInt(diario_TTAL_GASTOS) + CInt(diario_TTAL_EGRESOS))

        If Label_otros_ingresos.Text = "" Then Label_otros_ingresos.Text = "0"
        If Label_descuentos.Text = "" Then Label_descuentos.Text = "0"
        If Label_propinas.Text = "" Then Label_propinas.Text = "0"
        If Label_gastos.Text = "" Then Label_gastos.Text = "0"
        If Label_egresos.Text = "" Then Label_egresos.Text = "0"

        Label_ventas.Text = Format(CInt(Label_ventas.Text), "##,##0")
        Label_otros_ingresos.Text = Format(CInt(Label_otros_ingresos.Text), "##,##0")
        Label_descuentos.Text = Format(CInt(Label_descuentos.Text), "##,##0")
        Label_venta_neta.Text = Format(CInt(Label_venta_neta.Text), "##,##0")
        Label_total_imp.Text = Format(CInt(Label_total_imp.Text), "##,##0")
        Label_venta_total.Text = Format(CInt(Label_venta_total.Text), "##,##0")
        Label_propinas.Text = Format(CInt(Label_propinas.Text), "##,##0")
        Label_gastos.Text = Format(CInt(Label_gastos.Text), "##,##0")
        Label_egresos.Text = Format(CInt(Label_egresos.Text), "##,##0")
        Label_TOTAL_TOTAL.Text = Format(CInt(Label_TOTAL_TOTAL.Text), "##,##0")



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'genero para imprimir

        ' ventas  DIA  caja
        Try
            sql = "SELECT caja.tipodocumento AS Comprobante, caja.MedioDePago as MedioPago, format(SUM(caja.Total),0) AS TOTAL 
FROM caja where date_format(str_to_date(caja.FECHA,'%d/%m/%Y'),'%d/%m/%Y')='" & DateTimePicker_diario.Value.ToString("dd/MM/yyyy") & "' GROUP BY caja.tipodocumento, caja.MediodePago"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGrid_diario.DataSource = dt
            da.Dispose()
            dt.Dispose()
            conex.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try



        Try
            sql = "/*ventas por productco*/
SELECT CONCAT(ventas_prods.CodProd,'-',ventas_prods.Producto) AS Producto, sum(ventas_prods.cantidad) as Cant,
format(ventas_prods.valoru*sum(ventas_prods.cantidad),0)  as Total
FROM ventas
inner join ventas_prods 
on ventas.documento=ventas_prods.documento where date_format(str_to_date(ventas.fecha,'%d/%m/%Y'),'%d/%m/%Y')='" & DateTimePicker_diario.Value.ToString("dd/MM/yyyy") & "'
group by ventas_prods.CodProd;"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.MetroGrid_det_ventas.DataSource = dt

            da.Dispose()
            dt.Dispose()
            conex.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try



        Try
            alto_pag = (DataGrid_diario.RowCount + MetroGrid_det_ventas.RowCount) * 12 + 1000
            Dim pgSize = New iTextSharp.text.Rectangle(201, alto_pag)

            'Dim doc As New Document(PageSize.A4, 8, 400, 10, 10)
            Dim doc As New Document(pgSize, 8, 8, 10, 10)

            'Path que guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\INFORME DIARIO" & DateTimePicker_diario.Value.ToShortDateString.Replace("/", "-") & ".pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)

            PdfWriter.GetInstance(doc, file)
            doc.Open()
            ExportarDatosPDF_POS(doc)
            doc.Close()

            Process.Start("C:\Program Files\Tracker Software\PDF Viewer\pdfxcview.exe", """" & Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\INFORME DIARIO" & DateTimePicker_diario.Value.ToShortDateString.Replace("/", "-") & ".pdf" & """")


        Catch ex As Exception
            'Si el intento es fallido, mostrar MsgBox.
            Me.Cursor = Cursors.Default
            MessageBox.Show("No se puede generar el documento PDF, Cierre los documentos PDF generados anteriormente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        load_informe_diario()

    End Sub
    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        'funcion para obtener el tamaño de la columnas del datagridview
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function


    Private Sub Button_export_Click(sender As Object, e As EventArgs) Handles Button_export.Click
        'genero para imprimir
        ' ventas  DIA  caja
        Try
            sql = "SELECT caja.tipodocumento AS Comprobante, caja.MedioDePago as MedioPago, format(SUM(caja.Total),0) AS TOTAL 
FROM caja where caja.FECHA='" & DateTimePicker_diario.Value.ToShortDateString & "' GROUP BY caja.tipodocumento, caja.MediodePago"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGrid_diario.DataSource = dt
            da.Dispose()
            dt.Dispose()
            conex.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try



        Try
            sql = "/*ventas por productco*/
SELECT CONCAT(ventas_prods.CodProd,'-',ventas_prods.Producto) AS Producto, sum(ventas_prods.cantidad) as Cant,
format(ventas_prods.valoru*sum(ventas_prods.cantidad),0)  as Total
FROM ventas
inner join ventas_prods 
on ventas.documento=ventas_prods.documento where ventas.fecha='" & DateTimePicker_diario.Value.ToShortDateString & "'
group by ventas_prods.CodProd;"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.MetroGrid_det_ventas.DataSource = dt

            da.Dispose()
            dt.Dispose()
            conex.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try



        Try
            'Intentar generar el documento.
            'Dim pgSize = New iTextSharp.text.Rectangle(250, (DATAGrid_PDF.RowCount + DATAGrid_PDF.RowCount) * 10 + 200)

            Dim doc As New Document(PageSize.A4, 10, 10, 10, 10)
            'Dim doc As New Document(pgSize, 8, 8, 10, 10)

            'Path que guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\INFORME DIARIO" & DateTimePicker_diario.Value.ToShortDateString.Replace("/", "-") & ".pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)

            PdfWriter.GetInstance(doc, file)
            doc.Open()
            ExportarDatosPDF(doc)
            doc.Close()
            Process.Start(filename)
        Catch ex As Exception
            'Si el intento es fallido, mostrar MsgBox.
            Me.Cursor = Cursors.Default
            MessageBox.Show("No se puede generar el documento PDF, Cierre los documentos PDF generados anteriormente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        load_informe_diario()
    End Sub
    Public Sub ExportarDatosPDF_POS(ByVal document As Document)


        Dim CANT_FILAS As Integer = 0
        'Se crea un objeto PDFTable con el numero de columnas del DataGridView.
        Dim datatable As New PdfPTable(DataGrid_diario.ColumnCount)

        Dim datatableIMP As New PdfPTable(MetroGrid_IMPTURNO.ColumnCount)

        'Se asignan algunas propiedades para el diseño del PDF.
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(DataGrid_diario)

        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER


        Dim datatable_det_ventas As New PdfPTable(MetroGrid_det_ventas.ColumnCount)
        'Se asignan algunas propiedades para el diseño del PDF.
        datatable_det_ventas.DefaultCell.Padding = 3
        'Dim headerwidths2 As Single() = GetColumnasSize(MetroGrid_det_ventas)

        Dim anchos() As Single = {300, 70, 100}
        datatable_det_ventas.SetWidths(anchos)
        datatable_det_ventas.WidthPercentage = 100
        datatable_det_ventas.DefaultCell.BorderWidth = 2
        datatable_det_ventas.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT



        'Se asignan algunas propiedades para el diseño del PDF.
        datatableIMP.DefaultCell.Padding = 3
        Dim headerwidthsimp As Single() = GetColumnasSize(MetroGrid_IMPTURNO)

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

        Dim encabezadoLINE As New Paragraph("|======================================|", fontLINE)

        encabezadoLINE.Alignment = Element.ALIGN_LEFT
        encabezadoLINE.Font = fontLINE

        Dim encabezadoLINE2 As New Paragraph("=======================================", fontLINE)
        Dim encabezadoLINE3 As New Paragraph("_______________________________________", fontLINE)

        encabezadoLINE2.Alignment = Element.ALIGN_CENTER
        encabezadoLINE2.Font = fontLINE

        encabezadoLINE3.Alignment = Element.ALIGN_CENTER
        encabezadoLINE3.Font = fontLINE

        Dim tablahome As New PdfPTable(1)
        tablahome.WidthPercentage = 100
        tablahome.DefaultCell.Padding = 0
        tablahome.DefaultCell.BorderWidth = 0
        tablahome.SpacingBefore = 0
        tablahome.HorizontalAlignment = 0

        Dim cellhome As New PdfPCell
        cellhome.BorderWidth = 0


        cellhome.Phrase = New Phrase(comex_nombrecomercial, FontFactory.GetFont(FontFactory.COURIER_BOLD, 10, iTextSharp.text.Font.NORMAL))
        cellhome.HorizontalAlignment = Element.ALIGN_CENTER
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase(comex_nombrepropietario, FontFactory.GetFont(FontFactory.COURIER_BOLD, 8, iTextSharp.text.Font.NORMAL))
        cellhome.HorizontalAlignment = Element.ALIGN_CENTER
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase("NIT:" & comex_nit & "-" & comex_DV & " " & comex_regimen, FontFactory.GetFont(FontFactory.COURIER_BOLD, 8, iTextSharp.text.Font.NORMAL))
        cellhome.HorizontalAlignment = Element.ALIGN_CENTER
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase("Tels:" & comex_tels & " - " & comex_cels & " " & comex_dircomercio & " " & comex_ciudad, FontFactory.GetFont(FontFactory.COURIER_BOLD, 7, iTextSharp.text.Font.NORMAL))
        cellhome.HorizontalAlignment = Element.ALIGN_CENTER
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()


        Dim encabezado As New Paragraph("INFORME DIARIO" + Chr(13) + DateTimePicker_diario.Value.ToShortDateString, FontFactory.GetFont(FontFactory.COURIER_BOLD, 10, iTextSharp.text.Font.NORMAL))
        encabezado.Alignment = Element.ALIGN_CENTER

        Dim encabezadotipo As New Paragraph("INFORME(Z) DE CAJA", FontFactory.GetFont(FontFactory.COURIER_BOLD, 10, iTextSharp.text.Font.NORMAL))
        encabezadotipo.Alignment = Element.ALIGN_CENTER


        Dim PDF_temrinal As New Paragraph("Terminal:" & SERIAL_PROC, FontFactory.GetFont(FontFactory.COURIER_BOLD, 7.5D, iTextSharp.text.Font.NORMAL)) : PDF_temrinal.Alignment = Element.ALIGN_CENTER


        Dim tabla_turno_data As New PdfPTable(2)
        tabla_turno_data.WidthPercentage = 100
        tabla_turno_data.DefaultCell.Padding = 0
        tabla_turno_data.DefaultCell.BorderWidth = 0
        tabla_turno_data.SpacingBefore = 0
        tabla_turno_data.HorizontalAlignment = 0
        Dim cellturno As New PdfPCell
        cellturno.BorderWidth = 0



        cellturno.Phrase = New Phrase("(+)Ventas: $", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Label_ventas.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("(+)Ingresos: $", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Label_otros_ingresos.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("(-)Descuentos: $", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Label_descuentos.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("===============", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase("===============", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("VENTAS NETAS: $", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Label_venta_neta.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("(+)impuestos: $", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Label_total_imp.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("================", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase("================", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea


        cellturno.Phrase = New Phrase("TOTAL VENTAS: $", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Label_venta_total.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea



        cellturno.Phrase = New Phrase("(+)Propinas: $", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Label_propinas.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea


        cellturno.Phrase = New Phrase("(-)Gastos: $", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Label_gastos.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        'cellturno.Phrase = New Phrase("(-)Egresos: $", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        'cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        'cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        'tabla_turno_data.AddCell(cellturno) 'primera col

        'cellturno.Phrase = New Phrase(Label_egresos.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        'cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        'tabla_turno_data.AddCell(cellturno) ' segunda col
        'tabla_turno_data.CompleteRow() ' agrega linea


        cellturno.Phrase = New Phrase("================", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase("================", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("TOTAL TURNO: $", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Label_TOTAL_TOTAL.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        Dim encabezado_FACS As New Paragraph(Label_ini.Text & " Facturas emitidas, Desde:" + Label_ini.Text + " Hasta:" + Label_ini.Text + Chr(13), DIRFont) : encabezado_FACS.Alignment = Element.ALIGN_CENTER


        Dim encabezado7 As New Paragraph("Se Imprimió el " + DateTime.Now + Chr(13) + "Por: " + usrnom, DIRFont) : encabezado7.Alignment = 0
        Dim encabezado8 As New Paragraph("Detalle de Impuestos", iTextSharp.text.FontFactory.GetFont("Arial Black", 9, iTextSharp.text.Font.BOLD)) : encabezado8.Alignment = Element.ALIGN_CENTER
        Dim encabezado9 As New Paragraph("Ventas por Producto", iTextSharp.text.FontFactory.GetFont("Arial Black", 9, iTextSharp.text.Font.BOLD)) : encabezado9.Alignment = 0

        Dim encabezado_resumenOP As New Paragraph("Resumen de Operaciones", iTextSharp.text.FontFactory.GetFont("Arial Black", 9, iTextSharp.text.Font.BOLD)) : encabezado_resumenOP.Alignment = Element.ALIGN_CENTER

        Dim encabezado6 As New Paragraph("Relación de Operaciones", iTextSharp.text.FontFactory.GetFont("Arial Black", 9, iTextSharp.text.Font.BOLD)) : encabezado6.Alignment = Element.ALIGN_CENTER
        Dim encabezado_gastYegre As New Paragraph("Relación de Gastos y Egresos", iTextSharp.text.FontFactory.GetFont("Arial Black", 9, iTextSharp.text.Font.BOLD)) : encabezado_gastYegre.Alignment = Element.ALIGN_CENTER

        Dim glue = New Chunk(New VerticalPositionMark())

        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To MetroGrid_IMPTURNO.ColumnCount - 1
            Dim HEADERCELLFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 5, iTextSharp.text.Font.BOLD)

            Dim cell_TITLE As New PdfPCell
            cell_TITLE.Phrase = New Phrase(MetroGrid_IMPTURNO.Columns(i).HeaderText, FontFactory.GetFont(FontFactory.COURIER_BOLD, 7.5D, iTextSharp.text.Font.BOLD))
            cell_TITLE.HorizontalAlignment = Element.ALIGN_CENTER
            cell_TITLE.BackgroundColor = BaseColor.LIGHT_GRAY
            cell_TITLE.Border = 0

            datatableIMP.AddCell(cell_TITLE)
        Next
        datatableIMP.HeaderRows = 1
        datatableIMP.DefaultCell.BorderWidth = 0
        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To MetroGrid_IMPTURNO.RowCount - 1
            For j As Integer = 0 To MetroGrid_IMPTURNO.ColumnCount - 1
                Dim cell As New PdfPCell
                cell.Phrase = New Phrase(MetroGrid_IMPTURNO(j, i).FormattedValue.ToString, FontFactory.GetFont(FontFactory.COURIER, 7D, iTextSharp.text.Font.BOLD))
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


        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To DataGrid_diario.ColumnCount - 1
            Dim HEADERCELLFont = FontFactory.GetFont(FontFactory.COURIER_BOLD, 7.5D, iTextSharp.text.Font.BOLD)

            Dim cell_TITLE As New PdfPCell
            cell_TITLE.Phrase = New Phrase(DataGrid_diario.Columns(i).HeaderText, HEADERCELLFont)
            cell_TITLE.HorizontalAlignment = Element.ALIGN_CENTER
            cell_TITLE.BackgroundColor = BaseColor.LIGHT_GRAY
            cell_TITLE.Border = 0

            datatable.AddCell(cell_TITLE)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 0
        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To DataGrid_diario.RowCount - 1
            For j As Integer = 0 To DataGrid_diario.ColumnCount - 1
                Dim cell As New PdfPCell
                cell.Phrase = New Phrase(DataGrid_diario(j, i).FormattedValue.ToString, FontFactory.GetFont(FontFactory.COURIER, 7D, iTextSharp.text.Font.BOLD))
                If j = 0 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 1 Then cell.HorizontalAlignment = Element.ALIGN_CENTER
                If j = 2 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT : cell.BackgroundColor = BaseColor.LIGHT_GRAY
                If j = 3 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT : cell.BackgroundColor = BaseColor.LIGHT_GRAY
                If j = 4 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 5 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 6 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 7 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                cell.Border = 0
                cell.BorderWidthRight = 0.0F
                cell.BorderColorRight = BaseColor.BLACK
                datatable.AddCell(cell)
            Next
            datatable.CompleteRow()
        Next



        ' AGRUPACION
        Try
            sql = "SELECT DISTINCT(PRODUCTOS_CATEGORIAS.CATEGORIA)
FROM ventas
inner join ventas_prods 
on ventas.documento=ventas_prods.documento 
INNER JOIN PRODUCTOS ON VENTAS_PRODS.CODPROD=PRODUCTOS.COD
INNER JOIN PRODUCTOS_CATEGORIAS ON PRODUCTOS.CATEGORIA=PRODUCTOS_CATEGORIAS.CATEGORIA
where ventas.fecha='" & DateTimePicker_diario.Value.ToShortDateString & "' group by ventas_prods.CodProd"
            da_AGRUPACION = New MySqlDataAdapter(sql, conex)
            dt_AGRUPACION = New DataTable
            da_AGRUPACION.Fill(dt_AGRUPACION)
            For Each row3 As DataRow In dt_AGRUPACION.Rows
                'CStr(row3.Item("CATEGORIA"))


                Try
                    sql = "SELECT CONCAT(ventas_prods.CodProd,'-',ventas_prods.Producto) AS Producto, sum(ventas_prods.cantidad) as Cant,
format(ventas_prods.valoru*sum(ventas_prods.cantidad),0)  as Total
FROM ventas
inner join ventas_prods 
on ventas.documento=ventas_prods.documento 
INNER JOIN PRODUCTOS ON VENTAS_PRODS.CODPROD=PRODUCTOS.COD
INNER JOIN PRODUCTOS_CATEGORIAS ON PRODUCTOS.CATEGORIA=PRODUCTOS_CATEGORIAS.CATEGORIA
where ventas.fecha='" & DateTimePicker_diario.Value.ToShortDateString & "' AND PRODUCTOS_CATEGORIAS.CATEGORIA='" & CStr(row3.Item("CATEGORIA")) & "' group by ventas_prods.CodProd"
                    da = New MySqlDataAdapter(sql, conex)
                    dt = New DataTable
                    da.Fill(dt)
                    Me.MetroGrid_det_ventas.DataSource = dt

                    da.Dispose()
                    dt.Dispose()
                    conex.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

                'Dim encabezado_CAT As New Paragraph(CStr(row3.Item("CATEGORIA")) + Chr(13), DIRFont) : encabezado_CAT.Alignment = 0
                'document.Add(encabezado_CAT)



                Dim cell_CAT As New PdfPCell
                cell_CAT.Phrase = New Phrase("( " + CStr(row3.Item("CATEGORIA")) + " )", FontFactory.GetFont(FontFactory.COURIER_BOLD, 7D, iTextSharp.text.Font.BOLD))
                cell_CAT.BorderWidth = 0
                cell_CAT.BackgroundColor = BaseColor.WHITE
                cell_CAT.HorizontalAlignment = Element.ALIGN_CENTER
                cell_CAT.Colspan = 3
                datatable_det_ventas.AddCell(cell_CAT)
                cell_CAT.Phrase = New Phrase("", DIRFont2)
                cell_CAT.BorderWidth = 0
                cell_CAT.BackgroundColor = BaseColor.WHITE
                datatable_det_ventas.AddCell(cell_CAT)
                cell_CAT.Phrase = New Phrase("", DIRFont2)
                cell_CAT.BorderWidth = 0
                cell_CAT.BackgroundColor = BaseColor.WHITE
                datatable_det_ventas.AddCell(cell_CAT)
                datatable_det_ventas.CompleteRow()

                'Se capturan los nombres de las columnas del DataGridView.
                For i As Integer = 0 To MetroGrid_det_ventas.ColumnCount - 1
                    Dim HEADERCELLFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 8, iTextSharp.text.Font.BOLD)

                    Dim cell_TITLE As New PdfPCell
                    cell_TITLE.Phrase = New Phrase(MetroGrid_det_ventas.Columns(i).HeaderText, FontFactory.GetFont(FontFactory.COURIER_BOLD, 7D, iTextSharp.text.Font.BOLD))
                    cell_TITLE.HorizontalAlignment = Element.ALIGN_CENTER
                    cell_TITLE.BackgroundColor = BaseColor.LIGHT_GRAY
                    datatable_det_ventas.AddCell(cell_TITLE)
                Next
                datatable_det_ventas.HeaderRows = 1
                datatable_det_ventas.DefaultCell.BorderWidth = 0
                'Se generan las columnas del DataGridView.
                For i As Integer = 0 To MetroGrid_det_ventas.RowCount - 1
                    For j As Integer = 0 To MetroGrid_det_ventas.ColumnCount - 1
                        Dim cell As New PdfPCell
                        cell.Phrase = New Phrase(MetroGrid_det_ventas(j, i).FormattedValue.ToString, FontFactory.GetFont(FontFactory.COURIER, 7.5D, iTextSharp.text.Font.BOLD))
                        If j = 0 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                        If j = 1 Then cell.HorizontalAlignment = Element.ALIGN_CENTER
                        If j = 2 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT : cell.BackgroundColor = BaseColor.LIGHT_GRAY
                        If j = 3 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                        If j = 4 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                        If j = 5 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                        If j = 6 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                        If j = 7 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                        cell.Border = 0
                        cell.BorderWidthRight = 0.0F
                        cell.BorderColorRight = BaseColor.BLACK
                        datatable_det_ventas.AddCell(cell)
                    Next
                    datatable_det_ventas.CompleteRow()
                Next



            Next
            'datatable_det_ventas.SpacingBefore = 10
            'If BunifuCheckbox_det_ventas.Checked = True Then document.Add(datatable_det_ventas)

        Catch ex As Exception
        End Try
        conex.Close()
        da_AGRUPACION.Dispose()
        dt_AGRUPACION.Dispose()
        conex.Close()



        document.Add(encabezadoLINE)
        document.Add(tablahome)
        document.Add(encabezadoLINE2)
        document.Add(encabezado)
        document.Add(encabezadotipo)
        document.Add(PDF_temrinal)
        document.Add(encabezado_FACS)
        document.Add(encabezado_resumenOP)
        tabla_turno_data.SpacingBefore = 10
        document.Add(tabla_turno_data)
        document.Add(encabezado6)
        datatable.SpacingBefore = 10
        document.Add(datatable)
        document.Add(encabezadoLINE3)
        encabezado8.SpacingAfter = 4
        document.Add(encabezado8)
        document.Add(datatableIMP)
        document.Add(encabezadoLINE3)
        encabezado9.Alignment = Element.ALIGN_CENTER
        document.Add(encabezado9)
        datatable_det_ventas.SpacingBefore = 10
        document.Add(datatable_det_ventas)
        document.Add(encabezadoLINE3)


        document.Add(encabezado7)
        document.Add(encabezadoLINE)


    End Sub

    Public Sub ExportarDatosPDF(ByVal document As Document)
        'LOGO
        If comex_logo <> "" And File.Exists(comex_logo) = True Then
            Dim imagelogogopdf As iTextSharp.text.Image 'Declaracion de una imagen

            imagelogogopdf = iTextSharp.text.Image.GetInstance(comex_logo) 'Dirreccion a la imagen que se hace referencia
            imagelogogopdf.Alignment = Element.ALIGN_RIGHT
            imagelogogopdf.SetAbsolutePosition(420, 765) 'Posicion en el eje cartesiano
            imagelogogopdf.ScaleAbsoluteWidth(160) 'Ancho de la imagen
            imagelogogopdf.ScaleAbsoluteHeight(55) 'Altura de la imagen
            document.Add(imagelogogopdf) ' Agrega la imagen al documento
        End If

        Dim CANT_FILAS As Integer = 0
        'Se crea un objeto PDFTable con el numero de columnas del DataGridView.
        Dim datatable As New PdfPTable(DataGrid_diario.ColumnCount)

        Dim datatableIMP As New PdfPTable(MetroGrid_IMPTURNO.ColumnCount)

        'Se asignan algunas propiedades para el diseño del PDF.
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(DataGrid_diario)

        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER


        Dim datatable_det_ventas As New PdfPTable(MetroGrid_det_ventas.ColumnCount)
        'Se asignan algunas propiedades para el diseño del PDF.
        datatable_det_ventas.DefaultCell.Padding = 3
        'Dim headerwidths2 As Single() = GetColumnasSize(MetroGrid_det_ventas)

        Dim anchos() As Single = {300, 70, 100}
        datatable_det_ventas.SetWidths(anchos)
        datatable_det_ventas.WidthPercentage = 100
        datatable_det_ventas.DefaultCell.BorderWidth = 2
        datatable_det_ventas.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT



        'Se asignan algunas propiedades para el diseño del PDF.
        datatableIMP.DefaultCell.Padding = 3
        Dim headerwidthsimp As Single() = GetColumnasSize(MetroGrid_IMPTURNO)

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

        Dim encabezadoLINE As New Paragraph("|==========================================================================================================================|", fontLINE)

        encabezadoLINE.Alignment = Element.ALIGN_LEFT
        encabezadoLINE.Font = fontLINE

        Dim encabezadoLINE2 As New Paragraph("===========================================================================================================================", fontLINE)
        Dim encabezadoLINE3 As New Paragraph("________________________________________", fontLINE)

        encabezadoLINE2.Alignment = Element.ALIGN_LEFT
        encabezadoLINE2.Font = fontLINE

        encabezadoLINE3.Alignment = Element.ALIGN_LEFT
        encabezadoLINE3.Font = fontLINE

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

        cellhome.Phrase = New Phrase("Tels:" & comex_tels & " - " & comex_cels & " " & comex_dircomercio & " " & comex_ciudad, FontFactory.GetFont(FontFactory.COURIER_BOLD, 7, iTextSharp.text.Font.NORMAL))
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()


        Dim encabezado As New Paragraph("INFORME DIARIO" + Chr(13) + DateTimePicker_diario.Value.ToShortDateString, FontFactory.GetFont(FontFactory.COURIER_BOLD, 10, iTextSharp.text.Font.NORMAL))
        encabezado.Alignment = Element.ALIGN_CENTER

        Dim encabezadotipo As New Paragraph("INFORME(Z) DE CAJA", FontFactory.GetFont(FontFactory.COURIER_BOLD, 10, iTextSharp.text.Font.NORMAL))
        encabezadotipo.Alignment = Element.ALIGN_CENTER


        Dim PDF_temrinal As New Paragraph("Terminal:" & SERIAL_PROC, FontFactory.GetFont(FontFactory.COURIER_BOLD, 7.5D, iTextSharp.text.Font.NORMAL)) : PDF_temrinal.Alignment = Element.ALIGN_CENTER


        Dim tabla_turno_data As New PdfPTable(2)
        tabla_turno_data.WidthPercentage = 100
        tabla_turno_data.DefaultCell.Padding = 0
        tabla_turno_data.DefaultCell.BorderWidth = 0
        tabla_turno_data.SpacingBefore = 0
        tabla_turno_data.HorizontalAlignment = 0
        Dim cellturno As New PdfPCell
        cellturno.BorderWidth = 0

        Dim encabezado_FACS As New Paragraph(Label_ini.Text & " Facturas emitidas  | Desde:" + Label_ini.Text + " Hasta:" + Label_ini.Text + Chr(13), DIRFont) : encabezado_FACS.Alignment = Element.ALIGN_CENTER


        cellturno.Phrase = New Phrase("(+)Ventas: $", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Label_ventas.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("(+)Ingresos: $", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Label_otros_ingresos.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("(-)Descuentos: $", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Label_descuentos.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("===============", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase("===============", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("VENTAS NETAS: $", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Label_venta_neta.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("(+)impuestos: $", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Label_total_imp.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("================", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase("================", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea


        cellturno.Phrase = New Phrase("TOTAL VENTAS: $", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Label_venta_total.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea



        cellturno.Phrase = New Phrase("(+)Propinas: $", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Label_propinas.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea


        cellturno.Phrase = New Phrase("(-)Gastos: $", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Label_gastos.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        'cellturno.Phrase = New Phrase("(-)Egresos: $", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        'cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        'cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        'tabla_turno_data.AddCell(cellturno) 'primera col

        'cellturno.Phrase = New Phrase(Label_egresos.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        'cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        'tabla_turno_data.AddCell(cellturno) ' segunda col
        'tabla_turno_data.CompleteRow() ' agrega linea


        cellturno.Phrase = New Phrase("================", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase("================", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("TOTAL TURNO: $", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Label_TOTAL_TOTAL.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea


        Dim encabezado7 As New Paragraph("Se Imprimió el " + DateTime.Now + Chr(13) + "Por: " + usrnom, DIRFont) : encabezado7.Alignment = 0
        Dim encabezado8 As New Paragraph("Detalle de Impuestos", iTextSharp.text.FontFactory.GetFont("Arial Black", 9, iTextSharp.text.Font.BOLD)) : encabezado8.Alignment = Element.ALIGN_CENTER
        Dim encabezado9 As New Paragraph("Ventas por Producto", iTextSharp.text.FontFactory.GetFont("Arial Black", 9, iTextSharp.text.Font.BOLD)) : encabezado9.Alignment = 0

        Dim encabezado_resumenOP As New Paragraph("Resumen de Operaciones", iTextSharp.text.FontFactory.GetFont("Arial Black", 9, iTextSharp.text.Font.BOLD)) : encabezado_resumenOP.Alignment = Element.ALIGN_CENTER

        Dim encabezado6 As New Paragraph("Relación de Operaciones", iTextSharp.text.FontFactory.GetFont("Arial Black", 9, iTextSharp.text.Font.BOLD)) : encabezado6.Alignment = Element.ALIGN_CENTER
        Dim encabezado_gastYegre As New Paragraph("Relación de Gastos y Egresos", iTextSharp.text.FontFactory.GetFont("Arial Black", 9, iTextSharp.text.Font.BOLD)) : encabezado_gastYegre.Alignment = Element.ALIGN_CENTER

        Dim glue = New Chunk(New VerticalPositionMark())

        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To MetroGrid_IMPTURNO.ColumnCount - 1
            Dim HEADERCELLFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 5, iTextSharp.text.Font.BOLD)

            Dim cell_TITLE As New PdfPCell
            cell_TITLE.Phrase = New Phrase(MetroGrid_IMPTURNO.Columns(i).HeaderText, FontFactory.GetFont(FontFactory.COURIER_BOLD, 7.5D, iTextSharp.text.Font.BOLD))
            cell_TITLE.HorizontalAlignment = Element.ALIGN_CENTER
            cell_TITLE.BackgroundColor = BaseColor.LIGHT_GRAY
            cell_TITLE.Border = 0

            datatableIMP.AddCell(cell_TITLE)
        Next
        datatableIMP.HeaderRows = 1
        datatableIMP.DefaultCell.BorderWidth = 0
        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To MetroGrid_IMPTURNO.RowCount - 1
            For j As Integer = 0 To MetroGrid_IMPTURNO.ColumnCount - 1
                Dim cell As New PdfPCell
                cell.Phrase = New Phrase(MetroGrid_IMPTURNO(j, i).FormattedValue.ToString, FontFactory.GetFont(FontFactory.COURIER, 7D, iTextSharp.text.Font.BOLD))
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


        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To DataGrid_diario.ColumnCount - 1
            Dim HEADERCELLFont = FontFactory.GetFont(FontFactory.COURIER_BOLD, 7.5D, iTextSharp.text.Font.BOLD)

            Dim cell_TITLE As New PdfPCell
            cell_TITLE.Phrase = New Phrase(DataGrid_diario.Columns(i).HeaderText, HEADERCELLFont)
            cell_TITLE.HorizontalAlignment = Element.ALIGN_CENTER
            cell_TITLE.BackgroundColor = BaseColor.LIGHT_GRAY
            cell_TITLE.Border = 0

            datatable.AddCell(cell_TITLE)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 0
        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To DataGrid_diario.RowCount - 1
            For j As Integer = 0 To DataGrid_diario.ColumnCount - 1
                Dim cell As New PdfPCell
                cell.Phrase = New Phrase(DataGrid_diario(j, i).FormattedValue.ToString, FontFactory.GetFont(FontFactory.COURIER, 7D, iTextSharp.text.Font.BOLD))
                If j = 0 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 1 Then cell.HorizontalAlignment = Element.ALIGN_CENTER
                If j = 2 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT : cell.BackgroundColor = BaseColor.LIGHT_GRAY
                If j = 3 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT : cell.BackgroundColor = BaseColor.LIGHT_GRAY
                If j = 4 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 5 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 6 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 7 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                cell.Border = 0
                cell.BorderWidthRight = 0.0F
                cell.BorderColorRight = BaseColor.BLACK
                datatable.AddCell(cell)
            Next
            datatable.CompleteRow()
        Next



        ' AGRUPACION
        Try
            sql = "SELECT DISTINCT(PRODUCTOS_CATEGORIAS.CATEGORIA)
FROM ventas
inner join ventas_prods 
on ventas.documento=ventas_prods.documento 
INNER JOIN PRODUCTOS ON VENTAS_PRODS.CODPROD=PRODUCTOS.COD
INNER JOIN PRODUCTOS_CATEGORIAS ON PRODUCTOS.CATEGORIA=PRODUCTOS_CATEGORIAS.CATEGORIA
where ventas.fecha='" & DateTimePicker_diario.Value.ToShortDateString & "' group by ventas_prods.CodProd"
            da_AGRUPACION = New MySqlDataAdapter(sql, conex)
            dt_AGRUPACION = New DataTable
            da_AGRUPACION.Fill(dt_AGRUPACION)
            For Each row3 As DataRow In dt_AGRUPACION.Rows
                'CStr(row3.Item("CATEGORIA"))


                Try
                    sql = "SELECT CONCAT(ventas_prods.CodProd,'-',ventas_prods.Producto) AS Producto, sum(ventas_prods.cantidad) as Cant,
format(ventas_prods.valoru*sum(ventas_prods.cantidad),0)  as Total
FROM ventas
inner join ventas_prods 
on ventas.documento=ventas_prods.documento 
INNER JOIN PRODUCTOS ON VENTAS_PRODS.CODPROD=PRODUCTOS.COD
INNER JOIN PRODUCTOS_CATEGORIAS ON PRODUCTOS.CATEGORIA=PRODUCTOS_CATEGORIAS.CATEGORIA
where ventas.fecha='" & DateTimePicker_diario.Value.ToShortDateString & "' AND PRODUCTOS_CATEGORIAS.CATEGORIA='" & CStr(row3.Item("CATEGORIA")) & "' group by ventas_prods.CodProd"
                    da = New MySqlDataAdapter(sql, conex)
                    dt = New DataTable
                    da.Fill(dt)
                    Me.MetroGrid_det_ventas.DataSource = dt

                    da.Dispose()
                    dt.Dispose()
                    conex.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

                'Dim encabezado_CAT As New Paragraph(CStr(row3.Item("CATEGORIA")) + Chr(13), DIRFont) : encabezado_CAT.Alignment = 0
                'document.Add(encabezado_CAT)



                Dim cell_CAT As New PdfPCell
                cell_CAT.Phrase = New Phrase("( " + CStr(row3.Item("CATEGORIA")) + " )", FontFactory.GetFont(FontFactory.COURIER_BOLD, 7D, iTextSharp.text.Font.BOLD))
                cell_CAT.BorderWidth = 0
                cell_CAT.BackgroundColor = BaseColor.WHITE
                cell_CAT.HorizontalAlignment = Element.ALIGN_CENTER
                cell_CAT.Colspan = 3
                datatable_det_ventas.AddCell(cell_CAT)
                cell_CAT.Phrase = New Phrase("", DIRFont2)
                cell_CAT.BorderWidth = 0
                cell_CAT.BackgroundColor = BaseColor.WHITE
                datatable_det_ventas.AddCell(cell_CAT)
                cell_CAT.Phrase = New Phrase("", DIRFont2)
                cell_CAT.BorderWidth = 0
                cell_CAT.BackgroundColor = BaseColor.WHITE
                datatable_det_ventas.AddCell(cell_CAT)
                datatable_det_ventas.CompleteRow()

                'Se capturan los nombres de las columnas del DataGridView.
                For i As Integer = 0 To MetroGrid_det_ventas.ColumnCount - 1
                    Dim HEADERCELLFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 8, iTextSharp.text.Font.BOLD)

                    Dim cell_TITLE As New PdfPCell
                    cell_TITLE.Phrase = New Phrase(MetroGrid_det_ventas.Columns(i).HeaderText, FontFactory.GetFont(FontFactory.COURIER_BOLD, 7D, iTextSharp.text.Font.BOLD))
                    cell_TITLE.HorizontalAlignment = Element.ALIGN_CENTER
                    cell_TITLE.BackgroundColor = BaseColor.LIGHT_GRAY
                    datatable_det_ventas.AddCell(cell_TITLE)
                Next
                datatable_det_ventas.HeaderRows = 1
                datatable_det_ventas.DefaultCell.BorderWidth = 0
                'Se generan las columnas del DataGridView.
                For i As Integer = 0 To MetroGrid_det_ventas.RowCount - 1
                    For j As Integer = 0 To MetroGrid_det_ventas.ColumnCount - 1
                        Dim cell As New PdfPCell
                        cell.Phrase = New Phrase(MetroGrid_det_ventas(j, i).FormattedValue.ToString, FontFactory.GetFont(FontFactory.COURIER, 7.5D, iTextSharp.text.Font.BOLD))
                        If j = 0 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                        If j = 1 Then cell.HorizontalAlignment = Element.ALIGN_CENTER
                        If j = 2 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT : cell.BackgroundColor = BaseColor.LIGHT_GRAY
                        If j = 3 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                        If j = 4 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                        If j = 5 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                        If j = 6 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                        If j = 7 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                        cell.Border = 0
                        cell.BorderWidthRight = 0.0F
                        cell.BorderColorRight = BaseColor.BLACK
                        datatable_det_ventas.AddCell(cell)
                    Next
                    datatable_det_ventas.CompleteRow()
                Next



            Next
            'datatable_det_ventas.SpacingBefore = 10
            'If BunifuCheckbox_det_ventas.Checked = True Then document.Add(datatable_det_ventas)

        Catch ex As Exception
        End Try
        conex.Close()
        da_AGRUPACION.Dispose()
        dt_AGRUPACION.Dispose()
        conex.Close()



        document.Add(encabezadoLINE)
        document.Add(tablahome)
        document.Add(encabezadoLINE2)
        document.Add(encabezado)
        document.Add(encabezadotipo)
        document.Add(PDF_temrinal)
        document.Add(encabezado_FACS)

        document.Add(encabezado_resumenOP)
        tabla_turno_data.SpacingBefore = 10
        document.Add(tabla_turno_data)
        document.Add(encabezado6)
        datatable.SpacingBefore = 10
        document.Add(datatable)
        document.Add(encabezadoLINE3)
        encabezado8.SpacingAfter = 4
        document.Add(encabezado8)
        document.Add(datatableIMP)
        document.Add(encabezadoLINE3)
        encabezado9.Alignment = Element.ALIGN_CENTER
        document.Add(encabezado9)
        datatable_det_ventas.SpacingBefore = 10
        document.Add(datatable_det_ventas)
        document.Add(encabezadoLINE3)


        document.Add(encabezado7)
        document.Add(encabezadoLINE)


    End Sub
    Private Sub Form_inf_diario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_inf_diario_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        DateTimePicker_diario_ValueChanged(Nothing, Nothing)
    End Sub

    Private Sub Form_inf_diario_DragOver(sender As Object, e As DragEventArgs) Handles Me.DragOver

    End Sub
End Class