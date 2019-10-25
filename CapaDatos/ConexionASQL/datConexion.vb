Imports System.Data.SqlClient
Public MustInherit Class datConexion
    Private cadena_conexion As String
    Private cadena As String
    Protected Sub New()
        cadena_conexion = "Data Source=FAPCOD\SQLEXPRESS;Initial Catalog=Colegio_DB;Integrated Security=True"

    End Sub
    Protected Sub cone(user As String, pass As String)
        cadena = "Data Source=FAPCOD\SQLEXPRESS;Initial Catalog=Colegio_DB;User Id=" + user + ";Password=" + pass
    End Sub
    Protected Function ObtenerConexion() As SqlConnection
        Return New SqlConnection(cadena_conexion)
    End Function
    Protected Function ObtenerConexionU() As SqlConnection
        Return New SqlConnection(cadena)
        Console.Write(cadena)
    End Function

End Class