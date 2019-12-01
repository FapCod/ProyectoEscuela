Imports System.Data.SqlClient
Imports CapaDatos
Public Class negGrado
    Dim objdatGrado As New datGrado
    Public Function listarGradoInicial() As DataTable
        Return objdatGrado.listarGradoInicial()
    End Function
    Public Function listarGradoPrimaria() As DataTable
        Return objdatGrado.listarGradoPrimaria()
    End Function
End Class
