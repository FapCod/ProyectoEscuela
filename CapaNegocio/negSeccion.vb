Imports CapaEntidad
Imports CapaDatos
Public Class negSeccion
    Dim objentSeccion As entSeccion
    Dim objdatSeccion As New datSeccion
    Public Function registrarSeccion(objentSeccion) As Boolean
        Return objdatSeccion.registrarSeccion(objentSeccion)
    End Function
    Public Function obtenerTabla() As DataTable
        Return objdatSeccion.obtenerTabla()
    End Function
    Public Function cargarSeccion(grado As Integer) As DataTable
        Return objdatSeccion.cargarSeccion(grado)
    End Function
    Public Function cargarSeccionP(grado As Integer) As DataTable
        Return objdatSeccion.cargarSeccionP(grado)
    End Function
    Public Function VerificarSiExisteSeccionYGradoI(objentSeccion) As Integer
        Return objdatSeccion.VerificarSiExisteSeccionYGradoI(objentSeccion)
    End Function
    Public Function VerificarSiExisteSeccionYGradoP(objentSeccion) As Integer
        Return objdatSeccion.VerificarSiExisteSeccionYGradoP(objentSeccion)
    End Function

End Class
