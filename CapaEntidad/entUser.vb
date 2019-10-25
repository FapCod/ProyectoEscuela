Public Class entUser
    Private _userName
    Private _passUser
    'Private _FirstName
    Public Property username As String
        Get
            Return _userName
        End Get
        Set(value As String)
            _userName = value
        End Set
    End Property
    Public Property passUser As String
        Get
            Return _passUser
        End Get
        Set(value As String)
            _passUser = value
        End Set
    End Property
    'Public Property firtsName As String
    '    Get
    '        Return _FirstName
    '    End Get
    '    Set(value As String)
    '        _FirstName = value
    '    End Set
    'End Property
End Class
