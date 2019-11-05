Imports CapaEntidad
Imports CapaNegocio
Public Class frmAgregarAlumno

    Private Sub btnAgregarAlumno_Click(sender As Object, e As EventArgs) Handles btnagregarAlumno.Click
        Dim objeA As New entAlumno
        objeA._nombreAlumno = txtnombreAlumno.Text
        objeA._apellidoAlumno = txtapellidoAlumno.Text
        objeA._sexoAlumno = cmbsexoAlumno.Text
        If rbinicial.Checked = True Then
            objeA._nivelAlumno = "Inicial"
            objeA._gradoSeccionAlumno = cmbgradoInicial.Text
        ElseIf rbprimaria.Checked = True Then
            objeA._nivelAlumno = "Primaria"
            objeA._gradoSeccionAlumno = cmbgradoPrimaria.Text
        End If
        objeA._direccionAlumno = txtdireccionAlumno.Text
        objeA._nombreDeApoderadoAlumno = txtnombreApoderadoAlumno.Text
        Dim negalum As New negAlumno
        Dim verificarRA = negalum.registrarAlumno(objeA)
        If verificarRA = True Then
            MsgBox("registro exitoso")
            cmbgradoPrimaria.Enabled = True
            cmbseccionPrimaria.Enabled = True
            cmbgradoInicial.Enabled = True
            cmbseccionInicial.Enabled = True
            LimpiarDatos()
            Ver()
        Else
            MsgBox("Error de registro de Alumno")
        End If


    End Sub







    Private Sub rbInicial_Click(sender As Object, e As EventArgs) Handles rbinicial.Click
        If rbinicial.Checked = True Then
            cmbgradoPrimaria.Enabled = False
            cmbseccionPrimaria.Enabled = False
        End If
    End Sub

    Private Sub rbPrimaria_Click(sender As Object, e As EventArgs) Handles rbprimaria.Click
        If rbprimaria.Checked = True Then
            cmbgradoInicial.Enabled = False
            cmbseccionInicial.Enabled = False
        End If
    End Sub
    Public Sub LimpiarDatos()
        txtnombreAlumno.Clear()
        txtapellidoAlumno.Clear()
        cmbsexoAlumno.Text = ""
        rbinicial.Checked = False
        rbprimaria.Checked = False
        cmbgradoPrimaria.Text = ("")
        cmbseccionPrimaria.Text = ("")
        cmbgradoInicial.Text = ("")
        cmbseccionInicial.Text = ("")
        txtdireccionAlumno.Clear()
        txtnombreApoderadoAlumno.Clear()

    End Sub

    Private Sub btnEditarA_Click(sender As Object, e As EventArgs) Handles btneditarAlumno.Click
        Dim objeA As New entAlumno
        objeA._nombreAlumno = txtnombreAlumno.Text
        objeA._apellidoAlumno = txtapellidoAlumno.Text
        objeA._sexoAlumno = cmbsexoAlumno.Text
        If rbinicial.Checked = True Then
            objeA._nivelAlumno = "Inicial"
            objeA._gradoSeccionAlumno = cmbgradoInicial.Text

        ElseIf rbprimaria.Checked = True Then
            objeA._nivelAlumno = "Primaria"
            objeA._gradoSeccionAlumno = cmbgradoPrimaria.Text

        End If
        objeA._direccionAlumno = txtdireccionAlumno.Text
        objeA._nombreDeApoderadoAlumno = txtnombreApoderadoAlumno.Text
        Dim negalum As New negAlumno
        Dim id As Integer
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        id = DataGridView1.Item(0, i).Value()
        Dim verificarRA = negalum.editarAlumno(objeA)
        If verificarRA = True Then
            MsgBox("Actualizacion Exitosa")
            cmbgradoPrimaria.Enabled = True
            cmbseccionPrimaria.Enabled = True
            cmbgradoInicial.Enabled = True
            cmbseccionInicial.Enabled = True
            LimpiarDatos()
            Ver()
        Else
            MsgBox("Error de Actualizacion de Alumno")
        End If
    End Sub

    Private Sub btnEliminarA_Click(sender As Object, e As EventArgs) Handles btneliminarAlumno.Click
        Dim negalum As New negAlumno
        Dim id As Integer
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        id = DataGridView1.Item(0, i).Value()
        Dim verificarRA = negalum.eliminarAlumno(id)
        If verificarRA = True Then
            MsgBox("Eliminacion Exitosa")
            cmbgradoPrimaria.Enabled = True
            cmbseccionPrimaria.Enabled = True
            cmbgradoInicial.Enabled = True
            cmbseccionInicial.Enabled = True
            LimpiarDatos()
            Ver()
        Else
            MsgBox("Error de Eliminacion de Alumno")
        End If
    End Sub

    Sub Ver()
        Dim conexion As New negALUMNO
        DataGridView1.DataSource = conexion.obtenerTabla("select * from ALUMNO")
    End Sub

    Private Sub frmAgregarAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ver()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        Dim nivel As String
        i = DataGridView1.CurrentRow.Index
        txtnombreAlumno.Text = DataGridView1.Item(1, i).Value()
        txtapellidoAlumno.Text = DataGridView1.Item(2, i).Value()
        cmbsexoAlumno.Text = DataGridView1.Item(3, i).Value()
        nivel = DataGridView1.Item(4, i).Value()
        If nivel = "Inicial" Then
            cmbgradoPrimaria.Text = ("")
            cmbseccionPrimaria.Text = ("")
            rbinicial.Checked = True
            cmbgradoInicial.Text = DataGridView1.Item(5, i).Value()
            cmbseccionInicial.Text = DataGridView1.Item(6, i).Value()
        ElseIf nivel = "Primaria" Then
            cmbgradoInicial.Text = ("")
            cmbseccionInicial.Text = ("")
            rbprimaria.Checked = True
            cmbgradoPrimaria.Text = DataGridView1.Item(5, i).Value()
            cmbseccionPrimaria.Text = DataGridView1.Item(6, i).Value()
        End If
        txtdireccionAlumno.Text = DataGridView1.Item(7, i).Value()
        txtnombreApoderadoAlumno.Text = DataGridView1.Item(8, i).Value()
    End Sub

    Private Sub btnBuscarA_Click(sender As Object, e As EventArgs) Handles btnbuscarAlumno.Click
        Dim negalumn As New negAlumno
        Dim id As Integer
        id = Val(txtidAlumno.Text)

        DataGridView1.DataSource = negalumn.buscarAlumno(id)




    End Sub

    Private Sub rbInicial_CheckedChanged(sender As Object, e As EventArgs) Handles rbinicial.CheckedChanged
        If rbinicial.Checked = True Then
            cmbgradoPrimaria.Enabled = False
            cmbseccionPrimaria.Enabled = False
        End If
        If rbinicial.Checked = True Then
            cmbgradoInicial.Enabled = True
            cmbseccionInicial.Enabled = True
        End If

    End Sub


    Private Sub rbPrimaria_CheckedChanged(sender As Object, e As EventArgs) Handles rbprimaria.CheckedChanged
        If rbprimaria.Checked = True Then
            cmbseccionInicial.Enabled = False
            cmbgradoInicial.Enabled = False
        End If
        If rbprimaria.Checked = True Then
            cmbgradoPrimaria.Enabled = True
            cmbseccionPrimaria.Enabled = True
        End If
    End Sub
End Class