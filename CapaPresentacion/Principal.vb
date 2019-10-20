Public Class Principal

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        If MessageBox.Show("Estas seguro de cerrar Ventana?", "Mensaje",
         MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class