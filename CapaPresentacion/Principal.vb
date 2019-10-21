Imports CapaEntidad
Imports CapaNegocio
Public Class Principal

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNombreUser.Text = usuarioActivo.firstName
        Dim usuario As New negUser()

        If usuario.ValidarUser(usuarioActivo.UserID) = False Then
            MessageBox.Show("Error")
            Me.Close()
        End If
        If usuarioActivo.UserID = Nothing OrElse usuarioActivo.UserID = 0 Then
            MessageBox.Show("Error")
            Me.Close()
        End If
        manejoDePermisos()
    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        If MessageBox.Show("Estas seguro de cerrar Ventana?", "Mensaje",
         MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub


    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub btnCerrarC_Click(sender As Object, e As EventArgs) Handles btnCerrarC.Click
        If MessageBox.Show("Estas seguro de cerrar cuenta?", "Mensaje",
         MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
    Private Sub manejoDePermisos() ' restricciones en los botones
        If usuarioActivo.Cargo = Cargos.Profesor Then
            btnRegistrarMaestro.Enabled = False
            btnListarMaestros.Enabled = False
        End If
    End Sub

End Class