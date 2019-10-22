<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarAlumno
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNombreA = New System.Windows.Forms.TextBox()
        Me.txtApellidoA = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtNombreApo = New System.Windows.Forms.TextBox()
        Me.btnAgregarAlumno = New System.Windows.Forms.Button()
        Me.cmbSexoA = New System.Windows.Forms.ComboBox()
        Me.cmbGradoIn = New System.Windows.Forms.ComboBox()
        Me.rbInicial = New System.Windows.Forms.RadioButton()
        Me.rbPrimaria = New System.Windows.Forms.RadioButton()
        Me.cmbGradoPri = New System.Windows.Forms.ComboBox()
        Me.cmbSeccionPri = New System.Windows.Forms.ComboBox()
        Me.cmbSeccionIn = New System.Windows.Forms.ComboBox()
        Me.btnEditarA = New System.Windows.Forms.Button()
        Me.btnEliminarA = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnBuscarA = New System.Windows.Forms.Button()
        Me.txtBuscarA = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(109, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(109, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(109, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sexo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(109, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nivel"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(109, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Grado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(114, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Seccion"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(109, 312)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 24)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Direccion"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(109, 347)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(205, 24)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Nombre Aporderado"
        '
        'txtNombreA
        '
        Me.txtNombreA.Location = New System.Drawing.Point(254, 59)
        Me.txtNombreA.Name = "txtNombreA"
        Me.txtNombreA.Size = New System.Drawing.Size(184, 22)
        Me.txtNombreA.TabIndex = 8
        '
        'txtApellidoA
        '
        Me.txtApellidoA.Location = New System.Drawing.Point(254, 94)
        Me.txtApellidoA.Name = "txtApellidoA"
        Me.txtApellidoA.Size = New System.Drawing.Size(184, 22)
        Me.txtApellidoA.TabIndex = 9
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(254, 312)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(184, 22)
        Me.txtDireccion.TabIndex = 12
        '
        'txtNombreApo
        '
        Me.txtNombreApo.Location = New System.Drawing.Point(320, 350)
        Me.txtNombreApo.Name = "txtNombreApo"
        Me.txtNombreApo.Size = New System.Drawing.Size(184, 22)
        Me.txtNombreApo.TabIndex = 13
        '
        'btnAgregarAlumno
        '
        Me.btnAgregarAlumno.Location = New System.Drawing.Point(113, 392)
        Me.btnAgregarAlumno.Name = "btnAgregarAlumno"
        Me.btnAgregarAlumno.Size = New System.Drawing.Size(399, 57)
        Me.btnAgregarAlumno.TabIndex = 14
        Me.btnAgregarAlumno.Text = "Agregar"
        Me.btnAgregarAlumno.UseVisualStyleBackColor = True
        '
        'cmbSexoA
        '
        Me.cmbSexoA.FormattingEnabled = True
        Me.cmbSexoA.Items.AddRange(New Object() {"Hombre", "Mujer", "No especifico"})
        Me.cmbSexoA.Location = New System.Drawing.Point(254, 140)
        Me.cmbSexoA.Name = "cmbSexoA"
        Me.cmbSexoA.Size = New System.Drawing.Size(184, 24)
        Me.cmbSexoA.TabIndex = 15
        '
        'cmbGradoIn
        '
        Me.cmbGradoIn.FormattingEnabled = True
        Me.cmbGradoIn.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cmbGradoIn.Location = New System.Drawing.Point(254, 222)
        Me.cmbGradoIn.Name = "cmbGradoIn"
        Me.cmbGradoIn.Size = New System.Drawing.Size(60, 24)
        Me.cmbGradoIn.TabIndex = 16
        '
        'rbInicial
        '
        Me.rbInicial.AutoSize = True
        Me.rbInicial.Location = New System.Drawing.Point(254, 186)
        Me.rbInicial.Name = "rbInicial"
        Me.rbInicial.Size = New System.Drawing.Size(64, 21)
        Me.rbInicial.TabIndex = 17
        Me.rbInicial.TabStop = True
        Me.rbInicial.Text = "Inicial"
        Me.rbInicial.UseVisualStyleBackColor = True
        '
        'rbPrimaria
        '
        Me.rbPrimaria.AutoSize = True
        Me.rbPrimaria.Location = New System.Drawing.Point(339, 186)
        Me.rbPrimaria.Name = "rbPrimaria"
        Me.rbPrimaria.Size = New System.Drawing.Size(81, 21)
        Me.rbPrimaria.TabIndex = 18
        Me.rbPrimaria.TabStop = True
        Me.rbPrimaria.Text = "Primaria"
        Me.rbPrimaria.UseVisualStyleBackColor = True
        '
        'cmbGradoPri
        '
        Me.cmbGradoPri.FormattingEnabled = True
        Me.cmbGradoPri.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cmbGradoPri.Location = New System.Drawing.Point(339, 222)
        Me.cmbGradoPri.Name = "cmbGradoPri"
        Me.cmbGradoPri.Size = New System.Drawing.Size(60, 24)
        Me.cmbGradoPri.TabIndex = 19
        '
        'cmbSeccionPri
        '
        Me.cmbSeccionPri.FormattingEnabled = True
        Me.cmbSeccionPri.Items.AddRange(New Object() {"A", "B", "C"})
        Me.cmbSeccionPri.Location = New System.Drawing.Point(339, 260)
        Me.cmbSeccionPri.Name = "cmbSeccionPri"
        Me.cmbSeccionPri.Size = New System.Drawing.Size(60, 24)
        Me.cmbSeccionPri.TabIndex = 21
        '
        'cmbSeccionIn
        '
        Me.cmbSeccionIn.FormattingEnabled = True
        Me.cmbSeccionIn.Items.AddRange(New Object() {"A", "B", "C"})
        Me.cmbSeccionIn.Location = New System.Drawing.Point(254, 260)
        Me.cmbSeccionIn.Name = "cmbSeccionIn"
        Me.cmbSeccionIn.Size = New System.Drawing.Size(60, 24)
        Me.cmbSeccionIn.TabIndex = 20
        '
        'btnEditarA
        '
        Me.btnEditarA.Location = New System.Drawing.Point(113, 455)
        Me.btnEditarA.Name = "btnEditarA"
        Me.btnEditarA.Size = New System.Drawing.Size(201, 57)
        Me.btnEditarA.TabIndex = 22
        Me.btnEditarA.Text = "EDITAR"
        Me.btnEditarA.UseVisualStyleBackColor = True
        '
        'btnEliminarA
        '
        Me.btnEliminarA.Location = New System.Drawing.Point(331, 455)
        Me.btnEliminarA.Name = "btnEliminarA"
        Me.btnEliminarA.Size = New System.Drawing.Size(181, 57)
        Me.btnEliminarA.TabIndex = 23
        Me.btnEliminarA.Text = "ELIMINAR"
        Me.btnEliminarA.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(554, 94)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(643, 329)
        Me.DataGridView1.TabIndex = 24
        '
        'btnBuscarA
        '
        Me.btnBuscarA.Location = New System.Drawing.Point(866, 21)
        Me.btnBuscarA.Name = "btnBuscarA"
        Me.btnBuscarA.Size = New System.Drawing.Size(104, 57)
        Me.btnBuscarA.TabIndex = 25
        Me.btnBuscarA.Text = "BUSCAR"
        Me.btnBuscarA.UseVisualStyleBackColor = True
        '
        'txtBuscarA
        '
        Me.txtBuscarA.Location = New System.Drawing.Point(577, 38)
        Me.txtBuscarA.Name = "txtBuscarA"
        Me.txtBuscarA.Size = New System.Drawing.Size(283, 22)
        Me.txtBuscarA.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(573, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 24)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "id"
        '
        'frmAgregarAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1209, 567)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtBuscarA)
        Me.Controls.Add(Me.btnBuscarA)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnEliminarA)
        Me.Controls.Add(Me.btnEditarA)
        Me.Controls.Add(Me.cmbSeccionPri)
        Me.Controls.Add(Me.cmbSeccionIn)
        Me.Controls.Add(Me.cmbGradoPri)
        Me.Controls.Add(Me.rbPrimaria)
        Me.Controls.Add(Me.rbInicial)
        Me.Controls.Add(Me.cmbGradoIn)
        Me.Controls.Add(Me.cmbSexoA)
        Me.Controls.Add(Me.btnAgregarAlumno)
        Me.Controls.Add(Me.txtNombreApo)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtApellidoA)
        Me.Controls.Add(Me.txtNombreA)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAgregarAlumno"
        Me.Text = "frmAgregarAlumno"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNombreA As System.Windows.Forms.TextBox
    Friend WithEvents txtApellidoA As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreApo As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregarAlumno As System.Windows.Forms.Button
    Friend WithEvents cmbSexoA As System.Windows.Forms.ComboBox
    Friend WithEvents cmbGradoIn As System.Windows.Forms.ComboBox
    Friend WithEvents rbInicial As System.Windows.Forms.RadioButton
    Friend WithEvents rbPrimaria As System.Windows.Forms.RadioButton
    Friend WithEvents cmbGradoPri As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSeccionPri As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSeccionIn As System.Windows.Forms.ComboBox
    Friend WithEvents btnEditarA As System.Windows.Forms.Button
    Friend WithEvents btnEliminarA As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscarA As System.Windows.Forms.Button
    Friend WithEvents txtBuscarA As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
