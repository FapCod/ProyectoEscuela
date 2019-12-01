Public Class entSeccion
    Private codigoSeccion
    Private nombreSeccion
    Private codigoGrado
    Private dniProfesor
    Private numeroAno
    Private numeroVacantes

    Public Property _codigoSeccion As String
        Get
            Return codigoSeccion
        End Get
        Set(value As String)
            codigoSeccion = value
        End Set
    End Property

    Public Property _nombreSeccion As String
        Get
            Return nombreSeccion
        End Get
        Set(value As String)
            nombreSeccion = value
        End Set
    End Property

    Public Property _codigoGrado As String
        Get
            Return codigoGrado
        End Get
        Set(value As String)
            codigoGrado = value
        End Set
    End Property

    Public Property _dniProfesor As String
        Get
            Return dniProfesor
        End Get
        Set(value As String)
            dniProfesor = value
        End Set
    End Property

    Public Property _numeroAno As Integer
        Get
            Return numeroAno
        End Get
        Set(value As Integer)
            numeroAno = value
        End Set
    End Property

    Public Property _numeroVacantes As Integer
        Get
            Return numeroVacantes
        End Get
        Set(value As Integer)
            numeroVacantes = value
        End Set
    End Property
End Class
