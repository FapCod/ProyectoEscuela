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
    Public Function VerificarSiExisteMatricula(dni As String) As Integer
        Return objdatMatricula.VerificarSiExisteMatricula(dni)
    End Function
    Public Function VerificarSiHayVacante(codigoGrado As Integer) As Integer
        Return objdatMatricula.VerificarSiHayVacante(codigoGrado)
    End Function
    Public Function obtenerTabla() As DataTable
        Return objdatMatricula.obtenerTabla()
    End Function

    Public Function VerificarSiEsDeInicialoPrimaria(dni As String, nivel As String) As DataTable
        Return objdatMatricula.VerificarSiEsDeInicialoPrimaria(dni, nivel)
    End Function
    Public Function VerificarSiEsDeInicialoPrimariaInteger(dni As String, nivel As String) As Integer
        Return objdatMatricula.VerificarSiEsDeInicialoPrimariaInteger(dni, nivel)
    End Function
    Public Function decrementarVacante(objentMatricula) As Boolean
        Return objdatMatricula.decrementarVacante(objentMatricula)
    End Function
    Public Function decrementarVacante(codigoGrado As Integer, codigoSeccion As Integer) As Boolean
        Return objdatMatricula.decrementarVacante(codigoGrado, codigoSeccion)
    End Function
    Public Function aumentarVacante(codigoGrado As Integer, codigoSeccion As Integer) As Boolean
        Return objdatMatricula.aumentarVacante(codigoGrado, codigoSeccion)
    End Function


    Public Function buscarAlumnoLike(dni As String) As DataTable
        Return objdatMatricula.buscarAlumnoLike(dni)
    End Function
    Public Function buscarMatricula(dni As String) As DataTable
        Return objdatMatricula.buscarMatricula(dni)
    End Function

End Class
