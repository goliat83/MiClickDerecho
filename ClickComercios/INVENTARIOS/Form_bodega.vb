Imports MySql.Data.MySqlClient
Imports System.IO
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.Globalization
Imports Microsoft.Office.Interop

Public Class Form_bodega
    Dim STOCK As Integer
    Dim SALDO_DEL_PRODUCTO As Integer = 0
    Dim entran, salen, saldo As Integer

    Dim alto_pag As Integer
    Dim mes_num As Integer
    Dim mes_num_text As String

    Dim mousex As Integer = 0
    Dim mousey As Integer = 0
    Dim mouseDown1 As Boolean = False

    Public da_bod_saldos As New MySqlDataAdapter
    Public dt_bod_saldos As New DataTable

    Public da_pdf_bodega_pos As New MySqlDataAdapter
    Public dt_pdf_bodega_pos As New DataTable

    Public da_combo_docs_bodega As New MySqlDataAdapter
    Public dt_combo_docs_bodega As New DataTable



    Private Sub Panel_titlebar_MouseDown(sender As Object, e As MouseEventArgs) 
        mouseDown1 = True

    End Sub

    Private Sub Panel_titlebar_MouseMove(sender As Object, e As MouseEventArgs) 
        If mouseDown1 = True Then
            mousex = MousePosition.X - 405
            mousey = MousePosition.Y - 40
            Me.SetDesktopLocation(mousex, mousey)
        End If

    End Sub

    Private Sub Panel_titlebar_MouseUp(sender As Object, e As MouseEventArgs) 
        mouseDown1 = False

    End Sub

    Private Sub Button_cerrar_Click(sender As Object, e As EventArgs) 
        Me.Close()
    End Sub
    Private Sub ComboBoxProds_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBoxProds.SelectionChangeCommitted


    End Sub

    Private Sub Form_bodega_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'EffectOut("Form_bodega")

    End Sub

    Private Sub Form_bodega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NumericUpDown_anno.Value = DateTime.Now.Year



        'If comex_fondo = "AZUL" Then
        '    Me.BackColor = Color.FromArgb(164, 187, 212)
        '    RadioButton_faltantes.ForeColor = Color.Black
        '    RadioButton_entradaysalidas.ForeColor = Color.Black
        '    RadioButton_faltantes.ForeColor = Color.Black
        '    RadioButton_saldos.ForeColor = Color.Black
        '    Label19.ForeColor = Color.Black
        '    Label4.ForeColor = Color.Black
        '    CheckBox_tipodoc.ForeColor = Color.Black
        '    CheckBox_buscar_prod.ForeColor = Color.Black
        '    Label5.ForeColor = Color.Black
        '    Label1.ForeColor = Color.Black
        '    Label3.ForeColor = Color.Black
        '    Label2.ForeColor = Color.Black
        'End If




        'If comex_fondo = "NEGRO" Then
        '    'Me.BackColor = Color.FromArgb(28, 28, 28)
        '    'RadioButton_faltantes.ForeColor = Color.White
        '    'RadioButton_entradaysalidas.ForeColor = Color.White
        '    'RadioButton_faltantes.ForeColor = Color.White
        '    'RadioButton_saldos.ForeColor = Color.White
        '    'Label19.ForeColor = Color.White
        '    'Label4.ForeColor = Color.White
        '    'CheckBox_tipodoc.ForeColor = Color.White
        '    'CheckBox_buscar_prod.ForeColor = Color.White
        '    'Label5.ForeColor = Color.White
        '    'Label1.ForeColor = Color.White
        '    'Label3.ForeColor = Color.White
        '    'Label2.ForeColor = Color.White
        'End If

    End Sub
    Private Sub llena_combo_bodegas()
        Try
            sql = "SELECT cons, nombrebodega FROM bodegas"
            da_bod_saldos = New MySqlDataAdapter(sql, conex)
            dt_bod_saldos = New DataTable
            da_bod_saldos.Fill(dt_bod_saldos)
            Me.ComboBoxInfoBodega.DataSource = dt_bod_saldos.DefaultView
            Me.ComboBoxInfoBodega.DisplayMember = "nombrebodega"
            Me.ComboBoxInfoBodega.ValueMember = "cons"

            For Each row As DataRow In dt_bod_saldos.Rows

                'colocar esto en un ciclo
                Try
                    sql = "update bodega_" + row.Item("nombrebodega") + " set salen=replace(salen,'.','')"
                    da = New MySqlDataAdapter(sql, conex)
                    dt = New DataTable
                    da.Fill(dt)

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                conex.Close()
                da.Dispose()
                dt.Dispose()
                conex.Close()

            Next


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_bod_saldos.Dispose()
        dt_bod_saldos.Dispose()
        conex.Close()





    End Sub
    Private Sub Form_bodega_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.ToolTip1.Hide(ComboBoxProds)


        mes_num = DateTime.Now.Month()
        mes_num_text = CStr(mes_num)
        If mes_num <= 9 Then mes_num_text = "0" & CStr(mes_num)
        ComboBoX_fechaMES.SelectedIndex = mes_num_text - 1

        llena_combo_bodegas()

        Me.RadioButton_saldos.Checked = True

        'CONSULTAR_BODEGA()

        loads_productos()


        load_combo_docs()



    End Sub
    Private Sub calcula_saldo()
        Dim NOMBRE_PROD_SALDO As String = ""
        'saldo
        entran = 0
        salen = 0
        saldo = 0

        Try
            sql = "SELECT PRODUCTO, sum(entran) as entran, sum(salen) as salen FROM bodega_Principal where CodProducto=" & CInt(Me.ComboBoxProds.SelectedValue.ToString) & ""
            da = New MySqlDataAdapter(sql, conex)
            dt_saldos = New DataTable
            da.Fill(dt_saldos)
            For Each row As DataRow In dt_saldos.Rows
                entran = row.Item("entran")
                salen = row.Item("salen")
                NOMBRE_PROD_SALDO = row.Item("PRODUCTO")
            Next
            saldo = entran - salen
        Catch ex As Exception
            saldo = 0
        End Try
        da.Dispose()
        dt_saldos.Dispose()
        conex.Close()

        SALDO_DEL_PRODUCTO = saldo
        Me.ToolTip1.ToolTipIcon = ToolTipIcon.Info
        Me.ToolTip1.SetToolTip(Me.ComboBoxProds, "Saldo: " & SALDO_DEL_PRODUCTO)
        Me.ToolTip1.ToolTipTitle = "Existencias De: " & NOMBRE_PROD_SALDO & " "
        ToolTip1.Show("Saldo: " & SALDO_DEL_PRODUCTO, Me.ComboBoxProds)
    End Sub

    Private Sub Btn_salir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub ComboBoxProds_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxProds.SelectedIndexChanged

    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub Timer_prod_data_Tick(sender As Object, e As EventArgs) Handles Timer_prod_data.Tick
        Me.Timer_prod_data.Enabled = False
        calcula_saldo()
        STOCK_del_producto()
    End Sub
    Private Sub STOCK_del_producto()
        Try
            sql = "SELECT * FROM productos where cod=" & CInt(Me.ComboBoxProds.SelectedValue) & ""
            da = New MySqlDataAdapter(sql, conex)
            dt_saldos = New DataTable
            da.Fill(dt_saldos)
            For Each row As DataRow In dt_saldos.Rows
                STOCK = row.Item("STOCK")

            Next
            saldo = entran - salen
        Catch ex As Exception
            saldo = 0
        End Try
        da.Dispose()
        conex.Close()
        If SALDO_DEL_PRODUCTO <= STOCK Then
            Me.ToolTip1.ToolTipIcon = ToolTipIcon.Warning
            Me.ToolTip1.SetToolTip(Me.ComboBoxProds, "Saldo por debajo del stock mínimo: " & SALDO_DEL_PRODUCTO)
            Me.ToolTip1.ToolTipTitle = "Existencias"
            ToolTip1.Show("Saldo por debajo del stock mínimo: " & SALDO_DEL_PRODUCTO, Me.ComboBoxProds)

        End If
    End Sub

    Private Sub datagrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub


    Public Sub ExportarDatosPDF(ByVal document As Document)
        'Se crea un objeto PDFTable con el numero de columnas del DataGridView.
        Dim datatable As New PdfPTable(datagrid.ColumnCount)
        'Se asignan algunas propiedades para el diseño del PDF.
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(datagrid)
        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
        'Se crea el encabezado en el PDF.
        Dim titulo_encabezado As String = ""
        If RadioButton_saldos.Checked = True Then titulo_encabezado = "Saldos de Bodega "
        If RadioButton_faltantes.Checked = True Then titulo_encabezado = "Faltantes de Bodega "
        If RadioButton_entradaysalidas.Checked = True Then titulo_encabezado = "Kardex de Bodega "
        Dim encabezado As New Paragraph(comex_nombrecomercial, New Font(Font.Name = "Arial", 12, Font.Bold))
        Dim encabezado2 As New Paragraph(titulo_encabezado, New Font(Font.Name = "Arial", 12, Font.Bold))

        'Se crea el texto abajo del encabezado.
        Dim texto0 As New Phrase("Bodega: " + Me.ComboBoxInfoBodega.SelectedItem.ToString + " Periodo: " + Me.ComboBoX_fechaMES.Text + Chr(13), New Font(Font.Name = "Tahoma", 8, Font.Bold))
        Dim texto As New Phrase("Fecha del Reporte: " + DateTime.Now.ToString + Chr(13), New Font(Font.Name = "Tahoma", 8, Font.Bold))
        Dim texto_total As New Phrase("Valor Total: " + TextBox_total.Text + Chr(13), New Font(Font.Name = "Tahoma", 8, Font.Bold))

        Dim texto2 As New Phrase("Generado Por: " + usrnom, New Font(Font.Name = "Tahoma", 8, Font.Bold))

        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To datagrid.ColumnCount - 1
            Dim cellhdr As New PdfPCell(New Phrase(datagrid.Columns(i).HeaderText, New Font(Font.Name = "Arial", 8.0F, FontStyle.Bold)))
            'datatable.AddCell(MetroGrid_pdf.Columns(i).HeaderText)
            cellhdr.HorizontalAlignment = Element.ALIGN_CENTER
            cellhdr.BackgroundColor = BaseColor.LIGHT_GRAY
            datatable.AddCell(cellhdr)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1
        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To datagrid.RowCount - 1
            For j As Integer = 0 To datagrid.ColumnCount - 1
                'datatable.AddCell(datagrid(j, i).Value.ToString())

                Dim cell As New PdfPCell
                cell.Phrase = New Phrase(datagrid(j, i).Value.ToString, New Font(Font.Name = "Arial Narrow", 7.0F, Font.Bold = False))
                If j = 0 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 1 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 2 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 3 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 4 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 5 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 6 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 7 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 8 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 9 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 10 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 11 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 12 Then cell.HorizontalAlignment = Element.ALIGN_LEFT

                datatable.AddCell(cell)

            Next
            datatable.CompleteRow()
        Next

        'LOGO
        If comex_logo <> "" And File.Exists(comex_logo) = True Then
            Dim imagelogogopdf As iTextSharp.text.Image 'Declaracion de una imagen

            imagelogogopdf = iTextSharp.text.Image.GetInstance(comex_logo) 'Dirreccion a la imagen que se hace referencia
            imagelogogopdf.Alignment = Element.ALIGN_RIGHT
            imagelogogopdf.SetAbsolutePosition(645, 525) 'Posicion en el eje cartesiano
            imagelogogopdf.ScaleAbsoluteWidth(140) 'Ancho de la imagen
            imagelogogopdf.ScaleAbsoluteHeight(60) 'Altura de la imagen
            document.Add(imagelogogopdf) ' Agrega la imagen al documento
        End If

        'Se agrega el PDFTable al documento.
        document.Add(encabezado)
        document.Add(encabezado2)
        document.Add(texto)
        document.Add(texto_total)
        document.Add(texto2)

        document.Add(datatable)
    End Sub

    Private Sub ComboBoxInfoBodega_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxInfoBodega.SelectedIndexChanged

    End Sub



    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        'funcion para obtener el tamaño de la columnas del datagridview
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function



    Private Sub Label1_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Button_almacen_Click(sender As Object, e As EventArgs) 

    End Sub




    Private Sub CONSULTAR_BODEGA()
        Me.Cursor = Cursors.WaitCursor

        'consulto saldos de bodega====================================================================
        If Me.RadioButton_saldos.Checked = True Then    ' saldos
            Try
                'todos los saldos
                sql = "SELECT B.CodProducto, P.Categoria, concat(p.NOMBRE,' ',p.ref,' ',p.presentacion) as nombre, 
