Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Environment
Imports System.IO
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports iTextSharp.text.pdf.draw

Public Class Form_caja

    Dim efectivo_actual As String = "0"
    Dim total_Creditos As String = "0"

    Public da_dctos_venta As New MySqlDataAdapter
    Public dt_dctos_venta As New DataTable


    Dim TTALVENTAS, TTALVENTASCREDITO, TTALRECIBOSCAJA, TTALEGRESOS, TTALCOMPRAS, TTALCOMPRASCREDITO, TTALDEVOLVENTA As Long


    Dim totalingresos As Long
    Dim totalEGRESOS As Long
    Dim total_gastos As Long
    Dim total_impuestos_turno As String = ""
    Dim tipo_cierre As String = ""

    Dim SALDO_ACTUAL_CAJA As String = "0"

    Dim alto_pag As Integer = 0

    Public da_AGRUPACION As New MySqlDataAdapter
    Public dt_AGRUPACION As DataTable


    Private Sub Form_caja_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'EffectOut("Form_caja")
    End Sub

    Private Sub Form_caja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label_fecha.Text = DateTime.Now.ToShortDateString
        Me.Label_empleado.Text = USR_NOM

        tipo_cierre = "PARCIAL DE CAJA"

    End Sub

    Private Sub Form_turnos_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Cursor = Cursors.WaitCursor

        If turno_actual_global = "" Then

            Try
                sql = "Select CONCAT(CONS,'|',NOMBRE) AS CONS, nombre, cuentapuc FROM CAJAsYBANCOS where tipo In('CAJA')"
                da_COMBO_cuentas_paraabrir = New MySqlDataAdapter(sql, conex)
                dt_COMBO_cuentas_paraabrir = New DataTable
                da_COMBO_cuentas_paraabrir.Fill(dt_COMBO_cuentas_paraabrir)
                Me.ComboBox_cta_abre.DataSource = dt_COMBO_cuentas_paraabrir.DefaultView
                Me.ComboBox_cta_abre.DisplayMember = "nombre"
                Me.ComboBox_cta_abre.ValueMember = "cons"
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da_COMBO_cuentas_paraabrir.Dispose()
            dt_COMBO_cuentas_paraabrir.Dispose()
            conex.Close()

            ComboBox_cta_abre.SelectedItem = comex_cuenta_ventas
            'ComboBox_cta_abre_SelectionChangeCommitted(Nothing, Nothing)

            Me.Button_abrirTurno.Visible = True
            Me.Label_estado.Text = "TURNO CERRADO"
            Me.Label_estado.ForeColor = Color.Red
            Me.TextBox_base.Enabled = True
            Me.Label_empleado.Text = usrnom

            TextBox_base.Text = SALDO_ACTUAL_CAJA


            ComboBox_cta_abre.Visible = True
            ComboBox_cta_abre.Enabled = True

        Else
            ComboBox_cta_abre.Visible = True
            ComboBox_cta_abre.Enabled = False

            Try
                sql = "SELECT CONCAT(CONS,'|',NOMBRE) AS CONS, CUENTAPUC, nombre FROM CAJAsYBANCOS where tipo='CAJA' or tipo='BANCO'"
                da_COMBO_cuentas_paraabrir = New MySqlDataAdapter(sql, conex)
                dt_COMBO_cuentas_paraabrir = New DataTable
                da_COMBO_cuentas_paraabrir.Fill(dt_COMBO_cuentas_paraabrir)

                Me.ComboBox_cta_abre.DataSource = dt_COMBO_cuentas_paraabrir.DefaultView
                Me.ComboBox_cta_abre.DisplayMember = "nombre"
                Me.ComboBox_cta_abre.ValueMember = "cons"
            Catch ex As Exception
                MsgBox(ex.Message)
                conex.Close()
            End Try
            da_COMBO_cuentas_paraabrir.Dispose()
            dt_COMBO_cuentas_paraabrir.Dispose()
            conex.Close()


            Try
                sql = "SELECT CONCAT(CONS,'|',NOMBRE) AS CONS, CUENTAPUC, nombre FROM CAJAsYBANCOS where tipo='CAJA' or tipo='BANCO'"
                da_COMBO_cuentas_paracierre = New MySqlDataAdapter(sql, conex)
                dt_COMBO_cuentas_paracierre = New DataTable
                da_COMBO_cuentas_paracierre.Fill(dt_COMBO_cuentas_paracierre)

                Me.ComboBox_cta_cierre.DataSource = dt_COMBO_cuentas_paracierre.DefaultView
                Me.ComboBox_cta_cierre.DisplayMember = "nombre"
                Me.ComboBox_cta_cierre.ValueMember = "cons"
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da_COMBO_cuentas_paracierre.Dispose()
            dt_COMBO_cuentas_paracierre.Dispose()
            conex.Close()


            'cargar turno activo 
            ' falta
            sql = "SELECT * FROM turnos WHERE empleado = '" & usrnom & "' and estado = '" & "ABIERTO" & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                For Each row As DataRow In dt.Rows
                    turno_actual_global_ID = row.Item("cons")
                    Label_fecha.Text = row.Item("fecha")
                    turno_actual_global = row.Item("cons")
                    Me.Label_cons.Text = turno_actual_global
                    turno_actual_global_empleado = row.Item("empleado")
                    Me.Label_empleado.Text = turno_actual_global_empleado
                    turno_actual_inicio = row.Item("inicio").ToString
                    Me.Label_ini.Text = row.Item("inicio").ToString
                    turno_actual_fin = row.Item("fin").ToString
                    Me.Label_fin.Text = row.Item("fin").ToString
                    Me.TextBox_base.Text = row.Item("base").ToString
                    turno_actual_base = row.Item("base").ToString
                    turno_actual_estado = row.Item("estado").ToString

                    Me.Label18.Text = row.Item("caja").ToString

                Next
                Me.Label_estado.Text = "TURNO " & turno_actual_estado
                If turno_actual_estado = "ABIERTO" Then Me.Label_estado.ForeColor = Color.Lime
                If turno_actual_estado = "" Then Me.Label_estado.ForeColor = Color.Red : turno_actual_estado = "CERRADO" : Me.Label_estado.Text = "Turno " & turno_actual_estado
                Me.Button_CerrarTurno.Visible = True
                Me.Button_abrirTurno.Visible = False
                'Me.TextBox_base.Enabled = False


                ComboBox_cta_cierre.Text = comex_cuenta_cierre
                ComboBox_cta_abre.SelectedValue = Label18.Text






                grid_CAJA()

                Panel1.Visible = True
                TextBox_traslado.Text = 0 : TextBox_traslado.Enabled = False
                BunifuCheckbox1.Checked = False
            End If
        End If

        Me.Cursor = Cursors.Default
    End Sub








    Private Sub grid_CAJA()
        ' ventas todos los turnos toda la caja



        ' ventas  turno
        totalingresos = 0
        totalEGRESOS = 0
        total_impuestos_turno = 0
        Label_TOTAl_EGRESOS.Text = "0"
        LabelVentaTotal.Text = "0"
        Label_propinas.Text = ""
        Me.Label_TOTAL_TOTAL.Text = "0"
        Try
            sql = "SELECT * FROM caja WHERE estado='DESCARGADO' and turno='" & turno_actual_global & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGrid_caja.DataSource = dt
            Me.DataGrid_caja.Columns(0).Visible = False
            Me.DataGrid_caja.Columns(1).Visible = False
            Me.DataGrid_caja.Columns(2).Visible = False
            Me.DataGrid_caja.Columns(9).Visible = False
            Me.DataGrid_caja.Columns(10).Visible = False


            da.Dispose()
            dt.Dispose()
            conex.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            For i As Integer = 0 To DataGrid_caja.RowCount - 1



                'If DataGrid_caja.Item("mediodepago", i).Value.ToString.ToUpper.Contains("CREDITO") = False Then
                '    If DataGrid_caja.Item("tipodocumento", i).Value = "VENTA" Then totalingresos = totalingresos + DataGrid_caja.Item("total", i).Value
                '    If DataGrid_caja.Item("tipodocumento", i).Value = "RECIBO DE CAJA" Then totalingresos = totalingresos + DataGrid_caja.Item("total", i).Value
                '    If DataGrid_caja.Item("tipodocumento", i).Value = "COMPRA" Then totalEGRESOS = totalEGRESOS + DataGrid_caja.Item("total", i).Value
                '    If DataGrid_caja.Item("tipodocumento", i).Value = "COMPROBANTE DE EGRESO" Then totalEGRESOS = totalEGRESOS + DataGrid_caja.Item("total", i).Value

                '    If DataGrid_caja.Item("tipodocumento", i).Value = "Devolución Venta" Then totalEGRESOS = totalEGRESOS + DataGrid_caja.Item("total", i).Value

                'End If
                'If DataGrid_caja.Item("mediodepago", i).Value.ToString.Contains("CREDITO") = True Then
                '    If DataGrid_caja.Item("tipodocumento", i).Value = "VENTA" Then totalingresos = totalingresos + DataGrid_caja.Item("total", i).Value
                '    total_Creditos = total_Creditos + DataGrid_caja.Item("total", i).Value


                'End If




                '======
                If DataGrid_caja.Item("tipodocumento", i).Value = "VENTA" Then
                    TTALVENTAS = TTALVENTAS + DataGrid_caja.Item("total", i).Value
                    If DataGrid_caja.Item("mediodepago", i).Value.ToString.ToUpper.Contains("CREDITO") = True Then
                        TTALVENTASCREDITO = TTALVENTASCREDITO + DataGrid_caja.Item("total", i).Value
                    End If
                End If


                If DataGrid_caja.Item("tipodocumento", i).Value = "COMPRA" Then
                    TTALCOMPRAS = TTALCOMPRAS + DataGrid_caja.Item("total", i).Value
                    If DataGrid_caja.Item("mediodepago", i).Value.ToString.ToUpper.Contains("CREDITO") = True Then
                        TTALCOMPRASCREDITO = TTALCOMPRASCREDITO + DataGrid_caja.Item("total", i).Value
                    End If
                End If


                If DataGrid_caja.Item("tipodocumento", i).Value = "RECIBO DE CAJA" Then
                    TTALRECIBOSCAJA = TTALRECIBOSCAJA + DataGrid_caja.Item("total", i).Value
                End If

                If DataGrid_caja.Item("tipodocumento", i).Value = "COMPROBANTE DE EGRESO" Then
                    TTALEGRESOS = TTALEGRESOS + DataGrid_caja.Item("total", i).Value
                End If

                If DataGrid_caja.Item("tipodocumento", i).Value = "Devolución Venta" Then
                    TTALDEVOLVENTA = TTALDEVOLVENTA + DataGrid_caja.Item("total", i).Value
                End If

                '=========

            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try


        LabelVentaTotal.Text = TTALVENTAS + TTALRECIBOSCAJA
        LabelVentaCredito.Text = TTALVENTASCREDITO
        LabelOtrosIngresos.Text = TTALRECIBOSCAJA
        LabelVentaEfectivo.Text = TTALVENTAS - TTALVENTASCREDITO


        LabelGastos.Text = TTALEGRESOS
        LabelComprasEfectivo.Text = TTALCOMPRAS - TTALCOMPRASCREDITO
        LabelComprasCredito.Text = TTALCOMPRASCREDITO

        Label_TOTAl_EGRESOS.Text = TTALCOMPRAS + TTALEGRESOS + TTALDEVOLVENTA

        Me.Label_TOTAL_TOTAL.Text = ((TTALVENTAS + TTALRECIBOSCAJA - TTALVENTASCREDITO)) - ((TTALCOMPRAS + TTALEGRESOS + TTALDEVOLVENTA) - TTALCOMPRASCREDITO)


        efectivo_actual = 0
        efectivo_actual = CInt(TextBox_base.Text) + Me.Label_TOTAL_TOTAL.Text

        Label_EfectivoEnCaja.Text = FormatNumber(efectivo_actual, 0)



        'descuento
        Try
            sql = "SELECT SUM(descuento) AS descuentos FROM ventas WHERE turno='" & turno_actual_global & "' AND ESTADO<>'ANULADA'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Label_dctos.Text = "0"
            For Each row3 As DataRow In dt.Rows
                If row3.Item("descuentos").ToString <> "" Then
                    Label_dctos.Text = CInt(Label_dctos.Text) + CInt(row3.Item("descuentos"))
                End If
            Next
            da.Dispose()
            dt.Dispose()
            conex.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


        'PROPINAS
        Try
            sql = "SELECT SUM(PROPINA) AS PROPINA FROM ventas WHERE turno='" & turno_actual_global & "' AND ESTADO<>'ANULADA'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Label_propinas.Text = "0"
            For Each row3 As DataRow In dt.Rows
                If row3.Item("PROPINA").ToString <> "" Then
                    Label_propinas.Text = CInt(Label_propinas.Text) + CInt(row3.Item("PROPINA"))
                End If
            Next
            da.Dispose()
            dt.Dispose()
            conex.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


        Try
            sql = "SELECT ventas.documento, concat(ventas.DocCliente,' ', ventas.ClienteNom) as Cliente, 
