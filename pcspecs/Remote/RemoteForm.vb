Public Class RemoteForm

    Private Server As RemoteSocket

    Private Sub RemoteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Server = New RemoteSocket()
        Server.StartServer()
        lb_ipServer.Text = Server.ShowServerIp()
        lb_status.Text = "ESPERANDO"
    End Sub

    Public Sub UpdateLabelStatus()
        lb_status.Text = "CONECTADO"
    End Sub

End Class

