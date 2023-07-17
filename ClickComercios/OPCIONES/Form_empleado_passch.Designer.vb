<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_empleado_passch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_empleado_passch))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TextBox_actual = New ns1.BunifuMaterialTextbox()
        Me.Panel_titlebar = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_nueva = New ns1.BunifuMaterialTextbox()
        Me.button_crear = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_nueva2 = New ns1.BunifuMaterialTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label_empnom = New System.Windows.Forms.Label()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_titlebar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(96, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(288, 37)
        Me.Label4.TabIndex = 436
        Me.Label4.Text = "Cambio de Contraseña"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.MiClickDerecho.My.Resources.Resources.employee
        Me.PictureBox4.Location = New System.Drawing.Point(11, 20)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(83, 73)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 634
        Me.PictureBox4.TabStop = False
        '
        'Label24
        '
        Me.Label24.AllowDrop = True
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(33, 106)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(123, 15)
        Me.Label24.TabIndex = 672
        Me.Label24.Text = "Contraseña Actual"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox_actual
        '
        Me.TextBox_actual.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox_actual.Font = New System.Drawing.Font("Century Gothic", 10.75!)
        Me.TextBox_actual.ForeColor = System.Drawing.Color.Gray
        Me.TextBox_actual.HintForeColor = System.Drawing.Color.Empty
        Me.TextBox_actual.HintText = ""
        Me.TextBox_actual.isPassword = True
        Me.TextBox_actual.LineFocusedColor = System.Drawing.Color.Blue
        Me.TextBox_actual.LineIdleColor = System.Drawing.Color.Gray
        Me.TextBox_actual.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TextBox_actual.LineThickness = 2
        Me.TextBox_actual.Location = New System.Drawing.Point(36, 116)
        Me.TextBox_actual.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_actual.Name = "TextBox_actual"
        Me.TextBox_actual.Size = New System.Drawing.Size(273, 32)
        Me.TextBox_actual.TabIndex = 673
        Me.TextBox_actual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel_titlebar
        '
        Me.Panel_titlebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel_titlebar.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.banner9
        Me.Panel_titlebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_titlebar.Controls.Add(Me.Label4)
        Me.Panel_titlebar.Location = New System.Drawing.Point(0, 0)
        Me.Panel_titlebar.Name = "Panel_titlebar"
        Me.Panel_titlebar.Size = New System.Drawing.Size(526, 67)
        Me.Panel_titlebar.TabIndex = 674
        '
        'Label1
        '
        Me.Label1.AllowDrop = True
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(33, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 15)
        Me.Label1.TabIndex = 675
        Me.Label1.Text = "Nueva Contraseña"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_nueva
        '
        Me.TextBox_nueva.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox_nueva.Font = New System.Drawing.Font("Century Gothic", 10.75!)
        Me.TextBox_nueva.ForeColor = System.Drawing.Color.Black
        Me.TextBox_nueva.HintForeColor = System.Drawing.Color.Empty
        Me.TextBox_nueva.HintText = ""
        Me.TextBox_nueva.isPassword = True
        Me.TextBox_nueva.LineFocusedColor = System.Drawing.Color.Blue
        Me.TextBox_nueva.LineIdleColor = System.Drawing.Color.Black
        Me.TextBox_nueva.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TextBox_nueva.LineThickness = 2
        Me.TextBox_nueva.Location = New System.Drawing.Point(36, 190)
        Me.TextBox_nueva.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_nueva.Name = "TextBox_nueva"
        Me.TextBox_nueva.Size = New System.Drawing.Size(273, 32)
        Me.TextBox_nueva.TabIndex = 676
        Me.TextBox_nueva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.button_crear.Image = Global.MiClickDerecho.My.Resources.Resources.ok_transico
        Me.button_crear.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.button_crear.Location = New System.Drawing.Point(363, 222)
        Me.button_crear.Name = "button_crear"
        Me.button_crear.Size = New System.Drawing.Size(141, 53)
        Me.button_crear.TabIndex = 677
        Me.button_crear.Text = "Cambiar"
        Me.button_crear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.button_crear.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AllowDrop = True
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(33, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 15)
        Me.Label2.TabIndex = 678
        Me.Label2.Text = "Confirma la Contraseña"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_nueva2
        '
        Me.TextBox_nueva2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox_nueva2.Font = New System.Drawing.Font("Century Gothic", 10.75!)
        Me.TextBox_nueva2.ForeColor = System.Drawing.Color.Black
        Me.TextBox_nueva2.HintForeColor = System.Drawing.Color.Empty
        Me.TextBox_nueva2.HintText = ""
        Me.TextBox_nueva2.isPassword = True
        Me.TextBox_nueva2.LineFocusedColor = System.Drawing.Color.Blue
        Me.TextBox_nueva2.LineIdleColor = System.Drawing.Color.Black
        Me.TextBox_nueva2.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TextBox_nueva2.LineThickness = 2
        Me.TextBox_nueva2.Location = New System.Drawing.Point(36, 238)
        Me.TextBox_nueva2.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_nueva2.Name = "TextBox_nueva2"
        Me.TextBox_nueva2.Size = New System.Drawing.Size(273, 32)
        Me.TextBox_nueva2.TabIndex = 679
        Me.TextBox_nueva2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AllowDrop = True
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label3.Location = New System.Drawing.Point(100, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(414, 24)
        Me.Label3.TabIndex = 680
        Me.Label3.Text = "."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_empnom
        '
        Me.Label_empnom.AllowDrop = True
        Me.Label_empnom.AutoSize = True
        Me.Label_empnom.BackColor = System.Drawing.Color.Transparent
        Me.Label_empnom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label_empnom.ForeColor = System.Drawing.Color.Black
        Me.Label_empnom.Location = New System.Drawing.Point(98, 75)
        Me.Label_empnom.Name = "Label_empnom"
        Me.Label_empnom.Size = New System.Drawing.Size(71, 15)
        Me.Label_empnom.TabIndex = 681
        Me.Label_empnom.Text = "empleado"
        Me.Label_empnom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form_empleado_passch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(526, 287)
        Me.Controls.Add(Me.Label_empnom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox_nueva2)
        Me.Controls.Add(Me.button_crear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_nueva)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Panel_titlebar)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.TextBox_actual)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_empleado_passch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_titlebar.ResumeLayout(False)
        Me.Panel_titlebar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label24 As Label
    Friend WithEvents TextBox_actual As ns1.BunifuMaterialTextbox
    Friend WithEvents Panel_titlebar As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_nueva As ns1.BunifuMaterialTextbox
    Friend WithEvents button_crear As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_nueva2 As ns1.BunifuMaterialTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label_empnom As Label
End Class
