<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_producc_opciones
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_producc_opciones))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.Panel_dock = New System.Windows.Forms.Panel()
        Me.MetroGrid_pdf = New MetroFramework.Controls.MetroGrid()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Btn_nuevo = New System.Windows.Forms.Button()
        Me.Btn_Ver_editar = New System.Windows.Forms.Button()
        Me.Button_eliminar = New System.Windows.Forms.Button()
        Me.Panel_titlebar = New System.Windows.Forms.Panel()
        Me.Button_cerrar = New System.Windows.Forms.Button()
        Me.Button_productos = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.datagrid_recetas = New MetroFramework.Controls.MetroGrid()
        Me.Button_guardar_receta = New System.Windows.Forms.Button()
        Me.Button_Regresar_receta = New System.Windows.Forms.Button()
        Me.TabControl_detalle = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.Panel_detalles = New System.Windows.Forms.Panel()
        Me.RadioButton_PROCESADOS = New System.Windows.Forms.RadioButton()
        Me.RadioButton_INSUMOS = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button_exportar = New System.Windows.Forms.Button()
        Me.NumericUpDown_cant = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button_agregar_prod = New System.Windows.Forms.Button()
        Me.button_Quitar_Prod = New System.Windows.Forms.Button()
        Me.DataGrid_materia_prima = New MetroFramework.Controls.MetroGrid()
        Me.ComboBox_materiaprima = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox_prods_procesados = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_buscar_receta = New System.Windows.Forms.TextBox()
        Me.Button_buscar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button_ELIMINAR2 = New System.Windows.Forms.Button()
        Me.NumericUpDown_desechos = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_merma = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BunifuElipse2 = New ns1.BunifuElipse(Me.components)
        Me.BunifuElipse3 = New ns1.BunifuElipse(Me.components)
        Me.BunifuElipse4 = New ns1.BunifuElipse(Me.components)
        Me.Panel_dock.SuspendLayout()
        CType(Me.MetroGrid_pdf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_titlebar.SuspendLayout()
        CType(Me.datagrid_recetas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl_detalle.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.Panel_detalles.SuspendLayout()
        CType(Me.NumericUpDown_cant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid_materia_prima, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.NumericUpDown_desechos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_merma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel_dock
        '
        Me.Panel_dock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_dock.BackColor = System.Drawing.Color.Transparent
        Me.Panel_dock.Controls.Add(Me.MetroGrid_pdf)
        Me.Panel_dock.Controls.Add(Me.Button1)
        Me.Panel_dock.Controls.Add(Me.Btn_nuevo)
        Me.Panel_dock.Controls.Add(Me.Btn_Ver_editar)
        Me.Panel_dock.Controls.Add(Me.Button_eliminar)
        Me.Panel_dock.Location = New System.Drawing.Point(442, 9)
        Me.Panel_dock.Name = "Panel_dock"
        Me.Panel_dock.Size = New System.Drawing.Size(336, 48)
        Me.Panel_dock.TabIndex = 566
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
        Me.MetroGrid_pdf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MetroGrid_pdf.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.MetroGrid_pdf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid_pdf.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.MetroGrid_pdf.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid_pdf.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MetroGrid_pdf.ColumnHeadersHeight = 30
        Me.MetroGrid_pdf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid_pdf.DefaultCellStyle = DataGridViewCellStyle2
        Me.MetroGrid_pdf.EnableHeadersVisualStyles = False
        Me.MetroGrid_pdf.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid_pdf.GridColor = System.Drawing.Color.SteelBlue
        Me.MetroGrid_pdf.Location = New System.Drawing.Point(305, 5)
        Me.MetroGrid_pdf.MultiSelect = False
        Me.MetroGrid_pdf.Name = "MetroGrid_pdf"
        Me.MetroGrid_pdf.ReadOnly = True
        Me.MetroGrid_pdf.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid_pdf.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.MetroGrid_pdf.RowHeadersVisible = False
        Me.MetroGrid_pdf.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid_pdf.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue
        Me.MetroGrid_pdf.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.MetroGrid_pdf.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MetroGrid_pdf.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.MetroGrid_pdf.RowTemplate.Height = 30
        Me.MetroGrid_pdf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid_pdf.Size = New System.Drawing.Size(326, 27)
        Me.MetroGrid_pdf.TabIndex = 626
        Me.MetroGrid_pdf.Visible = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.botonamarillo
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = Global.MiClickDerecho.My.Resources.Resources.pdf_ico
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(257, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 45)
        Me.Button1.TabIndex = 298
        Me.Button1.Text = "Exportar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Btn_nuevo
        '
        Me.Btn_nuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_nuevo.BackColor = System.Drawing.Color.Transparent
        Me.Btn_nuevo.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.botonamarillo
        Me.Btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_nuevo.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Btn_nuevo.FlatAppearance.BorderSize = 0
        Me.Btn_nuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Btn_nuevo.ForeColor = System.Drawing.Color.Black
        Me.Btn_nuevo.Image = Global.MiClickDerecho.My.Resources.Resources.agregar
        Me.Btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_nuevo.Location = New System.Drawing.Point(14, 0)
        Me.Btn_nuevo.Name = "Btn_nuevo"
        Me.Btn_nuevo.Size = New System.Drawing.Size(66, 45)
        Me.Btn_nuevo.TabIndex = 296
        Me.Btn_nuevo.Text = "Nuevo"
        Me.Btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_nuevo.UseVisualStyleBackColor = False
        '
        'Btn_Ver_editar
        '
        Me.Btn_Ver_editar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Ver_editar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Ver_editar.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.botonamarillo
        Me.Btn_Ver_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Ver_editar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Ver_editar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Btn_Ver_editar.FlatAppearance.BorderSize = 0
        Me.Btn_Ver_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_Ver_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btn_Ver_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Ver_editar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Btn_Ver_editar.ForeColor = System.Drawing.Color.Black
        Me.Btn_Ver_editar.Image = Global.MiClickDerecho.My.Resources.Resources.viewicone
        Me.Btn_Ver_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Ver_editar.Location = New System.Drawing.Point(86, 0)
        Me.Btn_Ver_editar.Name = "Btn_Ver_editar"
        Me.Btn_Ver_editar.Size = New System.Drawing.Size(80, 45)
        Me.Btn_Ver_editar.TabIndex = 261
        Me.Btn_Ver_editar.Text = "Consultar"
        Me.Btn_Ver_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_Ver_editar.UseVisualStyleBackColor = False
        '
        'Button_eliminar
        '
        Me.Button_eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_eliminar.BackColor = System.Drawing.Color.Transparent
        Me.Button_eliminar.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.botonamarillo
        Me.Button_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button_eliminar.FlatAppearance.BorderSize = 0
        Me.Button_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Button_eliminar.ForeColor = System.Drawing.Color.Black
        Me.Button_eliminar.Image = Global.MiClickDerecho.My.Resources.Resources.QUITAR
        Me.Button_eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_eliminar.Location = New System.Drawing.Point(175, 0)
        Me.Button_eliminar.Name = "Button_eliminar"
        Me.Button_eliminar.Size = New System.Drawing.Size(72, 45)
        Me.Button_eliminar.TabIndex = 297
        Me.Button_eliminar.Text = "Eliminar"
        Me.Button_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_eliminar.UseVisualStyleBackColor = False
        '
        'Panel_titlebar
        '
        Me.Panel_titlebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel_titlebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_titlebar.Controls.Add(Me.Button_cerrar)
        Me.Panel_titlebar.Controls.Add(Me.Button_productos)
        Me.Panel_titlebar.Controls.Add(Me.Label1)
        Me.Panel_titlebar.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_titlebar.Location = New System.Drawing.Point(0, 0)
        Me.Panel_titlebar.Name = "Panel_titlebar"
        Me.Panel_titlebar.Size = New System.Drawing.Size(829, 32)
        Me.Panel_titlebar.TabIndex = 567
        '
        'Button_cerrar
        '
        Me.Button_cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_cerrar.BackColor = System.Drawing.Color.Transparent
        Me.Button_cerrar.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.CANCEL
        Me.Button_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_cerrar.FlatAppearance.BorderSize = 0
        Me.Button_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_cerrar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_cerrar.ForeColor = System.Drawing.Color.White
        Me.Button_cerrar.Location = New System.Drawing.Point(794, 3)
        Me.Button_cerrar.Name = "Button_cerrar"
        Me.Button_cerrar.Size = New System.Drawing.Size(25, 25)
        Me.Button_cerrar.TabIndex = 438
        Me.Button_cerrar.UseVisualStyleBackColor = False
        '
        'Button_productos
        '
        Me.Button_productos.BackColor = System.Drawing.Color.Transparent
        Me.Button_productos.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.manufactur
        Me.Button_productos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_productos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_productos.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_productos.FlatAppearance.BorderSize = 0
        Me.Button_productos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.Button_productos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_productos.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_productos.ForeColor = System.Drawing.Color.Black
        Me.Button_productos.Location = New System.Drawing.Point(6, 1)
        Me.Button_productos.Name = "Button_productos"
        Me.Button_productos.Size = New System.Drawing.Size(36, 31)
        Me.Button_productos.TabIndex = 394
        Me.Button_productos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_productos.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(44, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 19)
        Me.Label1.TabIndex = 393
        Me.Label1.Text = "Opciones de Producción"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'datagrid_recetas
        '
        Me.datagrid_recetas.AllowUserToAddRows = False
        Me.datagrid_recetas.AllowUserToDeleteRows = False
        Me.datagrid_recetas.AllowUserToOrderColumns = True
        Me.datagrid_recetas.AllowUserToResizeRows = False
        Me.datagrid_recetas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datagrid_recetas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagrid_recetas.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.datagrid_recetas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datagrid_recetas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.datagrid_recetas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_recetas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.datagrid_recetas.ColumnHeadersHeight = 30
        Me.datagrid_recetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid_recetas.DefaultCellStyle = DataGridViewCellStyle8
        Me.datagrid_recetas.EnableHeadersVisualStyles = False
        Me.datagrid_recetas.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.datagrid_recetas.GridColor = System.Drawing.Color.SteelBlue
        Me.datagrid_recetas.Location = New System.Drawing.Point(11, 59)
        Me.datagrid_recetas.MultiSelect = False
        Me.datagrid_recetas.Name = "datagrid_recetas"
        Me.datagrid_recetas.ReadOnly = True
        Me.datagrid_recetas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_recetas.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.datagrid_recetas.RowHeadersVisible = False
        Me.datagrid_recetas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagrid_recetas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue
        Me.datagrid_recetas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.datagrid_recetas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.datagrid_recetas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.datagrid_recetas.RowTemplate.Height = 30
        Me.datagrid_recetas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrid_recetas.Size = New System.Drawing.Size(767, 406)
        Me.datagrid_recetas.TabIndex = 578
        '
        'Button_guardar_receta
        '
        Me.Button_guardar_receta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_guardar_receta.BackColor = System.Drawing.Color.Transparent
        Me.Button_guardar_receta.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.botonamarillo
        Me.Button_guardar_receta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_guardar_receta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_guardar_receta.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button_guardar_receta.FlatAppearance.BorderSize = 0
        Me.Button_guardar_receta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_guardar_receta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.Button_guardar_receta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_guardar_receta.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_guardar_receta.ForeColor = System.Drawing.Color.Black
        Me.Button_guardar_receta.Image = Global.MiClickDerecho.My.Resources.Resources.guardar
        Me.Button_guardar_receta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_guardar_receta.Location = New System.Drawing.Point(442, 9)
        Me.Button_guardar_receta.Name = "Button_guardar_receta"
        Me.Button_guardar_receta.Size = New System.Drawing.Size(77, 45)
        Me.Button_guardar_receta.TabIndex = 581
        Me.Button_guardar_receta.Text = "Guardar"
        Me.Button_guardar_receta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_guardar_receta.UseVisualStyleBackColor = False
        '
        'Button_Regresar_receta
        '
        Me.Button_Regresar_receta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Regresar_receta.BackColor = System.Drawing.Color.Transparent
        Me.Button_Regresar_receta.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.botonamarillo
        Me.Button_Regresar_receta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Regresar_receta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Regresar_receta.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button_Regresar_receta.FlatAppearance.BorderSize = 0
        Me.Button_Regresar_receta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_Regresar_receta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_Regresar_receta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Regresar_receta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button_Regresar_receta.ForeColor = System.Drawing.Color.Black
        Me.Button_Regresar_receta.Image = Global.MiClickDerecho.My.Resources.Resources.back
        Me.Button_Regresar_receta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_Regresar_receta.Location = New System.Drawing.Point(684, 9)
        Me.Button_Regresar_receta.Name = "Button_Regresar_receta"
        Me.Button_Regresar_receta.Size = New System.Drawing.Size(83, 45)
        Me.Button_Regresar_receta.TabIndex = 582
        Me.Button_Regresar_receta.Text = "Regresar"
        Me.Button_Regresar_receta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_Regresar_receta.UseVisualStyleBackColor = False
        '
        'TabControl_detalle
        '
        Me.TabControl_detalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl_detalle.Controls.Add(Me.MetroTabPage1)
        Me.TabControl_detalle.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.TabControl_detalle.FontSize = MetroFramework.MetroTabControlSize.Small
        Me.TabControl_detalle.FontWeight = MetroFramework.MetroTabControlWeight.Bold
        Me.TabControl_detalle.HotTrack = True
        Me.TabControl_detalle.ItemSize = New System.Drawing.Size(160, 5)
        Me.TabControl_detalle.Location = New System.Drawing.Point(8, 41)
        Me.TabControl_detalle.Name = "TabControl_detalle"
        Me.TabControl_detalle.SelectedIndex = 0
        Me.TabControl_detalle.Size = New System.Drawing.Size(801, 489)
        Me.TabControl_detalle.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl_detalle.TabIndex = 602
        Me.TabControl_detalle.TabStop = False
        Me.TabControl_detalle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.TabControl_detalle.UseCustomBackColor = True
        Me.TabControl_detalle.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.BackColor = System.Drawing.Color.Transparent
        Me.MetroTabPage1.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.cuadro_blanco
        Me.MetroTabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MetroTabPage1.Controls.Add(Me.Panel_detalles)
        Me.MetroTabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 9)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(793, 476)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.UseVisualStyleBackColor = True
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'Panel_detalles
        '
        Me.Panel_detalles.BackColor = System.Drawing.Color.Transparent
        Me.Panel_detalles.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.cuadro_blanco
        Me.Panel_detalles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_detalles.Controls.Add(Me.RadioButton_PROCESADOS)
        Me.Panel_detalles.Controls.Add(Me.RadioButton_INSUMOS)
        Me.Panel_detalles.Controls.Add(Me.Label6)
        Me.Panel_detalles.Controls.Add(Me.ComboBox1)
        Me.Panel_detalles.Controls.Add(Me.Panel_dock)
        Me.Panel_detalles.Controls.Add(Me.Button_exportar)
        Me.Panel_detalles.Controls.Add(Me.NumericUpDown_cant)
        Me.Panel_detalles.Controls.Add(Me.Label8)
        Me.Panel_detalles.Controls.Add(Me.Button_agregar_prod)
        Me.Panel_detalles.Controls.Add(Me.button_Quitar_Prod)
        Me.Panel_detalles.Controls.Add(Me.DataGrid_materia_prima)
        Me.Panel_detalles.Controls.Add(Me.ComboBox_materiaprima)
        Me.Panel_detalles.Controls.Add(Me.Button_Regresar_receta)
        Me.Panel_detalles.Controls.Add(Me.Button_guardar_receta)
        Me.Panel_detalles.Controls.Add(Me.Label10)
        Me.Panel_detalles.Controls.Add(Me.ComboBox_prods_procesados)
        Me.Panel_detalles.Controls.Add(Me.Panel1)
        Me.Panel_detalles.Controls.Add(Me.Label3)
        Me.Panel_detalles.Controls.Add(Me.Button_ELIMINAR2)
        Me.Panel_detalles.Controls.Add(Me.NumericUpDown_desechos)
        Me.Panel_detalles.Controls.Add(Me.NumericUpDown_merma)
        Me.Panel_detalles.Controls.Add(Me.Label5)
        Me.Panel_detalles.Controls.Add(Me.Label4)
        Me.Panel_detalles.Controls.Add(Me.datagrid_recetas)
        Me.Panel_detalles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_detalles.Location = New System.Drawing.Point(0, 0)
        Me.Panel_detalles.Name = "Panel_detalles"
        Me.Panel_detalles.Size = New System.Drawing.Size(793, 476)
        Me.Panel_detalles.TabIndex = 546
        '
        'RadioButton_PROCESADOS
        '
        Me.RadioButton_PROCESADOS.AutoSize = True
        Me.RadioButton_PROCESADOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.RadioButton_PROCESADOS.Location = New System.Drawing.Point(99, 165)
        Me.RadioButton_PROCESADOS.Name = "RadioButton_PROCESADOS"
        Me.RadioButton_PROCESADOS.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton_PROCESADOS.TabIndex = 629
        Me.RadioButton_PROCESADOS.Text = "Procesados"
        Me.RadioButton_PROCESADOS.UseVisualStyleBackColor = True
        '
        'RadioButton_INSUMOS
        '
        Me.RadioButton_INSUMOS.AutoSize = True
        Me.RadioButton_INSUMOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.RadioButton_INSUMOS.Location = New System.Drawing.Point(16, 165)
        Me.RadioButton_INSUMOS.Name = "RadioButton_INSUMOS"
        Me.RadioButton_INSUMOS.Size = New System.Drawing.Size(71, 17)
        Me.RadioButton_INSUMOS.TabIndex = 628
        Me.RadioButton_INSUMOS.Text = "Insumos"
        Me.RadioButton_INSUMOS.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(18, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 12)
        Me.Label6.TabIndex = 627
        Me.Label6.Text = "Producto Desecho"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.Black
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.ItemHeight = 16
        Me.ComboBox1.Location = New System.Drawing.Point(136, 137)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(374, 24)
        Me.ComboBox1.TabIndex = 626
        '
        'Button_exportar
        '
        Me.Button_exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_exportar.BackColor = System.Drawing.Color.Transparent
        Me.Button_exportar.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.botonamarillo
        Me.Button_exportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_exportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_exportar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button_exportar.FlatAppearance.BorderSize = 0
        Me.Button_exportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_exportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_exportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_exportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Button_exportar.ForeColor = System.Drawing.Color.Black
        Me.Button_exportar.Image = Global.MiClickDerecho.My.Resources.Resources.download2
        Me.Button_exportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_exportar.Location = New System.Drawing.Point(604, 9)
        Me.Button_exportar.Name = "Button_exportar"
        Me.Button_exportar.Size = New System.Drawing.Size(72, 45)
        Me.Button_exportar.TabIndex = 298
        Me.Button_exportar.Text = "Exportar"
        Me.Button_exportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_exportar.UseVisualStyleBackColor = False
        '
        'NumericUpDown_cant
        '
        Me.NumericUpDown_cant.DecimalPlaces = 2
        Me.NumericUpDown_cant.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown_cant.Location = New System.Drawing.Point(521, 181)
        Me.NumericUpDown_cant.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.NumericUpDown_cant.Minimum = New Decimal(New Integer() {100000000, 0, 0, -2147483648})
        Me.NumericUpDown_cant.Name = "NumericUpDown_cant"
        Me.NumericUpDown_cant.Size = New System.Drawing.Size(111, 26)
        Me.NumericUpDown_cant.TabIndex = 617
        Me.NumericUpDown_cant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(549, 169)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 12)
        Me.Label8.TabIndex = 618
        Me.Label8.Text = "Cantidad"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button_agregar_prod
        '
        Me.Button_agregar_prod.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_agregar_prod.BackColor = System.Drawing.Color.Transparent
        Me.Button_agregar_prod.BackgroundImage = CType(resources.GetObject("Button_agregar_prod.BackgroundImage"), System.Drawing.Image)
        Me.Button_agregar_prod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_agregar_prod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_agregar_prod.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_agregar_prod.FlatAppearance.BorderSize = 0
        Me.Button_agregar_prod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button_agregar_prod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.Button_agregar_prod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_agregar_prod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_agregar_prod.ForeColor = System.Drawing.Color.White
        Me.Button_agregar_prod.Image = Global.MiClickDerecho.My.Resources.Resources.agregar
        Me.Button_agregar_prod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_agregar_prod.Location = New System.Drawing.Point(661, 171)
        Me.Button_agregar_prod.Name = "Button_agregar_prod"
        Me.Button_agregar_prod.Size = New System.Drawing.Size(109, 35)
        Me.Button_agregar_prod.TabIndex = 606
        Me.Button_agregar_prod.Text = "Agregar Insumo"
        Me.Button_agregar_prod.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_agregar_prod.UseVisualStyleBackColor = False
        '
        'button_Quitar_Prod
        '
        Me.button_Quitar_Prod.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button_Quitar_Prod.BackColor = System.Drawing.Color.Transparent
        Me.button_Quitar_Prod.BackgroundImage = CType(resources.GetObject("button_Quitar_Prod.BackgroundImage"), System.Drawing.Image)
        Me.button_Quitar_Prod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button_Quitar_Prod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_Quitar_Prod.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.button_Quitar_Prod.FlatAppearance.BorderSize = 0
        Me.button_Quitar_Prod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.button_Quitar_Prod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.button_Quitar_Prod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_Quitar_Prod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_Quitar_Prod.ForeColor = System.Drawing.Color.White
        Me.button_Quitar_Prod.Image = Global.MiClickDerecho.My.Resources.Resources.QUITAR
        Me.button_Quitar_Prod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_Quitar_Prod.Location = New System.Drawing.Point(661, 132)
        Me.button_Quitar_Prod.Name = "button_Quitar_Prod"
        Me.button_Quitar_Prod.Size = New System.Drawing.Size(109, 35)
        Me.button_Quitar_Prod.TabIndex = 607
        Me.button_Quitar_Prod.Text = "Quitar Insumo"
        Me.button_Quitar_Prod.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_Quitar_Prod.UseVisualStyleBackColor = False
        '
        'DataGrid_materia_prima
        '
        Me.DataGrid_materia_prima.AllowUserToAddRows = False
        Me.DataGrid_materia_prima.AllowUserToDeleteRows = False
        Me.DataGrid_materia_prima.AllowUserToOrderColumns = True
        Me.DataGrid_materia_prima.AllowUserToResizeRows = False
        Me.DataGrid_materia_prima.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGrid_materia_prima.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGrid_materia_prima.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.DataGrid_materia_prima.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGrid_materia_prima.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DataGrid_materia_prima.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid_materia_prima.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGrid_materia_prima.ColumnHeadersHeight = 30
        Me.DataGrid_materia_prima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrid_materia_prima.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGrid_materia_prima.EnableHeadersVisualStyles = False
        Me.DataGrid_materia_prima.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.DataGrid_materia_prima.GridColor = System.Drawing.Color.SteelBlue
        Me.DataGrid_materia_prima.Location = New System.Drawing.Point(12, 211)
        Me.DataGrid_materia_prima.MultiSelect = False
        Me.DataGrid_materia_prima.Name = "DataGrid_materia_prima"
        Me.DataGrid_materia_prima.ReadOnly = True
        Me.DataGrid_materia_prima.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid_materia_prima.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGrid_materia_prima.RowHeadersVisible = False
        Me.DataGrid_materia_prima.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGrid_materia_prima.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue
        Me.DataGrid_materia_prima.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGrid_materia_prima.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DataGrid_materia_prima.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGrid_materia_prima.RowTemplate.Height = 30
        Me.DataGrid_materia_prima.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid_materia_prima.Size = New System.Drawing.Size(760, 244)
        Me.DataGrid_materia_prima.TabIndex = 605
        '
        'ComboBox_materiaprima
        '
        Me.ComboBox_materiaprima.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox_materiaprima.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox_materiaprima.BackColor = System.Drawing.Color.White
        Me.ComboBox_materiaprima.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_materiaprima.ForeColor = System.Drawing.Color.Black
        Me.ComboBox_materiaprima.FormattingEnabled = True
        Me.ComboBox_materiaprima.ItemHeight = 16
        Me.ComboBox_materiaprima.Location = New System.Drawing.Point(12, 183)
        Me.ComboBox_materiaprima.Name = "ComboBox_materiaprima"
        Me.ComboBox_materiaprima.Size = New System.Drawing.Size(498, 24)
        Me.ComboBox_materiaprima.TabIndex = 599
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(15, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 12)
        Me.Label10.TabIndex = 616
        Me.Label10.Text = "Producto Procesado"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox_prods_procesados
        '
        Me.ComboBox_prods_procesados.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox_prods_procesados.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox_prods_procesados.BackColor = System.Drawing.Color.SteelBlue
        Me.ComboBox_prods_procesados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox_prods_procesados.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_prods_procesados.ForeColor = System.Drawing.Color.White
        Me.ComboBox_prods_procesados.FormattingEnabled = True
        Me.ComboBox_prods_procesados.ItemHeight = 18
        Me.ComboBox_prods_procesados.Location = New System.Drawing.Point(12, 74)
        Me.ComboBox_prods_procesados.Name = "ComboBox_prods_procesados"
        Me.ComboBox_prods_procesados.Size = New System.Drawing.Size(499, 26)
        Me.ComboBox_prods_procesados.TabIndex = 615
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TextBox_buscar_receta)
        Me.Panel1.Controls.Add(Me.Button_buscar)
        Me.Panel1.Location = New System.Drawing.Point(11, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(280, 44)
        Me.Panel1.TabIndex = 619
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 12)
        Me.Label2.TabIndex = 598
        Me.Label2.Text = "Buscar Productos"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_buscar_receta
        '
        Me.TextBox_buscar_receta.BackColor = System.Drawing.Color.SteelBlue
        Me.TextBox_buscar_receta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_buscar_receta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_buscar_receta.ForeColor = System.Drawing.Color.White
        Me.TextBox_buscar_receta.Location = New System.Drawing.Point(2, 18)
        Me.TextBox_buscar_receta.Name = "TextBox_buscar_receta"
        Me.TextBox_buscar_receta.Size = New System.Drawing.Size(179, 24)
        Me.TextBox_buscar_receta.TabIndex = 601
        Me.TextBox_buscar_receta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button_buscar
        '
        Me.Button_buscar.BackColor = System.Drawing.Color.Transparent
        Me.Button_buscar.BackgroundImage = CType(resources.GetObject("Button_buscar.BackgroundImage"), System.Drawing.Image)
        Me.Button_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_buscar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_buscar.FlatAppearance.BorderSize = 0
        Me.Button_buscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_buscar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_buscar.ForeColor = System.Drawing.Color.White
        Me.Button_buscar.Location = New System.Drawing.Point(190, 14)
        Me.Button_buscar.Name = "Button_buscar"
        Me.Button_buscar.Size = New System.Drawing.Size(85, 28)
        Me.Button_buscar.TabIndex = 614
        Me.Button_buscar.Text = " "
        Me.Button_buscar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(16, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(276, 24)
        Me.Label3.TabIndex = 620
        Me.Label3.Text = "Parametros de Producción"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Visible = False
        '
        'Button_ELIMINAR2
        '
        Me.Button_ELIMINAR2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_ELIMINAR2.BackColor = System.Drawing.Color.Transparent
        Me.Button_ELIMINAR2.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.botonamarillo
        Me.Button_ELIMINAR2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_ELIMINAR2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_ELIMINAR2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button_ELIMINAR2.FlatAppearance.BorderSize = 0
        Me.Button_ELIMINAR2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_ELIMINAR2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_ELIMINAR2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_ELIMINAR2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Button_ELIMINAR2.ForeColor = System.Drawing.Color.Black
        Me.Button_ELIMINAR2.Image = Global.MiClickDerecho.My.Resources.Resources.QUITAR
        Me.Button_ELIMINAR2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_ELIMINAR2.Location = New System.Drawing.Point(526, 9)
        Me.Button_ELIMINAR2.Name = "Button_ELIMINAR2"
        Me.Button_ELIMINAR2.Size = New System.Drawing.Size(72, 45)
        Me.Button_ELIMINAR2.TabIndex = 621
        Me.Button_ELIMINAR2.Text = "Eliminar"
        Me.Button_ELIMINAR2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_ELIMINAR2.UseVisualStyleBackColor = False
        '
        'NumericUpDown_desechos
        '
        Me.NumericUpDown_desechos.DecimalPlaces = 2
        Me.NumericUpDown_desechos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown_desechos.Location = New System.Drawing.Point(387, 106)
        Me.NumericUpDown_desechos.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.NumericUpDown_desechos.Minimum = New Decimal(New Integer() {100000000, 0, 0, -2147483648})
        Me.NumericUpDown_desechos.Name = "NumericUpDown_desechos"
        Me.NumericUpDown_desechos.Size = New System.Drawing.Size(122, 26)
        Me.NumericUpDown_desechos.TabIndex = 625
        Me.NumericUpDown_desechos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NumericUpDown_merma
        '
        Me.NumericUpDown_merma.DecimalPlaces = 2
        Me.NumericUpDown_merma.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown_merma.Location = New System.Drawing.Point(137, 106)
        Me.NumericUpDown_merma.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.NumericUpDown_merma.Minimum = New Decimal(New Integer() {100000000, 0, 0, -2147483648})
        Me.NumericUpDown_merma.Name = "NumericUpDown_merma"
        Me.NumericUpDown_merma.Size = New System.Drawing.Size(122, 26)
        Me.NumericUpDown_merma.TabIndex = 624
        Me.NumericUpDown_merma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(326, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 12)
        Me.Label5.TabIndex = 623
        Me.Label5.Text = "Desechos"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(17, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 12)
        Me.Label4.TabIndex = 622
        Me.Label4.Text = "Merma de Producción"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 5
        Me.BunifuElipse2.TargetControl = Me.DataGrid_materia_prima
        '
        'BunifuElipse3
        '
        Me.BunifuElipse3.ElipseRadius = 5
        Me.BunifuElipse3.TargetControl = Me.TextBox_buscar_receta
        '
        'BunifuElipse4
        '
        Me.BunifuElipse4.ElipseRadius = 5
        Me.BunifuElipse4.TargetControl = Me.datagrid_recetas
        '
        'Form_producc_opciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(829, 549)
        Me.Controls.Add(Me.TabControl_detalle)
        Me.Controls.Add(Me.Panel_titlebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_producc_opciones"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_producc_opciones"
        Me.Panel_dock.ResumeLayout(False)
        CType(Me.MetroGrid_pdf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_titlebar.ResumeLayout(False)
        Me.Panel_titlebar.PerformLayout()
        CType(Me.datagrid_recetas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl_detalle.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.Panel_detalles.ResumeLayout(False)
        Me.Panel_detalles.PerformLayout()
        CType(Me.NumericUpDown_cant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid_materia_prima, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.NumericUpDown_desechos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_merma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents Panel_dock As Panel
    Friend WithEvents Btn_nuevo As Button
    Friend WithEvents Btn_Ver_editar As Button
    Friend WithEvents Panel_titlebar As Panel
    Friend WithEvents Button_cerrar As Button
    Friend WithEvents Button_productos As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button_eliminar As Button
    Friend WithEvents datagrid_recetas As MetroFramework.Controls.MetroGrid
    Friend WithEvents Button_guardar_receta As Button
    Friend WithEvents Button_Regresar_receta As Button
    Friend WithEvents TabControl_detalle As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Panel_detalles As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox_materiaprima As ComboBox
    Friend WithEvents TextBox_buscar_receta As TextBox
    Friend WithEvents DataGrid_materia_prima As MetroFramework.Controls.MetroGrid
    Friend WithEvents Button_agregar_prod As Button
    Friend WithEvents button_Quitar_Prod As Button
    Friend WithEvents Button_buscar As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox_prods_procesados As ComboBox
    Friend WithEvents NumericUpDown_cant As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Button_exportar As Button
    Friend WithEvents Button_ELIMINAR2 As Button
    Friend WithEvents BunifuElipse2 As ns1.BunifuElipse
    Friend WithEvents BunifuElipse3 As ns1.BunifuElipse
    Friend WithEvents BunifuElipse4 As ns1.BunifuElipse
    Friend WithEvents NumericUpDown_desechos As NumericUpDown
    Friend WithEvents NumericUpDown_merma As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents MetroGrid_pdf As MetroFramework.Controls.MetroGrid
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents RadioButton_PROCESADOS As RadioButton
    Friend WithEvents RadioButton_INSUMOS As RadioButton
End Class
