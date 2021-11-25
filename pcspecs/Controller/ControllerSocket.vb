Imports System.Net.Sockets
Imports System.IO
Imports System.Net

Public Class ControllerSocket

    Private Client As TcpClient
    Private Const PORT As Integer = 5000
    Private OutputStream As StreamWriter
    Private InputStream As StreamReader

    Public Sub New(IpAddress As String)
        Try
            Client = New TcpClient(IpAddress, PORT)
            OutputStream = New StreamWriter(Client.GetStream)
            OutputStream.Flush()
        Catch ex As Exception
            MsgBox("ERROR: No se pudo establecer la conexion con el socket")
        End Try
    End Sub

    Public Sub Request(action As Byte)
        OutputStream.Write(action)
    End Sub

    Public Sub write(Message As String)
        OutputStream.Write(Message)
    End Sub

    Public Function Read()
        Read = InputStream.ReadToEnd
    End Function


End Class
