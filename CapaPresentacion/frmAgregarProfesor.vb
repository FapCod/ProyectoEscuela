
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
            objeP._asignaturasP = asigna
        ElseIf chcCienciasN.Checked = True Then
            asigna = chcCienciasN.Text
        End If
        If chcCienciasS.Checked = True Then
            asigna = "Ciencias Sociales"
            objeP._asignaturasP = asigna
        ElseIf chcCienciasS.Checked = True Then
            asigna = chcCienciasS.Text
        End If
        If chcEducacionF.Checked = True Then
            asigna = "Educacion Fisica"
            objeP._asignaturasP = asigna
        ElseIf chcEducacionF.Checked = True Then
            asigna = chcEducacionF.Text
        End If
        If chcLengua.Checked = True Then
            asigna = "Lengua"
            objeP._asignaturasP = asigna
        ElseIf chcLengua.Checked = True Then
            asigna = chcLengua.Text
        End If
        If chcMatematicas.Checked = True Then
            asigna = "Matematica"
            objeP._asignaturasP = asigna
        ElseIf chcMatematicas.Checked = True Then
            asigna = chcMatematicas.Text
        End If
        If chcPrimeraLE.Checked = True Then
            asigna = "Primera lengua"
            objeP._asignaturasP = asigna
        ElseIf chcPrimeraLE.Checked = True Then
            asigna = chcPrimeraLE.Text
        End If
        If chcReligion.Checked = True Then
            asigna = "Religion"
            objeP._asignaturasP = asigna
            objeP._asignaturasP = asigna
        ElseIf chcReligion.Checked = True Then
            asigna = chcReligion.Text
        End If

        If rbInicial.Checked = True Then
            objeP._nivelP = "Inicial"
            objeP._gradoYseccionP = cmbInicialGradPorf.Text
        End If
        If rbPrimaria.Checked = True Then
            objeP._nivelP = "Primaria"
            objeP._gradoYseccionP = cmbGradPorf.Text
        End If

        If cmbInicialGradPorf.Text <> "" Then
            objeP._gradoYseccionP = cmbInicialGradPorf.Text
        ElseIf cmbGradPorf.Text <> "" Then
            objeP._gradoYseccionP = cmbGradPorf.Text
        End If
        objeP._tipoP = cmbTipoProf.Text
        Dim negPro As New negProfesor
        Dim verificarRP = negPro.Registrar_prof(objeP)
        If verificarRP = True Then
            MsgBox("registro exitoso")
        Else
            MsgBox("Error de registro de profesor")
        End If
        Ver()
        LimpiarDatos()


    End Sub

    Sub Ver()
        Dim conexion As New negProfesor
        dgvlista.DataSource = conexion.obtenerTabla("select * from Profesor")
    End Sub
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim asigna As String
        Dim objeP As New entProfesor
        objeP._nombreP = txtNombreProf.Text
        objeP._apellidoP = txtApellidoProf.Text
        objeP._correoP = txtCorreoProf.Text
        objeP._sexoP = cmbSexo.Text
        objeP._telefonoP = Val(txtTelefonoProf.Text)
        objeP._direccionP = txtDireccionProf.Text
        objeP._tipoP = cmbTipoProf.Text
        'validacion de checkbox
        If chcCienciasN.Checked = True Then
            asigna = "Ciencias Naturales"
            objeP._asignaturasP = asigna
        ElseIf chcCienciasN.Checked = True Then
            asigna = chcCienciasN.Text
        End If
        If chcCienciasS.Checked = True Then
            asigna = "Ciencias Sociales"
            objeP._asignaturasP = asigna
        ElseIf chcCienciasS.Checked = True Then
            asigna = chcCienciasS.Text
        End If
        If chcEducacionF.Checked = True Then
            asigna = "Educacion Fisica"
            objeP._asignaturasP = asigna
        ElseIf chcEducacionF.Checked = True Then
            asigna = chcEducacionF.Text
        End If
        If chcLengua.Checked = True Then
            asigna = "Lengua"
            objeP._asignaturasP = asigna
        ElseIf chcLengua.Checked = True Then
            asigna = chcLengua.Text
        End If
        If chcMatematicas.Checked = True Then
            asigna = "Matematica"
            objeP._asignaturasP = asigna
        ElseIf chcMatematicas.Checked = True Then
            asigna = chcMatematicas.Text
        End If
        If chcPrimeraLE.Checked = True Then
            asigna = "Primera lengua"
            objeP._asignaturasP = asigna
        ElseIf chcPrimeraLE.Checked = True Then
            asigna = chcPrimeraLE.Text
        End If
        If chcReligion.Checked = True Then
            asigna = "Religion"
            objeP._asignaturasP = asigna
        ElseIf chcReligion.Checked = True Then
            asigna = chcReligion.Text
        End If
        If rbInicial.Checked = True Then
            objeP._nivelP = "Inicial"
            objeP._gradoYseccionP = cmbInicialGradPorf.Text
        End If
        If rbPrimaria.Checked = True Then
            objeP._nivelP = "Primaria"
            objeP._gradoYseccionP = cmbGradPorf.Text
        End If
        Dim negprofe As New negProfesor
        Dim id As Integer
        Dim i As Integer
        i = dgvlista.CurrentRow.Index
        id = dgvlista.Item(0, i).Value()
        Dim verificarRP = negprofe.Actualizar_Profesor(objeP, id)
        If verificarRP = True Then
            MsgBox("Actualizacion Exitosa")
            LimpiarDatos()
            Ver()
        Else
            MsgBox("Error de Actualizacion de Alumno")
        End If
    End Sub



    Private Sub dgvlista_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvlista.CellClick
        Dim i As Integer
        Dim asignaturas As String
        Dim nivel As String
        i = dgvlista.CurrentRow.Index
        txtNombreProf.Text = dgvlista.Item(1, i).Value()
        txtApellidoProf.Text = dgvlista.Item(2, i).Value()
        txtCorreoProf.Text = dgvlista.Item(3, i).Value()
        cmbSexo.Text = dgvlista.Item(4, i).Value()
        txtTelefonoProf.Text = dgvlista.Item(5, i).Value()
        txtDireccionProf.Text = dgvlista.Item(6, i).Value()
        asignaturas = dgvlista.Item(7, i).Value()
        If asignaturas = "Ciencias Naturales" Then
            chcCienciasN.Checked = True
        End If
        If asignaturas = "Ciencias Sociales" Then
            chcCienciasS.Checked = True
        End If
        If asignaturas = "Educacion Fisica" Then
            chcEducacionF.Checked = True
        End If
        If asignaturas = "Religion" Then
            chcReligion.Checked = True
        End If
        If asignaturas = "Matematica" Then
            chcMatematicas.Checked = True
        End If
        If asignaturas = "Primera lengua" Then
            chcPrimeraLE.Checked = True
        End If
        If asignaturas = "Lengua" Then
            chcLengua.Checked = True
        End If
        nivel = dgvlista.Item(8, i).Value
        If nivel = "Inicial" Then
            cmbGradPorf.Text = ("")
            rbInicial.Checked = True
            cmbInicialGradPorf.Text = dgvlista.Item(9, i).Value()
        ElseIf nivel = "Primaria" Then
            cmbInicialGradPorf.Text = ("")
            rbPrimaria.Checked = True
            cmbGradPorf.Text = dgvlista.Item(9, i).Value()
        End If

        cmbTipoProf.Text = dgvlista.Item(10, i).Value()
    End Sub

    Private Sub frmAgregarProfesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ver()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim negprof As New negProfesor
        Dim id As Integer
        Dim i As Integer
        i = dgvlista.CurrentRow.Index
        id = dgvlista.Item(0, i).Value()
        Dim verificarRA = negprof.Eliminar_Profesor(id)
        If verificarRA = True Then
            MsgBox("Eliminacion Exitosa")
            Ver()
        Else
            MsgBox("Error de Eliminacion de Alumno")
        End If
        LimpiarDatos()
    End Sub


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim negprof As New negProfesor
        Dim id As Integer
        id = Val(txtBuscarProf.Text)

        dgvlista.DataSource = negprof.Buscar_Profesor(id)

    End Sub

    Public Sub LimpiarDatos()
        txtNombreProf.Clear()
        txtApellidoProf.Clear()
        cmbSexo.Text = ""
        rbInicial.Checked = False
        rbPrimaria.Checked = False
        cmbInicialGradPorf.Text = ("")
        cmbGradPorf.Text = ("")
        txtBuscarProf.Clear()
        txtCorreoProf.Clear()
        txtTelefonoProf.Clear()
        txtDireccionProf.Clear()
        cmbTipoProf.Text = ("")
        chcCienciasN.Checked = False
        chcCienciasS.Checked = False
        chcEducacionF.Checked = False
        chcLengua.Checked = False
        chcMatematicas.Checked = False
        chcPrimeraLE.Checked = False
        chcReligion.Checked = False

    End Sub

    
   
End Class