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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnEditarMisDatos = New System.Windows.Forms.Button()
        Me.btnAperturarAno = New System.Windows.Forms.Button()
        Me.btnReporteProfesor = New System.Windows.Forms.Button()
        Me.btnRegistrarSeccion = New System.Windows.Forms.Button()
        Me.btnRegistrarNotas = New System.Windows.Forms.Button()
        Me.btnListarMaestros = New System.Windows.Forms.Button()
        Me.lblCargoUsuario = New System.Windows.Forms.Label()
        Me.lblCorreoUsuario = New System.Windows.Forms.Label()
        Me.lblApellidoUsuario = New System.Windows.Forms.Label()
        Me.lblNombresUsuario = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCerrarC = New System.Windows.Forms.PictureBox()
        Me.btnReportes = New System.Windows.Forms.Button()
        Me.btnListarAlumnos = New System.Windows.Forms.Button()
        Me.btnRegistrarAlumno = New System.Windows.Forms.Button()
        Me.btnRegistrarMaestro = New System.Windows.Forms.Button()
        Me.lblNombreUser = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.thorafecha = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrarC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.btnEditarMisDatos)
        Me.Panel1.Controls.Add(Me.btnAperturarAno)
        Me.Panel1.Controls.Add(Me.btnReporteProfesor)
        Me.Panel1.Controls.Add(Me.btnRegistrarSeccion)
        Me.Panel1.Controls.Add(Me.btnRegistrarNotas)
        Me.Panel1.Controls.Add(Me.btnListarMaestros)
        Me.Panel1.Controls.Add(Me.lblCargoUsuario)
        Me.Panel1.Controls.Add(Me.lblCorreoUsuario)
        Me.Panel1.Controls.Add(Me.lblApellidoUsuario)
        Me.Panel1.Controls.Add(Me.lblNombresUsuario)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnCerrarC)
        Me.Panel1.Controls.Add(Me.btnReportes)
        Me.Panel1.Controls.Add(Me.btnListarAlumnos)
        Me.Panel1.Controls.Add(Me.btnRegistrarAlumno)
        Me.Panel1.Controls.Add(Me.btnRegistrarMaestro)
        Me.Panel1.Controls.Add(Me.lblNombreUser)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(439, 882)
        Me.Panel1.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-624, 279)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(8, 8)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'btnEditarMisDatos
        '
        Me.btnEditarMisDatos.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnEditarMisDatos.FlatAppearance.BorderSize = 0
        Me.btnEditarMisDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarMisDatos.Font = New System.Drawing.Font("Gadugi", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarMisDatos.ForeColor = System.Drawing.Color.White
        Me.btnEditarMisDatos.Image = CType(resources.GetObject("btnEditarMisDatos.Image"), System.Drawing.Image)
        Me.btnEditarMisDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditarMisDatos.Location = New System.Drawing.Point(43, 154)
        Me.btnEditarMisDatos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEditarMisDatos.Name = "btnEditarMisDatos"
        Me.btnEditarMisDatos.Size = New System.Drawing.Size(341, 58)
        Me.btnEditarMisDatos.TabIndex = 17
        Me.btnEditarMisDatos.Text = "Editar Mis datos"
        Me.btnEditarMisDatos.UseVisualStyleBackColor = False
        '
        'btnAperturarAno
        '
        Me.btnAperturarAno.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAperturarAno.FlatAppearance.BorderSize = 0
        Me.btnAperturarAno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAperturarAno.Font = New System.Drawing.Font("Gadugi", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAperturarAno.ForeColor = System.Drawing.Color.White
        Me.btnAperturarAno.Image = CType(resources.GetObject("btnAperturarAno.Image"), System.Drawing.Image)
        Me.btnAperturarAno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAperturarAno.Location = New System.Drawing.Point(43, 216)
        Me.btnAperturarAno.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAperturarAno.Name = "btnAperturarAno"
        Me.btnAperturarAno.Size = New System.Drawing.Size(341, 58)
        Me.btnAperturarAno.TabIndex = 16
        Me.btnAperturarAno.Text = "Aperturar Año"
        Me.btnAperturarAno.UseVisualStyleBackColor = False
        '
        'btnReporteProfesor
        '
        Me.btnReporteProfesor.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnReporteProfesor.FlatAppearance.BorderSize = 0
        Me.btnReporteProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReporteProfesor.Font = New System.Drawing.Font("Gadugi", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporteProfesor.ForeColor = System.Drawing.Color.White
        Me.btnReporteProfesor.Image = CType(resources.GetObject("btnReporteProfesor.Image"), System.Drawing.Image)
        Me.btnReporteProfesor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReporteProfesor.Location = New System.Drawing.Point(43, 712)
        Me.btnReporteProfesor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReporteProfesor.Name = "btnReporteProfesor"
        Me.btnReporteProfesor.Size = New System.Drawing.Size(341, 58)
        Me.btnReporteProfesor.TabIndex = 15
        Me.btnReporteProfesor.Text = "Reportes"
        Me.btnReporteProfesor.UseVisualStyleBackColor = False
        '
        'btnRegistrarSeccion
        '
        Me.btnRegistrarSeccion.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnRegistrarSeccion.FlatAppearance.BorderSize = 0
        Me.btnRegistrarSeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrarSeccion.Font = New System.Drawing.Font("Gadugi", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarSeccion.ForeColor = System.Drawing.Color.White
        Me.btnRegistrarSeccion.Image = CType(resources.GetObject("btnRegistrarSeccion.Image"), System.Drawing.Image)
        Me.btnRegistrarSeccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistrarSeccion.Location = New System.Drawing.Point(43, 402)
        Me.btnRegistrarSeccion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRegistrarSeccion.Name = "btnRegistrarSeccion"
        Me.btnRegistrarSeccion.Size = New System.Drawing.Size(341, 58)
        Me.btnRegistrarSeccion.TabIndex = 14
        Me.btnRegistrarSeccion.Text = "Registrar Seccion"
        Me.btnRegistrarSeccion.UseVisualStyleBackColor = False
        '
        'btnRegistrarNotas
        '
        Me.btnRegistrarNotas.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnRegistrarNotas.FlatAppearance.BorderSize = 0
        Me.btnRegistrarNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrarNotas.Font = New System.Drawing.Font("Gadugi", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarNotas.ForeColor = System.Drawing.Color.White
        Me.btnRegistrarNotas.Image = CType(resources.GetObject("btnRegistrarNotas.Image"), System.Drawing.Image)
        Me.btnRegistrarNotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistrarNotas.Location = New System.Drawing.Point(43, 526)
        Me.btnRegistrarNotas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRegistrarNotas.Name = "btnRegistrarNotas"
        Me.btnRegistrarNotas.Size = New System.Drawing.Size(341, 58)
        Me.btnRegistrarNotas.TabIndex = 4
        Me.btnRegistrarNotas.Text = "Registrar Notas"
        Me.btnRegistrarNotas.UseVisualStyleBackColor = False
        '
        'btnListarMaestros
        '
        Me.btnListarMaestros.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnListarMaestros.FlatAppearance.BorderSize = 0
        Me.btnListarMaestros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListarMaestros.Font = New System.Drawing.Font("Gadugi", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListarMaestros.ForeColor = System.Drawing.Color.White
        Me.btnListarMaestros.Image = CType(resources.GetObject("btnListarMaestros.Image"), System.Drawing.Image)
        Me.btnListarMaestros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListarMaestros.Location = New System.Drawing.Point(43, 588)
        Me.btnListarMaestros.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnListarMaestros.Name = "btnListarMaestros"
        Me.btnListarMaestros.Size = New System.Drawing.Size(341, 58)
        Me.btnListarMaestros.TabIndex = 5
        Me.btnListarMaestros.Text = "Listar Maestros"
        Me.btnListarMaestros.UseVisualStyleBackColor = False
        '
        'lblCargoUsuario
        '
        Me.lblCargoUsuario.AutoSize = True
        Me.lblCargoUsuario.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCargoUsuario.ForeColor = System.Drawing.Color.White
        Me.lblCargoUsuario.Location = New System.Drawing.Point(76, 107)
        Me.lblCargoUsuario.Name = "lblCargoUsuario"
        Me.lblCargoUsuario.Size = New System.Drawing.Size(137, 24)
        Me.lblCargoUsuario.TabIndex = 13
        Me.lblCargoUsuario.Text = "CargoUsuario"
        '
        'lblCorreoUsuario
        '
        Me.lblCorreoUsuario.AutoSize = True
        Me.lblCorreoUsuario.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreoUsuario.ForeColor = System.Drawing.Color.White
        Me.lblCorreoUsuario.Location = New System.Drawing.Point(75, 83)
        Me.lblCorreoUsuario.Name = "lblCorreoUsuario"
        Me.lblCorreoUsuario.Size = New System.Drawing.Size(145, 24)
        Me.lblCorreoUsuario.TabIndex = 12
        Me.lblCorreoUsuario.Text = "CorreoUsuario"
        '
        'lblApellidoUsuario
        '
        Me.lblApellidoUsuario.AutoSize = True
        Me.lblApellidoUsuario.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidoUsuario.ForeColor = System.Drawing.Color.White
        Me.lblApellidoUsuario.Location = New System.Drawing.Point(76, 59)
        Me.lblApellidoUsuario.Name = "lblApellidoUsuario"
        Me.lblApellidoUsuario.Size = New System.Drawing.Size(161, 24)
        Me.lblApellidoUsuario.TabIndex = 11
        Me.lblApellidoUsuario.Text = "ApellidoUsuario"
        '
        'lblNombresUsuario
        '
        Me.lblNombresUsuario.AutoSize = True
        Me.lblNombresUsuario.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombresUsuario.ForeColor = System.Drawing.Color.White
        Me.lblNombresUsuario.Location = New System.Drawing.Point(75, 38)
        Me.lblNombresUsuario.Name = "lblNombresUsuario"
        Me.lblNombresUsuario.Size = New System.Drawing.Size(168, 24)
        Me.lblNombresUsuario.TabIndex = 10
        Me.lblNombresUsuario.Text = "NombresUsuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(109, 796)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Cerrar Cuenta"
        '
        'btnCerrarC
        '
        Me.btnCerrarC.Image = CType(resources.GetObject("btnCerrarC.Image"), System.Drawing.Image)
        Me.btnCerrarC.Location = New System.Drawing.Point(43, 783)
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
        Me.btnReportes.Image = CType(resources.GetObject("btnReportes.Image"), System.Drawing.Image)
        Me.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReportes.Location = New System.Drawing.Point(43, 464)
        Me.btnReportes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(341, 58)
        Me.btnReportes.TabIndex = 7
        Me.btnReportes.Text = "Registrar Matricula"
        Me.btnReportes.UseVisualStyleBackColor = False
        '
        'btnListarAlumnos
        '
        Me.btnListarAlumnos.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnListarAlumnos.FlatAppearance.BorderSize = 0
        Me.btnListarAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListarAlumnos.Font = New System.Drawing.Font("Gadugi", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListarAlumnos.ForeColor = System.Drawing.Color.White
        Me.btnListarAlumnos.Image = CType(resources.GetObject("btnListarAlumnos.Image"), System.Drawing.Image)
        Me.btnListarAlumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListarAlumnos.Location = New System.Drawing.Point(43, 650)
        Me.btnListarAlumnos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnListarAlumnos.Name = "btnListarAlumnos"
        Me.btnListarAlumnos.Size = New System.Drawing.Size(341, 58)
        Me.btnListarAlumnos.TabIndex = 6
        Me.btnListarAlumnos.Text = "Listar Alumnos"
        Me.btnListarAlumnos.UseVisualStyleBackColor = False
        '
        'btnRegistrarAlumno
        '
        Me.btnRegistrarAlumno.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnRegistrarAlumno.FlatAppearance.BorderSize = 0
        Me.btnRegistrarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrarAlumno.Font = New System.Drawing.Font("Gadugi", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarAlumno.ForeColor = System.Drawing.Color.White
        Me.btnRegistrarAlumno.Image = CType(resources.GetObject("btnRegistrarAlumno.Image"), System.Drawing.Image)
        Me.btnRegistrarAlumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistrarAlumno.Location = New System.Drawing.Point(43, 278)
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
        Me.btnRegistrarMaestro.Image = CType(resources.GetObject("btnRegistrarMaestro.Image"), System.Drawing.Image)
        Me.btnRegistrarMaestro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistrarMaestro.Location = New System.Drawing.Point(43, 340)
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
        Me.lblNombreUser.Location = New System.Drawing.Point(75, 14)
        Me.lblNombreUser.Name = "lblNombreUser"
        Me.lblNombreUser.Size = New System.Drawing.Size(129, 24)
        Me.lblNombreUser.TabIndex = 1
        Me.lblNombreUser.Text = "NombreUser"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 28)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Gadugi", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.Color.White
        Me.lblHora.Location = New System.Drawing.Point(1102, 727)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(241, 40)
        Me.lblHora.TabIndex = 16
        Me.lblHora.Text = "AquiIraLaHora"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Gadugi", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.White
        Me.lblFecha.Location = New System.Drawing.Point(977, 792)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(182, 28)
        Me.lblFecha.TabIndex = 16
        Me.lblFecha.Text = "aquiIraLaFecha"
        '
        'thorafecha
        '
        Me.thorafecha.Enabled = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(489, 190)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(882, 499)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 17
        Me.PictureBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gadugi", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(576, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(687, 51)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "INSTITUCION EDUCATIVA 15144"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(1403, 882)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrarC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents btnRegistrarSeccion As System.Windows.Forms.Button
    Friend WithEvents btnReporteProfesor As System.Windows.Forms.Button
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents thorafecha As System.Windows.Forms.Timer
    Friend WithEvents btnAperturarAno As System.Windows.Forms.Button
    Friend WithEvents btnEditarMisDatos As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
