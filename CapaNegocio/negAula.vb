Imports CapaDatos
Public Class negAula
    Dim objdatAula As New datAula
    Public Function listarAula() As DataTable
        Return objdatAula.listarAula()
    End Function
End Class
