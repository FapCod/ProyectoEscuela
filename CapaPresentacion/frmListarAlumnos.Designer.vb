<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListarAlumnos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListarAlumnos))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.rbtPrimaria = New System.Windows.Forms.RadioButton()
        Me.rbtinicial = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbcodseccion = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbcodGrado = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbannoEscolar = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(222, 183)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(670, 361)
        Me.DataGridView1.TabIndex = 24
        '
        'btnMostrar
        '
        Me.btnMostrar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnMostrar.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrar.ForeColor = System.Drawing.Color.White
        Me.btnMostrar.Location = New System.Drawing.Point(895, 103)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(201, 57)
        Me.btnMostrar.TabIndex = 35
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = False
        '
        'btnListar
        '
        Me.btnListar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnListar.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListar.ForeColor = System.Drawing.Color.White
        Me.btnListar.Location = New System.Drawing.Point(922, 487)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(201, 57)
        Me.btnListar.TabIndex = 36
        Me.btnListar.Text = "Listar"
        Me.btnListar.UseVisualStyleBackColor = False
        '
        'rbtPrimaria
        '
        Me.rbtPrimaria.AutoSize = True
        Me.rbtPrimaria.Location = New System.Drawing.Point(406, 130)
        Me.rbtPrimaria.Name = "rbtPrimaria"
        Me.rbtPrimaria.Size = New System.Drawing.Size(81, 21)
        Me.rbtPrimaria.TabIndex = 71
        Me.rbtPrimaria.TabStop = True
        Me.rbtPrimaria.Text = "Primaria"
        Me.rbtPrimaria.UseVisualStyleBackColor = True
        '
        'rbtinicial
        '
        Me.rbtinicial.AutoSize = True
        Me.rbtinicial.Location = New System.Drawing.Point(327, 130)
        Me.rbtinicial.Name = "rbtinicial"
        Me.rbtinicial.Size = New System.Drawing.Size(64, 21)
        Me.rbtinicial.TabIndex = 70
        Me.rbtinicial.TabStop = True
        Me.rbtinicial.Text = "Inicial"
        Me.rbtinicial.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(360, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 24)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "NIVEL"
        '
        'cmbcodseccion
        '
        Me.cmbcodseccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcodseccion.FormattingEnabled = True
        Me.cmbcodseccion.Location = New System.Drawing.Point(693, 130)
        Me.cmbcodseccion.Name = "cmbcodseccion"
        Me.cmbcodseccion.Size = New System.Drawing.Size(143, 24)
        Me.cmbcodseccion.TabIndex = 68
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(699, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 24)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "SECCION"
        '
        'cmbcodGrado
        '
        Me.cmbcodGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcodGrado.FormattingEnabled = True
        Me.cmbcodGrado.Location = New System.Drawing.Point(522, 130)
        Me.cmbcodGrado.Name = "cmbcodGrado"
        Me.cmbcodGrado.Size = New System.Drawing.Size(143, 24)
        Me.cmbcodGrado.TabIndex = 66
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(518, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 24)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "GRADO"
        '
        'cmbannoEscolar
        '
        Me.cmbannoEscolar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbannoEscolar.FormattingEnabled = True
        Me.cmbannoEscolar.Location = New System.Drawing.Point(327, 60)
        Me.cmbannoEscolar.Name = "cmbannoEscolar"
        Me.cmbannoEscolar.Size = New System.Drawing.Size(143, 24)
        Me.cmbannoEscolar.TabIndex = 73
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(323, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 24)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "AÑO ESCOLAR"
        '
        'frmListarAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(1135, 644)
        Me.Controls.Add(Me.cmbannoEscolar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rbtPrimaria)
        Me.Controls.Add(Me.rbtinicial)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbcodseccion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbcodGrado)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.DataGridView1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmListarAlumnos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmListarAlumnos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnMostrar As System.Windows.Forms.Button
    Friend WithEvents btnListar As System.Windows.Forms.Button
    Friend WithEvents rbtPrimaria As System.Windows.Forms.RadioButton
    Friend WithEvents rbtinicial As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbcodseccion As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbcodGrado As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbannoEscolar As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
