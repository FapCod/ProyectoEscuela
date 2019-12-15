Public Class entSeccion
    Private codigoSeccion
    Private nombreSeccion
    Public objentGrado As entGrado
    Public objentProfesor As entProfesor
    Public objentNumeroAnno As entAnnoEscolar
    Private numeroVacantes
    Private nivel
    Public Property _codigoSeccion As Integer
        Get
            Return codigoSeccion
        End Get
        Set(value As Integer)
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
    Public Property _numeroVacantes As Integer
        Get
            Return numeroVacantes
        End Get
        Set(value As Integer)
            numeroVacantes = value
        End Set
    End Property
    Public Property _nivel As String
        Get
            Return nivel
        End Get
        Set(value As String)
            nivel = value
        End Set
    End Property
    
    Public Sub New()
        objentGrado = New entGrado
        objentProfesor = New entProfesor
        objentNumeroAnno = New entAnnoEscolar
    End Sub
End Class
