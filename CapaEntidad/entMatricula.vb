Public Class entMatricula
    Private idMatricula
    Private fechaMatricula
    Private gradoAlumno
    Public objentAula As New entAula
    Public objentAlumno As New entAlumno
    Public objentAnnoEscolar As New entAnnoEscolar
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

    Public Property _gradoAlumno As Date
        Get
            Return gradoAlumno
        End Get
        Set(value As Date)
            gradoAlumno = value
        End Set
    End Property
    Public Sub New()
        objentAula = New entAula
        objentAlumno = New entAlumno
        objentAnnoEscolar = New entAnnoEscolar
    End Sub
End Class
