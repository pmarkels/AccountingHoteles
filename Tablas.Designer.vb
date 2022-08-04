<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tablas
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
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.grdTextos = New System.Windows.Forms.DataGridView
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.grdAreas = New System.Windows.Forms.DataGridView
        Me.grdDKNumbers = New System.Windows.Forms.DataGridView
        Me.DKNumber = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TMA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Empresa = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ARAcuerdoCabotaje = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.LANAcuerdoCabotaje = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.AcuerdoInternacional = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.grdTextos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdAreas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDKNumbers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(2, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(599, 412)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.grdAreas)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(591, 386)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Areas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.grdTextos)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(591, 386)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Textos Error"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'grdTextos
        '
        Me.grdTextos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdTextos.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.grdTextos.Location = New System.Drawing.Point(6, 6)
        Me.grdTextos.MultiSelect = False
        Me.grdTextos.Name = "grdTextos"
        Me.grdTextos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdTextos.Size = New System.Drawing.Size(579, 360)
        Me.grdTextos.TabIndex = 3
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(521, 430)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(80, 32)
        Me.btnSalir.TabIndex = 41
        Me.btnSalir.Text = "Salir"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(268, 432)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(80, 32)
        Me.btnGuardar.TabIndex = 42
        Me.btnGuardar.Text = "Guardar"
        '
        'grdAreas
        '
        Me.grdAreas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdAreas.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.grdAreas.Location = New System.Drawing.Point(6, 6)
        Me.grdAreas.Name = "grdAreas"
        Me.grdAreas.Size = New System.Drawing.Size(579, 374)
        Me.grdAreas.TabIndex = 3
        '
        'grdDKNumbers
        '
        Me.grdDKNumbers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDKNumbers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DKNumber, Me.TMA, Me.Empresa, Me.ARAcuerdoCabotaje, Me.LANAcuerdoCabotaje, Me.AcuerdoInternacional})
        Me.grdDKNumbers.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.grdDKNumbers.Location = New System.Drawing.Point(16, 51)
        Me.grdDKNumbers.Name = "grdDKNumbers"
        Me.grdDKNumbers.Size = New System.Drawing.Size(579, 374)
        Me.grdDKNumbers.TabIndex = 43
        Me.grdDKNumbers.Visible = False
        '
        'DKNumber
        '
        Me.DKNumber.HeaderText = "DK Number"
        Me.DKNumber.Name = "DKNumber"
        Me.DKNumber.Width = 70
        '
        'TMA
        '
        Me.TMA.HeaderText = "Codigo TMA"
        Me.TMA.Name = "TMA"
        Me.TMA.Width = 70
        '
        'Empresa
        '
        Me.Empresa.HeaderText = "Empresa"
        Me.Empresa.Name = "Empresa"
        Me.Empresa.Width = 70
        '
        'ARAcuerdoCabotaje
        '
        Me.ARAcuerdoCabotaje.HeaderText = "AR Acuerdo Cabotaje"
        Me.ARAcuerdoCabotaje.Items.AddRange(New Object() {"", "General", "Acuerdo Over"})
        Me.ARAcuerdoCabotaje.Name = "ARAcuerdoCabotaje"
        Me.ARAcuerdoCabotaje.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ARAcuerdoCabotaje.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'LANAcuerdoCabotaje
        '
        Me.LANAcuerdoCabotaje.HeaderText = "LAN Acuerdo Cabotaje"
        Me.LANAcuerdoCabotaje.Items.AddRange(New Object() {"", "Tiene Acuerdo"})
        Me.LANAcuerdoCabotaje.Name = "LANAcuerdoCabotaje"
        Me.LANAcuerdoCabotaje.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LANAcuerdoCabotaje.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'AcuerdoInternacional
        '
        Me.AcuerdoInternacional.HeaderText = "Acuerdo Internacional"
        Me.AcuerdoInternacional.Items.AddRange(New Object() {"", "Tiene Acuerdo"})
        Me.AcuerdoInternacional.Name = "AcuerdoInternacional"
        Me.AcuerdoInternacional.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AcuerdoInternacional.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Tablas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 476)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.grdDKNumbers)
        Me.Name = "Tablas"
        Me.Text = "Tablas"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.grdTextos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdAreas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDKNumbers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents btnSalir As System.Windows.Forms.Button
    Public WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents grdTextos As System.Windows.Forms.DataGridView
    Friend WithEvents grdAreas As System.Windows.Forms.DataGridView
    Friend WithEvents grdDKNumbers As System.Windows.Forms.DataGridView
    Friend WithEvents DKNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TMA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Empresa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ARAcuerdoCabotaje As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents LANAcuerdoCabotaje As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents AcuerdoInternacional As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
