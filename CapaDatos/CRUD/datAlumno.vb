Imports CapaDatos
Imports CapaEntidad
Imports System.Data.SqlClient
Public Class datAlumno
    Inherits datConexion
    'Funcion Registrar Alumno
    Public Function registrarAlumno(objAlumno As entAlumno) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = ""
                Command.Parameters.AddWithValue("@dniAlumno", objAlumno._nombreAlumno)
                Command.Parameters.AddWithValue("@nombreAlumno", objAlumno._nombreAlumno)
                Command.Parameters.AddWithValue("@apellidoAlumno", objAlumno._apellidoAlumno)
                Command.Parameters.AddWithValue("@sexoAlumno", objAlumno._sexoAlumno)
                Command.Parameters.AddWithValue("@nivelAlumno", objAlumno._nivelAlumno)
                Command.Parameters.AddWithValue("@gradoSeccionAlumno", objAlumno._gradoSeccionAlumno)
                Command.Parameters.AddWithValue("@direccionAlumno", objAlumno._direccionAlumno)
                Command.Parameters.AddWithValue("@nombreApoderadoAlumno", objAlumno._nombreDeApoderadoAlumno)
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
    'Funcion Editar Alumno
    Public Function editarAlumno(objAlumno As entAlumno) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = ""
                Command.Parameters.AddWithValue("@nombreAlumno", objAlumno._nombreAlumno)
                Command.Parameters.AddWithValue("@apellidoAlumno", objAlumno._apellidoAlumno)
                Command.Parameters.AddWithValue("@sexoAlumno", objAlumno._sexoAlumno)
                Command.Parameters.AddWithValue("@nivelAlumno", objAlumno._nivelAlumno)
                Command.Parameters.AddWithValue("@gradoSeccionAlumno", objAlumno._gradoSeccionAlumno)
                Command.Parameters.AddWithValue("@direccionAlumno", objAlumno._direccionAlumno)
                Command.Parameters.AddWithValue("@nombreApoderadoAlumno", objAlumno._nombreDeApoderadoAlumno)
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
    'Funcion Eliminar Alumno
    Public Function eliminarAlumno(objAlumno As entAlumno) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = ""
                'Command.Parameters.AddWithValue("")
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
    'Funcion Buscar Alumno
    Public Function buscarAlumno(objAlumno As entAlumno) As DataTable
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = ""
                'Command.Parameters.AddWithValue()
                Command.CommandType = CommandType.StoredProcedure
                Dim dt1 As New DataTable
                dt1.Load(Command.ExecuteReader())
                If Command.ExecuteNonQuery Then
                    Return dt1
                Else
                    Return Nothing
                End If
            End Using
        End Using
        Return Nothing
    End Function
    'FUNCION PARA OBTENER LA TABLA DE ALUMNOS

    Public Function obtenerTabla(ByVal query As String) As DataTable
        Dim cnn As SqlConnection
        'Dim cadena As String
        cnn = ObtenerConexion()
        'cnn = New SqlConnection(cadena)
        cnn.Open()
        Dim cmd As New SqlCommand(query, cnn)
        Dim dt1 As New DataTable
        dt1.Load(cmd.ExecuteReader())
        Return dt1
    End Function
End Class
