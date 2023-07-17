Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.draw

Public Class Form_informeTurnos
    Public da_turnos As New MySqlDataAdapter
    Public dt_turnos As DataTable
    Dim alto_pag As Integer = 0


    Dim efectivo_actual, TTALVENTAS, TTALVENTASCREDITO, TTALRECIBOSCAJA, TTALEGRESOS, TTALCOMPRAS, TTALCOMPRASCREDITO, TTALDEVOLVENTA As Long



    Dim totalingresos As Long
    Dim totalEGRESOS As Long
    Dim total_gastos As Long
    Dim total_impuestos_turno As String = ""

    Dim TURNO_NUM As String = ""
    Dim TURNO_INI As String = ""
    Dim TURNO_FIN As String = ""
    Dim TURNO_EMPLEADO As String = ""
    Dim TURNO_FECHA As String = ""
    Dim TURNO_BASE As String = ""
    Dim TURNO_ESTADO As String = ""

    Dim TURNO_TTAL_VENTAS As String
    Dim TURNO_TTAL_OTROSINGRESOS As String
    Dim TURNO_TTAL_GASTOS As String
    Dim TURNO_TTAL_EGRESOS As String
    Dim TURNO_TTAL_DESCUENTOS As String
    Dim TURNO_TTAL_PROPINAS As String
    Dim TURNO_TTAL_IMPUESTOS As String
    Dim TURNO_TTAL_VENTA_NETA As String
    Dim TURNO_TTAL_VENTA_TOTAL As String
    Dim TURNO_TTAL_TOTAL_TURNO As String

    Public da_AGRUPACION As New MySqlDataAdapter
    Public dt_AGRUPACION As DataTable

    Private Sub Form_informeTurnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
    Private Sub Form_informeTurnos_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        DateTimePicker_diario.Value = DateTime.Now.ToShortDateString

    End Sub
    Private Sub DateTimePicker_diario_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker_diario.ValueChanged

        Me.Cursor = Cursors.WaitCursor

        MetroGrid_turnos_fecha.DataSource = Nothing
        DataGrid_caja.DataSource = Nothing

        MetroGrid_det_ventas.DataSource = Nothing
        MetroGrid_IMPTURNO.DataSource = Nothing


        LabelBasedeCaja.Text = "0"
        LabelVentaEfectivo.Text = "0"
        LabelVentaCredito.Text = "0"
        LabelOtrosIngresos.Text = "0"
        Label_propinas.Text = "0"
        Label_impuestosTURNO.Text = "0"
        Label_dctos.Text = "0"
        LabelVentaTotal.Text = "0"

        LabelComprasCredito.Text = ""
        LabelComprasEfectivo.Text = ""
        LabelGastos.Text = "0"
        Label_TOTAl_EGRESOS.Text = "0"

        Label_TOTAL_TOTAL.Text = "0"

        Label_EfectivoEnCaja.Text = "0"


        TURNO_NUM = ""
        TURNO_EMPLEADO = ""
        TURNO_FECHA = ""
        TURNO_INI = ""
        TURNO_FIN = ""
        TURNO_BASE = ""
        TURNO_ESTADO = ""

        ' impuestosDateTimePicker_diario.Value.ToString("dd/MM/yyyy")
        Try
            sql = "SELECT * FROM turnos where DATE_FORMAT(STR_TO_DATE(fecha,'%d/%m/%Y'),'%d/%m/%Y')='" & DateTimePicker_diario.Value.ToString("dd/MM/yyyy") & "'"

            da_turnos = New MySqlDataAdapter(sql, conex)
            dt_turnos = New DataTable
            da_turnos.Fill(dt_turnos)
            MetroGrid_turnos_fecha.DataSource = dt_turnos.DefaultView
            MetroGrid_turnos_fecha.Columns(0).HeaderText = "#Turno"
            MetroGrid_turnos_fecha.Columns(0).Width = 60
            MetroGrid_turnos_fecha.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            MetroGrid_turnos_fecha.Columns(1).Visible = False
            MetroGrid_turnos_fecha.Columns(2).Width = 220
            MetroGrid_turnos_fecha.Columns(3).Width = 80
            MetroGrid_turnos_fecha.Columns(4).Width = 80

            MetroGrid_turnos_fecha.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            MetroGrid_turnos_fecha.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


            MetroGrid_turnos_fecha.Columns(5).Visible = False
            MetroGrid_turnos_fecha.Columns(6).Visible = False
            MetroGrid_turnos_fecha.Columns(7).Visible = False


            MetroGrid_turnos_fecha.Columns(8).HeaderText = "Estado"
            MetroGrid_turnos_fecha.Columns(8).Width = 90
            MetroGrid_turnos_fecha.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'For Each row As DataRow In dt.Rows
            '    Label_estado.Text = CStr(row.Item("estado"))
            'Next
            'If Label_estado.Text = "ABIERTO" Then Label_estado.Text = "TURNO ABIERTO"
            'If Label_estado.Text = "TURN" Then Label_estado.Text = "TURNO CERRADO"
            MetroGrid_turnos_fecha.ClearSelection()
        Catch ex As Exception
        End Try
        conex.Close()
        da_turnos.Dispose()
        dt_turnos.Dispose()
        conex.Close()

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Buttonsalir_Click(sender As Object, e As EventArgs) Handles Buttonsalir.Click
        Me.Close()
    End Sub


    Private Sub MetroGrid_turnos_fecha_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid_turnos_fecha.CellClick
        ' click

        DataGrid_caja.DataSource = Nothing
        MetroGrid_det_ventas.DataSource = Nothing
        MetroGrid_IMPTURNO.DataSource = Nothing

        LabelBasedeCaja.Text = "0"
        LabelVentaEfectivo.Text = "0"
        LabelVentaCredito.Text = "0"
        LabelOtrosIngresos.Text = "0"
        Label_propinas.Text = "0"
        Label_impuestosTURNO.Text = "0"
        Label_dctos.Text = "0"
        LabelVentaTotal.Text = "0"

        LabelComprasCredito.Text = ""
        LabelComprasEfectivo.Text = ""
        LabelGastos.Text = "0"
        Label_TOTAl_EGRESOS.Text = "0"

        Label_TOTAL_TOTAL.Text = "0"

        Label_EfectivoEnCaja.Text = "0"


        TURNO_NUM = ""
        TURNO_EMPLEADO = ""
        TURNO_FECHA = ""
        TURNO_INI = ""
        TURNO_FIN = ""
        TURNO_BASE = ""
        TURNO_ESTADO = ""

        Dim row_TURNO As DataGridViewRow = MetroGrid_turnos_fecha.CurrentRow

        TURNO_NUM = CStr(row_TURNO.Cells("CONS").Value)
        TURNO_EMPLEADO = CStr(row_TURNO.Cells("EMPLEADO").Value)
        TURNO_FECHA = CStr(row_TURNO.Cells("FECHA").Value)
        TURNO_INI = CStr(row_TURNO.Cells("INICIO").Value)
        TURNO_FIN = CStr(row_TURNO.Cells("FIN").Value)
        TURNO_BASE = CStr(row_TURNO.Cells("BASE").Value)

        TURNO_ESTADO = CStr(row_TURNO.Cells("ESTADO").Value)


        If TURNO_ESTADO = "ABIERTO" Then Label_estado.Text = "CAJA ABIERTA"
        If TURNO_ESTADO = "CERRADO" Then Label_estado.Text = "CAJA CERRADA"


        grid_CAJA()

    End Sub
    Private Sub grid_CAJA()
        ' ventas todos los turnos toda la caja

        LabelBasedeCaja.Text = "0"
        LabelVentaEfectivo.Text = "0"
        LabelVentaCredito.Text = "0"
        LabelOtrosIngresos.Text = "0"
        Label_propinas.Text = "0"
        Label_impuestosTURNO.Text = "0"
        Label_dctos.Text = "0"
        LabelVentaTotal.Text = "0"

        LabelComprasCredito.Text = ""
        LabelComprasEfectivo.Text = ""
        LabelGastos.Text = "0"
        Label_TOTAl_EGRESOS.Text = "0"

        Label_TOTAL_TOTAL.Text = "0"

        Label_EfectivoEnCaja.Text = "0"




        Try
            sql = "SELECT * FROM caja WHERE estado='DESCARGADO' and turno='" & TURNO_NUM & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGrid_caja.DataSource = dt
            Me.DataGrid_caja.Columns(0).Visible = False
            Me.DataGrid_caja.Columns(1).Visible = False
            Me.DataGrid_caja.Columns(2).Visible = False
            Me.DataGrid_caja.Columns(9).Visible = False
            Me.DataGrid_caja.Columns(10).Visible = False
            da.Dispose()
            dt.Dispose()
            conex.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            For i As Integer = 0 To DataGrid_caja.RowCount - 1
                'If DataGrid_caja.Item("mediodepago", i).Value <> "CREDITO" Then
                '    'INGRESOS
                '    If DataGrid_caja.Item("tipodocumento", i).Value = "VENTA" Then TURNO_TTAL_VENTAS = TURNO_TTAL_VENTAS + DataGrid_caja.Item("total", i).Value
                '    If DataGrid_caja.Item("tipodocumento", i).Value = "COBRO CREDITO" Then TURNO_TTAL_OTROSINGRESOS = TURNO_TTAL_OTROSINGRESOS + DataGrid_caja.Item("total", i).Value
                '    If DataGrid_caja.Item("tipodocumento", i).Value = "RECIBO DE CAJA" Then TURNO_TTAL_OTROSINGRESOS = TURNO_TTAL_OTROSINGRESOS + DataGrid_caja.Item("total", i).Value
                '    'EGRESOS
                '    If DataGrid_caja.Item("tipodocumento", i).Value = "COMPRA" Then TURNO_TTAL_EGRESOS = TURNO_TTAL_EGRESOS + DataGrid_caja.Item("total", i).Value
                '    If DataGrid_caja.Item("tipodocumento", i).Value = "GASTO" Then TURNO_TTAL_GASTOS = TURNO_TTAL_GASTOS + DataGrid_caja.Item("total", i).Value
                '    If DataGrid_caja.Item("tipodocumento", i).Value = "COMPROBANTE DE EGRESO" Then TURNO_TTAL_EGRESOS = TURNO_TTAL_EGRESOS + DataGrid_caja.Item("total", i).Value
                '    If DataGrid_caja.Item("tipodocumento", i).Value = "Devolución Venta" Then TURNO_TTAL_EGRESOS = TURNO_TTAL_EGRESOS + DataGrid_caja.Item("total", i).Value
                'End If
                'If DataGrid_caja.Item("mediodepago", i).Value.ToString.Contains("CREDITO") Then
                '    If DataGrid_caja.Item("tipodocumento", i).Value = "VENTA" Then TURNO_TTAL_VENTAS = TURNO_TTAL_VENTAS + DataGrid_caja.Item("total", i).Value
                'End If

                If DataGrid_caja.Item("tipodocumento", i).Value = "VENTA" Then
                    TTALVENTAS = TTALVENTAS + DataGrid_caja.Item("total", i).Value
                    If DataGrid_caja.Item("mediodepago", i).Value.ToString.ToUpper.Contains("CREDITO") = True Then
                        TTALVENTASCREDITO = TTALVENTASCREDITO + DataGrid_caja.Item("total", i).Value
                    End If
                End If


                If DataGrid_caja.Item("tipodocumento", i).Value = "COMPRA" Then
                    TTALCOMPRAS = TTALCOMPRAS + DataGrid_caja.Item("total", i).Value
                    If DataGrid_caja.Item("mediodepago", i).Value.ToString.ToUpper.Contains("CREDITO") = True Then
                        TTALCOMPRASCREDITO = TTALCOMPRASCREDITO + DataGrid_caja.Item("total", i).Value
                    End If
                End If


                If DataGrid_caja.Item("tipodocumento", i).Value = "RECIBO DE CAJA" Then
                    TTALRECIBOSCAJA = TTALRECIBOSCAJA + DataGrid_caja.Item("total", i).Value
                End If

                If DataGrid_caja.Item("tipodocumento", i).Value = "COMPROBANTE DE EGRESO" Then
                    TTALEGRESOS = TTALEGRESOS + DataGrid_caja.Item("total", i).Value
                End If

                If DataGrid_caja.Item("tipodocumento", i).Value = "Devolución Venta" Then
                    TTALDEVOLVENTA = TTALDEVOLVENTA + DataGrid_caja.Item("total", i).Value
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        LabelBasedeCaja.Text = TURNO_BASE

        LabelVentaTotal.Text = TTALVENTAS + TTALRECIBOSCAJA
        LabelVentaCredito.Text = TTALVENTASCREDITO
        LabelOtrosIngresos.Text = TTALRECIBOSCAJA
        LabelVentaEfectivo.Text = TTALVENTAS - TTALVENTASCREDITO


        LabelGastos.Text = TTALEGRESOS
        LabelComprasEfectivo.Text = TTALCOMPRAS - TTALCOMPRASCREDITO
        LabelComprasCredito.Text = TTALCOMPRASCREDITO

        Label_TOTAl_EGRESOS.Text = TTALCOMPRAS + TTALEGRESOS + TTALDEVOLVENTA

        Me.Label_TOTAL_TOTAL.Text = ((TTALVENTAS + TTALRECIBOSCAJA - TTALVENTASCREDITO)) - ((TTALCOMPRAS + TTALEGRESOS + TTALDEVOLVENTA) - TTALCOMPRASCREDITO)


        efectivo_actual = 0
        efectivo_actual = CInt(LabelBasedeCaja.Text) + Me.Label_TOTAL_TOTAL.Text

        Label_EfectivoEnCaja.Text = FormatNumber(efectivo_actual, 0)


        'DESCUENTOS
        Try
            sql = "SELECT SUM(DESCUENTO) AS DESCUENTO FROM ventas WHERE turno='" & TURNO_NUM & "' AND ESTADO<>'ANULADA'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row3 As DataRow In dt.Rows
                If row3.Item("DESCUENTO").ToString <> "" Then
                    TURNO_TTAL_DESCUENTOS = CInt(TURNO_TTAL_DESCUENTOS) + CDec(row3.Item("DESCUENTO"))
                End If
            Next
            da.Dispose()
            dt.Dispose()
            conex.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        'PROPINAS
        Try
            sql = "SELECT SUM(PROPINA) AS PROPINA FROM ventas WHERE turno='" & TURNO_NUM & "' AND ESTADO<>'ANULADA'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row3 As DataRow In dt.Rows
                If row3.Item("PROPINA").ToString <> "" Then
                    TURNO_TTAL_PROPINAS = CInt(TURNO_TTAL_PROPINAS) + CDec(row3.Item("PROPINA"))
                End If
            Next
            da.Dispose()
            dt.Dispose()
            conex.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Label_propinas.Text = Format(CDec(Label_propinas.Text), "##,##0")

        TURNO_TTAL_IMPUESTOS = 0
        ' impuestos
        Try
            sql = "SELECT  ventas_prods.ImpNom2 as impuesto, FORMAT(sum(ventas_prods.valortotal-ventas_prods.impuesto2),0) as Base, FORMAT(sum(ventas_prods.impuesto2),0) as Valor, FORMAT(sum(ventas_prods.valortotal),0) as Total
