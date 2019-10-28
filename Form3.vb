Public Class Form3
    Private Sub btnCerrarBD_Click(sender As Object, e As EventArgs) Handles btnCerrarBD.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub btnCerrarBD_MouseHover(sender As Object, e As EventArgs) Handles btnCerrarBD.MouseHover
        btnCerrarBD.FlatAppearance.BorderSize = 1
        btnCerrarBD.FlatAppearance.BorderColor = Color.Crimson
    End Sub

    Private Sub btnCerrarBD_MouseLeave(sender As Object, e As EventArgs) Handles btnCerrarBD.MouseLeave
        btnCerrarBD.FlatStyle = FlatStyle.Flat
        btnCerrarBD.FlatAppearance.BorderSize = 0
        btnCerrarBD.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnCerrarBD.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnCerrarBD.BackColor = Color.Transparent
    End Sub
End Class