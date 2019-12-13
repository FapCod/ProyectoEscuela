Imports System.Data.SqlClient
Imports CapaEntidad
Public Class datAnnoEscolar
    Inherits datConexion

    Public Function registrarAnnoEscolar(obj As entAnnoEscolar) As Boolean
        Try
            Using conexion = ObtenerConexion()
                conexion.Open()
                Using Command = New SqlCommand()
                    Command.Connection = conexion
                    Command.CommandText = "registrarAnnoEscolar"
                    Command.Parameters.AddWithValue("@numeroAnno", obj._numeroAnno)
                    Command.Parameters.AddWithValue("@fechaInicio", obj._fechaInicio)
                    Command.Parameters.AddWithValue("@fechaTermino", obj._fechaTermino)
                    Command.CommandType = CommandType.StoredProcedure
                    If Command.ExecuteNonQuery Then
                        Return True
                    Else
                        Return False
                    End If
                End Using
            End Using
            Return False
        Catch ex As Exception
            'MsgBox("Este año ya existe")
        End Try
        Return False
    End Function
    Public Function listarAnnoEscolar() As DataTable
        Dim cnn As SqlConnection
        Dim cadena As String
        cnn = ObtenerConexion()
        cadena = "SELECT * FROM annoEscolar"
        cnn.Open()
        Dim cmd As New SqlCommand(cadena, cnn)
        Dim dt2 As New DataTable
        dt2.Load(cmd.ExecuteReader())
        Return dt2
    End Function
End Class