replace(replace(replace(format(sum(B.entran)-sum(B.salen),2),'.',':'),',','.'),':',',') as Saldo, P.Presentacion, 
replace(replace(replace(format(avg(B.COSTO),2),'.',':'),',','.'),':',',') AS Costo, 
replace(replace(replace(format((sum(B.entran)-sum(B.salen))*(avg(B.COSTO)),2),'.',':'),',','.'),':',',') as CostoTotal,
p.Valor, p.valor2, p.valor3,
p.Stock, p.Sugerido, P.Maximo, B.Lote, b.Vence
FROM bodega_" & ComboBoxInfoBodega.Text & " B, PRODUCTOS P
WHERE B.CODPRODUCTO=P.COD GROUP BY B.CODPRODUCTO, B.LOTE order by saldo"

                'saldo por producto
                If ComboBoxProds.Text <> Nothing And CheckBox_buscar_prod.Checked = True Then _
                sql = "SELECT B.CodProducto, P.Categoria, concat(p.NOMBRE,' ',p.ref,' ',p.presentacion) as nombre, 
replace(replace(replace(format(sum(B.entran)-sum(B.salen),2),'.',':'),',','.'),':',',') as Saldo, P.Presentacion, 
replace(replace(replace(format(avg(B.COSTO),2),'.',':'),',','.'),':',',') AS Costo, 
replace(replace(replace(format((sum(B.entran)-sum(B.salen))*(avg(B.COSTO)),2),'.',':'),',','.'),':',',') as CostoTotal,
p.Valor, p.valor2, p.valor3,
p.Stock, p.Sugerido, P.Maximo, B.Lote, b.Vence
FROM bodega_" & ComboBoxInfoBodega.Text & " B, PRODUCTOS P
WHERE B.CODPRODUCTO=P.COD AND B.codproducto=" & ComboBoxProds.SelectedValue & " 
GROUP BY B.CODPRODUCTO, B.LOTE order by saldo"



                da_BODEGAS = New MySqlDataAdapter(sql, conex)
                dt_BODEGAS = New DataTable
                da_BODEGAS.Fill(dt_BODEGAS)
                Me.datagrid.DataSource = dt_BODEGAS
                Me.datagrid.Columns(0).HeaderText = "Código"
                Me.datagrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                Me.datagrid.Columns(0).Width = 100
                Me.datagrid.Columns(1).HeaderText = "Categoría"
                Me.datagrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                Me.datagrid.Columns(1).Width = 180
                Me.datagrid.Columns(2).HeaderText = "Producto"
                Me.datagrid.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                Me.datagrid.Columns(2).Width = 400
                Me.datagrid.Columns(3).HeaderText = "Saldo"
                Me.datagrid.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Me.datagrid.Columns(3).Width = 100
                Me.datagrid.Columns(4).HeaderText = "Present"
                Me.datagrid.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Me.datagrid.Columns(4).Width = 100
                Me.datagrid.Columns(5).HeaderText = "Costo"
                Me.datagrid.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Me.datagrid.Columns(5).Width = 100
                Me.datagrid.Columns(6).HeaderText = "CostoTotal"
                Me.datagrid.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Me.datagrid.Columns(6).Width = 100
                datagrid.Columns("valor").DefaultCellStyle.Format = "c"
                Me.datagrid.Columns(7).HeaderText = "Precio1"
                Me.datagrid.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Me.datagrid.Columns(7).Width = 100
                datagrid.Columns("valor2").DefaultCellStyle.Format = "c"
                Me.datagrid.Columns(8).HeaderText = "Precio2"
                Me.datagrid.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Me.datagrid.Columns(8).Width = 100
                datagrid.Columns("valor3").DefaultCellStyle.Format = "c"
                Me.datagrid.Columns(9).HeaderText = "Precio3"
                Me.datagrid.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Me.datagrid.Columns(9).Width = 100
                Me.datagrid.Columns(10).HeaderText = "Stock"
                Me.datagrid.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.datagrid.Columns(10).Width = 100
                Me.datagrid.Columns(11).HeaderText = "Sugerido"
                Me.datagrid.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.datagrid.Columns(11).Width = 100
                Me.datagrid.Columns(12).HeaderText = "Maximo"
                Me.datagrid.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.datagrid.Columns(12).Width = 100


                If BunifuCheckbox_vence.Checked = False Then Me.datagrid.Columns(13).Visible = False
                If BunifuCheckbox_vence.Checked = True Then Me.datagrid.Columns(13).Visible = True
                If BunifuCheckbox_vence.Checked = False Then Me.datagrid.Columns(14).Visible = False
                If BunifuCheckbox_vence.Checked = True Then Me.datagrid.Columns(14).Visible = True


            Catch ex As Exception
                MsgBox(ex.Message)
                conex.Close()
                da.Dispose()
                dt_BODEGAS.Dispose()
            End Try
            conex.Close()
            da_BODEGAS.Dispose()
            dt_BODEGAS.Dispose()
            Me.datagrid.ClearSelection()
            TextBox_total.Text = 0
            Dim costobo As String = 0
            Dim Precio1 As String = 0
            Dim Precio2 As String = 0
            Dim Precio3 As String = 0


            For Each fila As DataGridViewRow In datagrid.Rows
                If CInt(fila.Cells("saldo").Value.ToString) <= CInt(fila.Cells("stock").Value.ToString) Then
                    'fila.DefaultCellStyle.BackColor = Color.Red
                    fila.Cells("saldo").Style.BackColor = Color.Orange
                    'fila.DefaultCellStyle.ForeColor = Color.Black
                    fila.Cells("saldo").Style.ForeColor = Color.Black

                End If
                If CInt(fila.Cells("saldo").Value.ToString) <= 0 Then
                    'fila.DefaultCellStyle.BackColor = Color.Red
                    fila.Cells("saldo").Style.BackColor = Color.Red
                    'fila.DefaultCellStyle.ForeColor = Color.Black
                    fila.Cells("saldo").Style.ForeColor = Color.Black

                End If
                If CInt(fila.Cells("saldo").Value.ToString) >= CInt(fila.Cells("MAXIMO").Value.ToString) Then
                    'fila.DefaultCellStyle.BackColor = Color.Red
                    fila.Cells("saldo").Style.BackColor = Color.Orange
                    'fila.DefaultCellStyle.ForeColor = Color.Black
                    fila.Cells("saldo").Style.ForeColor = Color.Black

                End If
                If BunifuCheckbox_vence.Checked = True Then

                    If CStr(fila.Cells("VENCE").Value.ToString) <> "" Then   'VENCIMIENTO
                        Dim mes As Integer = DateDiff("m", CDate(DateTime.Now), CDate(fila.Cells("VENCE").Value.ToString))

                        If mes <= 3 Then fila.Cells("vence").Style.BackColor = Color.MistyRose
                        If mes > 3 And mes <= 6 Then fila.Cells("vence").Style.BackColor = Color.Orange
                        If mes > 6 And mes < 12 Then fila.Cells("vence").Style.BackColor = Color.Yellow
                        If mes >= 12 Then fila.Cells("vence").Style.BackColor = Color.LightGreen
                    End If
                End If
                'replace doble  para rregla , y .  en decimales
                costobo = (fila.Cells("CostoTotal").Value.ToString)
                Try
                    TextBox_total.Text = CInt(TextBox_total.Text) + CInt(costobo)
                    Precio1 = Precio1 + (CInt(fila.Cells("valor").Value.ToString) * CInt(fila.Cells("saldo").Value.ToString))
                    Precio2 = Precio2 + (CInt(fila.Cells("valor2").Value.ToString) * CInt(fila.Cells("saldo").Value.ToString))
                    Precio3 = Precio3 + (CInt(fila.Cells("valor3").Value.ToString) * CInt(fila.Cells("saldo").Value.ToString))
                Catch ex As Exception

                End Try


            Next

            Precio1 = FormatCurrency(CDec(Precio1), 0)
            Precio2 = FormatCurrency(CDec(Precio2), 0)
            Precio3 = FormatCurrency(CDec(Precio3), 0)

            ComboBox_precios.Items.Clear()
            ComboBox_precios.Items.Add("Precio 1 " & Precio1)
            ComboBox_precios.Items.Add("Precio 2 " & Precio2)
            ComboBox_precios.Items.Add("Precio 3 " & Precio3)
            ComboBox_precios.SelectedIndex=0

            FormatCurrency(TextBox_total.Text, 2)

            Me.TextBox_total.Text = Format(CDec(Me.TextBox_total.Text), "##,##0.00")
            Me.TextBox_total.Text = "$ " & Me.TextBox_total.Text
            datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        End If


        'consulto faltantes ==================================================================================================
        If Me.RadioButton_faltantes.Checked = True Then    ' saldos
            Try
                'sql = "SELECT CODPRODUCTO, PRODUCTO, SUM(ENTRAN)-SUM(SALEN) AS SALDO FROM bodega_" & CStr(Me.ComboBoxInfoBodega.SelectedItem) & " WHERE COD1='" & Me.TextBox_buscacodigo.Text & "' GROUP BY CODPRODUCTO, lote"
                sql = "SELECT B.CodProducto, P.Categoria, concat(p.NOMBRE,' ',p.ref,' ',p.presentacion) as nombre, 
