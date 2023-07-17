Public Class Form_Informescontables
    Private Sub Timer_LOAD_informe_Tick(sender As Object, e As EventArgs) Handles Timer_LOAD_informe.Tick
        Timer_LOAD_informe.Enabled = False
        Me.MetroGrid_Activo.DataSource = Nothing
        If ComboBox_tipoinforme.Text = "Estado de Resultados" Then
            Try
                sql = "SELECT codcuenta, cuenta, sum(debe)-sum(haber) FROM cajaspuc WHERE LEFT(CODCUENTA,1)='4' OR LEFT(CODCUENTA,1)='5' OR LEFT(CODCUENTA,1)='6' GROUP BY CODCUENTA;"
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                da.Fill(dt)
                Me.MetroGrid_Activo.DataSource = dt
                MetroGrid_Activo.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Catch ex As Exception
                MsgBox(ex.Message)
                conex.Close()
                da.Dispose()
                dt.Dispose()
            End Try
            conex.Close()
            da.Dispose()
            dt.Dispose()
        End If


        If ComboBox_tipoinforme.Text = "Balance General" Then
            Try
                sql = "SELECT CODCUENTA, cuenta, sum(debe)-sum(haber) from cajaspuc WHERE left(CODCUENTA,1)='1' GROUP BY CODCUENTA order by CODCUENTA"
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                da.Fill(dt)
                Me.MetroGrid_Activo.DataSource = dt
                MetroGrid_Activo.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Catch ex As Exception
                MsgBox(ex.Message)
                conex.Close()
                da.Dispose()
                dt.Dispose()
            End Try
            conex.Close()
            da.Dispose()
            dt.Dispose()

            Try
                sql = "SELECT CODCUENTA, cuenta, sum(debe)-sum(haber) from cajaspuc WHERE left(CODCUENTA,1)='2' GROUP BY CODCUENTA order by CODCUENTA"
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                da.Fill(dt)
                Me.MetroGrid_pasivo.DataSource = dt
                MetroGrid_pasivo.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Catch ex As Exception
                MsgBox(ex.Message)
                conex.Close()
                da.Dispose()
                dt.Dispose()
            End Try
            conex.Close()
            da.Dispose()
            dt.Dispose()

            Try
                sql = "SELECT CODCUENTA, cuenta, sum(debe)-sum(haber) from cajaspuc WHERE left(CODCUENTA,1)='3' GROUP BY CODCUENTA order by CODCUENTA"
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                da.Fill(dt)
                Me.MetroGrid_patrimonio.DataSource = dt
                MetroGrid_patrimonio.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Catch ex As Exception
                MsgBox(ex.Message)
                conex.Close()
                da.Dispose()
                dt.Dispose()
            End Try
            conex.Close()
            da.Dispose()
            dt.Dispose()
        End If



        If ComboBox_tipoinforme.Text = "Saldo de Cuentas" Then
            Try
                sql = "SELECT codcuenta, cuenta, sum(debe)-sum(haber) FROM cajaspuc GROUP BY CODCUENTA;"
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                da.Fill(dt)
                Me.MetroGrid_Activo.DataSource = dt
                MetroGrid_Activo.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Catch ex As Exception
                MsgBox(ex.Message)
                conex.Close()
                da.Dispose()
                dt.Dispose()
            End Try
            conex.Close()
            da.Dispose()
            dt.Dispose()
        End If


        If ComboBox_tipoinforme.Text = "Detalle de Cuenta" Then
            Try
                sql = "SELECT distinct(codcuenta) as cod, concat(codcuenta,' |',cuenta) as cuenta FROM cajaspuc;"
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                da.Fill(dt)
                Me.MetroComboBox1.DataSource = dt.DefaultView
                Me.MetroComboBox1.DisplayMember = "cuenta"
                Me.MetroComboBox1.ValueMember = "cod"
                Me.MetroComboBox1.SelectedItem = Nothing

            Catch ex As Exception
                MsgBox(ex.Message)
                conex.Close()
                da.Dispose()
                dt.Dispose()
            End Try
            conex.Close()
            da.Dispose()
            dt.Dispose()
        End If



    End Sub

    Private Sub ComboBox_tipoinforme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_tipoinforme.SelectedIndexChanged

    End Sub

    Private Sub ComboBox_tipoinforme_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox_tipoinforme.SelectedValueChanged
        Timer_LOAD_informe.Enabled = True
    End Sub

    Private Sub Button_backup_nube_Click(sender As Object, e As EventArgs) Handles Button_backup_nube.Click
        VERIFICAR_CONEXION_REMOTA()
        If ESTADO_CONEXION_REMOTA = False Then
            MsgBox("debe estarconectado a internet. ", vbInformation)
            Exit Sub
        End If

        If ESTADO_CONEXION_REMOTA = True Then
            Dim rta2 = MsgBox("Confirma Actualizar los Informes en la Nube?. " & Chr(13) & Chr(13) & "Puede tomar algun tiempo si la conexión a internet es lenta.", MsgBoxStyle.Information + MsgBoxStyle.YesNo)

            If rta2 = 6 Then
                Cursor.Current = Cursors.WaitCursor
                '' se guarda
                'sql = "INSERT INTO informe(fecha, detalle, inventario, caja, bancos, ventas, cxc, compras, cxp, gastos, costodeventas, utilidad)
                '       VALUES ('" & DateTime.Now & "','" & CStr(mes_num_text_general & "|" & comex_annoactual) & "','" & Label_costo_inv.Text & "','" & Label_total_Caja.Text & "','" & Label_bancos.Text & "','" & Label_TOTALVENTAS.Text & "','" & Label_total_cxc.Text & "','" & Label_totalcompras.Text & "','" & Label_total_cxp.Text & "','" & Label_total_gastos.Text & "','" & Label_costoVentas.Text & "','" & Label_utilidad.Text & "')"

                'conex_cloud = New MySqlConnection("data source=" & comex_hst & "; user id=" & comex_usr & "; password='" & comex_psw & "';database=" & comex_db & "; port=3306")

                'da = New MySqlDataAdapter(sql, conex_cloud)
                'dt = New DataTable
                'Try
                '    da.Fill(dt)
                '    '  MsgBox("Se Guardó correctamente. ", vbInformation)
                'Catch ex As Exception
                '    MsgBox(ex.ToString)
                '    da.Dispose()
                '    dt.Dispose()
                '    conex.Close()
                '    Exit Sub
                'End Try
                'da.Dispose()
                'dt.Dispose()
                'conex.Close()

                Cursor.Current = Cursors.Default

            End If

        End If
    End Sub

    Private Sub Timer_combo1_Tick(sender As Object, e As EventArgs) Handles Timer_combo1.Tick
        Timer_combo1.Enabled = False

        Try
            sql = "SELECT * from cajaspuc where codcuenta='" & MetroComboBox1.SelectedValue & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.MetroGrid_Activo.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
            conex.Close()
            da.Dispose()
            dt.Dispose()
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()

    End Sub

    Private Sub MetroComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroComboBox1.SelectedIndexChanged

    End Sub

    Private Sub MetroComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles MetroComboBox1.SelectionChangeCommitted
        Timer_combo1.Enabled = True



    End Sub

    Private Sub Button_cerrar_Click(sender As Object, e As EventArgs) Handles Button_cerrar.Click
        Me.Close()

    End Sub

    Private Sub Button_maxxi_Click(sender As Object, e As EventArgs) Handles Button_maxxi.Click
        Me.WindowState = FormWindowState.Maximized
        MetroGrid_Activo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub Button_minni_Click(sender As Object, e As EventArgs) Handles Button_minni.Click
        Me.WindowState = FormWindowState.Normal
        MetroGrid_Activo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub
End Class