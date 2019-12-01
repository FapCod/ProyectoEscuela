Public Class entCurso
    Private codigoCurso
    Private nombreCurso
    Public objGrado As entGrado
    Private competencia1
    Private competencia2
    Private competencia3

    Public Property _codigoCurso As String
        Get
            Return codigoCurso
        End Get
        Set(value As String)
            codigoCurso = value
        End Set
    End Property

    Public Property _nombreCurso As String
        Get
            Return nombreCurso
        End Get
        Set(value As String)
            nombreCurso = value
        End Set
    End Property

    Public Property _competencia1 As String
        Get
            Return competencia1
        End Get
        Set(value As String)
            competencia1 = value
        End Set
    End Property

    Public Property _competencia2 As String
        Get
            Return competencia2
        End Get
        Set(value As String)
            competencia2 = value
        End Set
    End Property

    Public Property _competencia3 As String
        Get
            Return competencia3
        End Get
        Set(value As String)
            competencia3 = value
        End Set
    End Property
    Public Sub New()
        objGrado = New entGrado
    End Sub
End Class
