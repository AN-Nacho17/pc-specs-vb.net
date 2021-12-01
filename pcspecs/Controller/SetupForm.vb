'Esta clase de formulario es la encargada de la pagina inicial de carga del 
'usario para que elija la conexion por protocolo TCP/IP, esta clase contiene otros
'objetos como el socket de comunicacion y el validador de las dirrecciones IP.
Public Class SetupForm

    Private ControllerSocket As ControllerSocket
    Private Const LOCALHOST_IPADDRESS = "127.0.0.1"
    Private ControllerForm As ControllerForm
    Private FinalIpAddress As String

    'Sub rutina necesaria para: validar si los datos ingresados en los campos
    'de texto son correctos y en caso de, armar la direccion IP completa
    'Ademas hace llamado a metodos para verificar el estado de la conexion
    'dada la direccion proporcionada
    Private Sub Connect()
        FinalIpAddress = "" 'Es necesario reiniciar el valor para cada intento de conexion
        Dim IpPart1 As String = txt_ip1.Text
        Dim IpPart2 As String = txt_ip2.Text
        Dim IpPart3 As String = txt_ip3.Text
        Dim IpPart4 As String = txt_ip4.Text
        Dim IpVector As String() = {IpPart1, IpPart2, IpPart3, IpPart4}
        Dim LocalIpAddres As String
        If IpManager.ValidateIpParts(IpVector) Then
            LocalIpAddres = IpManager.CraftIpAddress(IpVector)
            If IpManager.TestConnection(LocalIpAddres) Then
                'Se habilita el boton para comenzar y se deshabilitan los otros
                btn_start.Enabled = True
                btn_test.Enabled = False
                btn_localHost.Enabled = False
                FinalIpAddress = LocalIpAddres
                btn_test.Text = "Correcto"
                btn_clean.Enabled = True
                SetTxtBoxes(False)
                MsgBox(FinalIpAddress)
            Else
                btn_test.Enabled = False
                btn_start.Enabled = False
                btn_localHost.Enabled = False
                btn_clean.Enabled = True
                'Caso de error donde la conexion a la ip dada fallo
                btn_test.Text = "Incorrecto"
                SetTxtBoxes(False)
                MsgBox(FinalIpAddress)
            End If
        Else
            btn_test.Enabled = False
            btn_start.Enabled = False
            btn_localHost.Enabled = False
            btn_clean.Enabled = True
            'Caso de error donde la conexion a la ip dada fallo
            btn_test.Text = "Incorrecto"
            SetTxtBoxes(False)
        End If
    End Sub

    'Sub para setear todos los componentes graficos hacia el estado inicial en el que estaban
    'Ocurrre cuando el form es cargado o cuando el usuario desea regresar y cancelar
    'la conexion actual
    Public Sub setFormToInitialConfig()
        SetTxtBoxes(True)
        ClearTxtBoxes()
        btn_start.Enabled = False
        btn_test.Enabled = False
        Me.CenterToScreen()
        btn_test.Text = "Probar"
        btn_clean.Enabled = False
    End Sub

    'Subrutina que se genera cuando el formulario de inicio es cargado 
    Private Sub SetupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        setFormToInitialConfig()
    End Sub

    'Subrutina que se activa cuando el usuario desea probar la conexion con los
    'datos ingresados dentro de los campos de texto, se procede a validar la IP
    'Y la rutina de conectarse al servidor mediante el socket.
    Private Sub btn_test_Click(sender As Object, e As EventArgs) Handles btn_test.Click
        Connect()
    End Sub

    'Subrutina que se activa cuando el usuario desea comenzar la conexion a traves
    'de la direccion previamente validada y probada
    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        'Se crea el socket de conexion y se pasa el control logico de la aplicacion
        'al siguiente formulario
        If ConnectSocket() Then
            Me.Hide()
            ControllerForm.Show()
            ControllerSocket.Write("Hola")
        Else
            MsgBox("ERROR: El cliente no esta conectado")
        End If
    End Sub

    'Subrutina cuando el usuario selecciona que se deseea conectar a LOCALHOST
    'expresamente
    Private Sub btn_localHost_Click(sender As Object, e As EventArgs) Handles btn_localHost.Click
        If IpManager.TestConnection(LOCALHOST_IPADDRESS) Then
            If ConnectSocket() Then
                Me.Hide()
                ControllerForm.Show()
            Else
                MsgBox("ERROR: El cliente no esta conectado")
            End If
        End If
    End Sub

    'Sub para crear la instancia del socket controlador y realizar la conexion de los 
    'sockets
    Private Function ConnectSocket() As Boolean
        ControllerSocket = New ControllerSocket(LOCALHOST_IPADDRESS)
        Dim ConnectionStablished As Boolean
        If ControllerSocket.IsConnected Then
            ControllerForm = New ControllerForm()
            ControllerForm.SetControllerSocket(ControllerSocket)
            ControllerForm.SetSetupForm(Me)
            ConnectionStablished = True
        Else
            ConnectionStablished = False
        End If
        ConnectSocket = ConnectionStablished
    End Function

    'Sub para que cuando el texto de la ultima casilla es cambiado se permita presionar el boton de probar
    Private Sub txt_ip4_TextChanged(sender As Object, e As EventArgs) Handles txt_ip4.TextChanged
        btn_test.Enabled = True
    End Sub

    'Sub para limpiar y resetear todo los botones y los cuadros de texto en caso de
    'que se desee intentar con una nueva IP o limpiar todo y volver a intentar si la conexion
    'fue incorrecta
    Private Sub btn_clean_Click(sender As Object, e As EventArgs) Handles btn_clean.Click
        If btn_test.Text = "Correcto" Or btn_test.Text = "Incorrecto" Then
            ClearTxtBoxes()
            btn_start.Enabled = True
            btn_localHost.Enabled = True
            btn_test.Enabled = True
            btn_test.Text = "Probar"
            SetTxtBoxes(True)
        End If
    End Sub

    'Sub para cambiar el estado de los botones (desactivados - activados)
    Private Sub SetTxtBoxes(Value As Boolean)
        txt_ip1.Enabled = Value
        txt_ip2.Enabled = Value
        txt_ip3.Enabled = Value
        txt_ip4.Enabled = Value
    End Sub

    'Sub para limpiar todos los campo de texto en la pantalla inicial
    Private Sub ClearTxtBoxes()
        txt_ip1.Text = ""
        txt_ip2.Text = ""
        txt_ip3.Text = ""
        txt_ip4.Text = ""
    End Sub

    'Grupo de subrutinas para logica visual que se encarga de cambiar lo campos
    'de texto una vez que su numero maximo de caracteres haya sido conseguido
    Private Sub txt_ip1_TextChanged(sender As Object, e As EventArgs) Handles txt_ip1.TextChanged
        If txt_ip1.Text.Length = txt_ip1.MaxLength Then
            txt_ip2.Select()
        End If
    End Sub

    Private Sub txt_ip2_TextChanged(sender As Object, e As EventArgs) Handles txt_ip2.TextChanged
        If txt_ip2.Text.Length = txt_ip2.MaxLength Then
            txt_ip3.Select()
        End If
    End Sub

    Private Sub txt_ip3_TextChanged(sender As Object, e As EventArgs) Handles txt_ip3.TextChanged
        If txt_ip3.Text.Length = txt_ip3.MaxLength Then
            txt_ip4.Select()
        End If
    End Sub


End Class