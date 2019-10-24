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
        Me.txtNombreProf = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtApellidoProf = New System.Windows.Forms.TextBox()
        Me.txtCorreoProf = New System.Windows.Forms.TextBox()
        Me.txtTelefonoProf = New System.Windows.Forms.TextBox()
        Me.txtDireccionProf = New System.Windows.Forms.TextBox()
        Me.chcLengua = New System.Windows.Forms.CheckBox()
        Me.chcEducacionF = New System.Windows.Forms.CheckBox()
        Me.chcMatematicas = New System.Windows.Forms.CheckBox()
        Me.chcCienciasS = New System.Windows.Forms.CheckBox()
        Me.chcCienciasN = New System.Windows.Forms.CheckBox()
        Me.chcPrimeraLE = New System.Windows.Forms.CheckBox()
        Me.cmbGradPorf = New System.Windows.Forms.ComboBox()
        Me.cmbTipoProf = New System.Windows.Forms.ComboBox()
        Me.btnAgregarM = New System.Windows.Forms.Button()
        Me.chcReligion = New System.Windows.Forms.CheckBox()
        Me.cmbInicialGradPorf = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbSexo = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.rbInicial = New System.Windows.Forms.RadioButton()
        Me.rbPrimaria = New System.Windows.Forms.RadioButton()
        Me.dgvlista = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtBuscarProf = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(110, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(110, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(110, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Correo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(110, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Sexo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(110, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Telefono"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(110, 354)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Direccion"
        '
        'txtNombreProf
        '
        Me.txtNombreProf.Location = New System.Drawing.Point(308, 68)
        Me.txtNombreProf.Multiline = True
        Me.txtNombreProf.Name = "txtNombreProf"
        Me.txtNombreProf.Size = New System.Drawing.Size(217, 34)
        Me.txtNombreProf.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(110, 411)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 25)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Asignacturas"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(115, 565)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(171, 25)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Grado Y seccion"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(115, 618)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(170, 25)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Tipo de profesor"
        '
        'txtApellidoProf
        '
        Me.txtApellidoProf.Location = New System.Drawing.Point(308, 112)
        Me.txtApellidoProf.Multiline = True
        Me.txtApellidoProf.Name = "txtApellidoProf"
        Me.txtApellidoProf.Size = New System.Drawing.Size(217, 34)
        Me.txtApellidoProf.TabIndex = 10
        '
        'txtCorreoProf
        '
        Me.txtCorreoProf.Location = New System.Drawing.Point(308, 171)
        Me.txtCorreoProf.Multiline = True
        Me.txtCorreoProf.Name = "txtCorreoProf"
        Me.txtCorreoProf.Size = New System.Drawing.Size(217, 34)
        Me.txtCorreoProf.TabIndex = 11
        '
        'txtTelefonoProf
        '
        Me.txtTelefonoProf.Location = New System.Drawing.Point(308, 279)
        Me.txtTelefonoProf.Multiline = True
        Me.txtTelefonoProf.Name = "txtTelefonoProf"
        Me.txtTelefonoProf.Size = New System.Drawing.Size(217, 34)
        Me.txtTelefonoProf.TabIndex = 13
        '
        'txtDireccionProf
        '
        Me.txtDireccionProf.Location = New System.Drawing.Point(308, 345)
        Me.txtDireccionProf.Multiline = True
        Me.txtDireccionProf.Name = "txtDireccionProf"
        Me.txtDireccionProf.Size = New System.Drawing.Size(217, 34)
        Me.txtDireccionProf.TabIndex = 14
        '
        'chcLengua
        '
        Me.chcLengua.AutoSize = True
        Me.chcLengua.Location = New System.Drawing.Point(308, 411)
        Me.chcLengua.Name = "chcLengua"
        Me.chcLengua.Size = New System.Drawing.Size(224, 21)
        Me.chcLengua.TabIndex = 15
        Me.chcLengua.Text = "Lengua Castellana y Literatura"
        Me.chcLengua.UseVisualStyleBackColor = True
        '
        'chcEducacionF
        '
        Me.chcEducacionF.AutoSize = True
        Me.chcEducacionF.Location = New System.Drawing.Point(308, 465)
        Me.chcEducacionF.Name = "chcEducacionF"
        Me.chcEducacionF.Size = New System.Drawing.Size(136, 21)
        Me.chcEducacionF.TabIndex = 16
        Me.chcEducacionF.Text = "Educación Física"
        Me.chcEducacionF.UseVisualStyleBackColor = True
        '
        'chcMatematicas
        '
        Me.chcMatematicas.AutoSize = True
        Me.chcMatematicas.Location = New System.Drawing.Point(308, 438)
        Me.chcMatematicas.Name = "chcMatematicas"
        Me.chcMatematicas.Size = New System.Drawing.Size(109, 21)
        Me.chcMatematicas.TabIndex = 17
        Me.chcMatematicas.Text = "Matemáticas"
        Me.chcMatematicas.UseVisualStyleBackColor = True
        '
        'chcCienciasS
        '
        Me.chcCienciasS.AutoSize = True
        Me.chcCienciasS.Location = New System.Drawing.Point(425, 438)
        Me.chcCienciasS.Name = "chcCienciasS"
        Me.chcCienciasS.Size = New System.Drawing.Size(140, 21)
        Me.chcCienciasS.TabIndex = 18
        Me.chcCienciasS.Text = "Ciencias Sociales"
        Me.chcCienciasS.UseVisualStyleBackColor = True
        '
        'chcCienciasN
        '
        Me.chcCienciasN.AutoSize = True
        Me.chcCienciasN.Location = New System.Drawing.Point(549, 411)
        Me.chcCienciasN.Name = "chcCienciasN"
        Me.chcCienciasN.Size = New System.Drawing.Size(191, 21)
        Me.chcCienciasN.TabIndex = 19
        Me.chcCienciasN.Text = "Ciencias de la Naturaleza"
        Me.chcCienciasN.UseVisualStyleBackColor = True
        '
        'chcPrimeraLE
        '
        Me.chcPrimeraLE.AutoSize = True
        Me.chcPrimeraLE.Location = New System.Drawing.Point(571, 438)
        Me.chcPrimeraLE.Name = "chcPrimeraLE"
        Me.chcPrimeraLE.Size = New System.Drawing.Size(199, 21)
        Me.chcPrimeraLE.TabIndex = 20
        Me.chcPrimeraLE.Text = "Primera Lengua Extranjera"
        Me.chcPrimeraLE.UseVisualStyleBackColor = True
        '
        'cmbGradPorf
        '
        Me.cmbGradPorf.FormattingEnabled = True
        Me.cmbGradPorf.Items.AddRange(New Object() {"1A", "1B", "1C", "2A", "2B", "2C", "3A", "3B", "3C", "4A", "4B", "4C ", "5A", "5B", "5C", "6A", "6B", "6C", " "})
        Me.cmbGradPorf.Location = New System.Drawing.Point(426, 565)
        Me.cmbGradPorf.Name = "cmbGradPorf"
        Me.cmbGradPorf.Size = New System.Drawing.Size(109, 24)
        Me.cmbGradPorf.TabIndex = 21
        '
        'cmbTipoProf
        '
        Me.cmbTipoProf.FormattingEnabled = True
        Me.cmbTipoProf.Items.AddRange(New Object() {"Contratado", "Nombrado"})
        Me.cmbTipoProf.Location = New System.Drawing.Point(308, 618)
        Me.cmbTipoProf.Name = "cmbTipoProf"
        Me.cmbTipoProf.Size = New System.Drawing.Size(217, 24)
        Me.cmbTipoProf.TabIndex = 22
        '
        'btnAgregarM
        '
        Me.btnAgregarM.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAgregarM.Font = New System.Drawing.Font("Gadugi", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarM.ForeColor = System.Drawing.Color.White
        Me.btnAgregarM.Location = New System.Drawing.Point(115, 658)
        Me.btnAgregarM.Name = "btnAgregarM"
        Me.btnAgregarM.Size = New System.Drawing.Size(133, 49)
        Me.btnAgregarM.TabIndex = 23
        Me.btnAgregarM.Text = "AGREGAR"
        Me.btnAgregarM.UseVisualStyleBackColor = False
        '
        'chcReligion
        '
        Me.chcReligion.AutoSize = True
        Me.chcReligion.Location = New System.Drawing.Point(450, 465)
        Me.chcReligion.Name = "chcReligion"
        Me.chcReligion.Size = New System.Drawing.Size(85, 21)
        Me.chcReligion.TabIndex = 24
        Me.chcReligion.Text = "Religión "
        Me.chcReligion.UseVisualStyleBackColor = True
        '
        'cmbInicialGradPorf
        '
        Me.cmbInicialGradPorf.FormattingEnabled = True
        Me.cmbInicialGradPorf.Items.AddRange(New Object() {"1A", "1B", "1C", "2A", "2B", "2C", "3A", "3B", "3C"})
        Me.cmbInicialGradPorf.Location = New System.Drawing.Point(308, 565)
        Me.cmbInicialGradPorf.Name = "cmbInicialGradPorf"
        Me.cmbInicialGradPorf.Size = New System.Drawing.Size(109, 24)
        Me.cmbInicialGradPorf.TabIndex = 26
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(303, 499)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 25)
        Me.Label10.TabIndex = 28
        '
        'cmbSexo
        '
        Me.cmbSexo.FormattingEnabled = True
        Me.cmbSexo.Items.AddRange(New Object() {"Hombre", "Mujer", "No Especificado"})
        Me.cmbSexo.Location = New System.Drawing.Point(308, 234)
        Me.cmbSexo.Name = "cmbSexo"
        Me.cmbSexo.Size = New System.Drawing.Size(109, 24)
        Me.cmbSexo.TabIndex = 30
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(110, 511)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 25)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Nivel"
        '
        'rbInicial
        '
        Me.rbInicial.AutoSize = True
        Me.rbInicial.Location = New System.Drawing.Point(308, 511)
        Me.rbInicial.Name = "rbInicial"
        Me.rbInicial.Size = New System.Drawing.Size(64, 21)
        Me.rbInicial.TabIndex = 32
        Me.rbInicial.TabStop = True
        Me.rbInicial.Text = "Inicial"
        Me.rbInicial.UseVisualStyleBackColor = True
        '
        'rbPrimaria
        '
        Me.rbPrimaria.AutoSize = True
        Me.rbPrimaria.Location = New System.Drawing.Point(426, 515)
        Me.rbPrimaria.Name = "rbPrimaria"
        Me.rbPrimaria.Size = New System.Drawing.Size(81, 21)
        Me.rbPrimaria.TabIndex = 33
        Me.rbPrimaria.TabStop = True
        Me.rbPrimaria.Text = "Primaria"
        Me.rbPrimaria.UseVisualStyleBackColor = True
        '
        'dgvlista
        '
        Me.dgvlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlista.Location = New System.Drawing.Point(795, 153)
        Me.dgvlista.Name = "dgvlista"
        Me.dgvlista.RowTemplate.Height = 24
        Me.dgvlista.Size = New System.Drawing.Size(407, 489)
        Me.dgvlista.TabIndex = 34
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(810, 71)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(21, 17)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "ID"
        '
        'txtBuscarProf
        '
        Me.txtBuscarProf.Location = New System.Drawing.Point(795, 91)
        Me.txtBuscarProf.Multiline = True
        Me.txtBuscarProf.Name = "txtBuscarProf"
        Me.txtBuscarProf.Size = New System.Drawing.Size(217, 34)
        Me.txtBuscarProf.TabIndex = 36
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(1039, 88)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(149, 45)
        Me.btnBuscar.TabIndex = 37
        Me.btnBuscar.Text = "BUSCAR"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnActualizar.Font = New System.Drawing.Font("Gadugi", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.ForeColor = System.Drawing.Color.White
        Me.btnActualizar.Location = New System.Drawing.Point(268, 658)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(124, 49)
        Me.btnActualizar.TabIndex = 38
        Me.btnActualizar.Text = "ACTUALIZAR"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnEliminar.Font = New System.Drawing.Font("Gadugi", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(426, 658)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(124, 49)
        Me.btnEliminar.TabIndex = 39
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'frmAgregarProfesor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(1255, 744)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBuscarProf)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.dgvlista)
        Me.Controls.Add(Me.rbPrimaria)
        Me.Controls.Add(Me.rbInicial)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmbSexo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbInicialGradPorf)
        Me.Controls.Add(Me.chcReligion)
        Me.Controls.Add(Me.btnAgregarM)
        Me.Controls.Add(Me.cmbTipoProf)
        Me.Controls.Add(Me.cmbGradPorf)
        Me.Controls.Add(Me.chcPrimeraLE)
        Me.Controls.Add(Me.chcCienciasN)
        Me.Controls.Add(Me.chcCienciasS)
        Me.Controls.Add(Me.chcMatematicas)
        Me.Controls.Add(Me.chcEducacionF)
        Me.Controls.Add(Me.chcLengua)
        Me.Controls.Add(Me.txtDireccionProf)
        Me.Controls.Add(Me.txtTelefonoProf)
        Me.Controls.Add(Me.txtCorreoProf)
        Me.Controls.Add(Me.txtApellidoProf)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNombreProf)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAgregarProfesor"
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
    Friend WithEvents txtNombreProf As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtApellidoProf As System.Windows.Forms.TextBox
    Friend WithEvents txtCorreoProf As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefonoProf As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccionProf As System.Windows.Forms.TextBox
    Friend WithEvents chcLengua As System.Windows.Forms.CheckBox
    Friend WithEvents chcEducacionF As System.Windows.Forms.CheckBox
    Friend WithEvents chcMatematicas As System.Windows.Forms.CheckBox
    Friend WithEvents chcCienciasS As System.Windows.Forms.CheckBox
    Friend WithEvents chcCienciasN As System.Windows.Forms.CheckBox
    Friend WithEvents chcPrimeraLE As System.Windows.Forms.CheckBox
    Friend WithEvents cmbGradPorf As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTipoProf As System.Windows.Forms.ComboBox
    Friend WithEvents btnAgregarM As System.Windows.Forms.Button
    Friend WithEvents chcReligion As System.Windows.Forms.CheckBox
    Friend WithEvents cmbInicialGradPorf As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbSexo As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents rbInicial As System.Windows.Forms.RadioButton
    Friend WithEvents rbPrimaria As System.Windows.Forms.RadioButton
    Friend WithEvents dgvlista As System.Windows.Forms.DataGridView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtBuscarProf As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
End Class
