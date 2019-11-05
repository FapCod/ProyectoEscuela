Imports System.Data.SqlClient
Imports CapaDatos
Public Class negCurso
    Dim objdatCurso As New datCurso
    Public Function listarCurso() As DataTable
        Return objdatCurso.listarCurso()
    End Function
End Class
