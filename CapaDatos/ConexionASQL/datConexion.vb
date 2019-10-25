Imports System.Data.SqlClient
Public MustInherit Class datConexion
    Private cadena_conexion As String
    Private cadena As String
    Protected Sub New()
        'cadena_conexion = "Data Source=FAPCOD\SQLEXPRESS;Initial Catalog=Colegio_DB;Integrated Security=True"
        cadena_conexion = "Data Source=FAPCOD\SQLEXPRESS;Initial Catalog=Colegio_DB;User Id=Profesor;Password=12345678"
    End Sub
    Protected Function ObtenerConexion() As SqlConnection
        Return New SqlConnection(cadena_conexion)
    End Function
    Protected Function ObtenerConexionU() As SqlConnection
        Return New SqlConnection(cadena_conexion)
        Console.Write(cadena)
    End Function

End Class