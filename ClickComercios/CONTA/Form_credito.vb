Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.draw
Public Class Form_credito
    Dim cuenta_contable As String = ""

    Dim QUE_HACE_CREDITO As String

    Dim QUE_HACE_CLIENTE As String
    Dim COD_CREDITO As String = ""

    Dim cli_nom, cli_tel, cli_dir, cli_doc, cli_mail As String

    Dim PROD_SALDO, PROD_ENTRAN, PROD_SALEN As Integer

    Private Sub Btn_nuevo_cartera_Click(sender As Object, e As EventArgs) Handles Btn_nuevo_cartera.Click
        QUE_HACE_CREDITO = "CREAR"

        dataGrid_credito.Visible = False
        Panel_botones.Visible = False
        Label_panel_total_cartera.Visible = False
        Panel_total_cartera.Visible = False
        Label_tiitulo_cartera.Visible = False

        Panel1.Visible = False


        Label15.Visible = True

        Button_contabilizar_credito.Visible = False
        Button_exportar_credito.Visible = False


        'CONSECUTIVO
        consecutivo = 0
        cmd.Connection = conex
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select max(documento) + 1 from carteracredito WHERE TIPO='CREDITO'"
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
        TextBox_nro_cuenta.Text = consecutivo


        DateTimePicker_fecha.Value = DateTime.Now
        'TextBox_fecha_cartera.Text = DateTimePicker_fecha_cartera.Value.ToShortDateString
        TextBox_estado.Text = "NUEVO"
        TextBox_valor_cuenta.Text = 0
        TextBox_saldo.Text = 0
        datagrid_historial_credito.DataSource = Nothing
        Panel_bonotes2.Visible = True

        TextBox_vencimiento.Text = ""
        Label_empleado.Text = usrnom



    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Button_guardar_credito_Click(sender As Object, e As EventArgs) Handles Button_guardar_credito.Click
        If TextBox_valor_cuenta.Text = 0 Or TextBox_valor_cuenta.Text = "" Then
            MsgBox("La cuenta de debe tener un valor.", vbInformation)
            Exit Sub
        End If

        If TXT_DOC_CLIENTE.Text = "" Then
            MsgBox("La cuenta de debe tener un deudor (cliente).", vbInformation)
            Exit Sub
        End If

        If ComboBox_tipo_CuentaxPagar.Text = "" Or Nothing Then MsgBox("Seleccione un tipo de cuenta por pagar", vbInformation) : Exit Sub


        If ComboBox_tipo_CuentaxPagar.Text = "Cuenta Corriente Comercial" Then cuenta_contable = "2305"
        If ComboBox_tipo_CuentaxPagar.Text = "Cuenta Por Pagar a Proveedores" Then cuenta_contable = "2205"

        Dim TIPO_DOCUMENTO As String = "FACTURA DE VENTA"
        If TextBox_nro_fac_credito.Text <> "" Then TIPO_DOCUMENTO = ""

        sql = "INSERT INTO carteracredito(
        `Consecutivo`,
        `Tipo`,
        `Fecha`,
        `ClienteDoc`,
        `ClienteNom`,
        `TipoDoc`,
        `Documento`,
        `Concepto`,
        `valor`,
        `saldo`,
        `vencimiento`,
        `responsable`,
        `estado`)
        VALUES(" & CLng(consecutivo) & ",'CREDITO','" & TextBox_fecha.Text & "','" & CStr(TXT_DOC_CLIENTE.Text) & "','" & CStr(TXT_NOM_CLIENTE.Text) & "','FACTURA DE COMPRA','" & TextBox_nro_fac_credito.Text & "','" & TextBox_concepto.Text & "','" & TextBox_valor_cuenta.Text & "','" & TextBox_saldo.Text & "','" & TextBox_vencimiento.Text & "','" & Label_empleado.Text & "','PENDIENTE')"
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


        Button_contabilizar_credito_Click(Nothing, Nothing)



        MsgBox("Se Creó una nueva cuenta por pagar.", vbInformation)

        Button_regresar_credito_Click(Nothing, Nothing)
        GRID_credito()
    End Sub

    Private Sub Button_regresar_credito_Click(sender As Object, e As EventArgs) Handles Button_regresar_credito.Click
        Panel_bonotes2.Visible = False
        Panel_botones.Visible = True
        Panel_total_cartera.Visible = True
        Label_panel_total_cartera.Visible = True

        dataGrid_credito.Visible = True


        Panel1.Visible = False


        Label15.Visible = False
        Label_tiitulo_cartera.Visible = True

        COD_CREDITO = ""
        TextBox_nro_cuenta.Text = ""
        TextBox_estado.Text = ""
        TextBox_abonos.Text = "0"
        GRID_credito()

        datagrid_historial_credito.DataSource = Nothing
    End Sub

    Private Sub Button_contabilizar_credito_Click(sender As Object, e As EventArgs) Handles Button_contabilizar_credito.Click
        'contabilizar =======================================================================================
        Try
            saldo = 0
            sql = "SELECT sum(CAST(debe AS SIGNED)) as debe, sum(CAST(haber AS SIGNED)) as haber FROM cajaspuc where CODcuenta='311505'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                entran = row.Item("debe")
                salen = row.Item("haber")
                saldo = CInt(entran) - CInt(salen)
            Next
        Catch ex As Exception
            saldo = 0
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()

        PROD_SALEN = CInt(TextBox_valor_cuenta.Text)  ' TOMO LA CANTIDAD DEL GRID Q ESTA RECORRIENDO
        PROD_SALDO = saldo  ' IGUALDO SALDO PROD CON EL SALDO CALCULADO EN BODEGA PRICIPAL
        PROD_SALDO = CInt(PROD_SALDO) - CInt(PROD_SALEN) ' PROD_ENTRAN   '  ACUMULO
        PROD_ENTRAN = 0 ' POR QUE QUE ES UNA venta
        'REGISTRO EN PUC

        sql = "INSERT INTO cajaspuc(Codcuenta, cuenta, TERCERO, Fecha, Documento, TipoDoc, Rol, SaldoAnt, debe, haber, Saldo, detalle, Estado, annoactual)" &
               "VALUES ('311505','Cuotas o Partede de Interes Social','" & CStr(TXT_DOC_CLIENTE.Text & "|" & TXT_NOM_CLIENTE.Text) & "','" & DateTime.Now.ToShortDateString & "','" & consecutivo & "','CUENTA DE COBRO','SALEN'," & saldo & "," & PROD_ENTRAN & "," & PROD_SALEN & "," & PROD_SALDO & ",'" & CStr(TextBox_concepto.Text & "|" & "DOC# " & TextBox_nro_fac_credito.Text) & "','DESCARGADO','" & comex_annoactual & "')"
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

        Try
            saldo = 0
            sql = "SELECT sum(CAST(debe AS SIGNED)) as debe, sum(CAST(haber AS SIGNED)) as haber FROM cajaspuc where CODcuenta='2305'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                entran = row.Item("debe")
                salen = row.Item("haber")
                saldo = CInt(entran) - CInt(salen)
            Next
        Catch ex As Exception
            saldo = 0
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()

        PROD_SALEN = CInt(TextBox_valor_cuenta.Text)  ' TOMO LA CANTIDAD DEL GRID Q ESTA RECORRIENDO
        PROD_SALDO = saldo  ' IGUALDO SALDO PROD CON EL SALDO CALCULADO EN BODEGA PRICIPAL
        PROD_SALDO = CInt(PROD_SALDO) + CInt(PROD_SALEN) ' PROD_ENTRAN   '  ACUMULO
        PROD_ENTRAN = 0 ' POR QUE QUE ES UNA venta
        'REGISTRO EN PUC
        Dim nombre_cuenta As String = ""
        If cuenta_contable = "2305" Then nombre_cuenta = "Cuentas Corrientes Comerciales"
        If cuenta_contable = "2205" Then nombre_cuenta = "Proveedores Nacionales"

        sql = "INSERT INTO cajaspuc(Codcuenta, cuenta, TERCERO, Fecha, Documento, TipoDoc, Rol, SaldoAnt, debe, haber, Saldo, DETALLE, Estado, annoactual)" &
               "VALUES ('" & cuenta_contable & "','" & nombre_cuenta & "','" & CStr(TXT_DOC_CLIENTE.Text & "|" & TXT_NOM_CLIENTE.Text) & "','" & DateTime.Now.ToShortDateString & "','" & consecutivo & "','CUENTA DE COBRO','ENTRAN'," & saldo & "," & PROD_ENTRAN & "," & PROD_SALEN & "," & PROD_SALDO & ",'" & CStr(TextBox_concepto.Text & "|" & "REF# " & TextBox_nro_fac_credito.Text) & "','DESCARGADO','" & comex_annoactual & "')"
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
        '---------------------------------------------------------------------------------------------
    End Sub

    Private Sub Button_exportar_credito_Click(sender As Object, e As EventArgs) Handles Button_exportar_credito.Click
        Try
            sql = "SELECT Documento, Fecha, Valor, Empleado from recibos_egresos where REFERENCIA='" & TextBox_nro_cuenta.Text & "' and estado='DESCARGADO'"
            da_credito_DETALLE = New MySqlDataAdapter(sql, conex)
            dt_cREDITO_DETALLE = New DataTable
            da_credito_DETALLE.Fill(dt_cREDITO_DETALLE)
            Me.datagrid_historial_credito.DataSource = dt_cREDITO_DETALLE
        Catch ex As Exception
            MsgBox(ex.Message)
            conex.Close()
            da_credito_DETALLE.Dispose()
            dt_cREDITO_DETALLE.Dispose()
        End Try
        conex.Close()
        da_credito_DETALLE.Dispose()
        dt_cREDITO_DETALLE.Dispose()
        datagrid_historial_credito.ClearSelection()




        Try

            'Intentar generar el documento.
            Dim doc As New Document(PageSize.A4, 20, 20, 20, 20)
            If Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) & "\MiClickDerecho Docs\") = False Then
                Try
                    My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) & "\MiClickDerecho Docs\")
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
            'Path que guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\Cuenta Por Pagar" & TextBox_nro_cuenta.Text & ".pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)

            PdfWriter.GetInstance(doc, file)

            doc.Open()


            ExportarDatosPDF(doc)


            doc.Close()

            Process.Start(filename)
        Catch ex As Exception
            'Si el intento es fallido, mostrar MsgBox.
            MessageBox.Show("No se puede generar el documento PDF, Cierre los documentos PDF generados anteriormente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub ExportarDatosPDF(ByVal document As Document)
        Dim CANT_FILAS As Integer = 0
        'Se crea un objeto PDFTable con el numero de columnas del DataGridView.
        Dim datatable As New PdfPTable(datagrid_historial_credito.ColumnCount)
        'Se asignan algunas propiedades para el diseño del PDF.
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(datagrid_historial_credito)

        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER

        Dim encabezadoFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 10, iTextSharp.text.Font.BOLD)
        Dim contentFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 12, iTextSharp.text.Font.BOLD)
        Dim DIRFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 6, iTextSharp.text.Font.BOLD)
        Dim rowFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 6, iTextSharp.text.Font.BOLD)
        Dim DIRFont2 = iTextSharp.text.FontFactory.GetFont("Arial Black", 7.5, iTextSharp.text.Font.BOLD)

        Dim FIRMAFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 5, iTextSharp.text.Font.BOLD)
        Dim totalFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 8, iTextSharp.text.Font.BOLDITALIC)
        Dim totaltotalFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 9, iTextSharp.text.Font.BOLDITALIC)
        Dim CLIENTEFONT = iTextSharp.text.FontFactory.GetFont("Arial Black", 7, iTextSharp.text.Font.BOLDITALIC)


        'Se crea el encabezado en el PDF.
        Dim encabezado As New Paragraph("CUENTA DE COBRO   ", encabezadoFont)
        encabezado.Alignment = 2
        encabezado.Font = encabezadoFont
        Dim PDF_CONSECUTIVO As New Paragraph("No. " & TextBox_nro_cuenta.Text + "   ", New Font(Font.Name = "Arial Black", 9, Font.Bold = True)) : PDF_CONSECUTIVO.Alignment = 2
        Dim encabezado2 As New Paragraph("Fecha: " + Form_sales.Label_FECHA.Text + "   ", New Font(Font.Name = "Arial Balck", 9, Font.Bold)) : encabezado2.Alignment = 2

        Dim tablahome As New PdfPTable(2)
        tablahome.WidthPercentage = 100
        tablahome.DefaultCell.Padding = 0
        tablahome.DefaultCell.BorderWidth = 0
        tablahome.SpacingBefore = 3

        Dim cellhome As New PdfPCell
        cellhome.BorderWidth = 0

        cellhome.Phrase = New Phrase(" ", contentFont)
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        cellhome.Phrase = New Phrase(comex_nombrecomercial, contentFont)
        cellhome.HorizontalAlignment = Element.ALIGN_RIGHT
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase(" ", DIRFont)
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        cellhome.Phrase = New Phrase("NIT:" & comex_nit & " " & comex_regimen, DIRFont)
        cellhome.HorizontalAlignment = Element.ALIGN_RIGHT
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()


        Dim tablahome2 As New PdfPTable(3)
        tablahome2.WidthPercentage = 100
        tablahome2.DefaultCell.BorderWidth = 0

        Dim cellhome2 As New PdfPCell
        cellhome2.BorderWidth = 0

        cellhome2.Phrase = New Phrase("Cliente: " + TXT_NOM_CLIENTE.Text, CLIENTEFONT)
        cellhome2.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome2.AddCell(cellhome2)
        cellhome2.Phrase = New Phrase("DOC/NIT: " + TXT_DOC_CLIENTE.Text, CLIENTEFONT)
        cellhome2.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome2.AddCell(cellhome2)
        cellhome2.Phrase = New Phrase(comex_dircomercio + " " + comex_ciudad + Chr(13) + " Tel: " + comex_tels, DIRFont2)
        cellhome2.HorizontalAlignment = Element.ALIGN_RIGHT
        tablahome2.AddCell(cellhome2)
        tablahome2.CompleteRow()

        cellhome2.Phrase = New Phrase("Dirección:  " + TXT_DIR_CLIENTE.Text.ToString, CLIENTEFONT)
        cellhome2.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome2.AddCell(cellhome2)
        cellhome2.Phrase = New Phrase("Teléfono: " + TXT_TELS_CLIENTE.Text, CLIENTEFONT)
        cellhome2.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome2.AddCell(cellhome2)
        cellhome2.Phrase = New Phrase(" ", DIRFont2)
        cellhome2.HorizontalAlignment = Element.ALIGN_RIGHT
        tablahome2.AddCell(cellhome2)
        tablahome2.CompleteRow()

        cellhome2.Phrase = New Phrase(" ", CLIENTEFONT)
        cellhome2.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome2.AddCell(cellhome2)
        cellhome2.Phrase = New Phrase(" ", CLIENTEFONT)
        cellhome2.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome2.AddCell(cellhome2)
        cellhome2.Phrase = New Phrase(" ", DIRFont2)
        cellhome2.HorizontalAlignment = Element.ALIGN_RIGHT
        tablahome2.AddCell(cellhome2)
        tablahome2.CompleteRow()

        Dim glue = New Chunk(New VerticalPositionMark())

        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To datagrid_historial_credito.ColumnCount - 1
            Dim HEADERCELLFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 8, iTextSharp.text.Font.BOLD)

            Dim cell_TITLE As New PdfPCell
            cell_TITLE.Phrase = New Phrase(datagrid_historial_credito.Columns(i).HeaderText, HEADERCELLFont)
            cell_TITLE.HorizontalAlignment = Element.ALIGN_CENTER
            cell_TITLE.BackgroundColor = BaseColor.LIGHT_GRAY
            datatable.AddCell(cell_TITLE)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 0
        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To datagrid_historial_credito.RowCount - 1
            For j As Integer = 0 To datagrid_historial_credito.ColumnCount - 1
                Dim cell As New PdfPCell

                cell.Phrase = New Phrase(datagrid_historial_credito(j, i).FormattedValue.ToString, rowFont)

                If j = 0 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 1 Then cell.HorizontalAlignment = Element.ALIGN_CENTER
                If j = 2 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 3 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 4 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 5 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 6 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 7 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT


                cell.Border = 0
                'cell.BorderWidthRight = 0.3F
                cell.BorderColorRight = BaseColor.BLACK
                datatable.AddCell(cell)
            Next
            datatable.CompleteRow()
        Next


        '  CONTAR LAS FILAS DE LA GRILLA GENERADA, 
        ' ESTABLECER CUANTAS GRILLAS SE NECESITAN PARA LLEGAR A MEDIA CARTA Y CARTA,
        ' AGRAGAR LLASNECESARIAS PARA LLENAR EL ESPACION Q FALTA
        CANT_FILAS = Me.datagrid_historial_credito.RowCount

        If CANT_FILAS <= (16 - CANT_FILAS) Then
            For i As Integer = 0 To (16 - CANT_FILAS)
                For j As Integer = 0 To datagrid_historial_credito.ColumnCount - 1

                    Dim cell As New PdfPCell
                    cell.Phrase = New Phrase(" ", New Font(Font.Name = "Arial Narrow", 6, Font.Bold = False))
                    If j = 0 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                    If j = 1 Then cell.HorizontalAlignment = Element.ALIGN_CENTER
                    If j = 2 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                    If j = 3 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                    If j = 4 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                    If j = 5 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                    If j = 6 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                    If j = 7 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                    cell.Border = 0
                    cell.Border = 0
                    'cell.BorderWidthRight = 0.3F
                    cell.BorderColorRight = BaseColor.BLACK
                    datatable.AddCell(cell)
                Next
                datatable.CompleteRow()
            Next
        End If


        Dim tabla_PIE As New PdfPTable(6)
        tabla_PIE.WidthPercentage = 100
        tabla_PIE.DefaultCell.Padding = 0
        tabla_PIE.DefaultCell.BorderWidth = 0
        tabla_PIE.SpacingBefore = 3

        Dim cell_PIE As New PdfPCell
        cell_PIE.BorderWidth = 0

        cell_PIE.Phrase = New Phrase("Observaciones", New Font(Font.Name = "Arial Narrow", 4, Font.Bold))
        cell_PIE.HorizontalAlignment = Element.ALIGN_LEFT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase(" ", contentFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_LEFT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase(" ", contentFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_LEFT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase(" ", contentFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_LEFT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase("SubTotal", totalFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase(TextBox_valor_cuenta.Text & " ", totalFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_PIE.AddCell(cell_PIE)
        tabla_PIE.CompleteRow()

        cell_PIE.Phrase = New Phrase(" ", contentFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_LEFT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase(" ", contentFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_LEFT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase(" ", contentFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_LEFT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase(" ", contentFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_LEFT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase("Impuestos", totalFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase("", totalFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_PIE.AddCell(cell_PIE)
        tabla_PIE.CompleteRow()

        cell_PIE.Phrase = New Phrase("FIRMA CLIENTE:____________________ ", New Font(Font.Name = "Arial Narrow", 4, Font.Bold))
        cell_PIE.HorizontalAlignment = Element.ALIGN_LEFT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase("FIRMA VENDEDOR:___________________", New Font(Font.Name = "Arial Narrow", 4, Font.Bold))
        cell_PIE.HorizontalAlignment = Element.ALIGN_LEFT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase(" ", contentFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_LEFT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase(" ", contentFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_LEFT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase("Total", totalFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase(TextBox_valor_cuenta.Text, totaltotalFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_PIE.AddCell(cell_PIE)
        tabla_PIE.CompleteRow()

        cell_PIE.Phrase = New Phrase("Fecha de Impresión: " + Now.Date(), New Font(Font.Name = "Arial Narrow", 4, Font.Bold))
        cell_PIE.HorizontalAlignment = Element.ALIGN_LEFT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase("Generado Por: ", New Font(Font.Name = "Arial Narrow", 4, Font.Bold))
        cell_PIE.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase(usrnom, New Font(Font.Name = "Arial Narrow", 4, Font.Bold))
        cell_PIE.HorizontalAlignment = Element.ALIGN_LEFT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase(" ", totalFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase(" ", totalFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_PIE.AddCell(cell_PIE)
        tabla_PIE.CompleteRow()

        'LOGO
        If comex_logo <> "" Then
            Dim imagelogogopdf As iTextSharp.text.Image 'Declaracion de una imagen

            imagelogogopdf = iTextSharp.text.Image.GetInstance("c: \miclickderecho\logo.png") 'Dirreccion a la imagen que se hace referencia
            imagelogogopdf.Alignment = Element.ALIGN_RIGHT
            imagelogogopdf.SetAbsolutePosition(25, 760) 'Posicion en el eje cartesiano
            imagelogogopdf.ScaleAbsoluteWidth(200) 'Ancho de la imagen
            imagelogogopdf.ScaleAbsoluteHeight(70) 'Altura de la imagen
            document.Add(imagelogogopdf) ' Agrega la imagen al documento
        End If
        'Se agrega el PDFTable al documento.

        Dim CUADRO1 As iTextSharp.text.Image 'COMEX INFO
        CUADRO1 = iTextSharp.text.Image.GetInstance("c:\miclickderecho\marco.png") 'Dirreccion a la imagen que se hace referencia
        CUADRO1.Alignment = Element.ALIGN_RIGHT
        CUADRO1.SetAbsolutePosition(411, 775) 'Posicion en el eje cartesiano
        CUADRO1.ScaleAbsoluteWidth(168) 'Ancho de la imagen
        CUADRO1.ScaleAbsoluteHeight(44) 'Altura de la imagen
        document.Add(CUADRO1) ' Agrega la imagen al documento

        Dim CUADRO_cliente As iTextSharp.text.Image 'CLIENTE/BENEF
        CUADRO_cliente = iTextSharp.text.Image.GetInstance("c:\miclickderecho\cuadro_para_portadas2.png") 'Dirreccion a la imagen que se hace referencia
        CUADRO_cliente.Alignment = Element.ALIGN_LEFT
        CUADRO_cliente.SetAbsolutePosition(18, 697) 'Posicion en el eje cartesiano
        CUADRO_cliente.ScaleAbsoluteWidth(350) 'Ancho de la imagen
        CUADRO_cliente.ScaleAbsoluteHeight(64) 'Altura de la imagen
        document.Add(CUADRO_cliente) ' Agrega la imagen al documento

        Dim CUADRO_subtotal As iTextSharp.text.Image 'Declaracion de una imagen
        CUADRO_subtotal = iTextSharp.text.Image.GetInstance("c:\miclickderecho\square.png") 'Dirreccion a la imagen que se hace referencia
        CUADRO_subtotal.Alignment = Element.ALIGN_LEFT
        CUADRO_subtotal.SetAbsolutePosition(17.5F, 510.0F) 'Posicion en el eje cartesiano
        CUADRO_subtotal.ScaleAbsoluteWidth(563.5F) 'Ancho de la imagen
        CUADRO_subtotal.ScaleAbsoluteHeight(185) 'Altura de la imagen

        Dim CUADRO_obs As iTextSharp.text.Image 'Declaracion de una imagen
        CUADRO_obs = iTextSharp.text.Image.GetInstance("c:\miclickderecho\fondopanel.png") 'Dirreccion a la imagen que se hace referencia
        CUADRO_obs.Alignment = Element.ALIGN_LEFT
        CUADRO_obs.SetAbsolutePosition(18, 463) 'Posicion en el eje cartesiano
        CUADRO_obs.ScaleAbsoluteWidth(350) 'Ancho de la imagen
        CUADRO_obs.ScaleAbsoluteHeight(46) 'Altura de la imagen

        Dim CUADRO_total As iTextSharp.text.Image 'Declaracion de una imagen
        CUADRO_total = iTextSharp.text.Image.GetInstance("c:\miclickderecho\MARCO.png") 'Dirreccion a la imagen que se hace referencia
        CUADRO_total.Alignment = Element.ALIGN_LEFT
        CUADRO_total.SetAbsolutePosition(428, 458) 'Posicion en el eje cartesiano
        CUADRO_total.ScaleAbsoluteWidth(150) 'Ancho de la imagen
        CUADRO_total.ScaleAbsoluteHeight(50) 'Altura de la imagen


        Dim endline As iTextSharp.text.Image 'Declaracion de una imagen
        endline = iTextSharp.text.Image.GetInstance("c:\miclickderecho\endline.png") 'Dirreccion a la imagen que se hace referencia
        endline.Alignment = Element.ALIGN_CENTER
        endline.SetAbsolutePosition(18, 439) 'Posicion en el eje cartesiano
        endline.ScaleAbsoluteWidth(563.5F) 'Ancho de la imagen
        endline.ScaleAbsoluteHeight(9) 'Altura de la imagen

        document.Add(CUADRO_subtotal) ' Agrega la imagen al documento
        document.Add(encabezado)
        document.Add(PDF_CONSECUTIVO)
        document.Add(encabezado2)
        document.Add(tablahome)
        document.Add(tablahome2)
        datatable.SpacingBefore = 15
        document.Add(datatable)
        tabla_PIE.SpacingBefore = 5
        document.Add(tabla_PIE)
        document.Add(CUADRO_total)
        'document.Add(descuento)
        document.Add(CUADRO_obs)
        document.Add(endline)


    End Sub

    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        'funcion para obtener el tamaño de la columnas del datagridview
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function
    Private Sub dataGrid_credito_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGrid_credito.CellContentClick

    End Sub

    Dim entran, salen, saldo As Integer

    Private Sub Button_EDIT_CLI_Click(sender As Object, e As EventArgs) Handles Button_EDIT_CLI.Click
        If TXT_DOC_CLIENTE.Text = "1" Then
            Exit Sub
        End If

        Label_info_cliente.Visible = True
        Label_info_cliente.Text = "Registre los Datos del Cliente"

        Me.TXT_DIR_CLIENTE.BackColor = Color.WhiteSmoke
        Me.TXT_TELS_CLIENTE.BackColor = Color.WhiteSmoke
        Me.TxtMAIL_cliente.BackColor = Color.WhiteSmoke
        Me.TXT_DOC_CLIENTE.BackColor = Color.WhiteSmoke
        'Me.TXT_NOM_CLIENTE.BackColor = Color.WhiteSmoke   NO VA POR QUE ESTA EDITANDO

        COMBO_DOC_CLIENTE_FILTRO.Visible = False
        COMBO_NOM_CLIENTE_FILTRO.Visible = False

        QUE_HACE_CLIENTE = "editar"

        Button_NUEVO_CLI.Visible = False
        Button_EDIT_CLI.Visible = False
        Button_SAVE_CLI.Visible = True
    End Sub

    Private Sub Button_SAVE_CLI_Click(sender As Object, e As EventArgs) Handles Button_SAVE_CLI.Click
        Label_info_cliente.Visible = False

        If TXT_DOC_CLIENTE.Text = "" Then Exit Sub
        If TXT_NOM_CLIENTE.Text = "" Then Exit Sub


        If QUE_HACE_CLIENTE = "crear" Then
            Dim RTA As String
            RTA = MsgBox("Confirma Guardar el Cliente?." _
                & Chr(13) & Chr(13) & "Cliente:" & Me.TXT_NOM_CLIENTE.Text & Chr(13) &
                "Documento:" & Me.TXT_DOC_CLIENTE.Text & Chr(13) &
                "Teléfono:" & Me.TXT_TELS_CLIENTE.Text & Chr(13) &
                "Direccion:" & Me.TXT_DIR_CLIENTE.Text & Chr(13) &
                "Email:" & Me.TxtMAIL_cliente.Text, MsgBoxStyle.Question + MsgBoxStyle.YesNo)
            If RTA = 6 Then
                ' se guarda
                Dim DOC As String = "", dv As String = "", TIPODOC As String = "", ES_cliente As String = ""
                DOC = TXT_DOC_CLIENTE.Text
                dv = ""
                TIPODOC = "Cédula de Ciudadanía"
                ES_cliente = "SI"

                sql = "INSERT INTO proveedores(documento, TIPODOCUMENTO, nombre, telefono, direccion, email, cliente)" &
                      "VALUES ('" & DOC & "','" & CStr(TIPODOC) & "','" & CStr(Me.TXT_NOM_CLIENTE.Text) & "','" & CStr(Me.TXT_TELS_CLIENTE.Text) & "','" & CStr(Me.TXT_DIR_CLIENTE.Text) & "','" & CStr(Me.TxtMAIL_cliente.Text) & "','" & ES_cliente & "')"
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                Try
                    da.Fill(dt)
                Catch ex As Exception
                    If ex.ToString.Contains("Duplicate entry") Then MsgBox("Ese documento ya esta registrado en la lista de contactos.", vbExclamation)
                    If ex.ToString.Contains("Duplicata") Then MsgBox("Ese documento ya esta registrado en la lista de contactos.", vbExclamation)

                    'MsgBox(ex.ToString)
                End Try
                da.Dispose()
                dt.Dispose()
                conex.Close()
                Label_info_cliente.Text = "Se Guradó el Cliente."

            End If
        End If

        If QUE_HACE_CLIENTE = "editar" Then
            Dim RTA2 As String
            RTA2 = MsgBox("Confirma Modificar los datos del Cliente?." _
                    & Chr(13) & Chr(13) & "Cliente:" & Me.TXT_NOM_CLIENTE.Text & Chr(13) &
                    "Documento:" & Me.TXT_DOC_CLIENTE.Text & Chr(13) &
                    "Teléfono:" & Me.TXT_TELS_CLIENTE.Text & Chr(13) &
                    "Direccion:" & Me.TXT_DIR_CLIENTE.Text & Chr(13) &
                    "Email:" & Me.TxtMAIL_cliente.Text, MsgBoxStyle.Question + MsgBoxStyle.YesNo)
            If RTA2 = 6 Then
                ' se guarda
                Dim DOC As String = "", dv As String = "", TIPODOC As String = "", ES_cliente As String = ""
                DOC = TXT_DOC_CLIENTE.Text
                dv = ""
                TIPODOC = "Cédula de Ciudadanía"
                ES_cliente = "SI"

                sql = "update proveedores set documento='" & TXT_DOC_CLIENTE.Text & "', nombre='" & CStr(Me.TXT_NOM_CLIENTE.Text) & "', telefono='" & CStr(Me.TXT_TELS_CLIENTE.Text) & "', direccion='" & CStr(Me.TXT_DIR_CLIENTE.Text) & "', email='" & CStr(Me.TxtMAIL_cliente.Text) & "', cliente='" & ES_cliente & "' WHERE DOCUMENTO='" & TXT_DOC_CLIENTE.Text & "'"
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                Try
                    da.Fill(dt)

                Catch ex As Exception
                    If ex.ToString.Contains("Duplicate entry") Then MsgBox("Ese documento ya esta registrado en la lista de contactos.", vbExclamation)
                    If ex.ToString.Contains("Duplicata") Then MsgBox("Ese documento ya esta registrado en la lista de contactos.", vbExclamation)

                    'MsgBox(ex.ToString)
                End Try
                da.Dispose()
                dt.Dispose()
                conex.Close()
                Label_info_cliente.Text = "Se Guradó el Cliente."
            End If
        End If



        Try
            sql = "SELECT documento, nombre FROM proveedores"
            da_contact = New MySqlDataAdapter(sql, conex)
            DT_contact = New DataTable
            da_contact.Fill(DT_contact)
            Me.COMBO_NOM_CLIENTE_FILTRO.DataSource = DT_contact.DefaultView
            Me.COMBO_NOM_CLIENTE_FILTRO.DisplayMember = "nombre"
            Me.COMBO_NOM_CLIENTE_FILTRO.ValueMember = "documento"
            Me.COMBO_NOM_CLIENTE_FILTRO.AutoCompleteSource = AutoCompleteSource.ListItems
            Me.COMBO_NOM_CLIENTE_FILTRO.AutoCompleteMode = AutoCompleteMode.Suggest
            Me.COMBO_NOM_CLIENTE_FILTRO.SelectedItem = Nothing

            Me.COMBO_DOC_CLIENTE_FILTRO.DataSource = DT_contact.DefaultView
            Me.COMBO_DOC_CLIENTE_FILTRO.DisplayMember = "documento"
            Me.COMBO_DOC_CLIENTE_FILTRO.ValueMember = "documento"
            Me.COMBO_DOC_CLIENTE_FILTRO.AutoCompleteSource = AutoCompleteSource.ListItems
            Me.COMBO_DOC_CLIENTE_FILTRO.AutoCompleteMode = AutoCompleteMode.Suggest
            Me.COMBO_DOC_CLIENTE_FILTRO.SelectedItem = Nothing

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_contact.Dispose()
        DT_contact.Dispose()
        conex.Close()

        Button_SAVE_CLI.Visible = False
        Button_EDIT_CLI.Visible = True
        Button_NUEVO_CLI.Visible = True

        Me.TXT_DIR_CLIENTE.BackColor = Color.White
        Me.TXT_TELS_CLIENTE.BackColor = Color.White
        Me.TxtMAIL_cliente.BackColor = Color.White
        Me.TXT_DOC_CLIENTE.BackColor = Color.White
        Me.TXT_NOM_CLIENTE.BackColor = Color.White

        COMBO_DOC_CLIENTE_FILTRO.Visible = True
        COMBO_NOM_CLIENTE_FILTRO.Visible = True

        QUE_HACE_CLIENTE = ""

        cli_doc = TXT_DOC_CLIENTE.Text
        COMBO_DOC_CLIENTE_FILTRO.SelectedItem = cli_doc
        Timer_clientes.Enabled = True
    End Sub

    Private Sub Timer_clientes_Tick(sender As Object, e As EventArgs) Handles Timer_clientes.Tick
        cli_doc = COMBO_DOC_CLIENTE_FILTRO.Text

        Timer_clientes.Enabled = False
        Try
            sql = "SELECT * FROM proveedores where DOCUMENTO='" & CStr(cli_doc) & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt_clientes = New DataTable
            da.Fill(dt_clientes)
            cli_doc = ""
            For Each row As DataRow In dt_clientes.Rows
                cli_nom = row.Item("nombre")
                cli_doc = row.Item("DOCUMENTO")
                cli_tel = row.Item("TELEFONO")
                cli_dir = row.Item("DIRECCION")
                cli_mail = row.Item("email")
                imp_clienteDoc = cli_doc
                imp_clienteDoc = cli_nom
                imp_clienteTel = cli_tel
                ImpClienteDir = cli_dir
                imp_clientemail = cli_mail
            Next

            Me.TXT_DIR_CLIENTE.Text = cli_dir
            Me.TXT_TELS_CLIENTE.Text = cli_tel
            Me.TxtMAIL_cliente.Text = cli_mail
            Me.TXT_DOC_CLIENTE.Text = cli_doc
            Me.TXT_NOM_CLIENTE.Text = cli_nom

            If TXT_DOC_CLIENTE.Text = "1" Or TXT_DOC_CLIENTE.Text = "" Then
                Button_EDIT_CLI.Visible = False
            Else
                Button_EDIT_CLI.Visible = True
            End If

        Catch ex As Exception
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()

        COMBO_DOC_CLIENTE_FILTRO.Text = ""
        COMBO_NOM_CLIENTE_FILTRO.Text = ""
    End Sub

    Private Sub Button_REFRESH_cliente_Click(sender As Object, e As EventArgs) Handles Button_REFRESH_cliente.Click
        ''LLENADO contactos
        Try
            sql = "SELECT documento, nombre FROM proveedores"
            da_cli_cartera = New MySqlDataAdapter(sql, conex)
            dt_cli_cartera = New DataTable
            da_cli_cartera.Fill(dt_cli_cartera)
            Me.COMBO_NOM_CLIENTE_FILTRO.DataSource = dt_cli_cartera.DefaultView
            Me.COMBO_NOM_CLIENTE_FILTRO.DisplayMember = "nombre"
            Me.COMBO_NOM_CLIENTE_FILTRO.ValueMember = "documento"
            Me.COMBO_NOM_CLIENTE_FILTRO.AutoCompleteSource = AutoCompleteSource.ListItems
            Me.COMBO_NOM_CLIENTE_FILTRO.AutoCompleteMode = AutoCompleteMode.Suggest
            Me.COMBO_NOM_CLIENTE_FILTRO.SelectedItem = Nothing

            Me.COMBO_DOC_CLIENTE_FILTRO.DataSource = dt_cli_cartera.DefaultView
            Me.COMBO_DOC_CLIENTE_FILTRO.DisplayMember = "documento"
            Me.COMBO_DOC_CLIENTE_FILTRO.ValueMember = "documento"
            Me.COMBO_DOC_CLIENTE_FILTRO.AutoCompleteSource = AutoCompleteSource.ListItems
            Me.COMBO_DOC_CLIENTE_FILTRO.AutoCompleteMode = AutoCompleteMode.Suggest
            Me.COMBO_DOC_CLIENTE_FILTRO.SelectedItem = Nothing


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_cli_cartera.Dispose()
        dt_cli_cartera.Dispose()
        conex.Close()


        Me.TXT_DIR_CLIENTE.Text = ""
        Me.TXT_TELS_CLIENTE.Text = ""
        Me.TxtMAIL_cliente.Text = ""
        Me.TXT_DOC_CLIENTE.Text = ""
        Me.TXT_NOM_CLIENTE.Text = ""
        cli_dir = ""
        cli_tel = ""
        cli_mail = ""
        cli_doc = ""
        cli_nom = ""



        cli_doc = "1"
        Timer_clientes.Enabled = True


        Button_SAVE_CLI.Visible = False
        Button_EDIT_CLI.Visible = False
        Button_NUEVO_CLI.Visible = True

        Label_info_cliente.Visible = False

        COMBO_DOC_CLIENTE_FILTRO.Visible = True
        COMBO_NOM_CLIENTE_FILTRO.Visible = True
        QUE_HACE_CLIENTE = ""

    End Sub

    Private Sub COMBO_DOC_CLIENTE_FILTRO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMBO_DOC_CLIENTE_FILTRO.SelectedIndexChanged

    End Sub

    Private Sub COMBO_NOM_CLIENTE_FILTRO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMBO_NOM_CLIENTE_FILTRO.SelectedIndexChanged

    End Sub

    Private Sub Button_NUEVO_CLI_Click(sender As Object, e As EventArgs) Handles Button_NUEVO_CLI.Click
        'Form_contactos.Show()
        'Form_contactos.BringToFront()


        Label_info_cliente.Visible = True
        Label_info_cliente.Text = "Registre los Datos del Cliente"

        Me.TXT_DIR_CLIENTE.BackColor = Color.WhiteSmoke
        Me.TXT_TELS_CLIENTE.BackColor = Color.WhiteSmoke
        Me.TxtMAIL_cliente.BackColor = Color.WhiteSmoke
        Me.TXT_DOC_CLIENTE.BackColor = Color.WhiteSmoke
        Me.TXT_NOM_CLIENTE.BackColor = Color.WhiteSmoke

        Me.TXT_DIR_CLIENTE.Text = ""
        Me.TXT_TELS_CLIENTE.Text = ""
        Me.TxtMAIL_cliente.Text = ""
        Me.TXT_DOC_CLIENTE.Text = ""
        Me.TXT_NOM_CLIENTE.Text = ""
        cli_dir = ""
        cli_tel = ""
        cli_mail = ""
        cli_doc = ""
        cli_nom = ""
        COMBO_DOC_CLIENTE_FILTRO.Visible = False
        COMBO_NOM_CLIENTE_FILTRO.Visible = False

        Me.Button_SAVE_CLI.Visible = True
        Me.Button_EDIT_CLI.Visible = False
        Me.Button_NUEVO_CLI.Visible = False

        Me.TXT_DOC_CLIENTE.Focus()
        QUE_HACE_CLIENTE = "crear"
    End Sub

    Private Sub Button_ver_credito_Click(sender As Object, e As EventArgs) Handles Button_ver_credito.Click
        If COD_CREDITO = "" Then
            Exit Sub

        End If

        QUE_HACE_CREDITO = "VER"


        dataGrid_credito.Visible = False
        Panel_botones.Visible = False
        Panel_bonotes2.Visible = True
        Panel_total_cartera.Visible = False
        Label_panel_total_cartera.Visible = False

        Button_contabilizar_credito.Visible = True
        Button_exportar_credito.Visible = True
        Timer_clientes.Enabled = True

        TextBox_nro_fac_credito.Enabled = False
        TextBox_concepto.Enabled = False
        ComboBox_tipo_CuentaxPagar.Enabled = False


        Me.Label15.Visible = False
        Panel1.Visible = False

        GRID_credito_detalle()

    End Sub

    Private Sub Button_ver_buscar_fac_credito_Click(sender As Object, e As EventArgs) Handles Button_ver_buscar_fac_credito.Click
        ID_compra_VER = TextBox_nro_fac_credito.Text

        If ID_compra_VER <> "" Then
            FormPedidodeproveedor.Show()

        End If
    End Sub

    Private Sub ComboBox_tipo_CuentaxPagar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_tipo_CuentaxPagar.SelectedIndexChanged

    End Sub

    Dim cuenta_puc() As String

    Private Sub Button_buscar_Click(sender As Object, e As EventArgs) Handles Button_buscar.Click

        If RadioButton1.Checked = True Then sql = "SELECT * FROM carteracredito WHERE clientenom LIKE '%" & Me.TextBox_buscar_prov.Text.ToString & "%' order by clientenom asc"
        If RadioButton2.Checked = True Then sql = "SELECT * FROM carteracredito WHERE clientedoc='" & Me.TextBox_buscar_prov.Text.ToString & "' order by clientenom asc"

        Label_TOTAL_creditos.Text = 0

        Try
            da_credito_grid = New MySqlDataAdapter(sql, conex)
            DT_CREDITO_GRID = New DataTable
            da_credito_grid.Fill(DT_CREDITO_GRID)
            Me.dataGrid_credito.DataSource = DT_CREDITO_GRID
            Me.dataGrid_credito.Columns(0).Visible = False
            Me.dataGrid_credito.Columns(2).Visible = False
            Me.dataGrid_credito.Columns(3).Visible = False

            Me.dataGrid_credito.Columns(6).Visible = False
            Me.dataGrid_credito.Columns(7).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
            conex.Close()
            da_credito_grid.Dispose()
            DT_CREDITO_GRID.Dispose()
        End Try
        conex.Close()
        da_credito_grid.Dispose()
        DT_CREDITO_GRID.Dispose()

        dataGrid_credito.ClearSelection()

        For i As Integer = 0 To dataGrid_credito.RowCount - 1
            If dataGrid_credito.Item("ESTADO", i).Value = "PENDIENTE" Then
                Label_TOTAL_creditos.Text = CInt(Label_TOTAL_creditos.Text) + dataGrid_credito.Item("SALDO", i).Value

            End If
        Next



    End Sub

    Private Sub Button_anular_Click(sender As Object, e As EventArgs) Handles Button_anular.Click
        Select Case MessageBox.Show("Confirma la anular esta Cuenta?", "Anular CxC.", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            Case DialogResult.Yes

                sql = "dELETE from CARTERACREDITO WHERE consecutivo=" & CInt(Me.TextBox_nro_cuenta.Text) & " and tipo='CREDITO'"
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                Try
                    da.Fill(dt)
                Catch ex As Exception
                    MsgBox("error borrando ")
                End Try
                da.Dispose()
                dt.Dispose()
                conex.Close()

                Button_regresar_credito_Click(Nothing, Nothing)

                Me.Button_anular.Enabled = False
                Me.TextBox_estado.Text = "ANULADA"


                Me.Cursor = Cursors.Default
                MsgBox("Se anuló la cuenta.")

            Case DialogResult.No


        End Select
    End Sub

    Private Sub Form_credito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataGrid_credito.BringToFront()
    End Sub

    Private Sub Form_credito_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ''LLENADO contactos
        Try
            sql = "SELECT documento, nombre FROM proveedores"
            da_cli_credito = New MySqlDataAdapter(sql, conex)
            dt_cli_credito = New DataTable
            da_cli_credito.Fill(dt_cli_credito)
            Me.COMBO_NOM_CLIENTE_FILTRO.DataSource = dt_cli_credito.DefaultView
            Me.COMBO_NOM_CLIENTE_FILTRO.DisplayMember = "nombre"
            Me.COMBO_NOM_CLIENTE_FILTRO.ValueMember = "documento"
            Me.COMBO_NOM_CLIENTE_FILTRO.AutoCompleteSource = AutoCompleteSource.ListItems
            Me.COMBO_NOM_CLIENTE_FILTRO.AutoCompleteMode = AutoCompleteMode.Suggest
            Me.COMBO_NOM_CLIENTE_FILTRO.SelectedItem = Nothing

            Me.COMBO_DOC_CLIENTE_FILTRO.DataSource = dt_cli_credito.DefaultView
            Me.COMBO_DOC_CLIENTE_FILTRO.DisplayMember = "documento"
            Me.COMBO_DOC_CLIENTE_FILTRO.ValueMember = "documento"
            Me.COMBO_DOC_CLIENTE_FILTRO.AutoCompleteSource = AutoCompleteSource.ListItems
            Me.COMBO_DOC_CLIENTE_FILTRO.AutoCompleteMode = AutoCompleteMode.Suggest
            Me.COMBO_DOC_CLIENTE_FILTRO.SelectedItem = Nothing

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_cli_credito.Dispose()
        dt_cli_credito.Dispose()
        conex.Close()

        GRID_credito()

    End Sub

    Private Sub GRID_credito()
        Label_TOTAL_creditos.Text = 0

        Try
            sql = "SELECT * from carteracredito where tipo='CREDITO'"
            da_credito_grid = New MySqlDataAdapter(sql, conex)
            DT_CREDITO_GRID = New DataTable
            da_credito_grid.Fill(DT_CREDITO_GRID)
            Me.dataGrid_credito.DataSource = DT_CREDITO_GRID
            Me.dataGrid_credito.Columns(0).Visible = False
            Me.dataGrid_credito.Columns(2).Visible = False
            Me.dataGrid_credito.Columns(3).Visible = False

            'Me.dataGrid_credito.Columns(6).Visible = False
            'Me.dataGrid_credito.Columns(7).Visible = False
            Me.dataGrid_credito.Columns(8).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
            conex.Close()
            da_credito_grid.Dispose()
            DT_CREDITO_GRID.Dispose()
        End Try
        conex.Close()
        da_credito_grid.Dispose()
        DT_CREDITO_GRID.Dispose()

        dataGrid_credito.ClearSelection()

        For i As Integer = 0 To dataGrid_credito.RowCount - 1
            If dataGrid_credito.Item("ESTADO", i).Value = "PENDIENTE" Then
                Label_TOTAL_creditos.Text = CInt(Label_TOTAL_creditos.Text) + dataGrid_credito.Item("SALDO", i).Value

            End If
        Next
    End Sub

    Private Sub GRID_credito_detalle()
        TextBox_abonos.Text = 0

        Try
            sql = "SELECT * from recibos_egresos where REFERENCIA='" & TextBox_nro_cuenta.Text & "' and concepto='Cuenta Por Pagar' and estado='DESCARGADO'"
            da_credito_DETALLE = New MySqlDataAdapter(sql, conex)
            dt_cREDITO_DETALLE = New DataTable
            da_credito_DETALLE.Fill(dt_cREDITO_DETALLE)
            Me.datagrid_historial_credito.DataSource = dt_cREDITO_DETALLE
            Me.datagrid_historial_credito.Columns(0).Visible = False
            Me.datagrid_historial_credito.Columns(1).HeaderText = "Comprobante"

            Me.datagrid_historial_credito.Columns(3).Visible = False
            Me.datagrid_historial_credito.Columns(4).Visible = False
            Me.datagrid_historial_credito.Columns(5).Visible = False
            Me.datagrid_historial_credito.Columns(6).Visible = False
            Me.datagrid_historial_credito.Columns(7).Visible = False
            Me.datagrid_historial_credito.Columns(8).Visible = False
            Me.datagrid_historial_credito.Columns(9).Visible = False
            Me.datagrid_historial_credito.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            Me.datagrid_historial_credito.Columns(11).Visible = False
            Me.datagrid_historial_credito.Columns(12).Visible = False
            Me.datagrid_historial_credito.Columns(13).Visible = False
            Me.datagrid_historial_credito.Columns(14).Visible = False
            Me.datagrid_historial_credito.Columns(15).Visible = False
            Me.datagrid_historial_credito.Columns(16).Visible = False
            Me.datagrid_historial_credito.Columns(17).Visible = False
            Me.datagrid_historial_credito.Columns(18).Visible = False
            Me.datagrid_historial_credito.Columns(19).Visible = False
            Me.datagrid_historial_credito.Columns(20).Visible = False
            Me.datagrid_historial_credito.Columns(21).Visible = False
            Me.datagrid_historial_credito.Columns(22).Visible = False
            Me.datagrid_historial_credito.Columns(23).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
            conex.Close()
            da_credito_DETALLE.Dispose()
            dt_cREDITO_DETALLE.Dispose()
        End Try
        For i As Integer = 0 To datagrid_historial_credito.RowCount - 1
            TextBox_abonos.Text = CInt(TextBox_abonos.Text) + datagrid_historial_credito.Item("VALOR", i).Value
        Next
        TextBox_saldo.Text = CInt(TextBox_valor_cuenta.Text) - CInt(TextBox_abonos.Text)
        conex.Close()
        da_credito_DETALLE.Dispose()
        dt_cREDITO_DETALLE.Dispose()

        datagrid_historial_credito.ClearSelection()

    End Sub

    Private Sub dataGrid_credito_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGrid_credito.CellClick
        Dim row As DataGridViewRow = dataGrid_credito.CurrentRow
        COD_CREDITO = CStr(row.Cells("cons").Value)

        TextBox_nro_cuenta.Text = CStr(row.Cells("CONSECUTIVO").Value)
        TextBox_fecha.Text = CStr(row.Cells("FECHA").Value)

        TextBox_nro_fac_credito.Text = CStr(row.Cells("DOCUMENTO").Value)
        If CStr(row.Cells("DOCUMENTO").Value) = "" Then
            Label17.Visible = False
            TextBox_nro_fac_credito.Visible = False
            Button_ver_buscar_fac_credito.Visible = False
        Else
            Label17.Visible = True
            TextBox_nro_fac_credito.Visible = True
            Button_ver_buscar_fac_credito.Visible = True
        End If

        Label_empleado.Text = CStr(row.Cells("responsable").Value)

        TextBox_vencimiento.Text = CStr(row.Cells("VENCIMIENTO").Value)
        TextBox_concepto.Text = CStr(row.Cells("CONCEPTO").Value)
        TextBox_valor_cuenta.Text = CStr(row.Cells("VALOR").Value)
        TextBox_saldo.Text = CStr(row.Cells("SALDO").Value)

        COMBO_DOC_CLIENTE_FILTRO.Text = CStr(row.Cells("CLIENTEDOC").Value)



        'CONTINUAR
    End Sub

    Private Sub COMBO_NOM_CLIENTE_FILTRO_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles COMBO_NOM_CLIENTE_FILTRO.SelectionChangeCommitted
        cli_nom = COMBO_NOM_CLIENTE_FILTRO.Text
        cli_doc = COMBO_NOM_CLIENTE_FILTRO.SelectedValue.ToString

        Timer_clientes.Enabled = True
    End Sub

    Private Sub COMBO_DOC_CLIENTE_FILTRO_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles COMBO_DOC_CLIENTE_FILTRO.SelectionChangeCommitted
        Timer_clientes.Enabled = True

    End Sub

    Private Sub ComboBox_tipo_CuentaxPagar_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_tipo_CuentaxPagar.SelectionChangeCommitted

    End Sub
End Class