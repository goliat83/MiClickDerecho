<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_activacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_activacion))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_serial = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label_tipo_lic = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button_cerrar = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_mail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox_razonsocial = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox_doc = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label_fecha_r = New System.Windows.Forms.Label()
        Me.Label_ssdd = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label_fecha_v = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label_estado_lic = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label_producto = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label_lcd = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(20, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 18)
        Me.Label1.TabIndex = 550
        Me.Label1.Text = "Codigo de Activación"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox_serial
        '
        Me.TextBox_serial.BackColor = System.Drawing.Color.White
        Me.TextBox_serial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_serial.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_serial.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TextBox_serial.Location = New System.Drawing.Point(19, 83)
        Me.TextBox_serial.Name = "TextBox_serial"
        Me.TextBox_serial.Size = New System.Drawing.Size(386, 24)
        Me.TextBox_serial.TabIndex = 551
        Me.TextBox_serial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.BackColor = System.Drawing.Color.LightGray
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.Black
        Me.RichTextBox1.Location = New System.Drawing.Point(457, 368)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(10)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(441, 93)
        Me.RichTextBox1.TabIndex = 593
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'Label_tipo_lic
        '
        Me.Label_tipo_lic.AutoSize = True
        Me.Label_tipo_lic.BackColor = System.Drawing.Color.Transparent
        Me.Label_tipo_lic.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_tipo_lic.ForeColor = System.Drawing.Color.Black
        Me.Label_tipo_lic.Location = New System.Drawing.Point(107, 195)
        Me.Label_tipo_lic.Name = "Label_tipo_lic"
        Me.Label_tipo_lic.Size = New System.Drawing.Size(12, 17)
        Me.Label_tipo_lic.TabIndex = 594
        Me.Label_tipo_lic.Text = "-"
        Me.Label_tipo_lic.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.butttonsvg
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(424, 77)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 30)
        Me.Button1.TabIndex = 519
        Me.Button1.Text = "Activar Licencia"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel2.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.banner9
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Button_cerrar)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(923, 45)
        Me.Panel2.TabIndex = 548
        '
        'Button_cerrar
        '
        Me.Button_cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_cerrar.BackColor = System.Drawing.Color.Transparent
        Me.Button_cerrar.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.close
        Me.Button_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_cerrar.FlatAppearance.BorderSize = 0
        Me.Button_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_cerrar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_cerrar.ForeColor = System.Drawing.Color.White
        Me.Button_cerrar.Location = New System.Drawing.Point(887, 13)
        Me.Button_cerrar.Name = "Button_cerrar"
        Me.Button_cerrar.Size = New System.Drawing.Size(20, 20)
        Me.Button_cerrar.TabIndex = 505
        Me.Button_cerrar.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(11, 12)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(224, 23)
        Me.Label17.TabIndex = 393
        Me.Label17.Text = "Activación de Licencia"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(13, 405)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 13)
        Me.Label6.TabIndex = 702
        Me.Label6.Text = "Correo Electrónico"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_mail
        '
        Me.TextBox_mail.BackColor = System.Drawing.Color.LightGray
        Me.TextBox_mail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_mail.Enabled = False
        Me.TextBox_mail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_mail.ForeColor = System.Drawing.Color.Black
        Me.TextBox_mail.Location = New System.Drawing.Point(15, 419)
        Me.TextBox_mail.Name = "TextBox_mail"
        Me.TextBox_mail.Size = New System.Drawing.Size(331, 24)
        Me.TextBox_mail.TabIndex = 701
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(13, 354)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(216, 13)
        Me.Label8.TabIndex = 696
        Me.Label8.Text = "Nombre del Comercio / Razon Social"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_razonsocial
        '
        Me.TextBox_razonsocial.BackColor = System.Drawing.Color.LightGray
        Me.TextBox_razonsocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_razonsocial.Enabled = False
        Me.TextBox_razonsocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_razonsocial.ForeColor = System.Drawing.Color.Black
        Me.TextBox_razonsocial.Location = New System.Drawing.Point(15, 368)
        Me.TextBox_razonsocial.Name = "TextBox_razonsocial"
        Me.TextBox_razonsocial.Size = New System.Drawing.Size(414, 24)
        Me.TextBox_razonsocial.TabIndex = 695
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(14, 304)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 13)
        Me.Label7.TabIndex = 707
        Me.Label7.Text = "Documento / NIT"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_doc
        '
        Me.TextBox_doc.BackColor = System.Drawing.Color.LightGray
        Me.TextBox_doc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_doc.Enabled = False
        Me.TextBox_doc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_doc.ForeColor = System.Drawing.Color.Black
        Me.TextBox_doc.Location = New System.Drawing.Point(16, 318)
        Me.TextBox_doc.Name = "TextBox_doc"
        Me.TextBox_doc.Size = New System.Drawing.Size(176, 24)
        Me.TextBox_doc.TabIndex = 706
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.MiClickDerecho.My.Resources.Resources.oktrans
        Me.PictureBox2.Location = New System.Drawing.Point(18, 113)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 31)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 552
        Me.PictureBox2.TabStop = False
        '
        'Label_fecha_r
        '
        Me.Label_fecha_r.AutoSize = True
        Me.Label_fecha_r.BackColor = System.Drawing.Color.Transparent
        Me.Label_fecha_r.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_fecha_r.ForeColor = System.Drawing.Color.Black
        Me.Label_fecha_r.Location = New System.Drawing.Point(107, 239)
        Me.Label_fecha_r.Name = "Label_fecha_r"
        Me.Label_fecha_r.Size = New System.Drawing.Size(12, 17)
        Me.Label_fecha_r.TabIndex = 709
        Me.Label_fecha_r.Text = "-"
        Me.Label_fecha_r.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_ssdd
        '
        Me.Label_ssdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_ssdd.BackColor = System.Drawing.Color.Transparent
        Me.Label_ssdd.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ssdd.ForeColor = System.Drawing.Color.Red
        Me.Label_ssdd.Location = New System.Drawing.Point(10, 468)
        Me.Label_ssdd.Name = "Label_ssdd"
        Me.Label_ssdd.Size = New System.Drawing.Size(888, 19)
        Me.Label_ssdd.TabIndex = 711
        Me.Label_ssdd.Text = "ssdd"
        Me.Label_ssdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(27, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 712
        Me.Label2.Text = "Tipo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(27, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 713
        Me.Label3.Text = "Activación"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(27, 264)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 715
        Me.Label9.Text = "Vencimiento"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_fecha_v
        '
        Me.Label_fecha_v.AutoSize = True
        Me.Label_fecha_v.BackColor = System.Drawing.Color.Transparent
        Me.Label_fecha_v.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_fecha_v.ForeColor = System.Drawing.Color.Black
        Me.Label_fecha_v.Location = New System.Drawing.Point(107, 262)
        Me.Label_fecha_v.Name = "Label_fecha_v"
        Me.Label_fecha_v.Size = New System.Drawing.Size(12, 17)
        Me.Label_fecha_v.TabIndex = 714
        Me.Label_fecha_v.Text = "-"
        Me.Label_fecha_v.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(27, 174)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 717
        Me.Label10.Text = "Estado"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_estado_lic
        '
        Me.Label_estado_lic.AutoSize = True
        Me.Label_estado_lic.BackColor = System.Drawing.Color.Transparent
        Me.Label_estado_lic.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_estado_lic.ForeColor = System.Drawing.Color.Black
        Me.Label_estado_lic.Location = New System.Drawing.Point(107, 172)
        Me.Label_estado_lic.Name = "Label_estado_lic"
        Me.Label_estado_lic.Size = New System.Drawing.Size(12, 17)
        Me.Label_estado_lic.TabIndex = 716
        Me.Label_estado_lic.Text = "-"
        Me.Label_estado_lic.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(460, 346)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(382, 20)
        Me.CheckBox1.TabIndex = 718
        Me.CheckBox1.Text = "Acepto los Términos y Condiciones Generales de la Licencia"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(27, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 720
        Me.Label4.Text = "Producto"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_producto
        '
        Me.Label_producto.AutoSize = True
        Me.Label_producto.BackColor = System.Drawing.Color.Transparent
        Me.Label_producto.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_producto.ForeColor = System.Drawing.Color.Black
        Me.Label_producto.Location = New System.Drawing.Point(107, 217)
        Me.Label_producto.Name = "Label_producto"
        Me.Label_producto.Size = New System.Drawing.Size(12, 17)
        Me.Label_producto.TabIndex = 719
        Me.Label_producto.Text = "-"
        Me.Label_producto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.butttonsvg
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(605, 77)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(169, 30)
        Me.Button2.TabIndex = 721
        Me.Button2.Text = "Contactar Soporte"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label_lcd
        '
        Me.Label_lcd.AutoSize = True
        Me.Label_lcd.BackColor = System.Drawing.Color.Transparent
        Me.Label_lcd.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_lcd.ForeColor = System.Drawing.Color.Black
        Me.Label_lcd.Location = New System.Drawing.Point(54, 118)
        Me.Label_lcd.Name = "Label_lcd"
        Me.Label_lcd.Size = New System.Drawing.Size(365, 18)
        Me.Label_lcd.TabIndex = 722
        Me.Label_lcd.Text = "Actualmente no tiene una licencia habilitada."
        Me.Label_lcd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.MiClickDerecho.My.Resources.Resources.license
        Me.PictureBox1.Location = New System.Drawing.Point(698, 133)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(172, 184)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 723
        Me.PictureBox1.TabStop = False
        '
        'Form_activacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(923, 496)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label_lcd)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label_producto)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label_estado_lic)
        Me.Controls.Add(Me.Label_fecha_v)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label_ssdd)
        Me.Controls.Add(Me.Label_fecha_r)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox_doc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox_mail)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox_razonsocial)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.TextBox_serial)
        Me.Controls.Add(Me.Label_tipo_lic)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_activacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TextBox_serial As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label_tipo_lic As Label
    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button_cerrar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox_mail As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox_razonsocial As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox_doc As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label_fecha_r As Label
    Friend WithEvents Label_ssdd As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label_fecha_v As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label_estado_lic As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label_producto As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label_lcd As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
