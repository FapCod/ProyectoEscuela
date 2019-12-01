Imports CapaEntidad
Imports CapaNegocio
Public Class frmAgregarSeccion
    Private Sub frmAgregarSeccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub btnagregarSeccion_Click(sender As Object, e As EventArgs) Handles btnagregarSeccion.Click
        Dim objentSeccion As New entSeccion
        objentSeccion._codigoSeccion = txtCodigoSeccion.Text
        objentSeccion._nombreSeccion = txtSeccion.Text
        objentSeccion._codigoGrado = cmbGrado.Text
        objentSeccion._dniProfesor = cmbProfesor.Text
        objentSeccion._numeroAno = Val(txtAnoEscolar.Text)
        objentSeccion._numeroVacantes = Val(txtNumeroVacantes.Text)
        Dim objnegSeccion As New negSeccion
        Dim verificarRP = objnegSeccion.registrarSeccion(objentSeccion)
        If verificarRP = True Then
            MsgBox("registro exitoso")
            'ver()
            'LimpiarDatos()
        Else
            MsgBox("Error de registro de profesor")
        End If
    End Sub

   
End Class