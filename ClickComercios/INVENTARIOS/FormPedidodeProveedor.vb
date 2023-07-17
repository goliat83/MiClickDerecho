Imports System.Environment
Imports System.Globalization
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.draw

Public Class FormPedidodeproveedor
    Public da_contact_venta As New MySqlDataAdapter
    Public dt_contact_venta As New DataTable

    Public da_MediosPago As New MySqlDataAdapter
    Public dt_MediosPago As New DataTable

    Public da_CuentasPago As New MySqlDataAdapter
    Public dt_CuentasPago As New DataTable

    Dim ctapuc As String = ""
    Dim ctapucNOM As String = ""

    Dim factura_con_imp As Boolean = False
    Dim factura_con_rete As Boolean = False

    Dim QUE_HACE_CLIENTE As String
    Dim MEDIO_PAGO_DESTINO_FULL() As String
    Dim MEDIO_PAGO_DESTINO_COD As String
    Dim MEDIO_PAGO_DESTINO_NOMBRE, MEDIO_PAGO_DESTINO_TIPO As String
    Dim filtro As String = "TODO"
    Dim CodDocumento As Long = 0
    Dim desktop2 As String = Environment.GetFolderPath(SpecialFolder.DesktopDirectory)
    Dim NRO_FACTURA As String = ""
    Dim PROD_SALDO, PROD_ENTRAN, PROD_SALEN As String
    Dim prod_cons, prod_cod, prod_barras, prod_nom, prod_desc, PROD_VALOR_UNITARIO_BASE, prod_valor, prod_valor2, prod_valor3, PROD_CATEGORIA, prod_iva, prod_iva2, PROD_IVATIPO, PROD_IVATIPO2, prod_iva1nom, prod_iva2nom, prod_base, PROD_IVA_VR, PROD_IVA_VR2, prod_stock, prod_imagen, prod_decimal, PROD_INVENTARIADO, PROD_COSTO, PROD_COSTO_PROM As String
    Dim PROD_RETEFUENTE, PROD_RETEFUENTE_VALOR, PROD_RETEFUENTE_TOTAL As String
    Dim SALDO_DEL_PRODUCTO As Integer = 0
    Dim SALDO_DEL_PRODUCTO_aqui As Integer = 0
    Dim entran, salen, saldo As Integer
    Dim CODCUENTAPUC, CODCUENTAPUCNOMBRE As String
    Dim cli_nom, cli_tel, cli_dir, cli_doc, cli_mail, CLI_DECLARANTE, CLI_AUTORETENEDOR, CLI_AGENTERETENEDOR As String

    Dim mes_num As Integer
    Dim mes_num_text As String
    Dim mes_num_text_general As String



    Private Sub Formpedidoclientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datagrid_PEDIDOS.BringToFront()
        'If comex_fondo = "AZUL" Then
        '    Me.BackColor = Color.FromArgb(164, 187, 212)
        '    Label_tipomovimiento.ForeColor = Color.Black
        '    Label47.ForeColor = Color.Black
        '    Label50.ForeColor = Color.Black
        '    Label33.ForeColor = Color.Black
        '    Label34.ForeColor = Color.Black
        '    Label44.ForeColor = Color.Black
        '    Label24.ForeColor = Color.Black

        '    Label54.ForeColor = Color.Black
        '    Label16.ForeColor = Color.Black
        '    Label1.ForeColor = Color.Black
        '    Label8.ForeColor = Color.Black
        '    Label37.ForeColor = Color.Black

        '    Label40.ForeColor = Color.Black
        '    Label22.ForeColor = Color.Black
        '    Label28.ForeColor = Color.Black
        '    Label52.ForeColor = Color.Black
        '    Label9.ForeColor = Color.Black
        '    Label3.ForeColor = Color.Black
        '    Label5.ForeColor = Color.Black
        '    Label4.ForeColor = Color.Black
        '    Label14.ForeColor = Color.Black

        '    CheckBox_retefuente.ForeColor = Color.Black
        '    CheckBox_reteica.ForeColor = Color.Black
        '    CheckBox_reteIVA.ForeColor = Color.Black

        '    ComboBox_periodo.BackColor = Color.FromArgb(164, 187, 212) : ComboBox_periodo.ForeColor = Color.Black
        '    ComboBox_filtroprov.BackColor = Color.FromArgb(164, 187, 212) : ComboBox_filtroprov.ForeColor = Color.Black

        'End If
        'If comex_fondo = "NEGRO" Then
        '    Me.BackColor = Color.FromArgb(28, 28, 28)
        '    Label_tipomovimiento.ForeColor = Color.White
        '    Label47.ForeColor = Color.White
        '    Label50.ForeColor = Color.White
        '    Label33.ForeColor = Color.White
        '    Label34.ForeColor = Color.White
        '    Label44.ForeColor = Color.White
        '    Label24.ForeColor = Color.White

        '    Label54.ForeColor = Color.White
        '    Label16.ForeColor = Color.White
        '    Label1.ForeColor = Color.White
        '    Label8.ForeColor = Color.White
        '    Label37.ForeColor = Color.White

        '    Label40.ForeColor = Color.White
        '    Label22.ForeColor = Color.White
        '    Label28.ForeColor = Color.White
        '    Label52.ForeColor = Color.White
        '    Label9.ForeColor = Color.White

        '    Label3.ForeColor = Color.White
        '    Label5.ForeColor = Color.White
        '    Label4.ForeColor = Color.White
        '    Label14.ForeColor = Color.White

        '    CheckBox_retefuente.ForeColor = Color.White
        '    CheckBox_reteica.ForeColor = Color.White
        '    CheckBox_reteIVA.ForeColor = Color.White


        '    ComboBox_periodo.BackColor = Color.Azure : ComboBox_periodo.ForeColor = Color.Black
        '    ComboBox_filtroprov.BackColor = Color.Azure : ComboBox_filtroprov.ForeColor = Color.Black


        'End If
    End Sub

    Private Sub Formpedidoclientes_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        mes_num = DateTime.Now.Month()
        mes_num_text = CStr(mes_num)

        If mes_num <= 9 Then mes_num_text = "0" & CStr(mes_num)
        ComboBox_periodo.SelectedIndex = mes_num_text - 1

        NumericUpDown_anno.Value = DateTime.Now.Year()


        load_grid_PEDIDOS_provs()




        'LLENADO vendedores
        Try
            sql = "SELECT * FROM empleados where cargo='Vendedor'"
            da = New MySqlDataAdapter(sql, conex)
            dt_RUTAS_COMBO = New DataTable
            da.Fill(dt_RUTAS_COMBO)
            Me.Label_VENDEDOR.DataSource = dt_RUTAS_COMBO.DefaultView
            Me.Label_VENDEDOR.DisplayMember = "nombre"
            Me.Label_VENDEDOR.ValueMember = "cons"
            Me.Label_VENDEDOR.AutoCompleteSource = AutoCompleteSource.ListItems
            Me.Label_VENDEDOR.AutoCompleteMode = AutoCompleteMode.Suggest
            Me.Label_VENDEDOR.SelectedItem = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt_RUTAS_COMBO.Dispose()
        conex.Close()



        Try
            sql = "SELECT tipo, mediopago FROM medios_pago
