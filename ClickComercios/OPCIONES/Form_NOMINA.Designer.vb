<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_nomina
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_nomina))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button_export_pdf = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Buttoninformes = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ComboBoX_fechaMES = New MetroFramework.Controls.MetroComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RadioButton_mes = New System.Windows.Forms.RadioButton()
        Me.RadioButton_fecha = New System.Windows.Forms.RadioButton()
        Me.datagridview1 = New MetroFramework.Controls.MetroGrid()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.datagridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(204, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Empleado"
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.Black
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(203, 130)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(271, 23)
        Me.ComboBox1.TabIndex = 89
        '
        'Button_export_pdf
        '
        Me.Button_export_pdf.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_export_pdf.BackColor = System.Drawing.Color.Transparent
        Me.Button_export_pdf.BackgroundImage = CType(resources.GetObject("Button_export_pdf.BackgroundImage"), System.Drawing.Image)
        Me.Button_export_pdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_export_pdf.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_export_pdf.FlatAppearance.BorderSize = 0
        Me.Button_export_pdf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_export_pdf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_export_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_export_pdf.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_export_pdf.ForeColor = System.Drawing.Color.Black
        Me.Button_export_pdf.Image = Global.MiClickDerecho.My.Resources.Resources.agregar
        Me.Button_export_pdf.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_export_pdf.Location = New System.Drawing.Point(576, 109)
        Me.Button_export_pdf.Name = "Button_export_pdf"
        Me.Button_export_pdf.Size = New System.Drawing.Size(90, 45)
        Me.Button_export_pdf.TabIndex = 267
        Me.Button_export_pdf.Text = "Nuevo"
        Me.Button_export_pdf.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_export_pdf.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = Global.MiClickDerecho.My.Resources.Resources.viewicone
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(670, 109)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 45)
        Me.Button1.TabIndex = 268
        Me.Button1.Text = "Consultar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.tile_back
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Buttoninformes)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(-1, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(872, 70)
        Me.Panel1.TabIndex = 424
        '
        'Buttoninformes
        '
        Me.Buttoninformes.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Buttoninformes.BackColor = System.Drawing.Color.Transparent
        Me.Buttoninformes.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.iconocnomina
        Me.Buttoninformes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Buttoninformes.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Buttoninformes.FlatAppearance.BorderSize = 0
        Me.Buttoninformes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Buttoninformes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Buttoninformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buttoninformes.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttoninformes.ForeColor = System.Drawing.Color.White
        Me.Buttoninformes.Location = New System.Drawing.Point(5, 6)
        Me.Buttoninformes.Name = "Buttoninformes"
        Me.Buttoninformes.Size = New System.Drawing.Size(60, 57)
        Me.Buttoninformes.TabIndex = 394
        Me.Buttoninformes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Buttoninformes.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB Demi", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(71, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(311, 43)
        Me.Label2.TabIndex = 393
        Me.Label2.Text = "Pagos de Nómina"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MiClickDerecho.My.Resources.Resources.filtering
        Me.PictureBox1.Location = New System.Drawing.Point(18, 111)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 548
        Me.PictureBox1.TabStop = False
        '
        'ComboBoX_fechaMES
        '
        Me.ComboBoX_fechaMES.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ComboBoX_fechaMES.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.ComboBoX_fechaMES.FontWeight = MetroFramework.MetroComboBoxWeight.Light
        Me.ComboBoX_fechaMES.FormattingEnabled = True
        Me.ComboBoX_fechaMES.ItemHeight = 19
        Me.ComboBoX_fechaMES.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.ComboBoX_fechaMES.Location = New System.Drawing.Point(57, 128)
        Me.ComboBoX_fechaMES.Name = "ComboBoX_fechaMES"
        Me.ComboBoX_fechaMES.Size = New System.Drawing.Size(141, 25)
        Me.ComboBoX_fechaMES.TabIndex = 550
        Me.ComboBoX_fechaMES.UseSelectable = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RadioButton_mes)
        Me.Panel2.Controls.Add(Me.RadioButton_fecha)
        Me.Panel2.Location = New System.Drawing.Point(56, 108)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(133, 22)
        Me.Panel2.TabIndex = 551
        '
        'RadioButton_mes
        '
        Me.RadioButton_mes.AutoSize = True
        Me.RadioButton_mes.Checked = True
        Me.RadioButton_mes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_mes.Location = New System.Drawing.Point(3, 2)
        Me.RadioButton_mes.Name = "RadioButton_mes"
        Me.RadioButton_mes.Size = New System.Drawing.Size(48, 17)
        Me.RadioButton_mes.TabIndex = 549
        Me.RadioButton_mes.TabStop = True
        Me.RadioButton_mes.Text = "Mes"
        Me.RadioButton_mes.UseVisualStyleBackColor = True
        '
        'RadioButton_fecha
        '
        Me.RadioButton_fecha.AutoSize = True
        Me.RadioButton_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_fecha.Location = New System.Drawing.Point(56, 2)
        Me.RadioButton_fecha.Name = "RadioButton_fecha"
        Me.RadioButton_fecha.Size = New System.Drawing.Size(60, 17)
        Me.RadioButton_fecha.TabIndex = 548
        Me.RadioButton_fecha.Text = "Fecha"
        Me.RadioButton_fecha.UseVisualStyleBackColor = True
        Me.RadioButton_fecha.Visible = False
        '
        'datagridview1
        '
        Me.datagridview1.AllowUserToAddRows = False
        Me.datagridview1.AllowUserToDeleteRows = False
        Me.datagridview1.AllowUserToOrderColumns = True
        Me.datagridview1.AllowUserToResizeRows = False
        Me.datagridview1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datagridview1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridview1.BackgroundColor = System.Drawing.Color.White
        Me.datagridview1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datagridview1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.datagridview1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridview1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridview1.ColumnHeadersHeight = 28
        Me.datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridview1.DefaultCellStyle = DataGridViewCellStyle2
        Me.datagridview1.EnableHeadersVisualStyles = False
        Me.datagridview1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.datagridview1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagridview1.Location = New System.Drawing.Point(12, 13)
        Me.datagridview1.Name = "datagridview1"
        Me.datagridview1.ReadOnly = True
        Me.datagridview1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridview1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.datagridview1.RowHeadersVisible = False
        Me.datagridview1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridview1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.datagridview1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.datagridview1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.datagridview1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.datagridview1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridview1.Size = New System.Drawing.Size(815, 396)
        Me.datagridview1.TabIndex = 552
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.cuadro_de_text3
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.datagridview1)
        Me.Panel3.Location = New System.Drawing.Point(14, 156)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(839, 423)
        Me.Panel3.TabIndex = 553
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = Global.MiClickDerecho.My.Resources.Resources.salir_de_mi
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(774, 109)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 45)
        Me.Button2.TabIndex = 554
        Me.Button2.Text = "Salir"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form_nomina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 589)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ComboBoX_fechaMES)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button_export_pdf)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "Form_nomina"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.datagridview1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button_export_pdf As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Buttoninformes As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComboBoX_fechaMES As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RadioButton_mes As RadioButton
    Friend WithEvents RadioButton_fecha As RadioButton
    Friend WithEvents datagridview1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button2 As Button
End Class
