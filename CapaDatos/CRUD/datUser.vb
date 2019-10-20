Imports CapaDatos
Imports System.Data.SqlClient

Public Class datUser
    Public Function Login(user As String, pass As String) As Boolean
        Try
            Dim objdao As New datConexion
            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Select * from users Where userName=@user and passUser= @pass"
            cmd.Parameters.AddWithValue("@user", user)
            cmd.Parameters.AddWithValue("@pass", pass)
            objdao.Conectar("", "", True)
            cmd.Connection = objdao.cnn
            cmd.Connection.Open()
            'vean el problema 
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox("error ex" + ex.Message)
        End Try

        Return False
    End Function
    ''Funcion si existe usuario
    'Public Function existsUser(id As Integer, loginName As String, pass As String) As Boolean
    '    Using connection = GetConnection()
    '        connection.Open()
    '        Using command = New SqlCommand()
    '            command.Connection = connection
    '            command.CommandText = "select *from users where userId=@id and userName=@userName and passUser=@pass"
    '            command.Parameters.AddWithValue("@id", id)
    '            command.Parameters.AddWithValue("@userName", userName)
    '            command.Parameters.AddWithValue("@pass", pass)
    '            command.CommandType = CommandType.Text
    '            Dim reader = command.ExecuteReader()
    '            If reader.HasRows Then
    '                Return True
    '            Else
    '                Return False
    '            End If
    '        End Using
    '    End Using
    'End Function
End Class
