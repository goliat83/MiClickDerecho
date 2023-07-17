<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_contactos
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_contactos))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGrid_export = New MetroFramework.Controls.MetroGrid()
        Me.Button_eliminar = New System.Windows.Forms.Button()
        Me.Button_modificar = New System.Windows.Forms.Button()
        Me.button_crear = New System.Windows.Forms.Button()
        Me.Button_export_pdf = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TextBox_buscar_cliente = New ns1.BunifuMaterialTextbox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer_nuevo = New System.Windows.Forms.Timer(Me.components)
        Me.datagridPROVEEDORES = New MetroFramework.Controls.MetroGrid()
        Me.BunifuElipse3 = New ns1.BunifuElipse(Me.components)
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Panel_titlebar = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.ComboBox_activo = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.TextBox_Numero_id_fiscal = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.ComboBox_ACTIVIDAD = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.ComboBox_pais = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.ComboBox_autoretenedor = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Agenteretenedor = New System.Windows.Forms.ComboBox()
        Me.Combo_naturaleza = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.ComboBox_tipocontribuyente = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.ComboBox_declarante = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ComboBox_tipodoc = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_DOC = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox_dv = New System.Windows.Forms.TextBox()
        Me.Label_mail = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox_MAIL = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_DOMICILIO = New System.Windows.Forms.TextBox()
        Me.TextBox_SITIOWEB = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBox_CIUDAD = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CheckBox_otro = New System.Windows.Forms.CheckBox()
        Me.CheckBox_proveedor = New System.Windows.Forms.CheckBox()
        Me.CheckBox_cliente = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox_APELLIDO2 = New System.Windows.Forms.TextBox()
        Me.TextBox_NOMBRE1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.TextBox_APELLIDO1 = New System.Windows.Forms.TextBox()
        Me.TextBox_NOMBRE2 = New System.Windows.Forms.TextBox()
        Me.TextBox_cupoCredito = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.ComboBox_medioPAgo = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TextBox_contacto = New System.Windows.Forms.TextBox()
        Me.Text_leyenda = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox_TEL4 = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TextBox_TEL3 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_TEL = New System.Windows.Forms.TextBox()
        Me.TextBox_TEL2 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.textbox_fullname = New ns1.BunifuMaterialTextbox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button_guardar = New System.Windows.Forms.Button()
        Me.Button_cancelar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGrid_export, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.datagridPROVEEDORES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_titlebar.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.DataGrid_export)
        Me.Panel1.Controls.Add(Me.Button_eliminar)
        Me.Panel1.Controls.Add(Me.Button_modificar)
        Me.Panel1.Controls.Add(Me.button_crear)
        Me.Panel1.Controls.Add(Me.Button_export_pdf)
        Me.BunifuTransition1.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Location = New System.Drawing.Point(538, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(377, 50)
        Me.Panel1.TabIndex = 426
        '
        'DataGrid_export
        '
        Me.DataGrid_export.AllowUserToAddRows = False
        Me.DataGrid_export.AllowUserToDeleteRows = False
        Me.DataGrid_export.AllowUserToOrderColumns = True
        Me.DataGrid_export.AllowUserToResizeRows = False
        Me.DataGrid_export.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGrid_export.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGrid_export.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.DataGrid_export.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGrid_export.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGrid_export.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid_export.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGrid_export.ColumnHeadersHeight = 30
        Me.DataGrid_export.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.BunifuTransition1.SetDecoration(Me.DataGrid_export, BunifuAnimatorNS.DecorationType.None)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrid_export.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGrid_export.EnableHeadersVisualStyles = False
        Me.DataGrid_export.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.DataGrid_export.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGrid_export.Location = New System.Drawing.Point(305, 8)
        Me.DataGrid_export.Name = "DataGrid_export"
        Me.DataGrid_export.ReadOnly = True
        Me.DataGrid_export.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid_export.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGrid_export.RowHeadersVisible = False
        Me.DataGrid_export.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGrid_export.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DataGrid_export.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid_export.Size = New System.Drawing.Size(63, 16)
        Me.DataGrid_export.TabIndex = 643
        Me.DataGrid_export.Visible = False
        '
        'Button_eliminar
        '
        Me.Button_eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_eliminar.BackColor = System.Drawing.Color.Transparent
        Me.Button_eliminar.BackgroundImage = CType(resources.GetObject("Button_eliminar.BackgroundImage"), System.Drawing.Image)
        Me.Button_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTransition1.SetDecoration(Me.Button_eliminar, BunifuAnimatorNS.DecorationType.None)
        Me.Button_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_eliminar.FlatAppearance.BorderSize = 0
        Me.Button_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.Button_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_eliminar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_eliminar.ForeColor = System.Drawing.Color.White
        Me.Button_eliminar.Image = Global.MiClickDerecho.My.Resources.Resources.delete_row
        Me.Button_eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_eliminar.Location = New System.Drawing.Point(197, 2)
        Me.Button_eliminar.Name = "Button_eliminar"
        Me.Button_eliminar.Size = New System.Drawing.Size(94, 46)
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
        Me.BunifuTransition1.SetDecoration(Me.Button_modificar, BunifuAnimatorNS.DecorationType.None)
        Me.Button_modificar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_modificar.FlatAppearance.BorderSize = 0
        Me.Button_modificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.Button_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_modificar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_modificar.ForeColor = System.Drawing.Color.White
        Me.Button_modificar.Image = Global.MiClickDerecho.My.Resources.Resources.viewicone
        Me.Button_modificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_modificar.Location = New System.Drawing.Point(110, 2)
        Me.Button_modificar.Name = "Button_modificar"
        Me.Button_modificar.Size = New System.Drawing.Size(85, 46)
        Me.Button_modificar.TabIndex = 299
        Me.Button_modificar.Text = "Consultar"
        Me.Button_modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_modificar.UseVisualStyleBackColor = False
        '
        'button_crear
        '
        Me.button_crear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button_crear.BackColor = System.Drawing.Color.Transparent
        Me.button_crear.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.butttonsvg
        Me.button_crear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTransition1.SetDecoration(Me.button_crear, BunifuAnimatorNS.DecorationType.None)
        Me.button_crear.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.button_crear.FlatAppearance.BorderSize = 0
        Me.button_crear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.button_crear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.button_crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_crear.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_crear.ForeColor = System.Drawing.Color.White
        Me.button_crear.Image = Global.MiClickDerecho.My.Resources.Resources.agregar
        Me.button_crear.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.button_crear.Location = New System.Drawing.Point(21, 2)
        Me.button_crear.Name = "button_crear"
        Me.button_crear.Size = New System.Drawing.Size(87, 46)
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
        Me.BunifuTransition1.SetDecoration(Me.Button_export_pdf, BunifuAnimatorNS.DecorationType.None)
        Me.Button_export_pdf.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_export_pdf.FlatAppearance.BorderSize = 0
        Me.Button_export_pdf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_export_pdf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.Button_export_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_export_pdf.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_export_pdf.ForeColor = System.Drawing.Color.White
        Me.Button_export_pdf.Image = Global.MiClickDerecho.My.Resources.Resources.export_icon
        Me.Button_export_pdf.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_export_pdf.Location = New System.Drawing.Point(293, 2)
        Me.Button_export_pdf.Name = "Button_export_pdf"
        Me.Button_export_pdf.Size = New System.Drawing.Size(72, 46)
        Me.Button_export_pdf.TabIndex = 408
        Me.Button_export_pdf.Text = "Exportar"
        Me.Button_export_pdf.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_export_pdf.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label24)
        Me.Panel4.Controls.Add(Me.TextBox_buscar_cliente)
        Me.Panel4.Controls.Add(Me.Button2)
        Me.BunifuTransition1.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.Panel4.Location = New System.Drawing.Point(11, 53)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(371, 40)
        Me.Panel4.TabIndex = 642
        '
        'Label24
        '
        Me.Label24.AllowDrop = True
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label24, BunifuAnimatorNS.DecorationType.None)
        Me.Label24.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(3, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(104, 16)
        Me.Label24.TabIndex = 658
        Me.Label24.Text = "Buscar Contacto"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox_buscar_cliente
        '
        Me.TextBox_buscar_cliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.TextBox_buscar_cliente, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox_buscar_cliente.Font = New System.Drawing.Font("Century Gothic", 10.75!)
        Me.TextBox_buscar_cliente.ForeColor = System.Drawing.Color.Black
        Me.TextBox_buscar_cliente.HintForeColor = System.Drawing.Color.Empty
        Me.TextBox_buscar_cliente.HintText = ""
        Me.TextBox_buscar_cliente.isPassword = False
        Me.TextBox_buscar_cliente.LineFocusedColor = System.Drawing.Color.Blue
        Me.TextBox_buscar_cliente.LineIdleColor = System.Drawing.Color.Black
        Me.TextBox_buscar_cliente.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TextBox_buscar_cliente.LineThickness = 2
        Me.TextBox_buscar_cliente.Location = New System.Drawing.Point(3, 7)
        Me.TextBox_buscar_cliente.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_buscar_cliente.Name = "TextBox_buscar_cliente"
        Me.TextBox_buscar_cliente.Size = New System.Drawing.Size(246, 30)
        Me.TextBox_buscar_cliente.TabIndex = 671
        Me.TextBox_buscar_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.search_icon
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.Button2, BunifuAnimatorNS.DecorationType.None)
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(256, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 25)
        Me.Button2.TabIndex = 428
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Timer_nuevo
        '
        Me.Timer_nuevo.Interval = 300
        '
        'datagridPROVEEDORES
        '
        Me.datagridPROVEEDORES.AllowUserToAddRows = False
        Me.datagridPROVEEDORES.AllowUserToDeleteRows = False
        Me.datagridPROVEEDORES.AllowUserToOrderColumns = True
        Me.datagridPROVEEDORES.AllowUserToResizeRows = False
        Me.datagridPROVEEDORES.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datagridPROVEEDORES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridPROVEEDORES.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.datagridPROVEEDORES.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datagridPROVEEDORES.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.datagridPROVEEDORES.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridPROVEEDORES.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.datagridPROVEEDORES.ColumnHeadersHeight = 30
        Me.datagridPROVEEDORES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.BunifuTransition1.SetDecoration(Me.datagridPROVEEDORES, BunifuAnimatorNS.DecorationType.None)
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(87, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridPROVEEDORES.DefaultCellStyle = DataGridViewCellStyle5
        Me.datagridPROVEEDORES.EnableHeadersVisualStyles = False
        Me.datagridPROVEEDORES.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.datagridPROVEEDORES.GridColor = System.Drawing.Color.SteelBlue
        Me.datagridPROVEEDORES.Location = New System.Drawing.Point(12, 95)
        Me.datagridPROVEEDORES.Name = "datagridPROVEEDORES"
        Me.datagridPROVEEDORES.ReadOnly = True
        Me.datagridPROVEEDORES.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridPROVEEDORES.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.datagridPROVEEDORES.RowHeadersVisible = False
        Me.datagridPROVEEDORES.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridPROVEEDORES.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue
        Me.datagridPROVEEDORES.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagridPROVEEDORES.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.datagridPROVEEDORES.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.datagridPROVEEDORES.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.datagridPROVEEDORES.RowTemplate.Height = 30
        Me.datagridPROVEEDORES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridPROVEEDORES.Size = New System.Drawing.Size(899, 557)
        Me.datagridPROVEEDORES.TabIndex = 425
        '
        'BunifuElipse3
        '
        Me.BunifuElipse3.ElipseRadius = 5
        Me.BunifuElipse3.TargetControl = Me.datagridPROVEEDORES
        '
        'BunifuTransition1
        '
        Me.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Scale
        Me.BunifuTransition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.BunifuTransition1.DefaultAnimation = Animation1
        '
        'Panel_titlebar
        '
        Me.Panel_titlebar.BackColor = System.Drawing.Color.Transparent
        Me.Panel_titlebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_titlebar.Controls.Add(Me.Label8)
        Me.BunifuTransition1.SetDecoration(Me.Panel_titlebar, BunifuAnimatorNS.DecorationType.None)
        Me.Panel_titlebar.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_titlebar.Location = New System.Drawing.Point(0, 0)
        Me.Panel_titlebar.Name = "Panel_titlebar"
        Me.Panel_titlebar.Size = New System.Drawing.Size(926, 34)
        Me.Panel_titlebar.TabIndex = 427
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label8, BunifuAnimatorNS.DecorationType.None)
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(12, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(164, 19)
        Me.Label8.TabIndex = 393
        Me.Label8.Text = "Contactos / Terceros"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label29, BunifuAnimatorNS.DecorationType.None)
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(13, 103)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(139, 13)
        Me.Label29.TabIndex = 2003
        Me.Label29.Text = "Nombre / Razon Social"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox_activo
        '
        Me.ComboBox_activo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox_activo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox_activo.BackColor = System.Drawing.Color.White
        Me.BunifuTransition1.SetDecoration(Me.ComboBox_activo, BunifuAnimatorNS.DecorationType.None)
        Me.ComboBox_activo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ComboBox_activo.ForeColor = System.Drawing.Color.Black
        Me.ComboBox_activo.FormattingEnabled = True
        Me.ComboBox_activo.ItemHeight = 16
        Me.ComboBox_activo.Items.AddRange(New Object() {"SI", "NO"})
        Me.ComboBox_activo.Location = New System.Drawing.Point(748, 66)
        Me.ComboBox_activo.Name = "ComboBox_activo"
        Me.ComboBox_activo.Size = New System.Drawing.Size(114, 24)
        Me.ComboBox_activo.TabIndex = 6
        Me.ComboBox_activo.Text = "SI"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label19, BunifuAnimatorNS.DecorationType.None)
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(16, 110)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(153, 16)
        Me.Label19.TabIndex = 1024
        Me.Label19.Text = "Información Tributaria"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label37, BunifuAnimatorNS.DecorationType.None)
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.DimGray
        Me.Label37.Location = New System.Drawing.Point(465, 139)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(168, 13)
        Me.Label37.TabIndex = 1016
        Me.Label37.Text = "Número Identificación Fiscal"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_Numero_id_fiscal
        '
        Me.TextBox_Numero_id_fiscal.BackColor = System.Drawing.Color.White
        Me.BunifuTransition1.SetDecoration(Me.TextBox_Numero_id_fiscal, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox_Numero_id_fiscal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Numero_id_fiscal.ForeColor = System.Drawing.Color.Black
        Me.TextBox_Numero_id_fiscal.Location = New System.Drawing.Point(465, 152)
        Me.TextBox_Numero_id_fiscal.Name = "TextBox_Numero_id_fiscal"
        Me.TextBox_Numero_id_fiscal.Size = New System.Drawing.Size(230, 24)
        Me.TextBox_Numero_id_fiscal.TabIndex = 16
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label36, BunifuAnimatorNS.DecorationType.None)
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.DimGray
        Me.Label36.Location = New System.Drawing.Point(712, 48)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(106, 13)
        Me.Label36.TabIndex = 1013
        Me.Label36.Text = "Segundo Apelldio"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label33, BunifuAnimatorNS.DecorationType.None)
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.DimGray
        Me.Label33.Location = New System.Drawing.Point(19, 195)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(126, 13)
        Me.Label33.TabIndex = 1006
        Me.Label33.Text = "Actividad Economica"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox_ACTIVIDAD
        '
        Me.ComboBox_ACTIVIDAD.AutoCompleteCustomSource.AddRange(New String() {"MEDELLIN - ANTIOQUIA", "ABEJORRAL - ANTIOQUIA", "ABRIAQUI - ANTIOQUIA", "ALEJANDRIA - ANTIOQUIA", "AMAGA - ANTIOQUIA", "AMALFI - ANTIOQUIA", "ANDES - ANTIOQUIA", "ANGELOPOLIS - ANTIOQUIA", "ANGOSTURA - ANTIOQUIA", "ANORI - ANTIOQUIA", "SANTAFE DE ANTIOQUIA - ANTIOQUIA", "ANZA - ANTIOQUIA", "APARTADO - ANTIOQUIA", "ARBOLETES - ANTIOQUIA", "ARGELIA - ANTIOQUIA", "ARMENIA - ANTIOQUIA", "BARBOSA - ANTIOQUIA", "BELMIRA - ANTIOQUIA", "BELLO - ANTIOQUIA", "BETANIA - ANTIOQUIA", "BETULIA - ANTIOQUIA", "CIUDAD BOLIVAR - ANTIOQUIA", "BRICEÑO - ANTIOQUIA", "BURITICA - ANTIOQUIA", "CACERES - ANTIOQUIA", "CAICEDO - ANTIOQUIA", "CALDAS - ANTIOQUIA", "CAMPAMENTO - ANTIOQUIA", "CAÑASGORDAS - ANTIOQUIA", "CARACOLI - ANTIOQUIA", "CARAMANTA - ANTIOQUIA", "CAREPA - ANTIOQUIA", "EL CARMEN DE VIBORAL - ANTIOQUIA", "CAROLINA - ANTIOQUIA", "CAUCASIA - ANTIOQUIA", "CHIGORODO - ANTIOQUIA", "CISNEROS - ANTIOQUIA", "COCORNA - ANTIOQUIA", "CONCEPCION - ANTIOQUIA", "CONCORDIA - ANTIOQUIA", "COPACABANA - ANTIOQUIA", "DABEIBA - ANTIOQUIA", "DON MATIAS - ANTIOQUIA", "EBEJICO - ANTIOQUIA", "EL BAGRE - ANTIOQUIA", "ENTRERRIOS - ANTIOQUIA", "ENVIGADO - ANTIOQUIA", "FREDONIA - ANTIOQUIA", "FRONTINO - ANTIOQUIA", "GIRALDO - ANTIOQUIA", "GIRARDOTA - ANTIOQUIA", "GOMEZ PLATA - ANTIOQUIA", "GRANADA - ANTIOQUIA", "GUADALUPE - ANTIOQUIA", "GUARNE - ANTIOQUIA", "GUATAPE - ANTIOQUIA", "HELICONIA - ANTIOQUIA", "HISPANIA - ANTIOQUIA", "ITAGUI - ANTIOQUIA", "ITUANGO - ANTIOQUIA", "JARDIN - ANTIOQUIA", "JERICO - ANTIOQUIA", "LA CEJA - ANTIOQUIA", "LA ESTRELLA - ANTIOQUIA", "LA PINTADA - ANTIOQUIA", "LA UNION - ANTIOQUIA", "LIBORINA - ANTIOQUIA", "MACEO - ANTIOQUIA", "MARINILLA - ANTIOQUIA", "MONTEBELLO - ANTIOQUIA", "MURINDO - ANTIOQUIA", "MUTATA - ANTIOQUIA", "NARIÑO - ANTIOQUIA", "NECOCLI - ANTIOQUIA", "NECHI - ANTIOQUIA", "OLAYA - ANTIOQUIA", "PEÐOL - ANTIOQUIA", "PEQUE - ANTIOQUIA", "PUEBLORRICO - ANTIOQUIA", "PUERTO BERRIO - ANTIOQUIA", "PUERTO NARE - ANTIOQUIA", "PUERTO TRIUNFO - ANTIOQUIA", "REMEDIOS - ANTIOQUIA", "RETIRO - ANTIOQUIA", "RIONEGRO - ANTIOQUIA", "SABANALARGA - ANTIOQUIA", "SABANETA - ANTIOQUIA", "SALGAR - ANTIOQUIA", "SAN ANDRES DE CUERQUIA - ANTIOQUIA", "SAN CARLOS - ANTIOQUIA", "SAN FRANCISCO - ANTIOQUIA", "SAN JERONIMO - ANTIOQUIA", "SAN JOSE DE LA MONTAÑA - ANTIOQUIA", "SAN JUAN DE URABA - ANTIOQUIA", "SAN LUIS - ANTIOQUIA", "SAN PEDRO - ANTIOQUIA", "SAN PEDRO DE URABA - ANTIOQUIA", "SAN RAFAEL - ANTIOQUIA", "SAN ROQUE - ANTIOQUIA", "SAN VICENTE - ANTIOQUIA", "SANTA BARBARA - ANTIOQUIA", "SANTA ROSA DE OSOS - ANTIOQUIA", "SANTO DOMINGO - ANTIOQUIA", "EL SANTUARIO - ANTIOQUIA", "SEGOVIA - ANTIOQUIA", "SONSON - ANTIOQUIA", "SOPETRAN - ANTIOQUIA", "TAMESIS - ANTIOQUIA", "TARAZA - ANTIOQUIA", "TARSO - ANTIOQUIA", "TITIRIBI - ANTIOQUIA", "TOLEDO - ANTIOQUIA", "TURBO - ANTIOQUIA", "URAMITA - ANTIOQUIA", "URRAO - ANTIOQUIA", "VALDIVIA - ANTIOQUIA", "VALPARAISO - ANTIOQUIA", "VEGACHI - ANTIOQUIA", "VENECIA - ANTIOQUIA", "VIGIA DEL FUERTE - ANTIOQUIA", "YALI - ANTIOQUIA", "YARUMAL - ANTIOQUIA", "YOLOMBO - ANTIOQUIA", "YONDO - ANTIOQUIA", "ZARAGOZA - ANTIOQUIA", "BARRANQUILLA - ATLANTICO", "BARANOA - ATLANTICO", "CAMPO DE LA CRUZ - ATLANTICO", "CANDELARIA - ATLANTICO", "GALAPA - ATLANTICO", "JUAN DE ACOSTA - ATLANTICO", "LURUACO - ATLANTICO", "MALAMBO - ATLANTICO", "MANATI - ATLANTICO", "PALMAR DE VARELA - ATLANTICO", "PIOJO - ATLANTICO", "POLONUEVO - ATLANTICO", "PONEDERA - ATLANTICO", "PUERTO COLOMBIA - ATLANTICO", "REPELON - ATLANTICO", "SABANAGRANDE - ATLANTICO", "SABANALARGA - ATLANTICO", "SANTA LUCIA - ATLANTICO", "SANTO TOMAS - ATLANTICO", "SOLEDAD - ATLANTICO", "SUAN - ATLANTICO", "TUBARA - ATLANTICO", "USIACURI - ATLANTICO", "BOGOTA, D.C. - BOGOTA", "CARTAGENA - BOLIVAR", "ACHI - BOLIVAR", "ALTOS DEL ROSARIO - BOLIVAR", "ARENAL - BOLIVAR", "ARJONA - BOLIVAR", "ARROYOHONDO - BOLIVAR", "BARRANCO DE LOBA - BOLIVAR", "CALAMAR - BOLIVAR", "CANTAGALLO - BOLIVAR", "CICUCO - BOLIVAR", "CORDOBA - BOLIVAR", "CLEMENCIA - BOLIVAR", "EL CARMEN DE BOLIVAR - BOLIVAR", "EL GUAMO - BOLIVAR", "EL PEÑON - BOLIVAR", "HATILLO DE LOBA - BOLIVAR", "MAGANGUE - BOLIVAR", "MAHATES - BOLIVAR", "MARGARITA - BOLIVAR", "MARIA LA BAJA - BOLIVAR", "MONTECRISTO - BOLIVAR", "MOMPOS - BOLIVAR", "NOROSI - BOLIVAR", "MORALES - BOLIVAR", "PINILLOS - BOLIVAR", "REGIDOR - BOLIVAR", "RIO VIEJO - BOLIVAR", "SAN CRISTOBAL - BOLIVAR", "SAN ESTANISLAO - BOLIVAR", "SAN FERNANDO - BOLIVAR", "SAN JACINTO - BOLIVAR", "SAN JACINTO DEL CAUCA - BOLIVAR", "SAN JUAN NEPOMUCENO - BOLIVAR", "SAN MARTIN DE LOBA - BOLIVAR", "SAN PABLO - BOLIVAR", "SANTA CATALINA - BOLIVAR", "SANTA ROSA - BOLIVAR", "SANTA ROSA DEL SUR - BOLIVAR", "SIMITI - BOLIVAR", "SOPLAVIENTO - BOLIVAR", "TALAIGUA NUEVO - BOLIVAR", "TIQUISIO - BOLIVAR", "TURBACO - BOLIVAR", "TURBANA - BOLIVAR", "VILLANUEVA - BOLIVAR", "ZAMBRANO - BOLIVAR", "TUNJA - BOYACA", "ALMEIDA - BOYACA", "AQUITANIA - BOYACA", "ARCABUCO - BOYACA", "BELEN - BOYACA", "BERBEO - BOYACA", "BETEITIVA - BOYACA", "BOAVITA - BOYACA", "BOYACA - BOYACA", "BRICEÑO - BOYACA", "BUENAVISTA - BOYACA", "BUSBANZA - BOYACA", "CALDAS - BOYACA", "CAMPOHERMOSO - BOYACA", "CERINZA - BOYACA", "CHINAVITA - BOYACA", "CHIQUINQUIRA - BOYACA", "CHISCAS - BOYACA", "CHITA - BOYACA", "CHITARAQUE - BOYACA", "CHIVATA - BOYACA", "CIENEGA - BOYACA", "COMBITA - BOYACA", "COPER - BOYACA", "CORRALES - BOYACA", "COVARACHIA - BOYACA", "CUBARA - BOYACA", "CUCAITA - BOYACA", "CUITIVA - BOYACA", "CHIQUIZA - BOYACA", "CHIVOR - BOYACA", "DUITAMA - BOYACA", "EL COCUY - BOYACA", "EL ESPINO - BOYACA", "FIRAVITOBA - BOYACA", "FLORESTA - BOYACA", "GACHANTIVA - BOYACA", "GAMEZA - BOYACA", "GARAGOA - BOYACA", "GUACAMAYAS - BOYACA", "GUATEQUE - BOYACA", "GUAYATA - BOYACA", "GsICAN - BOYACA", "IZA - BOYACA", "JENESANO - BOYACA", "JERICO - BOYACA", "LABRANZAGRANDE - BOYACA", "LA CAPILLA - BOYACA", "LA VICTORIA - BOYACA", "LA UVITA - BOYACA", "VILLA DE LEYVA - BOYACA", "MACANAL - BOYACA", "MARIPI - BOYACA", "MIRAFLORES - BOYACA", "MONGUA - BOYACA", "MONGUI - BOYACA", "MONIQUIRA - BOYACA", "MOTAVITA - BOYACA", "MUZO - BOYACA", "NOBSA - BOYACA", "NUEVO COLON - BOYACA", "OICATA - BOYACA", "OTANCHE - BOYACA", "PACHAVITA - BOYACA", "PAEZ - BOYACA", "PAIPA - BOYACA", "PAJARITO - BOYACA", "PANQUEBA - BOYACA", "PAUNA - BOYACA", "PAYA - BOYACA", "PAZ DE RIO - BOYACA", "PESCA - BOYACA", "PISBA - BOYACA", "PUERTO BOYACA - BOYACA", "QUIPAMA - BOYACA", "RAMIRIQUI - BOYACA", "RAQUIRA - BOYACA", "RONDON - BOYACA", "SABOYA - BOYACA", "SACHICA - BOYACA", "SAMACA - BOYACA", "SAN EDUARDO - BOYACA", "SAN JOSE DE PARE - BOYACA", "SAN LUIS DE GACENO - BOYACA", "SAN MATEO - BOYACA", "SAN MIGUEL DE SEMA - BOYACA", "SAN PABLO DE BORBUR - BOYACA", "SANTANA - BOYACA", "SANTA MARIA - BOYACA", "SANTA ROSA DE VITERBO - BOYACA", "SANTA SOFIA - BOYACA", "SATIVANORTE - BOYACA", "SATIVASUR - BOYACA", "SIACHOQUE - BOYACA", "SOATA - BOYACA", "SOCOTA - BOYACA", "SOCHA - BOYACA", "SOGAMOSO - BOYACA", "SOMONDOCO - BOYACA", "SORA - BOYACA", "SOTAQUIRA - BOYACA", "SORACA - BOYACA", "SUSACON - BOYACA", "SUTAMARCHAN - BOYACA", "SUTATENZA - BOYACA", "TASCO - BOYACA", "TENZA - BOYACA", "TIBANA - BOYACA", "TIBASOSA - BOYACA", "TINJACA - BOYACA", "TIPACOQUE - BOYACA", "TOCA - BOYACA", "TOGsI - BOYACA", "TOPAGA - BOYACA", "TOTA - BOYACA", "TUNUNGUA - BOYACA", "TURMEQUE - BOYACA", "TUTA - BOYACA", "TUTAZA - BOYACA", "UMBITA - BOYACA", "VENTAQUEMADA - BOYACA", "VIRACACHA - BOYACA", "ZETAQUIRA - BOYACA", "MANIZALES - CALDAS", "AGUADAS - CALDAS", "ANSERMA - CALDAS", "ARANZAZU - CALDAS", "BELALCAZAR - CALDAS", "CHINCHINA - CALDAS", "FILADELFIA - CALDAS", "LA DORADA - CALDAS", "LA MERCED - CALDAS", "MANZANARES - CALDAS", "MARMATO - CALDAS", "MARQUETALIA - CALDAS", "MARULANDA - CALDAS", "NEIRA - CALDAS", "NORCASIA - CALDAS", "PACORA - CALDAS", "PALESTINA - CALDAS", "PENSILVANIA - CALDAS", "RIOSUCIO - CALDAS", "RISARALDA - CALDAS", "SALAMINA - CALDAS", "SAMANA - CALDAS", "SAN JOSE - CALDAS", "SUPIA - CALDAS", "VICTORIA - CALDAS", "VILLAMARIA - CALDAS", "VITERBO - CALDAS", "FLORENCIA - CAQUETA", "ALBANIA - CAQUETA", "BELEN DE LOS ANDAQUIES - CAQUETA", "CARTAGENA DEL CHAIRA - CAQUETA", "CURILLO - CAQUETA", "EL DONCELLO - CAQUETA", "EL PAUJIL - CAQUETA", "LA MONTAÑITA - CAQUETA", "MILAN - CAQUETA", "MORELIA - CAQUETA", "PUERTO RICO - CAQUETA", "SAN JOSE DEL FRAGUA - CAQUETA", "SAN VICENTE DEL CAGUAN - CAQUETA", "SOLANO - CAQUETA", "SOLITA - CAQUETA", "VALPARAISO - CAQUETA", "POPAYAN - CAUCA", "ALMAGUER - CAUCA", "ARGELIA - CAUCA", "BALBOA - CAUCA", "BOLIVAR - CAUCA", "BUENOS AIRES - CAUCA", "CAJIBIO - CAUCA", "CALDONO - CAUCA", "CALOTO - CAUCA", "CORINTO - CAUCA", "EL TAMBO - CAUCA", "FLORENCIA - CAUCA", "GUACHENE - CAUCA", "GUAPI - CAUCA", "INZA - CAUCA", "JAMBALO - CAUCA", "LA SIERRA - CAUCA", "LA VEGA - CAUCA", "LOPEZ - CAUCA", "MERCADERES - CAUCA", "MIRANDA - CAUCA", "MORALES - CAUCA", "PADILLA - CAUCA", "PAEZ - CAUCA", "PATIA - CAUCA", "PIAMONTE - CAUCA", "PIENDAMO - CAUCA", "PUERTO TEJADA - CAUCA", "PURACE - CAUCA", "ROSAS - CAUCA", "SAN SEBASTIAN - CAUCA", "SANTANDER DE QUILICHAO - CAUCA", "SANTA ROSA - CAUCA", "SILVIA - CAUCA", "SOTARA - CAUCA", "SUAREZ - CAUCA", "SUCRE - CAUCA", "TIMBIO - CAUCA", "TIMBIQUI - CAUCA", "TORIBIO - CAUCA", "TOTORO - CAUCA", "VILLA RICA - CAUCA", "VALLEDUPAR - CESAR", "AGUACHICA - CESAR", "AGUSTIN CODAZZI - CESAR", "ASTREA - CESAR", "BECERRIL - CESAR", "BOSCONIA - CESAR", "CHIMICHAGUA - CESAR", "CHIRIGUANA - CESAR", "CURUMANI - CESAR", "EL COPEY - CESAR", "EL PASO - CESAR", "GAMARRA - CESAR", "GONZALEZ - CESAR", "LA GLORIA - CESAR", "LA JAGUA DE IBIRICO - CESAR", "MANAURE - CESAR", "PAILITAS - CESAR", "PELAYA - CESAR", "PUEBLO BELLO - CESAR", "RIO DE ORO - CESAR", "LA PAZ - CESAR", "SAN ALBERTO - CESAR", "SAN DIEGO - CESAR", "SAN MARTIN - CESAR", "TAMALAMEQUE - CESAR", "MONTERIA - CORDOBA", "AYAPEL - CORDOBA", "BUENAVISTA - CORDOBA", "CANALETE - CORDOBA", "CERETE - CORDOBA", "CHIMA - CORDOBA", "CHINU - CORDOBA", "CIENAGA DE ORO - CORDOBA", "COTORRA - CORDOBA", "LA APARTADA - CORDOBA", "LORICA - CORDOBA", "LOS CORDOBAS - CORDOBA", "MOMIL - CORDOBA", "MONTELIBANO - CORDOBA", "MOÑITOS - CORDOBA", "PLANETA RICA - CORDOBA", "PUEBLO NUEVO - CORDOBA", "PUERTO ESCONDIDO - CORDOBA", "PUERTO LIBERTADOR - CORDOBA", "PURISIMA - CORDOBA", "SAHAGUN - CORDOBA", "SAN ANDRES SOTAVENTO - CORDOBA", "SAN ANTERO - CORDOBA", "SAN BERNARDO DEL VIENTO - CORDOBA", "SAN CARLOS - CORDOBA", "SAN PELAYO - CORDOBA", "TIERRALTA - CORDOBA", "VALENCIA - CORDOBA", "AGUA DE DIOS - CUNDINAMARCA", "ALBAN - CUNDINAMARCA", "ANAPOIMA - CUNDINAMARCA", "ANOLAIMA - CUNDINAMARCA", "ARBELAEZ - CUNDINAMARCA", "BELTRAN - CUNDINAMARCA", "BITUIMA - CUNDINAMARCA", "BOJACA - CUNDINAMARCA", "CABRERA - CUNDINAMARCA", "CACHIPAY - CUNDINAMARCA", "CAJICA - CUNDINAMARCA", "CAPARRAPI - CUNDINAMARCA", "CAQUEZA - CUNDINAMARCA", "CARMEN DE CARUPA - CUNDINAMARCA", "CHAGUANI - CUNDINAMARCA", "CHIA - CUNDINAMARCA", "CHIPAQUE - CUNDINAMARCA", "CHOACHI - CUNDINAMARCA", "CHOCONTA - CUNDINAMARCA", "COGUA - CUNDINAMARCA", "COTA - CUNDINAMARCA", "CUCUNUBA - CUNDINAMARCA", "EL COLEGIO - CUNDINAMARCA", "EL PEÑON - CUNDINAMARCA", "EL ROSAL - CUNDINAMARCA", "FACATATIVA - CUNDINAMARCA", "FOMEQUE - CUNDINAMARCA", "FOSCA - CUNDINAMARCA", "FUNZA - CUNDINAMARCA", "FUQUENE - CUNDINAMARCA", "FUSAGASUGA - CUNDINAMARCA", "GACHALA - CUNDINAMARCA", "GACHANCIPA - CUNDINAMARCA", "GACHETA - CUNDINAMARCA", "GAMA - CUNDINAMARCA", "GIRARDOT - CUNDINAMARCA", "GRANADA - CUNDINAMARCA", "GUACHETA - CUNDINAMARCA", "GUADUAS - CUNDINAMARCA", "GUASCA - CUNDINAMARCA", "GUATAQUI - CUNDINAMARCA", "GUATAVITA - CUNDINAMARCA", "GUAYABAL DE SIQUIMA - CUNDINAMARCA", "GUAYABETAL - CUNDINAMARCA", "GUTIERREZ - CUNDINAMARCA", "JERUSALEN - CUNDINAMARCA", "JUNIN - CUNDINAMARCA", "LA CALERA - CUNDINAMARCA", "LA MESA - CUNDINAMARCA", "LA PALMA - CUNDINAMARCA", "LA PEÑA - CUNDINAMARCA", "LA VEGA - CUNDINAMARCA", "LENGUAZAQUE - CUNDINAMARCA", "MACHETA - CUNDINAMARCA", "MADRID - CUNDINAMARCA", "MANTA - CUNDINAMARCA", "MEDINA - CUNDINAMARCA", "MOSQUERA - CUNDINAMARCA", "NARIÑO - CUNDINAMARCA", "NEMOCON - CUNDINAMARCA", "NILO - CUNDINAMARCA", "NIMAIMA - CUNDINAMARCA", "NOCAIMA - CUNDINAMARCA", "VENECIA - CUNDINAMARCA", "PACHO - CUNDINAMARCA", "PAIME - CUNDINAMARCA", "PANDI - CUNDINAMARCA", "PARATEBUENO - CUNDINAMARCA", "PASCA - CUNDINAMARCA", "PUERTO SALGAR - CUNDINAMARCA", "PULI - CUNDINAMARCA", "QUEBRADANEGRA - CUNDINAMARCA", "QUETAME - CUNDINAMARCA", "QUIPILE - CUNDINAMARCA", "APULO - CUNDINAMARCA", "RICAURTE - CUNDINAMARCA", "SAN ANTONIO DEL TEQUENDAMA - CUNDINAMARCA", "SAN BERNARDO - CUNDINAMARCA", "SAN CAYETANO - CUNDINAMARCA", "SAN FRANCISCO - CUNDINAMARCA", "SAN JUAN DE RIO SECO - CUNDINAMARCA", "SASAIMA - CUNDINAMARCA", "SESQUILE - CUNDINAMARCA", "SIBATE - CUNDINAMARCA", "SILVANIA - CUNDINAMARCA", "SIMIJACA - CUNDINAMARCA", "SOACHA - CUNDINAMARCA", "SOPO - CUNDINAMARCA", "SUBACHOQUE - CUNDINAMARCA", "SUESCA - CUNDINAMARCA", "SUPATA - CUNDINAMARCA", "SUSA - CUNDINAMARCA", "SUTATAUSA - CUNDINAMARCA", "TABIO - CUNDINAMARCA", "TAUSA - CUNDINAMARCA", "TENA - CUNDINAMARCA", "TENJO - CUNDINAMARCA", "TIBACUY - CUNDINAMARCA", "TIBIRITA - CUNDINAMARCA", "TOCAIMA - CUNDINAMARCA", "TOCANCIPA - CUNDINAMARCA", "TOPAIPI - CUNDINAMARCA", "UBALA - CUNDINAMARCA", "UBAQUE - CUNDINAMARCA", "VILLA DE SAN DIEGO DE UBATE - CUNDINAMARCA", "UNE - CUNDINAMARCA", "UTICA - CUNDINAMARCA", "VERGARA - CUNDINAMARCA", "VIANI - CUNDINAMARCA", "VILLAGOMEZ - CUNDINAMARCA", "VILLAPINZON - CUNDINAMARCA", "VILLETA - CUNDINAMARCA", "VIOTA - CUNDINAMARCA", "YACOPI - CUNDINAMARCA", "ZIPACON - CUNDINAMARCA", "ZIPAQUIRA - CUNDINAMARCA", "QUIBDO - CHOCO", "ACANDI - CHOCO", "ALTO BAUDO - CHOCO", "ATRATO - CHOCO", "BAGADO - CHOCO", "BAHIA SOLANO - CHOCO", "BAJO BAUDO - CHOCO", "BOJAYA - CHOCO", "EL CANTON DEL SAN PABLO - CHOCO", "CARMEN DEL DARIEN - CHOCO", "CERTEGUI - CHOCO", "CONDOTO - CHOCO", "EL CARMEN DE ATRATO - CHOCO", "EL LITORAL DEL SAN JUAN - CHOCO", "ISTMINA - CHOCO", "JURADO - CHOCO", "LLORO - CHOCO", "MEDIO ATRATO - CHOCO", "MEDIO BAUDO - CHOCO", "MEDIO SAN JUAN - CHOCO", "NOVITA - CHOCO", "NUQUI - CHOCO", "RIO IRO - CHOCO", "RIO QUITO - CHOCO", "RIOSUCIO - CHOCO", "SAN JOSE DEL PALMAR - CHOCO", "SIPI - CHOCO", "TADO - CHOCO", "UNGUIA - CHOCO", "UNION PANAMERICANA - CHOCO", "NEIVA - HUILA", "ACEVEDO - HUILA", "AGRADO - HUILA", "AIPE - HUILA", "ALGECIRAS - HUILA", "ALTAMIRA - HUILA", "BARAYA - HUILA", "CAMPOALEGRE - HUILA", "COLOMBIA - HUILA", "ELIAS - HUILA", "GARZON - HUILA", "GIGANTE - HUILA", "GUADALUPE - HUILA", "HOBO - HUILA", "IQUIRA - HUILA", "ISNOS - HUILA", "LA ARGENTINA - HUILA", "LA PLATA - HUILA", "NATAGA - HUILA", "OPORAPA - HUILA", "PAICOL - HUILA", "PALERMO - HUILA", "PALESTINA - HUILA", "PITAL - HUILA", "PITALITO - HUILA", "RIVERA - HUILA", "SALADOBLANCO - HUILA", "SAN AGUSTIN - HUILA", "SANTA MARIA - HUILA", "SUAZA - HUILA", "TARQUI - HUILA", "TESALIA - HUILA", "TELLO - HUILA", "TERUEL - HUILA", "TIMANA - HUILA", "VILLAVIEJA - HUILA", "YAGUARA - HUILA", "RIOHACHA - LA GUAJIRA", "ALBANIA - LA GUAJIRA", "BARRANCAS - LA GUAJIRA", "DIBULLA - LA GUAJIRA", "DISTRACCION - LA GUAJIRA", "EL MOLINO - LA GUAJIRA", "FONSECA - LA GUAJIRA", "HATONUEVO - LA GUAJIRA", "LA JAGUA DEL PILAR - LA GUAJIRA", "MAICAO - LA GUAJIRA", "MANAURE - LA GUAJIRA", "SAN JUAN DEL CESAR - LA GUAJIRA", "URIBIA - LA GUAJIRA", "URUMITA - LA GUAJIRA", "VILLANUEVA - LA GUAJIRA", "SANTA MARTA - MAGDALENA", "ALGARROBO - MAGDALENA", "ARACATACA - MAGDALENA", "ARIGUANI - MAGDALENA", "CERRO SAN ANTONIO - MAGDALENA", "CHIBOLO - MAGDALENA", "CIENAGA - MAGDALENA", "CONCORDIA - MAGDALENA", "EL BANCO - MAGDALENA", "EL PIÑON - MAGDALENA", "EL RETEN - MAGDALENA", "FUNDACION - MAGDALENA", "GUAMAL - MAGDALENA", "NUEVA GRANADA - MAGDALENA", "PEDRAZA - MAGDALENA", "PIJIÑO DEL CARMEN - MAGDALENA", "PIVIJAY - MAGDALENA", "PLATO - MAGDALENA", "PUEBLOVIEJO - MAGDALENA", "REMOLINO - MAGDALENA", "SABANAS DE SAN ANGEL - MAGDALENA", "SALAMINA - MAGDALENA", "SAN SEBASTIAN DE BUENAVISTA - MAGDALENA", "SAN ZENON - MAGDALENA", "SANTA ANA - MAGDALENA", "SANTA BARBARA DE PINTO - MAGDALENA", "SITIONUEVO - MAGDALENA", "TENERIFE - MAGDALENA", "ZAPAYAN - MAGDALENA", "ZONA BANANERA - MAGDALENA", "VILLAVICENCIO - META", "ACACIAS - META", "BARRANCA DE UPIA - META", "CABUYARO - META", "CASTILLA LA NUEVA - META", "CUBARRAL - META", "CUMARAL - META", "EL CALVARIO - META", "EL CASTILLO - META", "EL DORADO - META", "FUENTE DE ORO - META", "GRANADA - META", "GUAMAL - META", "MAPIRIPAN - META", "MESETAS - META", "LA MACARENA - META", "URIBE - META", "LEJANIAS - META", "PUERTO CONCORDIA - META", "PUERTO GAITAN - META", "PUERTO LOPEZ - META", "PUERTO LLERAS - META", "PUERTO RICO - META", "RESTREPO - META", "SAN CARLOS DE GUAROA - META", "SAN JUAN DE ARAMA - META", "SAN JUANITO - META", "SAN MARTIN - META", "VISTAHERMOSA - META", "PASTO - NARIÑO", "ALBAN - NARIÑO", "ALDANA - NARIÑO", "ANCUYA - NARIÑO", "ARBOLEDA - NARIÑO", "BARBACOAS - NARIÑO", "BELEN - NARIÑO", "BUESACO - NARIÑO", "COLON - NARIÑO", "CONSACA - NARIÑO", "CONTADERO - NARIÑO", "CORDOBA - NARIÑO", "CUASPUD - NARIÑO", "CUMBAL - NARIÑO", "CUMBITARA - NARIÑO", "CHACHAGsI - NARIÑO", "EL CHARCO - NARIÑO", "EL PEÑOL - NARIÑO", "EL ROSARIO - NARIÑO", "EL TABLON DE GOMEZ - NARIÑO", "EL TAMBO - NARIÑO", "FUNES - NARIÑO", "GUACHUCAL - NARIÑO", "GUAITARILLA - NARIÑO", "GUALMATAN - NARIÑO", "ILES - NARIÑO", "IMUES - NARIÑO", "IPIALES - NARIÑO", "LA CRUZ - NARIÑO", "LA FLORIDA - NARIÑO", "LA LLANADA - NARIÑO", "LA TOLA - NARIÑO", "LA UNION - NARIÑO", "LEIVA - NARIÑO", "LINARES - NARIÑO", "LOS ANDES - NARIÑO", "MAGsI - NARIÑO", "MALLAMA - NARIÑO", "MOSQUERA - NARIÑO", "NARIÑO - NARIÑO", "OLAYA HERRERA - NARIÑO", "OSPINA - NARIÑO", "FRANCISCO PIZARRO - NARIÑO", "POLICARPA - NARIÑO", "POTOSI - NARIÑO", "PROVIDENCIA - NARIÑO", "PUERRES - NARIÑO", "PUPIALES - NARIÑO", "RICAURTE - NARIÑO", "ROBERTO PAYAN - NARIÑO", "SAMANIEGO - NARIÑO", "SANDONA - NARIÑO", "SAN BERNARDO - NARIÑO", "SAN LORENZO - NARIÑO", "SAN PABLO - NARIÑO", "SAN PEDRO DE CARTAGO - NARIÑO", "SANTA BARBARA - NARIÑO", "SANTACRUZ - NARIÑO", "SAPUYES - NARIÑO", "TAMINANGO - NARIÑO", "TANGUA - NARIÑO", "SAN ANDRES DE TUMACO - NARIÑO", "TUQUERRES - NARIÑO", "YACUANQUER - NARIÑO", "CUCUTA - N. DE SANTANDER", "ABREGO - N. DE SANTANDER", "ARBOLEDAS - N. DE SANTANDER", "BOCHALEMA - N. DE SANTANDER", "BUCARASICA - N. DE SANTANDER", "CACOTA - N. DE SANTANDER", "CACHIRA - N. DE SANTANDER", "CHINACOTA - N. DE SANTANDER", "CHITAGA - N. DE SANTANDER", "CONVENCION - N. DE SANTANDER", "CUCUTILLA - N. DE SANTANDER", "DURANIA - N. DE SANTANDER", "EL CARMEN - N. DE SANTANDER", "EL TARRA - N. DE SANTANDER", "EL ZULIA - N. DE SANTANDER", "GRAMALOTE - N. DE SANTANDER", "HACARI - N. DE SANTANDER", "HERRAN - N. DE SANTANDER", "LABATECA - N. DE SANTANDER", "LA ESPERANZA - N. DE SANTANDER", "LA PLAYA - N. DE SANTANDER", "LOS PATIOS - N. DE SANTANDER", "LOURDES - N. DE SANTANDER", "MUTISCUA - N. DE SANTANDER", "OCAÑA - N. DE SANTANDER", "PAMPLONA - N. DE SANTANDER", "PAMPLONITA - N. DE SANTANDER", "PUERTO SANTANDER - N. DE SANTANDER", "RAGONVALIA - N. DE SANTANDER", "SALAZAR - N. DE SANTANDER", "SAN CALIXTO - N. DE SANTANDER", "SAN CAYETANO - N. DE SANTANDER", "SANTIAGO - N. DE SANTANDER", "SARDINATA - N. DE SANTANDER", "SILOS - N. DE SANTANDER", "TEORAMA - N. DE SANTANDER", "TIBU - N. DE SANTANDER", "TOLEDO - N. DE SANTANDER", "VILLA CARO - N. DE SANTANDER", "VILLA DEL ROSARIO - N. DE SANTANDER", "ARMENIA - QUINDIO", "BUENAVISTA - QUINDIO", "CALARCA - QUINDIO", "CIRCASIA - QUINDIO", "CORDOBA - QUINDIO", "FILANDIA - QUINDIO", "GENOVA - QUINDIO", "LA TEBAIDA - QUINDIO", "MONTENEGRO - QUINDIO", "PIJAO - QUINDIO", "QUIMBAYA - QUINDIO", "SALENTO - QUINDIO", "PEREIRA - RISARALDA", "APIA - RISARALDA", "BALBOA - RISARALDA", "BELEN DE UMBRIA - RISARALDA", "DOSQUEBRADAS - RISARALDA", "GUATICA - RISARALDA", "LA CELIA - RISARALDA", "LA VIRGINIA - RISARALDA", "MARSELLA - RISARALDA", "MISTRATO - RISARALDA", "PUEBLO RICO - RISARALDA", "QUINCHIA - RISARALDA", "SANTA ROSA DE CABAL - RISARALDA", "SANTUARIO - RISARALDA", "BUCARAMANGA - SANTANDER", "AGUADA - SANTANDER", "ALBANIA - SANTANDER", "ARATOCA - SANTANDER", "BARBOSA - SANTANDER", "BARICHARA - SANTANDER", "BARRANCABERMEJA - SANTANDER", "BETULIA - SANTANDER", "BOLIVAR - SANTANDER", "CABRERA - SANTANDER", "CALIFORNIA - SANTANDER", "CAPITANEJO - SANTANDER", "CARCASI - SANTANDER", "CEPITA - SANTANDER", "CERRITO - SANTANDER", "CHARALA - SANTANDER", "CHARTA - SANTANDER", "CHIMA - SANTANDER", "CHIPATA - SANTANDER", "CIMITARRA - SANTANDER", "CONCEPCION - SANTANDER", "CONFINES - SANTANDER", "CONTRATACION - SANTANDER", "COROMORO - SANTANDER", "CURITI - SANTANDER", "EL CARMEN DE CHUCURI - SANTANDER", "EL GUACAMAYO - SANTANDER", "EL PEÑON - SANTANDER", "EL PLAYON - SANTANDER", "ENCINO - SANTANDER", "ENCISO - SANTANDER", "FLORIAN - SANTANDER", "FLORIDABLANCA - SANTANDER", "GALAN - SANTANDER", "GAMBITA - SANTANDER", "GIRON - SANTANDER", "GUACA - SANTANDER", "GUADALUPE - SANTANDER", "GUAPOTA - SANTANDER", "GUAVATA - SANTANDER", "GsEPSA - SANTANDER", "HATO - SANTANDER", "JESUS MARIA - SANTANDER", "JORDAN - SANTANDER", "LA BELLEZA - SANTANDER", "LANDAZURI - SANTANDER", "LA PAZ - SANTANDER", "LEBRIJA - SANTANDER", "LOS SANTOS - SANTANDER", "MACARAVITA - SANTANDER", "MALAGA - SANTANDER", "MATANZA - SANTANDER", "MOGOTES - SANTANDER", "MOLAGAVITA - SANTANDER", "OCAMONTE - SANTANDER", "OIBA - SANTANDER", "ONZAGA - SANTANDER", "PALMAR - SANTANDER", "PALMAS DEL SOCORRO - SANTANDER", "PARAMO - SANTANDER", "PIEDECUESTA - SANTANDER", "PINCHOTE - SANTANDER", "PUENTE NACIONAL - SANTANDER", "PUERTO PARRA - SANTANDER", "PUERTO WILCHES - SANTANDER", "RIONEGRO - SANTANDER", "SABANA DE TORRES - SANTANDER", "SAN ANDRES - SANTANDER", "SAN BENITO - SANTANDER", "SAN GIL - SANTANDER", "SAN JOAQUIN - SANTANDER", "SAN JOSE DE MIRANDA - SANTANDER", "SAN MIGUEL - SANTANDER", "SAN VICENTE DE CHUCURI - SANTANDER", "SANTA BARBARA - SANTANDER", "SANTA HELENA DEL OPON - SANTANDER", "SIMACOTA - SANTANDER", "SOCORRO - SANTANDER", "SUAITA - SANTANDER", "SUCRE - SANTANDER", "SURATA - SANTANDER", "TONA - SANTANDER", "VALLE DE SAN JOSE - SANTANDER", "VELEZ - SANTANDER", "VETAS - SANTANDER", "VILLANUEVA - SANTANDER", "ZAPATOCA - SANTANDER", "SINCELEJO - SUCRE", "BUENAVISTA - SUCRE", "CAIMITO - SUCRE", "COLOSO - SUCRE", "COROZAL - SUCRE", "COVEÑAS - SUCRE", "CHALAN - SUCRE", "EL ROBLE - SUCRE", "GALERAS - SUCRE", "GUARANDA - SUCRE", "LA UNION - SUCRE", "LOS PALMITOS - SUCRE", "MAJAGUAL - SUCRE", "MORROA - SUCRE", "OVEJAS - SUCRE", "PALMITO - SUCRE", "SAMPUES - SUCRE", "SAN BENITO ABAD - SUCRE", "SAN JUAN DE BETULIA - SUCRE", "SAN MARCOS - SUCRE", "SAN ONOFRE - SUCRE", "SAN PEDRO - SUCRE", "SAN LUIS DE SINCE - SUCRE", "SUCRE - SUCRE", "SANTIAGO DE TOLU - SUCRE", "TOLU VIEJO - SUCRE", "IBAGUE - TOLIMA", "ALPUJARRA - TOLIMA", "ALVARADO - TOLIMA", "AMBALEMA - TOLIMA", "ANZOATEGUI - TOLIMA", "ARMERO - TOLIMA", "ATACO - TOLIMA", "CAJAMARCA - TOLIMA", "CARMEN DE APICALA - TOLIMA", "CASABIANCA - TOLIMA", "CHAPARRAL - TOLIMA", "COELLO - TOLIMA", "COYAIMA - TOLIMA", "CUNDAY - TOLIMA", "DOLORES - TOLIMA", "ESPINAL - TOLIMA", "FALAN - TOLIMA", "FLANDES - TOLIMA", "FRESNO - TOLIMA", "GUAMO - TOLIMA", "HERVEO - TOLIMA", "HONDA - TOLIMA", "ICONONZO - TOLIMA", "LERIDA - TOLIMA", "LIBANO - TOLIMA", "MARIQUITA - TOLIMA", "MELGAR - TOLIMA", "MURILLO - TOLIMA", "NATAGAIMA - TOLIMA", "ORTEGA - TOLIMA", "PALOCABILDO - TOLIMA", "PIEDRAS - TOLIMA", "PLANADAS - TOLIMA", "PRADO - TOLIMA", "PURIFICACION - TOLIMA", "RIOBLANCO - TOLIMA", "RONCESVALLES - TOLIMA", "ROVIRA - TOLIMA", "SALDAÑA - TOLIMA", "SAN ANTONIO - TOLIMA", "SAN LUIS - TOLIMA", "SANTA ISABEL - TOLIMA", "SUAREZ - TOLIMA", "VALLE DE SAN JUAN - TOLIMA", "VENADILLO - TOLIMA", "VILLAHERMOSA - TOLIMA", "VILLARRICA - TOLIMA", "CALI - VALLE DEL CAUCA", "ALCALA - VALLE DEL CAUCA", "ANDALUCIA - VALLE DEL CAUCA", "ANSERMANUEVO - VALLE DEL CAUCA", "ARGELIA - VALLE DEL CAUCA", "BOLIVAR - VALLE DEL CAUCA", "BUENAVENTURA - VALLE DEL CAUCA", "GUADALAJARA DE BUGA - VALLE DEL CAUCA", "BUGALAGRANDE - VALLE DEL CAUCA", "CAICEDONIA - VALLE DEL CAUCA", "CALIMA - VALLE DEL CAUCA", "CANDELARIA - VALLE DEL CAUCA", "CARTAGO - VALLE DEL CAUCA", "DAGUA - VALLE DEL CAUCA", "EL AGUILA - VALLE DEL CAUCA", "EL CAIRO - VALLE DEL CAUCA", "EL CERRITO - VALLE DEL CAUCA", "EL DOVIO - VALLE DEL CAUCA", "FLORIDA - VALLE DEL CAUCA", "GINEBRA - VALLE DEL CAUCA", "GUACARI - VALLE DEL CAUCA", "JAMUNDI - VALLE DEL CAUCA", "LA CUMBRE - VALLE DEL CAUCA", "LA UNION - VALLE DEL CAUCA", "LA VICTORIA - VALLE DEL CAUCA", "OBANDO - VALLE DEL CAUCA", "PALMIRA - VALLE DEL CAUCA", "PRADERA - VALLE DEL CAUCA", "RESTREPO - VALLE DEL CAUCA", "RIOFRIO - VALLE DEL CAUCA", "ROLDANILLO - VALLE DEL CAUCA", "SAN PEDRO - VALLE DEL CAUCA", "SEVILLA - VALLE DEL CAUCA", "TORO - VALLE DEL CAUCA", "TRUJILLO - VALLE DEL CAUCA", "TULUA - VALLE DEL CAUCA", "ULLOA - VALLE DEL CAUCA", "VERSALLES - VALLE DEL CAUCA", "VIJES - VALLE DEL CAUCA", "YOTOCO - VALLE DEL CAUCA", "YUMBO - VALLE DEL CAUCA", "ZARZAL - VALLE DEL CAUCA", "ARAUCA - ARAUCA", "ARAUQUITA - ARAUCA", "CRAVO NORTE - ARAUCA", "FORTUL - ARAUCA", "PUERTO RONDON - ARAUCA", "SARAVENA - ARAUCA", "TAME - ARAUCA", "YOPAL - CASANARE", "AGUAZUL - CASANARE", "CHAMEZA - CASANARE", "HATO COROZAL - CASANARE", "LA SALINA - CASANARE", "MANI - CASANARE", "MONTERREY - CASANARE", "NUNCHIA - CASANARE", "OROCUE - CASANARE", "PAZ DE ARIPORO - CASANARE", "PORE - CASANARE", "RECETOR - CASANARE", "SABANALARGA - CASANARE", "SACAMA - CASANARE", "SAN LUIS DE PALENQUE - CASANARE", "TAMARA - CASANARE", "TAURAMENA - CASANARE", "TRINIDAD - CASANARE", "VILLANUEVA - CASANARE", "MOCOA - PUTUMAYO", "COLON - PUTUMAYO", "ORITO - PUTUMAYO", "PUERTO ASIS - PUTUMAYO", "PUERTO CAICEDO - PUTUMAYO", "PUERTO GUZMAN - PUTUMAYO", "LEGUIZAMO - PUTUMAYO", "SIBUNDOY - PUTUMAYO", "SAN FRANCISCO - PUTUMAYO", "SAN MIGUEL - PUTUMAYO", "SANTIAGO - PUTUMAYO", "VALLE DEL GUAMUEZ - PUTUMAYO", "VILLAGARZON - PUTUMAYO", "SAN ANDRES - SAN ANDRES", "PROVIDENCIA - SAN ANDRES", "LETICIA - AMAZONAS", "EL ENCANTO - AMAZONAS", "LA CHORRERA - AMAZONAS", "LA PEDRERA - AMAZONAS", "LA VICTORIA - AMAZONAS", "MIRITI - PARANA - AMAZONAS", "PUERTO ALEGRIA - AMAZONAS", "PUERTO ARICA - AMAZONAS", "PUERTO NARIÑO - AMAZONAS", "PUERTO SANTANDER - AMAZONAS", "TARAPACA - AMAZONAS", "INIRIDA - GUAINIA", "BARRANCO MINAS - GUAINIA", "MAPIRIPANA - GUAINIA", "SAN FELIPE - GUAINIA", "PUERTO COLOMBIA - GUAINIA", "LA GUADALUPE - GUAINIA", "CACAHUAL - GUAINIA", "PANA PANA - GUAINIA", "MORICHAL - GUAINIA", "SAN JOSE DEL GUAVIARE - GUAVIARE", "CALAMAR - GUAVIARE", "EL RETORNO - GUAVIARE", "MIRAFLORES - GUAVIARE", "MITU - VAUPES", "CARURU - VAUPES", "PACOA - VAUPES", "TARAIRA - VAUPES", "PAPUNAUA - VAUPES", "YAVARATE - VAUPES", "PUERTO CARREÑO - VICHADA", "LA PRIMAVERA - VICHADA", "SANTA ROSALIA - VICHADA", "CUMARIBO - VICHADA"})
        Me.ComboBox_ACTIVIDAD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox_ACTIVIDAD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox_ACTIVIDAD.BackColor = System.Drawing.Color.White
        Me.BunifuTransition1.SetDecoration(Me.ComboBox_ACTIVIDAD, BunifuAnimatorNS.DecorationType.None)
        Me.ComboBox_ACTIVIDAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_ACTIVIDAD.ForeColor = System.Drawing.Color.Black
        Me.ComboBox_ACTIVIDAD.FormattingEnabled = True
        Me.ComboBox_ACTIVIDAD.ItemHeight = 16
        Me.ComboBox_ACTIVIDAD.Items.AddRange(New Object() {"Procesamiento y conservación de carne y productos cárnicos", "Procesamiento y conservación de pescados, crustáceos y moluscos", "Elaboración de aceites y grasas de origen vegetal y animal", "Elaboración de productos de molinería", "Elaboración de almidones y productos derivados del almidón", "Descafeinado, tostión y molienda del café", "Elaboración de otros derivados del café", "Elaboración y refinación de azúcar", "Elaboración de panela", "Elaboración de productos de panadería", "Elaboración de cacao, chocolate y productos de confitería", "Elaboración de macarrones, fideos, alcuzcuz y productos farináceos similares", "Elaboración de comidas y platos preparados", "Elaboración de otros productos alimenticios n.c.p.", "Elaboración de alimentos preparados para animales", "Confección de prendas de vestir, excepto prendas de piel", "Fabricación de calzado de cuero y piel, con cualquier tipo de suela", "Fabricación de otros tipos de calzado, excepto calzado de cuero y piel", "Procesamiento y conservación de frutas, legumbres, hortalizas y tubérculos (excep" &
                "to elaboración de jugos de frutas)", "Elaboración de productos lácteos (excepto bebidas)", "Fabricación de prendas de vestir de piel", "Fabricación de prendas de vestir  de punto y ganchillo", "Edición y publicación de libros (Tarifa especial para los contribuyentes que cump" &
                "len condiciones del Acuerdo 98 de 2003)", "Industrias básicas de hierro y de acero", "Fundición de hierro y de acero", "Fundición de metales no ferrosos", "Fabricación de vehículos automotores y sus motores", "Fabricación de carrocerías para vehículos automotores; fabricación de remolques y" &
                " semirremolques", "Fabricación de partes, piezas (autopartes) y accesorios (lujos) para vehículos au" &
                "tomotores", "Construcción de barcos y de estructuras flotantes", "Construcción de embarcaciones de recreo y deporte", "Fabricación de locomotoras y de material rodante para ferrocarriles", "Fabricación de aeronaves, naves espaciales y de maquinaria conexa", "Fabricación de vehículos militares de combate", "Fabricación de motocicletas", "Fabricación de bicicletas y de sillas de ruedas para personas con discapacidad", "Fabricación de otros tipos de equipo de transporte n.c.p.", "Extracción de hulla (carbón de piedra)", "Extracción de carbón lignito", "Extracción de petróleo crudo", "Extracción de gas natural", "Extracción de minerales de hierro", "Extracción de minerales de uranio y de torio", "Extracción de oro y otros metales preciosos", "Extracción de minerales de níquel", "Extracción de otros minerales metalíferos no ferrosos n.c.p.", "Extracción de piedra, arena, arcillas comunes, yeso y anhidrita", "Extracción de arcillas de uso industrial, caliza, caolín y bentonitas", "Extracción de esmeraldas, piedras preciosas y semipreciosas", "Extracción de minerales para la fabricación de abonos y productos químicos", "Extracción de halita (sal)", "Extracción de otros minerales no metálicos n.c.p.", "Destilación, rectificación y mezcla de bebidas alcohólicas", "Elaboración de bebidas fermentadas no destiladas", "Producción de malta, elaboración de cervezas y otras bebidas malteadas", "Elaboración de bebidas no alcohólicas, producción de aguas minerales y de otras a" &
                "guas embotelladas", "Elaboración de productos de tabaco", "Preparación e hilatura de fibras textiles", "Tejeduría de productos textiles", "Acabado de productos textiles", "Fabricación de tejidos de punto y ganchillo", "Confección de artículos con materiales textiles, excepto prendas de vestir", "Fabricación de tapetes y alfombras para pisos", "Fabricación de cuerdas, cordeles, cables, bramantes y redes", "Fabricación de otros artículos textiles n.c.p.", "Curtido y recurtido de cueros; recurtido y teñido de pieles.", "Fabricación de artículos de viaje, bolsos de mano y artículos similares elaborado" &
                "s en cuero, y fabricación de artículos de talabartería y guarnicionería.", "Fabricación de artículos de viaje, bolsos de mano y artículos similares; artículo" &
                "s de talabartería y guarnicionería elaborados en otros materiales", "Fabricación de partes del calzado", "Aserrado, acepillado e impregnación de la madera", "Fabricación de hojas de madera para enchapado; fabricación de tableros contrachap" &
                "ados, tableros laminados, tableros de partículas y otros tableros y paneles", "Fabricación de partes y piezas de madera, de carpintería y ebanistería para la co" &
                "nstrucción y para edificios", "Fabricación de recipientes de madera", "Fabricación de otros productos de madera; fabricación de artículos de corcho, ces" &
                "tería y espartería", "Fabricación de pulpas (pastas) celulósicas; papel y cartón", "Fabricación de papel y cartón ondulado (corrugado); fabricación de envases, empaq" &
                "ues y de embalajes de papel y cartón.", "Fabricación de otros artículos de papel y cartón", "Fabricación de productos de hornos de coque", "Fabricación de productos de la refinación del petróleo", "Actividad de mezcla de combustibles", "Fabricación de sustancias y productos químicos básicos", "Fabricación de abonos y compuestos inorgánicos nitrogenados", "Fabricación de plásticos en formas primarias", "Fabricación de caucho sintético en formas primarias", "Fabricación de plaguicidas y otros productos químicos de uso agropecuario", "Fabricación de pinturas, barnices y revestimientos similares, tintas para impresi" &
                "ón y masillas", "Fabricación de jabones y detergentes, preparados para limpiar y pulir; perfumes y" &
                " preparados de tocador", "Fabricación de otros productos químicos n.c.p.", "Fabricación de fibras sintéticas y artificiales", "Fabricación de productos farmacéuticos, sustancias químicas medicinales y product" &
                "os botánicos de uso farmacéutico", "Fabricación de llantas y neumáticos de caucho", "Reencauche de llantas usadas", "Fabricación de formas básicas de caucho y otros productos de caucho n.c.p.", "Fabricación de formas básicas de caucho y otros productos de caucho n.c.p.", "Fabricación de formas básicas de plástico", "Fabricación de artículos de plástico n.c.p.", "Fabricación de vidrio y productos de vidrio", "Fabricación de productos refractarios", "Fabricación de materiales de arcilla para la construcción", "Fabricación de otros productos de cerámica y porcelana", "Fabricación de cemento, cal y yeso", "Fabricación de artículos de hormigón, cemento y yeso", "Corte, tallado y acabado de la piedra", "Fabricación de otros productos minerales no metálicos n.c.p.", "Industrias básicas de metales preciosos", "Industrias básicas de otros metales no ferrosos", "Fabricación de productos metálicos para uso estructural", "Fabricación de tanques, depósitos y recipientes de metal, excepto los utilizados " &
                "para el envase o transporte de mercancías", "Fabricación de generadores de vapor, excepto calderas de agua caliente para calef" &
                "acción central", "Fabricación de armas y municiones", "Forja, prensado, estampado y laminado de metal; pulvimetalurgia", "Fabricación de artículos de cuchillería, herramientas de mano y artículos de ferr" &
                "etería", "Fabricación de otros productos elaborados de metal n.c.p.", "Fabricación de componentes y tableros electrónicos", "Fabricación de computadoras y de equipo periférico", "Fabricación de equipos de comunicación", "Fabricación de aparatos electrónicos de consumo", "Fabricación de equipo de medición, prueba, navegación y control", "Fabricación de relojes", "Fabricación de equipo de irradiación y equipo electrónico de uso médico y terapéu" &
                "tico", "Fabricación de instrumentos ópticos y equipo fotográfico", "Fabricación de soportes magnéticos y ópticos", "Fabricación de motores, generadores y transformadores eléctricos.", "Fabricación de aparatos de distribución y control de la energía eléctrica", "Fabricación de pilas, baterías y acumuladores eléctricos", "Fabricación de hilos y cables eléctricos y de fibra óptica", "Fabricación de dispositivos de cableado", "Fabricación de equipos eléctricos de iluminación", "Fabricación de aparatos de uso domestico", "Fabricación de otros tipos de equipo eléctrico n.c.p.", "Fabricación de motores, turbinas, y partes para motores de combustión interna", "Fabricación de equipos de potencia hidráulica y neumática", "Fabricación de otras bombas, compresores, grifos y válvulas", "Fabricación de cojinetes, engranajes, trenes de engranajes y piezas de transmisió" &
                "n", "Fabricación de hornos, hogares y quemadores industriales", "Fabricación de equipo de elevación y manipulación", "Fabricación de maquinaria y equipo de oficina (excepto computadoras y equipo peri" &
                "férico)", "Fabricación de herramientas manuales con motor", "Fabricación de otros tipos de maquinaria y equipo de uso general n.c.p.", "Fabricación de maquinaria agropecuaria y forestal", "Fabricación de máquinas formadoras de metal y de máquinas herramienta", "Fabricación de maquinaria para la metalurgia", "Fabricación de maquinaria para explotación de minas y canteras y para obras de co" &
                "nstrucción", "Fabricación de maquinaria para la elaboración de alimentos, bebidas y tabaco", "Fabricación de maquinaria para la elaboración de productos textiles, prendas de v" &
                "estir y cueros", "Fabricación de otros tipos de maquinaria y equipo de uso especial n.c.p.", "Fabricación de muebles", "Fabricación de colchones y somieres", "Fabricación de joyas, bisutería y artículos conexos", "Fabricación de instrumentos musicales", "Fabricación de juegos, juguetes y rompecabezas", "Fabricación de instrumentos, aparatos y materiales médicos y odontológicos (inclu" &
                "ido mobiliario)", "Otras industrias manufactureras n.c.p.", "Generación de energía eléctrica", "Transmisión de energía eléctrica", "Tratamiento y disposición de desechos no peligrosos", "Tratamiento y disposición de desechos peligrosos", "Recuperación de materiales", "Edición de directorios y listas de correo", "Otros trabajos de edición", "Edición de programas de informática (software)", "Actividades de producción de películas cinematográficas, videos, programas, anunc" &
                "ios y comerciales de televisión (excepto programación de televisión)", "Actividades de postproducción de películas cinematográficas, videos, programas, a" &
                "nuncios y comerciales de televisión  (excepto programación de televisión)", "Actividades de grabación de sonido y edición de música", "Elaboración de jugos de frutas", "Elaboración de bebidas lácteas", "Fabricación de artículos de piel (excepto prendas de vestir)", "Fabricación de artículos de punto y ganchillo (excepto prendas de vestir)", "Fabricación de artículos y equipo para la práctica del deporte   (excepto prendas" &
                " de vestir y calzado)", "Producción de gas", "Captación y tratamiento de agua", "Edición y publicación de libros", "Comercio al por mayor de productos alimenticios", "Comercio al por menor de productos agrícolas para el consumo en establecimientos " &
                "especializados", "Comercio al por menor de leche, productos lácteos y huevos, en establecimientos e" &
                "specializados", "Comercio al por menor de carnes (incluye aves de corral), productos cárnicos, pes" &
                "cados y productos de mar, en establecimientos especializados", "Comercio al por menor de otros productos alimenticios n.c.p., en establecimientos" &
                " especializados", "Comercio al por mayor de materias primas agrícolas en bruto (alimentos)", "Comercio al por mayor de productos farmacéuticos y medicinales", "Comercio al por menor en establecimientos no especializados con surtido compuesto" &
                " principalmente por alimentos, bebidas o tabaco (excepto licores y cigarrillos) " &
                "", "Comercio al por menor en establecimientos no especializados, con surtido compuest" &
                "o principalmente por drogas, medicamentos, textos escolares, libros y cuadernos." &
                "", "Comercio al por menor y al por mayor  de libros, textos escolares y cuadernos", "Comercio al por menor de productos farmacéuticos y medicinales en establecimiento" &
                "s especializados", "Comercio al por menor de alimentos en puestos de venta móviles", "Comercio al por menor de alimentos y productos agrícolas en bruto; venta de texto" &
                "s escolares y libros (incluye cuadernos escolares); venta de drogas y medicament" &
                "os realizado a través de internet", resources.GetString("ComboBox_ACTIVIDAD.Items"), "Otros tipos de comercio al por menor no realizado en establecimientos, puestos de" &
                " venta o mercados de textos escolares y libros (incluye cuadernos escolares); ve" &
                "nta de drogas y medicamentos", "Comercio de vehículos automotores nuevos", "Comercio de vehículos automotores usados", "Comercio de motocicletas", "Comercio al por mayor de materiales de construcción", "Comercio al por menor de materiales de construcción", "Comercio al por menor y al por mayor de madera y materiales para construcción; ve" &
                "nta de automotores (incluidas motocicletas)  realizado a través de internet", "Comercio al por menor y al por mayor de madera y materiales para construcción; ve" &
                "nta de automotores (incluidas motocicletas)  realizado a través de casas de vent" &
                "a o por correo", "Otros tipos de comercio al por menor no realizado en establecimientos, puestos de" &
                " venta o mercados de  materiales para construcción; venta de automotores (inclui" &
                "das motocicletas)  ", "Comercio al por menor de combustible para automotores", "Comercio al por mayor de licores y cigarrillos", "Venta de joyas", "Comercio al por mayor de combustibles  derivados del petróleo", "Comercio al por menor en establecimientos no especializados con surtido compuesto" &
                " principalmente  por licores y cigarrillos", "Comercio al por menor de licores y cigarrillos", "Comercio al por menor de cigarrillos y licores en puestos de venta móviles", "Comercio al por menor de cigarrillos y licores; venta de combustibles derivados d" &
                "el petróleo y venta de joyas  realizado a través de internet", "Comercio al por menor de cigarrillos y licores; venta de combustibles derivados d" &
                "el petróleo y venta de joyas  realizado a través de casas de venta o por correo", "Otros tipos de comercio al por menor no realizado en establecimientos, puestos de" &
                " venta o mercados de cigarrillos y licores; venta de combustibles derivados del " &
                "petróleo y venta de joyas", "Comercialización de energía eléctrica", "Comercio de partes, piezas (autopartes) y accesorios (lujos) para vehículos autom" &
                "otores", "Comercio al por mayor de productos textiles y productos confeccionados para uso d" &
                "oméstico", "Comercio al por mayor de prendas de vestir", "Comercio al por mayor de calzado", "Comercio al por mayor de aparatos y equipo de uso doméstico", "Comercio al por mayor de computadores, equipo periférico y programas de informáti" &
                "ca", "Comercio al por mayor de equipo, partes y piezas electrónicos y de telecomunicaci" &
                "ones", "Comercio al por mayor de maquinaria y equipo agropecuarios", "Comercio al por mayor de otros tipos de maquinaria y equipo n.c.p.", "Comercio al por mayor de metales y productos metalíferos", "Comercio al por mayor de productos químicos básicos, cauchos y plásticos en forma" &
                "s primarias y productos químicos de uso agropecuario", "Comercio al por mayor de desperdicios, desechos y chatarra", "Comercio al por mayor de otros productos n.c.p.", "Comercio al por mayor no especializado", "Comercio al por menor de lubricantes (aceites, grasas), aditivos y productos de l" &
                "impieza para vehículos automotores", "Comercio al por menor de computadores, equipos periféricos, programas de informát" &
                "ica y equipos de telecomunicaciones en establecimientos especializados", "Comercio al por menor de equipos y aparatos de sonido y de video, en establecimie" &
                "ntos especializados", "Comercio al por menor de productos textiles en establecimientos especializados", "Comercio al por menor de tapices, alfombras y cubrimientos para paredes y pisos e" &
                "n establecimientos especializados.", "Comercio al por menor de electrodomésticos y gasodomesticos de uso doméstico, mue" &
                "bles y equipos de iluminación", "Comercio al por menor de artículos y utensilios de uso domestico", "Comercio al por menor de otros artículos domésticos en establecimientos especiali" &
                "zados", "Comercio al por menor de artículos deportivos, en establecimientos especializados" &
                "", "Comercio al por menor de otros artículos culturales y de entretenimiento n.c.p. e" &
                "n establecimientos especializados", "Comercio al por menor de prendas de vestir y sus accesorios (incluye artículos de" &
                " piel) en establecimientos especializados", "Comercio al por menor de todo tipo de calzado y artículos de cuero y sucedáneos d" &
                "el cuero en establecimientos especializados.", "Comercio al por menor de otros productos nuevos en establecimientos especializado" &
                "s", "Comercio al por menor de artículos de segunda mano", "Comercio al por menor de productos textiles, prendas de vestir y calzado, en pues" &
                "tos de venta móviles", "Comercio al por menor de otros productos en puestos de venta móviles", "Comercio de partes, piezas y accesorios de motocicletas", "Comercio al por mayor de materias primas pecuarias y animales vivos", "Comercio al por mayor de bebidas y tabaco (diferentes a licores y cigarrillos)", "Comercio al por mayor de productos cosméticos y de tocador (excepto productos far" &
                "macéuticos y medicinales)", "Comercio al por mayor de otros utensilios domésticos n.c.p. (excepto joyas)", "Comercio al por mayor de combustibles sólidos, líquidos, gaseosos y productos con" &
                "exos (excepto combustibles derivados del petróleo)", "Comercio al por mayor de  artículos de ferretería, pinturas, productos de vidrio," &
                " equipo y materiales de fontanería y calefacción", resources.GetString("ComboBox_ACTIVIDAD.Items1"), "Comercio al por menor de bebidas y productos del tabaco, en establecimientos espe" &
                "cializados  (excepto licores y cigarrillos)", "Comercio al por menor de artículos de ferretería, pinturas y productos de vidrio " &
                "en establecimientos especializados (excepto materiales de construcción)", "Comercio al por menor de periódicos, materiales y artículos de papelería y escrit" &
                "orio, en establecimientos especializados (excepto libros, textos escolares y cua" &
                "dernos)", "Comercio al por menor de productos cosméticos y artículos de tocador en estableci" &
                "mientos especializados (excepto productos  farmacéuticos y medicinales)", "Comercio al por menor de  bebidas y tabaco en puestos de venta móviles (excepto l" &
                "icores y cigarrillos)", "Comercio al por menor de demás productos n.c.p.  realizado a través de internet", "Comercio al por menor de demás productos n.c.p.  realizado a través de casas de v" &
                "enta o por correo", "Otros tipos de comercio al por menor no realizado en establecimientos, puestos de" &
                " venta o mercados de demás productos n.c.p.", "Actividades comerciales de las casas de empeño o compraventa", "Transporte férreo de pasajeros", "Transporte férreo de carga", "Transporte de pasajeros", "Transporte mixto", "Transporte de carga por carretera", "Transporte por tuberías", "Transporte de pasajeros marítimo y de cabotaje", "Transporte de carga marítimo y de cabotaje", "Transporte fluvial de pasajeros", "Transporte fluvial de carga", "Transporte aéreo nacional de pasajeros", "Transporte aéreo internacional de pasajeros", "Transporte aéreo nacional de carga", "Transporte aéreo internacional de carga", "Actividades de puertos y servicios complementarios para el transporte acuático", "Edición de periódicos, revistas y otras publicaciones periódicas", "Actividades de programación y transmisión en el servicio de radiodifusión sonora", "Servicio de edición de libros", "Actividades de programación de televisión", "Construcción de edificios residenciales", "Construcción de edificios no residenciales", "Construcción de carreteras y vías de ferrocarril", "Construcción de proyectos de servicio público", "Construcción de otras obras de ingeniería civil", "Demolición", "Preparación del terreno", "Instalaciones eléctricas de la construcción", "Instalaciones de fontanería, calefacción y aire acondicionado de la construcción", "Otras instalaciones especializadas de la construcción", "Terminación y acabado de edificios y obras de ingeniería civil", "Otras actividades especializadas para la construcción de edificios y obras de ing" &
                "eniería civil", "Actividades de exhibición de películas cinematográficas y videos", "Actividades de consultoría informática y actividades de administración de instala" &
                "ciones informáticas", "Actividades de saneamiento ambiental y otros servicios de gestión de desechos pre" &
                "stados por contratistas de construcción, constructores y urbanizadores", "Actividades jurídicas como consultoría profesional", "Actividades de contabilidad, teneduría de libros, auditoría financiera y asesoría" &
                " tributaria como consultoría profesional", "Actividades de administración empresarial como consultoría profesional", "Actividades de consultoría de gestión", "Actividades de arquitectura e ingeniería y otras actividades conexas de consultor" &
                "ía técnica", "Ensayos y análisis técnicos como consultoría profesional", "Investigaciones y desarrollo experimental en el campo de las ciencias naturales y" &
                " la ingeniería  como consultoría profesional", "Investigaciones y desarrollo experimental en el campo de las ciencias sociales y " &
                "las humanidades  como consultoría profesional", "Estudios de mercado y realización de encuestas de opinión pública como consultorí" &
                "a profesional", "Actividades especializadas de diseño como consultoría profesional", "Otras actividades profesionales, científicas y técnicas n.c.p. como consultoría p" &
                "rofesional (incluye actividades de periodistas)", "Alojamiento en hoteles", "Alojamiento en aparta-hoteles", "Alojamiento en centros vacacionales", "Alojamiento rural", "Otros tipos de alojamientos para visitantes", "Actividades de zonas de camping y parques para vehículos recreacionales", "Servicio por horas  de alojamiento", "Otros tipos de alojamiento n.c.p.", "Expendio a la mesa de comidas preparadas", "Expendio por autoservicio de comidas preparadas", "Expendio de comidas preparadas en cafeterías", "Otros tipos de expendio de comidas preparadas n.c.p.", "Catering para eventos", "Actividades de otros servicios de comidas", "Expendio de bebidas alcohólicas para el consumo dentro del establecimiento", "Actividades de seguridad privada", "Actividades de servicios de sistemas de seguridad", "Actividades de detectives e investigadores privados", "Servicios de las casas de empeño o compraventas", "Actividades de apoyo a la agricultura", "Actividades de apoyo a la ganadería", "Tratamiento de semillas para propagación", "Servicios de apoyo a la silvicultura", "Actividades de apoyo para la extracción de petróleo y de gas natural", "Actividades de apoyo para otras actividades de explotación de minas y canteras", "Trilla de café", "Actividades de impresión", "Actividades de servicios relacionados con la impresión", "Producción de copias a partir de grabaciones originales", "Tratamiento y revestimiento de metales; mecanizado", "Mantenimiento y reparación especializado de productos elaborados en metal", "Mantenimiento y reparación especializado de maquinaria y equipo", "Mantenimiento y reparación especializado de equipo electrónico y óptico", "Mantenimiento y reparación especializado de equipo eléctrico", "Mantenimiento y reparación especializado de equipo de transporte, excepto los veh" &
                "ículos automotores, motocicletas y bicicletas", "Mantenimiento y reparación de otros tipos de equipos y sus componentes n.c.p.", "Instalación especializada de maquinaria y equipo industrial", "Distribución de energía eléctrica", "Suministro de vapor y aire acondicionado", "Evacuación y tratamiento de aguas residuales", "Recolección de desechos no peligrosos", "Recolección de desechos peligrosos", "Mantenimiento y reparación de vehículos automotores.", "Mantenimiento y reparación de motocicletas y de sus partes y piezas", "Comercio al por mayor a cambio de una retribución o por contrata", "Almacenamiento y depósito", "Actividades de estaciones, vías y servicios complementarios para el transporte te" &
                "rrestre", "Actividades de aeropuertos, servicios de navegación aérea y demás actividades con" &
                "exas al transporte aéreo", "Manipulación de carga", "Otras actividades complementarias al transporte", "Actividades postales nacionales", "Actividades de mensajería", "Actividades de distribución de películas cinematográficas, videos, programas, anu" &
                "ncios y comerciales de televisión", "Actividades de telecomunicaciones alámbricas", "Actividades de telecomunicaciones inalámbricas", "Actividades de telecomunicación satelital", "Otras actividades de telecomunicaciones", "Actividades de desarrollo de sistemas informáticos (planificación, análisis, dise" &
                "ño, programación, pruebas)", "Otras actividades de tecnologías de información y actividades de servicios inform" &
                "áticos", "Procesamiento de datos, alojamiento (hosting) y actividades relacionadas", "Portales Web", "Actividades de agencias de noticias", "Otras actividades de servicio de información n.c.p.", "Corretaje de valores y de contratos de productos básicos", "Otras actividades relacionadas con el mercado de valores", "Evaluación de riesgos y daños, y otras actividades de servicios auxiliares", "Actividades de las bolsas de valores", "Actividades inmobiliarias realizadas con bienes propios o arrendados", "Actividades inmobiliarias realizadas a cambio de una retribución o por contrata", "Publicidad", "Actividades de fotografía", "Actividades veterinarias", "Alquiler y arrendamiento de vehículos automotores", "Alquiler y arrendamiento de equipo recreativo y deportivo", "Alquiler de videos y discos", "Alquiler y arrendamiento de otros efectos personales y enseres domésticos n.c.p.", "Alquiler y arrendamiento de otros tipos de maquinaria, equipo y bienes tangibles " &
                "n.c.p.", "Arrendamiento de propiedad intelectual y productos similares, excepto obras prote" &
                "gidas por derechos de autor", "Actividades de agencias de empleo", "Actividades de agencias de empleo temporal", "Otras actividades de suministro de recurso humano", "Actividades de las agencias de viaje", "Actividades de operadores turísticos", "Otros servicios de reserva y actividades relacionadas", "Actividades combinadas de apoyo a instalaciones", "Limpieza general interior de edificios", "Otras actividades de limpieza de edificios e instalaciones industriales", "Actividades de paisajismo y servicios de mantenimiento conexos", "Actividades combinadas de servicios administrativos de oficina", "Fotocopiado, preparación de documentos y otras actividades especializadas de apoy" &
                "o a oficina", "Actividades de centros de llamadas (Call center)", "Organización de convenciones y eventos comerciales", "Actividades de agencias de cobranza y oficinas de calificación crediticia", "Actividades de envase y empaque", "Otras actividades de servicio de apoyo a las empresas n.c.p.", "Educación técnica profesional", "Educación tecnológica", "Educación de instituciones universitarias o de escuelas tecnológicas", "Educación de universidades", "Enseñanza deportiva y recreativa", "Enseñanza cultural", "Otros tipos de educación n.c.p.", "Actividades de apoyo a la educación", "Actividades de hospitales y clínicas, con internación", "Actividades de atención residencial, para el cuidado de pacientes con retardo men" &
                "tal, enfermedad mental y consumo de sustancias psicoactivas", "Actividades de atención en instituciones para el cuidado de personas mayores y/o " &
                "discapacitadas", "Otras actividades de atención en instituciones con alojamiento", "Actividades de asistencia social sin alojamiento para personas mayores y discapac" &
                "itadas", "Otras actividades de asistencia social sin alojamiento", "Actividades de parques de atracciones y parques temáticos", "Mantenimiento y reparación de computadores y de equipo periférico", "Mantenimiento y reparación de equipos de comunicación", "Mantenimiento y reparación de aparatos electrónicos de consumo", "Mantenimiento y reparación de aparatos domésticos y equipos domésticos y de jardi" &
                "nería", "Reparación de calzado y artículos de cuero", "Reparación de muebles y accesorios para el hogar", "Mantenimiento y reparación de otros efectos personales y enseres domésticos", "Lavado y limpieza, incluso la limpieza en seco, de productos textiles y de piel", "Peluquería y otros tratamientos de belleza", "Pompas fúnebres y actividades relacionadas", "Otras actividades de servicios personales n.c.p.", "Distribución de combustibles gaseosos por tuberías ", "Distribución de agua", "Actividades de saneamiento ambiental y otros servicios de gestión de desechos (ex" &
                "cepto los servicios prestados por contratistas de construcción, constructores y " &
                "urbanizadores)", "Actividades de transmisión de televisión", "Actividades jurídicas en el ejercicio de una profesión liberal", "Actividades de contabilidad, teneduría de libros, auditoría financiera y asesoría" &
                " tributaria en el ejercicio de una profesión liberal", "Actividades de administración empresarial en el ejercicio de una profesión libera" &
                "l", "Actividades de  gestión en el ejercicio de una profesión liberal", "Actividades de arquitectura e ingeniería y otras actividades conexas en el ejerci" &
                "cio de una profesión liberal", "Ensayos y análisis técnicos como consultoría profesional en el ejercicio de una p" &
                "rofesión liberal", "Investigaciones y desarrollo experimental en el campo de las ciencias naturales y" &
                " la ingeniería  en el ejercicio de una profesión liberal", "Investigaciones y desarrollo experimental en el campo de las ciencias sociales y " &
                "las humanidades  en el ejercicio de una profesión liberal", "Estudios de mercado y realización de encuestas de opinión pública en el ejercicio" &
                " de una profesión liberal", "Actividades especializadas de diseño en el ejercicio de una profesión liberal", "Otras actividades profesionales, científicas y técnicas n.c.p. en el ejercicio de" &
                " una profesión liberal", "Educación de formación laboral", "Educación académica no formal (excepto programas de educación básica primaria, bá" &
                "sica secundaria y media no gradual con fines de validación)", "Educación académica no formal impartida mediante programas de educación básica pr" &
                "imaria, básica secundaria y media no gradual con fines de validación", resources.GetString("ComboBox_ACTIVIDAD.Items2"), resources.GetString("ComboBox_ACTIVIDAD.Items3"), resources.GetString("ComboBox_ACTIVIDAD.Items4"), resources.GetString("ComboBox_ACTIVIDAD.Items5"), resources.GetString("ComboBox_ACTIVIDAD.Items6"), resources.GetString("ComboBox_ACTIVIDAD.Items7"), "Actividades de juegos de destreza, habilidad, conocimiento y fuerza", "Otras actividades recreativas y de esparcimiento n.c.p. (excepto juegos de suerte" &
                " y azar, discotecas y similares )", "Actividades de asociaciones empresariales y de empleadores", "Actividades de otras asociaciones n.c.p.", "Educación de la primera infancia", "Educación preescolar", "Educación básica primaria", "Educación básica secundaria", "Educación media académica", "Educación media técnica", "Establecimientos que combinan diferentes niveles de educación inicial, preescolar" &
                ", básica primaria, básica secundaria y media", "Banca Central", "Bancos comerciales", "Actividades de las corporaciones financieras", "Actividades de las compañías de financiamiento", "Banca de segundo piso", "Actividades de las cooperativas financieras", "Fideicomisos, fondos y entidades financieras similares", "Leasing financiero (arrendamiento financiero)", "Actividades financieras de fondos de empleados y otras formas asociativas del sec" &
                "tor solidario", "Actividades de compra de cartera o factoring", "Otras actividades de distribución de fondos", "Instituciones especiales oficiales", "Seguros generales", "Seguros de vida", "Reaseguros", "Capitalización", "Servicios de seguros sociales de salud", "Servicios de seguros sociales de riesgos profesionales", "Régimen de ahorro individual (RAI)", "Otras actividades auxiliares de las actividades de servicios financieros n.c.p.", "Actividades de agentes y corredores de seguros", "Actividades de administración de fondos", "Actividades de las casas de cambio", "Actividades de los profesionales de compra y venta de divisas", "Otras actividades de servicio financiero, excepto las de seguros y pensiones n.c." &
                "p.", "Administración de mercados financieros "})
        Me.ComboBox_ACTIVIDAD.Location = New System.Drawing.Point(16, 210)
        Me.ComboBox_ACTIVIDAD.Name = "ComboBox_ACTIVIDAD"
        Me.ComboBox_ACTIVIDAD.Size = New System.Drawing.Size(616, 24)
        Me.ComboBox_ACTIVIDAD.TabIndex = 17
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label30, BunifuAnimatorNS.DecorationType.None)
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.DimGray
        Me.Label30.Location = New System.Drawing.Point(14, 264)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(31, 13)
        Me.Label30.TabIndex = 676
        Me.Label30.Text = "Pais"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox_pais
        '
        Me.ComboBox_pais.AutoCompleteCustomSource.AddRange(New String() {"MEDELLIN - ANTIOQUIA", "ABEJORRAL - ANTIOQUIA", "ABRIAQUI - ANTIOQUIA", "ALEJANDRIA - ANTIOQUIA", "AMAGA - ANTIOQUIA", "AMALFI - ANTIOQUIA", "ANDES - ANTIOQUIA", "ANGELOPOLIS - ANTIOQUIA", "ANGOSTURA - ANTIOQUIA", "ANORI - ANTIOQUIA", "SANTAFE DE ANTIOQUIA - ANTIOQUIA", "ANZA - ANTIOQUIA", "APARTADO - ANTIOQUIA", "ARBOLETES - ANTIOQUIA", "ARGELIA - ANTIOQUIA", "ARMENIA - ANTIOQUIA", "BARBOSA - ANTIOQUIA", "BELMIRA - ANTIOQUIA", "BELLO - ANTIOQUIA", "BETANIA - ANTIOQUIA", "BETULIA - ANTIOQUIA", "CIUDAD BOLIVAR - ANTIOQUIA", "BRICEÑO - ANTIOQUIA", "BURITICA - ANTIOQUIA", "CACERES - ANTIOQUIA", "CAICEDO - ANTIOQUIA", "CALDAS - ANTIOQUIA", "CAMPAMENTO - ANTIOQUIA", "CAÑASGORDAS - ANTIOQUIA", "CARACOLI - ANTIOQUIA", "CARAMANTA - ANTIOQUIA", "CAREPA - ANTIOQUIA", "EL CARMEN DE VIBORAL - ANTIOQUIA", "CAROLINA - ANTIOQUIA", "CAUCASIA - ANTIOQUIA", "CHIGORODO - ANTIOQUIA", "CISNEROS - ANTIOQUIA", "COCORNA - ANTIOQUIA", "CONCEPCION - ANTIOQUIA", "CONCORDIA - ANTIOQUIA", "COPACABANA - ANTIOQUIA", "DABEIBA - ANTIOQUIA", "DON MATIAS - ANTIOQUIA", "EBEJICO - ANTIOQUIA", "EL BAGRE - ANTIOQUIA", "ENTRERRIOS - ANTIOQUIA", "ENVIGADO - ANTIOQUIA", "FREDONIA - ANTIOQUIA", "FRONTINO - ANTIOQUIA", "GIRALDO - ANTIOQUIA", "GIRARDOTA - ANTIOQUIA", "GOMEZ PLATA - ANTIOQUIA", "GRANADA - ANTIOQUIA", "GUADALUPE - ANTIOQUIA", "GUARNE - ANTIOQUIA", "GUATAPE - ANTIOQUIA", "HELICONIA - ANTIOQUIA", "HISPANIA - ANTIOQUIA", "ITAGUI - ANTIOQUIA", "ITUANGO - ANTIOQUIA", "JARDIN - ANTIOQUIA", "JERICO - ANTIOQUIA", "LA CEJA - ANTIOQUIA", "LA ESTRELLA - ANTIOQUIA", "LA PINTADA - ANTIOQUIA", "LA UNION - ANTIOQUIA", "LIBORINA - ANTIOQUIA", "MACEO - ANTIOQUIA", "MARINILLA - ANTIOQUIA", "MONTEBELLO - ANTIOQUIA", "MURINDO - ANTIOQUIA", "MUTATA - ANTIOQUIA", "NARIÑO - ANTIOQUIA", "NECOCLI - ANTIOQUIA", "NECHI - ANTIOQUIA", "OLAYA - ANTIOQUIA", "PEÐOL - ANTIOQUIA", "PEQUE - ANTIOQUIA", "PUEBLORRICO - ANTIOQUIA", "PUERTO BERRIO - ANTIOQUIA", "PUERTO NARE - ANTIOQUIA", "PUERTO TRIUNFO - ANTIOQUIA", "REMEDIOS - ANTIOQUIA", "RETIRO - ANTIOQUIA", "RIONEGRO - ANTIOQUIA", "SABANALARGA - ANTIOQUIA", "SABANETA - ANTIOQUIA", "SALGAR - ANTIOQUIA", "SAN ANDRES DE CUERQUIA - ANTIOQUIA", "SAN CARLOS - ANTIOQUIA", "SAN FRANCISCO - ANTIOQUIA", "SAN JERONIMO - ANTIOQUIA", "SAN JOSE DE LA MONTAÑA - ANTIOQUIA", "SAN JUAN DE URABA - ANTIOQUIA", "SAN LUIS - ANTIOQUIA", "SAN PEDRO - ANTIOQUIA", "SAN PEDRO DE URABA - ANTIOQUIA", "SAN RAFAEL - ANTIOQUIA", "SAN ROQUE - ANTIOQUIA", "SAN VICENTE - ANTIOQUIA", "SANTA BARBARA - ANTIOQUIA", "SANTA ROSA DE OSOS - ANTIOQUIA", "SANTO DOMINGO - ANTIOQUIA", "EL SANTUARIO - ANTIOQUIA", "SEGOVIA - ANTIOQUIA", "SONSON - ANTIOQUIA", "SOPETRAN - ANTIOQUIA", "TAMESIS - ANTIOQUIA", "TARAZA - ANTIOQUIA", "TARSO - ANTIOQUIA", "TITIRIBI - ANTIOQUIA", "TOLEDO - ANTIOQUIA", "TURBO - ANTIOQUIA", "URAMITA - ANTIOQUIA", "URRAO - ANTIOQUIA", "VALDIVIA - ANTIOQUIA", "VALPARAISO - ANTIOQUIA", "VEGACHI - ANTIOQUIA", "VENECIA - ANTIOQUIA", "VIGIA DEL FUERTE - ANTIOQUIA", "YALI - ANTIOQUIA", "YARUMAL - ANTIOQUIA", "YOLOMBO - ANTIOQUIA", "YONDO - ANTIOQUIA", "ZARAGOZA - ANTIOQUIA", "BARRANQUILLA - ATLANTICO", "BARANOA - ATLANTICO", "CAMPO DE LA CRUZ - ATLANTICO", "CANDELARIA - ATLANTICO", "GALAPA - ATLANTICO", "JUAN DE ACOSTA - ATLANTICO", "LURUACO - ATLANTICO", "MALAMBO - ATLANTICO", "MANATI - ATLANTICO", "PALMAR DE VARELA - ATLANTICO", "PIOJO - ATLANTICO", "POLONUEVO - ATLANTICO", "PONEDERA - ATLANTICO", "PUERTO COLOMBIA - ATLANTICO", "REPELON - ATLANTICO", "SABANAGRANDE - ATLANTICO", "SABANALARGA - ATLANTICO", "SANTA LUCIA - ATLANTICO", "SANTO TOMAS - ATLANTICO", "SOLEDAD - ATLANTICO", "SUAN - ATLANTICO", "TUBARA - ATLANTICO", "USIACURI - ATLANTICO", "BOGOTA, D.C. - BOGOTA", "CARTAGENA - BOLIVAR", "ACHI - BOLIVAR", "ALTOS DEL ROSARIO - BOLIVAR", "ARENAL - BOLIVAR", "ARJONA - BOLIVAR", "ARROYOHONDO - BOLIVAR", "BARRANCO DE LOBA - BOLIVAR", "CALAMAR - BOLIVAR", "CANTAGALLO - BOLIVAR", "CICUCO - BOLIVAR", "CORDOBA - BOLIVAR", "CLEMENCIA - BOLIVAR", "EL CARMEN DE BOLIVAR - BOLIVAR", "EL GUAMO - BOLIVAR", "EL PEÑON - BOLIVAR", "HATILLO DE LOBA - BOLIVAR", "MAGANGUE - BOLIVAR", "MAHATES - BOLIVAR", "MARGARITA - BOLIVAR", "MARIA LA BAJA - BOLIVAR", "MONTECRISTO - BOLIVAR", "MOMPOS - BOLIVAR", "NOROSI - BOLIVAR", "MORALES - BOLIVAR", "PINILLOS - BOLIVAR", "REGIDOR - BOLIVAR", "RIO VIEJO - BOLIVAR", "SAN CRISTOBAL - BOLIVAR", "SAN ESTANISLAO - BOLIVAR", "SAN FERNANDO - BOLIVAR", "SAN JACINTO - BOLIVAR", "SAN JACINTO DEL CAUCA - BOLIVAR", "SAN JUAN NEPOMUCENO - BOLIVAR", "SAN MARTIN DE LOBA - BOLIVAR", "SAN PABLO - BOLIVAR", "SANTA CATALINA - BOLIVAR", "SANTA ROSA - BOLIVAR", "SANTA ROSA DEL SUR - BOLIVAR", "SIMITI - BOLIVAR", "SOPLAVIENTO - BOLIVAR", "TALAIGUA NUEVO - BOLIVAR", "TIQUISIO - BOLIVAR", "TURBACO - BOLIVAR", "TURBANA - BOLIVAR", "VILLANUEVA - BOLIVAR", "ZAMBRANO - BOLIVAR", "TUNJA - BOYACA", "ALMEIDA - BOYACA", "AQUITANIA - BOYACA", "ARCABUCO - BOYACA", "BELEN - BOYACA", "BERBEO - BOYACA", "BETEITIVA - BOYACA", "BOAVITA - BOYACA", "BOYACA - BOYACA", "BRICEÑO - BOYACA", "BUENAVISTA - BOYACA", "BUSBANZA - BOYACA", "CALDAS - BOYACA", "CAMPOHERMOSO - BOYACA", "CERINZA - BOYACA", "CHINAVITA - BOYACA", "CHIQUINQUIRA - BOYACA", "CHISCAS - BOYACA", "CHITA - BOYACA", "CHITARAQUE - BOYACA", "CHIVATA - BOYACA", "CIENEGA - BOYACA", "COMBITA - BOYACA", "COPER - BOYACA", "CORRALES - BOYACA", "COVARACHIA - BOYACA", "CUBARA - BOYACA", "CUCAITA - BOYACA", "CUITIVA - BOYACA", "CHIQUIZA - BOYACA", "CHIVOR - BOYACA", "DUITAMA - BOYACA", "EL COCUY - BOYACA", "EL ESPINO - BOYACA", "FIRAVITOBA - BOYACA", "FLORESTA - BOYACA", "GACHANTIVA - BOYACA", "GAMEZA - BOYACA", "GARAGOA - BOYACA", "GUACAMAYAS - BOYACA", "GUATEQUE - BOYACA", "GUAYATA - BOYACA", "GsICAN - BOYACA", "IZA - BOYACA", "JENESANO - BOYACA", "JERICO - BOYACA", "LABRANZAGRANDE - BOYACA", "LA CAPILLA - BOYACA", "LA VICTORIA - BOYACA", "LA UVITA - BOYACA", "VILLA DE LEYVA - BOYACA", "MACANAL - BOYACA", "MARIPI - BOYACA", "MIRAFLORES - BOYACA", "MONGUA - BOYACA", "MONGUI - BOYACA", "MONIQUIRA - BOYACA", "MOTAVITA - BOYACA", "MUZO - BOYACA", "NOBSA - BOYACA", "NUEVO COLON - BOYACA", "OICATA - BOYACA", "OTANCHE - BOYACA", "PACHAVITA - BOYACA", "PAEZ - BOYACA", "PAIPA - BOYACA", "PAJARITO - BOYACA", "PANQUEBA - BOYACA", "PAUNA - BOYACA", "PAYA - BOYACA", "PAZ DE RIO - BOYACA", "PESCA - BOYACA", "PISBA - BOYACA", "PUERTO BOYACA - BOYACA", "QUIPAMA - BOYACA", "RAMIRIQUI - BOYACA", "RAQUIRA - BOYACA", "RONDON - BOYACA", "SABOYA - BOYACA", "SACHICA - BOYACA", "SAMACA - BOYACA", "SAN EDUARDO - BOYACA", "SAN JOSE DE PARE - BOYACA", "SAN LUIS DE GACENO - BOYACA", "SAN MATEO - BOYACA", "SAN MIGUEL DE SEMA - BOYACA", "SAN PABLO DE BORBUR - BOYACA", "SANTANA - BOYACA", "SANTA MARIA - BOYACA", "SANTA ROSA DE VITERBO - BOYACA", "SANTA SOFIA - BOYACA", "SATIVANORTE - BOYACA", "SATIVASUR - BOYACA", "SIACHOQUE - BOYACA", "SOATA - BOYACA", "SOCOTA - BOYACA", "SOCHA - BOYACA", "SOGAMOSO - BOYACA", "SOMONDOCO - BOYACA", "SORA - BOYACA", "SOTAQUIRA - BOYACA", "SORACA - BOYACA", "SUSACON - BOYACA", "SUTAMARCHAN - BOYACA", "SUTATENZA - BOYACA", "TASCO - BOYACA", "TENZA - BOYACA", "TIBANA - BOYACA", "TIBASOSA - BOYACA", "TINJACA - BOYACA", "TIPACOQUE - BOYACA", "TOCA - BOYACA", "TOGsI - BOYACA", "TOPAGA - BOYACA", "TOTA - BOYACA", "TUNUNGUA - BOYACA", "TURMEQUE - BOYACA", "TUTA - BOYACA", "TUTAZA - BOYACA", "UMBITA - BOYACA", "VENTAQUEMADA - BOYACA", "VIRACACHA - BOYACA", "ZETAQUIRA - BOYACA", "MANIZALES - CALDAS", "AGUADAS - CALDAS", "ANSERMA - CALDAS", "ARANZAZU - CALDAS", "BELALCAZAR - CALDAS", "CHINCHINA - CALDAS", "FILADELFIA - CALDAS", "LA DORADA - CALDAS", "LA MERCED - CALDAS", "MANZANARES - CALDAS", "MARMATO - CALDAS", "MARQUETALIA - CALDAS", "MARULANDA - CALDAS", "NEIRA - CALDAS", "NORCASIA - CALDAS", "PACORA - CALDAS", "PALESTINA - CALDAS", "PENSILVANIA - CALDAS", "RIOSUCIO - CALDAS", "RISARALDA - CALDAS", "SALAMINA - CALDAS", "SAMANA - CALDAS", "SAN JOSE - CALDAS", "SUPIA - CALDAS", "VICTORIA - CALDAS", "VILLAMARIA - CALDAS", "VITERBO - CALDAS", "FLORENCIA - CAQUETA", "ALBANIA - CAQUETA", "BELEN DE LOS ANDAQUIES - CAQUETA", "CARTAGENA DEL CHAIRA - CAQUETA", "CURILLO - CAQUETA", "EL DONCELLO - CAQUETA", "EL PAUJIL - CAQUETA", "LA MONTAÑITA - CAQUETA", "MILAN - CAQUETA", "MORELIA - CAQUETA", "PUERTO RICO - CAQUETA", "SAN JOSE DEL FRAGUA - CAQUETA", "SAN VICENTE DEL CAGUAN - CAQUETA", "SOLANO - CAQUETA", "SOLITA - CAQUETA", "VALPARAISO - CAQUETA", "POPAYAN - CAUCA", "ALMAGUER - CAUCA", "ARGELIA - CAUCA", "BALBOA - CAUCA", "BOLIVAR - CAUCA", "BUENOS AIRES - CAUCA", "CAJIBIO - CAUCA", "CALDONO - CAUCA", "CALOTO - CAUCA", "CORINTO - CAUCA", "EL TAMBO - CAUCA", "FLORENCIA - CAUCA", "GUACHENE - CAUCA", "GUAPI - CAUCA", "INZA - CAUCA", "JAMBALO - CAUCA", "LA SIERRA - CAUCA", "LA VEGA - CAUCA", "LOPEZ - CAUCA", "MERCADERES - CAUCA", "MIRANDA - CAUCA", "MORALES - CAUCA", "PADILLA - CAUCA", "PAEZ - CAUCA", "PATIA - CAUCA", "PIAMONTE - CAUCA", "PIENDAMO - CAUCA", "PUERTO TEJADA - CAUCA", "PURACE - CAUCA", "ROSAS - CAUCA", "SAN SEBASTIAN - CAUCA", "SANTANDER DE QUILICHAO - CAUCA", "SANTA ROSA - CAUCA", "SILVIA - CAUCA", "SOTARA - CAUCA", "SUAREZ - CAUCA", "SUCRE - CAUCA", "TIMBIO - CAUCA", "TIMBIQUI - CAUCA", "TORIBIO - CAUCA", "TOTORO - CAUCA", "VILLA RICA - CAUCA", "VALLEDUPAR - CESAR", "AGUACHICA - CESAR", "AGUSTIN CODAZZI - CESAR", "ASTREA - CESAR", "BECERRIL - CESAR", "BOSCONIA - CESAR", "CHIMICHAGUA - CESAR", "CHIRIGUANA - CESAR", "CURUMANI - CESAR", "EL COPEY - CESAR", "EL PASO - CESAR", "GAMARRA - CESAR", "GONZALEZ - CESAR", "LA GLORIA - CESAR", "LA JAGUA DE IBIRICO - CESAR", "MANAURE - CESAR", "PAILITAS - CESAR", "PELAYA - CESAR", "PUEBLO BELLO - CESAR", "RIO DE ORO - CESAR", "LA PAZ - CESAR", "SAN ALBERTO - CESAR", "SAN DIEGO - CESAR", "SAN MARTIN - CESAR", "TAMALAMEQUE - CESAR", "MONTERIA - CORDOBA", "AYAPEL - CORDOBA", "BUENAVISTA - CORDOBA", "CANALETE - CORDOBA", "CERETE - CORDOBA", "CHIMA - CORDOBA", "CHINU - CORDOBA", "CIENAGA DE ORO - CORDOBA", "COTORRA - CORDOBA", "LA APARTADA - CORDOBA", "LORICA - CORDOBA", "LOS CORDOBAS - CORDOBA", "MOMIL - CORDOBA", "MONTELIBANO - CORDOBA", "MOÑITOS - CORDOBA", "PLANETA RICA - CORDOBA", "PUEBLO NUEVO - CORDOBA", "PUERTO ESCONDIDO - CORDOBA", "PUERTO LIBERTADOR - CORDOBA", "PURISIMA - CORDOBA", "SAHAGUN - CORDOBA", "SAN ANDRES SOTAVENTO - CORDOBA", "SAN ANTERO - CORDOBA", "SAN BERNARDO DEL VIENTO - CORDOBA", "SAN CARLOS - CORDOBA", "SAN PELAYO - CORDOBA", "TIERRALTA - CORDOBA", "VALENCIA - CORDOBA", "AGUA DE DIOS - CUNDINAMARCA", "ALBAN - CUNDINAMARCA", "ANAPOIMA - CUNDINAMARCA", "ANOLAIMA - CUNDINAMARCA", "ARBELAEZ - CUNDINAMARCA", "BELTRAN - CUNDINAMARCA", "BITUIMA - CUNDINAMARCA", "BOJACA - CUNDINAMARCA", "CABRERA - CUNDINAMARCA", "CACHIPAY - CUNDINAMARCA", "CAJICA - CUNDINAMARCA", "CAPARRAPI - CUNDINAMARCA", "CAQUEZA - CUNDINAMARCA", "CARMEN DE CARUPA - CUNDINAMARCA", "CHAGUANI - CUNDINAMARCA", "CHIA - CUNDINAMARCA", "CHIPAQUE - CUNDINAMARCA", "CHOACHI - CUNDINAMARCA", "CHOCONTA - CUNDINAMARCA", "COGUA - CUNDINAMARCA", "COTA - CUNDINAMARCA", "CUCUNUBA - CUNDINAMARCA", "EL COLEGIO - CUNDINAMARCA", "EL PEÑON - CUNDINAMARCA", "EL ROSAL - CUNDINAMARCA", "FACATATIVA - CUNDINAMARCA", "FOMEQUE - CUNDINAMARCA", "FOSCA - CUNDINAMARCA", "FUNZA - CUNDINAMARCA", "FUQUENE - CUNDINAMARCA", "FUSAGASUGA - CUNDINAMARCA", "GACHALA - CUNDINAMARCA", "GACHANCIPA - CUNDINAMARCA", "GACHETA - CUNDINAMARCA", "GAMA - CUNDINAMARCA", "GIRARDOT - CUNDINAMARCA", "GRANADA - CUNDINAMARCA", "GUACHETA - CUNDINAMARCA", "GUADUAS - CUNDINAMARCA", "GUASCA - CUNDINAMARCA", "GUATAQUI - CUNDINAMARCA", "GUATAVITA - CUNDINAMARCA", "GUAYABAL DE SIQUIMA - CUNDINAMARCA", "GUAYABETAL - CUNDINAMARCA", "GUTIERREZ - CUNDINAMARCA", "JERUSALEN - CUNDINAMARCA", "JUNIN - CUNDINAMARCA", "LA CALERA - CUNDINAMARCA", "LA MESA - CUNDINAMARCA", "LA PALMA - CUNDINAMARCA", "LA PEÑA - CUNDINAMARCA", "LA VEGA - CUNDINAMARCA", "LENGUAZAQUE - CUNDINAMARCA", "MACHETA - CUNDINAMARCA", "MADRID - CUNDINAMARCA", "MANTA - CUNDINAMARCA", "MEDINA - CUNDINAMARCA", "MOSQUERA - CUNDINAMARCA", "NARIÑO - CUNDINAMARCA", "NEMOCON - CUNDINAMARCA", "NILO - CUNDINAMARCA", "NIMAIMA - CUNDINAMARCA", "NOCAIMA - CUNDINAMARCA", "VENECIA - CUNDINAMARCA", "PACHO - CUNDINAMARCA", "PAIME - CUNDINAMARCA", "PANDI - CUNDINAMARCA", "PARATEBUENO - CUNDINAMARCA", "PASCA - CUNDINAMARCA", "PUERTO SALGAR - CUNDINAMARCA", "PULI - CUNDINAMARCA", "QUEBRADANEGRA - CUNDINAMARCA", "QUETAME - CUNDINAMARCA", "QUIPILE - CUNDINAMARCA", "APULO - CUNDINAMARCA", "RICAURTE - CUNDINAMARCA", "SAN ANTONIO DEL TEQUENDAMA - CUNDINAMARCA", "SAN BERNARDO - CUNDINAMARCA", "SAN CAYETANO - CUNDINAMARCA", "SAN FRANCISCO - CUNDINAMARCA", "SAN JUAN DE RIO SECO - CUNDINAMARCA", "SASAIMA - CUNDINAMARCA", "SESQUILE - CUNDINAMARCA", "SIBATE - CUNDINAMARCA", "SILVANIA - CUNDINAMARCA", "SIMIJACA - CUNDINAMARCA", "SOACHA - CUNDINAMARCA", "SOPO - CUNDINAMARCA", "SUBACHOQUE - CUNDINAMARCA", "SUESCA - CUNDINAMARCA", "SUPATA - CUNDINAMARCA", "SUSA - CUNDINAMARCA", "SUTATAUSA - CUNDINAMARCA", "TABIO - CUNDINAMARCA", "TAUSA - CUNDINAMARCA", "TENA - CUNDINAMARCA", "TENJO - CUNDINAMARCA", "TIBACUY - CUNDINAMARCA", "TIBIRITA - CUNDINAMARCA", "TOCAIMA - CUNDINAMARCA", "TOCANCIPA - CUNDINAMARCA", "TOPAIPI - CUNDINAMARCA", "UBALA - CUNDINAMARCA", "UBAQUE - CUNDINAMARCA", "VILLA DE SAN DIEGO DE UBATE - CUNDINAMARCA", "UNE - CUNDINAMARCA", "UTICA - CUNDINAMARCA", "VERGARA - CUNDINAMARCA", "VIANI - CUNDINAMARCA", "VILLAGOMEZ - CUNDINAMARCA", "VILLAPINZON - CUNDINAMARCA", "VILLETA - CUNDINAMARCA", "VIOTA - CUNDINAMARCA", "YACOPI - CUNDINAMARCA", "ZIPACON - CUNDINAMARCA", "ZIPAQUIRA - CUNDINAMARCA", "QUIBDO - CHOCO", "ACANDI - CHOCO", "ALTO BAUDO - CHOCO", "ATRATO - CHOCO", "BAGADO - CHOCO", "BAHIA SOLANO - CHOCO", "BAJO BAUDO - CHOCO", "BOJAYA - CHOCO", "EL CANTON DEL SAN PABLO - CHOCO", "CARMEN DEL DARIEN - CHOCO", "CERTEGUI - CHOCO", "CONDOTO - CHOCO", "EL CARMEN DE ATRATO - CHOCO", "EL LITORAL DEL SAN JUAN - CHOCO", "ISTMINA - CHOCO", "JURADO - CHOCO", "LLORO - CHOCO", "MEDIO ATRATO - CHOCO", "MEDIO BAUDO - CHOCO", "MEDIO SAN JUAN - CHOCO", "NOVITA - CHOCO", "NUQUI - CHOCO", "RIO IRO - CHOCO", "RIO QUITO - CHOCO", "RIOSUCIO - CHOCO", "SAN JOSE DEL PALMAR - CHOCO", "SIPI - CHOCO", "TADO - CHOCO", "UNGUIA - CHOCO", "UNION PANAMERICANA - CHOCO", "NEIVA - HUILA", "ACEVEDO - HUILA", "AGRADO - HUILA", "AIPE - HUILA", "ALGECIRAS - HUILA", "ALTAMIRA - HUILA", "BARAYA - HUILA", "CAMPOALEGRE - HUILA", "COLOMBIA - HUILA", "ELIAS - HUILA", "GARZON - HUILA", "GIGANTE - HUILA", "GUADALUPE - HUILA", "HOBO - HUILA", "IQUIRA - HUILA", "ISNOS - HUILA", "LA ARGENTINA - HUILA", "LA PLATA - HUILA", "NATAGA - HUILA", "OPORAPA - HUILA", "PAICOL - HUILA", "PALERMO - HUILA", "PALESTINA - HUILA", "PITAL - HUILA", "PITALITO - HUILA", "RIVERA - HUILA", "SALADOBLANCO - HUILA", "SAN AGUSTIN - HUILA", "SANTA MARIA - HUILA", "SUAZA - HUILA", "TARQUI - HUILA", "TESALIA - HUILA", "TELLO - HUILA", "TERUEL - HUILA", "TIMANA - HUILA", "VILLAVIEJA - HUILA", "YAGUARA - HUILA", "RIOHACHA - LA GUAJIRA", "ALBANIA - LA GUAJIRA", "BARRANCAS - LA GUAJIRA", "DIBULLA - LA GUAJIRA", "DISTRACCION - LA GUAJIRA", "EL MOLINO - LA GUAJIRA", "FONSECA - LA GUAJIRA", "HATONUEVO - LA GUAJIRA", "LA JAGUA DEL PILAR - LA GUAJIRA", "MAICAO - LA GUAJIRA", "MANAURE - LA GUAJIRA", "SAN JUAN DEL CESAR - LA GUAJIRA", "URIBIA - LA GUAJIRA", "URUMITA - LA GUAJIRA", "VILLANUEVA - LA GUAJIRA", "SANTA MARTA - MAGDALENA", "ALGARROBO - MAGDALENA", "ARACATACA - MAGDALENA", "ARIGUANI - MAGDALENA", "CERRO SAN ANTONIO - MAGDALENA", "CHIBOLO - MAGDALENA", "CIENAGA - MAGDALENA", "CONCORDIA - MAGDALENA", "EL BANCO - MAGDALENA", "EL PIÑON - MAGDALENA", "EL RETEN - MAGDALENA", "FUNDACION - MAGDALENA", "GUAMAL - MAGDALENA", "NUEVA GRANADA - MAGDALENA", "PEDRAZA - MAGDALENA", "PIJIÑO DEL CARMEN - MAGDALENA", "PIVIJAY - MAGDALENA", "PLATO - MAGDALENA", "PUEBLOVIEJO - MAGDALENA", "REMOLINO - MAGDALENA", "SABANAS DE SAN ANGEL - MAGDALENA", "SALAMINA - MAGDALENA", "SAN SEBASTIAN DE BUENAVISTA - MAGDALENA", "SAN ZENON - MAGDALENA", "SANTA ANA - MAGDALENA", "SANTA BARBARA DE PINTO - MAGDALENA", "SITIONUEVO - MAGDALENA", "TENERIFE - MAGDALENA", "ZAPAYAN - MAGDALENA", "ZONA BANANERA - MAGDALENA", "VILLAVICENCIO - META", "ACACIAS - META", "BARRANCA DE UPIA - META", "CABUYARO - META", "CASTILLA LA NUEVA - META", "CUBARRAL - META", "CUMARAL - META", "EL CALVARIO - META", "EL CASTILLO - META", "EL DORADO - META", "FUENTE DE ORO - META", "GRANADA - META", "GUAMAL - META", "MAPIRIPAN - META", "MESETAS - META", "LA MACARENA - META", "URIBE - META", "LEJANIAS - META", "PUERTO CONCORDIA - META", "PUERTO GAITAN - META", "PUERTO LOPEZ - META", "PUERTO LLERAS - META", "PUERTO RICO - META", "RESTREPO - META", "SAN CARLOS DE GUAROA - META", "SAN JUAN DE ARAMA - META", "SAN JUANITO - META", "SAN MARTIN - META", "VISTAHERMOSA - META", "PASTO - NARIÑO", "ALBAN - NARIÑO", "ALDANA - NARIÑO", "ANCUYA - NARIÑO", "ARBOLEDA - NARIÑO", "BARBACOAS - NARIÑO", "BELEN - NARIÑO", "BUESACO - NARIÑO", "COLON - NARIÑO", "CONSACA - NARIÑO", "CONTADERO - NARIÑO", "CORDOBA - NARIÑO", "CUASPUD - NARIÑO", "CUMBAL - NARIÑO", "CUMBITARA - NARIÑO", "CHACHAGsI - NARIÑO", "EL CHARCO - NARIÑO", "EL PEÑOL - NARIÑO", "EL ROSARIO - NARIÑO", "EL TABLON DE GOMEZ - NARIÑO", "EL TAMBO - NARIÑO", "FUNES - NARIÑO", "GUACHUCAL - NARIÑO", "GUAITARILLA - NARIÑO", "GUALMATAN - NARIÑO", "ILES - NARIÑO", "IMUES - NARIÑO", "IPIALES - NARIÑO", "LA CRUZ - NARIÑO", "LA FLORIDA - NARIÑO", "LA LLANADA - NARIÑO", "LA TOLA - NARIÑO", "LA UNION - NARIÑO", "LEIVA - NARIÑO", "LINARES - NARIÑO", "LOS ANDES - NARIÑO", "MAGsI - NARIÑO", "MALLAMA - NARIÑO", "MOSQUERA - NARIÑO", "NARIÑO - NARIÑO", "OLAYA HERRERA - NARIÑO", "OSPINA - NARIÑO", "FRANCISCO PIZARRO - NARIÑO", "POLICARPA - NARIÑO", "POTOSI - NARIÑO", "PROVIDENCIA - NARIÑO", "PUERRES - NARIÑO", "PUPIALES - NARIÑO", "RICAURTE - NARIÑO", "ROBERTO PAYAN - NARIÑO", "SAMANIEGO - NARIÑO", "SANDONA - NARIÑO", "SAN BERNARDO - NARIÑO", "SAN LORENZO - NARIÑO", "SAN PABLO - NARIÑO", "SAN PEDRO DE CARTAGO - NARIÑO", "SANTA BARBARA - NARIÑO", "SANTACRUZ - NARIÑO", "SAPUYES - NARIÑO", "TAMINANGO - NARIÑO", "TANGUA - NARIÑO", "SAN ANDRES DE TUMACO - NARIÑO", "TUQUERRES - NARIÑO", "YACUANQUER - NARIÑO", "CUCUTA - N. DE SANTANDER", "ABREGO - N. DE SANTANDER", "ARBOLEDAS - N. DE SANTANDER", "BOCHALEMA - N. DE SANTANDER", "BUCARASICA - N. DE SANTANDER", "CACOTA - N. DE SANTANDER", "CACHIRA - N. DE SANTANDER", "CHINACOTA - N. DE SANTANDER", "CHITAGA - N. DE SANTANDER", "CONVENCION - N. DE SANTANDER", "CUCUTILLA - N. DE SANTANDER", "DURANIA - N. DE SANTANDER", "EL CARMEN - N. DE SANTANDER", "EL TARRA - N. DE SANTANDER", "EL ZULIA - N. DE SANTANDER", "GRAMALOTE - N. DE SANTANDER", "HACARI - N. DE SANTANDER", "HERRAN - N. DE SANTANDER", "LABATECA - N. DE SANTANDER", "LA ESPERANZA - N. DE SANTANDER", "LA PLAYA - N. DE SANTANDER", "LOS PATIOS - N. DE SANTANDER", "LOURDES - N. DE SANTANDER", "MUTISCUA - N. DE SANTANDER", "OCAÑA - N. DE SANTANDER", "PAMPLONA - N. DE SANTANDER", "PAMPLONITA - N. DE SANTANDER", "PUERTO SANTANDER - N. DE SANTANDER", "RAGONVALIA - N. DE SANTANDER", "SALAZAR - N. DE SANTANDER", "SAN CALIXTO - N. DE SANTANDER", "SAN CAYETANO - N. DE SANTANDER", "SANTIAGO - N. DE SANTANDER", "SARDINATA - N. DE SANTANDER", "SILOS - N. DE SANTANDER", "TEORAMA - N. DE SANTANDER", "TIBU - N. DE SANTANDER", "TOLEDO - N. DE SANTANDER", "VILLA CARO - N. DE SANTANDER", "VILLA DEL ROSARIO - N. DE SANTANDER", "ARMENIA - QUINDIO", "BUENAVISTA - QUINDIO", "CALARCA - QUINDIO", "CIRCASIA - QUINDIO", "CORDOBA - QUINDIO", "FILANDIA - QUINDIO", "GENOVA - QUINDIO", "LA TEBAIDA - QUINDIO", "MONTENEGRO - QUINDIO", "PIJAO - QUINDIO", "QUIMBAYA - QUINDIO", "SALENTO - QUINDIO", "PEREIRA - RISARALDA", "APIA - RISARALDA", "BALBOA - RISARALDA", "BELEN DE UMBRIA - RISARALDA", "DOSQUEBRADAS - RISARALDA", "GUATICA - RISARALDA", "LA CELIA - RISARALDA", "LA VIRGINIA - RISARALDA", "MARSELLA - RISARALDA", "MISTRATO - RISARALDA", "PUEBLO RICO - RISARALDA", "QUINCHIA - RISARALDA", "SANTA ROSA DE CABAL - RISARALDA", "SANTUARIO - RISARALDA", "BUCARAMANGA - SANTANDER", "AGUADA - SANTANDER", "ALBANIA - SANTANDER", "ARATOCA - SANTANDER", "BARBOSA - SANTANDER", "BARICHARA - SANTANDER", "BARRANCABERMEJA - SANTANDER", "BETULIA - SANTANDER", "BOLIVAR - SANTANDER", "CABRERA - SANTANDER", "CALIFORNIA - SANTANDER", "CAPITANEJO - SANTANDER", "CARCASI - SANTANDER", "CEPITA - SANTANDER", "CERRITO - SANTANDER", "CHARALA - SANTANDER", "CHARTA - SANTANDER", "CHIMA - SANTANDER", "CHIPATA - SANTANDER", "CIMITARRA - SANTANDER", "CONCEPCION - SANTANDER", "CONFINES - SANTANDER", "CONTRATACION - SANTANDER", "COROMORO - SANTANDER", "CURITI - SANTANDER", "EL CARMEN DE CHUCURI - SANTANDER", "EL GUACAMAYO - SANTANDER", "EL PEÑON - SANTANDER", "EL PLAYON - SANTANDER", "ENCINO - SANTANDER", "ENCISO - SANTANDER", "FLORIAN - SANTANDER", "FLORIDABLANCA - SANTANDER", "GALAN - SANTANDER", "GAMBITA - SANTANDER", "GIRON - SANTANDER", "GUACA - SANTANDER", "GUADALUPE - SANTANDER", "GUAPOTA - SANTANDER", "GUAVATA - SANTANDER", "GsEPSA - SANTANDER", "HATO - SANTANDER", "JESUS MARIA - SANTANDER", "JORDAN - SANTANDER", "LA BELLEZA - SANTANDER", "LANDAZURI - SANTANDER", "LA PAZ - SANTANDER", "LEBRIJA - SANTANDER", "LOS SANTOS - SANTANDER", "MACARAVITA - SANTANDER", "MALAGA - SANTANDER", "MATANZA - SANTANDER", "MOGOTES - SANTANDER", "MOLAGAVITA - SANTANDER", "OCAMONTE - SANTANDER", "OIBA - SANTANDER", "ONZAGA - SANTANDER", "PALMAR - SANTANDER", "PALMAS DEL SOCORRO - SANTANDER", "PARAMO - SANTANDER", "PIEDECUESTA - SANTANDER", "PINCHOTE - SANTANDER", "PUENTE NACIONAL - SANTANDER", "PUERTO PARRA - SANTANDER", "PUERTO WILCHES - SANTANDER", "RIONEGRO - SANTANDER", "SABANA DE TORRES - SANTANDER", "SAN ANDRES - SANTANDER", "SAN BENITO - SANTANDER", "SAN GIL - SANTANDER", "SAN JOAQUIN - SANTANDER", "SAN JOSE DE MIRANDA - SANTANDER", "SAN MIGUEL - SANTANDER", "SAN VICENTE DE CHUCURI - SANTANDER", "SANTA BARBARA - SANTANDER", "SANTA HELENA DEL OPON - SANTANDER", "SIMACOTA - SANTANDER", "SOCORRO - SANTANDER", "SUAITA - SANTANDER", "SUCRE - SANTANDER", "SURATA - SANTANDER", "TONA - SANTANDER", "VALLE DE SAN JOSE - SANTANDER", "VELEZ - SANTANDER", "VETAS - SANTANDER", "VILLANUEVA - SANTANDER", "ZAPATOCA - SANTANDER", "SINCELEJO - SUCRE", "BUENAVISTA - SUCRE", "CAIMITO - SUCRE", "COLOSO - SUCRE", "COROZAL - SUCRE", "COVEÑAS - SUCRE", "CHALAN - SUCRE", "EL ROBLE - SUCRE", "GALERAS - SUCRE", "GUARANDA - SUCRE", "LA UNION - SUCRE", "LOS PALMITOS - SUCRE", "MAJAGUAL - SUCRE", "MORROA - SUCRE", "OVEJAS - SUCRE", "PALMITO - SUCRE", "SAMPUES - SUCRE", "SAN BENITO ABAD - SUCRE", "SAN JUAN DE BETULIA - SUCRE", "SAN MARCOS - SUCRE", "SAN ONOFRE - SUCRE", "SAN PEDRO - SUCRE", "SAN LUIS DE SINCE - SUCRE", "SUCRE - SUCRE", "SANTIAGO DE TOLU - SUCRE", "TOLU VIEJO - SUCRE", "IBAGUE - TOLIMA", "ALPUJARRA - TOLIMA", "ALVARADO - TOLIMA", "AMBALEMA - TOLIMA", "ANZOATEGUI - TOLIMA", "ARMERO - TOLIMA", "ATACO - TOLIMA", "CAJAMARCA - TOLIMA", "CARMEN DE APICALA - TOLIMA", "CASABIANCA - TOLIMA", "CHAPARRAL - TOLIMA", "COELLO - TOLIMA", "COYAIMA - TOLIMA", "CUNDAY - TOLIMA", "DOLORES - TOLIMA", "ESPINAL - TOLIMA", "FALAN - TOLIMA", "FLANDES - TOLIMA", "FRESNO - TOLIMA", "GUAMO - TOLIMA", "HERVEO - TOLIMA", "HONDA - TOLIMA", "ICONONZO - TOLIMA", "LERIDA - TOLIMA", "LIBANO - TOLIMA", "MARIQUITA - TOLIMA", "MELGAR - TOLIMA", "MURILLO - TOLIMA", "NATAGAIMA - TOLIMA", "ORTEGA - TOLIMA", "PALOCABILDO - TOLIMA", "PIEDRAS - TOLIMA", "PLANADAS - TOLIMA", "PRADO - TOLIMA", "PURIFICACION - TOLIMA", "RIOBLANCO - TOLIMA", "RONCESVALLES - TOLIMA", "ROVIRA - TOLIMA", "SALDAÑA - TOLIMA", "SAN ANTONIO - TOLIMA", "SAN LUIS - TOLIMA", "SANTA ISABEL - TOLIMA", "SUAREZ - TOLIMA", "VALLE DE SAN JUAN - TOLIMA", "VENADILLO - TOLIMA", "VILLAHERMOSA - TOLIMA", "VILLARRICA - TOLIMA", "CALI - VALLE DEL CAUCA", "ALCALA - VALLE DEL CAUCA", "ANDALUCIA - VALLE DEL CAUCA", "ANSERMANUEVO - VALLE DEL CAUCA", "ARGELIA - VALLE DEL CAUCA", "BOLIVAR - VALLE DEL CAUCA", "BUENAVENTURA - VALLE DEL CAUCA", "GUADALAJARA DE BUGA - VALLE DEL CAUCA", "BUGALAGRANDE - VALLE DEL CAUCA", "CAICEDONIA - VALLE DEL CAUCA", "CALIMA - VALLE DEL CAUCA", "CANDELARIA - VALLE DEL CAUCA", "CARTAGO - VALLE DEL CAUCA", "DAGUA - VALLE DEL CAUCA", "EL AGUILA - VALLE DEL CAUCA", "EL CAIRO - VALLE DEL CAUCA", "EL CERRITO - VALLE DEL CAUCA", "EL DOVIO - VALLE DEL CAUCA", "FLORIDA - VALLE DEL CAUCA", "GINEBRA - VALLE DEL CAUCA", "GUACARI - VALLE DEL CAUCA", "JAMUNDI - VALLE DEL CAUCA", "LA CUMBRE - VALLE DEL CAUCA", "LA UNION - VALLE DEL CAUCA", "LA VICTORIA - VALLE DEL CAUCA", "OBANDO - VALLE DEL CAUCA", "PALMIRA - VALLE DEL CAUCA", "PRADERA - VALLE DEL CAUCA", "RESTREPO - VALLE DEL CAUCA", "RIOFRIO - VALLE DEL CAUCA", "ROLDANILLO - VALLE DEL CAUCA", "SAN PEDRO - VALLE DEL CAUCA", "SEVILLA - VALLE DEL CAUCA", "TORO - VALLE DEL CAUCA", "TRUJILLO - VALLE DEL CAUCA", "TULUA - VALLE DEL CAUCA", "ULLOA - VALLE DEL CAUCA", "VERSALLES - VALLE DEL CAUCA", "VIJES - VALLE DEL CAUCA", "YOTOCO - VALLE DEL CAUCA", "YUMBO - VALLE DEL CAUCA", "ZARZAL - VALLE DEL CAUCA", "ARAUCA - ARAUCA", "ARAUQUITA - ARAUCA", "CRAVO NORTE - ARAUCA", "FORTUL - ARAUCA", "PUERTO RONDON - ARAUCA", "SARAVENA - ARAUCA", "TAME - ARAUCA", "YOPAL - CASANARE", "AGUAZUL - CASANARE", "CHAMEZA - CASANARE", "HATO COROZAL - CASANARE", "LA SALINA - CASANARE", "MANI - CASANARE", "MONTERREY - CASANARE", "NUNCHIA - CASANARE", "OROCUE - CASANARE", "PAZ DE ARIPORO - CASANARE", "PORE - CASANARE", "RECETOR - CASANARE", "SABANALARGA - CASANARE", "SACAMA - CASANARE", "SAN LUIS DE PALENQUE - CASANARE", "TAMARA - CASANARE", "TAURAMENA - CASANARE", "TRINIDAD - CASANARE", "VILLANUEVA - CASANARE", "MOCOA - PUTUMAYO", "COLON - PUTUMAYO", "ORITO - PUTUMAYO", "PUERTO ASIS - PUTUMAYO", "PUERTO CAICEDO - PUTUMAYO", "PUERTO GUZMAN - PUTUMAYO", "LEGUIZAMO - PUTUMAYO", "SIBUNDOY - PUTUMAYO", "SAN FRANCISCO - PUTUMAYO", "SAN MIGUEL - PUTUMAYO", "SANTIAGO - PUTUMAYO", "VALLE DEL GUAMUEZ - PUTUMAYO", "VILLAGARZON - PUTUMAYO", "SAN ANDRES - SAN ANDRES", "PROVIDENCIA - SAN ANDRES", "LETICIA - AMAZONAS", "EL ENCANTO - AMAZONAS", "LA CHORRERA - AMAZONAS", "LA PEDRERA - AMAZONAS", "LA VICTORIA - AMAZONAS", "MIRITI - PARANA - AMAZONAS", "PUERTO ALEGRIA - AMAZONAS", "PUERTO ARICA - AMAZONAS", "PUERTO NARIÑO - AMAZONAS", "PUERTO SANTANDER - AMAZONAS", "TARAPACA - AMAZONAS", "INIRIDA - GUAINIA", "BARRANCO MINAS - GUAINIA", "MAPIRIPANA - GUAINIA", "SAN FELIPE - GUAINIA", "PUERTO COLOMBIA - GUAINIA", "LA GUADALUPE - GUAINIA", "CACAHUAL - GUAINIA", "PANA PANA - GUAINIA", "MORICHAL - GUAINIA", "SAN JOSE DEL GUAVIARE - GUAVIARE", "CALAMAR - GUAVIARE", "EL RETORNO - GUAVIARE", "MIRAFLORES - GUAVIARE", "MITU - VAUPES", "CARURU - VAUPES", "PACOA - VAUPES", "TARAIRA - VAUPES", "PAPUNAUA - VAUPES", "YAVARATE - VAUPES", "PUERTO CARREÑO - VICHADA", "LA PRIMAVERA - VICHADA", "SANTA ROSALIA - VICHADA", "CUMARIBO - VICHADA"})
        Me.ComboBox_pais.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox_pais.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox_pais.BackColor = System.Drawing.Color.White
        Me.BunifuTransition1.SetDecoration(Me.ComboBox_pais, BunifuAnimatorNS.DecorationType.None)
        Me.ComboBox_pais.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_pais.ForeColor = System.Drawing.Color.Black
        Me.ComboBox_pais.FormattingEnabled = True
        Me.ComboBox_pais.ItemHeight = 16
        Me.ComboBox_pais.Items.AddRange(New Object() {"AFGANISTAN|013", "ALBANIA|017", "ALEMANIA|023", "ARMENIA|026", "ARUBA|027", "BOSNIA-HERZEGOVINA|029", "BURKINA FASSO|031", "ANDORRA|037", "ANGOLA|040", "ANGUILLA|041", "ANTIGUA Y BARBUDA|043", "ANTILLAS HOLANDESAS|047", "ARABIA SAUDITA|053", "ARGELIA|059", "ARGENTINA|063", "AUSTRALIA|069", "AUSTRIA|072", "AZERBAIJAN|074", "BAHAMAS|077", "BAHREIN|080", "BANGLADESH|081", "BARBADOS|083", "BELGICA|087", "BELICE|088", "BERMUDAS|090", "BELARUS|091", "BIRMANIA (MYANMAR)|093", "BOLIVIA|097", "BOTSWANA|101", "BRASIL|105", "BRUNEI DARUSSALAM|108", "BULGARIA|111", "BURUNDI|115", "BUTAN|119", "CABO VERDE|127", "CAIMAN, ISLAS|137", "CAMBOYA (KAMPUCHEA)|141", "CAMERUN, REPUBLICA UNIDA DEL|145", "CANADA|149", "SANTA SEDE|159", "COCOS (KEELING), ISLAS|165", "COLOMBIA|169", "COMORAS|173", "CONGO|177", "COOK, ISLAS|183", "COREA (NORTE), REPUBLICA POPULAR DEMOCRATICA DE|187", "COREA (SUR), REPUBLICA DE|190", "COSTA DE MARFIL|193", "COSTA RICA|196", "CROACIA|198", "CUBA|199", "CHAD|203", "CHILE|211", "CHINA|215", "TAIWAN (FORMOSA)|218", "CHIPRE|221", "BENIN|229", "DINAMARCA|232", "DOMINICA|235", "ECUADOR|239", "EGIPTO|240", "EL SALVADOR|242", "ERITREA|243", "EMIRATOS ARABES UNIDOS|244", "ESPAÑA|245", "ESLOVAQUIA|246", "ESLOVENIA|247", "ESTADOS UNIDOS|249", "ESTONIA|251", "ETIOPIA|253", "FEROE, ISLAS|259", "FILIPINAS|267", "FINLANDIA|271", "FRANCIA|275", "GABON|281", "GAMBIA|285", "GEORGIA|287", "GHANA|289", "GIBRALTAR|293", "GRANADA|297", "GRECIA|301", "GROENLANDIA|305", "GUADALUPE|309", "GUAM|313", "GUATEMALA|317", "GUAYANA FRANCESA|325", "GUINEA|329", "GUINEA ECUATORIAL|331", "GUINEA-BISSAU|334", "GUAYANA|337", "HAITI|341", "HONDURAS|345", "HONG KONG|351", "HUNGRIA|355", "INDIA|361", "INDONESIA|365", "IRAK|369", "IRAN, REPUBLICA ISLAMICA DEL|372", "IRLANDA (EIRE)|375", "ISLANDIA|379", "ISRAEL|383", "ITALIA|386", "JAMAICA|391", "JAPON|399", "JORDANIA|403", "KASAJSTAN|406", "KENIA|410", "KIRIBATI|411", "KIRGUIZISTAN|412", "KUWAIT|413", "LAOS, REPUBLICA POPULAR DEMOCRATICA DE|420", "LESOTHO|426", "LETONIA|429", "LIBANO|431", "LIBERIA|434", "LIBIA (INCLUYE FEZZAN)|438", "LIECHTENSTEIN|440", "LITUANIA|443", "LUXEMBURGO|445", "MACAO|447", "MACEDONIA|448", "MADAGASCAR|450", "MALAYSIA|455", "MALAWI|458", "MALDIVAS|461", "MALI|464", "MALTA|467", "MARIANAS DEL NORTE, ISLAS|469", "MARSHALL, ISLAS|472", "MARRUECOS|474", "MARTINICA|477", "MAURICIO|485", "MAURITANIA|488", "MEXICO|493", "MICRONESIA, ESTADOS FEDERADOS DE|494", "MOLDAVIA|496", "MONGOLIA|497", "MONACO|498", "MONSERRAT, ISLA|501", "MOZAMBIQUE|505", "NAMIBIA|507", "NAURU|508", "NAVIDAD (CHRISTMAS), ISLAS|511", "NEPAL|517", "NICARAGUA|521", "NIGER|525", "NIGERIA|528", "NIUE, ISLA|531", "NORFOLK, ISLA|535", "NORUEGA|538", "NUEVA CALEDONIA|542", "PAPUASIA NUEVA GUINEA|545", "NUEVA ZELANDIA|548", "VANUATU|551", "OMAN|556", "PACIFICO, ISLAS (USA)|566", "PAISES BAJOS (HOLANDA)|573", "PAKISTAN|576", "PALAU, ISLAS|578", "PANAMA|580", "PARAGUAY|586", "PERU|589", "PITCAIRN, ISLA|593", "POLINESIA FRANCESA|599", "POLONIA|603", "PORTUGAL|607", "PUERTO RICO|611", "QATAR|618", "REINO UNIDO|628", "REPUBLICA CENTROAFRICANA|640", "REPUBLICA CHECA|644", "REPUBLICA DOMINICANA|647", "REUNION|660", "ZIMBABWE|665", "RUMANIA|670", "RUANDA|675", "RUSIA|676", "SALOMON, ISLAS|677", "SAHARA OCCIDENTAL|685", "SAMOA|687", "SAMOA NORTEAMERICANA|690", "SAN CRISTOBAL Y NIEVES|695", "SAN MARINO|697", "SAN PEDRO Y MIGUELON|700", "SAN VICENTE Y LAS GRANADINAS|705", "SANTA ELENA|710", "SANTA LUCIA|715", "SANTO TOME Y PRINCIPE|720", "SENEGAL|728", "SEYCHELLES|731", "SIERRA LEONA|735", "SINGAPUR|741", "SIRIA, REPUBLICA ARABE DE|744", "SOMALIA|748", "SRI LANKA|750", "SUDAFRICA, REPUBLICA DE|756", "SUDAN|759", "SUECIA|764", "SUIZA|767", "SURINAM|770", "SWAZILANDIA|773", "TADJIKISTAN|774", "TAILANDIA|776", "TANZANIA, REPUBLICA UNIDA DE|780", "DJIBOUTI|783", "TERRITORIO BRITANICO DEL OCEANO INDICO|787", "TIMOR DEL ESTE|788", "TOGO|800", "TOKELAU|805", "TONGA|810", "TRINIDAD Y TOBAGO|815", "TUNICIA|820", "TURCAS Y CAICOS, ISLAS|823", "TURKMENISTAN|825", "TURQUIA|827", "TUVALU|828", "UCRANIA|830", "UGANDA|833", "URUGUAY|845", "UZBEKISTAN|847", "VENEZUELA|850", "VIET NAM|855", "VIRGENES, ISLAS (BRITANICAS)|863", "VIRGENES, ISLAS (NORTEAMERICANAS)|866", "FIJI|870", "WALLIS Y FORTUNA, ISLAS|875", "YEMEN|880", "YUGOSLAVIA|885", "ZAIRE|888", "ZAMBIA|890", "ZONA NEUTRAL PALESTINA|897"})
        Me.ComboBox_pais.Location = New System.Drawing.Point(14, 277)
        Me.ComboBox_pais.Name = "ComboBox_pais"
        Me.ComboBox_pais.Size = New System.Drawing.Size(336, 24)
        Me.ComboBox_pais.TabIndex = 21
        Me.ComboBox_pais.Text = "COLOMBIA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(749, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 667
        Me.Label4.Text = "Contacto Activo"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label23, BunifuAnimatorNS.DecorationType.None)
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.DimGray
        Me.Label23.Location = New System.Drawing.Point(277, 139)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(110, 13)
        Me.Label23.TabIndex = 652
        Me.Label23.Text = "Agente Retenedor"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox_autoretenedor
        '
        Me.ComboBox_autoretenedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox_autoretenedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox_autoretenedor.BackColor = System.Drawing.Color.White
        Me.BunifuTransition1.SetDecoration(Me.ComboBox_autoretenedor, BunifuAnimatorNS.DecorationType.None)
        Me.ComboBox_autoretenedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ComboBox_autoretenedor.ForeColor = System.Drawing.Color.Black
        Me.ComboBox_autoretenedor.FormattingEnabled = True
        Me.ComboBox_autoretenedor.ItemHeight = 16
        Me.ComboBox_autoretenedor.Items.AddRange(New Object() {"SI", "NO"})
        Me.ComboBox_autoretenedor.Location = New System.Drawing.Point(146, 153)
        Me.ComboBox_autoretenedor.Name = "ComboBox_autoretenedor"
        Me.ComboBox_autoretenedor.Size = New System.Drawing.Size(114, 24)
        Me.ComboBox_autoretenedor.TabIndex = 14
        '
        'ComboBox_Agenteretenedor
        '
        Me.ComboBox_Agenteretenedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox_Agenteretenedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox_Agenteretenedor.BackColor = System.Drawing.Color.White
        Me.BunifuTransition1.SetDecoration(Me.ComboBox_Agenteretenedor, BunifuAnimatorNS.DecorationType.None)
        Me.ComboBox_Agenteretenedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ComboBox_Agenteretenedor.ForeColor = System.Drawing.Color.Black
        Me.ComboBox_Agenteretenedor.FormattingEnabled = True
        Me.ComboBox_Agenteretenedor.ItemHeight = 16
        Me.ComboBox_Agenteretenedor.Items.AddRange(New Object() {"SI", "NO"})
        Me.ComboBox_Agenteretenedor.Location = New System.Drawing.Point(278, 153)
        Me.ComboBox_Agenteretenedor.Name = "ComboBox_Agenteretenedor"
        Me.ComboBox_Agenteretenedor.Size = New System.Drawing.Size(164, 24)
        Me.ComboBox_Agenteretenedor.TabIndex = 15
        '
        'Combo_naturaleza
        '
        Me.Combo_naturaleza.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Combo_naturaleza.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Combo_naturaleza.BackColor = System.Drawing.Color.White
        Me.BunifuTransition1.SetDecoration(Me.Combo_naturaleza, BunifuAnimatorNS.DecorationType.None)
        Me.Combo_naturaleza.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Combo_naturaleza.ForeColor = System.Drawing.Color.Black
        Me.Combo_naturaleza.FormattingEnabled = True
        Me.Combo_naturaleza.Items.AddRange(New Object() {"Persona Natural", "Persona Jurídica"})
        Me.Combo_naturaleza.Location = New System.Drawing.Point(14, 67)
        Me.Combo_naturaleza.Name = "Combo_naturaleza"
        Me.Combo_naturaleza.Size = New System.Drawing.Size(202, 24)
        Me.Combo_naturaleza.TabIndex = 3
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label20, BunifuAnimatorNS.DecorationType.None)
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.DimGray
        Me.Label20.Location = New System.Drawing.Point(148, 139)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(87, 13)
        Me.Label20.TabIndex = 647
        Me.Label20.Text = "Autoretenedor"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label22, BunifuAnimatorNS.DecorationType.None)
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.DimGray
        Me.Label22.Location = New System.Drawing.Point(16, 139)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(69, 13)
        Me.Label22.TabIndex = 650
        Me.Label22.Text = "Declarante"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox_tipocontribuyente
        '
        Me.ComboBox_tipocontribuyente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox_tipocontribuyente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox_tipocontribuyente.BackColor = System.Drawing.Color.White
        Me.BunifuTransition1.SetDecoration(Me.ComboBox_tipocontribuyente, BunifuAnimatorNS.DecorationType.None)
        Me.ComboBox_tipocontribuyente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ComboBox_tipocontribuyente.ForeColor = System.Drawing.Color.Black
        Me.ComboBox_tipocontribuyente.FormattingEnabled = True
        Me.ComboBox_tipocontribuyente.ItemHeight = 16
        Me.ComboBox_tipocontribuyente.Items.AddRange(New Object() {"Entidades del Estado", "Gran Contribuyente", "Régimen Común", "Régimen Simplificado", "Excluido", "Régimen Simplificado para personas no residentes en el país", "No residentes No Responsables de IVA"})
        Me.ComboBox_tipocontribuyente.Location = New System.Drawing.Point(235, 67)
        Me.ComboBox_tipocontribuyente.Name = "ComboBox_tipocontribuyente"
        Me.ComboBox_tipocontribuyente.Size = New System.Drawing.Size(386, 24)
        Me.ComboBox_tipocontribuyente.TabIndex = 4
        '
        'DateTimePicker1
        '
        Me.BunifuTransition1.SetDecoration(Me.DateTimePicker1, BunifuAnimatorNS.DecorationType.None)
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(637, 67)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowUpDown = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(97, 23)
        Me.DateTimePicker1.TabIndex = 5
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label26, BunifuAnimatorNS.DecorationType.None)
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.DimGray
        Me.Label26.Location = New System.Drawing.Point(634, 53)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(42, 13)
        Me.Label26.TabIndex = 664
        Me.Label26.Text = "Fecha"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox_declarante
        '
        Me.ComboBox_declarante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox_declarante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox_declarante.BackColor = System.Drawing.Color.White
        Me.BunifuTransition1.SetDecoration(Me.ComboBox_declarante, BunifuAnimatorNS.DecorationType.None)
        Me.ComboBox_declarante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ComboBox_declarante.ForeColor = System.Drawing.Color.Black
        Me.ComboBox_declarante.FormattingEnabled = True
        Me.ComboBox_declarante.ItemHeight = 16
        Me.ComboBox_declarante.Items.AddRange(New Object() {"SI", "NO"})
        Me.ComboBox_declarante.Location = New System.Drawing.Point(16, 153)
        Me.ComboBox_declarante.Name = "ComboBox_declarante"
        Me.ComboBox_declarante.Size = New System.Drawing.Size(114, 24)
        Me.ComboBox_declarante.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label10, BunifuAnimatorNS.DecorationType.None)
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(232, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 13)
        Me.Label10.TabIndex = 646
        Me.Label10.Text = "Tipo de Contribuyente"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label9, BunifuAnimatorNS.DecorationType.None)
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(13, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 13)
        Me.Label9.TabIndex = 645
        Me.Label9.Text = "Naturaleza Juridica"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label13, BunifuAnimatorNS.DecorationType.None)
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DimGray
        Me.Label13.Location = New System.Drawing.Point(234, 6)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(118, 13)
        Me.Label13.TabIndex = 635
        Me.Label13.Text = "Tipo de Documento"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox_tipodoc
        '
        Me.ComboBox_tipodoc.AutoCompleteCustomSource.AddRange(New String() {"MEDELLIN - ANTIOQUIA", "ABEJORRAL - ANTIOQUIA", "ABRIAQUI - ANTIOQUIA", "ALEJANDRIA - ANTIOQUIA", "AMAGA - ANTIOQUIA", "AMALFI - ANTIOQUIA", "ANDES - ANTIOQUIA", "ANGELOPOLIS - ANTIOQUIA", "ANGOSTURA - ANTIOQUIA", "ANORI - ANTIOQUIA", "SANTAFE DE ANTIOQUIA - ANTIOQUIA", "ANZA - ANTIOQUIA", "APARTADO - ANTIOQUIA", "ARBOLETES - ANTIOQUIA", "ARGELIA - ANTIOQUIA", "ARMENIA - ANTIOQUIA", "BARBOSA - ANTIOQUIA", "BELMIRA - ANTIOQUIA", "BELLO - ANTIOQUIA", "BETANIA - ANTIOQUIA", "BETULIA - ANTIOQUIA", "CIUDAD BOLIVAR - ANTIOQUIA", "BRICEÑO - ANTIOQUIA", "BURITICA - ANTIOQUIA", "CACERES - ANTIOQUIA", "CAICEDO - ANTIOQUIA", "CALDAS - ANTIOQUIA", "CAMPAMENTO - ANTIOQUIA", "CAÑASGORDAS - ANTIOQUIA", "CARACOLI - ANTIOQUIA", "CARAMANTA - ANTIOQUIA", "CAREPA - ANTIOQUIA", "EL CARMEN DE VIBORAL - ANTIOQUIA", "CAROLINA - ANTIOQUIA", "CAUCASIA - ANTIOQUIA", "CHIGORODO - ANTIOQUIA", "CISNEROS - ANTIOQUIA", "COCORNA - ANTIOQUIA", "CONCEPCION - ANTIOQUIA", "CONCORDIA - ANTIOQUIA", "COPACABANA - ANTIOQUIA", "DABEIBA - ANTIOQUIA", "DON MATIAS - ANTIOQUIA", "EBEJICO - ANTIOQUIA", "EL BAGRE - ANTIOQUIA", "ENTRERRIOS - ANTIOQUIA", "ENVIGADO - ANTIOQUIA", "FREDONIA - ANTIOQUIA", "FRONTINO - ANTIOQUIA", "GIRALDO - ANTIOQUIA", "GIRARDOTA - ANTIOQUIA", "GOMEZ PLATA - ANTIOQUIA", "GRANADA - ANTIOQUIA", "GUADALUPE - ANTIOQUIA", "GUARNE - ANTIOQUIA", "GUATAPE - ANTIOQUIA", "HELICONIA - ANTIOQUIA", "HISPANIA - ANTIOQUIA", "ITAGUI - ANTIOQUIA", "ITUANGO - ANTIOQUIA", "JARDIN - ANTIOQUIA", "JERICO - ANTIOQUIA", "LA CEJA - ANTIOQUIA", "LA ESTRELLA - ANTIOQUIA", "LA PINTADA - ANTIOQUIA", "LA UNION - ANTIOQUIA", "LIBORINA - ANTIOQUIA", "MACEO - ANTIOQUIA", "MARINILLA - ANTIOQUIA", "MONTEBELLO - ANTIOQUIA", "MURINDO - ANTIOQUIA", "MUTATA - ANTIOQUIA", "NARIÑO - ANTIOQUIA", "NECOCLI - ANTIOQUIA", "NECHI - ANTIOQUIA", "OLAYA - ANTIOQUIA", "PEÐOL - ANTIOQUIA", "PEQUE - ANTIOQUIA", "PUEBLORRICO - ANTIOQUIA", "PUERTO BERRIO - ANTIOQUIA", "PUERTO NARE - ANTIOQUIA", "PUERTO TRIUNFO - ANTIOQUIA", "REMEDIOS - ANTIOQUIA", "RETIRO - ANTIOQUIA", "RIONEGRO - ANTIOQUIA", "SABANALARGA - ANTIOQUIA", "SABANETA - ANTIOQUIA", "SALGAR - ANTIOQUIA", "SAN ANDRES DE CUERQUIA - ANTIOQUIA", "SAN CARLOS - ANTIOQUIA", "SAN FRANCISCO - ANTIOQUIA", "SAN JERONIMO - ANTIOQUIA", "SAN JOSE DE LA MONTAÑA - ANTIOQUIA", "SAN JUAN DE URABA - ANTIOQUIA", "SAN LUIS - ANTIOQUIA", "SAN PEDRO - ANTIOQUIA", "SAN PEDRO DE URABA - ANTIOQUIA", "SAN RAFAEL - ANTIOQUIA", "SAN ROQUE - ANTIOQUIA", "SAN VICENTE - ANTIOQUIA", "SANTA BARBARA - ANTIOQUIA", "SANTA ROSA DE OSOS - ANTIOQUIA", "SANTO DOMINGO - ANTIOQUIA", "EL SANTUARIO - ANTIOQUIA", "SEGOVIA - ANTIOQUIA", "SONSON - ANTIOQUIA", "SOPETRAN - ANTIOQUIA", "TAMESIS - ANTIOQUIA", "TARAZA - ANTIOQUIA", "TARSO - ANTIOQUIA", "TITIRIBI - ANTIOQUIA", "TOLEDO - ANTIOQUIA", "TURBO - ANTIOQUIA", "URAMITA - ANTIOQUIA", "URRAO - ANTIOQUIA", "VALDIVIA - ANTIOQUIA", "VALPARAISO - ANTIOQUIA", "VEGACHI - ANTIOQUIA", "VENECIA - ANTIOQUIA", "VIGIA DEL FUERTE - ANTIOQUIA", "YALI - ANTIOQUIA", "YARUMAL - ANTIOQUIA", "YOLOMBO - ANTIOQUIA", "YONDO - ANTIOQUIA", "ZARAGOZA - ANTIOQUIA", "BARRANQUILLA - ATLANTICO", "BARANOA - ATLANTICO", "CAMPO DE LA CRUZ - ATLANTICO", "CANDELARIA - ATLANTICO", "GALAPA - ATLANTICO", "JUAN DE ACOSTA - ATLANTICO", "LURUACO - ATLANTICO", "MALAMBO - ATLANTICO", "MANATI - ATLANTICO", "PALMAR DE VARELA - ATLANTICO", "PIOJO - ATLANTICO", "POLONUEVO - ATLANTICO", "PONEDERA - ATLANTICO", "PUERTO COLOMBIA - ATLANTICO", "REPELON - ATLANTICO", "SABANAGRANDE - ATLANTICO", "SABANALARGA - ATLANTICO", "SANTA LUCIA - ATLANTICO", "SANTO TOMAS - ATLANTICO", "SOLEDAD - ATLANTICO", "SUAN - ATLANTICO", "TUBARA - ATLANTICO", "USIACURI - ATLANTICO", "BOGOTA, D.C. - BOGOTA", "CARTAGENA - BOLIVAR", "ACHI - BOLIVAR", "ALTOS DEL ROSARIO - BOLIVAR", "ARENAL - BOLIVAR", "ARJONA - BOLIVAR", "ARROYOHONDO - BOLIVAR", "BARRANCO DE LOBA - BOLIVAR", "CALAMAR - BOLIVAR", "CANTAGALLO - BOLIVAR", "CICUCO - BOLIVAR", "CORDOBA - BOLIVAR", "CLEMENCIA - BOLIVAR", "EL CARMEN DE BOLIVAR - BOLIVAR", "EL GUAMO - BOLIVAR", "EL PEÑON - BOLIVAR", "HATILLO DE LOBA - BOLIVAR", "MAGANGUE - BOLIVAR", "MAHATES - BOLIVAR", "MARGARITA - BOLIVAR", "MARIA LA BAJA - BOLIVAR", "MONTECRISTO - BOLIVAR", "MOMPOS - BOLIVAR", "NOROSI - BOLIVAR", "MORALES - BOLIVAR", "PINILLOS - BOLIVAR", "REGIDOR - BOLIVAR", "RIO VIEJO - BOLIVAR", "SAN CRISTOBAL - BOLIVAR", "SAN ESTANISLAO - BOLIVAR", "SAN FERNANDO - BOLIVAR", "SAN JACINTO - BOLIVAR", "SAN JACINTO DEL CAUCA - BOLIVAR", "SAN JUAN NEPOMUCENO - BOLIVAR", "SAN MARTIN DE LOBA - BOLIVAR", "SAN PABLO - BOLIVAR", "SANTA CATALINA - BOLIVAR", "SANTA ROSA - BOLIVAR", "SANTA ROSA DEL SUR - BOLIVAR", "SIMITI - BOLIVAR", "SOPLAVIENTO - BOLIVAR", "TALAIGUA NUEVO - BOLIVAR", "TIQUISIO - BOLIVAR", "TURBACO - BOLIVAR", "TURBANA - BOLIVAR", "VILLANUEVA - BOLIVAR", "ZAMBRANO - BOLIVAR", "TUNJA - BOYACA", "ALMEIDA - BOYACA", "AQUITANIA - BOYACA", "ARCABUCO - BOYACA", "BELEN - BOYACA", "BERBEO - BOYACA", "BETEITIVA - BOYACA", "BOAVITA - BOYACA", "BOYACA - BOYACA", "BRICEÑO - BOYACA", "BUENAVISTA - BOYACA", "BUSBANZA - BOYACA", "CALDAS - BOYACA", "CAMPOHERMOSO - BOYACA", "CERINZA - BOYACA", "CHINAVITA - BOYACA", "CHIQUINQUIRA - BOYACA", "CHISCAS - BOYACA", "CHITA - BOYACA", "CHITARAQUE - BOYACA", "CHIVATA - BOYACA", "CIENEGA - BOYACA", "COMBITA - BOYACA", "COPER - BOYACA", "CORRALES - BOYACA", "COVARACHIA - BOYACA", "CUBARA - BOYACA", "CUCAITA - BOYACA", "CUITIVA - BOYACA", "CHIQUIZA - BOYACA", "CHIVOR - BOYACA", "DUITAMA - BOYACA", "EL COCUY - BOYACA", "EL ESPINO - BOYACA", "FIRAVITOBA - BOYACA", "FLORESTA - BOYACA", "GACHANTIVA - BOYACA", "GAMEZA - BOYACA", "GARAGOA - BOYACA", "GUACAMAYAS - BOYACA", "GUATEQUE - BOYACA", "GUAYATA - BOYACA", "GsICAN - BOYACA", "IZA - BOYACA", "JENESANO - BOYACA", "JERICO - BOYACA", "LABRANZAGRANDE - BOYACA", "LA CAPILLA - BOYACA", "LA VICTORIA - BOYACA", "LA UVITA - BOYACA", "VILLA DE LEYVA - BOYACA", "MACANAL - BOYACA", "MARIPI - BOYACA", "MIRAFLORES - BOYACA", "MONGUA - BOYACA", "MONGUI - BOYACA", "MONIQUIRA - BOYACA", "MOTAVITA - BOYACA", "MUZO - BOYACA", "NOBSA - BOYACA", "NUEVO COLON - BOYACA", "OICATA - BOYACA", "OTANCHE - BOYACA", "PACHAVITA - BOYACA", "PAEZ - BOYACA", "PAIPA - BOYACA", "PAJARITO - BOYACA", "PANQUEBA - BOYACA", "PAUNA - BOYACA", "PAYA - BOYACA", "PAZ DE RIO - BOYACA", "PESCA - BOYACA", "PISBA - BOYACA", "PUERTO BOYACA - BOYACA", "QUIPAMA - BOYACA", "RAMIRIQUI - BOYACA", "RAQUIRA - BOYACA", "RONDON - BOYACA", "SABOYA - BOYACA", "SACHICA - BOYACA", "SAMACA - BOYACA", "SAN EDUARDO - BOYACA", "SAN JOSE DE PARE - BOYACA", "SAN LUIS DE GACENO - BOYACA", "SAN MATEO - BOYACA", "SAN MIGUEL DE SEMA - BOYACA", "SAN PABLO DE BORBUR - BOYACA", "SANTANA - BOYACA", "SANTA MARIA - BOYACA", "SANTA ROSA DE VITERBO - BOYACA", "SANTA SOFIA - BOYACA", "SATIVANORTE - BOYACA", "SATIVASUR - BOYACA", "SIACHOQUE - BOYACA", "SOATA - BOYACA", "SOCOTA - BOYACA", "SOCHA - BOYACA", "SOGAMOSO - BOYACA", "SOMONDOCO - BOYACA", "SORA - BOYACA", "SOTAQUIRA - BOYACA", "SORACA - BOYACA", "SUSACON - BOYACA", "SUTAMARCHAN - BOYACA", "SUTATENZA - BOYACA", "TASCO - BOYACA", "TENZA - BOYACA", "TIBANA - BOYACA", "TIBASOSA - BOYACA", "TINJACA - BOYACA", "TIPACOQUE - BOYACA", "TOCA - BOYACA", "TOGsI - BOYACA", "TOPAGA - BOYACA", "TOTA - BOYACA", "TUNUNGUA - BOYACA", "TURMEQUE - BOYACA", "TUTA - BOYACA", "TUTAZA - BOYACA", "UMBITA - BOYACA", "VENTAQUEMADA - BOYACA", "VIRACACHA - BOYACA", "ZETAQUIRA - BOYACA", "MANIZALES - CALDAS", "AGUADAS - CALDAS", "ANSERMA - CALDAS", "ARANZAZU - CALDAS", "BELALCAZAR - CALDAS", "CHINCHINA - CALDAS", "FILADELFIA - CALDAS", "LA DORADA - CALDAS", "LA MERCED - CALDAS", "MANZANARES - CALDAS", "MARMATO - CALDAS", "MARQUETALIA - CALDAS", "MARULANDA - CALDAS", "NEIRA - CALDAS", "NORCASIA - CALDAS", "PACORA - CALDAS", "PALESTINA - CALDAS", "PENSILVANIA - CALDAS", "RIOSUCIO - CALDAS", "RISARALDA - CALDAS", "SALAMINA - CALDAS", "SAMANA - CALDAS", "SAN JOSE - CALDAS", "SUPIA - CALDAS", "VICTORIA - CALDAS", "VILLAMARIA - CALDAS", "VITERBO - CALDAS", "FLORENCIA - CAQUETA", "ALBANIA - CAQUETA", "BELEN DE LOS ANDAQUIES - CAQUETA", "CARTAGENA DEL CHAIRA - CAQUETA", "CURILLO - CAQUETA", "EL DONCELLO - CAQUETA", "EL PAUJIL - CAQUETA", "LA MONTAÑITA - CAQUETA", "MILAN - CAQUETA", "MORELIA - CAQUETA", "PUERTO RICO - CAQUETA", "SAN JOSE DEL FRAGUA - CAQUETA", "SAN VICENTE DEL CAGUAN - CAQUETA", "SOLANO - CAQUETA", "SOLITA - CAQUETA", "VALPARAISO - CAQUETA", "POPAYAN - CAUCA", "ALMAGUER - CAUCA", "ARGELIA - CAUCA", "BALBOA - CAUCA", "BOLIVAR - CAUCA", "BUENOS AIRES - CAUCA", "CAJIBIO - CAUCA", "CALDONO - CAUCA", "CALOTO - CAUCA", "CORINTO - CAUCA", "EL TAMBO - CAUCA", "FLORENCIA - CAUCA", "GUACHENE - CAUCA", "GUAPI - CAUCA", "INZA - CAUCA", "JAMBALO - CAUCA", "LA SIERRA - CAUCA", "LA VEGA - CAUCA", "LOPEZ - CAUCA", "MERCADERES - CAUCA", "MIRANDA - CAUCA", "MORALES - CAUCA", "PADILLA - CAUCA", "PAEZ - CAUCA", "PATIA - CAUCA", "PIAMONTE - CAUCA", "PIENDAMO - CAUCA", "PUERTO TEJADA - CAUCA", "PURACE - CAUCA", "ROSAS - CAUCA", "SAN SEBASTIAN - CAUCA", "SANTANDER DE QUILICHAO - CAUCA", "SANTA ROSA - CAUCA", "SILVIA - CAUCA", "SOTARA - CAUCA", "SUAREZ - CAUCA", "SUCRE - CAUCA", "TIMBIO - CAUCA", "TIMBIQUI - CAUCA", "TORIBIO - CAUCA", "TOTORO - CAUCA", "VILLA RICA - CAUCA", "VALLEDUPAR - CESAR", "AGUACHICA - CESAR", "AGUSTIN CODAZZI - CESAR", "ASTREA - CESAR", "BECERRIL - CESAR", "BOSCONIA - CESAR", "CHIMICHAGUA - CESAR", "CHIRIGUANA - CESAR", "CURUMANI - CESAR", "EL COPEY - CESAR", "EL PASO - CESAR", "GAMARRA - CESAR", "GONZALEZ - CESAR", "LA GLORIA - CESAR", "LA JAGUA DE IBIRICO - CESAR", "MANAURE - CESAR", "PAILITAS - CESAR", "PELAYA - CESAR", "PUEBLO BELLO - CESAR", "RIO DE ORO - CESAR", "LA PAZ - CESAR", "SAN ALBERTO - CESAR", "SAN DIEGO - CESAR", "SAN MARTIN - CESAR", "TAMALAMEQUE - CESAR", "MONTERIA - CORDOBA", "AYAPEL - CORDOBA", "BUENAVISTA - CORDOBA", "CANALETE - CORDOBA", "CERETE - CORDOBA", "CHIMA - CORDOBA", "CHINU - CORDOBA", "CIENAGA DE ORO - CORDOBA", "COTORRA - CORDOBA", "LA APARTADA - CORDOBA", "LORICA - CORDOBA", "LOS CORDOBAS - CORDOBA", "MOMIL - CORDOBA", "MONTELIBANO - CORDOBA", "MOÑITOS - CORDOBA", "PLANETA RICA - CORDOBA", "PUEBLO NUEVO - CORDOBA", "PUERTO ESCONDIDO - CORDOBA", "PUERTO LIBERTADOR - CORDOBA", "PURISIMA - CORDOBA", "SAHAGUN - CORDOBA", "SAN ANDRES SOTAVENTO - CORDOBA", "SAN ANTERO - CORDOBA", "SAN BERNARDO DEL VIENTO - CORDOBA", "SAN CARLOS - CORDOBA", "SAN PELAYO - CORDOBA", "TIERRALTA - CORDOBA", "VALENCIA - CORDOBA", "AGUA DE DIOS - CUNDINAMARCA", "ALBAN - CUNDINAMARCA", "ANAPOIMA - CUNDINAMARCA", "ANOLAIMA - CUNDINAMARCA", "ARBELAEZ - CUNDINAMARCA", "BELTRAN - CUNDINAMARCA", "BITUIMA - CUNDINAMARCA", "BOJACA - CUNDINAMARCA", "CABRERA - CUNDINAMARCA", "CACHIPAY - CUNDINAMARCA", "CAJICA - CUNDINAMARCA", "CAPARRAPI - CUNDINAMARCA", "CAQUEZA - CUNDINAMARCA", "CARMEN DE CARUPA - CUNDINAMARCA", "CHAGUANI - CUNDINAMARCA", "CHIA - CUNDINAMARCA", "CHIPAQUE - CUNDINAMARCA", "CHOACHI - CUNDINAMARCA", "CHOCONTA - CUNDINAMARCA", "COGUA - CUNDINAMARCA", "COTA - CUNDINAMARCA", "CUCUNUBA - CUNDINAMARCA", "EL COLEGIO - CUNDINAMARCA", "EL PEÑON - CUNDINAMARCA", "EL ROSAL - CUNDINAMARCA", "FACATATIVA - CUNDINAMARCA", "FOMEQUE - CUNDINAMARCA", "FOSCA - CUNDINAMARCA", "FUNZA - CUNDINAMARCA", "FUQUENE - CUNDINAMARCA", "FUSAGASUGA - CUNDINAMARCA", "GACHALA - CUNDINAMARCA", "GACHANCIPA - CUNDINAMARCA", "GACHETA - CUNDINAMARCA", "GAMA - CUNDINAMARCA", "GIRARDOT - CUNDINAMARCA", "GRANADA - CUNDINAMARCA", "GUACHETA - CUNDINAMARCA", "GUADUAS - CUNDINAMARCA", "GUASCA - CUNDINAMARCA", "GUATAQUI - CUNDINAMARCA", "GUATAVITA - CUNDINAMARCA", "GUAYABAL DE SIQUIMA - CUNDINAMARCA", "GUAYABETAL - CUNDINAMARCA", "GUTIERREZ - CUNDINAMARCA", "JERUSALEN - CUNDINAMARCA", "JUNIN - CUNDINAMARCA", "LA CALERA - CUNDINAMARCA", "LA MESA - CUNDINAMARCA", "LA PALMA - CUNDINAMARCA", "LA PEÑA - CUNDINAMARCA", "LA VEGA - CUNDINAMARCA", "LENGUAZAQUE - CUNDINAMARCA", "MACHETA - CUNDINAMARCA", "MADRID - CUNDINAMARCA", "MANTA - CUNDINAMARCA", "MEDINA - CUNDINAMARCA", "MOSQUERA - CUNDINAMARCA", "NARIÑO - CUNDINAMARCA", "NEMOCON - CUNDINAMARCA", "NILO - CUNDINAMARCA", "NIMAIMA - CUNDINAMARCA", "NOCAIMA - CUNDINAMARCA", "VENECIA - CUNDINAMARCA", "PACHO - CUNDINAMARCA", "PAIME - CUNDINAMARCA", "PANDI - CUNDINAMARCA", "PARATEBUENO - CUNDINAMARCA", "PASCA - CUNDINAMARCA", "PUERTO SALGAR - CUNDINAMARCA", "PULI - CUNDINAMARCA", "QUEBRADANEGRA - CUNDINAMARCA", "QUETAME - CUNDINAMARCA", "QUIPILE - CUNDINAMARCA", "APULO - CUNDINAMARCA", "RICAURTE - CUNDINAMARCA", "SAN ANTONIO DEL TEQUENDAMA - CUNDINAMARCA", "SAN BERNARDO - CUNDINAMARCA", "SAN CAYETANO - CUNDINAMARCA", "SAN FRANCISCO - CUNDINAMARCA", "SAN JUAN DE RIO SECO - CUNDINAMARCA", "SASAIMA - CUNDINAMARCA", "SESQUILE - CUNDINAMARCA", "SIBATE - CUNDINAMARCA", "SILVANIA - CUNDINAMARCA", "SIMIJACA - CUNDINAMARCA", "SOACHA - CUNDINAMARCA", "SOPO - CUNDINAMARCA", "SUBACHOQUE - CUNDINAMARCA", "SUESCA - CUNDINAMARCA", "SUPATA - CUNDINAMARCA", "SUSA - CUNDINAMARCA", "SUTATAUSA - CUNDINAMARCA", "TABIO - CUNDINAMARCA", "TAUSA - CUNDINAMARCA", "TENA - CUNDINAMARCA", "TENJO - CUNDINAMARCA", "TIBACUY - CUNDINAMARCA", "TIBIRITA - CUNDINAMARCA", "TOCAIMA - CUNDINAMARCA", "TOCANCIPA - CUNDINAMARCA", "TOPAIPI - CUNDINAMARCA", "UBALA - CUNDINAMARCA", "UBAQUE - CUNDINAMARCA", "VILLA DE SAN DIEGO DE UBATE - CUNDINAMARCA", "UNE - CUNDINAMARCA", "UTICA - CUNDINAMARCA", "VERGARA - CUNDINAMARCA", "VIANI - CUNDINAMARCA", "VILLAGOMEZ - CUNDINAMARCA", "VILLAPINZON - CUNDINAMARCA", "VILLETA - CUNDINAMARCA", "VIOTA - CUNDINAMARCA", "YACOPI - CUNDINAMARCA", "ZIPACON - CUNDINAMARCA", "ZIPAQUIRA - CUNDINAMARCA", "QUIBDO - CHOCO", "ACANDI - CHOCO", "ALTO BAUDO - CHOCO", "ATRATO - CHOCO", "BAGADO - CHOCO", "BAHIA SOLANO - CHOCO", "BAJO BAUDO - CHOCO", "BOJAYA - CHOCO", "EL CANTON DEL SAN PABLO - CHOCO", "CARMEN DEL DARIEN - CHOCO", "CERTEGUI - CHOCO", "CONDOTO - CHOCO", "EL CARMEN DE ATRATO - CHOCO", "EL LITORAL DEL SAN JUAN - CHOCO", "ISTMINA - CHOCO", "JURADO - CHOCO", "LLORO - CHOCO", "MEDIO ATRATO - CHOCO", "MEDIO BAUDO - CHOCO", "MEDIO SAN JUAN - CHOCO", "NOVITA - CHOCO", "NUQUI - CHOCO", "RIO IRO - CHOCO", "RIO QUITO - CHOCO", "RIOSUCIO - CHOCO", "SAN JOSE DEL PALMAR - CHOCO", "SIPI - CHOCO", "TADO - CHOCO", "UNGUIA - CHOCO", "UNION PANAMERICANA - CHOCO", "NEIVA - HUILA", "ACEVEDO - HUILA", "AGRADO - HUILA", "AIPE - HUILA", "ALGECIRAS - HUILA", "ALTAMIRA - HUILA", "BARAYA - HUILA", "CAMPOALEGRE - HUILA", "COLOMBIA - HUILA", "ELIAS - HUILA", "GARZON - HUILA", "GIGANTE - HUILA", "GUADALUPE - HUILA", "HOBO - HUILA", "IQUIRA - HUILA", "ISNOS - HUILA", "LA ARGENTINA - HUILA", "LA PLATA - HUILA", "NATAGA - HUILA", "OPORAPA - HUILA", "PAICOL - HUILA", "PALERMO - HUILA", "PALESTINA - HUILA", "PITAL - HUILA", "PITALITO - HUILA", "RIVERA - HUILA", "SALADOBLANCO - HUILA", "SAN AGUSTIN - HUILA", "SANTA MARIA - HUILA", "SUAZA - HUILA", "TARQUI - HUILA", "TESALIA - HUILA", "TELLO - HUILA", "TERUEL - HUILA", "TIMANA - HUILA", "VILLAVIEJA - HUILA", "YAGUARA - HUILA", "RIOHACHA - LA GUAJIRA", "ALBANIA - LA GUAJIRA", "BARRANCAS - LA GUAJIRA", "DIBULLA - LA GUAJIRA", "DISTRACCION - LA GUAJIRA", "EL MOLINO - LA GUAJIRA", "FONSECA - LA GUAJIRA", "HATONUEVO - LA GUAJIRA", "LA JAGUA DEL PILAR - LA GUAJIRA", "MAICAO - LA GUAJIRA", "MANAURE - LA GUAJIRA", "SAN JUAN DEL CESAR - LA GUAJIRA", "URIBIA - LA GUAJIRA", "URUMITA - LA GUAJIRA", "VILLANUEVA - LA GUAJIRA", "SANTA MARTA - MAGDALENA", "ALGARROBO - MAGDALENA", "ARACATACA - MAGDALENA", "ARIGUANI - MAGDALENA", "CERRO SAN ANTONIO - MAGDALENA", "CHIBOLO - MAGDALENA", "CIENAGA - MAGDALENA", "CONCORDIA - MAGDALENA", "EL BANCO - MAGDALENA", "EL PIÑON - MAGDALENA", "EL RETEN - MAGDALENA", "FUNDACION - MAGDALENA", "GUAMAL - MAGDALENA", "NUEVA GRANADA - MAGDALENA", "PEDRAZA - MAGDALENA", "PIJIÑO DEL CARMEN - MAGDALENA", "PIVIJAY - MAGDALENA", "PLATO - MAGDALENA", "PUEBLOVIEJO - MAGDALENA", "REMOLINO - MAGDALENA", "SABANAS DE SAN ANGEL - MAGDALENA", "SALAMINA - MAGDALENA", "SAN SEBASTIAN DE BUENAVISTA - MAGDALENA", "SAN ZENON - MAGDALENA", "SANTA ANA - MAGDALENA", "SANTA BARBARA DE PINTO - MAGDALENA", "SITIONUEVO - MAGDALENA", "TENERIFE - MAGDALENA", "ZAPAYAN - MAGDALENA", "ZONA BANANERA - MAGDALENA", "VILLAVICENCIO - META", "ACACIAS - META", "BARRANCA DE UPIA - META", "CABUYARO - META", "CASTILLA LA NUEVA - META", "CUBARRAL - META", "CUMARAL - META", "EL CALVARIO - META", "EL CASTILLO - META", "EL DORADO - META", "FUENTE DE ORO - META", "GRANADA - META", "GUAMAL - META", "MAPIRIPAN - META", "MESETAS - META", "LA MACARENA - META", "URIBE - META", "LEJANIAS - META", "PUERTO CONCORDIA - META", "PUERTO GAITAN - META", "PUERTO LOPEZ - META", "PUERTO LLERAS - META", "PUERTO RICO - META", "RESTREPO - META", "SAN CARLOS DE GUAROA - META", "SAN JUAN DE ARAMA - META", "SAN JUANITO - META", "SAN MARTIN - META", "VISTAHERMOSA - META", "PASTO - NARIÑO", "ALBAN - NARIÑO", "ALDANA - NARIÑO", "ANCUYA - NARIÑO", "ARBOLEDA - NARIÑO", "BARBACOAS - NARIÑO", "BELEN - NARIÑO", "BUESACO - NARIÑO", "COLON - NARIÑO", "CONSACA - NARIÑO", "CONTADERO - NARIÑO", "CORDOBA - NARIÑO", "CUASPUD - NARIÑO", "CUMBAL - NARIÑO", "CUMBITARA - NARIÑO", "CHACHAGsI - NARIÑO", "EL CHARCO - NARIÑO", "EL PEÑOL - NARIÑO", "EL ROSARIO - NARIÑO", "EL TABLON DE GOMEZ - NARIÑO", "EL TAMBO - NARIÑO", "FUNES - NARIÑO", "GUACHUCAL - NARIÑO", "GUAITARILLA - NARIÑO", "GUALMATAN - NARIÑO", "ILES - NARIÑO", "IMUES - NARIÑO", "IPIALES - NARIÑO", "LA CRUZ - NARIÑO", "LA FLORIDA - NARIÑO", "LA LLANADA - NARIÑO", "LA TOLA - NARIÑO", "LA UNION - NARIÑO", "LEIVA - NARIÑO", "LINARES - NARIÑO", "LOS ANDES - NARIÑO", "MAGsI - NARIÑO", "MALLAMA - NARIÑO", "MOSQUERA - NARIÑO", "NARIÑO - NARIÑO", "OLAYA HERRERA - NARIÑO", "OSPINA - NARIÑO", "FRANCISCO PIZARRO - NARIÑO", "POLICARPA - NARIÑO", "POTOSI - NARIÑO", "PROVIDENCIA - NARIÑO", "PUERRES - NARIÑO", "PUPIALES - NARIÑO", "RICAURTE - NARIÑO", "ROBERTO PAYAN - NARIÑO", "SAMANIEGO - NARIÑO", "SANDONA - NARIÑO", "SAN BERNARDO - NARIÑO", "SAN LORENZO - NARIÑO", "SAN PABLO - NARIÑO", "SAN PEDRO DE CARTAGO - NARIÑO", "SANTA BARBARA - NARIÑO", "SANTACRUZ - NARIÑO", "SAPUYES - NARIÑO", "TAMINANGO - NARIÑO", "TANGUA - NARIÑO", "SAN ANDRES DE TUMACO - NARIÑO", "TUQUERRES - NARIÑO", "YACUANQUER - NARIÑO", "CUCUTA - N. DE SANTANDER", "ABREGO - N. DE SANTANDER", "ARBOLEDAS - N. DE SANTANDER", "BOCHALEMA - N. DE SANTANDER", "BUCARASICA - N. DE SANTANDER", "CACOTA - N. DE SANTANDER", "CACHIRA - N. DE SANTANDER", "CHINACOTA - N. DE SANTANDER", "CHITAGA - N. DE SANTANDER", "CONVENCION - N. DE SANTANDER", "CUCUTILLA - N. DE SANTANDER", "DURANIA - N. DE SANTANDER", "EL CARMEN - N. DE SANTANDER", "EL TARRA - N. DE SANTANDER", "EL ZULIA - N. DE SANTANDER", "GRAMALOTE - N. DE SANTANDER", "HACARI - N. DE SANTANDER", "HERRAN - N. DE SANTANDER", "LABATECA - N. DE SANTANDER", "LA ESPERANZA - N. DE SANTANDER", "LA PLAYA - N. DE SANTANDER", "LOS PATIOS - N. DE SANTANDER", "LOURDES - N. DE SANTANDER", "MUTISCUA - N. DE SANTANDER", "OCAÑA - N. DE SANTANDER", "PAMPLONA - N. DE SANTANDER", "PAMPLONITA - N. DE SANTANDER", "PUERTO SANTANDER - N. DE SANTANDER", "RAGONVALIA - N. DE SANTANDER", "SALAZAR - N. DE SANTANDER", "SAN CALIXTO - N. DE SANTANDER", "SAN CAYETANO - N. DE SANTANDER", "SANTIAGO - N. DE SANTANDER", "SARDINATA - N. DE SANTANDER", "SILOS - N. DE SANTANDER", "TEORAMA - N. DE SANTANDER", "TIBU - N. DE SANTANDER", "TOLEDO - N. DE SANTANDER", "VILLA CARO - N. DE SANTANDER", "VILLA DEL ROSARIO - N. DE SANTANDER", "ARMENIA - QUINDIO", "BUENAVISTA - QUINDIO", "CALARCA - QUINDIO", "CIRCASIA - QUINDIO", "CORDOBA - QUINDIO", "FILANDIA - QUINDIO", "GENOVA - QUINDIO", "LA TEBAIDA - QUINDIO", "MONTENEGRO - QUINDIO", "PIJAO - QUINDIO", "QUIMBAYA - QUINDIO", "SALENTO - QUINDIO", "PEREIRA - RISARALDA", "APIA - RISARALDA", "BALBOA - RISARALDA", "BELEN DE UMBRIA - RISARALDA", "DOSQUEBRADAS - RISARALDA", "GUATICA - RISARALDA", "LA CELIA - RISARALDA", "LA VIRGINIA - RISARALDA", "MARSELLA - RISARALDA", "MISTRATO - RISARALDA", "PUEBLO RICO - RISARALDA", "QUINCHIA - RISARALDA", "SANTA ROSA DE CABAL - RISARALDA", "SANTUARIO - RISARALDA", "BUCARAMANGA - SANTANDER", "AGUADA - SANTANDER", "ALBANIA - SANTANDER", "ARATOCA - SANTANDER", "BARBOSA - SANTANDER", "BARICHARA - SANTANDER", "BARRANCABERMEJA - SANTANDER", "BETULIA - SANTANDER", "BOLIVAR - SANTANDER", "CABRERA - SANTANDER", "CALIFORNIA - SANTANDER", "CAPITANEJO - SANTANDER", "CARCASI - SANTANDER", "CEPITA - SANTANDER", "CERRITO - SANTANDER", "CHARALA - SANTANDER", "CHARTA - SANTANDER", "CHIMA - SANTANDER", "CHIPATA - SANTANDER", "CIMITARRA - SANTANDER", "CONCEPCION - SANTANDER", "CONFINES - SANTANDER", "CONTRATACION - SANTANDER", "COROMORO - SANTANDER", "CURITI - SANTANDER", "EL CARMEN DE CHUCURI - SANTANDER", "EL GUACAMAYO - SANTANDER", "EL PEÑON - SANTANDER", "EL PLAYON - SANTANDER", "ENCINO - SANTANDER", "ENCISO - SANTANDER", "FLORIAN - SANTANDER", "FLORIDABLANCA - SANTANDER", "GALAN - SANTANDER", "GAMBITA - SANTANDER", "GIRON - SANTANDER", "GUACA - SANTANDER", "GUADALUPE - SANTANDER", "GUAPOTA - SANTANDER", "GUAVATA - SANTANDER", "GsEPSA - SANTANDER", "HATO - SANTANDER", "JESUS MARIA - SANTANDER", "JORDAN - SANTANDER", "LA BELLEZA - SANTANDER", "LANDAZURI - SANTANDER", "LA PAZ - SANTANDER", "LEBRIJA - SANTANDER", "LOS SANTOS - SANTANDER", "MACARAVITA - SANTANDER", "MALAGA - SANTANDER", "MATANZA - SANTANDER", "MOGOTES - SANTANDER", "MOLAGAVITA - SANTANDER", "OCAMONTE - SANTANDER", "OIBA - SANTANDER", "ONZAGA - SANTANDER", "PALMAR - SANTANDER", "PALMAS DEL SOCORRO - SANTANDER", "PARAMO - SANTANDER", "PIEDECUESTA - SANTANDER", "PINCHOTE - SANTANDER", "PUENTE NACIONAL - SANTANDER", "PUERTO PARRA - SANTANDER", "PUERTO WILCHES - SANTANDER", "RIONEGRO - SANTANDER", "SABANA DE TORRES - SANTANDER", "SAN ANDRES - SANTANDER", "SAN BENITO - SANTANDER", "SAN GIL - SANTANDER", "SAN JOAQUIN - SANTANDER", "SAN JOSE DE MIRANDA - SANTANDER", "SAN MIGUEL - SANTANDER", "SAN VICENTE DE CHUCURI - SANTANDER", "SANTA BARBARA - SANTANDER", "SANTA HELENA DEL OPON - SANTANDER", "SIMACOTA - SANTANDER", "SOCORRO - SANTANDER", "SUAITA - SANTANDER", "SUCRE - SANTANDER", "SURATA - SANTANDER", "TONA - SANTANDER", "VALLE DE SAN JOSE - SANTANDER", "VELEZ - SANTANDER", "VETAS - SANTANDER", "VILLANUEVA - SANTANDER", "ZAPATOCA - SANTANDER", "SINCELEJO - SUCRE", "BUENAVISTA - SUCRE", "CAIMITO - SUCRE", "COLOSO - SUCRE", "COROZAL - SUCRE", "COVEÑAS - SUCRE", "CHALAN - SUCRE", "EL ROBLE - SUCRE", "GALERAS - SUCRE", "GUARANDA - SUCRE", "LA UNION - SUCRE", "LOS PALMITOS - SUCRE", "MAJAGUAL - SUCRE", "MORROA - SUCRE", "OVEJAS - SUCRE", "PALMITO - SUCRE", "SAMPUES - SUCRE", "SAN BENITO ABAD - SUCRE", "SAN JUAN DE BETULIA - SUCRE", "SAN MARCOS - SUCRE", "SAN ONOFRE - SUCRE", "SAN PEDRO - SUCRE", "SAN LUIS DE SINCE - SUCRE", "SUCRE - SUCRE", "SANTIAGO DE TOLU - SUCRE", "TOLU VIEJO - SUCRE", "IBAGUE - TOLIMA", "ALPUJARRA - TOLIMA", "ALVARADO - TOLIMA", "AMBALEMA - TOLIMA", "ANZOATEGUI - TOLIMA", "ARMERO - TOLIMA", "ATACO - TOLIMA", "CAJAMARCA - TOLIMA", "CARMEN DE APICALA - TOLIMA", "CASABIANCA - TOLIMA", "CHAPARRAL - TOLIMA", "COELLO - TOLIMA", "COYAIMA - TOLIMA", "CUNDAY - TOLIMA", "DOLORES - TOLIMA", "ESPINAL - TOLIMA", "FALAN - TOLIMA", "FLANDES - TOLIMA", "FRESNO - TOLIMA", "GUAMO - TOLIMA", "HERVEO - TOLIMA", "HONDA - TOLIMA", "ICONONZO - TOLIMA", "LERIDA - TOLIMA", "LIBANO - TOLIMA", "MARIQUITA - TOLIMA", "MELGAR - TOLIMA", "MURILLO - TOLIMA", "NATAGAIMA - TOLIMA", "ORTEGA - TOLIMA", "PALOCABILDO - TOLIMA", "PIEDRAS - TOLIMA", "PLANADAS - TOLIMA", "PRADO - TOLIMA", "PURIFICACION - TOLIMA", "RIOBLANCO - TOLIMA", "RONCESVALLES - TOLIMA", "ROVIRA - TOLIMA", "SALDAÑA - TOLIMA", "SAN ANTONIO - TOLIMA", "SAN LUIS - TOLIMA", "SANTA ISABEL - TOLIMA", "SUAREZ - TOLIMA", "VALLE DE SAN JUAN - TOLIMA", "VENADILLO - TOLIMA", "VILLAHERMOSA - TOLIMA", "VILLARRICA - TOLIMA", "CALI - VALLE DEL CAUCA", "ALCALA - VALLE DEL CAUCA", "ANDALUCIA - VALLE DEL CAUCA", "ANSERMANUEVO - VALLE DEL CAUCA", "ARGELIA - VALLE DEL CAUCA", "BOLIVAR - VALLE DEL CAUCA", "BUENAVENTURA - VALLE DEL CAUCA", "GUADALAJARA DE BUGA - VALLE DEL CAUCA", "BUGALAGRANDE - VALLE DEL CAUCA", "CAICEDONIA - VALLE DEL CAUCA", "CALIMA - VALLE DEL CAUCA", "CANDELARIA - VALLE DEL CAUCA", "CARTAGO - VALLE DEL CAUCA", "DAGUA - VALLE DEL CAUCA", "EL AGUILA - VALLE DEL CAUCA", "EL CAIRO - VALLE DEL CAUCA", "EL CERRITO - VALLE DEL CAUCA", "EL DOVIO - VALLE DEL CAUCA", "FLORIDA - VALLE DEL CAUCA", "GINEBRA - VALLE DEL CAUCA", "GUACARI - VALLE DEL CAUCA", "JAMUNDI - VALLE DEL CAUCA", "LA CUMBRE - VALLE DEL CAUCA", "LA UNION - VALLE DEL CAUCA", "LA VICTORIA - VALLE DEL CAUCA", "OBANDO - VALLE DEL CAUCA", "PALMIRA - VALLE DEL CAUCA", "PRADERA - VALLE DEL CAUCA", "RESTREPO - VALLE DEL CAUCA", "RIOFRIO - VALLE DEL CAUCA", "ROLDANILLO - VALLE DEL CAUCA", "SAN PEDRO - VALLE DEL CAUCA", "SEVILLA - VALLE DEL CAUCA", "TORO - VALLE DEL CAUCA", "TRUJILLO - VALLE DEL CAUCA", "TULUA - VALLE DEL CAUCA", "ULLOA - VALLE DEL CAUCA", "VERSALLES - VALLE DEL CAUCA", "VIJES - VALLE DEL CAUCA", "YOTOCO - VALLE DEL CAUCA", "YUMBO - VALLE DEL CAUCA", "ZARZAL - VALLE DEL CAUCA", "ARAUCA - ARAUCA", "ARAUQUITA - ARAUCA", "CRAVO NORTE - ARAUCA", "FORTUL - ARAUCA", "PUERTO RONDON - ARAUCA", "SARAVENA - ARAUCA", "TAME - ARAUCA", "YOPAL - CASANARE", "AGUAZUL - CASANARE", "CHAMEZA - CASANARE", "HATO COROZAL - CASANARE", "LA SALINA - CASANARE", "MANI - CASANARE", "MONTERREY - CASANARE", "NUNCHIA - CASANARE", "OROCUE - CASANARE", "PAZ DE ARIPORO - CASANARE", "PORE - CASANARE", "RECETOR - CASANARE", "SABANALARGA - CASANARE", "SACAMA - CASANARE", "SAN LUIS DE PALENQUE - CASANARE", "TAMARA - CASANARE", "TAURAMENA - CASANARE", "TRINIDAD - CASANARE", "VILLANUEVA - CASANARE", "MOCOA - PUTUMAYO", "COLON - PUTUMAYO", "ORITO - PUTUMAYO", "PUERTO ASIS - PUTUMAYO", "PUERTO CAICEDO - PUTUMAYO", "PUERTO GUZMAN - PUTUMAYO", "LEGUIZAMO - PUTUMAYO", "SIBUNDOY - PUTUMAYO", "SAN FRANCISCO - PUTUMAYO", "SAN MIGUEL - PUTUMAYO", "SANTIAGO - PUTUMAYO", "VALLE DEL GUAMUEZ - PUTUMAYO", "VILLAGARZON - PUTUMAYO", "SAN ANDRES - SAN ANDRES", "PROVIDENCIA - SAN ANDRES", "LETICIA - AMAZONAS", "EL ENCANTO - AMAZONAS", "LA CHORRERA - AMAZONAS", "LA PEDRERA - AMAZONAS", "LA VICTORIA - AMAZONAS", "MIRITI - PARANA - AMAZONAS", "PUERTO ALEGRIA - AMAZONAS", "PUERTO ARICA - AMAZONAS", "PUERTO NARIÑO - AMAZONAS", "PUERTO SANTANDER - AMAZONAS", "TARAPACA - AMAZONAS", "INIRIDA - GUAINIA", "BARRANCO MINAS - GUAINIA", "MAPIRIPANA - GUAINIA", "SAN FELIPE - GUAINIA", "PUERTO COLOMBIA - GUAINIA", "LA GUADALUPE - GUAINIA", "CACAHUAL - GUAINIA", "PANA PANA - GUAINIA", "MORICHAL - GUAINIA", "SAN JOSE DEL GUAVIARE - GUAVIARE", "CALAMAR - GUAVIARE", "EL RETORNO - GUAVIARE", "MIRAFLORES - GUAVIARE", "MITU - VAUPES", "CARURU - VAUPES", "PACOA - VAUPES", "TARAIRA - VAUPES", "PAPUNAUA - VAUPES", "YAVARATE - VAUPES", "PUERTO CARREÑO - VICHADA", "LA PRIMAVERA - VICHADA", "SANTA ROSALIA - VICHADA", "CUMARIBO - VICHADA"})
        Me.ComboBox_tipodoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox_tipodoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox_tipodoc.BackColor = System.Drawing.Color.White
        Me.BunifuTransition1.SetDecoration(Me.ComboBox_tipodoc, BunifuAnimatorNS.DecorationType.None)
        Me.ComboBox_tipodoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_tipodoc.ForeColor = System.Drawing.Color.Black
        Me.ComboBox_tipodoc.FormattingEnabled = True
        Me.ComboBox_tipodoc.Items.AddRange(New Object() {"REGISTRO CIVIL DE NACIMIENTO", "CÉDULA DE CIUDADANÍA", "TARJETA DE EXTRANJERÍA", "CÉDULA DE EXTRANJERÍA", "NIT", "PASAPORTE"})
        Me.ComboBox_tipodoc.Location = New System.Drawing.Point(236, 19)
        Me.ComboBox_tipodoc.Name = "ComboBox_tipodoc"
        Me.ComboBox_tipodoc.Size = New System.Drawing.Size(276, 24)
        Me.ComboBox_tipodoc.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(14, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 395
        Me.Label1.Text = "Documento"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_DOC
        '
        Me.TextBox_DOC.BackColor = System.Drawing.Color.Lavender
        Me.BunifuTransition1.SetDecoration(Me.TextBox_DOC, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox_DOC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_DOC.ForeColor = System.Drawing.Color.Black
        Me.TextBox_DOC.Location = New System.Drawing.Point(14, 19)
        Me.TextBox_DOC.MaxLength = 15
        Me.TextBox_DOC.Name = "TextBox_DOC"
        Me.TextBox_DOC.Size = New System.Drawing.Size(151, 24)
        Me.TextBox_DOC.TabIndex = 1
        Me.TextBox_DOC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label17, BunifuAnimatorNS.DecorationType.None)
        Me.Label17.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(170, 19)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(15, 22)
        Me.Label17.TabIndex = 447
        Me.Label17.Text = "-"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_dv
        '
        Me.TextBox_dv.BackColor = System.Drawing.Color.Lavender
        Me.BunifuTransition1.SetDecoration(Me.TextBox_dv, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox_dv.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_dv.ForeColor = System.Drawing.Color.Black
        Me.TextBox_dv.Location = New System.Drawing.Point(189, 19)
        Me.TextBox_dv.MaxLength = 1
        Me.TextBox_dv.Name = "TextBox_dv"
        Me.TextBox_dv.Size = New System.Drawing.Size(27, 24)
        Me.TextBox_dv.TabIndex = 2000
        Me.TextBox_dv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_mail
        '
        Me.Label_mail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label_mail.AutoSize = True
        Me.Label_mail.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label_mail, BunifuAnimatorNS.DecorationType.None)
        Me.Label_mail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_mail.ForeColor = System.Drawing.Color.DimGray
        Me.Label_mail.Location = New System.Drawing.Point(14, 328)
        Me.Label_mail.Name = "Label_mail"
        Me.Label_mail.Size = New System.Drawing.Size(37, 13)
        Me.Label_mail.TabIndex = 403
        Me.Label_mail.Text = "Email"
        Me.Label_mail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label16, BunifuAnimatorNS.DecorationType.None)
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DimGray
        Me.Label16.Location = New System.Drawing.Point(190, 6)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(24, 13)
        Me.Label16.TabIndex = 445
        Me.Label16.Text = "DV"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_MAIL
        '
        Me.TextBox_MAIL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox_MAIL.BackColor = System.Drawing.Color.White
        Me.BunifuTransition1.SetDecoration(Me.TextBox_MAIL, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox_MAIL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_MAIL.ForeColor = System.Drawing.Color.Black
        Me.TextBox_MAIL.Location = New System.Drawing.Point(14, 341)
        Me.TextBox_MAIL.Name = "TextBox_MAIL"
        Me.TextBox_MAIL.Size = New System.Drawing.Size(378, 24)
        Me.TextBox_MAIL.TabIndex = 27
        Me.TextBox_MAIL.Text = "@"
        Me.TextBox_MAIL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(14, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 401
        Me.Label5.Text = "Dirección"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_DOMICILIO
        '
        Me.TextBox_DOMICILIO.BackColor = System.Drawing.Color.White
        Me.BunifuTransition1.SetDecoration(Me.TextBox_DOMICILIO, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox_DOMICILIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_DOMICILIO.ForeColor = System.Drawing.Color.Black
        Me.TextBox_DOMICILIO.Location = New System.Drawing.Point(14, 172)
        Me.TextBox_DOMICILIO.Name = "TextBox_DOMICILIO"
        Me.TextBox_DOMICILIO.Size = New System.Drawing.Size(848, 24)
        Me.TextBox_DOMICILIO.TabIndex = 19
        '
        'TextBox_SITIOWEB
        '
        Me.TextBox_SITIOWEB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox_SITIOWEB.BackColor = System.Drawing.Color.White
        Me.BunifuTransition1.SetDecoration(Me.TextBox_SITIOWEB, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox_SITIOWEB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_SITIOWEB.ForeColor = System.Drawing.Color.Black
        Me.TextBox_SITIOWEB.Location = New System.Drawing.Point(464, 341)
        Me.TextBox_SITIOWEB.Name = "TextBox_SITIOWEB"
        Me.TextBox_SITIOWEB.Size = New System.Drawing.Size(398, 24)
        Me.TextBox_SITIOWEB.TabIndex = 28
        Me.TextBox_SITIOWEB.Text = "http://www."
        Me.TextBox_SITIOWEB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label12, BunifuAnimatorNS.DecorationType.None)
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DimGray
        Me.Label12.Location = New System.Drawing.Point(463, 328)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 13)
        Me.Label12.TabIndex = 442
        Me.Label12.Text = "Sitio Web"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label11, BunifuAnimatorNS.DecorationType.None)
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(369, 264)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 440
        Me.Label11.Text = "Ciudad"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox_CIUDAD
        '
        Me.ComboBox_CIUDAD.AutoCompleteCustomSource.AddRange(New String() {"MEDELLIN - ANTIOQUIA", "ABEJORRAL - ANTIOQUIA", "ABRIAQUI - ANTIOQUIA", "ALEJANDRIA - ANTIOQUIA", "AMAGA - ANTIOQUIA", "AMALFI - ANTIOQUIA", "ANDES - ANTIOQUIA", "ANGELOPOLIS - ANTIOQUIA", "ANGOSTURA - ANTIOQUIA", "ANORI - ANTIOQUIA", "SANTAFE DE ANTIOQUIA - ANTIOQUIA", "ANZA - ANTIOQUIA", "APARTADO - ANTIOQUIA", "ARBOLETES - ANTIOQUIA", "ARGELIA - ANTIOQUIA", "ARMENIA - ANTIOQUIA", "BARBOSA - ANTIOQUIA", "BELMIRA - ANTIOQUIA", "BELLO - ANTIOQUIA", "BETANIA - ANTIOQUIA", "BETULIA - ANTIOQUIA", "CIUDAD BOLIVAR - ANTIOQUIA", "BRICEÑO - ANTIOQUIA", "BURITICA - ANTIOQUIA", "CACERES - ANTIOQUIA", "CAICEDO - ANTIOQUIA", "CALDAS - ANTIOQUIA", "CAMPAMENTO - ANTIOQUIA", "CAÑASGORDAS - ANTIOQUIA", "CARACOLI - ANTIOQUIA", "CARAMANTA - ANTIOQUIA", "CAREPA - ANTIOQUIA", "EL CARMEN DE VIBORAL - ANTIOQUIA", "CAROLINA - ANTIOQUIA", "CAUCASIA - ANTIOQUIA", "CHIGORODO - ANTIOQUIA", "CISNEROS - ANTIOQUIA", "COCORNA - ANTIOQUIA", "CONCEPCION - ANTIOQUIA", "CONCORDIA - ANTIOQUIA", "COPACABANA - ANTIOQUIA", "DABEIBA - ANTIOQUIA", "DON MATIAS - ANTIOQUIA", "EBEJICO - ANTIOQUIA", "EL BAGRE - ANTIOQUIA", "ENTRERRIOS - ANTIOQUIA", "ENVIGADO - ANTIOQUIA", "FREDONIA - ANTIOQUIA", "FRONTINO - ANTIOQUIA", "GIRALDO - ANTIOQUIA", "GIRARDOTA - ANTIOQUIA", "GOMEZ PLATA - ANTIOQUIA", "GRANADA - ANTIOQUIA", "GUADALUPE - ANTIOQUIA", "GUARNE - ANTIOQUIA", "GUATAPE - ANTIOQUIA", "HELICONIA - ANTIOQUIA", "HISPANIA - ANTIOQUIA", "ITAGUI - ANTIOQUIA", "ITUANGO - ANTIOQUIA", "JARDIN - ANTIOQUIA", "JERICO - ANTIOQUIA", "LA CEJA - ANTIOQUIA", "LA ESTRELLA - ANTIOQUIA", "LA PINTADA - ANTIOQUIA", "LA UNION - ANTIOQUIA", "LIBORINA - ANTIOQUIA", "MACEO - ANTIOQUIA", "MARINILLA - ANTIOQUIA", "MONTEBELLO - ANTIOQUIA", "MURINDO - ANTIOQUIA", "MUTATA - ANTIOQUIA", "NARIÑO - ANTIOQUIA", "NECOCLI - ANTIOQUIA", "NECHI - ANTIOQUIA", "OLAYA - ANTIOQUIA", "PEÐOL - ANTIOQUIA", "PEQUE - ANTIOQUIA", "PUEBLORRICO - ANTIOQUIA", "PUERTO BERRIO - ANTIOQUIA", "PUERTO NARE - ANTIOQUIA", "PUERTO TRIUNFO - ANTIOQUIA", "REMEDIOS - ANTIOQUIA", "RETIRO - ANTIOQUIA", "RIONEGRO - ANTIOQUIA", "SABANALARGA - ANTIOQUIA", "SABANETA - ANTIOQUIA", "SALGAR - ANTIOQUIA", "SAN ANDRES DE CUERQUIA - ANTIOQUIA", "SAN CARLOS - ANTIOQUIA", "SAN FRANCISCO - ANTIOQUIA", "SAN JERONIMO - ANTIOQUIA", "SAN JOSE DE LA MONTAÑA - ANTIOQUIA", "SAN JUAN DE URABA - ANTIOQUIA", "SAN LUIS - ANTIOQUIA", "SAN PEDRO - ANTIOQUIA", "SAN PEDRO DE URABA - ANTIOQUIA", "SAN RAFAEL - ANTIOQUIA", "SAN ROQUE - ANTIOQUIA", "SAN VICENTE - ANTIOQUIA", "SANTA BARBARA - ANTIOQUIA", "SANTA ROSA DE OSOS - ANTIOQUIA", "SANTO DOMINGO - ANTIOQUIA", "EL SANTUARIO - ANTIOQUIA", "SEGOVIA - ANTIOQUIA", "SONSON - ANTIOQUIA", "SOPETRAN - ANTIOQUIA", "TAMESIS - ANTIOQUIA", "TARAZA - ANTIOQUIA", "TARSO - ANTIOQUIA", "TITIRIBI - ANTIOQUIA", "TOLEDO - ANTIOQUIA", "TURBO - ANTIOQUIA", "URAMITA - ANTIOQUIA", "URRAO - ANTIOQUIA", "VALDIVIA - ANTIOQUIA", "VALPARAISO - ANTIOQUIA", "VEGACHI - ANTIOQUIA", "VENECIA - ANTIOQUIA", "VIGIA DEL FUERTE - ANTIOQUIA", "YALI - ANTIOQUIA", "YARUMAL - ANTIOQUIA", "YOLOMBO - ANTIOQUIA", "YONDO - ANTIOQUIA", "ZARAGOZA - ANTIOQUIA", "BARRANQUILLA - ATLANTICO", "BARANOA - ATLANTICO", "CAMPO DE LA CRUZ - ATLANTICO", "CANDELARIA - ATLANTICO", "GALAPA - ATLANTICO", "JUAN DE ACOSTA - ATLANTICO", "LURUACO - ATLANTICO", "MALAMBO - ATLANTICO", "MANATI - ATLANTICO", "PALMAR DE VARELA - ATLANTICO", "PIOJO - ATLANTICO", "POLONUEVO - ATLANTICO", "PONEDERA - ATLANTICO", "PUERTO COLOMBIA - ATLANTICO", "REPELON - ATLANTICO", "SABANAGRANDE - ATLANTICO", "SABANALARGA - ATLANTICO", "SANTA LUCIA - ATLANTICO", "SANTO TOMAS - ATLANTICO", "SOLEDAD - ATLANTICO", "SUAN - ATLANTICO", "TUBARA - ATLANTICO", "USIACURI - ATLANTICO", "BOGOTA, D.C. - BOGOTA", "CARTAGENA - BOLIVAR", "ACHI - BOLIVAR", "ALTOS DEL ROSARIO - BOLIVAR", "ARENAL - BOLIVAR", "ARJONA - BOLIVAR", "ARROYOHONDO - BOLIVAR", "BARRANCO DE LOBA - BOLIVAR", "CALAMAR - BOLIVAR", "CANTAGALLO - BOLIVAR", "CICUCO - BOLIVAR", "CORDOBA - BOLIVAR", "CLEMENCIA - BOLIVAR", "EL CARMEN DE BOLIVAR - BOLIVAR", "EL GUAMO - BOLIVAR", "EL PEÑON - BOLIVAR", "HATILLO DE LOBA - BOLIVAR", "MAGANGUE - BOLIVAR", "MAHATES - BOLIVAR", "MARGARITA - BOLIVAR", "MARIA LA BAJA - BOLIVAR", "MONTECRISTO - BOLIVAR", "MOMPOS - BOLIVAR", "NOROSI - BOLIVAR", "MORALES - BOLIVAR", "PINILLOS - BOLIVAR", "REGIDOR - BOLIVAR", "RIO VIEJO - BOLIVAR", "SAN CRISTOBAL - BOLIVAR", "SAN ESTANISLAO - BOLIVAR", "SAN FERNANDO - BOLIVAR", "SAN JACINTO - BOLIVAR", "SAN JACINTO DEL CAUCA - BOLIVAR", "SAN JUAN NEPOMUCENO - BOLIVAR", "SAN MARTIN DE LOBA - BOLIVAR", "SAN PABLO - BOLIVAR", "SANTA CATALINA - BOLIVAR", "SANTA ROSA - BOLIVAR", "SANTA ROSA DEL SUR - BOLIVAR", "SIMITI - BOLIVAR", "SOPLAVIENTO - BOLIVAR", "TALAIGUA NUEVO - BOLIVAR", "TIQUISIO - BOLIVAR", "TURBACO - BOLIVAR", "TURBANA - BOLIVAR", "VILLANUEVA - BOLIVAR", "ZAMBRANO - BOLIVAR", "TUNJA - BOYACA", "ALMEIDA - BOYACA", "AQUITANIA - BOYACA", "ARCABUCO - BOYACA", "BELEN - BOYACA", "BERBEO - BOYACA", "BETEITIVA - BOYACA", "BOAVITA - BOYACA", "BOYACA - BOYACA", "BRICEÑO - BOYACA", "BUENAVISTA - BOYACA", "BUSBANZA - BOYACA", "CALDAS - BOYACA", "CAMPOHERMOSO - BOYACA", "CERINZA - BOYACA", "CHINAVITA - BOYACA", "CHIQUINQUIRA - BOYACA", "CHISCAS - BOYACA", "CHITA - BOYACA", "CHITARAQUE - BOYACA", "CHIVATA - BOYACA", "CIENEGA - BOYACA", "COMBITA - BOYACA", "COPER - BOYACA", "CORRALES - BOYACA", "COVARACHIA - BOYACA", "CUBARA - BOYACA", "CUCAITA - BOYACA", "CUITIVA - BOYACA", "CHIQUIZA - BOYACA", "CHIVOR - BOYACA", "DUITAMA - BOYACA", "EL COCUY - BOYACA", "EL ESPINO - BOYACA", "FIRAVITOBA - BOYACA", "FLORESTA - BOYACA", "GACHANTIVA - BOYACA", "GAMEZA - BOYACA", "GARAGOA - BOYACA", "GUACAMAYAS - BOYACA", "GUATEQUE - BOYACA", "GUAYATA - BOYACA", "GsICAN - BOYACA", "IZA - BOYACA", "JENESANO - BOYACA", "JERICO - BOYACA", "LABRANZAGRANDE - BOYACA", "LA CAPILLA - BOYACA", "LA VICTORIA - BOYACA", "LA UVITA - BOYACA", "VILLA DE LEYVA - BOYACA", "MACANAL - BOYACA", "MARIPI - BOYACA", "MIRAFLORES - BOYACA", "MONGUA - BOYACA", "MONGUI - BOYACA", "MONIQUIRA - BOYACA", "MOTAVITA - BOYACA", "MUZO - BOYACA", "NOBSA - BOYACA", "NUEVO COLON - BOYACA", "OICATA - BOYACA", "OTANCHE - BOYACA", "PACHAVITA - BOYACA", "PAEZ - BOYACA", "PAIPA - BOYACA", "PAJARITO - BOYACA", "PANQUEBA - BOYACA", "PAUNA - BOYACA", "PAYA - BOYACA", "PAZ DE RIO - BOYACA", "PESCA - BOYACA", "PISBA - BOYACA", "PUERTO BOYACA - BOYACA", "QUIPAMA - BOYACA", "RAMIRIQUI - BOYACA", "RAQUIRA - BOYACA", "RONDON - BOYACA", "SABOYA - BOYACA", "SACHICA - BOYACA", "SAMACA - BOYACA", "SAN EDUARDO - BOYACA", "SAN JOSE DE PARE - BOYACA", "SAN LUIS DE GACENO - BOYACA", "SAN MATEO - BOYACA", "SAN MIGUEL DE SEMA - BOYACA", "SAN PABLO DE BORBUR - BOYACA", "SANTANA - BOYACA", "SANTA MARIA - BOYACA", "SANTA ROSA DE VITERBO - BOYACA", "SANTA SOFIA - BOYACA", "SATIVANORTE - BOYACA", "SATIVASUR - BOYACA", "SIACHOQUE - BOYACA", "SOATA - BOYACA", "SOCOTA - BOYACA", "SOCHA - BOYACA", "SOGAMOSO - BOYACA", "SOMONDOCO - BOYACA", "SORA - BOYACA", "SOTAQUIRA - BOYACA", "SORACA - BOYACA", "SUSACON - BOYACA", "SUTAMARCHAN - BOYACA", "SUTATENZA - BOYACA", "TASCO - BOYACA", "TENZA - BOYACA", "TIBANA - BOYACA", "TIBASOSA - BOYACA", "TINJACA - BOYACA", "TIPACOQUE - BOYACA", "TOCA - BOYACA", "TOGsI - BOYACA", "TOPAGA - BOYACA", "TOTA - BOYACA", "TUNUNGUA - BOYACA", "TURMEQUE - BOYACA", "TUTA - BOYACA", "TUTAZA - BOYACA", "UMBITA - BOYACA", "VENTAQUEMADA - BOYACA", "VIRACACHA - BOYACA", "ZETAQUIRA - BOYACA", "MANIZALES - CALDAS", "AGUADAS - CALDAS", "ANSERMA - CALDAS", "ARANZAZU - CALDAS", "BELALCAZAR - CALDAS", "CHINCHINA - CALDAS", "FILADELFIA - CALDAS", "LA DORADA - CALDAS", "LA MERCED - CALDAS", "MANZANARES - CALDAS", "MARMATO - CALDAS", "MARQUETALIA - CALDAS", "MARULANDA - CALDAS", "NEIRA - CALDAS", "NORCASIA - CALDAS", "PACORA - CALDAS", "PALESTINA - CALDAS", "PENSILVANIA - CALDAS", "RIOSUCIO - CALDAS", "RISARALDA - CALDAS", "SALAMINA - CALDAS", "SAMANA - CALDAS", "SAN JOSE - CALDAS", "SUPIA - CALDAS", "VICTORIA - CALDAS", "VILLAMARIA - CALDAS", "VITERBO - CALDAS", "FLORENCIA - CAQUETA", "ALBANIA - CAQUETA", "BELEN DE LOS ANDAQUIES - CAQUETA", "CARTAGENA DEL CHAIRA - CAQUETA", "CURILLO - CAQUETA", "EL DONCELLO - CAQUETA", "EL PAUJIL - CAQUETA", "LA MONTAÑITA - CAQUETA", "MILAN - CAQUETA", "MORELIA - CAQUETA", "PUERTO RICO - CAQUETA", "SAN JOSE DEL FRAGUA - CAQUETA", "SAN VICENTE DEL CAGUAN - CAQUETA", "SOLANO - CAQUETA", "SOLITA - CAQUETA", "VALPARAISO - CAQUETA", "POPAYAN - CAUCA", "ALMAGUER - CAUCA", "ARGELIA - CAUCA", "BALBOA - CAUCA", "BOLIVAR - CAUCA", "BUENOS AIRES - CAUCA", "CAJIBIO - CAUCA", "CALDONO - CAUCA", "CALOTO - CAUCA", "CORINTO - CAUCA", "EL TAMBO - CAUCA", "FLORENCIA - CAUCA", "GUACHENE - CAUCA", "GUAPI - CAUCA", "INZA - CAUCA", "JAMBALO - CAUCA", "LA SIERRA - CAUCA", "LA VEGA - CAUCA", "LOPEZ - CAUCA", "MERCADERES - CAUCA", "MIRANDA - CAUCA", "MORALES - CAUCA", "PADILLA - CAUCA", "PAEZ - CAUCA", "PATIA - CAUCA", "PIAMONTE - CAUCA", "PIENDAMO - CAUCA", "PUERTO TEJADA - CAUCA", "PURACE - CAUCA", "ROSAS - CAUCA", "SAN SEBASTIAN - CAUCA", "SANTANDER DE QUILICHAO - CAUCA", "SANTA ROSA - CAUCA", "SILVIA - CAUCA", "SOTARA - CAUCA", "SUAREZ - CAUCA", "SUCRE - CAUCA", "TIMBIO - CAUCA", "TIMBIQUI - CAUCA", "TORIBIO - CAUCA", "TOTORO - CAUCA", "VILLA RICA - CAUCA", "VALLEDUPAR - CESAR", "AGUACHICA - CESAR", "AGUSTIN CODAZZI - CESAR", "ASTREA - CESAR", "BECERRIL - CESAR", "BOSCONIA - CESAR", "CHIMICHAGUA - CESAR", "CHIRIGUANA - CESAR", "CURUMANI - CESAR", "EL COPEY - CESAR", "EL PASO - CESAR", "GAMARRA - CESAR", "GONZALEZ - CESAR", "LA GLORIA - CESAR", "LA JAGUA DE IBIRICO - CESAR", "MANAURE - CESAR", "PAILITAS - CESAR", "PELAYA - CESAR", "PUEBLO BELLO - CESAR", "RIO DE ORO - CESAR", "LA PAZ - CESAR", "SAN ALBERTO - CESAR", "SAN DIEGO - CESAR", "SAN MARTIN - CESAR", "TAMALAMEQUE - CESAR", "MONTERIA - CORDOBA", "AYAPEL - CORDOBA", "BUENAVISTA - CORDOBA", "CANALETE - CORDOBA", "CERETE - CORDOBA", "CHIMA - CORDOBA", "CHINU - CORDOBA", "CIENAGA DE ORO - CORDOBA", "COTORRA - CORDOBA", "LA APARTADA - CORDOBA", "LORICA - CORDOBA", "LOS CORDOBAS - CORDOBA", "MOMIL - CORDOBA", "MONTELIBANO - CORDOBA", "MOÑITOS - CORDOBA", "PLANETA RICA - CORDOBA", "PUEBLO NUEVO - CORDOBA", "PUERTO ESCONDIDO - CORDOBA", "PUERTO LIBERTADOR - CORDOBA", "PURISIMA - CORDOBA", "SAHAGUN - CORDOBA", "SAN ANDRES SOTAVENTO - CORDOBA", "SAN ANTERO - CORDOBA", "SAN BERNARDO DEL VIENTO - CORDOBA", "SAN CARLOS - CORDOBA", "SAN PELAYO - CORDOBA", "TIERRALTA - CORDOBA", "VALENCIA - CORDOBA", "AGUA DE DIOS - CUNDINAMARCA", "ALBAN - CUNDINAMARCA", "ANAPOIMA - CUNDINAMARCA", "ANOLAIMA - CUNDINAMARCA", "ARBELAEZ - CUNDINAMARCA", "BELTRAN - CUNDINAMARCA", "BITUIMA - CUNDINAMARCA", "BOJACA - CUNDINAMARCA", "CABRERA - CUNDINAMARCA", "CACHIPAY - CUNDINAMARCA", "CAJICA - CUNDINAMARCA", "CAPARRAPI - CUNDINAMARCA", "CAQUEZA - CUNDINAMARCA", "CARMEN DE CARUPA - CUNDINAMARCA", "CHAGUANI - CUNDINAMARCA", "CHIA - CUNDINAMARCA", "CHIPAQUE - CUNDINAMARCA", "CHOACHI - CUNDINAMARCA", "CHOCONTA - CUNDINAMARCA", "COGUA - CUNDINAMARCA", "COTA - CUNDINAMARCA", "CUCUNUBA - CUNDINAMARCA", "EL COLEGIO - CUNDINAMARCA", "EL PEÑON - CUNDINAMARCA", "EL ROSAL - CUNDINAMARCA", "FACATATIVA - CUNDINAMARCA", "FOMEQUE - CUNDINAMARCA", "FOSCA - CUNDINAMARCA", "FUNZA - CUNDINAMARCA", "FUQUENE - CUNDINAMARCA", "FUSAGASUGA - CUNDINAMARCA", "GACHALA - CUNDINAMARCA", "GACHANCIPA - CUNDINAMARCA", "GACHETA - CUNDINAMARCA", "GAMA - CUNDINAMARCA", "GIRARDOT - CUNDINAMARCA", "GRANADA - CUNDINAMARCA", "GUACHETA - CUNDINAMARCA", "GUADUAS - CUNDINAMARCA", "GUASCA - CUNDINAMARCA", "GUATAQUI - CUNDINAMARCA", "GUATAVITA - CUNDINAMARCA", "GUAYABAL DE SIQUIMA - CUNDINAMARCA", "GUAYABETAL - CUNDINAMARCA", "GUTIERREZ - CUNDINAMARCA", "JERUSALEN - CUNDINAMARCA", "JUNIN - CUNDINAMARCA", "LA CALERA - CUNDINAMARCA", "LA MESA - CUNDINAMARCA", "LA PALMA - CUNDINAMARCA", "LA PEÑA - CUNDINAMARCA", "LA VEGA - CUNDINAMARCA", "LENGUAZAQUE - CUNDINAMARCA", "MACHETA - CUNDINAMARCA", "MADRID - CUNDINAMARCA", "MANTA - CUNDINAMARCA", "MEDINA - CUNDINAMARCA", "MOSQUERA - CUNDINAMARCA", "NARIÑO - CUNDINAMARCA", "NEMOCON - CUNDINAMARCA", "NILO - CUNDINAMARCA", "NIMAIMA - CUNDINAMARCA", "NOCAIMA - CUNDINAMARCA", "VENECIA - CUNDINAMARCA", "PACHO - CUNDINAMARCA", "PAIME - CUNDINAMARCA", "PANDI - CUNDINAMARCA", "PARATEBUENO - CUNDINAMARCA", "PASCA - CUNDINAMARCA", "PUERTO SALGAR - CUNDINAMARCA", "PULI - CUNDINAMARCA", "QUEBRADANEGRA - CUNDINAMARCA", "QUETAME - CUNDINAMARCA", "QUIPILE - CUNDINAMARCA", "APULO - CUNDINAMARCA", "RICAURTE - CUNDINAMARCA", "SAN ANTONIO DEL TEQUENDAMA - CUNDINAMARCA", "SAN BERNARDO - CUNDINAMARCA", "SAN CAYETANO - CUNDINAMARCA", "SAN FRANCISCO - CUNDINAMARCA", "SAN JUAN DE RIO SECO - CUNDINAMARCA", "SASAIMA - CUNDINAMARCA", "SESQUILE - CUNDINAMARCA", "SIBATE - CUNDINAMARCA", "SILVANIA - CUNDINAMARCA", "SIMIJACA - CUNDINAMARCA", "SOACHA - CUNDINAMARCA", "SOPO - CUNDINAMARCA", "SUBACHOQUE - CUNDINAMARCA", "SUESCA - CUNDINAMARCA", "SUPATA - CUNDINAMARCA", "SUSA - CUNDINAMARCA", "SUTATAUSA - CUNDINAMARCA", "TABIO - CUNDINAMARCA", "TAUSA - CUNDINAMARCA", "TENA - CUNDINAMARCA", "TENJO - CUNDINAMARCA", "TIBACUY - CUNDINAMARCA", "TIBIRITA - CUNDINAMARCA", "TOCAIMA - CUNDINAMARCA", "TOCANCIPA - CUNDINAMARCA", "TOPAIPI - CUNDINAMARCA", "UBALA - CUNDINAMARCA", "UBAQUE - CUNDINAMARCA", "VILLA DE SAN DIEGO DE UBATE - CUNDINAMARCA", "UNE - CUNDINAMARCA", "UTICA - CUNDINAMARCA", "VERGARA - CUNDINAMARCA", "VIANI - CUNDINAMARCA", "VILLAGOMEZ - CUNDINAMARCA", "VILLAPINZON - CUNDINAMARCA", "VILLETA - CUNDINAMARCA", "VIOTA - CUNDINAMARCA", "YACOPI - CUNDINAMARCA", "ZIPACON - CUNDINAMARCA", "ZIPAQUIRA - CUNDINAMARCA", "QUIBDO - CHOCO", "ACANDI - CHOCO", "ALTO BAUDO - CHOCO", "ATRATO - CHOCO", "BAGADO - CHOCO", "BAHIA SOLANO - CHOCO", "BAJO BAUDO - CHOCO", "BOJAYA - CHOCO", "EL CANTON DEL SAN PABLO - CHOCO", "CARMEN DEL DARIEN - CHOCO", "CERTEGUI - CHOCO", "CONDOTO - CHOCO", "EL CARMEN DE ATRATO - CHOCO", "EL LITORAL DEL SAN JUAN - CHOCO", "ISTMINA - CHOCO", "JURADO - CHOCO", "LLORO - CHOCO", "MEDIO ATRATO - CHOCO", "MEDIO BAUDO - CHOCO", "MEDIO SAN JUAN - CHOCO", "NOVITA - CHOCO", "NUQUI - CHOCO", "RIO IRO - CHOCO", "RIO QUITO - CHOCO", "RIOSUCIO - CHOCO", "SAN JOSE DEL PALMAR - CHOCO", "SIPI - CHOCO", "TADO - CHOCO", "UNGUIA - CHOCO", "UNION PANAMERICANA - CHOCO", "NEIVA - HUILA", "ACEVEDO - HUILA", "AGRADO - HUILA", "AIPE - HUILA", "ALGECIRAS - HUILA", "ALTAMIRA - HUILA", "BARAYA - HUILA", "CAMPOALEGRE - HUILA", "COLOMBIA - HUILA", "ELIAS - HUILA", "GARZON - HUILA", "GIGANTE - HUILA", "GUADALUPE - HUILA", "HOBO - HUILA", "IQUIRA - HUILA", "ISNOS - HUILA", "LA ARGENTINA - HUILA", "LA PLATA - HUILA", "NATAGA - HUILA", "OPORAPA - HUILA", "PAICOL - HUILA", "PALERMO - HUILA", "PALESTINA - HUILA", "PITAL - HUILA", "PITALITO - HUILA", "RIVERA - HUILA", "SALADOBLANCO - HUILA", "SAN AGUSTIN - HUILA", "SANTA MARIA - HUILA", "SUAZA - HUILA", "TARQUI - HUILA", "TESALIA - HUILA", "TELLO - HUILA", "TERUEL - HUILA", "TIMANA - HUILA", "VILLAVIEJA - HUILA", "YAGUARA - HUILA", "RIOHACHA - LA GUAJIRA", "ALBANIA - LA GUAJIRA", "BARRANCAS - LA GUAJIRA", "DIBULLA - LA GUAJIRA", "DISTRACCION - LA GUAJIRA", "EL MOLINO - LA GUAJIRA", "FONSECA - LA GUAJIRA", "HATONUEVO - LA GUAJIRA", "LA JAGUA DEL PILAR - LA GUAJIRA", "MAICAO - LA GUAJIRA", "MANAURE - LA GUAJIRA", "SAN JUAN DEL CESAR - LA GUAJIRA", "URIBIA - LA GUAJIRA", "URUMITA - LA GUAJIRA", "VILLANUEVA - LA GUAJIRA", "SANTA MARTA - MAGDALENA", "ALGARROBO - MAGDALENA", "ARACATACA - MAGDALENA", "ARIGUANI - MAGDALENA", "CERRO SAN ANTONIO - MAGDALENA", "CHIBOLO - MAGDALENA", "CIENAGA - MAGDALENA", "CONCORDIA - MAGDALENA", "EL BANCO - MAGDALENA", "EL PIÑON - MAGDALENA", "EL RETEN - MAGDALENA", "FUNDACION - MAGDALENA", "GUAMAL - MAGDALENA", "NUEVA GRANADA - MAGDALENA", "PEDRAZA - MAGDALENA", "PIJIÑO DEL CARMEN - MAGDALENA", "PIVIJAY - MAGDALENA", "PLATO - MAGDALENA", "PUEBLOVIEJO - MAGDALENA", "REMOLINO - MAGDALENA", "SABANAS DE SAN ANGEL - MAGDALENA", "SALAMINA - MAGDALENA", "SAN SEBASTIAN DE BUENAVISTA - MAGDALENA", "SAN ZENON - MAGDALENA", "SANTA ANA - MAGDALENA", "SANTA BARBARA DE PINTO - MAGDALENA", "SITIONUEVO - MAGDALENA", "TENERIFE - MAGDALENA", "ZAPAYAN - MAGDALENA", "ZONA BANANERA - MAGDALENA", "VILLAVICENCIO - META", "ACACIAS - META", "BARRANCA DE UPIA - META", "CABUYARO - META", "CASTILLA LA NUEVA - META", "CUBARRAL - META", "CUMARAL - META", "EL CALVARIO - META", "EL CASTILLO - META", "EL DORADO - META", "FUENTE DE ORO - META", "GRANADA - META", "GUAMAL - META", "MAPIRIPAN - META", "MESETAS - META", "LA MACARENA - META", "URIBE - META", "LEJANIAS - META", "PUERTO CONCORDIA - META", "PUERTO GAITAN - META", "PUERTO LOPEZ - META", "PUERTO LLERAS - META", "PUERTO RICO - META", "RESTREPO - META", "SAN CARLOS DE GUAROA - META", "SAN JUAN DE ARAMA - META", "SAN JUANITO - META", "SAN MARTIN - META", "VISTAHERMOSA - META", "PASTO - NARIÑO", "ALBAN - NARIÑO", "ALDANA - NARIÑO", "ANCUYA - NARIÑO", "ARBOLEDA - NARIÑO", "BARBACOAS - NARIÑO", "BELEN - NARIÑO", "BUESACO - NARIÑO", "COLON - NARIÑO", "CONSACA - NARIÑO", "CONTADERO - NARIÑO", "CORDOBA - NARIÑO", "CUASPUD - NARIÑO", "CUMBAL - NARIÑO", "CUMBITARA - NARIÑO", "CHACHAGsI - NARIÑO", "EL CHARCO - NARIÑO", "EL PEÑOL - NARIÑO", "EL ROSARIO - NARIÑO", "EL TABLON DE GOMEZ - NARIÑO", "EL TAMBO - NARIÑO", "FUNES - NARIÑO", "GUACHUCAL - NARIÑO", "GUAITARILLA - NARIÑO", "GUALMATAN - NARIÑO", "ILES - NARIÑO", "IMUES - NARIÑO", "IPIALES - NARIÑO", "LA CRUZ - NARIÑO", "LA FLORIDA - NARIÑO", "LA LLANADA - NARIÑO", "LA TOLA - NARIÑO", "LA UNION - NARIÑO", "LEIVA - NARIÑO", "LINARES - NARIÑO", "LOS ANDES - NARIÑO", "MAGsI - NARIÑO", "MALLAMA - NARIÑO", "MOSQUERA - NARIÑO", "NARIÑO - NARIÑO", "OLAYA HERRERA - NARIÑO", "OSPINA - NARIÑO", "FRANCISCO PIZARRO - NARIÑO", "POLICARPA - NARIÑO", "POTOSI - NARIÑO", "PROVIDENCIA - NARIÑO", "PUERRES - NARIÑO", "PUPIALES - NARIÑO", "RICAURTE - NARIÑO", "ROBERTO PAYAN - NARIÑO", "SAMANIEGO - NARIÑO", "SANDONA - NARIÑO", "SAN BERNARDO - NARIÑO", "SAN LORENZO - NARIÑO", "SAN PABLO - NARIÑO", "SAN PEDRO DE CARTAGO - NARIÑO", "SANTA BARBARA - NARIÑO", "SANTACRUZ - NARIÑO", "SAPUYES - NARIÑO", "TAMINANGO - NARIÑO", "TANGUA - NARIÑO", "SAN ANDRES DE TUMACO - NARIÑO", "TUQUERRES - NARIÑO", "YACUANQUER - NARIÑO", "CUCUTA - N. DE SANTANDER", "ABREGO - N. DE SANTANDER", "ARBOLEDAS - N. DE SANTANDER", "BOCHALEMA - N. DE SANTANDER", "BUCARASICA - N. DE SANTANDER", "CACOTA - N. DE SANTANDER", "CACHIRA - N. DE SANTANDER", "CHINACOTA - N. DE SANTANDER", "CHITAGA - N. DE SANTANDER", "CONVENCION - N. DE SANTANDER", "CUCUTILLA - N. DE SANTANDER", "DURANIA - N. DE SANTANDER", "EL CARMEN - N. DE SANTANDER", "EL TARRA - N. DE SANTANDER", "EL ZULIA - N. DE SANTANDER", "GRAMALOTE - N. DE SANTANDER", "HACARI - N. DE SANTANDER", "HERRAN - N. DE SANTANDER", "LABATECA - N. DE SANTANDER", "LA ESPERANZA - N. DE SANTANDER", "LA PLAYA - N. DE SANTANDER", "LOS PATIOS - N. DE SANTANDER", "LOURDES - N. DE SANTANDER", "MUTISCUA - N. DE SANTANDER", "OCAÑA - N. DE SANTANDER", "PAMPLONA - N. DE SANTANDER", "PAMPLONITA - N. DE SANTANDER", "PUERTO SANTANDER - N. DE SANTANDER", "RAGONVALIA - N. DE SANTANDER", "SALAZAR - N. DE SANTANDER", "SAN CALIXTO - N. DE SANTANDER", "SAN CAYETANO - N. DE SANTANDER", "SANTIAGO - N. DE SANTANDER", "SARDINATA - N. DE SANTANDER", "SILOS - N. DE SANTANDER", "TEORAMA - N. DE SANTANDER", "TIBU - N. DE SANTANDER", "TOLEDO - N. DE SANTANDER", "VILLA CARO - N. DE SANTANDER", "VILLA DEL ROSARIO - N. DE SANTANDER", "ARMENIA - QUINDIO", "BUENAVISTA - QUINDIO", "CALARCA - QUINDIO", "CIRCASIA - QUINDIO", "CORDOBA - QUINDIO", "FILANDIA - QUINDIO", "GENOVA - QUINDIO", "LA TEBAIDA - QUINDIO", "MONTENEGRO - QUINDIO", "PIJAO - QUINDIO", "QUIMBAYA - QUINDIO", "SALENTO - QUINDIO", "PEREIRA - RISARALDA", "APIA - RISARALDA", "BALBOA - RISARALDA", "BELEN DE UMBRIA - RISARALDA", "DOSQUEBRADAS - RISARALDA", "GUATICA - RISARALDA", "LA CELIA - RISARALDA", "LA VIRGINIA - RISARALDA", "MARSELLA - RISARALDA", "MISTRATO - RISARALDA", "PUEBLO RICO - RISARALDA", "QUINCHIA - RISARALDA", "SANTA ROSA DE CABAL - RISARALDA", "SANTUARIO - RISARALDA", "BUCARAMANGA - SANTANDER", "AGUADA - SANTANDER", "ALBANIA - SANTANDER", "ARATOCA - SANTANDER", "BARBOSA - SANTANDER", "BARICHARA - SANTANDER", "BARRANCABERMEJA - SANTANDER", "BETULIA - SANTANDER", "BOLIVAR - SANTANDER", "CABRERA - SANTANDER", "CALIFORNIA - SANTANDER", "CAPITANEJO - SANTANDER", "CARCASI - SANTANDER", "CEPITA - SANTANDER", "CERRITO - SANTANDER", "CHARALA - SANTANDER", "CHARTA - SANTANDER", "CHIMA - SANTANDER", "CHIPATA - SANTANDER", "CIMITARRA - SANTANDER", "CONCEPCION - SANTANDER", "CONFINES - SANTANDER", "CONTRATACION - SANTANDER", "COROMORO - SANTANDER", "CURITI - SANTANDER", "EL CARMEN DE CHUCURI - SANTANDER", "EL GUACAMAYO - SANTANDER", "EL PEÑON - SANTANDER", "EL PLAYON - SANTANDER", "ENCINO - SANTANDER", "ENCISO - SANTANDER", "FLORIAN - SANTANDER", "FLORIDABLANCA - SANTANDER", "GALAN - SANTANDER", "GAMBITA - SANTANDER", "GIRON - SANTANDER", "GUACA - SANTANDER", "GUADALUPE - SANTANDER", "GUAPOTA - SANTANDER", "GUAVATA - SANTANDER", "GsEPSA - SANTANDER", "HATO - SANTANDER", "JESUS MARIA - SANTANDER", "JORDAN - SANTANDER", "LA BELLEZA - SANTANDER", "LANDAZURI - SANTANDER", "LA PAZ - SANTANDER", "LEBRIJA - SANTANDER", "LOS SANTOS - SANTANDER", "MACARAVITA - SANTANDER", "MALAGA - SANTANDER", "MATANZA - SANTANDER", "MOGOTES - SANTANDER", "MOLAGAVITA - SANTANDER", "OCAMONTE - SANTANDER", "OIBA - SANTANDER", "ONZAGA - SANTANDER", "PALMAR - SANTANDER", "PALMAS DEL SOCORRO - SANTANDER", "PARAMO - SANTANDER", "PIEDECUESTA - SANTANDER", "PINCHOTE - SANTANDER", "PUENTE NACIONAL - SANTANDER", "PUERTO PARRA - SANTANDER", "PUERTO WILCHES - SANTANDER", "RIONEGRO - SANTANDER", "SABANA DE TORRES - SANTANDER", "SAN ANDRES - SANTANDER", "SAN BENITO - SANTANDER", "SAN GIL - SANTANDER", "SAN JOAQUIN - SANTANDER", "SAN JOSE DE MIRANDA - SANTANDER", "SAN MIGUEL - SANTANDER", "SAN VICENTE DE CHUCURI - SANTANDER", "SANTA BARBARA - SANTANDER", "SANTA HELENA DEL OPON - SANTANDER", "SIMACOTA - SANTANDER", "SOCORRO - SANTANDER", "SUAITA - SANTANDER", "SUCRE - SANTANDER", "SURATA - SANTANDER", "TONA - SANTANDER", "VALLE DE SAN JOSE - SANTANDER", "VELEZ - SANTANDER", "VETAS - SANTANDER", "VILLANUEVA - SANTANDER", "ZAPATOCA - SANTANDER", "SINCELEJO - SUCRE", "BUENAVISTA - SUCRE", "CAIMITO - SUCRE", "COLOSO - SUCRE", "COROZAL - SUCRE", "COVEÑAS - SUCRE", "CHALAN - SUCRE", "EL ROBLE - SUCRE", "GALERAS - SUCRE", "GUARANDA - SUCRE", "LA UNION - SUCRE", "LOS PALMITOS - SUCRE", "MAJAGUAL - SUCRE", "MORROA - SUCRE", "OVEJAS - SUCRE", "PALMITO - SUCRE", "SAMPUES - SUCRE", "SAN BENITO ABAD - SUCRE", "SAN JUAN DE BETULIA - SUCRE", "SAN MARCOS - SUCRE", "SAN ONOFRE - SUCRE", "SAN PEDRO - SUCRE", "SAN LUIS DE SINCE - SUCRE", "SUCRE - SUCRE", "SANTIAGO DE TOLU - SUCRE", "TOLU VIEJO - SUCRE", "IBAGUE - TOLIMA", "ALPUJARRA - TOLIMA", "ALVARADO - TOLIMA", "AMBALEMA - TOLIMA", "ANZOATEGUI - TOLIMA", "ARMERO - TOLIMA", "ATACO - TOLIMA", "CAJAMARCA - TOLIMA", "CARMEN DE APICALA - TOLIMA", "CASABIANCA - TOLIMA", "CHAPARRAL - TOLIMA", "COELLO - TOLIMA", "COYAIMA - TOLIMA", "CUNDAY - TOLIMA", "DOLORES - TOLIMA", "ESPINAL - TOLIMA", "FALAN - TOLIMA", "FLANDES - TOLIMA", "FRESNO - TOLIMA", "GUAMO - TOLIMA", "HERVEO - TOLIMA", "HONDA - TOLIMA", "ICONONZO - TOLIMA", "LERIDA - TOLIMA", "LIBANO - TOLIMA", "MARIQUITA - TOLIMA", "MELGAR - TOLIMA", "MURILLO - TOLIMA", "NATAGAIMA - TOLIMA", "ORTEGA - TOLIMA", "PALOCABILDO - TOLIMA", "PIEDRAS - TOLIMA", "PLANADAS - TOLIMA", "PRADO - TOLIMA", "PURIFICACION - TOLIMA", "RIOBLANCO - TOLIMA", "RONCESVALLES - TOLIMA", "ROVIRA - TOLIMA", "SALDAÑA - TOLIMA", "SAN ANTONIO - TOLIMA", "SAN LUIS - TOLIMA", "SANTA ISABEL - TOLIMA", "SUAREZ - TOLIMA", "VALLE DE SAN JUAN - TOLIMA", "VENADILLO - TOLIMA", "VILLAHERMOSA - TOLIMA", "VILLARRICA - TOLIMA", "CALI - VALLE DEL CAUCA", "ALCALA - VALLE DEL CAUCA", "ANDALUCIA - VALLE DEL CAUCA", "ANSERMANUEVO - VALLE DEL CAUCA", "ARGELIA - VALLE DEL CAUCA", "BOLIVAR - VALLE DEL CAUCA", "BUENAVENTURA - VALLE DEL CAUCA", "GUADALAJARA DE BUGA - VALLE DEL CAUCA", "BUGALAGRANDE - VALLE DEL CAUCA", "CAICEDONIA - VALLE DEL CAUCA", "CALIMA - VALLE DEL CAUCA", "CANDELARIA - VALLE DEL CAUCA", "CARTAGO - VALLE DEL CAUCA", "DAGUA - VALLE DEL CAUCA", "EL AGUILA - VALLE DEL CAUCA", "EL CAIRO - VALLE DEL CAUCA", "EL CERRITO - VALLE DEL CAUCA", "EL DOVIO - VALLE DEL CAUCA", "FLORIDA - VALLE DEL CAUCA", "GINEBRA - VALLE DEL CAUCA", "GUACARI - VALLE DEL CAUCA", "JAMUNDI - VALLE DEL CAUCA", "LA CUMBRE - VALLE DEL CAUCA", "LA UNION - VALLE DEL CAUCA", "LA VICTORIA - VALLE DEL CAUCA", "OBANDO - VALLE DEL CAUCA", "PALMIRA - VALLE DEL CAUCA", "PRADERA - VALLE DEL CAUCA", "RESTREPO - VALLE DEL CAUCA", "RIOFRIO - VALLE DEL CAUCA", "ROLDANILLO - VALLE DEL CAUCA", "SAN PEDRO - VALLE DEL CAUCA", "SEVILLA - VALLE DEL CAUCA", "TORO - VALLE DEL CAUCA", "TRUJILLO - VALLE DEL CAUCA", "TULUA - VALLE DEL CAUCA", "ULLOA - VALLE DEL CAUCA", "VERSALLES - VALLE DEL CAUCA", "VIJES - VALLE DEL CAUCA", "YOTOCO - VALLE DEL CAUCA", "YUMBO - VALLE DEL CAUCA", "ZARZAL - VALLE DEL CAUCA", "ARAUCA - ARAUCA", "ARAUQUITA - ARAUCA", "CRAVO NORTE - ARAUCA", "FORTUL - ARAUCA", "PUERTO RONDON - ARAUCA", "SARAVENA - ARAUCA", "TAME - ARAUCA", "YOPAL - CASANARE", "AGUAZUL - CASANARE", "CHAMEZA - CASANARE", "HATO COROZAL - CASANARE", "LA SALINA - CASANARE", "MANI - CASANARE", "MONTERREY - CASANARE", "NUNCHIA - CASANARE", "OROCUE - CASANARE", "PAZ DE ARIPORO - CASANARE", "PORE - CASANARE", "RECETOR - CASANARE", "SABANALARGA - CASANARE", "SACAMA - CASANARE", "SAN LUIS DE PALENQUE - CASANARE", "TAMARA - CASANARE", "TAURAMENA - CASANARE", "TRINIDAD - CASANARE", "VILLANUEVA - CASANARE", "MOCOA - PUTUMAYO", "COLON - PUTUMAYO", "ORITO - PUTUMAYO", "PUERTO ASIS - PUTUMAYO", "PUERTO CAICEDO - PUTUMAYO", "PUERTO GUZMAN - PUTUMAYO", "LEGUIZAMO - PUTUMAYO", "SIBUNDOY - PUTUMAYO", "SAN FRANCISCO - PUTUMAYO", "SAN MIGUEL - PUTUMAYO", "SANTIAGO - PUTUMAYO", "VALLE DEL GUAMUEZ - PUTUMAYO", "VILLAGARZON - PUTUMAYO", "SAN ANDRES - SAN ANDRES", "PROVIDENCIA - SAN ANDRES", "LETICIA - AMAZONAS", "EL ENCANTO - AMAZONAS", "LA CHORRERA - AMAZONAS", "LA PEDRERA - AMAZONAS", "LA VICTORIA - AMAZONAS", "MIRITI - PARANA - AMAZONAS", "PUERTO ALEGRIA - AMAZONAS", "PUERTO ARICA - AMAZONAS", "PUERTO NARIÑO - AMAZONAS", "PUERTO SANTANDER - AMAZONAS", "TARAPACA - AMAZONAS", "INIRIDA - GUAINIA", "BARRANCO MINAS - GUAINIA", "MAPIRIPANA - GUAINIA", "SAN FELIPE - GUAINIA", "PUERTO COLOMBIA - GUAINIA", "LA GUADALUPE - GUAINIA", "CACAHUAL - GUAINIA", "PANA PANA - GUAINIA", "MORICHAL - GUAINIA", "SAN JOSE DEL GUAVIARE - GUAVIARE", "CALAMAR - GUAVIARE", "EL RETORNO - GUAVIARE", "MIRAFLORES - GUAVIARE", "MITU - VAUPES", "CARURU - VAUPES", "PACOA - VAUPES", "TARAIRA - VAUPES", "PAPUNAUA - VAUPES", "YAVARATE - VAUPES", "PUERTO CARREÑO - VICHADA", "LA PRIMAVERA - VICHADA", "SANTA ROSALIA - VICHADA", "CUMARIBO - VICHADA"})
        Me.ComboBox_CIUDAD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox_CIUDAD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox_CIUDAD.BackColor = System.Drawing.Color.White
        Me.BunifuTransition1.SetDecoration(Me.ComboBox_CIUDAD, BunifuAnimatorNS.DecorationType.None)
        Me.ComboBox_CIUDAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_CIUDAD.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ComboBox_CIUDAD.FormattingEnabled = True
        Me.ComboBox_CIUDAD.ItemHeight = 16
        Me.ComboBox_CIUDAD.Items.AddRange(New Object() {"EL ENCANTO AMAZONAS|91263", "LA CHORRERA AMAZONAS|91405", "LA PEDRERA AMAZONAS|91407", "LA VICTORIA AMAZONAS|91430", "LETICIA AMAZONAS|91001", "MIRITI - PARANA AMAZONAS|91460", "PUERTO ALEGRIA AMAZONAS|91530", "PUERTO ARICA AMAZONAS|91536", "PUERTO NARIÑO AMAZONAS|91540", "PUERTO SANTANDER AMAZONAS|91669", "TARAPACA AMAZONAS|91798", "ABEJORRAL ANTIOQUIA|05002", "ABRIAQUI ANTIOQUIA|05004", "ALEJANDRIA ANTIOQUIA|05021", "AMAGA ANTIOQUIA|05030", "AMALFI ANTIOQUIA|05031", "ANDES ANTIOQUIA|05034", "ANGELOPOLIS ANTIOQUIA|05036", "ANGOSTURA ANTIOQUIA|05038", "ANORI ANTIOQUIA|05040", "ANZA ANTIOQUIA|05044", "APARTADO ANTIOQUIA|05045", "ARBOLETES ANTIOQUIA|05051", "ARGELIA ANTIOQUIA|05055", "ARMENIA ANTIOQUIA|05059", "BARBOSA ANTIOQUIA|05079", "BELLO ANTIOQUIA|05088", "BELMIRA ANTIOQUIA|05086", "BETANIA ANTIOQUIA|05091", "BETULIA ANTIOQUIA|05093", "BRICE?O ANTIOQUIA|05107", "BURITICA ANTIOQUIA|05113", "CA?ASGORDAS ANTIOQUIA|05138", "CACERES ANTIOQUIA|05120", "CAICEDO ANTIOQUIA|05125", "CALDAS ANTIOQUIA|05129", "CAMPAMENTO ANTIOQUIA|05134", "CARACOLI ANTIOQUIA|05142", "CARAMANTA ANTIOQUIA|05145", "CAREPA ANTIOQUIA|05147", "CAROLINA ANTIOQUIA|05150", "CAUCASIA ANTIOQUIA|05154", "CHIGORODO ANTIOQUIA|05172", "CISNEROS ANTIOQUIA|05190", "CIUDAD BOLIVAR ANTIOQUIA|05101", "COCORNA ANTIOQUIA|05197", "CONCEPCION ANTIOQUIA|05206", "CONCORDIA ANTIOQUIA|05209", "COPACABANA ANTIOQUIA|05212", "DABEIBA ANTIOQUIA|05234", "DON MATIAS ANTIOQUIA|05237", "EBEJICO ANTIOQUIA|05240", "EL BAGRE ANTIOQUIA|05250", "EL CARMEN DE VIBORAL ANTIOQUIA|05148", "EL SANTUARIO ANTIOQUIA|05697", "ENTRERRIOS ANTIOQUIA|05264", "ENVIGADO ANTIOQUIA|05266", "FREDONIA ANTIOQUIA|05282", "FRONTINO ANTIOQUIA|05284", "GIRALDO ANTIOQUIA|05306", "GIRARDOTA ANTIOQUIA|05308", "GOMEZ PLATA ANTIOQUIA|05310", "GRANADA ANTIOQUIA|05313", "GUADALUPE ANTIOQUIA|05315", "GUARNE ANTIOQUIA|05318", "GUATAPE ANTIOQUIA|05321", "HELICONIA ANTIOQUIA|05347", "HISPANIA ANTIOQUIA|05353", "ITAGUI ANTIOQUIA|05360", "ITUANGO ANTIOQUIA|05361", "JARDIN ANTIOQUIA|05364", "JERICO ANTIOQUIA|05368", "LA CEJA ANTIOQUIA|05376", "LA ESTRELLA ANTIOQUIA|05380", "LA PINTADA ANTIOQUIA|05390", "LA UNION ANTIOQUIA|05400", "LIBORINA ANTIOQUIA|05411", "MACEO ANTIOQUIA|05425", "MARINILLA ANTIOQUIA|05440", "MEDELLIN ANTIOQUIA|05001", "MONTEBELLO ANTIOQUIA|05467", "MURINDO ANTIOQUIA|05475", "MUTATA ANTIOQUIA|05480", "NARI?O ANTIOQUIA|05483", "NECHI ANTIOQUIA|05495", "NECOCLI ANTIOQUIA|05490", "OLAYA ANTIOQUIA|05501", "PE?OL ANTIOQUIA|05541", "PEQUE ANTIOQUIA|05543", "PUEBLORRICO ANTIOQUIA|05576", "PUERTO BERRIO ANTIOQUIA|05579", "PUERTO NARE ANTIOQUIA|05585", "PUERTO TRIUNFO ANTIOQUIA|05591", "REMEDIOS ANTIOQUIA|05604", "RETIRO ANTIOQUIA|05607", "RIONEGRO ANTIOQUIA|05615", "SABANALARGA ANTIOQUIA|05628", "SABANETA ANTIOQUIA|05631", "SALGAR ANTIOQUIA|05642", "SAN ANDRES DE CUERQUIA ANTIOQUIA|05647", "SAN CARLOS ANTIOQUIA|05649", "SAN FRANCISCO ANTIOQUIA|05652", "SAN JERONIMO ANTIOQUIA|05656", "SAN JOSE DE LA MONTA?A ANTIOQUIA|05658", "SAN JUAN DE URABA ANTIOQUIA|05659", "SAN LUIS ANTIOQUIA|05660", "SAN PEDRO ANTIOQUIA|05664", "SAN PEDRO DE URABA ANTIOQUIA|05665", "SAN RAFAEL ANTIOQUIA|05667", "SAN ROQUE ANTIOQUIA|05670", "SAN VICENTE ANTIOQUIA|05674", "SANTA BARBARA ANTIOQUIA|05679", "SANTA ROSA DE OSOS ANTIOQUIA|05686", "SANTAFE DE ANTIOQUIA ANTIOQUIA|05042", "SANTO DOMINGO ANTIOQUIA|05690", "SEGOVIA ANTIOQUIA|05736", "SONSON ANTIOQUIA|05756", "SOPETRAN ANTIOQUIA|05761", "TAMESIS ANTIOQUIA|05789", "TARAZA ANTIOQUIA|05790", "TARSO ANTIOQUIA|05792", "TITIRIBI ANTIOQUIA|05809", "TOLEDO ANTIOQUIA|05819", "TURBO ANTIOQUIA|05837", "URAMITA ANTIOQUIA|05842", "URRAO ANTIOQUIA|05847", "VALDIVIA ANTIOQUIA|05854", "VALPARAISO ANTIOQUIA|05856", "VEGACHI ANTIOQUIA|05858", "VENECIA ANTIOQUIA|05861", "VIGIA DEL FUERTE ANTIOQUIA|05873", "YALI ANTIOQUIA|05885", "YARUMAL ANTIOQUIA|05887", "YOLOMBO ANTIOQUIA|05890", "YONDO ANTIOQUIA|05893", "ZARAGOZA ANTIOQUIA|05895", "ARAUCA ARAUCA|81001", "ARAUQUITA ARAUCA|81065", "CRAVO NORTE ARAUCA|81220", "FORTUL ARAUCA|81300", "PUERTO RONDON ARAUCA|81591", "SARAVENA ARAUCA|81736", "TAME ARAUCA|81794", "BARANOA ATLANTICO|08078", "BARRANQUILLA ATLANTICO|08001", "CAMPO DE LA CRUZ ATLANTICO|08137", "CANDELARIA ATLANTICO|08141", "GALAPA ATLANTICO|08296", "JUAN DE ACOSTA ATLANTICO|08372", "LURUACO ATLANTICO|08421", "MALAMBO ATLANTICO|08433", "MANATI ATLANTICO|08436", "PALMAR DE VARELA ATLANTICO|08520", "PIOJO ATLANTICO|08549", "POLONUEVO ATLANTICO|08558", "PONEDERA ATLANTICO|08560", "PUERTO COLOMBIA ATLANTICO|08573", "REPELON ATLANTICO|08606", "SABANAGRANDE ATLANTICO|08634", "SABANALARGA ATLANTICO|08638", "SANTA LUCIA ATLANTICO|08675", "SANTO TOMAS ATLANTICO|08685", "SOLEDAD ATLANTICO|08758", "SUAN ATLANTICO|08770", "TUBARA ATLANTICO|08832", "USIACURI ATLANTICO|08849", "BOGOTA BOGOTA|11001", "ACHI BOLIVAR|13006", "ALTOS DEL ROSARIO BOLIVAR|13030", "ARENAL BOLIVAR|13042", "ARJONA BOLIVAR|13052", "ARROYOHONDO BOLIVAR|13062", "BARRANCO DE LOBA BOLIVAR|13074", "CALAMAR BOLIVAR|13140", "CANTAGALLO BOLIVAR|13160", "CARTAGENA BOLIVAR|13001", "CICUCO BOLIVAR|13188", "CLEMENCIA BOLIVAR|13222", "CORDOBA BOLIVAR|13212", "EL CARMEN DE BOLIVAR BOLIVAR|13244", "EL GUAMO BOLIVAR|13248", "EL PE?ON BOLIVAR|13268", "HATILLO DE LOBA BOLIVAR|13300", "MAGANGUE BOLIVAR|13430", "MAHATES BOLIVAR|13433", "MARGARITA BOLIVAR|13440", "MARIA LA BAJA BOLIVAR|13442", "MOMPOS BOLIVAR|13468", "MONTECRISTO BOLIVAR|13458", "MORALES BOLIVAR|13473", "NOROSI BOLIVAR|13490", "PINILLOS BOLIVAR|13549", "REGIDOR BOLIVAR|13580", "RIO VIEJO BOLIVAR|13600", "SAN CRISTOBAL BOLIVAR|13620", "SAN ESTANISLAO BOLIVAR|13647", "SAN FERNANDO BOLIVAR|13650", "SAN JACINTO BOLIVAR|13654", "SAN JACINTO DEL CAUCA BOLIVAR|13655", "SAN JUAN NEPOMUCENO BOLIVAR|13657", "SAN MARTIN DE LOBA BOLIVAR|13667", "SAN PABLO BOLIVAR|13670", "SANTA CATALINA BOLIVAR|13673", "SANTA ROSA BOLIVAR|13683", "SANTA ROSA DEL SUR BOLIVAR|13688", "SIMITI BOLIVAR|13744", "SOPLAVIENTO BOLIVAR|13760", "TALAIGUA NUEVO BOLIVAR|13780", "TIQUISIO BOLIVAR|13810", "TURBACO BOLIVAR|13836", "TURBANA BOLIVAR|13838", "VILLANUEVA BOLIVAR|13873", "ZAMBRANO BOLIVAR|13894", "ALMEIDA BOYACA|15022", "AQUITANIA BOYACA|15047", "ARCABUCO BOYACA|15051", "BELEN BOYACA|15087", "BERBEO BOYACA|15090", "BETEITIVA BOYACA|15092", "BOAVITA BOYACA|15097", "BOYACA BOYACA|15104", "BRICE?O BOYACA|15106", "BUENAVISTA BOYACA|15109", "BUSBANZA BOYACA|15114", "CALDAS BOYACA|15131", "CAMPOHERMOSO BOYACA|15135", "CERINZA BOYACA|15162", "CHINAVITA BOYACA|15172", "CHIQUINQUIRA BOYACA|15176", "CHIQUIZA BOYACA|15232", "CHISCAS BOYACA|15180", "CHITA BOYACA|15183", "CHITARAQUE BOYACA|15185", "CHIVATA BOYACA|15187", "CHIVOR BOYACA|15236", "CIENEGA BOYACA|15189", "COMBITA BOYACA|15204", "COPER BOYACA|15212", "CORRALES BOYACA|15215", "COVARACHIA BOYACA|15218", "CUBARA BOYACA|15223", "CUCAITA BOYACA|15224", "CUITIVA BOYACA|15226", "DUITAMA BOYACA|15238", "EL COCUY BOYACA|15244", "EL ESPINO BOYACA|15248", "FIRAVITOBA BOYACA|15272", "FLORESTA BOYACA|15276", "GACHANTIVA BOYACA|15293", "GAMEZA BOYACA|15296", "GARAGOA BOYACA|15299", "GsICAN BOYACA|15332", "GUACAMAYAS BOYACA|15317", "GUATEQUE BOYACA|15322", "GUAYATA BOYACA|15325", "IZA BOYACA|15362", "JENESANO BOYACA|15367", "JERICO BOYACA|15368", "LA CAPILLA BOYACA|15380", "LA UVITA BOYACA|15403", "LA VICTORIA BOYACA|15401", "LABRANZAGRANDE BOYACA|15377", "MACANAL BOYACA|15425", "MARIPI BOYACA|15442", "MIRAFLORES BOYACA|15455", "MONGUA BOYACA|15464", "MONGUI BOYACA|15466", "MONIQUIRA BOYACA|15469", "MOTAVITA BOYACA|15476", "MUZO BOYACA|15480", "NOBSA BOYACA|15491", "NUEVO COLON BOYACA|15494", "OICATA BOYACA|15500", "OTANCHE BOYACA|15507", "PACHAVITA BOYACA|15511", "PAEZ BOYACA|15514", "PAIPA BOYACA|15516", "PAJARITO BOYACA|15518", "PANQUEBA BOYACA|15522", "PAUNA BOYACA|15531", "PAYA BOYACA|15533", "PAZ DE RIO BOYACA|15537", "PESCA BOYACA|15542", "PISBA BOYACA|15550", "PUERTO BOYACA BOYACA|15572", "QUIPAMA BOYACA|15580", "RAMIRIQUI BOYACA|15599", "RAQUIRA BOYACA|15600", "RONDON BOYACA|15621", "SABOYA BOYACA|15632", "SACHICA BOYACA|15638", "SAMACA BOYACA|15646", "SAN EDUARDO BOYACA|15660", "SAN JOSE DE PARE BOYACA|15664", "SAN LUIS DE GACENO BOYACA|15667", "SAN MATEO BOYACA|15673", "SAN MIGUEL DE SEMA BOYACA|15676", "SAN PABLO DE BORBUR BOYACA|15681", "SANTA MARIA BOYACA|15690", "SANTA ROSA DE VITERBO BOYACA|15693", "SANTA SOFIA BOYACA|15696", "SANTANA BOYACA|15686", "SATIVANORTE BOYACA|15720", "SATIVASUR BOYACA|15723", "SIACHOQUE BOYACA|15740", "SOATA BOYACA|15753", "SOCHA BOYACA|15757", "SOCOTA BOYACA|15755", "SOGAMOSO BOYACA|15759", "SOMONDOCO BOYACA|15761", "SORA BOYACA|15762", "SORACA BOYACA|15764", "SOTAQUIRA BOYACA|15763", "SUSACON BOYACA|15774", "SUTAMARCHAN BOYACA|15776", "SUTATENZA BOYACA|15778", "TASCO BOYACA|15790", "TENZA BOYACA|15798", "TIBANA BOYACA|15804", "TIBASOSA BOYACA|15806", "TINJACA BOYACA|15808", "TIPACOQUE BOYACA|15810", "TOCA BOYACA|15814", "TOGsI BOYACA|15816", "TOPAGA BOYACA|15820", "TOTA BOYACA|15822", "TUNJA BOYACA|15001", "TUNUNGUA BOYACA|15832", "TURMEQUE BOYACA|15835", "TUTA BOYACA|15837", "TUTAZA BOYACA|15839", "UMBITA BOYACA|15842", "VENTAQUEMADA BOYACA|15861", "VILLA DE LEYVA BOYACA|15407", "VIRACACHA BOYACA|15879", "ZETAQUIRA BOYACA|15897", "AGUADAS CALDAS|17013", "ANSERMA CALDAS|17042", "ARANZAZU CALDAS|17050", "BELALCAZAR CALDAS|17088", "CHINCHINA CALDAS|17174", "FILADELFIA CALDAS|17272", "LA DORADA CALDAS|17380", "LA MERCED CALDAS|17388", "MANIZALES CALDAS|17001", "MANZANARES CALDAS|17433", "MARMATO CALDAS|17442", "MARQUETALIA CALDAS|17444", "MARULANDA CALDAS|17446", "NEIRA CALDAS|17486", "NORCASIA CALDAS|17495", "PACORA CALDAS|17513", "PALESTINA CALDAS|17524", "PENSILVANIA CALDAS|17541", "RIOSUCIO CALDAS|17614", "RISARALDA CALDAS|17616", "SALAMINA CALDAS|17653", "SAMANA CALDAS|17662", "SAN JOSE CALDAS|17665", "SUPIA CALDAS|17777", "VICTORIA CALDAS|17867", "VILLAMARIA CALDAS|17873", "VITERBO CALDAS|17877", "ALBANIA CAQUETA|18029", "BELEN DE LOS ANDAQUIES CAQUETA|18094", "CARTAGENA DEL CHAIRA CAQUETA|18150", "CURILLO CAQUETA|18205", "EL DONCELLO CAQUETA|18247", "EL PAUJIL CAQUETA|18256", "FLORENCIA CAQUETA|18001", "LA MONTA?ITA CAQUETA|18410", "MILAN CAQUETA|18460", "MORELIA CAQUETA|18479", "PUERTO RICO CAQUETA|18592", "SAN JOSE DEL FRAGUA CAQUETA|18610", "SAN VICENTE DEL CAGUAN CAQUETA|18753", "SOLANO CAQUETA|18756", "SOLITA CAQUETA|18785", "VALPARAISO CAQUETA|18860", "AGUAZUL CASANARE|85010", "CHAMEZA CASANARE|85015", "HATO COROZAL CASANARE|85125", "LA SALINA CASANARE|85136", "MANI CASANARE|85139", "MONTERREY CASANARE|85162", "NUNCHIA CASANARE|85225", "OROCUE CASANARE|85230", "PAZ DE ARIPORO CASANARE|85250", "PORE CASANARE|85263", "RECETOR CASANARE|85279", "SABANALARGA CASANARE|85300", "SACAMA CASANARE|85315", "SAN LUIS DE PALENQUE CASANARE|85325", "TAMARA CASANARE|85400", "TAURAMENA CASANARE|85410", "TRINIDAD CASANARE|85430", "VILLANUEVA CASANARE|85440", "YOPAL CASANARE|85001", "ALMAGUER CAUCA|19022", "ARGELIA CAUCA|19050", "BALBOA CAUCA|19075", "BOLIVAR CAUCA|19100", "BUENOS AIRES CAUCA|19110", "CAJIBIO CAUCA|19130", "CALDONO CAUCA|19137", "CALOTO CAUCA|19142", "CORINTO CAUCA|19212", "EL TAMBO CAUCA|19256", "FLORENCIA CAUCA|19290", "GUACHENE CAUCA|19300", "GUAPI CAUCA|19318", "INZA CAUCA|19355", "JAMBALO CAUCA|19364", "LA SIERRA CAUCA|19392", "LA VEGA CAUCA|19397", "LOPEZ CAUCA|19418", "MERCADERES CAUCA|19450", "MIRANDA CAUCA|19455", "MORALES CAUCA|19473", "PADILLA CAUCA|19513", "PAEZ CAUCA|19517", "PATIA CAUCA|19532", "PIAMONTE CAUCA|19533", "PIENDAMO CAUCA|19548", "POPAYAN CAUCA|19001", "PUERTO TEJADA CAUCA|19573", "PURACE CAUCA|19585", "ROSAS CAUCA|19622", "SAN SEBASTIAN CAUCA|19693", "SANTA ROSA CAUCA|19701", "SANTANDER DE QUILICHAO CAUCA|19698", "SILVIA CAUCA|19743", "SOTARA CAUCA|19760", "SUAREZ CAUCA|19780", "SUCRE CAUCA|19785", "TIMBIO CAUCA|19807", "TIMBIQUI CAUCA|19809", "TORIBIO CAUCA|19821", "TOTORO CAUCA|19824", "VILLA RICA CAUCA|19845", "AGUACHICA CESAR|20011", "AGUSTIN CODAZZI CESAR|20013", "ASTREA CESAR|20032", "BECERRIL CESAR|20045", "BOSCONIA CESAR|20060", "CHIMICHAGUA CESAR|20175", "CHIRIGUANA CESAR|20178", "CURUMANI CESAR|20228", "EL COPEY CESAR|20238", "EL PASO CESAR|20250", "GAMARRA CESAR|20295", "GONZALEZ CESAR|20310", "LA GLORIA CESAR|20383", "LA JAGUA DE IBIRICO CESAR|20400", "LA PAZ CESAR|20621", "MANAURE CESAR|20443", "PAILITAS CESAR|20517", "PELAYA CESAR|20550", "PUEBLO BELLO CESAR|20570", "RIO DE ORO CESAR|20614", "SAN ALBERTO CESAR|20710", "SAN DIEGO CESAR|20750", "SAN MARTIN CESAR|20770", "TAMALAMEQUE CESAR|20787", "VALLEDUPAR CESAR|20001", "ACANDI CHOCO|27006", "ALTO BAUDO CHOCO|27025", "ATRATO CHOCO|27050", "BAGADO CHOCO|27073", "BAHIA SOLANO CHOCO|27075", "BAJO BAUDO CHOCO|27077", "BOJAYA CHOCO|27099", "CARMEN DEL DARIEN CHOCO|27150", "CERTEGUI CHOCO|27160", "CONDOTO CHOCO|27205", "EL CANTON DEL SAN PABLO CHOCO|27135", "EL CARMEN DE ATRATO CHOCO|27245", "EL LITORAL DEL SAN JUAN CHOCO|27250", "ISTMINA CHOCO|27361", "JURADO CHOCO|27372", "LLORO CHOCO|27413", "MEDIO ATRATO CHOCO|27425", "MEDIO BAUDO CHOCO|27430", "MEDIO SAN JUAN CHOCO|27450", "NOVITA CHOCO|27491", "NUQUI CHOCO|27495", "QUIBDO CHOCO|27001", "RIO IRO CHOCO|27580", "RIO QUITO CHOCO|27600", "RIOSUCIO CHOCO|27615", "SAN JOSE DEL PALMAR CHOCO|27660", "SIPI CHOCO|27745", "TADO CHOCO|27787", "UNGUIA CHOCO|27800", "UNION PANAMERICANA CHOCO|27810", "AYAPEL CORDOBA|23068", "BUENAVISTA CORDOBA|23079", "CANALETE CORDOBA|23090", "CERETE CORDOBA|23162", "CHIMA CORDOBA|23168", "CHINU CORDOBA|23182", "CIENAGA DE ORO CORDOBA|23189", "COTORRA CORDOBA|23300", "LA APARTADA CORDOBA|23350", "LORICA CORDOBA|23417", "LOS CORDOBAS CORDOBA|23419", "MO?ITOS CORDOBA|23500", "MOMIL CORDOBA|23464", "MONTELIBANO CORDOBA|23466", "MONTERIA CORDOBA|23001", "PLANETA RICA CORDOBA|23555", "PUEBLO NUEVO CORDOBA|23570", "PUERTO ESCONDIDO CORDOBA|23574", "PUERTO LIBERTADOR CORDOBA|23580", "PURISIMA CORDOBA|23586", "SAHAGUN CORDOBA|23660", "SAN ANDRES SOTAVENTO CORDOBA|23670", "SAN ANTERO CORDOBA|23672", "SAN BERNARDO DEL VIENTO CORDOBA|23675", "SAN CARLOS CORDOBA|23678", "SAN PELAYO CORDOBA|23686", "TIERRALTA CORDOBA|23807", "VALENCIA CORDOBA|23855", "AGUA DE DIOS CUNDINAMARCA|25001", "ALBAN CUNDINAMARCA|25019", "ANAPOIMA CUNDINAMARCA|25035", "ANOLAIMA CUNDINAMARCA|25040", "APULO CUNDINAMARCA|25599", "ARBELAEZ CUNDINAMARCA|25053", "BELTRAN CUNDINAMARCA|25086", "BITUIMA CUNDINAMARCA|25095", "BOJACA CUNDINAMARCA|25099", "CABRERA CUNDINAMARCA|25120", "CACHIPAY CUNDINAMARCA|25123", "CAJICA CUNDINAMARCA|25126", "CAPARRAPI CUNDINAMARCA|25148", "CAQUEZA CUNDINAMARCA|25151", "CARMEN DE CARUPA CUNDINAMARCA|25154", "CHAGUANI CUNDINAMARCA|25168", "CHIA CUNDINAMARCA|25175", "CHIPAQUE CUNDINAMARCA|25178", "CHOACHI CUNDINAMARCA|25181", "CHOCONTA CUNDINAMARCA|25183", "COGUA CUNDINAMARCA|25200", "COTA CUNDINAMARCA|25214", "CUCUNUBA CUNDINAMARCA|25224", "EL COLEGIO CUNDINAMARCA|25245", "EL PE?ON CUNDINAMARCA|25258", "EL ROSAL CUNDINAMARCA|25260", "FACATATIVA CUNDINAMARCA|25269", "FOMEQUE CUNDINAMARCA|25279", "FOSCA CUNDINAMARCA|25281", "FUNZA CUNDINAMARCA|25286", "FUQUENE CUNDINAMARCA|25288", "FUSAGASUGA CUNDINAMARCA|25290", "GACHALA CUNDINAMARCA|25293", "GACHANCIPA CUNDINAMARCA|25295", "GACHETA CUNDINAMARCA|25297", "GAMA CUNDINAMARCA|25299", "GIRARDOT CUNDINAMARCA|25307", "GRANADA CUNDINAMARCA|25312", "GUACHETA CUNDINAMARCA|25317", "GUADUAS CUNDINAMARCA|25320", "GUASCA CUNDINAMARCA|25322", "GUATAQUI CUNDINAMARCA|25324", "GUATAVITA CUNDINAMARCA|25326", "GUAYABAL DE SIQUIMA CUNDINAMARCA|25328", "GUAYABETAL CUNDINAMARCA|25335", "GUTIERREZ CUNDINAMARCA|25339", "JERUSALEN CUNDINAMARCA|25368", "JUNIN CUNDINAMARCA|25372", "LA CALERA CUNDINAMARCA|25377", "LA MESA CUNDINAMARCA|25386", "LA PALMA CUNDINAMARCA|25394", "LA PE?A CUNDINAMARCA|25398", "LA VEGA CUNDINAMARCA|25402", "LENGUAZAQUE CUNDINAMARCA|25407", "MACHETA CUNDINAMARCA|25426", "MADRID CUNDINAMARCA|25430", "MANTA CUNDINAMARCA|25436", "MEDINA CUNDINAMARCA|25438", "MOSQUERA CUNDINAMARCA|25473", "NARI?O CUNDINAMARCA|25483", "NEMOCON CUNDINAMARCA|25486", "NILO CUNDINAMARCA|25488", "NIMAIMA CUNDINAMARCA|25489", "NOCAIMA CUNDINAMARCA|25491", "PACHO CUNDINAMARCA|25513", "PAIME CUNDINAMARCA|25518", "PANDI CUNDINAMARCA|25524", "PARATEBUENO CUNDINAMARCA|25530", "PASCA CUNDINAMARCA|25535", "PUERTO SALGAR CUNDINAMARCA|25572", "PULI CUNDINAMARCA|25580", "QUEBRADANEGRA CUNDINAMARCA|25592", "QUETAME CUNDINAMARCA|25594", "QUIPILE CUNDINAMARCA|25596", "RICAURTE CUNDINAMARCA|25612", "SAN ANTONIO DEL TEQUENDAMA CUNDINAMARCA|25645", "SAN BERNARDO CUNDINAMARCA|25649", "SAN CAYETANO CUNDINAMARCA|25653", "SAN FRANCISCO CUNDINAMARCA|25658", "SAN JUAN DE RIO SECO CUNDINAMARCA|25662", "SASAIMA CUNDINAMARCA|25718", "SESQUILE CUNDINAMARCA|25736", "SIBATE CUNDINAMARCA|25740", "SILVANIA CUNDINAMARCA|25743", "SIMIJACA CUNDINAMARCA|25745", "SOACHA CUNDINAMARCA|25754", "SOPO CUNDINAMARCA|25758", "SUBACHOQUE CUNDINAMARCA|25769", "SUESCA CUNDINAMARCA|25772", "SUPATA CUNDINAMARCA|25777", "SUSA CUNDINAMARCA|25779", "SUTATAUSA CUNDINAMARCA|25781", "TABIO CUNDINAMARCA|25785", "TAUSA CUNDINAMARCA|25793", "TENA CUNDINAMARCA|25797", "TENJO CUNDINAMARCA|25799", "TIBACUY CUNDINAMARCA|25805", "TIBIRITA CUNDINAMARCA|25807", "TOCAIMA CUNDINAMARCA|25815", "TOCANCIPA CUNDINAMARCA|25817", "TOPAIPI CUNDINAMARCA|25823", "UBALA CUNDINAMARCA|25839", "UBAQUE CUNDINAMARCA|25841", "UNE CUNDINAMARCA|25845", "UTICA CUNDINAMARCA|25851", "VENECIA CUNDINAMARCA|25506", "VERGARA CUNDINAMARCA|25862", "VIANI CUNDINAMARCA|25867", "VILLA DE SAN DIEGO DE UBATE CUNDINAMARCA|25843", "VILLAGOMEZ CUNDINAMARCA|25871", "VILLAPINZON CUNDINAMARCA|25873", "VILLETA CUNDINAMARCA|25875", "VIOTA CUNDINAMARCA|25878", "YACOPI CUNDINAMARCA|25885", "ZIPACON CUNDINAMARCA|25898", "ZIPAQUIRA CUNDINAMARCA|25899", "BARRANCO MINAS GUAINIA|94343", "CACAHUAL GUAINIA|94886", "INIRIDA GUAINIA|94001", "LA GUADALUPE GUAINIA|94885", "MAPIRIPANA GUAINIA|94663", "MORICHAL GUAINIA|94888", "PANA PANA GUAINIA|94887", "PUERTO COLOMBIA GUAINIA|94884", "SAN FELIPE GUAINIA|94883", "CALAMAR GUAVIARE|95015", "EL RETORNO GUAVIARE|95025", "MIRAFLORES GUAVIARE|95200", "SAN JOSE DEL GUAVIARE GUAVIARE|95001", "ACEVEDO HUILA|41006", "AGRADO HUILA|41013", "AIPE HUILA|41016", "ALGECIRAS HUILA|41020", "ALTAMIRA HUILA|41026", "BARAYA HUILA|41078", "CAMPOALEGRE HUILA|41132", "COLOMBIA HUILA|41206", "ELIAS HUILA|41244", "GARZON HUILA|41298", "GIGANTE HUILA|41306", "GUADALUPE HUILA|41319", "HOBO HUILA|41349", "IQUIRA HUILA|41357", "ISNOS HUILA|41359", "LA ARGENTINA HUILA|41378", "LA PLATA HUILA|41396", "NATAGA HUILA|41483", "NEIVA HUILA|41001", "OPORAPA HUILA|41503", "PAICOL HUILA|41518", "PALERMO HUILA|41524", "PALESTINA HUILA|41530", "PITAL HUILA|41548", "PITALITO HUILA|41551", "RIVERA HUILA|41615", "SALADOBLANCO HUILA|41660", "SAN AGUSTIN HUILA|41668", "SANTA MARIA HUILA|41676", "SUAZA HUILA|41770", "TARQUI HUILA|41791", "TELLO HUILA|41799", "TERUEL HUILA|41801", "TESALIA HUILA|41797", "TIMANA HUILA|41807", "VILLAVIEJA HUILA|41872", "YAGUARA HUILA|41885", "ALBANIA LA GUAJIRA|44035", "BARRANCAS LA GUAJIRA|44078", "DIBULLA LA GUAJIRA|44090", "DISTRACCION LA GUAJIRA|44098", "EL MOLINO LA GUAJIRA|44110", "FONSECA LA GUAJIRA|44279", "HATONUEVO LA GUAJIRA|44378", "LA JAGUA DEL PILAR LA GUAJIRA|44420", "MAICAO LA GUAJIRA|44430", "MANAURE LA GUAJIRA|44560", "RIOHACHA LA GUAJIRA|44001", "SAN JUAN DEL CESAR LA GUAJIRA|44650", "URIBIA LA GUAJIRA|44847", "URUMITA LA GUAJIRA|44855", "VILLANUEVA LA GUAJIRA|44874", "ALGARROBO MAGDALENA|47030", "ARACATACA MAGDALENA|47053", "ARIGUANI MAGDALENA|47058", "CERRO SAN ANTONIO MAGDALENA|47161", "CHIBOLO MAGDALENA|47170", "CIENAGA MAGDALENA|47189", "CONCORDIA MAGDALENA|47205", "EL BANCO MAGDALENA|47245", "EL PI?ON MAGDALENA|47258", "EL RETEN MAGDALENA|47268", "FUNDACION MAGDALENA|47288", "GUAMAL MAGDALENA|47318", "NUEVA GRANADA MAGDALENA|47460", "PEDRAZA MAGDALENA|47541", "PIJI?O DEL CARMEN MAGDALENA|47545", "PIVIJAY MAGDALENA|47551", "PLATO MAGDALENA|47555", "PUEBLOVIEJO MAGDALENA|47570", "REMOLINO MAGDALENA|47605", "SABANAS DE SAN ANGEL MAGDALENA|47660", "SALAMINA MAGDALENA|47675", "SAN SEBASTIAN DE BUENAVISTA MAGDALENA|47692", "SAN ZENON MAGDALENA|47703", "SANTA ANA MAGDALENA|47707", "SANTA BARBARA DE PINTO MAGDALENA|47720", "SANTA MARTA MAGDALENA|47001", "SITIONUEVO MAGDALENA|47745", "TENERIFE MAGDALENA|47798", "ZAPAYAN MAGDALENA|47960", "ZONA BANANERA MAGDALENA|47980", "ACACIAS META|50006", "BARRANCA DE UPIA META|50110", "CABUYARO META|50124", "CASTILLA LA NUEVA META|50150", "CUBARRAL META|50223", "CUMARAL META|50226", "EL CALVARIO META|50245", "EL CASTILLO META|50251", "EL DORADO META|50270", "FUENTE DE ORO META|50287", "GRANADA META|50313", "GUAMAL META|50318", "LA MACARENA META|50350", "LEJANIAS META|50400", "MAPIRIPAN META|50325", "MESETAS META|50330", "PUERTO CONCORDIA META|50450", "PUERTO GAITAN META|50568", "PUERTO LLERAS META|50577", "PUERTO LOPEZ META|50573", "PUERTO RICO META|50590", "RESTREPO META|50606", "SAN CARLOS DE GUAROA META|50680", "SAN JUAN DE ARAMA META|50683", "SAN JUANITO META|50686", "SAN MARTIN META|50689", "URIBE META|50370", "VILLAVICENCIO META|50001", "VISTAHERMOSA META|50711", "ABREGO N. DE SANTANDER|54003", "ARBOLEDAS N. DE SANTANDER|54051", "BOCHALEMA N. DE SANTANDER|54099", "BUCARASICA N. DE SANTANDER|54109", "CACHIRA N. DE SANTANDER|54128", "CACOTA N. DE SANTANDER|54125", "CHINACOTA N. DE SANTANDER|54172", "CHITAGA N. DE SANTANDER|54174", "CONVENCION N. DE SANTANDER|54206", "CUCUTA N. DE SANTANDER|54001", "CUCUTILLA N. DE SANTANDER|54223", "DURANIA N. DE SANTANDER|54239", "EL CARMEN N. DE SANTANDER|54245", "EL TARRA N. DE SANTANDER|54250", "EL ZULIA N. DE SANTANDER|54261", "GRAMALOTE N. DE SANTANDER|54313", "HACARI N. DE SANTANDER|54344", "HERRAN N. DE SANTANDER|54347", "LA ESPERANZA N. DE SANTANDER|54385", "LA PLAYA N. DE SANTANDER|54398", "LABATECA N. DE SANTANDER|54377", "LOS PATIOS N. DE SANTANDER|54405", "LOURDES N. DE SANTANDER|54418", "MUTISCUA N. DE SANTANDER|54480", "OCA?A N. DE SANTANDER|54498", "PAMPLONA N. DE SANTANDER|54518", "PAMPLONITA N. DE SANTANDER|54520", "PUERTO SANTANDER N. DE SANTANDER|54553", "RAGONVALIA N. DE SANTANDER|54599", "SALAZAR N. DE SANTANDER|54660", "SAN CALIXTO N. DE SANTANDER|54670", "SAN CAYETANO N. DE SANTANDER|54673", "SANTIAGO N. DE SANTANDER|54680", "SARDINATA N. DE SANTANDER|54720", "SILOS N. DE SANTANDER|54743", "TEORAMA N. DE SANTANDER|54800", "TIBU N. DE SANTANDER|54810", "TOLEDO N. DE SANTANDER|54820", "VILLA CARO N. DE SANTANDER|54871", "VILLA DEL ROSARIO N. DE SANTANDER|54874", "ALBAN NARI?O|52019", "ALDANA NARI?O|52022", "ANCUYA NARI?O|52036", "ARBOLEDA NARI?O|52051", "BARBACOAS NARI?O|52079", "BELEN NARI?O|52083", "BUESACO NARI?O|52110", "CHACHAGsI NARI?O|52240", "COLON NARI?O|52203", "CONSACA NARI?O|52207", "CONTADERO NARI?O|52210", "CORDOBA NARI?O|52215", "CUASPUD NARI?O|52224", "CUMBAL NARI?O|52227", "CUMBITARA NARI?O|52233", "EL CHARCO NARI?O|52250", "EL PE?OL NARI?O|52254", "EL ROSARIO NARI?O|52256", "EL TABLON DE GOMEZ NARI?O|52258", "EL TAMBO NARI?O|52260", "FRANCISCO PIZARRO NARI?O|52520", "FUNES NARI?O|52287", "GUACHUCAL NARI?O|52317", "GUAITARILLA NARI?O|52320", "GUALMATAN NARI?O|52323", "ILES NARI?O|52352", "IMUES NARI?O|52354", "IPIALES NARI?O|52356", "LA CRUZ NARI?O|52378", "LA FLORIDA NARI?O|52381", "LA LLANADA NARI?O|52385", "LA TOLA NARI?O|52390", "LA UNION NARI?O|52399", "LEIVA NARI?O|52405", "LINARES NARI?O|52411", "LOS ANDES NARI?O|52418", "MAGsI NARI?O|52427", "MALLAMA NARI?O|52435", "MOSQUERA NARI?O|52473", "NARI?O NARI?O|52480", "OLAYA HERRERA NARI?O|52490", "OSPINA NARI?O|52506", "PASTO NARI?O|52001", "POLICARPA NARI?O|52540", "POTOSI NARI?O|52560", "PROVIDENCIA NARI?O|52565", "PUERRES NARI?O|52573", "PUPIALES NARI?O|52585", "RICAURTE NARI?O|52612", "ROBERTO PAYAN NARI?O|52621", "SAMANIEGO NARI?O|52678", "SAN ANDRES DE TUMACO NARI?O|52835", "SAN BERNARDO NARI?O|52685", "SAN LORENZO NARI?O|52687", "SAN PABLO NARI?O|52693", "SAN PEDRO DE CARTAGO NARI?O|52694", "SANDONA NARI?O|52683", "SANTA BARBARA NARI?O|52696", "SANTACRUZ NARI?O|52699", "SAPUYES NARI?O|52720", "TAMINANGO NARI?O|52786", "TANGUA NARI?O|52788", "TUQUERRES NARI?O|52838", "YACUANQUER NARI?O|52885", "COLON PUTUMAYO|86219", "LEGUIZAMO PUTUMAYO|86573", "MOCOA PUTUMAYO|86001", "ORITO PUTUMAYO|86320", "PUERTO ASIS PUTUMAYO|86568", "PUERTO CAICEDO PUTUMAYO|86569", "PUERTO GUZMAN PUTUMAYO|86571", "SAN FRANCISCO PUTUMAYO|86755", "SAN MIGUEL PUTUMAYO|86757", "SANTIAGO PUTUMAYO|86760", "SIBUNDOY PUTUMAYO|86749", "VALLE DEL GUAMUEZ PUTUMAYO|86865", "VILLAGARZON PUTUMAYO|86885", "ARMENIA QUINDIO|63001", "BUENAVISTA QUINDIO|63111", "CALARCA QUINDIO|63130", "CIRCASIA QUINDIO|63190", "CORDOBA QUINDIO|63212", "FILANDIA QUINDIO|63272", "GENOVA QUINDIO|63302", "LA TEBAIDA QUINDIO|63401", "MONTENEGRO QUINDIO|63470", "PIJAO QUINDIO|63548", "QUIMBAYA QUINDIO|63594", "SALENTO QUINDIO|63690", "APIA RISARALDA|66045", "BALBOA RISARALDA|66075", "BELEN DE UMBRIA RISARALDA|66088", "DOSQUEBRADAS RISARALDA|66170", "GUATICA RISARALDA|66318", "LA CELIA RISARALDA|66383", "LA VIRGINIA RISARALDA|66400", "MARSELLA RISARALDA|66440", "MISTRATO RISARALDA|66456", "PEREIRA RISARALDA|66001", "PUEBLO RICO RISARALDA|66572", "QUINCHIA RISARALDA|66594", "SANTA ROSA DE CABAL RISARALDA|66682", "SANTUARIO RISARALDA|66687", "PROVIDENCIA SAN ANDRES|88564", "SAN ANDRES SAN ANDRES|88001", "AGUADA SANTANDER|68013", "ALBANIA SANTANDER|68020", "ARATOCA SANTANDER|68051", "BARBOSA SANTANDER|68077", "BARICHARA SANTANDER|68079", "BARRANCABERMEJA SANTANDER|68081", "BETULIA SANTANDER|68092", "BOLIVAR SANTANDER|68101", "BUCARAMANGA SANTANDER|68001", "CABRERA SANTANDER|68121", "CALIFORNIA SANTANDER|68132", "CAPITANEJO SANTANDER|68147", "CARCASI SANTANDER|68152", "CEPITA SANTANDER|68160", "CERRITO SANTANDER|68162", "CHARALA SANTANDER|68167", "CHARTA SANTANDER|68169", "CHIMA SANTANDER|68176", "CHIPATA SANTANDER|68179", "CIMITARRA SANTANDER|68190", "CONCEPCION SANTANDER|68207", "CONFINES SANTANDER|68209", "CONTRATACION SANTANDER|68211", "COROMORO SANTANDER|68217", "CURITI SANTANDER|68229", "EL CARMEN DE CHUCURI SANTANDER|68235", "EL GUACAMAYO SANTANDER|68245", "EL PE?ON SANTANDER|68250", "EL PLAYON SANTANDER|68255", "ENCINO SANTANDER|68264", "ENCISO SANTANDER|68266", "FLORIAN SANTANDER|68271", "FLORIDABLANCA SANTANDER|68276", "GALAN SANTANDER|68296", "GAMBITA SANTANDER|68298", "GIRON SANTANDER|68307", "GsEPSA SANTANDER|68327", "GUACA SANTANDER|68318", "GUADALUPE SANTANDER|68320", "GUAPOTA SANTANDER|68322", "GUAVATA SANTANDER|68324", "HATO SANTANDER|68344", "JESUS MARIA SANTANDER|68368", "JORDAN SANTANDER|68370", "LA BELLEZA SANTANDER|68377", "LA PAZ SANTANDER|68397", "LANDAZURI SANTANDER|68385", "LEBRIJA SANTANDER|68406", "LOS SANTOS SANTANDER|68418", "MACARAVITA SANTANDER|68425", "MALAGA SANTANDER|68432", "MATANZA SANTANDER|68444", "MOGOTES SANTANDER|68464", "MOLAGAVITA SANTANDER|68468", "OCAMONTE SANTANDER|68498", "OIBA SANTANDER|68500", "ONZAGA SANTANDER|68502", "PALMAR SANTANDER|68522", "PALMAS DEL SOCORRO SANTANDER|68524", "PARAMO SANTANDER|68533", "PIEDECUESTA SANTANDER|68547", "PINCHOTE SANTANDER|68549", "PUENTE NACIONAL SANTANDER|68572", "PUERTO PARRA SANTANDER|68573", "PUERTO WILCHES SANTANDER|68575", "RIONEGRO SANTANDER|68615", "SABANA DE TORRES SANTANDER|68655", "SAN ANDRES SANTANDER|68669", "SAN BENITO SANTANDER|68673", "SAN GIL SANTANDER|68679", "SAN JOAQUIN SANTANDER|68682", "SAN JOSE DE MIRANDA SANTANDER|68684", "SAN MIGUEL SANTANDER|68686", "SAN VICENTE DE CHUCURI SANTANDER|68689", "SANTA BARBARA SANTANDER|68705", "SANTA HELENA DEL OPON SANTANDER|68720", "SIMACOTA SANTANDER|68745", "SOCORRO SANTANDER|68755", "SUAITA SANTANDER|68770", "SUCRE SANTANDER|68773", "SURATA SANTANDER|68780", "TONA SANTANDER|68820", "VALLE DE SAN JOSE SANTANDER|68855", "VELEZ SANTANDER|68861", "VETAS SANTANDER|68867", "VILLANUEVA SANTANDER|68872", "ZAPATOCA SANTANDER|68895", "BUENAVISTA SUCRE|70110", "CAIMITO SUCRE|70124", "CHALAN SUCRE|70230", "COLOSO SUCRE|70204", "COROZAL SUCRE|70215", "COVE?AS SUCRE|70221", "EL ROBLE SUCRE|70233", "GALERAS SUCRE|70235", "GUARANDA SUCRE|70265", "LA UNION SUCRE|70400", "LOS PALMITOS SUCRE|70418", "MAJAGUAL SUCRE|70429", "MORROA SUCRE|70473", "OVEJAS SUCRE|70508", "PALMITO SUCRE|70523", "SAMPUES SUCRE|70670", "SAN BENITO ABAD SUCRE|70678", "SAN JUAN DE BETULIA SUCRE|70702", "SAN LUIS DE SINCE SUCRE|70742", "SAN MARCOS SUCRE|70708", "SAN ONOFRE SUCRE|70713", "SAN PEDRO SUCRE|70717", "SANTIAGO DE TOLU SUCRE|70820", "SINCELEJO SUCRE|70001", "SUCRE SUCRE|70771", "TOLU VIEJO SUCRE|70823", "ALPUJARRA TOLIMA|73024", "ALVARADO TOLIMA|73026", "AMBALEMA TOLIMA|73030", "ANZOATEGUI TOLIMA|73043", "ARMERO TOLIMA|73055", "ATACO TOLIMA|73067", "CAJAMARCA TOLIMA|73124", "CARMEN DE APICALA TOLIMA|73148", "CASABIANCA TOLIMA|73152", "CHAPARRAL TOLIMA|73168", "COELLO TOLIMA|73200", "COYAIMA TOLIMA|73217", "CUNDAY TOLIMA|73226", "DOLORES TOLIMA|73236", "ESPINAL TOLIMA|73268", "FALAN TOLIMA|73270", "FLANDES TOLIMA|73275", "FRESNO TOLIMA|73283", "GUAMO TOLIMA|73319", "HERVEO TOLIMA|73347", "HONDA TOLIMA|73349", "IBAGUE TOLIMA|73001", "ICONONZO TOLIMA|73352", "LERIDA TOLIMA|73408", "LIBANO TOLIMA|73411", "MARIQUITA TOLIMA|73443", "MELGAR TOLIMA|73449", "MURILLO TOLIMA|73461", "NATAGAIMA TOLIMA|73483", "ORTEGA TOLIMA|73504", "PALOCABILDO TOLIMA|73520", "PIEDRAS TOLIMA|73547", "PLANADAS TOLIMA|73555", "PRADO TOLIMA|73563", "PURIFICACION TOLIMA|73585", "RIOBLANCO TOLIMA|73616", "RONCESVALLES TOLIMA|73622", "ROVIRA TOLIMA|73624", "SALDA?A TOLIMA|73671", "SAN ANTONIO TOLIMA|73675", "SAN LUIS TOLIMA|73678", "SANTA ISABEL TOLIMA|73686", "SUAREZ TOLIMA|73770", "VALLE DE SAN JUAN TOLIMA|73854", "VENADILLO TOLIMA|73861", "VILLAHERMOSA TOLIMA|73870", "VILLARRICA TOLIMA|73873", "ALCALA VALLE DEL CAUCA|76020", "ANDALUCIA VALLE DEL CAUCA|76036", "ANSERMANUEVO VALLE DEL CAUCA|76041", "ARGELIA VALLE DEL CAUCA|76054", "BOLIVAR VALLE DEL CAUCA|76100", "BUENAVENTURA VALLE DEL CAUCA|76109", "BUGALAGRANDE VALLE DEL CAUCA|76113", "CAICEDONIA VALLE DEL CAUCA|76122", "CALI VALLE DEL CAUCA|76001", "CALIMA VALLE DEL CAUCA|76126", "CANDELARIA VALLE DEL CAUCA|76130", "CARTAGO VALLE DEL CAUCA|76147", "DAGUA VALLE DEL CAUCA|76233", "EL AGUILA VALLE DEL CAUCA|76243", "EL CAIRO VALLE DEL CAUCA|76246", "EL CERRITO VALLE DEL CAUCA|76248", "EL DOVIO VALLE DEL CAUCA|76250", "FLORIDA VALLE DEL CAUCA|76275", "GINEBRA VALLE DEL CAUCA|76306", "GUACARI VALLE DEL CAUCA|76318", "GUADALAJARA DE BUGA VALLE DEL CAUCA|76111", "JAMUNDI VALLE DEL CAUCA|76364", "LA CUMBRE VALLE DEL CAUCA|76377", "LA UNION VALLE DEL CAUCA|76400", "LA VICTORIA VALLE DEL CAUCA|76403", "OBANDO VALLE DEL CAUCA|76497", "PALMIRA VALLE DEL CAUCA|76520", "PRADERA VALLE DEL CAUCA|76563", "RESTREPO VALLE DEL CAUCA|76606", "RIOFRIO VALLE DEL CAUCA|76616", "ROLDANILLO VALLE DEL CAUCA|76622", "SAN PEDRO VALLE DEL CAUCA|76670", "SEVILLA VALLE DEL CAUCA|76736", "TORO VALLE DEL CAUCA|76823", "TRUJILLO VALLE DEL CAUCA|76828", "TULUA VALLE DEL CAUCA|76834", "ULLOA VALLE DEL CAUCA|76845", "VERSALLES VALLE DEL CAUCA|76863", "VIJES VALLE DEL CAUCA|76869", "YOTOCO VALLE DEL CAUCA|76890", "YUMBO VALLE DEL CAUCA|76892", "ZARZAL VALLE DEL CAUCA|76895", "CARURU VAUPES|97161", "MITU VAUPES|97001", "PACOA VAUPES|97511", "PAPUNAUA VAUPES|97777", "TARAIRA VAUPES|97666", "YAVARATE VAUPES|97889", "CUMARIBO VICHADA|99773", "LA PRIMAVERA VICHADA|99524", "PUERTO CARRE?O VICHADA|99001", "SANTA ROSALIA VICHADA|99624"})
        Me.ComboBox_CIUDAD.Location = New System.Drawing.Point(367, 277)
        Me.ComboBox_CIUDAD.Name = "ComboBox_CIUDAD"
        Me.ComboBox_CIUDAD.Size = New System.Drawing.Size(492, 24)
        Me.ComboBox_CIUDAD.TabIndex = 22
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.CheckBox_otro)
        Me.Panel2.Controls.Add(Me.CheckBox_proveedor)
        Me.Panel2.Controls.Add(Me.CheckBox_cliente)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.BunifuTransition1.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.Panel2.Location = New System.Drawing.Point(575, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(284, 43)
        Me.Panel2.TabIndex = 1022
        '
        'CheckBox_otro
        '
        Me.CheckBox_otro.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.CheckBox_otro, BunifuAnimatorNS.DecorationType.None)
        Me.CheckBox_otro.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_otro.Location = New System.Drawing.Point(198, 21)
        Me.CheckBox_otro.Name = "CheckBox_otro"
        Me.CheckBox_otro.Size = New System.Drawing.Size(52, 20)
        Me.CheckBox_otro.TabIndex = 1024
        Me.CheckBox_otro.Text = "Otro"
        Me.CheckBox_otro.UseVisualStyleBackColor = True
        '
        'CheckBox_proveedor
        '
        Me.CheckBox_proveedor.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.CheckBox_proveedor, BunifuAnimatorNS.DecorationType.None)
        Me.CheckBox_proveedor.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_proveedor.Location = New System.Drawing.Point(93, 21)
        Me.CheckBox_proveedor.Name = "CheckBox_proveedor"
        Me.CheckBox_proveedor.Size = New System.Drawing.Size(89, 20)
        Me.CheckBox_proveedor.TabIndex = 1023
        Me.CheckBox_proveedor.Text = "Proveedor"
        Me.CheckBox_proveedor.UseVisualStyleBackColor = True
        '
        'CheckBox_cliente
        '
        Me.CheckBox_cliente.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.CheckBox_cliente, BunifuAnimatorNS.DecorationType.None)
        Me.CheckBox_cliente.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_cliente.Location = New System.Drawing.Point(10, 21)
        Me.CheckBox_cliente.Name = "CheckBox_cliente"
        Me.CheckBox_cliente.Size = New System.Drawing.Size(68, 20)
        Me.CheckBox_cliente.TabIndex = 1022
        Me.CheckBox_cliente.Text = "Cliente"
        Me.CheckBox_cliente.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AllowDrop = True
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label14, BunifuAnimatorNS.DecorationType.None)
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(7, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(115, 15)
        Me.Label14.TabIndex = 657
        Me.Label14.Text = "Tipo de Contacto"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox_APELLIDO2
        '
        Me.TextBox_APELLIDO2.BackColor = System.Drawing.Color.Lavender
        Me.BunifuTransition1.SetDecoration(Me.TextBox_APELLIDO2, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox_APELLIDO2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.TextBox_APELLIDO2.ForeColor = System.Drawing.Color.Black
        Me.TextBox_APELLIDO2.Location = New System.Drawing.Point(674, 62)
        Me.TextBox_APELLIDO2.Name = "TextBox_APELLIDO2"
        Me.TextBox_APELLIDO2.Size = New System.Drawing.Size(187, 21)
        Me.TextBox_APELLIDO2.TabIndex = 12
        '
        'TextBox_NOMBRE1
        '
        Me.TextBox_NOMBRE1.BackColor = System.Drawing.Color.Lavender
        Me.BunifuTransition1.SetDecoration(Me.TextBox_NOMBRE1, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox_NOMBRE1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.TextBox_NOMBRE1.ForeColor = System.Drawing.Color.Black
        Me.TextBox_NOMBRE1.Location = New System.Drawing.Point(19, 62)
        Me.TextBox_NOMBRE1.Name = "TextBox_NOMBRE1"
        Me.TextBox_NOMBRE1.Size = New System.Drawing.Size(181, 21)
        Me.TextBox_NOMBRE1.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(56, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 391
        Me.Label2.Text = "Primer Nombre"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label35, BunifuAnimatorNS.DecorationType.None)
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.DimGray
        Me.Label35.Location = New System.Drawing.Point(493, 48)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(91, 13)
        Me.Label35.TabIndex = 1012
        Me.Label35.Text = "Primer Apellido"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label34, BunifuAnimatorNS.DecorationType.None)
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.DimGray
        Me.Label34.Location = New System.Drawing.Point(274, 48)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(104, 13)
        Me.Label34.TabIndex = 1011
        Me.Label34.Text = "Segundo Nombre"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_APELLIDO1
        '
        Me.TextBox_APELLIDO1.BackColor = System.Drawing.Color.Lavender
        Me.BunifuTransition1.SetDecoration(Me.TextBox_APELLIDO1, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox_APELLIDO1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.TextBox_APELLIDO1.ForeColor = System.Drawing.Color.Black
        Me.TextBox_APELLIDO1.Location = New System.Drawing.Point(455, 62)
        Me.TextBox_APELLIDO1.Name = "TextBox_APELLIDO1"
        Me.TextBox_APELLIDO1.Size = New System.Drawing.Size(187, 21)
        Me.TextBox_APELLIDO1.TabIndex = 11
        '
        'TextBox_NOMBRE2
        '
        Me.TextBox_NOMBRE2.BackColor = System.Drawing.Color.Lavender
        Me.BunifuTransition1.SetDecoration(Me.TextBox_NOMBRE2, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox_NOMBRE2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.TextBox_NOMBRE2.ForeColor = System.Drawing.Color.Black
        Me.TextBox_NOMBRE2.Location = New System.Drawing.Point(236, 62)
        Me.TextBox_NOMBRE2.Name = "TextBox_NOMBRE2"
        Me.TextBox_NOMBRE2.Size = New System.Drawing.Size(183, 21)
        Me.TextBox_NOMBRE2.TabIndex = 10
        '
        'TextBox_cupoCredito
        '
        Me.TextBox_cupoCredito.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox_cupoCredito.BackColor = System.Drawing.Color.White
        Me.BunifuTransition1.SetDecoration(Me.TextBox_cupoCredito, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox_cupoCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_cupoCredito.ForeColor = System.Drawing.Color.Black
        Me.TextBox_cupoCredito.Location = New System.Drawing.Point(354, 273)
        Me.TextBox_cupoCredito.Name = "TextBox_cupoCredito"
        Me.TextBox_cupoCredito.Size = New System.Drawing.Size(169, 24)
        Me.TextBox_cupoCredito.TabIndex = 32
        Me.TextBox_cupoCredito.Text = "0"
        Me.TextBox_cupoCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label27
        '
        Me.Label27.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label27, BunifuAnimatorNS.DecorationType.None)
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.DimGray
        Me.Label27.Location = New System.Drawing.Point(353, 260)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(98, 13)
        Me.Label27.TabIndex = 1029
        Me.Label27.Text = "Cupo de Crédito"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label25, BunifuAnimatorNS.DecorationType.None)
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.DimGray
        Me.Label25.Location = New System.Drawing.Point(17, 259)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(147, 13)
        Me.Label25.TabIndex = 1027
        Me.Label25.Text = "Medio de Pago Preferido"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox_medioPAgo
        '
        Me.ComboBox_medioPAgo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_medioPAgo.AutoCompleteCustomSource.AddRange(New String() {"MEDELLIN - ANTIOQUIA", "ABEJORRAL - ANTIOQUIA", "ABRIAQUI - ANTIOQUIA", "ALEJANDRIA - ANTIOQUIA", "AMAGA - ANTIOQUIA", "AMALFI - ANTIOQUIA", "ANDES - ANTIOQUIA", "ANGELOPOLIS - ANTIOQUIA", "ANGOSTURA - ANTIOQUIA", "ANORI - ANTIOQUIA", "SANTAFE DE ANTIOQUIA - ANTIOQUIA", "ANZA - ANTIOQUIA", "APARTADO - ANTIOQUIA", "ARBOLETES - ANTIOQUIA", "ARGELIA - ANTIOQUIA", "ARMENIA - ANTIOQUIA", "BARBOSA - ANTIOQUIA", "BELMIRA - ANTIOQUIA", "BELLO - ANTIOQUIA", "BETANIA - ANTIOQUIA", "BETULIA - ANTIOQUIA", "CIUDAD BOLIVAR - ANTIOQUIA", "BRICEÑO - ANTIOQUIA", "BURITICA - ANTIOQUIA", "CACERES - ANTIOQUIA", "CAICEDO - ANTIOQUIA", "CALDAS - ANTIOQUIA", "CAMPAMENTO - ANTIOQUIA", "CAÑASGORDAS - ANTIOQUIA", "CARACOLI - ANTIOQUIA", "CARAMANTA - ANTIOQUIA", "CAREPA - ANTIOQUIA", "EL CARMEN DE VIBORAL - ANTIOQUIA", "CAROLINA - ANTIOQUIA", "CAUCASIA - ANTIOQUIA", "CHIGORODO - ANTIOQUIA", "CISNEROS - ANTIOQUIA", "COCORNA - ANTIOQUIA", "CONCEPCION - ANTIOQUIA", "CONCORDIA - ANTIOQUIA", "COPACABANA - ANTIOQUIA", "DABEIBA - ANTIOQUIA", "DON MATIAS - ANTIOQUIA", "EBEJICO - ANTIOQUIA", "EL BAGRE - ANTIOQUIA", "ENTRERRIOS - ANTIOQUIA", "ENVIGADO - ANTIOQUIA", "FREDONIA - ANTIOQUIA", "FRONTINO - ANTIOQUIA", "GIRALDO - ANTIOQUIA", "GIRARDOTA - ANTIOQUIA", "GOMEZ PLATA - ANTIOQUIA", "GRANADA - ANTIOQUIA", "GUADALUPE - ANTIOQUIA", "GUARNE - ANTIOQUIA", "GUATAPE - ANTIOQUIA", "HELICONIA - ANTIOQUIA", "HISPANIA - ANTIOQUIA", "ITAGUI - ANTIOQUIA", "ITUANGO - ANTIOQUIA", "JARDIN - ANTIOQUIA", "JERICO - ANTIOQUIA", "LA CEJA - ANTIOQUIA", "LA ESTRELLA - ANTIOQUIA", "LA PINTADA - ANTIOQUIA", "LA UNION - ANTIOQUIA", "LIBORINA - ANTIOQUIA", "MACEO - ANTIOQUIA", "MARINILLA - ANTIOQUIA", "MONTEBELLO - ANTIOQUIA", "MURINDO - ANTIOQUIA", "MUTATA - ANTIOQUIA", "NARIÑO - ANTIOQUIA", "NECOCLI - ANTIOQUIA", "NECHI - ANTIOQUIA", "OLAYA - ANTIOQUIA", "PEÐOL - ANTIOQUIA", "PEQUE - ANTIOQUIA", "PUEBLORRICO - ANTIOQUIA", "PUERTO BERRIO - ANTIOQUIA", "PUERTO NARE - ANTIOQUIA", "PUERTO TRIUNFO - ANTIOQUIA", "REMEDIOS - ANTIOQUIA", "RETIRO - ANTIOQUIA", "RIONEGRO - ANTIOQUIA", "SABANALARGA - ANTIOQUIA", "SABANETA - ANTIOQUIA", "SALGAR - ANTIOQUIA", "SAN ANDRES DE CUERQUIA - ANTIOQUIA", "SAN CARLOS - ANTIOQUIA", "SAN FRANCISCO - ANTIOQUIA", "SAN JERONIMO - ANTIOQUIA", "SAN JOSE DE LA MONTAÑA - ANTIOQUIA", "SAN JUAN DE URABA - ANTIOQUIA", "SAN LUIS - ANTIOQUIA", "SAN PEDRO - ANTIOQUIA", "SAN PEDRO DE URABA - ANTIOQUIA", "SAN RAFAEL - ANTIOQUIA", "SAN ROQUE - ANTIOQUIA", "SAN VICENTE - ANTIOQUIA", "SANTA BARBARA - ANTIOQUIA", "SANTA ROSA DE OSOS - ANTIOQUIA", "SANTO DOMINGO - ANTIOQUIA", "EL SANTUARIO - ANTIOQUIA", "SEGOVIA - ANTIOQUIA", "SONSON - ANTIOQUIA", "SOPETRAN - ANTIOQUIA", "TAMESIS - ANTIOQUIA", "TARAZA - ANTIOQUIA", "TARSO - ANTIOQUIA", "TITIRIBI - ANTIOQUIA", "TOLEDO - ANTIOQUIA", "TURBO - ANTIOQUIA", "URAMITA - ANTIOQUIA", "URRAO - ANTIOQUIA", "VALDIVIA - ANTIOQUIA", "VALPARAISO - ANTIOQUIA", "VEGACHI - ANTIOQUIA", "VENECIA - ANTIOQUIA", "VIGIA DEL FUERTE - ANTIOQUIA", "YALI - ANTIOQUIA", "YARUMAL - ANTIOQUIA", "YOLOMBO - ANTIOQUIA", "YONDO - ANTIOQUIA", "ZARAGOZA - ANTIOQUIA", "BARRANQUILLA - ATLANTICO", "BARANOA - ATLANTICO", "CAMPO DE LA CRUZ - ATLANTICO", "CANDELARIA - ATLANTICO", "GALAPA - ATLANTICO", "JUAN DE ACOSTA - ATLANTICO", "LURUACO - ATLANTICO", "MALAMBO - ATLANTICO", "MANATI - ATLANTICO", "PALMAR DE VARELA - ATLANTICO", "PIOJO - ATLANTICO", "POLONUEVO - ATLANTICO", "PONEDERA - ATLANTICO", "PUERTO COLOMBIA - ATLANTICO", "REPELON - ATLANTICO", "SABANAGRANDE - ATLANTICO", "SABANALARGA - ATLANTICO", "SANTA LUCIA - ATLANTICO", "SANTO TOMAS - ATLANTICO", "SOLEDAD - ATLANTICO", "SUAN - ATLANTICO", "TUBARA - ATLANTICO", "USIACURI - ATLANTICO", "BOGOTA, D.C. - BOGOTA", "CARTAGENA - BOLIVAR", "ACHI - BOLIVAR", "ALTOS DEL ROSARIO - BOLIVAR", "ARENAL - BOLIVAR", "ARJONA - BOLIVAR", "ARROYOHONDO - BOLIVAR", "BARRANCO DE LOBA - BOLIVAR", "CALAMAR - BOLIVAR", "CANTAGALLO - BOLIVAR", "CICUCO - BOLIVAR", "CORDOBA - BOLIVAR", "CLEMENCIA - BOLIVAR", "EL CARMEN DE BOLIVAR - BOLIVAR", "EL GUAMO - BOLIVAR", "EL PEÑON - BOLIVAR", "HATILLO DE LOBA - BOLIVAR", "MAGANGUE - BOLIVAR", "MAHATES - BOLIVAR", "MARGARITA - BOLIVAR", "MARIA LA BAJA - BOLIVAR", "MONTECRISTO - BOLIVAR", "MOMPOS - BOLIVAR", "NOROSI - BOLIVAR", "MORALES - BOLIVAR", "PINILLOS - BOLIVAR", "REGIDOR - BOLIVAR", "RIO VIEJO - BOLIVAR", "SAN CRISTOBAL - BOLIVAR", "SAN ESTANISLAO - BOLIVAR", "SAN FERNANDO - BOLIVAR", "SAN JACINTO - BOLIVAR", "SAN JACINTO DEL CAUCA - BOLIVAR", "SAN JUAN NEPOMUCENO - BOLIVAR", "SAN MARTIN DE LOBA - BOLIVAR", "SAN PABLO - BOLIVAR", "SANTA CATALINA - BOLIVAR", "SANTA ROSA - BOLIVAR", "SANTA ROSA DEL SUR - BOLIVAR", "SIMITI - BOLIVAR", "SOPLAVIENTO - BOLIVAR", "TALAIGUA NUEVO - BOLIVAR", "TIQUISIO - BOLIVAR", "TURBACO - BOLIVAR", "TURBANA - BOLIVAR", "VILLANUEVA - BOLIVAR", "ZAMBRANO - BOLIVAR", "TUNJA - BOYACA", "ALMEIDA - BOYACA", "AQUITANIA - BOYACA", "ARCABUCO - BOYACA", "BELEN - BOYACA", "BERBEO - BOYACA", "BETEITIVA - BOYACA", "BOAVITA - BOYACA", "BOYACA - BOYACA", "BRICEÑO - BOYACA", "BUENAVISTA - BOYACA", "BUSBANZA - BOYACA", "CALDAS - BOYACA", "CAMPOHERMOSO - BOYACA", "CERINZA - BOYACA", "CHINAVITA - BOYACA", "CHIQUINQUIRA - BOYACA", "CHISCAS - BOYACA", "CHITA - BOYACA", "CHITARAQUE - BOYACA", "CHIVATA - BOYACA", "CIENEGA - BOYACA", "COMBITA - BOYACA", "COPER - BOYACA", "CORRALES - BOYACA", "COVARACHIA - BOYACA", "CUBARA - BOYACA", "CUCAITA - BOYACA", "CUITIVA - BOYACA", "CHIQUIZA - BOYACA", "CHIVOR - BOYACA", "DUITAMA - BOYACA", "EL COCUY - BOYACA", "EL ESPINO - BOYACA", "FIRAVITOBA - BOYACA", "FLORESTA - BOYACA", "GACHANTIVA - BOYACA", "GAMEZA - BOYACA", "GARAGOA - BOYACA", "GUACAMAYAS - BOYACA", "GUATEQUE - BOYACA", "GUAYATA - BOYACA", "GsICAN - BOYACA", "IZA - BOYACA", "JENESANO - BOYACA", "JERICO - BOYACA", "LABRANZAGRANDE - BOYACA", "LA CAPILLA - BOYACA", "LA VICTORIA - BOYACA", "LA UVITA - BOYACA", "VILLA DE LEYVA - BOYACA", "MACANAL - BOYACA", "MARIPI - BOYACA", "MIRAFLORES - BOYACA", "MONGUA - BOYACA", "MONGUI - BOYACA", "MONIQUIRA - BOYACA", "MOTAVITA - BOYACA", "MUZO - BOYACA", "NOBSA - BOYACA", "NUEVO COLON - BOYACA", "OICATA - BOYACA", "OTANCHE - BOYACA", "PACHAVITA - BOYACA", "PAEZ - BOYACA", "PAIPA - BOYACA", "PAJARITO - BOYACA", "PANQUEBA - BOYACA", "PAUNA - BOYACA", "PAYA - BOYACA", "PAZ DE RIO - BOYACA", "PESCA - BOYACA", "PISBA - BOYACA", "PUERTO BOYACA - BOYACA", "QUIPAMA - BOYACA", "RAMIRIQUI - BOYACA", "RAQUIRA - BOYACA", "RONDON - BOYACA", "SABOYA - BOYACA", "SACHICA - BOYACA", "SAMACA - BOYACA", "SAN EDUARDO - BOYACA", "SAN JOSE DE PARE - BOYACA", "SAN LUIS DE GACENO - BOYACA", "SAN MATEO - BOYACA", "SAN MIGUEL DE SEMA - BOYACA", "SAN PABLO DE BORBUR - BOYACA", "SANTANA - BOYACA", "SANTA MARIA - BOYACA", "SANTA ROSA DE VITERBO - BOYACA", "SANTA SOFIA - BOYACA", "SATIVANORTE - BOYACA", "SATIVASUR - BOYACA", "SIACHOQUE - BOYACA", "SOATA - BOYACA", "SOCOTA - BOYACA", "SOCHA - BOYACA", "SOGAMOSO - BOYACA", "SOMONDOCO - BOYACA", "SORA - BOYACA", "SOTAQUIRA - BOYACA", "SORACA - BOYACA", "SUSACON - BOYACA", "SUTAMARCHAN - BOYACA", "SUTATENZA - BOYACA", "TASCO - BOYACA", "TENZA - BOYACA", "TIBANA - BOYACA", "TIBASOSA - BOYACA", "TINJACA - BOYACA", "TIPACOQUE - BOYACA", "TOCA - BOYACA", "TOGsI - BOYACA", "TOPAGA - BOYACA", "TOTA - BOYACA", "TUNUNGUA - BOYACA", "TURMEQUE - BOYACA", "TUTA - BOYACA", "TUTAZA - BOYACA", "UMBITA - BOYACA", "VENTAQUEMADA - BOYACA", "VIRACACHA - BOYACA", "ZETAQUIRA - BOYACA", "MANIZALES - CALDAS", "AGUADAS - CALDAS", "ANSERMA - CALDAS", "ARANZAZU - CALDAS", "BELALCAZAR - CALDAS", "CHINCHINA - CALDAS", "FILADELFIA - CALDAS", "LA DORADA - CALDAS", "LA MERCED - CALDAS", "MANZANARES - CALDAS", "MARMATO - CALDAS", "MARQUETALIA - CALDAS", "MARULANDA - CALDAS", "NEIRA - CALDAS", "NORCASIA - CALDAS", "PACORA - CALDAS", "PALESTINA - CALDAS", "PENSILVANIA - CALDAS", "RIOSUCIO - CALDAS", "RISARALDA - CALDAS", "SALAMINA - CALDAS", "SAMANA - CALDAS", "SAN JOSE - CALDAS", "SUPIA - CALDAS", "VICTORIA - CALDAS", "VILLAMARIA - CALDAS", "VITERBO - CALDAS", "FLORENCIA - CAQUETA", "ALBANIA - CAQUETA", "BELEN DE LOS ANDAQUIES - CAQUETA", "CARTAGENA DEL CHAIRA - CAQUETA", "CURILLO - CAQUETA", "EL DONCELLO - CAQUETA", "EL PAUJIL - CAQUETA", "LA MONTAÑITA - CAQUETA", "MILAN - CAQUETA", "MORELIA - CAQUETA", "PUERTO RICO - CAQUETA", "SAN JOSE DEL FRAGUA - CAQUETA", "SAN VICENTE DEL CAGUAN - CAQUETA", "SOLANO - CAQUETA", "SOLITA - CAQUETA", "VALPARAISO - CAQUETA", "POPAYAN - CAUCA", "ALMAGUER - CAUCA", "ARGELIA - CAUCA", "BALBOA - CAUCA", "BOLIVAR - CAUCA", "BUENOS AIRES - CAUCA", "CAJIBIO - CAUCA", "CALDONO - CAUCA", "CALOTO - CAUCA", "CORINTO - CAUCA", "EL TAMBO - CAUCA", "FLORENCIA - CAUCA", "GUACHENE - CAUCA", "GUAPI - CAUCA", "INZA - CAUCA", "JAMBALO - CAUCA", "LA SIERRA - CAUCA", "LA VEGA - CAUCA", "LOPEZ - CAUCA", "MERCADERES - CAUCA", "MIRANDA - CAUCA", "MORALES - CAUCA", "PADILLA - CAUCA", "PAEZ - CAUCA", "PATIA - CAUCA", "PIAMONTE - CAUCA", "PIENDAMO - CAUCA", "PUERTO TEJADA - CAUCA", "PURACE - CAUCA", "ROSAS - CAUCA", "SAN SEBASTIAN - CAUCA", "SANTANDER DE QUILICHAO - CAUCA", "SANTA ROSA - CAUCA", "SILVIA - CAUCA", "SOTARA - CAUCA", "SUAREZ - CAUCA", "SUCRE - CAUCA", "TIMBIO - CAUCA", "TIMBIQUI - CAUCA", "TORIBIO - CAUCA", "TOTORO - CAUCA", "VILLA RICA - CAUCA", "VALLEDUPAR - CESAR", "AGUACHICA - CESAR", "AGUSTIN CODAZZI - CESAR", "ASTREA - CESAR", "BECERRIL - CESAR", "BOSCONIA - CESAR", "CHIMICHAGUA - CESAR", "CHIRIGUANA - CESAR", "CURUMANI - CESAR", "EL COPEY - CESAR", "EL PASO - CESAR", "GAMARRA - CESAR", "GONZALEZ - CESAR", "LA GLORIA - CESAR", "LA JAGUA DE IBIRICO - CESAR", "MANAURE - CESAR", "PAILITAS - CESAR", "PELAYA - CESAR", "PUEBLO BELLO - CESAR", "RIO DE ORO - CESAR", "LA PAZ - CESAR", "SAN ALBERTO - CESAR", "SAN DIEGO - CESAR", "SAN MARTIN - CESAR", "TAMALAMEQUE - CESAR", "MONTERIA - CORDOBA", "AYAPEL - CORDOBA", "BUENAVISTA - CORDOBA", "CANALETE - CORDOBA", "CERETE - CORDOBA", "CHIMA - CORDOBA", "CHINU - CORDOBA", "CIENAGA DE ORO - CORDOBA", "COTORRA - CORDOBA", "LA APARTADA - CORDOBA", "LORICA - CORDOBA", "LOS CORDOBAS - CORDOBA", "MOMIL - CORDOBA", "MONTELIBANO - CORDOBA", "MOÑITOS - CORDOBA", "PLANETA RICA - CORDOBA", "PUEBLO NUEVO - CORDOBA", "PUERTO ESCONDIDO - CORDOBA", "PUERTO LIBERTADOR - CORDOBA", "PURISIMA - CORDOBA", "SAHAGUN - CORDOBA", "SAN ANDRES SOTAVENTO - CORDOBA", "SAN ANTERO - CORDOBA", "SAN BERNARDO DEL VIENTO - CORDOBA", "SAN CARLOS - CORDOBA", "SAN PELAYO - CORDOBA", "TIERRALTA - CORDOBA", "VALENCIA - CORDOBA", "AGUA DE DIOS - CUNDINAMARCA", "ALBAN - CUNDINAMARCA", "ANAPOIMA - CUNDINAMARCA", "ANOLAIMA - CUNDINAMARCA", "ARBELAEZ - CUNDINAMARCA", "BELTRAN - CUNDINAMARCA", "BITUIMA - CUNDINAMARCA", "BOJACA - CUNDINAMARCA", "CABRERA - CUNDINAMARCA", "CACHIPAY - CUNDINAMARCA", "CAJICA - CUNDINAMARCA", "CAPARRAPI - CUNDINAMARCA", "CAQUEZA - CUNDINAMARCA", "CARMEN DE CARUPA - CUNDINAMARCA", "CHAGUANI - CUNDINAMARCA", "CHIA - CUNDINAMARCA", "CHIPAQUE - CUNDINAMARCA", "CHOACHI - CUNDINAMARCA", "CHOCONTA - CUNDINAMARCA", "COGUA - CUNDINAMARCA", "COTA - CUNDINAMARCA", "CUCUNUBA - CUNDINAMARCA", "EL COLEGIO - CUNDINAMARCA", "EL PEÑON - CUNDINAMARCA", "EL ROSAL - CUNDINAMARCA", "FACATATIVA - CUNDINAMARCA", "FOMEQUE - CUNDINAMARCA", "FOSCA - CUNDINAMARCA", "FUNZA - CUNDINAMARCA", "FUQUENE - CUNDINAMARCA", "FUSAGASUGA - CUNDINAMARCA", "GACHALA - CUNDINAMARCA", "GACHANCIPA - CUNDINAMARCA", "GACHETA - CUNDINAMARCA", "GAMA - CUNDINAMARCA", "GIRARDOT - CUNDINAMARCA", "GRANADA - CUNDINAMARCA", "GUACHETA - CUNDINAMARCA", "GUADUAS - CUNDINAMARCA", "GUASCA - CUNDINAMARCA", "GUATAQUI - CUNDINAMARCA", "GUATAVITA - CUNDINAMARCA", "GUAYABAL DE SIQUIMA - CUNDINAMARCA", "GUAYABETAL - CUNDINAMARCA", "GUTIERREZ - CUNDINAMARCA", "JERUSALEN - CUNDINAMARCA", "JUNIN - CUNDINAMARCA", "LA CALERA - CUNDINAMARCA", "LA MESA - CUNDINAMARCA", "LA PALMA - CUNDINAMARCA", "LA PEÑA - CUNDINAMARCA", "LA VEGA - CUNDINAMARCA", "LENGUAZAQUE - CUNDINAMARCA", "MACHETA - CUNDINAMARCA", "MADRID - CUNDINAMARCA", "MANTA - CUNDINAMARCA", "MEDINA - CUNDINAMARCA", "MOSQUERA - CUNDINAMARCA", "NARIÑO - CUNDINAMARCA", "NEMOCON - CUNDINAMARCA", "NILO - CUNDINAMARCA", "NIMAIMA - CUNDINAMARCA", "NOCAIMA - CUNDINAMARCA", "VENECIA - CUNDINAMARCA", "PACHO - CUNDINAMARCA", "PAIME - CUNDINAMARCA", "PANDI - CUNDINAMARCA", "PARATEBUENO - CUNDINAMARCA", "PASCA - CUNDINAMARCA", "PUERTO SALGAR - CUNDINAMARCA", "PULI - CUNDINAMARCA", "QUEBRADANEGRA - CUNDINAMARCA", "QUETAME - CUNDINAMARCA", "QUIPILE - CUNDINAMARCA", "APULO - CUNDINAMARCA", "RICAURTE - CUNDINAMARCA", "SAN ANTONIO DEL TEQUENDAMA - CUNDINAMARCA", "SAN BERNARDO - CUNDINAMARCA", "SAN CAYETANO - CUNDINAMARCA", "SAN FRANCISCO - CUNDINAMARCA", "SAN JUAN DE RIO SECO - CUNDINAMARCA", "SASAIMA - CUNDINAMARCA", "SESQUILE - CUNDINAMARCA", "SIBATE - CUNDINAMARCA", "SILVANIA - CUNDINAMARCA", "SIMIJACA - CUNDINAMARCA", "SOACHA - CUNDINAMARCA", "SOPO - CUNDINAMARCA", "SUBACHOQUE - CUNDINAMARCA", "SUESCA - CUNDINAMARCA", "SUPATA - CUNDINAMARCA", "SUSA - CUNDINAMARCA", "SUTATAUSA - CUNDINAMARCA", "TABIO - CUNDINAMARCA", "TAUSA - CUNDINAMARCA", "TENA - CUNDINAMARCA", "TENJO - CUNDINAMARCA", "TIBACUY - CUNDINAMARCA", "TIBIRITA - CUNDINAMARCA", "TOCAIMA - CUNDINAMARCA", "TOCANCIPA - CUNDINAMARCA", "TOPAIPI - CUNDINAMARCA", "UBALA - CUNDINAMARCA", "UBAQUE - CUNDINAMARCA", "VILLA DE SAN DIEGO DE UBATE - CUNDINAMARCA", "UNE - CUNDINAMARCA", "UTICA - CUNDINAMARCA", "VERGARA - CUNDINAMARCA", "VIANI - CUNDINAMARCA", "VILLAGOMEZ - CUNDINAMARCA", "VILLAPINZON - CUNDINAMARCA", "VILLETA - CUNDINAMARCA", "VIOTA - CUNDINAMARCA", "YACOPI - CUNDINAMARCA", "ZIPACON - CUNDINAMARCA", "ZIPAQUIRA - CUNDINAMARCA", "QUIBDO - CHOCO", "ACANDI - CHOCO", "ALTO BAUDO - CHOCO", "ATRATO - CHOCO", "BAGADO - CHOCO", "BAHIA SOLANO - CHOCO", "BAJO BAUDO - CHOCO", "BOJAYA - CHOCO", "EL CANTON DEL SAN PABLO - CHOCO", "CARMEN DEL DARIEN - CHOCO", "CERTEGUI - CHOCO", "CONDOTO - CHOCO", "EL CARMEN DE ATRATO - CHOCO", "EL LITORAL DEL SAN JUAN - CHOCO", "ISTMINA - CHOCO", "JURADO - CHOCO", "LLORO - CHOCO", "MEDIO ATRATO - CHOCO", "MEDIO BAUDO - CHOCO", "MEDIO SAN JUAN - CHOCO", "NOVITA - CHOCO", "NUQUI - CHOCO", "RIO IRO - CHOCO", "RIO QUITO - CHOCO", "RIOSUCIO - CHOCO", "SAN JOSE DEL PALMAR - CHOCO", "SIPI - CHOCO", "TADO - CHOCO", "UNGUIA - CHOCO", "UNION PANAMERICANA - CHOCO", "NEIVA - HUILA", "ACEVEDO - HUILA", "AGRADO - HUILA", "AIPE - HUILA", "ALGECIRAS - HUILA", "ALTAMIRA - HUILA", "BARAYA - HUILA", "CAMPOALEGRE - HUILA", "COLOMBIA - HUILA", "ELIAS - HUILA", "GARZON - HUILA", "GIGANTE - HUILA", "GUADALUPE - HUILA", "HOBO - HUILA", "IQUIRA - HUILA", "ISNOS - HUILA", "LA ARGENTINA - HUILA", "LA PLATA - HUILA", "NATAGA - HUILA", "OPORAPA - HUILA", "PAICOL - HUILA", "PALERMO - HUILA", "PALESTINA - HUILA", "PITAL - HUILA", "PITALITO - HUILA", "RIVERA - HUILA", "SALADOBLANCO - HUILA", "SAN AGUSTIN - HUILA", "SANTA MARIA - HUILA", "SUAZA - HUILA", "TARQUI - HUILA", "TESALIA - HUILA", "TELLO - HUILA", "TERUEL - HUILA", "TIMANA - HUILA", "VILLAVIEJA - HUILA", "YAGUARA - HUILA", "RIOHACHA - LA GUAJIRA", "ALBANIA - LA GUAJIRA", "BARRANCAS - LA GUAJIRA", "DIBULLA - LA GUAJIRA", "DISTRACCION - LA GUAJIRA", "EL MOLINO - LA GUAJIRA", "FONSECA - LA GUAJIRA", "HATONUEVO - LA GUAJIRA", "LA JAGUA DEL PILAR - LA GUAJIRA", "MAICAO - LA GUAJIRA", "MANAURE - LA GUAJIRA", "SAN JUAN DEL CESAR - LA GUAJIRA", "URIBIA - LA GUAJIRA", "URUMITA - LA GUAJIRA", "VILLANUEVA - LA GUAJIRA", "SANTA MARTA - MAGDALENA", "ALGARROBO - MAGDALENA", "ARACATACA - MAGDALENA", "ARIGUANI - MAGDALENA", "CERRO SAN ANTONIO - MAGDALENA", "CHIBOLO - MAGDALENA", "CIENAGA - MAGDALENA", "CONCORDIA - MAGDALENA", "EL BANCO - MAGDALENA", "EL PIÑON - MAGDALENA", "EL RETEN - MAGDALENA", "FUNDACION - MAGDALENA", "GUAMAL - MAGDALENA", "NUEVA GRANADA - MAGDALENA", "PEDRAZA - MAGDALENA", "PIJIÑO DEL CARMEN - MAGDALENA", "PIVIJAY - MAGDALENA", "PLATO - MAGDALENA", "PUEBLOVIEJO - MAGDALENA", "REMOLINO - MAGDALENA", "SABANAS DE SAN ANGEL - MAGDALENA", "SALAMINA - MAGDALENA", "SAN SEBASTIAN DE BUENAVISTA - MAGDALENA", "SAN ZENON - MAGDALENA", "SANTA ANA - MAGDALENA", "SANTA BARBARA DE PINTO - MAGDALENA", "SITIONUEVO - MAGDALENA", "TENERIFE - MAGDALENA", "ZAPAYAN - MAGDALENA", "ZONA BANANERA - MAGDALENA", "VILLAVICENCIO - META", "ACACIAS - META", "BARRANCA DE UPIA - META", "CABUYARO - META", "CASTILLA LA NUEVA - META", "CUBARRAL - META", "CUMARAL - META", "EL CALVARIO - META", "EL CASTILLO - META", "EL DORADO - META", "FUENTE DE ORO - META", "GRANADA - META", "GUAMAL - META", "MAPIRIPAN - META", "MESETAS - META", "LA MACARENA - META", "URIBE - META", "LEJANIAS - META", "PUERTO CONCORDIA - META", "PUERTO GAITAN - META", "PUERTO LOPEZ - META", "PUERTO LLERAS - META", "PUERTO RICO - META", "RESTREPO - META", "SAN CARLOS DE GUAROA - META", "SAN JUAN DE ARAMA - META", "SAN JUANITO - META", "SAN MARTIN - META", "VISTAHERMOSA - META", "PASTO - NARIÑO", "ALBAN - NARIÑO", "ALDANA - NARIÑO", "ANCUYA - NARIÑO", "ARBOLEDA - NARIÑO", "BARBACOAS - NARIÑO", "BELEN - NARIÑO", "BUESACO - NARIÑO", "COLON - NARIÑO", "CONSACA - NARIÑO", "CONTADERO - NARIÑO", "CORDOBA - NARIÑO", "CUASPUD - NARIÑO", "CUMBAL - NARIÑO", "CUMBITARA - NARIÑO", "CHACHAGsI - NARIÑO", "EL CHARCO - NARIÑO", "EL PEÑOL - NARIÑO", "EL ROSARIO - NARIÑO", "EL TABLON DE GOMEZ - NARIÑO", "EL TAMBO - NARIÑO", "FUNES - NARIÑO", "GUACHUCAL - NARIÑO", "GUAITARILLA - NARIÑO", "GUALMATAN - NARIÑO", "ILES - NARIÑO", "IMUES - NARIÑO", "IPIALES - NARIÑO", "LA CRUZ - NARIÑO", "LA FLORIDA - NARIÑO", "LA LLANADA - NARIÑO", "LA TOLA - NARIÑO", "LA UNION - NARIÑO", "LEIVA - NARIÑO", "LINARES - NARIÑO", "LOS ANDES - NARIÑO", "MAGsI - NARIÑO", "MALLAMA - NARIÑO", "MOSQUERA - NARIÑO", "NARIÑO - NARIÑO", "OLAYA HERRERA - NARIÑO", "OSPINA - NARIÑO", "FRANCISCO PIZARRO - NARIÑO", "POLICARPA - NARIÑO", "POTOSI - NARIÑO", "PROVIDENCIA - NARIÑO", "PUERRES - NARIÑO", "PUPIALES - NARIÑO", "RICAURTE - NARIÑO", "ROBERTO PAYAN - NARIÑO", "SAMANIEGO - NARIÑO", "SANDONA - NARIÑO", "SAN BERNARDO - NARIÑO", "SAN LORENZO - NARIÑO", "SAN PABLO - NARIÑO", "SAN PEDRO DE CARTAGO - NARIÑO", "SANTA BARBARA - NARIÑO", "SANTACRUZ - NARIÑO", "SAPUYES - NARIÑO", "TAMINANGO - NARIÑO", "TANGUA - NARIÑO", "SAN ANDRES DE TUMACO - NARIÑO", "TUQUERRES - NARIÑO", "YACUANQUER - NARIÑO", "CUCUTA - N. DE SANTANDER", "ABREGO - N. DE SANTANDER", "ARBOLEDAS - N. DE SANTANDER", "BOCHALEMA - N. DE SANTANDER", "BUCARASICA - N. DE SANTANDER", "CACOTA - N. DE SANTANDER", "CACHIRA - N. DE SANTANDER", "CHINACOTA - N. DE SANTANDER", "CHITAGA - N. DE SANTANDER", "CONVENCION - N. DE SANTANDER", "CUCUTILLA - N. DE SANTANDER", "DURANIA - N. DE SANTANDER", "EL CARMEN - N. DE SANTANDER", "EL TARRA - N. DE SANTANDER", "EL ZULIA - N. DE SANTANDER", "GRAMALOTE - N. DE SANTANDER", "HACARI - N. DE SANTANDER", "HERRAN - N. DE SANTANDER", "LABATECA - N. DE SANTANDER", "LA ESPERANZA - N. DE SANTANDER", "LA PLAYA - N. DE SANTANDER", "LOS PATIOS - N. DE SANTANDER", "LOURDES - N. DE SANTANDER", "MUTISCUA - N. DE SANTANDER", "OCAÑA - N. DE SANTANDER", "PAMPLONA - N. DE SANTANDER", "PAMPLONITA - N. DE SANTANDER", "PUERTO SANTANDER - N. DE SANTANDER", "RAGONVALIA - N. DE SANTANDER", "SALAZAR - N. DE SANTANDER", "SAN CALIXTO - N. DE SANTANDER", "SAN CAYETANO - N. DE SANTANDER", "SANTIAGO - N. DE SANTANDER", "SARDINATA - N. DE SANTANDER", "SILOS - N. DE SANTANDER", "TEORAMA - N. DE SANTANDER", "TIBU - N. DE SANTANDER", "TOLEDO - N. DE SANTANDER", "VILLA CARO - N. DE SANTANDER", "VILLA DEL ROSARIO - N. DE SANTANDER", "ARMENIA - QUINDIO", "BUENAVISTA - QUINDIO", "CALARCA - QUINDIO", "CIRCASIA - QUINDIO", "CORDOBA - QUINDIO", "FILANDIA - QUINDIO", "GENOVA - QUINDIO", "LA TEBAIDA - QUINDIO", "MONTENEGRO - QUINDIO", "PIJAO - QUINDIO", "QUIMBAYA - QUINDIO", "SALENTO - QUINDIO", "PEREIRA - RISARALDA", "APIA - RISARALDA", "BALBOA - RISARALDA", "BELEN DE UMBRIA - RISARALDA", "DOSQUEBRADAS - RISARALDA", "GUATICA - RISARALDA", "LA CELIA - RISARALDA", "LA VIRGINIA - RISARALDA", "MARSELLA - RISARALDA", "MISTRATO - RISARALDA", "PUEBLO RICO - RISARALDA", "QUINCHIA - RISARALDA", "SANTA ROSA DE CABAL - RISARALDA", "SANTUARIO - RISARALDA", "BUCARAMANGA - SANTANDER", "AGUADA - SANTANDER", "ALBANIA - SANTANDER", "ARATOCA - SANTANDER", "BARBOSA - SANTANDER", "BARICHARA - SANTANDER", "BARRANCABERMEJA - SANTANDER", "BETULIA - SANTANDER", "BOLIVAR - SANTANDER", "CABRERA - SANTANDER", "CALIFORNIA - SANTANDER", "CAPITANEJO - SANTANDER", "CARCASI - SANTANDER", "CEPITA - SANTANDER", "CERRITO - SANTANDER", "CHARALA - SANTANDER", "CHARTA - SANTANDER", "CHIMA - SANTANDER", "CHIPATA - SANTANDER", "CIMITARRA - SANTANDER", "CONCEPCION - SANTANDER", "CONFINES - SANTANDER", "CONTRATACION - SANTANDER", "COROMORO - SANTANDER", "CURITI - SANTANDER", "EL CARMEN DE CHUCURI - SANTANDER", "EL GUACAMAYO - SANTANDER", "EL PEÑON - SANTANDER", "EL PLAYON - SANTANDER", "ENCINO - SANTANDER", "ENCISO - SANTANDER", "FLORIAN - SANTANDER", "FLORIDABLANCA - SANTANDER", "GALAN - SANTANDER", "GAMBITA - SANTANDER", "GIRON - SANTANDER", "GUACA - SANTANDER", "GUADALUPE - SANTANDER", "GUAPOTA - SANTANDER", "GUAVATA - SANTANDER", "GsEPSA - SANTANDER", "HATO - SANTANDER", "JESUS MARIA - SANTANDER", "JORDAN - SANTANDER", "LA BELLEZA - SANTANDER", "LANDAZURI - SANTANDER", "LA PAZ - SANTANDER", "LEBRIJA - SANTANDER", "LOS SANTOS - SANTANDER", "MACARAVITA - SANTANDER", "MALAGA - SANTANDER", "MATANZA - SANTANDER", "MOGOTES - SANTANDER", "MOLAGAVITA - SANTANDER", "OCAMONTE - SANTANDER", "OIBA - SANTANDER", "ONZAGA - SANTANDER", "PALMAR - SANTANDER", "PALMAS DEL SOCORRO - SANTANDER", "PARAMO - SANTANDER", "PIEDECUESTA - SANTANDER", "PINCHOTE - SANTANDER", "PUENTE NACIONAL - SANTANDER", "PUERTO PARRA - SANTANDER", "PUERTO WILCHES - SANTANDER", "RIONEGRO - SANTANDER", "SABANA DE TORRES - SANTANDER", "SAN ANDRES - SANTANDER", "SAN BENITO - SANTANDER", "SAN GIL - SANTANDER", "SAN JOAQUIN - SANTANDER", "SAN JOSE DE MIRANDA - SANTANDER", "SAN MIGUEL - SANTANDER", "SAN VICENTE DE CHUCURI - SANTANDER", "SANTA BARBARA - SANTANDER", "SANTA HELENA DEL OPON - SANTANDER", "SIMACOTA - SANTANDER", "SOCORRO - SANTANDER", "SUAITA - SANTANDER", "SUCRE - SANTANDER", "SURATA - SANTANDER", "TONA - SANTANDER", "VALLE DE SAN JOSE - SANTANDER", "VELEZ - SANTANDER", "VETAS - SANTANDER", "VILLANUEVA - SANTANDER", "ZAPATOCA - SANTANDER", "SINCELEJO - SUCRE", "BUENAVISTA - SUCRE", "CAIMITO - SUCRE", "COLOSO - SUCRE", "COROZAL - SUCRE", "COVEÑAS - SUCRE", "CHALAN - SUCRE", "EL ROBLE - SUCRE", "GALERAS - SUCRE", "GUARANDA - SUCRE", "LA UNION - SUCRE", "LOS PALMITOS - SUCRE", "MAJAGUAL - SUCRE", "MORROA - SUCRE", "OVEJAS - SUCRE", "PALMITO - SUCRE", "SAMPUES - SUCRE", "SAN BENITO ABAD - SUCRE", "SAN JUAN DE BETULIA - SUCRE", "SAN MARCOS - SUCRE", "SAN ONOFRE - SUCRE", "SAN PEDRO - SUCRE", "SAN LUIS DE SINCE - SUCRE", "SUCRE - SUCRE", "SANTIAGO DE TOLU - SUCRE", "TOLU VIEJO - SUCRE", "IBAGUE - TOLIMA", "ALPUJARRA - TOLIMA", "ALVARADO - TOLIMA", "AMBALEMA - TOLIMA", "ANZOATEGUI - TOLIMA", "ARMERO - TOLIMA", "ATACO - TOLIMA", "CAJAMARCA - TOLIMA", "CARMEN DE APICALA - TOLIMA", "CASABIANCA - TOLIMA", "CHAPARRAL - TOLIMA", "COELLO - TOLIMA", "COYAIMA - TOLIMA", "CUNDAY - TOLIMA", "DOLORES - TOLIMA", "ESPINAL - TOLIMA", "FALAN - TOLIMA", "FLANDES - TOLIMA", "FRESNO - TOLIMA", "GUAMO - TOLIMA", "HERVEO - TOLIMA", "HONDA - TOLIMA", "ICONONZO - TOLIMA", "LERIDA - TOLIMA", "LIBANO - TOLIMA", "MARIQUITA - TOLIMA", "MELGAR - TOLIMA", "MURILLO - TOLIMA", "NATAGAIMA - TOLIMA", "ORTEGA - TOLIMA", "PALOCABILDO - TOLIMA", "PIEDRAS - TOLIMA", "PLANADAS - TOLIMA", "PRADO - TOLIMA", "PURIFICACION - TOLIMA", "RIOBLANCO - TOLIMA", "RONCESVALLES - TOLIMA", "ROVIRA - TOLIMA", "SALDAÑA - TOLIMA", "SAN ANTONIO - TOLIMA", "SAN LUIS - TOLIMA", "SANTA ISABEL - TOLIMA", "SUAREZ - TOLIMA", "VALLE DE SAN JUAN - TOLIMA", "VENADILLO - TOLIMA", "VILLAHERMOSA - TOLIMA", "VILLARRICA - TOLIMA", "CALI - VALLE DEL CAUCA", "ALCALA - VALLE DEL CAUCA", "ANDALUCIA - VALLE DEL CAUCA", "ANSERMANUEVO - VALLE DEL CAUCA", "ARGELIA - VALLE DEL CAUCA", "BOLIVAR - VALLE DEL CAUCA", "BUENAVENTURA - VALLE DEL CAUCA", "GUADALAJARA DE BUGA - VALLE DEL CAUCA", "BUGALAGRANDE - VALLE DEL CAUCA", "CAICEDONIA - VALLE DEL CAUCA", "CALIMA - VALLE DEL CAUCA", "CANDELARIA - VALLE DEL CAUCA", "CARTAGO - VALLE DEL CAUCA", "DAGUA - VALLE DEL CAUCA", "EL AGUILA - VALLE DEL CAUCA", "EL CAIRO - VALLE DEL CAUCA", "EL CERRITO - VALLE DEL CAUCA", "EL DOVIO - VALLE DEL CAUCA", "FLORIDA - VALLE DEL CAUCA", "GINEBRA - VALLE DEL CAUCA", "GUACARI - VALLE DEL CAUCA", "JAMUNDI - VALLE DEL CAUCA", "LA CUMBRE - VALLE DEL CAUCA", "LA UNION - VALLE DEL CAUCA", "LA VICTORIA - VALLE DEL CAUCA", "OBANDO - VALLE DEL CAUCA", "PALMIRA - VALLE DEL CAUCA", "PRADERA - VALLE DEL CAUCA", "RESTREPO - VALLE DEL CAUCA", "RIOFRIO - VALLE DEL CAUCA", "ROLDANILLO - VALLE DEL CAUCA", "SAN PEDRO - VALLE DEL CAUCA", "SEVILLA - VALLE DEL CAUCA", "TORO - VALLE DEL CAUCA", "TRUJILLO - VALLE DEL CAUCA", "TULUA - VALLE DEL CAUCA", "ULLOA - VALLE DEL CAUCA", "VERSALLES - VALLE DEL CAUCA", "VIJES - VALLE DEL CAUCA", "YOTOCO - VALLE DEL CAUCA", "YUMBO - VALLE DEL CAUCA", "ZARZAL - VALLE DEL CAUCA", "ARAUCA - ARAUCA", "ARAUQUITA - ARAUCA", "CRAVO NORTE - ARAUCA", "FORTUL - ARAUCA", "PUERTO RONDON - ARAUCA", "SARAVENA - ARAUCA", "TAME - ARAUCA", "YOPAL - CASANARE", "AGUAZUL - CASANARE", "CHAMEZA - CASANARE", "HATO COROZAL - CASANARE", "LA SALINA - CASANARE", "MANI - CASANARE", "MONTERREY - CASANARE", "NUNCHIA - CASANARE", "OROCUE - CASANARE", "PAZ DE ARIPORO - CASANARE", "PORE - CASANARE", "RECETOR - CASANARE", "SABANALARGA - CASANARE", "SACAMA - CASANARE", "SAN LUIS DE PALENQUE - CASANARE", "TAMARA - CASANARE", "TAURAMENA - CASANARE", "TRINIDAD - CASANARE", "VILLANUEVA - CASANARE", "MOCOA - PUTUMAYO", "COLON - PUTUMAYO", "ORITO - PUTUMAYO", "PUERTO ASIS - PUTUMAYO", "PUERTO CAICEDO - PUTUMAYO", "PUERTO GUZMAN - PUTUMAYO", "LEGUIZAMO - PUTUMAYO", "SIBUNDOY - PUTUMAYO", "SAN FRANCISCO - PUTUMAYO", "SAN MIGUEL - PUTUMAYO", "SANTIAGO - PUTUMAYO", "VALLE DEL GUAMUEZ - PUTUMAYO", "VILLAGARZON - PUTUMAYO", "SAN ANDRES - SAN ANDRES", "PROVIDENCIA - SAN ANDRES", "LETICIA - AMAZONAS", "EL ENCANTO - AMAZONAS", "LA CHORRERA - AMAZONAS", "LA PEDRERA - AMAZONAS", "LA VICTORIA - AMAZONAS", "MIRITI - PARANA - AMAZONAS", "PUERTO ALEGRIA - AMAZONAS", "PUERTO ARICA - AMAZONAS", "PUERTO NARIÑO - AMAZONAS", "PUERTO SANTANDER - AMAZONAS", "TARAPACA - AMAZONAS", "INIRIDA - GUAINIA", "BARRANCO MINAS - GUAINIA", "MAPIRIPANA - GUAINIA", "SAN FELIPE - GUAINIA", "PUERTO COLOMBIA - GUAINIA", "LA GUADALUPE - GUAINIA", "CACAHUAL - GUAINIA", "PANA PANA - GUAINIA", "MORICHAL - GUAINIA", "SAN JOSE DEL GUAVIARE - GUAVIARE", "CALAMAR - GUAVIARE", "EL RETORNO - GUAVIARE", "MIRAFLORES - GUAVIARE", "MITU - VAUPES", "CARURU - VAUPES", "PACOA - VAUPES", "TARAIRA - VAUPES", "PAPUNAUA - VAUPES", "YAVARATE - VAUPES", "PUERTO CARREÑO - VICHADA", "LA PRIMAVERA - VICHADA", "SANTA ROSALIA - VICHADA", "CUMARIBO - VICHADA"})
        Me.ComboBox_medioPAgo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox_medioPAgo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox_medioPAgo.BackColor = System.Drawing.Color.White
        Me.BunifuTransition1.SetDecoration(Me.ComboBox_medioPAgo, BunifuAnimatorNS.DecorationType.None)
        Me.ComboBox_medioPAgo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_medioPAgo.ForeColor = System.Drawing.Color.Black
        Me.ComboBox_medioPAgo.FormattingEnabled = True
        Me.ComboBox_medioPAgo.ItemHeight = 16
        Me.ComboBox_medioPAgo.Location = New System.Drawing.Point(18, 273)
        Me.ComboBox_medioPAgo.Name = "ComboBox_medioPAgo"
        Me.ComboBox_medioPAgo.Size = New System.Drawing.Size(279, 24)
        Me.ComboBox_medioPAgo.TabIndex = 31
        '
        'Label31
        '
        Me.Label31.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label31, BunifuAnimatorNS.DecorationType.None)
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.DimGray
        Me.Label31.Location = New System.Drawing.Point(404, 379)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(126, 13)
        Me.Label31.TabIndex = 1002
        Me.Label31.Text = "Persona de Contacto"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_contacto
        '
        Me.TextBox_contacto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox_contacto.BackColor = System.Drawing.Color.White
        Me.BunifuTransition1.SetDecoration(Me.TextBox_contacto, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox_contacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_contacto.ForeColor = System.Drawing.Color.Black
        Me.TextBox_contacto.Location = New System.Drawing.Point(403, 392)
        Me.TextBox_contacto.Name = "TextBox_contacto"
        Me.TextBox_contacto.Size = New System.Drawing.Size(458, 24)
        Me.TextBox_contacto.TabIndex = 30
        '
        'Text_leyenda
        '
        Me.Text_leyenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Text_leyenda.BackColor = System.Drawing.Color.White
        Me.BunifuTransition1.SetDecoration(Me.Text_leyenda, BunifuAnimatorNS.DecorationType.None)
        Me.Text_leyenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_leyenda.ForeColor = System.Drawing.Color.Black
        Me.Text_leyenda.Location = New System.Drawing.Point(14, 392)
        Me.Text_leyenda.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.Text_leyenda.Multiline = True
        Me.Text_leyenda.Name = "Text_leyenda"
        Me.Text_leyenda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Text_leyenda.Size = New System.Drawing.Size(377, 66)
        Me.Text_leyenda.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label7, BunifuAnimatorNS.DecorationType.None)
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(14, 379)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 407
        Me.Label7.Text = "Observaciones"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_TEL4
        '
        Me.TextBox_TEL4.BackColor = System.Drawing.Color.White
        Me.BunifuTransition1.SetDecoration(Me.TextBox_TEL4, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox_TEL4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_TEL4.ForeColor = System.Drawing.Color.Black
        Me.TextBox_TEL4.Location = New System.Drawing.Point(552, 226)
        Me.TextBox_TEL4.Name = "TextBox_TEL4"
        Me.TextBox_TEL4.Size = New System.Drawing.Size(169, 24)
        Me.TextBox_TEL4.TabIndex = 26
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label28, BunifuAnimatorNS.DecorationType.None)
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.DimGray
        Me.Label28.Location = New System.Drawing.Point(551, 213)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(64, 13)
        Me.Label28.TabIndex = 672
        Me.Label28.Text = "Teléfono4"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_TEL3
        '
        Me.TextBox_TEL3.BackColor = System.Drawing.Color.White
        Me.BunifuTransition1.SetDecoration(Me.TextBox_TEL3, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox_TEL3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_TEL3.ForeColor = System.Drawing.Color.Black
        Me.TextBox_TEL3.Location = New System.Drawing.Point(367, 226)
        Me.TextBox_TEL3.Name = "TextBox_TEL3"
        Me.TextBox_TEL3.Size = New System.Drawing.Size(169, 24)
        Me.TextBox_TEL3.TabIndex = 25
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label21, BunifuAnimatorNS.DecorationType.None)
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.DimGray
        Me.Label21.Location = New System.Drawing.Point(366, 213)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(64, 13)
        Me.Label21.TabIndex = 670
        Me.Label21.Text = "Teléfono3"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(14, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 397
        Me.Label3.Text = "Teléfono1"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_TEL
        '
        Me.TextBox_TEL.BackColor = System.Drawing.Color.White
        Me.BunifuTransition1.SetDecoration(Me.TextBox_TEL, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox_TEL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_TEL.ForeColor = System.Drawing.Color.Black
        Me.TextBox_TEL.Location = New System.Drawing.Point(14, 226)
        Me.TextBox_TEL.Name = "TextBox_TEL"
        Me.TextBox_TEL.Size = New System.Drawing.Size(151, 24)
        Me.TextBox_TEL.TabIndex = 23
        '
        'TextBox_TEL2
        '
        Me.TextBox_TEL2.BackColor = System.Drawing.Color.White
        Me.BunifuTransition1.SetDecoration(Me.TextBox_TEL2, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox_TEL2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_TEL2.ForeColor = System.Drawing.Color.Black
        Me.TextBox_TEL2.Location = New System.Drawing.Point(181, 226)
        Me.TextBox_TEL2.Name = "TextBox_TEL2"
        Me.TextBox_TEL2.Size = New System.Drawing.Size(169, 24)
        Me.TextBox_TEL2.TabIndex = 24
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label18, BunifuAnimatorNS.DecorationType.None)
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.DimGray
        Me.Label18.Location = New System.Drawing.Point(180, 213)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 13)
        Me.Label18.TabIndex = 629
        Me.Label18.Text = "Teléfono2"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'textbox_fullname
        '
        Me.textbox_fullname.BackColor = System.Drawing.Color.WhiteSmoke
        Me.textbox_fullname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.textbox_fullname, BunifuAnimatorNS.DecorationType.None)
        Me.textbox_fullname.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox_fullname.ForeColor = System.Drawing.Color.Black
        Me.textbox_fullname.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.textbox_fullname.HintText = ""
        Me.textbox_fullname.isPassword = False
        Me.textbox_fullname.LineFocusedColor = System.Drawing.Color.Blue
        Me.textbox_fullname.LineIdleColor = System.Drawing.Color.Black
        Me.textbox_fullname.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.textbox_fullname.LineThickness = 2
        Me.textbox_fullname.Location = New System.Drawing.Point(16, 117)
        Me.textbox_fullname.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.textbox_fullname.Name = "textbox_fullname"
        Me.textbox_fullname.Size = New System.Drawing.Size(848, 32)
        Me.textbox_fullname.TabIndex = 2002
        Me.textbox_fullname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AllowDrop = True
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label15, BunifuAnimatorNS.DecorationType.None)
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(14, 101)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(318, 28)
        Me.Label15.TabIndex = 432
        Me.Label15.Text = "Información del  Contacto"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.BunifuTransition1.SetDecoration(Me.TabControl1, BunifuAnimatorNS.DecorationType.None)
        Me.TabControl1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.HotTrack = True
        Me.TabControl1.ItemSize = New System.Drawing.Size(139, 40)
        Me.TabControl1.Location = New System.Drawing.Point(14, 131)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(889, 510)
        Me.TabControl1.TabIndex = 1024
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label30)
        Me.TabPage1.Controls.Add(Me.Label29)
        Me.TabPage1.Controls.Add(Me.ComboBox_pais)
        Me.TabPage1.Controls.Add(Me.Label_mail)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.TextBox_DOMICILIO)
        Me.TabPage1.Controls.Add(Me.ComboBox_activo)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.ComboBox_CIUDAD)
        Me.TabPage1.Controls.Add(Me.Text_leyenda)
        Me.TabPage1.Controls.Add(Me.TextBox_TEL4)
        Me.TabPage1.Controls.Add(Me.TextBox_contacto)
        Me.TabPage1.Controls.Add(Me.Label28)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.TextBox_TEL3)
        Me.TabPage1.Controls.Add(Me.Label31)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.Combo_naturaleza)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.TextBox_TEL)
        Me.TabPage1.Controls.Add(Me.ComboBox_tipocontribuyente)
        Me.TabPage1.Controls.Add(Me.TextBox_TEL2)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.DateTimePicker1)
        Me.TabPage1.Controls.Add(Me.Label26)
        Me.TabPage1.Controls.Add(Me.textbox_fullname)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.TextBox_SITIOWEB)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.ComboBox_tipodoc)
        Me.TabPage1.Controls.Add(Me.TextBox_MAIL)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.TextBox_DOC)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.TextBox_dv)
        Me.BunifuTransition1.SetDecoration(Me.TabPage1, BunifuAnimatorNS.DecorationType.None)
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(881, 462)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "        Información General        "
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.mail_new
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.Button3, BunifuAnimatorNS.DecorationType.None)
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(398, 330)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(45, 38)
        Me.Button3.TabIndex = 658
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.TextBox_NOMBRE2)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.TextBox_APELLIDO1)
        Me.TabPage2.Controls.Add(Me.Label34)
        Me.TabPage2.Controls.Add(Me.Label37)
        Me.TabPage2.Controls.Add(Me.Label35)
        Me.TabPage2.Controls.Add(Me.TextBox_Numero_id_fiscal)
        Me.TabPage2.Controls.Add(Me.Label25)
        Me.TabPage2.Controls.Add(Me.ComboBox_medioPAgo)
        Me.TabPage2.Controls.Add(Me.TextBox_NOMBRE1)
        Me.TabPage2.Controls.Add(Me.Label27)
        Me.TabPage2.Controls.Add(Me.Label36)
        Me.TabPage2.Controls.Add(Me.TextBox_cupoCredito)
        Me.TabPage2.Controls.Add(Me.TextBox_APELLIDO2)
        Me.TabPage2.Controls.Add(Me.Label33)
        Me.TabPage2.Controls.Add(Me.ComboBox_declarante)
        Me.TabPage2.Controls.Add(Me.ComboBox_ACTIVIDAD)
        Me.TabPage2.Controls.Add(Me.Label22)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.ComboBox_Agenteretenedor)
        Me.TabPage2.Controls.Add(Me.ComboBox_autoretenedor)
        Me.TabPage2.Controls.Add(Me.Label23)
        Me.BunifuTransition1.SetDecoration(Me.TabPage2, BunifuAnimatorNS.DecorationType.None)
        Me.TabPage2.Location = New System.Drawing.Point(4, 44)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(881, 462)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "        Información Financiera        "
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTransition1.SetDecoration(Me.Button4, BunifuAnimatorNS.DecorationType.None)
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.0!)
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(206, 342)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(101, 24)
        Me.Button4.TabIndex = 1032
        Me.Button4.Text = "Borrar Puntos"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label6, BunifuAnimatorNS.DecorationType.None)
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(17, 329)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 13)
        Me.Label6.TabIndex = 1031
        Me.Label6.Text = "Puntos Acumulados"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.BunifuTransition1.SetDecoration(Me.TextBox1, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(18, 342)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(169, 24)
        Me.TextBox1.TabIndex = 1030
        Me.TextBox1.Text = "0"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button_guardar
        '
        Me.Button_guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_guardar.BackColor = System.Drawing.Color.Transparent
        Me.Button_guardar.BackgroundImage = CType(resources.GetObject("Button_guardar.BackgroundImage"), System.Drawing.Image)
        Me.Button_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTransition1.SetDecoration(Me.Button_guardar, BunifuAnimatorNS.DecorationType.None)
        Me.Button_guardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button_guardar.FlatAppearance.BorderSize = 0
        Me.Button_guardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Button_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.Button_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_guardar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.Button_guardar.ForeColor = System.Drawing.Color.White
        Me.Button_guardar.Image = Global.MiClickDerecho.My.Resources.Resources.save_icon_5427
        Me.Button_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_guardar.Location = New System.Drawing.Point(674, 40)
        Me.Button_guardar.Name = "Button_guardar"
        Me.Button_guardar.Size = New System.Drawing.Size(101, 46)
        Me.Button_guardar.TabIndex = 392
        Me.Button_guardar.Text = "Guardar"
        Me.Button_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_guardar.UseVisualStyleBackColor = False
        '
        'Button_cancelar
        '
        Me.Button_cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_cancelar.BackColor = System.Drawing.Color.Transparent
        Me.Button_cancelar.BackgroundImage = CType(resources.GetObject("Button_cancelar.BackgroundImage"), System.Drawing.Image)
        Me.Button_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTransition1.SetDecoration(Me.Button_cancelar, BunifuAnimatorNS.DecorationType.None)
        Me.Button_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button_cancelar.FlatAppearance.BorderSize = 0
        Me.Button_cancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Button_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.Button_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_cancelar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.Button_cancelar.ForeColor = System.Drawing.Color.White
        Me.Button_cancelar.Image = Global.MiClickDerecho.My.Resources.Resources.back
        Me.Button_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_cancelar.Location = New System.Drawing.Point(783, 40)
        Me.Button_cancelar.Name = "Button_cancelar"
        Me.Button_cancelar.Size = New System.Drawing.Size(101, 46)
        Me.Button_cancelar.TabIndex = 393
        Me.Button_cancelar.Text = "Regresar"
        Me.Button_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_cancelar.UseVisualStyleBackColor = False
        '
        'Form_contactos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(926, 668)
        Me.Controls.Add(Me.Panel_titlebar)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Button_guardar)
        Me.Controls.Add(Me.Button_cancelar)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.datagridPROVEEDORES)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(886, 561)
        Me.Name = "Form_contactos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contactos"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGrid_export, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.datagridPROVEEDORES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_titlebar.ResumeLayout(False)
        Me.Panel_titlebar.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox_DOMICILIO As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox_MAIL As System.Windows.Forms.TextBox
    Friend WithEvents Label_mail As System.Windows.Forms.Label
    Friend WithEvents Text_leyenda As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox_TEL As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox_DOC As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button_cancelar As System.Windows.Forms.Button
    Friend WithEvents Button_guardar As System.Windows.Forms.Button
    Friend WithEvents datagridPROVEEDORES As MetroFramework.Controls.MetroGrid
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button_eliminar As System.Windows.Forms.Button
    Friend WithEvents Button_modificar As System.Windows.Forms.Button
    Friend WithEvents button_crear As System.Windows.Forms.Button
    Friend WithEvents Button_export_pdf As System.Windows.Forms.Button
    Friend WithEvents Panel_titlebar As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ComboBox_CIUDAD As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox_SITIOWEB As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBox_dv As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox_TEL2 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ComboBox_tipodoc As ComboBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DataGrid_export As MetroFramework.Controls.MetroGrid
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox_tipocontribuyente As ComboBox
    Friend WithEvents Combo_naturaleza As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents ComboBox_autoretenedor As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents ComboBox_Agenteretenedor As ComboBox
    Friend WithEvents ComboBox_declarante As ComboBox
    Friend WithEvents Label20 As Label
    Public WithEvents Timer_nuevo As Timer
    Friend WithEvents Label14 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents BunifuElipse3 As ns1.BunifuElipse
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label26 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_TEL4 As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents TextBox_TEL3 As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents ComboBox_pais As ComboBox
    Friend WithEvents Label31 As Label
    Friend WithEvents TextBox_contacto As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents ComboBox_ACTIVIDAD As ComboBox
    Friend WithEvents Label36 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents TextBox_APELLIDO2 As TextBox
    Friend WithEvents TextBox_APELLIDO1 As TextBox
    Friend WithEvents TextBox_NOMBRE2 As TextBox
    Friend WithEvents TextBox_NOMBRE1 As TextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents TextBox_Numero_id_fiscal As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents TextBox_cupoCredito As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents ComboBox_medioPAgo As ComboBox
    Friend WithEvents ComboBox_activo As ComboBox
    Friend WithEvents TextBox_buscar_cliente As ns1.BunifuMaterialTextbox
    Friend WithEvents Label24 As Label
    Friend WithEvents textbox_fullname As ns1.BunifuMaterialTextbox
    Friend WithEvents Label29 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button4 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CheckBox_otro As CheckBox
    Friend WithEvents CheckBox_proveedor As CheckBox
    Friend WithEvents CheckBox_cliente As CheckBox
End Class
