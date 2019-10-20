Imports System.Data.SqlClient
Public Class datConexion
    Public cnn As SqlConnection

    Public Function Conectar(usuario As String, contrasena As String,
                             autenticacion As Boolean) As Boolean
        Dim cadena As String
        cadena = "Data Source=FAPCOD\SQLEXPRESS;Initial Catalog=Colegio_DB"
        If autenticacion Then
            cadena = cadena & ";Integrated Security=True"
        Else
            cadena = cadena & ";User Id=" & usuario &
                ";Password=" & contrasena
        End If
        Try
            cnn = New SqlConnection(cadena)
            cnn.Open()
            Return True
        Catch ex As Exception
            Return False
            MsgBox(ex.Message)
        End Try
    End Function
End Class