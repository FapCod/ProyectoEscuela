Imports CapaEntidad
Imports CapaNegocio
Public Class frmAgregarMatricula
#Region "Funcionalidad de la ventana"
    Private Sub frmAgregarMatricula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objnegAnnoEscolar As New negAnnoEscolar
        cmbannoEscolar.DataSource = objnegAnnoEscolar.listarAnnoEscolar()
        cmbannoEscolar.DisplayMember = "numeroAnno"
        dgvinicial.Visible = False
        dgvprimaria.Visible = False
        ver()
    End Sub

    Private Sub btnagregarMatricula_Click(sender As Object, e As EventArgs) Handles btnagregarMatricula.Click

        Dim objentMatricula As New entMatricula
        Dim objnegMatricula As New negMatricula
        If comprobar() Then
            If (objnegMatricula.VerificarSiExisteAlumno(txtdniAlumno.Text)) Then
                objentMatricula._fechaMatricula = Format(dtFecha.Value, "Short Date")
                objentMatricula.objentAlumno._dniAlumno = txtdniAlumno.Text
                objentMatricula.objentAnnoEscolar._numeroAnno = Val(cmbannoEscolar.Text)
                objentMatricula.objentgrado._codigoGrado = cmbcodGrado.SelectedValue
                objentMatricula.objentSeccion._codigoSeccion = cmbcodseccion.SelectedValue
                If rbtinicial.Checked = True Then
                    objentMatricula._nivelAlumno = "Inicial"

                End If
                If rbtPrimaria.Checked = True Then
                    objentMatricula._nivelAlumno = "Primaria"

                End If
                objentMatricula._eliminacionLogica = False

                Dim verificarRP = objnegMatricula.registrarMatricula(objentMatricula)
                If verificarRP = True Then
                    MsgBox("registro exitoso")
                    objnegMatricula.decrementarVacante(objentMatricula)
                    ver()
                    LimpiarDatos()
                Else
                    MsgBox("Error de registro de Matricula")
                End If
            Else
                MsgBox("El alumno no existe")
            End If
        Else
            MsgBox("Debe llenar todos los datos")
        End If
    End Sub
    Private Sub rbtinicial_CheckedChanged(sender As Object, e As EventArgs) Handles rbtinicial.CheckedChanged
        Dim objnegGrado As New negGrado
        Dim objnegCurso As New negCurso
        If rbtinicial.Checked = True Then
            cmbcodGrado.DataSource = objnegGrado.listarGradoInicial()
            cmbcodGrado.DisplayMember = "numeroGrado"
            cmbcodGrado.ValueMember = "codigoGrado"
            dgvinicial.DataSource = objnegCurso.listarCursoInicial()
            dgvinicial.Visible = True
            dgvprimaria.Visible = False
        End If
    End Sub

    Private Sub rbtPrimaria_CheckedChanged(sender As Object, e As EventArgs) Handles rbtPrimaria.CheckedChanged
        Dim objnegGrado As New negGrado
        Dim objnegCurso As New negCurso
        If rbtPrimaria.Checked = True Then
            cmbcodGrado.DataSource = objnegGrado.listarGradoPrimaria()
            cmbcodGrado.DisplayMember = "numeroGrado"
            cmbcodGrado.ValueMember = "codigoGrado"
            dgvprimaria.DataSource = objnegCurso.listarCursoPrimaria()
            dgvprimaria.Visible = True
            dgvinicial.Visible = False
        End If
    End Sub
#End Region

#Region "metodos creados"
    Public Sub LimpiarDatos()
        cmbcodGrado.Text = Nothing
        txtdniAlumno.Clear()
        cmbcodseccion.Text = Nothing
        dgvinicial.Visible = False
        dgvprimaria.Visible = False
        rbtinicial.Checked = False
        rbtPrimaria.Checked = False
    End Sub
    Sub ver()
        Dim objnegMatricula As New negMatricula
        DataGridView1.DataSource = objnegMatricula.obtenerTabla()
        DataGridView1.Columns(0).Visible = False
    End Sub

    Public Sub cargarDatosSeccionInicial()
        Dim objneg As New negSeccion
        cmbcodseccion.DataSource = objneg.cargarSeccion(Val(cmbcodGrado.Text))
        cmbcodseccion.DisplayMember = "nombreSeccion"
        cmbcodseccion.ValueMember = "codigoSeccion"
    End Sub
    Public Sub cargarDatosSeccionPrimaria()
        Dim objneg As New negSeccion
        cmbcodseccion.DataSource = objneg.cargarSeccionP(Val(cmbcodGrado.Text))
        cmbcodseccion.DisplayMember = "nombreSeccion"
        cmbcodseccion.ValueMember = "codigoSeccion"
    End Sub
#End Region

