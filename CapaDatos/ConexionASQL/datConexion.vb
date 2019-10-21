Imports System.Data.SqlClient
Public MustInherit Class datConexion
    Private cadena_conexion As String
    Protected Sub New()
        cadena_conexion = "Data Source=FAPCOD\SQLEXPRESS;Initial Catalog=Colegio_DB;Integrated Security=True"

    End Sub
    Protected Function ObtenerConexion() As SqlConnection
        Return New SqlConnection(cadena_conexion)
    End Function
End Class