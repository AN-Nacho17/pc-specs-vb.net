'Esta clase se encarga de realizar acciones para controlar el equipo con las 
' peticiones que se realizan. Su finalidad es controlar
Imports System.Runtime.InteropServices

Public Class SystemControlModule

    'Variables de clase que representan los comandos a enviar hacia la api de windows
    'como comandos de audio y control de volumen
    Const WM_APPCOMMAND As UInteger = &H319
    Const APPCOMMAND_VOLUME_UP As UInteger = &HA
    Const APPCOMMAND_VOLUME_DOWN As UInteger = &H9
    Const APPCOMMAND_VOLUME_MUTE As UInteger = &H8

    'Declaraciones necesarias para la interacion con el api de windows para llamadas como
    'el control de sonidos.
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(Msg As UInteger, wParam As IntPtr, lParam As IntPtr) As IntPtr
    End Function

    'Funcion para realizar una captura de pantalla, su valor de retorno es un
    'mapa de bits a decodificar que contiene la imagen.
    Public Shared Function TakeScreenShot() As String
        Dim LocalBmp As Bitmap
        Using Bmp As New Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
            Using Graph As Graphics = Graphics.FromImage(Bmp)
                Graph.CopyFromScreen(0, 0, 0, 0, Bmp.Size)
                LocalBmp = Bmp
            End Using
        End Using
        TakeScreenShot = LocalBmp.ToString
    End Function

    'Funcion para subir el volumen del equipo, no necesita parametros y no posee
    'valor de retorno
    Public Shared Sub VolumeUp()
        SendMessage(WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_UP * &H10000)
    End Sub
    'Funcion para bajar el volumen del equipo, no necesita parametros y no posee
    'valor de retorno
    Public Shared Sub VolumeDown()
        SendMessage(WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_DOWN * &H10000)
    End Sub

    'Funcion para silenciar el equipo, no necesita parametros y no posee
    'valor de retorno
    Public Shared Sub Mute()
        SendMessage(WM_APPCOMMAND, &H200EB0, APPCOMMAND_VOLUME_MUTE * &H10000)
    End Sub
    'Funcion para apagar el equipo, no necesita parametros y no posee
    'valor de retorno
    Public Shared Sub Shutdown()
        shellCall("shutdown /s")
    End Sub

    'Funcion para reiniciar el equipo, no necesita parametros y no posee
    'valor de retorno
    Public Shared Sub ReStart()
        shellCall("shutdown /r")
    End Sub
    'Funcion para cerrar la sesion de Windows del equipo el equipo, no necesita parametros y no posee
    'valor de retorno
    Public Shared Sub CloseUserSession()
        shellCall("shutdown /l")
    End Sub

    'Metodo para llamar a una funcion shell para iniciar un proceso de una
    'instancia de cmd y luego enviarle el comando DOS a ejecutar
    Private Shared Sub shellCall(shellCommand As String)
        'La tarea devuelve un PID del proceso iniciado
        Dim processFinished = 0
        Dim pid As Integer
        Dim process As Process
        pid = Shell("cmd.exe", 1)
        SendKeys.Send(shellCommand)
        SendKeys.Send("{Enter}")
        'Try
        'If (pid = processFinished) = False Then
        'process = Process.GetProcessById(pid)
        'process.Kill()
        ' MsgBox("Procces with PID: " & pid & " terminated")
        '  End If
        'Catch ex As Exception
        'End Try
    End Sub


End Class
