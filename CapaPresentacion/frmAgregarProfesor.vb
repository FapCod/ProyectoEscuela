
Imports CapaEntidad
Public Class frmAgregarProfesor


    Private Sub btnAgregarM_Click(sender As Object, e As EventArgs) Handles btnAgregarM.Click
        'Private nombreP
        'Private apellidoP
        'Private correoP
        'Private sexoP
        'Private telefonoP
        'Private direccionP
        'Private asignaturasP
        'Private gradoYseccionP
        'Private tipoP
        Dim objeP As New entProfesor
        objeP._nombreP = txtNombreProf.Text
        objeP._apellidoP = txtApellidoProf.Text
        objeP._correoP = txtCorreoProf.Text
        objeP._sexoP = cmbSexo.Text
        objeP._telefonoP = txtTelefonoProf.Text
        objeP._direccionP = txtDireccionProf.Text
        objeP._asignaturasP = chcCienciasN.Text & chcCienciasS.Text & chcEducacionF.Text & chcLengua.Text & chcMatematicas.Text & chcPrimeraLE.Text & chcReligion.Text
        If cmbInicialGradPorf.Text <> "" Then
            objeP._gradoYseccionP = cmbInicialGradPorf.Text & cmbInicialSecPorf.Text
        ElseIf cmbGradPorf.Text <> "" Then
            objeP._gradoYseccionP = cmbGradPorf.Text & cmbSecPorf.Text
        End If
        objeP._tipoP = cmbTipoProf.Text



    End Sub
End Class