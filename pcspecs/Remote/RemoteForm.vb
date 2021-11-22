
Public Class RemoteForm

    Private server As RemoteSocket
    Private Sub RemoteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Here the server socket class is instantiated to start with the program
        server = New RemoteSocket()
        lb_status.Text = "ESTADO: ESPERANDO POR UNA CONEXIÓN"
        server.AcceptClient() 'as this is a blocking function the next line is only to update the label
        lb_status.Text = "ESTADO: CONECTADO A UN EQUIPO CONTROLADOR IPCLIENT: " + server.ShowClientIP()
    End Sub

End Class

