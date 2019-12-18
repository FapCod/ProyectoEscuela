Imports CapaNegocio
Public Class frmListarMestros
#Region "Funcionalidad de la ventana"

    Private Sub frmListarMestros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objnegAnnoEscolar As New negAnnoEscolar
        cmbannoEscolar.DataSource = objnegAnnoEscolar.listarAnnoEscolar()
        cmbannoEscolar.DisplayMember = "numeroAnno"
    End Sub
    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Dim conexion As New negProfesor
        DataGridView1.DataSource = conexion.obtenerTabla()
    End Sub


    Private Sub cmbcodGrado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcodGrado.SelectedIndexChanged
        If rbtinicial.Checked = True Then
            cargarDatosSeccionInicial()
        ElseIf rbtPrimaria.Checked = True Then
            cargarDatosSeccionPrimaria()
        Else
            MsgBox("Debe elegir primaria o inicial")
        End If
    End Sub

    Public Sub cargarDatosSeccionInicial()
        Dim objneg As New negSeccion
        cmbcodseccion.DataSource = objneg.cargarSeccion(Val(cmbcodGrado.Text), Val(cmbannoEscolar.Text))
        cmbcodseccion.DisplayMember = "nombreSeccion"
        cmbcodseccion.ValueMember = "codigoSeccion"
    End Sub
    Public Sub cargarDatosSeccionPrimaria()
        Dim objneg As New negSeccion
        cmbcodseccion.DataSource = objneg.cargarSeccionP(Val(cmbcodGrado.Text), Val(cmbannoEscolar.Text))
        cmbcodseccion.DisplayMember = "nombreSeccion"
        cmbcodseccion.ValueMember = "codigoSeccion"
    End Sub

    Private Sub rbtinicial_CheckedChanged(sender As Object, e As EventArgs) Handles rbtinicial.CheckedChanged
        Dim objnegGrado As New negGrado
        Dim objnegCurso As New negCurso
        If rbtinicial.Checked = True Then
            cmbcodGrado.DataSource = objnegGrado.listarGradoInicial
            cmbcodGrado.DisplayMember = "numeroGrado"
            cmbcodGrado.ValueMember = "codigoGrado"
        End If
    End Sub

    Private Sub rbtPrimaria_CheckedChanged(sender As Object, e As EventArgs) Handles rbtPrimaria.CheckedChanged
        Dim objnegGrado As New negGrado
        Dim objnegCurso As New negCurso
        If rbtPrimaria.Checked = True Then
            cmbcodGrado.DataSource = objnegGrado.listarGradoPrimaria
            cmbcodGrado.DisplayMember = "numeroGrado"
            cmbcodGrado.ValueMember = "codigoGrado"
        End If
    End Sub


    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim objneg As New negProfesor
        Dim nivel As String = ""
        If rbtinicial.Checked = True Then
            nivel = "Inicial"
        ElseIf rbtPrimaria.Checked = True Then
            nivel = "Primaria"
        End If
        DataGridView1.DataSource = objneg.ObtenerTablaListar(cmbannoEscolar.Text, nivel, cmbcodGrado.SelectedValue, cmbcodseccion.SelectedValue)
    End Sub

#End Region

#Region "Finalizar"
    Protected Overrides Sub Finalize()
        Me.Close()
    End Sub
#End Region

End Class