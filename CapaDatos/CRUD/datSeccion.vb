Imports System.Data.SqlClient
Imports CapaEntidad
Public Class datSeccion
    Inherits datConexion
    Public Function registrarSeccion(objSeccion As entSeccion) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "registrarSeccion"
                Command.Parameters.AddWithValue("@codigoSeccion", objSeccion._codigoSeccion)
                Command.Parameters.AddWithValue("@nombreSeccion", objSeccion._nombreSeccion)
                Command.Parameters.AddWithValue("@codigoGrado", objSeccion._codigoGrado)
                Command.Parameters.AddWithValue("@dniProfesor", objSeccion._dniProfesor)
                Command.Parameters.AddWithValue("@numeroAno", objSeccion._numeroAno)
                Command.Parameters.AddWithValue("@numeroVacantes", objSeccion._numeroVacantes)

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
