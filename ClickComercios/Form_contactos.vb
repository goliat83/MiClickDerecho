Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class Form_contactos
    Dim que_hace As String
    Dim proveedor_id As String
    Dim ACTIVIDAD_ID As String

    Dim que_hace_act As String = ""

    Dim tipo_contacto_PROV As String = "NO"
    Dim tipo_contacto_CLI As String = "NO"
    Dim tipo_contacto_otro As String = "NO"

    Public da_actividades As New MySqlDataAdapter
    Public dt_actividades As DataTable

    Dim mousex As Integer = 0
    Dim mousey As Integer = 0
    Dim mouseDown1 As Boolean = False

    Dim viene_de As String

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




    Private Sub Form_proveedores_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If viene_de = "movimientos de inventario" Then
            Form_movimientos.Timer_contactos.Enabled = True

        End If



    End Sub






    Private Sub grid_proveedores()
        Me.Cursor = Cursors.WaitCursor
        sql = "SELECT * FROM PROVEEDORES order by nombre asc"
        da = New MySqlDataAdapter(sql, conex)
        dt = New DataTable
        Try
            da.Fill(dt)
            Me.datagridPROVEEDORES.DataSource = dt

        Catch ex As Exception
            If ex.ToString.Contains("Duplicate entry") Then MsgBox("Ese proveedor ya se encuentra en la lista", vbExclamation)
            MsgBox(ex.ToString)
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()

        Me.datagridPROVEEDORES.Columns(0).Visible = False

        Me.datagridPROVEEDORES.Columns(4).Visible = False
        Me.datagridPROVEEDORES.Columns(5).Visible = False


        Me.datagridPROVEEDORES.Columns(7).Visible = False
        Me.datagridPROVEEDORES.Columns(8).Visible = False
        Me.datagridPROVEEDORES.Columns(9).Visible = False
        Me.datagridPROVEEDORES.Columns(10).Visible = False
        Me.datagridPROVEEDORES.Columns(11).Visible = False
        Me.datagridPROVEEDORES.Columns(12).Visible = False
        Me.datagridPROVEEDORES.Columns(13).Visible = False
        Me.datagridPROVEEDORES.Columns(14).Visible = False
        Me.datagridPROVEEDORES.Columns(15).Visible = False
        Me.datagridPROVEEDORES.Columns(16).Visible = False
        Me.datagridPROVEEDORES.Columns(17).Visible = False
        Me.datagridPROVEEDORES.Columns(18).Visible = False
        Me.datagridPROVEEDORES.Columns(19).Visible = False
        Me.datagridPROVEEDORES.Columns(20).Visible = False
        Me.datagridPROVEEDORES.Columns(21).Visible = False
        Me.datagridPROVEEDORES.Columns(22).Visible = False
        Me.datagridPROVEEDORES.Columns(23).Visible = False
        Me.datagridPROVEEDORES.Columns(24).Visible = False
        Me.datagridPROVEEDORES.Columns(25).Visible = False
        Me.datagridPROVEEDORES.Columns(26).Visible = False
        Me.datagridPROVEEDORES.Columns(27).Visible = False
        Me.datagridPROVEEDORES.Columns(28).Visible = False
        Me.datagridPROVEEDORES.Columns(29).Visible = False
        Me.datagridPROVEEDORES.Columns(30).Visible = False
        Me.datagridPROVEEDORES.Columns(31).Visible = False
        Me.datagridPROVEEDORES.Columns(32).Visible = False
        Me.datagridPROVEEDORES.Columns(33).Visible = False
        Me.datagridPROVEEDORES.Columns(34).Visible = False

        Me.datagridPROVEEDORES.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.datagridPROVEEDORES.Columns(1).Width = 130
        Me.datagridPROVEEDORES.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.datagridPROVEEDORES.Columns(2).Width = 40
        Me.datagridPROVEEDORES.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.datagridPROVEEDORES.Columns(3).Width = 170
        'Me.datagridPROVEEDORES.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        'Me.datagridPROVEEDORES.Columns(6).Width = 170


        Me.datagridPROVEEDORES.ClearSelection()
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub grid_proveedores_export()
        Me.Cursor = Cursors.WaitCursor
        sql = "SELECT CONCAT(documento,' ', dv), tipodocumento as Tipodoc, nombre, razonsocial, telefono, ciudad, email, sitioweb FROM PROVEEDORES order by nombre asc"
        da = New MySqlDataAdapter(sql, conex)
        dt = New DataTable
        Try
            da.Fill(dt)
            Me.DataGrid_export.DataSource = dt
        Catch ex As Exception
            If ex.ToString.Contains("Duplicate entry") Then MsgBox("Ese proveedor ya se encuentra en la lista", vbExclamation)
            MsgBox(ex.ToString)
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()




        Me.DataGrid_export.ClearSelection()
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub button_salir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button_cancelar_Click(sender As Object, e As EventArgs) Handles Button_cancelar.Click
        Me.Panel4.Visible = True


        Me.Panel1.Visible = True
        Me.datagridPROVEEDORES.Visible = True


        Me.Button_guardar.Visible = False
        Me.Button_cancelar.Visible = False
        Me.datagridPROVEEDORES.Enabled = True
        ComboBox_tipodoc.Text = ""

        Me.TextBox_DOC.Text = ""
        Me.TextBox_fullname.Text = ""

        Me.TextBox_NOMBRE1.Text = ""
        Me.TextBox_NOMBRE2.Text = ""
        Me.TextBox_APELLIDO1.Text = ""
        Me.TextBox_APELLIDO2.Text = ""

        Me.TextBox_DOMICILIO.Text = ""
        Me.TextBox_TEL.Text = ""
        Me.TextBox_TEL2.Text = ""
        Me.TextBox_TEL3.Text = ""
        Me.TextBox_TEL4.Text = ""

        ComboBox_pais.Text = ""
        ComboBox_medioPAgo.Text = ""
        TextBox_cupoCredito.Text = "0"

        Me.TextBox_MAIL.Text = ""
        Me.Combo_naturaleza.Text = ""
        Me.ComboBox_tipocontribuyente.Text = ""
        Me.ComboBox_declarante.Text = ""
        Me.ComboBox_Agenteretenedor.Text = ""
        Me.ComboBox_autoretenedor.Text = ""
        proveedor_id = ""

        CheckBox_cliente.Checked = False
        CheckBox_otro.Checked = False
        CheckBox_proveedor.Checked = False

        grid_proveedores()

    End Sub

    Private Sub Button_guardar_Click(sender As Object, e As EventArgs) Handles Button_guardar.Click
        If Me.TextBox_DOC.Text = "" Then MsgBox("No escribió el documento.") : Exit Sub
        If Me.TextBox_dv.Text = "" Then MsgBox("No escribió el dígito de verificación.") : Exit Sub

        If CheckBox_proveedor.Checked = False And CheckBox_proveedor.Checked = False And CheckBox_otro.Checked = False Then
            MsgBox("Debe seleccionar el tipo de contacto: Cliente/Proveedor/Otro")
            Exit Sub
        End If


        Dim ES_CLIENTE, ES_PROVEEDOR, ES_OTRO, ES_RAZONSOCIAL, retemultiple As String
        ES_CLIENTE = ""
        ES_PROVEEDOR = ""
        ES_OTRO = ""

        ES_RAZONSOCIAL = ""

        retemultiple = ""

        If Me.CheckBox_proveedor.Checked = True Then ES_PROVEEDOR = "SI" Else ES_PROVEEDOR = "NO"
        If Me.CheckBox_proveedor.Checked = True Then ES_CLIENTE = "SI" Else ES_CLIENTE = "NO"
        If Me.CheckBox_otro.Checked = True Then ES_OTRO = "SI" Else ES_OTRO = "NO"

        ES_RAZONSOCIAL = ""

        retemultiple = ""


        Dim nombrecompleto As String = ""

        nombrecompleto = Trim(textbox_fullname.Text)


        'guardar
        If que_hace = "guardar" Then
            'se guarda
            sql = "INSERT INTO proveedores(documento, dv, TIPODOCUMENTO, tipocontribuyente, razonsocial, 
