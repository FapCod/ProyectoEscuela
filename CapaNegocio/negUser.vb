Imports CapaDatos
Imports CapaEntidad
Public Class negUser
    Dim objUser As New datUser
    Dim objUserr As New entUser
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
    Public Function crearUsuario(user As String, pass As String) As Boolean
        Return objUser.crearUsuario(user, pass)
    End Function



End Class

