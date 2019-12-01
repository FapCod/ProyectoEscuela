Imports CapaEntidad
Imports CapaNegocio
Public Class frmAgregarMatricula
    Private Sub frmAgregarMatricula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objnegAula As New negAula
        cmbcodigoGrado.DataSource = objnegAula.listarAula()
        cmbcodigoGrado.DisplayMember = "nombreAula"
        Dim objnegAnnoEscolar As New negAnnoEscolar
        cmbannoEscolar.DataSource = objnegAnnoEscolar.listarAnnoEscolar()
        cmbannoEscolar.DisplayMember = "numeroAnno"
        ver()
    End Sub

    Sub ver()
        Dim objnegMatricula As New negMatricula
        DataGridView1.DataSource = objnegMatricula.obtenerTabla()
    End Sub

    Private Sub btnagregarMatricula_Click(sender As Object, e As EventArgs) Handles btnagregarMatricula.Click
        Dim objentMatricula As New entMatricula
        objentMatricula._fechaMatricula = Format(dtFecha.Value, "Short Date")
        If cmbcodigoGrado.Text = "Inicial 3" Then
            objentMatricula.objentAula._codigoAula = "I3"
        ElseIf cmbcodigoGrado.Text = "Inicial 4" Then
            objentMatricula.objentAula._codigoAula = "I4"
        ElseIf cmbcodigoGrado.Text = "Inicial 5" Then
            objentMatricula.objentAula._codigoAula = "I5"
        ElseIf cmbcodigoGrado.Text = "Primaria 1" Then
            objentMatricula.objentAula._codigoAula = "P1"
        ElseIf cmbcodigoGrado.Text = "Primaria 2" Then
            objentMatricula.objentAula._codigoAula = "P2"
        ElseIf cmbcodigoGrado.Text = "Primaria 3" Then
            objentMatricula.objentAula._codigoAula = "P3"
        ElseIf cmbcodigoGrado.Text = "Primaria 4" Then
            objentMatricula.objentAula._codigoAula = "P4"
        ElseIf cmbcodigoGrado.Text = "Primaria 5" Then
            objentMatricula.objentAula._codigoAula = "P5"
        ElseIf cmbcodigoGrado.Text = "Primaria 6" Then
            objentMatricula.objentAula._codigoAula = "P6"
        End If
        objentMatricula.objentAlumno._dniAlumno = txtdniAlumno.Text
        objentMatricula.objentAnnoEscolar._numeroAnno = cmbannoEscolar.Text
        Dim objnegMatricula As New negMatricula
        Dim verificarRP = objnegMatricula.registrarMatricula(objentMatricula)
        If verificarRP = True Then
            MsgBox("registro exitoso")
            ver()
            LimpiarDatos()
        Else
            MsgBox("Error de registro de profesor")
        End If

    End Sub

    Public Sub LimpiarDatos()
        cmbcodigoGrado.Text = ""
        txtdniAlumno.Clear()
    End Sub
    Private Sub cmbcodigoAula_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcodigoGrado.SelectedIndexChanged
        Dim objnegMatricula As New negMatricula
        Dim objentAula As New entAula
        objentAula._nombreAula = cmbcodigoGrado.Text
        txtvacantesLibres.Text = objnegMatricula.obtenerVacantesLibres(objentAula)
    End Sub

   
End Class