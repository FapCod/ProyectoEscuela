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

    Public Function ObtenerTablaListar(dni As String, anno As Integer, nivel As String, grado As Integer, seccion As Integer, curso As String) As DataTable
        Return objdatNota.obtenerTablaListar(dni, anno, nivel, grado, seccion, curso)
    End Function
    Public Function editarNota(objentNota As entNota, idNota As Integer) As Boolean
        Return objdatNota.editarNota(objentNota, idNota)
    End Function
    Public Function validarSiExisteNota(objentNota As entNota) As Integer
        Return objdatNota.validarSiExisteNota(objentNota)
    End Function
End Class
