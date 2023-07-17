Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Environment
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.ComponentModel
Imports System.Globalization
Imports Microsoft.Office.Interop

Public Class Form_movimientos

    Dim autorizacion_doc As String
    Dim imprimir_inv_actual As String = ""
    Dim alto_pag As Integer = 0
    Dim total_inv_actual As String = ""
    Dim CodDocumento As Long = 0
    Dim TipoDocumento As String = ""
    Dim contabilizado As String = ""
    Dim desktop2 As String = Environment.GetFolderPath(SpecialFolder.DesktopDirectory)

    Dim PROD_SALDO, PROD_ENTRAN, PROD_SALEN As String
    Dim prod_cod, prod_barras, prod_nom, prod_desc, prod_valor, PROD_COSTO, PROD_COSTO_TOTAL, prod_iva, PROD_DECIMAL As String
    Dim SALDO_DEL_PRODUCTO As Integer = 0
    Dim entran, salen, saldo As Integer
    Dim mousex As Integer = 0
    Dim mousey As Integer = 0
    Dim mouseDown1 As Boolean = False

    Dim ctapucFULL1 As String = ""
    Dim ctapuc1() As String

    Dim ctapucFULL2 As String = ""
    Dim ctapuc2() As String

    Dim mes_num_text As String

    Dim mes_num As Integer
    Dim mes_num_text_general As String

    Public da_grid_movs As New MySqlDataAdapter
    Public dt_grid_movs As New DataTable

    Public da_prodscombo_movs As New MySqlDataAdapter
    Public dt_prodscombo_movs As New DataTable



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


    Private Sub Form_movimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_movimientos_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.datagrid_movimientos.BringToFront()


        'oculto el tab
        Me.TabControl_detalle.SelectTab(0)


        mes_num = DateTime.Now.Month()
        mes_num_text = CStr(mes_num)
        If mes_num <= 9 Then mes_num_text = "0" & CStr(mes_num)
        ComboBox_PERIODO.SelectedIndex = mes_num_text - 1
        NumericUpDown_anno_mov.Value = DateTime.Now.Year

        load_contactos()

        load_combo_docs()

        Timer__ver_movimientos.Enabled = True



    End Sub


    Private Sub load_contactos()

        ''LLENADO contactos
        Try
            sql = "SELECT documento, nombre FROM proveedores order by nombre"
            da_contact_mov = New MySqlDataAdapter(sql, conex)
            DT_contact_mov = New DataTable
            da_contact_mov.Fill(DT_contact_mov)
            Me.ComboBox_tercero.DataSource = DT_contact_mov.DefaultView
            Me.ComboBox_tercero.DisplayMember = "nombre"
            Me.ComboBox_tercero.ValueMember = "documento"
            Me.ComboBox_tercero.AutoCompleteSource = AutoCompleteSource.ListItems
            Me.ComboBox_tercero.AutoCompleteMode = AutoCompleteMode.Suggest
            Me.ComboBox_tercero.Text = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_contact_mov.Dispose()
        DT_contact_mov.Dispose()
        conex.Close()
    End Sub


    Private Sub load_combo_docs()

        Try
            sql = "SELECT CONS, concat(documento) as documento FROM data_docs WHERE ESTADO='SI' AND CODIGO='MI' and padre='NO'"
            da_COMBO_docs_conta_COMP = New MySqlDataAdapter(sql, conex)
            dt_combo_docs_conta_COMP = New DataTable
            da_COMBO_docs_conta_COMP.Fill(dt_combo_docs_conta_COMP)
            Me.Combobox_tipo_mov.DataSource = dt_combo_docs_conta_COMP.DefaultView
            Me.Combobox_tipo_mov.DisplayMember = "documento"
            Me.Combobox_tipo_mov.ValueMember = "cons"
            Me.Combobox_tipo_mov.AutoCompleteSource = AutoCompleteSource.ListItems
            Me.Combobox_tipo_mov.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_COMBO_docs_conta_COMP.Dispose()
        dt_combo_docs_conta_COMP.Dispose()
        conex.Close()

        Combobox_tipo_mov.Text = Nothing

    End Sub
    Private Sub Btn_Ver_editar_Click(sender As Object, e As EventArgs) Handles Btn_Ver_editar.Click
        If PERMISO_1(14) = "NO" Or PERMISO_1(14) = Nothing Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub


        contabilizado = ""
        If CodDocumento = 0 Then MsgBox("Seleccione un Documento para mostrar.", vbInformation) : Exit Sub

        If PERMISO_1(13) = "NO" Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub

        llena_combo_bodegas()
        Panel_datamov.Visible = True

        Try
            sql = "SELECT * FROM movimientos WHERE documento = " & CodDocumento & " and tipodocumento='" & TipoDocumento & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                Label_consecutivo.Text = row.Item("documento")
                Label_fecha.Text = row.Item("fecha")
                Me.TextBox_responsable.Text = row.Item("empleado")
                Me.Text_leyenda.Text = row.Item("observaciones")
                Me.Label_estado_movimiento.Text = row.Item("estado")
                Me.ComboBox_DESTINO.Text = row.Item("DESTINO")
                Me.ComboBox_tercero.SelectedValue = row.Item("DOCtercero")
                contabilizado = row.Item("contabilizado")
                TextBox_ref.Text = row.Item("referencia")

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()

        Me.Label_tipomovimiento.Visible = True : Me.Label_tipomovimiento.Text = TipoDocumento
        Me.Combobox_tipo_mov.Visible = False : Me.Label_tipomov.Visible = False
        Me.Combobox_tipo_mov.Enabled = False
        Me.Combobox_tipo_mov.Text = TipoDocumento

        Me.ComboBox_PERIODO.Visible = False
        Me.Label_periodo.Visible = False
        Me.Panel_dock.Visible = False

        que_movimiento = "Ver"

        Me.combobox_BuscarProd.Enabled = True
        Me.NumericUpDown_CANT.Enabled = True
        Me.NumericUpDown_vrUnitario.Enabled = True
        Me.TextBox_Total.Enabled = False
        Me.Text_leyenda.Enabled = True
        Me.TextBox_responsable.Enabled = False


        Me.ButtonDescargar.Visible = True
        Me.Button_guardar.Visible = False
        Me.Button_guardar.Text = "Guardar"
        Me.ButtonDescargar.Enabled = True

        Me.Button_anular.Visible = True


        Me.Button_agregar_prod.Visible = True
        Me.button_Quitar_Prod.Visible = True
        Me.Button_agregar_prod.Enabled = True
        Me.button_Quitar_Prod.Enabled = True
        Me.Button_exportar.Visible = True  'exportar
        Text_leyenda.Enabled = True


        RadioButton_entrada.Visible = False
        RadioButton_salida.Visible = False
        RadioButton_entrada.Enabled = False
        RadioButton_salida.Enabled = False
        Panel_detalles.Enabled = True

        ' habilito imprtar
        If Me.Combobox_tipo_mov.Text.ToString = "Inventario Inicial" Then Button_importar.Visible = True

        If Label_estado_movimiento.Text = "DESCARGADO" Then
            Button_importar.Visible = False
            Panel_detalles.Enabled = False
            RadioButton_entrada.Enabled = False
            RadioButton_salida.Enabled = False

            Me.Button_guardar.Visible = False

            Me.Button_anular.Visible = True
            Me.ButtonDescargar.Enabled = False
            Me.Button_agregar_prod.Visible = False
            Me.button_Quitar_Prod.Visible = False
            Me.Button_exportar.Visible = True


            'Me.MetroTabPage2.Show()
            'Me.MetroTabPage2.Parent = Me.TabControl_detalle

            Me.ComboBox_tercero.Enabled = False



        End If
        If Label_estado_movimiento.Text = "FINALIZADO" Then
            Text_leyenda.Enabled = False

        End If


        If Label_estado_movimiento.Text = "ANULADO" Then
            Me.Button_anular.Visible = False
            Me.ButtonDescargar.Visible = False
            Me.Button_agregar_prod.Visible = False
            Me.button_Quitar_Prod.Visible = False
            Me.Button_exportar.Visible = True
        End If



        Me.ComboBox_DESTINO.Visible = True
        Me.ComboBox_DESTINO.Enabled = False
        Me.ComboBox_ORIGEN.Visible = False


        If (TipoDocumento.Contains("Entrada") = True) Then
            Me.ButtonDescargar.Text = "Enviar a Bodega"
            RadioButton_entrada.Checked = True
        End If

        If TipoDocumento = "Inventario Inicial" Then
            Me.ButtonDescargar.Text = "Enviar a Bodega"
            RadioButton_entrada.Checked = True

        End If

        If TipoDocumento = "Ajuste de Inventario" Then
            Me.ButtonDescargar.Text = "Actualizar Bodega"

            If Label_estado_movimiento.Text = "DESCARGADO" Then
                RadioButton_entrada.Enabled = False
                RadioButton_salida.Enabled = False
            End If
            If Label_estado_movimiento.Text = "SIN DESCARGAR" Then
                RadioButton_entrada.Enabled = True
                RadioButton_salida.Enabled = True
                RadioButton_entrada.Visible = True
                RadioButton_salida.Visible = True
            End If

        End If

        If TipoDocumento.Contains("Salida") = True Then
            Me.ButtonDescargar.Text = "Retirar de Bodega"
            RadioButton_salida.Checked = True

        End If


        If TipoDocumento = "Traslado de Mercancia" Then
            Me.ButtonDescargar.Text = "Actualizar Bodegas"
            ComboBox_ORIGEN.Visible = True
            ComboBox_DESTINO.Visible = True
            Label_destino.Visible = True
            Label_origen.Visible = True
        End If

        Label6.Visible = False
        NumericUpDown_anno_mov.Visible = False


        Timer_gridProds.Enabled = True
        datagrid_movimientos.Visible = False
        TextBox_buscarprod.Focus()
    End Sub


    Private Sub Combo_tipo_mov_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Combobox_tipo_mov.SelectionChangeCommitted

        Timer__ver_movimientos.Enabled = True

    End Sub
    Private Sub load_movimientos()

        datagrid_movimientos.DataSource = Nothing
        datagrid_movimientos.Rows.Clear()
        datagrid_movimientos.Columns.Clear()
        My.Application.DoEvents()

        Me.datagrid_movimientos.Refresh()

        Try
            sql = "select * from movimientos where 
