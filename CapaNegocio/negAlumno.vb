Imports CapaDatos
Imports CapaEntidad
Public Class negAlumno
    Dim objalum As New entAlumno
    Dim objRAlumn As New datAlumno
    Public Function Registrar_Alumno(objalum) As Boolean
        Return objRAlumn.RegistrarAlumno(objalum)
    End Function
End Class
