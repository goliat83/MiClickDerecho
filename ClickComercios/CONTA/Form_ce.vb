Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.draw

Public Class Form_ce

    Dim cuenta_puc() As String
    Dim pago() As String
    Dim cod_cuenta_puc As String = ""
    Dim nom_cuenta_puc As String = ""
    Dim cli_nom, cli_tel, cli_dir, cli_doc, cli_dv, cli_mail As String
    Dim QUE_HACE_CLIENTE As String

    Dim MEDIO_PAGO_DESTINO_COD, MEDIO_PAGO_DESTINO_NOMBRE, MEDIO_PAGO_DESTINO_TIPO As String

    Dim IMP_NOMBRE, IMP_PORCENTAJE, IMP_VALOR, IMP_BASE As String
    Dim RETE_NOMBRE, RETE_PORCENTAJE, RETE_VALOR, RETE_BASE As String

    Dim dT_combo_CUENTAS_CONCEPTO As DataTable
    Dim da_combo_CUENTAS_CONCEPTO As MySqlDataAdapter

    Dim PROD_SALDO, PROD_ENTRAN, PROD_SALEN As Integer
    Dim entran, salen, saldo As Integer

    Public da_contact_fitro_ce As New MySqlDataAdapter
    Public dT_contact_fitro_ce As New DataTable

    Public da_IMP_ce As New MySqlDataAdapter
    Public dT_IMP_ce As New DataTable
    Public da_RETE_ce As New MySqlDataAdapter
    Public dT_RETE_ce As New DataTable

    Private Sub Form_ce_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_ce_Shown(sender As Object, e As EventArgs) Handles Me.Shown



        '        Try
        '            sql = "SELECT * FROM medios_pago
        'inner join cajasybancos on medios_pago.codcuenta=cajasybancos.cons
        'where medios_pago.pagar='SI' AND medios_pago.TIPO IN('CAJA','BANCO')"
        '            da_COMBO_MEDIOS_PAGO = New MySqlDataAdapter(sql, conex)
        '            dt_COMBO_MEDIOS_PAGO = New DataTable
        '            da_COMBO_MEDIOS_PAGO.Fill(dt_COMBO_MEDIOS_PAGO)
        '            Me.ComboBox_MEDIOPAGO.DataSource = dt_COMBO_MEDIOS_PAGO.DefaultView
        '            Me.ComboBox_MEDIOPAGO.DisplayMember = "MEDIOPAGO"
        '            Me.ComboBox_MEDIOPAGO.ValueMember = "cons"
        '        Catch ex As Exception
        '            MsgBox(ex.Message)
        '        End Try
        '        conex.Close()
        '        da_COMBO_MEDIOS_PAGO.Dispose()
        '        dt_COMBO_MEDIOS_PAGO.Dispose()
        '        conex.Close()

        Try
            sql = "SELECT CONS, nombre, cuentapuc FROM CAJAsYBANCOS where tipo in('CAJA','BANCO')"
            da_COMBO_cuentas_parapagos = New MySqlDataAdapter(sql, conex)
            dt_COMBO_cuentas_parapagos = New DataTable
            da_COMBO_cuentas_parapagos.Fill(dt_COMBO_cuentas_parapagos)
            Me.ComboBox_cta_caja_banco.DataSource = dt_COMBO_cuentas_parapagos.DefaultView
            Me.ComboBox_cta_caja_banco.DisplayMember = "nombre"
            Me.ComboBox_cta_caja_banco.ValueMember = "CONS"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_COMBO_cuentas_parapagos.Dispose()
        dt_COMBO_cuentas_parapagos.Dispose()


        'LOAD CUENTAPUC  CONCEPTO
        Try
            sql = "SELECT cons, documento, CUENTA1 from data_docs where estado='SI' and CODIGO='CE' AND padre='NO'"

            da_combo_CUENTAS_CONCEPTO = New MySqlDataAdapter(sql, conex)
            dT_combo_CUENTAS_CONCEPTO = New DataTable
            da_combo_CUENTAS_CONCEPTO.Fill(dT_combo_CUENTAS_CONCEPTO)
            Me.ComboBox_tipo_egreso.DataSource = dT_combo_CUENTAS_CONCEPTO.DefaultView
            Me.ComboBox_tipo_egreso.DisplayMember = "DOCUMENTO"
            Me.ComboBox_tipo_egreso.ValueMember = "CONS"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_combo_CUENTAS_CONCEPTO.Dispose()
        dT_combo_CUENTAS_CONCEPTO.Dispose()
        conex.Close()


        ComboBox_tipo_egreso.SelectedItem = Nothing

        Me.Label14.Text = usrnom


        'impuestos
        Try
            sql = "SELECT cons, TIPOIMP, porcentaje, nombre FROM impuestos where tipoimp='PORCENTAJE'"
            da_IMP_ce = New MySqlDataAdapter(sql, conex)
            dT_IMP_ce = New DataTable
            da_IMP_ce.Fill(dT_IMP_ce)

            ComboBox_impuestos.DataSource = dT_IMP_ce.DefaultView
            ComboBox_impuestos.DisplayMember = "nombre"
            ComboBox_impuestos.ValueMember = "CONS"
        Catch ex As Exception
            Cursor.Current = Cursors.Default

            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_IMP_ce.Dispose()
        dT_IMP_ce.Dispose()
        conex.Close()
        ComboBox_impuestos.SelectedItem = Nothing

        'retenciones
        Try
            sql = "SELECT cons, TIPOIMP, porcentaje, nombre FROM impuestos where tipoimp='RETENCION'"
            da_RETE_ce = New MySqlDataAdapter(sql, conex)
            dT_RETE_ce = New DataTable
            da_RETE_ce.Fill(dT_RETE_ce)

            ComboBox_RETENCIONES.DataSource = dT_RETE_ce.DefaultView
            ComboBox_RETENCIONES.DisplayMember = "nombre"
            ComboBox_RETENCIONES.ValueMember = "CONS"
        Catch ex As Exception
            Cursor.Current = Cursors.Default

            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_RETE_ce.Dispose()
        dT_RETE_ce.Dispose()
        conex.Close()
        ComboBox_RETENCIONES.SelectedItem = Nothing


        If turno_actual_global = "" Then
            turno_actualfecha = DateTime.Now.ToShortDateString
            Label_fecha.Text = turno_actualfecha
        End If



        Timer_MEDIO_PAGO.Enabled = True
        Panel_dock.BringToFront()

        'si esta viendo
        If ID_gasto_VER <> "" Then
            Timer_VER.Enabled = True
            Exit Sub
        End If



        ' si esta creando
        Btn_nuevo_mov_Click(Nothing, Nothing)
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs)
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""
    End Sub
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button_guardar_Click(sender As Object, e As EventArgs) Handles Button_guardar.Click

        If ComboBox_tipo_egreso.Text = "Abono a Cuenta Por Pagar" And TextBox_referencia.Text = "" Then
            MsgBox("Seleccione un cuenta de cobro.", vbInformation)
            Exit Sub
        End If

        If ComboBox_MEDIOPAGO.Text = Nothing Then MsgBox("Seleccione un medio de pago.", vbInformation) : Exit Sub

        If TXT_NOM_CLIENTE.Text = "" Then MsgBox("Digite el nombre del beneficiario.", vbInformation) : Exit Sub
        If TXT_DOC_CLIENTE.Text = "" Then MsgBox("Digite el documento del beneficiario.", vbInformation) : Exit Sub
        If TextBox_referencia.Text = "" Then MsgBox("Digite una referencia del gasto.", vbInformation) : Exit Sub

        If TextBox_DESCRIPCION.Text = "" Then MsgBox("Digite el concepto o justificación del gasto.", vbInformation) : Exit Sub
        If TextBox_valorgasto.Text = "0" Or TextBox_valorgasto.Text = "" Then MsgBox("Digite el valor.", vbInformation) : Exit Sub

        Dim RTA = MsgBox("Seguro desea registrar el egreso.? " & Chr(13) &
                         "=======================================" & Chr(13) &
                         ComboBox_tipo_egreso.Text & Chr(13) &
                         TXT_NOM_CLIENTE.Text & Chr(13) &
                         TextBox_DESCRIPCION.Text & Chr(13) &
                         "$ " & TextBox_valorgasto.Text, MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If RTA = "6" Then

            Me.Button_guardar.Visible = False
            Me.Button4.Visible = False
            Me.Button_anular.Visible = False

            Me.Button3.Visible = True
            Me.Button4.Visible = True
            Me.Button_anular.Visible = True

            Me.TextBox_valorgasto.Enabled = False
            Me.TextBox_referencia.Enabled = False
            Me.TextBox_DESCRIPCION.Enabled = False
            Me.TXT_DOC_CLIENTE.Enabled = False
            Me.TXT_DIR_CLIENTE.Enabled = False
            Me.TXT_NOM_CLIENTE.Enabled = False
            Me.TXT_TELS_CLIENTE.Enabled = False


            'MODIFICAR
            If Label_estado_gasto.Text = "DESCARGADO" Then

                'UPDATE CE
                sql = "UPDATE recibos_egresos SET DocCliente='" & CStr(TXT_DOC_CLIENTE.Text) & "', ClienteNom='" & TXT_NOM_CLIENTE.Text & "', Clientetel='" & TXT_TELS_CLIENTE.Text & "', clientedir='" & TXT_DIR_CLIENTE.Text & "', descripcion='" & TextBox_DESCRIPCION.Text & "', referencia='" & TextBox_referencia.Text & "', concepto='" & CStr(ComboBox_tipo_egreso.Text) & "', cuenta='" & cod_cuenta_puc & "|" & nom_cuenta_puc & "' WHERE DOCUMENTO='" & Label_consecutivo.Text & "'"
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



                Exit Sub
            End If

            ' fin modificar ================================================================================



            If turno_actualfecha = "" Then turno_actualfecha = DateTime.Now.ToShortDateString
            'GUARDAR
            sql = "INSERT INTO recibos_egresos(documento, fecha, DocCliente, ClienteNom, Clientetel, clientedir, descripcion, referencia, valor, empleadocod, empleado, turno, Estado,concepto,cuenta,mediodepago,CUENTAPAGO,imp,impvr,rete,retevr) 
VALUES(" & CLng(consecutivo) & ",'" & turno_actualfecha & "','" & CStr(TXT_DOC_CLIENTE.Text) & "','" & TXT_NOM_CLIENTE.Text & "','" & TXT_TELS_CLIENTE.Text & "','" & TXT_DIR_CLIENTE.Text & "','" & TextBox_DESCRIPCION.Text & "','" & TextBox_referencia.Text & "'," & CInt(TextBox_valor.Text) & "," & CStr(usrdoc) & ",'" & usrnom & "','" & turno_actual_global & "','DESCARGADO','" & CStr(ComboBox_tipo_egreso.Text) & "','" & CStr(cod_cuenta_puc & "|" & nom_cuenta_puc) & "','" & CStr(ComboBox_MEDIOPAGO.Text) & "','" & CStr(ComboBox_cta_caja_banco.SelectedValue) & "|" & CStr(ComboBox_cta_caja_banco.Text) & "','" & CStr(ComboBox_impuestos.Text) & "','" & CStr(TextBox_impuestos.Text) & "','" & CStr(ComboBox_RETENCIONES.Text) & "','" & CStr(TextBox_retenciones.Text) & "')"
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


            ' actualizo cuenta de cobro
            If ComboBox_cxp.Text <> "" Then
                sql = "UPDATE carteracredito SET saldo='" & CInt(Label_SALDO_actual.Text) - CInt(TextBox_valor.Text) & "' 
where tipo='CREDITO' and CONSECUTIVO='" & ComboBox_cxp.SelectedValue & "'"
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

                If (CInt(Label_SALDO_actual.Text) - CInt(TextBox_valor.Text)) = 0 Then
                    sql = "UPDATE carteracredito SET estado='PAGADA' 
where tipo='CREDITO' and CONSECUTIVO='" & ComboBox_cxp.SelectedValue & "'"
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

            End If



            'GUARDA EN CAJA
            'guardar mov
            If PERMISO__general(6) = "SI" Then

                sql = "INSERT INTO CAJA (turno, fecha, documento, tipoDocumento, subtotal, descuento, total, MEDIODEPAGO, EmpleadoDoc, empleado, estado)" &
                      "VALUES ('" & turno_actual_global & "','" & turno_actualfecha & "'," & consecutivo & ",'COMPROBANTE DE EGRESO'," & CInt(Me.TextBox_valorgasto.Text) & ",0," & CInt(Me.TextBox_valorgasto.Text) & ",'" & ComboBox_MEDIOPAGO.Text & "'," & CInt(usrdoc) & ",'" & usrnom & "','DESCARGADO')"
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



            'contabilizar =======================================================================================
            saldo = 0

            PROD_SALEN = CInt(TextBox_valorgasto.Text)  ' TOMO LA CANTIDAD DEL GRID Q ESTA RECORRIENDO
            PROD_SALDO = saldo  ' IGUALDO SALDO PROD CON EL SALDO CALCULADO EN BODEGA PRICIPAL
            PROD_SALDO = CInt(PROD_SALDO) - CInt(PROD_SALEN) ' PROD_ENTRAN   '  ACUMULO
            PROD_ENTRAN = 0 ' POR QUE QUE ES UNA venta
            'REGISTRO EN PUC




            sql = "INSERT INTO cajaspuc(Codcuenta, cuenta, TERCERO, Fecha, Documento, TipoDoc, Rol, SaldoAnt, debe, haber, Saldo, detalle, Estado, annoactual)" &
               "VALUES ('" & ComboBox_cta_caja_banco.SelectedValue & "','" & ComboBox_cta_caja_banco.Text.ToString & "','" & CStr(TXT_DOC_CLIENTE.Text & "|" & TXT_NOM_CLIENTE.Text) & "','" & turno_actualfecha & "','" & consecutivo & "','COMPROBANTE DE EGRESO','SALEN'," & saldo & "," & PROD_ENTRAN & "," & PROD_SALEN & "," & PROD_SALDO & ",'" & CStr(ComboBox_tipo_egreso.Text & " | " & TextBox_DESCRIPCION.Text.ToString) & "','DESCARGADO','" & comex_annoactual & "')"
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



            Me.Panel3.Enabled = False
            Me.Panel_cliente.Enabled = False
            Me.Panel4.Enabled = False
            Me.Cursor = Cursors.Default

            MsgBox("Se Registró el Comprobante de Egreso.", vbInformation)
            'Button_salir_Click(Nothing, Nothing)
        End If

    End Sub
    Public Sub ExportarDatosPDF_POS(ByVal document As Document)


        Dim fontLINE = iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLD)
        Dim encabezadoFont = iTextSharp.text.FontFactory.GetFont("Courier New", 10, iTextSharp.text.Font.BOLD)
        Dim contentFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 10, iTextSharp.text.Font.BOLD)
        Dim DIRFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 6, iTextSharp.text.Font.BOLD)
        Dim rowFont = iTextSharp.text.FontFactory.GetFont("Times New Roman", 7, iTextSharp.text.Font.NORMAL)
        Dim DIRFont2 = iTextSharp.text.FontFactory.GetFont("Arial Black", 7.5, iTextSharp.text.Font.BOLD)
        Dim DIRFont9 = iTextSharp.text.FontFactory.GetFont("Arial Black", 9.5D, iTextSharp.text.Font.NORMAL)
        Dim FIRMAFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 5, iTextSharp.text.Font.BOLD)
        Dim totalFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 8, iTextSharp.text.Font.BOLD)
        Dim totaltotalFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 9, iTextSharp.text.Font.BOLDITALIC)
        Dim CLIENTEFONT = iTextSharp.text.FontFactory.GetFont("Arial Black", 7, iTextSharp.text.Font.BOLDITALIC)

        If File.Exists(comex_logo) Then
            Dim imagelogogopdf As iTextSharp.text.Image 'Declaracion de una imagen

            imagelogogopdf = iTextSharp.text.Image.GetInstance(comex_logo) 'Dirreccion a la imagen que se hace referencia
            imagelogogopdf.Alignment = Element.ALIGN_CENTER
            imagelogogopdf.SetAbsolutePosition(20, 275) 'Posicion en el eje cartesiano
            imagelogogopdf.ScaleAbsoluteWidth(160) 'Ancho de la imagen
            imagelogogopdf.ScaleAbsoluteHeight(60) 'Altura de la imagen
            document.Add(imagelogogopdf) ' Agrega la imagen al documento
        End If


        Dim encabezadoLINE As New Paragraph("|======================================|", fontLINE)

        encabezadoLINE.Alignment = 0
        encabezadoLINE.Font = fontLINE
        If comex_logo <> "" Then encabezadoLINE.SpacingBefore = 60
        Dim encabezadoLINE2 As New Paragraph("=======================================", fontLINE)
        Dim encabezadoLINE3 As New Paragraph("_________________________________________", fontLINE)

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


        cellhome.Phrase = New Phrase(comex_nombrecomercial, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10, iTextSharp.text.Font.NORMAL))
        cellhome.HorizontalAlignment = Element.ALIGN_CENTER
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase(comex_nombrepropietario, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8, iTextSharp.text.Font.NORMAL))
        cellhome.HorizontalAlignment = Element.ALIGN_CENTER
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase("NIT:" & comex_nit & "-" & comex_DV & " " & comex_regimen, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8, iTextSharp.text.Font.NORMAL))
        cellhome.HorizontalAlignment = Element.ALIGN_CENTER
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase("Tels:" & comex_tels & " - " & comex_cels & " " & comex_dircomercio & " " & comex_ciudad, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8, iTextSharp.text.Font.NORMAL))
        cellhome.HorizontalAlignment = Element.ALIGN_CENTER
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        If comex_sitioweb <> "" And comex_email <> "" Then
            cellhome.Phrase = New Phrase(comex_sitioweb & " " & comex_email, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 7.5D, iTextSharp.text.Font.NORMAL))
            cellhome.HorizontalAlignment = Element.ALIGN_CENTER
            tablahome.AddCell(cellhome)
            tablahome.CompleteRow()
        End If




        Dim tabla_turno_data As New PdfPTable(2)
        Dim anchos() As Single = {60, 40}
        tabla_turno_data.SetWidths(anchos)

        tabla_turno_data.WidthPercentage = 100
        tabla_turno_data.DefaultCell.Padding = 0
        tabla_turno_data.DefaultCell.BorderWidth = 0
        tabla_turno_data.SpacingBefore = 0
        tabla_turno_data.HorizontalAlignment = 0
        Dim cellturno As New PdfPCell
        cellturno.BorderWidth = 0


        If Label_estado_gasto.Text = "ANULADO" Then
            cellturno.Phrase = New Phrase("<<< A N U L A D O >>>", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8, iTextSharp.text.Font.NORMAL))
            cellturno.HorizontalAlignment = Element.ALIGN_CENTER
            cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
            cellturno.Colspan = 2
            tabla_turno_data.AddCell(cellturno) 'primera col
            tabla_turno_data.CompleteRow() ' agrega linea

        End If

        cellturno.Phrase = New Phrase("Comprobante de Egreso", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_LEFT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase(Label_consecutivo.Text, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea

        cellturno.Phrase = New Phrase("Fecha:" & Label_fecha.Text, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 7, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_LEFT
        cellturno.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_turno_data.AddCell(cellturno) 'primera col

        cellturno.Phrase = New Phrase("", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 7, iTextSharp.text.Font.NORMAL))
        cellturno.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_turno_data.AddCell(cellturno) ' segunda col
        tabla_turno_data.CompleteRow() ' agrega linea


        Dim encabezado6 As New Paragraph("Tercero:" & TXT_NOM_CLIENTE.Text, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 7.5D, iTextSharp.text.Font.NORMAL)) : encabezado6.Alignment = Element.ALIGN_LEFT
        Dim encabezado_resumenOP As New Paragraph("Doc/NIT:" & TXT_DOC_CLIENTE.Text, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 7.5D, iTextSharp.text.Font.NORMAL)) : encabezado_resumenOP.Alignment = Element.ALIGN_LEFT



        Dim encabezado9 As New Paragraph("CONCEPTO", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 6D, iTextSharp.text.Font.BOLD)) : encabezado9.Alignment = Element.ALIGN_CENTER
        Dim encabezado91 As New Paragraph(ComboBox_tipo_egreso.Text, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 6D, iTextSharp.text.Font.BOLD)) : encabezado91.Alignment = Element.ALIGN_LEFT

        Dim encabezado_REF As New Paragraph("REFERENCIA: " & TextBox_referencia.Text, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 6D, iTextSharp.text.Font.BOLD)) : encabezado9.Alignment = Element.ALIGN_LEFT
        Dim encabezado_OBS As New Paragraph("OBSERVACION: " & Chr(13) & TextBox_DESCRIPCION.Text, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 6D, iTextSharp.text.Font.BOLD)) : encabezado91.Alignment = Element.ALIGN_LEFT



        Dim tabla_total As New PdfPTable(2)
        Dim anchostotal() As Single = {65, 35}
        tabla_total.SetWidths(anchostotal)

        tabla_total.WidthPercentage = 100
        tabla_total.DefaultCell.Padding = 0
        tabla_total.DefaultCell.BorderWidth = 0
        tabla_total.SpacingBefore = 0
        tabla_total.HorizontalAlignment = 0
        Dim celltotal As New PdfPCell
        celltotal.BorderWidth = 0



        celltotal.Phrase = New Phrase("VALOR>>>> $", FontFactory.GetFont(FontFactory.COURIER_BOLD, 10, iTextSharp.text.Font.BOLD))
        celltotal.HorizontalAlignment = Element.ALIGN_LEFT
        celltotal.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla_total.AddCell(celltotal) 'primera col

        celltotal.Phrase = New Phrase(FormatNumber(TextBox_valorgasto.Text, 0), FontFactory.GetFont(FontFactory.COURIER_BOLD, 10, iTextSharp.text.Font.NORMAL))
        celltotal.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_total.AddCell(celltotal) ' segunda col
        tabla_total.CompleteRow() ' agrega linea





        Dim encabezado_mesero As New Paragraph("Generado por:", FontFactory.GetFont(FontFactory.COURIER_BOLD, 6D, iTextSharp.text.Font.NORMAL)) : encabezado_mesero.Alignment = Element.ALIGN_LEFT


        Dim encabezado7 As New Paragraph(Label14.Text, FontFactory.GetFont(FontFactory.COURIER_BOLD, 5D, iTextSharp.text.Font.NORMAL)) : encabezado7.Alignment = 0
        Dim encabezado_publicidad As New Paragraph("MiCliCkDerecho.com Software/POS.", FontFactory.GetFont(FontFactory.COURIER_BOLD, 5D, iTextSharp.text.Font.NORMAL)) : encabezado7.Alignment = 0



        document.Add(encabezadoLINE)
        document.Add(tablahome)
        encabezadoLINE2.SpacingBefore = -3
        document.Add(encabezadoLINE2)

        tabla_turno_data.SpacingBefore = 0
        document.Add(tabla_turno_data)

        document.Add(encabezado6)
        document.Add(encabezado_resumenOP)
        encabezado_resumenOP.SpacingBefore = -3

        document.Add(encabezado9)
        document.Add(encabezado91)
        document.Add(encabezado_REF)
        document.Add(encabezado_OBS)


        encabezadoLINE3.SpacingBefore = -10
        document.Add(encabezadoLINE3)
        document.Add(encabezadoLINE2)

        document.Add(tabla_total)

        document.Add(encabezadoLINE2)

        document.Add(encabezado_mesero)

        document.Add(encabezadoLINE3)

        document.Add(encabezado7)
        document.Add(encabezado_publicidad)


        document.Add(encabezadoLINE2)


    End Sub
    Private Sub Label15_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroText_adjunto_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroText_adjunto_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.KeyChar = ""
    End Sub

    Private Sub Button_BORRARCLIENTE_Click(sender As Object, e As EventArgs)
        Me.TXT_DOC_CLIENTE.Text = ""
        Me.TXT_NOM_CLIENTE.Text = ""
        TXT_DIR_CLIENTE.Text = ""
        TXT_TELS_CLIENTE.Text = ""

    End Sub

    Private Sub Timer_CLIENTE_Tick(sender As Object, e As EventArgs) Handles Timer_CLIENTE.Tick

        Timer_CLIENTE.Enabled = False


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

        COMBO_NOM_CLIENTE_FILTRO.SelectedItem = Nothing

        ComboBox1_SelectionChangeCommitted(Nothing, Nothing)

    End Sub



    Private Sub ComboBox_MEDIO_PAGO_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox_nombre_prov_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Try
            sql = "SELECT concat(concepto,' ',descripcion,' Ref:',referencia) as Concepto FROM recibos_egresos WHERE CONS = " & CInt(Label_consecutivo.Text) & ""
            da = New MySqlDataAdapter(sql, conex)
            dt_imprimir_prods = New DataTable
            da.Fill(dt_imprimir_prods)
            Me.METROGRID_PDF.DataSource = dt_imprimir_prods
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt_imprimir_prods.Dispose()


        Try

            'Intentar generar el documento.
            Dim doc As New Document(PageSize.A4, 20, 20, 20, 20)
            If Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) & "\MiClickDerecho Docs\") = False Then
                Try
                    My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) & "\MiClickDerecho Docs\")
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
            'Path que guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\Comprobante de Egreso" & Label_consecutivo.Text & ".pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)

            PdfWriter.GetInstance(doc, file)

            doc.Open()

            ExportarDatosPDF(doc)
            'ExportarDatosPDF_POS(doc)

            doc.Close()

            Process.Start("C:\Program Files\Tracker Software\PDF Viewer\pdfxcview.exe", """" & Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\Comprobante de Egreso " & Label_consecutivo.Text & ".pdf" & """")
        Catch ex As Exception
            'Si el intento es fallido, mostrar MsgBox.
            MessageBox.Show("No se puede generar el documento PDF, Cierre los documentos PDF generados anteriormente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Public Sub ExportarDatosPDF(ByVal document As Document)
        Dim CANT_FILAS As Integer = 0
        'Se crea un objeto PDFTable con el numero de columnas del DataGridView.
        Dim datatable As New PdfPTable(METROGRID_PDF.ColumnCount)
        'Se asignan algunas propiedades para el diseño del PDF.
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(METROGRID_PDF)

        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER


        Dim fontLINE = iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLD)


        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER

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
        cellhome.Phrase = New Phrase("COMPROBANTE DE EGRESO", FontFactory.GetFont(FontFactory.COURIER, 11, iTextSharp.text.Font.BOLD))
        cellhome.HorizontalAlignment = Element.ALIGN_RIGHT
        cellhome.BackgroundColor = BaseColor.WHITE
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase("Cliente: " + TXT_NOM_CLIENTE.Text, FontFactory.GetFont(FontFactory.COURIER, 10, iTextSharp.text.Font.BOLD))
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        cellhome.BackgroundColor = BaseColor.LIGHT_GRAY
        tablahome.AddCell(cellhome)
        cellhome.Phrase = New Phrase("No. " & Label_consecutivo.Text + "   ", FontFactory.GetFont(FontFactory.COURIER, 11, iTextSharp.text.Font.BOLD))
        cellhome.HorizontalAlignment = Element.ALIGN_RIGHT
        cellhome.BackgroundColor = BaseColor.WHITE
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase("DOC/NIT: " + TXT_DOC_CLIENTE.Text, FontFactory.GetFont(FontFactory.COURIER, 7, iTextSharp.text.Font.BOLD))
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        cellhome.BackgroundColor = BaseColor.LIGHT_GRAY
        tablahome.AddCell(cellhome)
        cellhome.Phrase = New Phrase("Fecha: " + Label_fecha.Text + "   ", FontFactory.GetFont(FontFactory.COURIER, 10, iTextSharp.text.Font.BOLD))
        cellhome.HorizontalAlignment = Element.ALIGN_RIGHT
        cellhome.BackgroundColor = BaseColor.WHITE
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase("Dirección:  " + TXT_DIR_CLIENTE.Text.ToString, FontFactory.GetFont(FontFactory.COURIER, 7, iTextSharp.text.Font.BOLD))
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        cellhome.BackgroundColor = BaseColor.LIGHT_GRAY
        tablahome.AddCell(cellhome)
        cellhome.Phrase = New Phrase("Medio de Pago: ", FontFactory.GetFont(FontFactory.COURIER, 7, iTextSharp.text.Font.BOLD))
        cellhome.HorizontalAlignment = Element.ALIGN_RIGHT
        cellhome.BackgroundColor = BaseColor.WHITE
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()

        cellhome.Phrase = New Phrase("Teléfono: " + TXT_TELS_CLIENTE.Text, FontFactory.GetFont(FontFactory.COURIER, 7, iTextSharp.text.Font.BOLD))
        cellhome.HorizontalAlignment = Element.ALIGN_LEFT
        cellhome.BackgroundColor = BaseColor.LIGHT_GRAY
        tablahome.AddCell(cellhome)
        cellhome.Phrase = New Phrase(ComboBox_MEDIOPAGO.Text, FontFactory.GetFont(FontFactory.COURIER, 7, iTextSharp.text.Font.BOLD))
        cellhome.HorizontalAlignment = Element.ALIGN_RIGHT
        cellhome.BackgroundColor = BaseColor.WHITE
        tablahome.AddCell(cellhome)
        tablahome.CompleteRow()



        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To METROGRID_PDF.ColumnCount - 1
            Dim HEADERCELLFont = iTextSharp.text.FontFactory.GetFont("Arial Black", 12, iTextSharp.text.Font.BOLD)

            Dim cell_TITLE As New PdfPCell
            cell_TITLE.Phrase = New Phrase(METROGRID_PDF.Columns(i).HeaderText, HEADERCELLFont)
            cell_TITLE.HorizontalAlignment = Element.ALIGN_CENTER
            cell_TITLE.BackgroundColor = BaseColor.LIGHT_GRAY
            datatable.AddCell(cell_TITLE)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 0
        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To METROGRID_PDF.RowCount - 1
            For j As Integer = 0 To METROGRID_PDF.ColumnCount - 1
                Dim cell As New PdfPCell

                cell.Phrase = New Phrase(METROGRID_PDF(j, i).FormattedValue.ToString, iTextSharp.text.FontFactory.GetFont("Arial Black", 12, iTextSharp.text.Font.BOLD))

                If j = 0 Then cell.HorizontalAlignment = Element.ALIGN_LEFT
                If j = 1 Then cell.HorizontalAlignment = Element.ALIGN_CENTER
                If j = 2 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 3 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 4 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 5 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 6 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT
                If j = 7 Then cell.HorizontalAlignment = Element.ALIGN_RIGHT


                cell.Border = 0
                'cell.BorderWidthRight = 0.3F
                cell.BorderColorRight = BaseColor.BLACK
                datatable.AddCell(cell)
            Next
            datatable.CompleteRow()
        Next


        '  CONTAR LAS FILAS DE LA GRILLA GENERADA, 
        ' ESTABLECER CUANTAS GRILLAS SE NECESITAN PARA LLEGAR A MEDIA CARTA Y CARTA,
        ' AGRAGAR LLASNECESARIAS PARA LLENAR EL ESPACION Q FALTA
        CANT_FILAS = Me.METROGRID_PDF.RowCount

        If CANT_FILAS <= (8 - CANT_FILAS) Then
            For i As Integer = 0 To (8 - CANT_FILAS)
                For j As Integer = 0 To METROGRID_PDF.ColumnCount - 1

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
                    cell.Border = 0
                    'cell.BorderWidthRight = 0.3F
                    cell.BorderColorRight = BaseColor.BLACK
                    datatable.AddCell(cell)
                Next
                datatable.CompleteRow()
            Next
        End If


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
        cell_PIE.Phrase = New Phrase("SubTotal", totalFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase(TextBox_subtotal.Text & " ", totalFont)
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
        cell_PIE.Phrase = New Phrase("Retención:", totalFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase(FormatNumber(CDec(TextBox_retenciones.Text), 2) & " ", totalFont)
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
        cell_PIE.Phrase = New Phrase("IVA: ", totalFont)
        cell_PIE.HorizontalAlignment = Element.ALIGN_RIGHT
        tabla_PIE.AddCell(cell_PIE)
        cell_PIE.Phrase = New Phrase(FormatNumber(CDec(TextBox_impuestos.Text), 2) & " ", totalFont)
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
        cell_PIE.Phrase = New Phrase(FormatNumber(TextBox_valorgasto.Text, 2), totaltotalFont)
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

    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        'funcion para obtener el tamaño de la columnas del datagridview
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function

    Private Sub ComboBox_nombre_prov_SelectedValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox_DOC_CLIENTE_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroButton_adjuntar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer_VER_Tick(sender As Object, e As EventArgs) Handles Timer_VER.Tick
        Timer_VER.Enabled = False


        Try
            sql = "SELECT * FROM recibos_EGRESOS where DOCUMENTO=" & ID_gasto_VER & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                Label_consecutivo.Text = row.Item("DOCUMENTO")
                Label_fecha.Text = row.Item("fecha")
                Label_estado_gasto.Text = row.Item("estado")
                TXT_DOC_CLIENTE.Text = row.Item("doccliente")
                TextBox_DESCRIPCION.Text = row.Item("descripcion")
                TextBox_referencia.Text = row.Item("referencia")
                TextBox_valor.Text = row.Item("valor")
                Label14.Text = row.Item("empleado") & "(" & row.Item("empleadocod") & ")"
                ComboBox_tipo_egreso.Text = row.Item("concepto")
                ComboBox_MEDIOPAGO.Text = row.Item("mediodepago")


                Dim cuenta_pAGO() As String = Split(row.Item("CUENTAPAGO"), "|")
                ComboBox_cta_caja_banco.Text = cuenta_pAGO(1)

                IMP_NOMBRE = row.Item("imp")
                IMP_VALOR = row.Item("impvr")

                RETE_NOMBRE = row.Item("rete")
                RETE_VALOR = row.Item("retevr")

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()

        Me.Panel3.Enabled = False
        Me.Panel_cliente.Enabled = False
        Me.Panel4.Enabled = False


        Me.FlowLayoutPanel1.Visible = True
        Me.FlowLayoutPanel1.Enabled = True
        Button_guardar.Visible = False
        Btn_nuevo_mov.Visible = False
        Button3.Visible = True
        Button4.Visible = True
        Button_anular.Visible = True

        Button_gastos.Visible = False
        Button4.Visible = True
        cli_doc = TXT_DOC_CLIENTE.Text
        COMBO_NOM_CLIENTE_FILTRO.SelectedValue = cli_doc
        Panel_dock.Visible = False
        Button_modificar.Visible = True

        ComboBox_impuestos.Text = IMP_NOMBRE
        ComboBox_RETENCIONES.Text = RETE_NOMBRE


        TextBox_ret_a_aplicar.Text = RETE_VALOR
        TextBox_imp_a_aplicar.Text = IMP_VALOR

        TextBox_retenciones.Text = RETE_VALOR
        TextBox_impuestos.Text = IMP_VALOR

        totalizar()


        Button_anular.Visible = True
        Timer_CLIENTE_Tick(Nothing, Nothing)

        If Label_estado_gasto.Text = "ANULADO" Then
            Button_anular.Visible = False

        End If

        ID_gasto_VER = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Form_RECIBO_CAJA.Show()
        'Form_RECIBO_CAJA.Visible = False
        Try
            'Intentar generar el documento.
            Dim pgSize = New iTextSharp.text.Rectangle(201, 350)

            Dim doc As New Document(pgSize, 8, 8, 10, 10)

            'Path que guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\Comprobante de Egreso " & Label_consecutivo.Text & ".pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)

            PdfWriter.GetInstance(doc, file)
            doc.Open()

            ExportarDatosPDF_POS(doc)
            doc.Close()
            'Process.Start(filename)
        Catch ex As Exception
            'Si el intento es fallido, mostrar MsgBox.
            Me.Cursor = Cursors.Default
            MessageBox.Show("error al imprimir recibo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        Dim instance As New Printing.PrinterSettings
        Dim impresosaPredt As String = instance.PrinterName

        Process.Start("C:\Program Files\Tracker Software\PDF Viewer\pdfxcview.exe", " /print:printer=""" & impresosaPredt & """ """ & Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\MiClickDerecho Docs\Comprobante de Egreso " & Label_consecutivo.Text & ".pdf" & """")


    End Sub

    Private Sub Timer_cuentapuc_concepto_Tick(sender As Object, e As EventArgs) Handles Timer_cuentapuc_concepto.Tick
        Timer_cuentapuc_concepto.Enabled = False
        If Label_estado_gasto.Text = "DESCARGADO" Then Exit Sub


        If ComboBox_tipo_egreso.Text.Contains("|") = True Then
            cuenta_puc = Split(ComboBox_tipo_egreso.Text, "|")
            Exit Sub
        End If

        Try
            sql = "SELECT * FROM data_docs WHERE CONS='" & ComboBox_tipo_egreso.SelectedValue & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                cuenta_puc = Split(row.Item("CUENTA1"), "|")

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()
        If ComboBox_tipo_egreso.SelectedValue = Nothing Then Exit Sub
        cod_cuenta_puc = cuenta_puc(0)
        nom_cuenta_puc = cuenta_puc(1)

        TextBox_referencia.Text = ""

        If ComboBox_tipo_egreso.Text = "Cuenta Por Pagar" Then
            If TXT_DOC_CLIENTE.Text = "" Then
                MsgBox("Seleccione el beneficiario.")
                Exit Sub
            End If

            TextBox_referencia.Text = ""

            TextBox_referencia.Enabled = True
            ComboBox_cxp.Visible = True
            ComboBox_cxp.Enabled = True

            Panel_facturavr.Visible = True
            Label5.Visible = True
            Try
                sql = "SELECT consecutivo, CONCAT(CONSECUTIVO,' de ',FECHA, ' | $ ', valor) AS FACTURA, saldo FROM carteracredito WHERE tipo='CREDITO' AND CLIENTEDOC='" & TXT_DOC_CLIENTE.Text & "' AND ESTADO='PENDIENTE'"
                da_CXC = New MySqlDataAdapter(sql, conex)
                dt_CXC = New DataTable
                da_CXC.Fill(dt_CXC)
                Me.ComboBox_cxp.DataSource = dt_CXC.DefaultView
                Me.ComboBox_cxp.DisplayMember = "FACTURA"
                Me.ComboBox_cxp.ValueMember = "CONSECUTIVO"
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da_CXC.Dispose()
            dt_CXC.Dispose()
            conex.Close()
            TextBox_referencia.Enabled = False   ' BLOQUEO REFERENCIA

        Else
            ComboBox_cxp.Enabled = False
            TextBox_referencia.Enabled = True
            Panel_facturavr.Visible = False
            TextBox_referencia.Enabled = True  'DEJO ACTIVAOD REFERENCIA 

        End If
        ComboBox_cxp.SelectedItem = Nothing
        Label_SALDO_actual.Text = 0
    End Sub



    Private Sub Btn_nuevo_mov_Click(sender As Object, e As EventArgs) Handles Btn_nuevo_mov.Click
        Me.Button3.Visible = False
        Label_consecutivo.Text = ""
        'CONSECUTIVO
        consecutivo = 0
        cmd.Connection = conex
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select max(documento) + 1 from recibos_egresos"
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

        Me.Label_consecutivo.Text = consecutivo
        Me.Label_fecha.Text = DateTime.Now.ToShortDateString
        Me.Label14.Text = usrnom

        FlowLayoutPanel1.Visible = True
        Panel_dock.Visible = False


        Me.Panel_cliente.Enabled = True

        Me.Panel3.Enabled = True
        Me.Panel4.Enabled = True
        Button4.Visible = False

        COMBO_NOM_CLIENTE_FILTRO.Enabled = True
    End Sub

    Private Sub COMBO_DOC_CLIENTE_FILTRO_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_MEDIOPAGO.SelectedIndexChanged

    End Sub

    Private Sub Timer_factura_info_Tick(sender As Object, e As EventArgs) Handles Timer_factura_info.Tick
        Timer_factura_info.Enabled = False


        Dim VALOR_CUENTA As String = "0"
        Try
            sql = "SELECT * FROM carteracredito where tipo='CREDITO' and CONSECUTIVO='" & ComboBox_cxp.SelectedValue & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Label_SALDO_actual.Text = "0"

            For Each row As DataRow In dt.Rows
                VALOR_CUENTA = CInt(row.Item("VALOR"))
                Label_SALDO_actual.Text = CInt(row.Item("saldo"))
                TextBox_referencia.Text = CStr(row.Item("consecutivo"))
                TextBox_DESCRIPCION.Text = CStr(row.Item("concepto"))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()




        ' CALCLAR SALDO DE LA CUENTA
        Label_SALDO_actual.Text = 0
        Dim ABONOS As Integer = 0
        Try
            sql = "SELECT * from recibos_egresos where REFERENCIA='" & TextBox_referencia.Text & "' and concepto='Cuenta Por Pagar' and estado='DESCARGADO'"
            da_credito_DETALLE = New MySqlDataAdapter(sql, conex)
            dt_cREDITO_DETALLE = New DataTable
            da_credito_DETALLE.Fill(dt_cREDITO_DETALLE)
            Me.datagrid_historial_credito.DataSource = dt_cREDITO_DETALLE


        Catch ex As Exception
            MsgBox(ex.Message)
            conex.Close()
            da_credito_DETALLE.Dispose()
            dt_cREDITO_DETALLE.Dispose()
        End Try
        For i As Integer = 0 To datagrid_historial_credito.RowCount - 1
            ABONOS = CInt(ABONOS) + datagrid_historial_credito.Item("VALOR", i).Value
        Next
        Label_SALDO_actual.Text = CInt(VALOR_CUENTA) - CInt(ABONOS)
        conex.Close()
        da_credito_DETALLE.Dispose()
        dt_cREDITO_DETALLE.Dispose()

        datagrid_historial_credito.ClearSelection()

    End Sub

    Private Sub TxtMAIL_cliente_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub TXT_TELS_CLIENTE_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub Button_NUEVO_CLI_Click(sender As Object, e As EventArgs) Handles Button_NUEVO_CLI.Click
        'Form_contactos.Show()
        'Form_contactos.BringToFront()


        Label_info_cliente.Visible = True
        Label_info_cliente.Text = "Registre los Datos del Beneficiario"


        Me.TXT_DIR_CLIENTE.Text = ""
        Me.TXT_TELS_CLIENTE.Text = ""
        Me.TXT_DOC_CLIENTE.Text = ""
        Me.TextBox_dv_cliente.Text = ""

        Me.TXT_NOM_CLIENTE.Text = ""
        cli_dir = ""
        cli_tel = ""
        cli_mail = ""
        cli_doc = ""
        cli_nom = ""
        cli_dv = ""

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

        Label_info_cliente.Visible = True
        Label_info_cliente.Text = "Registre los Datos del Beneficiario"


        COMBO_NOM_CLIENTE_FILTRO.Visible = False

        QUE_HACE_CLIENTE = "editar"

        Button_NUEVO_CLI.Visible = False
        Button_EDIT_CLI.Visible = False
        Button_SAVE_CLI.Visible = True
    End Sub

    Private Sub Button_SAVE_CLI_Click(sender As Object, e As EventArgs) Handles Button_SAVE_CLI.Click
        Label_info_cliente.Visible = False

        If TXT_DOC_CLIENTE.Text = "" Then Exit Sub
        If TXT_NOM_CLIENTE.Text = "" Then Exit Sub


        If QUE_HACE_CLIENTE = "crear" Then
            Dim RTA As String
            RTA = MsgBox("Confirma Guardar el Contacto?." _
                & Chr(13) & "=======================================" & Chr(13) &
                "Documento:" & Me.TXT_DOC_CLIENTE.Text & "-" & TextBox_dv_cliente.Text & Chr(13) &
                "Nombre:" & Me.TXT_NOM_CLIENTE.Text & Chr(13) &
                "Teléfono:" & Me.TXT_TELS_CLIENTE.Text & Chr(13) &
                "Dirección:" & Me.TXT_DIR_CLIENTE.Text & Chr(13), MsgBoxStyle.Question + MsgBoxStyle.YesNo)
            If RTA = 6 Then
                ' se guarda
                Dim DOC As String = "", dv As String = "", TIPODOC As String = "", ES_proveedor As String = "", ES_CLIENTE As String = ""
                DOC = TXT_DOC_CLIENTE.Text
                dv = TextBox_dv_cliente.Text
                TIPODOC = "NIT"
                ES_proveedor = "SI"
                ES_CLIENTE = "SI"
                sql = "INSERT INTO proveedores(documento, dv, TIPODOCUMENTO, nombre, telefono, direccion, cliente, PROVEEDOR)" &
                      "VALUES ('" & DOC & "','" & dv & "','" & CStr(TIPODOC) & "','" & CStr(Me.TXT_NOM_CLIENTE.Text) & "','" & CStr(Me.TXT_TELS_CLIENTE.Text) & "','" & CStr(Me.TXT_DIR_CLIENTE.Text) & "','" & ES_CLIENTE & "','" & ES_proveedor & "')"
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
                Label_info_cliente.Text = "Se Guradó el Contacto."

            End If
        End If

        If QUE_HACE_CLIENTE = "editar" Then
            Dim RTA2 As String
            RTA2 = MsgBox("Confirma Modificar los datos del Contacto?." _
                    & Chr(13) & "=======================================" & Chr(13) &
                    "Nombre:" & Me.TXT_NOM_CLIENTE.Text & Chr(13) &
                    "Documento:" & Me.TXT_DOC_CLIENTE.Text & "-" & Me.TextBox_dv_cliente.Text & Chr(13) &
                    "Teléfono:" & Me.TXT_TELS_CLIENTE.Text & Chr(13) &
                    "Dirección:" & Me.TXT_DIR_CLIENTE.Text & Chr(13), MsgBoxStyle.Question + MsgBoxStyle.YesNo)
            If RTA2 = 6 Then
                ' se guarda
                Dim DOC As String = "", dv As String = "", TIPODOC As String = "", ES_cliente As String = ""
                DOC = TXT_DOC_CLIENTE.Text
                dv = ""
                TIPODOC = "Cédula de Contacto"
                ES_cliente = "SI"

                sql = "update proveedores set documento='" & TXT_DOC_CLIENTE.Text & "', nombre='" & CStr(Me.TXT_NOM_CLIENTE.Text) & "', telefono='" & CStr(Me.TXT_TELS_CLIENTE.Text) & "', direccion='" & CStr(Me.TXT_DIR_CLIENTE.Text) & "', cliente='" & ES_cliente & "' WHERE DOCUMENTO='" & TXT_DOC_CLIENTE.Text & "'"
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
                Label_info_cliente.Text = "Se Guradó el Contacto."
            End If
        End If



        Button_SAVE_CLI.Visible = False
        Button_EDIT_CLI.Visible = True
        Button_NUEVO_CLI.Visible = True


        COMBO_NOM_CLIENTE_FILTRO.Visible = True

        QUE_HACE_CLIENTE = ""


        'Timer_CLIENTE.Enabled = True
    End Sub
    Private Sub TXT_DIR_CLIENTE_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox_DOC_CLIENTE_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub

    Private Sub ComboBox_nombre_prov_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub

    Private Sub TXT_NOM_CLIENTE_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_tipo_egreso.SelectionChangeCommitted
        If ComboBox_tipo_egreso.Text = "" Then
            'si no hay concepto se sale
            Exit Sub
        End If

        If TXT_DOC_CLIENTE.Text = "" Then
            MsgBox("Seleccione el beneficiario.")
            ComboBox_tipo_egreso.SelectedItem = Nothing

            Exit Sub
        End If


        TextBox_referencia.Text = ""
        Label_SALDO_actual.Text = "0"
        TextBox_DESCRIPCION.Text = ""

        If ComboBox_tipo_egreso.Text = "Abono a Cuenta Por Pagar" Then

            Try
                sql = "SELECT consecutivo, CONCAT('CxP-',CONSECUTIVO,' de ',FECHA, ' Factura-',documento,' | $ ', replace(format(Valor,0),',','.')) AS FACTURA, saldo FROM carteracredito WHERE tipo='CREDITO' AND CLIENTEDOC='" & TXT_DOC_CLIENTE.Text & "' AND ESTADO='PENDIENTE'"
                da_CXP = New MySqlDataAdapter(sql, conex)
                dt_CXP = New DataTable
                da_CXP.Fill(dt_CXP)
                Me.ComboBox_cxp.DataSource = dt_CXP.DefaultView
                Me.ComboBox_cxp.DisplayMember = "FACTURA"
                Me.ComboBox_cxp.ValueMember = "CONSECUTIVO"
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da_CXP.Dispose()
            dt_CXP.Dispose()
            conex.Close()

            ComboBox_cxp.SelectedItem = Nothing


            Label5.Visible = True
            ComboBox_cxp.Visible = True

            TextBox_referencia.Enabled = False
            ComboBox_cxp.Enabled = True
            Panel_facturavr.Visible = True

            Exit Sub
        Else
            Label5.Visible = False
            ComboBox_cxp.Visible = False

            ComboBox_cxp.Enabled = True
            TextBox_referencia.Enabled = True
            Panel_facturavr.Visible = False
        End If





        Timer_cuentapuc_concepto.Enabled = True


        TextBox_referencia.Enabled = True
        TextBox_DESCRIPCION.Enabled = True
        ComboBox_cxp.Enabled = False
        TextBox_valorgasto.Enabled = True
    End Sub

    Private Sub TXT_DOC_CLIENTE_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox_DOC_CLIENTE_SelectionChangeCommitted(sender As Object, e As EventArgs)
        Timer_CLIENTE.Enabled = True

    End Sub

    Private Sub Button_anular_Click(sender As Object, e As EventArgs) Handles Button_anular.Click

        Select Case MessageBox.Show("Confirma la anulación de la factura?", "Anular Factura.", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            Case DialogResult.Yes

                sql = "UPDATE RECIBOS_EGRESOS SET estado='ANULADO' WHERE DOCUMENTO=" & CInt(Label_consecutivo.Text) & ""
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

                sql = "delete from CAJASPUC WHERE DOCUMENTO=" & CInt(Label_consecutivo.Text) & " and tipodoc='COMPROBANTE DE EGRESO'"
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


                'CAJA EMPLEADO
                sql = "UPDATE CAJA SET ESTADO='ANULADO' WHERE DOCUMENTO=" & CInt(Label_consecutivo.Text) & " and tipodocumento='COMPROBANTE DE EGRESO'"
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



                If ComboBox_tipo_egreso.Text = "Abono a Cuenta Por Pagar" Then

                End If




                Label_estado_gasto.Text = "ANULADO"
                Button_anular.Visible = False


            Case DialogResult.No
                Button_anular.Visible = True
                Me.Close()
        End Select
    End Sub

    Private Sub ComboBox_nombre_prov_SelectionChangeCommitted(sender As Object, e As EventArgs)
        Timer_CLIENTE.Enabled = True

    End Sub

    Private Sub TextBox_referencia_TextChanged(sender As Object, e As EventArgs) Handles TextBox_referencia.TextChanged

    End Sub

    Private Sub ComboBox3_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_MEDIOPAGO.SelectionChangeCommitted
        Timer_MEDIO_PAGO.Enabled = True
    End Sub

    Private Sub TextBox_dv_cliente_TextChanged(sender As Object, e As EventArgs) Handles TextBox_dv_cliente.TextChanged

    End Sub

    Private Sub TxtMAIL_cliente_KeyPress(sender As Object, e As KeyPressEventArgs)
        If QUE_HACE_CLIENTE = "crear" Or QUE_HACE_CLIENTE = "editar" Then
            Exit Sub
        End If
        e.KeyChar = ""
    End Sub

    Private Sub Timer_nuevo_Tick(sender As Object, e As EventArgs) Handles Timer_nuevo.Tick
        Timer_nuevo.Enabled = False
        Button_NUEVO_CLI_Click(Nothing, Nothing)
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub TextBox_BUSCAR_PROV_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button_REFRESH_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub

    Private Sub COMBO_NOM_CLIENTE_FILTRO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMBO_NOM_CLIENTE_FILTRO.SelectedIndexChanged

    End Sub

    Private Sub ConfigurarCuentasDeContabilidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigurarCuentasDeContabilidadToolStripMenuItem.Click

        Form_contadocs.Show()


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox_subtotal.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox_impuestos.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox_retenciones.TextChanged

    End Sub

    Private Sub Button_aplica_imp_Click(sender As Object, e As EventArgs) Handles Button_aplica_imp.Click
        TextBox_impuestos.Text = TextBox_imp_a_aplicar.Text

        totalizar()
    End Sub

    Private Sub Button_aplica_ret_Click(sender As Object, e As EventArgs) Handles Button_aplica_ret.Click
        TextBox_retenciones.Text = TextBox_ret_a_aplicar.Text

        totalizar()
    End Sub
    Private Sub totalizar()
        If TextBox_impuestos.Text = "" Then TextBox_impuestos.Text = 0
        If TextBox_retenciones.Text = "" Then TextBox_retenciones.Text = 0

        If IMP_PORCENTAJE = "" Then IMP_PORCENTAJE = 0
        IMP_BASE = CDec(TextBox_valor.Text) / CDec((CDec(IMP_PORCENTAJE) / 100) + 1)
        IMP_VALOR = TextBox_valor.Text - IMP_BASE

        TextBox_imp_a_aplicar.Text = FormatNumber(IMP_VALOR, 2)


        If RETE_PORCENTAJE = "" Then RETE_PORCENTAJE = 0

        RETE_BASE = CDec(TextBox_valor.Text) / CDec((CDec(RETE_PORCENTAJE) / 100) + 1)
        RETE_VALOR = TextBox_valor.Text - RETE_BASE

        TextBox_ret_a_aplicar.Text = FormatNumber(RETE_VALOR, 2)



        TextBox_subtotal.Text = CDec(TextBox_valor.Text) - CDec(TextBox_impuestos.Text)


        TextBox_valorgasto.Text = CDec(TextBox_subtotal.Text) + CDec(TextBox_impuestos.Text) - CDec(TextBox_retenciones.Text)




    End Sub
    Private Sub TextBox_ret_a_aplicar_TextChanged(sender As Object, e As EventArgs) Handles TextBox_ret_a_aplicar.TextChanged

    End Sub

    Private Sub Panel_facturavr_Paint(sender As Object, e As PaintEventArgs) Handles Panel_facturavr.Paint

    End Sub

    Private Sub TextBox_valorgasto_TextChanged(sender As Object, e As EventArgs) Handles TextBox_valorgasto.TextChanged

    End Sub

    Private Sub ComboBox_RETENCIONES_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_RETENCIONES.SelectedIndexChanged

    End Sub

    Private Sub TextBox_valor_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button_sel_cuenta_ce_Click(sender As Object, e As EventArgs) Handles Button_sel_cuenta_ce.Click

    End Sub

    Private Sub ComboBox_impuestos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_impuestos.SelectedIndexChanged

    End Sub

    Private Sub CargarConceptosDeEgresosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarConceptosDeEgresosToolStripMenuItem.Click
        'LOAD CUENTAPUC  CONCEPTO
        Try
            sql = "SELECT cons, documento, CUENTA1 from data_docs where estado='SI' and CODIGO IN('CE','CG') AND padre='NO'"

            da_combo_CUENTAS_CONCEPTO = New MySqlDataAdapter(sql, conex)
            dT_combo_CUENTAS_CONCEPTO = New DataTable
            da_combo_CUENTAS_CONCEPTO.Fill(dT_combo_CUENTAS_CONCEPTO)
            Me.ComboBox_tipo_egreso.DataSource = dT_combo_CUENTAS_CONCEPTO.DefaultView
            Me.ComboBox_tipo_egreso.DisplayMember = "DOCUMENTO"
            Me.ComboBox_tipo_egreso.ValueMember = "CONS"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da_combo_CUENTAS_CONCEPTO.Dispose()
        dT_combo_CUENTAS_CONCEPTO.Dispose()
        conex.Close()
        ComboBox_tipo_egreso.DroppedDown = True

    End Sub

    Private Sub ComboBox2_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_cxp.SelectionChangeCommitted
        Timer_factura_info.Enabled = True

    End Sub

    Private Sub TextBox_referencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_referencia.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""

    End Sub

    Private Sub TextBox_imp_a_aplicar_TextChanged(sender As Object, e As EventArgs) Handles TextBox_imp_a_aplicar.TextChanged

    End Sub

    Private Sub TextBox_dv_cliente_GotFocus(sender As Object, e As EventArgs) Handles TextBox_dv_cliente.GotFocus

    End Sub

    Private Sub TXT_DOC_CLIENTE_OnValueChanged(sender As Object, e As EventArgs) Handles TXT_DOC_CLIENTE.OnValueChanged
        If TXT_DOC_CLIENTE.Text = "" Then
            TextBox_dv_cliente.Text = ""
            Exit Sub
        End If

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
            TextBox_dv_cliente.Text = RESIDUO

            If RESIDUO > 1 Then
                TextBox_dv_cliente.Text = Convert.ToString(11 - RESIDUO)
            End If
        End If
    End Sub

    Private Sub TXT_NOM_CLIENTE_OnValueChanged(sender As Object, e As EventArgs) Handles TXT_NOM_CLIENTE.OnValueChanged

    End Sub

    Private Sub TXT_TELS_CLIENTE_OnValueChanged(sender As Object, e As EventArgs) Handles TXT_TELS_CLIENTE.OnValueChanged

    End Sub

    Private Sub COMBO_NOM_CLIENTE_FILTRO_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles COMBO_NOM_CLIENTE_FILTRO.SelectionChangeCommitted
        Timer_CLIENTE.Enabled = True
        TextBox_BUSCAR_PROV.Text = ""
        If COMBO_NOM_CLIENTE_FILTRO.SelectedValue <> Nothing Then cli_doc = COMBO_NOM_CLIENTE_FILTRO.SelectedValue.ToString
    End Sub

    Private Sub TXT_DIR_CLIENTE_OnValueChanged(sender As Object, e As EventArgs) Handles TXT_DIR_CLIENTE.OnValueChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_subtotal.KeyPress
        e.KeyChar = ""

    End Sub

    Private Sub TextBox_valor_OnValueChanged(sender As Object, e As EventArgs) Handles TextBox_valor.OnValueChanged
        If TextBox_valor.Text = "" Then TextBox_valor.Text = "0"

        totalizar()

    End Sub

    Private Sub TEXTBOX_BUSCAR_PROV_OnValueChanged(sender As Object, e As EventArgs) Handles TEXTBOX_BUSCAR_PROV.OnValueChanged

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_impuestos.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_retenciones.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub Button_modificar_Click(sender As Object, e As EventArgs) Handles Button_modificar.Click
        Panel_cliente.Enabled = True
        Button_modificar.Visible = False
        Button_guardar.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox_impuestos.Text = 0
        TextBox_imp_a_aplicar.Text = 0
        totalizar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox_retenciones.Text = 0
        TextBox_ret_a_aplicar.Text = 0
        totalizar()
    End Sub

    Private Sub ComboBox_cta_caja_banco_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_cta_caja_banco.SelectedIndexChanged

    End Sub

    Private Sub ComboBox_tipo_egreso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_tipo_egreso.SelectedIndexChanged

    End Sub

    Private Sub ComboBox_RETENCIONES_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_RETENCIONES.SelectionChangeCommitted
        'RETENCIONES
        Try
            sql = "SELECT porcentaje, NOMBRE FROM impuestos where tipo='COMPRAS' and tipoimp='RETENCION' AND CONS='" & ComboBox_RETENCIONES.SelectedValue & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)

            TextBox_ret_a_aplicar.Text = "0"
            RETE_PORCENTAJE = 0
            RETE_NOMBRE = ""

            For Each row As DataRow In dt.Rows
                RETE_PORCENTAJE = CInt(row.Item("porcentaje"))
                RETE_NOMBRE = CStr(row.Item("NOMBRE"))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()

        RETE_BASE = CDec(TextBox_valorgasto.Text) / CDec((CDec(RETE_PORCENTAJE) / 100) + 1)
        RETE_VALOR = TextBox_valorgasto.Text - RETE_BASE

        TextBox_ret_a_aplicar.Text = FormatNumber(RETE_VALOR, 2)

    End Sub

    Private Sub Timer_MEDIO_PAGO_Tick(sender As Object, e As EventArgs) Handles Timer_MEDIO_PAGO.Tick

    End Sub

    Private Sub ComboBox_impuestos_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_impuestos.SelectionChangeCommitted
        'IMPUESTOS
        Try
            sql = "SELECT porcentaje, NOMBRE FROM impuestos where tipo='COMPRAS' and tipoimp='PORCENTAJE' AND CONS='" & ComboBox_impuestos.SelectedValue & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)

            TextBox_imp_a_aplicar.Text = "0"
            IMP_PORCENTAJE = 0
            IMP_NOMBRE = ""

            For Each row As DataRow In dt.Rows
                IMP_PORCENTAJE = CInt(row.Item("porcentaje"))
                IMP_NOMBRE = CStr(row.Item("NOMBRE"))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()


        IMP_BASE = CDec(TextBox_valor.Text) / CDec((CDec(IMP_PORCENTAJE) / 100) + 1)
        IMP_VALOR = TextBox_valor.Text - IMP_BASE

        TextBox_imp_a_aplicar.Text = FormatNumber(IMP_VALOR, 2)

    End Sub

    Private Sub ComboBox_impuestos_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox_impuestos.SelectedValueChanged

    End Sub

    Private Sub TextBox_valorgasto_LostFocus(sender As Object, e As EventArgs) Handles TextBox_valorgasto.LostFocus
        totalizar()

    End Sub

    Private Sub TextBox_valorgasto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_valorgasto.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub Button_sel_cuenta_ce_MouseDown(sender As Object, e As MouseEventArgs) Handles Button_sel_cuenta_ce.MouseDown

        If e.Button = System.Windows.Forms.MouseButtons.Right = False Then
            Button_sel_cuenta_ce.ContextMenuStrip = ContextMenuStrip_LOAD_PUC
            Me.ContextMenuStrip_LOAD_PUC.Show(Button_sel_cuenta_ce, New Point(Button_sel_cuenta_ce.Width - Button_sel_cuenta_ce.Width, Button_sel_cuenta_ce.Height))
        End If

    End Sub

    Private Sub TextBox_ret_a_aplicar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_ret_a_aplicar.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""

    End Sub

    Private Sub TextBox_imp_a_aplicar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_imp_a_aplicar.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""

    End Sub

    Private Sub TXT_DOC_CLIENTE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_DOC_CLIENTE.KeyPress
        If QUE_HACE_CLIENTE = "crear" Then
            If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""
            Exit Sub
        End If
        e.KeyChar = ""
    End Sub

    Private Sub TXT_DOC_CLIENTE_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_DOC_CLIENTE.KeyDown

    End Sub

    Private Sub TXT_DOC_CLIENTE_GotFocus(sender As Object, e As EventArgs) Handles TXT_DOC_CLIENTE.GotFocus

    End Sub

    Private Sub TXT_NOM_CLIENTE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_NOM_CLIENTE.KeyPress
        If QUE_HACE_CLIENTE = "crear" Or QUE_HACE_CLIENTE = "editar" Then
            Exit Sub
        End If
        e.KeyChar = ""
    End Sub

    Private Sub TXT_TELS_CLIENTE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_TELS_CLIENTE.KeyPress
        If QUE_HACE_CLIENTE = "crear" Or QUE_HACE_CLIENTE = "editar" Then
            If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""

            Exit Sub
        End If
        e.KeyChar = ""
    End Sub

    Private Sub TXT_DIR_CLIENTE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_DIR_CLIENTE.KeyPress
        If QUE_HACE_CLIENTE = "crear" Or QUE_HACE_CLIENTE = "editar" Then
            Exit Sub
        End If
        e.KeyChar = ""
    End Sub

    Private Sub TextBox_valor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_valor.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""

    End Sub

    Private Sub TEXTBOX_BUSCAR_PROV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TEXTBOX_BUSCAR_PROV.KeyPress
        If TEXTBOX_BUSCAR_PROV.Text = "" Then
            TXT_NOM_CLIENTE.Text = ""
            TXT_DOC_CLIENTE.Text = ""
            TXT_TELS_CLIENTE.Text = ""
            TXT_DIR_CLIENTE.Text = ""
        End If
    End Sub

    Private Sub TEXTBOX_BUSCAR_PROV_KeyDown(sender As Object, e As KeyEventArgs) Handles TEXTBOX_BUSCAR_PROV.KeyDown
        If e.KeyCode = "13" Then

            If TEXTBOX_BUSCAR_PROV.Text = "" Then
                Label_info_cliente.Visible = True
                Label_info_cliente.Text = "debe escribir Documento o Nombre para buscar."
                Exit Sub
            End If


            ''LLENADO COMBO  contactos
            Try
                If IsNumeric(TEXTBOX_BUSCAR_PROV.Text) = True Then sql = "SELECT documento, nombre FROM proveedores WHERE documento='" & TEXTBOX_BUSCAR_PROV.Text & "'"
                If IsNumeric(TEXTBOX_BUSCAR_PROV.Text) = False = True Then sql = "SELECT documento, nombre FROM proveedores WHERE nombre like '%" & TEXTBOX_BUSCAR_PROV.Text & "%'"

                da_contact_fitro_ce = New MySqlDataAdapter(sql, conex)
                dT_contact_fitro_ce = New DataTable
                da_contact_fitro_ce.Fill(dT_contact_fitro_ce)
                Me.COMBO_NOM_CLIENTE_FILTRO.DataSource = dT_contact_fitro_ce.DefaultView
                Me.COMBO_NOM_CLIENTE_FILTRO.DisplayMember = "nombre"
                Me.COMBO_NOM_CLIENTE_FILTRO.ValueMember = "documento"
                Me.COMBO_NOM_CLIENTE_FILTRO.AutoCompleteSource = AutoCompleteSource.ListItems
                Me.COMBO_NOM_CLIENTE_FILTRO.AutoCompleteMode = AutoCompleteMode.Suggest
                Me.COMBO_NOM_CLIENTE_FILTRO.SelectedItem = Nothing


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conex.Close()
            da_contact_fitro_ce.Dispose()
            dT_contact_fitro_ce.Dispose()
            conex.Close()



            COMBO_NOM_CLIENTE_FILTRO.Focus()

            COMBO_NOM_CLIENTE_FILTRO.DroppedDown = True

            Cursor.Current = Cursors.Default
        End If

    End Sub

    Private Sub ComboBox_cta_caja_banco_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_cta_caja_banco.SelectionChangeCommitted

    End Sub
End Class