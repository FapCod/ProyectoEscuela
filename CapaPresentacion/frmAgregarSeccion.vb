Imports CapaNegocio
Imports CapaEntidad
Public Class frmAgregarSeccion

    Private Sub frmAgregarSeccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ver()
    End Sub

    Sub Ver()
        Dim conexion As New negSeccion
        dgvSeccionPrimaria.DataSource = conexion.obtenerTablaSecc("SELECT GradoAula, nombreSeccion, NumAula , Nivel from Grado_Seccion where Nivel = 'Primaria' ")
        dgvSeccionInicial.DataSource = conexion.obtenerTablaSecc("SELECT GradoAula, nombreSeccion, NumAula , Nivel from Grado_Seccion where Nivel = 'Inicial' ")
    End Sub

    
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim objeS As New entSeccion

        objeS.GradoAula = Val(txtGrado.Text)
        objeS.Seccion = txtSeccion.Text
        objeS.NAula = Val(txtNumAula.Text)
        If rbtIncial.Checked = True Then
            objeS.Nivel = "Inicial"
        End If
        If rbtPrimaria.Checked = True Then
            objeS.Nivel = "Primaria"
        End If
        Dim negSecc As New negSeccion
        Dim verificarRS = negSecc.RegistrarSeccion(objeS)
        If verificarRS = True Then
            MsgBox("Registro Exitoso")
        Else
            MsgBox("Error de registro de Seccion")
        End If
        Ver()
        LimpiarDatos()
    End Sub

    Public Sub LimpiarDatos()
        txtGrado.Clear()
        txtSeccion.Clear()
        txtNumAula.Clear()
        rbtIncial.Checked = False
        rbtPrimaria.Checked = False
    End Sub
End Class