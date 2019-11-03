Public Class entSeccion
    Private _GradoAula As String
    Private _Seccion As String
    Private _NAula As Integer
    Private _Nivel As String
    Public objProfesor As entProfesor

    Public Property GradoAula As String
        Get
            Return _GradoAula
        End Get
        Set(value As String)
            _GradoAula = value
        End Set
    End Property
    Public Property Seccion As String
        Get
            Return _Seccion
        End Get
        Set(value As String)
            _Seccion = value
        End Set
    End Property
    Public Property NAula As Integer
        Get
            Return _NAula
        End Get
        Set(value As Integer)
            _NAula = value
        End Set
    End Property
    Public Property Nivel As String
        Get
            Return _Nivel
        End Get
        Set(value As String)
            _Nivel = value
        End Set
    End Property
    Public Sub New()
        objProfesor = New entProfesor
    End Sub
End Class
