Imports System.Net.Sockets
Imports System.Threading

Public Class RequestManager

    Private Connection As Connection
    Private ResponseThread As Thread
    Private Listen = True

    'Server possible requests to response
    Private Const SO_COMPLETE_NAME As Byte = 1
    Private Const SO_PLATFORM As Byte = 2
    Private Const SO_VERSION As Byte = 3
    Private Const PC_NAME As Byte = 4
    Private Const CPU_INFO As Byte = 5
    Private Const TOTAL_RAM As Byte = 6
    Private Const DISC_UNITS_LIST As Byte = 7 'Neccesary to show some things
    Private Const SCREEN_RESOLUTION As Byte = 8
    Private Const LOGGED_USER_NAME As Byte = 9
    Private Const SYSTEM_REGION_ZONE As Byte = 10
    Private Const DATE_AND_TIME As Byte = 11
    Private Const PROCESS_RUNNING_LIST As Byte = 12
    Private Const TAKE_SCREESHOT As Byte = 13
    Private Const SEND_MESSAGE As Byte = 14
    Private Const VOL_UP As Byte = 15
    Private Const VOL_DOWN As Byte = 16
    Private Const MUTE_AUDIO As Byte = 17
    Private Const SHUTDOWN As Byte = 18
    Private Const RESTART As Byte = 19
    Private Const CLOSE_SESSION As Byte = 20
    Private Const EXIT_CODE As Byte = 21

    Public Sub New(Connec As Connection)
        Me.Connection = Connec
    End Sub

    Public Sub StartResponse()
        Control.CheckForIllegalCrossThreadCalls = False
        ResponseThread = New Thread(AddressOf HandleRequest)
        ResponseThread.Start()
    End Sub

    Private Sub HandleRequest()
        Dim Request As Byte
        Try
            While Listen
                Request = Connection.ReadRequest
                MsgBox(Request)
                'ManageRequest(Request)
            End While
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ManageRequest(Request As Byte)
        Dim Response As String
        Select Case Request
            Case SO_COMPLETE_NAME
                Response = SystemInfoModule.getOsFullName
                Connection.AnswerClient(Response)
            Case SO_PLATFORM
                Response = SystemInfoModule.getOsPlatform
                Connection.AnswerClient(Response)
            Case SO_VERSION
                Response = SystemInfoModule.getOsVersion
                Connection.AnswerClient(Response)
            Case PC_NAME
                Response = SystemInfoModule.getComputerName
                Connection.AnswerClient(Response)
            Case CPU_INFO
                Response = SystemInfoModule.getCpuInfo
                Connection.AnswerClient(Response)
            Case TOTAL_RAM
                Response = SystemInfoModule.getRam
                Connection.AnswerClient(Response)
            Case DISC_UNITS_LIST
                Response = SystemInfoModule.getDrivesInformation
                Connection.AnswerClient(Response)
            Case SCREEN_RESOLUTION
                Response = SystemInfoModule.getScreenResolution
                Connection.AnswerClient(Response)
            Case LOGGED_USER_NAME
                Response = SystemInfoModule.getUserName
                Connection.AnswerClient(Response)
            Case SYSTEM_REGION_ZONE
                Response = SystemInfoModule.getTimeZone
                Connection.AnswerClient(Response)
            Case DATE_AND_TIME
                Response = SystemInfoModule.getDateTime
                Connection.AnswerClient(Response)
            Case PROCESS_RUNNING_LIST
                Response = SystemInfoModule.getProcessList
                Connection.AnswerClient(Response)
            Case TAKE_SCREESHOT
                SystemControlModule.TakeScreenShot()
            Case SEND_MESSAGE
                Dim Message As String = Connection.Read()
                MsgBox(Message)
            Case VOL_UP
                SystemControlModule.volumeUp()
            Case VOL_DOWN
                SystemControlModule.volumenDown()
            Case MUTE_AUDIO
                SystemControlModule.muteAudio()
            Case SHUTDOWN
                SystemControlModule.shutdown()
            Case RESTART
                SystemControlModule.reStart()
            Case CLOSE_SESSION
                SystemControlModule.closeUserSession()
            Case EXIT_CODE
                Listen = False
                Connection.CloseClient()
        End Select
    End Sub

End Class
