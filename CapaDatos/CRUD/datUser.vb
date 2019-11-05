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
                Command.CommandText = "select * from usuario where nombreUsuario=@nombreUsuario and contraseUsuario = @contraseUsuario"
                Command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario)
                Command.Parameters.AddWithValue("@contraseUsuario", contraseUsuario)
                Command.CommandType = CommandType.Text
                Dim reader = Command.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read() 'Obtenemos los datos de la columna y asignamos a los campos de usuario activo en cache'
                        usuarioActivo.nombreUsuario = reader.GetString(0)
                        usuarioActivo.nombresUsuario = reader.GetString(2)
                        usuarioActivo.apellidoUsuario = reader.GetString(3)
                        usuarioActivo.correoUsuario = reader.GetString(4)
                        usuarioActivo.cargoUsuario = reader.GetString(5)
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

    Public Function usuarioExiste(nombreUsuario As String) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "select * from usuario where nombreUsuario = @nombreUsuario "
                Command.Parameters.AddWithValue("@nombreUsuario ", nombreUsuario)
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
    
    'funcion para recuperar contraseña
    Public Function recuperarContrasenaUsuario(ByVal CorreoUsuario As String) As String
        Using conexion = ObtenerConexion()
            conexion.Open()

            Using command = New SqlCommand()
                command.Connection = conexion
                command.CommandText = "select *from usuario where nombreUsuario=@nombreUsuario or correoUsuario=@correoUsuario"
                command.Parameters.AddWithValue("@nombreUsuario", CorreoUsuario)
                command.Parameters.AddWithValue("@correoUsuario", CorreoUsuario)
                command.CommandType = CommandType.Text
                Dim reader As SqlDataReader = command.ExecuteReader()
                'los numeros son las columnas de las tablas de las database
                If reader.Read() = True Then
                    Dim userName As String = reader.GetString(2) & ", " + reader.GetString(3)
                    Dim userMail As String = reader.GetString(4)
                    Dim accountPassword As String = reader.GetString(1)

                    Dim systemSupport = New SystemSupportMail()
                    systemSupport.sendMail(
                      subject:="SYSTEM: Recuperacion De Contraseña",
                      body:="Hola " & userName & vbLf & "solicitaste recuperar tu contraseña." & vbLf &
                      "Tu contraseña es: " & accountPassword & vbLf &
                      "Si puedes cambia tu contraseña cuando ingreses al sistema",
                      receiverMail:=New List(Of String) From {userMail}
                      )

                    Return "Hola " & userName & vbLf & "Solicitaste que se recupere tu contraseña." & vbLf &
                      "Por favor revisa tu correo: " & userMail & vbLf &
                      "Si puedes cambia tu contraseña cuando ingreses al sistema"

                Else
                    Return "Disculpa no tienes una cuenta con este email o username."
                End If

            End Using
        End Using
    End Function
End Class
