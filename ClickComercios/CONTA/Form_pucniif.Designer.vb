<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_pucniif
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_pucniif))
        Me.MetroGrid_NIIF = New MetroFramework.Controls.MetroGrid()
        Me.TreeView_niif = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel_opciones = New System.Windows.Forms.Panel()
        Me.Button_consultar_niif = New System.Windows.Forms.Button()
        Me.Button_eliminar_niif = New System.Windows.Forms.Button()
        Me.Button_crear_niif = New System.Windows.Forms.Button()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.TextBox_codigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_cuenta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel_guardar = New System.Windows.Forms.Panel()
        Me.Button_eliminar_ok_niif = New System.Windows.Forms.Button()
        Me.Button_regresar_niif = New System.Windows.Forms.Button()
        Me.Button_guardar_niif = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.MetroGrid_NIIF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_opciones.SuspendLayout()
        Me.Panel_guardar.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroGrid_NIIF
        '
        Me.MetroGrid_NIIF.AllowUserToAddRows = False
        Me.MetroGrid_NIIF.AllowUserToDeleteRows = False
        Me.MetroGrid_NIIF.AllowUserToResizeRows = False
        Me.MetroGrid_NIIF.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroGrid_NIIF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MetroGrid_NIIF.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.MetroGrid_NIIF.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.MetroGrid_NIIF.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid_NIIF.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid_NIIF.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid_NIIF.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.MetroGrid_NIIF.ColumnHeadersHeight = 28
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid_NIIF.DefaultCellStyle = DataGridViewCellStyle11
        Me.MetroGrid_NIIF.EnableHeadersVisualStyles = False
        Me.MetroGrid_NIIF.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid_NIIF.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid_NIIF.Location = New System.Drawing.Point(493, 111)
        Me.MetroGrid_NIIF.MultiSelect = False
        Me.MetroGrid_NIIF.Name = "MetroGrid_NIIF"
        Me.MetroGrid_NIIF.ReadOnly = True
        Me.MetroGrid_NIIF.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid_NIIF.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.MetroGrid_NIIF.RowHeadersVisible = False
        Me.MetroGrid_NIIF.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid_NIIF.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue
        Me.MetroGrid_NIIF.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.MetroGrid_NIIF.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MetroGrid_NIIF.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.MetroGrid_NIIF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid_NIIF.Size = New System.Drawing.Size(480, 429)
        Me.MetroGrid_NIIF.TabIndex = 586
        '
        'TreeView_niif
        '
        Me.TreeView_niif.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView_niif.BackColor = System.Drawing.SystemColors.Control
        Me.TreeView_niif.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TreeView_niif.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView_niif.ImageIndex = 0
        Me.TreeView_niif.ImageList = Me.ImageList1
        Me.TreeView_niif.Location = New System.Drawing.Point(10, 55)
        Me.TreeView_niif.Name = "TreeView_niif"
        Me.TreeView_niif.SelectedImageIndex = 0
        Me.TreeView_niif.Size = New System.Drawing.Size(477, 485)
        Me.TreeView_niif.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "money.png")
        Me.ImageList1.Images.SetKeyName(1, "QUITAR.png")
        Me.ImageList1.Images.SetKeyName(2, "clientes.png")
        Me.ImageList1.Images.SetKeyName(3, "cuentas-por-cobrar.png")
        Me.ImageList1.Images.SetKeyName(4, "cuentas-por-pagar.png")
        Me.ImageList1.Images.SetKeyName(5, "pos-2.png")
        Me.ImageList1.Images.SetKeyName(6, "manufactur.png")
        '
        'Panel_opciones
        '
        Me.Panel_opciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_opciones.Controls.Add(Me.Button_consultar_niif)
        Me.Panel_opciones.Controls.Add(Me.Button_eliminar_niif)
        Me.Panel_opciones.Controls.Add(Me.Button_crear_niif)
        Me.Panel_opciones.Location = New System.Drawing.Point(706, 13)
        Me.Panel_opciones.Name = "Panel_opciones"
        Me.Panel_opciones.Size = New System.Drawing.Size(267, 51)
        Me.Panel_opciones.TabIndex = 662
        '
        'Button_consultar_niif
        '
        Me.Button_consultar_niif.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_consultar_niif.BackColor = System.Drawing.Color.Transparent
        Me.Button_consultar_niif.BackgroundImage = CType(resources.GetObject("Button_consultar_niif.BackgroundImage"), System.Drawing.Image)
        Me.Button_consultar_niif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_consultar_niif.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_consultar_niif.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button_consultar_niif.FlatAppearance.BorderSize = 0
        Me.Button_consultar_niif.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_consultar_niif.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.Button_consultar_niif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_consultar_niif.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_consultar_niif.ForeColor = System.Drawing.Color.White
        Me.Button_consultar_niif.Image = Global.MiClickDerecho.My.Resources.Resources.lapizico
        Me.Button_consultar_niif.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_consultar_niif.Location = New System.Drawing.Point(100, 2)
        Me.Button_consultar_niif.Name = "Button_consultar_niif"
        Me.Button_consultar_niif.Size = New System.Drawing.Size(80, 48)
        Me.Button_consultar_niif.TabIndex = 662
        Me.Button_consultar_niif.Text = "Consultar"
        Me.Button_consultar_niif.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_consultar_niif.UseVisualStyleBackColor = False
        '
        'Button_eliminar_niif
        '
        Me.Button_eliminar_niif.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_eliminar_niif.BackColor = System.Drawing.Color.Transparent
        Me.Button_eliminar_niif.BackgroundImage = CType(resources.GetObject("Button_eliminar_niif.BackgroundImage"), System.Drawing.Image)
        Me.Button_eliminar_niif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_eliminar_niif.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_eliminar_niif.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button_eliminar_niif.FlatAppearance.BorderSize = 0
        Me.Button_eliminar_niif.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_eliminar_niif.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.Button_eliminar_niif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_eliminar_niif.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_eliminar_niif.ForeColor = System.Drawing.Color.White
        Me.Button_eliminar_niif.Image = Global.MiClickDerecho.My.Resources.Resources.delete_row
        Me.Button_eliminar_niif.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_eliminar_niif.Location = New System.Drawing.Point(185, 2)
        Me.Button_eliminar_niif.Name = "Button_eliminar_niif"
        Me.Button_eliminar_niif.Size = New System.Drawing.Size(78, 48)
        Me.Button_eliminar_niif.TabIndex = 661
        Me.Button_eliminar_niif.Text = "Eliminar"
        Me.Button_eliminar_niif.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_eliminar_niif.UseVisualStyleBackColor = False
        '
        'Button_crear_niif
        '
        Me.Button_crear_niif.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_crear_niif.BackColor = System.Drawing.Color.Transparent
        Me.Button_crear_niif.BackgroundImage = CType(resources.GetObject("Button_crear_niif.BackgroundImage"), System.Drawing.Image)
        Me.Button_crear_niif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_crear_niif.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_crear_niif.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button_crear_niif.FlatAppearance.BorderSize = 0
        Me.Button_crear_niif.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_crear_niif.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.Button_crear_niif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_crear_niif.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_crear_niif.ForeColor = System.Drawing.Color.White
        Me.Button_crear_niif.Image = Global.MiClickDerecho.My.Resources.Resources.agregar
        Me.Button_crear_niif.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_crear_niif.Location = New System.Drawing.Point(14, 2)
        Me.Button_crear_niif.Name = "Button_crear_niif"
        Me.Button_crear_niif.Size = New System.Drawing.Size(81, 48)
        Me.Button_crear_niif.TabIndex = 660
        Me.Button_crear_niif.Text = "Crear"
        Me.Button_crear_niif.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_crear_niif.UseVisualStyleBackColor = False
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(16, 13)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(359, 37)
        Me.Label40.TabIndex = 663
        Me.Label40.Text = "Catálogo de Conceptos NIIF"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_codigo
        '
        Me.TextBox_codigo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_codigo.BackColor = System.Drawing.Color.White
        Me.TextBox_codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_codigo.ForeColor = System.Drawing.Color.Black
        Me.TextBox_codigo.Location = New System.Drawing.Point(509, 198)
        Me.TextBox_codigo.MaxLength = 8
        Me.TextBox_codigo.Name = "TextBox_codigo"
        Me.TextBox_codigo.Size = New System.Drawing.Size(143, 24)
        Me.TextBox_codigo.TabIndex = 664
        Me.TextBox_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(509, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 17)
        Me.Label1.TabIndex = 665
        Me.Label1.Text = "Código Concepto"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_cuenta
        '
        Me.TextBox_cuenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_cuenta.BackColor = System.Drawing.Color.White
        Me.TextBox_cuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_cuenta.ForeColor = System.Drawing.Color.Black
        Me.TextBox_cuenta.Location = New System.Drawing.Point(509, 147)
        Me.TextBox_cuenta.MaxLength = 200
        Me.TextBox_cuenta.Multiline = True
        Me.TextBox_cuenta.Name = "TextBox_cuenta"
        Me.TextBox_cuenta.Size = New System.Drawing.Size(453, 25)
        Me.TextBox_cuenta.TabIndex = 666
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(509, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(245, 17)
        Me.Label2.TabIndex = 667
        Me.Label2.Text = "Nombre del Concepto de Contabilidad"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel_guardar
        '
        Me.Panel_guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_guardar.Controls.Add(Me.Button_eliminar_ok_niif)
        Me.Panel_guardar.Controls.Add(Me.Button_regresar_niif)
        Me.Panel_guardar.Controls.Add(Me.Button_guardar_niif)
        Me.Panel_guardar.Location = New System.Drawing.Point(516, 367)
        Me.Panel_guardar.Name = "Panel_guardar"
        Me.Panel_guardar.Size = New System.Drawing.Size(399, 51)
        Me.Panel_guardar.TabIndex = 663
        '
        'Button_eliminar_ok_niif
        '
        Me.Button_eliminar_ok_niif.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_eliminar_ok_niif.BackColor = System.Drawing.Color.Transparent
        Me.Button_eliminar_ok_niif.BackgroundImage = CType(resources.GetObject("Button_eliminar_ok_niif.BackgroundImage"), System.Drawing.Image)
        Me.Button_eliminar_ok_niif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_eliminar_ok_niif.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_eliminar_ok_niif.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button_eliminar_ok_niif.FlatAppearance.BorderSize = 0
        Me.Button_eliminar_ok_niif.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_eliminar_ok_niif.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.Button_eliminar_ok_niif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_eliminar_ok_niif.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_eliminar_ok_niif.ForeColor = System.Drawing.Color.White
        Me.Button_eliminar_ok_niif.Image = Global.MiClickDerecho.My.Resources.Resources.delete_row
        Me.Button_eliminar_ok_niif.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_eliminar_ok_niif.Location = New System.Drawing.Point(117, 2)
        Me.Button_eliminar_ok_niif.Name = "Button_eliminar_ok_niif"
        Me.Button_eliminar_ok_niif.Size = New System.Drawing.Size(93, 48)
        Me.Button_eliminar_ok_niif.TabIndex = 663
        Me.Button_eliminar_ok_niif.Text = "Eliminar"
        Me.Button_eliminar_ok_niif.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_eliminar_ok_niif.UseVisualStyleBackColor = False
        '
        'Button_regresar_niif
        '
        Me.Button_regresar_niif.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_regresar_niif.BackColor = System.Drawing.Color.Transparent
        Me.Button_regresar_niif.BackgroundImage = CType(resources.GetObject("Button_regresar_niif.BackgroundImage"), System.Drawing.Image)
        Me.Button_regresar_niif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_regresar_niif.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_regresar_niif.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button_regresar_niif.FlatAppearance.BorderSize = 0
        Me.Button_regresar_niif.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_regresar_niif.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.Button_regresar_niif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_regresar_niif.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_regresar_niif.ForeColor = System.Drawing.Color.White
        Me.Button_regresar_niif.Image = Global.MiClickDerecho.My.Resources.Resources.backk
        Me.Button_regresar_niif.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_regresar_niif.Location = New System.Drawing.Point(315, 2)
        Me.Button_regresar_niif.Name = "Button_regresar_niif"
        Me.Button_regresar_niif.Size = New System.Drawing.Size(80, 48)
        Me.Button_regresar_niif.TabIndex = 662
        Me.Button_regresar_niif.Text = "Regresar"
        Me.Button_regresar_niif.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_regresar_niif.UseVisualStyleBackColor = False
        '
        'Button_guardar_niif
        '
        Me.Button_guardar_niif.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_guardar_niif.BackColor = System.Drawing.Color.Transparent
        Me.Button_guardar_niif.BackgroundImage = CType(resources.GetObject("Button_guardar_niif.BackgroundImage"), System.Drawing.Image)
        Me.Button_guardar_niif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_guardar_niif.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_guardar_niif.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button_guardar_niif.FlatAppearance.BorderSize = 0
        Me.Button_guardar_niif.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_guardar_niif.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.Button_guardar_niif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_guardar_niif.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_guardar_niif.ForeColor = System.Drawing.Color.White
        Me.Button_guardar_niif.Image = Global.MiClickDerecho.My.Resources.Resources.guardar
        Me.Button_guardar_niif.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_guardar_niif.Location = New System.Drawing.Point(216, 2)
        Me.Button_guardar_niif.Name = "Button_guardar_niif"
        Me.Button_guardar_niif.Size = New System.Drawing.Size(93, 48)
        Me.Button_guardar_niif.TabIndex = 660
        Me.Button_guardar_niif.Text = "Guardar"
        Me.Button_guardar_niif.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_guardar_niif.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(499, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 20)
        Me.Label4.TabIndex = 671
        Me.Label4.Text = "Subcuentas de la Cuenta:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(511, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 16)
        Me.Label5.TabIndex = 672
        Me.Label5.Text = "-"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form_pucniif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 551)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel_guardar)
        Me.Controls.Add(Me.TextBox_codigo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TreeView_niif)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.Panel_opciones)
        Me.Controls.Add(Me.TextBox_cuenta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MetroGrid_NIIF)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1001, 590)
        Me.Name = "Form_pucniif"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.MetroGrid_NIIF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_opciones.ResumeLayout(False)
        Me.Panel_guardar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroGrid_NIIF As MetroFramework.Controls.MetroGrid
    Friend WithEvents TreeView_niif As TreeView
    Friend WithEvents Panel_opciones As Panel
    Friend WithEvents Button_crear_niif As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Label40 As Label
    Friend WithEvents Button_eliminar_niif As Button
    Friend WithEvents Button_consultar_niif As Button
    Friend WithEvents TextBox_codigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_cuenta As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel_guardar As Panel
    Friend WithEvents Button_regresar_niif As Button
    Friend WithEvents Button_guardar_niif As Button
    Friend WithEvents Button_eliminar_ok_niif As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
