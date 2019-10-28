Imports System.Threading
Public Class frmPresentacion
    Private Sub contadorInicio_Tick(sender As Object, e As EventArgs) Handles contadorInicio.Tick
        barraInicio.Value += 1
        lblContadorInicio.Text = "Cargando... " + barraInicio.Value.ToString + "%"
        If barraInicio.Value = 100 Then
            contadorInicio.Stop()
            Form2.Show()
        End If
    End Sub

    Private Sub frmPresentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        contadorInicio.Start()
    End Sub

    Private Sub frmPresentacion_Click(sender As Object, e As EventArgs) Handles Me.Click
        'Dim arregloPrueba() As String = {"C", "A", "R", "G", "A", "N", "D", "O"}
        'For Each letra As String In arregloPrueba
        '    lblPrueba.Text += letra
        '    Thread.Sleep(10)
        'Next
    End Sub

End Class
