
Imports CapaEntidad
Imports CapaNegocio
Public Class frmAgregarProfesor



    Private Sub btnAgregarM_Click(sender As Object, e As EventArgs) Handles btnagregarProfesor.Click

        Dim objeP As New entProfesor

        objeP._nombreProfesor = txtnombreProfesor.Text
        objeP._apellidoProfesor = txtapellidoProfesor.Text
        objeP._correoProfesor = txtcorreoProfesor.Text
        objeP._sexoProfesor = cmbsexoProfesor.Text
        objeP._telefonoProfesor = Val(txttelefonoProfesor.Text)
        objeP._direccionProfesor = txtdireccionProfesor.Text
        'validacion de checkbox

        objeP._tipoProfesor = cmbtipoProfesor.Text
        Dim negPro As New negProfesor
        Dim negUsu As New negUser

        Dim verificarRP = negPro.registrarProfesor(objeP)
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
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnactualizarProfesor.Click
        Dim objeP As New entProfesor
        objeP._nombreProfesor = txtnombreProfesor.Text
        objeP._apellidoProfesor = txtapellidoProfesor.Text
        objeP._correoProfesor = txtcorreoProfesor.Text
        objeP._sexoProfesor = cmbsexoProfesor.Text
        objeP._telefonoProfesor = Val(txttelefonoProfesor.Text)
        objeP._direccionProfesor = txtdireccionProfesor.Text
        objeP._tipoProfesor = cmbtipoProfesor.Text
        'validacion de checkbox
        Dim negprofe As New negProfesor
        Dim id As Integer
        Dim i As Integer
        i = dgvlista.CurrentRow.Index
        id = dgvlista.Item(0, i).Value()
        Dim verificarRP = negprofe.actualizarProfesor(objeP)
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
        txtnombreProfesor.Text = dgvlista.Item(1, i).Value()
        txtapellidoProfesor.Text = dgvlista.Item(2, i).Value()
        txtcorreoProfesor.Text = dgvlista.Item(3, i).Value()
        cmbsexoProfesor.Text = dgvlista.Item(4, i).Value()
        txttelefonoProfesor.Text = dgvlista.Item(5, i).Value()
        txtdireccionProfesor.Text = dgvlista.Item(6, i).Value()
        asignaturas = dgvlista.Item(7, i).Value()
        nivel = dgvlista.Item(8, i).Value
        If nivel = "Inicial" Then
            cmbprimariaGradoProfesor.Text = ("")
            rbinicialProfesor.Checked = True
            cmbinicialGradoProfesor.Text = dgvlista.Item(9, i).Value()
        ElseIf nivel = "Primaria" Then
            cmbinicialGradoProfesor.Text = ("")
            rbprimariaProfesor.Checked = True
            cmbprimariaGradoProfesor.Text = dgvlista.Item(9, i).Value()
        End If

        cmbtipoProfesor.Text = dgvlista.Item(10, i).Value()
    End Sub

    Private Sub frmAgregarProfesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ver()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btneliminarProfesor.Click
        Dim negprof As New negProfesor
        Dim id As Integer
        Dim i As Integer
        i = dgvlista.CurrentRow.Index
        id = dgvlista.Item(0, i).Value()
        Dim verificarRA = negprof.eliminarProfesor(id)
        If verificarRA = True Then
            MsgBox("Eliminacion Exitosa")
            Ver()
        Else
            MsgBox("Error de Eliminacion de Alumno")
        End If
        LimpiarDatos()
    End Sub


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnbuscarProfesor.Click
        Dim negprof As New negProfesor
        Dim id As Integer
        id = Val(txtidProfesor.Text)

        dgvlista.DataSource = negprof.buscarProfesor(id)

    End Sub

    Public Sub LimpiarDatos()
        txtnombreProfesor.Clear()
        txtapellidoProfesor.Clear()
        cmbsexoProfesor.Text = ""
        rbinicialProfesor.Checked = False
        rbprimariaProfesor.Checked = False
        cmbinicialGradoProfesor.Text = ("")
        cmbprimariaGradoProfesor.Text = ("")
        txtidProfesor.Clear()
        txtcorreoProfesor.Clear()
        txttelefonoProfesor.Clear()
        txtdireccionProfesor.Clear()
        cmbtipoProfesor.Text = ("")
       

    End Sub

    Private Sub rbInicial_CheckedChanged(sender As Object, e As EventArgs) Handles rbinicialProfesor.CheckedChanged

        If rbinicialProfesor.Checked = True Then
            cmbprimariaGradoProfesor.Enabled = False
        End If
        If rbinicialProfesor.Checked = True Then
            cmbinicialGradoProfesor.Enabled = True
        End If

    End Sub



    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btncancelarProfesor.Click
        LimpiarDatos()
    End Sub


    Private Sub rbPrimaria_CheckedChanged(sender As Object, e As EventArgs) Handles rbprimariaProfesor.CheckedChanged
        If rbprimariaProfesor.Checked = True Then
            cmbinicialGradoProfesor.Enabled = False
        End If
        If rbprimariaProfesor.Checked = True Then
            cmbprimariaGradoProfesor.Enabled = True
        End If

    End Sub
End Class