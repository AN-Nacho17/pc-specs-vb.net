<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControllerForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_osName = New System.Windows.Forms.Button()
        Me.btn_osPlatform = New System.Windows.Forms.Button()
        Me.btn_osVersion = New System.Windows.Forms.Button()
        Me.btn_pcName = New System.Windows.Forms.Button()
        Me.btn_cpuInfo = New System.Windows.Forms.Button()
        Me.btn_totalRam = New System.Windows.Forms.Button()
        Me.btn_drives = New System.Windows.Forms.Button()
        Me.btn_screenRes = New System.Windows.Forms.Button()
        Me.btn_user = New System.Windows.Forms.Button()
        Me.btn_timeZone = New System.Windows.Forms.Button()
        Me.btn_dateTime = New System.Windows.Forms.Button()
        Me.btn_Process = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_osName
        '
        Me.btn_osName.Location = New System.Drawing.Point(38, 126)
        Me.btn_osName.Name = "btn_osName"
        Me.btn_osName.Size = New System.Drawing.Size(230, 79)
        Me.btn_osName.TabIndex = 0
        Me.btn_osName.Text = "Nombre Completo SO"
        Me.btn_osName.UseVisualStyleBackColor = True
        '
        'btn_osPlatform
        '
        Me.btn_osPlatform.Location = New System.Drawing.Point(38, 236)
        Me.btn_osPlatform.Name = "btn_osPlatform"
        Me.btn_osPlatform.Size = New System.Drawing.Size(230, 77)
        Me.btn_osPlatform.TabIndex = 1
        Me.btn_osPlatform.Text = "Plataforma del SO"
        Me.btn_osPlatform.UseVisualStyleBackColor = True
        '
        'btn_osVersion
        '
        Me.btn_osVersion.Location = New System.Drawing.Point(38, 345)
        Me.btn_osVersion.Name = "btn_osVersion"
        Me.btn_osVersion.Size = New System.Drawing.Size(230, 79)
        Me.btn_osVersion.TabIndex = 2
        Me.btn_osVersion.Text = "Version SO"
        Me.btn_osVersion.UseVisualStyleBackColor = True
        '
        'btn_pcName
        '
        Me.btn_pcName.Location = New System.Drawing.Point(512, 126)
        Me.btn_pcName.Name = "btn_pcName"
        Me.btn_pcName.Size = New System.Drawing.Size(219, 57)
        Me.btn_pcName.TabIndex = 3
        Me.btn_pcName.Text = "Nombre del equipo"
        Me.btn_pcName.UseVisualStyleBackColor = True
        '
        'btn_cpuInfo
        '
        Me.btn_cpuInfo.Location = New System.Drawing.Point(512, 212)
        Me.btn_cpuInfo.Name = "btn_cpuInfo"
        Me.btn_cpuInfo.Size = New System.Drawing.Size(219, 55)
        Me.btn_cpuInfo.TabIndex = 4
        Me.btn_cpuInfo.Text = "Informacion del CPU"
        Me.btn_cpuInfo.UseVisualStyleBackColor = True
        '
        'btn_totalRam
        '
        Me.btn_totalRam.Location = New System.Drawing.Point(512, 289)
        Me.btn_totalRam.Name = "btn_totalRam"
        Me.btn_totalRam.Size = New System.Drawing.Size(219, 57)
        Me.btn_totalRam.TabIndex = 5
        Me.btn_totalRam.Text = "Total RAM(GB)"
        Me.btn_totalRam.UseVisualStyleBackColor = True
        '
        'btn_drives
        '
        Me.btn_drives.Location = New System.Drawing.Point(512, 367)
        Me.btn_drives.Name = "btn_drives"
        Me.btn_drives.Size = New System.Drawing.Size(219, 57)
        Me.btn_drives.TabIndex = 6
        Me.btn_drives.Text = "Lista Unidades de Disco"
        Me.btn_drives.UseVisualStyleBackColor = True
        '
        'btn_screenRes
        '
        Me.btn_screenRes.Location = New System.Drawing.Point(977, 126)
        Me.btn_screenRes.Name = "btn_screenRes"
        Me.btn_screenRes.Size = New System.Drawing.Size(208, 48)
        Me.btn_screenRes.TabIndex = 7
        Me.btn_screenRes.Text = "Resolucion de pantalla"
        Me.btn_screenRes.UseVisualStyleBackColor = True
        '
        'btn_user
        '
        Me.btn_user.Location = New System.Drawing.Point(977, 192)
        Me.btn_user.Name = "btn_user"
        Me.btn_user.Size = New System.Drawing.Size(208, 46)
        Me.btn_user.TabIndex = 8
        Me.btn_user.Text = "Nombre de usuario"
        Me.btn_user.UseVisualStyleBackColor = True
        '
        'btn_timeZone
        '
        Me.btn_timeZone.Location = New System.Drawing.Point(977, 255)
        Me.btn_timeZone.Name = "btn_timeZone"
        Me.btn_timeZone.Size = New System.Drawing.Size(208, 48)
        Me.btn_timeZone.TabIndex = 9
        Me.btn_timeZone.Text = "Zona horaria "
        Me.btn_timeZone.UseVisualStyleBackColor = True
        '
        'btn_dateTime
        '
        Me.btn_dateTime.Location = New System.Drawing.Point(977, 324)
        Me.btn_dateTime.Name = "btn_dateTime"
        Me.btn_dateTime.Size = New System.Drawing.Size(208, 48)
        Me.btn_dateTime.TabIndex = 10
        Me.btn_dateTime.Text = "Fecha y hora del equipo"
        Me.btn_dateTime.UseVisualStyleBackColor = True
        '
        'btn_Process
        '
        Me.btn_Process.Location = New System.Drawing.Point(977, 391)
        Me.btn_Process.Name = "btn_Process"
        Me.btn_Process.Size = New System.Drawing.Size(208, 48)
        Me.btn_Process.TabIndex = 11
        Me.btn_Process.Text = "Lista de procesos en ejecucion"
        Me.btn_Process.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-4, -4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1277, 101)
        Me.Panel1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(232, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(835, 51)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Opciones para obtener informacion del equipo remoto"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(-4, 462)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1277, 82)
        Me.Panel2.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(232, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(835, 51)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Opciones para controlar equipo remoto"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(38, 596)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(208, 74)
        Me.Button13.TabIndex = 14
        Me.Button13.Text = "Realizar captura de pantalla"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(38, 695)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(208, 74)
        Me.Button14.TabIndex = 15
        Me.Button14.Text = "Enviar mensaje a equipo remoto"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Location = New System.Drawing.Point(339, 596)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(208, 74)
        Me.Button15.TabIndex = 16
        Me.Button15.Text = "Subir volumen"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Location = New System.Drawing.Point(339, 695)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(208, 74)
        Me.Button16.TabIndex = 17
        Me.Button16.Text = "Bajar volumen"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Location = New System.Drawing.Point(659, 596)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(208, 74)
        Me.Button17.TabIndex = 18
        Me.Button17.Text = "Silenciar sonido"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.Location = New System.Drawing.Point(659, 695)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(208, 74)
        Me.Button18.TabIndex = 19
        Me.Button18.Text = "Apagar el equipo"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button19
        '
        Me.Button19.Location = New System.Drawing.Point(977, 596)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(208, 74)
        Me.Button19.TabIndex = 20
        Me.Button19.Text = "Reiniciar equipo"
        Me.Button19.UseVisualStyleBackColor = True
        '
        'Button20
        '
        Me.Button20.Location = New System.Drawing.Point(977, 695)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(208, 74)
        Me.Button20.TabIndex = 21
        Me.Button20.Text = "Cerrar sesion de windows"
        Me.Button20.UseVisualStyleBackColor = True
        '
        'ControllerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ClientSize = New System.Drawing.Size(1269, 805)
        Me.Controls.Add(Me.Button20)
        Me.Controls.Add(Me.Button19)
        Me.Controls.Add(Me.Button18)
        Me.Controls.Add(Me.Button17)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_Process)
        Me.Controls.Add(Me.btn_dateTime)
        Me.Controls.Add(Me.btn_timeZone)
        Me.Controls.Add(Me.btn_user)
        Me.Controls.Add(Me.btn_screenRes)
        Me.Controls.Add(Me.btn_drives)
        Me.Controls.Add(Me.btn_totalRam)
        Me.Controls.Add(Me.btn_cpuInfo)
        Me.Controls.Add(Me.btn_pcName)
        Me.Controls.Add(Me.btn_osVersion)
        Me.Controls.Add(Me.btn_osPlatform)
        Me.Controls.Add(Me.btn_osName)
        Me.Name = "ControllerForm"
        Me.Text = "Controller App"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_osName As Button
    Friend WithEvents btn_osPlatform As Button
    Friend WithEvents btn_osVersion As Button
    Friend WithEvents btn_pcName As Button
    Friend WithEvents btn_cpuInfo As Button
    Friend WithEvents btn_totalRam As Button
    Friend WithEvents btn_drives As Button
    Friend WithEvents btn_screenRes As Button
    Friend WithEvents btn_user As Button
    Friend WithEvents btn_timeZone As Button
    Friend WithEvents btn_dateTime As Button
    Friend WithEvents btn_Process As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents Button20 As Button
End Class
