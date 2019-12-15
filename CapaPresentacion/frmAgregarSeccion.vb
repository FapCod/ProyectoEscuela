Imports CapaEntidad
Imports CapaNegocio
Public Class frmagregarSeccion
#Region "Funcionalidad de las ventanas"
    Private Sub frmagregarSeccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objnegProfesor As New negProfesor
        Dim objnegAnnoEscolar As New negAnnoEscolar
        Dim objnegSeccion As New negSeccion
        cmbannoEscolar.DataSource = objnegAnnoEscolar.listarAnnoEscolar()
        cmbannoEscolar.DisplayMember = "numeroAnno"
        cmbProfesor.DataSource = objnegProfesor.ListarProfesor()
        cmbProfesor.DisplayMember = "nombreProfesor"
        cmbProfesor.ValueMember = "dniProfesor"

        dgvSeccion.DataSource = objnegSeccion.obtenerTabla()
    End Sub
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim objentSeccion As New entSeccion
        Dim objnegSeccion As New negSeccion
        If (comprobar()) Then
            objentSeccion._nombreSeccion = txtSeccion.Text
            If rbtinicial.Checked = True Then
                objentSeccion._nivel = "Inicial"
            End If
            If rbtprimaria.Checked = True Then
                objentSeccion._nivel = "Primaria"
            End If
            objentSeccion._numeroVacantes = txtvacantes.Text
            objentSeccion.objentGrado._codigoGrado = cmbGrado.SelectedValue
            objentSeccion.objentNumeroAnno._numeroAnno = Val(cmbannoEscolar.Text)
            objentSeccion.objentProfesor._dniProfesor = cmbProfesor.SelectedValue
            If rbtinicial.Checked = True Then
                If objnegSeccion.VerificarSiExisteSeccionYGradoI(objentSeccion) = 0 Then
                    If objnegSeccion.registrarSeccion(objentSeccion) Then
                        MsgBox("Se inserto un nuevo Registro")
                        dgvSeccion.DataSource = objnegSeccion.obtenerTabla()
                    End If
                Else
                    MsgBox("Ya existe seccion con ese grado")
                    txtSeccion.Focus()
                End If
            ElseIf rbtprimaria.Checked = True Then
                If objnegSeccion.VerificarSiExisteSeccionYGradoP(objentSeccion) = 0 Then
                    If objnegSeccion.registrarSeccion(objentSeccion) Then
                        MsgBox("Se inserto un nuevo Registro")
                        dgvSeccion.DataSource = objnegSeccion.obtenerTabla()
                    End If
                Else
                    MsgBox("Ya existe seccion con ese grado")
                    txtSeccion.Focus()
                End If
            End If

        Else
            MsgBox("Debe de llenar todos los campos")
        End If
    End Sub
    Private Sub rbtinicial_CheckedChanged(sender As Object, e As EventArgs) Handles rbtinicial.CheckedChanged
        Dim objnegGrado As New negGrado
        If rbtinicial.Checked = True Then
            cmbGrado.DataSource = objnegGrado.listarGradoInicial
            cmbGrado.DisplayMember = "numeroGrado"
            cmbGrado.ValueMember = "codigoGrado"
        End If
    End Sub

    Private Sub rbtprimaria_CheckedChanged(sender As Object, e As EventArgs) Handles rbtprimaria.CheckedChanged
        Dim objnegGrado As New negGrado
        If rbtprimaria.Checked = True Then
            cmbGrado.DataSource = objnegGrado.listarGradoPrimaria
            cmbGrado.DisplayMember = "numeroGrado"
            cmbGrado.ValueMember = "codigoGrado"
        End If
    End Sub
#End Region

#Region "metodos creados"

#End Region

#Region "funciones creadas"
    Private Function comprobar() As Boolean
        If Len(Trim$(txtSeccion.Text)) <> 0 And Len(Trim$(txtvacantes.Text)) <> 0 And Len(Trim$(cmbGrado.Text)) <> 0 And Len(Trim$(cmbannoEscolar.Text)) <> 0 And Len(Trim$(cmbProfesor.Text)) <> 0 Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region

#Region "Validar numeros y letras"
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

    Private Sub txtSeccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSeccion.KeyPress
        If Char.IsLetter(e.KeyChar) Then 'Si es letra si entra al textbox
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then 'Si es una tecla de control si entra al textbox
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then 'Si es espacio si entra al textbox
            e.Handled = False
        Else
            e.Handled = True   'Si es numero no entra al textbox
        End If
    End Sub
#End Region

#Region "los colores cambian"
    Private Sub btnguardar_MouseEnter(sender As Object, e As EventArgs) Handles btnguardar.MouseEnter
        btnguardar.BackColor = Color.DeepSkyBlue
    End Sub

    Private Sub btnguardar_MouseLeave(sender As Object, e As EventArgs) Handles btnguardar.MouseLeave
        btnguardar.BackColor = Color.DodgerBlue
    End Sub
#End Region

#Region "Finalizar"
    Protected Overrides Sub Finalize()
        Me.Close()
    End Sub
#End Region

End Class