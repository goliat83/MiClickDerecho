<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_impuesto
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_impuesto))
        Me.Label_doc_label = New System.Windows.Forms.Label()
        Me.datagrid_impuestos = New MetroFramework.Controls.MetroGrid()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button_opciones = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.button_crear = New System.Windows.Forms.Button()
        Me.Panel_imp_datos = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RadioButton_retencion = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox_porcentajevr = New ns1.BunifuMaterialTextbox()
        Me.combobox_cta2 = New ns1.BunifuMaterialTextbox()
        Me.combobox_cta1 = New ns1.BunifuMaterialTextbox()
        Me.Button_sel_cuenta_imp_CR = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button_sel_cuenta_imp_DB = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RadioButton_porcentaje = New System.Windows.Forms.RadioButton()
        Me.RadioButton_valor = New System.Windows.Forms.RadioButton()
        Me.Textbox_nombre = New ns1.BunifuMaterialTextbox()
        Me.Button_eliminar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_cancelar = New System.Windows.Forms.Button()
        Me.Btn_guardar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.BunifuElipse2 = New ns1.BunifuElipse(Me.components)
        Me.BunifuElipse3 = New ns1.BunifuElipse(Me.components)
        Me.BunifuElipse4 = New ns1.BunifuElipse(Me.components)
        Me.Panel_titlebar = New System.Windows.Forms.Panel()
        Me.Button_cerrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Panel_opciones = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox_categoria = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.RadioButton_aplicacategoria = New System.Windows.Forms.RadioButton()
        Me.ComboBox_impuestoaplicar = New System.Windows.Forms.ComboBox()
        Me.RadioButton_aplicatodos = New System.Windows.Forms.RadioButton()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.datagrid_impuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel_imp_datos.SuspendLayout()
        Me.Panel_titlebar.SuspendLayout()
        Me.Panel_opciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_doc_label
        '
        Me.Label_doc_label.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label_doc_label.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label_doc_label.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label_doc_label.ForeColor = System.Drawing.Color.Black
        Me.Label_doc_label.Location = New System.Drawing.Point(28, 66)
        Me.Label_doc_label.Name = "Label_doc_label"
        Me.Label_doc_label.Size = New System.Drawing.Size(285, 34)
        Me.Label_doc_label.TabIndex = 835
        Me.Label_doc_label.Text = "% Impuestos"
        Me.Label_doc_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'datagrid_impuestos
        '
        Me.datagrid_impuestos.AllowUserToAddRows = False
        Me.datagrid_impuestos.AllowUserToDeleteRows = False
        Me.datagrid_impuestos.AllowUserToResizeRows = False
        Me.datagrid_impuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagrid_impuestos.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.datagrid_impuestos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datagrid_impuestos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.datagrid_impuestos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_impuestos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.datagrid_impuestos.ColumnHeadersHeight = 30
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid_impuestos.DefaultCellStyle = DataGridViewCellStyle8
        Me.datagrid_impuestos.EnableHeadersVisualStyles = False
        Me.datagrid_impuestos.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.datagrid_impuestos.GridColor = System.Drawing.Color.SteelBlue
        Me.datagrid_impuestos.Location = New System.Drawing.Point(14, 97)
        Me.datagrid_impuestos.MultiSelect = False
        Me.datagrid_impuestos.Name = "datagrid_impuestos"
        Me.datagrid_impuestos.ReadOnly = True
        Me.datagrid_impuestos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_impuestos.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.datagrid_impuestos.RowHeadersVisible = False
        Me.datagrid_impuestos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagrid_impuestos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue
        Me.datagrid_impuestos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid_impuestos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.datagrid_impuestos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.datagrid_impuestos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.datagrid_impuestos.RowTemplate.Height = 50
        Me.datagrid_impuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrid_impuestos.Size = New System.Drawing.Size(694, 369)
        Me.datagrid_impuestos.TabIndex = 836
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Button_opciones)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.button_crear)
        Me.Panel1.Location = New System.Drawing.Point(377, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(334, 51)
        Me.Panel1.TabIndex = 837
        '
        'Button_opciones
        '
        Me.Button_opciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_opciones.BackColor = System.Drawing.Color.Transparent
        Me.Button_opciones.BackgroundImage = CType(resources.GetObject("Button_opciones.BackgroundImage"), System.Drawing.Image)
        Me.Button_opciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_opciones.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_opciones.FlatAppearance.BorderSize = 0
        Me.Button_opciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button_opciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.Button_opciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_opciones.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.75!)
        Me.Button_opciones.ForeColor = System.Drawing.Color.White
        Me.Button_opciones.Image = Global.MiClickDerecho.My.Resources.Resources.tpv1
        Me.Button_opciones.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_opciones.Location = New System.Drawing.Point(230, 5)
        Me.Button_opciones.Name = "Button_opciones"
        Me.Button_opciones.Size = New System.Drawing.Size(100, 45)
        Me.Button_opciones.TabIndex = 297
        Me.Button_opciones.Text = "Opciones"
        Me.Button_opciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_opciones.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.75!)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = Global.MiClickDerecho.My.Resources.Resources.lapizico
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(124, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 45)
        Me.Button3.TabIndex = 296
        Me.Button3.Text = "Modificar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = False
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
        Me.button_crear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.button_crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_crear.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.75!)
        Me.button_crear.ForeColor = System.Drawing.Color.White
        Me.button_crear.Image = Global.MiClickDerecho.My.Resources.Resources.agregar
        Me.button_crear.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.button_crear.Location = New System.Drawing.Point(21, 5)
        Me.button_crear.Name = "button_crear"
        Me.button_crear.Size = New System.Drawing.Size(97, 45)
        Me.button_crear.TabIndex = 295
        Me.button_crear.Text = "Nuevo"
        Me.button_crear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.button_crear.UseVisualStyleBackColor = False
        '
        'Panel_imp_datos
        '
        Me.Panel_imp_datos.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.cuadro_blanco
        Me.Panel_imp_datos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_imp_datos.Controls.Add(Me.Label4)
        Me.Panel_imp_datos.Controls.Add(Me.RadioButton_retencion)
        Me.Panel_imp_datos.Controls.Add(Me.Label8)
        Me.Panel_imp_datos.Controls.Add(Me.TextBox_porcentajevr)
        Me.Panel_imp_datos.Controls.Add(Me.combobox_cta2)
        Me.Panel_imp_datos.Controls.Add(Me.combobox_cta1)
        Me.Panel_imp_datos.Controls.Add(Me.Button_sel_cuenta_imp_CR)
        Me.Panel_imp_datos.Controls.Add(Me.Label11)
        Me.Panel_imp_datos.Controls.Add(Me.Button_sel_cuenta_imp_DB)
        Me.Panel_imp_datos.Controls.Add(Me.Label5)
        Me.Panel_imp_datos.Controls.Add(Me.RadioButton_porcentaje)
        Me.Panel_imp_datos.Controls.Add(Me.RadioButton_valor)
        Me.Panel_imp_datos.Controls.Add(Me.Textbox_nombre)
        Me.Panel_imp_datos.Controls.Add(Me.Button_eliminar)
        Me.Panel_imp_datos.Controls.Add(Me.Label2)
        Me.Panel_imp_datos.Controls.Add(Me.Btn_cancelar)
        Me.Panel_imp_datos.Controls.Add(Me.Btn_guardar)
        Me.Panel_imp_datos.Controls.Add(Me.Label3)
        Me.Panel_imp_datos.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_imp_datos.Location = New System.Drawing.Point(28, 103)
        Me.Panel_imp_datos.Name = "Panel_imp_datos"
        Me.Panel_imp_datos.Size = New System.Drawing.Size(662, 351)
        Me.Panel_imp_datos.TabIndex = 838
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(132, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(348, 13)
        Me.Label4.TabIndex = 757
        Me.Label4.Text = "______________________ Tipo ______________________"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadioButton_retencion
        '
        Me.RadioButton_retencion.AutoSize = True
        Me.RadioButton_retencion.BackColor = System.Drawing.Color.White
        Me.RadioButton_retencion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_retencion.Location = New System.Drawing.Point(375, 143)
        Me.RadioButton_retencion.Name = "RadioButton_retencion"
        Me.RadioButton_retencion.Size = New System.Drawing.Size(105, 25)
        Me.RadioButton_retencion.TabIndex = 982
        Me.RadioButton_retencion.TabStop = True
        Me.RadioButton_retencion.Text = "Retención"
        Me.RadioButton_retencion.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gray
        Me.Label8.Location = New System.Drawing.Point(22, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 981
        Me.Label8.Text = "Impuesto"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_porcentajevr
        '
        Me.TextBox_porcentajevr.BackColor = System.Drawing.Color.White
        Me.TextBox_porcentajevr.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox_porcentajevr.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.TextBox_porcentajevr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox_porcentajevr.HintForeColor = System.Drawing.Color.Empty
        Me.TextBox_porcentajevr.HintText = ""
        Me.TextBox_porcentajevr.isPassword = False
        Me.TextBox_porcentajevr.LineFocusedColor = System.Drawing.Color.Blue
        Me.TextBox_porcentajevr.LineIdleColor = System.Drawing.Color.Black
        Me.TextBox_porcentajevr.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TextBox_porcentajevr.LineThickness = 4
        Me.TextBox_porcentajevr.Location = New System.Drawing.Point(32, 144)
        Me.TextBox_porcentajevr.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextBox_porcentajevr.Name = "TextBox_porcentajevr"
        Me.TextBox_porcentajevr.Size = New System.Drawing.Size(65, 35)
        Me.TextBox_porcentajevr.TabIndex = 980
        Me.TextBox_porcentajevr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'combobox_cta2
        '
        Me.combobox_cta2.BackColor = System.Drawing.Color.White
        Me.combobox_cta2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.combobox_cta2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combobox_cta2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.combobox_cta2.HintForeColor = System.Drawing.Color.Empty
        Me.combobox_cta2.HintText = ""
        Me.combobox_cta2.isPassword = False
        Me.combobox_cta2.LineFocusedColor = System.Drawing.Color.Blue
        Me.combobox_cta2.LineIdleColor = System.Drawing.Color.Black
        Me.combobox_cta2.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.combobox_cta2.LineThickness = 3
        Me.combobox_cta2.Location = New System.Drawing.Point(31, 291)
        Me.combobox_cta2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.combobox_cta2.Name = "combobox_cta2"
        Me.combobox_cta2.Size = New System.Drawing.Size(427, 26)
        Me.combobox_cta2.TabIndex = 979
        Me.combobox_cta2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'combobox_cta1
        '
        Me.combobox_cta1.BackColor = System.Drawing.Color.White
        Me.combobox_cta1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.combobox_cta1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combobox_cta1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.combobox_cta1.HintForeColor = System.Drawing.Color.Empty
        Me.combobox_cta1.HintText = ""
        Me.combobox_cta1.isPassword = False
        Me.combobox_cta1.LineFocusedColor = System.Drawing.Color.Blue
        Me.combobox_cta1.LineIdleColor = System.Drawing.Color.Black
        Me.combobox_cta1.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.combobox_cta1.LineThickness = 2
        Me.combobox_cta1.Location = New System.Drawing.Point(31, 235)
        Me.combobox_cta1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.combobox_cta1.Name = "combobox_cta1"
        Me.combobox_cta1.Size = New System.Drawing.Size(427, 26)
        Me.combobox_cta1.TabIndex = 978
        Me.combobox_cta1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button_sel_cuenta_imp_CR
        '
        Me.Button_sel_cuenta_imp_CR.BackColor = System.Drawing.Color.Transparent
        Me.Button_sel_cuenta_imp_CR.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.menu
        Me.Button_sel_cuenta_imp_CR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_sel_cuenta_imp_CR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_sel_cuenta_imp_CR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_sel_cuenta_imp_CR.FlatAppearance.BorderSize = 0
        Me.Button_sel_cuenta_imp_CR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button_sel_cuenta_imp_CR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.Button_sel_cuenta_imp_CR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_sel_cuenta_imp_CR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Button_sel_cuenta_imp_CR.ForeColor = System.Drawing.Color.White
        Me.Button_sel_cuenta_imp_CR.Location = New System.Drawing.Point(466, 230)
        Me.Button_sel_cuenta_imp_CR.Name = "Button_sel_cuenta_imp_CR"
        Me.Button_sel_cuenta_imp_CR.Size = New System.Drawing.Size(31, 28)
        Me.Button_sel_cuenta_imp_CR.TabIndex = 977
        Me.Button_sel_cuenta_imp_CR.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Gray
        Me.Label11.Location = New System.Drawing.Point(22, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 13)
        Me.Label11.TabIndex = 614
        Me.Label11.Text = "Nombre Impuesto"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button_sel_cuenta_imp_DB
        '
        Me.Button_sel_cuenta_imp_DB.BackColor = System.Drawing.Color.Transparent
        Me.Button_sel_cuenta_imp_DB.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.menu
        Me.Button_sel_cuenta_imp_DB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_sel_cuenta_imp_DB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_sel_cuenta_imp_DB.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_sel_cuenta_imp_DB.FlatAppearance.BorderSize = 0
        Me.Button_sel_cuenta_imp_DB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button_sel_cuenta_imp_DB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.Button_sel_cuenta_imp_DB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_sel_cuenta_imp_DB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Button_sel_cuenta_imp_DB.ForeColor = System.Drawing.Color.White
        Me.Button_sel_cuenta_imp_DB.Location = New System.Drawing.Point(466, 287)
        Me.Button_sel_cuenta_imp_DB.Name = "Button_sel_cuenta_imp_DB"
        Me.Button_sel_cuenta_imp_DB.Size = New System.Drawing.Size(31, 28)
        Me.Button_sel_cuenta_imp_DB.TabIndex = 974
        Me.Button_sel_cuenta_imp_DB.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(20, 276)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 762
        Me.Label5.Text = "Cuenta Debitos"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadioButton_porcentaje
        '
        Me.RadioButton_porcentaje.AutoSize = True
        Me.RadioButton_porcentaje.BackColor = System.Drawing.Color.White
        Me.RadioButton_porcentaje.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_porcentaje.Location = New System.Drawing.Point(134, 143)
        Me.RadioButton_porcentaje.Name = "RadioButton_porcentaje"
        Me.RadioButton_porcentaje.Size = New System.Drawing.Size(110, 25)
        Me.RadioButton_porcentaje.TabIndex = 758
        Me.RadioButton_porcentaje.TabStop = True
        Me.RadioButton_porcentaje.Text = "Porcentaje"
        Me.RadioButton_porcentaje.UseVisualStyleBackColor = False
        '
        'RadioButton_valor
        '
        Me.RadioButton_valor.AutoSize = True
        Me.RadioButton_valor.BackColor = System.Drawing.Color.White
        Me.RadioButton_valor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_valor.Location = New System.Drawing.Point(270, 144)
        Me.RadioButton_valor.Name = "RadioButton_valor"
        Me.RadioButton_valor.Size = New System.Drawing.Size(68, 25)
        Me.RadioButton_valor.TabIndex = 756
        Me.RadioButton_valor.TabStop = True
        Me.RadioButton_valor.Text = "Valor"
        Me.RadioButton_valor.UseVisualStyleBackColor = False
        '
        'Textbox_nombre
        '
        Me.Textbox_nombre.BackColor = System.Drawing.Color.White
        Me.Textbox_nombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textbox_nombre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textbox_nombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Textbox_nombre.HintForeColor = System.Drawing.Color.Empty
        Me.Textbox_nombre.HintText = ""
        Me.Textbox_nombre.isPassword = False
        Me.Textbox_nombre.LineFocusedColor = System.Drawing.Color.Blue
        Me.Textbox_nombre.LineIdleColor = System.Drawing.Color.Black
        Me.Textbox_nombre.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.Textbox_nombre.LineThickness = 3
        Me.Textbox_nombre.Location = New System.Drawing.Point(31, 76)
        Me.Textbox_nombre.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Textbox_nombre.Name = "Textbox_nombre"
        Me.Textbox_nombre.Size = New System.Drawing.Size(192, 26)
        Me.Textbox_nombre.TabIndex = 755
        Me.Textbox_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button_eliminar
        '
        Me.Button_eliminar.BackColor = System.Drawing.Color.Transparent
        Me.Button_eliminar.BackgroundImage = CType(resources.GetObject("Button_eliminar.BackgroundImage"), System.Drawing.Image)
        Me.Button_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_eliminar.FlatAppearance.BorderSize = 0
        Me.Button_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.Button_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_eliminar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.75!)
        Me.Button_eliminar.ForeColor = System.Drawing.Color.White
        Me.Button_eliminar.Image = Global.MiClickDerecho.My.Resources.Resources.delete_256
        Me.Button_eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_eliminar.Location = New System.Drawing.Point(528, 210)
        Me.Button_eliminar.Name = "Button_eliminar"
        Me.Button_eliminar.Size = New System.Drawing.Size(120, 48)
        Me.Button_eliminar.TabIndex = 300
        Me.Button_eliminar.Text = "Eliminar"
        Me.Button_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_eliminar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(662, 31)
        Me.Label2.TabIndex = 618
        Me.Label2.Text = "Detalle del Impuesto"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn_cancelar
        '
        Me.Btn_cancelar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_cancelar.BackgroundImage = CType(resources.GetObject("Btn_cancelar.BackgroundImage"), System.Drawing.Image)
        Me.Btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Btn_cancelar.FlatAppearance.BorderSize = 0
        Me.Btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.Btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_cancelar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.75!)
        Me.Btn_cancelar.ForeColor = System.Drawing.Color.White
        Me.Btn_cancelar.Image = Global.MiClickDerecho.My.Resources.Resources.back
        Me.Btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_cancelar.Location = New System.Drawing.Point(528, 265)
        Me.Btn_cancelar.Name = "Btn_cancelar"
        Me.Btn_cancelar.Size = New System.Drawing.Size(120, 48)
        Me.Btn_cancelar.TabIndex = 616
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
        Me.Btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_guardar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.75!)
        Me.Btn_guardar.ForeColor = System.Drawing.Color.White
        Me.Btn_guardar.Image = Global.MiClickDerecho.My.Resources.Resources.save_icon_5427
        Me.Btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_guardar.Location = New System.Drawing.Point(528, 156)
        Me.Btn_guardar.Name = "Btn_guardar"
        Me.Btn_guardar.Size = New System.Drawing.Size(120, 48)
        Me.Btn_guardar.TabIndex = 615
        Me.Btn_guardar.Text = "Guardar"
        Me.Btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_guardar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(20, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 753
        Me.Label3.Text = "Cuenta Créditos"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me.Label_doc_label
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 5
        Me.BunifuElipse2.TargetControl = Me.datagrid_impuestos
        '
        'BunifuElipse3
        '
        Me.BunifuElipse3.ElipseRadius = 5
        Me.BunifuElipse3.TargetControl = Me.Label2
        '
        'BunifuElipse4
        '
        Me.BunifuElipse4.ElipseRadius = 5
        Me.BunifuElipse4.TargetControl = Me
        '
        'Panel_titlebar
        '
        Me.Panel_titlebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel_titlebar.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.banner9
        Me.Panel_titlebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_titlebar.Controls.Add(Me.Button_cerrar)
        Me.Panel_titlebar.Controls.Add(Me.Label1)
        Me.Panel_titlebar.Controls.Add(Me.Button6)
        Me.Panel_titlebar.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_titlebar.Location = New System.Drawing.Point(0, 0)
        Me.Panel_titlebar.Name = "Panel_titlebar"
        Me.Panel_titlebar.Size = New System.Drawing.Size(723, 34)
        Me.Panel_titlebar.TabIndex = 839
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
        Me.Button_cerrar.Location = New System.Drawing.Point(690, 5)
        Me.Button_cerrar.Name = "Button_cerrar"
        Me.Button_cerrar.Size = New System.Drawing.Size(25, 25)
        Me.Button_cerrar.TabIndex = 444
        Me.Button_cerrar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(47, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 23)
        Me.Label1.TabIndex = 388
        Me.Label1.Text = "Impuestos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.taxes
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Transparent
        Me.Button6.Location = New System.Drawing.Point(9, 1)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(39, 34)
        Me.Button6.TabIndex = 443
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Panel_opciones
        '
        Me.Panel_opciones.Controls.Add(Me.Button1)
        Me.Panel_opciones.Controls.Add(Me.Label7)
        Me.Panel_opciones.Controls.Add(Me.ComboBox_categoria)
        Me.Panel_opciones.Controls.Add(Me.Label6)
        Me.Panel_opciones.Controls.Add(Me.Label29)
        Me.Panel_opciones.Controls.Add(Me.RadioButton_aplicacategoria)
        Me.Panel_opciones.Controls.Add(Me.ComboBox_impuestoaplicar)
        Me.Panel_opciones.Controls.Add(Me.RadioButton_aplicatodos)
        Me.Panel_opciones.Controls.Add(Me.Button4)
        Me.Panel_opciones.Location = New System.Drawing.Point(50, 131)
        Me.Panel_opciones.Name = "Panel_opciones"
        Me.Panel_opciones.Size = New System.Drawing.Size(620, 306)
        Me.Panel_opciones.TabIndex = 840
        Me.Panel_opciones.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = Global.MiClickDerecho.My.Resources.Resources.back
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.Location = New System.Drawing.Point(471, 246)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 54)
        Me.Button1.TabIndex = 769
        Me.Button1.Text = "Regresar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(27, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 15)
        Me.Label7.TabIndex = 768
        Me.Label7.Text = "Categoría"
        '
        'ComboBox_categoria
        '
        Me.ComboBox_categoria.AutoCompleteCustomSource.AddRange(New String() {"MEDELLIN - ANTIOQUIA", "ABEJORRAL - ANTIOQUIA", "ABRIAQUI - ANTIOQUIA", "ALEJANDRIA - ANTIOQUIA", "AMAGA - ANTIOQUIA", "AMALFI - ANTIOQUIA", "ANDES - ANTIOQUIA", "ANGELOPOLIS - ANTIOQUIA", "ANGOSTURA - ANTIOQUIA", "ANORI - ANTIOQUIA", "SANTAFE DE ANTIOQUIA - ANTIOQUIA", "ANZA - ANTIOQUIA", "APARTADO - ANTIOQUIA", "ARBOLETES - ANTIOQUIA", "ARGELIA - ANTIOQUIA", "ARMENIA - ANTIOQUIA", "BARBOSA - ANTIOQUIA", "BELMIRA - ANTIOQUIA", "BELLO - ANTIOQUIA", "BETANIA - ANTIOQUIA", "BETULIA - ANTIOQUIA", "CIUDAD BOLIVAR - ANTIOQUIA", "BRICEÑO - ANTIOQUIA", "BURITICA - ANTIOQUIA", "CACERES - ANTIOQUIA", "CAICEDO - ANTIOQUIA", "CALDAS - ANTIOQUIA", "CAMPAMENTO - ANTIOQUIA", "CAÑASGORDAS - ANTIOQUIA", "CARACOLI - ANTIOQUIA", "CARAMANTA - ANTIOQUIA", "CAREPA - ANTIOQUIA", "EL CARMEN DE VIBORAL - ANTIOQUIA", "CAROLINA - ANTIOQUIA", "CAUCASIA - ANTIOQUIA", "CHIGORODO - ANTIOQUIA", "CISNEROS - ANTIOQUIA", "COCORNA - ANTIOQUIA", "CONCEPCION - ANTIOQUIA", "CONCORDIA - ANTIOQUIA", "COPACABANA - ANTIOQUIA", "DABEIBA - ANTIOQUIA", "DON MATIAS - ANTIOQUIA", "EBEJICO - ANTIOQUIA", "EL BAGRE - ANTIOQUIA", "ENTRERRIOS - ANTIOQUIA", "ENVIGADO - ANTIOQUIA", "FREDONIA - ANTIOQUIA", "FRONTINO - ANTIOQUIA", "GIRALDO - ANTIOQUIA", "GIRARDOTA - ANTIOQUIA", "GOMEZ PLATA - ANTIOQUIA", "GRANADA - ANTIOQUIA", "GUADALUPE - ANTIOQUIA", "GUARNE - ANTIOQUIA", "GUATAPE - ANTIOQUIA", "HELICONIA - ANTIOQUIA", "HISPANIA - ANTIOQUIA", "ITAGUI - ANTIOQUIA", "ITUANGO - ANTIOQUIA", "JARDIN - ANTIOQUIA", "JERICO - ANTIOQUIA", "LA CEJA - ANTIOQUIA", "LA ESTRELLA - ANTIOQUIA", "LA PINTADA - ANTIOQUIA", "LA UNION - ANTIOQUIA", "LIBORINA - ANTIOQUIA", "MACEO - ANTIOQUIA", "MARINILLA - ANTIOQUIA", "MONTEBELLO - ANTIOQUIA", "MURINDO - ANTIOQUIA", "MUTATA - ANTIOQUIA", "NARIÑO - ANTIOQUIA", "NECOCLI - ANTIOQUIA", "NECHI - ANTIOQUIA", "OLAYA - ANTIOQUIA", "PEÐOL - ANTIOQUIA", "PEQUE - ANTIOQUIA", "PUEBLORRICO - ANTIOQUIA", "PUERTO BERRIO - ANTIOQUIA", "PUERTO NARE - ANTIOQUIA", "PUERTO TRIUNFO - ANTIOQUIA", "REMEDIOS - ANTIOQUIA", "RETIRO - ANTIOQUIA", "RIONEGRO - ANTIOQUIA", "SABANALARGA - ANTIOQUIA", "SABANETA - ANTIOQUIA", "SALGAR - ANTIOQUIA", "SAN ANDRES DE CUERQUIA - ANTIOQUIA", "SAN CARLOS - ANTIOQUIA", "SAN FRANCISCO - ANTIOQUIA", "SAN JERONIMO - ANTIOQUIA", "SAN JOSE DE LA MONTAÑA - ANTIOQUIA", "SAN JUAN DE URABA - ANTIOQUIA", "SAN LUIS - ANTIOQUIA", "SAN PEDRO - ANTIOQUIA", "SAN PEDRO DE URABA - ANTIOQUIA", "SAN RAFAEL - ANTIOQUIA", "SAN ROQUE - ANTIOQUIA", "SAN VICENTE - ANTIOQUIA", "SANTA BARBARA - ANTIOQUIA", "SANTA ROSA DE OSOS - ANTIOQUIA", "SANTO DOMINGO - ANTIOQUIA", "EL SANTUARIO - ANTIOQUIA", "SEGOVIA - ANTIOQUIA", "SONSON - ANTIOQUIA", "SOPETRAN - ANTIOQUIA", "TAMESIS - ANTIOQUIA", "TARAZA - ANTIOQUIA", "TARSO - ANTIOQUIA", "TITIRIBI - ANTIOQUIA", "TOLEDO - ANTIOQUIA", "TURBO - ANTIOQUIA", "URAMITA - ANTIOQUIA", "URRAO - ANTIOQUIA", "VALDIVIA - ANTIOQUIA", "VALPARAISO - ANTIOQUIA", "VEGACHI - ANTIOQUIA", "VENECIA - ANTIOQUIA", "VIGIA DEL FUERTE - ANTIOQUIA", "YALI - ANTIOQUIA", "YARUMAL - ANTIOQUIA", "YOLOMBO - ANTIOQUIA", "YONDO - ANTIOQUIA", "ZARAGOZA - ANTIOQUIA", "BARRANQUILLA - ATLANTICO", "BARANOA - ATLANTICO", "CAMPO DE LA CRUZ - ATLANTICO", "CANDELARIA - ATLANTICO", "GALAPA - ATLANTICO", "JUAN DE ACOSTA - ATLANTICO", "LURUACO - ATLANTICO", "MALAMBO - ATLANTICO", "MANATI - ATLANTICO", "PALMAR DE VARELA - ATLANTICO", "PIOJO - ATLANTICO", "POLONUEVO - ATLANTICO", "PONEDERA - ATLANTICO", "PUERTO COLOMBIA - ATLANTICO", "REPELON - ATLANTICO", "SABANAGRANDE - ATLANTICO", "SABANALARGA - ATLANTICO", "SANTA LUCIA - ATLANTICO", "SANTO TOMAS - ATLANTICO", "SOLEDAD - ATLANTICO", "SUAN - ATLANTICO", "TUBARA - ATLANTICO", "USIACURI - ATLANTICO", "BOGOTA, D.C. - BOGOTA", "CARTAGENA - BOLIVAR", "ACHI - BOLIVAR", "ALTOS DEL ROSARIO - BOLIVAR", "ARENAL - BOLIVAR", "ARJONA - BOLIVAR", "ARROYOHONDO - BOLIVAR", "BARRANCO DE LOBA - BOLIVAR", "CALAMAR - BOLIVAR", "CANTAGALLO - BOLIVAR", "CICUCO - BOLIVAR", "CORDOBA - BOLIVAR", "CLEMENCIA - BOLIVAR", "EL CARMEN DE BOLIVAR - BOLIVAR", "EL GUAMO - BOLIVAR", "EL PEÑON - BOLIVAR", "HATILLO DE LOBA - BOLIVAR", "MAGANGUE - BOLIVAR", "MAHATES - BOLIVAR", "MARGARITA - BOLIVAR", "MARIA LA BAJA - BOLIVAR", "MONTECRISTO - BOLIVAR", "MOMPOS - BOLIVAR", "NOROSI - BOLIVAR", "MORALES - BOLIVAR", "PINILLOS - BOLIVAR", "REGIDOR - BOLIVAR", "RIO VIEJO - BOLIVAR", "SAN CRISTOBAL - BOLIVAR", "SAN ESTANISLAO - BOLIVAR", "SAN FERNANDO - BOLIVAR", "SAN JACINTO - BOLIVAR", "SAN JACINTO DEL CAUCA - BOLIVAR", "SAN JUAN NEPOMUCENO - BOLIVAR", "SAN MARTIN DE LOBA - BOLIVAR", "SAN PABLO - BOLIVAR", "SANTA CATALINA - BOLIVAR", "SANTA ROSA - BOLIVAR", "SANTA ROSA DEL SUR - BOLIVAR", "SIMITI - BOLIVAR", "SOPLAVIENTO - BOLIVAR", "TALAIGUA NUEVO - BOLIVAR", "TIQUISIO - BOLIVAR", "TURBACO - BOLIVAR", "TURBANA - BOLIVAR", "VILLANUEVA - BOLIVAR", "ZAMBRANO - BOLIVAR", "TUNJA - BOYACA", "ALMEIDA - BOYACA", "AQUITANIA - BOYACA", "ARCABUCO - BOYACA", "BELEN - BOYACA", "BERBEO - BOYACA", "BETEITIVA - BOYACA", "BOAVITA - BOYACA", "BOYACA - BOYACA", "BRICEÑO - BOYACA", "BUENAVISTA - BOYACA", "BUSBANZA - BOYACA", "CALDAS - BOYACA", "CAMPOHERMOSO - BOYACA", "CERINZA - BOYACA", "CHINAVITA - BOYACA", "CHIQUINQUIRA - BOYACA", "CHISCAS - BOYACA", "CHITA - BOYACA", "CHITARAQUE - BOYACA", "CHIVATA - BOYACA", "CIENEGA - BOYACA", "COMBITA - BOYACA", "COPER - BOYACA", "CORRALES - BOYACA", "COVARACHIA - BOYACA", "CUBARA - BOYACA", "CUCAITA - BOYACA", "CUITIVA - BOYACA", "CHIQUIZA - BOYACA", "CHIVOR - BOYACA", "DUITAMA - BOYACA", "EL COCUY - BOYACA", "EL ESPINO - BOYACA", "FIRAVITOBA - BOYACA", "FLORESTA - BOYACA", "GACHANTIVA - BOYACA", "GAMEZA - BOYACA", "GARAGOA - BOYACA", "GUACAMAYAS - BOYACA", "GUATEQUE - BOYACA", "GUAYATA - BOYACA", "GsICAN - BOYACA", "IZA - BOYACA", "JENESANO - BOYACA", "JERICO - BOYACA", "LABRANZAGRANDE - BOYACA", "LA CAPILLA - BOYACA", "LA VICTORIA - BOYACA", "LA UVITA - BOYACA", "VILLA DE LEYVA - BOYACA", "MACANAL - BOYACA", "MARIPI - BOYACA", "MIRAFLORES - BOYACA", "MONGUA - BOYACA", "MONGUI - BOYACA", "MONIQUIRA - BOYACA", "MOTAVITA - BOYACA", "MUZO - BOYACA", "NOBSA - BOYACA", "NUEVO COLON - BOYACA", "OICATA - BOYACA", "OTANCHE - BOYACA", "PACHAVITA - BOYACA", "PAEZ - BOYACA", "PAIPA - BOYACA", "PAJARITO - BOYACA", "PANQUEBA - BOYACA", "PAUNA - BOYACA", "PAYA - BOYACA", "PAZ DE RIO - BOYACA", "PESCA - BOYACA", "PISBA - BOYACA", "PUERTO BOYACA - BOYACA", "QUIPAMA - BOYACA", "RAMIRIQUI - BOYACA", "RAQUIRA - BOYACA", "RONDON - BOYACA", "SABOYA - BOYACA", "SACHICA - BOYACA", "SAMACA - BOYACA", "SAN EDUARDO - BOYACA", "SAN JOSE DE PARE - BOYACA", "SAN LUIS DE GACENO - BOYACA", "SAN MATEO - BOYACA", "SAN MIGUEL DE SEMA - BOYACA", "SAN PABLO DE BORBUR - BOYACA", "SANTANA - BOYACA", "SANTA MARIA - BOYACA", "SANTA ROSA DE VITERBO - BOYACA", "SANTA SOFIA - BOYACA", "SATIVANORTE - BOYACA", "SATIVASUR - BOYACA", "SIACHOQUE - BOYACA", "SOATA - BOYACA", "SOCOTA - BOYACA", "SOCHA - BOYACA", "SOGAMOSO - BOYACA", "SOMONDOCO - BOYACA", "SORA - BOYACA", "SOTAQUIRA - BOYACA", "SORACA - BOYACA", "SUSACON - BOYACA", "SUTAMARCHAN - BOYACA", "SUTATENZA - BOYACA", "TASCO - BOYACA", "TENZA - BOYACA", "TIBANA - BOYACA", "TIBASOSA - BOYACA", "TINJACA - BOYACA", "TIPACOQUE - BOYACA", "TOCA - BOYACA", "TOGsI - BOYACA", "TOPAGA - BOYACA", "TOTA - BOYACA", "TUNUNGUA - BOYACA", "TURMEQUE - BOYACA", "TUTA - BOYACA", "TUTAZA - BOYACA", "UMBITA - BOYACA", "VENTAQUEMADA - BOYACA", "VIRACACHA - BOYACA", "ZETAQUIRA - BOYACA", "MANIZALES - CALDAS", "AGUADAS - CALDAS", "ANSERMA - CALDAS", "ARANZAZU - CALDAS", "BELALCAZAR - CALDAS", "CHINCHINA - CALDAS", "FILADELFIA - CALDAS", "LA DORADA - CALDAS", "LA MERCED - CALDAS", "MANZANARES - CALDAS", "MARMATO - CALDAS", "MARQUETALIA - CALDAS", "MARULANDA - CALDAS", "NEIRA - CALDAS", "NORCASIA - CALDAS", "PACORA - CALDAS", "PALESTINA - CALDAS", "PENSILVANIA - CALDAS", "RIOSUCIO - CALDAS", "RISARALDA - CALDAS", "SALAMINA - CALDAS", "SAMANA - CALDAS", "SAN JOSE - CALDAS", "SUPIA - CALDAS", "VICTORIA - CALDAS", "VILLAMARIA - CALDAS", "VITERBO - CALDAS", "FLORENCIA - CAQUETA", "ALBANIA - CAQUETA", "BELEN DE LOS ANDAQUIES - CAQUETA", "CARTAGENA DEL CHAIRA - CAQUETA", "CURILLO - CAQUETA", "EL DONCELLO - CAQUETA", "EL PAUJIL - CAQUETA", "LA MONTAÑITA - CAQUETA", "MILAN - CAQUETA", "MORELIA - CAQUETA", "PUERTO RICO - CAQUETA", "SAN JOSE DEL FRAGUA - CAQUETA", "SAN VICENTE DEL CAGUAN - CAQUETA", "SOLANO - CAQUETA", "SOLITA - CAQUETA", "VALPARAISO - CAQUETA", "POPAYAN - CAUCA", "ALMAGUER - CAUCA", "ARGELIA - CAUCA", "BALBOA - CAUCA", "BOLIVAR - CAUCA", "BUENOS AIRES - CAUCA", "CAJIBIO - CAUCA", "CALDONO - CAUCA", "CALOTO - CAUCA", "CORINTO - CAUCA", "EL TAMBO - CAUCA", "FLORENCIA - CAUCA", "GUACHENE - CAUCA", "GUAPI - CAUCA", "INZA - CAUCA", "JAMBALO - CAUCA", "LA SIERRA - CAUCA", "LA VEGA - CAUCA", "LOPEZ - CAUCA", "MERCADERES - CAUCA", "MIRANDA - CAUCA", "MORALES - CAUCA", "PADILLA - CAUCA", "PAEZ - CAUCA", "PATIA - CAUCA", "PIAMONTE - CAUCA", "PIENDAMO - CAUCA", "PUERTO TEJADA - CAUCA", "PURACE - CAUCA", "ROSAS - CAUCA", "SAN SEBASTIAN - CAUCA", "SANTANDER DE QUILICHAO - CAUCA", "SANTA ROSA - CAUCA", "SILVIA - CAUCA", "SOTARA - CAUCA", "SUAREZ - CAUCA", "SUCRE - CAUCA", "TIMBIO - CAUCA", "TIMBIQUI - CAUCA", "TORIBIO - CAUCA", "TOTORO - CAUCA", "VILLA RICA - CAUCA", "VALLEDUPAR - CESAR", "AGUACHICA - CESAR", "AGUSTIN CODAZZI - CESAR", "ASTREA - CESAR", "BECERRIL - CESAR", "BOSCONIA - CESAR", "CHIMICHAGUA - CESAR", "CHIRIGUANA - CESAR", "CURUMANI - CESAR", "EL COPEY - CESAR", "EL PASO - CESAR", "GAMARRA - CESAR", "GONZALEZ - CESAR", "LA GLORIA - CESAR", "LA JAGUA DE IBIRICO - CESAR", "MANAURE - CESAR", "PAILITAS - CESAR", "PELAYA - CESAR", "PUEBLO BELLO - CESAR", "RIO DE ORO - CESAR", "LA PAZ - CESAR", "SAN ALBERTO - CESAR", "SAN DIEGO - CESAR", "SAN MARTIN - CESAR", "TAMALAMEQUE - CESAR", "MONTERIA - CORDOBA", "AYAPEL - CORDOBA", "BUENAVISTA - CORDOBA", "CANALETE - CORDOBA", "CERETE - CORDOBA", "CHIMA - CORDOBA", "CHINU - CORDOBA", "CIENAGA DE ORO - CORDOBA", "COTORRA - CORDOBA", "LA APARTADA - CORDOBA", "LORICA - CORDOBA", "LOS CORDOBAS - CORDOBA", "MOMIL - CORDOBA", "MONTELIBANO - CORDOBA", "MOÑITOS - CORDOBA", "PLANETA RICA - CORDOBA", "PUEBLO NUEVO - CORDOBA", "PUERTO ESCONDIDO - CORDOBA", "PUERTO LIBERTADOR - CORDOBA", "PURISIMA - CORDOBA", "SAHAGUN - CORDOBA", "SAN ANDRES SOTAVENTO - CORDOBA", "SAN ANTERO - CORDOBA", "SAN BERNARDO DEL VIENTO - CORDOBA", "SAN CARLOS - CORDOBA", "SAN PELAYO - CORDOBA", "TIERRALTA - CORDOBA", "VALENCIA - CORDOBA", "AGUA DE DIOS - CUNDINAMARCA", "ALBAN - CUNDINAMARCA", "ANAPOIMA - CUNDINAMARCA", "ANOLAIMA - CUNDINAMARCA", "ARBELAEZ - CUNDINAMARCA", "BELTRAN - CUNDINAMARCA", "BITUIMA - CUNDINAMARCA", "BOJACA - CUNDINAMARCA", "CABRERA - CUNDINAMARCA", "CACHIPAY - CUNDINAMARCA", "CAJICA - CUNDINAMARCA", "CAPARRAPI - CUNDINAMARCA", "CAQUEZA - CUNDINAMARCA", "CARMEN DE CARUPA - CUNDINAMARCA", "CHAGUANI - CUNDINAMARCA", "CHIA - CUNDINAMARCA", "CHIPAQUE - CUNDINAMARCA", "CHOACHI - CUNDINAMARCA", "CHOCONTA - CUNDINAMARCA", "COGUA - CUNDINAMARCA", "COTA - CUNDINAMARCA", "CUCUNUBA - CUNDINAMARCA", "EL COLEGIO - CUNDINAMARCA", "EL PEÑON - CUNDINAMARCA", "EL ROSAL - CUNDINAMARCA", "FACATATIVA - CUNDINAMARCA", "FOMEQUE - CUNDINAMARCA", "FOSCA - CUNDINAMARCA", "FUNZA - CUNDINAMARCA", "FUQUENE - CUNDINAMARCA", "FUSAGASUGA - CUNDINAMARCA", "GACHALA - CUNDINAMARCA", "GACHANCIPA - CUNDINAMARCA", "GACHETA - CUNDINAMARCA", "GAMA - CUNDINAMARCA", "GIRARDOT - CUNDINAMARCA", "GRANADA - CUNDINAMARCA", "GUACHETA - CUNDINAMARCA", "GUADUAS - CUNDINAMARCA", "GUASCA - CUNDINAMARCA", "GUATAQUI - CUNDINAMARCA", "GUATAVITA - CUNDINAMARCA", "GUAYABAL DE SIQUIMA - CUNDINAMARCA", "GUAYABETAL - CUNDINAMARCA", "GUTIERREZ - CUNDINAMARCA", "JERUSALEN - CUNDINAMARCA", "JUNIN - CUNDINAMARCA", "LA CALERA - CUNDINAMARCA", "LA MESA - CUNDINAMARCA", "LA PALMA - CUNDINAMARCA", "LA PEÑA - CUNDINAMARCA", "LA VEGA - CUNDINAMARCA", "LENGUAZAQUE - CUNDINAMARCA", "MACHETA - CUNDINAMARCA", "MADRID - CUNDINAMARCA", "MANTA - CUNDINAMARCA", "MEDINA - CUNDINAMARCA", "MOSQUERA - CUNDINAMARCA", "NARIÑO - CUNDINAMARCA", "NEMOCON - CUNDINAMARCA", "NILO - CUNDINAMARCA", "NIMAIMA - CUNDINAMARCA", "NOCAIMA - CUNDINAMARCA", "VENECIA - CUNDINAMARCA", "PACHO - CUNDINAMARCA", "PAIME - CUNDINAMARCA", "PANDI - CUNDINAMARCA", "PARATEBUENO - CUNDINAMARCA", "PASCA - CUNDINAMARCA", "PUERTO SALGAR - CUNDINAMARCA", "PULI - CUNDINAMARCA", "QUEBRADANEGRA - CUNDINAMARCA", "QUETAME - CUNDINAMARCA", "QUIPILE - CUNDINAMARCA", "APULO - CUNDINAMARCA", "RICAURTE - CUNDINAMARCA", "SAN ANTONIO DEL TEQUENDAMA - CUNDINAMARCA", "SAN BERNARDO - CUNDINAMARCA", "SAN CAYETANO - CUNDINAMARCA", "SAN FRANCISCO - CUNDINAMARCA", "SAN JUAN DE RIO SECO - CUNDINAMARCA", "SASAIMA - CUNDINAMARCA", "SESQUILE - CUNDINAMARCA", "SIBATE - CUNDINAMARCA", "SILVANIA - CUNDINAMARCA", "SIMIJACA - CUNDINAMARCA", "SOACHA - CUNDINAMARCA", "SOPO - CUNDINAMARCA", "SUBACHOQUE - CUNDINAMARCA", "SUESCA - CUNDINAMARCA", "SUPATA - CUNDINAMARCA", "SUSA - CUNDINAMARCA", "SUTATAUSA - CUNDINAMARCA", "TABIO - CUNDINAMARCA", "TAUSA - CUNDINAMARCA", "TENA - CUNDINAMARCA", "TENJO - CUNDINAMARCA", "TIBACUY - CUNDINAMARCA", "TIBIRITA - CUNDINAMARCA", "TOCAIMA - CUNDINAMARCA", "TOCANCIPA - CUNDINAMARCA", "TOPAIPI - CUNDINAMARCA", "UBALA - CUNDINAMARCA", "UBAQUE - CUNDINAMARCA", "VILLA DE SAN DIEGO DE UBATE - CUNDINAMARCA", "UNE - CUNDINAMARCA", "UTICA - CUNDINAMARCA", "VERGARA - CUNDINAMARCA", "VIANI - CUNDINAMARCA", "VILLAGOMEZ - CUNDINAMARCA", "VILLAPINZON - CUNDINAMARCA", "VILLETA - CUNDINAMARCA", "VIOTA - CUNDINAMARCA", "YACOPI - CUNDINAMARCA", "ZIPACON - CUNDINAMARCA", "ZIPAQUIRA - CUNDINAMARCA", "QUIBDO - CHOCO", "ACANDI - CHOCO", "ALTO BAUDO - CHOCO", "ATRATO - CHOCO", "BAGADO - CHOCO", "BAHIA SOLANO - CHOCO", "BAJO BAUDO - CHOCO", "BOJAYA - CHOCO", "EL CANTON DEL SAN PABLO - CHOCO", "CARMEN DEL DARIEN - CHOCO", "CERTEGUI - CHOCO", "CONDOTO - CHOCO", "EL CARMEN DE ATRATO - CHOCO", "EL LITORAL DEL SAN JUAN - CHOCO", "ISTMINA - CHOCO", "JURADO - CHOCO", "LLORO - CHOCO", "MEDIO ATRATO - CHOCO", "MEDIO BAUDO - CHOCO", "MEDIO SAN JUAN - CHOCO", "NOVITA - CHOCO", "NUQUI - CHOCO", "RIO IRO - CHOCO", "RIO QUITO - CHOCO", "RIOSUCIO - CHOCO", "SAN JOSE DEL PALMAR - CHOCO", "SIPI - CHOCO", "TADO - CHOCO", "UNGUIA - CHOCO", "UNION PANAMERICANA - CHOCO", "NEIVA - HUILA", "ACEVEDO - HUILA", "AGRADO - HUILA", "AIPE - HUILA", "ALGECIRAS - HUILA", "ALTAMIRA - HUILA", "BARAYA - HUILA", "CAMPOALEGRE - HUILA", "COLOMBIA - HUILA", "ELIAS - HUILA", "GARZON - HUILA", "GIGANTE - HUILA", "GUADALUPE - HUILA", "HOBO - HUILA", "IQUIRA - HUILA", "ISNOS - HUILA", "LA ARGENTINA - HUILA", "LA PLATA - HUILA", "NATAGA - HUILA", "OPORAPA - HUILA", "PAICOL - HUILA", "PALERMO - HUILA", "PALESTINA - HUILA", "PITAL - HUILA", "PITALITO - HUILA", "RIVERA - HUILA", "SALADOBLANCO - HUILA", "SAN AGUSTIN - HUILA", "SANTA MARIA - HUILA", "SUAZA - HUILA", "TARQUI - HUILA", "TESALIA - HUILA", "TELLO - HUILA", "TERUEL - HUILA", "TIMANA - HUILA", "VILLAVIEJA - HUILA", "YAGUARA - HUILA", "RIOHACHA - LA GUAJIRA", "ALBANIA - LA GUAJIRA", "BARRANCAS - LA GUAJIRA", "DIBULLA - LA GUAJIRA", "DISTRACCION - LA GUAJIRA", "EL MOLINO - LA GUAJIRA", "FONSECA - LA GUAJIRA", "HATONUEVO - LA GUAJIRA", "LA JAGUA DEL PILAR - LA GUAJIRA", "MAICAO - LA GUAJIRA", "MANAURE - LA GUAJIRA", "SAN JUAN DEL CESAR - LA GUAJIRA", "URIBIA - LA GUAJIRA", "URUMITA - LA GUAJIRA", "VILLANUEVA - LA GUAJIRA", "SANTA MARTA - MAGDALENA", "ALGARROBO - MAGDALENA", "ARACATACA - MAGDALENA", "ARIGUANI - MAGDALENA", "CERRO SAN ANTONIO - MAGDALENA", "CHIBOLO - MAGDALENA", "CIENAGA - MAGDALENA", "CONCORDIA - MAGDALENA", "EL BANCO - MAGDALENA", "EL PIÑON - MAGDALENA", "EL RETEN - MAGDALENA", "FUNDACION - MAGDALENA", "GUAMAL - MAGDALENA", "NUEVA GRANADA - MAGDALENA", "PEDRAZA - MAGDALENA", "PIJIÑO DEL CARMEN - MAGDALENA", "PIVIJAY - MAGDALENA", "PLATO - MAGDALENA", "PUEBLOVIEJO - MAGDALENA", "REMOLINO - MAGDALENA", "SABANAS DE SAN ANGEL - MAGDALENA", "SALAMINA - MAGDALENA", "SAN SEBASTIAN DE BUENAVISTA - MAGDALENA", "SAN ZENON - MAGDALENA", "SANTA ANA - MAGDALENA", "SANTA BARBARA DE PINTO - MAGDALENA", "SITIONUEVO - MAGDALENA", "TENERIFE - MAGDALENA", "ZAPAYAN - MAGDALENA", "ZONA BANANERA - MAGDALENA", "VILLAVICENCIO - META", "ACACIAS - META", "BARRANCA DE UPIA - META", "CABUYARO - META", "CASTILLA LA NUEVA - META", "CUBARRAL - META", "CUMARAL - META", "EL CALVARIO - META", "EL CASTILLO - META", "EL DORADO - META", "FUENTE DE ORO - META", "GRANADA - META", "GUAMAL - META", "MAPIRIPAN - META", "MESETAS - META", "LA MACARENA - META", "URIBE - META", "LEJANIAS - META", "PUERTO CONCORDIA - META", "PUERTO GAITAN - META", "PUERTO LOPEZ - META", "PUERTO LLERAS - META", "PUERTO RICO - META", "RESTREPO - META", "SAN CARLOS DE GUAROA - META", "SAN JUAN DE ARAMA - META", "SAN JUANITO - META", "SAN MARTIN - META", "VISTAHERMOSA - META", "PASTO - NARIÑO", "ALBAN - NARIÑO", "ALDANA - NARIÑO", "ANCUYA - NARIÑO", "ARBOLEDA - NARIÑO", "BARBACOAS - NARIÑO", "BELEN - NARIÑO", "BUESACO - NARIÑO", "COLON - NARIÑO", "CONSACA - NARIÑO", "CONTADERO - NARIÑO", "CORDOBA - NARIÑO", "CUASPUD - NARIÑO", "CUMBAL - NARIÑO", "CUMBITARA - NARIÑO", "CHACHAGsI - NARIÑO", "EL CHARCO - NARIÑO", "EL PEÑOL - NARIÑO", "EL ROSARIO - NARIÑO", "EL TABLON DE GOMEZ - NARIÑO", "EL TAMBO - NARIÑO", "FUNES - NARIÑO", "GUACHUCAL - NARIÑO", "GUAITARILLA - NARIÑO", "GUALMATAN - NARIÑO", "ILES - NARIÑO", "IMUES - NARIÑO", "IPIALES - NARIÑO", "LA CRUZ - NARIÑO", "LA FLORIDA - NARIÑO", "LA LLANADA - NARIÑO", "LA TOLA - NARIÑO", "LA UNION - NARIÑO", "LEIVA - NARIÑO", "LINARES - NARIÑO", "LOS ANDES - NARIÑO", "MAGsI - NARIÑO", "MALLAMA - NARIÑO", "MOSQUERA - NARIÑO", "NARIÑO - NARIÑO", "OLAYA HERRERA - NARIÑO", "OSPINA - NARIÑO", "FRANCISCO PIZARRO - NARIÑO", "POLICARPA - NARIÑO", "POTOSI - NARIÑO", "PROVIDENCIA - NARIÑO", "PUERRES - NARIÑO", "PUPIALES - NARIÑO", "RICAURTE - NARIÑO", "ROBERTO PAYAN - NARIÑO", "SAMANIEGO - NARIÑO", "SANDONA - NARIÑO", "SAN BERNARDO - NARIÑO", "SAN LORENZO - NARIÑO", "SAN PABLO - NARIÑO", "SAN PEDRO DE CARTAGO - NARIÑO", "SANTA BARBARA - NARIÑO", "SANTACRUZ - NARIÑO", "SAPUYES - NARIÑO", "TAMINANGO - NARIÑO", "TANGUA - NARIÑO", "SAN ANDRES DE TUMACO - NARIÑO", "TUQUERRES - NARIÑO", "YACUANQUER - NARIÑO", "CUCUTA - N. DE SANTANDER", "ABREGO - N. DE SANTANDER", "ARBOLEDAS - N. DE SANTANDER", "BOCHALEMA - N. DE SANTANDER", "BUCARASICA - N. DE SANTANDER", "CACOTA - N. DE SANTANDER", "CACHIRA - N. DE SANTANDER", "CHINACOTA - N. DE SANTANDER", "CHITAGA - N. DE SANTANDER", "CONVENCION - N. DE SANTANDER", "CUCUTILLA - N. DE SANTANDER", "DURANIA - N. DE SANTANDER", "EL CARMEN - N. DE SANTANDER", "EL TARRA - N. DE SANTANDER", "EL ZULIA - N. DE SANTANDER", "GRAMALOTE - N. DE SANTANDER", "HACARI - N. DE SANTANDER", "HERRAN - N. DE SANTANDER", "LABATECA - N. DE SANTANDER", "LA ESPERANZA - N. DE SANTANDER", "LA PLAYA - N. DE SANTANDER", "LOS PATIOS - N. DE SANTANDER", "LOURDES - N. DE SANTANDER", "MUTISCUA - N. DE SANTANDER", "OCAÑA - N. DE SANTANDER", "PAMPLONA - N. DE SANTANDER", "PAMPLONITA - N. DE SANTANDER", "PUERTO SANTANDER - N. DE SANTANDER", "RAGONVALIA - N. DE SANTANDER", "SALAZAR - N. DE SANTANDER", "SAN CALIXTO - N. DE SANTANDER", "SAN CAYETANO - N. DE SANTANDER", "SANTIAGO - N. DE SANTANDER", "SARDINATA - N. DE SANTANDER", "SILOS - N. DE SANTANDER", "TEORAMA - N. DE SANTANDER", "TIBU - N. DE SANTANDER", "TOLEDO - N. DE SANTANDER", "VILLA CARO - N. DE SANTANDER", "VILLA DEL ROSARIO - N. DE SANTANDER", "ARMENIA - QUINDIO", "BUENAVISTA - QUINDIO", "CALARCA - QUINDIO", "CIRCASIA - QUINDIO", "CORDOBA - QUINDIO", "FILANDIA - QUINDIO", "GENOVA - QUINDIO", "LA TEBAIDA - QUINDIO", "MONTENEGRO - QUINDIO", "PIJAO - QUINDIO", "QUIMBAYA - QUINDIO", "SALENTO - QUINDIO", "PEREIRA - RISARALDA", "APIA - RISARALDA", "BALBOA - RISARALDA", "BELEN DE UMBRIA - RISARALDA", "DOSQUEBRADAS - RISARALDA", "GUATICA - RISARALDA", "LA CELIA - RISARALDA", "LA VIRGINIA - RISARALDA", "MARSELLA - RISARALDA", "MISTRATO - RISARALDA", "PUEBLO RICO - RISARALDA", "QUINCHIA - RISARALDA", "SANTA ROSA DE CABAL - RISARALDA", "SANTUARIO - RISARALDA", "BUCARAMANGA - SANTANDER", "AGUADA - SANTANDER", "ALBANIA - SANTANDER", "ARATOCA - SANTANDER", "BARBOSA - SANTANDER", "BARICHARA - SANTANDER", "BARRANCABERMEJA - SANTANDER", "BETULIA - SANTANDER", "BOLIVAR - SANTANDER", "CABRERA - SANTANDER", "CALIFORNIA - SANTANDER", "CAPITANEJO - SANTANDER", "CARCASI - SANTANDER", "CEPITA - SANTANDER", "CERRITO - SANTANDER", "CHARALA - SANTANDER", "CHARTA - SANTANDER", "CHIMA - SANTANDER", "CHIPATA - SANTANDER", "CIMITARRA - SANTANDER", "CONCEPCION - SANTANDER", "CONFINES - SANTANDER", "CONTRATACION - SANTANDER", "COROMORO - SANTANDER", "CURITI - SANTANDER", "EL CARMEN DE CHUCURI - SANTANDER", "EL GUACAMAYO - SANTANDER", "EL PEÑON - SANTANDER", "EL PLAYON - SANTANDER", "ENCINO - SANTANDER", "ENCISO - SANTANDER", "FLORIAN - SANTANDER", "FLORIDABLANCA - SANTANDER", "GALAN - SANTANDER", "GAMBITA - SANTANDER", "GIRON - SANTANDER", "GUACA - SANTANDER", "GUADALUPE - SANTANDER", "GUAPOTA - SANTANDER", "GUAVATA - SANTANDER", "GsEPSA - SANTANDER", "HATO - SANTANDER", "JESUS MARIA - SANTANDER", "JORDAN - SANTANDER", "LA BELLEZA - SANTANDER", "LANDAZURI - SANTANDER", "LA PAZ - SANTANDER", "LEBRIJA - SANTANDER", "LOS SANTOS - SANTANDER", "MACARAVITA - SANTANDER", "MALAGA - SANTANDER", "MATANZA - SANTANDER", "MOGOTES - SANTANDER", "MOLAGAVITA - SANTANDER", "OCAMONTE - SANTANDER", "OIBA - SANTANDER", "ONZAGA - SANTANDER", "PALMAR - SANTANDER", "PALMAS DEL SOCORRO - SANTANDER", "PARAMO - SANTANDER", "PIEDECUESTA - SANTANDER", "PINCHOTE - SANTANDER", "PUENTE NACIONAL - SANTANDER", "PUERTO PARRA - SANTANDER", "PUERTO WILCHES - SANTANDER", "RIONEGRO - SANTANDER", "SABANA DE TORRES - SANTANDER", "SAN ANDRES - SANTANDER", "SAN BENITO - SANTANDER", "SAN GIL - SANTANDER", "SAN JOAQUIN - SANTANDER", "SAN JOSE DE MIRANDA - SANTANDER", "SAN MIGUEL - SANTANDER", "SAN VICENTE DE CHUCURI - SANTANDER", "SANTA BARBARA - SANTANDER", "SANTA HELENA DEL OPON - SANTANDER", "SIMACOTA - SANTANDER", "SOCORRO - SANTANDER", "SUAITA - SANTANDER", "SUCRE - SANTANDER", "SURATA - SANTANDER", "TONA - SANTANDER", "VALLE DE SAN JOSE - SANTANDER", "VELEZ - SANTANDER", "VETAS - SANTANDER", "VILLANUEVA - SANTANDER", "ZAPATOCA - SANTANDER", "SINCELEJO - SUCRE", "BUENAVISTA - SUCRE", "CAIMITO - SUCRE", "COLOSO - SUCRE", "COROZAL - SUCRE", "COVEÑAS - SUCRE", "CHALAN - SUCRE", "EL ROBLE - SUCRE", "GALERAS - SUCRE", "GUARANDA - SUCRE", "LA UNION - SUCRE", "LOS PALMITOS - SUCRE", "MAJAGUAL - SUCRE", "MORROA - SUCRE", "OVEJAS - SUCRE", "PALMITO - SUCRE", "SAMPUES - SUCRE", "SAN BENITO ABAD - SUCRE", "SAN JUAN DE BETULIA - SUCRE", "SAN MARCOS - SUCRE", "SAN ONOFRE - SUCRE", "SAN PEDRO - SUCRE", "SAN LUIS DE SINCE - SUCRE", "SUCRE - SUCRE", "SANTIAGO DE TOLU - SUCRE", "TOLU VIEJO - SUCRE", "IBAGUE - TOLIMA", "ALPUJARRA - TOLIMA", "ALVARADO - TOLIMA", "AMBALEMA - TOLIMA", "ANZOATEGUI - TOLIMA", "ARMERO - TOLIMA", "ATACO - TOLIMA", "CAJAMARCA - TOLIMA", "CARMEN DE APICALA - TOLIMA", "CASABIANCA - TOLIMA", "CHAPARRAL - TOLIMA", "COELLO - TOLIMA", "COYAIMA - TOLIMA", "CUNDAY - TOLIMA", "DOLORES - TOLIMA", "ESPINAL - TOLIMA", "FALAN - TOLIMA", "FLANDES - TOLIMA", "FRESNO - TOLIMA", "GUAMO - TOLIMA", "HERVEO - TOLIMA", "HONDA - TOLIMA", "ICONONZO - TOLIMA", "LERIDA - TOLIMA", "LIBANO - TOLIMA", "MARIQUITA - TOLIMA", "MELGAR - TOLIMA", "MURILLO - TOLIMA", "NATAGAIMA - TOLIMA", "ORTEGA - TOLIMA", "PALOCABILDO - TOLIMA", "PIEDRAS - TOLIMA", "PLANADAS - TOLIMA", "PRADO - TOLIMA", "PURIFICACION - TOLIMA", "RIOBLANCO - TOLIMA", "RONCESVALLES - TOLIMA", "ROVIRA - TOLIMA", "SALDAÑA - TOLIMA", "SAN ANTONIO - TOLIMA", "SAN LUIS - TOLIMA", "SANTA ISABEL - TOLIMA", "SUAREZ - TOLIMA", "VALLE DE SAN JUAN - TOLIMA", "VENADILLO - TOLIMA", "VILLAHERMOSA - TOLIMA", "VILLARRICA - TOLIMA", "CALI - VALLE DEL CAUCA", "ALCALA - VALLE DEL CAUCA", "ANDALUCIA - VALLE DEL CAUCA", "ANSERMANUEVO - VALLE DEL CAUCA", "ARGELIA - VALLE DEL CAUCA", "BOLIVAR - VALLE DEL CAUCA", "BUENAVENTURA - VALLE DEL CAUCA", "GUADALAJARA DE BUGA - VALLE DEL CAUCA", "BUGALAGRANDE - VALLE DEL CAUCA", "CAICEDONIA - VALLE DEL CAUCA", "CALIMA - VALLE DEL CAUCA", "CANDELARIA - VALLE DEL CAUCA", "CARTAGO - VALLE DEL CAUCA", "DAGUA - VALLE DEL CAUCA", "EL AGUILA - VALLE DEL CAUCA", "EL CAIRO - VALLE DEL CAUCA", "EL CERRITO - VALLE DEL CAUCA", "EL DOVIO - VALLE DEL CAUCA", "FLORIDA - VALLE DEL CAUCA", "GINEBRA - VALLE DEL CAUCA", "GUACARI - VALLE DEL CAUCA", "JAMUNDI - VALLE DEL CAUCA", "LA CUMBRE - VALLE DEL CAUCA", "LA UNION - VALLE DEL CAUCA", "LA VICTORIA - VALLE DEL CAUCA", "OBANDO - VALLE DEL CAUCA", "PALMIRA - VALLE DEL CAUCA", "PRADERA - VALLE DEL CAUCA", "RESTREPO - VALLE DEL CAUCA", "RIOFRIO - VALLE DEL CAUCA", "ROLDANILLO - VALLE DEL CAUCA", "SAN PEDRO - VALLE DEL CAUCA", "SEVILLA - VALLE DEL CAUCA", "TORO - VALLE DEL CAUCA", "TRUJILLO - VALLE DEL CAUCA", "TULUA - VALLE DEL CAUCA", "ULLOA - VALLE DEL CAUCA", "VERSALLES - VALLE DEL CAUCA", "VIJES - VALLE DEL CAUCA", "YOTOCO - VALLE DEL CAUCA", "YUMBO - VALLE DEL CAUCA", "ZARZAL - VALLE DEL CAUCA", "ARAUCA - ARAUCA", "ARAUQUITA - ARAUCA", "CRAVO NORTE - ARAUCA", "FORTUL - ARAUCA", "PUERTO RONDON - ARAUCA", "SARAVENA - ARAUCA", "TAME - ARAUCA", "YOPAL - CASANARE", "AGUAZUL - CASANARE", "CHAMEZA - CASANARE", "HATO COROZAL - CASANARE", "LA SALINA - CASANARE", "MANI - CASANARE", "MONTERREY - CASANARE", "NUNCHIA - CASANARE", "OROCUE - CASANARE", "PAZ DE ARIPORO - CASANARE", "PORE - CASANARE", "RECETOR - CASANARE", "SABANALARGA - CASANARE", "SACAMA - CASANARE", "SAN LUIS DE PALENQUE - CASANARE", "TAMARA - CASANARE", "TAURAMENA - CASANARE", "TRINIDAD - CASANARE", "VILLANUEVA - CASANARE", "MOCOA - PUTUMAYO", "COLON - PUTUMAYO", "ORITO - PUTUMAYO", "PUERTO ASIS - PUTUMAYO", "PUERTO CAICEDO - PUTUMAYO", "PUERTO GUZMAN - PUTUMAYO", "LEGUIZAMO - PUTUMAYO", "SIBUNDOY - PUTUMAYO", "SAN FRANCISCO - PUTUMAYO", "SAN MIGUEL - PUTUMAYO", "SANTIAGO - PUTUMAYO", "VALLE DEL GUAMUEZ - PUTUMAYO", "VILLAGARZON - PUTUMAYO", "SAN ANDRES - SAN ANDRES", "PROVIDENCIA - SAN ANDRES", "LETICIA - AMAZONAS", "EL ENCANTO - AMAZONAS", "LA CHORRERA - AMAZONAS", "LA PEDRERA - AMAZONAS", "LA VICTORIA - AMAZONAS", "MIRITI - PARANA - AMAZONAS", "PUERTO ALEGRIA - AMAZONAS", "PUERTO ARICA - AMAZONAS", "PUERTO NARIÑO - AMAZONAS", "PUERTO SANTANDER - AMAZONAS", "TARAPACA - AMAZONAS", "INIRIDA - GUAINIA", "BARRANCO MINAS - GUAINIA", "MAPIRIPANA - GUAINIA", "SAN FELIPE - GUAINIA", "PUERTO COLOMBIA - GUAINIA", "LA GUADALUPE - GUAINIA", "CACAHUAL - GUAINIA", "PANA PANA - GUAINIA", "MORICHAL - GUAINIA", "SAN JOSE DEL GUAVIARE - GUAVIARE", "CALAMAR - GUAVIARE", "EL RETORNO - GUAVIARE", "MIRAFLORES - GUAVIARE", "MITU - VAUPES", "CARURU - VAUPES", "PACOA - VAUPES", "TARAIRA - VAUPES", "PAPUNAUA - VAUPES", "YAVARATE - VAUPES", "PUERTO CARREÑO - VICHADA", "LA PRIMAVERA - VICHADA", "SANTA ROSALIA - VICHADA", "CUMARIBO - VICHADA"})
        Me.ComboBox_categoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox_categoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox_categoria.BackColor = System.Drawing.Color.White
        Me.ComboBox_categoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_categoria.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ComboBox_categoria.FormattingEnabled = True
        Me.ComboBox_categoria.Location = New System.Drawing.Point(30, 182)
        Me.ComboBox_categoria.Name = "ComboBox_categoria"
        Me.ComboBox_categoria.Size = New System.Drawing.Size(281, 28)
        Me.ComboBox_categoria.TabIndex = 767
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(6, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(571, 23)
        Me.Label6.TabIndex = 766
        Me.Label6.Text = "Utilice esta opcion para aplicarle impuestos a varios productos"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(27, 220)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(66, 15)
        Me.Label29.TabIndex = 765
        Me.Label29.Text = "Impuesto"
        '
        'RadioButton_aplicacategoria
        '
        Me.RadioButton_aplicacategoria.AutoSize = True
        Me.RadioButton_aplicacategoria.Font = New System.Drawing.Font("Berlin Sans FB", 11.75!)
        Me.RadioButton_aplicacategoria.ForeColor = System.Drawing.Color.Black
        Me.RadioButton_aplicacategoria.Location = New System.Drawing.Point(30, 127)
        Me.RadioButton_aplicacategoria.Name = "RadioButton_aplicacategoria"
        Me.RadioButton_aplicacategoria.Size = New System.Drawing.Size(394, 22)
        Me.RadioButton_aplicacategoria.TabIndex = 764
        Me.RadioButton_aplicacategoria.Text = "Aplicar Impuesto a Todos los Productos de una categoría"
        Me.RadioButton_aplicacategoria.UseVisualStyleBackColor = True
        '
        'ComboBox_impuestoaplicar
        '
        Me.ComboBox_impuestoaplicar.AutoCompleteCustomSource.AddRange(New String() {"MEDELLIN - ANTIOQUIA", "ABEJORRAL - ANTIOQUIA", "ABRIAQUI - ANTIOQUIA", "ALEJANDRIA - ANTIOQUIA", "AMAGA - ANTIOQUIA", "AMALFI - ANTIOQUIA", "ANDES - ANTIOQUIA", "ANGELOPOLIS - ANTIOQUIA", "ANGOSTURA - ANTIOQUIA", "ANORI - ANTIOQUIA", "SANTAFE DE ANTIOQUIA - ANTIOQUIA", "ANZA - ANTIOQUIA", "APARTADO - ANTIOQUIA", "ARBOLETES - ANTIOQUIA", "ARGELIA - ANTIOQUIA", "ARMENIA - ANTIOQUIA", "BARBOSA - ANTIOQUIA", "BELMIRA - ANTIOQUIA", "BELLO - ANTIOQUIA", "BETANIA - ANTIOQUIA", "BETULIA - ANTIOQUIA", "CIUDAD BOLIVAR - ANTIOQUIA", "BRICEÑO - ANTIOQUIA", "BURITICA - ANTIOQUIA", "CACERES - ANTIOQUIA", "CAICEDO - ANTIOQUIA", "CALDAS - ANTIOQUIA", "CAMPAMENTO - ANTIOQUIA", "CAÑASGORDAS - ANTIOQUIA", "CARACOLI - ANTIOQUIA", "CARAMANTA - ANTIOQUIA", "CAREPA - ANTIOQUIA", "EL CARMEN DE VIBORAL - ANTIOQUIA", "CAROLINA - ANTIOQUIA", "CAUCASIA - ANTIOQUIA", "CHIGORODO - ANTIOQUIA", "CISNEROS - ANTIOQUIA", "COCORNA - ANTIOQUIA", "CONCEPCION - ANTIOQUIA", "CONCORDIA - ANTIOQUIA", "COPACABANA - ANTIOQUIA", "DABEIBA - ANTIOQUIA", "DON MATIAS - ANTIOQUIA", "EBEJICO - ANTIOQUIA", "EL BAGRE - ANTIOQUIA", "ENTRERRIOS - ANTIOQUIA", "ENVIGADO - ANTIOQUIA", "FREDONIA - ANTIOQUIA", "FRONTINO - ANTIOQUIA", "GIRALDO - ANTIOQUIA", "GIRARDOTA - ANTIOQUIA", "GOMEZ PLATA - ANTIOQUIA", "GRANADA - ANTIOQUIA", "GUADALUPE - ANTIOQUIA", "GUARNE - ANTIOQUIA", "GUATAPE - ANTIOQUIA", "HELICONIA - ANTIOQUIA", "HISPANIA - ANTIOQUIA", "ITAGUI - ANTIOQUIA", "ITUANGO - ANTIOQUIA", "JARDIN - ANTIOQUIA", "JERICO - ANTIOQUIA", "LA CEJA - ANTIOQUIA", "LA ESTRELLA - ANTIOQUIA", "LA PINTADA - ANTIOQUIA", "LA UNION - ANTIOQUIA", "LIBORINA - ANTIOQUIA", "MACEO - ANTIOQUIA", "MARINILLA - ANTIOQUIA", "MONTEBELLO - ANTIOQUIA", "MURINDO - ANTIOQUIA", "MUTATA - ANTIOQUIA", "NARIÑO - ANTIOQUIA", "NECOCLI - ANTIOQUIA", "NECHI - ANTIOQUIA", "OLAYA - ANTIOQUIA", "PEÐOL - ANTIOQUIA", "PEQUE - ANTIOQUIA", "PUEBLORRICO - ANTIOQUIA", "PUERTO BERRIO - ANTIOQUIA", "PUERTO NARE - ANTIOQUIA", "PUERTO TRIUNFO - ANTIOQUIA", "REMEDIOS - ANTIOQUIA", "RETIRO - ANTIOQUIA", "RIONEGRO - ANTIOQUIA", "SABANALARGA - ANTIOQUIA", "SABANETA - ANTIOQUIA", "SALGAR - ANTIOQUIA", "SAN ANDRES DE CUERQUIA - ANTIOQUIA", "SAN CARLOS - ANTIOQUIA", "SAN FRANCISCO - ANTIOQUIA", "SAN JERONIMO - ANTIOQUIA", "SAN JOSE DE LA MONTAÑA - ANTIOQUIA", "SAN JUAN DE URABA - ANTIOQUIA", "SAN LUIS - ANTIOQUIA", "SAN PEDRO - ANTIOQUIA", "SAN PEDRO DE URABA - ANTIOQUIA", "SAN RAFAEL - ANTIOQUIA", "SAN ROQUE - ANTIOQUIA", "SAN VICENTE - ANTIOQUIA", "SANTA BARBARA - ANTIOQUIA", "SANTA ROSA DE OSOS - ANTIOQUIA", "SANTO DOMINGO - ANTIOQUIA", "EL SANTUARIO - ANTIOQUIA", "SEGOVIA - ANTIOQUIA", "SONSON - ANTIOQUIA", "SOPETRAN - ANTIOQUIA", "TAMESIS - ANTIOQUIA", "TARAZA - ANTIOQUIA", "TARSO - ANTIOQUIA", "TITIRIBI - ANTIOQUIA", "TOLEDO - ANTIOQUIA", "TURBO - ANTIOQUIA", "URAMITA - ANTIOQUIA", "URRAO - ANTIOQUIA", "VALDIVIA - ANTIOQUIA", "VALPARAISO - ANTIOQUIA", "VEGACHI - ANTIOQUIA", "VENECIA - ANTIOQUIA", "VIGIA DEL FUERTE - ANTIOQUIA", "YALI - ANTIOQUIA", "YARUMAL - ANTIOQUIA", "YOLOMBO - ANTIOQUIA", "YONDO - ANTIOQUIA", "ZARAGOZA - ANTIOQUIA", "BARRANQUILLA - ATLANTICO", "BARANOA - ATLANTICO", "CAMPO DE LA CRUZ - ATLANTICO", "CANDELARIA - ATLANTICO", "GALAPA - ATLANTICO", "JUAN DE ACOSTA - ATLANTICO", "LURUACO - ATLANTICO", "MALAMBO - ATLANTICO", "MANATI - ATLANTICO", "PALMAR DE VARELA - ATLANTICO", "PIOJO - ATLANTICO", "POLONUEVO - ATLANTICO", "PONEDERA - ATLANTICO", "PUERTO COLOMBIA - ATLANTICO", "REPELON - ATLANTICO", "SABANAGRANDE - ATLANTICO", "SABANALARGA - ATLANTICO", "SANTA LUCIA - ATLANTICO", "SANTO TOMAS - ATLANTICO", "SOLEDAD - ATLANTICO", "SUAN - ATLANTICO", "TUBARA - ATLANTICO", "USIACURI - ATLANTICO", "BOGOTA, D.C. - BOGOTA", "CARTAGENA - BOLIVAR", "ACHI - BOLIVAR", "ALTOS DEL ROSARIO - BOLIVAR", "ARENAL - BOLIVAR", "ARJONA - BOLIVAR", "ARROYOHONDO - BOLIVAR", "BARRANCO DE LOBA - BOLIVAR", "CALAMAR - BOLIVAR", "CANTAGALLO - BOLIVAR", "CICUCO - BOLIVAR", "CORDOBA - BOLIVAR", "CLEMENCIA - BOLIVAR", "EL CARMEN DE BOLIVAR - BOLIVAR", "EL GUAMO - BOLIVAR", "EL PEÑON - BOLIVAR", "HATILLO DE LOBA - BOLIVAR", "MAGANGUE - BOLIVAR", "MAHATES - BOLIVAR", "MARGARITA - BOLIVAR", "MARIA LA BAJA - BOLIVAR", "MONTECRISTO - BOLIVAR", "MOMPOS - BOLIVAR", "NOROSI - BOLIVAR", "MORALES - BOLIVAR", "PINILLOS - BOLIVAR", "REGIDOR - BOLIVAR", "RIO VIEJO - BOLIVAR", "SAN CRISTOBAL - BOLIVAR", "SAN ESTANISLAO - BOLIVAR", "SAN FERNANDO - BOLIVAR", "SAN JACINTO - BOLIVAR", "SAN JACINTO DEL CAUCA - BOLIVAR", "SAN JUAN NEPOMUCENO - BOLIVAR", "SAN MARTIN DE LOBA - BOLIVAR", "SAN PABLO - BOLIVAR", "SANTA CATALINA - BOLIVAR", "SANTA ROSA - BOLIVAR", "SANTA ROSA DEL SUR - BOLIVAR", "SIMITI - BOLIVAR", "SOPLAVIENTO - BOLIVAR", "TALAIGUA NUEVO - BOLIVAR", "TIQUISIO - BOLIVAR", "TURBACO - BOLIVAR", "TURBANA - BOLIVAR", "VILLANUEVA - BOLIVAR", "ZAMBRANO - BOLIVAR", "TUNJA - BOYACA", "ALMEIDA - BOYACA", "AQUITANIA - BOYACA", "ARCABUCO - BOYACA", "BELEN - BOYACA", "BERBEO - BOYACA", "BETEITIVA - BOYACA", "BOAVITA - BOYACA", "BOYACA - BOYACA", "BRICEÑO - BOYACA", "BUENAVISTA - BOYACA", "BUSBANZA - BOYACA", "CALDAS - BOYACA", "CAMPOHERMOSO - BOYACA", "CERINZA - BOYACA", "CHINAVITA - BOYACA", "CHIQUINQUIRA - BOYACA", "CHISCAS - BOYACA", "CHITA - BOYACA", "CHITARAQUE - BOYACA", "CHIVATA - BOYACA", "CIENEGA - BOYACA", "COMBITA - BOYACA", "COPER - BOYACA", "CORRALES - BOYACA", "COVARACHIA - BOYACA", "CUBARA - BOYACA", "CUCAITA - BOYACA", "CUITIVA - BOYACA", "CHIQUIZA - BOYACA", "CHIVOR - BOYACA", "DUITAMA - BOYACA", "EL COCUY - BOYACA", "EL ESPINO - BOYACA", "FIRAVITOBA - BOYACA", "FLORESTA - BOYACA", "GACHANTIVA - BOYACA", "GAMEZA - BOYACA", "GARAGOA - BOYACA", "GUACAMAYAS - BOYACA", "GUATEQUE - BOYACA", "GUAYATA - BOYACA", "GsICAN - BOYACA", "IZA - BOYACA", "JENESANO - BOYACA", "JERICO - BOYACA", "LABRANZAGRANDE - BOYACA", "LA CAPILLA - BOYACA", "LA VICTORIA - BOYACA", "LA UVITA - BOYACA", "VILLA DE LEYVA - BOYACA", "MACANAL - BOYACA", "MARIPI - BOYACA", "MIRAFLORES - BOYACA", "MONGUA - BOYACA", "MONGUI - BOYACA", "MONIQUIRA - BOYACA", "MOTAVITA - BOYACA", "MUZO - BOYACA", "NOBSA - BOYACA", "NUEVO COLON - BOYACA", "OICATA - BOYACA", "OTANCHE - BOYACA", "PACHAVITA - BOYACA", "PAEZ - BOYACA", "PAIPA - BOYACA", "PAJARITO - BOYACA", "PANQUEBA - BOYACA", "PAUNA - BOYACA", "PAYA - BOYACA", "PAZ DE RIO - BOYACA", "PESCA - BOYACA", "PISBA - BOYACA", "PUERTO BOYACA - BOYACA", "QUIPAMA - BOYACA", "RAMIRIQUI - BOYACA", "RAQUIRA - BOYACA", "RONDON - BOYACA", "SABOYA - BOYACA", "SACHICA - BOYACA", "SAMACA - BOYACA", "SAN EDUARDO - BOYACA", "SAN JOSE DE PARE - BOYACA", "SAN LUIS DE GACENO - BOYACA", "SAN MATEO - BOYACA", "SAN MIGUEL DE SEMA - BOYACA", "SAN PABLO DE BORBUR - BOYACA", "SANTANA - BOYACA", "SANTA MARIA - BOYACA", "SANTA ROSA DE VITERBO - BOYACA", "SANTA SOFIA - BOYACA", "SATIVANORTE - BOYACA", "SATIVASUR - BOYACA", "SIACHOQUE - BOYACA", "SOATA - BOYACA", "SOCOTA - BOYACA", "SOCHA - BOYACA", "SOGAMOSO - BOYACA", "SOMONDOCO - BOYACA", "SORA - BOYACA", "SOTAQUIRA - BOYACA", "SORACA - BOYACA", "SUSACON - BOYACA", "SUTAMARCHAN - BOYACA", "SUTATENZA - BOYACA", "TASCO - BOYACA", "TENZA - BOYACA", "TIBANA - BOYACA", "TIBASOSA - BOYACA", "TINJACA - BOYACA", "TIPACOQUE - BOYACA", "TOCA - BOYACA", "TOGsI - BOYACA", "TOPAGA - BOYACA", "TOTA - BOYACA", "TUNUNGUA - BOYACA", "TURMEQUE - BOYACA", "TUTA - BOYACA", "TUTAZA - BOYACA", "UMBITA - BOYACA", "VENTAQUEMADA - BOYACA", "VIRACACHA - BOYACA", "ZETAQUIRA - BOYACA", "MANIZALES - CALDAS", "AGUADAS - CALDAS", "ANSERMA - CALDAS", "ARANZAZU - CALDAS", "BELALCAZAR - CALDAS", "CHINCHINA - CALDAS", "FILADELFIA - CALDAS", "LA DORADA - CALDAS", "LA MERCED - CALDAS", "MANZANARES - CALDAS", "MARMATO - CALDAS", "MARQUETALIA - CALDAS", "MARULANDA - CALDAS", "NEIRA - CALDAS", "NORCASIA - CALDAS", "PACORA - CALDAS", "PALESTINA - CALDAS", "PENSILVANIA - CALDAS", "RIOSUCIO - CALDAS", "RISARALDA - CALDAS", "SALAMINA - CALDAS", "SAMANA - CALDAS", "SAN JOSE - CALDAS", "SUPIA - CALDAS", "VICTORIA - CALDAS", "VILLAMARIA - CALDAS", "VITERBO - CALDAS", "FLORENCIA - CAQUETA", "ALBANIA - CAQUETA", "BELEN DE LOS ANDAQUIES - CAQUETA", "CARTAGENA DEL CHAIRA - CAQUETA", "CURILLO - CAQUETA", "EL DONCELLO - CAQUETA", "EL PAUJIL - CAQUETA", "LA MONTAÑITA - CAQUETA", "MILAN - CAQUETA", "MORELIA - CAQUETA", "PUERTO RICO - CAQUETA", "SAN JOSE DEL FRAGUA - CAQUETA", "SAN VICENTE DEL CAGUAN - CAQUETA", "SOLANO - CAQUETA", "SOLITA - CAQUETA", "VALPARAISO - CAQUETA", "POPAYAN - CAUCA", "ALMAGUER - CAUCA", "ARGELIA - CAUCA", "BALBOA - CAUCA", "BOLIVAR - CAUCA", "BUENOS AIRES - CAUCA", "CAJIBIO - CAUCA", "CALDONO - CAUCA", "CALOTO - CAUCA", "CORINTO - CAUCA", "EL TAMBO - CAUCA", "FLORENCIA - CAUCA", "GUACHENE - CAUCA", "GUAPI - CAUCA", "INZA - CAUCA", "JAMBALO - CAUCA", "LA SIERRA - CAUCA", "LA VEGA - CAUCA", "LOPEZ - CAUCA", "MERCADERES - CAUCA", "MIRANDA - CAUCA", "MORALES - CAUCA", "PADILLA - CAUCA", "PAEZ - CAUCA", "PATIA - CAUCA", "PIAMONTE - CAUCA", "PIENDAMO - CAUCA", "PUERTO TEJADA - CAUCA", "PURACE - CAUCA", "ROSAS - CAUCA", "SAN SEBASTIAN - CAUCA", "SANTANDER DE QUILICHAO - CAUCA", "SANTA ROSA - CAUCA", "SILVIA - CAUCA", "SOTARA - CAUCA", "SUAREZ - CAUCA", "SUCRE - CAUCA", "TIMBIO - CAUCA", "TIMBIQUI - CAUCA", "TORIBIO - CAUCA", "TOTORO - CAUCA", "VILLA RICA - CAUCA", "VALLEDUPAR - CESAR", "AGUACHICA - CESAR", "AGUSTIN CODAZZI - CESAR", "ASTREA - CESAR", "BECERRIL - CESAR", "BOSCONIA - CESAR", "CHIMICHAGUA - CESAR", "CHIRIGUANA - CESAR", "CURUMANI - CESAR", "EL COPEY - CESAR", "EL PASO - CESAR", "GAMARRA - CESAR", "GONZALEZ - CESAR", "LA GLORIA - CESAR", "LA JAGUA DE IBIRICO - CESAR", "MANAURE - CESAR", "PAILITAS - CESAR", "PELAYA - CESAR", "PUEBLO BELLO - CESAR", "RIO DE ORO - CESAR", "LA PAZ - CESAR", "SAN ALBERTO - CESAR", "SAN DIEGO - CESAR", "SAN MARTIN - CESAR", "TAMALAMEQUE - CESAR", "MONTERIA - CORDOBA", "AYAPEL - CORDOBA", "BUENAVISTA - CORDOBA", "CANALETE - CORDOBA", "CERETE - CORDOBA", "CHIMA - CORDOBA", "CHINU - CORDOBA", "CIENAGA DE ORO - CORDOBA", "COTORRA - CORDOBA", "LA APARTADA - CORDOBA", "LORICA - CORDOBA", "LOS CORDOBAS - CORDOBA", "MOMIL - CORDOBA", "MONTELIBANO - CORDOBA", "MOÑITOS - CORDOBA", "PLANETA RICA - CORDOBA", "PUEBLO NUEVO - CORDOBA", "PUERTO ESCONDIDO - CORDOBA", "PUERTO LIBERTADOR - CORDOBA", "PURISIMA - CORDOBA", "SAHAGUN - CORDOBA", "SAN ANDRES SOTAVENTO - CORDOBA", "SAN ANTERO - CORDOBA", "SAN BERNARDO DEL VIENTO - CORDOBA", "SAN CARLOS - CORDOBA", "SAN PELAYO - CORDOBA", "TIERRALTA - CORDOBA", "VALENCIA - CORDOBA", "AGUA DE DIOS - CUNDINAMARCA", "ALBAN - CUNDINAMARCA", "ANAPOIMA - CUNDINAMARCA", "ANOLAIMA - CUNDINAMARCA", "ARBELAEZ - CUNDINAMARCA", "BELTRAN - CUNDINAMARCA", "BITUIMA - CUNDINAMARCA", "BOJACA - CUNDINAMARCA", "CABRERA - CUNDINAMARCA", "CACHIPAY - CUNDINAMARCA", "CAJICA - CUNDINAMARCA", "CAPARRAPI - CUNDINAMARCA", "CAQUEZA - CUNDINAMARCA", "CARMEN DE CARUPA - CUNDINAMARCA", "CHAGUANI - CUNDINAMARCA", "CHIA - CUNDINAMARCA", "CHIPAQUE - CUNDINAMARCA", "CHOACHI - CUNDINAMARCA", "CHOCONTA - CUNDINAMARCA", "COGUA - CUNDINAMARCA", "COTA - CUNDINAMARCA", "CUCUNUBA - CUNDINAMARCA", "EL COLEGIO - CUNDINAMARCA", "EL PEÑON - CUNDINAMARCA", "EL ROSAL - CUNDINAMARCA", "FACATATIVA - CUNDINAMARCA", "FOMEQUE - CUNDINAMARCA", "FOSCA - CUNDINAMARCA", "FUNZA - CUNDINAMARCA", "FUQUENE - CUNDINAMARCA", "FUSAGASUGA - CUNDINAMARCA", "GACHALA - CUNDINAMARCA", "GACHANCIPA - CUNDINAMARCA", "GACHETA - CUNDINAMARCA", "GAMA - CUNDINAMARCA", "GIRARDOT - CUNDINAMARCA", "GRANADA - CUNDINAMARCA", "GUACHETA - CUNDINAMARCA", "GUADUAS - CUNDINAMARCA", "GUASCA - CUNDINAMARCA", "GUATAQUI - CUNDINAMARCA", "GUATAVITA - CUNDINAMARCA", "GUAYABAL DE SIQUIMA - CUNDINAMARCA", "GUAYABETAL - CUNDINAMARCA", "GUTIERREZ - CUNDINAMARCA", "JERUSALEN - CUNDINAMARCA", "JUNIN - CUNDINAMARCA", "LA CALERA - CUNDINAMARCA", "LA MESA - CUNDINAMARCA", "LA PALMA - CUNDINAMARCA", "LA PEÑA - CUNDINAMARCA", "LA VEGA - CUNDINAMARCA", "LENGUAZAQUE - CUNDINAMARCA", "MACHETA - CUNDINAMARCA", "MADRID - CUNDINAMARCA", "MANTA - CUNDINAMARCA", "MEDINA - CUNDINAMARCA", "MOSQUERA - CUNDINAMARCA", "NARIÑO - CUNDINAMARCA", "NEMOCON - CUNDINAMARCA", "NILO - CUNDINAMARCA", "NIMAIMA - CUNDINAMARCA", "NOCAIMA - CUNDINAMARCA", "VENECIA - CUNDINAMARCA", "PACHO - CUNDINAMARCA", "PAIME - CUNDINAMARCA", "PANDI - CUNDINAMARCA", "PARATEBUENO - CUNDINAMARCA", "PASCA - CUNDINAMARCA", "PUERTO SALGAR - CUNDINAMARCA", "PULI - CUNDINAMARCA", "QUEBRADANEGRA - CUNDINAMARCA", "QUETAME - CUNDINAMARCA", "QUIPILE - CUNDINAMARCA", "APULO - CUNDINAMARCA", "RICAURTE - CUNDINAMARCA", "SAN ANTONIO DEL TEQUENDAMA - CUNDINAMARCA", "SAN BERNARDO - CUNDINAMARCA", "SAN CAYETANO - CUNDINAMARCA", "SAN FRANCISCO - CUNDINAMARCA", "SAN JUAN DE RIO SECO - CUNDINAMARCA", "SASAIMA - CUNDINAMARCA", "SESQUILE - CUNDINAMARCA", "SIBATE - CUNDINAMARCA", "SILVANIA - CUNDINAMARCA", "SIMIJACA - CUNDINAMARCA", "SOACHA - CUNDINAMARCA", "SOPO - CUNDINAMARCA", "SUBACHOQUE - CUNDINAMARCA", "SUESCA - CUNDINAMARCA", "SUPATA - CUNDINAMARCA", "SUSA - CUNDINAMARCA", "SUTATAUSA - CUNDINAMARCA", "TABIO - CUNDINAMARCA", "TAUSA - CUNDINAMARCA", "TENA - CUNDINAMARCA", "TENJO - CUNDINAMARCA", "TIBACUY - CUNDINAMARCA", "TIBIRITA - CUNDINAMARCA", "TOCAIMA - CUNDINAMARCA", "TOCANCIPA - CUNDINAMARCA", "TOPAIPI - CUNDINAMARCA", "UBALA - CUNDINAMARCA", "UBAQUE - CUNDINAMARCA", "VILLA DE SAN DIEGO DE UBATE - CUNDINAMARCA", "UNE - CUNDINAMARCA", "UTICA - CUNDINAMARCA", "VERGARA - CUNDINAMARCA", "VIANI - CUNDINAMARCA", "VILLAGOMEZ - CUNDINAMARCA", "VILLAPINZON - CUNDINAMARCA", "VILLETA - CUNDINAMARCA", "VIOTA - CUNDINAMARCA", "YACOPI - CUNDINAMARCA", "ZIPACON - CUNDINAMARCA", "ZIPAQUIRA - CUNDINAMARCA", "QUIBDO - CHOCO", "ACANDI - CHOCO", "ALTO BAUDO - CHOCO", "ATRATO - CHOCO", "BAGADO - CHOCO", "BAHIA SOLANO - CHOCO", "BAJO BAUDO - CHOCO", "BOJAYA - CHOCO", "EL CANTON DEL SAN PABLO - CHOCO", "CARMEN DEL DARIEN - CHOCO", "CERTEGUI - CHOCO", "CONDOTO - CHOCO", "EL CARMEN DE ATRATO - CHOCO", "EL LITORAL DEL SAN JUAN - CHOCO", "ISTMINA - CHOCO", "JURADO - CHOCO", "LLORO - CHOCO", "MEDIO ATRATO - CHOCO", "MEDIO BAUDO - CHOCO", "MEDIO SAN JUAN - CHOCO", "NOVITA - CHOCO", "NUQUI - CHOCO", "RIO IRO - CHOCO", "RIO QUITO - CHOCO", "RIOSUCIO - CHOCO", "SAN JOSE DEL PALMAR - CHOCO", "SIPI - CHOCO", "TADO - CHOCO", "UNGUIA - CHOCO", "UNION PANAMERICANA - CHOCO", "NEIVA - HUILA", "ACEVEDO - HUILA", "AGRADO - HUILA", "AIPE - HUILA", "ALGECIRAS - HUILA", "ALTAMIRA - HUILA", "BARAYA - HUILA", "CAMPOALEGRE - HUILA", "COLOMBIA - HUILA", "ELIAS - HUILA", "GARZON - HUILA", "GIGANTE - HUILA", "GUADALUPE - HUILA", "HOBO - HUILA", "IQUIRA - HUILA", "ISNOS - HUILA", "LA ARGENTINA - HUILA", "LA PLATA - HUILA", "NATAGA - HUILA", "OPORAPA - HUILA", "PAICOL - HUILA", "PALERMO - HUILA", "PALESTINA - HUILA", "PITAL - HUILA", "PITALITO - HUILA", "RIVERA - HUILA", "SALADOBLANCO - HUILA", "SAN AGUSTIN - HUILA", "SANTA MARIA - HUILA", "SUAZA - HUILA", "TARQUI - HUILA", "TESALIA - HUILA", "TELLO - HUILA", "TERUEL - HUILA", "TIMANA - HUILA", "VILLAVIEJA - HUILA", "YAGUARA - HUILA", "RIOHACHA - LA GUAJIRA", "ALBANIA - LA GUAJIRA", "BARRANCAS - LA GUAJIRA", "DIBULLA - LA GUAJIRA", "DISTRACCION - LA GUAJIRA", "EL MOLINO - LA GUAJIRA", "FONSECA - LA GUAJIRA", "HATONUEVO - LA GUAJIRA", "LA JAGUA DEL PILAR - LA GUAJIRA", "MAICAO - LA GUAJIRA", "MANAURE - LA GUAJIRA", "SAN JUAN DEL CESAR - LA GUAJIRA", "URIBIA - LA GUAJIRA", "URUMITA - LA GUAJIRA", "VILLANUEVA - LA GUAJIRA", "SANTA MARTA - MAGDALENA", "ALGARROBO - MAGDALENA", "ARACATACA - MAGDALENA", "ARIGUANI - MAGDALENA", "CERRO SAN ANTONIO - MAGDALENA", "CHIBOLO - MAGDALENA", "CIENAGA - MAGDALENA", "CONCORDIA - MAGDALENA", "EL BANCO - MAGDALENA", "EL PIÑON - MAGDALENA", "EL RETEN - MAGDALENA", "FUNDACION - MAGDALENA", "GUAMAL - MAGDALENA", "NUEVA GRANADA - MAGDALENA", "PEDRAZA - MAGDALENA", "PIJIÑO DEL CARMEN - MAGDALENA", "PIVIJAY - MAGDALENA", "PLATO - MAGDALENA", "PUEBLOVIEJO - MAGDALENA", "REMOLINO - MAGDALENA", "SABANAS DE SAN ANGEL - MAGDALENA", "SALAMINA - MAGDALENA", "SAN SEBASTIAN DE BUENAVISTA - MAGDALENA", "SAN ZENON - MAGDALENA", "SANTA ANA - MAGDALENA", "SANTA BARBARA DE PINTO - MAGDALENA", "SITIONUEVO - MAGDALENA", "TENERIFE - MAGDALENA", "ZAPAYAN - MAGDALENA", "ZONA BANANERA - MAGDALENA", "VILLAVICENCIO - META", "ACACIAS - META", "BARRANCA DE UPIA - META", "CABUYARO - META", "CASTILLA LA NUEVA - META", "CUBARRAL - META", "CUMARAL - META", "EL CALVARIO - META", "EL CASTILLO - META", "EL DORADO - META", "FUENTE DE ORO - META", "GRANADA - META", "GUAMAL - META", "MAPIRIPAN - META", "MESETAS - META", "LA MACARENA - META", "URIBE - META", "LEJANIAS - META", "PUERTO CONCORDIA - META", "PUERTO GAITAN - META", "PUERTO LOPEZ - META", "PUERTO LLERAS - META", "PUERTO RICO - META", "RESTREPO - META", "SAN CARLOS DE GUAROA - META", "SAN JUAN DE ARAMA - META", "SAN JUANITO - META", "SAN MARTIN - META", "VISTAHERMOSA - META", "PASTO - NARIÑO", "ALBAN - NARIÑO", "ALDANA - NARIÑO", "ANCUYA - NARIÑO", "ARBOLEDA - NARIÑO", "BARBACOAS - NARIÑO", "BELEN - NARIÑO", "BUESACO - NARIÑO", "COLON - NARIÑO", "CONSACA - NARIÑO", "CONTADERO - NARIÑO", "CORDOBA - NARIÑO", "CUASPUD - NARIÑO", "CUMBAL - NARIÑO", "CUMBITARA - NARIÑO", "CHACHAGsI - NARIÑO", "EL CHARCO - NARIÑO", "EL PEÑOL - NARIÑO", "EL ROSARIO - NARIÑO", "EL TABLON DE GOMEZ - NARIÑO", "EL TAMBO - NARIÑO", "FUNES - NARIÑO", "GUACHUCAL - NARIÑO", "GUAITARILLA - NARIÑO", "GUALMATAN - NARIÑO", "ILES - NARIÑO", "IMUES - NARIÑO", "IPIALES - NARIÑO", "LA CRUZ - NARIÑO", "LA FLORIDA - NARIÑO", "LA LLANADA - NARIÑO", "LA TOLA - NARIÑO", "LA UNION - NARIÑO", "LEIVA - NARIÑO", "LINARES - NARIÑO", "LOS ANDES - NARIÑO", "MAGsI - NARIÑO", "MALLAMA - NARIÑO", "MOSQUERA - NARIÑO", "NARIÑO - NARIÑO", "OLAYA HERRERA - NARIÑO", "OSPINA - NARIÑO", "FRANCISCO PIZARRO - NARIÑO", "POLICARPA - NARIÑO", "POTOSI - NARIÑO", "PROVIDENCIA - NARIÑO", "PUERRES - NARIÑO", "PUPIALES - NARIÑO", "RICAURTE - NARIÑO", "ROBERTO PAYAN - NARIÑO", "SAMANIEGO - NARIÑO", "SANDONA - NARIÑO", "SAN BERNARDO - NARIÑO", "SAN LORENZO - NARIÑO", "SAN PABLO - NARIÑO", "SAN PEDRO DE CARTAGO - NARIÑO", "SANTA BARBARA - NARIÑO", "SANTACRUZ - NARIÑO", "SAPUYES - NARIÑO", "TAMINANGO - NARIÑO", "TANGUA - NARIÑO", "SAN ANDRES DE TUMACO - NARIÑO", "TUQUERRES - NARIÑO", "YACUANQUER - NARIÑO", "CUCUTA - N. DE SANTANDER", "ABREGO - N. DE SANTANDER", "ARBOLEDAS - N. DE SANTANDER", "BOCHALEMA - N. DE SANTANDER", "BUCARASICA - N. DE SANTANDER", "CACOTA - N. DE SANTANDER", "CACHIRA - N. DE SANTANDER", "CHINACOTA - N. DE SANTANDER", "CHITAGA - N. DE SANTANDER", "CONVENCION - N. DE SANTANDER", "CUCUTILLA - N. DE SANTANDER", "DURANIA - N. DE SANTANDER", "EL CARMEN - N. DE SANTANDER", "EL TARRA - N. DE SANTANDER", "EL ZULIA - N. DE SANTANDER", "GRAMALOTE - N. DE SANTANDER", "HACARI - N. DE SANTANDER", "HERRAN - N. DE SANTANDER", "LABATECA - N. DE SANTANDER", "LA ESPERANZA - N. DE SANTANDER", "LA PLAYA - N. DE SANTANDER", "LOS PATIOS - N. DE SANTANDER", "LOURDES - N. DE SANTANDER", "MUTISCUA - N. DE SANTANDER", "OCAÑA - N. DE SANTANDER", "PAMPLONA - N. DE SANTANDER", "PAMPLONITA - N. DE SANTANDER", "PUERTO SANTANDER - N. DE SANTANDER", "RAGONVALIA - N. DE SANTANDER", "SALAZAR - N. DE SANTANDER", "SAN CALIXTO - N. DE SANTANDER", "SAN CAYETANO - N. DE SANTANDER", "SANTIAGO - N. DE SANTANDER", "SARDINATA - N. DE SANTANDER", "SILOS - N. DE SANTANDER", "TEORAMA - N. DE SANTANDER", "TIBU - N. DE SANTANDER", "TOLEDO - N. DE SANTANDER", "VILLA CARO - N. DE SANTANDER", "VILLA DEL ROSARIO - N. DE SANTANDER", "ARMENIA - QUINDIO", "BUENAVISTA - QUINDIO", "CALARCA - QUINDIO", "CIRCASIA - QUINDIO", "CORDOBA - QUINDIO", "FILANDIA - QUINDIO", "GENOVA - QUINDIO", "LA TEBAIDA - QUINDIO", "MONTENEGRO - QUINDIO", "PIJAO - QUINDIO", "QUIMBAYA - QUINDIO", "SALENTO - QUINDIO", "PEREIRA - RISARALDA", "APIA - RISARALDA", "BALBOA - RISARALDA", "BELEN DE UMBRIA - RISARALDA", "DOSQUEBRADAS - RISARALDA", "GUATICA - RISARALDA", "LA CELIA - RISARALDA", "LA VIRGINIA - RISARALDA", "MARSELLA - RISARALDA", "MISTRATO - RISARALDA", "PUEBLO RICO - RISARALDA", "QUINCHIA - RISARALDA", "SANTA ROSA DE CABAL - RISARALDA", "SANTUARIO - RISARALDA", "BUCARAMANGA - SANTANDER", "AGUADA - SANTANDER", "ALBANIA - SANTANDER", "ARATOCA - SANTANDER", "BARBOSA - SANTANDER", "BARICHARA - SANTANDER", "BARRANCABERMEJA - SANTANDER", "BETULIA - SANTANDER", "BOLIVAR - SANTANDER", "CABRERA - SANTANDER", "CALIFORNIA - SANTANDER", "CAPITANEJO - SANTANDER", "CARCASI - SANTANDER", "CEPITA - SANTANDER", "CERRITO - SANTANDER", "CHARALA - SANTANDER", "CHARTA - SANTANDER", "CHIMA - SANTANDER", "CHIPATA - SANTANDER", "CIMITARRA - SANTANDER", "CONCEPCION - SANTANDER", "CONFINES - SANTANDER", "CONTRATACION - SANTANDER", "COROMORO - SANTANDER", "CURITI - SANTANDER", "EL CARMEN DE CHUCURI - SANTANDER", "EL GUACAMAYO - SANTANDER", "EL PEÑON - SANTANDER", "EL PLAYON - SANTANDER", "ENCINO - SANTANDER", "ENCISO - SANTANDER", "FLORIAN - SANTANDER", "FLORIDABLANCA - SANTANDER", "GALAN - SANTANDER", "GAMBITA - SANTANDER", "GIRON - SANTANDER", "GUACA - SANTANDER", "GUADALUPE - SANTANDER", "GUAPOTA - SANTANDER", "GUAVATA - SANTANDER", "GsEPSA - SANTANDER", "HATO - SANTANDER", "JESUS MARIA - SANTANDER", "JORDAN - SANTANDER", "LA BELLEZA - SANTANDER", "LANDAZURI - SANTANDER", "LA PAZ - SANTANDER", "LEBRIJA - SANTANDER", "LOS SANTOS - SANTANDER", "MACARAVITA - SANTANDER", "MALAGA - SANTANDER", "MATANZA - SANTANDER", "MOGOTES - SANTANDER", "MOLAGAVITA - SANTANDER", "OCAMONTE - SANTANDER", "OIBA - SANTANDER", "ONZAGA - SANTANDER", "PALMAR - SANTANDER", "PALMAS DEL SOCORRO - SANTANDER", "PARAMO - SANTANDER", "PIEDECUESTA - SANTANDER", "PINCHOTE - SANTANDER", "PUENTE NACIONAL - SANTANDER", "PUERTO PARRA - SANTANDER", "PUERTO WILCHES - SANTANDER", "RIONEGRO - SANTANDER", "SABANA DE TORRES - SANTANDER", "SAN ANDRES - SANTANDER", "SAN BENITO - SANTANDER", "SAN GIL - SANTANDER", "SAN JOAQUIN - SANTANDER", "SAN JOSE DE MIRANDA - SANTANDER", "SAN MIGUEL - SANTANDER", "SAN VICENTE DE CHUCURI - SANTANDER", "SANTA BARBARA - SANTANDER", "SANTA HELENA DEL OPON - SANTANDER", "SIMACOTA - SANTANDER", "SOCORRO - SANTANDER", "SUAITA - SANTANDER", "SUCRE - SANTANDER", "SURATA - SANTANDER", "TONA - SANTANDER", "VALLE DE SAN JOSE - SANTANDER", "VELEZ - SANTANDER", "VETAS - SANTANDER", "VILLANUEVA - SANTANDER", "ZAPATOCA - SANTANDER", "SINCELEJO - SUCRE", "BUENAVISTA - SUCRE", "CAIMITO - SUCRE", "COLOSO - SUCRE", "COROZAL - SUCRE", "COVEÑAS - SUCRE", "CHALAN - SUCRE", "EL ROBLE - SUCRE", "GALERAS - SUCRE", "GUARANDA - SUCRE", "LA UNION - SUCRE", "LOS PALMITOS - SUCRE", "MAJAGUAL - SUCRE", "MORROA - SUCRE", "OVEJAS - SUCRE", "PALMITO - SUCRE", "SAMPUES - SUCRE", "SAN BENITO ABAD - SUCRE", "SAN JUAN DE BETULIA - SUCRE", "SAN MARCOS - SUCRE", "SAN ONOFRE - SUCRE", "SAN PEDRO - SUCRE", "SAN LUIS DE SINCE - SUCRE", "SUCRE - SUCRE", "SANTIAGO DE TOLU - SUCRE", "TOLU VIEJO - SUCRE", "IBAGUE - TOLIMA", "ALPUJARRA - TOLIMA", "ALVARADO - TOLIMA", "AMBALEMA - TOLIMA", "ANZOATEGUI - TOLIMA", "ARMERO - TOLIMA", "ATACO - TOLIMA", "CAJAMARCA - TOLIMA", "CARMEN DE APICALA - TOLIMA", "CASABIANCA - TOLIMA", "CHAPARRAL - TOLIMA", "COELLO - TOLIMA", "COYAIMA - TOLIMA", "CUNDAY - TOLIMA", "DOLORES - TOLIMA", "ESPINAL - TOLIMA", "FALAN - TOLIMA", "FLANDES - TOLIMA", "FRESNO - TOLIMA", "GUAMO - TOLIMA", "HERVEO - TOLIMA", "HONDA - TOLIMA", "ICONONZO - TOLIMA", "LERIDA - TOLIMA", "LIBANO - TOLIMA", "MARIQUITA - TOLIMA", "MELGAR - TOLIMA", "MURILLO - TOLIMA", "NATAGAIMA - TOLIMA", "ORTEGA - TOLIMA", "PALOCABILDO - TOLIMA", "PIEDRAS - TOLIMA", "PLANADAS - TOLIMA", "PRADO - TOLIMA", "PURIFICACION - TOLIMA", "RIOBLANCO - TOLIMA", "RONCESVALLES - TOLIMA", "ROVIRA - TOLIMA", "SALDAÑA - TOLIMA", "SAN ANTONIO - TOLIMA", "SAN LUIS - TOLIMA", "SANTA ISABEL - TOLIMA", "SUAREZ - TOLIMA", "VALLE DE SAN JUAN - TOLIMA", "VENADILLO - TOLIMA", "VILLAHERMOSA - TOLIMA", "VILLARRICA - TOLIMA", "CALI - VALLE DEL CAUCA", "ALCALA - VALLE DEL CAUCA", "ANDALUCIA - VALLE DEL CAUCA", "ANSERMANUEVO - VALLE DEL CAUCA", "ARGELIA - VALLE DEL CAUCA", "BOLIVAR - VALLE DEL CAUCA", "BUENAVENTURA - VALLE DEL CAUCA", "GUADALAJARA DE BUGA - VALLE DEL CAUCA", "BUGALAGRANDE - VALLE DEL CAUCA", "CAICEDONIA - VALLE DEL CAUCA", "CALIMA - VALLE DEL CAUCA", "CANDELARIA - VALLE DEL CAUCA", "CARTAGO - VALLE DEL CAUCA", "DAGUA - VALLE DEL CAUCA", "EL AGUILA - VALLE DEL CAUCA", "EL CAIRO - VALLE DEL CAUCA", "EL CERRITO - VALLE DEL CAUCA", "EL DOVIO - VALLE DEL CAUCA", "FLORIDA - VALLE DEL CAUCA", "GINEBRA - VALLE DEL CAUCA", "GUACARI - VALLE DEL CAUCA", "JAMUNDI - VALLE DEL CAUCA", "LA CUMBRE - VALLE DEL CAUCA", "LA UNION - VALLE DEL CAUCA", "LA VICTORIA - VALLE DEL CAUCA", "OBANDO - VALLE DEL CAUCA", "PALMIRA - VALLE DEL CAUCA", "PRADERA - VALLE DEL CAUCA", "RESTREPO - VALLE DEL CAUCA", "RIOFRIO - VALLE DEL CAUCA", "ROLDANILLO - VALLE DEL CAUCA", "SAN PEDRO - VALLE DEL CAUCA", "SEVILLA - VALLE DEL CAUCA", "TORO - VALLE DEL CAUCA", "TRUJILLO - VALLE DEL CAUCA", "TULUA - VALLE DEL CAUCA", "ULLOA - VALLE DEL CAUCA", "VERSALLES - VALLE DEL CAUCA", "VIJES - VALLE DEL CAUCA", "YOTOCO - VALLE DEL CAUCA", "YUMBO - VALLE DEL CAUCA", "ZARZAL - VALLE DEL CAUCA", "ARAUCA - ARAUCA", "ARAUQUITA - ARAUCA", "CRAVO NORTE - ARAUCA", "FORTUL - ARAUCA", "PUERTO RONDON - ARAUCA", "SARAVENA - ARAUCA", "TAME - ARAUCA", "YOPAL - CASANARE", "AGUAZUL - CASANARE", "CHAMEZA - CASANARE", "HATO COROZAL - CASANARE", "LA SALINA - CASANARE", "MANI - CASANARE", "MONTERREY - CASANARE", "NUNCHIA - CASANARE", "OROCUE - CASANARE", "PAZ DE ARIPORO - CASANARE", "PORE - CASANARE", "RECETOR - CASANARE", "SABANALARGA - CASANARE", "SACAMA - CASANARE", "SAN LUIS DE PALENQUE - CASANARE", "TAMARA - CASANARE", "TAURAMENA - CASANARE", "TRINIDAD - CASANARE", "VILLANUEVA - CASANARE", "MOCOA - PUTUMAYO", "COLON - PUTUMAYO", "ORITO - PUTUMAYO", "PUERTO ASIS - PUTUMAYO", "PUERTO CAICEDO - PUTUMAYO", "PUERTO GUZMAN - PUTUMAYO", "LEGUIZAMO - PUTUMAYO", "SIBUNDOY - PUTUMAYO", "SAN FRANCISCO - PUTUMAYO", "SAN MIGUEL - PUTUMAYO", "SANTIAGO - PUTUMAYO", "VALLE DEL GUAMUEZ - PUTUMAYO", "VILLAGARZON - PUTUMAYO", "SAN ANDRES - SAN ANDRES", "PROVIDENCIA - SAN ANDRES", "LETICIA - AMAZONAS", "EL ENCANTO - AMAZONAS", "LA CHORRERA - AMAZONAS", "LA PEDRERA - AMAZONAS", "LA VICTORIA - AMAZONAS", "MIRITI - PARANA - AMAZONAS", "PUERTO ALEGRIA - AMAZONAS", "PUERTO ARICA - AMAZONAS", "PUERTO NARIÑO - AMAZONAS", "PUERTO SANTANDER - AMAZONAS", "TARAPACA - AMAZONAS", "INIRIDA - GUAINIA", "BARRANCO MINAS - GUAINIA", "MAPIRIPANA - GUAINIA", "SAN FELIPE - GUAINIA", "PUERTO COLOMBIA - GUAINIA", "LA GUADALUPE - GUAINIA", "CACAHUAL - GUAINIA", "PANA PANA - GUAINIA", "MORICHAL - GUAINIA", "SAN JOSE DEL GUAVIARE - GUAVIARE", "CALAMAR - GUAVIARE", "EL RETORNO - GUAVIARE", "MIRAFLORES - GUAVIARE", "MITU - VAUPES", "CARURU - VAUPES", "PACOA - VAUPES", "TARAIRA - VAUPES", "PAPUNAUA - VAUPES", "YAVARATE - VAUPES", "PUERTO CARREÑO - VICHADA", "LA PRIMAVERA - VICHADA", "SANTA ROSALIA - VICHADA", "CUMARIBO - VICHADA"})
        Me.ComboBox_impuestoaplicar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox_impuestoaplicar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox_impuestoaplicar.BackColor = System.Drawing.Color.White
        Me.ComboBox_impuestoaplicar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_impuestoaplicar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_impuestoaplicar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ComboBox_impuestoaplicar.FormattingEnabled = True
        Me.ComboBox_impuestoaplicar.Location = New System.Drawing.Point(30, 240)
        Me.ComboBox_impuestoaplicar.Name = "ComboBox_impuestoaplicar"
        Me.ComboBox_impuestoaplicar.Size = New System.Drawing.Size(281, 28)
        Me.ComboBox_impuestoaplicar.TabIndex = 763
        '
        'RadioButton_aplicatodos
        '
        Me.RadioButton_aplicatodos.AutoSize = True
        Me.RadioButton_aplicatodos.Checked = True
        Me.RadioButton_aplicatodos.Font = New System.Drawing.Font("Berlin Sans FB", 11.75!)
        Me.RadioButton_aplicatodos.ForeColor = System.Drawing.Color.Black
        Me.RadioButton_aplicatodos.Location = New System.Drawing.Point(30, 98)
        Me.RadioButton_aplicatodos.Name = "RadioButton_aplicatodos"
        Me.RadioButton_aplicatodos.Size = New System.Drawing.Size(278, 22)
        Me.RadioButton_aplicatodos.TabIndex = 762
        Me.RadioButton_aplicatodos.TabStop = True
        Me.RadioButton_aplicatodos.Text = "Aplicar Impuesto a Todos los Productos"
        Me.RadioButton_aplicatodos.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.botonamarillo
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = Global.MiClickDerecho.My.Resources.Resources.ok_transico
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.Location = New System.Drawing.Point(471, 184)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(146, 57)
        Me.Button4.TabIndex = 296
        Me.Button4.Text = "Aplicar Impuesto"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Form_impuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 479)
        Me.Controls.Add(Me.Panel_titlebar)
        Me.Controls.Add(Me.Panel_imp_datos)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.datagrid_impuestos)
        Me.Controls.Add(Me.Label_doc_label)
        Me.Controls.Add(Me.Panel_opciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_impuesto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.datagrid_impuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel_imp_datos.ResumeLayout(False)
        Me.Panel_imp_datos.PerformLayout()
        Me.Panel_titlebar.ResumeLayout(False)
        Me.Panel_titlebar.PerformLayout()
        Me.Panel_opciones.ResumeLayout(False)
        Me.Panel_opciones.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label_doc_label As Label
    Friend WithEvents datagrid_impuestos As MetroFramework.Controls.MetroGrid
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents button_crear As Button
    Friend WithEvents Button_opciones As Button
    Friend WithEvents Panel_imp_datos As Panel
    Friend WithEvents Textbox_nombre As ns1.BunifuMaterialTextbox
    Friend WithEvents Button_eliminar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_cancelar As Button
    Friend WithEvents Btn_guardar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents RadioButton_porcentaje As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents RadioButton_valor As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Button_sel_cuenta_imp_DB As Button
    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents BunifuElipse2 As ns1.BunifuElipse
    Friend WithEvents BunifuElipse3 As ns1.BunifuElipse
    Friend WithEvents Button_sel_cuenta_imp_CR As Button
    Friend WithEvents BunifuElipse4 As ns1.BunifuElipse
    Friend WithEvents Panel_titlebar As Panel
    Friend WithEvents Button_cerrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Panel_opciones As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox_categoria As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents RadioButton_aplicacategoria As RadioButton
    Friend WithEvents ComboBox_impuestoaplicar As ComboBox
    Friend WithEvents RadioButton_aplicatodos As RadioButton
    Friend WithEvents Button4 As Button
    Friend WithEvents combobox_cta2 As ns1.BunifuMaterialTextbox
    Friend WithEvents combobox_cta1 As ns1.BunifuMaterialTextbox
    Friend WithEvents TextBox_porcentajevr As ns1.BunifuMaterialTextbox
    Friend WithEvents Label8 As Label
    Friend WithEvents RadioButton_retencion As RadioButton
End Class
