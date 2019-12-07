Imports System.Data.SqlClient
Imports CapaEntidad
Public Class datNota
    Inherits datConexion
    Public Function obtenerTabla(objNota As entNota) As DataTable
        Using conexion = ObtenerConexion()
            conexion.Open()
            Dim dt As DataTable
            Dim da As SqlDataAdapter
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandType = CommandType.StoredProcedure
                Command.CommandText = "listarNotaAlumnoPorCursoTrimestre"
                Command.Parameters.AddWithValue("@dniAlumno", objNota.objentAlumno._dniAlumno)
                Command.Parameters.AddWithValue("@codigoTrimestre", objNota.objentTrimestre._codigoTrimestre)
                Command.Parameters.AddWithValue("@codigoCurso", objNota.objentCurso._codigoCurso)
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
    'Funcion Registrar nota
    Public Function registrarNota(objNota As entnota) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "agregarnota"
                Command.Parameters.AddWithValue("@nota", objNota._nota)
                Command.Parameters.AddWithValue("@descripcion", objNota._descripcion)
                Command.Parameters.AddWithValue("@codigoCurso", objNota.objentCurso._codigoCurso)
                Command.Parameters.AddWithValue("@dniAlumno", objNota.objentAlumno._dniAlumno)
                Command.Parameters.AddWithValue("@codigoTrimestre", objNota.objentTrimestre._codigoTrimestre)
                Command.Parameters.AddWithValue("@numeroAnno", objNota.objentAnnoEscolar._numeroAnno)
                Command.Parameters.AddWithValue("@eliminacionLogica", objNota._eliminacionLogica)
                Command.CommandType = CommandType.StoredProcedure
                Try
                    If Command.ExecuteNonQuery Then
                        Return True
                    Else
                        Return False
                    End If
                Catch ex As Exception
                    MsgBox("Alumno no existe", MsgBoxStyle.Critical)
                End Try
                
            End Using
        End Using
        Return False
    End Function
    Public Function editarNota(objNota As entNota, idNota As Integer) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "editarnota"
                Command.Parameters.AddWithValue("@codigoNota", idNota)
                Command.Parameters.AddWithValue("@nota", objNota._nota)
                Command.Parameters.AddWithValue("@descripcion", objNota._descripcion)
                Command.Parameters.AddWithValue("@codigoCurso", objNota.objentCurso._codigoCurso)
                Command.Parameters.AddWithValue("@dniAlumno", objNota.objentAlumno._dniAlumno)
                Command.Parameters.AddWithValue("@codigoTrimestre", objNota.objentTrimestre._codigoTrimestre)
                Command.Parameters.AddWithValue("@numeroAnno", objNota.objentAnnoEscolar._numeroAnno)
                Command.Parameters.AddWithValue("@eliminacionLogica", objNota._eliminacionLogica)
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
End Class
