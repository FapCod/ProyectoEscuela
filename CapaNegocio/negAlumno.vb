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

    Public Function buscarAlumno(dni As String) As DataTable
        Return objdatAlumno.buscarAlumno(dni)
    End Function

    'creacion de datatable
    Public Function obtenerTabla() As DataTable
        Dim dat As New datAlumno
        Return dat.obtenerTabla()
    End Function
End Class
