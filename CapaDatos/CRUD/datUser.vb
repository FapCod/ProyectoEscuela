Imports CapaDatos
Imports CapaEntidad
Imports System.Data.SqlClient

Public Class datUser
    Inherits datConexion
    Public Function Login(user As String, pass As String) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "select * from users where userName= @user and passUser = @pass "
                Command.Parameters.AddWithValue("@user", user)
                Command.Parameters.AddWithValue("@pass", pass)
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

    Public Function UsuarioExiste(id As Integer) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "select * from users where UserID = @user"
                Command.Parameters.AddWithValue("@user", id)
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
