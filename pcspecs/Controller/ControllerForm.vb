﻿'Esta clase se encarga de controlar las acciones que sean disparadas segun los botones
'del formulario que representan acciones dentro de la maquina remota.
Public Class ControllerForm

    'Socket de controlador pre instalado desde el formulario inicilar
    Private ControllerSocket As ControllerSocket
    'Instancia de la ventana padre (menu principal)
    Private SetupForm As SetupForm
    'Constantes que representan las solicitudes del usuario mediante los botones
    Private Const SO_COMPLETE_NAME As Byte = 1
    Private Const SO_PLATFORM As Byte = 2
    Private Const SO_VERSION As Byte = 3
    Private Const PC_NAME As Byte = 4
    Private Const CPU_INFO As Byte = 5
    Private Const TOTAL_RAM As Byte = 6
    Private Const DISC_UNITS_LIST As Byte = 7
    Private Const SCREEN_RESOLUTION As Byte = 8
    Private Const LOGGED_USER_NAME As Byte = 9
    Private Const TIME_ZONE As Byte = 10
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

    'Constructor de clase que recibe el objeto controlador previamente inicializado
    Public Sub New(ControlSock As ControllerSocket, Sform As SetupForm)
        ControllerSocket = ControlSock
        SetupForm = Sform
        Me.CenterToScreen()
    End Sub

    'Sub de accion para solicitar el nombre completo del sistema operativo al equipo remoto
    Private Sub btn_osName_Click(sender As Object, e As EventArgs) Handles btn_osName.Click
        ControllerSocket.Request(SO_COMPLETE_NAME)
    End Sub

    'Sub de accion para solicitar el nombre de la plataforma del sistema operativo al equipo remoto
    Private Sub btn_osPlatform_Click(sender As Object, e As EventArgs) Handles btn_osPlatform.Click
        ControllerSocket.Request(SO_PLATFORM)
    End Sub

    'Sub de accion para solicitar la version del sistema operativo al equipo remoto
    Private Sub btn_osVersion_Click(sender As Object, e As EventArgs) Handles btn_osVersion.Click
        ControllerSocket.Request(SO_VERSION)
    End Sub

    'Sub de accion para solicitar el nombre de el equipo del sistema operativo al equipo remoto
    Private Sub btn_pcName_Click(sender As Object, e As EventArgs) Handles btn_pcName.Click
        ControllerSocket.Request(PC_NAME)
    End Sub

    'Sub de accion para solicitar la informacion del CPU al equipo remoto
    Private Sub btn_cpuInfo_Click(sender As Object, e As EventArgs) Handles btn_cpuInfo.Click
        ControllerSocket.Request(CPU_INFO)
    End Sub

    'Sub de accion para solicitar la cantidad de memoria RAM al equipo remoto
    Private Sub btn_totalRam_Click(sender As Object, e As EventArgs) Handles btn_totalRam.Click
        ControllerSocket.Request(TOTAL_RAM)
    End Sub

    'Sub de accion para solicitar la informacion de las unidades de disco del equipo remoto
    Private Sub btn_drives_Click(sender As Object, e As EventArgs) Handles btn_drives.Click
        ControllerSocket.Request(DISC_UNITS_LIST)
    End Sub

    'Sub de accion para solicitar la resolucion de la pantalla del equipo remoto
    Private Sub btn_screenRes_Click(sender As Object, e As EventArgs) Handles btn_screenRes.Click
        ControllerSocket.Request(SCREEN_RESOLUTION)
    End Sub

    'Sub de accion para solicitar el nombre de usuario que inicio sesion dentro de la maquina
    Private Sub btn_user_Click(sender As Object, e As EventArgs) Handles btn_user.Click
        ControllerSocket.Request(LOGGED_USER_NAME)
    End Sub

    'Sub de accion para solicitar la zona horaria del equipo remoto
    Private Sub btn_timeZone_Click(sender As Object, e As EventArgs) Handles btn_timeZone.Click
        ControllerSocket.Request(TIME_ZONE)
    End Sub

    'Sub de accion para solicitar la fecha y hora del equipo remoto
    Private Sub btn_dateTime_Click(sender As Object, e As EventArgs) Handles btn_dateTime.Click
        ControllerSocket.Request(DATE_AND_TIME)
    End Sub

    'Sub de accion para solicitar la lista de procesos en ejecucion dentro del equipo remoto
    Private Sub btn_Process_Click(sender As Object, e As EventArgs) Handles btn_Process.Click
        ControllerSocket.Request(PROCESS_RUNNING_LIST)
    End Sub

    'Sub de accion para solicitarle al equipo remoto que realize una captura de pantalla
    Private Sub btn_takeScreenShot_Click(sender As Object, e As EventArgs) Handles btn_takeScreenShot.Click
        ControllerSocket.Request(TAKE_SCREESHOT)
    End Sub

    'Sub de accion para enviar un mensaje al equipo remoto
    Private Sub btn_sendMessage_Click(sender As Object, e As EventArgs) Handles btn_sendMessage.Click
        ControllerSocket.Request(SEND_MESSAGE)
    End Sub

    'Sub de accion para solicitarle al equipo remoto que suba el volumen
    Private Sub btn_volumeUp_Click(sender As Object, e As EventArgs) Handles btn_volumeUp.Click
        ControllerSocket.Request(VOL_UP)
    End Sub

    'Sub de accion para solicitarle al equipo remoto que baje el volumen
    Private Sub btn_volumeDown_Click(sender As Object, e As EventArgs) Handles btn_volumeDown.Click
        ControllerSocket.Request(VOL_DOWN)
    End Sub

    'Sub de accion para solicitarle al equipo remoto que mutee el sonido total del equipo remoto
    Private Sub btn_mute_Click(sender As Object, e As EventArgs) Handles btn_mute.Click
        ControllerSocket.Request(MUTE_AUDIO)
    End Sub

    'Sub de accion para solicitar que se apague el equipo remoto.
    Private Sub btn_shutdown_Click(sender As Object, e As EventArgs) Handles btn_shutdown.Click
        ControllerSocket.Request(SHUTDOWN)
    End Sub

    'Sub de accion para solicitarle al equipo remoto que se reinicie
    Private Sub btn_restart_Click(sender As Object, e As EventArgs) Handles btn_restart.Click
        ControllerSocket.Request(RESTART)
    End Sub

    'Sub de accion para solicitarle al equipo remoto que cierre la sesion del usuario
    'actual
    Private Sub btn_closeSession_Click(sender As Object, e As EventArgs) Handles btn_closeSession.Click
        ControllerSocket.Request(CLOSE_SESSION)
    End Sub


End Class
