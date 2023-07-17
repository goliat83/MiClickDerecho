Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.draw

Public Class Form_verfactura
    Dim NRO_FACTURA As String = ""
    Dim PROD_SALDO, PROD_ENTRAN, PROD_SALEN As Integer
    Dim prod_cons, prod_cod, prod_barras, prod_nom, prod_desc, PROD_VALOR_UNITARIO_BASE, prod_valor, prod_valor2, prod_valor3, PROD_CATEGORIA, prod_iva, prod_iva2, PROD_IVATIPO, PROD_IVATIPO2, prod_iva1nom, prod_iva2nom, prod_base, PROD_IVA_VR, PROD_IVA_VR2, prod_stock, prod_imagen, PROD_INVENTARIADO, PROD_COSTO, prod_decimal As String
    Dim entran, salen, saldo As Integer
    Dim MEDIO_PAGO_DESTINO_COD, MEDIO_PAGO_DESTINO_NOMBRE, MEDIO_PAGO_DESTINO_TIPO As String
    Dim medio_de_pago As String
    Dim cli_nom, cli_tel, cli_dir, cli_doc, cli_dv, cli_mail As String
    Dim CODCUENTAPUC, CODCUENTAPUCNOMBRE As String

    Public da_pos As New MySqlDataAdapter
    Public dt_pos As DataTable
    Public da_imp As New MySqlDataAdapter
    Public dt_imp As DataTable
    Dim alto_pag As Integer = 0

    Public da_contact_fitro_facver As New MySqlDataAdapter
    Public dT_contact_fitro_facver As New DataTable

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub TEXTBOX_BUSCAR_PROV_OnValueChanged(sender As Object, e As EventArgs) Handles TEXTBOX_BUSCAR_PROV.OnValueChanged

    End Sub

    Public da_dctos_venta As New MySqlDataAdapter

    Private Sub Button_EDIT_CLI_Click_1(sender As Object, e As EventArgs) Handles Button_EDIT_CLI.Click
        Button_EDIT_CLI.Visible = False

        Label23.Visible = True
        TEXTBOX_BUSCAR_PROV.Visible = True
        PictureBox1.Visible = True
        COMBO_NOM_CLIENTE_FILTRO.Visible = True
    End Sub

    Private Sub COMBO_NOM_CLIENTE_FILTRO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMBO_NOM_CLIENTE_FILTRO.SelectedIndexChanged

    End Sub

    Public dt_dctos_venta As New DataTable



    Private Sub TXT_DOC_CLIENTE_OnValueChanged(sender As Object, e As EventArgs) Handles TXT_DOC_CLIENTE.OnValueChanged
        If TXT_DOC_CLIENTE.Text = "" Then
            TextBox_dv_cliente.Text = ""
            Exit Sub
        End If

        If TXT_DOC_CLIENTE.Text <> "" Then

            Dim NIT As String = TXT_DOC_CLIENTE.Text
            Dim TEMP As String = ""
            Dim RESIDUO As Integer = 0
            Dim ACUMULADOR As Integer = 0
            Dim VECTOR(15) As Integer

            VECTOR(0) = 3
            VECTOR(1) = 7
            VECTOR(2) = 13
            VECTOR(3) = 17
            VECTOR(4) = 19
            VECTOR(5) = 23
            VECTOR(6) = 29
            VECTOR(7) = 37
            VECTOR(8) = 41
            VECTOR(9) = 43
            VECTOR(10) = 47
            VECTOR(11) = 53
            VECTOR(12) = 59
            VECTOR(13) = 67
            VECTOR(14) = 71

            For CONTADOR As Integer = 0 To CInt(NIT.Length)
                If CONTADOR = CInt(NIT.Length) Then
                    Exit For
                End If
                TEMP = NIT((NIT.Length - 1) - CONTADOR).ToString()
                ACUMULADOR = ACUMULADOR + (Convert.ToInt32(TEMP) * VECTOR(CONTADOR))
            Next
            RESIDUO = ACUMULADOR Mod 11
            TextBox_dv_cliente.Text = RESIDUO

            If RESIDUO > 1 Then
                TextBox_dv_cliente.Text = Convert.ToString(11 - RESIDUO)
            End If
        End If
    End Sub

    Private Sub Button_elim_cliente_Click(sender As Object, e As EventArgs) Handles Button_elim_cliente.Click
        Me.TXT_DIR_CLIENTE.Text = ""
        Me.TXT_TELS_CLIENTE.Text = ""
        Me.TXT_DOC_CLIENTE.Text = ""
        Me.TextBox_dv_cliente.Text = ""
        Me.TXT_NOM_CLIENTE.Text = ""
        Me.txt_mail_cliente.Text = ""


        cli_dir = ""
        cli_tel = ""
        cli_mail = ""
        cli_doc = ""
        cli_nom = ""
        cli_dv = ""

        cli_doc = ""


        sql = "UPDATE ventas SET doccliente='', clientenom='' WHERE DOCUMENTO=" & CInt(Label_consecutivo.Text) & ""
        da = New MySqlDataAdapter(sql, conex)
        dt = New DataTable
        Try
            da.Fill(dt)
            'MsgBox("Tarifa Actualizada.   :).", vbInformation)
        Catch ex As Exception
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()
    End Sub

    Private Sub TXT_NOM_CLIENTE_OnValueChanged(sender As Object, e As EventArgs) Handles TXT_NOM_CLIENTE.OnValueChanged

    End Sub

    Private Sub MetroGrid_dctos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid_dctos.CellContentClick

    End Sub

    Private Sub TXT_TELS_CLIENTE_OnValueChanged(sender As Object, e As EventArgs) Handles TXT_TELS_CLIENTE.OnValueChanged

    End Sub

    Private Sub Button_EDIT_CLI_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TXT_DIR_CLIENTE_OnValueChanged(sender As Object, e As EventArgs) Handles TXT_DIR_CLIENTE.OnValueChanged

    End Sub

    Dim inv_prod_cta_vender, inv_prod_cuenta_inventariar, inv_prod_cuenta_costear, inv_prod_cuenta_devolver As String

    Private Sub Button_devs_Click(sender As Object, e As EventArgs) Handles Button_devs.Click
        Form_devoluciones.Show()
        Me.Close()

    End Sub

    Private Sub txt_mail_cliente_OnValueChanged(sender As Object, e As EventArgs) Handles txt_mail_cliente.OnValueChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub datagrid_detalleProds_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub



    Private Sub Label15_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_ANULAR.Click

        Select Case MessageBox.Show("Confirma la anulación de la factura?", "Anular Factura.", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            Case DialogResult.Yes
                sql = "UPDATE ventas SET estado='ANULADA' WHERE DOCUMENTO=" & CInt(ID_VENTA_VER) & ""
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                Try
                    da.Fill(dt)
                    'MsgBox("Tarifa Actualizada.   :).", vbInformation)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                da.Dispose()
                dt.Dispose()
                conex.Close()

                'CAJA PUC
                sql = "DELETE FROM CAJASPUC WHERE DOCUMENTO=" & CInt(Label_consecutivo.Text) & " and tipodoc='FACTURA DE VENTA'"
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

                'CAJA EMPLEADO
                sql = "UPDATE CAJA SET ESTADO='ANULADO' WHERE DOCUMENTO=" & CInt(Label_consecutivo.Text) & " and tipodocumento='VENTA'"
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

                sql = "UPDATE VENTAS_prods SET ESTADO='ANULADO' WHERE DOCUMENTO=" & CInt(Me.Label_consecutivo.Text) & ""
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

                Me.Button_ANULAR.Enabled = False
                Me.Label_estado_movimiento.Text = "ANULADA"

                '  REGRESO A bodega    =============================================
                Me.Cursor = Cursors.WaitCursor
                Try
                    For J As Integer = 0 To Me.datagrid_detalleProds.RowCount - 1
                        prod_decimal = datagrid_detalleProds.Item("DECI", J).Value

                        Dim saldo As String
                        'saldo                 (solo se descargan de inventario los productos)  
                        Try
                            saldo = 0
                            sql = "SELECT sum(entran) as entran, sum(salen) as salen, (sum(entran) - sum(salen)) as saldo FROM bodega_" & comex_bodega_ventas & " where CodProdUCTO =" & CInt(datagrid_detalleProds.Item("CodProd", J).Value) & ""
                            If prod_decimal = "SI" Then sql = "SELECT sum(CAST(CONVERT(REPLACE(CAST(entran AS CHAR),',','.'),decimal(12,2)) AS DECIMAL(12,2)))-sum(CAST(CONVERT(REPLACE(CAST(SALEN AS CHAR),',','.'),decimal(12,2)) AS DECIMAL(12,2))) AS SALDO FROM bodega_principaL where CodProdUCTO =" & CInt(datagrid_detalleProds.Item("CodProd", J).Value) & ""
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

                        PROD_ENTRAN = Me.datagrid_detalleProds.Item("cantidad", J).Value  ' TOMO LA CANTIDAD DEL GRID Q ESTA RECORRIENDO
                        PROD_SALDO = saldo  ' IGUALDO SALDO PROD CON EL SALDO CALCULADO EN BODEGA PRICIPAL
                        If prod_decimal = "NO" Then PROD_SALDO = CInt(PROD_SALDO) + CInt(PROD_ENTRAN)   '  ACUMULO
                        If prod_decimal = "SI" Then PROD_SALDO = CDec(PROD_SALDO) + CDec(PROD_ENTRAN)   '  ACUMULO
                        PROD_SALEN = 0 ' POR QUE QUE ES UNA COMPRA
                        Dim rol As String = ""
                        rol = "SALEN"

                        sql = "INSERT INTO bodega_" & comex_bodega_ventas & " (fecha, CodBodega, NomBodega, TipoDocumento, Documento, Rol, CodProducto, Producto, Entran, Salen, Saldo, valoru, valortotal, Empleado, Estado)" &
                        "VALUES ('" & DateTime.Now.ToShortDateString & "',1,'PRINCIPAL','ANULACION VENTA'," & CInt(Me.Label_consecutivo.Text) & ",'SALEN'," & CInt(Me.datagrid_detalleProds.Item("CODPROD", J).Value) & ",'" & CStr(Me.datagrid_detalleProds.Item("PRODUCTO", J).Value) & "','" & PROD_ENTRAN & "','0','" & PROD_SALDO & "'," & CLng(Me.datagrid_detalleProds.Item("valoru", J).Value) & "," & (Me.datagrid_detalleProds.Item("valortotal", J).Value) & ",'" & usrnom & "','DESCARGADO')"
                        da = New MySqlDataAdapter(sql, conex)
                        dt = New DataTable
                        Try
                            da.Fill(dt)
                        Catch ex As Exception
                            If ex.ToString.Contains("Duplicate entry") Then MsgBox("Error al INSERTAR EN KARDEX DE BODEGA", vbExclamation)
                            MsgBox(ex.ToString)
                        End Try
                        da.Dispose()
                        dt.Dispose()
                        conex.Close()
                    Next
                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try
                Me.Cursor = Cursors.Default


            Case DialogResult.No

        End Select


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer_gridProds_Tick(sender As Object, e As EventArgs) Handles Timer_gridProds.Tick
        Me.Timer_gridProds.Enabled = False
        grid_VENTAsprods()
        datagrid_detalleProds.ClearSelection()
        Me.datagrid_detalleProds.Columns(3).Width = 240
        Me.datagrid_detalleProds.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        'Me.datagrid_detalleProds.Columns(4).Width = 40
        'Me.datagrid_detalleProds.Columns(5).Width = 50
        'Me.datagrid_detalleProds.Columns(6).Width = 50
        'Me.datagrid_detalleProds.Columns(7).Width = 50

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Form_verfactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub ExportarDatosPDF_POS(ByVal document As Document)


        Dim fontLINE = iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLD)
        Dim encabezadoFont = iTextSharp.text.FontFactory.GetFont("Courier New", 10, iTextSharp.text.Font.BOLD)
        Dim contentFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 10, iTextSharp.text.Font.BOLD)
        Dim DIRFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 6, iTextSharp.text.Font.BOLD)
        Dim rowFont = iTextSharp.text.FontFactory.GetFont("Times New Roman", 7, iTextSharp.text.Font.NORMAL)
        Dim DIRFont2 = iTextSharp.text.FontFactory.GetFont("Arial Black", 7.5, iTextSharp.text.Font.BOLD)
        Dim DIRFont9 = iTextSharp.text.FontFactory.GetFont("Arial Black", 9.5D, iTextSharp.text.Font.NORMAL)
        Dim FIRMAFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 5, iTextSharp.text.Font.BOLD)
        Dim totalFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 8, iTextSharp.text.Font.BOLD)
        Dim totaltotalFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 9, iTextSharp.text.Font.BOLDITALIC)
        Dim CLIENTEFONT = iTextSharp.text.FontFactory.GetFont("Arial Black", 7, iTextSharp.text.Font.BOLDITALIC)

        If comex_logo <> "" And File.Exists(comex_logo) Then
            Dim imagelogogopdf As iTextSharp.text.Image 'Declaracion de una imagen

            imagelogogopdf = iTextSharp.text.Image.GetInstance(comex_logo) 'Dirreccion a la imagen que se hace referencia
            imagelogogopdf.Alignment = Element.ALIGN_CENTER
            imagelogogopdf.SetAbsolutePosition(20, alto_pag - 60) 'Posicion en el eje cartesiano
            imagelogogopdf.ScaleAbsoluteWidth(160) 'Ancho de la imagen
            imagelogogopdf.ScaleAbsoluteHeight(60) 'Altura de la imagen
            document.Add(imagelogogopdf) ' Agrega la imagen al documento
        End If

        Dim encabezadoLINE As New Paragraph("|=======================================|", fontLINE)

        encabezadoLINE.Alignment = 0
        encabezadoLINE.Font = fontLINE
        If comex_logo <> "" Then encabezadoLINE.SpacingBefore = 60
        Dim encabezadoLINE2 As New Paragraph("========================================", fontLINE)
        Dim encabezadoLINE3 As New Paragraph("__________________________________________", fontLINE)

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

        If comex_sitioweb <> "" And comex_email <> "" Then
            cellhome.Phrase = New Phrase(comex_sitioweb & " " & comex_email, FontFactory.GetFont(FontFactory.COURIER_BOLD, 7.5D, iTextSharp.text.Font.NORMAL))
            cellhome.HorizontalAlignment = Element.ALIGN_CENTER
            tablahome.AddCell(cellhome)
            tablahome.CompleteRow()
        End If


        Dim PDF_leyedian1 As New Paragraph("RANGO DE FACTURACION DEL  " & comex_prefijo & "-" & comex_intervalo & " AL " & comex_prefijo & "-" & comex_intervalo2, FontFactory.GetFont(FontFactory.COURIER, 6.5, iTextSharp.text.Font.BOLD)) : PDF_leyedian1.Alignment = Element.ALIGN_CENTER
        Dim PDF_leyedian2 As New Paragraph("RESOLUCION " & comex_Resdian & " del " & comex_fechadian & Chr(13), FontFactory.GetFont(FontFactory.COURIER, 6.5, iTextSharp.text.Font.BOLD)) : PDF_leyedian2.Alignment = Element.ALIGN_CENTER



        Dim tabla_turno_data As New PdfPTable(2)
        Dim anchos() As Single = {60, 40}
        tabla_turno_data.SetWidths(anchos)

        tabla_turno_data.WidthPercentage = 100
        tabla_turno_data.DefaultCell.Padding = 0
        tabla_turno_data.DefaultCell.BorderWidth = 0
        tabla_turno_data.SpacingBefore = 0
        tabla_turno_data.HorizontalAlignment = 0
        Dim cellturno As New PdfPCell
        cellturno.BorderWidth = 0

        cellturno.Phrase = New Phrase("Factura de Venta", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_LEFT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(comex_prefijo & "-" & Label_consecutivo.Text, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("Fecha:" & Label_fecha.Text, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 7, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_LEFT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase("Hora:", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 7, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        If Label_estado_movimiento.Text = "ANULADA" Then
            cellturno.Phrase = New Phrase("****** A N U L A D A ******", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 7, iTextSharp.text.Font.NORMAL))
            cellturno.HorizontalAlignment = Element.ALIGN_CENTER
            cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
            cellturno.Colspan = 2
            tabla_turno_data.AddCell(cellturno) 'primera col
            tabla_turno_data.CompleteRow() ' agrega linea
        End If

        Dim encabezado6 As New Paragraph("Cliente:" & TXT_NOM_CLIENTE.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 7.5D, iTextSharp.text.Font.NORMAL)) : encabezado6.Alignment = Element.ALIGN_LEFT
        Dim encabezado_resumenOP As New Paragraph("Doc/NIT:" & TXT_DOC_CLIENTE.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 7.5D, iTextSharp.text.Font.NORMAL)) : encabezado_resumenOP.Alignment = Element.ALIGN_LEFT



        Dim encabezado9 As New Paragraph("Código  |  Producto         ", FontFactory.GetFont(FontFactory.COURIER_BOLD, 6D, iTextSharp.text.Font.BOLD)) : encabezado9.Alignment = Element.ALIGN_LEFT
        Dim encabezado91 As New Paragraph("xCant   |  Precio              |$ Total", FontFactory.GetFont(FontFactory.COURIER_BOLD, 6D, iTextSharp.text.Font.BOLD)) : encabezado91.Alignment = Element.ALIGN_LEFT


        Dim datatable_detventas As New PdfPTable(MetroGrid_det_ventas.ColumnCount)
        'Se asignan algunas propiedades para el diseño del PDF.
        datatable_detventas.DefaultCell.Padding = 3
        Dim headerwidthsimp As Single() = GetColumnasSize(MetroGrid_det_ventas)
        datatable_detventas.SetWidths(headerwidthsimp)
        datatable_detventas.WidthPercentage = 100
        datatable_detventas.DefaultCell.BorderWidth = 0
        datatable_detventas.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER


        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To MetroGrid_det_ventas.RowCount - 1
            For j As Integer = 0 To MetroGrid_det_ventas.ColumnCount - 1
                Dim cell As New PdfPCell
                cell.Phrase = New Phrase(MetroGrid_det_ventas(j, i).FormattedValue.ToString, FontFactory.GetFont(FontFactory.COURIER_BOLD, 7.5D, iTextSharp.text.Font.NORMAL))
                If j = 0 Then cell.HorizontalAlignment = Element.ALIGN_LEFT : cell.Colspan = 1 : cell.Rowspan = 1
                If j = 1 Then cell.HorizontalAlignment = Element.ALIGN_LEFT : cell.Colspan = 5 : cell.Rowspan = 1
                If j = 2 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT : cell.Colspan = 1 : cell.Rowspan = 2
                If j = 3 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT : cell.Colspan = 2 : cell.Rowspan = 2
                If j = 4 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT : cell.Colspan = 2 : cell.Rowspan = 2
                If j = 5 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 6 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 7 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                cell.Border = 0
                If j = 2 Then cell.BorderWidthBottom = 0.2F
                If j = 2 Then cell.BorderColorRight = BaseColor.BLACK
                If j = 3 Then cell.BorderWidthBottom = 0.2F
                If j = 3 Then cell.BorderColorRight = BaseColor.BLACK
                If j = 4 Then cell.BorderWidthBottom = 0.2F
                If j = 4 Then cell.BorderColorRight = BaseColor.BLACK
                datatable_detventas.AddCell(cell)
            Next
            datatable_detventas.CompleteRow()
        Next

        Dim tabla_total As New PdfPTable(2)
        Dim anchostotal() As Single = {65, 35}
        tabla_total.SetWidths(anchostotal)

        tabla_total.WidthPercentage = 100
        tabla_total.DefaultCell.Padding = 0
        tabla_total.DefaultCell.BorderWidth = 0
        tabla_total.SpacingBefore = 0
        tabla_total.HorizontalAlignment = 0
        Dim celltotal As New PdfPCell
        celltotal.BorderWidth = 0

        celltotal.Phrase = New Phrase("SubTotal ---------> $", FontFactory.GetFont(FontFactory.COURIER_BOLD, 8, iTextSharp.text.Font.NORMAL))
        celltotal.HorizontalAlignment = Element.ALIGN_LEFT
        celltotal.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_total.AddCell(celltotal) 'primera col

        celltotal.Phrase = New Phrase(TextBox_TOTALVENTA.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        celltotal.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_total.AddCell(celltotal) ' segunda col
        tabla_total.CompleteRow() ' agrega linea

        celltotal.Phrase = New Phrase("Descuentos -------> $", FontFactory.GetFont(FontFactory.COURIER_BOLD, 8, iTextSharp.text.Font.NORMAL))
        celltotal.HorizontalAlignment = Element.ALIGN_LEFT
        celltotal.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_total.AddCell(celltotal) 'primera col

        celltotal.Phrase = New Phrase(TextBox_DESCUENTO.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        celltotal.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_total.AddCell(celltotal) ' segunda col
        tabla_total.CompleteRow() ' agrega linea

        celltotal.Phrase = New Phrase("Serv. Vol. -------> $", FontFactory.GetFont(FontFactory.COURIER_BOLD, 8, iTextSharp.text.Font.NORMAL))
        celltotal.HorizontalAlignment = Element.ALIGN_LEFT
        celltotal.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_total.AddCell(celltotal) 'primera col

        celltotal.Phrase = New Phrase(TextBox_propina.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        celltotal.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_total.AddCell(celltotal) ' segunda col
        tabla_total.CompleteRow() ' agrega linea

        celltotal.Phrase = New Phrase("Domicilio --------> $", FontFactory.GetFont(FontFactory.COURIER_BOLD, 8, iTextSharp.text.Font.NORMAL))
        celltotal.HorizontalAlignment = Element.ALIGN_LEFT
        celltotal.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_total.AddCell(celltotal) 'primera col

        celltotal.Phrase = New Phrase(TextBox_domiciliovr.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        celltotal.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_total.AddCell(celltotal) ' segunda col
        tabla_total.CompleteRow() ' agrega linea

        celltotal.Phrase = New Phrase("TOTAL A PAGAR>>>> $", FontFactory.GetFont(FontFactory.COURIER_BOLD, 10, iTextSharp.text.Font.NORMAL))
        celltotal.HorizontalAlignment = Element.ALIGN_LEFT
        celltotal.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_total.AddCell(celltotal) 'primera col

        celltotal.Phrase = New Phrase(TextBox_TOTALVENTA.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 10, iTextSharp.text.Font.NORMAL))
        celltotal.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_total.AddCell(celltotal) ' segunda col
        tabla_total.CompleteRow() ' agrega linea

        Dim encabezado_ttal_pago As New Paragraph(ComboBox_MEDIO_PAGO.Text & ":" & Label27.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 7D, iTextSharp.text.Font.NORMAL)) : encabezado_ttal_pago.Alignment = Element.ALIGN_RIGHT
        Dim encabezado_ttal_cambio As New Paragraph("Cambio:   $" & Label30.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 7D, iTextSharp.text.Font.NORMAL)) : encabezado_ttal_cambio.Alignment = Element.ALIGN_RIGHT

        Dim encabezado8 As New Paragraph("Detalle de Impuestos", FontFactory.GetFont(FontFactory.COURIER_BOLD, 7D, iTextSharp.text.Font.NORMAL)) : encabezado8.Alignment = Element.ALIGN_LEFT


        Dim datatable_imp As New PdfPTable(MetroGrid_imp.ColumnCount)
        'Se asignan algunas propiedades para el diseño del PDF.
        datatable_imp.DefaultCell.Padding = 3
        Dim headerwidthsimp2 As Single() = GetColumnasSize(MetroGrid_imp)
        datatable_imp.SetWidths(headerwidthsimp2)
        datatable_imp.WidthPercentage = 100
        datatable_imp.DefaultCell.BorderWidth = 0
        datatable_imp.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER



        For i As Integer = 0 To MetroGrid_imp.ColumnCount - 1
            Dim HEADERCELLFont = FontFactory.GetFont(FontFactory.COURIER_BOLD, 7.5D, iTextSharp.text.Font.NORMAL)

            Dim cell_TITLE As New PdfPCell
            cell_TITLE.Phrase = New Phrase(MetroGrid_imp.Columns(i).HeaderText, HEADERCELLFont)
            cell_TITLE.HorizontalAlignment = Element.ALIGN_CENTER
            cell_TITLE.BackgroundColor = BaseColor.LIGHT_GRAY
            cell_TITLE.Border = 0

            datatable_imp.AddCell(cell_TITLE)
        Next
        datatable_imp.HeaderRows = 1
        datatable_imp.DefaultCell.BorderWidth = 0
        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To MetroGrid_imp.RowCount - 1
            For j As Integer = 0 To MetroGrid_imp.ColumnCount - 1
                Dim cell As New PdfPCell
                cell.Phrase = New Phrase(MetroGrid_imp(j, i).FormattedValue.ToString, FontFactory.GetFont(FontFactory.COURIER_BOLD, 7.5D, iTextSharp.text.Font.NORMAL))
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
                datatable_imp.AddCell(cell)
            Next
            datatable_imp.CompleteRow()
        Next


        Dim encabezado_Observ As New Paragraph("Observaciones:" & TextBox1.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 6D, iTextSharp.text.Font.NORMAL)) : encabezado_Observ.Alignment = Element.ALIGN_LEFT
        Dim encabezado_mesa As New Paragraph("Mesa:" & Label_mesa.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 6D, iTextSharp.text.Font.NORMAL)) : encabezado_mesa.Alignment = Element.ALIGN_LEFT

        Dim encabezado_mesero As New Paragraph("Le Atendió:" & ComboBox_MESERO.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 6D, iTextSharp.text.Font.NORMAL)) : encabezado_mesero.Alignment = Element.ALIGN_LEFT

        Dim encabezado_caja As New Paragraph("Cajero:" & Label_empleado.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 6D, iTextSharp.text.Font.NORMAL)) : encabezado_caja.Alignment = Element.ALIGN_LEFT

        Dim encabezado7 As New Paragraph("Se Imprimió el " + DateTime.Now + Chr(13) + "Por: " + usrnom, FontFactory.GetFont(FontFactory.COURIER_BOLD, 5D, iTextSharp.text.Font.NORMAL)) : encabezado7.Alignment = 0
        Dim encabezado_publicidad As New Paragraph("MiCliCkDerecho.com Sistemas POS 3165259554.", FontFactory.GetFont(FontFactory.COURIER_BOLD, 5D, iTextSharp.text.Font.NORMAL)) : encabezado7.Alignment = 0

        Dim encabezado_domicilio_data As New Paragraph("Entrega Domicilio:", FontFactory.GetFont(FontFactory.COURIER_BOLD, 6D, iTextSharp.text.Font.NORMAL)) : encabezado8.Alignment = Element.ALIGN_LEFT
        Dim encabezado_domicilio_MESAJERO As New Paragraph("Mensajero:", FontFactory.GetFont(FontFactory.COURIER_BOLD, 6D, iTextSharp.text.Font.NORMAL)) : encabezado_domicilio_MESAJERO.Alignment = Element.ALIGN_LEFT

        Dim glue = New Chunk(New VerticalPositionMark())

        document.Add(encabezadoLINE)
        document.Add(tablahome)
        document.Add(PDF_leyedian1)
        document.Add(PDF_leyedian2)
        encabezadoLINE2.SpacingBefore = -3
        document.Add(encabezadoLINE2)

        tabla_turno_data.SpacingBefore = 0
        document.Add(tabla_turno_data)

        document.Add(encabezado6)
        document.Add(encabezado_resumenOP)
        encabezado_resumenOP.SpacingBefore = -3

        document.Add(encabezado9)
        document.Add(encabezado91)
        encabezadoLINE3.SpacingBefore = -10
        document.Add(encabezadoLINE3)
        document.Add(datatable_detventas)
        encabezado8.SpacingAfter = 4
        document.Add(encabezadoLINE2)

        document.Add(tabla_total)

        document.Add(encabezado_ttal_pago)
        document.Add(encabezado_ttal_cambio)


        document.Add(encabezado8)
        document.Add(datatable_imp)
        document.Add(encabezadoLINE2)
        document.Add(encabezado_Observ)
        document.Add(encabezado_mesa)

        document.Add(encabezado_mesero)
        document.Add(encabezado_caja)

        document.Add(encabezadoLINE3)

        document.Add(encabezado7)
        document.Add(encabezado_publicidad)

        If ComboBox_domiciliario.Text <> "" Then document.Add(encabezado_domicilio_data)
        If ComboBox_domiciliario.Text <> "" Then document.Add(encabezado_domicilio_MESAJERO)


        document.Add(encabezadoLINE2)


    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If comex_formatofactura = "Tiquete POS" Then
            que_imprime = "copia venta"
            imp_titulo1 = comex_nombrecomercial
            imp_dir = comex_dircomercio
            imp_tels = comex_tels
            imp_propietario = comex_nombrepropietario
            imp_regimen = comex_regimen
            imp_nit = comex_nit & "-" & comex_DV
            imp_resdian = comex_Resdian
            imp_intervalo = comex_intervalo

            imp_clienteDoc = cli_doc
            imp_clienteNom = cli_nom
            ImpClienteDir = cli_dir
            imp_clienteTel = cli_tel
            imp_clientemail = cli_mail

            imp_factunum = ID_VENTA_VER
            imp_fecha_factu = Label_fecha.Text

            imp_totalVenta = Me.TextBox_TOTALVENTA.Text
            imp_subtotal = TextBox_SUBTOTAL.Text
            Imp_baseimp = "0"
            imp_impuesto = "0"
            imp_totalapagar = TextBox_TOTAL_pagar.Text
            imp_efectivo = ""
            imp_cambio = ""
            imp_cajero = Label_empleado.Text
            IMP_MEDIODEPAGO = ComboBox_MEDIO_PAGO.Text

            Try
                sql = "SELECT CodProd, Producto, 
