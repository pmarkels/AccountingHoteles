<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contingencia
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
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.grdDias = New System.Windows.Forms.DataGridView
        CType(Me.grdDias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(132, 230)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(80, 32)
        Me.btnGuardar.TabIndex = 45
        Me.btnGuardar.Text = "Guardar"
        '
        'grdDias
        '
        Me.grdDias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDias.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.grdDias.Location = New System.Drawing.Point(3, 3)
        Me.grdDias.Name = "grdDias"
        Me.grdDias.Size = New System.Drawing.Size(209, 221)
        Me.grdDias.TabIndex = 44
        '
        'Contingencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(220, 268)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.grdDias)
        Me.Name = "Contingencia"
        Me.Text = "Contingencia"
        CType(Me.grdDias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents grdDias As System.Windows.Forms.DataGridView
End Class
