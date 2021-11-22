Imports System.Net.Sockets
Imports System.IO
Imports System.Net

Public Class ControllerSocket

    Private client As TcpClient
    Private outputStream As StreamWriter

    'Client possible requests to the server
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

    Public Sub New(hostIp As String, Port As Integer)
        client = New TcpClient(hostIp, Port)
        outputStream = New StreamWriter(client.GetStream)
        outputStream.Flush()
    End Sub

    Public Sub request(action As Byte)
        outputStream.Write(action)
    End Sub

End Class
