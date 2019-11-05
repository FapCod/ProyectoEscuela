<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarProfesor
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
        Me.txtnombreProfesor = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtapellidoProfesor = New System.Windows.Forms.TextBox()
        Me.txtcorreoProfesor = New System.Windows.Forms.TextBox()
        Me.txttelefonoProfesor = New System.Windows.Forms.TextBox()
        Me.txtdireccionProfesor = New System.Windows.Forms.TextBox()
        Me.cmbprimariaGradoProfesor = New System.Windows.Forms.ComboBox()
        Me.cmbtipoProfesor = New System.Windows.Forms.ComboBox()
        Me.btnagregarProfesor = New System.Windows.Forms.Button()
        Me.cmbinicialGradoProfesor = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbsexoProfesor = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.rbinicialProfesor = New System.Windows.Forms.RadioButton()
        Me.rbprimariaProfesor = New System.Windows.Forms.RadioButton()
        Me.dgvlista = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtidProfesor = New System.Windows.Forms.TextBox()
        Me.btnbuscarProfesor = New System.Windows.Forms.Button()
        Me.btnactualizarProfesor = New System.Windows.Forms.Button()
        Me.btneliminarProfesor = New System.Windows.Forms.Button()
        Me.btncancelarProfesor = New System.Windows.Forms.Button()
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(110, 96)
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
        Me.Label2.Location = New System.Drawing.Point(110, 141)
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
        Me.Label3.Location = New System.Drawing.Point(110, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Correo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(110, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Sexo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(110, 306)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Telefono"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(110, 377)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Direccion"
        '
        'txtnombreProfesor
        '
        Me.txtnombreProfesor.Location = New System.Drawing.Point(307, 85)
        Me.txtnombreProfesor.Multiline = True
        Me.txtnombreProfesor.Name = "txtnombreProfesor"
        Me.txtnombreProfesor.Size = New System.Drawing.Size(217, 35)
        Me.txtnombreProfesor.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(110, 484)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 24)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Grado "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(110, 558)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(167, 24)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Tipo de profesor"
        '
        'txtapellidoProfesor
        '
        Me.txtapellidoProfesor.Location = New System.Drawing.Point(308, 130)
        Me.txtapellidoProfesor.Multiline = True
        Me.txtapellidoProfesor.Name = "txtapellidoProfesor"
        Me.txtapellidoProfesor.Size = New System.Drawing.Size(217, 35)
        Me.txtapellidoProfesor.TabIndex = 10
        '
        'txtcorreoProfesor
        '
        Me.txtcorreoProfesor.Location = New System.Drawing.Point(308, 181)
        Me.txtcorreoProfesor.Multiline = True
        Me.txtcorreoProfesor.Name = "txtcorreoProfesor"
        Me.txtcorreoProfesor.Size = New System.Drawing.Size(217, 35)
        Me.txtcorreoProfesor.TabIndex = 11
        '
        'txttelefonoProfesor
        '
        Me.txttelefonoProfesor.Location = New System.Drawing.Point(308, 297)
        Me.txttelefonoProfesor.Multiline = True
        Me.txttelefonoProfesor.Name = "txttelefonoProfesor"
        Me.txttelefonoProfesor.Size = New System.Drawing.Size(217, 35)
        Me.txttelefonoProfesor.TabIndex = 13
        '
        'txtdireccionProfesor
        '
        Me.txtdireccionProfesor.Location = New System.Drawing.Point(308, 366)
        Me.txtdireccionProfesor.Multiline = True
        Me.txtdireccionProfesor.Name = "txtdireccionProfesor"
        Me.txtdireccionProfesor.Size = New System.Drawing.Size(217, 35)
        Me.txtdireccionProfesor.TabIndex = 14
        '
        'cmbprimariaGradoProfesor
        '
        Me.cmbprimariaGradoProfesor.FormattingEnabled = True
        Me.cmbprimariaGradoProfesor.Location = New System.Drawing.Point(416, 483)
        Me.cmbprimariaGradoProfesor.Name = "cmbprimariaGradoProfesor"
        Me.cmbprimariaGradoProfesor.Size = New System.Drawing.Size(109, 25)
        Me.cmbprimariaGradoProfesor.TabIndex = 21
        '
        'cmbtipoProfesor
        '
        Me.cmbtipoProfesor.FormattingEnabled = True
        Me.cmbtipoProfesor.Items.AddRange(New Object() {"Contratado", "Nombrado"})
        Me.cmbtipoProfesor.Location = New System.Drawing.Point(297, 560)
        Me.cmbtipoProfesor.Name = "cmbtipoProfesor"
        Me.cmbtipoProfesor.Size = New System.Drawing.Size(227, 25)
        Me.cmbtipoProfesor.TabIndex = 22
        '
        'btnagregarProfesor
        '
        Me.btnagregarProfesor.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnagregarProfesor.Font = New System.Drawing.Font("Gadugi", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregarProfesor.ForeColor = System.Drawing.Color.White
        Me.btnagregarProfesor.Location = New System.Drawing.Point(114, 596)
        Me.btnagregarProfesor.Name = "btnagregarProfesor"
        Me.btnagregarProfesor.Size = New System.Drawing.Size(133, 52)
        Me.btnagregarProfesor.TabIndex = 23
        Me.btnagregarProfesor.Text = "AGREGAR"
        Me.btnagregarProfesor.UseVisualStyleBackColor = False
        '
        'cmbinicialGradoProfesor
        '
        Me.cmbinicialGradoProfesor.FormattingEnabled = True
        Me.cmbinicialGradoProfesor.Location = New System.Drawing.Point(297, 483)
        Me.cmbinicialGradoProfesor.Name = "cmbinicialGradoProfesor"
        Me.cmbinicialGradoProfesor.Size = New System.Drawing.Size(109, 25)
        Me.cmbinicialGradoProfesor.TabIndex = 26
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(303, 530)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 25)
        Me.Label10.TabIndex = 28
        '
        'cmbsexoProfesor
        '
        Me.cmbsexoProfesor.FormattingEnabled = True
        Me.cmbsexoProfesor.Items.AddRange(New Object() {"Hombre", "Mujer", "No Especificado"})
        Me.cmbsexoProfesor.Location = New System.Drawing.Point(308, 248)
        Me.cmbsexoProfesor.Name = "cmbsexoProfesor"
        Me.cmbsexoProfesor.Size = New System.Drawing.Size(109, 25)
        Me.cmbsexoProfesor.TabIndex = 30
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(110, 435)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 24)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Nivel"
        '
        'rbinicialProfesor
        '
        Me.rbinicialProfesor.AutoSize = True
        Me.rbinicialProfesor.ForeColor = System.Drawing.Color.White
        Me.rbinicialProfesor.Location = New System.Drawing.Point(308, 437)
        Me.rbinicialProfesor.Name = "rbinicialProfesor"
        Me.rbinicialProfesor.Size = New System.Drawing.Size(68, 22)
        Me.rbinicialProfesor.TabIndex = 32
        Me.rbinicialProfesor.TabStop = True
        Me.rbinicialProfesor.Text = "Inicial"
        Me.rbinicialProfesor.UseVisualStyleBackColor = True
        '
        'rbprimariaProfesor
        '
        Me.rbprimariaProfesor.AutoSize = True
        Me.rbprimariaProfesor.ForeColor = System.Drawing.Color.White
        Me.rbprimariaProfesor.Location = New System.Drawing.Point(426, 437)
        Me.rbprimariaProfesor.Name = "rbprimariaProfesor"
        Me.rbprimariaProfesor.Size = New System.Drawing.Size(87, 22)
        Me.rbprimariaProfesor.TabIndex = 33
        Me.rbprimariaProfesor.TabStop = True
        Me.rbprimariaProfesor.Text = "Primaria"
        Me.rbprimariaProfesor.UseVisualStyleBackColor = True
        '
        'dgvlista
        '
        Me.dgvlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlista.Location = New System.Drawing.Point(540, 141)
        Me.dgvlista.Name = "dgvlista"
        Me.dgvlista.RowTemplate.Height = 24
        Me.dgvlista.Size = New System.Drawing.Size(668, 519)
        Me.dgvlista.TabIndex = 34
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(565, 58)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 24)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "ID"
        '
        'txtidProfesor
        '
        Me.txtidProfesor.Location = New System.Drawing.Point(569, 85)
        Me.txtidProfesor.Multiline = True
        Me.txtidProfesor.Name = "txtidProfesor"
        Me.txtidProfesor.Size = New System.Drawing.Size(217, 35)
        Me.txtidProfesor.TabIndex = 36
        '
        'btnbuscarProfesor
        '
        Me.btnbuscarProfesor.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnbuscarProfesor.ForeColor = System.Drawing.Color.White
        Me.btnbuscarProfesor.Location = New System.Drawing.Point(792, 72)
        Me.btnbuscarProfesor.Name = "btnbuscarProfesor"
        Me.btnbuscarProfesor.Size = New System.Drawing.Size(149, 48)
        Me.btnbuscarProfesor.TabIndex = 37
        Me.btnbuscarProfesor.Text = "BUSCAR"
        Me.btnbuscarProfesor.UseVisualStyleBackColor = False
        '
        'btnactualizarProfesor
        '
        Me.btnactualizarProfesor.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnactualizarProfesor.Font = New System.Drawing.Font("Gadugi", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnactualizarProfesor.ForeColor = System.Drawing.Color.White
        Me.btnactualizarProfesor.Location = New System.Drawing.Point(253, 596)
        Me.btnactualizarProfesor.Name = "btnactualizarProfesor"
        Me.btnactualizarProfesor.Size = New System.Drawing.Size(124, 52)
        Me.btnactualizarProfesor.TabIndex = 38
        Me.btnactualizarProfesor.Text = "ACTUALIZAR"
        Me.btnactualizarProfesor.UseVisualStyleBackColor = False
        '
        'btneliminarProfesor
        '
        Me.btneliminarProfesor.BackColor = System.Drawing.Color.DodgerBlue
        Me.btneliminarProfesor.Font = New System.Drawing.Font("Gadugi", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminarProfesor.ForeColor = System.Drawing.Color.White
        Me.btneliminarProfesor.Location = New System.Drawing.Point(389, 596)
        Me.btneliminarProfesor.Name = "btneliminarProfesor"
        Me.btneliminarProfesor.Size = New System.Drawing.Size(124, 52)
        Me.btneliminarProfesor.TabIndex = 39
        Me.btneliminarProfesor.Text = "ELIMINAR"
        Me.btneliminarProfesor.UseVisualStyleBackColor = False
        '
        'btncancelarProfesor
        '
        Me.btncancelarProfesor.BackColor = System.Drawing.Color.DodgerBlue
        Me.btncancelarProfesor.Font = New System.Drawing.Font("Gadugi", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelarProfesor.ForeColor = System.Drawing.Color.White
        Me.btncancelarProfesor.Location = New System.Drawing.Point(253, 654)
        Me.btncancelarProfesor.Name = "btncancelarProfesor"
        Me.btncancelarProfesor.Size = New System.Drawing.Size(124, 52)
        Me.btncancelarProfesor.TabIndex = 43
        Me.btncancelarProfesor.Text = "CANCELAR"
        Me.btncancelarProfesor.UseVisualStyleBackColor = False
        '
        'frmAgregarProfesor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(1244, 708)
        Me.Controls.Add(Me.btncancelarProfesor)
        Me.Controls.Add(Me.btneliminarProfesor)
        Me.Controls.Add(Me.btnactualizarProfesor)
        Me.Controls.Add(Me.btnbuscarProfesor)
        Me.Controls.Add(Me.txtidProfesor)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.dgvlista)
        Me.Controls.Add(Me.rbprimariaProfesor)
        Me.Controls.Add(Me.rbinicialProfesor)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmbsexoProfesor)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbinicialGradoProfesor)
        Me.Controls.Add(Me.btnagregarProfesor)
        Me.Controls.Add(Me.cmbtipoProfesor)
        Me.Controls.Add(Me.cmbprimariaGradoProfesor)
        Me.Controls.Add(Me.txtdireccionProfesor)
        Me.Controls.Add(Me.txttelefonoProfesor)
        Me.Controls.Add(Me.txtcorreoProfesor)
        Me.Controls.Add(Me.txtapellidoProfesor)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtnombreProfesor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Gadugi", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "frmAgregarProfesor"
        Me.Text = "frmAgregarProfesor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtnombreProfesor As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtapellidoProfesor As System.Windows.Forms.TextBox
    Friend WithEvents txtcorreoProfesor As System.Windows.Forms.TextBox
    Friend WithEvents txttelefonoProfesor As System.Windows.Forms.TextBox
    Friend WithEvents txtdireccionProfesor As System.Windows.Forms.TextBox
    Friend WithEvents cmbprimariaGradoProfesor As System.Windows.Forms.ComboBox
    Friend WithEvents cmbtipoProfesor As System.Windows.Forms.ComboBox
    Friend WithEvents btnagregarProfesor As System.Windows.Forms.Button
    Friend WithEvents cmbinicialGradoProfesor As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbsexoProfesor As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents rbinicialProfesor As System.Windows.Forms.RadioButton
    Friend WithEvents rbprimariaProfesor As System.Windows.Forms.RadioButton
    Friend WithEvents dgvlista As System.Windows.Forms.DataGridView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtidProfesor As System.Windows.Forms.TextBox
    Friend WithEvents btnbuscarProfesor As System.Windows.Forms.Button
    Friend WithEvents btnactualizarProfesor As System.Windows.Forms.Button
    Friend WithEvents btneliminarProfesor As System.Windows.Forms.Button
    Friend WithEvents btncancelarProfesor As System.Windows.Forms.Button
End Class
