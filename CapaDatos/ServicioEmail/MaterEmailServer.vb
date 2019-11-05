Imports System.Net
Imports System.Net.Mail
Public MustInherit Class MasterEmailServer
    '//Atributos'
    Private smtpClient As SmtpClient
    Protected senderMail As String
    Protected password As String
    Protected host As String
    Protected port As Integer
    Protected ssl As Boolean
    Protected Sub initializeSmptClient()
        smtpClient = New SmtpClient
        smtpClient.Credentials = New NetworkCredential(senderMail, password)
        smtpClient.Host = host
        smtpClient.Port = port
        smtpClient.EnableSsl = ssl
    End Sub
    '//Método para enviar los mensajes de correo electrónico a uno o varios destinatarios'
    Public Sub sendMail(ByVal subject As String, ByVal body As String, ByVal receiverMail As List(Of String))
        Dim mailMessage As MailMessage = New MailMessage
        Try
            mailMessage.From = New MailAddress(senderMail)
            For Each mail As String In receiverMail
                mailMessage.To.Add(mail)
            Next
            mailMessage.Subject = subject
            mailMessage.Body = body
            mailMessage.Priority = MailPriority.Normal
            smtpClient.Send(mailMessage)
        Catch ex As Exception
        Finally
            mailMessage.Dispose()
            smtpClient.Dispose()
        End Try
    End Sub
End Class