
Imports CapaEntidad
Imports CapaNegocio
Public Class frmAgregarProfesor
#Region "Funcionalidad de la ventana"
    Private Sub frmAgregarProfesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ver()
    End Sub

    Private Sub btnAgregarM_Click(sender As Object, e As EventArgs) Handles btnagregarProfesor.Click
        Dim objentProfesor As New entProfesor
        Dim objentUser As New entUser
        If comprobar() Then
            objentProfesor._dniProfesor = txtdniProfesor.Text
            objentProfesor._nombreProfesor = txtnombreProfesor.Text
            objentProfesor._apellidoProfesor = txtapellidoProfesor.Text
            objentProfesor._edadProfesor = txtedadProfesor.Text
            objentProfesor._sexoProfesor = cmbsexoProfesor.Text
            objentProfesor._direccionProfesor = txtdireccionProfesor.Text
            objentProfesor._correoProfesor = txtcorreoProfesor.Text
            objentProfesor._telefonoProfesor = txttelefonoProfesor.Text
            objentUser._username = txtdniProfesor.Text
            objentUser._contrasenaUsuario = txtdniProfesor.Text
            objentUser._dniUsuario = txtdniProfesor.Text
            objentUser._nombreUsuario = txtnombreProfesor.Text
            objentUser._apellidoUsuario = txtapellidoProfesor.Text
            objentUser._correoUsuario = txtcorreoProfesor.Text
            objentUser._cargoUsuario = "Profesor"
            Dim objnegProfesor As New negProfesor
            Dim objnegUser As New negUser
            Dim verificarRP = objnegProfesor.registrarProfesor(objentProfesor)
            Dim verificarRU = objnegUser.crearUsuario(objentUser)
            If verificarRP = True Then
                MsgBox("registro exitoso")
                If verificarRU = True Then
                    MsgBox("Usuario Creado")
                    MsgBox("Nombre de usuario:" & txtdniProfesor.Text & vbLf & "Su contraseña es:" & txtdniProfesor.Text)
                End If
            Else
                MsgBox("Error de registro de profesor")
            End If
            Ver()
            LimpiarDatos()
        Else
            MsgBox("DEBE DE LLENAR TODOS LOS DATOS", MsgBoxStyle.Critical)
        End If

    End Sub


    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnactualizarProfesor.Click
        Dim objentProfesor As New entProfesor
        Dim dni As String
        Dim i As Integer
        i = dgvlista.CurrentRow.Index
        dni = dgvlista.Item(0, i).Value()
        If comprobar() Then
            objentProfesor._dniProfesor = dni
            objentProfesor._dniProfesor = txtdniProfesor.Text
            objentProfesor._nombreProfesor = txtnombreProfesor.Text
            objentProfesor._apellidoProfesor = txtapellidoProfesor.Text
            objentProfesor._edadProfesor = txtedadProfesor.Text
            objentProfesor._sexoProfesor = cmbsexoProfesor.Text
            objentProfesor._direccionProfesor = txtdireccionProfesor.Text
            objentProfesor._correoProfesor = txtcorreoProfesor.Text
            objentProfesor._telefonoProfesor = txttelefonoProfesor.Text
            Dim objnegProfesor As New negProfesor
            Dim verificarRP = objnegProfesor.actualizarProfesor(objentProfesor)
            If verificarRP = True Then
                MsgBox("Actualizacion Exitosa")
                LimpiarDatos()

                Ver()
            Else
                MsgBox("Error de Actualizacion de Profesor")
            End If
        Else
            MsgBox("DEBE DE LLENAR TODOS LOS DATOS", MsgBoxStyle.Critical)
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
    End Sub



    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btneliminarProfesor.Click
        Try
            Dim objnegProfesor As New negProfesor
            Dim objnegU As New negUser
            Dim dni As String
            Dim i As Integer
            i = dgvlista.CurrentRow.Index
            dni = dgvlista.Item(0, i).Value()
            Dim verificarRA = objnegProfesor.eliminarProfesor(dni)
            Dim verificarRU = objnegU.eliminarUsuario(dni)
            If verificarRA = True And verificarRU = True Then
                MsgBox("Eliminacion Exitosa")
                Ver()
            Else
                MsgBox("Error de Eliminacion de Profesor")
            End If
            LimpiarDatos()
        Catch ex As Exception

        End Try
        
    End Sub


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnbuscarProfesor.Click
        Dim objnegProfesor As New negProfesor
        Dim dni As String
        dni = txtdniIIProfesor.Text
        dgvlista.DataSource = objnegProfesor.buscarProfesor(dni)

    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btncancelarProfesor.Click
        LimpiarDatos()
    End Sub
    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Ver()
    End Sub
