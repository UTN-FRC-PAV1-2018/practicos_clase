Public Class frmMensaje

    Private Sub btnMensaje_Click(sender As Object, e As EventArgs) Handles btnMensaje.Click
        Dim mensaje As String = txtMensaje.Text


        'MessageBox.Show("Esto es un ejemplo!", "Título")
        'MessageBox.Show(mensaje, "Título")
        MsgBox(mensaje, MsgBoxStyle.Information, "Título")
    End Sub


End Class
