'Esta clase se encarga de obtener la informacion necesaria del equipo
' haciendo uso de objetos establecidos del entorno vb.net, su razon de ser es 
' solo obtener la informacion necesaria de cada peticion
Public Class SystemInfoModule

    'My.Computer.Registry.getValue(dir, nombre_archivo, nothing or '')
    'tcp/ ip protocol para sockets
    'TCPListener, TCPClient

    'Funcion para regresar el nombre completo del SO
    'No recibe parametros y el valor de retorno es una cadena
    Public Shared Function getOsFullName() As String
        Dim osFullName As String
        osFullName = My.Computer.Info.OSFullName
        getOsFullName = osFullName
    End Function

    'Funcion para regresar el nombre de la plataforma del SO
    'No recibe parametros y el valor de retorno es una cadena
    Public Shared Function getOsPlatform() As String
        Dim osPlatform As String
        osPlatform = My.Computer.Info.OSPlatform
        getOsPlatform = osPlatform
    End Function

    'Funcion para regresar la version del SO
    'No recibe parametros y el valor de retorno es una cadena
    Public Shared Function getOsVersion() As String
        Dim osVersion As String
        osVersion = My.Computer.Info.OSVersion
        getOsVersion = osVersion
    End Function

    'Funcion para regresar el nombre de computador
    'No recibe parametros y el valor de retorno es una cadena
    Public Shared Function getComputerName() As String
        Dim compName As String
        compName = My.Computer.Name
        getComputerName = compName
    End Function

    'Funcion para regresar la informacion del cpu
    'No recibe parametros y el valor de retorno es una cadena
    Public Shared Function getCpuInfo() As String
        Dim regAddres As String
        regAddres = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\CentralProcessor\0\", "ProcessorNameString", Nothing)
        getCpuInfo = regAddres
    End Function

    'Funcion para regresar la cantidad de memoria RAM expresada en GB
    'No recibe parametros y el valor de retorno es un entero
    Public Shared Function getRam() As String
        'Dim totalRam As Integer
        'totalRam = My.Computer.Info.TotalPhysicalMemory
        'getRam = toGigaBytes(totalRam) & " GB"
        'totalRam = Integer.Parse(totalRam)
        'getRam = totalRam.ToString(totalRam) & " GB"
        Return toGigaBytes(My.Computer.Info.TotalPhysicalMemory)
    End Function

    'Funcion para regresar la informacion de las unidades de disco
    'Incluyendo la letra de unidad, el total, el espacio utilizado, el espacio
    'libre y el formato del sistema de archivos de la unidad, no recibe parametros 
    ' su tipo de retorno es una cadena
    Public Shared Function getDrivesInformation() As String
        Dim drivesInfo As String = ""
        Dim diskInfoManager() As System.IO.DriveInfo
        Try
            diskInfoManager = System.IO.DriveInfo.GetDrives
        Catch ex As Exception
        End Try
        For Each drive As System.IO.DriveInfo In diskInfoManager
            If drive.IsReady Then
                drivesInfo += "Letra de unidad: " & drive.Name & "?"
                drivesInfo += "Espacio total en disco: " & toGigaBytes(drive.TotalSize) & "?"
                drivesInfo += "Espacio utilizado en disco: " & toGigaBytes((drive.TotalSize - drive.TotalFreeSpace)) & "?"
                drivesInfo += "Espacio libre en disco: " & toGigaBytes(drive.TotalFreeSpace) & "?"
                drivesInfo += "Sistema de archivos: " & drive.DriveFormat & "?"
            End If
        Next
        getDrivesInformation = drivesInfo
    End Function

    'Funcion para regresar la resolucion de pantalla del equipo, no recibe parametros
    'su tipo de retorno es una cadena
    Public Shared Function getScreenResolution() As String
        Dim screenRes As String
        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        screenRes = screenWidth & " x " & screenHeight
        getScreenResolution = screenRes
    End Function

    'Funcion para regresar la cadena que contiene el nombre de usuario que inicio sesion 
    'no recibe parametros
    Public Shared Function getUserName() As String
        Return System.Environment.UserName
    End Function

    'Funcion para regresar la zona horaria del sistema en formato cadena, no recibe
    'parametros
    Public Shared Function getTimeZone() As String
        Dim timeZone As TimeZoneInfo
        timeZone = System.TimeZoneInfo.Local
        getTimeZone = timeZone.DisplayName
    End Function

    'Funcion para regresar la fecha y la hora del equipo en el momento de consulta
    'no se reciben parametros y el valor de retorno es una cadena
    Public Shared Function getDateTime() As String
        Dim dateTime As Date
        dateTime = My.Computer.Clock.LocalTime
        getDateTime = dateTime.ToString
    End Function

    'Funcion para regresar una lista entera de los procesos en ejecucion en el equipo
    'no recibe parametros y el valor de retorno es una cadena de texto
    Public Shared Function getProcessList() As String
        Dim processList() As Process
        Dim processInfoList As String = ""
        Try
            processList = Process.GetProcesses
            For Each process As Process In processList
                processInfoList += "PID: " & vbTab & process.Id & vbTab & " Nombre del proceso: " & vbTab & process.ProcessName & "?"
            Next
        Catch ex As Exception
        End Try
        getProcessList = processInfoList
    End Function

    'Funcion para convertir una determinada cantidad a gigabtyes dada una cantidad en bytes
    'Recibe la cantidad de bytes como un lon y devuelve se equivalente en gigas
    Private Shared Function toGigaBytes(bytes As Long) As String
        toGigaBytes = Math.Round(bytes / (1073741824), 1) & " GB "
    End Function



End Class

