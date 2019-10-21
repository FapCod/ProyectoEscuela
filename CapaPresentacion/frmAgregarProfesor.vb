
Imports CapaEntidad
Imports CapaNegocio
Public Class frmAgregarProfesor


    Private Sub btnAgregarM_Click(sender As Object, e As EventArgs) Handles btnAgregarM.Click
        Dim asigna As String
        Dim objeP As New entProfesor
        objeP._nombreP = txtNombreProf.Text
        objeP._apellidoP = txtApellidoProf.Text
        objeP._correoP = txtCorreoProf.Text
        objeP._sexoP = cmbSexo.Text
        objeP._telefonoP = Val(txtTelefonoProf.Text)
        objeP._direccionP = txtDireccionProf.Text
        'validacion de checkbox

        If chcCienciasN.Checked = True Then
            asigna = "Ciencias Naturales"
        ElseIf chcCienciasN.Checked = True Then
            asigna = chcCienciasN.Text
        End If
        If chcCienciasS.Checked = True Then
            asigna = "Ciencias Sociales"
        ElseIf chcCienciasS.Checked = True Then
            asigna = chcCienciasS.Text
        End If
        If chcEducacionF.Checked = True Then
            asigna = "Educacion Fisica"
        ElseIf chcEducacionF.Checked = True Then
            asigna = chcEducacionF.Text
        End If
        If chcLengua.Checked = True Then
            asigna = "Lengua"
        ElseIf chcLengua.Checked = True Then
            asigna = chcLengua.Text
        End If
        If chcMatematicas.Checked = True Then
            asigna = "Matematica"
        ElseIf chcMatematicas.Checked = True Then
            asigna = chcMatematicas.Text
        End If
        If chcPrimeraLE.Checked = True Then
            asigna = "Primera lengua"
        ElseIf chcPrimeraLE.Checked = True Then
            asigna = chcPrimeraLE.Text
        End If
        If chcReligion.Checked = True Then
            asigna = "Religion"
            objeP._asignaturasP = asigna
        ElseIf chcReligion.Checked = True Then
            asigna = chcReligion.Text

        End If

        If cmbInicialGradPorf.Text <> "" Then
            objeP._gradoYseccionP = cmbInicialGradPorf.Text & cmbInicialSecPorf.Text
        ElseIf cmbGradPorf.Text <> "" Then
            objeP._gradoYseccionP = cmbGradPorf.Text & cmbSecPorf.Text
        End If
        objeP._tipoP = cmbTipoProf.Text
        Dim negPro As New negProfesor
        Dim verificarRP = negPro.Registrar_prof(objeP)
        If verificarRP = True Then
            MsgBox("registro exitoso")
        Else
            MsgBox("Error de registro de profesor")
        End If



    End Sub
End Class