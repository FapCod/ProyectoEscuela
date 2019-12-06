Public Class entMatricula
    Private idMatricula
    Private fechaMatricula
    Public objentgrado As entGrado
    Public objentAlumno As entAlumno
    Public objentSeccion As entSeccion
    Public objentAnnoEscolar As entAnnoEscolar
    Private nivelAlumno
    Private eliminacionLogica
    Public Property _idMatricula As String
        Get
            Return idMatricula
        End Get
        Set(value As String)
            idMatricula = value
        End Set
    End Property

    Public Property _fechaMatricula As Date
        Get
            Return fechaMatricula
        End Get
        Set(value As Date)
            fechaMatricula = value
        End Set
    End Property
    Public Property _nivelAlumno As String
        Get
            Return nivelAlumno
        End Get
        Set(value As String)
            nivelAlumno = value
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
        objentGrado = New entGrado
        objentAlumno = New entAlumno
        objentAnnoEscolar = New entAnnoEscolar
        objentSeccion = New entSeccion
    End Sub
End Class
