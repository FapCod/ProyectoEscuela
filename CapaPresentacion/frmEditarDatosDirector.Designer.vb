<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditarDatosDirector
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditarDatosDirector))
        Me.btnEditarMisDatos = New System.Windows.Forms.Button()
        Me.lblNombreUser = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtcontraseña = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdniuser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnombreuser = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtapellidouser = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcorreouser = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcargouser = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEditarMisDatos
        '
        Me.btnEditarMisDatos.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnEditarMisDatos.FlatAppearance.BorderSize = 0
        Me.btnEditarMisDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarMisDatos.Font = New System.Drawing.Font("Gadugi", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarMisDatos.ForeColor = System.Drawing.Color.White
        Me.btnEditarMisDatos.Location = New System.Drawing.Point(132, 415)
        Me.btnEditarMisDatos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEditarMisDatos.Name = "btnEditarMisDatos"
        Me.btnEditarMisDatos.Size = New System.Drawing.Size(341, 58)
        Me.btnEditarMisDatos.TabIndex = 18
        Me.btnEditarMisDatos.Text = "Editar Mis datos"
        Me.btnEditarMisDatos.UseVisualStyleBackColor = False
        '
        'lblNombreUser
        '
        Me.lblNombreUser.AutoSize = True
        Me.lblNombreUser.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreUser.ForeColor = System.Drawing.Color.White
        Me.lblNombreUser.Location = New System.Drawing.Point(128, 53)
        Me.lblNombreUser.Name = "lblNombreUser"
        Me.lblNombreUser.Size = New System.Drawing.Size(104, 24)
        Me.lblNombreUser.TabIndex = 20
        Me.lblNombreUser.Text = "Username"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(289, 56)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.ReadOnly = True
        Me.txtUsername.Size = New System.Drawing.Size(184, 22)
        Me.txtUsername.TabIndex = 53
        '
        'txtcontraseña
        '
        Me.txtcontraseña.Location = New System.Drawing.Point(289, 111)
        Me.txtcontraseña.Name = "txtcontraseña"
        Me.txtcontraseña.Size = New System.Drawing.Size(184, 22)
        Me.txtcontraseña.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(128, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 24)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Contraseña"
        '
        'txtdniuser
        '
        Me.txtdniuser.Location = New System.Drawing.Point(289, 156)
        Me.txtdniuser.Name = "txtdniuser"
        Me.txtdniuser.ReadOnly = True
        Me.txtdniuser.Size = New System.Drawing.Size(184, 22)
        Me.txtdniuser.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(128, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 24)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Dni User"
        '
        'txtnombreuser
        '
        Me.txtnombreuser.Location = New System.Drawing.Point(289, 217)
        Me.txtnombreuser.Name = "txtnombreuser"
        Me.txtnombreuser.Size = New System.Drawing.Size(184, 22)
        Me.txtnombreuser.TabIndex = 59
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(128, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 24)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Nombre User"
        '
        'txtapellidouser
        '
        Me.txtapellidouser.Location = New System.Drawing.Point(289, 268)
        Me.txtapellidouser.Name = "txtapellidouser"
        Me.txtapellidouser.Size = New System.Drawing.Size(184, 22)
        Me.txtapellidouser.TabIndex = 61
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(128, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 24)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Apellido User"
        '
        'txtcorreouser
        '
        Me.txtcorreouser.Location = New System.Drawing.Point(289, 323)
        Me.txtcorreouser.Name = "txtcorreouser"
        Me.txtcorreouser.Size = New System.Drawing.Size(184, 22)
        Me.txtcorreouser.TabIndex = 63
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(128, 320)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 24)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Correo User"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(494, 53)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(595, 371)
        Me.DataGridView1.TabIndex = 66
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(128, 369)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 24)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Cargo User"
        '
        'txtcargouser
        '
        Me.txtcargouser.Location = New System.Drawing.Point(289, 372)
        Me.txtcargouser.Name = "txtcargouser"
        Me.txtcargouser.ReadOnly = True
        Me.txtcargouser.Size = New System.Drawing.Size(184, 22)
        Me.txtcargouser.TabIndex = 68
        '
        'frmEditarDatosDirector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(1101, 564)
        Me.Controls.Add(Me.txtcargouser)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtcorreouser)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtapellidouser)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtnombreuser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtdniuser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtcontraseña)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblNombreUser)
        Me.Controls.Add(Me.btnEditarMisDatos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEditarDatosDirector"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEditarDatosDirector"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEditarMisDatos As System.Windows.Forms.Button
    Friend WithEvents lblNombreUser As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtcontraseña As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtdniuser As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnombreuser As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtapellidouser As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcorreouser As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtcargouser As System.Windows.Forms.TextBox
End Class
