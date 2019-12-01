Imports CapaEntidad
Imports CapaNegocio
Public Class frmagregarSeccion
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim objentSeccion As New entSeccion
        Dim objnegSeccion As New negSeccion
        objentSeccion._nombreSeccion = txtSeccion.Text
        If rbtinicial.Checked = True Then
            objentSeccion._nivel = "Inicial"
        End If
        If rbtprimaria.Checked = True Then
            objentSeccion._nivel = "Primaria"
        End If
        objentSeccion._numeroVacantes = txtvacantes.Text
        objentSeccion.objentGrado._codigoGrado = cmbGrado.Text
        objentSeccion.objentNumeroAnno._numeroAnno = cmbannoEscolar.Text
        objentSeccion.objentProfesor._dniProfesor = cmbProfesor.Text
        If objnegSeccion.registrarSeccion(objentSeccion) Then
            MsgBox("Se inserto un nuevo Registro")
            dgvSeccion.DataSource = objnegSeccion.obtenerTabla()
        End If
    End Sub

    Private Sub frmagregarSeccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objnegProfesor As New negProfesor
        Dim objnegAnnoEscolar As New negAnnoEscolar
        Dim objnegSeccion As New negSeccion
        cmbannoEscolar.DataSource = objnegAnnoEscolar.listarAnnoEscolar()
        cmbannoEscolar.DisplayMember = "numeroAnno"
        cmbProfesor.DataSource = objnegProfesor.ListarProfesor()
        cmbProfesor.DisplayMember = "nombreProfesor"
        dgvSeccion.DataSource = objnegSeccion.obtenerTabla()
    End Sub

    Private Sub rbtinicial_CheckedChanged(sender As Object, e As EventArgs) Handles rbtinicial.CheckedChanged
        Dim objnegGrado As New negGrado
        If rbtinicial.Checked = True Then
            cmbGrado.DataSource = objnegGrado.listarGradoInicial
            cmbGrado.DisplayMember = "numeroGrado"
        End If
      
    End Sub

    Private Sub rbtprimaria_CheckedChanged(sender As Object, e As EventArgs) Handles rbtprimaria.CheckedChanged
        Dim objnegGrado As New negGrado
        If rbtprimaria.Checked = True Then
            cmbGrado.DataSource = objnegGrado.listarGradoPrimaria
            cmbGrado.DisplayMember = "numeroGrado"
        End If
    End Sub

    Private Sub txtvacantes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtvacantes.KeyPress
        If Char.IsNumber(e.KeyChar) Then 'Si es numero si entra al textbox
            e.Handled = False
            If txtvacantes.TextLength > 1 Then
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