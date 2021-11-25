
Public Class RemoteForm

    Private Server As RemoteSocket

    Private Sub RemoteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Server = New RemoteSocket()
        lb_status.Text = "ESPERANDO POR UNA CONEXIÓN"
        Server.AcceptClient()
        lb_status.Text = "CONECTADO"
        lb_ipAddress.Text = Server.ShowClientIP()
    End Sub

End Class

