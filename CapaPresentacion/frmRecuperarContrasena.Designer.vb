<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecuperarContrasena
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecuperarContrasena))
        Me.lblResultadoMensaje = New System.Windows.Forms.Label()
        Me.txtCorreoUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblResultadoMensaje
        '
        Me.lblResultadoMensaje.AutoSize = True
        Me.lblResultadoMensaje.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultadoMensaje.ForeColor = System.Drawing.Color.White
        Me.lblResultadoMensaje.Location = New System.Drawing.Point(39, 137)
        Me.lblResultadoMensaje.Name = "lblResultadoMensaje"
        Me.lblResultadoMensaje.Size = New System.Drawing.Size(104, 24)
        Me.lblResultadoMensaje.TabIndex = 7
        Me.lblResultadoMensaje.Text = "Resultado"
        '
        'txtCorreoUsuario
        '
        Me.txtCorreoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreoUsuario.Location = New System.Drawing.Point(43, 79)
        Me.txtCorreoUsuario.Multiline = True
        Me.txtCorreoUsuario.Name = "txtCorreoUsuario"
        Me.txtCorreoUsuario.Size = New System.Drawing.Size(422, 40)
        Me.txtCorreoUsuario.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(39, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(353, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "INGRESE SU CORREO O SU USUARIO"
        '
        'btnEnviar
        '
        Me.btnEnviar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnEnviar.Font = New System.Drawing.Font("Gadugi", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviar.ForeColor = System.Drawing.Color.White
        Me.btnEnviar.Location = New System.Drawing.Point(486, 79)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(141, 40)
        Me.btnEnviar.TabIndex = 4
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = False
        '
        'frmRecuperarContrasena
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(645, 251)
        Me.Controls.Add(Me.lblResultadoMensaje)
        Me.Controls.Add(Me.txtCorreoUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEnviar)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRecuperarContrasena"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRecuperarContrasena"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblResultadoMensaje As System.Windows.Forms.Label
    Friend WithEvents txtCorreoUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
End Class
