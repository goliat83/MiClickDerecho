Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.draw

Public Class form_Cartera
    Dim QUE_HACE_CARTERA As String
    Dim QUE_HACE_CREDITO As String

    Dim QUE_HACE_CLIENTE As String
    Dim COD_CARTERA As String = ""
    Dim filtroXcliente As Boolean = False

    Dim cli_nom, cli_tel, cli_dir, cli_doc, cli_mail As String

    Public da_contact_fitro As New MySqlDataAdapter
    Public dT_contact_fitro As New DataTable

    Public da_contact As New MySqlDataAdapter
    Public dT_contact As New DataTable

    Dim PROD_SALDO, PROD_ENTRAN, PROD_SALEN As Integer
    Dim entran, salen, saldo As Integer
    Dim NroFacRef As String

    Dim cuenta_puc() As String

    Private Sub CreditoyCartera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataGrid_cartera.BringToFront()

    End Sub

    Private Sub Btn_nuevo_cartera_Click(sender As Object, e As EventArgs) Handles Btn_nuevo_cartera.Click



        QUE_HACE_CARTERA = "CREAR"

        dataGrid_cartera.Visible = False
        Panel_botones.Visible = False
        'Label_panel_total_cartera.Visible = False
        'Panel_total_cartera.Visible = False
        ComboBox_ClientesfiltroLista.Visible = False
        CheckBoxFiltroPeriodo.Visible = False
        CheckBox_filtroCliente.Visible = False
        CheckBox_FiltroPagadas.Visible = False
        Button_buscar.Visible = False
        TextBox_nro_fac_cartera.Text = ""

        Button_ver_buscar_fac_cartera.Enabled = False
        Button_exportar_cartera.Visible = False
        Button_anular.Visible = False
        Button_guardar_cartera.Enabled = True
        Button_guardar_cartera.Visible = True
        ComboBoxPeriodoFiltro.Visible = False
        TextBox_concepto_cartera.Enabled = True
        NumericUpDown_anno.Visible = False
        CheckBoxAnno.Visible = False

        'CONSECUTIVO
        consecutivo = 0
        cmd.Connection = conex
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select MAX(CAST(CONSECUTIVO AS SIGNED))+1 from carteracredito WHERE TIPO='CARTERA'"
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
        TextBox_nro_cuenta_cartera.Text = consecutivo


        DateTimePicker_fecha_cartera.Value = DateTime.Now
        'TextBox_fecha_cartera.Text = DateTimePicker_fecha_cartera.Value.ToShortDateString
        TextBox_estado_cartera.Text = "NUEVO"
        TextBox_valor_cuenta_cartera.Text = 0
        TextBox_saldo_cartera.Text = 0
        TextBox_concepto_cartera.Text = ""
        datagrid_historial_cartera.DataSource = Nothing
        Panel_bonotes2.Visible = True

        TextBox_vencimiento_cartera.Text = ""
        Label_empleado_cartera.Text = usrnom


    End Sub

    Private Sub Button_ver_cartera_Click(sender As Object, e As EventArgs) Handles Button_ver_cartera.Click

        If COD_CARTERA = "" Then
            Exit Sub

        End If


        QUE_HACE_CARTERA = "VER"


        dataGrid_cartera.Visible = False
        Panel_botones.Visible = False
        Panel_bonotes2.Visible = True
        Panel_total_cartera.Visible = False
        Label_panel_total_cartera.Visible = False


        Button_guardar_cartera.Visible = False
        Button_exportar_cartera.Visible = True
        Button_anular.Visible = True
        Button_ver_buscar_fac_cartera.Enabled = True

        TextBox_concepto_cartera.Enabled = False
        DateTimePicker_fecha_cartera.Enabled = False
        ComboBoxPeriodoFiltro.Visible = False

        COMBO_NOM_CLIENTE_FILTRO.Visible = False
        TEXTBOX_BUSCAR_CLI.Visible = False

        CheckBoxFiltroPeriodo.Visible = False
        NumericUpDown_anno.Visible = False
        CheckBoxAnno.Visible = False
        ComboBox_ClientesfiltroLista.Visible = False
        CheckBox_filtroCliente.Visible = False
        CheckBox_FiltroPagadas.Visible = False
        Button_buscar.Visible = False


        GRID_cartera_detalle()

        Timer_clientes.Enabled = True



    End Sub

    Private Sub Button_exportar_Click(sender As Object, e As EventArgs) Handles Button_exportar.Click


    End Sub



    Private Sub TextBox_saldo_cartera_TextChanged(sender As Object, e As EventArgs) Handles TextBox_saldo_cartera.TextChanged

    End Sub

    Private Sub DateTimePicker_fecha_cartera_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker_fecha_cartera.ValueChanged
        TextBox_fecha_cartera.Text = DateTimePicker_fecha_cartera.Value.ToShortDateString

        DateTimePicker_vence_cartera.MinDate = DateTimePicker_fecha_cartera.Value

    End Sub

    Private Sub DateTimePicker_vence_cartera_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker_vence_cartera.ValueChanged
        TextBox_vencimiento_cartera.Text = DateTimePicker_vence_cartera.Value.ToShortDateString




        If QUE_HACE_CARTERA = "VER" Then

            sql = "update carteracredito set
        `vencimiento`='" & cli_doc & "' 
        where cons=" & TextBox_nro_cuenta_cartera.Text & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                MsgBox("error actualizando el vencimiento de la cuenta, puede informar al proveedor del software en opciones de soporte. " + vbNewLine + vbNewLine + ex.ToString, vbInformation)
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()

        End If

    End Sub

    Private Sub CreditoyCartera_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ''LLENADO contactos
        'Try
        '    sql = "SELECT documento, nombre FROM proveedores"
        '    da_cli_cartera = New MySqlDataAdapter(sql, conex)
        '    dt_cli_cartera = New DataTable
        '    da_cli_cartera.Fill(dt_cli_cartera)
        '    Me.COMBO_NOM_CLIENTE_FILTRO.DataSource = dt_cli_cartera.DefaultView
        '    Me.COMBO_NOM_CLIENTE_FILTRO.DisplayMember = "nombre"
        '    Me.COMBO_NOM_CLIENTE_FILTRO.ValueMember = "documento"
        '    Me.COMBO_NOM_CLIENTE_FILTRO.AutoCompleteSource = AutoCompleteSource.ListItems
        '    Me.COMBO_NOM_CLIENTE_FILTRO.AutoCompleteMode = AutoCompleteMode.Suggest
        '    Me.COMBO_NOM_CLIENTE_FILTRO.SelectedItem = Nothing



        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'conex.Close()
        'da_cli_cartera.Dispose()
        'dt_cli_cartera.Dispose()
        'conex.Close()

        'GRID_cartera()
        Dim cxc As String = 0
        Dim recaudo As String = 0
        Dim saldo As String = 0

        Try
            sql = "SELECT   
