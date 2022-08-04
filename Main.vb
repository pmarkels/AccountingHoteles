Imports WebServicesSabre.Tablas

Public Class Main

    Private WithEvents ColasOrigen As WebServicesSabre.Colas
    Private Errores As String = ""
    Private EsCuentaCorriente As Boolean
    Private Cookies As System.Net.CookieContainer

    Private Sub Main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        ColasOrigen.Detener()
        ColasOrigen.CerrarSesion()

    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ColasOrigen = New WebServicesSabre.Colas()

    End Sub

    Private Sub btnArrancar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnArrancar.Click

        If WebServicesSabre.Tablas.Empresas.CargarEmpresas(Errores) Then

            sbLabel.Text = "Iniciando..."
            pb.Visible = True
            pb.Maximum = 10
            btnArrancar.Enabled = False
            btnArrancar2.Enabled = False
            EsCuentaCorriente = True
            btnDetener.Text = "Detener"
            ColasOrigen.EsCuentaCorriente = EsCuentaCorriente
            ColasOrigen.ProcesarEnContingencia = chkContingencia.Checked

            Me.Text = "Accounting Hoteles - Procesando Cuenta Corriente"

            ColasOrigen.ProcesarColas(Errores)

            Me.Text = "Accounting Hoteles"
            sbLabel.Text = "Detenido"
            pb.Value = 0
            pb.Visible = False
            btnArrancar.Enabled = True
            btnArrancar2.Enabled = True
            btnDetener.Text = "Salir"
            txtConsola.Text = ""

        Else
            txtConsola.Text = Errores
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Timer1.Stop()

        If Not ColasOrigen.Detenido Then
            sbLabel.Text = "Procesando..."
            Application.DoEvents()

            Errores = ""
            ColasOrigen.EsCuentaCorriente = EsCuentaCorriente
            ColasOrigen.ProcesarEnContingencia = chkContingencia.Checked
            ColasOrigen.ProcesarColas(Errores)
            Timer1.Start()
            Application.DoEvents()
        End If

    End Sub

    Private Sub btnDetener_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDetener.Click

        Dim sStatus As String = ""

        If btnDetener.Text = "Detener" Then
            ColasOrigen.Detener()
            'Timer1.Stop()
            sbLabel.Text = "Detenido"
            pb.Value = 0
            pb.Visible = False
            btnArrancar.Enabled = True
            btnArrancar2.Enabled = True
            btnDetener.Text = "Salir"
            txtConsola.Text = ""

        Else
            ColasOrigen.CerrarSesion()
            End
        End If

    End Sub

    Private Sub ColasOrigen_ActualizarPantalla(ByVal Status As String, ByVal Texto As String) Handles ColasOrigen.ActualizarPantalla

        'If Not ColasOrigen.Detenido Then
        sbLabel.Text = Status
        Texto = Status & vbCrLf & "-----------------------" & vbCrLf & Texto
        txtConsola.Text = Texto

        If pb.Visible Then
            If pb.Value < 9 Then
                pb.Value = pb.Value + 1
            Else
                pb.Value = 0
            End If
        End If
        Application.DoEvents()
        'End If

    End Sub

    Private Sub cmdLogs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogs.Click

        Logs.Show()

    End Sub

    Private Sub btnArrancar2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnArrancar2.Click
        If WebServicesSabre.Tablas.Empresas.CargarEmpresas(Errores) Then

            sbLabel.Text = "Iniciando..."
            pb.Visible = True
            pb.Maximum = 10
            btnArrancar.Enabled = False
            btnArrancar2.Enabled = False
            EsCuentaCorriente = False
            btnDetener.Text = "Detener"
            ColasOrigen.EsCuentaCorriente = EsCuentaCorriente
            ColasOrigen.ProcesarEnContingencia = chkContingencia.Checked
            Me.Text = "Accounting Hoteles - Procesando Pago en Destino"
            ColasOrigen.ProcesarColas(Errores)
            Me.Text = "Accounting Hoteles"
            sbLabel.Text = "Detenido"
            pb.Value = 0
            pb.Visible = False
            btnArrancar.Enabled = True
            btnArrancar2.Enabled = True
            btnDetener.Text = "Salir"
            txtConsola.Text = ""
        Else
            txtConsola.Text = Errores
        End If
    End Sub

    Private Sub btnFeriados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFeriados.Click

        Feriados.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Contingencia.Show()

    End Sub

End Class