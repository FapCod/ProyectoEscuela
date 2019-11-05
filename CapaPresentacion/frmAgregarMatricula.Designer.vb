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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdniAlumno = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btneliminarMatricula = New System.Windows.Forms.Button()
        Me.btneditarMatricula = New System.Windows.Forms.Button()
        Me.btnagregarMatricula = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbannoEscolar = New System.Windows.Forms.ComboBox()
        Me.cmbcodigoAula = New System.Windows.Forms.ComboBox()
        Me.txtvacantesLibres = New System.Windows.Forms.TextBox()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(208, 72)
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
        Me.DataGridView1.Location = New System.Drawing.Point(452, 34)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(643, 329)
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 24)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "VACANTES LIBRES"
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
        Me.cmbannoEscolar.FormattingEnabled = True
        Me.cmbannoEscolar.Location = New System.Drawing.Point(212, 34)
        Me.cmbannoEscolar.Name = "cmbannoEscolar"
        Me.cmbannoEscolar.Size = New System.Drawing.Size(143, 24)
        Me.cmbannoEscolar.TabIndex = 55
        '
        'cmbcodigoAula
        '
        Me.cmbcodigoAula.FormattingEnabled = True
        Me.cmbcodigoAula.Location = New System.Drawing.Point(212, 97)
        Me.cmbcodigoAula.Name = "cmbcodigoAula"
        Me.cmbcodigoAula.Size = New System.Drawing.Size(143, 24)
        Me.cmbcodigoAula.TabIndex = 56
        '
        'txtvacantesLibres
        '
        Me.txtvacantesLibres.Location = New System.Drawing.Point(7, 173)
        Me.txtvacantesLibres.Name = "txtvacantesLibres"
        Me.txtvacantesLibres.Size = New System.Drawing.Size(184, 22)
        Me.txtvacantesLibres.TabIndex = 57
        '
        'dtFecha
        '
        Me.dtFecha.Location = New System.Drawing.Point(2, 99)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(200, 22)
        Me.dtFecha.TabIndex = 58
        '
        'frmAgregarMatricula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(1124, 391)
        Me.Controls.Add(Me.dtFecha)
        Me.Controls.Add(Me.txtvacantesLibres)
        Me.Controls.Add(Me.cmbcodigoAula)
        Me.Controls.Add(Me.cmbannoEscolar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtdniAlumno)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btneliminarMatricula)
        Me.Controls.Add(Me.btneditarMatricula)
        Me.Controls.Add(Me.btnagregarMatricula)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAgregarMatricula"
        Me.Text = "frmAgregarMatricula"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbannoEscolar As System.Windows.Forms.ComboBox
    Friend WithEvents cmbcodigoAula As System.Windows.Forms.ComboBox
    Friend WithEvents txtvacantesLibres As System.Windows.Forms.TextBox
    Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
End Class
