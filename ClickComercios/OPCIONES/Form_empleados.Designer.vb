<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_empleados
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_empleados))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox_DOMICILIO = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_MAIL = New System.Windows.Forms.TextBox()
        Me.Label_mail = New System.Windows.Forms.Label()
        Me.datagridempleados = New MetroFramework.Controls.MetroGrid()
        Me.TextBox_TEL = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_DOC = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_NOMBRE = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button_eliminar = New System.Windows.Forms.Button()
        Me.Button_modificar = New System.Windows.Forms.Button()
        Me.button_crear = New System.Windows.Forms.Button()
        Me.Button_export_pdf = New System.Windows.Forms.Button()
        Me.datagrid_export = New MetroFramework.Controls.MetroGrid()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox_celular = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.MetroComboBox_estado = New MetroFramework.Controls.MetroComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBox_tipodoc = New System.Windows.Forms.ComboBox()
        Me.Combo_cargo = New System.Windows.Forms.ComboBox()
        Me.TextBox_salario = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox_password = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.datagrid_permisos_todos = New MetroFramework.Controls.MetroGrid()
        Me.RadioButton_ADMINISTRACION = New System.Windows.Forms.RadioButton()
        Me.RadioButton_INFORMES = New System.Windows.Forms.RadioButton()
        Me.RadioButton_PAGOS = New System.Windows.Forms.RadioButton()
        Me.RadioButton_INVENTARIOS = New System.Windows.Forms.RadioButton()
        Me.RadioButton_ventas = New System.Windows.Forms.RadioButton()
        Me.datagrid_permisos = New MetroFramework.Controls.MetroGrid()
        Me.Button_quitar_permiso = New System.Windows.Forms.Button()
        Me.Button_agregar_permiso = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox_buscar_cliente = New System.Windows.Forms.TextBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.Timer_modificar = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_MEDIO_PAGO = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.Timer_PERMISOS = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuElipse2 = New ns1.BunifuElipse(Me.components)
        Me.Panel_titlebar = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button_cerrar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button_guardar = New System.Windows.Forms.Button()
        Me.Button_cancelar = New System.Windows.Forms.Button()
        Me.BunifuElipse3 = New ns1.BunifuElipse(Me.components)
        Me.Button_tab1 = New System.Windows.Forms.Button()
        Me.Button_tab2 = New System.Windows.Forms.Button()
        Me.Label_nombre_titulo = New System.Windows.Forms.Label()
        Me.BunifuElipse4 = New ns1.BunifuElipse(Me.components)
        Me.BunifuElipse5 = New ns1.BunifuElipse(Me.components)
        Me.BunifuElipse6 = New ns1.BunifuElipse(Me.components)
        Me.BunifuElipse7 = New ns1.BunifuElipse(Me.components)
        Me.BunifuElipse8 = New ns1.BunifuElipse(Me.components)
        CType(Me.datagridempleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.datagrid_export, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabPage2.SuspendLayout()
        CType(Me.datagrid_permisos_todos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datagrid_permisos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel_titlebar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label7.Location = New System.Drawing.Point(541, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(174, 23)
        Me.Label7.TabIndex = 410
        Me.Label7.Text = "Acceso al Sistema"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_DOMICILIO
        '
        Me.TextBox_DOMICILIO.BackColor = System.Drawing.Color.White
        Me.TextBox_DOMICILIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_DOMICILIO.ForeColor = System.Drawing.Color.Black
        Me.TextBox_DOMICILIO.Location = New System.Drawing.Point(35, 202)
        Me.TextBox_DOMICILIO.Name = "TextBox_DOMICILIO"
        Me.TextBox_DOMICILIO.Size = New System.Drawing.Size(395, 24)
        Me.TextBox_DOMICILIO.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(34, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 405
        Me.Label5.Text = "Domicilio"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_MAIL
        '
        Me.TextBox_MAIL.BackColor = System.Drawing.Color.White
        Me.TextBox_MAIL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_MAIL.ForeColor = System.Drawing.Color.Black
        Me.TextBox_MAIL.Location = New System.Drawing.Point(35, 243)
        Me.TextBox_MAIL.Name = "TextBox_MAIL"
        Me.TextBox_MAIL.Size = New System.Drawing.Size(395, 24)
        Me.TextBox_MAIL.TabIndex = 6
        '
        'Label_mail
        '
        Me.Label_mail.AutoSize = True
        Me.Label_mail.BackColor = System.Drawing.Color.Transparent
        Me.Label_mail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_mail.ForeColor = System.Drawing.Color.Black
        Me.Label_mail.Location = New System.Drawing.Point(34, 230)
        Me.Label_mail.Name = "Label_mail"
        Me.Label_mail.Size = New System.Drawing.Size(30, 13)
        Me.Label_mail.TabIndex = 407
        Me.Label_mail.Text = "Mail"
        Me.Label_mail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'datagridempleados
        '
        Me.datagridempleados.AllowUserToAddRows = False
        Me.datagridempleados.AllowUserToDeleteRows = False
        Me.datagridempleados.AllowUserToResizeRows = False
        Me.datagridempleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridempleados.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.datagridempleados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datagridempleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.datagridempleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridempleados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridempleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridempleados.DefaultCellStyle = DataGridViewCellStyle2
        Me.datagridempleados.EnableHeadersVisualStyles = False
        Me.datagridempleados.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.datagridempleados.GridColor = System.Drawing.Color.SteelBlue
        Me.datagridempleados.Location = New System.Drawing.Point(10, 98)
        Me.datagridempleados.MultiSelect = False
        Me.datagridempleados.Name = "datagridempleados"
        Me.datagridempleados.ReadOnly = True
        Me.datagridempleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridempleados.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.datagridempleados.RowHeadersVisible = False
        Me.datagridempleados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridempleados.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue
        Me.datagridempleados.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagridempleados.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.datagridempleados.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.datagridempleados.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.datagridempleados.RowTemplate.Height = 25
        Me.datagridempleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridempleados.Size = New System.Drawing.Size(846, 440)
        Me.datagridempleados.TabIndex = 393
        '
        'TextBox_TEL
        '
        Me.TextBox_TEL.BackColor = System.Drawing.Color.White
        Me.TextBox_TEL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_TEL.ForeColor = System.Drawing.Color.Black
        Me.TextBox_TEL.Location = New System.Drawing.Point(35, 287)
        Me.TextBox_TEL.Name = "TextBox_TEL"
        Me.TextBox_TEL.Size = New System.Drawing.Size(151, 24)
        Me.TextBox_TEL.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(34, 273)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 401
        Me.Label3.Text = "Teléfono Fijo"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_DOC
        '
        Me.TextBox_DOC.BackColor = System.Drawing.Color.White
        Me.TextBox_DOC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_DOC.ForeColor = System.Drawing.Color.Black
        Me.TextBox_DOC.Location = New System.Drawing.Point(35, 75)
        Me.TextBox_DOC.Name = "TextBox_DOC"
        Me.TextBox_DOC.Size = New System.Drawing.Size(151, 24)
        Me.TextBox_DOC.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(33, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 399
        Me.Label1.Text = "Documento"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_NOMBRE
        '
        Me.TextBox_NOMBRE.BackColor = System.Drawing.Color.White
        Me.TextBox_NOMBRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_NOMBRE.ForeColor = System.Drawing.Color.Black
        Me.TextBox_NOMBRE.Location = New System.Drawing.Point(35, 162)
        Me.TextBox_NOMBRE.Name = "TextBox_NOMBRE"
        Me.TextBox_NOMBRE.Size = New System.Drawing.Size(395, 24)
        Me.TextBox_NOMBRE.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(34, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 395
        Me.Label2.Text = "Nombre"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Button_eliminar)
        Me.Panel1.Controls.Add(Me.Button_modificar)
        Me.Panel1.Controls.Add(Me.button_crear)
        Me.Panel1.Controls.Add(Me.Button_export_pdf)
        Me.Panel1.Controls.Add(Me.datagrid_export)
        Me.Panel1.Location = New System.Drawing.Point(509, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(349, 48)
        Me.Panel1.TabIndex = 392
        '
        'Button_eliminar
        '
        Me.Button_eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_eliminar.BackColor = System.Drawing.Color.Transparent
        Me.Button_eliminar.BackgroundImage = CType(resources.GetObject("Button_eliminar.BackgroundImage"), System.Drawing.Image)
        Me.Button_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_eliminar.FlatAppearance.BorderSize = 0
        Me.Button_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_eliminar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_eliminar.ForeColor = System.Drawing.Color.White
        Me.Button_eliminar.Image = Global.MiClickDerecho.My.Resources.Resources.delete_row
        Me.Button_eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_eliminar.Location = New System.Drawing.Point(192, 2)
        Me.Button_eliminar.Name = "Button_eliminar"
        Me.Button_eliminar.Size = New System.Drawing.Size(70, 45)
        Me.Button_eliminar.TabIndex = 300
        Me.Button_eliminar.Text = "Eliminar"
        Me.Button_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_eliminar.UseVisualStyleBackColor = False
        '
        'Button_modificar
        '
        Me.Button_modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_modificar.BackColor = System.Drawing.Color.Transparent
        Me.Button_modificar.BackgroundImage = CType(resources.GetObject("Button_modificar.BackgroundImage"), System.Drawing.Image)
        Me.Button_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_modificar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_modificar.FlatAppearance.BorderSize = 0
        Me.Button_modificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_modificar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_modificar.ForeColor = System.Drawing.Color.White
        Me.Button_modificar.Image = Global.MiClickDerecho.My.Resources.Resources.viewicone
        Me.Button_modificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_modificar.Location = New System.Drawing.Point(104, 2)
        Me.Button_modificar.Name = "Button_modificar"
        Me.Button_modificar.Size = New System.Drawing.Size(85, 45)
        Me.Button_modificar.TabIndex = 299
        Me.Button_modificar.Text = "Consultar"
        Me.Button_modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_modificar.UseVisualStyleBackColor = False
        '
        'button_crear
        '
        Me.button_crear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button_crear.BackColor = System.Drawing.Color.Transparent
        Me.button_crear.BackgroundImage = CType(resources.GetObject("button_crear.BackgroundImage"), System.Drawing.Image)
        Me.button_crear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button_crear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_crear.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.button_crear.FlatAppearance.BorderSize = 0
        Me.button_crear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.button_crear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.button_crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_crear.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_crear.ForeColor = System.Drawing.Color.White
        Me.button_crear.Image = Global.MiClickDerecho.My.Resources.Resources.agregar
        Me.button_crear.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.button_crear.Location = New System.Drawing.Point(6, 2)
        Me.button_crear.Name = "button_crear"
        Me.button_crear.Size = New System.Drawing.Size(95, 45)
        Me.button_crear.TabIndex = 295
        Me.button_crear.Text = "Crear"
        Me.button_crear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.button_crear.UseVisualStyleBackColor = False
        '
        'Button_export_pdf
        '
        Me.Button_export_pdf.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_export_pdf.BackColor = System.Drawing.Color.Transparent
        Me.Button_export_pdf.BackgroundImage = CType(resources.GetObject("Button_export_pdf.BackgroundImage"), System.Drawing.Image)
        Me.Button_export_pdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_export_pdf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_export_pdf.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_export_pdf.FlatAppearance.BorderSize = 0
        Me.Button_export_pdf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_export_pdf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_export_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_export_pdf.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_export_pdf.ForeColor = System.Drawing.Color.White
        Me.Button_export_pdf.Image = Global.MiClickDerecho.My.Resources.Resources.export_icon
        Me.Button_export_pdf.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_export_pdf.Location = New System.Drawing.Point(264, 2)
        Me.Button_export_pdf.Name = "Button_export_pdf"
        Me.Button_export_pdf.Size = New System.Drawing.Size(75, 45)
        Me.Button_export_pdf.TabIndex = 415
        Me.Button_export_pdf.Text = "Exportar"
        Me.Button_export_pdf.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_export_pdf.UseVisualStyleBackColor = False
        '
        'datagrid_export
        '
        Me.datagrid_export.AllowUserToAddRows = False
        Me.datagrid_export.AllowUserToDeleteRows = False
        Me.datagrid_export.AllowUserToResizeRows = False
        Me.datagrid_export.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.datagrid_export.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datagrid_export.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.datagrid_export.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_export.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.datagrid_export.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid_export.DefaultCellStyle = DataGridViewCellStyle5
        Me.datagrid_export.EnableHeadersVisualStyles = False
        Me.datagrid_export.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.datagrid_export.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid_export.Location = New System.Drawing.Point(282, 16)
        Me.datagrid_export.Name = "datagrid_export"
        Me.datagrid_export.ReadOnly = True
        Me.datagrid_export.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_export.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.datagrid_export.RowHeadersVisible = False
        Me.datagrid_export.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagrid_export.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.datagrid_export.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid_export.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.datagrid_export.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.datagrid_export.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.datagrid_export.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrid_export.Size = New System.Drawing.Size(18, 17)
        Me.datagrid_export.TabIndex = 644
        Me.datagrid_export.Visible = False
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Bold
        Me.MetroTabControl1.HotTrack = True
        Me.MetroTabControl1.ItemSize = New System.Drawing.Size(152, 5)
        Me.MetroTabControl1.Location = New System.Drawing.Point(23, 136)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(820, 394)
        Me.MetroTabControl1.TabIndex = 435
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.cuadro_blanco
        Me.MetroTabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MetroTabPage1.Controls.Add(Me.CheckBox1)
        Me.MetroTabPage1.Controls.Add(Me.TextBox_celular)
        Me.MetroTabPage1.Controls.Add(Me.Label15)
        Me.MetroTabPage1.Controls.Add(Me.MetroComboBox_estado)
        Me.MetroTabPage1.Controls.Add(Me.Label6)
        Me.MetroTabPage1.Controls.Add(Me.Label9)
        Me.MetroTabPage1.Controls.Add(Me.ComboBox_tipodoc)
        Me.MetroTabPage1.Controls.Add(Me.Combo_cargo)
        Me.MetroTabPage1.Controls.Add(Me.Label7)
        Me.MetroTabPage1.Controls.Add(Me.TextBox_salario)
        Me.MetroTabPage1.Controls.Add(Me.Label13)
        Me.MetroTabPage1.Controls.Add(Me.Label29)
        Me.MetroTabPage1.Controls.Add(Me.Label1)
        Me.MetroTabPage1.Controls.Add(Me.TextBox_MAIL)
        Me.MetroTabPage1.Controls.Add(Me.TextBox_DOC)
        Me.MetroTabPage1.Controls.Add(Me.Label2)
        Me.MetroTabPage1.Controls.Add(Me.TextBox_DOMICILIO)
        Me.MetroTabPage1.Controls.Add(Me.Label5)
        Me.MetroTabPage1.Controls.Add(Me.TextBox_TEL)
        Me.MetroTabPage1.Controls.Add(Me.Label_mail)
        Me.MetroTabPage1.Controls.Add(Me.Label3)
        Me.MetroTabPage1.Controls.Add(Me.TextBox_NOMBRE)
        Me.MetroTabPage1.Controls.Add(Me.Panel3)
        Me.MetroTabPage1.Controls.Add(Me.Label12)
        Me.MetroTabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 9)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(812, 381)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Datos Genelares      "
        Me.MetroTabPage1.UseStyleColors = True
        Me.MetroTabPage1.UseVisualStyleBackColor = True
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.White
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(468, 202)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(314, 20)
        Me.CheckBox1.TabIndex = 641
        Me.CheckBox1.Text = "Permitir a este usuario dar autorizaciones"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'TextBox_celular
        '
        Me.TextBox_celular.BackColor = System.Drawing.Color.White
        Me.TextBox_celular.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_celular.ForeColor = System.Drawing.Color.Black
        Me.TextBox_celular.Location = New System.Drawing.Point(35, 331)
        Me.TextBox_celular.Name = "TextBox_celular"
        Me.TextBox_celular.Size = New System.Drawing.Size(151, 24)
        Me.TextBox_celular.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(34, 317)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 13)
        Me.Label15.TabIndex = 640
        Me.Label15.Text = "Telèfono Movil"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MetroComboBox_estado
        '
        Me.MetroComboBox_estado.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroComboBox_estado.BackColor = System.Drawing.Color.White
        Me.MetroComboBox_estado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MetroComboBox_estado.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.MetroComboBox_estado.ForeColor = System.Drawing.Color.Black
        Me.MetroComboBox_estado.FormattingEnabled = True
        Me.MetroComboBox_estado.ItemHeight = 19
        Me.MetroComboBox_estado.Items.AddRange(New Object() {"ACTIVO", "INACTIVO"})
        Me.MetroComboBox_estado.Location = New System.Drawing.Point(466, 330)
        Me.MetroComboBox_estado.MaxDropDownItems = 3
        Me.MetroComboBox_estado.Name = "MetroComboBox_estado"
        Me.MetroComboBox_estado.Size = New System.Drawing.Size(240, 25)
        Me.MetroComboBox_estado.TabIndex = 11
        Me.MetroComboBox_estado.UseCustomBackColor = True
        Me.MetroComboBox_estado.UseSelectable = True
        Me.MetroComboBox_estado.UseStyleColors = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(34, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 638
        Me.Label6.Text = "Cargo"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(190, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 13)
        Me.Label9.TabIndex = 637
        Me.Label9.Text = "Tipo de Documento"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox_tipodoc
        '
        Me.ComboBox_tipodoc.AutoCompleteCustomSource.AddRange(New String() {"MEDELLIN - ANTIOQUIA", "ABEJORRAL - ANTIOQUIA", "ABRIAQUI - ANTIOQUIA", "ALEJANDRIA - ANTIOQUIA", "AMAGA - ANTIOQUIA", "AMALFI - ANTIOQUIA", "ANDES - ANTIOQUIA", "ANGELOPOLIS - ANTIOQUIA", "ANGOSTURA - ANTIOQUIA", "ANORI - ANTIOQUIA", "SANTAFE DE ANTIOQUIA - ANTIOQUIA", "ANZA - ANTIOQUIA", "APARTADO - ANTIOQUIA", "ARBOLETES - ANTIOQUIA", "ARGELIA - ANTIOQUIA", "ARMENIA - ANTIOQUIA", "BARBOSA - ANTIOQUIA", "BELMIRA - ANTIOQUIA", "BELLO - ANTIOQUIA", "BETANIA - ANTIOQUIA", "BETULIA - ANTIOQUIA", "CIUDAD BOLIVAR - ANTIOQUIA", "BRICEÑO - ANTIOQUIA", "BURITICA - ANTIOQUIA", "CACERES - ANTIOQUIA", "CAICEDO - ANTIOQUIA", "CALDAS - ANTIOQUIA", "CAMPAMENTO - ANTIOQUIA", "CAÑASGORDAS - ANTIOQUIA", "CARACOLI - ANTIOQUIA", "CARAMANTA - ANTIOQUIA", "CAREPA - ANTIOQUIA", "EL CARMEN DE VIBORAL - ANTIOQUIA", "CAROLINA - ANTIOQUIA", "CAUCASIA - ANTIOQUIA", "CHIGORODO - ANTIOQUIA", "CISNEROS - ANTIOQUIA", "COCORNA - ANTIOQUIA", "CONCEPCION - ANTIOQUIA", "CONCORDIA - ANTIOQUIA", "COPACABANA - ANTIOQUIA", "DABEIBA - ANTIOQUIA", "DON MATIAS - ANTIOQUIA", "EBEJICO - ANTIOQUIA", "EL BAGRE - ANTIOQUIA", "ENTRERRIOS - ANTIOQUIA", "ENVIGADO - ANTIOQUIA", "FREDONIA - ANTIOQUIA", "FRONTINO - ANTIOQUIA", "GIRALDO - ANTIOQUIA", "GIRARDOTA - ANTIOQUIA", "GOMEZ PLATA - ANTIOQUIA", "GRANADA - ANTIOQUIA", "GUADALUPE - ANTIOQUIA", "GUARNE - ANTIOQUIA", "GUATAPE - ANTIOQUIA", "HELICONIA - ANTIOQUIA", "HISPANIA - ANTIOQUIA", "ITAGUI - ANTIOQUIA", "ITUANGO - ANTIOQUIA", "JARDIN - ANTIOQUIA", "JERICO - ANTIOQUIA", "LA CEJA - ANTIOQUIA", "LA ESTRELLA - ANTIOQUIA", "LA PINTADA - ANTIOQUIA", "LA UNION - ANTIOQUIA", "LIBORINA - ANTIOQUIA", "MACEO - ANTIOQUIA", "MARINILLA - ANTIOQUIA", "MONTEBELLO - ANTIOQUIA", "MURINDO - ANTIOQUIA", "MUTATA - ANTIOQUIA", "NARIÑO - ANTIOQUIA", "NECOCLI - ANTIOQUIA", "NECHI - ANTIOQUIA", "OLAYA - ANTIOQUIA", "PEÐOL - ANTIOQUIA", "PEQUE - ANTIOQUIA", "PUEBLORRICO - ANTIOQUIA", "PUERTO BERRIO - ANTIOQUIA", "PUERTO NARE - ANTIOQUIA", "PUERTO TRIUNFO - ANTIOQUIA", "REMEDIOS - ANTIOQUIA", "RETIRO - ANTIOQUIA", "RIONEGRO - ANTIOQUIA", "SABANALARGA - ANTIOQUIA", "SABANETA - ANTIOQUIA", "SALGAR - ANTIOQUIA", "SAN ANDRES DE CUERQUIA - ANTIOQUIA", "SAN CARLOS - ANTIOQUIA", "SAN FRANCISCO - ANTIOQUIA", "SAN JERONIMO - ANTIOQUIA", "SAN JOSE DE LA MONTAÑA - ANTIOQUIA", "SAN JUAN DE URABA - ANTIOQUIA", "SAN LUIS - ANTIOQUIA", "SAN PEDRO - ANTIOQUIA", "SAN PEDRO DE URABA - ANTIOQUIA", "SAN RAFAEL - ANTIOQUIA", "SAN ROQUE - ANTIOQUIA", "SAN VICENTE - ANTIOQUIA", "SANTA BARBARA - ANTIOQUIA", "SANTA ROSA DE OSOS - ANTIOQUIA", "SANTO DOMINGO - ANTIOQUIA", "EL SANTUARIO - ANTIOQUIA", "SEGOVIA - ANTIOQUIA", "SONSON - ANTIOQUIA", "SOPETRAN - ANTIOQUIA", "TAMESIS - ANTIOQUIA", "TARAZA - ANTIOQUIA", "TARSO - ANTIOQUIA", "TITIRIBI - ANTIOQUIA", "TOLEDO - ANTIOQUIA", "TURBO - ANTIOQUIA", "URAMITA - ANTIOQUIA", "URRAO - ANTIOQUIA", "VALDIVIA - ANTIOQUIA", "VALPARAISO - ANTIOQUIA", "VEGACHI - ANTIOQUIA", "VENECIA - ANTIOQUIA", "VIGIA DEL FUERTE - ANTIOQUIA", "YALI - ANTIOQUIA", "YARUMAL - ANTIOQUIA", "YOLOMBO - ANTIOQUIA", "YONDO - ANTIOQUIA", "ZARAGOZA - ANTIOQUIA", "BARRANQUILLA - ATLANTICO", "BARANOA - ATLANTICO", "CAMPO DE LA CRUZ - ATLANTICO", "CANDELARIA - ATLANTICO", "GALAPA - ATLANTICO", "JUAN DE ACOSTA - ATLANTICO", "LURUACO - ATLANTICO", "MALAMBO - ATLANTICO", "MANATI - ATLANTICO", "PALMAR DE VARELA - ATLANTICO", "PIOJO - ATLANTICO", "POLONUEVO - ATLANTICO", "PONEDERA - ATLANTICO", "PUERTO COLOMBIA - ATLANTICO", "REPELON - ATLANTICO", "SABANAGRANDE - ATLANTICO", "SABANALARGA - ATLANTICO", "SANTA LUCIA - ATLANTICO", "SANTO TOMAS - ATLANTICO", "SOLEDAD - ATLANTICO", "SUAN - ATLANTICO", "TUBARA - ATLANTICO", "USIACURI - ATLANTICO", "BOGOTA, D.C. - BOGOTA", "CARTAGENA - BOLIVAR", "ACHI - BOLIVAR", "ALTOS DEL ROSARIO - BOLIVAR", "ARENAL - BOLIVAR", "ARJONA - BOLIVAR", "ARROYOHONDO - BOLIVAR", "BARRANCO DE LOBA - BOLIVAR", "CALAMAR - BOLIVAR", "CANTAGALLO - BOLIVAR", "CICUCO - BOLIVAR", "CORDOBA - BOLIVAR", "CLEMENCIA - BOLIVAR", "EL CARMEN DE BOLIVAR - BOLIVAR", "EL GUAMO - BOLIVAR", "EL PEÑON - BOLIVAR", "HATILLO DE LOBA - BOLIVAR", "MAGANGUE - BOLIVAR", "MAHATES - BOLIVAR", "MARGARITA - BOLIVAR", "MARIA LA BAJA - BOLIVAR", "MONTECRISTO - BOLIVAR", "MOMPOS - BOLIVAR", "NOROSI - BOLIVAR", "MORALES - BOLIVAR", "PINILLOS - BOLIVAR", "REGIDOR - BOLIVAR", "RIO VIEJO - BOLIVAR", "SAN CRISTOBAL - BOLIVAR", "SAN ESTANISLAO - BOLIVAR", "SAN FERNANDO - BOLIVAR", "SAN JACINTO - BOLIVAR", "SAN JACINTO DEL CAUCA - BOLIVAR", "SAN JUAN NEPOMUCENO - BOLIVAR", "SAN MARTIN DE LOBA - BOLIVAR", "SAN PABLO - BOLIVAR", "SANTA CATALINA - BOLIVAR", "SANTA ROSA - BOLIVAR", "SANTA ROSA DEL SUR - BOLIVAR", "SIMITI - BOLIVAR", "SOPLAVIENTO - BOLIVAR", "TALAIGUA NUEVO - BOLIVAR", "TIQUISIO - BOLIVAR", "TURBACO - BOLIVAR", "TURBANA - BOLIVAR", "VILLANUEVA - BOLIVAR", "ZAMBRANO - BOLIVAR", "TUNJA - BOYACA", "ALMEIDA - BOYACA", "AQUITANIA - BOYACA", "ARCABUCO - BOYACA", "BELEN - BOYACA", "BERBEO - BOYACA", "BETEITIVA - BOYACA", "BOAVITA - BOYACA", "BOYACA - BOYACA", "BRICEÑO - BOYACA", "BUENAVISTA - BOYACA", "BUSBANZA - BOYACA", "CALDAS - BOYACA", "CAMPOHERMOSO - BOYACA", "CERINZA - BOYACA", "CHINAVITA - BOYACA", "CHIQUINQUIRA - BOYACA", "CHISCAS - BOYACA", "CHITA - BOYACA", "CHITARAQUE - BOYACA", "CHIVATA - BOYACA", "CIENEGA - BOYACA", "COMBITA - BOYACA", "COPER - BOYACA", "CORRALES - BOYACA", "COVARACHIA - BOYACA", "CUBARA - BOYACA", "CUCAITA - BOYACA", "CUITIVA - BOYACA", "CHIQUIZA - BOYACA", "CHIVOR - BOYACA", "DUITAMA - BOYACA", "EL COCUY - BOYACA", "EL ESPINO - BOYACA", "FIRAVITOBA - BOYACA", "FLORESTA - BOYACA", "GACHANTIVA - BOYACA", "GAMEZA - BOYACA", "GARAGOA - BOYACA", "GUACAMAYAS - BOYACA", "GUATEQUE - BOYACA", "GUAYATA - BOYACA", "GsICAN - BOYACA", "IZA - BOYACA", "JENESANO - BOYACA", "JERICO - BOYACA", "LABRANZAGRANDE - BOYACA", "LA CAPILLA - BOYACA", "LA VICTORIA - BOYACA", "LA UVITA - BOYACA", "VILLA DE LEYVA - BOYACA", "MACANAL - BOYACA", "MARIPI - BOYACA", "MIRAFLORES - BOYACA", "MONGUA - BOYACA", "MONGUI - BOYACA", "MONIQUIRA - BOYACA", "MOTAVITA - BOYACA", "MUZO - BOYACA", "NOBSA - BOYACA", "NUEVO COLON - BOYACA", "OICATA - BOYACA", "OTANCHE - BOYACA", "PACHAVITA - BOYACA", "PAEZ - BOYACA", "PAIPA - BOYACA", "PAJARITO - BOYACA", "PANQUEBA - BOYACA", "PAUNA - BOYACA", "PAYA - BOYACA", "PAZ DE RIO - BOYACA", "PESCA - BOYACA", "PISBA - BOYACA", "PUERTO BOYACA - BOYACA", "QUIPAMA - BOYACA", "RAMIRIQUI - BOYACA", "RAQUIRA - BOYACA", "RONDON - BOYACA", "SABOYA - BOYACA", "SACHICA - BOYACA", "SAMACA - BOYACA", "SAN EDUARDO - BOYACA", "SAN JOSE DE PARE - BOYACA", "SAN LUIS DE GACENO - BOYACA", "SAN MATEO - BOYACA", "SAN MIGUEL DE SEMA - BOYACA", "SAN PABLO DE BORBUR - BOYACA", "SANTANA - BOYACA", "SANTA MARIA - BOYACA", "SANTA ROSA DE VITERBO - BOYACA", "SANTA SOFIA - BOYACA", "SATIVANORTE - BOYACA", "SATIVASUR - BOYACA", "SIACHOQUE - BOYACA", "SOATA - BOYACA", "SOCOTA - BOYACA", "SOCHA - BOYACA", "SOGAMOSO - BOYACA", "SOMONDOCO - BOYACA", "SORA - BOYACA", "SOTAQUIRA - BOYACA", "SORACA - BOYACA", "SUSACON - BOYACA", "SUTAMARCHAN - BOYACA", "SUTATENZA - BOYACA", "TASCO - BOYACA", "TENZA - BOYACA", "TIBANA - BOYACA", "TIBASOSA - BOYACA", "TINJACA - BOYACA", "TIPACOQUE - BOYACA", "TOCA - BOYACA", "TOGsI - BOYACA", "TOPAGA - BOYACA", "TOTA - BOYACA", "TUNUNGUA - BOYACA", "TURMEQUE - BOYACA", "TUTA - BOYACA", "TUTAZA - BOYACA", "UMBITA - BOYACA", "VENTAQUEMADA - BOYACA", "VIRACACHA - BOYACA", "ZETAQUIRA - BOYACA", "MANIZALES - CALDAS", "AGUADAS - CALDAS", "ANSERMA - CALDAS", "ARANZAZU - CALDAS", "BELALCAZAR - CALDAS", "CHINCHINA - CALDAS", "FILADELFIA - CALDAS", "LA DORADA - CALDAS", "LA MERCED - CALDAS", "MANZANARES - CALDAS", "MARMATO - CALDAS", "MARQUETALIA - CALDAS", "MARULANDA - CALDAS", "NEIRA - CALDAS", "NORCASIA - CALDAS", "PACORA - CALDAS", "PALESTINA - CALDAS", "PENSILVANIA - CALDAS", "RIOSUCIO - CALDAS", "RISARALDA - CALDAS", "SALAMINA - CALDAS", "SAMANA - CALDAS", "SAN JOSE - CALDAS", "SUPIA - CALDAS", "VICTORIA - CALDAS", "VILLAMARIA - CALDAS", "VITERBO - CALDAS", "FLORENCIA - CAQUETA", "ALBANIA - CAQUETA", "BELEN DE LOS ANDAQUIES - CAQUETA", "CARTAGENA DEL CHAIRA - CAQUETA", "CURILLO - CAQUETA", "EL DONCELLO - CAQUETA", "EL PAUJIL - CAQUETA", "LA MONTAÑITA - CAQUETA", "MILAN - CAQUETA", "MORELIA - CAQUETA", "PUERTO RICO - CAQUETA", "SAN JOSE DEL FRAGUA - CAQUETA", "SAN VICENTE DEL CAGUAN - CAQUETA", "SOLANO - CAQUETA", "SOLITA - CAQUETA", "VALPARAISO - CAQUETA", "POPAYAN - CAUCA", "ALMAGUER - CAUCA", "ARGELIA - CAUCA", "BALBOA - CAUCA", "BOLIVAR - CAUCA", "BUENOS AIRES - CAUCA", "CAJIBIO - CAUCA", "CALDONO - CAUCA", "CALOTO - CAUCA", "CORINTO - CAUCA", "EL TAMBO - CAUCA", "FLORENCIA - CAUCA", "GUACHENE - CAUCA", "GUAPI - CAUCA", "INZA - CAUCA", "JAMBALO - CAUCA", "LA SIERRA - CAUCA", "LA VEGA - CAUCA", "LOPEZ - CAUCA", "MERCADERES - CAUCA", "MIRANDA - CAUCA", "MORALES - CAUCA", "PADILLA - CAUCA", "PAEZ - CAUCA", "PATIA - CAUCA", "PIAMONTE - CAUCA", "PIENDAMO - CAUCA", "PUERTO TEJADA - CAUCA", "PURACE - CAUCA", "ROSAS - CAUCA", "SAN SEBASTIAN - CAUCA", "SANTANDER DE QUILICHAO - CAUCA", "SANTA ROSA - CAUCA", "SILVIA - CAUCA", "SOTARA - CAUCA", "SUAREZ - CAUCA", "SUCRE - CAUCA", "TIMBIO - CAUCA", "TIMBIQUI - CAUCA", "TORIBIO - CAUCA", "TOTORO - CAUCA", "VILLA RICA - CAUCA", "VALLEDUPAR - CESAR", "AGUACHICA - CESAR", "AGUSTIN CODAZZI - CESAR", "ASTREA - CESAR", "BECERRIL - CESAR", "BOSCONIA - CESAR", "CHIMICHAGUA - CESAR", "CHIRIGUANA - CESAR", "CURUMANI - CESAR", "EL COPEY - CESAR", "EL PASO - CESAR", "GAMARRA - CESAR", "GONZALEZ - CESAR", "LA GLORIA - CESAR", "LA JAGUA DE IBIRICO - CESAR", "MANAURE - CESAR", "PAILITAS - CESAR", "PELAYA - CESAR", "PUEBLO BELLO - CESAR", "RIO DE ORO - CESAR", "LA PAZ - CESAR", "SAN ALBERTO - CESAR", "SAN DIEGO - CESAR", "SAN MARTIN - CESAR", "TAMALAMEQUE - CESAR", "MONTERIA - CORDOBA", "AYAPEL - CORDOBA", "BUENAVISTA - CORDOBA", "CANALETE - CORDOBA", "CERETE - CORDOBA", "CHIMA - CORDOBA", "CHINU - CORDOBA", "CIENAGA DE ORO - CORDOBA", "COTORRA - CORDOBA", "LA APARTADA - CORDOBA", "LORICA - CORDOBA", "LOS CORDOBAS - CORDOBA", "MOMIL - CORDOBA", "MONTELIBANO - CORDOBA", "MOÑITOS - CORDOBA", "PLANETA RICA - CORDOBA", "PUEBLO NUEVO - CORDOBA", "PUERTO ESCONDIDO - CORDOBA", "PUERTO LIBERTADOR - CORDOBA", "PURISIMA - CORDOBA", "SAHAGUN - CORDOBA", "SAN ANDRES SOTAVENTO - CORDOBA", "SAN ANTERO - CORDOBA", "SAN BERNARDO DEL VIENTO - CORDOBA", "SAN CARLOS - CORDOBA", "SAN PELAYO - CORDOBA", "TIERRALTA - CORDOBA", "VALENCIA - CORDOBA", "AGUA DE DIOS - CUNDINAMARCA", "ALBAN - CUNDINAMARCA", "ANAPOIMA - CUNDINAMARCA", "ANOLAIMA - CUNDINAMARCA", "ARBELAEZ - CUNDINAMARCA", "BELTRAN - CUNDINAMARCA", "BITUIMA - CUNDINAMARCA", "BOJACA - CUNDINAMARCA", "CABRERA - CUNDINAMARCA", "CACHIPAY - CUNDINAMARCA", "CAJICA - CUNDINAMARCA", "CAPARRAPI - CUNDINAMARCA", "CAQUEZA - CUNDINAMARCA", "CARMEN DE CARUPA - CUNDINAMARCA", "CHAGUANI - CUNDINAMARCA", "CHIA - CUNDINAMARCA", "CHIPAQUE - CUNDINAMARCA", "CHOACHI - CUNDINAMARCA", "CHOCONTA - CUNDINAMARCA", "COGUA - CUNDINAMARCA", "COTA - CUNDINAMARCA", "CUCUNUBA - CUNDINAMARCA", "EL COLEGIO - CUNDINAMARCA", "EL PEÑON - CUNDINAMARCA", "EL ROSAL - CUNDINAMARCA", "FACATATIVA - CUNDINAMARCA", "FOMEQUE - CUNDINAMARCA", "FOSCA - CUNDINAMARCA", "FUNZA - CUNDINAMARCA", "FUQUENE - CUNDINAMARCA", "FUSAGASUGA - CUNDINAMARCA", "GACHALA - CUNDINAMARCA", "GACHANCIPA - CUNDINAMARCA", "GACHETA - CUNDINAMARCA", "GAMA - CUNDINAMARCA", "GIRARDOT - CUNDINAMARCA", "GRANADA - CUNDINAMARCA", "GUACHETA - CUNDINAMARCA", "GUADUAS - CUNDINAMARCA", "GUASCA - CUNDINAMARCA", "GUATAQUI - CUNDINAMARCA", "GUATAVITA - CUNDINAMARCA", "GUAYABAL DE SIQUIMA - CUNDINAMARCA", "GUAYABETAL - CUNDINAMARCA", "GUTIERREZ - CUNDINAMARCA", "JERUSALEN - CUNDINAMARCA", "JUNIN - CUNDINAMARCA", "LA CALERA - CUNDINAMARCA", "LA MESA - CUNDINAMARCA", "LA PALMA - CUNDINAMARCA", "LA PEÑA - CUNDINAMARCA", "LA VEGA - CUNDINAMARCA", "LENGUAZAQUE - CUNDINAMARCA", "MACHETA - CUNDINAMARCA", "MADRID - CUNDINAMARCA", "MANTA - CUNDINAMARCA", "MEDINA - CUNDINAMARCA", "MOSQUERA - CUNDINAMARCA", "NARIÑO - CUNDINAMARCA", "NEMOCON - CUNDINAMARCA", "NILO - CUNDINAMARCA", "NIMAIMA - CUNDINAMARCA", "NOCAIMA - CUNDINAMARCA", "VENECIA - CUNDINAMARCA", "PACHO - CUNDINAMARCA", "PAIME - CUNDINAMARCA", "PANDI - CUNDINAMARCA", "PARATEBUENO - CUNDINAMARCA", "PASCA - CUNDINAMARCA", "PUERTO SALGAR - CUNDINAMARCA", "PULI - CUNDINAMARCA", "QUEBRADANEGRA - CUNDINAMARCA", "QUETAME - CUNDINAMARCA", "QUIPILE - CUNDINAMARCA", "APULO - CUNDINAMARCA", "RICAURTE - CUNDINAMARCA", "SAN ANTONIO DEL TEQUENDAMA - CUNDINAMARCA", "SAN BERNARDO - CUNDINAMARCA", "SAN CAYETANO - CUNDINAMARCA", "SAN FRANCISCO - CUNDINAMARCA", "SAN JUAN DE RIO SECO - CUNDINAMARCA", "SASAIMA - CUNDINAMARCA", "SESQUILE - CUNDINAMARCA", "SIBATE - CUNDINAMARCA", "SILVANIA - CUNDINAMARCA", "SIMIJACA - CUNDINAMARCA", "SOACHA - CUNDINAMARCA", "SOPO - CUNDINAMARCA", "SUBACHOQUE - CUNDINAMARCA", "SUESCA - CUNDINAMARCA", "SUPATA - CUNDINAMARCA", "SUSA - CUNDINAMARCA", "SUTATAUSA - CUNDINAMARCA", "TABIO - CUNDINAMARCA", "TAUSA - CUNDINAMARCA", "TENA - CUNDINAMARCA", "TENJO - CUNDINAMARCA", "TIBACUY - CUNDINAMARCA", "TIBIRITA - CUNDINAMARCA", "TOCAIMA - CUNDINAMARCA", "TOCANCIPA - CUNDINAMARCA", "TOPAIPI - CUNDINAMARCA", "UBALA - CUNDINAMARCA", "UBAQUE - CUNDINAMARCA", "VILLA DE SAN DIEGO DE UBATE - CUNDINAMARCA", "UNE - CUNDINAMARCA", "UTICA - CUNDINAMARCA", "VERGARA - CUNDINAMARCA", "VIANI - CUNDINAMARCA", "VILLAGOMEZ - CUNDINAMARCA", "VILLAPINZON - CUNDINAMARCA", "VILLETA - CUNDINAMARCA", "VIOTA - CUNDINAMARCA", "YACOPI - CUNDINAMARCA", "ZIPACON - CUNDINAMARCA", "ZIPAQUIRA - CUNDINAMARCA", "QUIBDO - CHOCO", "ACANDI - CHOCO", "ALTO BAUDO - CHOCO", "ATRATO - CHOCO", "BAGADO - CHOCO", "BAHIA SOLANO - CHOCO", "BAJO BAUDO - CHOCO", "BOJAYA - CHOCO", "EL CANTON DEL SAN PABLO - CHOCO", "CARMEN DEL DARIEN - CHOCO", "CERTEGUI - CHOCO", "CONDOTO - CHOCO", "EL CARMEN DE ATRATO - CHOCO", "EL LITORAL DEL SAN JUAN - CHOCO", "ISTMINA - CHOCO", "JURADO - CHOCO", "LLORO - CHOCO", "MEDIO ATRATO - CHOCO", "MEDIO BAUDO - CHOCO", "MEDIO SAN JUAN - CHOCO", "NOVITA - CHOCO", "NUQUI - CHOCO", "RIO IRO - CHOCO", "RIO QUITO - CHOCO", "RIOSUCIO - CHOCO", "SAN JOSE DEL PALMAR - CHOCO", "SIPI - CHOCO", "TADO - CHOCO", "UNGUIA - CHOCO", "UNION PANAMERICANA - CHOCO", "NEIVA - HUILA", "ACEVEDO - HUILA", "AGRADO - HUILA", "AIPE - HUILA", "ALGECIRAS - HUILA", "ALTAMIRA - HUILA", "BARAYA - HUILA", "CAMPOALEGRE - HUILA", "COLOMBIA - HUILA", "ELIAS - HUILA", "GARZON - HUILA", "GIGANTE - HUILA", "GUADALUPE - HUILA", "HOBO - HUILA", "IQUIRA - HUILA", "ISNOS - HUILA", "LA ARGENTINA - HUILA", "LA PLATA - HUILA", "NATAGA - HUILA", "OPORAPA - HUILA", "PAICOL - HUILA", "PALERMO - HUILA", "PALESTINA - HUILA", "PITAL - HUILA", "PITALITO - HUILA", "RIVERA - HUILA", "SALADOBLANCO - HUILA", "SAN AGUSTIN - HUILA", "SANTA MARIA - HUILA", "SUAZA - HUILA", "TARQUI - HUILA", "TESALIA - HUILA", "TELLO - HUILA", "TERUEL - HUILA", "TIMANA - HUILA", "VILLAVIEJA - HUILA", "YAGUARA - HUILA", "RIOHACHA - LA GUAJIRA", "ALBANIA - LA GUAJIRA", "BARRANCAS - LA GUAJIRA", "DIBULLA - LA GUAJIRA", "DISTRACCION - LA GUAJIRA", "EL MOLINO - LA GUAJIRA", "FONSECA - LA GUAJIRA", "HATONUEVO - LA GUAJIRA", "LA JAGUA DEL PILAR - LA GUAJIRA", "MAICAO - LA GUAJIRA", "MANAURE - LA GUAJIRA", "SAN JUAN DEL CESAR - LA GUAJIRA", "URIBIA - LA GUAJIRA", "URUMITA - LA GUAJIRA", "VILLANUEVA - LA GUAJIRA", "SANTA MARTA - MAGDALENA", "ALGARROBO - MAGDALENA", "ARACATACA - MAGDALENA", "ARIGUANI - MAGDALENA", "CERRO SAN ANTONIO - MAGDALENA", "CHIBOLO - MAGDALENA", "CIENAGA - MAGDALENA", "CONCORDIA - MAGDALENA", "EL BANCO - MAGDALENA", "EL PIÑON - MAGDALENA", "EL RETEN - MAGDALENA", "FUNDACION - MAGDALENA", "GUAMAL - MAGDALENA", "NUEVA GRANADA - MAGDALENA", "PEDRAZA - MAGDALENA", "PIJIÑO DEL CARMEN - MAGDALENA", "PIVIJAY - MAGDALENA", "PLATO - MAGDALENA", "PUEBLOVIEJO - MAGDALENA", "REMOLINO - MAGDALENA", "SABANAS DE SAN ANGEL - MAGDALENA", "SALAMINA - MAGDALENA", "SAN SEBASTIAN DE BUENAVISTA - MAGDALENA", "SAN ZENON - MAGDALENA", "SANTA ANA - MAGDALENA", "SANTA BARBARA DE PINTO - MAGDALENA", "SITIONUEVO - MAGDALENA", "TENERIFE - MAGDALENA", "ZAPAYAN - MAGDALENA", "ZONA BANANERA - MAGDALENA", "VILLAVICENCIO - META", "ACACIAS - META", "BARRANCA DE UPIA - META", "CABUYARO - META", "CASTILLA LA NUEVA - META", "CUBARRAL - META", "CUMARAL - META", "EL CALVARIO - META", "EL CASTILLO - META", "EL DORADO - META", "FUENTE DE ORO - META", "GRANADA - META", "GUAMAL - META", "MAPIRIPAN - META", "MESETAS - META", "LA MACARENA - META", "URIBE - META", "LEJANIAS - META", "PUERTO CONCORDIA - META", "PUERTO GAITAN - META", "PUERTO LOPEZ - META", "PUERTO LLERAS - META", "PUERTO RICO - META", "RESTREPO - META", "SAN CARLOS DE GUAROA - META", "SAN JUAN DE ARAMA - META", "SAN JUANITO - META", "SAN MARTIN - META", "VISTAHERMOSA - META", "PASTO - NARIÑO", "ALBAN - NARIÑO", "ALDANA - NARIÑO", "ANCUYA - NARIÑO", "ARBOLEDA - NARIÑO", "BARBACOAS - NARIÑO", "BELEN - NARIÑO", "BUESACO - NARIÑO", "COLON - NARIÑO", "CONSACA - NARIÑO", "CONTADERO - NARIÑO", "CORDOBA - NARIÑO", "CUASPUD - NARIÑO", "CUMBAL - NARIÑO", "CUMBITARA - NARIÑO", "CHACHAGsI - NARIÑO", "EL CHARCO - NARIÑO", "EL PEÑOL - NARIÑO", "EL ROSARIO - NARIÑO", "EL TABLON DE GOMEZ - NARIÑO", "EL TAMBO - NARIÑO", "FUNES - NARIÑO", "GUACHUCAL - NARIÑO", "GUAITARILLA - NARIÑO", "GUALMATAN - NARIÑO", "ILES - NARIÑO", "IMUES - NARIÑO", "IPIALES - NARIÑO", "LA CRUZ - NARIÑO", "LA FLORIDA - NARIÑO", "LA LLANADA - NARIÑO", "LA TOLA - NARIÑO", "LA UNION - NARIÑO", "LEIVA - NARIÑO", "LINARES - NARIÑO", "LOS ANDES - NARIÑO", "MAGsI - NARIÑO", "MALLAMA - NARIÑO", "MOSQUERA - NARIÑO", "NARIÑO - NARIÑO", "OLAYA HERRERA - NARIÑO", "OSPINA - NARIÑO", "FRANCISCO PIZARRO - NARIÑO", "POLICARPA - NARIÑO", "POTOSI - NARIÑO", "PROVIDENCIA - NARIÑO", "PUERRES - NARIÑO", "PUPIALES - NARIÑO", "RICAURTE - NARIÑO", "ROBERTO PAYAN - NARIÑO", "SAMANIEGO - NARIÑO", "SANDONA - NARIÑO", "SAN BERNARDO - NARIÑO", "SAN LORENZO - NARIÑO", "SAN PABLO - NARIÑO", "SAN PEDRO DE CARTAGO - NARIÑO", "SANTA BARBARA - NARIÑO", "SANTACRUZ - NARIÑO", "SAPUYES - NARIÑO", "TAMINANGO - NARIÑO", "TANGUA - NARIÑO", "SAN ANDRES DE TUMACO - NARIÑO", "TUQUERRES - NARIÑO", "YACUANQUER - NARIÑO", "CUCUTA - N. DE SANTANDER", "ABREGO - N. DE SANTANDER", "ARBOLEDAS - N. DE SANTANDER", "BOCHALEMA - N. DE SANTANDER", "BUCARASICA - N. DE SANTANDER", "CACOTA - N. DE SANTANDER", "CACHIRA - N. DE SANTANDER", "CHINACOTA - N. DE SANTANDER", "CHITAGA - N. DE SANTANDER", "CONVENCION - N. DE SANTANDER", "CUCUTILLA - N. DE SANTANDER", "DURANIA - N. DE SANTANDER", "EL CARMEN - N. DE SANTANDER", "EL TARRA - N. DE SANTANDER", "EL ZULIA - N. DE SANTANDER", "GRAMALOTE - N. DE SANTANDER", "HACARI - N. DE SANTANDER", "HERRAN - N. DE SANTANDER", "LABATECA - N. DE SANTANDER", "LA ESPERANZA - N. DE SANTANDER", "LA PLAYA - N. DE SANTANDER", "LOS PATIOS - N. DE SANTANDER", "LOURDES - N. DE SANTANDER", "MUTISCUA - N. DE SANTANDER", "OCAÑA - N. DE SANTANDER", "PAMPLONA - N. DE SANTANDER", "PAMPLONITA - N. DE SANTANDER", "PUERTO SANTANDER - N. DE SANTANDER", "RAGONVALIA - N. DE SANTANDER", "SALAZAR - N. DE SANTANDER", "SAN CALIXTO - N. DE SANTANDER", "SAN CAYETANO - N. DE SANTANDER", "SANTIAGO - N. DE SANTANDER", "SARDINATA - N. DE SANTANDER", "SILOS - N. DE SANTANDER", "TEORAMA - N. DE SANTANDER", "TIBU - N. DE SANTANDER", "TOLEDO - N. DE SANTANDER", "VILLA CARO - N. DE SANTANDER", "VILLA DEL ROSARIO - N. DE SANTANDER", "ARMENIA - QUINDIO", "BUENAVISTA - QUINDIO", "CALARCA - QUINDIO", "CIRCASIA - QUINDIO", "CORDOBA - QUINDIO", "FILANDIA - QUINDIO", "GENOVA - QUINDIO", "LA TEBAIDA - QUINDIO", "MONTENEGRO - QUINDIO", "PIJAO - QUINDIO", "QUIMBAYA - QUINDIO", "SALENTO - QUINDIO", "PEREIRA - RISARALDA", "APIA - RISARALDA", "BALBOA - RISARALDA", "BELEN DE UMBRIA - RISARALDA", "DOSQUEBRADAS - RISARALDA", "GUATICA - RISARALDA", "LA CELIA - RISARALDA", "LA VIRGINIA - RISARALDA", "MARSELLA - RISARALDA", "MISTRATO - RISARALDA", "PUEBLO RICO - RISARALDA", "QUINCHIA - RISARALDA", "SANTA ROSA DE CABAL - RISARALDA", "SANTUARIO - RISARALDA", "BUCARAMANGA - SANTANDER", "AGUADA - SANTANDER", "ALBANIA - SANTANDER", "ARATOCA - SANTANDER", "BARBOSA - SANTANDER", "BARICHARA - SANTANDER", "BARRANCABERMEJA - SANTANDER", "BETULIA - SANTANDER", "BOLIVAR - SANTANDER", "CABRERA - SANTANDER", "CALIFORNIA - SANTANDER", "CAPITANEJO - SANTANDER", "CARCASI - SANTANDER", "CEPITA - SANTANDER", "CERRITO - SANTANDER", "CHARALA - SANTANDER", "CHARTA - SANTANDER", "CHIMA - SANTANDER", "CHIPATA - SANTANDER", "CIMITARRA - SANTANDER", "CONCEPCION - SANTANDER", "CONFINES - SANTANDER", "CONTRATACION - SANTANDER", "COROMORO - SANTANDER", "CURITI - SANTANDER", "EL CARMEN DE CHUCURI - SANTANDER", "EL GUACAMAYO - SANTANDER", "EL PEÑON - SANTANDER", "EL PLAYON - SANTANDER", "ENCINO - SANTANDER", "ENCISO - SANTANDER", "FLORIAN - SANTANDER", "FLORIDABLANCA - SANTANDER", "GALAN - SANTANDER", "GAMBITA - SANTANDER", "GIRON - SANTANDER", "GUACA - SANTANDER", "GUADALUPE - SANTANDER", "GUAPOTA - SANTANDER", "GUAVATA - SANTANDER", "GsEPSA - SANTANDER", "HATO - SANTANDER", "JESUS MARIA - SANTANDER", "JORDAN - SANTANDER", "LA BELLEZA - SANTANDER", "LANDAZURI - SANTANDER", "LA PAZ - SANTANDER", "LEBRIJA - SANTANDER", "LOS SANTOS - SANTANDER", "MACARAVITA - SANTANDER", "MALAGA - SANTANDER", "MATANZA - SANTANDER", "MOGOTES - SANTANDER", "MOLAGAVITA - SANTANDER", "OCAMONTE - SANTANDER", "OIBA - SANTANDER", "ONZAGA - SANTANDER", "PALMAR - SANTANDER", "PALMAS DEL SOCORRO - SANTANDER", "PARAMO - SANTANDER", "PIEDECUESTA - SANTANDER", "PINCHOTE - SANTANDER", "PUENTE NACIONAL - SANTANDER", "PUERTO PARRA - SANTANDER", "PUERTO WILCHES - SANTANDER", "RIONEGRO - SANTANDER", "SABANA DE TORRES - SANTANDER", "SAN ANDRES - SANTANDER", "SAN BENITO - SANTANDER", "SAN GIL - SANTANDER", "SAN JOAQUIN - SANTANDER", "SAN JOSE DE MIRANDA - SANTANDER", "SAN MIGUEL - SANTANDER", "SAN VICENTE DE CHUCURI - SANTANDER", "SANTA BARBARA - SANTANDER", "SANTA HELENA DEL OPON - SANTANDER", "SIMACOTA - SANTANDER", "SOCORRO - SANTANDER", "SUAITA - SANTANDER", "SUCRE - SANTANDER", "SURATA - SANTANDER", "TONA - SANTANDER", "VALLE DE SAN JOSE - SANTANDER", "VELEZ - SANTANDER", "VETAS - SANTANDER", "VILLANUEVA - SANTANDER", "ZAPATOCA - SANTANDER", "SINCELEJO - SUCRE", "BUENAVISTA - SUCRE", "CAIMITO - SUCRE", "COLOSO - SUCRE", "COROZAL - SUCRE", "COVEÑAS - SUCRE", "CHALAN - SUCRE", "EL ROBLE - SUCRE", "GALERAS - SUCRE", "GUARANDA - SUCRE", "LA UNION - SUCRE", "LOS PALMITOS - SUCRE", "MAJAGUAL - SUCRE", "MORROA - SUCRE", "OVEJAS - SUCRE", "PALMITO - SUCRE", "SAMPUES - SUCRE", "SAN BENITO ABAD - SUCRE", "SAN JUAN DE BETULIA - SUCRE", "SAN MARCOS - SUCRE", "SAN ONOFRE - SUCRE", "SAN PEDRO - SUCRE", "SAN LUIS DE SINCE - SUCRE", "SUCRE - SUCRE", "SANTIAGO DE TOLU - SUCRE", "TOLU VIEJO - SUCRE", "IBAGUE - TOLIMA", "ALPUJARRA - TOLIMA", "ALVARADO - TOLIMA", "AMBALEMA - TOLIMA", "ANZOATEGUI - TOLIMA", "ARMERO - TOLIMA", "ATACO - TOLIMA", "CAJAMARCA - TOLIMA", "CARMEN DE APICALA - TOLIMA", "CASABIANCA - TOLIMA", "CHAPARRAL - TOLIMA", "COELLO - TOLIMA", "COYAIMA - TOLIMA", "CUNDAY - TOLIMA", "DOLORES - TOLIMA", "ESPINAL - TOLIMA", "FALAN - TOLIMA", "FLANDES - TOLIMA", "FRESNO - TOLIMA", "GUAMO - TOLIMA", "HERVEO - TOLIMA", "HONDA - TOLIMA", "ICONONZO - TOLIMA", "LERIDA - TOLIMA", "LIBANO - TOLIMA", "MARIQUITA - TOLIMA", "MELGAR - TOLIMA", "MURILLO - TOLIMA", "NATAGAIMA - TOLIMA", "ORTEGA - TOLIMA", "PALOCABILDO - TOLIMA", "PIEDRAS - TOLIMA", "PLANADAS - TOLIMA", "PRADO - TOLIMA", "PURIFICACION - TOLIMA", "RIOBLANCO - TOLIMA", "RONCESVALLES - TOLIMA", "ROVIRA - TOLIMA", "SALDAÑA - TOLIMA", "SAN ANTONIO - TOLIMA", "SAN LUIS - TOLIMA", "SANTA ISABEL - TOLIMA", "SUAREZ - TOLIMA", "VALLE DE SAN JUAN - TOLIMA", "VENADILLO - TOLIMA", "VILLAHERMOSA - TOLIMA", "VILLARRICA - TOLIMA", "CALI - VALLE DEL CAUCA", "ALCALA - VALLE DEL CAUCA", "ANDALUCIA - VALLE DEL CAUCA", "ANSERMANUEVO - VALLE DEL CAUCA", "ARGELIA - VALLE DEL CAUCA", "BOLIVAR - VALLE DEL CAUCA", "BUENAVENTURA - VALLE DEL CAUCA", "GUADALAJARA DE BUGA - VALLE DEL CAUCA", "BUGALAGRANDE - VALLE DEL CAUCA", "CAICEDONIA - VALLE DEL CAUCA", "CALIMA - VALLE DEL CAUCA", "CANDELARIA - VALLE DEL CAUCA", "CARTAGO - VALLE DEL CAUCA", "DAGUA - VALLE DEL CAUCA", "EL AGUILA - VALLE DEL CAUCA", "EL CAIRO - VALLE DEL CAUCA", "EL CERRITO - VALLE DEL CAUCA", "EL DOVIO - VALLE DEL CAUCA", "FLORIDA - VALLE DEL CAUCA", "GINEBRA - VALLE DEL CAUCA", "GUACARI - VALLE DEL CAUCA", "JAMUNDI - VALLE DEL CAUCA", "LA CUMBRE - VALLE DEL CAUCA", "LA UNION - VALLE DEL CAUCA", "LA VICTORIA - VALLE DEL CAUCA", "OBANDO - VALLE DEL CAUCA", "PALMIRA - VALLE DEL CAUCA", "PRADERA - VALLE DEL CAUCA", "RESTREPO - VALLE DEL CAUCA", "RIOFRIO - VALLE DEL CAUCA", "ROLDANILLO - VALLE DEL CAUCA", "SAN PEDRO - VALLE DEL CAUCA", "SEVILLA - VALLE DEL CAUCA", "TORO - VALLE DEL CAUCA", "TRUJILLO - VALLE DEL CAUCA", "TULUA - VALLE DEL CAUCA", "ULLOA - VALLE DEL CAUCA", "VERSALLES - VALLE DEL CAUCA", "VIJES - VALLE DEL CAUCA", "YOTOCO - VALLE DEL CAUCA", "YUMBO - VALLE DEL CAUCA", "ZARZAL - VALLE DEL CAUCA", "ARAUCA - ARAUCA", "ARAUQUITA - ARAUCA", "CRAVO NORTE - ARAUCA", "FORTUL - ARAUCA", "PUERTO RONDON - ARAUCA", "SARAVENA - ARAUCA", "TAME - ARAUCA", "YOPAL - CASANARE", "AGUAZUL - CASANARE", "CHAMEZA - CASANARE", "HATO COROZAL - CASANARE", "LA SALINA - CASANARE", "MANI - CASANARE", "MONTERREY - CASANARE", "NUNCHIA - CASANARE", "OROCUE - CASANARE", "PAZ DE ARIPORO - CASANARE", "PORE - CASANARE", "RECETOR - CASANARE", "SABANALARGA - CASANARE", "SACAMA - CASANARE", "SAN LUIS DE PALENQUE - CASANARE", "TAMARA - CASANARE", "TAURAMENA - CASANARE", "TRINIDAD - CASANARE", "VILLANUEVA - CASANARE", "MOCOA - PUTUMAYO", "COLON - PUTUMAYO", "ORITO - PUTUMAYO", "PUERTO ASIS - PUTUMAYO", "PUERTO CAICEDO - PUTUMAYO", "PUERTO GUZMAN - PUTUMAYO", "LEGUIZAMO - PUTUMAYO", "SIBUNDOY - PUTUMAYO", "SAN FRANCISCO - PUTUMAYO", "SAN MIGUEL - PUTUMAYO", "SANTIAGO - PUTUMAYO", "VALLE DEL GUAMUEZ - PUTUMAYO", "VILLAGARZON - PUTUMAYO", "SAN ANDRES - SAN ANDRES", "PROVIDENCIA - SAN ANDRES", "LETICIA - AMAZONAS", "EL ENCANTO - AMAZONAS", "LA CHORRERA - AMAZONAS", "LA PEDRERA - AMAZONAS", "LA VICTORIA - AMAZONAS", "MIRITI - PARANA - AMAZONAS", "PUERTO ALEGRIA - AMAZONAS", "PUERTO ARICA - AMAZONAS", "PUERTO NARIÑO - AMAZONAS", "PUERTO SANTANDER - AMAZONAS", "TARAPACA - AMAZONAS", "INIRIDA - GUAINIA", "BARRANCO MINAS - GUAINIA", "MAPIRIPANA - GUAINIA", "SAN FELIPE - GUAINIA", "PUERTO COLOMBIA - GUAINIA", "LA GUADALUPE - GUAINIA", "CACAHUAL - GUAINIA", "PANA PANA - GUAINIA", "MORICHAL - GUAINIA", "SAN JOSE DEL GUAVIARE - GUAVIARE", "CALAMAR - GUAVIARE", "EL RETORNO - GUAVIARE", "MIRAFLORES - GUAVIARE", "MITU - VAUPES", "CARURU - VAUPES", "PACOA - VAUPES", "TARAIRA - VAUPES", "PAPUNAUA - VAUPES", "YAVARATE - VAUPES", "PUERTO CARREÑO - VICHADA", "LA PRIMAVERA - VICHADA", "SANTA ROSALIA - VICHADA", "CUMARIBO - VICHADA"})
        Me.ComboBox_tipodoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox_tipodoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox_tipodoc.BackColor = System.Drawing.Color.White
        Me.ComboBox_tipodoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_tipodoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_tipodoc.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ComboBox_tipodoc.FormattingEnabled = True
        Me.ComboBox_tipodoc.Items.AddRange(New Object() {"NIT", "RUT", "Cédula de Ciudadanía"})
        Me.ComboBox_tipodoc.Location = New System.Drawing.Point(192, 75)
        Me.ComboBox_tipodoc.Name = "ComboBox_tipodoc"
        Me.ComboBox_tipodoc.Size = New System.Drawing.Size(238, 24)
        Me.ComboBox_tipodoc.TabIndex = 2
        '
        'Combo_cargo
        '
        Me.Combo_cargo.BackColor = System.Drawing.Color.White
        Me.Combo_cargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_cargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_cargo.FormattingEnabled = True
        Me.Combo_cargo.Items.AddRange(New Object() {"Gerente", "Administrador", "Administrador Local", "Administrador Bodega", "Administrador Sistema", "Ayudante", "Asistente", "Cajero", "Contador", "Conductor", "Empacador", "Mesero", "Mensajero", "Vendedor", "Soporte Técnico", "Técnico Especialista", "Domiciliario"})
        Me.Combo_cargo.Location = New System.Drawing.Point(35, 122)
        Me.Combo_cargo.Name = "Combo_cargo"
        Me.Combo_cargo.Size = New System.Drawing.Size(395, 24)
        Me.Combo_cargo.TabIndex = 3
        '
        'TextBox_salario
        '
        Me.TextBox_salario.BackColor = System.Drawing.Color.White
        Me.TextBox_salario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_salario.ForeColor = System.Drawing.Color.Black
        Me.TextBox_salario.Location = New System.Drawing.Point(244, 331)
        Me.TextBox_salario.Name = "TextBox_salario"
        Me.TextBox_salario.Size = New System.Drawing.Size(151, 24)
        Me.TextBox_salario.TabIndex = 9
        Me.TextBox_salario.Text = "0"
        Me.TextBox_salario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(243, 318)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 13)
        Me.Label13.TabIndex = 542
        Me.Label13.Text = "Salario"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label29.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label29.Location = New System.Drawing.Point(31, 17)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(186, 23)
        Me.Label29.TabIndex = 538
        Me.Label29.Text = "Datos del Empleado"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.cuadro_para_portadas2
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.TextBox_password)
        Me.Panel3.Controls.Add(Me.PictureBox4)
        Me.Panel3.Location = New System.Drawing.Point(466, 63)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(316, 116)
        Me.Panel3.TabIndex = 543
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(134, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 412
        Me.Label8.Text = "Contraseña"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_password
        '
        Me.TextBox_password.BackColor = System.Drawing.Color.White
        Me.TextBox_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_password.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TextBox_password.Location = New System.Drawing.Point(135, 36)
        Me.TextBox_password.Name = "TextBox_password"
        Me.TextBox_password.Size = New System.Drawing.Size(151, 24)
        Me.TextBox_password.TabIndex = 10
        Me.TextBox_password.UseSystemPasswordChar = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.MiClickDerecho.My.Resources.Resources.employee
        Me.PictureBox4.Location = New System.Drawing.Point(16, 20)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(98, 84)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 633
        Me.PictureBox4.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(465, 317)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 540
        Me.Label12.Text = "Estado"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.datagrid_permisos_todos)
        Me.MetroTabPage2.Controls.Add(Me.RadioButton_ADMINISTRACION)
        Me.MetroTabPage2.Controls.Add(Me.RadioButton_INFORMES)
        Me.MetroTabPage2.Controls.Add(Me.RadioButton_PAGOS)
        Me.MetroTabPage2.Controls.Add(Me.RadioButton_INVENTARIOS)
        Me.MetroTabPage2.Controls.Add(Me.RadioButton_ventas)
        Me.MetroTabPage2.Controls.Add(Me.datagrid_permisos)
        Me.MetroTabPage2.Controls.Add(Me.Button_quitar_permiso)
        Me.MetroTabPage2.Controls.Add(Me.Button_agregar_permiso)
        Me.MetroTabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 9)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(812, 381)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Permisos                  "
        Me.MetroTabPage2.VerticalScrollbar = True
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'datagrid_permisos_todos
        '
        Me.datagrid_permisos_todos.AllowUserToAddRows = False
        Me.datagrid_permisos_todos.AllowUserToDeleteRows = False
        Me.datagrid_permisos_todos.AllowUserToResizeRows = False
        Me.datagrid_permisos_todos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagrid_permisos_todos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.datagrid_permisos_todos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datagrid_permisos_todos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.datagrid_permisos_todos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_permisos_todos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.datagrid_permisos_todos.ColumnHeadersHeight = 33
        Me.datagrid_permisos_todos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid_permisos_todos.DefaultCellStyle = DataGridViewCellStyle8
        Me.datagrid_permisos_todos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagrid_permisos_todos.EnableHeadersVisualStyles = False
        Me.datagrid_permisos_todos.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.datagrid_permisos_todos.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid_permisos_todos.Location = New System.Drawing.Point(400, 115)
        Me.datagrid_permisos_todos.MultiSelect = False
        Me.datagrid_permisos_todos.Name = "datagrid_permisos_todos"
        Me.datagrid_permisos_todos.ReadOnly = True
        Me.datagrid_permisos_todos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_permisos_todos.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.datagrid_permisos_todos.RowHeadersVisible = False
        Me.datagrid_permisos_todos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.datagrid_permisos_todos.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.datagrid_permisos_todos.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.datagrid_permisos_todos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.datagrid_permisos_todos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.datagrid_permisos_todos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.datagrid_permisos_todos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.datagrid_permisos_todos.RowTemplate.Height = 28
        Me.datagrid_permisos_todos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid_permisos_todos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrid_permisos_todos.Size = New System.Drawing.Size(395, 263)
        Me.datagrid_permisos_todos.TabIndex = 780
        '
        'RadioButton_ADMINISTRACION
        '
        Me.RadioButton_ADMINISTRACION.AutoSize = True
        Me.RadioButton_ADMINISTRACION.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.RadioButton_ADMINISTRACION.ForeColor = System.Drawing.Color.White
        Me.RadioButton_ADMINISTRACION.Location = New System.Drawing.Point(301, 41)
        Me.RadioButton_ADMINISTRACION.Name = "RadioButton_ADMINISTRACION"
        Me.RadioButton_ADMINISTRACION.Padding = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.RadioButton_ADMINISTRACION.Size = New System.Drawing.Size(142, 23)
        Me.RadioButton_ADMINISTRACION.TabIndex = 779
        Me.RadioButton_ADMINISTRACION.TabStop = True
        Me.RadioButton_ADMINISTRACION.Text = "ADMINISTRACION"
        Me.RadioButton_ADMINISTRACION.UseVisualStyleBackColor = False
        '
        'RadioButton_INFORMES
        '
        Me.RadioButton_INFORMES.AutoSize = True
        Me.RadioButton_INFORMES.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.RadioButton_INFORMES.ForeColor = System.Drawing.Color.White
        Me.RadioButton_INFORMES.Location = New System.Drawing.Point(186, 41)
        Me.RadioButton_INFORMES.Name = "RadioButton_INFORMES"
        Me.RadioButton_INFORMES.Padding = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.RadioButton_INFORMES.Size = New System.Drawing.Size(99, 23)
        Me.RadioButton_INFORMES.TabIndex = 778
        Me.RadioButton_INFORMES.TabStop = True
        Me.RadioButton_INFORMES.Text = "INFORMES"
        Me.RadioButton_INFORMES.UseVisualStyleBackColor = False
        '
        'RadioButton_PAGOS
        '
        Me.RadioButton_PAGOS.AutoSize = True
        Me.RadioButton_PAGOS.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.RadioButton_PAGOS.ForeColor = System.Drawing.Color.White
        Me.RadioButton_PAGOS.Location = New System.Drawing.Point(18, 41)
        Me.RadioButton_PAGOS.Name = "RadioButton_PAGOS"
        Me.RadioButton_PAGOS.Padding = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.RadioButton_PAGOS.Size = New System.Drawing.Size(151, 23)
        Me.RadioButton_PAGOS.TabIndex = 777
        Me.RadioButton_PAGOS.TabStop = True
        Me.RadioButton_PAGOS.Text = "PAGOS/RECAUDOS"
        Me.RadioButton_PAGOS.UseVisualStyleBackColor = False
        '
        'RadioButton_INVENTARIOS
        '
        Me.RadioButton_INVENTARIOS.AutoSize = True
        Me.RadioButton_INVENTARIOS.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.RadioButton_INVENTARIOS.ForeColor = System.Drawing.Color.White
        Me.RadioButton_INVENTARIOS.Location = New System.Drawing.Point(118, 11)
        Me.RadioButton_INVENTARIOS.Name = "RadioButton_INVENTARIOS"
        Me.RadioButton_INVENTARIOS.Padding = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.RadioButton_INVENTARIOS.Size = New System.Drawing.Size(119, 23)
        Me.RadioButton_INVENTARIOS.TabIndex = 776
        Me.RadioButton_INVENTARIOS.TabStop = True
        Me.RadioButton_INVENTARIOS.Text = "INVENTARIOS"
        Me.RadioButton_INVENTARIOS.UseVisualStyleBackColor = False
        '
        'RadioButton_ventas
        '
        Me.RadioButton_ventas.AutoSize = True
        Me.RadioButton_ventas.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.RadioButton_ventas.ForeColor = System.Drawing.Color.White
        Me.RadioButton_ventas.Location = New System.Drawing.Point(18, 11)
        Me.RadioButton_ventas.Name = "RadioButton_ventas"
        Me.RadioButton_ventas.Padding = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.RadioButton_ventas.Size = New System.Drawing.Size(84, 23)
        Me.RadioButton_ventas.TabIndex = 775
        Me.RadioButton_ventas.TabStop = True
        Me.RadioButton_ventas.Text = "VENTAS"
        Me.RadioButton_ventas.UseVisualStyleBackColor = False
        '
        'datagrid_permisos
        '
        Me.datagrid_permisos.AllowUserToAddRows = False
        Me.datagrid_permisos.AllowUserToDeleteRows = False
        Me.datagrid_permisos.AllowUserToResizeRows = False
        Me.datagrid_permisos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagrid_permisos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.datagrid_permisos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datagrid_permisos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.datagrid_permisos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_permisos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.datagrid_permisos.ColumnHeadersHeight = 33
        Me.datagrid_permisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid_permisos.DefaultCellStyle = DataGridViewCellStyle12
        Me.datagrid_permisos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagrid_permisos.EnableHeadersVisualStyles = False
        Me.datagrid_permisos.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.datagrid_permisos.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid_permisos.Location = New System.Drawing.Point(3, 74)
        Me.datagrid_permisos.MultiSelect = False
        Me.datagrid_permisos.Name = "datagrid_permisos"
        Me.datagrid_permisos.ReadOnly = True
        Me.datagrid_permisos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_permisos.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.datagrid_permisos.RowHeadersVisible = False
        Me.datagrid_permisos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.datagrid_permisos.RowsDefaultCellStyle = DataGridViewCellStyle14
        Me.datagrid_permisos.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.datagrid_permisos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.datagrid_permisos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.datagrid_permisos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.datagrid_permisos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.datagrid_permisos.RowTemplate.Height = 28
        Me.datagrid_permisos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid_permisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrid_permisos.Size = New System.Drawing.Size(391, 265)
        Me.datagrid_permisos.TabIndex = 769
        '
        'Button_quitar_permiso
        '
        Me.Button_quitar_permiso.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_quitar_permiso.BackColor = System.Drawing.Color.Transparent
        Me.Button_quitar_permiso.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.butttonsvg
        Me.Button_quitar_permiso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_quitar_permiso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_quitar_permiso.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_quitar_permiso.FlatAppearance.BorderSize = 0
        Me.Button_quitar_permiso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_quitar_permiso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_quitar_permiso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_quitar_permiso.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_quitar_permiso.ForeColor = System.Drawing.Color.White
        Me.Button_quitar_permiso.Image = Global.MiClickDerecho.My.Resources.Resources.delete_256
        Me.Button_quitar_permiso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_quitar_permiso.Location = New System.Drawing.Point(257, 345)
        Me.Button_quitar_permiso.Name = "Button_quitar_permiso"
        Me.Button_quitar_permiso.Size = New System.Drawing.Size(137, 33)
        Me.Button_quitar_permiso.TabIndex = 772
        Me.Button_quitar_permiso.Text = "Quitar Permiso >>"
        Me.Button_quitar_permiso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_quitar_permiso.UseVisualStyleBackColor = False
        '
        'Button_agregar_permiso
        '
        Me.Button_agregar_permiso.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_agregar_permiso.BackColor = System.Drawing.Color.Transparent
        Me.Button_agregar_permiso.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.butttonsvg
        Me.Button_agregar_permiso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_agregar_permiso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_agregar_permiso.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_agregar_permiso.FlatAppearance.BorderSize = 0
        Me.Button_agregar_permiso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_agregar_permiso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_agregar_permiso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_agregar_permiso.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_agregar_permiso.ForeColor = System.Drawing.Color.White
        Me.Button_agregar_permiso.Image = Global.MiClickDerecho.My.Resources.Resources.agregar
        Me.Button_agregar_permiso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_agregar_permiso.Location = New System.Drawing.Point(400, 76)
        Me.Button_agregar_permiso.Name = "Button_agregar_permiso"
        Me.Button_agregar_permiso.Size = New System.Drawing.Size(153, 33)
        Me.Button_agregar_permiso.TabIndex = 645
        Me.Button_agregar_permiso.Text = "<<Agregar Permiso"
        Me.Button_agregar_permiso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_agregar_permiso.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Button3)
        Me.Panel4.Controls.Add(Me.TextBox_buscar_cliente)
        Me.Panel4.Controls.Add(Me.RadioButton4)
        Me.Panel4.Location = New System.Drawing.Point(11, 42)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(342, 55)
        Me.Panel4.TabIndex = 643
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.botonbuscar
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(234, 22)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 30)
        Me.Button3.TabIndex = 428
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TextBox_buscar_cliente
        '
        Me.TextBox_buscar_cliente.BackColor = System.Drawing.Color.SteelBlue
        Me.TextBox_buscar_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_buscar_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_buscar_cliente.ForeColor = System.Drawing.Color.White
        Me.TextBox_buscar_cliente.Location = New System.Drawing.Point(4, 28)
        Me.TextBox_buscar_cliente.Name = "TextBox_buscar_cliente"
        Me.TextBox_buscar_cliente.Size = New System.Drawing.Size(221, 24)
        Me.TextBox_buscar_cliente.TabIndex = 429
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Checked = True
        Me.RadioButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(10, 10)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(68, 17)
        Me.RadioButton4.TabIndex = 632
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Nombre"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'Timer_modificar
        '
        Me.Timer_modificar.Interval = 400
        '
        'Timer_MEDIO_PAGO
        '
        Me.Timer_MEDIO_PAGO.Interval = 300
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Timer_PERMISOS
        '
        Me.Timer_PERMISOS.Interval = 400
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 5
        Me.BunifuElipse2.TargetControl = Me.TextBox_buscar_cliente
        '
        'Panel_titlebar
        '
        Me.Panel_titlebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel_titlebar.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.banner9
        Me.Panel_titlebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_titlebar.Controls.Add(Me.Button1)
        Me.Panel_titlebar.Controls.Add(Me.Button_cerrar)
        Me.Panel_titlebar.Controls.Add(Me.PictureBox1)
        Me.Panel_titlebar.Controls.Add(Me.Label4)
        Me.Panel_titlebar.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_titlebar.Location = New System.Drawing.Point(0, 0)
        Me.Panel_titlebar.Name = "Panel_titlebar"
        Me.Panel_titlebar.Size = New System.Drawing.Size(867, 35)
        Me.Panel_titlebar.TabIndex = 433
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.question
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(170, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(15, 15)
        Me.Button1.TabIndex = 752
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button_cerrar
        '
        Me.Button_cerrar.BackColor = System.Drawing.Color.Transparent
        Me.Button_cerrar.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.CANCEL
        Me.Button_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_cerrar.FlatAppearance.BorderSize = 0
        Me.Button_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_cerrar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_cerrar.ForeColor = System.Drawing.Color.White
        Me.Button_cerrar.Location = New System.Drawing.Point(829, 5)
        Me.Button_cerrar.Name = "Button_cerrar"
        Me.Button_cerrar.Size = New System.Drawing.Size(25, 25)
        Me.Button_cerrar.TabIndex = 436
        Me.Button_cerrar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.MiClickDerecho.My.Resources.Resources.profile_icon_png_918
        Me.PictureBox1.Location = New System.Drawing.Point(5, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 435
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB", 16.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(51, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 24)
        Me.Label4.TabIndex = 393
        Me.Label4.Text = "Empleados"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button_guardar
        '
        Me.Button_guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_guardar.BackColor = System.Drawing.Color.Transparent
        Me.Button_guardar.BackgroundImage = CType(resources.GetObject("Button_guardar.BackgroundImage"), System.Drawing.Image)
        Me.Button_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_guardar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_guardar.FlatAppearance.BorderSize = 0
        Me.Button_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen
        Me.Button_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_guardar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_guardar.ForeColor = System.Drawing.Color.Black
        Me.Button_guardar.Image = Global.MiClickDerecho.My.Resources.Resources.save_icon_5427
        Me.Button_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_guardar.Location = New System.Drawing.Point(596, 51)
        Me.Button_guardar.Name = "Button_guardar"
        Me.Button_guardar.Size = New System.Drawing.Size(117, 40)
        Me.Button_guardar.TabIndex = 396
        Me.Button_guardar.Text = "Guardar"
        Me.Button_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_guardar.UseVisualStyleBackColor = False
        Me.Button_guardar.Visible = False
        '
        'Button_cancelar
        '
        Me.Button_cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_cancelar.BackColor = System.Drawing.Color.Transparent
        Me.Button_cancelar.BackgroundImage = CType(resources.GetObject("Button_cancelar.BackgroundImage"), System.Drawing.Image)
        Me.Button_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_cancelar.FlatAppearance.BorderSize = 0
        Me.Button_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen
        Me.Button_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_cancelar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_cancelar.ForeColor = System.Drawing.Color.Black
        Me.Button_cancelar.Image = Global.MiClickDerecho.My.Resources.Resources.back
        Me.Button_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_cancelar.Location = New System.Drawing.Point(719, 51)
        Me.Button_cancelar.Name = "Button_cancelar"
        Me.Button_cancelar.Size = New System.Drawing.Size(121, 40)
        Me.Button_cancelar.TabIndex = 397
        Me.Button_cancelar.Text = "Regresar"
        Me.Button_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_cancelar.UseVisualStyleBackColor = False
        Me.Button_cancelar.Visible = False
        '
        'BunifuElipse3
        '
        Me.BunifuElipse3.ElipseRadius = 5
        Me.BunifuElipse3.TargetControl = Me.datagridempleados
        '
        'Button_tab1
        '
        Me.Button_tab1.BackColor = System.Drawing.Color.Transparent
        Me.Button_tab1.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.BOTONTAB
        Me.Button_tab1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_tab1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_tab1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_tab1.FlatAppearance.BorderSize = 0
        Me.Button_tab1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_tab1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_tab1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_tab1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_tab1.ForeColor = System.Drawing.Color.White
        Me.Button_tab1.Location = New System.Drawing.Point(26, 102)
        Me.Button_tab1.Name = "Button_tab1"
        Me.Button_tab1.Size = New System.Drawing.Size(147, 37)
        Me.Button_tab1.TabIndex = 633
        Me.Button_tab1.Text = "Datos Generales"
        Me.Button_tab1.UseVisualStyleBackColor = False
        '
        'Button_tab2
        '
        Me.Button_tab2.BackColor = System.Drawing.Color.Transparent
        Me.Button_tab2.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.BOTONTAB
        Me.Button_tab2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_tab2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_tab2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_tab2.FlatAppearance.BorderSize = 0
        Me.Button_tab2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_tab2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_tab2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_tab2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_tab2.ForeColor = System.Drawing.Color.White
        Me.Button_tab2.Location = New System.Drawing.Point(173, 102)
        Me.Button_tab2.Name = "Button_tab2"
        Me.Button_tab2.Size = New System.Drawing.Size(147, 37)
        Me.Button_tab2.TabIndex = 644
        Me.Button_tab2.Text = "Permisos"
        Me.Button_tab2.UseVisualStyleBackColor = False
        '
        'Label_nombre_titulo
        '
        Me.Label_nombre_titulo.AutoSize = True
        Me.Label_nombre_titulo.BackColor = System.Drawing.Color.Transparent
        Me.Label_nombre_titulo.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label_nombre_titulo.ForeColor = System.Drawing.Color.Black
        Me.Label_nombre_titulo.Location = New System.Drawing.Point(22, 70)
        Me.Label_nombre_titulo.Name = "Label_nombre_titulo"
        Me.Label_nombre_titulo.Size = New System.Drawing.Size(97, 23)
        Me.Label_nombre_titulo.TabIndex = 645
        Me.Label_nombre_titulo.Text = "empleado"
        '
        'BunifuElipse4
        '
        Me.BunifuElipse4.ElipseRadius = 5
        Me.BunifuElipse4.TargetControl = Me.RadioButton_ventas
        '
        'BunifuElipse5
        '
        Me.BunifuElipse5.ElipseRadius = 5
        Me.BunifuElipse5.TargetControl = Me.RadioButton_INVENTARIOS
        '
        'BunifuElipse6
        '
        Me.BunifuElipse6.ElipseRadius = 5
        Me.BunifuElipse6.TargetControl = Me.RadioButton_PAGOS
        '
        'BunifuElipse7
        '
        Me.BunifuElipse7.ElipseRadius = 5
        Me.BunifuElipse7.TargetControl = Me.RadioButton_INFORMES
        '
        'BunifuElipse8
        '
        Me.BunifuElipse8.ElipseRadius = 5
        Me.BunifuElipse8.TargetControl = Me.RadioButton_ADMINISTRACION
        '
        'Form_empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(867, 550)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label_nombre_titulo)
        Me.Controls.Add(Me.Button_tab2)
        Me.Controls.Add(Me.Button_tab1)
        Me.Controls.Add(Me.Panel_titlebar)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Controls.Add(Me.datagridempleados)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button_guardar)
        Me.Controls.Add(Me.Button_cancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(867, 550)
        Me.MinimumSize = New System.Drawing.Size(867, 550)
        Me.Name = "Form_empleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.datagridempleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.datagrid_export, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage2.PerformLayout()
        CType(Me.datagrid_permisos_todos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datagrid_permisos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel_titlebar.ResumeLayout(False)
        Me.Panel_titlebar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox_password As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox_DOMICILIO As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox_MAIL As System.Windows.Forms.TextBox
    Friend WithEvents Label_mail As System.Windows.Forms.Label
    Friend WithEvents Button_eliminar As System.Windows.Forms.Button
    Friend WithEvents Button_modificar As System.Windows.Forms.Button
    Friend WithEvents button_crear As System.Windows.Forms.Button
    Friend WithEvents datagridempleados As MetroFramework.Controls.MetroGrid
    Friend WithEvents TextBox_TEL As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox_DOC As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button_cancelar As System.Windows.Forms.Button
    Friend WithEvents Button_guardar As System.Windows.Forms.Button
    Friend WithEvents TextBox_NOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button_export_pdf As System.Windows.Forms.Button
    Friend WithEvents Panel_titlebar As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Label29 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox_buscar_cliente As TextBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Label12 As Label
    Friend WithEvents MetroComboBox_estado As MetroFramework.Controls.MetroComboBox
    Friend WithEvents datagrid_export As MetroFramework.Controls.MetroGrid
    Friend WithEvents TextBox_salario As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Combo_cargo As ComboBox
    Friend WithEvents Timer_modificar As Timer
    Friend WithEvents Timer_MEDIO_PAGO As Timer
    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents Button_cerrar As Button
    Friend WithEvents Timer_PERMISOS As Timer
    Friend WithEvents BunifuElipse2 As ns1.BunifuElipse
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox_tipodoc As ComboBox
    Friend WithEvents BunifuElipse3 As ns1.BunifuElipse
    Friend WithEvents TextBox_celular As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Button_tab2 As Button
    Friend WithEvents Button_tab1 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label_nombre_titulo As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button_quitar_permiso As Button
    Friend WithEvents Button_agregar_permiso As Button
    Friend WithEvents datagrid_permisos As MetroFramework.Controls.MetroGrid
    Friend WithEvents RadioButton_PAGOS As RadioButton
    Friend WithEvents RadioButton_INVENTARIOS As RadioButton
    Friend WithEvents RadioButton_ventas As RadioButton
    Friend WithEvents RadioButton_INFORMES As RadioButton
    Friend WithEvents RadioButton_ADMINISTRACION As RadioButton
    Friend WithEvents BunifuElipse4 As ns1.BunifuElipse
    Friend WithEvents BunifuElipse5 As ns1.BunifuElipse
    Friend WithEvents BunifuElipse6 As ns1.BunifuElipse
    Friend WithEvents BunifuElipse7 As ns1.BunifuElipse
    Friend WithEvents BunifuElipse8 As ns1.BunifuElipse
    Friend WithEvents datagrid_permisos_todos As MetroFramework.Controls.MetroGrid
End Class
