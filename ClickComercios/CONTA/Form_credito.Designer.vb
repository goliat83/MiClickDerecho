<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_credito
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_credito))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TextBox_dv = New System.Windows.Forms.TextBox()
        Me.Label_info_cliente = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button_REFRESH_cliente = New System.Windows.Forms.Button()
        Me.Button_NUEVO_CLI = New System.Windows.Forms.Button()
        Me.Button_EDIT_CLI = New System.Windows.Forms.Button()
        Me.Button_SAVE_CLI = New System.Windows.Forms.Button()
        Me.Label_panel_total_cartera = New System.Windows.Forms.Label()
        Me.Label_tiitulo_cartera = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.TXT_NOM_CLIENTE = New System.Windows.Forms.TextBox()
        Me.TXT_DOC_CLIENTE = New System.Windows.Forms.TextBox()
        Me.COMBO_DOC_CLIENTE_FILTRO = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.COMBO_NOM_CLIENTE_FILTRO = New System.Windows.Forms.ComboBox()
        Me.TXT_DIR_CLIENTE = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TxtMAIL_cliente = New System.Windows.Forms.TextBox()
        Me.Label_TOTAL_creditos = New System.Windows.Forms.Label()
        Me.DateTimePicker_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel_total_cartera = New System.Windows.Forms.Panel()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Timer_PROVEEDORES = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_clientes = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_tipo_cajabanco = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_TERCERO = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuElipse8 = New ns1.BunifuElipse(Me.components)
        Me.BunifuElipse7 = New ns1.BunifuElipse(Me.components)
        Me.BunifuElipse6 = New ns1.BunifuElipse(Me.components)
        Me.BunifuElipse5 = New ns1.BunifuElipse(Me.components)
        Me.BunifuElipse4 = New ns1.BunifuElipse(Me.components)
        Me.dataGrid_credito = New MetroFramework.Controls.MetroGrid()
        Me.BunifuElipse3 = New ns1.BunifuElipse(Me.components)
        Me.BunifuElipse2 = New ns1.BunifuElipse(Me.components)
        Me.TextBox_valor_cuenta = New System.Windows.Forms.TextBox()
        Me.Timer_tipomov = New System.Windows.Forms.Timer(Me.components)
        Me.Button_regresar_credito = New System.Windows.Forms.Button()
        Me.Button_exportar_credito = New System.Windows.Forms.Button()
        Me.Button_contabilizar_credito = New System.Windows.Forms.Button()
        Me.Button_guardar_credito = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel_bonotes2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button_anular = New System.Windows.Forms.Button()
        Me.Btn_nuevo_cartera = New System.Windows.Forms.Button()
        Me.Button_ver_credito = New System.Windows.Forms.Button()
        Me.Button_exportar = New System.Windows.Forms.Button()
        Me.Panel_botones = New System.Windows.Forms.Panel()
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TXT_TELS_CLIENTE = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TextBox_saldo = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.datagrid_historial_credito = New MetroFramework.Controls.MetroGrid()
        Me.Button_ver_buscar_fac_credito = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_abonos = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button_buscar = New System.Windows.Forms.Button()
        Me.TextBox_buscar_prov = New System.Windows.Forms.TextBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox_tipo_CuentaxPagar = New System.Windows.Forms.ComboBox()
        Me.TextBox_concepto = New System.Windows.Forms.TextBox()
        Me.TextBox_nro_cuenta = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBox_nro_fac_credito = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox_vencimiento = New System.Windows.Forms.TextBox()
        Me.DateTimePicker_vence = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BunifuCards_clientes = New ns1.BunifuCards()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TextBox_estado = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label_empleado = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.TextBox_fecha = New System.Windows.Forms.TextBox()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.DataGrid_export = New MetroFramework.Controls.MetroGrid()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuElipse9 = New ns1.BunifuElipse(Me.components)
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel_total_cartera.SuspendLayout()
        CType(Me.dataGrid_credito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_bonotes2.SuspendLayout()
        Me.Panel_botones.SuspendLayout()
        CType(Me.datagrid_historial_credito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.BunifuCards_clientes.SuspendLayout()
        Me.Panel22.SuspendLayout()
        Me.MetroTabControl1.SuspendLayout()
        CType(Me.DataGrid_export, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox_dv
        '
        Me.TextBox_dv.BackColor = System.Drawing.Color.White
        Me.TextBox_dv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_dv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_dv.ForeColor = System.Drawing.Color.Black
        Me.TextBox_dv.Location = New System.Drawing.Point(136, 44)
        Me.TextBox_dv.Name = "TextBox_dv"
        Me.TextBox_dv.Size = New System.Drawing.Size(26, 15)
        Me.TextBox_dv.TabIndex = 604
        '
        'Label_info_cliente
        '
        Me.Label_info_cliente.AllowDrop = True
        Me.Label_info_cliente.BackColor = System.Drawing.Color.Transparent
        Me.Label_info_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Label_info_cliente.ForeColor = System.Drawing.Color.Red
        Me.Label_info_cliente.Location = New System.Drawing.Point(283, 100)
        Me.Label_info_cliente.Name = "Label_info_cliente"
        Me.Label_info_cliente.Size = New System.Drawing.Size(192, 35)
        Me.Label_info_cliente.TabIndex = 603
        Me.Label_info_cliente.Text = "Registre los Datos del Cliente"
        Me.Label_info_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label_info_cliente.Visible = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Button_REFRESH_cliente)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button_NUEVO_CLI)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button_EDIT_CLI)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button_SAVE_CLI)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(491, 5)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(36, 134)
        Me.FlowLayoutPanel1.TabIndex = 603
        '
        'Button_REFRESH_cliente
        '
        Me.Button_REFRESH_cliente.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button_REFRESH_cliente.BackColor = System.Drawing.Color.Transparent
        Me.Button_REFRESH_cliente.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.refresh
        Me.Button_REFRESH_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_REFRESH_cliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_REFRESH_cliente.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.Button_REFRESH_cliente.FlatAppearance.BorderSize = 0
        Me.Button_REFRESH_cliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_REFRESH_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_REFRESH_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_REFRESH_cliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_REFRESH_cliente.ForeColor = System.Drawing.Color.White
        Me.Button_REFRESH_cliente.Location = New System.Drawing.Point(3, 3)
        Me.Button_REFRESH_cliente.Name = "Button_REFRESH_cliente"
        Me.Button_REFRESH_cliente.Size = New System.Drawing.Size(30, 28)
        Me.Button_REFRESH_cliente.TabIndex = 751
        Me.Button_REFRESH_cliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_REFRESH_cliente.UseVisualStyleBackColor = False
        '
        'Button_NUEVO_CLI
        '
        Me.Button_NUEVO_CLI.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button_NUEVO_CLI.BackColor = System.Drawing.Color.Transparent
        Me.Button_NUEVO_CLI.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.agregar
        Me.Button_NUEVO_CLI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_NUEVO_CLI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_NUEVO_CLI.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.Button_NUEVO_CLI.FlatAppearance.BorderSize = 0
        Me.Button_NUEVO_CLI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_NUEVO_CLI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_NUEVO_CLI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_NUEVO_CLI.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_NUEVO_CLI.ForeColor = System.Drawing.Color.White
        Me.Button_NUEVO_CLI.Location = New System.Drawing.Point(3, 37)
        Me.Button_NUEVO_CLI.Name = "Button_NUEVO_CLI"
        Me.Button_NUEVO_CLI.Size = New System.Drawing.Size(30, 28)
        Me.Button_NUEVO_CLI.TabIndex = 754
        Me.Button_NUEVO_CLI.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_NUEVO_CLI.UseVisualStyleBackColor = False
        '
        'Button_EDIT_CLI
        '
        Me.Button_EDIT_CLI.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button_EDIT_CLI.BackColor = System.Drawing.Color.Transparent
        Me.Button_EDIT_CLI.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.lapizico
        Me.Button_EDIT_CLI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_EDIT_CLI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_EDIT_CLI.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.Button_EDIT_CLI.FlatAppearance.BorderSize = 0
        Me.Button_EDIT_CLI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_EDIT_CLI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_EDIT_CLI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_EDIT_CLI.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_EDIT_CLI.ForeColor = System.Drawing.Color.White
        Me.Button_EDIT_CLI.Location = New System.Drawing.Point(3, 71)
        Me.Button_EDIT_CLI.Name = "Button_EDIT_CLI"
        Me.Button_EDIT_CLI.Size = New System.Drawing.Size(30, 28)
        Me.Button_EDIT_CLI.TabIndex = 755
        Me.Button_EDIT_CLI.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_EDIT_CLI.UseVisualStyleBackColor = False
        Me.Button_EDIT_CLI.Visible = False
        '
        'Button_SAVE_CLI
        '
        Me.Button_SAVE_CLI.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button_SAVE_CLI.BackColor = System.Drawing.Color.Transparent
        Me.Button_SAVE_CLI.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.guardar
        Me.Button_SAVE_CLI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_SAVE_CLI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_SAVE_CLI.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.Button_SAVE_CLI.FlatAppearance.BorderSize = 0
        Me.Button_SAVE_CLI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_SAVE_CLI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_SAVE_CLI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_SAVE_CLI.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_SAVE_CLI.ForeColor = System.Drawing.Color.White
        Me.Button_SAVE_CLI.Location = New System.Drawing.Point(3, 105)
        Me.Button_SAVE_CLI.Name = "Button_SAVE_CLI"
        Me.Button_SAVE_CLI.Size = New System.Drawing.Size(30, 28)
        Me.Button_SAVE_CLI.TabIndex = 756
        Me.Button_SAVE_CLI.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_SAVE_CLI.UseVisualStyleBackColor = False
        Me.Button_SAVE_CLI.Visible = False
        '
        'Label_panel_total_cartera
        '
        Me.Label_panel_total_cartera.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_panel_total_cartera.AutoSize = True
        Me.Label_panel_total_cartera.BackColor = System.Drawing.Color.Transparent
        Me.Label_panel_total_cartera.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_panel_total_cartera.ForeColor = System.Drawing.Color.Black
        Me.Label_panel_total_cartera.Location = New System.Drawing.Point(600, 451)
        Me.Label_panel_total_cartera.Name = "Label_panel_total_cartera"
        Me.Label_panel_total_cartera.Size = New System.Drawing.Size(44, 16)
        Me.Label_panel_total_cartera.TabIndex = 554
        Me.Label_panel_total_cartera.Text = "Total"
        '
        'Label_tiitulo_cartera
        '
        Me.Label_tiitulo_cartera.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_tiitulo_cartera.AutoSize = True
        Me.Label_tiitulo_cartera.BackColor = System.Drawing.Color.Transparent
        Me.Label_tiitulo_cartera.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_tiitulo_cartera.ForeColor = System.Drawing.Color.Black
        Me.Label_tiitulo_cartera.Location = New System.Drawing.Point(16, 19)
        Me.Label_tiitulo_cartera.Name = "Label_tiitulo_cartera"
        Me.Label_tiitulo_cartera.Size = New System.Drawing.Size(209, 25)
        Me.Label_tiitulo_cartera.TabIndex = 650
        Me.Label_tiitulo_cartera.Text = "Cuentas por Pagar"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(3, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 31)
        Me.Label3.TabIndex = 545
        Me.Label3.Text = "$"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label45
        '
        Me.Label45.AllowDrop = True
        Me.Label45.AutoSize = True
        Me.Label45.BackColor = System.Drawing.Color.Transparent
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Gray
        Me.Label45.Location = New System.Drawing.Point(139, 32)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(21, 12)
        Me.Label45.TabIndex = 605
        Me.Label45.Text = "DV"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXT_NOM_CLIENTE
        '
        Me.TXT_NOM_CLIENTE.BackColor = System.Drawing.Color.White
        Me.TXT_NOM_CLIENTE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_NOM_CLIENTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NOM_CLIENTE.ForeColor = System.Drawing.Color.Black
        Me.TXT_NOM_CLIENTE.Location = New System.Drawing.Point(168, 44)
        Me.TXT_NOM_CLIENTE.Name = "TXT_NOM_CLIENTE"
        Me.TXT_NOM_CLIENTE.Size = New System.Drawing.Size(307, 15)
        Me.TXT_NOM_CLIENTE.TabIndex = 4
        '
        'TXT_DOC_CLIENTE
        '
        Me.TXT_DOC_CLIENTE.BackColor = System.Drawing.Color.White
        Me.TXT_DOC_CLIENTE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_DOC_CLIENTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_DOC_CLIENTE.ForeColor = System.Drawing.Color.Black
        Me.TXT_DOC_CLIENTE.Location = New System.Drawing.Point(12, 44)
        Me.TXT_DOC_CLIENTE.Name = "TXT_DOC_CLIENTE"
        Me.TXT_DOC_CLIENTE.Size = New System.Drawing.Size(118, 15)
        Me.TXT_DOC_CLIENTE.TabIndex = 3
        '
        'COMBO_DOC_CLIENTE_FILTRO
        '
        Me.COMBO_DOC_CLIENTE_FILTRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.COMBO_DOC_CLIENTE_FILTRO.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.COMBO_DOC_CLIENTE_FILTRO.FormattingEnabled = True
        Me.COMBO_DOC_CLIENTE_FILTRO.Location = New System.Drawing.Point(100, 7)
        Me.COMBO_DOC_CLIENTE_FILTRO.Name = "COMBO_DOC_CLIENTE_FILTRO"
        Me.COMBO_DOC_CLIENTE_FILTRO.Size = New System.Drawing.Size(143, 21)
        Me.COMBO_DOC_CLIENTE_FILTRO.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AllowDrop = True
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(6, 6)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 22)
        Me.Label14.TabIndex = 540
        Me.Label14.Text = "Proveedor"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'COMBO_NOM_CLIENTE_FILTRO
        '
        Me.COMBO_NOM_CLIENTE_FILTRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.COMBO_NOM_CLIENTE_FILTRO.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.COMBO_NOM_CLIENTE_FILTRO.FormattingEnabled = True
        Me.COMBO_NOM_CLIENTE_FILTRO.Location = New System.Drawing.Point(251, 7)
        Me.COMBO_NOM_CLIENTE_FILTRO.Name = "COMBO_NOM_CLIENTE_FILTRO"
        Me.COMBO_NOM_CLIENTE_FILTRO.Size = New System.Drawing.Size(224, 21)
        Me.COMBO_NOM_CLIENTE_FILTRO.TabIndex = 2
        '
        'TXT_DIR_CLIENTE
        '
        Me.TXT_DIR_CLIENTE.BackColor = System.Drawing.Color.White
        Me.TXT_DIR_CLIENTE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_DIR_CLIENTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_DIR_CLIENTE.ForeColor = System.Drawing.Color.Black
        Me.TXT_DIR_CLIENTE.Location = New System.Drawing.Point(181, 79)
        Me.TXT_DIR_CLIENTE.Name = "TXT_DIR_CLIENTE"
        Me.TXT_DIR_CLIENTE.Size = New System.Drawing.Size(294, 15)
        Me.TXT_DIR_CLIENTE.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AllowDrop = True
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Gray
        Me.Label11.Location = New System.Drawing.Point(167, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 12)
        Me.Label11.TabIndex = 539
        Me.Label11.Text = "Nombre/Razon Social"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AllowDrop = True
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Gray
        Me.Label13.Location = New System.Drawing.Point(8, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 12)
        Me.Label13.TabIndex = 537
        Me.Label13.Text = "Documento/NIT"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.AllowDrop = True
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Gray
        Me.Label27.Location = New System.Drawing.Point(181, 66)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(53, 12)
        Me.Label27.TabIndex = 579
        Me.Label27.Text = "Dirección"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtMAIL_cliente
        '
        Me.TxtMAIL_cliente.BackColor = System.Drawing.Color.White
        Me.TxtMAIL_cliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtMAIL_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMAIL_cliente.ForeColor = System.Drawing.Color.Black
        Me.TxtMAIL_cliente.Location = New System.Drawing.Point(11, 116)
        Me.TxtMAIL_cliente.Name = "TxtMAIL_cliente"
        Me.TxtMAIL_cliente.Size = New System.Drawing.Size(270, 15)
        Me.TxtMAIL_cliente.TabIndex = 7
        '
        'Label_TOTAL_creditos
        '
        Me.Label_TOTAL_creditos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_TOTAL_creditos.BackColor = System.Drawing.Color.Transparent
        Me.Label_TOTAL_creditos.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TOTAL_creditos.ForeColor = System.Drawing.Color.Black
        Me.Label_TOTAL_creditos.Location = New System.Drawing.Point(25, 6)
        Me.Label_TOTAL_creditos.Name = "Label_TOTAL_creditos"
        Me.Label_TOTAL_creditos.Size = New System.Drawing.Size(225, 32)
        Me.Label_TOTAL_creditos.TabIndex = 408
        Me.Label_TOTAL_creditos.Text = "0"
        Me.Label_TOTAL_creditos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePicker_fecha
        '
        Me.DateTimePicker_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.DateTimePicker_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_fecha.Location = New System.Drawing.Point(586, 159)
        Me.DateTimePicker_fecha.Name = "DateTimePicker_fecha"
        Me.DateTimePicker_fecha.Size = New System.Drawing.Size(143, 24)
        Me.DateTimePicker_fecha.TabIndex = 671
        '
        'Label37
        '
        Me.Label37.AllowDrop = True
        Me.Label37.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(584, 334)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(105, 19)
        Me.Label37.TabIndex = 663
        Me.Label37.Text = "Total Cuenta"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(586, 145)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 666
        Me.Label10.Text = "Fecha"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel_total_cartera
        '
        Me.Panel_total_cartera.BackColor = System.Drawing.Color.Transparent
        Me.Panel_total_cartera.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.banner_box3
        Me.Panel_total_cartera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_total_cartera.Controls.Add(Me.Label_TOTAL_creditos)
        Me.Panel_total_cartera.Controls.Add(Me.Label3)
        Me.Panel_total_cartera.Location = New System.Drawing.Point(648, 437)
        Me.Panel_total_cartera.Name = "Panel_total_cartera"
        Me.Panel_total_cartera.Size = New System.Drawing.Size(255, 44)
        Me.Panel_total_cartera.TabIndex = 555
        '
        'Label31
        '
        Me.Label31.AllowDrop = True
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Gray
        Me.Label31.Location = New System.Drawing.Point(8, 99)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(33, 12)
        Me.Label31.TabIndex = 581
        Me.Label31.Text = "Email"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label36
        '
        Me.Label36.AllowDrop = True
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Black
        Me.Label36.Location = New System.Drawing.Point(-2, -15)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(56, 15)
        Me.Label36.TabIndex = 449
        Me.Label36.Text = "Destino"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer_PROVEEDORES
        '
        Me.Timer_PROVEEDORES.Interval = 300
        '
        'Timer_clientes
        '
        Me.Timer_clientes.Interval = 300
        '
        'Timer_tipo_cajabanco
        '
        Me.Timer_tipo_cajabanco.Interval = 300
        '
        'Timer1
        '
        Me.Timer1.Interval = 400
        '
        'Timer_TERCERO
        '
        Me.Timer_TERCERO.Interval = 300
        '
        'BunifuElipse8
        '
        Me.BunifuElipse8.ElipseRadius = 5
        Me.BunifuElipse8.TargetControl = Me
        '
        'BunifuElipse7
        '
        Me.BunifuElipse7.ElipseRadius = 5
        Me.BunifuElipse7.TargetControl = Me
        '
        'BunifuElipse6
        '
        Me.BunifuElipse6.ElipseRadius = 5
        Me.BunifuElipse6.TargetControl = Me
        '
        'BunifuElipse5
        '
        Me.BunifuElipse5.ElipseRadius = 5
        Me.BunifuElipse5.TargetControl = Me
        '
        'BunifuElipse4
        '
        Me.BunifuElipse4.ElipseRadius = 5
        Me.BunifuElipse4.TargetControl = Me.dataGrid_credito
        '
        'dataGrid_credito
        '
        Me.dataGrid_credito.AllowUserToAddRows = False
        Me.dataGrid_credito.AllowUserToDeleteRows = False
        Me.dataGrid_credito.AllowUserToResizeRows = False
        Me.dataGrid_credito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataGrid_credito.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dataGrid_credito.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataGrid_credito.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dataGrid_credito.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGrid_credito.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dataGrid_credito.ColumnHeadersHeight = 28
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGrid_credito.DefaultCellStyle = DataGridViewCellStyle5
        Me.dataGrid_credito.EnableHeadersVisualStyles = False
        Me.dataGrid_credito.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dataGrid_credito.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataGrid_credito.Location = New System.Drawing.Point(12, 99)
        Me.dataGrid_credito.Name = "dataGrid_credito"
        Me.dataGrid_credito.ReadOnly = True
        Me.dataGrid_credito.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGrid_credito.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dataGrid_credito.RowHeadersVisible = False
        Me.dataGrid_credito.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dataGrid_credito.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue
        Me.dataGrid_credito.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dataGrid_credito.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dataGrid_credito.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dataGrid_credito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGrid_credito.Size = New System.Drawing.Size(888, 332)
        Me.dataGrid_credito.TabIndex = 585
        '
        'BunifuElipse3
        '
        Me.BunifuElipse3.ElipseRadius = 5
        Me.BunifuElipse3.TargetControl = Me
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 5
        Me.BunifuElipse2.TargetControl = Me
        '
        'TextBox_valor_cuenta
        '
        Me.TextBox_valor_cuenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_valor_cuenta.BackColor = System.Drawing.Color.White
        Me.TextBox_valor_cuenta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_valor_cuenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBox_valor_cuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_valor_cuenta.ForeColor = System.Drawing.Color.Lime
        Me.TextBox_valor_cuenta.Location = New System.Drawing.Point(3, 6)
        Me.TextBox_valor_cuenta.Name = "TextBox_valor_cuenta"
        Me.TextBox_valor_cuenta.Size = New System.Drawing.Size(176, 22)
        Me.TextBox_valor_cuenta.TabIndex = 523
        Me.TextBox_valor_cuenta.Text = "0"
        Me.TextBox_valor_cuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer_tipomov
        '
        Me.Timer_tipomov.Interval = 300
        '
        'Button_regresar_credito
        '
        Me.Button_regresar_credito.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_regresar_credito.BackColor = System.Drawing.Color.Transparent
        Me.Button_regresar_credito.BackgroundImage = CType(resources.GetObject("Button_regresar_credito.BackgroundImage"), System.Drawing.Image)
        Me.Button_regresar_credito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_regresar_credito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_regresar_credito.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_regresar_credito.FlatAppearance.BorderSize = 0
        Me.Button_regresar_credito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button_regresar_credito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.Button_regresar_credito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_regresar_credito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_regresar_credito.ForeColor = System.Drawing.Color.White
        Me.Button_regresar_credito.Image = Global.MiClickDerecho.My.Resources.Resources.back
        Me.Button_regresar_credito.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_regresar_credito.Location = New System.Drawing.Point(405, 3)
        Me.Button_regresar_credito.Name = "Button_regresar_credito"
        Me.Button_regresar_credito.Size = New System.Drawing.Size(87, 50)
        Me.Button_regresar_credito.TabIndex = 753
        Me.Button_regresar_credito.Text = "Regresar"
        Me.Button_regresar_credito.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_regresar_credito.UseVisualStyleBackColor = False
        '
        'Button_exportar_credito
        '
        Me.Button_exportar_credito.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_exportar_credito.BackColor = System.Drawing.Color.Transparent
        Me.Button_exportar_credito.BackgroundImage = CType(resources.GetObject("Button_exportar_credito.BackgroundImage"), System.Drawing.Image)
        Me.Button_exportar_credito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_exportar_credito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_exportar_credito.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_exportar_credito.FlatAppearance.BorderSize = 0
        Me.Button_exportar_credito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button_exportar_credito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.Button_exportar_credito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_exportar_credito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button_exportar_credito.ForeColor = System.Drawing.Color.White
        Me.Button_exportar_credito.Image = Global.MiClickDerecho.My.Resources.Resources.pdficon2
        Me.Button_exportar_credito.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_exportar_credito.Location = New System.Drawing.Point(329, 3)
        Me.Button_exportar_credito.Name = "Button_exportar_credito"
        Me.Button_exportar_credito.Size = New System.Drawing.Size(70, 50)
        Me.Button_exportar_credito.TabIndex = 752
        Me.Button_exportar_credito.Text = "Exportar"
        Me.Button_exportar_credito.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_exportar_credito.UseVisualStyleBackColor = False
        '
        'Button_contabilizar_credito
        '
        Me.Button_contabilizar_credito.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_contabilizar_credito.BackColor = System.Drawing.Color.Transparent
        Me.Button_contabilizar_credito.BackgroundImage = CType(resources.GetObject("Button_contabilizar_credito.BackgroundImage"), System.Drawing.Image)
        Me.Button_contabilizar_credito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_contabilizar_credito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_contabilizar_credito.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_contabilizar_credito.FlatAppearance.BorderSize = 0
        Me.Button_contabilizar_credito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button_contabilizar_credito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.Button_contabilizar_credito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_contabilizar_credito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button_contabilizar_credito.ForeColor = System.Drawing.Color.White
        Me.Button_contabilizar_credito.Image = Global.MiClickDerecho.My.Resources.Resources.accountericon
        Me.Button_contabilizar_credito.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_contabilizar_credito.Location = New System.Drawing.Point(236, 3)
        Me.Button_contabilizar_credito.Name = "Button_contabilizar_credito"
        Me.Button_contabilizar_credito.Size = New System.Drawing.Size(87, 50)
        Me.Button_contabilizar_credito.TabIndex = 755
        Me.Button_contabilizar_credito.Text = "Contabilizar"
        Me.Button_contabilizar_credito.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_contabilizar_credito.UseVisualStyleBackColor = False
        '
        'Button_guardar_credito
        '
        Me.Button_guardar_credito.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_guardar_credito.BackColor = System.Drawing.Color.Transparent
        Me.Button_guardar_credito.BackgroundImage = CType(resources.GetObject("Button_guardar_credito.BackgroundImage"), System.Drawing.Image)
        Me.Button_guardar_credito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_guardar_credito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_guardar_credito.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_guardar_credito.FlatAppearance.BorderSize = 0
        Me.Button_guardar_credito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button_guardar_credito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.Button_guardar_credito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_guardar_credito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button_guardar_credito.ForeColor = System.Drawing.Color.White
        Me.Button_guardar_credito.Image = Global.MiClickDerecho.My.Resources.Resources.save_icon_5427
        Me.Button_guardar_credito.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_guardar_credito.Location = New System.Drawing.Point(143, 3)
        Me.Button_guardar_credito.Name = "Button_guardar_credito"
        Me.Button_guardar_credito.Size = New System.Drawing.Size(87, 50)
        Me.Button_guardar_credito.TabIndex = 756
        Me.Button_guardar_credito.Text = "Guardar"
        Me.Button_guardar_credito.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_guardar_credito.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label15.Location = New System.Drawing.Point(16, 75)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(448, 25)
        Me.Label15.TabIndex = 723
        Me.Label15.Text = "Registre los datos de la cuenta por pagar"
        Me.Label15.Visible = False
        '
        'Panel_bonotes2
        '
        Me.Panel_bonotes2.Controls.Add(Me.Button_regresar_credito)
        Me.Panel_bonotes2.Controls.Add(Me.Button_exportar_credito)
        Me.Panel_bonotes2.Controls.Add(Me.Button_contabilizar_credito)
        Me.Panel_bonotes2.Controls.Add(Me.Button_guardar_credito)
        Me.Panel_bonotes2.Controls.Add(Me.Button_anular)
        Me.Panel_bonotes2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.Panel_bonotes2.Location = New System.Drawing.Point(401, 12)
        Me.Panel_bonotes2.Name = "Panel_bonotes2"
        Me.Panel_bonotes2.Size = New System.Drawing.Size(495, 52)
        Me.Panel_bonotes2.TabIndex = 724
        Me.Panel_bonotes2.Visible = False
        '
        'Button_anular
        '
        Me.Button_anular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_anular.BackColor = System.Drawing.Color.Transparent
        Me.Button_anular.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.BUTTTON1
        Me.Button_anular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_anular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_anular.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_anular.FlatAppearance.BorderSize = 0
        Me.Button_anular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button_anular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.Button_anular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_anular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button_anular.ForeColor = System.Drawing.Color.White
        Me.Button_anular.Image = Global.MiClickDerecho.My.Resources.Resources.delete_256
        Me.Button_anular.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_anular.Location = New System.Drawing.Point(50, 3)
        Me.Button_anular.Name = "Button_anular"
        Me.Button_anular.Size = New System.Drawing.Size(87, 50)
        Me.Button_anular.TabIndex = 758
        Me.Button_anular.Text = "Anular"
        Me.Button_anular.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_anular.UseVisualStyleBackColor = False
        '
        'Btn_nuevo_cartera
        '
        Me.Btn_nuevo_cartera.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_nuevo_cartera.BackColor = System.Drawing.Color.Transparent
        Me.Btn_nuevo_cartera.BackgroundImage = CType(resources.GetObject("Btn_nuevo_cartera.BackgroundImage"), System.Drawing.Image)
        Me.Btn_nuevo_cartera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_nuevo_cartera.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_nuevo_cartera.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Btn_nuevo_cartera.FlatAppearance.BorderSize = 0
        Me.Btn_nuevo_cartera.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_nuevo_cartera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btn_nuevo_cartera.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_nuevo_cartera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Btn_nuevo_cartera.ForeColor = System.Drawing.Color.Black
        Me.Btn_nuevo_cartera.Image = Global.MiClickDerecho.My.Resources.Resources.agregar
        Me.Btn_nuevo_cartera.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_nuevo_cartera.Location = New System.Drawing.Point(7, 4)
        Me.Btn_nuevo_cartera.Name = "Btn_nuevo_cartera"
        Me.Btn_nuevo_cartera.Size = New System.Drawing.Size(123, 44)
        Me.Btn_nuevo_cartera.TabIndex = 651
        Me.Btn_nuevo_cartera.Text = "Crear Cuenta"
        Me.Btn_nuevo_cartera.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_nuevo_cartera.UseVisualStyleBackColor = False
        Me.Btn_nuevo_cartera.Visible = False
        '
        'Button_ver_credito
        '
        Me.Button_ver_credito.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_ver_credito.BackColor = System.Drawing.Color.Transparent
        Me.Button_ver_credito.BackgroundImage = CType(resources.GetObject("Button_ver_credito.BackgroundImage"), System.Drawing.Image)
        Me.Button_ver_credito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_ver_credito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_ver_credito.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button_ver_credito.FlatAppearance.BorderSize = 0
        Me.Button_ver_credito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_ver_credito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_ver_credito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_ver_credito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Button_ver_credito.ForeColor = System.Drawing.Color.Black
        Me.Button_ver_credito.Image = Global.MiClickDerecho.My.Resources.Resources.viewicone
        Me.Button_ver_credito.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_ver_credito.Location = New System.Drawing.Point(136, 4)
        Me.Button_ver_credito.Name = "Button_ver_credito"
        Me.Button_ver_credito.Size = New System.Drawing.Size(123, 44)
        Me.Button_ver_credito.TabIndex = 652
        Me.Button_ver_credito.Text = "Ver Cuenta"
        Me.Button_ver_credito.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_ver_credito.UseVisualStyleBackColor = False
        '
        'Button_exportar
        '
        Me.Button_exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_exportar.BackColor = System.Drawing.Color.Transparent
        Me.Button_exportar.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.botonamarillo
        Me.Button_exportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_exportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_exportar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_exportar.FlatAppearance.BorderSize = 0
        Me.Button_exportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_exportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_exportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_exportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_exportar.ForeColor = System.Drawing.Color.Black
        Me.Button_exportar.Image = Global.MiClickDerecho.My.Resources.Resources.download2
        Me.Button_exportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_exportar.Location = New System.Drawing.Point(265, 4)
        Me.Button_exportar.Name = "Button_exportar"
        Me.Button_exportar.Size = New System.Drawing.Size(106, 44)
        Me.Button_exportar.TabIndex = 625
        Me.Button_exportar.Text = "Exportar"
        Me.Button_exportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_exportar.UseVisualStyleBackColor = False
        '
        'Panel_botones
        '
        Me.Panel_botones.Controls.Add(Me.Btn_nuevo_cartera)
        Me.Panel_botones.Controls.Add(Me.Button_ver_credito)
        Me.Panel_botones.Controls.Add(Me.Button_exportar)
        Me.Panel_botones.Location = New System.Drawing.Point(519, 45)
        Me.Panel_botones.Name = "Panel_botones"
        Me.Panel_botones.Size = New System.Drawing.Size(381, 51)
        Me.Panel_botones.TabIndex = 694
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Label30
        '
        Me.Label30.AllowDrop = True
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Gray
        Me.Label30.Location = New System.Drawing.Point(32, 254)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(43, 12)
        Me.Label30.TabIndex = 693
        Me.Label30.Text = "Abonos"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXT_TELS_CLIENTE
        '
        Me.TXT_TELS_CLIENTE.BackColor = System.Drawing.Color.White
        Me.TXT_TELS_CLIENTE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_TELS_CLIENTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_TELS_CLIENTE.ForeColor = System.Drawing.Color.Black
        Me.TXT_TELS_CLIENTE.Location = New System.Drawing.Point(11, 79)
        Me.TXT_TELS_CLIENTE.Name = "TXT_TELS_CLIENTE"
        Me.TXT_TELS_CLIENTE.Size = New System.Drawing.Size(165, 15)
        Me.TXT_TELS_CLIENTE.TabIndex = 5
        '
        'Label26
        '
        Me.Label26.AllowDrop = True
        Me.Label26.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(584, 402)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(53, 19)
        Me.Label26.TabIndex = 665
        Me.Label26.Text = "Saldo"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.AllowDrop = True
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Gray
        Me.Label24.Location = New System.Drawing.Point(577, 264)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(53, 12)
        Me.Label24.TabIndex = 685
        Me.Label24.Text = "Concepto"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.AllowDrop = True
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(-2, -15)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(56, 15)
        Me.Label25.TabIndex = 449
        Me.Label25.Text = "Destino"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox_saldo
        '
        Me.TextBox_saldo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_saldo.BackColor = System.Drawing.Color.White
        Me.TextBox_saldo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_saldo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBox_saldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_saldo.ForeColor = System.Drawing.Color.Lime
        Me.TextBox_saldo.Location = New System.Drawing.Point(3, 6)
        Me.TextBox_saldo.Name = "TextBox_saldo"
        Me.TextBox_saldo.Size = New System.Drawing.Size(176, 22)
        Me.TextBox_saldo.TabIndex = 523
        Me.TextBox_saldo.Text = "0"
        Me.TextBox_saldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AllowDrop = True
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(584, 368)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 19)
        Me.Label16.TabIndex = 665
        Me.Label16.Text = "Abonos"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'datagrid_historial_credito
        '
        Me.datagrid_historial_credito.AllowUserToAddRows = False
        Me.datagrid_historial_credito.AllowUserToDeleteRows = False
        Me.datagrid_historial_credito.AllowUserToResizeRows = False
        Me.datagrid_historial_credito.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datagrid_historial_credito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagrid_historial_credito.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.datagrid_historial_credito.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datagrid_historial_credito.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.datagrid_historial_credito.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_historial_credito.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datagrid_historial_credito.ColumnHeadersHeight = 25
        Me.datagrid_historial_credito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid_historial_credito.DefaultCellStyle = DataGridViewCellStyle2
        Me.datagrid_historial_credito.EnableHeadersVisualStyles = False
        Me.datagrid_historial_credito.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.datagrid_historial_credito.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid_historial_credito.Location = New System.Drawing.Point(28, 269)
        Me.datagrid_historial_credito.Name = "datagrid_historial_credito"
        Me.datagrid_historial_credito.ReadOnly = True
        Me.datagrid_historial_credito.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_historial_credito.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.datagrid_historial_credito.RowHeadersVisible = False
        Me.datagrid_historial_credito.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagrid_historial_credito.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue
        Me.datagrid_historial_credito.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold)
        Me.datagrid_historial_credito.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.datagrid_historial_credito.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.datagrid_historial_credito.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.datagrid_historial_credito.RowTemplate.Height = 20
        Me.datagrid_historial_credito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrid_historial_credito.Size = New System.Drawing.Size(524, 123)
        Me.datagrid_historial_credito.TabIndex = 692
        '
        'Button_ver_buscar_fac_credito
        '
        Me.Button_ver_buscar_fac_credito.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_ver_buscar_fac_credito.BackColor = System.Drawing.Color.Transparent
        Me.Button_ver_buscar_fac_credito.BackgroundImage = CType(resources.GetObject("Button_ver_buscar_fac_credito.BackgroundImage"), System.Drawing.Image)
        Me.Button_ver_buscar_fac_credito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_ver_buscar_fac_credito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_ver_buscar_fac_credito.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button_ver_buscar_fac_credito.FlatAppearance.BorderSize = 0
        Me.Button_ver_buscar_fac_credito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_ver_buscar_fac_credito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_ver_buscar_fac_credito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_ver_buscar_fac_credito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Button_ver_buscar_fac_credito.ForeColor = System.Drawing.Color.Black
        Me.Button_ver_buscar_fac_credito.Image = Global.MiClickDerecho.My.Resources.Resources.viewicone
        Me.Button_ver_buscar_fac_credito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_ver_buscar_fac_credito.Location = New System.Drawing.Point(768, 234)
        Me.Button_ver_buscar_fac_credito.Name = "Button_ver_buscar_fac_credito"
        Me.Button_ver_buscar_fac_credito.Size = New System.Drawing.Size(109, 32)
        Me.Button_ver_buscar_fac_credito.TabIndex = 689
        Me.Button_ver_buscar_fac_credito.Text = "Ver/Buscar"
        Me.Button_ver_buscar_fac_credito.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_ver_buscar_fac_credito.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.buttonborder2
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Controls.Add(Me.Label25)
        Me.Panel4.Controls.Add(Me.TextBox_saldo)
        Me.Panel4.Location = New System.Drawing.Point(700, 393)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(184, 34)
        Me.Panel4.TabIndex = 666
        '
        'Label4
        '
        Me.Label4.AllowDrop = True
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(-2, -15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 15)
        Me.Label4.TabIndex = 449
        Me.Label4.Text = "Destino"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox_abonos
        '
        Me.TextBox_abonos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_abonos.BackColor = System.Drawing.Color.White
        Me.TextBox_abonos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_abonos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBox_abonos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_abonos.ForeColor = System.Drawing.Color.Lime
        Me.TextBox_abonos.Location = New System.Drawing.Point(3, 6)
        Me.TextBox_abonos.Name = "TextBox_abonos"
        Me.TextBox_abonos.Size = New System.Drawing.Size(176, 22)
        Me.TextBox_abonos.TabIndex = 523
        Me.TextBox_abonos.Text = "0"
        Me.TextBox_abonos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.buttonborder2
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.TextBox_abonos)
        Me.Panel3.Location = New System.Drawing.Point(700, 359)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(184, 34)
        Me.Panel3.TabIndex = 666
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.BackColor = System.Drawing.Color.White
        Me.MetroTabPage1.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.cuadro_blanco
        Me.MetroTabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MetroTabPage1.Controls.Add(Me.Panel1)
        Me.MetroTabPage1.Controls.Add(Me.Label1)
        Me.MetroTabPage1.Controls.Add(Me.ComboBox_tipo_CuentaxPagar)
        Me.MetroTabPage1.Controls.Add(Me.Panel3)
        Me.MetroTabPage1.Controls.Add(Me.Label16)
        Me.MetroTabPage1.Controls.Add(Me.datagrid_historial_credito)
        Me.MetroTabPage1.Controls.Add(Me.Button_ver_buscar_fac_credito)
        Me.MetroTabPage1.Controls.Add(Me.Panel4)
        Me.MetroTabPage1.Controls.Add(Me.Label26)
        Me.MetroTabPage1.Controls.Add(Me.TextBox_concepto)
        Me.MetroTabPage1.Controls.Add(Me.Label24)
        Me.MetroTabPage1.Controls.Add(Me.TextBox_nro_cuenta)
        Me.MetroTabPage1.Controls.Add(Me.Label22)
        Me.MetroTabPage1.Controls.Add(Me.Label20)
        Me.MetroTabPage1.Controls.Add(Me.TextBox_nro_fac_credito)
        Me.MetroTabPage1.Controls.Add(Me.Label17)
        Me.MetroTabPage1.Controls.Add(Me.TextBox_vencimiento)
        Me.MetroTabPage1.Controls.Add(Me.DateTimePicker_vence)
        Me.MetroTabPage1.Controls.Add(Me.Label12)
        Me.MetroTabPage1.Controls.Add(Me.BunifuCards_clientes)
        Me.MetroTabPage1.Controls.Add(Me.TextBox_estado)
        Me.MetroTabPage1.Controls.Add(Me.Label41)
        Me.MetroTabPage1.Controls.Add(Me.Label_empleado)
        Me.MetroTabPage1.Controls.Add(Me.Label32)
        Me.MetroTabPage1.Controls.Add(Me.TextBox_fecha)
        Me.MetroTabPage1.Controls.Add(Me.Panel22)
        Me.MetroTabPage1.Controls.Add(Me.DateTimePicker_fecha)
        Me.MetroTabPage1.Controls.Add(Me.Label37)
        Me.MetroTabPage1.Controls.Add(Me.Label10)
        Me.MetroTabPage1.Controls.Add(Me.Panel_total_cartera)
        Me.MetroTabPage1.Controls.Add(Me.Label_panel_total_cartera)
        Me.MetroTabPage1.Controls.Add(Me.Label_tiitulo_cartera)
        Me.MetroTabPage1.Controls.Add(Me.Label30)
        Me.MetroTabPage1.Controls.Add(Me.dataGrid_credito)
        Me.MetroTabPage1.Controls.Add(Me.Panel_botones)
        Me.MetroTabPage1.Controls.Add(Me.Label15)
        Me.MetroTabPage1.Controls.Add(Me.Panel_bonotes2)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(914, 492)
        Me.MetroTabPage1.TabIndex = 2
        Me.MetroTabPage1.Text = "|               Crédtio               |"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button_buscar)
        Me.Panel1.Controls.Add(Me.TextBox_buscar_prov)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Location = New System.Drawing.Point(12, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(423, 41)
        Me.Panel1.TabIndex = 726
        '
        'Button_buscar
        '
        Me.Button_buscar.BackColor = System.Drawing.Color.Transparent
        Me.Button_buscar.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.botonbuscar
        Me.Button_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_buscar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_buscar.FlatAppearance.BorderSize = 0
        Me.Button_buscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_buscar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_buscar.ForeColor = System.Drawing.Color.White
        Me.Button_buscar.Location = New System.Drawing.Point(277, 7)
        Me.Button_buscar.Name = "Button_buscar"
        Me.Button_buscar.Size = New System.Drawing.Size(93, 30)
        Me.Button_buscar.TabIndex = 428
        Me.Button_buscar.UseVisualStyleBackColor = False
        '
        'TextBox_buscar_prov
        '
        Me.TextBox_buscar_prov.BackColor = System.Drawing.SystemColors.HotTrack
        Me.TextBox_buscar_prov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_buscar_prov.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_buscar_prov.ForeColor = System.Drawing.Color.White
        Me.TextBox_buscar_prov.Location = New System.Drawing.Point(5, 14)
        Me.TextBox_buscar_prov.Name = "TextBox_buscar_prov"
        Me.TextBox_buscar_prov.Size = New System.Drawing.Size(267, 24)
        Me.TextBox_buscar_prov.TabIndex = 429
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(88, -2)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(89, 17)
        Me.RadioButton2.TabIndex = 633
        Me.RadioButton2.Text = "Documento"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(11, -2)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(68, 17)
        Me.RadioButton1.TabIndex = 632
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Nombre"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(587, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 725
        Me.Label1.Text = "Tipo de Crédito"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox_tipo_CuentaxPagar
        '
        Me.ComboBox_tipo_CuentaxPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.ComboBox_tipo_CuentaxPagar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ComboBox_tipo_CuentaxPagar.FormattingEnabled = True
        Me.ComboBox_tipo_CuentaxPagar.Items.AddRange(New Object() {"Cuenta Corriente Comercial", "Cuenta Por Pagar a Proveedores"})
        Me.ComboBox_tipo_CuentaxPagar.Location = New System.Drawing.Point(687, 191)
        Me.ComboBox_tipo_CuentaxPagar.Name = "ComboBox_tipo_CuentaxPagar"
        Me.ComboBox_tipo_CuentaxPagar.Size = New System.Drawing.Size(201, 21)
        Me.ComboBox_tipo_CuentaxPagar.TabIndex = 606
        '
        'TextBox_concepto
        '
        Me.TextBox_concepto.BackColor = System.Drawing.Color.White
        Me.TextBox_concepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_concepto.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TextBox_concepto.Location = New System.Drawing.Point(577, 278)
        Me.TextBox_concepto.Multiline = True
        Me.TextBox_concepto.Name = "TextBox_concepto"
        Me.TextBox_concepto.Size = New System.Drawing.Size(311, 40)
        Me.TextBox_concepto.TabIndex = 686
        '
        'TextBox_nro_cuenta
        '
        Me.TextBox_nro_cuenta.BackColor = System.Drawing.Color.White
        Me.TextBox_nro_cuenta.Enabled = False
        Me.TextBox_nro_cuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_nro_cuenta.ForeColor = System.Drawing.Color.Black
        Me.TextBox_nro_cuenta.Location = New System.Drawing.Point(586, 118)
        Me.TextBox_nro_cuenta.Name = "TextBox_nro_cuenta"
        Me.TextBox_nro_cuenta.Size = New System.Drawing.Size(143, 24)
        Me.TextBox_nro_cuenta.TabIndex = 683
        Me.TextBox_nro_cuenta.Text = "0"
        Me.TextBox_nro_cuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(602, 104)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(112, 13)
        Me.Label22.TabIndex = 684
        Me.Label22.Text = "Numero de Cuenta"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.AllowDrop = True
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Gray
        Me.Label20.Location = New System.Drawing.Point(593, 240)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(0, 12)
        Me.Label20.TabIndex = 681
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox_nro_fac_credito
        '
        Me.TextBox_nro_fac_credito.BackColor = System.Drawing.Color.White
        Me.TextBox_nro_fac_credito.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_nro_fac_credito.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TextBox_nro_fac_credito.Location = New System.Drawing.Point(644, 239)
        Me.TextBox_nro_fac_credito.Name = "TextBox_nro_fac_credito"
        Me.TextBox_nro_fac_credito.Size = New System.Drawing.Size(101, 24)
        Me.TextBox_nro_fac_credito.TabIndex = 680
        Me.TextBox_nro_fac_credito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox_nro_fac_credito.Visible = False
        '
        'Label17
        '
        Me.Label17.AllowDrop = True
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Gray
        Me.Label17.Location = New System.Drawing.Point(578, 244)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 12)
        Me.Label17.TabIndex = 607
        Me.Label17.Text = "Factura No."
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label17.Visible = False
        '
        'TextBox_vencimiento
        '
        Me.TextBox_vencimiento.BackColor = System.Drawing.Color.White
        Me.TextBox_vencimiento.Enabled = False
        Me.TextBox_vencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_vencimiento.ForeColor = System.Drawing.Color.Black
        Me.TextBox_vencimiento.Location = New System.Drawing.Point(745, 159)
        Me.TextBox_vencimiento.Name = "TextBox_vencimiento"
        Me.TextBox_vencimiento.Size = New System.Drawing.Size(113, 24)
        Me.TextBox_vencimiento.TabIndex = 677
        '
        'DateTimePicker_vence
        '
        Me.DateTimePicker_vence.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.DateTimePicker_vence.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_vence.Location = New System.Drawing.Point(745, 159)
        Me.DateTimePicker_vence.Name = "DateTimePicker_vence"
        Me.DateTimePicker_vence.Size = New System.Drawing.Size(143, 24)
        Me.DateTimePicker_vence.TabIndex = 679
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(745, 145)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(133, 13)
        Me.Label12.TabIndex = 678
        Me.Label12.Text = "Fecha de Vencimiento"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BunifuCards_clientes
        '
        Me.BunifuCards_clientes.BackColor = System.Drawing.Color.White
        Me.BunifuCards_clientes.BorderRadius = 10
        Me.BunifuCards_clientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuCards_clientes.BottomSahddow = False
        Me.BunifuCards_clientes.color = System.Drawing.Color.DodgerBlue
        Me.BunifuCards_clientes.Controls.Add(Me.Label45)
        Me.BunifuCards_clientes.Controls.Add(Me.TextBox_dv)
        Me.BunifuCards_clientes.Controls.Add(Me.Label_info_cliente)
        Me.BunifuCards_clientes.Controls.Add(Me.FlowLayoutPanel1)
        Me.BunifuCards_clientes.Controls.Add(Me.TXT_NOM_CLIENTE)
        Me.BunifuCards_clientes.Controls.Add(Me.TXT_DOC_CLIENTE)
        Me.BunifuCards_clientes.Controls.Add(Me.COMBO_DOC_CLIENTE_FILTRO)
        Me.BunifuCards_clientes.Controls.Add(Me.Label14)
        Me.BunifuCards_clientes.Controls.Add(Me.COMBO_NOM_CLIENTE_FILTRO)
        Me.BunifuCards_clientes.Controls.Add(Me.Label31)
        Me.BunifuCards_clientes.Controls.Add(Me.TXT_DIR_CLIENTE)
        Me.BunifuCards_clientes.Controls.Add(Me.Label11)
        Me.BunifuCards_clientes.Controls.Add(Me.Label13)
        Me.BunifuCards_clientes.Controls.Add(Me.Label27)
        Me.BunifuCards_clientes.Controls.Add(Me.TxtMAIL_cliente)
        Me.BunifuCards_clientes.Controls.Add(Me.TXT_TELS_CLIENTE)
        Me.BunifuCards_clientes.Controls.Add(Me.Label28)
        Me.BunifuCards_clientes.LeftSahddow = False
        Me.BunifuCards_clientes.Location = New System.Drawing.Point(22, 105)
        Me.BunifuCards_clientes.Name = "BunifuCards_clientes"
        Me.BunifuCards_clientes.RightSahddow = False
        Me.BunifuCards_clientes.ShadowDepth = 40
        Me.BunifuCards_clientes.Size = New System.Drawing.Size(536, 143)
        Me.BunifuCards_clientes.TabIndex = 676
        '
        'Label28
        '
        Me.Label28.AllowDrop = True
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Gray
        Me.Label28.Location = New System.Drawing.Point(8, 66)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(48, 12)
        Me.Label28.TabIndex = 578
        Me.Label28.Text = "Teléfono"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox_estado
        '
        Me.TextBox_estado.BackColor = System.Drawing.Color.White
        Me.TextBox_estado.Enabled = False
        Me.TextBox_estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_estado.ForeColor = System.Drawing.Color.Black
        Me.TextBox_estado.Location = New System.Drawing.Point(745, 118)
        Me.TextBox_estado.Name = "TextBox_estado"
        Me.TextBox_estado.Size = New System.Drawing.Size(143, 24)
        Me.TextBox_estado.TabIndex = 674
        Me.TextBox_estado.Text = "NUEVO"
        Me.TextBox_estado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Black
        Me.Label41.Location = New System.Drawing.Point(790, 104)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(46, 13)
        Me.Label41.TabIndex = 675
        Me.Label41.Text = "Estado"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_empleado
        '
        Me.Label_empleado.BackColor = System.Drawing.Color.Transparent
        Me.Label_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_empleado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_empleado.Location = New System.Drawing.Point(128, 395)
        Me.Label_empleado.Name = "Label_empleado"
        Me.Label_empleado.Size = New System.Drawing.Size(341, 20)
        Me.Label_empleado.TabIndex = 662
        Me.Label_empleado.Text = "?"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Gray
        Me.Label32.Location = New System.Drawing.Point(28, 396)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(99, 15)
        Me.Label32.TabIndex = 661
        Me.Label32.Text = "Elaborado Por"
        '
        'TextBox_fecha
        '
        Me.TextBox_fecha.BackColor = System.Drawing.Color.White
        Me.TextBox_fecha.Enabled = False
        Me.TextBox_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_fecha.ForeColor = System.Drawing.Color.Black
        Me.TextBox_fecha.Location = New System.Drawing.Point(586, 159)
        Me.TextBox_fecha.Name = "TextBox_fecha"
        Me.TextBox_fecha.Size = New System.Drawing.Size(113, 24)
        Me.TextBox_fecha.TabIndex = 665
        '
        'Panel22
        '
        Me.Panel22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel22.BackColor = System.Drawing.Color.Transparent
        Me.Panel22.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.buttonborder2
        Me.Panel22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel22.Controls.Add(Me.Label36)
        Me.Panel22.Controls.Add(Me.TextBox_valor_cuenta)
        Me.Panel22.Location = New System.Drawing.Point(700, 325)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(184, 34)
        Me.Panel22.TabIndex = 664
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Bold
        Me.MetroTabControl1.Location = New System.Drawing.Point(7, 53)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(922, 534)
        Me.MetroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.MetroTabControl1.TabIndex = 509
        Me.MetroTabControl1.UseCustomBackColor = True
        Me.MetroTabControl1.UseCustomForeColor = True
        Me.MetroTabControl1.UseSelectable = True
        Me.MetroTabControl1.UseStyleColors = True
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.CANCEL
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button6.Location = New System.Drawing.Point(895, 7)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(30, 30)
        Me.Button6.TabIndex = 644
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button6.UseVisualStyleBackColor = False
        '
        'DataGrid_export
        '
        Me.DataGrid_export.AllowUserToAddRows = False
        Me.DataGrid_export.AllowUserToDeleteRows = False
        Me.DataGrid_export.AllowUserToOrderColumns = True
        Me.DataGrid_export.AllowUserToResizeRows = False
        Me.DataGrid_export.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGrid_export.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.DataGrid_export.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGrid_export.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGrid_export.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid_export.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGrid_export.ColumnHeadersHeight = 30
        Me.DataGrid_export.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrid_export.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGrid_export.EnableHeadersVisualStyles = False
        Me.DataGrid_export.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.DataGrid_export.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGrid_export.Location = New System.Drawing.Point(629, 23)
        Me.DataGrid_export.Name = "DataGrid_export"
        Me.DataGrid_export.ReadOnly = True
        Me.DataGrid_export.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid_export.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGrid_export.RowHeadersVisible = False
        Me.DataGrid_export.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGrid_export.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DataGrid_export.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid_export.Size = New System.Drawing.Size(112, 14)
        Me.DataGrid_export.TabIndex = 643
        Me.DataGrid_export.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.MiClickDerecho.My.Resources.Resources.cuentasporpagar
        Me.PictureBox1.Location = New System.Drawing.Point(4, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 45)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 434
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Berlin Sans FB", 16.25!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(54, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(197, 24)
        Me.Label8.TabIndex = 393
        Me.Label8.Text = "Opciones de Crédito"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.banner9
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Controls.Add(Me.DataGrid_export)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(-1, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(938, 46)
        Me.Panel2.TabIndex = 508
        '
        'BunifuElipse9
        '
        Me.BunifuElipse9.ElipseRadius = 5
        Me.BunifuElipse9.TargetControl = Me.datagrid_historial_credito
        '
        'Form_credito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(936, 597)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_credito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_credito"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel_total_cartera.ResumeLayout(False)
        Me.Panel_total_cartera.PerformLayout()
        CType(Me.dataGrid_credito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_bonotes2.ResumeLayout(False)
        Me.Panel_botones.ResumeLayout(False)
        CType(Me.datagrid_historial_credito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.BunifuCards_clientes.ResumeLayout(False)
        Me.BunifuCards_clientes.PerformLayout()
        Me.Panel22.ResumeLayout(False)
        Me.Panel22.PerformLayout()
        Me.MetroTabControl1.ResumeLayout(False)
        CType(Me.DataGrid_export, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextBox_dv As TextBox
    Friend WithEvents Label_info_cliente As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Button_REFRESH_cliente As Button
    Friend WithEvents Button_NUEVO_CLI As Button
    Friend WithEvents Button_EDIT_CLI As Button
    Friend WithEvents Button_SAVE_CLI As Button
    Friend WithEvents Label_panel_total_cartera As Label
    Friend WithEvents Label_tiitulo_cartera As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents TXT_NOM_CLIENTE As TextBox
    Friend WithEvents TXT_DOC_CLIENTE As TextBox
    Friend WithEvents COMBO_DOC_CLIENTE_FILTRO As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents COMBO_NOM_CLIENTE_FILTRO As ComboBox
    Friend WithEvents TXT_DIR_CLIENTE As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents TxtMAIL_cliente As TextBox
    Friend WithEvents Label_TOTAL_creditos As Label
    Friend WithEvents DateTimePicker_fecha As DateTimePicker
    Friend WithEvents Label37 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel_total_cartera As Panel
    Friend WithEvents Label31 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Timer_PROVEEDORES As Timer
    Friend WithEvents Timer_clientes As Timer
    Friend WithEvents Timer_tipo_cajabanco As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer_TERCERO As Timer
    Friend WithEvents BunifuElipse8 As ns1.BunifuElipse
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_abonos As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents datagrid_historial_credito As MetroFramework.Controls.MetroGrid
    Friend WithEvents Button_ver_buscar_fac_credito As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label25 As Label
    Friend WithEvents TextBox_saldo As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents TextBox_concepto As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents TextBox_nro_cuenta As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TextBox_nro_fac_credito As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox_vencimiento As TextBox
    Friend WithEvents DateTimePicker_vence As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents BunifuCards_clientes As ns1.BunifuCards
    Friend WithEvents TXT_TELS_CLIENTE As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents TextBox_estado As TextBox
    Friend WithEvents Label41 As Label
    Friend WithEvents Label_empleado As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents TextBox_fecha As TextBox
    Friend WithEvents Panel22 As Panel
    Friend WithEvents TextBox_valor_cuenta As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents dataGrid_credito As MetroFramework.Controls.MetroGrid
    Friend WithEvents Panel_botones As Panel
    Friend WithEvents Btn_nuevo_cartera As Button
    Friend WithEvents Button_ver_credito As Button
    Friend WithEvents Button_exportar As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel_bonotes2 As FlowLayoutPanel
    Friend WithEvents Button_regresar_credito As Button
    Friend WithEvents Button_exportar_credito As Button
    Friend WithEvents Button_contabilizar_credito As Button
    Friend WithEvents Button_guardar_credito As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents DataGrid_export As MetroFramework.Controls.MetroGrid
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BunifuElipse7 As ns1.BunifuElipse
    Friend WithEvents BunifuElipse6 As ns1.BunifuElipse
    Friend WithEvents BunifuElipse5 As ns1.BunifuElipse
    Friend WithEvents BunifuElipse4 As ns1.BunifuElipse
    Friend WithEvents BunifuElipse3 As ns1.BunifuElipse
    Friend WithEvents BunifuElipse2 As ns1.BunifuElipse
    Friend WithEvents Timer_tipomov As Timer
    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents BunifuElipse9 As ns1.BunifuElipse
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox_tipo_CuentaxPagar As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button_buscar As Button
    Friend WithEvents TextBox_buscar_prov As TextBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Button_anular As Button
End Class
