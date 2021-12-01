Public Class RemoteForm

    Private Server As RemoteSocket

    Private Sub RemoteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Server = New RemoteSocket()
        Server.SetRemoteForm(Me)
        Server.StartServer()
        lb_ipServer.Text = Server.ShowServerIp()
        lb_status.Text = "ESPERANDO"
    End Sub

    Public Sub UpdateLabelStatus(Status As String)
        lb_status.Text = Status
    End Sub

    Public Sub GetRemoteUserIp(IpAddres As String)
    End Sub

End Class

