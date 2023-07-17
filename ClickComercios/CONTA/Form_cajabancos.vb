Imports System.Globalization
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class Form_cajabancos
    Dim que_hace As String = ""
    Dim que_MOVIMIENTO_hace As String = ""
    Dim DOC As String = ""
    Dim SQLTXT As String = ""
    Dim cod_cajabanco As String = ""
    Dim cod_mediospagos As String = ""
    Dim mediospago_tipo As String = ""
    Dim cod_mediospagos_cuentas As String = ""
    Dim cod_movimiento As String = ""

    Dim mes_num As Integer
    Dim mes_num_text As String
    Dim mes_num2 As Integer
    Dim mes_num_text2 As String


    Dim PROD_SALDO, PROD_SALDO2, PROD_ENTRAN, PROD_SALEN As Integer

    Dim entran, salen, saldo As Integer
    Dim cod_cuenta_para_movimeinto_origen As String
    Dim cod_cuenta_para_movimeinto_destino As String

    Dim ctapucFULL1 As String = ""
    Dim ctapuc1() As String

    Dim ctapucFULL2 As String = ""
    Dim ctapuc2() As String

    Dim rol As String = ""

    Public da_COMBO_CAJAS As New MySqlDataAdapter
    Public dT_COMBO_CAJAS As New DataTable

    Public da_COMBO_BANCOS As New MySqlDataAdapter
    Public dT_COMBO_BANCOS As New DataTable

    Public da_COMBO_CREDITO As New MySqlDataAdapter
    Public dT_COMBO_CREDITO As New DataTable

    Public da_COMBO_CARTERA As New MySqlDataAdapter
    Public dT_COMBO_CARTERA As New DataTable

    Public da_MOVS_CAJAS_LIST As New MySqlDataAdapter
    Public dT_MOVS_CAJAS_LIST As New DataTable

    Public da_MOVS_CARTERAS_LIST As New MySqlDataAdapter
    Public dT_MOVS_CARTERAS_LIST As New DataTable









    Private Sub GRID_movimientos()
        If mes_num_text = "" Then Exit Sub
        Try
            sql = "SELECT cons, tipo, comprobante, tercero, fecha, codorigen, origen, coddestino, destino, observaciones, empleado, cast(valor as signed) as valor, estado from movimientoscuentas WHERE month(STR_TO_DATE(fecha,'%d/%m/%Y'))=" & mes_num_text & ""
            da_MOVIMIENTOS_GRID = New MySqlDataAdapter(sql, conex)
            dt_MOVIMIENTOS_GRID = New DataTable
            da_MOVIMIENTOS_GRID.Fill(dt_MOVIMIENTOS_GRID)
            MetroGrid_movimientos.DataSource = dt_MOVIMIENTOS_GRID
            MetroGrid_movimientos.Columns(0).Visible = False
            MetroGrid_movimientos.Columns(1).Visible = False
            MetroGrid_movimientos.Columns(2).Visible = False
            MetroGrid_movimientos.Columns(3).Visible = False
            MetroGrid_movimientos.Columns(4).HeaderText = "Fecha"
            MetroGrid_movimientos.Columns(4).Width = 80

            MetroGrid_movimientos.Columns(5).Visible = False
            MetroGrid_movimientos.Columns(6).HeaderText = "Origen"
            MetroGrid_movimientos.Columns(6).Width = 200

            MetroGrid_movimientos.Columns(7).Visible = False
            MetroGrid_movimientos.Columns(8).HeaderText = "Destino"
            MetroGrid_movimientos.Columns(8).Width = 200

            MetroGrid_movimientos.Columns(9).Visible = False
            MetroGrid_movimientos.Columns(10).Visible = False

            MetroGrid_movimientos.Columns(11).HeaderText = "Valor"
            MetroGrid_movimientos.Columns(11).Width = 100
            MetroGrid_movimientos.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            MetroGrid_movimientos.Columns(11).DefaultCellStyle.Format = "C"

            Me.MetroGrid_movimientos.Columns(12).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
            conex.Close()
            da_MOVIMIENTOS_GRID.Dispose()
            dt_MOVIMIENTOS_GRID.Dispose()
        End Try
        conex.Close()
        da_MOVIMIENTOS_GRID.Dispose()
        dt_MOVIMIENTOS_GRID.Dispose()


        MetroGrid_movimientos.ClearSelection()

    End Sub


    'Private Sub llenar_combo_cta_puc_cajas()
    '    Try
    '        sql = "SELECT CONS, CONCAT(codigo,'|',cuenta) AS NOMBRE FROM cuentaspuc where left(codigo,4)='1105'"
    '        da_combo_ctapuc_vender_cat = New MySqlDataAdapter(sql, conex)
    '        dt_combo_ctapuc_vender_cat = New DataTable
    '        da_combo_ctapuc_vender_cat.Fill(dt_combo_ctapuc_vender_cat)
    '        Me.ComboBox_cuentapuc.DataSource = dt_combo_ctapuc_vender_cat.DefaultView
    '        Me.ComboBox_cuentapuc.DisplayMember = "NOMBRE"
    '        Me.ComboBox_cuentapuc.ValueMember = "CONS"
    '        Me.ComboBox_cuentapuc.AutoCompleteSource = AutoCompleteSource.ListItems
    '        Me.ComboBox_cuentapuc.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    '    conex.Close()
    '    da_combo_ctapuc_vender_cat.Dispose()
    '    dt_combo_ctapuc_vender_cat.Dispose()
    '    conex.Close()
    'End Sub
    'Private Sub llenar_combo_cta_puc_bancos()
    '    Try
    '        sql = "SELECT CONS, CONCAT(codigo,'|',cuenta) AS NOMBRE FROM cuentaspuc where left(codigo,4)='1110'"
    '        da_combo_ctapuc_vender_cat = New MySqlDataAdapter(sql, conex)
    '        dt_combo_ctapuc_vender_cat = New DataTable
    '        da_combo_ctapuc_vender_cat.Fill(dt_combo_ctapuc_vender_cat)
    '        Me.ComboBox_cuentapuc.DataSource = dt_combo_ctapuc_vender_cat.DefaultView
    '        Me.ComboBox_cuentapuc.DisplayMember = "NOMBRE"
    '        Me.ComboBox_cuentapuc.ValueMember = "CONS"
    '        Me.ComboBox_cuentapuc.AutoCompleteSource = AutoCompleteSource.ListItems
    '        Me.ComboBox_cuentapuc.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    '    conex.Close()
    '    da_combo_ctapuc_vender_cat.Dispose()
    '    dt_combo_ctapuc_vender_cat.Dispose()
    '    conex.Close()
    'End Sub


    Private Sub LLENAR_COMBOS()


        '  cargo el combo de cajas
        Try
            sql = "SELECT CONS, CONCAT(NOMBRE,'|',NUMERO) AS NOMBREn, nombre, numero, cuentapuc FROM CAJAsYBANCOS WHERE TIPO='CAJA' OR TIPO='BANCO'"
            da_COMBO_CAJAS = New MySqlDataAdapter(sql, conex)
            dt_COMBO_CAJA = New DataTable
            da_COMBO_CAJAS.Fill(dt_COMBO_CAJA)
            Me.MetroComboBox_CAJAS.DataSource = dt_COMBO_CAJA.DefaultView
            Me.MetroComboBox_CAJAS.DisplayMember = "NOMBRE"
            Me.MetroComboBox_CAJAS.ValueMember = "CONS"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_COMBO_CAJAS.Dispose()
        dt_COMBO_CAJA.Dispose()
        conex.Close()





    End Sub

    Private Sub LLENAGRID_CAJABANCOS()
        Try
            sql = "SELECT * from cajasybancos WHERE ESTADO='ACTIVA' and tipo in('CAJA','BANCO') order by cuentapuc"

            da_cajas = New MySqlDataAdapter(sql, conex)
            dt_cajas = New DataTable
            da_cajas.Fill(dt_cajas)
            Me.Grid_cajas.DataSource = dt_cajas

            Me.Grid_cajas.Columns(0).Visible = False
            Me.Grid_cajas.Columns(1).Visible = False
            Me.Grid_cajas.Columns(2).Visible = False
            Me.Grid_cajas.Columns(3).Visible = False

            'Me.Grid_cajasybancos.Columns(1).HeaderText = "Tipo"
            'Me.Grid_cajasybancos.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'Me.Grid_cajasybancos.Columns(1).Width = 100
            'Me.Grid_cajas.Columns(2).HeaderText = "ID"
            'Me.Grid_cajas.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'Me.Grid_cajas.Columns(2).Width = 80
            'Me.Grid_cajas.Columns(3).HeaderText = "Cuenta PUC"
            'Me.Grid_cajas.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'Me.Grid_cajas.Columns(3).Width = 90
            Me.Grid_cajas.Columns(4).HeaderText = "NOMBRE"
            Me.Grid_cajas.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.Grid_cajas.Columns(4).Width = 150

            Me.Grid_cajas.Columns(5).HeaderText = "Descripción"
            Me.Grid_cajas.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.Grid_cajas.Columns(5).Width = 250

            Me.Grid_cajas.Columns(6).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
            conex.Close()
            da_cajas.Dispose()
            dt_cajas.Dispose()
        End Try
        conex.Close()
        da_cajas.Dispose()
        dt_cajas.Dispose()

        Grid_cajas.ClearSelection()



    End Sub

    Private Sub Form_cajabancos_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Timer1.Enabled = True


    End Sub


    Private Sub Grid_cajasybancos_SelectionChanged(sender As Object, e As EventArgs) Handles Grid_cajas.SelectionChanged


    End Sub

    Private Sub Button_agregarCajabanc_Click(sender As Object, e As EventArgs) Handles Button_agregarCajabanc.Click
        que_hace = "crear"

        RadioButton_BANCO.Enabled = True
        RadioButton_CAJA.Enabled = True
        TextBox_nro_cajabanco.Enabled = True
        TextBox_nombre_cuentabanco.Enabled = True

        Me.Grid_cajas.ClearSelection()


        Me.Panel_informacion_me.Enabled = True
        TextBox_nro_cajabanco.Text = ""
        TextBox_nombre_cuentabanco.Text = ""

        Me.RadioButton_CAJA.Checked = True

        Me.Panel_guarda.Visible = True

        Me.Panel_crear.Enabled = False
        Grid_cajas.Visible = False
        Panel_informacion_me.Visible = True

        Label_CodCtaCajaBanco.Text = ""

        RadioButton_CAJA.Checked = True
        RadioButton_CAJA_CheckedChanged(Nothing, Nothing)

    End Sub

    Private Sub Button_cancel_crear_cuentabanc_Click(sender As Object, e As EventArgs) Handles Button_cancel_crear_cuentabanc.Click
        Me.Panel_informacion_me.Enabled = False
        TextBox_nro_cajabanco.Text = ""
        TextBox_nombre_cuentabanco.Text = ""

        Me.RadioButton_CAJA.Checked = True

        Me.Panel_guarda.Visible = False

        Me.Panel_crear.Enabled = True

        RadioButton_BANCO.Enabled = False
        RadioButton_CAJA.Enabled = False
        TextBox_nro_cajabanco.Enabled = False
        TextBox_nombre_cuentabanco.Enabled = False

        que_hace = ""

        Grid_cajas.Visible = True



        cod_cajabanco = ""
        Panel_informacion_me.Visible = False

        Grid_cajas.ClearSelection()

    End Sub

    Private Sub Button_cajabanc_Click(sender As Object, e As EventArgs) Handles Button_cajabanc.Click


        If cod_cajabanco = "" Then
            MsgBox("Seleccione una cuenta de caja o banco.", vbInformation)
            Exit Sub
        End If

        que_hace = "modificar"

        Me.Panel_guarda.Visible = True
        Me.Panel_informacion_me.Enabled = True
        Me.Panel_crear.Enabled = False

        RadioButton_BANCO.Enabled = True
        RadioButton_CAJA.Enabled = True
        TextBox_nombre_cuentabanco.Enabled = True



        Grid_cajas.Visible = False

        Panel_informacion_me.Visible = True
    End Sub

    Private Sub Button_guardar_cajabanc_Click(sender As Object, e As EventArgs) Handles Button_guardar_cajabanc.Click
        'If cod_cajabanco = "1" Or cod_cajabanco = "4" Or cod_cajabanco = "5" Then
        '    MsgBox("No puede modificar este item.", vbInformation)
        '    Exit Sub
        'End If


        'If TextBox_nro_cajabanco.Text = "" Then MsgBox("Debe escribir un número para identificar la cuenta", vbInformation) : Exit Sub
        If TextBox_nombre_cuentabanco.Text = "" Then MsgBox("Debe escribir un nombre para identificar la cuenta", vbInformation) : Exit Sub


        If que_hace = "crear" Then
            If RadioButton_BANCO.Checked = True Then sql = "INSERT INTO CAJAsYBANCOS(tipo, numero, nombre, descripcion, estado) VALUES('BANCO','" & CStr(TextBox_nro_cajabanco.Text) & "','" & CStr(Me.TextBox_nombre_cuentabanco.Text) & "','" & CStr(Me.TextBox_descripcioncajabanco.Text) & "','ACTIVA')"
            If RadioButton_CAJA.Checked = True Then sql = "INSERT INTO CAJAsYBANCOS(tipo, numero, nombre, descripcion, estado) VALUES('CAJA','" & CStr(TextBox_nro_cajabanco.Text) & "','" & CStr(Me.TextBox_nombre_cuentabanco.Text) & "','" & CStr(Me.TextBox_descripcioncajabanco.Text) & "','ACTIVA')"

            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
                'MsgBox("Se Guardó correctamente. ", vbInformation)
            Catch ex As Exception
                If ex.ToString.Contains("Duplicate entry") Then MsgBox(" ya se encuentra en la lista", vbExclamation)
                MsgBox(ex.ToString)
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()

            'last id
            sql = "Select last_insert_id() as lastid"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                For Each row As DataRow In dt.Rows
                    Label_CodCtaCajaBanco.Text = row.Item("lastid").ToString
                Next
            End If
            da.Dispose()
            dt.Dispose()
            conex.Close()

        End If

        If que_hace = "modificar" Then
            sql = "UPDATE CAJAsYBANCOS SET numero='" & CStr(TextBox_nro_cajabanco.Text) & "', nombre='" & CStr(Me.TextBox_nombre_cuentabanco.Text) & "', descripcion='" & TextBox_descripcioncajabanco.Text & "', estado='ACTIVA' WHERE CONS=" & cod_cajabanco & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            Try
                da.Fill(dt)
                'MsgBox("Se Guardó correctamente. ", vbInformation)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()

        End If


        Me.Panel_informacion_me.Enabled = False
        Me.Panel_crear.Enabled = True
        Me.Panel_guarda.Visible = False

        RadioButton_BANCO.Enabled = False
        RadioButton_CAJA.Enabled = False
        TextBox_nro_cajabanco.Enabled = False
        TextBox_nombre_cuentabanco.Enabled = False

        LLENAGRID_CAJABANCOS()

        LLENAR_COMBOS()

        Grid_cajas.ClearSelection()


        Grid_cajas.Visible = True

        Panel_informacion_me.Visible = False
        cod_cajabanco = ""
    End Sub

    Private Sub Grid_cajasybancos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid_cajas.CellContentClick

    End Sub

    Private Sub Form_cajabancos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Grid_cajas.BringToFront()
        Panel_informacion_me.Visible = False

        'oculto el tab
        Me.MetroTabControl1.SelectTab(0)

        'If USRCARGO <> "Administrador" And USRCARGO <> "Administrador Sistema" And USRCARGO <> "Soporte técnico" And USRCARGO <> "Administrador Local" Then
        '    Me.MetroTabPage4.Hide()
        '    Me.MetroTabPage4.Parent = Nothing

        'End If


    End Sub

    Private Sub Grid_cajasybancos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid_cajas.CellClick
        Me.RadioButton_BANCO.Checked = False
        Me.RadioButton_CAJA.Checked = True



        Dim row As DataGridViewRow = Grid_cajas.CurrentRow
        cod_cajabanco = CStr(row.Cells("cons").Value)
        Label_CodCtaCajaBanco.Text = cod_cajabanco

        If CStr(row.Cells("tipo").Value) = "CAJA" Then Me.RadioButton_CAJA.Checked = True : RadioButton_CAJA_CheckedChanged(Nothing, Nothing)
        If CStr(row.Cells("tipo").Value) = "BANCO" Then Me.RadioButton_BANCO.Checked = True : RadioButton_BANCO_CheckedChanged(Nothing, Nothing)

        Me.TextBox_nro_cajabanco.Text = CStr(row.Cells("numero").Value)
        Me.TextBox_nombre_cuentabanco.Text = CStr(row.Cells("nombre").Value)
        Label16.Text = "Número de la Caja" : Label15.Text = "Nombre de la Caja"

        Me.TextBox_descripcioncajabanco.Text = CStr(row.Cells("descripcion").Value)


    End Sub

    Private Sub Button_eliminar_cuentabanc_Click(sender As Object, e As EventArgs) Handles Button_eliminar_cuentabanc.Click
        If cod_cajabanco = "1" Then
            MsgBox("No puede Eliminar esta cuenta, es un requisito mínimo del sistema.", vbInformation)
            Exit Sub
        End If

        If cod_cajabanco = "" Then
            MsgBox("Seleccione una cuenta o banco.", vbInformation)
            Exit Sub
        End If



        'verifico si la cta tiene saldo =====================================================
        Dim saldocta As String = "0"
        Try
            sql = "Select SUM(DEBE)-SUM(HABER) As SALDO from CAJASPUC WHERE CODCUENTA='" & cod_cajabanco & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                If Convert.ToString(row.Item("SALDO")) <> "" Then saldocta = row.Item("SALDO").ToString Else saldocta = "0"
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()
        saldocta = Format(CDec(saldocta), "##,##0")
        If CInt(saldocta) > 0 Then
            MsgBox("No puede Eliminar, la cuenta actualmente tiene una saldo de:  $" & saldocta, vbInformation)
            Exit Sub
        End If
        '=====================================================================================





        sql = "delete from CAJASYBANCOS wheRE CONS=" & CInt(cod_cajabanco) & ""
        da = New MySqlDataAdapter(sql, conex)
        dt = New DataTable
        Try
            da.Fill(dt)
            'MsgBox("Se Guardó correctamente. ", vbInformation)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()





        Button_cancel_crear_cuentabanc_Click(Nothing, Nothing)

        LLENAGRID_CAJABANCOS()

        LLENAR_COMBOS()
    End Sub

    Private Sub MetroComboBox_CAJAS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroComboBox_CAJAS.SelectedIndexChanged



    End Sub

    Private Sub MetroComboBox_CAJAS_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles MetroComboBox_CAJAS.SelectionChangeCommitted
        Dim caja_cod(1) As String
        Try
            caja_cod = Split(MetroComboBox_CAJAS.SelectedValue.ToString, "|")

        Catch ex As Exception

        End Try



        ' total  ==============================================

        Me.Label_total_caja.Text = "0"
        Label5.Text = "0"
        Label7.Text = "0"

        Try

            sql = "Select sum(debe) as debe, sum(haber) as haber, SUM(DEBE)-SUM(HABER) As SALDO from CAJASPUC WHERE CODCUENTA='" & caja_cod(0) & "'"

            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                'If row.Item("SALDO") <> DBNull.Value.ToString Then Label_total_caja.Text = row.Item("SALDO") Else Label_total_caja.Text = "0"
                If Convert.ToString(row.Item("SALDO")) <> "" Then Label_total_caja.Text = row.Item("SALDO").ToString Else Label_total_caja.Text = "0"
                If Convert.ToString(row.Item("debe")) <> "" Then Label5.Text = row.Item("debe").ToString Else Label5.Text = "0"
                If Convert.ToString(row.Item("haber")) <> "" Then Label7.Text = row.Item("haber").ToString Else Label7.Text = "0"

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()


        Me.Label_total_caja.Text = Format(CDec(Me.Label_total_caja.Text), "##,##0")
        Me.Label5.Text = Format(CDec(Me.Label5.Text), "##,##0")
        Me.Label7.Text = Format(CDec(Me.Label7.Text), "##,##0")

        '==============================================



        Try
            If RadioButton3.Checked = True Then sql = "Select * FROM CAJASPUC WHERE CODCUENTA='" & caja_cod(0) & "'"

            da_MOVS_CAJAS_LIST = New MySqlDataAdapter(sql, conex)
            dT_MOVS_CAJAS_LIST = New DataTable
            da_MOVS_CAJAS_LIST.Fill(dT_MOVS_CAJAS_LIST)
            MetroGrid_movs_caja.DataSource = dT_MOVS_CAJAS_LIST
            MetroGrid_movs_caja.Columns(0).Visible = False
            MetroGrid_movs_caja.Columns(1).Visible = False
            MetroGrid_movs_caja.Columns(2).Visible = False
            MetroGrid_movs_caja.Columns(3).Visible = False

            MetroGrid_movs_caja.Columns(4).HeaderText = "Fecha"
            MetroGrid_movs_caja.Columns(4).Width = 80
            MetroGrid_movs_caja.Columns(5).HeaderText = "Consecutivo"
            MetroGrid_movs_caja.Columns(5).Width = 90

            MetroGrid_movs_caja.Columns(6).HeaderText = "Tipo de Documento"
            MetroGrid_movs_caja.Columns(6).Width = 370

            MetroGrid_movs_caja.Columns(7).Visible = False
            MetroGrid_movs_caja.Columns(8).Visible = False

            MetroGrid_movs_caja.Columns(9).HeaderText = "Débito"
            MetroGrid_movs_caja.Columns(9).Width = 100
            MetroGrid_movs_caja.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            MetroGrid_movs_caja.Columns(9).DefaultCellStyle.Format = "C"

            MetroGrid_movs_caja.Columns(10).HeaderText = "Crédito"
            MetroGrid_movs_caja.Columns(10).Width = 100
            MetroGrid_movs_caja.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            MetroGrid_movs_caja.Columns(10).DefaultCellStyle.Format = "C"

            MetroGrid_movs_caja.Columns(11).Visible = False
            MetroGrid_movs_caja.Columns(12).Visible = False
            MetroGrid_movs_caja.Columns(13).Visible = False
            MetroGrid_movs_caja.Columns(14).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_MOVS_CAJAS_LIST.Dispose()
        dT_MOVS_CAJAS_LIST.Dispose()
        conex.Close()
    End Sub

    Private Sub MetroComboBox_fechaCaja_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub






    Private Sub MetroComboBox_cajaMEs_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroComboBox_BANCOS_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    'Private Sub MetroComboBox_BANCOS_SelectionChangeCommitted(sender As Object, e As EventArgs)
    '    Dim banco_cod() As String = Split(MetroComboBox_BANCOS.SelectedValue.ToString, "|")
    '    ' total  ==============================================

    '    Me.Label_TOTAL_BANCOS.Text = "0"

    '    Try
    '        sql = "Select SUM(DEBE)-SUM(HABER) As SALDO from CAJASPUC WHERE CODCUENTA='" & banco_cod(0) & "'"
    '        da = New MySqlDataAdapter(sql, conex)
    '        dt = New DataTable
    '        da.Fill(dt)
    '        For Each row As DataRow In dt.Rows
    '            'If row.Item("SALDO") <> DBNull.Value.ToString Then Label_total_caja.Text = row.Item("SALDO") Else Label_total_caja.Text = "0"
    '            If Convert.ToString(row.Item("SALDO")) <> "" Then Label_TOTAL_BANCOS.Text = row.Item("SALDO").ToString Else Label_TOTAL_BANCOS.Text = "0"
    '        Next
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    '    conex.Close()
    '    da.Dispose()
    '    dt.Dispose()
    '    conex.Close()


    '    Me.Label_TOTAL_BANCOS.Text = Format(CDec(Me.Label_TOTAL_BANCOS.Text), "##,##0")
    '    '==============================================





    'End Sub





    Private Sub Button_nuevo_mov_Click(sender As Object, e As EventArgs) Handles Button_nuevo_mov.Click
        Panel13.Visible = True

        Me.TextBox_codMOV.Text = "0"
        TextBox_fecha_mov.Text = DateTime.Now.ToShortDateString
        Me.TextBox_valorMOV.Text = 0
        TextBox_NRO_DOCONTABLE.Text = ""
        TextBox_observ_mov.Text = ""

        Me.Panel_BTNS_MOVS.Visible = True
        Me.Panel8.Visible = True
        Me.MetroGrid_movimientos.Visible = True
        Panel9.Enabled = True

        TextBox_codMOV.Enabled = True
        TextBox_estadomov.Enabled = True

        Me.Button_guardar_mov.Visible = True
        Me.Button_CANCELAR_MOV.Visible = True


        MetroGrid_movimientos.Visible = False
        que_MOVIMIENTO_hace = "MOVIMIENTO"

        MetroComboBox_DOCCONTABLE.SelectedItem = Nothing

        'CONSECUTIVO
        consecutivo = 0
        cmd.Connection = conex
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select max(cons) + 1 from movimientoscuentas"
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


        TextBox_codMOV.Text = consecutivo
        Me.Label_empleado.Text = usrnom
        Me.Panel_BTNS_MOVS.Visible = False
        Me.Panel8.Visible = False

        'cargo cuentas para trasladar
        Try
            sql = "SELECT CONS, CUENTAPUC, NOMBRE, tipo FROM CAJAsYBANCOS where tipo='BANCO' OR tipo='CAJA'"
            da_comboorigenmov = New MySqlDataAdapter(sql, conex)
            dt_comboorigenmov = New DataTable
            da_comboorigenmov.Fill(dt_comboorigenmov)
            Me.ComboBox_ORIGEN.DataSource = dt_comboorigenmov.DefaultView
            Me.ComboBox_ORIGEN.DisplayMember = "NOMBRE"
            Me.ComboBox_ORIGEN.ValueMember = "CONS"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_comboorigenmov.Dispose()
        dt_comboorigenmov.Dispose()
        conex.Close()

        Try
            sql = "SELECT CONS, CUENTAPUC, NOMBRE, tipo FROM CAJAsYBANCOS where tipo='BANCO' OR tipo='CAJA'"
            da_combodestinomov = New MySqlDataAdapter(sql, conex)
            dt_combodestinomov = New DataTable
            da_combodestinomov.Fill(dt_combodestinomov)
            Me.ComboBox_DESTINO.DataSource = dt_combodestinomov.DefaultView
            Me.ComboBox_DESTINO.DisplayMember = "NOMBRE"
            Me.ComboBox_DESTINO.ValueMember = "CONS"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_combodestinomov.Dispose()
        dt_combodestinomov.Dispose()
        conex.Close()


        Me.ComboBox_DESTINO.SelectedItem = Nothing


        Me.ComboBox_ORIGEN.SelectedItem = Nothing





    End Sub

    Private Sub Button_guardar_mov_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub MetroGrid_mediospagos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub MetroComboBox_TIPOMOV_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub





    Private Sub MetroComboBox_cuentasparapagos_SelectedIndexChanged(sender As Object, e As EventArgs)



    End Sub



    Private Sub MetroComboBox_destino_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroTabPage3_Click(sender As Object, e As EventArgs) Handles MetroTabPage3.Click

    End Sub



    Private Sub TextBox_fecha_mov_TextChanged(sender As Object, e As EventArgs) Handles TextBox_fecha_mov.TextChanged

    End Sub

    Private Sub MetroComboBox_cuentasparapagos_SelectionChangeCommitted(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox_cod_TextChanged(sender As Object, e As EventArgs) Handles TextBox_codMOV.TextChanged

    End Sub











    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Button_CONSULTAR_MOV_Click(sender As Object, e As EventArgs) Handles Button_CONSULTAR_MOV.Click
        If cod_movimiento = "" Then
            MsgBox("Seleccione un Movimiento", vbInformation)
            Exit Sub
        End If

        Button_anular_mov.Visible = True
        Me.Panel_BTNS_MOVS.Visible = False
        Me.Panel8.Visible = False
        Me.MetroGrid_movimientos.Visible = False
        Panel9.Enabled = False

        TextBox_codMOV.Enabled = False
        TextBox_estadomov.Enabled = False

        Me.Button_guardar_mov.Visible = False
        Me.Button_CANCELAR_MOV.Visible = True : Me.Button_CANCELAR_MOV.Text = "Regresar"
        Button_Exportarmov.Visible = True

        Panel13.Visible = False

    End Sub

    Private Sub TextBox_valorMOV_TextChanged(sender As Object, e As EventArgs) Handles TextBox_valorMOV.TextChanged
        If Me.TextBox_valorMOV.Text = "" Then Me.TextBox_valorMOV.Text = "0"
        If TextBox_origen_Actual.Text = "" Then TextBox_origen_Actual.Text = "0"
        If TextBox_destino_actual.Text = "" Then TextBox_destino_actual.Text = "0"

        TextBox_nuevo_origen.Text = CInt(TextBox_origen_Actual.Text) - CInt(TextBox_valorMOV.Text)
        TextBox_nuevo_destino.Text = CInt(TextBox_destino_actual.Text) + CInt(TextBox_valorMOV.Text)

        Me.TextBox_nuevo_origen.Text = FormatNumber(Me.TextBox_nuevo_origen.Text, 0)
        Me.TextBox_nuevo_origen.Select(Me.TextBox_nuevo_origen.Text.Length, 0)

        Me.TextBox_nuevo_destino.Text = FormatNumber(Me.TextBox_nuevo_destino.Text, 0)
        Me.TextBox_nuevo_destino.Select(Me.TextBox_nuevo_destino.Text.Length, 0)

        Me.TextBox_valorMOV.Text = FormatNumber(Me.TextBox_valorMOV.Text, 0)
        Me.TextBox_valorMOV.Select(Me.TextBox_valorMOV.Text.Length, 0)
    End Sub

    Private Sub MetroTabPage5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroComboBox_NOMMEDIOPAGO_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox_mediopago_pagar_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox_mediopago_cobrar_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroGrid_movimientos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub




    Private Sub ComboBox_filtrotipomovcaja_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroComboBox_origen_SelectedValueChanged(sender As Object, e As EventArgs)

    End Sub



    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        'funcion para obtener el tamaño de la columnas del datagridview
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False

        LLENAR_COMBOS()
        LLENAGRID_CAJABANCOS()

        Me.MetroTabControl1.SelectTab(0)
        Me.MetroGrid_movimientos.BringToFront()

        Me.MetroComboBox_CAJAS.SelectedItem = Nothing

        DateTimePicker_MOVS_CAJA.Value = Today

        MetroComboBox6.SelectedIndex = DateTime.Now.Month - 1
        MetroComboBox1.SelectedIndex = DateTime.Now.Month - 1

        MetroComboBox_CAJAS.SelectedIndex = -1

        Me.Grid_cajas.ClearSelection()
        MetroGrid_movimientos.ClearSelection()
        MetroGrid_movs_caja.ClearSelection()

        Grid_cajas.ClearSelection()

    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs)

    End Sub





    Private Sub MetroComboBox_DOCCONTABLE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroComboBox_DOCCONTABLE.SelectedIndexChanged

    End Sub

    Private Sub TextBox_NRO_DOCONTABLE_TextChanged(sender As Object, e As EventArgs) Handles TextBox_NRO_DOCONTABLE.TextChanged

    End Sub

    Private Sub TextBox_fecha_mov_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_fecha_mov.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub RadioButton_BANCO_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_BANCO.CheckedChanged
        If RadioButton_BANCO.Checked = True Then
            Label16.Text = "Número de la Cuenta"
            Label15.Text = "Nombre de la Cuenta"
            TextBox_nro_cajabanco.Enabled = True
            TextBox_nro_cajabanco.Text = ""
        End If

    End Sub

    Private Sub RadioButton_CAJA_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_CAJA.CheckedChanged
        If RadioButton_CAJA.Checked = True Then
            Label16.Text = "Número de la Caja"
            Label15.Text = "Nombre de la Caja"
            TextBox_nro_cajabanco.Enabled = False
            TextBox_nro_cajabanco.Text = ""
        End If

    End Sub

    Private Sub Button_CANCELAR_MOV_Click(sender As Object, e As EventArgs) Handles Button_CANCELAR_MOV.Click
        Me.Button_CANCELAR_MOV.Text = "Cancelar Movimiento"
        Me.TextBox_codMOV.Text = "0"
        TextBox_fecha_mov.Text = DateTime.Now.ToShortDateString
        Me.TextBox_valorMOV.Text = 0
        TextBox_NRO_DOCONTABLE.Text = ""
        TextBox_observ_mov.Text = ""
        MetroGrid_movimientos.BringToFront()
        GRID_movimientos()
        MetroGrid_movimientos.Visible = True
        Me.Panel_BTNS_MOVS.Visible = True
        Me.Panel8.Visible = True
    End Sub

    Private Sub ComboBox_DOCtercero_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox_cod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_codMOV.KeyPress
        e.KeyChar = ""

    End Sub





    Private Sub TextBox_estadomov_TextChanged(sender As Object, e As EventArgs) Handles TextBox_estadomov.TextChanged

    End Sub



    Private Sub MetroComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles MetroComboBox_DOCCONTABLE.SelectionChangeCommitted


        'If MetroComboBox_DOCCONTABLE.Text = "FACTURA DE VENTA" Then DOC = "VENTA" : SQLTXT = "select max(cons) + 1 from VENTAS"
        'If MetroComboBox_DOCCONTABLE.Text = "FACTURA DE COMPRA" Then DOC = "COMPRA" : SQLTXT = "select max(cons) + 1 from COMPRAs"
        'If MetroComboBox_DOCCONTABLE.Text = "GASTO" Then DOC = "GASTO" : SQLTXT = "select max(cons) + 1 from GASTOS"
        'If MetroComboBox_DOCCONTABLE.Text = "COMPROBANTE CONTABLE" Then DOC = "COMPROBANTE CONTABLE" : SQLTXT = "select max(COMPROBANTE) + 1 from movimientosCUENTAS where tipo='COMPROBANTE CONTABLE'"


        ''consecutivo
        'consecutivo = 0
        'cmd.Connection = conex
        'cmd.CommandType = CommandType.Text
        'cmd.CommandText = SQLTXT
        'conex.Open()
        'Try
        '    dr_consecutivos = cmd.ExecuteReader()
        '    If dr_consecutivos.Read() Then
        '        consecutivo = dr_consecutivos(0)
        '    Else
        '        consecutivo = 1
        '    End If
        'Catch ex As Exception
        '    consecutivo = 1
        '    conex.Close()
        'End Try
        'conex.Close()



        'TextBox_NRO_DOCONTABLE.Text = consecutivo
    End Sub

    Private Sub TextBox_NRO_DOCONTABLE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_NRO_DOCONTABLE.KeyPress
        'e.KeyChar = ""

    End Sub

    Private Sub ComboBox_DOCtercero_SelectionChangeCommitted(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button_Exportarmov_Click(sender As Object, e As EventArgs) Handles Button_Exportarmov.Click



        Try
            'Intentar generar el documento.
            Dim doc As New Document(PageSize.A4, 10, 20, 10, 10)
            'Path que guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\comprobante de movimiento " & Me.TextBox_codMOV.Text & ".pdf"
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
        'Se crea un objeto PDFTable con el numero de columnas del DataGridView.



        Dim fontLINE = iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLD)



        'Se crea el encabezado en el PDF.
        Dim encabezadoLINE As New Paragraph("|=====================================================================================================================|", fontLINE)

        encabezadoLINE.Alignment = 0
        encabezadoLINE.Font = fontLINE

        Dim encabezadoLINE2 As New Paragraph("========================================================================================================================", fontLINE)
        Dim encabezadoLINE3 As New Paragraph("____________________________________________________________________________________________________________________________", fontLINE)

        encabezadoLINE2.Alignment = 0
        encabezadoLINE2.Font = fontLINE

        Dim encabezadoFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 10, iTextSharp.text.Font.BOLD)
        Dim contentFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 12, iTextSharp.text.Font.BOLD)
        Dim DIRFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 6, iTextSharp.text.Font.BOLD)
        Dim rowFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 6, iTextSharp.text.Font.BOLD)
        Dim DIRFont2 = iTextSharp.text.FontFactory.GetFont("Arial Black", 7.5, iTextSharp.text.Font.BOLD)

        Dim FIRMAFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 5, iTextSharp.text.Font.BOLD)
        Dim totalFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 8, iTextSharp.text.Font.BOLDITALIC)
        Dim totaltotalFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 9, iTextSharp.text.Font.BOLDITALIC)
        Dim CLIENTEFONT = iTextSharp.text.FontFactory.GetFont("Arial Black", 7, iTextSharp.text.Font.BOLDITALIC)

        'Se crea el encabezado en el PDF.
        Dim encabezado As New Paragraph(comex_nombrecomercial, encabezadoFont) : encabezado.Alignment = Element.ALIGN_LEFT
        encabezado.Font = encabezadoFont
        Dim PDF_CONSECUTIVO As New Paragraph(comex_razonsocial, New Font(Font.Name = "Arial Black", 9, Font.Bold = True)) : PDF_CONSECUTIVO.Alignment = Element.ALIGN_LEFT
        Dim encabezado2 As New Paragraph("NIT:" & comex_nit & "-" & comex_DV & " " & comex_regimen & Chr(13) & comex_dircomercio + " Tels:" & comex_tels & " " & comex_cels, New Font(Font.Name = "Arial Balck", 9, Font.Bold)) : encabezado2.Alignment = Element.ALIGN_LEFT

        Dim tablahome As New PdfPTable(2)
        tablahome.WidthPercentage = 100
        tablahome.DefaultCell.Padding = 0
        tablahome.DefaultCell.BorderWidth = 0
        tablahome.SpacingBefore = 0
        tablahome.HorizontalAlignment = 0

        Dim cellhome As New PdfPCell
        cellhome.BorderWidth = 0


        cellhome.Phrase = New Phrase("Beneficiario:", FontFactory.GetFont(FontFactory.COURIER, 13, iTextSharp.text.Font.BOLD))
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        cellhome.BackgroundColor = BaseColor.LIGHT_GRAY
        tablahome.AddCell(cellhome)
        cellhome.Phrase = New Phrase("TRASLADO DE CUENTAS", FontFactory.GetFont(FontFactory.COURIER, 11, iTextSharp.text.Font.BOLD))
        cellhome.HorizontalAlignment = Element.ALIGN_RIGHT
        cellhome.BackgroundColor = BaseColor.WHITE
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()


        cellhome.Phrase = New Phrase("Cliente: " + comex_nombrecomercial, FontFactory.GetFont(FontFactory.COURIER, 10, iTextSharp.text.Font.BOLD))
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        cellhome.BackgroundColor = BaseColor.LIGHT_GRAY
        tablahome.AddCell(cellhome)
        cellhome.Phrase = New Phrase("No. " & TextBox_codMOV.Text + "   ", FontFactory.GetFont(FontFactory.COURIER, 11, iTextSharp.text.Font.BOLD))
        cellhome.HorizontalAlignment = Element.ALIGN_RIGHT
        cellhome.BackgroundColor = BaseColor.WHITE
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase("DOC/NIT: " + comex_nit, FontFactory.GetFont(FontFactory.COURIER, 7, iTextSharp.text.Font.BOLD))
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        cellhome.BackgroundColor = BaseColor.LIGHT_GRAY
        tablahome.AddCell(cellhome)
        cellhome.Phrase = New Phrase("Fecha: " + TextBox_fecha_mov.Text + "   ", FontFactory.GetFont(FontFactory.COURIER, 10, iTextSharp.text.Font.BOLD))
        cellhome.HorizontalAlignment = Element.ALIGN_RIGHT
        cellhome.BackgroundColor = BaseColor.WHITE
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase("Dirección:  " + TextBox_fecha_mov.Text.ToString, FontFactory.GetFont(FontFactory.COURIER, 7, iTextSharp.text.Font.BOLD))
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        cellhome.BackgroundColor = BaseColor.LIGHT_GRAY
        tablahome.AddCell(cellhome)
        cellhome.Phrase = New Phrase(" ", FontFactory.GetFont(FontFactory.COURIER, 7, iTextSharp.text.Font.BOLD))
        cellhome.HorizontalAlignment = Element.ALIGN_RIGHT
        cellhome.BackgroundColor = BaseColor.WHITE
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase("Teléfono: " + "", FontFactory.GetFont(FontFactory.COURIER, 7, iTextSharp.text.Font.BOLD))
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        cellhome.BackgroundColor = BaseColor.LIGHT_GRAY
        tablahome.AddCell(cellhome)
        cellhome.Phrase = New Phrase("", FontFactory.GetFont(FontFactory.COURIER, 7, iTextSharp.text.Font.BOLD))
        cellhome.HorizontalAlignment = Element.ALIGN_RIGHT
        cellhome.BackgroundColor = BaseColor.WHITE
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()


        Dim datatable As New PdfPTable(2)
        'Se asignan algunas propiedades para el diseño del PDF.
        datatable.DefaultCell.Padding = 3

        Dim anchos() As Single = {300, 70}
        datatable.SetWidths(anchos)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER

        Dim cell_tabla As New PdfPCell
        cell_tabla.BorderWidth = 0

        cell_tabla.Phrase = New Phrase("Origen: " & ComboBox_ORIGEN.Text, FontFactory.GetFont(FontFactory.COURIER, 13, iTextSharp.text.Font.BOLD))
        cell_tabla.HorizontalAlignment = Element.ALIGN_LEFT
        cell_tabla.BackgroundColor = BaseColor.LIGHT_GRAY
        datatable.AddCell(cell_tabla)
        cell_tabla.Phrase = New Phrase(ComboBox_ORIGEN.SelectedValue, FontFactory.GetFont(FontFactory.COURIER, 9, iTextSharp.text.Font.BOLD))
        cell_tabla.HorizontalAlignment = Element.ALIGN_RIGHT
        cell_tabla.BackgroundColor = BaseColor.WHITE
        datatable.AddCell(cell_tabla)
        datatable.CompleteRow()

        cell_tabla.Phrase = New Phrase("Destino: " & ComboBox_ORIGEN.Text, FontFactory.GetFont(FontFactory.COURIER, 13, iTextSharp.text.Font.BOLD))
        cell_tabla.HorizontalAlignment = Element.ALIGN_LEFT
        cell_tabla.BackgroundColor = BaseColor.LIGHT_GRAY
        datatable.AddCell(cell_tabla)
        cell_tabla.Phrase = New Phrase(ComboBox_DESTINO.SelectedValue, FontFactory.GetFont(FontFactory.COURIER, 9, iTextSharp.text.Font.BOLD))
        cell_tabla.HorizontalAlignment = Element.ALIGN_RIGHT
        cell_tabla.BackgroundColor = BaseColor.WHITE
        datatable.AddCell(cell_tabla)
        datatable.CompleteRow()



        Dim tabla_PIE As New PdfPTable(6)
        tabla_PIE.WidthPercentage = 100
        tabla_PIE.DefaultCell.Padding = 0
        tabla_PIE.DefaultCell.BorderWidth = 0
        tabla_PIE.SpacingBefore = 3

        Dim cell_PIE As New PdfPCell
        cell_PIE.BorderWidth = 0

        cell_PIE.Phrase = New Phrase("Observaciones", New Font(Font.Name = "Arial Narrow", 8, Font.Bold))
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
        cell_PIE.Phrase = New Phrase("", totalFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase(" ", totalFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_RIGHT
        cell_PIE.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_PIE.AddCell(cell_PIE)
        tabla_PIE.CompleteRow()

        cell_PIE.Phrase = New Phrase(" ", New Font(Font.Name = "Arial Narrow", 8, Font.Bold))
        cell_PIE.HorizontalAlignment = Element.ALIGN_LEFT
        cell_PIE.BackgroundColor = BaseColor.WHITE
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
        cell_PIE.Phrase = New Phrase(" ", totalFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase(" ", totalFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_RIGHT
        cell_PIE.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_PIE.AddCell(cell_PIE)
        tabla_PIE.CompleteRow()


        cell_PIE.Phrase = New Phrase(" ", contentFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_LEFT
        cell_PIE.BackgroundColor = BaseColor.WHITE
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
        cell_PIE.Phrase = New Phrase(" ", totalFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase(" ", totalFont)
        cell_PIE.BackgroundColor = BaseColor.LIGHT_GRAY
        cell_PIE.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_PIE.AddCell(cell_PIE)
        tabla_PIE.CompleteRow()

        cell_PIE.Phrase = New Phrase("Elaborado:", New Font(Font.Name = "Arial Narrow", 7, Font.Bold))
        cell_PIE.HorizontalAlignment = Element.ALIGN_LEFT
        cell_PIE.BackgroundColor = BaseColor.WHITE
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase("", New Font(Font.Name = "Arial Narrow", 7, Font.Bold))
        cell_PIE.HorizontalAlignment = Element.ALIGN_LEFT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase("Recibido:", New Font(Font.Name = "Arial Narrow", 7, Font.Bold))
        cell_PIE.HorizontalAlignment = Element.ALIGN_LEFT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase("", New Font(Font.Name = "Arial Narrow", 7, Font.Bold))
        cell_PIE.HorizontalAlignment = Element.ALIGN_LEFT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase("Total", totalFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase(FormatNumber(TextBox_valorMOV.Text, 2), totaltotalFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_RIGHT
        cell_PIE.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_PIE.AddCell(cell_PIE)
        tabla_PIE.CompleteRow()

        cell_PIE.Phrase = New Phrase("Fecha de Impresión: " + Now.Date(), New Font(Font.Name = "Arial Narrow", 4, Font.Bold))
        cell_PIE.HorizontalAlignment = Element.ALIGN_LEFT
        cell_PIE.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase("Generado Por: ", New Font(Font.Name = "Arial Narrow", 4, Font.Bold))
        cell_PIE.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase(usrnom, New Font(Font.Name = "Arial Narrow", 4, Font.Bold))
        cell_PIE.HorizontalAlignment = Element.ALIGN_LEFT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase(" ", totalFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase(" ", totalFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase(" ", totalFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_PIE.AddCell(cell_PIE)
        tabla_PIE.CompleteRow()

        'LOGO
        If comex_logo <> "" And File.Exists(comex_logo) = True Then
            Dim imagelogogopdf As iTextSharp.text.Image 'Declaracion de una imagen

            imagelogogopdf = iTextSharp.text.Image.GetInstance(comex_logo) 'Dirreccion a la imagen que se hace referencia
            imagelogogopdf.Alignment = Element.ALIGN_RIGHT
            imagelogogopdf.SetAbsolutePosition(420, 750) 'Posicion en el eje cartesiano
            imagelogogopdf.ScaleAbsoluteWidth(160) 'Ancho de la imagen
            imagelogogopdf.ScaleAbsoluteHeight(60) 'Altura de la imagen
            document.Add(imagelogogopdf) ' Agrega la imagen al documento
        End If
        'Se agrega el PDFTable al documento.



        'Dim CUADRO_total As iTextSharp.text.Image 'Declaracion de una imagen
        'CUADRO_total = iTextSharp.text.Image.GetInstance("c:\miclickderecho\MARCO.png") 'Dirreccion a la imagen que se hace referencia
        'CUADRO_total.Alignment = Element.ALIGN_LEFT
        'CUADRO_total.SetAbsolutePosition(428, 458) 'Posicion en el eje cartesiano
        'CUADRO_total.ScaleAbsoluteWidth(150) 'Ancho de la imagen
        'CUADRO_total.ScaleAbsoluteHeight(50) 'Altura de la imagen


        Dim endline As iTextSharp.text.Image 'Declaracion de una imagen
        endline = iTextSharp.text.Image.GetInstance("c:\miclickderecho\endline.png") 'Dirreccion a la imagen que se hace referencia
        endline.Alignment = Element.ALIGN_CENTER
        endline.SetAbsolutePosition(18, 439) 'Posicion en el eje cartesiano
        endline.ScaleAbsoluteWidth(563.5F) 'Ancho de la imagen
        endline.ScaleAbsoluteHeight(9) 'Altura de la imagen

        document.Add(encabezadoLINE)
        document.Add(encabezado)
        document.Add(PDF_CONSECUTIVO)
        document.Add(encabezado2)
        document.Add(encabezadoLINE3)

        tablahome.SpacingBefore = 5
        document.Add(tablahome)
        datatable.SpacingBefore = 15
        document.Add(datatable)
        document.Add(encabezadoLINE3)
        tabla_PIE.SpacingBefore = 5
        document.Add(tabla_PIE)
        'document.Add(CUADRO_total)
        'document.Add(descuento)

    End Sub

    Private Sub Button_movS_Click(sender As Object, e As EventArgs) Handles Button_movS.Click

    End Sub

    Private Sub ComboBox_FECHA_MOV_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel_crear_Paint(sender As Object, e As PaintEventArgs) Handles Panel_crear.Paint

    End Sub

    Private Sub ComboBox_DOCtercero_SelectedValueChanged(sender As Object, e As EventArgs)
        Timer_TERCERO.Enabled = True

    End Sub

    Private Sub MetroTabPage2_Click(sender As Object, e As EventArgs) Handles MetroTabPage2.Click

    End Sub

    Private Sub MetroComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroComboBox6.SelectedIndexChanged

    End Sub


    Private Sub Panel10_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TextBox_estadomov_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_estadomov.KeyPress
        e.KeyChar = ""
        e.KeyChar = ""
    End Sub

    Private Sub Grid_bancos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub MetroComboBox_DOCCONTABLE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MetroComboBox_DOCCONTABLE.KeyPress
        e.KeyChar = ""

    End Sub



    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroComboBox_origen_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.KeyChar = ""

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel9_Paint(sender As Object, e As PaintEventArgs) Handles Panel9.Paint

    End Sub

    Private Sub MetroGrid_movimientos_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid_movimientos.CellContentClick

    End Sub

    Private Sub MetroComboBox_destino_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.KeyChar = ""

    End Sub

    Private Sub MetroComboBox_CARTERA_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Grid_cajasybancos_CellBorderStyleChanged(sender As Object, e As EventArgs) Handles Grid_cajas.CellBorderStyleChanged

    End Sub

    Private Sub MetroComboBox_TIPOMOV_SizeChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroComboBox_CREDITO_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub Panel_informacion_Paint(sender As Object, e As PaintEventArgs) Handles Panel_informacion_me.Paint

    End Sub



    Private Sub Timer_refresh_combo_puc_Tick(sender As Object, e As EventArgs) Handles Timer_refresh_combo_puc.Tick

        Timer_refresh_combo_puc.Enabled = False

        RadioButton_CAJA_CheckedChanged(Nothing, Nothing)

        RadioButton_BANCO_CheckedChanged(Nothing, Nothing)

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub Timer_tipomov_Tick(sender As Object, e As EventArgs) Handles Timer_tipomov.Tick

    End Sub

    Private Sub Button_guardar_mov_Click_1(sender As Object, e As EventArgs) Handles Button_guardar_mov.Click
        If Me.MetroComboBox_DOCCONTABLE.Text = "" Then MsgBox("Debe seleccionar el tipo de documento soporte.", vbInformation) : Exit Sub
        If Me.ComboBox_ORIGEN.Text = "" Then MsgBox("Debe seleccionar el Origen del documento.", vbInformation) : Exit Sub
        If Me.ComboBox_DESTINO.Text = "" Then MsgBox("Debe seleccionar el Destino del documento.", vbInformation) : Exit Sub
        If Me.ComboBox_ORIGEN.Text = ComboBox_DESTINO.Text Then
            MsgBox("Debe seleccionar cuentas distintas.", vbInformation) : Exit Sub
        End If

        'If Me.ComboBox_DOCtercero.Text.ToString = "" Then MsgBox("Debe seleccionar el documento DEL TERCERO.", vbInformation) : Exit Sub
        If Me.TextBox_observ_mov.Text = "" Then MsgBox("Escriba una observacion.", vbInformation) : Exit Sub
        If CInt(TextBox_valorMOV.Text) < 0 Then
            MsgBox("DEBE DIGITAR UN VALOR", vbInformation)
            Exit Sub
        End If


        TextBox_estadomov.Text = "NUEVO"



        rol = "SALEN"
        PROD_SALEN = CInt(TextBox_valorMOV.Text)
        PROD_ENTRAN = 0

        'REGISTRO EN PUC
        Dim TERCERO As String = CStr(comex_nit) & "|" & CStr(comex_nombrecomercial)

        sql = "INSERT INTO cajaspuc(Codcuenta, cuenta, TERCERO, Fecha, Documento, TipoDoc, Rol, SaldoAnt, debe, haber, Saldo, Estado, annoactual)" &
                               "VALUES ('" & ComboBox_ORIGEN.SelectedValue.ToString & "','" & ComboBox_ORIGEN.SelectedItem.ToString & "','" & CStr(TERCERO) & "','" & DateTime.Now.ToShortDateString & "','" & TextBox_codMOV.Text & "','TRASLADO DE FONDOS','" & rol & "'," & saldo & "," & PROD_ENTRAN & "," & PROD_SALEN & "," & PROD_SALDO & ",'DESCARGADO','" & comex_annoactual & "')"
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


        '================================================================================================
        PROD_SALEN = 0
        PROD_SALDO = 0
        PROD_SALDO = 0


        rol = "ENTRAN"

        PROD_ENTRAN = CInt(TextBox_valorMOV.Text)
        PROD_SALDO = saldo
        PROD_SALDO = CInt(PROD_SALDO) + CInt(PROD_ENTRAN)
        PROD_SALEN = 0

        'REGISTRO EN PUC
        sql = "INSERT INTO cajaspuc(Codcuenta, cuenta, TERCERO, Fecha, Documento, TipoDoc, Rol, debe, haber, Estado, annoactual)" &
                               "VALUES ('" & ComboBox_DESTINO.SelectedValue.ToString & "','" & ComboBox_DESTINO.SelectedItem.ToString & "','" & CStr(TERCERO) & "','" & DateTime.Now.ToShortDateString & "','" & TextBox_codMOV.Text & "','TRASLADO DE FONDOS','" & rol & "'," & PROD_ENTRAN & "," & PROD_SALEN & ",'DESCARGADO','" & comex_annoactual & "')"
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
        '================================================================================================


        sql = "INSERT INTO movimientoscuentas(TIPO, COMPROBANTE, TERCERO, FECHA, CODORIGEN, ORIGEN, CODDESTINO, DESTINO, OBSERVACIONES, EMPLEADO, VALOR, ESTADO)" &
                      "VALUES ('" & MetroComboBox_DOCCONTABLE.SelectedItem & "','" & TextBox_NRO_DOCONTABLE.Text & "','" & CStr(comex_nombrecomercial & "|" & comex_nit) & "','" & TextBox_fecha_mov.Text & "','" & ComboBox_ORIGEN.SelectedValue.ToString & "|" & ComboBox_ORIGEN.SelectedItem.ToString & "','" & ComboBox_ORIGEN.Text & "','" & ComboBox_DESTINO.SelectedValue.ToString & "" & ComboBox_DESTINO.SelectedItem.ToString & "','" & ComboBox_DESTINO.Text & "','" & TextBox_observ_mov.Text & "','" & Label_empleado.Text & "','" & CInt(TextBox_valorMOV.Text) & "','DESCARGADO')"

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





        Me.TextBox_codMOV.Text = "0"
        TextBox_fecha_mov.Text = DateTime.Now.ToShortDateString
        Me.TextBox_valorMOV.Text = 0
        TextBox_NRO_DOCONTABLE.Text = ""
        TextBox_observ_mov.Text = ""
        MetroGrid_movimientos.BringToFront()
        GRID_movimientos()
        MetroGrid_movimientos.Visible = True
        Me.Panel_BTNS_MOVS.Visible = True
        Me.Panel8.Visible = True
    End Sub

    Private Sub MetroComboBox_TIPOMOV_SelectedValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroGrid_movimientos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid_movimientos.CellClick
        Dim row As DataGridViewRow = MetroGrid_movimientos.CurrentRow
        cod_movimiento = CStr(row.Cells("cons").Value)
        TextBox_codMOV.Text = CStr(row.Cells("cons").Value)

        Me.TextBox_fecha_mov.Text = CStr(row.Cells("fecha").Value)
        Me.MetroComboBox_DOCCONTABLE.Text = CStr(row.Cells("tipo").Value)
        Me.TextBox_NRO_DOCONTABLE.Text = CStr(row.Cells("comprobante").Value)

        Dim tercero_info() As String = Split(CStr(row.Cells("TERCERO").Value), "|")

        Me.TextBox_observ_mov.Text = CStr(row.Cells("observaciones").Value)

        Me.ComboBox_ORIGEN.Text = CStr(row.Cells("origen").Value)
        Me.ComboBox_DESTINO.Text = CStr(row.Cells("destino").Value)

        Me.TextBox_valorMOV.Text = CStr(row.Cells("valor").Value)
        Me.TextBox_estadomov.Text = CStr(row.Cells("estado").Value)
    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox_origen_Actual.TextChanged

    End Sub





    Private Sub ComboBox_cuentapuc_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button_anular_mov_Click(sender As Object, e As EventArgs) Handles Button_anular_mov.Click
        If cod_movimiento = "" Then
            Exit Sub
        End If


        Dim RTA As String
        RTA = MsgBox("Está seguro que desea eliminar el producto?.", MsgBoxStyle.Question + MsgBoxStyle.YesNo)

        If RTA = 6 Then
            sql = "DELETE FROM movimientoscuentas WHERE CONS='" & cod_movimiento & "'"
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


            sql = "DELETE FROM cajaspuc WHERE documento='" & cod_movimiento & "'' and tipodoc='TRASLADO DE FONDOS'"
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

            Button_CANCELAR_MOV_Click(Nothing, Nothing)
        End If

    End Sub

    Private Sub Button_tab1_Click(sender As Object, e As EventArgs) Handles Button_tab1.Click
        Me.MetroTabPage4.Hide()
        Me.MetroTabPage3.Hide()

        'MetroTabPage2.Parent = Nothing

        Me.MetroTabPage2.Show()
        Me.MetroTabPage2.Parent = Me.MetroTabControl1
        MetroTabControl1.SelectTab(0)

        MetroGrid_movs_caja.ClearSelection()

        MetroGrid_movimientos.ClearSelection()
        cod_movimiento = ""

        Grid_cajas.ClearSelection()
        cod_cajabanco = ""
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.MetroTabPage4.Hide()
        Me.MetroTabPage2.Hide()

        'MetroTabPage2.Parent = Nothing

        Me.MetroTabPage3.Show()
        Me.MetroTabPage3.Parent = Me.MetroTabControl1
        MetroTabControl1.SelectTab(1)



        'cargo cuentas para trasladar
        Try
            sql = "SELECT CONS, CUENTAPUC, NOMBRE, tipo FROM CAJAsYBANCOS where tipo='BANCO' OR tipo='CAJA'"
            da_comboorigenmov = New MySqlDataAdapter(sql, conex)
            dt_comboorigenmov = New DataTable
            da_comboorigenmov.Fill(dt_comboorigenmov)
            Me.ComboBox_ORIGEN.DataSource = dt_comboorigenmov.DefaultView
            Me.ComboBox_ORIGEN.DisplayMember = "NOMBRE"
            Me.ComboBox_ORIGEN.ValueMember = "CONS"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_comboorigenmov.Dispose()
        dt_comboorigenmov.Dispose()
        conex.Close()

        Try
            sql = "SELECT CONS, CUENTAPUC, NOMBRE, tipo FROM CAJAsYBANCOS where tipo='BANCO' OR tipo='CAJA'"
            da_combodestinomov = New MySqlDataAdapter(sql, conex)
            dt_combodestinomov = New DataTable
            da_combodestinomov.Fill(dt_combodestinomov)
            Me.ComboBox_DESTINO.DataSource = dt_combodestinomov.DefaultView
            Me.ComboBox_DESTINO.DisplayMember = "NOMBRE"
            Me.ComboBox_DESTINO.ValueMember = "CONS"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_combodestinomov.Dispose()
        dt_combodestinomov.Dispose()
        conex.Close()


        Me.ComboBox_DESTINO.SelectedItem = Nothing


        Me.ComboBox_ORIGEN.SelectedItem = Nothing

        MetroGrid_movs_caja.ClearSelection()

        MetroGrid_movimientos.ClearSelection()
        cod_movimiento = ""

        Grid_cajas.ClearSelection()
        cod_cajabanco = ""

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.MetroTabPage3.Hide()
        Me.MetroTabPage2.Hide()

        'MetroTabPage2.Parent = Nothing

        Me.MetroTabPage4.Show()
        Me.MetroTabPage4.Parent = Me.MetroTabControl1
        MetroTabControl1.SelectTab(2)

        MetroGrid_movs_caja.ClearSelection()

        MetroGrid_movimientos.ClearSelection()
        cod_movimiento = ""

        Grid_cajas.ClearSelection()
        cod_cajabanco = ""
    End Sub



    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_origen_Actual.KeyPress
        e.KeyChar = ""

    End Sub

    Private Sub PictureBox_movs_caja_Click(sender As Object, e As EventArgs) Handles PictureBox_movs_caja.Click
        Dim caja_cod(1) As String
        Try
            caja_cod = Split(MetroComboBox_CAJAS.SelectedValue.ToString, "|")

        Catch ex As Exception

        End Try



        ' total  ==============================================

        Me.Label_total_caja.Text = "0"
        Label5.Text = "0"
        Label7.Text = "0"

        Try

            If RadioButton3.Checked = True Then sql = "Select sum(debe) as debe, sum(haber) as haber, SUM(DEBE)-SUM(HABER) As SALDO from CAJASPUC WHERE CODCUENTA='" & caja_cod(0) & "' and month(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & MetroComboBox1.SelectedIndex + 1 & "'"
            If RadioButton4.Checked = True Then sql = "Select sum(debe) as debe, sum(haber) as haber, SUM(DEBE)-SUM(HABER) As SALDO FROM CAJASPUC WHERE CODCUENTA='" & caja_cod(0) & "' and fecha='" & DateTimePicker_MOVS_CAJA.Value.ToShortDateString & "'"

            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                'If row.Item("SALDO") <> DBNull.Value.ToString Then Label_total_caja.Text = row.Item("SALDO") Else Label_total_caja.Text = "0"
                If Convert.ToString(row.Item("SALDO")) <> "" Then Label_total_caja.Text = row.Item("SALDO").ToString Else Label_total_caja.Text = "0"
                If Convert.ToString(row.Item("debe")) <> "" Then Label5.Text = row.Item("debe").ToString Else Label5.Text = "0"
                If Convert.ToString(row.Item("haber")) <> "" Then Label7.Text = row.Item("haber").ToString Else Label7.Text = "0"

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()


        Me.Label_total_caja.Text = Format(CDec(Me.Label_total_caja.Text), "##,##0")
        Me.Label5.Text = Format(CDec(Me.Label5.Text), "##,##0")
        Me.Label7.Text = Format(CDec(Me.Label7.Text), "##,##0")

        '==============================================



        Try
            If RadioButton3.Checked = True Then sql = "Select * FROM CAJASPUC WHERE CODCUENTA='" & caja_cod(0) & "' and month(STR_TO_DATE(fecha,'%d/%m/%Y'))='" & MetroComboBox1.SelectedIndex + 1 & "'"
            If RadioButton4.Checked = True Then sql = "Select * FROM CAJASPUC WHERE CODCUENTA='" & caja_cod(0) & "' and fecha='" & DateTimePicker_MOVS_CAJA.Value.ToShortDateString & "'"

            da_MOVS_CAJAS_LIST = New MySqlDataAdapter(sql, conex)
            dT_MOVS_CAJAS_LIST = New DataTable
            da_MOVS_CAJAS_LIST.Fill(dT_MOVS_CAJAS_LIST)
            MetroGrid_movs_caja.DataSource = dT_MOVS_CAJAS_LIST
            MetroGrid_movs_caja.Columns(0).Visible = False
            MetroGrid_movs_caja.Columns(1).Visible = False
            MetroGrid_movs_caja.Columns(2).Visible = False
            MetroGrid_movs_caja.Columns(3).Visible = False

            MetroGrid_movs_caja.Columns(4).HeaderText = "Fecha"
            MetroGrid_movs_caja.Columns(4).Width = 80
            MetroGrid_movs_caja.Columns(5).HeaderText = "Consecutivo"
            MetroGrid_movs_caja.Columns(5).Width = 90

            MetroGrid_movs_caja.Columns(6).HeaderText = "Tipo de Documento"
            MetroGrid_movs_caja.Columns(6).Width = 370

            MetroGrid_movs_caja.Columns(7).Visible = False
            MetroGrid_movs_caja.Columns(8).Visible = False

            MetroGrid_movs_caja.Columns(9).HeaderText = "Débito"
            MetroGrid_movs_caja.Columns(9).Width = 100
            MetroGrid_movs_caja.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            MetroGrid_movs_caja.Columns(9).DefaultCellStyle.Format = "C"

            MetroGrid_movs_caja.Columns(10).HeaderText = "Crédito"
            MetroGrid_movs_caja.Columns(10).Width = 100
            MetroGrid_movs_caja.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            MetroGrid_movs_caja.Columns(10).DefaultCellStyle.Format = "C"

            MetroGrid_movs_caja.Columns(11).Visible = False
            MetroGrid_movs_caja.Columns(12).Visible = False
            MetroGrid_movs_caja.Columns(13).Visible = False
            MetroGrid_movs_caja.Columns(14).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_MOVS_CAJAS_LIST.Dispose()
        dT_MOVS_CAJAS_LIST.Dispose()
        conex.Close()




    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            DateTimePicker_MOVS_CAJA.Visible = True
            MetroComboBox1.Visible = False
        Else
            DateTimePicker_MOVS_CAJA.Visible = False
            MetroComboBox1.Visible = True
        End If

    End Sub

    Private Sub MetroGrid_movs_caja_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid_movs_caja.CellContentClick

    End Sub

    Private Sub ComboBox_ORIGEN_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_ORIGEN.SelectedIndexChanged

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        mes_num = DateTime.ParseExact(Me.MetroComboBox6.Text, "MMMM", CultureInfo.CurrentCulture).Month
        mes_num_text = CStr(mes_num)
        If mes_num <= 9 Then mes_num_text = "0" & CStr(mes_num)

        GRID_movimientos()
    End Sub

    Private Sub ComboBox_DESTINO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_DESTINO.SelectedIndexChanged

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_destino_actual.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub TextBox_valorMOV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_valorMOV.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""

    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_nuevo_origen.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_nuevo_destino.KeyPress
        e.KeyChar = ""

    End Sub

    Private Sub ComboBox_ORIGEN_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_ORIGEN.SelectionChangeCommitted
        Me.TextBox_origen_Actual.Text = "0"

        Try
            sql = "Select SUM(DEBE)-SUM(HABER) As SALDO from CAJASPUC WHERE CODCUENTA='" & ComboBox_ORIGEN.SelectedValue & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                'If row.Item("SALDO") <> DBNull.Value.ToString Then Label_total_caja.Text = row.Item("SALDO") Else Label_total_caja.Text = "0"
                If Convert.ToString(row.Item("SALDO")) <> "" Then TextBox_origen_Actual.Text = row.Item("SALDO").ToString Else TextBox_origen_Actual.Text = "0"
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()


        Me.TextBox_origen_Actual.Text = Format(CDec(Me.TextBox_origen_Actual.Text), "##,##0")
    End Sub

    Private Sub ComboBox_DESTINO_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_DESTINO.SelectionChangeCommitted
        ' total  ==============================================

        Me.TextBox_destino_actual.Text = "0"

        Try
            sql = "Select SUM(DEBE)-SUM(HABER) As SALDO from CAJASPUC WHERE CODCUENTA='" & ComboBox_DESTINO.SelectedValue & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                'If row.Item("SALDO") <> DBNull.Value.ToString Then Label_total_caja.Text = row.Item("SALDO") Else Label_total_caja.Text = "0"
                If Convert.ToString(row.Item("SALDO")) <> "" Then TextBox_destino_actual.Text = row.Item("SALDO").ToString Else TextBox_destino_actual.Text = "0"
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()


        Me.TextBox_destino_actual.Text = Format(CDec(Me.TextBox_destino_actual.Text), "##,##0")
        '==============================================
    End Sub
End Class