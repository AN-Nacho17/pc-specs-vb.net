'Esta clase se encarga de realizar acciones para controlar el equipo con las 
' peticiones que se realizan. Su finalidad es controlar
Public Class SystemControlModule

    Private Audio As Microsoft.VisualBasic.Devices.Audio

    'Funcion para realizar una captura de pantalla, su valor de retorno es un
    'mapa de bits a decodificar que contiene la imagen.

    'Funcion para subir el volumen del equipo, no necesita parametros y no posee
    'valor de retorno
    Public Sub volumeUp()

    End Sub
    'Funcion para bajar el volumen del equipo, no necesita parametros y no posee
    'valor de retorno
    Public Sub volumenDown()

    End Sub

    'Funcion para silenciar el equipo, no necesita parametros y no posee
    'valor de retorno
    Public Sub muteAudio()

    End Sub
    'Funcion para apagar el equipo, no necesita parametros y no posee
    'valor de retorno
    Public Sub shutdown()
        shellCall("shutdown /s")
    End Sub

    'Funcion para reiniciar el equipo, no necesita parametros y no posee
    'valor de retorno
    Public Sub reStart()
        shellCall("shutdown /r")
    End Sub
    'Funcion para cerrar la sesion de Windows del equipo el equipo, no necesita parametros y no posee
    'valor de retorno
    Public Sub closeUserSession()
        shellCall("shutdown /l")
    End Sub

    'Metodo para llamar a una funcion shell para iniciar un proceso de una
    'instancia de cmd y luego enviarle el comando DOS a ejecutar
    Public Sub shellCall(shellCommand As String)
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
