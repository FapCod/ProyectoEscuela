<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteProfesor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReporteProfesor))
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Colegio_DBDataSet = New CapaPresentacion.Colegio_DBDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cmbannoEscolar = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbtPrimaria = New System.Windows.Forms.RadioButton()
        Me.rbtinicial = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbcodseccion = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbcodGrado = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnMostrar = New System.Windows.Forms.Button()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Colegio_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.Colegio_DBDataSet
        '
        'Colegio_DBDataSet
        '
        Me.Colegio_DBDataSet.DataSetName = "Colegio_DBDataSet"
        Me.Colegio_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.DataTable1BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.rptReporteProfesor.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(1, 155)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1077, 367)
        Me.ReportViewer1.TabIndex = 0
        '
        'cmbannoEscolar
        '
        Me.cmbannoEscolar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbannoEscolar.FormattingEnabled = True
        Me.cmbannoEscolar.Location = New System.Drawing.Point(238, 71)
        Me.cmbannoEscolar.Name = "cmbannoEscolar"
        Me.cmbannoEscolar.Size = New System.Drawing.Size(143, 24)
        Me.cmbannoEscolar.TabIndex = 75
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(234, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 24)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "AÑO ESCOLAR"
        '
        'rbtPrimaria
        '
        Me.rbtPrimaria.AutoSize = True
        Me.rbtPrimaria.Location = New System.Drawing.Point(318, 125)
        Me.rbtPrimaria.Name = "rbtPrimaria"
        Me.rbtPrimaria.Size = New System.Drawing.Size(81, 21)
        Me.rbtPrimaria.TabIndex = 78
        Me.rbtPrimaria.TabStop = True
        Me.rbtPrimaria.Text = "Primaria"
        Me.rbtPrimaria.UseVisualStyleBackColor = True
        '
        'rbtinicial
        '
        Me.rbtinicial.AutoSize = True
        Me.rbtinicial.Location = New System.Drawing.Point(239, 125)
        Me.rbtinicial.Name = "rbtinicial"
        Me.rbtinicial.Size = New System.Drawing.Size(64, 21)
        Me.rbtinicial.TabIndex = 77
        Me.rbtinicial.TabStop = True
        Me.rbtinicial.Text = "Inicial"
        Me.rbtinicial.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(272, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 24)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "NIVEL"
        '
        'cmbcodseccion
        '
        Me.cmbcodseccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcodseccion.FormattingEnabled = True
        Me.cmbcodseccion.Location = New System.Drawing.Point(609, 125)
        Me.cmbcodseccion.Name = "cmbcodseccion"
        Me.cmbcodseccion.Size = New System.Drawing.Size(143, 24)
        Me.cmbcodseccion.TabIndex = 82
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(615, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 24)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "SECCION"
        '
        'cmbcodGrado
        '
        Me.cmbcodGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcodGrado.FormattingEnabled = True
        Me.cmbcodGrado.Location = New System.Drawing.Point(438, 125)
        Me.cmbcodGrado.Name = "cmbcodGrado"
        Me.cmbcodGrado.Size = New System.Drawing.Size(143, 24)
        Me.cmbcodGrado.TabIndex = 80
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(434, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 24)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "GRADO"
        '
        'btnMostrar
        '
        Me.btnMostrar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnMostrar.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrar.ForeColor = System.Drawing.Color.White
        Me.btnMostrar.Location = New System.Drawing.Point(822, 92)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(201, 57)
        Me.btnMostrar.TabIndex = 83
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = False
        '
        'frmReporteProfesor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(1077, 478)
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
        Me.Name = "frmReporteProfesor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReporteProfesor"
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Colegio_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataTable1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Colegio_DBDataSet As CapaPresentacion.Colegio_DBDataSet
    Friend WithEvents cmbannoEscolar As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbtPrimaria As System.Windows.Forms.RadioButton
    Friend WithEvents rbtinicial As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbcodseccion As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbcodGrado As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnMostrar As System.Windows.Forms.Button
End Class
