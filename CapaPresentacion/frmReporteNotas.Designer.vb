<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteNotas
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReporteNotas))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cmbannoEscolar = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbtPrimaria = New System.Windows.Forms.RadioButton()
        Me.rbtinicial = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbcodGrado = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbcodseccion = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbcodigocurso = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Colegio_DBDataSet2 = New CapaPresentacion.Colegio_DBDataSet2()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.Colegio_DBDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.DataTable1BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.rptReporteNotas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-5, 151)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1213, 397)
        Me.ReportViewer1.TabIndex = 0
        '
        'cmbannoEscolar
        '
        Me.cmbannoEscolar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbannoEscolar.FormattingEnabled = True
        Me.cmbannoEscolar.Location = New System.Drawing.Point(180, 113)
        Me.cmbannoEscolar.Name = "cmbannoEscolar"
        Me.cmbannoEscolar.Size = New System.Drawing.Size(143, 24)
        Me.cmbannoEscolar.TabIndex = 77
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(176, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 24)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "AÑO ESCOLAR"
        '
        'rbtPrimaria
        '
        Me.rbtPrimaria.AutoSize = True
        Me.rbtPrimaria.Location = New System.Drawing.Point(266, 36)
        Me.rbtPrimaria.Name = "rbtPrimaria"
        Me.rbtPrimaria.Size = New System.Drawing.Size(81, 21)
        Me.rbtPrimaria.TabIndex = 81
        Me.rbtPrimaria.TabStop = True
        Me.rbtPrimaria.Text = "Primaria"
        Me.rbtPrimaria.UseVisualStyleBackColor = True
        '
        'rbtinicial
        '
        Me.rbtinicial.AutoSize = True
        Me.rbtinicial.Location = New System.Drawing.Point(187, 36)
        Me.rbtinicial.Name = "rbtinicial"
        Me.rbtinicial.Size = New System.Drawing.Size(64, 21)
        Me.rbtinicial.TabIndex = 80
        Me.rbtinicial.TabStop = True
        Me.rbtinicial.Text = "Inicial"
        Me.rbtinicial.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(220, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 24)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "NIVEL"
        '
        'cmbcodGrado
        '
        Me.cmbcodGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcodGrado.FormattingEnabled = True
        Me.cmbcodGrado.Location = New System.Drawing.Point(351, 115)
        Me.cmbcodGrado.Name = "cmbcodGrado"
        Me.cmbcodGrado.Size = New System.Drawing.Size(143, 24)
        Me.cmbcodGrado.TabIndex = 83
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(347, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 24)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "GRADO"
        '
        'cmbcodseccion
        '
        Me.cmbcodseccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcodseccion.FormattingEnabled = True
        Me.cmbcodseccion.Location = New System.Drawing.Point(510, 115)
        Me.cmbcodseccion.Name = "cmbcodseccion"
        Me.cmbcodseccion.Size = New System.Drawing.Size(143, 24)
        Me.cmbcodseccion.TabIndex = 85
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(516, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 24)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "SECCION"
        '
        'btnMostrar
        '
        Me.btnMostrar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnMostrar.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrar.ForeColor = System.Drawing.Color.White
        Me.btnMostrar.Location = New System.Drawing.Point(739, 88)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(201, 57)
        Me.btnMostrar.TabIndex = 86
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = False
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(50, 100)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(100, 22)
        Me.txtDni.TabIndex = 87
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(73, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 24)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "DNI"
        '
        'cmbcodigocurso
        '
        Me.cmbcodigocurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcodigocurso.FormattingEnabled = True
        Me.cmbcodigocurso.Location = New System.Drawing.Point(351, 47)
        Me.cmbcodigocurso.Name = "cmbcodigocurso"
        Me.cmbcodigocurso.Size = New System.Drawing.Size(143, 24)
        Me.cmbcodigocurso.TabIndex = 90
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(347, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 24)
        Me.Label5.TabIndex = 89
        Me.Label5.Text = "CURSO"
        '
        'Colegio_DBDataSet2
        '
        Me.Colegio_DBDataSet2.DataSetName = "Colegio_DBDataSet2"
        Me.Colegio_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.Colegio_DBDataSet2
        '
        'frmReporteNotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(1208, 545)
        Me.Controls.Add(Me.cmbcodigocurso)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDni)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.cmbcodseccion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbcodGrado)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.rbtPrimaria)
        Me.Controls.Add(Me.rbtinicial)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbannoEscolar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReporteNotas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReporteNotas"
        CType(Me.Colegio_DBDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cmbannoEscolar As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbtPrimaria As System.Windows.Forms.RadioButton
    Friend WithEvents rbtinicial As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbcodGrado As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbcodseccion As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnMostrar As System.Windows.Forms.Button
    Friend WithEvents txtDni As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbcodigocurso As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataTable1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Colegio_DBDataSet2 As CapaPresentacion.Colegio_DBDataSet2
End Class
