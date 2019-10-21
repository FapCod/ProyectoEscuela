Imports CapaEntidad
Imports CapaNegocio
Public Class frmAgregarAlumno

    Private Sub btnAgregarAlumno_Click(sender As Object, e As EventArgs) Handles btnAgregarAlumno.Click
        Dim objeA As New entAlumno
        objeA._NombreA = txtNombreA.Text
        objeA._ApellidosA = txtApellidoA.Text
        objeA._SexoA = cmbSexoA.Text
        If rbInicial.Checked = True Then
            cmbGradoPri.Enabled = False
            cmbSeccionPri.Enabled = False
            objeA._NivelA = "Inicial"
            objeA._GradoA = cmbGradoIn.Text
            objeA._SeccionA = cmbSeccionIn.Text
        ElseIf rbPrimaria.Checked = True Then
            cmbGradoIn.Enabled = False
            cmbSeccionIn.Enabled = False
            objeA._NivelA = "Primaria"
            objeA._GradoA = cmbGradoPri.Text
            objeA._SeccionA = cmbSeccionPri.Text
        End If
        objeA._DireccionA = txtDireccion.Text
        objeA._NombreApo = txtNombreApo.Text
        Dim negalum As New negAlumno
        Dim verificarRA = negalum.Registrar_Alumno(objeA)
        If verificarRA = True Then
            MsgBox("registro exitoso")
        Else
            MsgBox("Error de registro de profesor")
        End If


    End Sub


      



    
End Class