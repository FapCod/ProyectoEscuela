Imports CapaEntidad
Imports CapaNegocio
Public Class frmPrincipal

#Region "Botones del formulario"
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
            btnAperturarAno.Enabled = False
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
        Dim frmAN As New frmAgregarNota
        frmAN.Show()
    End Sub



    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        Dim frmAM As New frmAgregarMatricula
        frmAM.Show()
    End Sub

    Private Sub btnRegistrarSeccion_Click(sender As Object, e As EventArgs) Handles btnRegistrarSeccion.Click
        Dim frmSC As New frmagregarSeccion
        frmSC.Show()
    End Sub

    Private Sub btnRegistrarMaestro_MouseEnter(sender As Object, e As EventArgs) Handles btnRegistrarMaestro.MouseEnter
        btnRegistrarMaestro.BackColor = Color.DeepSkyBlue
    End Sub

    Private Sub btnRegistrarMaestro_MouseLeave(sender As Object, e As EventArgs) Handles btnRegistrarMaestro.MouseLeave
        btnRegistrarMaestro.BackColor = Color.DodgerBlue
    End Sub

    Private Sub btnRegistrarAlumno_MouseEnter(sender As Object, e As EventArgs) Handles btnRegistrarAlumno.MouseEnter
        btnRegistrarAlumno.BackColor = Color.DeepSkyBlue
    End Sub

    Private Sub btnRegistrarAlumno_MouseLeave(sender As Object, e As EventArgs) Handles btnRegistrarAlumno.MouseLeave
        btnRegistrarAlumno.BackColor = Color.DodgerBlue
    End Sub

    Private Sub btnRegistrarNotas_MouseEnter(sender As Object, e As EventArgs) Handles btnRegistrarNotas.MouseEnter
        btnRegistrarNotas.BackColor = Color.DeepSkyBlue
    End Sub

    Private Sub btnRegistrarNotas_MouseLeave(sender As Object, e As EventArgs) Handles btnRegistrarNotas.MouseLeave
        btnRegistrarNotas.BackColor = Color.DodgerBlue
    End Sub

    Private Sub btnListarMaestros_MouseEnter(sender As Object, e As EventArgs) Handles btnListarMaestros.MouseEnter
        btnListarMaestros.BackColor = Color.DeepSkyBlue
    End Sub

    Private Sub btnListarMaestros_MouseLeave(sender As Object, e As EventArgs) Handles btnListarMaestros.MouseLeave
        btnListarMaestros.BackColor = Color.DodgerBlue
    End Sub

    Private Sub btnListarAlumnos_MouseEnter(sender As Object, e As EventArgs) Handles btnListarAlumnos.MouseEnter
        btnListarAlumnos.BackColor = Color.DeepSkyBlue
    End Sub

    Private Sub btnListarAlumnos_MouseLeave(sender As Object, e As EventArgs) Handles btnListarAlumnos.MouseLeave
        btnListarAlumnos.BackColor = Color.DodgerBlue
    End Sub

    Private Sub btnReportes_MouseEnter(sender As Object, e As EventArgs) Handles btnReportes.MouseEnter
        btnReportes.BackColor = Color.DeepSkyBlue
    End Sub

    Private Sub btnReportes_MouseLeave(sender As Object, e As EventArgs) Handles btnReportes.MouseLeave
        btnReportes.BackColor = Color.DodgerBlue
    End Sub

    Private Sub btnRegistrarSeccion_MouseEnter(sender As Object, e As EventArgs) Handles btnRegistrarSeccion.MouseEnter
        btnRegistrarSeccion.BackColor = Color.DeepSkyBlue
    End Sub

    Private Sub btnRegistrarSeccion_MouseLeave(sender As Object, e As EventArgs) Handles btnRegistrarSeccion.MouseLeave
        btnRegistrarSeccion.BackColor = Color.DodgerBlue
    End Sub

    Private Sub btnReporteProfesor_Click(sender As Object, e As EventArgs) Handles btnReporteProfesor.Click
        frmReportes.Show()
    End Sub

    Private Sub thorafecha_Tick(sender As Object, e As EventArgs) Handles thorafecha.Tick
        lblHora.Text = DateTime.Now.ToLongTimeString
        lblFecha.Text = DateTime.Now.Date.ToLongDateString
    End Sub

    Private Sub btnAperturarAno_Click(sender As Object, e As EventArgs) Handles btnAperturarAno.Click
        frmAnnoEscolar.Show()
    End Sub

    Private Sub btnListarAlumnos_Click(sender As Object, e As EventArgs) Handles btnListarAlumnos.Click
        frmListarAlumnos.Show()
    End Sub

    Private Sub btnListarMaestros_Click(sender As Object, e As EventArgs) Handles btnListarMaestros.Click
        frmListarMestros.Show()
    End Sub
    Private Sub btnEditarMisDatos_Click(sender As Object, e As EventArgs) Handles btnEditarMisDatos.Click
        Dim director As String = "Director"
        If usuarioActivo.cargoUsuario.Equals(director) Then
            frmEditarDatosDirector.Show()
        Else
            frmEditarDatosProfesor.Show()
        End If
    End Sub
#End Region

#Region "Finalizar"
    Protected Overrides Sub Finalize()
        Me.Close()
    End Sub
#End Region
End Class