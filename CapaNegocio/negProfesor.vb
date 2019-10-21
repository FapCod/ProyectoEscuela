Imports CapaDatos
Imports CapaEntidad
Public Class negProfesor
    Dim objprof As New entProfesor
    Dim objRProf As New datProfesor
    Public Function Registrar_prof(objprofe) As Boolean
        Return objRProf.RegistrarProfesor(objprofe)
    End Function
End Class