tipodocumento='" & Combobox_tipo_mov.Text & "' and month(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & mes_num_text_general & "' and year(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & NumericUpDown_anno_mov.Value & "'"

            If Combobox_tipo_mov.Text = Nothing Then
                sql = "select * from movimientos where 
 month(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & mes_num_text_general & "' and year(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & NumericUpDown_anno_mov.Value & "'"
            End If

            If CheckBox1.Checked = False Then
                sql = sql + " AND ESTADO<>'ANULADO'"
            End If


            da_grid_movs = New MySqlDataAdapter(sql, conex)
            dt_grid_movs = New DataTable
            da_grid_movs.Fill(dt_grid_movs)
            Me.datagrid_movimientos.DataSource = dt_grid_movs
            Me.datagrid_movimientos.Columns(0).Visible = False
            Me.datagrid_movimientos.Columns(1).HeaderText = "#Doc"
            Me.datagrid_movimientos.Columns(1).Width = 60
            Me.datagrid_movimientos.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagrid_movimientos.Columns(2).HeaderText = "Tipo Documento"
            Me.datagrid_movimientos.Columns(2).Width = 120
            Me.datagrid_movimientos.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagrid_movimientos.Columns(3).Visible = False
            Me.datagrid_movimientos.Columns(4).HeaderText = "Bodega Origen"
            Me.datagrid_movimientos.Columns(4).Width = 120
            Me.datagrid_movimientos.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagrid_movimientos.Columns(5).Visible = False
            Me.datagrid_movimientos.Columns(6).HeaderText = "Bodega Destino"
            Me.datagrid_movimientos.Columns(6).Width = 120
            Me.datagrid_movimientos.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagrid_movimientos.Columns(7).HeaderText = "DocTercero"
            Me.datagrid_movimientos.Columns(7).Width = 100
            Me.datagrid_movimientos.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagrid_movimientos.Columns(8).HeaderText = "Tercero"
            Me.datagrid_movimientos.Columns(8).Width = 100
            Me.datagrid_movimientos.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagrid_movimientos.Columns(9).HeaderText = "Fecha"
            Me.datagrid_movimientos.Columns(9).Width = 100
            Me.datagrid_movimientos.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagrid_movimientos.Columns(10).Visible = False
            Me.datagrid_movimientos.Columns(11).Visible = False
            Me.datagrid_movimientos.Columns(12).Visible = False
            Me.datagrid_movimientos.Columns(13).HeaderText = "Estado"
            Me.datagrid_movimientos.Columns(13).Width = 120
            Me.datagrid_movimientos.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagrid_movimientos.Columns(14).Visible = False
            Me.datagrid_movimientos.Columns(15).Visible = False
            Me.datagrid_movimientos.Columns(16).HeaderText = "Ref"
            Me.datagrid_movimientos.Columns(16).Width = 60
            Me.datagrid_movimientos.Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            'Dim btn As New DataGridViewButtonColumn()

            'datagrid_movimientos.Columns.Add(btn)
            'btn.HeaderText = ""
            'btn.Text = "Consultar"
            'btn.Name = "btn"
            'btn.UseColumnTextForButtonValue = True


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_grid_movs.Dispose()
        dt_grid_movs.Dispose()
        conex.Close()

        datagrid_movimientos.ClearSelection()

        autorizacion_doc = ""
        Try
            sql = "SELECT autorizacion FROM data_docs WHERE cons=" & CInt(Combobox_tipo_mov.SelectedValue) & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                autorizacion_doc = row.Item("autorizacion")

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
    End Sub


    Private Sub loads_productos(ByVal critero As String)
        'LLENADO DE PRODUCTOS COMBO
        Try
            If critero = "" Then sql = "SELECT concat(tipo,' - ',categoria,'  | ',nombre,' ',ref,' ',presentacion) as nombrep, productos.* FROM productos where inventariado='SI' and tipo<>'SERVICIOS' order by tipo, categoria, nombre"
            If critero = "nombre" Then sql = "SELECT concat(tipo,' - ',categoria,'  | ',nombre,' ',ref,' ',presentacion) as nombrep, productos.* FROM productos where inventariado='SI' and tipo<>'SERVICIOS' and nombre like '%" & CStr(TextBox_buscarprod.Text) & "%' order by tipo, categoria, nombre"
            If critero = "referencia" Then sql = "SELECT concat(tipo,' - ',categoria,'  | ',nombre,' ',ref,' ',presentacion) as nombrep, productos.* FROM productos where inventariado='SI' and tipo<>'SERVICIOS' and ref='" & CStr(TextBox_buscarprod.Text) & "' order by tipo, categoria, nombre"
            If critero = "barras" Then sql = "SELECT concat(tipo,' - ',categoria,'  | ',nombre,' ',ref,' ',presentacion) as nombrep, productos.* FROM productos where inventariado='SI' and tipo<>'SERVICIOS' and codbarras='" & TextBox_buscarprod.Text & "' order by tipo, categoria, nombre"
            If critero = "codigo" Then sql = "SELECT concat(tipo,' - ',categoria,'  | ',nombre,' ',ref,' ',presentacion) as nombrep, productos.* FROM productos where inventariado='SI' and tipo<>'SERVICIOS' and cod='" & TextBox_buscarprod.Text & "' order by tipo, categoria, nombre"


            da_prodscombo_movs = New MySqlDataAdapter(sql, conex)
            dt_prodscombo_movs = New DataTable
            da_prodscombo_movs.Fill(dt_prodscombo_movs)
            Me.Datagrid_prods_catalogo.DataSource = dt_prodscombo_movs
            Me.combobox_BuscarProd.DataSource = dt_prodscombo_movs.DefaultView
            Me.combobox_BuscarProd.DisplayMember = "nombrep"
            Me.combobox_BuscarProd.ValueMember = "cod"
            Me.combobox_BuscarProd.AutoCompleteSource = AutoCompleteSource.ListItems
            Me.combobox_BuscarProd.AutoCompleteMode = AutoCompleteMode.Suggest
            Me.combobox_BuscarProd.SelectedItem = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_prodscombo_movs.Dispose()
        dt_prodscombo_movs.Dispose()
        conex.Close()
    End Sub



    Private Sub Button_guardarCompra_Click(sender As Object, e As EventArgs) Handles Button_guardar.Click
        If PERMISO_1(14) = "NO" Or PERMISO_1(14) = Nothing Then MsgBox("No está autorizado.", vbExclamation) : Exit Sub


        'If ComboBox_tercero.Text = "" Then
        '    MsgBox("Debes seleccionar un tercero.", vbInformation)
        '    Exit Sub
        'End If


        ' si esta creando un nuevo movimiento ________________________
        If Me.Button_guardar.Text = "Continuar" Then

            If Me.ComboBox_DESTINO.Text = Nothing Then
                MsgBox("Seleccione una bodega.", vbInformation)
                Exit Sub
            End If



            If Me.Combobox_tipo_mov.Text.ToString.Contains("Salida") = True Then
                sql = "INSERT INTO movimientos (documento, tipoDocumento, CODORIGEN, ORIGEN, CodDestino, Destino, doctercero, tercero, fecha, empleadoCod, empleado, Observaciones, Estado, referencia)" &
                      "VALUES (" & CLng(Me.Label_consecutivo.Text) & ",'" & Me.Combobox_tipo_mov.Text & "',0,'N/A'," & Me.ComboBox_DESTINO.SelectedValue & ",'" & Me.ComboBox_DESTINO.Text.ToString & "','" & Me.ComboBox_tercero.SelectedValue & "','" & Me.ComboBox_tercero.Text & "','" & DateTime.Now.ToShortDateString & "','" & usrdoc & "','" & usrnom & "','" & Me.Text_leyenda.Text & "','SIN DESCARGAR', '" & TextBox_ref.Text & "')"
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


                'loads_productos("")

                Me.Button_agregar_prod.Visible = True : Me.Button_agregar_prod.Enabled = True
                Me.button_Quitar_Prod.Visible = True : Me.button_Quitar_Prod.Enabled = True

                Me.Button_exportar.Visible = True  'exportar
                Me.ButtonDescargar.Visible = True
                Me.NumericUpDown_vrUnitario.Text = 0
                Me.Label_estado_movimiento.Text = "SIN DESCARGAR"

                Me.combobox_BuscarProd.Enabled = True
                Me.NumericUpDown_CANT.Enabled = True
                Me.NumericUpDown_vrUnitario.Enabled = True

                Me.Panel_detalles.Enabled = True
                'Me.Label_info.Text = "Se Creó el documento, ahora puede agregar productos." : Me.Label_info.Visible = True
                'Me.Button_info.Visible = True
                Me.Timer_alerta_stock.Enabled = True
                Me.Button_guardar.Text = "Guardar"
                Button_guardar.Visible = False
                Button_anular.Visible = True
                Button_GUARDAR_REF.Visible = True
            End If


            If (Me.Combobox_tipo_mov.Text.ToString.Contains("Entrada") = True) Or Me.Combobox_tipo_mov.Text.ToString = "Inventario Inicial" Or Combobox_tipo_mov.Text.ToString = "Ajuste de Inventario" Then

                ' habilito imprtar
                If Me.Combobox_tipo_mov.Text.ToString = "Inventario Inicial" Then Button_importar.Visible = True

                sql = "INSERT INTO movimientos (documento, tipoDocumento, CODORIGEN, ORIGEN, CodDestino, Destino, doctercero, tercero, fecha, empleadoCod, empleado, Observaciones, Estado, REFERENCIA)" &
                      "VALUES (" & CLng(Me.Label_consecutivo.Text) & ",'" & Me.Combobox_tipo_mov.Text & "',0,'N/A'," & CInt(Me.ComboBox_DESTINO.SelectedValue.ToString) & ",'" & Me.ComboBox_DESTINO.Text.ToString & "','" & Me.ComboBox_tercero.SelectedValue & "','" & Me.ComboBox_tercero.Text & "','" & DateTime.Now.ToShortDateString & "','" & usrdoc & "','" & usrnom & "','" & Me.Text_leyenda.Text & "','SIN DESCARGAR','" & TextBox_ref.Text & "')"
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

                If Me.Combobox_tipo_mov.Text.ToString = "Ajuste de Inventario" Then
                    RadioButton_entrada.Visible = True
                    RadioButton_salida.Visible = True
                    RadioButton_entrada.Enabled = True
                    RadioButton_salida.Enabled = True
                End If


                Me.Button_agregar_prod.Visible = True : Me.Button_agregar_prod.Enabled = True
                Me.button_Quitar_Prod.Visible = True : Me.button_Quitar_Prod.Enabled = True

                Me.Button_exportar.Visible = True  'exportar
                Me.ButtonDescargar.Visible = True
                Me.NumericUpDown_vrUnitario.Text = 0
                Me.Label_estado_movimiento.Text = "SIN DESCARGAR"

                Me.combobox_BuscarProd.Enabled = True
                Me.NumericUpDown_CANT.Enabled = True
                Me.NumericUpDown_vrUnitario.Enabled = True

                Me.Timer_alerta_stock.Enabled = True
                Me.Panel_detalles.Enabled = True
                Me.Button_guardar.Text = "Guardar"
                Button_guardar.Visible = False
                Button_anular.Visible = True


            End If



            ' si esta creando un  traslado y se selecciona la misma bodega. 
            If Me.ComboBox_DESTINO.Text = ComboBox_ORIGEN.Text And Combobox_tipo_mov.Text = "Traslado de Mercancia" And Me.Button_guardar.Text = "Continuar" Then
                MsgBox("No puede Trasladar a la misma bodega.", vbInformation)
                Exit Sub
            End If

            ' si esta creando un  traslado y no selecciono bodegas. 
            ' o dejó alguna vacia
            If Me.Button_guardar.Text = "Continuar" And Combobox_tipo_mov.Text = "Traslado de Mercancia" Then
                If (Me.ComboBox_DESTINO.Text = "" Or ComboBox_ORIGEN.Text = "") Then
                    MsgBox("Debe seleccionar bodega de origen y destino para realizar un traslado.", vbInformation)
                    Exit Sub
                End If
            End If

            If Me.Combobox_tipo_mov.Text.ToString = "Traslado de Mercancia" Then
                sql = "INSERT INTO movimientos (documento, tipoDocumento, CODORIGEN, ORIGEN, CodDestino, Destino, doctercero, tercero, fecha, empleadoCod, empleado, Observaciones, Estado, REFERENCIA)" &
                      "VALUES (" & CLng(Me.Label_consecutivo.Text) & ",'" & Me.Combobox_tipo_mov.Text & "'," & CInt(Me.ComboBox_ORIGEN.SelectedValue.ToString) & ",'" & Me.ComboBox_ORIGEN.Text.ToString & "'," & CInt(Me.ComboBox_DESTINO.SelectedValue.ToString) & ",'" & Me.ComboBox_DESTINO.Text.ToString & "','" & Me.ComboBox_tercero.SelectedValue & "','" & Me.ComboBox_tercero.Text & "','" & DateTime.Now.ToShortDateString & "','" & usrdoc & "','" & usrnom & "','" & Me.Text_leyenda.Text & "','SIN DESCARGAR','" & TextBox_ref.Text & "')"
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


                'loads_productos("")

                Me.Button_agregar_prod.Visible = True : Me.Button_agregar_prod.Enabled = True
                Me.button_Quitar_Prod.Visible = True : Me.button_Quitar_Prod.Enabled = True

                Me.Button_exportar.Visible = True  'exportar
                Me.ButtonDescargar.Visible = True
                Me.NumericUpDown_vrUnitario.Text = 0
                Me.Label_estado_movimiento.Text = "SIN DESCARGAR"

                Me.combobox_BuscarProd.Enabled = True
                Me.NumericUpDown_CANT.Enabled = True
                Me.NumericUpDown_vrUnitario.Enabled = True
                Me.Panel_detalles.Enabled = True
                'Me.Label_info.Text = "Se Creó el documento, ahora puede agregar productos." : Me.Label_info.Visible = True
                'Me.Button_info.Visible = True
                Me.Timer_alerta_stock.Enabled = True
                Me.Button_guardar.Text = "Guardar"
                Button_guardar.Visible = False
                Button_anular.Visible = True

            End If

        End If

        Me.ComboBox_DESTINO.Enabled = False
        Me.ComboBox_ORIGEN.Enabled = False
        Me.ComboBox_tercero.Enabled = False
        Me.TextBox_ref.Enabled = False

    End Sub



    Private Sub NumericUpDown1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NumericUpDown_CANT.KeyPress

        'If Me.TextBox_valorunitario.Text = "" Then Me.TextBox_valorunitario.Text = 0
        'If PROD_DECIMAL = "NO" Then Me.TextBox_Total.Text = CInt(Me.NumericUpDown_CANT.Value) * CInt(TextBox_valorunitario.Text)
        'If PROD_DECIMAL = "SI" Then Me.TextBox_Total.Text = CDec(Me.NumericUpDown_CANT.Value) * CDec(TextBox_valorunitario.Text)


    End Sub



    Private Sub TextBoxTotalDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxTotalDoc1.KeyPress
        e.KeyChar = ""
    End Sub


    Private Sub TextBox_Total_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_Total.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub Button_agregar_prod_Click(sender As Object, e As EventArgs) Handles Button_agregar_prod.Click

        If PERMISO_1(14) = "NO" Or PERMISO_1(14) = Nothing Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub

        If Me.Label_estado_movimiento.Text = "Nuevo" Then
            MsgBox("Antes de agregar productos a la lista debe guardar.", vbIgnore) : Exit Sub
        End If




        If NumericUpDown_CANT.Value = 0 Then MsgBox("Falta la Cantidad.") : Exit Sub
        'If Me.NumericUpDown_vrUnitario.Value = 0 Then MsgBox("Falta el valor unitario.") : Exit Sub

        If prod_cod = "" Or prod_cod = "0" Then
            Exit Sub
        End If


        Me.TextBox_Total.Text = Math.Round((CDec(Me.NumericUpDown_CANT.Value) * CDec(NumericUpDown_vrUnitario.Text)), 2)


        Dim ROL_PROD As String = ""
        If Combobox_tipo_mov.Text = "Inventario Inicial" Or (Me.Combobox_tipo_mov.Text.Contains("Entrada") = True) Then ROL_PROD = "ENTRAN" : RadioButton_entrada.Checked = True
        If (Me.Combobox_tipo_mov.Text.Contains("Salida") = True) Or Combobox_tipo_mov.Text = "Traslado de Mercancia" Then ROL_PROD = "SALEN" : RadioButton_salida.Checked = True

        If Combobox_tipo_mov.Text = "Ajuste de Inventario" And RadioButton_entrada.Checked = False And RadioButton_salida.Checked = False Then
            MsgBox("Al hacer ajustes al inventario, debe elejir entrada o salida.", vbInformation)
            Exit Sub
        End If

        If RadioButton_entrada.Checked = True Then ROL_PROD = "ENTRAN"
        If RadioButton_salida.Checked = True Then ROL_PROD = "SALEN"

        Dim nuevosaldo As String = "0"
        If ROL_PROD = "ENTRAN" Then nuevosaldo = CDec(Label_saldo_actual.Text) + CDec(NumericUpDown_CANT.Value)
        If ROL_PROD = "SALEN" Then nuevosaldo = CDec(Label_saldo_actual.Text) - CDec(NumericUpDown_CANT.Value)

        nuevosaldo = Format(CDec(nuevosaldo), "##,##0.00")

        Me.Cursor = Cursors.WaitCursor
        Dim vrunit As String = FormatNumber(CDec(NumericUpDown_vrUnitario.Value), 2).ToString.Replace(".", "")
        TextBox_Total.Text = CDec(TextBox_Total.Text)
        sql = "INSERT INTO movimientos_prods (documento, tipodoc, codprod, producto, cantidad, valoru, valortotal, estado, DECI, lote, vence, ROL, saldoant, nuevosaldo)" &
              "VALUES (" & CInt(Me.Label_consecutivo.Text) & ",'" & CStr(Me.Combobox_tipo_mov.Text) & "','" & CLng(Me.combobox_BuscarProd.SelectedValue) & "','" & Label20.Text & "','" & CStr(NumericUpDown_CANT.Value) & "','" & vrunit & "','" & CStr(TextBox_Total.Text) & "','SIN DESCARGAR','" & PROD_DECIMAL & "','" & TextBox_lote.Text & "','','" & ROL_PROD & "','" & Label_saldo_actual.Text & "','" & nuevosaldo & "')"
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



        Timer_gridProds.Enabled = True
        Me.datagrid_productos.Enabled = True



        TextBox_buscarprod.Focus()
        prod_cod = ""
    End Sub

    Private Sub button_Quitar_Prod_Click(sender As Object, e As EventArgs) Handles button_Quitar_Prod.Click
        If PERMISO_1(14) = "NO" Or PERMISO_1(14) = Nothing Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub



        If prod_cod = 0 Then MsgBox("Debe Seleccionar un producto.", vbInformation) : Exit Sub

        Dim RTA As String
        RTA = MsgBox("Confirma que desea eliminar?.", MsgBoxStyle.Question + MsgBoxStyle.YesNo)

        If RTA = 6 Then
            sql = "delete from movimientos_prods where cons=" & CInt(prod_cod) & " and tipodoc='" & Me.Combobox_tipo_mov.Text & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                MsgBox("Error al Borrar el Registro.")
                Exit Sub
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()
        End If

        Me.Timer_gridProds.Enabled = True

    End Sub

    Private Sub Timer_gridProds_Tick(sender As Object, e As EventArgs) Handles Timer_gridProds.Tick
        Me.Timer_gridProds.Enabled = False

        grid_movimientos()
        datagrid_productos.ClearSelection()

        Label20.Text = "-"
        Label1.Text = "-"

        Label_saldo_actual.Text = 0
        'Label_saldo_lote.Text = 0


        TextBox_buscarprod.Text = ""
        NumericUpDown_vrUnitario.Value = 0

        Me.NumericUpDown_CANT.Value = 0
        Me.TextBox_Total.Text = 0


        Me.datagrid_productos.CurrentCell = Nothing
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub grid_movimientos()
        Me.Cursor = Cursors.WaitCursor

        Try
            sql = "SELECT * FROM movimientos_prods WHERE documento = " & CInt(Label_consecutivo.Text) & " and tipodoc='" & Me.Combobox_tipo_mov.Text & "' ORDER BY CONS DESC"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.datagrid_productos.DataSource = dt
            Me.datagrid_productos.Columns(0).Visible = False
            Me.datagrid_productos.Columns(1).Visible = False
            Me.datagrid_productos.Columns(2).Visible = False
            Me.datagrid_productos.Columns(3).HeaderText = "Código"
            Me.datagrid_productos.Columns(3).Width = 50
            Me.datagrid_productos.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagrid_productos.Columns(4).HeaderText = "PRODUCTO"
            Me.datagrid_productos.Columns(4).Width = 370
            Me.datagrid_productos.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.datagrid_productos.Columns(5).HeaderText = "Cant"
            Me.datagrid_productos.Columns(5).Width = 40
            Me.datagrid_productos.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.datagrid_productos.Columns(6).HeaderText = "Valor"
            Me.datagrid_productos.Columns(6).Width = 60
            Me.datagrid_productos.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.datagrid_productos.Columns(7).HeaderText = "Total"
            Me.datagrid_productos.Columns(7).Width = 70
            Me.datagrid_productos.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.datagrid_productos.Columns(8).Visible = False
            Me.datagrid_productos.Columns(9).Visible = False
            Me.datagrid_productos.Columns(10).HeaderText = "Lote"
            Me.datagrid_productos.Columns(10).Width = 50
            Me.datagrid_productos.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.datagrid_productos.Columns(11).HeaderText = "Vence"
            Me.datagrid_productos.Columns(11).Width = 70
            Me.datagrid_productos.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.datagrid_productos.Columns(12).HeaderText = "Rol"
            Me.datagrid_productos.Columns(12).Width = 70
            Me.datagrid_productos.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.datagrid_productos.Columns(13).Visible = False
            Me.datagrid_productos.Columns(14).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()




        Me.TextBoxTotalDoc1.Text = 0
        Me.TextBoxtotaldoc2.Text = 0

        Try
            For i As Integer = 0 To datagrid_productos.RowCount - 1
                If datagrid_productos.Item("ROL", i).Value = "ENTRAN" Then Me.TextBoxTotalDoc1.Text = CDec(Me.TextBoxTotalDoc1.Text) + CDec(datagrid_productos.Item("valortotal", i).Value)
                If datagrid_productos.Item("ROL", i).Value = "SALEN" Then Me.TextBoxtotaldoc2.Text = CDec(Me.TextBoxtotaldoc2.Text) + CDec(datagrid_productos.Item("valortotal", i).Value)

            Next
            Me.TextBoxTotalDoc1.Text = Format(CDec(Me.TextBoxTotalDoc1.Text), "##,##0.00")  ' SIN REDONDEAR
            Me.TextBoxTotalDoc1.Text = Format(CDec(Me.TextBoxTotalDoc1.Text), "##,##0")    ' REDONEADO

            Me.TextBoxtotaldoc2.Text = Format(CDec(Me.TextBoxtotaldoc2.Text), "##,##0.00")  ' SIN REDONDEAR
            Me.TextBoxtotaldoc2.Text = Format(CDec(Me.TextBoxtotaldoc2.Text), "##,##0")    ' REDONEADO

        Catch ex As Exception
            'MsgBox(ex.Message.ToString)
        End Try


    End Sub



    Private Sub datos_del_producto(ByVal tipo As String)
        If tipo = "combo" Then sql = "SELECT * FROM productos where cod='" & CStr(Me.combobox_BuscarProd.SelectedValue) & "' AND inventariado='SI'"
        If tipo = "cod" Then sql = "SELECT * FROM productos where cod='" & CStr(Me.combobox_BuscarProd.Text) & "' AND inventariado='SI'"
        If tipo = "barras" Then sql = "SELECT * FROM productos where codBARRAS='" & CStr(Me.combobox_BuscarProd.Text) & "' and inventariado='SI'"

        Try
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                prod_barras = row.Item("codbarras")
                prod_cod = row.Item("cod")
                Label1.Text = row.Item("cod")
                TextBox_buscarprod.Text = row.Item("nombre")
                Label20.Text = row.Item("nombre")
                prod_nom = row.Item("nombre")
                prod_desc = row.Item("descripcion")
                prod_iva = row.Item("iva")
                prod_valor = row.Item("valor")
                PROD_COSTO = row.Item("COSTO")
                PROD_DECIMAL = row.Item("DECIMALES")
            Next
        Catch ex As Exception
        End Try
        da.Dispose()
        conex.Close()
        'Me.combobox_BuscarProd.SelectedItem = prod_cod
        Me.NumericUpDown_vrUnitario.Value = PROD_COSTO
        If PROD_DECIMAL = "SI" Then NumericUpDown_CANT.DecimalPlaces = 3 Else NumericUpDown_CANT.DecimalPlaces = 0


    End Sub

    Private Sub calcula_saldo()
        'saldo
        entran = 0
        salen = 0
        saldo = 0
        'Label_saldo_lote.Text = 0
        Label_saldo_actual.Text = 0
        Try
            If Label_tipomovimiento.Text = "Traslado de Mercancia" Then sql = "SELECT sum(entran) - sum(salen) as saldo FROM bodega_" & ComboBox_ORIGEN.Text & " where CodProducto=" & CInt(prod_cod) & ""
            If Label_tipomovimiento.Text <> "Traslado de Mercancia" Then sql = "SELECT sum(entran) - sum(salen) as saldo FROM bodega_" & ComboBox_DESTINO.Text & " where CodProducto=" & CInt(prod_cod) & ""

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



        '  colocar parametor en opciones dle sistema para habilitar y deshabilitar esta opcion
        If Label_tipomovimiento.Text = "Traslado de Mercancia" Then
            NumericUpDown_CANT.Maximum = 1000000
        Else
            NumericUpDown_CANT.Maximum = 1000000
        End If

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





    Private Sub datagrid_productos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_productos.CellClick
        Dim row_prod As DataGridViewRow = datagrid_productos.CurrentRow
        prod_cod = CStr(row_prod.Cells("cons").Value) ' LLAVE PRINCIPAL
    End Sub


    Private Sub Timer_prod_data_Tick(sender As Object, e As EventArgs) Handles Timer_prod_data.Tick
        Me.Timer_prod_data.Enabled = False
        'datos_del_producto("combo")

        For i As Integer = 0 To Datagrid_prods_catalogo.RowCount - 1
            If CStr(Datagrid_prods_catalogo.Item("cod", i).Value) = combobox_BuscarProd.SelectedValue Then
                Label1.Text = Datagrid_prods_catalogo.Item("cod", i).Value
                prod_barras = Datagrid_prods_catalogo.Item("codbarras", i).Value
                prod_cod = Datagrid_prods_catalogo.Item("cod", i).Value
                Label1.Text = Datagrid_prods_catalogo.Item("cod", i).Value
                'TextBox_buscarprod.Text = Datagrid_prods_catalogo.Item("nombre", i).Value
                Label20.Text = Datagrid_prods_catalogo.Item("nombre", i).Value & " " & Datagrid_prods_catalogo.Item("ref", i).Value & " " & Datagrid_prods_catalogo.Item("presentacion", i).Value
                prod_nom = Datagrid_prods_catalogo.Item("nombre", i).Value & " " & Datagrid_prods_catalogo.Item("ref", i).Value & " " & Datagrid_prods_catalogo.Item("presentacion", i).Value
                prod_desc = Datagrid_prods_catalogo.Item("descripcion", i).Value
                prod_iva = Datagrid_prods_catalogo.Item("iva", i).Value
                prod_valor = Datagrid_prods_catalogo.Item("valor", i).Value
                PROD_COSTO = Datagrid_prods_catalogo.Item("COSTO", i).Value
                PROD_DECIMAL = Datagrid_prods_catalogo.Item("DECIMALES", i).Value
            End If

        Next


        calcula_saldo()

        'busca_lotes()

        'If Label_tipomovimiento.Text = "Traslado de Mercancia" Then
        'End If


        Me.NumericUpDown_vrUnitario.Value = PROD_COSTO

    End Sub
    Private Sub Timer_PROD_DATA_BARRAS_Tick(sender As Object, e As EventArgs) Handles Timer_PROD_DATA_BARRAS.Tick
        Me.Timer_PROD_DATA_BARRAS.Enabled = False
        datos_del_producto("barras")


        busca_lotes()


        Me.NumericUpDown_vrUnitario.Value = PROD_COSTO
    End Sub



    Public Sub ExportarDatosPDF_mov(ByVal document As Document)

        'Se crea un objeto PDFTable con el numero de columnas del DataGridView.
        Dim datatable As New PdfPTable(MetroGrid_pdf.ColumnCount)
        'Se asignan algunas propiedades para el diseño del PDF.
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(MetroGrid_pdf)

        Dim fontLINE = iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLD)


        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER

        'Se crea el encabezado en el PDF.
        Dim encabezadoLINE As New Paragraph("|=======================================================================================================================|", fontLINE)

        encabezadoLINE.Alignment = 0
        encabezadoLINE.Font = fontLINE

        Dim encabezadoLINE2 As New Paragraph("========================================================================================================================", fontLINE)
        Dim encabezadoLINE3 As New Paragraph("______________________________________________________________________________________________________________________________", fontLINE)

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

        Dim encabezado2 As New Paragraph(Combobox_tipo_mov.Text & " " & Label_consecutivo.Text, FontFactory.GetFont(FontFactory.COURIER, 11, iTextSharp.text.Font.BOLD))
        encabezado2.Alignment = Element.ALIGN_CENTER
        Dim encabezado_movdetalle As New Paragraph(ComboBox_ORIGEN.Text & " ==> " & ComboBox_DESTINO.Text, FontFactory.GetFont(FontFactory.COURIER, 11, iTextSharp.text.Font.BOLD))
        encabezado_movdetalle.Alignment = Element.ALIGN_CENTER

        Dim encabezado_estado As New Paragraph(Label_estado_movimiento.Text, FontFactory.GetFont(FontFactory.COURIER, 11, iTextSharp.text.Font.BOLD))
        encabezado_estado.Alignment = Element.ALIGN_CENTER

        'Se crea el texto abajo del encabezado.
        Dim texto_total_in As New Phrase("Valor Entrada: $" + Me.TextBoxTotalDoc1.Text.ToString + Chr(13), FontFactory.GetFont(FontFactory.COURIER, 6D, iTextSharp.text.Font.BOLD))
        Dim texto_total_out As New Phrase("Valor Salida; $" + Me.TextBoxtotaldoc2.Text.ToString + Chr(13), FontFactory.GetFont(FontFactory.COURIER, 6D, iTextSharp.text.Font.BOLD))

        Dim texto2 As New Phrase("Fecha:" + Now.Date() + Chr(13), FontFactory.GetFont(FontFactory.COURIER, 8D, iTextSharp.text.Font.BOLD))
        Dim texto_ReSPONSABLE As New Phrase("Responsable:" + Me.TextBox_responsable.Text.ToString + Chr(13), FontFactory.GetFont(FontFactory.COURIER, 8D, iTextSharp.text.Font.BOLD))
        Dim texto_observ As New Phrase("Obsrevaciones:" + Me.Text_leyenda.Text.ToString + Chr(13), FontFactory.GetFont(FontFactory.COURIER, 8D, iTextSharp.text.Font.BOLD))

        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To MetroGrid_pdf.ColumnCount - 1
            Dim cell_TITLE As New PdfPCell
            cell_TITLE.Phrase = New Phrase(MetroGrid_pdf.Columns(i).HeaderText, New iTextSharp.text.Font(Font.Name = "Arial Narrow", 8, Font.Bold = False))
            cell_TITLE.HorizontalAlignment = Element.ALIGN_CENTER
            cell_TITLE.BackgroundColor = BaseColor.LIGHT_GRAY
            datatable.AddCell(cell_TITLE)
        Next

        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1
        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To MetroGrid_pdf.RowCount - 1
            For j As Integer = 0 To MetroGrid_pdf.ColumnCount - 1

                Dim cell As New PdfPCell
                cell.Phrase = New Phrase(MetroGrid_pdf(j, i).Value.ToString, New Font(Font.Name = "Arial Narrow", 8, Font.Bold = False))
                If j = 0 Then cell.HorizontalAlignment = Element.ALIGN_CENTER
                If j = 1 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 2 Then cell.HorizontalAlignment = Element.ALIGN_CENTER
                If j = 3 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 4 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 5 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 6 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 7 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                datatable.AddCell(cell)

            Next
            datatable.CompleteRow()
        Next


        Dim PDF_FIRMACLIENTE As New Paragraph(Chr(13) + Chr(13) + "Elaborado:____________________         Revisado:________________________       Autorizado:________________________", FontFactory.GetFont(FontFactory.COURIER, 8D, iTextSharp.text.Font.BOLD)) : PDF_FIRMACLIENTE.Alignment = 0
        PDF_FIRMACLIENTE.Font = FontFactory.GetFont(FontFactory.COURIER, 8D, iTextSharp.text.Font.BOLD)
        Dim texto3 As New Phrase("Imprimió:" + usrnom, FontFactory.GetFont(FontFactory.COURIER, 8D, iTextSharp.text.Font.BOLD))

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

        document.Add(encabezadoLINE)
        document.Add(tablahome)
        document.Add(encabezadoLINE3)
        document.Add(encabezado2)
        document.Add(encabezado_movdetalle)
        document.Add(encabezado_estado)
        document.Add(encabezadoLINE3)


        document.Add(texto_total_in)
        document.Add(texto_total_out)

        document.Add(texto2)
        document.Add(texto_ReSPONSABLE)
        document.Add(texto_observ)
        document.Add(datatable)
        document.Add(texto3)
        document.Add(PDF_FIRMACLIENTE)

    End Sub

    Public Sub ExportarDatosPOS_mov(ByVal document As Document)

        'Se crea un objeto PDFTable con el numero de columnas del DataGridView.
        Dim datatable As New PdfPTable(MetroGrid_pdf.ColumnCount)
        'Se asignan algunas propiedades para el diseño del PDF.
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(MetroGrid_pdf)

        Dim fontLINE = iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLD)


        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER

        'Se crea el encabezado en el PDF.
        Dim encabezadoLINE As New Paragraph("|=======================================|", fontLINE)

        encabezadoLINE.Alignment = 0
        encabezadoLINE.Font = fontLINE
        If comex_logo <> "" Then encabezadoLINE.SpacingBefore = 60

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


        cellhome.Phrase = New Phrase(comex_nombrecomercial, FontFactory.GetFont(FontFactory.COURIER, 10, iTextSharp.text.Font.BOLD))
        cellhome.HorizontalAlignment = Element.ALIGN_CENTER
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase(comex_nombrepropietario, FontFactory.GetFont(FontFactory.COURIER, 9, iTextSharp.text.Font.BOLD))
        cellhome.HorizontalAlignment = Element.ALIGN_CENTER
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase("NIT:" & comex_nit & "-" & comex_DV & " " & comex_regimen, FontFactory.GetFont(FontFactory.COURIER, 7, iTextSharp.text.Font.BOLD))
        cellhome.HorizontalAlignment = Element.ALIGN_CENTER
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase(comex_dircomercio + " Tels:" & comex_tels & " " & comex_cels, FontFactory.GetFont(FontFactory.COURIER, 7, iTextSharp.text.Font.BOLD))
        cellhome.HorizontalAlignment = Element.ALIGN_CENTER
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        Dim encabezado2 As New Paragraph(Combobox_tipo_mov.Text & " " & Label_consecutivo.Text, FontFactory.GetFont(FontFactory.COURIER, 9, iTextSharp.text.Font.BOLD))
        encabezado2.Alignment = Element.ALIGN_CENTER
        Dim encabezado_movdetalle As New Paragraph(ComboBox_ORIGEN.Text & " ==> " & ComboBox_DESTINO.Text, FontFactory.GetFont(FontFactory.COURIER, 9, iTextSharp.text.Font.BOLD))
        encabezado_movdetalle.Alignment = Element.ALIGN_CENTER


        Dim encabezado_estado As New Paragraph(Label_estado_movimiento.Text, FontFactory.GetFont(FontFactory.COURIER, 9, iTextSharp.text.Font.BOLD))
        encabezado_estado.Alignment = Element.ALIGN_CENTER



        'Se crea el texto abajo del encabezado.
        Dim texto_total_in As New Phrase("Valor Entrada: $" + Me.TextBoxTotalDoc1.Text.ToString + Chr(13), FontFactory.GetFont(FontFactory.COURIER, 6D, iTextSharp.text.Font.BOLD))
        Dim texto_total_out As New Phrase("Valor Salida; $" + Me.TextBoxtotaldoc2.Text.ToString + Chr(13), FontFactory.GetFont(FontFactory.COURIER, 6D, iTextSharp.text.Font.BOLD))


        Dim texto2 As New Phrase("Fecha: " + Now.Date() + Chr(13), FontFactory.GetFont(FontFactory.COURIER, 6D, iTextSharp.text.Font.BOLD))
        Dim texto_ReSPONSABLE As New Phrase("Responsable:" + Me.TextBox_responsable.Text.ToString + Chr(13), FontFactory.GetFont(FontFactory.COURIER, 6D, iTextSharp.text.Font.BOLD))
        Dim texto_observ As New Phrase("Obsrevaciones:" + Me.Text_leyenda.Text.ToString + Chr(13), FontFactory.GetFont(FontFactory.COURIER, 6D, iTextSharp.text.Font.BOLD))

        'Se capturan los nombres de las columnas del DataGridView.
        'For i As Integer = 0 To MetroGrid_pdf.ColumnCount - 1
        '    Dim cell_TITLE As New PdfPCell
        '    cell_TITLE.Phrase = New Phrase(MetroGrid_pdf.Columns(i).HeaderText, New iTextSharp.text.Font(Font.Name = "Arial Narrow", 8, Font.Bold = False))
        '    cell_TITLE.HorizontalAlignment = Element.ALIGN_CENTER
        '    cell_TITLE.BackgroundColor = BaseColor.LIGHT_GRAY
        '    datatable.AddCell(cell_TITLE)
        'Next
        Dim encabezado9 As New Paragraph("Código  |  Producto             ", FontFactory.GetFont(FontFactory.COURIER_BOLD, 6D, iTextSharp.text.Font.BOLD)) : encabezado9.Alignment = Element.ALIGN_LEFT
        Dim encabezado91 As New Paragraph("Rol     |   Cant   |   Valor   |  Total", FontFactory.GetFont(FontFactory.COURIER_BOLD, 6D, iTextSharp.text.Font.BOLD)) : encabezado91.Alignment = Element.ALIGN_LEFT

        datatable.HeaderRows = 0
        datatable.DefaultCell.BorderWidth = 0
        datatable.SetWidths({20, 1, 20, 20, 20, 20})

        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To MetroGrid_pdf.RowCount - 1
            For j As Integer = 0 To MetroGrid_pdf.ColumnCount - 1

                Dim cell As New PdfPCell
                cell.Phrase = New Phrase(MetroGrid_pdf(j, i).Value.ToString, New Font(Font.Name = "Arial Narrow", 7D, Font.Bold = False))
                If j = 0 Then cell.HorizontalAlignment = Element.ALIGN_CENTER : cell.Colspan = 1 : cell.Rowspan = 1
                If j = 1 Then cell.HorizontalAlignment = Element.ALIGN_LEFT : cell.Colspan = 5 : cell.Rowspan = 1
                If j = 2 Then cell.HorizontalAlignment = Element.ALIGN_CENTER : cell.Colspan = 1 : cell.Rowspan = 2
                If j = 3 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT : cell.Colspan = 2 : cell.Rowspan = 2
                If j = 4 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT : cell.Colspan = 1 : cell.Rowspan = 2
                If j = 5 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT : cell.Colspan = 2 : cell.Rowspan = 2
                If j = 6 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 7 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT

                If j = 0 Then cell.BackgroundColor = BaseColor.LIGHT_GRAY
                If j = 1 Then cell.BackgroundColor = BaseColor.LIGHT_GRAY


                datatable.AddCell(cell)

            Next
            datatable.CompleteRow()
        Next


        Dim PDF_FIRMACLIENTE As New Paragraph(Chr(13) + Chr(13) + "Elaborado:____________________         Revisado:________________________       Autorizado:________________________", FontFactory.GetFont(FontFactory.COURIER, 7.5D, iTextSharp.text.Font.BOLD)) : PDF_FIRMACLIENTE.Alignment = 0
        PDF_FIRMACLIENTE.Font = FontFactory.GetFont(FontFactory.COURIER, 7.5D, iTextSharp.text.Font.BOLD)
        Dim texto3 As New Phrase("Imprimió:" + usrnom, FontFactory.GetFont(FontFactory.COURIER_BOLD, 6D, iTextSharp.text.Font.BOLD))


        'LOGO
        If comex_logo <> "" And File.Exists(comex_logo) = True Then
            Dim imagelogogopdf As iTextSharp.text.Image 'Declaracion de una imagen

            imagelogogopdf = iTextSharp.text.Image.GetInstance(comex_logo) 'Dirreccion a la imagen que se hace referencia
            imagelogogopdf.Alignment = Element.ALIGN_RIGHT
            imagelogogopdf.SetAbsolutePosition(20, alto_pag - 60) 'Posicion en el eje cartesiano
            imagelogogopdf.ScaleAbsoluteWidth(160) 'Ancho de la imagen
            imagelogogopdf.ScaleAbsoluteHeight(50) 'Altura de la imagen
            document.Add(imagelogogopdf) ' Agrega la imagen al documento
        End If

        document.Add(encabezadoLINE)
        document.Add(tablahome)
        document.Add(encabezadoLINE3)
        document.Add(encabezado2)
        document.Add(encabezado_movdetalle)
        document.Add(encabezado_estado)
        document.Add(encabezadoLINE3)

        document.Add(texto_total_in)
        document.Add(texto_total_out)

        document.Add(texto2)
        document.Add(texto_ReSPONSABLE)
        document.Add(texto_observ)
        document.Add(encabezadoLINE3)
        document.Add(encabezado9)
        document.Add(encabezado91)
        datatable.SpacingBefore = 5
        document.Add(datatable)
        document.Add(texto3)
        document.Add(PDF_FIRMACLIENTE)

    End Sub


    Private Sub Timer_prod_data_cod_Tick(sender As Object, e As EventArgs) Handles Timer_prod_data_cod.Tick
        Me.Timer_prod_data_cod.Enabled = False
        datos_del_producto("cod")
        busca_lotes()

        If Combobox_tipo_mov.Text = "Traslado de Mercancia" Then calcula_saldo()

        Me.NumericUpDown_vrUnitario.Value = PROD_COSTO
    End Sub

    Private Sub ButtonDescargar_Click(sender As Object, e As EventArgs) Handles ButtonDescargar.Click
        If PERMISO_1(14) = "NO" Or PERMISO_1(14) = Nothing Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub


        If Me.Combobox_tipo_mov.Text.Contains("Entrada") And PERMISO_1(11) = "NO" Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub
        If Me.Combobox_tipo_mov.Text.Contains("Salida") And PERMISO_1(12) = "NO" Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub


        Dim RTA As String = ""
        If Me.Combobox_tipo_mov.Text.Contains("Entrada") = True Then
            RTA = MsgBox("Seguro desea finalizar la entrada de mercancia?. " & Chr(13) & Chr(13) & "Se ingresaran los productos a la bodega.", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        End If
        If Me.Combobox_tipo_mov.Text.Contains("Salida") = True Then
            RTA = MsgBox("Seguro desea finalizar la salida de mercancia?. " & Chr(13) & Chr(13) & "Se retirarn los productos de la bodega.", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        End If
        If Me.Combobox_tipo_mov.Text = "Inventario Inicial" Then
            RTA = MsgBox("Seguro desea finalizar el Inventario Inicial de Mercancia?. " & Chr(13) & Chr(13) & "Se ingresaran los productos a la bodega.", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        End If
        If Me.Combobox_tipo_mov.Text = "Traslado de Mercancia" Then
            RTA = MsgBox("Seguro desea finalizar el Traslado de Mercancia?. " & Chr(13) & Chr(13) & "Se moveran los productos a la bodega seleccionada.", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
            ' traslado de mercanncia 
            hacer_movimiento()


            'prueba
            If Label_estado_movimiento.Text = "SIN DESCARGAR" Then

            End If
            'prueba
            If Label_estado_movimiento.Text = "EN TRASLADO" Then

            End If
            Exit Sub
        End If


        If Me.Combobox_tipo_mov.Text = "Ajuste de Inventario" Then
            RTA = MsgBox("Seguro desea finalizar el Ajuste de Inventario? " & Chr(13) & Chr(13) & "", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        End If


        Dim TERCEROO As String = CStr(ComboBox_tercero.SelectedValue) & "|" & CStr(ComboBox_tercero.Text)


        If RTA = 6 Then
            'descargar ventas de productos
            Cursor.Current = Cursors.WaitCursor
            Try
                For J As Integer = 0 To Me.datagrid_productos.RowCount - 1
                    PROD_SALEN = 0
                    PROD_SALDO = 0
                    PROD_SALDO = 0
                    PROD_DECIMAL = datagrid_productos.Item("DECI", J).Value

                    saldo = 0

                    'costo     ===========
                    PROD_COSTO = CDec(Me.datagrid_productos.Item("valoru", J).Value)


                    'promedio================

                    If (Me.Combobox_tipo_mov.Text.Contains("Entrada") = True) Or Me.Combobox_tipo_mov.Text = "Inventario Inicial" Then
                        PROD_ENTRAN = Me.datagrid_productos.Item("cantidad", J).Value  ' TOMO LA CANTIDAD DEL GRID Q ESTA RECORRIENDO
                        PROD_SALDO = saldo  ' IGUALDO SALDO PROD CON EL SALDO CALCULADO EN BODEGA PRICIPAL
                        If PROD_DECIMAL = "NO" Then PROD_SALDO = CInt(PROD_SALDO) + CInt(PROD_ENTRAN)   '  ACUMULO
                        If PROD_DECIMAL = "SI" Then PROD_SALDO = CDec(PROD_SALDO) + CDec(PROD_ENTRAN)   '  ACUMULO
                        PROD_SALEN = 0 ' POR QUE QUE ES UNA COMPRA
                    End If
                    If Me.Combobox_tipo_mov.Text.Contains("Salida") = True Then
                        PROD_SALEN = Me.datagrid_productos.Item("cantidad", J).Value  ' TOMO LA CANTIDAD DEL GRID Q ESTA RECORRIENDO
                        PROD_SALDO = saldo  ' IGUALDO SALDO PROD CON EL SALDO CALCULADO EN BODEGA PRICIPAL
                        If PROD_DECIMAL = "NO" Then PROD_SALDO = CInt(PROD_SALDO) - CInt(PROD_SALEN) ' ACUMULO
                        If PROD_DECIMAL = "SI" Then PROD_SALDO = CDec(PROD_SALDO) - CDec(PROD_SALEN)
                        PROD_ENTRAN = 0 ' POR QUE QUE ES UNA COMPRA
                    End If

                    If Me.Combobox_tipo_mov.Text = "Ajuste de Inventario" Then
                        If Me.datagrid_productos.Item("ROL", J).Value = "ENTRAN" Then

                            PROD_ENTRAN = Me.datagrid_productos.Item("cantidad", J).Value  ' TOMO LA CANTIDAD DEL GRID Q ESTA RECORRIENDO
                            PROD_SALDO = saldo  ' IGUALDO SALDO PROD CON EL SALDO CALCULADO EN BODEGA PRICIPAL
                            PROD_SALDO = CDec(PROD_SALDO) + CDec(PROD_ENTRAN)
                            PROD_SALEN = 0 ' POR QUE QUE ES UNA COMPRA
                        End If

                        If Me.datagrid_productos.Item("ROL", J).Value = "SALEN" Then
                            PROD_SALEN = Me.datagrid_productos.Item("cantidad", J).Value  ' TOMO LA CANTIDAD DEL GRID Q ESTA RECORRIENDO
                            PROD_SALDO = saldo  ' IGUALDO SALDO PROD CON EL SALDO CALCULADO EN BODEGA PRICIPAL
                            PROD_SALDO = CDec(PROD_SALDO) - CDec(PROD_SALEN)
                            PROD_ENTRAN = 0 ' POR QUE QUE ES UNA COMPRA
                        End If
                    End If
                    '________________________________________________________________________________________________________________________
                    Dim rol As String = ""
                    If (Me.Combobox_tipo_mov.Text.Contains("Entrada") = True) Or
                        Me.Combobox_tipo_mov.Text = "Inventario Inicial" Then rol = "ENTRAN"

                    If Me.Combobox_tipo_mov.Text.Contains("Salida") = True Then rol = "SALEN"


                    If (Me.Combobox_tipo_mov.Text.Contains("Entrada") = True) Or Me.Combobox_tipo_mov.Text = "Inventario Inicial" Then
                        If PROD_DECIMAL = "NO" Then PROD_COSTO_TOTAL = CDec(Me.datagrid_productos.Item("valoru", J).Value) * CInt(PROD_ENTRAN)
                        If PROD_DECIMAL = "SI" Then PROD_COSTO_TOTAL = CDec(Me.datagrid_productos.Item("valoru", J).Value) * CDec(PROD_ENTRAN)

                        sql = "INSERT INTO bodega_" & ComboBox_DESTINO.Text & " (fecha, CodBodega, NomBodega, TipoDocumento, Documento, tercero, Rol, CodProducto, Producto, saldoant, Entran, Salen, Saldo, valoru, valortotal, Empleado, Estado, DECI, COSTO, lote, vence)" &
                              "VALUES ('" & DateTime.Now.ToShortDateString & "'," & ComboBox_DESTINO.SelectedValue & ",'" & ComboBox_DESTINO.Text & "','" & Me.Combobox_tipo_mov.Text & "'," & CInt(Me.Label_consecutivo.Text) & ",'" & TERCEROO & "','ENTRAN'," & CInt(Me.datagrid_productos.Item("CODPROD", J).Value) & ",'" & CStr(Me.datagrid_productos.Item("PRODUCTO", J).Value) & "','" & saldo & "','" & PROD_ENTRAN & "','0','" & PROD_SALDO & "','" & CDec(Me.datagrid_productos.Item("valoru", J).Value) & "','" & (Me.datagrid_productos.Item("valortotal", J).Value) & "','" & usrnom & "','DESCARGADO','" & PROD_DECIMAL & "','" & PROD_COSTO & "','" & CStr(datagrid_productos.Item("lote", J).Value) & "','" & CStr(datagrid_productos.Item("vence", J).Value) & "')"

                    End If

                    If (Me.Combobox_tipo_mov.Text.Contains("Salida") = True) Then
                        If PROD_DECIMAL = "NO" Then PROD_COSTO_TOTAL = CLng(Me.datagrid_productos.Item("valoru", J).Value) * CInt(PROD_SALEN)
                        If PROD_DECIMAL = "SI" Then PROD_COSTO_TOTAL = CLng(Me.datagrid_productos.Item("valoru", J).Value) * CDec(PROD_SALEN)
                        sql = "INSERT INTO bodega_" & ComboBox_DESTINO.Text & " (fecha, CodBodega, NomBodega, TipoDocumento, Documento, tercero, Rol, CodProducto, Producto, saldoant, Entran, Salen, Saldo, valoru, valortotal, Empleado, Estado, DECI, COSTO, lote,vence)" &
                            "VALUES ('" & DateTime.Now.ToShortDateString & "'," & ComboBox_DESTINO.SelectedValue & ",'" & ComboBox_DESTINO.Text & "','" & Me.Combobox_tipo_mov.Text & "'," & CInt(Me.Label_consecutivo.Text) & ",'" & TERCEROO & "','SALEN'," & CInt(Me.datagrid_productos.Item("CODPROD", J).Value) & ",'" & CStr(Me.datagrid_productos.Item("PRODUCTO", J).Value) & "','" & saldo & "','0','" & PROD_SALEN & "','" & PROD_SALDO & "','" & CDec(Me.datagrid_productos.Item("valoru", J).Value) & "','" & (Me.datagrid_productos.Item("valortotal", J).Value) & "','" & usrnom & "','DESCARGADO','" & PROD_DECIMAL & "','" & PROD_COSTO & "','" & CStr(datagrid_productos.Item("lote", J).Value) & "','" & CStr(datagrid_productos.Item("vence", J).Value) & "')"
                    End If

                    If Me.Combobox_tipo_mov.Text = "Ajuste de Inventario" Then
                        If Me.datagrid_productos.Item("ROL", J).Value = "ENTRAN" Then
                            rol = "ENTRAN"
                            PROD_COSTO_TOTAL = CLng(Me.datagrid_productos.Item("valoru", J).Value) * CInt(PROD_ENTRAN)

                            sql = "INSERT INTO bodega_" & ComboBox_DESTINO.Text & " (fecha, CodBodega, NomBodega, TipoDocumento, Documento, tercero, Rol, CodProducto, Producto, saldoant, Entran, Salen, Saldo, valoru, valortotal, Empleado, Estado, DECI, COSTO, lote, vence)" &
                              "VALUES ('" & DateTime.Now.ToShortDateString & "',
                              " & ComboBox_DESTINO.SelectedValue & ",'" & ComboBox_DESTINO.Text & "',
                              '" & Me.Combobox_tipo_mov.Text & "'," & CInt(Me.Label_consecutivo.Text) & ",'" & TERCEROO & "',
                              'ENTRAN'," & CInt(Me.datagrid_productos.Item("CODPROD", J).Value) & ",'" & CStr(Me.datagrid_productos.Item("PRODUCTO", J).Value) & "',
                              '" & saldo & "','" & PROD_ENTRAN & "','0','" & PROD_SALDO & "',
                              '" & CDec(Me.datagrid_productos.Item("valoru", J).Value) & "','" & (Me.datagrid_productos.Item("valortotal", J).Value) & "',
                              '" & usrnom & "','DESCARGADO','" & PROD_DECIMAL & "','" & PROD_COSTO & "',
                              '" & CStr(datagrid_productos.Item("lote", J).Value) & "',
                              '" & CStr(datagrid_productos.Item("vence", J).Value) & "')"
                        End If

                        If Me.datagrid_productos.Item("ROL", J).Value = "SALEN" Then
                            rol = "ENTRAN"
                            PROD_COSTO_TOTAL = CLng(Me.datagrid_productos.Item("valoru", J).Value) * CInt(PROD_SALEN)

                            sql = "INSERT INTO bodega_" & ComboBox_DESTINO.Text & " (fecha, CodBodega, NomBodega, TipoDocumento, Documento, tercero, Rol, CodProducto, Producto, Entran, Salen, valoru, valortotal, Empleado, Estado, DECI, COSTO, lote,vence)" &
                            "VALUES ('" & DateTime.Now.ToShortDateString & "',
                            " & ComboBox_DESTINO.SelectedValue & ",'" & ComboBox_DESTINO.Text & "',
                            '" & Me.Combobox_tipo_mov.Text & "',
                            " & CInt(Me.Label_consecutivo.Text) & ",
                            '" & TERCEROO & "',
                            'SALEN'," & CInt(Me.datagrid_productos.Item("CODPROD", J).Value) & ",'" & CStr(Me.datagrid_productos.Item("PRODUCTO", J).Value) & "',
                            '0','" & PROD_SALEN & "',
                            '" & CDec(Me.datagrid_productos.Item("valoru", J).Value) & "',
                            '" & (Me.datagrid_productos.Item("valortotal", J).Value) & "',
                            '" & usrnom & "','DESCARGADO','" & PROD_DECIMAL & "','" & PROD_COSTO & "',
                            '" & CStr(datagrid_productos.Item("lote", J).Value) & "',
                            '" & CStr(datagrid_productos.Item("vence", J).Value) & "')"
                        End If
                    End If


                    da = New MySqlDataAdapter(sql, conex)
                    dt = New DataTable
                    Try
                        da.Fill(dt)
                    Catch ex As Exception
                        If ex.ToString.Contains("Duplicate entry") Then MsgBox("Error al actualizar EN KARDEX DE BODEGA", vbExclamation)
                        MsgBox(ex.ToString)
                    End Try
                    da.Dispose()
                    dt.Dispose()
                    conex.Close()

                    PROD_SALEN = 0
                    PROD_SALDO = 0
                    PROD_SALDO = 0

                Next
            Catch ex As Exception
                Cursor.Current = Cursors.Default

                MsgBox(ex.Message.ToString)
            End Try

            PROD_SALEN = 0
            PROD_SALDO = 0
            PROD_SALDO = 0

            Cursor.Current = Cursors.Default

            Cursor.Current = Cursors.WaitCursor


            sql = "UPDATE movimientos_prods SET estado='DESCARGADO' WHERE DOCUMENTO=" & CInt(Me.Label_consecutivo.Text) & " and tipodoc='" & Me.Combobox_tipo_mov.Text & "'"
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

            sql = "UPDATE MOVIMIENTOS SET observaciones='" & CStr(Me.Text_leyenda.Text) & "', estado='DESCARGADO' WHERE DOCUMENTO=" & CInt(Me.Label_consecutivo.Text) & " AND TIPODOCUMENTO='" & Me.Combobox_tipo_mov.Text & "'"
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

            Me.Label_estado_movimiento.Text = "DESCARGADO"
            Me.ButtonDescargar.Visible = False
            Me.Button_anular.Visible = True

            Me.Button_agregar_prod.Visible = False
            Me.button_Quitar_Prod.Visible = False


            Me.Cursor = Cursors.Default
        End If
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Timer_alerta_stock_Tick(sender As Object, e As EventArgs) Handles Timer_alerta_stock.Tick
        Me.Timer_alerta_stock.Enabled = False

        'Me.Button_info.Visible = False
        'Me.Label_info.Visible = False
    End Sub


    Private Sub llena_grid_PRODUCTOS_EXPORT()
        Try

            da_pdf = New MySqlDataAdapter(sql, conex)
            dt_pdf = New DataTable
            da_pdf.Fill(dt_pdf)
            Me.MetroGrid_pdf.DataSource = dt_pdf
            Me.MetroGrid_pdf.Columns(0).HeaderText = "Documento"
            Me.MetroGrid_pdf.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.MetroGrid_pdf.Columns(0).Width = 50
            Me.MetroGrid_pdf.Columns(1).HeaderText = "Fecha"
            Me.MetroGrid_pdf.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.MetroGrid_pdf.Columns(1).Width = 70
            Me.MetroGrid_pdf.Columns(2).HeaderText = "Tipo"
            Me.MetroGrid_pdf.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.MetroGrid_pdf.Columns(2).Width = 130
            Me.MetroGrid_pdf.Columns(3).HeaderText = "Origen"
            Me.MetroGrid_pdf.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.MetroGrid_pdf.Columns(3).Width = 110
            Me.MetroGrid_pdf.Columns(4).HeaderText = "Destino"
            Me.MetroGrid_pdf.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.MetroGrid_pdf.Columns(4).Width = 110
            Me.MetroGrid_pdf.Columns(5).HeaderText = "Tercero"
            Me.MetroGrid_pdf.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.MetroGrid_pdf.Columns(5).Width = 150
            Me.MetroGrid_pdf.Columns(6).HeaderText = "Responsable"
            Me.MetroGrid_pdf.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.MetroGrid_pdf.Columns(6).Width = 150
            Me.MetroGrid_pdf.Columns(7).HeaderText = "Estado"
            Me.MetroGrid_pdf.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.MetroGrid_pdf.Columns(7).Width = 70
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




    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        'funcion para obtener el tamaño de la columnas del datagridview
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function



    Private Sub Button_exportar_Click(sender As Object, e As EventArgs) Handles Button_exportar.Click

        Panel_detalles.Enabled = False
        FlowLayoutPanel1.Enabled = False




        BunifuCards_exportar.Height = 262
        BunifuCards_exportar.Visible = True
        BunifuCards_exportar.BringToFront()
        Centrar(BunifuCards_exportar)


    End Sub


    Private Sub datagrid_movimientos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_movimientos.CellClick

        Dim row_mov As DataGridViewRow = datagrid_movimientos.CurrentRow

        If Not IsNothing(row_mov) Then
            CodDocumento = CLng(row_mov.Cells("documento").Value) ' LLAVE PRINCIPAL
            TipoDocumento = CStr(row_mov.Cells("Tipodocumento").Value)
        End If




    End Sub



    Private Sub Button_anular_Click(sender As Object, e As EventArgs) Handles Button_anular.Click
        'If Label_estado_movimiento.Text = "SIN DESCARGAR" Then
        'MsgBox("no sepuede anular un movimiento sin descargar?. ", vbInformation)
        'Exit Sub
        'End If

        Dim RTA As String = ""


        RTA = MsgBox("Confirma que desea anular el movimiento de invenario?. ", MsgBoxStyle.Question + MsgBoxStyle.YesNo)





        If RTA = 6 Then
            Me.Cursor = Cursors.WaitCursor

            sql = "delete from bodega_" & ComboBox_DESTINO.Text & " where DOCUMENTO=" & CInt(Me.Label_consecutivo.Text) & " and tipodocUMENTO='" & Me.Label_tipomovimiento.Text & "'"
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





        sql = "UPDATE MOVIMIENTOS SET observaciones='" & CStr(Me.Text_leyenda.Text) & "', ANULADO='SI', ESTADO='ANULADO' WHERE DOCUMENTO=" & CInt(Me.Label_consecutivo.Text) & " AND TIPODOCUMENTO='" & Me.Label_tipomovimiento.Text & "'"
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


        Me.Label_estado_movimiento.Text = "ANULADO"
        Me.Button_anular.Visible = False
        Me.ButtonDescargar.Visible = False
        Me.Button_agregar_prod.Visible = False
        Me.button_Quitar_Prod.Visible = False

        'oculto el tab
        Me.TabControl_detalle.SelectTab(0)

            Me.Cursor = Cursors.Default
        End If

    End Sub
    Private Sub ANULAR_CONTABILIZACION()

        sql = "DELETE FROM cajaspuc WHERE Documento=" & Label_consecutivo.Text & " and TipoDoc='" & Combobox_tipo_mov.Text & "'"
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


    Private Sub llena_combo_bodegas()
        Try
            sql = "SELECT cons, nombrebodega FROM bodegas"
            da = New MySqlDataAdapter(sql, conex)
            dt_destino = New DataTable
            DT_ORIGEN = New DataTable

            da.Fill(dt_destino)
            da.Fill(DT_ORIGEN)

            Me.ComboBox_DESTINO.DataSource = dt_destino.DefaultView
            Me.ComboBox_DESTINO.DisplayMember = "nombrebodega"
            Me.ComboBox_DESTINO.ValueMember = "cons"

            Me.ComboBox_ORIGEN.DataSource = DT_ORIGEN.DefaultView
            Me.ComboBox_ORIGEN.DisplayMember = "nombrebodega"
            Me.ComboBox_ORIGEN.ValueMember = "cons"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt_destino.Dispose()
        DT_ORIGEN.Dispose()

        conex.Close()

        Me.ComboBox_ORIGEN.Text = Nothing
        Me.ComboBox_DESTINO.Text = Nothing

    End Sub


    Private Sub Btn_nuevo_mov_Click(sender As Object, e As EventArgs) Handles Btn_nuevo_mov.Click

        If PERMISO_1(13) = "NO" Or PERMISO_1(13) = Nothing Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub


        If autorizacion_doc = "SI" And usrAUTORIZADOR <> "SI" Then MsgBox("este documento requiere un usuario con autorización.", vbExclamation) : Exit Sub

        contabilizado = ""
        Me.ComboBox_tercero.Enabled = True

        If Me.Combobox_tipo_mov.Text = "" Or Me.Combobox_tipo_mov.Text = "Todos los Movimientos" Then
            If Me.Combobox_tipo_mov.Text = "" Or Me.Combobox_tipo_mov.Text = "Todos los Movimientos" Then
                MsgBox("Seleccione un tipo de Movimiento", vbOKOnly)
                Combobox_tipo_mov.DroppedDown = True

                Exit Sub

            End If

        End If


        Panel_datamov.Visible = True


        Me.TextBox_ref.Enabled = True
        Button_GUARDAR_REF.Visible = False

        If Me.Combobox_tipo_mov.Text = "Inventario Inicial" Then
            If PERMISO_1(9) = "NO" Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub
            Me.Label_tipomovimiento.Visible = True : Me.Label_tipomovimiento.Text = Me.Combobox_tipo_mov.Text
            Me.Combobox_tipo_mov.Visible = False
            Me.Label_tipomov.Visible = False
            Me.ComboBox_PERIODO.Visible = False
            Me.Label_periodo.Visible = False
            Me.Combobox_tipo_mov.Enabled = False
            consecutivo = 0
            cmd.Connection = conex
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select max(documento) + 1 from movimientos where tipodocumento='Inventario Inicial'"
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

            llena_combo_bodegas()

            Me.Label_consecutivo.Text = consecutivo
            Me.Label_fecha.Text = DateTime.Now.ToShortDateString
            Me.Label_estado_movimiento.Text = "NUEVO"
            que_movimiento = "Nuevo"
            Me.TextBox_responsable.Text = usrnom
            Me.Button_guardar.Visible = True

            Me.ComboBox_DESTINO.Visible = True

            Me.ComboBox_ORIGEN.Visible = False
            Label_destino.Visible = True
            Me.Panel_detalles.Enabled = False

            'Me.Label_info.Text = "Seleccione la Bodega, el tercero y haga click en continuar." : Me.Label_info.Visible = True
            'Me.Button_info.Visible = True
            Me.datagrid_movimientos.Visible = False
            Me.Panel_dock.Visible = False
            ComboBox_tercero.SelectedValue = comex_nit

            RadioButton_entrada.Checked = True

            RadioButton_entrada.Visible = False : RadioButton_entrada.Enabled = False
            RadioButton_salida.Visible = False : RadioButton_salida.Enabled = False
            NumericUpDown_anno_mov.Visible = False
            Label6.Visible = False

        End If




        If Me.Combobox_tipo_mov.Text.Contains("Entrada") = True Then
            If PERMISO_1(11) = "NO" Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub
            Me.Label_tipomovimiento.Visible = True : Me.Label_tipomovimiento.Text = Me.Combobox_tipo_mov.Text
            Me.Combobox_tipo_mov.Visible = False
            Me.Label_tipomov.Visible = False
            Me.ComboBox_PERIODO.Visible = False
            Me.Label_periodo.Visible = False
            Me.Combobox_tipo_mov.Enabled = False

            consecutivo = 0
            cmd.Connection = conex
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select max(documento) + 1 from movimientos where TIPODOCUMENTO like '%Entrada%'"
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

            llena_combo_bodegas()

            Me.Label_consecutivo.Text = consecutivo
            Me.Label_fecha.Text = DateTime.Now.ToShortDateString
            Me.Label_estado_movimiento.Text = "NUEVO"
            que_movimiento = "Nuevo"
            Me.TextBox_responsable.Text = usrnom
            Me.Button_guardar.Visible = True

            Me.ComboBox_DESTINO.Visible = True
            Label_destino.Visible = True
            Label_origen.Visible = False
            Me.ComboBox_ORIGEN.Visible = False



            Me.Panel_detalles.Enabled = False


            'Me.Label_info.Text = "Seleccione la Bodega, el tercero y haga click en continuar." : Me.Label_info.Visible = True
            'Me.Button_info.Visible = True
            Me.datagrid_movimientos.Visible = False
            Me.Panel_dock.Visible = False


            RadioButton_entrada.Checked = True

            RadioButton_entrada.Visible = True : RadioButton_entrada.Enabled = False
            RadioButton_salida.Visible = True : RadioButton_salida.Enabled = False
            NumericUpDown_anno_mov.Visible = False
            Label6.Visible = False

        End If


        If Me.Combobox_tipo_mov.Text.Contains("Salida") = True Then
            If PERMISO_1(12) = "NO" Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub
            Me.Label_tipomovimiento.Visible = True : Me.Label_tipomovimiento.Text = Me.Combobox_tipo_mov.Text
            Me.Combobox_tipo_mov.Visible = False
            Me.Label_tipomov.Visible = False
            Me.ComboBox_PERIODO.Visible = False
            Me.Label_periodo.Visible = False
            Me.Combobox_tipo_mov.Enabled = False
            consecutivo = 0
            cmd.Connection = conex
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select max(documento) + 1 from movimientos WHERE TIPODOCUMENTO like '%Salida%'"
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
            llena_combo_bodegas()
            Me.Label_consecutivo.Text = consecutivo
            Me.Label_fecha.Text = DateTime.Now.ToShortDateString
            Me.Label_estado_movimiento.Text = "NUEVO"
            que_movimiento = "Nuevo"
            Me.TextBox_responsable.Text = usrnom
            Me.Button_guardar.Visible = True

            Label_origen.Visible = False
            Me.ComboBox_ORIGEN.Visible = False

            Label_destino.Visible = True
            Me.ComboBox_DESTINO.Visible = True

            Me.Panel_detalles.Enabled = False

            'Me.Label_info.Text = "Seleccione la Bodega, el tercero y haga click en continuar." : Me.Label_info.Visible = True
            'Me.Button_info.Visible = True
            Me.datagrid_movimientos.Visible = False
            Me.Panel_dock.Visible = False
            ComboBox_tercero.SelectedValue = comex_nit

            RadioButton_salida.Checked = True

            RadioButton_entrada.Visible = True : RadioButton_entrada.Enabled = False
            RadioButton_salida.Visible = True : RadioButton_salida.Enabled = False
            NumericUpDown_anno_mov.Visible = False
            Label6.Visible = False

        End If

        If Me.Combobox_tipo_mov.Text = "Traslado de Mercancia" Then
            If PERMISO_1(12) = "NO" Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub
            Me.Label_tipomovimiento.Visible = True : Me.Label_tipomovimiento.Text = Me.Combobox_tipo_mov.Text
            Me.Combobox_tipo_mov.Visible = False
            Me.Label_tipomov.Visible = False
            Me.ComboBox_PERIODO.Visible = False
            Me.Label_periodo.Visible = False
            Me.Combobox_tipo_mov.Enabled = False
            consecutivo = 0
            cmd.Connection = conex
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select max(documento) + 1 from movimientos where tipodocumento='Traslado de Mercancia'"
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
            llena_combo_bodegas()
            Me.Label_consecutivo.Text = consecutivo
            Me.Label_fecha.Text = DateTime.Now.ToShortDateString
            Me.Label_estado_movimiento.Text = "NUEVO"
            que_movimiento = "Nuevo"
            Me.TextBox_responsable.Text = usrnom
            Me.Button_guardar.Visible = True


            Me.ComboBox_ORIGEN.Visible = True
            Label_origen.Visible = True

            Me.ComboBox_DESTINO.Visible = True
            Label_destino.Visible = True

            Me.Panel_detalles.Enabled = False

            'Me.Label_info.Text = "Seleccione la Bodega, el tercero y haga click en continuar." : Me.Label_info.Visible = True
            'Me.Button_info.Visible = True
            Me.datagrid_movimientos.Visible = False
            Me.Panel_dock.Visible = False
            ComboBox_tercero.SelectedValue = comex_nit

            RadioButton_salida.Checked = True

            RadioButton_entrada.Visible = True : RadioButton_entrada.Enabled = False
            RadioButton_salida.Visible = True : RadioButton_salida.Enabled = False
            NumericUpDown_anno_mov.Visible = False
            Label6.Visible = False

        End If

        If Me.Combobox_tipo_mov.Text = "Ajuste de Inventario" Then

            If PERMISO_1(9) = "NO" Then MsgBox("No esta autorizado.", vbExclamation) : Exit Sub



            Me.Label_tipomovimiento.Visible = True : Me.Label_tipomovimiento.Text = Me.Combobox_tipo_mov.Text
            Me.Combobox_tipo_mov.Visible = False
            Me.Label_tipomov.Visible = False
            Me.ComboBox_PERIODO.Visible = False



            Label_origen.Visible = True

            Me.Label_periodo.Visible = False
            Me.Combobox_tipo_mov.Enabled = False
            consecutivo = 0
            cmd.Connection = conex
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select max(documento) + 1 from movimientos where tipodocumento='Ajuste de Inventario'"
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

            llena_combo_bodegas()

            Me.Label_consecutivo.Text = consecutivo
            Me.Label_fecha.Text = DateTime.Now.ToShortDateString
            Me.Label_estado_movimiento.Text = "NUEVO"
            que_movimiento = "Nuevo"
            Me.TextBox_responsable.Text = usrnom
            Me.Button_guardar.Visible = True

            Me.ComboBox_DESTINO.Visible = True
            Label_destino.Visible = True
            Label_origen.Visible = True

            Me.ComboBox_ORIGEN.Visible = False

            Me.Panel_detalles.Enabled = False


            Me.datagrid_movimientos.Visible = False
            Me.Panel_dock.Visible = False
            Me.Button_guardar.Text = "Continuar"
            ComboBox_tercero.SelectedValue = comex_nit
            ComboBox_DESTINO.Focus()

            RadioButton_salida.Checked = False
            RadioButton_entrada.Checked = False

            RadioButton_entrada.Visible = True : RadioButton_entrada.Enabled = False
            RadioButton_salida.Visible = True : RadioButton_salida.Enabled = False

            NumericUpDown_anno_mov.Visible = False
            Label6.Visible = False

        End If
    End Sub



    Private Sub Button_cerrar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub



    Private Sub TextBox_BARRAS_KeyDown(sender As Object, e As KeyEventArgs)
        'If e.KeyCode = Keys.Enter Then
        '    Timer_PROD_DATA_BARRAS.Enabled = True


        'End If

        If e.KeyCode = Keys.Enter Then
            loads_productos("barras")

            Timer_PROD_DATA_BARRAS.Enabled = True

            combobox_BuscarProd.Focus()

        End If
    End Sub



    Private Sub Timer_movimientos_Tick(sender As Object, e As EventArgs) Handles Timer__ver_movimientos.Tick
        Timer__ver_movimientos.Enabled = False


        mes_num = DateTime.ParseExact(Me.ComboBox_PERIODO.Text, "MMMM", CultureInfo.CurrentCulture).Month
        mes_num_text_general = CStr(mes_num)
        If mes_num <= 9 Then mes_num_text_general = "0" & CStr(mes_num)



        load_movimientos()


    End Sub

    Private Sub Button_anular_conta_Click_1(sender As Object, e As EventArgs)
        Dim RTA = MsgBox("Seguro desea anular los registros en contabilidad?. ", MsgBoxStyle.Question + MsgBoxStyle.YesNo)

        If RTA = 6 Then
            sql = "delete from cajaspuc where documento='" & CInt(Label_consecutivo.Text) & "' and tipodoc='" & Me.Combobox_tipo_mov.Text & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                MsgBox("Error al Borrar el Registro.")
                Exit Sub
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()

            sql = "UPDATE movimientos SET ANULADO='SI', contabilizado='' WHERE DOCUMENTO=" & CInt(Me.Label_consecutivo.Text) & " and tipodocUMENTO='" & Me.Combobox_tipo_mov.Text & "'"
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
    End Sub



    Private Sub ComboBox_DESTINO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox_DESTINO.KeyPress
        e.KeyChar = ""
    End Sub



    Private Sub ComboBox_ORIGEN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox_ORIGEN.KeyPress
        e.KeyChar = ""

    End Sub


    Private Sub combobox_BuscarProd_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles combobox_BuscarProd.SelectionChangeCommitted
        If combobox_BuscarProd.Text = Nothing Then Exit Sub
        If Me.Timer_prod_data.Enabled = True Then Me.Timer_prod_data.Enabled = False

        Me.Timer_prod_data.Enabled = True

    End Sub



    Private Sub NumericUpDown_CANT_KeyDown(sender As Object, e As KeyEventArgs) Handles NumericUpDown_CANT.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button_agregar_prod_Click(Nothing, Nothing)
        End If
    End Sub


    Private Sub BackgroundWorker_work_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Panel_detalles.Enabled = True
    End Sub

    Private Sub Form_movimientos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.Alt = True And e.KeyValue = Keys.A Then

            Button_agregar_prod_Click(Nothing, Nothing)

        End If

        If e.Alt = True And e.KeyValue = Keys.Q Then

            button_Quitar_Prod_Click(Nothing, Nothing)

        End If
    End Sub



    Private Sub Button_AGREGAR_tercero_Click(sender As Object, e As EventArgs)
        If Form_contactos.Visible = True Then
            Form_contactos.BringToFront()
            Exit Sub

        End If


        Form_contactos.Show()
        Form_contactos.Timer_nuevo.Enabled = True

    End Sub

    Private Sub Timer_contactos_Tick(sender As Object, e As EventArgs) Handles Timer_contactos.Tick
        Timer_contactos.Enabled = False

        load_contactos()

    End Sub

    Private Sub TextBox_vencimiento_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.KeyChar = ""
    End Sub



    Private Sub combobox_BuscarProd_KeyDown(sender As Object, e As KeyEventArgs) Handles combobox_BuscarProd.KeyDown
        If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete Then
            If combobox_BuscarProd.Text = "" Then
                TextBox_lote.DataSource = Nothing
                TextBox_lote.Items.Clear()
                'TextBox_vencimiento.Text = ""
                NumericUpDown_CANT.Value = 0
                NumericUpDown_vrUnitario.Value = 0
                TextBox_Total.Text = 0

                prod_barras = ""
                prod_cod = ""
                prod_nom = ""
                prod_desc = ""
                prod_iva = ""
                prod_valor = ""
                PROD_COSTO = ""
                PROD_DECIMAL = ""
            End If


        End If

        If e.KeyCode = Keys.Enter Then
            datos_del_producto("combo")

            calcula_saldo()
        End If


    End Sub

    Private Sub ComboBox_PERIODO_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_PERIODO.SelectionChangeCommitted
        Combobox_tipo_mov.SelectedItem = Nothing


        Timer__ver_movimientos.Enabled = True

    End Sub

    Private Sub TextBox_buscarprod_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_buscarprod.KeyDown
        If e.KeyCode = Keys.Enter And Radio_nombre.Checked = True Then
            Cursor.Current = Cursors.WaitCursor
            loads_productos("nombre")

            If combobox_BuscarProd.Items.Count = 0 Then Exit Sub

            combobox_BuscarProd.Focus()
            Cursor.Current = Cursors.Default

            Exit Sub
        End If


        If e.KeyCode = Keys.Enter And Radio_cod.Checked = True Then
            loads_productos("codigo")

            If combobox_BuscarProd.Items.Count = 0 Then Exit Sub
            If combobox_BuscarProd.Items.Count > 0 Then combobox_BuscarProd.SelectedValue = 1
            combobox_BuscarProd.Focus()
            Exit Sub


        End If

        If e.KeyCode = Keys.Enter And Radio_Bar.Checked = True Then
            loads_productos("barras")

            If combobox_BuscarProd.Items.Count = 0 Then Exit Sub
            If combobox_BuscarProd.Items.Count > 0 Then combobox_BuscarProd.SelectedValue = 1
            combobox_BuscarProd.Focus()
        End If

        If e.KeyCode = Keys.Enter And Radio_ref.Checked = True Then
            loads_productos("referencia")

            If combobox_BuscarProd.Items.Count = 0 Then Exit Sub
            If combobox_BuscarProd.Items.Count > 0 Then combobox_BuscarProd.SelectedValue = 1
            combobox_BuscarProd.Focus()
        End If

    End Sub

    Private Sub combobox_BuscarProd_GotFocus(sender As Object, e As EventArgs) Handles combobox_BuscarProd.GotFocus
        combobox_BuscarProd.BackColor = Color.MistyRose

        combobox_BuscarProd.DroppedDown = True
        combobox_BuscarProd.SelectedItem = Nothing
        combobox_BuscarProd.Text = Nothing
        Cursor.Current = Cursors.Default

    End Sub


    Private Sub Button_maxxi_Click(sender As Object, e As EventArgs) 
        Me.WindowState = FormWindowState.Maximized
        datagrid_movimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub Button_minni_Click(sender As Object, e As EventArgs) 
        Me.WindowState = FormWindowState.Normal
        datagrid_movimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

    End Sub



    Private Sub TextBox_buscarprod_GotFocus(sender As Object, e As EventArgs) Handles TextBox_buscarprod.GotFocus
        TextBox_buscarprod.BackColor = Color.MistyRose
        TextBox_buscarprod.SelectAll()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) 
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub TextBox_buscarprod_LostFocus(sender As Object, e As EventArgs) Handles TextBox_buscarprod.LostFocus
        TextBox_buscarprod.BackColor = Color.AliceBlue

    End Sub

    Private Sub combobox_BuscarProd_LostFocus(sender As Object, e As EventArgs) Handles combobox_BuscarProd.LostFocus
        combobox_BuscarProd.BackColor = Color.AliceBlue

    End Sub

    Private Sub Button_opcionesMOV_Click(sender As Object, e As EventArgs)
        If FlowLayoutPanel1.Height = 34 Then
            FlowLayoutPanel1.Height = 182
            Exit Sub
        End If


        If FlowLayoutPanel1.Height > 34 Then
            FlowLayoutPanel1.Height = 34

        End If

    End Sub



    Private Sub NumericUpDown_CANT_GotFocus(sender As Object, e As EventArgs) Handles NumericUpDown_CANT.GotFocus
        NumericUpDown_CANT.BackColor = Color.MistyRose
        'NumericUpDown_CANT.Select(0, NumericUpDown_CANT.Text.Length)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        If File.Exists("c:\miclickderecho\manualmovsdeinventario.pdf") Then
            Process.Start("c:\miclickderecho\manualmovsdeinventario.pdf")
        Else
            MsgBox("no se encontró el archivo de ayuda, por lo que se cargará desde internet.")
            Me.Cursor = Cursors.WaitCursor
            Try
                ' System.Diagnostics.Process.Start("C:\Archivos de PRograma\Internet Explorer\iexplorer.exe", "www.google.com")
                Dim pag As String
                pag = "http://www.miclickderecho.com/manual/manualmovsdeinventario.pdf"
                Shell("Explorer " & pag)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            Me.Cursor = Cursors.Default



        End If


    End Sub



    Private Sub NumericUpDown_CANT_LostFocus(sender As Object, e As EventArgs) Handles NumericUpDown_CANT.LostFocus
        NumericUpDown_CANT.BackColor = Color.AliceBlue
        Me.TextBox_Total.Text = Math.Round((CDec(Me.NumericUpDown_CANT.Value) * CDec(NumericUpDown_vrUnitario.Text)), 2)

    End Sub

    Private Sub TextBox_vencimiento_GotFocus(sender As Object, e As EventArgs)
        DateTimePicker1.BackColor = Color.MistyRose

    End Sub

    Private Sub TextBox_vencimiento_LostFocus(sender As Object, e As EventArgs)
        DateTimePicker1.BackColor = Color.AliceBlue

    End Sub

    Private Sub TextBox_lote_GotFocus(sender As Object, e As EventArgs) Handles TextBox_lote.GotFocus
        TextBox_lote.BackColor = Color.MistyRose

    End Sub

    Private Sub TextBox_lote_LostFocus(sender As Object, e As EventArgs) Handles TextBox_lote.LostFocus
        TextBox_lote.BackColor = Color.AliceBlue

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


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel_detalles.Enabled = True
        FlowLayoutPanel1.Enabled = True

        BunifuCards_exportar.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        Try

            If RadioButton1.Checked = True Then  ' normal
                sql = "SELECT codprod, producto, rol as Ajuste, cantidad, valorU, valorTotal FROM movimientos_prods WHERE documento = " & CInt(Label_consecutivo.Text) & " and tipodoc='" & Me.Combobox_tipo_mov.Text & "'"

            End If
            If RadioButton3.Checked = True Then   '  pos
                sql = "SELECT codprod, producto, rol as Ajuste, cantidad, ValorU, ValorTotal FROM movimientos_prods WHERE documento = " & CInt(Label_consecutivo.Text) & " and tipodoc='" & Me.Combobox_tipo_mov.Text & "'"
            End If


            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.MetroGrid_pdf.DataSource = dt
            Me.MetroGrid_pdf.Columns(0).HeaderText = "Código"
            Me.MetroGrid_pdf.Columns(0).Width = 50
            Me.MetroGrid_pdf.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.MetroGrid_pdf.Columns(1).HeaderText = "PRODUCTO"
            Me.MetroGrid_pdf.Columns(1).Width = 300
            Me.MetroGrid_pdf.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.MetroGrid_pdf.Columns(2).HeaderText = "Ajuste"
            Me.MetroGrid_pdf.Columns(2).Width = 80
            Me.MetroGrid_pdf.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.MetroGrid_pdf.Columns(3).HeaderText = "Cant"
            Me.MetroGrid_pdf.Columns(3).Width = 80
            Me.MetroGrid_pdf.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.MetroGrid_pdf.Columns(4).HeaderText = "Valor"
            Me.MetroGrid_pdf.Columns(4).Width = 80
            Me.MetroGrid_pdf.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.MetroGrid_pdf.Columns(5).HeaderText = "Total"
            Me.MetroGrid_pdf.Columns(5).Width = 90
            Me.MetroGrid_pdf.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()


        Me.TextBoxTotalDoc1.Text = 0
        Me.TextBoxtotaldoc2.Text = 0

        Try
            For i As Integer = 0 To datagrid_productos.RowCount - 1
                If datagrid_productos.Item("ROL", i).Value = "ENTRAN" Then Me.TextBoxTotalDoc1.Text = CDec(Me.TextBoxTotalDoc1.Text) + CDec(datagrid_productos.Item("valortotal", i).Value)
                If datagrid_productos.Item("ROL", i).Value = "SALEN" Then Me.TextBoxtotaldoc2.Text = CDec(Me.TextBoxtotaldoc2.Text) + CDec(datagrid_productos.Item("valortotal", i).Value)

            Next
            Me.TextBoxTotalDoc1.Text = Format(CDec(Me.TextBoxTotalDoc1.Text), "##,##0.00")  ' SIN REDONDEAR
            Me.TextBoxTotalDoc1.Text = Format(CDec(Me.TextBoxTotalDoc1.Text), "##,##0")    ' REDONEADO

            Me.TextBoxtotaldoc2.Text = Format(CDec(Me.TextBoxtotaldoc2.Text), "##,##0.00")  ' SIN REDONDEAR
            Me.TextBoxtotaldoc2.Text = Format(CDec(Me.TextBoxtotaldoc2.Text), "##,##0")    ' REDONEADO

        Catch ex As Exception
            'MsgBox(ex.Message.ToString)
        End Try


        Try
            alto_pag = (MetroGrid_pdf.RowCount * 25) + 500

            Dim pgSize = New iTextSharp.text.Rectangle(205, alto_pag)
            Dim doc As New Document(pgSize, 8, 8, 10, 10)  'formato pos

            If RadioButton1.Checked = True Then doc = New Document(PageSize.A4, 10, 20, 10, 20)  ' si es formato normal

            'Path que guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\" + Me.Combobox_tipo_mov.Text + " No " & Me.Label_consecutivo.Text & ".pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, file)
            doc.Open()
            If RadioButton1.Checked = True Then
                ExportarDatosPDF_mov(doc)   'normal
            End If
            If RadioButton3.Checked = True Then
                ExportarDatosPOS_mov(doc)   'pos
            End If

            doc.Close()

            Process.Start("C:\Program Files\Tracker Software\PDF Viewer\pdfxcview.exe", """" & Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\" + Me.Combobox_tipo_mov.Text + " No " & Me.Label_consecutivo.Text & ".pdf" & """")

        Catch ex As Exception
            'Si el intento es fallido, mostrar MsgBox.
            MessageBox.Show("No se puede generar el documento PDF, Cierre los documentos PDF generados anteriormente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Cursor = Cursors.Default



        Button4_Click(Nothing, Nothing)
        Me.Cursor = Cursors.Default
    End Sub



    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles Radio_Bar.CheckedChanged
        TextBox_buscarprod.Focus()
        TextBox_buscarprod.SelectAll()
    End Sub

    Private Sub Radio_cod_CheckedChanged(sender As Object, e As EventArgs) Handles Radio_cod.CheckedChanged
        TextBox_buscarprod.Focus()
        TextBox_buscarprod.SelectAll()

    End Sub

    Private Sub Radio_nombre_CheckedChanged(sender As Object, e As EventArgs) Handles Radio_nombre.CheckedChanged
        TextBox_buscarprod.Focus()
        TextBox_buscarprod.SelectAll()

    End Sub



    Private Sub datagrid_movimientos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_movimientos.CellDoubleClick
        Btn_Ver_editar_Click(Nothing, Nothing)
    End Sub

    Private Sub hacer_movimiento()

        Dim TERCEROO As String = CStr(ComboBox_tercero.SelectedValue) & "|" & CStr(ComboBox_tercero.Text)


        Dim bodega_out_nom As String = ""
        Dim bodega_in_nom As String = ""

        bodega_out_nom = ComboBox_ORIGEN.Text
        bodega_in_nom = ComboBox_DESTINO.Text

        Dim bodega_out_online As String = ""
        Try

            sql = "SELECT observaciones from bodegas where cons='" & ComboBox_ORIGEN.SelectedValue & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                bodega_out_online = row.Item("DESCRIPCION")
            Next
        Catch ex As Exception
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()

        Dim bodega_in_online As String = ""
        Try

            sql = "SELECT observaciones from bodegas where cons='" & ComboBox_DESTINO.SelectedValue & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                bodega_in_online = row.Item("DESCRIPCION")
            Next
        Catch ex As Exception
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()

        ' salida del movimiento
        Cursor.Current = Cursors.WaitCursor

        Try
            For J As Integer = 0 To Me.datagrid_productos.RowCount - 1
                PROD_SALEN = 0
                PROD_SALDO = 0
                PROD_SALDO = 0

                Dim saldo As String = 0


                PROD_SALEN = Me.datagrid_productos.Item("cantidad", J).Value  ' TOMO LA CANTIDAD DEL GRID Q ESTA RECORRIENDO
                PROD_SALDO = saldo  ' IGUALDO SALDO PROD CON EL SALDO CALCULADO EN BODEGA PRICIPAL
                PROD_SALDO = CInt(PROD_SALDO) - CInt(PROD_SALEN)
                PROD_ENTRAN = 0 ' POR QUE QUE ES UNA COMPRA


                Dim rol As String = ""
                rol = "SALEN"
                PROD_COSTO_TOTAL = CLng(Me.datagrid_productos.Item("valoru", J).Value) * CInt(PROD_SALEN)
                PROD_COSTO = CStr(Me.datagrid_productos.Item("valoru", J).Value)
                PROD_DECIMAL = CStr(Me.datagrid_productos.Item("DECI", J).Value)
                sql = "INSERT INTO bodega_" & bodega_out_nom & " (fecha, nombodega, TipoDocumento, Documento, tercero, Rol, CodProducto, Producto, saldoant, Entran, Salen, Saldo, valoru, valortotal, Empleado, Estado, DECI, COSTO, lote,vence)" &
                        "VALUES ('" & DateTime.Now.ToShortDateString & "','" & bodega_out_nom & "','" & Me.Combobox_tipo_mov.Text & "'," & CInt(Me.Label_consecutivo.Text) & ",'" & TERCEROO & "','SALEN','" & CStr(Me.datagrid_productos.Item("CODPROD", J).Value) & "','" & CStr(Me.datagrid_productos.Item("PRODUCTO", J).Value) & "','" & saldo & "','0','" & PROD_SALEN & "','" & PROD_SALDO & "','" & CLng(Me.datagrid_productos.Item("valoru", J).Value) & "','" & (Me.datagrid_productos.Item("valortotal", J).Value) & "','" & usrnom & "','DESCARGADO','" & PROD_DECIMAL & "','" & PROD_COSTO & "','" & CStr(datagrid_productos.Item("lote", J).Value) & "','" & CStr(datagrid_productos.Item("vence", J).Value) & "')"

                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                Try
                    da.Fill(dt)
                Catch ex As Exception
                    If ex.ToString.Contains("Duplicate entry") Then MsgBox("Error al actualizar EN KARDEX DE BODEGA", vbExclamation)
                    'MsgBox(ex.ToString)
                End Try
                da.Dispose()
                dt.Dispose()
                conex.Close()

                PROD_SALEN = 0
                PROD_SALDO = 0
                PROD_SALDO = 0

            Next
        Catch ex As Exception
            Cursor.Current = Cursors.Default

            MsgBox(ex.Message.ToString)
        End Try

        PROD_SALEN = 0
        PROD_SALDO = 0
        PROD_SALDO = 0

        Cursor.Current = Cursors.Default


        Cursor.Current = Cursors.WaitCursor
        ' entrada del movimiento
        Cursor.Current = Cursors.WaitCursor

        Try
            For J As Integer = 0 To Me.datagrid_productos.RowCount - 1
                PROD_SALEN = 0
                PROD_SALDO = 0
                PROD_SALDO = 0

                Dim saldo As String = 0


                PROD_ENTRAN = Me.datagrid_productos.Item("cantidad", J).Value  ' TOMO LA CANTIDAD DEL GRID Q ESTA RECORRIENDO
                PROD_SALDO = saldo  ' IGUALDO SALDO PROD CON EL SALDO CALCULADO EN BODEGA PRICIPAL
                PROD_SALDO = CInt(PROD_SALDO) + CInt(PROD_ENTRAN)
                PROD_SALEN = 0 ' POR QUE QUE ES UNA COMPRA


                Dim rol As String = ""
                rol = "ENTRAN"
                PROD_COSTO_TOTAL = CLng(Me.datagrid_productos.Item("valoru", J).Value) * CInt(PROD_ENTRAN)
                PROD_COSTO = CInt(Me.datagrid_productos.Item("valoru", J).Value)
                PROD_DECIMAL = CStr(Me.datagrid_productos.Item("DECI", J).Value)
                sql = "INSERT INTO bodega_" & bodega_in_nom & " (fecha, nombodega, TipoDocumento, Documento, tercero, Rol, CodProducto, Producto, saldoant, Entran, Salen, Saldo, valoru, valortotal, Empleado, Estado, DECI, COSTO, lote,vence)" &
                        "VALUES ('" & DateTime.Now.ToShortDateString & "','" & bodega_in_nom & "','" & Me.Combobox_tipo_mov.Text & "'," & CInt(Me.Label_consecutivo.Text) & ",'" & TERCEROO & "','SALEN','" & CStr(Me.datagrid_productos.Item("CODPROD", J).Value) & "','" & CStr(Me.datagrid_productos.Item("PRODUCTO", J).Value) & "','" & saldo & "','" & PROD_ENTRAN & "','" & PROD_SALEN & "','" & PROD_SALDO & "','" & CLng(Me.datagrid_productos.Item("valoru", J).Value) & "','" & (Me.datagrid_productos.Item("valortotal", J).Value) & "','" & usrnom & "','DESCARGADO','" & PROD_DECIMAL & "','" & PROD_COSTO & "','" & CStr(datagrid_productos.Item("lote", J).Value) & "','" & CStr(datagrid_productos.Item("vence", J).Value) & "')"

                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                Try
                    da.Fill(dt)
                Catch ex As Exception
                    If ex.ToString.Contains("Duplicate entry") Then MsgBox("Error al actualizar EN KARDEX DE BODEGA", vbExclamation)
                    'MsgBox(ex.ToString)
                End Try
                da.Dispose()
                dt.Dispose()
                conex.Close()

                PROD_SALEN = 0
                PROD_SALDO = 0
                PROD_SALDO = 0

            Next
        Catch ex As Exception
            Cursor.Current = Cursors.Default

            MsgBox(ex.Message.ToString)
        End Try

        PROD_SALEN = 0
        PROD_SALDO = 0
        PROD_SALDO = 0

        sql = "UPDATE movimientos_prods SET estado='DESCARGADO' WHERE DOCUMENTO=" & CInt(Me.Label_consecutivo.Text) & " and tipodoc='" & Me.Combobox_tipo_mov.Text & "'"
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

        sql = "UPDATE MOVIMIENTOS SET observaciones='" & CStr(Me.Text_leyenda.Text) & "', estado='DESCARGADO' WHERE DOCUMENTO=" & CInt(Me.Label_consecutivo.Text) & " AND TIPODOCUMENTO='" & Me.Combobox_tipo_mov.Text & "'"
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

        Me.Label_estado_movimiento.Text = "TRASLADO"
        Me.ButtonDescargar.Visible = False
        Me.Button_anular.Visible = True

        Me.Button_agregar_prod.Visible = False
        Me.button_Quitar_Prod.Visible = False


        Me.Cursor = Cursors.Default


    End Sub

    Private Sub TextBox_ref_TextChanged(sender As Object, e As EventArgs) Handles TextBox_ref.TextChanged

    End Sub

    Private Sub Button_GUARDAR_REF_Click(sender As Object, e As EventArgs) Handles Button_GUARDAR_REF.Click
        sql = "update movimientos set rferencia='" & TextBox_ref.Text & "' where documento='" & Label_consecutivo.Text & "'"
        da = New MySqlDataAdapter(sql, conex)
        dt = New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            MsgBox("Error Actualizando Referencia en estado " & Label_estado_movimiento.Text, vbObjectError)
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()
    End Sub

    Private Sub Combobox_tipo_mov_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combobox_tipo_mov.SelectedIndexChanged

    End Sub

    Private Sub datagrid_movimientos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_movimientos.CellContentClick

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Timer__ver_movimientos.Enabled = True
    End Sub

    Private Sub ComboBox_PERIODO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_PERIODO.SelectedIndexChanged

    End Sub

    Private Sub TimerVerLoad_Tick(sender As Object, e As EventArgs) Handles TimerVerLoad.Tick
        TimerVerLoad.Enabled = False

        CodDocumento = CodMovimientoVer
        TipoDocumento = TipoMovimientoVer


        CodMovimientoVer = ""
        TipoMovimientoVer = ""
    End Sub

    Private Sub combobox_BuscarProd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles combobox_BuscarProd.KeyPress
        If combobox_BuscarProd.DroppedDown = True Then
            combobox_BuscarProd.DroppedDown = False
        End If
    End Sub



    Private Sub BackgroundWorker_excel_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        datagrid_movimientos.Visible = True
        TabControl_detalle.Visible = True

        Me.Cursor = Cursors.Default
        Panel_dock.Visible = True
        Combobox_tipo_mov.Visible = True
        ComboBox_PERIODO.Visible = True
        Label22.Visible = True
        Label_tipomov.Visible = True
        Label_periodo.Visible = True

        TextBoxTotalDoc1.Visible = True
        TextBoxtotaldoc2.Visible = True

        TextBox_responsable.Visible = True
        Text_leyenda.Visible = True

        Label9.Visible = True
        Label8.Visible = True
        Label7.Visible = True
        'load docuemtno?????
        Dim RTA As String
        RTA = MsgBox("Se Generó el informe " & Chr(13) & Chr(13) & "Desea Ver el archivo ahora?.", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If RTA = 6 Then
            System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Reporte de movimientos.xlsx")
        End If
    End Sub

    Private Sub Button_ayuda_Click(sender As Object, e As EventArgs) Handles Button_ayuda.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            ' System.Diagnostics.Process.Start("C:\Archivos de PRograma\Internet Explorer\iexplorer.exe", "www.google.com")
            Dim pag As String
            pag = "http://www.miclickderecho.com/ayudamovimientos.html"
            Shell("Explorer " & pag)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Cursor = Cursors.Default
    End Sub



    Private Sub Button_importar_Click(sender As Object, e As EventArgs) Handles Button_importar.Click

        Dim RTA As String = ""
        RTA = MsgBox("Desea Importar el inventario actual ?. ", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If RTA = 6 Then
            Panel_detalles.Enabled = False
            FlowLayoutPanel1.Enabled = False
            Try
                'todos los saldos
                sql = "SELECT B.CodProducto, P.Categoria, concat(p.NOMBRE,' ',p.ref,' ',p.presentacion) as nombre, 
format(sum(B.entran)-sum(B.salen),2) as Saldo, P.Presentacion, 
format(avg(B.COSTO),2) AS Costo, 
format((sum(B.entran)-sum(B.salen))*(avg(B.COSTO)),2) as CostoTotal,
p.Valor, p.valor2, p.valor3,
p.Stock, p.Sugerido, P.Maximo, B.Lote, b.Vence
FROM bodega_" & ComboBox_DESTINO.Text & " B, PRODUCTOS P
WHERE B.CODPRODUCTO=P.COD GROUP BY B.CODPRODUCTO, B.LOTE order by saldo"

                'saldo por producto

                da_BODEGAS = New MySqlDataAdapter(sql, conex)
                dt_BODEGAS = New DataTable
                da_BODEGAS.Fill(dt_BODEGAS)
                Me.datagrid.DataSource = dt_BODEGAS


            Catch ex As Exception
                MsgBox(ex.Message)
                conex.Close()
                da.Dispose()
                dt_BODEGAS.Dispose()
            End Try
            conex.Close()
            da_BODEGAS.Dispose()
            dt_BODEGAS.Dispose()
            Me.datagrid.ClearSelection()
            TextBox_Total.Text = 0
            Dim costobo As String = 0
            Dim Precio1 As String = 0
            Dim Precio2 As String = 0
            Dim Precio3 As String = 0


            For Each fila As DataGridViewRow In datagrid.Rows
                Cursor.Current = Cursors.WaitCursor

                sql = "INSERT INTO movimientos_prods (documento, tipodoc, codprod, producto, cantidad, valoru, valortotal, estado, lote, vence, ROL)" &
             "VALUES (" & CInt(Me.Label_consecutivo.Text) & ",'" & CStr(Me.Combobox_tipo_mov.Text) & "',
             '" & (fila.Cells("CodProducto").Value.ToString) & "','" & (fila.Cells("nombre").Value.ToString) & "',
             '" & (fila.Cells("Saldo").Value.ToString.Replace(",", "").ToString.Replace(".", ",")) & "','" & (fila.Cells("Costo").Value.ToString.Replace(",", "").ToString.Replace(".", ",")) & "','" & (fila.Cells("CostoTotal").Value.ToString.Replace(",", "").ToString.Replace(".", ",")) & "','SIN DESCARGAR',
             '" & (fila.Cells("lote").Value.ToString) & "','" & (fila.Cells("vence").Value.ToString) & "',
             'ENTRAN')"
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

            Next
            Cursor.Current = Cursors.Default
            Panel_detalles.Enabled = True
            FlowLayoutPanel1.Enabled = True
            Timer_gridProds.Enabled = True
        End If

    End Sub



    Private Sub Button_guardar_obs_Click(sender As Object, e As EventArgs) Handles Button_guardar_obs.Click
        sql = "UPDATE movimientos SET observaciones='" & Text_leyenda.Text & "' WHERE documento=" & CLng(Label_consecutivo.Text) & " and tipodocumento='" & Me.Combobox_tipo_mov.Text.ToString & "'"
        da = New MySqlDataAdapter(sql, conex)
        dt = New DataTable
        Try
            da.Fill(dt)
            'MsgBox("Tarifa Actualizada.   :).", vbInformation)
        Catch ex As Exception
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()
        Exit Sub
    End Sub


    Private Sub NumericUpDown_vrUnitario_GotFocus(sender As Object, e As EventArgs) Handles NumericUpDown_vrUnitario.GotFocus
        NumericUpDown_vrUnitario.BackColor = Color.MistyRose
        NumericUpDown_vrUnitario.Select(0, NumericUpDown_vrUnitario.Value.ToString.Length)

    End Sub

    Private Sub NumericUpDown_vrUnitario_LostFocus(sender As Object, e As EventArgs) Handles NumericUpDown_vrUnitario.LostFocus
        NumericUpDown_vrUnitario.BackColor = Color.AliceBlue
        Me.TextBox_Total.Text = Math.Round((CDec(Me.NumericUpDown_CANT.Value) * CDec(NumericUpDown_vrUnitario.Text)), 2)

        TextBox_buscarprod.Focus()

    End Sub



    Private Sub NumericUpDown_vrUnitario_KeyDown(sender As Object, e As KeyEventArgs) Handles NumericUpDown_vrUnitario.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button_agregar_prod_Click(Nothing, Nothing)
        End If
    End Sub



    Private Sub TextBoxtotaldoc2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxtotaldoc2.KeyPress
        e.KeyChar = ""

    End Sub



    Private Sub ComboBox_DESTINO_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_DESTINO.SelectionChangeCommitted
        sql = "UPDATE movimientos SET CODDESTINO=" & Me.ComboBox_DESTINO.SelectedValue & ", DESTINO='" & Me.ComboBox_DESTINO.Text.ToString & "' WHERE documento=" & CLng(Label_consecutivo.Text) & " and tipodocumento='" & Me.Combobox_tipo_mov.Text.ToString & "'"
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

    Private Sub ComboBox_ORIGEN_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_ORIGEN.SelectionChangeCommitted
        sql = "UPDATE movimientos SET CODORIGEN=" & Me.ComboBox_ORIGEN.SelectedValue & ", ORIGEN='" & Me.ComboBox_ORIGEN.Text.ToString & "' WHERE documento=" & CLng(Label_consecutivo.Text) & " and tipodocumento='" & Me.Combobox_tipo_mov.Text.ToString & "'"
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

    Private Sub ComboBox_tercero_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_tercero.SelectionChangeCommitted
        sql = "UPDATE movimientos SET doctercero=" & Me.ComboBox_tercero.SelectedValue & ", tercero='" & Me.ComboBox_tercero.Text.ToString & "' WHERE documento=" & CLng(Label_consecutivo.Text) & " and tipodocumento='" & Me.Combobox_tipo_mov.Text.ToString & "'"
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


End Class