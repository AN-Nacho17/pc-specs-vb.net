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
        FinalIpAddress = ""
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
        btn_test.Text = "Probar"
        btn_clean.Enabled = False
    End Sub

    'Subrutina que se activa cuando el usuario desea comenzar la conexion a traves
    'de la direccion previamente validada y probada
    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        'Se crea el socket de conexion y se pasa el control logico de la aplicacion
        'al siguiente formulario
        ControllerSocket = New ControllerSocket(FinalIpAddress)
        Me.Hide()
        ControllerForm = New ControllerForm()
        ControllerForm.SetControllerSocket(ControllerSocket)
        ControllerForm.SetSetupForm(Me)
        ControllerForm.Show()
    End Sub

    'Subrutina cuando el usuario selecciona que se deseea conectar a LOCALHOST
    'expresamente
    Private Sub btn_localHost_Click(sender As Object, e As EventArgs) Handles btn_localHost.Click
        If IpManager.TestConnection(LOCALHOST_IPADDRESS) Then
            ControllerSocket = New ControllerSocket(LOCALHOST_IPADDRESS)
            Me.Hide()
            ControllerForm = New ControllerForm()
            ControllerForm.SetControllerSocket(ControllerSocket)
            ControllerForm.SetSetupForm(Me)
            ControllerForm.Show()
        End If
    End Sub

    Private Sub txt_ip4_TextChanged(sender As Object, e As EventArgs) Handles txt_ip4.TextChanged
        btn_test.Enabled = True
    End Sub

    Private Sub btn_clean_Click(sender As Object, e As EventArgs) Handles btn_clean.Click
        If btn_test.Text = "Correcto" Or btn_test.Text = "Incorrecto" Then
            txt_ip1.Text = ""
            txt_ip2.Text = ""
            txt_ip3.Text = ""
            txt_ip4.Text = ""
            btn_start.Enabled = True
            btn_localHost.Enabled = True
            btn_test.Enabled = True
            btn_test.Text = "Probar"
            SetTxtBoxes(True)
        End If
    End Sub

    Private Sub SetTxtBoxes(Value As Boolean)
        txt_ip1.Enabled = Value
        txt_ip2.Enabled = Value
        txt_ip3.Enabled = Value
        txt_ip4.Enabled = Value
    End Sub

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