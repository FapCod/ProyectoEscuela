Imports CapaDatos
Imports CapaEntidad
Public Class negProfesor
    Dim objprof As New entProfesor
    Dim objRProf As New datProfesor
    Public Function Registrar_prof(objprofe) As Boolean
        Return objRProf.RegistrarProfesor(objprofe)
    End Function
    Public Function Actualizar_Profesor(objprof As entProfesor, id As Integer) As Boolean
        Return objRProf.ActualizarProfesor(objprof, id)
    End Function
    Public Function Eliminar_Profesor(id As Integer) As Boolean
        Return objRProf.EliminarProfesor(id)
    End Function
    Public Function Buscar_Profesor(id As Integer) As DataTable
        Return objRProf.BuscarProfesor(id)
    End Function
    Public Function obtenerTabla(cadena As String) As DataTable
        Dim dat As New datProfesor
        Return dat.obtenerTabla(cadena)
    End Function
End Class
