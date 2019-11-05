Imports CapaDatos
Imports CapaEntidad
Imports System.Data.SqlClient

Public Class datUser
    Inherits datConexion
    Public Function Login(nombreUsuario As String, contraseUsuario As String) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "select * from user where userName=@nombreUsuario and passUser = @contraseUsuario"
                Command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario)
                Command.Parameters.AddWithValue("@contraseUsuario", contraseUsuario)
                Command.CommandType = CommandType.Text
                Dim reader = Command.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read() 'Obtenemos los datos de la columna y asignamos a los campos de usuario activo en cache'
                        usuarioActivo.UserID = reader.GetInt32(0)
                        usuarioActivo.firstName = reader.GetString(3)
                        usuarioActivo.Cargo = reader.GetString(4)
                    End While
                    reader.Dispose()

                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
        Return False
    End Function

    Public Function usuarioExiste(idUsuario As Integer) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "select * from users where UserID = @idUsuario "
                Command.Parameters.AddWithValue("@idUsuario ", idUsuario)
                Command.CommandType = CommandType.Text
                Dim reader = Command.ExecuteReader()
                If reader.HasRows Then
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
        Return False
    End Function
    Public Function crearUsuario(user As String, pass As String) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "create login " + user + " with password = '" + pass + "'"
                Command.CommandType = CommandType.Text
                If Command.ExecuteNonQuery Then
                    crearUsuario1(user)
                    crearUsuario2(user)
                    crearUsuario3(user)
                    Return True

                Else
                    Return False
                End If
            End Using
        End Using
        Return False
    End Function
    Public Function crearUsuario1(user As String) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "create user " + user + " for login " + user
                Command.CommandType = CommandType.Text
                If Command.ExecuteNonQuery Then
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
        Return False
    End Function
    Public Function crearUsuario2(user As String) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = " grant select, update, delete, insert on Alumno To " + user + " with grant option "
                Command.CommandType = CommandType.Text
                If Command.ExecuteNonQuery Then
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
        Return False
    End Function
    Public Function crearUsuario3(user As String) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "grant select, update, delete, insert on Profesor To " + user + " with grant option"
                Command.CommandType = CommandType.Text
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
