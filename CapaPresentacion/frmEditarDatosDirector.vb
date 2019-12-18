Imports CapaNegocio
Imports CapaEntidad
Public Class frmEditarDatosDirector
#Region "Funcionalidad de la ventana"
    Private Sub frmEditarDatosDirector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ver()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        txtUsername.Text = DataGridView1.Item(0, i).Value()
        txtcontraseña.Text = DataGridView1.Item(1, i).Value()
        txtdniuser.Text = DataGridView1.Item(2, i).Value()
        txtnombreuser.Text = DataGridView1.Item(3, i).Value()
        txtapellidouser.Text = DataGridView1.Item(4, i).Value()
        txtcorreouser.Text = DataGridView1.Item(5, i).Value()
        txtcargouser.Text = DataGridView1.Item(6, i).Value()
    End Sub

    

    Private Sub btnEditarMisDatos_Click(sender As Object, e As EventArgs) Handles btnEditarMisDatos.Click
        Dim objentUser As New entUser
        objentUser._username = txtUsername.Text
        objentUser._contrasenaUsuario = txtcontraseña.Text
        objentUser._dniUsuario = txtdniuser.Text
        objentUser._nombreUsuario = txtnombreuser.Text
        objentUser._apellidoUsuario = txtapellidouser.Text
        objentUser._correoUsuario = txtcorreouser.Text
        objentUser._cargoUsuario = "Director"
        Dim objnegUser As New negUser
        Dim verificarRU = objnegUser.editarUsuario(objentUser)
        If verificarRU = True Then
            MsgBox("Usuario Actualizado")
            limpiar()
            ver()
        End If
    End Sub
#End Region

#Region "Metodos creados"
    Public Sub ver()
        Dim objneg As New negUser
        DataGridView1.DataSource = objneg.listarDirector(usuarioActivo.nombreUsuario)
    End Sub
    Public Sub limpiar()
        txtUsername.Clear()
        txtcontraseña.Clear()
        txtdniuser.Clear()
        txtnombreuser.Clear()
        txtapellidouser.Clear()
        txtcorreouser.Clear()
        txtcargouser.Clear()
    End Sub
#End Region
End Class