Imports System.IO
Imports System.Net.Sockets

Public Class Connection

    Private Reader As StreamReader
    Private Writer As StreamWriter
    Private Client As TcpClient

    Sub New(Client As TcpClient)
        Me.Client = Client
        Reader = New StreamReader(Client.GetStream)
        Writer = New StreamWriter(Client.GetStream)
    End Sub

    Public Sub AnswerClient(Response As String)
        Writer.Write(Response)
    End Sub

    Public Sub Write(Message As String)
        Writer.Write(Message)
    End Sub

    Public Sub WriteObject(Bitmap As Bitmap)
    End Sub

    Public Function Read() As String
        Read = Reader.ReadLine()
    End Function

    Public Function ReadRequest() As Byte
        Dim StringRequest = Reader.ReadLine
        Dim ParsedRequest = Convert.ToByte(StringRequest)
        ReadRequest = ParsedRequest
    End Function

    Public Sub CloseClient()
        Try
            Client.Close()
        Catch ex As Exception
        End Try
    End Sub

    Public Function ClientConnected() As Boolean
        Return Client.Connected
    End Function

End Class
