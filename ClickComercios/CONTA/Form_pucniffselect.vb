Public Class Form_pucniffselect
    Dim da_tree_puc_tmp As New MySqlDataAdapter
    Dim dt_tree_puc_tmp As New DataTable
    Private Sub Form_pucniffselect_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_pucniffselect_Shown(sender As Object, e As EventArgs) Handles Me.Shown
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
        End Try
        conex.Close()
        da_tree_puc_tmp.Dispose()
        dt_tree_puc_tmp.Dispose()

    End Sub

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

    Private Sub TreeView_niif_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView_niif.NodeMouseDoubleClick
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
End Class