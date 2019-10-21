Imports CapaDatos
Imports CapaEntidad
Imports System.Data.SqlClient
Public Class datProfesor
    Inherits datConexion
    Public Function RegistrarProfesor(objeP As entProfesor) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "exec InsertarProf"
                Command.Parameters.AddWithValue("@nombre", objeP._nombreP)
                Command.Parameters.AddWithValue("@apellido", objeP._apellidoP)
                Command.Parameters.AddWithValue("@correo", objeP._correoP)
                Command.Parameters.AddWithValue("@sexo", objeP._sexoP)
                Command.Parameters.AddWithValue("@telefono", objeP._telefonoP)
                Command.Parameters.AddWithValue("@direccion", objeP._direccionP)
                Command.Parameters.AddWithValue("@asignatura", objeP._asignaturasP)
                Command.Parameters.AddWithValue("@grado", objeP._gradoYseccionP)
                Command.Parameters.AddWithValue("@tipo", objeP._tipoP)
                Command.CommandType = CommandType.StoredProcedure
                Dim reader = Command.ExecuteReader()
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
