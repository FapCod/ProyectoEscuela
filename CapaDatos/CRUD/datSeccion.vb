Imports CapaDatos
Imports CapaEntidad
Imports System.Data.SqlClient
Public Class datSeccion
    Inherits datConexion

    Public Function RegistrarSeccion(objeS As entSeccion) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "AgregarSeccion"
                Command.Parameters.AddWithValue("@Grado", objeS.GradoAula)
                Command.Parameters.AddWithValue("@Seccion", objeS.Seccion)
                Command.Parameters.AddWithValue("@NAula", objeS.NAula)
                Command.Parameters.AddWithValue("@Nivel", objeS.Nivel)
                'Command.Parameters.AddWithValue("idprofesor", objeS.objProfesor._nombreP)
                Command.CommandType = CommandType.StoredProcedure
                If Command.ExecuteNonQuery Then
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
        Return False
    End Function
    Public Function obtenerTablaSecc(ByVal query As String) As DataTable
        Dim cnn As SqlConnection
        'Dim cadena As String
        cnn = ObtenerConexion()
        'cnn = New SqlConnection(cadena)
        cnn.Open()
        Dim cmd As New SqlCommand(query, cnn)
        Dim dt3 As New DataTable
        dt3.Load(cmd.ExecuteReader())
        Return dt3
    End Function
    Public Function obtenerCombobox(ByVal query As String) As DataTable
        Dim cnn As SqlConnection
        'Dim cadena As String
        cnn = ObtenerConexion()
        'cnn = New SqlConnection(cadena)
        cnn.Open()
        Dim cmd As New SqlCommand(query, cnn)
        Dim dt3 As New DataTable
        dt3.Load(cmd.ExecuteReader())
        Return dt3
    End Function
End Class
