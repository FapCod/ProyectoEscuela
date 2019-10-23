Imports CapaDatos
Imports CapaEntidad
Public Class negAlumno
    Dim objalum As New entAlumno
    Dim objRAlumn As New datAlumno
    Public Function Registrar_Alumno(objalum) As Boolean
        Return objRAlumn.RegistrarAlumno(objalum)
    End Function
    Public Function Editar_Alumno(objalum As entAlumno, id As Integer) As Boolean
        Return objRAlumn.editarAlumno(objalum, id)
    End Function
    Public Function Eliminar_Alumno(id As Integer) As Boolean
        Return objRAlumn.eliminarAlumno(id)
    End Function
    Public Function Buscar_Alumno(id As Integer) As DataTable
        Return objRAlumn.buscarAlumno(id)
    End Function

    'creacion de datatable
    Public Function obtenerTabla(cadena As String) As DataTable
        Dim dat As New datAlumno
        Return dat.obtenerTabla(cadena)
    End Function
End Class
