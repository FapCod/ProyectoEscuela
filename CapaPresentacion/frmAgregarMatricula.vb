Imports CapaEntidad
Imports CapaNegocio
Public Class frmAgregarMatricula
    Private Sub frmAgregarMatricula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objnegAula As New negAula
        cmbcodigoAula.DataSource = objnegAula.listarAula()
        cmbcodigoAula.DisplayMember = "nombreAula"
        Dim objnegAnnoEscolar As New negAnnoEscolar
        cmbannoEscolar.DataSource = objnegAnnoEscolar.listarAnnoEscolar()
        cmbannoEscolar.DisplayMember = "numeroAnno"
    End Sub

    Private Sub btnagregarMatricula_Click(sender As Object, e As EventArgs) Handles btnagregarMatricula.Click
        Dim objentMatricula As New entMatricula
        objentMatricula._fechaMatricula = Format(dtFecha.Value, "Short Date")
        objentMatricula._gradoAlumno = cmbcodigoAula.Text
        If cmbcodigoAula.Text = "Inicial 3" Then
            objentMatricula.objentAula._codigoAula = "I3"
        ElseIf cmbcodigoAula.Text = "Inicial 4" Then
            objentMatricula.objentAula._codigoAula = "I4"
        ElseIf cmbcodigoAula.Text = "Inicial 5" Then
            objentMatricula.objentAula._codigoAula = "I5"
        ElseIf cmbcodigoAula.Text = "Primaria 1" Then
            objentMatricula.objentAula._codigoAula = "P1"
        ElseIf cmbcodigoAula.Text = "Primaria 2" Then
            objentMatricula.objentAula._codigoAula = "P2"
        ElseIf cmbcodigoAula.Text = "Primaria 3" Then
            objentMatricula.objentAula._codigoAula = "P3"
        ElseIf cmbcodigoAula.Text = "Primaria 4" Then
            objentMatricula.objentAula._codigoAula = "P4"
        ElseIf cmbcodigoAula.Text = "Primaria 5" Then
            objentMatricula.objentAula._codigoAula = "P5"
        ElseIf cmbcodigoAula.Text = "Primaria 6" Then
            objentMatricula.objentAula._codigoAula = "P6"
        End If
        objentMatricula.objentAlumno._dniAlumno = txtdniAlumno.Text
        objentMatricula.objentAnnoEscolar._numeroAnno = cmbannoEscolar.Text
        Dim objnegMatricula As New negMatricula
        Dim verificarRP = objnegMatricula.registrarmatricula(objnegMatricula)
        If verificarRP = True Then
            MsgBox("registro exitoso")
            LimpiarDatos()
        Else
            MsgBox("Error de registro de profesor")
        End If
        
    End Sub
   
    Public Sub LimpiarDatos()
        cmbcodigoAula.Text = ""
        txtdniAlumno.Clear()
    End Sub
    Private Sub cmbcodigoAula_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcodigoAula.SelectedIndexChanged
        Dim objnegMatricula As New negMatricula
        Dim objentAula As New entAula
        objentAula._nombreAula = cmbcodigoAula.Text
        txtvacantesLibres.Text = objnegMatricula.obtenerVacantesLibres(objentAula)
    End Sub
End Class