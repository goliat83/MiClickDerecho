<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_ntcr
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_ntcr))
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button_gastos = New System.Windows.Forms.Button()
        Me.Btn_salir = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.BunifuElipse4 = New ns1.BunifuElipse(Me.components)
        Me.TextBox_referencia = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox_subtotal = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ComboBox_cxp = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox_concepto = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox_impuestos = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox_valorgasto = New System.Windows.Forms.TextBox()
        Me.Label_info_cliente = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBox_imp_a_aplicar = New System.Windows.Forms.TextBox()
        Me.Button_aplica_imp = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.ComboBox_impuestos = New System.Windows.Forms.ComboBox()
        Me.TextBox_ret_a_aplicar = New System.Windows.Forms.TextBox()
        Me.Button_aplica_ret = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.ComboBox_RETENCIONES = New System.Windows.Forms.ComboBox()
        Me.TextBox_valor = New ns1.BunifuMaterialTextbox()
        Me.Button_concepto_op = New System.Windows.Forms.Button()
        Me.ComboBox_tipo_egreso = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button_REFRESH = New System.Windows.Forms.Button()
        Me.Button_NUEVO_CLI = New System.Windows.Forms.Button()
        Me.Button_EDIT_CLI = New System.Windows.Forms.Button()
        Me.Button_SAVE_CLI = New System.Windows.Forms.Button()
        Me.BunifuElipse5 = New ns1.BunifuElipse(Me.components)
        Me.Label19 = New System.Windows.Forms.Label()
        Me.BunifuElipse3 = New ns1.BunifuElipse(Me.components)
        Me.ConfigurarCuentasDeContabilidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip_LOAD_PUC = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button_anular = New System.Windows.Forms.Button()
        Me.Button_guardar = New System.Windows.Forms.Button()
        Me.BunifuElipse2 = New ns1.BunifuElipse(Me.components)
        Me.Timer_factura_info = New System.Windows.Forms.Timer(Me.components)
        Me.Btn_nuevo_mov = New System.Windows.Forms.Button()
        Me.Panel_dock = New System.Windows.Forms.Panel()
        Me.Timer_cuentapuc_concepto = New System.Windows.Forms.Timer(Me.components)
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.ComboBox_MEDIOPAGO = New System.Windows.Forms.ComboBox()
        Me.Timer_VER = New System.Windows.Forms.Timer(Me.components)
        Me.Label_estado_gasto = New System.Windows.Forms.Label()
        Me.Label_fecha = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label_consecutivo = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Timer_MEDIO_PAGO = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_CLIENTE = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_dv_cliente = New System.Windows.Forms.TextBox()
        Me.COMBO_NOM_CLIENTE_FILTRO = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.BunifuCards1 = New ns1.BunifuCards()
        Me.TEXTBOX_BUSCAR_PROV = New ns1.BunifuMaterialTextbox()
        Me.Panel_cliente = New System.Windows.Forms.Panel()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TXT_DIR_CLIENTE = New ns1.BunifuMaterialTextbox()
        Me.TXT_DOC_CLIENTE = New ns1.BunifuMaterialTextbox()
        Me.TXT_NOM_CLIENTE = New ns1.BunifuMaterialTextbox()
        Me.TXT_TELS_CLIENTE = New ns1.BunifuMaterialTextbox()
        Me.BunifuElipse6 = New ns1.BunifuElipse(Me.components)
        Me.Timer_nuevo = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox_retenciones = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.ContextMenuStrip_LOAD_PUC.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel_dock.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.BunifuCards1.SuspendLayout()
        Me.Panel_cliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Panel2.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.banner9
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Button_gastos)
        Me.Panel2.Controls.Add(Me.Btn_salir)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(974, 32)
        Me.Panel2.TabIndex = 934
        '
        'Button_gastos
        '
        Me.Button_gastos.BackColor = System.Drawing.Color.Transparent
        Me.Button_gastos.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.iconocnomina
        Me.Button_gastos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_gastos.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.Button_gastos.FlatAppearance.BorderSize = 0
        Me.Button_gastos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_gastos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_gastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_gastos.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_gastos.ForeColor = System.Drawing.Color.White
        Me.Button_gastos.Location = New System.Drawing.Point(5, 1)
        Me.Button_gastos.Name = "Button_gastos"
        Me.Button_gastos.Size = New System.Drawing.Size(33, 34)
        Me.Button_gastos.TabIndex = 394
        Me.Button_gastos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_gastos.UseVisualStyleBackColor = False
        '
        'Btn_salir
        '
        Me.Btn_salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_salir.BackColor = System.Drawing.Color.Transparent
        Me.Btn_salir.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.CANCEL
        Me.Btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_salir.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Btn_salir.FlatAppearance.BorderSize = 0
        Me.Btn_salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Btn_salir.ForeColor = System.Drawing.Color.Black
        Me.Btn_salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_salir.Location = New System.Drawing.Point(938, 4)
        Me.Btn_salir.Name = "Btn_salir"
        Me.Btn_salir.Size = New System.Drawing.Size(25, 25)
        Me.Btn_salir.TabIndex = 265
        Me.Btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_salir.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(40, 9)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(129, 18)
        Me.Label17.TabIndex = 393
        Me.Label17.Text = "Notas de Crédito"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BunifuElipse4
        '
        Me.BunifuElipse4.ElipseRadius = 5
        Me.BunifuElipse4.TargetControl = Me.TextBox_referencia
        '
        'TextBox_referencia
        '
        Me.TextBox_referencia.BackColor = System.Drawing.Color.Gainsboro
        Me.TextBox_referencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_referencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox_referencia.ForeColor = System.Drawing.Color.Black
        Me.TextBox_referencia.Location = New System.Drawing.Point(17, 70)
        Me.TextBox_referencia.Name = "TextBox_referencia"
        Me.TextBox_referencia.Size = New System.Drawing.Size(150, 26)
        Me.TextBox_referencia.TabIndex = 539
        Me.TextBox_referencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AllowDrop = True
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.25!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(63, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 16)
        Me.Label10.TabIndex = 950
        Me.Label10.Text = "Subtotal"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox_subtotal
        '
        Me.TextBox_subtotal.BackColor = System.Drawing.Color.LightGray
        Me.TextBox_subtotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_subtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_subtotal.ForeColor = System.Drawing.Color.Black
        Me.TextBox_subtotal.Location = New System.Drawing.Point(136, 26)
        Me.TextBox_subtotal.Name = "TextBox_subtotal"
        Me.TextBox_subtotal.Size = New System.Drawing.Size(186, 19)
        Me.TextBox_subtotal.TabIndex = 947
        Me.TextBox_subtotal.Text = "0"
        Me.TextBox_subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AllowDrop = True
        Me.Label15.BackColor = System.Drawing.Color.LightCoral
        Me.Label15.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(601, 140)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(331, 30)
        Me.Label15.TabIndex = 943
        Me.Label15.Text = "Total"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox_cxp
        '
        Me.ComboBox_cxp.BackColor = System.Drawing.Color.Gainsboro
        Me.ComboBox_cxp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox_cxp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_cxp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_cxp.ForeColor = System.Drawing.Color.Black
        Me.ComboBox_cxp.FormattingEnabled = True
        Me.ComboBox_cxp.Location = New System.Drawing.Point(172, 71)
        Me.ComboBox_cxp.Name = "ComboBox_cxp"
        Me.ComboBox_cxp.Size = New System.Drawing.Size(406, 24)
        Me.ComboBox_cxp.TabIndex = 750
        '
        'Label13
        '
        Me.Label13.AllowDrop = True
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(6, 291)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 13)
        Me.Label13.TabIndex = 920
        Me.Label13.Text = "Generado Por"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AllowDrop = True
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Green
        Me.Label14.Location = New System.Drawing.Point(97, 292)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 13)
        Me.Label14.TabIndex = 921
        Me.Label14.Text = "Empleado"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AllowDrop = True
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(171, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(184, 16)
        Me.Label5.TabIndex = 908
        Me.Label5.Text = "Factura / Cuenta de Cobro"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AllowDrop = True
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.25!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(16, 99)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 16)
        Me.Label11.TabIndex = 539
        Me.Label11.Text = "Descripción"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox_concepto
        '
        Me.TextBox_concepto.BackColor = System.Drawing.Color.Gainsboro
        Me.TextBox_concepto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_concepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_concepto.ForeColor = System.Drawing.Color.Black
        Me.TextBox_concepto.Location = New System.Drawing.Point(16, 117)
        Me.TextBox_concepto.Multiline = True
        Me.TextBox_concepto.Name = "TextBox_concepto"
        Me.TextBox_concepto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox_concepto.Size = New System.Drawing.Size(562, 76)
        Me.TextBox_concepto.TabIndex = 540
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TextBox_retenciones)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.TextBox_subtotal)
        Me.Panel1.Controls.Add(Me.TextBox_impuestos)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TextBox_valorgasto)
        Me.Panel1.Location = New System.Drawing.Point(600, 166)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(332, 138)
        Me.Panel1.TabIndex = 970
        '
        'TextBox_impuestos
        '
        Me.TextBox_impuestos.BackColor = System.Drawing.Color.LightGray
        Me.TextBox_impuestos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_impuestos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_impuestos.ForeColor = System.Drawing.Color.Black
        Me.TextBox_impuestos.Location = New System.Drawing.Point(136, 50)
        Me.TextBox_impuestos.Name = "TextBox_impuestos"
        Me.TextBox_impuestos.Size = New System.Drawing.Size(186, 19)
        Me.TextBox_impuestos.TabIndex = 948
        Me.TextBox_impuestos.Text = "0"
        Me.TextBox_impuestos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AllowDrop = True
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.25!)
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(41, 51)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 16)
        Me.Label16.TabIndex = 951
        Me.Label16.Text = "+Impuestos"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AllowDrop = True
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.25!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(85, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 16)
        Me.Label8.TabIndex = 949
        Me.Label8.Text = "Total"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox_valorgasto
        '
        Me.TextBox_valorgasto.BackColor = System.Drawing.Color.LightGray
        Me.TextBox_valorgasto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_valorgasto.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox_valorgasto.ForeColor = System.Drawing.Color.Black
        Me.TextBox_valorgasto.Location = New System.Drawing.Point(136, 102)
        Me.TextBox_valorgasto.Name = "TextBox_valorgasto"
        Me.TextBox_valorgasto.Size = New System.Drawing.Size(186, 20)
        Me.TextBox_valorgasto.TabIndex = 944
        Me.TextBox_valorgasto.Text = "0"
        Me.TextBox_valorgasto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_info_cliente
        '
        Me.Label_info_cliente.AllowDrop = True
        Me.Label_info_cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label_info_cliente.BackColor = System.Drawing.Color.Transparent
        Me.Label_info_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Label_info_cliente.ForeColor = System.Drawing.Color.Red
        Me.Label_info_cliente.Location = New System.Drawing.Point(8, 124)
        Me.Label_info_cliente.Name = "Label_info_cliente"
        Me.Label_info_cliente.Size = New System.Drawing.Size(482, 23)
        Me.Label_info_cliente.TabIndex = 603
        Me.Label_info_cliente.Text = "Registre los Datos del Cliente"
        Me.Label_info_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label_info_cliente.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel3.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.cuadro_blanco
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.TextBox_imp_a_aplicar)
        Me.Panel3.Controls.Add(Me.Button_aplica_imp)
        Me.Panel3.Controls.Add(Me.Label28)
        Me.Panel3.Controls.Add(Me.ComboBox_impuestos)
        Me.Panel3.Controls.Add(Me.TextBox_ret_a_aplicar)
        Me.Panel3.Controls.Add(Me.Button_aplica_ret)
        Me.Panel3.Controls.Add(Me.Label25)
        Me.Panel3.Controls.Add(Me.ComboBox_RETENCIONES)
        Me.Panel3.Controls.Add(Me.TextBox_valor)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.ComboBox_cxp)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.TextBox_concepto)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.Button_concepto_op)
        Me.Panel3.Controls.Add(Me.ComboBox_tipo_egreso)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.TextBox_referencia)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label23)
        Me.Panel3.Enabled = False
        Me.Panel3.Location = New System.Drawing.Point(15, 247)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(945, 309)
        Me.Panel3.TabIndex = 941
        '
        'TextBox_imp_a_aplicar
        '
        Me.TextBox_imp_a_aplicar.BackColor = System.Drawing.Color.LightGray
        Me.TextBox_imp_a_aplicar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_imp_a_aplicar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_imp_a_aplicar.ForeColor = System.Drawing.Color.Black
        Me.TextBox_imp_a_aplicar.Location = New System.Drawing.Point(12, 243)
        Me.TextBox_imp_a_aplicar.Name = "TextBox_imp_a_aplicar"
        Me.TextBox_imp_a_aplicar.Size = New System.Drawing.Size(159, 19)
        Me.TextBox_imp_a_aplicar.TabIndex = 994
        Me.TextBox_imp_a_aplicar.Text = "0"
        Me.TextBox_imp_a_aplicar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button_aplica_imp
        '
        Me.Button_aplica_imp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_aplica_imp.BackColor = System.Drawing.Color.Transparent
        Me.Button_aplica_imp.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.butttonsvg
        Me.Button_aplica_imp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_aplica_imp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_aplica_imp.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_aplica_imp.FlatAppearance.BorderSize = 0
        Me.Button_aplica_imp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button_aplica_imp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.Button_aplica_imp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_aplica_imp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Button_aplica_imp.ForeColor = System.Drawing.Color.White
        Me.Button_aplica_imp.Location = New System.Drawing.Point(202, 239)
        Me.Button_aplica_imp.Name = "Button_aplica_imp"
        Me.Button_aplica_imp.Size = New System.Drawing.Size(85, 27)
        Me.Button_aplica_imp.TabIndex = 991
        Me.Button_aplica_imp.Text = "Aplicar"
        Me.Button_aplica_imp.UseVisualStyleBackColor = False
        '
        'Label28
        '
        Me.Label28.AllowDrop = True
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.25!)
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(13, 196)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(70, 16)
        Me.Label28.TabIndex = 990
        Me.Label28.Text = "Impuesto"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox_impuestos
        '
        Me.ComboBox_impuestos.BackColor = System.Drawing.Color.Gainsboro
        Me.ComboBox_impuestos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox_impuestos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_impuestos.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.ComboBox_impuestos.ForeColor = System.Drawing.Color.Black
        Me.ComboBox_impuestos.FormattingEnabled = True
        Me.ComboBox_impuestos.Location = New System.Drawing.Point(12, 212)
        Me.ComboBox_impuestos.Name = "ComboBox_impuestos"
        Me.ComboBox_impuestos.Size = New System.Drawing.Size(275, 21)
        Me.ComboBox_impuestos.TabIndex = 988
        '
        'TextBox_ret_a_aplicar
        '
        Me.TextBox_ret_a_aplicar.BackColor = System.Drawing.Color.LightGray
        Me.TextBox_ret_a_aplicar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_ret_a_aplicar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ret_a_aplicar.ForeColor = System.Drawing.Color.Black
        Me.TextBox_ret_a_aplicar.Location = New System.Drawing.Point(299, 242)
        Me.TextBox_ret_a_aplicar.Name = "TextBox_ret_a_aplicar"
        Me.TextBox_ret_a_aplicar.Size = New System.Drawing.Size(159, 19)
        Me.TextBox_ret_a_aplicar.TabIndex = 993
        Me.TextBox_ret_a_aplicar.Text = "0"
        Me.TextBox_ret_a_aplicar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button_aplica_ret
        '
        Me.Button_aplica_ret.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_aplica_ret.BackColor = System.Drawing.Color.Transparent
        Me.Button_aplica_ret.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.butttonsvg
        Me.Button_aplica_ret.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_aplica_ret.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_aplica_ret.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_aplica_ret.FlatAppearance.BorderSize = 0
        Me.Button_aplica_ret.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button_aplica_ret.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.Button_aplica_ret.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_aplica_ret.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Button_aplica_ret.ForeColor = System.Drawing.Color.White
        Me.Button_aplica_ret.Location = New System.Drawing.Point(489, 240)
        Me.Button_aplica_ret.Name = "Button_aplica_ret"
        Me.Button_aplica_ret.Size = New System.Drawing.Size(85, 27)
        Me.Button_aplica_ret.TabIndex = 992
        Me.Button_aplica_ret.Text = "Aplicar"
        Me.Button_aplica_ret.UseVisualStyleBackColor = False
        '
        'Label25
        '
        Me.Label25.AllowDrop = True
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.25!)
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(299, 196)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(75, 16)
        Me.Label25.TabIndex = 989
        Me.Label25.Text = "Retención"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox_RETENCIONES
        '
        Me.ComboBox_RETENCIONES.BackColor = System.Drawing.Color.Gainsboro
        Me.ComboBox_RETENCIONES.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox_RETENCIONES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_RETENCIONES.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.ComboBox_RETENCIONES.ForeColor = System.Drawing.Color.Black
        Me.ComboBox_RETENCIONES.FormattingEnabled = True
        Me.ComboBox_RETENCIONES.Location = New System.Drawing.Point(299, 212)
        Me.ComboBox_RETENCIONES.Name = "ComboBox_RETENCIONES"
        Me.ComboBox_RETENCIONES.Size = New System.Drawing.Size(275, 21)
        Me.ComboBox_RETENCIONES.TabIndex = 987
        '
        'TextBox_valor
        '
        Me.TextBox_valor.BackColor = System.Drawing.Color.White
        Me.TextBox_valor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox_valor.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.TextBox_valor.ForeColor = System.Drawing.Color.Black
        Me.TextBox_valor.HintForeColor = System.Drawing.Color.Empty
        Me.TextBox_valor.HintText = ""
        Me.TextBox_valor.isPassword = False
        Me.TextBox_valor.LineFocusedColor = System.Drawing.Color.Blue
        Me.TextBox_valor.LineIdleColor = System.Drawing.Color.LightCoral
        Me.TextBox_valor.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TextBox_valor.LineThickness = 3
        Me.TextBox_valor.Location = New System.Drawing.Point(728, 26)
        Me.TextBox_valor.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextBox_valor.Name = "TextBox_valor"
        Me.TextBox_valor.Size = New System.Drawing.Size(198, 26)
        Me.TextBox_valor.TabIndex = 986
        Me.TextBox_valor.Text = "0"
        Me.TextBox_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button_concepto_op
        '
        Me.Button_concepto_op.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_concepto_op.BackColor = System.Drawing.Color.Transparent
        Me.Button_concepto_op.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.menu
        Me.Button_concepto_op.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_concepto_op.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_concepto_op.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_concepto_op.FlatAppearance.BorderSize = 0
        Me.Button_concepto_op.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button_concepto_op.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.Button_concepto_op.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_concepto_op.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Button_concepto_op.ForeColor = System.Drawing.Color.White
        Me.Button_concepto_op.Location = New System.Drawing.Point(588, 22)
        Me.Button_concepto_op.Name = "Button_concepto_op"
        Me.Button_concepto_op.Size = New System.Drawing.Size(31, 28)
        Me.Button_concepto_op.TabIndex = 973
        Me.Button_concepto_op.UseVisualStyleBackColor = False
        '
        'ComboBox_tipo_egreso
        '
        Me.ComboBox_tipo_egreso.BackColor = System.Drawing.Color.PowderBlue
        Me.ComboBox_tipo_egreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_tipo_egreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.75!, System.Drawing.FontStyle.Bold)
        Me.ComboBox_tipo_egreso.ForeColor = System.Drawing.Color.Black
        Me.ComboBox_tipo_egreso.FormattingEnabled = True
        Me.ComboBox_tipo_egreso.Items.AddRange(New Object() {"A Factura de Venta", "A Cuenta Por Cobrar", "A Factura de Compra", "A Cuenta Por Pagar"})
        Me.ComboBox_tipo_egreso.Location = New System.Drawing.Point(17, 26)
        Me.ComboBox_tipo_egreso.Name = "ComboBox_tipo_egreso"
        Me.ComboBox_tipo_egreso.Size = New System.Drawing.Size(561, 25)
        Me.ComboBox_tipo_egreso.TabIndex = 750
        '
        'Label1
        '
        Me.Label1.AllowDrop = True
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(18, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 906
        Me.Label1.Text = "Concepto"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AllowDrop = True
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.25!)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(18, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 16)
        Me.Label12.TabIndex = 553
        Me.Label12.Text = "No. Referencia"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.AllowDrop = True
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.25!)
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(680, 31)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(44, 16)
        Me.Label23.TabIndex = 974
        Me.Label23.Text = "Valor"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanel2.Controls.Add(Me.Button_REFRESH)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button_NUEVO_CLI)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button_EDIT_CLI)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button_SAVE_CLI)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(528, 47)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(36, 134)
        Me.FlowLayoutPanel2.TabIndex = 603
        '
        'Button_REFRESH
        '
        Me.Button_REFRESH.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button_REFRESH.BackColor = System.Drawing.Color.Transparent
        Me.Button_REFRESH.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.refresh
        Me.Button_REFRESH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_REFRESH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_REFRESH.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.Button_REFRESH.FlatAppearance.BorderSize = 0
        Me.Button_REFRESH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_REFRESH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_REFRESH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_REFRESH.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_REFRESH.ForeColor = System.Drawing.Color.White
        Me.Button_REFRESH.Location = New System.Drawing.Point(3, 3)
        Me.Button_REFRESH.Name = "Button_REFRESH"
        Me.Button_REFRESH.Size = New System.Drawing.Size(30, 28)
        Me.Button_REFRESH.TabIndex = 751
        Me.Button_REFRESH.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_REFRESH.UseVisualStyleBackColor = False
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
        'BunifuElipse5
        '
        Me.BunifuElipse5.ElipseRadius = 5
        Me.BunifuElipse5.TargetControl = Me.ComboBox_cxp
        '
        'Label19
        '
        Me.Label19.AllowDrop = True
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(17, 39)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(260, 45)
        Me.Label19.TabIndex = 945
        Me.Label19.Text = "Nota de Crédito"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuElipse3
        '
        Me.BunifuElipse3.ElipseRadius = 5
        Me.BunifuElipse3.TargetControl = Me.Label15
        '
        'ConfigurarCuentasDeContabilidadToolStripMenuItem
        '
        Me.ConfigurarCuentasDeContabilidadToolStripMenuItem.BackColor = System.Drawing.Color.Lavender
        Me.ConfigurarCuentasDeContabilidadToolStripMenuItem.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.buttonborder2
        Me.ConfigurarCuentasDeContabilidadToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ConfigurarCuentasDeContabilidadToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.ConfigurarCuentasDeContabilidadToolStripMenuItem.Image = Global.MiClickDerecho.My.Resources.Resources.accounter2512
        Me.ConfigurarCuentasDeContabilidadToolStripMenuItem.Name = "ConfigurarCuentasDeContabilidadToolStripMenuItem"
        Me.ConfigurarCuentasDeContabilidadToolStripMenuItem.Size = New System.Drawing.Size(322, 26)
        Me.ConfigurarCuentasDeContabilidadToolStripMenuItem.Text = "Configurar Conceptos de Egresos"
        '
        'ContextMenuStrip_LOAD_PUC
        '
        Me.ContextMenuStrip_LOAD_PUC.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfigurarCuentasDeContabilidadToolStripMenuItem})
        Me.ContextMenuStrip_LOAD_PUC.Name = "ContextMenuStrip_LOAD_PUC"
        Me.ContextMenuStrip_LOAD_PUC.Size = New System.Drawing.Size(323, 30)
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Button3)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button4)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button_anular)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button_guardar)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(643, 37)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(319, 48)
        Me.FlowLayoutPanel1.TabIndex = 944
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = Global.MiClickDerecho.My.Resources.Resources.export_icon
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(240, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(76, 45)
        Me.Button3.TabIndex = 751
        Me.Button3.Text = "Exportar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = Global.MiClickDerecho.My.Resources.Resources.PRINTICON
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(159, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 45)
        Me.Button4.TabIndex = 752
        Me.Button4.Text = "Imprimir"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.Visible = False
        '
        'Button_anular
        '
        Me.Button_anular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_anular.BackColor = System.Drawing.Color.Transparent
        Me.Button_anular.BackgroundImage = CType(resources.GetObject("Button_anular.BackgroundImage"), System.Drawing.Image)
        Me.Button_anular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_anular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_anular.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_anular.FlatAppearance.BorderSize = 0
        Me.Button_anular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button_anular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.Button_anular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_anular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_anular.ForeColor = System.Drawing.Color.White
        Me.Button_anular.Image = Global.MiClickDerecho.My.Resources.Resources.delete_256
        Me.Button_anular.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_anular.Location = New System.Drawing.Point(88, 3)
        Me.Button_anular.Name = "Button_anular"
        Me.Button_anular.Size = New System.Drawing.Size(65, 45)
        Me.Button_anular.TabIndex = 602
        Me.Button_anular.Text = "&Anular"
        Me.Button_anular.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_anular.UseVisualStyleBackColor = False
        Me.Button_anular.Visible = False
        '
        'Button_guardar
        '
        Me.Button_guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_guardar.BackColor = System.Drawing.Color.Transparent
        Me.Button_guardar.BackgroundImage = CType(resources.GetObject("Button_guardar.BackgroundImage"), System.Drawing.Image)
        Me.Button_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_guardar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_guardar.FlatAppearance.BorderSize = 0
        Me.Button_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.Button_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_guardar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_guardar.ForeColor = System.Drawing.Color.White
        Me.Button_guardar.Image = Global.MiClickDerecho.My.Resources.Resources.guardar
        Me.Button_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_guardar.Location = New System.Drawing.Point(5, 3)
        Me.Button_guardar.Name = "Button_guardar"
        Me.Button_guardar.Size = New System.Drawing.Size(77, 45)
        Me.Button_guardar.TabIndex = 554
        Me.Button_guardar.Text = "Guardar"
        Me.Button_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_guardar.UseVisualStyleBackColor = False
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 5
        Me.BunifuElipse2.TargetControl = Me
        '
        'Timer_factura_info
        '
        Me.Timer_factura_info.Interval = 300
        '
        'Btn_nuevo_mov
        '
        Me.Btn_nuevo_mov.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_nuevo_mov.BackColor = System.Drawing.Color.Transparent
        Me.Btn_nuevo_mov.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.butttonsvg
        Me.Btn_nuevo_mov.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_nuevo_mov.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_nuevo_mov.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Btn_nuevo_mov.FlatAppearance.BorderSize = 0
        Me.Btn_nuevo_mov.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_nuevo_mov.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btn_nuevo_mov.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_nuevo_mov.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Btn_nuevo_mov.ForeColor = System.Drawing.Color.White
        Me.Btn_nuevo_mov.Image = Global.MiClickDerecho.My.Resources.Resources.agregar
        Me.Btn_nuevo_mov.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_nuevo_mov.Location = New System.Drawing.Point(234, 2)
        Me.Btn_nuevo_mov.Name = "Btn_nuevo_mov"
        Me.Btn_nuevo_mov.Size = New System.Drawing.Size(107, 45)
        Me.Btn_nuevo_mov.TabIndex = 296
        Me.Btn_nuevo_mov.Text = "Nuevo"
        Me.Btn_nuevo_mov.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_nuevo_mov.UseVisualStyleBackColor = False
        '
        'Panel_dock
        '
        Me.Panel_dock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_dock.BackColor = System.Drawing.Color.Transparent
        Me.Panel_dock.Controls.Add(Me.Btn_nuevo_mov)
        Me.Panel_dock.Location = New System.Drawing.Point(618, 37)
        Me.Panel_dock.Name = "Panel_dock"
        Me.Panel_dock.Size = New System.Drawing.Size(346, 48)
        Me.Panel_dock.TabIndex = 939
        '
        'Timer_cuentapuc_concepto
        '
        Me.Timer_cuentapuc_concepto.Interval = 300
        '
        'Panel15
        '
        Me.Panel15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel15.BackColor = System.Drawing.Color.Transparent
        Me.Panel15.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.cuadro_blanco
        Me.Panel15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel15.Controls.Add(Me.ComboBox_MEDIOPAGO)
        Me.Panel15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel15.Location = New System.Drawing.Point(147, 109)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(212, 28)
        Me.Panel15.TabIndex = 906
        '
        'ComboBox_MEDIOPAGO
        '
        Me.ComboBox_MEDIOPAGO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_MEDIOPAGO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox_MEDIOPAGO.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.ComboBox_MEDIOPAGO.ForeColor = System.Drawing.Color.Black
        Me.ComboBox_MEDIOPAGO.FormattingEnabled = True
        Me.ComboBox_MEDIOPAGO.Location = New System.Drawing.Point(4, 4)
        Me.ComboBox_MEDIOPAGO.Name = "ComboBox_MEDIOPAGO"
        Me.ComboBox_MEDIOPAGO.Size = New System.Drawing.Size(204, 21)
        Me.ComboBox_MEDIOPAGO.TabIndex = 550
        '
        'Timer_VER
        '
        Me.Timer_VER.Interval = 300
        '
        'Label_estado_gasto
        '
        Me.Label_estado_gasto.AllowDrop = True
        Me.Label_estado_gasto.BackColor = System.Drawing.Color.Transparent
        Me.Label_estado_gasto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_estado_gasto.ForeColor = System.Drawing.Color.Black
        Me.Label_estado_gasto.Location = New System.Drawing.Point(6, 3)
        Me.Label_estado_gasto.Name = "Label_estado_gasto"
        Me.Label_estado_gasto.Size = New System.Drawing.Size(200, 20)
        Me.Label_estado_gasto.TabIndex = 550
        Me.Label_estado_gasto.Text = "Nuevo"
        Me.Label_estado_gasto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_fecha
        '
        Me.Label_fecha.AllowDrop = True
        Me.Label_fecha.BackColor = System.Drawing.Color.Transparent
        Me.Label_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_fecha.ForeColor = System.Drawing.Color.Black
        Me.Label_fecha.Location = New System.Drawing.Point(5, 4)
        Me.Label_fecha.Name = "Label_fecha"
        Me.Label_fecha.Size = New System.Drawing.Size(204, 20)
        Me.Label_fecha.TabIndex = 548
        Me.Label_fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label26
        '
        Me.Label26.AllowDrop = True
        Me.Label26.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(96, 10)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(47, 27)
        Me.Label26.TabIndex = 569
        Me.Label26.Text = "No."
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.AllowDrop = True
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(29, 115)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(114, 16)
        Me.Label18.TabIndex = 905
        Me.Label18.Text = "Medio de Pago"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel9
        '
        Me.Panel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel9.BackColor = System.Drawing.Color.Transparent
        Me.Panel9.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.cuadro_blanco
        Me.Panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel9.Controls.Add(Me.Label_consecutivo)
        Me.Panel9.Location = New System.Drawing.Point(147, 10)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(212, 28)
        Me.Panel9.TabIndex = 566
        '
        'Label_consecutivo
        '
        Me.Label_consecutivo.AllowDrop = True
        Me.Label_consecutivo.BackColor = System.Drawing.Color.Transparent
        Me.Label_consecutivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_consecutivo.ForeColor = System.Drawing.Color.Red
        Me.Label_consecutivo.Location = New System.Drawing.Point(7, 4)
        Me.Label_consecutivo.Name = "Label_consecutivo"
        Me.Label_consecutivo.Size = New System.Drawing.Size(198, 20)
        Me.Label_consecutivo.TabIndex = 546
        Me.Label_consecutivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Panel7.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.cuadro_blanco
        Me.Panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel7.Controls.Add(Me.Label_estado_gasto)
        Me.Panel7.Location = New System.Drawing.Point(147, 75)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(212, 28)
        Me.Panel7.TabIndex = 568
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel15)
        Me.Panel5.Controls.Add(Me.Label26)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Controls.Add(Me.Label34)
        Me.Panel5.Controls.Add(Me.Label22)
        Me.Panel5.Controls.Add(Me.Label21)
        Me.Panel5.Controls.Add(Me.Panel9)
        Me.Panel5.Controls.Add(Me.Panel8)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Location = New System.Drawing.Point(595, 91)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(364, 150)
        Me.Panel5.TabIndex = 942
        '
        'Label34
        '
        Me.Label34.AllowDrop = True
        Me.Label34.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(181, -78)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(114, 16)
        Me.Label34.TabIndex = 904
        Me.Label34.Text = "Medio de Pago"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label34.Visible = False
        '
        'Label22
        '
        Me.Label22.AllowDrop = True
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(93, 47)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(51, 16)
        Me.Label22.TabIndex = 564
        Me.Label22.Text = "Fecha"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.AllowDrop = True
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(40, 81)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(104, 16)
        Me.Label21.TabIndex = 565
        Me.Label21.Text = "Estado Actual"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel8
        '
        Me.Panel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel8.BackColor = System.Drawing.Color.Transparent
        Me.Panel8.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.cuadro_blanco
        Me.Panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel8.Controls.Add(Me.Label_fecha)
        Me.Panel8.Location = New System.Drawing.Point(147, 42)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(212, 28)
        Me.Panel8.TabIndex = 567
        '
        'Timer_MEDIO_PAGO
        '
        Me.Timer_MEDIO_PAGO.Interval = 300
        '
        'Timer_CLIENTE
        '
        Me.Timer_CLIENTE.Interval = 300
        '
        'Label3
        '
        Me.Label3.AllowDrop = True
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(9, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 12)
        Me.Label3.TabIndex = 758
        Me.Label3.Text = "Documento"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AllowDrop = True
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(135, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(9, 12)
        Me.Label7.TabIndex = 757
        Me.Label7.Text = "-"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AllowDrop = True
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(147, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 12)
        Me.Label6.TabIndex = 755
        Me.Label6.Text = "DV"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox_dv_cliente
        '
        Me.TextBox_dv_cliente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox_dv_cliente.BackColor = System.Drawing.Color.White
        Me.TextBox_dv_cliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_dv_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox_dv_cliente.ForeColor = System.Drawing.Color.Black
        Me.TextBox_dv_cliente.Location = New System.Drawing.Point(147, 64)
        Me.TextBox_dv_cliente.Name = "TextBox_dv_cliente"
        Me.TextBox_dv_cliente.Size = New System.Drawing.Size(20, 16)
        Me.TextBox_dv_cliente.TabIndex = 752
        '
        'COMBO_NOM_CLIENTE_FILTRO
        '
        Me.COMBO_NOM_CLIENTE_FILTRO.BackColor = System.Drawing.Color.White
        Me.COMBO_NOM_CLIENTE_FILTRO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.COMBO_NOM_CLIENTE_FILTRO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.COMBO_NOM_CLIENTE_FILTRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.COMBO_NOM_CLIENTE_FILTRO.ForeColor = System.Drawing.Color.Black
        Me.COMBO_NOM_CLIENTE_FILTRO.FormattingEnabled = True
        Me.COMBO_NOM_CLIENTE_FILTRO.Location = New System.Drawing.Point(239, 14)
        Me.COMBO_NOM_CLIENTE_FILTRO.Name = "COMBO_NOM_CLIENTE_FILTRO"
        Me.COMBO_NOM_CLIENTE_FILTRO.Size = New System.Drawing.Size(324, 21)
        Me.COMBO_NOM_CLIENTE_FILTRO.TabIndex = 924
        '
        'Label4
        '
        Me.Label4.AllowDrop = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(4, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 16)
        Me.Label4.TabIndex = 925
        Me.Label4.Text = "Beneficiario"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.AllowDrop = True
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Gray
        Me.Label20.Location = New System.Drawing.Point(9, 87)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(48, 12)
        Me.Label20.TabIndex = 578
        Me.Label20.Text = "Teléfono"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.AllowDrop = True
        Me.Label27.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Gray
        Me.Label27.Location = New System.Drawing.Point(183, 51)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(114, 12)
        Me.Label27.TabIndex = 539
        Me.Label27.Text = "Nombre/Razon Social"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuCards1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.Tomato
        Me.BunifuCards1.Controls.Add(Me.COMBO_NOM_CLIENTE_FILTRO)
        Me.BunifuCards1.Controls.Add(Me.Label4)
        Me.BunifuCards1.Controls.Add(Me.TEXTBOX_BUSCAR_PROV)
        Me.BunifuCards1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(573, 45)
        Me.BunifuCards1.TabIndex = 756
        '
        'TEXTBOX_BUSCAR_PROV
        '
        Me.TEXTBOX_BUSCAR_PROV.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.TEXTBOX_BUSCAR_PROV.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TEXTBOX_BUSCAR_PROV.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.TEXTBOX_BUSCAR_PROV.ForeColor = System.Drawing.Color.White
        Me.TEXTBOX_BUSCAR_PROV.HintForeColor = System.Drawing.Color.White
        Me.TEXTBOX_BUSCAR_PROV.HintText = ""
        Me.TEXTBOX_BUSCAR_PROV.isPassword = False
        Me.TEXTBOX_BUSCAR_PROV.LineFocusedColor = System.Drawing.Color.SlateGray
        Me.TEXTBOX_BUSCAR_PROV.LineIdleColor = System.Drawing.Color.White
        Me.TEXTBOX_BUSCAR_PROV.LineMouseHoverColor = System.Drawing.Color.LightSlateGray
        Me.TEXTBOX_BUSCAR_PROV.LineThickness = 2
        Me.TEXTBOX_BUSCAR_PROV.Location = New System.Drawing.Point(15, 16)
        Me.TEXTBOX_BUSCAR_PROV.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.TEXTBOX_BUSCAR_PROV.Name = "TEXTBOX_BUSCAR_PROV"
        Me.TEXTBOX_BUSCAR_PROV.Size = New System.Drawing.Size(189, 26)
        Me.TEXTBOX_BUSCAR_PROV.TabIndex = 990
        Me.TEXTBOX_BUSCAR_PROV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel_cliente
        '
        Me.Panel_cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel_cliente.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.cuadro_blanco
        Me.Panel_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_cliente.Controls.Add(Me.Label3)
        Me.Panel_cliente.Controls.Add(Me.Label7)
        Me.Panel_cliente.Controls.Add(Me.Label6)
        Me.Panel_cliente.Controls.Add(Me.TextBox_dv_cliente)
        Me.Panel_cliente.Controls.Add(Me.Label20)
        Me.Panel_cliente.Controls.Add(Me.Label29)
        Me.Panel_cliente.Controls.Add(Me.Label27)
        Me.Panel_cliente.Controls.Add(Me.BunifuCards1)
        Me.Panel_cliente.Controls.Add(Me.FlowLayoutPanel2)
        Me.Panel_cliente.Controls.Add(Me.Label_info_cliente)
        Me.Panel_cliente.Controls.Add(Me.TXT_DIR_CLIENTE)
        Me.Panel_cliente.Controls.Add(Me.TXT_DOC_CLIENTE)
        Me.Panel_cliente.Controls.Add(Me.TXT_NOM_CLIENTE)
        Me.Panel_cliente.Controls.Add(Me.TXT_TELS_CLIENTE)
        Me.Panel_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_cliente.Location = New System.Drawing.Point(16, 86)
        Me.Panel_cliente.Name = "Panel_cliente"
        Me.Panel_cliente.Size = New System.Drawing.Size(573, 158)
        Me.Panel_cliente.TabIndex = 943
        '
        'Label29
        '
        Me.Label29.AllowDrop = True
        Me.Label29.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Gray
        Me.Label29.Location = New System.Drawing.Point(184, 87)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(53, 12)
        Me.Label29.TabIndex = 579
        Me.Label29.Text = "Dirección"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXT_DIR_CLIENTE
        '
        Me.TXT_DIR_CLIENTE.BackColor = System.Drawing.Color.White
        Me.TXT_DIR_CLIENTE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_DIR_CLIENTE.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_DIR_CLIENTE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_DIR_CLIENTE.HintForeColor = System.Drawing.Color.Empty
        Me.TXT_DIR_CLIENTE.HintText = ""
        Me.TXT_DIR_CLIENTE.isPassword = False
        Me.TXT_DIR_CLIENTE.LineFocusedColor = System.Drawing.Color.Blue
        Me.TXT_DIR_CLIENTE.LineIdleColor = System.Drawing.Color.Gray
        Me.TXT_DIR_CLIENTE.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TXT_DIR_CLIENTE.LineThickness = 3
        Me.TXT_DIR_CLIENTE.Location = New System.Drawing.Point(186, 98)
        Me.TXT_DIR_CLIENTE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TXT_DIR_CLIENTE.Name = "TXT_DIR_CLIENTE"
        Me.TXT_DIR_CLIENTE.Size = New System.Drawing.Size(312, 21)
        Me.TXT_DIR_CLIENTE.TabIndex = 989
        Me.TXT_DIR_CLIENTE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_DOC_CLIENTE
        '
        Me.TXT_DOC_CLIENTE.BackColor = System.Drawing.Color.White
        Me.TXT_DOC_CLIENTE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_DOC_CLIENTE.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TXT_DOC_CLIENTE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_DOC_CLIENTE.HintForeColor = System.Drawing.Color.Empty
        Me.TXT_DOC_CLIENTE.HintText = ""
        Me.TXT_DOC_CLIENTE.isPassword = False
        Me.TXT_DOC_CLIENTE.LineFocusedColor = System.Drawing.Color.Blue
        Me.TXT_DOC_CLIENTE.LineIdleColor = System.Drawing.Color.Gray
        Me.TXT_DOC_CLIENTE.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TXT_DOC_CLIENTE.LineThickness = 3
        Me.TXT_DOC_CLIENTE.Location = New System.Drawing.Point(9, 62)
        Me.TXT_DOC_CLIENTE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TXT_DOC_CLIENTE.Name = "TXT_DOC_CLIENTE"
        Me.TXT_DOC_CLIENTE.Size = New System.Drawing.Size(124, 23)
        Me.TXT_DOC_CLIENTE.TabIndex = 986
        Me.TXT_DOC_CLIENTE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_NOM_CLIENTE
        '
        Me.TXT_NOM_CLIENTE.BackColor = System.Drawing.Color.White
        Me.TXT_NOM_CLIENTE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NOM_CLIENTE.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TXT_NOM_CLIENTE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_NOM_CLIENTE.HintForeColor = System.Drawing.Color.Empty
        Me.TXT_NOM_CLIENTE.HintText = ""
        Me.TXT_NOM_CLIENTE.isPassword = False
        Me.TXT_NOM_CLIENTE.LineFocusedColor = System.Drawing.Color.Blue
        Me.TXT_NOM_CLIENTE.LineIdleColor = System.Drawing.Color.Gray
        Me.TXT_NOM_CLIENTE.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TXT_NOM_CLIENTE.LineThickness = 3
        Me.TXT_NOM_CLIENTE.Location = New System.Drawing.Point(186, 62)
        Me.TXT_NOM_CLIENTE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TXT_NOM_CLIENTE.Name = "TXT_NOM_CLIENTE"
        Me.TXT_NOM_CLIENTE.Size = New System.Drawing.Size(312, 23)
        Me.TXT_NOM_CLIENTE.TabIndex = 987
        Me.TXT_NOM_CLIENTE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_TELS_CLIENTE
        '
        Me.TXT_TELS_CLIENTE.BackColor = System.Drawing.Color.White
        Me.TXT_TELS_CLIENTE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_TELS_CLIENTE.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_TELS_CLIENTE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_TELS_CLIENTE.HintForeColor = System.Drawing.Color.Empty
        Me.TXT_TELS_CLIENTE.HintText = ""
        Me.TXT_TELS_CLIENTE.isPassword = False
        Me.TXT_TELS_CLIENTE.LineFocusedColor = System.Drawing.Color.Blue
        Me.TXT_TELS_CLIENTE.LineIdleColor = System.Drawing.Color.Gray
        Me.TXT_TELS_CLIENTE.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TXT_TELS_CLIENTE.LineThickness = 3
        Me.TXT_TELS_CLIENTE.Location = New System.Drawing.Point(9, 98)
        Me.TXT_TELS_CLIENTE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TXT_TELS_CLIENTE.Name = "TXT_TELS_CLIENTE"
        Me.TXT_TELS_CLIENTE.Size = New System.Drawing.Size(161, 21)
        Me.TXT_TELS_CLIENTE.TabIndex = 988
        Me.TXT_TELS_CLIENTE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuElipse6
        '
        Me.BunifuElipse6.ElipseRadius = 5
        Me.BunifuElipse6.TargetControl = Me.ComboBox_tipo_egreso
        '
        'Timer_nuevo
        '
        Me.Timer_nuevo.Interval = 300
        '
        'TextBox_retenciones
        '
        Me.TextBox_retenciones.BackColor = System.Drawing.Color.LightGray
        Me.TextBox_retenciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_retenciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_retenciones.ForeColor = System.Drawing.Color.Black
        Me.TextBox_retenciones.Location = New System.Drawing.Point(136, 76)
        Me.TextBox_retenciones.Name = "TextBox_retenciones"
        Me.TextBox_retenciones.Size = New System.Drawing.Size(186, 19)
        Me.TextBox_retenciones.TabIndex = 955
        Me.TextBox_retenciones.Text = "0"
        Me.TextBox_retenciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label24
        '
        Me.Label24.AllowDrop = True
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.25!)
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(31, 76)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(96, 16)
        Me.Label24.TabIndex = 956
        Me.Label24.Text = "-Retenciones"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form_ntcr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(974, 573)
        Me.Controls.Add(Me.Panel_dock)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel_cliente)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_ntcr"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_ntcr"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.ContextMenuStrip_LOAD_PUC.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel_dock.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.BunifuCards1.ResumeLayout(False)
        Me.Panel_cliente.ResumeLayout(False)
        Me.Panel_cliente.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button_gastos As Button
    Friend WithEvents Btn_salir As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents ComboBox_cxp As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox_concepto As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox_subtotal As TextBox
    Friend WithEvents TextBox_impuestos As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox_valorgasto As TextBox
    Friend WithEvents Button_concepto_op As Button
    Friend WithEvents ComboBox_tipo_egreso As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_referencia As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button_anular As Button
    Friend WithEvents Button_guardar As Button
    Friend WithEvents Panel_dock As Panel
    Friend WithEvents Btn_nuevo_mov As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents ComboBox_MEDIOPAGO As ComboBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label_consecutivo As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label_fecha As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label_estado_gasto As Label
    Friend WithEvents Panel_cliente As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox_dv_cliente As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents BunifuCards1 As ns1.BunifuCards
    Friend WithEvents COMBO_NOM_CLIENTE_FILTRO As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Button_REFRESH As Button
    Friend WithEvents Button_NUEVO_CLI As Button
    Friend WithEvents Button_EDIT_CLI As Button
    Friend WithEvents Button_SAVE_CLI As Button
    Friend WithEvents Label_info_cliente As Label
    Friend WithEvents BunifuElipse4 As ns1.BunifuElipse
    Friend WithEvents BunifuElipse5 As ns1.BunifuElipse
    Friend WithEvents BunifuElipse3 As ns1.BunifuElipse
    Friend WithEvents ConfigurarCuentasDeContabilidadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip_LOAD_PUC As ContextMenuStrip
    Friend WithEvents BunifuElipse2 As ns1.BunifuElipse
    Friend WithEvents Timer_factura_info As Timer
    Friend WithEvents Timer_cuentapuc_concepto As Timer
    Friend WithEvents Timer_VER As Timer
    Friend WithEvents Timer_MEDIO_PAGO As Timer
    Friend WithEvents Timer_CLIENTE As Timer
    Friend WithEvents BunifuElipse6 As ns1.BunifuElipse
    Friend WithEvents Timer_nuevo As Timer
    Friend WithEvents TEXTBOX_BUSCAR_PROV As ns1.BunifuMaterialTextbox
    Friend WithEvents TXT_DIR_CLIENTE As ns1.BunifuMaterialTextbox
    Friend WithEvents TXT_DOC_CLIENTE As ns1.BunifuMaterialTextbox
    Friend WithEvents TXT_NOM_CLIENTE As ns1.BunifuMaterialTextbox
    Friend WithEvents TXT_TELS_CLIENTE As ns1.BunifuMaterialTextbox
    Friend WithEvents TextBox_valor As ns1.BunifuMaterialTextbox
    Friend WithEvents TextBox_imp_a_aplicar As TextBox
    Friend WithEvents Button_aplica_imp As Button
    Friend WithEvents Label28 As Label
    Friend WithEvents ComboBox_impuestos As ComboBox
    Friend WithEvents TextBox_ret_a_aplicar As TextBox
    Friend WithEvents Button_aplica_ret As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents ComboBox_RETENCIONES As ComboBox
    Friend WithEvents TextBox_retenciones As TextBox
    Friend WithEvents Label24 As Label
End Class
