<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Feriados
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
        Me.grdFeriados = New System.Windows.Forms.DataGridView
        Me.btnGuardar = New System.Windows.Forms.Button
        CType(Me.grdFeriados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdFeriados
        '
        Me.grdFeriados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdFeriados.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.grdFeriados.Location = New System.Drawing.Point(9, 12)
        Me.grdFeriados.Name = "grdFeriados"
        Me.grdFeriados.Size = New System.Drawing.Size(209, 221)
        Me.grdFeriados.TabIndex = 3
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(138, 239)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(80, 32)
        Me.btnGuardar.TabIndex = 43
        Me.btnGuardar.Text = "Guardar"
        '
        'Feriados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(230, 274)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.grdFeriados)
        Me.Name = "Feriados"
        Me.Text = "Feriados"
        CType(Me.grdFeriados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdFeriados As System.Windows.Forms.DataGridView
    Public WithEvents btnGuardar As System.Windows.Forms.Button
End Class
