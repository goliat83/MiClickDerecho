Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.Drawing
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.Environment
Imports System.ComponentModel
Imports Microsoft.Office.Interop


Public Class Form_productos
    Dim filtro_TIPO As String = ""
    Dim filtro_estado As String = ""

    Dim puede_cacular_utilidad As Boolean = False

    Dim desktop2 As String = Environment.GetFolderPath(SpecialFolder.MyPictures)
    Dim imagepath As String
    Dim PARA_COCINAR As String = ""
    Dim PARA_BAR As String = ""
    Dim PARA_PARRILLA As String = ""

    Dim cant_cats, cant_prods As Integer

    Dim CATEGORIA_BUSCAR As String = ""
    Dim CATEGORIA_GUARDAR As String = ""
    Dim TIPOCATEGORIA_GUARDAR As String = ""

    Dim ABRIR_TIPO_DOC As String = ""
    Dim ABRIR_TIPO_DOC_doc As String = ""

    Dim costo_prod_kit As String = ""
    Dim KIT_sel_cod As String

    Public da_prods_kit As New MySqlDataAdapter
    Public dt_prods_kit As New DataTable

    Public da_bods As New MySqlDataAdapter
    Public dt_bods As New DataTable

    Public da_bodsinfo As New MySqlDataAdapter
    Public dt_bodsinfo As New DataTable

    Public da_prods_presentacion As New MySqlDataAdapter
    Public dt_prods_presentacion As New DataTable

    Public da_AGRUPACION As New MySqlDataAdapter
    Public dt_AGRUPACION As New DataTable

    Public dt_categorias As DataTable
    Public dA_categorias As MySqlDataAdapter

    Public dt_categorias2 As DataTable
    Public dA_categorias2 As MySqlDataAdapter

    Dim codproducto As Long = 0
    Dim STREAM_IMAGE As System.IO.StreamReader
    Dim imgThumb As System.Drawing.Image = Nothing
    Dim image2 As System.Drawing.Image = Nothing
    Dim resizedimage As System.Drawing.Image

    Dim pcompra As Long
    Dim pventa As Long
    Dim incremento As Long
    Dim porcentaje As Long
    Dim prod_sel_cod As String
    Dim que_hace As String = ""

    Dim categ As String = ""

    Dim mousex As Integer = 0
    Dim mousey As Integer = 0
    Dim mouseDown1 As Boolean = False


    Dim miconex As MiConex = New MiConex()

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
    Private Sub TextBox_precio_GotFocus(sender As Object, e As EventArgs)
        Me.TextBox_valor1.BackColor = Color.MistyRose
    End Sub
    Private Sub TextBox_dir_KeyPress(sender As Object, e As KeyPressEventArgs)


        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""
    End Sub

    Private Sub TextBox_precio_LostFocus(sender As Object, e As EventArgs)
        Me.TextBox_valor1.BackColor = Color.White

    End Sub

    Private Sub Btn_crear_Click(sender As Object, e As EventArgs) Handles Btn_crear.Click
        Checkbox_kit.Checked = False

        If PERMISO_1(9) = "NO" Or PERMISO_1(9) = Nothing Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub


        BunifuCheckbox_inactivos.Visible = False
        Label60.Visible = False
        label_info_cant_cats.Visible = False
        Label_info_cant_prods.Visible = False
        Grid_InfoProd.DataSource = Nothing

        Checkbox_kit.Enabled = False
        Me.Button_buscar.Enabled = False
        Me.Combobox_categoria_buscar.Enabled = False
        consecutivo = 0
        cmd.Connection = conex
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select max(cod) + 1 from " & "productos" & ""
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

        que_hace = "GUARDAR"

        Me.TextBox_codprod.Text = consecutivo

        Me.TextBox_codprod.Visible = True

        Me.datagridProdsList.Visible = False

        Me.Button_cancelar.Enabled = True : Me.Button_cancelar.Visible = True
        Me.Button_guardar.Enabled = True : Me.Button_guardar.Visible = True


        Me.Panel_buttons.Visible = False
        Me.Panel_busqueda.Enabled = False
        Me.Panel_busqueda.Cursor = Cursors.No

        Me.Textbox_Nombre.Enabled = True
        Me.TextBox_presentacion.Enabled = True

        Me.Textbox_descripcion.Enabled = True
        Me.TextBox_valor1.Enabled = True
        Me.NUMERIC_costo.Enabled = True

        Me.TextBox_barras.Enabled = True
        Me.TextBox_stock.Enabled = True
        Me.PictureBox_image.Enabled = True
        Me.TextBox_barras.Text = ""
        Me.TextBox_presentacion.SelectedItem = ""

        RadioButton_estado_act.Checked = True

        Me.TextBox_ref.Text = ""
        Me.Textbox_Nombre.Text = ""
        Me.Textbox_descripcion.Text = ""
        Me.TextBox_valor1.Text = 0
        Me.TextBox_valor3.Text = 0
        Me.TextBox_valor2.Text = 0

        Me.Label_utilidad.Text = "Utilidad:"
        Me.Label_utilidad2.Text = "Utilidad:"
        Me.Label_utilidad3.Text = "Utilidad:"


        Me.NUMERIC_costo.Value = 0
        Me.TextBox_stock.Text = 0
        Me.datagridProdsList.CurrentCell = Nothing
        Me.Combobox_impuestos.Enabled = True
        Me.Combobox_impuestos.SelectedValue = 1
        Me.ComboBox_INVENTARIO.SelectedValue = 1
        Me.ComboBox_INVENTARIO.Text = "SI"
        Me.ComboBox_categoria.SelectedItem = Nothing

        CATEGORIA_GUARDAR = ""
        TIPOCATEGORIA_GUARDAR = ""

        If PERMISO__general(5) = "NO" Then
            Combobox_impuestos.Enabled = False
            Me.Combobox_impuestos.SelectedValue = 1
            TextBox_espejo1.Enabled = False
            ComboBox_impuestos2.Enabled = False
            Me.Combobox_impuestos.SelectedValue = 1
            TextBox_espejo2.Enabled = False
        End If


        Me.Combobox_impuestos.SelectedValue = 3
        Me.ComboBox_impuestos2.SelectedValue = 1
        TextBox_espejo1.Text = "VALOR"
        TextBox_espejo2.Text = "PORCENTAJE"
        Me.MetroComboBox_decimales.SelectedItem = "NO"
        Timer_impuesto.Enabled = True
        Timer_Impuesto2.Enabled = True

        imagepath = ""
        puede_cacular_utilidad = True

        Me.PictureBox_image.Image = Nothing
        Application.DoEvents()
        If PictureBox_image.ImageLocation <> Nothing Then
            Kill(PictureBox_image.ImageLocation)
        End If

        Label_kit_title.Text = "Kit del Producto"

        NumericUpDown_alerta.Value = 0

        Label_titulo_producto2.Text = ""
        Label_titulo_producto1.Text = ""
        Label_titulo_producto3.Text = ""
        Label_titulo_producto4.Text = Textbox_Nombre.Text

        Panel_busqueda.Visible = False

        TabControl1.SelectTab(0)

        TextBox_codprod.Enabled = True

        Button_eliminar.Enabled = False


        Me.TextBox_barras.Focus()


    End Sub

    Private Sub Form_productos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Background_GRID.CancelAsync()

    End Sub

    Private Sub Form_productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.datagridProdsList.BringToFront()


    End Sub

    Private Sub Form_productos_Shown(sender As Object, e As EventArgs) Handles Me.Shown


        If PERMISO__general(5) = "NO" Then Me.Combobox_impuestos.Enabled = False
        If PERMISO__general(5) = "NO" Then Me.ComboBox_impuestos2.Enabled = False

        If PERMISO__general(5) = "SI" Then Me.Combobox_impuestos.Enabled = True
        If PERMISO__general(5) = "SI" Then Me.ComboBox_impuestos2.Enabled = True



        'funciones de cocina
        If PERMISO__general(10) = "SI" Then
            BunifuCheckbox_COCINA.Visible = True
            BunifuCheckbox_PARRILLA.Visible = True
            BunifuCheckbox_BAR.Visible = True

            Label_cocina.Visible = True
            Label_parrilla.Visible = True
            Label_bar.Visible = True

        End If


        If PERMISO__general(10) = "NO" Then
            BunifuCheckbox_COCINA.Visible = False
            BunifuCheckbox_PARRILLA.Visible = False
            BunifuCheckbox_BAR.Visible = False

            Label_cocina.Visible = False
            Label_parrilla.Visible = False
            Label_bar.Visible = False

        End If



        If MiConex.ConexTest() Then
            Cursor.Current = Cursors.WaitCursor
            Try
                Dim dt_CatList As DataTable = miconex.Buscar("SELECT cons, concat(tipo,'  | ',LTRIM(RTRIM(categoria))) as cat FROM PRODUCTOS_CATEGORIAS ORDER BY TIPO, CATEGORIA")
                cant_cats = dt_CatList.Rows.Count 'cantidad de categorias
                label_info_cant_cats.Text = cant_cats & " Categorías."

                ComboBox_categoria.DataSource = dt_CatList.DefaultView
                ComboBox_categoria.DisplayMember = "cat"
                ComboBox_categoria.ValueMember = "CONS"

                dt_categorias2 = New DataTable
                dt_categorias2 = dt_CatList.Copy()
                Combobox_categoria_buscar.DataSource = dt_categorias2.DefaultView
                Combobox_categoria_buscar.DisplayMember = "cat"
                Combobox_categoria_buscar.ValueMember = "CONS"
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conex.Close()
            End Try

        Else
            MessageBox.Show("Error de acceso a datos: " & miconex.ConexRta.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If


        Cursor.Current = Cursors.Default





        'impuestos
        Try
            sql = "SELECT cons, TIPOIMP, porcentaje, nombre FROM impuestos where tipo='VENTAS' and tipoimp='VALOR'"
            da_impuestosVentas = New MySqlDataAdapter(sql, conex)
            sql = "SELECT cons, TIPOIMP, porcentaje, nombre FROM impuestos where tipo='VENTAS' and tipoimp='PORCENTAJE'"
            da_impuestosVentas2 = New MySqlDataAdapter(sql, conex)

            dt_impuestosVentas = New DataTable
            dt_impuestosVentas2 = New DataTable

            da_impuestosVentas.Fill(dt_impuestosVentas)
            da_impuestosVentas2.Fill(dt_impuestosVentas2)

            Combobox_impuestos.DataSource = dt_impuestosVentas.DefaultView
            ComboBox_impespejo1.DataSource = dt_impuestosVentas.DefaultView

            Combobox_impuestos.DisplayMember = "nombre"
            Combobox_impuestos.ValueMember = "CONS"

            ComboBox_impespejo1.DisplayMember = "tipoimp"
            ComboBox_impespejo1.ValueMember = "PORCENTAJE"

            ComboBox_impuestos2.DataSource = dt_impuestosVentas2.DefaultView
            ComboBox_impespejo2.DataSource = dt_impuestosVentas2.DefaultView

            ComboBox_impuestos2.DisplayMember = "nombre"
            ComboBox_impuestos2.ValueMember = "CONS"

            ComboBox_impespejo2.DisplayMember = "tipoimp"
            ComboBox_impespejo2.ValueMember = "PORCENTAJE"
        Catch ex As Exception
            Cursor.Current = Cursors.Default

            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_impuestosVentas.Dispose()
        dt_impuestosVentas.Dispose()

        da_impuestosVentas2.Dispose()
        dt_impuestosVentas2.Dispose()
        conex.Close()
        Cursor.Current = Cursors.Default

        filtro_TIPO = " AND TIPO IN('PRODUCTOS','PROCESADOS','INSUMOS','SERVICIOS')"



        ComboBox_bods.Items.Clear()
        Try
            sql = "SELECT nombrebodega from BODEGAs"

            da_bodsinfo = New MySqlDataAdapter(sql, conex)
            dt_bodsinfo = New DataTable
            da_bodsinfo.Fill(dt_bodsinfo)
            For Each rowb As DataRow In dt_bodsinfo.Rows
                Dim bod_nom = rowb.Item("nombrebodega")

                ComboBox_bodegasInfo.Items.Add(bod_nom)

            Next
        Catch ex As Exception
        End Try

        da_bodsinfo.Dispose()
        dt_bodsinfo.Dispose()
        conex.Close()
        ComboBox_bodegasInfo.SelectedIndex = 0

        NumericUpDown_anoconsulta.Value = DateTime.Now.Year

        Me.Timer_load.Enabled = True
        Panel_buttons.BringToFront()

    End Sub

    Private Sub Timer_load_Tick(sender As Object, e As EventArgs) Handles Timer_load.Tick
        Me.Timer_load.Enabled = False

        'llena_grid_PRODUCTOS()



        Combobox_categoria_buscar.Text = ""
        Me.RadioButton_nombre.Checked = True
        Button2_Click(Nothing, Nothing)

    End Sub



    Private Sub llena_grid_PRODUCTOS_EXPORT(ByVal pdf_xls As String)
        Try
            If pdf_xls = "xls" Then sql = "SELECT * FROM productos order by categoria, nombre"

            da_pdf = New MySqlDataAdapter(sql, conex)
            dt_pdf = New DataTable
            da_pdf.Fill(dt_pdf)
            Me.MetroGrid_pdf.DataSource = dt_pdf
            Me.MetroGrid_pdf.CurrentCell = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
            conex.Close()
            da_pdf.Dispose()
            dt_pdf.Dispose()
        End Try
        conex.Close()
        da_pdf.Dispose()
        dt_pdf.Dispose()

    End Sub
    Private Sub Button_guardar_Click(sender As Object, e As EventArgs) Handles Button_guardar.Click
        Dim prod_alerta As String = ""

        If NumericUpDown_alerta.Value > 0 Then
            If RadioButton_hrs.Checked = True Then prod_alerta = NumericUpDown_alerta.Value & "|hrs"
            If RadioButton_mins.Checked = True Then prod_alerta = NumericUpDown_alerta.Value.ToString & "|mins"
        End If

        BunifuCheckbox_inactivos.Visible = True
        Label60.Visible = True
        label_info_cant_cats.Visible = True
        Label_info_cant_prods.Visible = True

        If String.IsNullOrEmpty(TextBox_valor1.Text) Then
            TextBox_valor1.Value = 0
        End If

        If String.IsNullOrEmpty(TextBox_valor2.Text) Then
            TextBox_valor2.Value = 0
        End If
        If String.IsNullOrEmpty(TextBox_valor3.Text) Then
            TextBox_valor3.Value = 0
        End If

        Dim ESTADO_PROD As String = ""
        If RadioButton_estado_act.Checked = True Then ESTADO_PROD = "ACTIVO"
        If RadioButton_estado_inac.Checked = True Then ESTADO_PROD = "INACTIVO"



        If que_hace = "GUARDAR" Then
            ' se guarda
            If Me.ComboBox_categoria.Text = "" Or Nothing Then MsgBox("Debe elejir la categoría del producto.", vbInformation) : Exit Sub

            If Me.Textbox_Nombre.Text = "" Then MsgBox("Debe escribir el NOMBRE del PRODUCTO", vbInformation) : Exit Sub
            If Me.ComboBox_categoria.Text = "" Or Nothing Then MsgBox("Debe elejir el tipo de producto.", vbInformation) : Exit Sub

            'If TextBox_valor2.Value <= 0 And TextBox_valor3.Value <= 0 Then
            '    If TextBox_valor1.Value <= 0 Then MsgBox("debe almenos elejir un precio para el producto") : Exit Sub
            'End If

            Dim PROD_FAV As String = ""
            If BunifuCheckbox_fav.Checked = True Then PROD_FAV = "SI"
            If BunifuCheckbox_fav.Checked = False Then PROD_FAV = "NO"

            If BunifuCheckbox_COCINA.Checked = True Then
                PARA_COCINAR = "SI"
            End If
            If BunifuCheckbox_COCINA.Checked = False Then
                PARA_COCINAR = "NO"
            End If
            If BunifuCheckbox_PARRILLA.Checked = True Then
                PARA_PARRILLA = "SI"
            End If
            If BunifuCheckbox_PARRILLA.Checked = False Then
                PARA_PARRILLA = "NO"
            End If
            If BunifuCheckbox_BAR.Checked = True Then
                PARA_BAR = "SI"
            End If
            If BunifuCheckbox_BAR.Checked = False Then
                PARA_BAR = "NO"
            End If

            Dim prod_lote As String = "NO"
            If BunifuCheckbox_LOTE.Checked = True Then prod_lote = "SI"
            If BunifuCheckbox_LOTE.Checked = False Then prod_lote = "NO"


            Dim prod_VENCE As String = "NO"
            If BunifuCheckbox_VENCE.Checked = True Then prod_VENCE = "SI"
            If BunifuCheckbox_VENCE.Checked = False Then prod_VENCE = "NO"

            Dim prod_KIT As String = "NO"
            If Checkbox_kit.Checked = True Then prod_KIT = "SI"
            If Checkbox_kit.Checked = False Then prod_KIT = "NO"

            Dim catdata() As String
            catdata = Split(ComboBox_categoria.Text, "|")

            CATEGORIA_GUARDAR = catdata(1)
            TIPOCATEGORIA_GUARDAR = catdata(0)
            CATEGORIA_GUARDAR = Trim(CATEGORIA_GUARDAR)
            TIPOCATEGORIA_GUARDAR = Trim(TIPOCATEGORIA_GUARDAR)

            Dim costoprod As String = Me.NUMERIC_costo.Value
            costoprod = CStr(costoprod).Replace(".", "")

            Me.Cursor = Cursors.WaitCursor

            Me.Button_buscar.Enabled = True
            Me.Combobox_categoria_buscar.Enabled = True
            If imagepath <> Nothing Then imagepath = imagepath.ToString.Replace("\", "\\")
            sql = "INSERT INTO productos (cod, CODBARRAS, nombre, descripcion, presentacion, CATEGORIA, iva, iva2, costo, valor, valor2, valor3, stock, INVENTARIADO, ESTADO, imagen, tipo, ivatipo, ivatipo2, impid1, impid2, impnom1, impnom2, DECIMALES, COCINA, PARRILLA, BAR, INVIMA, lote, vence, KIT, ubicacion, maximo, alerta, sugerido, REF, FAV)" &
                      "VALUES (" & CLng(Me.TextBox_codprod.Text) & ",'" & CStr(Me.TextBox_barras.Text) & "','" & CStr(Me.Textbox_Nombre.Text) & "','" & CStr(Me.Textbox_descripcion.Text) & "','" & CStr(Me.TextBox_presentacion.Text) & "','" & CStr(Me.CATEGORIA_GUARDAR) & "','" & CStr(TextBox_espejo1.Text.ToString) & "','" & CStr(TextBox_espejo2.Text.ToString) & "','" & costoprod & "'," & CInt(Me.TextBox_valor1.Text) & "," & CInt(Me.TextBox_valor2.Text) & "," & CInt(Me.TextBox_valor3.Text) & "," & CInt(Me.TextBox_stock.Text) & ",'" & CStr(Me.ComboBox_INVENTARIO.Text) & "','" & CStr(ESTADO_PROD) & "', '" & imagepath & "','" & CStr(TIPOCATEGORIA_GUARDAR) & "','" & CStr(Me.ComboBox_impespejo1.Text) & "','" & CStr(Me.ComboBox_impespejo2.Text) & "','" & CStr(Combobox_impuestos.SelectedValue) & "','" & CStr(ComboBox_impuestos2.SelectedValue) & "','" & CStr(Combobox_impuestos.Text) & "','" & CStr(ComboBox_impuestos2.Text) & "','" & CStr(MetroComboBox_decimales.Text) & "','" & CStr(PARA_COCINAR) & "','" & CStr(PARA_PARRILLA) & "','" & CStr(PARA_BAR) & "','" & CStr(TextBox_INVIMA.Text) & "','" & CStr(prod_lote) & "','" & CStr(prod_VENCE) & "','" & CStr(prod_KIT) & "','" & TextBox_ubicacion.Text & "'," & TextBox_stock_maximo.Text & ",'" & prod_alerta & "','" & TextBox_sugerido.Text & "','" & TextBox_ref.Text & "','" & PROD_FAV & "')"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                If ex.ToString.Contains("Duplicate entry") Then MsgBox("Error al crear el producto, puede que el código ya este asignado", vbExclamation)
                MsgBox(ex.ToString)
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()

            Me.datagridProdsList.Enabled = True

            Me.Textbox_Nombre.Enabled = False
            Me.TextBox_presentacion.Enabled = False

            Me.Textbox_descripcion.Enabled = False
            Me.TextBox_valor1.Enabled = False
            Me.NUMERIC_costo.Enabled = False

            Me.Combobox_impuestos.Enabled = False
            Me.TextBox_barras.Enabled = False
            Me.TextBox_stock.Enabled = False
            Me.Button_guardar.Enabled = False
            Me.Button_cancelar.Enabled = False
            Me.Panel_buttons.Visible = True
            Me.Panel_busqueda.Enabled = True
            Me.Panel_busqueda.Cursor = Cursors.Default

            Checkbox_kit.Enabled = True

            Me.Cursor = Cursors.Default
            Me.Button_guardar.Visible = False
            Me.Button_cancelar.Visible = False
            Me.PictureBox_image.Enabled = False
            codproducto = 0


            imagepath = ""
            OpenFileDialog1.Dispose()
            Me.PictureBox_image.Image = Nothing
            Application.DoEvents()
            If PictureBox_image.ImageLocation <> Nothing Then
                Kill(PictureBox_image.ImageLocation)
            End If
            que_hace = ""
            Me.Button_cancelar_Click(Nothing, Nothing)

            Panel_busqueda.Visible = True


            Button2_Click(Nothing, Nothing)

            Exit Sub

        End If

        If que_hace = "MODIFICAR" Then
            Me.Cursor = Cursors.WaitCursor

            If Me.ComboBox_categoria.Text = "" Or Nothing Then MsgBox("Debe elejir la categoría del producto.", vbInformation) : Exit Sub


            If BunifuCheckbox_COCINA.Checked = True Then
                PARA_COCINAR = "SI"
            End If
            If BunifuCheckbox_COCINA.Checked = False Then
                PARA_COCINAR = "NO"
            End If
            If BunifuCheckbox_PARRILLA.Checked = True Then
                PARA_PARRILLA = "SI"
            End If
            If BunifuCheckbox_PARRILLA.Checked = False Then
                PARA_PARRILLA = "NO"
            End If
            If BunifuCheckbox_BAR.Checked = True Then
                PARA_BAR = "SI"
            End If
            If BunifuCheckbox_BAR.Checked = False Then
                PARA_BAR = "NO"
            End If

            If TextBox_stock.Text = "" Then TextBox_stock.Text = 0
            If Me.Textbox_Nombre.Text = "" Then MsgBox("Debe escribir el NOMBRE del PRODUCTO", vbInformation) : Exit Sub
            If Me.TextBox_valor1.Text = "" Then MsgBox("Debe escribir el PRECIO del PRODUCTO", vbInformation) : Exit Sub
            If Me.Combobox_impuestos.Text = Nothing Then MsgBox("Debe seleccionar una opción en IMPUESTOS del PRODUCTO", vbInformation) : Exit Sub

            imagepath = imagepath.ToString.Replace("\", "\\")


            Me.Button_buscar.Enabled = True
            Me.Combobox_categoria_buscar.Enabled = True


            Dim prod_lote As String = "NO"
            If BunifuCheckbox_PARRILLA.Checked = True Then prod_lote = "SI"
            If BunifuCheckbox_PARRILLA.Checked = False Then prod_lote = "NO"


            Dim prod_VENCE As String = "NO"
            If BunifuCheckbox_BAR.Checked = True Then prod_VENCE = "SI"
            If BunifuCheckbox_BAR.Checked = False Then prod_VENCE = "NO"


            Dim prod_KIT As String = "NO"
            If Checkbox_kit.Checked = True Then prod_KIT = "SI"
            If Checkbox_kit.Checked = False Then prod_KIT = "NO"

            Dim catdata() As String
            catdata = Split(ComboBox_categoria.Text, "|")

            CATEGORIA_GUARDAR = Trim(catdata(1))
            TIPOCATEGORIA_GUARDAR = Trim(catdata(0))
            CATEGORIA_GUARDAR = Trim(CATEGORIA_GUARDAR)
            TIPOCATEGORIA_GUARDAR = Trim(TIPOCATEGORIA_GUARDAR)

            sql = "UPDATE PRODUCTOS SET CODBARRAS='" & CStr(Me.TextBox_barras.Text) & "', NOMBRE='" & CStr(Me.Textbox_Nombre.Text) & "', descripcion='" & CStr(Me.Textbox_descripcion.Text) & "', presentacion='" & CStr(Me.TextBox_presentacion.Text) & "', categoria='" & CATEGORIA_GUARDAR & "', iva='" & TextBox_espejo1.Text.ToString & "', iva2='" & TextBox_espejo2.Text.ToString & "', costo='" & Me.NUMERIC_costo.Value & "', valor=" & CInt(Me.TextBox_valor1.Value) & ", valor2=" & CInt(Me.TextBox_valor2.Value) & ", valor3=" & CInt(Me.TextBox_valor3.Value) & ", stock=" & CInt(Me.TextBox_stock.Text) & ", ESTADO='" & CStr(ESTADO_PROD) & "', INVENTARIADO='" & CStr(Me.ComboBox_INVENTARIO.Text) & "', imageN='" & imagepath & "', ivatipo='" & CStr(ComboBox_impespejo1.Text.ToString) & "', ivatipo2='" & CStr(ComboBox_impespejo2.Text.ToString) & "', impid1='" & CStr(Combobox_impuestos.SelectedValue.ToString) & "', impid2='" & CStr(ComboBox_impuestos2.SelectedValue.ToString) & "', impnom1='" & CStr(Combobox_impuestos.Text.ToString) & "', impnom2='" & CStr(ComboBox_impuestos2.Text.ToString) & "', decimales='" & MetroComboBox_decimales.Text & "', TIPO='" & CStr(TIPOCATEGORIA_GUARDAR) & "', COCINA='" & CStr(PARA_COCINAR) & "', PARRILLA='" & CStr(PARA_PARRILLA) & "', BAR='" & CStr(PARA_BAR) & "', INVIMA='" & CStr(TextBox_INVIMA.Text) & "', lote='" & CStr(prod_lote) & "', vence='" & CStr(prod_VENCE) & "', KIT='" & CStr(prod_KIT) & "', ubicacion='" & CStr(TextBox_ubicacion.Text) & "', maximo='" & CStr(TextBox_stock_maximo.Text) & "', alerta='" & CStr(prod_alerta) & "', sugerido='" & CStr(TextBox_sugerido.Text) & "', REF='" & CStr(TextBox_ref.Text) & "' WHERE COD=" & codproducto & ""
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

            Me.datagridProdsList.Enabled = True

            Me.Textbox_Nombre.Enabled = False
            Me.Textbox_descripcion.Enabled = False
            Me.TextBox_valor1.Enabled = False
            Me.NUMERIC_costo.Enabled = False

            Me.TextBox_barras.Enabled = False
            Me.Combobox_impuestos.Enabled = False
            Me.TextBox_stock.Enabled = False
            Me.Button_guardar.Enabled = False
            Me.Button_cancelar.Enabled = False
            Me.Panel_buttons.Visible = True
            Me.Panel_busqueda.Enabled = True
            Me.Button_guardar.Visible = False
            Me.Button_cancelar.Visible = False
            Me.PictureBox_image.Enabled = False
            Me.Cursor = Cursors.Default
            codproducto = 0


            imagepath = ""
            OpenFileDialog1.Dispose()


            Me.PictureBox_image.Image = Nothing
            Application.DoEvents()
            If PictureBox_image.ImageLocation <> Nothing Then
                Kill(PictureBox_image.ImageLocation)
            End If

            que_hace = ""
            Button_cancelar_Click(Nothing, Nothing)
            Panel_busqueda.Visible = True


            Button2_Click(Nothing, Nothing)

            Exit Sub
        End If

    End Sub

    Private Sub Button_cancelar_Click(sender As Object, e As EventArgs) Handles Button_cancelar.Click

        BunifuCheckbox_inactivos.Visible = True
        Label60.Visible = True
        label_info_cant_cats.Visible = True
        Label_info_cant_prods.Visible = True

        Me.Textbox_Nombre.Enabled = False
        Me.TextBox_presentacion.Enabled = False

        Me.Textbox_descripcion.Enabled = False
        Me.TextBox_valor1.Enabled = False
        Me.NUMERIC_costo.Enabled = False

        Me.Combobox_impuestos.Enabled = False
        Me.TextBox_barras.Enabled = False
        Me.TextBox_stock.Enabled = False

        Me.Button_guardar.Enabled = True
        Me.Button_cancelar.Enabled = True
        Me.Panel_buttons.Visible = True
        Me.Panel_busqueda.Enabled = True
        Me.Panel_busqueda.Cursor = Cursors.Default
        Me.datagridProdsList.Visible = True
        Me.Textbox_Nombre.Text = ""
        Me.Textbox_descripcion.Text = ""
        Me.TextBox_valor1.Text = "0"
        Me.NUMERIC_costo.Value = "0"
        Me.codproducto = 0
        Me.TextBox_stock.Text = 0
        Me.TextBox_INVIMA.Text = ""

        ABRIR_TIPO_DOC = ""

        Me.ComboBox_categoria.Text = "General"

        CATEGORIA_GUARDAR = ""
        TIPOCATEGORIA_GUARDAR = ""

        Me.Button_guardar.Visible = False
        Me.Button_cancelar.Visible = False
        Me.TextBox_codprod.Text = "-"
        Me.PictureBox_image.Enabled = False

        Me.Button_buscar.Enabled = True
        Me.Combobox_categoria_buscar.Enabled = True
        codproducto = 0

        NumericUpDown_alerta.Value = 0

        TextBox_sugerido.Text = 0
        TextBox_stock_maximo.Text = "0"

        imagepath = ""

        Me.PictureBox_image.Image = Nothing
        Application.DoEvents()
        If PictureBox_image.ImageLocation <> Nothing Then
            Kill(PictureBox_image.ImageLocation)
        End If

        Me.datagridProdsList.ClearSelection()

        Grid_kit.DataSource = Nothing


        'Try
        '    sql = "SELECT cons, CATEGORIA FROM PRODUCTOS_CATEGORIAS"
        '    da = New MySqlDataAdapter(sql, conex)
        '    dt_categorias = New DataTable
        '    dt_categorias2 = New DataTable
        '    da.Fill(dt_categorias)
        '    da.Fill(dt_categorias2)
        '    ComboBox_categoria.DataSource = dt_categorias.DefaultView
        '    ComboBox_categoria.DisplayMember = "categoria"
        '    ComboBox_categoria.ValueMember = "categoria"

        '    ComboBox_categoria2.DataSource = dt_categorias2.DefaultView
        '    ComboBox_categoria2.DisplayMember = "categoria"
        '    ComboBox_categoria2.ValueMember = "categoria"
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'conex.Close()
        'da.Dispose()
        'dt_categorias.Dispose()
        'dt_categorias2.Dispose()
        'conex.Close()

        Me.ComboBox_categoria.SelectedItem = Nothing
        Me.Combobox_categoria_buscar.SelectedItem = Nothing
        que_hace = ""

        Panel_KIT.Visible = False
        Panel_busqueda.Visible = True

        Grid_InfoProd.DataSource = Nothing

    End Sub

    Private Sub Btn_Ver_editar_Click(sender As Object, e As EventArgs) Handles Btn_Ver_editar.Click
        If PERMISO_1(10) = "NO" Or PERMISO_1(10) = Nothing Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub

        codproducto = 0

        If IsDBNull(datagridProdsList.Item("cod", 0).Value) Then
            Exit Sub
        End If


        Dim row As DataGridViewRow = datagridProdsList.CurrentRow

        codproducto = CLng(row.Cells("cod").Value)


        If codproducto = 0 Then MsgBox("Seleccione un producto de la lista.", vbInformation) : Exit Sub




        CATEGORIA_GUARDAR = ""
        TIPOCATEGORIA_GUARDAR = ""




        Me.PictureBox_image.Image = Nothing
        Application.DoEvents()
        If PictureBox_image.ImageLocation <> Nothing Then
            Kill(PictureBox_image.ImageLocation)
        End If


        'PRODUCTO FAVORITO
        If CStr(row.Cells("fav").Value) = "NO" Or CStr(row.Cells("fav").Value) = "" Then
            BunifuCheckbox_fav.Checked = False
        Else
            BunifuCheckbox_fav.Checked = True
        End If


        Me.PictureBox_image.Image = Me.PictureBox_image.InitialImage
        Me.PictureBox_image.Refresh()
        codproducto = 0
        codproducto = CLng(row.Cells("cod").Value)
        Me.TextBox_codprod.Text = codproducto
        Me.TextBox_barras.Text = CStr(row.Cells("CODBArras").Value)

        Me.Textbox_Nombre.Text = CStr(row.Cells("nombre").Value)
        Label_titulo_producto2.Text = Textbox_Nombre.Text
        Label_titulo_producto1.Text = Textbox_Nombre.Text
        Label_titulo_producto3.Text = Textbox_Nombre.Text
        Label_titulo_producto4.Text = Textbox_Nombre.Text

        Me.TextBox_presentacion.Text = CStr(row.Cells("presentacion").Value)

        Me.Textbox_descripcion.Text = CStr(row.Cells("descripcion").Value)
        puede_cacular_utilidad = False

        Me.TextBox_valor1.Text = CInt(row.Cells("valor").Value)
        Me.TextBox_valor2.Text = CInt(row.Cells("valor2").Value)
        Me.TextBox_valor3.Text = CInt(row.Cells("valor3").Value)

        Me.TextBox_ref.Text = CStr(row.Cells("ref").Value)


        If CStr(row.Cells("estado").Value) = "ACTIVO" Then RadioButton_estado_act.Checked = True
        If CStr(row.Cells("estado").Value) = "INACTIVO" Then RadioButton_estado_inac.Checked = True


        'Label_CATEGORIA_GUARDAR.Text = CStr(row.Cells("categoria").Value)
        'Me.LABEL_TIPOPROD.Text = CStr(row.Cells("TIPO").Value)

        Me.ComboBox_categoria.Text = Trim(CStr(row.Cells("TIPO").Value)) & "  | " & Trim(CStr(row.Cells("categoria").Value))


        Timer_TIPO_CATEGORIA.Enabled = True


        Me.NUMERIC_costo.Value = CDec(row.Cells("costo").Value)

        Me.Textbox_Nombre.Enabled = False
        Me.Textbox_descripcion.Enabled = False
        Me.TextBox_valor1.Enabled = False
        Me.TextBox_stock.Text = CStr(row.Cells("STOCK").Value)
        Me.TextBox_stock_maximo.Text = CStr(row.Cells("maximo").Value)
        Me.TextBox_sugerido.Text = CStr(row.Cells("sugerido").Value)

        Me.Combobox_impuestos.Text = CStr(row.Cells("impnom1").Value)
        Me.ComboBox_impuestos2.Text = CStr(row.Cells("impnom2").Value)
        Me.MetroComboBox_decimales.Text = CStr(row.Cells("DECIMALES").Value)
        Me.TextBox_INVIMA.Text = CStr(row.Cells("INVIMA").Value)


        PARA_COCINAR = CStr(row.Cells("cocina").Value)
        PARA_PARRILLA = CStr(row.Cells("PARRILLA").Value)
        PARA_BAR = CStr(row.Cells("BAR").Value)



        If PARA_COCINAR = "SI" Then
            BunifuCheckbox_COCINA.Checked = True
        End If
        If PARA_COCINAR = "NO" Then
            BunifuCheckbox_COCINA.Checked = False
        End If

        If PARA_PARRILLA = "SI" Then
            BunifuCheckbox_PARRILLA.Checked = True
        End If
        If PARA_PARRILLA = "NO" Then
            BunifuCheckbox_PARRILLA.Checked = False
        End If
        If PARA_BAR = "SI" Then
            BunifuCheckbox_BAR.Checked = True
        End If
        If PARA_BAR = "NO" Then
            BunifuCheckbox_BAR.Checked = False
        End If


        If CStr(row.Cells("LOTE").Value) = "SI" Then BunifuCheckbox_PARRILLA.Checked = True
        If CStr(row.Cells("LOTE").Value) = "NO" Or CStr(row.Cells("LOTE").Value) = "" Then BunifuCheckbox_PARRILLA.Checked = False

        If CStr(row.Cells("VENCE").Value) = "SI" Then BunifuCheckbox_BAR.Checked = True
        If CStr(row.Cells("VENCE").Value) = "NO" Or CStr(row.Cells("VENCE").Value) = "" Then BunifuCheckbox_BAR.Checked = False

        If CStr(row.Cells("KIT").Value) = "SI" Then Checkbox_kit.Checked = True : Panel_KIT.Visible = True : grid_prods_kit() : Label_kit_title.Text = "Kit del Producto (" & Textbox_Nombre.Text & ")"
        If CStr(row.Cells("KIT").Value) = "NO" Or CStr(row.Cells("KIT").Value) = "" Then Checkbox_kit.Checked = False : Panel_KIT.Visible = False : Label_kit_title.Text = "Kit del Producto"

        'revisar receta
        'If CStr(row.Cells("receta").Value) = "SI" Then Checkbox_kit.Checked = True : Panel_KIT.Visible = True : grid_prods_kit() : Label_kit_title.Text = "Kit del Producto (" & Textbox_Nombre.Text & ")"
        'If CStr(row.Cells("receta").Value) = "NO" Or CStr(row.Cells("KIT").Value) = "" Then Checkbox_kit.Checked = False : Panel_KIT.Visible = False : Label_kit_title.Text = "Kit del Producto"


        NumericUpDown_alerta.Value = 0

        If CStr(row.Cells("ALERTA").Value) <> "" Then
            Dim alerta_tiempo() As String

            alerta_tiempo = Strings.Split(CStr(row.Cells("ALERTA").Value), "|")
            NumericUpDown_alerta.Value = alerta_tiempo(0).ToString
            If alerta_tiempo(1).ToString = "hrs" Then RadioButton_hrs.Checked = True
            If alerta_tiempo(1).ToString = "mins" Then RadioButton_mins.Checked = True
        End If



        'Timer_impuesto.Enabled = True
        Me.TextBox_espejo1.Text = CStr(row.Cells("iva").Value)
        Me.TextBox_espejo2.Text = CStr(row.Cells("iva2").Value)

        Me.ComboBox_INVENTARIO.Text = CStr(row.Cells("INVENTARIADO").Value)



        'imagen
        imagepath = CStr(row.Cells("IMAGEN").Value)

        If imagepath <> "" And File.Exists(imagepath) = True Then
            Try
                PictureBox_image.Image = Drawing.Image.FromFile(imagepath)
            Catch ex As Exception
                PictureBox_image.Image = Nothing
            End Try
        Else
            PictureBox_image.Image = Nothing

        End If











        Label_utilidad_Click(Nothing, Nothing)


        Label_utilidad2_Click(Nothing, Nothing)


        Label_utilidad3_Click(Nothing, Nothing)




        'carga el tipo d eproducto
        Try
            sql = "SELECT productos_categorias.tipo as tipo FROM productos, productos_categorias 
where productos.Categoria=productos_categorias.categoria and productos.cod=" & CStr(TextBox_codprod.Text) & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each roww As DataRow In dt.Rows
                TIPOCATEGORIA_GUARDAR = roww.Item("tipo")
            Next
        Catch ex As Exception
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()





        BunifuCheckbox_inactivos.Visible = False
        Label60.Visible = False
        label_info_cant_cats.Visible = False
        Label_info_cant_prods.Visible = False


        que_hace = "MODIFICAR"
        Checkbox_kit.Enabled = True



        Me.Textbox_Nombre.Enabled = True
        Me.TextBox_presentacion.Enabled = True

        Me.Textbox_descripcion.Enabled = True
        Me.TextBox_valor1.Enabled = True
        Me.NUMERIC_costo.Enabled = True

        Me.Combobox_impuestos.Enabled = True
        Me.TextBox_barras.Enabled = True
        Me.TextBox_stock.Enabled = True

        Me.PictureBox_image.Enabled = True
        Me.Panel_buttons.Visible = False
        Me.Panel_busqueda.Enabled = False
        Me.Panel_busqueda.Cursor = Cursors.No


        Me.datagridProdsList.Visible = False
        Me.Button_cancelar.Enabled = True : Me.Button_cancelar.Visible = True
        Me.Button_guardar.Enabled = True : Me.Button_guardar.Visible = True
        Me.ComboBox_INVENTARIO.Enabled = True
        Me.datagridProdsList.CurrentCell = Nothing

        If PERMISO__general(5) = "NO" Then
            Combobox_impuestos.Enabled = False

            ComboBox_impuestos2.Enabled = False

            Timer_impuesto.Enabled = True
        End If

        BUSCA_SALDO_PRODUCTO()

        BUSCA_precios_compra()

        If Me.ComboBox_INVENTARIO.Text = "SI" Then

            If CInt(TextBox_existencias.Text) <= CInt(Me.TextBox_stock.Text) Then Label20.Visible = True
            Me.TextBox_stock.Enabled = True
            Me.TextBox_stock_maximo.Enabled = True

        Else
            Me.TextBox_stock.Enabled = False
            Me.TextBox_stock_maximo.Enabled = False

        End If

        puede_cacular_utilidad = True

        Timer_UTILIDAD.Enabled = True

        'si tiene kit y los costos ssson distintos se actualiza costo
        If Checkbox_kit.Checked = True Then
            If TextBox_total_costo_kit.Text <> NUMERIC_costo.Value.ToString Then
                NUMERIC_costo.Value = TextBox_total_costo_kit.Text
                sql = "UPDATE PRODUCTOS SET  costo='" & Me.NUMERIC_costo.Value & "' WHERE COD=" & codproducto & ""
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
            End If
        End If


        TextBox_codprod.Enabled = False

        Panel_busqueda.Visible = False
        TabControl1.SelectTab(0)

        Button_eliminar.Enabled = True


        Me.TextBox_barras.Focus()

    End Sub

    Private Sub BUSCA_SALDO_PRODUCTO()
        Me.Cursor = Cursors.WaitCursor

        TextBox_entradas.Text = "0"
        TextBox_salidas.Text = "0"
        TextBox_existencias.Text = "0"
        Try
            sql = "SELECT sum(entran) as entran, sum(salen) as salen, sum(entran) - sum(salen) as saldo FROM bodega_" & ComboBox_bodegasInfo.Text & " where CodProducto='" & CLng(codproducto) & "'"
            da_SALDOS = New MySqlDataAdapter(sql, conex)
            dt_saldos = New DataTable
            da_SALDOS.Fill(dt_saldos)
            For Each row As DataRow In dt_saldos.Rows
                TextBox_entradas.Text = row.Item("entran")
                TextBox_salidas.Text = row.Item("salen")
                TextBox_existencias.Text = row.Item("saldo")
            Next
        Catch ex As Exception
            ex.ToString()
        End Try

        da_SALDOS.Dispose()
        dt_saldos.Dispose()
        conex.Close()

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BUSCA_precios_compra()
        Me.Cursor = Cursors.WaitCursor
        TextBox_prom_compra.Text = "0"





        'Try
        '    sql = "SELECT nombre from BODEGAs"

        '    da_bods = New MySqlDataAdapter(sql, conex)
        '    dt_bods = New DataTable
        '    da_bods.Fill(dt_bods)
        '    For Each rowb As DataRow In dt_bods.Rows
        '        Dim bod_nom = rowb.Item("nombre")

        '        Try
        '            If comex_costo = "PROMEDIO" Then sql = "SELECT IFNULL(AVG(VALORU),0) as promedio FROM BODEGA_" & ComboBox_bodegasInfo.Text & " where codproducto='" & CInt(codproducto) & "' AND TIPODOCUMENTO IN('Entrada de Mercancia','Inventario Inicial','COMPRA') and estado='DESCARGADO'"
        '            If comex_costo = "MAXIMO" Then sql = "SELECT IFNULL(MAX(VALORU),O) FROM BODEGA_" & ComboBox_bodegasInfo.Text & " where codproducto='" & CInt(codproducto) & "' AND TIPODOCUMENTO IN('Entrada de Mercancia','Inventario Inicial','COMPRA') and estado='DESCARGADO'"
        '            If comex_costo = "ULTIMO" Then sql = "SELECT MAX(CONS), IFNULL(VALORU,0) FROM BODEGA_" & ComboBox_bodegasInfo.Text & " where codproducto='" & CInt(codproducto) & "' AND TIPODOCUMENTO IN('Entrada de Mercancia','Inventario Inicial','COMPRA') and estado='DESCARGADO'"
        '            If comex_costo = "MINIMO" Then sql = "SELECT IFNULL(MIN(VALORU),O) FROM BODEGA_" & ComboBox_bodegasInfo.Text & " where codproducto='" & CInt(codproducto) & "' AND TIPODOCUMENTO IN('Entrada de Mercancia','Inventario Inicial','COMPRA') and estado='DESCARGADO'"

        '            da = New MySqlDataAdapter(sql, conex)
        '            dt = New DataTable
        '            da.Fill(dt)
        '            For Each row As DataRow In dt.Rows
        '                TextBox_prom_compra.Text = row.Item("promedio")
        '            Next

        '        Catch ex As Exception
        '        End Try
        '        da.Dispose()
        '        dt.Dispose()
        '        conex.Close()

        '    Next
        'Catch ex As Exception
        'End Try

        'da_bods.Dispose()
        'dt_bods.Dispose()
        'conex.Close()

        'costo================





        'costo  DESDE PEDIDOS   ===========

        Try
            sql = "SELECT avg(valoru) as promedio FROM pedidosprov_prods where CodProd=" & CInt(codproducto) & " and estado<>'ANULADO'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                TextBox_prom_compra.Text = CDec(row.Item("promedio"))
            Next
        Catch ex As Exception
        End Try

        da.Dispose()
        dt.Dispose()
        conex.Close()
        'costo================





        TextBox_ult_compra.Text = "0"
        Try
            sql = "SELECT cons, valoru FROM pedidosprov_prods where CodProd=" & CInt(codproducto) & " and estado<>'ANULADO' order by cons desc limit 1"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                TextBox_ult_compra.Text = row.Item("valoru")
            Next
        Catch ex As Exception
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()


        TextBox_min_compra.Text = "0"
        TextBox_max_compra.Text = "0"
        Try
            sql = "SELECT min(valoru) as minimo, MAX(valoru) as maximo FROM pedidosprov_prods where CodProd=" & CInt(codproducto) & " and estado<>'ANULADO'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                TextBox_min_compra.Text = row.Item("minimo")
                TextBox_max_compra.Text = row.Item("maximo")
            Next
        Catch ex As Exception
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()


        'If TIPOCATEGORIA_GUARDAR = "PRODUCTOS" Or TIPOCATEGORIA_GUARDAR = "INSUMOS" Then
        '    If comex_costo = "PROMEDIO" Then NUMERIC_costo.Value = TextBox_prom_compra.Text
        '    If comex_costo = "MAXIMO" Then NUMERIC_costo.Value = TextBox_max_compra.Text
        '    If comex_costo = "ULTIMO" Then NUMERIC_costo.Value = TextBox_ult_compra.Text
        '    If comex_costo = "MINIMO" Then NUMERIC_costo.Value = TextBox_min_compra.Text
        'End If

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Btn_salir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox_image.Click
        OpenFileDialog1.InitialDirectory = desktop2
        If Me.OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox_image.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
            imagepath = OpenFileDialog1.FileName.ToString
        Else
            imagepath = ""
        End If
    End Sub





    Private Sub TextBox_stock_GotFocus(sender As Object, e As EventArgs) Handles TextBox_stock.GotFocus
        Me.TextBox_stock.BackColor = Color.MistyRose

    End Sub

    Private Sub TextBox_stock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_stock.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""
    End Sub

    Private Sub TextBox_stock_LostFocus(sender As Object, e As EventArgs) Handles TextBox_stock.LostFocus
        Me.TextBox_stock.BackColor = Color.White

    End Sub

    Private Sub TextBox_stock_TextChanged(sender As Object, e As EventArgs) Handles TextBox_stock.TextChanged

    End Sub



    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Form_categorias.Show()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button_buscar.Click
        Me.datagridProdsList.DataSource = Nothing

        If RadioButton_codigo.Checked = True And TextBox_nombrebuscar.Text = "" Then
            MsgBox("Debe Digitar un codigo.", vbInformation) : Exit Sub
        End If

        filtro_estado = ""

        If BunifuCheckbox_inactivos.Checked = False Then filtro_estado = " AND ESTADO IN('ACTIVO')"

        If CheckBox_categorias.Checked = True Then
            If RadioButton_barras.Checked = True Then sql = "SELECT PRODUCTOS.COD, PRODUCTOS.CODBARRAS, PRODUCTOS.TIPO, PRODUCTOS.CATEGORIA, CONCAT(PRODUCTOS.NOMBRE,' ',PRODUCTOS.REF,' ',PRODUCTOS.PRESENTACION), PRODUCTOS.* 
FROM PRODUCTOS WHERE codbarras='" & Me.TextBox_nombrebuscar.Text.ToString & "' AND categoria='" & CATEGORIA_BUSCAR & "'" & filtro_TIPO & filtro_estado & " order by tipo, categoria, nombre"

            If RadioButton_nombre.Checked = True Then sql = "SELECT PRODUCTOS.COD, PRODUCTOS.CODBARRAS, PRODUCTOS.TIPO, PRODUCTOS.CATEGORIA, CONCAT(PRODUCTOS.NOMBRE,' ',PRODUCTOS.REF,' ',PRODUCTOS.PRESENTACION), PRODUCTOS.* 
FROM PRODUCTOS WHERE nombre LIKE '%" & Me.TextBox_nombrebuscar.Text.ToString & "%' AND categoria='" & CATEGORIA_BUSCAR & "'" & filtro_TIPO & filtro_estado & " order by tipo, categoria, nombre"
            If RadioButton_codigo.Checked = True And IsNumeric(RadioButton_codigo.Text) = True Then sql = "SELECT PRODUCTOS.COD, PRODUCTOS.CODBARRAS, PRODUCTOS.TIPO, PRODUCTOS.CATEGORIA, CONCAT(PRODUCTOS.NOMBRE,' ',PRODUCTOS.REF,' ',PRODUCTOS.PRESENTACION), PRODUCTOS.* 
FROM PRODUCTOS WHERE cod=" & CInt(Me.TextBox_nombrebuscar.Text.ToString) & " AND categoria='" & CATEGORIA_BUSCAR & "'" & filtro_TIPO & filtro_estado & " order by tipo, categoria, nombre"
        End If


        If CheckBox_categorias.Checked = False Then
            If RadioButton_barras.Checked = True Then sql = "SELECT PRODUCTOS.COD, PRODUCTOS.CODBARRAS, PRODUCTOS.TIPO, PRODUCTOS.CATEGORIA, CONCAT(PRODUCTOS.NOMBRE,' ',PRODUCTOS.REF,' ',PRODUCTOS.PRESENTACION), PRODUCTOS.*  
FROM PRODUCTOS WHERE codbarras='" & Me.TextBox_nombrebuscar.Text & "'" & filtro_TIPO & filtro_estado & "  order by tipo, categoria, nombre"

            If RadioButton_nombre.Checked = True Then sql = "SELECT PRODUCTOS.COD, PRODUCTOS.CODBARRAS, PRODUCTOS.TIPO, PRODUCTOS.CATEGORIA, CONCAT(PRODUCTOS.NOMBRE,' ',PRODUCTOS.REF,' ',PRODUCTOS.PRESENTACION), PRODUCTOS.* 
FROM PRODUCTOS WHERE nombre LIKE '%" & Me.TextBox_nombrebuscar.Text & "%'" & filtro_TIPO & filtro_estado & " order by tipo, categoria, nombre"
            If RadioButton_codigo.Checked = True And IsNumeric(TextBox_nombrebuscar.Text) = True Then sql = "SELECT PRODUCTOS.COD, PRODUCTOS.CODBARRAS, PRODUCTOS.TIPO, PRODUCTOS.CATEGORIA, CONCAT(PRODUCTOS.NOMBRE,' ',PRODUCTOS.REF,' ',PRODUCTOS.PRESENTACION), PRODUCTOS.* 
FROM PRODUCTOS WHERE cod=" & CInt(Me.TextBox_nombrebuscar.Text) & "" & filtro_TIPO & filtro_estado & " order by tipo, categoria, nombre"
        End If

        Button_buscar.Visible = False
        Picture_LOAD.Visible = True


        'Me.datagridProdsList.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue
        For Each fila As DataGridViewRow In datagridProdsList.Rows
            If CStr(fila.Cells("estado").Value.ToString) = "INACTIVO" Then
                fila.DefaultCellStyle.ForeColor = Color.Black
                fila.DefaultCellStyle.BackColor = Color.LightGray
            End If

        Next
        With Me.datagridProdsList.DefaultCellStyle
            .ForeColor = Color.Blue
            .BackColor = Color.Beige
            .SelectionForeColor = Color.Yellow
            .SelectionBackColor = Color.Black
        End With

        Background_GRID.WorkerReportsProgress = True
        Background_GRID.WorkerSupportsCancellation = True
        Background_GRID.RunWorkerAsync()


        Cursor.Current = Cursors.WaitCursor

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button_eliminar.Click

        If PERMISO_1(11) = "NO" Or PERMISO_1(11) = Nothing Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub

        If codproducto = 0 Then
            MsgBox("Debe Seleccionar un producto para eliminar.", vbInformation) : Exit Sub
        End If


        BUSCA_SALDO_PRODUCTO()
        If TextBox_existencias.Text <> 0 Then
            MsgBox("el producto registra saldo en bodega no s epuede eliminar.", vbInformation) : Exit Sub
        End If



        Dim RTA As String
        RTA = MsgBox("Desea eliminar el producto ?.  " & Chr(13) & Chr(13) & Chr(13) & Chr(13) & "==> " & Me.Textbox_Nombre.Text.ToString, MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If RTA = 6 Then
            sql = "delete from productos where COD=" & codproducto & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
                MsgBox("Se Borró el producto.")
            Catch ex As Exception
                MsgBox("error al Borrar el producto.")
                Exit Sub
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()


            sql = "delete from productos_kit where CODprod=" & codproducto & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                MsgBox("error al Borrar el producto.")
                Exit Sub
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()


            sql = "delete from productos_receta where CODprod=" & codproducto & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                MsgBox("error al Borrar el producto.")
                Exit Sub
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()

            Button_cancelar_Click(Nothing, Nothing)

            Button2_Click(Nothing, Nothing)
        End If

        Me.Button_eliminar.Visible = True

    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button_AGREGAR_CATEGORIA.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs)
        Form_categorias.Show()
    End Sub

    Private Sub ComboBox_categoria2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub grid_prods_kit()
        Me.Cursor = Cursors.WaitCursor

        Try
            sql = "SELECT productos_kit.CONS, productos_kit.CODKIT, 
productos_kit.CODPROD, productos_kit.PRODUCTO, format(cast(replace(productos_kit.Cantidad,',','.') as decimal (10,2)),2),
FORMAT(CAST(REPLACE(PRODUCTOS.COSTO,',','.') AS DECIMAL (10,2))*CAST(REPLACE(productos_kit.Cantidad,',','.') AS DECIMAL(10,2)),2) As Costo 
FROM productos_kit 
LEFT JOIN PRODUCTOS ON productos_kit.CODPROD=PRODUCTOS.COD 
WHERE codKIT = " & CInt(TextBox_codprod.Text) & " ORDER BY CONS"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.Grid_kit.DataSource = dt
            Me.Grid_kit.Columns(0).Visible = False
            Me.Grid_kit.Columns(1).Visible = False
            Me.Grid_kit.Columns(2).HeaderText = "Código"
            Me.Grid_kit.Columns(2).Width = 80
            Me.Grid_kit.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.Grid_kit.Columns(3).HeaderText = "Productos"
            Me.Grid_kit.Columns(3).Width = 350
            Me.Grid_kit.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.Grid_kit.Columns(4).HeaderText = "Cant"
            Me.Grid_kit.Columns(4).Width = 90
            Me.Grid_kit.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.Grid_kit.Columns(5).HeaderText = "Costo"
            Me.Grid_kit.Columns(5).Width = 100
            Me.Grid_kit.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()



        Me.TextBox_total_costo_kit.Text = 0
        Try
            For i As Integer = 0 To Grid_kit.RowCount - 1
                Dim costototal As String = ""
                costototal = Grid_kit.Item("costo", i).Value.ToString.Replace(",", "")
                costototal = costototal.Replace(".", ",")

                Me.TextBox_total_costo_kit.Text = CInt(Me.TextBox_total_costo_kit.Text) + CInt(costototal)
            Next
            Me.TextBox_total_costo_kit.Text = CInt(Me.TextBox_total_costo_kit.Text)

            Me.NUMERIC_costo.Value = Me.TextBox_total_costo_kit.Text ' paso el costo d eproduccion al costo del producto

        Catch ex As Exception
            'MsgBox(ex.Message.ToString)
        End Try

        Grid_kit.ClearSelection()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub grid_prods_info()
        Me.Cursor = Cursors.WaitCursor

        If RadioButton_VerVentas.Checked = True Then
            Try
                sql = "SELECT vp.Cons, v.fecha, vp.Documento, v.DocCliente, v.ClienteNom, vp.CodProd, vp.Producto, vp.Cantidad, vp.Base, vp.Imp, vp.imp2, vp.Impuesto, vp.impuesto2, vp.ValorU, vp.ValorTotal, vp.Estado, vp.Inventariado, vp.ImpNom1, vp.ImpNom2, vp.deci, vp.costo, vp.idbodega, vp.Lote, vp.vence, vp.cta_vender, vp.cta_inventariar, vp.cta_costear, vp.cta_devolver 
FROM ventas_prods vp
inner join ventas v on vp.documento=v.documento
where codprod= " & CInt(TextBox_codprod.Text) & " ORDER BY documento;"
                If CheckBox_FiltroPeriodoConsultas.Checked = True Then sql = "SELECT vp.Cons, v.fecha, vp.Documento, v.DocCliente, v.ClienteNom, vp.CodProd, vp.Producto, vp.Cantidad, vp.Base, vp.Imp, vp.imp2, vp.Impuesto, vp.impuesto2, vp.ValorU, vp.ValorTotal, vp.Estado, vp.Inventariado, vp.ImpNom1, vp.ImpNom2, vp.deci, vp.costo, vp.idbodega, vp.Lote, vp.vence, vp.cta_vender, vp.cta_inventariar, vp.cta_costear, vp.cta_devolver 
FROM ventas_prods vp
inner join ventas v on vp.documento=v.documento
where codprod= " & CInt(TextBox_codprod.Text) & " and month(STR_TO_DATE(v.fecha,'%d/%m/%Y'))='" & ComboBox_PeriodoConsulta.SelectedIndex.ToString & "' AND YEAR(STR_TO_DATE(v.fecha,'%d/%m/%Y'))='" & NumericUpDown_anoconsulta.Value & "' ORDER BY documento;"
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                da.Fill(dt)
                Me.Grid_InfoProd.DataSource = dt
                Me.Grid_InfoProd.Columns(0).Visible = False

                Me.Grid_InfoProd.Columns(1).HeaderText = "Fecha"
                Me.Grid_InfoProd.Columns(1).Width = 50
                Me.Grid_InfoProd.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                Me.Grid_InfoProd.Columns(2).HeaderText = "No. Fact"
                Me.Grid_InfoProd.Columns(3).Width = 50
                Me.Grid_InfoProd.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft


                Me.Grid_InfoProd.Columns(3).HeaderText = "DocCliente"
                Me.Grid_InfoProd.Columns(3).Width = 70
                Me.Grid_InfoProd.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                Me.Grid_InfoProd.Columns(4).HeaderText = "Cliente"
                Me.Grid_InfoProd.Columns(4).Width = 200
                Me.Grid_InfoProd.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                Me.Grid_InfoProd.Columns(5).HeaderText = "Cod Producto"
                Me.Grid_InfoProd.Columns(5).Width = 50
                Me.Grid_InfoProd.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                Me.Grid_InfoProd.Columns(6).HeaderText = "Producto"
                Me.Grid_InfoProd.Columns(6).Width = 200
                Me.Grid_InfoProd.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                Me.Grid_InfoProd.Columns(7).HeaderText = "Cantidad"
                Me.Grid_InfoProd.Columns(7).Width = 80
                Me.Grid_InfoProd.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                Me.Grid_InfoProd.Columns(8).Visible = False
                Me.Grid_InfoProd.Columns(9).Visible = False
                Me.Grid_InfoProd.Columns(10).Visible = False
                Me.Grid_InfoProd.Columns(11).Visible = False
                Me.Grid_InfoProd.Columns(12).Visible = False

                Me.Grid_InfoProd.Columns(13).HeaderText = "Vr Unitario"
                Me.Grid_InfoProd.Columns(13).Width = 80
                Me.Grid_InfoProd.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Me.Grid_InfoProd.Columns(14).HeaderText = "Vr Total"
                Me.Grid_InfoProd.Columns(14).Width = 80
                Me.Grid_InfoProd.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                Me.Grid_InfoProd.Columns(15).Visible = False
                Me.Grid_InfoProd.Columns(16).Visible = False
                Me.Grid_InfoProd.Columns(17).Visible = False
                Me.Grid_InfoProd.Columns(18).Visible = False
                Me.Grid_InfoProd.Columns(19).Visible = False
                Me.Grid_InfoProd.Columns(20).Visible = False
                Me.Grid_InfoProd.Columns(21).Visible = False
                Me.Grid_InfoProd.Columns(22).Visible = False
                Me.Grid_InfoProd.Columns(23).Visible = False
                Me.Grid_InfoProd.Columns(24).Visible = False
                Me.Grid_InfoProd.Columns(25).Visible = False
                Me.Grid_InfoProd.Columns(26).Visible = False
                Me.Grid_InfoProd.Columns(27).Visible = False
                'Me.Grid_InfoProd.Columns(28).Visible = False


            Catch ex As Exception
                'MsgBox(ex.Message)
            End Try
            conex.Close()
            da.Dispose()
            dt.Dispose()


            'Me.TextBox_total_costo_kit.Text = 0
            'Try
            '    For i As Integer = 0 To Grid_InfoProd.RowCount - 1
            '        Dim costototal As String = ""
            '        costototal = Grid_kit.Item("costo", i).Value.ToString.Replace(",", "")
            '        costototal = costototal.Replace(".", ",")

            '        Me.TextBox_total_costo_kit.Text = CInt(Me.TextBox_total_costo_kit.Text) + CInt(costototal)
            '    Next
            '    Me.TextBox_total_costo_kit.Text = CInt(Me.TextBox_total_costo_kit.Text)

            '    'Me.NUMERIC_costo.Value = Me.TextBox_total_costo_kit.Text ' paso el costo d eproduccion al costo del producto

            'Catch ex As Exception
            '    'MsgBox(ex.Message.ToString)
            'End Try


        End If

        If RadioButton_vercompras.Checked = True Then

            Try
                sql = "SELECT pedidosprov.CONS as NumPedido, pedidosprov.nrofac as NumFactura, pedidosprov.fecha as fecha, pedidosprov.codcliente as DocProveedor, pedidosprov.cliente as Proveedor, pedidosprov_prods.CODPROD as CodProd, pedidosprov_prods.producto as Producto, 
pedidosprov_prods.cantidad as Cant, pedidosprov_prods.valoru as VrUnitario, pedidosprov_prods.valortotal as VrTotal FROM miclickdb.pedidosprov_prods 
inner join pedidosprov on pedidosprov_prods.documento=pedidosprov.cons 
where codprod= " & CInt(TextBox_codprod.Text) & " and pedidosprov.estado='FINALIZADO';"
                If CheckBox_FiltroPeriodoConsultas.Checked = True Then sql = "SELECT pedidosprov.CONS as NumPedido, pedidosprov.fecha as fecha, pedidosprov.cliente as Proveedor, pedidosprov_prods.CODPROD as CodProd, pedidosprov_prods.producto as Producto, 
pedidosprov_prods.cantidad as Cant, pedidosprov_prods.valoru as VrUnitario, pedidosprov_prods.valortotal as VrTotal FROM miclickdb.pedidosprov_prods 
inner join pedidosprov on pedidosprov_prods.documento=pedidosprov.cons 
where codprod= " & CInt(TextBox_codprod.Text) & " and pedidosprov.estado='FINALIZADO' and month(STR_TO_DATE(pedidosprov.fecha,'%d/%m/%Y'))='" & ComboBox_PeriodoConsulta.SelectedIndex.ToString & "' AND YEAR(STR_TO_DATE(pedidosprov.fecha,'%d/%m/%Y'))='" & NumericUpDown_anoconsulta.Value & "';"
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                da.Fill(dt)
                Me.Grid_InfoProd.DataSource = dt
                Me.Grid_InfoProd.Columns(0).HeaderText = "No. Pedido"
                Me.Grid_InfoProd.Columns(0).Width = 50
                Me.Grid_InfoProd.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                Me.Grid_InfoProd.Columns(1).HeaderText = "No. Factura"
                Me.Grid_InfoProd.Columns(1).Width = 50
                Me.Grid_InfoProd.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                Me.Grid_InfoProd.Columns(2).HeaderText = "Fecha"
                Me.Grid_InfoProd.Columns(2).Width = 50
                Me.Grid_InfoProd.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                Me.Grid_InfoProd.Columns(3).HeaderText = "DocProveedor"
                Me.Grid_InfoProd.Columns(3).Width = 50
                Me.Grid_InfoProd.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                Me.Grid_InfoProd.Columns(4).HeaderText = "Proveedor"
                Me.Grid_InfoProd.Columns(4).Width = 100
                Me.Grid_InfoProd.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                Me.Grid_InfoProd.Columns(5).HeaderText = "Cod Producto"
                Me.Grid_InfoProd.Columns(5).Width = 70
                Me.Grid_InfoProd.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                Me.Grid_InfoProd.Columns(6).HeaderText = "Producto"
                Me.Grid_InfoProd.Columns(6).Width = 280
                Me.Grid_InfoProd.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                Me.Grid_InfoProd.Columns(7).HeaderText = "Cantidad"
                Me.Grid_InfoProd.Columns(7).Width = 80
                Me.Grid_InfoProd.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


                Me.Grid_InfoProd.Columns(8).HeaderText = "Vr Unitario"
                Me.Grid_InfoProd.Columns(8).Width = 80
                Me.Grid_InfoProd.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Me.Grid_InfoProd.Columns(9).HeaderText = "Vr Total"
                Me.Grid_InfoProd.Columns(9).Width = 80
                Me.Grid_InfoProd.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da.Dispose()
            dt.Dispose()


            'Me.TextBox_total_costo_kit.Text = 0
            'Try
            '    For i As Integer = 0 To Grid_InfoProd.RowCount - 1
            '        Dim costototal As String = ""
            '        costototal = Grid_kit.Item("costo", i).Value.ToString.Replace(",", "")
            '        costototal = costototal.Replace(".", ",")

            '        Me.TextBox_total_costo_kit.Text = CInt(Me.TextBox_total_costo_kit.Text) + CInt(costototal)
            '    Next
            '    Me.TextBox_total_costo_kit.Text = CInt(Me.TextBox_total_costo_kit.Text)

            '    'Me.NUMERIC_costo.Value = Me.TextBox_total_costo_kit.Text ' paso el costo d eproduccion al costo del producto

            'Catch ex As Exception
            '    'MsgBox(ex.Message.ToString)
            'End Try


        End If

        If RadioButton_VerMovs.Checked = True Then
            Try
                sql = "SELECT b.Fecha, b.TipoDocumento, b.Documento, b.CODPRODUCTO, concat(p.NOMBRE,' ',p.ref,' ',p.presentacion) as Producto, b.ENTRAN, b.SALEN, b.VALORU, b.VALORTOTAL FROM bodega_" & CStr(Me.ComboBox_bods.Text) & " b inner join productos p on b.codproducto=p.cod where b.codproducto=" & Me.TextBox_codprod.Text & ""

                If CheckBox_FiltroPeriodoConsultas.Checked = True Then sql = "SELECT b.Fecha, b.TipoDocumento, b.Documento, b.CODPRODUCTO, concat(p.NOMBRE,' ',p.ref,' ',p.presentacion) as Producto, b.ENTRAN, b.SALEN, b.VALORU, b.VALORTOTAL FROM bodega_" & CStr(Me.ComboBox_bods.Text) & " b inner join productos p on b.codproducto=p.cod where b.codproducto=" & Me.TextBox_codprod.Text & " AND month(STR_TO_DATE(b.fecha,'%d/%m/%Y'))=" & ComboBox_PeriodoConsulta.SelectedIndex.ToString & " and YEAR(STR_TO_DATE(b.fecha,'%d/%m/%Y'))='" & NumericUpDown_anoconsulta.Value & "'"
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                da.Fill(dt)
                Me.Grid_InfoProd.DataSource = dt

                Me.Grid_InfoProd.Columns(0).HeaderText = "Fecha"
                Me.Grid_InfoProd.Columns(0).Width = 50
                Me.Grid_InfoProd.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                Me.Grid_InfoProd.Columns(1).HeaderText = "Tipo Doc"
                Me.Grid_InfoProd.Columns(1).Width = 70
                Me.Grid_InfoProd.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                Me.Grid_InfoProd.Columns(2).HeaderText = "Documento"
                Me.Grid_InfoProd.Columns(2).Width = 70
                Me.Grid_InfoProd.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                Me.Grid_InfoProd.Columns(3).HeaderText = "Cod Producto"
                Me.Grid_InfoProd.Columns(3).Width = 80
                Me.Grid_InfoProd.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                Me.Grid_InfoProd.Columns(4).HeaderText = "Producto"
                Me.Grid_InfoProd.Columns(4).Width = 200
                Me.Grid_InfoProd.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                Me.Grid_InfoProd.Columns(5).HeaderText = "Entradas"
                Me.Grid_InfoProd.Columns(5).Width = 80
                Me.Grid_InfoProd.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Me.Grid_InfoProd.Columns(6).HeaderText = "Salidas"
                Me.Grid_InfoProd.Columns(6).Width = 80
                Me.Grid_InfoProd.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Me.Grid_InfoProd.Columns(7).HeaderText = "Vr Unitario"
                Me.Grid_InfoProd.Columns(7).Width = 80
                Me.Grid_InfoProd.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Me.Grid_InfoProd.Columns(8).HeaderText = "Vr Total"
                Me.Grid_InfoProd.Columns(8).Width = 80
                Me.Grid_InfoProd.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da.Dispose()
            dt.Dispose()


            'Me.TextBox_total_costo_kit.Text = 0
            'Try
            '    For i As Integer = 0 To Grid_InfoProd.RowCount - 1
            '        Dim costototal As String = ""
            '        costototal = Grid_kit.Item("costo", i).Value.ToString.Replace(",", "")
            '        costototal = costototal.Replace(".", ",")

            '        Me.TextBox_total_costo_kit.Text = CInt(Me.TextBox_total_costo_kit.Text) + CInt(costototal)
            '    Next
            '    Me.TextBox_total_costo_kit.Text = CInt(Me.TextBox_total_costo_kit.Text)

            '    'Me.NUMERIC_costo.Value = Me.TextBox_total_costo_kit.Text ' paso el costo d eproduccion al costo del producto

            'Catch ex As Exception
            '    'MsgBox(ex.Message.ToString)
            'End Try


        End If
        Grid_InfoProd.ClearSelection()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""

    End Sub

    Private Sub Label_utilidad_Click(sender As Object, e As EventArgs) Handles Label_utilidad.Click
        If puede_cacular_utilidad = False Then Exit Sub

        Dim VR1, VR2 As Integer
        Dim incremento As Decimal

        If CInt(TextBox_valor1.Value) = "0" Or CInt(NUMERIC_costo.Value) = "0" Then
            Exit Sub
        End If

        VR1 = CInt(TextBox_valor1.Value)
        VR2 = CInt(NUMERIC_costo.Value)

        incremento = (VR1 - VR2)
        incremento = (VR1 - VR2) / VR2
        incremento = incremento * 100

        Me.Label_utilidad.Text = "Utilidad:  "

        Me.NumericUpDown1.Value = incremento
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        PictureBox1_Click(Nothing, Nothing)

    End Sub

    Private Sub ComboBox_INVENTARIO_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_INVENTARIO.SelectionChangeCommitted

        Timer_impuesto.Enabled = True
        If Me.ComboBox_INVENTARIO.Text = "SI" Then Me.TextBox_stock.Enabled = True : Me.TextBox_stock.Text = "0" : Me.TextBox_stock_maximo.Enabled = True : Me.TextBox_stock_maximo.Text = "0"
        If Me.ComboBox_INVENTARIO.Text = "NO" Then Me.TextBox_stock.Enabled = False : Me.TextBox_stock.Text = "0" : Me.TextBox_stock_maximo.Enabled = False : Me.TextBox_stock_maximo.Text = "0"

    End Sub

    Private Sub Label_utilidad2_Click(sender As Object, e As EventArgs) Handles Label_utilidad2.Click
        If puede_cacular_utilidad = False Then Exit Sub


        Dim VR1, VR2 As Integer
        Dim incremento As Decimal

        If TextBox_valor2.Value = "0" Or NUMERIC_costo.Value = "0" Then
            Exit Sub
        End If

        VR1 = CInt(TextBox_valor2.Value)
        VR2 = CInt(NUMERIC_costo.Value)
        incremento = (VR1 - VR2)
        incremento = incremento / VR2
        incremento = incremento * 100

        Me.Label_utilidad2.Text = "Utilidad:  "
        Me.NumericUpDown2.Value = incremento

    End Sub

    Private Sub Label_utilidad3_Click(sender As Object, e As EventArgs) Handles Label_utilidad3.Click

        If puede_cacular_utilidad = False Then Exit Sub



        Dim VR1, VR2 As Integer
        Dim incremento As Decimal

        If TextBox_valor3.Value = "0" Or NUMERIC_costo.Value = "0" Then
            Exit Sub
        End If

        VR1 = CInt(TextBox_valor3.Value)
        VR2 = CInt(NUMERIC_costo.Value)
        incremento = (VR1 - VR2)
        incremento = incremento / VR2
        incremento = incremento * 100

        Me.Label_utilidad3.Text = "Utilidad:  "
        Me.NumericUpDown3.Value = incremento


    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs)

    End Sub
    Private Sub TextBox_precio_TextChanged(sender As Object, e As EventArgs)
        If Me.TextBox_valor1.Text = "" Then Me.TextBox_valor1.Text = "0"


        Me.TextBox_valor1.Text = FormatNumber(Me.TextBox_valor1.Text, 0)
        Me.TextBox_valor1.Select(Me.TextBox_valor1.Text.Length, 0)

        Label_utilidad_Click(Nothing, Nothing)

    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_codprod.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""

    End Sub

    Private Sub Combobox_impuestos_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Combobox_impuestos.SelectionChangeCommitted
        Timer_impuesto.Enabled = True

    End Sub

    Private Sub ComboBox_impuestos2_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_impuestos2.SelectionChangeCommitted
        Timer_Impuesto2.Enabled = True


    End Sub

    Private Sub Timer_impuesto_Tick(sender As Object, e As EventArgs) Handles Timer_impuesto.Tick
        Timer_impuesto.Enabled = False

        If Me.ComboBox_impespejo1.Text = "VALOR" Then
            Me.TextBox_espejo1.Visible = True
            Me.TextBox_espejo1.Enabled = True
            Me.TextBox_espejo1.Text = Me.ComboBox_impespejo1.SelectedValue.ToString

        End If
        If Me.ComboBox_impespejo1.Text = "PORCENTAJE" Then
            Me.TextBox_espejo1.Visible = True
            Me.TextBox_espejo1.Enabled = False
            Me.TextBox_espejo1.Text = Me.ComboBox_impespejo1.SelectedValue.ToString

        End If

    End Sub

    Private Sub ComboBox_impuestos2_SizeChanged(sender As Object, e As EventArgs) Handles ComboBox_impuestos2.SizeChanged

    End Sub

    Private Sub Timer_Impuesto2_Tick(sender As Object, e As EventArgs) Handles Timer_Impuesto2.Tick
        Me.Timer_Impuesto2.Enabled = False
        If Me.ComboBox_impespejo2.Text = "VALOR" Then
            Me.TextBox_espejo2.Visible = True
            Me.TextBox_espejo2.Enabled = True
            Me.TextBox_espejo2.Text = Me.ComboBox_impespejo2.SelectedValue.ToString

        End If
        If Me.ComboBox_impespejo2.Text = "PORCENTAJE" Then
            Me.TextBox_espejo2.Visible = True
            Me.TextBox_espejo2.Enabled = False
            Me.TextBox_espejo2.Text = Me.ComboBox_impespejo2.SelectedValue.ToString

        End If
    End Sub


    Private Sub Button_pdf_Click(sender As Object, e As EventArgs)


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



    Function GridAExcel(ByVal ElGrid As DataGridView) As Boolean
        'Creamos las variables
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
        exApp.Application.Visible = False

        exLibro = exApp.Workbooks.Open(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Reporte de productos.xls")
        exHoja = exApp.ActiveWorkbook.Sheets(1)
        Try
            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = ElGrid.ColumnCount
            Dim NRow As Integer = ElGrid.RowCount

            'encabezados
            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).Font.colorindex = 2
            exHoja.Rows.Item(2).Font.Bold = 1
            exHoja.Rows.Item(2).Font.colorindex = 2
            exHoja.Rows.Item(3).Font.Bold = 1
            exHoja.Rows.Item(3).Font.colorindex = 2
            exHoja.Rows.Item(4).Font.Bold = 1
            exHoja.Rows.Item(4).Font.colorindex = 2
            exHoja.Rows.Item(5).Font.Bold = 1
            exHoja.Rows.Item(5).interior.colorindex = 23
            exHoja.Rows.Item(5).Font.colorindex = 2
            exHoja.Rows.Item(5).HorizontalAlignment = 3

            exHoja.Cells.Item(1, 1).interior.colorindex = 23
            exHoja.Cells.Item(2, 1).interior.colorindex = 23
            exHoja.Cells.Item(3, 1).interior.colorindex = 23
            exHoja.Cells.Item(4, 1).interior.colorindex = 23

            exHoja.Cells.Item(1, 2) = "          " : exHoja.Cells.Item(1, 2).interior.colorindex = 23
            exHoja.Cells.Item(1, 2) = comex_nombrecomercial : exHoja.Cells.Item(1, 2).interior.colorindex = 23
            exHoja.Cells.Item(2, 2) = "Reporte de Productos" : exHoja.Cells.Item(2, 2).interior.colorindex = 23
            exHoja.Cells.Item(3, 2) = usrnom.ToString : exHoja.Cells.Item(3, 2).interior.colorindex = 23
            exHoja.Cells.Item(4, 2) = DateTime.Now.ToString : exHoja.Cells.Item(4, 2).interior.colorindex = 23

            exHoja.Columns.AutoFit()
            '----

            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.}}
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(5, i) = ElGrid.Columns(i - 1).Name.ToString
                exHoja.Cells.Item(5, i).HorizontalAlignment = 2
            Next
            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 6, Col + 1) = ElGrid.Rows(Fila).Cells(Col).Value
                    exHoja.Cells.Item(Fila + 6, Col + 1).HorizontalAlignment = 2
                Next
            Next
            exApp.Application.Visible = True

            exApp.Workbooks.Close()
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



    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        TextBox_valor1.Text = NUMERIC_costo.Value + (CInt(NUMERIC_costo.Value) * (NumericUpDown1.Value) / 100)
    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        TextBox_valor2.Text = NUMERIC_costo.Value + (CInt(NUMERIC_costo.Value) * (NumericUpDown2.Value) / 100)

    End Sub

    Private Sub NumericUpDown3_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown3.ValueChanged
        TextBox_valor3.Text = NUMERIC_costo.Value + (CInt(NUMERIC_costo.Value) * (NumericUpDown3.Value) / 100)

    End Sub

    Private Sub NumericUpDown1_TextChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.TextChanged
        NumericUpDown1_ValueChanged(Nothing, Nothing)
    End Sub

    Private Sub NumericUpDown2_TextChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.TextChanged
        NumericUpDown2_ValueChanged(Nothing, Nothing)

    End Sub

    Private Sub NumericUpDown3_TextChanged(sender As Object, e As EventArgs) Handles NumericUpDown3.TextChanged
        NumericUpDown3_ValueChanged(Nothing, Nothing)

    End Sub

    Private Sub Button_cerrar_panel_opciones_Click(sender As Object, e As EventArgs) Handles Button_cerrar_panel_opciones.Click

        imagepath = ""

        Me.PictureBox_image.Image = Nothing
        Application.DoEvents()
        If PictureBox_image.ImageLocation <> Nothing Then
            Kill(PictureBox_image.ImageLocation)
        End If
    End Sub

    Private Sub TextBox_precio_KeyDown(sender As Object, e As KeyEventArgs)

    End Sub

    Private Sub Form_productos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown


        If (e.KeyCode = Keys.Escape) And que_hace = "GUARDAR" Then
            Button_cancelar_Click(Nothing, Nothing)
            Exit Sub
        End If

        If (e.KeyCode = Keys.Escape) And que_hace = "MODIFICAR" Then
            Button_cancelar_Click(Nothing, Nothing)
            Exit Sub
        End If

        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If


        'If (e.KeyCode = Keys.Left) Then
        '    SendKeys.Send("{TAB}")
        '    MetroTabControl1.SelectTab(0)
        '    Exit Sub
        'End If
        'If (e.KeyCode = Keys.Right) Then
        '    SendKeys.Send("{TAB}")
        '    MetroTabControl1.SelectTab(1)
        '    Exit Sub
        'End If
    End Sub



    Private Sub TextBox_nombrebuscar_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub RadioButton_nombre_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_nombre.CheckedChanged
        TextBox_nombrebuscar.Text = ""
        If comex_fondo = "NEGRO" Then TextBox_nombrebuscar.ForeColor = Color.White
        If comex_fondo = "AZUL" Then TextBox_nombrebuscar.ForeColor = Color.Black

    End Sub

    Private Sub RadioButton_codigo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_codigo.CheckedChanged
        TextBox_nombrebuscar.Text = ""
        If comex_fondo = "NEGRO" Then TextBox_nombrebuscar.ForeColor = Color.White
        If comex_fondo = "AZUL" Then TextBox_nombrebuscar.ForeColor = Color.Black
    End Sub

    Private Sub RadioButton_barras_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_barras.CheckedChanged
        TextBox_nombrebuscar.Text = ""
        If comex_fondo = "NEGRO" Then TextBox_nombrebuscar.ForeColor = Color.White
        If comex_fondo = "AZUL" Then TextBox_nombrebuscar.ForeColor = Color.Black
    End Sub

    Private Sub datagridProdsList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub TextBox_barras_TextChanged(sender As Object, e As EventArgs) Handles TextBox_barras.TextChanged

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs)

    End Sub


    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox_ult_compra.TextChanged

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox_prom_compra.TextChanged

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
    Private Sub Button_pdf_Click_1(sender As Object, e As EventArgs) Handles Button_exportar.Click
        datagridProdsList.Enabled = False

        Panel_buttons.Enabled = False
        Panel_busqueda.Enabled = False

        BunifuCards_exportar.Height = 319
        BunifuCards_exportar.Visible = True
        BunifuCards_exportar.BringToFront()
        Centrar(BunifuCards_exportar)




    End Sub

    Public Sub ExportarDatosPDF(ByVal document As Document)
        'Se crea un objeto PDFTable con el numero de columnas del DataGridView.
        Dim datatable As New PdfPTable(8)
        'Se asignan algunas propiedades para el diseño del PDF.
        datatable.DefaultCell.Padding = 3

        datatable.SetWidths({20, 160, 40, 40, 40, 40, 20, 40})
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

        Dim encabezado2 As New Paragraph("<<< LISTADO DE PRODUCTOS >>>", FontFactory.GetFont(FontFactory.COURIER, 11, iTextSharp.text.Font.BOLD))
        encabezado2.Alignment = Element.ALIGN_CENTER

        'Se crea el texto abajo del encabezado.

        Dim texto2 As New Phrase("Fecha del Reporte: " + Now.Date(), FontFactory.GetFont(FontFactory.COURIER, 9D, iTextSharp.text.Font.BOLD))
        Dim texto3 As New Phrase("            Generado Por :" + usrnom, FontFactory.GetFont(FontFactory.COURIER, 9D, iTextSharp.text.Font.BOLD))



        ' AGRUPACION
        Try
            sql = "SELECT DISTINCT(tipo) FROM PRODUCTOS WHERE " & filtro_TIPO.Replace("AND", "") & filtro_estado & " order by tipo, CATEGORIA"
            da_AGRUPACION = New MySqlDataAdapter(sql, conex)
            dt_AGRUPACION = New DataTable
            da_AGRUPACION.Fill(dt_AGRUPACION)
            For Each row3 As DataRow In dt_AGRUPACION.Rows
                'CStr(row3.Item("CATEGORIA"))


                Try
                    sql = "SELECT Cod, Nombre, Categoria, costo, impnom2 as Impuesto, replace(format(Valor,0),',','.') as Valor, Stock, Estado FROM productos where tipo='" & CStr(row3.Item("tipo")) & "' " & filtro_estado & " order by categoria, nombre"

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
                cell_CAT.Phrase = New Phrase(Chr(13) & "( " + CStr(row3.Item("tipo")) + " )", FontFactory.GetFont(FontFactory.COURIER_BOLD, 12D, iTextSharp.text.Font.BOLD))
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
        da_AGRUPACION.Dispose()
        dt_AGRUPACION.Dispose()
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

    Public Sub ExportarDatosKIT(ByVal document As Document)
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

        Dim encabezado2 As New Paragraph("<<< PRODUCTOS CON KIT >>>", FontFactory.GetFont(FontFactory.COURIER, 11, iTextSharp.text.Font.BOLD))
        encabezado2.Alignment = Element.ALIGN_CENTER

        'Se crea el texto abajo del encabezado.

        Dim texto2 As New Phrase("Fecha del Reporte: " + Now.Date(), FontFactory.GetFont(FontFactory.COURIER, 9D, iTextSharp.text.Font.BOLD))
        Dim texto3 As New Phrase("            Generado Por :" + usrnom, FontFactory.GetFont(FontFactory.COURIER, 9D, iTextSharp.text.Font.BOLD))



        ' AGRUPACION
        Try
            sql = "SELECT cod, nombre FROM productos WHERE kit='SI'"
            da_AGRUPACION = New MySqlDataAdapter(sql, conex)
            dt_AGRUPACION = New DataTable
            da_AGRUPACION.Fill(dt_AGRUPACION)
            For Each row3 As DataRow In dt_AGRUPACION.Rows
                'CStr(row3.Item("CATEGORIA"))


                Try
                    sql = "SELECT CodPROD, PRODUCTO, CANTIDAD FROM productos_KIT where CODKIT='" & CStr(row3.Item("COD")) & "' order by PRODUCTO"

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
                cell_CAT.Phrase = New Phrase(Chr(13) & "( " + CStr(row3.Item("COD")) + " | " + CStr(row3.Item("NOMBRE")) + " )", FontFactory.GetFont(FontFactory.COURIER_BOLD, 12D, iTextSharp.text.Font.BOLD))
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
        da_AGRUPACION.Dispose()
        dt_AGRUPACION.Dispose()
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
    Private Sub Button_cerrar_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub MetroComboBox_TIPOPROD_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer_UTILIDAD_Tick(sender As Object, e As EventArgs) Handles Timer_UTILIDAD.Tick

        Timer_UTILIDAD.Enabled = False


        Label_utilidad_Click(Nothing, Nothing)
        Label_utilidad2_Click(Nothing, Nothing)
        Label_utilidad3_Click(Nothing, Nothing)

    End Sub

    Private Sub Background_GRID_DoWork(sender As Object, e As DoWorkEventArgs) Handles Background_GRID.DoWork


        Try

            Cursor.Current = Cursors.WaitCursor

            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            cant_prods = dt.Rows.Count
        Catch ex As Exception
            Background_GRID.CancelAsync()
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        Cursor.Current = Cursors.Default

        If Background_GRID.CancellationPending Then Exit Sub

    End Sub

    Private Sub TextBox_barras_VisibleChanged(sender As Object, e As EventArgs) Handles TextBox_barras.VisibleChanged

    End Sub

    Private Sub Label51_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox_categoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_categoria.SelectedIndexChanged

    End Sub

    Private Sub Background_GRID_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles Background_GRID.RunWorkerCompleted

        Label_info_cant_prods.Text = cant_prods & " Productos Registrados"

        Me.datagridProdsList.DataSource = dt
        Me.datagridProdsList.Columns(0).HeaderText = "Código"
        Me.datagridProdsList.Columns(0).Width = 60
        Me.datagridProdsList.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.datagridProdsList.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.datagridProdsList.Columns(1).HeaderText = "Cód Barras"
        Me.datagridProdsList.Columns(1).Width = 80
        Me.datagridProdsList.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.datagridProdsList.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.datagridProdsList.Columns(2).HeaderText = "Tipo"
        Me.datagridProdsList.Columns(2).Width = 60
        Me.datagridProdsList.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.datagridProdsList.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.datagridProdsList.Columns(3).HeaderText = "Categoría"
        Me.datagridProdsList.Columns(3).Width = 80
        Me.datagridProdsList.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.datagridProdsList.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.datagridProdsList.Columns(4).HeaderText = "Producto"
        Me.datagridProdsList.Columns(4).Width = 300
        Me.datagridProdsList.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.datagridProdsList.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.datagridProdsList.Columns(4).DefaultCellStyle.WrapMode = DataGridViewTriState.True

        Me.datagridProdsList.Columns(5).Visible = False
        Me.datagridProdsList.Columns(6).Visible = False
        Me.datagridProdsList.Columns(7).Visible = False
        Me.datagridProdsList.Columns(8).Visible = False
        Me.datagridProdsList.Columns(9).Visible = False
        Me.datagridProdsList.Columns(10).Visible = False
        Me.datagridProdsList.Columns(11).Visible = False
        Me.datagridProdsList.Columns(12).Visible = False
        Me.datagridProdsList.Columns(13).Visible = False
        Me.datagridProdsList.Columns(14).Visible = False
        Me.datagridProdsList.Columns(15).Visible = False

        Me.datagridProdsList.Columns(16).Visible = False


        Me.datagridProdsList.Columns(17).Visible = False
        Me.datagridProdsList.Columns(18).Visible = False
        Me.datagridProdsList.Columns(19).Visible = False
        Me.datagridProdsList.Columns(20).Visible = False
        Me.datagridProdsList.Columns(21).Visible = False
        Me.datagridProdsList.Columns(22).Visible = False
        Me.datagridProdsList.Columns(23).Visible = False
        Me.datagridProdsList.Columns(24).Visible = False
        Me.datagridProdsList.Columns(25).Visible = False
        Me.datagridProdsList.Columns(26).Visible = False
        Me.datagridProdsList.Columns(27).Visible = False
        Me.datagridProdsList.Columns(28).Visible = False
        Me.datagridProdsList.Columns(29).Visible = False
        Me.datagridProdsList.Columns(30).Visible = False
        Me.datagridProdsList.Columns(31).Visible = False
        Me.datagridProdsList.Columns(32).Visible = False
        Me.datagridProdsList.Columns(33).Visible = False
        Me.datagridProdsList.Columns(34).Visible = False
        Me.datagridProdsList.Columns(35).Visible = False
        Me.datagridProdsList.Columns(36).Visible = False
        Me.datagridProdsList.Columns(37).Visible = False
        Me.datagridProdsList.Columns(38).Visible = False
        Me.datagridProdsList.Columns(39).Visible = False
        Me.datagridProdsList.Columns(40).Visible = False
        Me.datagridProdsList.Columns(41).Visible = False
        Me.datagridProdsList.Columns(42).Visible = False
        Me.datagridProdsList.Columns(43).Visible = False
        Me.datagridProdsList.Columns(44).Visible = False
        Me.datagridProdsList.Columns(45).Visible = False

        'Me.datagridProdsList.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue
        'Me.datagridProdsList.DefaultCellStyle.BackColor = Color.AliceBlue
        'Me.datagridProdsList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        ''Me.datagridProdsList.BackgroundColor = Color.AliceBlue
        'If comex_fondo = "NEGRO" Then Me.datagridProdsList.DefaultCellStyle.BackColor = Color.FromArgb(28, 28, 28)
        'If comex_fondo = "NEGRO" Then Me.datagridProdsList.BackgroundColor = Color.FromArgb(28, 28, 28)
        'For Each fila As DataGridViewRow In datagridProdsList.Rows
        '    If CStr(fila.Cells("estado").Value.ToString) = "INACTIVO" Then
        '        fila.DefaultCellStyle.ForeColor = Color.Black
        '        fila.DefaultCellStyle.BackColor = Color.LightGray
        '    End If

        'Next
        Me.datagridProdsList.CurrentCell = Nothing


        Button_buscar.Visible = True
        Picture_LOAD.Visible = False
        datagridProdsList.Refresh()

        Cursor.Current = Cursors.Default

    End Sub

    Private Sub Timer_TIPO_CATEGORIA_Tick(sender As Object, e As EventArgs) Handles Timer_TIPO_CATEGORIA.Tick

        Timer_TIPO_CATEGORIA.Enabled = False

        Try
            sql = "SELECT TIPO, CATEGORIA FROM productos_categorias WHERE CONS=" & ComboBox_categoria.SelectedValue & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                CATEGORIA_GUARDAR = CStr(row.Item("CATEGORIA"))

                TIPOCATEGORIA_GUARDAR = CStr(row.Item("TIPO"))
            Next
        Catch ex As Exception
        End Try

        da.Dispose()
        dt.Dispose()
        conex.Close()
    End Sub

    Private Sub Checkbox_kit_OnChange(sender As Object, e As EventArgs) Handles Checkbox_kit.OnChange
        If Checkbox_kit.Checked = True Then
            Panel_KIT.Visible = True

            If RadioButton_prod_kit.Checked = True Then
                loads_productos("PRODUCTOS")
            End If

            If RadioButton_materiaPrima_kit.Checked = True Then
                loads_productos("INSUMOS")
            End If
            If RadioButton_prod_proc_kit.Checked = True Then
                loads_productos("PROCESADOS")
            End If

            Label_kit_title.Text = "Kit del Producto (" & Textbox_Nombre.Text & ")"
        Else
            Panel_KIT.Visible = False
            Me.ComboBox_prods_kit.DataSource = Nothing
            Label_kit_title.Text = "Kit del Producto"
            Panel_KIT.Visible = False

        End If
    End Sub

    Private Sub ComboBox_categoria_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_categoria.SelectionChangeCommitted
        Timer_TIPO_CATEGORIA.Enabled = True


    End Sub

    Private Sub RadioButton_materiaPrima_kit_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_materiaPrima_kit.CheckedChanged
        Checkbox_kit_OnChange(Nothing, Nothing)
    End Sub

    Private Sub RadioButton_prod_kit_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_prod_kit.CheckedChanged
        Checkbox_kit_OnChange(Nothing, Nothing)

    End Sub

    Private Sub Button_agregar_kit_Click(sender As Object, e As EventArgs) Handles Button_agregar_kit.Click
        If NumericUpDown_cant_kit.Value = 0 Then MsgBox("Falta la Cantidad.") : Exit Sub
        If ComboBox_prods_kit.Text = "" Or Nothing Then MsgBox("Seleccione un producto.") : Exit Sub

        Me.Cursor = Cursors.WaitCursor

        sql = "INSERT INTO productos_kit (codkit, codprod, producto, cantidad)" &
              "VALUES (" & CInt(Me.TextBox_codprod.Text) & ",'" & CStr(Me.ComboBox_prods_kit.SelectedValue) & "','" & CStr(Me.ComboBox_prods_kit.Text) & "','" & CStr(Me.NumericUpDown_cant_kit.Value) & "')"
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

        ComboBox_prods_kit.SelectedItem = Nothing
        NumericUpDown_cant_kit.Value = 0

        grid_prods_kit()


    End Sub

    Private Sub Button_quitar_kit_Click(sender As Object, e As EventArgs) Handles Button_quitar_kit.Click
        If KIT_sel_cod = "" Then KIT_sel_cod = 0
        If KIT_sel_cod = 0 Then MsgBox("Debe Seleccionar un producto.", vbInformation) : Exit Sub

        Me.Cursor = Cursors.WaitCursor

        sql = "delete from productos_kit where coNS='" & KIT_sel_cod & "'"
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

        ComboBox_prods_kit.SelectedItem = Nothing
        NumericUpDown_cant_kit.Value = 0

        grid_prods_kit()
        KIT_sel_cod = ""
    End Sub

    Private Sub ComboBox_prods_kit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_prods_kit.SelectedIndexChanged

    End Sub

    Private Sub loads_productos(ByVal critero As String)
        Me.Cursor = Cursors.WaitCursor

        'LLENADO DE PRODUCTOS COMBO
        Try
            sql = "SELECT * FROM productos where tipo='" & critero & "' order by nombre"
            da_prods_kit = New MySqlDataAdapter(sql, conex)
            dt_prods_kit = New DataTable
            da_prods_kit.Fill(dt_prods_kit)
            Me.ComboBox_prods_kit.DataSource = dt_prods_kit.DefaultView
            Me.ComboBox_prods_kit.DisplayMember = "nombre"
            Me.ComboBox_prods_kit.ValueMember = "cod"

            Me.ComboBox_prods_kit.SelectedItem = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_prods_kit.Dispose()
        dt_prods_kit.Dispose()
        conex.Close()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Timer_costo_prod_kit_Tick(sender As Object, e As EventArgs) Handles Timer_costo_prod_kit.Tick
        Timer_costo_prod_kit.Enabled = False
        costo_prod_kit = "0"
        Try
            sql = "SELECT costo from productos WHERE COD=" & ComboBox_prods_kit.SelectedValue & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                costo_prod_kit = CStr(row.Item("costo"))
            Next
        Catch ex As Exception
        End Try

        da.Dispose()
        dt.Dispose()
        conex.Close()
    End Sub

    Private Sub Grid_kit_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid_kit.CellContentClick

    End Sub

    Private Sub ComboBox_prods_kit_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_prods_kit.SelectionChangeCommitted
        Timer_costo_prod_kit.Enabled = True
    End Sub

    Private Sub Grid_kit_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid_kit.CellClick
        Dim row_KIT As DataGridViewRow = Grid_kit.CurrentRow


        KIT_sel_cod = CLng(row_KIT.Cells("CONS").Value)
    End Sub

    Private Sub datagridProdsList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        Btn_Ver_editar_Click(Nothing, Nothing)
    End Sub

    Private Sub TextBox_cod_personalizado_GotFocus(sender As Object, e As EventArgs) Handles TextBox_codprod.GotFocus
        TextBox_codprod.BackColor = Color.MistyRose
    End Sub

    Private Sub TextBox_cod_personalizado_LostFocus(sender As Object, e As EventArgs) Handles TextBox_codprod.LostFocus
        TextBox_codprod.BackColor = Color.White

    End Sub

    Private Sub TextBox_barras_GotFocus(sender As Object, e As EventArgs) Handles TextBox_barras.GotFocus
        TextBox_barras.BackColor = Color.MistyRose
        Label_conciencia.Text = "Escanee o digite el codigo de barras del producto/servicio."
    End Sub

    Private Sub TextBox_barras_LostFocus(sender As Object, e As EventArgs) Handles TextBox_barras.LostFocus
        TextBox_barras.BackColor = Color.White
        Label_conciencia.Text = "-"

    End Sub

    Private Sub ComboBox_categoria_GotFocus(sender As Object, e As EventArgs) Handles ComboBox_categoria.GotFocus
        ComboBox_categoria.BackColor = Color.MistyRose
        Label_conciencia.Text = "Seleccione la categorías a la que pertenece el producto ó servicio.  Puede crear mas categorías haciendo click en icono del (+)"

    End Sub

    Private Sub Textbox_Nombre_TextChanged(sender As Object, e As EventArgs)
        Label_titulo_producto2.Text = Textbox_Nombre.Text
        Label_titulo_producto1.Text = Textbox_Nombre.Text
        Label_titulo_producto3.Text = Textbox_Nombre.Text
        Label_titulo_producto4.Text = Textbox_Nombre.Text

    End Sub

    Private Sub ComboBox_categoria_LostFocus(sender As Object, e As EventArgs) Handles ComboBox_categoria.LostFocus
        ComboBox_categoria.BackColor = Color.White
        Label_conciencia.Text = "-"


    End Sub



    Private Sub TextBox_presentacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TextBox_presentacion.SelectedIndexChanged

    End Sub



    Private Sub TextBox_presentacion_GotFocus(sender As Object, e As EventArgs) Handles TextBox_presentacion.GotFocus
        TextBox_presentacion.BackColor = Color.MistyRose

    End Sub

    Private Sub Textbox_descripcion_TextChanged(sender As Object, e As EventArgs) Handles Textbox_descripcion.TextChanged

    End Sub

    Private Sub TextBox_presentacion_LostFocus(sender As Object, e As EventArgs) Handles TextBox_presentacion.LostFocus
        TextBox_presentacion.BackColor = Color.White

    End Sub

    Private Sub Textbox_descripcion_GotFocus(sender As Object, e As EventArgs) Handles Textbox_descripcion.GotFocus
        Textbox_descripcion.BackColor = Color.MistyRose
        Label_conciencia.Text = "escriba la descripción del producto/servicio."

    End Sub

    Private Sub TextBox_INVIMA_TextChanged(sender As Object, e As EventArgs) Handles TextBox_INVIMA.TextChanged

    End Sub

    Private Sub Textbox_descripcion_LostFocus(sender As Object, e As EventArgs) Handles Textbox_descripcion.LostFocus
        Textbox_descripcion.BackColor = Color.White
        Label_conciencia.Text = "-"

    End Sub

    Private Sub TextBox_INVIMA_GotFocus(sender As Object, e As EventArgs) Handles TextBox_INVIMA.GotFocus
        Label_conciencia.Text = "puede asigar el codigo invima cuando se trata de medicamentos."


        TextBox_INVIMA.BackColor = Color.MistyRose

    End Sub

    Private Sub RadioButton_prod_proc_kit_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_prod_proc_kit.CheckedChanged
        Checkbox_kit_OnChange(Nothing, Nothing)

    End Sub

    Private Sub TextBox_INVIMA_LostFocus(sender As Object, e As EventArgs) Handles TextBox_INVIMA.LostFocus
        Label_conciencia.Text = "-"

        TextBox_INVIMA.BackColor = Color.White

    End Sub

    Private Sub Button_AGREGAR_CATEGORIA_MouseEnter(sender As Object, e As EventArgs) Handles Button_AGREGAR_CATEGORIA.MouseEnter
        Label_conciencia.Text = "Puede crear mas categorías haciendo click en este icono."

    End Sub

    Private Sub Button_AGREGAR_CATEGORIA_MouseLeave(sender As Object, e As EventArgs) Handles Button_AGREGAR_CATEGORIA.MouseLeave
        Label_conciencia.Text = "-"

    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Label_conciencia.Text = "haga click para seleccionar la imgen del producto/servicio."

    End Sub

    Private Sub TextBox7_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Label_conciencia.Text = "-"

    End Sub

    Private Sub TextBox_valor1_GiveFeedback(sender As Object, e As GiveFeedbackEventArgs)
        TextBox_valor1.BackColor = Color.MistyRose

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub TextBox_ubicacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TextBox_ubicacion.SelectedIndexChanged

    End Sub

    Private Sub MetroComboBox_decimales_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroComboBox_decimales.SelectedIndexChanged

    End Sub

    Private Sub MetroComboBox_decimales_GotFocus(sender As Object, e As EventArgs) Handles MetroComboBox_decimales.GotFocus
        MetroComboBox_decimales.BackColor = Color.MistyRose
    End Sub

    Private Sub MetroComboBox_decimales_LostFocus(sender As Object, e As EventArgs) Handles MetroComboBox_decimales.LostFocus
        MetroComboBox_decimales.BackColor = Color.White

    End Sub

    Private Sub ComboBox_INVENTARIO_GotFocus(sender As Object, e As EventArgs) Handles ComboBox_INVENTARIO.GotFocus
        ComboBox_INVENTARIO.BackColor = Color.MistyRose

    End Sub

    Private Sub ComboBox_INVENTARIO_LostFocus(sender As Object, e As EventArgs) Handles ComboBox_INVENTARIO.LostFocus
        ComboBox_INVENTARIO.BackColor = Color.White

    End Sub

    Private Sub TextBox_ubicacion_GotFocus(sender As Object, e As EventArgs) Handles TextBox_ubicacion.GotFocus
        TextBox_ubicacion.BackColor = Color.MistyRose

    End Sub

    Private Sub TextBox_stock_maximo_TextChanged(sender As Object, e As EventArgs) Handles TextBox_stock_maximo.TextChanged

    End Sub

    Private Sub TextBox_ubicacion_LostFocus(sender As Object, e As EventArgs) Handles TextBox_ubicacion.LostFocus
        TextBox_ubicacion.BackColor = Color.White

    End Sub

    Private Sub TextBox_stock_maximo_GotFocus(sender As Object, e As EventArgs) Handles TextBox_stock_maximo.GotFocus
        TextBox_stock_maximo.BackColor = Color.MistyRose

    End Sub

    Private Sub TextBox_stock_maximo_LostFocus(sender As Object, e As EventArgs) Handles TextBox_stock_maximo.LostFocus
        TextBox_stock_maximo.BackColor = Color.White
        NUMERIC_costo.Focus()

    End Sub

    Private Sub NumericUpDown1_LostFocus(sender As Object, e As EventArgs) Handles NumericUpDown1.LostFocus
        Me.NumericUpDown1.BackColor = Color.White

    End Sub

    Private Sub NumericUpDown1_GotFocus(sender As Object, e As EventArgs) Handles NumericUpDown1.GotFocus
        Me.NumericUpDown1.BackColor = Color.MistyRose
    End Sub

    Private Sub NumericUpDown2_GotFocus(sender As Object, e As EventArgs) Handles NumericUpDown2.GotFocus
        Me.NumericUpDown2.BackColor = Color.MistyRose
    End Sub

    Private Sub NumericUpDown2_LostFocus(sender As Object, e As EventArgs) Handles NumericUpDown2.LostFocus
        Me.NumericUpDown2.BackColor = Color.White
    End Sub

    Private Sub NumericUpDown3_GotFocus(sender As Object, e As EventArgs) Handles NumericUpDown3.GotFocus
        Me.NumericUpDown3.BackColor = Color.MistyRose

    End Sub



    Private Sub MetroTabControl1_Selecting(sender As Object, e As TabControlCancelEventArgs)

    End Sub

    Private Sub MetroTabControl1_MouseClick(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub NumericUpDown3_LostFocus(sender As Object, e As EventArgs) Handles NumericUpDown3.LostFocus
        Me.NumericUpDown3.BackColor = Color.White

    End Sub

    Private Sub MetroTabControl1_Selected(sender As Object, e As TabControlEventArgs)


    End Sub

    Private Sub NumericUpDown_alerta_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_alerta.ValueChanged

    End Sub



    Private Sub NumericUpDown_alerta_LostFocus(sender As Object, e As EventArgs) Handles NumericUpDown_alerta.LostFocus
        Me.NumericUpDown_alerta.BackColor = Color.White
        Label_conciencia.Text = "."

        TextBox_barras.Focus()

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub NumericUpDown_alerta_GotFocus(sender As Object, e As EventArgs) Handles NumericUpDown_alerta.GotFocus
        Me.NumericUpDown_alerta.BackColor = Color.MistyRose
        Label_conciencia.Text = "puede asignar un tiempo de alerta al producto, ideal para la configuración de billares, moteles etc."

    End Sub

    Private Sub ComboBox_categoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox_categoria.KeyPress
        If ComboBox_categoria.DroppedDown = True Then
            ComboBox_categoria.DroppedDown = False
        End If
    End Sub

    Private Sub BackgroundWorker_excel_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker_excel.DoWork
        Try
            My.Computer.FileSystem.CopyFile("c:\miclick\plantilla.xlsx",
            Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\productos.xlsx", True) ' muevo el archivo 
        Catch ex As Exception
            MsgBox("la plantilla no existe", vbInformation)
            BackgroundWorker_excel.CancelAsync()
            Exit Sub
        End Try





        Application.DoEvents()

        Try
            'llena_grid_PRODUCTOS_EXPORT("xls")


            Dim dt As DataTable = DirectCast(MetroGrid_pdf.DataSource, DataTable)
            ExportToExcel(dt, Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\productos.xlsx", "Hoja1")
        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

        End Try


        If BackgroundWorker_excel.CancellationPending Then Exit Sub


    End Sub

    Private Sub ComboBox_prods_kit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox_prods_kit.KeyPress
        If ComboBox_prods_kit.DroppedDown = True Then
            ComboBox_prods_kit.DroppedDown = False
        End If
    End Sub

    Private Sub BackgroundWorker_excel_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker_excel.RunWorkerCompleted
        datagridProdsList.Visible = True
        Me.Cursor = Cursors.Default
        Panel_buttons.Enabled = True
        Panel_busqueda.Enabled = True

        'MessageBox.Show("Los datos han sido exportados satisfactoriamente.")
        Dim RTA1 As String
        RTA1 = MsgBox("Los datos han sido exportados." & Chr(13) & Chr(13) & "Desea ver el archivo ahora?.", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If RTA1 = 6 Then

            Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\productos.xlsx")

        End If



    End Sub

    Private Sub TextBox_presentacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_presentacion.KeyPress
        If TextBox_presentacion.DroppedDown = True Then
            TextBox_presentacion.DroppedDown = False
        End If
    End Sub

    Private Sub MetroTabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LABEL_TIPOPROD_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        If File.Exists("c:\miclickderecho\ManualProductos.pdf") Then
            Process.Start("c:\miclickderecho\ManualProductos.pdf")
        Else
            MsgBox("no se encontró el archivo de ayuda, por lo que se cargará desde internet.")
            Me.Cursor = Cursors.WaitCursor
            Try
                ' System.Diagnostics.Process.Start("C:\Archivos de PRograma\Internet Explorer\iexplorer.exe", "www.google.com")
                Dim pag As String
                pag = "http://www.miclickderecho.com/manual/manualproductos.pdf"
                Shell("Explorer " & pag)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            Me.Cursor = Cursors.Default



        End If



    End Sub



    Private Sub ComboBoxeSTADO_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub Background_GRID_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles Background_GRID.ProgressChanged

    End Sub

    Private Sub Timer_CATEG_Tick(sender As Object, e As EventArgs) Handles Timer_CATEG.Tick


        ' SE EJECUTA CUANDO SALEN DE CREAR CATEGORIAS

        Timer_CATEG.Enabled = False

        Cursor.Current = Cursors.WaitCursor
        Try
            sql = "SELECT cons, concat(tipo,'  | ',categoria) as cat FROM PRODUCTOS_CATEGORIAS ORDER BY TIPO, CATEGORIA"
            dA_categorias = New MySqlDataAdapter(sql, conex)
            dt_categorias = New DataTable
            dA_categorias.Fill(dt_categorias)

            cant_cats = dt_categorias.Rows.Count 'cantidad de categorias
            label_info_cant_cats.Text = cant_cats & " Categorías."

            ComboBox_categoria.DataSource = dt_categorias.DefaultView
            ComboBox_categoria.DisplayMember = "cat"
            ComboBox_categoria.ValueMember = "CONS"

        Catch ex As Exception
            Cursor.Current = Cursors.Default
            MsgBox(ex.Message)
        End Try
        conex.Close()
        dA_categorias.Dispose()
        dt_categorias.Dispose()
        conex.Close()

        Try
            sql = "SELECT cons, concat(tipo,'  | ',categoria) as cat FROM PRODUCTOS_CATEGORIAS ORDER BY TIPO, CATEGORIA"
            dA_categorias2 = New MySqlDataAdapter(sql, conex)
            dt_categorias2 = New DataTable
            dA_categorias2.Fill(dt_categorias2)

            Combobox_categoria_buscar.DataSource = dt_categorias2.DefaultView
            Combobox_categoria_buscar.DisplayMember = "cat"
            Combobox_categoria_buscar.ValueMember = "CONS"

        Catch ex As Exception
            Cursor.Current = Cursors.Default
            MsgBox(ex.Message)
        End Try
        conex.Close()
        dA_categorias2.Dispose()
        dt_categorias2.Dispose()
        conex.Close()



    End Sub

    Private Sub Combobox_categoria_buscar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combobox_categoria_buscar.SelectedIndexChanged

    End Sub



    Private Sub Combobox_categoria_buscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Combobox_categoria_buscar.KeyPress
        If Combobox_categoria_buscar.DroppedDown = True Then
            Combobox_categoria_buscar.DroppedDown = False
        End If

        If Combobox_categoria_buscar.Text = "" Then
            Combobox_categoria_buscar.SelectedItem = Nothing
            CATEGORIA_BUSCAR = ""
        End If
    End Sub
    Private Sub Checkbox_prods_OnChange(sender As Object, e As EventArgs) Handles Checkbox_prods.OnChange
        filtro_TIPO = " AND TIPO IN("

        If Checkbox_prods.Checked = False And Checkbox_servs.Checked = False And Checkbox_procesados.Checked = False And Checkbox_insumos.Checked = False Then
            filtro_TIPO = ""
            'Dim filtro_TIPO As String = " AND TIPO IN('PRODUCTOS','PROCESADOS','INSUMOS','SERVICIOS')"

            Exit Sub
        End If


        If Checkbox_procesados.Checked = True Then filtro_TIPO = filtro_TIPO & "'PROCESADOS',"
        If Checkbox_insumos.Checked = True Then filtro_TIPO = filtro_TIPO & "'INSUMOS',"
        If Checkbox_servs.Checked = True Then filtro_TIPO = filtro_TIPO & "'SERVICIOS',"
        If Checkbox_prods.Checked = True Then filtro_TIPO = filtro_TIPO & "'PRODUCTOS'"
        If Checkbox_prods.Checked = False Then filtro_TIPO = filtro_TIPO.TrimEnd(",")

        filtro_TIPO = filtro_TIPO & ")"
    End Sub
    Private Sub Checkbox_procesados_OnChange(sender As Object, e As EventArgs) Handles Checkbox_procesados.OnChange
        filtro_TIPO = " AND TIPO IN("
        If Checkbox_prods.Checked = False And Checkbox_servs.Checked = False And Checkbox_procesados.Checked = False And Checkbox_insumos.Checked = False Then
            filtro_TIPO = ""
            Exit Sub

        End If
        If Checkbox_insumos.Checked = True Then filtro_TIPO = filtro_TIPO & "'INSUMOS',"
        If Checkbox_servs.Checked = True Then filtro_TIPO = filtro_TIPO & "'SERVICIOS',"
        If Checkbox_prods.Checked = True Then filtro_TIPO = filtro_TIPO & "'PRODUCTOS',"
        If Checkbox_procesados.Checked = True Then filtro_TIPO = filtro_TIPO & "'PROCESADOS'"
        If Checkbox_procesados.Checked = False Then filtro_TIPO = filtro_TIPO.TrimEnd(",")

        filtro_TIPO = filtro_TIPO & ")"
    End Sub

    Private Sub Checkbox_servs_OnChange(sender As Object, e As EventArgs) Handles Checkbox_servs.OnChange
        filtro_TIPO = " AND TIPO IN("
        If Checkbox_prods.Checked = False And Checkbox_servs.Checked = False And Checkbox_procesados.Checked = False And Checkbox_insumos.Checked = False Then
            filtro_TIPO = ""
            Exit Sub

        End If
        If Checkbox_prods.Checked = True Then filtro_TIPO = filtro_TIPO & "'PRODUCTOS',"
        If Checkbox_procesados.Checked = True Then filtro_TIPO = filtro_TIPO & "'PROCESADOS',"
        If Checkbox_insumos.Checked = True Then filtro_TIPO = filtro_TIPO & "'INSUMOS',"
        If Checkbox_servs.Checked = True Then filtro_TIPO = filtro_TIPO & "'SERVICIOS'"
        If Checkbox_servs.Checked = False Then filtro_TIPO = filtro_TIPO.TrimEnd(",")


        filtro_TIPO = filtro_TIPO & ")"
    End Sub

    Private Sub Checkbox_insumos_OnChange(sender As Object, e As EventArgs) Handles Checkbox_insumos.OnChange
        filtro_TIPO = " AND TIPO IN("

        If Checkbox_prods.Checked = False And Checkbox_servs.Checked = False And Checkbox_procesados.Checked = False And Checkbox_insumos.Checked = False Then
            filtro_TIPO = ""
            Exit Sub

        End If
        If Checkbox_procesados.Checked = True Then filtro_TIPO = filtro_TIPO & "'PROCESADOS',"
        If Checkbox_servs.Checked = True Then filtro_TIPO = filtro_TIPO & "'SERVICIOS',"
        If Checkbox_prods.Checked = True Then filtro_TIPO = filtro_TIPO & "'PRODUCTOS',"
        If Checkbox_insumos.Checked = True Then filtro_TIPO = filtro_TIPO & "'INSUMOS'"
        If Checkbox_insumos.Checked = False Then filtro_TIPO = filtro_TIPO.TrimEnd(",")

        filtro_TIPO = filtro_TIPO & ")"
    End Sub



    Private Sub NUMERIC_costo_ValueChanged(sender As Object, e As EventArgs) Handles NUMERIC_costo.ValueChanged


        TextBox_precio_TextChanged(Nothing, Nothing)
        TextBox_valor2_TextChanged(Nothing, Nothing)
        TextBox_valor3_TextChanged(Nothing, Nothing)
    End Sub






    Private Sub Combobox_categoria_buscar_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Combobox_categoria_buscar.SelectionChangeCommitted
        'Timer_CATEG.Enabled = True
        Dim cat_buscar() As String

        cat_buscar = Strings.Split(Combobox_categoria_buscar.Text, "|")
        CATEGORIA_BUSCAR = Strings.Trim(cat_buscar(1))
    End Sub

    Private Sub datagridProdsList_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub

    Private Sub BunifuCheckbox_COCINA_OnChange(sender As Object, e As EventArgs) Handles BunifuCheckbox_COCINA.OnChange

    End Sub

    Private Sub Panel_titlebar_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TextBox_valor2_ValueChanged(sender As Object, e As EventArgs) Handles TextBox_valor2.ValueChanged
        TextBox_valor2_TextChanged(Nothing, Nothing)


    End Sub

    Private Sub datagridProdsList_KeyDown(sender As Object, e As KeyEventArgs)
        'If e.KeyCode = Keys.Enter Then

        '    datagridProdsList_CellClick(Nothing, Nothing)
        '    Btn_Ver_editar_Click(Nothing, Nothing)
        'End If
    End Sub

    Private Sub TextBox_valor1_ValueChanged(sender As Object, e As EventArgs) Handles TextBox_valor1.ValueChanged
        TextBox_precio_TextChanged(Nothing, Nothing)

    End Sub

    Private Sub TextBox_valor2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_valor2.KeyPress
        If InStr(1, "0123456789," & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""

    End Sub

    Private Sub TextBox_valor3_ValueChanged(sender As Object, e As EventArgs) Handles TextBox_valor3.ValueChanged
        TextBox_valor3_TextChanged(Nothing, Nothing)

    End Sub

    Private Sub TextBox_valor1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_valor1.KeyPress
        If InStr(1, "0123456789," & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""

    End Sub

    Private Sub TextBox_valor3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_valor3.KeyPress
        If InStr(1, "0123456789," & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""

    End Sub

    Private Sub TextBox_espejo1_TextChanged(sender As Object, e As EventArgs) Handles TextBox_espejo1.TextChanged

    End Sub

    Private Sub NUMERIC_costo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NUMERIC_costo.KeyPress
        If InStr(1, "0123456789," & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""

    End Sub

    Private Sub TextBox_valor1_TextChanged(sender As Object, e As EventArgs) Handles TextBox_valor1.TextChanged

        'Me.TextBox_valor1.Select(Me.TextBox_valor1.Value.ToString.Length, 0)

        'Label_utilidad_Click(Nothing, Nothing)
    End Sub

    Private Sub TextBox_valor2_TextChanged(sender As Object, e As EventArgs) Handles TextBox_valor2.TextChanged

        If Me.TextBox_valor2.Text = "" Then Me.TextBox_valor2.Text = "0"


        Me.TextBox_valor2.Text = FormatNumber(Me.TextBox_valor2.Text, 0)
        Me.TextBox_valor2.Select(Me.TextBox_valor2.Text.Length, 0)

        If puede_cacular_utilidad = False Then Exit Sub

        Dim VR1, VR2 As Integer
        Dim incremento As Decimal

        If CInt(TextBox_valor2.Value) = "0" Or CInt(NUMERIC_costo.Value) = "0" Then
            Exit Sub
        End If

        VR1 = CInt(TextBox_valor2.Value)
        VR2 = CInt(NUMERIC_costo.Value)

        incremento = (VR1 - VR2)
        incremento = (VR1 - VR2) / VR2
        incremento = incremento * 100

        Me.Label_utilidad.Text = "Utilidad:  "

        Me.NumericUpDown2.Value = incremento

    End Sub

    Private Sub TextBox_valor3_TextChanged(sender As Object, e As EventArgs) Handles TextBox_valor3.TextChanged
        If Me.TextBox_valor3.Text = "" Then Me.TextBox_valor3.Text = "0"


        Me.TextBox_valor3.Text = FormatNumber(Me.TextBox_valor3.Text, 0)
        Me.TextBox_valor3.Select(Me.TextBox_valor3.Text.Length, 0)


        If puede_cacular_utilidad = False Then Exit Sub

        Dim VR1, VR2 As Integer
        Dim incremento As Decimal

        If CInt(TextBox_valor3.Value) = "0" Or CInt(NUMERIC_costo.Value) = "0" Then
            Exit Sub
        End If

        VR1 = CInt(TextBox_valor3.Value)
        VR2 = CInt(NUMERIC_costo.Value)

        incremento = (VR1 - VR2)
        incremento = (VR1 - VR2) / VR2
        incremento = incremento * 100

        Me.Label_utilidad.Text = "Utilidad:  "

        Me.NumericUpDown3.Value = incremento
    End Sub

    Private Sub TextBox_valor1_GotFocus(sender As Object, e As EventArgs) Handles TextBox_valor1.GotFocus
        TextBox_valor1.BackColor = Color.MistyRose

    End Sub

    Private Sub TextBox_valor2_GotFocus(sender As Object, e As EventArgs) Handles TextBox_valor2.GotFocus
        TextBox_valor2.BackColor = Color.MistyRose

    End Sub

    Private Sub TextBox_valor3_GotFocus(sender As Object, e As EventArgs) Handles TextBox_valor3.GotFocus
        TextBox_valor3.BackColor = Color.MistyRose

    End Sub

    Private Sub TextBox_valor1_LostFocus(sender As Object, e As EventArgs) Handles TextBox_valor1.LostFocus
        TextBox_valor1.BackColor = Color.White

    End Sub

    Private Sub TextBox_valor2_LostFocus(sender As Object, e As EventArgs) Handles TextBox_valor2.LostFocus
        TextBox_valor2.BackColor = Color.White

    End Sub

    Private Sub Button_exportar_productos_Click(sender As Object, e As EventArgs) Handles Button_exportar_productos.Click


        If RadioButton_normal.Checked = True Then
            'formato normal
            Me.Cursor = Cursors.WaitCursor

            If Not File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs") Then
                My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\ClickDerecho Docs")
            End If

            Try
                'Intentar generar el documento.
                Dim doc As New Document(PageSize.A4, 15, 15, 15, 15)
                'Path que guarda el reporte en el escritorio de windows (Desktop).
                Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\Listado de productos.pdf"
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

            Me.Cursor = Cursors.Default
        End If

        If RadioButton_xls.Checked = True Then
            Dim RTA1 As String
            RTA1 = MsgBox("El informe que se va a generar puede tardar un tiempo considerable dependiendo de su tamaño." & Chr(13) & "Desea generar el archivo ahora?.", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
            If RTA1 = 6 Then
                llena_grid_PRODUCTOS_EXPORT("xls")

                datagridProdsList.Visible = False

                Me.Cursor = Cursors.WaitCursor
                Panel_buttons.Enabled = False
                Panel_busqueda.Enabled = False

                BackgroundWorker_excel.WorkerReportsProgress = True
                BackgroundWorker_excel.WorkerSupportsCancellation = True
                BackgroundWorker_excel.RunWorkerAsync()

            End If
        End If



        ' exportar kit
        If RadioButton_kit_pdf.Checked = True Then
            Try
                'Intentar generar el documento.
                Dim doc As New Document(PageSize.A4, 15, 15, 15, 15)
                'Path que guarda el reporte en el escritorio de windows (Desktop).
                Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\Listado de productos.pdf"
                Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
                PdfWriter.GetInstance(doc, file)
                doc.Open()
                ExportarDatosKIT(doc)
                doc.Close()
                Process.Start(filename)
            Catch ex As Exception
                'Si el intento es fallido, mostrar MsgBox.
                MessageBox.Show("No se puede generar el documento PDF, Cierre los documentos PDF generados anteriormente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Button_cerrar_exportar_Click(sender As Object, e As EventArgs) Handles Button_cerrar_exportar.Click
        datagridProdsList.Enabled = True

        Panel_buttons.Enabled = True
        Panel_busqueda.Enabled = True

        BunifuCards_exportar.Visible = False
    End Sub

    Private Sub Button_excel_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox_valor3_LostFocus(sender As Object, e As EventArgs) Handles TextBox_valor3.LostFocus
        TextBox_valor3.BackColor = Color.White

    End Sub

    Private Sub ListarTodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarTodoToolStripMenuItem.Click

        If Form_categorias.Visible = True Then
            Form_categorias.BringToFront()
            Exit Sub
        End If
        Form_categorias.Show(Me)

    End Sub

    Private Sub RadioButton_kit_pdf_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_kit_pdf.CheckedChanged


    End Sub

    Private Sub Textbox_Nombre_OnValueChanged(sender As Object, e As EventArgs) Handles Textbox_Nombre.OnValueChanged

    End Sub

    Private Sub Button_AGREGAR_CATEGORIA_MouseDown(sender As Object, e As MouseEventArgs) Handles Button_AGREGAR_CATEGORIA.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right = False Then
            Button_AGREGAR_CATEGORIA.ContextMenuStrip = ContextMenuStrip_LOAD_CAT
            Me.ContextMenuStrip_LOAD_CAT.Show(Button_AGREGAR_CATEGORIA, New Point(Button_AGREGAR_CATEGORIA.Width - Button_AGREGAR_CATEGORIA.Width, Button1.Height))
        End If
    End Sub

    Private Sub Textbox_Nombre_LostFocus(sender As Object, e As EventArgs) Handles Textbox_Nombre.LostFocus
        Textbox_Nombre.BackColor = Color.White
        Label_conciencia.Text = "-"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged





    End Sub



    Private Sub RadioButton_normal_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_normal.CheckedChanged
        If RadioButton_normal.Checked = True Then
            RadioButton_normal.BackColor = Color.FromArgb(51, 205, 117)
        End If

        If RadioButton_normal.Checked = False Then
            RadioButton_normal.BackColor = Color.White
        End If
    End Sub

    Private Sub RadioButton_xls_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_xls.CheckedChanged
        If RadioButton_xls.Checked = True Then
            RadioButton_xls.BackColor = Color.FromArgb(51, 205, 117)
        End If

        If RadioButton_xls.Checked = False Then
            RadioButton_xls.BackColor = Color.White
        End If
    End Sub



    Private Sub PictureBox1_Click_2(sender As Object, e As EventArgs) Handles PictureBox1.Click
        RadioButton_normal.Checked = True

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        RadioButton_xls.Checked = True

    End Sub

    Private Sub TextBox_nombrebuscar_OnValueChanged(sender As Object, e As EventArgs) Handles TextBox_nombrebuscar.OnValueChanged

    End Sub

    Private Sub Textbox_Nombre_GotFocus(sender As Object, e As EventArgs) Handles Textbox_Nombre.GotFocus
        Textbox_Nombre.BackColor = Color.MistyRose
        Label_conciencia.Text = "escriba el nombre del producto/servicio."
    End Sub

    Private Sub TextBox_nombrebuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_nombrebuscar.KeyPress

        If RadioButton_codigo.Checked = True Then
            If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""
        End If



    End Sub

    Private Sub TextBox_ref_TextChanged(sender As Object, e As EventArgs) Handles TextBox_ref.TextChanged

    End Sub

    Private Sub TextBox_nombrebuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_nombrebuscar.KeyDown

        If e.KeyCode = "13" Then
            Button2_Click(Nothing, Nothing)
        End If


    End Sub

    Private Sub TextBox_ref_GotFocus(sender As Object, e As EventArgs) Handles TextBox_ref.GotFocus
        TextBox_ref.BackColor = Color.MistyRose
    End Sub

    Private Sub CheckBox_categorias_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_categorias.CheckedChanged
        If CheckBox_categorias.Checked = True Then
            Combobox_categoria_buscar.Enabled = True
            Combobox_categoria_buscar.SelectedItem = Nothing

        Else
            Combobox_categoria_buscar.Enabled = False
            Combobox_categoria_buscar.SelectedItem = Nothing
        End If

    End Sub

    Private Sub Button_ayuda_Click(sender As Object, e As EventArgs) Handles Button_ayuda.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            ' System.Diagnostics.Process.Start("C:\Archivos de PRograma\Internet Explorer\iexplorer.exe", "www.google.com")
            Dim pag As String
            pag = "http://www.miclickderecho.com/ayudaproductos.html"
            Shell("Explorer " & pag)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Label42_Click(sender As Object, e As EventArgs) Handles Label42.Click

    End Sub

    Private Sub Label59_Click(sender As Object, e As EventArgs) Handles Label59.Click

    End Sub

    Private Sub TextBox_min_compra_TextChanged(sender As Object, e As EventArgs) Handles TextBox_min_compra.TextChanged

    End Sub

    Private Sub Label51_Click_1(sender As Object, e As EventArgs) Handles Label51.Click

    End Sub

    Private Sub TextBox_max_compra_TextChanged(sender As Object, e As EventArgs) Handles TextBox_max_compra.TextChanged

    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs) Handles Label25.Click

    End Sub

    Private Sub TextBox_entradas_TextChanged(sender As Object, e As EventArgs) Handles TextBox_entradas.TextChanged

    End Sub

    Private Sub TextBox_salidas_TextChanged(sender As Object, e As EventArgs) Handles TextBox_salidas.TextChanged

    End Sub

    Private Sub TextBox_existencias_TextChanged(sender As Object, e As EventArgs) Handles TextBox_existencias.TextChanged

    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label32_Click(sender As Object, e As EventArgs) Handles Label32.Click

    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_VerVentas.CheckedChanged

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub ButtonVerInfoProd_Click(sender As Object, e As EventArgs) Handles ButtonVerInfoProd.Click

        If RadioButton_VerVentas.Checked = False And RadioButton_vercompras.Checked = False And RadioButton_VerMovs.Checked = False Then
            MsgBox("Seleccione una opcion para la consulta.")
            Exit Sub
        End If



        If CheckBox_FiltroPeriodoConsultas.Checked = True Then
            If ComboBox_PeriodoConsulta.Text = "" Then
                MsgBox("Seleccione un periodo.")
                Exit Sub
            End If
        End If


        grid_prods_info()
    End Sub

    Private Sub RadioButton_VerMovs_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_VerMovs.CheckedChanged
        If RadioButton_VerMovs.Checked = True Then
            Try
                sql = "SELECT cons, nombrebodega FROM bodegas"
                da_bods = New MySqlDataAdapter(sql, conex)
                dt_bods = New DataTable
                da_bods.Fill(dt_bods)
                Me.ComboBox_bods.DataSource = dt_bods.DefaultView
                Me.ComboBox_bods.DisplayMember = "nombrebodega"
                Me.ComboBox_bods.ValueMember = "cons"

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da_bods.Dispose()
            dt_bods.Dispose()
            conex.Close()

            ComboBox_bods.Visible = True
            Label44.Visible = True
        Else
            ComboBox_bods.Visible = False
            Label44.Visible = False
            Me.ComboBox_bods.DataSource = Nothing
        End If
    End Sub

    Private Sub CheckBox_FiltroPeriodoConsultas_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_FiltroPeriodoConsultas.CheckedChanged
        If CheckBox_FiltroPeriodoConsultas.Checked = True Then
            ComboBox_PeriodoConsulta.Enabled = True
            ComboBox_PeriodoConsulta.SelectedItem = Nothing

            NumericUpDown_anoconsulta.Enabled = True
        Else
            ComboBox_PeriodoConsulta.Enabled = False
            ComboBox_PeriodoConsulta.SelectedItem = Nothing

            NumericUpDown_anoconsulta.Enabled = False
        End If
    End Sub


    Private Sub Button_InfoMovs_Click(sender As Object, e As EventArgs) Handles Button_InfoMovs.Click
        MsgBox("el resumen de movimientos muestra la infomacion de el numero de entradas y salidas que resgistra este producto en la bodega seleccionada.", vbInformation)
    End Sub

    Private Sub Button_InfoCompra_Click(sender As Object, e As EventArgs) Handles Button_InfoCompra.Click

    End Sub

    Private Sub Label43_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox_bodegasInfo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_bodegasInfo.SelectedIndexChanged

    End Sub

    Private Sub TextBox_ref_LostFocus(sender As Object, e As EventArgs) Handles TextBox_ref.LostFocus
        TextBox_ref.BackColor = Color.White
    End Sub

    Private Sub Grid_InfoProd_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid_InfoProd.CellContentClick

    End Sub

    Private Sub ComboBox_bodegasInfo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_bodegasInfo.SelectionChangeCommitted

    End Sub

    Private Sub datagridProdsList_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles datagridProdsList.CellContentClick

    End Sub

    Private Sub Grid_InfoProd_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid_InfoProd.CellClick
        Dim columna As String = ""
        If RadioButton_VerVentas.Checked = True Then columna = "documento"
        If RadioButton_vercompras.Checked = True Then columna = "numpedido"
        If RadioButton_VerMovs.Checked = True Then columna = "documento"



        If IsDBNull(Grid_InfoProd.Item(columna, 0).Value) Then
            Exit Sub
        End If





        Dim row_AbrirDoc As DataGridViewRow = Grid_InfoProd.CurrentRow


        If RadioButton_VerVentas.Checked = True Then
            ABRIR_TIPO_DOC_doc = CLng(row_AbrirDoc.Cells("documento").Value)
            ABRIR_TIPO_DOC_doc = "VENTA"

        End If

        If RadioButton_vercompras.Checked = True Then
            ABRIR_TIPO_DOC_doc = "COMPRA"

            ABRIR_TIPO_DOC_doc = CLng(row_AbrirDoc.Cells("numpedido").Value)
        End If

        If RadioButton_VerMovs.Checked = True Then
            ABRIR_TIPO_DOC_doc = CLng(row_AbrirDoc.Cells("documento").Value)
            ABRIR_TIPO_DOC = CStr(row_AbrirDoc.Cells("tipodocumento").Value)
        End If

    End Sub

    Private Sub ButtonConsultarDocumento_Click(sender As Object, e As EventArgs) Handles ButtonConsultarDocumento.Click









        If RadioButton_VerMovs.Checked = True Then



            If ABRIR_TIPO_DOC = "VENTA" Then
                'MsgBox("ABRIR VENTA")
                ID_VENTA_VER = ABRIR_TIPO_DOC_doc
                Form_verfactura.Show()
            End If

            If ABRIR_TIPO_DOC = "COMPRA" Then
                'MsgBox("ABRIR ORDEN COMPRA")
                ID_compra_VER = ABRIR_TIPO_DOC_doc
                FormPedidodeproveedor.Show()
            End If

            If ABRIR_TIPO_DOC = "ORDEN DE PRODUCCION" Then
                MsgBox("ABRIR ORDEN DE PRODUCCION")
            End If

            If ABRIR_TIPO_DOC.ToLower.Contains("movimiento") = True Or ABRIR_TIPO_DOC.ToLower.Contains("entrada") = True Or ABRIR_TIPO_DOC.ToLower.Contains("salida") = True Or ABRIR_TIPO_DOC.ToLower.Contains("inventario inicial") = True Then
                'MsgBox("ABRIR MOVIMIETNO")
                CodMovimientoVer = ABRIR_TIPO_DOC_doc
                TipoMovimientoVer = ABRIR_TIPO_DOC
                Form_movimientos.Show()
                Form_movimientos.BringToFront()
                Form_movimientos.TimerVerLoad.Enabled = True
            End If
        End If
    End Sub

    Private Sub datagridProdsList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridProdsList.CellClick

    End Sub
End Class