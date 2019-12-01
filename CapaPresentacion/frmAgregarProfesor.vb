
Imports CapaEntidad
Imports CapaNegocio
Public Class frmAgregarProfesor

    Private Sub frmAgregarProfesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ver()
        
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
        If rbtlibre.Checked = True Then
            objentProfesor._estadoProfesor = True
        End If
        If rbtAsignado.Checked = False Then
            objentProfesor._estadoProfesor = False
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
        objentProfesor._dniProfesor = txtdniProfesor.Text
        objentProfesor._nombreProfesor = txtnombreProfesor.Text
        objentProfesor._apellidoProfesor = txtapellidoProfesor.Text
        objentProfesor._edadProfesor = txtedadProfesor.Text
        objentProfesor._sexoProfesor = cmbsexoProfesor.Text
        objentProfesor._direccionProfesor = txtdireccionProfesor.Text
        objentProfesor._correoProfesor = txtcorreoProfesor.Text
        objentProfesor._telefonoProfesor = txttelefonoProfesor.Text
        If rbtlibre.Checked = True Then
            objentProfesor._estadoProfesor = True
        End If
        If rbtAsignado.Checked = False Then
            objentProfesor._estadoProfesor = False
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
        If dgvlista.Item(8, i).Value() = True Then
            rbtlibre.Checked = True
        ElseIf dgvlista.Item(8, i).Value() = False Then
            rbtAsignado.Checked = True
        End If
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
        rbtlibre.Checked = False
        rbtAsignado.Checked = False
        txtdniIIProfesor.Clear()
    End Sub

    



    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btncancelarProfesor.Click
        LimpiarDatos()
    End Sub


    Private Sub txtdniProfesor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdniProfesor.KeyPress
        If Char.IsNumber(e.KeyChar) Then 'Si es numero si entra al textbox
            e.Handled = False
            If txtdniProfesor.TextLength > 7 Then
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

    Private Sub txtdniIIProfesor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdniIIProfesor.KeyPress
        If Char.IsNumber(e.KeyChar) Then 'Si es numero si entra al textbox
            e.Handled = False
            If txtdniIIProfesor.TextLength > 7 Then
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

    Private Sub txtnombreProfesor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombreProfesor.KeyPress
        If Char.IsLetter(e.KeyChar) Then 'Si es letra si entra al textbox
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then 'Si es una tecla de control si entra al textbox
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then 'Si es espacio si entra al textbox
            e.Handled = False
        Else
            e.Handled = True   'Si es numero no entra al textbox
        End If
    End Sub

    Private Sub txtapellidoProfesor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapellidoProfesor.KeyPress
        If Char.IsLetter(e.KeyChar) Then 'Si es letra si entra al textbox
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then 'Si es una tecla de control si entra al textbox
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then 'Si es espacio si entra al textbox
            e.Handled = False
        Else
            e.Handled = True   'Si es numero no entra al textbox
        End If
    End Sub

    Private Sub txtedadProfesor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtedadProfesor.KeyPress
        If Char.IsNumber(e.KeyChar) Then 'Si es numero si entra al textbox
            e.Handled = False
            If txtedadProfesor.TextLength > 1 Then
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

    Private Sub txttelefonoProfesor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelefonoProfesor.KeyPress
        If Char.IsNumber(e.KeyChar) Then 'Si es numero si entra al textbox
            e.Handled = False
            If txttelefonoProfesor.TextLength > 8 Then
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
End Class