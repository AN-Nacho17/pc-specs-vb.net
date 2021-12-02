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
        Writer.WriteLine(Response)
        Writer.Flush()
    End Sub

    Public Sub Write(Message As String)
        Writer.Write(Message)
        Writer.Flush()
    End Sub

    Public Sub WriteObject(Bitmap As Bitmap)
    End Sub

    Public Function Read() As String
        Return Reader.ReadLine()
    End Function

    Public Function ReadRequest() As String
        Return Reader.ReadLine()
    End Function

    Public Sub CloseClient()
        Try
            Writer.Close()
            Reader.Close()
            Client.Close()
        Catch ex As Exception
        End Try
    End Sub

    Public Function ClientConnected() As Boolean
        Return Client.Connected
    End Function

End Class
