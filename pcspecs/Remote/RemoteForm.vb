
Public Class RemoteForm

    Private server As RemoteSocket
    Private controlMod As New SystemControlModule

    Private Sub RemoteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim sysmanager = New SystemInfoModule
        'MsgBox(sysmanager.getComputerName())
        'Here the server socket class is instantiated to start with the program
        'server = New RemoteSocket()
        'lb_status.Text = "ESPERANDO POR UNA CONEXIÓN"
        'server.AcceptClient() 'as this is a blocking function the next line is only to update the label
        'lb_status.Text = "CONECTADO A UN EQUIPO CONTROLADOR IPCLIENT: "
        'lb_ipAddress.Text = server.ShowClientIP()
        controlMod.shellCall("ipconfig")
    End Sub

End Class

