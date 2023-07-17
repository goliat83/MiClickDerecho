<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_comprobantes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_comprobantes))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Timer_LOAD_COMPROBANTES = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_clasificar = New System.Windows.Forms.Timer(Me.components)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.COMBOBOX_FECHA_FILTRO = New MetroFramework.Controls.MetroComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ComboBox_MEs_filtro_comp = New MetroFramework.Controls.MetroComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.NumericUpDown_anoventa = New System.Windows.Forms.NumericUpDown()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.MetroGrid_detalle_comprobante = New MetroFramework.Controls.MetroGrid()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label_totalDEBE = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label_totalHABER = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label_156 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.RadioButton_debitar = New System.Windows.Forms.RadioButton()
        Me.Button_aagregar_siento = New System.Windows.Forms.Button()
        Me.ComboBox_cta_comp_NOMBRE = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Button_eliminar_asiento = New System.Windows.Forms.Button()
        Me.ComboBox_cta_comp = New System.Windows.Forms.ComboBox()
        Me.Panel_GUARDAR = New System.Windows.Forms.Panel()
        Me.Button_MODIFICAR = New System.Windows.Forms.Button()
        Me.Button_guardar = New System.Windows.Forms.Button()
        Me.Button_regresar = New System.Windows.Forms.Button()
        Me.Button_ANULAR = New System.Windows.Forms.Button()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.Button_exportar = New System.Windows.Forms.Button()
        Me.Panel_datos_comprobantes = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox_fecha_comprobante = New System.Windows.Forms.TextBox()
        Me.TextBox_comprobante = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MetroDateTime3 = New MetroFramework.Controls.MetroDateTime()
        Me.TextBox_TIPO_COMPROBANTE = New System.Windows.Forms.TextBox()
        Me.TextBox_OBSERVACION = New System.Windows.Forms.TextBox()
        Me.Label_ESTADO = New System.Windows.Forms.Label()
        Me.Panel_comprobantes = New System.Windows.Forms.Panel()
        Me.MetroGrid_comprobantes = New MetroFramework.Controls.MetroGrid()
        Me.Timer_CLIENTE = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button_almacen = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel_general = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button_CONSULTAR_MOV = New System.Windows.Forms.Button()
        Me.Button_nuevo_comp = New System.Windows.Forms.Button()
        Me.Timer_prod_data = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.BunifuElipse2 = New ns1.BunifuElipse(Me.components)
        Me.BunifuElipse3 = New ns1.BunifuElipse(Me.components)
        Me.BunifuElipse4 = New ns1.BunifuElipse(Me.components)
        Me.BunifuElipse5 = New ns1.BunifuElipse(Me.components)
        Me.BunifuCards_asiento = New ns1.BunifuCards()
        Me.Button_sel_cuenta_ce = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_valor = New System.Windows.Forms.NumericUpDown()
        Me.BunifuElipse6 = New ns1.BunifuElipse(Me.components)
        Me.BunifuElipse7 = New ns1.BunifuElipse(Me.components)
        Me.BunifuElipse8 = New ns1.BunifuElipse(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox_dv_cliente = New System.Windows.Forms.TextBox()
        Me.TXT_NOM_CLIENTE = New System.Windows.Forms.TextBox()
        Me.TXT_DOC_CLIENTE = New System.Windows.Forms.TextBox()
        Me.TXT_DIR_CLIENTE = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TXT_TELS_CLIENTE = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.COMBO_TERCERO_FILTRO = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TextBox_BUSCAR_PROV = New System.Windows.Forms.TextBox()
        Me.RadioButton_NOM_PROV = New System.Windows.Forms.RadioButton()
        Me.RadioButton_NIT_PROV = New System.Windows.Forms.RadioButton()
        Me.BunifuElipse9 = New ns1.BunifuElipse(Me.components)
        Me.BunifuCards_TERCERO = New ns1.BunifuCards()
        Me.BunifuElipse10 = New ns1.BunifuElipse(Me.components)
        Me.Panel5.SuspendLayout()
        CType(Me.NumericUpDown_anoventa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.MetroGrid_detalle_comprobante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel_GUARDAR.SuspendLayout()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_datos_comprobantes.SuspendLayout()
        Me.Panel_comprobantes.SuspendLayout()
        CType(Me.MetroGrid_comprobantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel_general.SuspendLayout()
        Me.BunifuCards_asiento.SuspendLayout()
        CType(Me.TextBox_valor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards_TERCERO.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer_LOAD_COMPROBANTES
        '
        Me.Timer_LOAD_COMPROBANTES.Interval = 300
        '
        'Timer_clasificar
        '
        Me.Timer_clasificar.Interval = 300
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.COMBOBOX_FECHA_FILTRO)
        Me.Panel5.Controls.Add(Me.Label20)
        Me.Panel5.Controls.Add(Me.ComboBox_MEs_filtro_comp)
        Me.Panel5.Controls.Add(Me.Label19)
        Me.Panel5.Controls.Add(Me.NumericUpDown_anoventa)
        Me.Panel5.Controls.Add(Me.Button2)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.MetroComboBox1)
        Me.Panel5.Controls.Add(Me.Label30)
        Me.Panel5.Location = New System.Drawing.Point(22, 50)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(458, 91)
        Me.Panel5.TabIndex = 649
        '
        'COMBOBOX_FECHA_FILTRO
        '
        Me.COMBOBOX_FECHA_FILTRO.BackColor = System.Drawing.Color.White
        Me.COMBOBOX_FECHA_FILTRO.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.COMBOBOX_FECHA_FILTRO.FontWeight = MetroFramework.MetroComboBoxWeight.Bold
        Me.COMBOBOX_FECHA_FILTRO.ForeColor = System.Drawing.Color.Black
        Me.COMBOBOX_FECHA_FILTRO.FormattingEnabled = True
        Me.COMBOBOX_FECHA_FILTRO.ItemHeight = 19
        Me.COMBOBOX_FECHA_FILTRO.Location = New System.Drawing.Point(245, 17)
        Me.COMBOBOX_FECHA_FILTRO.Name = "COMBOBOX_FECHA_FILTRO"
        Me.COMBOBOX_FECHA_FILTRO.Size = New System.Drawing.Size(111, 25)
        Me.COMBOBOX_FECHA_FILTRO.TabIndex = 907
        Me.COMBOBOX_FECHA_FILTRO.UseCustomBackColor = True
        Me.COMBOBOX_FECHA_FILTRO.UseCustomForeColor = True
        Me.COMBOBOX_FECHA_FILTRO.UseSelectable = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(247, 5)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(36, 12)
        Me.Label20.TabIndex = 906
        Me.Label20.Text = "Fecha"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox_MEs_filtro_comp
        '
        Me.ComboBox_MEs_filtro_comp.BackColor = System.Drawing.Color.White
        Me.ComboBox_MEs_filtro_comp.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.ComboBox_MEs_filtro_comp.FontWeight = MetroFramework.MetroComboBoxWeight.Bold
        Me.ComboBox_MEs_filtro_comp.ForeColor = System.Drawing.Color.Black
        Me.ComboBox_MEs_filtro_comp.FormattingEnabled = True
        Me.ComboBox_MEs_filtro_comp.ItemHeight = 19
        Me.ComboBox_MEs_filtro_comp.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.ComboBox_MEs_filtro_comp.Location = New System.Drawing.Point(97, 17)
        Me.ComboBox_MEs_filtro_comp.Name = "ComboBox_MEs_filtro_comp"
        Me.ComboBox_MEs_filtro_comp.Size = New System.Drawing.Size(142, 25)
        Me.ComboBox_MEs_filtro_comp.TabIndex = 905
        Me.ComboBox_MEs_filtro_comp.UseCustomBackColor = True
        Me.ComboBox_MEs_filtro_comp.UseCustomForeColor = True
        Me.ComboBox_MEs_filtro_comp.UseSelectable = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(15, 4)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(25, 12)
        Me.Label19.TabIndex = 904
        Me.Label19.Text = "Año"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumericUpDown_anoventa
        '
        Me.NumericUpDown_anoventa.BackColor = System.Drawing.Color.White
        Me.NumericUpDown_anoventa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumericUpDown_anoventa.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.NumericUpDown_anoventa.ForeColor = System.Drawing.Color.Black
        Me.NumericUpDown_anoventa.Location = New System.Drawing.Point(13, 17)
        Me.NumericUpDown_anoventa.Maximum = New Decimal(New Integer() {2018, 0, 0, 0})
        Me.NumericUpDown_anoventa.Minimum = New Decimal(New Integer() {2016, 0, 0, 0})
        Me.NumericUpDown_anoventa.Name = "NumericUpDown_anoventa"
        Me.NumericUpDown_anoventa.Size = New System.Drawing.Size(79, 25)
        Me.NumericUpDown_anoventa.TabIndex = 903
        Me.NumericUpDown_anoventa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown_anoventa.Value = New Decimal(New Integer() {2018, 0, 0, 0})
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.BUTTTON1
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.MiClickDerecho.My.Resources.Resources.viewicone
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(362, 55)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 30)
        Me.Button2.TabIndex = 902
        Me.Button2.Text = "Buscar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(8, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 12)
        Me.Label8.TabIndex = 593
        Me.Label8.Text = "Tipos  de  Documento"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MetroComboBox1
        '
        Me.MetroComboBox1.BackColor = System.Drawing.Color.White
        Me.MetroComboBox1.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.MetroComboBox1.FontWeight = MetroFramework.MetroComboBoxWeight.Bold
        Me.MetroComboBox1.ForeColor = System.Drawing.Color.White
        Me.MetroComboBox1.FormattingEnabled = True
        Me.MetroComboBox1.ItemHeight = 19
        Me.MetroComboBox1.Location = New System.Drawing.Point(11, 60)
        Me.MetroComboBox1.Name = "MetroComboBox1"
        Me.MetroComboBox1.PromptText = "Seleccione Tipo de Documento"
        Me.MetroComboBox1.Size = New System.Drawing.Size(345, 25)
        Me.MetroComboBox1.TabIndex = 594
        Me.MetroComboBox1.UseCustomBackColor = True
        Me.MetroComboBox1.UseCustomForeColor = True
        Me.MetroComboBox1.UseSelectable = True
        Me.MetroComboBox1.UseStyleColors = True
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(99, 5)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(43, 12)
        Me.Label30.TabIndex = 578
        Me.Label30.Text = "Periodo"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(29, 149)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 20)
        Me.Label11.TabIndex = 666
        Me.Label11.Text = "Descripción"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.cuadro_blanco
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Controls.Add(Me.MetroGrid_detalle_comprobante)
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Controls.Add(Me.Panel1)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label_156)
        Me.Panel4.Location = New System.Drawing.Point(22, 366)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(5, 5, 5, 0)
        Me.Panel4.Size = New System.Drawing.Size(955, 277)
        Me.Panel4.TabIndex = 587
        '
        'MetroGrid_detalle_comprobante
        '
        Me.MetroGrid_detalle_comprobante.AllowUserToAddRows = False
        Me.MetroGrid_detalle_comprobante.AllowUserToDeleteRows = False
        Me.MetroGrid_detalle_comprobante.AllowUserToResizeRows = False
        Me.MetroGrid_detalle_comprobante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MetroGrid_detalle_comprobante.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.MetroGrid_detalle_comprobante.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid_detalle_comprobante.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.MetroGrid_detalle_comprobante.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid_detalle_comprobante.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MetroGrid_detalle_comprobante.ColumnHeadersHeight = 28
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid_detalle_comprobante.DefaultCellStyle = DataGridViewCellStyle2
        Me.MetroGrid_detalle_comprobante.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroGrid_detalle_comprobante.EnableHeadersVisualStyles = False
        Me.MetroGrid_detalle_comprobante.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid_detalle_comprobante.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid_detalle_comprobante.Location = New System.Drawing.Point(5, 5)
        Me.MetroGrid_detalle_comprobante.Name = "MetroGrid_detalle_comprobante"
        Me.MetroGrid_detalle_comprobante.ReadOnly = True
        Me.MetroGrid_detalle_comprobante.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid_detalle_comprobante.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.MetroGrid_detalle_comprobante.RowHeadersVisible = False
        Me.MetroGrid_detalle_comprobante.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid_detalle_comprobante.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.MetroGrid_detalle_comprobante.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroGrid_detalle_comprobante.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.MetroGrid_detalle_comprobante.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MetroGrid_detalle_comprobante.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.MetroGrid_detalle_comprobante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid_detalle_comprobante.Size = New System.Drawing.Size(945, 221)
        Me.MetroGrid_detalle_comprobante.TabIndex = 585
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.buttonborder
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.Label_totalDEBE)
        Me.Panel3.Location = New System.Drawing.Point(566, 241)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(178, 31)
        Me.Panel3.TabIndex = 583
        '
        'Label_totalDEBE
        '
        Me.Label_totalDEBE.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_totalDEBE.BackColor = System.Drawing.Color.Transparent
        Me.Label_totalDEBE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_totalDEBE.ForeColor = System.Drawing.Color.Black
        Me.Label_totalDEBE.Location = New System.Drawing.Point(3, 5)
        Me.Label_totalDEBE.Name = "Label_totalDEBE"
        Me.Label_totalDEBE.Size = New System.Drawing.Size(170, 20)
        Me.Label_totalDEBE.TabIndex = 408
        Me.Label_totalDEBE.Text = "0"
        Me.Label_totalDEBE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.buttonborder
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label_totalHABER)
        Me.Panel1.Location = New System.Drawing.Point(752, 241)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(178, 31)
        Me.Panel1.TabIndex = 581
        '
        'Label_totalHABER
        '
        Me.Label_totalHABER.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_totalHABER.BackColor = System.Drawing.Color.Transparent
        Me.Label_totalHABER.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label_totalHABER.ForeColor = System.Drawing.Color.Black
        Me.Label_totalHABER.Location = New System.Drawing.Point(6, 5)
        Me.Label_totalHABER.Name = "Label_totalHABER"
        Me.Label_totalHABER.Size = New System.Drawing.Size(169, 20)
        Me.Label_totalHABER.TabIndex = 408
        Me.Label_totalHABER.Text = "0"
        Me.Label_totalHABER.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(626, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 12)
        Me.Label3.TabIndex = 658
        Me.Label3.Text = "Total Debe"
        '
        'Label_156
        '
        Me.Label_156.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_156.AutoSize = True
        Me.Label_156.BackColor = System.Drawing.Color.Transparent
        Me.Label_156.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold)
        Me.Label_156.ForeColor = System.Drawing.Color.Black
        Me.Label_156.Location = New System.Drawing.Point(812, 229)
        Me.Label_156.Name = "Label_156"
        Me.Label_156.Size = New System.Drawing.Size(63, 12)
        Me.Label_156.TabIndex = 580
        Me.Label_156.Text = "Total Haber"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Black
        Me.TextBox2.Location = New System.Drawing.Point(330, 57)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(142, 17)
        Me.TextBox2.TabIndex = 524
        Me.TextBox2.Text = "."
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(123, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 12)
        Me.Label14.TabIndex = 665
        Me.Label14.Text = "Nombre Cuenta"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadioButton_debitar
        '
        Me.RadioButton_debitar.AutoSize = True
        Me.RadioButton_debitar.BackColor = System.Drawing.Color.DodgerBlue
        Me.RadioButton_debitar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_debitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_debitar.Location = New System.Drawing.Point(17, 117)
        Me.RadioButton_debitar.Name = "RadioButton_debitar"
        Me.RadioButton_debitar.Padding = New System.Windows.Forms.Padding(10, 0, 5, 0)
        Me.RadioButton_debitar.Size = New System.Drawing.Size(92, 20)
        Me.RadioButton_debitar.TabIndex = 635
        Me.RadioButton_debitar.TabStop = True
        Me.RadioButton_debitar.Text = "Debitar"
        Me.RadioButton_debitar.UseVisualStyleBackColor = False
        '
        'Button_aagregar_siento
        '
        Me.Button_aagregar_siento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_aagregar_siento.BackColor = System.Drawing.Color.Transparent
        Me.Button_aagregar_siento.BackgroundImage = CType(resources.GetObject("Button_aagregar_siento.BackgroundImage"), System.Drawing.Image)
        Me.Button_aagregar_siento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_aagregar_siento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_aagregar_siento.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button_aagregar_siento.FlatAppearance.BorderSize = 0
        Me.Button_aagregar_siento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_aagregar_siento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_aagregar_siento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_aagregar_siento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_aagregar_siento.ForeColor = System.Drawing.Color.White
        Me.Button_aagregar_siento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_aagregar_siento.Location = New System.Drawing.Point(267, 107)
        Me.Button_aagregar_siento.Name = "Button_aagregar_siento"
        Me.Button_aagregar_siento.Size = New System.Drawing.Size(119, 35)
        Me.Button_aagregar_siento.TabIndex = 633
        Me.Button_aagregar_siento.Text = "Agregar Registro"
        Me.Button_aagregar_siento.UseVisualStyleBackColor = False
        '
        'ComboBox_cta_comp_NOMBRE
        '
        Me.ComboBox_cta_comp_NOMBRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.ComboBox_cta_comp_NOMBRE.FormattingEnabled = True
        Me.ComboBox_cta_comp_NOMBRE.Location = New System.Drawing.Point(122, 27)
        Me.ComboBox_cta_comp_NOMBRE.Name = "ComboBox_cta_comp_NOMBRE"
        Me.ComboBox_cta_comp_NOMBRE.Size = New System.Drawing.Size(316, 21)
        Me.ComboBox_cta_comp_NOMBRE.TabIndex = 664
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(66, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(30, 0, 30, 0)
        Me.Label6.Size = New System.Drawing.Size(107, 18)
        Me.Label6.TabIndex = 659
        Me.Label6.Text = "Valor"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.DodgerBlue
        Me.RadioButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(123, 117)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Padding = New System.Windows.Forms.Padding(10, 0, 5, 0)
        Me.RadioButton1.Size = New System.Drawing.Size(104, 20)
        Me.RadioButton1.TabIndex = 636
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Acreditar"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'Button_eliminar_asiento
        '
        Me.Button_eliminar_asiento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_eliminar_asiento.BackColor = System.Drawing.Color.Transparent
        Me.Button_eliminar_asiento.BackgroundImage = CType(resources.GetObject("Button_eliminar_asiento.BackgroundImage"), System.Drawing.Image)
        Me.Button_eliminar_asiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_eliminar_asiento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_eliminar_asiento.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button_eliminar_asiento.FlatAppearance.BorderSize = 0
        Me.Button_eliminar_asiento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_eliminar_asiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_eliminar_asiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_eliminar_asiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_eliminar_asiento.ForeColor = System.Drawing.Color.White
        Me.Button_eliminar_asiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_eliminar_asiento.Location = New System.Drawing.Point(392, 107)
        Me.Button_eliminar_asiento.Name = "Button_eliminar_asiento"
        Me.Button_eliminar_asiento.Size = New System.Drawing.Size(81, 35)
        Me.Button_eliminar_asiento.TabIndex = 634
        Me.Button_eliminar_asiento.Text = "Eliminar"
        Me.Button_eliminar_asiento.UseVisualStyleBackColor = False
        '
        'ComboBox_cta_comp
        '
        Me.ComboBox_cta_comp.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.ComboBox_cta_comp.FormattingEnabled = True
        Me.ComboBox_cta_comp.Location = New System.Drawing.Point(8, 27)
        Me.ComboBox_cta_comp.Name = "ComboBox_cta_comp"
        Me.ComboBox_cta_comp.Size = New System.Drawing.Size(108, 21)
        Me.ComboBox_cta_comp.TabIndex = 655
        '
        'Panel_GUARDAR
        '
        Me.Panel_GUARDAR.Controls.Add(Me.Button_MODIFICAR)
        Me.Panel_GUARDAR.Controls.Add(Me.Button_guardar)
        Me.Panel_GUARDAR.Controls.Add(Me.Button_regresar)
        Me.Panel_GUARDAR.Controls.Add(Me.Button_ANULAR)
        Me.Panel_GUARDAR.Controls.Add(Me.MetroGrid1)
        Me.Panel_GUARDAR.Controls.Add(Me.Button_exportar)
        Me.Panel_GUARDAR.Location = New System.Drawing.Point(491, 87)
        Me.Panel_GUARDAR.Name = "Panel_GUARDAR"
        Me.Panel_GUARDAR.Size = New System.Drawing.Size(490, 52)
        Me.Panel_GUARDAR.TabIndex = 654
        Me.Panel_GUARDAR.Visible = False
        '
        'Button_MODIFICAR
        '
        Me.Button_MODIFICAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_MODIFICAR.BackColor = System.Drawing.Color.Transparent
        Me.Button_MODIFICAR.BackgroundImage = CType(resources.GetObject("Button_MODIFICAR.BackgroundImage"), System.Drawing.Image)
        Me.Button_MODIFICAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_MODIFICAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_MODIFICAR.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button_MODIFICAR.FlatAppearance.BorderSize = 0
        Me.Button_MODIFICAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_MODIFICAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.Button_MODIFICAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_MODIFICAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_MODIFICAR.ForeColor = System.Drawing.Color.White
        Me.Button_MODIFICAR.Image = Global.MiClickDerecho.My.Resources.Resources.lapizico
        Me.Button_MODIFICAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_MODIFICAR.Location = New System.Drawing.Point(93, 3)
        Me.Button_MODIFICAR.Name = "Button_MODIFICAR"
        Me.Button_MODIFICAR.Size = New System.Drawing.Size(105, 44)
        Me.Button_MODIFICAR.TabIndex = 635
        Me.Button_MODIFICAR.Text = "Modificar"
        Me.Button_MODIFICAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_MODIFICAR.UseVisualStyleBackColor = False
        '
        'Button_guardar
        '
        Me.Button_guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_guardar.BackColor = System.Drawing.Color.Transparent
        Me.Button_guardar.BackgroundImage = CType(resources.GetObject("Button_guardar.BackgroundImage"), System.Drawing.Image)
        Me.Button_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_guardar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button_guardar.FlatAppearance.BorderSize = 0
        Me.Button_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.Button_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_guardar.ForeColor = System.Drawing.Color.White
        Me.Button_guardar.Image = Global.MiClickDerecho.My.Resources.Resources.guardar
        Me.Button_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_guardar.Location = New System.Drawing.Point(284, 3)
        Me.Button_guardar.Name = "Button_guardar"
        Me.Button_guardar.Size = New System.Drawing.Size(93, 44)
        Me.Button_guardar.TabIndex = 634
        Me.Button_guardar.Text = "Guardar"
        Me.Button_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_guardar.UseVisualStyleBackColor = False
        '
        'Button_regresar
        '
        Me.Button_regresar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_regresar.BackColor = System.Drawing.Color.Transparent
        Me.Button_regresar.BackgroundImage = CType(resources.GetObject("Button_regresar.BackgroundImage"), System.Drawing.Image)
        Me.Button_regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_regresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_regresar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button_regresar.FlatAppearance.BorderSize = 0
        Me.Button_regresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_regresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.Button_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_regresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_regresar.ForeColor = System.Drawing.Color.White
        Me.Button_regresar.Image = Global.MiClickDerecho.My.Resources.Resources.back
        Me.Button_regresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_regresar.Location = New System.Drawing.Point(381, 3)
        Me.Button_regresar.Name = "Button_regresar"
        Me.Button_regresar.Size = New System.Drawing.Size(108, 44)
        Me.Button_regresar.TabIndex = 631
        Me.Button_regresar.Text = "Regresar"
        Me.Button_regresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_regresar.UseVisualStyleBackColor = False
        '
        'Button_ANULAR
        '
        Me.Button_ANULAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_ANULAR.BackColor = System.Drawing.Color.Transparent
        Me.Button_ANULAR.BackgroundImage = CType(resources.GetObject("Button_ANULAR.BackgroundImage"), System.Drawing.Image)
        Me.Button_ANULAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_ANULAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_ANULAR.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button_ANULAR.FlatAppearance.BorderSize = 0
        Me.Button_ANULAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_ANULAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.Button_ANULAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_ANULAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_ANULAR.ForeColor = System.Drawing.Color.White
        Me.Button_ANULAR.Image = Global.MiClickDerecho.My.Resources.Resources.delete_256
        Me.Button_ANULAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_ANULAR.Location = New System.Drawing.Point(202, 3)
        Me.Button_ANULAR.Name = "Button_ANULAR"
        Me.Button_ANULAR.Size = New System.Drawing.Size(78, 44)
        Me.Button_ANULAR.TabIndex = 632
        Me.Button_ANULAR.Text = "Anular"
        Me.Button_ANULAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_ANULAR.UseVisualStyleBackColor = False
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToAddRows = False
        Me.MetroGrid1.AllowUserToDeleteRows = False
        Me.MetroGrid1.AllowUserToResizeRows = False
        Me.MetroGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.MetroGrid1.ColumnHeadersHeight = 28
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle5
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(50, 22)
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.ReadOnly = True
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.MetroGrid1.RowHeadersVisible = False
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.MetroGrid1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroGrid1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.MetroGrid1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MetroGrid1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(29, 13)
        Me.MetroGrid1.TabIndex = 586
        Me.MetroGrid1.Visible = False
        '
        'Button_exportar
        '
        Me.Button_exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_exportar.BackColor = System.Drawing.Color.Transparent
        Me.Button_exportar.BackgroundImage = CType(resources.GetObject("Button_exportar.BackgroundImage"), System.Drawing.Image)
        Me.Button_exportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_exportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_exportar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button_exportar.FlatAppearance.BorderSize = 0
        Me.Button_exportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_exportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.Button_exportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_exportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_exportar.ForeColor = System.Drawing.Color.White
        Me.Button_exportar.Image = Global.MiClickDerecho.My.Resources.Resources.download2
        Me.Button_exportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_exportar.Location = New System.Drawing.Point(1, 3)
        Me.Button_exportar.Name = "Button_exportar"
        Me.Button_exportar.Size = New System.Drawing.Size(89, 44)
        Me.Button_exportar.TabIndex = 633
        Me.Button_exportar.Text = "Exportar"
        Me.Button_exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_exportar.UseVisualStyleBackColor = False
        '
        'Panel_datos_comprobantes
        '
        Me.Panel_datos_comprobantes.Controls.Add(Me.Label9)
        Me.Panel_datos_comprobantes.Controls.Add(Me.TextBox_fecha_comprobante)
        Me.Panel_datos_comprobantes.Controls.Add(Me.TextBox_comprobante)
        Me.Panel_datos_comprobantes.Controls.Add(Me.Label10)
        Me.Panel_datos_comprobantes.Controls.Add(Me.MetroDateTime3)
        Me.Panel_datos_comprobantes.Controls.Add(Me.TextBox_TIPO_COMPROBANTE)
        Me.Panel_datos_comprobantes.Location = New System.Drawing.Point(30, 60)
        Me.Panel_datos_comprobantes.Name = "Panel_datos_comprobantes"
        Me.Panel_datos_comprobantes.Size = New System.Drawing.Size(438, 81)
        Me.Panel_datos_comprobantes.TabIndex = 721
        Me.Panel_datos_comprobantes.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(6, 1)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 640
        Me.Label9.Text = "No."
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_fecha_comprobante
        '
        Me.TextBox_fecha_comprobante.BackColor = System.Drawing.Color.White
        Me.TextBox_fecha_comprobante.Enabled = False
        Me.TextBox_fecha_comprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox_fecha_comprobante.ForeColor = System.Drawing.Color.Black
        Me.TextBox_fecha_comprobante.Location = New System.Drawing.Point(119, 15)
        Me.TextBox_fecha_comprobante.Name = "TextBox_fecha_comprobante"
        Me.TextBox_fecha_comprobante.Size = New System.Drawing.Size(113, 26)
        Me.TextBox_fecha_comprobante.TabIndex = 637
        '
        'TextBox_comprobante
        '
        Me.TextBox_comprobante.BackColor = System.Drawing.Color.White
        Me.TextBox_comprobante.Enabled = False
        Me.TextBox_comprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox_comprobante.ForeColor = System.Drawing.Color.Black
        Me.TextBox_comprobante.Location = New System.Drawing.Point(7, 15)
        Me.TextBox_comprobante.Name = "TextBox_comprobante"
        Me.TextBox_comprobante.Size = New System.Drawing.Size(102, 26)
        Me.TextBox_comprobante.TabIndex = 639
        Me.TextBox_comprobante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(121, 2)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 638
        Me.Label10.Text = "Fecha"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MetroDateTime3
        '
        Me.MetroDateTime3.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.MetroDateTime3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.MetroDateTime3.Location = New System.Drawing.Point(152, 16)
        Me.MetroDateTime3.MinimumSize = New System.Drawing.Size(4, 25)
        Me.MetroDateTime3.Name = "MetroDateTime3"
        Me.MetroDateTime3.Size = New System.Drawing.Size(108, 25)
        Me.MetroDateTime3.TabIndex = 898
        '
        'TextBox_TIPO_COMPROBANTE
        '
        Me.TextBox_TIPO_COMPROBANTE.BackColor = System.Drawing.SystemColors.HotTrack
        Me.TextBox_TIPO_COMPROBANTE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_TIPO_COMPROBANTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_TIPO_COMPROBANTE.ForeColor = System.Drawing.Color.White
        Me.TextBox_TIPO_COMPROBANTE.Location = New System.Drawing.Point(7, 48)
        Me.TextBox_TIPO_COMPROBANTE.Name = "TextBox_TIPO_COMPROBANTE"
        Me.TextBox_TIPO_COMPROBANTE.Size = New System.Drawing.Size(422, 24)
        Me.TextBox_TIPO_COMPROBANTE.TabIndex = 665
        Me.TextBox_TIPO_COMPROBANTE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_OBSERVACION
        '
        Me.TextBox_OBSERVACION.BackColor = System.Drawing.Color.White
        Me.TextBox_OBSERVACION.Enabled = False
        Me.TextBox_OBSERVACION.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_OBSERVACION.ForeColor = System.Drawing.Color.Black
        Me.TextBox_OBSERVACION.Location = New System.Drawing.Point(30, 169)
        Me.TextBox_OBSERVACION.Multiline = True
        Me.TextBox_OBSERVACION.Name = "TextBox_OBSERVACION"
        Me.TextBox_OBSERVACION.Size = New System.Drawing.Size(947, 32)
        Me.TextBox_OBSERVACION.TabIndex = 723
        '
        'Label_ESTADO
        '
        Me.Label_ESTADO.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label_ESTADO.AutoSize = True
        Me.Label_ESTADO.BackColor = System.Drawing.Color.Transparent
        Me.Label_ESTADO.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ESTADO.ForeColor = System.Drawing.Color.Black
        Me.Label_ESTADO.Location = New System.Drawing.Point(842, 53)
        Me.Label_ESTADO.Name = "Label_ESTADO"
        Me.Label_ESTADO.Size = New System.Drawing.Size(136, 27)
        Me.Label_ESTADO.TabIndex = 718
        Me.Label_ESTADO.Text = "PENDIENTE"
        Me.Label_ESTADO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_ESTADO.Visible = False
        '
        'Panel_comprobantes
        '
        Me.Panel_comprobantes.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.cuadro_blanco
        Me.Panel_comprobantes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_comprobantes.Controls.Add(Me.MetroGrid_comprobantes)
        Me.Panel_comprobantes.Location = New System.Drawing.Point(16, 145)
        Me.Panel_comprobantes.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel_comprobantes.Name = "Panel_comprobantes"
        Me.Panel_comprobantes.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel_comprobantes.Size = New System.Drawing.Size(10, 503)
        Me.Panel_comprobantes.TabIndex = 586
        '
        'MetroGrid_comprobantes
        '
        Me.MetroGrid_comprobantes.AllowUserToAddRows = False
        Me.MetroGrid_comprobantes.AllowUserToDeleteRows = False
        Me.MetroGrid_comprobantes.AllowUserToResizeRows = False
        Me.MetroGrid_comprobantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MetroGrid_comprobantes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.MetroGrid_comprobantes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid_comprobantes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.MetroGrid_comprobantes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid_comprobantes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.MetroGrid_comprobantes.ColumnHeadersHeight = 26
        Me.MetroGrid_comprobantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkTurquoise
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid_comprobantes.DefaultCellStyle = DataGridViewCellStyle8
        Me.MetroGrid_comprobantes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroGrid_comprobantes.EnableHeadersVisualStyles = False
        Me.MetroGrid_comprobantes.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid_comprobantes.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid_comprobantes.Location = New System.Drawing.Point(5, 5)
        Me.MetroGrid_comprobantes.Name = "MetroGrid_comprobantes"
        Me.MetroGrid_comprobantes.ReadOnly = True
        Me.MetroGrid_comprobantes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid_comprobantes.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.MetroGrid_comprobantes.RowHeadersVisible = False
        Me.MetroGrid_comprobantes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DarkTurquoise
        Me.MetroGrid_comprobantes.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.MetroGrid_comprobantes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.MetroGrid_comprobantes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.MetroGrid_comprobantes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MetroGrid_comprobantes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.MetroGrid_comprobantes.RowTemplate.DividerHeight = 1
        Me.MetroGrid_comprobantes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.MetroGrid_comprobantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid_comprobantes.Size = New System.Drawing.Size(0, 493)
        Me.MetroGrid_comprobantes.TabIndex = 722
        '
        'Timer_CLIENTE
        '
        Me.Timer_CLIENTE.Interval = 300
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.banner9
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Button_almacen)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(-1, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1002, 38)
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
        Me.Button1.Location = New System.Drawing.Point(960, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 30)
        Me.Button1.TabIndex = 598
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button_almacen
        '
        Me.Button_almacen.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button_almacen.BackColor = System.Drawing.Color.Transparent
        Me.Button_almacen.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.accounter2512
        Me.Button_almacen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_almacen.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.Button_almacen.FlatAppearance.BorderSize = 0
        Me.Button_almacen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_almacen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_almacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_almacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_almacen.ForeColor = System.Drawing.Color.White
        Me.Button_almacen.Location = New System.Drawing.Point(5, 3)
        Me.Button_almacen.Name = "Button_almacen"
        Me.Button_almacen.Size = New System.Drawing.Size(40, 33)
        Me.Button_almacen.TabIndex = 394
        Me.Button_almacen.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_almacen.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(46, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(298, 24)
        Me.Label5.TabIndex = 393
        Me.Label5.Text = "Comprobantes de Contabilidad"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel_general
        '
        Me.Panel_general.BackColor = System.Drawing.Color.Transparent
        Me.Panel_general.Controls.Add(Me.Button3)
        Me.Panel_general.Controls.Add(Me.Button_CONSULTAR_MOV)
        Me.Panel_general.Controls.Add(Me.Button_nuevo_comp)
        Me.Panel_general.Location = New System.Drawing.Point(601, 85)
        Me.Panel_general.Name = "Panel_general"
        Me.Panel_general.Size = New System.Drawing.Size(380, 56)
        Me.Panel_general.TabIndex = 644
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = Global.MiClickDerecho.My.Resources.Resources.xls_icone
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(297, 10)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(79, 45)
        Me.Button3.TabIndex = 620
        Me.Button3.Text = "Exportar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button_CONSULTAR_MOV
        '
        Me.Button_CONSULTAR_MOV.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_CONSULTAR_MOV.BackColor = System.Drawing.Color.Transparent
        Me.Button_CONSULTAR_MOV.BackgroundImage = CType(resources.GetObject("Button_CONSULTAR_MOV.BackgroundImage"), System.Drawing.Image)
        Me.Button_CONSULTAR_MOV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_CONSULTAR_MOV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_CONSULTAR_MOV.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button_CONSULTAR_MOV.FlatAppearance.BorderSize = 0
        Me.Button_CONSULTAR_MOV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_CONSULTAR_MOV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.Button_CONSULTAR_MOV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_CONSULTAR_MOV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_CONSULTAR_MOV.ForeColor = System.Drawing.Color.White
        Me.Button_CONSULTAR_MOV.Image = Global.MiClickDerecho.My.Resources.Resources.viewicone
        Me.Button_CONSULTAR_MOV.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_CONSULTAR_MOV.Location = New System.Drawing.Point(204, 10)
        Me.Button_CONSULTAR_MOV.Name = "Button_CONSULTAR_MOV"
        Me.Button_CONSULTAR_MOV.Size = New System.Drawing.Size(90, 45)
        Me.Button_CONSULTAR_MOV.TabIndex = 623
        Me.Button_CONSULTAR_MOV.Text = "Consultar"
        Me.Button_CONSULTAR_MOV.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_CONSULTAR_MOV.UseVisualStyleBackColor = False
        '
        'Button_nuevo_comp
        '
        Me.Button_nuevo_comp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_nuevo_comp.BackColor = System.Drawing.Color.Transparent
        Me.Button_nuevo_comp.BackgroundImage = CType(resources.GetObject("Button_nuevo_comp.BackgroundImage"), System.Drawing.Image)
        Me.Button_nuevo_comp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_nuevo_comp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_nuevo_comp.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button_nuevo_comp.FlatAppearance.BorderSize = 0
        Me.Button_nuevo_comp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_nuevo_comp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.Button_nuevo_comp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_nuevo_comp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_nuevo_comp.ForeColor = System.Drawing.Color.White
        Me.Button_nuevo_comp.Image = Global.MiClickDerecho.My.Resources.Resources.agregar
        Me.Button_nuevo_comp.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_nuevo_comp.Location = New System.Drawing.Point(101, 10)
        Me.Button_nuevo_comp.Name = "Button_nuevo_comp"
        Me.Button_nuevo_comp.Size = New System.Drawing.Size(99, 45)
        Me.Button_nuevo_comp.TabIndex = 622
        Me.Button_nuevo_comp.Text = "Nuevo"
        Me.Button_nuevo_comp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_nuevo_comp.UseVisualStyleBackColor = False
        '
        'Timer_prod_data
        '
        Me.Timer_prod_data.Interval = 300
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 5
        Me.BunifuElipse2.TargetControl = Me.MetroGrid_comprobantes
        '
        'BunifuElipse3
        '
        Me.BunifuElipse3.ElipseRadius = 5
        Me.BunifuElipse3.TargetControl = Me.RadioButton_debitar
        '
        'BunifuElipse4
        '
        Me.BunifuElipse4.ElipseRadius = 5
        Me.BunifuElipse4.TargetControl = Me.RadioButton1
        '
        'BunifuElipse5
        '
        Me.BunifuElipse5.ElipseRadius = 5
        Me.BunifuElipse5.TargetControl = Me.MetroGrid_detalle_comprobante
        '
        'BunifuCards_asiento
        '
        Me.BunifuCards_asiento.BackColor = System.Drawing.Color.White
        Me.BunifuCards_asiento.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.cuadro_blanco
        Me.BunifuCards_asiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuCards_asiento.BorderRadius = 5
        Me.BunifuCards_asiento.BottomSahddow = True
        Me.BunifuCards_asiento.color = System.Drawing.Color.Tomato
        Me.BunifuCards_asiento.Controls.Add(Me.Button_sel_cuenta_ce)
        Me.BunifuCards_asiento.Controls.Add(Me.TextBox1)
        Me.BunifuCards_asiento.Controls.Add(Me.RadioButton_debitar)
        Me.BunifuCards_asiento.Controls.Add(Me.TextBox2)
        Me.BunifuCards_asiento.Controls.Add(Me.Button_aagregar_siento)
        Me.BunifuCards_asiento.Controls.Add(Me.RadioButton1)
        Me.BunifuCards_asiento.Controls.Add(Me.Button_eliminar_asiento)
        Me.BunifuCards_asiento.Controls.Add(Me.ComboBox_cta_comp_NOMBRE)
        Me.BunifuCards_asiento.Controls.Add(Me.ComboBox_cta_comp)
        Me.BunifuCards_asiento.Controls.Add(Me.Label18)
        Me.BunifuCards_asiento.Controls.Add(Me.Label15)
        Me.BunifuCards_asiento.Controls.Add(Me.Label14)
        Me.BunifuCards_asiento.Controls.Add(Me.Label4)
        Me.BunifuCards_asiento.Controls.Add(Me.Label6)
        Me.BunifuCards_asiento.Controls.Add(Me.TextBox_valor)
        Me.BunifuCards_asiento.LeftSahddow = False
        Me.BunifuCards_asiento.Location = New System.Drawing.Point(494, 211)
        Me.BunifuCards_asiento.Name = "BunifuCards_asiento"
        Me.BunifuCards_asiento.RightSahddow = True
        Me.BunifuCards_asiento.ShadowDepth = 20
        Me.BunifuCards_asiento.Size = New System.Drawing.Size(484, 149)
        Me.BunifuCards_asiento.TabIndex = 725
        '
        'Button_sel_cuenta_ce
        '
        Me.Button_sel_cuenta_ce.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_sel_cuenta_ce.BackColor = System.Drawing.Color.Transparent
        Me.Button_sel_cuenta_ce.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.menu
        Me.Button_sel_cuenta_ce.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_sel_cuenta_ce.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_sel_cuenta_ce.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_sel_cuenta_ce.FlatAppearance.BorderSize = 0
        Me.Button_sel_cuenta_ce.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button_sel_cuenta_ce.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.Button_sel_cuenta_ce.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_sel_cuenta_ce.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Button_sel_cuenta_ce.ForeColor = System.Drawing.Color.White
        Me.Button_sel_cuenta_ce.Location = New System.Drawing.Point(444, 20)
        Me.Button_sel_cuenta_ce.Name = "Button_sel_cuenta_ce"
        Me.Button_sel_cuenta_ce.Size = New System.Drawing.Size(31, 28)
        Me.Button_sel_cuenta_ce.TabIndex = 974
        Me.Button_sel_cuenta_ce.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(330, 80)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(142, 17)
        Me.TextBox1.TabIndex = 666
        Me.TextBox1.Text = "."
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Gray
        Me.Label18.Location = New System.Drawing.Point(258, 82)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 12)
        Me.Label18.TabIndex = 668
        Me.Label18.Text = "Nuevo Saldo"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Gray
        Me.Label15.Location = New System.Drawing.Point(258, 60)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 12)
        Me.Label15.TabIndex = 667
        Me.Label15.Text = "Saldo Actual"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(9, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 12)
        Me.Label4.TabIndex = 624
        Me.Label4.Text = "Código Cuenta"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_valor
        '
        Me.TextBox_valor.BackColor = System.Drawing.Color.Azure
        Me.TextBox_valor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_valor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox_valor.DecimalPlaces = 2
        Me.TextBox_valor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_valor.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.TextBox_valor.Location = New System.Drawing.Point(11, 73)
        Me.TextBox_valor.Maximum = New Decimal(New Integer() {1410065408, 2, 0, 0})
        Me.TextBox_valor.Name = "TextBox_valor"
        Me.TextBox_valor.Size = New System.Drawing.Size(234, 26)
        Me.TextBox_valor.TabIndex = 669
        Me.TextBox_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox_valor.ThousandsSeparator = True
        '
        'BunifuElipse6
        '
        Me.BunifuElipse6.ElipseRadius = 5
        Me.BunifuElipse6.TargetControl = Me.TextBox_TIPO_COMPROBANTE
        '
        'BunifuElipse7
        '
        Me.BunifuElipse7.ElipseRadius = 5
        Me.BunifuElipse7.TargetControl = Me.Label6
        '
        'BunifuElipse8
        '
        Me.BunifuElipse8.ElipseRadius = 3
        Me.BunifuElipse8.TargetControl = Me.TextBox_valor
        '
        'Label1
        '
        Me.Label1.AllowDrop = True
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(4, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 12)
        Me.Label1.TabIndex = 758
        Me.Label1.Text = "Documento"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AllowDrop = True
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(124, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(9, 12)
        Me.Label7.TabIndex = 757
        Me.Label7.Text = "-"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AllowDrop = True
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Gray
        Me.Label13.Location = New System.Drawing.Point(136, 71)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(21, 12)
        Me.Label13.TabIndex = 755
        Me.Label13.Text = "DV"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox_dv_cliente
        '
        Me.TextBox_dv_cliente.BackColor = System.Drawing.Color.PowderBlue
        Me.TextBox_dv_cliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_dv_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox_dv_cliente.ForeColor = System.Drawing.Color.Black
        Me.TextBox_dv_cliente.Location = New System.Drawing.Point(136, 84)
        Me.TextBox_dv_cliente.Name = "TextBox_dv_cliente"
        Me.TextBox_dv_cliente.Size = New System.Drawing.Size(20, 16)
        Me.TextBox_dv_cliente.TabIndex = 752
        '
        'TXT_NOM_CLIENTE
        '
        Me.TXT_NOM_CLIENTE.BackColor = System.Drawing.Color.PowderBlue
        Me.TXT_NOM_CLIENTE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_NOM_CLIENTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TXT_NOM_CLIENTE.ForeColor = System.Drawing.Color.Black
        Me.TXT_NOM_CLIENTE.Location = New System.Drawing.Point(166, 84)
        Me.TXT_NOM_CLIENTE.Name = "TXT_NOM_CLIENTE"
        Me.TXT_NOM_CLIENTE.Size = New System.Drawing.Size(289, 16)
        Me.TXT_NOM_CLIENTE.TabIndex = 753
        '
        'TXT_DOC_CLIENTE
        '
        Me.TXT_DOC_CLIENTE.BackColor = System.Drawing.Color.PowderBlue
        Me.TXT_DOC_CLIENTE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_DOC_CLIENTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TXT_DOC_CLIENTE.ForeColor = System.Drawing.Color.Black
        Me.TXT_DOC_CLIENTE.Location = New System.Drawing.Point(4, 84)
        Me.TXT_DOC_CLIENTE.Name = "TXT_DOC_CLIENTE"
        Me.TXT_DOC_CLIENTE.Size = New System.Drawing.Size(116, 16)
        Me.TXT_DOC_CLIENTE.TabIndex = 751
        '
        'TXT_DIR_CLIENTE
        '
        Me.TXT_DIR_CLIENTE.BackColor = System.Drawing.Color.PowderBlue
        Me.TXT_DIR_CLIENTE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_DIR_CLIENTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TXT_DIR_CLIENTE.ForeColor = System.Drawing.Color.Black
        Me.TXT_DIR_CLIENTE.Location = New System.Drawing.Point(166, 118)
        Me.TXT_DIR_CLIENTE.Name = "TXT_DIR_CLIENTE"
        Me.TXT_DIR_CLIENTE.Size = New System.Drawing.Size(289, 16)
        Me.TXT_DIR_CLIENTE.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.AllowDrop = True
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Gray
        Me.Label16.Location = New System.Drawing.Point(4, 105)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 12)
        Me.Label16.TabIndex = 578
        Me.Label16.Text = "Teléfono"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXT_TELS_CLIENTE
        '
        Me.TXT_TELS_CLIENTE.BackColor = System.Drawing.Color.PowderBlue
        Me.TXT_TELS_CLIENTE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_TELS_CLIENTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TXT_TELS_CLIENTE.ForeColor = System.Drawing.Color.Black
        Me.TXT_TELS_CLIENTE.Location = New System.Drawing.Point(3, 118)
        Me.TXT_TELS_CLIENTE.Name = "TXT_TELS_CLIENTE"
        Me.TXT_TELS_CLIENTE.Size = New System.Drawing.Size(154, 16)
        Me.TXT_TELS_CLIENTE.TabIndex = 3
        '
        'Label27
        '
        Me.Label27.AllowDrop = True
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Gray
        Me.Label27.Location = New System.Drawing.Point(166, 105)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(53, 12)
        Me.Label27.TabIndex = 579
        Me.Label27.Text = "Dirección"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.AllowDrop = True
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Gray
        Me.Label21.Location = New System.Drawing.Point(165, 71)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(114, 12)
        Me.Label21.TabIndex = 539
        Me.Label21.Text = "Nombre/Razon Social"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'COMBO_TERCERO_FILTRO
        '
        Me.COMBO_TERCERO_FILTRO.BackColor = System.Drawing.Color.White
        Me.COMBO_TERCERO_FILTRO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.COMBO_TERCERO_FILTRO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.COMBO_TERCERO_FILTRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.COMBO_TERCERO_FILTRO.ForeColor = System.Drawing.Color.Black
        Me.COMBO_TERCERO_FILTRO.FormattingEnabled = True
        Me.COMBO_TERCERO_FILTRO.Location = New System.Drawing.Point(4, 41)
        Me.COMBO_TERCERO_FILTRO.Name = "COMBO_TERCERO_FILTRO"
        Me.COMBO_TERCERO_FILTRO.Size = New System.Drawing.Size(451, 21)
        Me.COMBO_TERCERO_FILTRO.TabIndex = 924
        '
        'Label22
        '
        Me.Label22.AllowDrop = True
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 10.75!, System.Drawing.FontStyle.Bold)
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(8, 15)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(66, 18)
        Me.Label22.TabIndex = 925
        Me.Label22.Text = "Tercero"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_BUSCAR_PROV
        '
        Me.TextBox_BUSCAR_PROV.BackColor = System.Drawing.Color.AliceBlue
        Me.TextBox_BUSCAR_PROV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_BUSCAR_PROV.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TextBox_BUSCAR_PROV.Location = New System.Drawing.Point(261, 15)
        Me.TextBox_BUSCAR_PROV.Name = "TextBox_BUSCAR_PROV"
        Me.TextBox_BUSCAR_PROV.Size = New System.Drawing.Size(189, 20)
        Me.TextBox_BUSCAR_PROV.TabIndex = 928
        Me.TextBox_BUSCAR_PROV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadioButton_NOM_PROV
        '
        Me.RadioButton_NOM_PROV.AutoSize = True
        Me.RadioButton_NOM_PROV.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton_NOM_PROV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_NOM_PROV.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_NOM_PROV.ForeColor = System.Drawing.Color.Black
        Me.RadioButton_NOM_PROV.Location = New System.Drawing.Point(181, 17)
        Me.RadioButton_NOM_PROV.Name = "RadioButton_NOM_PROV"
        Me.RadioButton_NOM_PROV.Size = New System.Drawing.Size(62, 16)
        Me.RadioButton_NOM_PROV.TabIndex = 927
        Me.RadioButton_NOM_PROV.Text = "Nombre"
        Me.RadioButton_NOM_PROV.UseVisualStyleBackColor = False
        '
        'RadioButton_NIT_PROV
        '
        Me.RadioButton_NIT_PROV.AutoSize = True
        Me.RadioButton_NIT_PROV.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton_NIT_PROV.Checked = True
        Me.RadioButton_NIT_PROV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_NIT_PROV.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_NIT_PROV.ForeColor = System.Drawing.Color.Black
        Me.RadioButton_NIT_PROV.Location = New System.Drawing.Point(96, 17)
        Me.RadioButton_NIT_PROV.Name = "RadioButton_NIT_PROV"
        Me.RadioButton_NIT_PROV.Size = New System.Drawing.Size(80, 16)
        Me.RadioButton_NIT_PROV.TabIndex = 926
        Me.RadioButton_NIT_PROV.TabStop = True
        Me.RadioButton_NIT_PROV.Text = "Documento"
        Me.RadioButton_NIT_PROV.UseVisualStyleBackColor = False
        '
        'BunifuElipse9
        '
        Me.BunifuElipse9.ElipseRadius = 3
        Me.BunifuElipse9.TargetControl = Me.Label11
        '
        'BunifuCards_TERCERO
        '
        Me.BunifuCards_TERCERO.BackColor = System.Drawing.Color.White
        Me.BunifuCards_TERCERO.BorderRadius = 5
        Me.BunifuCards_TERCERO.BottomSahddow = True
        Me.BunifuCards_TERCERO.color = System.Drawing.Color.MidnightBlue
        Me.BunifuCards_TERCERO.Controls.Add(Me.Label22)
        Me.BunifuCards_TERCERO.Controls.Add(Me.Label1)
        Me.BunifuCards_TERCERO.Controls.Add(Me.Label7)
        Me.BunifuCards_TERCERO.Controls.Add(Me.RadioButton_NIT_PROV)
        Me.BunifuCards_TERCERO.Controls.Add(Me.Label21)
        Me.BunifuCards_TERCERO.Controls.Add(Me.Label13)
        Me.BunifuCards_TERCERO.Controls.Add(Me.TextBox_BUSCAR_PROV)
        Me.BunifuCards_TERCERO.Controls.Add(Me.Label27)
        Me.BunifuCards_TERCERO.Controls.Add(Me.RadioButton_NOM_PROV)
        Me.BunifuCards_TERCERO.Controls.Add(Me.TXT_TELS_CLIENTE)
        Me.BunifuCards_TERCERO.Controls.Add(Me.Label16)
        Me.BunifuCards_TERCERO.Controls.Add(Me.TXT_DIR_CLIENTE)
        Me.BunifuCards_TERCERO.Controls.Add(Me.COMBO_TERCERO_FILTRO)
        Me.BunifuCards_TERCERO.Controls.Add(Me.TextBox_dv_cliente)
        Me.BunifuCards_TERCERO.Controls.Add(Me.TXT_DOC_CLIENTE)
        Me.BunifuCards_TERCERO.Controls.Add(Me.TXT_NOM_CLIENTE)
        Me.BunifuCards_TERCERO.LeftSahddow = False
        Me.BunifuCards_TERCERO.Location = New System.Drawing.Point(27, 211)
        Me.BunifuCards_TERCERO.Name = "BunifuCards_TERCERO"
        Me.BunifuCards_TERCERO.RightSahddow = True
        Me.BunifuCards_TERCERO.ShadowDepth = 20
        Me.BunifuCards_TERCERO.Size = New System.Drawing.Size(461, 149)
        Me.BunifuCards_TERCERO.TabIndex = 930
        '
        'BunifuElipse10
        '
        Me.BunifuElipse10.ElipseRadius = 3
        Me.BunifuElipse10.TargetControl = Me.TextBox_OBSERVACION
        '
        'Form_comprobantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1000, 660)
        Me.Controls.Add(Me.BunifuCards_TERCERO)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel_comprobantes)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TextBox_OBSERVACION)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel_datos_comprobantes)
        Me.Controls.Add(Me.Label_ESTADO)
        Me.Controls.Add(Me.BunifuCards_asiento)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel_general)
        Me.Controls.Add(Me.Panel_GUARDAR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1000, 660)
        Me.MinimumSize = New System.Drawing.Size(1000, 660)
        Me.Name = "Form_comprobantes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.NumericUpDown_anoventa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.MetroGrid_detalle_comprobante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel_GUARDAR.ResumeLayout(False)
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_datos_comprobantes.ResumeLayout(False)
        Me.Panel_datos_comprobantes.PerformLayout()
        Me.Panel_comprobantes.ResumeLayout(False)
        CType(Me.MetroGrid_comprobantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel_general.ResumeLayout(False)
        Me.BunifuCards_asiento.ResumeLayout(False)
        Me.BunifuCards_asiento.PerformLayout()
        CType(Me.TextBox_valor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards_TERCERO.ResumeLayout(False)
        Me.BunifuCards_TERCERO.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_almacen As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Timer_LOAD_COMPROBANTES As Timer
    Friend WithEvents Timer_clasificar As Timer
    Friend WithEvents Button_eliminar_asiento As Button
    Friend WithEvents Label_totalHABER As Label
    Friend WithEvents MetroGrid_detalle_comprobante As MetroFramework.Controls.MetroGrid
    Friend WithEvents ComboBox_cta_comp_NOMBRE As ComboBox
    Friend WithEvents Panel_general As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button_CONSULTAR_MOV As Button
    Friend WithEvents Button_nuevo_comp As Button
    Friend WithEvents Button_regresar As Button
    Friend WithEvents Button_ANULAR As Button
    Friend WithEvents Label_totalDEBE As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Panel_comprobantes As Panel
    Friend WithEvents Panel_GUARDAR As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label_156 As Label
    Friend WithEvents TextBox_comprobante As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox_fecha_comprobante As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox_cta_comp As ComboBox
    Friend WithEvents TextBox_TIPO_COMPROBANTE As TextBox
    Friend WithEvents RadioButton_debitar As RadioButton
    Friend WithEvents Button_aagregar_siento As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Button_exportar As Button
    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents Button_guardar As Button
    Friend WithEvents Timer_CLIENTE As Timer
    Friend WithEvents Label14 As Label
    Friend WithEvents Label_ESTADO As Label
    Friend WithEvents MetroGrid_comprobantes As MetroFramework.Controls.MetroGrid
    Friend WithEvents Panel_datos_comprobantes As Panel
    Friend WithEvents MetroDateTime3 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents TextBox_OBSERVACION As TextBox
    Friend WithEvents Button_MODIFICAR As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Timer_prod_data As Timer
    Friend WithEvents Button2 As Button
    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents BunifuElipse2 As ns1.BunifuElipse
    Friend WithEvents BunifuElipse3 As ns1.BunifuElipse
    Friend WithEvents BunifuElipse4 As ns1.BunifuElipse
    Friend WithEvents BunifuElipse5 As ns1.BunifuElipse
    Friend WithEvents BunifuCards_asiento As ns1.BunifuCards
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BunifuElipse6 As ns1.BunifuElipse
    Friend WithEvents Label19 As Label
    Friend WithEvents NumericUpDown_anoventa As NumericUpDown
    Friend WithEvents COMBOBOX_FECHA_FILTRO As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents ComboBox_MEs_filtro_comp As MetroFramework.Controls.MetroComboBox
    Friend WithEvents TextBox_valor As NumericUpDown
    Friend WithEvents BunifuElipse7 As ns1.BunifuElipse
    Friend WithEvents BunifuElipse8 As ns1.BunifuElipse
    Friend WithEvents Label22 As Label
    Friend WithEvents RadioButton_NIT_PROV As RadioButton
    Friend WithEvents TextBox_BUSCAR_PROV As TextBox
    Friend WithEvents RadioButton_NOM_PROV As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents TXT_TELS_CLIENTE As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TXT_DIR_CLIENTE As TextBox
    Friend WithEvents COMBO_TERCERO_FILTRO As ComboBox
    Friend WithEvents TXT_DOC_CLIENTE As TextBox
    Friend WithEvents TXT_NOM_CLIENTE As TextBox
    Friend WithEvents TextBox_dv_cliente As TextBox
    Friend WithEvents Button_sel_cuenta_ce As Button
    Friend WithEvents BunifuElipse9 As ns1.BunifuElipse
    Friend WithEvents BunifuCards_TERCERO As ns1.BunifuCards
    Friend WithEvents BunifuElipse10 As ns1.BunifuElipse
End Class
