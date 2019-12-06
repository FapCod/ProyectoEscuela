Imports System.Data.SqlClient
Public Class datGrado
    Inherits datConexion
    Public Function listarGradoInicial() As DataTable
        Dim cnn As SqlConnection
        Dim cadena As String
        cnn = ObtenerConexion()
        cadena = "listarGradoI "
        cnn.Open()
        Dim cmd As New SqlCommand(cadena, cnn)
        Dim dt2 As New DataTable
        dt2.Load(cmd.ExecuteReader())
        Return dt2
    End Function
    Public Function listarGradoPrimaria() As DataTable
        Dim cnn As SqlConnection
        Dim cadena As String
        cnn = ObtenerConexion()
        cadena = "listarGradoP"
        cnn.Open()
        Dim cmd As New SqlCommand(cadena, cnn)
        Dim dt3 As New DataTable
        dt3.Load(cmd.ExecuteReader())
        Return dt3
    End Function
End Class