ventas_prods.CodProd, ventas_prods.Producto, ventas_prods.cantidad, ventas_prods.ValorU,
ventas.Salon, ventas.Mesa, ventas.Mesero, ventas.Total, ventas.MediodePago, ventas.propina, ventas.cambio 
FROM ventas
inner join ventas_prods 
on ventas.documento=ventas_prods.documento 
WHERE ventas.turno='" & turno_actual_global_ID & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.MetroGrid_det_ventas.DataSource = dt

            da.Dispose()
            dt.Dispose()
            conex.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        MetroGrid_det_ventas.ClearSelection()

        ' impuestos
        Try
            sql = "SELECT  ventas_prods.ImpNom2 as impuesto, 
FORMAT(sum(ventas_prods.valortotal-ventas_prods.impuesto2),0) as Base, 
FORMAT(sum(ventas_prods.impuesto2),0) as Valor, 
FORMAT(sum(ventas_prods.valortotal),0) as Total
FROM ventas_prods
left join ventas on ventas_prods.documento=ventas.documento
where ventas.turno='" & turno_actual_global & "'
group by ventas_prods.impnom2"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            MetroGrid_IMPTURNO.DataSource = dt.DefaultView
            total_impuestos_turno = "0"
            For Each row3 As DataRow In dt.Rows
                If row3.Item("impuesto") <> "NO" Then total_impuestos_turno = CInt(total_impuestos_turno) + CDec(row3.Item("valor"))

            Next
        Catch ex As Exception
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        conex.Close()

        total_impuestos_turno = total_impuestos_turno.Replace(",", "")
        Label_impuestosTURNO.Text = FormatNumber(total_impuestos_turno, 0)

        DataGrid_caja.ClearSelection()
        MetroGrid_IMPTURNO.ClearSelection()




        'resumen
        Try
            sql = "SELECT caja.tipodocumento AS Comprobante, caja.MediodePago as MedioPago, format(SUM(caja.Total),0) AS TOTAL 
