Public Class entTrimestre
    Private codigoTrimestre
    Private descripcionTrimestre
    Public Property _codigoTrimestre As String
        Get
            Return codigoTrimestre
        End Get
        Set(value As String)
            codigoTrimestre = value
        End Set
    End Property
    Public Property _descripcionTrimestre As String
        Get
            Return descripcionTrimestre
        End Get
        Set(value As String)
            descripcionTrimestre = value
        End Set
    End Property
End Class