concat('x',cantidad), format(valoru,0), concat('$',format(valortotal,0))
from ventas_prods
WHERE documento='" & Label_consecutivo.Text & "'"
                da_pos = New MySqlDataAdapter(sql, conex)
                dt_pos = New DataTable
                da_pos.Fill(dt_pos)
                Me.MetroGrid_det_ventas.DataSource = dt_pos

                da_pos.Dispose()
                dt_pos.Dispose()
                conex.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            Try
                sql = "SELECT  ventas_prods.ImpNom2 as IMPUESTO, CONCAT('$',format(sum(ventas_prods.valortotal-ventas_prods.impuesto2),0)) as BASE, CONCAT('$',format(sum(ventas_prods.impuesto2),0)) as VrIMP, CONCAT('$',format(sum(ventas_prods.valortotal),0)) as VrTOTAL
FROM ventas_prods
left join ventas on ventas_prods.documento=ventas.DOCUMENTO
where ventas.documento='" & Label_consecutivo.Text & "'
group by ventas_prods.impnom2"
                da_imp = New MySqlDataAdapter(sql, conex)
                dt_imp = New DataTable
                da_imp.Fill(dt_imp)
                MetroGrid_imp.DataSource = dt_imp.DefaultView
                'Label8.Text = 0
                'For Each row As DataRow In dt.Rows
                '    If row.Item("impuesto") <> "NO" Then Label8.Text = CInt(Label8.Text) + CInt(row.Item("valor"))
                'Next
            Catch ex As Exception
            End Try
            conex.Close()
            da_imp.Dispose()
            dt_imp.Dispose()
            conex.Close()


            Try
                'Intentar generar el documento.
                alto_pag = ((MetroGrid_det_ventas.RowCount + MetroGrid_imp.RowCount) * 10) + 500
                Dim pgSize = New iTextSharp.text.Rectangle(205, alto_pag)

                'Dim doc As New Document(PageSize.A4, 8, 400, 10, 10)
                Dim doc As New Document(pgSize, 8, 8, 10, 10)

                'Path que guarda el reporte en el escritorio de windows (Desktop).
                Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\factura " & Label_consecutivo.Text & ".pdf"
                Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)

                PdfWriter.GetInstance(doc, file)
                doc.Open()

                ExportarDatosPDF_POS(doc)
                doc.Close()
                'Process.Start(filename)
            Catch ex As Exception
                'Si el intento es fallido, mostrar MsgBox.
                Me.Cursor = Cursors.Default
                MessageBox.Show("error al imprimir recibo" & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Try
                'imprimir automaticamente  _______________________________________________________________________________________
                'Dim psiPOS As System.Diagnostics.ProcessStartInfo = New System.Diagnostics.ProcessStartInfo()
                'psiPOS.UseShellExecute = True
                'psiPOS.Verb = "print"
                'psiPOS.FileName = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\factura " & Label_consecutivo.Text & ".pdf"
                'psiPOS.WindowStyle = ProcessWindowStyle.Minimized
                'psiPOS.WindowStyle = ProcessWindowStyle.Hidden
                'psiPOS.CreateNoWindow = True

                'psiPOS.ErrorDialog = False
                'psiPOS.Arguments = "/p /h"
                'Dim ppos As System.Diagnostics.Process = System.Diagnostics.Process.Start(psiPOS)
                'ppos.WaitForInputIdle()



                Dim instance As New Printing.PrinterSettings
                Dim impresosaPredt As String = instance.PrinterName

                Process.Start("C:\Program Files\Tracker Software\PDF Viewer\pdfxcview.exe", " /print:printer=""" & impresosaPredt & """ """ & Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\factura " & Label_consecutivo.Text & ".pdf" & """")


            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try


        End If




        If comex_formatofactura = "Media Carta" Then

            Try

                'sql = "SELECT cantidad as Cant, concat(codprod, '-', producto) as Producto, BASE as Base, impuesto as ICO, impuesto2 as IVA, VALORU, valortotal as ValorTotal FROM ventas_prods WHERE documento = " & CInt(consecutivo) & ""
                sql = "SELECT cantidad as Cant, concat(codprod, '-', producto) as Producto, impuesto2 as Impuesto, VALORU, valortotal as ValorTotal FROM ventas_prods WHERE documento = " & CInt(consecutivo) & ""

                dA_imprimir_prods = New MySqlDataAdapter(sql, conex)
                dt_imprimir_prods = New DataTable
                dA_imprimir_prods.Fill(dt_imprimir_prods)
                Me.MetroGrid_pdf.DataSource = dt_imprimir_prods
                Me.MetroGrid_pdf.Columns(0).HeaderText = "Cant"
                Me.MetroGrid_pdf.Columns(0).Width = 40
                Me.MetroGrid_pdf.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.MetroGrid_pdf.Columns(1).HeaderText = "Producto"
                Me.MetroGrid_pdf.Columns(1).Width = 270
                Me.MetroGrid_pdf.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                Me.MetroGrid_pdf.Columns(2).HeaderText = "IVA"
                Me.MetroGrid_pdf.Columns(2).Width = 40
                Me.MetroGrid_pdf.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Me.MetroGrid_pdf.Columns(3).HeaderText = "Valor/U"
                Me.MetroGrid_pdf.Columns(3).Width = 70
                Me.MetroGrid_pdf.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Me.MetroGrid_pdf.Columns(4).HeaderText = "TOTAL"
                Me.MetroGrid_pdf.Columns(4).Width = 80
                Me.MetroGrid_pdf.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                MetroGrid_pdf.Columns.Item("cant").DefaultCellStyle.Format = "###,##0"
                'MetroGrid_pdf.Columns.Item("base").DefaultCellStyle.Format = "###,##0"
                MetroGrid_pdf.Columns.Item("impuesto").DefaultCellStyle.Format = "###,##0"
                MetroGrid_pdf.Columns.Item("valoru").DefaultCellStyle.Format = "###,##0"
                MetroGrid_pdf.Columns.Item("valorTotal").DefaultCellStyle.Format = "###,##0"

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            dA_imprimir_prods.Dispose()
            dt_imprimir_prods.Dispose()

            If Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\") = False Then
                Try
                    My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) & "\MiClickDerecho Docs\")
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If




            Try
                'Intentar generar el documento.
                Dim doc As New Document(PageSize.A4, 20, 20, 20, 20)

                'Path que guarda el reporte en el escritorio de windows (Desktop).
                Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\factura " & Label_consecutivo.Text & ".pdf"
                Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)

                PdfWriter.GetInstance(doc, file)
                doc.Open()
                ExportarDatosPDF_2(doc)
                doc.Close()
                'Process.Start(filename)
            Catch ex As Exception
                'Si el intento es fallido, mostrar MsgBox.
                MessageBox.Show("No se puede generar el documento PDF, Cierre los documentos PDF generados anteriormente." & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


            Dim instance As New Printing.PrinterSettings
            Dim impresosaPredt As String = instance.PrinterName

            Process.Start("C:\Program Files\Tracker Software\PDF Viewer\pdfxcview.exe", " /print:printer=""" & impresosaPredt & """ """ & Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\factura " & Label_consecutivo.Text & ".pdf" & """")


        End If



        Timer_gridProds.Enabled = True

    End Sub


    Private Sub GENERAR_VENTA()
        'CONSECUTIVO VENTA
        consecutivo = 0
        cmd.Connection = conex
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select max(documento) + 1 from VENTAS"
        conex.Open()
        Try
            dr_consecutivos = cmd.ExecuteReader()
            If dr_consecutivos.Read() Then
                consecutivo = dr_consecutivos(0)
                NRO_FACTURA = consecutivo
                Label_consecutivo.Text = consecutivo

            Else
                consecutivo = 1
                NRO_FACTURA = consecutivo

            End If
        Catch ex As Exception
            consecutivo = 1
            NRO_FACTURA = consecutivo

            conex.Close()
        End Try
        conex.Close()
        Me.Label_consecutivo.Text = NRO_FACTURA
        'guardar mov
        sql = "INSERT INTO VENTAS (documento, tipoDocumento, DocCliente, ClienteNom, fecha, TOTALVENTA, DESCUENTO, BASEIMPUESTO, IMPUESTO, IMPUESTO2, TOTAL, mediodepago, fechapago, fechapagada, empleadoCod, empleado, cotizacion, turno, Estado)" &
               " VALUES (" & CLng(consecutivo) & ",'VENTAS','" & TXT_DOC_CLIENTE.Text & "','" & TXT_NOM_CLIENTE.Text & "','" & DateTime.Now.ToShortDateString & "'," & CInt(TextBox_TOTAL_pagar.Text) & ",0," & CInt(TextBox_BASEimp.Text) & "," & CInt(TextBox_impuesto.Text) & "," & CInt(TextBox_impuesto2.Text) & "," & CInt(TextBox_TOTAL_pagar.Text) & ",'EFECTIVO" & "','" & Label_fechapagar.Text & "','" & Label_FECHAPAGada.Text & "','" & usrdoc & "','" & usrnom & "','" & CInt(NRO_FACTURA) & "','" & CStr(turno_actual_global_ID) & "','DESCARGADO')"
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


        For J As Integer = 0 To datagrid_detalleProds.RowCount - 1

            sql = "INSERT INTO ventas_prods (documento, codprod, producto, cantidad, base, imp, IMP2, impuesto, IMPUESTO2, valoru, valortotal, estado,  inventariado, IMPNOM1, IMPNOM2)" &
                 "VALUES (" & CInt(consecutivo) & "," & CInt(datagrid_detalleProds.Item("CODPROD", J).Value) & ",'" & CStr(datagrid_detalleProds.Item("PRODUCTO", J).Value) & "'," & CStr(datagrid_detalleProds.Item("CANTIDAD", J).Value) & "," & CInt(datagrid_detalleProds.Item("base", J).Value) & ",'" & CInt(datagrid_detalleProds.Item("imp", J).Value) & "','" & CInt(datagrid_detalleProds.Item("imp2", J).Value) & "'," & CInt(datagrid_detalleProds.Item("impuesto", J).Value) & "," & CInt(datagrid_detalleProds.Item("impuesto2", J).Value) & "," & CInt(datagrid_detalleProds.Item("valoru", J).Value) & "," & CInt(datagrid_detalleProds.Item("valortotal", J).Value) & ",'DESCARGADO','" & PROD_INVENTARIADO & "','" & prod_iva1nom & "','" & prod_iva2nom & "')"
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



        'GUARDA EN CAJA
        'guardar mov
        If turno_actual_global <> "" Then
            Me.Label_FECHAPAGada.Text = DateTime.Now.ToShortDateString
            sql = "INSERT INTO CAJA (turno, fecha, documento, tipoDocumento, subtotal, total, mediodepago, EmpleadoDoc, empleado, estado)" &
                                       "VALUES ('" & turno_actual_global & "','" & DateTime.Now.ToShortDateString & "'," & CInt(NRO_FACTURA) & ",'COBRO CREDITO'," & TextBox_TOTALVENTA.Text & "," & TextBox_TOTAL_pagar.Text & ",'EFECTIVO'," & CInt(usrdoc) & ",'" & usrnom & "','DESCARGADO')"
            da_VENTAS = New MySqlDataAdapter(sql, conex)
            DT_VENTAS = New DataTable
            Try
                da_VENTAS.Fill(DT_VENTAS)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            da_VENTAS.Dispose()
            DT_VENTAS.Dispose()
            conex.Close()
        End If



        Me.Label1.Text = "Consultar Venta"

    End Sub




    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        If id_devolucion <> "" Then
            Form_devoluciones.Show()
            Exit Sub

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label7_Click(Nothing, Nothing)
    End Sub

    Public Sub ExportarDatosPDF(ByVal document As Document)
        Dim CANT_FILAS As Integer = 0
        'Se crea un objeto PDFTable con el numero de columnas del DataGridView.
        Dim datatable As New PdfPTable(MetroGrid_pdf.ColumnCount)
        'Se asignan algunas propiedades para el diseño del PDF.
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(MetroGrid_pdf)

        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER

        Dim encabezadoFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 10, iTextSharp.text.Font.BOLD)
        Dim contentFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 12, iTextSharp.text.Font.BOLD)
        Dim DIRFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 6, iTextSharp.text.Font.BOLD)
        Dim rowFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 7, iTextSharp.text.Font.BOLD)
        Dim DIRFont2 = iTextSharp.text.FontFactory.GetFont("Arial Black", 7.5, iTextSharp.text.Font.BOLD)

        Dim FIRMAFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 5, iTextSharp.text.Font.BOLD)
        Dim totalFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 8, iTextSharp.text.Font.BOLDITALIC)
        Dim totaltotalFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 9, iTextSharp.text.Font.BOLDITALIC)
        Dim CLIENTEFONT = iTextSharp.text.FontFactory.GetFont("Arial Black", 7, iTextSharp.text.Font.BOLDITALIC)

        'Se crea el encabezado en el PDF.

        Dim encabezado As New Paragraph("FACTURA DE VENTA   ", encabezadoFont)
        encabezado.Alignment = 2
        encabezado.Font = encabezadoFont
        Dim PDF_CONSECUTIVO As New Paragraph("No. " & Label_consecutivo.Text + "   ", encabezadoFont) : PDF_CONSECUTIVO.Alignment = 2
        Dim encabezado2 As New Paragraph("Fecha: " + Label_fecha.Text + "   ", New Font(Font.Name = "Arial Balck", 9, Font.Bold)) : encabezado2.Alignment = 2

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
        cellhome2.Phrase = New Phrase("Res. DIAN " & comex_Resdian & " de " & comex_fechadian, DIRFont2)
        If comex_Resdian = "" Then cellhome2.Phrase = New Phrase(" ", DIRFont2)
        cellhome2.HorizontalAlignment = Element.ALIGN_RIGHT
        tablahome2.AddCell(cellhome2)
        tablahome2.CompleteRow()

        cellhome2.Phrase = New Phrase(" ", CLIENTEFONT)
        cellhome2.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome2.AddCell(cellhome2)
        cellhome2.Phrase = New Phrase(" ", CLIENTEFONT)
        cellhome2.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome2.AddCell(cellhome2)
        cellhome2.Phrase = New Phrase("Rango Autorizado " & comex_intervalo & " al " & comex_intervalo2, DIRFont2)
        If comex_Resdian = "" Then cellhome2.Phrase = New Phrase(" ", DIRFont2)
        cellhome2.HorizontalAlignment = Element.ALIGN_RIGHT
        tablahome2.AddCell(cellhome2)
        tablahome2.CompleteRow()

        Dim glue = New Chunk(New VerticalPositionMark())


        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To MetroGrid_pdf.ColumnCount - 1
            Dim HEADERCELLFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 8, iTextSharp.text.Font.BOLD)

            Dim cell_TITLE As New PdfPCell
            cell_TITLE.Phrase = New Phrase(MetroGrid_pdf.Columns(i).HeaderText, HEADERCELLFont)
            cell_TITLE.HorizontalAlignment = Element.ALIGN_CENTER
            cell_TITLE.BackgroundColor = BaseColor.LIGHT_GRAY
            datatable.AddCell(cell_TITLE)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 0
        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To MetroGrid_pdf.RowCount - 1
            For j As Integer = 0 To MetroGrid_pdf.ColumnCount - 1
                Dim cell As New PdfPCell
                cell.Phrase = New Phrase(MetroGrid_pdf(j, i).FormattedValue.ToString, rowFont)
                If j = 0 Then cell.HorizontalAlignment = Element.ALIGN_CENTER
                If j = 1 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
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


        '  CONTAR LAS FILAS DE LA GRILLA GENERADA, 
        ' ESTABLECER CUANTAS GRILLAS SE NECESITAN PARA LLEGAR A MEDIA CARTA Y CARTA,
        ' AGRAGAR LLASNECESARIAS PARA LLENAR EL ESPACION Q FALTA
        CANT_FILAS = MetroGrid_pdf.RowCount

        If CANT_FILAS <= (16 - CANT_FILAS) Then
            For i As Integer = 0 To (16 - CANT_FILAS)
                For j As Integer = 0 To MetroGrid_pdf.ColumnCount - 1

                    Dim cell As New PdfPCell
                    cell.Phrase = New Phrase(" ", New Font(Font.Name = "Arial Narrow", 6, Font.Bold = False))
                    If j = 0 Then cell.HorizontalAlignment = Element.ALIGN_CENTER
                    If j = 1 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                    If j = 2 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                    If j = 3 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                    If j = 4 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                    If j = 5 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                    If j = 6 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                    If j = 7 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                    cell.Border = 0
                    cell.Border = 0
                    cell.BorderWidthRight = 0.3F
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

        cell_PIE.Phrase = New Phrase("Observaciones", New Font(Font.Name = "Arial Narrow", 5, Font.Bold))
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
        cell_PIE.Phrase = New Phrase(TextBox_SUBTOTAL.Text & "  ", totalFont)
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
        cell_PIE.Phrase = New Phrase(TextBox_Total_impuestos.Text & "  ", totalFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_PIE.AddCell(cell_PIE)
        tabla_PIE.CompleteRow()

        cell_PIE.Phrase = New Phrase("FIRMA CLIENTE:____________________ ", New Font(Font.Name = "Arial Narrow", 5, Font.Bold))
        cell_PIE.HorizontalAlignment = Element.ALIGN_LEFT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase("FIRMA VENDEDOR:___________________", New Font(Font.Name = "Arial Narrow", 5, Font.Bold))
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
        cell_PIE.Phrase = New Phrase(TextBox_TOTAL_pagar.Text & "  ", totaltotalFont)
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
        If comex_logo <> "" And File.Exists(comex_logo) = True Then
            Dim imagelogogopdf As iTextSharp.text.Image 'Declaracion de una imagen

            imagelogogopdf = iTextSharp.text.Image.GetInstance(comex_logo) 'Dirreccion a la imagen que se hace referencia
            imagelogogopdf.Alignment = Element.ALIGN_RIGHT
            imagelogogopdf.SetAbsolutePosition(25, 760) 'Posicion en el eje cartesiano
            imagelogogopdf.ScaleAbsoluteWidth(200) 'Ancho de la imagen
            imagelogogopdf.ScaleAbsoluteHeight(70) 'Altura de la imagen
            document.Add(imagelogogopdf) ' Agrega la imagen al documento
        End If
        'Se agrega el PDFTable al documento.

        Dim CUADRO1 As iTextSharp.text.Image 'COMEX INFO
        CUADRO1 = iTextSharp.text.Image.GetInstance("C:\MiClick\Datos\settings\marco.png") 'Dirreccion a la imagen que se hace referencia
        CUADRO1.Alignment = Element.ALIGN_RIGHT
        CUADRO1.SetAbsolutePosition(411, 775) 'Posicion en el eje cartesiano
        CUADRO1.ScaleAbsoluteWidth(168) 'Ancho de la imagen
        CUADRO1.ScaleAbsoluteHeight(44) 'Altura de la imagen
        document.Add(CUADRO1) ' Agrega la imagen al documento

        Dim CUADRO_cliente As iTextSharp.text.Image 'CLIENTE/BENEF
        CUADRO_cliente = iTextSharp.text.Image.GetInstance("C:\MiClick\Datos\settings\cuadro_para_portadas2.png") 'Dirreccion a la imagen que se hace referencia
        CUADRO_cliente.Alignment = Element.ALIGN_LEFT
        CUADRO_cliente.SetAbsolutePosition(18, 697) 'Posicion en el eje cartesiano
        CUADRO_cliente.ScaleAbsoluteWidth(350) 'Ancho de la imagen
        CUADRO_cliente.ScaleAbsoluteHeight(64) 'Altura de la imagen
        document.Add(CUADRO_cliente) ' Agrega la imagen al documento

        Dim CUADRO_subtotal As iTextSharp.text.Image 'Declaracion de una imagen
        CUADRO_subtotal = iTextSharp.text.Image.GetInstance("C:\MiClick\Datos\settings\square.png") 'Dirreccion a la imagen que se hace referencia
        CUADRO_subtotal.Alignment = Element.ALIGN_LEFT
        CUADRO_subtotal.SetAbsolutePosition(17.5F, 509.0F) 'Posicion en el eje cartesiano
        CUADRO_subtotal.ScaleAbsoluteWidth(563.5F) 'Ancho de la imagen
        CUADRO_subtotal.ScaleAbsoluteHeight(186) 'Altura de la imagen

        Dim CUADRO_obs As iTextSharp.text.Image 'Declaracion de una imagen
        CUADRO_obs = iTextSharp.text.Image.GetInstance("C:\MiClick\Datos\settings\fondopanel.png") 'Dirreccion a la imagen que se hace referencia
        CUADRO_obs.Alignment = Element.ALIGN_LEFT
        CUADRO_obs.SetAbsolutePosition(18, 460) 'Posicion en el eje cartesiano
        CUADRO_obs.ScaleAbsoluteWidth(350) 'Ancho de la imagen
        CUADRO_obs.ScaleAbsoluteHeight(46) 'Altura de la imagen

        Dim CUADRO_total As iTextSharp.text.Image 'Declaracion de una imagen
        CUADRO_total = iTextSharp.text.Image.GetInstance("C:\MiClick\Datos\settings\MARCO.png") 'Dirreccion a la imagen que se hace referencia
        CUADRO_total.Alignment = Element.ALIGN_LEFT
        CUADRO_total.SetAbsolutePosition(428, 457) 'Posicion en el eje cartesiano
        CUADRO_total.ScaleAbsoluteWidth(150) 'Ancho de la imagen
        CUADRO_total.ScaleAbsoluteHeight(50) 'Altura de la imagen


        Dim endline As iTextSharp.text.Image 'Declaracion de una imagen
        endline = iTextSharp.text.Image.GetInstance("C:\MiClick\Datos\settings\endline.png") 'Dirreccion a la imagen que se hace referencia
        endline.Alignment = Element.ALIGN_CENTER
        endline.SetAbsolutePosition(18, 438) 'Posicion en el eje cartesiano
        endline.ScaleAbsoluteWidth(563.5F) 'Ancho de la imagen
        endline.ScaleAbsoluteHeight(7) 'Altura de la imagen

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
    Public Sub ExportarDatosPDF_2(ByVal document As Document)
        Dim CANT_FILAS As Integer = 0
        'Se crea un objeto PDFTable con el numero de columnas del DataGridView.
        Dim datatable As New PdfPTable(MetroGrid_pdf.ColumnCount)
        'Se asignan algunas propiedades para el diseño del PDF.
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(MetroGrid_pdf)

        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.SpacingBefore = 3
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER

        Dim encabezadoFontwhite = iTextSharp.text.FontFactory.GetFont("Arial Black", 12, iTextSharp.text.Font.BOLD, BaseColor.WHITE)
        Dim encabezadoFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 13, iTextSharp.text.Font.BOLD, BaseColor.BLACK)

        Dim contentFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 13, iTextSharp.text.Font.BOLD)
        Dim DIRFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 6, iTextSharp.text.Font.BOLD)
        Dim rowFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 8.5F, iTextSharp.text.Font.BOLD)
        Dim DIRFont2 = iTextSharp.text.FontFactory.GetFont("Arial Black", 7.5, iTextSharp.text.Font.BOLD)

        Dim FIRMAFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 5, iTextSharp.text.Font.BOLD)
        Dim totalFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 8, iTextSharp.text.Font.BOLDITALIC)
        Dim totaltotalFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 9, iTextSharp.text.Font.BOLDITALIC)
        Dim CLIENTEFONT = iTextSharp.text.FontFactory.GetFont("Arial Black", 7, iTextSharp.text.Font.BOLDITALIC)

        'Se crea el encabezado en el PDF.

        Dim encabezado As New Paragraph("FACTURA  DE  VENTA     ", encabezadoFontwhite)
        encabezado.Alignment = 2
        encabezado.Font = encabezadoFontwhite

        Dim PDF_CONSECUTIVO As New Paragraph("No.    " & Label_consecutivo.Text + "    ", encabezadoFont)
        PDF_CONSECUTIVO.Alignment = 2
        PDF_CONSECUTIVO.Font = encabezadoFont

        Dim encabezado2 As New Paragraph(Label_fecha.Text + "             ", FontFactory.GetFont("Arial Black", 10, iTextSharp.text.Font.BOLDITALIC)) : encabezado2.Alignment = 2
        encabezado2.SpacingBefore = 1

        Dim tablahome As New PdfPTable(3)
        tablahome.WidthPercentage = 100
        tablahome.DefaultCell.BorderWidth = 0
        Dim anchos() As Single = {15, 60, 80}

        tablahome.SetWidths(anchos)
        tablahome.DefaultCell.Padding = 0
        tablahome.SpacingBefore = 3

        Dim cellhome As New PdfPCell
        cellhome.BorderWidth = 0
        cellhome.Phrase = New Phrase("", CLIENTEFONT)
        cellhome.HorizontalAlignment = Element.ALIGN_BOTTOM
        tablahome.AddCell(cellhome)
        cellhome.Phrase = New Phrase("", contentFont)
        cellhome.HorizontalAlignment = Element.ALIGN_RIGHT
        tablahome.AddCell(cellhome)
        cellhome.Phrase = New Phrase(comex_nombrecomercial, contentFont)
        cellhome.HorizontalAlignment = Element.ALIGN_RIGHT
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase("DOC/NIT: ", FontFactory.GetFont("Arial Black", 7, iTextSharp.text.Font.BOLDITALIC, BaseColor.WHITE))
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        cellhome.Phrase = New Phrase(TXT_DOC_CLIENTE.Text, CLIENTEFONT)
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        cellhome.Phrase = New Phrase(comex_razonsocial & " NIT:" & comex_nit & " " & comex_regimen, DIRFont)
        cellhome.HorizontalAlignment = Element.ALIGN_RIGHT
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()


        cellhome.Phrase = New Phrase("Cliente: ", FontFactory.GetFont("Arial Black", 7, iTextSharp.text.Font.BOLDITALIC, BaseColor.WHITE))
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        cellhome.Phrase = New Phrase(TXT_NOM_CLIENTE.Text, CLIENTEFONT)
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        cellhome.Phrase = New Phrase(comex_dircomercio + " " + comex_ciudad + " Tel: " + comex_tels, DIRFont2)
        cellhome.HorizontalAlignment = Element.ALIGN_RIGHT
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase("Dirección:  ", FontFactory.GetFont("Arial Black", 7, iTextSharp.text.Font.BOLDITALIC, BaseColor.WHITE))
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        cellhome.Phrase = New Phrase(TXT_DIR_CLIENTE.Text.ToString, CLIENTEFONT)
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        cellhome.Phrase = New Phrase("Res. DIAN " & comex_Resdian & " de " & comex_fechadian, DIRFont2)
        If comex_Resdian = "" Then cellhome.Phrase = New Phrase(" ", DIRFont2)
        cellhome.HorizontalAlignment = Element.ALIGN_RIGHT
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase("Teléfono(s): ", FontFactory.GetFont("Arial Black", 7, iTextSharp.text.Font.BOLDITALIC, BaseColor.WHITE))
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        cellhome.Phrase = New Phrase(TXT_TELS_CLIENTE.Text, DIRFont2)
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        cellhome.Phrase = New Phrase("Rango Autorizado " & comex_intervalo & " al " & comex_intervalo2, DIRFont2)
        If comex_Resdian = "" Then cellhome.Phrase = New Phrase(" ", DIRFont2)
        cellhome.HorizontalAlignment = Element.ALIGN_RIGHT
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        'Dim glue = New Chunk(New VerticalPositionMark())
        'imagen tabla

        'If File.Exists("C:\MiClick\Datos\settings\grid.png") = True Then
        '    Dim imagegrid As iTextSharp.text.Image 'Declaracion de una imagen

        '    imagegrid = iTextSharp.text.Image.GetInstance("C:\MiClick\Datos\settings\grid.png") 'Dirreccion a la imagen que se hace referencia
        '    imagegrid.Alignment = Element.ALIGN_LEFT
        '    imagegrid.SetAbsolutePosition(18, 510) 'Posicion en el eje cartesiano
        '    imagegrid.ScaleAbsoluteWidth(559) 'Ancho de la imagen
        '    imagegrid.ScaleAbsoluteHeight(186) 'Altura de la imagen
        '    document.Add(imagegrid) ' Agrega la imagen al documento
        '    'Se agrega el PDFTable al documento.
        'End If


        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To MetroGrid_pdf.ColumnCount - 1
            Dim HEADERCELLFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK)

            Dim cell_TITLE As New PdfPCell
            cell_TITLE.BorderWidth = 0
            cell_TITLE.Phrase = New Phrase(MetroGrid_pdf.Columns(i).HeaderText, HEADERCELLFont)
            cell_TITLE.HorizontalAlignment = Element.ALIGN_CENTER
            cell_TITLE.BackgroundColor = BaseColor.LIGHT_GRAY
            datatable.AddCell(cell_TITLE)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 0
        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To MetroGrid_pdf.RowCount - 1
            For j As Integer = 0 To MetroGrid_pdf.ColumnCount - 1
                Dim cell As New PdfPCell

                cell.Phrase = New Phrase(MetroGrid_pdf(j, i).FormattedValue.ToString, rowFont)
                If j = 0 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 1 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 2 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 3 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 4 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 5 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                'If j = 6 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                'If j = 7 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                cell.Border = 0
                'cell.BorderWidthRight = 0.3F
                'cell.BorderColorRight = BaseColor.BLACK
                cell.PaddingTop = 3
                datatable.AddCell(cell)

            Next
            datatable.CompleteRow()
            If MetroGrid_pdf.RowCount = 11 Then

            End If
        Next


        '  CONTAR LAS FILAS DE LA GRILLA GENERADA, 
        ' ESTABLECER CUANTAS GRILLAS SE NECESITAN PARA LLEGAR A MEDIA CARTA Y CARTA,
        ' AGRAGAR LLASNECESARIAS PARA LLENAR EL ESPACION Q FALTA
        CANT_FILAS = MetroGrid_pdf.RowCount

        If CANT_FILAS <= (11 - CANT_FILAS) Then
            For i As Integer = 0 To (11 - CANT_FILAS)
                For j As Integer = 0 To MetroGrid_pdf.ColumnCount - 1

                    Dim cell As New PdfPCell
                    cell.Phrase = New Phrase("- ", iTextSharp.text.FontFactory.GetFont("Arial Black", 10, iTextSharp.text.Font.BOLD, BaseColor.WHITE))
                    If j = 0 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                    If j = 1 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                    If j = 2 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                    If j = 3 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                    If j = 4 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                    If j = 5 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                    'If j = 6 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                    'If j = 7 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                    cell.Border = 0
                    'cell.BorderWidthRight = 0.3F
                    'cell.BorderColorRight = BaseColor.BLACK
                    datatable.AddCell(cell)
                Next
                datatable.CompleteRow()
            Next
        End If

        Dim tabla_PIE As New PdfPTable(6)
        tabla_PIE.WidthPercentage = 100
        tabla_PIE.DefaultCell.Padding = 0
        tabla_PIE.DefaultCell.BorderWidth = 0
        tabla_PIE.SpacingBefore = 0

        Dim cell_PIE As New PdfPCell
        cell_PIE.BorderWidth = 0
        'cell_PIE.Padding = 0

        cell_PIE.Phrase = New Phrase("  Observaciones", iTextSharp.text.FontFactory.GetFont("Arial Narrow", 5, iTextSharp.text.Font.BOLD, BaseColor.BLACK))
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
        cell_PIE.Phrase = New Phrase(TextBox_SUBTOTAL.Text & "  ", totalFont)
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
        cell_PIE.Phrase = New Phrase(TextBox_Total_impuestos.Text & "  ", totalFont)
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
        cell_PIE.Phrase = New Phrase("Descuentos", totalFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase(TextBox_DESCUENTO.Text & "  ", totalFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_PIE.AddCell(cell_PIE)
        tabla_PIE.CompleteRow()



        cell_PIE.Phrase = New Phrase("CLIENTE:______________________ ", iTextSharp.text.FontFactory.GetFont("Arial Narrow", 5, iTextSharp.text.Font.BOLD, BaseColor.BLACK))
        cell_PIE.HorizontalAlignment = Element.ALIGN_BOTTOM

        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase("VENDEDOR:_____________________", iTextSharp.text.FontFactory.GetFont("Arial Narrow", 5, iTextSharp.text.Font.BOLD, BaseColor.BLACK))
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
        cell_PIE.Phrase = New Phrase(TextBox_TOTAL_pagar.Text & "  ", totaltotalFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_PIE.AddCell(cell_PIE)
        tabla_PIE.CompleteRow()


        cell_PIE.BackgroundColor = BaseColor.LIGHT_GRAY
        cell_PIE.Phrase = New Phrase("Fecha: " + Now.Date(), New Font(Font.Name = "Arial Narrow", 5, Font.Bold))
        cell_PIE.HorizontalAlignment = Element.ALIGN_TOP
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase("Generado Por: ", New Font(Font.Name = "Arial Narrow", 5, Font.Bold))
        cell_PIE.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase(usrnom, New Font(Font.Name = "Arial Narrow", 5, Font.Bold))
        cell_PIE.HorizontalAlignment = Element.ALIGN_LEFT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase(" ", New Font(Font.Name = "Arial Narrow", 5, Font.Bold))
        cell_PIE.HorizontalAlignment = Element.ALIGN_TOP
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase("Sistemas POS ", New Font(Font.Name = "Arial Narrow", 5, Font.Bold))
        cell_PIE.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase("www.miclickderecho.com", New Font(Font.Name = "Arial Narrow", 5, Font.Bold))
        cell_PIE.HorizontalAlignment = Element.ALIGN_LEFT
        tabla_PIE.AddCell(cell_PIE)
        tabla_PIE.CompleteRow()

        'LOGO
        If comex_logo <> "" And File.Exists(comex_logo) Then
            Dim imagelogogopdf As iTextSharp.text.Image 'Declaracion de una imagen

            imagelogogopdf = iTextSharp.text.Image.GetInstance(comex_logo) 'Dirreccion a la imagen que se hace referencia
            imagelogogopdf.Alignment = Element.ALIGN_CENTER
            imagelogogopdf.SetAbsolutePosition(20, alto_pag - 60) 'Posicion en el eje cartesiano
            imagelogogopdf.ScaleAbsoluteWidth(160) 'Ancho de la imagen
            imagelogogopdf.ScaleAbsoluteHeight(60) 'Altura de la imagen
            document.Add(imagelogogopdf) ' Agrega la imagen al documento
        End If
        'Se agrega el PDFTable al documento.


        Dim CUADRO_fecha As iTextSharp.text.Image 'CLIENTE/BENEF
        CUADRO_fecha = iTextSharp.text.Image.GetInstance("C:\MiClick\Datos\settings\cuadrofecha.png") 'Dirreccion a la imagen que se hace referencia
        CUADRO_fecha.Alignment = Element.ALIGN_RIGHT
        CUADRO_fecha.SetAbsolutePosition(420, 766) 'Posicion en el eje cartesiano
        CUADRO_fecha.ScaleAbsoluteWidth(150) 'Ancho de la imagen
        CUADRO_fecha.ScaleAbsoluteHeight(15) 'Altura de la imagen
        document.Add(CUADRO_fecha) ' Agrega la imagen al documento


        Dim CUADRO_documento As iTextSharp.text.Image 'COMEX INFO
        CUADRO_documento = iTextSharp.text.Image.GetInstance("C:\MiClick\Datos\settings\tipodoc.png") 'Dirreccion a la imagen que se hace referencia

        CUADRO_documento.Alignment = Element.ALIGN_RIGHT
        CUADRO_documento.SetAbsolutePosition(410, 778) 'Posicion en el eje cartesiano
        CUADRO_documento.ScaleAbsoluteWidth(168) 'Ancho de la imagen
        CUADRO_documento.ScaleAbsoluteHeight(44) 'Altura de la imagen
        document.Add(CUADRO_documento) ' Agrega la imagen al documento



        Dim CUADRO_cliente As iTextSharp.text.Image 'CLIENTE/BENEF
        CUADRO_cliente = iTextSharp.text.Image.GetInstance("C:\MiClick\Datos\settings\cuadrocli.png") 'Dirreccion a la imagen que se hace referencia
        CUADRO_cliente.Alignment = Element.ALIGN_LEFT
        CUADRO_cliente.SetAbsolutePosition(18, 736) 'Posicion en el eje cartesiano
        CUADRO_cliente.ScaleAbsoluteWidth(150) 'Ancho de la imagen
        CUADRO_cliente.ScaleAbsoluteHeight(12) 'Altura de la imagen
        document.Add(CUADRO_cliente) ' Agrega la imagen al documento

        Dim CUADRO_cliente2 As iTextSharp.text.Image 'CLIENTE/BENEF
        CUADRO_cliente2 = iTextSharp.text.Image.GetInstance("C:\MiClick\Datos\settings\cuadrocli2.png") 'Dirreccion a la imagen que se hace referencia
        CUADRO_cliente2.Alignment = Element.ALIGN_LEFT
        CUADRO_cliente2.SetAbsolutePosition(18, 725) 'Posicion en el eje cartesiano
        CUADRO_cliente2.ScaleAbsoluteWidth(300) 'Ancho de la imagen
        CUADRO_cliente2.ScaleAbsoluteHeight(12) 'Altura de la imagen
        document.Add(CUADRO_cliente2) ' Agrega la imagen al documento

        Dim CUADRO_cliente3 As iTextSharp.text.Image 'CLIENTE/BENEF
        CUADRO_cliente3 = iTextSharp.text.Image.GetInstance("C:\MiClick\Datos\settings\cuadrocli2.png") 'Dirreccion a la imagen que se hace referencia
        CUADRO_cliente3.Alignment = Element.ALIGN_LEFT
        CUADRO_cliente3.SetAbsolutePosition(18, 714) 'Posicion en el eje cartesiano
        CUADRO_cliente3.ScaleAbsoluteWidth(300) 'Ancho de la imagen
        CUADRO_cliente3.ScaleAbsoluteHeight(12) 'Altura de la imagen
        document.Add(CUADRO_cliente3) ' Agrega la imagen al documento

        Dim CUADRO_cliente4 As iTextSharp.text.Image 'CLIENTE/BENEF
        CUADRO_cliente4 = iTextSharp.text.Image.GetInstance("C:\MiClick\Datos\settings\cuadrocli2.png") 'Dirreccion a la imagen que se hace referencia
        CUADRO_cliente4.Alignment = Element.ALIGN_LEFT
        CUADRO_cliente4.SetAbsolutePosition(18, 703) 'Posicion en el eje cartesiano
        CUADRO_cliente4.ScaleAbsoluteWidth(300) 'Ancho de la imagen
        CUADRO_cliente4.ScaleAbsoluteHeight(12) 'Altura de la imagen
        document.Add(CUADRO_cliente4) ' Agrega la imagen al documento



        Dim CUADRO_obs As iTextSharp.text.Image 'Declaracion de una imagen
        CUADRO_obs = iTextSharp.text.Image.GetInstance("C:\MiClick\Datos\settings\cuadroobs.png") 'Dirreccion a la imagen que se hace referencia
        CUADRO_obs.Alignment = Element.ALIGN_LEFT
        CUADRO_obs.SetAbsolutePosition(18, 457) 'Posicion en el eje cartesiano
        CUADRO_obs.ScaleAbsoluteWidth(350) 'Ancho de la imagen
        CUADRO_obs.ScaleAbsoluteHeight(52) 'Altura de la imagen

        Dim CUADRO_total As iTextSharp.text.Image 'Declaracion de una imagen
        CUADRO_total = iTextSharp.text.Image.GetInstance("C:\MiClick\Datos\settings\cuadrototal.png") 'Dirreccion a la imagen que se hace referencia
        CUADRO_total.Alignment = Element.ALIGN_LEFT
        CUADRO_total.SetAbsolutePosition(428, 457) 'Posicion en el eje cartesiano
        CUADRO_total.ScaleAbsoluteWidth(150) 'Ancho de la imagen
        CUADRO_total.ScaleAbsoluteHeight(52) 'Altura de la imagen

        Dim CUADRO_total2 As iTextSharp.text.Image 'Declaracion de una imagen
        CUADRO_total2 = iTextSharp.text.Image.GetInstance("C:\MiClick\Datos\settings\cuadrototal.png") 'Dirreccion a la imagen que se hace referencia
        CUADRO_total2.Alignment = Element.ALIGN_LEFT
        CUADRO_total2.SetAbsolutePosition(428, 442) 'Posicion en el eje cartesiano
        CUADRO_total2.ScaleAbsoluteWidth(150) 'Ancho de la imagen
        CUADRO_total2.ScaleAbsoluteHeight(17) 'Altura de la imagen


        Dim endline As iTextSharp.text.Image 'Declaracion de una imagen
        endline = iTextSharp.text.Image.GetInstance("C:\MiClick\Datos\settings\endline.png") 'Dirreccion a la imagen que se hace referencia
        endline.Alignment = Element.ALIGN_CENTER
        endline.SetAbsolutePosition(18, 440) 'Posicion en el eje cartesiano
        endline.ScaleAbsoluteWidth(563.5F) 'Ancho de la imagen
        endline.ScaleAbsoluteHeight(2) 'Altura de la imagen

        document.Add(encabezado)
        document.Add(PDF_CONSECUTIVO)
        document.Add(encabezado2)
        document.Add(tablahome)
        datatable.SpacingBefore = 10
        document.Add(datatable)
        tabla_PIE.SpacingBefore = 5
        document.Add(tabla_PIE)
        'document.Add(CUADRO_total)
        'document.Add(CUADRO_total2)

        'document.Add(descuento)
        'document.Add(CUADRO_obs)
        'document.Add(endline)

    End Sub
    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        'funcion para obtener el tamaño de la columnas del datagridview
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If comex_formatofactura = "Tiquete POS" Then
            que_imprime = "copia venta"
            imp_titulo1 = comex_nombrecomercial
            imp_dir = comex_dircomercio
            imp_tels = comex_tels
            imp_propietario = comex_nombrepropietario
            imp_regimen = comex_regimen
            imp_nit = comex_nit & "-" & comex_DV
            imp_resdian = comex_Resdian
            imp_intervalo = comex_intervalo

            imp_clienteDoc = cli_doc
            imp_clienteNom = cli_nom
            ImpClienteDir = cli_dir
            imp_clienteTel = cli_tel
            imp_clientemail = cli_mail

            imp_factunum = ID_VENTA_VER
            imp_fecha_factu = Label_fecha.Text

            imp_totalVenta = Me.TextBox_TOTALVENTA.Text
            imp_subtotal = TextBox_SUBTOTAL.Text
            Imp_baseimp = "0"
            imp_impuesto = "0"
            imp_totalapagar = TextBox_TOTAL_pagar.Text
            imp_efectivo = ""
            imp_cambio = ""
            imp_cajero = Label_empleado.Text
            IMP_MEDIODEPAGO = ComboBox_MEDIO_PAGO.Text

            Try
                sql = "SELECT CodProd, Producto, 
concat('x',cantidad), format(valoru,0), concat('$',format(valortotal,0))
from ventas_prods
WHERE documento='" & Label_consecutivo.Text & "'"
                da_pos = New MySqlDataAdapter(sql, conex)
                dt_pos = New DataTable
                da_pos.Fill(dt_pos)
                Me.MetroGrid_det_ventas.DataSource = dt_pos

                da_pos.Dispose()
                dt_pos.Dispose()
                conex.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            Try
                sql = "SELECT  ventas_prods.ImpNom2 as IMPUESTO, CONCAT('$',format(sum(ventas_prods.valortotal-ventas_prods.impuesto2),0)) as BASE, CONCAT('$',format(sum(ventas_prods.impuesto2),0)) as VrIMP, CONCAT('$',format(sum(ventas_prods.valortotal),0)) as VrTOTAL
FROM ventas_prods
left join ventas on ventas_prods.documento=ventas.DOCUMENTO
where ventas.documento='" & Label_consecutivo.Text & "'
group by ventas_prods.impnom2"
                da_imp = New MySqlDataAdapter(sql, conex)
                dt_imp = New DataTable
                da_imp.Fill(dt_imp)
                MetroGrid_imp.DataSource = dt_imp.DefaultView
                'Label8.Text = 0
                'For Each row As DataRow In dt.Rows
                '    If row.Item("impuesto") <> "NO" Then Label8.Text = CInt(Label8.Text) + CInt(row.Item("valor"))
                'Next
            Catch ex As Exception
            End Try
            conex.Close()
            da_imp.Dispose()
            dt_imp.Dispose()
            conex.Close()


            Try
                'Intentar generar el documento.
                alto_pag = ((MetroGrid_det_ventas.RowCount + MetroGrid_imp.RowCount) * 10) + 500
                Dim pgSize = New iTextSharp.text.Rectangle(205, alto_pag)

                'Dim doc As New Document(PageSize.A4, 8, 400, 10, 10)
                Dim doc As New Document(pgSize, 8, 8, 10, 10)

                'Path que guarda el reporte en el escritorio de windows (Desktop).
                Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\factura " & Label_consecutivo.Text & ".pdf"
                Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)

                PdfWriter.GetInstance(doc, file)
                doc.Open()

                ExportarDatosPDF_POS(doc)
                doc.Close()
                Process.Start(filename)
            Catch ex As Exception
                'Si el intento es fallido, mostrar MsgBox.
                Me.Cursor = Cursors.Default
                MessageBox.Show("error al generar recibo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


        End If


        If comex_formatofactura = "Media Carta" Then

            Try

                'sql = "SELECT cantidad as Cant, concat(codprod, '-', producto) as Producto, BASE as Base, impuesto as ICO, impuesto2 as IVA, VALORU, valortotal as ValorTotal FROM ventas_prods WHERE documento = " & CInt(consecutivo) & ""
                sql = "SELECT 
V.cantidad as Cant, P.CODBARRAS as CodBarras ,concat(V.codprod, '-', V.producto) as Producto, 
V.impuesto2 as Impuesto, 
V.VALORU, V.valortotal as ValorTotal 
FROM ventas_prods V
INNER JOIN  PRODUCTOS P ON V.CodProd=P.COD
WHERE documento = " & CInt(consecutivo) & ""

                dA_imprimir_prods = New MySqlDataAdapter(sql, conex)
                dt_imprimir_prods = New DataTable
                dA_imprimir_prods.Fill(dt_imprimir_prods)
                Me.MetroGrid_pdf.DataSource = dt_imprimir_prods
                Me.MetroGrid_pdf.Columns(0).HeaderText = "Cant"
                Me.MetroGrid_pdf.Columns(0).Width = 40
                Me.MetroGrid_pdf.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.MetroGrid_pdf.Columns(1).HeaderText = "CodBarras"
                Me.MetroGrid_pdf.Columns(1).Width = 80
                Me.MetroGrid_pdf.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.MetroGrid_pdf.Columns(2).HeaderText = "Producto"
                Me.MetroGrid_pdf.Columns(2).Width = 260
                Me.MetroGrid_pdf.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                Me.MetroGrid_pdf.Columns(3).HeaderText = "IVA"
                Me.MetroGrid_pdf.Columns(3).Width = 70
                Me.MetroGrid_pdf.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Me.MetroGrid_pdf.Columns(4).HeaderText = "Valor/U"
                Me.MetroGrid_pdf.Columns(4).Width = 80
                Me.MetroGrid_pdf.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Me.MetroGrid_pdf.Columns(5).HeaderText = "TOTAL"
                Me.MetroGrid_pdf.Columns(5).Width = 80
                Me.MetroGrid_pdf.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                MetroGrid_pdf.Columns.Item("cant").DefaultCellStyle.Format = "###,##0"
                'MetroGrid_pdf.Columns.Item("base").DefaultCellStyle.Format = "###,##0"
                MetroGrid_pdf.Columns.Item("impuesto").DefaultCellStyle.Format = "###,##0"
                MetroGrid_pdf.Columns.Item("valoru").DefaultCellStyle.Format = "###,##0"
                MetroGrid_pdf.Columns.Item("valorTotal").DefaultCellStyle.Format = "###,##0"

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            dA_imprimir_prods.Dispose()
            dt_imprimir_prods.Dispose()

            If Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\") = False Then
                Try
                    My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) & "\MiClickDerecho Docs\")
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If




            Try
                'Intentar generar el documento.
                Dim doc As New Document(PageSize.A4, 20, 20, 20, 20)

                'Path que guarda el reporte en el escritorio de windows (Desktop).
                Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\factura " & Label_consecutivo.Text & ".pdf"
                Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)

                PdfWriter.GetInstance(doc, file)
                doc.Open()
                ExportarDatosPDF_2(doc)
                doc.Close()
                Process.Start(filename)
            Catch ex As Exception
                'Si el intento es fallido, mostrar MsgBox.
                MessageBox.Show("No se puede generar el documento PDF, Cierre los documentos PDF generados anteriormente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If


    End Sub



    Private Sub Timer_prod_data_Tick(sender As Object, e As EventArgs) Handles Timer_prod_data.Tick

    End Sub

    Private Sub TextBox_Total_impuestos_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Total_impuestos.TextChanged

    End Sub

    Private Sub Form_verfactura_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.ComboBox_domiciliario.Items.Clear()

        Try
            sql = "SELECT documento, nombre FROM empleados WHERE cargo='Mensajero'"
            da_mensajeros = New MySqlDataAdapter(sql, conex)
            DT_mensajeros = New DataTable
            da_mensajeros.Fill(DT_mensajeros)
            For Each row As DataRow In DT_mensajeros.Rows
                Me.ComboBox_domiciliario.Items.Add(CStr(row.Item("nombre")))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_mensajeros.Dispose()
        DT_mensajeros.Dispose()
        conex.Close()




        Try
            If ID_VENTA_VER <> "" Then sql = "SELECT * FROM ventas WHERE documento = " & CInt(ID_VENTA_VER) & ""
            If ver_cxc <> "" Then sql = "SELECT * FROM ventas_CREDITO WHERE documento = " & CInt(ver_cxc) & "" : Me.Label1.Text = "Consultar Venta por Cobrar"

            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                Label_consecutivo.Text = row.Item("documento")
                consecutivo = row.Item("documento")
                Me.Label_mesa.Text = row.Item("MESA")
                Me.ComboBox_MESERO.Text = row.Item("MESERO")
                Label_fecha.Text = row.Item("fecha")
                Me.Label_estado_movimiento.Text = row.Item("estado")
                If ver_cxc <> "" And Me.Label_estado_movimiento.Text = "PENDIENTE" Then Me.Label_estado_movimiento.ForeColor = Color.Red
                cli_doc = row.Item("doccliente")
                Me.ComboBox_MEDIO_PAGO.Text = row.Item("MEDIODEPAGO")
                Me.Label_fechapagar.Text = row.Item("fechapago")
                Me.Label_FECHAPAGada.Text = row.Item("fechapagada")
                Me.Label_empleado.Text = row.Item("EMPLEADO")
                Me.TextBox_DESCUENTO.Text = row.Item("DESCUENTO")
                label_bodega.Text = row.Item("bodega")
                Me.TextBox1.Text = row.Item("OBSERVACIONES")

                propina = row.Item("propina")
                TextBox_propina.Text = propina


                id_devolucion = row.Item("devolucion")
                If row.Item("devolucion") <> "" Then Me.Button2.Visible = True : Me.Label7.Visible = True
                If row.Item("devolucion") = "" Then Me.Button2.Visible = False : Me.Label7.Visible = False

                domicilio_ID = row.Item("DOMICILIO")
                Me.ComboBox_domiciliario.Visible = False
                If domicilio_ID <> "" Then
                    venta_con_domicilio = "SI"
                    domiciliario = row.Item("DOMICILIario")
                    Me.ComboBox_domiciliario.Text = domiciliario : Me.ComboBox_domiciliario.Visible = True
                    TextBox_domiciliovr.Visible = True
                    TextBox_domiciliovr.Text = row.Item("DOMICILIOVR")
                    Me.Label37.Visible = True : Me.Label37.Text = "RECRAGO"
                End If

                If Label_estado_movimiento.Text = "ANULADA" Then
                    Me.Button_ANULAR.Enabled = False

                End If

                Dim cambios As String()
                Try
                    cambios = Split(row.Item("cambio"), "|")
                    Label27.Text = cambios(0)
                    Label30.Text = cambios(1)
                Catch ex As Exception

                End Try

            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()





        Try
            sql = "SELECT * FROM PROVEEDORES where DOCUMENTO='" & CStr(cli_doc) & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt_clientes = New DataTable
            da.Fill(dt_clientes)
            For Each row As DataRow In dt_clientes.Rows
                cli_doc = row.Item("DOCUMENTO")
                cli_nom = row.Item("nombre")
                cli_tel = row.Item("TELEFONO")
                cli_dir = row.Item("DIRECCION")
                cli_mail = row.Item("email")

                Me.TXT_DOC_CLIENTE.Text = row.Item("DOCUMENTO")
                Me.TXT_NOM_CLIENTE.Text = row.Item("nombre")
                Me.TXT_TELS_CLIENTE.Text = row.Item("TELEFONO")
                Me.TXT_DIR_CLIENTE.Text = row.Item("DIRECCION")
                Me.txt_mail_cliente.Text = row.Item("email")

                Button_elim_cliente.Visible = True
            Next
        Catch ex As Exception

        End Try
        dt_clientes.Dispose()
        conex.Close()


        Timer_gridProds.Enabled = True

    End Sub

    Private Sub MetroGrid_pdf_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button_cerrar_panel_opciones_Click(sender As Object, e As EventArgs) Handles Button_cerrar_panel_opciones.Click
        If Me.Panel_impuestos.Visible = True Then Me.Panel_impuestos.Visible = False : Me.datagrid_detalleProds.Visible = True : Exit Sub
        If Me.Panel_impuestos.Visible = False Then Me.Panel_impuestos.Visible = True : Me.datagrid_detalleProds.Visible = False : Exit Sub
    End Sub

    Private Sub grid_VENTAsprods()
        Try

            If ID_VENTA_VER <> "" Then sql = "SELECT * FROM ventas_prods WHERE documento = " & CInt(Label_consecutivo.Text) & ""
            If ver_cxc <> "" Then sql = "SELECT * FROM ventas_CREDITO_prods WHERE documento = " & CInt(Label_consecutivo.Text) & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.datagrid_detalleProds.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()

        Me.datagrid_detalleProds.Columns(0).Visible = False
        Me.datagrid_detalleProds.Columns(1).Visible = False
        Me.datagrid_detalleProds.Columns(2).HeaderText = "Codigo"
        Me.datagrid_detalleProds.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.datagrid_detalleProds.Columns(3).HeaderText = "Producto"
        Me.datagrid_detalleProds.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.datagrid_detalleProds.Columns(3).Width = 180
        Me.datagrid_detalleProds.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.datagrid_detalleProds.Columns(4).HeaderText = "Cant"
        Me.datagrid_detalleProds.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.datagrid_detalleProds.Columns(5).Visible = False
        Me.datagrid_detalleProds.Columns(6).HeaderText = "ICO"
        Me.datagrid_detalleProds.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.datagrid_detalleProds.Columns(7).HeaderText = "IVA"
        Me.datagrid_detalleProds.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.datagrid_detalleProds.Columns(8).Visible = False
        Me.datagrid_detalleProds.Columns(9).Visible = False
        Me.datagrid_detalleProds.Columns(10).HeaderText = "Valor/U"
        Me.datagrid_detalleProds.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.datagrid_detalleProds.Columns(11).HeaderText = "TOTAL"
        Me.datagrid_detalleProds.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.datagrid_detalleProds.Columns(12).Visible = False
        Me.datagrid_detalleProds.Columns(13).Visible = False
        Me.datagrid_detalleProds.Columns(14).Visible = False
        Me.datagrid_detalleProds.Columns(15).Visible = False
        Me.datagrid_detalleProds.Columns(16).Visible = False
        Me.datagrid_detalleProds.Columns(17).Visible = False
        Me.datagrid_detalleProds.Columns(18).Visible = False
        Me.datagrid_detalleProds.Columns(19).Visible = False

        Me.datagrid_detalleProds.Columns(20).Visible = False
        Me.datagrid_detalleProds.Columns(21).Visible = False
        Me.datagrid_detalleProds.Columns(22).Visible = False
        Me.datagrid_detalleProds.Columns(23).Visible = False
        Me.datagrid_detalleProds.Columns(24).Visible = False

        datagrid_detalleProds.Columns.Item("cantidad").DefaultCellStyle.Format = "###,##0"
        datagrid_detalleProds.Columns.Item("base").DefaultCellStyle.Format = "###,##0"
        datagrid_detalleProds.Columns.Item("imp").DefaultCellStyle.Format = "###,##0"
        datagrid_detalleProds.Columns.Item("imp2").DefaultCellStyle.Format = "###,##0"
        datagrid_detalleProds.Columns.Item("valoru").DefaultCellStyle.Format = "###,##0"
        datagrid_detalleProds.Columns.Item("VALORTOTAL").DefaultCellStyle.Format = "###,##0"

        Me.datagrid_detalleProds.Refresh()
        Me.TextBox_TOTALVENTA.Text = 0
        Me.TextBox_impuesto.Text = 0
        Me.TextBox_impuesto2.Text = 0
        Me.TextBox_BASEimp.Text = 0
        Me.TextBox_Total_impuestos.Text = 0
        Try
            For i As Integer = 0 To datagrid_detalleProds.RowCount - 1
                Me.TextBox_TOTALVENTA.Text = Me.TextBox_TOTALVENTA.Text + datagrid_detalleProds.Item("valortotal", i).Value
                Me.TextBox_TOTALVENTA.Text = Format(CDec(Me.TextBox_TOTALVENTA.Text), "##,##0")

                Me.TextBox_impuesto.Text = CInt(Me.TextBox_impuesto.Text) + datagrid_detalleProds.Item("impuesto", i).Value
                Me.TextBox_impuesto2.Text = CInt(Me.TextBox_impuesto2.Text) + datagrid_detalleProds.Item("impuesto2", i).Value

                Me.TextBox_BASEimp.Text = CInt(Me.TextBox_BASEimp.Text) + datagrid_detalleProds.Item("BASE", i).Value

                Me.TextBox_Total_impuestos.Text = CInt(Me.TextBox_impuesto.Text) + CInt(Me.TextBox_impuesto2.Text)
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        'descuentos==================
        Try
            sql = "SELECT PRODUCTO, VALORTOTAL FROM ventas_dctos WHERE DOCUMENTO='" & Label_consecutivo.Text & "'"
            da_dctos_venta = New MySqlDataAdapter(sql, conex)
            dt_dctos_venta = New DataTable
            da_dctos_venta.Fill(dt_dctos_venta)
            Me.MetroGrid_dctos.DataSource = dt_dctos_venta
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        da_dctos_venta.Dispose()
        dt_dctos_venta.Dispose()
        conex.Close()
        TextBox_DESCUENTO.Text = 0
        Try
            For i As Integer = 0 To MetroGrid_dctos.RowCount - 1
                Me.TextBox_DESCUENTO.Text = CInt(Me.TextBox_DESCUENTO.Text) + CInt(MetroGrid_dctos.Item("valortotal", i).Value)
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        '================================================

        Me.TextBox_SUBTOTAL.Text = CInt(Me.TextBox_TOTALVENTA.Text)
        Me.TextBox_SUBTOTAL.Text = Format(CDec(Me.TextBox_SUBTOTAL.Text), "##,##0")

        If TextBox_propina.Text = "" Then TextBox_propina.Text = "0"

        Me.TextBox_TOTAL_pagar.Text = CInt(Me.TextBox_SUBTOTAL.Text) + CInt(Me.TextBox_propina.Text) + CInt(Me.TextBox_domiciliovr.Text) + CInt(Me.TextBox_DESCUENTO.Text)

        Me.TextBox_BASEimp.Text = Format(CDec(Me.TextBox_BASEimp.Text), "##,##0")
        Me.TextBox_impuesto.Text = Format(CDec(Me.TextBox_impuesto.Text), "##,##0")
        Me.TextBox_impuesto2.Text = Format(CDec(Me.TextBox_impuesto2.Text), "##,##0")
        Me.TextBox_Total_impuestos.Text = Format(CDec(Me.TextBox_Total_impuestos.Text), "##,##0")
        Me.TextBox_TOTAL_pagar.Text = Format(CDec(Me.TextBox_TOTAL_pagar.Text), "##,##0")


        Try
            sql = "SELECT CODPROD AS CODIGO, PRODUCTO, BASE AS BASE, IMP AS ICO, IMP2 AS IVA, VALORU, VALORTOTAL FROM ventas_prods WHERE DOCUMENTO='" & Label_consecutivo.Text & "' and concat(impnom1,impnom2)<>'NONO'"

            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.MetroGrid_impuestos.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message.ToString)

        End Try




    End Sub







    Private Sub Form_verfactura_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ID_VENTA_VER = ""
        ver_cxc = ""
    End Sub

    Private Sub Form_verfactura_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If venta_con_domicilio = "SI" Then

            Try
                sql = "SELECT * FROM domicilios WHERE factura = " & Me.Label_consecutivo.Text & ""
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                da.Fill(dt)
                For Each row As DataRow In dt.Rows
                    domicilio_ID = "Domicilio # " & row.Item("cons")
                    ComboBox_domiciliario.Text = row.Item("mensajero")
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da.Dispose()
            dt.Dispose()

            ComboBox_domiciliario.Visible = True
            Me.Label_emp_mensajero.Visible = True
            Me.BunifuCheckbox1.Visible = True : BunifuCheckbox1.Checked = True
        End If
    End Sub

    Private Sub TextBox_Total_impuestos_Click(sender As Object, e As EventArgs) Handles TextBox_Total_impuestos.Click
        If Me.Panel_impuestos.Visible = True Then Me.Panel_impuestos.Visible = False : Me.datagrid_detalleProds.Visible = True : Exit Sub
        If Me.Panel_impuestos.Visible = False Then Me.Panel_impuestos.Visible = True : Me.datagrid_detalleProds.Visible = False : Exit Sub
    End Sub

    Private Sub Form_verfactura_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub datagrid_detalleProds_CellClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub TEXTBOX_BUSCAR_PROV_KeyDown(sender As Object, e As KeyEventArgs) Handles TEXTBOX_BUSCAR_PROV.KeyDown
        If e.KeyCode = "13" Then


            ''LLENADO COMBO  contactos
            Try
                If IsNumeric(TEXTBOX_BUSCAR_PROV.Text) = True Then sql = "SELECT documento, nombre FROM proveedores WHERE documento='" & TEXTBOX_BUSCAR_PROV.Text & "'"
                If IsNumeric(TEXTBOX_BUSCAR_PROV.Text) = False = True Then sql = "SELECT documento, nombre FROM proveedores WHERE nombre like '%" & TEXTBOX_BUSCAR_PROV.Text & "%'"

                da_contact_fitro_facver = New MySqlDataAdapter(sql, conex)
                dT_contact_fitro_facver = New DataTable
                da_contact_fitro_facver.Fill(dT_contact_fitro_facver)
                Me.COMBO_NOM_CLIENTE_FILTRO.DataSource = dT_contact_fitro_facver.DefaultView
                Me.COMBO_NOM_CLIENTE_FILTRO.DisplayMember = "nombre"
                Me.COMBO_NOM_CLIENTE_FILTRO.ValueMember = "documento"
                Me.COMBO_NOM_CLIENTE_FILTRO.AutoCompleteSource = AutoCompleteSource.ListItems
                Me.COMBO_NOM_CLIENTE_FILTRO.AutoCompleteMode = AutoCompleteMode.Suggest
                Me.COMBO_NOM_CLIENTE_FILTRO.SelectedItem = Nothing
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da_contact_fitro_facver.Dispose()
            dT_contact_fitro_facver.Dispose()
            conex.Close()



            COMBO_NOM_CLIENTE_FILTRO.Focus()

            COMBO_NOM_CLIENTE_FILTRO.DroppedDown = True

            Cursor.Current = Cursors.Default
        End If

    End Sub

    Private Sub COMBO_NOM_CLIENTE_FILTRO_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles COMBO_NOM_CLIENTE_FILTRO.SelectionChangeCommitted

        Try
            sql = "SELECT * FROM PROVEEDORES where DOCUMENTO='" & CStr(COMBO_NOM_CLIENTE_FILTRO.SelectedValue) & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt_clientes = New DataTable
            da.Fill(dt_clientes)
            For Each row As DataRow In dt_clientes.Rows
                cli_doc = row.Item("DOCUMENTO")
                cli_nom = row.Item("nombre")
                cli_tel = row.Item("TELEFONO")
                cli_dir = row.Item("DIRECCION")
                cli_mail = row.Item("email")

                Me.TXT_DOC_CLIENTE.Text = row.Item("DOCUMENTO")
                Me.TXT_NOM_CLIENTE.Text = row.Item("nombre")
                Me.TXT_TELS_CLIENTE.Text = row.Item("TELEFONO")
                Me.TXT_DIR_CLIENTE.Text = row.Item("DIRECCION")
                Me.txt_mail_cliente.Text = row.Item("email")

                Button_elim_cliente.Visible = True
            Next
        Catch ex As Exception

        End Try
        dt_clientes.Dispose()
        conex.Close()


        TEXTBOX_BUSCAR_PROV.Text = ""



        sql = "UPDATE ventas SET doccliente='" & cli_doc & "', clientenom='" & cli_nom & "' WHERE DOCUMENTO=" & CInt(Label_consecutivo.Text) & ""
        da = New MySqlDataAdapter(sql, conex)
        dt = New DataTable
        Try
            da.Fill(dt)
            'MsgBox("Tarifa Actualizada.   :).", vbInformation)
        Catch ex As Exception
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()



    End Sub

    Private Sub TXT_DOC_CLIENTE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_DOC_CLIENTE.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub TXT_NOM_CLIENTE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_NOM_CLIENTE.KeyPress
        e.KeyChar = ""

    End Sub

    Private Sub TXT_TELS_CLIENTE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_TELS_CLIENTE.KeyPress
        e.KeyChar = ""

    End Sub

    Private Sub TXT_DIR_CLIENTE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_DIR_CLIENTE.KeyPress
        e.KeyChar = ""

    End Sub

    Private Sub txt_mail_cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_mail_cliente.KeyPress
        e.KeyChar = ""

    End Sub
End Class