FROM caja where caja.turno='" & turno_actual_global & "' GROUP BY caja.tipodocumento, caja.MediodePago"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DATAGrid_PDF.DataSource = dt

            da.Dispose()
            dt.Dispose()
            conex.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        DATAGrid_PDF.ClearSelection()


    End Sub
    Private Sub grid_CAJA_EXPORT()






    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button_abrirTurno.Click
        If ComboBox_cta_abre.Text = "" Then
            MsgBox("selccione una caja para inicar ventas.")
            Exit Sub
        End If



        Select Case MessageBox.Show("Se Abrirá turno con los siguientes datos: " & Chr(13) & Chr(13) &
                                    "Dinero Base:  $ " & Me.TextBox_base.Text & Chr(13) &
                                    "Fecha: " & DateTime.Now.ToShortDateString & Chr(13) &
                                    "Empleado: " & usrnom & Chr(13) & Chr(13) &
                                    "Confirma abrir el turno?", "Inicio de Turno", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            Case DialogResult.Yes
                CONSECUTIVOs("turnos")
                Me.Label_cons.Text = consecutivo
                Me.Label_fecha.Text = DateTime.Now.ToShortDateString
                Me.Label_ini.Text = DateTime.Now.ToLongTimeString
                turno_actual_estado = "ABIERTO"
                Me.Label_estado.Text = "Turno " & turno_actual_estado
                If turno_actual_estado = "ABIERTO" Then Me.Label_estado.ForeColor = Color.Lime
                Me.Label_empleado.Text = usrnom
                turno_actual_global_ID = consecutivo
                turno_actual_global = consecutivo
                turno_actual_global_empleado = usrnom
                turno_actual_inicio = DateTime.Now.ToLongTimeString
                turno_actualfecha = DateTime.Now.ToShortDateString


                Label_fecha.Text = DateTime.Now.ToShortDateString
                Label18.Text = ComboBox_cta_abre.SelectedValue
                ' inserto en turno el nuevo turno y lo dejo en estado abierto
                sql = "INSERT INTO turnos (fecha, empleado, inicio, base, TOTAL, caja, estado)" &
                "VALUES ('" & Label_fecha.Text & "','" & usrnom & "','" & turno_actual_inicio & "','" & Me.TextBox_base.Text & "','0','" & Me.Label18.Text & "','" & "ABIERTO" & "')"
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                Try
                    da.Fill(dt)
                    '  MsgBox("Se Guardaron los datos. ")
                Catch ex As Exception
                    If ex.ToString.Contains("Duplicate entry") Then MsgBox("Ya existe turno registrado, verifique los datos.", vbExclamation)
                End Try
                da.Dispose()
                dt.Dispose()
                conex.Close()

                Me.TextBox_base.Enabled = False

                grid_CAJA()

                Me.Button_abrirTurno.Visible = False
                Me.Button_CerrarTurno.Visible = True

                'Form_Main.Timer_turno.Enabled = True

                Me.Close()
            Case DialogResult.No
                Exit Sub
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Me.Close()
    End Sub


    Private Sub Button_CerrarTurno_Click(sender As Object, e As EventArgs) Handles Button_CerrarTurno.Click
        If BunifuCheckbox1.Checked = True Then

            If TextBox_traslado.Text = 0 Or ComboBox_cta_cierre.Text = "" Then
                MsgBox("escriba el valor a trasladar Y la cuenta destino.")
                Exit Sub
            End If


            If ComboBox_cta_abre.Text = ComboBox_cta_cierre.Text Then
                MsgBox("Para trasladar las ventas seleccione una cuenta destino diferente.")
                Exit Sub
            End If



        End If


        Dim rta As String
        rta = MsgBox("ESTA SEGURO QUE DESEA CERRAR EL TURNO?.", MsgBoxStyle.Question + MsgBoxStyle.YesNo)

        If rta = 6 Then
            tipo_cierre = "CIERRE DE TURNO"
            Label_fin.Text = DateTime.Now.ToString
            Try
                sql = "UPDATE turnos SET total='" & Me.LabelVentaTotal.Text & "', estado='" & "CERRADO" & "', FIN='" & DateTime.Now.ToString & "' WHERE CONS=" & CLng(turno_actual_global_ID) & ""
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                da.Fill(dt)
                ' MsgBox("SE CERRO TURNO ACTUAL.", vbInformation)
                da.Dispose()
                dt.Dispose()
                conex.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
                da.Dispose()
                dt.Dispose()
                conex.Close()
            End Try

            Try
                sql = "UPDATE CAJA SET estado='DESCARGADO' WHERE TURNO='" & CStr(turno_actual_global) & "' and estado<>'ANULADO'"
                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                da.Fill(dt)
                ' MsgBox("SE CERRO TURNO ACTUAL.", vbInformation)
                da.Dispose()
                dt.Dispose()
                conex.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
                da.Dispose()
                dt.Dispose()
                conex.Close()
            End Try


            If BunifuCheckbox1.Checked = True Then    ' INICIO TRASLDADO
                Dim cuenta_origen() As String = Split(Label18.Text, "|")
                Dim cuenta_destino() As String = Split(ComboBox_cta_cierre.SelectedValue, "|")

                Dim rol As String = ""
                Dim PROD_SALEN, PROD_ENTRAN, PROD_SALDO As String
                PROD_ENTRAN = "0"
                PROD_SALEN = "0"
                PROD_SALEN = "0"
                PROD_SALDO = "0"

                rol = "SALEN"
                PROD_SALEN = CInt(TextBox_traslado.Text)
                PROD_ENTRAN = 0

                Dim TERCERO As String = CStr(comex_nit) & "|" & CStr(comex_nombrecomercial)

                sql = "INSERT INTO cajaspuc(Codcuenta, cuenta, TERCERO, Fecha, Documento, TipoDoc, Rol, SaldoAnt, debe, haber, Saldo, Estado, annoactual)" &
                               "VALUES ('" & cuenta_origen(0) & "','" & (cuenta_origen(1)) & "','" & CStr(TERCERO) & "','" & DateTime.Now.ToShortDateString & "','" & Label_cons.Text & "','TRASLADO DE FONDOS','" & rol & "',0," & PROD_ENTRAN & "," & PROD_SALEN & "," & PROD_SALDO & ",'DESCARGADO','" & comex_annoactual & "')"
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
                PROD_ENTRAN = 0
                PROD_SALDO = 0

                rol = "ENTRAN"
                PROD_ENTRAN = CInt(TextBox_traslado.Text)
                PROD_SALEN = 0

                'REGISTRO EN PUC

                sql = "INSERT INTO cajaspuc(Codcuenta, cuenta, TERCERO, Fecha, Documento, TipoDoc, Rol, SaldoAnt, debe, haber, Saldo, Estado, annoactual)" &
                               "VALUES ('" & cuenta_destino(0) & "','" & cuenta_destino(1) & "','" & CStr(TERCERO) & "','" & DateTime.Now.ToShortDateString & "','" & Label_cons.Text & "','TRASLADO DE FONDOS','SALEN',0," & PROD_ENTRAN & "," & PROD_SALEN & "," & PROD_SALDO & ",'DESCARGADO','" & comex_annoactual & "')"
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
                      "VALUES ('CIERRE DE TURNO','" & Label_cons.Text & "','" & CStr(comex_nombrecomercial & "|" & comex_nit) & "','" & DateTime.Now.ToShortDateString & "','" & cuenta_origen(0) & "','" & cuenta_origen(1) & "','" & cuenta_destino(0) & "','" & cuenta_destino(1) & "','" & TextBox2.Text & "','" & Label_empleado.Text & "','" & TextBox_traslado.Text & "','DESCARGADO')"

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

            End If    ' FIN DE TRASLADO

            Button2_Click(Nothing, Nothing)

            turno_actual_global = ""
            turno_actual_global_ID = ""
            turno_actualfecha = ""
            turno_actual_global_empleado = ""
            turno_actual_inicio = ""
            turno_actual_fin = ""
            turno_actual_estado = "CERRADO"
            turno_actual_base = ""

            Me.TextBox_base.Text = "0"
            Me.Label_cons.Text = "?"
            Me.Label_fecha.Text = "?"
            Me.Label_ini.Text = "?"
            Me.Label_fin.Text = "?"
            Me.Label_empleado.Text = USR_NOM
            Me.Label_estado.Text = "TURNO CERRADO"
            Me.Label_estado.ForeColor = Color.Red

            Me.DataGrid_caja.DataSource = Nothing
            Me.MetroGrid_det_ventas.DataSource = Nothing
            Me.MetroGrid_IMPTURNO.DataSource = Nothing

            Me.Button_CerrarTurno.Visible = False
            'Me.Button_abrirTurno.Visible = True

            Label_fecha.Text = DateTime.Now.ToShortDateString
            MsgBox("SE CERRO EL TURNO CORRECTAMENTE. ", vbInformation)

            'Form_Main.Timer_turno.Enabled = True
        End If

    End Sub

    Private Sub TextBox_base_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_base.KeyPress
        'If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""
        If Label_estado.Text = "TURNO ABIERTO" Then e.KeyChar = ""
    End Sub

    Private Sub TextBox_base_TextChanged(sender As Object, e As EventArgs) Handles TextBox_base.TextChanged

        If Me.TextBox_base.Text = "" Then Me.TextBox_base.Text = "0"
        Me.TextBox_base.Text = FormatNumber(Me.TextBox_base.Text, 0)
        Me.TextBox_base.Select(Me.TextBox_base.Text.Length, 0)
    End Sub

    Private Sub Label_total_RECAUDO_Click(sender As Object, e As EventArgs) Handles LabelVentaTotal.Click

    End Sub

    Private Sub Label_TOTA_EGRESOS_Click(sender As Object, e As EventArgs) Handles Label_TOTAl_EGRESOS.Click
        If Me.Label_TOTAl_EGRESOS.Text = "" Then Me.Label_TOTAl_EGRESOS.Text = "0"
        Me.Label_TOTAl_EGRESOS.Text = FormatNumber(Me.Label_TOTAl_EGRESOS.Text, 0)
    End Sub

    Private Sub Label_TOTAL_TOTAL_Click(sender As Object, e As EventArgs) Handles Label_TOTAL_TOTAL.Click
        If Me.Label_TOTAL_TOTAL.Text = "" Then Me.Label_TOTAL_TOTAL.Text = "0"
        Me.Label_TOTAL_TOTAL.Text = FormatNumber(Me.Label_TOTAL_TOTAL.Text, 0)
    End Sub

    Private Sub Button_export_pdf_ventas_Click(sender As Object, e As EventArgs) Handles Button_export.Click

        Me.Cursor = Cursors.WaitCursor


        ' ventas  turno  caja
        totalingresos = 0
        Try
            sql = "SELECT caja.tipodocumento AS Comprobante, caja.MediodePago as MedioPago, format(SUM(caja.Total),0) AS TOTAL 
FROM caja where caja.turno='" & turno_actual_global & "' GROUP BY caja.tipodocumento, caja.MediodePago"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DATAGrid_PDF.DataSource = dt

            da.Dispose()
            dt.Dispose()
            conex.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try





        Try
            sql = "/*ventas por productco*/
SELECT CONCAT(ventas_prods.CodProd,'-',ventas_prods.Producto) AS Producto, sum(ventas_prods.cantidad) as Cant,
format(sum(ventas_prods.valortotal),0)  as Total
FROM ventas
inner join ventas_prods 
on ventas.documento=ventas_prods.documento where ventas.turno='" & turno_actual_global & "'
group by ventas_prods.CodProd;"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.MetroGrid_det_ventas.DataSource = dt

            da.Dispose()
            dt.Dispose()
            conex.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try



        Try
            'Intentar generar el documento.
            Dim pgSize = New iTextSharp.text.Rectangle(250, DATAGrid_PDF.RowCount * 10 + 200)

            Dim doc As New Document(PageSize.A4, 15, 15, 15, 15)
            'Dim doc As New Document(pgSize, 8, 8, 10, 10)

            'Path que guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\CIERRE DE TURNO " & turno_actual_global & ".pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)

            PdfWriter.GetInstance(doc, file)
            doc.Open()
            ExportarDatosPDF_CARTA(doc)
            doc.Close()
            Process.Start(filename)
        Catch ex As Exception
            'Si el intento es fallido, mostrar MsgBox.
            Me.Cursor = Cursors.Default
            MessageBox.Show("No se puede generar el documento PDF, Cierre los documentos PDF generados anteriormente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Public Sub ExportarDatosPDF_CARTA(ByVal document As Document)
        Dim CANT_FILAS As Integer = 0
        'Se crea un objeto PDFTable con el numero de columnas del DataGridView.
        Dim datatable As New PdfPTable(DATAGrid_PDF.ColumnCount)

        Dim datatableIMP As New PdfPTable(MetroGrid_IMPTURNO.ColumnCount)

        'Se asignan algunas propiedades para el diseño del PDF.
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(DATAGrid_PDF)

        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER


        Dim datatable_det_ventas As New PdfPTable(MetroGrid_det_ventas.ColumnCount)
        'Se asignan algunas propiedades para el diseño del PDF.
        datatable_det_ventas.DefaultCell.Padding = 3
        'Dim headerwidths2 As Single() = GetColumnasSize(MetroGrid_det_ventas)

        Dim anchos() As Single = {300, 70, 100}
        datatable_det_ventas.SetWidths(anchos)
        datatable_det_ventas.WidthPercentage = 100
        datatable_det_ventas.DefaultCell.BorderWidth = 2
        datatable_det_ventas.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT



        'Se asignan algunas propiedades para el diseño del PDF.
        datatableIMP.DefaultCell.Padding = 3
        Dim headerwidthsimp As Single() = GetColumnasSize(MetroGrid_IMPTURNO)

        datatableIMP.SetWidths(headerwidthsimp)
        datatableIMP.WidthPercentage = 100
        datatableIMP.DefaultCell.BorderWidth = 0
        datatableIMP.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER



        Dim fontLINE = iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLD)

        Dim encabezadoFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 10, iTextSharp.text.Font.BOLD)
        Dim contentFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 10, iTextSharp.text.Font.BOLD)
        Dim DIRFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 6, iTextSharp.text.Font.BOLD)
        Dim rowFont = iTextSharp.text.FontFactory.GetFont("Times New Roman", 7, iTextSharp.text.Font.NORMAL)
        Dim DIRFont2 = iTextSharp.text.FontFactory.GetFont("Arial Black", 7.5, iTextSharp.text.Font.BOLD)
        Dim DIRFont9 = iTextSharp.text.FontFactory.GetFont("Arial Black", 9.5D, iTextSharp.text.Font.NORMAL)

        Dim FIRMAFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 5, iTextSharp.text.Font.BOLD)
        Dim totalFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 8, iTextSharp.text.Font.BOLD)
        Dim totaltotalFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 9, iTextSharp.text.Font.BOLDITALIC)
        Dim CLIENTEFONT = iTextSharp.text.FontFactory.GetFont("Arial Black", 7, iTextSharp.text.Font.BOLDITALIC)

        'Se crea el encabezado en el PDF.

        Dim encabezadoLINE As New Paragraph("_____________________________________________________", fontLINE)

        encabezadoLINE.Alignment = 0
        encabezadoLINE.Font = fontLINE

        Dim encabezadoLINE2 As New Paragraph("========================================================================================================================", fontLINE)
        Dim encabezadoLINE3 As New Paragraph("_______________________________________________________________________________________________________________________________", fontLINE)

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


        cellhome.Phrase = New Phrase(comex_nombrecomercial, contentFont)
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase(comex_nombrepropietario, DIRFont)
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase("NIT:" & comex_nit & "-" & comex_DV & " " & comex_regimen, DIRFont)
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase("Tels:" & comex_tels & " - " & comex_cels, DIRFont)
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase(comex_dircomercio, DIRFont)
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()


        Dim TURNO_ESTADO_PRINT As String = ""
        If turno_actual_estado = "ABIERTO" Then TURNO_ESTADO_PRINT = "PARCIAL DE TURNO #"
        If turno_actual_estado = "CERRADO" Then TURNO_ESTADO_PRINT = "CIERRE DE TURNO #"
        Dim encabezado As New Paragraph(TURNO_ESTADO_PRINT & turno_actual_global, encabezadoFont)
        encabezado.Alignment = Element.ALIGN_CENTER
        encabezado.Font = encabezadoFont


        Dim PDF_temrinal As New Paragraph("Terminal:" & SERIAL_PROC, DIRFont) : PDF_temrinal.Alignment = 0
        Dim PDF_CONSECUTIVO As New Paragraph("Empleado. " + Chr(13) + Label_empleado.Text, DIRFont) : PDF_CONSECUTIVO.Alignment = 0
        Dim encabezado2 As New Paragraph("Fecha: " + Label_fecha.Text, DIRFont) : encabezado2.Alignment = 0
        Dim encabezado3 As New Paragraph("Inicio:" + turno_actual_inicio + " Fin:" + turno_actual_fin, DIRFont) : encabezado2.Alignment = 0



        Dim tabla_turno_data As New PdfPTable(2)
        tabla_turno_data.WidthPercentage = 100
        tabla_turno_data.DefaultCell.Padding = 0
        tabla_turno_data.DefaultCell.BorderWidth = 0
        tabla_turno_data.SpacingBefore = 0
        tabla_turno_data.HorizontalAlignment = 0
        Dim cellturno As New PdfPCell
        cellturno.BorderWidth = 0


        cellturno.Phrase = New Phrase("(+)Base: $", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Format(CInt(TextBox_base.Text), "##,##"), DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("(+)Ventas: $", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Format(CInt(LabelVentaTotal.Text) - CInt(total_impuestos_turno), "##,##"), DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("(-)Descuentos: $", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase("0", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("===============", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase("===============", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("VENTAS NETAS: $", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Format(CInt(CInt(LabelVentaTotal.Text) - CInt(total_impuestos_turno)), "##,##"), DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("(+)impuestos: $", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Format(CInt(total_impuestos_turno), "##,##"), DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("================", DIRFont)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase("================", DIRFont)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea


        cellturno.Phrase = New Phrase("TOTAL VENTAS: $", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Format(CInt(LabelVentaTotal.Text), "##,##"), DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea



        cellturno.Phrase = New Phrase("(+)Propinas: $", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Label_propinas.Text, DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea


        cellturno.Phrase = New Phrase("(-)Gastos: $", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Format(CInt(Label_TOTAl_EGRESOS.Text), "##,##"), DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea


        cellturno.Phrase = New Phrase("================", DIRFont)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase("================", DIRFont)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("TOTAL TURNO: $", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Format(CInt(CInt(LabelVentaTotal.Text) - CInt(Label_TOTAl_EGRESOS.Text)), "##,##"), DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea


        Dim encabezado7 As New Paragraph("Se Imprimió el " + DateTime.Now + Chr(13) + "Por: " + usrnom, DIRFont) : encabezado7.Alignment = 0
        Dim encabezado8 As New Paragraph("Detalle de Impuestos", iTextSharp.text.FontFactory.GetFont("Arial Black", 9, iTextSharp.text.Font.BOLD)) : encabezado8.Alignment = Element.ALIGN_CENTER
        Dim encabezado9 As New Paragraph("Ventas por Producto", iTextSharp.text.FontFactory.GetFont("Arial Black", 9, iTextSharp.text.Font.BOLD)) : encabezado9.Alignment = 0

        Dim encabezado_resumenOP As New Paragraph("Resumen de Operaciones", iTextSharp.text.FontFactory.GetFont("Arial Black", 9, iTextSharp.text.Font.BOLD)) : encabezado_resumenOP.Alignment = Element.ALIGN_CENTER

        Dim encabezado6 As New Paragraph("Relación de Operaciones", iTextSharp.text.FontFactory.GetFont("Arial Black", 9, iTextSharp.text.Font.BOLD)) : encabezado6.Alignment = Element.ALIGN_CENTER
        Dim encabezado_gastYegre As New Paragraph("Relación de Gastos y Egresos", iTextSharp.text.FontFactory.GetFont("Arial Black", 9, iTextSharp.text.Font.BOLD)) : encabezado_gastYegre.Alignment = Element.ALIGN_CENTER

        Dim glue = New Chunk(New VerticalPositionMark())

        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To MetroGrid_IMPTURNO.ColumnCount - 1
            Dim HEADERCELLFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 5, iTextSharp.text.Font.BOLD)

            Dim cell_TITLE As New PdfPCell
            cell_TITLE.Phrase = New Phrase(MetroGrid_IMPTURNO.Columns(i).HeaderText, HEADERCELLFont)
            cell_TITLE.HorizontalAlignment = Element.ALIGN_CENTER
            cell_TITLE.BackgroundColor = BaseColor.LIGHT_GRAY
            datatableIMP.AddCell(cell_TITLE)
        Next
        datatableIMP.HeaderRows = 1
        datatableIMP.DefaultCell.BorderWidth = 0
        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To MetroGrid_IMPTURNO.RowCount - 1
            For j As Integer = 0 To MetroGrid_IMPTURNO.ColumnCount - 1
                Dim cell As New PdfPCell
                cell.Phrase = New Phrase(MetroGrid_IMPTURNO(j, i).FormattedValue.ToString, rowFont)
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
                datatableIMP.AddCell(cell)
            Next
            datatableIMP.CompleteRow()
        Next


        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To DATAGrid_PDF.ColumnCount - 1
            Dim HEADERCELLFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 8, iTextSharp.text.Font.BOLD)

            Dim cell_TITLE As New PdfPCell
            cell_TITLE.Phrase = New Phrase(DATAGrid_PDF.Columns(i).HeaderText, HEADERCELLFont)
            cell_TITLE.HorizontalAlignment = Element.ALIGN_CENTER
            cell_TITLE.BackgroundColor = BaseColor.LIGHT_GRAY
            datatable.AddCell(cell_TITLE)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 0
        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To DATAGrid_PDF.RowCount - 1
            For j As Integer = 0 To DATAGrid_PDF.ColumnCount - 1
                Dim cell As New PdfPCell
                cell.Phrase = New Phrase(DATAGrid_PDF(j, i).FormattedValue.ToString, rowFont)
                If j = 0 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 1 Then cell.HorizontalAlignment = Element.ALIGN_CENTER
                If j = 2 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT : cell.BackgroundColor = BaseColor.LIGHT_GRAY
                If j = 3 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT : cell.BackgroundColor = BaseColor.LIGHT_GRAY
                If j = 4 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 5 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 6 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 7 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                cell.Border = 0
                cell.BorderWidthRight = 0.3F
                cell.BorderColorRight = BaseColor.BLACK
                datatable.AddCell(cell)
            Next
            datatable.CompleteRow()
        Next



        ' AGRUPACION
        Try
            sql = "SELECT DISTINCT(PRODUCTOS_CATEGORIAS.CATEGORIA)
FROM ventas
inner join ventas_prods 
on ventas.documento=ventas_prods.documento 
INNER JOIN PRODUCTOS ON VENTAS_PRODS.CODPROD=PRODUCTOS.COD
INNER JOIN PRODUCTOS_CATEGORIAS ON PRODUCTOS.CATEGORIA=PRODUCTOS_CATEGORIAS.CATEGORIA
where ventas.TURNO='" & turno_actual_global & "' group by ventas_prods.CodProd"
            da_AGRUPACION = New MySqlDataAdapter(sql, conex)
            dt_AGRUPACION = New DataTable
            da_AGRUPACION.Fill(dt_AGRUPACION)
            For Each row3 As DataRow In dt_AGRUPACION.Rows
                'CStr(row3.Item("CATEGORIA"))


                Try
                    sql = "SELECT CONCAT(ventas_prods.CodProd,'-',ventas_prods.Producto) AS Producto, sum(ventas_prods.cantidad) as Cant,
format(sum(ventas_prods.valortotal),0)  as Total
FROM ventas
inner join ventas_prods 
on ventas.documento=ventas_prods.documento 
INNER JOIN PRODUCTOS ON VENTAS_PRODS.CODPROD=PRODUCTOS.COD
INNER JOIN PRODUCTOS_CATEGORIAS ON PRODUCTOS.CATEGORIA=PRODUCTOS_CATEGORIAS.CATEGORIA
where ventas.TURNO='" & turno_actual_global & "' AND PRODUCTOS_CATEGORIAS.CATEGORIA='" & CStr(row3.Item("CATEGORIA")) & "' group by ventas_prods.CodProd"
                    da = New MySqlDataAdapter(sql, conex)
                    dt = New DataTable
                    da.Fill(dt)
                    Me.MetroGrid_det_ventas.DataSource = dt

                    da.Dispose()
                    dt.Dispose()
                    conex.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

                'Dim encabezado_CAT As New Paragraph(CStr(row3.Item("CATEGORIA")) + Chr(13), DIRFont) : encabezado_CAT.Alignment = 0
                'document.Add(encabezado_CAT)



                Dim cell_CAT As New PdfPCell
                cell_CAT.Phrase = New Phrase("( " + CStr(row3.Item("CATEGORIA")) + " )", iTextSharp.text.FontFactory.GetFont("Arial Black", 9, iTextSharp.text.Font.BOLD))
                cell_CAT.BorderWidth = 0
                cell_CAT.BackgroundColor = BaseColor.WHITE
                cell_CAT.HorizontalAlignment = Element.ALIGN_CENTER
                cell_CAT.Colspan = 3
                datatable_det_ventas.AddCell(cell_CAT)
                cell_CAT.Phrase = New Phrase("", DIRFont2)
                cell_CAT.BorderWidth = 0
                cell_CAT.BackgroundColor = BaseColor.WHITE
                datatable_det_ventas.AddCell(cell_CAT)
                cell_CAT.Phrase = New Phrase("", DIRFont2)
                cell_CAT.BorderWidth = 0
                cell_CAT.BackgroundColor = BaseColor.WHITE
                datatable_det_ventas.AddCell(cell_CAT)
                datatable_det_ventas.CompleteRow()

                'Se capturan los nombres de las columnas del DataGridView.
                For i As Integer = 0 To MetroGrid_det_ventas.ColumnCount - 1
                    Dim HEADERCELLFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 8, iTextSharp.text.Font.BOLD)

                    Dim cell_TITLE As New PdfPCell
                    cell_TITLE.Phrase = New Phrase(MetroGrid_det_ventas.Columns(i).HeaderText, HEADERCELLFont)
                    cell_TITLE.HorizontalAlignment = Element.ALIGN_CENTER
                    cell_TITLE.BackgroundColor = BaseColor.LIGHT_GRAY
                    datatable_det_ventas.AddCell(cell_TITLE)
                Next
                datatable_det_ventas.HeaderRows = 1
                datatable_det_ventas.DefaultCell.BorderWidth = 0
                'Se generan las columnas del DataGridView.
                For i As Integer = 0 To MetroGrid_det_ventas.RowCount - 1
                    For j As Integer = 0 To MetroGrid_det_ventas.ColumnCount - 1
                        Dim cell As New PdfPCell
                        cell.Phrase = New Phrase(MetroGrid_det_ventas(j, i).FormattedValue.ToString, rowFont)
                        If j = 0 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                        If j = 1 Then cell.HorizontalAlignment = Element.ALIGN_CENTER
                        If j = 2 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT : cell.BackgroundColor = BaseColor.LIGHT_GRAY
                        If j = 3 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                        If j = 4 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                        If j = 5 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                        If j = 6 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                        If j = 7 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                        cell.Border = 0
                        cell.BorderWidthRight = 0.0F
                        cell.BorderColorRight = BaseColor.BLACK
                        datatable_det_ventas.AddCell(cell)
                    Next
                    datatable_det_ventas.CompleteRow()
                Next



            Next
            'datatable_det_ventas.SpacingBefore = 10
            'If BunifuCheckbox_det_ventas.Checked = True Then document.Add(datatable_det_ventas)

        Catch ex As Exception
        End Try
        conex.Close()
        da_AGRUPACION.Dispose()
        dt_AGRUPACION.Dispose()
        conex.Close()

        If comex_logo <> "" Then
            Dim imagelogogopdf As iTextSharp.text.Image 'Declaracion de una imagen

            imagelogogopdf = iTextSharp.text.Image.GetInstance(comex_logo) 'Dirreccion a la imagen que se hace referencia
            imagelogogopdf.Alignment = Element.ALIGN_RIGHT
            imagelogogopdf.SetAbsolutePosition(410, 760) 'Posicion en el eje cartesiano
            imagelogogopdf.ScaleAbsoluteWidth(160) 'Ancho de la imagen
            imagelogogopdf.ScaleAbsoluteHeight(60) 'Altura de la imagen
            document.Add(imagelogogopdf) ' Agrega la imagen al documento
        End If

        document.Add(encabezadoLINE)
        document.Add(tablahome)
        document.Add(encabezadoLINE2)
        document.Add(encabezado)
        document.Add(PDF_temrinal)
        document.Add(PDF_CONSECUTIVO)
        document.Add(encabezado2)
        document.Add(encabezado3)
        document.Add(encabezado_resumenOP)
        tabla_turno_data.SpacingBefore = 10
        document.Add(tabla_turno_data)
        document.Add(encabezado6)
        datatable.SpacingBefore = 10
        document.Add(datatable)
        document.Add(encabezadoLINE3)
        encabezado9.Alignment = Element.ALIGN_CENTER
        document.Add(encabezado9)
        datatable_det_ventas.SpacingBefore = 10
        document.Add(datatable_det_ventas)
        document.Add(encabezadoLINE3)
        encabezado8.SpacingAfter = 4
        document.Add(encabezado8)
        document.Add(datatableIMP)
        document.Add(encabezadoLINE3)

        document.Add(encabezado7)
        document.Add(encabezadoLINE)


    End Sub

    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        'funcion para obtener el tamaño de la columnas del datagridview
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function



    Private Sub DataGrid_caja_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid_caja.CellContentClick

    End Sub





    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Cursor = Cursors.WaitCursor


        If Label_estado.Text = "TURNO CERRADO" Then
            Me.Cursor = Cursors.Default

            MsgBox("No hay nada que imprimir.")

            Exit Sub

        End If


        ' ventas  turno  caja
        totalingresos = 0
        Try
            sql = "SELECT caja.tipodocumento AS Comprobante, caja.MediodePago as MedioPago, format(SUM(caja.Total),0) AS TOTAL 
FROM caja where caja.turno='" & turno_actual_global & "' GROUP BY caja.tipodocumento, caja.MediodePago"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.DATAGrid_PDF.DataSource = dt

            da.Dispose()
            dt.Dispose()
            conex.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try





        Try
            sql = "/*ventas por productco*/
SELECT CONCAT(ventas_prods.CodProd,'-',ventas_prods.Producto) AS Producto, sum(ventas_prods.cantidad) as Cant,
format(sum(ventas_prods.valortotal),0)  as Total
FROM ventas
inner join ventas_prods 
on ventas.documento=ventas_prods.documento where ventas.turno='" & turno_actual_global & "'
group by ventas_prods.CodProd;"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Me.MetroGrid_det_ventas.DataSource = dt

            da.Dispose()
            dt.Dispose()
            conex.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try





        Try
            'Intentar generar el documento
            alto_pag = (DATAGrid_PDF.RowCount + DATAGrid_PDF.RowCount) * 20 + 600
            Dim pgSize = New iTextSharp.text.Rectangle(205, alto_pag)

            'Dim doc As New Document(PageSize.A4, 8, 400, 10, 10)
            Dim doc As New Document(pgSize, 8, 8, 10, 10)

            'Path que guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\CIERRE DE TURNO " & turno_actual_global & ".pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)

            PdfWriter.GetInstance(doc, file)
            doc.Open()
            ExportarDatosPDF_POS(doc)
            doc.Close()

            Process.Start("C:\Program Files\Tracker Software\PDF Viewer\pdfxcview.exe", """" & Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\CIERRE DE TURNO " & turno_actual_global & ".pdf" & """")


        Catch ex As Exception
            'Si el intento es fallido, mostrar MsgBox.
            Me.Cursor = Cursors.Default
            MessageBox.Show("No se puede generar el documento PDF, Cierre los documentos PDF generados anteriormente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Cursor = Cursors.Default

    End Sub


    Public Sub ExportarDatosPDF_POS(ByVal document As Document)
        Dim CANT_FILAS As Integer = 0
        'Se crea un objeto PDFTable con el numero de columnas del DataGridView.
        Dim datatable As New PdfPTable(DATAGrid_PDF.ColumnCount)

        Dim datatableIMP As New PdfPTable(MetroGrid_IMPTURNO.ColumnCount)

        'Se asignan algunas propiedades para el diseño del PDF.
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(DATAGrid_PDF)

        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER


        Dim datatable_det_ventas As New PdfPTable(MetroGrid_det_ventas.ColumnCount)
        'Se asignan algunas propiedades para el diseño del PDF.
        datatable_det_ventas.DefaultCell.Padding = 3
        'Dim headerwidths2 As Single() = GetColumnasSize(MetroGrid_det_ventas)

        Dim anchos() As Single = {300, 70, 100}
        datatable_det_ventas.SetWidths(anchos)
        datatable_det_ventas.WidthPercentage = 100
        datatable_det_ventas.DefaultCell.BorderWidth = 2
        datatable_det_ventas.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT



        'Se asignan algunas propiedades para el diseño del PDF.
        datatableIMP.DefaultCell.Padding = 3
        Dim headerwidthsimp As Single() = GetColumnasSize(MetroGrid_IMPTURNO)

        datatableIMP.SetWidths(headerwidthsimp)
        datatableIMP.WidthPercentage = 100
        datatableIMP.DefaultCell.BorderWidth = 0
        datatableIMP.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER



        Dim fontLINE = iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLD)

        Dim encabezadoFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 10, iTextSharp.text.Font.BOLD)
        Dim contentFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 10, iTextSharp.text.Font.BOLD)
        Dim DIRFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 6, iTextSharp.text.Font.BOLD)
        Dim rowFont = iTextSharp.text.FontFactory.GetFont("Times New Roman", 7, iTextSharp.text.Font.NORMAL)
        Dim DIRFont2 = iTextSharp.text.FontFactory.GetFont("Arial Black", 7.5, iTextSharp.text.Font.BOLD)
        Dim DIRFont9 = iTextSharp.text.FontFactory.GetFont("Arial Black", 9.5D, iTextSharp.text.Font.NORMAL)

        Dim FIRMAFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 5, iTextSharp.text.Font.BOLD)
        Dim totalFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 8, iTextSharp.text.Font.BOLD)
        Dim totaltotalFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 9, iTextSharp.text.Font.BOLDITALIC)
        Dim CLIENTEFONT = iTextSharp.text.FontFactory.GetFont("Arial Black", 7, iTextSharp.text.Font.BOLDITALIC)

        'Se crea el encabezado en el PDF.

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


        cellhome.Phrase = New Phrase(comex_nombrecomercial, contentFont)
        cellhome.HorizontalAlignment = Element.ALIGN_CENTER
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase(comex_nombrepropietario, DIRFont)
        cellhome.HorizontalAlignment = Element.ALIGN_CENTER
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase("NIT:" & comex_nit & "-" & comex_DV & " " & comex_regimen, DIRFont)
        cellhome.HorizontalAlignment = Element.ALIGN_CENTER
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase("Tels:" & comex_tels & " - " & comex_cels, DIRFont)
        cellhome.HorizontalAlignment = Element.ALIGN_CENTER
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase(comex_dircomercio, DIRFont)
        cellhome.HorizontalAlignment = Element.ALIGN_CENTER
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()


        Dim TURNO_ESTADO_PRINT As String = ""
        If turno_actual_estado = "ABIERTO" Then TURNO_ESTADO_PRINT = "PARCIAL DE TURNO #"
        If turno_actual_estado = "CERRADO" Then TURNO_ESTADO_PRINT = "CIERRE DE TURNO #"
        Dim encabezado As New Paragraph(TURNO_ESTADO_PRINT & turno_actual_global, encabezadoFont)
        encabezado.Alignment = Element.ALIGN_CENTER
        encabezado.Font = encabezadoFont


        Dim PDF_temrinal As New Paragraph("Terminal:" & SERIAL_PROC, DIRFont) : PDF_temrinal.Alignment = 0
        Dim PDF_CONSECUTIVO As New Paragraph("Empleado. " + Chr(13) + Label_empleado.Text, DIRFont) : PDF_CONSECUTIVO.Alignment = 0
        Dim encabezado2 As New Paragraph("Fecha: " + Label_fecha.Text, DIRFont) : encabezado2.Alignment = 0
        Dim encabezado3 As New Paragraph("Inicio:" + turno_actual_inicio + " Fin:" + turno_actual_fin, DIRFont) : encabezado2.Alignment = 0



        Dim tabla_turno_data As New PdfPTable(2)
        tabla_turno_data.WidthPercentage = 100
        tabla_turno_data.DefaultCell.Padding = 0
        tabla_turno_data.DefaultCell.BorderWidth = 0
        tabla_turno_data.SpacingBefore = 0
        tabla_turno_data.HorizontalAlignment = 0
        Dim cellturno As New PdfPCell
        cellturno.BorderWidth = 0


        cellturno.Phrase = New Phrase("(+)Base: $", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(FormatNumber(CInt(TextBox_base.Text), 0), DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("(+)Ventas Efectivo: $", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(FormatNumber(CInt(LabelVentaEfectivo.Text)), DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("(+)Ventas Crédito: $", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(FormatNumber(CInt(LabelVentaCredito.Text)), DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea


        cellturno.Phrase = New Phrase("( )Propinas: $", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Label_propinas.Text, DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("( )Descuentos: $", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Label_dctos.Text, DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("===============", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase("===============", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("TOTAL VENTAS: $", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(FormatNumber(CInt(CInt(LabelVentaTotal.Text) - CInt(total_impuestos_turno)), 0), DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("()impuestos: $", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(FormatNumber(CInt(Label_impuestosTURNO.Text), 0), DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("================", DIRFont)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase("================", DIRFont)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea


        cellturno.Phrase = New Phrase("(-)Gastos: $", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Format(CInt(LabelGastos.Text), "##,##"), DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("(-)Compras de Mercancia: $", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Format(CInt(LabelComprasEfectivo.Text), "##,##"), DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("TOTAL EGRESOS: $", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Format(CInt(Label_TOTAl_EGRESOS.Text), "##,##"), DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea


        cellturno.Phrase = New Phrase("================", DIRFont)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase("================", DIRFont)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("TOTAL TURNO: $", DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(FormatNumber(CInt(Label_TOTAL_TOTAL.Text), 0), DIRFont9)
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea


        Dim encabezado7 As New Paragraph("Se Imprimió el " + DateTime.Now + Chr(13) + "Por: " + usrnom, DIRFont) : encabezado7.Alignment = 0
        Dim encabezado8 As New Paragraph("Detalle de Impuestos", iTextSharp.text.FontFactory.GetFont("Arial Black", 9, iTextSharp.text.Font.BOLD)) : encabezado8.Alignment = Element.ALIGN_CENTER
        Dim encabezado9 As New Paragraph("Ventas por Producto", iTextSharp.text.FontFactory.GetFont("Arial Black", 9, iTextSharp.text.Font.BOLD)) : encabezado9.Alignment = 0

        Dim encabezado_resumenOP As New Paragraph("Resumen de Operaciones", iTextSharp.text.FontFactory.GetFont("Arial Black", 9, iTextSharp.text.Font.BOLD)) : encabezado_resumenOP.Alignment = Element.ALIGN_CENTER

        Dim encabezado6 As New Paragraph("Relación de Operaciones", iTextSharp.text.FontFactory.GetFont("Arial Black", 9, iTextSharp.text.Font.BOLD)) : encabezado6.Alignment = Element.ALIGN_CENTER
        Dim encabezado_gastYegre As New Paragraph("Relación de Gastos y Egresos", iTextSharp.text.FontFactory.GetFont("Arial Black", 9, iTextSharp.text.Font.BOLD)) : encabezado_gastYegre.Alignment = Element.ALIGN_CENTER

        Dim glue = New Chunk(New VerticalPositionMark())

        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To MetroGrid_IMPTURNO.ColumnCount - 1
            Dim HEADERCELLFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 5, iTextSharp.text.Font.BOLD)

            Dim cell_TITLE As New PdfPCell
            cell_TITLE.Phrase = New Phrase(MetroGrid_IMPTURNO.Columns(i).HeaderText, HEADERCELLFont)
            cell_TITLE.HorizontalAlignment = Element.ALIGN_CENTER
            cell_TITLE.BackgroundColor = BaseColor.LIGHT_GRAY
            datatableIMP.AddCell(cell_TITLE)
        Next
        datatableIMP.HeaderRows = 1
        datatableIMP.DefaultCell.BorderWidth = 0
        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To MetroGrid_IMPTURNO.RowCount - 1
            For j As Integer = 0 To MetroGrid_IMPTURNO.ColumnCount - 1
                Dim cell As New PdfPCell
                cell.Phrase = New Phrase(MetroGrid_IMPTURNO(j, i).FormattedValue.ToString, rowFont)
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
                datatableIMP.AddCell(cell)
            Next
            datatableIMP.CompleteRow()
        Next


        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To DATAGrid_PDF.ColumnCount - 1
            Dim HEADERCELLFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 8, iTextSharp.text.Font.BOLD)

            Dim cell_TITLE As New PdfPCell
            cell_TITLE.Phrase = New Phrase(DATAGrid_PDF.Columns(i).HeaderText, HEADERCELLFont)
            cell_TITLE.HorizontalAlignment = Element.ALIGN_CENTER
            cell_TITLE.BackgroundColor = BaseColor.LIGHT_GRAY
            datatable.AddCell(cell_TITLE)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 0
        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To DATAGrid_PDF.RowCount - 1
            For j As Integer = 0 To DATAGrid_PDF.ColumnCount - 1
                Dim cell As New PdfPCell
                cell.Phrase = New Phrase(DATAGrid_PDF(j, i).FormattedValue.ToString, rowFont)
                If j = 0 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 1 Then cell.HorizontalAlignment = Element.ALIGN_CENTER
                If j = 2 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT : cell.BackgroundColor = BaseColor.LIGHT_GRAY
                If j = 3 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT : cell.BackgroundColor = BaseColor.LIGHT_GRAY
                If j = 4 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 5 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 6 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 7 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                cell.Border = 0
                cell.BorderWidthRight = 0.3F
                cell.BorderColorRight = BaseColor.BLACK
                datatable.AddCell(cell)
            Next
            datatable.CompleteRow()
        Next



        ' AGRUPACION
        Try
            sql = "SELECT DISTINCT(PRODUCTOS_CATEGORIAS.CATEGORIA)
FROM ventas
inner join ventas_prods 
on ventas.documento=ventas_prods.documento 
INNER JOIN PRODUCTOS ON VENTAS_PRODS.CODPROD=PRODUCTOS.COD
INNER JOIN PRODUCTOS_CATEGORIAS ON PRODUCTOS.CATEGORIA=PRODUCTOS_CATEGORIAS.CATEGORIA
where ventas.TURNO='" & turno_actual_global & "' group by ventas_prods.CodProd"
            da_AGRUPACION = New MySqlDataAdapter(sql, conex)
            dt_AGRUPACION = New DataTable
            da_AGRUPACION.Fill(dt_AGRUPACION)
            For Each row3 As DataRow In dt_AGRUPACION.Rows
                'CStr(row3.Item("CATEGORIA"))


                Try
                    sql = "SELECT CONCAT(ventas_prods.CodProd,'-',ventas_prods.Producto) AS Producto, sum(ventas_prods.cantidad) as Cant,
format(sum(ventas_prods.valortotal),0)  as Total
FROM ventas
inner join ventas_prods 
on ventas.documento=ventas_prods.documento 
INNER JOIN PRODUCTOS ON VENTAS_PRODS.CODPROD=PRODUCTOS.COD
INNER JOIN PRODUCTOS_CATEGORIAS ON PRODUCTOS.CATEGORIA=PRODUCTOS_CATEGORIAS.CATEGORIA
where ventas.TURNO='" & turno_actual_global & "' AND PRODUCTOS_CATEGORIAS.CATEGORIA='" & CStr(row3.Item("CATEGORIA")) & "' group by ventas_prods.CodProd"
                    da = New MySqlDataAdapter(sql, conex)
                    dt = New DataTable
                    da.Fill(dt)
                    Me.MetroGrid_det_ventas.DataSource = dt

                    da.Dispose()
                    dt.Dispose()
                    conex.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

                'Dim encabezado_CAT As New Paragraph(CStr(row3.Item("CATEGORIA")) + Chr(13), DIRFont) : encabezado_CAT.Alignment = 0
                'document.Add(encabezado_CAT)



                Dim cell_CAT As New PdfPCell
                cell_CAT.Phrase = New Phrase("( " + CStr(row3.Item("CATEGORIA")) + " )", iTextSharp.text.FontFactory.GetFont("Arial Black", 9, iTextSharp.text.Font.BOLD))
                cell_CAT.BorderWidth = 0
                cell_CAT.BackgroundColor = BaseColor.WHITE
                cell_CAT.HorizontalAlignment = Element.ALIGN_CENTER
                cell_CAT.Colspan = 3
                datatable_det_ventas.AddCell(cell_CAT)
                cell_CAT.Phrase = New Phrase("", DIRFont2)
                cell_CAT.BorderWidth = 0
                cell_CAT.BackgroundColor = BaseColor.WHITE
                datatable_det_ventas.AddCell(cell_CAT)
                cell_CAT.Phrase = New Phrase("", DIRFont2)
                cell_CAT.BorderWidth = 0
                cell_CAT.BackgroundColor = BaseColor.WHITE
                datatable_det_ventas.AddCell(cell_CAT)
                datatable_det_ventas.CompleteRow()

                'Se capturan los nombres de las columnas del DataGridView.
                For i As Integer = 0 To MetroGrid_det_ventas.ColumnCount - 1
                    Dim HEADERCELLFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 8, iTextSharp.text.Font.BOLD)

                    Dim cell_TITLE As New PdfPCell
                    cell_TITLE.Phrase = New Phrase(MetroGrid_det_ventas.Columns(i).HeaderText, HEADERCELLFont)
                    cell_TITLE.HorizontalAlignment = Element.ALIGN_CENTER
                    cell_TITLE.BackgroundColor = BaseColor.LIGHT_GRAY
                    datatable_det_ventas.AddCell(cell_TITLE)
                Next
                datatable_det_ventas.HeaderRows = 1
                datatable_det_ventas.DefaultCell.BorderWidth = 0
                'Se generan las columnas del DataGridView.
                For i As Integer = 0 To MetroGrid_det_ventas.RowCount - 1
                    For j As Integer = 0 To MetroGrid_det_ventas.ColumnCount - 1
                        Dim cell As New PdfPCell
                        cell.Phrase = New Phrase(MetroGrid_det_ventas(j, i).FormattedValue.ToString, rowFont)
                        If j = 0 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                        If j = 1 Then cell.HorizontalAlignment = Element.ALIGN_CENTER
                        If j = 2 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT : cell.BackgroundColor = BaseColor.LIGHT_GRAY
                        If j = 3 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                        If j = 4 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                        If j = 5 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                        If j = 6 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                        If j = 7 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                        cell.Border = 0
                        cell.BorderWidthRight = 0.0F
                        cell.BorderColorRight = BaseColor.BLACK
                        datatable_det_ventas.AddCell(cell)
                    Next
                    datatable_det_ventas.CompleteRow()
                Next



            Next
            'datatable_det_ventas.SpacingBefore = 10
            'If BunifuCheckbox_det_ventas.Checked = True Then document.Add(datatable_det_ventas)

        Catch ex As Exception
        End Try
        conex.Close()
        da_AGRUPACION.Dispose()
        dt_AGRUPACION.Dispose()
        conex.Close()



        document.Add(encabezadoLINE)
        document.Add(tablahome)
        document.Add(encabezadoLINE2)
        document.Add(encabezado)
        document.Add(PDF_temrinal)
        document.Add(PDF_CONSECUTIVO)
        document.Add(encabezado2)
        document.Add(encabezado3)
        document.Add(encabezado_resumenOP)
        tabla_turno_data.SpacingBefore = 10
        document.Add(tabla_turno_data)
        document.Add(encabezado6)
        datatable.SpacingBefore = 10
        document.Add(datatable)
        document.Add(encabezadoLINE3)
        encabezado9.Alignment = Element.ALIGN_CENTER
        document.Add(encabezado9)
        datatable_det_ventas.SpacingBefore = 10
        document.Add(datatable_det_ventas)
        document.Add(encabezadoLINE3)
        encabezado8.SpacingAfter = 4
        document.Add(encabezado8)
        document.Add(datatableIMP)
        document.Add(encabezadoLINE3)

        document.Add(encabezado7)
        document.Add(encabezadoLINE)


    End Sub

    Private Sub DataGrid_caja_DoubleClick(sender As Object, e As EventArgs) Handles DataGrid_caja.DoubleClick

    End Sub

    Private Sub DataGrid_caja_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid_caja.CellDoubleClick
        Try
            Dim row As DataGridViewRow = DataGrid_caja.CurrentRow
            ID_VENTA_VER = row.Cells("DOCUMENTO").Value

        Catch ex As Exception

        End Try






    End Sub



    Private Sub DataGrid_caja_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid_caja.CellClick
        ID_VENTA_VER = 0

        If Not IsDBNull(DataGrid_caja.Item("documento", 0).Value) Then


            Dim row As DataGridViewRow = DataGrid_caja.CurrentRow

            ID_VENTA_VER = CLng(row.Cells("documento").Value)



        End If


    End Sub

    Private Sub MetroGrid_IMPTURNO_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid_IMPTURNO.CellContentClick

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox_traslado.TextChanged
        If Me.TextBox_traslado.Text = "" Then Me.TextBox_traslado.Text = "0"
        Me.TextBox_traslado.Text = FormatNumber(Me.TextBox_traslado.Text, 0)
        Me.TextBox_traslado.Select(Me.TextBox_traslado.Text.Length, 0)
        Label_EfectivoEnCaja.Text = CInt(FormatNumber(efectivo_actual, 0) - CInt(total_Creditos)) - CInt(TextBox_traslado.Text)
    End Sub

    Private Sub BunifuCheckbox1_OnChange(sender As Object, e As EventArgs) Handles BunifuCheckbox1.OnChange
        If BunifuCheckbox1.Checked = True Then
            TextBox_traslado.Enabled = True
        Else
            TextBox_traslado.Enabled = False
            TextBox_traslado.Text = "0"
        End If
    End Sub

    Private Sub Label_total_RECAUDO_TextChanged(sender As Object, e As EventArgs) Handles LabelVentaTotal.TextChanged
        If Me.LabelVentaTotal.Text = "" Then Me.LabelVentaTotal.Text = "0"
        Me.LabelVentaTotal.Text = FormatNumber(Me.LabelVentaTotal.Text, 0)
    End Sub

    Private Sub Label_propinas_Click(sender As Object, e As EventArgs) Handles Label_propinas.Click

    End Sub

    Private Sub ComboBox_cta_abre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_cta_abre.SelectedIndexChanged

    End Sub

    Private Sub ComboBox_cta_abre_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_cta_abre.SelectionChangeCommitted
        'CONSULTAR SALDO DE CAJA PARA ABRIR TURNO  (BASE)
        'Dim caja_cod(1) As String
        'Try
        '    caja_cod = Split(ComboBox_cta_abre.SelectedValue.ToString, "|")
        '    Label18.Text = ComboBox_cta_abre.SelectedValue.ToString
        'Catch ex As Exception

        'End Try

        'SALDO_ACTUAL_CAJA = 0

        'Try
        '    sql = "Select IFNULL(SUM(DEBE)-SUM(HABER),0) As SALDO from CAJASPUC WHERE CODCUENTA='" & caja_cod(0) & "'"
        '    da = New MySqlDataAdapter(sql, conex)
        '    dt = New DataTable
        '    da.Fill(dt)
        '    For Each row As DataRow In dt.Rows
        '        SALDO_ACTUAL_CAJA = row.Item("SALDO").ToString
        '    Next
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'conex.Close()
        'da.Dispose()
        'dt.Dispose()
        'conex.Close()

        'TextBox_base.Text = FormatNumber(SALDO_ACTUAL_CAJA, 0)


    End Sub

    Private Sub ComboBox_cta_cierre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_cta_cierre.SelectedIndexChanged

    End Sub

    Private Sub Buttonsalir_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox_base_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_base.KeyDown

    End Sub

    Private Sub TextBox_traslado_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_traslado.KeyDown

    End Sub

    Private Sub TextBox_traslado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_traslado.KeyPress

    End Sub
End Class