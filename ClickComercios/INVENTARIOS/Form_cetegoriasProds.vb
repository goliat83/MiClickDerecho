Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Form_categorias
    Dim CATEGORIA_ID As String = ""
    Dim CATEGORIA_TIPO As String = ""
    Dim CATEGORIA_nombre As String = ""

    Dim CATEGORIA_contextmenu As String = ""


    Dim QUE_HACE As String = ""

    Dim dt_categorias_CAT As DataTable
    Dim dA_categorias_CA As MySqlDataAdapter

    Dim dt_cat_puc_4 As DataTable
    Dim da_cat_puc_4 As MySqlDataAdapter



    Private Sub Form_categorias_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        For Each f As Form In Application.OpenForms
            If f.Name = Form_productos.Name Then
                'actualizar combo 

                Form_productos.Timer_CATEG.Enabled = True

            End If
        Next
    End Sub

    Private Sub Form_categorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.datagridcategorias.BringToFront()


        sql = "SELECT * FROM productos_categorias order by tipo, categoria"
        da_CATEGORIAS_TEMP = New MySqlDataAdapter(sql, conex)
        dt_categorias_TEMP = New DataTable
        Try
            da_CATEGORIAS_TEMP.Fill(dt_categorias_TEMP)
            Me.datagridcategorias.DataSource = dt_categorias_TEMP
            Me.datagridcategorias.Columns(0).Visible = False
            Me.datagridcategorias.Columns(1).HeaderText = "Categoría"
            Me.datagridcategorias.Columns(1).Width = 320
            Me.datagridcategorias.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagridcategorias.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagridcategorias.Columns(2).HeaderText = "Tipo de Categoría"
            Me.datagridcategorias.Columns(2).Width = 180
            Me.datagridcategorias.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.datagridcategorias.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.datagridcategorias.Columns(3).Visible = False
            Me.datagridcategorias.Columns(4).Visible = False
            Me.datagridcategorias.Columns(5).Visible = False
            Me.datagridcategorias.Columns(6).Visible = False
            Me.datagridcategorias.Columns(7).Visible = False

        Catch ex As Exception
            If ex.ToString.Contains("Duplicate entry") Then MsgBox(" ya se encuentra en la lista", vbExclamation)
            MsgBox(ex.ToString)
        End Try

        da_CATEGORIAS_TEMP.Dispose()
        dt_categorias_TEMP.Dispose()
        conex.Close()


    End Sub



    Private Sub Btn_guardar_Click(sender As Object, e As EventArgs) Handles Btn_guardar.Click

        If Textbox_categoria.Text = "" Then
            MsgBox("Escribe el nombre de la categoría que deseas crear.")
            Exit Sub
        End If


        Dim TIPOCAT As String = ""
        If RadioButton_PRODS.Checked = True Then TIPOCAT = "PRODUCTOS"
        If RadioButton_INS.Checked = True Then TIPOCAT = "INSUMOS"
        If RadioButton_PROC.Checked = True Then TIPOCAT = "PROCESADOS"
        If RadioButton_SERV.Checked = True Then TIPOCAT = "SERVICIOS"



        If TIPOCAT = "" Then
            MsgBox("Selecciona el tipo de categoría que deseas crear.")
            Exit Sub
        End If



        If label_cuenta_cat_inv.Text = Nothing And TIPOCAT <> "SERVICIOS" Then
            label_cuenta_cat_inv.Text = "14|INVENTARIOS"
        End If

        If label_cuenta_cat_ing.Text = Nothing Then label_cuenta_cat_ing.Text = "41"


        Dim CUENTAventas() As String = Split(label_cuenta_cat_ing.Text, "|")
        Dim CUENTAinv() As String = Split(label_cuenta_cat_inv.Text, "|")



        If QUE_HACE = "" Then

            ' se guarda
            sql = "INSERT INTO productos_categorias(categoria, tipo, impventa, impinv, estado) VALUES ('" & CStr(Me.Textbox_categoria.Text) & "','" & CStr(TIPOCAT) & "','" & CUENTAventas(0) & "','" & label_cuenta_cat_inv.Text & "','ACTIVO')"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
                '  MsgBox("Se Guardó correctamente. ", vbInformation)
            Catch ex As Exception
                If ex.ToString.Contains("Duplicate") Or ex.ToString.Contains("Duplicata") Then MsgBox("La categoría, " & Textbox_categoria.Text & " ya existe.", vbExclamation)
                'MsgBox(ex.ToString)
                da.Dispose()
                dt.Dispose()
                conex.Close()
                Exit Sub
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()

            Me.datagridcategorias.Visible = True
            Me.datagridcategorias.BringToFront()
            Me.Textbox_categoria.Text = ""

            load_grid_categorias()

            Me.Panel1.Visible = True
            Exit Sub
        End If

        If QUE_HACE = "modificar" Then

            'ACTUALIZO LA CATEGORIA
            sql = "UPDATE productos_categorias set 
