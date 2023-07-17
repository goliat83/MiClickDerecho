Public Class FormDomicilio
    Private Sub Label_consecutivo_Click(sender As Object, e As EventArgs) Handles Label_consecutivoVENTA.Click

    End Sub

    Private Sub Label_consecutivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Label_consecutivoVENTA.KeyPress

    End Sub

    Private Sub FormDomicilio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If VENTAS_DOMICILIO = "" Then
            Label_consecutivoVENTA.Text = VENTAS_DOMICILIO_ID_VENTA
        End If
    End Sub

    Private Sub FormDomicilio_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Textbox_Cliente_Doc.Text = ""
        Textbox_Cliente_Nom.Text = ""
        Textbox_Cliente_Tel1.Text = ""
        Textbox_Cliente_Dir.Text = ""
        TextBox_valor.Text = "0"

        txt_domi_doc.Text = ""
        txt_domi_nom.Text = ""
        txt_domi_tel.Text = ""

        txt_domi_notas.Text = ""



        Label11.Text = DateTime.Now.ToShortDateString & " " & DateTime.Now.ToLongTimeString

        txt_domi_doc.Enabled = True
        txt_domi_nom.Enabled = True
        txt_domi_tel.Enabled = True

        txt_domi_notas.Enabled = True

        Textbox_Cliente_Doc.Enabled = True
        Textbox_Cliente_Nom.Enabled = True
        Textbox_Cliente_Tel1.Enabled = True
        Textbox_Cliente_Dir.Enabled = True
        TextBox_valor.Enabled = True


        Textbox_Cliente_Nom.Text = Form_sales.Textbox_Cliente_Nom.Text
        Textbox_Cliente_Doc.Text = Form_sales.Textbox_Cliente_Doc.Text
        Textbox_Cliente_Dir.Text = Form_sales.Textbox_Cliente_Dir.Text
        Textbox_Cliente_Tel1.Text = Form_sales.Textbox_Cliente_Tel1.Text

        ComboBox_DOMICILIARIOS.Enabled = True

        Try
            sql = "SELECT nombre, documento FROM EMPLEADOS where cargo='Domiciliario'"
            da_domiciliarios = New MySqlDataAdapter(sql, conex)
            dt_domiciliarios = New DataTable
            da_domiciliarios.Fill(dt_domiciliarios)
            Me.ComboBox_DOMICILIARIOS.DataSource = dt_domiciliarios.DefaultView
            Me.ComboBox_DOMICILIARIOS.DisplayMember = "NOMBRE"
            Me.ComboBox_DOMICILIARIOS.ValueMember = "DOCUMENTO"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()

        Dim topRow5 As DataRow = dt_domiciliarios.NewRow()
        topRow5("nombre") = ""
        dt_domiciliarios.Rows.InsertAt(topRow5, 0)

        da_domiciliarios.Dispose()
        dt_domiciliarios.Dispose()
        conex.Close()

        ComboBox_DOMICILIARIOS.SelectedItem = Nothing



        'CARGAR DATOS DLE DOMICILIO SI YA FUE CREADO

        Try




            sql = "SELECT * from DOMICILIOS where CUENTA='" & VENTAS_DOMICILIO_ID_VENTA & "'"

            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                Label_CONS.Text = row.Item("cons")
                Textbox_Cliente_Doc.Text = row.Item("doccliente")
                Textbox_Cliente_Nom.Text = row.Item("cliente")
                Textbox_Cliente_Dir.Text = row.Item("direccion")
                Textbox_Cliente_Tel1.Text = row.Item("telefono")
                TextBox_valor.Text = row.Item("valor")
                txt_domi_notas.Text = row.Item("notas")
                Label_estado.Text = row.Item("estado")

                txt_domi_doc.Text = row.Item("MensajeroDoc")
                txt_domi_nom.Text = row.Item("MensajeroNom")
                txt_domi_tel.Text = row.Item("MensajeroTel")

                Dim domiarray = Split(row.Item("mensajero"), "|")

                Label11.Text = row.Item("fecha") & " " & row.Item("hora")


                If row.Item("estado") = "PROGRAMADO" Then
                    Button_guardar.Visible = False

                    txt_domi_doc.Enabled = False
                    txt_domi_nom.Enabled = False
                    txt_domi_tel.Enabled = False

                    Textbox_Cliente_Doc.Enabled = False
                    Textbox_Cliente_Nom.Enabled = False
                    Textbox_Cliente_Tel1.Enabled = False
                    Textbox_Cliente_Dir.Enabled = False
                    TextBox_valor.Enabled = False
                    txt_domi_notas.Enabled = False

                    ComboBox_DOMICILIARIOS.Enabled = False
                End If

            Next
        Catch ex As Exception
        End Try
        da.Dispose()
        dt.Dispose()
        conex.Close()




    End Sub

    Private Sub Textbox_Cliente_Nom_OnValueChanged(sender As Object, e As EventArgs) Handles Textbox_Cliente_Nom.OnValueChanged

    End Sub

    Private Sub ComboBox_DOMICILIARIOS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_DOMICILIARIOS.SelectedIndexChanged

    End Sub

    Private Sub ComboBox_DOMICILIARIOS_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_DOMICILIARIOS.SelectionChangeCommitted
        txt_domi_doc.Text = ""
        txt_domi_nom.Text = ""
        txt_domi_tel.Text = ""

        txt_domi_doc.Enabled = True
        txt_domi_nom.Enabled = True
        txt_domi_tel.Enabled = True

        If ComboBox_DOMICILIARIOS.SelectedValue.ToString <> "" Then

            Try


                txt_domi_doc.Enabled = False
                txt_domi_nom.Enabled = False
                txt_domi_tel.Enabled = False

                sql = "SELECT * from empleados where DOCUMENTO='" & CStr(ComboBox_DOMICILIARIOS.SelectedValue) & "'"

                da = New MySqlDataAdapter(sql, conex)
                dt = New DataTable
                da.Fill(dt)
                For Each row As DataRow In dt.Rows

                    txt_domi_doc.Text = row.Item("Documento")
                    txt_domi_nom.Text = row.Item("Nombre")
                    txt_domi_tel.Text = row.Item("Telefono")

                Next
            Catch ex As Exception
            End Try
            da.Dispose()
            dt.Dispose()
            conex.Close()


        End If
    End Sub

    Private Sub Button_guardar_Click(sender As Object, e As EventArgs) Handles Button_guardar.Click


        sql = "INSERT INTO domicilios(fecha,hora,docCliente,cliente,telefono,direccion,mensajero,mensajerodoc,mensajeronom,mensajerotel,estado,notas,cuenta,valor) 
                VALUES ('" & DateTime.Now.ToShortDateString & "',
                        '" & DateTime.Now.ToLongTimeString & "',
                        '" & Textbox_Cliente_Doc.Text & "',
                        '" & Textbox_Cliente_Nom.Text & "',
                        '" & Textbox_Cliente_Tel1.Text & "',
                        '" & Textbox_Cliente_Dir.Text & "',
                        '" & ComboBox_DOMICILIARIOS.SelectedValue & "',
                        '" & txt_domi_doc.Text & "',
                        '" & txt_domi_nom.Text & "',
                        '" & txt_domi_tel.Text & "',
                        'PROGRAMADO',
                        '" & txt_domi_notas.Text & "',
                        '" & Label_consecutivoVENTA.Text & "',
                        '" & TextBox_valor.Text & "')"
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

        Form_sales.Label_domicilio_estado.Text = Label_estado.Text
        Form_sales.Label_domicilio_estado.Visible = True

        Me.Close()

    End Sub

    Private Sub TextBox_valor_OnValueChanged(sender As Object, e As EventArgs) Handles TextBox_valor.OnValueChanged

    End Sub

    Private Sub TextBox_valor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_valor.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""

    End Sub


    Private Sub Textbox_Cliente_Doc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Textbox_Cliente_Doc.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""

    End Sub


    Private Sub Textbox_Cliente_Tel1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Textbox_Cliente_Tel1.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""

    End Sub



    Private Sub txt_domi_doc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_domi_doc.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""

    End Sub


    Private Sub txt_domi_tel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_domi_tel.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then e.KeyChar = ""

    End Sub
End Class