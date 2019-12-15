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
                Command.CommandText = "loginUser"
                Command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario)
                Command.Parameters.AddWithValue("@contraseUsuario", contraseUsuario)
                Command.CommandType = CommandType.StoredProcedure
                Dim reader = Command.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read() 'Obtenemos los datos de la columna y asignamos a los campos de usuario activo en cache'
                        usuarioActivo.nombreUsuario = reader.GetString(0)
                        usuarioActivo.nombresUsuario = reader.GetString(3)
                        usuarioActivo.apellidoUsuario = reader.GetString(4)
                        usuarioActivo.correoUsuario = reader.GetString(5)
                        usuarioActivo.cargoUsuario = reader.GetString(6)
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
                Command.CommandText = "VerificarSiExisteUsuario "
                Command.Parameters.AddWithValue("@nombreUsuario ", nombreUsuario)
                Command.CommandType = CommandType.StoredProcedure
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
    Public Function crearUsuario(obj As entUser) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "registrarUsuario"
                Command.Parameters.AddWithValue("@usuario", obj._username)
                Command.Parameters.AddWithValue("@contrasenna", obj._contrasenaUsuario)
                Command.Parameters.AddWithValue("@dniUsuario", obj._dniUsuario)
                Command.Parameters.AddWithValue("@nombreUsuario", obj._nombreUsuario)
                Command.Parameters.AddWithValue("@apellidoUsuario", obj._apellidoUsuario)
                Command.Parameters.AddWithValue("@correoUsuario", obj._correoUsuario)
                Command.Parameters.AddWithValue("@cargoUsuario", obj._cargoUsuario)
                Command.CommandType = CommandType.StoredProcedure
                Try
                    If Command.ExecuteNonQuery Then
                        Return True
                    Else
                        Return False
                    End If
                Catch ex As Exception

                End Try
                
            End Using
        End Using
        Return False
    End Function
    Public Function editarUsuario(obj As entUser) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "actualizarUsuario"
                Command.Parameters.AddWithValue("@contrasenna", obj._contrasenaUsuario)
                Command.Parameters.AddWithValue("@dni", obj._dniUsuario)
                Command.Parameters.AddWithValue("@nombreUsuario", obj._nombreUsuario)
                Command.Parameters.AddWithValue("@apellidoUsuario", obj._apellidoUsuario)
                Command.Parameters.AddWithValue("@correoUsuario", obj._correoUsuario)
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
    Public Function eliminarUsuario(dni As String) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "eliminarUsuario"
                Command.Parameters.AddWithValue("@dni", dni)
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




    Public Function listarProfesores(dni As String) As DataTable
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "listarProfesores"
                Command.Parameters.AddWithValue("@dni", dni)
                Command.CommandType = CommandType.StoredProcedure
                Dim dt1 As New DataTable
                dt1.Load(Command.ExecuteReader())
                If Command.ExecuteNonQuery Then
                    Return dt1
                Else
                    Return Nothing
                End If
            End Using
        End Using
        Return Nothing
    End Function

    Public Function listarDirector(dni As String) As DataTable
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "listarDirector"
                Command.Parameters.AddWithValue("@dni", dni)
                Command.CommandType = CommandType.StoredProcedure
                Dim dt1 As New DataTable
                dt1.Load(Command.ExecuteReader())
                If Command.ExecuteNonQuery Then
                    Return dt1
                Else
                    Return Nothing
                End If
            End Using
        End Using
        Return Nothing
    End Function
End Class
