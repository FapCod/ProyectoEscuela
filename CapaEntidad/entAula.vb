Public Class entAula
    Private codigoAula
    Private nombreAula
    Private capacidadAula
    Private vacantesLibresAula


    Public Property _codigoAula As String
        Get
            Return codigoAula
        End Get
        Set(value As String)
            codigoAula = value
        End Set
    End Property

    Public Property _nombreAula As String
        Get
            Return nombreAula
        End Get
        Set(value As String)
            nombreAula = value
        End Set
    End Property

    Public Property _capacidadAula As String
        Get
            Return capacidadAula
        End Get
        Set(value As String)
            capacidadAula = value
        End Set
    End Property

    Public Property _vacantesLibresAula As String
        Get
            Return vacantesLibresAula
        End Get
        Set(value As String)
            vacantesLibresAula = value
        End Set
    End Property
End Class
