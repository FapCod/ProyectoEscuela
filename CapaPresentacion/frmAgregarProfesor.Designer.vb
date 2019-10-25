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
        'txtNombreProf
        '
        Me.txtNombreProf.Location = New System.Drawing.Point(307, 85)
        Me.txtNombreProf.Multiline = True
        Me.txtNombreProf.Name = "txtNombreProf"
        Me.txtNombreProf.Size = New System.Drawing.Size(217, 35)
        Me.txtNombreProf.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(110, 436)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 24)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Asignacturas"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(115, 601)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(161, 24)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Grado Y seccion"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(115, 656)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(167, 24)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Tipo de profesor"
        '
        'txtApellidoProf
        '
        Me.txtApellidoProf.Location = New System.Drawing.Point(308, 130)
        Me.txtApellidoProf.Multiline = True
        Me.txtApellidoProf.Name = "txtApellidoProf"
        Me.txtApellidoProf.Size = New System.Drawing.Size(217, 35)
        Me.txtApellidoProf.TabIndex = 10
        '
        'txtCorreoProf
        '
        Me.txtCorreoProf.Location = New System.Drawing.Point(308, 181)
        Me.txtCorreoProf.Multiline = True
        Me.txtCorreoProf.Name = "txtCorreoProf"
        Me.txtCorreoProf.Size = New System.Drawing.Size(217, 35)
        Me.txtCorreoProf.TabIndex = 11
        '
        'txtTelefonoProf
        '
        Me.txtTelefonoProf.Location = New System.Drawing.Point(308, 297)
        Me.txtTelefonoProf.Multiline = True
        Me.txtTelefonoProf.Name = "txtTelefonoProf"
        Me.txtTelefonoProf.Size = New System.Drawing.Size(217, 35)
        Me.txtTelefonoProf.TabIndex = 13
        '
        'txtDireccionProf
        '
        Me.txtDireccionProf.Location = New System.Drawing.Point(308, 366)
        Me.txtDireccionProf.Multiline = True
        Me.txtDireccionProf.Name = "txtDireccionProf"
        Me.txtDireccionProf.Size = New System.Drawing.Size(217, 35)
        Me.txtDireccionProf.TabIndex = 14
        '
        'chcLengua
        '
        Me.chcLengua.AutoSize = True
        Me.chcLengua.Font = New System.Drawing.Font("Gadugi", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chcLengua.ForeColor = System.Drawing.Color.White
        Me.chcLengua.Location = New System.Drawing.Point(251, 435)
        Me.chcLengua.Name = "chcLengua"
        Me.chcLengua.Size = New System.Drawing.Size(273, 24)
        Me.chcLengua.TabIndex = 15
        Me.chcLengua.Text = "Lengua Castellana y Literatura"
        Me.chcLengua.UseVisualStyleBackColor = True
        '
        'chcEducacionF
        '
        Me.chcEducacionF.AutoSize = True
        Me.chcEducacionF.Font = New System.Drawing.Font("Gadugi", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chcEducacionF.ForeColor = System.Drawing.Color.White
        Me.chcEducacionF.Location = New System.Drawing.Point(251, 493)
        Me.chcEducacionF.Name = "chcEducacionF"
        Me.chcEducacionF.Size = New System.Drawing.Size(159, 24)
        Me.chcEducacionF.TabIndex = 16
        Me.chcEducacionF.Text = "Educación Física"
        Me.chcEducacionF.UseVisualStyleBackColor = True
        '
        'chcMatematicas
        '
        Me.chcMatematicas.AutoSize = True
        Me.chcMatematicas.Font = New System.Drawing.Font("Gadugi", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chcMatematicas.ForeColor = System.Drawing.Color.White
        Me.chcMatematicas.Location = New System.Drawing.Point(251, 465)
        Me.chcMatematicas.Name = "chcMatematicas"
        Me.chcMatematicas.Size = New System.Drawing.Size(133, 24)
        Me.chcMatematicas.TabIndex = 17
        Me.chcMatematicas.Text = "Matemáticas"
        Me.chcMatematicas.UseVisualStyleBackColor = True
        '
        'chcCienciasS
        '
        Me.chcCienciasS.AutoSize = True
        Me.chcCienciasS.Font = New System.Drawing.Font("Gadugi", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chcCienciasS.ForeColor = System.Drawing.Color.White
        Me.chcCienciasS.Location = New System.Drawing.Point(385, 465)
        Me.chcCienciasS.Name = "chcCienciasS"
        Me.chcCienciasS.Size = New System.Drawing.Size(163, 24)
        Me.chcCienciasS.TabIndex = 18
        Me.chcCienciasS.Text = "Ciencias Sociales"
        Me.chcCienciasS.UseVisualStyleBackColor = True
        '
        'chcCienciasN
        '
        Me.chcCienciasN.AutoSize = True
        Me.chcCienciasN.Font = New System.Drawing.Font("Gadugi", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chcCienciasN.ForeColor = System.Drawing.Color.White
        Me.chcCienciasN.Location = New System.Drawing.Point(520, 435)
        Me.chcCienciasN.Name = "chcCienciasN"
        Me.chcCienciasN.Size = New System.Drawing.Size(230, 24)
        Me.chcCienciasN.TabIndex = 19
        Me.chcCienciasN.Text = "Ciencias de la Naturaleza"
        Me.chcCienciasN.UseVisualStyleBackColor = True
        '
        'chcPrimeraLE
        '
        Me.chcPrimeraLE.AutoSize = True
        Me.chcPrimeraLE.Font = New System.Drawing.Font("Gadugi", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chcPrimeraLE.ForeColor = System.Drawing.Color.White
        Me.chcPrimeraLE.Location = New System.Drawing.Point(543, 465)
        Me.chcPrimeraLE.Name = "chcPrimeraLE"
        Me.chcPrimeraLE.Size = New System.Drawing.Size(243, 24)
        Me.chcPrimeraLE.TabIndex = 20
        Me.chcPrimeraLE.Text = "Primera Lengua Extranjera"
        Me.chcPrimeraLE.UseVisualStyleBackColor = True
        '
        'cmbGradPorf
        '
        Me.cmbGradPorf.FormattingEnabled = True
        Me.cmbGradPorf.Items.AddRange(New Object() {"1A", "1B", "1C", "2A", "2B", "2C", "3A", "3B", "3C", "4A", "4B", "4C ", "5A", "5B", "5C", "6A", "6B", "6C", " "})
        Me.cmbGradPorf.Location = New System.Drawing.Point(426, 601)
        Me.cmbGradPorf.Name = "cmbGradPorf"
        Me.cmbGradPorf.Size = New System.Drawing.Size(109, 25)
        Me.cmbGradPorf.TabIndex = 21
        '
        'cmbTipoProf
        '
        Me.cmbTipoProf.FormattingEnabled = True
        Me.cmbTipoProf.Items.AddRange(New Object() {"Contratado", "Nombrado"})
        Me.cmbTipoProf.Location = New System.Drawing.Point(308, 656)
        Me.cmbTipoProf.Name = "cmbTipoProf"
        Me.cmbTipoProf.Size = New System.Drawing.Size(217, 25)
        Me.cmbTipoProf.TabIndex = 22
        '
        'btnAgregarM
        '
        Me.btnAgregarM.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAgregarM.Font = New System.Drawing.Font("Gadugi", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarM.ForeColor = System.Drawing.Color.White
        Me.btnAgregarM.Location = New System.Drawing.Point(115, 700)
        Me.btnAgregarM.Name = "btnAgregarM"
        Me.btnAgregarM.Size = New System.Drawing.Size(133, 52)
        Me.btnAgregarM.TabIndex = 23
        Me.btnAgregarM.Text = "AGREGAR"
        Me.btnAgregarM.UseVisualStyleBackColor = False
        '
        'chcReligion
        '
        Me.chcReligion.AutoSize = True
        Me.chcReligion.Font = New System.Drawing.Font("Gadugi", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chcReligion.ForeColor = System.Drawing.Color.White
        Me.chcReligion.Location = New System.Drawing.Point(406, 493)
        Me.chcReligion.Name = "chcReligion"
        Me.chcReligion.Size = New System.Drawing.Size(102, 24)
        Me.chcReligion.TabIndex = 24
        Me.chcReligion.Text = "Religión "
        Me.chcReligion.UseVisualStyleBackColor = True
        '
        'cmbInicialGradPorf
        '
        Me.cmbInicialGradPorf.FormattingEnabled = True
        Me.cmbInicialGradPorf.Items.AddRange(New Object() {"1A", "1B", "1C", "2A", "2B", "2C", "3A", "3B", "3C"})
        Me.cmbInicialGradPorf.Location = New System.Drawing.Point(308, 601)
        Me.cmbInicialGradPorf.Name = "cmbInicialGradPorf"
        Me.cmbInicialGradPorf.Size = New System.Drawing.Size(109, 25)
        Me.cmbInicialGradPorf.TabIndex = 26
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
        'cmbSexo
        '
        Me.cmbSexo.FormattingEnabled = True
        Me.cmbSexo.Items.AddRange(New Object() {"Hombre", "Mujer", "No Especificado"})
        Me.cmbSexo.Location = New System.Drawing.Point(308, 248)
        Me.cmbSexo.Name = "cmbSexo"
        Me.cmbSexo.Size = New System.Drawing.Size(109, 25)
        Me.cmbSexo.TabIndex = 30
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(110, 543)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 24)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Nivel"
        '
        'rbInicial
        '
        Me.rbInicial.AutoSize = True
        Me.rbInicial.ForeColor = System.Drawing.Color.White
        Me.rbInicial.Location = New System.Drawing.Point(308, 543)
        Me.rbInicial.Name = "rbInicial"
        Me.rbInicial.Size = New System.Drawing.Size(68, 22)
        Me.rbInicial.TabIndex = 32
        Me.rbInicial.TabStop = True
        Me.rbInicial.Text = "Inicial"
        Me.rbInicial.UseVisualStyleBackColor = True
        '
        'rbPrimaria
        '
        Me.rbPrimaria.AutoSize = True
        Me.rbPrimaria.ForeColor = System.Drawing.Color.White
        Me.rbPrimaria.Location = New System.Drawing.Point(426, 547)
        Me.rbPrimaria.Name = "rbPrimaria"
        Me.rbPrimaria.Size = New System.Drawing.Size(87, 22)
        Me.rbPrimaria.TabIndex = 33
        Me.rbPrimaria.TabStop = True
        Me.rbPrimaria.Text = "Primaria"
        Me.rbPrimaria.UseVisualStyleBackColor = True
        '
        'dgvlista
        '
        Me.dgvlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlista.Location = New System.Drawing.Point(795, 162)
        Me.dgvlista.Name = "dgvlista"
        Me.dgvlista.RowTemplate.Height = 24
        Me.dgvlista.Size = New System.Drawing.Size(938, 519)
        Me.dgvlista.TabIndex = 34
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(802, 69)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 24)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "ID"
        '
        'txtBuscarProf
        '
        Me.txtBuscarProf.Location = New System.Drawing.Point(795, 96)
        Me.txtBuscarProf.Multiline = True
        Me.txtBuscarProf.Name = "txtBuscarProf"
        Me.txtBuscarProf.Size = New System.Drawing.Size(217, 35)
        Me.txtBuscarProf.TabIndex = 36
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(1039, 94)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(149, 48)
        Me.btnBuscar.TabIndex = 37
        Me.btnBuscar.Text = "BUSCAR"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnActualizar.Font = New System.Drawing.Font("Gadugi", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.ForeColor = System.Drawing.Color.White
        Me.btnActualizar.Location = New System.Drawing.Point(268, 700)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(124, 52)
        Me.btnActualizar.TabIndex = 38
        Me.btnActualizar.Text = "ACTUALIZAR"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnEliminar.Font = New System.Drawing.Font("Gadugi", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(426, 700)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(124, 52)
        Me.btnEliminar.TabIndex = 39
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'frmAgregarProfesor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(1761, 776)
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
