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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarProfesor))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnombreProfesor = New System.Windows.Forms.TextBox()
        Me.txtapellidoProfesor = New System.Windows.Forms.TextBox()
        Me.txtcorreoProfesor = New System.Windows.Forms.TextBox()
        Me.txttelefonoProfesor = New System.Windows.Forms.TextBox()
        Me.txtdireccionProfesor = New System.Windows.Forms.TextBox()
        Me.btnagregarProfesor = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbsexoProfesor = New System.Windows.Forms.ComboBox()
        Me.dgvlista = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtdniIIProfesor = New System.Windows.Forms.TextBox()
        Me.btnbuscarProfesor = New System.Windows.Forms.Button()
        Me.btnactualizarProfesor = New System.Windows.Forms.Button()
        Me.btneliminarProfesor = New System.Windows.Forms.Button()
        Me.btncancelarProfesor = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtdniProfesor = New System.Windows.Forms.TextBox()
        Me.txtedadProfesor = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnListar = New System.Windows.Forms.Button()
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(117, 85)
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
        Me.Label3.Location = New System.Drawing.Point(110, 319)
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
        Me.Label4.Location = New System.Drawing.Point(110, 231)
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
        Me.Label5.Location = New System.Drawing.Point(109, 370)
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
        Me.Label6.Location = New System.Drawing.Point(109, 275)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Direccion"
        '
        'txtnombreProfesor
        '
        Me.txtnombreProfesor.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombreProfesor.Location = New System.Drawing.Point(307, 85)
        Me.txtnombreProfesor.Multiline = True
        Me.txtnombreProfesor.Name = "txtnombreProfesor"
        Me.txtnombreProfesor.Size = New System.Drawing.Size(217, 35)
        Me.txtnombreProfesor.TabIndex = 2
        '
        'txtapellidoProfesor
        '
        Me.txtapellidoProfesor.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapellidoProfesor.Location = New System.Drawing.Point(308, 130)
        Me.txtapellidoProfesor.Multiline = True
        Me.txtapellidoProfesor.Name = "txtapellidoProfesor"
        Me.txtapellidoProfesor.Size = New System.Drawing.Size(217, 35)
        Me.txtapellidoProfesor.TabIndex = 3
        '
        'txtcorreoProfesor
        '
        Me.txtcorreoProfesor.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcorreoProfesor.Location = New System.Drawing.Point(308, 311)
        Me.txtcorreoProfesor.Multiline = True
        Me.txtcorreoProfesor.Name = "txtcorreoProfesor"
        Me.txtcorreoProfesor.Size = New System.Drawing.Size(217, 35)
        Me.txtcorreoProfesor.TabIndex = 7
        '
        'txttelefonoProfesor
        '
        Me.txttelefonoProfesor.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelefonoProfesor.Location = New System.Drawing.Point(307, 361)
        Me.txttelefonoProfesor.Multiline = True
        Me.txttelefonoProfesor.Name = "txttelefonoProfesor"
        Me.txttelefonoProfesor.Size = New System.Drawing.Size(217, 35)
        Me.txttelefonoProfesor.TabIndex = 8
        '
        'txtdireccionProfesor
        '
        Me.txtdireccionProfesor.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdireccionProfesor.Location = New System.Drawing.Point(307, 264)
        Me.txtdireccionProfesor.Multiline = True
        Me.txtdireccionProfesor.Name = "txtdireccionProfesor"
        Me.txtdireccionProfesor.Size = New System.Drawing.Size(217, 35)
        Me.txtdireccionProfesor.TabIndex = 6
        '
        'btnagregarProfesor
        '
        Me.btnagregarProfesor.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnagregarProfesor.Font = New System.Drawing.Font("Gadugi", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregarProfesor.ForeColor = System.Drawing.Color.White
        Me.btnagregarProfesor.Location = New System.Drawing.Point(113, 436)
        Me.btnagregarProfesor.Name = "btnagregarProfesor"
        Me.btnagregarProfesor.Size = New System.Drawing.Size(133, 52)
        Me.btnagregarProfesor.TabIndex = 23
        Me.btnagregarProfesor.Text = "AGREGAR"
        Me.btnagregarProfesor.UseVisualStyleBackColor = False
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
        Me.cmbsexoProfesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbsexoProfesor.DropDownWidth = 109
        Me.cmbsexoProfesor.FormattingEnabled = True
        Me.cmbsexoProfesor.Items.AddRange(New Object() {"M", "F", "N"})
        Me.cmbsexoProfesor.Location = New System.Drawing.Point(307, 230)
        Me.cmbsexoProfesor.Name = "cmbsexoProfesor"
        Me.cmbsexoProfesor.Size = New System.Drawing.Size(109, 25)
        Me.cmbsexoProfesor.TabIndex = 5
        '
        'dgvlista
        '
        Me.dgvlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlista.Location = New System.Drawing.Point(541, 117)
        Me.dgvlista.Name = "dgvlista"
        Me.dgvlista.RowTemplate.Height = 24
        Me.dgvlista.Size = New System.Drawing.Size(668, 429)
        Me.dgvlista.TabIndex = 34
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(562, 47)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 24)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "DNI"
        '
        'txtdniIIProfesor
        '
        Me.txtdniIIProfesor.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdniIIProfesor.Location = New System.Drawing.Point(566, 74)
        Me.txtdniIIProfesor.Multiline = True
        Me.txtdniIIProfesor.Name = "txtdniIIProfesor"
        Me.txtdniIIProfesor.Size = New System.Drawing.Size(217, 35)
        Me.txtdniIIProfesor.TabIndex = 36
        '
        'btnbuscarProfesor
        '
        Me.btnbuscarProfesor.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnbuscarProfesor.ForeColor = System.Drawing.Color.White
        Me.btnbuscarProfesor.Location = New System.Drawing.Point(789, 61)
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
        Me.btnactualizarProfesor.Location = New System.Drawing.Point(253, 436)
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
        Me.btneliminarProfesor.Location = New System.Drawing.Point(383, 436)
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
        Me.btncancelarProfesor.Location = New System.Drawing.Point(253, 494)
        Me.btncancelarProfesor.Name = "btncancelarProfesor"
        Me.btncancelarProfesor.Size = New System.Drawing.Size(124, 52)
        Me.btncancelarProfesor.TabIndex = 43
        Me.btncancelarProfesor.Text = "CANCELAR"
        Me.btncancelarProfesor.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(117, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 24)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "DNI"
        '
        'txtdniProfesor
        '
        Me.txtdniProfesor.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdniProfesor.Location = New System.Drawing.Point(308, 44)
        Me.txtdniProfesor.Multiline = True
        Me.txtdniProfesor.Name = "txtdniProfesor"
        Me.txtdniProfesor.Size = New System.Drawing.Size(217, 35)
        Me.txtdniProfesor.TabIndex = 1
        '
        'txtedadProfesor
        '
        Me.txtedadProfesor.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtedadProfesor.Location = New System.Drawing.Point(308, 174)
        Me.txtedadProfesor.Multiline = True
        Me.txtedadProfesor.Name = "txtedadProfesor"
        Me.txtedadProfesor.Size = New System.Drawing.Size(69, 35)
        Me.txtedadProfesor.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(110, 185)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 24)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "Edad"
        '
        'btnListar
        '
        Me.btnListar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnListar.ForeColor = System.Drawing.Color.White
        Me.btnListar.Location = New System.Drawing.Point(960, 61)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(149, 48)
        Me.btnListar.TabIndex = 47
        Me.btnListar.Text = "LISTAR"
        Me.btnListar.UseVisualStyleBackColor = False
        '
        'frmAgregarProfesor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(1244, 558)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.txtedadProfesor)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtdniProfesor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btncancelarProfesor)
        Me.Controls.Add(Me.btneliminarProfesor)
        Me.Controls.Add(Me.btnactualizarProfesor)
        Me.Controls.Add(Me.btnbuscarProfesor)
        Me.Controls.Add(Me.txtdniIIProfesor)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.dgvlista)
        Me.Controls.Add(Me.cmbsexoProfesor)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnagregarProfesor)
        Me.Controls.Add(Me.txtdireccionProfesor)
        Me.Controls.Add(Me.txttelefonoProfesor)
        Me.Controls.Add(Me.txtcorreoProfesor)
        Me.Controls.Add(Me.txtapellidoProfesor)
        Me.Controls.Add(Me.txtnombreProfesor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Gadugi", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAgregarProfesor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAgregarProfesor"
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
    Friend WithEvents txtapellidoProfesor As System.Windows.Forms.TextBox
    Friend WithEvents txtcorreoProfesor As System.Windows.Forms.TextBox
    Friend WithEvents txttelefonoProfesor As System.Windows.Forms.TextBox
    Friend WithEvents txtdireccionProfesor As System.Windows.Forms.TextBox
    Friend WithEvents btnagregarProfesor As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbsexoProfesor As System.Windows.Forms.ComboBox
    Friend WithEvents dgvlista As System.Windows.Forms.DataGridView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtdniIIProfesor As System.Windows.Forms.TextBox
    Friend WithEvents btnbuscarProfesor As System.Windows.Forms.Button
    Friend WithEvents btnactualizarProfesor As System.Windows.Forms.Button
    Friend WithEvents btneliminarProfesor As System.Windows.Forms.Button
    Friend WithEvents btncancelarProfesor As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtdniProfesor As System.Windows.Forms.TextBox
    Friend WithEvents txtedadProfesor As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnListar As System.Windows.Forms.Button
End Class
