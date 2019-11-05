Imports CapaDatos
Imports CapaEntidad
Public Class negMatricula
    Dim objentMatricula As New entMatricula
    Dim objdatMatricula As New datMatricula
    Public Function registrarMatricula(objentMatricula) As Boolean
        Return objdatMatricula.registrarMatricula(objentMatricula)
    End Function
    Public Function obtenerVacantesLibres(objAula As entAula) As Integer
        Return objdatMatricula.obtenerVacantesLibres(objAula)
    End Function
End Class
