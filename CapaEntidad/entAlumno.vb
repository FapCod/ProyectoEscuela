Public Class entAlumno
    Private dniAlumno
    Private nombreAlumno
    Private apellidoAlumno
    Private edadAlumno
    Private sexoAlumno
    Private direccionAlumno
    Private nombreDeApoderadoAlumno
    Private numeroTelefonoApoderado
    Private eliminacionLogica
    Public Property _dniAlumno As String
        Get
            Return dniAlumno
        End Get
        Set(value As String)
            dniAlumno = value
        End Set
    End Property

    Public Property _nombreAlumno As String
        Get
            Return nombreAlumno
        End Get
        Set(value As String)
            nombreAlumno = value
        End Set
    End Property

    Public Property _apellidoAlumno As String
        Get
            Return apellidoAlumno
        End Get
        Set(value As String)
            apellidoAlumno = value
        End Set
    End Property

    Public Property _edadAlumno As String
        Get
            Return edadAlumno
        End Get
        Set(value As String)
            edadAlumno = value
        End Set
    End Property

    Public Property _sexoAlumno As String
        Get
            Return sexoAlumno
        End Get
        Set(value As String)
            sexoAlumno = value
        End Set
    End Property

    Public Property _direccionAlumno As String
        Get
            Return direccionAlumno
        End Get
        Set(value As String)
            direccionAlumno = value
        End Set
    End Property

    Public Property _nombreDeApoderadoAlumno As String
        Get
            Return nombreDeApoderadoAlumno
        End Get
        Set(value As String)
            nombreDeApoderadoAlumno = value
        End Set
    End Property

    Public Property _numeroTelefonoApoderado As String
        Get
            Return numeroTelefonoApoderado
        End Get
        Set(value As String)
            numeroTelefonoApoderado = value
        End Set
    End Property
    Public Property _eliminacionLogica As Boolean
        Get
            Return eliminacionLogica
        End Get
        Set(value As Boolean)
            eliminacionLogica = value
        End Set
    End Property
End Class
