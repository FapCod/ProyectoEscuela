Imports CapaDatos
Imports CapaEntidad
Public Class negNota
    Dim objentNota As New entNota
    Dim objdatNota As New datNota
    Public Function registrarNota(objentNota) As Boolean
        Return objdatNota.registrarNota(objentNota)
    End Function
    Public Function obtenerTabla(objentNota) As DataTable
        Return objdatNota.obtenerTabla(objentNota)
    End Function
End Class
