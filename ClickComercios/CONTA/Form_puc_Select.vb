Public Class Form_puc_Select

    Dim da_tree_puc_tmp As New MySqlDataAdapter
    Dim dt_tree_puc_tmp As New DataTable


    Private Sub TreeView_niif_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView_niif.AfterSelect
        Dim node As TreeNode = TreeView_niif.SelectedNode
        If (Not (node Is Nothing)) Then
            Dim key As String = node.Name
            Dim text As String = node.Text
            Dim fullPath As String = node.FullPath

            Label_codigo.Text = key
            Label_cuenta.Text = text

        End If
    End Sub

    Private Sub Form_puc_Select_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_puc_Select_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        TreeView_niif.Nodes.Add("1", "ACTIVO", 0, 0)
        TreeView_niif.Nodes.Add("2", "PASIVO", 1, 1)
        TreeView_niif.Nodes.Add("3", "PATRIMONIO", 2, 2)
        TreeView_niif.Nodes.Add("4", "INGRESOS", 3, 3)
        TreeView_niif.Nodes.Add("5", "GASTOS", 4, 4)
        TreeView_niif.Nodes.Add("6", "COSTOS DE VENTAS", 5, 5)
        TreeView_niif.Nodes.Add("7", "COSTOS DE PRODUCCION U OPERACION", 6, 6)


        Try
            sql = "SELECT * FROM cuentaspuc where length(codigo)=2 and left(codigo,1)=1"
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
        End Try
        conex.Close()
        da_tree_puc_tmp.Dispose()
        dt_tree_puc_tmp.Dispose()


        Try
            sql = "SELECT * FROM cuentaspuc where length(codigo)=2 and left(codigo,1)=2"
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
        End Try
        conex.Close()
        da_tree_puc_tmp.Dispose()
        dt_tree_puc_tmp.Dispose()

        Try
            sql = "SELECT * FROM cuentaspuc where length(codigo)=2 and left(codigo,1)=3"
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
        End Try
        conex.Close()
        da_tree_puc_tmp.Dispose()
        dt_tree_puc_tmp.Dispose()


        Try
            sql = "SELECT * FROM cuentaspuc where length(codigo)=2 and left(codigo,1)=4"
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
        End Try
        conex.Close()
        da_tree_puc_tmp.Dispose()
        dt_tree_puc_tmp.Dispose()




        Try
            sql = "SELECT * FROM cuentaspuc where length(codigo)=2 and left(codigo,1)=5"
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
        End Try
        conex.Close()
        da_tree_puc_tmp.Dispose()
        dt_tree_puc_tmp.Dispose()


        Try
            sql = "SELECT * FROM cuentaspuc where length(codigo)=2 and left(codigo,1)=6"
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
        End Try
        conex.Close()
        da_tree_puc_tmp.Dispose()
        dt_tree_puc_tmp.Dispose()

        Try
            sql = "SELECT * FROM cuentaspuc where length(codigo)=2 and left(codigo,1)=7"
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
        End Try
        conex.Close()
        da_tree_puc_tmp.Dispose()
        dt_tree_puc_tmp.Dispose()


    End Sub

    Private Sub TreeView_niif_DoubleClick(sender As Object, e As EventArgs) Handles TreeView_niif.DoubleClick

    End Sub

    Private Sub TreeView_niif_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView_niif.NodeMouseDoubleClick
        Dim node As TreeNode = TreeView_niif.SelectedNode
        If (Not (node Is Nothing)) Then
            Dim key As String = node.Name
            Dim text As String = node.Text
            Dim fullPath As String = node.FullPath



            If key.ToString.Count >= 2 Then
                Try
                    TreeView_niif.SelectedNode.Nodes.Clear()
                    sql = "SELECT * FROM cuentaspuc where length(codigo)=" & key.ToString.Count + 2 & " and left(codigo," & key.ToString.Count & ")=" & key & ""
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

    Private Sub Label_cuenta_Click(sender As Object, e As EventArgs) Handles Label_cuenta.Click

    End Sub

    Private Sub Button_regresar_niif_Click(sender As Object, e As EventArgs) Handles Button_regresar_niif.Click
        'mi
        If Form_contadocs.Visible = True Then
            If Form_contadocs.Button_select_cta_mi.Text = "Seleccionando..." Then
                If Label_codigo.Text <> "-" And Label_cuenta.Text <> "-" Then
                    Form_contadocs.Label_codcuenta_mi.Text = Label_codigo.Text
                    Form_contadocs.Label_cuenta_mi.Text = Label_cuenta.Text
                    Form_contadocs.Panel_config_mi.Enabled = True
                    Form_contadocs.Button_select_cta_mi.Text = "Seleccionar Cuenta"
                    Me.Close()
                End If
            End If
        End If

        'ce config
        If Form_contadocs.Visible = True Then
            If Form_contadocs.Button_select_cta_ce.Text = "Seleccionando..." Then
                If Label_codigo.Text <> "-" And Label_cuenta.Text <> "-" Then
                    Form_contadocs.Label_codcuenta_ce.Text = Label_codigo.Text
                    Form_contadocs.Label_cuenta_ce.Text = Label_cuenta.Text
                    Form_contadocs.Panel_config_CE.Enabled = True
                    Form_contadocs.Button_select_cta_ce.Text = "Seleccionar Cuenta"
                    Me.Close()
                End If
            End If
        End If

        'ce comprobante
        If Form_ce.Visible = True Then
            If Form_ce.Button_sel_cuenta_ce.Text = "Seleccionando..." Then
                If Label_codigo.Text <> "-" And Label_cuenta.Text <> "-" Then
                    Form_ce.ComboBox_tipo_egreso.DataSource = Nothing
                    Form_ce.ComboBox_tipo_egreso.Items.Add(Label_codigo.Text & "|" & Label_cuenta.Text)
                    Form_ce.ComboBox_tipo_egreso.SelectedItem = Label_codigo.Text & "|" & Label_cuenta.Text
                    'Form_ce.Label_codcuenta_ce.Text = Label_codigo.Text
                    'Form_ce.Label_cuenta_ce.Text = Label_cuenta.Text
                    Form_ce.Panel3.Enabled = True
                    Form_ce.Button_sel_cuenta_ce.Text = ""
                    Me.Close()
                End If
            End If
        End If


        'rc
        If Form_contadocs.Visible = True Then
            If Form_contadocs.Button_select_cta_rc.Text = "Seleccionando..." Then
                If Label_codigo.Text <> "-" And Label_cuenta.Text <> "-" Then
                    Form_contadocs.Label_codcuenta_rc.Text = Label_codigo.Text
                    Form_contadocs.Label_cuenta_rc.Text = Label_cuenta.Text
                    Form_contadocs.Panel_config_RC.Enabled = True
                    Form_contadocs.Button_select_cta_rc.Text = "Seleccionar Cuenta"
                    Me.Close()
                End If
            End If
        End If
        'rc comprobante
        If Form_rc.Visible = True Then
            If Form_rc.Button_sel_cuenta_rc.Text = "Seleccionando..." Then
                If Label_codigo.Text <> "-" And Label_cuenta.Text <> "-" Then
                    Form_rc.ComboBox_tipo_ingreso.DataSource = Nothing
                    Form_rc.ComboBox_tipo_ingreso.Items.Add(Label_codigo.Text & "|" & Label_cuenta.Text)
                    Form_rc.ComboBox_tipo_ingreso.SelectedItem = Label_codigo.Text & "|" & Label_cuenta.Text
                    'Form_ce.Label_codcuenta_ce.Text = Label_codigo.Text
                    'Form_ce.Label_cuenta_ce.Text = Label_cuenta.Text
                    Form_rc.Panel3.Enabled = True
                    Form_rc.Button_sel_cuenta_rc.Text = ""
                    Me.Close()
                End If
            End If
        End If






        'IMPUESTOS
        If Form_impuesto.Visible = True Then
            If Form_impuesto.Button_sel_cuenta_imp_CR.Text = "..." Then
                If Label_codigo.Text <> "-" And Label_cuenta.Text <> "-" Then
                    Form_impuesto.combobox_cta1.Text = Label_codigo.Text & "|" & Label_cuenta.Text
                    Form_impuesto.Panel_imp_datos.Enabled = True
                    Form_impuesto.Button_sel_cuenta_imp_CR.Text = ""
                    Me.Close()
                End If
            End If
            If Form_impuesto.Button_sel_cuenta_imp_DB.Text = "..." Then
                If Label_codigo.Text <> "-" And Label_cuenta.Text <> "-" Then
                    Form_impuesto.combobox_cta2.Text = Label_codigo.Text & "|" & Label_cuenta.Text
                    Form_impuesto.Panel_imp_datos.Enabled = True
                    Form_impuesto.Button_sel_cuenta_imp_DB.Text = ""
                    Me.Close()
                End If
            End If
        End If

        'impuestos
        If Form_impuesto.Visible = True Then
            If Form_impuesto.Button_sel_cuenta_imp_CR.Text = "..." Then
                If Label_codigo.Text <> "-" And Label_cuenta.Text <> "-" Then
                    Form_impuesto.combobox_cta1.Text = Label_codigo.Text & "|" & Label_cuenta.Text
                    Form_impuesto.Panel_imp_datos.Enabled = True
                    Form_impuesto.Button_sel_cuenta_imp_CR.Text = ""
                    Me.Close()
                End If
            End If
            If Form_impuesto.Button_sel_cuenta_imp_DB.Text = "..." Then
                If Label_codigo.Text <> "-" And Label_cuenta.Text <> "-" Then
                    Form_impuesto.combobox_cta2.Text = Label_codigo.Text & "|" & Label_cuenta.Text
                    Form_impuesto.Panel_imp_datos.Enabled = True
                    Form_impuesto.Button_sel_cuenta_imp_DB.Text = ""
                    Me.Close()
                End If
            End If
            If Form_impuesto.Button_sel_cuenta_imp_DB.Text = "..." Then
                If Label_codigo.Text <> "-" And Label_cuenta.Text <> "-" Then
                    Form_impuesto.combobox_cta2.Text = Label_codigo.Text & "|" & Label_cuenta.Text
                    Form_impuesto.Panel_imp_datos.Enabled = True
                    Form_impuesto.Button_sel_cuenta_imp_DB.Text = ""
                    Me.Close()
                End If
            End If
            If Form_impuesto.Button_sel_cuenta_imp_DB.Text = "..." Then
                If Label_codigo.Text <> "-" And Label_cuenta.Text <> "-" Then
                    Form_impuesto.combobox_cta2.Text = Label_codigo.Text & "|" & Label_cuenta.Text
                    Form_impuesto.Panel_imp_datos.Enabled = True
                    Form_impuesto.Button_sel_cuenta_imp_DB.Text = ""
                    Me.Close()
                End If
            End If
        End If


        If Form_categorias.Visible = True Then
            If Form_categorias.Button_cat_inv.Text = "Seleccionando..." Then
                ' si, si seleccionó algo
                If Label_codigo.Text <> "-" And Label_cuenta.Text <> "-" Then
                    Form_categorias.label_cuenta_cat_inv.Text = Label_codigo.Text & "|" & Label_cuenta.Text
                    Form_categorias.Button_cat_inv.Text = ""
                    Form_categorias.Enabled = True
                    Me.Close()
                End If
            End If
            If Form_categorias.Button_cat_ventas.Text = "Seleccionando..." Then
                ' si, si seleccionó algo
                If Label_codigo.Text <> "-" And Label_cuenta.Text <> "-" Then
                    Form_categorias.label_cuenta_cat_ing.Text = Label_codigo.Text & "|" & Label_cuenta.Text
                    Form_categorias.Button_cat_ventas.Text = ""
                    Form_categorias.Enabled = True
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub Form_puc_Select_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'categorias
        If Form_categorias.Visible = True Then
            If Form_categorias.Button_cat_inv.Text = "Seleccionando..." Then
                Form_categorias.Button_cat_inv.Text = ""
                Form_categorias.Enabled = True
            End If
            If Form_categorias.Button_cat_ventas.Text = "Seleccionando..." Then
                Form_categorias.Button_cat_ventas.Text = ""
                Form_categorias.Enabled = True
            End If
        End If
        'mi
        If Form_contadocs.Visible = True Then
            If Form_contadocs.Button_select_cta_mi.Text = "Seleccionando..." Then
                Form_contadocs.Panel_config_mi.Enabled = True
                Form_contadocs.Button_select_cta_mi.Text = "Seleccionar Cuenta"
            End If
        End If
        'ce config
        If Form_contadocs.Visible = True Then
            If Form_contadocs.Button_select_cta_ce.Text = "Seleccionando..." Then
                Form_contadocs.Panel_config_CE.Enabled = True
                Form_contadocs.Button_select_cta_ce.Text = "Seleccionar Cuenta"
            End If
        End If
        'ce comprobante
        If Form_ce.Visible = True Then
            If Form_ce.Button_sel_cuenta_ce.Text = "Seleccionando..." Then
                Form_ce.Panel3.Enabled = True
                Form_ce.Button_sel_cuenta_ce.Text = ""
            End If
        End If
        'rc
        If Form_contadocs.Visible = True Then
            If Form_contadocs.Button_select_cta_rc.Text = "Seleccionando..." Then
                Form_contadocs.Panel_config_RC.Enabled = True
                Form_contadocs.Button_select_cta_rc.Text = "Seleccionar Cuenta"
            End If
        End If
        'rc comprobante
        If Form_rc.Visible = True Then
            If Form_rc.Button_sel_cuenta_rc.Text = "Seleccionando..." Then
                Form_rc.Panel3.Enabled = True
                Form_rc.Button_sel_cuenta_rc.Text = ""
            End If
        End If


        'IMPUESTOS
        If Form_impuesto.Visible = True Then
            If Form_impuesto.Button_sel_cuenta_imp_CR.Text = "..." Then
                Form_impuesto.Panel_imp_datos.Enabled = True
                Form_impuesto.Button_sel_cuenta_imp_CR.Text = ""
            End If
            If Form_impuesto.Button_sel_cuenta_imp_DB.Text = "..." Then
                Form_impuesto.Panel_imp_datos.Enabled = True
                Form_impuesto.Button_sel_cuenta_imp_DB.Text = ""
            End If
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form_puc.Show()
        Form_puc.TopMost = True


    End Sub
End Class