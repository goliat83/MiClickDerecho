Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.draw

Public Class Form_sales
    Dim factura_con_imp As Boolean = False

    Dim estado_unir_mesa As Boolean = False
    Dim invitador_cuenta As String = ""
    Dim invitador_mesa As String = ""
    Dim invitador_salon As String = ""

    Dim inv_prod_cta_vender, inv_prod_cuenta_inventariar, inv_prod_cuenta_costear, inv_prod_cuenta_devolver As String


    Private WithEvents panel_flow_cuenta As New FlowLayoutPanel
    Private WithEvents BOTON_CTA As New Button
    Private WithEvents BOTON_LAB_CTA As New Button
    Private WithEvents BOTON_ZONE As New Button

    Private WithEvents BOTON_CAT As New Button
    Private WithEvents BOTON_product As New Button
    Private WithEvents BOTON_LAB_prod As New Button

    Private WithEvents panel_flow_in As New FlowLayoutPanel
    Private WithEvents BOTON_MESAS As New Button
    Private WithEvents BOTON_LAB_mesa As New Button
    Private WithEvents BOTON_NFac As New Button


    Dim MEDIO_PAGO_DESTINO_COD, MEDIO_PAGO_DESTINO_NOMBRE, MEDIO_PAGO_DESTINO_TIPO As String
    Dim medio_de_pago As String = ""

    Dim PROD_SALDO, PROD_ENTRAN, PROD_SALEN As String
    Dim SALDO_DEL_PRODUCTO As Integer = 0
    Dim entran, salen, saldo As Integer
    Dim total_esta_venta, descuento, subtotal, baseimpuesto, impuesto, baseimpuesto2, impuesto2, totalapagar As Integer
    Dim fecha_de_pago As String



    Public da_dctos_venta As New MySqlDataAdapter
    Public dt_dctos_venta As New DataTable

    Public da_pre As New MySqlDataAdapter
    Public dt_pre As New DataTable

    Public da_pos As New MySqlDataAdapter
    Public dt_pos As DataTable

    Dim alto_pag As Integer = 0


    Public da_imp As New MySqlDataAdapter
    Public dt_imp As DataTable

    Public da_zone As New MySqlDataAdapter
    Public dt_zone As DataTable

    Public da_CtaPagar As New MySqlDataAdapter
    Public dt_CtaPagar As DataTable

    Dim nuevo_precio As Integer = 0


    Dim prod_cod_sel As String = ""
    Dim prod_cons_Sel As String = ""
    Dim prod_nom_sel As String = ""
    Dim prod_CANT_sel As String = ""
    Dim prod_PRECIO_sel As String = ""


    Dim agregando As String = ""
    Public da_prods_venta As New MySqlDataAdapter


    Dim prod_cons, prod_cod, prod_barras, prod_nom, prod_desc, PROD_VALOR_UNITARIO_BASE, PROD_VALOR_UNITARIO_total, prod_valor, prod_valor2, prod_valor3, PROD_CATEGORIA, prod_iva, prod_iva2, PROD_IVATIPO, PROD_IVATIPO2, prod_iva1nom, prod_iva2nom, prod_base, PROD_IVA_VR, PROD_IVA_VR2, prod_stock, prod_decimal, prod_imagen, prod_lote, PROD_VENCE, PROD_INVENTARIADO, prod_costo, prod_costo_prom, ID_COSTO_BODEGA, prod_cocina, prod_parrilla, prod_bar, prod_tipo, prod_kit, prod_cta_vender, prod_cta_inventariar, prod_cta_costear, prod_cta_devolver, prod_alerta As String

    Dim SALDO_DEL_PRODUCTO_aqui As String = 0

    Dim cambiando_CANTIDAD As String = ""

    Public dt_prods_venta As New DataTable

    Public da_contact_fitro_ce As New MySqlDataAdapter
    Public dT_contact_fitro_ce As New DataTable
    Dim agregando_cli As String
    Dim cli_nom, cli_tel, cli_tel2, cli_dir, cli_doc, cli_mail, cli_puntos As String


    Dim PARA_COCINAR As String = ""
    Dim PARA_PARRILLA As String = ""
    Dim PARA_BAR As String = ""

    Public DT_INV_KIT As DataTable
    Public da_INV_KIT As MySqlDataAdapter

    Public DT_KIT As DataTable
    Public da_KIT As MySqlDataAdapter






    Private Sub FlowLayout_MULTIPANEL_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayout_MULTIPANEL.Paint

    End Sub

    Private Sub Panel_foot_Paint(sender As Object, e As PaintEventArgs) Handles Panel_foot.Paint

    End Sub




    '---------- load_shown_closing
    Private Sub Form_sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label_FECHA.Text = DateTime.Now.ToShortDateString
        Label1.Text = comex_rotulovendedor
        VENTAS_DOMICILIO = ""

        Panel_derecha.BringToFront()

        If comex_fondo = "CLARO" Then
            Me.BackColor = Color.FromArgb(224, 224, 224) '0, 84, 144

        End If
        If comex_fondo = "NEGRO" Then
            Me.BackColor = Color.Black
        End If

        If comex_fondo = "AZUL" Then
            Me.BackColor = Color.FromArgb(8, 44, 71) '0, 84, 144
            Panel_derecha.BackColor = Color.FromArgb(21, 63, 103) 'azul claro
            Panel_izquierda.BackColor = Color.FromArgb(21, 63, 103) 'azul claro


            FlowLayout_MULTIPANEL.BackColor = Color.FromArgb(8, 44, 71)
            Label_lcd.BackColor = Color.FromArgb(8, 44, 71)

            Panel5.BackColor = Color.FromArgb(21, 63, 103)
            TextBox_buscarcliente.BackColor = Color.FromArgb(21, 63, 103)



            Label_cliente.BackColor = Color.FromArgb(35, 81, 130)
            Panel_cliente.BackColor = Color.FromArgb(79, 125, 174)

        End If
    End Sub
    Private Sub Form_sales_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        'FACTURAR A MESAS
        If PERMISO__general(8) = "SI" Then
            Label4.Visible = True
            Label_mesa.Visible = True
            PictureBox_mesas.Visible = True
            LabeL_ZONA.Visible = True
        Else
            Label4.Visible = False
            Label_mesa.Visible = False
            PictureBox_mesas.Visible = False
            LabeL_ZONA.Visible = False
        End If

        'asignar ventas mesero
        If PERMISO__general(1) = "SI" Then
            Label1.Visible = True
            PictureBox_back_mesero.Visible = True
            ComboBox_mesero.Visible = True
        Else
            Label1.Visible = False
            PictureBox_back_mesero.Visible = False
            ComboBox_mesero.Visible = False
        End If


        'cocina
        If PERMISO__general(10) = "SI" Then

        Else

        End If


        If comex_propina <> "" Then
            Me.TextBox_propina.Visible = True
            Me.Label_propina.Visible = True
        Else
            Me.TextBox_propina.Visible = False
            Me.Label_propina.Visible = False
        End If


        'If PERMISO__general(11).ToString = "SI" Then
        '    Checkbox_MOSTRAR_LOTES.Checked = True
        'Else
        '    Checkbox_MOSTRAR_LOTES.Checked = False
        'End If


        If PERMISO__general(14).ToString = "SI" Then
            BunifuCheckbox_propina.Checked = True
        Else
            BunifuCheckbox_propina.Checked = False

        End If


        fill_zones()

        fill_bartenders()

        'Fill_ProdsSale("")
        Button1.BringToFront()

    End Sub

    Private Sub Form_sales_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Label_estado.Text = "** Nueva Cuenta **" Then
            Me.Cursor = Cursors.WaitCursor
            sql = "delete from ventas_pre where DOCUMENTO=" & CInt(Me.Label_consecutivo.Text) & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                MsgBox("error .")
                Exit Sub
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()

            sql = "delete from ventas_prods_Temp where documento=" & CInt(Me.Label_consecutivo.Text) & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                MsgBox("error al Borrar el Registro Invima.")
                Exit Sub
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()
            'Form_Main.Timer_cocina_flash.Enabled = True


            sql = "delete from ventas_dctos_Temp where documento=" & CInt(Me.Label_consecutivo.Text) & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                MsgBox("error al Borrar el Registro Invima.")
                Exit Sub
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()


            Me.Cursor = Cursors.WaitCursor
        End If
        fact_saveok = 0
    End Sub
    '---------- load_shown_closing




    ' nueva Y anular cuenta
    Private Sub Button_nueva_cuenta_Click(sender As Object, e As EventArgs) Handles Button_nueva_cuenta.Click

        ' SI TIENE UNA NUEVA CUENTA Y NO SE HA GUARDADO Y NO HA AGREGADO PRODUCTOS SE SALE
        If Label_estado.Text.ToUpper = "CUENTA PENDIENTE" And dataGrid_detalleprodsVENTA.Rows.Count = 0 Then
            Label_lcd.Text = "Tiene una cuenta activa sin items, utilice la cuenta actual antes de crear una nueva."
            Timer_LcdOff.Enabled = True
            Exit Sub
        End If


        Label_FECHA.Text = DateTime.Now.ToShortDateString
        Label_hr.Text = DateTime.Now.ToLongTimeString
        Label_mesa.Text = ""
        TextBox_TOTAL_pagar.Text = "0"

        'guardar PRE VENTA   NUEVA **********

        'CONSECUTIVO
        consecutivo = 0
        cmd.Connection = conex
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select max(documento) + 1 from VENTAS_PRE"
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

        If turno_actualfecha = "" Then DateTime.Now.ToShortDateString()
        'NUEVA****************
        sql = "INSERT INTO VENTAS_PRE (documento, tipoDocumento, doccliente, clientenom, fecha, empleadoCod, empleado, turno, Estado, totalventa, descuento, baseimpuesto,impuesto,impuesto2,total,HORA)" &
              "VALUES (" & CLng(consecutivo) & ",'VENTAS','" & CStr(ComboBox_mesero.SelectedValue) & "','" & CStr(ComboBox_mesero.Text) & "','" & turno_actualfecha & "','',''," & CInt(turno_actual_global_ID) & ",'PENDIENTE','0','0','0','0','0','0','" & Label_hr.Text & "')"
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
        fact_saveok = 0
        Me.Label_consecutivo.Text = consecutivo
        Me.Label_consecutivo.BackColor = Color.Tomato : Label_consecutivo.ForeColor = Color.White
        Label_mesa.BackColor = Color.Tomato : Label_mesa.ForeColor = Color.White
        Label_estado.BackColor = Color.Tomato : Label_estado.ForeColor = Color.AntiqueWhite

        CLEAN_FLOW()
        dataGrid_detalleprodsVENTA.ClearSelection()

        dataGrid_detalleprodsVENTA.DataSource = Nothing
        PictureBox_opcion_cliente_Click(Nothing, Nothing)
        PictureBox_back_mesero_Click(Nothing, Nothing)
        Label_estado.Text = "** Nueva Cuenta **"

        Button_nueva_cuenta.Visible = False

        Button_anular_cuenta.Enabled = True

        Textbox_buscar_prod.Focus()




        Label_estado.Text = "Cuenta Pendiente" : Label_estado.BackColor = Color.Tomato : Label_estado.ForeColor = Color.White
        Label_mesa.BackColor = Color.Tomato : Label_mesa.ForeColor = Color.White
        Label_consecutivo.BackColor = Color.Tomato : Label_consecutivo.ForeColor = Color.White
        Button_nueva_cuenta.Visible = True

        Textbox_Cliente_Doc.Text = ""
        Label_DV.Text = ""
        Textbox_Cliente_Nom.Text = ""
        Textbox_Cliente_Email.Text = ""
        Textbox_Cliente_Tel1.Text = ""
        Textbox_Cliente_Tel2.Text = ""
        Textbox_Cliente_Dir.Text = ""

        TextBox_buscarcliente.Text = ""
        Label_cliente.Text = ""

    End Sub

    Private Sub Button_anular_cuenta_Click(sender As Object, e As EventArgs) Handles Button_anular_cuenta.Click
        If Label_consecutivo.Text = "" Then
            Exit Sub
        End If

        If Label_estado.Text = "Cuenta Pendiente" Then
            'PREGUNTAR
            Dim RTA = MsgBox("Desea anular la cuenta? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo)

            If RTA = 6 Then
                Me.Cursor = Cursors.WaitCursor
                sql = "delete from ventas_pre where DOCUMENTO=" & CInt(Me.Label_consecutivo.Text) & ""
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                Try
                    da.Fill(dt)
                Catch ex As Exception
                    MsgBox("error .")
                    Exit Sub
                End Try
                da.Dispose()
                dt.Dispose()
                conex.Close()

                sql = "delete from ventas_prods_Temp where documento=" & CInt(Me.Label_consecutivo.Text) & ""
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                Try
                    da.Fill(dt)
                Catch ex As Exception
                    MsgBox("error al Borrar el Registro .")
                    Exit Sub
                End Try
                da.Dispose()
                dt.Dispose()
                conex.Close()


                sql = "delete from ventas_dctos_Temp where documento=" & CInt(Me.Label_consecutivo.Text) & ""
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                Try
                    da.Fill(dt)
                Catch ex As Exception
                    MsgBox("error al Borrar el Registro Invima.")
                    Exit Sub
                End Try
                da.Dispose()
                dt.Dispose()
                conex.Close()

                Label_consecutivo.Text = "" : Label_consecutivo.BackColor = Color.PaleGreen : Label_consecutivo.ForeColor = Color.Black
                Label_mesa.Text = "" : Label_mesa.BackColor = Color.PaleGreen : Label_mesa.ForeColor = Color.Black
                Label_estado.Text = "Caja Disponible" : Label_estado.BackColor = Color.PaleGreen : Label_estado.ForeColor = Color.Black

                ComboBox_mesero.Text = ""
                dataGrid_detalleprodsVENTA.DataSource = Nothing

                Me.Cursor = Cursors.Default

                Button_nueva_cuenta.Visible = True

                Button_anular_cuenta.Enabled = False

                Label_hr.Text = ""

                CLEAN_FLOW()
                TextBox_TOTAL_pagar.Text = 0

                Textbox_Cliente_Doc.Text = ""
                Label_DV.Text = ""
                Textbox_Cliente_Nom.Text = ""
                Textbox_Cliente_Email.Text = ""
                Textbox_Cliente_Tel1.Text = ""
                Textbox_Cliente_Tel2.Text = ""
                Textbox_Cliente_Dir.Text = ""

                TextBox_buscarcliente.Text = ""
                Label_cliente.Text = ""
            Else
                Button_nueva_cuenta.Visible = True

                Button_anular_cuenta.Enabled = False

                Exit Sub
            End If

        End If




    End Sub
    ' nueva anular cuenta





    ' CONTROLES ADD ETC
    Private Sub Button_mas_Click(sender As Object, e As EventArgs) Handles Button_mas.Click
        TextBox_cant.Text = CLng(TextBox_cant.Text) + 1

    End Sub
    Private Sub Button_menos_Click(sender As Object, e As EventArgs) Handles Button_menos.Click
        TextBox_cant.Text = CLng(TextBox_cant.Text) - 1

    End Sub
    Private Sub PictureBox_OK_Click(sender As Object, e As EventArgs) Handles PictureBox_OK.Click


        If Label_estado.Text = "Caja Disponible" Then
            Exit Sub
        End If

        If Label_consecutivo.Text = "" Then
            Exit Sub
        End If




        If cambiando_CANTIDAD = "SI" Then
            CAMBIAR_CANTIDAD()

            PictureBox_OK.Visible = False
            Button_mas.Visible = False
            Button_menos.Visible = False
            TextBox_cant.Visible = False
            TextBox_cant.Text = "1"
            cambiando_CANTIDAD = ""

            Exit Sub
        End If



        If prod_cod = "" Then Exit Sub
        If prod_valor = "" Then Exit Sub

        If PROD_INVENTARIADO = "SI" Then
            Try
                BUSCA_SALDO_PRODUCTO_aqui()
                BUSCA_SALDO_PRODUCTO()

                If SALDO_DEL_PRODUCTO < TextBox_cant.Text And PERMISO__general(3) = "NO" Then

                    Me.Textbox_buscar_prod.Text = ""
                    Me.Textbox_buscar_prod.Focus()
                    Me.Label_lcd.Text = "No están permitidas la ventas sin existencias. EL Inventario no registra existencias de este producto, por favor revise la cantidad."

                    agregando = "NO"
                    TextBox_cant.Text = 1
                    'Textbox_buscar_prod.Focus()
                    Exit Sub
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try



        End If

        agregando = "SI"

        Button_mas.Visible = False
        Button_menos.Visible = False
        PictureBox_OK.Visible = False
        TextBox_cant.Visible = False

        Try
            agregar_1_prod()

            Me.Textbox_buscar_prod.Text = ""
            Label_lcd.Text = ""

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        PANEL_prods_result.Visible = False
        Fill_ProdsSale(Label_consecutivo.Text)
        FlowLayout_MULTIPANEL.Visible = True
        TextBox_cant.Text = 1
        Label_lcd.Text = ""
        agregando = "NO"
        dataGrid_detalleprodsVENTA.ClearSelection()

        TextBox_cant.Visible = True
        Numeric_cant.Value = False

        Textbox_buscar_prod.Focus()

    End Sub
    Private Sub PictureBox_back_Click(sender As Object, e As EventArgs) Handles PictureBox_back.Click
        Grid_PRODS_RESULT.DataSource = Nothing
        PANEL_prods_result.Visible = False
        FlowLayout_MULTIPANEL.Visible = True

        CLEAN_FLOW()

        FlowLayout_MULTIPANEL.Refresh()
        Label_lcd.Text = "Seleccione una Opción"
        Textbox_buscar_prod.Text = ""

        estado_unir_mesa = False


        Button_mas.Visible = False
        Button_menos.Visible = False
        PictureBox_OK.Visible = False
        TextBox_cant.Visible = False

        dataGrid_detalleprodsVENTA.ClearSelection()

        button_Quitar_Prod.Enabled = False
        Button_modificarprecio.Enabled = False
        Button_modificar_cant.Enabled = False

        'Textbox_Cliente_Doc.Text = ""
        'Label_DV.Text = ""
        'Textbox_Cliente_Nom.Text = ""
        'Textbox_Cliente_Email.Text = ""
        'Textbox_Cliente_Tel1.Text = ""
        'Textbox_Cliente_Tel2.Text = ""
        'Textbox_Cliente_Dir.Text = ""

        'TextBox_buscarcliente.Text = ""
        'Label_cliente.Text = ""
    End Sub
    Private Sub PictureBox_back_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox_back.DoubleClick
        CLEAN_FLOW()
        clean_txt_cliente()
        Label_cliente.Text = ""

        If FlowLayout_MULTIPANEL.Controls.Count = 0 Then
            Label_consecutivo.Text = "" : Label_consecutivo.BackColor = Color.PaleGreen
            Label_mesa.Text = "" : Label_mesa.BackColor = Color.PaleGreen
            Label_estado.Text = "Caja Disponible" : Label_estado.BackColor = Color.PaleGreen : Label_estado.ForeColor = Color.Black
            Label_hr.Text = ""

            dataGrid_detalleprodsVENTA.DataSource = Nothing

            Button_nueva_cuenta.Visible = True : Button_nueva_cuenta.Enabled = True
            Button_anular_cuenta.Enabled = False
            TextBox_TOTAL_pagar.Text = 0
        End If
    End Sub
    'CONTROLES ADD ETC



    ' <---------- BUSCAR CLIENTE >
    Private Sub datagrid_clientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_clientes.CellContentClick

    End Sub

    Private Sub TextBox_buscarcliente_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_buscarcliente.KeyDown
        If e.KeyCode = Keys.Down Then
            TextBox_buscarcliente.Text = ""
            datagrid_clientes.Visible = True : dataGrid_detalleprodsVENTA.Visible = False
            datagrid_clientes.Focus()
            PictureBox_opcion_cliente.Image = My.Resources.oktrans : PictureBox_opcion_cliente.Visible = True

        End If


        If e.KeyCode = "13" Then

            If TextBox_buscarcliente.Text = "" Then
                'Label_info_cliente.Text = "debe escribir Documento o Nombre para buscar."
                Exit Sub
            End If

            Try
                If IsNumeric(TextBox_buscarcliente.Text) = True Then sql = "SELECT cons, concat(documento,'-',nombre) as fullname, nombre, documento, direccion, telefono, telefono2, telefono3, email, puntos  FROM proveedores WHERE documento like '%" & TextBox_buscarcliente.Text & "%' order by nombre"
                If IsNumeric(TextBox_buscarcliente.Text) = False = True Then sql = "SELECT cons, concat(documento,'-',nombre) as fullname, nombre, documento, direccion, telefono, telefono2, telefono3, email, puntos FROM proveedores WHERE nombre like '%" & TextBox_buscarcliente.Text & "%' order by nombre"

                da_contact_fitro_ce = New MySqlDataAdapter(sql, conex)
                dT_contact_fitro_ce = New DataTable
                da_contact_fitro_ce.Fill(dT_contact_fitro_ce)
                If dT_contact_fitro_ce.Rows.Count = 0 Then
                    ' si no encontro productos

                    Exit Sub
                End If
                PictureBox_opcion_cliente.Image = My.Resources.oktrans : PictureBox_opcion_cliente.Visible = True
                Me.datagrid_clientes.DataSource = dT_contact_fitro_ce
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da_contact_fitro_ce.Dispose()
            dT_contact_fitro_ce.Dispose()
            conex.Close()
            datagrid_clientes.Columns(0).Visible = False
            datagrid_clientes.Columns(2).Visible = False
            datagrid_clientes.Columns(3).Visible = False
            datagrid_clientes.Columns(4).Visible = False
            datagrid_clientes.Columns(5).Visible = False
            datagrid_clientes.Columns(6).Visible = False
            datagrid_clientes.Columns(7).Visible = False
            datagrid_clientes.Columns(8).Visible = False
            datagrid_clientes.Columns(9).Visible = False

            Me.datagrid_clientes.BringToFront()
            Me.datagrid_clientes.Visible = True
            datagrid_clientes.ClearSelection()

            'datagrid_prodlist.Focus()

        End If

        Cursor.Current = Cursors.Default
    End Sub

    Private Sub TextBox_buscarcliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_buscarcliente.KeyPress
        If Label_consecutivo.Text = "" Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub PictureBox_opcion_cliente_Click(sender As Object, e As EventArgs) Handles PictureBox_opcion_cliente.Click


        If Label_cliente.Text <> "" Then
            Label_cliente.Text = ""
            TextBox_buscarcliente.Text = ""
            TextBox_buscarcliente.Focus()
            PictureBox_opcion_cliente.Visible = False
            cli_doc = "" : cli_nom = "" : cli_tel = "" : cli_mail = "" : cli_dir = ""
            datagrid_clientes.Visible = False : dataGrid_detalleprodsVENTA.Visible = True

            Exit Sub
        End If

        If Label_cliente.Text = "" Then

            If cli_doc <> "" Then
                TextBox_buscarcliente.Text = ""
                Label_cliente.Text = cli_doc & vbNewLine & cli_nom
                datagrid_clientes.DataSource = Nothing
                datagrid_clientes.Visible = False : dataGrid_detalleprodsVENTA.Visible = True
                PictureBox_opcion_cliente.Visible = True : PictureBox_opcion_cliente.Image = My.Resources.Backspace2
            End If

        End If

    End Sub

    Private Sub TextBox_buscarcliente_OnValueChanged(sender As Object, e As EventArgs) Handles TextBox_buscarcliente.OnValueChanged

    End Sub

    Private Sub TextBox_buscarcliente_DoubleClick(sender As Object, e As EventArgs) Handles TextBox_buscarcliente.DoubleClick

    End Sub

    Private Sub datagrid_clientes_KeyDown(sender As Object, e As KeyEventArgs) Handles datagrid_clientes.KeyDown
        If e.KeyCode = Keys.Enter Then
            agregando_cli = "SI"
            clean_txt_cliente()

            Dim row_prod As DataGridViewRow = datagrid_clientes.CurrentRow
            cli_nom = row_prod.Cells("nombre").Value
            cli_doc = row_prod.Cells("documento").Value
            cli_dir = row_prod.Cells("direccion").Value
            cli_tel = row_prod.Cells("telefono").Value
            cli_tel2 = row_prod.Cells("telefono2").Value
            cli_mail = row_prod.Cells("email").Value
            cli_puntos = row_prod.Cells("puntos").Value

            Label_cliente.Text = row_prod.Cells("documento").Value & vbNewLine & row_prod.Cells("nombre").Value
            datagrid_clientes.DataSource = Nothing
            datagrid_clientes.Visible = False : dataGrid_detalleprodsVENTA.Visible = True
            PictureBox_opcion_cliente.Visible = True : PictureBox_opcion_cliente.Image = My.Resources.Backspace2

            Textbox_Cliente_Nom.Text = cli_nom
            Textbox_Cliente_Doc.Text = cli_doc
            Textbox_Cliente_Dir.Text = cli_dir
            Textbox_Cliente_Tel1.Text = cli_tel
            Textbox_Cliente_Tel2.Text = cli_tel2
            Textbox_Cliente_Email.Text = cli_mail
            Label_puntos_cliente.Text = cli_puntos

            sql = "update VENTAS_pre set doccliente='" & cli_doc & "', clientenom='" & cli_nom & "' where documento='" & Label_consecutivo.Text & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
                Me.Label_lcd.Text = "Se asignó cliente."
                'MsgBox("Se Borró el producto.")
            Catch ex As Exception
                MsgBox("Error al Borrar el Registro." & ex.ToString)
                Exit Sub
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()

        End If

        If e.KeyCode = Keys.Escape Then
            PictureBox_opcion_cliente.Visible = False
            datagrid_clientes.DataSource = Nothing
            TextBox_buscarcliente.Text = ""
            Label_cliente.Text = ""
            Label_cliente.Focus()
        End If
    End Sub

    Private Sub datagrid_clientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_clientes.CellClick
        Dim row_prod As DataGridViewRow = datagrid_clientes.CurrentRow
        cli_nom = row_prod.Cells("nombre").Value
        cli_doc = row_prod.Cells("documento").Value
        cli_dir = row_prod.Cells("direccion").Value
        cli_tel = row_prod.Cells("telefono").Value
        cli_tel2 = row_prod.Cells("telefono2").Value
        cli_mail = row_prod.Cells("email").Value
        cli_puntos = row_prod.Cells("puntos").Value

    End Sub

    Private Sub datagrid_clientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_clientes.CellDoubleClick
        Dim row_prod As DataGridViewRow = datagrid_clientes.CurrentRow
        clean_txt_cliente()

        cli_nom = row_prod.Cells("nombre").Value
        cli_doc = row_prod.Cells("documento").Value
        cli_dir = row_prod.Cells("direccion").Value
        cli_tel = row_prod.Cells("telefono").Value
        cli_tel2 = row_prod.Cells("telefono2").Value
        cli_mail = row_prod.Cells("email").Value
        cli_puntos = row_prod.Cells("puntos").Value

        Textbox_Cliente_Nom.Text = cli_nom
        Textbox_Cliente_Doc.Text = cli_doc
        Textbox_Cliente_Dir.Text = cli_dir
        Textbox_Cliente_Tel1.Text = cli_tel
        Textbox_Cliente_Tel2.Text = cli_tel2
        Textbox_Cliente_Email.Text = cli_mail
        Label_puntos_cliente.Text = cli_puntos

        PictureBox_opcion_cliente_Click(Nothing, Nothing)


        sql = "update VENTAS_pre set doccliente='" & cli_doc & "', clientenom='" & cli_nom & "' where documento='" & Label_consecutivo.Text & "'"
        da = New MySqlDataAdapter(sql, conex)
        dt = New DataTable
        Try
            da.Fill(dt)
            Me.Label_lcd.Text = "Se asignó cliente."
            'MsgBox("Se Borró el producto.")
        Catch ex As Exception
            MsgBox("Error al Borrar el Registro." & ex.ToString)
            Exit Sub
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()






    End Sub

    Private Sub PictureBox_Cliente_opciones_Click(sender As Object, e As EventArgs) Handles PictureBox_Cliente_opciones.Click

        If Label_consecutivo.Text = "" Then Exit Sub


        If Label_cliente.Text = "" Then
            Label2.Text = "Registrar Cliente"
            Button_guardar_Cliente.Text = "Guardar"
        End If

        If Label_cliente.Text <> "" Then
            Label2.Text = "Cliente"
            Button_guardar_Cliente.Text = "Actualizar"
        End If


        Panel_cliente.Visible = True

        dataGrid_detalleprodsVENTA.Visible = False
        datagrid_clientes.Visible = False

        Textbox_Cliente_Doc.HintText = "Documento"

        Textbox_Cliente_Doc.Focus()

        ComboBox_tipoDoc.SelectedItem = "CC"
    End Sub

    Private Sub Button_cancela_guardar_cliente_Click(sender As Object, e As EventArgs) Handles Button_cancela_guardar_cliente.Click
        Panel_cliente.Visible = False
        datagrid_clientes.Visible = True

        dataGrid_detalleprodsVENTA.Visible = True
    End Sub

    Private Sub Button_guardar_Cliente_Click(sender As Object, e As EventArgs) Handles Button_guardar_Cliente.Click

        If Textbox_Cliente_Doc.Text = "" Then Exit Sub
        If Textbox_Cliente_Nom.Text = "" Then Exit Sub


        If Button_guardar_Cliente.Text = "Guardar" Then
            sql = "INSERT INTO proveedores(documento, dv, TIPODOCUMENTO, nombre, telefono, telefono2, direccion, cliente)" &
                      "VALUES ('" & Textbox_Cliente_Doc.Text & "','" & Label_DV.Text & "','" & CStr(ComboBox_tipoDoc.Text) & "','" & CStr(Me.Textbox_Cliente_Nom.Text) & "','" & CStr(Me.Textbox_Cliente_Tel1.Text) & "','" & CStr(Me.Textbox_Cliente_Tel2.Text) & "','" & CStr(Me.Textbox_Cliente_Dir.Text) & "','SI')"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                If ex.ToString.Contains("Duplicate") Then MsgBox("Ese documento ya esta registrado en la lista de clientes.", vbExclamation)
                If ex.ToString.Contains("Duplicata") Then MsgBox("Ese documento ya esta registrado en la lista de clientes.", vbExclamation)

                'MsgBox(ex.ToString)
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()
            Label_lcd.Text = "Se Guardó el Cliente."
        End If
        If Button_guardar_Cliente.Text = "Actualizar" Then
            sql = "UPDATE PROVEEDORES SET documento='" & Textbox_Cliente_Doc.Text & "', dv='" & Label_DV.Text & "', TIPODOCUMENTO='" & CStr(ComboBox_tipoDoc.Text) & "', nombre='" & CStr(Me.Textbox_Cliente_Nom.Text) & "', telefono='" & CStr(Me.Textbox_Cliente_Tel1.Text) & "', telefono2='" & CStr(Me.Textbox_Cliente_Tel2.Text) & "', direccion='" & CStr(Me.Textbox_Cliente_Dir.Text) & "', cliente='SI' where documento='" & cli_doc & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                If ex.ToString.Contains("Duplicate") Then MsgBox("Ese documento ya esta registrado en la lista de clientes.", vbExclamation)
                If ex.ToString.Contains("Duplicata") Then MsgBox("Ese documento ya esta registrado en la lista de clientes.", vbExclamation)

                'MsgBox(ex.ToString)
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()
            Label_lcd.Text = "Se actualizó la información del Cliente."
        End If
        Label_cliente.Text = Textbox_Cliente_Doc.Text & vbNewLine & Textbox_Cliente_Nom.Text


        Button_cancela_guardar_cliente_Click(Nothing, Nothing)
        PictureBox_opcion_cliente.Visible = True : PictureBox_opcion_cliente.Image = My.Resources.Backspace2

    End Sub

    Private Sub Textbox_Cliente_Doc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Textbox_Cliente_Doc.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""

    End Sub

    Private Sub Textbox_Cliente_Tel1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Textbox_Cliente_Tel1.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""

    End Sub

    Private Sub Textbox_Cliente_Tel2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Textbox_Cliente_Tel2.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""

    End Sub

    Private Sub Textbox_Cliente_Doc_OnValueChanged(sender As Object, e As EventArgs) Handles Textbox_Cliente_Doc.OnValueChanged
        If Textbox_Cliente_Doc.Text = "" Then
            Textbox_Cliente_Doc.Text = ""
            Label_DV.Text = "0"
            Exit Sub
        End If

        If Textbox_Cliente_Doc.Text <> "" Then

            Dim NIT As String = Textbox_Cliente_Doc.Text
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
            Label_DV.Text = RESIDUO

            If RESIDUO > 1 Then
                Label_DV.Text = Convert.ToString(11 - RESIDUO)
            End If
        End If
    End Sub
    ' <--------- BUSCAR CLIENTE >



    ' cambiar precio -----------------------------------
    Private Sub Button_modificarprecio_Click(sender As Object, e As EventArgs) Handles Button_modificarprecio.Click
        ' CAMBIAR PRECIOS
        If PERMISO_1(29) = "NO" Or PERMISO_1(29) = Nothing Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub



        RadioButton_precio1.Checked = False
        RadioButton_precio2.Checked = False
        RadioButton_precio3.Checked = False
        RadioButton_otroprecio.Checked = False


        Panel_preciocambiar.Visible = True
        Panel_preciocambiar.Width = 483
        Centrar(Panel_preciocambiar)

        PANEL_prods_result.Visible = True

        Grid_PRODS_RESULT.Visible = False

        TextBox_precio1.Text = "0"
        TextBox_precio2.Text = "0"
        TextBox_precio3.Text = "0"
        TextBox_precio3.Text = "0"

        Try
            sql = "SELECT VALOR, VALOR2, VALOR3, costo FROM productos where productos.COD='" & prod_cod_sel & "' AND productos.ESTADO='ACTIVO'"

            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                TextBox_precio1.Text = row.Item("valor")
                TextBox_precio2.Text = row.Item("valor2")
                TextBox_precio3.Text = row.Item("valor3")
                TextBox_otroprecio.Text = row.Item("costo")
            Next
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()


        ' modificar EL PRECIO
        If PERMISO_1(33) = "NO" Or PERMISO_1(33) = Nothing Then
            RadioButton_otroprecio.Enabled = True
            Panel_otroprecio.Enabled = True
            TextBox_otroprecio.Enabled = True

        Else
            RadioButton_otroprecio.Enabled = False
            Panel_otroprecio.Enabled = False
            TextBox_otroprecio.Enabled = False
        End If


        TextBox_precio1.Focus()

        Exit Sub
    End Sub
    Private Sub DataGrid_kit_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid_kit.CellContentClick

    End Sub
    Private Sub Button_cancelar_cambiarprecio_Click(sender As Object, e As EventArgs) Handles Button_cancelar_cambiarprecio.Click
        Panel_preciocambiar.Visible = False
        Grid_PRODS_RESULT.Visible = True
        PANEL_prods_result.Visible = False

    End Sub
    Private Sub Button_guardar_cambiarprecio_Click(sender As Object, e As EventArgs) Handles Button_guardar_cambiarprecio.Click
        If TextBox_precio1.Text = "" Then
            TextBox_precio1.Text = "0"
        End If
        If TextBox_precio2.Text = "" Then
            TextBox_precio2.Text = "0"
        End If
        If TextBox_precio3.Text = "" Then
            TextBox_precio3.Text = "0"
        End If
        If TextBox_otroprecio.Text = "" Then
            TextBox_otroprecio.Text = "0"
        End If



        If Me.RadioButton_precio1.Checked = True Then
            If TextBox_precio1.Text = 0 Then Exit Sub
            nuevo_precio = TextBox_precio1.Text

        End If


        If Me.RadioButton_precio2.Checked = True Then
            If TextBox_precio2.Text = 0 Then Exit Sub
            nuevo_precio = TextBox_precio2.Text

        End If

        If Me.RadioButton_precio3.Checked = True Then
            If TextBox_precio3.Text = 0 Then Exit Sub
            nuevo_precio = TextBox_precio3.Text

        End If

        If Me.RadioButton_otroprecio.Checked = True Then
            If TextBox_otroprecio.Text = 0 Then Exit Sub
            nuevo_precio = TextBox_otroprecio.Text

        End If

        If RadioButton_precio1.Checked = False And RadioButton_precio2.Checked = False And RadioButton_precio3.Checked = False And RadioButton_otroprecio.Checked = False Then
            Exit Sub
        End If



        CONSULTAR_PRODUCTO("CODIGO", prod_cod_sel)

        prod_valor = nuevo_precio  'actualizo la variable q calcula base imp y demas

        PROD_VALOR_UNITARIO_BASE = 0
        PROD_VALOR_UNITARIO_BASE = prod_valor

        PROD_CANT = prod_CANT_sel

        If prod_decimal = "SI" Then
            PROD_VALOR_UNITARIO_BASE = Math.Round((CDec(PROD_VALOR_UNITARIO_BASE)), 3)
            PROD_VALOR_UNITARIO_total = Math.Round((CDec(PROD_VALOR_UNITARIO_BASE) * CDec(PROD_CANT)), 3)
        Else
            PROD_VALOR_UNITARIO_BASE = Math.Round((CInt(PROD_VALOR_UNITARIO_BASE)), 0)
            PROD_VALOR_UNITARIO_total = Math.Round((CInt(PROD_VALOR_UNITARIO_BASE) * CInt(PROD_CANT)), 0)
        End If

        If prod_iva2nom <> "NO" Then  'CALCULAMOS EL IVA
            PROD_VALOR_UNITARIO_BASE = CInt(PROD_VALOR_UNITARIO_BASE / ((CInt(prod_iva2) / 100) + 1))
            PROD_IVA_VR2 = CInt(prod_valor) - CInt(PROD_VALOR_UNITARIO_BASE)
        End If


        If prod_iva1nom <> "NO" Then  ' calculamos ico
            PROD_VALOR_UNITARIO_BASE = CInt(PROD_VALOR_UNITARIO_BASE) - CInt(prod_iva)
            PROD_IVA_VR = prod_iva
        End If

        If prod_iva2nom = "NO" Then 'CALCULAMOS EL IVA
            PROD_IVA_VR2 = 0
            prod_iva2 = 0
        End If

        If prod_iva1nom = "NO" Then  ' calculamos ico
            PROD_IVA_VR = 0
            prod_iva = 0
        End If




        sql = "update VENTAS_PRODS_TEMP set CANTIDAD='" & PROD_CANT & "', base='" & CInt(PROD_VALOR_UNITARIO_BASE) & "', imp='" & CInt(prod_iva) & "', imp2='" & CInt(PROD_IVA_VR2) & "', impuesto='" & CInt(PROD_IVA_VR) * PROD_CANT & "', impuesto2='" & CInt(PROD_IVA_VR2) * PROD_CANT & "', valorU='" & prod_valor & "', valortotal='" & PROD_VALOR_UNITARIO_total & "' where cons=" & CInt(prod_cons_Sel) & ""
        da = New MySqlDataAdapter(sql, conex)
        dt = New DataTable
        Try
            da.Fill(dt)
            Me.Label_lcd.Text = "Se modificó la cantidad de el producto."
            'MsgBox("Se Borró el producto.")
        Catch ex As Exception
            MsgBox("Error al Borrar el Registro." & ex.ToString)
            Exit Sub
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()

        prod_cod = ""
        prod_nom = ""
        prod_cons = ""

        Fill_ProdsSale(Label_consecutivo.Text)

        Me.Button_modificarprecio.Enabled = False
        Me.Button_modificar_cant.Enabled = False
        Me.button_Quitar_Prod.Enabled = False

        nuevo_precio = "0"

        Me.Panel_preciocambiar.Visible = False : Me.dataGrid_detalleprodsVENTA.Visible = True : Panel_preciocambiar.Width = 20 : Exit Sub


        If comex_buscarpor = "Codigo" Then RadioButton_codProd.Checked = True
        If comex_buscarpor = "Codigo de Barras" Then RadioButton_barras.Checked = True
        If comex_buscarpor = "Nombre" Then RadioButton_Nombre.Checked = True

        PANEL_prods_result.Visible = False
        FlowLayout_MULTIPANEL.Visible = True
        Grid_PRODS_RESULT.Visible = True


        dataGrid_detalleprodsVENTA.ClearSelection()

    End Sub

    Private Sub ComboBox_Cuentas_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_Cuentas.SelectionChangeCommitted
        'Try
        '    sql = "SELECT * FROM medios_pago
        'inner join cajasybancos on medios_pago.codcuenta=cajasybancos.cons
        ' WHERE medios_pago.CONS='" & Me.ListBox1.SelectedValue.ToString & "'"
        '    da = New MySqlDataAdapter(sql, conex)
        '    dt = New DataTable
        '    da.Fill(dt)
        '    For Each row As DataRow In dt.Rows
        '        MEDIO_PAGO_DESTINO_COD = row.Item("CUENTApuc")
        '        MEDIO_PAGO_DESTINO_NOMBRE = row.Item("MEDIOPAGO")
        '        MEDIO_PAGO_DESTINO_TIPO = row.Item("TIPO")
        '        medio_de_pago = MEDIO_PAGO_DESTINO_NOMBRE
        '    Next
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'conex.Close()
        'da.Dispose()
        'dt.Dispose()

        'If MEDIO_PAGO_DESTINO_NOMBRE = Nothing Then
        '    Exit Sub
        'End If


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        Try
            sql = "SELECT cons, nombre FROM cajasybancos
where tipo='" & Me.ListBox1.SelectedValue.ToString & "' order by cons"
            da_CtaPagar = New MySqlDataAdapter(sql, conex)
            dt_CtaPagar = New DataTable
            da_CtaPagar.Fill(dt_CtaPagar)
            Me.ComboBox_Cuentas.DataSource = dt_CtaPagar.DefaultView
            Me.ComboBox_Cuentas.DisplayMember = "nombre"
            Me.ComboBox_Cuentas.ValueMember = "cons"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_CtaPagar.Dispose()
        dt_CtaPagar.Dispose()
        conex.Close()
        My.Application.DoEvents()





        MEDIO_PAGO_DESTINO_NOMBRE = ListBox1.Text

        If MEDIO_PAGO_DESTINO_NOMBRE.ToUpper = "EFECTIVO" Then
            Me.TextBox_efectivo.Text = Me.TextBox_TOTAL_pagar.Text
            fecha_de_pago = ""
            medio_de_pago = "EFECTIVO"

            Me.Panel_COMPROBANTE.Visible = False

            Me.TextBox_comprobante.Enabled = False : Me.TextBox_comprobante.Text = ""

            Me.TextBox_efectivo.Enabled = True : TextBox_efectivo.Text = TextBox_TOTAL_pagar.Text
            Me.TextBox_efectivo.Focus()
            Me.TextBox_efectivo.SelectAll()
        End If

        If MEDIO_PAGO_DESTINO_NOMBRE.ToString.Contains("CREDITO") Then
            fecha_de_pago = ""
            medio_de_pago = "CREDITO"
            Me.TextBox_efectivo.Text = "0"
            Label_cambio_VR.Text = "0"

            Me.TextBox_comprobante.Enabled = False : Me.TextBox_comprobante.Text = ""
            'Me.Label_CREDITO_VR.Text = Me.Label5.Text
            Me.TextBox_efectivo.Enabled = False
            'Me.TextBox3.Text = Me.TextBox_efectivo.Enabled
            Me.DateTimePicker_FECHAPAGO.Value = DateTime.Now.ToShortDateString
            Me.DateTimePicker_FECHAPAGO.MinDate = DateTime.Now.ToShortDateString
            Me.DateTimePicker_FECHAPAGO.MaxDate = DateTime.Now.AddMonths(12)
            Me.DateTimePicker_FECHAPAGO.Visible = True

            'Me.Panel_EFECTIVO.Visible = False
            'Me.Panel_CREDITO.Visible = True
            Me.Panel_COMPROBANTE.Visible = False




            Exit Sub
        End If

        If MEDIO_PAGO_DESTINO_NOMBRE.ToUpper <> "EFECTIVO" Then
            Me.TextBox_comprobante.Enabled = True
            fecha_de_pago = ""
            Me.TextBox_efectivo.Text = "0"
            Label_cambio_VR.Text = "0"


            Me.Panel_COMPROBANTE.Visible = True
        End If
    End Sub






    Private Sub Panel_preciocambiar_Paint(sender As Object, e As PaintEventArgs) Handles Panel_preciocambiar.Paint

    End Sub
    ' cambiar precio -----------------------------------




    ' hacer descuento -----------------------------------
    Private Sub Button_cancelar_descuento_Click(sender As Object, e As EventArgs) Handles Button_cancelar_descuento.Click
        Panel_descuento.Visible = False
        Grid_PRODS_RESULT.Visible = True
        PANEL_prods_result.Visible = False

    End Sub
    Private Sub TextBox_TOTALVENTA_TextChanged(sender As Object, e As EventArgs) Handles TextBox_TOTALVENTA.TextChanged

    End Sub
    Private Sub Button_hacer_descuento_Click(sender As Object, e As EventArgs) Handles Button_hacer_descuento.Click
        If Textbox_dcto_concepto.Text = "" Then
            MsgBox("debe escribir la descripcion del descuento.")
            Exit Sub
        End If
        If NumericUpDown_dcto.Value > 0 Then
            Textbox_dcto_concepto.Text = Textbox_dcto_concepto.Text & " " & NumericUpDown_dcto.Value & "%"
        End If

        sql = "insert into ventas_dctos_temp (documento,codprod, producto, valortotal, estado) 
values('" & Label_consecutivo.Text & "','','" & Textbox_dcto_concepto.Text & "','" & CInt(TextBox_descuento_vr.Text) * -1 & "','DESCARGADO')"
        da = New MySqlDataAdapter(sql, conex)
        dt = New DataTable
        Try
            da.Fill(dt)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.ToString)
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()


        Panel_descuento.Visible = False
        Grid_PRODS_RESULT.Visible = True
        PANEL_prods_result.Visible = False


        Fill_ProdsSale(Me.Label_consecutivo.Text)

        dataGrid_detalleprodsVENTA.ClearSelection()
    End Sub
    Private Sub Button_descuento_Click(sender As Object, e As EventArgs) Handles Button_descuento.Click
        If PERMISO_1(32) = "NO" Or PERMISO_1(32) = Nothing Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub



        If Label_consecutivo.Text = "" Then Exit Sub


        PANEL_prods_result.Visible = True
        Grid_PRODS_RESULT.Visible = False

        Panel_descuento.Width = 410
        Centrar(Panel_descuento)

        Panel_descuento.Visible = True
    End Sub
    Private Sub TextBox_descuento_vr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_descuento_vr.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""

    End Sub
    Private Sub TextBox_DESCUENTO_TextChanged(sender As Object, e As EventArgs) Handles TextBox_DESCUENTO.TextChanged

    End Sub
    Private Sub TextBox_descuento_vr_OnValueChanged(sender As Object, e As EventArgs) Handles TextBox_descuento_vr.OnValueChanged

    End Sub
    Private Sub NumericUpDown_dcto_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_dcto.ValueChanged
        If TextBox_TOTAL_pagar.Text = "" Then Exit Sub
        If TextBox_TOTAL_pagar.Text = "0" Then Exit Sub

        If TextBox_descuento_vr.Text = "" Then TextBox_descuento_vr.Text = "0"

        If CInt(TextBox_TOTAL_pagar.Text) < CInt(TextBox_descuento_vr.Text) Then Exit Sub



        TextBox_descuento_vr.Text = (CInt(TextBox_TOTAL_pagar.Text) * (NumericUpDown_dcto.Value) / 100)

    End Sub
    ' hacer descuento -----------------------------------







    '===============SELECT CUENTA PENDIENTE
    Private Sub PictureBox_cuentas_Click(sender As Object, e As EventArgs) Handles PictureBox_cuentas.Click
        If Label_estado.Text = "** Nueva Cuenta **" Then
            Exit Sub
        End If
        Label_lcd.Text = ""


        If PANEL_prods_result.Visible = True Then
            PANEL_prods_result.Visible = False
            FlowLayout_MULTIPANEL.Visible = True
        End If

        CLEAN_FLOW()
        dataGrid_detalleprodsVENTA.ClearSelection()

        Try
            sql = "select documento, clientenom, total, Salon, mesa, mesero, cocina, parrilla, bar, Propina, Alerta from ventas_pre where estado='PENDIENTE'"
            da_pre = New MySqlDataAdapter(sql, conex)
            dt_pre = New DataTable
            da_pre.Fill(dt_pre)
            Me.Grid_Pre_pendientes.DataSource = dt_pre

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_pre.Dispose()
        dt_pre.Dispose()
        conex.Close()


        Try
            For Each row As DataRow In dt_pre.Rows
                'prod_cod = row.Item("documento")


                panel_flow_cuenta = New FlowLayoutPanel
                panel_flow_cuenta.Size = New Size(180, 170)
                panel_flow_cuenta.Padding = New Padding(5)
                panel_flow_cuenta.BorderStyle = BorderStyle.FixedSingle
                panel_flow_cuenta.Name = "FlowCTA_" & row.Item("documento").ToString

                AddHandler panel_flow_cuenta.Click, AddressOf panel_flow_cuenta_Click

                BOTON_CTA.Text.ToUpper()
                BOTON_CTA = New Button
                BOTON_CTA.Size = New Size(160, 110)
                BOTON_CTA.FlatStyle = FlatStyle.Flat
                BOTON_CTA.FlatAppearance.MouseOverBackColor = Color.PaleGreen

                BOTON_CTA.FlatAppearance.BorderSize = 0
                BOTON_CTA.BackColor = Color.Transparent
                BOTON_CTA.ForeColor = Color.Black
                BOTON_CTA.Font = New System.Drawing.Font(FontFamily.GenericSansSerif, 17.0F, FontStyle.Bold)
                BOTON_CTA.TextAlign = ContentAlignment.TopLeft
                BOTON_CTA.Padding = New Padding(3)
                BOTON_CTA.Name = "BTNCTA_" & row.Item("documento").ToString
                BOTON_CTA.Text = "#" & row.Item("documento").ToString    ' TEXTODE LA CELDAçç
                BOTON_CTA.BackgroundImage = My.Resources.notenew

                BOTON_CTA.BackgroundImageLayout = ImageLayout.Stretch
                AddHandler BOTON_CTA.Click, AddressOf BOTON_CTA_Click
                AddHandler BOTON_CTA.DoubleClick, AddressOf BOTON_CTA_DoubleClick


                BOTON_LAB_CTA.Text.ToUpper()
                BOTON_LAB_CTA = New Button
                BOTON_LAB_CTA.Size = New Size(170, 40)
                BOTON_LAB_CTA.FlatStyle = FlatStyle.Flat
                BOTON_LAB_CTA.FlatAppearance.BorderSize = 0
                BOTON_LAB_CTA.BackColor = Color.Transparent
                BOTON_LAB_CTA.ForeColor = Color.Red
                BOTON_LAB_CTA.Font = New System.Drawing.Font("Courier New", 11.0F, FontStyle.Bold)
                BOTON_LAB_CTA.TextAlign = ContentAlignment.MiddleCenter
                BOTON_LAB_CTA.Name = "LABELCTA_" & row.Item("documento").ToString
                BOTON_LAB_CTA.Text = FormatCurrency(row.Item("TOTAL").ToString)  ' TEXTODE LA CELDAçç
                BOTON_LAB_CTA.BackgroundImage = My.Resources.banner_box3
                BOTON_LAB_CTA.BackgroundImageLayout = ImageLayout.Stretch
                AddHandler BOTON_LAB_CTA.Click, AddressOf BOTON_LAB_cta_Click


                FlowLayout_MULTIPANEL.Controls.Add(panel_flow_cuenta)
                panel_flow_cuenta.Controls.Add(BOTON_CTA)
                panel_flow_cuenta.Controls.Add(BOTON_LAB_CTA)

                Label_lcd.Text = "Seleccione una Cuenta"
                Application.DoEvents()
            Next

        Catch ex As Exception

        End Try






    End Sub
    Private Sub Panel_cliente_Paint(sender As Object, e As PaintEventArgs) Handles Panel_cliente.Paint

    End Sub
    Private Sub panel_flow_cuenta_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
    Private Sub BOTON_CTA_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Select Case btn.Text
            Case 0
        End Select
        Dim cta_sel As String = btn.Name.ToString
        cta_sel = cta_sel.Replace("BTNCTA_", "")

        Label_consecutivo.Text = cta_sel : Label_consecutivo.BackColor = Color.Tomato
        Label_mesa.Text = ""
        Try
            sql = "select fecha, documento, clientenom, doccliente, total, Salon, mesa, mesero, cocina, parrilla, bar, Propina, Alerta, observaciones, hora from ventas_pre where estado='PENDIENTE' and documento='" & cta_sel & "'"
            da_pre = New MySqlDataAdapter(sql, conex)
            dt_pre = New DataTable
            da_pre.Fill(dt_pre)
            Me.Grid_Pre_pendientes.DataSource = dt_pre

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_pre.Dispose()
        dt_pre.Dispose()
        conex.Close()

        For Each row As DataRow In dt_pre.Rows
            Label_mesa.Text = row.Item("mesa").ToString : Label_mesa.BackColor = Color.Tomato
            LabeL_ZONA.Text = row.Item("SALON").ToString : Label_mesa.BackColor = Color.Tomato

            Label_hr.Text = row.Item("hora").ToString

            ComboBox_mesero.Text = row.Item("mesero").ToString : PictureBox_back_mesero.Visible = True
            Label_FECHA.Text = row.Item("fecha").ToString
            Label_cliente.Text = row.Item("doccliente").ToString & vbNewLine & row.Item("clientenom").ToString : PictureBox_opcion_cliente.Visible = True
            propina = row.Item("propina")

            cli_doc = row.Item("doccliente").ToString
            TextBox_observaciones.Text = row.Item("observaciones").ToString
        Next
        'cargo cliente data
        fill_client_data(cli_doc)

        'carga productos
        Fill_ProdsSale(cta_sel)

        Label_estado.Text = "Cuenta Pendiente" : Label_estado.BackColor = Color.Tomato
        Button_nueva_cuenta.Visible = True : Button_nueva_cuenta.Enabled = True
        Button_anular_cuenta.Enabled = False

        VENTAS_DOMICILIO = ""
        dataGrid_detalleprodsVENTA.ClearSelection()
        Label_domicilio_estado.Visible = False

        TextBoxDomicilioVr.Text = "0"

        Try



            sql = "SELECT * from domicilios where cuenta='" & CStr(cta_sel) & "'"

            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                VENTAS_DOMICILIO = row.Item("CONS")
                Label_domicilio_estado.Text = row.Item("estado")
                Label_domicilio_estado.Visible = True
                TextBoxDomicilioVr.Text = row.Item("valor")
            Next
        Catch ex As Exception
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()


    End Sub
    Private Sub TextBox_otroprecio_TextChanged(sender As Object, e As EventArgs) Handles TextBox_otroprecio.TextChanged

    End Sub
    Private Sub BOTON_CTA_DoubleClick(sender As Object, e As EventArgs)



    End Sub
    Private Sub BOTON_LAB_cta_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Select Case btn.Text
            Case 0
        End Select
        Dim cta_sel As String = btn.Name.ToString
        cta_sel = cta_sel.Replace("LABELCTA_", "")

        Label_consecutivo.Text = cta_sel : Label_consecutivo.BackColor = Color.Tomato
        Label_mesa.Text = ""

        Try
            sql = "select fecha, documento, clientenom, doccliente, total, Salon, mesa, mesero, cocina, parrilla, bar, Propina, Alerta, Hora, observaciones from ventas_pre where estado='PENDIENTE' and documento='" & cta_sel & "'"
            da_pre = New MySqlDataAdapter(sql, conex)
            dt_pre = New DataTable
            da_pre.Fill(dt_pre)
            Me.Grid_Pre_pendientes.DataSource = dt_pre

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_pre.Dispose()
        dt_pre.Dispose()
        conex.Close()

        For Each row As DataRow In dt_pre.Rows
            Label_mesa.Text = row.Item("mesa").ToString : Label_mesa.BackColor = Color.Tomato
            LabeL_ZONA.Text = row.Item("SALON").ToString : Label_mesa.BackColor = Color.Tomato
            Label_hr.Text = row.Item("hora").ToString

            ComboBox_mesero.Text = row.Item("mesero").ToString : PictureBox_back_mesero.Visible = True
            Label_FECHA.Text = row.Item("fecha").ToString
            Label_cliente.Text = row.Item("doccliente").ToString & vbNewLine & row.Item("clientenom").ToString : PictureBox_opcion_cliente.Visible = True
            propina = row.Item("propina")
            cli_doc = row.Item("doccliente").ToString
            TextBox_observaciones.Text = row.Item("observaciones").ToString

        Next

        Fill_ProdsSale(cta_sel)
        fill_client_data(cli_doc)
        Textbox_buscar_prod.Focus()

        'carga productos

        CLEAN_FLOW()

        Label_estado.Text = "Cuenta Pendiente" : Label_estado.BackColor = Color.Tomato
        Button_nueva_cuenta.Visible = True : Button_nueva_cuenta.Enabled = True
        Button_anular_cuenta.Enabled = True
        dataGrid_detalleprodsVENTA.ClearSelection()

        VENTAS_DOMICILIO = ""
        dataGrid_detalleprodsVENTA.ClearSelection()
        Label_domicilio_estado.Visible = False

        TextBoxDomicilioVr.Text = "0"

        Try



            sql = "SELECT * from domicilios where cuenta='" & CStr(cta_sel) & "'"

            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                VENTAS_DOMICILIO = row.Item("CONS")
                Label_domicilio_estado.Text = row.Item("estado")
                Label_domicilio_estado.Visible = True
                TextBoxDomicilioVr.Text = row.Item("valor")
            Next
        Catch ex As Exception
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()

    End Sub
    Private Sub BOTON_LAB_cta_DoubleClick(sender As Object, e As EventArgs)

    End Sub
    '===============SELECT CUENTA PENDIENTE

    Private Sub BunifuCheckbox_propina_OnChange(sender As Object, e As EventArgs) Handles BunifuCheckbox_propina.OnChange
        If BunifuCheckbox_propina.Checked = True Then

            If comex_propina = "PORCENTAJE" Then
                Label_propina.Text = "Propina " & comex_propinavr & "%"
                propina = comex_propinavr
                TextBox_propina.Text = CInt((CInt(TextBox_TOTALVENTA.Text) * CInt(propina)) / 100)
                TextBox_TOTAL_pagar.Text = CInt(TextBox_TOTALVENTA.Text) + CInt(TextBox_propina.Text)

                TextBox_propina.Enabled = False
            End If

            If comex_propina = "VALOR" Then
                Label_propina.Text = "Propina" & " $" & comex_propinavr

                TextBox_propina.Text = comex_propinavr

                TextBox_propina.Enabled = True
                TextBox_TOTAL_pagar.Text = CInt(TextBox_TOTALVENTA.Text) + CInt(TextBox_propina.Text)

            End If

            'sql = "UPDATE ventas_pre SET propina='SI' WHERE DOCUMENTO=" & CLng(Label_consecutivo.Text) & ""
            'da = New MySqlDataAdapter(sql, conex)
            'dt = New DataTable
            'Try
            '    da.Fill(dt)
            '    'MsgBox("Tarifa Actualizada.   :).", vbInformation)
            'Catch ex As Exception
            '    MsgBox(ex.ToString)
            'End Try
            'da.Dispose()
            'dt.Dispose()
            'conex.Close()
        End If

        If BunifuCheckbox_propina.Checked = False Then
            If TextBox_propina.Text = "" Then TextBox_propina.Text = "0"
            TextBox_TOTAL_pagar.Text = CInt(TextBox_TOTAL_pagar.Text) - CInt(TextBox_propina.Text)
            TextBox_propina.Text = "0"

            Label_propina.Text = "Propina"

            'sql = "UPDATE ventas_pre SET propina='' WHERE DOCUMENTO=" & CLng(Label_consecutivo.Text) & ""
            'da = New MySqlDataAdapter(sql, conex)
            'dt = New DataTable
            'Try
            '    da.Fill(dt)
            '    'MsgBox("Tarifa Actualizada.   :).", vbInformation)
            'Catch ex As Exception
            '    MsgBox(ex.ToString)
            'End Try
            'da.Dispose()
            'dt.Dispose()
            'conex.Close()
        End If
        TextBox_efectivo.Text = TextBox_TOTAL_pagar.Text
    End Sub

    ' <---- BUSCAR MESA >
    Private Sub PictureBox_mesas_Click(sender As Object, e As EventArgs) Handles PictureBox_mesas.Click



        CLEAN_FLOW()
        dataGrid_detalleprodsVENTA.ClearSelection()
        datagrid_prodlist.ClearSelection()

        For I = 0 To MetroGrid_zonas.RowCount - 1

            BOTON_ZONE = New Button
            BOTON_ZONE.Size = New Size(170, 65)
            BOTON_ZONE.FlatStyle = FlatStyle.Flat
            BOTON_ZONE.FlatAppearance.BorderSize = 0
            BOTON_ZONE.BackColor = Color.Transparent
            BOTON_ZONE.ForeColor = Color.White
            BOTON_ZONE.Font = New System.Drawing.Font("Courier New", 14.0F, FontStyle.Bold)

            BOTON_ZONE.BackgroundImage = My.Resources.butttonsvg
            BOTON_ZONE.BackgroundImageLayout = ImageLayout.Stretch

            BOTON_ZONE.TextAlign = ContentAlignment.MiddleCenter
            BOTON_ZONE.Name = "BUTTONZONA_" & MetroGrid_zonas.Item("CONS", I).Value & "_" & MetroGrid_zonas.Item("MESAS", I).Value
            BOTON_ZONE.Text = MetroGrid_zonas.Item("ZONA", I).Value   ' TEXTO DE LA CELDA
            AddHandler BOTON_ZONE.Click, AddressOf BOTON_ZONE_Click
            FlowLayout_MULTIPANEL.Controls.Add(BOTON_ZONE)
        Next
        Label_lcd.Text = "Seleccione una Ubicación..."

        Exit Sub

    End Sub
    Private Sub BOTON_ZONE_Click(sender As Object, e As EventArgs)

        Dim btn As Button = CType(sender, Button)
        Select Case btn.Text
            Case 0
        End Select
        Dim MESAS_INFO As String() = Split(btn.Name.ToString, "_")
        comex_mesas = MESAS_INFO(2)
        ' ======================================   seleccionar anterior mesa
        LabeL_ZONA.Text = btn.Text
        If PANEL_prods_result.Visible = True Then
            PANEL_prods_result.Visible = False
            FlowLayout_MULTIPANEL.Visible = True
        End If

        CLEAN_FLOW()
        Label_lcd.Text = "Seleccione una Cuenta"

        For j = 1 To CInt(comex_mesas)
            panel_flow_in = New FlowLayoutPanel
            panel_flow_in.Size = New Size(160, 150)
            panel_flow_in.Padding = New Padding(5)
            panel_flow_in.BorderStyle = BorderStyle.FixedSingle
            panel_flow_in.Name = "Flow" & j.ToString

            AddHandler panel_flow_in.Click, AddressOf PANEL_FLOW_IN_Click

            BOTON_NFac = New Button
            BOTON_NFac.Size = New Size(30, 30)
            BOTON_NFac.FlatStyle = FlatStyle.Flat
            BOTON_NFac.FlatAppearance.BorderSize = 0
            BOTON_NFac.BackColor = Color.Transparent
            BOTON_NFac.ForeColor = Color.White
            BOTON_NFac.Font = New System.Drawing.Font(FontFamily.GenericSansSerif, 0.1F, FontStyle.Bold)
            BOTON_NFac.TextAlign = ContentAlignment.BottomCenter

            BOTON_NFac.BackgroundImageLayout = ImageLayout.Stretch

            BOTON_NFac.TextAlign = ContentAlignment.MiddleCenter
            BOTON_NFac.Name = "add_" & j
            BOTON_NFac.BackgroundImage = My.Resources.agregar
            'If datagrid_prodlist.Item("imagen", j).Value <> "" And datagrid_prodlist.Item("imagen", j).Value <> " " Then BOTON_prod.BackgroundImage = Image.FromFile(datagrid_prodlist.Item("imagen", j).Value)
            BOTON_NFac.TextAlign = ContentAlignment.BottomCenter

            AddHandler BOTON_NFac.Click, AddressOf BOTON_NFac_Click


            BOTON_MESAS = New Button
            BOTON_MESAS.Size = New Size(100, 90)
            BOTON_MESAS.FlatStyle = FlatStyle.Flat
            BOTON_MESAS.FlatAppearance.BorderSize = 0
            BOTON_MESAS.BackColor = Color.Transparent
            BOTON_MESAS.ForeColor = Color.White
            BOTON_MESAS.Font = New System.Drawing.Font(FontFamily.GenericSansSerif, 0.1F, FontStyle.Bold)
            BOTON_MESAS.TextAlign = ContentAlignment.BottomCenter

            BOTON_MESAS.BackgroundImageLayout = ImageLayout.Stretch

            BOTON_MESAS.TextAlign = ContentAlignment.MiddleCenter
            BOTON_MESAS.Name = j
            BOTON_MESAS.Text = "Mesa " & j.ToString   ' TEXTODE LA CELDAçç
            BOTON_MESAS.BackgroundImage = My.Resources.table7
            'If datagrid_prodlist.Item("imagen", j).Value <> "" And datagrid_prodlist.Item("imagen", j).Value <> " " Then BOTON_prod.BackgroundImage = Image.FromFile(datagrid_prodlist.Item("imagen", j).Value)
            BOTON_MESAS.TextAlign = ContentAlignment.BottomCenter

            AddHandler BOTON_MESAS.Click, AddressOf BOTON_MESAS_Click



            BOTON_LAB_mesa = New Button
            BOTON_LAB_mesa.Size = New Size(148, 40)
            BOTON_LAB_mesa.FlatStyle = FlatStyle.Flat
            BOTON_LAB_mesa.FlatAppearance.BorderSize = 0
            BOTON_LAB_mesa.BackColor = Color.Transparent
            BOTON_LAB_mesa.ForeColor = Color.White
            BOTON_LAB_mesa.Font = New System.Drawing.Font(FontFamily.GenericSansSerif, 8.5F, FontStyle.Bold)
            BOTON_LAB_mesa.TextAlign = ContentAlignment.MiddleCenter
            BOTON_LAB_mesa.Name = "LAB" & j.ToString
            BOTON_LAB_mesa.Text = "Mesa " & j.ToString & vbNewLine & "$ 0" ' TEXTODE LA CELDAçç
            'BOTON_LAB.BackgroundImage = My.Resources.BUTTTON1
            BOTON_LAB_mesa.BackColor = Color.SteelBlue
            BOTON_LAB_mesa.BackgroundImageLayout = ImageLayout.Stretch

            AddHandler BOTON_LAB_mesa.Click, AddressOf BOTON_LAB_mesa_Click




            FlowLayout_MULTIPANEL.Controls.Add(panel_flow_in)

            panel_flow_in.Controls.Add(BOTON_MESAS)
            panel_flow_in.Controls.Add(BOTON_NFac)

            panel_flow_in.Controls.Add(BOTON_LAB_mesa)


            BOTON_LAB_mesa.Enabled = False
            BOTON_MESAS.Enabled = False


            Try
                sql = "SELECT mesa, TOTAL FROM ventas_pre WHERE MESA='" & j.ToString & "' AND SALON='" & btn.Text & "'"
                da_MESAS = New MySqlDataAdapter(sql, conex)
                DT_MESAS = New DataTable
                da_MESAS.Fill(DT_MESAS)


                For Each row As DataRow In DT_MESAS.Rows
                    'Me.ComboBox_MESA.Items.Remove(CInt(row.Item("mesA")))
                    If row.Item("TOTAL") = 0 Then BOTON_LAB_mesa.Text = "Mesa " & j.ToString & vbNewLine & "$ 0"
                    If row.Item("TOTAL") <> 0 Then BOTON_LAB_mesa.Text = "Mesa " & j.ToString & vbNewLine & FormatCurrency(row.Item("TOTAL"))
                    BOTON_LAB_mesa.BackColor = Color.Orange
                    BOTON_MESAS.BackgroundImage = My.Resources.tablebusy
                    BOTON_LAB_mesa.Enabled = True
                    BOTON_MESAS.Enabled = True
                    BOTON_NFac.Visible = False
                    'BOTON_NFac.BackgroundImage = My.Resources.refresh
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da_MESAS.Dispose()
            DT_MESAS.Dispose()
            conex.Close()
        Next

        Label_lcd.Text = "<<<  " & LabeL_ZONA.Text & "  >>>" & vbNewLine & "Seleccione una Mesa"


        'Textbox_buscar_prod.Focus()


    End Sub
    Private Sub BOTON_MESAS_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Select Case btn.Text
            Case 0
        End Select
        Dim mesa_sel As String = btn.Name.ToString
        mesa_sel = mesa_sel.Replace("Mesa ", "")



        Try
            sql = "select fecha, documento, clientenom, doccliente, total, Salon, mesa, mesero, cocina, parrilla, bar, Propina, Alerta, Hora, observaciones from ventas_pre where estado='PENDIENTE' and mesa='" & mesa_sel & "' and salon='" & LabeL_ZONA.Text & "'"
            da_pre = New MySqlDataAdapter(sql, conex)
            dt_pre = New DataTable
            da_pre.Fill(dt_pre)
            Me.Grid_Pre_pendientes.DataSource = dt_pre

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_pre.Dispose()
        dt_pre.Dispose()
        conex.Close()

        '===========> unir mesa
        If estado_unir_mesa = True Then
            If mesa_sel = Label_mesa.Text Then ' validacion
                Label_lcd.Text = "Seleccione otra mesa para invitar..."
                Exit Sub
            End If
            Dim RTA = MsgBox("Desea invitar la Mesa " & mesa_sel & vbNewLine & "a la Mesa: " & Label_mesa.Text, MsgBoxStyle.Question + MsgBoxStyle.YesNo)
            If RTA = 6 Then
                For Each row As DataRow In dt_pre.Rows
                    unir_la_mesa(row.Item("documento").ToString, row.Item("mesa").ToString, row.Item("SALON").ToString)
                    estado_unir_mesa = False
                Next
            End If
            PictureBox_back_Click(Nothing, Nothing)
            Fill_ProdsSale(Label_consecutivo.Text)

            Exit Sub
        End If
        '===========> unir mesa



        Dim cta_sel As String = ""

        For Each row As DataRow In dt_pre.Rows
            Label_consecutivo.Text = row.Item("documento").ToString : Label_consecutivo.BackColor = Color.Tomato
            cta_sel = row.Item("documento").ToString
            Label_mesa.Text = row.Item("mesa").ToString : Label_mesa.BackColor = Color.Tomato
            LabeL_ZONA.Text = row.Item("SALON").ToString : Label_mesa.BackColor = Color.Tomato
            ComboBox_mesero.Text = row.Item("mesero").ToString : PictureBox_back_mesero.Visible = True
            Label_FECHA.Text = row.Item("fecha").ToString
            Label_hr.Text = row.Item("hora").ToString

            Label_cliente.Text = row.Item("doccliente").ToString & vbNewLine & row.Item("clientenom").ToString : PictureBox_opcion_cliente.Visible = True
            propina = row.Item("propina")
            cli_doc = row.Item("doccliente").ToString
            TextBox_observaciones.Text = row.Item("observaciones").ToString
        Next
        Fill_ProdsSale(cta_sel)
        fill_client_data(cli_doc)
        Textbox_buscar_prod.Focus()

        'carga productos
        dataGrid_detalleprodsVENTA.ClearSelection()

        Label_estado.Text = "Cuenta Pendiente" : Label_estado.BackColor = Color.Tomato
        Button_nueva_cuenta.Visible = True : Button_nueva_cuenta.Enabled = True
        Button_anular_cuenta.Enabled = False

    End Sub
    Private Sub BOTON_LAB_mesa_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Select Case btn.Text
            Case 0
        End Select
        Dim mesa_sel As String = btn.Name.ToString
        mesa_sel = mesa_sel.Replace("LAB", "")


        Try
            sql = "select fecha, documento, clientenom, doccliente, total, Salon, mesa, mesero, cocina, parrilla, bar, Propina, Alerta, Hora, observaciones from ventas_pre where estado='PENDIENTE' and mesa='" & mesa_sel & "' and salon='" & LabeL_ZONA.Text & "'"
            da_pre = New MySqlDataAdapter(sql, conex)
            dt_pre = New DataTable
            da_pre.Fill(dt_pre)
            Me.Grid_Pre_pendientes.DataSource = dt_pre

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_pre.Dispose()
        dt_pre.Dispose()
        conex.Close()

        Dim cta_sel As String = ""

        For Each row As DataRow In dt_pre.Rows
            Label_consecutivo.Text = row.Item("documento").ToString : Label_consecutivo.BackColor = Color.Tomato
            cta_sel = row.Item("documento").ToString
            Label_mesa.Text = row.Item("mesa").ToString : Label_mesa.BackColor = Color.Tomato
            LabeL_ZONA.Text = row.Item("SALON").ToString : Label_mesa.BackColor = Color.Tomato

            ComboBox_mesero.Text = row.Item("mesero").ToString : PictureBox_back_mesero.Visible = True
            Label_FECHA.Text = row.Item("fecha").ToString
            Label_hr.Text = row.Item("hora").ToString

            Label_cliente.Text = row.Item("doccliente").ToString & vbNewLine & row.Item("clientenom").ToString : PictureBox_opcion_cliente.Visible = True
            propina = row.Item("propina")
            cli_doc = row.Item("doccliente").ToString
            TextBox_observaciones.Text = row.Item("observaciones").ToString
        Next

        Fill_ProdsSale(cta_sel)
        fill_client_data(cli_doc)
        Textbox_buscar_prod.Focus()

        'carga productos

        dataGrid_detalleprodsVENTA.ClearSelection()

        Label_estado.Text = "Cuenta Pendiente" : Label_estado.BackColor = Color.Tomato

        CLEAN_FLOW()
        Button_nueva_cuenta.Visible = True : Button_nueva_cuenta.Enabled = True
        Button_anular_cuenta.Enabled = True


    End Sub
    Private Sub PANEL_FLOW_IN_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BOTON_NFac_Click(sender As Object, e As EventArgs)



        If Label_mesa.Text <> "" Then

        End If

        'crea nueva cuenta desde vista de mesas
        Dim btn As Button = CType(sender, Button)
        Select Case btn.Text
            Case 0
        End Select
        Dim mesa_sel As String = btn.Name.ToString
        mesa_sel = mesa_sel.Replace("add_", "")


        'If Label_estado.Text = "** Nueva Cuenta **" Then
        '    'establece la mesa solamente sin guardar la prefactura
        '    Label_mesa.Text = mesa_sel
        'End If


        If Label_estado.Text = "Caja Disponible" Then

            Dim RTA = MsgBox("Desea crear nueva cuenta en:" & vbNewLine & vbNewLine &
                             LabeL_ZONA.Text & vbNewLine &
                             "Mesa: " & mesa_sel, MsgBoxStyle.Question + MsgBoxStyle.YesNo)
            If RTA = 6 Then

                'si la cuenta es nueva guarda la prefactura
                'establece la mesa 
                Button_nueva_cuenta_Click(Nothing, Nothing)
                Label_mesa.Text = mesa_sel

                ' actualizo la mesa


                sql = "UPDATE ventas_pre SET SALON='" & LabeL_ZONA.Text & "', mesa='" & CStr(mesa_sel) & "' WHERE DOCUMENTO='" & CLng(Label_consecutivo.Text) & "'"
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
                Label_lcd.Text = "Seleccione una Opción"
                'For Each control As Control In FlowLayout_MULTIPANEL.Controls
                '    If control.GetType().ToString = "Button" Then
                '        If control.Name = mesa_sel Then control.BackgroundImage = My.Resources.tablebusy

                '    End If
                'Next
                CLEAN_FLOW()

                Exit Sub
            End If

        End If


        If Label_estado.Text = "Cuenta Pendiente" Then
            Dim pregunta As String = ""
            If Label_mesa.Text = "" Then pregunta = "Desea Asignar la mesa  " & vbNewLine & vbNewLine & mesa_sel & "  a la Cuenta  " & Label_consecutivo.Text
            If Label_mesa.Text <> "" Then pregunta = "Desea cambiar de la mesa  " & Label_mesa.Text & vbNewLine & vbNewLine & "a la Mesa  " & mesa_sel

            'PREGUNTAR
            Dim RTA = MsgBox(pregunta, MsgBoxStyle.Question + MsgBoxStyle.YesNo)

            If RTA = 6 Then
                Label_mesa.Text = mesa_sel
                ' actualizo la mesa


                sql = "UPDATE ventas_pre SET SALON='" & LabeL_ZONA.Text & "', mesa='" & CStr(mesa_sel) & "' WHERE DOCUMENTO='" & CLng(Label_consecutivo.Text) & "'"
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
                Label_lcd.Text = "Seleccione una Opción"
                'For Each control As Control In FlowLayout_MULTIPANEL.Controls
                '    If control.GetType().ToString = "Button" Then
                '        If control.Name = mesa_sel Then control.BackgroundImage = My.Resources.tablebusy

                '    End If
                'Next
            End If

        End If
        CLEAN_FLOW()

    End Sub

    Private Sub UnirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnirToolStripMenuItem.Click
        Label_lcd.Text = "Seleccione una Mesa para unificar..."
        estado_unir_mesa = True

        invitador_cuenta = Label_consecutivo.Text
        invitador_mesa = Label_mesa.Text
        invitador_salon = LabeL_ZONA.Text

        PictureBox_mesas_Click(Nothing, Nothing)
    End Sub

    Private Sub QuitarMesaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitarMesaToolStripMenuItem.Click
        sql = "UPDATE ventas_pre SET SALON='', mesa='' WHERE DOCUMENTO='" & CLng(Label_consecutivo.Text) & "'"
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

        Label_mesa.Text = ""
        LabeL_ZONA.Text = ""

        CLEAN_FLOW()

    End Sub

    ' <---- BUSCAR MESA >



    ' ---------------------- buscar    favoritos
    Private Sub PictureBox_favoritos_Click(sender As Object, e As EventArgs) Handles PictureBox_favoritos.Click
        If Label_estado.Text = "Caja Disponible" Then
            Exit Sub
        End If



        CLEAN_FLOW()
        FlowLayout_MULTIPANEL.Refresh()

        'Dim btn As Button = CType(sender, Button)
        'Select Case btn.Text
        '    Case 0
        'End Select


        Me.Cursor = Cursors.WaitCursor
        sql = "SELECT * FROM productos where fav='SI' and estado='ACTIVO'"
        da = New MySqlDataAdapter(sql, conex)
        dt = New DataTable
        Try
            da.Fill(dt)
            Me.datagrid_prodlist.DataSource = dt

        Catch ex As Exception
            If ex.ToString.Contains("Duplicate entry") Then MsgBox("Ese proveedor ya se encuentra en la lista", vbExclamation)
            MsgBox(ex.ToString)
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()
        Me.Cursor = Cursors.Default


        For j = 0 To datagrid_prodlist.RowCount - 1

            panel_flow_in = New FlowLayoutPanel
            panel_flow_in.Size = New Size(190, 150)
            panel_flow_in.Padding = New Padding(5)
            panel_flow_in.BorderStyle = BorderStyle.FixedSingle
            panel_flow_in.Name = "Flow" & j.ToString

            AddHandler panel_flow_in.Click, AddressOf PANEL_FLOW_IN_Click



            BOTON_LAB_prod.Text.ToUpper()
            BOTON_LAB_prod = New Button
            BOTON_LAB_prod.Size = New Size(170, 40)
            BOTON_LAB_prod.FlatStyle = FlatStyle.Flat
            BOTON_LAB_prod.FlatAppearance.BorderSize = 0
            BOTON_LAB_prod.BackColor = Color.Transparent
            BOTON_LAB_prod.ForeColor = Color.Black
            BOTON_LAB_prod.Font = New System.Drawing.Font(FontFamily.GenericSansSerif, 7.0F, FontStyle.Bold)
            BOTON_LAB_prod.TextAlign = ContentAlignment.MiddleCenter
            BOTON_LAB_prod.Name = "LAB" & datagrid_prodlist.Item("COD", j).Value
            BOTON_LAB_prod.Text = datagrid_prodlist.Item("nombre", j).Value    ' TEXTODE LA CELDAçç
            BOTON_LAB_prod.BackgroundImage = My.Resources.banner_box3
            BOTON_LAB_prod.BackgroundImageLayout = ImageLayout.Stretch
            AddHandler BOTON_LAB_prod.Click, AddressOf BOTON_lab_prod_Click


            BOTON_product = New Button
            BOTON_product.Size = New Size(170, 100)
            BOTON_product.FlatStyle = FlatStyle.Flat
            BOTON_product.FlatAppearance.BorderSize = 0
            BOTON_product.BackColor = Color.Transparent
            BOTON_product.ForeColor = Color.White
            BOTON_product.Font = New System.Drawing.Font(FontFamily.GenericSansSerif, 0.1F, FontStyle.Bold)
            BOTON_product.TextAlign = ContentAlignment.BottomCenter

            BOTON_product.BackgroundImageLayout = ImageLayout.Stretch

            BOTON_product.TextAlign = ContentAlignment.MiddleCenter
            BOTON_product.Name = datagrid_prodlist.Item("COD", j).Value
            BOTON_product.Text = datagrid_prodlist.Item("nombre", j).Value   ' TEXTODE LA CELDAçç
            BOTON_product.BackgroundImage = My.Resources.no_product_3


            If File.Exists(CStr(datagrid_prodlist.Item("imagen", j).Value)) Then
                If datagrid_prodlist.Item("imagen", j).Value <> "" And datagrid_prodlist.Item("imagen", j).Value <> " " Then BOTON_product.BackgroundImage = System.Drawing.Image.FromFile(datagrid_prodlist.Item("imagen", j).Value)
            End If

            BOTON_product.TextAlign = ContentAlignment.BottomCenter

            AddHandler BOTON_product.Click, AddressOf BOTON_product_Click


            FlowLayout_MULTIPANEL.Controls.Add(panel_flow_in)


            panel_flow_in.Controls.Add(BOTON_product)
            panel_flow_in.Controls.Add(BOTON_LAB_prod)

        Next
        Label_lcd.Text = "Seleccione un producto..."

    End Sub
    ' ---------------------- buscar    favoritos




    ' <-------- BUSCAR cateorias y productos >

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If Label_estado.Text = "Caja Disponible" Then
            Exit Sub
        End If


        If PANEL_prods_result.Visible = True Then
            PANEL_prods_result.Visible = False
            FlowLayout_MULTIPANEL.Visible = True
        End If


        CLEAN_FLOW()
        FlowLayout_MULTIPANEL.Refresh()
        dataGrid_detalleprodsVENTA.ClearSelection()


        Me.Cursor = Cursors.WaitCursor
        sql = "SELECT distinct(categoria) AS CATEGORIA FROM productos_categorias where tipo in('SERVICIOS','PRODUCTOS') and estado='ACTIVO' order by categoria;"
        da = New MySqlDataAdapter(sql, conex)
        dt = New DataTable
        Try
            da.Fill(dt)
            Me.MetroGrid_categorias.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()
        Me.Cursor = Cursors.Default



        For I = 0 To MetroGrid_categorias.RowCount - 1

            BOTON_CAT = New Button
            BOTON_CAT.Size = New Size(170, 65)
            BOTON_CAT.FlatStyle = FlatStyle.Flat
            BOTON_CAT.FlatAppearance.BorderSize = 0
            BOTON_CAT.BackColor = Color.Transparent
            BOTON_CAT.ForeColor = Color.White
            BOTON_CAT.Font = New System.Drawing.Font("Courier New", 14.0F, FontStyle.Bold)

            BOTON_CAT.BackgroundImage = My.Resources.butttonsvg
            BOTON_CAT.BackgroundImageLayout = ImageLayout.Stretch

            BOTON_CAT.TextAlign = ContentAlignment.MiddleCenter
            BOTON_CAT.Name = "BUTTON_" & I.ToString
            BOTON_CAT.Text = MetroGrid_categorias.Item("CATEGORIA", I).Value   ' TEXTODE LA CELDA
            AddHandler BOTON_CAT.Click, AddressOf BOTON_CAT_Click
            FlowLayout_MULTIPANEL.Controls.Add(BOTON_CAT)
        Next
        Label_lcd.Text = "Seleccione una categoría..."
    End Sub
    Private Sub BOTON_CAT_Click(sender As Object, e As EventArgs)
        CLEAN_FLOW()
        FlowLayout_MULTIPANEL.Refresh()

        Dim btn As Button = CType(sender, Button)
        Select Case btn.Text
            Case 0
        End Select


        Me.Cursor = Cursors.WaitCursor
        sql = "SELECT * FROM productos where categoria='" & btn.Text & "' AND ESTADO='ACTIVO'"
        da = New MySqlDataAdapter(sql, conex)
        dt = New DataTable
        Try
            da.Fill(dt)
            Me.datagrid_prodlist.DataSource = dt

        Catch ex As Exception
            If ex.ToString.Contains("Duplicate entry") Then MsgBox("Ese proveedor ya se encuentra en la lista", vbExclamation)
            MsgBox(ex.ToString)
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()
        Me.Cursor = Cursors.Default


        For j = 0 To datagrid_prodlist.RowCount - 1

            panel_flow_in = New FlowLayoutPanel
            panel_flow_in.Size = New Size(190, 150)
            panel_flow_in.Padding = New Padding(5)
            panel_flow_in.BorderStyle = BorderStyle.FixedSingle
            panel_flow_in.Name = "Flow" & j.ToString

            AddHandler panel_flow_in.Click, AddressOf PANEL_FLOW_IN_Click



            BOTON_LAB_prod = New Button
            BOTON_LAB_prod.Size = New Size(170, 40)
            BOTON_LAB_prod.FlatStyle = FlatStyle.Flat
            BOTON_LAB_prod.FlatAppearance.BorderSize = 0
            BOTON_LAB_prod.BackColor = Color.Transparent
            BOTON_LAB_prod.ForeColor = Color.White
            BOTON_LAB_prod.Font = New System.Drawing.Font("Century Gotic", 7.5F, FontStyle.Bold)
            BOTON_LAB_prod.TextAlign = ContentAlignment.MiddleCenter
            BOTON_LAB_prod.Name = "LAB" & datagrid_prodlist.Item("COD", j).Value
            BOTON_LAB_prod.Text = datagrid_prodlist.Item("nombre", j).Value    ' TEXTODE LA CELDAçç
            'BOTON_LAB_prod.BackgroundImage = My.Resources.butttonsvg
            BOTON_LAB_prod.BackgroundImageLayout = ImageLayout.Stretch
            AddHandler BOTON_LAB_prod.Click, AddressOf BOTON_lab_prod_Click


            BOTON_product = New Button
            BOTON_product.Size = New Size(170, 100)
            BOTON_product.FlatStyle = FlatStyle.Flat
            BOTON_product.FlatAppearance.BorderSize = 0
            BOTON_product.BackColor = Color.Transparent
            BOTON_product.ForeColor = Color.White
            BOTON_product.Font = New System.Drawing.Font("Courier New", 1.0F, FontStyle.Regular)
            BOTON_product.TextAlign = ContentAlignment.BottomCenter

            BOTON_product.BackgroundImageLayout = ImageLayout.Stretch

            BOTON_product.TextAlign = ContentAlignment.MiddleCenter
            BOTON_product.Name = datagrid_prodlist.Item("COD", j).Value
            BOTON_product.Text = datagrid_prodlist.Item("nombre", j).Value   ' TEXTODE LA CELDAçç
            BOTON_product.BackgroundImage = My.Resources.no_product_3


            If File.Exists(CStr(datagrid_prodlist.Item("imagen", j).Value)) Then
                If datagrid_prodlist.Item("imagen", j).Value <> "" And datagrid_prodlist.Item("imagen", j).Value <> " " Then BOTON_product.BackgroundImage = System.Drawing.Image.FromFile(datagrid_prodlist.Item("imagen", j).Value)
            End If

            BOTON_product.TextAlign = ContentAlignment.BottomCenter

            AddHandler BOTON_product.Click, AddressOf BOTON_product_Click


            FlowLayout_MULTIPANEL.Controls.Add(panel_flow_in)


            panel_flow_in.Controls.Add(BOTON_product)
            panel_flow_in.Controls.Add(BOTON_LAB_prod)

        Next
        Label_lcd.Text = "Seleccione un producto..."
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim Texto As String, Fuente As String, Tamano As Integer
        Dim Estilo As New FontStyle
        Estilo = FontStyle.Regular
        Fuente = ""
        Tamano = 1
        Dim Letra As New System.Drawing.Font(Fuente, Tamano, Estilo)
        Texto = Chr(27) & Chr(112) & Chr(0) & Chr(25) & Chr(255)
        e.Graphics.DrawString(Texto, Letra, Brushes.Black, 0, 0)
    End Sub

    Private Sub Button_notas_Click(sender As Object, e As EventArgs) Handles Button_notas.Click
        If Label_consecutivo.Text = "" Then
            Exit Sub
        End If

        PANEL_prods_result.Visible = True
        Grid_PRODS_RESULT.Visible = False

        Panel_notas.Width = 460
        Centrar(Panel_notas)

        Panel_notas.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click


        Panel_notas.Visible = False
        Grid_PRODS_RESULT.Visible = True
        PANEL_prods_result.Visible = False
    End Sub

    Private Sub Button_guardar_notas_Click(sender As Object, e As EventArgs) Handles Button_guardar_notas.Click


        sql = "UPDATE ventas_pre SET observaciones='" & TextBox_observaciones.Text & "' WHERE DOCUMENTO='" & Label_consecutivo.Text & "'"
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

        'cerrar panel
        Button5_Click(Nothing, Nothing)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Label_consecutivo.Text = "" Then Exit Sub
        Button1.Visible = True

        'If BunifuCheckbox_propina.Checked = True Then
        '    imp_propina = TextBox_propina.Text
        'Else
        '    imp_propina = ""
        'End If

        imp_titulo1 = comex_nombrecomercial
        imp_dir = comex_dircomercio
        imp_tels = comex_tels
        imp_propietario = comex_nombrepropietario
        imp_regimen = comex_regimen
        imp_nit = comex_nit & "-" & comex_DV
        imp_resdian = comex_Resdian
        imp_intervalo = comex_intervalo
        imp_factunum = Label_consecutivo.Text
        imp_fecha_factu = DateTime.Now.ToShortDateString
        imp_hora_factu = DateTime.Now.ToShortTimeString

        'imp_prod, imp_cant, imp_vrtotal, 
        imp_totalVenta = TextBox_TOTAL_pagar.Text
        'imp_Descuento = TextBox_DESCUENTO.Text
        imp_subtotal = imp_subtotal
        'Imp_baseimp = baseimpuesto
        'imp_impuesto = impuesto
        imp_totalapagar = TextBox_TOTAL_pagar.Text
        imp_efectivo = "?"
        imp_cambio = "?"
        imp_cajero = usrnom

        Try
            sql = "SELECT CodProd, Producto, 
