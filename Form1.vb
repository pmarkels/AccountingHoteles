Imports Microsoft.Reporting.WinForms
Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ItinerarioDataSet.Itinerario' table. You can move, or remove it, as needed.
        Me.ItinerarioTableAdapter.Fill(Me.ItinerarioDataSet.Itinerario)

        'Dim ReportViewer1 As New ReportViewer

        'ReportViewer1.LocalReport.ReportPath = "C:\Desarrollos\WebServicesSabre\AccountingHoteles\Report1.rdlc"

        ReportViewer1.LocalReport.EnableExternalImages = True


        Dim parameters As New List(Of ReportParameter)()
        parameters.Add(New ReportParameter("Nombre", "Pablo Markels"))
        parameters.Add(New ReportParameter("Reserva", "SDKSDFS"))

        ReportViewer1.LocalReport.SetParameters(parameters)
        ReportViewer1.Refresh()

        'Dim deviceInfo As String = ""
        'Dim mimeType As String = ""
        'Dim encoding As String = ""
        'Dim fileNameExtension As String = ""
        'Dim streams() As String
        'Dim warnings() As Microsoft.Reporting.WinForms.Warning
        'Dim bytes() As Byte
        'Dim file As System.IO.FileStream

        'bytes = ReportViewer1.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, fileNameExtension, streams, warnings)

        'file = New System.IO.FileStream("c:\pruebareport3.pdf", IO.FileMode.Create)

        'file.Write(bytes, 0, bytes.Length)

        'file.Close()

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class