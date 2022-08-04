Public Class Contingencia

    Private Sub Contingencia_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim oDs As Data.DataSet

        oDs = New DataSet
        oDs.ReadXml(System.Configuration.ConfigurationManager.AppSettings("Datos") & "\DiasContingencia.xml")
        grdDias.DataSource = oDs.Tables(0)
        grdDias.Refresh()

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Dim oDs As Data.DataSet
        Dim oDt As DataTable

        oDs = New Data.DataSet("Dias")
        oDt = grdDias.DataSource
        oDt.TableName = "Dia"
        oDs.Tables.Add(oDt.Copy)
        oDs.WriteXml(System.Configuration.ConfigurationManager.AppSettings("Datos") & "\DiasContingencia.xml")
        oDt = Nothing
        oDs = Nothing
        Me.Close()

    End Sub
End Class