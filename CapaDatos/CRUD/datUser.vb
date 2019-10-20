Public Class datUser
    ''Se crea funcion para el ingreso del ususario con retorno booleano
    'Public Function Login(user As String, pass As String) As Boolean
    '    'se usa using porque al terminar el proceso automaticamente sera liberada la memoria dependiendo de lo que haya estado ejecutandose.
    '    Using connection = GetConnection()
    '        connection.Open()
    '        Using Comman = New SqlCommand()
    '            Comman.Connection = connection
    '            Comman.CommandText = "Select * from users Where userName=@user and passUser= @pass"
    '            Comman.Parameters.AddWithValue("@user", user)
    '            Comman.Parameters.AddWithValue("@pass", pass)
    '            Comman.CommandType = CommandType.Text
    '            Dim reader = Comman.ExecuteReader()
    '            'si la variable reader tiene filas entonces retornara true 
    '            If reader.HasRows Then
    '                Return True
    '            Else
    '                Return False
    '            End If
    '        End Using
    '    End Using
    'End Function
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
