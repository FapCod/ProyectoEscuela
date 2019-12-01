Imports System.Data.SqlClient
Imports CapaDatos
Public Class negCurso
    Dim objdatCurso As New datCurso
    Public Function listarCursoInicial() As DataTable
        Return objdatCurso.listarCursoInicial()
    End Function
    Public Function listarCursoPrimaria() As DataTable
        Return objdatCurso.listarCursoPrimaria()
    End Function
End Class
