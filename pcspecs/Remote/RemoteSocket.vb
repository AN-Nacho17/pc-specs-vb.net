Imports System.Net.Sockets
Imports System.Net
Imports System.IO
Imports System.Threading
Public Class RemoteSocket

    'Server socket variables
    Private IpAddress As IPAddress
    Private PORT As Integer = 8888
    Private ServerSocket As TcpListener
    Private RequestResponser As Threading.Thread
    Private StopListen As Boolean = False
    Private RemoteForm As RemoteForm
    Public Shared ClientConnected As Boolean = False

    'Server possible requests to response
    Private SO_COMPLETE_NAME As Byte = 1
    Private SO_PLATFORM As Byte = 2
    Private SO_VERSION As Byte = 3
    Private PC_NAME As Byte = 4
    Private CPU_INFO As Byte = 5
    Private TOTAL_RAM As Byte = 6
    Private DISC_UNITS_LIST As Byte = 7 'Neccesary to show some things
    Private SCREEN_RESOLUTION As Byte = 8
    Private LOGGED_USER_NAME As Byte = 9
    Private SYSTEM_REGION_ZONE As Byte = 10
    Private DATE_AND_TIME As Byte = 11
    Private PROCESS_RUNNING_LIST As Byte = 12
    Private TAKE_SCREESHOT As Byte = 13
    Private SEND_MESSAGE As Byte = 14
    Private Const VOL_UP As Byte = 15
    Private Const VOL_DOWN As Byte = 16
    Private Const MUTE_AUDIO As Byte = 17
    Private Const SHUTDOWN As Byte = 18
    Private Const RESTART As Byte = 19
    Private Const CLOSE_SESSION As Byte = 20

    'Clients that gonna be connected in server
    Private Client As TcpClient
    Private ClientData As NetworkStream

    Public Sub New(RemoteForm As RemoteForm)
        Me.RemoteForm = RemoteForm
        'GetIP()
        IpAddress = IPAddress.Parse("127.0.0.1")
        ServerSocket = New TcpListener(IpAddress, PORT)
        RequestResponser = New Threading.Thread(AddressOf ResponseRequest)
        StartListen()
    End Sub

    Public Function ShowClientIP() As String
        Return IpAddress.ToString
    End Function

    Public Sub StartListen()
        ServerSocket.Start()
        RequestResponser.Start()
    End Sub

    Public Sub AcceptClient()
        Client = ServerSocket.AcceptTcpClient()
        ClientConnected = True
    End Sub

    Public Sub GetStreams()
        ClientData = Client.GetStream()
    End Sub

    Private Sub CloseConnection()
        Client.Close()
        ServerSocket.Stop()
        ClientConnected = False
    End Sub

    Private Sub GetIP()
        Dim Ipv4String As String = ""
        Dim Ipv4 As IPAddress() = Dns.GetHostAddresses(Dns.GetHostName)
        For Each address As IPAddress In Ipv4
            If address.AddressFamily = AddressFamily.InterNetwork Then
                Ipv4String = address.ToString()
            End If
        Next
        IpAddress = IPAddress.Parse(Ipv4String)
    End Sub

    Private Sub ResponseRequest()
        AcceptClient()
        GetStreams()
        While StopListen = False
            If (ServerSocket.Pending = True) Then
                'Logica para atender las consultas
            End If
            Thread.Sleep(150)
        End While
    End Sub

End Class
