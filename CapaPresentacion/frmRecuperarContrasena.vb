Imports CapaNegocio
Public Class frmRecuperarContrasena
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim objnegUsuario As New negUser()
        Dim result = objnegUsuario.recuperarContrasena(txtCorreoUsuario.Text)
        lblResultadoMensaje.Text = result
    End Sub
End Class