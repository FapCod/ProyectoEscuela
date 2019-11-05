Imports CapaEntidad
Imports CapaNegocio
Public Class frmAgregarAlumno

    Private Sub btnAgregarAlumno_Click(sender As Object, e As EventArgs) Handles btnagregarAlumno.Click
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


    End Sub







  

    
    Public Sub LimpiarDatos()
        txtdniAlumno.Clear()
        txtnombreAlumno.Clear()
        txtapellidoAlumno.Clear()
        txtedadAlumno.Clear()
        cmbsexoAlumno.Text = ""
        txtdireccionAlumno.Clear()
        txtnombreApoderadoAlumno.Clear()
        txtnumeroTelefonoApoderado.Clear()
    End Sub

    Private Sub btnEditarA_Click(sender As Object, e As EventArgs) Handles btneditarAlumno.Click
        Dim objentAlumno As New entAlumno
        Dim dni As String
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        dni = DataGridView1.Item(0, i).Value()
        objentAlumno._dniAlumno = dni
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
    End Sub

    Private Sub btnEliminarA_Click(sender As Object, e As EventArgs) Handles btneliminarAlumno.Click
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
    End Sub

    Sub Ver()
        Dim conexion As New negALUMNO
        DataGridView1.DataSource = conexion.obtenerTabla()
    End Sub

    Private Sub frmAgregarAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ver()
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

    Private Sub btnBuscarA_Click(sender As Object, e As EventArgs) Handles btnbuscarAlumno.Click
        Dim objnegAlumno As New negAlumno
        Dim dni As String
        dni = txtdniiAlumno.Text
        DataGridView1.DataSource = objnegAlumno.buscarAlumno(dni)
    End Sub

   


  
    
End Class