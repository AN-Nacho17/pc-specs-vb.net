Imports System.Net.Sockets
Imports System.IO

Public Class ControllerSocket

    Private Client As TcpClient
    Private Const PORT As Integer = 5000
    Private OutputStream As StreamWriter
    Private InputStream As StreamReader
    Private ClientConnected As Boolean

    Public Sub New(IpAddress As String)
        Try
            Client = New TcpClient(IpAddress, PORT)
            If Client.GetStream.CanRead And Client.GetStream.CanWrite Then
                OutputStream = New StreamWriter(Client.GetStream)
                InputStream = New StreamReader(Client.GetStream)
                ClientConnected = True
            End If
        Catch ex As Exception
            Client.Close()
            ClientConnected = False
            MsgBox("ERROR: No se pudo establecer la conexion con el socket remoto")
        End Try
    End Sub

    Public Sub SendRequest(req As Byte)
        If InputStream.BaseStream.CanRead And OutputStream.BaseStream.CanWrite Then
            Try
                Request(req)
                MsgBox(req)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Request(Request As Byte)
        Dim ParsedToStringRequest = Convert.ToString(Request)
        OutputStream.WriteLine(ParsedToStringRequest)
    End Sub

    Public Sub Write(Message As String)
        OutputStream.WriteLine(Message)
    End Sub

    Public Function Read()
        Read = InputStream.ReadToEnd()
    End Function

    Public Sub DissconnectClient()
        ClientConnected = False
    End Sub

    Public Function IsConnected() As Boolean
        IsConnected = ClientConnected
    End Function


End Class
