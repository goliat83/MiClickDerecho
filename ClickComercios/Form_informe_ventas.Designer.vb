<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_informe_ventas
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_informe_ventas))
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MetroComboBox2 = New MetroFramework.Controls.MetroComboBox()
        Me.grid_VENTAS = New MetroFramework.Controls.MetroGrid()
        Me.Label_fac_count = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label_fin = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label_ini = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TextBox_ventas_descuentos = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TextBox_ventas_netas = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBox_ventas_devoluciones = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBox_ventas_anuladas = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.COMBOBOX_FECHA_VENTAS = New MetroFramework.Controls.MetroComboBox()
        Me.datagrid_imp = New MetroFramework.Controls.MetroGrid()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NumericUpDown_anoventa = New System.Windows.Forms.NumericUpDown()
        Me.datagrid_VENTAS_grafico = New MetroFramework.Controls.MetroGrid()
        Me.TextBox_total_ventas_butas = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Combo_mesVentas = New MetroFramework.Controls.MetroComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox_ventas_impuestos = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.datagrid_imp_dev = New MetroFramework.Controls.MetroGrid()
        Me.button_crear = New System.Windows.Forms.Button()
        Me.Button_export_pdf_ventas = New System.Windows.Forms.Button()
        Me.Panel_titlebar = New System.Windows.Forms.Panel()
        Me.Button_min = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Buttoninformes = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.grid_VENTAS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datagrid_imp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_anoventa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datagrid_VENTAS_grafico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datagrid_imp_dev, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_titlebar.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(28, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 755
        Me.Label4.Text = "Cliente"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MetroComboBox2
        '
        Me.MetroComboBox2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.MetroComboBox2.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.MetroComboBox2.FontWeight = MetroFramework.MetroComboBoxWeight.Light
        Me.MetroComboBox2.FormattingEnabled = True
        Me.MetroComboBox2.ItemHeight = 19
        Me.MetroComboBox2.Location = New System.Drawing.Point(29, 138)
        Me.MetroComboBox2.Name = "MetroComboBox2"
        Me.MetroComboBox2.Size = New System.Drawing.Size(430, 25)
        Me.MetroComboBox2.TabIndex = 756
        Me.MetroComboBox2.UseSelectable = True
        '
        'grid_VENTAS
        '
        Me.grid_VENTAS.AllowUserToAddRows = False
        Me.grid_VENTAS.AllowUserToDeleteRows = False
        Me.grid_VENTAS.AllowUserToResizeRows = False
        Me.grid_VENTAS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grid_VENTAS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grid_VENTAS.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.grid_VENTAS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grid_VENTAS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grid_VENTAS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_VENTAS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_VENTAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_VENTAS.DefaultCellStyle = DataGridViewCellStyle2
        Me.grid_VENTAS.EnableHeadersVisualStyles = False
        Me.grid_VENTAS.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grid_VENTAS.GridColor = System.Drawing.Color.AliceBlue
        Me.grid_VENTAS.Location = New System.Drawing.Point(24, 168)
        Me.grid_VENTAS.Name = "grid_VENTAS"
        Me.grid_VENTAS.ReadOnly = True
        Me.grid_VENTAS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_VENTAS.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grid_VENTAS.RowHeadersVisible = False
        Me.grid_VENTAS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grid_VENTAS.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue
        Me.grid_VENTAS.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.grid_VENTAS.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grid_VENTAS.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.grid_VENTAS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_VENTAS.Size = New System.Drawing.Size(954, 263)
        Me.grid_VENTAS.TabIndex = 724
        Me.grid_VENTAS.UseStyleColors = True
        '
        'Label_fac_count
        '
        Me.Label_fac_count.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_fac_count.BackColor = System.Drawing.Color.Transparent
        Me.Label_fac_count.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_fac_count.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_fac_count.Location = New System.Drawing.Point(631, 434)
        Me.Label_fac_count.Name = "Label_fac_count"
        Me.Label_fac_count.Size = New System.Drawing.Size(152, 19)
        Me.Label_fac_count.TabIndex = 754
        Me.Label_fac_count.Text = "0"
        Me.Label_fac_count.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(531, 438)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 13)
        Me.Label10.TabIndex = 753
        Me.Label10.Text = "Total Facturas"
        '
        'Label_fin
        '
        Me.Label_fin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_fin.BackColor = System.Drawing.Color.Transparent
        Me.Label_fin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_fin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_fin.Location = New System.Drawing.Point(378, 434)
        Me.Label_fin.Name = "Label_fin"
        Me.Label_fin.Size = New System.Drawing.Size(152, 19)
        Me.Label_fin.TabIndex = 752
        Me.Label_fin.Text = "0"
        Me.Label_fin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(285, 438)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(81, 13)
        Me.Label22.TabIndex = 751
        Me.Label22.Text = "Factura Final"
        '
        'Label_ini
        '
        Me.Label_ini.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_ini.BackColor = System.Drawing.Color.Transparent
        Me.Label_ini.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ini.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_ini.Location = New System.Drawing.Point(122, 434)
        Me.Label_ini.Name = "Label_ini"
        Me.Label_ini.Size = New System.Drawing.Size(152, 19)
        Me.Label_ini.TabIndex = 750
        Me.Label_ini.Text = "0"
        Me.Label_ini.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(22, 438)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(88, 13)
        Me.Label24.TabIndex = 749
        Me.Label24.Text = "Factura Inicial"
        '
        'TextBox_ventas_descuentos
        '
        Me.TextBox_ventas_descuentos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_ventas_descuentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ventas_descuentos.Location = New System.Drawing.Point(802, 539)
        Me.TextBox_ventas_descuentos.Name = "TextBox_ventas_descuentos"
        Me.TextBox_ventas_descuentos.Size = New System.Drawing.Size(166, 22)
        Me.TextBox_ventas_descuentos.TabIndex = 748
        Me.TextBox_ventas_descuentos.Text = "0"
        Me.TextBox_ventas_descuentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(681, 542)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(118, 15)
        Me.Label23.TabIndex = 747
        Me.Label23.Text = "Total Descuentos"
        '
        'TextBox_ventas_netas
        '
        Me.TextBox_ventas_netas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_ventas_netas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ventas_netas.Location = New System.Drawing.Point(802, 588)
        Me.TextBox_ventas_netas.Name = "TextBox_ventas_netas"
        Me.TextBox_ventas_netas.Size = New System.Drawing.Size(166, 22)
        Me.TextBox_ventas_netas.TabIndex = 743
        Me.TextBox_ventas_netas.Text = "0"
        Me.TextBox_ventas_netas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(708, 591)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(91, 15)
        Me.Label20.TabIndex = 742
        Me.Label20.Text = "Ventas Netas"
        '
        'TextBox_ventas_devoluciones
        '
        Me.TextBox_ventas_devoluciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_ventas_devoluciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ventas_devoluciones.Location = New System.Drawing.Point(802, 515)
        Me.TextBox_ventas_devoluciones.Name = "TextBox_ventas_devoluciones"
        Me.TextBox_ventas_devoluciones.Size = New System.Drawing.Size(166, 22)
        Me.TextBox_ventas_devoluciones.TabIndex = 741
        Me.TextBox_ventas_devoluciones.Text = "0"
        Me.TextBox_ventas_devoluciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(706, 518)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(93, 15)
        Me.Label18.TabIndex = 740
        Me.Label18.Text = "Devoluciones"
        '
        'TextBox_ventas_anuladas
        '
        Me.TextBox_ventas_anuladas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_ventas_anuladas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ventas_anuladas.Location = New System.Drawing.Point(802, 491)
        Me.TextBox_ventas_anuladas.Name = "TextBox_ventas_anuladas"
        Me.TextBox_ventas_anuladas.Size = New System.Drawing.Size(166, 22)
        Me.TextBox_ventas_anuladas.TabIndex = 739
        Me.TextBox_ventas_anuladas.Text = "0"
        Me.TextBox_ventas_anuladas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(686, 494)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(113, 15)
        Me.Label17.TabIndex = 738
        Me.Label17.Text = "Ventas Anuladas"
        '
        'COMBOBOX_FECHA_VENTAS
        '
        Me.COMBOBOX_FECHA_VENTAS.BackColor = System.Drawing.SystemColors.HotTrack
        Me.COMBOBOX_FECHA_VENTAS.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.COMBOBOX_FECHA_VENTAS.FontWeight = MetroFramework.MetroComboBoxWeight.Light
        Me.COMBOBOX_FECHA_VENTAS.FormattingEnabled = True
        Me.COMBOBOX_FECHA_VENTAS.ItemHeight = 19
        Me.COMBOBOX_FECHA_VENTAS.Location = New System.Drawing.Point(187, 98)
        Me.COMBOBOX_FECHA_VENTAS.Name = "COMBOBOX_FECHA_VENTAS"
        Me.COMBOBOX_FECHA_VENTAS.Size = New System.Drawing.Size(152, 25)
        Me.COMBOBOX_FECHA_VENTAS.TabIndex = 737
        Me.COMBOBOX_FECHA_VENTAS.UseSelectable = True
        '
        'datagrid_imp
        '
        Me.datagrid_imp.AllowUserToAddRows = False
        Me.datagrid_imp.AllowUserToDeleteRows = False
        Me.datagrid_imp.AllowUserToResizeRows = False
        Me.datagrid_imp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.datagrid_imp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagrid_imp.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.datagrid_imp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datagrid_imp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.datagrid_imp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_imp.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.datagrid_imp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid_imp.DefaultCellStyle = DataGridViewCellStyle5
        Me.datagrid_imp.EnableHeadersVisualStyles = False
        Me.datagrid_imp.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.datagrid_imp.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid_imp.Location = New System.Drawing.Point(25, 461)
        Me.datagrid_imp.Name = "datagrid_imp"
        Me.datagrid_imp.ReadOnly = True
        Me.datagrid_imp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_imp.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.datagrid_imp.RowHeadersVisible = False
        Me.datagrid_imp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagrid_imp.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.datagrid_imp.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue
        Me.datagrid_imp.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.datagrid_imp.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.datagrid_imp.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.datagrid_imp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrid_imp.Size = New System.Drawing.Size(619, 68)
        Me.datagrid_imp.TabIndex = 736
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(29, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 12)
        Me.Label7.TabIndex = 735
        Me.Label7.Text = "Año"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumericUpDown_anoventa
        '
        Me.NumericUpDown_anoventa.BackColor = System.Drawing.Color.White
        Me.NumericUpDown_anoventa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumericUpDown_anoventa.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.NumericUpDown_anoventa.ForeColor = System.Drawing.Color.Black
        Me.NumericUpDown_anoventa.Location = New System.Drawing.Point(31, 56)
        Me.NumericUpDown_anoventa.Maximum = New Decimal(New Integer() {2025, 0, 0, 0})
        Me.NumericUpDown_anoventa.Minimum = New Decimal(New Integer() {2016, 0, 0, 0})
        Me.NumericUpDown_anoventa.Name = "NumericUpDown_anoventa"
        Me.NumericUpDown_anoventa.Size = New System.Drawing.Size(79, 25)
        Me.NumericUpDown_anoventa.TabIndex = 734
        Me.NumericUpDown_anoventa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown_anoventa.Value = New Decimal(New Integer() {2018, 0, 0, 0})
        '
        'datagrid_VENTAS_grafico
        '
        Me.datagrid_VENTAS_grafico.AllowUserToAddRows = False
        Me.datagrid_VENTAS_grafico.AllowUserToDeleteRows = False
        Me.datagrid_VENTAS_grafico.AllowUserToResizeRows = False
        Me.datagrid_VENTAS_grafico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datagrid_VENTAS_grafico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.datagrid_VENTAS_grafico.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid_VENTAS_grafico.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datagrid_VENTAS_grafico.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.datagrid_VENTAS_grafico.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_VENTAS_grafico.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.datagrid_VENTAS_grafico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid_VENTAS_grafico.DefaultCellStyle = DataGridViewCellStyle8
        Me.datagrid_VENTAS_grafico.EnableHeadersVisualStyles = False
        Me.datagrid_VENTAS_grafico.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.datagrid_VENTAS_grafico.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid_VENTAS_grafico.Location = New System.Drawing.Point(894, 76)
        Me.datagrid_VENTAS_grafico.Name = "datagrid_VENTAS_grafico"
        Me.datagrid_VENTAS_grafico.ReadOnly = True
        Me.datagrid_VENTAS_grafico.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_VENTAS_grafico.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.datagrid_VENTAS_grafico.RowHeadersVisible = False
        Me.datagrid_VENTAS_grafico.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagrid_VENTAS_grafico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrid_VENTAS_grafico.Size = New System.Drawing.Size(39, 19)
        Me.datagrid_VENTAS_grafico.TabIndex = 733
        Me.datagrid_VENTAS_grafico.Visible = False
        '
        'TextBox_total_ventas_butas
        '
        Me.TextBox_total_ventas_butas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_total_ventas_butas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_total_ventas_butas.Location = New System.Drawing.Point(802, 467)
        Me.TextBox_total_ventas_butas.Name = "TextBox_total_ventas_butas"
        Me.TextBox_total_ventas_butas.Size = New System.Drawing.Size(166, 22)
        Me.TextBox_total_ventas_butas.TabIndex = 730
        Me.TextBox_total_ventas_butas.Text = "0"
        Me.TextBox_total_ventas_butas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(704, 470)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(95, 15)
        Me.Label19.TabIndex = 729
        Me.Label19.Text = "Ventas Brutas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(27, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 12)
        Me.Label1.TabIndex = 727
        Me.Label1.Text = "Periodo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Combo_mesVentas
        '
        Me.Combo_mesVentas.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Combo_mesVentas.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.Combo_mesVentas.FontWeight = MetroFramework.MetroComboBoxWeight.Light
        Me.Combo_mesVentas.FormattingEnabled = True
        Me.Combo_mesVentas.ItemHeight = 19
        Me.Combo_mesVentas.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.Combo_mesVentas.Location = New System.Drawing.Point(29, 98)
        Me.Combo_mesVentas.Name = "Combo_mesVentas"
        Me.Combo_mesVentas.Size = New System.Drawing.Size(152, 25)
        Me.Combo_mesVentas.TabIndex = 728
        Me.Combo_mesVentas.UseSelectable = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(185, 86)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 12)
        Me.Label13.TabIndex = 726
        Me.Label13.Text = "Fecha"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_ventas_impuestos
        '
        Me.TextBox_ventas_impuestos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_ventas_impuestos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ventas_impuestos.Location = New System.Drawing.Point(802, 564)
        Me.TextBox_ventas_impuestos.Name = "TextBox_ventas_impuestos"
        Me.TextBox_ventas_impuestos.Size = New System.Drawing.Size(166, 22)
        Me.TextBox_ventas_impuestos.TabIndex = 745
        Me.TextBox_ventas_impuestos.Text = "0"
        Me.TextBox_ventas_impuestos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(690, 567)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(109, 15)
        Me.Label21.TabIndex = 744
        Me.Label21.Text = "Total Impuestos"
        '
        'datagrid_imp_dev
        '
        Me.datagrid_imp_dev.AllowUserToAddRows = False
        Me.datagrid_imp_dev.AllowUserToDeleteRows = False
        Me.datagrid_imp_dev.AllowUserToResizeRows = False
        Me.datagrid_imp_dev.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.datagrid_imp_dev.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagrid_imp_dev.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.datagrid_imp_dev.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datagrid_imp_dev.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.datagrid_imp_dev.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_imp_dev.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.datagrid_imp_dev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid_imp_dev.DefaultCellStyle = DataGridViewCellStyle11
        Me.datagrid_imp_dev.EnableHeadersVisualStyles = False
        Me.datagrid_imp_dev.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.datagrid_imp_dev.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid_imp_dev.Location = New System.Drawing.Point(25, 539)
        Me.datagrid_imp_dev.Name = "datagrid_imp_dev"
        Me.datagrid_imp_dev.ReadOnly = True
        Me.datagrid_imp_dev.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_imp_dev.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.datagrid_imp_dev.RowHeadersVisible = False
        Me.datagrid_imp_dev.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagrid_imp_dev.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.datagrid_imp_dev.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue
        Me.datagrid_imp_dev.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.datagrid_imp_dev.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.datagrid_imp_dev.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.datagrid_imp_dev.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrid_imp_dev.Size = New System.Drawing.Size(619, 68)
        Me.datagrid_imp_dev.TabIndex = 746
        '
        'button_crear
        '
        Me.button_crear.BackColor = System.Drawing.Color.Transparent
        Me.button_crear.BackgroundImage = CType(resources.GetObject("button_crear.BackgroundImage"), System.Drawing.Image)
        Me.button_crear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button_crear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_crear.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.button_crear.FlatAppearance.BorderSize = 0
        Me.button_crear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.button_crear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.button_crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_crear.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_crear.ForeColor = System.Drawing.Color.White
        Me.button_crear.Image = Global.MiClickDerecho.My.Resources.Resources.viewicone
        Me.button_crear.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.button_crear.Location = New System.Drawing.Point(780, 111)
        Me.button_crear.Name = "button_crear"
        Me.button_crear.Size = New System.Drawing.Size(100, 48)
        Me.button_crear.TabIndex = 731
        Me.button_crear.Text = "Ver Factura"
        Me.button_crear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.button_crear.UseVisualStyleBackColor = False
        '
        'Button_export_pdf_ventas
        '
        Me.Button_export_pdf_ventas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_export_pdf_ventas.BackColor = System.Drawing.Color.Transparent
        Me.Button_export_pdf_ventas.BackgroundImage = CType(resources.GetObject("Button_export_pdf_ventas.BackgroundImage"), System.Drawing.Image)
        Me.Button_export_pdf_ventas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_export_pdf_ventas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_export_pdf_ventas.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_export_pdf_ventas.FlatAppearance.BorderSize = 0
        Me.Button_export_pdf_ventas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button_export_pdf_ventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.Button_export_pdf_ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_export_pdf_ventas.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_export_pdf_ventas.ForeColor = System.Drawing.Color.White
        Me.Button_export_pdf_ventas.Image = Global.MiClickDerecho.My.Resources.Resources.export_icon
        Me.Button_export_pdf_ventas.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_export_pdf_ventas.Location = New System.Drawing.Point(885, 111)
        Me.Button_export_pdf_ventas.Name = "Button_export_pdf_ventas"
        Me.Button_export_pdf_ventas.Size = New System.Drawing.Size(88, 48)
        Me.Button_export_pdf_ventas.TabIndex = 725
        Me.Button_export_pdf_ventas.Text = "Exportar"
        Me.Button_export_pdf_ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_export_pdf_ventas.UseVisualStyleBackColor = False
        '
        'Panel_titlebar
        '
        Me.Panel_titlebar.BackColor = System.Drawing.Color.Transparent
        Me.Panel_titlebar.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.banner9
        Me.Panel_titlebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_titlebar.Controls.Add(Me.Button_min)
        Me.Panel_titlebar.Controls.Add(Me.Button13)
        Me.Panel_titlebar.Controls.Add(Me.Buttoninformes)
        Me.Panel_titlebar.Controls.Add(Me.Label2)
        Me.Panel_titlebar.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_titlebar.Location = New System.Drawing.Point(0, 0)
        Me.Panel_titlebar.Name = "Panel_titlebar"
        Me.Panel_titlebar.Size = New System.Drawing.Size(1004, 36)
        Me.Panel_titlebar.TabIndex = 757
        '
        'Button_min
        '
        Me.Button_min.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_min.BackColor = System.Drawing.Color.Transparent
        Me.Button_min.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.minimi
        Me.Button_min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_min.FlatAppearance.BorderSize = 0
        Me.Button_min.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_min.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_min.ForeColor = System.Drawing.Color.White
        Me.Button_min.Location = New System.Drawing.Point(930, 4)
        Me.Button_min.Name = "Button_min"
        Me.Button_min.Size = New System.Drawing.Size(25, 25)
        Me.Button_min.TabIndex = 598
        Me.Button_min.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button13.BackColor = System.Drawing.Color.Transparent
        Me.Button13.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.CANCEL
        Me.Button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button13.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.ForeColor = System.Drawing.Color.Black
        Me.Button13.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button13.Location = New System.Drawing.Point(965, 5)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(25, 25)
        Me.Button13.TabIndex = 597
        Me.Button13.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Buttoninformes
        '
        Me.Buttoninformes.BackColor = System.Drawing.Color.Transparent
        Me.Buttoninformes.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.graphic
        Me.Buttoninformes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Buttoninformes.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Buttoninformes.FlatAppearance.BorderSize = 0
        Me.Buttoninformes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Buttoninformes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Buttoninformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buttoninformes.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttoninformes.ForeColor = System.Drawing.Color.White
        Me.Buttoninformes.Location = New System.Drawing.Point(6, 3)
        Me.Buttoninformes.Name = "Buttoninformes"
        Me.Buttoninformes.Size = New System.Drawing.Size(40, 31)
        Me.Buttoninformes.TabIndex = 394
        Me.Buttoninformes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Buttoninformes.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(48, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 23)
        Me.Label2.TabIndex = 393
        Me.Label2.Text = "Informe de Ventas"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form_informe_ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 635)
        Me.Controls.Add(Me.Panel_titlebar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MetroComboBox2)
        Me.Controls.Add(Me.grid_VENTAS)
        Me.Controls.Add(Me.Label_fac_count)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label_fin)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label_ini)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.TextBox_ventas_descuentos)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.TextBox_ventas_netas)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.TextBox_ventas_devoluciones)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TextBox_ventas_anuladas)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.COMBOBOX_FECHA_VENTAS)
        Me.Controls.Add(Me.datagrid_imp)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.NumericUpDown_anoventa)
        Me.Controls.Add(Me.button_crear)
        Me.Controls.Add(Me.datagrid_VENTAS_grafico)
        Me.Controls.Add(Me.Button_export_pdf_ventas)
        Me.Controls.Add(Me.TextBox_total_ventas_butas)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Combo_mesVentas)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TextBox_ventas_impuestos)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.datagrid_imp_dev)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_informe_ventas"
        Me.ShowInTaskbar = False
        Me.Text = "Form_informe_ventas"
        CType(Me.grid_VENTAS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datagrid_imp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_anoventa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datagrid_VENTAS_grafico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datagrid_imp_dev, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_titlebar.ResumeLayout(False)
        Me.Panel_titlebar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents Label4 As Label
    Friend WithEvents MetroComboBox2 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents grid_VENTAS As MetroFramework.Controls.MetroGrid
    Friend WithEvents Label_fac_count As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label_fin As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label_ini As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents TextBox_ventas_descuentos As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TextBox_ventas_netas As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TextBox_ventas_devoluciones As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TextBox_ventas_anuladas As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents COMBOBOX_FECHA_VENTAS As MetroFramework.Controls.MetroComboBox
    Friend WithEvents datagrid_imp As MetroFramework.Controls.MetroGrid
    Friend WithEvents Label7 As Label
    Friend WithEvents NumericUpDown_anoventa As NumericUpDown
    Friend WithEvents button_crear As Button
    Friend WithEvents datagrid_VENTAS_grafico As MetroFramework.Controls.MetroGrid
    Friend WithEvents Button_export_pdf_ventas As Button
    Friend WithEvents TextBox_total_ventas_butas As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Combo_mesVentas As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox_ventas_impuestos As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents datagrid_imp_dev As MetroFramework.Controls.MetroGrid
    Friend WithEvents Panel_titlebar As Panel
    Friend WithEvents Button_min As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Buttoninformes As Button
    Friend WithEvents Label2 As Label
End Class
