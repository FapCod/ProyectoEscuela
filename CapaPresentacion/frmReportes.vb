Public Class frmReportes

    Private Sub btnReporteProfesor_Click(sender As Object, e As EventArgs) Handles btnReporteProfesor.Click
        frmReporteProfesor.Show()
    End Sub


#Region "Finalizar"
    Protected Overrides Sub Finalize()
        Me.Close()
    End Sub
#End Region

   
    Private Sub btnReporteAlumno_Click(sender As Object, e As EventArgs) Handles btnReporteAlumno.Click
        frmReporteAlumno.Show()
    End Sub

    Private Sub btnReporteNota_Click(sender As Object, e As EventArgs) Handles btnReporteNota.Click
        frmReporteNotas.Show()
    End Sub
End Class