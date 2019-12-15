<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnnoEscolar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnnoEscolar))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAnnoEscolar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.btnAperturar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gadugi", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(403, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "APERTURA DE AÑO ESCOLAR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(62, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "AÑO ESCOLAR"
        '
        'txtAnnoEscolar
        '
        Me.txtAnnoEscolar.Location = New System.Drawing.Point(215, 145)
        Me.txtAnnoEscolar.Name = "txtAnnoEscolar"
        Me.txtAnnoEscolar.Size = New System.Drawing.Size(151, 22)
        Me.txtAnnoEscolar.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(38, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "FECHA DE INICIO"
        '
        'dtFechaInicio
        '
        Me.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaInicio.Location = New System.Drawing.Point(215, 194)
        Me.dtFechaInicio.Name = "dtFechaInicio"
        Me.dtFechaInicio.Size = New System.Drawing.Size(112, 22)
        Me.dtFechaInicio.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(14, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(202, 24)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "FECHA DE TERMINO"
        '
        'dtFechaFin
        '
        Me.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaFin.Location = New System.Drawing.Point(215, 244)
        Me.dtFechaFin.Name = "dtFechaFin"
        Me.dtFechaFin.Size = New System.Drawing.Size(112, 22)
        Me.dtFechaFin.TabIndex = 6
        '
        'btnAperturar
        '
        Me.btnAperturar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAperturar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAperturar.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAperturar.ForeColor = System.Drawing.Color.White
        Me.btnAperturar.Location = New System.Drawing.Point(70, 291)
        Me.btnAperturar.Name = "btnAperturar"
        Me.btnAperturar.Size = New System.Drawing.Size(295, 41)
        Me.btnAperturar.TabIndex = 7
        Me.btnAperturar.Text = "APERTURAR"
        Me.btnAperturar.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(468, 49)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(147, 301)
        Me.DataGridView1.TabIndex = 8
        '
        'frmAnnoEscolar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(644, 390)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnAperturar)
        Me.Controls.Add(Me.dtFechaFin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtFechaInicio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAnnoEscolar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAnnoEscolar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAnnoEscolar"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAnnoEscolar As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnAperturar As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