nombre, nombre1, nombre2, apellido1, apellido2, telefono, telefono2, telefono3, telefono4, direccion, ciudad, pais, email, SITIOWEB, observacion, 
naturaleza, declarante, autoretenedor, agenteretenedor, retemultiple, ecoactividad, cliente, proveedor, otro, fecha, contacto, mediopago, cupocredito, activo)
VALUES ('" & Me.TextBox_DOC.Text & "','" & CStr(Me.TextBox_dv.Text) & "','" & CStr(Me.ComboBox_tipodoc.Text) & "','" & CStr(Me.ComboBox_tipocontribuyente.Text) & "','" & ES_RAZONSOCIAL & "',
'" & CStr(nombrecompleto) & "','" & CStr(Me.TextBox_NOMBRE1.Text) & "','" & CStr(Me.TextBox_NOMBRE2.Text) & "','" & CStr(Me.TextBox_APELLIDO1.Text) & "','" & CStr(Me.TextBox_APELLIDO2.Text) & "',
'" & CStr(Me.TextBox_TEL.Text) & "','" & CStr(Me.TextBox_TEL2.Text) & "','" & CStr(Me.TextBox_TEL3.Text) & "','" & CStr(Me.TextBox_TEL4.Text) & "','" & CStr(Me.TextBox_DOMICILIO.Text) & "',
'" & CStr(Me.ComboBox_CIUDAD.Text) & "','" & CStr(Me.ComboBox_pais.Text) & "','" & CStr(Me.TextBox_MAIL.Text) & "','" & CStr(Me.TextBox_SITIOWEB.Text) & "','" & CStr(Me.Text_leyenda.Text) & "',
'" & CStr(Me.Combo_naturaleza.Text) & "','" & CStr(Me.ComboBox_declarante.Text) & "','" & CStr(Me.ComboBox_autoretenedor.Text) & "','" & CStr(Me.ComboBox_Agenteretenedor.Text) & "',
'" & retemultiple & "','" & ComboBox_ACTIVIDAD.Text & "','" & ES_CLIENTE & "','" & ES_PROVEEDOR & "','" & ES_OTRO & "','" & DateTimePicker1.Value.ToShortDateString & "',
'" & TextBox_contacto.Text & "','" & ComboBox_medioPAgo.Text & "','" & TextBox_cupoCredito.Text & "','" & ComboBox_activo.Text & "')"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
                ' MsgBox("Se restro la . ", vbInformation)
            Catch ex As Exception
                If ex.ToString.Contains("Duplicate") Then MsgBox("Ese contacto  ya se encuentra registrado", vbExclamation)
                If ex.ToString.Contains("Duplicata") Then MsgBox("Ese contacto ya se encuentra registrado", vbExclamation)
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()

            If viene_de <> "" Then
                Me.Close()
            End If
        End If



        If que_hace = "modificar" Then
            Me.Cursor = Cursors.WaitCursor

            sql = "UPDATE proveedores SET tIPODOCUMENTO='" & CStr(Me.ComboBox_tipodoc.Text) & "', tipocontribuyente='" & ComboBox_tipocontribuyente.Text & "', razonsocial='" & ES_RAZONSOCIAL & "', 
