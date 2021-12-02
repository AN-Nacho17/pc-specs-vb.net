Imports System.Net.Sockets
Imports System.Threading

Public Class RequestManager

    Private Connection As Connection
    Private ResponseThread As Thread
    Private Listen = True
    Private RemoteForm As RemoteForm

    'Server possible requests to response
    Private Const SO_COMPLETE_NAME As String = "1"
    Private Const SO_PLATFORM As String = "2"
    Private Const SO_VERSION As String = "3"
    Private Const PC_NAME As String = "4"
    Private Const CPU_INFO As String = "5"
    Private Const TOTAL_RAM As String = "6"
    Private Const DISC_UNITS_LIST As String = "7"
    Private Const SCREEN_RESOLUTION As String = "8"
    Private Const LOGGED_USER_NAME As String = "9"
    Private Const TIME_ZONE As String = "10"
    Private Const DATE_AND_TIME As String = "11"
    Private Const PROCESS_RUNNING_LIST As String = "12"
    Private Const TAKE_SCREESHOT As String = "13"
    Private Const SEND_MESSAGE As String = "14"
    Private Const VOL_UP As String = "15"
    Private Const VOL_DOWN As String = "16"
    Private Const MUTE_AUDIO As String = "17"
    Private Const SHUTDOWN As String = "18"
    Private Const RESTART As String = "19"
    Private Const CLOSE_SESSION As String = "20"
    Private Const EXIT_CODE As String = "21"

    Public Sub New(Connec As Connection)
        Me.Connection = Connec
    End Sub

    Public Sub SetRemoteForm(RemoteForm As RemoteForm)
        Me.RemoteForm = RemoteForm
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Public Sub StartResponse()
        Control.CheckForIllegalCrossThreadCalls = False
        ResponseThread = New Thread(AddressOf HandleRequest)
        ResponseThread.Start()
    End Sub

    Private Sub HandleRequest()
        Dim Request As String
        Try
            While Listen
                Request = Connection.ReadRequest
                ManageRequest(Request)
            End While
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ManageRequest(Request As String)
        Dim Response As String = ""
        Select Case Request
            Case SO_COMPLETE_NAME
                Response = SystemInfoModule.getOsFullName
            Case SO_PLATFORM
                Response = SystemInfoModule.getOsPlatform
            Case SO_VERSION
                Response = SystemInfoModule.getOsVersion
            Case PC_NAME
                Response = SystemInfoModule.getComputerName
            Case CPU_INFO
                Response = SystemInfoModule.getCpuInfo
            Case TOTAL_RAM
                Response = SystemInfoModule.getRam
            Case DISC_UNITS_LIST
                Response = SystemInfoModule.getDrivesInformation
            Case SCREEN_RESOLUTION
                Response = SystemInfoModule.getScreenResolution
            Case LOGGED_USER_NAME
                Response = SystemInfoModule.getUserName
            Case TIME_ZONE
                Response = SystemInfoModule.getTimeZone
            Case DATE_AND_TIME
                Response = SystemInfoModule.getDateTime
            Case PROCESS_RUNNING_LIST
                Response = SystemInfoModule.getProcessList
            Case TAKE_SCREESHOT
                SystemControlModule.TakeScreenShot()
            Case SEND_MESSAGE
                Dim Message As String = ""
                While String.IsNullOrEmpty(Message)
                    Message = Connection.Read()
                End While
                RemoteForm.SetOutputText(Message)
            Case VOL_UP
                SystemControlModule.VolumeUp()
            Case VOL_DOWN
                SystemControlModule.VolumeDown()
            Case MUTE_AUDIO
                SystemControlModule.Mute()
            Case SHUTDOWN
                SystemControlModule.Shutdown()
            Case RESTART
                SystemControlModule.ReStart()
            Case CLOSE_SESSION
                SystemControlModule.CloseUserSession()
            Case EXIT_CODE
                Listen = False
                RemoteForm.UpdateLabelStatus("ESPERANDO")
                Connection.CloseClient()
        End Select
        If (String.IsNullOrWhiteSpace(Response) = False) Then
            Connection.AnswerClient(Response)
        End If
    End Sub

End Class
