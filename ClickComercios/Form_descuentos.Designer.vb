<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_descuentos
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
        Me.TextBox_nombrepord = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Buttonsalir = New System.Windows.Forms.Button()
        Me.Button_almacen = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox_nombrepord
        '
        Me.TextBox_nombrepord.BackColor = System.Drawing.Color.White
        Me.TextBox_nombrepord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_nombrepord.Enabled = False
        Me.TextBox_nombrepord.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_nombrepord.ForeColor = System.Drawing.Color.Black
        Me.TextBox_nombrepord.Location = New System.Drawing.Point(38, 111)
        Me.TextBox_nombrepord.Name = "TextBox_nombrepord"
        Me.TextBox_nombrepord.Size = New System.Drawing.Size(290, 27)
        Me.TextBox_nombrepord.TabIndex = 397
        Me.TextBox_nombrepord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(37, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 13)
        Me.Label2.TabIndex = 398
        Me.Label2.Text = "Nombre Descuento"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(37, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 399
        Me.Label1.Text = "Tipo de Descuento"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(50, 176)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(213, 24)
        Me.RadioButton1.TabIndex = 400
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Descuento en Valor ($)"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(293, 176)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(262, 24)
        Me.RadioButton2.TabIndex = 401
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Descuento en Porcentaje (%)"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(51, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 402
        Me.Label3.Text = "Valor Porcentaje"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(176, 306)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(109, 24)
        Me.RadioButton3.TabIndex = 405
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Propducto"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(60, 306)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(89, 24)
        Me.RadioButton4.TabIndex = 404
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Factura"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(47, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 403
        Me.Label4.Text = "Descuento Para:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(158, 224)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(114, 27)
        Me.TextBox1.TabIndex = 406
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel2.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.banner9
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Buttonsalir)
        Me.Panel2.Controls.Add(Me.Button_almacen)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(649, 38)
        Me.Panel2.TabIndex = 654
        '
        'Buttonsalir
        '
        Me.Buttonsalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Buttonsalir.BackColor = System.Drawing.Color.Transparent
        Me.Buttonsalir.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.CANCEL
        Me.Buttonsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Buttonsalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Buttonsalir.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Buttonsalir.FlatAppearance.BorderSize = 0
        Me.Buttonsalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Buttonsalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Buttonsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buttonsalir.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonsalir.ForeColor = System.Drawing.Color.Black
        Me.Buttonsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Buttonsalir.Location = New System.Drawing.Point(610, 4)
        Me.Buttonsalir.Name = "Buttonsalir"
        Me.Buttonsalir.Size = New System.Drawing.Size(30, 30)
        Me.Buttonsalir.TabIndex = 479
        Me.Buttonsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Buttonsalir.UseVisualStyleBackColor = False
        '
        'Button_almacen
        '
        Me.Button_almacen.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button_almacen.BackColor = System.Drawing.Color.Transparent
        Me.Button_almacen.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.d5e5d037b0b005f
        Me.Button_almacen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_almacen.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.Button_almacen.FlatAppearance.BorderSize = 0
        Me.Button_almacen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_almacen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_almacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_almacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_almacen.ForeColor = System.Drawing.Color.White
        Me.Button_almacen.Location = New System.Drawing.Point(5, 5)
        Me.Button_almacen.Name = "Button_almacen"
        Me.Button_almacen.Size = New System.Drawing.Size(38, 33)
        Me.Button_almacen.TabIndex = 394
        Me.Button_almacen.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_almacen.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(47, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(231, 26)
        Me.Label5.TabIndex = 393
        Me.Label5.Text = "Descuentos en Ventas"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form_descuentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 486)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_nombrepord)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_descuentos"
        Me.Text = "Form_descentos"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_nombrepord As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Buttonsalir As Button
    Friend WithEvents Button_almacen As Button
    Friend WithEvents Label5 As Label
End Class
