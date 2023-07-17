<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_pucniffselect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_pucniffselect))
        Me.TreeView_niif = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label_cuenta = New System.Windows.Forms.Label()
        Me.Label_codigo = New System.Windows.Forms.Label()
        Me.Button_regresar_niif = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TreeView_niif
        '
        Me.TreeView_niif.BackColor = System.Drawing.Color.White
        Me.TreeView_niif.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TreeView_niif.Dock = System.Windows.Forms.DockStyle.Top
        Me.TreeView_niif.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView_niif.ImageIndex = 0
        Me.TreeView_niif.ImageList = Me.ImageList1
        Me.TreeView_niif.Location = New System.Drawing.Point(0, 0)
        Me.TreeView_niif.Name = "TreeView_niif"
        Me.TreeView_niif.SelectedImageIndex = 0
        Me.TreeView_niif.Size = New System.Drawing.Size(730, 411)
        Me.TreeView_niif.TabIndex = 674
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
        'Label_cuenta
        '
        Me.Label_cuenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_cuenta.BackColor = System.Drawing.Color.Transparent
        Me.Label_cuenta.Font = New System.Drawing.Font("Segoe UI", 10.75!, System.Drawing.FontStyle.Bold)
        Me.Label_cuenta.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label_cuenta.Location = New System.Drawing.Point(8, 444)
        Me.Label_cuenta.Name = "Label_cuenta"
        Me.Label_cuenta.Size = New System.Drawing.Size(511, 34)
        Me.Label_cuenta.TabIndex = 677
        Me.Label_cuenta.Text = "-"
        Me.Label_cuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_codigo
        '
        Me.Label_codigo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_codigo.AutoSize = True
        Me.Label_codigo.BackColor = System.Drawing.Color.Transparent
        Me.Label_codigo.Font = New System.Drawing.Font("Segoe UI", 10.75!, System.Drawing.FontStyle.Bold)
        Me.Label_codigo.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label_codigo.Location = New System.Drawing.Point(8, 422)
        Me.Label_codigo.Name = "Label_codigo"
        Me.Label_codigo.Size = New System.Drawing.Size(15, 20)
        Me.Label_codigo.TabIndex = 676
        Me.Label_codigo.Text = "-"
        Me.Label_codigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Button_regresar_niif.Image = Global.MiClickDerecho.My.Resources.Resources.ok_transico1
        Me.Button_regresar_niif.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_regresar_niif.Location = New System.Drawing.Point(525, 426)
        Me.Button_regresar_niif.Name = "Button_regresar_niif"
        Me.Button_regresar_niif.Size = New System.Drawing.Size(198, 48)
        Me.Button_regresar_niif.TabIndex = 675
        Me.Button_regresar_niif.Text = "Seleccionar"
        Me.Button_regresar_niif.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_regresar_niif.UseVisualStyleBackColor = False
        '
        'Form_pucniffselect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 479)
        Me.Controls.Add(Me.TreeView_niif)
        Me.Controls.Add(Me.Label_cuenta)
        Me.Controls.Add(Me.Label_codigo)
        Me.Controls.Add(Me.Button_regresar_niif)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_pucniffselect"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TreeView_niif As TreeView
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Label_cuenta As Label
    Friend WithEvents Label_codigo As Label
    Friend WithEvents Button_regresar_niif As Button
End Class