where tipo<>'CARTERA' order by cons"
            da_MediosPago = New MySqlDataAdapter(sql, conex)
            dt_MediosPago = New DataTable
            da_MediosPago.Fill(dt_MediosPago)
            Me.ComboBox_MedioPago.DataSource = dt_MediosPago.DefaultView
            Me.ComboBox_MedioPago.DisplayMember = "mediopago"
            Me.ComboBox_MedioPago.ValueMember = "tipo"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_MediosPago.Dispose()
        dt_MediosPago.Dispose()
        conex.Close()
        ComboBox_MedioPago.SelectedItem = Nothing




        ComboBox_CuentaPago.SelectedItem = Nothing

        ''LLENADO contactos QUE SON PROVEEDORES para filtro de pedidos
        Try
            sql = "SELECT documento, nombre FROM proveedores WHERE PROVEEDOR='SI' or cliente='SI'"
            da_contact_mov = New MySqlDataAdapter(sql, conex)
            DT_contact_mov = New DataTable
            da_contact_mov.Fill(DT_contact_mov)
            Me.ComboBox_filtroprov.DataSource = DT_contact_mov.DefaultView
            Me.ComboBox_filtroprov.DisplayMember = "nombre"
            Me.ComboBox_filtroprov.ValueMember = "documento"
            Me.ComboBox_filtroprov.AutoCompleteSource = AutoCompleteSource.ListItems
            Me.ComboBox_filtroprov.AutoCompleteMode = AutoCompleteMode.Suggest
            Me.ComboBox_filtroprov.SelectedItem = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        DT_contact_mov.Dispose()
        da_contact_mov.Dispose()
        conex.Close()

        If ID_compra_VER <> "" Then
            CodDocumento = ID_compra_VER
            Btn_Ver_editar_Click(Nothing, Nothing)
            ID_compra_VER = ""
        End If

        'cargo bodega de compras
        ComboBox_bodega_destino.Items.Add(comex_bodega_compras)
        ComboBox_bodega_destino.SelectedItem = comex_bodega_compras
    End Sub




    Private Sub load_grid_PEDIDOS_provs()
        Try
            sql = "select * from pedidosprov where  month(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & mes_num_text & "' and year(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & NumericUpDown_anno.Value & "'"
            'sql = "SELECT pedidosprov.Cons, pedidosprov.Fecha, pedidosprov.FechaEntrega, pedidosprov.CodCliente, pedidosprov.Cliente, pedidosprov.Observaciones, pedidosprov.EmpleadoCod, pedidosprov.Empleado, pedidosprov.Estado, pedidosprov.fechaPago, pedidosprov.Cargue, pedidosprov.CodCargue, pedidosprov.Ruta, pedidosprov.Descargado, pedidosprov.Facturado, pedidosprov.NroFac, pedidosprov.ServicioT, pedidosprov.Tecnico, pedidosprov.RETEFUENTE, pedidosprov.RETE_VR, pedidosprov.RETE_TOTAL, pedidosprov.descuento, pedidosprov.FacturaP, pedidosprov.MedioPago, pedidosprov.anulado, sum(CAST(CONVERT(REPLACE(CAST(pedidosprov_prods.valortotal AS CHAR),',','.'),decimal(12,2)) AS DECIMAL(12,2))) as Total from pedidosprov, pedidosprov_prods where pedidosprov.cons=pedidosprov_prods.codprod and year(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & comex_annoactual & "'"
            If ComboBox_filtroprov.Text <> "" Then sql = "select * from pedidosprov where month(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & mes_num_text & "' and year(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & NumericUpDown_anno.Value & "' and codcliente='" & ComboBox_filtroprov.SelectedValue.ToString & "'"
            'sql = SELECT pedidosprov.Cons, pedidosprov.Fecha, pedidosprov.FechaEntrega, pedidosprov.CodCliente, pedidosprov.Cliente, pedidosprov.Observaciones, pedidosprov.EmpleadoCod, pedidosprov.Empleado, pedidosprov.Estado, pedidosprov.fechaPago, pedidosprov.Cargue, pedidosprov.CodCargue, pedidosprov.Ruta, pedidosprov.Descargado, pedidosprov.Facturado, pedidosprov.NroFac, pedidosprov.ServicioT, pedidosprov.Tecnico, pedidosprov.RETEFUENTE, pedidosprov.RETE_VR, pedidosprov.RETE_TOTAL, pedidosprov.descuento, pedidosprov.FacturaP, pedidosprov.MedioPago, pedidosprov.anulado, sum(CAST(CONVERT(REPLACE(CAST(pedidosprov_prods.valortotal AS CHAR),',','.'),decimal(12,2)) AS DECIMAL(12,2))) from pedidosprov, pedidosprov_prods where pedidosprov.cons=pedidosprov_prods.codprod and year(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & pedidosprov.comex_annoactual & "' and pedidosprov.codcliente='" & pedidosprov.ComboBox_filtroprov.SelectedValue.ToString & "';

            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.datagrid_PEDIDOS.DataSource = dt
            Me.datagrid_PEDIDOS.Columns(0).HeaderText = "Pedido"
            Me.datagrid_PEDIDOS.Columns(0).Width = 60
            Me.datagrid_PEDIDOS.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.datagrid_PEDIDOS.Columns(1).HeaderText = "Fecha"
            Me.datagrid_PEDIDOS.Columns(1).Width = 90
            Me.datagrid_PEDIDOS.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.datagrid_PEDIDOS.Columns(2).Visible = False
            Me.datagrid_PEDIDOS.Columns(3).Visible = False
            Me.datagrid_PEDIDOS.Columns(4).HeaderText = "Proveedor"
            Me.datagrid_PEDIDOS.Columns(4).Width = 300
            Me.datagrid_PEDIDOS.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagrid_PEDIDOS.Columns(5).Visible = False
            Me.datagrid_PEDIDOS.Columns(6).Visible = False
            Me.datagrid_PEDIDOS.Columns(7).Visible = False
            Me.datagrid_PEDIDOS.Columns(8).HeaderText = "Estado"
            Me.datagrid_PEDIDOS.Columns(8).Width = 110
            Me.datagrid_PEDIDOS.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.datagrid_PEDIDOS.Columns(9).Visible = False
            Me.datagrid_PEDIDOS.Columns(10).Visible = False
            Me.datagrid_PEDIDOS.Columns(11).Visible = False
            Me.datagrid_PEDIDOS.Columns(12).Visible = False

            Me.datagrid_PEDIDOS.Columns(13).HeaderText = "Descargado"
            Me.datagrid_PEDIDOS.Columns(13).Width = 100
            Me.datagrid_PEDIDOS.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.datagrid_PEDIDOS.Columns(14).HeaderText = "Pagado"
            Me.datagrid_PEDIDOS.Columns(14).Width = 100
            Me.datagrid_PEDIDOS.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.datagrid_PEDIDOS.Columns(15).Visible = False
            Me.datagrid_PEDIDOS.Columns(16).Visible = False
            Me.datagrid_PEDIDOS.Columns(17).Visible = False
            Me.datagrid_PEDIDOS.Columns(18).Visible = False
            Me.datagrid_PEDIDOS.Columns(19).Visible = False
            Me.datagrid_PEDIDOS.Columns(20).Visible = False
            Me.datagrid_PEDIDOS.Columns(21).Visible = False
            Me.datagrid_PEDIDOS.Columns(22).Visible = False
            Me.datagrid_PEDIDOS.Columns(23).Visible = False
            Me.datagrid_PEDIDOS.Columns(24).Visible = False
            Me.datagrid_PEDIDOS.Columns(25).Visible = False


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        Me.datagrid_PEDIDOS.ClearSelection()

        Try
            For i As Integer = 0 To datagrid_PEDIDOS.RowCount - 1
                If datagrid_PEDIDOS.Item("estado", i).Value = "ANULADO" Then datagrid_PEDIDOS.Rows(i).DefaultCellStyle.ForeColor = Color.Brown

            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        Me.datagrid_PEDIDOS.ClearSelection()
    End Sub

    Private Sub load_grid_PEDIDOS_CLIENTES_FILTRO(ByRef filtro_estado As String)
        Try
            sql = "select * from pedidosprov where estado='" & filtro_estado & "' and year(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & comex_annoactual & "'"
            If ComboBox_filtroprov.Text <> "" Then sql = "select * from pedidosprov where estado='" & filtro_estado & "' and year(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & comex_annoactual & "' and codcliente='" & ComboBox_filtroprov.SelectedValue.ToString & "'"

            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.datagrid_PEDIDOS.DataSource = dt
            Me.datagrid_PEDIDOS.Columns(0).HeaderText = "Pedido"
            Me.datagrid_PEDIDOS.Columns(0).Width = 60
            Me.datagrid_PEDIDOS.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.datagrid_PEDIDOS.Columns(1).HeaderText = "Fecha"
            Me.datagrid_PEDIDOS.Columns(1).Width = 90
            Me.datagrid_PEDIDOS.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.datagrid_PEDIDOS.Columns(2).Visible = False
            Me.datagrid_PEDIDOS.Columns(3).Visible = False
            Me.datagrid_PEDIDOS.Columns(4).HeaderText = "Cliente"
            Me.datagrid_PEDIDOS.Columns(4).Width = 300
            Me.datagrid_PEDIDOS.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagrid_PEDIDOS.Columns(5).Visible = False
            Me.datagrid_PEDIDOS.Columns(6).Visible = False
            Me.datagrid_PEDIDOS.Columns(7).Visible = False
            Me.datagrid_PEDIDOS.Columns(8).HeaderText = "Estado"
            Me.datagrid_PEDIDOS.Columns(8).Width = 110
            Me.datagrid_PEDIDOS.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.datagrid_PEDIDOS.Columns(9).Visible = False
            Me.datagrid_PEDIDOS.Columns(10).Visible = False
            Me.datagrid_PEDIDOS.Columns(11).Visible = False
            Me.datagrid_PEDIDOS.Columns(12).HeaderText = "Descargado"
            Me.datagrid_PEDIDOS.Columns(12).Width = 100
            Me.datagrid_PEDIDOS.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.datagrid_PEDIDOS.Columns(13).HeaderText = "Facturado"
            Me.datagrid_PEDIDOS.Columns(13).Width = 100
            Me.datagrid_PEDIDOS.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.datagrid_PEDIDOS.Columns(14).Visible = False
            Me.datagrid_PEDIDOS.Columns(15).Visible = False
            Me.datagrid_PEDIDOS.Columns(16).Visible = False
            Me.datagrid_PEDIDOS.Columns(17).Visible = False
            Me.datagrid_PEDIDOS.Columns(18).Visible = False
            Me.datagrid_PEDIDOS.Columns(19).Visible = False
            Me.datagrid_PEDIDOS.Columns(20).Visible = False
            Me.datagrid_PEDIDOS.Columns(21).Visible = False
            Me.datagrid_PEDIDOS.Columns(22).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        Me.datagrid_PEDIDOS.ClearSelection()

    End Sub

    Private Sub Btn_nuevo_mov_Click(sender As Object, e As EventArgs) Handles Btn_nuevo_mov.Click

        If PERMISO_1(20) = "NO" Or PERMISO_1(20) = Nothing Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub




        Me.Label_VENDEDOR.Text = "" : Me.TextBox_buscar_cod.Text = "" : Me.TextBox_buscar_barras.Text = ""

        'reseteo datos del producto
        Me.TextBox_valorunitario.Text = "0" : Me.NumericUpDown_CANT.Value = "0" : Me.TextBox_Total.Text = "0"
        Me.CheckBox_retefuente.Visible = False

        'botones agregar o quitar prods
        Me.Button_agregar_prod.Visible = False
        Me.button_Quitar_Prod.Visible = False


        'bonotes amarillos
        Me.Panel_dock.Visible = False

        'panel prods

        PROD_RETEFUENTE = ""
        PROD_RETEFUENTE_VALOR = ""
        PROD_RETEFUENTE_TOTAL = ""


        'consecutivo
        consecutivo = 0
        cmd.Connection = conex
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select max(cons) + 1 from pedidosprov"
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

        Me.Label_consecutivo.Text = consecutivo : Me.Label_fecha.Text = DateTime.Now.ToShortDateString
        Me.TextBox_responsable.Text = usrnom
        Me.TextBox_nrofacprov.Text = ""

        Me.TextBoxTotalDoc.Text = 0
        Me.TextBox_dcto.Text = 0
        Me.TextBoxTotalDoc.Text = 0
        Me.TextBox_subtotal.Text = 0

        Me.datagrid_PEDIDOS.Visible = False

        Me.Button_FACTURAR.Text = "Facturar"
        Me.Button_descargar.Text = "Ingresar a Bodega"

        OCULTO_OPCIONES_BOTONES()
        Me.Button_finalizar.Visible = False : Me.Button_ANULAR.Visible = False
        Me.Button_descargar.Visible = False : Me.Button_FACTURAR.Visible = False

        Me.Button_EXPORTAR.Visible = True
        Me.Button_guardar.Text = "Guardar"
        Me.Button_guardar.Visible = False
        Me.Button_EXPORTAR.Visible = False
        Me.ComboBox_CuentaPago.Enabled = True

        'servicio tecnico
        'Me.TextBox_serv_descrip.Text = ""
        'Me.CheckBox_servicioTecnico.CheckState = CheckState.Checked
        'Me.Label_serv_des.Visible = True
        'Me.TextBox_serv_descrip.Visible = True


        Me.Button_continuar.Visible = True
        Panel_filtro.Visible = False
        Label50.Visible = False
        Label47.Visible = False
        Button4.Visible = False
        ComboBox_CuentaPago.SelectedItem = Nothing


        ComboBox_bodega_destino.Items.Clear()
        ComboBox_bodega_destino.Items.Add(comex_bodega_compras)
        ComboBox_bodega_destino.Text = comex_bodega_compras


        Me.Panel_prods.Enabled = False

        Me.panel_proveedores.Visible = True
        Me.panel_proveedores.Enabled = True
        TextBox_BUSCAR_PROV.Focus()

    End Sub
    Private Sub OCULTO_OPCIONES_BOTONES()
        Me.Button_finalizar.Enabled = False
        Me.Button_ANULAR.Enabled = False
        Me.Button_FACTURAR.Enabled = False
        Me.Button_descargar.Enabled = False
        Me.Button_EXPORTAR.Enabled = True

        Me.Button_guardar.Enabled = True
        Me.Button_Regresar.Enabled = True

        Me.Button_finalizar.Visible = True
        Me.Button_ANULAR.Visible = True
        Me.Button_FACTURAR.Visible = True
        Me.Button_descargar.Visible = True
        Me.Button_EXPORTAR.Visible = True
        Me.Button_guardar.Visible = True
        Me.Button_Regresar.Visible = True

    End Sub
    Private Sub MetroDateTime1_ValueChanged(sender As Object, e As EventArgs) Handles MetroDateTime1.ValueChanged
        Me.Label_fechaentrega.Text = MetroDateTime1.Value.ToShortDateString
    End Sub



    Private Sub Button_guardar_Click(sender As Object, e As EventArgs) Handles Button_guardar.Click
        If PERMISO_1(21) = "NO" Or PERMISO_1(21) = Nothing Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub




        If Me.Button_guardar.Text = "Guardar Cambios" And Label_estado_movimiento.Text = "PENDIENTE" Then

            sql = "UPDATE pedidosprov SET CODcliente='" & TXT_DOC_CLIENTE.Text & "', cliente='" & TXT_NOM_CLIENTE.Text & "', FECHAENTREGA='" & Label_fechaentrega.Text & "', fechapago='" & Me.Label_fechapago.Text & "', OBSERVACIONES='" & Text_leyenda.Text & "', RETEFUENTE='" & "" & "', RETE_VR='" & "" & "', RETE_TOTAL='" & Me.TextBox_retenciones.Text & "', descuento='" & CInt(Me.TextBox_dcto.Text) & "', facturap='" & CStr(TextBox_nrofacprov.Text) & "', mediopago='" & ComboBox_CuentaPago.Text & "', tecnico='" & Label_VENDEDOR.Text & "', BODEGA='" & comex_bodega_compras & "' WHERE CONS=" & CLng(Label_consecutivo.Text) & ""
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

            Me.datagrid_PEDIDOS.Visible = True
            Me.Panel_dock.Visible = True
            CodDocumento = 0

            load_grid_PEDIDOS_provs()

            Exit Sub
        End If

    End Sub

    Private Sub loads_productos(ByVal critero As String, ByRef dato As String)
        'LLENADO DE PRODUCTOS COMBO
        Try
            If critero = "" Then sql = "SELECT productos.*,CONCAT(TIPO,' |',NOMBRE) AS NOMBRES FROM productos where inventariado='SI' and tipo NOT IN('PRODUCTOS PROCESADOS','SERVICIOS') order by TIPO, nombre"
            If critero = "nombre" Then sql = "SELECT productos.*,CONCAT(TIPO,' |',NOMBRE) AS NOMBRES FROM productos where inventariado='SI' and nombre like '%" & dato & "%' AND tipo NOT IN('PRODUCTOS PROCESADOS','SERVICIOS') order by TIPO, nombre"
            If critero = "barras" Then sql = "SELECT productos.*,CONCAT(TIPO,' |',NOMBRE) AS NOMBRES FROM productos where inventariado='SI' and codbarras='" & dato & "' AND tipo NOT IN('PRODUCTOS PROCESADOS','SERVICIOS') order by TIPO, nombre"
            If critero = "codigo" Then sql = "SELECT productos.*,CONCAT(TIPO,' |',NOMBRE) AS NOMBRES FROM productos where inventariado='SI' and cod='" & dato & "' AND tipo NOT IN('PRODUCTOS PROCESADOS','SERVICIOS') order by TIPO, nombre"

            da = New MySqlDataAdapter(sql, conex)
            dt_prodscombo = New DataTable
            da.Fill(dt_prodscombo)
            Me.Datagrid_prods_catalogo.DataSource = dt_prodscombo
            Me.combobox_BuscarProd.DataSource = dt_prodscombo.DefaultView
            Me.combobox_BuscarProd.DisplayMember = "nombreS"
            Me.combobox_BuscarProd.ValueMember = "cod"
            Me.combobox_BuscarProd.AutoCompleteSource = AutoCompleteSource.ListItems
            Me.combobox_BuscarProd.AutoCompleteMode = AutoCompleteMode.Suggest
            Me.combobox_BuscarProd.SelectedItem = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt_prodscombo.Dispose()
        conex.Close()
    End Sub



    Private Sub TextBox_responsable_TextChanged(sender As Object, e As EventArgs) Handles TextBox_responsable.TextChanged

    End Sub

    Private Sub TextBox_responsable_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_responsable.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub TextBoxTotalDoc_TextChanged(sender As Object, e As EventArgs) Handles TextBoxTotalDoc.TextChanged

    End Sub

    Private Sub TextBoxTotalDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxTotalDoc.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub Label_fechaentrega_Click(sender As Object, e As EventArgs) Handles Label_fechaentrega.Click

    End Sub

    Private Sub Button_agregar_prod_Click(sender As Object, e As EventArgs) Handles Button_agregar_prod.Click

        'If PROD_INVENTARIADO = "SI" Then
        '    Try
        '        Me.Cursor = Cursors.WaitCursor
        '        BUSCA_SALDO_PRODUCTO()
        '        BUSCA_SALDO_PRODUCTO_aqui()

        '        Me.Cursor = Cursors.Default
        '    Catch ex As Exception
        '        Me.Cursor = Cursors.Default
        '        MsgBox(ex.ToString)
        '    End Try

        '    If SALDO_DEL_PRODUCTO < NumericUpDown_CANT.Value Then
        '        'MsgBox("No hay Existencias suficientes del producto " & Chr(13) & Chr(13) & "Producto: " & prod_nom & Chr(13) & "Saldo Actual: " & SALDO_DEL_PRODUCTO + NumericUpDown_CANT.Value, vbExclamation)

        '        Me.Label_info.Text = "No hay Existencias suficientes del producto " & Chr(13) & Chr(13) & "Producto: " & prod_nom & Chr(13) & "Saldo Actual: " & SALDO_DEL_PRODUCTO
        '        Me.Button_info.Visible = True
        '        'Exit Sub
        '    End If
        '    If SALDO_DEL_PRODUCTO <= 0 Then
        '        'MsgBox("No hay Existencias del producto " & Chr(13) & Chr(13) & "Producto: " & prod_nom & Chr(13) & "Saldo Actual: " & SALDO_DEL_PRODUCTO + NumericUpDown_CANT.Value, vbExclamation)
        '        Me.Label_info.Text = "No hay Existencias suficientes del producto " & Chr(13) & Chr(13) & "Producto: " & prod_nom & Chr(13) & "Saldo Actual: " & SALDO_DEL_PRODUCTO
        '        Me.Button_info.Visible = True
        '        'Exit Sub
        '    End If
        'End If

        If Me.Label_estado_movimiento.Text = "Nuevo" Then
            MsgBox("Antes de agregar productos a la lista debe guardar la compra.", vbIgnore) : Exit Sub
        End If

        If NumericUpDown_CANT.Value = 0 Then MsgBox("Falta la Cantidad.") : Exit Sub
        If Me.TextBox_valorunitario.Text = 0 Then MsgBox("Falta el valor unitario.") : Exit Sub


        Button_agregar_prod.Enabled = False

        Me.TextBox_Total.Text = Math.Round((CDec(Me.NumericUpDown_CANT.Value) * CDec(TextBox_valorunitario.Text)), 2)


        PROD_VALOR_UNITARIO_BASE = 0
        If prod_decimal = "SI" Then PROD_VALOR_UNITARIO_BASE = CDec(TextBox_valorunitario.Text)
        If prod_decimal = "NO" Then PROD_VALOR_UNITARIO_BASE = CInt(TextBox_valorunitario.Text)

        If prod_iva2nom <> "NO" Then  'CALCULAMOS EL IVA
            PROD_VALOR_UNITARIO_BASE = CDec(PROD_VALOR_UNITARIO_BASE / ((CDec(prod_iva2) / 100) + 1))
            PROD_IVA_VR2 = CDec(TextBox_valorunitario.Text) - CDec(PROD_VALOR_UNITARIO_BASE)

            PROD_VALOR_UNITARIO_BASE = Math.Round(CDec(PROD_VALOR_UNITARIO_BASE), 2)

            PROD_IVA_VR2 = Math.Round(CDec(PROD_IVA_VR2), 2)

        End If

        If prod_iva1nom <> "NO" Then  ' calculamos ico
            PROD_VALOR_UNITARIO_BASE = CDec(PROD_VALOR_UNITARIO_BASE) - CDec(prod_iva)
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


        If prod_iva2nom <> "NO" Then  'CALCULAMOS EL IVA
            PROD_COSTO = PROD_VALOR_UNITARIO_BASE
        End If

        ' costo ----------------------

        'prod costo para guardar en eel pedido
        If comex_costo = "RETAIL" Or comex_costo = "" Then PROD_COSTO = TextBox_valorunitario.Text

        If comex_costo <> "RETAIL" Then
            ' SI ES REATIL SE USA EL DEL ESTANDARD DEL PRODUCTO
            ' SI ES CERO SE USA ELESTARDAR DEL RPODUCTO 
            Try
                If comex_costo = "PROMEDIO" Then sql = "SELECT IFNULL(AVG(VALORU),0) as promedio FROM BODEGA_PRINCIPAL where codproducto='" & CInt(prod_cod) & "' AND TIPODOCUMENTO IN('Entrada de Mercancia','Inventario Inicial','COMPRA') and estado='DESCARGADO'"
                If comex_costo = "MAXIMO" Then sql = "SELECT IFNULL(MAX(VALORU),0) FROM BODEGA_PRINCIPAL where codproducto='" & CInt(prod_cod) & "' AND TIPODOCUMENTO IN('Entrada de Mercancia','Inventario Inicial','COMPRA') and estado='DESCARGADO'"
                If comex_costo = "ULTIMO" Then sql = "SELECT MAX(CONS), IFNULL(VALORU,0) FROM BODEGA_PRINCIPAL where codproducto='" & CInt(prod_cod) & "' AND TIPODOCUMENTO IN('Entrada de Mercancia','Inventario Inicial','COMPRA') and estado='DESCARGADO'"

                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                da.Fill(dt)
                For Each row As DataRow In dt.Rows
                    If CInt(row.Item("promedio")) <> 0 Then
                        PROD_COSTO = Math.Round(CDec(row.Item("promedio")), 2)
                    End If
                Next
                PROD_COSTO = Math.Round(CDec(PROD_COSTO), 2) + Math.Round(CDec(TextBox_valorunitario.Text) / 2, 2)
            Catch ex As Exception

            End Try

            da.Dispose()
            dt.Dispose()
            conex.Close()
        End If

        If IsNumeric(Label58.Text) = False Then Exit Sub

        Me.Cursor = Cursors.WaitCursor
        sql = "INSERT INTO pedidosprov_prods (documento, codprod, producto, cantidad, base, imp, IMP2, impuesto, IMPUESTO2, valoru, valortotal, estado,  inventariado, IMPNOM1, IMPNOM2, deci, COSTO, lote, vence)" &
                    "VALUES (" & CInt(Me.Label_consecutivo.Text) & "," & CInt(Label58.Text) & ",'" & Me.Label56.Text & "','" & CStr(NumericUpDown_CANT.Value) & "','" & PROD_VALOR_UNITARIO_BASE & "','" & CStr(PROD_IVA_VR) & "','" & CStr(PROD_IVA_VR2) & "','" & Math.Round((CDec(PROD_IVA_VR) * CDec(NumericUpDown_CANT.Value)), 0) & "','" & Math.Round((CDec(PROD_IVA_VR2) * CDec(NumericUpDown_CANT.Value)), 0) & "','" & CDec(TextBox_valorunitario.Text) & "','" & CStr(Math.Round(CDec(TextBox_Total.Text), 2)) & "','SIN DESCARGAR','" & PROD_INVENTARIADO.ToString & "','" & prod_iva1nom & "','" & prod_iva2nom & "','" & prod_decimal & "','" & PROD_COSTO & "','" & TextBox_lote.Text & "','" & TextBox_vencimiento.Text & "')"
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

        Me.Cursor = Cursors.Default



        Me.datagrid_productos.CurrentCell = Nothing
        Me.Cursor = Cursors.Default

        Me.Button_Regresar.Visible = True
        Timer_gridProds.Enabled = True
        Me.datagrid_productos.Enabled = True

        Timer_PROD_OFF.Enabled = True

        prod_cons = ""

        Label_saldo_lote.Text = 0
        Label_saldo_actual.Text = 0
        Label56.Text = "-"

    End Sub

    Private Sub datagrid_PEDIDOS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_PEDIDOS.CellContentClick

    End Sub

    Private Sub datagrid_PEDIDOS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_PEDIDOS.CellClick
        Dim row_mov As DataGridViewRow = datagrid_PEDIDOS.CurrentRow
        If datagrid_PEDIDOS.RowCount = 0 Then Exit Sub

        CodDocumento = CLng(row_mov.Cells("cons").Value) ' LLAVE PRINCIPAL
    End Sub

    Private Sub Btn_Ver_editar_Click(sender As Object, e As EventArgs) Handles Btn_Ver_editar.Click
        If PERMISO_1(21) = "NO" Or PERMISO_1(21) = Nothing Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub



        If CodDocumento = 0 Then MsgBox("Seleccione un Pedido del listado.", vbInformation) : Exit Sub
        'If PERMISO_1(13) = "NO" Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub

        OCULTO_OPCIONES_BOTONES()

        Me.Panel_dock.Visible = False
        ComboBox_CuentaPago.SelectedItem = Nothing


        'DATOS BASICOS DLE PEDIDO
        Me.TextBox_buscar_barras.Enabled = True : Me.TextBox_buscar_cod.Enabled = True : Me.combobox_BuscarProd.Enabled = True
        Me.NumericUpDown_CANT.Enabled = True : Me.TextBox_valorunitario.Enabled = True : Me.TextBox_Total.Enabled = False
        Me.Text_leyenda.Enabled = True : Me.TextBox_responsable.Enabled = False

        PROD_RETEFUENTE = ""
        PROD_RETEFUENTE_VALOR = ""
        PROD_RETEFUENTE_TOTAL = ""

        Try
            sql = "SELECT * FROM pedidosprov WHERE CONS = " & CodDocumento & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                Label_consecutivo.Text = row.Item("CONS")
                Label_fecha.Text = row.Item("fecha")
                Label_fechaentrega.Text = row.Item("fechaENTREGA")
                Label_fechapago.Text = row.Item("fechapago")
                cli_doc = row.Item("codcliente")
                Me.TextBox_responsable.Text = row.Item("empleado")
                Me.TextBox_nrofacprov.Text = row.Item("FacturaP")

                Me.Text_leyenda.Text = row.Item("observaciones")
                Me.Label_estado_movimiento.Text = row.Item("estado")
                Me.TextBox_dcto.Text = row.Item("descuento")
                Me.TextBox_dcto.Text = Format(CDec(Me.TextBox_dcto.Text), "##,##0")


                If row.Item("descargado") = "SI" Then
                    Me.Button_descargar.Text = "DESCARGADO" : Me.Button_descargar.Enabled = False
                    Me.Button_agregar_prod.Visible = False : Me.button_Quitar_Prod.Visible = False
                    Me.Button_ANULAR.Enabled = False
                End If

                If row.Item("facturado") = "SI" Then
                    Me.Button_FACTURAR.Text = "FACTURADO" : Me.Button_FACTURAR.Enabled = False
                    Me.Button_agregar_prod.Visible = False : Me.button_Quitar_Prod.Visible = False
                    NRO_FACTURA = row.Item("nrofac")
                    'Label35.Text = row.Item("nrofac")
                    panel_proveedores.Enabled = False
                End If


                ComboBox_bodega_destino.Items.Clear()
                ComboBox_bodega_destino.Items.Add(row.Item("bodega"))
                Me.ComboBox_bodega_destino.Text = row.Item("bodega")


                NumericUpDown_retefuente.Value = row.Item("RETEFUENTE")

                TextBox_retefuente.Text = row.Item("RETE_VR")
                TextBox_retenciones.Text = row.Item("RETE_TOTAL")

            Next
        Catch ex As Exception
            If ex.ToString.Contains("no pertenece a la tabla") = True Then
                MsgBox("falta un parametro, debe reparar la estructura del conjunto de pedidos, ó comuniquese con soporte.", vbInformation)

            End If
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()



        'loads_productos()

        Me.datagrid_PEDIDOS.Visible = False

        Me.Panel_prods.Visible = True

        Me.Button_agregar_prod.Visible = True
        Me.button_Quitar_Prod.Visible = True
        Me.Button_agregar_prod.Enabled = True
        Me.button_Quitar_Prod.Enabled = True



        Me.Button_guardar.Text = "Guardar Cambios"
        Me.Panel_prods.Enabled = False

        If Label_estado_movimiento.Text = "PENDIENTE" Then
            Me.Panel_prods.Enabled = True

            Me.Button_agregar_prod.Visible = True : Me.Button_agregar_prod.Enabled = True
            Me.button_Quitar_Prod.Visible = True : Me.button_Quitar_Prod.Enabled = True

            Me.Button_continuar.Visible = False
            Me.Button_guardar.Visible = True
            Me.Button_guardar.Enabled = True
            Me.Button_EXPORTAR.Enabled = True
            Me.Button_descargar.Enabled = True
            Me.Button_FACTURAR.Enabled = True
            Me.Button_ANULAR.Enabled = True
            Me.Button_finalizar.Enabled = True
            Me.MetroDateTime1.Enabled = True
            Me.MetroDateTime3.Enabled = True
            Me.ComboBox_CuentaPago.Enabled = True
            Me.ComboBox_MedioPago.Enabled = True

            'Me.CheckBox_retefuente.Enabled = True
            Label_VENDEDOR.Enabled = True
            TextBox_nrofacprov.Enabled = True

            If Me.Button_FACTURAR.Text = "FACTURADO" Then
                Me.Button_FACTURAR.Enabled = True
                Me.button_Quitar_Prod.Visible = False
                Me.Button_agregar_prod.Visible = False
                Me.Button_ANULAR.Enabled = False
                Me.MetroDateTime1.Enabled = False
                Me.MetroDateTime3.Enabled = False
                Me.ComboBox_CuentaPago.Enabled = False
                Me.ComboBox_MedioPago.Enabled = False

                'Me.CheckBox_retefuente.Enabled = False
                Label_VENDEDOR.Enabled = False
                TextBox_nrofacprov.Enabled = False
            End If

            If Me.Button_descargar.Text = "DESCARGADO" Then Me.Button_descargar.Enabled = False : Me.button_Quitar_Prod.Visible = False : Me.Button_agregar_prod.Visible = False : Me.Button_ANULAR.Enabled = False
        End If

        If Label_estado_movimiento.Text = "FINALIZADO" Then
            Me.Button_continuar.Visible = False

            Me.Button_ANULAR.Enabled = False
            Me.Button_descargar.Enabled = True
            'Me.Button_FACTURAR.Enabled = False
            Me.Button_guardar.Enabled = False
            Me.Button_EXPORTAR.Enabled = True
            Me.Button_guardar.Enabled = False

            Me.Button_guardar.Text = "Guardar"

            Me.Button_agregar_prod.Visible = False
            Me.button_Quitar_Prod.Visible = False



            Me.Label_VENDEDOR.Enabled = False
            Me.ComboBox_CuentaPago.Enabled = False
            Me.ComboBox_MedioPago.Enabled = False

            Me.MetroDateTime1.Enabled = False
            Me.MetroDateTime3.Enabled = False
            Me.CheckBox_retefuente.Visible = False
        End If

        If Label_estado_movimiento.Text = "ANULADA" Then
            Me.Button_continuar.Visible = False

            Me.Button_EXPORTAR.Visible = True
            Me.Button_agregar_prod.Visible = False
            Me.button_Quitar_Prod.Visible = False
            Me.Button_Regresar.Visible = True
            Me.Button_guardar.Enabled = False
            Me.Button_guardar.Text = "Guardar"
            Me.Button_FACTURAR.Enabled = False
        End If

        Label47.Visible = False
        ComboBox_filtroprov.Visible = False
        Button4.Visible = False

        Timer_gridProds.Enabled = True


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
                CLI_DECLARANTE = row.Item("DECLARANTE")
                CLI_AGENTERETENEDOR = row.Item("AGENTERETENeDOR")
                CLI_AUTORETENEDOR = row.Item("AUTORETENEDOR")

                imp_clienteDoc = cli_doc
                imp_clienteDoc = cli_nom
                imp_clienteTel = cli_tel
                ImpClienteDir = cli_dir
                imp_clientemail = cli_mail
            Next

            Me.TXT_DIR_CLIENTE.Text = cli_dir
            Me.TXT_TELS_CLIENTE.Text = cli_tel
            Me.TxtMAIL_cliente.Text = cli_mail
            Me.TXT_DOC_CLIENTE.Text = cli_doc
            Me.TXT_NOM_CLIENTE.Text = cli_nom
            Me.TxtMAIL_cliente.Text = cli_mail

            If TXT_DOC_CLIENTE.Text = "1" Or TXT_DOC_CLIENTE.Text = "" Then
                Button_EDIT_CLI.Visible = False
            Else
                Button_EDIT_CLI.Visible = True
            End If

        Catch ex As Exception
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()

        TextBox_BUSCAR_PROV.Text = ""
        COMBO_NOM_CLIENTE_FILTRO.Text = ""

        Panel_filtro.Visible = False


        Me.panel_proveedores.Visible = True

    End Sub

    Private Sub Button_Regresar_Click(sender As Object, e As EventArgs) Handles Button_Regresar.Click
        If Me.Button_guardar.Text = "Guardar Cambios" And Label_estado_movimiento.Text = "PENDIENTE" Then
            Button_guardar_Click(Nothing, Nothing)

        End If


        Timer_info.Enabled = True
        NRO_FACTURA = ""
        datagrid_PEDIDOS.Visible = True
        CodDocumento = 0

        Me.Button_FACTURAR.Text = "Facturar"
        Me.Button_descargar.Text = "Enviar a Bodega"

        Me.TXT_DOC_CLIENTE.Text = ""
        Me.TXT_NOM_CLIENTE.Text = ""
        Me.TxtMAIL_cliente.Text = ""

        Me.TXT_TELS_CLIENTE.Text = ""
        Me.TXT_DIR_CLIENTE.Text = ""
        Me.Label_consecutivo.Text = "0"
        Me.Label_fecha.Text = "0"
        Me.Label_fechaentrega.Text = ""
        Me.Text_leyenda.Text = ""
        Me.TextBox_responsable.Text = ""
        Me.TextBoxTotalDoc.Text = ""
        Me.Label_estado_movimiento.Text = "NUEVO"
        Me.combobox_BuscarProd.DataSource = Nothing
        Me.TextBox_buscar_barras.Text = ""
        Me.NumericUpDown_CANT.Value = 0
        Me.TextBox_valorunitario.Text = "0"
        Me.TextBox_Total.Text = "0"

        'filtro
        Label47.Visible = True
        ComboBox_filtroprov.Visible = True
        Label50.Visible = True
        ComboBox_periodo.Visible = True

        TextBox_nrofacprov.Text = ""

        Me.Panel_dock.Visible = True

        Me.datagrid_productos.DataSource = Nothing

        load_grid_PEDIDOS_provs()

        MetroDateTime3.Value = DateTime.Now

        Me.datagrid_PEDIDOS.ClearSelection()

        ComboBox_filtroprov.SelectedItem = Nothing
        Label47.Visible = True
        ComboBox_filtroprov.Visible = True
        Button4.Visible = True
        Me.panel_proveedores.Visible = False
        Panel_filtro.Visible = True

    End Sub

    Private Sub Timer_PROD_DATA_BARRAS_Tick(sender As Object, e As EventArgs) Handles Timer_PROD_DATA_BARRAS.Tick
        Me.Timer_PROD_DATA_BARRAS.Enabled = False
        datos_del_producto_BARRAS()
        'calcula_saldo()
        Me.TextBox_valorunitario.Text = PROD_COSTO
    End Sub





    Private Sub TextBox_BARRAS_TextChanged(sender As Object, e As EventArgs) Handles TextBox_buscar_barras.TextChanged

    End Sub









    Private Sub button_Quitar_Prod_Click(sender As Object, e As EventArgs) Handles button_Quitar_Prod.Click

        If prod_cons = "" Then
            MsgBox("Seleccione un producto para eliminar.", vbInformation)
            Exit Sub
        End If

        Dim RTA As String
        Me.Cursor = Cursors.WaitCursor

        RTA = MsgBox("Desea eliminar el producto?.", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If RTA = 6 Then
            sql = "delete from pedidosprov_prods where cons=" & CInt(prod_cons) & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
                'MsgBox("Se Borró el producto.")
            Catch ex As Exception
                MsgBox("Error al Borrar el Registro.")
                Exit Sub
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()
        End If
        prod_cod = ""
        Me.Timer_gridProds.Enabled = True
        Me.Timer_PROD_OFF.Enabled = True

        prod_cons = ""


        Me.Cursor = Cursors.Default

    End Sub



    Private Sub Button_FACTURAR_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button_EXPORTAR_Click(sender As Object, e As EventArgs) Handles Button_EXPORTAR.Click



        Try
            sql = "SELECT CODPROD, PRODUCTO, CANTIDAD, VALORU, VALORTOTAL FROM pedidosprov_PRODS WHERE documento = " & CInt(Label_consecutivo.Text) & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DATAGrid_EXPORTAR.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        Me.DATAGrid_EXPORTAR.Columns(0).Width = 50
        Me.DATAGrid_EXPORTAR.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DATAGrid_EXPORTAR.Columns(1).Width = 250
        Me.DATAGrid_EXPORTAR.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        Me.DATAGrid_EXPORTAR.Columns(2).Width = 50
        Me.DATAGrid_EXPORTAR.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DATAGrid_EXPORTAR.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DATAGrid_EXPORTAR.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        'DATAGrid_EXPORTAR.Columns.Item("valoru").DefaultCellStyle.Format = "###,##0"
        'DATAGrid_EXPORTAR.Columns.Item("valorotal").DefaultCellStyle.Format = "###,##0"


        Try
            'Intentar generar el documento.
            Dim doc As New Document(PageSize.A4, 10, 20, 10, 10)
            'Path que guarda el reporte en el escritorio de windows (Desktop).
            If Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) & "\MiClickDerecho Docs\") = False Then
                Try
                    My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) & "\MiClickDerecho Docs\")
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If

            'Path que guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\pedidoproveedor " & Label_consecutivo.Text & ".pdf"
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



    Public Sub ExportarDatosPDF2(ByVal document As Document)
        Dim CANT_FILAS As Integer = 0
        'Se crea un objeto PDFTable con el numero de columnas del DataGridView.
        Dim datatable As New PdfPTable(DATAGrid_EXPORTAR.ColumnCount)
        'Se asignan algunas propiedades para el diseño del PDF.
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(DATAGrid_EXPORTAR)

        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER

        Dim fontLINE = iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLD)

        Dim contentFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 12, iTextSharp.text.Font.BOLD)
        Dim DIRFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 6, iTextSharp.text.Font.BOLD)
        Dim rowFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 7, iTextSharp.text.Font.BOLD)

        Dim FIRMAFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 5, iTextSharp.text.Font.BOLD)
        Dim CLIENTEFONT = iTextSharp.text.FontFactory.GetFont("Arial Black", 7, iTextSharp.text.Font.BOLDITALIC)
        Dim totalFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 8, iTextSharp.text.Font.BOLDITALIC)
        Dim totaltotalFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 9, iTextSharp.text.Font.BOLDITALIC)


        'LOGO
        If comex_logo <> "" Then
            Dim imagelogogopdf As iTextSharp.text.Image 'Declaracion de una imagen

            imagelogogopdf = iTextSharp.text.Image.GetInstance(comex_logo) 'Dirreccion a la imagen que se hace referencia
            imagelogogopdf.Alignment = Element.ALIGN_RIGHT
            imagelogogopdf.SetAbsolutePosition(650, 520) 'Posicion en el eje cartesiano
            imagelogogopdf.ScaleAbsoluteWidth(160) 'Ancho de la imagen
            imagelogogopdf.ScaleAbsoluteHeight(68) 'Altura de la imagen
            document.Add(imagelogogopdf) ' Agrega la imagen al documento
        End If



        Dim encabezadoLINE As New Paragraph("|=======================================|", fontLINE)

        encabezadoLINE.Alignment = 0
        encabezadoLINE.Font = fontLINE

        Dim encabezadoLINE2 As New Paragraph("========================================", fontLINE)
        Dim encabezadoLINE3 As New Paragraph("________________________________________", fontLINE)

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
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase(comex_nombrepropietario, FontFactory.GetFont(FontFactory.COURIER_BOLD, 8, iTextSharp.text.Font.NORMAL))
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase("NIT:" & comex_nit & "-" & comex_DV & " " & comex_regimen, FontFactory.GetFont(FontFactory.COURIER_BOLD, 8, iTextSharp.text.Font.NORMAL))
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase("Tels:" & comex_tels & " - " & comex_cels & " " & comex_dircomercio & " " & comex_ciudad, FontFactory.GetFont(FontFactory.COURIER_BOLD, 8, iTextSharp.text.Font.NORMAL))
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()


        Dim PDF_CONSECUTIVO As New Paragraph("No. " & Label_consecutivo.Text, New Font(Font.Name = "Arial Black", 8, Font.Bold = True)) : PDF_CONSECUTIVO.Alignment = 2
        Dim encabezado As New Paragraph("PEDIDO A PROVEEDOR", CLIENTEFONT) : encabezado.Alignment = 2
        Dim encabezado2 As New Paragraph("Fecha:" + Me.Label_fecha.Text + " Entrega:" + Label_fechaentrega.Text, New Font(Font.Name = "Arial Balck", 8, Font.Bold)) : encabezado2.Alignment = 2

        Dim glue = New Chunk(New VerticalPositionMark())
        Dim texto_CLIENTE As New Paragraph("Proveedor: " + Me.TXT_NOM_CLIENTE.Text.ToString + "   Documento/NIT: " + TXT_DOC_CLIENTE.Text, CLIENTEFONT)
        texto_CLIENTE.Add(New Chunk(glue))
        texto_CLIENTE.Add("NIT:" & comex_nit & " " & comex_regimen)
        texto_CLIENTE.SpacingBefore = 5

        Dim texto_dirCLIENTE As New Paragraph("Dirección:  " + Me.TXT_DIR_CLIENTE.Text.ToString + "   Teléfono: " + TXT_TELS_CLIENTE.Text, CLIENTEFONT)
        texto_dirCLIENTE.Add(New Chunk(glue))
        If Label_fechapago.Text <> "" Then texto_dirCLIENTE.Add("Medio de Pago:" & ComboBox_CuentaPago.Text & " / Fecha:" & Label_fechapago.Text)
        If Label_fechapago.Text = "" Then texto_dirCLIENTE.Add("Medio de Pago: ")

        Dim texto_mailCLIENTE As New Paragraph(" ", CLIENTEFONT)
        texto_mailCLIENTE.Add(New Chunk(glue))
        texto_mailCLIENTE.Add("#Factura: " & TextBox_nrofacprov.Text & " / ")

        Dim texto_resp As New Paragraph("Vendedor: " + Label_VENDEDOR.Text, New Font(Font.Name = "Arial Narrow", 7, Font.Bold = True))
        texto_resp.Add(New Chunk(glue))
        texto_resp.Add("Responsable: " + TextBox_responsable.Text)

        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To DATAGrid_EXPORTAR.ColumnCount - 1
            Dim cell_TITLE As New PdfPCell
            cell_TITLE.Phrase = New Phrase(DATAGrid_EXPORTAR.Columns(i).HeaderText, New Font(Font.Name = "Arial Narrow", 8, Font.Bold = True))
            cell_TITLE.HorizontalAlignment = Element.ALIGN_CENTER
            cell_TITLE.BackgroundColor = BaseColor.LIGHT_GRAY
            datatable.AddCell(cell_TITLE)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 0
        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To DATAGrid_EXPORTAR.RowCount - 1
            For j As Integer = 0 To DATAGrid_EXPORTAR.ColumnCount - 1

                Dim cell As New PdfPCell
                cell.Phrase = New Phrase(DATAGrid_EXPORTAR(j, i).Value.ToString, rowFont)
                If j = 0 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 1 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 2 Then cell.HorizontalAlignment = Element.ALIGN_CENTER
                If j = 3 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 4 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 5 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 6 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 7 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                cell.Border = 0
                datatable.AddCell(cell)
            Next
            datatable.CompleteRow()
        Next

        '  CONTAR LAS FILAS DE LA GRILLA GENERADA, 
        ' ESTABLECER CUANTAS GRILLAS SE NECESITAN PARA LLEGAR A MEDIA CARTA Y CARTA,
        ' AGRAGAR LLASNECESARIAS PARA LLENAR EL ESPACION Q FALTA
        CANT_FILAS = Me.DATAGrid_EXPORTAR.RowCount

        If CANT_FILAS <= (60 - CANT_FILAS) Then
            For i As Integer = 0 To (50 - CANT_FILAS)
                For j As Integer = 0 To DATAGrid_EXPORTAR.ColumnCount - 1

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
                    datatable.AddCell(cell)
                Next
                datatable.CompleteRow()
            Next
        End If

        Dim descuento As New Paragraph("", totalFont)
        descuento.Add(New Chunk(glue))
        descuento.Add("Descuento ")
        descuento.IndentationLeft = 350
        descuento.Alignment = Element.ALIGN_RIGHT
        descuento.Add(New Chunk(glue))
        descuento.Add(TextBox_dcto.Text & " ")
        descuento.SpacingBefore = 3

        'Dim subtotal As New Paragraph("", New Font(Font.Name = "Arial Black", 7, Font.Bold = True))
        'subtotal.Add(New Chunk(glue))
        'subtotal.Add("SubTotal ")
        'subtotal.IndentationLeft = 349
        'subtotal.Alignment = Element.ALIGN_RIGHT
        'subtotal.Add(New Chunk(glue))
        'subtotal.Add(CInt(TextBoxTotalDoc.Text) - CInt(TextBox_retefuente.Text) - CInt(TextBoximp.Text) & " ")

        Dim RETEFUENTE As New Paragraph(" ", totalFont)
        RETEFUENTE.Add(New Chunk(glue))
        RETEFUENTE.Add("Retefunte " & "" & "%")
        RETEFUENTE.IndentationLeft = 353
        RETEFUENTE.Alignment = Element.ALIGN_RIGHT
        RETEFUENTE.Add(New Chunk(glue))
        RETEFUENTE.Add(TextBox_retenciones.Text & " ")

        Dim impuestos As New Paragraph(" ", totalFont)
        impuestos.Add(New Chunk(glue))
        impuestos.Add("Impuestos ")
        impuestos.IndentationLeft = 347
        impuestos.Alignment = Element.ALIGN_RIGHT
        impuestos.Add(New Chunk(glue))
        impuestos.Add(TextBoximp.Text & " ")

        Dim total_fac As New Paragraph(" ", totaltotalFont)
        total_fac.Add(New Chunk(glue))
        total_fac.Add("Total ")
        total_fac.IndentationLeft = 359
        total_fac.Alignment = Element.ALIGN_RIGHT
        total_fac.Add(New Chunk(glue))
        total_fac.Add(TextBoxTotalDoc.Text & " ")

        Dim PDF_observaciones As New Paragraph("Observaciones:", FIRMAFont) : PDF_observaciones.Alignment = 0

        Dim saltoDeLinea = New Paragraph("                                                                                          ")

        'Dim PDF_FIRMACLIENTE As New Paragraph("FIRMA CLIENTE:____________________                    FIRMA VENDEDOR:________________________", FIRMAFont) : PDF_FIRMACLIENTE.Alignment = 0
        'PDF_FIRMACLIENTE.Font = FIRMAFont

        Dim texto2 As New Phrase("Fecha del Reporte: " + Now.Date(), New Font(Font.Name = "Arial Narrow", 5, Font.Bold))
        Dim texto3 As New Phrase("Generado Por :" + usrnom, New Font(Font.Name = "Arial Narrow", 5, Font.Bold))

        'LOGO
        If comex_logo <> "" Then
            Dim imagelogogopdf As iTextSharp.text.Image 'Declaracion de una imagen

            imagelogogopdf = iTextSharp.text.Image.GetInstance(comex_logo) 'Dirreccion a la imagen que se hace referencia
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
        CUADRO1.SetAbsolutePosition(400, 762) 'Posicion en el eje cartesiano
        CUADRO1.ScaleAbsoluteWidth(180) 'Ancho de la imagen
        CUADRO1.ScaleAbsoluteHeight(43) 'Altura de la imagen
        document.Add(CUADRO1) ' Agrega la imagen al documento

        Dim CUADRO_cliente As iTextSharp.text.Image 'Declaracion de una imagen
        CUADRO_cliente = iTextSharp.text.Image.GetInstance("c:\miclickderecho\cuadro_para_portadas2.png") 'Dirreccion a la imagen que se hace referencia
        CUADRO_cliente.Alignment = Element.ALIGN_LEFT
        CUADRO_cliente.SetAbsolutePosition(5, 714) 'Posicion en el eje cartesiano
        CUADRO_cliente.ScaleAbsoluteWidth(350) 'Ancho de la imagen
        CUADRO_cliente.ScaleAbsoluteHeight(54) 'Altura de la imagen
        document.Add(CUADRO_cliente) ' Agrega la imagen al documento

        'Dim CUADRO_prods As iTextSharp.text.Image 'Declaracion de una imagen
        'CUADRO_prods = iTextSharp.text.Image.GetInstance("c:\miclickderecho\square.png") 'Dirreccion a la imagen que se hace referencia
        'CUADRO_prods.Alignment = Element.ALIGN_LEFT
        'CUADRO_prods.SetAbsolutePosition(7, 90) 'Posicion en el eje cartesiano
        'CUADRO_prods.ScaleAbsoluteWidth(575) 'Ancho de la imagen
        'CUADRO_prods.ScaleAbsoluteHeight(620) 'Altura de la imagen
        'document.Add(CUADRO_prods) ' Agrega la imagen al documento


        'Dim CUADRO_total As iTextSharp.text.Image 'Declaracion de una imagen
        'CUADRO_total = iTextSharp.text.Image.GetInstance("c:\miclickderecho\cuadro_para_portadas2.png") 'Dirreccion a la imagen que se hace referencia
        'CUADRO_total.Alignment = Element.ALIGN_LEFT
        'CUADRO_total.SetAbsolutePosition(428, 30) 'Posicion en el eje cartesiano
        'CUADRO_total.ScaleAbsoluteWidth(150) 'Ancho de la imagen
        'CUADRO_total.ScaleAbsoluteHeight(58) 'Altura de la imagen


        document.Add(encabezadoLINE)
        document.Add(tablahome)
        document.Add(encabezadoLINE2)

        document.Add(encabezado)
        document.Add(PDF_CONSECUTIVO)
        document.Add(encabezado2)
        document.Add(texto_CLIENTE)
        document.Add(texto_dirCLIENTE)
        document.Add(texto_mailCLIENTE)
        document.Add(texto_resp)
        datatable.SpacingBefore = 15
        document.Add(datatable)
        'document.Add(CUADRO_total)

        document.Add(descuento)
        document.Add(RETEFUENTE)
        'document.Add(subtotal)
        document.Add(impuestos)
        document.Add(total_fac)
        'document.Add(saltoDeLinea)
        document.Add(PDF_observaciones)
        'document.Add(PDF_FIRMACLIENTE)
        document.Add(texto2)
        document.Add(texto3)


    End Sub
    Public Sub ExportarDatosPDF(ByVal document As Document)
        'Se crea un objeto PDFTable con el numero de columnas del DataGridView.
        Dim datatable As New PdfPTable(DATAGrid_EXPORTAR.ColumnCount)
        'Se asignan algunas propiedades para el diseño del PDF.
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(DATAGrid_EXPORTAR)

        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER

        'Se crea el encabezado en el PDF.
        Dim encabezado As New Paragraph(comex_nombrecomercial, New Font(Font.Name = "Tahoma", 14, Font.Bold))
        Dim encabezado2 As New Paragraph("PEDIDO No. " + Me.Label_consecutivo.Text + "    Ruta: " + Me.Label_VENDEDOR.Text, New Font(Font.Name = "Arial Balck", 12, Font.Bold))
        Dim encabezado3 As New Paragraph("CLIENTE: " + TXT_NOM_CLIENTE.Text + " NIT: " & Me.TXT_DOC_CLIENTE.Text.ToString, New Font(Font.Name = "Arial Balck", 12, Font.Bold))

        'Se crea el texto abajo del encabezado.
        Dim texto As New Phrase("Fecha Pedido: " + Me.Label_fecha.Text.ToString & "          Fecha Entrega: " + Me.Label_fechaentrega.Text.ToString + Chr(13), New Font(Font.Name = "Arial Narrow", 10, Font.Bold))
        Dim texto_empleado As New Phrase("Realizado por: " + Me.TextBox_responsable.Text.ToString + Chr(13), New Font(Font.Name = "Arial Narrow", 10, Font.Bold))
        Dim texto_estadodoc As New Phrase("Estado: " + Me.Label_estado_movimiento.Text.ToString + "      Total: " + Me.TextBoxTotalDoc.Text.ToString + Chr(13), New Font(Font.Name = "Arial Narrow", 10, Font.Bold))
        Dim texto2 As New Phrase("Fecha del Reporte: " + Now.Date() + Chr(13), New Font(Font.Name = "Arial Narrow", 10, Font.Bold))
        Dim texto_obs As New Phrase("Observación: " + Text_leyenda.Text, New Font(Font.Name = "Arial Narrow", 10, Font.Bold))

        Dim texto3 As New Phrase("          Generado Por :" + usrnom, New Font(Font.Name = "Arial Narrow", 10, Font.Bold))

        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To DATAGrid_EXPORTAR.ColumnCount - 1
            Dim cellhdr As New PdfPCell(New Phrase(DATAGrid_EXPORTAR.Columns(i).HeaderText, New Font(Font.Name = "Arial", 10.0F, FontStyle.Bold)))
            'datatable.AddCell(MetroGrid_pdf.Columns(i).HeaderText)
            cellhdr.HorizontalAlignment = Element.ALIGN_CENTER
            cellhdr.BackgroundColor = BaseColor.LIGHT_GRAY
            datatable.AddCell(cellhdr)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1
        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To DATAGrid_EXPORTAR.RowCount - 1
            For j As Integer = 0 To DATAGrid_EXPORTAR.ColumnCount - 1

                Dim cell As New PdfPCell
                cell.Phrase = New Phrase(DATAGrid_EXPORTAR(j, i).Value.ToString, New Font(Font.Name = "Arial Narrow", 8))
                If j = 0 Then cell.HorizontalAlignment = Element.ALIGN_CENTER
                If j = 1 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 2 Then cell.HorizontalAlignment = Element.ALIGN_CENTER
                If j = 3 Then cell.HorizontalAlignment = Element.ALIGN_CENTER
                If j = 4 Then cell.HorizontalAlignment = Element.ALIGN_CENTER
                If j = 5 Then cell.HorizontalAlignment = Element.ALIGN_CENTER
                If j = 6 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 7 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                datatable.AddCell(cell)

            Next
            datatable.CompleteRow()
        Next

        'LOGO
        If comex_logo <> "" And File.Exists(comex_logo) = True Then
            Dim imagelogogopdf As iTextSharp.text.Image 'Declaracion de una imagen

            imagelogogopdf = iTextSharp.text.Image.GetInstance(comex_logo) 'Dirreccion a la imagen que se hace referencia
            imagelogogopdf.Alignment = Element.ALIGN_RIGHT
            imagelogogopdf.SetAbsolutePosition(410, 770) 'Posicion en el eje cartesiano
            imagelogogopdf.ScaleAbsoluteWidth(160) 'Ancho de la imagen
            imagelogogopdf.ScaleAbsoluteHeight(60) 'Altura de la imagen
            document.Add(imagelogogopdf) ' Agrega la imagen al documento
        End If
        'Se agrega el PDFTable al documento.


        document.Add(encabezado)
        document.Add(encabezado2)
        document.Add(encabezado3)
        document.Add(texto)
        document.Add(texto_empleado)
        document.Add(texto_estadodoc)
        document.Add(texto2)
        document.Add(texto_obs)

        document.Add(datatable)
        document.Add(texto3)

    End Sub

    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        'funcion para obtener el tamaño de la columnas del datagridview
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function
    Private Sub datagrid_productos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_productos.CellContentClick

    End Sub

    Private Sub Label_estado_movimiento_Click(sender As Object, e As EventArgs) Handles Label_estado_movimiento.Click

        If Label_estado_movimiento.Text = "NUEVO" Then
            Exit Sub
        End If


    End Sub
    Private Sub ver_prod_PROD_INVENTARIADO(ByVal codprod As String)
        Try
            sql = "SELECT inventariado FROM productos where cod=" & CInt(codprod) & ""
            da = New MySqlDataAdapter(sql, conex)
            dt_saldos = New DataTable
            da.Fill(dt_saldos)
            For Each row As DataRow In dt_saldos.Rows
                PROD_INVENTARIADO = row.Item("inventariado")
            Next
            saldo = entran - salen
        Catch ex As Exception
            saldo = 0
        End Try
        da.Dispose()
        conex.Close()
    End Sub
    Private Sub Button_descargar_Click(sender As Object, e As EventArgs) Handles Button_descargar.Click


        If PERMISO_1(21) = "NO" Or PERMISO_1(21) = Nothing Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub


        If Me.TextBoxTotalDoc.Text = "0" Then
            MsgBox("No hay productos para descargar.", vbInformation) : Exit Sub
        End If


        If Me.Button_descargar.Text = "DESCARGADO" Then
            MsgBox("Los productos de este pedido ya se ingesaron a la bodega.", vbInformation)
            Exit Sub
        End If

        Dim RTA As String
        RTA = MsgBox("Confirma el ingreso de los productos a la bodega.", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If RTA = 6 Then
            '  ingreso a bodega    =============================================
            Me.Cursor = Cursors.WaitCursor
            Ingresar_a_Bodega()
            Me.Cursor = Cursors.WaitCursor

            sql = "update pedidosprov SET Descargado='SI', fechaentrega='" & Me.Label_fechaentrega.Text & "' WHERE CONS=" & CLng(Label_consecutivo.Text) & ""
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

            Me.Button_ANULAR.Enabled = False
            Me.Button_descargar.Enabled = False
            Me.Button_descargar.Text = "DESCARGADO"
            Me.Cursor = Cursors.Default

        End If


    End Sub

    Private Sub Button_enviarCompra_Click(sender As Object, e As EventArgs) Handles Button_FACTURAR.Click

        If PERMISO_1(21) = "NO" Or PERMISO_1(21) = Nothing Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub


        If Me.Button_FACTURAR.Text = "FACTURADO" Then MsgBox("Ya se Facturó este Pedido..") : Exit Sub

        If TXT_DOC_CLIENTE.Text = "" And ComboBox_CuentaPago.Text = "CREDITO COMPRA" Then
            MsgBox("Debe elejir un proveedor si desea comprar a crédito.")
            Exit Sub
        End If

        If Me.Button_FACTURAR.Text = "FACTURADO" Then
            If NRO_FACTURA <> "" Then
                ID_VENTA_VER = NRO_FACTURA
                Form_verfactura.Show()
            End If
            Exit Sub
        End If

        If Me.TXT_DOC_CLIENTE.Text = "" Or TXT_NOM_CLIENTE.Text = "" Then
            MsgBox("Debe seleccionar un proveedor para poder facturar la compra.")
            Exit Sub
        End If

        If ComboBox_MedioPago.Text.ToString = Nothing Then
            MsgBox("Debe seleccionar un medio de pago.")
            Exit Sub
        End If

        If Not ComboBox_MedioPago.Text.Contains("CREDITO") Then
            If ComboBox_CuentaPago.Text.ToString = Nothing Then
                MsgBox("Debe seleccionar una cuenta para pagar.")
                Exit Sub
            End If
        End If

        If TextBox_nrofacprov.Text = "" Then
            MsgBox("Debe escribir el numero que identifica la factura del  proveedor para poder generar el pago.")
            Exit Sub
        End If

        If Me.TextBoxTotalDoc.Text = "0" Then
            MsgBox("No hay productos para facturar.", vbInformation) : Exit Sub
        End If

        Dim RTA, rta2 As String
        RTA = MsgBox("Confirma generar el pago de este pedido?.", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If RTA = 6 Then
            Me.Cursor = Cursors.WaitCursor
            If Label_fechapago.Text = "" Then Label_fechapago.Text = DateTime.Now.ToShortDateString


            GENERAR_COMPRA()


            Me.Cursor = Cursors.Default
            NRO_FACTURA = consecutivo

            'descarggue de bodega
            If Me.Button_descargar.Text <> "DESCARGADO" Then
                rta2 = MsgBox("Se va a facturar una compra y no se han enviado los productos de la bodega. " & Chr(13) & Chr(13) & "Desea hacerlo ahora?.", MsgBoxStyle.Information + MsgBoxStyle.YesNo)
                If rta2 = 6 Then
                    '  ingreso de bodega    =============================================
                    Me.Cursor = Cursors.WaitCursor

                    Ingresar_a_Bodega()

                    sql = "update pedidosprov SET Descargado='SI', CODCLIENTE='" & TXT_DOC_CLIENTE.Text & "', CLIENTE='" & TXT_NOM_CLIENTE.Text & "', retefuente='" & NumericUpDown_retefuente.Value & "', rete_vr='" & TextBox_retefuente.Text & "',rete_total='" & TextBox_retenciones.Text & "' WHERE CONS=" & CLng(Label_consecutivo.Text) & ""
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

                    Me.Button_descargar.Enabled = False
                    Me.Button_descargar.Text = "DESCARGADO"
                    Me.Button_agregar_prod.Visible = False
                    Me.button_Quitar_Prod.Visible = False

                End If
                Me.Cursor = Cursors.Default

                Me.Button_ANULAR.Enabled = False
            End If
            Me.Button_FACTURAR.Enabled = False
            Me.button_Quitar_Prod.Visible = False
            Me.Button_agregar_prod.Visible = False
            Me.Button_ANULAR.Enabled = False
            Me.MetroDateTime1.Enabled = False
            Me.MetroDateTime3.Enabled = False
            Me.ComboBox_CuentaPago.Enabled = False
            'Me.CheckBox_retefuente.Enabled = False
            Label_VENDEDOR.Enabled = False
            TextBox_nrofacprov.Enabled = False
        End If


    End Sub
    Private Sub GENERAR_COMPRA()
        'CONSECUTIVO VENTA
        consecutivo = 0
        cmd.Connection = conex
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select max(documento) + 1 from COMPRAs"
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




        If TextBoximp.Text > 0 Then
            factura_con_imp = True
        End If


        'guardar mov
        If turno_actual_global_ID = "" Then turno_actual_global_ID = "0"

        If Label_fechapago.Text = "" Then DateTime.Now.ToShortDateString()
        If turno_actualfecha = "" Then turno_actualfecha = DateTime.Now.ToShortDateString

        sql = "INSERT INTO COMPRAS (documento, tipoDocumento, DocCliente, ClienteNom, fecha, TOTALVENTA, DESCUENTO, BASEIMPUESTO, IMPUESTO, TOTAL, mediodepago, fechapago, empleadoCod, empleado, PEDIDO, turno, Estado, RETEFUENTE, RETE_VR, RETE_TOTAL)" &
               " VALUES (" & CLng(consecutivo) & ",'COMPRA','" & CStr(TXT_DOC_CLIENTE.Text) & "','" & TXT_NOM_CLIENTE.Text & "','" & Me.Label_fechapago.Text & "'," & CInt(TextBoxTotalDoc.Text) & "," & CInt(TextBox_dcto.Text) & "," & CInt(TextBoxbaseimp.Text) & "," & CInt(TextBoximp.Text) & "," & CInt(TextBoxTotalDoc.Text) & ",'" & ComboBox_CuentaPago.Text & "','" & Label_fechapago.Text & "','" & usrdoc & "','" & usrnom & "','" & CInt(Label_consecutivo.Text) & "'," & CInt(turno_actual_global_ID) & ",'DESCARGADO','" & NumericUpDown_retefuente.Value & "','" & TextBox_retefuente.Text & "','" & TextBox_retenciones.Text & "')"
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

        Dim TERCERO As String = CStr(TXT_DOC_CLIENTE.Text) & "|" & CStr(TXT_NOM_CLIENTE.Text)

        For J As Integer = 0 To datagrid_productos.RowCount - 1

            sql = "INSERT INTO COMPRAS_prods (documento, codprod, producto, cantidad, base, imp, imp2, impuesto, impuesto2, valoru, valortotal, estado, INVENTARIADO, IMPNOM1, IMPNOM2, costo)" &
                                    "VALUES (" & CInt(consecutivo) & "," & CInt(datagrid_productos.Item("CODPROD", J).Value) & ",'" & CStr(datagrid_productos.Item("PRODUCTO", J).Value) & "','" & CStr(datagrid_productos.Item("CANTIDAD", J).Value) & "','" & CInt(datagrid_productos.Item("base", J).Value) & "','" & CInt(datagrid_productos.Item("imp", J).Value) & "','" & CInt(datagrid_productos.Item("imp2", J).Value) & "','" & CInt(datagrid_productos.Item("impuesto", J).Value) & "','" & CInt(datagrid_productos.Item("impuesto2", J).Value) & "','" & CInt(datagrid_productos.Item("valoru", J).Value) & "','" & CInt(datagrid_productos.Item("valortotal", J).Value) & "','DESCARGADO','" & CStr(datagrid_productos.Item("INVENTARIADO", J).Value) & "','" & CStr(datagrid_productos.Item("IMPNOM1", J).Value) & "','" & CStr(datagrid_productos.Item("IMPNOM2", J).Value) & "','" & CStr(datagrid_productos.Item("costo", J).Value) & "')"
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

            PROD_SALEN = 0
            PROD_SALDO = 0
            PROD_SALDO = 0

            'contabilizar   EN INVENTARIO=======================================================================================
            'buscamos cuenta inventarios
            'Dim ctapucfull1 As String = ""
            'Dim ctapuc1() As String

            'Try
            '    saldo = 0
            '    sql = "SELECT concat(productos_categorias.impinv,'|',cuentaspuc.cuenta) as impinv 
            'FROM productos_categorias 
            'left join productos 
            'on productos.Categoria=productos_categorias.categoria 
            'left join cuentaspuc 
            'on cuentaspuc.codigo=productos_categorias.impinv 
            'where productos.cod=" & CStr(datagrid_productos.Item("CODPROD", J).Value) & ""
            '    da = New MySqlDataAdapter(sql, conex)
            '    dt = New DataTable
            '    da.Fill(dt)
            '    For Each row As DataRow In dt.Rows
            '        ctapucfull1 = row.Item("impinv")
            '    Next
            'Catch ex As Exception
            '    saldo = 0
            'End Try
            'conex.Close()
            'da.Dispose()
            'dt.Dispose()

            'ctapuc1 = Split(ctapucfull1, "|")

            'saldo = 0


            'PROD_ENTRAN = CInt(CInt(datagrid_productos.Item("valortotal", J).Value))  ' TOMO LA CANTIDAD DEL GRID Q ESTA RECORRIENDO
            'If factura_con_imp = True Then PROD_ENTRAN = CInt(CInt(datagrid_productos.Item("base", J).Value) * CInt(datagrid_productos.Item("cantidad", J).Value))
            'PROD_SALDO = saldo  ' IGUALDO SALDO PROD CON EL SALDO CALCULADO EN BODEGA PRICIPAL
            'PROD_SALDO = CInt(PROD_SALDO) + CInt(PROD_ENTRAN) ' PROD_ENTRAN   '  ACUMULO
            'PROD_SALEN = 0 ' POR QUE QUE ES UNA venta
            ''REGISTRO EN PUC
            'Dim TERCEROO As String = CStr(TXT_DOC_CLIENTE.Text) & "|" & CStr(TXT_NOM_CLIENTE.Text)

            'sql = "INSERT INTO cajaspuc(Codcuenta, cuenta, tercero, Fecha, Documento, TipoDoc, Rol, SaldoAnt, debe, haber, Saldo, DETALLE, Estado, annoactual)" &
            '               "VALUES ('" & ctapuc1(0) & "','" & ctapuc1(1) & "','" & TERCEROO & "','" & DateTime.Now.ToShortDateString & "','" & Label_consecutivo.Text & "','FACTURA DE COMPRA','ENTRAN'," & saldo & "," & PROD_ENTRAN & "," & PROD_SALEN & "," & PROD_SALDO & ",'" & CStr(CStr(datagrid_productos.Item("CODPROD", J).Value) & "|" & CStr(datagrid_productos.Item("PRODUCTO", J).Value)) & "','DESCARGADO','" & comex_annoactual & "')"
            'da = New MySqlDataAdapter(sql, conex)
            'dt = New DataTable
            'Try
            '    da.Fill(dt)
            'Catch ex As Exception
            '    MsgBox(ex.ToString)
            'End Try
            'da.Dispose()
            'dt.Dispose()
            'conex.Close()
            '=======================================================


            ' 'partida de iva   =======================================================================================
            ' If factura_con_imp = True Then
            '     ctapuc = "240810" : ctapucNOM = "Impuesto Sobre las Ventas por Pagar"

            '     saldo = 0

            '     PROD_ENTRAN = CInt(TextBoximp.Text)
            '     PROD_SALDO = saldo
            '     PROD_SALDO = CInt(PROD_SALDO) - CInt(PROD_ENTRAN) ' 
            '     PROD_SALEN = 0 ' POR QUE QUE ES UNA venta
            '     'REGISTRO EN PUC

            '     sql = "INSERT INTO cajaspuc(Codcuenta, cuenta, TERCERO, Fecha, Documento, TipoDoc, Rol, SaldoAnt, debe, haber, Saldo, DETALLE, Estado, annoactual)" &
            '"VALUES ('" & ctapuc & "','" & ctapucNOM & "','" & TERCERO & "','" & DateTime.Now.ToShortDateString & "','" & Label_consecutivo.Text & "','FACTURA DE COMPRA','SALEN'," & saldo & "," & PROD_ENTRAN & "," & PROD_SALEN & "," & PROD_SALDO & ",'FACTURA DE COMPRA','DESCARGADO','" & comex_annoactual & "')"
            '     da = New MySqlDataAdapter(sql, conex)
            '     dt = New DataTable
            '     Try
            '         da.Fill(dt)
            '     Catch ex As Exception
            '         MsgBox(ex.ToString)
            '     End Try
            '     da.Dispose()
            '     dt.Dispose()
            '     conex.Close()
            '     'partida de iva   =======================================================================================
            ' End If


        Next


        ''partida de retencion   =======================================================================================
        'If CheckBox_retefuente.Checked = True Then
        '    ctapuc = "236540" : ctapucNOM = "Retención en Compras"

        '    saldo = 0

        '    PROD_ENTRAN = 0
        '    PROD_SALDO = saldo
        '    PROD_SALDO = 0
        '    PROD_SALEN = CInt(TextBox_retefuente.Text) ' POR QUE QUE ES UNA compra
        '    'REGISTRO EN PUC

        '    sql = "INSERT INTO cajaspuc(Codcuenta, cuenta, TERCERO, Fecha, Documento, TipoDoc, Rol, SaldoAnt, debe, haber, Saldo, DETALLE, Estado, annoactual)" &
        '   "VALUES ('" & ctapuc & "','" & ctapucNOM & "','" & TERCERO & "','" & DateTime.Now.ToShortDateString & "','" & Label_consecutivo.Text & "','FACTURA DE COMPRA','SALEN'," & saldo & "," & PROD_ENTRAN & "," & PROD_SALEN & "," & PROD_SALDO & ",'FACTURA DE COMPRA','DESCARGADO','" & comex_annoactual & "')"
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
        '    'partida de rete   =======================================================================================
        'End If
        'If CheckBox_reteica.Checked = True Then
        '    ctapuc = "236840" : ctapucNOM = "Impuesto ICA"

        '    saldo = 0

        '    PROD_ENTRAN = 0
        '    PROD_SALDO = saldo
        '    PROD_SALDO = 0
        '    PROD_SALEN = CInt(TextBox_reteica.Text) ' POR QUE QUE ES UNA compra
        '    'REGISTRO EN PUC

        '    sql = "INSERT INTO cajaspuc(Codcuenta, cuenta, TERCERO, Fecha, Documento, TipoDoc, Rol, SaldoAnt, debe, haber, Saldo, DETALLE, Estado, annoactual)" &
        '   "VALUES ('" & ctapuc & "','" & ctapucNOM & "','" & TERCERO & "','" & DateTime.Now.ToShortDateString & "','" & Label_consecutivo.Text & "','FACTURA DE COMPRA','SALEN'," & saldo & "," & PROD_ENTRAN & "," & PROD_SALEN & "," & PROD_SALDO & ",'FACTURA DE COMPRA','DESCARGADO','" & comex_annoactual & "')"
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

        'If CheckBox_reteIVA.Checked = True Then
        '    ctapuc = "230802" : ctapucNOM = "Retención IVA"

        '    saldo = 0

        '    PROD_ENTRAN = 0
        '    PROD_SALDO = saldo
        '    PROD_SALDO = 0
        '    PROD_SALEN = CInt(TextBox_reteiva.Text) ' POR QUE QUE ES UNA compra
        '    'REGISTRO EN PUC

        '    sql = "INSERT INTO cajaspuc(Codcuenta, cuenta, TERCERO, Fecha, Documento, TipoDoc, Rol, SaldoAnt, debe, haber, Saldo, DETALLE, Estado, annoactual)" &
        '   "VALUES ('" & ctapuc & "','" & ctapucNOM & "','" & TERCERO & "','" & DateTime.Now.ToShortDateString & "','" & Label_consecutivo.Text & "','FACTURA DE COMPRA','SALEN'," & saldo & "," & PROD_ENTRAN & "," & PROD_SALEN & "," & PROD_SALDO & ",'FACTURA DE COMPRA','DESCARGADO','" & comex_annoactual & "')"
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



        '    ctapuc = "240802" : ctapucNOM = "IVA ASUMIDO"

        '    saldo = 0

        '    PROD_ENTRAN = CInt(TextBox_reteiva.Text)
        '    PROD_SALDO = saldo
        '    PROD_SALDO = 0
        '    PROD_SALEN = 0 ' POR QUE QUE ES UNA compra
        '    'REGISTRO EN PUC

        '    sql = "INSERT INTO cajaspuc(Codcuenta, cuenta, TERCERO, Fecha, Documento, TipoDoc, Rol, SaldoAnt, debe, haber, Saldo, DETALLE, Estado, annoactual)" &
        '   "VALUES ('" & ctapuc & "','" & ctapucNOM & "','" & TERCERO & "','" & DateTime.Now.ToShortDateString & "','" & Label_consecutivo.Text & "','FACTURA DE COMPRA','SALEN'," & saldo & "," & PROD_ENTRAN & "," & PROD_SALEN & "," & PROD_SALDO & ",'FACTURA DE COMPRA','DESCARGADO','" & comex_annoactual & "')"
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

        'CONTABILIZACION CAJA ====================================================================================

        If ComboBox_CuentaPago.Text.ToString.Contains("CREDITO") = False Then
            PROD_SALEN = 0
            PROD_SALDO = 0
            PROD_SALDO = 0

            saldo = 0

            PROD_SALEN = CInt(TextBoxTotalDoc.Text) - CInt(TextBox_retefuente.Text) - CInt(TextBox_reteica.Text)
            PROD_SALDO = saldo
            PROD_SALDO = CInt(PROD_SALDO) - CInt(PROD_SALEN)
            PROD_ENTRAN = 0

            If ComboBox_CuentaPago.Text.Contains("CREDITO") Then
                PROD_SALEN = CInt(TextBoxTotalDoc.Text)
                PROD_SALDO = saldo
                PROD_SALDO = CInt(PROD_SALDO) + CInt(PROD_SALEN)
                PROD_ENTRAN = 0

            End If
            'REGISTRO EN PUC

            sql = "INSERT INTO cajaspuc(Codcuenta, cuenta, TERCERO, Fecha, Documento, TipoDoc, Rol, SaldoAnt, debe, haber, Saldo, Estado, annoactual, DETALLE)" &
                               "VALUES ('" & ComboBox_CuentaPago.SelectedValue & "','" & ComboBox_CuentaPago.Text & "','" & CStr(TERCERO) & "','" & turno_actualfecha & "','" & Label_consecutivo.Text & "','FACTURA DE COMPRA','SALEN'," & saldo & "," & PROD_ENTRAN & "," & PROD_SALEN & "," & PROD_SALDO & ",'DESCARGADO','" & comex_annoactual & "','FACTURA DE COMPRA')"
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
        '================================================================================================



        'GUARDAR LA CUENTA DE COBRO

        If ComboBox_MedioPago.Text.ToString.Contains("CREDITO") = True Then

            'CONSECUTIVO
            consecutivo_CXC = 0
            cmd.Connection = conex
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select max(documento) + 1 from carteracredito WHERE TIPO='CREDITO'"
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


            If turno_actualfecha = "" Then turno_actualfecha = DateTime.Now.ToShortDateString
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
        VALUES(" & CLng(consecutivo_CXC) & ",'CREDITO','" & turno_actualfecha & "','" & CStr(TXT_DOC_CLIENTE.Text) & "','" & CStr(TXT_NOM_CLIENTE.Text) & "','FACTURA DE COMPRA','" & Label_consecutivo.Text & "','COMPRA A CREDITO','" & CInt(TextBoxTotalDoc.Text) & "','" & CInt(TextBoxTotalDoc.Text) & "','" & Label_fechapago.Text & "','" & usrnom & "','PENDIENTE')"
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



        'GUARDA EN CAJA TURNO
        If turno_actualfecha = "" Then turno_actualfecha = DateTime.Now.ToShortDateString

        If turno_actual_global <> "" Then
            sql = "INSERT INTO CAJA (turno, fecha, documento, tipoDocumento, subtotal, descuento, total, mediodepago, EmpleadoDoc, empleado, estado)" &
              "VALUES ('" & turno_actual_global & "','" & turno_actualfecha & "'," & consecutivo & ",'COMPRA'," & CInt(TextBoxTotalDoc.Text) & ",0," & CInt(TextBoxTotalDoc.Text) & ",'" & ComboBox_MedioPago.Text & "'," & CInt(usrdoc) & ",'" & usrnom & "','DESCARGADO')"
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



        sql = "UPDATE pedidosprov set FACTURADO='SI', nrofac='" & consecutivo & "', fechapago='" & Me.Label_fechapago.Text & "', facturap='" & TextBox_nrofacprov.Text & "', tecnico='" & Label_VENDEDOR.Text & "', mediopago='" & ComboBox_CuentaPago.Text & "' WHERE CONS=" & CLng(Label_consecutivo.Text) & ""
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


        Me.Label_estado_movimiento.Text = "FACTURADO"
        Me.Button_FACTURAR.Text = "FACTURADO"
    End Sub


    Private Sub LABEL_NIT_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub Timer_prod_data_Tick(sender As Object, e As EventArgs) Handles Timer_prod_data.Tick
        Me.Timer_prod_data.Enabled = False

        Label_saldo_lote.Text = 0
        Label_saldo_actual.Text = 0
        Label56.Text = "-"
        Label58.Text = "-"
        Label_sugeridomax.Text = "0/0/0"

        datos_del_producto()

        BUSCA_SALDO_PRODUCTO()

        busca_lotes()


        Me.TextBox_valorunitario.Text = PROD_COSTO
        NumericUpDown_CANT.Value = 0

        TextBox_buscar_cod.Focus()

    End Sub
    Private Sub busca_lotes()
        ''LLENADO contactos
        Try
            sql = "SELECT DISTINCT(lote) as lotes FROM movimientos_prods where codprod='" & prod_cod & "'"
            da_lotes = New MySqlDataAdapter(sql, conex)
            DT_lotes = New DataTable
            da_lotes.Fill(DT_lotes)
            Me.TextBox_lote.DataSource = DT_lotes.DefaultView
            Me.TextBox_lote.DisplayMember = "lotes"
            Me.TextBox_lote.ValueMember = "lotes"
            Me.TextBox_lote.AutoCompleteSource = AutoCompleteSource.ListItems
            Me.TextBox_lote.AutoCompleteMode = AutoCompleteMode.Suggest
            Me.TextBox_lote.Text = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_lotes.Dispose()
        DT_lotes.Dispose()
        conex.Close()

    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox_buscar_cod.TextChanged

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        TXT_DOC_CLIENTE.Text = ""
        TXT_NOM_CLIENTE.Text = ""
        TXT_TELS_CLIENTE.Text = ""
        TXT_DIR_CLIENTE.Text = ""
        Label_VENDEDOR.Text = ""

    End Sub



    Private Sub Label28_Click(sender As Object, e As EventArgs) Handles Label28.Click

    End Sub

    Private Sub Panel17_Paint(sender As Object, e As PaintEventArgs) Handles Panel17.Paint

    End Sub

    Private Sub TextBox_retefuente_TextChanged(sender As Object, e As EventArgs) Handles TextBox_retenciones.TextChanged

    End Sub

    Private Sub Timer_gridProds_Tick(sender As Object, e As EventArgs) Handles Timer_gridProds.Tick
        Timer_gridProds.Enabled = False

        Me.Cursor = Cursors.WaitCursor

        grid_comprasprods()
        Me.Cursor = Cursors.Default
        Me.datagrid_productos.CurrentCell = Nothing
        Me.Cursor = Cursors.Default
        Button_agregar_prod.Enabled = True

    End Sub

    Private Sub CheckBox_retefuente_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_retefuente.CheckedChanged

        If CheckBox_retefuente.Checked = True Then
            NumericUpDown_retefuente.Enabled = True
            TextBox_retefuente.Enabled = True

            NumericUpDown_retefuente_ValueChanged(Nothing, Nothing)
        End If



        If CheckBox_retefuente.Checked = False Then
            NumericUpDown_retefuente.Enabled = False
            TextBox_retefuente.Enabled = False
            TextBox_retefuente.Text = 0

            TextBox_retenciones.Text = CInt(TextBox_retefuente.Text) + CInt(TextBox_reteica.Text) + CInt(TextBox_reteiva.Text)

        End If
    End Sub

    Private Sub Combobox_impuestos_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button_cerrar_panel_opciones_Click(sender As Object, e As EventArgs) Handles Button_cerrar_panel_opciones.Click
        If Me.Panel_impuestos.Visible = True Then Me.Panel_impuestos.Visible = False : Me.Panel_prods.Visible = True : Exit Sub
        If Me.Panel_impuestos.Visible = False Then Me.Panel_impuestos.Visible = True : Me.Panel_prods.Visible = False : Exit Sub
    End Sub

    Private Sub Button_MAIL_Click(sender As Object, e As EventArgs)
        Try
            sql = "SELECT CODPROD, PRODUCTO, CANTIDAD, VALORU, VALORTOTAL FROM pedidosprov_PRODS WHERE documento = " & CInt(Label_consecutivo.Text) & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DATAGrid_EXPORTAR.DataSource = dt
            Me.DATAGrid_EXPORTAR.Columns(0).Width = 50
            Me.DATAGrid_EXPORTAR.Columns(1).Width = 250
            Me.DATAGrid_EXPORTAR.Columns(2).Width = 50


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()



        Try
            'Intentar generar el documento.
            Dim doc As New Document(PageSize.A4, 10, 20, 10, 10)
            'Path que guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\pedidoproveedor" & Me.Label_consecutivo.Text & ".pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, file)
            doc.Open()
            ExportarDatosPDF2(doc)
            doc.Close()
            'Process.Start(filename)
        Catch ex As Exception
            'Si el intento es fallido, mostrar MsgBox.
            MessageBox.Show("No se puede generar el documento PDF, Cierre los documentos PDF generados anteriormente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

    Private Sub MetroDateTime3_ValueChanged(sender As Object, e As EventArgs) Handles MetroDateTime3.ValueChanged
        Me.Label_fechapago.Text = MetroDateTime3.Value.ToShortDateString

    End Sub

    Private Sub combobox_BuscarProd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobox_BuscarProd.SelectedIndexChanged

    End Sub

    Private Sub Timer_impuesto_Tick(sender As Object, e As EventArgs) Handles Timer_impuesto.Tick
        Timer_impuesto.Enabled = False

        'If Me.ComboBox_retefuente.Text = "VALOR" Then
        '    Me.TextBox_espejo1.Visible = True
        '    Me.TextBox_espejo1.Enabled = True
        '    Me.TextBox_espejo1.Text = Me.ComboBox_retefuente.SelectedValue.ToString

        'End If

        'If Me.ComboBox_retefuente.Text = "PORCENTAJE" Then


        '    TextBox_retefuente.Text = (CInt(TextBoxTotalDoc.Text) * (CInt(TextBox_espejo1.Text))) / 100
        '    Me.TextBoxTotalDoc.Text = CInt(Me.TextBoxTotalDoc.Text) - CInt(TextBox_retefuente.Text)

        '    Me.TextBox_retefuente.Text = Format(CDec(Me.TextBox_retefuente.Text), "##,##0")
        '    Me.TextBoxTotalDoc.Text = Format(CDec(Me.TextBoxTotalDoc.Text), "##,##0")

        'End If


    End Sub

    Private Sub load_grid_EXPORTAR()
        Try
            sql = "select CONS, FECHA, CODCLIENTE, CLIENTE, ESTADO, DESCARGADO, FACTURADO, NROFAC from pedidosprov WHERE ESTADO='" & filtro & "' and year(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & comex_annoactual & "'"
            If filtro = "TODO" Then sql = "select CONS, FECHA, CODCLIENTE, CLIENTE, ESTADO, DESCARGADO, FACTURADO, NROFAC from pedidosprov where year(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & comex_annoactual & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.datagrid_PEDIDOS.DataSource = dt


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        Me.datagrid_PEDIDOS.ClearSelection()

        Me.datagrid_PEDIDOS.Columns(0).Width = 50
        Me.datagrid_PEDIDOS.Columns(1).Width = 100
        Me.datagrid_PEDIDOS.Columns(2).Width = 100

        'Me.datagrid_PEDIDOS.Columns(3).Width = 250
        Me.datagrid_PEDIDOS.Columns(4).Width = 100
        Me.datagrid_PEDIDOS.Columns(5).Width = 90
        Me.datagrid_PEDIDOS.Columns(6).Width = 80
        Me.datagrid_PEDIDOS.Columns(7).Width = 70

        Me.datagrid_PEDIDOS.ClearSelection()
    End Sub

    Private Sub TextBox_espejo1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Button2.Visible = False
        Me.Button_pdf.Visible = True
        Me.Button_excel.Visible = True
    End Sub


    Public Sub ExportarLISTADO(ByVal document As Document)
        'Se crea un objeto PDFTable con el numero de columnas del DataGridView.
        Dim datatable As New PdfPTable(datagrid_PEDIDOS.ColumnCount)
        'Se asignan algunas propiedades para el diseño del PDF.
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(datagrid_PEDIDOS)

        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER

        'Se crea el encabezado en el PDF.
        Dim encabezado As New Paragraph(comex_nombrecomercial, New Font(Font.Name = "Tahoma", 14, Font.Bold))
        Dim encabezado2 As New Paragraph("PEDIDOS A PROVEEDORES", New Font(Font.Name = "Arial Balck", 12, Font.Bold))

        'Se crea el texto abajo del encabezado.
        Dim texto As New Phrase("Filtro: " + filtro + Chr(13), New Font(Font.Name = "Arial Narrow", 10, Font.Bold))
        Dim texto2 As New Phrase("Fecha del Reporte: " + Now.Date(), New Font(Font.Name = "Arial Narrow", 10, Font.Bold))
        Dim texto3 As New Phrase("          Generado Por :" + usrnom, New Font(Font.Name = "Arial Narrow", 10, Font.Bold))

        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To datagrid_PEDIDOS.ColumnCount - 1
            Dim cellhdr As New PdfPCell(New Phrase(datagrid_PEDIDOS.Columns(i).HeaderText, New Font(Font.Name = "Arial", 10.0F, FontStyle.Bold)))
            'datatable.AddCell(MetroGrid_pdf.Columns(i).HeaderText)
            cellhdr.HorizontalAlignment = Element.ALIGN_CENTER
            cellhdr.BackgroundColor = BaseColor.LIGHT_GRAY
            datatable.AddCell(cellhdr)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1
        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To datagrid_PEDIDOS.RowCount - 1
            For j As Integer = 0 To datagrid_PEDIDOS.ColumnCount - 1

                Dim cell As New PdfPCell
                cell.Phrase = New Phrase(datagrid_PEDIDOS(j, i).Value.ToString, New Font(Font.Name = "Arial Narrow", 8))
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
        document.Add(texto)
        document.Add(texto2)
        document.Add(datatable)
        document.Add(texto3)

    End Sub

    Private Sub TextBoximp_TextChanged(sender As Object, e As EventArgs) Handles TextBoximp.TextChanged

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub Timer_info_Tick(sender As Object, e As EventArgs) Handles Timer_info.Tick
        Me.Timer_info.Enabled = False

    End Sub

    Private Sub TextBox_subtotal_TextChanged(sender As Object, e As EventArgs) Handles TextBox_subtotal.TextChanged

    End Sub

    Private Sub Button_pdf_Click(sender As Object, e As EventArgs) Handles Button_pdf.Click
        Me.Cursor = Cursors.WaitCursor

        load_grid_EXPORTAR()


        Try
            'Intentar generar el documento.
            Dim doc As New Document(PageSize.A4.Rotate, 10, 10, 10, 10)
            'Path que guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\LISTADO DE PEDIDOS.pdf"
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

        load_grid_PEDIDOS_CLIENTES_FILTRO(filtro)
        If filtro = "" Or filtro = "TODO" Then
            load_grid_PEDIDOS_provs()

        End If
        Me.Cursor = Cursors.Default
        Me.Button2.Visible = True
        Me.Button_pdf.Visible = False
        Me.Button_excel.Visible = False

    End Sub

    Function GridAExcel(ByVal ElGrid As DataGridView) As Boolean
        'Creamos las variables
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
        exLibro = exApp.Workbooks.Open(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Reporte de Pedidos.xls")
        exHoja = exApp.ActiveWorkbook.Sheets(1)
        Try
            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = ElGrid.ColumnCount
            Dim NRow As Integer = ElGrid.RowCount

            'encabezados
            exHoja.Cells.Item(2, 2) = "Reporte de Pedidos a Proveedoes"
            exHoja.Cells.Item(3, 2) = usrnom.ToString
            exHoja.Cells.Item(4, 2) = DateTime.Now.ToString
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

            'Titulo en negrita, Alineado al centro y que el tamaño de la columna seajuste al texto
            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3
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

    Private Sub Button_continuar_Click(sender As Object, e As EventArgs) Handles Button_continuar.Click
        Me.Cursor = Cursors.WaitCursor

        If Me.TXT_DOC_CLIENTE.Text = "" Or TXT_NOM_CLIENTE.Text = "" Then
            Timer_info.Enabled = True
            Me.Cursor = Cursors.Default

            Exit Sub
        End If


        sql = "INSERT INTO pedidosprov(FECHA, fechaentrega, codcliente, cliente, Observaciones, empleadocod, empleado, tecnico, Estado, fechapago, RETEFUENTE, RETE_VR, RETE_TOTAL, descuento, facturap, BODEGA)" &
             "VALUES ('" & Label_fecha.Text & "','" & Label_fechaentrega.Text & "','" & TXT_DOC_CLIENTE.Text & "','" & TXT_NOM_CLIENTE.Text & "','" & Text_leyenda.Text & "','" & usrdoc & "','" & usrnom & "','" & Label_VENDEDOR.Text & "','PENDIENTE','" & Me.Label_fechapago.Text & "','" & PROD_RETEFUENTE & "','" & CStr(PROD_RETEFUENTE_VALOR) & "','" & CStr(PROD_RETEFUENTE_TOTAL) & "','" & CInt(TextBox_dcto.Text) & "','" & CStr(TextBox_nrofacprov.Text) & "','" & comex_bodega_compras & "')"
        da = New MySqlDataAdapter(sql, conex)
        dt = New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            Me.Cursor = Cursors.Default

            MsgBox(ex.ToString)
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()
        Me.Cursor = Cursors.Default

        Me.Cursor = Cursors.WaitCursor
        loads_productos("", "")
        Me.Cursor = Cursors.Default

        Me.Button_agregar_prod.Visible = True : Me.Button_agregar_prod.Enabled = True
        Me.button_Quitar_Prod.Visible = True : Me.button_Quitar_Prod.Enabled = True

        Me.TextBox_valorunitario.Text = 0

        Me.Button_guardar.Text = "Guardar Cambios"
        Me.Label_estado_movimiento.Text = "PENDIENTE"

        Me.Cursor = Cursors.WaitCursor
        cmd.Connection = conex
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select max(cons) from pedidosprov"
        conex.Open()
        Try
            dr_consecutivos = cmd.ExecuteReader()
            If dr_consecutivos.Read() Then
                Label_consecutivo.Text = dr_consecutivos(0).ToString
            Else
                Label_consecutivo.Text = "1"
            End If
        Catch ex As Exception
            Label_consecutivo.Text = "1"
            conex.Close()
        End Try
        conex.Close()

        Me.Cursor = Cursors.Default

        Me.Timer_info.Enabled = True

        OCULTO_OPCIONES_BOTONES()

        Me.Button_finalizar.Enabled = True
        Me.Button_ANULAR.Enabled = True
        Me.Button_descargar.Enabled = True
        Me.Button_FACTURAR.Enabled = True
        Me.Button_EXPORTAR.Enabled = True
        Me.Button_continuar.Visible = False
        Me.Button_guardar.Visible = False

        Me.Panel_prods.Visible = True
        Panel_prods.Enabled = True

        Me.CheckBox_retefuente.Visible = True

        Timer_gridProds.Enabled = True
        Me.Cursor = Cursors.Default
        ComboBox_CuentaPago.SelectedItem = Nothing

    End Sub

    Private Sub ComboBox_nombre_prov_SelectedIndexChanged(sender As Object, e As EventArgs)

        Timer_clientes.Enabled = True

    End Sub

    Private Sub Button_excel_Click(sender As Object, e As EventArgs) Handles Button_excel.Click
        Me.Cursor = Cursors.WaitCursor


        Dim RTA1 As String
        RTA1 = MsgBox("El informe que se va a generar puede tardar un tiempo considerable dependiendo de su tamaño." & Chr(13) & "Desea generar el archivo ahora?.", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If RTA1 = 6 Then
            Me.datagrid_PEDIDOS.Enabled = False
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
                        oFileStream = New FileStream(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Reporte de Pedidos.xls", FileMode.Create, FileAccess.ReadWrite)
                        oFileStream.Write(aBytDocumento, 0, aBytDocumento.Length)
                        oFileStream.Close()
                        'MessageBox.Show("Documento generado con éxito", "Generar Documentos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            Catch Exp As Exception
                MessageBox.Show(Exp.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            Me.Cursor = Cursors.WaitCursor

            GridAExcel(Me.datagrid_PEDIDOS)

            Me.Cursor = Cursors.Default
            'load docuemtno?????
            Dim RTA As String
            RTA = MsgBox("Se Generó el informe de productos" & Chr(13) & Chr(13) & "Desea Ver el archivo ahora?.", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
            If RTA = 6 Then
                System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Reporte de Pedidos.xls")
            End If
            Me.datagrid_PEDIDOS.Enabled = True
        End If     ' fin de generar el informe.

        Me.Cursor = Cursors.Default
        Me.Button2.Visible = True
        Me.Button_pdf.Visible = False
        Me.Button_excel.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_ANULAR.Click

        If PERMISO_1(21) = "NO" Or PERMISO_1(21) = Nothing Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub

        Dim RTA As String
        RTA = MsgBox("Desea anular este pedido?.", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If RTA = 6 Then
            Me.Cursor = Cursors.WaitCursor

            sql = "update pedidosprov SET estado='ANULADO' WHERE CONS=" & CLng(Label_consecutivo.Text) & ""
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

            sql = "update pedidosprov_prods SET estado='ANULADO' WHERE documento=" & CLng(Label_consecutivo.Text) & ""
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



            Me.Button_ANULAR.Visible = False
            Me.Button_descargar.Visible = False
            Me.Button_FACTURAR.Visible = False
            Me.Button_guardar.Visible = False
            Me.Cursor = Cursors.Default

            If NRO_FACTURA <> "" Then
                sql = "update compras SET estado='ANULADO' WHERE CONS=" & (NRO_FACTURA) & ""
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

                sql = "update compras_prods SET estado='ANULADO' WHERE documento=" & (NRO_FACTURA) & ""
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


                sql = "delete from CAJASPUC WHERE DOCUMENTO=" & CInt(Me.Label_consecutivo.Text) & " and tipodocumento='FACTURA DE COMPRA'"
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


                Label_estado_movimiento.Text = "ANULADO"
            End If

            If Me.Button_descargar.Text = "DESCARGADO" Then

                sql = "delete from bodega_" & ComboBox_bodega_destino.Text & " where DOCUMENTO=" & CInt(Me.Label_consecutivo.Text) & " and tipodocumento='COMPRA'"
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


                sql = "delete from CAJASPUC WHERE DOCUMENTO=" & CInt(Me.Label_consecutivo.Text) & " and tipodocumento='FACTURA DE COMPRA'"
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

            Button_Regresar_Click(Nothing, Nothing)


        End If


    End Sub



    Private Sub Timer_PROF_OFF_Tick(sender As Object, e As EventArgs) Handles Timer_PROD_OFF.Tick
        Timer_PROD_OFF.Enabled = False

        Me.combobox_BuscarProd.SelectedIndex = -1
        Me.NumericUpDown_CANT.Value = 0
        Me.TextBox_buscar_barras.Text = ""
        Me.TextBox_valorunitario.Text = "0"
        Me.TextBox_Total.Text = "0"
        Me.TextBox_buscar_cod.Text = ""
    End Sub



    Private Sub ComboBox_MEDIO_PAGO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_CuentaPago.SelectedIndexChanged

    End Sub






    Private Sub Button_ANULA_Click(sender As Object, e As EventArgs)

    End Sub







    Private Sub Label46_Click(sender As Object, e As EventArgs) Handles Label46.Click
        If Me.TextBox_valorunitario.Text = "" Then TextBox_valorunitario.Text = "0"

        If TextBox_valorunitario.Text > 0 Then
            TextBox_valorunitario.Text = CInt(TextBox_valorunitario.Text) * (1.19)
        End If
    End Sub



    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        TextBox_vencimiento.Text = DateTimePicker1.Value.ToShortDateString

    End Sub

    Private Sub TextBox_vencimiento_TextChanged(sender As Object, e As EventArgs) Handles TextBox_vencimiento.TextChanged

    End Sub




    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.ComboBox_filtroprov.SelectedValue = -1
        load_grid_PEDIDOS_provs()
    End Sub

    Private Sub TXT_DOC_CLIENTE_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub TextBox_DV_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox_buscar_prod.TextChanged

    End Sub

    Private Sub Button_finalizar_Click(sender As Object, e As EventArgs) Handles Button_finalizar.Click
        If PERMISO_1(21) = "NO" Or PERMISO_1(21) = Nothing Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub



        If Me.Button_descargar.Enabled = True Then
            Dim RTA_DESC As String
            RTA_DESC = MsgBox("El pedido aún no se ha descargado en bodega, confirma que desea finalizar el pedido?.", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
            If RTA_DESC = 6 Then
            Else
                Exit Sub
            End If
        End If

        If Me.Button_FACTURAR.Enabled = True Then
            Dim RTA_DESC As String
            RTA_DESC = MsgBox("El pedido aún no se ha facturado, confirma que desea finalizar el pedido?.", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
            If RTA_DESC = 6 Then
            Else
                Exit Sub
            End If
        End If




        Dim RTA As String
        RTA = MsgBox("Desea finalizar el pedido?.", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If RTA = 6 Then
            Me.Cursor = Cursors.WaitCursor

            sql = "update pedidosprov SET estado='FINALIZADO' WHERE CONS=" & CLng(Label_consecutivo.Text) & ""
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

            Me.Label_VENDEDOR.Enabled = False
            Me.ComboBox_CuentaPago.Enabled = False

            Me.MetroDateTime1.Enabled = False
            Me.MetroDateTime3.Enabled = False
            Me.CheckBox_retefuente.Visible = False
            Me.Button_ANULAR.Enabled = False
            Me.Button_descargar.Enabled = False
            Me.Button_FACTURAR.Enabled = False
            Me.Button_guardar.Enabled = False
            Me.Cursor = Cursors.Default
            Me.Label_estado_movimiento.Text = "FINALIZADO"
        End If
    End Sub

    Private Sub COMBO_DOC_CLIENTE_FILTRO_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub COMBO_NOM_CLIENTE_FILTRO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMBO_NOM_CLIENTE_FILTRO.SelectedIndexChanged

    End Sub

    Private Sub Timer_prod_data_cod_Tick(sender As Object, e As EventArgs) Handles Timer_prod_data_cod.Tick
        Me.Timer_prod_data_cod.Enabled = False
        datos_del_producto()
        busca_lotes()


        Me.TextBox_valorunitario.Text = PROD_COSTO
    End Sub


    Private Sub TextBox_Total_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Total.TextChanged

    End Sub

    Private Sub grid_comprasprods()
        Try
            sql = "SELECT * FROM pedidosprov_PRODS WHERE documento = " & CInt(Label_consecutivo.Text) & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.datagrid_productos.DataSource = dt
            Me.datagrid_productos.Columns(0).Visible = False
            Me.datagrid_productos.Columns(1).Visible = False
            Me.datagrid_productos.Columns(2).HeaderText = "Código"
            Me.datagrid_productos.Columns(2).Width = 60
            Me.datagrid_productos.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagrid_productos.Columns(3).HeaderText = "Producto"
            Me.datagrid_productos.Columns(3).Width = 240
            Me.datagrid_productos.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagrid_productos.Columns(4).HeaderText = "Cant"
            Me.datagrid_productos.Columns(4).Width = 40
            Me.datagrid_productos.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.datagrid_productos.Columns(5).HeaderText = "P/Base"
            Me.datagrid_productos.Columns(5).Width = 50
            Me.datagrid_productos.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.datagrid_productos.Columns.Item("Base").DefaultCellStyle.Format = "###,##0"
            'Me.datagrid_productos.Columns(6).HeaderText = "ICO"
            'Me.datagrid_productos.Columns(6).Width = 50
            'Me.datagrid_productos.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.datagrid_productos.Columns(6).Visible = False

            Me.datagrid_productos.Columns.Item("Imp").DefaultCellStyle.Format = "###,##0"
            Me.datagrid_productos.Columns(7).HeaderText = "IVA"
            Me.datagrid_productos.Columns(7).Width = 50
            Me.datagrid_productos.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.datagrid_productos.Columns.Item("imp2").DefaultCellStyle.Format = "###,##0"
            Me.datagrid_productos.Columns(8).Visible = False
            Me.datagrid_productos.Columns(9).Visible = False
            Me.datagrid_productos.Columns(10).HeaderText = "Valor/U"
            Me.datagrid_productos.Columns(10).Width = 80
            Me.datagrid_productos.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.datagrid_productos.Columns.Item("ValorU").DefaultCellStyle.Format = "###,##0"
            Me.datagrid_productos.Columns(11).HeaderText = "TOTAL"
            Me.datagrid_productos.Columns(11).Width = 90
            Me.datagrid_productos.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            datagrid_productos.Columns.Item("valorTOTAL").DefaultCellStyle.Format = "###,##0"

            Me.datagrid_productos.Columns(12).Visible = False
            Me.datagrid_productos.Columns(13).Visible = False
            Me.datagrid_productos.Columns(14).Visible = False
            Me.datagrid_productos.Columns(15).Visible = False
            Me.datagrid_productos.Columns(16).Visible = False
            Me.datagrid_productos.Columns(17).Visible = False

            Me.datagrid_productos.Columns(18).HeaderText = "Lote"
            Me.datagrid_productos.Columns(18).Width = 60
            Me.datagrid_productos.Columns(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.datagrid_productos.Columns(19).HeaderText = "Vence"
            Me.datagrid_productos.Columns(19).Width = 60
            Me.datagrid_productos.Columns(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.datagrid_productos.Columns(18).Visible = False
            Me.datagrid_productos.Columns(19).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()

        datagrid_productos.ClearSelection()


        Me.TextBox_subtotal.Text = 0
        Me.TextBoxTotalDoc.Text = 0
        Me.TextBox_impuesto.Text = 0
        Me.TextBox_impuesto2.Text = 0
        Me.TextBox_BASEimp.Text = 0
        Me.TextBoximp.Text = 0
        Try
            For i As Integer = 0 To datagrid_productos.RowCount - 1

                Me.TextBoxTotalDoc.Text = CInt(Me.TextBoxTotalDoc.Text) + CInt(datagrid_productos.Item("valortotal", i).Value)
                Me.TextBox_impuesto.Text = CInt(Me.TextBox_impuesto.Text) + CInt(datagrid_productos.Item("impuesto", i).Value)
                Me.TextBox_impuesto2.Text = CInt(Me.TextBox_impuesto2.Text) + CInt(datagrid_productos.Item("impuesto2", i).Value)
                Me.TextBox_BASEimp.Text = 0
                'CInt(Me.TextBox_BASEimp.Text) + CInt(CInt(datagrid_productos.Item("BASE", i).Value) * CInt(datagrid_productos.Item("CANTIDAD", i).Value))
                Me.TextBoxbaseimp.Text = 0
                'CInt(Me.TextBox_BASEimp.Text) + CInt(CInt(datagrid_productos.Item("BASE", i).Value) * CInt(datagrid_productos.Item("CANTIDAD", i).Value))


                Me.TextBoxbaseimp.Text = CInt(Me.TextBoxbaseimp.Text) + CInt(CInt(datagrid_productos.Item("BASE", i).Value) * CInt(datagrid_productos.Item("CANTIDAD", i).Value))
            Next

            TextBoximp.Text = CInt(TextBox_impuesto.Text) + CInt(TextBox_impuesto2.Text)

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        If CInt(TextBoxTotalDoc.Text) > 895000 Then
            CheckBox_retefuente.Enabled = True
            If CLI_DECLARANTE = "SI" Then NumericUpDown_retefuente.Value = 2.5
            If CLI_DECLARANTE = "NO" Then NumericUpDown_retefuente.Value = 3.5

        End If

        If CInt(TextBoxTotalDoc.Text) > 895000 Then
            CheckBox_reteica.Enabled = True

        End If

        If CInt(TextBoxTotalDoc.Text) > 895000 Then
            CheckBox_reteIVA.Enabled = True
        End If


        TextBox_subtotal.Text = Format(CDec(Me.TextBoxTotalDoc.Text), "##,##0") - CInt(TextBox_dcto.Text) - CInt(TextBoximp.Text)

        Me.TextBoxTotalDoc.Text = Format(CDec(Me.TextBoxTotalDoc.Text), "##,##0")
        Me.TextBox_subtotal.Text = Format(CDec(Me.TextBox_subtotal.Text), "##,##0")
        Me.TextBox_BASEimp.Text = Format(CDec(Me.TextBox_BASEimp.Text), "##,##0")
        Me.TextBoxbaseimp.Text = Format(CDec(Me.TextBoxbaseimp.Text), "##,##0")


        Me.TextBox_impuesto.Text = Format(CDec(Me.TextBox_impuesto.Text), "##,##0")
        Me.TextBox_impuesto2.Text = Format(CDec(Me.TextBox_impuesto2.Text), "##,##0")
        Me.TextBoximp.Text = Format(CDec(Me.TextBoximp.Text), "##,##0")
        Me.TextBox_dcto.Text = Format(CDec(Me.TextBox_dcto.Text), "##,##0")

        'If CheckBox_retefuente.CheckState = CheckState.Checked Then
        '    TextBox_retenciones.Text = (CInt(TextBoxTotalDoc.Text) * (CInt(TextBox_espejo1.Text))) / 100
        '    Me.TextBoxTotalDoc.Text = CInt(Me.TextBoxTotalDoc.Text) - CInt(TextBox_retenciones.Text)

        '    Me.TextBoxTotalDoc.Text = Format(CDec(Me.TextBoxTotalDoc.Text), "##,##0")
        '    Me.TextBox_retenciones.Text = Format(CDec(Me.TextBox_retenciones.Text), "##,##0")
        'End If
        If TextBox_retenciones.Text = "" Then TextBox_retenciones.Text = "0"




        TextBoxbaseimp.Text = CInt(TextBoxTotalDoc.Text) - CInt(TextBoximp.Text) - CInt(TextBox_retenciones.Text)
        Me.TextBoxbaseimp.Text = Format(CDec(Me.TextBoxbaseimp.Text), "##,##0")


        Try
            sql = "SELECT CODPROD AS CODIGO, PRODUCTO, BASE AS BASE, IMP AS ICO, IMP2 AS IVA, VALORU, VALORTOTAL FROM PEDIDOSPROV_prods WHERE DOCUMENTO='" & Label_consecutivo.Text & "' and concat(impnom1,impnom2)<>'NONO'"
            If fact_saveok = 1 Then sql = "SELECT CODPROD AS CODIGO, PRODUCTO, BASE AS BASE, IMP AS ICO, IMP2 AS IVA, VALORU, VALORTOTAL FROM PEDIDOSPROV_prods WHERE DOCUMENTO='" & Label_consecutivo.Text & "' and concat(impnom1,impnom2)<>'NONO'"

            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.MetroGrid_impuestos.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message.ToString)

        End Try

        Me.datagrid_productos.ClearSelection()
        Me.datagrid_productos.ClearSelection()

    End Sub

    Private Sub Button_REFRESH_Click(sender As Object, e As EventArgs) Handles Button_REFRESH.Click



        Me.TXT_DIR_CLIENTE.Text = ""
        Me.TXT_TELS_CLIENTE.Text = ""
        Me.TxtMAIL_cliente.Text = ""
        Me.TXT_DOC_CLIENTE.Text = ""
        Me.Textbox_DV.Text = ""

        Me.TXT_NOM_CLIENTE.Text = ""
        cli_dir = ""
        cli_tel = ""
        cli_mail = ""
        cli_doc = ""
        cli_nom = ""



        'cli_doc = "1"
        Timer_clientes.Enabled = True


        Button_SAVE_CLI.Visible = False
        Button_EDIT_CLI.Visible = False
        Button_NUEVO_CLI.Visible = True

        Label_info_PROVEEDOR.Visible = False

        TextBox_BUSCAR_PROV.Visible = True
        COMBO_NOM_CLIENTE_FILTRO.Visible = True
        QUE_HACE_CLIENTE = ""
    End Sub

    Private Sub Timer_clientes_Tick(sender As Object, e As EventArgs) Handles Timer_clientes.Tick


        Timer_clientes.Enabled = False

        cli_doc = COMBO_NOM_CLIENTE_FILTRO.SelectedValue


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
                imp_clienteDoc = cli_nom
                imp_clienteTel = cli_tel
                ImpClienteDir = cli_dir
                imp_clientemail = cli_mail
            Next

            Me.TXT_DIR_CLIENTE.Text = cli_dir
            Me.TXT_TELS_CLIENTE.Text = cli_tel
            Me.TxtMAIL_cliente.Text = cli_mail
            Me.TXT_DOC_CLIENTE.Text = cli_doc
            Me.TXT_NOM_CLIENTE.Text = cli_nom

            If TXT_DOC_CLIENTE.Text = "1" Or TXT_DOC_CLIENTE.Text = "" Then
                Button_EDIT_CLI.Visible = False
            Else
                Button_EDIT_CLI.Visible = True
            End If

        Catch ex As Exception
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()

        TextBox_BUSCAR_PROV.Text = ""
        COMBO_NOM_CLIENTE_FILTRO.Text = ""
    End Sub

    Private Sub Button_NUEVO_CLI_Click(sender As Object, e As EventArgs) Handles Button_NUEVO_CLI.Click

        Label_info_PROVEEDOR.Visible = True
        Label_info_PROVEEDOR.Text = "Registre los Datos del Proveedor"

        Me.TXT_DIR_CLIENTE.BackColor = Color.WhiteSmoke
        Me.TXT_TELS_CLIENTE.BackColor = Color.WhiteSmoke
        Me.TxtMAIL_cliente.BackColor = Color.WhiteSmoke
        Me.TXT_DOC_CLIENTE.BackColor = Color.WhiteSmoke
        Me.TXT_NOM_CLIENTE.BackColor = Color.WhiteSmoke

        Me.TXT_DIR_CLIENTE.Text = ""
        Me.TXT_TELS_CLIENTE.Text = ""
        Me.TxtMAIL_cliente.Text = ""
        Me.TXT_DOC_CLIENTE.Text = ""
        Me.TXT_NOM_CLIENTE.Text = ""
        cli_dir = ""
        cli_tel = ""
        cli_mail = ""
        cli_doc = ""
        cli_nom = ""
        TextBox_BUSCAR_PROV.Visible = False
        COMBO_NOM_CLIENTE_FILTRO.Visible = False

        Me.Button_SAVE_CLI.Visible = True
        Me.Button_EDIT_CLI.Visible = False
        Me.Button_NUEVO_CLI.Visible = False

        Me.TXT_DOC_CLIENTE.Focus()
        QUE_HACE_CLIENTE = "crear"
    End Sub

    Private Sub Button_EDIT_CLI_Click(sender As Object, e As EventArgs) Handles Button_EDIT_CLI.Click
        If TXT_DOC_CLIENTE.Text = "1" Then
            Exit Sub
        End If

        Label_info_PROVEEDOR.Visible = True
        Label_info_PROVEEDOR.Text = "Registre los Datos del Cliente"

        Me.TXT_DIR_CLIENTE.BackColor = Color.WhiteSmoke
        Me.TXT_TELS_CLIENTE.BackColor = Color.WhiteSmoke
        Me.TxtMAIL_cliente.BackColor = Color.WhiteSmoke
        Me.TXT_DOC_CLIENTE.BackColor = Color.WhiteSmoke
        'Me.TXT_NOM_CLIENTE.BackColor = Color.WhiteSmoke   NO VA POR QUE ESTA EDITANDO

        TextBox_BUSCAR_PROV.Visible = False
        COMBO_NOM_CLIENTE_FILTRO.Visible = False

        QUE_HACE_CLIENTE = "editar"

        Button_NUEVO_CLI.Visible = False
        Button_EDIT_CLI.Visible = False
        Button_SAVE_CLI.Visible = True
    End Sub

    Private Sub Button_SAVE_CLI_Click(sender As Object, e As EventArgs) Handles Button_SAVE_CLI.Click
        Label_info_PROVEEDOR.Visible = False

        If TXT_DOC_CLIENTE.Text = "" Then Exit Sub
        If TXT_NOM_CLIENTE.Text = "" Then Exit Sub


        If QUE_HACE_CLIENTE = "crear" Then
            Dim RTA As String
            RTA = MsgBox("Confirma Guardar el Cliente?." _
                & Chr(13) & Chr(13) & "Cliente:" & Me.TXT_NOM_CLIENTE.Text & Chr(13) &
                "Documento:" & Me.TXT_DOC_CLIENTE.Text & "-" & Textbox_DV.Text & Chr(13) &
                "Teléfono:" & Me.TXT_TELS_CLIENTE.Text & Chr(13) &
                "Direccion:" & Me.TXT_DIR_CLIENTE.Text & Chr(13) &
                "Email:" & Me.TxtMAIL_cliente.Text, MsgBoxStyle.Question + MsgBoxStyle.YesNo)
            If RTA = 6 Then
                ' se guarda
                Dim DOC As String = "", dv As String = "", TIPODOC As String = "", ES_cliente As String = ""
                DOC = TXT_DOC_CLIENTE.Text
                dv = ""
                TIPODOC = "Cédula de Ciudadanía"
                ES_cliente = "SI"

                sql = "INSERT INTO proveedores(documento, dv, TIPODOCUMENTO, nombre, telefono, direccion, email, cliente, proveedor)" &
                      "VALUES ('" & DOC & "','" & Textbox_DV.Text & "','" & CStr(TIPODOC) & "','" & CStr(Me.TXT_NOM_CLIENTE.Text) & "','" & CStr(Me.TXT_TELS_CLIENTE.Text) & "','" & CStr(Me.TXT_DIR_CLIENTE.Text) & "','" & CStr(Me.TxtMAIL_cliente.Text) & "','" & ES_cliente & "','SI')"
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
                Label_info_PROVEEDOR.Text = "Se Guardó el Cliente."

            End If
        End If







        If QUE_HACE_CLIENTE = "editar" Then
            Dim RTA2 As String
            RTA2 = MsgBox("Confirma Modificar los datos del Cliente?." _
                    & Chr(13) & Chr(13) & "Cliente:" & Me.TXT_NOM_CLIENTE.Text & Chr(13) &
                    "Documento:" & Me.TXT_DOC_CLIENTE.Text & Chr(13) &
                    "Teléfono:" & Me.TXT_TELS_CLIENTE.Text & Chr(13) &
                    "Direccion:" & Me.TXT_DIR_CLIENTE.Text & Chr(13) &
                    "Email:" & Me.TxtMAIL_cliente.Text, MsgBoxStyle.Question + MsgBoxStyle.YesNo)
            If RTA2 = 6 Then
                ' se guarda
                Dim DOC As String = "", dv As String = "", TIPODOC As String = "", ES_cliente As String = ""
                DOC = TXT_DOC_CLIENTE.Text
                dv = ""
                TIPODOC = "Cédula de Ciudadanía"
                ES_cliente = "SI"

                sql = "update proveedores set documento='" & TXT_DOC_CLIENTE.Text & "', dv='" & Textbox_DV.Text & "', nombre='" & CStr(Me.TXT_NOM_CLIENTE.Text) & "', telefono='" & CStr(Me.TXT_TELS_CLIENTE.Text) & "', direccion='" & CStr(Me.TXT_DIR_CLIENTE.Text) & "', email='" & CStr(Me.TxtMAIL_cliente.Text) & "', cliente='" & ES_cliente & "', PROVEEDOR='SI' WHERE DOCUMENTO='" & TXT_DOC_CLIENTE.Text & "'"
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
                Label_info_PROVEEDOR.Text = "Se Guradó el Cliente."
            End If
        End If


        Button_SAVE_CLI.Visible = False
        Button_EDIT_CLI.Visible = True
        Button_NUEVO_CLI.Visible = True

        Me.TXT_DIR_CLIENTE.BackColor = Color.White
        Me.TXT_TELS_CLIENTE.BackColor = Color.White
        Me.TXT_DOC_CLIENTE.BackColor = Color.White
        Me.TXT_NOM_CLIENTE.BackColor = Color.White

        COMBO_NOM_CLIENTE_FILTRO.Visible = True

        QUE_HACE_CLIENTE = ""

        COMBO_NOM_CLIENTE_FILTRO.SelectedItem = cli_doc



    End Sub







    Private Sub TXT_DOC_CLIENTE_TextChanged_1(sender As Object, e As EventArgs) Handles TXT_DOC_CLIENTE.TextChanged

    End Sub

    Private Sub Textbox_DV_TextChanged_1(sender As Object, e As EventArgs) Handles Textbox_DV.TextChanged

    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub


    Private Sub TextBox_BUSCAR_PROV_TextChanged(sender As Object, e As EventArgs) Handles TextBox_BUSCAR_PROV.TextChanged

    End Sub

    Private Sub RadioButton_NIT_PROV_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_NIT_PROV.CheckedChanged
        TextBox_BUSCAR_PROV.Focus()

    End Sub

    Private Sub ComboBox_periodo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_periodo.SelectedIndexChanged

    End Sub

    Private Sub RadioButton_NOM_PROV_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_NOM_PROV.CheckedChanged
        TextBox_BUSCAR_PROV.Focus()

    End Sub

    Private Sub ComboBox_filtroprov_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_filtroprov.SelectedIndexChanged

    End Sub

    Private Sub datos_del_producto()
        Try
            sql = "SELECT * FROM productos where cod=" & CInt(Me.combobox_BuscarProd.SelectedValue) & ""
            da = New MySqlDataAdapter(sql, conex)
            dt_saldos = New DataTable
            da.Fill(dt_saldos)
            For Each row As DataRow In dt_saldos.Rows
                Me.TextBox_buscar_barras.Text = row.Item("codbarras")
                prod_barras = row.Item("codbarras")
                prod_cod = row.Item("cod")
                Label58.Text = row.Item("cod")

                prod_nom = row.Item("nombre")

                Label56.Text = row.Item("nombre")

                prod_desc = row.Item("descripcion")
                prod_iva = row.Item("iva")
                prod_iva2 = row.Item("iva2")
                PROD_IVATIPO = row.Item("ivaTIPO")
                PROD_IVATIPO2 = row.Item("ivaTIPO2")
                prod_iva1nom = row.Item("impnom1")
                prod_iva2nom = row.Item("impnom2")

                PROD_COSTO = row.Item("COSTO")

                prod_stock = row.Item("stock")
                PROD_INVENTARIADO = row.Item("inventariado")

                Label_sugeridomax.Text = row.Item("stock") & "/" & row.Item("sugerido") & "/" & row.Item("maximo")
                PROD_CATEGORIA = row.Item("CATEGORIA")
                prod_imagen = row.Item("imagen")
                prod_decimal = row.Item("DECIMALES")

            Next
            saldo = entran - salen
        Catch ex As Exception
            saldo = 0
        End Try
        da.Dispose()
        conex.Close()

        If comex_listaprecios2 = "Precio 1" Then PROD_COSTO = PROD_COSTO
        If comex_listaprecios2 = "Precio 2" Then PROD_COSTO = PROD_COSTO
        If comex_listaprecios2 = "Precio 3" Then PROD_COSTO = PROD_COSTO

        'Me.TextBox_buscar_cod.Text = prod_cod
        'Me.combobox_BuscarProd.SelectedItem = prod_nom
        'Me.TextBox_buscar_barras.Text = prod_barras
        If prod_decimal = "SI" Then NumericUpDown_CANT.DecimalPlaces = 3 Else NumericUpDown_CANT.DecimalPlaces = 0


        'prod costo para MOSTRAR en el text antes de agregar el producto
        'If comex_costo = "PROMEDIO" Then

        '    Try
        '        sql = "Select avg(valoru) As promedio FROM compras_prods where CodProd=" & CInt(prod_cod) & " And estado='DESCARGADO'"
        '        da = New MySqlDataAdapter(sql, conex)
        '        dt = New DataTable
        '        da.Fill(dt)
        '        For Each row As DataRow In dt.Rows
        '            PROD_COSTO = CInt(row.Item("promedio"))
        '        Next
        '    Catch ex As Exception
        '    End Try

        'End If


        'Me.TextBox_valorunitario.Text = PROD_COSTO
    End Sub
    Private Sub datos_del_producto_BARRAS()
        Try
            sql = "SELECT * FROM productos where codBARRAS='" & CInt(Me.TextBox_buscar_barras.Text) & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt_saldos = New DataTable
            da.Fill(dt_saldos)
            For Each row As DataRow In dt_saldos.Rows
                Me.TextBox_buscar_barras.Text = row.Item("codbarras")
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

                prod_valor = row.Item("COSTO")


                prod_stock = row.Item("stock")
                PROD_INVENTARIADO = row.Item("inventariado")

                PROD_CATEGORIA = row.Item("CATEGORIA")
                prod_imagen = row.Item("imagen")

            Next
            saldo = entran - salen
        Catch ex As Exception
            saldo = 0
        End Try
        da.Dispose()
        conex.Close()
        Me.combobox_BuscarProd.Text = prod_nom
        Me.TextBox_buscar_barras.Text = prod_barras
        Me.TextBox_valorunitario.Text = PROD_COSTO
    End Sub

    Private Sub Button_modificar_prods_Click(sender As Object, e As EventArgs) Handles Button_modificar_prods.Click

        If prod_cons = "" Then

            MsgBox("Selecione un producto para modificar.", vbInformation)
            Exit Sub

        End If


        'loads_productos("codigo", Label58.Text)
        'combobox_BuscarProd.SelectedValue = TextBox_buscar_cod.Text

        'combobox_BuscarProd.Focus()




        If NumericUpDown_CANT.Value = 0 Then MsgBox("Falta la Cantidad.") : Exit Sub
        If Me.TextBox_valorunitario.Text = 0 Then MsgBox("Falta el valor unitario.") : Exit Sub

        PROD_VALOR_UNITARIO_BASE = 0
        If prod_decimal = "SI" Then PROD_VALOR_UNITARIO_BASE = CDec(TextBox_valorunitario.Text)
        If prod_decimal = "NO" Then PROD_VALOR_UNITARIO_BASE = CInt(TextBox_valorunitario.Text)

        If prod_iva2nom <> "NO" Then  'CALCULAMOS EL IVA
            PROD_VALOR_UNITARIO_BASE = CInt(PROD_VALOR_UNITARIO_BASE / ((CInt(prod_iva2) / 100) + 1))
            PROD_IVA_VR2 = CInt(TextBox_valorunitario.Text) - CInt(PROD_VALOR_UNITARIO_BASE)
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


        If prod_iva2nom <> "NO" Then  'CALCULAMOS EL IVA
            PROD_COSTO = PROD_VALOR_UNITARIO_BASE

        End If

        ' costo ----------------------

        'prod costo para guardar en eel pedido
        If comex_costo = "RETAIL" Or comex_costo = "" Then PROD_COSTO = TextBox_valorunitario.Text

        If comex_costo <> "RETAIL" Then
            ' SI ES REATIL SE USA EL DEL ESTANDARD DEL PRODUCTO
            ' SI ES CERO SE USA ELESTARDAR DEL RPODUCTO 
            Try
                If comex_costo = "PROMEDIO" Then sql = "SELECT IFNULL(AVG(VALORU),0) as promedio FROM BODEGA_PRINCIPAL where codproducto='" & CInt(prod_cod) & "' AND TIPODOCUMENTO IN('Entrada de Mercancia','Inventario Inicial','COMPRA') and estado='DESCARGADO'"
                If comex_costo = "MAXIMO" Then sql = "SELECT IFNULL(MAX(VALORU),O) FROM BODEGA_PRINCIPAL where codproducto='" & CInt(prod_cod) & "' AND TIPODOCUMENTO IN('Entrada de Mercancia','Inventario Inicial','COMPRA') and estado='DESCARGADO'"
                If comex_costo = "ULTIMO" Then sql = "SELECT MAX(CONS), IFNULL(VALORU,0) FROM BODEGA_PRINCIPAL where codproducto='" & CInt(prod_cod) & "' AND TIPODOCUMENTO IN('Entrada de Mercancia','Inventario Inicial','COMPRA') and estado='DESCARGADO'"

                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                da.Fill(dt)
                For Each row As DataRow In dt.Rows
                    If CInt(row.Item("promedio")) <> 0 Then
                        PROD_COSTO = CInt(row.Item("promedio"))
                    End If
                Next
                PROD_COSTO = CInt(PROD_COSTO) + CInt(TextBox_valorunitario.Text) / 2
            Catch ex As Exception

            End Try

            da.Dispose()
            dt.Dispose()
            conex.Close()
        End If


        Dim RTA As String = ""

        RTA = MsgBox("Confirma Cambiar los datos del producto. ", MsgBoxStyle.Question + MsgBoxStyle.YesNo)

        If RTA = 6 Then

            sql = "UPDATE pedidosprov_prods set 
        cantidad='" & CStr(NumericUpDown_CANT.Value) & "', 
        base='" & PROD_VALOR_UNITARIO_BASE & "', 
        imp='" & CStr(PROD_IVA_VR) & "', 
        IMP2='" & CStr(PROD_IVA_VR2) & "', 
        impuesto='" & Math.Round((CDec(PROD_IVA_VR) * CDec(NumericUpDown_CANT.Value)), 0) & "', 
        IMPUESTO2='" & Math.Round((CDec(PROD_IVA_VR2) * CDec(NumericUpDown_CANT.Value)), 0) & "', 
        valoru='" & CStr(Math.Round(CDec(TextBox_valorunitario.Text), 3)) & "', 
        valortotal='" & CStr(Math.Round(CDec(TextBox_Total.Text), 3)) & "', 
        IMPNOM1='" & prod_iva1nom & "', 
        IMPNOM2='" & prod_iva2nom & "', 
        deci='" & prod_decimal & "', 
        COSTO='" & PROD_COSTO & "', 
        lote='" & TextBox_lote.Text & "', 
        vence='" & TextBox_vencimiento.Text & "' where cons='" & prod_cons & "'"

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

            Timer_gridProds.Enabled = True

            prod_cons = ""
            prod_nom = ""
            prod_cod = ""

            NumericUpDown_CANT.Value = 0

        End If

    End Sub

    Private Sub RadioButton_pendiente_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Timer_PROD_DATA_BARRAS.Enabled = True

        End If
    End Sub

    Private Sub RadioButton_facturado_KeyDown(sender As Object, e As KeyEventArgs)
        Me.TextBox_Total.Text = CInt(Me.NumericUpDown_CANT.Value) * CInt(TextBox_valorunitario.Text)

    End Sub

    Private Sub datagrid_productos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_productos.CellClick

        Dim row_prod As DataGridViewRow = datagrid_productos.CurrentRow
        prod_cons = CStr(row_prod.Cells("cons").Value) ' LLAVE PRINCIPAL


    End Sub




    Private Sub BUSCA_SALDO_PRODUCTO_aqui()
        Me.Cursor = Cursors.WaitCursor
        'saldo
        entran = 0
        salen = 0
        saldo = 0
        Try
            sql = "SELECT sum(cantidad) as cant FROM pedidosprov_prods where CodProd='" & CInt(prod_cod) & "'"
            da_SALDOS = New MySqlDataAdapter(sql, conex)
            dt_saldos = New DataTable
            da_SALDOS.Fill(dt_saldos)
            For Each row As DataRow In dt_saldos.Rows
                saldo = row.Item("cant")
            Next
        Catch ex As Exception
            saldo = 0
        End Try

        da_SALDOS.Dispose()
        dt_saldos.Dispose()
        conex.Close()

        SALDO_DEL_PRODUCTO_aqui = saldo + NumericUpDown_CANT.Value

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BUSCA_SALDO_PRODUCTO()
        'saldo
        entran = 0
        salen = 0
        saldo = 0
        Label_saldo_lote.Text = 0
        Label_saldo_actual.Text = 0
        Try
            sql = "SELECT sum(entran) - sum(salen) as saldo FROM bodega_" & comex_bodega_compras & " where CodProducto=" & CInt(prod_cod) & ""

            da = New MySqlDataAdapter(sql, conex)
            dt_saldos = New DataTable
            da.Fill(dt_saldos)
            For Each row As DataRow In dt_saldos.Rows
                saldo = row.Item("saldo")
            Next
        Catch ex As Exception
            saldo = 0
        End Try
        da.Dispose()
        dt_saldos.Dispose()
        conex.Close()

        SALDO_DEL_PRODUCTO = saldo

        Label_saldo_actual.Text = SALDO_DEL_PRODUCTO


    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_buscar_cod.KeyDown
        If e.KeyCode = Keys.Enter Then
            loads_productos("codigo", TextBox_buscar_cod.Text)

            Me.combobox_BuscarProd.SelectedValue = Me.TextBox_buscar_cod.Text

            Timer_prod_data_cod.Enabled = True
            combobox_BuscarProd.DroppedDown = True
        End If
    End Sub

    Private Sub TextBox_Total_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_Total.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub TextBox_BARRAS_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_buscar_barras.KeyDown


        If e.KeyCode = Keys.Enter Then
            loads_productos("barras", TextBox_buscar_barras.Text)

            Timer_PROD_DATA_BARRAS.Enabled = True

            combobox_BuscarProd.Focus()

        End If




    End Sub

    Private Sub CheckBox_reteica_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_reteica.CheckedChanged
        If CheckBox_reteica.Checked = True Then
            NumericUpDown_reteICA.Enabled = True
            TextBox_reteica.Enabled = True

            NumericUpDown_reteICA_ValueChanged(Nothing, Nothing)

        End If



        'If CheckBox_reteica.Checked = False Then
        '    NumericUpDown_reteICA.Enabled = False
        '    TextBox_reteica.Enabled = False
        '    TextBox_retefuente.Text = 0

        '    TextBox_retenciones.Text = CInt(TextBox_retefuente.Text) + CInt(TextBox_reteica.Text) + CInt(TextBox_reteiva.Text)

        'End If
    End Sub

    Private Sub CheckBox_reteIVA_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_reteIVA.CheckedChanged
        If CheckBox_reteIVA.Checked = True Then
            NumericUpDown_reteiva.Enabled = True
            TextBox_reteiva.Enabled = True
            NumericUpDown_reteiva_ValueChanged(Nothing, Nothing)

        End If



        If CheckBox_reteIVA.Checked = False Then
            NumericUpDown_reteiva.Enabled = False
            TextBox_reteiva.Enabled = False

            TextBox_retefuente.Text = 0

            TextBox_retenciones.Text = CInt(TextBox_retefuente.Text) + CInt(TextBox_reteica.Text) + CInt(TextBox_reteiva.Text)

        End If
    End Sub

    Private Sub TextBox_valorunitario_ValueChanged(sender As Object, e As EventArgs) Handles TextBox_valorunitario.ValueChanged


    End Sub

    Private Sub NumericUpDown_retefuente_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_retefuente.ValueChanged
        If CheckBox_retefuente.Checked = True Then

            TextBox_retefuente.Text = CInt(CInt(TextBoxbaseimp.Text) * NumericUpDown_retefuente.Value / 100)
            TextBox_retenciones.Text = CInt(TextBox_retefuente.Text) + CInt(TextBox_reteica.Text) + CInt(TextBox_reteiva.Text)
        End If
    End Sub

    Private Sub NumericUpDown_reteICA_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_reteICA.ValueChanged
        If CheckBox_reteica.Checked = True Then  '  el ICA SE DIVIDE POR 1000
            TextBox_reteica.Text = CInt(TextBoxbaseimp.Text) * NumericUpDown_reteICA.Value / 1000
            TextBox_retenciones.Text = CInt(TextBox_retefuente.Text) + CInt(TextBox_reteica.Text) + CInt(TextBox_reteiva.Text)

        End If
    End Sub

    Private Sub NumericUpDown_CANT_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_CANT.ValueChanged

    End Sub

    Private Sub Label58_Click(sender As Object, e As EventArgs) Handles Label58.Click

    End Sub

    Private Sub Label53_Click(sender As Object, e As EventArgs) Handles Label53.Click

    End Sub

    Private Sub Label_saldo_actual_Click(sender As Object, e As EventArgs) Handles Label_saldo_actual.Click

    End Sub

    Private Sub Label55_Click(sender As Object, e As EventArgs) Handles Label55.Click

    End Sub

    Private Sub Label_saldo_lote_Click(sender As Object, e As EventArgs) Handles Label_saldo_lote.Click

    End Sub

    Private Sub Label56_Click(sender As Object, e As EventArgs) Handles Label56.Click

    End Sub

    Private Sub ComboBox_MedioPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_MedioPago.SelectedIndexChanged

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub TextBox_dcto_TextChanged(sender As Object, e As EventArgs) Handles TextBox_dcto.TextChanged

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub NumericUpDown_reteiva_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_reteiva.ValueChanged
        If CheckBox_reteIVA.Checked = True Then
            TextBox_reteiva.Text = CInt(TextBoximp.Text) * NumericUpDown_reteiva.Value / 100
            TextBox_retenciones.Text = CInt(TextBox_retefuente.Text) + CInt(TextBox_reteica.Text) + CInt(TextBox_reteiva.Text)
        End If
    End Sub

    Private Sub FormPedidodeClientes_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Private Sub Panel17_Click(sender As Object, e As EventArgs) Handles Panel17.Click
        If Me.Panel_impuestos.Visible = True Then Me.Panel_impuestos.Visible = False : Me.Panel_prods.Visible = True
        If Me.Panel_impuestos.Visible = False Then Me.Panel_impuestos.Visible = True : Me.Panel_prods.Visible = False
    End Sub

    Private Sub TextBox_retefuente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_retenciones.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub Combobox_impuestos_SelectionChangeCommitted(sender As Object, e As EventArgs)
        Timer_impuesto.Enabled = True

    End Sub

    Private Sub Ingresar_a_Bodega()
        Try
            For J As Integer = 0 To Me.datagrid_productos.RowCount - 1
                prod_decimal = datagrid_productos.Item("DECI", J).Value

                Dim saldo As String = 0


                PROD_ENTRAN = Me.datagrid_productos.Item("cantidad", J).Value  ' TOMO LA CANTIDAD DEL GRID Q ESTA RECORRIENDO
                PROD_SALDO = saldo  ' IGUALDO SALDO PROD CON EL SALDO CALCULADO EN BODEGA PRICIPAL

                If prod_decimal = "NO" Then PROD_SALDO = CInt(PROD_SALDO) + CInt(PROD_ENTRAN)   '  ACUMULO
                If prod_decimal = "SI" Then PROD_SALDO = CDec(PROD_SALDO) + CDec(PROD_ENTRAN)   '  ACUMULO
                PROD_SALEN = 0 ' POR QUE QUE ES UNA COMPRA
                Dim rol As String = ""
                rol = "ENTRAN"

                sql = "INSERT INTO bodega_" & comex_bodega_compras & " (fecha, CodBodega, NomBodega, TipoDocumento, Documento, tercero, Rol, CodProducto, Producto, saldoant, Entran, Salen, Saldo, valoru, valortotal, Empleado, Estado, deci, costo, LOTE, VENCE)" &
                            " VALUES ('" & DateTime.Now.ToShortDateString & "',1,'" & comex_bodega_compras & "','COMPRA'," & CInt(Me.Label_consecutivo.Text) & ",'" & CStr(TXT_DOC_CLIENTE.Text & "|" & TXT_NOM_CLIENTE.Text) & "','ENTRAN'," & CInt(Me.datagrid_productos.Item("CODPROD", J).Value) & ",'" & CStr(Me.datagrid_productos.Item("PRODUCTO", J).Value) & "','" & saldo & "','" & PROD_ENTRAN & "','" & PROD_SALEN & "','" & PROD_SALDO & "','" & Me.datagrid_productos.Item("valoru", J).Value & "','" & Me.datagrid_productos.Item("valortotal", J).Value & "','" & usrnom & "','DESCARGADO','" & prod_decimal & "','" & Me.datagrid_productos.Item("valoru", J).Value & "','" & Me.datagrid_productos.Item("LOTE", J).Value & "','" & Me.datagrid_productos.Item("VENCE", J).Value & "')"
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



                'costo     ===========
                'Try
                '    If comex_costo = "PROMEDIO" Then sql = "SELECT IFNULL(AVG(VALORU),0) as promedio FROM BODEGA_" & comex_bodega_ventas & " where codproducto='" & CInt(prod_cod) & "' AND TIPODOCUMENTO IN('Entrada de Mercancia','Inventario Inicial','COMPRA') and estado='DESCARGADO'"

                '    da = New MySqlDataAdapter(sql, conex)
                '    dt = New DataTable
                '    da.Fill(dt)
                '    For Each row As DataRow In dt.Rows
                '        PROD_COSTO = CInt(row.Item("promedio"))
                '    Next
                'Catch ex As Exception
                'End Try

                'da.Dispose()
                'dt.Dispose()
                'conex.Close()
                'costo================


            Next

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try


    End Sub

    Private Sub combobox_BuscarProd_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles combobox_BuscarProd.SelectionChangeCommitted
        Me.Timer_prod_data.Enabled = True

    End Sub

    Private Sub combobox_BuscarProd_SelectedValueChanged(sender As Object, e As EventArgs) Handles combobox_BuscarProd.SelectedValueChanged

    End Sub

    Private Sub Combobox_impuestos_SizeChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox_dcto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_dcto.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""

    End Sub

    Private Sub TextBox_subtotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_subtotal.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub TextBox_dcto_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_dcto.KeyDown

    End Sub



    Private Sub ComboBox_MEDIO_PAGO_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_CuentaPago.SelectionChangeCommitted

        MEDIO_PAGO_DESTINO_COD = ComboBox_CuentaPago.SelectedValue
        MEDIO_PAGO_DESTINO_NOMBRE = ComboBox_CuentaPago.Text

        MEDIO_PAGO_DESTINO_FULL = Split(MEDIO_PAGO_DESTINO_COD, "|")

    End Sub

    Private Sub ComboBox_MEDIO_PAGO_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox_CuentaPago.SelectedValueChanged

    End Sub



    Private Sub TextBox_vencimiento_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_vencimiento.KeyDown
        If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete Then
            TextBox_vencimiento.Text = ""
        End If
    End Sub

    Private Sub TextBox_vencimiento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_vencimiento.KeyPress
        e.KeyChar = ""

    End Sub




    Private Sub Txt_DV_CLIENTE_KeyDown(sender As Object, e As KeyEventArgs)
        'If e.KeyCode = Keys.Enter Then
        '    loads_productos("nombre")

        '    combobox_BuscarProd.Focus()

        'End If
    End Sub

    Private Sub TextBox_buscarprod_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_buscar_prod.KeyDown
        If e.KeyCode = Keys.Enter Then
            loads_productos("nombre", TextBox_buscar_prod.Text)

            combobox_BuscarProd.Focus()

        End If
    End Sub

    Private Sub combobox_BuscarProd_GotFocus(sender As Object, e As EventArgs) Handles combobox_BuscarProd.GotFocus
        combobox_BuscarProd.DroppedDown = True
        Cursor.Current = Cursors.Default
    End Sub



    Private Sub COMBO_NOM_CLIENTE_FILTRO_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles COMBO_NOM_CLIENTE_FILTRO.SelectionChangeCommitted
        Timer_clientes.Enabled = True

    End Sub




    Private Sub COMBO_NOM_CLIENTE_FILTRO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles COMBO_NOM_CLIENTE_FILTRO.KeyPress
        If COMBO_NOM_CLIENTE_FILTRO.Text = "" Then
            TXT_NOM_CLIENTE.Text = ""
            TXT_DOC_CLIENTE.Text = ""
            TXT_TELS_CLIENTE.Text = ""
            TXT_DIR_CLIENTE.Text = ""
        End If
    End Sub

    Private Sub COMBO_NOM_CLIENTE_FILTRO_KeyDown(sender As Object, e As KeyEventArgs) Handles COMBO_NOM_CLIENTE_FILTRO.KeyDown
        If e.KeyCode = "13" Then
            Timer_clientes.Enabled = True
        End If
    End Sub




    Private Sub TextBox_BUSCAR_PROV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_BUSCAR_PROV.KeyPress
        If TextBox_BUSCAR_PROV.Text = "" Then
            TXT_NOM_CLIENTE.Text = ""
            TXT_DOC_CLIENTE.Text = ""
            TXT_TELS_CLIENTE.Text = ""
            TXT_DIR_CLIENTE.Text = ""
        End If

        If RadioButton_NIT_PROV.Checked = True Then
            If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""
        End If
    End Sub

    Private Sub TextBox_BUSCAR_PROV_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_BUSCAR_PROV.KeyDown
        If e.KeyCode = "13" Then

            If TextBox_BUSCAR_PROV.Text = "" And RadioButton_NIT_PROV.Checked = True Then
                Label_info_PROVEEDOR.Visible = True
                Label_info_PROVEEDOR.Text = "debe escribir un número de nit."
                Exit Sub
            End If


            ''LLENADO contactos
            Try
                If RadioButton_NIT_PROV.Checked = True Then sql = "SELECT documento, dv, nombre FROM proveedores WHERE PROVEEDOR='SI' and documento='" & TextBox_BUSCAR_PROV.Text & "'"
                If RadioButton_NOM_PROV.Checked = True Then sql = "SELECT documento, dv, nombre FROM proveedores WHERE PROVEEDOR='SI' and nombre like '%" & TextBox_BUSCAR_PROV.Text & "%'"

                da_contact_venta = New MySqlDataAdapter(sql, conex)
                dt_contact_venta = New DataTable
                da_contact_venta.Fill(dt_contact_venta)
                Me.COMBO_NOM_CLIENTE_FILTRO.DataSource = dt_contact_venta.DefaultView
                Me.COMBO_NOM_CLIENTE_FILTRO.DisplayMember = "nombre"
                Me.COMBO_NOM_CLIENTE_FILTRO.ValueMember = "documento"
                Me.COMBO_NOM_CLIENTE_FILTRO.AutoCompleteSource = AutoCompleteSource.ListItems
                Me.COMBO_NOM_CLIENTE_FILTRO.AutoCompleteMode = AutoCompleteMode.Suggest
                Me.COMBO_NOM_CLIENTE_FILTRO.SelectedItem = Nothing
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da_contact_venta.Dispose()
            dt_contact_venta.Dispose()
            conex.Close()

            COMBO_NOM_CLIENTE_FILTRO.Focus()

        End If
    End Sub

    Private Sub Textbox_DV_GotFocus(sender As Object, e As EventArgs) Handles Textbox_DV.GotFocus
        If TXT_DOC_CLIENTE.Text <> "" Then

            Dim NIT As String = TXT_DOC_CLIENTE.Text
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
            Textbox_DV.Text = RESIDUO

            If RESIDUO > 1 Then
                Textbox_DV.Text = Convert.ToString(11 - RESIDUO)
            End If
        End If
    End Sub

    Private Sub TextBox_BUSCAR_PROV_GotFocus(sender As Object, e As EventArgs) Handles TextBox_BUSCAR_PROV.GotFocus

    End Sub

    Private Sub ComboBox_periodo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_periodo.SelectionChangeCommitted
        mes_num = DateTime.ParseExact(Me.ComboBox_periodo.Text, "MMMM", CultureInfo.CurrentCulture).Month
        mes_num_text = CStr(mes_num)
        If mes_num <= 9 Then mes_num_text = "0" & CStr(mes_num)


        load_grid_PEDIDOS_provs()

    End Sub

    Private Sub ComboBox_filtroprov_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_filtroprov.SelectionChangeCommitted


        load_grid_PEDIDOS_provs()

    End Sub

    Private Sub COMBO_NOM_CLIENTE_FILTRO_GotFocus(sender As Object, e As EventArgs) Handles COMBO_NOM_CLIENTE_FILTRO.GotFocus

        COMBO_NOM_CLIENTE_FILTRO.DroppedDown = True

        Cursor.Current = Cursors.Default

    End Sub

    Private Sub datagrid_productos_SelectionChanged(sender As Object, e As EventArgs) Handles datagrid_productos.SelectionChanged
        Label_sugeridomax.Text = ""
        Label_saldo_actual.Text = ""
        Label_saldo_lote.Text = ""
        Label58.Text = ""
        Label56.Text = ""

        TextBox_buscar_cod.Text = ""
        TextBox_buscar_barras.Text = ""
        TextBox_buscar_prod.Text = ""

        combobox_BuscarProd.DataSource = Nothing

        TextBox_valorunitario.Text = "0"

        TextBox_Total.Text = "0"

        NumericUpDown_CANT.Value = 0
        Button_modificar_prods.Visible = False

    End Sub

    Private Sub datagrid_productos_CellBorderStyleChanged(sender As Object, e As EventArgs) Handles datagrid_productos.CellBorderStyleChanged

    End Sub

    Private Sub datagrid_productos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_productos.CellDoubleClick
        If datagrid_productos.RowCount = 0 Then Exit Sub

        Dim row_prod As DataGridViewRow = datagrid_productos.CurrentRow

        If Not IsDBNull(datagrid_productos.Item("cons", 0).Value) Then

            prod_cons = CStr(row_prod.Cells("cons").Value) ' LLAVE PRINCIPAL



            Label_sugeridomax.Text = "0/0/0"
            Label_saldo_actual.Text = "0"
            Label_saldo_lote.Text = "0"
            Label58.Text = ""
            Label56.Text = ""

            Label58.Text = row_prod.Cells("CODPROD").Value
            Label56.Text = row_prod.Cells("producto").Value


            'loads_productos("codigo", Label58.Text)
            'combobox_BuscarProd.SelectedValue = Label58.Text
            'Timer_prod_data.Enabled = True

            datos_del_producto()

            BUSCA_SALDO_PRODUCTO()


            TextBox_valorunitario.Text = row_prod.Cells("VALORU").Value ' LLAVE PRINCIPAL
            NumericUpDown_CANT.Value = row_prod.Cells("CANTIDAD").Value ' LLAVE PRINCIPAL
            TextBox_Total.Text = row_prod.Cells("VALORTOTAL").Value ' LLAVE PRINCIPAL


            Button_modificar_prods.Visible = True

        End If
    End Sub

    Private Sub NumericUpDown_CANT_GotFocus(sender As Object, e As EventArgs) Handles NumericUpDown_CANT.GotFocus
        NumericUpDown_CANT.BackColor = Color.MistyRose
    End Sub

    Private Sub NumericUpDown_CANT_LostFocus(sender As Object, e As EventArgs) Handles NumericUpDown_CANT.LostFocus
        NumericUpDown_CANT.BackColor = Color.White
        Me.TextBox_Total.Text = Math.Round((CDec(Me.NumericUpDown_CANT.Value) * CDec(TextBox_valorunitario.Text)), 2)

    End Sub




    Private Sub TextBox_valorunitario_GotFocus(sender As Object, e As EventArgs) Handles TextBox_valorunitario.GotFocus
        TextBox_valorunitario.BackColor = Color.MistyRose

    End Sub

    Private Sub TextBox_valorunitario_LostFocus(sender As Object, e As EventArgs) Handles TextBox_valorunitario.LostFocus
        TextBox_valorunitario.BackColor = Color.White
        Me.TextBox_Total.Text = Math.Round((CDec(Me.NumericUpDown_CANT.Value) * CDec(TextBox_valorunitario.Text)), 2)


    End Sub

    Private Sub TXT_DOC_CLIENTE_LostFocus(sender As Object, e As EventArgs) Handles TXT_DOC_CLIENTE.LostFocus
        If TXT_DOC_CLIENTE.Text <> "" Then

            Dim NIT As String = TXT_DOC_CLIENTE.Text
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
            Textbox_DV.Text = RESIDUO

            If RESIDUO > 1 Then
                Textbox_DV.Text = Convert.ToString(11 - RESIDUO)
            End If
        End If
    End Sub

    Private Sub ComboBox_MedioPago_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_MedioPago.SelectionChangeCommitted


        If ComboBox_MedioPago.Text <> "CREDITO COMPRA" Then
            ComboBox_CuentaPago.DataSource = Nothing
            ComboBox_CuentaPago.Text = ""
        End If



        Try

            sql = "SELECT CONS, nombre, cuentapuc FROM CAJAsYBANCOS where tipo='" & Me.ComboBox_MedioPago.SelectedValue.ToString & "'"
            da_CuentasPago = New MySqlDataAdapter(sql, conex)
            dt_CuentasPago = New DataTable
            da_CuentasPago.Fill(dt_CuentasPago)
            Me.ComboBox_CuentaPago.DataSource = dt_CuentasPago.DefaultView
            Me.ComboBox_CuentaPago.DisplayMember = "nombre"
            Me.ComboBox_CuentaPago.ValueMember = "cons"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_CuentasPago.Dispose()
        dt_CuentasPago.Dispose()
        conex.Close()




    End Sub
End Class