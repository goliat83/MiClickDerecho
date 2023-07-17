Public Class Form_impuesto

    Dim IMPUESTO_TIPO, IMPUESTO_TIPOIMP As String
    Dim COD_IMPUESTO As Integer
    Dim impu() As String

    Public dt_categorias_IMP As DataTable
    Public dA_categorias_IMP As MySqlDataAdapter
    Dim que_hace As String = ""
    Dim seleccionando As String = ""


    Private Sub Form_impuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_impuesto_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        seleccionando = "si"
        GRID_IMPUESTOS()
        seleccionando = ""

    End Sub

    Private Sub GRID_IMPUESTOS()
        Me.datagrid_impuestos.BringToFront()
        sql = "SELECT * FROM IMPUESTOS"
        da = New MySqlDataAdapter(sql, conex)
        dt = New DataTable
        Try
            da.Fill(dt)
            If dt.Rows.Count = 0 Then Me.datagrid_impuestos.DataSource = Nothing
            If dt.Rows.Count > 0 Then
                Me.datagrid_impuestos.DataSource = dt
                Me.datagrid_impuestos.Columns(0).Visible = False
                Me.datagrid_impuestos.Columns(1).Visible = False
                Me.datagrid_impuestos.Columns(2).Visible = False
                Me.datagrid_impuestos.Columns(3).HeaderText = "Impuesto"
                Me.datagrid_impuestos.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.datagrid_impuestos.Columns(3).Width = 100
                Me.datagrid_impuestos.Columns(4).HeaderText = "Tarifa"
                Me.datagrid_impuestos.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.datagrid_impuestos.Columns(4).Width = 100
                Me.datagrid_impuestos.Columns(5).Visible = False
                Me.datagrid_impuestos.Columns(6).Visible = False

            End If
        Catch ex As Exception
            If ex.ToString.Contains("Duplicate entry") Then MsgBox(" ya se encuentra en la lista", vbExclamation)
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()

        datagrid_impuestos.ClearSelection()

    End Sub

    Private Sub button_crear_Click(sender As Object, e As EventArgs) Handles button_crear.Click

        Me.Panel1.Visible = False

        CONSECUTIVOs("IMPUESTOS")
        Me.datagrid_impuestos.Visible = False
        combobox_cta1.Text = ""
        combobox_cta2.Text = ""

        Me.Textbox_nombre.Text = ""
        Me.TextBox_porcentajevr.Text = ""

        COD_IMPUESTO = 0
        RadioButton_porcentaje.Checked = True
    End Sub



    Private Sub Btn_cancelar_Click(sender As Object, e As EventArgs) Handles Btn_cancelar.Click
        datagrid_impuestos.Visible = True
        Me.Textbox_nombre.Text = ""
        Me.TextBox_porcentajevr.Text = ""

        Me.datagrid_impuestos.Visible = True
        Me.datagrid_impuestos.BringToFront()


        COD_IMPUESTO = 0

        GRID_IMPUESTOS()




        Me.Panel1.Visible = True
    End Sub

    Private Sub datagrid_impuestos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_impuestos.CellContentClick

    End Sub

    Private Sub Label_doc_label_Click(sender As Object, e As EventArgs) Handles Label_doc_label.Click

    End Sub

    Private Sub datagrid_impuestos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_impuestos.CellClick
        COD_IMPUESTO = 0
        Dim row As DataGridViewRow = datagrid_impuestos.CurrentRow
        COD_IMPUESTO = CLng(row.Cells("Cons").Value)
        Textbox_nombre.Text = CStr(row.Cells("nombre").Value)
        TextBox_porcentajevr.Text = CStr(row.Cells("porcentaje").Value)

        combobox_cta1.Text = CStr(row.Cells("cuentapuc").Value)
        combobox_cta2.Text = CStr(row.Cells("cuentapuc2").Value)

        If CStr(row.Cells("tipoimp").Value) = "VALOR" Then
            RadioButton_valor.Checked = True
        End If
        If CStr(row.Cells("tipoimp").Value) = "PORCENTAJE" Then
            RadioButton_porcentaje.Checked = True
        End If

        If CStr(row.Cells("tipoimp").Value) = "RETENCION" Then
            RadioButton_retencion.Checked = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        que_hace = "Modificar"
        Me.Panel1.Visible = False
        Me.datagrid_impuestos.Visible = False


    End Sub

    Private Sub Button_opciones_Click(sender As Object, e As EventArgs) Handles Button_opciones.Click
        datagrid_impuestos.Visible = False
        Panel_opciones.Visible = True
        Panel_imp_datos.Visible = False


        'impuestos
        Try
            sql = "SELECT cons, TIPOIMP, porcentaje, nombre, concat(nombre,'|',porcentaje) as impuesto FROM impuestos where tipo='VENTAS' and tipoimp='PORCENTAJE'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            ComboBox_impuestoaplicar.DataSource = dt.DefaultView
            ComboBox_impuestoaplicar.DisplayMember = "impuesto"
            ComboBox_impuestoaplicar.ValueMember = "CONS"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()

        conex.Close()

        ComboBox_impuestoaplicar.SelectedItem = Nothing


        Try
            sql = "SELECT cons, CATEGORIA FROM PRODUCTOS_CATEGORIAS"
            dA_categorias_IMP = New MySqlDataAdapter(sql, conex)
            dt_categorias_IMP = New DataTable
            dA_categorias_IMP.Fill(dt_categorias_IMP)
            ComboBox_categoria.DataSource = dt_categorias_IMP.DefaultView
            ComboBox_categoria.DisplayMember = "categoria"
            ComboBox_categoria.ValueMember = "categoria"

        Catch ex As Exception
            Cursor.Current = Cursors.Default
            MsgBox(ex.Message)
        End Try
        conex.Close()
        dA_categorias_IMP.Dispose()
        dt_categorias_IMP.Dispose()
        conex.Close()



        Panel1.Visible = False

    End Sub

    Private Sub Button_cerrar_Click(sender As Object, e As EventArgs) Handles Button_cerrar.Click
        Me.Close()
    End Sub

    Private Sub TextBox_porcentajevr_OnValueChanged(sender As Object, e As EventArgs) Handles TextBox_porcentajevr.OnValueChanged

    End Sub

    Private Sub datagrid_impuestos_SelectionChanged(sender As Object, e As EventArgs) Handles datagrid_impuestos.SelectionChanged
        If seleccionando = "si" Then Exit Sub

        COD_IMPUESTO = 0
        Dim row As DataGridViewRow = datagrid_impuestos.CurrentRow
        COD_IMPUESTO = CLng(row.Cells("Cons").Value)
        Textbox_nombre.Text = CStr(row.Cells("nombre").Value)
        TextBox_porcentajevr.Text = CStr(row.Cells("porcentaje").Value)

        combobox_cta1.Text = CStr(row.Cells("cuentapuc").Value)
        combobox_cta2.Text = CStr(row.Cells("cuentapuc2").Value)

        If CStr(row.Cells("tipoimp").Value) = "VALOR" Then
            RadioButton_valor.Checked = True
        End If
        If CStr(row.Cells("tipoimp").Value) = "PORCENTAJE" Then
            RadioButton_porcentaje.Checked = True
        End If
    End Sub

    Private Sub RadioButton_porcentaje_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_porcentaje.CheckedChanged

    End Sub

    Private Sub RadioButton_valor_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_valor.CheckedChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Cursor.Current = Cursors.WaitCursor

        If RadioButton_aplicacategoria.Checked = True Then
            If ComboBox_categoria.Text = Nothing Then
                MsgBox("Seleccione una categoria", vbInformation)
                Cursor.Current = Cursors.Default

                Exit Sub
            End If


            If ComboBox_impuestoaplicar.Text = Nothing Then
                MsgBox("Seleccione un impuesto", vbInformation)
                Cursor.Current = Cursors.Default

                Exit Sub
            End If
        End If


        If RadioButton_aplicatodos.Checked = True Then

            If ComboBox_impuestoaplicar.Text = Nothing Then
                MsgBox("Seleccione un impuesto", vbInformation)
                Cursor.Current = Cursors.Default

                Exit Sub
            End If
        End If


        impu = Split(ComboBox_impuestoaplicar.Text, "|")
        'actuzalizo
        Try
            If RadioButton_aplicatodos.Checked = True Then sql = "update productos set iva2='" & impu(1) & "', ivatipo2='PORCENTAJE', IMPID2='" & ComboBox_impuestoaplicar.SelectedValue & "', IMPNOM2='" & impu(0) & "'"
            If RadioButton_aplicacategoria.Checked = True Then sql = "update productos set iva2='" & impu(1) & "', ivatipo2='PORCENTAJE', IMPID2='" & ComboBox_impuestoaplicar.SelectedValue & "', IMPNOM2='" & impu(0) & "' where categoria='" & ComboBox_categoria.Text & "'"

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
        Cursor.Current = Cursors.Default

        MsgBox("Se aplicó el impuesto correctamente.", vbInformation)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        datagrid_impuestos.Visible = True
        Panel_opciones.Visible = False
        Panel_imp_datos.Visible = True
        Panel1.Visible = True



    End Sub


    Private Sub TextBox_porcentajevr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_porcentajevr.KeyPress

        If InStr(1, "0123456789," & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""

    End Sub

    Private Sub Button_sel_cuenta_imp_CR_Click(sender As Object, e As EventArgs) Handles Button_sel_cuenta_imp_CR.Click
        Button_sel_cuenta_imp_CR.Text = "..."
        Panel_imp_datos.Enabled = False
        Form_puc_Select.Show()

    End Sub

    Private Sub Button_sel_cuenta_imp_DB_Click(sender As Object, e As EventArgs) Handles Button_sel_cuenta_imp_DB.Click
        Button_sel_cuenta_imp_DB.Text = "..."
        Panel_imp_datos.Enabled = False
        Form_puc_Select.Show()
    End Sub

    Private Sub combobox_cta1_OnValueChanged(sender As Object, e As EventArgs) Handles combobox_cta1.OnValueChanged

    End Sub

    Private Sub Btn_guardar_Click(sender As Object, e As EventArgs) Handles Btn_guardar.Click
        Dim CUENTApuc() As String = Split(combobox_cta1.Text, "|")

        If Me.Textbox_nombre.Text = "" Then MsgBox("Debe Escribir un nombre para el impuesto.", vbInformation) : Exit Sub
        If Me.TextBox_porcentajevr.Text = "" Then MsgBox("Debe Escribir el valor del porcentaje.", vbInformation) : Exit Sub

        If RadioButton_porcentaje.Checked = True Then
            IMPUESTO_TIPOIMP = "PORCENTAJE"
        End If

        If RadioButton_valor.Checked = True Then
            IMPUESTO_TIPOIMP = "VALOR"
        End If

        If RadioButton_retencion.Checked = True Then
            IMPUESTO_TIPOIMP = "RETENCION"
        End If


        ' se guarda
        If IMPUESTO_TIPOIMP = "PORCENTAJE" Or IMPUESTO_TIPOIMP = "RETENCION" Then sql = "INSERT INTO impuestos(tipo, TIPOIMP, nombre, porcentaje, cuentapuc, cuentapuc2) VALUES('" & CStr(IMPUESTO_TIPO) & "','" & CStr(IMPUESTO_TIPOIMP) & "','" & CStr(Me.Textbox_nombre.Text) & "','" & CInt(Me.TextBox_porcentajevr.Text) & "','" & CStr(combobox_cta1.Text) & "','" & CStr(combobox_cta2.Text) & "')"
        If IMPUESTO_TIPOIMP = "VALOR" Then sql = "INSERT INTO impuestos(tipo, TIPOIMP, nombre, porcentaje, cuentapuc, cuentapuc2) VALUES('" & CStr(IMPUESTO_TIPO) & "','" & CStr(IMPUESTO_TIPOIMP) & "','" & CStr(Me.Textbox_nombre.Text) & "','" & CInt(Me.TextBox_porcentajevr.Text) & "','" & CStr(combobox_cta1.Text) & "','" & CStr(combobox_cta2.Text) & "')"


        If que_hace = "Modificar" Then
            If IMPUESTO_TIPOIMP = "PORCENTAJE" Or IMPUESTO_TIPOIMP = "RETENCION" Then sql = "update impuestos set tipo='" & CStr(IMPUESTO_TIPO) & "', TIPOIMP='" & CStr(IMPUESTO_TIPOIMP) & "', nombre='" & CStr(Me.Textbox_nombre.Text) & "', porcentaje='" & CInt(Me.TextBox_porcentajevr.Text) & "', cuentapuc='" & CStr(combobox_cta1.Text) & "', cuentapuc2='" & CStr(combobox_cta2.Text) & "'"
            If IMPUESTO_TIPOIMP = "VALOR" Then sql = "update impuestos set tipo='" & CStr(IMPUESTO_TIPO) & "', TIPOIMP='" & CStr(IMPUESTO_TIPOIMP) & "', nombre='" & CStr(Me.Textbox_nombre.Text) & "', porcentaje='" & CInt(Me.TextBox_porcentajevr.Text) & "', cuentapuc='" & CStr(combobox_cta1.Text) & "', cuentapuc2='" & CStr(combobox_cta2.Text) & "'"

        End If


        da = New MySqlDataAdapter(sql, conex)
        dt = New DataTable
        Try
            da.Fill(dt)
            'MsgBox("Se Guardó correctamente. ", vbInformation)
        Catch ex As Exception
            If ex.ToString.Contains("Duplicate entry") Then MsgBox("Ese impuesto ya se encuentra rgistrado.", vbExclamation)
            MsgBox(ex.ToString)
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()

        Me.datagrid_impuestos.Visible = True
        Me.datagrid_impuestos.BringToFront()
        Me.Textbox_nombre.Text = ""
        Me.TextBox_porcentajevr.Text = "0"

        Me.Label2.Text = "Detalles del Impuesto"



        Me.Panel1.Visible = True

        GRID_IMPUESTOS()
    End Sub

    Private Sub combobox_cta2_OnValueChanged(sender As Object, e As EventArgs) Handles combobox_cta2.OnValueChanged

    End Sub

    Private Sub combobox_cta1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles combobox_cta1.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub Button_eliminar_Click(sender As Object, e As EventArgs) Handles Button_eliminar.Click
        If COD_IMPUESTO = 0 Then MsgBox("Seleccione un registro de la lista.", vbInformation) : Exit Sub
        If COD_IMPUESTO = 1 Then MsgBox("No debe eliminar este Item.", vbInformation) : Exit Sub
        If COD_IMPUESTO = 2 Then MsgBox("No debe eliminar este Item.", vbInformation) : Exit Sub
        If COD_IMPUESTO = 3 Then MsgBox("No debe eliminar este Item.", vbInformation) : Exit Sub
        If COD_IMPUESTO = 4 Then MsgBox("No debe eliminar este Item.", vbInformation) : Exit Sub


        Dim RTA As String
        RTA = MsgBox("Desea eliminar el impuesto:" & Me.Textbox_nombre.Text, MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If RTA = 6 Then
            sql = "delete from impuestos where cons=" & CInt(COD_IMPUESTO) & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
                MsgBox("Se Borró el impuesto.")
            Catch ex As Exception
                MsgBox("error BORRANDO.")
                Exit Sub
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()

        End If

        GRID_IMPUESTOS()
    End Sub

    Private Sub Panel_titlebar_Paint(sender As Object, e As PaintEventArgs) Handles Panel_titlebar.Paint

    End Sub

    Private Sub combobox_cta2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles combobox_cta2.KeyPress
        e.KeyChar = ""

    End Sub
End Class