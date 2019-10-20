Imports CapaEntidad
Imports CapaNegocio
Public Class Login
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim username = txtUser.Text
        Dim passUser = txtPass.Text
        Dim objnegUser As New negUser
        Try
            If objnegUser.Login(username, passUser) Then
                MsgBox("REGISTRO EXITOSO")
            Else
                MsgBox("ERROR", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub

End Class
