Imports System.IO
Imports System.Net.Sockets

'Clase encargada de recibir la instancia del cliente conectado y
'asignarles sus respectivos canales de datos
Public Class Connection

    Private Reader As StreamReader 'Lector de datos
    Private Writer As StreamWriter 'Escritor de datos
    Private Client As TcpClient 'Cliente que se va a conectar

    Sub New(Client As TcpClient)
        Me.Client = Client
        Reader = New StreamReader(Client.GetStream)
        Writer = New StreamWriter(Client.GetStream)
    End Sub

    'Escribe datos de vuelta al cliente segun una respuesta de los comandos
    ' y despues se limpia el canal de datos mediante un flush()
    Public Sub AnswerClient(Response As String)
        Writer.WriteLine(Response)
        Writer.Flush()
    End Sub

    'Escribe un mensaje como cadena de texto al cliente conectado
    ' y despues se limpia el canal de datos mediante un flush()
    Public Sub Write(Message As String)
        Writer.Write(Message)
        Writer.Flush()
    End Sub

    'Lee datos provenientes de un cliente conectado al servidor
    Public Function Read() As String
        Return Reader.ReadLine()
    End Function

    'Lee datos provenientes de un cliente conectado al servidor
    Public Function ReadRequest() As String
        Return Reader.ReadLine()
    End Function

    'Cierra la conexion del cliente y sus canales de envio de datos respectivos
    Public Sub CloseClient()
        Try
            Writer.Close()
            Reader.Close()
            Client.Close()
        Catch ex As Exception
        End Try
    End Sub

    'retorna un boolean segun el metodo de la libreria para saber si el cliente
    'esta o no conectado
    Public Function ClientConnected() As Boolean
        Return Client.Connected
    End Function

End Class
