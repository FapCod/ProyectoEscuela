Imports CapaDatos
Imports CapaEntidad
Public Class negSeccion
    Dim objSecc As New entSeccion
    Dim objSeccion As New datSeccion

    Public Function RegistrarSeccion(objSec) As Boolean
        Return objSeccion.RegistrarSeccion(objSec)
    End Function
    Public Function obtenerTablaSecc(cadena As String) As DataTable
        Dim dat As New datSeccion
        Return dat.obtenerTablaSecc(cadena)
    End Function
    Function ObtenerCombobox(cadena As String) As DataTable
        Dim objdat As New datSeccion
        Return objdat.obtenerCombobox(cadena)
    End Function
End Class
