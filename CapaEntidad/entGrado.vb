Public Class entGrado
    Private codigoGrado
    Private numeroGrado
    Private nivelGrado
    Public Property _codigoGrado As Integer
        Get
            Return codigoGrado
        End Get
        Set(value As Integer)
            codigoGrado = value
        End Set
    End Property
    Public Property _numeroGrado As Integer
        Get
            Return numeroGrado
        End Get
        Set(value As Integer)
            numeroGrado = value
        End Set
    End Property
    Public Property _nivelGrado As String
        Get
            Return nivelGrado
        End Get
        Set(value As String)
            nivelGrado = value
        End Set
    End Property
End Class
