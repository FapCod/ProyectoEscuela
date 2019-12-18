Imports CapaNegocio
Imports CapaEntidad
Public Class frmAgregarNota
#Region "Funcionalidad de la ventana"

    Private Sub frmAgregarNota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objnegTrimestre As New negTrimestre
        cmbtrimestre.DataSource = objnegTrimestre.listarTrimestre()
        cmbtrimestre.DisplayMember = "descripcionTrimestre"
        DataGridView2.Visible = False
    End Sub

    Private Sub btnagregarNota_Click(sender As Object, e As EventArgs) Handles btnagregarNota.Click
        Dim objentNotas As New entNota
        If comprobar() Then
            Dim dniAlumno As Integer
            dniAlumno = DataGridView2.CurrentRow.Cells(0).Value
            objentNotas._nota = cmbnota.Text
            objentNotas._descripcion = cmbCompetencia.Text
            objentNotas.objentAlumno._dniAlumno = dniAlumno
            objentNotas.objentAnnoEscolar._numeroAnno = cmbannoEscolar.Text
            objentNotas.objentCurso._codigoCurso = cmbcodigocurso.SelectedValue
            If cmbtrimestre.Text = "Primer Trimestre" Then
                objentNotas.objentTrimestre._codigoTrimestre = "1Tri"
            ElseIf cmbtrimestre.Text = "Segundo Trimestre" Then
                objentNotas.objentTrimestre._codigoTrimestre = "2Tri"
            ElseIf cmbtrimestre.Text = "Tercer Trimestre" Then
                objentNotas.objentTrimestre._codigoTrimestre = "3Tri"
            End If
            objentNotas._eliminacionLogica = False
            Dim objnegNota As New negNota
            If objnegNota.validarSiExisteNota(objentNotas) = 0 Then
                Dim objnegM As New negMatricula
                Dim nivelM As String = Nothing
                If rbtInicial.Checked = True Then
                    nivelM = "Inicial"
                ElseIf rbtprimaria.Checked = True Then
                    nivelM = "Primaria"
                End If
                If objnegM.VerificarSiEsDeInicialoPrimariaInteger(txtapellidoAlumno.Text, nivelM) = 1 Then
                    Dim verificarRA = objnegNota.registrarNota(objentNotas)
                    If verificarRA = True Then
                        MsgBox("registro exitoso")
                        DataGridView1.DataSource = objnegNota.obtenerTabla(objentNotas)
                        DataGridView1.Columns(0).Visible = False
                        LimpiarDatos()
                        'Ver()
                    Else
                        MsgBox("Error de registro de nota")
                    End If
                Else
                    MsgBox("El alumno no existe en ese nivel")
                End If
            Else
                MsgBox("Ya existe Nota para aquella competencia")
            End If
        Else
            MsgBox("Debe llenar los datos que le faltan", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub btneditarNota_Click(sender As Object, e As EventArgs) Handles btneditarNota.Click
        Dim idNota As Integer
        Dim i As Integer
        Dim objnegNota As New negNota
        i = DataGridView1.CurrentRow.Index
        idNota = DataGridView1.Item(0, i).Value()
        Dim dniAlumno As String
        dniAlumno = DataGridView2.CurrentRow.Cells(0).Value
        Dim objentNotas As New entNota
        If comprobar() Then
            objentNotas._nota = cmbnota.Text
            objentNotas._descripcion = cmbCompetencia.Text
            objentNotas.objentAlumno._dniAlumno = dniAlumno
            objentNotas.objentAnnoEscolar._numeroAnno = cmbannoEscolar.Text
            objentNotas.objentCurso._codigoCurso = cmbcodigocurso.SelectedValue
            If cmbtrimestre.Text = "Primer Trimestre" Then
                objentNotas.objentTrimestre._codigoTrimestre = "1Tri"
            ElseIf cmbtrimestre.Text = "Segundo Trimestre" Then
                objentNotas.objentTrimestre._codigoTrimestre = "2Tri"
            ElseIf cmbtrimestre.Text = "Tercer Trimestre" Then
                objentNotas.objentTrimestre._codigoTrimestre = "3Tri"
            End If
            objentNotas._eliminacionLogica = False
            If objnegNota.validarSiExisteNota(objentNotas) = 0 Then
                Dim verificarRA = objnegNota.editarNota(objentNotas, idNota)
                If verificarRA = True Then
                    MsgBox("Actualizacion exitosa")
                    DataGridView1.DataSource = objnegNota.obtenerTabla(objentNotas)
                    DataGridView1.Columns(0).Visible = False
                    radioButtonEnabletrue()
                    LimpiarDatos()
                    'Ver()
                Else
                    MsgBox("Error al actualizar nota")
                End If

            Else
                MsgBox("Ya existe Nota para aquella competencia")
            End If

        Else
            MsgBox("Debe llenar los datos que le faltan", MsgBoxStyle.Information)
        End If
    End Sub



    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        Dim nivel As String
        nivel = DataGridView1.Item(1, i).Value()
        Dim comparar As Integer
        Dim nievelA As String = "Primaria"
        comparar = nivel.CompareTo(nievelA)
        If comparar = 0 Then
            rbtprimaria.Checked = True
        Else
            rbtInicial.Checked = True
        End If
        txtapellidoAlumno.Text = DataGridView1.Item(3, i).Value()
        cmbtrimestre.Text = DataGridView1.Item(5, i).Value()
        cmbcodigocurso.Text = DataGridView1.Item(6, i).Value()
        cmbCompetencia.Text = DataGridView1.Item(7, i).Value()
        cmbannoEscolar.Text = DataGridView1.Item(8, i).Value()
        cmbnota.Text = DataGridView1.Item(9, i).Value()

        radioButtonEnableFalse()
    End Sub



    Private Sub txtapellidoAlumno_TextChanged(sender As Object, e As EventArgs) Handles txtapellidoAlumno.TextChanged
        Dim objneg As New negMatricula

        If rbtInicial.Checked = True Then
            DataGridView2.DataSource = objneg.VerificarSiEsDeInicialoPrimaria(txtapellidoAlumno.Text, rbtInicial.Text)
            DataGridView2.Visible = True
        ElseIf rbtprimaria.Checked = True Then
            DataGridView2.DataSource = objneg.VerificarSiEsDeInicialoPrimaria(txtapellidoAlumno.Text, rbtprimaria.Text)
            DataGridView2.Visible = True
        Else
            MsgBox("Debe seleccionar Inicial o Primaria")
        End If
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        cmbannoEscolar.DropDownStyle = ComboBoxStyle.DropDown
        Dim dniAlumno As Integer
        dniAlumno = DataGridView2.CurrentRow.Cells(0).Value
        txtapellidoAlumno.Text = DataGridView2.CurrentRow.Cells(1).Value
        cmbannoEscolar.Text = DataGridView2.CurrentRow.Cells(3).Value
        DataGridView2.Visible = False
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
    Private Sub cmbannoEscolar_MouseHover(sender As Object, e As EventArgs) Handles cmbannoEscolar.MouseHover
        cmbannoEscolar.Items.Add(cmbannoEscolar.Text)
        cmbannoEscolar.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub
#End Region

#Region "metodos creados"
    Public Sub LimpiarDatos()
        txtapellidoAlumno.Clear()
        rbtInicial.Checked = False
        rbtprimaria.Checked = False
        cmbCompetencia.Text = Nothing
        cmbnota.Text = Nothing
        DataGridView2.Visible = False
    End Sub
    Public Sub radioButtonEnableFalse()
        If rbtInicial.Checked = True Then
            rbtprimaria.Enabled = False
        ElseIf rbtprimaria.Checked = True Then
            rbtInicial.Enabled = False
        End If
    End Sub
    Public Sub radioButtonEnabletrue()
        rbtprimaria.Enabled = True
        rbtInicial.Enabled = True
    End Sub
#End Region

#Region "funciones creadas"
    Private Function comprobar() As Boolean
        If Len(Trim$(txtapellidoAlumno.Text)) <> 0 And Len(Trim$(cmbannoEscolar.Text)) <> 0 And Len(Trim$(cmbnota.Text)) <> 0 And Len(Trim$(cmbCompetencia.Text)) <> 0 Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region

#Region "validacion de numeros y letras"
    Private Sub txtapellidoAlumno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapellidoAlumno.KeyPress
        If Char.IsLetter(e.KeyChar) Then 'Si es letra si entra al textbox

            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then 'Si es una tecla de control si entra al textbox
            e.Handled = False
        Else
            e.Handled = True   'Si es number no entra al textbox
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

#End Region
    
#Region "Finalizar"
    Protected Overrides Sub Finalize()
        Me.Close()
    End Sub
#End Region

End Class