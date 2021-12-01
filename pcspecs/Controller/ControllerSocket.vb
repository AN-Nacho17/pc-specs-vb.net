﻿Imports System.Net.Sockets
Imports System.IO

'Esta clase es referente al socket del cliente donde tendra el comportamiento de un TCP
'client, es decir, los data streams para enviar y recibir mensajes del servidor.
Public Class ControllerSocket

    'Variables de clases referentes a la estructura de una clase cliente
    Private Client As TcpClient
    Private Const PORT As Integer = 5000
    Private Writer As StreamWriter
    Private Reader As StreamReader

    'Constructor para crear un nuevo cliente asi como sus flujos de datos, los streams
    'para leer y escribir al servidor
    Public Sub New(IpAddress As String)
        Try
            Client = New TcpClient(IpAddress, PORT)
            Writer = New StreamWriter(Client.GetStream)
            Reader = New StreamReader(Client.GetStream)
            Writer.Flush()
        Catch ex As Exception
            Client.Close()
            MsgBox("ERROR: No se pudo establecer la conexion con el socket remoto")
        End Try
    End Sub

    'Esta sub recibe la opcion que debera ser enviada al servidor y la escribira como un string
    'para luego ser casteada a byte de opcion.
    Public Sub Request(Request As String)
        Writer.WriteLine(Request)
        Writer.Flush()
    End Sub

    Public Sub Write(Message As String)
        Writer.Write(Message)
        Writer.Flush()

    End Sub

    Public Sub WriteLine(Request As String)
        Writer.WriteLine(Request)
        Writer.Flush()
    End Sub

    Public Function Read() As String
        Return Reader.ReadLine()
    End Function

    Public Sub DissconnectClient()
        Writer.Close()
        Reader.Close()
        Client.Close()
    End Sub

    Public Function IsConnected() As Boolean
        IsConnected = Client.Connected
    End Function


End Class
