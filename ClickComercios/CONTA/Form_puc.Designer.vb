<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_puc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_puc))
        Me.Timer_load_tipo_doc_parametros = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_LOAD_COMPROBANTES = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_clasificar = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_grid_puc = New System.Windows.Forms.Panel()
        Me.MetroGrid_puc = New MetroFramework.Controls.MetroGrid()
        Me.Panel_botones_puc = New System.Windows.Forms.Panel()
        Me.Button_crear_cuentaPUC = New System.Windows.Forms.Button()
        Me.Button_consultarcuenta = New System.Windows.Forms.Button()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Panel_filtro = New System.Windows.Forms.Panel()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Button_filtro_cuentas_puc = New System.Windows.Forms.Button()
        Me.Textbox_buscar_cta = New ns1.BunifuMaterialTextbox()
        Me.TextBox_descripcion = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.ComboBox_naturaleza = New MetroFramework.Controls.MetroComboBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button_almacen = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.BunifuElipse4 = New ns1.BunifuElipse(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox_niif = New System.Windows.Forms.ComboBox()
        Me.ContextMenuStrip_LOAD_PUC = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FiltrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarTodasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuentasDeActivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatrimonioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GastosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GastosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CostosDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CostosDeOperacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BsucarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorCódigoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorNombreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigurarCuentasDeContabilidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox_tipo = New MetroFramework.Controls.MetroComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MetroComboBox_clase = New MetroFramework.Controls.MetroComboBox()
        Me.TextBox_NOMBRECUENTA = New ns1.BunifuMaterialTextbox()
        Me.TextBox_cuentapuc = New ns1.BunifuMaterialTextbox()
        Me.RadioButton_Activa = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Inactiva = New System.Windows.Forms.RadioButton()
        Me.Panel_grid_puc.SuspendLayout()
        CType(Me.MetroGrid_puc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_botones_puc.SuspendLayout()
        Me.Panel_filtro.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ContextMenuStrip_LOAD_PUC.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer_load_tipo_doc_parametros
        '
        Me.Timer_load_tipo_doc_parametros.Interval = 300
        '
        'Timer_LOAD_COMPROBANTES
        '
        Me.Timer_LOAD_COMPROBANTES.Interval = 300
        '
        'Timer_clasificar
        '
        Me.Timer_clasificar.Interval = 300
        '
        'Panel_grid_puc
        '
        Me.Panel_grid_puc.BackColor = System.Drawing.Color.Transparent
        Me.Panel_grid_puc.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.cuadro_blanco
        Me.Panel_grid_puc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_grid_puc.Controls.Add(Me.MetroGrid_puc)
        Me.Panel_grid_puc.Location = New System.Drawing.Point(12, 150)
        Me.Panel_grid_puc.Name = "Panel_grid_puc"
        Me.Panel_grid_puc.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel_grid_puc.Size = New System.Drawing.Size(19, 452)
        Me.Panel_grid_puc.TabIndex = 587
        '
        'MetroGrid_puc
        '
        Me.MetroGrid_puc.AllowUserToAddRows = False
        Me.MetroGrid_puc.AllowUserToDeleteRows = False
        Me.MetroGrid_puc.AllowUserToResizeRows = False
        Me.MetroGrid_puc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MetroGrid_puc.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.MetroGrid_puc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid_puc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid_puc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid_puc.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MetroGrid_puc.ColumnHeadersHeight = 28
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid_puc.DefaultCellStyle = DataGridViewCellStyle2
        Me.MetroGrid_puc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroGrid_puc.EnableHeadersVisualStyles = False
        Me.MetroGrid_puc.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid_puc.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid_puc.Location = New System.Drawing.Point(5, 5)
        Me.MetroGrid_puc.Name = "MetroGrid_puc"
        Me.MetroGrid_puc.ReadOnly = True
        Me.MetroGrid_puc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid_puc.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.MetroGrid_puc.RowHeadersVisible = False
        Me.MetroGrid_puc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid_puc.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue
        Me.MetroGrid_puc.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.MetroGrid_puc.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MetroGrid_puc.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.MetroGrid_puc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid_puc.Size = New System.Drawing.Size(9, 442)
        Me.MetroGrid_puc.TabIndex = 585
        '
        'Panel_botones_puc
        '
        Me.Panel_botones_puc.Controls.Add(Me.Button_crear_cuentaPUC)
        Me.Panel_botones_puc.Controls.Add(Me.Button_consultarcuenta)
        Me.Panel_botones_puc.Location = New System.Drawing.Point(563, 92)
        Me.Panel_botones_puc.Name = "Panel_botones_puc"
        Me.Panel_botones_puc.Size = New System.Drawing.Size(419, 50)
        Me.Panel_botones_puc.TabIndex = 586
        '
        'Button_crear_cuentaPUC
        '
        Me.Button_crear_cuentaPUC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_crear_cuentaPUC.BackColor = System.Drawing.Color.Transparent
        Me.Button_crear_cuentaPUC.BackgroundImage = CType(resources.GetObject("Button_crear_cuentaPUC.BackgroundImage"), System.Drawing.Image)
        Me.Button_crear_cuentaPUC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_crear_cuentaPUC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_crear_cuentaPUC.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button_crear_cuentaPUC.FlatAppearance.BorderSize = 0
        Me.Button_crear_cuentaPUC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_crear_cuentaPUC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_crear_cuentaPUC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_crear_cuentaPUC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_crear_cuentaPUC.ForeColor = System.Drawing.Color.White
        Me.Button_crear_cuentaPUC.Image = Global.MiClickDerecho.My.Resources.Resources.agregar
        Me.Button_crear_cuentaPUC.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_crear_cuentaPUC.Location = New System.Drawing.Point(204, 0)
        Me.Button_crear_cuentaPUC.Name = "Button_crear_cuentaPUC"
        Me.Button_crear_cuentaPUC.Size = New System.Drawing.Size(115, 48)
        Me.Button_crear_cuentaPUC.TabIndex = 625
        Me.Button_crear_cuentaPUC.Text = "Crear Cuenta"
        Me.Button_crear_cuentaPUC.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_crear_cuentaPUC.UseVisualStyleBackColor = False
        '
        'Button_consultarcuenta
        '
        Me.Button_consultarcuenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_consultarcuenta.BackColor = System.Drawing.Color.Transparent
        Me.Button_consultarcuenta.BackgroundImage = CType(resources.GetObject("Button_consultarcuenta.BackgroundImage"), System.Drawing.Image)
        Me.Button_consultarcuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_consultarcuenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_consultarcuenta.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button_consultarcuenta.FlatAppearance.BorderSize = 0
        Me.Button_consultarcuenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_consultarcuenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_consultarcuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_consultarcuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_consultarcuenta.ForeColor = System.Drawing.Color.White
        Me.Button_consultarcuenta.Image = Global.MiClickDerecho.My.Resources.Resources.Openfileiconmini
        Me.Button_consultarcuenta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_consultarcuenta.Location = New System.Drawing.Point(323, 0)
        Me.Button_consultarcuenta.Name = "Button_consultarcuenta"
        Me.Button_consultarcuenta.Size = New System.Drawing.Size(90, 48)
        Me.Button_consultarcuenta.TabIndex = 626
        Me.Button_consultarcuenta.Text = "Consultar"
        Me.Button_consultarcuenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_consultarcuenta.UseVisualStyleBackColor = False
        '
        'Label40
        '
        Me.Label40.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label40.AutoSize = True
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(21, 52)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(145, 23)
        Me.Label40.TabIndex = 649
        Me.Label40.Text = "Plan de Cuentas"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel_filtro
        '
        Me.Panel_filtro.Controls.Add(Me.Label47)
        Me.Panel_filtro.Controls.Add(Me.Button_filtro_cuentas_puc)
        Me.Panel_filtro.Controls.Add(Me.Textbox_buscar_cta)
        Me.Panel_filtro.Location = New System.Drawing.Point(18, 78)
        Me.Panel_filtro.Name = "Panel_filtro"
        Me.Panel_filtro.Size = New System.Drawing.Size(521, 66)
        Me.Panel_filtro.TabIndex = 661
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.BackColor = System.Drawing.Color.Transparent
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label47.ForeColor = System.Drawing.Color.Black
        Me.Label47.Location = New System.Drawing.Point(4, 14)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(90, 13)
        Me.Label47.TabIndex = 655
        Me.Label47.Text = "Buscar Cuenta"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button_filtro_cuentas_puc
        '
        Me.Button_filtro_cuentas_puc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_filtro_cuentas_puc.BackColor = System.Drawing.Color.Transparent
        Me.Button_filtro_cuentas_puc.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.butttonsvg
        Me.Button_filtro_cuentas_puc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_filtro_cuentas_puc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_filtro_cuentas_puc.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button_filtro_cuentas_puc.FlatAppearance.BorderSize = 0
        Me.Button_filtro_cuentas_puc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_filtro_cuentas_puc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_filtro_cuentas_puc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_filtro_cuentas_puc.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_filtro_cuentas_puc.ForeColor = System.Drawing.Color.White
        Me.Button_filtro_cuentas_puc.Location = New System.Drawing.Point(343, 30)
        Me.Button_filtro_cuentas_puc.Name = "Button_filtro_cuentas_puc"
        Me.Button_filtro_cuentas_puc.Size = New System.Drawing.Size(98, 32)
        Me.Button_filtro_cuentas_puc.TabIndex = 656
        Me.Button_filtro_cuentas_puc.Text = "Buscar"
        Me.Button_filtro_cuentas_puc.UseVisualStyleBackColor = False
        '
        'Textbox_buscar_cta
        '
        Me.Textbox_buscar_cta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textbox_buscar_cta.Font = New System.Drawing.Font("Century Gothic", 10.75!)
        Me.Textbox_buscar_cta.ForeColor = System.Drawing.Color.Black
        Me.Textbox_buscar_cta.HintForeColor = System.Drawing.Color.Empty
        Me.Textbox_buscar_cta.HintText = ""
        Me.Textbox_buscar_cta.isPassword = False
        Me.Textbox_buscar_cta.LineFocusedColor = System.Drawing.Color.Blue
        Me.Textbox_buscar_cta.LineIdleColor = System.Drawing.Color.Black
        Me.Textbox_buscar_cta.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.Textbox_buscar_cta.LineThickness = 2
        Me.Textbox_buscar_cta.Location = New System.Drawing.Point(9, 21)
        Me.Textbox_buscar_cta.Margin = New System.Windows.Forms.Padding(5)
        Me.Textbox_buscar_cta.Name = "Textbox_buscar_cta"
        Me.Textbox_buscar_cta.Size = New System.Drawing.Size(317, 40)
        Me.Textbox_buscar_cta.TabIndex = 661
        Me.Textbox_buscar_cta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_descripcion
        '
        Me.TextBox_descripcion.BackColor = System.Drawing.Color.White
        Me.TextBox_descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_descripcion.ForeColor = System.Drawing.Color.Black
        Me.TextBox_descripcion.Location = New System.Drawing.Point(71, 419)
        Me.TextBox_descripcion.Multiline = True
        Me.TextBox_descripcion.Name = "TextBox_descripcion"
        Me.TextBox_descripcion.Size = New System.Drawing.Size(661, 80)
        Me.TextBox_descripcion.TabIndex = 592
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.BackColor = System.Drawing.Color.Transparent
        Me.Label51.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.Black
        Me.Label51.Location = New System.Drawing.Point(71, 404)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(67, 13)
        Me.Label51.TabIndex = 657
        Me.Label51.Text = "Descripción"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.BackColor = System.Drawing.Color.Transparent
        Me.Label49.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.Black
        Me.Label49.Location = New System.Drawing.Point(292, 349)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(63, 13)
        Me.Label49.TabIndex = 652
        Me.Label49.Text = "Naturaleza"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox_naturaleza
        '
        Me.ComboBox_naturaleza.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ComboBox_naturaleza.FontWeight = MetroFramework.MetroComboBoxWeight.Light
        Me.ComboBox_naturaleza.FormattingEnabled = True
        Me.ComboBox_naturaleza.ItemHeight = 23
        Me.ComboBox_naturaleza.Items.AddRange(New Object() {"DEBITO", "CREDITO"})
        Me.ComboBox_naturaleza.Location = New System.Drawing.Point(294, 363)
        Me.ComboBox_naturaleza.Name = "ComboBox_naturaleza"
        Me.ComboBox_naturaleza.Size = New System.Drawing.Size(215, 29)
        Me.ComboBox_naturaleza.TabIndex = 590
        Me.ComboBox_naturaleza.UseSelectable = True
        '
        'Label44
        '
        Me.Label44.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label44.AutoSize = True
        Me.Label44.BackColor = System.Drawing.Color.Transparent
        Me.Label44.Font = New System.Drawing.Font("Segoe UI Semibold", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Black
        Me.Label44.Location = New System.Drawing.Point(66, 163)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(330, 31)
        Me.Label44.TabIndex = 653
        Me.Label44.Text = "Detalles de la Cuenta Contable"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Black
        Me.Label43.Location = New System.Drawing.Point(69, 519)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(81, 13)
        Me.Label43.TabIndex = 651
        Me.Label43.Text = "Concepto NIIF"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label43.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(71, 288)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 13)
        Me.Label16.TabIndex = 634
        Me.Label16.Text = "Nombre"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(545, 221)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(81, 15)
        Me.Label17.TabIndex = 636
        Me.Label17.Text = "Estado Actual"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button10
        '
        Me.Button10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button10.BackColor = System.Drawing.Color.Transparent
        Me.Button10.BackgroundImage = CType(resources.GetObject("Button10.BackgroundImage"), System.Drawing.Image)
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button10.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.White
        Me.Button10.Image = Global.MiClickDerecho.My.Resources.Resources.guardar
        Me.Button10.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button10.Location = New System.Drawing.Point(814, 204)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(137, 52)
        Me.Button10.TabIndex = 638
        Me.Button10.Text = "Guardar"
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button9.BackColor = System.Drawing.Color.Transparent
        Me.Button9.BackgroundImage = CType(resources.GetObject("Button9.BackgroundImage"), System.Drawing.Image)
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button9.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Image = Global.MiClickDerecho.My.Resources.Resources.backk
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button9.Location = New System.Drawing.Point(814, 329)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(137, 52)
        Me.Button9.TabIndex = 639
        Me.Button9.Text = "Regresar"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel2.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.banner9
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Button_almacen)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1000, 40)
        Me.Panel2.TabIndex = 508
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.CANCEL
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(956, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 30)
        Me.Button1.TabIndex = 598
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button_almacen
        '
        Me.Button_almacen.BackColor = System.Drawing.Color.Transparent
        Me.Button_almacen.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.unnamedcon
        Me.Button_almacen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_almacen.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.Button_almacen.FlatAppearance.BorderSize = 0
        Me.Button_almacen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_almacen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_almacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_almacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_almacen.ForeColor = System.Drawing.Color.White
        Me.Button_almacen.Location = New System.Drawing.Point(7, 3)
        Me.Button_almacen.Name = "Button_almacen"
        Me.Button_almacen.Size = New System.Drawing.Size(37, 32)
        Me.Button_almacen.TabIndex = 394
        Me.Button_almacen.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_almacen.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(50, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(381, 26)
        Me.Label5.TabIndex = 393
        Me.Label5.Text = "Configuración del Plan de Cuentas"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuElipse4
        '
        Me.BunifuElipse4.ElipseRadius = 5
        Me.BunifuElipse4.TargetControl = Me.MetroGrid_puc
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.MiClickDerecho.My.Resources.Resources.delete_row
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(814, 266)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(137, 52)
        Me.Button2.TabIndex = 627
        Me.Button2.Text = "Eliminar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(71, 223)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 662
        Me.Label1.Text = "Codigo PUC"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox_niif
        '
        Me.ComboBox_niif.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox_niif.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox_niif.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ComboBox_niif.FormattingEnabled = True
        Me.ComboBox_niif.Location = New System.Drawing.Point(69, 534)
        Me.ComboBox_niif.Name = "ComboBox_niif"
        Me.ComboBox_niif.Size = New System.Drawing.Size(629, 25)
        Me.ComboBox_niif.TabIndex = 663
        Me.ComboBox_niif.Visible = False
        '
        'ContextMenuStrip_LOAD_PUC
        '
        Me.ContextMenuStrip_LOAD_PUC.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FiltrarToolStripMenuItem, Me.BsucarToolStripMenuItem, Me.ConfigurarCuentasDeContabilidadToolStripMenuItem})
        Me.ContextMenuStrip_LOAD_PUC.Name = "ContextMenuStrip_LOAD_PUC"
        Me.ContextMenuStrip_LOAD_PUC.Size = New System.Drawing.Size(252, 82)
        '
        'FiltrarToolStripMenuItem
        '
        Me.FiltrarToolStripMenuItem.BackColor = System.Drawing.Color.Lavender
        Me.FiltrarToolStripMenuItem.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.buttonborder2
        Me.FiltrarToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FiltrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListarTodasToolStripMenuItem, Me.CuentasDeActivoToolStripMenuItem, Me.ActivoToolStripMenuItem, Me.PatrimonioToolStripMenuItem, Me.GastosToolStripMenuItem, Me.GastosToolStripMenuItem1, Me.CostosDeVentasToolStripMenuItem, Me.CostosDeOperacionToolStripMenuItem})
        Me.FiltrarToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.FiltrarToolStripMenuItem.Image = Global.MiClickDerecho.My.Resources.Resources.filtering
        Me.FiltrarToolStripMenuItem.Name = "FiltrarToolStripMenuItem"
        Me.FiltrarToolStripMenuItem.Size = New System.Drawing.Size(251, 26)
        Me.FiltrarToolStripMenuItem.Text = "Filtrar"
        '
        'ListarTodasToolStripMenuItem
        '
        Me.ListarTodasToolStripMenuItem.Name = "ListarTodasToolStripMenuItem"
        Me.ListarTodasToolStripMenuItem.Size = New System.Drawing.Size(374, 26)
        Me.ListarTodasToolStripMenuItem.Text = "Listar Todas"
        '
        'CuentasDeActivoToolStripMenuItem
        '
        Me.CuentasDeActivoToolStripMenuItem.Name = "CuentasDeActivoToolStripMenuItem"
        Me.CuentasDeActivoToolStripMenuItem.Size = New System.Drawing.Size(374, 26)
        Me.CuentasDeActivoToolStripMenuItem.Text = "1. Activo"
        '
        'ActivoToolStripMenuItem
        '
        Me.ActivoToolStripMenuItem.Name = "ActivoToolStripMenuItem"
        Me.ActivoToolStripMenuItem.Size = New System.Drawing.Size(374, 26)
        Me.ActivoToolStripMenuItem.Text = "2. Pasivo"
        '
        'PatrimonioToolStripMenuItem
        '
        Me.PatrimonioToolStripMenuItem.Name = "PatrimonioToolStripMenuItem"
        Me.PatrimonioToolStripMenuItem.Size = New System.Drawing.Size(374, 26)
        Me.PatrimonioToolStripMenuItem.Text = "3. Patrimonio"
        '
        'GastosToolStripMenuItem
        '
        Me.GastosToolStripMenuItem.Name = "GastosToolStripMenuItem"
        Me.GastosToolStripMenuItem.Size = New System.Drawing.Size(374, 26)
        Me.GastosToolStripMenuItem.Text = "4. Ingresos"
        '
        'GastosToolStripMenuItem1
        '
        Me.GastosToolStripMenuItem1.Name = "GastosToolStripMenuItem1"
        Me.GastosToolStripMenuItem1.Size = New System.Drawing.Size(374, 26)
        Me.GastosToolStripMenuItem1.Text = "5. Gastos"
        '
        'CostosDeVentasToolStripMenuItem
        '
        Me.CostosDeVentasToolStripMenuItem.Name = "CostosDeVentasToolStripMenuItem"
        Me.CostosDeVentasToolStripMenuItem.Size = New System.Drawing.Size(374, 26)
        Me.CostosDeVentasToolStripMenuItem.Text = "6. Costos de Ventas"
        '
        'CostosDeOperacionToolStripMenuItem
        '
        Me.CostosDeOperacionToolStripMenuItem.Name = "CostosDeOperacionToolStripMenuItem"
        Me.CostosDeOperacionToolStripMenuItem.Size = New System.Drawing.Size(374, 26)
        Me.CostosDeOperacionToolStripMenuItem.Text = "7. Costos de Producción o de Operación"
        '
        'BsucarToolStripMenuItem
        '
        Me.BsucarToolStripMenuItem.BackColor = System.Drawing.Color.Lavender
        Me.BsucarToolStripMenuItem.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.buttonborder2
        Me.BsucarToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BsucarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PorCódigoToolStripMenuItem, Me.PorNombreToolStripMenuItem})
        Me.BsucarToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.BsucarToolStripMenuItem.Image = Global.MiClickDerecho.My.Resources.Resources.viewicone
        Me.BsucarToolStripMenuItem.Name = "BsucarToolStripMenuItem"
        Me.BsucarToolStripMenuItem.Size = New System.Drawing.Size(251, 26)
        Me.BsucarToolStripMenuItem.Text = "Bsucar"
        '
        'PorCódigoToolStripMenuItem
        '
        Me.PorCódigoToolStripMenuItem.Name = "PorCódigoToolStripMenuItem"
        Me.PorCódigoToolStripMenuItem.Size = New System.Drawing.Size(169, 26)
        Me.PorCódigoToolStripMenuItem.Text = "Por Código"
        '
        'PorNombreToolStripMenuItem
        '
        Me.PorNombreToolStripMenuItem.Name = "PorNombreToolStripMenuItem"
        Me.PorNombreToolStripMenuItem.Size = New System.Drawing.Size(169, 26)
        Me.PorNombreToolStripMenuItem.Text = "Por Nombre"
        '
        'ConfigurarCuentasDeContabilidadToolStripMenuItem
        '
        Me.ConfigurarCuentasDeContabilidadToolStripMenuItem.BackColor = System.Drawing.Color.Lavender
        Me.ConfigurarCuentasDeContabilidadToolStripMenuItem.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.buttonborder2
        Me.ConfigurarCuentasDeContabilidadToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ConfigurarCuentasDeContabilidadToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.ConfigurarCuentasDeContabilidadToolStripMenuItem.Image = Global.MiClickDerecho.My.Resources.Resources.accounter2512
        Me.ConfigurarCuentasDeContabilidadToolStripMenuItem.Name = "ConfigurarCuentasDeContabilidadToolStripMenuItem"
        Me.ConfigurarCuentasDeContabilidadToolStripMenuItem.Size = New System.Drawing.Size(251, 26)
        Me.ConfigurarCuentasDeContabilidadToolStripMenuItem.Text = "Configurar Cuentas NIIF"
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.menu
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.ContextMenuStrip = Me.ContextMenuStrip_LOAD_PUC
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(710, 529)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(31, 30)
        Me.Button3.TabIndex = 665
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(515, 349)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 667
        Me.Label2.Text = "Tipo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Visible = False
        '
        'ComboBox_tipo
        '
        Me.ComboBox_tipo.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ComboBox_tipo.FontWeight = MetroFramework.MetroComboBoxWeight.Light
        Me.ComboBox_tipo.FormattingEnabled = True
        Me.ComboBox_tipo.ItemHeight = 23
        Me.ComboBox_tipo.Items.AddRange(New Object() {"ACTIVO", "PASIVO", "CAPITAL", "INGRESOS", "GASTOS", "COSTO DE VENTAS", "COSTO DE PRODUCCION", "CUENTAS DE ORDEN DEUDORAS", "CUENTAS DE ORDEN ACREEDORES"})
        Me.ComboBox_tipo.Location = New System.Drawing.Point(517, 363)
        Me.ComboBox_tipo.Name = "ComboBox_tipo"
        Me.ComboBox_tipo.Size = New System.Drawing.Size(215, 29)
        Me.ComboBox_tipo.TabIndex = 666
        Me.ComboBox_tipo.UseSelectable = True
        Me.ComboBox_tipo.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(71, 348)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 669
        Me.Label3.Text = "Clase"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MetroComboBox_clase
        '
        Me.MetroComboBox_clase.BackColor = System.Drawing.SystemColors.HotTrack
        Me.MetroComboBox_clase.FontWeight = MetroFramework.MetroComboBoxWeight.Light
        Me.MetroComboBox_clase.FormattingEnabled = True
        Me.MetroComboBox_clase.ItemHeight = 23
        Me.MetroComboBox_clase.Items.AddRange(New Object() {"ACTIVO", "PASIVO", "CAPITAL", "INGRESOS", "GASTOS", "COSTO DE VENTAS", "COSTO DE PRODUCCION", "CUENTAS DE ORDEN DEUDORAS", "CUENTAS DE ORDEN ACREEDORES"})
        Me.MetroComboBox_clase.Location = New System.Drawing.Point(71, 363)
        Me.MetroComboBox_clase.Name = "MetroComboBox_clase"
        Me.MetroComboBox_clase.Size = New System.Drawing.Size(215, 29)
        Me.MetroComboBox_clase.TabIndex = 668
        Me.MetroComboBox_clase.UseSelectable = True
        '
        'TextBox_NOMBRECUENTA
        '
        Me.TextBox_NOMBRECUENTA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox_NOMBRECUENTA.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_NOMBRECUENTA.ForeColor = System.Drawing.Color.Black
        Me.TextBox_NOMBRECUENTA.HintForeColor = System.Drawing.Color.Empty
        Me.TextBox_NOMBRECUENTA.HintText = ""
        Me.TextBox_NOMBRECUENTA.isPassword = False
        Me.TextBox_NOMBRECUENTA.LineFocusedColor = System.Drawing.Color.Blue
        Me.TextBox_NOMBRECUENTA.LineIdleColor = System.Drawing.Color.Black
        Me.TextBox_NOMBRECUENTA.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TextBox_NOMBRECUENTA.LineThickness = 2
        Me.TextBox_NOMBRECUENTA.Location = New System.Drawing.Point(75, 290)
        Me.TextBox_NOMBRECUENTA.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_NOMBRECUENTA.Name = "TextBox_NOMBRECUENTA"
        Me.TextBox_NOMBRECUENTA.Size = New System.Drawing.Size(657, 40)
        Me.TextBox_NOMBRECUENTA.TabIndex = 662
        Me.TextBox_NOMBRECUENTA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_cuentapuc
        '
        Me.TextBox_cuentapuc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox_cuentapuc.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_cuentapuc.ForeColor = System.Drawing.Color.Black
        Me.TextBox_cuentapuc.HintForeColor = System.Drawing.Color.Empty
        Me.TextBox_cuentapuc.HintText = ""
        Me.TextBox_cuentapuc.isPassword = False
        Me.TextBox_cuentapuc.LineFocusedColor = System.Drawing.Color.Blue
        Me.TextBox_cuentapuc.LineIdleColor = System.Drawing.Color.Black
        Me.TextBox_cuentapuc.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TextBox_cuentapuc.LineThickness = 2
        Me.TextBox_cuentapuc.Location = New System.Drawing.Point(75, 232)
        Me.TextBox_cuentapuc.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_cuentapuc.Name = "TextBox_cuentapuc"
        Me.TextBox_cuentapuc.Size = New System.Drawing.Size(176, 33)
        Me.TextBox_cuentapuc.TabIndex = 670
        Me.TextBox_cuentapuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadioButton_Activa
        '
        Me.RadioButton_Activa.AutoSize = True
        Me.RadioButton_Activa.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Activa.Location = New System.Drawing.Point(550, 243)
        Me.RadioButton_Activa.Name = "RadioButton_Activa"
        Me.RadioButton_Activa.Size = New System.Drawing.Size(73, 25)
        Me.RadioButton_Activa.TabIndex = 671
        Me.RadioButton_Activa.TabStop = True
        Me.RadioButton_Activa.Text = "Activa"
        Me.RadioButton_Activa.UseVisualStyleBackColor = True
        '
        'RadioButton_Inactiva
        '
        Me.RadioButton_Inactiva.AutoSize = True
        Me.RadioButton_Inactiva.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Inactiva.Location = New System.Drawing.Point(650, 243)
        Me.RadioButton_Inactiva.Name = "RadioButton_Inactiva"
        Me.RadioButton_Inactiva.Size = New System.Drawing.Size(84, 25)
        Me.RadioButton_Inactiva.TabIndex = 672
        Me.RadioButton_Inactiva.TabStop = True
        Me.RadioButton_Inactiva.Text = "Inactiva"
        Me.RadioButton_Inactiva.UseVisualStyleBackColor = True
        '
        'Form_puc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1000, 614)
        Me.Controls.Add(Me.Panel_grid_puc)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel_botones_puc)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.Panel_filtro)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ComboBox_niif)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MetroComboBox_clase)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox_tipo)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.ComboBox_naturaleza)
        Me.Controls.Add(Me.TextBox_NOMBRECUENTA)
        Me.Controls.Add(Me.TextBox_cuentapuc)
        Me.Controls.Add(Me.Label51)
        Me.Controls.Add(Me.TextBox_descripcion)
        Me.Controls.Add(Me.RadioButton_Inactiva)
        Me.Controls.Add(Me.RadioButton_Activa)
        Me.Controls.Add(Me.Label17)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_puc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel_grid_puc.ResumeLayout(False)
        CType(Me.MetroGrid_puc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_botones_puc.ResumeLayout(False)
        Me.Panel_filtro.ResumeLayout(False)
        Me.Panel_filtro.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ContextMenuStrip_LOAD_PUC.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_descripcion As TextBox
    Friend WithEvents Label51 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents ComboBox_naturaleza As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label43 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Button_filtro_cuentas_puc As Button
    Friend WithEvents Panel_botones_puc As Panel
    Friend WithEvents Button_crear_cuentaPUC As Button
    Friend WithEvents Button_consultarcuenta As Button
    Friend WithEvents MetroGrid_puc As MetroFramework.Controls.MetroGrid
    Friend WithEvents Label40 As Label
    Friend WithEvents Timer_load_tipo_doc_parametros As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents Button_almacen As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Timer_LOAD_COMPROBANTES As Timer
    Friend WithEvents Timer_clasificar As Timer
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Panel_filtro As Panel
    Friend WithEvents Label44 As Label
    Friend WithEvents Panel_grid_puc As Panel
    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents BunifuElipse4 As ns1.BunifuElipse
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox_niif As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents ContextMenuStrip_LOAD_PUC As ContextMenuStrip
    Friend WithEvents FiltrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BsucarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PorCódigoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PorNombreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfigurarCuentasDeContabilidadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarTodasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuentasDeActivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PatrimonioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GastosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GastosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CostosDeVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CostosDeOperacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents MetroComboBox_clase As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox_tipo As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Textbox_buscar_cta As ns1.BunifuMaterialTextbox
    Friend WithEvents TextBox_NOMBRECUENTA As ns1.BunifuMaterialTextbox
    Friend WithEvents TextBox_cuentapuc As ns1.BunifuMaterialTextbox
    Friend WithEvents RadioButton_Inactiva As RadioButton
    Friend WithEvents RadioButton_Activa As RadioButton
End Class
