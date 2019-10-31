Imports System.Data.SqlClient
Public MustInherit Class datConexion
    Private cadena_conexion As String
    Private cadena As String

    Protected Sub New()

        'cadena_conexion = "Data Source=FAPCOD\SQLEXPRESS;Initial Catalog=Colegio_DB;Integrated Security=True"

        cadena_conexion = "Data Source=FAPCOD\SQLEXPRESS;Initial Catalog=Colegio_DB;User Id=profesor;Password=12345678"

    End Sub
    'Protected Sub usuario2(user As String, pass As String)
    '    'cadena_conexion = "Data Source=FAPCOD\SQLEXPRESS;Initial Catalog=Colegio_DB;Integrated Security=True"
    '    cadena_conexion = "Data Source=FAPCOD\SQLEXPRESS;Initial Catalog=Colegio_DB;User Id=" + user + ";Password=" + pass
    '    MsgBox(cadena_conexion)
    'End Sub
    Protected Function ObtenerConexion() As SqlConnection
        Return New SqlConnection(cadena_conexion)
    End Function
    Protected Function ObtenerConexionU() As SqlConnection
        Return New SqlConnection(cadena_conexion)
    End Function

End Class