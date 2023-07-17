Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class Form_producc_opciones

    Public da_prods_producir As New MySqlDataAdapter
    Public dt_prods_producir As New DataTable

    Public da_prods_desecho As New MySqlDataAdapter
    Public dt_prods_desecho As New DataTable

    Public da_recetario As New MySqlDataAdapter
    Public dt_recetario As New DataTable

    Public da_insumos As New MySqlDataAdapter
    Public dt_insumos As New DataTable

    Public da_prods_ins As New MySqlDataAdapter
    Public dt_prods_ins As New DataTable

    Public da_AGRUPA_RECETAS As New MySqlDataAdapter
    Public dt_AGRUPA_RECETAS As New DataTable

    Dim QUE_HACE As String = ""

    Dim COD_MATERIA_PRIMA_SEL As String = ""

    Private Sub Button_cerrar_Click(sender As Object, e As EventArgs) Handles Button_cerrar.Click
        Me.Close()
    End Sub

    Private Sub Form_producc_opciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datagrid_recetas.BringToFront()
    End Sub

    Private Sub Form_producc_opciones_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Cursor = Cursors.WaitCursor

        'LLENADO DE PRODUCTOS para desecho
        Try
            sql = "SELECT COD, CONCAT(NOMBRE,' ',PRESENTACION) AS NOMBRE FROM productos where tipo='PROCESADOS' order by nombre"
            da_prods_desecho = New MySqlDataAdapter(sql, conex)
            dt_prods_desecho = New DataTable
            da_prods_desecho.Fill(dt_prods_desecho)
            Me.ComboBox1.DataSource = dt_prods_desecho.DefaultView
            Me.ComboBox1.DisplayMember = "nombre"
            Me.ComboBox1.ValueMember = "cod"
            Me.ComboBox1.SelectedItem = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_prods_desecho.Dispose()
        dt_prods_desecho.Dispose()
        conex.Close()







        'LLENADO DE PRODUCTOS PROCESADOS
        Try
            sql = "SELECT COD, CONCAT(NOMBRE,' ',PRESENTACION) AS NOMBRE FROM productos where tipo='PROCESADOS' order by nombre"
            da_prods_producir = New MySqlDataAdapter(sql, conex)
            dt_prods_producir = New DataTable
            da_prods_producir.Fill(dt_prods_producir)
            Me.ComboBox_prods_procesados.DataSource = dt_prods_producir.DefaultView
            Me.ComboBox_prods_procesados.DisplayMember = "nombre"
            Me.ComboBox_prods_procesados.ValueMember = "cod"
            Me.ComboBox_prods_procesados.SelectedItem = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_prods_producir.Dispose()
        dt_prods_producir.Dispose()
        conex.Close()

        grid_recetas()

        datagrid_recetas.Refresh()



        Me.Cursor = Cursors.Default


    End Sub

    Private Sub Button_buscar_Click(sender As Object, e As EventArgs) Handles Button_buscar.Click
        Me.Cursor = Cursors.WaitCursor
        ComboBox_prods_procesados.SelectedItem = Nothing

        Try
            sql = "SELECT COD, CONCAT(nombre,' ',PRESENTACION) as Producto, MERMA, DESECHOS, coddesecho FROM productos WHERE nombre like '%" & TextBox_buscar_receta.Text & "%' and receta='SI' ORDER BY NOMBRE DESC"
            da_recetario = New MySqlDataAdapter(sql, conex)
            dt_recetario = New DataTable
            da_recetario.Fill(dt_recetario)
            Me.datagrid_recetas.DataSource = dt_recetario
            Me.datagrid_recetas.Columns(0).HeaderText = "Código"
            Me.datagrid_recetas.Columns(0).Width = 80
            Me.datagrid_recetas.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagrid_recetas.Columns(1).HeaderText = "Producto"
            'Me.datagrid_recetas.Columns(1).Width = 0
            Me.datagrid_recetas.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagrid_recetas.Columns(2).Visible = False
            Me.datagrid_recetas.Columns(3).Visible = False
            Me.datagrid_recetas.Columns(4).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_recetario.Dispose()
        dt_recetario.Dispose()

        datagrid_recetas.ClearSelection()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Btn_nuevo_Click(sender As Object, e As EventArgs) Handles Btn_nuevo.Click
        Panel1.Visible = False
        Button_guardar_receta.Text = "Crear"
        QUE_HACE = "CREAR"
        Label3.Visible = True

        Me.Cursor = Cursors.WaitCursor
        'LLENADO DE PRODUCTOS PROCESADOS
        Try
            sql = "SELECT COD, CONCAT(NOMBRE,' ',PRESENTACION) AS NOMBRE FROM productos where tipo='PROCESADOS' order by nombre"
            da_prods_producir = New MySqlDataAdapter(sql, conex)
            dt_prods_producir = New DataTable
            da_prods_producir.Fill(dt_prods_producir)
            Me.ComboBox_prods_procesados.DataSource = dt_prods_producir.DefaultView
            Me.ComboBox_prods_procesados.DisplayMember = "nombre"
            Me.ComboBox_prods_procesados.ValueMember = "cod"
            Me.ComboBox_prods_procesados.SelectedItem = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_prods_producir.Dispose()
        dt_prods_producir.Dispose()
        conex.Close()
        Me.Cursor = Cursors.Default

        ComboBox_prods_procesados.Enabled = True

        Me.Cursor = Cursors.WaitCursor
        Try
            sql = "SELECT COD, CONCAT(NOMBRE,' ',PRESENTACION) AS NOMBRE FROM productos where tipo='INSUMOS' order by nombre"
            da_prods_ins = New MySqlDataAdapter(sql, conex)
            dt_prods_ins = New DataTable
            da_prods_ins.Fill(dt_prods_ins)
            Me.ComboBox_materiaprima.DataSource = dt_prods_ins.DefaultView
            Me.ComboBox_materiaprima.DisplayMember = "nombre"
            Me.ComboBox_materiaprima.ValueMember = "cod"
            Me.ComboBox_materiaprima.SelectedItem = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_prods_ins.Dispose()
        dt_prods_ins.Dispose()
        conex.Close()
        Me.Cursor = Cursors.Default



        Panel_dock.Visible = False



        datagrid_recetas.Visible = False
        DataGrid_materia_prima.DataSource = Nothing

        ComboBox_prods_procesados.Focus()
        ComboBox_prods_procesados.DroppedDown = True



        ComboBox_materiaprima.Enabled = False
        NumericUpDown_cant.Enabled = False
        button_Quitar_Prod.Enabled = False
        Button_agregar_prod.Enabled = False


        Button_ELIMINAR2.Enabled = False
        Button_exportar.Enabled = False

        NumericUpDown_desechos.Enabled = True
        NumericUpDown_merma.Enabled = True
        ComboBox1.Enabled = True

    End Sub

    Private Sub Btn_Ver_editar_Click(sender As Object, e As EventArgs) Handles Btn_Ver_editar.Click
        If ComboBox_prods_procesados.SelectedItem.ToString = Nothing Then
            Exit Sub

        End If




        QUE_HACE = "CONSULTAR"
        Button_guardar_receta.Text = "Guardar"
        Panel1.Visible = False

        Panel_dock.Visible = False
        Label3.Visible = True



        datagrid_recetas.Visible = False
        DataGrid_materia_prima.DataSource = Nothing
        ComboBox_prods_procesados.Enabled = False
        NumericUpDown_desechos.Enabled = True
        NumericUpDown_merma.Enabled = True
        ComboBox1.Enabled = True
        Button_agregar_prod.Enabled = True
        button_Quitar_Prod.Enabled = True

        grid_prods_receta()

    End Sub

    Private Sub Button_Regresar_receta_Click(sender As Object, e As EventArgs) Handles Button_Regresar_receta.Click


        datagrid_recetas.Visible = True
        datagrid_recetas.BringToFront()
        datagrid_recetas.ClearSelection()


        DataGrid_materia_prima.DataSource = Nothing
        ComboBox_materiaprima.SelectedItem = Nothing
        ComboBox_prods_procesados.SelectedItem = Nothing
        ComboBox1.SelectedItem = Nothing

        NumericUpDown_cant.Value = 0
        Panel1.Visible = True
        Panel_dock.Visible = True

        Label3.Visible = False

        grid_recetas()

    End Sub

    Private Sub Button_guardar_receta_Click(sender As Object, e As EventArgs) Handles Button_guardar_receta.Click
        ComboBox_prods_procesados.Enabled = False
        ComboBox_materiaprima.Enabled = True
        ComboBox1.Enabled = True

        button_Quitar_Prod.Enabled = True
        Button_agregar_prod.Enabled = True

        Button_ELIMINAR2.Enabled = True
        Button_exportar.Enabled = True

        NumericUpDown_cant.Enabled = True
        Button_guardar_receta.Text = "Guardar"


        sql = "update productos set receta='SI', merma='" & NumericUpDown_merma.Value & "', desechos='" & NumericUpDown_desechos.Value & "', CODdesecho='" & ComboBox1.SelectedValue & "'  WHERE cod=" & ComboBox_prods_procesados.SelectedValue & ""
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

    End Sub

    Private Sub Button_agregar_prod_Click(sender As Object, e As EventArgs) Handles Button_agregar_prod.Click
        If NumericUpDown_cant.Value = 0 Then MsgBox("Falta la Cantidad.") : Exit Sub
        If ComboBox_materiaprima.Text = "" Or Nothing Then MsgBox("Seleccione un producto.") : Exit Sub

        Me.Cursor = Cursors.WaitCursor

        sql = "INSERT INTO productos_receta (codreceta, codprod, producto, cantidad)" &
              "VALUES (" & CInt(Me.ComboBox_prods_procesados.SelectedValue) & ",'" & CStr(Me.ComboBox_materiaprima.SelectedValue) & "','" & CStr(Me.ComboBox_materiaprima.Text) & "','" & CStr(Me.NumericUpDown_cant.Value) & "')"
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
        Me.Cursor = Cursors.Default

        ComboBox_materiaprima.SelectedItem = Nothing
        NumericUpDown_cant.Value = 0

        grid_prods_receta()

    End Sub

    Private Sub grid_prods_receta()
        Me.Cursor = Cursors.WaitCursor

        Try
            sql = "SELECT * FROM productos_receta WHERE codrecETA = " & CInt(ComboBox_prods_procesados.SelectedValue) & " ORDER BY CONS DESC"
            da_insumos = New MySqlDataAdapter(sql, conex)
            dt_insumos = New DataTable
            da_insumos.Fill(dt_insumos)
            Me.DataGrid_materia_prima.DataSource = dt_insumos
            Me.DataGrid_materia_prima.Columns(0).Visible = False
            Me.DataGrid_materia_prima.Columns(1).Visible = False
            Me.DataGrid_materia_prima.Columns(2).HeaderText = "Código"
            Me.DataGrid_materia_prima.Columns(2).Width = 80
            Me.DataGrid_materia_prima.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.DataGrid_materia_prima.Columns(3).HeaderText = "Insumo"
            Me.DataGrid_materia_prima.Columns(3).Width = 350
            Me.DataGrid_materia_prima.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.DataGrid_materia_prima.Columns(4).HeaderText = "Cant"
            Me.DataGrid_materia_prima.Columns(4).Width = 90
            Me.DataGrid_materia_prima.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_insumos.Dispose()
        dt_insumos.Dispose()





        DataGrid_materia_prima.ClearSelection()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub grid_recetas()
        Me.Cursor = Cursors.WaitCursor

        Try
            sql = "SELECT COD, CONCAT(nombre,' ',PRESENTACION) as Producto, MERMA, DESECHOS, coddesecho FROM productos WHERE receta='SI' ORDER BY NOMBRE DESC"
            da_recetario = New MySqlDataAdapter(sql, conex)
            dt_recetario = New DataTable
            da_recetario.Fill(dt_recetario)
            Me.datagrid_recetas.DataSource = dt_recetario
            Me.datagrid_recetas.Columns(0).HeaderText = "Código"
            Me.datagrid_recetas.Columns(0).Width = 80
            Me.datagrid_recetas.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagrid_recetas.Columns(1).HeaderText = "Producto"
            'Me.datagrid_recetas.Columns(1).Width = 0
            Me.datagrid_recetas.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagrid_recetas.Columns(2).Visible = False
            Me.datagrid_recetas.Columns(3).Visible = False
            Me.datagrid_recetas.Columns(4).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_recetario.Dispose()
        dt_recetario.Dispose()

        datagrid_recetas.ClearSelection()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Panel_detalles_Paint(sender As Object, e As PaintEventArgs) Handles Panel_detalles.Paint

    End Sub

    Private Sub datagrid_recetas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_recetas.CellContentClick

    End Sub

    Private Sub datagrid_recetas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_recetas.CellClick
        If Not IsDBNull(datagrid_recetas.Item("cod", 0).Value) Then
            Dim row As DataGridViewRow = datagrid_recetas.CurrentRow
            ComboBox_prods_procesados.SelectedValue = CLng(row.Cells("cod").Value)
            NumericUpDown_merma.Value = CStr(row.Cells("MERMA").Value)
            NumericUpDown_desechos.Value = CStr(row.Cells("DESECHOS").Value)
            If CStr(row.Cells("CODDESECHO").Value) = "" Then ComboBox1.SelectedItem = Nothing
            If CStr(row.Cells("CODDESECHO").Value) <> "" Then ComboBox1.SelectedValue = CStr(row.Cells("CODDESECHO").Value)


        End If
    End Sub

    Private Sub Button_ELIMINAR2_Click(sender As Object, e As EventArgs) Handles Button_ELIMINAR2.Click
        Button_eliminar_Click(Nothing, Nothing)
    End Sub

    Private Sub Button_eliminar_Click(sender As Object, e As EventArgs) Handles Button_eliminar.Click
        Dim RTA As String
        RTA = MsgBox("Desea eliminar el LA RECETA ?.  ", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If RTA = 6 Then
            Me.Cursor = Cursors.WaitCursor

            Try
                sql = "DELETE FROM PRODUCTOS_RECETA WHERE CODRECETA='" & ComboBox_prods_procesados.SelectedValue & "'"
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                da.Fill(dt)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da.Dispose()
            dt.Dispose()

            sql = "update productos set receta='NO', merma='',desechos='',CODdesecho='' WHERE cod=" & ComboBox_prods_procesados.SelectedValue & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                MsgBox(ex.ToString)
                Me.Cursor = Cursors.Default

            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()

            grid_recetas()
            Me.Cursor = Cursors.Default

            DataGrid_materia_prima.DataSource = Nothing
            ComboBox_materiaprima.SelectedItem = Nothing
            ComboBox_prods_procesados.SelectedItem = Nothing
            NumericUpDown_cant.Value = 0

        End If


    End Sub

    Private Sub DataGrid_materia_prima_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid_materia_prima.CellContentClick

    End Sub

    Private Sub DataGrid_materia_prima_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid_materia_prima.CellClick
        If Not IsDBNull(DataGrid_materia_prima.Item("CONS", 0).Value) Then
            Dim row As DataGridViewRow = DataGrid_materia_prima.CurrentRow
            COD_MATERIA_PRIMA_SEL = CLng(row.Cells("CONS").Value)
        End If
    End Sub

    Private Sub button_Quitar_Prod_Click(sender As Object, e As EventArgs) Handles button_Quitar_Prod.Click
        If COD_MATERIA_PRIMA_SEL = "" Then
            MsgBox("Primero seleccione un item para eliminar.", vbInformation)
            Exit Sub
        End If


        Dim RTA As String
        RTA = MsgBox("Desea eliminar el insumo?.  ", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If RTA = 6 Then
            Try
                sql = "DELETE FROM PRODUCTOS_RECETA WHERE cons='" & COD_MATERIA_PRIMA_SEL & "'"
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                da.Fill(dt)
                Me.datagrid_recetas.DataSource = dt


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da.Dispose()
            dt.Dispose()

            grid_prods_receta()

            COD_MATERIA_PRIMA_SEL = ""
        End If


    End Sub



    Private Sub ComboBox_prods_procesados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_prods_procesados.SelectedIndexChanged

    End Sub

    Private Sub ComboBox_prods_procesados_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox_prods_procesados.KeyPress
        If ComboBox_prods_procesados.DroppedDown = True Then
            ComboBox_prods_procesados.DroppedDown = False
        End If
    End Sub

    Private Sub ComboBox_materiaprima_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_materiaprima.SelectedIndexChanged

    End Sub

    Private Sub ComboBox_materiaprima_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox_materiaprima.KeyPress
        If ComboBox_materiaprima.DroppedDown = True Then
            ComboBox_materiaprima.DroppedDown = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs") Then
            My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MIClickDerecho Docs")
        End If

        Try
            'Intentar generar el documento.
            Dim doc As New Document(PageSize.A4, 15, 15, 15, 15)
            'Path que guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\Listado de Recetas de Producción.pdf"
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
        'Se crea un objeto PDFTable con el numero de columnas del DataGridView.
        Dim datatable As New PdfPTable(3)
        'Se asignan algunas propiedades para el diseño del PDF.
        datatable.DefaultCell.Padding = 3

        datatable.SetWidths({50, 100, 50})
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER

        Dim contentFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 10, iTextSharp.text.Font.BOLD)
        Dim fontLINE = iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLD)
        Dim DIRFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 6, iTextSharp.text.Font.BOLD)

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


        cellhome.Phrase = New Phrase(comex_nombrecomercial, FontFactory.GetFont(FontFactory.COURIER, 11, iTextSharp.text.Font.BOLD))
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase(comex_nombrepropietario, FontFactory.GetFont(FontFactory.COURIER, 10, iTextSharp.text.Font.BOLD))
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase("NIT:" & comex_nit & "-" & comex_DV & " " & comex_regimen, FontFactory.GetFont(FontFactory.COURIER, 7, iTextSharp.text.Font.BOLD))
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase(comex_dircomercio + " Tels:" & comex_tels & " " & comex_cels, FontFactory.GetFont(FontFactory.COURIER, 7, iTextSharp.text.Font.BOLD))
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        Dim encabezado2 As New Paragraph("<<< RECETAS DE PRODUCCION >>>", FontFactory.GetFont(FontFactory.COURIER, 11, iTextSharp.text.Font.BOLD))
        encabezado2.Alignment = Element.ALIGN_CENTER

        'Se crea el texto abajo del encabezado.

        Dim texto2 As New Phrase("Fecha del Reporte: " + Now.Date(), FontFactory.GetFont(FontFactory.COURIER, 9D, iTextSharp.text.Font.BOLD))
        Dim texto3 As New Phrase("            Generado Por :" + usrnom, FontFactory.GetFont(FontFactory.COURIER, 9D, iTextSharp.text.Font.BOLD))



        ' AGRUPACION
        Try
            sql = "SELECT DISTINCT(CODRECETA), PRODUCTOS.NOMBRE FROM PRODUCTOS_RECETA
