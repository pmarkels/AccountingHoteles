Public Class Logs

    Private Sub Logs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtLogs.Text = System.IO.File.ReadAllText(System.Configuration.ConfigurationManager.AppSettings("Logs") & "\Logs.txt")
        
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click

        Me.Close()

    End Sub

    Private Sub cmdLimipiar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdLimipiar.Click

        System.IO.File.WriteAllText(System.Configuration.ConfigurationManager.AppSettings("Logs") & "\Logs.txt", "")
        txtLogs.Text = ""

    End Sub
End Class