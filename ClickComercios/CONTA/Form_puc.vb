Public Class Form_puc

    Dim agregando = ""

    Dim COD_PUC As String = ""
    Dim COD_asiento As String = ""
    Dim COD_DOC_asiento As String = ""

    Dim COD_cuenta_sel As String = ""

    Dim QUE_HACE As String = ""
    Dim QUE_HACE_asiento As String = ""
    Dim naturaleza As String = ""
    Dim PROD_SALDO, PROD_DEBE, PROD_HABER As Integer

    Dim entran, salen, saldo As Integer

    Dim DOC_TERCERO, NOM_TERCERO As String

    Dim da_combo_niif As New MySqlDataAdapter
    Dim dt_combo_niif As New DataTable
    Dim estado_cuenta As String = ""

    Private Sub Form_puc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub




    Private Sub load_grid_cuentas_puc_FILTRO(ByRef FILTRO As String)
        Try
            If IsNumeric(Textbox_buscar_cta.Text) = True Then FILTRO = "codigo"
            If IsNumeric(Textbox_buscar_cta.Text) = False Then FILTRO = "nombre"


            If FILTRO = "nombre" Then sql = "SELECT * from cuentaspuc WHERE CUENTA like '%" & Textbox_buscar_cta.Text & "%' order by codigo"
            If FILTRO = "codigo" Then sql = "SELECT * from cuentaspuc WHERE left(CODIGO," & Textbox_buscar_cta.Text.Count & ")='" & Textbox_buscar_cta.Text & "' order by codigo"

            da_puc = New MySqlDataAdapter(sql, conex)
            dt_puc = New DataTable
            da_puc.Fill(dt_puc)
            Me.MetroGrid_puc.DataSource = dt_puc

            Me.MetroGrid_puc.Columns(0).Visible = False
            Me.MetroGrid_puc.Columns(1).Width = 130
            Me.MetroGrid_puc.Columns(2).Width = 400
            Me.MetroGrid_puc.Columns(3).Visible = False
            Me.MetroGrid_puc.Columns(4).Visible = False
            Me.MetroGrid_puc.Columns(5).Visible = False
            Me.MetroGrid_puc.Columns(6).Visible = False
            Me.MetroGrid_puc.Columns(7).Visible = False
            Me.MetroGrid_puc.Columns(8).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
            conex.Close()
            da_puc.Dispose()
            dt_puc.Dispose()
        End Try
        conex.Close()
        da_puc.Dispose()
        dt_puc.Dispose()


        MetroGrid_puc.ClearSelection()
    End Sub




    Private Sub Button_crear_cuentaPUC_Click(sender As Object, e As EventArgs) Handles Button_crear_cuentaPUC.Click



        Panel_filtro.Visible = False
        Me.Panel_grid_puc.Visible = False
        Me.Panel_botones_puc.Visible = False
        ComboBox_naturaleza.SelectedItem = Nothing
        TextBox_cuentapuc.Text = ""
        TextBox_NOMBRECUENTA.Text = ""
        TextBox_NOMBRECUENTA.Enabled = True
        QUE_HACE = "CREAR"
        TextBox_cuentapuc.Focus()

    End Sub

    Private Sub Button_consultarcuenta_Click(sender As Object, e As EventArgs) Handles Button_consultarcuenta.Click

        If COD_cuenta_sel = "" Then
            MsgBox("seleccione una cuenta")
            Exit Sub
        End If


        Panel_filtro.Visible = False

        Me.Panel_grid_puc.Visible = False
        Me.Panel_botones_puc.Visible = False


        QUE_HACE = "CONSULTAR"

        TextBox_cuentapuc.Focus()

    End Sub



    Private Sub Combobox_cuentas_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub MetroGrid_puc_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid_puc.CellContentClick

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        Dim Naturaleza_cta As String = ""
        If ComboBox_naturaleza.Text = "DEBITO" Then Naturaleza_cta = "DB"
        If ComboBox_naturaleza.Text = "CREDITO" Then Naturaleza_cta = "CR"


        If RadioButton_Activa.Checked = False Or RadioButton_Inactiva.Checked = False Then
            MsgBox("Seleccione el estado de la cuenta.")
            Exit Sub
        End If


        'ESTADO DE LA CUENTA
        If RadioButton_Activa.Checked = True Then
            estado_cuenta = "ACTIVA"
        End If
        If RadioButton_Inactiva.Checked = True Then
            estado_cuenta = "INACTIVA"
        End If


        If QUE_HACE = "CONSULTAR" Then

            Try
                sql = "update cuentaspuc set 
