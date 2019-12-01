﻿Imports CapaEntidad
Imports CapaNegocio
Public Class frmAgregarMatricula
    Private Sub frmAgregarMatricula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objnegAnnoEscolar As New negAnnoEscolar
        cmbannoEscolar.DataSource = objnegAnnoEscolar.listarAnnoEscolar()
        cmbannoEscolar.DisplayMember = "numeroAnno"
        dgvinicial.Visible = False
        dgvprimaria.Visible = False
        ver()
    End Sub

    Sub ver()
        Dim objnegMatricula As New negMatricula
        DataGridView1.DataSource = objnegMatricula.obtenerTabla()
    End Sub

    Private Sub btnagregarMatricula_Click(sender As Object, e As EventArgs) Handles btnagregarMatricula.Click
        Dim objentMatricula As New entMatricula
        objentMatricula._fechaMatricula = Format(dtFecha.Value, "Short Date")
        objentMatricula.objentAlumno._dniAlumno = txtdniAlumno.Text
        objentMatricula.objentAnnoEscolar._numeroAnno = Val(cmbannoEscolar.Text)
        objentMatricula.objentgrado._codigoGrado = Val(cmbcodGrado.Text)
        objentMatricula.objentSeccion._nombreSeccion = cmbcodseccion.Text
        If rbtinicial.Checked = True Then
            objentMatricula._nivelAlumno = "Inicial"
            
        End If
        If rbtPrimaria.Checked = True Then
            objentMatricula._nivelAlumno = "Primaria"
  
        End If
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
        cmbcodGrado.Text = ""
        txtdniAlumno.Clear()
        cmbcodseccion.Text = ""
        dgvinicial.Visible = False
        dgvprimaria.Visible = False
    End Sub

    

    Private Sub rbtinicial_CheckedChanged(sender As Object, e As EventArgs) Handles rbtinicial.CheckedChanged
        Dim objnegGrado As New negGrado
        Dim objnegCurso As New negCurso
        If rbtinicial.Checked = True Then
            cmbcodGrado.DataSource = objnegGrado.listarGradoInicial()
            cmbcodGrado.DisplayMember = "numeroGrado"
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
            dgvprimaria.DataSource = objnegCurso.listarCursoPrimaria()
            dgvprimaria.Visible = True
            dgvinicial.Visible = False
        End If
    End Sub

    Private Sub cmbcodGrado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcodGrado.SelectedIndexChanged
        Dim objnegSeccion As New negSeccion
        cmbcodseccion.DataSource = objnegSeccion.cargarSeccion(Val(cmbcodGrado.Text))
        cmbcodseccion.DisplayMember = "nombreSeccion"
    End Sub

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
End Class