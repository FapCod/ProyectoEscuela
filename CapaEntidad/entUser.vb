Public Class entUser
    Private nombreUsuario
    Private contraseUsuario
    Private nombresUsuario
    Private apellidosUsuario
    Private cargoUsuario
    Public Property _nombreUsuario As String
        Get
            Return nombreUsuario
        End Get
        Set(value As String)
            nombreUsuario = value
        End Set
    End Property
    Public Property _contraseUsuario As String
        Get
            Return contraseUsuario
        End Get
        Set(value As String)
            contraseUsuario = value
        End Set
    End Property

    Public Property _nombresUsuario As String
        Get
            Return nombresUsuario
        End Get
        Set(value As String)
            nombresUsuario = value
        End Set
    End Property

    Public Property _apellidosUsuario As String
        Get
            Return apellidosUsuario
        End Get
        Set(value As String)
            apellidosUsuario = value
        End Set
    End Property

    Public Property _cargoUsuario As String
        Get
            Return cargoUsuario
        End Get
        Set(value As String)
            cargoUsuario = value
        End Set
    End Property
    
End Class