replace(replace(replace(format(sum(B.entran)-sum(B.salen),2),'.',':'),',','.'),':',',') as Saldo, P.Presentacion, 
replace(replace(replace(format(avg(B.COSTO),2),'.',':'),',','.'),':',',') AS Costo, 
replace(replace(replace(format((sum(B.entran)-sum(B.salen))*(avg(B.COSTO)),2),'.',':'),',','.'),':',',') as CostoTotal,
p.Valor, p.valor2, p.valor3,
p.Stock, p.Sugerido, P.Maximo, B.Lote, b.Vence
FROM bodega_" & ComboBoxInfoBodega.Text & " B, PRODUCTOS P
WHERE B.CODPRODUCTO=P.COD 
GROUP BY B.CODPRODUCTO, B.LOTE having Saldo<=0 order by Saldo"
                If ComboBoxProds.Text <> Nothing And CheckBox_buscar_prod.Checked = True Then
                    sql = "SELECT B.CodProducto, P.Categoria, concat(p.NOMBRE,' ',p.ref,' ',p.presentacion) as nombre, 
replace(replace(replace(format(sum(B.entran)-sum(B.salen),2),'.',':'),',','.'),':',',') as Saldo, P.Presentacion, 
replace(replace(replace(format(avg(B.COSTO),2),'.',':'),',','.'),':',',') AS Costo, 
replace(replace(replace(format((sum(B.entran)-sum(B.salen))*(avg(B.COSTO)),2),'.',':'),',','.'),':',',') as CostoTotal,
p.Valor, p.valor2, p.valor3,
p.Stock, p.Sugerido, P.Maximo, B.Lote, b.Vence
FROM bodega_" & ComboBoxInfoBodega.Text & " B, PRODUCTOS P
WHERE B.CODPRODUCTO=P.COD AND B.codproducto=" & ComboBoxProds.SelectedValue & " 
GROUP BY B.CODPRODUCTO, B.LOTE having Saldo<=0 order by Saldo"
                End If




                da_BODEGAS = New MySqlDataAdapter(sql, conex)
                dt_BODEGAS = New DataTable
                da_BODEGAS.Fill(dt_BODEGAS)
                Me.datagrid.DataSource = dt_BODEGAS
                Me.datagrid.Columns(0).HeaderText = "Código"
                Me.datagrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.datagrid.Columns(0).Width = 100
                Me.datagrid.Columns(1).HeaderText = "Categoría"
                Me.datagrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                Me.datagrid.Columns(1).Width = 180
                Me.datagrid.Columns(2).HeaderText = "Producto"
                Me.datagrid.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                Me.datagrid.Columns(2).Width = 400
                Me.datagrid.Columns(3).HeaderText = "Saldo"
                Me.datagrid.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Me.datagrid.Columns(3).Width = 100
                Me.datagrid.Columns(4).HeaderText = "Present"
                Me.datagrid.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Me.datagrid.Columns(4).Width = 100
                Me.datagrid.Columns(5).HeaderText = "Costo"
                Me.datagrid.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Me.datagrid.Columns(5).Width = 100

                Me.datagrid.Columns(6).HeaderText = "CostoTotal"
                Me.datagrid.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Me.datagrid.Columns(6).Width = 100
                Me.datagrid.Columns(7).HeaderText = "Precio1"
                Me.datagrid.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Me.datagrid.Columns(7).Width = 100
                Me.datagrid.Columns(8).HeaderText = "Precio2"
                Me.datagrid.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.datagrid.Columns(8).Width = 100
                Me.datagrid.Columns(9).HeaderText = "Precio3"
                Me.datagrid.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.datagrid.Columns(9).Width = 100
                Me.datagrid.Columns(10).HeaderText = "Stock"
                Me.datagrid.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.datagrid.Columns(10).Width = 100
                Me.datagrid.Columns(11).HeaderText = "Sugerido"
                Me.datagrid.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.datagrid.Columns(11).Width = 100
                Me.datagrid.Columns(12).HeaderText = "Maximo"
                Me.datagrid.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.datagrid.Columns(12).Width = 100


                If BunifuCheckbox_vence.Checked = False Then Me.datagrid.Columns(13).Visible = False
                If BunifuCheckbox_vence.Checked = True Then Me.datagrid.Columns(13).Visible = True
                If BunifuCheckbox_vence.Checked = False Then Me.datagrid.Columns(14).Visible = False
                If BunifuCheckbox_vence.Checked = True Then Me.datagrid.Columns(14).Visible = True


            Catch ex As Exception
                MsgBox(ex.Message)
                conex.Close()
                da.Dispose()
                dt_BODEGAS.Dispose()
            End Try
            conex.Close()
            da_BODEGAS.Dispose()
            dt_BODEGAS.Dispose()
            Me.datagrid.ClearSelection()
            TextBox_total.Text = 0
            For Each fila As DataGridViewRow In datagrid.Rows
                If CInt(fila.Cells("saldo").Value.ToString.Replace(",", "").ToString.Replace(".", ",")) <= CInt(fila.Cells("stock").Value.ToString) Then
                    'fila.DefaultCellStyle.BackColor = Color.Red
                    fila.Cells("saldo").Style.BackColor = Color.Orange
                    'fila.DefaultCellStyle.ForeColor = Color.Black
                    fila.Cells("saldo").Style.ForeColor = Color.Black

                End If
                If CInt(fila.Cells("saldo").Value.ToString.Replace(",", "").ToString.Replace(".", ",")) <= 0 Then
                    'fila.DefaultCellStyle.BackColor = Color.Red
                    fila.Cells("saldo").Style.BackColor = Color.Red
                    'fila.DefaultCellStyle.ForeColor = Color.Black
                    fila.Cells("saldo").Style.ForeColor = Color.Black

                End If
                If CInt(fila.Cells("saldo").Value.ToString.Replace(",", "").ToString.Replace(".", ",")) >= CInt(fila.Cells("MAXIMO").Value.ToString) Then
                    'fila.DefaultCellStyle.BackColor = Color.Red
                    fila.Cells("saldo").Style.BackColor = Color.Orange
                    'fila.DefaultCellStyle.ForeColor = Color.Black
                    fila.Cells("saldo").Style.ForeColor = Color.Black

                End If

                If BunifuCheckbox_vence.Checked = True Then

                    If CStr(fila.Cells("VENCE").Value.ToString) <> "" Then   'VENCIMIENTO
                        Dim mes As Integer = DateDiff("m", CDate(DateTime.Now), CDate(fila.Cells("VENCE").Value.ToString))

                        If mes <= 3 Then fila.Cells("vence").Style.BackColor = Color.MistyRose
                        If mes > 3 And mes <= 6 Then fila.Cells("vence").Style.BackColor = Color.Orange
                        If mes > 6 And mes < 12 Then fila.Cells("vence").Style.BackColor = Color.Yellow
                        If mes >= 12 Then fila.Cells("vence").Style.BackColor = Color.LightGreen
                    End If
                End If

                TextBox_total.Text = CInt(TextBox_total.Text) + CInt(fila.Cells("costototal").Value.ToString.Replace(",", "").ToString.Replace(".", ","))

            Next
            FormatCurrency(TextBox_total.Text, 2)

            Me.TextBox_total.Text = Format(CDec(Me.TextBox_total.Text), "##,##0.00")
            Me.TextBox_total.Text = "$ " & Me.TextBox_total.Text
            datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        End If






        ' consulto kardex  ========================================================
        If Me.RadioButton_entradaysalidas.Checked = True Then
            Me.TextBox_total.Text = 0
            Me.datagrid.DataSource = Nothing
            Try

                Dim tipodoc As String = ""
                tipodoc = ComboBox_tipodoc.Text
                If ComboBox_tipodoc.Text = "Factura de Venta" Then tipodoc = "VENTA"
                If ComboBox_tipodoc.Text = "Factura de Compra" Then tipodoc = "COMPRA"

                sql = "SELECT b.Fecha, b.TipoDocumento, b.Documento, b.CODPRODUCTO, concat(p.NOMBRE,' ',p.ref,' ',p.presentacion) as Producto, b.ENTRAN, b.SALEN, b.VALORU, b.VALORTOTAL, b.COSTO, b.LOTE, b.vence 