CODIGO='" & TextBox_cuentapuc.Text & "', 
NIF='" & ComboBox_niif.Text & "', 
NATURALEZA='" & ComboBox_naturaleza.Text & "', 
estado='" & estado_cuenta & "', 
CUENTA='" & TextBox_NOMBRECUENTA.Text & "', 
DESCRIPCION='" & TextBox_descripcion.Text & "' 
WHERE 
CODIGO=" & TextBox_cuentapuc.Text & ""
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

        End If


        If QUE_HACE = "CREAR" Then

            If TextBox_cuentapuc.Text = "" Then Exit Sub
            If TextBox_NOMBRECUENTA.Text = "" Then Exit Sub
            If ComboBox_naturaleza.Text = "" Then Exit Sub



            Dim CUENTANUEVA As String = ""
            If TextBox_cuentapuc.Text <> "" Then CUENTANUEVA = TextBox_cuentapuc.Text

                Try
                    sql = "insert into cuentaspuc(codigo, Cuenta, Naturaleza, Estado, descripcion, nif) 
values('" & CUENTANUEVA & "','" & TextBox_NOMBRECUENTA.Text & "','" & ComboBox_naturaleza.Text & "','" & estado_cuenta & "','" & TextBox_descripcion.Text & "','" & ComboBox_niif.Text & "')"
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
            End If



            QUE_HACE = ""


        Me.Panel_grid_puc.Visible = True
        Me.Panel_botones_puc.Visible = True
        Panel_filtro.Visible = True
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Panel_grid_puc.Visible = True
        Me.Panel_botones_puc.Visible = True
        QUE_HACE = ""
        Panel_filtro.Visible = True
    End Sub


    Private Sub Button_filtro_cuentas_puc_Click(sender As Object, e As EventArgs) Handles Button_filtro_cuentas_puc.Click

        agregando = "SI"




        load_grid_cuentas_puc_FILTRO("")
        agregando = ""


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If COD_cuenta_sel = "" Then
            MsgBox("seleccione una cuenta")
            Exit Sub
        End If

        'verifico si la cuenta esta asignada a una caja
        Try
            sql = "SELECT cons from cajasybancos where cuentapuc='" & TextBox_cuentapuc.Text & "|" & TextBox_NOMBRECUENTA.Text & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                MsgBox("no se puede eliminar,la cuenta está asiganda en Cajas y Bancos.")
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


        'verifico si la cuenta esta asignada a datadocs
        Try
            sql = "SELECT cons from datadocs where cuenta1='" & TextBox_cuentapuc.Text & "|" & TextBox_NOMBRECUENTA.Text & "' or cuenta2='" & TextBox_cuentapuc.Text & "|" & TextBox_NOMBRECUENTA.Text & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                MsgBox("no se puede eliminar, la cuenta está asiganda a un documento contable.")
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



        Try
            sql = "delete from cuentaspuc where codcuenta='" & TextBox_cuentapuc.Text & "'"
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
    End Sub







    Private Sub Combobox_cuentas_SelectionChangeCommitted(sender As Object, e As EventArgs)
        Timer_clasificar.Enabled = True

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub MetroGrid_puc_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid_puc.CellClick
        Dim row As DataGridViewRow = MetroGrid_puc.CurrentRow

        COD_cuenta_sel = CStr(row.Cells("codigo").Value)
        COD_PUC = COD_cuenta_sel

        TextBox_cuentapuc.Text = CStr(row.Cells("codigo").Value)
        TextBox_NOMBRECUENTA.Text = CStr(row.Cells("CUENTA").Value)

        estado_cuenta = CStr(row.Cells("estADO").Value)

        ComboBox_niif.Text = CStr(row.Cells("NIF").Value)

        MetroComboBox_clase.Text = CStr(row.Cells("CLASE").Value)

        If CStr(row.Cells("NATURALEZA").Value) = "DB" Then ComboBox_naturaleza.Text = "DEBITO"
        If CStr(row.Cells("NATURALEZA").Value) = "CR" Then ComboBox_naturaleza.Text = "CREDITO"

        ComboBox_tipo.Text = CStr(row.Cells("TIPO").Value)


        TextBox_descripcion.Text = CStr(row.Cells("descripcion").Value)

        If estado_cuenta = "ACTIVA" Then
            RadioButton_Activa.Checked = True
        End If

        If estado_cuenta = "INACTIVA" Then
            RadioButton_Inactiva.Checked = True
        End If

    End Sub

    Private Sub FiltrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FiltrarToolStripMenuItem.Click
        Try
            sql = "SELECT CONS, CONCAT(codigo,'|',cuenta) AS NOMBRE FROM cuentasniif"
            da_combo_niif = New MySqlDataAdapter(sql, conex)
            dt_combo_niif = New DataTable
            da_combo_niif.Fill(dt_combo_niif)
            Me.ComboBox_niif.DataSource = dt_combo_niif.DefaultView
            Me.ComboBox_niif.DisplayMember = "NOMBRE"
            Me.ComboBox_niif.ValueMember = "CONS"
            Me.ComboBox_niif.AutoCompleteSource = AutoCompleteSource.ListItems
            Me.ComboBox_niif.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_combo_niif.Dispose()
        dt_combo_niif.Dispose()
        conex.Close()
    End Sub

    Private Sub ConfigurarCuentasDeContabilidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigurarCuentasDeContabilidadToolStripMenuItem.Click
        Form_pucniif.Show()

    End Sub

    Private Sub CostosDeOperacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CostosDeOperacionToolStripMenuItem.Click

    End Sub

    Private Sub ComboBox_ESTADO_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton_Activa_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Activa.CheckedChanged

    End Sub

    Private Sub RadioButton_Inactiva_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Inactiva.CheckedChanged

    End Sub

    Private Sub CuentasDeActivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuentasDeActivoToolStripMenuItem.Click

    End Sub

    Private Sub BsucarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BsucarToolStripMenuItem.Click

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub Form_puc_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Form_cajabancos.Visible = True Then
            Form_cajabancos.Timer_refresh_combo_puc.Enabled = False


        End If
    End Sub

    Private Sub Form_puc_Shown(sender As Object, e As EventArgs) Handles Me.Shown




        Cursor.Current = Cursors.WaitCursor
        Panel_grid_puc.Width = 970
        'load_grid_cuentas_puc()
        'load_combo_cunetaspuc_DET_DOCS()
        Cursor.Current = Cursors.WaitCursor

    End Sub



    Private Sub MetroGrid_puc_KeyDown(sender As Object, e As KeyEventArgs) Handles MetroGrid_puc.KeyDown
        If e.KeyCode = Keys.Enter Then
            'agregando = "SI"
            'Button_consultarcuenta_Click(Nothing, Nothing)
        End If

    End Sub

    Private Sub Button3_MouseDown(sender As Object, e As MouseEventArgs) Handles Button3.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right = False Then
            Button3.ContextMenuStrip = ContextMenuStrip_LOAD_PUC
            Me.ContextMenuStrip_LOAD_PUC.Show(Button3, New Point(Button3.Width - Button3.Width, Button3.Height))
        End If
    End Sub
End Class