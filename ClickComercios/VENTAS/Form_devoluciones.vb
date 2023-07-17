Imports System.Environment
Imports System.Globalization
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Public Class Form_devoluciones
    Dim mes_num As Integer
    Dim mes_num_text As String
    Dim mes_num_text_general As String

    Dim cli_nom, cli_tel, cli_dir, cli_doc, cli_mail As String

    Dim medio_depago_dev As String = ""


    Dim TIENE_DEVOLUCION As String
    Dim filtro As String = "TODO"
    Dim CodDocumento As Long = 0
    Dim desktop2 As String = Environment.GetFolderPath(SpecialFolder.DesktopDirectory)
    Dim NRO_FACTURA As String = ""
    Dim PROD_SALDO, PROD_ENTRAN, PROD_SALEN As Integer
    Dim prod_cod, prod_barras, prod_nom, prod_desc, prod_valor, prod_valor2, prod_valor3, PROD_COSTO, prod_iva1nom, prod_iva2nom, PROD_VALOR_UNITARIO_BASE, prod_iva, prod_iva2, PROD_IVA_VR, PROD_IVA_VR2, PROD_IVATIPO, PROD_IVATIPO2, prod_base, prod_stock, prod_imagen, PROD_INVENTARIADO As String
    Dim PROD_DECIMAL As String = ""
    Dim SALDO_DEL_PRODUCTO As Integer = 0
    Dim entran, salen, saldo As Integer

    Dim medio_de_pago As String
    Dim MEDIO_PAGO_DESTINO_COD, MEDIO_PAGO_DESTINO_NOMBRE, MEDIO_PAGO_DESTINO_TIPO As String

    Public da_combo_facs_dcto As MySqlDataAdapter
    Public dt_combo_facs_dcto As DataTable

    Public da_contact_dev_ventas As MySqlDataAdapter
    Public dt_contact_dev_ventas As DataTable



    Private Sub Form_devoluciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datagrid_devoluciones.BringToFront()
        datagrid_devoluciones.Size = New Size(914, 521)

    End Sub

    Private Sub Form_devoluciones_Shown(sender As Object, e As EventArgs) Handles Me.Shown


        mes_num = DateTime.Now.Month()
        mes_num_text_general = CStr(mes_num)
        If mes_num <= 9 Then mes_num_text_general = "0" & CStr(mes_num)
        ComboBox_mes_general.SelectedIndex = mes_num_text_general - 1
        ComboBox_periodoFiltro.SelectedIndex = mes_num_text_general - 1



        Try
            sql = "SELECT CONS, nombre, cuentapuc FROM CAJAsYBANCOS where tipo in('CAJA','BANCO')"
            da_COMBO_cuentas_parapagos = New MySqlDataAdapter(sql, conex)
            dt_COMBO_cuentas_parapagos = New DataTable
            da_COMBO_cuentas_parapagos.Fill(dt_COMBO_cuentas_parapagos)
            Me.ComboBox_cta_caja_banco.DataSource = dt_COMBO_cuentas_parapagos.DefaultView
            'Me.ComboBox_cta_caja_banco.DisplayMember = "nombre"
            Me.ComboBox_cta_caja_banco.DisplayMember = "nombre"

            'Me.ComboBox_cta_caja_banco.ValueMember = "CONS"
            Me.ComboBox_cta_caja_banco.ValueMember = "cons"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




        load_grid_PEDIDOS_CLIENTES()



        If id_devolucion <> "" Then
            Me.Timer_ver.Enabled = True
            CodDocumento = id_devolucion

        End If
        id_devolucion = ""

        Timer_MEDIO_PAGO.Enabled = True

    End Sub


    Private Sub load_grid_PEDIDOS_CLIENTES()

        Try
            sql = "select * from devoluciones where month(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & mes_num_text_general & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.datagrid_devoluciones.DataSource = dt
            Me.datagrid_devoluciones.Columns(0).HeaderText = "Devolución"
            Me.datagrid_devoluciones.Columns(0).Width = 60
            Me.datagrid_devoluciones.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.datagrid_devoluciones.Columns(1).HeaderText = "Fecha"
            Me.datagrid_devoluciones.Columns(1).Width = 90
            Me.datagrid_devoluciones.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.datagrid_devoluciones.Columns(2).Visible = False
            Me.datagrid_devoluciones.Columns(3).Visible = False
            Me.datagrid_devoluciones.Columns(4).HeaderText = "Cliente"
            Me.datagrid_devoluciones.Columns(4).Width = 300
            Me.datagrid_devoluciones.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagrid_devoluciones.Columns(5).Visible = False
            Me.datagrid_devoluciones.Columns(6).Visible = False
            Me.datagrid_devoluciones.Columns(7).Visible = False
            Me.datagrid_devoluciones.Columns(8).HeaderText = "Estado"
            Me.datagrid_devoluciones.Columns(8).Width = 110
            Me.datagrid_devoluciones.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.datagrid_devoluciones.Columns(9).Visible = False
            Me.datagrid_devoluciones.Columns(10).Visible = False
            Me.datagrid_devoluciones.Columns(11).Visible = False
            Me.datagrid_devoluciones.Columns(12).Visible = False
            Me.datagrid_devoluciones.Columns(13).Visible = False
            Me.datagrid_devoluciones.Columns(14).Visible = False
            Me.datagrid_devoluciones.Columns(15).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        Me.datagrid_devoluciones.ClearSelection()

        Try
            For i As Integer = 0 To datagrid_devoluciones.RowCount - 1
                If datagrid_devoluciones.Item("estado", i).Value = "ANULADO" Then datagrid_devoluciones.Rows(i).DefaultCellStyle.ForeColor = Color.SteelBlue
                If datagrid_devoluciones.Item("estado", i).Value = "PENDIENTE" Then datagrid_devoluciones.Rows(i).DefaultCellStyle.ForeColor = Color.Yellow

            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        Me.datagrid_devoluciones.ClearSelection()
    End Sub

    Private Sub load_grid_PEDIDOS_CLIENTES_FILTRO(ByRef filtro_estado As String)
        Try
            sql = "select * from devoluciones where tipodev='" & tipo_devolucion & "' and estado='" & filtro_estado & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.datagrid_devoluciones.DataSource = dt
            Me.datagrid_devoluciones.Columns(0).HeaderText = "Pedido"
            Me.datagrid_devoluciones.Columns(0).Width = 60
            Me.datagrid_devoluciones.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.datagrid_devoluciones.Columns(1).HeaderText = "Fecha"
            Me.datagrid_devoluciones.Columns(1).Width = 90
            Me.datagrid_devoluciones.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.datagrid_devoluciones.Columns(2).Visible = False
            Me.datagrid_devoluciones.Columns(3).Visible = False
            Me.datagrid_devoluciones.Columns(4).HeaderText = "Cliente"
            Me.datagrid_devoluciones.Columns(4).Width = 300
            Me.datagrid_devoluciones.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagrid_devoluciones.Columns(5).Visible = False
            Me.datagrid_devoluciones.Columns(6).Visible = False
            Me.datagrid_devoluciones.Columns(7).Visible = False
            Me.datagrid_devoluciones.Columns(8).HeaderText = "Estado"
            Me.datagrid_devoluciones.Columns(8).Width = 110
            Me.datagrid_devoluciones.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.datagrid_devoluciones.Columns(9).Visible = False
            Me.datagrid_devoluciones.Columns(10).Visible = False
            Me.datagrid_devoluciones.Columns(11).Visible = False
            Me.datagrid_devoluciones.Columns(12).HeaderText = "Descargado"
            Me.datagrid_devoluciones.Columns(12).Width = 100
            Me.datagrid_devoluciones.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.datagrid_devoluciones.Columns(13).HeaderText = "Facturado"
            Me.datagrid_devoluciones.Columns(13).Width = 100
            Me.datagrid_devoluciones.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        Me.datagrid_devoluciones.ClearSelection()

    End Sub

    Private Sub Btn_nuevo_mov_Click(sender As Object, e As EventArgs) Handles Btn_nuevo_mov.Click
        Me.datagrid_devoluciones.Visible = False
        Me.Panel_detallePRODS.Visible = False
        Panel_dock.Visible = False

        ComboBox_periodoFiltro.Visible = False
        Label27.Visible = False
        Label33.Visible = True : Label33.Text = "Seleccione una Opción"



    End Sub
    Private Sub OCULTO_OPCIONES_BOTONES()
        Me.Button_FACTURAR.Enabled = False
        Me.Button_EXPORTAR.Enabled = True

        Me.Button_guardar.Enabled = True
        Me.Button_Regresar.Enabled = True

        Me.Button_FACTURAR.Visible = True
        Me.Button_EXPORTAR.Visible = True
        Me.Button_guardar.Visible = True
        Me.Button_Regresar.Visible = True

    End Sub

    Private Sub Button_guardar_Click(sender As Object, e As EventArgs) Handles Button_guardar.Click


        If Me.Button_guardar.Text = "Guardar" Then
            Me.Cursor = Cursors.WaitCursor

            sql = "INSERT INTO devoluciones(FECHA, factura, codcliente, cliente, Observaciones, empleadocod, empleado, Estado, nrofac, tipodev)" &
                 "VALUES ('" & Label_fecha_dev.Text & "','" & ID_VENTA_dev & "','" & TXT_DOC_CLIENTE.Text & "','" & TXT_NOM_CLIENTE.Text & "','" & Text_leyenda.Text & "','" & usrdoc & "','" & usrnom & "','PENDIENTE','" & Me.Label_consecutivo_dev.Text & "','" & tipo_devolucion & "')"
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

            loads_productos()
            Me.Cursor = Cursors.Default

            Me.Button_agregar_prod.Visible = True : Me.Button_agregar_prod.Enabled = True
            Me.button_Quitar_Prod.Visible = True : Me.button_Quitar_Prod.Enabled = True

            Me.TextBox_valorunitario.Text = 0
            Me.Button_guardar.Text = "Guardar Cambios"
            Me.Label_estado_dev.Text = "PENDIENTE"


            'MsgBox("Se Creó la devolución,  ahora puede seleccionar los productos.", vbInformation)

            OCULTO_OPCIONES_BOTONES()
            Me.Button_FACTURAR.Enabled = True
            Me.Button_EXPORTAR.Enabled = True

            'Me.Panel_prods.Visible = True
            'Timer_gridProds.Enabled = True

            Exit Sub
        End If



        If Me.Button_guardar.Text = "Guardar Cambios" And Label_estado_dev.Text = "PENDIENTE" Then
            sql = "UPDATE devoluciones SET OBSERVACIONES='" & Text_leyenda.Text & "' WHERE CONS=" & CLng(Label_consecutivo_dev.Text) & ""
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

            Me.datagrid_devoluciones.Visible = True
            Me.Panel_dock.Visible = True
            CodDocumento = 0



            load_grid_PEDIDOS_CLIENTES()

            Exit Sub
        End If

    End Sub

    Private Sub loads_productos()
        'LLENADO DE PRODUCTOS COMBO
        Try
            sql = "SELECT producto, codprod FROM ventas_prods where documento='" & Me.Label_Nofactura.Text & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt_prodscombo = New DataTable
            da.Fill(dt_prodscombo)
            Me.Datagrid_prods_catalogo.DataSource = dt_prodscombo
            Me.combobox_BuscarProd.DataSource = dt_prodscombo.DefaultView
            Me.combobox_BuscarProd.DisplayMember = "producto"
            Me.combobox_BuscarProd.ValueMember = "codprod"
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

    Private Sub TextBox_responsable_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_responsable.KeyPress
        e.KeyChar = ""
    End Sub


    Private Sub TextBoxTotalDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxTotal_Dev.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub Button_agregar_prod_Click(sender As Object, e As EventArgs) Handles Button_agregar_prod.Click
        If PROD_DECIMAL = "" Then PROD_DECIMAL = "NO"

        If Me.Label_estado_dev.Text = "Nuevo" Then
            MsgBox("Antes de agregar productos a la lista debe guardar.", vbIgnore) : Exit Sub
        End If

        If NumericUpDown_CANT.Value = 0 Then MsgBox("Falta la Cantidad.") : Exit Sub
        If Me.TextBox_valorunitario.Text = 0 Then MsgBox("Falta el valor unitario.") : Exit Sub

        PROD_IVA_VR = "0"
        PROD_VALOR_UNITARIO_BASE = 0
        PROD_INVENTARIADO = "SI"
        PROD_VALOR_UNITARIO_BASE = CInt(prod_valor)
        If prod_iva2nom <> "NO" Then  'CALCULAMOS EL IVA
            PROD_VALOR_UNITARIO_BASE = CInt(PROD_VALOR_UNITARIO_BASE / ((CInt(prod_iva2) / 100) + 1))
            PROD_IVA_VR2 = CInt(prod_valor) - CInt(PROD_VALOR_UNITARIO_BASE)
        End If

        If prod_iva1nom <> "NO" Then  ' calculamos ico
            'PROD_VALOR_UNITARIO_BASE = CInt(PROD_VALOR_UNITARIO_BASE) - CInt(prod_iva)
            'PROD_IVA_VR = prod_iva

            PROD_VALOR_UNITARIO_BASE = CDec(CDec(PROD_VALOR_UNITARIO_BASE) * CDec(NumericUpDown_CANT.Value) / ((CDec(prod_iva2) / 100) + 1))

            PROD_IVA_VR2 = CDec(CDec(PROD_VALOR_UNITARIO_BASE) * CDec(prod_iva2)) / 100

            'redondeo a dos decimales
            PROD_VALOR_UNITARIO_BASE = Math.Round(CDec(PROD_VALOR_UNITARIO_BASE), 0)
            PROD_IVA_VR2 = Math.Round(CDec(PROD_IVA_VR2), 0)

        End If

        If prod_iva2nom = "NO" Then 'CALCULAMOS EL IVA
            PROD_IVA_VR2 = 0
            prod_iva2 = 0
        End If

        If prod_iva1nom = "NO" Then  ' calculamos ico
            PROD_IVA_VR = 0
            prod_iva = 0
        End If

        prod_base = CLng(prod_base) * CInt(NumericUpDown_CANT.Value)

        Me.Cursor = Cursors.WaitCursor
        If PROD_DECIMAL = "NO" Then sql = "INSERT INTO devoluciones_prods (documento, codprod, producto, cantidad, base, imp, IMP2, impuesto, IMPUESTO2, valoru, valortotal, estado,  inventariado, IMPNOM1, IMPNOM2, DECI, COSTO)" &
                    "VALUES (" & CInt(Me.Label_consecutivo_dev.Text) & "," & CLng(Me.combobox_BuscarProd.SelectedValue) & ",'" & Me.combobox_BuscarProd.Text & "'," & CInt(NumericUpDown_CANT.Value) & ",'" & PROD_VALOR_UNITARIO_BASE & "',
                    '" & CStr(PROD_IVA_VR) & "','" & CStr(PROD_IVA_VR2) & "','" & CLng(PROD_IVA_VR) * NumericUpDown_CANT.Value & "','" & CLng(PROD_IVA_VR2) * NumericUpDown_CANT.Value & "'," & CInt(TextBox_valorunitario.Text) & "," & CInt(TextBox_Total_prod.Text) & ",'SIN DESCARGAR','" & PROD_INVENTARIADO & "','" & prod_iva1nom & "','" & prod_iva2nom & "','" & PROD_DECIMAL & "','" & CInt(PROD_COSTO) * NumericUpDown_CANT.Value & "')"
        If PROD_DECIMAL = "SI" Then sql = "INSERT INTO devoluciones_prods (documento, codprod, producto, cantidad, base, imp, IMP2, impuesto, IMPUESTO2, valoru, valortotal, estado,  inventariado, IMPNOM1, IMPNOM2, DECI, COSTO)" &
                    "VALUES (" & CInt(Me.Label_consecutivo_dev.Text) & "," & CInt(Me.combobox_BuscarProd.SelectedValue) & ",'" & Me.combobox_BuscarProd.Text & "','" & CStr(NumericUpDown_CANT.Value) & "','" & PROD_VALOR_UNITARIO_BASE & "','" & CStr(PROD_IVA_VR) & "','" & CStr(PROD_IVA_VR2) & "','" & Math.Round((CDec(PROD_IVA_VR) * CDec(NumericUpDown_CANT.Value)), 0) & "','" & Math.Round((CDec(PROD_IVA_VR2) * CDec(NumericUpDown_CANT.Value)), 0) & "','" & CStr(Math.Round(CDec(TextBox_valorunitario.Text), 3)) & "','" & CStr(Math.Round(CDec(TextBox_Total_prod.Text), 3)) & "','SIN DESCARGAR','" & PROD_INVENTARIADO.ToString & "','" & prod_iva1nom & "','" & prod_iva2nom & "','" & PROD_DECIMAL & "','" & CInt(PROD_COSTO) & "')"

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

        Me.Button_Regresar.Visible = True
        Timer_gridProds.Enabled = True
        Me.datagrid_productos.Enabled = True

    End Sub

    Private Sub datagrid_PEDIDOS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_devoluciones.CellContentClick

    End Sub

    Private Sub datagrid_PEDIDOS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_devoluciones.CellClick
        Dim row_mov As DataGridViewRow = datagrid_devoluciones.CurrentRow
        CodDocumento = CLng(row_mov.Cells("cons").Value) ' LLAVE PRINCIPAL
        Label_Nofactura.Text = CLng(row_mov.Cells("cons").Value) ' LLAVE PRINCIPAL

    End Sub

    Private Sub Btn_Ver_editar_Click(sender As Object, e As EventArgs) Handles Btn_Ver_editar.Click
        If CodDocumento = 0 Then MsgBox("Seleccione una Nota del listado.", vbInformation) : Exit Sub
        'If PERMISO_1(13) = "NO" Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub

        OCULTO_OPCIONES_BOTONES()

        ComboBox_periodoFiltro.Visible = False
        Label27.Visible = False

        Me.Panel_dock.Visible = False


        'DATOS BASICOS DLE PEDIDO
        Me.combobox_BuscarProd.Enabled = True
        Me.NumericUpDown_CANT.Enabled = True : Me.TextBox_valorunitario.Enabled = True : Me.TextBox_Total_prod.Enabled = False
        Me.Text_leyenda.Enabled = True : Me.TextBox_responsable.Enabled = False

        Try
            sql = "SELECT * FROM devoluciones WHERE CONS = " & CodDocumento & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                Label_consecutivo_dev.Text = row.Item("CONS")
                Label_fecha_dev.Text = row.Item("fecha")
                Label_Nofactura.Text = row.Item("factura")

                TXT_NOM_CLIENTE.Text = row.Item("cliente")
                TXT_DOC_CLIENTE.Text = row.Item("codcliente")
                Me.TextBox_responsable.Text = row.Item("empleado")
                Me.Text_leyenda.Text = row.Item("observaciones")
                Me.Label_estado_dev.Text = row.Item("estado")

                If row.Item("descargado") = "SI" Then
                    Me.Button_agregar_prod.Visible = False : Me.button_Quitar_Prod.Visible = False
                End If

                If row.Item("facturado") = "SI" Then
                    Me.Button_FACTURAR.Text = "FACTURADO" : Me.Button_FACTURAR.Enabled = False
                    Me.Button_agregar_prod.Visible = False : Me.button_Quitar_Prod.Visible = False
                    NRO_FACTURA = row.Item("nrofac")
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()


        'datos de factura
        Try
            sql = "SELECT documento, fecha, total, DEVOLUCION, mediodepago FROM ventas WHERE documento = " & Label_Nofactura.Text & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                Label_Nofactura.Text = row.Item("documento")
                Label24.Text = row.Item("fecha")
                Label_total_fac.Text = row.Item("total")
                TIENE_DEVOLUCION = row.Item("DEVOLUCION")
                medio_depago_dev = row.Item("mediodepago")

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()


        Try
            sql = "select cajasybancos.cuentapuc
