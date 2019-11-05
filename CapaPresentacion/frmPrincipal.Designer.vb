<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCerrarC = New System.Windows.Forms.PictureBox()
        Me.btnReportes = New System.Windows.Forms.Button()
        Me.btnListarAlumnos = New System.Windows.Forms.Button()
        Me.btnListarMaestros = New System.Windows.Forms.Button()
        Me.btnRegistrarNotas = New System.Windows.Forms.Button()
        Me.btnRegistrarAlumno = New System.Windows.Forms.Button()
        Me.btnRegistrarMaestro = New System.Windows.Forms.Button()
        Me.lblNombreUser = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblNombresUsuario = New System.Windows.Forms.Label()
        Me.lblApellidoUsuario = New System.Windows.Forms.Label()
        Me.lblCorreoUsuario = New System.Windows.Forms.Label()
        Me.lblCargoUsuario = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.btnCerrarC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), System.Drawing.Image)
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Location = New System.Drawing.Point(1220, 2)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(25, 27)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnMinimizar
        '
        Me.btnMinimizar.BackgroundImage = CType(resources.GetObject("btnMinimizar.BackgroundImage"), System.Drawing.Image)
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Location = New System.Drawing.Point(1189, 2)
        Me.btnMinimizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(25, 27)
        Me.btnMinimizar.TabIndex = 1
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel1.Controls.Add(Me.lblCargoUsuario)
        Me.Panel1.Controls.Add(Me.lblCorreoUsuario)
        Me.Panel1.Controls.Add(Me.lblApellidoUsuario)
        Me.Panel1.Controls.Add(Me.lblNombresUsuario)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnCerrarC)
        Me.Panel1.Controls.Add(Me.btnReportes)
        Me.Panel1.Controls.Add(Me.btnListarAlumnos)
        Me.Panel1.Controls.Add(Me.btnListarMaestros)
        Me.Panel1.Controls.Add(Me.btnRegistrarNotas)
        Me.Panel1.Controls.Add(Me.btnRegistrarAlumno)
        Me.Panel1.Controls.Add(Me.btnRegistrarMaestro)
        Me.Panel1.Controls.Add(Me.lblNombreUser)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(341, 666)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(77, 626)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Cerrar Cuenta"
        '
        'btnCerrarC
        '
        Me.btnCerrarC.Image = CType(resources.GetObject("btnCerrarC.Image"), System.Drawing.Image)
        Me.btnCerrarC.Location = New System.Drawing.Point(21, 615)
        Me.btnCerrarC.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCerrarC.Name = "btnCerrarC"
        Me.btnCerrarC.Size = New System.Drawing.Size(50, 50)
        Me.btnCerrarC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCerrarC.TabIndex = 8
        Me.btnCerrarC.TabStop = False
        '
        'btnReportes
        '
        Me.btnReportes.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnReportes.FlatAppearance.BorderSize = 0
        Me.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportes.Font = New System.Drawing.Font("Gadugi", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportes.ForeColor = System.Drawing.Color.White
        Me.btnReportes.Location = New System.Drawing.Point(0, 537)
        Me.btnReportes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(341, 58)
        Me.btnReportes.TabIndex = 7
        Me.btnReportes.Text = "Reportes"
        Me.btnReportes.UseVisualStyleBackColor = False
        '
        'btnListarAlumnos
        '
        Me.btnListarAlumnos.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnListarAlumnos.FlatAppearance.BorderSize = 0
        Me.btnListarAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListarAlumnos.Font = New System.Drawing.Font("Gadugi", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListarAlumnos.ForeColor = System.Drawing.Color.White
        Me.btnListarAlumnos.Location = New System.Drawing.Point(0, 471)
        Me.btnListarAlumnos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnListarAlumnos.Name = "btnListarAlumnos"
        Me.btnListarAlumnos.Size = New System.Drawing.Size(341, 58)
        Me.btnListarAlumnos.TabIndex = 6
        Me.btnListarAlumnos.Text = "Listar Alumnos"
        Me.btnListarAlumnos.UseVisualStyleBackColor = False
        '
        'btnListarMaestros
        '
        Me.btnListarMaestros.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnListarMaestros.FlatAppearance.BorderSize = 0
        Me.btnListarMaestros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListarMaestros.Font = New System.Drawing.Font("Gadugi", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListarMaestros.ForeColor = System.Drawing.Color.White
        Me.btnListarMaestros.Location = New System.Drawing.Point(0, 405)
        Me.btnListarMaestros.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnListarMaestros.Name = "btnListarMaestros"
        Me.btnListarMaestros.Size = New System.Drawing.Size(341, 58)
        Me.btnListarMaestros.TabIndex = 5
        Me.btnListarMaestros.Text = "Listar Maestros"
        Me.btnListarMaestros.UseVisualStyleBackColor = False
        '
        'btnRegistrarNotas
        '
        Me.btnRegistrarNotas.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnRegistrarNotas.FlatAppearance.BorderSize = 0
        Me.btnRegistrarNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrarNotas.Font = New System.Drawing.Font("Gadugi", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarNotas.ForeColor = System.Drawing.Color.White
        Me.btnRegistrarNotas.Location = New System.Drawing.Point(0, 337)
        Me.btnRegistrarNotas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRegistrarNotas.Name = "btnRegistrarNotas"
        Me.btnRegistrarNotas.Size = New System.Drawing.Size(341, 58)
        Me.btnRegistrarNotas.TabIndex = 4
        Me.btnRegistrarNotas.Text = "Registrar Notas"
        Me.btnRegistrarNotas.UseVisualStyleBackColor = False
        '
        'btnRegistrarAlumno
        '
        Me.btnRegistrarAlumno.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnRegistrarAlumno.FlatAppearance.BorderSize = 0
        Me.btnRegistrarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrarAlumno.Font = New System.Drawing.Font("Gadugi", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarAlumno.ForeColor = System.Drawing.Color.White
        Me.btnRegistrarAlumno.Location = New System.Drawing.Point(0, 266)
        Me.btnRegistrarAlumno.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRegistrarAlumno.Name = "btnRegistrarAlumno"
        Me.btnRegistrarAlumno.Size = New System.Drawing.Size(341, 58)
        Me.btnRegistrarAlumno.TabIndex = 3
        Me.btnRegistrarAlumno.Text = "Registrar Alumnos"
        Me.btnRegistrarAlumno.UseVisualStyleBackColor = False
        '
        'btnRegistrarMaestro
        '
        Me.btnRegistrarMaestro.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnRegistrarMaestro.FlatAppearance.BorderSize = 0
        Me.btnRegistrarMaestro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrarMaestro.Font = New System.Drawing.Font("Gadugi", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarMaestro.ForeColor = System.Drawing.Color.White
        Me.btnRegistrarMaestro.Location = New System.Drawing.Point(0, 195)
        Me.btnRegistrarMaestro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRegistrarMaestro.Name = "btnRegistrarMaestro"
        Me.btnRegistrarMaestro.Size = New System.Drawing.Size(341, 58)
        Me.btnRegistrarMaestro.TabIndex = 2
        Me.btnRegistrarMaestro.Text = "Registrar Profesor"
        Me.btnRegistrarMaestro.UseVisualStyleBackColor = False
        '
        'lblNombreUser
        '
        Me.lblNombreUser.AutoSize = True
        Me.lblNombreUser.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreUser.ForeColor = System.Drawing.Color.White
        Me.lblNombreUser.Location = New System.Drawing.Point(88, 9)
        Me.lblNombreUser.Name = "lblNombreUser"
        Me.lblNombreUser.Size = New System.Drawing.Size(129, 24)
        Me.lblNombreUser.TabIndex = 1
        Me.lblNombreUser.Text = "NombreUser"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(113, 33)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblNombresUsuario
        '
        Me.lblNombresUsuario.AutoSize = True
        Me.lblNombresUsuario.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombresUsuario.ForeColor = System.Drawing.Color.White
        Me.lblNombresUsuario.Location = New System.Drawing.Point(67, 80)
        Me.lblNombresUsuario.Name = "lblNombresUsuario"
        Me.lblNombresUsuario.Size = New System.Drawing.Size(168, 24)
        Me.lblNombresUsuario.TabIndex = 10
        Me.lblNombresUsuario.Text = "NombresUsuario"
        '
        'lblApellidoUsuario
        '
        Me.lblApellidoUsuario.AutoSize = True
        Me.lblApellidoUsuario.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidoUsuario.ForeColor = System.Drawing.Color.White
        Me.lblApellidoUsuario.Location = New System.Drawing.Point(67, 104)
        Me.lblApellidoUsuario.Name = "lblApellidoUsuario"
        Me.lblApellidoUsuario.Size = New System.Drawing.Size(161, 24)
        Me.lblApellidoUsuario.TabIndex = 11
        Me.lblApellidoUsuario.Text = "ApellidoUsuario"
        '
        'lblCorreoUsuario
        '
        Me.lblCorreoUsuario.AutoSize = True
        Me.lblCorreoUsuario.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreoUsuario.ForeColor = System.Drawing.Color.White
        Me.lblCorreoUsuario.Location = New System.Drawing.Point(3, 128)
        Me.lblCorreoUsuario.Name = "lblCorreoUsuario"
        Me.lblCorreoUsuario.Size = New System.Drawing.Size(145, 24)
        Me.lblCorreoUsuario.TabIndex = 12
        Me.lblCorreoUsuario.Text = "CorreoUsuario"
        '
        'lblCargoUsuario
        '
        Me.lblCargoUsuario.AutoSize = True
        Me.lblCargoUsuario.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCargoUsuario.ForeColor = System.Drawing.Color.White
        Me.lblCargoUsuario.Location = New System.Drawing.Point(68, 152)
        Me.lblCargoUsuario.Name = "lblCargoUsuario"
        Me.lblCargoUsuario.Size = New System.Drawing.Size(137, 24)
        Me.lblCargoUsuario.TabIndex = 13
        Me.lblCargoUsuario.Text = "CargoUsuario"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(1251, 666)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnMinimizar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Principal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnCerrarC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnMinimizar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnReportes As System.Windows.Forms.Button
    Friend WithEvents btnListarAlumnos As System.Windows.Forms.Button
    Friend WithEvents btnListarMaestros As System.Windows.Forms.Button
    Friend WithEvents btnRegistrarNotas As System.Windows.Forms.Button
    Friend WithEvents btnRegistrarAlumno As System.Windows.Forms.Button
    Friend WithEvents btnRegistrarMaestro As System.Windows.Forms.Button
    Friend WithEvents lblNombreUser As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCerrarC As System.Windows.Forms.PictureBox
    Friend WithEvents lblCargoUsuario As System.Windows.Forms.Label
    Friend WithEvents lblCorreoUsuario As System.Windows.Forms.Label
    Friend WithEvents lblApellidoUsuario As System.Windows.Forms.Label
    Friend WithEvents lblNombresUsuario As System.Windows.Forms.Label
End Class
