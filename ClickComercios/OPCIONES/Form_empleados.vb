Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class Form_empleados
    Dim MEDIO_PAGO_DESTINO_COD, MEDIO_PAGO_DESTINO_NOMBRE, MEDIO_PAGO_DESTINO_TIPO As String
    Dim cod_permiso_emp As String = ""
    Dim estado_permiso_emp As String = ""
    Dim COD_PERMISONOMBRE_emp As String = ""
    Dim COD_MODULO_emp As String = ""



    Dim cod_permiso_general As String = ""
    Dim modulo_general As String = ""

    Dim COD_PERMISONOMBRE_general As String
    Dim estado_permiso_general As String = ""




    Dim cod_emp_mpago As String = ""
    Dim cod_MEDIO As String = ""

    Dim que_hace As String = ""
    Dim empleado_id As String = ""
    Dim ACCESO_SISTEM As Integer = 0

    Dim modulo_sel As String = ""

    Public da_grid_pdf As MySqlDataAdapter
    Public dt_grid_pdf As DataTable

    Public da_grid_emp As MySqlDataAdapter
    Public dt_grid_emp As DataTable

    Public da_permisos_general As MySqlDataAdapter
    Public dt_permisos_general As DataTable

    Public da_permisos_emp As MySqlDataAdapter
    Public dt_permisos_emp As DataTable


    Private Sub Form_empleados_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'EffectOut("Form_empleados")

    End Sub
    Private Sub Form_empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MetroTabControl1.SendToBack()
        datagridempleados.BringToFront()
    End Sub
    Private Sub grid_empleados()
        Me.Cursor = Cursors.WaitCursor
        sql = "SELECT * FROM empleados where cons<>1"
        da_emplist = New MySqlDataAdapter(sql, conex)
        dt_emplist = New DataTable
        Try
            da_emplist.Fill(dt_emplist)
            Me.datagridempleados.DataSource = dt_emplist


        Catch ex As Exception
            If ex.ToString.Contains("Duplicate entry") Then MsgBox("Ese empleado ya se encuentra en la lista", vbExclamation)
            MsgBox(ex.ToString)
        End Try
        da_emplist.Dispose()
        dt_emplist.Dispose()
        conex.Close()
        datagridempleados.ClearSelection()
        Me.Cursor = Cursors.Default
    End Sub



    Private Sub button_crear_Click(sender As Object, e As EventArgs) Handles button_crear.Click
        que_hace = "guardar"
        Me.Panel1.Visible = False

        Me.Panel4.Visible = False
        Me.datagridempleados.Visible = False

        Me.Button_guardar.Visible = True
        Me.Button_cancelar.Visible = True
        Me.Button_export_pdf.Visible = False

        empleado_id = ""
        Me.TextBox_DOC.Text = ""
        Me.TextBox_NOMBRE.Text = ""
        Me.TextBox_DOMICILIO.Text = ""
        Me.TextBox_TEL.Text = ""
        Me.TextBox_celular.Text = ""

        Me.TextBox_MAIL.Text = ""
        TextBox_password.Text = ""
        TextBox_salario.Text = ""
        MetroComboBox_estado.Text = "ACTIVO"
        ACCESO_SISTEM = 0

        'consecutivo compras
        consecutivo = 0
        cmd.Connection = conex
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select max(cons) +1 from empleados"
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

        Me.MetroTabControl1.SelectTab(0)
        Me.MetroTabPage2.Hide()
        Me.MetroTabPage2.Parent = Nothing


        TextBox_DOC.Focus()

        Panel4.Visible = False

        TextBox_NOMBRE.Text = ""
    End Sub

    Private Sub Button_modificar_Click(sender As Object, e As EventArgs) Handles Button_modificar.Click
        If empleado_id = "123456789" Then
            MsgBox("Seleccione un Empleado.", vbInformation)
            Exit Sub
        End If
        If empleado_id = "" Then
            MsgBox("Seleccione un Empleado", vbInformation)
            Me.Panel1.Visible = True
            Me.datagridempleados.Visible = True
            Me.Button_export_pdf.Visible = True
            Exit Sub
        End If

        Me.MetroTabControl1.SelectTab(0)

        If USRCARGO = "Administrador" Or USRCARGO = "Administrador Sistema" Or USRCARGO = "Soporte técnico" Or USRCARGO = "Administrador Local" Then
            Me.MetroTabPage2.Show()
            Me.MetroTabPage2.Parent = Me.MetroTabControl1
        Else
            Me.MetroTabPage2.Hide()
            Me.MetroTabPage2.Parent = Nothing
        End If

        que_hace = "modificar"
        Me.Panel1.Visible = False



        If empleado_id <> "" Then
            Me.Panel1.Visible = False
            Me.datagridempleados.Visible = False
            Me.MetroTabPage2.Enabled = True
            Me.Button_guardar.Visible = True
            Me.Button_cancelar.Visible = True
            Me.Button_export_pdf.Visible = False

            Me.MetroTabControl1.SelectTab(0)

        End If








        Panel4.Visible = False

    End Sub



    Private Sub Button_cancelar_Click(sender As Object, e As EventArgs) Handles Button_cancelar.Click


        Me.Panel1.Visible = True
        Me.Panel4.Visible = True
        Me.datagridempleados.Visible = True
        Me.Button_guardar.Visible = False
        Me.Button_cancelar.Visible = False
        Me.datagridempleados.Enabled = True

        TextBox_celular.Text = ""
        TextBox_salario.Text = "0"
        Me.TextBox_DOC.Text = ""
        Me.TextBox_NOMBRE.Text = ""
        Me.TextBox_DOMICILIO.Text = ""
        Me.TextBox_TEL.Text = ""
        Me.TextBox_MAIL.Text = ""
        Me.TextBox_password.Text = ""
        Me.Combo_cargo.SelectedItem = Nothing
        empleado_id = ""
        Me.Button_export_pdf.Visible = True
        Me.TextBox_salario.Text = 0
        que_hace = ""
        grid_empleados()


        Panel4.Visible = True
        TextBox_NOMBRE.Text = ""

        datagrid_permisos_todos.DataSource = Nothing
        datagrid_permisos.DataSource = Nothing

        RadioButton_ventas.Checked = False
        RadioButton_INFORMES.Checked = False
        RadioButton_ADMINISTRACION.Checked = False
        RadioButton_INVENTARIOS.Checked = False
        RadioButton_PAGOS.Checked = False


        RadioButton_ventas.BackColor = Color.FromArgb(28, 47, 87)
        RadioButton_INVENTARIOS.BackColor = Color.FromArgb(28, 47, 87)
        RadioButton_PAGOS.BackColor = Color.FromArgb(28, 47, 87)
        RadioButton_INFORMES.BackColor = Color.FromArgb(28, 47, 87)
        RadioButton_ADMINISTRACION.BackColor = Color.FromArgb(28, 47, 87)


    End Sub

    Private Sub Button_guardar_Click(sender As Object, e As EventArgs) Handles Button_guardar.Click

        If Me.TextBox_salario.Text = "" Then MsgBox("No escribió el salario del empleado, si no tiene salario escriba 0.") : Exit Sub
        If Me.ComboBox_tipodoc.Text = "" Then MsgBox("No seleccionó el tipo de documento.") : Exit Sub

        If Me.TextBox_NOMBRE.Text = "" Then MsgBox("No escribió el nombre del cliente.") : Exit Sub
        If Me.TextBox_DOC.Text = "" Then MsgBox("No escribió el documento.") : Exit Sub

        If TextBox_password.Text <> "" Then
            ACCESO_SISTEM = 1
            If Me.TextBox_password.Text.Length < 4 Then
                MsgBox("la contraseña debe tener almenos 4 Carácteres.") : Exit Sub
            End If
        End If

        If TextBox_password.Text = "" Then
            ACCESO_SISTEM = 0
        End If

        'guardar
        If que_hace = "guardar" Then
            If Me.TextBox_TEL.Text = "" Then TextBox_TEL.Text = "0"
            Dim autorizador As String = ""
            If CheckBox1.Checked = True Then autorizador = "SI"
            If CheckBox1.Checked = False Then autorizador = "NO"

            ' se guarda
            sql = "INSERT INTO EMpleados (documento, tipodoc, nombre, direccion, mail, telefono, celular, cargo, accesosistema, pass, estado, salario,autorizador)" &
                  "VALUES ('" & Me.TextBox_DOC.Text & "','" & Me.ComboBox_tipodoc.Text & "','" & CStr(Me.TextBox_NOMBRE.Text) & "','" & CStr(Me.TextBox_DOMICILIO.Text) & "','" & CStr(Me.TextBox_MAIL.Text) & "','" & CStr(Me.TextBox_TEL.Text) & "','" & CStr(Me.TextBox_celular.Text) & "','" & CStr(Me.Combo_cargo.Text) & "'," & ACCESO_SISTEM & ",'" & CStr(Me.TextBox_password.Text) & "','ACTIVO','" & CStr(Me.TextBox_salario.Text) & "','" & CStr(autorizador) & "')"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
                '            MsgBox("Se restro la . ", vbInformation)
            Catch ex As Exception
                If ex.ToString.Contains("Duplicate entry") Then MsgBox("El documento que esta registraNdo ya está asignado", vbExclamation)
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()


            Me.Cursor = Cursors.WaitCursor
        End If


        If que_hace = "modificar" Then
            Me.Cursor = Cursors.WaitCursor
            Dim autorizador As String = ""
            If CheckBox1.Checked = True Then autorizador = "SI"
            If CheckBox1.Checked = False Then autorizador = "NO"

            sql = "UPDATE empleados SET tipodoc='" & CStr(Me.ComboBox_tipodoc.Text) & "', nombre='" & CStr(Me.TextBox_NOMBRE.Text) & "', direccion='" & CStr(Me.TextBox_DOMICILIO.Text) & "', mail='" & CStr(Me.TextBox_MAIL.Text) & "', telefono='" & CStr(Me.TextBox_TEL.Text) & "', celular='" & CStr(Me.TextBox_TEL.Text) & "', CARGO='" & Me.Combo_cargo.Text & "', ACCESOSISTEMA=" & ACCESO_SISTEM & ", PASS='" & Me.TextBox_password.Text & "', estado='" & Me.MetroComboBox_estado.Text & "', salario='" & CStr(Me.TextBox_salario.Text) & "', AUTORIZADOR='" & CStr(AUTORIZADOR) & "' WHERE cons='" & CStr(empleado_id) & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
                ' MsgBox("Tarifa Actualizada.   :).", vbInformation)
            Catch ex As Exception
                MsgBox("NO SE PUDO GUARDAR CONTACTE A SOPORTE.")
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()
        End If



        empleado_id = ""
        Me.Panel1.Visible = True
        Me.Panel4.Visible = True

        Me.datagridempleados.Visible = True
        Me.TextBox_DOC.Text = ""
        Me.TextBox_DOMICILIO.Text = ""
        Me.TextBox_MAIL.Text = ""
        Me.TextBox_TEL.Text = ""
        Me.TextBox_NOMBRE.Text = ""
        Me.TextBox_password.Text = ""
        Me.Combo_cargo.SelectedItem = Nothing

        Me.Button_export_pdf.Visible = True
        Me.TextBox_salario.Text = 0

        Me.Button_guardar.Visible = False
        Me.Button_cancelar.Visible = False


        grid_empleados()

        Me.datagridempleados.Columns(0).Visible = False
        Me.datagridempleados.Columns(1).HeaderText = "Documento"
        Me.datagridempleados.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.datagridempleados.Columns(1).Width = 100
        Me.datagridempleados.Columns(2).Visible = False
        Me.datagridempleados.Columns(3).HeaderText = "Nombre"
        Me.datagridempleados.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.datagridempleados.Columns(3).Width = 300
        Me.datagridempleados.Columns(4).Visible = False
        Me.datagridempleados.Columns(5).Visible = False
        Me.datagridempleados.Columns(6).Visible = False

        Me.datagridempleados.Columns(7).HeaderText = "cargo"
        Me.datagridempleados.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.datagridempleados.Columns(7).Width = 100

        Me.datagridempleados.Columns(8).Visible = False
        Me.datagridempleados.Columns(9).Visible = False
        Me.datagridempleados.Columns(10).Visible = False
        Me.datagridempleados.Columns(11).Visible = False

        datagridempleados.ClearSelection()
    End Sub

    Private Sub ACTUALIZAR_PERMISO(ByVal PERMISO As String, ByVal ESTADO As String)
        sql = "UPDATE PERMISOS SET ESTADO='" & CStr(ESTADO) & "' WHERE PERMISO='" & CStr(PERMISO) & "' AND CODEMPLEADO=" & CInt(empleado_id) & ""
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


    Private Sub Form_clientes_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        grid_empleados()


        Me.datagridempleados.Columns(0).Visible = False
        Me.datagridempleados.Columns(1).HeaderText = "Documento"
        Me.datagridempleados.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.datagridempleados.Columns(1).Width = 100
        Me.datagridempleados.Columns(2).Visible = False
        Me.datagridempleados.Columns(3).HeaderText = "Nombre"
        Me.datagridempleados.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.datagridempleados.Columns(3).Width = 300
        Me.datagridempleados.Columns(4).Visible = False
        Me.datagridempleados.Columns(5).Visible = False
        Me.datagridempleados.Columns(6).Visible = False
        Me.datagridempleados.Columns(7).Visible = False

        Me.datagridempleados.Columns(8).HeaderText = "cargo"
        Me.datagridempleados.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.datagridempleados.Columns(8).Width = 100

        Me.datagridempleados.Columns(9).Visible = False
        Me.datagridempleados.Columns(10).Visible = False
        Me.datagridempleados.Columns(11).Visible = False
        Me.datagridempleados.Columns(12).Visible = False

        datagridempleados.ClearSelection()



        'Try
        '    sql = "SELECT permisos.*, concat(modulo,'|  ',permiso) as permiso FROM miclickdb.permisos where codempleado=1 order by modulo;"
        '    da_comboemppermisos = New MySqlDataAdapter(sql, conex)
        '    dt_comboemppermisos = New DataTable
        '    da_comboemppermisos.Fill(dt_comboemppermisos)
        '    Me.ComboBox_PERMISOS.DataSource = dt_comboemppermisos.DefaultView
        '    Me.ComboBox_PERMISOS.DisplayMember = "permiso"
        '    Me.ComboBox_PERMISOS.ValueMember = "cons"
        '    Me.ComboBox_PERMISOS.AutoCompleteSource = AutoCompleteSource.ListItems
        '    Me.ComboBox_PERMISOS.AutoCompleteMode = AutoCompleteMode.Suggest
        '    Me.ComboBox_PERMISOS.SelectedItem = Nothing
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'conex.Close()
        'da_comboemppermisos.Dispose()
        'dt_comboemppermisos.Dispose()
        'conex.Close()

        'ComboBox_PERMISOS.SelectedItem = Nothing

    End Sub

    Private Sub datagridClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridempleados.CellClick
        Dim row As DataGridViewRow = datagridempleados.CurrentRow
        empleado_id = CInt(row.Cells("CONS").Value)
        ComboBox_tipodoc.Text = CStr(row.Cells("tipodoc").Value)

        TextBox_DOC.Text = CStr(row.Cells("documento").Value)
        Me.TextBox_NOMBRE.Text = CStr(row.Cells("nombre").Value)
        Me.Label_nombre_titulo.Text = CStr(row.Cells("nombre").Value)

        MetroComboBox_estado.Text = CStr(row.Cells("estado").Value)
        Me.TextBox_DOMICILIO.Text = CStr(row.Cells("direccion").Value)
        Me.TextBox_TEL.Text = CStr(row.Cells("telefono").Value)
        Me.TextBox_celular.Text = CStr(row.Cells("celular").Value)

        Me.TextBox_MAIL.Text = CStr(row.Cells("mail").Value)
        Me.TextBox_password.Text = CStr(row.Cells("pass").Value)
        Me.TextBox_salario.Text = CStr(row.Cells("salario").Value)
        Me.Combo_cargo.Text = CStr(row.Cells("cargo").Value)
        If row.Cells("ACCESOSISTEMA").Value = 1 Then ACCESO_SISTEM = 1
        If row.Cells("ACCESOSISTEMA").Value = 0 Then ACCESO_SISTEM = 0

        If row.Cells("AUTORIZADOR").Value = "SI" Then CheckBox1.Checked = True
        If row.Cells("AUTORIZADOR").Value = "NO" Then CheckBox1.Checked = False
        If row.Cells("AUTORIZADOR").Value = "" Then CheckBox1.Checked = False


    End Sub

    Private Sub datagridClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridempleados.CellContentClick

    End Sub

    Private Sub Button_eliminar_Click(sender As Object, e As EventArgs) Handles Button_eliminar.Click
        If empleado_id = "" Then MsgBox("Seleccione un registro de la lista.", vbInformation) : Exit Sub
        If TextBox_DOC.Text = "123456789" Then MsgBox("El Empleado Administrador no se puede eliminar.", vbInformation) : Exit Sub
        If empleado_id = 2 Then MsgBox("El Empleado Administrador no se puede eliminar.", vbInformation) : Exit Sub

        Dim RTA As String
        RTA = MsgBox("Desea eliminar el Empleado:     " & Chr(13) & Chr(13) & Me.TextBox_NOMBRE.Text, MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If RTA = 6 Then
            sql = "delete from empleados where CONS='" & CStr(empleado_id) & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
                'MsgBox("Se Borró el empleado.")
            Catch ex As Exception
                MsgBox("error BORRANDO.")
                Exit Sub
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()

            sql = "delete from permisos where codempleado='" & CStr(empleado_id) & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
                'MsgBox("Se Borró el empleado.")
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

    Private Sub MetroComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)
        ACCESO_SISTEM = 1
        Me.TextBox_password.Enabled = True

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)
        ACCESO_SISTEM = 0
        Me.TextBox_password.Enabled = False
        Me.TextBox_password.Clear()

    End Sub
    Private Sub grid_empleados_export()
        Me.Cursor = Cursors.WaitCursor
        sql = "SELECT documento as Documento, nombre as Nombre, telefono as Telefono, cargo as Cargo FROM empleados"
        da_grid_pdf = New MySqlDataAdapter(sql, conex)
        dt_grid_pdf = New DataTable
        Try
            da_grid_pdf.Fill(dt_grid_pdf)
            Me.datagrid_export.DataSource = dt_grid_pdf
        Catch ex As Exception
            If ex.ToString.Contains("Duplicate entry") Then MsgBox("Ese proveedor ya se encuentra en la lista", vbExclamation)
            MsgBox(ex.ToString)
        End Try
        da_grid_pdf.Dispose()
        dt_grid_pdf.Dispose()
        conex.Close()


        Me.datagrid_export.Columns(0).Width = 100
        Me.datagrid_export.Columns(1).Width = 300
        Me.datagrid_export.Columns(2).Width = 100
        Me.datagrid_export.Columns(3).Width = 150

        Me.datagrid_export.ClearSelection()
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub Button_export_pdf_Click(sender As Object, e As EventArgs) Handles Button_export_pdf.Click

        grid_empleados_export()
        Me.datagrid_export.Columns(0).Width = 100
        Me.datagrid_export.Columns(1).Width = 300
        Me.datagrid_export.Columns(2).Width = 100
        Me.datagrid_export.Columns(3).Width = 100

        Try
            'Intentar generar el documento.
            Dim doc As New Document(PageSize.A4, 15, 15, 15, 15)
            'Path que guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Lista de Clientes.pdf"
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
        Dim datatable As New PdfPTable(datagrid_export.ColumnCount)
        'Se asignan algunas propiedades para el diseño del PDF.
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(datagrid_export)
        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
        'Se crea el encabezado en el PDF.
        Dim encabezado As New Paragraph(comex_nombrecomercial, iTextSharp.text.FontFactory.GetFont("Arial Black", 11.0F, iTextSharp.text.Font.BOLD))
        Dim encabezado2 As New Paragraph("Listado de Empleados", iTextSharp.text.FontFactory.GetFont("Arial Black", 10.0F, iTextSharp.text.Font.BOLD))


        'Se crea el texto abajo del encabezado.
        Dim texto As New Phrase("Fecha del Reporte:" + Now.Date(), iTextSharp.text.FontFactory.GetFont("Arial Black", 7.0F, iTextSharp.text.Font.BOLD))
        Dim texto2 As New Phrase("  /  Generado Por:" + usrnom, iTextSharp.text.FontFactory.GetFont("Arial Black", 7.0F, iTextSharp.text.Font.BOLD))

        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To datagrid_export.ColumnCount - 1
            Dim cellhdr As New PdfPCell(New Phrase(datagrid_export.Columns(i).HeaderText, iTextSharp.text.FontFactory.GetFont("Arial Black", 6.0F, iTextSharp.text.Font.BOLD)))
            'datatable.AddCell(MetroGrid_pdf.Columns(i).HeaderText)
            cellhdr.HorizontalAlignment = Element.ALIGN_CENTER
            cellhdr.BackgroundColor = BaseColor.LIGHT_GRAY
            datatable.AddCell(cellhdr)
        Next


        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1
        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To datagrid_export.RowCount - 1
            For j As Integer = 0 To datagrid_export.ColumnCount - 1

                Dim cell As New PdfPCell
                cell.Phrase = New Phrase(datagrid_export(j, i).Value.ToString, iTextSharp.text.FontFactory.GetFont("Arial Black", 4.0F, iTextSharp.text.Font.NORMAL))
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
        If comex_logo <> "" Then
            Dim imagelogogopdf As iTextSharp.text.Image 'Declaracion de una imagen

            imagelogogopdf = iTextSharp.text.Image.GetInstance("c:\miclickderecho\logo.png") 'Dirreccion a la imagen que se hace referencia
            imagelogogopdf.Alignment = Element.ALIGN_RIGHT
            imagelogogopdf.SetAbsolutePosition(425, 777) 'Posicion en el eje cartesiano
            imagelogogopdf.ScaleAbsoluteWidth(150) 'Ancho de la imagen
            imagelogogopdf.ScaleAbsoluteHeight(45) 'Altura de la imagen
            document.Add(imagelogogopdf) ' Agrega la imagen al documento
        End If

        document.Add(encabezado)
        document.Add(encabezado2)
        document.Add(texto)
        document.Add(texto2)

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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button_modificar_DockChanged(sender As Object, e As EventArgs) Handles Button_modificar.DockChanged

    End Sub

    Private Sub Button_modificar_DoubleClick(sender As Object, e As EventArgs) Handles Button_modificar.DoubleClick
        Me.Button_modificar_Click(Nothing, Nothing)
    End Sub

    Private Sub MetroCheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox_salario.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_salario.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""

    End Sub

    Private Sub MetroCheckBox12_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer_modificar_Tick(sender As Object, e As EventArgs) Handles Timer_modificar.Tick
        Timer_modificar.Enabled = False
        empleado_id = USR_COD
        Me.Button_modificar_Click(Nothing, Nothing)

    End Sub



    Private Sub ComboBox_MEDIO_PAGO_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroCheckBox14_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroCheckBox15_CheckedChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub MetroGrid_PERMISOS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub ComboBox_MEDIO_PAGO_SelectionChangeCommitted(sender As Object, e As EventArgs)
        Timer_MEDIO_PAGO.Enabled = True
    End Sub

    Private Sub MetroGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub






    Private Sub Button_cerrar_Click(sender As Object, e As EventArgs) Handles Button_cerrar.Click
        Me.Close()
    End Sub


    Dim mousex As Integer = 0
    Dim mousey As Integer = 0
    Dim mouseDown1 As Boolean = False

    Private Sub Panel_titlebar_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel_titlebar.MouseDown
        mouseDown1 = True

    End Sub






    Private Sub MetroTabPage2_Click(sender As Object, e As EventArgs) Handles MetroTabPage2.Click

    End Sub



    Private Sub Panel_titlebar_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel_titlebar.MouseMove
        If mouseDown1 = True Then
            mousex = MousePosition.X - 405
            mousey = MousePosition.Y - 40
            Me.SetDesktopLocation(mousex, mousey)
        End If

    End Sub

    Private Sub TextBox_TEL_TextChanged(sender As Object, e As EventArgs) Handles TextBox_TEL.TextChanged

    End Sub

    Private Sub Panel_titlebar_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel_titlebar.MouseUp
        mouseDown1 = False

    End Sub

    Private Sub TextBox_DOC_TextChanged(sender As Object, e As EventArgs) Handles TextBox_DOC.TextChanged

    End Sub

    Private Sub MetroComboBox_MODULO_SelectionChangeCommitted(sender As Object, e As EventArgs)
        Timer_PERMISOS.Enabled = True

    End Sub

    Private Sub TextBox_TEL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_TEL.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            sql = "SELECT * FROM empleados WHERE nombre LIKE '%" & Me.TextBox_buscar_cliente.Text.ToString & "%' order by nombre asc"

            da_grid_emp = New MySqlDataAdapter(sql, conex)
            dt_grid_emp = New DataTable
            da_grid_emp.Fill(dt_grid_emp)
            Me.datagridempleados.DataSource = dt_grid_emp
            Me.datagridempleados.Columns(0).Visible = False
            Me.datagridempleados.Columns(1).HeaderText = "Documento"
            Me.datagridempleados.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagridempleados.Columns(1).Width = 100
            Me.datagridempleados.Columns(2).Visible = False
            Me.datagridempleados.Columns(3).HeaderText = "Nombre"
            Me.datagridempleados.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagridempleados.Columns(3).Width = 300
            Me.datagridempleados.Columns(4).Visible = False
            Me.datagridempleados.Columns(5).Visible = False
            Me.datagridempleados.Columns(6).Visible = False

            Me.datagridempleados.Columns(7).HeaderText = "cargo"
            Me.datagridempleados.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagridempleados.Columns(7).Width = 100

            Me.datagridempleados.Columns(8).Visible = False
            Me.datagridempleados.Columns(9).Visible = False
            Me.datagridempleados.Columns(10).Visible = False
            Me.datagridempleados.Columns(11).Visible = False
            datagridempleados.ClearSelection()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_grid_emp.Dispose()
        dt_grid_emp.Dispose()
        conex.Close()
    End Sub

    Private Sub TextBox_buscar_cliente_TextChanged(sender As Object, e As EventArgs) Handles TextBox_buscar_cliente.TextChanged

    End Sub

    Private Sub TextBox_DOC_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_DOC.KeyDown

    End Sub

    Private Sub TextBox_DOC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_DOC.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""

    End Sub

    Private Sub MetroComboBox_estado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroComboBox_estado.SelectedIndexChanged

    End Sub

    Private Sub TextBox_buscar_cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_buscar_cliente.KeyPress

    End Sub

    Private Sub TextBox_buscar_cliente_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_buscar_cliente.KeyDown



        If e.KeyCode = "13" Then
            Button3_Click(Nothing, Nothing)
        End If


    End Sub



    Private Sub ComboBox_tipodoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_tipodoc.SelectedIndexChanged

    End Sub

    Private Sub TextBox_DOC_GotFocus(sender As Object, e As EventArgs) Handles TextBox_DOC.GotFocus
        TextBox_DOC.BackColor = Color.MistyRose

    End Sub

    Private Sub TextBox_DOC_LostFocus(sender As Object, e As EventArgs) Handles TextBox_DOC.LostFocus
        TextBox_DOC.BackColor = Color.White

    End Sub

    Private Sub Combo_cargo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_cargo.SelectedIndexChanged

    End Sub

    Private Sub ComboBox_tipodoc_GotFocus(sender As Object, e As EventArgs) Handles ComboBox_tipodoc.GotFocus
        ComboBox_tipodoc.BackColor = Color.MistyRose

    End Sub

    Private Sub ComboBox_tipodoc_LostFocus(sender As Object, e As EventArgs) Handles ComboBox_tipodoc.LostFocus
        ComboBox_tipodoc.BackColor = Color.White

    End Sub

    Private Sub TextBox_NOMBRE_TextChanged(sender As Object, e As EventArgs) Handles TextBox_NOMBRE.TextChanged
        Label_nombre_titulo.Text = TextBox_NOMBRE.Text
    End Sub

    Private Sub Combo_cargo_GotFocus(sender As Object, e As EventArgs) Handles Combo_cargo.GotFocus
        Combo_cargo.BackColor = Color.MistyRose
    End Sub

    Private Sub Combo_cargo_LostFocus(sender As Object, e As EventArgs) Handles Combo_cargo.LostFocus
        Combo_cargo.BackColor = Color.White
    End Sub

    Private Sub TextBox_DOMICILIO_TextChanged(sender As Object, e As EventArgs) Handles TextBox_DOMICILIO.TextChanged

    End Sub

    Private Sub TextBox_NOMBRE_GotFocus(sender As Object, e As EventArgs) Handles TextBox_NOMBRE.GotFocus
        TextBox_NOMBRE.BackColor = Color.MistyRose
    End Sub

    Private Sub TextBox_NOMBRE_LostFocus(sender As Object, e As EventArgs) Handles TextBox_NOMBRE.LostFocus
        TextBox_NOMBRE.BackColor = Color.White
    End Sub

    Private Sub TextBox_MAIL_TextChanged(sender As Object, e As EventArgs) Handles TextBox_MAIL.TextChanged

    End Sub

    Private Sub TextBox_DOMICILIO_GotFocus(sender As Object, e As EventArgs) Handles TextBox_DOMICILIO.GotFocus
        TextBox_DOMICILIO.BackColor = Color.MistyRose
    End Sub

    Private Sub TextBox_DOMICILIO_LostFocus(sender As Object, e As EventArgs) Handles TextBox_DOMICILIO.LostFocus
        TextBox_DOMICILIO.BackColor = Color.White
    End Sub

    Private Sub TextBox_MAIL_GotFocus(sender As Object, e As EventArgs) Handles TextBox_MAIL.GotFocus
        TextBox_MAIL.BackColor = Color.MistyRose
    End Sub

    Private Sub TextBox_MAIL_LostFocus(sender As Object, e As EventArgs) Handles TextBox_MAIL.LostFocus
        TextBox_MAIL.BackColor = Color.White
    End Sub

    Private Sub TextBox_TEL_GotFocus(sender As Object, e As EventArgs) Handles TextBox_TEL.GotFocus
        TextBox_TEL.BackColor = Color.MistyRose
    End Sub

    Private Sub TextBox_TEL_LostFocus(sender As Object, e As EventArgs) Handles TextBox_TEL.LostFocus
        TextBox_TEL.BackColor = Color.White
    End Sub

    Private Sub TextBox_password_TextChanged(sender As Object, e As EventArgs) Handles TextBox_password.TextChanged

    End Sub

    Private Sub TextBox_salario_GotFocus(sender As Object, e As EventArgs) Handles TextBox_salario.GotFocus
        TextBox_salario.BackColor = Color.MistyRose
    End Sub

    Private Sub TextBox_salario_LostFocus(sender As Object, e As EventArgs) Handles TextBox_salario.LostFocus
        TextBox_salario.BackColor = Color.White
    End Sub

    Private Sub TextBox_password_GotFocus(sender As Object, e As EventArgs) Handles TextBox_password.GotFocus
        TextBox_password.BackColor = Color.MistyRose
    End Sub

    Private Sub TextBox_password_LostFocus(sender As Object, e As EventArgs) Handles TextBox_password.LostFocus
        TextBox_password.BackColor = Color.White
        TextBox_DOC.Focus()

    End Sub

    Private Sub MetroComboBox_estado_GotFocus(sender As Object, e As EventArgs) Handles MetroComboBox_estado.GotFocus
        MetroComboBox_estado.BackColor = Color.MistyRose

    End Sub
    Private Sub MetroComboBox_estado_LostFocus(sender As Object, e As EventArgs) Handles MetroComboBox_estado.LostFocus
        MetroComboBox_estado.BackColor = Color.White

    End Sub

    Private Sub Button_tab0_Click(sender As Object, e As EventArgs) Handles Button_tab1.Click
        Me.MetroTabPage2.Hide()
        'MetroTabPage2.Parent = Nothing

        Me.MetroTabPage1.Show()
        Me.MetroTabPage1.Parent = Me.MetroTabControl1
        MetroTabControl1.SelectTab(0)
    End Sub

    Private Sub Button_tab2_Click(sender As Object, e As EventArgs) Handles Button_tab2.Click
        Me.MetroTabPage1.Hide()
        'MetroTabPage1.Parent = Nothing

        Me.MetroTabPage2.Show()
        Me.MetroTabPage2.Parent = Me.MetroTabControl1
        MetroTabControl1.SelectTab(1)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If File.Exists("c:\miclickderecho\manualempleados.pdf") Then
            Process.Start("c:\miclickderecho\manualempleados.pdf")
        Else
            MsgBox("no se encontró el archivo de ayuda, por lo que se cargará desde internet.")
            Me.Cursor = Cursors.WaitCursor
            Try
                ' System.Diagnostics.Process.Start("C:\Archivos de PRograma\Internet Explorer\iexplorer.exe", "www.google.com")
                Dim pag As String
                pag = "http://www.miclickderecho.com/manual/manualempleados.pdf"
                Shell("Explorer " & pag)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            Me.Cursor = Cursors.Default

        End If

    End Sub

    Private Sub ComboBox_PERMISOS_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox_modulos_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form_empleados_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Escape And que_hace = "guardar" Then
            Button_cancelar_Click(Nothing, Nothing)
            Exit Sub
        End If
        If e.KeyCode = Keys.Escape And que_hace = "modificar" Then
            Button_cancelar_Click(Nothing, Nothing)
            Exit Sub
        End If



        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub RadioButton_ventas_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_ventas.CheckedChanged
        If RadioButton_ventas.Checked = True Then
            modulo_sel = "VENTAS"
            RadioButton_ventas.BackColor = Color.DodgerBlue
            RadioButton_INVENTARIOS.BackColor = Color.FromArgb(28, 47, 87)
            RadioButton_PAGOS.BackColor = Color.FromArgb(28, 47, 87)
            RadioButton_INFORMES.BackColor = Color.FromArgb(28, 47, 87)
            RadioButton_ADMINISTRACION.BackColor = Color.FromArgb(28, 47, 87)


            GRID_PERMISOS()
            GRID_PERMISOS_generales_empleado()

            comparar()

        End If


    End Sub

    Private Sub RadioButton_INVENTARIOS_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_INVENTARIOS.CheckedChanged
        If RadioButton_INVENTARIOS.Checked = True Then
            modulo_sel = "INVENTARIOS"
            RadioButton_INVENTARIOS.BackColor = Color.DodgerBlue
            RadioButton_PAGOS.BackColor = Color.FromArgb(28, 47, 87)
            RadioButton_INFORMES.BackColor = Color.FromArgb(28, 47, 87)
            RadioButton_ADMINISTRACION.BackColor = Color.FromArgb(28, 47, 87)
            RadioButton_ventas.BackColor = Color.FromArgb(28, 47, 87)

            GRID_PERMISOS()
            GRID_PERMISOS_generales_empleado()
            comparar()

        End If



    End Sub

    Private Sub RadioButton_PAGOS_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_PAGOS.CheckedChanged

        If RadioButton_PAGOS.Checked = True Then
            modulo_sel = "GASTOS"
            RadioButton_PAGOS.BackColor = Color.DodgerBlue
            RadioButton_INVENTARIOS.BackColor = Color.FromArgb(28, 47, 87)
            RadioButton_INFORMES.BackColor = Color.FromArgb(28, 47, 87)
            RadioButton_ADMINISTRACION.BackColor = Color.FromArgb(28, 47, 87)
            RadioButton_ventas.BackColor = Color.FromArgb(28, 47, 87)
            GRID_PERMISOS()
            GRID_PERMISOS_generales_empleado()
            comparar()
        End If

    End Sub

    Private Sub RadioButton_INFORMES_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_INFORMES.CheckedChanged
        If RadioButton_INFORMES.Checked = True Then
            modulo_sel = "INFORMES"
            RadioButton_INFORMES.BackColor = Color.DodgerBlue
            RadioButton_INVENTARIOS.BackColor = Color.FromArgb(28, 47, 87)
            RadioButton_PAGOS.BackColor = Color.FromArgb(28, 47, 87)
            RadioButton_ADMINISTRACION.BackColor = Color.FromArgb(28, 47, 87)
            RadioButton_ventas.BackColor = Color.FromArgb(28, 47, 87)

            GRID_PERMISOS()
            GRID_PERMISOS_generales_empleado()
            comparar()
        End If



    End Sub

    Private Sub RadioButton_ADMINISTRACION_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_ADMINISTRACION.CheckedChanged
        If RadioButton_ADMINISTRACION.Checked = True Then
            modulo_sel = "ADMINISTRACION"
            RadioButton_ADMINISTRACION.BackColor = Color.DodgerBlue
            RadioButton_INFORMES.BackColor = Color.FromArgb(28, 47, 87)
            RadioButton_PAGOS.BackColor = Color.FromArgb(28, 47, 87)
            RadioButton_ventas.BackColor = Color.FromArgb(28, 47, 87)
            RadioButton_INVENTARIOS.BackColor = Color.FromArgb(28, 47, 87)

            GRID_PERMISOS()
            GRID_PERMISOS_generales_empleado()
            comparar()
        End If



    End Sub
    Private Sub comparar()
        Try


            For Each fila As DataGridViewRow In datagrid_permisos_todos.Rows
                For Each fila2 As DataGridViewRow In datagrid_permisos.Rows
                    If CStr(fila.Cells("permiso").Value.ToString) = CStr(fila2.Cells("permiso").Value.ToString) Then
                        fila.Cells("permiso").Style.ForeColor = Color.LimeGreen
                    End If

                Next


            Next

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub
    Private Sub datagrid_permisos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_permisos.CellContentClick

    End Sub

    Private Sub datagridempleados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridempleados.CellDoubleClick
        Button_modificar_Click(Nothing, Nothing)
    End Sub

    Private Sub GRID_PERMISOS()
        datagrid_permisos.DataSource = Nothing

        sql = "SELECT * FROM permisos where codempleado='" & empleado_id & "' and modulo='" & modulo_sel & "'"
        da_permisos_emp = New MySqlDataAdapter(sql, conex)
        dt_permisos_emp = New DataTable
        Try
            da_permisos_emp.Fill(dt_permisos_emp)
            If dt_permisos_emp.Rows.Count > 0 Then
                Me.datagrid_permisos.DataSource = dt_permisos_emp
                datagrid_permisos.Columns(0).Visible = False
                datagrid_permisos.Columns(1).Visible = False
                datagrid_permisos.Columns(2).Visible = False

                Me.datagrid_permisos.Columns(3).HeaderText = "PERMISOS HABILITADOS AL EMPLEADO"
                Me.datagrid_permisos.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                'Me.datagrid_permisos.Columns(3).Width = 100

                datagrid_permisos.Columns(4).Visible = False
                datagrid_permisos.Columns(5).Visible = False


            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        da_permisos_emp.Dispose()
        dt_permisos_emp.Dispose()
        conex.Close()

        datagrid_permisos.ClearSelection()
    End Sub

    Private Sub datagrid_permisos_todos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_permisos_todos.CellContentClick

    End Sub


    Private Sub GRID_PERMISOS_generales_empleado()

        datagrid_permisos_todos.DataSource = Nothing

        sql = "SELECT codigo, modulo, permiso FROM permisos where codempleado='1' and modulo='" & modulo_sel & "'"
        da_permisos_general = New MySqlDataAdapter(sql, conex)
        dt_permisos_general = New DataTable
        Try
            da_permisos_general.Fill(dt_permisos_general)
            datagrid_permisos_todos.DataSource = dt_permisos_general
            datagrid_permisos_todos.Columns(0).Visible = False
            datagrid_permisos_todos.Columns(1).Visible = False

            Me.datagrid_permisos_todos.Columns(2).HeaderText = "LISTADO GENERAL DE  PERMISOS"
            Me.datagrid_permisos_todos.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            'Me.datagrid_permisos_todos.Columns(1).Width = 100
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        da_permisos_general.Dispose()
        dt_permisos_general.Dispose()
        conex.Close()
        datagrid_permisos_todos.ClearSelection()
    End Sub

    Private Sub Button_agregar_permiso_Click(sender As Object, e As EventArgs) Handles Button_agregar_permiso.Click
        If datagrid_permisos_todos.SelectedRows.Count = 0 Then MsgBox("seleccione un permiso de la tabla de permisos generales.")

        sql = "INSERT INTO permisos (codigo, modulo, permiso, codempleado, estado) values('" & cod_permiso_general & "','" & modulo_general & "','" & COD_PERMISONOMBRE_general & "','" & empleado_id & "','SI')"
        da = New MySqlDataAdapter(sql, conex)
        dt = New DataTable
        Try
            da.Fill(dt)
            'MsgBox("Se agregó el permiso")
        Catch ex As Exception
            MsgBox("error.")
            da.Dispose()
            dt.Dispose()
            conex.Close()
            Exit Sub
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()

        cod_permiso_general = ""
        modulo_general = ""
        COD_PERMISONOMBRE_general = ""

        datagrid_permisos_todos.ClearSelection()

        GRID_PERMISOS()

        comparar()

    End Sub

    Private Sub Button_quitar_permiso_Click_1(sender As Object, e As EventArgs) Handles Button_quitar_permiso.Click


        If datagrid_permisos.SelectedRows.Count = 0 Then MsgBox("seleccione un permiso de la tabla de permisos geenrales.") : Exit Sub


        sql = "delete from permisos where cons='" & cod_permiso_emp & "'"
        da = New MySqlDataAdapter(sql, conex)
        dt = New DataTable
        Try
            da.Fill(dt)
            'MsgBox("Se quito el permiso")
        Catch ex As Exception
            MsgBox("error BORRANDO.")
            da.Dispose()
            dt.Dispose()
            conex.Close()
            Exit Sub
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()

        datagrid_permisos.ClearSelection()


        GRID_PERMISOS()
        GRID_PERMISOS_generales_empleado()


        comparar()
        cod_permiso_emp = ""

    End Sub

    Private Sub datagrid_permisos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_permisos.CellClick
        Dim row As DataGridViewRow = datagrid_permisos.CurrentRow
        cod_permiso_emp = CStr(row.Cells("CONS").Value)
        estado_permiso_emp = CStr(row.Cells("ESTADO").Value)
        COD_PERMISONOMBRE_emp = CStr(row.Cells("permiso").Value)




        datagrid_permisos_todos.ClearSelection()

    End Sub

    Private Sub datagrid_permisos_todos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_permisos_todos.CellClick
        Dim row_general As DataGridViewRow = datagrid_permisos_todos.CurrentRow

        cod_permiso_general = CStr(row_general.Cells("codigo").Value)
        modulo_general = CStr(row_general.Cells("modulo").Value)
        COD_PERMISONOMBRE_general = CStr(row_general.Cells("permiso").Value)

        datagrid_permisos.ClearSelection()
    End Sub
End Class