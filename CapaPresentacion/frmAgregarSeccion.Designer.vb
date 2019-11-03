<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarSeccion
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtGrado = New System.Windows.Forms.TextBox()
        Me.txtSeccion = New System.Windows.Forms.TextBox()
        Me.txtNumAula = New System.Windows.Forms.TextBox()
        Me.rbtIncial = New System.Windows.Forms.RadioButton()
        Me.rbtPrimaria = New System.Windows.Forms.RadioButton()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dgvSeccionPrimaria = New System.Windows.Forms.DataGridView()
        Me.dgvSeccionInicial = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgvSeccionPrimaria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSeccionInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Grado "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Seccion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "N° Aula"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nivel "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(109, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Secciones"
        '
        'txtGrado
        '
        Me.txtGrado.Location = New System.Drawing.Point(166, 93)
        Me.txtGrado.Name = "txtGrado"
        Me.txtGrado.Size = New System.Drawing.Size(100, 22)
        Me.txtGrado.TabIndex = 6
        '
        'txtSeccion
        '
        Me.txtSeccion.Location = New System.Drawing.Point(166, 131)
        Me.txtSeccion.Name = "txtSeccion"
        Me.txtSeccion.Size = New System.Drawing.Size(100, 22)
        Me.txtSeccion.TabIndex = 7
        '
        'txtNumAula
        '
        Me.txtNumAula.Location = New System.Drawing.Point(166, 178)
        Me.txtNumAula.Name = "txtNumAula"
        Me.txtNumAula.Size = New System.Drawing.Size(100, 22)
        Me.txtNumAula.TabIndex = 8
        '
        'rbtIncial
        '
        Me.rbtIncial.AutoSize = True
        Me.rbtIncial.Location = New System.Drawing.Point(166, 237)
        Me.rbtIncial.Name = "rbtIncial"
        Me.rbtIncial.Size = New System.Drawing.Size(64, 21)
        Me.rbtIncial.TabIndex = 10
        Me.rbtIncial.TabStop = True
        Me.rbtIncial.Text = "Inicial"
        Me.rbtIncial.UseVisualStyleBackColor = True
        '
        'rbtPrimaria
        '
        Me.rbtPrimaria.AutoSize = True
        Me.rbtPrimaria.Location = New System.Drawing.Point(242, 237)
        Me.rbtPrimaria.Name = "rbtPrimaria"
        Me.rbtPrimaria.Size = New System.Drawing.Size(81, 21)
        Me.rbtPrimaria.TabIndex = 11
        Me.rbtPrimaria.TabStop = True
        Me.rbtPrimaria.Text = "Primaria"
        Me.rbtPrimaria.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(55, 288)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(117, 41)
        Me.btnAgregar.TabIndex = 12
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(206, 288)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 41)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dgvSeccionPrimaria
        '
        Me.dgvSeccionPrimaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSeccionPrimaria.Location = New System.Drawing.Point(383, 26)
        Me.dgvSeccionPrimaria.Name = "dgvSeccionPrimaria"
        Me.dgvSeccionPrimaria.RowTemplate.Height = 24
        Me.dgvSeccionPrimaria.Size = New System.Drawing.Size(396, 136)
        Me.dgvSeccionPrimaria.TabIndex = 14
        '
        'dgvSeccionInicial
        '
        Me.dgvSeccionInicial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSeccionInicial.Location = New System.Drawing.Point(383, 204)
        Me.dgvSeccionInicial.Name = "dgvSeccionInicial"
        Me.dgvSeccionInicial.RowTemplate.Height = 24
        Me.dgvSeccionInicial.Size = New System.Drawing.Size(395, 135)
        Me.dgvSeccionInicial.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(379, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 23)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Secciones Primarias"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(379, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 23)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Secciones Iniciales"
        '
        'frmAgregarSeccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 352)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvSeccionInicial)
        Me.Controls.Add(Me.dgvSeccionPrimaria)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.rbtPrimaria)
        Me.Controls.Add(Me.rbtIncial)
        Me.Controls.Add(Me.txtNumAula)
        Me.Controls.Add(Me.txtSeccion)
        Me.Controls.Add(Me.txtGrado)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAgregarSeccion"
        Me.Text = "frmAgregarSeccion"
        CType(Me.dgvSeccionPrimaria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSeccionInicial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtGrado As System.Windows.Forms.TextBox
    Friend WithEvents txtSeccion As System.Windows.Forms.TextBox
    Friend WithEvents txtNumAula As System.Windows.Forms.TextBox
    Friend WithEvents rbtIncial As System.Windows.Forms.RadioButton
    Friend WithEvents rbtPrimaria As System.Windows.Forms.RadioButton
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents dgvSeccionPrimaria As System.Windows.Forms.DataGridView
    Friend WithEvents dgvSeccionInicial As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
