Imports CapaDatos
Imports CapaEntidad
Public Class negSeccion
    Dim objentSeccion As New entSeccion
    Dim objdatSeccion As New datSeccion
    Public Function registrarSeccion(objentSeccion) As Boolean
        Return objdatSeccion.registrarSeccion(objentSeccion)
    End Function

End Class