FROM bodega_" & CStr(Me.ComboBoxInfoBodega.Text) & " b inner join productos p on b.codproducto=p.cod
WHERE month(STR_TO_DATE(b.fecha,'%d/%m/%Y'))=" & mes_num_text & " and year(STR_TO_DATE(b.fecha,'%d/%m/%Y'))=" & NumericUpDown_anno.Value.ToString & ""

                If CheckBox_buscar_prod.Checked = True And CheckBox_tipodoc.Checked = False Then sql = "SELECT b.Fecha, b.TipoDocumento, b.Documento, b.CODPRODUCTO, concat(p.NOMBRE,' ',p.ref,' ',p.presentacion) as Producto, b.ENTRAN, b.SALEN, b.VALORU, b.VALORTOTAL, b.COSTO, b.LOTE, b.vence FROM bodega_" & CStr(Me.ComboBoxInfoBodega.Text) & " b inner join productos p on b.codproducto=p.cod where b.codproducto=" & Me.ComboBoxProds.SelectedValue & " AND month(STR_TO_DATE(b.fecha,'%d/%m/%Y'))=" & mes_num_text & ""

                If CheckBox_buscar_prod.Checked = True And CheckBox_tipodoc.Checked = True Then sql = "SELECT b.Fecha, b.TipoDocumento, b.Documento, b.CODPRODUCTO, concat(p.NOMBRE,' ',p.ref,' ',p.presentacion) as Producto, b.ENTRAN, b.SALEN, b.VALORU, b.VALORTOTAL, b.COSTO, b.LOTE, b.vence FROM bodega_" & CStr(Me.ComboBoxInfoBodega.Text) & " b inner join productos p on b.codproducto=p.cod where b.codproducto=" & Me.ComboBoxProds.SelectedValue & " and b.tipodocumento='" & CStr(tipodoc) & "' AND month(STR_TO_DATE(b.fecha,'%d/%m/%Y'))=" & mes_num_text & ""

                If CheckBox_buscar_prod.Checked = False And CheckBox_tipodoc.Checked = True Then sql = "SELECT b.Fecha, b.TipoDocumento, b.Documento, b.CODPRODUCTO, concat(p.NOMBRE,' ',p.ref,' ',p.presentacion) as Producto, b.ENTRAN, b.SALEN, b.VALORU, b.VALORTOTAL, b.COSTO, b.LOTE, b.vence FROM bodega_" & CStr(Me.ComboBoxInfoBodega.Text) & " b inner join productos p on b.codproducto=p.cod where b.tipodocumento='" & CStr(tipodoc) & "' AND month(STR_TO_DATE(b.fecha,'%d/%m/%Y'))=" & mes_num_text & ""


                da_BODEGAS = New MySqlDataAdapter(sql, conex)
                dt_BODEGAS = New DataTable
                da_BODEGAS.Fill(dt_BODEGAS)
                Me.datagrid.DataSource = dt_BODEGAS
                Me.datagrid.Columns(0).HeaderText = "Fecha"
                Me.datagrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                Me.datagrid.Columns(0).Width = 200
                Me.datagrid.Columns(1).HeaderText = "Tipo de Movimiento"
                Me.datagrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                Me.datagrid.Columns(1).Width = 200
                Me.datagrid.Columns(2).HeaderText = "No Doc"
                Me.datagrid.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                Me.datagrid.Columns(2).Width = 70
                Me.datagrid.Columns(3).HeaderText = "Cod Prod"
                Me.datagrid.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.datagrid.Columns(3).Width = 100
                Me.datagrid.Columns(4).HeaderText = "Producto"
                Me.datagrid.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                Me.datagrid.Columns(4).Width = 250

                Me.datagrid.Columns(5).HeaderText = "ENTRAN"
                Me.datagrid.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.datagrid.Columns(5).Width = 70
                Me.datagrid.Columns(6).HeaderText = "SALEN"
                Me.datagrid.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.datagrid.Columns(6).Width = 70

                Me.datagrid.Columns(7).HeaderText = "Vr/Unit"
                Me.datagrid.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.datagrid.Columns(7).Width = 70
                Me.datagrid.Columns(8).HeaderText = "Vr/Total"
                Me.datagrid.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.datagrid.Columns(8).Width = 70
                Me.datagrid.Columns(9).HeaderText = "Vr/Costeo"
                Me.datagrid.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.datagrid.Columns(9).Width = 70
            Catch ex As Exception
                MsgBox(ex.Message)
                conex.Close()
                da_BODEGAS.Dispose()
                dt_BODEGAS.Dispose()
            End Try
            conex.Close()
            da_BODEGAS.Dispose()
            dt_BODEGAS.Dispose()


            Me.datagrid.ClearSelection()
            datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ComboBoxInfoBodega_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBoxInfoBodega.SelectionChangeCommitted
        'loads_productos()

    End Sub

    Private Sub RadioButton_mes_CheckedChanged(sender As Object, e As EventArgs)
        'If Me.RadioButton_mes.Checked = CheckState.Checked Then
        '    Me.ComboBoX_fechaMES.DataSource = Nothing
        '    Me.ComboBoX_fechaMES.Items.Add("Enero")
        '    Me.ComboBoX_fechaMES.Items.Add("Febrero")
        '    Me.ComboBoX_fechaMES.Items.Add("Marzo")
        '    Me.ComboBoX_fechaMES.Items.Add("Abril")
        '    Me.ComboBoX_fechaMES.Items.Add("Mayo")
        '    Me.ComboBoX_fechaMES.Items.Add("Junio")
        '    Me.ComboBoX_fechaMES.Items.Add("Julio")
        '    Me.ComboBoX_fechaMES.Items.Add("Agosto")
        '    Me.ComboBoX_fechaMES.Items.Add("Septiembre")
        '    Me.ComboBoX_fechaMES.Items.Add("Octubre")
        '    Me.ComboBoX_fechaMES.Items.Add("Noviembre")
        '    Me.ComboBoX_fechaMES.Items.Add("Diciembre")
        'End If
    End Sub





    Private Sub loads_productos()

        'LLENADO DE PRODUCTOS COMBO
        Try
            sql = "SELECT cod, concat(nombre,' ',ref,' ',presentacion) as nombre FROM productos where estado='ACTIVO'"
            da_prodscombo = New MySqlDataAdapter(sql, conex)
            dt_prodscombo = New DataTable
            da_prodscombo.Fill(dt_prodscombo)
            Me.ComboBoxProds.DataSource = dt_prodscombo.DefaultView
            Me.ComboBoxProds.DisplayMember = "nombre"
            Me.ComboBoxProds.ValueMember = "cod"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_prodscombo.Dispose()
        dt_prodscombo.Dispose()
        conex.Close()
        Me.ComboBoxProds.SelectedItem = Nothing

    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        CONSULTAR_BODEGA()

    End Sub




    Public Sub ExportToExcel(ByVal dt As DataTable,
                         ByVal fileName As String,
                         ByVal sheetName As String)

        ' Verificamos los parámetros pasados
        '
        If ((dt Is Nothing) OrElse
        (String.IsNullOrEmpty(fileName)) OrElse
        (String.IsNullOrEmpty(sheetName))) Then _
        Throw New ArgumentNullException()

        Dim app As Excel.Application = Nothing
        Dim book As Excel.Workbook = Nothing
        Dim sheet As Excel.Worksheet = Nothing

        Try
            ' Referenciamos la aplicación Excel.
            '
            app = New Excel.Application()

            ' Abrimos el libro de trabajo.
            '
            book = app.Workbooks.Open(fileName)

            ' Referenciamos la hoja de cálculo del libro.
            '
            sheet = DirectCast(book.Sheets(sheetName), Excel.Worksheet)

            With sheet
                ' Limpiamos el contenido de toda la hoja.
                '
                .Cells.Select()
                .Cells.ClearContents()

                ' Seleccionamos la primera celda de la hoja.
                '
                .Range("A1").Select()

                ' Escribimos los nombres de las columnas en la primera
                ' celda de la primera fila de la hoja de cálculo
                '
                Dim fila As Integer = 1
                Dim columna As Integer = 1

                For Each dc As DataColumn In dt.Columns
                    .Cells(fila, columna) = dc.ColumnName
                    columna += 1
                Next

                ' Establecemos los atributos de la fuente para las
                ' celdas de la primera fila.
                '
                With .Range(.Cells(1, 1), .Cells(1, dt.Columns.Count)).Font
                    .Name = "Calibri"
                    .Bold = True
                    .Size = 12
                End With

                ' Insertamos los datos en la hoja de cálculo, comenzando por la
                ' fila número 2, ya que la primera fila está ocupada
                ' por el nombre de las columnas.
                '
                fila = 2

                For Each row As DataRow In dt.Rows

                    ' Primera columna
                    columna = 1

                    For Each dc As DataColumn In dt.Columns
                        .Cells(fila, columna) = row(dc.ColumnName)

                        ' Siguiente columna
                        columna += 1
                    Next

                    ' Siguiente fila
                    fila += 1

                Next

                ' Autoajustamos el ancho de todas las columnas utilizadas.
                '
                .Columns().AutoFit()

            End With

        Catch ex As Exception
            ' Se ha producido una excepción;
            ' indicamos que el libro ha sido guardado.
            '
            If (book IsNot Nothing) Then
                book.Saved = True
            End If

            ' Devolvemos la excepción al procedimiento llamador
            Throw

        Finally
            sheet = Nothing

            If (book IsNot Nothing) Then
                ' Si procede, guardamos el libro de trabajo.
                If (Not (book.Saved)) Then book.Save()
                ' Cerramos el libro de Excel.
                book.Close()
            End If
            book = Nothing

            If (app IsNot Nothing) Then
                ' Si procede, cerramos Excel y disminuimos el recuento
                ' de referencias al objeto Excel.Application.
                app.Quit()
                While (System.Runtime.InteropServices.Marshal.ReleaseComObject(app) > 0)
                    ' Sin implementación.
                End While
            End If
            app = Nothing

        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If CheckBox_buscar_prod.Checked = True And ComboBoxProds.Text = "" Then
            Exit Sub
        End If



        If CheckBox_tipodoc.Checked = True And ComboBox_tipodoc.Text = "" Then
            Exit Sub
        End If


        Button3.Enabled = False
        Button_exportar.Enabled = False
        RadioButton_saldos.Enabled = False
        RadioButton_faltantes.Enabled = False
        RadioButton_entradaysalidas.Enabled = False
        ComboBoxInfoBodega.Enabled = False
        ComboBoX_fechaMES.Enabled = False
        ComboBox_tipodoc.Enabled = False
        ComboBoxProds.Enabled = False


        Cursor.Current = Cursors.WaitCursor
        CONSULTAR_BODEGA()
        Cursor.Current = Cursors.Default


        Button3.Enabled = True
        Button_exportar.Enabled = True
        RadioButton_saldos.Enabled = True
        RadioButton_faltantes.Enabled = True
        RadioButton_entradaysalidas.Enabled = True
        ComboBoxInfoBodega.Enabled = True
        ComboBoX_fechaMES.Enabled = True
        ComboBox_tipodoc.Enabled = True
        ComboBoxProds.Enabled = True

    End Sub

    Private Sub TextBox_BARRAS_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox_cod_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBoX_fechaMES_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoX_fechaMES.SelectedIndexChanged

    End Sub

    Private Sub ComboBoxProds_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBoxProds.KeyDown
        'If ComboBoxProds.Text = "" Then
        '    Me.ComboBoxProds.SelectedIndex = -1
        '    Timer1.Enabled = True

        'End If
    End Sub

    Private Sub ComboBoxProds_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxProds.SelectedValueChanged

    End Sub

    Private Sub datagrid_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid.CellContentClick

    End Sub

    Private Sub Button_maxxi_Click(sender As Object, e As EventArgs) 
        Me.WindowState = FormWindowState.Maximized
        datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub Button_minni_Click(sender As Object, e As EventArgs) 
        Me.WindowState = FormWindowState.Normal
        datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        Me.WindowState = FormWindowState.Minimized

    End Sub




    Public Sub ExportarDatosPDF_pos(ByVal document As Document)
        'Se crea un objeto PDFTable con el numero de columnas del DataGridView.
        Dim datatable As New PdfPTable(MetroGrid_pdf.ColumnCount)
        'Se asignan algunas propiedades para el diseño del PDF.
        datatable.DefaultCell.Padding = 3

        Dim anchos() As Single = {40, 20, 20, 20}
        datatable.SetWidths(anchos)

        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 1
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
        'Se crea el encabezado en el PDF.
        Dim titulo_encabezado As String = ""
        If RadioButton_saldos.Checked = True Then titulo_encabezado = "Saldos de Bodega "
        If RadioButton_faltantes.Checked = True Then titulo_encabezado = "Faltantes de Bodega "
        If RadioButton_entradaysalidas.Checked = True Then titulo_encabezado = "Kardex de Bodega "

        Dim encabezado As New Paragraph(comex_nombrecomercial, New Font(Font.Name = "Arial", 12, Font.Bold))
        Dim encabezado2 As New Paragraph(titulo_encabezado, New Font(Font.Name = "Arial", 12, Font.Bold))

        'Se crea el texto abajo del encabezado.
        Dim texto0 As New Phrase("Bodega: " + Me.ComboBoxInfoBodega.Text + Chr(13), New Font(Font.Name = "Tahoma", 8, Font.Bold))
        Dim texto As New Phrase("Fecha del Reporte: " + DateTime.Now().ToString + Chr(13), New Font(Font.Name = "Tahoma", 8, Font.Bold))
        Dim texto_total As New Phrase("Valor Total: " + TextBox_total.Text + Chr(13), New Font(Font.Name = "Tahoma", 8, Font.Bold))

        Dim texto2 As New Phrase("Generado Por: " + usrnom, New Font(Font.Name = "Tahoma", 8, Font.Bold))

        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To MetroGrid_pdf.ColumnCount - 1
            Dim cellhdr As New PdfPCell(New Phrase(MetroGrid_pdf.Columns(i).HeaderText, New Font(Font.Name = "Arial", 8.0F, FontStyle.Bold)))
            'datatable.AddCell(MetroGrid_pdf.Columns(i).HeaderText)
            cellhdr.HorizontalAlignment = Element.ALIGN_CENTER
            cellhdr.BackgroundColor = BaseColor.LIGHT_GRAY
            datatable.AddCell(cellhdr)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1
        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To MetroGrid_pdf.RowCount - 1
            For j As Integer = 0 To MetroGrid_pdf.ColumnCount - 1
                'datatable.AddCell(datagrid(j, i).Value.ToString())

                Dim cell As New PdfPCell
                cell.Phrase = New Phrase(MetroGrid_pdf(j, i).Value.ToString, New Font(Font.Name = "Arial Narrow", 7, Font.Bold = False))
                If j = 0 Then cell.HorizontalAlignment = Element.ALIGN_LEFT : cell.Colspan = 4 : cell.Rowspan = 1 : cell.BackgroundColor = BaseColor.LIGHT_GRAY
                If j = 1 Then cell.HorizontalAlignment = Element.ALIGN_LEFT : cell.Colspan = 1 : cell.Rowspan = 1 : cell.BackgroundColor = BaseColor.WHITE
                If j = 2 Then cell.HorizontalAlignment = Element.ALIGN_LEFT : cell.Colspan = 2 : cell.Rowspan = 1 : cell.BackgroundColor = BaseColor.WHITE
                If j = 3 Then cell.HorizontalAlignment = Element.ALIGN_LEFT : cell.Colspan = 1 : cell.Rowspan = 1 : cell.BackgroundColor = BaseColor.WHITE
                If j = 4 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 5 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 6 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 7 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 8 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 9 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 10 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 11 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 12 Then cell.HorizontalAlignment = Element.ALIGN_LEFT

                datatable.AddCell(cell)

            Next
            datatable.CompleteRow()
        Next

        'LOGO
        If comex_logo <> "" Then
            'Dim imagelogogopdf As iTextSharp.text.Image 'Declaracion de una imagen

            'imagelogogopdf = iTextSharp.text.Image.GetInstance(comex_logo) 'Dirreccion a la imagen que se hace referencia
            'imagelogogopdf.Alignment = Element.ALIGN_RIGHT
            'imagelogogopdf.SetAbsolutePosition(645, 525) 'Posicion en el eje cartesiano
            'imagelogogopdf.ScaleAbsoluteWidth(140) 'Ancho de la imagen
            'imagelogogopdf.ScaleAbsoluteHeight(60) 'Altura de la imagen
            'document.Add(imagelogogopdf) ' Agrega la imagen al documento
        End If

        'Se agrega el PDFTable al documento.
        document.Add(encabezado)
        document.Add(encabezado2)
        document.Add(texto0)
        document.Add(texto)
        document.Add(texto_total)
        document.Add(texto2)

        document.Add(datatable)
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) 
        If File.Exists("c:\miclickderecho\ManualConsultaInventario.pdf") Then
            Process.Start("c:\miclickderecho\ManualConsultaInventario.pdf")
        Else
            MsgBox("no se encontró el archivo de ayuda, por lo que se cargará desde internet.")
            Me.Cursor = Cursors.WaitCursor
            Try
                ' System.Diagnostics.Process.Start("C:\Archivos de PRograma\Internet Explorer\iexplorer.exe", "www.google.com")
                Dim pag As String
                pag = "http://www.miclickderecho.com/manual/ManualConsultaInventario.pdf"
                Shell("Explorer " & pag)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            Me.Cursor = Cursors.Default



        End If
    End Sub

    Private Sub RadioButton_entradaysalidas_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_entradaysalidas.CheckedChanged
        ComboBox_tipodoc.Visible = True
        CheckBox_tipodoc.Visible = True
        CheckBox_tipodoc.Checked = False

        ComboBoxProds.SelectedItem = Nothing
        CheckBox_buscar_prod.Checked = False

        Label4.Visible = True
        ComboBoX_fechaMES.Visible = True


        datagrid.DataSource = Nothing

        Label5.Visible = False
        Label1.Visible = False
        ComboBox_precios.Visible = False : ComboBox_precios.Items.Clear()
        TextBox_total.Text = 0
        TextBox_total.Visible = False
    End Sub

    Private Sub RadioButton_saldos_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_saldos.CheckedChanged
        ComboBox_tipodoc.Visible = False
        CheckBox_tipodoc.Visible = False
        ComboBox_tipodoc.SelectedItem = Nothing
        CheckBox_tipodoc.Checked = False

        ComboBoxProds.SelectedItem = Nothing
        CheckBox_buscar_prod.Checked = False

        Label4.Visible = False
        ComboBoX_fechaMES.Visible = False


        datagrid.DataSource = Nothing


        Label5.Visible = True
        Label1.Visible = True
        ComboBox_precios.Visible = True : ComboBox_precios.Items.Clear()
        TextBox_total.Text = 0
        TextBox_total.Visible = True

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub RadioButton_faltantes_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_faltantes.CheckedChanged

        ComboBox_tipodoc.Visible = False
        CheckBox_tipodoc.Visible = False
        ComboBox_tipodoc.SelectedItem = Nothing
        CheckBox_tipodoc.Checked = False


        ComboBoxProds.SelectedItem = Nothing
        CheckBox_buscar_prod.Checked = False

        Label4.Visible = False
        ComboBoX_fechaMES.Visible = False



        datagrid.DataSource = Nothing

        Label5.Visible = True
        Label1.Visible = True
        ComboBox_precios.Visible = False : ComboBox_precios.Items.Clear()
        TextBox_total.Text = 0
        TextBox_total.Visible = True

    End Sub

    Private Sub CheckBox_buscar_prod_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_buscar_prod.CheckedChanged
        If CheckBox_buscar_prod.Checked = True Then ComboBoxProds.Enabled = True
        If CheckBox_buscar_prod.Checked = False Then ComboBoxProds.SelectedItem = Nothing : ComboBoxProds.Enabled = False

    End Sub

    Private Sub CheckBox_tipodoc_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_tipodoc.CheckedChanged
        If CheckBox_tipodoc.Checked = True Then ComboBox_tipodoc.Enabled = True
        If CheckBox_tipodoc.Checked = False Then ComboBox_tipodoc.SelectedItem = Nothing : ComboBox_tipodoc.Enabled = False
    End Sub
    Private Sub load_combo_docs()


        Try
            sql = "SELECT CONS, concat(documento) as documento FROM data_docs WHERE ESTADO='SI' and padre='NO' AND CODIGO in('MI','FV','FC') "
            da_combo_docs_bodega = New MySqlDataAdapter(sql, conex)
            dt_combo_docs_bodega = New DataTable
            da_COMBO_docs_bodega.Fill(dt_combo_docs_bodega)
            Me.ComboBox_tipodoc.DataSource = dt_combo_docs_bodega.DefaultView
            Me.ComboBox_tipodoc.DisplayMember = "documento"
            Me.ComboBox_tipodoc.ValueMember = "cons"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_COMBO_docs_bodega.Dispose()
        dt_combo_docs_bodega.Dispose()
        conex.Close()


        ComboBox_tipodoc.Text = Nothing

    End Sub

    Private Sub Button_exportar_BODEGA_Click(sender As Object, e As EventArgs) Handles Button_exportar_BODEGA.Click
        Button_exportar.Text = "Exportando...."
        Cursor.Current = Cursors.WaitCursor

        Button3.Enabled = False
        Button_exportar.Enabled = False
        RadioButton_saldos.Enabled = False
        RadioButton_faltantes.Enabled = False
        RadioButton_entradaysalidas.Enabled = False
        ComboBoxInfoBodega.Enabled = False
        ComboBoX_fechaMES.Enabled = False
        ComboBox_tipodoc.Enabled = False
        ComboBoxProds.Enabled = False

        Panel6.Enabled = False
        Button_exportar_BODEGA.Enabled = False


        Cursor.Current = Cursors.WaitCursor
        '======================================================================
        ' saldos de bodega
        If RadioButton_saldos.Checked = True Then
            Cursor.Current = Cursors.WaitCursor

            If RadioButton_pos.Checked = True Then  'formato pos
                Try
                    sql = "SELECT concat(b.codproducto,'|',P.Nombre) as Producto, 
