Imports CapaNegocio
Public Class frmRecuperarContrasena
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim objnegUsuario As New negUser()
        Dim result = objnegUsuario.recuperarContrasena(txtCorreoUsuario.Text)
        lblResultadoMensaje.Text = result
    End Sub

    Private Sub btnEnviar_MouseEnter(sender As Object, e As EventArgs) Handles btnEnviar.MouseEnter
        btnEnviar.BackColor = Color.DeepSkyBlue
    End Sub

    Private Sub btnEnviar_MouseLeave(sender As Object, e As EventArgs) Handles btnEnviar.MouseLeave
        btnEnviar.BackColor = Color.DodgerBlue
    End Sub
End Class