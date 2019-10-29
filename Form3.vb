Public Class Form3
    Private TmrTask As Task
    Private operacion = 1 '1 Actualizar - 0 guardar
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

    Private Sub AlumnosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AlumnosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AlumnosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDPruebaDataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDPruebaDataSet.alumnos' table. You can move, or remove it, as needed.
        Me.AlumnosTableAdapter.Fill(Me.BDPruebaDataSet.alumnos)

        Me.btnGuardar.Enabled = False
        Me.btnCancelar.Enabled = False
        Me.IdTextBox.Enabled = False
        Me.NombreTextBox.Enabled = False
        Me.ApellidoTextBox.Enabled = False

        If TmrTask Is Nothing OrElse TmrTask.IsCompleted Then
            TmrTask = Task.Run(Sub() MyTimerTask())
        End If

    End Sub

    Private Sub MyTimerTask()
        Dim arr() As String = {"BIENVENIDO BROW", "Aplicacion Simple", "Hecha con amor :v", "Facil de usar", "Para Sistemas Distribuidos",
            "Interactiva..", "Conectada remotamente...", "Gracias por tu atencion", "Guiño infinito..."}
        'Dim arr() As String = {"Cake", "Mouse", "Heat"} 'to test
        For Each s As String In arr
            Me.BeginInvoke(Sub()
                               lblTexto.Text = s
                           End Sub)
            Threading.Thread.Sleep(10000)
        Next
    End Sub

    Private Sub Activar_Controles()
        Me.btnNuevo.Enabled = False
        Me.btnEliminar.Enabled = False
        Me.btnGuardar.Enabled = True
        Me.btnCancelar.Enabled = True
        Me.btnEditar.Enabled = False
        Me.btnCancelar.Enabled = True
        Me.IdTextBox.Enabled = True
        Me.NombreTextBox.Enabled = True
        Me.ApellidoTextBox.Enabled = True
        Me.IdTextBox.Text = ""
        Me.NombreTextBox.Text = ""
        Me.ApellidoTextBox.Text = ""
    End Sub

    Private Sub Desactivar_Controles()
        Me.btnNuevo.Enabled = True
        Me.btnEliminar.Enabled = True
        Me.btnGuardar.Enabled = False
        Me.btnEditar.Enabled = True
        Me.btnCancelar.Enabled = False
        Me.IdTextBox.Enabled = False
        Me.NombreTextBox.Enabled = False
        Me.ApellidoTextBox.Enabled = False
        Me.IdTextBox.Text = ""
        Me.NombreTextBox.Text = ""
        Me.ApellidoTextBox.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Activar_Controles()
        operacion = 0
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Desactivar_Controles()
    End Sub

    Private Sub IdLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub IdTextBox_TextChanged(sender As Object, e As EventArgs) Handles IdTextBox.TextChanged

    End Sub

    Private Sub tiempo_Tick(sender As Object, e As EventArgs) Handles tiempo.Tick
        lblTime.Text = "Fecha: " + DateTime.Now().ToLongDateString() + " Hora: " + DateTime.Now().ToLongTimeString()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If (operacion = 0) Then
            Me.AlumnosTableAdapter.InsertQuery(IdTextBox.Text, NombreTextBox.Text, ApellidoTextBox.Text)
            Me.AlumnosTableAdapter.Fill(Me.BDPruebaDataSet.alumnos)
            Desactivar_Controles()
        Else
            Me.AlumnosTableAdapter.UpdateQuery(NombreTextBox.Text, ApellidoTextBox.Text, IdTextBox.Text)
            Me.AlumnosTableAdapter.Fill(Me.BDPruebaDataSet.alumnos)
            Desactivar_Controles()
        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Me.AlumnosTableAdapter.DeleteQuery(IdTextBox.Text)
        Me.AlumnosTableAdapter.Fill(Me.BDPruebaDataSet.alumnos)
        Desactivar_Controles()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Me.btnEditar.Enabled = False
        Me.btnCancelar.Enabled = True
        Me.btnGuardar.Enabled = True
        Me.btnEliminar.Enabled = False
        Me.btnNuevo.Enabled = False
        Me.IdTextBox.Enabled = False
        Me.NombreTextBox.Enabled = True
        Me.ApellidoTextBox.Enabled = True
        operacion = 1
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class