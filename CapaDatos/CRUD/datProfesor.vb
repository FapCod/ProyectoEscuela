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
                Command.CommandText = "agregarProfesor"
                Command.Parameters.AddWithValue("@dniProfesor", objProfesor._dniProfesor)
                Command.Parameters.AddWithValue("@nombreProfesor", objProfesor._nombreProfesor)
                Command.Parameters.AddWithValue("@apellidoProfesor", objProfesor._apellidoProfesor)
                Command.Parameters.AddWithValue("@edadProfesor", objProfesor._edadProfesor)
                Command.Parameters.AddWithValue("@sexoProfesor", objProfesor._sexoProfesor)
                Command.Parameters.AddWithValue("@direccionProfesor", objProfesor._direccionProfesor)
                Command.Parameters.AddWithValue("@correoProfesor", objProfesor._correoProfesor)
                Command.Parameters.AddWithValue("@telefonoProfesor", objProfesor._telefonoProfesor)
                Command.Parameters.AddWithValue("@codigoAula", objProfesor.objentAula._codigoAula)
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
                Command.CommandText = "actualizarProfesor"
                Command.Parameters.AddWithValue("@dniProfesor", objProfesor._dniProfesor)
                Command.Parameters.AddWithValue("@nombreProfesor", objProfesor._nombreProfesor)
                Command.Parameters.AddWithValue("@apellidoProfesor", objProfesor._apellidoProfesor)
                Command.Parameters.AddWithValue("@edadProfesor", objProfesor._edadProfesor)
                Command.Parameters.AddWithValue("@sexoProfesor", objProfesor._sexoProfesor)
                Command.Parameters.AddWithValue("@direccionProfesor", objProfesor._direccionProfesor)
                Command.Parameters.AddWithValue("@correoProfesor", objProfesor._correoProfesor)
                Command.Parameters.AddWithValue("@telefonoProfesor", objProfesor._telefonoProfesor)
                Command.Parameters.AddWithValue("@codigoAula", objProfesor.objentAula._codigoAula)
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

    Public Function buscarProfesor(dni As String) As DataTable
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "buscarprofesor"
                Command.Parameters.AddWithValue("@dniProfesor", dni)
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
    Public Function eliminarProfesor(dni As String) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "eliminarProfesor"
                Command.Parameters.AddWithValue("@dni", dni)
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

    Public Function obtenerTabla() As DataTable
        Dim cnn As SqlConnection
        Dim cadena As String
        cnn = ObtenerConexion()
        cadena = "SELECT dbo.profesor.dniProfesor, dbo.profesor.nombreProfesor, dbo.profesor.apellidoProfesor, dbo.profesor.edadProfesor, dbo.profesor.sexoProfesor, dbo.profesor.direccionProfesor, dbo.profesor.correoProfesor, dbo.profesor.telefonoProfesor, dbo.aula.nombreAula  FROM     dbo.aula INNER JOIN dbo.profesor ON dbo.aula.codigoAula = dbo.profesor.codigoAula"
        cnn.Open()
        Dim cmd As New SqlCommand(cadena, cnn)
        Dim dt2 As New DataTable
        dt2.Load(cmd.ExecuteReader())
        Return dt2
    End Function
End Class