FROM ventas_prods
left join ventas on ventas_prods.documento=ventas.documento
LEFT JOIN DEVOLUCIONES_PRODS ON ventas_prods.documento=DEVOLUCIONES_PRODS.DOCUMENTO
where ventas.turno='" & TURNO_NUM & "'
group by ventas_prods.impnom2"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            MetroGrid_IMPTURNO.DataSource = dt.DefaultView
            total_impuestos_turno = "0"
            For Each row3 As DataRow In dt.Rows
                If row3.Item("impuesto") <> "NO" Then TURNO_TTAL_IMPUESTOS = CInt(TURNO_TTAL_IMPUESTOS) + CDec(row3.Item("valor"))
            Next
        Catch ex As Exception
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()


        'detalle de ventas
        Try
            sql = "SELECT ventas.documento, concat(ventas.DocCliente,' ', ventas.ClienteNom) as Cliente, 
ventas_prods.CodProd, ventas_prods.Producto, ventas_prods.cantidad,
ventas.Salon, ventas.Mesa, ventas.Mesero, ventas.Total, ventas.MediodePago, ventas.propina, ventas.cambio 
FROM ventas
inner join ventas_prods 
on ventas.documento=ventas_prods.documento 
WHERE ventas.turno='" & TURNO_NUM & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.MetroGrid_det_ventas.DataSource = dt
            MetroGrid_det_ventas.Columns(0).Visible = False
            MetroGrid_det_ventas.Columns(1).Visible = False

            da.Dispose()
            dt.Dispose()
            conex.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


        'QUITO LA COMA ,
        TURNO_TTAL_IMPUESTOS = TURNO_TTAL_IMPUESTOS.Replace(",", "")




        LabelBasedeCaja.Text = FormatNumber(CInt(LabelBasedeCaja.Text), 0)
        LabelVentaEfectivo.Text = FormatNumber(CInt(LabelVentaEfectivo.Text), 0)
        LabelVentaCredito.Text = FormatNumber(CInt(LabelVentaCredito.Text), 0)
        LabelOtrosIngresos.Text = FormatNumber(CInt(LabelOtrosIngresos.Text), 0)
        Label_propinas.Text = FormatNumber(CInt(Label_propinas.Text), 0)
        Label_impuestosTURNO.Text = FormatNumber(CInt(Label_impuestosTURNO.Text), 0)
        Label_dctos.Text = FormatNumber(CInt(Label_dctos.Text), 0)
        LabelVentaTotal.Text = FormatNumber(CInt(LabelVentaTotal.Text), 0)

        LabelComprasCredito.Text = FormatNumber(CInt(LabelComprasCredito.Text), 0)
        LabelComprasEfectivo.Text = FormatNumber(CInt(LabelComprasEfectivo.Text), 0)
        LabelGastos.Text = FormatNumber(CInt(LabelGastos.Text), 0)
        Label_TOTAl_EGRESOS.Text = FormatNumber(CInt(Label_TOTAl_EGRESOS.Text), 0)


        Label_EfectivoEnCaja.Text = FormatNumber(CInt(Label_EfectivoEnCaja.Text), 0)

        Label_TOTAL_TOTAL.Text = FormatNumber(CInt(Label_TOTAL_TOTAL.Text), 0)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TURNO_NUM = "" Then MsgBox("seleccione un turno.") : Exit Sub

        Me.Cursor = Cursors.WaitCursor


        ' ventas  turno  caja
        totalingresos = 0
        Try
            sql = "SELECT caja.tipodocumento AS Comprobante, caja.MedioDePago as MedioPago, format(SUM(caja.Total),0) AS TOTAL 
