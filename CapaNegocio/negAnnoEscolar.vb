Imports CapaDatos
Imports CapaEntidad
Public Class negAnnoEscolar
    Dim objdatAnnoEscolar As New datAnnoEscolar
    Dim obj As New entAnnoEscolar

    Public Function registrarAnnoEscolar(obj) As Boolean
        Return objdatAnnoEscolar.registrarAnnoEscolar(obj)
    End Function
    Public Function listarAnnoEscolar() As DataTable
        Return objdatAnnoEscolar.listarAnnoEscolar()
    End Function
End Class
