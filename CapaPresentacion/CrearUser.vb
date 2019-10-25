Imports CapaNegocio
Imports CapaEntidad
Public Class CrearUser

    Private Sub btnAgregarM_Click(sender As Object, e As EventArgs) Handles btnAgregarM.Click
       
        Dim user As String
        Dim pass As String
        user = txtUsername.Text
        pass = txtpass.Text
        Dim negUsu As New negUser
        Dim verificarUs = negUsu.crearUsuario(user, pass)
        If verificarUs = True Then
            MsgBox("registro exitoso")
        Else
            MsgBox("Error de registro de profesor")
        End If

    End Sub
End Class