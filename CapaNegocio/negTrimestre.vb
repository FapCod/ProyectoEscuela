Imports CapaDatos
Public Class negTrimestre
    Dim objdatTrimestre As New dattrimestre
    Public Function listarTrimestre() As DataTable
        Return objdatTrimestre.listarTrimestre()
    End Function
End Class
