Public Class RemoteForm

    Private Server As RemoteSocket

    Private Sub RemoteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Server = New RemoteSocket()
        txt_output.Enabled = False
        Server.SetRemoteForm(Me)
        Server.StartServer()
        lb_ipServer.Text = Server.ShowServerIp()
        lb_status.Text = "ESPERANDO"
    End Sub

    Public Sub UpdateLabelStatus(Status As String)
        lb_status.Text = Status
    End Sub

    Public Sub SetOutputText(Text As String)
        txt_output.Text = Text
    End Sub

End Class

