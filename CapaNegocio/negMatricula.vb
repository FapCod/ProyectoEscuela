Imports CapaDatos
Imports CapaEntidad
Public Class negMatricula
    Dim objentMatricula As New entMatricula
    Dim objdatMatricula As New datMatricula
    Public Function registrarMatricula(objentMatricula) As Boolean
        Return objdatMatricula.registrarMatricula(objentMatricula)
    End Function
    Public Function editarMatricula(objentMatricula As entMatricula, idMatricula As Integer) As Boolean
        Return objdatMatricula.editarMatricula(objentMatricula, idMatricula)
    End Function

    Public Function eliminarMatricula(idMatricula As Integer) As Boolean
        Return objdatMatricula.eliminarMatricula(idMatricula)
    End Function
    Public Function VerificarSiExisteAlumno(dni As String) As Integer
        Return objdatMatricula.VerificarSiExisteAlumno(dni)
    End Function
    Public Function obtenerTabla() As DataTable
        Return objdatMatricula.obtenerTabla()
    End Function

    Public Function decrementarVacante(objentMatricula) As Boolean
        Return objdatMatricula.decrementarVacante(objentMatricula)
    End Function
End Class