#End Region

#Region "metodos creados"
    Sub Ver()
        Dim conexion As New negProfesor
        dgvlista.DataSource = conexion.obtenerTabla()
    End Sub
    Public Sub LimpiarDatos()
        txtdniProfesor.Clear()
        txtnombreProfesor.Clear()
        txtapellidoProfesor.Clear()
        txtedadProfesor.Clear()
        cmbsexoProfesor.Text = Nothing
        txtdireccionProfesor.Clear()
        txtcorreoProfesor.Clear()
        txttelefonoProfesor.Clear()
        txtdniIIProfesor.Clear()
    End Sub
#End Region

#Region "funciones creadas"
    Public Function comprobar() As Boolean
        If Len(Trim$(txtdniProfesor.Text)) <> 0 And Len(Trim$(txtnombreProfesor.Text)) <> 0 And Len(Trim$(txtapellidoProfesor.Text)) <> 0 And Len(Trim$(txtedadProfesor.Text)) <> 0 And Len(Trim$(cmbsexoProfesor.Text)) <> 0 And Len(Trim$(txtdireccionProfesor.Text)) <> 0 And Len(Trim$(txtcorreoProfesor.Text)) <> 0 And Len(Trim$(txttelefonoProfesor.Text)) <> 0 Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region

#Region "validacion de numeros y letras"
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
#End Region

#Region "los colores cambian"
    Private Sub btnagregarProfesor_MouseEnter(sender As Object, e As EventArgs) Handles btnagregarProfesor.MouseEnter
        btnagregarProfesor.BackColor = Color.DeepSkyBlue
    End Sub

    Private Sub btnagregarProfesor_MouseLeave(sender As Object, e As EventArgs) Handles btnagregarProfesor.MouseLeave
        btnagregarProfesor.BackColor = Color.DodgerBlue
    End Sub

    Private Sub btnactualizarProfesor_MouseEnter(sender As Object, e As EventArgs) Handles btnactualizarProfesor.MouseEnter
        btnactualizarProfesor.BackColor = Color.DeepSkyBlue
    End Sub

    Private Sub btnactualizarProfesor_MouseLeave(sender As Object, e As EventArgs) Handles btnactualizarProfesor.MouseLeave
        btnactualizarProfesor.BackColor = Color.DodgerBlue
    End Sub

    Private Sub btneliminarProfesor_MouseEnter(sender As Object, e As EventArgs) Handles btneliminarProfesor.MouseEnter
        btneliminarProfesor.BackColor = Color.Red
    End Sub

    Private Sub btneliminarProfesor_MouseLeave(sender As Object, e As EventArgs) Handles btneliminarProfesor.MouseLeave
        btneliminarProfesor.BackColor = Color.DodgerBlue
    End Sub

    Private Sub btncancelarProfesor_MouseEnter(sender As Object, e As EventArgs) Handles btncancelarProfesor.MouseEnter
        btncancelarProfesor.BackColor = Color.Red
    End Sub

    Private Sub btncancelarProfesor_MouseLeave(sender As Object, e As EventArgs) Handles btncancelarProfesor.MouseLeave
        btncancelarProfesor.BackColor = Color.DodgerBlue
    End Sub

    Private Sub btnbuscarProfesor_MouseEnter(sender As Object, e As EventArgs) Handles btnbuscarProfesor.MouseEnter
        btnbuscarProfesor.BackColor = Color.DeepSkyBlue
    End Sub

    Private Sub btnbuscarProfesor_MouseLeave(sender As Object, e As EventArgs) Handles btnbuscarProfesor.MouseLeave
        btnbuscarProfesor.BackColor = Color.DodgerBlue
    End Sub
#End Region

#Region "Finalizar"
    Protected Overrides Sub Finalize()
        Me.Close()
    End Sub
#End Region

End Class