LEFT JOIN PRODUCTOS ON PRODUCTOS_RECETA.CODRECETA=PRODUCTOS.COD order by PRODUCTO"
            da_AGRUPA_RECETAS = New MySqlDataAdapter(sql, conex)
            dt_AGRUPA_RECETAS = New DataTable
            da_AGRUPA_RECETAS.Fill(dt_AGRUPA_RECETAS)
            For Each row3 As DataRow In dt_AGRUPA_RECETAS.Rows
                'CStr(row3.Item("CATEGORIA"))

                Try
                    sql = "SELECT CodPROD, PRODUCTO, CANTIDAD FROM productos_RECETA where CODRECETA='" & CStr(row3.Item("codreceta")) & "' order by PRODUCTO"

                    da_pdf = New MySqlDataAdapter(sql, conex)
                    dt_pdf = New DataTable
                    da_pdf.Fill(dt_pdf)
                    Me.MetroGrid_pdf.DataSource = dt_pdf

                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    conex.Close()
                    da_pdf.Dispose()
                    dt_pdf.Dispose()
                End Try
                conex.Close()
                da_pdf.Dispose()
                dt_pdf.Dispose()

                'Dim encabezado_CAT As New Paragraph(CStr(row3.Item("CATEGORIA")) + Chr(13), DIRFont) : encabezado_CAT.Alignment = 0
                'document.Add(encabezado_CAT)



                Dim cell_CAT As New PdfPCell
                cell_CAT.Phrase = New Phrase("( " + CStr(row3.Item("CODRECETA")) + " | " + CStr(row3.Item("NOMBRE")) + " )", FontFactory.GetFont(FontFactory.COURIER_BOLD, 10D, iTextSharp.text.Font.BOLD))
                cell_CAT.BorderWidth = 1


                cell_CAT.BackgroundColor = BaseColor.LIGHT_GRAY
                cell_CAT.HorizontalAlignment = Element.ALIGN_CENTER
                cell_CAT.Colspan = 8
                datatable.AddCell(cell_CAT)
                cell_CAT.Phrase = New Phrase("", iTextSharp.text.FontFactory.GetFont(FontFactory.COURIER_BOLD, 7.5D, iTextSharp.text.Font.NORMAL, BaseColor.BLACK))
                cell_CAT.BorderWidth = 0
                cell_CAT.BackgroundColor = BaseColor.WHITE
                datatable.AddCell(cell_CAT)
                cell_CAT.Phrase = New Phrase("", iTextSharp.text.FontFactory.GetFont(FontFactory.COURIER_BOLD, 7.5D, iTextSharp.text.Font.NORMAL, BaseColor.BLACK))
                cell_CAT.BorderWidth = 0
                cell_CAT.BackgroundColor = BaseColor.WHITE
                datatable.AddCell(cell_CAT)
                datatable.CompleteRow()

                'Se capturan los nombres de las columnas del DataGridView.
                For i As Integer = 0 To MetroGrid_pdf.ColumnCount - 1
                    Dim HEADERCELLFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 8, iTextSharp.text.Font.BOLD)

                    Dim cell_TITLE As New PdfPCell
                    cell_TITLE.Phrase = New Phrase(MetroGrid_pdf.Columns(i).HeaderText, FontFactory.GetFont(FontFactory.COURIER_BOLD, 7D, iTextSharp.text.Font.BOLD))
                    cell_TITLE.HorizontalAlignment = Element.ALIGN_CENTER
                    cell_TITLE.BackgroundColor = BaseColor.LIGHT_GRAY
                    datatable.AddCell(cell_TITLE)
                Next
                datatable.HeaderRows = 0
                datatable.DefaultCell.BorderWidth = 0
                'Se generan las columnas del DataGridView.
                For i As Integer = 0 To MetroGrid_pdf.RowCount - 1
                    For j As Integer = 0 To MetroGrid_pdf.ColumnCount - 1
                        Dim cell As New PdfPCell
                        cell.Border = 0
                        cell.BorderColor = BaseColor.BLACK
                        cell.Phrase = New Phrase(MetroGrid_pdf(j, i).FormattedValue.ToString, FontFactory.GetFont(FontFactory.COURIER, 7.5D, iTextSharp.text.Font.BOLD))
                        If j = 0 Then cell.HorizontalAlignment = Element.ALIGN_LEFT : cell.BorderWidthLeft = 1
                        If j = 1 Then cell.HorizontalAlignment = Element.ALIGN_LEFT : cell.BorderWidthLeft = 0
                        If j = 2 Then cell.HorizontalAlignment = Element.ALIGN_CENTER : cell.BorderWidthLeft = 0
                        If j = 3 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT : cell.BorderWidthLeft = 0
                        If j = 4 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT : cell.BorderWidthLeft = 0
                        If j = 5 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT : cell.BorderWidthLeft = 0
                        If j = 6 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT : cell.BorderWidthLeft = 0
                        If j = 7 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT : cell.BorderWidthLeft = 0 : cell.BorderWidthRight = 1

                        datatable.AddCell(cell)
                    Next
                    datatable.CompleteRow()
                Next

            Next
            'datatable_det_ventas.SpacingBefore = 10
            'If BunifuCheckbox_det_ventas.Checked = True Then document.Add(datatable_det_ventas)

        Catch ex As Exception
        End Try
        conex.Close()
        da_AGRUPA_RECETAS.Dispose()
        dt_AGRUPA_RECETAS.Dispose()
        conex.Close()













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

        'Se agrega el PDFTable al documento.
        'Se agrega el PDFTable al documento.
        document.Add(encabezadoLINE)

        document.Add(tablahome)
        document.Add(encabezadoLINE3)
        document.Add(encabezado2)
        document.Add(encabezadoLINE3)
        document.Add(texto2)
        document.Add(texto3)
        document.Add(datatable)

        encabezadoLINE3.SpacingBefore = -12
        document.Add(encabezadoLINE3)

    End Sub
    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        'funcion para obtener el tamaño de la columnas del datagridview
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function

    Private Sub RadioButton_INSUMOS_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_INSUMOS.CheckedChanged
        If RadioButton_INSUMOS.Checked = True Then
            Try
                sql = "SELECT COD, CONCAT(NOMBRE,' ',PRESENTACION) AS NOMBRE FROM productos where tipo='INSUMOS' order by nombre"
                da_prods_ins = New MySqlDataAdapter(sql, conex)
                dt_prods_ins = New DataTable
                da_prods_ins.Fill(dt_prods_ins)
                Me.ComboBox_materiaprima.DataSource = dt_prods_ins.DefaultView
                Me.ComboBox_materiaprima.DisplayMember = "nombre"
                Me.ComboBox_materiaprima.ValueMember = "cod"
                Me.ComboBox_materiaprima.SelectedItem = Nothing

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da_prods_ins.Dispose()
            dt_prods_ins.Dispose()
            conex.Close()
        End If
    End Sub

    Private Sub RadioButton_PROCESADOS_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_PROCESADOS.CheckedChanged
        If RadioButton_PROCESADOS.Checked = True Then
            Try
                sql = "SELECT COD, CONCAT(NOMBRE,' ',PRESENTACION) AS NOMBRE FROM productos where tipo='PROCESADOS' order by nombre"
                da_prods_ins = New MySqlDataAdapter(sql, conex)
                dt_prods_ins = New DataTable
                da_prods_ins.Fill(dt_prods_ins)
                Me.ComboBox_materiaprima.DataSource = dt_prods_ins.DefaultView
                Me.ComboBox_materiaprima.DisplayMember = "nombre"
                Me.ComboBox_materiaprima.ValueMember = "cod"
                Me.ComboBox_materiaprima.SelectedItem = Nothing

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da_prods_ins.Dispose()
            dt_prods_ins.Dispose()
            conex.Close()
        End If
    End Sub
End Class