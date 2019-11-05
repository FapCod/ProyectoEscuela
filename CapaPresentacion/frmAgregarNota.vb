Imports CapaNegocio
Imports CapaEntidad
Public Class frmAgregarNota


    Private Sub frmAgregarNota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objnegCurso As New negCurso
        cmbcodigocurso.DataSource = objnegCurso.listarCurso()
        cmbcodigocurso.DisplayMember = "nombreCurso"
        Dim objnegTrimestre As New negTrimestre
        cmbtrimestre.DataSource = objnegTrimestre.listarTrimestre()
        cmbtrimestre.DisplayMember = "descripcionTrimestre"
    End Sub


    Private Sub btnagregarNota_Click(sender As Object, e As EventArgs) Handles btnagregarNota.Click
        Dim objentNotas As New entNota
        objentNotas._nota = cmbnota.Text
        objentNotas._descripcion = cmbCompetencia.Text
        If cmbcodigocurso.Text = "Comunicacion" Then
            objentNotas.objentCurso._codigoCurso = "COM01"
        ElseIf cmbcodigocurso.Text = "Personal Social" Then
            objentNotas.objentCurso._codigoCurso = "PSC01"
        ElseIf cmbcodigocurso.Text = "Educacion Fisica" Then
            objentNotas.objentCurso._codigoCurso = "EFS01"
        ElseIf cmbcodigocurso.Text = "Arte y Cultura" Then
            objentNotas.objentCurso._codigoCurso = "ACL01"
        ElseIf cmbcodigocurso.Text = "Matematica" Then
            objentNotas.objentCurso._codigoCurso = "MAT01"
        ElseIf cmbcodigocurso.Text = "Ciencia Tecnologia y Ambiente" Then
            objentNotas.objentCurso._codigoCurso = "CTA01"
        End If
        objentNotas.objentAlumno._dniAlumno = txtdniAlumno.Text
        If cmbtrimestre.Text = "Primer Trimestre" Then
            objentNotas.objentTrimestre._codigoTrimestre = "1Tri"
        ElseIf cmbtrimestre.Text = "Segundo Trimestre" Then
            objentNotas.objentTrimestre._codigoTrimestre = "2Tri"
        ElseIf cmbtrimestre.Text = "Tercer Trimestre" Then
            objentNotas.objentTrimestre._codigoTrimestre = "3Tri"
        End If
        Dim objnegNota As New negnota
        Dim verificarRA = objnegNota.registrarNota(objentNotas)
        If verificarRA = True Then
            MsgBox("registro exitoso")
            DataGridView1.DataSource = objnegNota.obtenerTabla(objentNotas)

            'LimpiarDatos()
            'Ver()
        Else
            MsgBox("Error de registro de Alumno")
        End If
    End Sub

End Class