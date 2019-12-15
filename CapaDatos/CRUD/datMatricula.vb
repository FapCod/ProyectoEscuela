Imports System.Data.SqlClient
Imports CapaEntidad
Public Class datMatricula
    Inherits datConexion
    Public Function registrarMatricula(objMatricula As entMatricula) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "registrarMatricula"
                Command.Parameters.AddWithValue("@fechaMatricula", objMatricula._fechaMatricula)
                Command.Parameters.AddWithValue("@codigoGrado", objMatricula.objentgrado._codigoGrado)
                Command.Parameters.AddWithValue("@dniAlumno", objMatricula.objentAlumno._dniAlumno)
                Command.Parameters.AddWithValue("@numeroAnno", objMatricula.objentAnnoEscolar._numeroAnno)
                Command.Parameters.AddWithValue("@codigoSeccion", objMatricula.objentSeccion._codigoSeccion)
                Command.Parameters.AddWithValue("@nivelAlumno", objMatricula._nivelAlumno)
                Command.Parameters.AddWithValue("@eliminacionLogica", objMatricula._eliminacionLogica)
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
    Public Function editarMatricula(objMatricula As entMatricula, idMatricula As Integer) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "actualizarMatricula"
                Command.Parameters.AddWithValue("@idMatricula", idMatricula)
                Command.Parameters.AddWithValue("@fechaMatricula", objMatricula._fechaMatricula)
                Command.Parameters.AddWithValue("@codigoGrado", objMatricula.objentgrado._codigoGrado)
                Command.Parameters.AddWithValue("@dniAlumno", objMatricula.objentAlumno._dniAlumno)
                Command.Parameters.AddWithValue("@numeroAnno", objMatricula.objentAnnoEscolar._numeroAnno)
                Command.Parameters.AddWithValue("@codigoSeccion", objMatricula.objentSeccion._codigoSeccion)
                Command.Parameters.AddWithValue("@nivelAlumno", objMatricula._nivelAlumno)
                Command.Parameters.AddWithValue("@eliminacionLogica", objMatricula._eliminacionLogica)
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
    Public Function eliminarMatricula(idMatricula As Integer) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "eliminarMatricula"
                Command.Parameters.AddWithValue("@idMatricula", idMatricula)
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
    
    Public Function VerificarSiExisteAlumno(dni As String) As Integer
        Using conexion = ObtenerConexion()
            conexion.Open()
            Dim dt As DataTable
            Dim da As SqlDataAdapter
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandType = CommandType.StoredProcedure
                Command.CommandText = "VerificarSiExisteAlumno"
                Command.Parameters.AddWithValue("@dni", dni)
                If Command.ExecuteNonQuery Then
                    dt = New DataTable
                    da = New SqlDataAdapter(Command)
                    da.Fill(dt)
                    If dt.Rows.Count = 0 Then
                        Return 0
                    Else
                        Return 1
                    End If
                Else
                    Return Nothing
                End If
            End Using
        End Using
    End Function

    Public Function VerificarSiExisteMatricula(dni As String) As Integer
        Using conexion = ObtenerConexion()
            conexion.Open()
            Dim dt As DataTable
            Dim da As SqlDataAdapter
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandType = CommandType.StoredProcedure
                Command.CommandText = "VerificarSiExisteMatricula"
                Command.Parameters.AddWithValue("@dni", dni)
                If Command.ExecuteNonQuery Then
                    dt = New DataTable
                    da = New SqlDataAdapter(Command)
                    da.Fill(dt)
                    If dt.Rows.Count = 0 Then
                        Return 0
                    Else
                        Return 1
                    End If
                Else
                    Return Nothing
                End If
            End Using
        End Using
    End Function
    Public Function VerificarSiHayVacante(codigoGrado As Integer) As Integer
        Using conexion = ObtenerConexion()
            conexion.Open()
            Dim dt As DataTable
            Dim da As SqlDataAdapter
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandType = CommandType.StoredProcedure
                Command.CommandText = "VerificarSiHayVacante"
                Command.Parameters.AddWithValue("@codigoGrado", codigoGrado)
                If Command.ExecuteNonQuery Then
                    dt = New DataTable
                    da = New SqlDataAdapter(Command)
                    da.Fill(dt)
                    If dt.Rows.Count = 0 Then
                        Return 0
                    Else
                        Return 1
                    End If
                Else
                    Return Nothing
                End If
            End Using
        End Using
    End Function

    Public Function decrementarVacante(objMatricula As entMatricula) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "decrementarVacante"
                Command.Parameters.AddWithValue("@codigoGrado", objMatricula.objentgrado._codigoGrado)
                Command.Parameters.AddWithValue("@codigoSeccion", objMatricula.objentSeccion._codigoSeccion)
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

    Public Function decrementarVacante(codigoGrado As Integer, codigoSeccion As Integer) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "decrementarVacante"
                Command.Parameters.AddWithValue("@codigoGrado", codigoGrado)
                Command.Parameters.AddWithValue("@codigoSeccion", codigoSeccion)
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

    Public Function aumentarVacante(codigoGrado As Integer, codigoSeccion As Integer) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "aumentarVacante"
                Command.Parameters.AddWithValue("@codigoGrado", codigoGrado)
                Command.Parameters.AddWithValue("@codigoSeccion", codigoSeccion)
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
        Using conexion = ObtenerConexion()
            conexion.Open()
            Dim dt As DataTable
            Dim da As SqlDataAdapter
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandType = CommandType.Text
                Command.CommandText = "obtenerTablaMatricula"
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
    Public Function VerificarSiEsDeInicialoPrimaria(apellido As String, nivel As String) As DataTable
        Using conexion = ObtenerConexion()
            conexion.Open()
            Dim dt As DataTable
            Dim da As SqlDataAdapter
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandType = CommandType.StoredProcedure
                Command.CommandText = "VerificarSiEsDeInicialoPrimaria"
                Command.Parameters.AddWithValue("@apellido", apellido)
                Command.Parameters.AddWithValue("@nivel", nivel)
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

    Public Function VerificarSiEsDeInicialoPrimariaInteger(apellido As String, nivel As String) As Integer
        Using conexion = ObtenerConexion()
            conexion.Open()
            Dim dt As DataTable
            Dim da As SqlDataAdapter
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandType = CommandType.StoredProcedure
                Command.CommandText = "VerificarSiEsDeInicialoPrimaria"
                Command.Parameters.AddWithValue("@apellido", apellido)
                Command.Parameters.AddWithValue("@nivel", nivel)
                If Command.ExecuteNonQuery Then
                    dt = New DataTable
                    da = New SqlDataAdapter(Command)
                    da.Fill(dt)
                    If dt.Rows.Count = 0 Then
                        Return 0
                    Else
                        Return 1
                    End If
                Else
                    Return Nothing
                End If
            End Using
        End Using
    End Function



    Public Function buscarAlumnoLike(dni As String) As DataTable
        Using conexion = ObtenerConexion()
            conexion.Open()
            Dim dt As DataTable
            Dim da As SqlDataAdapter
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandType = CommandType.StoredProcedure
                Command.CommandText = "buscarAlumnoLike"
                Command.Parameters.AddWithValue("@dni", dni)
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
    Public Function buscarMatricula(dni As String) As DataTable
        Using conexion = ObtenerConexion()
            conexion.Open()
            Dim dt As DataTable
            Dim da As SqlDataAdapter
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandType = CommandType.StoredProcedure
                Command.CommandText = "buscarMatricula"
                Command.Parameters.AddWithValue("@dni", dni)
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
