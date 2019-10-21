Imports CapaEntidad
Imports CapaNegocio
Public Class Login
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim negUser As New negUser()
        Dim username = txtUser.Text
        Dim passUser = txtPass.Text
        Dim validarLogin = negUser.Login(txtUser.Text, txtPass.Text)
        If validarLogin = True Then
            Dim frmprincipal As New Principal()
            frmprincipal.Show()
            AddHandler frmprincipal.FormClosed, AddressOf Me.CerrarCuenta
            Me.Hide()
        Else
            MessageBox.Show("Usuario o contraseña incorrecta.")
            txtPass.Clear()
            txtPass.Focus()
        End If
    End Sub

    Private Sub CerrarCuenta(sender As Object, e As FormClosedEventArgs)
        txtUser.Clear()
        txtPass.Clear()
        Me.Show()
        txtUser.Focus()
    End Sub
 
End Class
