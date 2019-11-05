Public Class entAnnoEscolar
    Private numeroAnno
    Private fechaInicio
    Private fechaTermino

    Public Property _numeroAnno As Integer
        Get
            Return numeroAnno
        End Get
        Set(value As Integer)
            numeroAnno = value
        End Set
    End Property

    Public Property _fechaInicio As Date
        Get
            Return fechaInicio
        End Get
        Set(value As Date)
            fechaInicio = value
        End Set
    End Property

    Public Property _fechaTermino As Date
        Get
            Return fechaTermino
        End Get
        Set(value As Date)
            fechaTermino = value
        End Set
    End Property
End Class
