<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_bodega
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_bodega))
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer_prod_data = New System.Windows.Forms.Timer(Me.components)
        Me.ComboBoxProds = New System.Windows.Forms.ComboBox()
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ComboBoxInfoBodega = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.RadioButton_entradaysalidas = New System.Windows.Forms.RadioButton()
        Me.RadioButton_saldos = New System.Windows.Forms.RadioButton()
        Me.BunifuCheckbox_vence = New ns1.BunifuCheckbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuElipse2 = New ns1.BunifuElipse(Me.components)
        Me.datagrid = New MetroFramework.Controls.MetroGrid()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ComboBoX_fechaMES = New System.Windows.Forms.ComboBox()
        Me.TextBox_total = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox_tipodoc = New System.Windows.Forms.ComboBox()
        Me.MetroGrid_pdf = New MetroFramework.Controls.MetroGrid()
        Me.RadioButton_faltantes = New System.Windows.Forms.RadioButton()
        Me.CheckBox_buscar_prod = New System.Windows.Forms.CheckBox()
        Me.CheckBox_tipodoc = New System.Windows.Forms.CheckBox()
        Me.BunifuElipse3 = New ns1.BunifuElipse(Me.components)
        Me.BunifuElipse4 = New ns1.BunifuElipse(Me.components)
        Me.BunifuElipse5 = New ns1.BunifuElipse(Me.components)
        Me.BunifuCards_exportar = New ns1.BunifuCards()
        Me.Button_exportar_BODEGA = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button_cerrar_exportar = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.RadioButton_xls = New System.Windows.Forms.RadioButton()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.RadioButton_normal = New System.Windows.Forms.RadioButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RadioButton_pos = New System.Windows.Forms.RadioButton()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Button_exportar = New System.Windows.Forms.Button()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox_precios = New System.Windows.Forms.ComboBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.NumericUpDown_anno = New System.Windows.Forms.NumericUpDown()
        CType(Me.datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetroGrid_pdf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards_exportar.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_anno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ShowAlways = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Archivos Adjuntos"
        '
        'Timer_prod_data
        '
        Me.Timer_prod_data.Interval = 300
        '
        'ComboBoxProds
        '
        Me.ComboBoxProds.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxProds.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxProds.BackColor = System.Drawing.Color.SteelBlue
        Me.ComboBoxProds.Enabled = False
        Me.ComboBoxProds.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxProds.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.ComboBoxProds.ForeColor = System.Drawing.Color.White
        Me.ComboBoxProds.FormattingEnabled = True
        Me.ComboBoxProds.Location = New System.Drawing.Point(18, 131)
        Me.ComboBoxProds.Name = "ComboBoxProds"
        Me.ComboBoxProds.Size = New System.Drawing.Size(344, 23)
        Me.ComboBoxProds.TabIndex = 390
        '
        'ToolTip2
        '
        Me.ToolTip2.IsBalloon = True
        Me.ToolTip2.ShowAlways = True
        Me.ToolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip2.ToolTipTitle = "Archivos Adjuntos"
        '
        'Timer1
        '
        Me.Timer1.Interval = 300
        '
        'ComboBoxInfoBodega
        '
        Me.ComboBoxInfoBodega.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxInfoBodega.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxInfoBodega.BackColor = System.Drawing.Color.SteelBlue
        Me.ComboBoxInfoBodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxInfoBodega.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxInfoBodega.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.ComboBoxInfoBodega.ForeColor = System.Drawing.Color.White
        Me.ComboBoxInfoBodega.FormattingEnabled = True
        Me.ComboBoxInfoBodega.Location = New System.Drawing.Point(297, 85)
        Me.ComboBoxInfoBodega.Name = "ComboBoxInfoBodega"
        Me.ComboBoxInfoBodega.Size = New System.Drawing.Size(247, 23)
        Me.ComboBoxInfoBodega.TabIndex = 425
        '
        'Label19
        '
        Me.Label19.AllowDrop = True
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(296, 69)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(49, 15)
        Me.Label19.TabIndex = 540
        Me.Label19.Text = "Bodega"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadioButton_entradaysalidas
        '
        Me.RadioButton_entradaysalidas.AutoSize = True
        Me.RadioButton_entradaysalidas.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_entradaysalidas.Location = New System.Drawing.Point(395, 40)
        Me.RadioButton_entradaysalidas.Name = "RadioButton_entradaysalidas"
        Me.RadioButton_entradaysalidas.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.RadioButton_entradaysalidas.Size = New System.Drawing.Size(174, 27)
        Me.RadioButton_entradaysalidas.TabIndex = 544
        Me.RadioButton_entradaysalidas.TabStop = True
        Me.RadioButton_entradaysalidas.Text = "Mostrar Kardex"
        Me.RadioButton_entradaysalidas.UseVisualStyleBackColor = True
        '
        'RadioButton_saldos
        '
        Me.RadioButton_saldos.AutoSize = True
        Me.RadioButton_saldos.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_saldos.Location = New System.Drawing.Point(20, 40)
        Me.RadioButton_saldos.Name = "RadioButton_saldos"
        Me.RadioButton_saldos.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.RadioButton_saldos.Size = New System.Drawing.Size(168, 27)
        Me.RadioButton_saldos.TabIndex = 545
        Me.RadioButton_saldos.TabStop = True
        Me.RadioButton_saldos.Text = "Mostrar Saldos"
        Me.RadioButton_saldos.UseVisualStyleBackColor = True
        '
        'BunifuCheckbox_vence
        '
        Me.BunifuCheckbox_vence.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.BunifuCheckbox_vence.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.BunifuCheckbox_vence.Checked = False
        Me.BunifuCheckbox_vence.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuCheckbox_vence.ForeColor = System.Drawing.Color.White
        Me.BunifuCheckbox_vence.Location = New System.Drawing.Point(565, 87)
        Me.BunifuCheckbox_vence.Name = "BunifuCheckbox_vence"
        Me.BunifuCheckbox_vence.Size = New System.Drawing.Size(20, 20)
        Me.BunifuCheckbox_vence.TabIndex = 600
        '
        'Label3
        '
        Me.Label3.AllowDrop = True
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(588, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 15)
        Me.Label3.TabIndex = 601
        Me.Label3.Text = "Incluir Lote y Vencimiento"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 5
        Me.BunifuElipse2.TargetControl = Me.datagrid
        '
        'datagrid
        '
        Me.datagrid.AllowUserToAddRows = False
        Me.datagrid.AllowUserToDeleteRows = False
        Me.datagrid.AllowUserToOrderColumns = True
        Me.datagrid.AllowUserToResizeRows = False
        Me.datagrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.datagrid.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.datagrid.ColumnHeadersHeight = 28
        Me.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid.DefaultCellStyle = DataGridViewCellStyle14
        Me.datagrid.EnableHeadersVisualStyles = False
        Me.datagrid.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.datagrid.GridColor = System.Drawing.Color.AliceBlue
        Me.datagrid.Location = New System.Drawing.Point(18, 161)
        Me.datagrid.Name = "datagrid"
        Me.datagrid.ReadOnly = True
        Me.datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.datagrid.RowHeadersVisible = False
        Me.datagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue
        Me.datagrid.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.datagrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.datagrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrid.Size = New System.Drawing.Size(970, 357)
        Me.datagrid.TabIndex = 602
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Transparent
        Me.Button3.Image = Global.MiClickDerecho.My.Resources.Resources.viewicone
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(810, 108)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 45)
        Me.Button3.TabIndex = 599
        Me.Button3.Text = "Buscar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ComboBoX_fechaMES
        '
        Me.ComboBoX_fechaMES.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoX_fechaMES.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoX_fechaMES.BackColor = System.Drawing.Color.SteelBlue
        Me.ComboBoX_fechaMES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoX_fechaMES.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoX_fechaMES.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.ComboBoX_fechaMES.ForeColor = System.Drawing.Color.White
        Me.ComboBoX_fechaMES.FormattingEnabled = True
        Me.ComboBoX_fechaMES.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.ComboBoX_fechaMES.Location = New System.Drawing.Point(108, 85)
        Me.ComboBoX_fechaMES.Name = "ComboBoX_fechaMES"
        Me.ComboBoX_fechaMES.Size = New System.Drawing.Size(178, 23)
        Me.ComboBoX_fechaMES.TabIndex = 603
        Me.ComboBoX_fechaMES.Visible = False
        '
        'TextBox_total
        '
        Me.TextBox_total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_total.BackColor = System.Drawing.Color.AliceBlue
        Me.TextBox_total.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_total.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold)
        Me.TextBox_total.ForeColor = System.Drawing.Color.Black
        Me.TextBox_total.Location = New System.Drawing.Point(626, 536)
        Me.TextBox_total.Name = "TextBox_total"
        Me.TextBox_total.Size = New System.Drawing.Size(172, 20)
        Me.TextBox_total.TabIndex = 604
        Me.TextBox_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AllowDrop = True
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(107, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 15)
        Me.Label4.TabIndex = 607
        Me.Label4.Text = "Periodo"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label4.Visible = False
        '
        'ComboBox_tipodoc
        '
        Me.ComboBox_tipodoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox_tipodoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox_tipodoc.BackColor = System.Drawing.Color.SteelBlue
        Me.ComboBox_tipodoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_tipodoc.Enabled = False
        Me.ComboBox_tipodoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox_tipodoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.ComboBox_tipodoc.ForeColor = System.Drawing.Color.White
        Me.ComboBox_tipodoc.FormattingEnabled = True
        Me.ComboBox_tipodoc.Location = New System.Drawing.Point(381, 131)
        Me.ComboBox_tipodoc.Name = "ComboBox_tipodoc"
        Me.ComboBox_tipodoc.Size = New System.Drawing.Size(347, 23)
        Me.ComboBox_tipodoc.TabIndex = 608
        Me.ComboBox_tipodoc.Visible = False
        '
        'MetroGrid_pdf
        '
        Me.MetroGrid_pdf.AllowUserToAddRows = False
        Me.MetroGrid_pdf.AllowUserToDeleteRows = False
        Me.MetroGrid_pdf.AllowUserToOrderColumns = True
        Me.MetroGrid_pdf.AllowUserToResizeRows = False
        Me.MetroGrid_pdf.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroGrid_pdf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.MetroGrid_pdf.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.MetroGrid_pdf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid_pdf.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.MetroGrid_pdf.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid_pdf.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.MetroGrid_pdf.ColumnHeadersHeight = 28
        Me.MetroGrid_pdf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid_pdf.DefaultCellStyle = DataGridViewCellStyle17
        Me.MetroGrid_pdf.EnableHeadersVisualStyles = False
        Me.MetroGrid_pdf.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid_pdf.GridColor = System.Drawing.Color.DodgerBlue
        Me.MetroGrid_pdf.Location = New System.Drawing.Point(958, 13)
        Me.MetroGrid_pdf.Name = "MetroGrid_pdf"
        Me.MetroGrid_pdf.ReadOnly = True
        Me.MetroGrid_pdf.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid_pdf.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.MetroGrid_pdf.RowHeadersVisible = False
        Me.MetroGrid_pdf.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid_pdf.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue
        Me.MetroGrid_pdf.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroGrid_pdf.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.MetroGrid_pdf.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MetroGrid_pdf.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.MetroGrid_pdf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid_pdf.Size = New System.Drawing.Size(31, 25)
        Me.MetroGrid_pdf.TabIndex = 610
        Me.MetroGrid_pdf.Visible = False
        '
        'RadioButton_faltantes
        '
        Me.RadioButton_faltantes.AutoSize = True
        Me.RadioButton_faltantes.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_faltantes.Location = New System.Drawing.Point(195, 40)
        Me.RadioButton_faltantes.Name = "RadioButton_faltantes"
        Me.RadioButton_faltantes.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.RadioButton_faltantes.Size = New System.Drawing.Size(190, 27)
        Me.RadioButton_faltantes.TabIndex = 611
        Me.RadioButton_faltantes.TabStop = True
        Me.RadioButton_faltantes.Text = "Mostrar Faltantes"
        Me.RadioButton_faltantes.UseVisualStyleBackColor = True
        '
        'CheckBox_buscar_prod
        '
        Me.CheckBox_buscar_prod.AutoSize = True
        Me.CheckBox_buscar_prod.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_buscar_prod.Location = New System.Drawing.Point(20, 114)
        Me.CheckBox_buscar_prod.Name = "CheckBox_buscar_prod"
        Me.CheckBox_buscar_prod.Size = New System.Drawing.Size(75, 19)
        Me.CheckBox_buscar_prod.TabIndex = 612
        Me.CheckBox_buscar_prod.Text = "Producto"
        Me.CheckBox_buscar_prod.UseVisualStyleBackColor = True
        '
        'CheckBox_tipodoc
        '
        Me.CheckBox_tipodoc.AutoSize = True
        Me.CheckBox_tipodoc.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_tipodoc.Location = New System.Drawing.Point(385, 114)
        Me.CheckBox_tipodoc.Name = "CheckBox_tipodoc"
        Me.CheckBox_tipodoc.Size = New System.Drawing.Size(130, 19)
        Me.CheckBox_tipodoc.TabIndex = 613
        Me.CheckBox_tipodoc.Text = "Tipo de Documento"
        Me.CheckBox_tipodoc.UseVisualStyleBackColor = True
        '
        'BunifuElipse3
        '
        Me.BunifuElipse3.ElipseRadius = 5
        Me.BunifuElipse3.TargetControl = Me.RadioButton_entradaysalidas
        '
        'BunifuElipse4
        '
        Me.BunifuElipse4.ElipseRadius = 5
        Me.BunifuElipse4.TargetControl = Me.RadioButton_faltantes
        '
        'BunifuElipse5
        '
        Me.BunifuElipse5.ElipseRadius = 5
        Me.BunifuElipse5.TargetControl = Me.RadioButton_saldos
        '
        'BunifuCards_exportar
        '
        Me.BunifuCards_exportar.BackColor = System.Drawing.Color.White
        Me.BunifuCards_exportar.BorderRadius = 5
        Me.BunifuCards_exportar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuCards_exportar.BottomSahddow = True
        Me.BunifuCards_exportar.color = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.BunifuCards_exportar.Controls.Add(Me.Button_exportar_BODEGA)
        Me.BunifuCards_exportar.Controls.Add(Me.Label13)
        Me.BunifuCards_exportar.Controls.Add(Me.Button_cerrar_exportar)
        Me.BunifuCards_exportar.Controls.Add(Me.Panel6)
        Me.BunifuCards_exportar.Controls.Add(Me.Label18)
        Me.BunifuCards_exportar.LeftSahddow = False
        Me.BunifuCards_exportar.Location = New System.Drawing.Point(585, 3)
        Me.BunifuCards_exportar.Name = "BunifuCards_exportar"
        Me.BunifuCards_exportar.RightSahddow = True
        Me.BunifuCards_exportar.ShadowDepth = 20
        Me.BunifuCards_exportar.Size = New System.Drawing.Size(355, 48)
        Me.BunifuCards_exportar.TabIndex = 614
        Me.BunifuCards_exportar.Visible = False
        '
        'Button_exportar_BODEGA
        '
        Me.Button_exportar_BODEGA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button_exportar_BODEGA.BackColor = System.Drawing.Color.Transparent
        Me.Button_exportar_BODEGA.BackgroundImage = CType(resources.GetObject("Button_exportar_BODEGA.BackgroundImage"), System.Drawing.Image)
        Me.Button_exportar_BODEGA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_exportar_BODEGA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_exportar_BODEGA.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button_exportar_BODEGA.FlatAppearance.BorderSize = 0
        Me.Button_exportar_BODEGA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_exportar_BODEGA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.Button_exportar_BODEGA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_exportar_BODEGA.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_exportar_BODEGA.ForeColor = System.Drawing.Color.White
        Me.Button_exportar_BODEGA.Location = New System.Drawing.Point(72, -21)
        Me.Button_exportar_BODEGA.Name = "Button_exportar_BODEGA"
        Me.Button_exportar_BODEGA.Size = New System.Drawing.Size(209, 40)
        Me.Button_exportar_BODEGA.TabIndex = 1010
        Me.Button_exportar_BODEGA.Text = "Exportar"
        Me.Button_exportar_BODEGA.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(8, 14)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 19)
        Me.Label13.TabIndex = 447
        Me.Label13.Text = "Exportar"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button_cerrar_exportar
        '
        Me.Button_cerrar_exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_cerrar_exportar.BackColor = System.Drawing.Color.Transparent
        Me.Button_cerrar_exportar.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.CANCEL
        Me.Button_cerrar_exportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_cerrar_exportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_cerrar_exportar.FlatAppearance.BorderSize = 0
        Me.Button_cerrar_exportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_cerrar_exportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_cerrar_exportar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_cerrar_exportar.ForeColor = System.Drawing.Color.White
        Me.Button_cerrar_exportar.Location = New System.Drawing.Point(314, 10)
        Me.Button_cerrar_exportar.Name = "Button_cerrar_exportar"
        Me.Button_cerrar_exportar.Size = New System.Drawing.Size(25, 25)
        Me.Button_cerrar_exportar.TabIndex = 446
        Me.Button_cerrar_exportar.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.RadioButton_xls)
        Me.Panel6.Controls.Add(Me.PictureBox3)
        Me.Panel6.Controls.Add(Me.RadioButton_normal)
        Me.Panel6.Controls.Add(Me.PictureBox2)
        Me.Panel6.Controls.Add(Me.PictureBox1)
        Me.Panel6.Controls.Add(Me.RadioButton_pos)
        Me.Panel6.Location = New System.Drawing.Point(16, 89)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(319, 82)
        Me.Panel6.TabIndex = 1013
        '
        'RadioButton_xls
        '
        Me.RadioButton_xls.AutoSize = True
        Me.RadioButton_xls.BackColor = System.Drawing.Color.SteelBlue
        Me.RadioButton_xls.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold)
        Me.RadioButton_xls.ForeColor = System.Drawing.Color.White
        Me.RadioButton_xls.Location = New System.Drawing.Point(242, 62)
        Me.RadioButton_xls.Name = "RadioButton_xls"
        Me.RadioButton_xls.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.RadioButton_xls.Size = New System.Drawing.Size(58, 17)
        Me.RadioButton_xls.TabIndex = 1017
        Me.RadioButton_xls.Text = "XLS"
        Me.RadioButton_xls.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.MiClickDerecho.My.Resources.Resources.xls_icon_3403
        Me.PictureBox3.Location = New System.Drawing.Point(240, 6)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(63, 52)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 1016
        Me.PictureBox3.TabStop = False
        '
        'RadioButton_normal
        '
        Me.RadioButton_normal.AutoSize = True
        Me.RadioButton_normal.BackColor = System.Drawing.Color.SteelBlue
        Me.RadioButton_normal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold)
        Me.RadioButton_normal.ForeColor = System.Drawing.Color.White
        Me.RadioButton_normal.Location = New System.Drawing.Point(118, 62)
        Me.RadioButton_normal.Name = "RadioButton_normal"
        Me.RadioButton_normal.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.RadioButton_normal.Size = New System.Drawing.Size(85, 17)
        Me.RadioButton_normal.TabIndex = 1015
        Me.RadioButton_normal.Text = "NORMAL"
        Me.RadioButton_normal.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.MiClickDerecho.My.Resources.Resources.PRINTICON
        Me.PictureBox2.Location = New System.Drawing.Point(128, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(63, 52)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1014
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MiClickDerecho.My.Resources.Resources.pos
        Me.PictureBox1.Location = New System.Drawing.Point(7, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(63, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1013
        Me.PictureBox1.TabStop = False
        '
        'RadioButton_pos
        '
        Me.RadioButton_pos.BackColor = System.Drawing.Color.SteelBlue
        Me.RadioButton_pos.Checked = True
        Me.RadioButton_pos.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold)
        Me.RadioButton_pos.ForeColor = System.Drawing.Color.White
        Me.RadioButton_pos.Location = New System.Drawing.Point(7, 62)
        Me.RadioButton_pos.Name = "RadioButton_pos"
        Me.RadioButton_pos.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.RadioButton_pos.Size = New System.Drawing.Size(63, 17)
        Me.RadioButton_pos.TabIndex = 1011
        Me.RadioButton_pos.TabStop = True
        Me.RadioButton_pos.Text = "POS"
        Me.RadioButton_pos.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(13, 71)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(148, 16)
        Me.Label18.TabIndex = 449
        Me.Label18.Text = "Seleccione el Formato"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button_exportar
        '
        Me.Button_exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_exportar.BackColor = System.Drawing.Color.Transparent
        Me.Button_exportar.BackgroundImage = CType(resources.GetObject("Button_exportar.BackgroundImage"), System.Drawing.Image)
        Me.Button_exportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_exportar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_exportar.FlatAppearance.BorderSize = 0
        Me.Button_exportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_exportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_exportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_exportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button_exportar.ForeColor = System.Drawing.Color.Transparent
        Me.Button_exportar.Image = Global.MiClickDerecho.My.Resources.Resources.export_icon
        Me.Button_exportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_exportar.Location = New System.Drawing.Point(901, 108)
        Me.Button_exportar.Name = "Button_exportar"
        Me.Button_exportar.Size = New System.Drawing.Size(85, 45)
        Me.Button_exportar.TabIndex = 615
        Me.Button_exportar.Text = "Exportar"
        Me.Button_exportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_exportar.UseVisualStyleBackColor = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.Image = Global.MiClickDerecho.My.Resources.Resources.ajaxloader
        Me.PictureBox9.Location = New System.Drawing.Point(143, 357)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(715, 38)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 616
        Me.PictureBox9.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 20.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(287, 34)
        Me.Label2.TabIndex = 771
        Me.Label2.Text = "Consultar Inventario"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AllowDrop = True
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(626, 520)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 772
        Me.Label1.Text = "Total Costo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AllowDrop = True
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(806, 520)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 15)
        Me.Label5.TabIndex = 774
        Me.Label5.Text = "Total Precios / Venta"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox_precios
        '
        Me.ComboBox_precios.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_precios.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_precios.FormattingEnabled = True
        Me.ComboBox_precios.Location = New System.Drawing.Point(809, 534)
        Me.ComboBox_precios.Name = "ComboBox_precios"
        Me.ComboBox_precios.Size = New System.Drawing.Size(180, 24)
        Me.ComboBox_precios.TabIndex = 775
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(21, 70)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(25, 12)
        Me.Label35.TabIndex = 928
        Me.Label35.Text = "Año"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumericUpDown_anno
        '
        Me.NumericUpDown_anno.BackColor = System.Drawing.Color.SteelBlue
        Me.NumericUpDown_anno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumericUpDown_anno.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold)
        Me.NumericUpDown_anno.ForeColor = System.Drawing.Color.White
        Me.NumericUpDown_anno.Location = New System.Drawing.Point(20, 82)
        Me.NumericUpDown_anno.Maximum = New Decimal(New Integer() {2025, 0, 0, 0})
        Me.NumericUpDown_anno.Minimum = New Decimal(New Integer() {2016, 0, 0, 0})
        Me.NumericUpDown_anno.Name = "NumericUpDown_anno"
        Me.NumericUpDown_anno.Size = New System.Drawing.Size(79, 26)
        Me.NumericUpDown_anno.TabIndex = 927
        Me.NumericUpDown_anno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown_anno.Value = New Decimal(New Integer() {2019, 0, 0, 0})
        '
        'Form_bodega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 561)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.NumericUpDown_anno)
        Me.Controls.Add(Me.ComboBox_precios)
        Me.Controls.Add(Me.BunifuCards_exportar)
        Me.Controls.Add(Me.datagrid)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.Button_exportar)
        Me.Controls.Add(Me.MetroGrid_pdf)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BunifuCheckbox_vence)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox_total)
        Me.Controls.Add(Me.RadioButton_faltantes)
        Me.Controls.Add(Me.RadioButton_saldos)
        Me.Controls.Add(Me.RadioButton_entradaysalidas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox_tipodoc)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.ComboBoxInfoBodega)
        Me.Controls.Add(Me.ComboBoxProds)
        Me.Controls.Add(Me.CheckBox_buscar_prod)
        Me.Controls.Add(Me.CheckBox_tipodoc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBoX_fechaMES)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_bodega"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetroGrid_pdf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards_exportar.ResumeLayout(False)
        Me.BunifuCards_exportar.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_anno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Timer_prod_data As System.Windows.Forms.Timer
    Friend WithEvents ComboBoxProds As System.Windows.Forms.ComboBox
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ComboBoxInfoBodega As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents RadioButton_entradaysalidas As RadioButton
    Friend WithEvents RadioButton_saldos As RadioButton
    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents BunifuCheckbox_vence As ns1.BunifuCheckbox
    Friend WithEvents BunifuElipse2 As ns1.BunifuElipse
    Friend WithEvents datagrid As MetroFramework.Controls.MetroGrid
    Friend WithEvents ComboBoX_fechaMES As ComboBox
    Friend WithEvents TextBox_total As TextBox
    Friend WithEvents ComboBox_tipodoc As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents MetroGrid_pdf As MetroFramework.Controls.MetroGrid
    Friend WithEvents RadioButton_faltantes As RadioButton
    Friend WithEvents CheckBox_buscar_prod As CheckBox
    Friend WithEvents CheckBox_tipodoc As CheckBox
    Friend WithEvents BunifuElipse3 As ns1.BunifuElipse
    Friend WithEvents BunifuElipse4 As ns1.BunifuElipse
    Friend WithEvents BunifuElipse5 As ns1.BunifuElipse
    Friend WithEvents BunifuCards_exportar As ns1.BunifuCards
    Friend WithEvents Button_exportar_BODEGA As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Button_cerrar_exportar As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents RadioButton_normal As RadioButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RadioButton_pos As RadioButton
    Friend WithEvents Label18 As Label
    Friend WithEvents Button_exportar As Button
    Friend WithEvents RadioButton_xls As RadioButton
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox_precios As ComboBox
    Friend WithEvents Label35 As Label
    Friend WithEvents NumericUpDown_anno As NumericUpDown
End Class
