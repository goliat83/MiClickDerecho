Public Class Form_pucniif
    Dim seleccionando As String = ""
    Dim QUE_HACE As String = ""

    Dim NIIF_cod_sel As String = ""
    Dim NIIF_cuenta_sel As String = ""


    Dim da_grid_niif As New MySqlDataAdapter
    Dim dt_grid_niif As New DataTable


    Dim da_tree_puc_tmp As New MySqlDataAdapter
    Dim dt_tree_puc_tmp As New DataTable




    Private Sub Form_pucniif_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetroGrid_NIIF.BringToFront()

    End Sub

    Private Sub Form_pucniif_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        TreeView_niif.Nodes.Add("1", "ACTIVO", 0, 0)
        TreeView_niif.Nodes.Add("2", "PASIVO", 1, 1)
        TreeView_niif.Nodes.Add("3", "PATRIMONIO", 2, 2)
        TreeView_niif.Nodes.Add("4", "INGRESOS", 3, 3)
        TreeView_niif.Nodes.Add("5", "GASTOS", 4, 4)
        TreeView_niif.Nodes.Add("6", "COSTOS DE VENTAS", 5, 5)
        TreeView_niif.Nodes.Add("7", "COSTOS DE PRODUCCION U OPERACION", 6, 6)




        Try
            sql = "SELECT * FROM cuentasniif where length(codigo)=2 and left(codigo,1)=1"
            da_tree_puc_tmp = New MySqlDataAdapter(sql, conex)
            dt_tree_puc_tmp = New DataTable
            da_tree_puc_tmp.Fill(dt_tree_puc_tmp)

            For Each row As DataRow In dt_tree_puc_tmp.Rows
                ' para llenar nodo seleccionado
                'TreeView1.SelectedNode.Nodes.Add(row.Item("codigo").ToString(), row.Item("cuenta").ToString(), 0, 0)

                ' para llenar nodo que yo quiera
                TreeView_niif.Nodes("1").Nodes.Add(row.Item("codigo").ToString(), row.Item("cuenta").ToString(), 0, 0)
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
            conex.Close()
            da_tree_puc_tmp.Dispose()
            dt_grid_niif.Dispose()
        End Try
        conex.Close()
        da_tree_puc_tmp.Dispose()
        dt_tree_puc_tmp.Dispose()


        Try
            sql = "SELECT * FROM cuentasniif where length(codigo)=2 and left(codigo,1)=2"
            da_tree_puc_tmp = New MySqlDataAdapter(sql, conex)
            dt_tree_puc_tmp = New DataTable
            da_tree_puc_tmp.Fill(dt_tree_puc_tmp)

            For Each row As DataRow In dt_tree_puc_tmp.Rows
                ' para llenar nodo seleccionado
                'TreeView1.SelectedNode.Nodes.Add(row.Item("codigo").ToString(), row.Item("cuenta").ToString(), 0, 0)

                ' para llenar nodo que yo quiera
                TreeView_niif.Nodes("2").Nodes.Add(row.Item("codigo").ToString(), row.Item("cuenta").ToString(), 1, 1)
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
            conex.Close()
            da_tree_puc_tmp.Dispose()
            dt_grid_niif.Dispose()
        End Try
        conex.Close()
        da_tree_puc_tmp.Dispose()
        dt_tree_puc_tmp.Dispose()

        Try
            sql = "SELECT * FROM cuentasniif where length(codigo)=2 and left(codigo,1)=3"
            da_tree_puc_tmp = New MySqlDataAdapter(sql, conex)
            dt_tree_puc_tmp = New DataTable
            da_tree_puc_tmp.Fill(dt_tree_puc_tmp)

            For Each row As DataRow In dt_tree_puc_tmp.Rows
                ' para llenar nodo seleccionado
                'TreeView1.SelectedNode.Nodes.Add(row.Item("codigo").ToString(), row.Item("cuenta").ToString(), 0, 0)

                ' para llenar nodo que yo quiera
                TreeView_niif.Nodes("3").Nodes.Add(row.Item("codigo").ToString(), row.Item("cuenta").ToString(), 2, 2)
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
            conex.Close()
            da_tree_puc_tmp.Dispose()
            dt_grid_niif.Dispose()
        End Try
        conex.Close()
        da_tree_puc_tmp.Dispose()
        dt_tree_puc_tmp.Dispose()


        Try
            sql = "SELECT * FROM cuentasniif where length(codigo)=2 and left(codigo,1)=4"
            da_tree_puc_tmp = New MySqlDataAdapter(sql, conex)
            dt_tree_puc_tmp = New DataTable
            da_tree_puc_tmp.Fill(dt_tree_puc_tmp)

            For Each row As DataRow In dt_tree_puc_tmp.Rows
                ' para llenar nodo seleccionado
                'TreeView1.SelectedNode.Nodes.Add(row.Item("codigo").ToString(), row.Item("cuenta").ToString(), 0, 0)

                ' para llenar nodo que yo quiera
                TreeView_niif.Nodes("4").Nodes.Add(row.Item("codigo").ToString(), row.Item("cuenta").ToString(), 3, 3)
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
            conex.Close()
            da_tree_puc_tmp.Dispose()
            dt_grid_niif.Dispose()
        End Try
        conex.Close()
        da_tree_puc_tmp.Dispose()
        dt_tree_puc_tmp.Dispose()




        Try
            sql = "SELECT * FROM cuentasniif where length(codigo)=2 and left(codigo,1)=5"
            da_tree_puc_tmp = New MySqlDataAdapter(sql, conex)
            dt_tree_puc_tmp = New DataTable
            da_tree_puc_tmp.Fill(dt_tree_puc_tmp)

            For Each row As DataRow In dt_tree_puc_tmp.Rows
                ' para llenar nodo seleccionado
                'TreeView1.SelectedNode.Nodes.Add(row.Item("codigo").ToString(), row.Item("cuenta").ToString(), 0, 0)

                ' para llenar nodo que yo quiera
                TreeView_niif.Nodes("5").Nodes.Add(row.Item("codigo").ToString(), row.Item("cuenta").ToString(), 4, 4)
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
            conex.Close()
            da_tree_puc_tmp.Dispose()
            dt_grid_niif.Dispose()
        End Try
        conex.Close()
        da_tree_puc_tmp.Dispose()
        dt_tree_puc_tmp.Dispose()


        Try
            sql = "SELECT * FROM cuentasniif where length(codigo)=2 and left(codigo,1)=6"
            da_tree_puc_tmp = New MySqlDataAdapter(sql, conex)
            dt_tree_puc_tmp = New DataTable
            da_tree_puc_tmp.Fill(dt_tree_puc_tmp)

            For Each row As DataRow In dt_tree_puc_tmp.Rows
                ' para llenar nodo seleccionado
                'TreeView1.SelectedNode.Nodes.Add(row.Item("codigo").ToString(), row.Item("cuenta").ToString(), 0, 0)

                ' para llenar nodo que yo quiera
                TreeView_niif.Nodes("6").Nodes.Add(row.Item("codigo").ToString(), row.Item("cuenta").ToString(), 5, 5)
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
            conex.Close()
            da_tree_puc_tmp.Dispose()
            dt_grid_niif.Dispose()
        End Try
        conex.Close()
        da_tree_puc_tmp.Dispose()
        dt_tree_puc_tmp.Dispose()

        Try
            sql = "SELECT * FROM cuentasniif where length(codigo)=2 and left(codigo,1)=7"
            da_tree_puc_tmp = New MySqlDataAdapter(sql, conex)
            dt_tree_puc_tmp = New DataTable
            da_tree_puc_tmp.Fill(dt_tree_puc_tmp)

            For Each row As DataRow In dt_tree_puc_tmp.Rows
                ' para llenar nodo seleccionado
                'TreeView1.SelectedNode.Nodes.Add(row.Item("codigo").ToString(), row.Item("cuenta").ToString(), 0, 0)

                ' para llenar nodo que yo quiera
                TreeView_niif.Nodes("7").Nodes.Add(row.Item("codigo").ToString(), row.Item("cuenta").ToString(), 6, 6)
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
            conex.Close()
            da_tree_puc_tmp.Dispose()
            dt_grid_niif.Dispose()
        End Try
        conex.Close()
        da_tree_puc_tmp.Dispose()
        dt_tree_puc_tmp.Dispose()
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView_niif.AfterSelect
        Dim node As TreeNode = TreeView_niif.SelectedNode
        If (Not (node Is Nothing)) Then
            Dim key As String = node.Name
            Dim text As String = node.Text
            Dim fullPath As String = node.FullPath

            Label5.Text = key

            MetroGrid_NIIF.DataSource = Nothing

            If key.ToString.Count >= 2 Then
                seleccionando = "si"
                Try
                    sql = "SELECT * from CUENTASNIIF WHERE length(codigo)=" & key.ToString.Count + 2 & " and lEFT(CODIGO," & key.ToString.Count & ")=" & key & " order by codigo"
                    da_grid_niif = New MySqlDataAdapter(sql, conex)
                    dt_grid_niif = New DataTable
                    da_grid_niif.Fill(dt_grid_niif)
                    Me.MetroGrid_NIIF.DataSource = dt_grid_niif
                    Me.MetroGrid_NIIF.Columns(0).Visible = False
                    Me.MetroGrid_NIIF.Columns(1).HeaderText = "Código"
                    Me.MetroGrid_NIIF.Columns(1).Width = 80
                    Me.MetroGrid_NIIF.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    Me.MetroGrid_NIIF.Columns(2).HeaderText = "Cuenta"
                    Me.MetroGrid_NIIF.Columns(2).Width = 350
                    Me.MetroGrid_NIIF.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    Me.MetroGrid_NIIF.Columns(2).DefaultCellStyle.WrapMode = DataGridViewTriState.True

                    Me.MetroGrid_NIIF.Columns(3).Visible = False

                Catch ex As Exception
                    MsgBox("no se ha instalado el plaan de cuentas niif, contacte con soporte.")
                    conex.Close()
                    da_grid_niif.Dispose()
                    dt_grid_niif.Dispose()
                End Try
                conex.Close()
                da_grid_niif.Dispose()
                dt_grid_niif.Dispose()

                MetroGrid_NIIF.ClearSelection()
                seleccionando = ""
                NIIF_cod_sel = ""
                NIIF_cuenta_sel = ""
            End If

        End If

    End Sub

    Private Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView_niif.NodeMouseClick
        'Dim node As TreeNode = TreeView1.SelectedNode

        'If (Not (node Is Nothing)) Then
        '    Dim key As String = node.Name
        '    Dim text As String = node.Text
        '    Dim fullPath As String = node.FullPath

        '    Try
        '        sql = "SELECT * from CUENTASNIIF WHERE LEFT(CODIGO,1)=" & key & " order by codigo"
        '        da_grid_niif = New MySqlDataAdapter(sql, conex)
        '        dt_grid_niif = New DataTable
        '        da_grid_niif.Fill(dt_grid_niif)
        '        Me.MetroGrid_NIIF.DataSource = dt_grid_niif
        '        Me.MetroGrid_NIIF.Columns(0).Visible = False
        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '        conex.Close()
        '        da_grid_niif.Dispose()
        '        dt_grid_niif.Dispose()
        '    End Try
        '    conex.Close()
        '    da_grid_niif.Dispose()
        '    dt_grid_niif.Dispose()

        '    MetroGrid_NIIF.ClearSelection()

        'Dim msg As String = String.Format(
        '    "Key: {0}{1}Text: {2}{3}FullPath: {4}",
        '    key, Environment.NewLine,
        '    text, Environment.NewLine,
        '    fullPath)

        'MessageBox.Show(msg)


        'End If



    End Sub

    Private Sub load_grid_cuentas_puc()

    End Sub



    Private Sub TreeView1_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView_niif.NodeMouseDoubleClick
        Dim node As TreeNode = TreeView_niif.SelectedNode
        If (Not (node Is Nothing)) Then
            Dim key As String = node.Name
            Dim text As String = node.Text
            Dim fullPath As String = node.FullPath



            If key.ToString.Count >= 2 Then
                Try
                    TreeView_niif.SelectedNode.Nodes.Clear()
                    sql = "SELECT * FROM cuentasniif where length(codigo)=" & key.ToString.Count + 2 & " and left(codigo," & key.ToString.Count & ")=" & key & ""
                    da_tree_puc_tmp = New MySqlDataAdapter(sql, conex)
                    dt_tree_puc_tmp = New DataTable
                    da_tree_puc_tmp.Fill(dt_tree_puc_tmp)

                    For Each row As DataRow In dt_tree_puc_tmp.Rows
                        ' para llenar nodo seleccionado
                        Dim IMAGEINDEX As Integer = Strings.Left(row.Item("codigo").ToString, 1)
                        TreeView_niif.SelectedNode.Nodes.Add(row.Item("codigo").ToString(), row.Item("cuenta").ToString(), IMAGEINDEX - 1, IMAGEINDEX - 1)

                        ' para llenar nodo que yo quiera
                        'TreeView1.Nodes(key).Nodes.Add(row.Item("codigo").ToString(), row.Item("cuenta").ToString(), 0, 0)
                    Next

                Catch ex As Exception
                    MsgBox(ex.Message)
                    conex.Close()
                    da_tree_puc_tmp.Dispose()
                    dt_tree_puc_tmp.Dispose()
                End Try
                conex.Close()
                da_tree_puc_tmp.Dispose()
                dt_tree_puc_tmp.Dispose()

            End If




        End If



    End Sub

    Private Sub MetroGrid_NIIF_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid_NIIF.CellContentClick

    End Sub

    Private Sub MetroGrid_NIIF_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid_NIIF.CellClick
        Dim row_niff As DataGridViewRow = MetroGrid_NIIF.CurrentRow

        NIIF_cod_sel = CStr(row_niff.Cells("codigo").Value)
        NIIF_cuenta_sel = CStr(row_niff.Cells("cuenta").Value)

    End Sub

    Private Sub MetroGrid_NIIF_SelectionChanged(sender As Object, e As EventArgs) Handles MetroGrid_NIIF.SelectionChanged
        If seleccionando <> "" Then
            Exit Sub
        End If


        Dim row_niff As DataGridViewRow = MetroGrid_NIIF.CurrentRow
        If Not IsDBNull(MetroGrid_NIIF.Item("cons", 0).Value) Then
            NIIF_cod_sel = CStr(row_niff.Cells("codigo").Value)
            NIIF_cuenta_sel = CStr(row_niff.Cells("cuenta").Value)
        End If


    End Sub

    Private Sub Button_crear_niif_Click(sender As Object, e As EventArgs) Handles Button_crear_niif.Click
        'CREAR

        Panel_opciones.Visible = False
        Panel_guardar.Visible = True
        MetroGrid_NIIF.Visible = False
        TreeView_niif.Enabled = False
        Button_eliminar_ok_niif.Visible = False

        Label4.Text = "Crear Subcuenta de la Cuenta:"

        QUE_HACE = "GUARDAR"

        TextBox_codigo.MaxLength = 2

    End Sub

    Private Sub Button_consultar_niif_Click(sender As Object, e As EventArgs) Handles Button_consultar_niif.Click
        ' CONSULTAR 

        If NIIF_cod_sel = "" Then
            MsgBox("Seleccione una Cuenta.")

            Exit Sub
        End If

        TextBox_codigo.Enabled = False
        TextBox_codigo.Text = NIIF_cod_sel
        TextBox_cuenta.Text = NIIF_cuenta_sel

        QUE_HACE = "MODIFICAR"


        Button_eliminar_ok_niif.Visible = True

        Panel_opciones.Visible = False
        Panel_guardar.Visible = True
        MetroGrid_NIIF.Visible = False
        TreeView_niif.Enabled = False



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button_guardar_niif.Click
        'GUARDAR / MODIFICAR

        If TextBox_codigo.Text = "" Then
            MsgBox("Debe escirbir el código de la cuenta.")
            Exit Sub
        End If

        If TextBox_cuenta.Text = "" Then
            MsgBox("Debe escirbir el nombre de la cuenta.")
            Exit Sub
        End If


        If QUE_HACE = "MODIFICAR" Then



            Dim RTA As String
            RTA = MsgBox("Confirma Modificar la información de la cuenta.", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
            If RTA = 6 Then
                Try
                    sql = "update cuentasNIIF set 
CODIGO='" & TextBox_codigo.Text & "', 
CUENTA='" & TextBox_cuenta.Text & "' 
WHERE 
CODIGO=" & CInt(NIIF_cod_sel) & ""
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
                TextBox_codigo.Text = ""
                TextBox_cuenta.Text = ""
            End If
        End If


        If QUE_HACE = "GUARDAR" Then
            Dim RTA As String
            RTA = MsgBox("Desea crear la Subcuenta?." & Chr(13) & TextBox_codigo.Text & " " & TextBox_cuenta.Text, MsgBoxStyle.Question + MsgBoxStyle.YesNo)
            If RTA = 6 Then
                Try
                    sql = "INSERT INTO cuentasNIIF(CODIGO,CUENTA) 
VALUES('" & CStr(Label5.Text & TextBox_codigo.Text) & "','" & TextBox_cuenta.Text & "')"
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

        End If



        QUE_HACE = ""

        NIIF_cod_sel = ""
        NIIF_cuenta_sel = ""
        TextBox_codigo.Enabled = True

        TextBox_codigo.Text = ""
        TextBox_cuenta.Text = ""

        Panel_opciones.Visible = True
        Panel_guardar.Visible = False
        MetroGrid_NIIF.Visible = True
        TreeView_niif.Enabled = True
        Button_eliminar_ok_niif.Visible = True

        TreeView1_AfterSelect(Nothing, Nothing)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_regresar_niif.Click
        'REGRESAR


        QUE_HACE = ""

        NIIF_cod_sel = ""
        NIIF_cuenta_sel = ""


        TextBox_codigo.Enabled = True
        TextBox_codigo.Text = ""
        TextBox_cuenta.Text = ""


        Panel_opciones.Visible = True
        Panel_guardar.Visible = False
        MetroGrid_NIIF.Visible = True
        TreeView_niif.Enabled = True
        Button_eliminar_ok_niif.Visible = True

        Label4.Text = "Subcuentas de:"


        MetroGrid_NIIF.ClearSelection()

    End Sub

    Private Sub Button_eliminar_ok_niif_Click(sender As Object, e As EventArgs) Handles Button_eliminar_ok_niif.Click
        'ELIMINAR  OK


        Dim RTA As String
        RTA = MsgBox("Desea eliminar la cuenta Seleccionada.", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If RTA = 6 Then
            Try
                sql = "delete from cuentasniif WHERE CODIGO=" & CInt(NIIF_cod_sel) & ""
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

        NIIF_cod_sel = ""
        NIIF_cuenta_sel = ""

        TextBox_codigo.Text = ""
        TextBox_cuenta.Text = ""
        Panel_opciones.Visible = True
        Panel_guardar.Visible = False
        MetroGrid_NIIF.Visible = True
        TreeView_niif.Enabled = True
        Button_eliminar_ok_niif.Visible = False

    End Sub

    Private Sub Button_eliminar_niif_Click(sender As Object, e As EventArgs) Handles Button_eliminar_niif.Click
        'ELIMINAR

        If NIIF_cod_sel = "" Then
            Exit Sub
        End If


        Button_eliminar_ok_niif.Visible = True

        TextBox_codigo.Text = NIIF_cod_sel
        TextBox_cuenta.Text = NIIF_cuenta_sel

        Panel_opciones.Visible = False
        Panel_guardar.Visible = True
        MetroGrid_NIIF.Visible = False
        TreeView_niif.Enabled = False

        Button_regresar_niif.Visible = False
        Button_guardar_niif.Visible = False

    End Sub

    Private Sub TextBox_codigo_TextChanged(sender As Object, e As EventArgs) Handles TextBox_codigo.TextChanged

    End Sub

    Private Sub TextBox_codigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_codigo.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""

    End Sub

    Private Sub TreeView_niif_DoubleClick(sender As Object, e As EventArgs) Handles TreeView_niif.DoubleClick

    End Sub
End Class