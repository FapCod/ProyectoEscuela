Imports System.Data.SqlClient
Public Class datAnnoEscolar
    Inherits datConexion
    Public Function listarAnnoEscolar() As DataTable
        Dim cnn As SqlConnection
        Dim cadena As String
        cnn = ObtenerConexion()
        cadena = "SELECT * FROM annoEscolar"
        cnn.Open()
        Dim cmd As New SqlCommand(cadena, cnn)
        Dim dt2 As New DataTable
        dt2.Load(cmd.ExecuteReader())
        Return dt2
    End Function
End Class
