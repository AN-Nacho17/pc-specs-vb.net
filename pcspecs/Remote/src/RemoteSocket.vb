Imports System.Net.Sockets
Imports System.Net
Imports System.Threading
Imports System.IO

'Clase que asume el papel del servidor
'el servidor escucha en un puerto y IP determinados
'acepta y atiene cliente y solicitudes segun la peticion
'requiere de dos hilos para su funcionamiento, uno para aceptar cliente
'y otro para atender las peticiones
Public Class RemoteSocket

    Private ServerIpAddress As IPAddress
    Private Const PORT As Integer = 5000
    Private Server As TcpListener
    Private ServerRunning As Boolean
    Private Client As TcpClient
    Private RequestManager As RequestManager
    Private RemoteForm As RemoteForm
    Private ClientReceiver As Thread

    Public Sub New()
        'GetIP() 'For testing only On local host
        ServerIpAddress = IPAddress.Parse("127.0.0.1")
    End Sub

    'Metodo para establecer la instancia de la ventana del equipo remoto
    'en funcion de cambiar etiquetas segun el estado
    Public Sub SetRemoteForm(RemoteForm As RemoteForm)
        Me.RemoteForm = RemoteForm
    End Sub

    'Metod que se encarga de iniciar el hilo para la aceptacion de los clientes y 
    ' respecto a ese cliente asignarle el hilo para su atencion de consultas
    Public Sub StartServer()
        Try
            Control.CheckForIllegalCrossThreadCalls = False
            Server = New TcpListener(IPAddress.Any, PORT)
            Server.Start()
            ServerRunning = True
            ClientReceiver = New Thread(AddressOf WaitForConnection)
            ClientReceiver.Start()
        Catch ex As Exception
            MsgBox("ERROR: No se pudo iniciar el servidor")
            Server.Stop()
            ServerRunning = False
        End Try
    End Sub

    'Metodo que se encarga de esperar y aceptar un cliente mediante el metodo
    'AcceptTcpClient(), y con la instancia de la ventaja, cambiar la etiqueta de estado
    'ademas se crea la instancia de la clase encargada de respaldar la logica
    Private Sub WaitForConnection()
        Try
            While ServerRunning
                Client = Server.AcceptTcpClient
                RemoteForm.UpdateLabelStatus("CONECTADO")
                RequestManager = New RequestManager(New Connection(Client))
                RequestManager.SetRemoteForm(RemoteForm)
                RequestManager.StartResponse()
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Metodo que obtiene la ipv4 del equipo remoto, con objetivos de conexion
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

    'Metodo que devuelve el IP actual del equipo remoto
    Public Function ShowServerIp() As String
        Return ServerIpAddress.ToString
    End Function

End Class
