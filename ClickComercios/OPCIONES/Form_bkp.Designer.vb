<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_bkp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_bkp))
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label_ok = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.BackWorker_bkp = New System.ComponentModel.BackgroundWorker()
        Me.PictureBox_loader = New System.Windows.Forms.PictureBox()
        Me.button_crear = New System.Windows.Forms.Button()
        Me.PictureBox_ok = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel_titlebar = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox_loader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_ok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_titlebar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label24
        '
        Me.Label24.AllowDrop = True
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label24.ForeColor = System.Drawing.Color.DimGray
        Me.Label24.Location = New System.Drawing.Point(12, 123)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(226, 15)
        Me.Label24.TabIndex = 679
        Me.Label24.Text = "Guardar la copia de seguridad en:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AllowDrop = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(12, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(518, 40)
        Me.Label1.TabIndex = 682
        Me.Label1.Text = "C:\miclickderecho\backup\"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_ok
        '
        Me.Label_ok.AllowDrop = True
        Me.Label_ok.AutoSize = True
        Me.Label_ok.BackColor = System.Drawing.Color.Transparent
        Me.Label_ok.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ok.ForeColor = System.Drawing.Color.Black
        Me.Label_ok.Location = New System.Drawing.Point(29, 299)
        Me.Label_ok.Name = "Label_ok"
        Me.Label_ok.Size = New System.Drawing.Size(187, 16)
        Me.Label_ok.TabIndex = 684
        Me.Label_ok.Text = "Se Creó la copia de seguridad"
        Me.Label_ok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label_ok.Visible = False
        '
        'BackWorker_bkp
        '
        '
        'PictureBox_loader
        '
        Me.PictureBox_loader.Image = Global.MiClickDerecho.My.Resources.Resources.ajaxloader
        Me.PictureBox_loader.Location = New System.Drawing.Point(15, 205)
        Me.PictureBox_loader.Name = "PictureBox_loader"
        Me.PictureBox_loader.Size = New System.Drawing.Size(515, 41)
        Me.PictureBox_loader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_loader.TabIndex = 686
        Me.PictureBox_loader.TabStop = False
        Me.PictureBox_loader.Visible = False
        '
        'button_crear
        '
        Me.button_crear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button_crear.BackColor = System.Drawing.Color.Transparent
        Me.button_crear.BackgroundImage = CType(resources.GetObject("button_crear.BackgroundImage"), System.Drawing.Image)
        Me.button_crear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button_crear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_crear.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.button_crear.FlatAppearance.BorderSize = 0
        Me.button_crear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.button_crear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.button_crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_crear.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_crear.ForeColor = System.Drawing.Color.White
        Me.button_crear.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.button_crear.Location = New System.Drawing.Point(374, 274)
        Me.button_crear.Name = "button_crear"
        Me.button_crear.Size = New System.Drawing.Size(141, 53)
        Me.button_crear.TabIndex = 681
        Me.button_crear.Text = "Hacer Backup"
        Me.button_crear.UseVisualStyleBackColor = False
        '
        'PictureBox_ok
        '
        Me.PictureBox_ok.Image = Global.MiClickDerecho.My.Resources.Resources.oktrans
        Me.PictureBox_ok.Location = New System.Drawing.Point(222, 274)
        Me.PictureBox_ok.Name = "PictureBox_ok"
        Me.PictureBox_ok.Size = New System.Drawing.Size(39, 41)
        Me.PictureBox_ok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_ok.TabIndex = 685
        Me.PictureBox_ok.TabStop = False
        Me.PictureBox_ok.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.MiClickDerecho.My.Resources.Resources.backup
        Me.PictureBox4.Location = New System.Drawing.Point(15, 17)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(83, 84)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 678
        Me.PictureBox4.TabStop = False
        '
        'Panel_titlebar
        '
        Me.Panel_titlebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel_titlebar.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.banner9
        Me.Panel_titlebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_titlebar.Controls.Add(Me.Label4)
        Me.Panel_titlebar.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_titlebar.Location = New System.Drawing.Point(0, 0)
        Me.Panel_titlebar.Name = "Panel_titlebar"
        Me.Panel_titlebar.Size = New System.Drawing.Size(542, 67)
        Me.Panel_titlebar.TabIndex = 680
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(104, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(252, 37)
        Me.Label4.TabIndex = 436
        Me.Label4.Text = "Copia de Seguridad"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form_bkp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(542, 340)
        Me.Controls.Add(Me.PictureBox_loader)
        Me.Controls.Add(Me.button_crear)
        Me.Controls.Add(Me.PictureBox_ok)
        Me.Controls.Add(Me.Label_ok)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Panel_titlebar)
        Me.Controls.Add(Me.Label24)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_bkp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.PictureBox_loader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_ok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_titlebar.ResumeLayout(False)
        Me.Panel_titlebar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel_titlebar As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents button_crear As Button
    Friend WithEvents Label24 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label_ok As Label
    Friend WithEvents PictureBox_ok As PictureBox
    Friend WithEvents PictureBox_loader As PictureBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents BackWorker_bkp As System.ComponentModel.BackgroundWorker
End Class
