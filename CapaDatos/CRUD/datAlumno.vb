Imports CapaDatos
Imports CapaEntidad
Imports System.Data.SqlClient
Public Class datAlumno
    Inherits datConexion
    Public Function RegistrarAlumno(objeA As entAlumno) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = ""
                Command.Parameters.AddWithValue("@nombre", objeA._NombreA)
                Command.Parameters.AddWithValue("@apellido", objeA._ApellidosA)
                Command.Parameters.AddWithValue("@sexo", objeA._SexoA)
                Command.Parameters.AddWithValue("@nivel", objeA._NivelA)
                Command.Parameters.AddWithValue("@grado", objeA._GradoA)
                Command.Parameters.AddWithValue("@seccion", objeA._SeccionA)
                Command.Parameters.AddWithValue("@direccion", objeA._DireccionA)
                Command.Parameters.AddWithValue("@nombreAp", objeA._NombreApo)
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
