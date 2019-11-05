Imports CapaDatos
Imports CapaEntidad
Public Class negAlumno
    Dim objentAlumno As New entAlumno
    Dim objdatAlumno As New datAlumno

    Public Function registrarAlumno(objentAlumno) As Boolean
        Return objdatAlumno.registrarAlumno(objentAlumno)
    End Function

    Public Function editarAlumno(objentAlumno) As Boolean
        Return objdatAlumno.editarAlumno(objentAlumno)
    End Function

    Public Function eliminarAlumno(objentAlumno) As Boolean
        Return objdatAlumno.eliminarAlumno(objentAlumno)
    End Function

    Public Function buscarAlumno(objentAlumno) As DataTable
        Return objdatAlumno.buscarAlumno(objentAlumno)
    End Function

    'creacion de datatable
    Public Function obtenerTabla(cadena As String) As DataTable
        Dim dat As New datAlumno
        Return dat.obtenerTabla(cadena)
    End Function
End Class
