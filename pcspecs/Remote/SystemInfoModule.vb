Public Class SystemInfoModule

    'Funcion para regresar el nombre completo del SO
    'No recibe parametros y el valor de retorno es una cadena
    Public Function getOsFullName() As String
        Dim osFullName As String
        osFullName = My.Computer.Info.OSFullName
        getOsFullName = osFullName
    End Function

    'Funcion para regresar el nombre de la plataforma del SO
    'No recibe parametros y el valor de retorno es una cadena
    Public Function getOsPlatform() As String
        Dim osPlatform As String
        osPlatform = My.Computer.Info.OSPlatform
        getOsPlatform = osPlatform
    End Function

    'Funcion para regresar la version del SO
    'No recibe parametros y el valor de retorno es una cadena
    Public Function getOsVersion() As String
        Dim osVersion As String
        osVersion = My.Computer.Info.OSVersion
        getOsVersion = osVersion
    End Function

    'Funcion para regresar el nombre de computador
    'No recibe parametros y el valor de retorno es una cadena
    Public Function getComputerName() As String
        Dim compName As String
        compName = My.Computer.Name
        getComputerName = compName
    End Function

    'Funcion para regresar la version informacion del cpu
    'No recibe parametros y el valor de retorno es una cadena


    'Funcion para regresar la cantidad de memoria RAM expresada en GB
    'No recibe parametros y el valor de retorno es un entero
    Public Function getRam() As Integer
        Dim totalRam As Integer
        totalRam = My.Computer.Info.TotalPhysicalMemory
        getRam = totalRam
    End Function

End Class
