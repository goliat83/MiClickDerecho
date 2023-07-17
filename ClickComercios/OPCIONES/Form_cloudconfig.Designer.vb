<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_cloudconfig
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_cloudconfig))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.datagrid_local = New MetroFramework.Controls.MetroGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ComboBox_DESTINO = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.datagrid_remoto = New MetroFramework.Controls.MetroGrid()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.BunifuElipse2 = New ns1.BunifuElipse(Me.components)
        Me.BunifuElipse3 = New ns1.BunifuElipse(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel_titlebar = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button_cerrar = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Button_down = New System.Windows.Forms.Button()
        Me.Button_up = New System.Windows.Forms.Button()
        CType(Me.datagrid_local, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.datagrid_remoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_titlebar.SuspendLayout()
        Me.SuspendLayout()
        '
        'datagrid_local
        '
        Me.datagrid_local.AllowUserToAddRows = False
        Me.datagrid_local.AllowUserToDeleteRows = False
        Me.datagrid_local.AllowUserToOrderColumns = True
        Me.datagrid_local.AllowUserToResizeRows = False
        Me.datagrid_local.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.datagrid_local.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.datagrid_local.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datagrid_local.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.datagrid_local.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_local.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datagrid_local.ColumnHeadersHeight = 28
        Me.datagrid_local.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datagrid_local.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid_local.DefaultCellStyle = DataGridViewCellStyle2
        Me.datagrid_local.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagrid_local.EnableHeadersVisualStyles = False
        Me.datagrid_local.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.datagrid_local.GridColor = System.Drawing.Color.DodgerBlue
        Me.datagrid_local.Location = New System.Drawing.Point(10, 174)
        Me.datagrid_local.Name = "datagrid_local"
        Me.datagrid_local.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_local.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.datagrid_local.RowHeadersVisible = False
        Me.datagrid_local.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagrid_local.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.datagrid_local.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.datagrid_local.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.datagrid_local.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.datagrid_local.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrid_local.ShowEditingIcon = False
        Me.datagrid_local.Size = New System.Drawing.Size(502, 476)
        Me.datagrid_local.TabIndex = 599
        '
        'Label1
        '
        Me.Label1.AllowDrop = True
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 15)
        Me.Label1.TabIndex = 600
        Me.Label1.Text = "Seleccione un Modulo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Location = New System.Drawing.Point(9, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(527, 97)
        Me.Panel1.TabIndex = 910
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Panel7.BackgroundImage = CType(resources.GetObject("Panel7.BackgroundImage"), System.Drawing.Image)
        Me.Panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel7.Controls.Add(Me.Label16)
        Me.Panel7.Controls.Add(Me.ComboBox_DESTINO)
        Me.Panel7.Location = New System.Drawing.Point(11, 23)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(324, 39)
        Me.Panel7.TabIndex = 601
        '
        'Label16
        '
        Me.Label16.AllowDrop = True
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(-2, -15)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 15)
        Me.Label16.TabIndex = 449
        Me.Label16.Text = "Destino"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox_DESTINO
        '
        Me.ComboBox_DESTINO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox_DESTINO.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_DESTINO.FormattingEnabled = True
        Me.ComboBox_DESTINO.Items.AddRange(New Object() {"", "Productos", "Invenario", "Ventas", "Compras", "Gastos", "Egresos", "Recibos de Caja", "-", "Esado de Resultados"})
        Me.ComboBox_DESTINO.Location = New System.Drawing.Point(5, 3)
        Me.ComboBox_DESTINO.Name = "ComboBox_DESTINO"
        Me.ComboBox_DESTINO.Size = New System.Drawing.Size(315, 32)
        Me.ComboBox_DESTINO.TabIndex = 542
        '
        'Timer1
        '
        Me.Timer1.Interval = 300
        '
        'datagrid_remoto
        '
        Me.datagrid_remoto.AllowUserToAddRows = False
        Me.datagrid_remoto.AllowUserToDeleteRows = False
        Me.datagrid_remoto.AllowUserToOrderColumns = True
        Me.datagrid_remoto.AllowUserToResizeRows = False
        Me.datagrid_remoto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.datagrid_remoto.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.datagrid_remoto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datagrid_remoto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.datagrid_remoto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_remoto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.datagrid_remoto.ColumnHeadersHeight = 28
        Me.datagrid_remoto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datagrid_remoto.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid_remoto.DefaultCellStyle = DataGridViewCellStyle5
        Me.datagrid_remoto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagrid_remoto.EnableHeadersVisualStyles = False
        Me.datagrid_remoto.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.datagrid_remoto.GridColor = System.Drawing.Color.DodgerBlue
        Me.datagrid_remoto.Location = New System.Drawing.Point(519, 174)
        Me.datagrid_remoto.Name = "datagrid_remoto"
        Me.datagrid_remoto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_remoto.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.datagrid_remoto.RowHeadersVisible = False
        Me.datagrid_remoto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagrid_remoto.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.datagrid_remoto.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.datagrid_remoto.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.datagrid_remoto.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.datagrid_remoto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrid_remoto.ShowEditingIcon = False
        Me.datagrid_remoto.Size = New System.Drawing.Size(484, 476)
        Me.datagrid_remoto.TabIndex = 911
        '
        'Label4
        '
        Me.Label4.AllowDrop = True
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB Demi", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Orange
        Me.Label4.Location = New System.Drawing.Point(12, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 24)
        Me.Label4.TabIndex = 912
        Me.Label4.Text = "Información Local"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label4.UseWaitCursor = True
        '
        'Label5
        '
        Me.Label5.AllowDrop = True
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Berlin Sans FB Demi", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Orange
        Me.Label5.Location = New System.Drawing.Point(526, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(233, 24)
        Me.Label5.TabIndex = 913
        Me.Label5.Text = "Información de la Nube"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label5.UseWaitCursor = True
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 5
        Me.BunifuElipse2.TargetControl = Me.datagrid_local
        '
        'BunifuElipse3
        '
        Me.BunifuElipse3.ElipseRadius = 5
        Me.BunifuElipse3.TargetControl = Me.datagrid_remoto
        '
        'Label3
        '
        Me.Label3.AllowDrop = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label3.Location = New System.Drawing.Point(10, 649)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(993, 20)
        Me.Label3.TabIndex = 602
        Me.Label3.Text = "-"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_titlebar
        '
        Me.Panel_titlebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel_titlebar.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.banner9
        Me.Panel_titlebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_titlebar.Controls.Add(Me.Button6)
        Me.Panel_titlebar.Controls.Add(Me.Button_cerrar)
        Me.Panel_titlebar.Controls.Add(Me.Label23)
        Me.Panel_titlebar.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_titlebar.Location = New System.Drawing.Point(0, 0)
        Me.Panel_titlebar.Name = "Panel_titlebar"
        Me.Panel_titlebar.Size = New System.Drawing.Size(1015, 44)
        Me.Panel_titlebar.TabIndex = 917
        '
        'Button6
        '
        Me.Button6.Anchor = System.Windows.Forms.AnchorStyles.None
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
        Me.Button6.Location = New System.Drawing.Point(1, 1)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(47, 47)
        Me.Button6.TabIndex = 444
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button_cerrar
        '
        Me.Button_cerrar.BackColor = System.Drawing.Color.Transparent
        Me.Button_cerrar.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.CANCEL
        Me.Button_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_cerrar.FlatAppearance.BorderSize = 0
        Me.Button_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.Button_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_cerrar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_cerrar.ForeColor = System.Drawing.Color.White
        Me.Button_cerrar.Location = New System.Drawing.Point(972, 8)
        Me.Button_cerrar.Name = "Button_cerrar"
        Me.Button_cerrar.Size = New System.Drawing.Size(30, 30)
        Me.Button_cerrar.TabIndex = 1
        Me.Button_cerrar.UseVisualStyleBackColor = False
        '
        'Label23
        '
        Me.Label23.AllowDrop = True
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(52, 14)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(309, 23)
        Me.Label23.TabIndex = 907
        Me.Label23.Text = "Actualizar Información de la Nube"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button_down
        '
        Me.Button_down.BackColor = System.Drawing.Color.Transparent
        Me.Button_down.BackgroundImage = CType(resources.GetObject("Button_down.BackgroundImage"), System.Drawing.Image)
        Me.Button_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_down.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button_down.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button_down.FlatAppearance.BorderSize = 0
        Me.Button_down.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_down.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.Button_down.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_down.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button_down.ForeColor = System.Drawing.Color.White
        Me.Button_down.Image = Global.MiClickDerecho.My.Resources.Resources.clo1
        Me.Button_down.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_down.Location = New System.Drawing.Point(845, 72)
        Me.Button_down.Name = "Button_down"
        Me.Button_down.Size = New System.Drawing.Size(148, 62)
        Me.Button_down.TabIndex = 903
        Me.Button_down.Text = "Descargar de Mi Nube"
        Me.Button_down.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_down.UseVisualStyleBackColor = False
        '
        'Button_up
        '
        Me.Button_up.BackColor = System.Drawing.Color.Transparent
        Me.Button_up.BackgroundImage = CType(resources.GetObject("Button_up.BackgroundImage"), System.Drawing.Image)
        Me.Button_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_up.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button_up.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_up.FlatAppearance.BorderSize = 0
        Me.Button_up.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button_up.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.Button_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_up.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button_up.ForeColor = System.Drawing.Color.White
        Me.Button_up.Image = Global.MiClickDerecho.My.Resources.Resources.clo2
        Me.Button_up.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_up.Location = New System.Drawing.Point(697, 72)
        Me.Button_up.Name = "Button_up"
        Me.Button_up.Size = New System.Drawing.Size(142, 62)
        Me.Button_up.TabIndex = 905
        Me.Button_up.Text = "Guardar en Mi Nube"
        Me.Button_up.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_up.UseVisualStyleBackColor = False
        '
        'Form_cloudconfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 674)
        Me.Controls.Add(Me.Panel_titlebar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button_down)
        Me.Controls.Add(Me.Button_up)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.datagrid_local)
        Me.Controls.Add(Me.datagrid_remoto)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form_cloudconfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualización de la Nube"
        CType(Me.datagrid_local, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.datagrid_remoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_titlebar.ResumeLayout(False)
        Me.Panel_titlebar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents datagrid_local As MetroFramework.Controls.MetroGrid
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents ComboBox_DESTINO As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents datagrid_remoto As MetroFramework.Controls.MetroGrid
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents Panel_titlebar As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button_cerrar As Button
    Friend WithEvents BunifuElipse2 As ns1.BunifuElipse
    Friend WithEvents BunifuElipse3 As ns1.BunifuElipse
    Friend WithEvents Button_down As Button
    Friend WithEvents Button_up As Button
    Friend WithEvents Label3 As Label
End Class
