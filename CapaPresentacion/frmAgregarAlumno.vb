Imports CapaEntidad
Imports CapaNegocio
Public Class frmAgregarAlumno
#Region "Funcionalidad de la ventana"

    Private Sub frmAgregarAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ver()
    End Sub
    Private Sub btnAgregarAlumno_Click(sender As Object, e As EventArgs) Handles btnagregarAlumno.Click
        If comprobar() Then
            Dim objentAlumno As New entAlumno
            objentAlumno._dniAlumno = txtdniAlumno.Text
            objentAlumno._nombreAlumno = txtnombreAlumno.Text
            objentAlumno._apellidoAlumno = txtapellidoAlumno.Text
            objentAlumno._edadAlumno = txtedadAlumno.Text
            objentAlumno._sexoAlumno = cmbsexoAlumno.Text
            objentAlumno._direccionAlumno = txtdireccionAlumno.Text
            objentAlumno._nombreDeApoderadoAlumno = txtnombreApoderadoAlumno.Text
            objentAlumno._numeroTelefonoApoderado = txtnumeroTelefonoApoderado.Text
            Dim objnegAlumno As New negAlumno
            Dim verificarRA = objnegAlumno.registrarAlumno(objentAlumno)
            If verificarRA = True Then
                MsgBox("registro exitoso")
                LimpiarDatos()
                Ver()
            Else
                MsgBox("Error de registro de Alumno")
            End If
        Else
            MsgBox("DEBE DE LLENAR TODOS LOS CAMPOS", MsgBoxStyle.Critical)
        End If

    End Sub


    Private Sub btnEditarA_Click(sender As Object, e As EventArgs) Handles btneditarAlumno.Click
        If comprobar() Then
            Dim objentAlumno As New entAlumno
            Dim dni As String
            Dim i As Integer
            i = DataGridView1.CurrentRow.Index
            dni = DataGridView1.Item(0, i).Value()
            objentAlumno._dniAlumno = txtdniAlumno.Text
            objentAlumno._nombreAlumno = txtnombreAlumno.Text
            objentAlumno._apellidoAlumno = txtapellidoAlumno.Text
            objentAlumno._edadAlumno = txtedadAlumno.Text
            objentAlumno._sexoAlumno = cmbsexoAlumno.Text
            objentAlumno._direccionAlumno = txtdireccionAlumno.Text
            objentAlumno._nombreDeApoderadoAlumno = txtnombreApoderadoAlumno.Text
            objentAlumno._numeroTelefonoApoderado = txtnumeroTelefonoApoderado.Text
            Dim negalum As New negAlumno
            Dim verificarRA = negalum.editarAlumno(objentAlumno)
            If verificarRA = True Then
                MsgBox("Actualizacion Exitosa")
                LimpiarDatos()
                Ver()
            Else
                MsgBox("Error de Actualizacion de Alumno")
            End If
        Else
            MsgBox("DEBE DE LLENAR TODOS LOS CAMPOS", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btnEliminarA_Click(sender As Object, e As EventArgs) Handles btneliminarAlumno.Click
        Try
            Dim negalum As New negAlumno
            Dim dni As String
            Dim i As Integer
            i = DataGridView1.CurrentRow.Index
            dni = DataGridView1.Item(0, i).Value()
            Dim verificarRA = negalum.eliminarAlumno(dni)
            If verificarRA = True Then
                MsgBox("Eliminacion Exitosa")
                LimpiarDatos()
                Ver()
            Else
                MsgBox("Error de Eliminacion de Alumno")
            End If
        Catch ex As Exception

        End Try
        
    End Sub
    Private Sub btnBuscarA_Click(sender As Object, e As EventArgs) Handles btnbuscarAlumno.Click
        Dim objnegAlumno As New negAlumno
        Dim dni As String
        dni = txtdniiAlumno.Text
        DataGridView1.DataSource = objnegAlumno.buscarAlumno(dni)
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        txtdniAlumno.Text = DataGridView1.Item(0, i).Value()
        txtnombreAlumno.Text = DataGridView1.Item(1, i).Value()
        txtapellidoAlumno.Text = DataGridView1.Item(2, i).Value()
        txtedadAlumno.Text = DataGridView1.Item(3, i).Value()
        cmbsexoAlumno.Text = DataGridView1.Item(4, i).Value()
        txtdireccionAlumno.Text = DataGridView1.Item(5, i).Value()
        txtnombreApoderadoAlumno.Text = DataGridView1.Item(6, i).Value()
        txtnumeroTelefonoApoderado.Text = DataGridView1.Item(7, i).Value()
    End Sub
    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Ver()
    End Sub
#End Region

#Region "metodos creados"
    Sub Ver()
        Dim conexion As New negAlumno
        DataGridView1.DataSource = conexion.obtenerTabla()
    End Sub
    Public Sub LimpiarDatos()
        txtdniAlumno.Clear()
        txtnombreAlumno.Clear()
        txtapellidoAlumno.Clear()
        txtedadAlumno.Clear()
        cmbsexoAlumno.Text = Nothing
        txtdireccionAlumno.Clear()
        txtnombreApoderadoAlumno.Clear()
        txtnumeroTelefonoApoderado.Clear()
    End Sub
#End Region

#Region "funciones creadas"
    Public Function comprobar() As Boolean
        If Len(Trim$(txtdniAlumno.Text)) <> 0 And Len(Trim$(txtnombreAlumno.Text)) <> 0 And Len(Trim$(txtapellidoAlumno.Text)) <> 0 And Len(Trim$(txtedadAlumno.Text)) <> 0 And Len(Trim$(cmbsexoAlumno.Text)) <> 0 And Len(Trim$(txtdireccionAlumno.Text)) <> 0 And Len(Trim$(txtnombreApoderadoAlumno.Text)) <> 0 And Len(Trim$(txtnumeroTelefonoApoderado.Text)) <> 0 Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region

#Region "Validacion de numero y letras"
    Private Sub txtdniAlumno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdniAlumno.KeyPress
        If Char.IsNumber(e.KeyChar) Then 'Si es numero si entra al textbox
            e.Handled = False
            If txtdniAlumno.TextLength > 7 Then
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

    Private Sub txtnombreAlumno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombreAlumno.KeyPress
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

    Private Sub txtapellidoAlumno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapellidoAlumno.KeyPress
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

    Private Sub txtedadAlumno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtedadAlumno.KeyPress
        If Char.IsNumber(e.KeyChar) Then 'Si es numero si entra al textbox
            e.Handled = False
            If txtedadAlumno.TextLength > 1 Then
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

    Private Sub txtnombreApoderadoAlumno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombreApoderadoAlumno.KeyPress
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

    Private Sub txtnumeroTelefonoApoderado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumeroTelefonoApoderado.KeyPress
        If Char.IsNumber(e.KeyChar) Then 'Si es numero si entra al textbox
            e.Handled = False
            If txtnumeroTelefonoApoderado.TextLength > 8 Then
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

    Private Sub txtdniiAlumno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdniiAlumno.KeyPress
        If Char.IsNumber(e.KeyChar) Then 'Si es numero si entra al textbox
            e.Handled = False
            If txtdniiAlumno.TextLength > 7 Then
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

#Region "Los colores cambian"
    Private Sub btnagregarAlumno_MouseEnter(sender As Object, e As EventArgs) Handles btnagregarAlumno.MouseEnter
        btnagregarAlumno.BackColor = Color.DeepSkyBlue
    End Sub

    Private Sub btnagregarAlumno_MouseLeave(sender As Object, e As EventArgs) Handles btnagregarAlumno.MouseLeave
        btnagregarAlumno.BackColor = Color.DodgerBlue
    End Sub

    Private Sub btneditarAlumno_MouseEnter(sender As Object, e As EventArgs) Handles btneditarAlumno.MouseEnter
        btneditarAlumno.BackColor = Color.DeepSkyBlue
    End Sub

    Private Sub btneditarAlumno_MouseLeave(sender As Object, e As EventArgs) Handles btneditarAlumno.MouseLeave
        btneditarAlumno.BackColor = Color.DodgerBlue
    End Sub

    Private Sub btneliminarAlumno_MouseEnter(sender As Object, e As EventArgs) Handles btneliminarAlumno.MouseEnter
        btneliminarAlumno.BackColor = Color.Red
    End Sub

    Private Sub btneliminarAlumno_MouseLeave(sender As Object, e As EventArgs) Handles btneliminarAlumno.MouseLeave
        btneliminarAlumno.BackColor = Color.DodgerBlue
    End Sub

    Private Sub btnbuscarAlumno_MouseEnter(sender As Object, e As EventArgs) Handles btnbuscarAlumno.MouseEnter
        btnbuscarAlumno.BackColor = Color.DeepSkyBlue
    End Sub

    Private Sub btnbuscarAlumno_MouseLeave(sender As Object, e As EventArgs) Handles btnbuscarAlumno.MouseLeave
        btnbuscarAlumno.BackColor = Color.DodgerBlue
    End Sub
#End Region

#Region "Finalizar"
    Protected Overrides Sub Finalize()
        Me.Close()
    End Sub
#End Region

   
   
    
End Class