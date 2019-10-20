Imports System.Data.SqlClient
Public Class datConexion
    Public cnn As New SqlConnection

    Public Function ConectarSinUsuario() As Boolean
        Dim cadena As String
        cadena = "Data Source=FAPCOD\SQLEXPRESS;Initial Catalog=Colegio_DB"
        Try
            cnn = New SqlConnection(cadena)
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try
    End Function
End Class