format(CONVERT(REPLACE(CAST(B.COSTO AS CHAR),',','.'),decimal(12,2)),0) AS Costo, 
convert(CONVERT(REPLACE(CAST(B.COSTO AS CHAR),',','.'),decimal(12,2)) * IF(B.DECI='SI', sum(CAST(CONVERT(REPLACE(CAST(B.entran AS CHAR),',','.'),decimal(12,2)) AS DECIMAL(12,2)))-sum(CAST(CONVERT(REPLACE(CAST(B.SALEN AS CHAR),',','.'),decimal(12,2)) AS DECIMAL(12,2))), sum(CAST(B.entran AS CHAR))-sum(CAST(B.SALEN AS CHAR))),decimal(12,2)) as Total,
IF(B.DECI='SI', sum(CAST(CONVERT(REPLACE(CAST(B.entran AS CHAR),',','.'),decimal(12,2)) AS DECIMAL(12,2)))-sum(CAST(CONVERT(REPLACE(CAST(B.SALEN AS CHAR),',','.'),decimal(12,2)) AS DECIMAL(12,2))), sum(CAST(B.entran AS CHAR))-sum(CAST(B.SALEN AS CHAR))) AS Saldo
FROM bodega_" & ComboBoxInfoBodega.Text & " B, PRODUCTOS P
WHERE B.CODPRODUCTO=P.COD GROUP BY B.CODPRODUCTO, B.LOTE order by saldo"
                    If ComboBoxProds.Text <> Nothing And ComboBoxProds.SelectedValue <> Nothing Then sql = "SELECT concat(b.codproducto,'|',P.Nombre) as Producto
