Imports System.Data.SqlClient
Imports CapaEntidad
Public Class datMatricula
    Inherits datConexion
    Public Function registrarMatricula(objMatricula As entMatricula) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = ""
                Command.Parameters.AddWithValue("@fechaMatricula", objMatricula._fechaMatricula)
                Command.Parameters.AddWithValue("@gradoAlumno", objMatricula._gradoAlumno)
                Command.Parameters.AddWithValue("@codigoAula", objMatricula.objentAula._codigoAula)
                Command.Parameters.AddWithValue("@dniAlumno", objMatricula.objentAlumno._dniAlumno)
                Command.Parameters.AddWithValue("@numeroAnno", objMatricula.objentAnnoEscolar._numeroAnno)
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

    Public Function obtenerVacantesLibres(objAula As entAula) As Integer
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "select * from aula where nombreAula=@nombreAula"
                Command.Parameters.AddWithValue("@nombreAula", objAula._nombreAula)
                Command.CommandType = CommandType.Text
                Dim reader = Command.ExecuteReader()
                If reader.HasRows Then
                    Dim vacantesLibres As Integer
                    While reader.Read() 'Obtenemos los datos de la columna y asignamos a los campos de usuario activo en cache'
                        vacantesLibres = reader.GetInt32(3)
                    End While
                    reader.Dispose()

                    Return vacantesLibres
                Else
                    Return Nothing
                End If
            End Using
        End Using
        Return False
    End Function
End Class