from medios_pago
inner join cajasybancos on medios_pago.codcuenta=cajasybancos.cons
where medios_pago.mediopago='" & medio_de_pago & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                MEDIO_PAGO_DESTINO_NOMBRE = row.Item("CUENTApuc")
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()



        Try
            sql = "SELECT * FROM PROVEEDORES WHERE documento='" & TXT_DOC_CLIENTE.Text.ToString & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                TXT_DIR_CLIENTE.Text = row.Item("DIRECCION")
                TXT_TELS_CLIENTE.Text = row.Item("TELEFONO")
                TxtMAIL_cliente.Text = row.Item("EMAIL")
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()




        Me.datagrid_devoluciones.Visible = False

        Me.Panel_prods.Visible = True

        Me.Button_agregar_prod.Visible = True
        Me.button_Quitar_Prod.Visible = True
        Me.Button_agregar_prod.Enabled = True
        Me.button_Quitar_Prod.Enabled = True



        Me.Button_guardar.Text = "Guardar Cambios"


        Button_guardar.Visible = True

        If Label_estado_dev.Text = "PENDIENTE" Then
            Me.Button_agregar_prod.Visible = True : Me.Button_agregar_prod.Enabled = True
            Me.button_Quitar_Prod.Visible = True : Me.button_Quitar_Prod.Enabled = True

            Me.Button_EXPORTAR.Enabled = True
            Me.Button_FACTURAR.Enabled = True

            If Me.Button_FACTURAR.Text = "FACTURADO" Then Me.Button_FACTURAR.Enabled = False : Me.button_Quitar_Prod.Visible = False : Me.Button_agregar_prod.Visible = False
            loads_productos()

        End If

        If Label_estado_dev.Text = "FINALIZADO" Then

            Me.Button_FACTURAR.Enabled = False
            Me.Button_guardar.Enabled = False
            Me.Button_EXPORTAR.Enabled = True
            Me.Button_guardar.Enabled = False

            Me.Button_guardar.Text = "Guardar"

            Me.Button_agregar_prod.Visible = False
            Me.button_Quitar_Prod.Visible = False
            Button_guardar.Visible = False

        End If

        If Label_estado_dev.Text = "ANULADA" Then
            Me.Button_EXPORTAR.Visible = True
            Me.Button_agregar_prod.Visible = False
            Me.button_Quitar_Prod.Visible = False
            Me.Button_Regresar.Visible = True
            Me.Button_guardar.Enabled = False
            Me.Button_guardar.Text = "Guardar"
            Me.Button_FACTURAR.Enabled = False
            Button_guardar.Visible = False

        End If
        Timer_gridProds.Enabled = True

        Panel_detallePRODS.Width = 898
    End Sub

    Private Sub Button_Regresar_Click(sender As Object, e As EventArgs) Handles Button_Regresar.Click
        NRO_FACTURA = ""
        datagrid_devoluciones.Visible = True
        CodDocumento = 0

        Me.Button_FACTURAR.Text = "Facturar"

        Me.TXT_DOC_CLIENTE.Text = ""
        Me.TXT_NOM_CLIENTE.Text = ""
        Me.TXT_TELS_CLIENTE.Text = ""
        Me.TXT_DIR_CLIENTE.Text = ""
        Me.TxtMAIL_cliente.Text = ""
        Me.Label_consecutivo_dev.Text = "0"
        Me.Label_fecha_dev.Text = "0"
        Me.Text_leyenda.Text = ""
        Me.TextBox_responsable.Text = ""
        Me.TextBoxTotal_Dev.Text = ""
        Me.Label_estado_dev.Text = "NUEVO"
        Me.combobox_BuscarProd.DataSource = Nothing
        Me.NumericUpDown_CANT.Value = 0
        Me.TextBox_valorunitario.Text = "0"
        Me.TextBox_Total_prod.Text = "0"

        Me.Panel_dock.Visible = True

        Me.datagrid_productos.DataSource = Nothing

        load_grid_PEDIDOS_CLIENTES()
        ComboBox_periodoFiltro.Visible = True
        Label33.Visible = True


        Me.datagrid_devoluciones.ClearSelection()
    End Sub



    Private Sub TextBox_BARRAS_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_CANT.ValueChanged
        Me.TextBox_Total_prod.Text = CInt(Me.NumericUpDown_CANT.Value) * CInt(TextBox_valorunitario.Text)

    End Sub



    Private Sub TextBox_valorunitario_TextChanged(sender As Object, e As EventArgs) Handles TextBox_valorunitario.TextChanged
        If Me.TextBox_valorunitario.Text = "" Then Me.TextBox_valorunitario.Text = 0
        Me.TextBox_Total_prod.Text = CInt(Me.NumericUpDown_CANT.Value) * CInt(TextBox_valorunitario.Text)
    End Sub

    Private Sub button_Quitar_Prod_Click(sender As Object, e As EventArgs) Handles button_Quitar_Prod.Click
        If prod_cod = 0 Then MsgBox("Debe Seleccionar un producto.", vbInformation) : Exit Sub

        Dim RTA As String
        Me.Cursor = Cursors.WaitCursor

        RTA = MsgBox("Desea eliminar el producto?.", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If RTA = 6 Then
            sql = "delete from devoluciones_prods where cons=" & CInt(prod_cod) & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
                MsgBox("Se Borró el producto.")
            Catch ex As Exception
                MsgBox("Error al Borrar el Registro.")
                Exit Sub
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()
            Me.Button_Regresar.Visible = False
        End If
        prod_cod = ""
        Me.Timer_gridProds.Enabled = True
        Me.Cursor = Cursors.Default

    End Sub



    Private Sub Button_FACTURAR_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button_EXPORTAR_Click(sender As Object, e As EventArgs) Handles Button_EXPORTAR.Click
        Try
            sql = "SELECT CODPROD, PRODUCTO, CANTIDAD, VALORU, VALORTOTAL FROM devoluciones_PRODS WHERE documento = " & CInt(Label_consecutivo_dev.Text) & ""
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
            Dim doc As New Document(PageSize.A4.Rotate, 50, 10, 10, 10)
            'Path que guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\devolucion_" & Me.Label_consecutivo_dev.Text & ".pdf"
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
        Dim encabezado2 As New Paragraph("Nota de Devolución No. " + Me.Label_consecutivo_dev.Text, New Font(Font.Name = "Arial Balck", 12, Font.Bold))
        Dim encabezado3 As New Paragraph("Cliente: " + TXT_NOM_CLIENTE.Text + " NIT: " & Me.TXT_DOC_CLIENTE.Text.ToString, New Font(Font.Name = "Arial Balck", 12, Font.Bold))


        'Se crea el texto abajo del encabezado.
        Dim texto As New Phrase("Fecha: " + Me.Label_fecha_dev.Text.ToString + Chr(13), New Font(Font.Name = "Arial Narrow", 10, Font.Bold))
        Dim texto_empleado As New Phrase("Realizado por: " + Me.TextBox_responsable.Text.ToString + Chr(13), New Font(Font.Name = "Arial Narrow", 10, Font.Bold))
        Dim texto_estadodoc As New Phrase("Estado: " + Me.Label_estado_dev.Text.ToString + "      Total: " + Me.TextBoxTotal_Dev.Text.ToString + Chr(13), New Font(Font.Name = "Arial Narrow", 10, Font.Bold))
        Dim texto2 As New Phrase("Fecha del Reporte: " + Now.Date(), New Font(Font.Name = "Arial Narrow", 10, Font.Bold))
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
            imagelogogopdf.SetAbsolutePosition(580, 490) 'Posicion en el eje cartesiano
            imagelogogopdf.ScaleAbsoluteWidth(200) 'Ancho de la imagen
            imagelogogopdf.ScaleAbsoluteHeight(100) 'Altura de la imagen
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
        document.Add(texto3)
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
    Private Sub datagrid_productos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_productos.CellContentClick

    End Sub

    Private Sub Label_estado_movimiento_Click(sender As Object, e As EventArgs) Handles Label_estado_dev.Click

        If Label_estado_dev.Text = "NUEVO" Then
            Exit Sub
        End If


    End Sub



    Private Sub Button_enviarCompra_Click(sender As Object, e As EventArgs) Handles Button_FACTURAR.Click

        If Me.Button_FACTURAR.Text = "FACTURADO" Then
            If NRO_FACTURA <> "" Then
                ID_VENTA_VER = NRO_FACTURA
                Form_verfactura.Show()
            End If
            Exit Sub
        End If

        If Me.TextBoxTotal_Dev.Text = "0" Then
            MsgBox("No hay productos para facturar.", vbInformation) : Exit Sub
        End If

        Dim RTA, rta2 As String
        RTA = MsgBox("Confirma Generar la devolucion?.", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If RTA = 6 Then
            Me.Cursor = Cursors.WaitCursor
            GENERAR_VENTA()
            Me.Cursor = Cursors.Default

            NRO_FACTURA = consecutivo

            'descarggue de bodega
            '  retiro de bodega    =============================================
            Me.Cursor = Cursors.WaitCursor
            Try
                For J As Integer = 0 To Me.datagrid_productos.RowCount - 1

                    Dim entran, salen, saldo As Integer

                    saldo = 0

                    PROD_ENTRAN = Me.datagrid_productos.Item("cantidad", J).Value
                    PROD_SALDO = saldo
                    PROD_SALDO = PROD_SALDO + PROD_ENTRAN ' PROD_ENTRAN   '  ACUMULO
                    PROD_SALEN = 0 ' POR QUE QUE ES UNA COMPRA
                    Dim rol As String = ""
                    rol = "ENTRAN"

                    sql = "INSERT INTO bodega_" & comex_bodega_ventas & " (fecha, CodBodega, NomBodega, TipoDocumento, Documento, Rol, CodProducto, Producto, SALDOANT, Entran, Salen, Saldo, valoru, valortotal, costo, Empleado, Estado)" &
                        " VALUES ('" & DateTime.Now.ToShortDateString & "',1,'PRINCIPAL','Devolución de Venta'," & CInt(Me.Label_consecutivo_dev.Text) & ",'ENTRAN'," & CInt(Me.datagrid_productos.Item("CODPROD", J).Value) & ",'" & CStr(Me.datagrid_productos.Item("PRODUCTO", J).Value) & "'," & saldo & "," & PROD_ENTRAN & ",0," & PROD_SALDO & "," & CLng(Me.datagrid_productos.Item("valoru", J).Value) & "," & (Me.datagrid_productos.Item("valortotal", J).Value) & "," & (Me.datagrid_productos.Item("costo", J).Value) & ",'" & usrnom & "','DESCARGADO')"
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


                    PROD_ENTRAN = 0
                    PROD_SALDO = 0
                    PROD_SALDO = 0
                    PROD_SALEN = 0
                    '    'contabilizar COSTO=======================================================================================
                    '    saldo = 0

                    '    PROD_SALEN = CInt(datagrid_productos.Item("costo", J).Value)  ' TOMO LA CANTIDAD DEL GRID Q ESTA RECORRIENDO
                    '    PROD_SALDO = saldo  ' IGUALDO SALDO PROD CON EL SALDO CALCULADO EN BODEGA PRICIPAL
                    '    PROD_SALDO = CInt(PROD_SALDO) - CInt(PROD_SALEN) ' PROD_ENTRAN   '  ACUMULO
                    '    PROD_ENTRAN = 0 ' POR QUE QUE ES UNA venta
                    '    'REGISTRO EN PUC


                    '    sql = "INSERT INTO cajaspuc(Codcuenta, cuenta, TERCERO, Fecha, Documento, TipoDoc, Rol, SaldoAnt, debe, haber, Saldo, DETALLE, Estado, annoactual)" &
                    '   "VALUES ('61350501','Comercio al por mayor y al por menor','" & TXT_DOC_CLIENTE.Text & "|" & TXT_NOM_CLIENTE.Text & "','" & DateTime.Now.ToShortDateString & "','" & consecutivo & "','DEVOLUCION DE VENTA','SALEN'," & saldo & "," & PROD_ENTRAN & "," & PROD_SALEN & "," & PROD_SALDO & ",'" & CStr(CStr(datagrid_productos.Item("CODPROD", J).Value) & "|" & CStr(datagrid_productos.Item("PRODUCTO", J).Value)) & "','DESCARGADO','" & comex_annoactual & "')"
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

                    '    PROD_ENTRAN = 0
                    '    PROD_SALDO = 0
                    '    PROD_SALDO = 0
                    '    PROD_SALEN = 0

                    '    saldo = 0

                    '    PROD_ENTRAN = CStr(datagrid_productos.Item("costo", J).Value)  ' TOMO LA CANTIDAD DEL GRID Q ESTA RECORRIENDO
                    '    PROD_SALDO = saldo  ' IGUALDO SALDO PROD CON EL SALDO CALCULADO EN BODEGA PRICIPAL
                    '    PROD_SALDO = CInt(PROD_SALDO) + CInt(PROD_ENTRAN) ' PROD_ENTRAN   '  ACUMULO
                    '    PROD_SALEN = 0 ' POR QUE QUE ES UNA venta
                    '    'REGISTRO EN PUC

                    '    sql = "INSERT INTO cajaspuc(Codcuenta, cuenta, TERCERO,Fecha, Documento, TipoDoc, Rol, SaldoAnt, debe, haber, Saldo, DETALLE, Estado, annoactual)" &
                    '"VALUES ('14359001','Mercancias no fabricadas por la empresa','" & TXT_DOC_CLIENTE.Text & "|" & TXT_NOM_CLIENTE.Text & "','" & DateTime.Now.ToShortDateString & "','" & consecutivo & "','DEVOLUCION DE VENTA','ENTRAN'," & saldo & "," & PROD_ENTRAN & "," & PROD_SALEN & "," & PROD_SALDO & ",'" & CStr(CStr(datagrid_productos.Item("CODPROD", J).Value) & "|" & CStr(datagrid_productos.Item("PRODUCTO", J).Value)) & "','DESCARGADO','" & comex_annoactual & "')"
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
                    '    '================================================================================================

                Next
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try


            Dim pago() As String
            pago = Strings.Split(MEDIO_PAGO_DESTINO_NOMBRE, "|")

            PROD_SALEN = CInt(TextBoxTotal_Dev.Text)  ' TOMO LA CANTIDAD DEL GRID Q ESTA RECORRIENDO
            PROD_SALDO = saldo  ' IGUALDO SALDO PROD CON EL SALDO CALCULADO EN BODEGA PRICIPAL
            PROD_SALDO = CInt(PROD_SALDO) - CInt(PROD_SALEN) ' PROD_ENTRAN   '  ACUMULO
            PROD_ENTRAN = 0 ' POR QUE QUE ES UNA venta
            'REGISTRO EN PUC

            sql = "INSERT INTO cajaspuc(Codcuenta, cuenta, TERCERO, Fecha, Documento, TipoDoc, Rol, SaldoAnt, debe, haber, Saldo, DETALLE, Estado, annoactual)" &
   "VALUES ('" & ComboBox_cta_caja_banco.SelectedValue & "','" & ComboBox_cta_caja_banco.Text & "','" & TXT_DOC_CLIENTE.Text & "|" & TXT_NOM_CLIENTE.Text & "','" & DateTime.Now.ToShortDateString & "','" & consecutivo & "','DEVOLUCION DE VENTA','SALEN'," & saldo & "," & PROD_ENTRAN & "," & PROD_SALEN & "," & PROD_SALDO & ",'DEVOLUCION DE VENTA','DESCARGADO','" & comex_annoactual & "')"
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


            PROD_ENTRAN = 0
            PROD_SALDO = 0
            PROD_SALDO = 0
            PROD_SALEN = 0

            '         Dim ctapuc, ctapucNOM As String

            '         ctapuc = "417505" : ctapucNOM = "Comercio al Por Mayor y menor de tecnologia"
            '         'If PROD_categoria = "PRODUCTOS (No Fabricados por la Empresa)" Then ctapuc = "41350501" : ctapucNOM = "Comercio al Por Mayor y menor de tecnologia"
            '         'If PROD_categoria = "SERVICIOS" Then ctapuc = "423565" : ctapucNOM = "Servicios de Mantenimiento"

            '         'contrapartida --------------------------------------
            '         saldo = 0


            '         PROD_ENTRAN = CInt(TextBoxTotal_Dev.Text)
            '         PROD_SALDO = saldo
            '         PROD_SALDO = CInt(PROD_SALDO) + CInt(PROD_SALEN) ' 
            '         PROD_SALEN = 0 ' POR QUE QUE ES UNA venta
            '         'REGISTRO EN PUC

            '         sql = "INSERT INTO cajaspuc(Codcuenta, cuenta, TERCERO, Fecha, Documento, TipoDoc, Rol, SaldoAnt, debe, haber, Saldo, DETALLE, Estado, annoactual)" &
            '"VALUES ('" & ctapuc & "','" & ctapucNOM & "','" & TXT_DOC_CLIENTE.Text & "|" & TXT_NOM_CLIENTE.Text & "','" & DateTime.Now.ToShortDateString & "','" & consecutivo & "','DEVOLUCION DE VENTA','ENTRAN'," & saldo & "," & PROD_ENTRAN & "," & PROD_SALEN & "," & PROD_SALDO & ",'DEVOLUCION DE VENTA','DESCARGADO','" & comex_annoactual & "')"
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

            '         'partida de impusto   =======================================================================================
            '         If CInt(TextBox_imp_dev.Text) > 0 Then

            '             '============================================================================
            '             ctapuc = "233575" : ctapucNOM = "Impuesto Nacional al Consumo"
            '             saldo = 0

            '             PROD_ENTRAN = CInt(TextBox_imp_dev.Text)
            '             PROD_SALDO = saldo
            '             PROD_SALDO = CInt(PROD_SALDO) + CInt(PROD_SALEN) ' 
            '             PROD_SALEN = 0 ' POR QUE QUE ES UNA venta
            '             'REGISTRO EN PUC

            '             sql = "INSERT INTO cajaspuc(Codcuenta, cuenta, TERCERO, Fecha, Documento, TipoDoc, Rol, SaldoAnt, debe, haber, Saldo, DETALLE, Estado, annoactual)" &
            '    "VALUES ('" & ctapuc & "','" & ctapucNOM & "','" & TXT_DOC_CLIENTE.Text & "|" & TXT_NOM_CLIENTE.Text & "','" & DateTime.Now.ToShortDateString & "','" & consecutivo & "','FACTURA DE VENTA','ENTRAN'," & saldo & "," & PROD_ENTRAN & "," & PROD_SALEN & "," & PROD_SALDO & ",'FACTURA DE VENTA','DESCARGADO','" & comex_annoactual & "')"
            '             da = New MySqlDataAdapter(sql, conex)
            '             dt = New DataTable
            '             Try
            '                 da.Fill(dt)
            '             Catch ex As Exception
            '                 MsgBox(ex.ToString)
            '             End Try
            '             da.Dispose()
            '             dt.Dispose()
            '             conex.Close()
            '             'partida de iva   =======================================================================================
            '         End If


            sql = "update devoluciones SET Descargado='SI',estado='FINALIZADO', mediopago='" & ComboBox_cta_caja_banco.SelectedValue & "', vrpago='" & TextBoxTotal_Dev.Text & "' WHERE CONS=" & CLng(Label_consecutivo_dev.Text) & ""
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



            Me.Cursor = Cursors.WaitCursor


            Label_estado_dev.Text = "FINALIZADO"

            Me.Cursor = Cursors.Default
            Me.Button_agregar_prod.Visible = False
            Me.button_Quitar_Prod.Visible = False
            Me.Cursor = Cursors.Default

        End If


    End Sub
    Private Sub GENERAR_VENTA()




        sql = "INSERT INTO CAJA (turno, fecha, documento, tipoDocumento, subtotal, descuento, total, mediodepago, EmpleadoDoc, empleado, estado)" &
              "VALUES ('" & turno_actual_global_ID & "','" & DateTime.Now.ToShortDateString & "'," & Label_consecutivo_dev.Text & ",'Devolución Venta'," & CInt(TextBoxTotal_Dev.Text) & ",0," & CInt(TextBoxTotal_Dev.Text) & ",'EFECTIVO'," & CInt(usrdoc) & ",'" & usrnom & "','DESCARGADO')"
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


        sql = "UPDATE DEVOLUCIONES set FACTURADO='SI', nrofac='" & Label_Nofactura.Text & "' WHERE CONS=" & CLng(Label_consecutivo_dev.Text) & ""
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



        '  caja y bancos
        '  caja y bancos





        Me.Button_FACTURAR.Text = "DEVUELTO"


    End Sub


    Private Sub LABEL_NIT_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub combobox_BuscarProd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobox_BuscarProd.SelectedIndexChanged

    End Sub

    Private Sub combobox_BuscarProd_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles combobox_BuscarProd.SelectionChangeCommitted
        Me.Timer_prod_data.Enabled = True

    End Sub

    Private Sub Timer_prod_data_Tick(sender As Object, e As EventArgs) Handles Timer_prod_data.Tick
        Me.Timer_prod_data.Enabled = False
        datos_del_producto()
        datos_del_prod_en_factura()

        BUSCA_SALDO_PRODUCTO()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub




    Private Sub Button_crear_dev_Click(sender As Object, e As EventArgs) Handles Button_crear_dev.Click
        If ID_VENTA_dev = "" Then
            MsgBox("Busque y seleccione una factura.", MsgBoxStyle.Information)
            datagrid_fac_dev.ClearSelection()

            Exit Sub
        End If

        If TIENE_DEVOLUCION <> "" Then
            MsgBox("esa factura ya tiene una devolucion.", MsgBoxStyle.Information) : Exit Sub
            datagrid_fac_dev.ClearSelection()
        End If


        'reseteo datos del producto
        Me.TextBox_valorunitario.Text = "0" : Me.NumericUpDown_CANT.Value = "0" : Me.TextBox_Total_prod.Text = "0"


        'botones agregar o quitar prods
        Me.Button_agregar_prod.Visible = False
        Me.button_Quitar_Prod.Visible = False



        'bonotes amarillos
        Me.Panel_dock.Visible = False

        'panel prods
        Me.Panel_prods.Visible = False

        Me.datagrid_devoluciones.Visible = True
        Me.Panel_detallePRODS.Visible = True

        'consecutivo
        consecutivo = 0
        cmd.Connection = conex
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select max(cons) + 1 from devoluciones"
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

        Me.Label_consecutivo_dev.Text = consecutivo : Me.Label_fecha_dev.Text = DateTime.Now.ToShortDateString
        Me.TextBox_responsable.Text = usrnom
        Me.TextBoxTotal_Dev.Text = 0


        sql = "UPDATE ventas set devolucion='" & consecutivo & "' WHERE CONS=" & ID_VENTA_dev & ""
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


        Me.datagrid_devoluciones.Visible = False

        Me.Button_FACTURAR.Text = "Facturar"

        OCULTO_OPCIONES_BOTONES()
        Me.Button_EXPORTAR.Visible = True
        Me.Button_guardar.Text = "Guardar"
        Me.Button_guardar.Enabled = True


        Try
            sql = "SELECT * FROM PROVEEDORES WHERE documento='" & Me.TXT_DOC_CLIENTE.Text & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                TXT_NOM_CLIENTE.Text = row.Item("nombre")
                TXT_DIR_CLIENTE.Text = row.Item("DIRECCION")
                TXT_TELS_CLIENTE.Text = row.Item("TELEFONO")
                TxtMAIL_cliente.Text = row.Item("EMAIL")
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()


        'datos de factura
        Try
            sql = "SELECT documento, fecha, total, DEVOLUCION, mediodepago FROM ventas WHERE documento = " & Label_Nofactura.Text & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                Label_Nofactura.Text = row.Item("documento")
                Label24.Text = row.Item("fecha")
                Label_total_fac.Text = row.Item("total")
                TIENE_DEVOLUCION = row.Item("DEVOLUCION")
                medio_depago_dev = row.Item("mediodepago")
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()


        Try
            sql = "select cajasybancos.cuentapuc
from medios_pago
inner join cajasybancos on medios_pago.codcuenta=cajasybancos.cons
where medios_pago.mediopago='" & medio_depago_dev & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                MEDIO_PAGO_DESTINO_NOMBRE = row.Item("CUENTApuc")
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()


        Me.TXT_DOC_CLIENTE.Focus()


        Panel_detallePRODS.Width = 898



        Button_guardar_Click(Nothing, Nothing)

        Panel_prods.Visible = True

    End Sub



    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        GRID_VENTAS_nro_dev()
    End Sub

    Private Sub GRID_VENTAS_fecha_dev()
        Try
            sql = "select * from VENTAS WHERE month(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & mes_num_text_general & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.datagrid_fac_dev.DataSource = dt
            Me.datagrid_fac_dev.Columns(0).Visible = False
            Me.datagrid_fac_dev.Columns(1).Visible = False
            Me.datagrid_fac_dev.Columns(2).HeaderText = "Factura"
            Me.datagrid_fac_dev.Columns(2).Width = 80
            Me.datagrid_fac_dev.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagrid_fac_dev.Columns(3).Visible = False
            Me.datagrid_fac_dev.Columns(4).HeaderText = "Doc. Cliente"
            Me.datagrid_fac_dev.Columns(4).Width = 90
            Me.datagrid_fac_dev.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagrid_fac_dev.Columns(5).HeaderText = "Cliente"
            Me.datagrid_fac_dev.Columns(5).Width = 100
            Me.datagrid_fac_dev.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagrid_fac_dev.Columns(6).HeaderText = "Fecha"
            Me.datagrid_fac_dev.Columns(6).Width = 80
            Me.datagrid_fac_dev.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagrid_fac_dev.Columns(7).Visible = False
            Me.datagrid_fac_dev.Columns(8).Visible = False
            Me.datagrid_fac_dev.Columns(9).Visible = False
            Me.datagrid_fac_dev.Columns(10).Visible = False
            Me.datagrid_fac_dev.Columns(11).HeaderText = "Totalventa"
            Me.datagrid_fac_dev.Columns(11).Width = 80
            Me.datagrid_fac_dev.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagrid_fac_dev.Columns(12).Visible = False
            Me.datagrid_fac_dev.Columns(13).Visible = False
            Me.datagrid_fac_dev.Columns(14).Visible = False
            Me.datagrid_fac_dev.Columns(15).Visible = False
            Me.datagrid_fac_dev.Columns(16).Visible = False
            Me.datagrid_fac_dev.Columns(17).Visible = False
            Me.datagrid_fac_dev.Columns(18).Visible = False
            Me.datagrid_fac_dev.Columns(19).Visible = False
            Me.datagrid_fac_dev.Columns(20).Visible = False
            Me.datagrid_fac_dev.Columns(21).Visible = False
            Me.datagrid_fac_dev.Columns(22).Visible = False
            Me.datagrid_fac_dev.Columns(23).Visible = False
            Me.datagrid_fac_dev.Columns(24).Visible = False
            Me.datagrid_fac_dev.Columns(25).Visible = False
            Me.datagrid_fac_dev.Columns(26).Visible = False
            Me.datagrid_fac_dev.Columns(27).Visible = False
            Me.datagrid_fac_dev.Columns(28).Visible = False
            Me.datagrid_fac_dev.Columns(29).Visible = False
            Me.datagrid_fac_dev.Columns(30).Visible = False
            Me.datagrid_fac_dev.Columns(31).Visible = False
            Me.datagrid_fac_dev.Columns(32).HeaderText = "Cambio"
            Me.datagrid_fac_dev.Columns(32).Width = 80
            Me.datagrid_fac_dev.Columns(32).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        datagrid_fac_dev.ClearSelection()

    End Sub

    Private Sub Timer_MEDIO_PAGO_Tick(sender As Object, e As EventArgs) Handles Timer_MEDIO_PAGO.Tick
        Timer_MEDIO_PAGO.Enabled = False
        Try
            sql = "SELECT * FROM medios_pago WHERE CONS='6'"   'devoluciones a caja menor 6
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                'MEDIO_PAGO_DESTINO_COD = row.Item("CUENTA")
                MEDIO_PAGO_DESTINO_NOMBRE = row.Item("MEDIOPAGO")
                MEDIO_PAGO_DESTINO_TIPO = row.Item("TIPO")

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()


        '        Try
        '            sql = "SELECT * FROM medios_pago
        'inner join cajasybancos on medios_pago.codcuenta=cajasybancos.cons
        ' WHERE medios_pago.CONS='" & Me.ListBox1.SelectedValue.ToString & "'"
        '            da = New MySqlDataAdapter(sql, conex)
        '            dt = New DataTable
        '            da.Fill(dt)
        '            For Each row As DataRow In dt.Rows
        '                MEDIO_PAGO_DESTINO_COD = row.Item("CUENTApuc")
        '                MEDIO_PAGO_DESTINO_NOMBRE = row.Item("MEDIOPAGO")
        '                MEDIO_PAGO_DESTINO_TIPO = row.Item("TIPO")
        '                medio_de_pago = MEDIO_PAGO_DESTINO_NOMBRE
        '            Next
        '        Catch ex As Exception
        '            MsgBox(ex.Message)
        '        End Try
        '        conex.Close()
        '        da.Dispose()
        '        dt.Dispose()



        medio_de_pago = MEDIO_PAGO_DESTINO_NOMBRE
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel_detallePRODS_Paint(sender As Object, e As PaintEventArgs) Handles Panel_detallePRODS.Paint

    End Sub

    Private Sub ComboBox_mes_general_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_mes_general.SelectedIndexChanged

    End Sub

    Private Sub Btn_salir_Click(sender As Object, e As EventArgs) Handles Btn_salir.Click
        Me.Close()
    End Sub

    Private Sub ComboBox_periodoFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_periodoFiltro.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If TXT_DOC_CLIENTE.Text = "" Then
            MsgBox("debe seleccionar un cliente.", MsgBoxStyle.Information)

            Exit Sub
        End If


        If TextBox_concepto_desc.Text = "" Then
            MsgBox("debe escribir una concepto.", MsgBoxStyle.Information)

            Exit Sub
        End If

        If TextBox_valor_desc.Text = "" Or TextBox_valor_desc.Text = "0" Then
            MsgBox("Digite el valor.", MsgBoxStyle.Information)

            Exit Sub
        End If

        If ComboBox_factura_nota_dev.Text = "" And Checkbox_aplicar_fac.Checked = True Then
            MsgBox("Seleccione una factura.", MsgBoxStyle.Information)
            Exit Sub
        End If


        Me.Cursor = Cursors.WaitCursor


        'consecutivo
        consecutivo = 0
        cmd.Connection = conex
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select max(cons) + 1 from devoluciones"
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

        Me.Label_consecutivo_dev.Text = consecutivo
        Me.Label_fecha_dev.Text = DateTime.Now.ToShortDateString
        Me.TextBox_responsable.Text = usrnom
        Me.TextBoxTotal_Dev.Text = 0


        sql = "INSERT INTO devoluciones(FECHA, factura, codcliente, cliente, Observaciones, empleadocod, empleado, Estado, nrofac, tipodev)" &
                 "VALUES ('" & Label_fecha_dev.Text & "','" & CStr(ComboBox_factura_nota_dev.SelectedValue) & "','" & TXT_DOC_CLIENTE.Text & "','" & TXT_NOM_CLIENTE.Text & "','" & Text_leyenda.Text & "','" & usrdoc & "','" & usrnom & "','PENDIENTE','" & Me.Label_consecutivo_dev.Text & "','" & tipo_devolucion & "')"
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
        sql = "INSERT INTO devoluciones_prods (documento, producto, cantidad, base, imp, IMP2, impuesto, IMPUESTO2, valoru, valortotal, estado)" &
                    "VALUES (" & CInt(Me.Label_consecutivo_dev.Text) & ",'" & TextBox_concepto_desc.Text & "'," & "0" & ",'" & TextBox_valor_desc.Text & "','" & CStr("0") & "','" & CStr("0") & "','" & "0" & "','" & "0" & "'," & CInt(0) & "," & CInt(TextBox_valor_desc.Text) & ",'SIN DESCARGAR')"

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


        If Checkbox_aplicar_fac.Checked = True Then
            sql = "insert into ventas_prods (documento,codprod, producto, valortotal, estado) values('" & Me.ComboBox_factura_nota_dev.SelectedValue.Text & "','','Nota de Descuento " & Label_consecutivo_dev.Text & "','" & CInt(TextBox_valor_desc.Text) * -1 & "','DESCARGADO')"
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



        End If

        Me.Cursor = Cursors.WaitCursor



        Panel16.Visible = False

        Me.TextBox_valorunitario.Text = 0
        Me.Button_guardar.Text = "Guardar Cambios"
        Me.Label_estado_dev.Text = "PENDIENTE"




        Me.Button_EXPORTAR.Enabled = True

        Panel_prods.Visible = True
        Button_Regresar.Visible = True
        Button_EXPORTAR.Visible = True

        Timer_gridProds.Enabled = True

        COMBO_NOM_CLIENTE_FILTRO.Enabled = False
        COMBO_DOC_CLIENTE_FILTRO.Enabled = False

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub TXT_DOC_CLIENTE_TextChanged(sender As Object, e As EventArgs) Handles TXT_DOC_CLIENTE.TextChanged

    End Sub

    Private Sub Checkbox_aplicar_fac_OnChange(sender As Object, e As EventArgs) Handles Checkbox_aplicar_fac.OnChange
        If Checkbox_aplicar_fac.Checked = True Then
            Try
                sql = "select * from VENTAS WHERE month(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & mes_num_text_general & "' and doccliente='" & TXT_DOC_CLIENTE.Text & "'"
                da_combo_facs_dcto = New MySqlDataAdapter(sql, conex)
                dt_combo_facs_dcto = New DataTable
                da_combo_facs_dcto.Fill(dt_combo_facs_dcto)
                ' llenar el combo de facturas
                Me.ComboBox_factura_nota_dev.DataSource = dt_combo_facs_dcto.DefaultView
                Me.ComboBox_factura_nota_dev.DisplayMember = "documento"
                Me.ComboBox_factura_nota_dev.ValueMember = "documento"
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da_combo_facs_dcto.Dispose()
            dt_combo_facs_dcto.Dispose()
            conex.Close()
            ComboBox_factura_nota_dev.Enabled = True
        Else
            ComboBox_factura_nota_dev.Enabled = False

            Me.ComboBox_factura_nota_dev.DataSource = Nothing
            ComboBox_factura_nota_dev.Items.Clear()
        End If

    End Sub

    Private Sub TextBox_DV_TextChanged(sender As Object, e As EventArgs) Handles TextBox_DV.TextChanged

    End Sub

    Private Sub COMBO_DOC_CLIENTE_FILTRO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMBO_DOC_CLIENTE_FILTRO.SelectedIndexChanged

    End Sub

    Private Sub TXT_NOM_CLIENTE_TextChanged(sender As Object, e As EventArgs) Handles TXT_NOM_CLIENTE.TextChanged

    End Sub

    Private Sub COMBO_NOM_CLIENTE_FILTRO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMBO_NOM_CLIENTE_FILTRO.SelectedIndexChanged

    End Sub

    Private Sub TXT_TELS_CLIENTE_TextChanged(sender As Object, e As EventArgs) Handles TXT_TELS_CLIENTE.TextChanged

    End Sub

    Private Sub Timer_clientes_Tick(sender As Object, e As EventArgs) Handles Timer_clientes.Tick
        Timer_clientes.Enabled = False

        cli_doc = COMBO_DOC_CLIENTE_FILTRO.Text


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

        COMBO_DOC_CLIENTE_FILTRO.Text = ""
        COMBO_NOM_CLIENTE_FILTRO.Text = ""
    End Sub

    Private Sub TXT_DIR_CLIENTE_TextChanged(sender As Object, e As EventArgs) Handles TXT_DIR_CLIENTE.TextChanged

    End Sub

    Private Sub datagrid_fac_dev_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_fac_dev.CellContentClick

    End Sub

    Private Sub TxtMAIL_cliente_TextChanged(sender As Object, e As EventArgs) Handles TxtMAIL_cliente.TextChanged

    End Sub

    Private Sub Button_nota_cred_Click(sender As Object, e As EventArgs) Handles Button_nota_cred.Click




        'reseteo datos del producto
        Me.TextBox_valorunitario.Text = "0" : Me.NumericUpDown_CANT.Value = "0" : Me.TextBox_Total_prod.Text = "0"


        'botones agregar o quitar prods
        Me.Button_agregar_prod.Visible = False
        Me.button_Quitar_Prod.Visible = False



        'bonotes amarillos
        Me.Panel_dock.Visible = False

        'panel prods
        Me.Panel_prods.Visible = False

        Me.datagrid_devoluciones.Visible = True
        Me.Panel_detallePRODS.Visible = True

        'consecutivo
        consecutivo = 0
        cmd.Connection = conex
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select max(cons) + 1 from devoluciones"
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

        Me.Label_consecutivo_dev.Text = consecutivo : Me.Label_fecha_dev.Text = DateTime.Now.ToShortDateString
        Me.TextBox_responsable.Text = usrnom
        Me.TextBoxTotal_Dev.Text = 0





        Me.datagrid_devoluciones.Visible = False

        Me.Button_FACTURAR.Text = "Facturar"

        OCULTO_OPCIONES_BOTONES()
        Me.Button_EXPORTAR.Visible = True
        Me.Button_guardar.Text = "Guardar"
        Me.Button_guardar.Enabled = True

        Me.TXT_DOC_CLIENTE.Focus()

        Try
            sql = "SELECT * FROM PROVEEDORES WHERE documento='" & Me.TXT_DOC_CLIENTE.Text & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                TXT_NOM_CLIENTE.Text = row.Item("nombre")
                TXT_DIR_CLIENTE.Text = row.Item("DIRECCION")
                TXT_TELS_CLIENTE.Text = row.Item("TELEFONO")
                TxtMAIL_cliente.Text = row.Item("EMAIL")
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()

        Label30.Visible = False
        Label31.Visible = False
        Label9.Visible = False


        Button_FACTURAR.Visible = False
        Button_EXPORTAR.Visible = False
        Button_guardar.Visible = False
        Button_Regresar.Visible = False

        'Button_guardar_Click(Nothing, Nothing)



        ''LLENADO contactos
        Try
            sql = "SELECT documento, nombre FROM proveedores"
            da_contact_dev_ventas = New MySqlDataAdapter(sql, conex)
            dt_contact_dev_ventas = New DataTable
            da_contact_dev_ventas.Fill(dt_contact_dev_ventas)
            Me.COMBO_NOM_CLIENTE_FILTRO.DataSource = dt_contact_dev_ventas.DefaultView
            Me.COMBO_NOM_CLIENTE_FILTRO.DisplayMember = "nombre"
            Me.COMBO_NOM_CLIENTE_FILTRO.ValueMember = "documento"
            Me.COMBO_NOM_CLIENTE_FILTRO.AutoCompleteSource = AutoCompleteSource.ListItems
            Me.COMBO_NOM_CLIENTE_FILTRO.AutoCompleteMode = AutoCompleteMode.Suggest
            Me.COMBO_NOM_CLIENTE_FILTRO.SelectedItem = Nothing

            Me.COMBO_DOC_CLIENTE_FILTRO.DataSource = dt_contact_dev_ventas.DefaultView
            Me.COMBO_DOC_CLIENTE_FILTRO.DisplayMember = "documento"
            Me.COMBO_DOC_CLIENTE_FILTRO.ValueMember = "documento"
            Me.COMBO_DOC_CLIENTE_FILTRO.AutoCompleteSource = AutoCompleteSource.ListItems
            Me.COMBO_DOC_CLIENTE_FILTRO.AutoCompleteMode = AutoCompleteMode.Suggest
            Me.COMBO_DOC_CLIENTE_FILTRO.SelectedItem = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_contact_dev_ventas.Dispose()
        dt_contact_dev_ventas.Dispose()
        conex.Close()


    End Sub

    Private Sub GRID_VENTAS_nro_dev()
        Try
            sql = "select * from VENTAS WHERE documento='" & TextBox_norFACDEV.Text & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.datagrid_fac_dev.DataSource = dt
            Me.datagrid_fac_dev.Columns(0).Visible = False
            Me.datagrid_fac_dev.Columns(1).Visible = False
            Me.datagrid_fac_dev.Columns(2).HeaderText = "#FACT"
            Me.datagrid_fac_dev.Columns(2).Width = 80
            Me.datagrid_fac_dev.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagrid_fac_dev.Columns(3).Visible = False
            Me.datagrid_fac_dev.Columns(4).HeaderText = "Documento"
            Me.datagrid_fac_dev.Columns(4).Width = 60
            Me.datagrid_fac_dev.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            Me.datagrid_fac_dev.Columns(5).HeaderText = "Cliente"
            Me.datagrid_fac_dev.Columns(5).Width = 80
            Me.datagrid_fac_dev.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagrid_fac_dev.Columns(6).HeaderText = "Fecha"
            Me.datagrid_fac_dev.Columns(6).Width = 90
            Me.datagrid_fac_dev.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagrid_fac_dev.Columns(7).HeaderText = "Totalventa"
            Me.datagrid_fac_dev.Columns(7).Width = 80
            Me.datagrid_fac_dev.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagrid_fac_dev.Columns(8).Visible = False
            Me.datagrid_fac_dev.Columns(8).Visible = False
            Me.datagrid_fac_dev.Columns(10).Visible = False
            Me.datagrid_fac_dev.Columns(11).Visible = False
            Me.datagrid_fac_dev.Columns(12).Visible = False
            Me.datagrid_fac_dev.Columns(13).Visible = False
            Me.datagrid_fac_dev.Columns(14).Visible = False
            Me.datagrid_fac_dev.Columns(15).Visible = False
            Me.datagrid_fac_dev.Columns(16).Visible = False
            Me.datagrid_fac_dev.Columns(17).Visible = False
            Me.datagrid_fac_dev.Columns(18).Visible = False
            Me.datagrid_fac_dev.Columns(19).Visible = False
            Me.datagrid_fac_dev.Columns(20).Visible = False
            Me.datagrid_fac_dev.Columns(21).Visible = False
            Me.datagrid_fac_dev.Columns(22).Visible = False
            Me.datagrid_fac_dev.Columns(23).Visible = False
            Me.datagrid_fac_dev.Columns(24).Visible = False
            Me.datagrid_fac_dev.Columns(25).Visible = False
            Me.datagrid_fac_dev.Columns(26).Visible = False
            Me.datagrid_fac_dev.Columns(27).Visible = False
            Me.datagrid_fac_dev.Columns(28).Visible = False
            Me.datagrid_fac_dev.Columns(29).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

    End Sub

    Private Sub Text_leyenda_TextChanged(sender As Object, e As EventArgs) Handles Text_leyenda.TextChanged

    End Sub

    Private Sub Timer_gridProds_Tick(sender As Object, e As EventArgs) Handles Timer_gridProds.Tick
        Me.Timer_gridProds.Enabled = False
        Me.combobox_BuscarProd.SelectedItem = Nothing
        Me.Cursor = Cursors.WaitCursor

        grid_comprasprods()
        Me.Cursor = Cursors.Default

        Me.NumericUpDown_CANT.Value = 0
        Me.TextBox_valorunitario.Text = 0
        Me.TextBox_Total_prod.Text = 0
        Me.datagrid_productos.CurrentCell = Nothing
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button_NUEVO_CLI_Click(sender As Object, e As EventArgs) Handles Button_NUEVO_CLI.Click

    End Sub

    Private Sub Button_REFRESH_Click(sender As Object, e As EventArgs) Handles Button_REFRESH.Click

    End Sub



    Private Sub Timer_ver_Tick(sender As Object, e As EventArgs) Handles Timer_ver.Tick
        Timer_ver.Enabled = False

        Btn_Ver_editar_Click(Nothing, Nothing)


    End Sub

    Private Sub TextBox_Total_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Total_prod.TextChanged

    End Sub
    Private Sub load_grid_EXPORTAR()
        Try
            sql = "select CONS, FECHA, CODCLIENTE, CLIENTE, ESTADO, DESCARGADO, FACTURADO, NROFAC from DEVOLUCIONES WHERE ESTADO='" & filtro & "'"
            If filtro = "TODO" Then sql = "select CONS, FECHA, CODCLIENTE, CLIENTE, ESTADO, DESCARGADO, FACTURADO, NROFAC from DEVOLUCIONES"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.datagrid_devoluciones.DataSource = dt


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        Me.datagrid_devoluciones.ClearSelection()

        Me.datagrid_devoluciones.Columns(0).Width = 50
        Me.datagrid_devoluciones.Columns(1).Width = 100
        Me.datagrid_devoluciones.Columns(2).Width = 100

        'Me.datagrid_PEDIDOS.Columns(3).Width = 250
        Me.datagrid_devoluciones.Columns(4).Width = 100
        Me.datagrid_devoluciones.Columns(5).Width = 90
        Me.datagrid_devoluciones.Columns(6).Width = 80
        Me.datagrid_devoluciones.Columns(7).Width = 70

        Me.datagrid_devoluciones.ClearSelection()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Cursor = Cursors.WaitCursor

        load_grid_EXPORTAR()


        Try
            'Intentar generar el documento.
            Dim doc As New Document(PageSize.A4.Rotate, 10, 10, 10, 10)
            'Path que guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\LISTADO DE DEVOLUCIONES.pdf"
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
            load_grid_PEDIDOS_CLIENTES()

        End If
        Me.Cursor = Cursors.Default
    End Sub
    Public Sub ExportarLISTADO(ByVal document As Document)
        'Se crea un objeto PDFTable con el numero de columnas del DataGridView.
        Dim datatable As New PdfPTable(datagrid_devoluciones.ColumnCount)
        'Se asignan algunas propiedades para el diseño del PDF.
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(datagrid_devoluciones)

        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER

        'Se crea el encabezado en el PDF.
        Dim encabezado As New Paragraph(comex_nombrecomercial, New Font(Font.Name = "Tahoma", 14, Font.Bold))
        Dim encabezado2 As New Paragraph("LISTADO DE DEVOLUCIONES", New Font(Font.Name = "Arial Balck", 12, Font.Bold))

        'Se crea el texto abajo del encabezado.
        Dim texto As New Phrase("Filtro: " + filtro + Chr(13), New Font(Font.Name = "Arial Narrow", 10, Font.Bold))
        Dim texto2 As New Phrase("Fecha del Reporte: " + Now.Date(), New Font(Font.Name = "Arial Narrow", 10, Font.Bold))
        Dim texto3 As New Phrase("          Generado Por :" + usrnom, New Font(Font.Name = "Arial Narrow", 10, Font.Bold))

        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To datagrid_devoluciones.ColumnCount - 1
            Dim cellhdr As New PdfPCell(New Phrase(datagrid_devoluciones.Columns(i).HeaderText, New Font(Font.Name = "Arial", 10.0F, FontStyle.Bold)))
            'datatable.AddCell(MetroGrid_pdf.Columns(i).HeaderText)
            cellhdr.HorizontalAlignment = Element.ALIGN_CENTER
            cellhdr.BackgroundColor = BaseColor.LIGHT_GRAY
            datatable.AddCell(cellhdr)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1
        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To datagrid_devoluciones.RowCount - 1
            For j As Integer = 0 To datagrid_devoluciones.ColumnCount - 1

                Dim cell As New PdfPCell
                cell.Phrase = New Phrase(datagrid_devoluciones(j, i).Value.ToString, New Font(Font.Name = "Arial Narrow", 8))
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
    Private Sub grid_comprasprods()
        Try
            sql = "SELECT * FROM DEVOLUCIONES_PRODS WHERE documento = " & CInt(Label_consecutivo_dev.Text) & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.datagrid_productos.DataSource = dt
            Me.datagrid_productos.Columns(0).Visible = False
            Me.datagrid_productos.Columns(1).Visible = False
            Me.datagrid_productos.Columns(2).HeaderText = "Código"
            Me.datagrid_productos.Columns(2).Width = 60
            Me.datagrid_productos.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.datagrid_productos.Columns(3).HeaderText = "Producto"
            Me.datagrid_productos.Columns(3).Width = 240
            Me.datagrid_productos.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
            Me.datagrid_productos.Columns(4).HeaderText = "Cant"
            Me.datagrid_productos.Columns(4).Width = 40
            Me.datagrid_productos.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.datagrid_productos.Columns(5).HeaderText = "P/Base"
            Me.datagrid_productos.Columns(5).Width = 50
            Me.datagrid_productos.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.datagrid_productos.Columns(6).HeaderText = "ICO"
            Me.datagrid_productos.Columns(6).Width = 50
            Me.datagrid_productos.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.datagrid_productos.Columns(7).HeaderText = "IVA"
            Me.datagrid_productos.Columns(7).Width = 50
            Me.datagrid_productos.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.datagrid_productos.Columns(8).Visible = False
            Me.datagrid_productos.Columns(9).Visible = False
            Me.datagrid_productos.Columns(10).HeaderText = "Valor/U"
            Me.datagrid_productos.Columns(10).Width = 80
            Me.datagrid_productos.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.datagrid_productos.Columns(11).HeaderText = "TOTAL"
            Me.datagrid_productos.Columns(11).Width = 90
            Me.datagrid_productos.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.datagrid_productos.Columns(12).Visible = False
            Me.datagrid_productos.Columns(13).Visible = False
            Me.datagrid_productos.Columns(14).Visible = False
            Me.datagrid_productos.Columns(15).Visible = False
            Me.datagrid_productos.Columns(16).Visible = False
            Me.datagrid_productos.Columns(17).Visible = False
            Me.datagrid_productos.Columns(18).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()


        Me.TextBoxTotal_Dev.Text = 0
        TextBox_imp_dev.Text = 0
        Try
            For i As Integer = 0 To datagrid_productos.RowCount - 1
                Me.TextBoxTotal_Dev.Text = CDec(Me.TextBoxTotal_Dev.Text) + datagrid_productos.Item("valortotal", i).Value
                Me.TextBox_imp_dev.Text = CDec(Me.TextBox_imp_dev.Text) + datagrid_productos.Item("impuesto2", i).Value
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        Me.TextBoxTotal_Dev.Text = Format(CDec(Me.TextBoxTotal_Dev.Text), "##,##0.00")
        Me.TextBox_imp_dev.Text = Format(CDec(Me.TextBox_imp_dev.Text), "##,##0.00")

        Me.datagrid_productos.ClearSelection()

    End Sub
    Private Sub datos_del_producto()
        Try
            sql = "SELECT * FROM productos where cod=" & CInt(Me.combobox_BuscarProd.SelectedValue) & ""
            da = New MySqlDataAdapter(sql, conex)
            dt_saldos = New DataTable
            da.Fill(dt_saldos)
            For Each row As DataRow In dt_saldos.Rows

                prod_cod = row.Item("cod")
                prod_nom = row.Item("nombre")
                prod_iva = row.Item("iva")
                prod_iva2 = row.Item("iva2")
                PROD_IVATIPO = row.Item("ivaTIPO")
                PROD_IVATIPO2 = row.Item("ivaTIPO2")
                prod_iva1nom = row.Item("impnom1")
                prod_iva2nom = row.Item("impnom2")

                prod_stock = row.Item("stock")
                PROD_INVENTARIADO = row.Item("inventariado")

                PROD_categoria = row.Item("CATEGORIA")
                prod_imagen = row.Item("imagen")
                PROD_DECIMAL = row.Item("DECIMALES")
                'prod_valor = row.Item("valoru")

            Next
        Catch ex As Exception
            saldo = 0
        End Try
        da.Dispose()
        conex.Close()
        TextBox_valorunitario.Text = prod_valor


        If PROD_DECIMAL = "SI" Then NumericUpDown_CANT.DecimalPlaces = 3 Else NumericUpDown_CANT.DecimalPlaces = 0

    End Sub
    Private Sub datos_del_prod_en_factura()
        Try
            sql = "SELECT * FROM ventas_prods where documento=" & CInt(Label_Nofactura.Text) & " and codprod=" & Me.combobox_BuscarProd.SelectedValue & ""
            da = New MySqlDataAdapter(sql, conex)
            dt_saldos = New DataTable
            da.Fill(dt_saldos)
            For Each row As DataRow In dt_saldos.Rows
                Me.NumericUpDown_CANT.Maximum = row.Item("cantidad")
                Me.TextBox_valorunitario.Text = row.Item("valoru")
                prod_valor = row.Item("valoru")
                PROD_COSTO = row.Item("COSTO")
                PROD_COSTO = row.Item("COSTO") / row.Item("cantidad")

            Next
        Catch ex As Exception
            saldo = 0
        End Try
        da.Dispose()
        conex.Close()




    End Sub


    Private Sub RadioButton_pendiente_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Timer_PROD_DATA_BARRAS.Enabled = True

        End If
    End Sub

    Private Sub RadioButton_facturado_KeyDown(sender As Object, e As KeyEventArgs)
        Me.TextBox_Total_prod.Text = CInt(Me.NumericUpDown_CANT.Value) * CInt(TextBox_valorunitario.Text)

    End Sub

    Private Sub datagrid_productos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_productos.CellClick
        Dim row_prod As DataGridViewRow = datagrid_productos.CurrentRow
        prod_cod = CStr(row_prod.Cells("cons").Value) ' LLAVE PRINCIPAL
    End Sub

    Private Sub BUSCA_SALDO_PRODUCTO()
        Me.Cursor = Cursors.WaitCursor
        'saldo
        entran = 0
        salen = 0
        saldo = 0
        Try
            sql = "SELECT sum(entran) as entran, sum(salen) as salen FROM bodega_PRINCIPAL where CodProducto='" & CInt(prod_cod) & "'"
            da_SALDOS = New MySqlDataAdapter(sql, conex)
            dt_saldos = New DataTable
            da_SALDOS.Fill(dt_saldos)
            For Each row As DataRow In dt_saldos.Rows
                entran = row.Item("entran")
                salen = row.Item("salen")
            Next
            saldo = entran - salen
        Catch ex As Exception
            saldo = 0
        End Try

        da_SALDOS.Dispose()
        dt_saldos.Dispose()
        conex.Close()
        SALDO_DEL_PRODUCTO = saldo
        Me.Cursor = Cursors.Default
    End Sub



    Private Sub TextBox_Total_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_Total_prod.KeyPress
        e.KeyChar = ""
    End Sub



    Private Sub datagrid_fac_dev_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_fac_dev.CellClick
        Dim row_VENTA As DataGridViewRow = datagrid_fac_dev.CurrentRow
        ID_VENTA_dev = CInt(row_VENTA.Cells("DOCUMENTO").Value)
        Label_Nofactura.Text = CInt(row_VENTA.Cells("DOCUMENTO").Value)


        Me.TXT_DOC_CLIENTE.Text = CInt(row_VENTA.Cells("DOCcliente").Value)

        Me.TXT_NOM_CLIENTE.Text = CStr(row_VENTA.Cells("clientenom").Value)

        If CStr(row_VENTA.Cells("devolucion").Value) <> "" Then TIENE_DEVOLUCION = "SI" Else TIENE_DEVOLUCION = ""

    End Sub

    Private Sub TextBox_valorunitario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_valorunitario.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub Form_devoluciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        id_devolucion = ""

    End Sub

    Private Sub ComboBox_mes_general_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_mes_general.SelectionChangeCommitted
        mes_num = DateTime.ParseExact(Me.ComboBox_mes_general.Text, "MMMM", CultureInfo.CurrentCulture).Month
        mes_num_text_general = CStr(mes_num)
        If mes_num <= 9 Then mes_num_text_general = "0" & CStr(mes_num)

        GRID_VENTAS_fecha_dev()


    End Sub

    Private Sub ComboBox_periodoFiltro_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_periodoFiltro.SelectionChangeCommitted
        mes_num = DateTime.ParseExact(Me.ComboBox_periodoFiltro.Text, "MMMM", CultureInfo.CurrentCulture).Month
        mes_num_text_general = CStr(mes_num)
        If mes_num <= 9 Then mes_num_text_general = "0" & CStr(mes_num)


        load_grid_PEDIDOS_CLIENTES()

    End Sub

    Private Sub TXT_DOC_CLIENTE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_DOC_CLIENTE.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub TextBox_DV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_DV.KeyPress
        e.KeyChar = ""

    End Sub

    Private Sub TXT_NOM_CLIENTE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_NOM_CLIENTE.KeyPress
        e.KeyChar = ""

    End Sub

    Private Sub TXT_TELS_CLIENTE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_TELS_CLIENTE.KeyPress
        e.KeyChar = ""

    End Sub

    Private Sub TXT_DIR_CLIENTE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_DIR_CLIENTE.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub TxtMAIL_cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMAIL_cliente.KeyPress
        e.KeyChar = ""

    End Sub

    Private Sub COMBO_DOC_CLIENTE_FILTRO_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles COMBO_DOC_CLIENTE_FILTRO.SelectionChangeCommitted
        Timer_clientes.Enabled = True

    End Sub

    Private Sub COMBO_NOM_CLIENTE_FILTRO_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles COMBO_NOM_CLIENTE_FILTRO.SelectionChangeCommitted
        Timer_clientes.Enabled = True

    End Sub

    Private Sub Text_leyenda_LostFocus(sender As Object, e As EventArgs) Handles Text_leyenda.LostFocus
        sql = "UPDATE devoluciones SET OBSERVACIONES='" & Text_leyenda.Text & "' WHERE CONS=" & CLng(Label_consecutivo_dev.Text) & ""
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
    End Sub

    Private Sub combobox_BuscarProd_SelectedValueChanged(sender As Object, e As EventArgs) Handles combobox_BuscarProd.SelectedValueChanged

    End Sub
End Class