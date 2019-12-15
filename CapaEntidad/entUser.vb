Public Class entUser
    Private username
    Private contrasenaUsuario
    Private dniUsuario
    Private nombreUsuario
    Private apellidoUsuario
    Private correoUsuario
    Private cargoUsuario
    Public Property _username As String
        Get
            Return username
        End Get
        Set(value As String)
            username = value
        End Set
    End Property
    Public Property _contrasenaUsuario As String
        Get
            Return contrasenaUsuario
        End Get
        Set(value As String)
            contrasenaUsuario = value
        End Set
    End Property

    Public Property _dniUsuario As String
        Get
            Return dniUsuario
        End Get
        Set(value As String)
            dniUsuario = value
        End Set
    End Property

    Public Property _nombreUsuario As String
        Get
            Return nombreUsuario
        End Get
        Set(value As String)
            nombreUsuario = value
        End Set
    End Property

    Public Property _apellidoUsuario As String
        Get
            Return apellidoUsuario
        End Get
        Set(value As String)
            apellidoUsuario = value
        End Set
    End Property
    Public Property _correoUsuario As String
        Get
            Return correoUsuario
        End Get
        Set(value As String)
            correoUsuario = value
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
