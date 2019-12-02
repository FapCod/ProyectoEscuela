Imports CapaNegocio
Imports CapaEntidad
Public Class frmAgregarNota
#Region "Funcionalidad de la ventana"

    Private Sub frmAgregarNota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim objnegCurso As New negCurso
        'cmbcodigocurso.DataSource = objnegCurso.listarCurso()
        'cmbcodigocurso.DisplayMember = "nombreCurso"
        Dim objnegTrimestre As New negTrimestre
        cmbtrimestre.DataSource = objnegTrimestre.listarTrimestre()
        cmbtrimestre.DisplayMember = "descripcionTrimestre"
        Dim objnegAnnoEscolar As New negAnnoEscolar
        cmbannoEscolar.DataSource = objnegAnnoEscolar.listarAnnoEscolar()
        cmbannoEscolar.DisplayMember = "numeroAnno"
    End Sub

    Private Sub btnagregarNota_Click(sender As Object, e As EventArgs) Handles btnagregarNota.Click
        Dim objentNotas As New entNota
        If comprobar() Then
        objentNotas._nota = cmbnota.Text
        objentNotas._descripcion = cmbCompetencia.Text
        objentNotas.objentAlumno._dniAlumno = txtdniAlumno.Text
        objentNotas.objentAnnoEscolar._numeroAnno = cmbannoEscolar.Text
        If cmbcodigocurso.Text = "Comunicacion" And rbtprimaria.Checked = True Then
            objentNotas.objentCurso._codigoCurso = "COM01"
        ElseIf cmbcodigocurso.Text = "Personal Social" And rbtprimaria.Checked = True Then
            objentNotas.objentCurso._codigoCurso = "PSC01"
        ElseIf cmbcodigocurso.Text = "Educacion Fisica" And rbtprimaria.Checked = True Then
            objentNotas.objentCurso._codigoCurso = "EFS01"
        ElseIf cmbcodigocurso.Text = "Arte y Cultura" And rbtprimaria.Checked = True Then
            objentNotas.objentCurso._codigoCurso = "ACL01"
        ElseIf cmbcodigocurso.Text = "Matematica" And rbtprimaria.Checked = True Then
            objentNotas.objentCurso._codigoCurso = "MAT01"
        ElseIf cmbcodigocurso.Text = "Ciencia Tecnologia y Ambiente" And rbtprimaria.Checked = True Then
            objentNotas.objentCurso._codigoCurso = "CTA01"
        ElseIf cmbcodigocurso.Text = "Comunicacion" And rbtInicial.Checked = True Then
            objentNotas.objentCurso._codigoCurso = "-ICOM01"
        ElseIf cmbcodigocurso.Text = "Personal Social" And rbtInicial.Checked = True Then
            objentNotas.objentCurso._codigoCurso = "IPSC01"
        ElseIf cmbcodigocurso.Text = " Matematica" And rbtInicial.Checked = True Then
            objentNotas.objentCurso._codigoCurso = "IMAT01"
        ElseIf cmbcodigocurso.Text = "Ciencia Tecnologia y Ambiente" And rbtInicial.Checked = True Then
            objentNotas.objentCurso._codigoCurso = "ICTA01"
        End If
        If cmbtrimestre.Text = "Primer Trimestre" Then
            objentNotas.objentTrimestre._codigoTrimestre = "1Tri"
        ElseIf cmbtrimestre.Text = "Segundo Trimestre" Then
            objentNotas.objentTrimestre._codigoTrimestre = "2Tri"
        ElseIf cmbtrimestre.Text = "Tercer Trimestre" Then
            objentNotas.objentTrimestre._codigoTrimestre = "3Tri"
        End If
        Dim objnegNota As New negNota
        Dim verificarRA = objnegNota.registrarNota(objentNotas)
        If verificarRA = True Then
            MsgBox("registro exitoso")
            DataGridView1.DataSource = objnegNota.obtenerTabla(objentNotas)

            'LimpiarDatos()
            'Ver()
        Else
            MsgBox("Error de registro de Alumno")
            End If
        Else
            MsgBox("Debe llenar los datos que le faltan", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub rbtInicial_CheckedChanged(sender As Object, e As EventArgs) Handles rbtInicial.CheckedChanged
        Dim objnegCurso As New negCurso
        If rbtInicial.Checked = True Then
            cmbcodigocurso.DataSource = objnegCurso.listarCursoInicial
            cmbcodigocurso.DisplayMember = "nombreCurso"
            cmbcodigocurso.ValueMember = "codigoCurso"
        End If
    End Sub

    Private Sub rbtprimaria_CheckedChanged(sender As Object, e As EventArgs) Handles rbtprimaria.CheckedChanged
        Dim objnegCurso As New negCurso
        If rbtprimaria.Checked = True Then
            cmbcodigocurso.DataSource = objnegCurso.listarCursoPrimaria
            cmbcodigocurso.DisplayMember = "nombreCurso"
            cmbcodigocurso.ValueMember = "codigoCurso"
        End If
    End Sub

#End Region

#Region "metodos creados"

#End Region

#Region "funciones creadas"
    Private Function comprobar() As Boolean
        If Len(Trim$(txtdniAlumno.Text)) <> 0 And Len(Trim$(cmbannoEscolar.Text)) <> 0 And Len(Trim$(cmbnota.Text)) <> 0 And Len(Trim$(cmbCompetencia.Text)) <> 0 Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region

#Region "validacion de numeros y letras"
    Private Sub txtdniAlumno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdniAlumno.KeyPress
        If Char.IsNumber(e.KeyChar) Then 'Si es numero si entra al textbox
            e.Handled = False
            If txtdniAlumno.TextLength > 7 Then
                e.Handled = True
            End If
        ElseIf Char.IsControl(e.KeyChar) Then 'Si es una tecla de control si entra al textbox
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then 'Si es espacio no entra al textbox
            e.Handled = True
        Else
            e.Handled = True   'Si es letra no entra al textbox
        End If
    End Sub
#End Region

#Region "los colores cambian"
    Private Sub btnagregarNota_MouseEnter(sender As Object, e As EventArgs) Handles btnagregarNota.MouseEnter
        btnagregarNota.BackColor = Color.DeepSkyBlue
    End Sub

    Private Sub btnagregarNota_MouseLeave(sender As Object, e As EventArgs) Handles btnagregarNota.MouseLeave
        btnagregarNota.BackColor = Color.DodgerBlue
    End Sub

    Private Sub btneditarNota_MouseEnter(sender As Object, e As EventArgs) Handles btneditarNota.MouseEnter
        btneditarNota.BackColor = Color.DeepSkyBlue
    End Sub

    Private Sub btneditarNota_MouseLeave(sender As Object, e As EventArgs) Handles btneditarNota.MouseLeave
        btneditarNota.BackColor = Color.DodgerBlue
    End Sub

    Private Sub btneliminarNota_MouseEnter(sender As Object, e As EventArgs) Handles btneliminarNota.MouseEnter
        btneliminarNota.BackColor = Color.Red
    End Sub

    Private Sub btneliminarNota_MouseLeave(sender As Object, e As EventArgs) Handles btneliminarNota.MouseLeave
        btneliminarNota.BackColor = Color.DodgerBlue
    End Sub
#End Region
    
End Class