concat('x',cantidad), format(valoru,0), concat('$',format(valortotal,0))
from ventas_prods_temp
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
            sql = "SELECT  ventas_prods_temp.ImpNom2 as IMPUESTO, CONCAT('$',format(sum(ventas_prods_temp.valortotal-ventas_prods_temp.impuesto2),0)) as BASE, CONCAT('$',format(sum(ventas_prods_temp.impuesto2),0)) as VrIMP, CONCAT('$',format(sum(ventas_prods_temp.valortotal),0)) as VrTOTAL
FROM ventas_prods_temp
left join ventas_pre on ventas_prods_temp.documento=ventas_pre.documento
where ventas_pre.documento='" & Label_consecutivo.Text & "'
group by ventas_prods_temp.impnom2"
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
            Try
                If comex_formatofactura = "Tiquete POS" Then
                    'Intentar generar el documento.
                    alto_pag = (MetroGrid_det_ventas.RowCount + MetroGrid_imp.RowCount) * 20 + 500
                    Dim pgSize = New iTextSharp.text.Rectangle(205, alto_pag)
                    'Dim doc As New Document(PageSize.A4, 8, 400, 10, 10)
                    Dim doc As New Document(pgSize, 8, 8, 10, 10)

                    'Path que guarda el reporte en el escritorio de windows (Desktop).
                    Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\PREfactura " & Label_consecutivo.Text & ".pdf"
                    Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)

                    PdfWriter.GetInstance(doc, file)
                    doc.Open()
                    ExportarDatosPDF_PRE_POS(doc)
                    doc.Close()
                End If
                If comex_formatofactura = "Media Carta" Then
                    Try
                        Try

                            'sql = "SELECT cantidad as Cant, concat(codprod, '-', producto) as Producto, BASE as Base, impuesto as ICO, impuesto2 as IVA, VALORU, valortotal as ValorTotal FROM ventas_prods WHERE documento = " & CInt(consecutivo) & ""
                            sql = "SELECT cantidad as Cant, concat(codprod, '-', producto) as Producto, impuesto2 as Impuesto, VALORU, valortotal as ValorTotal FROM ventas_prods_TEMP WHERE documento = " & CInt(Label_consecutivo.Text) & ""

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
                        da.Dispose()
                        dt_imprimir_prods.Dispose()

                        'Intentar generar el documento.
                        Dim doc As New Document(PageSize.A4, 20, 20, 20, 20)

                        If Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) & "\MiClickDerecho Docs\") Then
                            Try
                                My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) & "\MiClickDerecho Docs\")
                            Catch ex As Exception
                                MsgBox(ex.ToString)
                            End Try
                        End If

                        'Path que guarda el reporte en el escritorio de windows (Desktop).
                        Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\PREfactura " & Label_consecutivo.Text & ".pdf"
                        Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)

                        PdfWriter.GetInstance(doc, file)

                        doc.Open()
                        ExportarDatosPDF_PRE_HALF(doc)
                        doc.Close()

                    Catch ex As Exception
                        'Si el intento es fallido, mostrar MsgBox.
                        MessageBox.Show("No se puede generar el documento PDF, Cierre los documentos PDF generados anteriormente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If

            Catch ex As Exception
                'Si el intento es fallido, mostrar MsgBox.
                Me.Cursor = Cursors.Default
                MessageBox.Show("error al imprimir recibo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Dim instance As New Printing.PrinterSettings
            Dim impresosaPredt As String = instance.PrinterName

            'imprimir
            If comex_formatofactura = "Tiquete POS" Then
                Process.Start("C:\Program Files\Tracker Software\PDF Viewer\pdfxcview.exe", " /print:printer=""" & impresosaPredt & """ """ & Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\PREfactura " & Label_consecutivo.Text & ".pdf" & """")
            End If
            'ver
            If comex_formatofactura = "Media Carta" Then
                Process.Start("C:\Program Files\Tracker Software\PDF Viewer\pdfxcview.exe", """" & Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\PREfactura " & Label_consecutivo.Text & ".pdf" & """")
            End If



        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Form_Main.Timer_comanda.Enabled = True
        CONTINUE_PREVENTA_COD = Label_consecutivo.Text

        Button1.Visible = True

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button_COBRAR.Image = My.Resources.cash

        Panel_derecha.Visible = True

        Panel_TOTAL.Visible = False
        dataGrid_detalleprodsVENTA.Enabled = True
    End Sub

    Private Sub TextBox_cant_TextChanged(sender As Object, e As EventArgs) Handles TextBox_cant.TextChanged

    End Sub

    Private Sub BOTON_product_Click(sender As Object, e As EventArgs)


        'seleccionar producto




        Dim btn_prod As Button = CType(sender, Button)


        Label_lcd.Text = btn_prod.Text.ToString
        CONSULTAR_PRODUCTO("CODIGO", btn_prod.Name)

        Button_mas.Visible = True : Button_menos.Visible = True
        PictureBox_OK.Visible = True
        TextBox_cant.Visible = True
        'Try
        '    For i As Integer = 0 To datagrid_prodlist.RowCount - 1
        '        If datagrid_prodlist.Item("cod", i).Value = btn_prod.Name.ToString Then Me.Label_infoPrecio.Text = datagrid_prodlist.Item("valor", i).Value

        '    Next
        'Catch ex As Exception
        '    MsgBox(ex.Message.ToString)
        'End Try
        'Me.Label_infoPrecio.Text = Format(CDec(Me.Label_infoPrecio.Text), "##,##0")


    End Sub

    Private Sub Button_ayuda_Click(sender As Object, e As EventArgs) Handles Button_ayuda.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            ' System.Diagnostics.Process.Start("C:\Archivos de PRograma\Internet Explorer\iexplorer.exe", "www.google.com")
            Dim pag As String
            pag = "http://www.miclickderecho.com/ayudaventas.html"
            Shell("Explorer " & pag)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ComboBox_Cuentas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Cuentas.SelectedIndexChanged

    End Sub

    Private Sub BOTON_lab_prod_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Timer_LcdOff_Tick(sender As Object, e As EventArgs) Handles Timer_LcdOff.Tick
        Timer_LcdOff.Enabled = False
        Label_lcd.Text = "Seleccione una Opción"
    End Sub

    Private Sub Textbox_buscar_prod_OnValueChanged(sender As Object, e As EventArgs) Handles Textbox_buscar_prod.OnValueChanged

        dataGrid_detalleprodsVENTA.ClearSelection()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Label_consecutivo.Text = "" Then
            Exit Sub
        End If



        FormDomicilio.Show()
        FormDomicilio.BringToFront()
        FormDomicilio.TopMost = True

        VENTAS_DOMICILIO_ID_VENTA = Label_consecutivo.Text
        FormDomicilio.Label_consecutivoVENTA.Text = Label_consecutivo.Text



    End Sub

    Private Sub Textbox_buscar_prod_KeyDown(sender As Object, e As KeyEventArgs) Handles Textbox_buscar_prod.KeyDown



        If e.KeyCode = Keys.Enter Then
            If Label_estado.Text = "Caja Disponible" Then
                Exit Sub
            End If

            If Me.Textbox_buscar_prod.Text.ToString = "" Then MsgBox("Debe Escribir un nombre de producto.", vbInformation) : Me.Cursor = Cursors.Default : Exit Sub

            prod_barras = "" : prod_cod = "" : prod_nom = "" : prod_desc = "" : PROD_CATEGORIA = "" : prod_imagen = ""
            prod_iva = "" : prod_valor = "" : prod_lote = ""


            Button_mas.Visible = True : Button_menos.Visible = True : TextBox_cant.Visible = True : PictureBox_OK.Visible = True

            Grid_PRODS_RESULT.DataSource = Nothing
            Grid_PRODS_RESULT.Refresh()

            My.Application.DoEvents()




            Try
                Dim colum As String = ""
                If RadioButton_Nombre.Checked = True Then colum = "nombre"
                If RadioButton_codProd.Checked = True Then colum = "cod"
                If RadioButton_barras.Checked = True Then colum = "codbarras"

                'busca en inventario sin lote
                If PERMISO__general(3) = "NO" Then
                    If colum = "nombre" Then sql = "SELECT PRODUCTOS.COD, 
                    concat(productos.categoria,'  | ',PRODUCTOS.NOMBRE,' ',productos.ref,' ',productos.presentacion) as fullname, 
                    ifnull(sum(bodega_" & comex_bodega_ventas & ".entran)-sum(bodega_" & comex_bodega_ventas & ".salen),0) as Unds,
                    productos.*, 
                    productos_categorias.impventa,productos_categorias.impinv,productos_categorias.impcosto,productos_categorias.impdev
                    FROM productos 
                    left join bodega_" & comex_bodega_ventas & "
                    on productos.cod=bodega_" & comex_bodega_ventas & ".codproducto
                    left join productos_categorias
                    on productos.categoria=productos_categorias.categoria
                    where productos.estado='ACTIVO' and " & colum & " like '%" & Textbox_buscar_prod.Text & "%' 
                    and productos.tipo in('SERVICIOS','PRODUCTOS')
                    group by PRODUCTOS.cod
                    ORDER BY CATEGORIA, NOMBRE"
                    If colum = "cod" Then sql = "SELECT PRODUCTOS.COD, 
                    concat(productos.categoria,'  | ',PRODUCTOS.NOMBRE,' ',productos.ref,' ',productos.presentacion) as fullname, 
                    ifnull(sum(bodega_" & comex_bodega_ventas & ".entran)-sum(bodega_" & comex_bodega_ventas & ".salen),0) as Unds,
                    productos.*, 
                    productos_categorias.impventa,productos_categorias.impinv,productos_categorias.impcosto,productos_categorias.impdev
                    FROM productos 
                    left join bodega_" & comex_bodega_ventas & "
                    on productos.cod=bodega_" & comex_bodega_ventas & ".codproducto
                    left join productos_categorias
                    on productos.categoria=productos_categorias.categoria
                    where productos.estado='ACTIVO' and " & colum & "='" & Textbox_buscar_prod.Text & "' 
                    and productos.tipo in('SERVICIOS','PRODUCTOS')
                    group by PRODUCTOS.cod
                    ORDER BY CATEGORIA, NOMBRE"
                    If colum = "codbarras" Then sql = "SELECT PRODUCTOS.COD, 
                    concat(productos.categoria,'  | ',PRODUCTOS.NOMBRE,' ',productos.ref,' ',productos.presentacion) as fullname, 
                    ifnull(sum(bodega_" & comex_bodega_ventas & ".entran)-sum(bodega_" & comex_bodega_ventas & ".salen),0) as Unds,
                    productos.*, 
                    productos_categorias.impventa,productos_categorias.impinv,productos_categorias.impcosto,productos_categorias.impdev
                    FROM productos 
                    left join bodega_" & comex_bodega_ventas & "
                    on productos.cod=bodega_" & comex_bodega_ventas & ".codproducto
                    left join productos_categorias
                    on productos.categoria=productos_categorias.categoria
                    where productos.estado='ACTIVO' and " & colum & "='" & Textbox_buscar_prod.Text & "' 
                    and productos.tipo in('SERVICIOS','PRODUCTOS')
                    group by PRODUCTOS.cod
                    ORDER BY CATEGORIA, NOMBRE"
                End If

                '                'busca todo
                If PERMISO__general(3) = "SI" Then
                    If colum = "nombre" Then sql = "select 
                    cod, concat(productos.categoria,'  | ',PRODUCTOS.NOMBRE,' ',productos.ref,' ',productos.presentacion) as fullname,
                    productos.*
                    from productos where nombre like '%" & Textbox_buscar_prod.Text & "%' and productos.tipo in('SERVICIOS','PRODUCTOS') and estado='ACTIVO' order by fullname, cod"
                    If colum = "cod" Then sql = "select 
                    cod, concat(productos.categoria,'  | ',PRODUCTOS.NOMBRE,' ',productos.ref,' ',productos.presentacion) as fullname,
                    productos.*
                    from productos where cod ='" & Textbox_buscar_prod.Text & "' and productos.tipo in('SERVICIOS','PRODUCTOS') and estado='ACTIVO' order by fullname, cod"
                    If colum = "codbarras" Then sql = "select 
                    cod, concat(productos.categoria,'  | ',PRODUCTOS.NOMBRE,' ',productos.ref,' ',productos.presentacion) as fullname,
                    productos.*
                    from productos where codbarras='" & Textbox_buscar_prod.Text & "' and productos.tipo in('SERVICIOS','PRODUCTOS') and estado='ACTIVO' order by fullname, cod"
                End If

                da_prodlist = New MySqlDataAdapter(sql, conex)
                DT_prodlist = New DataTable
                da_prodlist.Fill(DT_prodlist)
                If DT_prodlist.Rows.Count = 0 Then
                    ' si no encontro productos
                    Grid_PRODS_RESULT.Visible = False
                    My.Application.DoEvents()
                    Exit Sub
                End If
                Me.Grid_PRODS_RESULT.DataSource = DT_prodlist
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da_prodlist.Dispose()
            DT_prodlist.Dispose()
            conex.Close()

            Grid_PRODS_RESULT.Visible = True

            Me.Grid_PRODS_RESULT.Columns(0).Visible = False
            Me.Grid_PRODS_RESULT.Columns(1).HeaderText = "Producto"
            Me.Grid_PRODS_RESULT.Columns(1).Width = 200
            Me.Grid_PRODS_RESULT.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.Grid_PRODS_RESULT.Columns(1).DefaultCellStyle.WrapMode = DataGridViewTriState.True


            If PERMISO__general(3) = "SI" Then Me.Grid_PRODS_RESULT.Columns(2).Visible = False
            Me.Grid_PRODS_RESULT.Columns(3).Visible = False
            Me.Grid_PRODS_RESULT.Columns(4).Visible = False
            Me.Grid_PRODS_RESULT.Columns(5).Visible = False
            Me.Grid_PRODS_RESULT.Columns(6).Visible = False
            Me.Grid_PRODS_RESULT.Columns(7).Visible = False
            Me.Grid_PRODS_RESULT.Columns(8).Visible = False
            Me.Grid_PRODS_RESULT.Columns(9).Visible = False
            Me.Grid_PRODS_RESULT.Columns(10).Visible = False
            Me.Grid_PRODS_RESULT.Columns(11).Visible = False
            Me.Grid_PRODS_RESULT.Columns(12).Visible = False
            Me.Grid_PRODS_RESULT.Columns(13).Visible = False
            Me.Grid_PRODS_RESULT.Columns(14).Visible = False
            Me.Grid_PRODS_RESULT.Columns(15).Visible = False
            Me.Grid_PRODS_RESULT.Columns(16).Visible = False
            Me.Grid_PRODS_RESULT.Columns(17).Visible = False
            Me.Grid_PRODS_RESULT.Columns(18).Visible = False
            Me.Grid_PRODS_RESULT.Columns(19).Visible = False
            Me.Grid_PRODS_RESULT.Columns(20).Visible = False
            Me.Grid_PRODS_RESULT.Columns(21).Visible = False
            Me.Grid_PRODS_RESULT.Columns(22).Visible = False
            Me.Grid_PRODS_RESULT.Columns(23).Visible = False
            Me.Grid_PRODS_RESULT.Columns(24).Visible = False
            Me.Grid_PRODS_RESULT.Columns(25).Visible = False
            Me.Grid_PRODS_RESULT.Columns(26).Visible = False
            Me.Grid_PRODS_RESULT.Columns(27).Visible = False

            Me.Grid_PRODS_RESULT.Columns(28).Visible = False
            Me.Grid_PRODS_RESULT.Columns(29).Visible = False
            Me.Grid_PRODS_RESULT.Columns(30).Visible = False
            Me.Grid_PRODS_RESULT.Columns(31).Visible = False
            Me.Grid_PRODS_RESULT.Columns(32).Visible = False
            Me.Grid_PRODS_RESULT.Columns(33).Visible = False
            Me.Grid_PRODS_RESULT.Columns(34).Visible = False
            Me.Grid_PRODS_RESULT.Columns(35).Visible = False
            Me.Grid_PRODS_RESULT.Columns(36).Visible = False
            Me.Grid_PRODS_RESULT.Columns(37).Visible = False

            Me.Grid_PRODS_RESULT.Columns(38).Visible = False
            Me.Grid_PRODS_RESULT.Columns(39).Visible = False
            Me.Grid_PRODS_RESULT.Columns(40).Visible = False
            Me.Grid_PRODS_RESULT.Columns(41).Visible = False
            Me.Grid_PRODS_RESULT.Columns(42).Visible = False
            If PERMISO__general(3) = "NO" Then Me.Grid_PRODS_RESULT.Columns(43).Visible = False
            If PERMISO__general(3) = "NO" Then Me.Grid_PRODS_RESULT.Columns(44).Visible = False
            If PERMISO__general(3) = "NO" Then Me.Grid_PRODS_RESULT.Columns(45).Visible = False
            If PERMISO__general(3) = "NO" Then Me.Grid_PRODS_RESULT.Columns(46).Visible = False
            If PERMISO__general(3) = "NO" Then Me.Grid_PRODS_RESULT.Columns(47).Visible = False

            Me.Grid_PRODS_RESULT.BringToFront()
            Me.Grid_PRODS_RESULT.Visible = True

            PANEL_prods_result.Visible = True
            FlowLayout_MULTIPANEL.Visible = False
            Grid_PRODS_RESULT.Focus()

            dataGrid_detalleprodsVENTA.ClearSelection()


        End If


    End Sub


    Private Sub Textbox_buscar_prod_LostFocus(sender As Object, e As EventArgs) Handles Textbox_buscar_prod.LostFocus
        Label_lcd.Text = "Seleccione una Opción"

    End Sub

    ' <-------- BUSCAR cateorias y productos >




    ' ------- buscar por nombre  por teclado
    Private Sub Textbox_buscar_prod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Textbox_buscar_prod.KeyPress

        If Label_consecutivo.Text = "" Then
            e.KeyChar = ""
        End If

        If agregando <> "" Then Label_lcd.Text = ""

        dataGrid_detalleprodsVENTA.ClearSelection()

        button_Quitar_Prod.Enabled = False
        Button_modificarprecio.Enabled = False
        Button_modificar_cant.Enabled = False
    End Sub

    Private Sub Textbox_buscar_prod_GotFocus(sender As Object, e As EventArgs) Handles Textbox_buscar_prod.GotFocus

        dataGrid_detalleprodsVENTA.ClearSelection()
        datagrid_prodlist.ClearSelection()

        button_Quitar_Prod.Enabled = False
        Button_modificarprecio.Enabled = False
        Button_modificar_cant.Enabled = False
    End Sub


    Private Sub Grid_PRODS_RESULT_SelectionChanged(sender As Object, e As EventArgs) Handles Grid_PRODS_RESULT.SelectionChanged
        If agregando = "SI" Then Exit Sub

        If Grid_PRODS_RESULT.RowCount = 0 Then
            Exit Sub
        End If

        If Not IsDBNull(Grid_PRODS_RESULT.Item("cod", 0).Value) Then

            Dim row_prod As DataGridViewRow = Grid_PRODS_RESULT.CurrentRow



            prod_barras = row_prod.Cells("codbarras").Value
            prod_cod = row_prod.Cells("cod").Value


            'CONSULTAR_PRODUCTO("codigo")

            prod_nom = row_prod.Cells("nombre").Value
            prod_desc = row_prod.Cells("descripcion").Value
            prod_iva = row_prod.Cells("iva").Value
            prod_iva2 = row_prod.Cells("iva2").Value
            PROD_IVATIPO = row_prod.Cells("ivaTIPO").Value
            PROD_IVATIPO2 = row_prod.Cells("ivaTIPO2").Value
            prod_iva1nom = row_prod.Cells("impnom1").Value
            prod_iva2nom = row_prod.Cells("impnom2").Value
            prod_valor = row_prod.Cells("valor").Value
            prod_valor2 = row_prod.Cells("valor2").Value
            prod_valor3 = row_prod.Cells("valor3").Value
            prod_costo = row_prod.Cells("costo").Value
            prod_tipo = row_prod.Cells("tipo").Value
            prod_kit = row_prod.Cells("kit").Value
            prod_costo_prom = prod_costo

            PROD_CATEGORIA = row_prod.Cells("CATEGORIA").Value
            prod_imagen = row_prod.Cells("imagen").Value
            PROD_INVENTARIADO = row_prod.Cells("INVENTARIADO").Value
            prod_stock = row_prod.Cells("STOCK").Value
            prod_decimal = row_prod.Cells("decimales").Value
            prod_cocina = row_prod.Cells("cocina").Value
            prod_parrilla = row_prod.Cells("parrilla").Value
            prod_bar = row_prod.Cells("bar").Value

            If PERMISO__general(3) = "NO" Then

                PROD_CANT = row_prod.Cells("Unds").Value
                SALDO_DEL_PRODUCTO = row_prod.Cells("Unds").Value

            End If
            If PERMISO__general(3) = "SI" Then
                PROD_CANT = 0
                SALDO_DEL_PRODUCTO = 0
            End If

            If prod_decimal = "SI" Then
                Numeric_cant.Visible = True
                TextBox_cant.Visible = False
            Else
                Numeric_cant.Visible = False
                TextBox_cant.Visible = True
            End If



            'If Not IsDBNull(row_prod.Cells("impventa").Value) Then prod_cta_vender = row_prod.Cells("impventa").Value Else prod_cta_vender = "41"
            'If Not IsDBNull(row_prod.Cells("impinv").Value) Then prod_cta_inventariar = row_prod.Cells("impinv").Value Else prod_cta_inventariar = "14"
            'If Not IsDBNull(row_prod.Cells("impcosto").Value) Then prod_cta_costear = row_prod.Cells("impcosto").Value Else prod_cta_costear = "61"
            'If Not IsDBNull(row_prod.Cells("impdev").Value) Then prod_cta_devolver = row_prod.Cells("impdev").Value Else prod_cta_devolver = "4175"



            prod_alerta = row_prod.Cells("alerta").Value

            'SALDO_DEL_PRODUCTO = row_prod.Cells("UNDS").Value

            '----------------------------------------------------------------
            If comex_listaprecios = "Precio 1" Then prod_valor = prod_valor
            If comex_listaprecios = "Precio 2" Then prod_valor = prod_valor2
            If comex_listaprecios = "Precio 3" Then prod_valor = prod_valor3
            '----------------------------------------------------------------   paso el pecio configurado


            Me.Label_lcd.Text = row_prod.Cells("fullname").Value & "  --->  $ " & prod_valor &
            vbNewLine & prod_desc

            'Me.Label_infoProd.Text = prod_nom
            'Me.Label_infoPrecio.Text = prod_valor
            'If prod_imagen <> "" Then
            '    Try
            '        PictureBox_IMAGENPROD.Image = Drawing.Image.FromFile(prod_imagen)
            '    Catch ex As Exception
            '        PictureBox_IMAGENPROD.Image = Nothing
            '    End Try
            'Else
            '    PictureBox_IMAGENPROD.Image = Nothing

            'End If


        End If


    End Sub

    Private Sub Grid_PRODS_RESULT_KeyDown(sender As Object, e As KeyEventArgs) Handles Grid_PRODS_RESULT.KeyDown
        If e.KeyCode = Keys.Right Then
            TextBox_cant.Text = TextBox_cant.Text + 1
        End If
        If e.KeyCode = Keys.Left Then
            TextBox_cant.Text = TextBox_cant.Text - 1
            If TextBox_cant.Text < 0 Then TextBox_cant.Text = "0"
        End If


        If e.KeyCode = Keys.Enter Then
            'TextBox_buscarPROD.Text = prod_cod

            e.SuppressKeyPress = True
            Button_mas.Visible = False : Button_menos.Visible = False : TextBox_cant.Visible = False : PictureBox_OK.Visible = False


            If Grid_PRODS_RESULT.RowCount = 0 Then
                Exit Sub
            End If

            If Not IsDBNull(Grid_PRODS_RESULT.Item("cod", 0).Value) Then

                Dim row_prod As DataGridViewRow = Grid_PRODS_RESULT.CurrentRow



                prod_barras = row_prod.Cells("codbarras").Value
                prod_cod = row_prod.Cells("cod").Value


                'CONSULTAR_PRODUCTO("codigo")

                prod_nom = row_prod.Cells("nombre").Value
                prod_desc = row_prod.Cells("descripcion").Value
                prod_iva = row_prod.Cells("iva").Value
                prod_iva2 = row_prod.Cells("iva2").Value
                PROD_IVATIPO = row_prod.Cells("ivaTIPO").Value
                PROD_IVATIPO2 = row_prod.Cells("ivaTIPO2").Value
                prod_iva1nom = row_prod.Cells("impnom1").Value
                prod_iva2nom = row_prod.Cells("impnom2").Value
                prod_valor = row_prod.Cells("valor").Value
                prod_valor2 = row_prod.Cells("valor2").Value
                prod_valor3 = row_prod.Cells("valor3").Value
                prod_costo = row_prod.Cells("costo").Value
                prod_tipo = row_prod.Cells("tipo").Value
                prod_kit = row_prod.Cells("kit").Value
                prod_costo_prom = prod_costo

                PROD_CATEGORIA = row_prod.Cells("CATEGORIA").Value
                prod_imagen = row_prod.Cells("imagen").Value
                PROD_INVENTARIADO = row_prod.Cells("INVENTARIADO").Value
                prod_stock = row_prod.Cells("STOCK").Value
                prod_decimal = row_prod.Cells("decimales").Value
                prod_cocina = row_prod.Cells("cocina").Value
                prod_parrilla = row_prod.Cells("parrilla").Value
                prod_bar = row_prod.Cells("bar").Value



                If prod_decimal = "SI" Then
                    Numeric_cant.Visible = True
                    TextBox_cant.Visible = False
                Else
                    Numeric_cant.Visible = False
                    TextBox_cant.Visible = True
                End If



                'If Not IsDBNull(row_prod.Cells("impventa").Value) Then prod_cta_vender = row_prod.Cells("impventa").Value Else prod_cta_vender = "41"
                'If Not IsDBNull(row_prod.Cells("impinv").Value) Then prod_cta_inventariar = row_prod.Cells("impinv").Value Else prod_cta_inventariar = "14"
                'If Not IsDBNull(row_prod.Cells("impcosto").Value) Then prod_cta_costear = row_prod.Cells("impcosto").Value Else prod_cta_costear = "61"
                'If Not IsDBNull(row_prod.Cells("impdev").Value) Then prod_cta_devolver = row_prod.Cells("impdev").Value Else prod_cta_devolver = "4175"



                prod_alerta = row_prod.Cells("alerta").Value

                'SALDO_DEL_PRODUCTO = row_prod.Cells("UNDS").Value

                '----------------------------------------------------------------
                If comex_listaprecios = "Precio 1" Then prod_valor = prod_valor
                If comex_listaprecios = "Precio 2" Then prod_valor = prod_valor2
                If comex_listaprecios = "Precio 3" Then prod_valor = prod_valor3
                '----------------------------------------------------------------   paso el pecio configurado


                Me.Label_lcd.Text = row_prod.Cells("fullname").Value & "  --->  $ " & prod_valor &
            vbNewLine & prod_desc

                'Me.Label_infoProd.Text = prod_nom
                'Me.Label_infoPrecio.Text = prod_valor
                'If prod_imagen <> "" Then
                '    Try
                '        PictureBox_IMAGENPROD.Image = Drawing.Image.FromFile(prod_imagen)
                '    Catch ex As Exception
                '        PictureBox_IMAGENPROD.Image = Nothing
                '    End Try
                'Else
                '    PictureBox_IMAGENPROD.Image = Nothing

                'End If


            End If



            CONSULTAR_PRODUCTO("CODIGO", prod_cod)

            If prod_valor = "" Then Exit Sub

            agregando = "SI"

            If PROD_INVENTARIADO = "SI" Then

                Try
                    BUSCA_SALDO_PRODUCTO_aqui()
                    BUSCA_SALDO_PRODUCTO()
                    If SALDO_DEL_PRODUCTO < TextBox_cant.Text And PERMISO__general(3) = "NO" Then
                        Me.Textbox_buscar_prod.Text = ""
                        Me.Textbox_buscar_prod.Focus()
                        Me.Label_lcd.Text = "No están permitidas las ventas sin existencias. EL Inventario no registra existencias de este producto, por favor revise la cantidad."

                        agregando = "NO"
                        TextBox_cant.Text = 1
                        'Textbox_buscar_prod.Focus()
                        Exit Sub
                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString)

                End Try







            End If



            Try
                agregar_1_prod()

                Me.Textbox_buscar_prod.Text = ""
                Label_lcd.Text = ""
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try



            Fill_ProdsSale(Label_consecutivo.Text)

            dataGrid_detalleprodsVENTA.Visible = True
            dataGrid_detalleprodsVENTA.ClearSelection()
            PANEL_prods_result.Visible = False
            FlowLayout_MULTIPANEL.Visible = True
            agregando = "NO"
            TextBox_cant.Text = 1
            Label_lcd.Text = ""
            Textbox_buscar_prod.Focus()

        End If




        If e.KeyCode = Keys.Escape Then
            PANEL_prods_result.Visible = False
            FlowLayout_MULTIPANEL.Visible = True
            Grid_PRODS_RESULT.DataSource = Nothing

            Button_mas.Visible = False : Button_menos.Visible = False : PictureBox_OK.Visible = False
            TextBox_cant.Visible = False
            dataGrid_detalleprodsVENTA.ClearSelection()

            Textbox_buscar_prod.Focus()

        End If


    End Sub

    Private Sub Grid_PRODS_RESULT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Grid_PRODS_RESULT.KeyPress

    End Sub


    Private Sub Grid_PRODS_RESULT_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid_PRODS_RESULT.CellContentClick

    End Sub
    ' ----- buscar por nombre  por teclado




    ' mesero
    Private Sub ComboBox_mesero_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_mesero.SelectedIndexChanged

    End Sub

    Private Sub ComboBox_mesero_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_mesero.SelectionChangeCommitted
        If ComboBox_mesero.SelectedItem.ToString <> "" Then
            PictureBox_back_mesero.Visible = True

            sql = "UPDATE ventas_pre SET empleadocod='" & CStr(ComboBox_mesero.SelectedValue) & "', empleado='" & CStr(ComboBox_mesero.Text) & "' WHERE DOCUMENTO='" & Label_consecutivo.Text & "'"
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


        End If

    End Sub

    Private Sub PictureBox_back_mesero_Click(sender As Object, e As EventArgs) Handles PictureBox_back_mesero.Click
        PictureBox_back_mesero.Visible = False
        ComboBox_mesero.SelectedItem = Nothing
    End Sub

    'mesero





    ' grid detalle venta
    Private Sub dataGrid_detalleprods_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGrid_detalleprodsVENTA.CellClick
        Dim row_prod_sel As DataGridViewRow = dataGrid_detalleprodsVENTA.CurrentRow

        prod_cod_sel = ""
        prod_cons_Sel = ""
        prod_nom_sel = ""
        prod_CANT_sel = ""

        Button_modificarprecio.Enabled = False
        button_Quitar_Prod.Enabled = False
        Button_modificar_cant.Enabled = False

        Try
            prod_cod_sel = CStr(row_prod_sel.Cells("CODPROD").Value) ' LLAVE PRINCIPAL
            prod_cons_Sel = CStr(row_prod_sel.Cells("cons").Value) ' LLAVE PRINCIPAL
            prod_nom_sel = CStr(row_prod_sel.Cells("PRODUCTO").Value) ' LLAVE PRINCIPAL
            prod_CANT_sel = CStr(row_prod_sel.Cells("CANTIDAD").Value) ' LLAVE PRINCIPAL
            prod_PRECIO_sel = CStr(row_prod_sel.Cells("VALORU").Value) ' LLAVE PRINCIPAL

            Button_modificarprecio.Enabled = True
            button_Quitar_Prod.Enabled = True
            Button_modificar_cant.Enabled = True
        Catch ex As Exception
            Label_lcd.Text = "Error seleccionando producto de la venta"
        End Try


    End Sub

    Private Sub dataGrid_detalleprods_LostFocus(sender As Object, e As EventArgs) Handles dataGrid_detalleprodsVENTA.LostFocus
        'Button_modificarprecio.Enabled = False
        'button_Quitar_Prod.Enabled = False
        'Button_modificar_cant.Enabled = False
        dataGrid_detalleprodsVENTA.ClearSelection()

    End Sub

    Private Sub dataGrid_detalleprods_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGrid_detalleprodsVENTA.CellContentClick

    End Sub
    '  grid detalle veNta


    'opciones
    Private Sub button_Quitar_Prod_Click(sender As Object, e As EventArgs) Handles button_Quitar_Prod.Click
        If prod_cons_Sel = "" Then MsgBox("Debe Seleccionar un producto.", vbInformation) : Exit Sub

        Dim RTA As String
        RTA = MsgBox("Desea eliminar el producto?." & vbNewLine & vbNewLine & prod_nom_sel, MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If RTA = 6 Then
            sql = "delete from VENTAS_PRODS_TEMP where cons=" & CInt(prod_cons_Sel) & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
                Me.Label_lcd.Text = "Se Borró el producto..."

            Catch ex As Exception
                Me.Label_lcd.Text = "error Borrando el producto..."
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()
        End If
        prod_cod_sel = ""
        prod_nom_sel = ""
        prod_cons_Sel = ""

        Fill_ProdsSale(Label_consecutivo.Text)

        dataGrid_detalleprodsVENTA.ClearSelection()

        button_Quitar_Prod.Enabled = False
        Button_modificar_cant.Enabled = False
        Button_modificarprecio.Enabled = False
    End Sub
    Private Sub TextBox_TOTAL_CUENTA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_TOTAL_pagar.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub Button_COBRAR_Click(sender As Object, e As EventArgs) Handles Button_COBRAR.Click

        'If Button_COBRAR.Text = "Regresar" Then
        '    Button_COBRAR.Text = "Cobrar"
        '    Button_COBRAR.Image = My.Resources.cash

        '    Panel_derecha.Visible = True

        '    Panel_TOTAL.Visible = False
        '    dataGrid_detalleprodsVENTA.Enabled = True

        '    Exit Sub
        'End If
        BunifuCheckbox_propina.Checked = False



        If Label_consecutivo.Text = "" Then Exit Sub
        Panel_TOTAL.Visible = True
        Panel_TOTAL.BringToFront()
        Panel_derecha.Visible = False

        Try
            sql = "SELECT tipo, mediopago FROM medios_pago
where tipo<>'CREDITO' order by cons"
            da_COMBO_MEDIOS_PAGO = New MySqlDataAdapter(sql, conex)
            dt_COMBO_MEDIOS_PAGO = New DataTable
            da_COMBO_MEDIOS_PAGO.Fill(dt_COMBO_MEDIOS_PAGO)
            Me.ListBox1.DataSource = dt_COMBO_MEDIOS_PAGO.DefaultView
            Me.ListBox1.DisplayMember = "mediopago"
            Me.ListBox1.ValueMember = "tipo"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_COMBO_MEDIOS_PAGO.Dispose()
        dt_COMBO_MEDIOS_PAGO.Dispose()
        conex.Close()


        If ListBox1.Items.Count = 0 Then
            Button_ok.Visible = False
            Exit Sub
        End If

        dataGrid_detalleprodsVENTA.Enabled = False


        Button_COBRAR.ImageList = ImageList_imgs
        Button_COBRAR.ImageIndex = 0

        ListBox1.SelectedIndex = 0
        ListBox1_SelectedIndexChanged(Nothing, Nothing)

        'ComboBox_Cuentas_SelectionChangeCommitted(Nothing, Nothing)

        TextBox_efectivo.Text = TextBox_TOTAL_pagar.Text
        Me.TextBox_efectivo.Focus()

        Me.TextBox_efectivo.SelectAll()
    End Sub
    Private Sub Button_pagar_ok_Click(sender As Object, e As EventArgs) Handles Button_ok.Click

        If Not MEDIO_PAGO_DESTINO_NOMBRE.Contains("CREDITO") Then
            If ComboBox_Cuentas.Text.ToString = Nothing Then
                MsgBox("no existen cuentas registradas para el medio de pago " & MEDIO_PAGO_DESTINO_NOMBRE)
                Exit Sub
            End If




        End If

        If MEDIO_PAGO_DESTINO_NOMBRE.Contains("CREDITO") Then


            Try
                sql = "SELECT sum(c.valor) as creditos,  
sum((SELECT IFNULL(SUM(VALOR),0) FROM RECIBOS_CAJA rc1 WHERE rc1.referencia=c.CONSECUTIVO AND rc1.Concepto='Cuenta Por Cobrar')) AS abonos,
(select p.CupoCredito  from proveedores p where p.Documento='" & Textbox_Cliente_Doc.Text & "') as cupocredito
FROM carteracredito c where c.tipo='CARTERA' and c.estado ='PENDIENTE' and c.ClienteDoc ='" & Textbox_Cliente_Doc.Text & "'"
                da = New MySqlDataAdapter(sql, conex)
                dt_clientes = New DataTable
                da.Fill(dt_clientes)


                Dim cupo As String = 0
                Dim creditos As String = 0
                Dim abonos As String = 0
                Dim saldo As String = 0
                For Each row As DataRow In dt_clientes.Rows
                    creditos = row.Item("creditos")
                    abonos = row.Item("abonos")
                    cupo = row.Item("cupocredito")

                Next
                saldo = creditos - abonos


                If CInt(cupo) > 0 Then
                    If CInt(cupo) <= CInt(saldo) Then
                        Dim RTA As String

                        RTA = MsgBox("El cliente alcanzó el límite de crédito: $" & vbNewLine & "Cupo Asignado: " & cupo & vbNewLine & "Deuda Actual: " & saldo & vbNewLine & vbNewLine & "Desea Continuar con la venta ???", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
                        If RTA = 6 Then
                            'continua
                        Else
                            Exit Sub
                        End If
                    End If

                End If
            Catch ex As Exception

            End Try
        End If


        If cli_doc = "" Or cli_nom = "" Then

            cli_doc = "1"
            cli_nom = "CLIENTE CONTADO"
        End If


        If TextBox_Total_impuestos.Text > 0 Then
            factura_con_imp = True
        End If

        If CInt(TextBox_TOTALVENTA.Text) = 0 Then
            MsgBox("hola")
            Exit Sub
        End If

        If dataGrid_detalleprodsVENTA.RowCount = 0 Then
            MsgBox("hola")
            Exit Sub
        End If

        que_imprime = "venta"

        total_esta_venta = TextBox_TOTALVENTA.Text
        descuento = TextBox_DESCUENTO.Text
        subtotal = TextBox_SUBTOTAL.Text
        baseimpuesto = TextBox_BASEimp.Text
        impuesto = TextBox_impuesto.Text
        impuesto2 = TextBox_impuesto2.Text
        totalapagar = TextBox_TOTAL_pagar.Text


        medio_de_pago = MEDIO_PAGO_DESTINO_NOMBRE
        IMP_MEDIODEPAGO = medio_de_pago


        Cursor.Current = Cursors.WaitCursor
        Try
            'FINALIZAR_VENTA()
            '****************   finalizar venta ********************************

            consecutivo = 0
            cmd.Connection = conex
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select max(documento) + 1 from VENTAS"
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

            If turno_actualfecha = "" Then turno_actualfecha = DateTime.Now.ToShortDateString

            sql = "INSERT INTO VENTAS (res, documento, tipoDocumento, DocCliente, ClienteNom, fecha, MESA, MESERO, TOTALVENTA, DESCUENTO, BASEIMPUESTO, IMPUESTO, IMPUESTO2, TOTAL, mediodepago, fechapago, empleadoCod, empleado, turno, Estado, domicilio, DOMICILIARIO, domiciliovr, propina, salon, cambio,observaciones,hora) 
VALUES ('" & comex_Resdian & "'," & CLng(consecutivo) & ",'VENTAS','" & CStr(cli_doc) & "','" & CStr(cli_nom) & "','" & turno_actualfecha & "','" & Label_mesa.Text & "','" & ComboBox_mesero.Text & "'," & total_esta_venta & "," & descuento & "," & baseimpuesto & "," & impuesto & "," & impuesto2 & "," & totalapagar & ",'" & medio_de_pago & "','" & fecha_de_pago & "','" & usrdoc & "','" & usrnom & "'," & CInt(turno_actual_global_ID) & ",'DESCARGADO','" & consecutivo_domicilios & "','','0','" & TextBox_propina.Text & "','Seccion 1','" & TextBox_efectivo.Text & "|" & Label_cambio_VR.Text & "','" & TextBox_observaciones.Text & "', '" & Label_hr.Text & "')"
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


            For J As Integer = 0 To MetroGrid_dctos.RowCount - 1
                sql = "insert into ventas_dctos (documento,codprod, producto, valortotal, estado) 
values('" & consecutivo & "','','" & CStr(MetroGrid_dctos.Item("PRODUCTO", J).Value) & "','" & CStr(MetroGrid_dctos.Item("valortotal", J).Value) & "','DESCARGADO')"
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                Try
                    da.Fill(dt)
                    Me.Cursor = Cursors.Default
                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    MsgBox(ex.ToString)
                End Try
                da.Dispose()
                dt.Dispose()
                conex.Close()

                sql = "UPDATE domicilios set cuenta='', factura='" & consecutivo & "' "
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                Try
                    da.Fill(dt)
                    Me.Cursor = Cursors.Default
                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    MsgBox(ex.ToString)
                End Try
                da.Dispose()
                dt.Dispose()
                conex.Close()
            Next


            'GUARDAR LA CUENTA DE COBRO

            If medio_de_pago.Contains("CREDITO") = True Then
                'CONSECUTIVO
                consecutivo_CXC = 0
                cmd.Connection = conex
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "select max(cast(CONSECUTIVO as signed)) + 1 from carteracredito WHERE TIPO='CARTERA'"
                conex.Open()
                Try
                    dr_consecutivos = cmd.ExecuteReader()
                    If dr_consecutivos.Read() Then
                        consecutivo_CXC = dr_consecutivos(0)
                    Else
                        consecutivo_CXC = 1
                    End If
                Catch ex As Exception
                    consecutivo_CXC = 1
                    conex.Close()
                End Try
                conex.Close()

                Try
                    sql = "SELECT * FROM proveedores where DOCUMENTO='" & CStr(cli_doc) & "'"
                    da = New MySqlDataAdapter(sql, conex)
                    dt_clientes = New DataTable
                    da.Fill(dt_clientes)
                    For Each row As DataRow In dt_clientes.Rows
                        cli_nom = row.Item("nombre")

                    Next
                Catch ex As Exception

                End Try


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
        VALUES(" & CLng(consecutivo_CXC) & ",'CARTERA','" & turno_actualfecha & "','" & CStr(cli_doc) & "','" & CStr(cli_nom) & "','FACTURA DE VENTA','" & consecutivo & "','VENTA A CREDITO','" & totalapagar & "','" & totalapagar & "','" & DateTimePicker_FECHAPAGO.Value.ToShortDateString & "','" & usrnom & "','PENDIENTE')"
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
            End If





            If PERMISO__general(6) = "SI" Then
                'GUARDA EN CAJA
                'guardar mov
                sql = "INSERT INTO CAJA (turno, fecha, documento, tipoDocumento, subtotal, descuento, total, mediodepago, EmpleadoDoc, empleado, estado) 
VALUES ('" & turno_actual_global & "','" & turno_actualfecha & "'," & consecutivo & ",'VENTA'," & total_esta_venta & "," & descuento & "," & totalapagar & ",'" & medio_de_pago & "','" & CStr(usrdoc) & "','" & usrnom & "','DESCARGADO')"
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


            Me.Cursor = Cursors.WaitCursor
            Try
                For J As Integer = 0 To dataGrid_detalleprodsVENTA.RowCount - 1
                    PROD_ENTRAN = 0
                    PROD_SALDO = 0
                    PROD_SALDO = 0
                    PROD_SALEN = 0
                    Dim saldo As String
                    Dim inv_prodCod As Integer
                    Dim inv_prodCant As String
                    Dim inv_prodNom, INV_PROD_INVENTARIADO, INV_PROd_dec, inv_prod_lote, inv_prod_VENCE As String
                    inv_prod_lote = ""
                    inv_prodNom = CStr(dataGrid_detalleprodsVENTA.Item("PRODUCTO", J).Value)
                    inv_prodCant = dataGrid_detalleprodsVENTA.Item("cantidad", J).Value
                    inv_prodCod = CInt(dataGrid_detalleprodsVENTA.Item("CodProd", J).Value.ToString)
                    INV_PROD_INVENTARIADO = CStr(dataGrid_detalleprodsVENTA.Item("INVENTARIADO", J).Value.ToString)
                    INV_PROd_dec = CStr(dataGrid_detalleprodsVENTA.Item("deci", J).Value)
                    inv_prod_lote = CStr(dataGrid_detalleprodsVENTA.Item("LOTE", J).Value)
                    inv_prod_VENCE = CStr(dataGrid_detalleprodsVENTA.Item("VENCE", J).Value)

                    inv_prod_cta_vender = CStr(dataGrid_detalleprodsVENTA.Item("cta_vender", J).Value)
                    inv_prod_cuenta_inventariar = CStr(dataGrid_detalleprodsVENTA.Item("cta_inventariar", J).Value)
                    inv_prod_cuenta_costear = CStr(dataGrid_detalleprodsVENTA.Item("cta_costear", J).Value)
                    inv_prod_cuenta_devolver = CStr(dataGrid_detalleprodsVENTA.Item("cta_devolver", J).Value)

                    'saldo                 (solo se descargan de inventario los productos)  

                    saldo = 0

                    PROD_SALEN = inv_prodCant  ' TOMO LA CANTIDAD DEL GRID Q ESTA RECORRIENDO
                    PROD_SALDO = saldo  ' IGUALDO SALDO PROD CON EL SALDO CALCULADO EN BODEGA PRICIPAL

                    PROD_ENTRAN = 0 ' POR QUE QUE ES UNA venta
                    '________________________________________________________________________________________________________________________

                    If INV_PROD_INVENTARIADO = "SI" And CStr(dataGrid_detalleprodsVENTA.Item("KIT", J).Value) <> "SI" Then  ' CONFIRMO SI EL PRODUCTO MANEJA INVENTARIOS
                        Dim rol As String = ""
                        rol = "SALEN"
                        sql = "INSERT INTO bodega_" & comex_bodega_ventas & " (fecha, CodBodega, NomBodega, TipoDocumento, Documento, tercero, Rol, CodProducto, Producto, saldoant, ENTRAN ,Salen, Saldo, valoru, valortotal, Empleado, Estado, DECI, COSTO, LOTE, VENCE) 
VALUES ('" & turno_actualfecha & "',1,'PRINCIPAL','VENTA'," & CInt(consecutivo) & ",'" & CStr(cli_doc & "|" & cli_nom) & "','SALEN'," & CInt(inv_prodCod) & ",'" & inv_prodNom.ToString & "','" & saldo & "','" & PROD_ENTRAN & "','" & PROD_SALEN & "','" & PROD_SALDO & "','" & CInt(dataGrid_detalleprodsVENTA.Item("valoru", J).Value) & "','" & CDec(dataGrid_detalleprodsVENTA.Item("valortotal", J).Value) & "','" & usrnom & "','DESCARGADO','" & INV_PROd_dec & "','" & CDec(dataGrid_detalleprodsVENTA.Item("COSTO", J).Value) / inv_prodCant & "','" & inv_prod_lote & "','" & inv_prod_VENCE & "')"
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

                        ' AQUI PUEDE IR EL UPDATE DE COSTEADO
                    End If

                    'DESACRGAR LOS PRODUCTOS DEL KITTTTTTTTTTTTTT
                    If CStr(dataGrid_detalleprodsVENTA.Item("kit", J).Value) = "SI" Then

                        sql = "SELECT PRODUCTOS_KIT.CONS, 
PRODUCTOS_KIT.CODKIT, 
PRODUCTOS_KIT.CODPROD,
PRODUCTOS_KIT.PRODUCTO,
PRODUCTOS_KIT.CANTIDAD,
PRODUCTOS.COSTO FROM PRODUCTOS_KIT
INNER JOIN PRODUCTOS ON
PRODUCTOS_KIT.CODPROD=PRODUCTOS.COD
WHERE CODKIT='" & CStr(inv_prodCod) & "'"
                        da_INV_KIT = New MySqlDataAdapter(sql, conex)
                        DT_INV_KIT = New DataTable
                        Try
                            da_INV_KIT.Fill(DT_INV_KIT)
                            Me.DataGrid_kit.DataSource = DT_INV_KIT
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try
                        da_INV_KIT.Dispose()
                        DT_INV_KIT.Dispose()
                        conex.Close()

                        For k As Integer = 0 To DataGrid_kit.RowCount - 1

                            saldo = 0

                            PROD_SALEN = CStr(DataGrid_kit.Item("cantidad", k).Value) * CInt(inv_prodCant)
                            PROD_SALDO = saldo  ' IGUALDO SALDO PROD CON EL SALDO CALCULADO EN BODEGA PRICIPAL
                            PROD_SALDO = CDec(PROD_SALDO) - CDec(PROD_SALEN) ' PROD_ENTRAN   '  ACUMULO
                            PROD_ENTRAN = 0 ' POR QUE QUE ES UNA venta
                            '________________________________________________________________________________________________________________________

                            Dim rol As String = ""
                            Dim COSTO_KIT_UND As String = CLng(DataGrid_kit.Item("COSTO", k).Value)
                            Dim COSTO_KIT_UND_TTAL As String = CDec(DataGrid_kit.Item("COSTO", k).Value) * CDec(DataGrid_kit.Item("CANTIDAD", k).Value)

                            rol = "SALEN"
                            sql = "INSERT INTO bodega_" & comex_bodega_ventas & " (fecha, CodBodega, NomBodega, TipoDocumento, Documento, tercero, Rol, CodProducto, Producto, saldoant, ENTRAN ,Salen, Saldo, valoru, valortotal, Empleado, Estado, DECI, COSTO, LOTE, VENCE) 
VALUES ('" & turno_actualfecha & "',1,'" & comex_bodega_ventas & "','VENTA'," & CInt(consecutivo) & ",'" & CStr(cli_doc & "|" & cli_nom) & "','SALEN'," & CStr(DataGrid_kit.Item("CODPROD", k).Value) & ",'" & CStr(DataGrid_kit.Item("producto", k).Value) & "','" & saldo & "','" & PROD_ENTRAN & "','" & PROD_SALEN & "','" & PROD_SALDO & "','" & COSTO_KIT_UND_TTAL & "','" & CDec(CDec(COSTO_KIT_UND_TTAL) * CDec(inv_prodCant)) & "','" & usrnom & "','DESCARGADO','" & INV_PROd_dec & "','" & CStr(DataGrid_kit.Item("COSTO", k).Value) & "','" & inv_prod_lote & "','" & inv_prod_VENCE & "')"
                            da_KIT = New MySqlDataAdapter(sql, conex)
                            DT_KIT = New DataTable
                            Try
                                da_KIT.Fill(DT_KIT)
                            Catch ex As Exception
                                If ex.ToString.Contains("Duplicate entry") Then MsgBox("Error al INSERTAR EN KARDEX DE BODEGA", vbExclamation)
                                MsgBox(ex.ToString)
                            End Try
                            da_KIT.Dispose()
                            DT_KIT.Dispose()
                            conex.Close()
                        Next

                    End If
                    ' fin kit  ======================================================================================


                    sql = "INSERT INTO ventas_prods (documento, codprod, producto, cantidad, base, imp, IMP2, impuesto, IMPUESTO2, valoru, valortotal, estado,  inventariado, IMPNOM1, IMPNOM2, deci, costo, idbodega, lote) 
VALUES(" & CInt(consecutivo) & "," & CInt(dataGrid_detalleprodsVENTA.Item("CODPROD", J).Value) & ",'" & CStr(dataGrid_detalleprodsVENTA.Item("PRODUCTO", J).Value) & "','" & inv_prodCant & "'," & CInt(dataGrid_detalleprodsVENTA.Item("base", J).Value) & ",'" & CInt(dataGrid_detalleprodsVENTA.Item("imp", J).Value) & "','" & CInt(dataGrid_detalleprodsVENTA.Item("imp2", J).Value) & "'," & CInt(dataGrid_detalleprodsVENTA.Item("impuesto", J).Value) & "," & CInt(dataGrid_detalleprodsVENTA.Item("impuesto2", J).Value) & "," & CInt(dataGrid_detalleprodsVENTA.Item("valoru", J).Value) & "," & CInt(dataGrid_detalleprodsVENTA.Item("valortotal", J).Value) & ",'DESCARGADO','" & CStr(dataGrid_detalleprodsVENTA.Item("INVENTARIADO", J).Value) & "','" & CStr(dataGrid_detalleprodsVENTA.Item("IMPNOM1", J).Value) & "','" & CStr(dataGrid_detalleprodsVENTA.Item("IMPNOM2", J).Value) & "','" & CStr(dataGrid_detalleprodsVENTA.Item("deci", J).Value) & "','" & CStr(dataGrid_detalleprodsVENTA.Item("costo", J).Value) & "','" & CStr(dataGrid_detalleprodsVENTA.Item("idbodega", J).Value) & "','" & inv_prod_lote & "')"
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




                    Me.Cursor = Cursors.WaitCursor

                Next
            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try




            '================================================================================================



            PROD_ENTRAN = CInt(totalapagar)
            PROD_SALDO = saldo
            PROD_SALDO = CInt(PROD_SALDO) + CInt(PROD_ENTRAN)
            PROD_SALEN = 0



            MEDIO_PAGO_DESTINO_COD = ComboBox_Cuentas.SelectedValue & "|" & ComboBox_Cuentas.Text

            Dim pago() As String
            pago = Strings.Split(MEDIO_PAGO_DESTINO_COD, "|")
            'MEDIO DE Pgo
            sql = "INSERT INTO cajaspuc(Codcuenta, cuenta, TERCERO, Fecha, Documento, TipoDoc, Rol, SaldoAnt, debe, haber, Saldo, DETALLE, Estado, annoactual)" &
           "VALUES ('" & pago(0) & "','" & pago(1) & "','" & Textbox_Cliente_Doc.Text & "|" & Textbox_Cliente_Nom.Text & "','" & turno_actualfecha & "','" & consecutivo & "','FACTURA DE VENTA','ENTRAN'," & saldo & "," & PROD_ENTRAN & "," & PROD_SALEN & "," & PROD_SALDO & ",'FACTURA DE VENTA','DESCARGADO','" & comex_annoactual & "')"
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




            sql = "delete from ventas_pre where DOCUMENTO=" & CInt(Label_consecutivo.Text) & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                MsgBox("error al Borrar el Registro Invima.")
                Exit Sub
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()

            sql = "delete from ventas_prods_Temp where documento=" & CInt(Label_consecutivo.Text) & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                MsgBox("error al Borrar el Registro Invima.")
                Exit Sub
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()

            sql = "delete from ventas_dctos_temp where documento='" & Label_consecutivo.Text & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                MsgBox(ex.ToString)
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()
            Me.Cursor = Cursors.WaitCursor

            Me.Cursor = Cursors.Default

            fact_saveok = 1

            'cargo productos de la ventapara impr
            Try

                sql = "SELECT concat(codprod, '-', producto) as Producto, cantidad as Cant, IMP as IMP1, imp2 as IMP2, valortotal as ValorTotal FROM ventas_prods WHERE documento = " & CInt(consecutivo) & ""

                Da_IMPRIMIRPRODS = New MySqlDataAdapter(sql, conex)
                dt_imprimir_prods = New DataTable
                Da_IMPRIMIRPRODS.Fill(dt_imprimir_prods)
                Me.DataGridView1.DataSource = dt_imprimir_prods

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            Da_IMPRIMIRPRODS.Dispose()
            dt_imprimir_prods.Dispose()



            ' si imprime
            If CheckBox_print.CheckState = CheckState.Checked Then
                If comex_formatofactura = "Tiquete POS" Then
                    If BunifuCheckbox_propina.Checked = True Then
                        imp_propina = TextBox_propina.Text
                    Else
                        imp_propina = ""
                    End If

                    imp_titulo1 = comex_nombrecomercial
                    imp_dir = comex_dircomercio
                    imp_tels = comex_tels
                    imp_propietario = comex_nombrepropietario
                    imp_regimen = comex_regimen
                    imp_nit = comex_nit & "-" & comex_DV
                    imp_resdian = comex_Resdian
                    imp_intervalo = comex_intervalo
                    imp_factunum = consecutivo
                    imp_fecha_factu = DateTime.Now.ToShortDateString
                    imp_hora_factu = DateTime.Now.ToShortTimeString

                    'imp_prod, imp_cant, imp_vrtotal, 
                    imp_totalVenta = total_esta_venta
                    imp_Descuento = descuento
                    imp_subtotal = subtotal
                    'Imp_baseimp = baseimpuesto
                    'imp_impuesto = impuesto
                    imp_totalapagar = totalapagar
                    imp_efectivo = Me.TextBox_efectivo.Text
                    imp_cambio = Me.Label_cambio_VR.Text
                    imp_cajero = USR_NOM
                    imp_mesero = ComboBox_mesero.Text
                    Try
                        sql = "SELECT CodProd, Producto, 
concat('x',cantidad), format(valoru,0), concat('$',format(valortotal,0))
from ventas_prods
WHERE documento='" & consecutivo & "'"
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
where ventas.documento='" & consecutivo & "'
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
                        Try
                            alto_pag = ((MetroGrid_det_ventas.RowCount + MetroGrid_imp.RowCount) * 10) + 500
                            Dim pgSize = New iTextSharp.text.Rectangle(205, alto_pag)

                            Dim doc As New Document(pgSize, 8, 8, 10, 10)

                            'Path que guarda el reporte en el escritorio de windows (Desktop).
                            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\factura " & consecutivo & ".pdf"
                            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)

                            PdfWriter.GetInstance(doc, file)
                            doc.Open()
                            ExportarDatosPDF_POS(doc)
                            doc.Close()
                            'Process.Start(filename)
                        Catch ex As Exception
                            'Si el intento es fallido, mostrar MsgBox.
                            Me.Cursor = Cursors.Default
                            MessageBox.Show("error al imprimir recibo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try


                        Dim instance As New Printing.PrinterSettings
                        Dim impresosaPredt As String = instance.PrinterName

                        Process.Start("C:\Program Files\Tracker Software\PDF Viewer\pdfxcview.exe", " /print:printer=""" & impresosaPredt & """ """ & Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\factura " & consecutivo & ".pdf" & """")


                    Catch ex As Exception

                    End Try



                    'Try
                    '    'Intentar generar el documento.
                    '    Dim doc As New Document(PageSize.A4, 10, 20, 10, 10)
                    '    'Path que guarda el reporte en el escritorio de windows (Desktop).
                    '    Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\domicilio" & consecutivo & ".pdf"
                    '    Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
                    '    PdfWriter.GetInstance(doc, file)
                    '    doc.Open()
                    '    ExportarDatosPDF_DIMICILIO(doc)
                    '    doc.Close()
                    '    Process.Start(filename)
                    'Catch ex As Exception
                    '    'Si el intento es fallido, mostrar MsgBox.
                    '    MessageBox.Show("No se puede generar el documento PDF, Cierre los documentos PDF generados anteriormente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'End Try



                End If

                If comex_formatofactura = "Media Carta" Then
                    imp_totalVenta = total_esta_venta
                    imp_Descuento = descuento
                    imp_subtotal = subtotal
                    'Imp_baseimp = baseimpuesto
                    'imp_impuesto = impuesto
                    imp_totalapagar = totalapagar
                    Button_EXPORTAR_mediacarta()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            Panel_derecha.Visible = True

            Panel_TOTAL.Visible = False
            Button_COBRAR.Text = "Cobrar"
            Button_COBRAR.Image = My.Resources.cash

            'limpiar variables y todo

        End Try

        If CheckBox_print.Checked = False Then
            PrintDocument1.Print()
        End If

        ListBox1.SelectedIndex = 0
        CLEAN_FLOW()
        Label_consecutivo.Text = "" : Label_consecutivo.BackColor = Color.PaleGreen
        Label_mesa.Text = "" : Label_mesa.BackColor = Color.PaleGreen
        Label_estado.Text = "Caja Disponible" : Label_estado.BackColor = Color.PaleGreen : Label_estado.ForeColor = Color.Black

        dataGrid_detalleprodsVENTA.DataSource = Nothing

        Button_nueva_cuenta.Visible = True : Button_nueva_cuenta.Enabled = True
        Button_anular_cuenta.Enabled = False
        TextBox_TOTAL_pagar.Text = 0


        dataGrid_detalleprodsVENTA.Enabled = True


        PictureBox_opcion_cliente_Click(Nothing, Nothing)


        Cursor.Current = Cursors.WaitCursor

    End Sub
    Public Sub ExportarDatosPDF_DIMICILIO(ByVal document As Document)

        'Dim contentFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 12, iTextSharp.text.Font.BOLD)
        'Dim DIRFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 5, iTextSharp.text.Font.BOLD)
        'Dim FIRMAFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 6, iTextSharp.text.Font.BOLD)
        'Dim OBSRVFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 6, iTextSharp.text.Font.BOLD)

        ''Se crea el encabezado en el PDF.
        'Dim PDF_COMEX As New Paragraph(comex_nombrecomercial, contentFont) : PDF_COMEX.Alignment = 2
        'PDF_COMEX.Font = contentFont
        'Dim PDF_COMEX_DIR As New Paragraph(comex_dircomercio + " " + comex_ciudad + " " + comex_tels, DIRFont) : PDF_COMEX_DIR.Alignment = 2
        'PDF_COMEX_DIR.Font = DIRFont

        'Dim PDF_CONSECUTIVO As New Paragraph("No. " & consecutivo, New Font(Font.Name = "Arial Black", 8, Font.Bold = True)) : PDF_CONSECUTIVO.Alignment = 2
        'Dim encabezado As New Paragraph("DOMICILIO", New Font(Font.Name = "Arial Black", 8, Font.Bold = True)) : encabezado.Alignment = 2
        'Dim encabezado2 As New Paragraph("Fecha:" + DateTime.Now.ToShortDateString & " " & DateTime.Now.ToLongTimeString, New Font(Font.Name = "Arial Balck", 8, Font.Bold)) : encabezado2.Alignment = 2

        'Dim glue = New Chunk(New VerticalPositionMark())
        'Dim texto_CLIENTE As New Paragraph("Cliente: " + Me.Textbox_Cliente_Nom.Text.ToString + " Documento/NIT: " + Textbox_Cliente_Nom.Text, New Font(Font.Name = "Arial Narrow", 7, Font.Bold = True))
        'texto_CLIENTE.Add(New Chunk(glue))
        'texto_CLIENTE.Add(comex_nit & " " & comex_regimen)
        'texto_CLIENTE.SpacingBefore = 5

        'Dim texto_dirCLIENTE As New Paragraph("Dirección:  " + Me.Textbox_Cliente_Dir.Text.ToString + " Teléfono: " + Textbox_Cliente_Tel1.Text, New Font(Font.Name = "Arial Narrow", 7, Font.Bold = True))
        'texto_dirCLIENTE.Add(New Chunk(glue))
        'texto_dirCLIENTE.Add(comex_Resdian)








        'Dim texto_resp As New Paragraph("Responsable: ", New Font(Font.Name = "Arial Narrow", 7, Font.Bold = True))
        'texto_resp.Add(New Chunk(glue))
        'texto_resp.Add("-")

        ''Dim descuento As New Paragraph("", New Font(Font.Name = "Arial Black", 7, Font.Bold = True))
        ''descuento.Add(New Chunk(glue))
        ''descuento.Add("Descuento ")
        ''descuento.IndentationLeft = 350
        ''descuento.Alignment = Element.ALIGN_RIGHT
        ''descuento.Add(New Chunk(glue))
        ''descuento.Add("0" & " ")
        ''descuento.SpacingBefore = 3

        ''Dim subtotal As New Paragraph("", New Font(Font.Name = "Arial Black", 7, Font.Bold = True))
        ''subtotal.Add(New Chunk(glue))
        ''subtotal.Add("SubTotal ")
        ''subtotal.IndentationLeft = 349
        ''subtotal.Alignment = Element.ALIGN_RIGHT
        ''subtotal.Add(New Chunk(glue))
        ''subtotal.Add(TextBoxbaseimp.Text & " ")

        ''Dim impuestos As New Paragraph("", New Font(Font.Name = "Arial Black", 7, Font.Bold = True))
        ''impuestos.Add(New Chunk(glue))
        ''impuestos.Add("Impuestos ")
        ''impuestos.IndentationLeft = 368
        ''impuestos.Alignment = Element.ALIGN_RIGHT
        ''impuestos.Add(New Chunk(glue))
        ''impuestos.Add(TextBoximp.Text & " ")

        'Dim total_fac As New Paragraph("", New Font(Font.Name = "Arial Black", 9, Font.Bold = True))
        'total_fac.Add(New Chunk(glue))
        'total_fac.Add("Total ")
        'total_fac.IndentationLeft = 359
        'total_fac.Alignment = Element.ALIGN_RIGHT
        'total_fac.Add(New Chunk(glue))
        'total_fac.Add(TextBoxDomicilioVr.Text & " ")

        'Dim PDF_mensajero As New Paragraph("Mensajero: " & ComboBox_mensajro.Text, FIRMAFont) : PDF_mensajero.Alignment = 0
        'Dim PDF_nrofact As New Paragraph("#Factura: " & TextBox_factura.Text, FIRMAFont) : PDF_mensajero.Alignment = 0
        'Dim pdf_Observaciones As New Paragraph("Observaciones: " & TextBox_observaciones.Text, OBSRVFont) : PDF_mensajero.Alignment = 0

        ''Dim saltoDeLinea = New Paragraph("                                                                                          ")

        'Dim PDF_FIRMACLIENTE As New Paragraph("FIRMA CLIENTE:____________________", FIRMAFont) : PDF_FIRMACLIENTE.Alignment = 0
        'PDF_FIRMACLIENTE.Font = FIRMAFont

        'Dim texto2 As New Phrase("Generado en: " + Now.Date(), New Font(Font.Name = "Arial Narrow", 5, Font.Bold))
        'Dim texto3 As New Phrase("  Por: " + usrnom, New Font(Font.Name = "Arial Narrow", 5, Font.Bold))

        ''LOGO
        'If comex_logo <> "" Then
        '    Dim imagelogogopdf As iTextSharp.text.Image 'Declaracion de una imagen

        '    imagelogogopdf = iTextSharp.text.Image.GetInstance("c:\miclickderecho\logo.png") 'Dirreccion a la imagen que se hace referencia
        '    imagelogogopdf.Alignment = Element.ALIGN_RIGHT
        '    imagelogogopdf.SetAbsolutePosition(10, 785) 'Posicion en el eje cartesiano
        '    imagelogogopdf.ScaleAbsoluteWidth(140) 'Ancho de la imagen
        '    imagelogogopdf.ScaleAbsoluteHeight(55) 'Altura de la imagen
        '    document.Add(imagelogogopdf) ' Agrega la imagen al documento
        'End If
        ''Se agrega el PDFTable al documento.

        'Dim CUADRO1 As iTextSharp.text.Image 'Declaracion de una imagen
        'CUADRO1 = iTextSharp.text.Image.GetInstance("c:\miclickderecho\cuadro_para_portadas2.png") 'Dirreccion a la imagen que se hace referencia
        'CUADRO1.Alignment = Element.ALIGN_RIGHT
        'CUADRO1.SetAbsolutePosition(414, 762) 'Posicion en el eje cartesiano
        'CUADRO1.ScaleAbsoluteWidth(168) 'Ancho de la imagen
        'CUADRO1.ScaleAbsoluteHeight(43) 'Altura de la imagen
        'document.Add(CUADRO1) ' Agrega la imagen al documento

        'Dim CUADRO_cliente As iTextSharp.text.Image 'Declaracion de una imagen
        'CUADRO_cliente = iTextSharp.text.Image.GetInstance("c:\miclickderecho\cuadro_para_portadas2.png") 'Dirreccion a la imagen que se hace referencia
        'CUADRO_cliente.Alignment = Element.ALIGN_LEFT
        'CUADRO_cliente.SetAbsolutePosition(5, 714) 'Posicion en el eje cartesiano
        'CUADRO_cliente.ScaleAbsoluteWidth(350) 'Ancho de la imagen
        'CUADRO_cliente.ScaleAbsoluteHeight(54) 'Altura de la imagen
        'document.Add(CUADRO_cliente) ' Agrega la imagen al documento

        'Dim CUADRO_subtotal As iTextSharp.text.Image 'Declaracion de una imagen
        'CUADRO_subtotal = iTextSharp.text.Image.GetInstance("c:\miclickderecho\fondopanel.png") 'Dirreccion a la imagen que se hace referencia
        'CUADRO_subtotal.Alignment = Element.ALIGN_LEFT
        'CUADRO_subtotal.SetAbsolutePosition(6, 500) 'Posicion en el eje cartesiano
        'CUADRO_subtotal.ScaleAbsoluteWidth(574) 'Ancho de la imagen
        'CUADRO_subtotal.ScaleAbsoluteHeight(200) 'Altura de la imagen

        ''document.Add(CUADRO_subtotal) ' Agrega la imagen al documento


        'document.Add(PDF_COMEX)
        'document.Add(PDF_COMEX_DIR)
        'document.Add(encabezado)
        'document.Add(PDF_CONSECUTIVO)
        'document.Add(encabezado2)
        'document.Add(texto_CLIENTE)
        'document.Add(texto_dirCLIENTE)
        'document.Add(texto_mailCLIENTE)
        'document.Add(texto_resp)
        ''DataTable.SpacingBefore = 15
        ''document.Add(DataTable)
        ''document.Add(descuento)
        ''document.Add(subtotal)
        ''document.Add(impuestos)
        'document.Add(total_fac)
        ''document.Add(saltoDeLinea)
        'document.Add(PDF_mensajero)
        'document.Add(PDF_nrofact)

        'document.Add(PDF_FIRMACLIENTE)
        'document.Add(texto2)
        'document.Add(texto3)


    End Sub
    Private Sub Button_modificar_cant_Click(sender As Object, e As EventArgs) Handles Button_modificar_cant.Click
        If prod_cons_Sel = "" Then MsgBox("Debe Seleccionar un producto.", vbInformation) : Exit Sub

        CONSULTAR_PRODUCTO("CODIGO", prod_cod_sel)

        cambiando_CANTIDAD = "SI"
        PictureBox_OK.Visible = True
        Button_mas.Visible = True
        Button_menos.Visible = True
        TextBox_cant.Visible = True
    End Sub
    'opciones 




    ' IMPRIMIR PREFACTURA ------------------------------------>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If PERMISO__general(10) = "SI" Then
            Button1.Visible = False
            Exit Sub
        End If


        If Label_consecutivo.Text = "" Then Exit Sub

        'If BunifuCheckbox_propina.Checked = True Then
        '    imp_propina = TextBox_propina.Text
        'Else
        '    imp_propina = ""
        'End If

        imp_titulo1 = comex_nombrecomercial
        imp_dir = comex_dircomercio
        imp_tels = comex_tels
        imp_propietario = comex_nombrepropietario
        imp_regimen = comex_regimen
        imp_nit = comex_nit & "-" & comex_DV
        imp_resdian = comex_Resdian
        imp_intervalo = comex_intervalo
        imp_factunum = Label_consecutivo.Text
        imp_fecha_factu = DateTime.Now.ToShortDateString
        imp_hora_factu = DateTime.Now.ToShortTimeString

        'imp_prod, imp_cant, imp_vrtotal, 
        imp_totalVenta = TextBox_TOTAL_pagar.Text
        'imp_Descuento = TextBox_DESCUENTO.Text
        imp_subtotal = imp_subtotal
        'Imp_baseimp = baseimpuesto
        'imp_impuesto = impuesto
        imp_totalapagar = TextBox_TOTAL_pagar.Text
        imp_efectivo = "?"
        imp_cambio = "?"
        imp_cajero = usrnom

        Try
            sql = "SELECT CodProd, Producto, 
concat('x',cantidad), format(valoru,0), concat('$',format(valortotal,0))
from ventas_prods_temp
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
            sql = "SELECT  ventas_prods_temp.ImpNom2 as IMPUESTO, CONCAT('$',format(sum(ventas_prods_temp.valortotal-ventas_prods_temp.impuesto2),0)) as BASE, CONCAT('$',format(sum(ventas_prods_temp.impuesto2),0)) as VrIMP, CONCAT('$',format(sum(ventas_prods_temp.valortotal),0)) as VrTOTAL
FROM ventas_prods_temp
left join ventas_pre on ventas_prods_temp.documento=ventas_pre.documento
where ventas_pre.documento='" & Label_consecutivo.Text & "'
group by ventas_prods_temp.impnom2"
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
            Try
                If comex_formatofactura = "Tiquete POS" Then
                    'Intentar generar el documento.
                    alto_pag = (MetroGrid_det_ventas.RowCount + MetroGrid_imp.RowCount) * 20 + 500
                    Dim pgSize = New iTextSharp.text.Rectangle(205, alto_pag)
                    'Dim doc As New Document(PageSize.A4, 8, 400, 10, 10)
                    Dim doc As New Document(pgSize, 8, 8, 10, 10)

                    'Path que guarda el reporte en el escritorio de windows (Desktop).
                    Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\PREfactura " & Label_consecutivo.Text & ".pdf"
                    Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)

                    PdfWriter.GetInstance(doc, file)
                    doc.Open()
                    ExportarDatosPDF_PRE_POS(doc)
                    doc.Close()
                End If
                If comex_formatofactura = "Media Carta" Then
                    Try
                        Try

                            'sql = "SELECT cantidad as Cant, concat(codprod, '-', producto) as Producto, BASE as Base, impuesto as ICO, impuesto2 as IVA, VALORU, valortotal as ValorTotal FROM ventas_prods WHERE documento = " & CInt(consecutivo) & ""
                            sql = "SELECT cantidad as Cant, concat(codprod, '-', producto) as Producto, impuesto2 as Impuesto, VALORU, valortotal as ValorTotal FROM ventas_prods_TEMP WHERE documento = " & CInt(Label_consecutivo.Text) & ""

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
                        da.Dispose()
                        dt_imprimir_prods.Dispose()

                        'Intentar generar el documento.
                        Dim doc As New Document(PageSize.A4, 20, 20, 20, 20)

                        If Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) & "\MiClickDerecho Docs\") Then
                            Try
                                My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) & "\MiClickDerecho Docs\")
                            Catch ex As Exception
                                MsgBox(ex.ToString)
                            End Try
                        End If

                        'Path que guarda el reporte en el escritorio de windows (Desktop).
                        Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\PREfactura " & Label_consecutivo.Text & ".pdf"
                        Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)

                        PdfWriter.GetInstance(doc, file)

                        doc.Open()
                        ExportarDatosPDF_PRE_HALF(doc)
                        doc.Close()

                    Catch ex As Exception
                        'Si el intento es fallido, mostrar MsgBox.
                        MessageBox.Show("No se puede generar el documento PDF, Cierre los documentos PDF generados anteriormente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If

            Catch ex As Exception
                'Si el intento es fallido, mostrar MsgBox.
                Me.Cursor = Cursors.Default
                MessageBox.Show("error al imprimir recibo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Dim instance As New Printing.PrinterSettings
            Dim impresosaPredt As String = instance.PrinterName

            'imprimir
            If comex_formatofactura = "Tiquete POS" Then
                Process.Start("C:\Program Files\Tracker Software\PDF Viewer\pdfxcview.exe", " /print:printer=""" & impresosaPredt & """ """ & Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\PREfactura " & Label_consecutivo.Text & ".pdf" & """")
            End If
            'ver
            If comex_formatofactura = "Media Carta" Then
                Process.Start("C:\Program Files\Tracker Software\PDF Viewer\pdfxcview.exe", """" & Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\PREfactura " & Label_consecutivo.Text & ".pdf" & """")
            End If



        Catch ex As Exception

        End Try

    End Sub
    Public Sub ExportarDatosPDF_PRE_HALF(ByVal document As Document)
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

        Dim encabezado As New Paragraph("PREFACTURA     ", encabezadoFontwhite)
        encabezado.Alignment = 2
        encabezado.Font = encabezadoFontwhite

        Dim PDF_CONSECUTIVO As New Paragraph("No.    " & Label_consecutivo.Text + "    ", encabezadoFont)
        PDF_CONSECUTIVO.Alignment = 2
        PDF_CONSECUTIVO.Font = encabezadoFont

        Dim encabezado2 As New Paragraph(DateTime.Now.ToShortDateString + "             ", FontFactory.GetFont("Arial Black", 10, iTextSharp.text.Font.BOLDITALIC)) : encabezado2.Alignment = 2
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
        cellhome.Phrase = New Phrase("", CLIENTEFONT)
        cellhome.HorizontalAlignment = Element.ALIGN_BOTTOM
        tablahome.AddCell(cellhome)
        cellhome.Phrase = New Phrase(comex_nombrecomercial, contentFont)
        cellhome.HorizontalAlignment = Element.ALIGN_RIGHT
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase("DOC/NIT: ", FontFactory.GetFont("Arial Black", 7, iTextSharp.text.Font.BOLDITALIC, BaseColor.WHITE))
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        cellhome.Phrase = New Phrase(imp_clienteDoc, CLIENTEFONT)
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        cellhome.Phrase = New Phrase(comex_razonsocial & " NIT:" & comex_nit & " " & comex_regimen, DIRFont)
        cellhome.HorizontalAlignment = Element.ALIGN_RIGHT
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()


        cellhome.Phrase = New Phrase("Cliente: ", FontFactory.GetFont("Arial Black", 7, iTextSharp.text.Font.BOLDITALIC, BaseColor.WHITE))
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        cellhome.Phrase = New Phrase(Textbox_Cliente_Nom.Text, CLIENTEFONT)
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        cellhome.Phrase = New Phrase(comex_dircomercio + " " + comex_ciudad + " Tel: " + comex_tels, DIRFont2)
        cellhome.HorizontalAlignment = Element.ALIGN_RIGHT
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase("Dirección:  ", FontFactory.GetFont("Arial Black", 7, iTextSharp.text.Font.BOLDITALIC, BaseColor.WHITE))
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        cellhome.Phrase = New Phrase(Textbox_Cliente_Dir.Text, CLIENTEFONT)
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
        cellhome.Phrase = New Phrase(Textbox_Cliente_Nom.Text, DIRFont2)
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
                If j = 0 Then cell.HorizontalAlignment = Element.ALIGN_CENTER
                If j = 1 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 2 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 3 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 4 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                'If j = 5 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                'If j = 6 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                'If j = 7 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                cell.Border = 0
                'cell.BorderWidthRight = 0.3F
                'cell.BorderColorRight = BaseColor.BLACK
                cell.PaddingTop = 3
                datatable.AddCell(cell)
            Next
            datatable.CompleteRow()
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
                    If j = 0 Then cell.HorizontalAlignment = Element.ALIGN_CENTER
                    If j = 1 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                    If j = 2 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                    If j = 3 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                    If j = 4 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                    'If j = 5 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
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
        tabla_PIE.SpacingBefore = 3

        Dim cell_PIE As New PdfPCell
        cell_PIE.BorderWidth = 0

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
        cell_PIE.Phrase = New Phrase(TextBox_SUBTOTAL.Text & " ", totalFont)
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
        cell_PIE.Phrase = New Phrase(TextBox_Total_impuestos.Text, totalFont)
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
        cell_PIE.Phrase = New Phrase(TextBox_TOTAL_pagar.Text, totaltotalFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_PIE.AddCell(cell_PIE)
        tabla_PIE.CompleteRow()

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
        If comex_logo <> "" And File.Exists(comex_logo) = True Then
            Dim imagelogogopdf As iTextSharp.text.Image 'Declaracion de una imagen

            imagelogogopdf = iTextSharp.text.Image.GetInstance(comex_logo) 'Dirreccion a la imagen que se hace referencia
            imagelogogopdf.Alignment = Element.ALIGN_RIGHT
            imagelogogopdf.SetAbsolutePosition(25, 760) 'Posicion en el eje cartesiano
            imagelogogopdf.ScaleAbsoluteWidth(160) 'Ancho de la imagen
            imagelogogopdf.ScaleAbsoluteHeight(68) 'Altura de la imagen
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
        document.Add(CUADRO_total2)
        'document.Add(descuento)
        'document.Add(CUADRO_obs)
        document.Add(endline)

    End Sub
    Public Sub ExportarDatosPDF_PRE_POS(ByVal document As Document)

        Dim fontLINE = iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLD)

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
        If comex_logo <> "" And File.Exists(comex_logo) Then encabezadoLINE.SpacingBefore = 60
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

        cellhome.Phrase = New Phrase(comex_dircomercio & " Tels:" & comex_tels & " " & comex_ciudad, FontFactory.GetFont(FontFactory.COURIER_BOLD, 7, iTextSharp.text.Font.NORMAL))
        cellhome.HorizontalAlignment = Element.ALIGN_CENTER
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        If comex_sitioweb <> "" And comex_email <> "" Then
            cellhome.Phrase = New Phrase(comex_sitioweb & " " & comex_email, FontFactory.GetFont(FontFactory.COURIER_BOLD, 7, iTextSharp.text.Font.NORMAL))
            cellhome.HorizontalAlignment = Element.ALIGN_CENTER
            tablahome.AddCell(cellhome)
            tablahome.CompleteRow()
        End If


        Dim PDF_leyedian1 As New Paragraph("RANGO DE FACTURACION DEL  " & comex_prefijo & "-" & comex_intervalo & " AL " & comex_prefijo & "-" & comex_intervalo2, FontFactory.GetFont(FontFactory.COURIER, 6, iTextSharp.text.Font.BOLD)) : PDF_leyedian1.Alignment = Element.ALIGN_CENTER
        Dim PDF_leyedian2 As New Paragraph("RESOLUCION " & comex_Resdian & " del " & comex_fechadian & Chr(13), FontFactory.GetFont(FontFactory.COURIER, 6, iTextSharp.text.Font.BOLD)) : PDF_leyedian2.Alignment = Element.ALIGN_CENTER



        Dim tabla_turno_data As New PdfPTable(2)
        Dim anchos() As Single = {55, 45}
        tabla_turno_data.SetWidths(anchos)

        tabla_turno_data.WidthPercentage = 100
        tabla_turno_data.DefaultCell.Padding = 0
        tabla_turno_data.DefaultCell.BorderWidth = 0
        tabla_turno_data.SpacingBefore = 0
        tabla_turno_data.HorizontalAlignment = 0
        Dim cellturno As New PdfPCell
        cellturno.BorderWidth = 0

        cellturno.Phrase = New Phrase("<PRE-FACTURA>", FontFactory.GetFont(FontFactory.COURIER_BOLD, 8, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_LEFT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(comex_prefijo & " " & Label_consecutivo.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 8, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("Fecha:" & imp_fecha_factu, FontFactory.GetFont(FontFactory.COURIER_BOLD, 8, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_LEFT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase("Hora:" & imp_hora_factu, FontFactory.GetFont(FontFactory.COURIER_BOLD, 8, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea


        Dim encabezado6 As New Paragraph("Cliente:" & imp_clienteNom, FontFactory.GetFont(FontFactory.COURIER_BOLD, 7.5D, iTextSharp.text.Font.NORMAL)) : encabezado6.Alignment = Element.ALIGN_LEFT
        Dim encabezado_resumenOP As New Paragraph("Doc/NIT:" & imp_clienteDoc, FontFactory.GetFont(FontFactory.COURIER_BOLD, 7.5D, iTextSharp.text.Font.NORMAL)) : encabezado_resumenOP.Alignment = Element.ALIGN_LEFT



        Dim encabezado9 As New Paragraph("Código  |  Producto         ", FontFactory.GetFont(FontFactory.COURIER_BOLD, 6D, iTextSharp.text.Font.NORMAL)) : encabezado9.Alignment = Element.ALIGN_LEFT
        Dim encabezado91 As New Paragraph("xCant   |  Precio              |$ Total", FontFactory.GetFont(FontFactory.COURIER_BOLD, 6D, iTextSharp.text.Font.NORMAL)) : encabezado91.Alignment = Element.ALIGN_LEFT


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

        celltotal.Phrase = New Phrase("SubTotal ---------> $", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        celltotal.HorizontalAlignment = Element.ALIGN_LEFT
        celltotal.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_total.AddCell(celltotal) 'primera col

        celltotal.Phrase = New Phrase(TextBox_SUBTOTAL.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        celltotal.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_total.AddCell(celltotal) ' segunda col
        tabla_total.CompleteRow() ' agrega linea

        celltotal.Phrase = New Phrase("Impuestos --------> $", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        celltotal.HorizontalAlignment = Element.ALIGN_LEFT
        celltotal.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_total.AddCell(celltotal) 'primera col

        celltotal.Phrase = New Phrase(TextBox_Total_impuestos.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        celltotal.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_total.AddCell(celltotal) ' segunda col
        tabla_total.CompleteRow() ' agrega linea

        celltotal.Phrase = New Phrase("Descuentos -------> $", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        celltotal.HorizontalAlignment = Element.ALIGN_LEFT
        celltotal.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_total.AddCell(celltotal) 'primera col

        celltotal.Phrase = New Phrase(TextBox_DESCUENTO.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        celltotal.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_total.AddCell(celltotal) ' segunda col
        tabla_total.CompleteRow() ' agrega linea

        celltotal.Phrase = New Phrase("Serv. Vol. -------> $", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        celltotal.HorizontalAlignment = Element.ALIGN_LEFT
        celltotal.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_total.AddCell(celltotal) 'primera col

        celltotal.Phrase = New Phrase(FormatNumber(TextBox_propina.Text, 0), FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        celltotal.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_total.AddCell(celltotal) ' segunda col
        tabla_total.CompleteRow() ' agrega linea

        celltotal.Phrase = New Phrase("Domicilio --------> $", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        celltotal.HorizontalAlignment = Element.ALIGN_LEFT
        celltotal.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_total.AddCell(celltotal) 'primera col

        celltotal.Phrase = New Phrase("", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        celltotal.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_total.AddCell(celltotal) ' segunda col
        tabla_total.CompleteRow() ' agrega linea

        celltotal.Phrase = New Phrase("TOTAL A PAGAR>>>> $", FontFactory.GetFont(FontFactory.COURIER_BOLD, 10, iTextSharp.text.Font.NORMAL))
        celltotal.HorizontalAlignment = Element.ALIGN_LEFT
        celltotal.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_total.AddCell(celltotal) 'primera col

        celltotal.Phrase = New Phrase(FormatNumber(TextBox_TOTAL_pagar.Text, 0), FontFactory.GetFont(FontFactory.COURIER_BOLD, 10, iTextSharp.text.Font.NORMAL))
        celltotal.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_total.AddCell(celltotal) ' segunda col
        tabla_total.CompleteRow() ' agrega linea

        Dim encabezado_ttal_pago As New Paragraph("MedioPago: ?", FontFactory.GetFont(FontFactory.COURIER, 6D, iTextSharp.text.Font.NORMAL)) : encabezado_ttal_pago.Alignment = Element.ALIGN_RIGHT
        Dim encabezado_ttal_cambio As New Paragraph("Cambio: ?", FontFactory.GetFont(FontFactory.COURIER, 6D, iTextSharp.text.Font.NORMAL)) : encabezado_ttal_cambio.Alignment = Element.ALIGN_RIGHT

        Dim encabezado8 As New Paragraph("Detalle de Impuestos", FontFactory.GetFont(FontFactory.COURIER_BOLD, 6D, iTextSharp.text.Font.NORMAL)) : encabezado8.Alignment = Element.ALIGN_LEFT

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

        Dim encabezado_mesa As New Paragraph("Mesa:" & Label_mesa.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 6D, iTextSharp.text.Font.NORMAL)) : encabezado_mesa.Alignment = Element.ALIGN_LEFT
        Dim encabezado_mesero As New Paragraph("Le Atendió:" & ComboBox_mesero.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 6D, iTextSharp.text.Font.NORMAL)) : encabezado_mesero.Alignment = Element.ALIGN_LEFT

        Dim encabezado_caja As New Paragraph("Cajero:" & usrnom, FontFactory.GetFont(FontFactory.COURIER_BOLD, 6D, iTextSharp.text.Font.NORMAL)) : encabezado_caja.Alignment = Element.ALIGN_LEFT
        Dim encabezado7 As New Paragraph("Se Imprimió el " + DateTime.Now, FontFactory.GetFont(FontFactory.COURIER_BOLD, 5D, iTextSharp.text.Font.NORMAL)) : encabezado7.Alignment = 0
        Dim encabezado_publicidad As New Paragraph("www.MiCliCkDerecho.com Sistemas POS 3165259554.", FontFactory.GetFont(FontFactory.HELVETICA, 5D, iTextSharp.text.Font.NORMAL)) : encabezado7.Alignment = Element.ALIGN_CENTER
        Dim encabezado_domicilio_data As New Paragraph("Entrega Domicilio:", FontFactory.GetFont(FontFactory.COURIER_BOLD, 6D, iTextSharp.text.Font.NORMAL)) : encabezado8.Alignment = Element.ALIGN_LEFT
        Dim encabezado_domicilio_MESAJERO As New Paragraph("Mensajero:", FontFactory.GetFont(FontFactory.COURIER_BOLD, 6D, iTextSharp.text.Font.NORMAL)) : encabezado_domicilio_MESAJERO.Alignment = Element.ALIGN_LEFT

        Dim glue = New Chunk(New VerticalPositionMark())

        document.Add(encabezadoLINE)
        document.Add(tablahome)
        If comex_prefijo <> "" Then document.Add(PDF_leyedian1)
        If comex_prefijo <> "" Then document.Add(PDF_leyedian2)
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
        document.Add(encabezado_mesa)

        document.Add(encabezado_mesero)
        document.Add(encabezado_caja)

        document.Add(encabezadoLINE3)

        document.Add(encabezado7)
        document.Add(encabezado_publicidad)

        'If ComboBox_domiciliario.Text <> "" Then document.Add(encabezado_domicilio_data)
        'If ComboBox_domiciliario.Text <> "" Then document.Add(encabezado_domicilio_MESAJERO)

        document.Add(encabezadoLINE2)

    End Sub
    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        'funcion para obtener el tamaño de la columnas del datagridview
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function

    '  IMPRIMIR PREFACTURA  ---------------------------------


    'imprimir exportar factura
    Public Sub ExportarDatosPDF_POS(ByVal document As Document)

        Dim fontLINE = iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLD)

        Dim encabezadoLINE As New Paragraph("|=======================================|", fontLINE)

        encabezadoLINE.Alignment = 0
        encabezadoLINE.Font = fontLINE
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

        cellhome.Phrase = New Phrase(comex_nombrecomercial, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10, iTextSharp.text.Font.NORMAL))
        cellhome.HorizontalAlignment = Element.ALIGN_CENTER
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase(comex_nombrepropietario, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8, iTextSharp.text.Font.NORMAL))
        cellhome.HorizontalAlignment = Element.ALIGN_CENTER
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase("NIT:" & comex_nit & "-" & comex_DV & " " & comex_regimen, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8, iTextSharp.text.Font.NORMAL))
        cellhome.HorizontalAlignment = Element.ALIGN_CENTER
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase("Tels:" & comex_tels & " - " & comex_cels & " " & comex_dircomercio & " " & comex_ciudad, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 7, iTextSharp.text.Font.NORMAL))
        cellhome.HorizontalAlignment = Element.ALIGN_CENTER
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        If comex_sitioweb <> "" And comex_email <> "" Then
            cellhome.Phrase = New Phrase(comex_sitioweb & " " & comex_email, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 7, iTextSharp.text.Font.NORMAL))
            cellhome.HorizontalAlignment = Element.ALIGN_CENTER
            tablahome.AddCell(cellhome)
            tablahome.CompleteRow()
        End If


        Dim PDF_leyedian1 As New Paragraph("RANGO DE FACTURACION DEL  " & comex_prefijo & "-" & comex_intervalo & " AL " & comex_prefijo & "-" & comex_intervalo2, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 6, iTextSharp.text.Font.BOLD)) : PDF_leyedian1.Alignment = Element.ALIGN_CENTER
        Dim PDF_leyedian2 As New Paragraph("RESOLUCION " & comex_Resdian & " del " & comex_fechadian & Chr(13), FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 6, iTextSharp.text.Font.BOLD)) : PDF_leyedian2.Alignment = Element.ALIGN_CENTER
        Dim TITEL_TERMINAL As New Paragraph("S/N:" & SERIAL_DD & Chr(13), FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 6, iTextSharp.text.Font.BOLD)) : PDF_leyedian2.Alignment = Element.ALIGN_CENTER



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

        cellturno.Phrase = New Phrase(comex_prefijo & "-" & consecutivo, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("Fecha:" & imp_fecha_factu, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_LEFT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase("Hora:" & imp_hora_factu, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        Dim encabezado6 As New Paragraph("Cliente:" & Textbox_Cliente_Nom.Text, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 7.5D, iTextSharp.text.Font.NORMAL)) : encabezado6.Alignment = Element.ALIGN_LEFT
        Dim encabezado_resumenOP As New Paragraph("Doc/NIT:" & Textbox_Cliente_Doc.Text, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 7.5D, iTextSharp.text.Font.NORMAL)) : encabezado_resumenOP.Alignment = Element.ALIGN_LEFT


        Dim encabezado9 As New Paragraph("Código  |  Producto         ", FontFactory.GetFont(FontFactory.COURIER_BOLD, 6D, iTextSharp.text.Font.NORMAL)) : encabezado9.Alignment = Element.ALIGN_LEFT
        Dim encabezado91 As New Paragraph("xCant   |  Precio              |$ Total", FontFactory.GetFont(FontFactory.COURIER_BOLD, 6D, iTextSharp.text.Font.NORMAL)) : encabezado91.Alignment = Element.ALIGN_LEFT

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

        celltotal.Phrase = New Phrase("SubTotal ---------> $", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        celltotal.HorizontalAlignment = Element.ALIGN_LEFT
        celltotal.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_total.AddCell(celltotal) 'primera col

        celltotal.Phrase = New Phrase(TextBox_TOTALVENTA.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        celltotal.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_total.AddCell(celltotal) ' segunda col
        tabla_total.CompleteRow() ' agrega linea

        celltotal.Phrase = New Phrase("Descuentos -------> $", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        celltotal.HorizontalAlignment = Element.ALIGN_LEFT
        celltotal.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_total.AddCell(celltotal) 'primera col

        celltotal.Phrase = New Phrase(TextBox_DESCUENTO.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        celltotal.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_total.AddCell(celltotal) ' segunda col
        tabla_total.CompleteRow() ' agrega linea

        celltotal.Phrase = New Phrase("Serv. Vol. -------> $", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        celltotal.HorizontalAlignment = Element.ALIGN_LEFT
        celltotal.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_total.AddCell(celltotal) 'primera col

        celltotal.Phrase = New Phrase(TextBox_propina.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        celltotal.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_total.AddCell(celltotal) ' segunda col
        tabla_total.CompleteRow() ' agrega linea

        'celltotal.Phrase = New Phrase("Domicilio --------> $", FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        'celltotal.HorizontalAlignment = Element.ALIGN_LEFT
        'celltotal.BackgroundColor = BaseColor.LIGHT_GRAY
        'tabla_total.AddCell(celltotal) 'primera col

        'celltotal.Phrase = New Phrase(TextBox_domiciliovr.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, iTextSharp.text.Font.NORMAL))
        'celltotal.HorizontalAlignment = Element.ALIGN_RIGHT
        'tabla_total.AddCell(celltotal) ' segunda col
        'tabla_total.CompleteRow() ' agrega linea

        celltotal.Phrase = New Phrase("TOTAL A PAGAR>>>> $", FontFactory.GetFont(FontFactory.COURIER_BOLD, 10, iTextSharp.text.Font.NORMAL))
        celltotal.HorizontalAlignment = Element.ALIGN_LEFT
        celltotal.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_total.AddCell(celltotal) 'primera col

        celltotal.Phrase = New Phrase(FormatNumber(imp_totalapagar, 0), FontFactory.GetFont(FontFactory.COURIER_BOLD, 10, iTextSharp.text.Font.NORMAL))
        celltotal.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_total.AddCell(celltotal) ' segunda col
        tabla_total.CompleteRow() ' agrega linea

        Dim encabezado_ttal_pago As New Paragraph("Pago: " & MEDIO_PAGO_DESTINO_NOMBRE & "  $ " & TextBox_efectivo.Text, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 6D, iTextSharp.text.Font.NORMAL)) : encabezado_ttal_pago.Alignment = Element.ALIGN_RIGHT
        Dim encabezado_ttal_cambio As New Paragraph("Cambio:   $" & Label_cambio_VR.Text, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 6D, iTextSharp.text.Font.NORMAL)) : encabezado_ttal_cambio.Alignment = Element.ALIGN_RIGHT

        Dim encabezado8 As New Paragraph("Detalle de Impuestos", FontFactory.GetFont(FontFactory.COURIER_BOLD, 6D, iTextSharp.text.Font.NORMAL)) : encabezado8.Alignment = Element.ALIGN_LEFT


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

        Dim encabezado_mesa As New Paragraph("Mesa:" & Label_mesa.Text, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 6D, iTextSharp.text.Font.NORMAL)) : encabezado_mesa.Alignment = Element.ALIGN_LEFT

        Dim encabezado_mesero As New Paragraph("Le Atendió:" & ComboBox_mesero.Text, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 6D, iTextSharp.text.Font.NORMAL)) : encabezado_mesero.Alignment = Element.ALIGN_LEFT

        Dim encabezado_caja As New Paragraph("Cajero:" & USR_NOM, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 6D, iTextSharp.text.Font.NORMAL)) : encabezado_caja.Alignment = Element.ALIGN_LEFT

        Dim encabezado7 As New Paragraph("Se Imprimió el " + DateTime.Now + Chr(13) + "Por: " + usrnom, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 5D, iTextSharp.text.Font.NORMAL)) : encabezado7.Alignment = 0
        Dim encabezado_publicidad As New Paragraph("www.MiCliCkDerecho.com Sistemas POS 3165259554.", FontFactory.GetFont(FontFactory.HELVETICA, 5D, iTextSharp.text.Font.NORMAL)) : encabezado7.Alignment = 0

        Dim encabezado_domicilio_data As New Paragraph("Entrega Domicilio:", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 6D, iTextSharp.text.Font.NORMAL)) : encabezado8.Alignment = Element.ALIGN_LEFT

        Dim encabezado_domicilio_MESAJERO As New Paragraph("Mensajero:", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 6D, iTextSharp.text.Font.NORMAL)) : encabezado_domicilio_MESAJERO.Alignment = Element.ALIGN_LEFT

        Dim glue = New Chunk(New VerticalPositionMark())


        If comex_logo <> "" And File.Exists(comex_logo) = True Then
            Dim imagelogogopdf As iTextSharp.text.Image 'Declaracion de una imagen

            imagelogogopdf = iTextSharp.text.Image.GetInstance(comex_logo) 'Dirreccion a la imagen que se hace referencia
            imagelogogopdf.Alignment = Element.ALIGN_CENTER
            imagelogogopdf.SetAbsolutePosition(20, alto_pag - 60) 'Posicion en el eje cartesiano
            imagelogogopdf.ScaleAbsoluteWidth(160) 'Ancho de la imagen
            imagelogogopdf.ScaleAbsoluteHeight(60) 'Altura de la imagen
            document.Add(imagelogogopdf) ' Agrega la imagen al documento
        End If

        If comex_logo <> "" And File.Exists(comex_logo) = True Then encabezadoLINE.SpacingBefore = 60

        document.Add(encabezadoLINE)
        document.Add(tablahome)
        document.Add(PDF_leyedian1)
        document.Add(PDF_leyedian2)
        document.Add(TITEL_TERMINAL)
        encabezadoLINE2.SpacingBefore = -3
        document.Add(encabezadoLINE2)

        tabla_turno_data.SpacingBefore = 0
        document.Add(tabla_turno_data)

        document.Add(encabezado6)
        document.Add(encabezado_resumenOP)
        encabezado_resumenOP.SpacingBefore = -3

        encabezadoLINE3.SpacingBefore = -10
        document.Add(encabezadoLINE3)
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
        document.Add(encabezado_mesa)

        document.Add(encabezado_mesero)
        document.Add(encabezado_caja)

        document.Add(encabezadoLINE3)

        document.Add(encabezado7)
        document.Add(encabezado_publicidad)



        document.Add(encabezadoLINE2)


    End Sub
    Private Sub Button_EXPORTAR_mediacarta()


        Try
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
            da.Dispose()
            dt_imprimir_prods.Dispose()

            'Intentar generar el documento.
            Dim doc As New Document(PageSize.A4, 20, 20, 20, 20)

            If Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) & "\MiClickDerecho Docs\") Then
                Try
                    My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) & "\MiClickDerecho Docs\")
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If

            'Path que guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\factura " & Label_consecutivo.Text & ".pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)

            PdfWriter.GetInstance(doc, file)

            doc.Open()
            ExportarDatosMediaCarta(doc)
            doc.Close()
            Process.Start(filename)
        Catch ex As Exception
            'Si el intento es fallido, mostrar MsgBox.
            MessageBox.Show("No se puede generar el documento PDF, Cierre los documentos PDF generados anteriormente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub ExportarDatosMediaCarta(ByVal document As Document)
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

        Dim PDF_CONSECUTIVO As New Paragraph("No.    " & consecutivo & "    ", encabezadoFont)
        PDF_CONSECUTIVO.Alignment = 2
        PDF_CONSECUTIVO.Font = encabezadoFont

        Dim encabezado2 As New Paragraph(DateTime.Now.ToShortDateString + "             ", FontFactory.GetFont("Arial Black", 10, iTextSharp.text.Font.BOLDITALIC)) : encabezado2.Alignment = 2
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
        cellhome.Phrase = New Phrase("", CLIENTEFONT)
        cellhome.HorizontalAlignment = Element.ALIGN_BOTTOM
        tablahome.AddCell(cellhome)
        cellhome.Phrase = New Phrase(comex_nombrecomercial, contentFont)
        cellhome.HorizontalAlignment = Element.ALIGN_RIGHT
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase("DOC/NIT: ", FontFactory.GetFont("Arial Black", 7, iTextSharp.text.Font.BOLDITALIC, BaseColor.WHITE))
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        cellhome.Phrase = New Phrase(Textbox_Cliente_Doc.Text, CLIENTEFONT)
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        cellhome.Phrase = New Phrase("NIT:" & comex_nit & " " & comex_regimen, DIRFont)
        cellhome.HorizontalAlignment = Element.ALIGN_RIGHT
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()


        cellhome.Phrase = New Phrase("Cliente: ", FontFactory.GetFont("Arial Black", 7, iTextSharp.text.Font.BOLDITALIC, BaseColor.WHITE))
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        cellhome.Phrase = New Phrase(Textbox_Cliente_Nom.Text, CLIENTEFONT)
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        cellhome.Phrase = New Phrase(comex_dircomercio + " " + comex_ciudad + " Tel: " + comex_tels, DIRFont2)
        cellhome.HorizontalAlignment = Element.ALIGN_RIGHT
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase("Dirección:  ", FontFactory.GetFont("Arial Black", 7, iTextSharp.text.Font.BOLDITALIC, BaseColor.WHITE))
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        cellhome.Phrase = New Phrase(Textbox_Cliente_Dir.Text.ToString, CLIENTEFONT)
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
        cellhome.Phrase = New Phrase(Textbox_Cliente_Tel1.Text, DIRFont2)
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
                If j = 0 Then cell.HorizontalAlignment = Element.ALIGN_CENTER
                If j = 1 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 2 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 3 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 4 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                'If j = 5 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                'If j = 6 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                'If j = 7 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                cell.Border = 0
                'cell.BorderWidthRight = 0.3F
                'cell.BorderColorRight = BaseColor.BLACK
                cell.PaddingTop = 3
                datatable.AddCell(cell)
            Next
            datatable.CompleteRow()
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
                    If j = 0 Then cell.HorizontalAlignment = Element.ALIGN_CENTER
                    If j = 1 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                    If j = 2 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                    If j = 3 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                    If j = 4 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                    'If j = 5 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
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
        tabla_PIE.SpacingBefore = 3

        Dim cell_PIE As New PdfPCell
        cell_PIE.BorderWidth = 0

        cell_PIE.Phrase = New Phrase("  Observaciones", iTextSharp.text.FontFactory.GetFont("Arial Narrow", 5, iTextSharp.text.Font.BOLD, BaseColor.BLACK))
        cell_PIE.HorizontalAlignment = Element.ALIGN_LEFT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase("Medio de Pago: " & ComboBox_Cuentas.Text, contentFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase("Paguese en " & DateTimePicker_FECHAPAGO.Text, contentFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_LEFT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase(" ", contentFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_LEFT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase("SubTotal", totalFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase(TextBox_SUBTOTAL.Text & " ", totalFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_PIE.AddCell(cell_PIE)
        tabla_PIE.CompleteRow()

        cell_PIE.Phrase = New Phrase(TextBox_observaciones.Text, DIRFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_LEFT
        cell_PIE.HorizontalAlignment = Element.ALIGN_JUSTIFIED
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
        cell_PIE.Phrase = New Phrase(TextBox_Total_impuestos.Text, totalFont)
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
        cell_PIE.Phrase = New Phrase(TextBox_TOTAL_pagar.Text, totaltotalFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_PIE.AddCell(cell_PIE)
        tabla_PIE.CompleteRow()

        cell_PIE.Phrase = New Phrase("Fecha de Impresión: " + Now.Date(), New Font(Font.Name = "Arial Narrow", 5, Font.Bold))
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
        If comex_logo <> "" And File.Exists(comex_logo) = True Then
            Dim imagelogogopdf As iTextSharp.text.Image 'Declaracion de una imagen

            imagelogogopdf = iTextSharp.text.Image.GetInstance(comex_logo) 'Dirreccion a la imagen que se hace referencia
            imagelogogopdf.Alignment = Element.ALIGN_RIGHT
            imagelogogopdf.SetAbsolutePosition(25, 760) 'Posicion en el eje cartesiano
            imagelogogopdf.ScaleAbsoluteWidth(160) 'Ancho de la imagen
            imagelogogopdf.ScaleAbsoluteHeight(68) 'Altura de la imagen
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
        document.Add(CUADRO_total)
        'document.Add(descuento)
        document.Add(CUADRO_obs)
        document.Add(endline)


    End Sub
    'imprimir exportar factura





    '||||||||||||||||||||||||||||||||||||||||||||||||||||FUNCIONES|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    Private Sub unir_la_mesa(ByVal cuenta As String, mesa As String, seccion As String)


        ' actualizo union de la mesa



        sql = "UPDATE ventas_prods_temp SET documento='" & invitador_cuenta & "' WHERE DOCUMENTO='" & cuenta & "'"
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

        sql = "delete from ventas_pre WHERE DOCUMENTO='" & cuenta & "'"
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


        Label_lcd.Text = "Se unificaron las mesas..."


    End Sub

    Private Sub clean_txt_cliente()
        Textbox_Cliente_Doc.Text = ""
        Textbox_Cliente_Nom.Text = ""
        Textbox_Cliente_Dir.Text = ""
        Textbox_Cliente_Tel1.Text = ""
        Textbox_Cliente_Tel2.Text = ""
        Textbox_Cliente_Email.Text = ""
        Label_puntos_cliente.Text = "0"
        Label_DV.Text = "0"

    End Sub
    Private Sub CLEAN_FLOW()

        Dim num_controles As Int32 = Me.FlowLayout_MULTIPANEL.Controls.Count - 1
        For n As Integer = num_controles To 0 Step -1
            Dim ctrl As Windows.Forms.Control = Me.FlowLayout_MULTIPANEL.Controls(n)
            Me.FlowLayout_MULTIPANEL.Controls.Remove(ctrl)

            ctrl.Dispose()
        Next
    End Sub
    Private Sub fill_bartenders()
        ' CARGAMOS LOS MESEROS O EMPLEADOS
        Try
            sql = "SELECT nombre, documento FROM EMPLEADOS where cargo='Mesero' or cargo='Vendedor' or cargo='Cajero'"
            da_meseros = New MySqlDataAdapter(sql, conex)
            DT_meseros = New DataTable
            da_meseros.Fill(DT_meseros)
            Me.ComboBox_mesero.DataSource = DT_meseros.DefaultView
            Me.ComboBox_mesero.DisplayMember = "NOMBRE"
            Me.ComboBox_mesero.ValueMember = "DOCUMENTO"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_meseros.Dispose()
        DT_meseros.Dispose()
        conex.Close()

        ComboBox_mesero.SelectedItem = Nothing
    End Sub
    Private Sub fill_client_data(ByVal clidoc As String)
        Textbox_Cliente_Nom.Text = ""
        Textbox_Cliente_Doc.Text = ""
        Textbox_Cliente_Tel1.Text = ""
        Textbox_Cliente_Tel2.Text = ""
        Textbox_Cliente_Dir.Text = ""
        Textbox_Cliente_Email.Text = ""
        Label_puntos_cliente.Text = 0
        Label_limite.Text = 0
        Try
            sql = "SELECT * FROM proveedores where DOCUMENTO='" & CStr(clidoc) & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt_clientes = New DataTable
            da.Fill(dt_clientes)
            For Each row As DataRow In dt_clientes.Rows
                Textbox_Cliente_Nom.Text = row.Item("nombre")
                Textbox_Cliente_Doc.Text = row.Item("DOCUMENTO")
                Textbox_Cliente_Tel1.Text = row.Item("TELEFONO")
                Textbox_Cliente_Tel2.Text = row.Item("TELEFONO2")
                Textbox_Cliente_Dir.Text = row.Item("DIRECCION")
                Textbox_Cliente_Email.Text = row.Item("email")
                Label_puntos_cliente.Text = row.Item("puntos")
                Label_puntos_cliente.Text = row.Item("puntos")
                Label_limite.Text = row.Item("CupoCredito")
            Next
        Catch ex As Exception

        End Try

    End Sub
    Private Sub fill_zones()
        Me.Cursor = Cursors.WaitCursor
        sql = "SELECT CONS, zona, MESAS from zonas where estado='ACTIVA';"
        da_zone = New MySqlDataAdapter(sql, conex)
        dt_zone = New DataTable
        Try
            da_zone.Fill(dt_zone)
            Me.MetroGrid_zonas.DataSource = dt_zone

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        da_zone.Dispose()
        dt_zone.Dispose()
        conex.Close()
        Me.Cursor = Cursors.Default


    End Sub

    Private Sub Fill_ProdsSale(ByVal NVenta As String)
        Try
            sql = "select Cons, Documento, CodProd, Producto, Cantidad, Base, Imp, imp2, Impuesto, Impuesto2, ValorU, replace(format(ValorTotal,0),',','.') as ValorTotal, Estado, inventariado, ImpNom1, ImpNom2, deci, costo, idbodega, Lote, vence, cta_vender, cta_inventariar, cta_costear, cta_devolver, kit, cocina, parrilla, bar FROM ventas_prods_TEMP WHERE documento = " & CInt(NVenta) & ""

            da_prods_venta = New MySqlDataAdapter(sql, conex)
            dt_prods_venta = New DataTable
            da_prods_venta.Fill(dt_prods_venta)
            Me.dataGrid_detalleprodsVENTA.DataSource = dt_prods_venta
            Me.dataGrid_detalleprodsVENTA.Columns(0).Visible = False
            Me.dataGrid_detalleprodsVENTA.Columns(1).Visible = False
            Me.dataGrid_detalleprodsVENTA.Columns(2).HeaderText = "Código"
            Me.dataGrid_detalleprodsVENTA.Columns(2).Width = 60
            Me.dataGrid_detalleprodsVENTA.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.dataGrid_detalleprodsVENTA.Columns(2).Visible = False
            Me.dataGrid_detalleprodsVENTA.Columns(3).HeaderText = "Producto"
            'Me.datagrid_detalleProds.Columns(3).Width = 240
            Me.dataGrid_detalleprodsVENTA.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.dataGrid_detalleprodsVENTA.Columns(3).DefaultCellStyle.WrapMode = DataGridViewTriState.True
            Me.dataGrid_detalleprodsVENTA.Columns(4).HeaderText = "Cant"
            Me.dataGrid_detalleprodsVENTA.Columns(4).Width = 60
            Me.dataGrid_detalleprodsVENTA.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.dataGrid_detalleprodsVENTA.Columns(5).HeaderText = "P/Base"
            Me.dataGrid_detalleprodsVENTA.Columns(5).Width = 50
            Me.dataGrid_detalleprodsVENTA.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.dataGrid_detalleprodsVENTA.Columns(5).Visible = False
            Me.dataGrid_detalleprodsVENTA.Columns(6).HeaderText = "ICO"
            Me.dataGrid_detalleprodsVENTA.Columns(6).Width = 50
            Me.dataGrid_detalleprodsVENTA.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.dataGrid_detalleprodsVENTA.Columns(6).Visible = False
            Me.dataGrid_detalleprodsVENTA.Columns(7).HeaderText = "IVA"
            Me.dataGrid_detalleprodsVENTA.Columns(7).Width = 50
            Me.dataGrid_detalleprodsVENTA.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.dataGrid_detalleprodsVENTA.Columns(7).Visible = False
            Me.dataGrid_detalleprodsVENTA.Columns(8).Visible = False
            Me.dataGrid_detalleprodsVENTA.Columns(9).Visible = False
            Me.dataGrid_detalleprodsVENTA.Columns(10).HeaderText = "Valor/U"
            Me.dataGrid_detalleprodsVENTA.Columns(10).Width = 80
            Me.dataGrid_detalleprodsVENTA.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.dataGrid_detalleprodsVENTA.Columns(10).Visible = False
            Me.dataGrid_detalleprodsVENTA.Columns(11).HeaderText = "TOTAL"
            Me.dataGrid_detalleprodsVENTA.Columns(11).Width = 80
            Me.dataGrid_detalleprodsVENTA.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.dataGrid_detalleprodsVENTA.Columns(11).DefaultCellStyle.Format = "c"
            Me.dataGrid_detalleprodsVENTA.Columns(12).Visible = False
            Me.dataGrid_detalleprodsVENTA.Columns(13).Visible = False
            Me.dataGrid_detalleprodsVENTA.Columns(14).Visible = False
            Me.dataGrid_detalleprodsVENTA.Columns(15).Visible = False
            Me.dataGrid_detalleprodsVENTA.Columns(16).Visible = False
            Me.dataGrid_detalleprodsVENTA.Columns(17).Visible = False
            Me.dataGrid_detalleprodsVENTA.Columns(18).Visible = False
            Me.dataGrid_detalleprodsVENTA.Columns(19).Visible = False
            Me.dataGrid_detalleprodsVENTA.Columns(20).Visible = False
            Me.dataGrid_detalleprodsVENTA.Columns(21).Visible = False
            Me.dataGrid_detalleprodsVENTA.Columns(22).Visible = False
            Me.dataGrid_detalleprodsVENTA.Columns(23).Visible = False
            Me.dataGrid_detalleprodsVENTA.Columns(24).Visible = False
            Me.dataGrid_detalleprodsVENTA.Columns(25).Visible = False
            Me.dataGrid_detalleprodsVENTA.Columns(26).Visible = False
            Me.dataGrid_detalleprodsVENTA.Columns(27).Visible = False
            Me.dataGrid_detalleprodsVENTA.Columns(28).Visible = False


            Me.dataGrid_detalleprodsVENTA.Columns(2).Width = 60
            Me.dataGrid_detalleprodsVENTA.Columns(3).Width = 250
            Me.dataGrid_detalleprodsVENTA.Columns(4).Width = 50
            Me.dataGrid_detalleprodsVENTA.Columns(5).Width = 50
            Me.dataGrid_detalleprodsVENTA.Columns(6).Width = 50
            Me.dataGrid_detalleprodsVENTA.Columns(7).Width = 80



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_prods_venta.Dispose()
        dt_prods_venta.Dispose()

        Me.dataGrid_detalleprodsVENTA.Refresh()
        TextBox_TOTALVENTA.Text = 0
        Me.TextBox_TOTAL_pagar.Text = 0
        Me.TextBox_impuesto.Text = 0
        Me.TextBox_impuesto2.Text = 0
        Me.TextBox_BASEimp.Text = 0
        Me.TextBox_Total_impuestos.Text = 0
        TextBox_TOTAL_pagar.Text = 0
        TextBox_COSTO.Text = 0
        TextBox_SUBTOTAL.Text = 0
        TextBox_TOTAL_pagar.Text = 0        'BunifuCheckbox_cocina.Checked = False
        'BunifuCheckbox_parrilla.Checked = False
        'BunifuCheckbox_bar.Checked = False

        Try
            For i As Integer = 0 To dataGrid_detalleprodsVENTA.RowCount - 1
                Me.TextBox_BASEimp.Text = CInt(Me.TextBox_BASEimp.Text) + ((dataGrid_detalleprodsVENTA.Item("BASE", i).Value))
                Me.TextBox_impuesto.Text = CInt(Me.TextBox_impuesto.Text) + dataGrid_detalleprodsVENTA.Item("impuesto", i).Value
                Me.TextBox_impuesto2.Text = CInt(Me.TextBox_impuesto2.Text) + dataGrid_detalleprodsVENTA.Item("impuesto2", i).Value
                Me.TextBox_COSTO.Text = CInt(Me.TextBox_COSTO.Text) + dataGrid_detalleprodsVENTA.Item("COSTO", i).Value
                Me.TextBox_Total_impuestos.Text = CInt(Me.TextBox_impuesto.Text) + CInt(Me.TextBox_impuesto2.Text)
                Me.TextBox_TOTALVENTA.Text = CInt(Me.TextBox_TOTALVENTA.Text) + CInt(dataGrid_detalleprodsVENTA.Item("valortotal", i).Value)
                'If dataGrid_detalleprods.Item("cocina", i).Value = "SI" Then BunifuCheckbox_cocina.Checked = True
                'If dataGrid_detalleprods.Item("parrilla", i).Value = "SI" Then BunifuCheckbox_parrilla.Checked = True
                'If dataGrid_detalleprods.Item("bar", i).Value = "SI" Then BunifuCheckbox_bar.Checked = True
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try


        Try
            sql = "SELECT CODPROD AS CODIGO, PRODUCTO, BASE AS BASE, IMP AS ICO, IMP2 AS IVA, VALORU, VALORTOTAL FROM ventas_prods_temp WHERE DOCUMENTO='" & Label_consecutivo.Text & "' and concat(impnom1,impnom2)<>'NONO'"
            If fact_saveok = 1 Then sql = "SELECT CODPROD AS CODIGO, PRODUCTO, BASE AS BASE, IMP AS ICO, IMP2 AS IVA, VALORU, VALORTOTAL FROM ventas_prods WHERE DOCUMENTO='" & Label_consecutivo.Text & "' and concat(impnom1,impnom2)<>'NONO'"

            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.MetroGrid_impuestos.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try



        'descuentos==================
        Try
            sql = "SELECT PRODUCTO, VALORTOTAL FROM ventas_dctos_temp WHERE DOCUMENTO='" & Label_consecutivo.Text & "'"
            If fact_saveok = 1 Then sql = "SELECT PRODUCTO, VALORTOTAL FROM ventas_dctos WHERE DOCUMENTO='" & Label_consecutivo.Text & "'"

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



        If Me.TextBox_DESCUENTO.Text = "" Then Me.TextBox_DESCUENTO.Text = "0"



        Me.TextBox_TOTAL_pagar.Text = CInt(Me.TextBox_TOTALVENTA.Text) + CInt(TextBox_DESCUENTO.Text)


        Me.TextBox_TOTALVENTA.Text = Format(CInt(Me.TextBox_TOTALVENTA.Text), "##,##0")

        Me.TextBox_SUBTOTAL.Text = (CInt(Me.TextBox_TOTALVENTA.Text) + CInt(TextBox_DESCUENTO.Text)) - CInt(Me.TextBox_Total_impuestos.Text)
        Me.TextBox_SUBTOTAL.Text = Format(CInt(Me.TextBox_SUBTOTAL.Text), "##,##0")


        Me.TextBox_BASEimp.Text = Format(CInt(Me.TextBox_BASEimp.Text), "##,##0")
        Me.TextBox_impuesto.Text = Format(CInt(Me.TextBox_impuesto.Text), "##,##0")
        Me.TextBox_impuesto2.Text = Format(CInt(Me.TextBox_impuesto2.Text), "##,##0")

        Me.TextBox_Total_impuestos.Text = Format(CInt(Me.TextBox_Total_impuestos.Text), "##,##0")


        Me.TextBox_DESCUENTO.Text = Format(CInt(Me.TextBox_DESCUENTO.Text), "##,##0")

        Me.TextBox_TOTAL_pagar.Text = Format(CInt(Me.TextBox_TOTAL_pagar.Text), "##,##0")





        sql = "update VENTAS_pre set total='" & CInt(TextBox_TOTAL_pagar.Text) & "' where documento=" & CInt(Label_consecutivo.Text) & ""
        da = New MySqlDataAdapter(sql, conex)
        dt = New DataTable
        Try
            da.Fill(dt)

            'MsgBox("Se Borró el producto.")
        Catch ex As Exception
            MsgBox("Error al MODIFICAR el Registro." & ex.ToString)
            Exit Sub
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()


        Me.TextBox_cant.Text = 1
        Me.Textbox_buscar_prod.Text = ""
    End Sub
    Private Sub CONSULTAR_PRODUCTO(ByVal CRITERIO As String, ByVal CODIGOPROD As String)
        prod_lote = ""
        Try

            If CRITERIO = "CODIGO" Then sql = "SELECT productos.*, 
productos_categorias.impventa, productos_categorias.impinv, productos_categorias.impcosto, productos_categorias.impdev 
FROM productos, productos_categorias
where productos.categoria=productos_categorias.Categoria and productos.tipo=productos_categorias.tipo
and productos.cod=" & (CODIGOPROD) & "  AND productos.ESTADO='ACTIVO'
group by productos.cod"

            da_prodscombo = New MySqlDataAdapter(sql, conex)
            dt_prodscombo = New DataTable
            da_prodscombo.Fill(dt_prodscombo)


            For Each row As DataRow In dt_prodscombo.Rows
                prod_barras = row.Item("codbarras")
                prod_cod = row.Item("cod")
                prod_nom = row.Item("nombre")
                prod_desc = row.Item("descripcion")
                prod_iva = row.Item("iva")
                prod_iva2 = row.Item("iva2")
                PROD_IVATIPO = row.Item("ivaTIPO")
                PROD_IVATIPO2 = row.Item("ivaTIPO2")
                prod_iva1nom = row.Item("impnom1")
                prod_iva2nom = row.Item("impnom2")
                prod_valor = row.Item("valor")
                prod_valor2 = row.Item("valor2")
                prod_valor3 = row.Item("valor3")
                prod_costo = row.Item("costo")
                prod_tipo = row.Item("tipo")
                prod_kit = row.Item("kit")
                'prod_costo_prom = prod_costo

                PROD_CATEGORIA = row.Item("CATEGORIA")
                prod_imagen = row.Item("imagen")
                PROD_INVENTARIADO = row.Item("INVENTARIADO")
                prod_stock = row.Item("STOCK")
                prod_decimal = row.Item("decimales")
                prod_cocina = row.Item("cocina")
                prod_parrilla = row.Item("parrilla")
                prod_bar = row.Item("bar")

                'If prod_decimal = "SI" Then Numeric_cant.DecimalPlaces = 1 Else Numeric_cant.DecimalPlaces = 0



                prod_cta_vender = row.Item("impventa")
                prod_cta_inventariar = row.Item("impinv")
                prod_cta_costear = row.Item("impcosto")
                prod_cta_devolver = row.Item("impdev")

                prod_alerta = row.Item("alerta")

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_prodscombo.Dispose()
        dt_prodscombo.Dispose()
        conex.Close()

        'costo     ===========

        Dim costo_prom, costo_ult, costo_max, costo_min As String
        costo_prom = 0 : costo_ult = 0 : costo_max = 0 : costo_min = 0

        Try
            sql = "SELECT avg(valoru) as promedio FROM pedidosprov_prods where CodProd=" & CInt(prod_cod) & " and estado<>'ANULADO'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                costo_prom = CDec(row.Item("promedio"))
            Next
        Catch ex As Exception
        End Try

        da.Dispose()
        dt.Dispose()
        conex.Close()

        Try
            sql = "SELECT cons, valoru FROM pedidosprov_prods where CodProd=" & CInt(prod_cod) & " and estado<>'ANULADO' order by cons desc limit 1"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                costo_ult = row.Item("valoru")
            Next
        Catch ex As Exception
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()


        Try
            sql = "SELECT min(valoru) as minimo, MAX(valoru) as maximo FROM pedidosprov_prods where CodProd=" & CInt(prod_cod) & " and estado<>'ANULADO'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                costo_min = row.Item("minimo")
                costo_max = row.Item("maximo")
            Next
        Catch ex As Exception
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()


        If comex_costo = "PROMEDIO" Then prod_costo = costo_prom
        If comex_costo = "MAXIMO" Then prod_costo = costo_max
        If comex_costo = "ULTIMO" Then prod_costo = costo_ult
        If comex_costo = "MINIMO" Then prod_costo = costo_min

        'costo================

    End Sub
    Private Sub BUSCA_SALDO_PRODUCTO_aqui()
        Me.Cursor = Cursors.WaitCursor

        Try
            sql = "SELECT sum(cantidad) as CANT FROM ventas_prods_temp where CodProd='" & CInt(prod_cod) & "' and lote='" & prod_lote & "'"
            If prod_lote = "" Then sql = "SELECT sum(cantidad) as CANT FROM ventas_prods_temp where CodProd='" & CInt(prod_cod) & "'"

            If prod_decimal = "SI" Then sql = "SELECT sum(CAST(CONVERT(REPLACE(CAST(cantidad AS CHAR),',','.'),decimal(12,3)) AS DECIMAL(12,3))) AS CANT FROM ventas_prods_temp where CodProd='" & CInt(prod_cod) & "' and loteS='" & prod_lote & "'"

            da_SALDOS = New MySqlDataAdapter(sql, conex)
            dt_saldos = New DataTable
            da_SALDOS.Fill(dt_saldos)
            For Each row As DataRow In dt_saldos.Rows
                SALDO_DEL_PRODUCTO_aqui = row.Item("cant")
            Next
        Catch ex As Exception
            SALDO_DEL_PRODUCTO_aqui = 0
        End Try

        da_SALDOS.Dispose()
        dt_saldos.Dispose()
        conex.Close()


        Me.Cursor = Cursors.Default
    End Sub
    Private Sub BUSCA_SALDO_PRODUCTO()
        Me.Cursor = Cursors.WaitCursor


        If prod_decimal = "SI" Then SALDO_DEL_PRODUCTO = Format(CDec(SALDO_DEL_PRODUCTO), "00.000") - Format(CDec(SALDO_DEL_PRODUCTO_aqui), "00.000") ' le quito lo que esta vendiendo actualmente
        '   REVISARRRRRRRRRRRRRRRRRRRRRRRRRRRR
        If prod_decimal = "SI" Then
            SALDO_DEL_PRODUCTO = Format(CDec(SALDO_DEL_PRODUCTO), "00.000") - Format(CDec(SALDO_DEL_PRODUCTO_aqui), "00.000")
            SALDO_DEL_PRODUCTO = Format(CDec(SALDO_DEL_PRODUCTO), "00.000") - Format(CDec(SALDO_DEL_PRODUCTO_aqui), "00.000") ' le quito lo que esta vendiendo actualmente
        Else
            SALDO_DEL_PRODUCTO = CInt(SALDO_DEL_PRODUCTO) - CInt(SALDO_DEL_PRODUCTO_aqui) ' le quito lo que esta vendiendo actualmente
            SALDO_DEL_PRODUCTO = CInt(SALDO_DEL_PRODUCTO) - CDec(SALDO_DEL_PRODUCTO_aqui) ' le quito lo que esta vendiendo actualmente

        End If

        ' aviso de stock minimo

        Me.Cursor = Cursors.Default
    End Sub
    Private Sub agregar_1_prod()
        If prod_valor = "" Then prod_valor = "0"
        PROD_VALOR_UNITARIO_BASE = 0
        PROD_VALOR_UNITARIO_BASE = CInt(prod_valor)

        If prod_iva1nom <> "NO" Then  ' calculamos ico
            PROD_VALOR_UNITARIO_BASE = CInt(PROD_VALOR_UNITARIO_BASE) - CInt(prod_iva)
            PROD_IVA_VR = prod_iva
        End If

        Dim CANTIDA As String = ""
        If prod_decimal = "SI" Then
            CANTIDA = Numeric_cant.Value
        Else
            CANTIDA = TextBox_cant.Text
        End If

        If prod_iva2nom <> "NO" Then  'CALCULAMOS EL IVA
            PROD_VALOR_UNITARIO_BASE = CDec(CDec(PROD_VALOR_UNITARIO_BASE) * CDec(CANTIDA) / ((CDec(prod_iva2) / 100) + 1))

            PROD_IVA_VR2 = CDec(CDec(PROD_VALOR_UNITARIO_BASE) * CDec(prod_iva2)) / 100

            'redondeo a dos decimales
            PROD_VALOR_UNITARIO_BASE = Math.Round(CDec(PROD_VALOR_UNITARIO_BASE), 0)
            PROD_IVA_VR2 = Math.Round(CDec(PROD_IVA_VR2), 0)
        End If

        'alerta de tiempo
        'If prod_alerta <> "" Then
        '    Panel_alerta.Visible = True
        '    Dim alerta_tiempo() As String
        '    alerta_tiempo = Strings.Split(prod_alerta, "|")
        '    NumericUpDown_alerta.Value = alerta_tiempo(0).ToString
        '    If alerta_tiempo(1).ToString = "hrs" Then RadioButton_hrs.Checked = True
        '    If alerta_tiempo(1).ToString = "mins" Then RadioButton_mins.Checked = True
        'Else
        '    Panel_alerta.Visible = False
        '    NumericUpDown_alerta.Value = 0
        'End If


        If prod_iva2nom = "NO" Then 'CALCULAMOS EL IVA
            PROD_IVA_VR2 = 0
            prod_iva2 = 0
        End If

        If prod_iva1nom = "NO" Then  ' calculamos ico
            PROD_IVA_VR = 0
            prod_iva = 0
        End If

        If prod_decimal = "SI" Then
            PROD_VALOR_UNITARIO_BASE = Math.Round((CDec(PROD_VALOR_UNITARIO_BASE)), 2)
            PROD_VALOR_UNITARIO_total = Math.Round((CDec(PROD_VALOR_UNITARIO_BASE) * CDec(Numeric_cant.Text)), 3)
        Else
            PROD_VALOR_UNITARIO_BASE = Math.Round((CInt(PROD_VALOR_UNITARIO_BASE)), 0)
            PROD_VALOR_UNITARIO_total = Math.Round((CInt(PROD_VALOR_UNITARIO_BASE) * CInt(TextBox_cant.Text)), 0)
        End If



        If prod_costo = "" Then prod_costo = "0"
        Dim caNti As String = ""
        If prod_decimal = "SI" Then
            caNti = Format(CDec(Numeric_cant.Text), "##,##0.000")
            prod_costo = Format(CDec(CDec(prod_costo)), "##,##0.000")
        Else
            caNti = CInt(TextBox_cant.Text)
            prod_costo = CInt(CInt(prod_costo))

        End If


        If prod_cocina = "" Then prod_cocina = "NO"
        If prod_parrilla = "" Then prod_parrilla = "NO"
        If prod_bar = "" Then prod_bar = "NO"

        PARA_COCINAR = prod_cocina
        PARA_PARRILLA = prod_parrilla
        PARA_BAR = prod_bar




        '===============================================================================================================================
        sql = "INSERT INTO ventas_prods_temp(documento, codprod, producto, cantidad, base, imp, IMP2, impuesto, IMPUESTO2, valoru, valortotal, estado, inventariado, IMPNOM1, IMPNOM2, deci, costo, idbodega, lote, VENCE, cta_vender, cta_inventariar, cta_costear, cta_devolver, kit, cocina, parrilla, bar)
            VALUES(" & CInt(Me.Label_consecutivo.Text) & "," & CInt(prod_cod) & ",'" & prod_nom.ToString & "','" & caNti.ToString & "','" & CInt(PROD_VALOR_UNITARIO_BASE) & "','" & CInt(PROD_IVA_VR) & "','" & CInt(PROD_IVA_VR2) & "','" & CStr(Math.Round((CDec(PROD_IVA_VR) * CDec(caNti)), 2)) & "','" & CStr(Math.Round((CInt(PROD_IVA_VR2)), 0)) & "','" & prod_valor & "','" & CStr(Math.Round((CDec(prod_valor) * CDec(caNti)), 0)) & "','SIN DESCARGAR','" & PROD_INVENTARIADO & "','" & prod_iva1nom & "','" & prod_iva2nom & "','" & prod_decimal & "','" & CStr(CDec(prod_costo) * CDec(caNti)) & "','" & ID_COSTO_BODEGA & "','" & prod_lote & "','" & PROD_VENCE & "','" & prod_cta_vender & "','" & prod_cta_inventariar & "','" & prod_cta_costear & "','" & prod_cta_devolver & "','" & prod_kit & "','" & PARA_COCINAR & "','" & PARA_PARRILLA & "','" & PARA_BAR & "');"
        da = New MySqlDataAdapter(sql, conex)
        dt = New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            MsgBox("debe reparar ventas prods temp")
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()

        'cocina
        If PERMISO__general(10) = "SI" Then
            If prod_cocina.Contains("SI") Then
                sql = "UPDATE ventas_pre SET COCINA='SI' WHERE DOCUMENTO=" & CLng(Label_consecutivo.Text) & ""
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
            End If
        End If


    End Sub
    Private Sub CAMBIAR_CANTIDAD()
        PROD_CANT = TextBox_cant.Text.ToString


        Dim RTA As String

        RTA = MsgBox("Confirma Cambiar la cantidad?.  " & Chr(13) & "Nueva Cantidad:  " & TextBox_cant.Text, MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If RTA = 6 Then
            PROD_VALOR_UNITARIO_BASE = 0
            PROD_VALOR_UNITARIO_BASE = CInt(prod_PRECIO_sel)

            If prod_decimal = "SI" Then
                PROD_VALOR_UNITARIO_BASE = Math.Round((CDec(PROD_VALOR_UNITARIO_BASE)), 3)
                PROD_VALOR_UNITARIO_total = Math.Round((CDec(PROD_VALOR_UNITARIO_BASE) * CDec(PROD_CANT)), 3)
            Else
                PROD_VALOR_UNITARIO_BASE = Math.Round((CInt(PROD_VALOR_UNITARIO_BASE)), 0)
                PROD_VALOR_UNITARIO_total = Math.Round((CInt(PROD_VALOR_UNITARIO_BASE) * CInt(PROD_CANT)), 0)
            End If


            If prod_iva2nom <> "NO" Then  'CALCULAMOS EL IVA
                PROD_VALOR_UNITARIO_BASE = CInt(PROD_VALOR_UNITARIO_BASE / ((CInt(prod_iva2) / 100) + 1))
                PROD_IVA_VR2 = CInt(prod_PRECIO_sel) - CInt(PROD_VALOR_UNITARIO_BASE)
            End If

            If prod_iva1nom <> "NO" Then  ' calculamos ico
                PROD_VALOR_UNITARIO_BASE = CInt(PROD_VALOR_UNITARIO_BASE) - CInt(prod_iva)
                PROD_IVA_VR = prod_iva
            End If

            If prod_iva2nom = "NO" Then 'CALCULAMOS EL IVA
                PROD_IVA_VR2 = 0
                prod_iva2 = 0
            End If

            If prod_iva1nom = "NO" Then  ' calculamos ico
                PROD_IVA_VR = 0
                prod_iva = 0
            End If



            sql = "update VENTAS_PRODS_TEMP set CANTIDAD='" & PROD_CANT & "', BASE='" & CInt(PROD_VALOR_UNITARIO_BASE) & "', imp='" & CInt(prod_iva) & "', imp2='" & CInt(PROD_IVA_VR2) & "', impuesto='" & CInt(PROD_IVA_VR) * PROD_CANT & "', impuesto2='" & CInt(PROD_IVA_VR2) * PROD_CANT & "', valoru='" & prod_PRECIO_sel & "', valortotal='" & prod_PRECIO_sel * PROD_CANT & "' where cons=" & CInt(prod_cons_Sel) & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)

                Me.Label_lcd.Text = "Se modificó la cantidad de el producto."
                'MsgBox("Se Borró el producto.")
            Catch ex As Exception
                MsgBox("Error al MODIFICAR el Registro." & ex.ToString)
                Exit Sub
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()

            prod_cod = ""
            prod_nom = ""
            prod_cons = ""

            Me.Button_modificarprecio.Enabled = False
            Me.Button_modificar_cant.Enabled = False
            Me.button_Quitar_Prod.Enabled = False


            Fill_ProdsSale(Label_consecutivo.Text)
        End If
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
    Private Sub FINALIZAR_VENTA()

        'CONSECUTIVO
        consecutivo = 0
        cmd.Connection = conex
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select max(documento) + 1 from VENTAS"
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


        sql = "INSERT INTO VENTAS (res, documento, tipoDocumento, DocCliente, ClienteNom, fecha, MESA, MESERO, TOTALVENTA, DESCUENTO, BASEIMPUESTO, IMPUESTO, IMPUESTO2, TOTAL, mediodepago, fechapago, empleadoCod, empleado, turno, Estado, domicilio, DOMICILIARIO, domiciliovr, propina, salon, cambio,observaciones) VALUES ('" & comex_Resdian & "'," & CLng(consecutivo) & ",'VENTAS','" & CStr(Textbox_Cliente_Doc.Text) & "','" & Textbox_Cliente_Nom.Text & "','" & DateTime.Now.ToShortDateString & "','" & Label_mesa.Text & "','" & ComboBox_mesero.Text & "'," & total_esta_venta & "," & descuento & "," & baseimpuesto & "," & impuesto & "," & impuesto2 & "," & totalapagar & ",'" & medio_de_pago & "','" & fecha_de_pago & "','" & usrdoc & "','" & usrnom & "'," & CInt(turno_actual_global_ID) & ",'DESCARGADO','" & consecutivo_domicilios & "','','0','" & TextBox_propina.Text & "','Seccion 1','" & TextBox_efectivo.Text & "|" & Label_cambio_VR.Text & "','')"
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


        For J As Integer = 0 To MetroGrid_dctos.RowCount - 1
            sql = "insert into ventas_dctos (documento,codprod, producto, valortotal, estado) 
values('" & consecutivo & "','','" & CStr(MetroGrid_dctos.Item("PRODUCTO", J).Value) & "','" & CStr(MetroGrid_dctos.Item("valortotal", J).Value) & "','DESCARGADO')"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                MsgBox(ex.ToString)
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()


        Next


        'GUARDAR LA CUENTA DE COBRO

        If medio_de_pago.Contains("CREDITO") = True Then
            'CONSECUTIVO
            consecutivo_CXC = 0
            cmd.Connection = conex
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select max(cast(CONSECUTIVO as signed)) + 1 from carteracredito WHERE TIPO='CARTERA'"
            conex.Open()
            Try
                dr_consecutivos = cmd.ExecuteReader()
                If dr_consecutivos.Read() Then
                    consecutivo_CXC = dr_consecutivos(0)
                Else
                    consecutivo_CXC = 1
                End If
            Catch ex As Exception
                consecutivo_CXC = 1
                conex.Close()
            End Try
            conex.Close()
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
        VALUES(" & CLng(consecutivo_CXC) & ",'CARTERA','" & DateTime.Now.ToShortDateString & "','" & CStr(Textbox_Cliente_Doc.Text) & "','" & CStr(Textbox_Cliente_Nom.Text) & "','FACTURA DE VENTA','" & consecutivo & "','VENTA A CREDITO','" & totalapagar & "','" & totalapagar & "','" & DateTimePicker_FECHAPAGO.Value.ToShortDateString & "','" & usrnom & "','PENDIENTE')"
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
        End If





        If PERMISO__general(6) = "SI" Then
            'GUARDA EN CAJA
            'guardar mov
            sql = "INSERT INTO CAJA (turno, fecha, documento, tipoDocumento, subtotal, descuento, total, mediodepago, EmpleadoDoc, empleado, estado) VALUES ('" & turno_actual_global & "','" & DateTime.Now.ToShortDateString & "'," & consecutivo & ",'VENTA'," & total_esta_venta & "," & descuento & "," & totalapagar & ",'" & medio_de_pago & "','" & CStr(usrdoc) & "','" & usrnom & "','DESCARGADO')"
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

        'If .BunifuCheckbox_domicilio.Checked = True Then
        '    'guardar domicilio
        '    sql = "INSERT INTO DOMICILIOS (fecha, hora, DOCCLIENTE, Cliente, telefono, direccion, valor, mensajero, tiempoest, empleado, estado, factura) VALUES('" & DateTime.Now.ToShortDateString & "','" & DateTime.Now.ToShortTimeString & "','" & CStr(.COMBO_DOC_CLIENTE_FILTRO.Text) & "','" & CStr(.COMBO_NOM_CLIENTE_FILTRO.Text) & "','" & CStr(.TXT_TELS_CLIENTE.Text) & "','" & CStr(.TXT_DIR_CLIENTE.Text) & "'," & CInt(.TextBox_domiciliovr.Text) & ",'" & .ComboBox_domiciliario.Text & "','','" & usrnom & "','PENDIENTE','" & consecutivo & "')"

        '    da = New MySqlDataAdapter(sql, conex)
        '    dt = New DataTable
        '    Try
        '        da.Fill(dt)
        '    Catch ex As Exception
        '        MsgBox(ex.ToString)
        '    End Try
        '    da.Dispose()
        '    dt.Dispose()
        '    conex.Close()

        '    'CONSECUTIVO
        '    consecutivo_domicilios = 0
        '    cmd.Connection = conex
        '    cmd.CommandType = CommandType.Text
        '    cmd.CommandText = "select max(cons) + 1 from domicilios"
        '    conex.Open()
        '    Try
        '        dr_consecutivos = cmd.ExecuteReader()
        '        If dr_consecutivos.Read() Then
        '            consecutivo_domicilios = dr_consecutivos(0)
        '        Else
        '            consecutivo_domicilios = 1
        '        End If
        '    Catch ex As Exception
        '        consecutivo_domicilios = 1
        '        conex.Close()
        '    End Try
        '    conex.Close()


        '    sql = "UPDATE ventas_pre SET DOMICILIO='" & consecutivo_domicilios & "', domiciliario='" & .ComboBox_domiciliario.Text.ToString & "' WHERE DOCUMENTO='" & CLng(Label_consecutivo.Text) & "'"
        '    da = New MySqlDataAdapter(sql, conex)
        '    dt = New DataTable
        '    Try
        '        da.Fill(dt)
        '    Catch ex As Exception
        '        MsgBox(ex.ToString)
        '    End Try
        '    da.Dispose()
        '    dt.Dispose()
        '    conex.Close()
        'End If



        Dim RTA As String
        RTA = 6
        If RTA = 6 Then
            'descargar ventas de productos
            Me.Cursor = Cursors.WaitCursor
            Try
                For J As Integer = 0 To dataGrid_detalleprodsVENTA.RowCount - 1
                    PROD_ENTRAN = 0
                    PROD_SALDO = 0
                    PROD_SALDO = 0
                    PROD_SALEN = 0
                    Dim saldo As String
                    Dim inv_prodCod As Integer
                    Dim inv_prodCant As String
                    Dim inv_prodNom, INV_PROD_INVENTARIADO, INV_PROd_dec, inv_prod_lote, inv_prod_VENCE As String
                    inv_prod_lote = ""
                    inv_prodNom = CStr(dataGrid_detalleprodsVENTA.Item("PRODUCTO", J).Value)
                    inv_prodCant = dataGrid_detalleprodsVENTA.Item("cantidad", J).Value
                    inv_prodCod = CInt(dataGrid_detalleprodsVENTA.Item("CodProd", J).Value.ToString)
                    INV_PROD_INVENTARIADO = CStr(dataGrid_detalleprodsVENTA.Item("INVENTARIADO", J).Value.ToString)
                    INV_PROd_dec = CStr(dataGrid_detalleprodsVENTA.Item("deci", J).Value)
                    inv_prod_lote = CStr(dataGrid_detalleprodsVENTA.Item("LOTE", J).Value)
                    inv_prod_VENCE = CStr(dataGrid_detalleprodsVENTA.Item("VENCE", J).Value)

                    inv_prod_cta_vender = CStr(dataGrid_detalleprodsVENTA.Item("cta_vender", J).Value)
                    inv_prod_cuenta_inventariar = CStr(dataGrid_detalleprodsVENTA.Item("cta_inventariar", J).Value)
                    inv_prod_cuenta_costear = CStr(dataGrid_detalleprodsVENTA.Item("cta_costear", J).Value)
                    inv_prod_cuenta_devolver = CStr(dataGrid_detalleprodsVENTA.Item("cta_devolver", J).Value)

                    'saldo                 (solo se descargan de inventario los productos)  

                    saldo = 0

                        PROD_SALEN = inv_prodCant  ' TOMO LA CANTIDAD DEL GRID Q ESTA RECORRIENDO
                        PROD_SALDO = saldo  ' IGUALDO SALDO PROD CON EL SALDO CALCULADO EN BODEGA PRICIPAL
                        If INV_PROd_dec = "SI" Then PROD_SALDO = CDec(PROD_SALDO) - CDec(PROD_SALEN) ' PROD_ENTRAN   '  ACUMULO
                        If INV_PROd_dec = "NO" Then PROD_SALDO = CInt(PROD_SALDO) - CInt(PROD_SALEN)
                        PROD_ENTRAN = 0 ' POR QUE QUE ES UNA venta
                        '________________________________________________________________________________________________________________________

                        If INV_PROD_INVENTARIADO = "SI" And CStr(dataGrid_detalleprodsVENTA.Item("KIT", J).Value) <> "SI" Then  ' CONFIRMO SI EL PRODUCTO MANEJA INVENTARIOS
                            Dim rol As String = ""
                            rol = "SALEN"
                            sql = "INSERT INTO bodega_" & comex_bodega_ventas & " (fecha, CodBodega, NomBodega, TipoDocumento, Documento, tercero, Rol, CodProducto, Producto, saldoant, ENTRAN ,Salen, Saldo, valoru, valortotal, Empleado, Estado, DECI, COSTO, LOTE, VENCE) VALUES ('" & DateTime.Now.ToShortDateString & "',1,'PRINCIPAL','VENTA'," & CInt(consecutivo) & ",'" & CStr(Textbox_Cliente_Doc.Text & "|" & Textbox_Cliente_Nom.Text) & "','SALEN'," & CInt(inv_prodCod) & ",'" & inv_prodNom.ToString & "','" & saldo & "','" & PROD_ENTRAN & "','" & PROD_SALEN & "','" & PROD_SALDO & "','" & CLng(dataGrid_detalleprodsVENTA.Item("valoru", J).Value) & "','" & CStr(dataGrid_detalleprodsVENTA.Item("valortotal", J).Value) & "','" & usrnom & "','DESCARGADO','" & INV_PROd_dec & "','" & CStr(dataGrid_detalleprodsVENTA.Item("COSTO", J).Value) & "','" & inv_prod_lote & "','" & inv_prod_VENCE & "')"
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

                            ' AQUI PUEDE IR EL UPDATE DE COSTEADO
                        End If

                        'DESACRGAR LOS PRODUCTOS DEL KITTTTTTTTTTTTTT
                        If CStr(dataGrid_detalleprodsVENTA.Item("kit", J).Value) = "SI" Then

                            sql = "SELECT PRODUCTOS_KIT.CONS, 
PRODUCTOS_KIT.CODKIT, 
PRODUCTOS_KIT.CODPROD,
PRODUCTOS_KIT.PRODUCTO,
PRODUCTOS_KIT.CANTIDAD,
PRODUCTOS.COSTO FROM PRODUCTOS_KIT
INNER JOIN PRODUCTOS ON
PRODUCTOS_KIT.CODPROD=PRODUCTOS.COD
WHERE CODKIT='" & CStr(inv_prodCod) & "'"
                            da_INV_KIT = New MySqlDataAdapter(sql, conex)
                            DT_INV_KIT = New DataTable
                            Try
                                da_INV_KIT.Fill(DT_INV_KIT)
                                Me.DataGrid_kit.DataSource = DT_INV_KIT
                            Catch ex As Exception
                                MsgBox(ex.ToString)
                            End Try
                            da_INV_KIT.Dispose()
                            DT_INV_KIT.Dispose()
                            conex.Close()

                            For k As Integer = 0 To DataGrid_kit.RowCount - 1

                                saldo = 0

                                PROD_SALEN = CStr(DataGrid_kit.Item("cantidad", k).Value) * CInt(inv_prodCant)
                                PROD_SALDO = saldo  ' IGUALDO SALDO PROD CON EL SALDO CALCULADO EN BODEGA PRICIPAL
                                PROD_SALDO = CDec(PROD_SALDO) - CDec(PROD_SALEN) ' PROD_ENTRAN   '  ACUMULO
                                PROD_ENTRAN = 0 ' POR QUE QUE ES UNA venta
                                '________________________________________________________________________________________________________________________

                                Dim rol As String = ""
                                Dim COSTO_KIT_UND As String = CLng(DataGrid_kit.Item("costo", k).Value)
                                Dim COSTO_KIT_UND_TTAL As String = CDec(DataGrid_kit.Item("costo", k).Value) * CDec(DataGrid_kit.Item("CANTIDAD", k).Value)

                                rol = "SALEN"
                                sql = "INSERT INTO bodega_" & comex_bodega_ventas & " (fecha, CodBodega, NomBodega, TipoDocumento, Documento, tercero, Rol, CodProducto, Producto, saldoant, ENTRAN ,Salen, Saldo, valoru, valortotal, Empleado, Estado, DECI, COSTO, LOTE, VENCE) 
VALUES ('" & DateTime.Now.ToShortDateString & "',1,'" & comex_bodega_ventas & "','VENTA'," & CInt(consecutivo) & ",'" & CStr(Textbox_Cliente_Doc.Text & "|" & Textbox_Cliente_Nom.Text) & "','SALEN'," & CStr(DataGrid_kit.Item("CODPROD", k).Value) & ",'" & CStr(DataGrid_kit.Item("producto", k).Value) & "','" & saldo & "','" & PROD_ENTRAN & "','" & PROD_SALEN & "','" & PROD_SALDO & "','" & COSTO_KIT_UND_TTAL & "','" & CDec(CDec(COSTO_KIT_UND_TTAL) * CDec(inv_prodCant)) & "','" & usrnom & "','DESCARGADO','" & INV_PROd_dec & "','" & CStr(DataGrid_kit.Item("COSTO", k).Value) & "','" & inv_prod_lote & "','" & inv_prod_VENCE & "')"
                                da_KIT = New MySqlDataAdapter(sql, conex)
                                DT_KIT = New DataTable
                                Try
                                    da_KIT.Fill(DT_KIT)
                                Catch ex As Exception
                                    If ex.ToString.Contains("Duplicate entry") Then MsgBox("Error al INSERTAR EN KARDEX DE BODEGA", vbExclamation)
                                    MsgBox(ex.ToString)
                                End Try
                                da_KIT.Dispose()
                                DT_KIT.Dispose()
                                conex.Close()
                            Next

                        End If
                        ' fin kit  ======================================================================================


                        sql = "INSERT INTO ventas_prods (documento, codprod, producto, cantidad, base, imp, IMP2, impuesto, IMPUESTO2, valoru, valortotal, estado,  inventariado, IMPNOM1, IMPNOM2, deci, costo, idbodega, lote) VALUES(" & CInt(consecutivo) & "," & CInt(dataGrid_detalleprodsVENTA.Item("CODPROD", J).Value) & ",'" & CStr(dataGrid_detalleprodsVENTA.Item("PRODUCTO", J).Value) & "','" & inv_prodCant & "'," & CInt(dataGrid_detalleprodsVENTA.Item("base", J).Value) & ",'" & CInt(dataGrid_detalleprodsVENTA.Item("imp", J).Value) & "','" & CInt(dataGrid_detalleprodsVENTA.Item("imp2", J).Value) & "'," & CInt(dataGrid_detalleprodsVENTA.Item("impuesto", J).Value) & "," & CInt(dataGrid_detalleprodsVENTA.Item("impuesto2", J).Value) & "," & CInt(dataGrid_detalleprodsVENTA.Item("valoru", J).Value) & "," & CInt(dataGrid_detalleprodsVENTA.Item("valortotal", J).Value) & ",'DESCARGADO','" & CStr(dataGrid_detalleprodsVENTA.Item("INVENTARIADO", J).Value) & "','" & CStr(dataGrid_detalleprodsVENTA.Item("IMPNOM1", J).Value) & "','" & CStr(dataGrid_detalleprodsVENTA.Item("IMPNOM2", J).Value) & "','" & CStr(dataGrid_detalleprodsVENTA.Item("deci", J).Value) & "','" & CStr(dataGrid_detalleprodsVENTA.Item("costo", J).Value) & "','" & CStr(dataGrid_detalleprodsVENTA.Item("idbodega", J).Value) & "','" & inv_prod_lote & "')"
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




                        Me.Cursor = Cursors.WaitCursor

                Next
            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try




            '================================================================================================



            PROD_ENTRAN = CInt(totalapagar)
            PROD_SALDO = saldo
            PROD_SALDO = CInt(PROD_SALDO) + CInt(PROD_ENTRAN)
            PROD_SALEN = 0




            Dim pago() As String
            pago = Strings.Split(MEDIO_PAGO_DESTINO_COD, "|")
            'MEDIO DE Pgo
            sql = "INSERT INTO cajaspuc(Codcuenta, cuenta, TERCERO, Fecha, Documento, TipoDoc, Rol, SaldoAnt, debe, haber, Saldo, DETALLE, Estado, annoactual)" &
           "VALUES ('" & pago(0) & "','" & pago(1) & "','" & Textbox_Cliente_Doc.Text & "|" & Textbox_Cliente_Nom.Text & "','" & DateTime.Now.ToShortDateString & "','" & consecutivo & "','FACTURA DE VENTA','ENTRAN'," & saldo & "," & PROD_ENTRAN & "," & PROD_SALEN & "," & PROD_SALDO & ",'FACTURA DE VENTA','DESCARGADO','" & comex_annoactual & "')"
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


            'PROD_ENTRAN = 0
            'PROD_SALDO = 0
            'PROD_SALDO = 0
            'PROD_SALEN = 0



            ' ctapuc = inv_prod_cta_vender : ctapucNOM = "Comercio al Por Mayor y Menor de"

            ' 'contrapartida --------------------------------------
            ' saldo = 0


            ' PROD_SALEN = CInt(Label5.Text)
            ' If factura_con_imp Then PROD_SALEN = CInt(Label5.Text) - CInt(Label_iva.Text)
            ' PROD_SALDO = saldo
            ' PROD_SALDO = CInt(PROD_SALDO) + CInt(PROD_SALEN) ' 
            ' PROD_ENTRAN = 0 ' POR QUE QUE ES UNA venta
            ' 'REGISTRO EN PUC

            ' sql = "INSERT INTO cajaspuc(Codcuenta, cuenta, TERCERO, Fecha, Documento, TipoDoc, Rol, SaldoAnt, debe, haber, Saldo, DETALLE, Estado, annoactual)" &
            '"VALUES ('" & ctapuc & "','" & ctapucNOM & "','" & Label_DOCUMENTO_CLIENTE.Text & "|" & Label_NOMBRE_CLIENTE.Text & "','" & DateTime.Now.ToShortDateString & "','" & consecutivo & "','FACTURA DE VENTA','ENTRAN'," & saldo & "," & PROD_ENTRAN & "," & PROD_SALEN & "," & PROD_SALDO & ",'FACTURA DE VENTA','DESCARGADO','" & comex_annoactual & "')"
            ' da = New MySqlDataAdapter(sql, conex)
            ' dt = New DataTable
            ' Try
            '     da.Fill(dt)
            ' Catch ex As Exception
            '     MsgBox(ex.ToString)
            ' End Try
            ' da.Dispose()
            ' dt.Dispose()
            ' conex.Close()

            'partida de impusto   =======================================================================================
            If factura_con_imp = True Then

                '============================================================================
                '         ctapuc = "233575" : ctapucNOM = "Impuesto Nacional al Consumo"
                '         saldo = 0

                '         PROD_SALEN = CInt(Label_iva.Text)
                '         PROD_SALDO = saldo
                '         PROD_SALDO = CInt(PROD_SALDO) + CInt(PROD_SALEN) ' 
                '         PROD_ENTRAN = 0 ' POR QUE QUE ES UNA venta
                '         'REGISTRO EN PUC

                '         sql = "INSERT INTO cajaspuc(Codcuenta, cuenta, TERCERO, Fecha, Documento, TipoDoc, Rol, SaldoAnt, debe, haber, Saldo, DETALLE, Estado, annoactual)" &
                '"VALUES ('" & ctapuc & "','" & ctapucNOM & "','" & Label_DOCUMENTO_CLIENTE.Text & "|" & Label_NOMBRE_CLIENTE.Text & "','" & DateTime.Now.ToShortDateString & "','" & consecutivo & "','FACTURA DE VENTA','ENTRAN'," & saldo & "," & PROD_ENTRAN & "," & PROD_SALEN & "," & PROD_SALDO & ",'FACTURA DE VENTA','DESCARGADO','" & comex_annoactual & "')"
                '         da = New MySqlDataAdapter(sql, conex)
                '         dt = New DataTable
                '         Try
                '             da.Fill(dt)
                '         Catch ex As Exception
                '             MsgBox(ex.ToString)
                '         End Try
                '         da.Dispose()
                '         dt.Dispose()
                '         conex.Close()
                'partida de iva   =======================================================================================
            End If

            '     'partida de propina   =======================================================================================
            '     If .TextBox_propina.Text = "" Then .TextBox_propina.Text = "0"
            '     If .BunifuCheckbox_propina.Checked = True And .TextBox_propina.Text > 0 Then



            '         ctapuc = "2815" : ctapucNOM = "Propinas"
            '         saldo = 0


            '         PROD_SALEN = CInt(.TextBox_propina.Text)
            '         PROD_SALDO = saldo
            '         PROD_SALDO = CInt(PROD_SALDO) + CInt(PROD_SALEN) ' 
            '         PROD_ENTRAN = 0 ' POR QUE QUE ES UNA venta
            '         'REGISTRO EN PUC

            '         sql = "INSERT INTO cajaspuc(Codcuenta, cuenta, TERCERO, Fecha, Documento, TipoDoc, Rol, SaldoAnt, debe, haber, Saldo, DETALLE, Estado, annoactual)" &
            '"VALUES ('" & ctapuc & "','" & ctapucNOM & "','" & Label_DOCUMENTO_CLIENTE.Text & "|" & Label_NOMBRE_CLIENTE.Text & "','" & DateTime.Now.ToShortDateString & "','" & consecutivo & "','FACTURA DE VENTA','ENTRAN'," & saldo & "," & PROD_ENTRAN & "," & PROD_SALEN & "," & PROD_SALDO & ",'PROPINAS','DESCARGADO','" & comex_annoactual & "')"
            '         da = New MySqlDataAdapter(sql, conex)
            '         dt = New DataTable
            '         Try
            '             da.Fill(dt)
            '         Catch ex As Exception
            '             MsgBox(ex.ToString)
            '         End Try
            '         da.Dispose()
            '         dt.Dispose()
            '         conex.Close()

            '         'saca de  la propina del medio de pago caja
            '         pago = Strings.Split(MEDIO_PAGO_DESTINO_COD, "|")
            '         ctapuc = pago(0) : ctapucNOM = pago(1)
            '         saldo = 0




            '         PROD_SALEN = CInt(.TextBox_propina.Text)
            '         PROD_SALDO = saldo
            '         PROD_SALDO = CInt(PROD_SALDO) - CInt(PROD_SALEN) ' 
            '         PROD_ENTRAN = 0 ' POR QUE QUE ES UNA venta
            '         'REGISTRO EN PUC

            '         sql = "INSERT INTO cajaspuc(Codcuenta, cuenta, TERCERO, Fecha, Documento, TipoDoc, Rol, SaldoAnt, debe, haber, Saldo, DETALLE, Estado, annoactual)" &
            '"VALUES ('" & ctapuc & "','" & ctapucNOM & "','" & Label_DOCUMENTO_CLIENTE.Text & "|" & Label_NOMBRE_CLIENTE.Text & "','" & DateTime.Now.ToShortDateString & "','" & consecutivo & "','FACTURA DE VENTA','ENTRAN'," & saldo & "," & PROD_ENTRAN & "," & PROD_SALEN & "," & PROD_SALDO & ",'PROPINAS','DESCARGADO','" & comex_annoactual & "')"
            '         da = New MySqlDataAdapter(sql, conex)
            '         dt = New DataTable
            '         Try
            '             da.Fill(dt)
            '         Catch ex As Exception
            '             MsgBox(ex.ToString)
            '         End Try
            '         da.Dispose()
            '         dt.Dispose()
            '         conex.Close()
            '         'partida de PROPINA   =======================================================================================
            '     End If


            sql = "delete from ventas_pre where DOCUMENTO=" & CInt(Label_consecutivo.Text) & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                MsgBox("error al Borrar el Registro Invima.")
                Exit Sub
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()

            sql = "delete from ventas_prods_Temp where documento=" & CInt(Label_consecutivo.Text) & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                MsgBox("error al Borrar el Registro Invima.")
                Exit Sub
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()

            sql = "delete from ventas_dctos_temp where documento='" & Label_consecutivo.Text & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                MsgBox(ex.ToString)
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()
            Me.Cursor = Cursors.WaitCursor

            Me.Cursor = Cursors.Default
        End If
        fact_saveok = 1

        'cargo productos de la ventapara impr
        Try

            sql = "SELECT concat(codprod, '-', producto) as Producto, cantidad as Cant, IMP as IMP1, imp2 as IMP2, valortotal as ValorTotal FROM ventas_prods WHERE documento = " & CInt(consecutivo) & ""

            Da_IMPRIMIRPRODS = New MySqlDataAdapter(sql, conex)
            dt_imprimir_prods = New DataTable
            Da_IMPRIMIRPRODS.Fill(dt_imprimir_prods)
            Me.DataGridView1.DataSource = dt_imprimir_prods

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        Da_IMPRIMIRPRODS.Dispose()
        dt_imprimir_prods.Dispose()



        ' si imprime
        If CheckBox_print.CheckState = CheckState.Checked Then
            If comex_formatofactura = "Tiquete POS" Then
                If BunifuCheckbox_propina.Checked = True Then
                    imp_propina = TextBox_propina.Text
                Else
                    imp_propina = ""
                End If

                imp_titulo1 = comex_nombrecomercial
                imp_dir = comex_dircomercio
                imp_tels = comex_tels
                imp_propietario = comex_nombrepropietario
                imp_regimen = comex_regimen
                imp_nit = comex_nit & "-" & comex_DV
                imp_resdian = comex_Resdian
                imp_intervalo = comex_intervalo
                imp_factunum = consecutivo
                imp_fecha_factu = DateTime.Now.ToShortDateString
                imp_hora_factu = DateTime.Now.ToShortTimeString

                'imp_prod, imp_cant, imp_vrtotal, 
                imp_totalVenta = total_esta_venta
                imp_Descuento = descuento
                imp_subtotal = subtotal
                'Imp_baseimp = baseimpuesto
                'imp_impuesto = impuesto
                imp_totalapagar = totalapagar
                imp_efectivo = Me.TextBox_efectivo.Text
                imp_cambio = Me.Label_cambio_VR.Text
                imp_cajero = USR_NOM
                imp_mesero = ComboBox_mesero.Text
                Try
                    sql = "SELECT CodProd, Producto, 
concat('x',cantidad), format(valoru,0), concat('$',format(valortotal,0))
from ventas_prods
WHERE documento='" & consecutivo & "'"
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
where ventas.documento='" & consecutivo & "'
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
                    Try
                        alto_pag = ((MetroGrid_det_ventas.RowCount + MetroGrid_imp.RowCount) * 10) + 500
                        Dim pgSize = New iTextSharp.text.Rectangle(205, alto_pag)

                        Dim doc As New Document(pgSize, 8, 8, 10, 10)

                        'Path que guarda el reporte en el escritorio de windows (Desktop).
                        Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\factura " & consecutivo & ".pdf"
                        Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)

                        PdfWriter.GetInstance(doc, file)
                        doc.Open()
                        ExportarDatosPDF_POS(doc)
                        doc.Close()
                        'Process.Start(filename)
                    Catch ex As Exception
                        'Si el intento es fallido, mostrar MsgBox.
                        Me.Cursor = Cursors.Default
                        MessageBox.Show("error al imprimir recibo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                    'imprimir automaticamente  _______________________________________________________________________________________
                    'Dim psiPOS As System.Diagnostics.ProcessStartInfo = New System.Diagnostics.ProcessStartInfo()
                    'psiPOS.UseShellExecute = True
                    'psiPOS.Verb = "print"
                    'psiPOS.FileName = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\factura " & Label_CONSECUTIVO.Text & ".pdf"
                    'psiPOS.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
                    'psiPOS.ErrorDialog = False
                    'psiPOS.Arguments = "/p"
                    'Dim ppos As System.Diagnostics.Process = System.Diagnostics.Process.Start(psiPOS)
                    'ppos.WaitForInputIdle()

                    Dim instance As New Printing.PrinterSettings
                    Dim impresosaPredt As String = instance.PrinterName

                    Process.Start("C:\Program Files\Tracker Software\PDF Viewer\pdfxcview.exe", " /print:printer=""" & impresosaPredt & """ """ & Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\factura " & consecutivo & ".pdf" & """")


                Catch ex As Exception

                End Try

            End If

            If comex_formatofactura = "Media Carta" Then
                imp_totalVenta = total_esta_venta
                imp_Descuento = descuento
                imp_subtotal = subtotal
                'Imp_baseimp = baseimpuesto
                'imp_impuesto = impuesto
                imp_totalapagar = totalapagar
                Button_EXPORTAR_mediacarta()
            End If
        End If

    End Sub



    Private Sub TextBox_TOTALVENTA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_TOTALVENTA.KeyPress
        e.KeyChar = ""

    End Sub

    Private Sub TextBox_SUBTOTAL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_SUBTOTAL.KeyPress
        e.KeyChar = ""

    End Sub

    Private Sub TextBox_Total_impuestos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_Total_impuestos.KeyPress
        e.KeyChar = ""

    End Sub

    Private Sub TextBox_DESCUENTO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_DESCUENTO.KeyPress
        e.KeyChar = ""

    End Sub

    Private Sub TextBox_propina_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_propina.KeyPress
        e.KeyChar = ""

    End Sub

    Private Sub TextBox_efectivo_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_efectivo.KeyDown

    End Sub

    Private Sub TextBox_efectivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_efectivo.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""

    End Sub

    Private Sub Label_mesa_MouseDown(sender As Object, e As MouseEventArgs) Handles Label_mesa.MouseDown
        If Label_mesa.Text = "" Then Exit Sub

        If e.Button = System.Windows.Forms.MouseButtons.Right = False Then
            Label_mesa.ContextMenuStrip = ContextMenu_zona
            Me.ContextMenu_zona.Show(Label_mesa, New Point(Label_mesa.Width - Label_mesa.Width, Label_mesa.Height))
        End If

    End Sub

    Private Sub TextBox_otroprecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_otroprecio.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""

    End Sub





    '||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||





    Private Sub TextBox_propina_TextChanged(sender As Object, e As EventArgs) Handles TextBox_propina.TextChanged

    End Sub

    Private Sub TextBox_Total_impuestos_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Total_impuestos.TextChanged

    End Sub
    Private Sub TextBox_SUBTOTAL_TextChanged(sender As Object, e As EventArgs) Handles TextBox_SUBTOTAL.TextChanged

    End Sub

    Private Sub TextBox_TOTAL_pagar_TextChanged(sender As Object, e As EventArgs) Handles TextBox_TOTAL_pagar.TextChanged

    End Sub

    Private Sub TextBox_efectivo_TextChanged(sender As Object, e As EventArgs) Handles TextBox_efectivo.TextChanged
        If Me.TextBox_efectivo.Text = "" Then Me.TextBox_efectivo.Text = 0
        If Me.TextBox_TOTAL_pagar.Text <> "" Then Me.Label_cambio_VR.Text = CInt(Me.TextBox_efectivo.Text) - CInt(Me.TextBox_TOTAL_pagar.Text)

    End Sub
    Private Sub Label_mesa_Click(sender As Object, e As EventArgs) Handles Label_mesa.Click

    End Sub
    Private Sub Label25_Click(sender As Object, e As EventArgs) Handles Label25.Click

    End Sub

    Private Sub Textbox_buscar_prod_Click(sender As Object, e As EventArgs) Handles Textbox_buscar_prod.Click

        dataGrid_detalleprodsVENTA.ClearSelection()

    End Sub

    Private Sub TextBox_cant_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_cant.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub Form_sales_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.F1) Then
            If Label_estado.Text.ToUpper = "CUENTA PENDIENTE" And dataGrid_detalleprodsVENTA.Rows.Count = 0 Then
                Label_lcd.Text = "Tiene una cuenta activa sin items, utilice la cuenta actual antes de crear una nueva."
                Timer_LcdOff.Enabled = True
                Exit Sub
            End If
            Button_nueva_cuenta_Click(Nothing, Nothing)
            Exit Sub
        End If


        If (e.KeyCode = Keys.F4) Then
            If Button_anular_cuenta.Enabled = False Then Exit Sub

            Button_anular_cuenta_Click(Nothing, Nothing)
        End If


        If (e.KeyCode = Keys.F11) And Panel_TOTAL.Visible = False Then
            Button_COBRAR_Click(Nothing, Nothing)
            Exit Sub
        End If


        If (e.KeyCode = Keys.F12) And Panel_TOTAL.Visible = True Then
            Button_pagar_ok_Click(Nothing, Nothing)
            Exit Sub
        End If


        If (e.KeyCode = Keys.Escape) And Panel_TOTAL.Visible = True Then
            Button4_Click(Nothing, Nothing)
            Exit Sub
        End If
    End Sub

    Private Sub Textbox_buscar_prod_KeyUp(sender As Object, e As KeyEventArgs) Handles Textbox_buscar_prod.KeyUp

    End Sub
End Class