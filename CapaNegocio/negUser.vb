Imports CapaDatos
Public Class negUser
    Dim objUser As New datUser
    Public Function Login(user As String, pass As String) As Boolean
        Return objUser.Login(user, pass)
    End Function
End Class
