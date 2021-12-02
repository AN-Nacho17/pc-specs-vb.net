Imports System.Net.Sockets
Imports System.Net
Imports System.Threading
Imports System.IO

Public Class RemoteSocket

    Private ServerIpAddress As IPAddress
    Private Const PORT As Integer = 5000
    Private Server As TcpListener
    Private ServerRunning As Boolean
    Private Client As TcpClient
    Private RequestManager As RequestManager
    Private RemoteForm As RemoteForm
    Private ClientReceiver As Thread

    Public Sub New()
        GetIP() 'For testing only On local host
        'ServerIpAddress = IPAddress.Parse("127.0.0.1")
    End Sub

    Public Sub SetRemoteForm(RemoteForm As RemoteForm)
        Me.RemoteForm = RemoteForm
    End Sub

    Public Sub StartServer()
        Try
            Control.CheckForIllegalCrossThreadCalls = False
            Server = New TcpListener(ServerIpAddress, PORT)
            Server.Start()
            ServerRunning = True
            ClientReceiver = New Thread(AddressOf WaitForConnection)
            ClientReceiver.Start()
        Catch ex As Exception
            MsgBox("ERROR: No se pudo iniciar el servidor")
            Server.Stop()
            ServerRunning = False
        End Try
    End Sub

    Private Sub WaitForConnection()
        Try
            While ServerRunning
                Client = Server.AcceptTcpClient
                RemoteForm.UpdateLabelStatus("CONECTADO")
                RequestManager = New RequestManager(New Connection(Client))
                RequestManager.SetRemoteForm(RemoteForm)
                RequestManager.StartResponse()
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GetIP()
        Dim Ipv4String As String = ""
        Dim Ipv4 As IPAddress() = Dns.GetHostAddresses(Dns.GetHostName)
        For Each address As IPAddress In Ipv4
            If address.AddressFamily = AddressFamily.InterNetwork Then
                Ipv4String = address.ToString()
            End If
        Next
        ServerIpAddress = IPAddress.Parse(Ipv4String)
    End Sub

    Public Function ShowServerIp() As String
        Return ServerIpAddress.ToString
    End Function

End Class
