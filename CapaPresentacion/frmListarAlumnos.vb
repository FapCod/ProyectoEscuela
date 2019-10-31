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
        Dim cadena As String
        grado = Integer.Parse(cmbGrado.Text)
        If grado = 1 Then
            cadena = Convert.ToString("exec GradoAlum 1")
            Dim conexion As New negAlumno
            DataGridView1.DataSource = conexion.obtenerTabla(cadena)
        ElseIf grado = 2 Then
            cadena = Convert.ToString("exec GradoAlum 2")
            Dim conexion As New negAlumno
            DataGridView1.DataSource = conexion.obtenerTabla(cadena)
        ElseIf grado = 3 Then
            cadena = Convert.ToString("exec GradoAlum 3")
            Dim conexion As New negAlumno
            DataGridView1.DataSource = conexion.obtenerTabla(cadena)
        ElseIf grado = 4 Then
            cadena = Convert.ToString("exec GradoAlum 4")
            Dim conexion As New negAlumno
            DataGridView1.DataSource = conexion.obtenerTabla(cadena)
        ElseIf grado = 5 Then
            cadena = Convert.ToString("exec GradoAlum 5")
            Dim conexion As New negAlumno
            DataGridView1.DataSource = conexion.obtenerTabla(cadena)
        ElseIf grado = 6 Then
            cadena = Convert.ToString("exec GradoAlum 6")
            Dim conexion As New negAlumno
            DataGridView1.DataSource = conexion.obtenerTabla(cadena)
        End If
        Console.Write(grado)
       
    End Sub

    
End Class