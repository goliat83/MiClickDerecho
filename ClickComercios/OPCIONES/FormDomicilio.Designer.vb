<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDomicilio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDomicilio))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label_consecutivoVENTA = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.ComboBox_DOMICILIARIOS = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Textbox_Cliente_Doc = New ns1.BunifuMaterialTextbox()
        Me.Textbox_Cliente_Nom = New ns1.BunifuMaterialTextbox()
        Me.Textbox_Cliente_Tel1 = New ns1.BunifuMaterialTextbox()
        Me.Textbox_Cliente_Dir = New ns1.BunifuMaterialTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_domi_doc = New ns1.BunifuMaterialTextbox()
        Me.txt_domi_nom = New ns1.BunifuMaterialTextbox()
        Me.txt_domi_tel = New ns1.BunifuMaterialTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_domi_notas = New ns1.BunifuMaterialTextbox()
        Me.TextBox_valor = New ns1.BunifuMaterialTextbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button_guardar = New System.Windows.Forms.Button()
        Me.Label_estado = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label_CONS = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(63, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 29)
        Me.Label1.TabIndex = 793
        Me.Label1.Text = "Domiclios"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.MiClickDerecho.My.Resources.Resources.domi_ico
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(45, 45)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 806
        Me.PictureBox2.TabStop = False
        '
        'Label_consecutivoVENTA
        '
        Me.Label_consecutivoVENTA.AllowDrop = True
        Me.Label_consecutivoVENTA.BackColor = System.Drawing.Color.PaleGreen
        Me.Label_consecutivoVENTA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label_consecutivoVENTA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_consecutivoVENTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label_consecutivoVENTA.ForeColor = System.Drawing.Color.White
        Me.Label_consecutivoVENTA.Location = New System.Drawing.Point(26, 90)
        Me.Label_consecutivoVENTA.Name = "Label_consecutivoVENTA"
        Me.Label_consecutivoVENTA.Size = New System.Drawing.Size(114, 28)
        Me.Label_consecutivoVENTA.TabIndex = 807
        Me.Label_consecutivoVENTA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label53
        '
        Me.Label53.AllowDrop = True
        Me.Label53.AutoSize = True
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Label53.ForeColor = System.Drawing.Color.White
        Me.Label53.Location = New System.Drawing.Point(24, 72)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(52, 15)
        Me.Label53.TabIndex = 808
        Me.Label53.Text = "Cuenta"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.AllowDrop = True
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(22, 259)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(110, 20)
        Me.Label28.TabIndex = 810
        Me.Label28.Text = "Domiciliario"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox_DOMICILIARIOS
        '
        Me.ComboBox_DOMICILIARIOS.BackColor = System.Drawing.Color.Black
        Me.ComboBox_DOMICILIARIOS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox_DOMICILIARIOS.DropDownHeight = 200
        Me.ComboBox_DOMICILIARIOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_DOMICILIARIOS.DropDownWidth = 267
        Me.ComboBox_DOMICILIARIOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox_DOMICILIARIOS.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_DOMICILIARIOS.ForeColor = System.Drawing.Color.White
        Me.ComboBox_DOMICILIARIOS.FormattingEnabled = True
        Me.ComboBox_DOMICILIARIOS.IntegralHeight = False
        Me.ComboBox_DOMICILIARIOS.ItemHeight = 18
        Me.ComboBox_DOMICILIARIOS.Location = New System.Drawing.Point(28, 279)
        Me.ComboBox_DOMICILIARIOS.Name = "ComboBox_DOMICILIARIOS"
        Me.ComboBox_DOMICILIARIOS.Size = New System.Drawing.Size(543, 26)
        Me.ComboBox_DOMICILIARIOS.TabIndex = 809
        '
        'Label22
        '
        Me.Label22.AllowDrop = True
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label22.ForeColor = System.Drawing.Color.DarkGray
        Me.Label22.Location = New System.Drawing.Point(28, 207)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(46, 14)
        Me.Label22.TabIndex = 818
        Me.Label22.Text = "Teléfono"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.AllowDrop = True
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.DarkGray
        Me.Label21.Location = New System.Drawing.Point(174, 206)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(51, 14)
        Me.Label21.TabIndex = 817
        Me.Label21.Text = "Dirección"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.AllowDrop = True
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.Color.DarkGray
        Me.Label19.Location = New System.Drawing.Point(221, 155)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(46, 14)
        Me.Label19.TabIndex = 816
        Me.Label19.Text = "Nombre"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AllowDrop = True
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.DarkGray
        Me.Label15.Location = New System.Drawing.Point(26, 156)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 14)
        Me.Label15.TabIndex = 815
        Me.Label15.Text = "Documento"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Textbox_Cliente_Doc
        '
        Me.Textbox_Cliente_Doc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textbox_Cliente_Doc.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textbox_Cliente_Doc.ForeColor = System.Drawing.Color.White
        Me.Textbox_Cliente_Doc.HintForeColor = System.Drawing.Color.White
        Me.Textbox_Cliente_Doc.HintText = ""
        Me.Textbox_Cliente_Doc.isPassword = False
        Me.Textbox_Cliente_Doc.LineFocusedColor = System.Drawing.Color.Orange
        Me.Textbox_Cliente_Doc.LineIdleColor = System.Drawing.Color.White
        Me.Textbox_Cliente_Doc.LineMouseHoverColor = System.Drawing.Color.Orange
        Me.Textbox_Cliente_Doc.LineThickness = 1
        Me.Textbox_Cliente_Doc.Location = New System.Drawing.Point(30, 169)
        Me.Textbox_Cliente_Doc.Margin = New System.Windows.Forms.Padding(4)
        Me.Textbox_Cliente_Doc.Name = "Textbox_Cliente_Doc"
        Me.Textbox_Cliente_Doc.Size = New System.Drawing.Size(162, 24)
        Me.Textbox_Cliente_Doc.TabIndex = 811
        Me.Textbox_Cliente_Doc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Textbox_Cliente_Nom
        '
        Me.Textbox_Cliente_Nom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textbox_Cliente_Nom.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textbox_Cliente_Nom.ForeColor = System.Drawing.Color.White
        Me.Textbox_Cliente_Nom.HintForeColor = System.Drawing.Color.White
        Me.Textbox_Cliente_Nom.HintText = ""
        Me.Textbox_Cliente_Nom.isPassword = False
        Me.Textbox_Cliente_Nom.LineFocusedColor = System.Drawing.Color.Orange
        Me.Textbox_Cliente_Nom.LineIdleColor = System.Drawing.Color.White
        Me.Textbox_Cliente_Nom.LineMouseHoverColor = System.Drawing.Color.Orange
        Me.Textbox_Cliente_Nom.LineThickness = 1
        Me.Textbox_Cliente_Nom.Location = New System.Drawing.Point(224, 169)
        Me.Textbox_Cliente_Nom.Margin = New System.Windows.Forms.Padding(4)
        Me.Textbox_Cliente_Nom.Name = "Textbox_Cliente_Nom"
        Me.Textbox_Cliente_Nom.Size = New System.Drawing.Size(353, 24)
        Me.Textbox_Cliente_Nom.TabIndex = 812
        Me.Textbox_Cliente_Nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Textbox_Cliente_Tel1
        '
        Me.Textbox_Cliente_Tel1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textbox_Cliente_Tel1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textbox_Cliente_Tel1.ForeColor = System.Drawing.Color.White
        Me.Textbox_Cliente_Tel1.HintForeColor = System.Drawing.Color.White
        Me.Textbox_Cliente_Tel1.HintText = ""
        Me.Textbox_Cliente_Tel1.isPassword = False
        Me.Textbox_Cliente_Tel1.LineFocusedColor = System.Drawing.Color.Orange
        Me.Textbox_Cliente_Tel1.LineIdleColor = System.Drawing.Color.White
        Me.Textbox_Cliente_Tel1.LineMouseHoverColor = System.Drawing.Color.Orange
        Me.Textbox_Cliente_Tel1.LineThickness = 1
        Me.Textbox_Cliente_Tel1.Location = New System.Drawing.Point(30, 216)
        Me.Textbox_Cliente_Tel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Textbox_Cliente_Tel1.Name = "Textbox_Cliente_Tel1"
        Me.Textbox_Cliente_Tel1.Size = New System.Drawing.Size(139, 24)
        Me.Textbox_Cliente_Tel1.TabIndex = 814
        Me.Textbox_Cliente_Tel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Textbox_Cliente_Dir
        '
        Me.Textbox_Cliente_Dir.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textbox_Cliente_Dir.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textbox_Cliente_Dir.ForeColor = System.Drawing.Color.White
        Me.Textbox_Cliente_Dir.HintForeColor = System.Drawing.Color.White
        Me.Textbox_Cliente_Dir.HintText = ""
        Me.Textbox_Cliente_Dir.isPassword = False
        Me.Textbox_Cliente_Dir.LineFocusedColor = System.Drawing.Color.Orange
        Me.Textbox_Cliente_Dir.LineIdleColor = System.Drawing.Color.White
        Me.Textbox_Cliente_Dir.LineMouseHoverColor = System.Drawing.Color.Orange
        Me.Textbox_Cliente_Dir.LineThickness = 1
        Me.Textbox_Cliente_Dir.Location = New System.Drawing.Point(177, 216)
        Me.Textbox_Cliente_Dir.Margin = New System.Windows.Forms.Padding(4)
        Me.Textbox_Cliente_Dir.Name = "Textbox_Cliente_Dir"
        Me.Textbox_Cliente_Dir.Size = New System.Drawing.Size(400, 24)
        Me.Textbox_Cliente_Dir.TabIndex = 813
        Me.Textbox_Cliente_Dir.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AllowDrop = True
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(24, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 15)
        Me.Label4.TabIndex = 821
        Me.Label4.Text = "Destinatario"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AllowDrop = True
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.DarkGray
        Me.Label6.Location = New System.Drawing.Point(451, 319)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 14)
        Me.Label6.TabIndex = 829
        Me.Label6.Text = "Celular"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AllowDrop = True
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.DarkGray
        Me.Label8.Location = New System.Drawing.Point(179, 317)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 14)
        Me.Label8.TabIndex = 827
        Me.Label8.Text = "Nombre"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AllowDrop = True
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.DarkGray
        Me.Label9.Location = New System.Drawing.Point(30, 317)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 14)
        Me.Label9.TabIndex = 826
        Me.Label9.Text = "Documento"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_domi_doc
        '
        Me.txt_domi_doc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_domi_doc.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_domi_doc.ForeColor = System.Drawing.Color.White
        Me.txt_domi_doc.HintForeColor = System.Drawing.Color.White
        Me.txt_domi_doc.HintText = ""
        Me.txt_domi_doc.isPassword = False
        Me.txt_domi_doc.LineFocusedColor = System.Drawing.Color.Orange
        Me.txt_domi_doc.LineIdleColor = System.Drawing.Color.White
        Me.txt_domi_doc.LineMouseHoverColor = System.Drawing.Color.Orange
        Me.txt_domi_doc.LineThickness = 1
        Me.txt_domi_doc.Location = New System.Drawing.Point(30, 333)
        Me.txt_domi_doc.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_domi_doc.Name = "txt_domi_doc"
        Me.txt_domi_doc.Size = New System.Drawing.Size(139, 24)
        Me.txt_domi_doc.TabIndex = 822
        Me.txt_domi_doc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_domi_nom
        '
        Me.txt_domi_nom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_domi_nom.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_domi_nom.ForeColor = System.Drawing.Color.White
        Me.txt_domi_nom.HintForeColor = System.Drawing.Color.White
        Me.txt_domi_nom.HintText = ""
        Me.txt_domi_nom.isPassword = False
        Me.txt_domi_nom.LineFocusedColor = System.Drawing.Color.Orange
        Me.txt_domi_nom.LineIdleColor = System.Drawing.Color.White
        Me.txt_domi_nom.LineMouseHoverColor = System.Drawing.Color.Orange
        Me.txt_domi_nom.LineThickness = 1
        Me.txt_domi_nom.Location = New System.Drawing.Point(179, 333)
        Me.txt_domi_nom.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_domi_nom.Name = "txt_domi_nom"
        Me.txt_domi_nom.Size = New System.Drawing.Size(261, 24)
        Me.txt_domi_nom.TabIndex = 823
        Me.txt_domi_nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_domi_tel
        '
        Me.txt_domi_tel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_domi_tel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_domi_tel.ForeColor = System.Drawing.Color.White
        Me.txt_domi_tel.HintForeColor = System.Drawing.Color.White
        Me.txt_domi_tel.HintText = ""
        Me.txt_domi_tel.isPassword = False
        Me.txt_domi_tel.LineFocusedColor = System.Drawing.Color.Orange
        Me.txt_domi_tel.LineIdleColor = System.Drawing.Color.White
        Me.txt_domi_tel.LineMouseHoverColor = System.Drawing.Color.Orange
        Me.txt_domi_tel.LineThickness = 1
        Me.txt_domi_tel.Location = New System.Drawing.Point(451, 333)
        Me.txt_domi_tel.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_domi_tel.Name = "txt_domi_tel"
        Me.txt_domi_tel.Size = New System.Drawing.Size(162, 24)
        Me.txt_domi_tel.TabIndex = 825
        Me.txt_domi_tel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AllowDrop = True
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.DarkGray
        Me.Label5.Location = New System.Drawing.Point(28, 371)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 14)
        Me.Label5.TabIndex = 831
        Me.Label5.Text = "Notas"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_domi_notas
        '
        Me.txt_domi_notas.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_domi_notas.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_domi_notas.ForeColor = System.Drawing.Color.White
        Me.txt_domi_notas.HintForeColor = System.Drawing.Color.White
        Me.txt_domi_notas.HintText = ""
        Me.txt_domi_notas.isPassword = False
        Me.txt_domi_notas.LineFocusedColor = System.Drawing.Color.Orange
        Me.txt_domi_notas.LineIdleColor = System.Drawing.Color.White
        Me.txt_domi_notas.LineMouseHoverColor = System.Drawing.Color.Orange
        Me.txt_domi_notas.LineThickness = 1
        Me.txt_domi_notas.Location = New System.Drawing.Point(30, 385)
        Me.txt_domi_notas.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_domi_notas.Name = "txt_domi_notas"
        Me.txt_domi_notas.Size = New System.Drawing.Size(583, 24)
        Me.txt_domi_notas.TabIndex = 830
        Me.txt_domi_notas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TextBox_valor
        '
        Me.TextBox_valor.BackColor = System.Drawing.Color.Black
        Me.TextBox_valor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox_valor.Font = New System.Drawing.Font("Century Gothic", 14.75!, System.Drawing.FontStyle.Bold)
        Me.TextBox_valor.ForeColor = System.Drawing.Color.White
        Me.TextBox_valor.HintForeColor = System.Drawing.Color.Empty
        Me.TextBox_valor.HintText = ""
        Me.TextBox_valor.isPassword = False
        Me.TextBox_valor.LineFocusedColor = System.Drawing.Color.Blue
        Me.TextBox_valor.LineIdleColor = System.Drawing.Color.LightCoral
        Me.TextBox_valor.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TextBox_valor.LineThickness = 4
        Me.TextBox_valor.Location = New System.Drawing.Point(466, 82)
        Me.TextBox_valor.Margin = New System.Windows.Forms.Padding(1)
        Me.TextBox_valor.Name = "TextBox_valor"
        Me.TextBox_valor.Size = New System.Drawing.Size(183, 36)
        Me.TextBox_valor.TabIndex = 987
        Me.TextBox_valor.Text = "0"
        Me.TextBox_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AllowDrop = True
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(463, 68)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 15)
        Me.Label10.TabIndex = 988
        Me.Label10.Text = "VALOR DOMICILIO"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button_guardar
        '
        Me.Button_guardar.BackColor = System.Drawing.Color.Transparent
        Me.Button_guardar.BackgroundImage = CType(resources.GetObject("Button_guardar.BackgroundImage"), System.Drawing.Image)
        Me.Button_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_guardar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_guardar.FlatAppearance.BorderSize = 0
        Me.Button_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.Button_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_guardar.ForeColor = System.Drawing.Color.White
        Me.Button_guardar.Image = Global.MiClickDerecho.My.Resources.Resources.guardar
        Me.Button_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_guardar.Location = New System.Drawing.Point(696, 356)
        Me.Button_guardar.Name = "Button_guardar"
        Me.Button_guardar.Size = New System.Drawing.Size(145, 53)
        Me.Button_guardar.TabIndex = 989
        Me.Button_guardar.Text = "Guardar"
        Me.Button_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_guardar.UseVisualStyleBackColor = False
        '
        'Label_estado
        '
        Me.Label_estado.BackColor = System.Drawing.Color.Transparent
        Me.Label_estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_estado.ForeColor = System.Drawing.Color.White
        Me.Label_estado.Location = New System.Drawing.Point(660, 86)
        Me.Label_estado.Name = "Label_estado"
        Me.Label_estado.Size = New System.Drawing.Size(202, 29)
        Me.Label_estado.TabIndex = 990
        Me.Label_estado.Text = "REGISTRO"
        Me.Label_estado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(442, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 29)
        Me.Label2.TabIndex = 991
        Me.Label2.Text = "$"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AllowDrop = True
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(662, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 992
        Me.Label3.Text = "ESTADO"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_CONS
        '
        Me.Label_CONS.BackColor = System.Drawing.Color.Transparent
        Me.Label_CONS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label_CONS.CausesValidation = False
        Me.Label_CONS.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_CONS.ForeColor = System.Drawing.Color.White
        Me.Label_CONS.Location = New System.Drawing.Point(620, 9)
        Me.Label_CONS.Name = "Label_CONS"
        Me.Label_CONS.Size = New System.Drawing.Size(238, 40)
        Me.Label_CONS.TabIndex = 993
        Me.Label_CONS.Text = "-"
        Me.Label_CONS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(146, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(290, 29)
        Me.Label11.TabIndex = 994
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AllowDrop = True
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(148, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 15)
        Me.Label7.TabIndex = 995
        Me.Label7.Text = "Fecha / hora"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormDomicilio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(870, 438)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label_CONS)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label_estado)
        Me.Controls.Add(Me.Button_guardar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox_valor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_domi_notas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_domi_doc)
        Me.Controls.Add(Me.txt_domi_nom)
        Me.Controls.Add(Me.txt_domi_tel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Textbox_Cliente_Doc)
        Me.Controls.Add(Me.Textbox_Cliente_Nom)
        Me.Controls.Add(Me.Textbox_Cliente_Tel1)
        Me.Controls.Add(Me.Textbox_Cliente_Dir)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.ComboBox_DOMICILIARIOS)
        Me.Controls.Add(Me.Label_consecutivoVENTA)
        Me.Controls.Add(Me.Label53)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(886, 477)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(886, 477)
        Me.Name = "FormDomicilio"
        Me.Opacity = 0.85R
        Me.ShowIcon = False
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label_consecutivoVENTA As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents ComboBox_DOMICILIARIOS As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Textbox_Cliente_Doc As ns1.BunifuMaterialTextbox
    Friend WithEvents Textbox_Cliente_Nom As ns1.BunifuMaterialTextbox
    Friend WithEvents Textbox_Cliente_Tel1 As ns1.BunifuMaterialTextbox
    Friend WithEvents Textbox_Cliente_Dir As ns1.BunifuMaterialTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_domi_doc As ns1.BunifuMaterialTextbox
    Friend WithEvents txt_domi_nom As ns1.BunifuMaterialTextbox
    Friend WithEvents txt_domi_tel As ns1.BunifuMaterialTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_domi_notas As ns1.BunifuMaterialTextbox
    Friend WithEvents TextBox_valor As ns1.BunifuMaterialTextbox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button_guardar As Button
    Friend WithEvents Label_estado As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label_CONS As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
End Class