SUM((SELECT IFNULL(SUM(VALOR),0) FROM RECIBOS_CAJA WHERE recibos_caja.referencia=carteracredito.CONSECUTIVO AND recibos_caja.Concepto='Cuenta Por Cobrar')-carteracredito.VALOR) AS valor
FROM carteracredito where carteracredito.tipo='CARTERA'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)



            For Each row As DataRow In dt.Rows
                Label_TOTAL_cartera.Text = CInt(row.Item("valor"))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()






    End Sub

    Private Sub Timer_clientes_Tick(sender As Object, e As EventArgs) Handles Timer_clientes.Tick

        Timer_clientes.Enabled = False
        cli_dir = ""
        cli_tel = ""
        cli_mail = ""
        cli_nom = ""
        If cli_doc = "" Then Exit Sub
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
                imp_clienteNom = cli_nom
                imp_clienteTel = cli_tel
                ImpClienteDir = cli_dir
                imp_clientemail = cli_mail
            Next

            Me.TXT_DIR_CLIENTE.Text = cli_dir
            Me.TXT_TELS_CLIENTE.Text = cli_tel
            Me.TxtMAIL_cliente.Text = cli_mail
            Me.TXT_DOC_CLIENTE.Text = cli_doc
            Me.TXT_NOM_CLIENTE.Text = cli_nom

        Catch ex As Exception
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()

        COMBO_NOM_CLIENTE_FILTRO.Text = ""




        TEXTBOX_BUSCAR_CLI.Text = ""


    End Sub



    Private Sub TextBox_valor_cuenta_cartera_TextChanged(sender As Object, e As EventArgs) Handles TextBox_valor_cuenta_cartera.TextChanged
        If TextBox_valor_cuenta_cartera.Text = "" Then
            TextBox_valor_cuenta_cartera.Text = 0
        End If
    End Sub



    Private Sub TXT_DOC_CLIENTE_TextChanged(sender As Object, e As EventArgs) Handles TXT_DOC_CLIENTE.TextChanged

    End Sub

    Private Sub COMBO_NOM_CLIENTE_FILTRO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMBO_NOM_CLIENTE_FILTRO.SelectedIndexChanged

    End Sub









    Private Sub Button_guardar_cartera_Click(sender As Object, e As EventArgs) Handles Button_guardar_cartera.Click
        If TextBox_valor_cuenta_cartera.Text = 0 Or TextBox_valor_cuenta_cartera.Text = "" Then
            MsgBox("La cuenta de debe tener un valor.", vbInformation)
            Exit Sub
        End If

        If TXT_DOC_CLIENTE.Text = "" Then
            MsgBox("La cuenta de debe tener un deudor (cliente).", vbInformation)
            Exit Sub
        End If

        If TextBox_vencimiento_cartera.Text = "" Then
            MsgBox("seleccione una fecha de vencimiento.", vbInformation)
            Exit Sub
        End If

        'CONSECUTIVO
        consecutivo = 0
        cmd.Connection = conex
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select MAX(CAST(CONSECUTIVO AS SIGNED))+1 from carteracredito WHERE TIPO='CARTERA'"
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
        TextBox_nro_cuenta_cartera.Text = consecutivo




        Dim TIPO_DOCUMENTO As String = "FACTURA DE VENTA"
        If TextBox_nro_fac_cartera.Text = "" Then TIPO_DOCUMENTO = "" : TextBox_nro_fac_cartera.Text = "0"

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
        VALUES(" & CLng(consecutivo) & ",'CARTERA','" & TextBox_fecha_cartera.Text & "','" & CStr(TXT_DOC_CLIENTE.Text) & "','" & CStr(TXT_NOM_CLIENTE.Text) & "','FACTURA DE VENTA','" & TextBox_nro_fac_cartera.Text & "','" & TextBox_concepto_cartera.Text & "','" & TextBox_valor_cuenta_cartera.Text & "','" & TextBox_saldo_cartera.Text & "','" & TextBox_vencimiento_cartera.Text & "','" & Label_empleado_cartera.Text & "','PENDIENTE')"
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





        MsgBox("Se Creó una nueva cuenta por cobrar.", vbInformation)

        Button_regresar_cartera_Click(Nothing, Nothing)
        GRID_cartera()

    End Sub

    Private Sub COMBO_NOM_CLIENTE_FILTRO_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles COMBO_NOM_CLIENTE_FILTRO.SelectionChangeCommitted

        If COMBO_NOM_CLIENTE_FILTRO.Text = Nothing Then Exit Sub

        cli_nom = COMBO_NOM_CLIENTE_FILTRO.SelectedItem.ToString
        cli_doc = COMBO_NOM_CLIENTE_FILTRO.SelectedValue.ToString



        Timer_clientes.Enabled = True
        Button_BuscarCliente.Visible = False






    End Sub

    Private Sub TextBox_saldo_cartera_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_saldo_cartera.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub TXT_NOM_CLIENTE_TextChanged(sender As Object, e As EventArgs) Handles TXT_NOM_CLIENTE.TextChanged

    End Sub

    Private Sub TextBox_valor_cuenta_cartera_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_valor_cuenta_cartera.KeyPress
        If QUE_HACE_CARTERA = "VER" Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TXT_TELS_CLIENTE_TextChanged(sender As Object, e As EventArgs) Handles TXT_TELS_CLIENTE.TextChanged

    End Sub

    Private Sub TXT_DOC_CLIENTE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_DOC_CLIENTE.KeyPress

        e.KeyChar = ""
    End Sub

    Private Sub TXT_DIR_CLIENTE_TextChanged(sender As Object, e As EventArgs) Handles TXT_DIR_CLIENTE.TextChanged

    End Sub

    Private Sub TXT_DOC_CLIENTE_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_DOC_CLIENTE.KeyDown

    End Sub

    Private Sub TxtMAIL_cliente_TextChanged(sender As Object, e As EventArgs) Handles TxtMAIL_cliente.TextChanged

    End Sub

    Private Sub TextBox_valor_cuenta_cartera_LostFocus(sender As Object, e As EventArgs) Handles TextBox_valor_cuenta_cartera.LostFocus
        If QUE_HACE_CARTERA = "CREAR" Then
            TextBox_saldo_cartera.Text = TextBox_valor_cuenta_cartera.Text
        End If

    End Sub

    Private Sub TextBox_nro_cuenta_cartera_TextChanged(sender As Object, e As EventArgs) Handles TextBox_nro_cuenta_cartera.TextChanged

    End Sub

    Private Sub TXT_NOM_CLIENTE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_NOM_CLIENTE.KeyPress

        e.KeyChar = ""
    End Sub

    Private Sub TextBox_estado_cartera_TextChanged(sender As Object, e As EventArgs) Handles TextBox_estado_cartera.TextChanged

    End Sub

    Private Sub TXT_TELS_CLIENTE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_TELS_CLIENTE.KeyPress


        e.KeyChar = ""
    End Sub

    Private Sub TextBox_nro_fac_cartera_TextChanged(sender As Object, e As EventArgs) Handles TextBox_nro_fac_cartera.TextChanged

    End Sub

    Private Sub Button_regresar_cartera_Click(sender As Object, e As EventArgs) Handles Button_regresar_cartera.Click
        CheckBox_FiltroPagadas.Visible = True
        Button_buscar.Visible = True


        Panel_bonotes2.Visible = False
        Panel_botones.Visible = True
        'Panel_total_cartera.Visible = True
        'Label_panel_total_cartera.Visible = True

        dataGrid_cartera.Visible = True

        ComboBox_ClientesfiltroLista.Visible = True
        CheckBox_filtroCliente.Visible = True
        CheckBox_FiltroPagadas.Visible = True
        CheckBoxFiltroPeriodo.Visible = True
        Button_buscar.Visible = True
        NumericUpDown_anno.Visible = True
        CheckBoxAnno.Visible = True
        COD_CARTERA = ""
        TextBox_nro_cuenta_cartera.Text = ""
        TextBox_estado_cartera.Text = ""
        TextBox_abonos_cartera.Text = "0"
        NroFacRef = ""
        TXT_NOM_CLIENTE.Text = ""
        TXT_DOC_CLIENTE.Text = ""
        TXT_TELS_CLIENTE.Text = ""
        TXT_DIR_CLIENTE.Text = ""

        ComboBoxPeriodoFiltro.Visible = True

        datagrid_historial_cartera.DataSource = Nothing

        GRID_cartera()
        dataGrid_cartera.ClearSelection()

    End Sub



    Private Sub TXT_DIR_CLIENTE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_DIR_CLIENTE.KeyPress


        e.KeyChar = ""
    End Sub



    Private Sub TxtMAIL_cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMAIL_cliente.KeyPress


        e.KeyChar = ""
    End Sub



    Private Sub dataGrid_cartera_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGrid_cartera.CellContentClick

    End Sub



    Private Sub TextBox_nro_cuenta_cartera_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_nro_cuenta_cartera.KeyPress
        e.KeyChar = ""
    End Sub



    Private Sub Button_ver_buscar_fac_cartera_Click(sender As Object, e As EventArgs) Handles Button_ver_buscar_fac_cartera.Click

        If NroFacRef <> TextBox_nro_fac_cartera.Text Then
            'hacer aqui que actualice la factura q esta vinvulada


        End If





        ID_VENTA_VER = TextBox_nro_fac_cartera.Text

        If ID_VENTA_VER <> "" Then
            Form_verfactura.Show()

        End If

    End Sub



    Private Sub Button_exportar_cartera_Click(sender As Object, e As EventArgs) Handles Button_exportar_cartera.Click
        Try
            sql = "SELECT Documento, Fecha, Valor, Empleado from recibos_caja where REFERENCIA='" & TextBox_nro_cuenta_cartera.Text & "' and estado='DESCARGADO'"
            da_cartera_DETALLE = New MySqlDataAdapter(sql, conex)
            dt_cartera_DETALLE = New DataTable
            da_cartera_DETALLE.Fill(dt_cartera_DETALLE)
            Me.datagrid_historial_cartera.DataSource = dt_cartera_DETALLE
        Catch ex As Exception
            MsgBox(ex.Message)
            conex.Close()
            da_cartera_DETALLE.Dispose()
            dt_cartera_DETALLE.Dispose()
        End Try
        conex.Close()
        da_cartera_DETALLE.Dispose()
        dt_cartera_DETALLE.Dispose()
        datagrid_historial_cartera.ClearSelection()




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
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\Cuenta Por Cobrar" & TextBox_nro_cuenta_cartera.Text & ".pdf"
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
        Dim datatable As New PdfPTable(datagrid_historial_cartera.ColumnCount)
        'Se asignan algunas propiedades para el diseño del PDF.
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(datagrid_historial_cartera)

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
        Dim PDF_CONSECUTIVO As New Paragraph("No. " & TextBox_nro_cuenta_cartera.Text + "   ", New Font(Font.Name = "Arial Black", 9, Font.Bold = True)) : PDF_CONSECUTIVO.Alignment = 2
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
        For i As Integer = 0 To datagrid_historial_cartera.ColumnCount - 1
            Dim HEADERCELLFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 8, iTextSharp.text.Font.BOLD)

            Dim cell_TITLE As New PdfPCell
            cell_TITLE.Phrase = New Phrase(datagrid_historial_cartera.Columns(i).HeaderText, HEADERCELLFont)
            cell_TITLE.HorizontalAlignment = Element.ALIGN_CENTER
            cell_TITLE.BackgroundColor = BaseColor.LIGHT_GRAY
            datatable.AddCell(cell_TITLE)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 0
        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To datagrid_historial_cartera.RowCount - 1
            For j As Integer = 0 To datagrid_historial_cartera.ColumnCount - 1
                Dim cell As New PdfPCell

                cell.Phrase = New Phrase(datagrid_historial_cartera(j, i).FormattedValue.ToString, rowFont)

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
        CANT_FILAS = Me.datagrid_historial_cartera.RowCount

        If CANT_FILAS <= (16 - CANT_FILAS) Then
            For i As Integer = 0 To (16 - CANT_FILAS)
                For j As Integer = 0 To datagrid_historial_cartera.ColumnCount - 1

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
        cell_PIE.Phrase = New Phrase(TextBox_valor_cuenta_cartera.Text & " ", totalFont)
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
        cell_PIE.Phrase = New Phrase(TextBox_valor_cuenta_cartera.Text, totaltotalFont)
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

    Private Sub MetroTabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button_anular_Click(sender As Object, e As EventArgs) Handles Button_anular.Click
        Select Case MessageBox.Show("Confirma la anular ésta Cuenta por Cobrar?" & vbNewLine & "los pagos realizados anteriormente a esta cuenta no se afectan, si lo requiere estos deben anularse desde recibos de caja.", "Anular CxC.", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            Case DialogResult.Yes

                sql = "dELETE from CARTERACREDITO WHERE consecutivo=" & CInt(Me.TextBox_nro_cuenta_cartera.Text) & " and tipo='CARTERA'"
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                Try
                    da.Fill(dt)
                Catch ex As Exception
                    MsgBox("error borrando")
                End Try
                da.Dispose()
                dt.Dispose()
                conex.Close()



                Me.Button_anular.Enabled = False
                Me.TextBox_estado_cartera.Text = "ANULADA"


                Me.Cursor = Cursors.Default
                MsgBox("Se anuló la Cuenta por Cobrar.")



                Button_regresar_cartera_Click(Nothing, Nothing)
                GRID_cartera()


            Case DialogResult.No


        End Select
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_filtroCliente.CheckedChanged
        If CheckBox_filtroCliente.Checked = True Then
            Try
                sql = "SELECT documento, nombre FROM proveedores where cliente='SI' order by nombre"

                da_contact_fitro = New MySqlDataAdapter(sql, conex)
                dT_contact_fitro = New DataTable
                da_contact_fitro.Fill(dT_contact_fitro)
                Me.ComboBox_ClientesfiltroLista.DataSource = dT_contact_fitro.DefaultView
                Me.ComboBox_ClientesfiltroLista.DisplayMember = "nombre"
                Me.ComboBox_ClientesfiltroLista.ValueMember = "documento"
                Me.ComboBox_ClientesfiltroLista.AutoCompleteSource = AutoCompleteSource.ListItems
                Me.ComboBox_ClientesfiltroLista.AutoCompleteMode = AutoCompleteMode.Suggest
                Me.ComboBox_ClientesfiltroLista.SelectedItem = Nothing

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da_contact_fitro.Dispose()
            dT_contact_fitro.Dispose()
            conex.Close()
            ComboBox_ClientesfiltroLista.Enabled = True
            filtroXcliente = True
        Else
            filtroXcliente = False
            ComboBox_ClientesfiltroLista.DataSource = Nothing
            ComboBox_ClientesfiltroLista.Enabled = False
            GRID_cartera()

        End If
    End Sub

    Private Sub BunifuCards_clientes_Paint(sender As Object, e As PaintEventArgs) Handles BunifuCards_clientes.Paint

    End Sub

    Private Sub TextBox_concepto_cartera_TextChanged(sender As Object, e As EventArgs) Handles TextBox_concepto_cartera.TextChanged

    End Sub

    Private Sub Button_BuscarCliente_Click(sender As Object, e As EventArgs) Handles Button_BuscarCliente.Click
        TEXTBOX_BUSCAR_CLI.Visible = True
        COMBO_NOM_CLIENTE_FILTRO.Visible = True
        TEXTBOX_BUSCAR_CLI.Focus()
        Button_guardarCLi.Visible = True






    End Sub

    Private Sub TEXTBOX_BUSCAR_CLI_OnValueChanged(sender As Object, e As EventArgs) Handles TEXTBOX_BUSCAR_CLI.OnValueChanged

    End Sub

    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        'funcion para obtener el tamaño de la columnas del datagridview
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function

    Private Sub ComboBox_ClientesfiltroLista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_ClientesfiltroLista.SelectedIndexChanged

    End Sub

    Private Sub TextBox_estado_cartera_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_estado_cartera.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub CheckBox_FiltroPagadas_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_FiltroPagadas.CheckedChanged

    End Sub
    Private Sub CheckBox_FiltroPagadas_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBox_FiltroPagadas.CheckStateChanged

    End Sub



    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click

    End Sub

    Private Sub Label30_Click(sender As Object, e As EventArgs) Handles Label30.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub MetroComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPeriodoFiltro.SelectedIndexChanged

    End Sub



    Private Sub Panel_bonotes2_Paint(sender As Object, e As PaintEventArgs) Handles Panel_bonotes2.Paint

    End Sub

    Private Sub Button_buscar_Click(sender As Object, e As EventArgs) Handles Button_buscar.Click
        GRID_cartera()

    End Sub

    Private Sub Panel_total_cartera_Paint(sender As Object, e As PaintEventArgs) Handles Panel_total_cartera.Paint

    End Sub



    Private Sub GRID_cartera()
        Label_TOTAL_cartera.Text = 0

        Try
            'sql = "SELECT * from carteracredito where tipo='CARTERA'"
            'If filtroXcliente = True Then sql = "SELECT * from carteracredito where tipo='CARTERA' AND CLIENTEDOC='" & ComboBox_ClientesfiltroLista.SelectedValue.ToString & "'"

            sql = "SELECT carteracredito.*,  
(SELECT IFNULL(SUM(VALOR),0) FROM RECIBOS_CAJA WHERE recibos_caja.referencia=carteracredito.CONSECUTIVO AND recibos_caja.Concepto='Cuenta Por Cobrar') AS Abonos,
(SELECT IFNULL(SUM(VALOR),0) FROM RECIBOS_CAJA WHERE recibos_caja.referencia=carteracredito.CONSECUTIVO AND recibos_caja.Concepto='Cuenta Por Cobrar')-carteracredito.VALOR AS SaldoP
FROM carteracredito where carteracredito.tipo='CARTERA'"
            If filtroXcliente = True Then sql = "SELECT carteracredito.*,  
(SELECT IFNULL(SUM(VALOR),0) FROM RECIBOS_CAJA WHERE recibos_caja.referencia=carteracredito.CONSECUTIVO AND recibos_caja.Concepto='Cuenta Por Cobrar') AS Abonos,
(SELECT IFNULL(SUM(VALOR),0) FROM RECIBOS_CAJA WHERE recibos_caja.referencia=carteracredito.CONSECUTIVO AND recibos_caja.Concepto='Cuenta Por Cobrar')-carteracredito.VALOR AS SaldoP
FROM carteracredito where carteracredito.tipo='CARTERA' AND CLIENTEDOC='" & ComboBox_ClientesfiltroLista.SelectedValue.ToString & "'"
            If CheckBoxAnno.Checked = True Then sql = sql & " and year(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & NumericUpDown_anno.Value & "'"
            If CheckBoxFiltroPeriodo.Checked = True Then sql = sql & " and month(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & ComboBoxPeriodoFiltro.SelectedIndex & "'"
            If CheckBox_FiltroPagadas.Checked = True Then sql = sql & " and (SELECT IFNULL(SUM(VALOR),0) FROM RECIBOS_CAJA WHERE recibos_caja.referencia=carteracredito.CONSECUTIVO AND recibos_caja.Concepto='Cuenta Por Cobrar')-carteracredito.VALOR<>0"

            da_cartera_grid = New MySqlDataAdapter(sql, conex)
            dt_cartera_grid = New DataTable
            da_cartera_grid.Fill(dt_cartera_grid)
            Me.dataGrid_cartera.DataSource = dt_cartera_grid
            Me.dataGrid_cartera.Columns(0).Visible = False

            Me.dataGrid_cartera.Columns(1).HeaderText = "Cuenta"
            Me.dataGrid_cartera.Columns(1).Width = 60
            Me.dataGrid_cartera.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.dataGrid_cartera.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            Me.dataGrid_cartera.Columns(2).Visible = False
            Me.dataGrid_cartera.Columns(3).Visible = False
            Me.dataGrid_cartera.Columns(4).Visible = False

            Me.dataGrid_cartera.Columns(5).HeaderText = "Cliente"
            Me.dataGrid_cartera.Columns(5).Width = 150
            Me.dataGrid_cartera.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.dataGrid_cartera.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            Me.dataGrid_cartera.Columns(6).Visible = False

            Me.dataGrid_cartera.Columns(7).HeaderText = "Factura"
            Me.dataGrid_cartera.Columns(7).Width = 60
            Me.dataGrid_cartera.Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.dataGrid_cartera.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            Me.dataGrid_cartera.Columns(8).Visible = False

            Me.dataGrid_cartera.Columns(9).HeaderText = "Valor"
            Me.dataGrid_cartera.Columns(9).Width = 80
            Me.dataGrid_cartera.Columns(9).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.dataGrid_cartera.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            Me.dataGrid_cartera.Columns(10).Visible = False
            Me.dataGrid_cartera.Columns(10).HeaderText = "Saldo"
            Me.dataGrid_cartera.Columns(10).Width = 80
            Me.dataGrid_cartera.Columns(10).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.dataGrid_cartera.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            Me.dataGrid_cartera.Columns(11).HeaderText = "Vencimiento"
            Me.dataGrid_cartera.Columns(11).Width = 80
            Me.dataGrid_cartera.Columns(11).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.dataGrid_cartera.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            Me.dataGrid_cartera.Columns(12).Visible = False
            Me.dataGrid_cartera.Columns(12).HeaderText = "Responsable"
            Me.dataGrid_cartera.Columns(12).Width = 150
            Me.dataGrid_cartera.Columns(12).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.dataGrid_cartera.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            Me.dataGrid_cartera.Columns(13).Visible = False
            Me.dataGrid_cartera.Columns(13).HeaderText = "Estado"
            Me.dataGrid_cartera.Columns(13).Width = 100
            Me.dataGrid_cartera.Columns(13).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.dataGrid_cartera.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            Me.dataGrid_cartera.Columns(14).HeaderText = "Abonos"
            Me.dataGrid_cartera.Columns(14).Width = 100
            Me.dataGrid_cartera.Columns(14).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.dataGrid_cartera.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            Me.dataGrid_cartera.Columns(15).HeaderText = "Saldo"
            Me.dataGrid_cartera.Columns(15).Width = 100
            Me.dataGrid_cartera.Columns(15).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.dataGrid_cartera.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Catch ex As Exception
            MsgBox("Ocurrio un error mientras se cargaba el listado", vbExclamation)
            conex.Close()
            da_cartera_grid.Dispose()
        End Try
        conex.Close()
        da_cartera_grid.Dispose()
        dt_cartera_grid.Dispose()

        dataGrid_cartera.ClearSelection()

        For i As Integer = 0 To dataGrid_cartera.RowCount - 1
            If dataGrid_cartera.Item("ESTADO", i).Value = "PENDIENTE" Then
                Label_TOTAL_cartera.Text = CInt(Label_TOTAL_cartera.Text) + dataGrid_cartera.Item("SALDOp", i).Value

            End If
        Next
    End Sub

    Private Sub CheckBoxFiltroPeriodo_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxFiltroPeriodo.CheckedChanged
        If CheckBoxFiltroPeriodo.Checked = True Then ComboBoxPeriodoFiltro.Enabled = True : Exit Sub
        If CheckBoxFiltroPeriodo.Checked = False Then ComboBoxPeriodoFiltro.Enabled = False : Exit Sub

    End Sub


    Private Sub Button_guardarCLi_Click(sender As Object, e As EventArgs) Handles Button_guardarCLi.Click

        ' actualizo el cliente en la cuenta x cobrar
        sql = "update carteracredito set
        `ClienteDoc`='" & cli_doc & "',
        `ClienteNom`='" & cli_nom & "' 
        where consecutivo=" & TextBox_nro_cuenta_cartera.Text & ""
        da = New MySqlDataAdapter(sql, conex)
        dt = New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            MsgBox("error actualizando el tercero en la cuenta, puede informar al proveedor del software si el error persiste. " + vbNewLine + vbNewLine + ex.ToString, vbInformation)
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()


        Button_guardarCLi.Visible = False
        Button_BuscarCliente.Visible = True

    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox_abonos_cartera.TextChanged

    End Sub

    Private Sub GRID_cartera_detalle()
        TextBox_abonos_cartera.Text = 0
        TextBox_saldo_cartera.Text = 0

        Try
            sql = "SELECT * from recibos_caja where REFERENCIA='" & TextBox_nro_cuenta_cartera.Text & "' and concepto='Cuenta Por Cobrar' and estado='DESCARGADO'"
            da_cartera_DETALLE = New MySqlDataAdapter(sql, conex)
            dt_cartera_DETALLE = New DataTable
            da_cartera_DETALLE.Fill(dt_cartera_DETALLE)
            Me.datagrid_historial_cartera.DataSource = dt_cartera_DETALLE
            Me.datagrid_historial_cartera.Columns(0).Visible = False

            Me.datagrid_historial_cartera.Columns(1).HeaderText = "Comprobante"
            Me.datagrid_historial_cartera.Columns(1).Width = 60
            Me.datagrid_historial_cartera.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.datagrid_historial_cartera.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            Me.datagrid_historial_cartera.Columns(2).HeaderText = "Fecha"
            Me.datagrid_historial_cartera.Columns(2).Width = 80
            Me.datagrid_historial_cartera.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.datagrid_historial_cartera.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            Me.datagrid_historial_cartera.Columns(3).Visible = False
            Me.datagrid_historial_cartera.Columns(4).Visible = False
            Me.datagrid_historial_cartera.Columns(5).Visible = False
            Me.datagrid_historial_cartera.Columns(6).Visible = False
            Me.datagrid_historial_cartera.Columns(7).Visible = False
            Me.datagrid_historial_cartera.Columns(8).Visible = False
            Me.datagrid_historial_cartera.Columns(9).Visible = False


            Me.datagrid_historial_cartera.Columns(10).HeaderText = "Valor"
            Me.datagrid_historial_cartera.Columns(10).Width = 100
            Me.datagrid_historial_cartera.Columns(10).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.datagrid_historial_cartera.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            Me.datagrid_historial_cartera.Columns(11).Visible = False

            Me.datagrid_historial_cartera.Columns(12).HeaderText = "Responsable"
            Me.datagrid_historial_cartera.Columns(12).Width = 150
            Me.datagrid_historial_cartera.Columns(12).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.datagrid_historial_cartera.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            Me.datagrid_historial_cartera.Columns(13).Visible = False
            Me.datagrid_historial_cartera.Columns(14).Visible = False
            Me.datagrid_historial_cartera.Columns(15).Visible = False
            Me.datagrid_historial_cartera.Columns(16).Visible = False
            Me.datagrid_historial_cartera.Columns(17).Visible = False
            Me.datagrid_historial_cartera.Columns(18).Visible = False
            Me.datagrid_historial_cartera.Columns(19).Visible = False
            Me.datagrid_historial_cartera.Columns(20).Visible = False
            Me.datagrid_historial_cartera.Columns(21).Visible = False
            Me.datagrid_historial_cartera.Columns(22).Visible = False
            Me.datagrid_historial_cartera.Columns(23).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
            conex.Close()
            da_cartera_DETALLE.Dispose()
            dt_cartera_DETALLE.Dispose()
        End Try
        For i As Integer = 0 To datagrid_historial_cartera.RowCount - 1
            TextBox_abonos_cartera.Text = CInt(TextBox_abonos_cartera.Text) + datagrid_historial_cartera.Item("VALOR", i).Value
        Next

        TextBox_saldo_cartera.Text = CInt(TextBox_valor_cuenta_cartera.Text) - CInt(TextBox_abonos_cartera.Text)
        If CInt(TextBox_saldo_cartera.Text) < 0 Then TextBox_saldo_cartera.Text = 0


        conex.Close()
        da_cartera_DETALLE.Dispose()
        dt_cartera_DETALLE.Dispose()

        datagrid_historial_cartera.ClearSelection()

    End Sub



    Private Sub dataGrid_cartera_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGrid_cartera.CellClick

        If dataGrid_cartera.CurrentRow Is Nothing Then
            Exit Sub
        End If

        Dim row As DataGridViewRow = dataGrid_cartera.CurrentRow
        COD_CARTERA = row.Cells("cons").Value

        TextBox_nro_cuenta_cartera.Text = CStr(row.Cells("CONSECUTIVO").Value)
        TextBox_fecha_cartera.Text = CStr(row.Cells("FECHA").Value)

        TextBox_nro_fac_cartera.Text = CStr(row.Cells("DOCUMENTO").Value)
        NroFacRef = CStr(row.Cells("DOCUMENTO").Value)


        If CStr(row.Cells("DOCUMENTO").Value) = "" Then
            Label1.Visible = False
            TextBox_nro_fac_cartera.Visible = False
            Button_ver_buscar_fac_cartera.Visible = False
        Else
            Label1.Visible = True
            TextBox_nro_fac_cartera.Visible = True
            Button_ver_buscar_fac_cartera.Visible = True
        End If

        Label_empleado_cartera.Text = CStr(row.Cells("responsable").Value)

        TextBox_vencimiento_cartera.Text = CStr(row.Cells("VENCIMIENTO").Value)
        TextBox_concepto_cartera.Text = CStr(row.Cells("CONCEPTO").Value)
        TextBox_valor_cuenta_cartera.Text = CStr(row.Cells("VALOR").Value)
        'TextBox_saldo_cartera.Text = CStr(row.Cells("SALDO").Value)

        cli_doc = CStr(row.Cells("CLIENTEDOC").Value)

        TextBox_estado_cartera.Text = CStr(row.Cells("estado").Value)


        'CONTINUAR

    End Sub

    Private Sub dataGrid_cartera_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dataGrid_cartera.CellBeginEdit

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_abonos_cartera.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub TEXTBOX_BUSCAR_CLI_KeyDown(sender As Object, e As KeyEventArgs) Handles TEXTBOX_BUSCAR_CLI.KeyDown
        If e.KeyCode = "13" Then


            ''LLENADO COMBO  contactos
            Try
                If IsNumeric(TEXTBOX_BUSCAR_CLI.Text) = True Then sql = "SELECT documento, nombre FROM proveedores WHERE documento='" & TEXTBOX_BUSCAR_CLI.Text & "'"
                If IsNumeric(TEXTBOX_BUSCAR_CLI.Text) = False = True Then sql = "SELECT documento, nombre FROM proveedores WHERE nombre like '%" & TEXTBOX_BUSCAR_CLI.Text & "%'"

                da_contact = New MySqlDataAdapter(sql, conex)
                dT_contact = New DataTable
                da_contact.Fill(dT_contact)
                Me.COMBO_NOM_CLIENTE_FILTRO.DataSource = dT_contact.DefaultView
                Me.COMBO_NOM_CLIENTE_FILTRO.DisplayMember = "nombre"
                Me.COMBO_NOM_CLIENTE_FILTRO.ValueMember = "documento"
                Me.COMBO_NOM_CLIENTE_FILTRO.AutoCompleteSource = AutoCompleteSource.ListItems
                Me.COMBO_NOM_CLIENTE_FILTRO.AutoCompleteMode = AutoCompleteMode.Suggest
                Me.COMBO_NOM_CLIENTE_FILTRO.SelectedItem = Nothing


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da_contact.Dispose()
            dT_contact.Dispose()
            conex.Close()


            COMBO_NOM_CLIENTE_FILTRO.Focus()

            COMBO_NOM_CLIENTE_FILTRO.DroppedDown = True

            Cursor.Current = Cursors.Default
        End If
    End Sub

    Private Sub ComboBox_ClientesfiltroLista_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_ClientesfiltroLista.SelectionChangeCommitted

    End Sub


End Class