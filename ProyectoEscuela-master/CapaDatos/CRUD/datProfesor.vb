Imports CapaDatos
Imports CapaEntidad
Imports System.Data.SqlClient
Public Class datProfesor
    Inherits datConexion
    Public Function RegistrarProfesor(objeP As entProfesor) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "InsertarProf"
                Command.Parameters.AddWithValue("@nombre", objeP._nombreP)
                Command.Parameters.AddWithValue("@apellido", objeP._apellidoP)
                Command.Parameters.AddWithValue("@correo", objeP._correoP)
                Command.Parameters.AddWithValue("@sexo", objeP._sexoP)
                Command.Parameters.AddWithValue("@telefono", objeP._telefonoP)
                Command.Parameters.AddWithValue("@direccion", objeP._direccionP)
                Command.Parameters.AddWithValue("@asignaturas", objeP._asignaturasP)
                Command.Parameters.AddWithValue("@nivel", objeP._nivelP)
                Command.Parameters.AddWithValue("@grado_secc", objeP._gradoYseccionP)
                Command.Parameters.AddWithValue("@tipo", objeP._tipoP)
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
    Public Function ActualizarProfesor(objeP As entProfesor, id As integer) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "ActualizarProf"
                Command.Parameters.AddWithValue("@id", id)
                Command.Parameters.AddWithValue("@nombre", objeP._nombreP)
                Command.Parameters.AddWithValue("@apellido", objeP._apellidoP)
                Command.Parameters.AddWithValue("@correo", objeP._correoP)
                Command.Parameters.AddWithValue("@sexo", objeP._sexoP)
                Command.Parameters.AddWithValue("@telefono", objeP._telefonoP)
                Command.Parameters.AddWithValue("@direccion", objeP._direccionP)
                Command.Parameters.AddWithValue("@asignaturas", objeP._asignaturasP)
                Command.Parameters.AddWithValue("@nivel", objeP._nivelP)
                Command.Parameters.AddWithValue("@grado_secc", objeP._gradoYseccionP)
                Command.Parameters.AddWithValue("@tipo", objeP._tipoP)
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

    Public Function BuscarProfesor(id As Integer) As DataTable
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "BuscarProf"
                Command.Parameters.AddWithValue("@id", id)
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
    Public Function EliminarProfesor(id As Integer) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "EliminarProf"
                Command.Parameters.AddWithValue("@idprof", id)
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
