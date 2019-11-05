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
        Me.txtnombreAlumno = New System.Windows.Forms.TextBox()
        Me.txtapellidoAlumno = New System.Windows.Forms.TextBox()
        Me.txtdireccionAlumno = New System.Windows.Forms.TextBox()
        Me.txtnombreApoderadoAlumno = New System.Windows.Forms.TextBox()
        Me.btnagregarAlumno = New System.Windows.Forms.Button()
        Me.cmbsexoAlumno = New System.Windows.Forms.ComboBox()
        Me.cmbgradoInicial = New System.Windows.Forms.ComboBox()
        Me.rbinicial = New System.Windows.Forms.RadioButton()
        Me.rbprimaria = New System.Windows.Forms.RadioButton()
        Me.cmbgradoPrimaria = New System.Windows.Forms.ComboBox()
        Me.cmbseccionPrimaria = New System.Windows.Forms.ComboBox()
        Me.cmbseccionInicial = New System.Windows.Forms.ComboBox()
        Me.btneditarAlumno = New System.Windows.Forms.Button()
        Me.btneliminarAlumno = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnbuscarAlumno = New System.Windows.Forms.Button()
        Me.txtidAlumno = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
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
        Me.Label2.ForeColor = System.Drawing.Color.White
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
        Me.Label3.ForeColor = System.Drawing.Color.White
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
        Me.Label4.ForeColor = System.Drawing.Color.White
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
        Me.Label5.ForeColor = System.Drawing.Color.White
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
        Me.Label6.ForeColor = System.Drawing.Color.White
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
        Me.Label7.ForeColor = System.Drawing.Color.White
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
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(109, 347)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(197, 24)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Nombre Apoderado"
        '
        'txtnombreAlumno
        '
        Me.txtnombreAlumno.Location = New System.Drawing.Point(254, 59)
        Me.txtnombreAlumno.Name = "txtnombreAlumno"
        Me.txtnombreAlumno.Size = New System.Drawing.Size(184, 22)
        Me.txtnombreAlumno.TabIndex = 8
        '
        'txtapellidoAlumno
        '
        Me.txtapellidoAlumno.Location = New System.Drawing.Point(254, 94)
        Me.txtapellidoAlumno.Name = "txtapellidoAlumno"
        Me.txtapellidoAlumno.Size = New System.Drawing.Size(184, 22)
        Me.txtapellidoAlumno.TabIndex = 9
        '
        'txtdireccionAlumno
        '
        Me.txtdireccionAlumno.Location = New System.Drawing.Point(254, 312)
        Me.txtdireccionAlumno.Name = "txtdireccionAlumno"
        Me.txtdireccionAlumno.Size = New System.Drawing.Size(184, 22)
        Me.txtdireccionAlumno.TabIndex = 12
        '
        'txtnombreApoderadoAlumno
        '
        Me.txtnombreApoderadoAlumno.Location = New System.Drawing.Point(331, 349)
        Me.txtnombreApoderadoAlumno.Name = "txtnombreApoderadoAlumno"
        Me.txtnombreApoderadoAlumno.Size = New System.Drawing.Size(184, 22)
        Me.txtnombreApoderadoAlumno.TabIndex = 13
        '
        'btnagregarAlumno
        '
        Me.btnagregarAlumno.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnagregarAlumno.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregarAlumno.ForeColor = System.Drawing.Color.White
        Me.btnagregarAlumno.Location = New System.Drawing.Point(113, 392)
        Me.btnagregarAlumno.Name = "btnagregarAlumno"
        Me.btnagregarAlumno.Size = New System.Drawing.Size(399, 57)
        Me.btnagregarAlumno.TabIndex = 14
        Me.btnagregarAlumno.Text = "Agregar"
        Me.btnagregarAlumno.UseVisualStyleBackColor = False
        '
        'cmbsexoAlumno
        '
        Me.cmbsexoAlumno.FormattingEnabled = True
        Me.cmbsexoAlumno.Items.AddRange(New Object() {"Hombre", "Mujer", "No especifico"})
        Me.cmbsexoAlumno.Location = New System.Drawing.Point(254, 140)
        Me.cmbsexoAlumno.Name = "cmbsexoAlumno"
        Me.cmbsexoAlumno.Size = New System.Drawing.Size(184, 24)
        Me.cmbsexoAlumno.TabIndex = 15
        '
        'cmbgradoInicial
        '
        Me.cmbgradoInicial.FormattingEnabled = True
        Me.cmbgradoInicial.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cmbgradoInicial.Location = New System.Drawing.Point(254, 222)
        Me.cmbgradoInicial.Name = "cmbgradoInicial"
        Me.cmbgradoInicial.Size = New System.Drawing.Size(60, 24)
        Me.cmbgradoInicial.TabIndex = 16
        '
        'rbinicial
        '
        Me.rbinicial.AutoSize = True
        Me.rbinicial.Font = New System.Drawing.Font("Gadugi", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbinicial.ForeColor = System.Drawing.Color.White
        Me.rbinicial.Location = New System.Drawing.Point(254, 186)
        Me.rbinicial.Name = "rbinicial"
        Me.rbinicial.Size = New System.Drawing.Size(77, 24)
        Me.rbinicial.TabIndex = 17
        Me.rbinicial.TabStop = True
        Me.rbinicial.Text = "Inicial"
        Me.rbinicial.UseVisualStyleBackColor = True
        '
        'rbprimaria
        '
        Me.rbprimaria.AutoSize = True
        Me.rbprimaria.Font = New System.Drawing.Font("Gadugi", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbprimaria.ForeColor = System.Drawing.Color.White
        Me.rbprimaria.Location = New System.Drawing.Point(339, 186)
        Me.rbprimaria.Name = "rbprimaria"
        Me.rbprimaria.Size = New System.Drawing.Size(98, 24)
        Me.rbprimaria.TabIndex = 18
        Me.rbprimaria.TabStop = True
        Me.rbprimaria.Text = "Primaria"
        Me.rbprimaria.UseVisualStyleBackColor = True
        '
        'cmbgradoPrimaria
        '
        Me.cmbgradoPrimaria.FormattingEnabled = True
        Me.cmbgradoPrimaria.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cmbgradoPrimaria.Location = New System.Drawing.Point(339, 222)
        Me.cmbgradoPrimaria.Name = "cmbgradoPrimaria"
        Me.cmbgradoPrimaria.Size = New System.Drawing.Size(60, 24)
        Me.cmbgradoPrimaria.TabIndex = 19
        '
        'cmbseccionPrimaria
        '
        Me.cmbseccionPrimaria.FormattingEnabled = True
        Me.cmbseccionPrimaria.Items.AddRange(New Object() {"A", "B", "C"})
        Me.cmbseccionPrimaria.Location = New System.Drawing.Point(339, 260)
        Me.cmbseccionPrimaria.Name = "cmbseccionPrimaria"
        Me.cmbseccionPrimaria.Size = New System.Drawing.Size(60, 24)
        Me.cmbseccionPrimaria.TabIndex = 21
        '
        'cmbseccionInicial
        '
        Me.cmbseccionInicial.FormattingEnabled = True
        Me.cmbseccionInicial.Items.AddRange(New Object() {"A", "B", "C"})
        Me.cmbseccionInicial.Location = New System.Drawing.Point(254, 260)
        Me.cmbseccionInicial.Name = "cmbseccionInicial"
        Me.cmbseccionInicial.Size = New System.Drawing.Size(60, 24)
        Me.cmbseccionInicial.TabIndex = 20
        '
        'btneditarAlumno
        '
        Me.btneditarAlumno.BackColor = System.Drawing.Color.DodgerBlue
        Me.btneditarAlumno.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditarAlumno.ForeColor = System.Drawing.Color.White
        Me.btneditarAlumno.Location = New System.Drawing.Point(113, 455)
        Me.btneditarAlumno.Name = "btneditarAlumno"
        Me.btneditarAlumno.Size = New System.Drawing.Size(201, 57)
        Me.btneditarAlumno.TabIndex = 22
        Me.btneditarAlumno.Text = "EDITAR"
        Me.btneditarAlumno.UseVisualStyleBackColor = False
        '
        'btneliminarAlumno
        '
        Me.btneliminarAlumno.BackColor = System.Drawing.Color.DodgerBlue
        Me.btneliminarAlumno.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminarAlumno.ForeColor = System.Drawing.Color.White
        Me.btneliminarAlumno.Location = New System.Drawing.Point(331, 455)
        Me.btneliminarAlumno.Name = "btneliminarAlumno"
        Me.btneliminarAlumno.Size = New System.Drawing.Size(181, 57)
        Me.btneliminarAlumno.TabIndex = 23
        Me.btneliminarAlumno.Text = "ELIMINAR"
        Me.btneliminarAlumno.UseVisualStyleBackColor = False
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
        'btnbuscarAlumno
        '
        Me.btnbuscarAlumno.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnbuscarAlumno.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscarAlumno.ForeColor = System.Drawing.Color.White
        Me.btnbuscarAlumno.Location = New System.Drawing.Point(866, 21)
        Me.btnbuscarAlumno.Name = "btnbuscarAlumno"
        Me.btnbuscarAlumno.Size = New System.Drawing.Size(104, 57)
        Me.btnbuscarAlumno.TabIndex = 25
        Me.btnbuscarAlumno.Text = "BUSCAR"
        Me.btnbuscarAlumno.UseVisualStyleBackColor = False
        '
        'txtidAlumno
        '
        Me.txtidAlumno.Location = New System.Drawing.Point(577, 38)
        Me.txtidAlumno.Name = "txtidAlumno"
        Me.txtidAlumno.Size = New System.Drawing.Size(283, 22)
        Me.txtidAlumno.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
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
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(1209, 567)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtidAlumno)
        Me.Controls.Add(Me.btnbuscarAlumno)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btneliminarAlumno)
        Me.Controls.Add(Me.btneditarAlumno)
        Me.Controls.Add(Me.cmbseccionPrimaria)
        Me.Controls.Add(Me.cmbseccionInicial)
        Me.Controls.Add(Me.cmbgradoPrimaria)
        Me.Controls.Add(Me.rbprimaria)
        Me.Controls.Add(Me.rbinicial)
        Me.Controls.Add(Me.cmbgradoInicial)
        Me.Controls.Add(Me.cmbsexoAlumno)
        Me.Controls.Add(Me.btnagregarAlumno)
        Me.Controls.Add(Me.txtnombreApoderadoAlumno)
        Me.Controls.Add(Me.txtdireccionAlumno)
        Me.Controls.Add(Me.txtapellidoAlumno)
        Me.Controls.Add(Me.txtnombreAlumno)
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
    Friend WithEvents txtnombreAlumno As System.Windows.Forms.TextBox
    Friend WithEvents txtapellidoAlumno As System.Windows.Forms.TextBox
    Friend WithEvents txtdireccionAlumno As System.Windows.Forms.TextBox
    Friend WithEvents txtnombreApoderadoAlumno As System.Windows.Forms.TextBox
    Friend WithEvents btnagregarAlumno As System.Windows.Forms.Button
    Friend WithEvents cmbsexoAlumno As System.Windows.Forms.ComboBox
    Friend WithEvents cmbgradoInicial As System.Windows.Forms.ComboBox
    Friend WithEvents rbinicial As System.Windows.Forms.RadioButton
    Friend WithEvents rbprimaria As System.Windows.Forms.RadioButton
    Friend WithEvents cmbgradoPrimaria As System.Windows.Forms.ComboBox
    Friend WithEvents cmbseccionPrimaria As System.Windows.Forms.ComboBox
    Friend WithEvents cmbseccionInicial As System.Windows.Forms.ComboBox
    Friend WithEvents btneditarAlumno As System.Windows.Forms.Button
    Friend WithEvents btneliminarAlumno As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnbuscarAlumno As System.Windows.Forms.Button
    Friend WithEvents txtidAlumno As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
