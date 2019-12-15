Imports System.Data.SqlClient
Public Class datGrado
    Inherits datConexion
    Public Function listarGradoInicial() As DataTable
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "listarGradoI"
                Command.CommandType = CommandType.StoredProcedure
                Dim dt1 As New DataTable
                dt1.Load(Command.ExecuteReader())
                If Command.ExecuteNonQuery Then
                    Return dt1
                Else
                    Return Nothing
                End If
            End Using
        End Using
        Return Nothing
    End Function

    Public Function listarGradoPrimaria() As DataTable
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "listarGradoP"
                Command.CommandType = CommandType.StoredProcedure
                Dim dt1 As New DataTable
                dt1.Load(Command.ExecuteReader())
                If Command.ExecuteNonQuery Then
                    Return dt1
                Else
                    Return Nothing
                End If
            End Using
        End Using
        Return Nothing
    End Function

   
    
End Class