#Region "funciones creadas"
    Private Function comprobar() As Boolean
        If Len(Trim$(txtdniAlumno.Text)) <> 0 And Len(Trim$(cmbannoEscolar.Text)) <> 0 And Len(Trim$(cmbcodGrado.Text)) <> 0 And Len(Trim$(cmbcodseccion.Text)) <> 0 Then
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
    Private Sub btnagregarMatricula_MouseEnter(sender As Object, e As EventArgs) Handles btnagregarMatricula.MouseEnter
        btnagregarMatricula.BackColor = Color.DeepSkyBlue
    End Sub

    Private Sub btnagregarMatricula_MouseLeave(sender As Object, e As EventArgs) Handles btnagregarMatricula.MouseLeave
        btnagregarMatricula.BackColor = Color.DodgerBlue
    End Sub

    Private Sub btneditarMatricula_MouseEnter(sender As Object, e As EventArgs) Handles btneditarMatricula.MouseEnter
        btneditarMatricula.BackColor = Color.DeepSkyBlue
    End Sub

    Private Sub btneditarMatricula_MouseLeave(sender As Object, e As EventArgs) Handles btneditarMatricula.MouseLeave
        btneditarMatricula.BackColor = Color.DodgerBlue
    End Sub

    Private Sub btneliminarMatricula_MouseEnter(sender As Object, e As EventArgs) Handles btneliminarMatricula.MouseEnter
        btneliminarMatricula.BackColor = Color.Red
    End Sub

    Private Sub btneliminarMatricula_MouseLeave(sender As Object, e As EventArgs) Handles btneliminarMatricula.MouseLeave
        btneliminarMatricula.BackColor = Color.DodgerBlue
    End Sub

#End Region

    


    Private Sub cmbcodGrado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcodGrado.SelectedIndexChanged
        If rbtinicial.Checked = True Then
            cargarDatosSeccionInicial()
        ElseIf rbtPrimaria.Checked = True Then
            cargarDatosSeccionPrimaria()
        Else
            MsgBox("Debe elegir primaria o inicial")
        End If

    End Sub

    
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        dtFecha.Text = DataGridView1.Item(1, i).Value()
        cmbcodGrado.Text = DataGridView1.Item(2, i).Value()
        txtdniAlumno.Text = DataGridView1.Item(3, i).Value()
        cmbannoEscolar.Text = DataGridView1.Item(4, i).Value()
        cmbcodseccion.Text = DataGridView1.Item(5, i).Value()
        Dim nivel As String
        nivel = DataGridView1.Item(6, i).Value()
        Dim comparar As Integer
        Dim nievelA As String = "Primaria"
        comparar = nivel.CompareTo(nievelA)
        If comparar = 0 Then
            rbtPrimaria.Checked = True
        Else
            rbtinicial.Checked = True
        End If
    End Sub

    Private Sub btneditarMatricula_Click(sender As Object, e As EventArgs) Handles btneditarMatricula.Click
        Dim idMatricula As Integer
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        idMatricula = DataGridView1.Item(0, i).Value()
        Dim objentMatricula As New entMatricula
        Dim objnegMatricula As New negMatricula
        If comprobar() Then
            If (objnegMatricula.VerificarSiExisteAlumno(txtdniAlumno.Text)) Then
                objentMatricula._fechaMatricula = Format(dtFecha.Value, "Short Date")
                objentMatricula.objentAlumno._dniAlumno = txtdniAlumno.Text
                objentMatricula.objentAnnoEscolar._numeroAnno = Val(cmbannoEscolar.Text)
                objentMatricula.objentgrado._codigoGrado = cmbcodGrado.SelectedValue
                objentMatricula.objentSeccion._codigoSeccion = cmbcodseccion.SelectedValue
                If rbtinicial.Checked = True Then
                    objentMatricula._nivelAlumno = "Inicial"

                End If
                If rbtPrimaria.Checked = True Then
                    objentMatricula._nivelAlumno = "Primaria"

                End If
                objentMatricula._eliminacionLogica = False

                Dim verificarRP = objnegMatricula.editarMatricula(objentMatricula, idMatricula)
                If verificarRP = True Then
                    MsgBox("Actualizacion exitosa")
                    ver()
                    LimpiarDatos()
                Else
                    MsgBox("Error al actualizar Matricula")
                End If
            Else
                MsgBox("El alumno no existe")
            End If
        Else
            MsgBox("Debe llenar todos los datos")
        End If
    End Sub

    Private Sub btneliminarMatricula_Click(sender As Object, e As EventArgs) Handles btneliminarMatricula.Click
        Dim idMatricula As Integer
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        idMatricula = DataGridView1.Item(0, i).Value()
        Dim objnegMatricula As New negMatricula
        Dim verificarRP = objnegMatricula.eliminarMatricula(idMatricula)
        If verificarRP = True Then
            MsgBox("Elimincacion exitosa")
            ver()
            LimpiarDatos()
        Else
            MsgBox("Error al eliminar Matricula")
        End If
    End Sub
End Class