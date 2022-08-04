<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Me.txtConsola = New System.Windows.Forms.TextBox()
        Me.btnDetener = New System.Windows.Forms.Button()
        Me.btnArrancar = New System.Windows.Forms.Button()
        Me.sb = New System.Windows.Forms.StatusStrip()
        Me.pb = New System.Windows.Forms.ToolStripProgressBar()
        Me.sbLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmdLogs = New System.Windows.Forms.Button()
        Me.btnArrancar2 = New System.Windows.Forms.Button()
        Me.btnFeriados = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chkContingencia = New System.Windows.Forms.CheckBox()
        Me.sb.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtConsola
        '
        Me.txtConsola.BackColor = System.Drawing.SystemColors.Highlight
        Me.txtConsola.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConsola.ForeColor = System.Drawing.Color.Gold
        Me.txtConsola.Location = New System.Drawing.Point(12, 12)
        Me.txtConsola.Multiline = True
        Me.txtConsola.Name = "txtConsola"
        Me.txtConsola.Size = New System.Drawing.Size(584, 274)
        Me.txtConsola.TabIndex = 51
        '
        'btnDetener
        '
        Me.btnDetener.Location = New System.Drawing.Point(538, 317)
        Me.btnDetener.Name = "btnDetener"
        Me.btnDetener.Size = New System.Drawing.Size(58, 32)
        Me.btnDetener.TabIndex = 53
        Me.btnDetener.Text = "Salir"
        '
        'btnArrancar
        '
        Me.btnArrancar.Location = New System.Drawing.Point(437, 317)
        Me.btnArrancar.Name = "btnArrancar"
        Me.btnArrancar.Size = New System.Drawing.Size(95, 32)
        Me.btnArrancar.TabIndex = 52
        Me.btnArrancar.Text = "Procesar Cta Cte"
        '
        'sb
        '
        Me.sb.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pb, Me.sbLabel})
        Me.sb.Location = New System.Drawing.Point(0, 355)
        Me.sb.Name = "sb"
        Me.sb.Size = New System.Drawing.Size(602, 22)
        Me.sb.TabIndex = 54
        Me.sb.Text = "StatusStrip1"
        '
        'pb
        '
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(100, 16)
        Me.pb.Visible = False
        '
        'sbLabel
        '
        Me.sbLabel.Name = "sbLabel"
        Me.sbLabel.Size = New System.Drawing.Size(0, 17)
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'cmdLogs
        '
        Me.cmdLogs.Location = New System.Drawing.Point(11, 317)
        Me.cmdLogs.Name = "cmdLogs"
        Me.cmdLogs.Size = New System.Drawing.Size(50, 32)
        Me.cmdLogs.TabIndex = 57
        Me.cmdLogs.Text = "Logs"
        '
        'btnArrancar2
        '
        Me.btnArrancar2.Location = New System.Drawing.Point(306, 317)
        Me.btnArrancar2.Name = "btnArrancar2"
        Me.btnArrancar2.Size = New System.Drawing.Size(125, 32)
        Me.btnArrancar2.TabIndex = 58
        Me.btnArrancar2.Text = "Procesar Pago Destino"
        '
        'btnFeriados
        '
        Me.btnFeriados.Location = New System.Drawing.Point(67, 317)
        Me.btnFeriados.Name = "btnFeriados"
        Me.btnFeriados.Size = New System.Drawing.Size(58, 32)
        Me.btnFeriados.TabIndex = 59
        Me.btnFeriados.Text = "Feriados"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(131, 317)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 32)
        Me.Button1.TabIndex = 60
        Me.Button1.Text = "Dias Contingencia"
        '
        'chkContingencia
        '
        Me.chkContingencia.AutoSize = True
        Me.chkContingencia.Location = New System.Drawing.Point(12, 292)
        Me.chkContingencia.Name = "chkContingencia"
        Me.chkContingencia.Size = New System.Drawing.Size(148, 17)
        Me.chkContingencia.TabIndex = 61
        Me.chkContingencia.Text = "Procesar en Contingencia"
        Me.chkContingencia.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 377)
        Me.Controls.Add(Me.chkContingencia)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnFeriados)
        Me.Controls.Add(Me.btnArrancar2)
        Me.Controls.Add(Me.cmdLogs)
        Me.Controls.Add(Me.sb)
        Me.Controls.Add(Me.btnDetener)
        Me.Controls.Add(Me.btnArrancar)
        Me.Controls.Add(Me.txtConsola)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Text = "Accounting Hoteles"
        Me.sb.ResumeLayout(False)
        Me.sb.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents txtConsola As System.Windows.Forms.TextBox
    Public WithEvents btnDetener As System.Windows.Forms.Button
    Public WithEvents btnArrancar As System.Windows.Forms.Button
    Friend WithEvents sb As System.Windows.Forms.StatusStrip
    Friend WithEvents pb As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents sbLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Public WithEvents cmdLogs As System.Windows.Forms.Button
    Public WithEvents btnArrancar2 As System.Windows.Forms.Button
    Public WithEvents btnFeriados As System.Windows.Forms.Button
    Public WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents chkContingencia As System.Windows.Forms.CheckBox
End Class
