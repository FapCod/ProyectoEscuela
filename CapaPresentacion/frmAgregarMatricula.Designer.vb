<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarMatricula
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarMatricula))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdniAlumno = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btneliminarMatricula = New System.Windows.Forms.Button()
        Me.btneditarMatricula = New System.Windows.Forms.Button()
        Me.btnagregarMatricula = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbannoEscolar = New System.Windows.Forms.ComboBox()
        Me.cmbcodGrado = New System.Windows.Forms.ComboBox()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbcodseccion = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rbtinicial = New System.Windows.Forms.RadioButton()
        Me.rbtPrimaria = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvprimaria = New System.Windows.Forms.DataGridView()
        Me.dgvinicial = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtDniBuscar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnListar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvprimaria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvinicial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(2, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 24)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "GRADO"
        '
        'txtdniAlumno
        '
        Me.txtdniAlumno.Location = New System.Drawing.Point(2, 36)
        Me.txtdniAlumno.Name = "txtdniAlumno"
        Me.txtdniAlumno.Size = New System.Drawing.Size(184, 22)
        Me.txtdniAlumno.TabIndex = 52
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(2, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(141, 24)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "DNI ALUMNO"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(469, 110)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(643, 176)
        Me.DataGridView1.TabIndex = 47
        '
        'btneliminarMatricula
        '
        Me.btneliminarMatricula.BackColor = System.Drawing.Color.DodgerBlue
        Me.btneliminarMatricula.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminarMatricula.ForeColor = System.Drawing.Color.White
        Me.btneliminarMatricula.Location = New System.Drawing.Point(242, 266)
        Me.btneliminarMatricula.Name = "btneliminarMatricula"
        Me.btneliminarMatricula.Size = New System.Drawing.Size(181, 57)
        Me.btneliminarMatricula.TabIndex = 46
        Me.btneliminarMatricula.Text = "ELIMINAR"
        Me.btneliminarMatricula.UseVisualStyleBackColor = False
        '
        'btneditarMatricula
        '
        Me.btneditarMatricula.BackColor = System.Drawing.Color.DodgerBlue
        Me.btneditarMatricula.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditarMatricula.ForeColor = System.Drawing.Color.White
        Me.btneditarMatricula.Location = New System.Drawing.Point(24, 266)
        Me.btneditarMatricula.Name = "btneditarMatricula"
        Me.btneditarMatricula.Size = New System.Drawing.Size(201, 57)
        Me.btneditarMatricula.TabIndex = 45
        Me.btneditarMatricula.Text = "EDITAR"
        Me.btneditarMatricula.UseVisualStyleBackColor = False
        '
        'btnagregarMatricula
        '
        Me.btnagregarMatricula.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnagregarMatricula.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregarMatricula.ForeColor = System.Drawing.Color.White
        Me.btnagregarMatricula.Location = New System.Drawing.Point(24, 203)
        Me.btnagregarMatricula.Name = "btnagregarMatricula"
        Me.btnagregarMatricula.Size = New System.Drawing.Size(399, 57)
        Me.btnagregarMatricula.TabIndex = 43
        Me.btnagregarMatricula.Text = "Agregar"
        Me.btnagregarMatricula.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(2, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 24)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "FECHA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(208, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 24)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "AÑO ESCOLAR"
        '
        'cmbannoEscolar
        '
        Me.cmbannoEscolar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbannoEscolar.FormattingEnabled = True
        Me.cmbannoEscolar.Location = New System.Drawing.Point(212, 34)
        Me.cmbannoEscolar.Name = "cmbannoEscolar"
        Me.cmbannoEscolar.Size = New System.Drawing.Size(143, 24)
        Me.cmbannoEscolar.TabIndex = 55
        '
        'cmbcodGrado
        '
        Me.cmbcodGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcodGrado.FormattingEnabled = True
        Me.cmbcodGrado.Location = New System.Drawing.Point(6, 160)
        Me.cmbcodGrado.Name = "cmbcodGrado"
        Me.cmbcodGrado.Size = New System.Drawing.Size(143, 24)
        Me.cmbcodGrado.TabIndex = 56
        '
        'dtFecha
        '
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha.Location = New System.Drawing.Point(2, 99)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(125, 22)
        Me.dtFecha.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(218, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 24)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "SECCION"
        '
        'cmbcodseccion
        '
        Me.cmbcodseccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcodseccion.FormattingEnabled = True
        Me.cmbcodseccion.Location = New System.Drawing.Point(212, 160)
        Me.cmbcodseccion.Name = "cmbcodseccion"
        Me.cmbcodseccion.Size = New System.Drawing.Size(143, 24)
        Me.cmbcodseccion.TabIndex = 60
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(208, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 24)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "NIVEL"
        '
        'rbtinicial
        '
        Me.rbtinicial.AutoSize = True
        Me.rbtinicial.Location = New System.Drawing.Point(222, 99)
        Me.rbtinicial.Name = "rbtinicial"
        Me.rbtinicial.Size = New System.Drawing.Size(64, 21)
        Me.rbtinicial.TabIndex = 63
        Me.rbtinicial.TabStop = True
        Me.rbtinicial.Text = "Inicial"
        Me.rbtinicial.UseVisualStyleBackColor = True
        '
        'rbtPrimaria
        '
        Me.rbtPrimaria.AutoSize = True
        Me.rbtPrimaria.Location = New System.Drawing.Point(301, 99)
        Me.rbtPrimaria.Name = "rbtPrimaria"
        Me.rbtPrimaria.Size = New System.Drawing.Size(81, 21)
        Me.rbtPrimaria.TabIndex = 64
        Me.rbtPrimaria.TabStop = True
        Me.rbtPrimaria.Text = "Primaria"
        Me.rbtPrimaria.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(453, 309)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(208, 24)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "CURSOS ASIGNADOS"
        '
        'dgvprimaria
        '
        Me.dgvprimaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvprimaria.Location = New System.Drawing.Point(457, 336)
        Me.dgvprimaria.Name = "dgvprimaria"
        Me.dgvprimaria.RowTemplate.Height = 24
        Me.dgvprimaria.Size = New System.Drawing.Size(638, 119)
        Me.dgvprimaria.TabIndex = 66
        '
        'dgvinicial
        '
        Me.dgvinicial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvinicial.Location = New System.Drawing.Point(457, 336)
        Me.dgvinicial.Name = "dgvinicial"
        Me.dgvinicial.RowTemplate.Height = 24
        Me.dgvinicial.Size = New System.Drawing.Size(638, 119)
        Me.dgvinicial.TabIndex = 67
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(2, 60)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView2.TabIndex = 68
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnBuscar.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(695, 36)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(181, 57)
        Me.btnBuscar.TabIndex = 69
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtDniBuscar
        '
        Me.txtDniBuscar.Location = New System.Drawing.Point(491, 60)
        Me.txtDniBuscar.Name = "txtDniBuscar"
        Me.txtDniBuscar.Size = New System.Drawing.Size(184, 22)
        Me.txtDniBuscar.TabIndex = 70
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(487, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 24)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "DNI"
        '
        'btnListar
        '
        Me.btnListar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnListar.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListar.ForeColor = System.Drawing.Color.White
        Me.btnListar.Location = New System.Drawing.Point(892, 36)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(181, 57)
        Me.btnListar.TabIndex = 72
        Me.btnListar.Text = "Listar"
        Me.btnListar.UseVisualStyleBackColor = False
        '
        'frmAgregarMatricula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(1124, 468)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDniBuscar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.dgvinicial)
        Me.Controls.Add(Me.dgvprimaria)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.rbtPrimaria)
        Me.Controls.Add(Me.rbtinicial)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbcodseccion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtFecha)
        Me.Controls.Add(Me.cmbcodGrado)
        Me.Controls.Add(Me.cmbannoEscolar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtdniAlumno)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btneliminarMatricula)
        Me.Controls.Add(Me.btneditarMatricula)
        Me.Controls.Add(Me.btnagregarMatricula)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAgregarMatricula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAgregarMatricula"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvprimaria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvinicial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtdniAlumno As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btneliminarMatricula As System.Windows.Forms.Button
    Friend WithEvents btneditarMatricula As System.Windows.Forms.Button
    Friend WithEvents btnagregarMatricula As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbannoEscolar As System.Windows.Forms.ComboBox
    Friend WithEvents cmbcodGrado As System.Windows.Forms.ComboBox
    Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbcodseccion As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rbtinicial As System.Windows.Forms.RadioButton
    Friend WithEvents rbtPrimaria As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgvprimaria As System.Windows.Forms.DataGridView
    Friend WithEvents dgvinicial As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtDniBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnListar As System.Windows.Forms.Button
End Class
