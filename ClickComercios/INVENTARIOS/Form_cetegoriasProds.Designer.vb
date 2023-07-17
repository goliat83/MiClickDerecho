<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_categorias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_categorias))
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button_consultar = New System.Windows.Forms.Button()
        Me.ImageList_botones = New System.Windows.Forms.ImageList(Me.components)
        Me.Button_eliminar = New System.Windows.Forms.Button()
        Me.button_crear = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Textbox_categoria = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BunifuElipse2 = New ns1.BunifuElipse(Me.components)
        Me.datagridcategorias = New MetroFramework.Controls.MetroGrid()
        Me.Timer_load = New System.Windows.Forms.Timer(Me.components)
        Me.Background_GRID = New System.ComponentModel.BackgroundWorker()
        Me.ContextMenuStrip_LOAD_PUC = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FiltrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsarPorDefectoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigurarCuentasDeContabilidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RadioButton_PRODS = New System.Windows.Forms.RadioButton()
        Me.RadioButton_INS = New System.Windows.Forms.RadioButton()
        Me.RadioButton_PROC = New System.Windows.Forms.RadioButton()
        Me.RadioButton_SERV = New System.Windows.Forms.RadioButton()
        Me.BunifuElipse3 = New ns1.BunifuElipse(Me.components)
        Me.BunifuElipse4 = New ns1.BunifuElipse(Me.components)
        Me.BunifuElipse5 = New ns1.BunifuElipse(Me.components)
        Me.BunifuElipse6 = New ns1.BunifuElipse(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_cancelar = New System.Windows.Forms.Button()
        Me.Btn_guardar = New System.Windows.Forms.Button()
        Me.BunifuElipse7 = New ns1.BunifuElipse(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button_cat_ventas = New System.Windows.Forms.Button()
        Me.label_cuenta_cat_inv = New ns1.BunifuMaterialTextbox()
        Me.Button_cat_inv = New System.Windows.Forms.Button()
        Me.label_cuenta_cat_ing = New ns1.BunifuMaterialTextbox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.datagridcategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip_LOAD_PUC.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Button_consultar)
        Me.Panel1.Controls.Add(Me.Button_eliminar)
        Me.Panel1.Controls.Add(Me.button_crear)
        Me.Panel1.Location = New System.Drawing.Point(472, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(264, 43)
        Me.Panel1.TabIndex = 387
        '
        'Button_consultar
        '
        Me.Button_consultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_consultar.BackColor = System.Drawing.Color.Transparent
        Me.Button_consultar.BackgroundImage = CType(resources.GetObject("Button_consultar.BackgroundImage"), System.Drawing.Image)
        Me.Button_consultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_consultar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_consultar.FlatAppearance.BorderSize = 0
        Me.Button_consultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button_consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.Button_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_consultar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_consultar.ForeColor = System.Drawing.Color.White
        Me.Button_consultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_consultar.ImageKey = "Openfileicon.png"
        Me.Button_consultar.ImageList = Me.ImageList_botones
        Me.Button_consultar.Location = New System.Drawing.Point(92, 0)
        Me.Button_consultar.Name = "Button_consultar"
        Me.Button_consultar.Size = New System.Drawing.Size(82, 43)
        Me.Button_consultar.TabIndex = 302
        Me.Button_consultar.Text = "Consultar"
        Me.Button_consultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_consultar.UseVisualStyleBackColor = False
        '
        'ImageList_botones
        '
        Me.ImageList_botones.ImageStream = CType(resources.GetObject("ImageList_botones.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_botones.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_botones.Images.SetKeyName(0, "agregar.png")
        Me.ImageList_botones.Images.SetKeyName(1, "Openfileicon.png")
        Me.ImageList_botones.Images.SetKeyName(2, "export_icon.png")
        Me.ImageList_botones.Images.SetKeyName(3, "Logout.png")
        Me.ImageList_botones.Images.SetKeyName(4, "ok-trans.png")
        Me.ImageList_botones.Images.SetKeyName(5, "delete_x.png")
        Me.ImageList_botones.Images.SetKeyName(6, "inventarioss.png")
        Me.ImageList_botones.Images.SetKeyName(7, "add_row_icon.png")
        Me.ImageList_botones.Images.SetKeyName(8, "delete_row.png")
        Me.ImageList_botones.Images.SetKeyName(9, "QUITAR.png")
        Me.ImageList_botones.Images.SetKeyName(10, "DeleteSelected.png")
        Me.ImageList_botones.Images.SetKeyName(11, "backspace1.png")
        Me.ImageList_botones.Images.SetKeyName(12, "diskette.png")
        '
        'Button_eliminar
        '
        Me.Button_eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_eliminar.BackColor = System.Drawing.Color.Transparent
        Me.Button_eliminar.BackgroundImage = CType(resources.GetObject("Button_eliminar.BackgroundImage"), System.Drawing.Image)
        Me.Button_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_eliminar.FlatAppearance.BorderSize = 0
        Me.Button_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.Button_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_eliminar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_eliminar.ForeColor = System.Drawing.Color.White
        Me.Button_eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_eliminar.ImageKey = "DeleteSelected.png"
        Me.Button_eliminar.ImageList = Me.ImageList_botones
        Me.Button_eliminar.Location = New System.Drawing.Point(177, 0)
        Me.Button_eliminar.Name = "Button_eliminar"
        Me.Button_eliminar.Size = New System.Drawing.Size(81, 43)
        Me.Button_eliminar.TabIndex = 300
        Me.Button_eliminar.Text = "Eliminar"
        Me.Button_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_eliminar.UseVisualStyleBackColor = False
        '
        'button_crear
        '
        Me.button_crear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button_crear.BackColor = System.Drawing.Color.Transparent
        Me.button_crear.BackgroundImage = CType(resources.GetObject("button_crear.BackgroundImage"), System.Drawing.Image)
        Me.button_crear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button_crear.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.button_crear.FlatAppearance.BorderSize = 0
        Me.button_crear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.button_crear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.button_crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_crear.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_crear.ForeColor = System.Drawing.Color.White
        Me.button_crear.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.button_crear.ImageKey = "agregar.png"
        Me.button_crear.ImageList = Me.ImageList_botones
        Me.button_crear.Location = New System.Drawing.Point(18, 0)
        Me.button_crear.Name = "button_crear"
        Me.button_crear.Size = New System.Drawing.Size(70, 43)
        Me.button_crear.TabIndex = 295
        Me.button_crear.Text = "Crear"
        Me.button_crear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.button_crear.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(32, 284)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 15)
        Me.Label7.TabIndex = 755
        Me.Label7.Text = "Concepto de Inventarios"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(37, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 15)
        Me.Label3.TabIndex = 748
        Me.Label3.Text = "Tipo de Categoría"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Textbox_categoria
        '
        Me.Textbox_categoria.BackColor = System.Drawing.Color.White
        Me.Textbox_categoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Textbox_categoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Textbox_categoria.ForeColor = System.Drawing.Color.Black
        Me.Textbox_categoria.Location = New System.Drawing.Point(38, 104)
        Me.Textbox_categoria.MaxLength = 32
        Me.Textbox_categoria.Name = "Textbox_categoria"
        Me.Textbox_categoria.Size = New System.Drawing.Size(364, 26)
        Me.Textbox_categoria.TabIndex = 390
        Me.Textbox_categoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(38, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(136, 15)
        Me.Label11.TabIndex = 392
        Me.Label11.Text = "Nombre de la Categoría"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 5
        Me.BunifuElipse2.TargetControl = Me.datagridcategorias
        '
        'datagridcategorias
        '
        Me.datagridcategorias.AllowUserToAddRows = False
        Me.datagridcategorias.AllowUserToDeleteRows = False
        Me.datagridcategorias.AllowUserToOrderColumns = True
        Me.datagridcategorias.AllowUserToResizeRows = False
        Me.datagridcategorias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datagridcategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridcategorias.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.datagridcategorias.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datagridcategorias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.datagridcategorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridcategorias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.datagridcategorias.ColumnHeadersHeight = 30
        Me.datagridcategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridcategorias.DefaultCellStyle = DataGridViewCellStyle11
        Me.datagridcategorias.EnableHeadersVisualStyles = False
        Me.datagridcategorias.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.datagridcategorias.GridColor = System.Drawing.Color.AliceBlue
        Me.datagridcategorias.Location = New System.Drawing.Point(12, 72)
        Me.datagridcategorias.MultiSelect = False
        Me.datagridcategorias.Name = "datagridcategorias"
        Me.datagridcategorias.ReadOnly = True
        Me.datagridcategorias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridcategorias.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.datagridcategorias.RowHeadersVisible = False
        Me.datagridcategorias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridcategorias.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue
        Me.datagridcategorias.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagridcategorias.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.datagridcategorias.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.datagridcategorias.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.datagridcategorias.RowTemplate.Height = 30
        Me.datagridcategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridcategorias.Size = New System.Drawing.Size(727, 363)
        Me.datagridcategorias.TabIndex = 769
        '
        'Timer_load
        '
        Me.Timer_load.Interval = 150
        '
        'Background_GRID
        '
        '
        'ContextMenuStrip_LOAD_PUC
        '
        Me.ContextMenuStrip_LOAD_PUC.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FiltrarToolStripMenuItem, Me.UsarPorDefectoToolStripMenuItem, Me.ConfigurarCuentasDeContabilidadToolStripMenuItem})
        Me.ContextMenuStrip_LOAD_PUC.Name = "ContextMenuStrip_LOAD_PUC"
        Me.ContextMenuStrip_LOAD_PUC.Size = New System.Drawing.Size(338, 82)
        '
        'FiltrarToolStripMenuItem
        '
        Me.FiltrarToolStripMenuItem.BackColor = System.Drawing.Color.Lavender
        Me.FiltrarToolStripMenuItem.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.buttonborder2
        Me.FiltrarToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FiltrarToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.FiltrarToolStripMenuItem.Image = Global.MiClickDerecho.My.Resources.Resources.filtering
        Me.FiltrarToolStripMenuItem.Name = "FiltrarToolStripMenuItem"
        Me.FiltrarToolStripMenuItem.Size = New System.Drawing.Size(337, 26)
        Me.FiltrarToolStripMenuItem.Text = "Filtrar Cuentas de Ingreso"
        '
        'UsarPorDefectoToolStripMenuItem
        '
        Me.UsarPorDefectoToolStripMenuItem.BackColor = System.Drawing.Color.Lavender
        Me.UsarPorDefectoToolStripMenuItem.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.buttonborder2
        Me.UsarPorDefectoToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UsarPorDefectoToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.UsarPorDefectoToolStripMenuItem.Image = Global.MiClickDerecho.My.Resources.Resources.image013
        Me.UsarPorDefectoToolStripMenuItem.Name = "UsarPorDefectoToolStripMenuItem"
        Me.UsarPorDefectoToolStripMenuItem.Size = New System.Drawing.Size(337, 26)
        Me.UsarPorDefectoToolStripMenuItem.Text = "Usar Cuenta por Defecto"
        '
        'ConfigurarCuentasDeContabilidadToolStripMenuItem
        '
        Me.ConfigurarCuentasDeContabilidadToolStripMenuItem.BackColor = System.Drawing.Color.Lavender
        Me.ConfigurarCuentasDeContabilidadToolStripMenuItem.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.buttonborder2
        Me.ConfigurarCuentasDeContabilidadToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ConfigurarCuentasDeContabilidadToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.ConfigurarCuentasDeContabilidadToolStripMenuItem.Image = Global.MiClickDerecho.My.Resources.Resources.accounter2512
        Me.ConfigurarCuentasDeContabilidadToolStripMenuItem.Name = "ConfigurarCuentasDeContabilidadToolStripMenuItem"
        Me.ConfigurarCuentasDeContabilidadToolStripMenuItem.Size = New System.Drawing.Size(337, 26)
        Me.ConfigurarCuentasDeContabilidadToolStripMenuItem.Text = "Configurar Cuentas de Contabilidad"
        '
        'RadioButton_PRODS
        '
        Me.RadioButton_PRODS.AutoSize = True
        Me.RadioButton_PRODS.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton_PRODS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_PRODS.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_PRODS.ForeColor = System.Drawing.Color.Black
        Me.RadioButton_PRODS.Location = New System.Drawing.Point(44, 198)
        Me.RadioButton_PRODS.Name = "RadioButton_PRODS"
        Me.RadioButton_PRODS.Padding = New System.Windows.Forms.Padding(5)
        Me.RadioButton_PRODS.Size = New System.Drawing.Size(107, 30)
        Me.RadioButton_PRODS.TabIndex = 765
        Me.RadioButton_PRODS.TabStop = True
        Me.RadioButton_PRODS.Text = "PRODUCTOS"
        Me.RadioButton_PRODS.UseVisualStyleBackColor = False
        '
        'RadioButton_INS
        '
        Me.RadioButton_INS.AutoSize = True
        Me.RadioButton_INS.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton_INS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_INS.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_INS.ForeColor = System.Drawing.Color.Black
        Me.RadioButton_INS.Location = New System.Drawing.Point(175, 198)
        Me.RadioButton_INS.Name = "RadioButton_INS"
        Me.RadioButton_INS.Padding = New System.Windows.Forms.Padding(5)
        Me.RadioButton_INS.Size = New System.Drawing.Size(90, 30)
        Me.RadioButton_INS.TabIndex = 766
        Me.RadioButton_INS.TabStop = True
        Me.RadioButton_INS.Text = "INSUMOS"
        Me.RadioButton_INS.UseVisualStyleBackColor = False
        '
        'RadioButton_PROC
        '
        Me.RadioButton_PROC.AutoSize = True
        Me.RadioButton_PROC.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton_PROC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_PROC.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_PROC.ForeColor = System.Drawing.Color.Black
        Me.RadioButton_PROC.Location = New System.Drawing.Point(288, 198)
        Me.RadioButton_PROC.Name = "RadioButton_PROC"
        Me.RadioButton_PROC.Padding = New System.Windows.Forms.Padding(5)
        Me.RadioButton_PROC.Size = New System.Drawing.Size(114, 30)
        Me.RadioButton_PROC.TabIndex = 767
        Me.RadioButton_PROC.TabStop = True
        Me.RadioButton_PROC.Text = "PROCESADOS"
        Me.RadioButton_PROC.UseVisualStyleBackColor = False
        '
        'RadioButton_SERV
        '
        Me.RadioButton_SERV.AutoSize = True
        Me.RadioButton_SERV.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton_SERV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_SERV.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_SERV.ForeColor = System.Drawing.Color.Black
        Me.RadioButton_SERV.Location = New System.Drawing.Point(435, 198)
        Me.RadioButton_SERV.Name = "RadioButton_SERV"
        Me.RadioButton_SERV.Padding = New System.Windows.Forms.Padding(5)
        Me.RadioButton_SERV.Size = New System.Drawing.Size(96, 30)
        Me.RadioButton_SERV.TabIndex = 768
        Me.RadioButton_SERV.TabStop = True
        Me.RadioButton_SERV.Text = "SERVICIOS"
        Me.RadioButton_SERV.UseVisualStyleBackColor = False
        '
        'BunifuElipse3
        '
        Me.BunifuElipse3.ElipseRadius = 5
        Me.BunifuElipse3.TargetControl = Me.RadioButton_INS
        '
        'BunifuElipse4
        '
        Me.BunifuElipse4.ElipseRadius = 5
        Me.BunifuElipse4.TargetControl = Me.RadioButton_PROC
        '
        'BunifuElipse5
        '
        Me.BunifuElipse5.ElipseRadius = 5
        Me.BunifuElipse5.TargetControl = Me.RadioButton_PRODS
        '
        'BunifuElipse6
        '
        Me.BunifuElipse6.ElipseRadius = 5
        Me.BunifuElipse6.TargetControl = Me.RadioButton_SERV
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(15, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(388, 40)
        Me.Label2.TabIndex = 770
        Me.Label2.Text = "Categorías del Inventario"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Btn_cancelar
        '
        Me.Btn_cancelar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_cancelar.BackgroundImage = CType(resources.GetObject("Btn_cancelar.BackgroundImage"), System.Drawing.Image)
        Me.Btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Btn_cancelar.FlatAppearance.BorderSize = 0
        Me.Btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.Btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_cancelar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_cancelar.ForeColor = System.Drawing.Color.White
        Me.Btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_cancelar.ImageKey = "backspace1.png"
        Me.Btn_cancelar.ImageList = Me.ImageList_botones
        Me.Btn_cancelar.Location = New System.Drawing.Point(605, 104)
        Me.Btn_cancelar.Name = "Btn_cancelar"
        Me.Btn_cancelar.Size = New System.Drawing.Size(113, 43)
        Me.Btn_cancelar.TabIndex = 394
        Me.Btn_cancelar.Text = "Regresar"
        Me.Btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_cancelar.UseVisualStyleBackColor = False
        '
        'Btn_guardar
        '
        Me.Btn_guardar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_guardar.BackgroundImage = CType(resources.GetObject("Btn_guardar.BackgroundImage"), System.Drawing.Image)
        Me.Btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_guardar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Btn_guardar.FlatAppearance.BorderSize = 0
        Me.Btn_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_guardar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_guardar.ForeColor = System.Drawing.Color.White
        Me.Btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_guardar.ImageKey = "diskette.png"
        Me.Btn_guardar.ImageList = Me.ImageList_botones
        Me.Btn_guardar.Location = New System.Drawing.Point(605, 156)
        Me.Btn_guardar.Name = "Btn_guardar"
        Me.Btn_guardar.Size = New System.Drawing.Size(113, 43)
        Me.Btn_guardar.TabIndex = 393
        Me.Btn_guardar.Text = "Guardar"
        Me.Btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_guardar.UseVisualStyleBackColor = False
        '
        'BunifuElipse7
        '
        Me.BunifuElipse7.ElipseRadius = 5
        Me.BunifuElipse7.TargetControl = Me.Label2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(32, 347)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 15)
        Me.Label5.TabIndex = 751
        Me.Label5.Text = "Concepto de Ingresos"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Visible = False
        '
        'Button_cat_ventas
        '
        Me.Button_cat_ventas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_cat_ventas.BackColor = System.Drawing.Color.Transparent
        Me.Button_cat_ventas.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.search_icon
        Me.Button_cat_ventas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_cat_ventas.ContextMenuStrip = Me.ContextMenuStrip_LOAD_PUC
        Me.Button_cat_ventas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_cat_ventas.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_cat_ventas.FlatAppearance.BorderSize = 0
        Me.Button_cat_ventas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button_cat_ventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.Button_cat_ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_cat_ventas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Button_cat_ventas.ForeColor = System.Drawing.Color.White
        Me.Button_cat_ventas.Location = New System.Drawing.Point(531, 360)
        Me.Button_cat_ventas.Name = "Button_cat_ventas"
        Me.Button_cat_ventas.Size = New System.Drawing.Size(31, 30)
        Me.Button_cat_ventas.TabIndex = 303
        Me.Button_cat_ventas.UseVisualStyleBackColor = False
        Me.Button_cat_ventas.Visible = False
        '
        'label_cuenta_cat_inv
        '
        Me.label_cuenta_cat_inv.BackColor = System.Drawing.Color.White
        Me.label_cuenta_cat_inv.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.label_cuenta_cat_inv.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_cuenta_cat_inv.ForeColor = System.Drawing.Color.Black
        Me.label_cuenta_cat_inv.HintForeColor = System.Drawing.Color.Empty
        Me.label_cuenta_cat_inv.HintText = ""
        Me.label_cuenta_cat_inv.isPassword = False
        Me.label_cuenta_cat_inv.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label_cuenta_cat_inv.LineIdleColor = System.Drawing.Color.Black
        Me.label_cuenta_cat_inv.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label_cuenta_cat_inv.LineThickness = 2
        Me.label_cuenta_cat_inv.Location = New System.Drawing.Point(32, 301)
        Me.label_cuenta_cat_inv.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.label_cuenta_cat_inv.Name = "label_cuenta_cat_inv"
        Me.label_cuenta_cat_inv.Size = New System.Drawing.Size(494, 26)
        Me.label_cuenta_cat_inv.TabIndex = 868
        Me.label_cuenta_cat_inv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.label_cuenta_cat_inv.Visible = False
        '
        'Button_cat_inv
        '
        Me.Button_cat_inv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_cat_inv.BackColor = System.Drawing.Color.Transparent
        Me.Button_cat_inv.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.search_icon
        Me.Button_cat_inv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_cat_inv.ContextMenuStrip = Me.ContextMenuStrip_LOAD_PUC
        Me.Button_cat_inv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_cat_inv.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_cat_inv.FlatAppearance.BorderSize = 0
        Me.Button_cat_inv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button_cat_inv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.Button_cat_inv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_cat_inv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Button_cat_inv.ForeColor = System.Drawing.Color.White
        Me.Button_cat_inv.Location = New System.Drawing.Point(531, 297)
        Me.Button_cat_inv.Name = "Button_cat_inv"
        Me.Button_cat_inv.Size = New System.Drawing.Size(30, 30)
        Me.Button_cat_inv.TabIndex = 869
        Me.Button_cat_inv.UseVisualStyleBackColor = False
        Me.Button_cat_inv.Visible = False
        '
        'label_cuenta_cat_ing
        '
        Me.label_cuenta_cat_ing.BackColor = System.Drawing.Color.White
        Me.label_cuenta_cat_ing.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.label_cuenta_cat_ing.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_cuenta_cat_ing.ForeColor = System.Drawing.Color.Black
        Me.label_cuenta_cat_ing.HintForeColor = System.Drawing.Color.Empty
        Me.label_cuenta_cat_ing.HintText = ""
        Me.label_cuenta_cat_ing.isPassword = False
        Me.label_cuenta_cat_ing.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label_cuenta_cat_ing.LineIdleColor = System.Drawing.Color.Black
        Me.label_cuenta_cat_ing.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label_cuenta_cat_ing.LineThickness = 2
        Me.label_cuenta_cat_ing.Location = New System.Drawing.Point(32, 364)
        Me.label_cuenta_cat_ing.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.label_cuenta_cat_ing.Name = "label_cuenta_cat_ing"
        Me.label_cuenta_cat_ing.Size = New System.Drawing.Size(494, 26)
        Me.label_cuenta_cat_ing.TabIndex = 870
        Me.label_cuenta_cat_ing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.label_cuenta_cat_ing.Visible = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.ImageKey = "DeleteSelected.png"
        Me.Button1.ImageList = Me.ImageList_botones
        Me.Button1.Location = New System.Drawing.Point(605, 209)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 43)
        Me.Button1.TabIndex = 303
        Me.Button1.Text = "Eliminar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.ContextMenuStrip = Me.ContextMenuStrip_LOAD_PUC
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(570, 297)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(30, 30)
        Me.Button2.TabIndex = 872
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
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
        Me.Button3.Location = New System.Drawing.Point(570, 360)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(31, 30)
        Me.Button3.TabIndex = 871
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'Form_categorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(751, 442)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.label_cuenta_cat_ing)
        Me.Controls.Add(Me.Button_cat_inv)
        Me.Controls.Add(Me.RadioButton_SERV)
        Me.Controls.Add(Me.RadioButton_PROC)
        Me.Controls.Add(Me.RadioButton_INS)
        Me.Controls.Add(Me.RadioButton_PRODS)
        Me.Controls.Add(Me.Button_cat_ventas)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Btn_cancelar)
        Me.Controls.Add(Me.Btn_guardar)
        Me.Controls.Add(Me.Textbox_categoria)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.label_cuenta_cat_inv)
        Me.Controls.Add(Me.datagridcategorias)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(673, 442)
        Me.Name = "Form_categorias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        CType(Me.datagridcategorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip_LOAD_PUC.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_cancelar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button_eliminar As Button
    Friend WithEvents button_crear As Button
    Friend WithEvents Textbox_categoria As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Btn_guardar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button_consultar As Button
    Friend WithEvents BunifuElipse2 As ns1.BunifuElipse
    Friend WithEvents Timer_load As Timer
    Friend WithEvents Background_GRID As System.ComponentModel.BackgroundWorker
    Friend WithEvents RadioButton_PROC As RadioButton
    Friend WithEvents RadioButton_INS As RadioButton
    Friend WithEvents RadioButton_PRODS As RadioButton
    Friend WithEvents RadioButton_SERV As RadioButton
    Friend WithEvents BunifuElipse3 As ns1.BunifuElipse
    Friend WithEvents BunifuElipse4 As ns1.BunifuElipse
    Friend WithEvents BunifuElipse5 As ns1.BunifuElipse
    Friend WithEvents BunifuElipse6 As ns1.BunifuElipse
    Friend WithEvents ContextMenuStrip_LOAD_PUC As ContextMenuStrip
    Friend WithEvents FiltrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents datagridcategorias As MetroFramework.Controls.MetroGrid
    Friend WithEvents Label2 As Label
    Friend WithEvents UsarPorDefectoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfigurarCuentasDeContabilidadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BunifuElipse7 As ns1.BunifuElipse
    Friend WithEvents Button_cat_ventas As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents label_cuenta_cat_inv As ns1.BunifuMaterialTextbox
    Friend WithEvents Button_cat_inv As Button
    Friend WithEvents ImageList_botones As ImageList
    Friend WithEvents label_cuenta_cat_ing As ns1.BunifuMaterialTextbox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
