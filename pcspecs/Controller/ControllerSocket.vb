Imports System.Net.Sockets
Imports System.IO

Public Class ControllerSocket

    Private Client As TcpClient
    Private Const PORT As Integer = 5000
    Private OutputStream As StreamWriter
    Private InputStream As StreamReader
    Private Const InfoRequestEnd As Byte = 12
    Private Const ControlRequestEnd As Byte = 21

    Public Sub New(IpAddress As String)
        Client = New TcpClient(IpAddress, PORT)
        Try
            OutputStream = New StreamWriter(Client.GetStream)
            InputStream = New StreamReader(Client.GetStream)
            OutputStream.Flush()
        Catch ex As Exception
            Client.Close()
            MsgBox("ERROR: No se pudo establecer la conexion con el socket remoto")
        End Try
    End Sub

    Public Sub SendRequest(req As Byte)
        Dim Response As String
        If InputStream.BaseStream.CanRead And OutputStream.BaseStream.CanWrite Then
            Try
                MsgBox("Consulta realizada")
                'Caso de una solicitud de informacion
                If req <= InfoRequestEnd Then
                    Request(req)
                    Response = InputStream.ReadLine
                    If String.IsNullOrWhiteSpace(Response) = False Then
                        MsgBox(Response)
                    End If
                End If
                'Caso de una solicitud de control
                If req > InfoRequestEnd And req <= ControlRequestEnd Then
                    Request(req)
                End If
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
        Read = InputStream.ReadLine()
    End Function

    Public Sub DissconnectClient()
        Client.Close()
    End Sub

    Public Function IsConnected() As Boolean
        IsConnected = Client.Connected
    End Function


End Class
