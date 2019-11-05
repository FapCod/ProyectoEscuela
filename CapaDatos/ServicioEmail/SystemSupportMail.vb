Public Class SystemSupportMail
    Inherits MasterEmailServer
    Public Sub New()
        senderMail = "serviciotecnicoescuela@gmail.com"
        password = "serviciotecnico123"
        host = "smtp.gmail.com"
        port = 587
        ssl = True
        initializeSmptClient()
    End Sub

End Class
