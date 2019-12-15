<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmagregarSeccion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmagregarSeccion))
        Me.txtvacantes = New System.Windows.Forms.TextBox()
        Me.label = New System.Windows.Forms.Label()
        Me.txtSeccion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbGrado = New System.Windows.Forms.ComboBox()
        Me.cmbProfesor = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rbtinicial = New System.Windows.Forms.RadioButton()
        Me.rbtprimaria = New System.Windows.Forms.RadioButton()
        Me.dgvSeccion = New System.Windows.Forms.DataGridView()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.cmbannoEscolar = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgvSeccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtvacantes
        '
        Me.txtvacantes.Location = New System.Drawing.Point(251, 314)
        Me.txtvacantes.Name = "txtvacantes"
        Me.txtvacantes.Size = New System.Drawing.Size(184, 22)
        Me.txtvacantes.TabIndex = 39
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.ForeColor = System.Drawing.Color.White
        Me.label.Location = New System.Drawing.Point(67, 56)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(121, 24)
        Me.label.TabIndex = 38
        Me.label.Text = "Año Escolar"
        '
        'txtSeccion
        '
        Me.txtSeccion.Location = New System.Drawing.Point(251, 107)
        Me.txtSeccion.Name = "txtSeccion"
        Me.txtSeccion.Size = New System.Drawing.Size(184, 22)
        Me.txtSeccion.TabIndex = 37
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(67, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(165, 24)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Nombre Seccion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(67, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 24)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Profesor"
        '
        'cmbGrado
        '
        Me.cmbGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGrado.FormattingEnabled = True
        Me.cmbGrado.Location = New System.Drawing.Point(251, 203)
        Me.cmbGrado.Name = "cmbGrado"
        Me.cmbGrado.Size = New System.Drawing.Size(175, 24)
        Me.cmbGrado.TabIndex = 40
        '
        'cmbProfesor
        '
        Me.cmbProfesor.BackColor = System.Drawing.SystemColors.Window
        Me.cmbProfesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProfesor.FormattingEnabled = True
        Me.cmbProfesor.Location = New System.Drawing.Point(251, 259)
        Me.cmbProfesor.Name = "cmbProfesor"
        Me.cmbProfesor.Size = New System.Drawing.Size(175, 24)
        Me.cmbProfesor.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(67, 314)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 24)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Vacantes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(67, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 24)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Nivel"
        '
        'rbtinicial
        '
        Me.rbtinicial.AutoSize = True
        Me.rbtinicial.Location = New System.Drawing.Point(251, 149)
        Me.rbtinicial.Name = "rbtinicial"
        Me.rbtinicial.Size = New System.Drawing.Size(64, 21)
        Me.rbtinicial.TabIndex = 44
        Me.rbtinicial.TabStop = True
        Me.rbtinicial.Text = "Inicial"
        Me.rbtinicial.UseVisualStyleBackColor = True
        '
        'rbtprimaria
        '
        Me.rbtprimaria.AutoSize = True
        Me.rbtprimaria.Location = New System.Drawing.Point(345, 150)
        Me.rbtprimaria.Name = "rbtprimaria"
        Me.rbtprimaria.Size = New System.Drawing.Size(81, 21)
        Me.rbtprimaria.TabIndex = 45
        Me.rbtprimaria.TabStop = True
        Me.rbtprimaria.Text = "Primaria"
        Me.rbtprimaria.UseVisualStyleBackColor = True
        '
        'dgvSeccion
        '
        Me.dgvSeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSeccion.Location = New System.Drawing.Point(486, 71)
        Me.dgvSeccion.Name = "dgvSeccion"
        Me.dgvSeccion.RowTemplate.Height = 24
        Me.dgvSeccion.Size = New System.Drawing.Size(585, 302)
        Me.dgvSeccion.TabIndex = 46
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnguardar.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.White
        Me.btnguardar.Location = New System.Drawing.Point(77, 367)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(375, 44)
        Me.btnguardar.TabIndex = 47
        Me.btnguardar.Text = "GUARDAR"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'cmbannoEscolar
        '
        Me.cmbannoEscolar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbannoEscolar.FormattingEnabled = True
        Me.cmbannoEscolar.Location = New System.Drawing.Point(251, 59)
        Me.cmbannoEscolar.Name = "cmbannoEscolar"
        Me.cmbannoEscolar.Size = New System.Drawing.Size(164, 24)
        Me.cmbannoEscolar.TabIndex = 48
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(67, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 24)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Grado"
        '
        'frmagregarSeccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(1113, 499)
        Me.Controls.Add(Me.cmbannoEscolar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.dgvSeccion)
        Me.Controls.Add(Me.rbtprimaria)
        Me.Controls.Add(Me.rbtinicial)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbProfesor)
        Me.Controls.Add(Me.cmbGrado)
        Me.Controls.Add(Me.txtvacantes)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.txtSeccion)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmagregarSeccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmagregarSeccion"
        CType(Me.dgvSeccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtvacantes As System.Windows.Forms.TextBox
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents txtSeccion As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbGrado As System.Windows.Forms.ComboBox
    Friend WithEvents cmbProfesor As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rbtinicial As System.Windows.Forms.RadioButton
    Friend WithEvents rbtprimaria As System.Windows.Forms.RadioButton
    Friend WithEvents dgvSeccion As System.Windows.Forms.DataGridView
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents cmbannoEscolar As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
