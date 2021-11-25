Imports System.Text.RegularExpressions

Public Class SetupForm

    Private ControllerSocket As ControllerSocket
    Private Const LOCALHOST_IPADDRESS = "127.0.0.1"
    Private ControllerForm As ControllerForm
    Private FinalIpAddress As String

    'Sub rutina necesaria para: validar si los datos ingresados en los campos
    'de texto son correctos y en caso de, armar la direccion IP completa
    'Ademas hace llamado a metodos para verificar el estado de la conexion
    'dada la direccion proporcionada
    Public Sub Connect()
        Dim IpPart1 As String = txt_ip1.Text
        Dim IpPart2 As String = txt_ip2.Text
        Dim IpPart3 As String = txt_ip3.Text
        Dim IpPart4 As String = txt_ip4.Text
        Dim IpVector As String() = {IpPart1, IpPart2, IpPart3, IpPart4}
        Dim LocalIpAddres As String
        If ValidateIpParts(IpVector) Then
            LocalIpAddres = CraftIpAddress(IpVector)
            If TestConnection(LocalIpAddres) Then
                'Se habilita el boton para comenzar y se deshabilitan los otros
                btn_start.Enabled = True
                btn_test.Enabled = False
                btn_localHost.Enabled = False
                FinalIpAddress = LocalIpAddres
            Else
                'Caso de error donde la conexion a la ip dada fallo
                MsgBox("ERROR: No se pudo establecer una conexion con la IP ingresada")
            End If
        Else
            'Caso de error donde las partes de la IP esten incorrectas
            MsgBox("ERROR: Algunas de las partes ingresadas en los campos son erroneas" & "Recuerde utilizar datos numericos.")
        End If
    End Sub

    'Funcion para validar que las partes ingresadas dentro de la cadena 
    'respetan el formato de la direccion ip es decir, numeros. Recibe
    'el vector con cada una de las partes y valida que cada elemento de este vector 
    'cumpla con los requisitos
    Private Function ValidateIpParts(IpVector As String()) As Boolean
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
    Private Function CraftIpAddress(IpVector As String())
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
    Private Function TestConnection(IpAddres As String)
        Dim ConnectionSuccessfull As Boolean
        Try
            ConnectionSuccessfull = My.Computer.Network.Ping(IpAddres)
        Catch ex As Exception
            MsgBox("ERROR: Error durante la prueba de conexion")
        End Try
        TestConnection = ConnectionSuccessfull
    End Function

    'Subrutina que se activa cuando el usuario desea probar la conexion con los
    'datos ingresados dentro de los campos de texto.
    Private Sub btn_test_Click(sender As Object, e As EventArgs) Handles btn_test.Click
        Connect()
    End Sub

    'Subrutina que se genera cuando el formulario de inicio es cargado 
    Private Sub SetupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_start.Enabled = False
        btn_test.Enabled = False
        Me.CenterToScreen()
    End Sub

    'Subrutina que se activa cuando el usuario desea comenzar la conexion a traves
    'de la direccion previamente validada y probada
    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        'Se crea el socket de conexion y se pasa el control logico de la aplicacion
        'al siguiente formulario
        ControllerSocket = New ControllerSocket(FinalIpAddress)
        Me.Hide()
        ControllerForm = New ControllerForm(ControllerSocket, Me)
        ControllerForm.Show()
    End Sub

    'Subrutina cuando el usuario selecciona que se deseea conectar a LOCALHOST
    'expresamente
    Private Sub btn_localHost_Click(sender As Object, e As EventArgs) Handles btn_localHost.Click
        If TestConnection(LOCALHOST_IPADDRESS) Then
            ControllerSocket = New ControllerSocket(LOCALHOST_IPADDRESS)
            Me.Hide()
            ControllerForm = New ControllerForm(ControllerSocket, Me)
            ControllerForm.Show()
        End If
    End Sub

    Private Sub txt_ip4_TextChanged(sender As Object, e As EventArgs) Handles txt_ip4.TextChanged
        btn_test.Enabled = True
    End Sub

End Class