categoria='" & Textbox_categoria.Text & "', 
tipo='" & TIPOCAT & "', 
impventa='', 
impinv='' 
WHERE CONS=" & CATEGORIA_ID & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
                ' MsgBox("Tarifa Actualizada.   :).", vbInformation)
            Catch ex As Exception
                If ex.ToString.Contains("Duplicate") Or ex.ToString.Contains("Duplicata") Then MsgBox("La categoria, " & Textbox_categoria.Text & " ya existe.", vbExclamation)
                da.Dispose()
                dt.Dispose()
                conex.Close()
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()

        End If

        'ACTUALIZO LAS CATEHORIAS EN LOS PRODUCTOS
        sql = "UPDATE productos set categoria='" & Textbox_categoria.Text & "', tipo='" & TIPOCAT & "' WHERE categoria='" & CATEGORIA_nombre & "'"
        da = New MySqlDataAdapter(sql, conex)
        dt = New DataTable
        Try
            da.Fill(dt)
            ' MsgBox("Tarifa Actualizada.   :).", vbInformation)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()



        Me.datagridcategorias.Visible = True
        Me.datagridcategorias.BringToFront()
        Me.Textbox_categoria.Text = ""

        load_grid_categorias()

        Me.Panel1.Visible = True
    End Sub

    Private Sub Btn_cancelar_Click(sender As Object, e As EventArgs) Handles Btn_cancelar.Click
        Me.datagridcategorias.Visible = True
        Me.datagridcategorias.BringToFront()
        Me.Textbox_categoria.Text = ""
        CATEGORIA_ID = 0



        Me.datagridcategorias.BringToFront()
        load_grid_categorias()


        Me.datagridcategorias.ClearSelection()

        Me.datagridcategorias.ClearSelection()
        Me.Panel1.Visible = True

    End Sub

    Private Sub button_crear_Click(sender As Object, e As EventArgs) Handles button_crear.Click

        If PERMISO_1(16) = "NO" Or PERMISO_1(16) = Nothing Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub


        QUE_HACE = ""
        Button1.Enabled = False

        CONSECUTIVOs("productos_categorias")
        Me.datagridcategorias.Visible = False

        Me.Textbox_categoria.Text = ""
        CATEGORIA_ID = 0

        Me.Textbox_categoria.Focus()


        Me.Panel1.Visible = False

        label_cuenta_cat_inv.Text = ""
    End Sub

    Private Sub Button_eliminar_Click(sender As Object, e As EventArgs) Handles Button_eliminar.Click
        If PERMISO_1(18) = "NO" Or PERMISO_1(18) = Nothing Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub


        If CATEGORIA_ID = 0 Then MsgBox("Seleccione un registro de la lista.", vbInformation) : Exit Sub


        Try
            sql = "SELECT cod from productos where categoria='" & CATEGORIA_nombre & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                MsgBox("no se puede eliminar, existen productos con asignados a esta categoría.")
                Exit Sub
            End If
            conex.Close()
            da.Dispose()
            dt.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()




        Dim RTA As String
        RTA = MsgBox("Desea eliminar la categoria: " & Me.Textbox_categoria.Text, MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If RTA = 6 Then
            sql = "delete from productos_CATEGORIAS where cons=" & CInt(CATEGORIA_ID) & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                MsgBox("error BORRANDO.")
                Exit Sub
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()

        End If

        Me.datagridcategorias.BringToFront()


        Me.Btn_cancelar_Click(Nothing, Nothing)
        Me.datagridcategorias.ClearSelection()


    End Sub



    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)


    End Sub


    Private Sub Button_salir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Form_categorias_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'Timer_load.Enabled = True


        load_grid_categorias()



    End Sub
    Private Sub load_grid_categorias()

        sql = "SELECT * FROM productos_categorias order by tipo, categoria"
        da_CATEGORIAS_TEMP = New MySqlDataAdapter(sql, conex)
        dt_categorias_TEMP = New DataTable
        Try
            da_CATEGORIAS_TEMP.Fill(dt_categorias_TEMP)
            Me.datagridcategorias.DataSource = dt_categorias_TEMP
            Me.datagridcategorias.Columns(0).Visible = False
            Me.datagridcategorias.Columns(1).HeaderText = "Categoría"
            Me.datagridcategorias.Columns(1).Width = 320
            Me.datagridcategorias.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagridcategorias.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagridcategorias.Columns(2).HeaderText = "Tipo de Categoría"
            Me.datagridcategorias.Columns(2).Width = 180
            Me.datagridcategorias.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.datagridcategorias.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.datagridcategorias.Columns(3).Visible = False
            Me.datagridcategorias.Columns(4).Visible = False
            Me.datagridcategorias.Columns(5).Visible = False
            Me.datagridcategorias.Columns(6).Visible = False
            Me.datagridcategorias.Columns(7).Visible = False

        Catch ex As Exception
            If ex.ToString.Contains("Duplicate entry") Then MsgBox(" ya se encuentra en la lista", vbExclamation)
            MsgBox(ex.ToString)
        End Try

        da_CATEGORIAS_TEMP.Dispose()
        dt_categorias_TEMP.Dispose()
        conex.Close()





        Me.datagridcategorias.ClearSelection()
    End Sub

    Private Sub datagridcategorias_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Textbox_Cod_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Textbox_categoria_TextChanged(sender As Object, e As EventArgs) Handles Textbox_categoria.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button_categorias_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Textbox_categoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Textbox_categoria.KeyPress

    End Sub

    Private Sub ComboBox_ctapuc_vender_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button_consultar_Click(sender As Object, e As EventArgs) Handles Button_consultar.Click
        If PERMISO_1(17) = "NO" Or PERMISO_1(17) = Nothing Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub

        If CATEGORIA_ID = "" Or CATEGORIA_ID = "0" Then
            Exit Sub
        End If

        QUE_HACE = "modificar"

        datagridcategorias.Visible = False
        Panel1.Visible = False

        Button1.Enabled = True

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs)

    End Sub


    Private Sub Form_categorias_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress

    End Sub

    Private Sub Form_categorias_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown



        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If


    End Sub

    Private Sub Background_GRID_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Background_GRID.DoWork

    End Sub

    Private Sub RadioButton_SERV_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_SERV.CheckedChanged

    End Sub

    Private Sub RadioButton_PROC_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_PROC.CheckedChanged

    End Sub

    Private Sub RadioButton_INS_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_INS.CheckedChanged

    End Sub

    Private Sub RadioButton_PRODS_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_PRODS.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_cat_ventas.Click
        Button_cat_ventas.Text = "Seleccionando..."
        Me.Enabled = False

        Form_puc_Select.Show()
    End Sub





    Private Sub datagridcategorias_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridcategorias.CellContentClick

    End Sub

    Private Sub datagridcategorias_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridcategorias.CellClick
        CATEGORIA_ID = ""
        Dim row As DataGridViewRow = datagridcategorias.CurrentRow
        CATEGORIA_ID = CStr(row.Cells("Cons").Value)

        Textbox_categoria.Text = CStr(row.Cells("categoria").Value)
        CATEGORIA_nombre = CStr(row.Cells("categoria").Value)

        CATEGORIA_TIPO = CStr(row.Cells("tipo").Value)
        If CATEGORIA_TIPO = "PRODUCTOS" Then RadioButton_PRODS.Checked = True
        If CATEGORIA_TIPO = "INSUMOS" Then RadioButton_INS.Checked = True
        If CATEGORIA_TIPO = "PROCESADOS" Then RadioButton_PROC.Checked = True
        If CATEGORIA_TIPO = "SERVICIOS" Then RadioButton_SERV.Checked = True



        label_cuenta_cat_ing.Text = CStr(row.Cells("impventa").Value)
        label_cuenta_cat_inv.Text = CStr(row.Cells("impinv").Value)
    End Sub

    Private Sub datagridcategorias_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridcategorias.CellDoubleClick

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles Button_cat_ventas.MouseDown

    End Sub



    Private Sub Textbox_Cod_GotFocus(sender As Object, e As EventArgs)

    End Sub

    Private Sub Textbox_categoria_GiveFeedback(sender As Object, e As GiveFeedbackEventArgs) Handles Textbox_categoria.GiveFeedback

    End Sub

    Private Sub Textbox_categoria_GotFocus(sender As Object, e As EventArgs) Handles Textbox_categoria.GotFocus

    End Sub



    Private Sub ContextMenuStrip_LOAD_PUC_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_LOAD_PUC.Opening

    End Sub

    Private Sub Button_ayuda_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub Button_cat_inv_Click(sender As Object, e As EventArgs) Handles Button_cat_inv.Click
        'If CATEGORIA_contextmenu = "inventarios" Then Button_cat_inv.Text = "Seleccionando..."
        'If CATEGORIA_contextmenu = "ventas" Then Button_cat_ventas.Text = "Seleccionando..."
        'If CATEGORIA_contextmenu = "costos" Then Button_cat_costos.Text = "Seleccionando..."
        'If CATEGORIA_contextmenu = "devoluciones" Then Button_cat_dev.Text = "Seleccionando..."
        Button_cat_inv.Text = "Seleccionando..."
        Me.Enabled = False

        Form_puc_Select.Show()
    End Sub

    Private Sub label_cuenta_cat_inv_OnValueChanged(sender As Object, e As EventArgs) Handles label_cuenta_cat_inv.OnValueChanged

    End Sub

    Private Sub label_cuenta_cat_inv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles label_cuenta_cat_inv.KeyPress
        e.KeyChar = ""

    End Sub

    Private Sub label_cuenta_cat_inv_KeyDown(sender As Object, e As KeyEventArgs) Handles label_cuenta_cat_inv.KeyDown

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Button_eliminar_Click(Nothing, Nothing)
    End Sub

    Private Sub label_cuenta_cat_ing_OnValueChanged(sender As Object, e As EventArgs) Handles label_cuenta_cat_ing.OnValueChanged

    End Sub

    Private Sub label_cuenta_cat_ing_KeyPress(sender As Object, e As KeyPressEventArgs) Handles label_cuenta_cat_ing.KeyPress
        e.KeyChar = ""

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        label_cuenta_cat_inv.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        label_cuenta_cat_ing.Text = ""

    End Sub


End Class