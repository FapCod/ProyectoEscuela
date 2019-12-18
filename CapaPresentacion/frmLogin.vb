Imports CapaEntidad
Imports CapaNegocio
Public Class frmLogin
#Region "Funcionalidad de la ventana"


    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
        Close()
    End Sub
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs)
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

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        txtPass.PasswordChar = ""
        btnMostrar.Hide()
        btnOcultar.Show()
    End Sub

    Private Sub btnOcultar_Click(sender As Object, e As EventArgs) Handles btnOcultar.Click
        txtPass.PasswordChar = "*"
        btnOcultar.Hide()
        btnMostrar.Show()
    End Sub
#End Region

#Region "Validacion"
    Private Sub txtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUser.KeyPress
        If Char.IsSeparator(e.KeyChar) Then 'Si es espacio no entra al textbox
            e.Handled = True
        End If
    End Sub
#End Region
#Region "Cambio de color de botones"
    Private Sub btnIngresar_MouseEnter(sender As Object, e As EventArgs) Handles btnIngresar.MouseEnter
        btnIngresar.BackColor = Color.DarkOrange
    End Sub

    Private Sub btnIngresar_MouseLeave(sender As Object, e As EventArgs) Handles btnIngresar.MouseLeave
        btnIngresar.BackColor = Color.Orange
    End Sub
#End Region
End Class
