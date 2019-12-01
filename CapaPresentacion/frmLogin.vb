Imports CapaEntidad
Imports CapaNegocio
Public Class frmLogin
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
            Me.Hide()
            Dim frmBienvenidoUser As New frmBienvenidoUser
            frmBienvenidoUser.ShowDialog()
            Dim frmprincipal As New frmPrincipal()
            frmprincipal.Show()
            AddHandler frmprincipal.FormClosed, AddressOf Me.CerrarCuenta

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

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim frmrecuperarContrasena As New frmRecuperarContrasena()
        frmrecuperarContrasena.Show()
    End Sub

    Private Sub txtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUser.KeyPress
        If Char.IsSeparator(e.KeyChar) Then 'Si es espacio no entra al textbox
            e.Handled = True
        End If
    End Sub
End Class