FROM caja where caja.turno='" & TURNO_NUM & "' GROUP BY caja.tipodocumento, caja.MediodePago"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DATAGrid_PDF.DataSource = dt

            da.Dispose()
            dt.Dispose()
            conex.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try



        Try
            sql = "/*ventas por productco*/
SELECT CONCAT(ventas_prods.CodProd,'-',ventas_prods.Producto) AS Producto, sum(ventas_prods.cantidad) as Cant,
format(sum(ventas_prods.valortotal),0)  as Total
FROM ventas
inner join ventas_prods 
on ventas.documento=ventas_prods.documento where ventas.turno='" & TURNO_NUM & "'
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
            alto_pag = (DATAGrid_PDF.RowCount + DATAGrid_PDF.RowCount) * 20 + 700

            Dim pgSize = New iTextSharp.text.Rectangle(205, alto_pag)

            'Dim doc As New Document(PageSize.A4, 8, 400, 10, 10)
            Dim doc As New Document(pgSize, 8, 8, 10, 10)


            'Path que guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\CIERRE DE TURNO " & TURNO_NUM & ".pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)

            PdfWriter.GetInstance(doc, file)
            doc.Open()
            ExportarDatosPDF_POS(doc)
            doc.Close()

            Process.Start("C:\Program Files\Tracker Software\PDF Viewer\pdfxcview.exe", """" & Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\CIERRE DE TURNO " & TURNO_NUM & ".pdf" & """")


        Catch ex As Exception
            'Si el intento es fallido, mostrar MsgBox.
            Me.Cursor = Cursors.Default
            MessageBox.Show("No se puede generar el documento PDF, Cierre los documentos PDF generados anteriormente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Cursor = Cursors.Default
    End Sub


    Public Sub ExportarDatosPDF_POS(ByVal document As Document)
        Dim CANT_FILAS As Integer = 0
        'Se crea un objeto PDFTable con el numero de columnas del DataGridView.
        Dim datatable As New PdfPTable(DATAGrid_PDF.ColumnCount)

        Dim datatableIMP As New PdfPTable(MetroGrid_IMPTURNO.ColumnCount)

        'Se asignan algunas propiedades para el diseño del PDF.
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(DATAGrid_PDF)

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

        Dim encabezadoLINE As New Paragraph("|=======================================|", fontLINE)

        encabezadoLINE.Alignment = 0
        encabezadoLINE.Font = fontLINE

        Dim encabezadoLINE2 As New Paragraph("========================================", fontLINE)
        Dim encabezadoLINE3 As New Paragraph("________________________________________", fontLINE)

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

        cellhome.Phrase = New Phrase("Tels:" & comex_tels & " - " & comex_cels & " " & comex_dircomercio & " " & comex_ciudad, FontFactory.GetFont(FontFactory.COURIER_BOLD, 8, iTextSharp.text.Font.NORMAL))
        cellhome.HorizontalAlignment = Element.ALIGN_CENTER
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()


        Dim TURNO_ESTADO_PRINT As String = ""
        If TURNO_ESTADO = "ABIERTO" Then TURNO_ESTADO_PRINT = "PARCIAL DE TURNO #"
        If TURNO_ESTADO = "CERRADO" Then TURNO_ESTADO_PRINT = "CIERRE DE TURNO #"
        Dim encabezado As New Paragraph(TURNO_ESTADO_PRINT & TURNO_NUM, FontFactory.GetFont(FontFactory.COURIER_BOLD, 10, iTextSharp.text.Font.NORMAL))
        encabezado.Alignment = Element.ALIGN_CENTER

        Dim encabezadotipo As New Paragraph("INFORME(X) DE CAJA", FontFactory.GetFont(FontFactory.COURIER_BOLD, 10, iTextSharp.text.Font.NORMAL))
        encabezadotipo.Alignment = Element.ALIGN_CENTER


        Dim PDF_temrinal As New Paragraph("Terminal:" & SERIAL_PROC, FontFactory.GetFont(FontFactory.COURIER_BOLD, 7.5D, iTextSharp.text.Font.NORMAL)) : PDF_temrinal.Alignment = Element.ALIGN_CENTER
        Dim PDF_CONSECUTIVO As New Paragraph("Empleado. " + Chr(13) + TURNO_EMPLEADO, FontFactory.GetFont(FontFactory.COURIER_BOLD, 7.5D, iTextSharp.text.Font.NORMAL)) : PDF_CONSECUTIVO.Alignment = 0
        Dim encabezado2 As New Paragraph("Fecha: " + TURNO_FECHA, FontFactory.GetFont(FontFactory.COURIER_BOLD, 7.5D, iTextSharp.text.Font.NORMAL)) : encabezado2.Alignment = 0
        Dim encabezado3 As New Paragraph("Inicio:" + TURNO_INI + " Fin:" + TURNO_FIN, FontFactory.GetFont(FontFactory.COURIER_BOLD, 7.5D, iTextSharp.text.Font.NORMAL)) : encabezado2.Alignment = 0



        Dim tabla_turno_data As New PdfPTable(2)
        tabla_turno_data.WidthPercentage = 100
        tabla_turno_data.DefaultCell.Padding = 0
        tabla_turno_data.DefaultCell.BorderWidth = 0
        tabla_turno_data.SpacingBefore = 0
        tabla_turno_data.HorizontalAlignment = 0
        Dim cellturno As New PdfPCell
        cellturno.BorderWidth = 0


        cellturno.Phrase = New Phrase("(+)Base: $", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Format(CInt(LabelBasedeCaja.Text), "##,##"), DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("(+)Ventas: $", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Format(CInt(LabelVentaTotal.Text) - CInt(total_impuestos_turno), "##,##"), DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("(-)Descuentos: $", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase("0", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("===============", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase("===============", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("VENTAS NETAS: $", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Format(CInt(CInt(LabelVentaTotal.Text) - CInt(total_impuestos_turno)), "##,##"), DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("(+)impuestos: $", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Format(CInt(total_impuestos_turno), "##,##"), DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("================", DIRFont)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase("================", DIRFont)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea


        cellturno.Phrase = New Phrase("TOTAL VENTAS: $", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Format(CInt(LabelVentaTotal.Text), "##,##"), DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea



        cellturno.Phrase = New Phrase("(+)Propinas: $", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Label_propinas.Text, DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea


        cellturno.Phrase = New Phrase("(-)Gastos: $", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Format(CInt(Label_TOTAl_EGRESOS.Text), "##,##"), DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea


        cellturno.Phrase = New Phrase("================", DIRFont)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase("================", DIRFont)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("TOTAL TURNO: $", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Format(CInt(CInt(LabelVentaTotal.Text) - CInt(Label_TOTAl_EGRESOS.Text)), "##,##"), DIRFont9)
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
        For i As Integer = 0 To DATAGrid_PDF.ColumnCount - 1
            Dim HEADERCELLFont = FontFactory.GetFont(FontFactory.COURIER_BOLD, 7.5D, iTextSharp.text.Font.BOLD)

            Dim cell_TITLE As New PdfPCell
            cell_TITLE.Phrase = New Phrase(DATAGrid_PDF.Columns(i).HeaderText, HEADERCELLFont)
            cell_TITLE.HorizontalAlignment = Element.ALIGN_CENTER
            cell_TITLE.BackgroundColor = BaseColor.LIGHT_GRAY
            cell_TITLE.Border = 0

            datatable.AddCell(cell_TITLE)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 0
        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To DATAGrid_PDF.RowCount - 1
            For j As Integer = 0 To DATAGrid_PDF.ColumnCount - 1
                Dim cell As New PdfPCell
                cell.Phrase = New Phrase(DATAGrid_PDF(j, i).FormattedValue.ToString, FontFactory.GetFont(FontFactory.COURIER, 7D, iTextSharp.text.Font.BOLD))
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
where ventas.TURNO='" & TURNO_NUM & "' group by ventas_prods.CodProd"
            da_AGRUPACION = New MySqlDataAdapter(sql, conex)
            dt_AGRUPACION = New DataTable
            da_AGRUPACION.Fill(dt_AGRUPACION)
            For Each row3 As DataRow In dt_AGRUPACION.Rows
                'CStr(row3.Item("CATEGORIA"))


                Try
                    sql = "SELECT CONCAT(ventas_prods.CodProd,'-',ventas_prods.Producto) AS Producto, sum(ventas_prods.cantidad) as Cant,
format(ventas_prods.valortotal,0)  as Total
FROM ventas
inner join ventas_prods 
on ventas.documento=ventas_prods.documento 
INNER JOIN PRODUCTOS ON VENTAS_PRODS.CODPROD=PRODUCTOS.COD
INNER JOIN PRODUCTOS_CATEGORIAS ON PRODUCTOS.CATEGORIA=PRODUCTOS_CATEGORIAS.CATEGORIA
where ventas.TURNO='" & TURNO_NUM & "' AND PRODUCTOS_CATEGORIAS.CATEGORIA='" & CStr(row3.Item("CATEGORIA")) & "' group by ventas_prods.CodProd"
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
        document.Add(PDF_CONSECUTIVO)
        document.Add(encabezado2)
        document.Add(encabezado3)
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


    Private Sub MetroGrid_turnos_fecha_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid_turnos_fecha.CellContentClick

    End Sub

    Private Sub Button_export_Click(sender As Object, e As EventArgs) Handles Button_export.Click
        If TURNO_NUM = "" Then MsgBox("seleccione un turno.") : Exit Sub


        Me.Cursor = Cursors.WaitCursor


        ' ventas  turno  caja
        totalingresos = 0
        Try
            sql = "SELECT caja.tipodocumento AS Comprobante, caja.MediodePago as MedioPago, format(SUM(caja.Total),0) AS TOTAL 
FROM caja where caja.turno='" & TURNO_NUM & "' GROUP BY caja.tipodocumento, caja.MediodePago"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DATAGrid_PDF.DataSource = dt

            da.Dispose()
            dt.Dispose()
            conex.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try





        Try
            sql = "/*ventas por productco*/
SELECT CONCAT(ventas_prods.CodProd,'-',ventas_prods.Producto) AS Producto, sum(ventas_prods.cantidad) as Cant,
format(sum(ventas_prods.valortotal),0)  as Total
FROM ventas
inner join ventas_prods 
on ventas.documento=ventas_prods.documento where ventas.turno='" & TURNO_NUM & "'
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
            Dim pgSize = New iTextSharp.text.Rectangle(250, DATAGrid_PDF.RowCount * 10 + 200)

            Dim doc As New Document(PageSize.A4, 15, 15, 15, 15)
            'Dim doc As New Document(pgSize, 8, 8, 10, 10)

            'Path que guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\CIERRE DE TURNO " & TURNO_NUM & ".pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)

            PdfWriter.GetInstance(doc, file)
            doc.Open()
            ExportarDatosPDF_CARTA(doc)
            doc.Close()
            Process.Start(filename)
        Catch ex As Exception
            'Si el intento es fallido, mostrar MsgBox.
            Me.Cursor = Cursors.Default
            MessageBox.Show("No se puede generar el documento PDF, Cierre los documentos PDF generados anteriormente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Cursor = Cursors.Default
    End Sub


    Public Sub ExportarDatosPDF_CARTA(ByVal document As Document)
        Dim CANT_FILAS As Integer = 0
        'Se crea un objeto PDFTable con el numero de columnas del DataGridView.
        Dim datatable As New PdfPTable(DATAGrid_PDF.ColumnCount)

        Dim datatableIMP As New PdfPTable(MetroGrid_IMPTURNO.ColumnCount)

        'Se asignan algunas propiedades para el diseño del PDF.
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(DATAGrid_PDF)

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

        Dim encabezadoLINE As New Paragraph("|=======================================================================================================================|", fontLINE)

        encabezadoLINE.Alignment = 0
        encabezadoLINE.Font = fontLINE

        Dim encabezadoLINE2 As New Paragraph("========================================================================================================================", fontLINE)
        Dim encabezadoLINE3 As New Paragraph("_______________________________________________________________________________________________________________________________", fontLINE)

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


        cellhome.Phrase = New Phrase(comex_nombrecomercial, contentFont)
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase(comex_nombrepropietario, DIRFont)
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase("NIT:" & comex_nit & "-" & comex_DV & " " & comex_regimen, DIRFont)
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase(comex_dircomercio + " Tels:" & comex_tels & " " & comex_cels, DIRFont)
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()


        Dim TURNO_ESTADO_PRINT As String = ""
        If TURNO_ESTADO = "ABIERTO" Then TURNO_ESTADO_PRINT = "PARCIAL DE TURNO #"
        If TURNO_ESTADO = "CERRADO" Then TURNO_ESTADO_PRINT = "CIERRE DE TURNO #"
        Dim encabezado As New Paragraph(TURNO_ESTADO_PRINT & TURNO_NUM, encabezadoFont)
        encabezado.Alignment = Element.ALIGN_CENTER
        encabezado.Font = encabezadoFont


        Dim PDF_temrinal As New Paragraph("Terminal:" & SERIAL_PROC, DIRFont) : PDF_temrinal.Alignment = Element.ALIGN_CENTER
        Dim PDF_CONSECUTIVO As New Paragraph("Empleado. " + Chr(13) + TURNO_EMPLEADO, DIRFont) : PDF_CONSECUTIVO.Alignment = Element.ALIGN_CENTER
        Dim encabezado2 As New Paragraph("Fecha: " + TURNO_FECHA, DIRFont) : encabezado2.Alignment = Element.ALIGN_CENTER
        Dim encabezado3 As New Paragraph("Inicio:" + TURNO_INI + " Fin:" + TURNO_FIN, DIRFont) : encabezado3.Alignment = Element.ALIGN_CENTER



        Dim tabla_turno_data As New PdfPTable(2)
        tabla_turno_data.WidthPercentage = 100
        tabla_turno_data.DefaultCell.Padding = 0
        tabla_turno_data.DefaultCell.BorderWidth = 0
        tabla_turno_data.SpacingBefore = 0
        tabla_turno_data.HorizontalAlignment = 0
        Dim cellturno As New PdfPCell
        cellturno.BorderWidth = 0


        cellturno.Phrase = New Phrase("(+)Base: $", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Format(CInt(LabelBasedeCaja.Text), "##,##"), DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("(+)Ventas: $", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Format(CInt(LabelVentaTotal.Text) - CInt(total_impuestos_turno), "##,##"), DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("(-)Descuentos: $", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase("0", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("===============", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase("===============", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("VENTAS NETAS: $", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Format(CInt(CInt(LabelVentaTotal.Text) - CInt(total_impuestos_turno)), "##,##"), DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("(+)impuestos: $", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Format(CInt(total_impuestos_turno), "##,##"), DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("================", DIRFont)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase("================", DIRFont)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea


        cellturno.Phrase = New Phrase("TOTAL VENTAS: $", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Format(CInt(LabelVentaTotal.Text), "##,##"), DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea



        cellturno.Phrase = New Phrase("(+)Propinas: $", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Label_propinas.Text, DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea


        cellturno.Phrase = New Phrase("(-)Gastos: $", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Format(CInt(Label_TOTAl_EGRESOS.Text), "##,##"), DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea


        cellturno.Phrase = New Phrase("================", DIRFont)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase("================", DIRFont)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("TOTAL TURNO: $", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Format(CInt(CInt(LabelVentaTotal.Text) - CInt(Label_TOTAl_EGRESOS.Text)), "##,##"), DIRFont9)
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
            cell_TITLE.Phrase = New Phrase(MetroGrid_IMPTURNO.Columns(i).HeaderText, HEADERCELLFont)
            cell_TITLE.HorizontalAlignment = Element.ALIGN_CENTER
            cell_TITLE.BackgroundColor = BaseColor.LIGHT_GRAY
            datatableIMP.AddCell(cell_TITLE)
        Next
        datatableIMP.HeaderRows = 1
        datatableIMP.DefaultCell.BorderWidth = 0
        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To MetroGrid_IMPTURNO.RowCount - 1
            For j As Integer = 0 To MetroGrid_IMPTURNO.ColumnCount - 1
                Dim cell As New PdfPCell
                cell.Phrase = New Phrase(MetroGrid_IMPTURNO(j, i).FormattedValue.ToString, rowFont)
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
        For i As Integer = 0 To DATAGrid_PDF.ColumnCount - 1
            Dim HEADERCELLFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 8, iTextSharp.text.Font.BOLD)

            Dim cell_TITLE As New PdfPCell
            cell_TITLE.Phrase = New Phrase(DATAGrid_PDF.Columns(i).HeaderText, HEADERCELLFont)
            cell_TITLE.HorizontalAlignment = Element.ALIGN_CENTER
            cell_TITLE.BackgroundColor = BaseColor.LIGHT_GRAY
            datatable.AddCell(cell_TITLE)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 0
        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To DATAGrid_PDF.RowCount - 1
            For j As Integer = 0 To DATAGrid_PDF.ColumnCount - 1
                Dim cell As New PdfPCell
                cell.Phrase = New Phrase(DATAGrid_PDF(j, i).FormattedValue.ToString, rowFont)
                If j = 0 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 1 Then cell.HorizontalAlignment = Element.ALIGN_CENTER
                If j = 2 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT : cell.BackgroundColor = BaseColor.LIGHT_GRAY
                If j = 3 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT : cell.BackgroundColor = BaseColor.LIGHT_GRAY
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



        ' AGRUPACION
        Try
            sql = "SELECT DISTINCT(PRODUCTOS_CATEGORIAS.CATEGORIA)
FROM ventas
inner join ventas_prods 
on ventas.documento=ventas_prods.documento 
INNER JOIN PRODUCTOS ON VENTAS_PRODS.CODPROD=PRODUCTOS.COD
INNER JOIN PRODUCTOS_CATEGORIAS ON PRODUCTOS.CATEGORIA=PRODUCTOS_CATEGORIAS.CATEGORIA
where ventas.TURNO='" & TURNO_NUM & "' group by ventas_prods.CodProd"
            da_AGRUPACION = New MySqlDataAdapter(sql, conex)
            dt_AGRUPACION = New DataTable
            da_AGRUPACION.Fill(dt_AGRUPACION)
            For Each row3 As DataRow In dt_AGRUPACION.Rows
                'CStr(row3.Item("CATEGORIA"))


                Try
                    sql = "SELECT CONCAT(ventas_prods.CodProd,'-',ventas_prods.Producto) AS Producto, sum(ventas_prods.cantidad) as Cant,
format(sum(ventas_prods.valortotal),0)  as Total
FROM ventas
inner join ventas_prods 
on ventas.documento=ventas_prods.documento 
INNER JOIN PRODUCTOS ON VENTAS_PRODS.CODPROD=PRODUCTOS.COD
INNER JOIN PRODUCTOS_CATEGORIAS ON PRODUCTOS.CATEGORIA=PRODUCTOS_CATEGORIAS.CATEGORIA
where ventas.TURNO='" & TURNO_NUM & "' AND PRODUCTOS_CATEGORIAS.CATEGORIA='" & CStr(row3.Item("CATEGORIA")) & "' group by ventas_prods.CodProd"
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
                cell_CAT.Phrase = New Phrase("( " + CStr(row3.Item("CATEGORIA")) + " )", iTextSharp.text.FontFactory.GetFont("Arial Black", 9, iTextSharp.text.Font.BOLD))
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
                    cell_TITLE.Phrase = New Phrase(MetroGrid_det_ventas.Columns(i).HeaderText, HEADERCELLFont)
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
                        cell.Phrase = New Phrase(MetroGrid_det_ventas(j, i).FormattedValue.ToString, rowFont)
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

        If comex_logo <> "" And File.Exists(comex_logo) = True Then
            Dim imagelogogopdf As iTextSharp.text.Image 'Declaracion de una imagen

            imagelogogopdf = iTextSharp.text.Image.GetInstance(comex_logo) 'Dirreccion a la imagen que se hace referencia
            imagelogogopdf.Alignment = Element.ALIGN_RIGHT
            imagelogogopdf.SetAbsolutePosition(410, 765) 'Posicion en el eje cartesiano
            imagelogogopdf.ScaleAbsoluteWidth(160) 'Ancho de la imagen
            imagelogogopdf.ScaleAbsoluteHeight(50) 'Altura de la imagen
            document.Add(imagelogogopdf) ' Agrega la imagen al documento
        End If

        document.Add(encabezadoLINE)
        document.Add(tablahome)
        document.Add(encabezadoLINE2)
        document.Add(encabezado)
        document.Add(PDF_temrinal)
        document.Add(PDF_CONSECUTIVO)
        document.Add(encabezado2)
        document.Add(encabezado3)
        document.Add(encabezado_resumenOP)
        tabla_turno_data.SpacingBefore = 10
        document.Add(tabla_turno_data)
        document.Add(encabezado6)
        datatable.SpacingBefore = 10
        document.Add(datatable)
        document.Add(encabezadoLINE3)
        encabezado9.Alignment = Element.ALIGN_CENTER
        document.Add(encabezado9)
        datatable_det_ventas.SpacingBefore = 10
        document.Add(datatable_det_ventas)
        document.Add(encabezadoLINE3)
        encabezado8.SpacingAfter = 4
        document.Add(encabezado8)
        document.Add(datatableIMP)
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


    Private Sub TextBox_base_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox_base_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.KeyChar = ""
    End Sub

    Private Sub MetroGrid_turnos_fecha_CellBorderStyleChanged(sender As Object, e As EventArgs) Handles MetroGrid_turnos_fecha.CellBorderStyleChanged

    End Sub

    Private Sub Label_estado_Click(sender As Object, e As EventArgs) Handles Label_estado.Click

    End Sub


End Class