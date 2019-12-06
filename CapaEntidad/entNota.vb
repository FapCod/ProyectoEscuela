Public Class entNota
    Private nota
    Private descripcion
    Public objentCurso As New entCurso
    Public objentAlumno As New entAlumno
    Public objentTrimestre As New entTrimestre
    Public objentAnnoEscolar As New entAnnoEscolar
    Private eliminacionLogica
    Public Property _nota As String
        Get
            Return nota
        End Get
        Set(value As String)
            nota = value
        End Set
    End Property

    Public Property _descripcion As String
        Get
            Return descripcion
        End Get
        Set(value As String)
            descripcion = value
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

    Public Sub New()
        objentCurso = New entCurso
        objentAlumno = New entAlumno
        objentTrimestre = New entTrimestre
        objentAnnoEscolar = New entAnnoEscolar
    End Sub
End Class
