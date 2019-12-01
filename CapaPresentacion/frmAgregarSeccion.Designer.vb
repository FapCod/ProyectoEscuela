<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarSeccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarSeccion))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbNivel = New System.Windows.Forms.ComboBox()
        Me.cmbGrado = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSeccion = New System.Windows.Forms.TextBox()
        Me.cmbProfesor = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNumeroVacantes = New System.Windows.Forms.TextBox()
        Me.txtAnoEscolar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btneliminarSeccion = New System.Windows.Forms.Button()
        Me.btneditarSeccion = New System.Windows.Forms.Button()
        Me.btnagregarSeccion = New System.Windows.Forms.Button()
        Me.txtCodigoSeccion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(75, 70)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 24)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "Nivel"
        '
        'cmbNivel
        '
        Me.cmbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNivel.FormattingEnabled = True
        Me.cmbNivel.Items.AddRange(New Object() {"Inicial", "Primaria"})
        Me.cmbNivel.Location = New System.Drawing.Point(79, 97)
        Me.cmbNivel.Name = "cmbNivel"
        Me.cmbNivel.Size = New System.Drawing.Size(143, 24)
        Me.cmbNivel.TabIndex = 56
        '
        'cmbGrado
        '
        Me.cmbGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGrado.FormattingEnabled = True
        Me.cmbGrado.Location = New System.Drawing.Point(79, 151)
        Me.cmbGrado.Name = "cmbGrado"
        Me.cmbGrado.Size = New System.Drawing.Size(143, 24)
        Me.cmbGrado.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(75, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 24)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Grado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(235, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 24)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Seccion"
        '
        'txtSeccion
        '
        Me.txtSeccion.Location = New System.Drawing.Point(239, 153)
        Me.txtSeccion.Name = "txtSeccion"
        Me.txtSeccion.Size = New System.Drawing.Size(78, 22)
        Me.txtSeccion.TabIndex = 60
        '
        'cmbProfesor
        '
        Me.cmbProfesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProfesor.FormattingEnabled = True
        Me.cmbProfesor.Location = New System.Drawing.Point(79, 220)
        Me.cmbProfesor.Name = "cmbProfesor"
        Me.cmbProfesor.Size = New System.Drawing.Size(143, 24)
        Me.cmbProfesor.TabIndex = 62
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(75, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 24)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Profesor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(83, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 24)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "N. Vacantes"
        '
        'txtNumeroVacantes
        '
        Me.txtNumeroVacantes.Location = New System.Drawing.Point(87, 287)
        Me.txtNumeroVacantes.Name = "txtNumeroVacantes"
        Me.txtNumeroVacantes.Size = New System.Drawing.Size(78, 22)
        Me.txtNumeroVacantes.TabIndex = 60
        '
        'txtAnoEscolar
        '
        Me.txtAnoEscolar.Location = New System.Drawing.Point(239, 287)
        Me.txtAnoEscolar.Name = "txtAnoEscolar"
        Me.txtAnoEscolar.Size = New System.Drawing.Size(78, 22)
        Me.txtAnoEscolar.TabIndex = 64
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(235, 258)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 24)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Año Escolar"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(456, 61)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(661, 305)
        Me.DataGridView1.TabIndex = 65
        '
        'btneliminarSeccion
        '
        Me.btneliminarSeccion.BackColor = System.Drawing.Color.DodgerBlue
        Me.btneliminarSeccion.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminarSeccion.ForeColor = System.Drawing.Color.White
        Me.btneliminarSeccion.Location = New System.Drawing.Point(263, 437)
        Me.btneliminarSeccion.Name = "btneliminarSeccion"
        Me.btneliminarSeccion.Size = New System.Drawing.Size(181, 57)
        Me.btneliminarSeccion.TabIndex = 68
        Me.btneliminarSeccion.Text = "ELIMINAR"
        Me.btneliminarSeccion.UseVisualStyleBackColor = False
        '
        'btneditarSeccion
        '
        Me.btneditarSeccion.BackColor = System.Drawing.Color.DodgerBlue
        Me.btneditarSeccion.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditarSeccion.ForeColor = System.Drawing.Color.White
        Me.btneditarSeccion.Location = New System.Drawing.Point(45, 437)
        Me.btneditarSeccion.Name = "btneditarSeccion"
        Me.btneditarSeccion.Size = New System.Drawing.Size(201, 57)
        Me.btneditarSeccion.TabIndex = 67
        Me.btneditarSeccion.Text = "EDITAR"
        Me.btneditarSeccion.UseVisualStyleBackColor = False
        '
        'btnagregarSeccion
        '
        Me.btnagregarSeccion.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnagregarSeccion.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregarSeccion.ForeColor = System.Drawing.Color.White
        Me.btnagregarSeccion.Location = New System.Drawing.Point(45, 374)
        Me.btnagregarSeccion.Name = "btnagregarSeccion"
        Me.btnagregarSeccion.Size = New System.Drawing.Size(399, 57)
        Me.btnagregarSeccion.TabIndex = 66
        Me.btnagregarSeccion.Text = "Agregar"
        Me.btnagregarSeccion.UseVisualStyleBackColor = False
        '
        'txtCodigoSeccion
        '
        Me.txtCodigoSeccion.Location = New System.Drawing.Point(79, 38)
        Me.txtCodigoSeccion.Name = "txtCodigoSeccion"
        Me.txtCodigoSeccion.Size = New System.Drawing.Size(143, 22)
        Me.txtCodigoSeccion.TabIndex = 70
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(75, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 24)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Codigo"
        '
        'frmAgregarSeccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(1129, 512)
        Me.Controls.Add(Me.txtCodigoSeccion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btneliminarSeccion)
        Me.Controls.Add(Me.btneditarSeccion)
        Me.Controls.Add(Me.btnagregarSeccion)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtAnoEscolar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbProfesor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNumeroVacantes)
        Me.Controls.Add(Me.txtSeccion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbGrado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbNivel)
        Me.Controls.Add(Me.Label10)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAgregarSeccion"
        Me.Text = "frmAgregarSeccion"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbNivel As System.Windows.Forms.ComboBox
    Friend WithEvents cmbGrado As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSeccion As System.Windows.Forms.TextBox
    Friend WithEvents cmbProfesor As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNumeroVacantes As System.Windows.Forms.TextBox
    Friend WithEvents txtAnoEscolar As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btneliminarSeccion As System.Windows.Forms.Button
    Friend WithEvents btneditarSeccion As System.Windows.Forms.Button
    Friend WithEvents btnagregarSeccion As System.Windows.Forms.Button
    Friend WithEvents txtCodigoSeccion As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
