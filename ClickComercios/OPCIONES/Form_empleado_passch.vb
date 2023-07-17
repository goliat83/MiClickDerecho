Public Class Form_empleado_passch
    Private Sub Form_empleado_passch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox_actual.isPassword = True
        TextBox_nueva.isPassword = True
        TextBox_nueva2.isPassword = True
        Label_empnom.Text = usrnom
    End Sub

    Private Sub button_crear_Click(sender As Object, e As EventArgs) Handles button_crear.Click
        If TextBox_actual.Text = "" Then
            Label3.Text = "digíte la contraseña actual"
            Exit Sub
        End If


        If TextBox_nueva.Text <> TextBox_nueva2.Text Then
            Label3.Text = "la nueva contraseña no coincide"
            Exit Sub
        End If

    End Sub
End Class