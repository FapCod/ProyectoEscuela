Imports System.Data.SqlClient
Imports CapaEntidad
Public Class datSeccion
    Inherits datConexion

    Public Function registrarSeccion(objSeccion As entSeccion) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "registrarSeccion"
                Command.Parameters.AddWithValue("@nombreSeccion", objSeccion._nombreSeccion)
                Command.Parameters.AddWithValue("@codigoGrado", objSeccion.objentGrado._codigoGrado)
                Command.Parameters.AddWithValue("@dniProfesor", objSeccion.objentProfesor._dniProfesor)
                Command.Parameters.AddWithValue("@numeroAnno", objSeccion.objentNumeroAnno._numeroAnno)
                Command.Parameters.AddWithValue("@numeroVacantes", objSeccion._numeroVacantes)
                Command.Parameters.AddWithValue("@nivel", objSeccion._nivel)
                Command.Parameters.AddWithValue("@eliminacionLogica", objSeccion._eliminacionLogica)
                Command.CommandType = CommandType.StoredProcedure
                If Command.ExecuteNonQuery Then
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
        Return False
    End Function
    Public Function obtenerTabla() As DataTable
        Using conexion = ObtenerConexion()
            conexion.Open()
            Dim dt As DataTable
            Dim da As SqlDataAdapter
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandType = CommandType.StoredProcedure
                Command.CommandText = "obtenerTablaSeccion"
                If Command.ExecuteNonQuery Then
                    dt = New DataTable
                    da = New SqlDataAdapter(Command)
                    da.Fill(dt)
                    Return dt
                Else
                    Return Nothing
                End If
            End Using
        End Using
    End Function
    
    Public Function cargarSeccion(grado As Integer) As DataTable
        Using conexion = ObtenerConexion()
            conexion.Open()
            Dim dt As DataTable
            Dim da As SqlDataAdapter
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandType = CommandType.StoredProcedure
                Command.CommandText = "listarSeccionI"
                Command.Parameters.AddWithValue("@grado", grado)
                If Command.ExecuteNonQuery Then
                    dt = New DataTable
                    da = New SqlDataAdapter(Command)
                    da.Fill(dt)
                    Return dt
                Else
                    Return Nothing
                End If
            End Using
        End Using
    End Function

    Public Function cargarSeccionP(grado As Integer) As DataTable
        Using conexion = ObtenerConexion()
            conexion.Open()
            Dim dt As DataTable
            Dim da As SqlDataAdapter
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandType = CommandType.StoredProcedure
                Command.CommandText = "listarSeccionP"
                Command.Parameters.AddWithValue("@grado", grado)
                If Command.ExecuteNonQuery Then
                    dt = New DataTable
                    da = New SqlDataAdapter(Command)
                    da.Fill(dt)
                    Return dt
                Else
                    Return Nothing
                End If
            End Using
        End Using
    End Function
End Class
