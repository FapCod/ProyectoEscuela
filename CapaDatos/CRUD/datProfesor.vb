Imports CapaDatos
Imports CapaEntidad
Imports System.Data.SqlClient
Public Class datProfesor
    Inherits datConexion
    Public Function registrarProfesor(objProfesor As entProfesor) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = ""
                Command.Parameters.AddWithValue("@nombreProfesor", objProfesor._nombreProfesor)
                Command.Parameters.AddWithValue("@apellidoProfesor", objProfesor._apellidoProfesor)
                Command.Parameters.AddWithValue("@correoProfesor", objProfesor._correoProfesor)
                Command.Parameters.AddWithValue("@sexoProfesor", objProfesor._sexoProfesor)
                Command.Parameters.AddWithValue("@telefonoProfesor", objProfesor._telefonoProfesor)
                Command.Parameters.AddWithValue("@direccionProfesor", objProfesor._direccionProfesor)
                Command.Parameters.AddWithValue("@tipoProfesor", objProfesor._tipoProfesor)
                Command.CommandType = CommandType.StoredProcedure
                'Dim reader = Command.ExecuteReader()
                If Command.ExecuteNonQuery Then
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
        Return False
    End Function

    Public Function actualizarProfesor(objProfesor As entProfesor) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = ""
                Command.Parameters.AddWithValue("@nombreProfesor", objProfesor._nombreProfesor)
                Command.Parameters.AddWithValue("@apellidoProfesor", objProfesor._apellidoProfesor)
                Command.Parameters.AddWithValue("@correoProfesor", objProfesor._correoProfesor)
                Command.Parameters.AddWithValue("@sexoProfesor", objProfesor._sexoProfesor)
                Command.Parameters.AddWithValue("@telefonoProfesor", objProfesor._telefonoProfesor)
                Command.Parameters.AddWithValue("@direccionProfesor", objProfesor._direccionProfesor)
                Command.Parameters.AddWithValue("@tipoProfesor", objProfesor._tipoProfesor)
                Command.CommandType = CommandType.StoredProcedure
                'Dim reader = Command.ExecuteReader()
                If Command.ExecuteNonQuery Then
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
        Return False
    End Function

    Public Function buscarProfesor(objProfesor As entProfesor) As DataTable
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = ""
                'Command.Parameters.AddWithValue()
                Command.CommandType = CommandType.StoredProcedure
                Dim dt2 As New DataTable
                dt2.Load(Command.ExecuteReader())
                If Command.ExecuteNonQuery Then
                    Return dt2
                Else
                    Return Nothing
                End If
            End Using
        End Using
        Return Nothing
    End Function
    Public Function eliminarProfesor(objProfesor As entProfesor) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = ""
                'Command.Parameters.AddWithValue()
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

    Public Function obtenerTabla(ByVal query As String) As DataTable
        Dim cnn As SqlConnection
        'Dim cadena As String
        cnn = ObtenerConexion()
        'cnn = New SqlConnection(cadena)
        cnn.Open()
        Dim cmd As New SqlCommand(query, cnn)
        Dim dt2 As New DataTable
        dt2.Load(cmd.ExecuteReader())
        Return dt2
    End Function
End Class
