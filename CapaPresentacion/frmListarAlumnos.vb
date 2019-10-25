Imports CapaNegocio
Public Class frmListarAlumnos

    Private Sub frmListarAlumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ver()
    End Sub

    Sub Ver()
        Dim conexion As New negALUMNO
        DataGridView1.DataSource = conexion.obtenerTabla("select * from ALUMNO")
    End Sub

    Private Sub btnEditarA_Click(sender As Object, e As EventArgs) Handles btnEditarA.Click
        Dim conexion As New negAlumno
        DataGridView1.DataSource = conexion.obtenerTabla("exec MostarAlum 'A' , '4'")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim grado As Integer
        grado = nmGrado.Value
        Console.Write(grado)
        Dim conexion As New negAlumno
        DataGridView1.DataSource = conexion.obtenerTabla("exec GradoAlum " + grado)
    End Sub
End Class