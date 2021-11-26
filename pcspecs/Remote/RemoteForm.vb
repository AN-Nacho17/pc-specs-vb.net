Public Class RemoteForm

    Private Server As RemoteSocket

    Private Sub RemoteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Server = New RemoteSocket()
        Server.SetRemoteForm(Me)
        lb_status.Text = "ESPERANDO"
        lb_ipAddress.Text = Server.ShowClientIP()
    End Sub


End Class