CONVERT(REPLACE(CAST(B.COSTO AS CHAR),',','.'),decimal(12,3)) AS Costo, 
convert(CONVERT(REPLACE(CAST(B.COSTO AS CHAR),',','.'),decimal(12,3)) * IF(B.DECI='SI', sum(CAST(CONVERT(REPLACE(CAST(B.entran AS CHAR),',','.'),decimal(12,3)) AS DECIMAL(12,3)))-sum(CAST(CONVERT(REPLACE(CAST(B.SALEN AS CHAR),',','.'),decimal(12,3)) AS DECIMAL(12,3))), sum(CAST(B.entran AS CHAR))-sum(CAST(B.SALEN AS CHAR))),decimal(12,3)) as Total,
IF(B.DECI='SI', sum(CAST(CONVERT(REPLACE(CAST(B.entran AS CHAR),',','.'),decimal(12,3)) AS DECIMAL(12,3)))-sum(CAST(CONVERT(REPLACE(CAST(B.SALEN AS CHAR),',','.'),decimal(12,3)) AS DECIMAL(12,3))), sum(CAST(B.entran AS CHAR))-sum(CAST(B.SALEN AS CHAR))) AS Saldo
FROM bodega_" & ComboBoxInfoBodega.Text & " B, PRODUCTOS P
WHERE B.CODPRODUCTO=P.COD AND B.codproducto=" & ComboBoxProds.SelectedValue & " 
GROUP BY B.CODPRODUCTO, B.LOTE order by saldo"

                    da_pdf_bodega_pos = New MySqlDataAdapter(sql, conex)
                    dt_pdf_bodega_pos = New DataTable
                    da_pdf_bodega_pos.Fill(dt_pdf_bodega_pos)
                    Me.MetroGrid_pdf.DataSource = dt_pdf_bodega_pos


                Catch ex As Exception
                    MsgBox(ex.Message)
                    conex.Close()
                    da_pdf_bodega_pos.Dispose()
                    dt_pdf_bodega_pos.Dispose()
                End Try
                conex.Close()
                da_pdf_bodega_pos.Dispose()
                dt_pdf_bodega_pos.Dispose()

                'TOTAL
                TextBox_total.Text = 0
                For Each fila As DataGridViewRow In datagrid.Rows
                    TextBox_total.Text = CInt(TextBox_total.Text) + CInt(fila.Cells("costototal").Value.ToString.Replace(",", "").ToString.Replace(".", ","))
                Next
                Me.TextBox_total.Text = Format(CDec(Me.TextBox_total.Text), "##,##0.00")
                Me.TextBox_total.Text = "$ " & Me.TextBox_total.Text

                Try
                    'Intentar generar el documento.
                    alto_pag = ((MetroGrid_pdf.RowCount) * 24)
                    Dim pgSize = New iTextSharp.text.Rectangle(205, alto_pag)
                    'Dim doc As New Document(PageSize.A4, 8, 400, 10, 10)
                    Dim doc As New Document(pgSize, 8, 8, 10, 10)
                    'Intentar generar el documento.
                    If Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) & "\MiClickDerecho Docs\") = False Then
                        Try
                            My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) & "\MiClickDerecho Docs\")
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try
                    End If
                    'Path que guarda el reporte en el escritorio de windows (Desktop).
                    Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\Saldos de Bodega" & ComboBoxInfoBodega.Text & ".pdf"
                    Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
                    PdfWriter.GetInstance(doc, file)
                    doc.Open()
                    ExportarDatosPDF_pos(doc)
                    doc.Close()

                    Process.Start("C:\Program Files\Tracker Software\PDF Viewer\pdfxcview.exe", """" & Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\Saldos de Bodega" & ComboBoxInfoBodega.Text & ".pdf" & """")


                Catch ex As Exception
                    If ex.ToString.Contains("page size must be smaller") Then
                        MessageBox.Show("el documento es demasiado grande para el formato POS", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    'Si el intento es fallido, mostrar MsgBox.
                    MessageBox.Show("No se puede generar el documento PDF, Cierre los documentos PDF generados anteriormente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If


            'saldos en formato normal
            If RadioButton_normal.Checked = True Then
                Try
                    'Intentar generar el documento.
                    Dim doc As New Document(PageSize.A4.Rotate, 20, 20, 10, 10)
                    If Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) & "\MiClickDerecho Docs\") = False Then
                        Try
                            My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) & "\MiClickDerecho Docs\")
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try
                    End If
                    'Path que guarda el reporte en el escritorio de windows (Desktop).
                    Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\Saldos de Bodega" & ComboBoxInfoBodega.Text & ".pdf"
                    Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
                    PdfWriter.GetInstance(doc, file)
                    doc.Open()
                    ExportarDatosPDF(doc)
                    doc.Close()


                    Process.Start("C:\Program Files\Tracker Software\PDF Viewer\pdfxcview.exe", """" & Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\Saldos de Bodega" & ComboBoxInfoBodega.Text & ".pdf" & """")


                Catch ex As Exception
                    'Si el intento es fallido, mostrar MsgBox.
                    MessageBox.Show("No se puede generar el documento PDF, Cierre los documentos PDF generados anteriormente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If



            'saldos en excel excel
            If RadioButton_xls.Checked = True Then
                Cursor.Current = Cursors.WaitCursor

                Application.DoEvents()

                ' Cambiamos el tipo de cursor
                '



                Try
                    My.Computer.FileSystem.CopyFile("c:\miclick\plantilla.xlsx",
            Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\saldosdebodega.xlsx", True) ' muevo el archivo 
                Catch ex As Exception
                    MsgBox("la plantilla no existe", vbInformation)
                End Try

                Try

                    ' Referenciamos el objeto DataTable enlazado con
                    ' el control DataGridView.

                    Dim dt As DataTable = DirectCast(datagrid.DataSource, DataTable)

                    ' Exportamos los datos a la hoja de Excel de un
                    ' libro de Excel 2007 - 2010.
                    '
                    ExportToExcel(dt, Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\saldosdebodega.xlsx", "Hoja1")

                    MessageBox.Show("Los datos han sido exportados satisfactoriamente.")

                Catch ex As Exception
                    ' Se ha producido un error.
                    '
                    MessageBox.Show(ex.Message)

                Finally
                    ' Restauramos el tipo de cursos existente
                    '

                End Try

            End If
            Cursor.Current = Cursors.Default

        End If








        '=======================================================================
        ' faltantes
        If RadioButton_faltantes.Checked = True Then
            'faltantes POS
            If RadioButton_pos.Checked = True Then
                Try
                    'sql = "SELECT CODPRODUCTO, PRODUCTO, SUM(ENTRAN)-SUM(SALEN) AS SALDO FROM bodega_" & CStr(Me.ComboBoxInfoBodega.SelectedItem) & " WHERE COD1='" & Me.TextBox_buscacodigo.Text & "' GROUP BY CODPRODUCTO, lote"
                    sql = "SELECT B.CodProducto, P.Categoria, concat(p.NOMBRE,' ',p.ref,' ',p.presentacion) as nombre, 
format(sum(B.entran)-sum(B.salen),2) as Saldo, P.Presentacion, 
format(avg(B.COSTO),2) AS Costo, 
format((sum(B.entran)-sum(B.salen))*(avg(B.COSTO)),2) as CostoTotal,
p.Valor, p.valor2, p.valor3,
p.Stock, p.Sugerido, P.Maximo, B.Lote, b.Vence
FROM bodega_" & ComboBoxInfoBodega.Text & " B, PRODUCTOS P
WHERE B.CODPRODUCTO=P.COD and Saldo<0
GROUP BY B.CODPRODUCTO, B.LOTE order by Saldo"
                    If ComboBoxProds.Text <> Nothing And ComboBoxProds.SelectedValue <> Nothing Then
                        sql = "SELECT B.CodProducto, P.Categoria, concat(p.NOMBRE,' ',p.ref,' ',p.presentacion) as nombre, 
format(sum(B.entran)-sum(B.salen),2) as Saldo, P.Presentacion, 
format(avg(B.COSTO),2) AS Costo, 
format((sum(B.entran)-sum(B.salen))*(avg(B.COSTO)),2) as CostoTotal,
p.Valor, p.valor2, p.valor3,
p.Stock, p.Sugerido, P.Maximo, B.Lote, b.Vence
FROM bodega_" & ComboBoxInfoBodega.Text & " B, PRODUCTOS P
WHERE B.CODPRODUCTO=P.COD AND B.codproducto=" & ComboBoxProds.SelectedValue & " and Saldo<0'
GROUP BY B.CODPRODUCTO, B.LOTE order by Saldo"
                    End If


                    da_pdf_bodega_pos = New MySqlDataAdapter(sql, conex)
                    dt_pdf_bodega_pos = New DataTable
                    da_pdf_bodega_pos.Fill(dt_pdf_bodega_pos)
                    Me.MetroGrid_pdf.DataSource = dt_pdf_bodega_pos


                Catch ex As Exception
                    MsgBox(ex.Message)
                    conex.Close()
                    da_pdf_bodega_pos.Dispose()
                    dt_pdf_bodega_pos.Dispose()
                End Try
                conex.Close()
                da_pdf_bodega_pos.Dispose()
                dt_pdf_bodega_pos.Dispose()

                'TOTAL 
                TextBox_total.Text = 0
                For Each fila As DataGridViewRow In datagrid.Rows
                    TextBox_total.Text = CInt(TextBox_total.Text) + CInt(fila.Cells("total").Value.ToString)
                Next
                Me.TextBox_total.Text = Format(CDec(Me.TextBox_total.Text), "##,##0.00")
                Me.TextBox_total.Text = "$ " & Me.TextBox_total.Text

                Try
                    'Intentar generar el documento.
                    alto_pag = ((MetroGrid_pdf.RowCount) * 24)
                    Dim pgSize = New iTextSharp.text.Rectangle(205, alto_pag)
                    'Dim doc As New Document(PageSize.A4, 8, 400, 10, 10)
                    Dim doc As New Document(pgSize, 8, 8, 10, 10)
                    'Intentar generar el documento.
                    If Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) & "\MiClickDerecho Docs\") = False Then
                        Try
                            My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) & "\MiClickDerecho Docs\")
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try
                    End If
                    'Path que guarda el reporte en el escritorio de windows (Desktop).
                    Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\Faltantes de Bodega" & ComboBoxInfoBodega.Text & ".pdf"
                    Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
                    PdfWriter.GetInstance(doc, file)
                    doc.Open()
                    ExportarDatosPDF_pos(doc)
                    doc.Close()

                    Process.Start("C:\Program Files\Tracker Software\PDF Viewer\pdfxcview.exe", """" & Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\Faltantes de Bodega" & ComboBoxInfoBodega.Text & ".pdf" & """")

                Catch ex As Exception
                    'Si el intento es fallido, mostrar MsgBox.
                    MessageBox.Show("No se puede generar el documento PDF, Cierre los documentos PDF generados anteriormente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If


            'faltantes en formato normal
            If RadioButton_normal.Checked = True Then
                Try
                    'Intentar generar el documento.
                    Dim doc As New Document(PageSize.A4.Rotate, 20, 20, 10, 10)
                    If Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) & "\MiClickDerecho Docs\") = False Then
                        Try
                            My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) & "\MiClickDerecho Docs\")
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try
                    End If
                    'Path que guarda el reporte en el escritorio de windows (Desktop).
                    Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\Faltantes de Bodega" & ComboBoxInfoBodega.Text & ".pdf"
                    Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
                    PdfWriter.GetInstance(doc, file)
                    doc.Open()
                    ExportarDatosPDF(doc)
                    doc.Close()

                    Process.Start("C:\Program Files\Tracker Software\PDF Viewer\pdfxcview.exe", """" & Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\Faltantes de Bodega" & ComboBoxInfoBodega.Text & ".pdf" & """")


                Catch ex As Exception
                    'Si el intento es fallido, mostrar MsgBox.
                    MessageBox.Show("No se puede generar el documento PDF, Cierre los documentos PDF generados anteriormente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If



            'falta tes en excel excel
            If RadioButton_xls.Checked = True Then
                Application.DoEvents()

                ' Cambiamos el tipo de cursor
                '
                Dim tipoCursor As Cursor = Me.Cursor
                Me.Cursor = Cursors.WaitCursor
                Try
                    My.Computer.FileSystem.CopyFile("c:\miclickderecho\plantilla.xlsx",
            Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\faltantesbodega.xlsx", True) ' muevo el archivo 
                Catch ex As Exception
                    MsgBox("la plantilla no existe", vbInformation)
                End Try

                Try

                    ' Referenciamos el objeto DataTable enlazado con
                    ' el control DataGridView.
                    '
                    Dim dt As DataTable = DirectCast(datagrid.DataSource, DataTable)

                    ' Exportamos los datos a la hoja de Excel de un
                    ' libro de Excel 2007 - 2010.
                    '
                    ExportToExcel(dt, Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\faltantesbodega.xlsx", "Hoja1")

                    MessageBox.Show("Los datos han sido exportados satisfactoriamente.")

                Catch ex As Exception
                    ' Se ha producido un error.
                    '
                    MessageBox.Show(ex.Message)

                Finally
                    ' Restauramos el tipo de cursos existente
                    '
                    Me.Cursor = tipoCursor

                End Try

            End If
        End If







        '========================================================================
        ' kardex
        If RadioButton_entradaysalidas.Checked = True Then

            If RadioButton_pos.Checked = True Then
                Cursor.Current = Cursors.Default

                Exit Sub
            End If




            'kardex en formato normal
            If RadioButton_normal.Checked = True Then
                    Try
                        'Intentar generar el documento.
                        Dim doc As New Document(PageSize.A4.Rotate, 20, 20, 10, 10)
                        If Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) & "\MiClickDerecho Docs\") = False Then
                            Try
                                My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) & "\MiClickDerecho Docs\")
                            Catch ex As Exception
                                MsgBox(ex.ToString)
                            End Try
                        End If
                        'Path que guarda el reporte en el escritorio de windows (Desktop).
                        Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\kardex de Bodega " & ComboBoxInfoBodega.Text & ".pdf"
                        Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
                        PdfWriter.GetInstance(doc, file)
                        doc.Open()
                        ExportarDatosPDF(doc)
                        doc.Close()


                        Process.Start("C:\Program Files\Tracker Software\PDF Viewer\pdfxcview.exe", """" & Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\kardex de Bodega " & ComboBoxInfoBodega.Text & ".pdf" & """")


                    Catch ex As Exception
                        'Si el intento es fallido, mostrar MsgBox.
                        MessageBox.Show("No se puede generar el documento PDF, Cierre los documentos PDF generados anteriormente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If



                'kardex en excel excel
                If RadioButton_xls.Checked = True Then
                    Application.DoEvents()

                    ' Cambiamos el tipo de cursor
                    '
                    Dim tipoCursor As Cursor = Me.Cursor
                    Me.Cursor = Cursors.WaitCursor
                    Try
                        My.Computer.FileSystem.CopyFile("c:\miclickderecho\plantilla.xlsx",
                Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\kardexbodega" & ComboBoxInfoBodega.Text & ".xlsx", True) ' muevo el archivo 
                    Catch ex As Exception
                        MsgBox("la plantilla no existe", vbInformation)
                    End Try

                    Try

                        ' Referenciamos el objeto DataTable enlazado con
                        ' el control DataGridView.
                        '
                        Dim dt As DataTable = DirectCast(datagrid.DataSource, DataTable)

                        ' Exportamos los datos a la hoja de Excel de un
                        ' libro de Excel 2007 - 2010.
                        '
                        ExportToExcel(dt, Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\kardexbodega" & ComboBoxInfoBodega.Text & ".xlsx", "Hoja1")

                        MessageBox.Show("Los datos han sido exportados satisfactoriamente.")

                    Catch ex As Exception
                        ' Se ha producido un error.
                        '
                        MessageBox.Show(ex.Message)

                    Finally
                        ' Restauramos el tipo de cursos existente
                        '
                        Me.Cursor = tipoCursor

                    End Try

                End If
            End If   '===================================================



            Cursor.Current = Cursors.Default



        Button3.Enabled = True
        Button_exportar.Enabled = True
        RadioButton_saldos.Enabled = True
        RadioButton_faltantes.Enabled = True
        RadioButton_entradaysalidas.Enabled = True
        ComboBoxInfoBodega.Enabled = True
        ComboBoX_fechaMES.Enabled = True
        ComboBox_tipodoc.Enabled = True
        ComboBoxProds.Enabled = True

        Panel6.Enabled = True
        Button_exportar_BODEGA.Enabled = True

        BunifuCards_exportar.Visible = False
        Button_exportar.Text = "Exportar"

    End Sub

    Private Sub Button_exportar_Click(sender As Object, e As EventArgs) Handles Button_exportar.Click

        BunifuCards_exportar.Height = 272
        BunifuCards_exportar.Visible = True
        BunifuCards_exportar.BringToFront()
        Centrar(BunifuCards_exportar)


        If RadioButton_saldos.Checked = True Then Label13.Text = "Exportar Saldos"
        If RadioButton_faltantes.Checked = True Then Label13.Text = "Exportar Faltantes"
        If RadioButton_entradaysalidas.Checked = True Then Label13.Text = "Exportar Kardex"


    End Sub
    Private Sub Centrar(ByVal Objeto As Object)

        ' Centrar un Formulario ...  
        If TypeOf Objeto Is Form Then
            Dim frm As Form = CType(Objeto, Form)
            With Screen.PrimaryScreen.WorkingArea ' Dimensiones de la pantalla sin el TaskBar  
                frm.Top = (.Height - frm.Height) \ 2
                frm.Left = (.Width - frm.Width) \ 2
            End With

            ' Centrar un control dentro del contenedor  
        Else
            ' referencia al control  
            Dim c As Control = CType(Objeto, Control)

            'le  establece el top y el Left dentro del Parent  
            With c
                .Top = (.Parent.ClientSize.Height - c.Height) \ 2
                .Left = (.Parent.ClientSize.Width - c.Width) \ 2
            End With
        End If
    End Sub

    Private Sub Button_cerrar_exportar_Click(sender As Object, e As EventArgs) Handles Button_cerrar_exportar.Click
        BunifuCards_exportar.Visible = False

    End Sub

    Private Sub ComboBox_tipodoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_tipodoc.SelectedIndexChanged

    End Sub

    Private Sub ComboBoX_fechaMES_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoX_fechaMES.SelectedValueChanged

    End Sub

    Private Sub ComboBoX_fechaMES_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBoX_fechaMES.SelectionChangeCommitted
        mes_num = DateTime.ParseExact(Me.ComboBoX_fechaMES.Text, "MMMM", CultureInfo.CurrentCulture).Month
        mes_num_text = CStr(mes_num)
        If mes_num <= 9 Then mes_num_text = "0" & CStr(mes_num)



    End Sub

    Private Sub ComboBox_tipodoc_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_tipodoc.SelectionChangeCommitted


    End Sub

    Private Sub datagrid_Sorted(sender As Object, e As EventArgs) Handles datagrid.Sorted

        If RadioButton_entradaysalidas.Checked = False Then

            For Each fila As DataGridViewRow In datagrid.Rows
                If CInt(fila.Cells("saldo").Value.ToString) <= CInt(fila.Cells("stock").Value.ToString) Then
                    'fila.DefaultCellStyle.BackColor = Color.Red
                    fila.Cells("saldo").Style.BackColor = Color.Orange
                    'fila.DefaultCellStyle.ForeColor = Color.Black
                    fila.Cells("saldo").Style.ForeColor = Color.Black

                End If

                If CInt(fila.Cells("saldo").Value.ToString) <= 0 Then
                    'fila.DefaultCellStyle.BackColor = Color.Red
                    fila.Cells("saldo").Style.BackColor = Color.Red
                    'fila.DefaultCellStyle.ForeColor = Color.Black
                    fila.Cells("saldo").Style.ForeColor = Color.Black

                End If
            Next

        End If


    End Sub

    Private Sub TextBox_total_TextChanged(sender As Object, e As EventArgs) Handles TextBox_total.TextChanged



    End Sub

    Private Sub ComboBoxProds_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxProds.KeyPress
        If ComboBoxProds.DroppedDown = True Then
            ComboBoxProds.DroppedDown = False
        End If
    End Sub

    Private Sub TextBox_totalP_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBoxInfoBodega_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxInfoBodega.SelectedValueChanged

    End Sub

    Private Sub ComboBox_precios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_precios.SelectedIndexChanged

    End Sub

    Private Sub TextBox_total_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_total.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub TextBox_totalP_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.KeyChar = ""
    End Sub

    Private Sub ComboBox_precios_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox_precios.KeyPress
        e.KeyChar = ""

    End Sub
End Class