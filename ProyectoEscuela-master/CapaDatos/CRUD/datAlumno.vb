Imports CapaDatos
Imports CapaEntidad
Imports System.Data.SqlClient
Public Class datAlumno
    Inherits datConexion
    'Funcion Registrar Alumno
    Public Function RegistrarAlumno(objeA As entAlumno) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "RegistrarAlum"
                Command.Parameters.AddWithValue("@NombreAlumno", objeA._NombreA)
                Command.Parameters.AddWithValue("@ApellidosAlumno", objeA._ApellidosA)
                Command.Parameters.AddWithValue("@SexoAlumno", objeA._SexoA)
                Command.Parameters.AddWithValue("@NivelAlumno", objeA._NivelA)
                Command.Parameters.AddWithValue("@GradoAlumno", objeA._GradoA)
                Command.Parameters.AddWithValue("@SeccionAlumno", objeA._SeccionA)
                Command.Parameters.AddWithValue("@DireccionAlumno", objeA._DireccionA)
                Command.Parameters.AddWithValue("@NombreApoderado", objeA._NombreApo)
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
    Public Function editarAlumno(objeA As entAlumno, id As Integer) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "ActualizarAlum"
                Command.Parameters.AddWithValue("@id", id)
                Command.Parameters.AddWithValue("@nombre", objeA._NombreA)
                Command.Parameters.AddWithValue("@apellido", objeA._ApellidosA)
                Command.Parameters.AddWithValue("@sexo", objeA._SexoA)
                Command.Parameters.AddWithValue("@nivel", objeA._NivelA)
                Command.Parameters.AddWithValue("@grado", objeA._GradoA)
                Command.Parameters.AddWithValue("@seccion", objeA._SeccionA)
                Command.Parameters.AddWithValue("@direccion", objeA._DireccionA)
                Command.Parameters.AddWithValue("@nombreApoderado", objeA._NombreApo)
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
    Public Function eliminarAlumno(id As Integer) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "EliminarAlum"
                Command.Parameters.AddWithValue("@idalumn", id)
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
    Public Function buscarAlumno(id As Integer) As DataTable
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "BuscarAlum"
                Command.Parameters.AddWithValue("@id", id)
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
