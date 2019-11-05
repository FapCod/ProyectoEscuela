Public Class entNota
    Private codigoNota 
    Private nota
    Private descripcion
    Public objentAlumno As New entAlumno
    Public objentCurso As New entCurso
    Public objentTrimestre As New entTrimestre
    Public Property _codigoNota As String
        Get
            Return codigoNota
        End Get
        Set(value As String)
            codigoNota = value
        End Set
    End Property

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

    Public Sub New()
        objentAlumno = New entAlumno
        objentCurso = New entCurso
        objentTrimestre = New entTrimestre
    End Sub
End Class
