Public Class Feriados

    Private Sub Feriados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim oDs As Data.DataSet

        oDs = New DataSet
        oDs.ReadXml(System.Configuration.ConfigurationManager.AppSettings("Datos") & "\Feriados.xml")
        grdFeriados.DataSource = oDs.Tables(0)
        grdFeriados.Refresh()

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Dim oDs As Data.DataSet
        Dim oDt As DataTable

        oDs = New Data.DataSet("Feriados")
        oDt = grdFeriados.DataSource
        oDt.TableName = "Feriado"
        oDs.Tables.Add(oDt.Copy)
        oDs.WriteXml(System.Configuration.ConfigurationManager.AppSettings("Datos") & "\Feriados.xml")
        oDt = Nothing
        oDs = Nothing
        Me.Close()

    End Sub
End Class