Imports CapaEntidad
Imports CapaNegocio
Public Class frmPrincipal

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNombreUser.Text = usuarioActivo.nombreUsuario
        lblNombresUsuario.Text = usuarioActivo.nombresUsuario
        lblApellidoUsuario.Text = usuarioActivo.apellidoUsuario
        lblCorreoUsuario.Text = usuarioActivo.correoUsuario
        lblCargoUsuario.Text = usuarioActivo.cargoUsuario
        Dim usuario As New negUser()

        If usuario.validarUsuario(usuarioActivo.nombreUsuario) = False Then
            MessageBox.Show("Error")
            Me.Close()
        End If
        If usuarioActivo.nombreUsuario = Nothing OrElse usuarioActivo.nombreUsuario = "" Then
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
        If usuarioActivo.cargoUsuario = Cargos.Profesor Then
            btnRegistrarMaestro.Enabled = False
            btnListarMaestros.Enabled = False
        End If
    End Sub

    Private Sub btnRegistrarMaestro_Click(sender As Object, e As EventArgs) Handles btnRegistrarMaestro.Click
        Dim frmRM As New frmAgregarProfesor
        frmRM.Show()
    End Sub

    Private Sub btnRegistrarAlumno_Click(sender As Object, e As EventArgs) Handles btnRegistrarAlumno.Click
        Dim frmRA As New frmAgregarAlumno
        frmRA.Show()
    End Sub

    Private Sub btnRegistrarNotas_Click(sender As Object, e As EventArgs) Handles btnRegistrarNotas.Click
        Dim frmRN As New frmRegistrarNotas
        frmRN.Show()
    End Sub

    
   
End Class