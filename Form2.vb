Public Class Form2
    Private Const intentos As Integer = 3
    Dim contador As Integer = 0
    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles btnIniciarSesion.MouseHover
        ' Button1.BackColor = Color.FromArgb(5, 230, 0, 0)
        btnIniciarSesion.FlatAppearance.BorderSize = 1
        btnIniciarSesion.FlatAppearance.BorderColor = Color.Crimson

    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles btnIniciarSesion.MouseLeave
        btnIniciarSesion.FlatStyle = FlatStyle.Flat
        btnIniciarSesion.FlatAppearance.BorderSize = 0
        btnIniciarSesion.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnIniciarSesion.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnIniciarSesion.BackColor = Color.Transparent
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnIniciarSesion.FlatStyle = FlatStyle.Flat
        btnIniciarSesion.FlatAppearance.BorderSize = 0
        btnIniciarSesion.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnIniciarSesion.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnIniciarSesion.BackColor = Color.Transparent
        contador = 0
        lblIncorrecto.Visible = False
        frmPresentacion.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form2_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        'Dim gr As System.Drawing.Graphics = Me.CreateGraphics
        'gr.FillEllipse(System.Drawing.Brushes.Blue, 0, 0,
        'Me.ClientSize.Width - 1, Me.ClientSize.Height - 1)
    End Sub

    Private Sub btnClose_MouseHover(sender As Object, e As EventArgs) Handles btnClose.MouseHover
        btnClose.FlatAppearance.BorderSize = 1
        btnClose.FlatAppearance.BorderColor = Color.Crimson
    End Sub

    Private Sub btnClose_MouseLeave(sender As Object, e As EventArgs) Handles btnClose.MouseLeave
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnClose.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnClose.BackColor = Color.Transparent
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        frmPresentacion.Close()
    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged

    End Sub

    'Private Sub txtUsuario_Paint(sender As Object, e As PaintEventArgs) Handles txtUsuario.Paint
    '    Dim rec As System.Drawing.Rectangle
    '    rec.Height = 40
    '    rec.Width = 120
    '    'e.Graphics.DrawRectangle(System.Drawing.Pens.AliceBlue, rec)
    'End Sub

    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        contador += 1
        If (txtUsuario.Text.Equals("admin") And txtContra.Text.Equals("123456") And contador <= intentos) Then
            Form3.Show()
            txtContra.Text = ""
            txtUsuario.Text = ""
            Me.Hide()
        Else
            If (contador < intentos) Then
                lblIncorrecto.Visible = True
                lblIncorrecto.Text = "Usuario o Contraseña Incorrectos - Intento: " + contador.ToString
            Else
                lblIncorrecto.Visible = True
                contador = 61
                bloqueador.Start()
            End If
        End If

    End Sub

    Private Sub bloqueador_Tick(sender As Object, e As EventArgs) Handles bloqueador.Tick
        contador -= 1
        If (contador > -1) Then
            txtUsuario.Text = ""
            txtContra.Text = ""
            txtUsuario.Enabled = False
            txtContra.Enabled = False
            btnIniciarSesion.Enabled = False
            lblIncorrecto.Text = "Excediste el número de intentos, espera " + contador.ToString + " seg."
        Else
            txtUsuario.Enabled = True
            txtContra.Enabled = True
            btnIniciarSesion.Enabled = True
            lblIncorrecto.Enabled = True
            lblIncorrecto.Visible = False
            contador = 0
            bloqueador.Stop()

        End If
    End Sub
End Class