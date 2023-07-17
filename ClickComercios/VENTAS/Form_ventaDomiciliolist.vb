Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.draw

Public Class Form_ventaDomiciliolist
    Dim QUE_HACE As String
    Private Sub Form_ventaDomiciliolist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_domicilios_grid()
        datagriddomicilios.BringToFront()

    End Sub

    Private Sub load_domicilios_grid()
        Me.Cursor = Cursors.WaitCursor
        sql = "SELECT * FROM domicilios"
        da = New MySqlDataAdapter(sql, conex)
        dt = New DataTable
        Try
            da.Fill(dt)
            Me.datagriddomicilios.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()

        Me.datagriddomicilios.Columns(6).Visible = False
        Me.datagriddomicilios.Columns(7).Visible = False
        Me.datagriddomicilios.Columns(9).Visible = False
        Me.datagriddomicilios.Columns(10).Visible = False
        Me.datagriddomicilios.Columns(11).Visible = False
        Me.datagriddomicilios.Columns(12).Visible = False
        Me.datagriddomicilios.Columns(13).Visible = False
        Me.datagriddomicilios.Columns(14).Visible = False
        Me.datagriddomicilios.Columns(15).Visible = False
        Me.datagriddomicilios.Columns(17).Visible = False

        Me.datagriddomicilios.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.datagriddomicilios.Columns(0).Width = 130

        Me.datagriddomicilios.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.datagriddomicilios.Columns(1).Width = 50
        Me.datagriddomicilios.Columns(1).HeaderText = "No."
        Me.datagriddomicilios.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.datagriddomicilios.Columns(2).Width = 80
        Me.datagriddomicilios.Columns(2).HeaderText = "Fecha"
        Me.datagriddomicilios.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.datagriddomicilios.Columns(3).Width = 80
        Me.datagriddomicilios.Columns(3).HeaderText = "Hora"
        Me.datagriddomicilios.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.datagriddomicilios.Columns(4).Width = 160
        Me.datagriddomicilios.Columns(4).HeaderText = "Entregado"
        Me.datagriddomicilios.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.datagriddomicilios.Columns(5).Width = 160
        Me.datagriddomicilios.Columns(5).HeaderText = "DocCliente"
        Me.datagriddomicilios.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.datagriddomicilios.Columns(8).Width = 200
        Me.datagriddomicilios.Columns(8).HeaderText = "Direccion"
        Me.datagriddomicilios.Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.datagriddomicilios.Columns(16).Width = 130
        Me.datagriddomicilios.Columns(16).HeaderText = "Estado"
        Me.datagriddomicilios.ClearSelection()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub CheckBox_FECHA_CheckedChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub Form_ventaDomiciliolist_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            sql = "SELECT nombre, documento FROM EMPLEADOS where cargo='Mensajero'"
            da_meseros = New MySqlDataAdapter(sql, conex)
            DT_meseros = New DataTable
            da_meseros.Fill(DT_meseros)
            Me.ComboBox_mensajro.DataSource = DT_meseros.DefaultView
            Me.ComboBox_mensajro.DisplayMember = "NOMBRE"
            Me.ComboBox_mensajro.ValueMember = "DOCUMENTO"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_meseros.Dispose()
        DT_meseros.Dispose()
        conex.Close()
        ComboBox_mensajro.Text = Nothing



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Cursor = Cursors.WaitCursor
        sql = "SELECT * FROM domicilios where FECHA='" & ComboBox_fechafiltro.Text & "'"

        If Me.ComboBox_fechafiltro.Text <> "" Or Me.ComboBox_fechafiltro.Text = "Nothing" Then sql = sql & " AND FECHA='" & Me.ComboBox_fechafiltro.Text & "'"

        If Me.ComboBox_mesajerofiltro.Text <> "" Or Me.ComboBox_mesajerofiltro.Text = "Nothing" Then sql = sql & " AND MENSAJERO='" & Me.ComboBox_mesajerofiltro.Text & "'"


        da = New MySqlDataAdapter(sql, conex)
        dt = New DataTable
        Try
            da.Fill(dt)
            Me.datagriddomicilios.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()

        'Me.datagridPROVEEDORES.Columns(0).Visible = False
        'Me.datagridPROVEEDORES.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        'Me.datagridPROVEEDORES.Columns(1).Width = 130
        'Me.datagridPROVEEDORES.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'Me.datagridPROVEEDORES.Columns(2).Width = 40
        'Me.datagridPROVEEDORES.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        'Me.datagridPROVEEDORES.Columns(3).Width = 300
        Me.datagriddomicilios.ClearSelection()
        Me.Cursor = Cursors.Default
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub datagriddomicilios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagriddomicilios.CellContentClick

    End Sub

    Private Sub datagriddomicilios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagriddomicilios.CellClick
        Dim row_mov As DataGridViewRow = datagriddomicilios.CurrentRow

        TextBox_cod.Text = CStr(row_mov.Cells("cons").Value) ' LLAVE PRINCIPAL

        TextBox_FECHA.Text = CStr(row_mov.Cells("FECHA").Value) ' 
        TextBox_HORA.Text = CStr(row_mov.Cells("hora").Value) ' 
        TextBox_FIN.Text = CStr(row_mov.Cells("entregado").Value) ' 
        TextBox_DOC.Text = CStr(row_mov.Cells("DocCliente").Value) ' 
        TextBox_NOM.Text = CStr(row_mov.Cells("cliente").Value) ' 
        TextBox_TEL.Text = CStr(row_mov.Cells("telefono").Value) ' 
        TextBox_MAIL.Text = CStr(row_mov.Cells("email").Value) ' 
        TextBox_DIR.Text = CStr(row_mov.Cells("direccion").Value) ' 
        TextBox_valordomicilio.Text = CStr(row_mov.Cells("valor").Value) ' 
        TextBox_observaciones.Text = CStr(row_mov.Cells("observaciones").Value) ' 
        ComboBox_mensajro.Text = CStr(row_mov.Cells("mensajero").Value) ' 
        NumericUp_estimado.Text = CStr(row_mov.Cells("tiempoest").Value) ' 
        TextBox_tiempo.Text = CStr(row_mov.Cells("tiempo").Value) ' 
        TextBox_empleado.Text = CStr(row_mov.Cells("empleado").Value) ' 
        TextBox_estado.Text = CStr(row_mov.Cells("estado").Value) ' 
        TextBox_factura.Text = CStr(row_mov.Cells("factura").Value) ' 

        If TextBox_factura.Text <> "" And TextBox_factura.Text <> "0" Then
            Button6_Click(Nothing, Nothing)
        End If
        If TextBox_estado.Text = "FINALIZADO" Then
            ' CALCULAR TIEMPO
            Me.TextBox_tiempo.Text = DateDiff(DateInterval.Minute, CDate(CStr(row_mov.Cells("FECHA").Value) & " " & CStr(row_mov.Cells("hora").Value)), CDate(CStr(row_mov.Cells("FECHA").Value) & " " & CStr(row_mov.Cells("ENTREGADO").Value))).ToString
        End If

        If TextBox_estado.Text = "PENDIENTE" Then
            Me.TextBox_tiempo.Text = DateDiff(DateInterval.Minute, CDate(CStr(row_mov.Cells("FECHA").Value) & " " & CStr(row_mov.Cells("hora").Value)), CDate(DateTime.Now)).ToString
        End If

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub Panel15_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button_modificar_Click(sender As Object, e As EventArgs) Handles Button_modificar.Click
        If TextBox_cod.Text = "" Then MsgBox("Seleccione un domicilio", vbInformation) : Exit Sub

        QUE_HACE = "modificar"

        Me.datagriddomicilios.Visible = False

        Me.Panel4.Visible = False
        Me.Panel_BOTONES.Visible = False



        If TextBox_estado.Text = "FINALIZADO" Then
            Button_finalizar.Visible = False
            Button_ANULAR.Visible = False
            Button_IMPRIMIR_POS.Visible = True
            Me.Button_EXPORTAR.Visible = True
            Button6.Enabled = False
            Button_guardar.Visible = False
        End If
        If TextBox_estado.Text = "PENDIENTE" Then
            Button_finalizar.Visible = True
            Button_ANULAR.Visible = True
            Button_guardar.Visible = True
            Button_IMPRIMIR_POS.Visible = True

            Me.Button_EXPORTAR.Visible = True
            Button6.Enabled = True
        End If

        If TextBox_estado.Text = "ANULADO" Then
            Button_finalizar.Visible = False
            Button_ANULAR.Visible = False
            Button_guardar.Visible = False
            Me.Button_EXPORTAR.Visible = False
            Button_IMPRIMIR_POS.Visible = False
            Button6.Enabled = False
        End If

    End Sub

    Private Sub Button_Regresar_Click(sender As Object, e As EventArgs) Handles Button_Regresar.Click
        TextBox_cod.Text = "" ' LLAVE PRINCIPAL

        TextBox_FECHA.Text = DateTime.Now.ToShortDateString
        TextBox_HORA.Text = DateTime.Now.ToShortTimeString
        TextBox_FIN.Text = 0
        TextBox_DOC.Text = ""
        TextBox_NOM.Text = ""
        TextBox_TEL.Text = ""
        TextBox_MAIL.Text = ""
        TextBox_DIR.Text = ""
        TextBox_valordomicilio.Text = 0
        TextBox_observaciones.Text = ""
        ComboBox_mensajro.Text = Nothing
        NumericUp_estimado.Value = 0
        TextBox_tiempo.Text = 0
        TextBox_empleado.Text = ""
        TextBox_factura.Text = ""

        Me.Panel_BOTONES.Visible = True

        Me.Panel4.Visible = True
        Me.datagriddomicilios.Visible = True
        load_grid_DOMICILIOS()

    End Sub

    Private Sub button_crear_Click(sender As Object, e As EventArgs) Handles button_crear.Click


        'consecutivo
        consecutivo = 0
        cmd.Connection = conex
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select max(cons) + 1 from DOMICILIOS"
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

        TextBox_cod.Text = consecutivo

        QUE_HACE = "guardar"

        Me.TextBox_estado.Text = "NUEVO"

        Button_ANULAR.Visible = False
        Button_finalizar.Visible = False
        Button_EXPORTAR.Visible = False

        Me.datagriddomicilios.Visible = False
        Me.Panel4.Visible = False



        TextBox_FECHA.Text = DateTime.Now.ToShortDateString
        TextBox_HORA.Text = DateTime.Now.ToShortTimeString
        TextBox_FIN.Text = 0
        TextBox_DOC.Text = ""
        TextBox_NOM.Text = ""
        TextBox_TEL.Text = ""
        TextBox_MAIL.Text = ""
        TextBox_DIR.Text = ""
        TextBox_valordomicilio.Text = 0
        TextBox_observaciones.Text = ""
        ComboBox_mensajro.Text = Nothing
        NumericUp_estimado.Value = 0
        TextBox_tiempo.Text = 0
        TextBox_empleado.Text = ""
        TextBox_factura.Text = "0"
        Me.Panel_BOTONES.Visible = False


        Me.Label27.Text = ""
        Label31.Text = ""
        Me.Label32.Text = ""

        domicilio_ID = ""

        venta_con_domicilio = ""
        domiciliario = ""

        Me.Button6.Text = "Buscar"
        Me.FlowLayoutPanel2.Visible = False
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.TextBox_DOC.Text = ""
        Me.TextBox_NOM.Text = ""
        Me.Button_buscar_cliente.Visible = True
        TextBox_DIR.Text = ""
        TextBox_TEL.Text = ""
        TextBox_MAIL.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Me.TextBox_DOC.Text = "" Then Exit Sub
        If Me.TextBox_NOM.Text = "" Then Exit Sub

        Dim RTA As String
        RTA = MsgBox("Confirma Guardar el Cliente?." _
            & Chr(13) & Chr(13) & "Cliente:" & Me.TextBox_NOM.Text & Chr(13) &
            "Documento:" & Me.TextBox_NOM.Text & Chr(13) &
            "Teléfono:" & Me.TextBox_TEL.Text & Chr(13) &
            "Direccion:" & Me.TextBox_DIR.Text & Chr(13) &
            "Email:" & Me.TextBox_MAIL.Text, MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If RTA = 6 Then
            ' se guarda
            Dim DOC As String = "", dv As String = "", TIPODOC As String = "", ES_CLIENTE As String = ""
            DOC = TextBox_DOC.Text
            dv = TextBox_DOC.Text
            TIPODOC = "Cédula de Ciudadanía"
            ES_CLIENTE = "SI"
            If Me.TextBox_DOC.Text.Contains("-") Then
                dv = dv.TrimEnd("-")
                DOC = dv.TrimStart("-")
                TIPODOC = "NIT"
            End If
            sql = "INSERT INTO proveedores(documento, dv, TIPODOCUMENTO, nombre, telefono, direccion, email, cliente)" &
                  "VALUES ('" & DOC & "','" & dv & "','" & CStr(TIPODOC) & "','" & CStr(Me.TextBox_NOM.Text) & "','" & CStr(Me.TextBox_TEL.Text) & "','" & CStr(Me.TextBox_DIR.Text) & "','" & CStr(Me.TextBox_MAIL.Text) & "','" & ES_CLIENTE & "')"
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
        End If
    End Sub



    Private Sub TextBox_empleado_TextChanged(sender As Object, e As EventArgs) Handles TextBox_empleado.TextChanged

    End Sub

    Private Sub TextBox_empleado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_empleado.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub TextBox_cod_TextChanged(sender As Object, e As EventArgs) Handles TextBox_cod.TextChanged

    End Sub

    Private Sub TextBox_cod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_cod.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub Button_guardar_Click(sender As Object, e As EventArgs) Handles Button_guardar.Click

        If QUE_HACE = "guardar" Then

            sql = "INSERT INTO domicilios(fecha, hora, entregado, doccliente, cliente, telefono, email, direccion, valor, observaciones, mensajero, tiempoest, tiempo, empleado, estado, factura)
              VALUES ('" & CStr(Me.TextBox_FECHA.Text) & "','" & Me.TextBox_HORA.Text & "',0,
                      '" & Me.TextBox_DOC.Text & "','" & Me.TextBox_NOM.Text & "','" & Me.TextBox_TEL.Text & "',
                      '" & Me.TextBox_MAIL.Text & "','" & Me.TextBox_DIR.Text & "','" & Me.TextBox_valordomicilio.Text & "','" & Me.TextBox_observaciones.Text & "','" & Me.ComboBox_mensajro.Text & "','" & Me.NumericUp_estimado.Text & "','" & Me.TextBox_tiempo.Text & "','" & Me.TextBox_empleado.Text & "','PENDIENTE','" & Me.TextBox_factura.Text & "')"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
                '  MsgBox("Se Guardó correctamente. ", vbInformation)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()


            If Me.TextBox_factura.Text <> "" And TextBox_factura.Text <> "0" Then
                sql = "update ventas set domicilio='" & CStr(Me.TextBox_cod.Text) & "',domiciliario='" & CStr(Me.ComboBox_mensajro.Text) & "',domiciliovr='" & CStr(Me.TextBox_tiempo.Text) & "' WHERE documento=" & Me.TextBox_factura.Text & ""
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                Try
                    da.Fill(dt)
                    MsgBox("Se Guardó correctamente. ", vbInformation)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                da.Dispose()
                dt.Dispose()
                conex.Close()
            End If

            MsgBox("Se guardó el domicilio.", vbInformation)
        End If

        If QUE_HACE = "modificar" Then
            sql = "update domicilios set fecha='" & CStr(Me.TextBox_FECHA.Text) & "',hora='" & CStr(Me.TextBox_HORA.Text) & "',entregado='" & CStr(Me.TextBox_FIN.Text) & "',doccliente='" & CStr(Me.TextBox_DOC.Text) & "',cliente='" & CStr(Me.TextBox_NOM.Text) & "',telefono='" & CStr(Me.TextBox_TEL.Text) & "',email='" & CStr(Me.TextBox_MAIL.Text) & "',direccion='" & CStr(Me.TextBox_DIR.Text) & "',valor='" & CStr(Me.TextBox_valordomicilio.Text) & "',observaciones='" & CStr(Me.TextBox_observaciones.Text) & "',mensajero='" & CStr(Me.ComboBox_mensajro.Text) & "',tiempoest='" & CStr(Me.NumericUp_estimado.Value) & "',tiempo='" & CStr(Me.TextBox_tiempo.Text) & "',empleado='" & CStr(Me.TextBox_empleado.Text) & "',factura='" & CStr(Me.TextBox_factura.Text) & "' WHERE CONS=" & Me.TextBox_cod.Text & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
                MsgBox("Se Guardó correctamente. ", vbInformation)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()
        End If


        If Me.TextBox_factura.Text <> "" And TextBox_factura.Text <> "0" Then
            sql = "update ventas set domicilio='" & CStr(Me.TextBox_cod.Text) & "',domiciliario='" & CStr(Me.ComboBox_mensajro.Text) & "',domiciliovr='" & CStr(Me.TextBox_tiempo.Text) & "' WHERE documento=" & Me.TextBox_factura.Text & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
                MsgBox("Se Guardó correctamente. ", vbInformation)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()
        End If


        Me.Button_Regresar_Click(Nothing, Nothing)

    End Sub

    Private Sub Button_ANULAR_Click(sender As Object, e As EventArgs) Handles Button_ANULAR.Click
        Dim RTA As String
        RTA = MsgBox("Desea anular este pedido?.", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If RTA = 6 Then
            Me.Cursor = Cursors.WaitCursor

            sql = "update domicilios SET estado='ANULADO' WHERE CONS=" & CLng(TextBox_cod.Text) & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
                'MsgBox("Tarifa Actualizada.   :).", vbInformation)
            Catch ex As Exception
                Me.Cursor = Cursors.Default

                MsgBox(ex.ToString)
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()
        End If

        Me.Button_Regresar_Click(Nothing, Nothing)

    End Sub

    Private Sub Button_finalizar_Click(sender As Object, e As EventArgs) Handles Button_finalizar.Click
        Dim RTA As String
        RTA = MsgBox("Desea anular este pedido?.", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If RTA = 6 Then
            Me.Cursor = Cursors.WaitCursor

            Me.TextBox_tiempo.Text = DateDiff(DateInterval.Minute, CDate(CStr(TextBox_FECHA.Text) & " " & CStr(TextBox_HORA.Text)), CDate(DateTime.Now)).ToString

            sql = "update domicilios SET ENTREGADO='" & DateTime.Now.ToString & "', TIEMPO='" & Me.TextBox_tiempo.Text & "', estado='FINALIZADO' WHERE CONS=" & CLng(TextBox_cod.Text) & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
                'MsgBox("Tarifa Actualizada.   :).", vbInformation)
            Catch ex As Exception
                Me.Cursor = Cursors.Default

                MsgBox(ex.ToString)
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()
        End If

        Me.Button_Regresar_Click(Nothing, Nothing)
    End Sub

    Private Sub Button_export_pdf_Click(sender As Object, e As EventArgs) Handles Button_export_pdf.Click
        Me.Button_export_pdf.Visible = False

        Me.Button_pdf.Visible = True
        Me.Button_excel.Visible = True
    End Sub
    Private Sub load_grid_DOMICILIOS()
        Try
            sql = "SELECT * FROM DOMICILIOS"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.datagriddomicilios.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        Me.datagriddomicilios.Columns(0).Width = 50
        Me.datagriddomicilios.Columns(1).Width = 100
        Me.datagriddomicilios.Columns(2).Width = 100
        Me.datagriddomicilios.Columns(4).Width = 100
        Me.datagriddomicilios.Columns(5).Width = 90
        Me.datagriddomicilios.Columns(6).Width = 80
        Me.datagriddomicilios.Columns(7).Width = 70

        Me.datagriddomicilios.ClearSelection()
    End Sub
    Private Sub Button_pdf_Click(sender As Object, e As EventArgs) Handles Button_pdf.Click
        Me.Cursor = Cursors.WaitCursor

        load_grid_DOMICILIOS()


        Try
            'Intentar generar el documento.
            Dim doc As New iTextSharp.text.Document(PageSize.A4.Rotate, 10, 10, 10, 10)
            'Path que guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\LISTADO DE DOMICILIOS.pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, file)
            doc.Open()
            ExportarLISTADO(doc)
            doc.Close()
            Process.Start(filename)
        Catch ex As Exception
            'Si el intento es fallido, mostrar MsgBox.
            MessageBox.Show("No se puede generar el documento PDF, Cierre los documentos PDF generados anteriormente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        Me.Cursor = Cursors.Default
        Me.Button2.Visible = True
        Me.Button_pdf.Visible = False
        Me.Button_excel.Visible = False

    End Sub

    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        'funcion para obtener el tamaño de la columnas del datagridview
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function
    Public Sub ExportarLISTADO(ByVal document As Document)
        'Se crea un objeto PDFTable con el numero de columnas del DataGridView.
        Dim datatable As New PdfPTable(datagriddomicilios.ColumnCount)
        'Se asignan algunas propiedades para el diseño del PDF.
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(datagriddomicilios)

        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER

        'Se crea el encabezado en el PDF.
        Dim encabezado As New Paragraph(comex_nombrecomercial, New Font(Font.Name = "Tahoma", 14, Font.Bold))
        Dim encabezado2 As New Paragraph("LISTADO DE DOMICILIOS", New Font(Font.Name = "Arial Balck", 12, Font.Bold))

        'Se crea el texto abajo del encabezado.
        Dim texto2 As New Phrase("Fecha del Reporte: " + Now.Date(), New Font(Font.Name = "Arial Narrow", 10, Font.Bold))
        Dim texto3 As New Phrase("          Generado Por :" + usrnom, New Font(Font.Name = "Arial Narrow", 10, Font.Bold))

        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To datagriddomicilios.ColumnCount - 1
            Dim cellhdr As New PdfPCell(New Phrase(datagriddomicilios.Columns(i).HeaderText, New Font(Font.Name = "Arial", 10.0F, FontStyle.Bold)))
            'datatable.AddCell(MetroGrid_pdf.Columns(i).HeaderText)
            cellhdr.HorizontalAlignment = Element.ALIGN_CENTER
            cellhdr.BackgroundColor = BaseColor.LIGHT_GRAY
            datatable.AddCell(cellhdr)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1
        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To datagriddomicilios.RowCount - 1
            For j As Integer = 0 To datagriddomicilios.ColumnCount - 1

                Dim cell As New PdfPCell
                cell.Phrase = New Phrase(datagriddomicilios(j, i).Value.ToString, New Font(Font.Name = "Arial Narrow", 8))
                If j = 0 Then cell.HorizontalAlignment = Element.ALIGN_CENTER
                If j = 1 Then cell.HorizontalAlignment = Element.ALIGN_CENTER
                If j = 2 Then cell.HorizontalAlignment = Element.ALIGN_CENTER
                If j = 3 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 4 Then cell.HorizontalAlignment = Element.ALIGN_CENTER
                If j = 5 Then cell.HorizontalAlignment = Element.ALIGN_CENTER
                If j = 6 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 7 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                datatable.AddCell(cell)

            Next
            datatable.CompleteRow()
        Next
        'LOGO
        If comex_logo <> "" Then
            Dim imagelogogopdf As iTextSharp.text.Image 'Declaracion de una imagen

            imagelogogopdf = iTextSharp.text.Image.GetInstance("c:\miclickderecho\logo.png") 'Dirreccion a la imagen que se hace referencia
            imagelogogopdf.Alignment = Element.ALIGN_RIGHT
            imagelogogopdf.SetAbsolutePosition(650, 500) 'Posicion en el eje cartesiano
            imagelogogopdf.ScaleAbsoluteWidth(150) 'Ancho de la imagen
            imagelogogopdf.ScaleAbsoluteHeight(70) 'Altura de la imagen
            document.Add(imagelogogopdf) ' Agrega la imagen al documento
        End If
        'Se agrega el PDFTable al documento.


        document.Add(encabezado)
        document.Add(encabezado2)
        document.Add(texto2)
        document.Add(datatable)
        document.Add(texto3)

    End Sub

    Private Sub Button_excel_Click(sender As Object, e As EventArgs) Handles Button_excel.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            sql = "SELECT fecha,hora,entregado,doccliente,cliente,telefono,email,direccion,ciudad,valor,mensajero,tiempoest,tiempo,empleado,estado,factura FROM DOMICILLIOS"
            da_pdf = New MySqlDataAdapter(sql, conex)
            dt_pdf = New DataTable
            da_pdf.Fill(dt_pdf)
            Me.datagriddomicilios.DataSource = dt_pdf

            'Me.datagrid_saldoinicial.Columns(8).HeaderText = "ValorU"
            'Me.datagrid_saldoinicial.Columns(8).Width = 50
            'Me.datagrid_saldoinicial.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'Me.datagrid_saldoinicial.Columns(9).HeaderText = "Total"
            'Me.datagrid_saldoinicial.Columns(9).Width = 50
            'Me.datagrid_saldoinicial.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_pdf.Dispose()
        dt_pdf.Dispose()

        Dim RTA1 As String
        RTA1 = MsgBox("El informe que se va a generar puede tardar un tiempo considerable dependiendo de su tamaño." & Chr(13) & "Desea generar el archivo ahora?.", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If RTA1 = 6 Then
            Me.datagriddomicilios.Enabled = False
            Me.Cursor = Cursors.WaitCursor
            'Generar_Excel()
            Me.Cursor = Cursors.WaitCursor
            Try
                Using conex
                    ' recuperamos el documento de la base de datos y lo pasamos a un fichero
                    Dim drDocumentos As MySqlDataReader
                    Dim aBytDocumento() As Byte = Nothing
                    Dim oFileStream As FileStream
                    Dim lsQuery As String = "Select archivo From resources Where id=4"
                    Using loComando As New MySqlCommand(lsQuery, conex)
                        conex.Open()
                        drDocumentos = loComando.ExecuteReader(CommandBehavior.SingleRow)
                    End Using
                    If drDocumentos.Read() Then
                        aBytDocumento = CType(drDocumentos("archivo"), Byte())
                        '  End If
                        drDocumentos.Close()
                        oFileStream = New FileStream(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Reporte de domicilios.xls", FileMode.Create, FileAccess.ReadWrite)
                        oFileStream.Write(aBytDocumento, 0, aBytDocumento.Length)
                        oFileStream.Close()
                        'MessageBox.Show("Documento generado con éxito", "Generar Documentos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            Catch Exp As Exception
                MessageBox.Show(Exp.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            Me.Cursor = Cursors.WaitCursor

            GridAExcel(Me.datagriddomicilios)

            Me.Cursor = Cursors.Default
            'load docuemtno?????
            Dim RTA As String
            RTA = MsgBox("Se Generó el informe de productos" & Chr(13) & Chr(13) & "Desea Ver el archivo ahora?.", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
            If RTA = 6 Then
                System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Reporte de domicilios.xls")
            End If
            Me.datagriddomicilios.Enabled = True
        End If     ' fin de generar el informe.


        Me.Button_export_pdf.Visible = True
        Me.Button_pdf.Visible = False
        Me.Button_excel.Visible = False

        Me.Cursor = Cursors.Default
    End Sub

    Function GridAExcel(ByVal ElGrid As DataGridView) As Boolean
        'Creamos las variables
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
        exLibro = exApp.Workbooks.Open(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Reporte de domicilios.xls")
        exHoja = exApp.ActiveWorkbook.Sheets(1)
        Try
            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = ElGrid.ColumnCount
            Dim NRow As Integer = ElGrid.RowCount

            'encabezados
            exHoja.Cells.Item(2, 2) = "Reporte de Domicilios"
            exHoja.Cells.Item(3, 2) = usrnom.ToString
            exHoja.Cells.Item(4, 2) = DateTime.Now.ToString
            '----

            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.}}
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(5, i) = ElGrid.Columns(i - 1).Name.ToString
                exHoja.Cells.Item(5, i).HorizontalAlignment = 2
                exHoja.Cells.Interior.Color = Color.WhiteSmoke
            Next
            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 6, Col + 1) = ElGrid.Rows(Fila).Cells(Col).Value
                    exHoja.Cells.Item(Fila + 6, Col + 1).HorizontalAlignment = 2
                Next
            Next
            'Titulo en negrita, Alineado al centro y que el tamaño de la columna seajuste al texto
            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Rows.Interior.Color = Color.WhiteSmoke

            exHoja.Columns.AutoFit()

            'Aplicación visible
            exApp.Application.Visible = False
            exLibro.Save()
            exLibro.Close()
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
            Return False
        End Try
        Return True
    End Function

    Private Sub Button_EXPORTAR_Click(sender As Object, e As EventArgs) Handles Button_EXPORTAR.Click
        Try
            'Intentar generar el documento.
            Dim doc As New Document(PageSize.A4, 10, 20, 10, 10)
            'Path que guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\domicilio" & Me.TextBox_cod.Text & ".pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, file)
            doc.Open()
            ExportarDatosPDF2(doc)
            doc.Close()
            Process.Start(filename)
        Catch ex As Exception
            'Si el intento es fallido, mostrar MsgBox.
            MessageBox.Show("No se puede generar el documento PDF, Cierre los documentos PDF generados anteriormente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub ExportarDatosPDF2(ByVal document As Document)

        Dim contentFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 12, iTextSharp.text.Font.BOLD)
        Dim DIRFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 5, iTextSharp.text.Font.BOLD)
        Dim FIRMAFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 6, iTextSharp.text.Font.BOLD)
        Dim OBSRVFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 6, iTextSharp.text.Font.BOLD)

        'Se crea el encabezado en el PDF.
        Dim PDF_COMEX As New Paragraph(comex_nombrecomercial, contentFont) : PDF_COMEX.Alignment = 2
        PDF_COMEX.Font = contentFont
        Dim PDF_COMEX_DIR As New Paragraph(comex_dircomercio + " " + comex_ciudad + " " + comex_tels, DIRFont) : PDF_COMEX_DIR.Alignment = 2
        PDF_COMEX_DIR.Font = DIRFont

        Dim PDF_CONSECUTIVO As New Paragraph("No. " & TextBox_cod.Text, New Font(Font.Name = "Arial Black", 8, Font.Bold = True)) : PDF_CONSECUTIVO.Alignment = 2
        Dim encabezado As New Paragraph("DOMICILIO", New Font(Font.Name = "Arial Black", 8, Font.Bold = True)) : encabezado.Alignment = 2
        Dim encabezado2 As New Paragraph("Fecha:" + Me.TextBox_FECHA.Text & " " & TextBox_HORA.Text, New Font(Font.Name = "Arial Balck", 8, Font.Bold)) : encabezado2.Alignment = 2

        Dim glue = New Chunk(New VerticalPositionMark())
        Dim texto_CLIENTE As New Paragraph("Cliente: " + Me.TextBox_NOM.Text.ToString + " Documento/NIT: " + TextBox_DOC.Text, New Font(Font.Name = "Arial Narrow", 7, Font.Bold = True))
        texto_CLIENTE.Add(New Chunk(glue))
        texto_CLIENTE.Add(comex_nit & " " & comex_regimen)
        texto_CLIENTE.SpacingBefore = 5

        Dim texto_dirCLIENTE As New Paragraph("Dirección:  " + Me.TextBox_DIR.Text.ToString + " Teléfono: " + TextBox_TEL.Text, New Font(Font.Name = "Arial Narrow", 7, Font.Bold = True))
        texto_dirCLIENTE.Add(New Chunk(glue))
        texto_dirCLIENTE.Add(comex_Resdian)

        Dim texto_mailCLIENTE As New Paragraph("Email: " + Me.TextBox_MAIL.Text.ToString, New Font(Font.Name = "Arial Narrow", 7, Font.Bold = True))
        texto_mailCLIENTE.Add(New Chunk(glue))
        texto_mailCLIENTE.Add(comex_intervalo)







        Dim texto_resp As New Paragraph("Responsable: ", New Font(Font.Name = "Arial Narrow", 7, Font.Bold = True))
        texto_resp.Add(New Chunk(glue))
        texto_resp.Add("-")

        'Dim descuento As New Paragraph("", New Font(Font.Name = "Arial Black", 7, Font.Bold = True))
        'descuento.Add(New Chunk(glue))
        'descuento.Add("Descuento ")
        'descuento.IndentationLeft = 350
        'descuento.Alignment = Element.ALIGN_RIGHT
        'descuento.Add(New Chunk(glue))
        'descuento.Add("0" & " ")
        'descuento.SpacingBefore = 3

        'Dim subtotal As New Paragraph("", New Font(Font.Name = "Arial Black", 7, Font.Bold = True))
        'subtotal.Add(New Chunk(glue))
        'subtotal.Add("SubTotal ")
        'subtotal.IndentationLeft = 349
        'subtotal.Alignment = Element.ALIGN_RIGHT
        'subtotal.Add(New Chunk(glue))
        'subtotal.Add(TextBoxbaseimp.Text & " ")

        'Dim impuestos As New Paragraph("", New Font(Font.Name = "Arial Black", 7, Font.Bold = True))
        'impuestos.Add(New Chunk(glue))
        'impuestos.Add("Impuestos ")
        'impuestos.IndentationLeft = 368
        'impuestos.Alignment = Element.ALIGN_RIGHT
        'impuestos.Add(New Chunk(glue))
        'impuestos.Add(TextBoximp.Text & " ")

        Dim total_fac As New Paragraph("", New Font(Font.Name = "Arial Black", 9, Font.Bold = True))
        total_fac.Add(New Chunk(glue))
        total_fac.Add("Total ")
        total_fac.IndentationLeft = 359
        total_fac.Alignment = Element.ALIGN_RIGHT
        total_fac.Add(New Chunk(glue))
        total_fac.Add(TextBox_valordomicilio.Text & " ")

        Dim PDF_mensajero As New Paragraph("Mensajero: " & ComboBox_mensajro.Text & "Tiempo Est.  " & NumericUp_estimado.Value & "  Mins", FIRMAFont) : PDF_mensajero.Alignment = 0
        Dim PDF_nrofact As New Paragraph("#Factura: " & TextBox_factura.Text, FIRMAFont) : PDF_mensajero.Alignment = 0
        Dim pdf_Observaciones As New Paragraph("Observaciones: " & TextBox_observaciones.Text, OBSRVFont) : PDF_mensajero.Alignment = 0

        'Dim saltoDeLinea = New Paragraph("                                                                                          ")

        Dim PDF_FIRMACLIENTE As New Paragraph("FIRMA CLIENTE:____________________", FIRMAFont) : PDF_FIRMACLIENTE.Alignment = 0
        PDF_FIRMACLIENTE.Font = FIRMAFont

        Dim texto2 As New Phrase("Generado en: " + Now.Date(), New Font(Font.Name = "Arial Narrow", 5, Font.Bold))
        Dim texto3 As New Phrase("  Por: " + usrnom, New Font(Font.Name = "Arial Narrow", 5, Font.Bold))

        'LOGO
        If comex_logo <> "" Then
            Dim imagelogogopdf As iTextSharp.text.Image 'Declaracion de una imagen

            imagelogogopdf = iTextSharp.text.Image.GetInstance("c:\miclickderecho\logo.png") 'Dirreccion a la imagen que se hace referencia
            imagelogogopdf.Alignment = Element.ALIGN_RIGHT
            imagelogogopdf.SetAbsolutePosition(10, 785) 'Posicion en el eje cartesiano
            imagelogogopdf.ScaleAbsoluteWidth(140) 'Ancho de la imagen
            imagelogogopdf.ScaleAbsoluteHeight(55) 'Altura de la imagen
            document.Add(imagelogogopdf) ' Agrega la imagen al documento
        End If
        'Se agrega el PDFTable al documento.

        Dim CUADRO1 As iTextSharp.text.Image 'Declaracion de una imagen
        CUADRO1 = iTextSharp.text.Image.GetInstance("c:\miclickderecho\cuadro_para_portadas2.png") 'Dirreccion a la imagen que se hace referencia
        CUADRO1.Alignment = Element.ALIGN_RIGHT
        CUADRO1.SetAbsolutePosition(414, 762) 'Posicion en el eje cartesiano
        CUADRO1.ScaleAbsoluteWidth(168) 'Ancho de la imagen
        CUADRO1.ScaleAbsoluteHeight(43) 'Altura de la imagen
        document.Add(CUADRO1) ' Agrega la imagen al documento

        Dim CUADRO_cliente As iTextSharp.text.Image 'Declaracion de una imagen
        CUADRO_cliente = iTextSharp.text.Image.GetInstance("c:\miclickderecho\cuadro_para_portadas2.png") 'Dirreccion a la imagen que se hace referencia
        CUADRO_cliente.Alignment = Element.ALIGN_LEFT
        CUADRO_cliente.SetAbsolutePosition(5, 714) 'Posicion en el eje cartesiano
        CUADRO_cliente.ScaleAbsoluteWidth(350) 'Ancho de la imagen
        CUADRO_cliente.ScaleAbsoluteHeight(54) 'Altura de la imagen
        document.Add(CUADRO_cliente) ' Agrega la imagen al documento

        Dim CUADRO_subtotal As iTextSharp.text.Image 'Declaracion de una imagen
        CUADRO_subtotal = iTextSharp.text.Image.GetInstance("c:\miclickderecho\fondopanel.png") 'Dirreccion a la imagen que se hace referencia
        CUADRO_subtotal.Alignment = Element.ALIGN_LEFT
        CUADRO_subtotal.SetAbsolutePosition(6, 500) 'Posicion en el eje cartesiano
        CUADRO_subtotal.ScaleAbsoluteWidth(574) 'Ancho de la imagen
        CUADRO_subtotal.ScaleAbsoluteHeight(200) 'Altura de la imagen

        'document.Add(CUADRO_subtotal) ' Agrega la imagen al documento


        document.Add(PDF_COMEX)
        document.Add(PDF_COMEX_DIR)
        document.Add(encabezado)
        document.Add(PDF_CONSECUTIVO)
        document.Add(encabezado2)
        document.Add(texto_CLIENTE)
        document.Add(texto_dirCLIENTE)
        document.Add(texto_mailCLIENTE)
        document.Add(texto_resp)
        'DataTable.SpacingBefore = 15
        'document.Add(DataTable)
        'document.Add(descuento)
        'document.Add(subtotal)
        'document.Add(impuestos)
        document.Add(total_fac)
        'document.Add(saltoDeLinea)
        document.Add(PDF_mensajero)
        document.Add(PDF_nrofact)

        document.Add(PDF_FIRMACLIENTE)
        document.Add(texto2)
        document.Add(texto3)


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button_IMPRIMIR_POS.Click



        que_imprime = "domicilio"
        imp_titulo1 = comex_nombrecomercial
        imp_dir = comex_dircomercio
        imp_tels = comex_tels
        imp_propietario = comex_nombrepropietario
        imp_regimen = comex_regimen
        imp_nit = comex_nit & "-" & comex_DV
        imp_resdian = comex_Resdian
        imp_intervalo = comex_intervalo


        imp_clienteDoc = TextBox_DOC.Text
        imp_clienteNom = TextBox_NOM.Text
        ImpClienteDir = TextBox_DIR.Text
        imp_clienteTel = TextBox_TEL.Text
        imp_clientemail = TextBox_MAIL.Text

        imp_factunum = TextBox_factura.Text
        imp_fecha_factu = ""


        'imp_prod, imp_cant, imp_vrtotal, 

        imp_totalVenta = "0"
        imp_Descuento = "0"
        imp_subtotal = "0"
        Imp_baseimp = "0"
        imp_impuesto = "0"
        imp_totalapagar = TextBox_valordomicilio.Text
        imp_efectivo = ""
        imp_cambio = ""
        imp_cajero = TextBox_empleado.Text





    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        If Me.TextBox_factura.Text = "" Or Me.TextBox_factura.Text = "0" Then Exit Sub

        If Me.Button6.Text = "Buscar" Then

            Try
                sql = "SELECT * FROM ventas WHERE documento = " & CInt(TextBox_factura.Text) & ""
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                da.Fill(dt)
                For Each row As DataRow In dt.Rows
                    TextBox_factura.Text = row.Item("documento")

                    Me.Label27.Text = row.Item("totalventa")
                    Label31.Text = row.Item("fecha")
                    Me.Label32.Text = row.Item("estado")

                    TextBox_DOC.Text = row.Item("doccliente")
                    domicilio_ID = row.Item("DOMICILIO")

                    If domicilio_ID <> "" Then
                        venta_con_domicilio = "SI"
                        domiciliario = row.Item("DOMICILIario")
                        Me.ComboBox_mensajro.Text = domiciliario
                        TextBox_valordomicilio.Text = row.Item("DOMICILIOVR")
                    End If
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da.Dispose()
            dt.Dispose()

            If TextBox_DOC.Text <> "" Then
                Try
                    sql = "SELECT * FROM PROVEEDORES where DOCUMENTO='" & CStr(TextBox_DOC.Text) & "'"
                    da = New MySqlDataAdapter(sql, conex)
                    dt_clientes = New DataTable
                    da.Fill(dt_clientes)
                    For Each row As DataRow In dt_clientes.Rows
                        TextBox_NOM.Text = row.Item("nombre")
                        TextBox_TEL.Text = row.Item("TELEFONO")
                        TextBox_DIR.Text = row.Item("DIRECCION")
                        TextBox_MAIL.Text = row.Item("email")
                    Next
                Catch ex As Exception
                End Try
                da.Dispose()
                conex.Close()
            End If
            Me.Button6.Text = "Desvincular"
            Me.FlowLayoutPanel2.Visible = True
            Exit Sub
        End If

        If Me.Button6.Text = "Desvincular" Then
            TextBox_factura.Text = "0"
            Me.Label27.Text = ""
            Label31.Text = ""
            Me.Label32.Text = ""

            TextBox_DOC.Text = ""
            domicilio_ID = ""

            venta_con_domicilio = ""
            domiciliario = ""
            Me.ComboBox_mensajro.Text = Nothing

            TextBox_NOM.Text = ""
            TextBox_TEL.Text = ""
            TextBox_DIR.Text = ""
            TextBox_MAIL.Text = ""
            Me.Button6.Text = "Buscar"
            Me.FlowLayoutPanel2.Visible = False
        End If
    End Sub

    Private Sub TextBox_valordomicilio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_valordomicilio.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""
    End Sub


    Private Sub TextBox_tiempo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_tiempo.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""
    End Sub

    Private Sub TextBox_factura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_factura.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""
    End Sub

    Private Sub TextBox_FIN_TextChanged(sender As Object, e As EventArgs) Handles TextBox_FIN.TextChanged

    End Sub

    Private Sub TextBox_factura_TextChanged(sender As Object, e As EventArgs) Handles TextBox_factura.TextChanged
        If Me.TextBox_factura.Text = "" Then Me.TextBox_factura.Text = "0"
    End Sub

    Private Sub TextBox_FECHA_TextChanged(sender As Object, e As EventArgs) Handles TextBox_FECHA.TextChanged

    End Sub

    Private Sub TextBox_FECHA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_FECHA.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub TextBox_HORA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_HORA.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub TextBox_FIN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_FIN.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        'Try
        '    'Intentar generar el documento.
        '    Dim doc As New Document(PageSize.A4, 10, 20, 10, 10)
        '    'Path que guarda el reporte en el escritorio de windows (Desktop).
        '    Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\domicilio" & Me.TextBox_cod.Text & ".pdf"
        '    Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
        '    PdfWriter.GetInstance(doc, file)
        '    doc.Open()
        '    ExportarDatosPDF2(doc)
        '    doc.Close()
        '    'Process.Start(filename)
        'Catch ex As Exception
        '    'Si el intento es fallido, mostrar MsgBox.
        '    MessageBox.Show("No se puede generar el documento PDF, Cierre los documentos PDF generados anteriormente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try




    End Sub

    Private Sub TextBox_DOC_TextChanged(sender As Object, e As EventArgs) Handles TextBox_DOC.TextChanged

    End Sub

    Private Sub TextBox_DOC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_DOC.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""

    End Sub

    Private Sub Button_eliminar_Click(sender As Object, e As EventArgs)

    End Sub
End Class