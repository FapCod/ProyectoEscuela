<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarNota
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
        Me.cmbnota = New System.Windows.Forms.ComboBox()
        Me.cmbtrimestre = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdniAlumno = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btneliminarNota = New System.Windows.Forms.Button()
        Me.btneditarNota = New System.Windows.Forms.Button()
        Me.btnagregarNota = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbcodigocurso = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbCompetencia = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbnota
        '
        Me.cmbnota.FormattingEnabled = True
        Me.cmbnota.Items.AddRange(New Object() {"A", "B", "C"})
        Me.cmbnota.Location = New System.Drawing.Point(51, 217)
        Me.cmbnota.Name = "cmbnota"
        Me.cmbnota.Size = New System.Drawing.Size(143, 24)
        Me.cmbnota.TabIndex = 70
        '
        'cmbtrimestre
        '
        Me.cmbtrimestre.FormattingEnabled = True
        Me.cmbtrimestre.Location = New System.Drawing.Point(257, 91)
        Me.cmbtrimestre.Name = "cmbtrimestre"
        Me.cmbtrimestre.Size = New System.Drawing.Size(143, 24)
        Me.cmbtrimestre.TabIndex = 69
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(47, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 24)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "NOTA"
        '
        'txtdniAlumno
        '
        Me.txtdniAlumno.Location = New System.Drawing.Point(47, 93)
        Me.txtdniAlumno.Name = "txtdniAlumno"
        Me.txtdniAlumno.Size = New System.Drawing.Size(184, 22)
        Me.txtdniAlumno.TabIndex = 67
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(47, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(141, 24)
        Me.Label10.TabIndex = 66
        Me.Label10.Text = "DNI ALUMNO"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(200, 202)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(716, 329)
        Me.DataGridView1.TabIndex = 65
        '
        'btneliminarNota
        '
        Me.btneliminarNota.BackColor = System.Drawing.Color.DodgerBlue
        Me.btneliminarNota.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminarNota.ForeColor = System.Drawing.Color.White
        Me.btneliminarNota.Location = New System.Drawing.Point(821, 135)
        Me.btneliminarNota.Name = "btneliminarNota"
        Me.btneliminarNota.Size = New System.Drawing.Size(181, 57)
        Me.btneliminarNota.TabIndex = 64
        Me.btneliminarNota.Text = "ELIMINAR"
        Me.btneliminarNota.UseVisualStyleBackColor = False
        '
        'btneditarNota
        '
        Me.btneditarNota.BackColor = System.Drawing.Color.DodgerBlue
        Me.btneditarNota.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditarNota.ForeColor = System.Drawing.Color.White
        Me.btneditarNota.Location = New System.Drawing.Point(603, 135)
        Me.btneditarNota.Name = "btneditarNota"
        Me.btneditarNota.Size = New System.Drawing.Size(201, 57)
        Me.btneditarNota.TabIndex = 63
        Me.btneditarNota.Text = "EDITAR"
        Me.btneditarNota.UseVisualStyleBackColor = False
        '
        'btnagregarNota
        '
        Me.btnagregarNota.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnagregarNota.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregarNota.ForeColor = System.Drawing.Color.White
        Me.btnagregarNota.Location = New System.Drawing.Point(603, 72)
        Me.btnagregarNota.Name = "btnagregarNota"
        Me.btnagregarNota.Size = New System.Drawing.Size(399, 57)
        Me.btnagregarNota.TabIndex = 62
        Me.btnagregarNota.Text = "Agregar"
        Me.btnagregarNota.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(47, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 24)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "COMPETENCIA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(253, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 24)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "TRIMESTRE"
        '
        'cmbcodigocurso
        '
        Me.cmbcodigocurso.FormattingEnabled = True
        Me.cmbcodigocurso.Location = New System.Drawing.Point(425, 91)
        Me.cmbcodigocurso.Name = "cmbcodigocurso"
        Me.cmbcodigocurso.Size = New System.Drawing.Size(143, 24)
        Me.cmbcodigocurso.TabIndex = 74
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(421, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 24)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "CURSO"
        '
        'cmbCompetencia
        '
        Me.cmbCompetencia.FormattingEnabled = True
        Me.cmbCompetencia.Items.AddRange(New Object() {"Exposicion", "Trabajos", "Examen"})
        Me.cmbCompetencia.Location = New System.Drawing.Point(51, 156)
        Me.cmbCompetencia.Name = "cmbCompetencia"
        Me.cmbCompetencia.Size = New System.Drawing.Size(180, 24)
        Me.cmbCompetencia.TabIndex = 75
        '
        'frmAgregarNota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(1187, 661)
        Me.Controls.Add(Me.cmbCompetencia)
        Me.Controls.Add(Me.cmbcodigocurso)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbnota)
        Me.Controls.Add(Me.cmbtrimestre)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtdniAlumno)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btneliminarNota)
        Me.Controls.Add(Me.btneditarNota)
        Me.Controls.Add(Me.btnagregarNota)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAgregarNota"
        Me.Text = "frmAgregarNota"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbnota As System.Windows.Forms.ComboBox
    Friend WithEvents cmbtrimestre As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtdniAlumno As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btneliminarNota As System.Windows.Forms.Button
    Friend WithEvents btneditarNota As System.Windows.Forms.Button
    Friend WithEvents btnagregarNota As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbcodigocurso As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbCompetencia As System.Windows.Forms.ComboBox
End Class
