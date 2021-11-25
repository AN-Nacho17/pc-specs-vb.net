Imports System.Net.Sockets
Imports System.Net
Imports System.IO
Imports System.Threading
Public Class RemoteSocket

    'Server socket variables
    Private ipAddress As IPAddress
    Private PORT As Integer = 5000
    Private serverSocket As TcpListener
    Private requestResponser As Threading.Thread
    Private stopListen As Boolean = False

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
    Private client As TcpClient
    Private clientData As StreamReader

    Public Sub New()
        GetIPAddress()
        serverSocket = New TcpListener(ipAddress, PORT)
        StartListen()
        'We create the thread whose function is to attend the request
        requestResponser = New Threading.Thread(AddressOf ResponseRequest)
    End Sub

    Public Function ShowClientIP() As String
        Return ipAddress.ToString
    End Function

    Public Sub StartListen()
        serverSocket.Start()
        requestResponser.Start()
    End Sub

    Public Sub AcceptClient()
        client = serverSocket.AcceptTcpClient()
    End Sub

    Public Sub AcceptRequest()
        clientData = New StreamReader(client.GetStream)
    End Sub

    Private Sub CloseConnection()

    End Sub

    Private Sub GetIPAddress()
        Dim strHostName As String
        Dim strIPAddress As String
        strHostName = System.Net.Dns.GetHostName()
        strIPAddress = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        ipAddress = IPAddress.Parse(strIPAddress)
        'Este mensaje se muestra en el form
        MessageBox.Show("IP Address: " & strIPAddress)
    End Sub

    Private Sub ResponseRequest()
        While stopListen = True
            If (serverSocket.Pending = True) Then
                AcceptClient()
                AcceptRequest()
            End If
            Thread.Sleep(150)
        End While
    End Sub

End Class
