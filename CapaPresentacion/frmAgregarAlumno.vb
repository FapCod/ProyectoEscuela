Imports CapaEntidad
Imports CapaNegocio
Public Class frmAgregarAlumno

    Private Sub btnAgregarAlumno_Click(sender As Object, e As EventArgs) Handles btnAgregarAlumno.Click
        Dim objeA As New entAlumno
        objeA._NombreA = txtNombreA.Text
        objeA._ApellidosA = txtApellidoA.Text
        objeA._SexoA = cmbSexoA.Text
        If rbInicial.Checked = True Then
            objeA._NivelA = "Inicial"
            objeA._GradoA = cmbGradoIn.Text
            objeA._SeccionA = cmbSeccionIn.Text
        ElseIf rbPrimaria.Checked = True Then
            objeA._NivelA = "Primaria"
            objeA._GradoA = cmbGradoPri.Text
            objeA._SeccionA = cmbSeccionPri.Text
        End If
        objeA._DireccionA = txtDireccion.Text
        objeA._NombreApo = txtNombreApo.Text
        Dim negalum As New negAlumno
        Dim verificarRA = negalum.Registrar_Alumno(objeA)
        If verificarRA = True Then
            MsgBox("registro exitoso")
            cmbGradoPri.Enabled = True
            cmbSeccionPri.Enabled = True
            cmbGradoIn.Enabled = True
            cmbSeccionIn.Enabled = True
            LimpiarDatos()
            Ver()
        Else
            MsgBox("Error de registro de Alumno")
        End If


    End Sub


      



    
    Private Sub rbInicial_Click(sender As Object, e As EventArgs) Handles rbInicial.Click
        If rbInicial.Checked = True Then
            cmbGradoPri.Enabled = False
            cmbSeccionPri.Enabled = False
        End If
    End Sub

    Private Sub rbPrimaria_Click(sender As Object, e As EventArgs) Handles rbPrimaria.Click
        If rbPrimaria.Checked = True Then
            cmbGradoIn.Enabled = False
            cmbSeccionIn.Enabled = False
        End If
    End Sub
    Public Sub LimpiarDatos()
        txtNombreA.Clear()
        txtApellidoA.Clear()
        cmbSexoA.Text = ""
        rbInicial.Checked = False
        rbPrimaria.Checked = False
        cmbGradoPri.Text = ("")
        cmbSeccionPri.Text = ("")
        cmbGradoIn.Text = ("")
        cmbSeccionIn.Text = ("")
        txtDireccion.Clear()
        txtNombreApo.Clear()

    End Sub

    Private Sub btnEditarA_Click(sender As Object, e As EventArgs) Handles btnEditarA.Click
        Dim objeA As New entAlumno
        objeA._NombreA = txtNombreA.Text
        objeA._ApellidosA = txtApellidoA.Text
        objeA._SexoA = cmbSexoA.Text
        If rbInicial.Checked = True Then
            objeA._NivelA = "Inicial"
            objeA._GradoA = cmbGradoIn.Text
            objeA._SeccionA = cmbSeccionIn.Text
        ElseIf rbPrimaria.Checked = True Then
            objeA._NivelA = "Primaria"
            objeA._GradoA = cmbGradoPri.Text
            objeA._SeccionA = cmbSeccionPri.Text
        End If
        objeA._DireccionA = txtDireccion.Text
        objeA._NombreApo = txtNombreApo.Text
        Dim negalum As New negAlumno
        Dim id As Integer
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        id = DataGridView1.Item(0, i).Value()
        Dim verificarRA = negalum.Editar_Alumno(objeA, id)
        If verificarRA = True Then
            MsgBox("Actualizacion Exitosa")
            cmbGradoPri.Enabled = True
            cmbSeccionPri.Enabled = True
            cmbGradoIn.Enabled = True
            cmbSeccionIn.Enabled = True
            LimpiarDatos()
            Ver()
        Else
            MsgBox("Error de Actualizacion de Alumno")
        End If
    End Sub

    Private Sub btnEliminarA_Click(sender As Object, e As EventArgs) Handles btnEliminarA.Click
        Dim negalum As New negAlumno
        Dim id As Integer
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        id = DataGridView1.Item(0, i).Value()
        Dim verificarRA = negalum.Eliminar_Alumno(id)
        If verificarRA = True Then
            MsgBox("Eliminacion Exitosa")
            cmbGradoPri.Enabled = True
            cmbSeccionPri.Enabled = True
            cmbGradoIn.Enabled = True
            cmbSeccionIn.Enabled = True
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
        txtNombreA.Text = DataGridView1.Item(1, i).Value()
        txtApellidoA.Text = DataGridView1.Item(2, i).Value()
        cmbSexoA.Text = DataGridView1.Item(3, i).Value()
        nivel = DataGridView1.Item(4, i).Value()
        If nivel = "Inicial" Then
            cmbGradoPri.Text = ("")
            cmbSeccionPri.Text = ("")
            rbInicial.Checked = True
            cmbGradoIn.Text = DataGridView1.Item(5, i).Value()
            cmbSeccionIn.Text = DataGridView1.Item(6, i).Value()
        ElseIf nivel = "Primaria" Then
            cmbGradoIn.Text = ("")
            cmbSeccionIn.Text = ("")
            rbPrimaria.Checked = True
            cmbGradoPri.Text = DataGridView1.Item(5, i).Value()
            cmbSeccionPri.Text = DataGridView1.Item(6, i).Value()
        End If
        txtDireccion.Text = DataGridView1.Item(7, i).Value()
        txtNombreApo.Text = DataGridView1.Item(8, i).Value()
    End Sub

    Private Sub btnBuscarA_Click(sender As Object, e As EventArgs) Handles btnBuscarA.Click
        Dim negalumn As New negAlumno
        Dim id As Integer
        id = Val(txtBuscarA.Text)

        DataGridView1.DataSource = negalumn.Buscar_Alumno(id)




    End Sub
End Class