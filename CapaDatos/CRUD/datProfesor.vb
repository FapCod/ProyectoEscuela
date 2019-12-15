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
                Command.CommandType = CommandType.StoredProcedure
                'Dim reader = Command.ExecuteReader()
                Try
                    If Command.ExecuteNonQuery Then
                        Return True
                    Else
                        Return False
                    End If
                Catch ex As Exception
                    MsgBox("Profesor ya creado")
                End Try
                
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
    Public Function editarProfesor(objProfesor As entProfesor) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "editarProfesor"
                Command.Parameters.AddWithValue("@dni", objProfesor._dniProfesor)
                Command.Parameters.AddWithValue("@nombre", objProfesor._nombreProfesor)
                Command.Parameters.AddWithValue("@apellido", objProfesor._apellidoProfesor)
                Command.Parameters.AddWithValue("@correo", objProfesor._correoProfesor)
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
                Command.Parameters.AddWithValue("@dniProfesor", dni)
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

    Public Function obtenerTabla() As DataTable
        Dim cnn As SqlConnection
        Dim cadena As String
        cnn = ObtenerConexion()
        cadena = "obtenerTablaProfesor"
        cnn.Open()
        Dim cmd As New SqlCommand(cadena, cnn)
        Dim dt2 As New DataTable
        dt2.Load(cmd.ExecuteReader())
        Return dt2
    End Function
    Public Function ProfesoresLibres() As DataTable
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "listarProfesor"
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

    Public Function ObtenerReporteProfesor() As DataTable
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "Select dniProfesor,nombreProfesor,apellidoProfesor from profesor"
                Command.CommandType = CommandType.Text
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
    Public Function obtenerTablaListar(anno As Integer, nivel As String, grado As Integer, seccion As Integer) As DataTable
        Using conexion = ObtenerConexion()
            conexion.Open()
            Dim dt As DataTable
            Dim da As SqlDataAdapter
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandType = CommandType.StoredProcedure
                Command.CommandText = "listarProfesorPorGradoSeccion"
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
