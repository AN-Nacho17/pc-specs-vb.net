Imports System.Net.Sockets
Imports System.Net
Imports System.IO

Public Class RemoteSocket

    'Server socket variables
    Private ServerIpAddress As IPAddress
    Private ClientIpAddress As IPAddress
    Private PORT As Integer = 5000
    Private Server As TcpListener
    Private ServerRunning As Boolean
    Private Client As TcpClient
    Private ConnectionThread As Threading.Thread

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


    Public Sub New()
        'GetIP() for testing only on local host
        ServerIpAddress = IPAddress.Parse("127.0.0.1")
    End Sub

    Public Sub StartServer()
        Try
            Server = New TcpListener(ServerIpAddress, PORT)
            Server.Start()
            ServerRunning = True
            ConnectionThread = New Threading.Thread(AddressOf ResponseRequest)
            ConnectionThread.Start()
        Catch ex As Exception
            MsgBox("ERROR: No se pudo iniciar el servidor")
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

    Private Sub CloseConnectionWithClient()
        Try
            Client.Close()
            MsgBox("Conexion terminada con el cliente")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ResponseRequest()
        Dim InputStream As StreamReader
        Dim OutputStream As StreamWriter
        Dim Request As String
        Dim ParsedRequest As Byte
        Try
            If (ServerRunning) Then
                Client = Server.AcceptTcpClient
                InputStream = New StreamReader(Client.GetStream)
                OutputStream = New StreamWriter(Client.GetStream)
                ClientIpAddress = IPAddress.Parse(InputStream.ReadLine)
                MsgBox(ClientIpAddress.ToString)
                While InputStream.BaseStream.CanRead And OutputStream.BaseStream.CanWrite
                    Request = InputStream.ReadLine
                    ParsedRequest = Convert.ToByte(Request)
                    MsgBox("PARSED REQUEST: " + ParsedRequest)
                End While
            End If
        Catch ex As Exception
            CloseConnectionWithClient()
        End Try
    End Sub


End Class
