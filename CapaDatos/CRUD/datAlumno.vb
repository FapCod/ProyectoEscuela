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
                Command.CommandText = "agregaralumno"
                Command.Parameters.AddWithValue("@dniAlumno", objAlumno._dniAlumno)
                Command.Parameters.AddWithValue("@nombreAlumno", objAlumno._nombreAlumno)
                Command.Parameters.AddWithValue("@apellidoAlumno", objAlumno._apellidoAlumno)
                Command.Parameters.AddWithValue("@edadAlumno", objAlumno._edadAlumno)
                Command.Parameters.AddWithValue("@sexoAlumno", objAlumno._sexoAlumno)
                Command.Parameters.AddWithValue("@direccionAlumno", objAlumno._direccionAlumno)
                Command.Parameters.AddWithValue("@nombreApoderadoAlumno", objAlumno._nombreDeApoderadoAlumno)
                Command.Parameters.AddWithValue("@numeroTelefonoApoderado", objAlumno._numeroTelefonoApoderado)

                Command.CommandType = CommandType.StoredProcedure
                Try
                    If Command.ExecuteNonQuery Then
                        Return True
                    Else
                        Return False
                    End If
                Catch ex As Exception
                    MsgBox("Alumno ya registrado")
                End Try
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
                Command.CommandText = "actualizaralumno"
                Command.Parameters.AddWithValue("@dniAlumno", objAlumno._dniAlumno)
                Command.Parameters.AddWithValue("@nombreAlumno", objAlumno._nombreAlumno)
                Command.Parameters.AddWithValue("@apellidoAlumno", objAlumno._apellidoAlumno)
                Command.Parameters.AddWithValue("@edadAlumno", objAlumno._edadAlumno)
                Command.Parameters.AddWithValue("@sexoAlumno", objAlumno._sexoAlumno)
                Command.Parameters.AddWithValue("@direccionAlumno", objAlumno._direccionAlumno)
                Command.Parameters.AddWithValue("@nombreApoderadoAlumno", objAlumno._nombreDeApoderadoAlumno)
                Command.Parameters.AddWithValue("@numeroTelefonoApoderado", objAlumno._numeroTelefonoApoderado)
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
    Public Function eliminarAlumno(dni As String) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "eliminaralumno"
                Command.Parameters.AddWithValue("@dni", dni)
                Command.CommandType = CommandType.StoredProcedure
                Try
                    If Command.ExecuteNonQuery Then
                        Return True
                    Else
                        Return False
                    End If
                Catch ex As Exception
                    Return False
                End Try
                
            End Using
        End Using
        Return False
    End Function
    'Funcion Buscar Alumno
    Public Function buscarAlumno(dni As String) As DataTable
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "buscaralumno"
                Command.Parameters.AddWithValue("@dni", dni)
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

    Public Function obtenerTabla() As DataTable
        Using conexion = ObtenerConexion()
            conexion.Open()
            Dim dt As DataTable
            Dim da As SqlDataAdapter
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandType = CommandType.StoredProcedure
                Command.CommandText = "obtenerTablaAlumno"

                If Command.ExecuteNonQuery Then
                    dt = New DataTable
                    da = New SqlDataAdapter(Command)
                    da.Fill(dt)
                    Return dt
                Else
                    Return Nothing
                End If
            End Using
        End Using
    End Function
    Public Function obtenerTablaListar(anno As Integer, nivel As String, grado As Integer, seccion As Integer) As DataTable
        Using conexion = ObtenerConexion()
            conexion.Open()
            Dim dt As DataTable
            Dim da As SqlDataAdapter
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandType = CommandType.StoredProcedure
                Command.CommandText = "listarAlumnosPorGradoSeccion"
                Command.Parameters.AddWithValue("@anno", anno)
                Command.Parameters.AddWithValue("@nivel", nivel)
                Command.Parameters.AddWithValue("@grado", grado)
                Command.Parameters.AddWithValue("@seccion", seccion)
                If Command.ExecuteNonQuery Then
                    dt = New DataTable
                    da = New SqlDataAdapter(Command)
                    da.Fill(dt)
                    Return dt
                Else
                    Return Nothing
                End If
            End Using
        End Using
    End Function
End Class
