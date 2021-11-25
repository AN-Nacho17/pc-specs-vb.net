Imports System.Text.RegularExpressions

Public Class IpManager

    'Funcion para validar que las partes ingresadas dentro de la cadena 
    'respetan el formato de la direccion ip es decir, numeros. Recibe
    'el vector con cada una de las partes y valida que cada elemento de este vector 
    'cumpla con los requisitos
    Public Shared Function ValidateIpParts(IpVector As String()) As Boolean
        Dim Valid As Boolean = True
        Const IpPartPattern As String = "[0-9]"
        For Each IpPart In IpVector
            If Strings.Len(IpPart) > 3 Then
                Valid = False
            End If
            For Each part In IpPart
                If Regex.IsMatch(part, IpPartPattern) = False Then
                    Valid = False
                End If
            Next
        Next
        ValidateIpParts = Valid
    End Function

    'Funcion para conformar la direccion ip juntando todas las partes expresadas
    'dentro de las cajas de texto en la interfaz grafica, recibe el vector de las 
    'parte recopiladas y devuelve la cadena completa uniendo cada parte y formando
    'la direccion ip con su debido formato
    Public Shared Function CraftIpAddress(IpVector As String())
        Dim builder As New System.Text.StringBuilder
        Dim DotCounter As Byte = 0
        Const MaxDotsInAddress = 3
        For Each IpPart In IpVector
            If DotCounter <= MaxDotsInAddress Then
                builder.Append(IpPart & ".")
                DotCounter += 1
            End If
        Next
        CraftIpAddress = builder.ToString
    End Function

    'Funcion para probar la conexion establecida con la dirreccion ip
    'proporcionada, recibe la dirrecion completa de ip y si valor de retorno
    'es si la operacion booleana aplicada con el comando PING fue valida o no
    Public Shared Function TestConnection(IpAddres As String)
        Dim ConnectionSuccessfull As Boolean
        Try
            ConnectionSuccessfull = My.Computer.Network.Ping(IpAddres)
        Catch ex As Exception
            MsgBox("ERROR: Error durante la prueba de conexion")
        End Try
        TestConnection = ConnectionSuccessfull
    End Function




End Class
