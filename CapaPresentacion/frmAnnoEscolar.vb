Imports CapaEntidad
Imports CapaNegocio
Public Class frmAnnoEscolar

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAperturar.Click
        Dim objent As New entAnnoEscolar
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
    End Sub

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

    
#Region "Finalizar"
    Protected Overrides Sub Finalize()
        Me.Close()
    End Sub
#End Region
End Class