<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Logs
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
        Me.txtLogs = New System.Windows.Forms.TextBox
        Me.cmdLimipiar = New System.Windows.Forms.Button
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.cmdImprimir = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtLogs
        '
        Me.txtLogs.Location = New System.Drawing.Point(12, 12)
        Me.txtLogs.Multiline = True
        Me.txtLogs.Name = "txtLogs"
        Me.txtLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLogs.Size = New System.Drawing.Size(470, 321)
        Me.txtLogs.TabIndex = 0
        '
        'cmdLimipiar
        '
        Me.cmdLimipiar.Location = New System.Drawing.Point(12, 339)
        Me.cmdLimipiar.Name = "cmdLimipiar"
        Me.cmdLimipiar.Size = New System.Drawing.Size(80, 29)
        Me.cmdLimipiar.TabIndex = 1
        Me.cmdLimipiar.Text = "Limpiar"
        Me.cmdLimipiar.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(400, 339)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(80, 29)
        Me.cmdSalir.TabIndex = 2
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Location = New System.Drawing.Point(98, 339)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(80, 29)
        Me.cmdImprimir.TabIndex = 3
        Me.cmdImprimir.Text = "Imprimir"
        Me.cmdImprimir.UseVisualStyleBackColor = True
        '
        'Logs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 373)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdLimipiar)
        Me.Controls.Add(Me.txtLogs)
        Me.Name = "Logs"
        Me.Text = "Logs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLogs As System.Windows.Forms.TextBox
    Friend WithEvents cmdLimipiar As System.Windows.Forms.Button
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdImprimir As System.Windows.Forms.Button
End Class