nombre='" & CStr(nombrecompleto) & "', nombre1='" & CStr(Me.TextBox_NOMBRE1.Text) & "', nombre2='" & CStr(Me.TextBox_NOMBRE2.Text) & "', 
apellido1='" & CStr(Me.TextBox_APELLIDO1.Text) & "', apellido2='" & CStr(Me.TextBox_APELLIDO2.Text) & "',
telefono='" & CStr(Me.TextBox_TEL.Text) & "', telefono2='" & CStr(Me.TextBox_TEL2.Text) & "', telefono3='" & CStr(Me.TextBox_TEL3.Text) & "', telefono4='" & CStr(Me.TextBox_TEL4.Text) & "', 
direccion='" & CStr(Me.TextBox_DOMICILIO.Text) & "', ciudad='" & CStr(Me.ComboBox_CIUDAD.Text) & "', pais='" & CStr(Me.ComboBox_pais.Text) & "', email='" & CStr(Me.TextBox_MAIL.Text) & "', SITIOWEB='" & CStr(Me.TextBox_SITIOWEB.Text) & "', observacion='" & CStr(Me.Text_leyenda.Text) & "', 
naturaleza='" & CStr(Me.Combo_naturaleza.Text) & "', declarante='" & CStr(Me.ComboBox_declarante.Text) & "', autoretenedor='" & CStr(Me.ComboBox_autoretenedor.Text) & "', agenteretenedor='" & CStr(Me.ComboBox_Agenteretenedor.Text) & "', retemultiple='" & retemultiple & "', Ecoactividad='" & ComboBox_ACTIVIDAD.Text & "',
cliente='" & CStr(ES_CLIENTE) & "', proveedor='" & CStr(ES_PROVEEDOR) & "', otro='" & CStr(ES_OTRO) & "', fecha='" & DateTimePicker1.Value.ToShortDateString & "', contacto='" & CStr(Me.TextBox_contacto.Text) & "', 
mediopago='" & CStr(Me.ComboBox_medioPAgo.Text) & "', cupocredito='" & CStr(Me.TextBox_cupoCredito.Text) & "', activo='" & CStr(ComboBox_activo.Text) & "'
WHERE cons=" & CInt(proveedor_id) & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
                ' MsgBox("Tarifa Actualizada.   :).", vbInformation)
            Catch ex As Exception
                If ex.ToString.Contains("Duplicate") Or ex.ToString.Contains("Duplicata") Then MsgBox("Ese contacto  ya se encuentra registrado", vbExclamation)
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()
        End If


        proveedor_id = ""
        Me.Panel1.Visible = True
        Me.datagridPROVEEDORES.Visible = True

        Me.TextBox_DOC.Text = ""
        Me.TextBox_DOMICILIO.Text = ""
        Me.TextBox_MAIL.Text = ""
        Me.TextBox_TEL.Text = ""
        Me.TextBox_NOMBRE1.Text = ""
        Me.TextBox_fullname.Text = ""
        Me.TextBox_NOMBRE2.Text = ""
        Me.TextBox_APELLIDO1.Text = ""
        Me.TextBox_APELLIDO2.Text = ""

        grid_proveedores()
        Me.Panel4.Visible = True


    End Sub

    Private Sub Form_clientes_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.datagridPROVEEDORES.BringToFront()



        'grid_proveedores()


    End Sub

    Private Sub TextBox_DOC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_DOC.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Try
            If IsNumeric(TextBox_buscar_cliente.Text) = False Then sql = "SELECT * FROM proveedores WHERE nombre LIKE '%" & Me.TextBox_buscar_cliente.Text.ToString & "%' order by nombre asc"
            If IsNumeric(TextBox_buscar_cliente.Text) = True Then sql = "SELECT * FROM proveedores WHERE documento=" & CInt(Me.TextBox_buscar_cliente.Text.ToString) & " order by nombre asc"

            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.datagridPROVEEDORES.DataSource = dt
            Me.datagridPROVEEDORES.Columns(0).Visible = False

            Me.datagridPROVEEDORES.Columns(4).Visible = False
            Me.datagridPROVEEDORES.Columns(5).Visible = False


            Me.datagridPROVEEDORES.Columns(7).Visible = False
            Me.datagridPROVEEDORES.Columns(8).Visible = False
            Me.datagridPROVEEDORES.Columns(9).Visible = False
            Me.datagridPROVEEDORES.Columns(10).Visible = False
            Me.datagridPROVEEDORES.Columns(11).Visible = False
            Me.datagridPROVEEDORES.Columns(12).Visible = False
            Me.datagridPROVEEDORES.Columns(13).Visible = False
            Me.datagridPROVEEDORES.Columns(14).Visible = False
            Me.datagridPROVEEDORES.Columns(15).Visible = False
            Me.datagridPROVEEDORES.Columns(16).Visible = False
            Me.datagridPROVEEDORES.Columns(17).Visible = False
            Me.datagridPROVEEDORES.Columns(18).Visible = False
            Me.datagridPROVEEDORES.Columns(19).Visible = False
            Me.datagridPROVEEDORES.Columns(20).Visible = False
            Me.datagridPROVEEDORES.Columns(21).Visible = False
            Me.datagridPROVEEDORES.Columns(22).Visible = False
            Me.datagridPROVEEDORES.Columns(23).Visible = False
            Me.datagridPROVEEDORES.Columns(24).Visible = False
            Me.datagridPROVEEDORES.Columns(25).Visible = False
            Me.datagridPROVEEDORES.Columns(26).Visible = False
            Me.datagridPROVEEDORES.Columns(27).Visible = False
            Me.datagridPROVEEDORES.Columns(28).Visible = False
            Me.datagridPROVEEDORES.Columns(29).Visible = False
            Me.datagridPROVEEDORES.Columns(30).Visible = False
            Me.datagridPROVEEDORES.Columns(31).Visible = False
            Me.datagridPROVEEDORES.Columns(32).Visible = False

            Me.datagridPROVEEDORES.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagridPROVEEDORES.Columns(1).Width = 130
            Me.datagridPROVEEDORES.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.datagridPROVEEDORES.Columns(2).Width = 40
            Me.datagridPROVEEDORES.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagridPROVEEDORES.Columns(3).Width = 200
            'Me.datagridPROVEEDORES.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            'Me.datagridPROVEEDORES.Columns(6).Width = 170
            Me.datagridPROVEEDORES.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message)
            End Try
            conex.Close()
            da.Dispose()
            dt.Dispose()
            conex.Close()




    End Sub

    Private Sub Button_modificar_Click_1(sender As Object, e As EventArgs) Handles Button_modificar.Click
        'If PERMISO_1(25) = "NO" Or PERMISO_1(25) = Nothing Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub


        If proveedor_id = "" Then MsgBox("Seleccione un Proveedor.", vbInformation) : Exit Sub

        que_hace = "modificar"
        Me.Panel1.Visible = False

        If proveedor_id <> "" Then
            Me.Panel1.Visible = False
            Me.datagridPROVEEDORES.Visible = False

            Me.Button_guardar.Visible = True
            Me.Button_cancelar.Visible = True
        End If

        Me.Panel4.Visible = False

    End Sub

    Private Sub Button_eliminar_Click_1(sender As Object, e As EventArgs) Handles Button_eliminar.Click
        'If PERMISO_1(26) = "NO" Or PERMISO_1(26) = Nothing Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub


        If proveedor_id = "" Then MsgBox("Seleccione un contacto de la lista.", vbInformation) : Exit Sub

        Dim RTA As String
        RTA = MsgBox("Desea eliminar el proveedor:     " & Me.TextBox_NOMBRE1.Text, MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If RTA = 6 Then
            sql = "delete from proveedores where cons=" & CInt(proveedor_id) & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
                MsgBox("Se Borró el contacto.")
            Catch ex As Exception
                MsgBox("error BORRANDO.")
                Exit Sub
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()

        End If
        Me.Button_cancelar_Click(Nothing, Nothing)
    End Sub

    Private Sub Button_export_pdf_Click(sender As Object, e As EventArgs) Handles Button_export_pdf.Click
        grid_proveedores_export()

        Try
            'Intentar generar el documento.
            Dim doc As New Document(PageSize.LEGAL.Rotate, 10, 10, 10, 10)
            'Path que guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Lista de Contactos.pdf"
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
        Dim datatable As New PdfPTable(DataGrid_export.ColumnCount)
        'Se asignan algunas propiedades para el diseño del PDF.
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(DataGrid_export)
        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
        'Se crea el encabezado en el PDF.
        Dim encabezado As New Paragraph(comex_nombrecomercial, New Font(Font.Name = "Arial", 12, Font.Bold))
        Dim encabezado2 As New Paragraph("Listado de Contactos", New Font(Font.Name = "Arial", 12, Font.Bold))

        'Se crea el texto abajo del encabezado.
        Dim texto As New Phrase("Fecha del Reporte:" + Now.Date(), New Font(Font.Name = "Tahoma", 10, Font.Bold))
        Dim texto2 As New Phrase("Generado Por:" + USR_NOM, New Font(Font.Name = "Tahoma", 10, Font.Bold))

        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To DataGrid_export.ColumnCount - 1
            Dim cellhdr As New PdfPCell(New Phrase(DataGrid_export.Columns(i).HeaderText, New Font(Font.Name = "Arial", 10.0F, FontStyle.Bold)))
            'datatable.AddCell(MetroGrid_pdf.Columns(i).HeaderText)
            cellhdr.HorizontalAlignment = Element.ALIGN_CENTER
            cellhdr.BackgroundColor = BaseColor.LIGHT_GRAY
            datatable.AddCell(cellhdr)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1
        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To DataGrid_export.RowCount - 1
            For j As Integer = 0 To DataGrid_export.ColumnCount - 1

                Dim cell As New PdfPCell
                cell.Phrase = New Phrase(DataGrid_export(j, i).Value.ToString, New Font(Font.Name = "Arial Narrow", 8, Font.Bold = False))
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
        'Se agrega el PDFTable al documento.
        document.Add(encabezado)
        document.Add(encabezado2)
        document.Add(texto)


        document.Add(datatable)
    End Sub

    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        'funcion para obtener el tamaño de la columnas del datagridview
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function



    Private Sub button_crear_Click(sender As Object, e As EventArgs) Handles button_crear.Click

        'If PERMISO_1(24) = "NO" Or PERMISO_1(24) = Nothing Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub


        que_hace = "guardar"

        Me.CheckBox_cliente.Checked = True
        Me.CheckBox_proveedor.Checked = True
        Me.CheckBox_otro.Checked = True

        Me.Panel1.Visible = False
        Me.datagridPROVEEDORES.Visible = False

        Me.Button_guardar.Visible = True
        Me.Button_cancelar.Visible = True

        proveedor_id = ""
        Me.TextBox_DOC.Text = ""
        Me.TextBox_dv.Text = ""

        Me.TextBox_fullname.Text = ""

        Me.TextBox_NOMBRE1.Text = ""
        Me.TextBox_NOMBRE2.Text = ""
        Me.TextBox_APELLIDO1.Text = ""
        Me.TextBox_APELLIDO2.Text = ""


        Me.TextBox_DOMICILIO.Text = ""
        Me.ComboBox_tipodoc.Text = "Cédula de Ciudadanía"
        Me.ComboBox_CIUDAD.Text = ""

        Me.Combo_naturaleza.Text = "Persona Natural"
        Me.ComboBox_tipocontribuyente.Text = ""
        Me.ComboBox_declarante.Text = ""
        Me.ComboBox_Agenteretenedor.Text = ""
        Me.ComboBox_autoretenedor.Text = ""

        Me.TextBox_TEL.Text = ""
        Me.TextBox_MAIL.Text = ""
        Me.TextBox_TEL2.Text = ""
        Me.TextBox_TEL3.Text = ""
        Me.TextBox_TEL4.Text = ""

        Me.TextBox_SITIOWEB.Text = ""

        Me.Text_leyenda.Text = ""
        Me.Panel4.Visible = False
        consecutivo = 0

        'consecutivo compras
        consecutivo = 0
        cmd.Connection = conex
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select max(cons) +1 from proveedores"
        conex.Open()
        Try
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                consecutivo = dr(0)
            Else
                consecutivo = 1
            End If
        Catch ex As Exception
            consecutivo = 1
            conex.Close()
        End Try
        conex.Close()



        ComboBox_ACTIVIDAD.SelectedItem = Nothing


        TextBox_DOC.Focus()

        CheckBox_cliente.Enabled = True
        CheckBox_proveedor.Enabled = True
        CheckBox_otro.Enabled = True

        TextBox1.Text = 0
    End Sub

    Private Sub datagridPROVEEDORES_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridPROVEEDORES.CellClick
        Dim row As DataGridViewRow = datagridPROVEEDORES.CurrentRow

        If row.Cells("CLIENTE").Value = "SI" Then Me.CheckBox_cliente.Checked = True : tipo_contacto_CLI = "SI" Else Me.CheckBox_cliente.Checked = False : tipo_contacto_CLI = "NO"
        If row.Cells("PROVEEDOR").Value = "SI" Then Me.CheckBox_proveedor.Checked = True : tipo_contacto_PROV = "SI" Else Me.CheckBox_proveedor.Checked = False : tipo_contacto_PROV = "NO"
        If row.Cells("OTRO").Value = "SI" Then Me.CheckBox_otro.Checked = True : tipo_contacto_otro = "SI" Else Me.CheckBox_otro.Checked = False : tipo_contacto_otro = "NO"



        proveedor_id = CInt(row.Cells("cons").Value)

        TextBox_DOC.Text = CStr(row.Cells("documento").Value)
        TextBox_dv.Text = CStr(row.Cells("dv").Value)
        ComboBox_tipodoc.Text = CStr(row.Cells("tipodocumento").Value)
        Me.ComboBox_tipocontribuyente.Text = CStr(row.Cells("tipocontribuyente").Value)


        textbox_fullname.Text = CStr(row.Cells("nombre").Value)

        Me.TextBox_NOMBRE1.Text = CStr(row.Cells("nombre1").Value)
        Me.TextBox_NOMBRE2.Text = CStr(row.Cells("nombre2").Value)
        Me.TextBox_APELLIDO1.Text = CStr(row.Cells("apellido1").Value)
        Me.TextBox_APELLIDO2.Text = CStr(row.Cells("apellido2").Value)


        Me.TextBox_TEL.Text = CStr(row.Cells("telefono").Value)
        Me.TextBox_TEL2.Text = CStr(row.Cells("telefono2").Value)
        Me.TextBox_TEL3.Text = CStr(row.Cells("telefono3").Value)
        Me.TextBox_TEL4.Text = CStr(row.Cells("telefono4").Value)


        Me.TextBox_DOMICILIO.Text = CStr(row.Cells("direccion").Value)
        Me.ComboBox_pais.Text = CStr(row.Cells("pais").Value)
        Me.ComboBox_CIUDAD.Text = CStr(row.Cells("ciudad").Value)


        Me.Combo_naturaleza.Text = CStr(row.Cells("naturaleza").Value)
        Me.ComboBox_declarante.Text = CStr(row.Cells("declarante").Value)
        Me.ComboBox_Agenteretenedor.Text = CStr(row.Cells("autoretenedor").Value)
        Me.ComboBox_autoretenedor.Text = CStr(row.Cells("agenteretenedor").Value)

        Me.Text_leyenda.Text = CStr(row.Cells("observacion").Value)
        Me.TextBox_SITIOWEB.Text = CStr(row.Cells("sitioweb").Value)
        Me.TextBox_MAIL.Text = CStr(row.Cells("email").Value)

        Me.TextBox1.Text = CStr(row.Cells("puntos").Value)


        If IsDate(row.Cells("fecha").Value) = True Then Me.DateTimePicker1.Value = row.Cells("fecha").Value

        Me.TextBox_contacto.Text = CStr(row.Cells("contacto").Value)
        Me.ComboBox_medioPAgo.Text = CStr(row.Cells("mediopago").Value)
        Me.TextBox_cupoCredito.Text = CStr(row.Cells("cupocredito").Value)

        Me.ComboBox_activo.Text = CStr(row.Cells("activo").Value)





    End Sub

    Private Sub datagridPROVEEDORES_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridPROVEEDORES.CellContentClick

    End Sub





    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub Form_proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BringToFront()

    End Sub

    Private Sub datagridPROVEEDORES_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles datagridPROVEEDORES.CellFormatting


    End Sub

    Private Sub TextBox_buscar_cliente_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub TextBox_dv_TextChanged(sender As Object, e As EventArgs) Handles TextBox_dv.TextChanged

    End Sub

    Private Sub TextBox_dv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_dv.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""

    End Sub

    Private Sub TextBox_DOC_TextChanged(sender As Object, e As EventArgs) Handles TextBox_DOC.TextChanged
        If TextBox_DOC.Text = "" Then
            TextBox_dv.Text = "0"
            Exit Sub
        End If


        If TextBox_DOC.Text <> "" Then
            TextBox_DOC_LostFocus(Nothing, Nothing)

        End If
    End Sub




    Private Sub Label10_Click_1(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub ComboBox_tipocontribuyente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_tipocontribuyente.SelectedIndexChanged

    End Sub

    Private Sub Combo_naturaleza_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_naturaleza.SelectedIndexChanged

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub






    Private Sub Timer_nuevo_Tick(sender As Object, e As EventArgs) Handles Timer_nuevo.Tick
        Me.Timer_nuevo.Enabled = False

        Me.button_crear_Click(Nothing, Nothing)

        viene_de = "movimientos de inventario"


    End Sub

    Private Sub ComboBox_ruta_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox_ruta_KeyPress(sender As Object, e As KeyPressEventArgs)
        'e.KeyChar = ""
    End Sub



    Private Sub Label24_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub Panel_titlebar_Paint(sender As Object, e As PaintEventArgs) Handles Panel_titlebar.Paint

    End Sub





    Private Sub TextBox_dv_DoubleClick(sender As Object, e As EventArgs) Handles TextBox_dv.DoubleClick


        If TextBox_DOC.Text <> "" Then

            Dim NIT As String = TextBox_DOC.Text
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

            If RESIDUO > 1 Then
                TextBox_dv.Text = Convert.ToString(11 - RESIDUO)
            End If
        End If



    End Sub

    Private Sub TextBox_dv_DragDrop(sender As Object, e As DragEventArgs) Handles TextBox_dv.DragDrop

    End Sub





    Private Sub ComboBox_CIUDAD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_CIUDAD.SelectedIndexChanged

    End Sub

    Private Sub ComboBox_CIUDAD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox_CIUDAD.KeyPress
        If ComboBox_CIUDAD.DroppedDown = True Then
            ComboBox_CIUDAD.DroppedDown = False
        End If
    End Sub

    Private Sub CheckBox_OTRO_OnChange(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox_DOC_GotFocus(sender As Object, e As EventArgs) Handles TextBox_DOC.GotFocus
        TextBox_DOC.BackColor = Color.MistyRose
    End Sub

    Private Sub TextBox_DOC_LostFocus(sender As Object, e As EventArgs) Handles TextBox_DOC.LostFocus
        'TextBox_DOC.BackColor = Color.Lavender

        'If TextBox_DOC.Text <> "" And IsNumeric(TextBox_DOC.Text) = True Then

        '    Dim NIT As String = TextBox_DOC.Text
        '    Dim TEMP As String = ""
        '    Dim RESIDUO As Integer = 0
        '    Dim ACUMULADOR As Integer = 0
        '    Dim VECTOR(15) As Integer

        '    VECTOR(0) = 3
        '    VECTOR(1) = 7
        '    VECTOR(2) = 13
        '    VECTOR(3) = 17
        '    VECTOR(4) = 19
        '    VECTOR(5) = 23
        '    VECTOR(6) = 29
        '    VECTOR(7) = 37
        '    VECTOR(8) = 41
        '    VECTOR(9) = 43
        '    VECTOR(10) = 47
        '    VECTOR(11) = 53
        '    VECTOR(12) = 59
        '    VECTOR(13) = 67
        '    VECTOR(14) = 71

        '    For CONTADOR As Integer = 0 To CInt(NIT.Length)
        '        If CONTADOR = CInt(NIT.Length) Then
        '            Exit For
        '        End If
        '        TEMP = NIT((NIT.Length - 1) - CONTADOR).ToString()
        '        ACUMULADOR = ACUMULADOR + (Convert.ToInt32(TEMP) * VECTOR(CONTADOR))

        '    Next

        '    RESIDUO = ACUMULADOR Mod 11
        '    TextBox_dv.Text = RESIDUO

        '    If RESIDUO > 1 Then
        '        TextBox_dv.Text = Convert.ToString(11 - RESIDUO)
        '    End If
        'End If
    End Sub
    Private Sub TextBox_dv_GotFocus(sender As Object, e As EventArgs) Handles TextBox_dv.GotFocus

        TextBox_dv.BackColor = Color.MistyRose

        If IsNumeric(TextBox_DOC.Text) = True Then

            Dim NIT As String = TextBox_DOC.Text
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
            TextBox_dv.Text = RESIDUO

            If RESIDUO > 1 Then
                TextBox_dv.Text = Convert.ToString(11 - RESIDUO)
            End If
        End If
    End Sub
    Private Sub TextBox_dv_LostFocus(sender As Object, e As EventArgs) Handles TextBox_dv.LostFocus
        TextBox_dv.BackColor = Color.Lavender

    End Sub

    Private Sub ComboBox_tipodoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_tipodoc.SelectedIndexChanged

    End Sub

    Private Sub ComboBox_tipodoc_GotFocus(sender As Object, e As EventArgs) Handles ComboBox_tipodoc.GotFocus
        ComboBox_tipodoc.BackColor = Color.MistyRose

    End Sub

    Private Sub ComboBox_tipodoc_LostFocus(sender As Object, e As EventArgs) Handles ComboBox_tipodoc.LostFocus
        ComboBox_tipodoc.BackColor = Color.White

    End Sub





    Private Sub Combo_naturaleza_GotFocus(sender As Object, e As EventArgs) Handles Combo_naturaleza.GotFocus
        Combo_naturaleza.BackColor = Color.MistyRose

    End Sub

    Private Sub Combo_naturaleza_LostFocus(sender As Object, e As EventArgs) Handles Combo_naturaleza.LostFocus
        Combo_naturaleza.BackColor = Color.White

    End Sub

    Private Sub ComboBox_tipocontribuyente_GotFocus(sender As Object, e As EventArgs) Handles ComboBox_tipocontribuyente.GotFocus
        ComboBox_tipocontribuyente.BackColor = Color.MistyRose

    End Sub

    Private Sub ComboBox_tipocontribuyente_LostFocus(sender As Object, e As EventArgs) Handles ComboBox_tipocontribuyente.LostFocus
        ComboBox_tipocontribuyente.BackColor = Color.White

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub DateTimePicker1_GotFocus(sender As Object, e As EventArgs) Handles DateTimePicker1.GotFocus
        DateTimePicker1.BackColor = Color.MistyRose

    End Sub

    Private Sub DateTimePicker1_LostFocus(sender As Object, e As EventArgs) Handles DateTimePicker1.LostFocus
        DateTimePicker1.BackColor = Color.White

    End Sub





    Private Sub TextBox_NOMBRE1_TextChanged(sender As Object, e As EventArgs) Handles TextBox_NOMBRE1.TextChanged

    End Sub

    Private Sub TextBox_NOMBRE1_GotFocus(sender As Object, e As EventArgs) Handles TextBox_NOMBRE1.GotFocus
        TextBox_NOMBRE1.BackColor = Color.MistyRose

    End Sub

    Private Sub TextBox_NOMBRE2_TextChanged(sender As Object, e As EventArgs) Handles TextBox_NOMBRE2.TextChanged

    End Sub

    Private Sub TextBox_NOMBRE2_LostFocus(sender As Object, e As EventArgs) Handles TextBox_NOMBRE2.LostFocus
        TextBox_NOMBRE2.BackColor = Color.Lavender

    End Sub

    Private Sub TextBox_APELLIDO1_TextChanged(sender As Object, e As EventArgs) Handles TextBox_APELLIDO1.TextChanged

    End Sub

    Private Sub TextBox_APELLIDO1_GotFocus(sender As Object, e As EventArgs) Handles TextBox_APELLIDO1.GotFocus
        TextBox_APELLIDO1.BackColor = Color.MistyRose

    End Sub

    Private Sub TextBox_APELLIDO1_LostFocus(sender As Object, e As EventArgs) Handles TextBox_APELLIDO1.LostFocus
        TextBox_APELLIDO1.BackColor = Color.Lavender

    End Sub

    Private Sub TextBox_APELLIDO2_TextChanged(sender As Object, e As EventArgs) Handles TextBox_APELLIDO2.TextChanged

    End Sub

    Private Sub TextBox_APELLIDO2_GotFocus(sender As Object, e As EventArgs) Handles TextBox_APELLIDO2.GotFocus
        TextBox_APELLIDO2.BackColor = Color.MistyRose

    End Sub

    Private Sub TextBox_APELLIDO2_LostFocus(sender As Object, e As EventArgs) Handles TextBox_APELLIDO2.LostFocus
        TextBox_APELLIDO2.BackColor = Color.Lavender

    End Sub

    Private Sub ComboBox_declarante_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_declarante.SelectedIndexChanged

    End Sub

    Private Sub ComboBox_declarante_GotFocus(sender As Object, e As EventArgs) Handles ComboBox_declarante.GotFocus
        ComboBox_declarante.BackColor = Color.MistyRose

    End Sub

    Private Sub ComboBox_declarante_LostFocus(sender As Object, e As EventArgs) Handles ComboBox_declarante.LostFocus
        ComboBox_declarante.BackColor = Color.White

    End Sub

    Private Sub ComboBox_RfuenteCompras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_autoretenedor.SelectedIndexChanged

    End Sub










    Private Sub Label24_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox_NOMBRE1_LostFocus(sender As Object, e As EventArgs) Handles TextBox_NOMBRE1.LostFocus
        TextBox_NOMBRE1.BackColor = Color.Lavender

    End Sub

    Private Sub TextBox_NOMBRE2_GotFocus(sender As Object, e As EventArgs) Handles TextBox_NOMBRE2.GotFocus

        TextBox_NOMBRE2.BackColor = Color.MistyRose

    End Sub



    Private Sub TextBox_Numero_id_fiscal_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Numero_id_fiscal.TextChanged

    End Sub

    Private Sub TextBox_Numero_id_fiscal_GotFocus(sender As Object, e As EventArgs) Handles TextBox_Numero_id_fiscal.GotFocus
        TextBox_Numero_id_fiscal.BackColor = Color.MistyRose

    End Sub

    Private Sub TextBox_Numero_id_fiscal_LostFocus(sender As Object, e As EventArgs) Handles TextBox_Numero_id_fiscal.LostFocus
        TextBox_Numero_id_fiscal.BackColor = Color.White

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_ACTIVIDAD.SelectedIndexChanged

    End Sub



    Private Sub TextBox_DOMICILIO_TextChanged(sender As Object, e As EventArgs) Handles TextBox_DOMICILIO.TextChanged

    End Sub

    Private Sub TextBox_DOMICILIO_GotFocus(sender As Object, e As EventArgs) Handles TextBox_DOMICILIO.GotFocus
        TextBox_DOMICILIO.BackColor = Color.MistyRose

    End Sub

    Private Sub TextBox_DOMICILIO_LostFocus(sender As Object, e As EventArgs) Handles TextBox_DOMICILIO.LostFocus
        TextBox_DOMICILIO.BackColor = Color.White

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox_pais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_pais.SelectedIndexChanged

    End Sub

    Private Sub ComboBox_pais_GotFocus(sender As Object, e As EventArgs) Handles ComboBox_pais.GotFocus
        ComboBox_pais.BackColor = Color.MistyRose

    End Sub

    Private Sub ComboBox_pais_LostFocus(sender As Object, e As EventArgs) Handles ComboBox_pais.LostFocus
        ComboBox_pais.BackColor = Color.White

    End Sub

    Private Sub ComboBox_CIUDAD_GotFocus(sender As Object, e As EventArgs) Handles ComboBox_CIUDAD.GotFocus
        ComboBox_CIUDAD.BackColor = Color.MistyRose
    End Sub

    Private Sub ComboBox_CIUDAD_LostFocus(sender As Object, e As EventArgs) Handles ComboBox_CIUDAD.LostFocus
        ComboBox_CIUDAD.BackColor = Color.White

    End Sub

    Private Sub MetroGrid_actividades_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub



    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub







    Private Sub ComboBox_autoretenedor_GotFocus(sender As Object, e As EventArgs) Handles ComboBox_autoretenedor.GotFocus
        ComboBox_autoretenedor.BackColor = Color.MistyRose
    End Sub

    Private Sub ComboBox_autoretenedor_LostFocus(sender As Object, e As EventArgs) Handles ComboBox_autoretenedor.LostFocus
        ComboBox_autoretenedor.BackColor = Color.White
    End Sub

    Private Sub ComboBox_Agenteretenedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Agenteretenedor.SelectedIndexChanged

    End Sub

    Private Sub ComboBox_Agenteretenedor_GotFocus(sender As Object, e As EventArgs) Handles ComboBox_Agenteretenedor.GotFocus
        ComboBox_Agenteretenedor.BackColor = Color.MistyRose

    End Sub

    Private Sub ComboBox_Agenteretenedor_LostFocus(sender As Object, e As EventArgs) Handles ComboBox_Agenteretenedor.LostFocus
        ComboBox_Agenteretenedor.BackColor = Color.White

    End Sub

    Private Sub ComboBox_ACTIVIDAD_GotFocus(sender As Object, e As EventArgs) Handles ComboBox_ACTIVIDAD.GotFocus
        ComboBox_ACTIVIDAD.BackColor = Color.MistyRose
    End Sub

    Private Sub ComboBox_ACTIVIDAD_LostFocus(sender As Object, e As EventArgs) Handles ComboBox_ACTIVIDAD.LostFocus
        ComboBox_ACTIVIDAD.BackColor = Color.White

    End Sub

    Private Sub TextBox_TEL_TextChanged(sender As Object, e As EventArgs) Handles TextBox_TEL.TextChanged

    End Sub

    Private Sub TextBox_TEL_HandleCreated(sender As Object, e As EventArgs) Handles TextBox_TEL.HandleCreated

    End Sub

    Private Sub TextBox_TEL_GotFocus(sender As Object, e As EventArgs) Handles TextBox_TEL.GotFocus
        TextBox_TEL.BackColor = Color.MistyRose

    End Sub

    Private Sub TextBox_TEL_LostFocus(sender As Object, e As EventArgs) Handles TextBox_TEL.LostFocus
        TextBox_TEL.BackColor = Color.White

    End Sub

    Private Sub TextBox_TEL2_TextChanged(sender As Object, e As EventArgs) Handles TextBox_TEL2.TextChanged

    End Sub

    Private Sub TextBox_TEL2_GotFocus(sender As Object, e As EventArgs) Handles TextBox_TEL2.GotFocus
        TextBox_TEL2.BackColor = Color.MistyRose

    End Sub

    Private Sub TextBox_TEL2_LostFocus(sender As Object, e As EventArgs) Handles TextBox_TEL2.LostFocus
        TextBox_TEL2.BackColor = Color.White

    End Sub

    Private Sub TextBox_TEL3_TextChanged(sender As Object, e As EventArgs) Handles TextBox_TEL3.TextChanged

    End Sub

    Private Sub TextBox_TEL3_GotFocus(sender As Object, e As EventArgs) Handles TextBox_TEL3.GotFocus
        TextBox_TEL3.BackColor = Color.MistyRose

    End Sub

    Private Sub TextBox_TEL3_LostFocus(sender As Object, e As EventArgs) Handles TextBox_TEL3.LostFocus
        TextBox_TEL3.BackColor = Color.White

    End Sub

    Private Sub TextBox_TEL4_TextChanged(sender As Object, e As EventArgs) Handles TextBox_TEL4.TextChanged

    End Sub

    Private Sub TextBox_TEL4_GotFocus(sender As Object, e As EventArgs) Handles TextBox_TEL4.GotFocus
        TextBox_TEL4.BackColor = Color.MistyRose

    End Sub

    Private Sub TextBox_TEL4_LostFocus(sender As Object, e As EventArgs) Handles TextBox_TEL4.LostFocus
        TextBox_TEL4.BackColor = Color.White

    End Sub

    Private Sub TextBox_MAIL_TextChanged(sender As Object, e As EventArgs) Handles TextBox_MAIL.TextChanged

    End Sub

    Private Sub TextBox_MAIL_GotFocus(sender As Object, e As EventArgs) Handles TextBox_MAIL.GotFocus
        TextBox_MAIL.BackColor = Color.MistyRose

    End Sub

    Private Sub TextBox_MAIL_LostFocus(sender As Object, e As EventArgs) Handles TextBox_MAIL.LostFocus
        TextBox_MAIL.BackColor = Color.White

    End Sub

    Private Sub TextBox_SITIOWEB_TextChanged(sender As Object, e As EventArgs) Handles TextBox_SITIOWEB.TextChanged

    End Sub

    Private Sub TextBox_SITIOWEB_LostFocus(sender As Object, e As EventArgs) Handles TextBox_SITIOWEB.LostFocus
        TextBox_SITIOWEB.BackColor = Color.MistyRose

    End Sub

    Private Sub TextBox_SITIOWEB_GotFocus(sender As Object, e As EventArgs) Handles TextBox_SITIOWEB.GotFocus
        TextBox_SITIOWEB.BackColor = Color.White

    End Sub

    Private Sub Text_leyenda_TextChanged(sender As Object, e As EventArgs) Handles Text_leyenda.TextChanged

    End Sub

    Private Sub Text_leyenda_GotFocus(sender As Object, e As EventArgs) Handles Text_leyenda.GotFocus
        Text_leyenda.BackColor = Color.MistyRose

    End Sub

    Private Sub Text_leyenda_LostFocus(sender As Object, e As EventArgs) Handles Text_leyenda.LostFocus
        Text_leyenda.BackColor = Color.White

    End Sub

    Private Sub TextBox_contacto_TextChanged(sender As Object, e As EventArgs) Handles TextBox_contacto.TextChanged

    End Sub

    Private Sub TextBox_contacto_GotFocus(sender As Object, e As EventArgs) Handles TextBox_contacto.GotFocus
        TextBox_contacto.BackColor = Color.MistyRose

    End Sub

    Private Sub TextBox_contacto_LostFocus(sender As Object, e As EventArgs) Handles TextBox_contacto.LostFocus
        TextBox_contacto.BackColor = Color.White

    End Sub

    Private Sub ComboBox_medioPAgo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_medioPAgo.SelectedIndexChanged

    End Sub

    Private Sub ComboBox_medioPAgo_GotFocus(sender As Object, e As EventArgs) Handles ComboBox_medioPAgo.GotFocus
        ComboBox_medioPAgo.BackColor = Color.MistyRose

    End Sub

    Private Sub ComboBox_medioPAgo_LostFocus(sender As Object, e As EventArgs) Handles ComboBox_medioPAgo.LostFocus
        ComboBox_medioPAgo.BackColor = Color.White

    End Sub

    Private Sub TextBox_cupoCredito_TextChanged(sender As Object, e As EventArgs) Handles TextBox_cupoCredito.TextChanged

    End Sub

    Private Sub TextBox_cupoCredito_GotFocus(sender As Object, e As EventArgs) Handles TextBox_cupoCredito.GotFocus
        ComboBox_medioPAgo.BackColor = Color.MistyRose

    End Sub

    Private Sub TextBox_cupoCredito_LostFocus(sender As Object, e As EventArgs) Handles TextBox_cupoCredito.LostFocus
        ComboBox_medioPAgo.BackColor = Color.White

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        'If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""
        e.KeyChar = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sql = "UPDATE proveedores SET puntos=0 WHERE cons=" & CInt(proveedor_id) & ""
        da = New MySqlDataAdapter(sql, conex)
        dt = New DataTable
        Try
            da.Fill(dt)
            ' MsgBox("Tarifa Actualizada.   :).", vbInformation)
        Catch ex As Exception

        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()

        TextBox1.Text = 0
    End Sub

    Private Sub TextBox_buscar_cliente_OnValueChanged(sender As Object, e As EventArgs) Handles TextBox_buscar_cliente.OnValueChanged

    End Sub

    Private Sub TextBox_buscar_cliente_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_buscar_cliente.KeyDown
        If e.KeyCode = "13" Then
            Button2_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub Button_cerrar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox_cliente_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_cliente.CheckedChanged

    End Sub
End Class