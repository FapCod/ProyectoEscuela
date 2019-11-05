
Imports CapaEntidad
Imports CapaNegocio
Public Class frmAgregarProfesor

    Private Sub frmAgregarProfesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ver()
        Dim objnegAula As New negAula
        cmbcodigoAula.DataSource = objnegAula.listarAula()
        cmbcodigoAula.DisplayMember = "nombreAula"
    End Sub

    Private Sub btnAgregarM_Click(sender As Object, e As EventArgs) Handles btnagregarProfesor.Click

        Dim objentProfesor As New entProfesor
        objentProfesor._dniProfesor = txtdniProfesor.Text
        objentProfesor._nombreProfesor = txtnombreProfesor.Text
        objentProfesor._apellidoProfesor = txtapellidoProfesor.Text
        objentProfesor._edadProfesor = txtedadProfesor.Text
        objentProfesor._sexoProfesor = cmbsexoProfesor.Text
        objentProfesor._direccionProfesor = txtdireccionProfesor.Text
        objentProfesor._correoProfesor = txtcorreoProfesor.Text
        objentProfesor._telefonoProfesor = txttelefonoProfesor.Text
        If cmbcodigoAula.Text = "Inicial 3" Then
            objentProfesor.objentAula._codigoAula = "I3"
        ElseIf cmbcodigoAula.Text = "Inicial 4" Then
            objentProfesor.objentAula._codigoAula = "I4"
        ElseIf cmbcodigoAula.Text = "Inicial 5" Then
            objentProfesor.objentAula._codigoAula = "I5"
        ElseIf cmbcodigoAula.Text = "Primaria 1" Then
            objentProfesor.objentAula._codigoAula = "P1"
        ElseIf cmbcodigoAula.Text = "Primaria 2" Then
            objentProfesor.objentAula._codigoAula = "P2"
        ElseIf cmbcodigoAula.Text = "Primaria 3" Then
            objentProfesor.objentAula._codigoAula = "P3"
        ElseIf cmbcodigoAula.Text = "Primaria 4" Then
            objentProfesor.objentAula._codigoAula = "P4"
        ElseIf cmbcodigoAula.Text = "Primaria 5" Then
            objentProfesor.objentAula._codigoAula = "P5"
        ElseIf cmbcodigoAula.Text = "Primaria 6" Then
            objentProfesor.objentAula._codigoAula = "P6"
        End If

        Dim objnegProfesor As New negProfesor
        Dim verificarRP = objnegProfesor.registrarProfesor(objentProfesor)
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
        dgvlista.DataSource = conexion.obtenerTabla()
    End Sub
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnactualizarProfesor.Click
        Dim objentProfesor As New entProfesor
        Dim dni As String
        Dim i As Integer
        i = dgvlista.CurrentRow.Index
        dni = dgvlista.Item(0, i).Value()
        objentProfesor._dniProfesor = dni
        objentProfesor._nombreProfesor = txtnombreProfesor.Text
        objentProfesor._apellidoProfesor = txtapellidoProfesor.Text
        objentProfesor._edadProfesor = txtedadProfesor.Text
        objentProfesor._sexoProfesor = cmbsexoProfesor.Text
        objentProfesor._direccionProfesor = txtdireccionProfesor.Text
        objentProfesor._correoProfesor = txtcorreoProfesor.Text
        objentProfesor._telefonoProfesor = txttelefonoProfesor.Text
        If cmbcodigoAula.Text = "Inicial 3" Then
            objentProfesor.objentAula._codigoAula = "I3"
        ElseIf cmbcodigoAula.Text = "Inicial 4" Then
            objentProfesor.objentAula._codigoAula = "I4"
        ElseIf cmbcodigoAula.Text = "Inicial 5" Then
            objentProfesor.objentAula._codigoAula = "I5"
        ElseIf cmbcodigoAula.Text = "Primaria 1" Then
            objentProfesor.objentAula._codigoAula = "P1"
        ElseIf cmbcodigoAula.Text = "Primaria 2" Then
            objentProfesor.objentAula._codigoAula = "P2"
        ElseIf cmbcodigoAula.Text = "Primaria 3" Then
            objentProfesor.objentAula._codigoAula = "P3"
        ElseIf cmbcodigoAula.Text = "Primaria 4" Then
            objentProfesor.objentAula._codigoAula = "P4"
        ElseIf cmbcodigoAula.Text = "Primaria 5" Then
            objentProfesor.objentAula._codigoAula = "P5"
        ElseIf cmbcodigoAula.Text = "Primaria 6" Then
            objentProfesor.objentAula._codigoAula = "P6"
        End If
        Dim objnegProfesor As New negProfesor
        Dim verificarRP = objnegProfesor.actualizarProfesor(objentProfesor)
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
        i = dgvlista.CurrentRow.Index
        txtdniProfesor.Text = dgvlista.Item(0, i).Value()
        txtnombreProfesor.Text = dgvlista.Item(1, i).Value()
        txtapellidoProfesor.Text = dgvlista.Item(2, i).Value()
        txtedadProfesor.Text = dgvlista.Item(3, i).Value()
        cmbsexoProfesor.Text = dgvlista.Item(4, i).Value()
        txtdireccionProfesor.Text = dgvlista.Item(5, i).Value()
        txtcorreoProfesor.Text = dgvlista.Item(6, i).Value()
        txttelefonoProfesor.Text = dgvlista.Item(7, i).Value()
        cmbcodigoAula.Text = dgvlista.Item(8, i).Value()
    End Sub

    

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btneliminarProfesor.Click
        Dim objnegProfesor As New negProfesor
        Dim dni As String
        Dim i As Integer
        i = dgvlista.CurrentRow.Index
        dni = dgvlista.Item(0, i).Value()
        Dim verificarRA = objnegProfesor.eliminarProfesor(dni)
        If verificarRA = True Then
            MsgBox("Eliminacion Exitosa")
            Ver()
        Else
            MsgBox("Error de Eliminacion de Alumno")
        End If
        LimpiarDatos()
    End Sub


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnbuscarProfesor.Click
        Dim objnegProfesor As New negProfesor
        Dim dni As String
        dni = txtdniIIProfesor.Text
        dgvlista.DataSource = objnegProfesor.buscarProfesor(dni)

    End Sub

    Public Sub LimpiarDatos()
        txtdniProfesor.Clear()
        txtnombreProfesor.Clear()
        txtapellidoProfesor.Clear()
        txtedadProfesor.Clear()
        cmbsexoProfesor.Text = ""
        txtdireccionProfesor.Clear()
        txtcorreoProfesor.Clear()
        txttelefonoProfesor.Clear()
        cmbcodigoAula.Text = ""
        txtdniIIProfesor.Clear()
    End Sub

    



    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btncancelarProfesor.Click
        LimpiarDatos()
    End Sub


End Class