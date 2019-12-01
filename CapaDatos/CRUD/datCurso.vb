Imports System.Data.SqlClient
Public Class datCurso
    Inherits datConexion
    Public Function listarCursoInicial() As DataTable
        Dim cnn As SqlConnection
        Dim cadena As String
        cnn = ObtenerConexion()
        cadena = "SELECT * FROM curso where nivel = 'Inicial'"
        cnn.Open()
        Dim cmd As New SqlCommand(cadena, cnn)
        Dim dt2 As New DataTable
        dt2.Load(cmd.ExecuteReader())
        Return dt2
    End Function
    Public Function listarCursoPrimaria() As DataTable
        Dim cnn As SqlConnection
        Dim cadena As String
        cnn = ObtenerConexion()
        cadena = "SELECT * FROM curso where nivel = 'Primaria'"
        cnn.Open()
        Dim cmd As New SqlCommand(cadena, cnn)
        Dim dt2 As New DataTable
        dt2.Load(cmd.ExecuteReader())
        Return dt2
    End Function
End Class
