Imports CapaEntidad
Imports CapaNegocio
Public Class frmAnnoEscolar
#Region "Funcionalidad de la ventana"
    Private Sub frmAnnoEscolar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim neg As New negAnnoEscolar
        DataGridView1.DataSource = neg.listarAnnoEscolar()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAperturar.Click
        Dim objent As New entAnnoEscolar
        If compararAnnos() = False Then
            objent._numeroAnno = txtAnnoEscolar.Text
            objent._fechaInicio = dtFechaInicio.Text
            objent._fechaTermino = dtFechaFin.Text
            Dim objneg As New negAnnoEscolar
            Dim verificar = objneg.registrarAnnoEscolar(objent)
            If verificar Then
                MsgBox("Registro exitoso")
            Else
                MsgBox("AÑO YA ESTABLECIDO")
            End If
        Else
            MsgBox("Los años deben coincidir")
        End If
    End Sub
#End Region

#Region "VAlidacion de numeros o letras"
    Private Sub txtAnnoEscolar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAnnoEscolar.KeyPress
        If Char.IsNumber(e.KeyChar) Then 'Si es numero si entra al textbox
            e.Handled = False
            If txtAnnoEscolar.TextLength > 7 Then
                e.Handled = True
            End If
        ElseIf Char.IsControl(e.KeyChar) Then 'Si es una tecla de control si entra al textbox
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then 'Si es espacio no entra al textbox
            e.Handled = True
        Else
            e.Handled = True   'Si es letra no entra al textbox
        End If
    End Sub
#End Region

#Region "Finalizar"
    Protected Overrides Sub Finalize()
        Me.Close()
    End Sub
#End Region

#Region "Funciones Creadas"
    Private Function compararAnnos() As Boolean
        Dim fecha1 As Integer = dtFechaInicio.Value.Year
        Dim fecha2 As Integer = dtFechaFin.Value.Year
        Dim fecha3 As Integer = Val(txtAnnoEscolar.Text)
        Dim fecha4 As Integer = Year(Now)
        Dim comparar As Integer
        Dim comparar1 As Integer
        Dim comparar2 As Integer
        comparar2 = fecha3.CompareTo(fecha4)
        comparar = fecha1.CompareTo(fecha3)
        comparar1 = fecha2.CompareTo(fecha3)
        If comparar = 0 And comparar1 = 0 And comparar2 = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
#End Region
End Class