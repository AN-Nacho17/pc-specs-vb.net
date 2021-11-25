Public Class RemoteForm

    Private Server As RemoteSocket
    Private ThreadChecker As System.Threading.Thread

    Private Sub RemoteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Server = New RemoteSocket(Me)
        lb_status.Text = "ESPERANDO"
        lb_ipAddress.Text = Server.ShowClientIP()
        ThreadChecker = New System.Threading.Thread(AddressOf CheckState)
        ThreadChecker.Start()
    End Sub

    Private Sub CheckState()
        If RemoteSocket.ClientConnected Then
            lb_status.Text = "CONECTADO"
        End If
    End Sub

End Class

