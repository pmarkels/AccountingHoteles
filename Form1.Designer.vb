<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.ItinerarioDataSet = New AccountingHoteles.ItinerarioDataSet
        Me.ItinerarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItinerarioTableAdapter = New AccountingHoteles.ItinerarioDataSetTableAdapters.ItinerarioTableAdapter
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        CType(Me.ItinerarioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItinerarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ItinerarioDataSet
        '
        Me.ItinerarioDataSet.DataSetName = "ItinerarioDataSet"
        Me.ItinerarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItinerarioBindingSource
        '
        Me.ItinerarioBindingSource.DataMember = "Itinerario"
        Me.ItinerarioBindingSource.DataSource = Me.ItinerarioDataSet
        '
        'ItinerarioTableAdapter
        '
        Me.ItinerarioTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "ItinerarioDataSet_Itinerario"
        ReportDataSource1.Value = Me.ItinerarioBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AccountingHoteles.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(865, 470)
        Me.ReportViewer1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 494)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ItinerarioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItinerarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ItinerarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItinerarioDataSet As AccountingHoteles.ItinerarioDataSet
    Friend WithEvents ItinerarioTableAdapter As AccountingHoteles.ItinerarioDataSetTableAdapters.ItinerarioTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
