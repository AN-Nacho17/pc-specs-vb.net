Imports System.Net.Sockets
Imports System.IO

'Esta clase es referente al socket del cliente donde tendra el comportamiento de un TCP
'client, es decir, los data streams para enviar y recibir mensajes del servidor.
Public Class ControllerSocket

    'Variables de clases referentes a la estructura de una clase cliente
    Private Client As TcpClient
    Private Const PORT As Integer = 5000
    Private OutputStream As StreamWriter
    Private InputStream As StreamReader
    Private Const InfoRequestEnd As Byte = 12
    Private Const ControlRequestEnd As Byte = 21

    'Constructor para crear un nuevo cliente asi como sus flujos de datos, los streams
    'para leer y escribir al servidor
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

    'Esta sub se encarga de manejar la recepcion de consultas, es decir, por cada consulta que
    'se envia esta rutina se activa para leer y mostar la informacion pertinente en cada momento.
    'Recibe la opcion que se debera enviar al servidor. 
    Public Sub SendRequest(req As Byte)
        Dim Response As String
        Try
            'Caso de una solicitud de informacion
            If req <= InfoRequestEnd Then
                Request(req)
                Response = Read()
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
    End Sub

    'Esta sub recibe la opcion que debera ser enviada al servidor y la escribira como un string
    'para luego ser casteada a byte de opcion.
    Public Sub Request(Request As Byte)
        OutputStream.WriteLine(Request)
    End Sub

    Public Sub Write(Message As String)
        OutputStream.Write(Message)
    End Sub

    Public Sub WriteLine(Request As Byte)
        OutputStream.WriteLine(Request)
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
