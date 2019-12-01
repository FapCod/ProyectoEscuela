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
                Command.CommandText = "select * from matricula"
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
