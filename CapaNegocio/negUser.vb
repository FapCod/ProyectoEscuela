Imports CapaDatos
Imports CapaEntidad
Public Class negUser
    Dim objUser As New datUser
    Public Function Login(user As String, pass As String) As Boolean
        Return objUser.Login(user, pass)
    End Function

    Public Function ValidarUser(id As Integer) As Boolean
        If usuarioActivo.UserID >= 1 Then
            If objUser.UsuarioExiste(usuarioActivo.UserID) = True Then
                Return True
            Else
                Return False

            End If
        Else
            Return False
        End If
    End Function

    
End Class

