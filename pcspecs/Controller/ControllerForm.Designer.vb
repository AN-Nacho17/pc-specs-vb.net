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
        Me.btn_takeScreenShot = New System.Windows.Forms.Button()
        Me.btn_sendMessage = New System.Windows.Forms.Button()
        Me.btn_volumeUp = New System.Windows.Forms.Button()
        Me.btn_volumeDown = New System.Windows.Forms.Button()
        Me.btn_mute = New System.Windows.Forms.Button()
        Me.btn_shutdown = New System.Windows.Forms.Button()
        Me.btn_restart = New System.Windows.Forms.Button()
        Me.btn_closeSession = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_osName
        '
        Me.btn_osName.AutoSize = True
        Me.btn_osName.BackColor = System.Drawing.Color.Salmon
        Me.btn_osName.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_osName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_osName.Location = New System.Drawing.Point(38, 126)
        Me.btn_osName.Name = "btn_osName"
        Me.btn_osName.Size = New System.Drawing.Size(230, 79)
        Me.btn_osName.TabIndex = 0
        Me.btn_osName.Text = "Nombre Completo SO"
        Me.btn_osName.UseVisualStyleBackColor = False
        '
        'btn_osPlatform
        '
        Me.btn_osPlatform.AutoSize = True
        Me.btn_osPlatform.BackColor = System.Drawing.Color.Salmon
        Me.btn_osPlatform.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_osPlatform.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_osPlatform.Location = New System.Drawing.Point(38, 236)
        Me.btn_osPlatform.Name = "btn_osPlatform"
        Me.btn_osPlatform.Size = New System.Drawing.Size(230, 77)
        Me.btn_osPlatform.TabIndex = 1
        Me.btn_osPlatform.Text = "Plataforma del SO"
        Me.btn_osPlatform.UseVisualStyleBackColor = False
        '
        'btn_osVersion
        '
        Me.btn_osVersion.AutoSize = True
        Me.btn_osVersion.BackColor = System.Drawing.Color.Salmon
        Me.btn_osVersion.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_osVersion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_osVersion.Location = New System.Drawing.Point(38, 345)
        Me.btn_osVersion.Name = "btn_osVersion"
        Me.btn_osVersion.Size = New System.Drawing.Size(230, 79)
        Me.btn_osVersion.TabIndex = 2
        Me.btn_osVersion.Text = "Version SO"
        Me.btn_osVersion.UseVisualStyleBackColor = False
        '
        'btn_pcName
        '
        Me.btn_pcName.AutoSize = True
        Me.btn_pcName.BackColor = System.Drawing.Color.Salmon
        Me.btn_pcName.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_pcName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_pcName.Location = New System.Drawing.Point(512, 126)
        Me.btn_pcName.Name = "btn_pcName"
        Me.btn_pcName.Size = New System.Drawing.Size(219, 57)
        Me.btn_pcName.TabIndex = 3
        Me.btn_pcName.Text = "Nombre del equipo"
        Me.btn_pcName.UseVisualStyleBackColor = False
        '
        'btn_cpuInfo
        '
        Me.btn_cpuInfo.AutoSize = True
        Me.btn_cpuInfo.BackColor = System.Drawing.Color.Salmon
        Me.btn_cpuInfo.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_cpuInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_cpuInfo.Location = New System.Drawing.Point(512, 212)
        Me.btn_cpuInfo.Name = "btn_cpuInfo"
        Me.btn_cpuInfo.Size = New System.Drawing.Size(219, 55)
        Me.btn_cpuInfo.TabIndex = 4
        Me.btn_cpuInfo.Text = "Informacion del CPU"
        Me.btn_cpuInfo.UseVisualStyleBackColor = False
        '
        'btn_totalRam
        '
        Me.btn_totalRam.AutoSize = True
        Me.btn_totalRam.BackColor = System.Drawing.Color.Salmon
        Me.btn_totalRam.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_totalRam.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_totalRam.Location = New System.Drawing.Point(512, 289)
        Me.btn_totalRam.Name = "btn_totalRam"
        Me.btn_totalRam.Size = New System.Drawing.Size(219, 57)
        Me.btn_totalRam.TabIndex = 5
        Me.btn_totalRam.Text = "Total RAM(GB)"
        Me.btn_totalRam.UseVisualStyleBackColor = False
        '
        'btn_drives
        '
        Me.btn_drives.AutoSize = True
        Me.btn_drives.BackColor = System.Drawing.Color.Salmon
        Me.btn_drives.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_drives.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_drives.Location = New System.Drawing.Point(512, 367)
        Me.btn_drives.Name = "btn_drives"
        Me.btn_drives.Size = New System.Drawing.Size(219, 57)
        Me.btn_drives.TabIndex = 6
        Me.btn_drives.Text = "Lista Unidades de Disco"
        Me.btn_drives.UseVisualStyleBackColor = False
        '
        'btn_screenRes
        '
        Me.btn_screenRes.AutoSize = True
        Me.btn_screenRes.BackColor = System.Drawing.Color.Salmon
        Me.btn_screenRes.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_screenRes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_screenRes.Location = New System.Drawing.Point(977, 126)
        Me.btn_screenRes.Name = "btn_screenRes"
        Me.btn_screenRes.Size = New System.Drawing.Size(208, 48)
        Me.btn_screenRes.TabIndex = 7
        Me.btn_screenRes.Text = "Resolucion de pantalla"
        Me.btn_screenRes.UseVisualStyleBackColor = False
        '
        'btn_user
        '
        Me.btn_user.AutoSize = True
        Me.btn_user.BackColor = System.Drawing.Color.Salmon
        Me.btn_user.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_user.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_user.Location = New System.Drawing.Point(977, 192)
        Me.btn_user.Name = "btn_user"
        Me.btn_user.Size = New System.Drawing.Size(208, 46)
        Me.btn_user.TabIndex = 8
        Me.btn_user.Text = "Nombre de usuario"
        Me.btn_user.UseVisualStyleBackColor = False
        '
        'btn_timeZone
        '
        Me.btn_timeZone.AutoSize = True
        Me.btn_timeZone.BackColor = System.Drawing.Color.Salmon
        Me.btn_timeZone.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_timeZone.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_timeZone.Location = New System.Drawing.Point(977, 255)
        Me.btn_timeZone.Name = "btn_timeZone"
        Me.btn_timeZone.Size = New System.Drawing.Size(208, 48)
        Me.btn_timeZone.TabIndex = 9
        Me.btn_timeZone.Text = "Zona horaria "
        Me.btn_timeZone.UseVisualStyleBackColor = False
        '
        'btn_dateTime
        '
        Me.btn_dateTime.AutoSize = True
        Me.btn_dateTime.BackColor = System.Drawing.Color.Salmon
        Me.btn_dateTime.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_dateTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_dateTime.Location = New System.Drawing.Point(977, 324)
        Me.btn_dateTime.Name = "btn_dateTime"
        Me.btn_dateTime.Size = New System.Drawing.Size(208, 48)
        Me.btn_dateTime.TabIndex = 10
        Me.btn_dateTime.Text = "Fecha y hora del equipo"
        Me.btn_dateTime.UseVisualStyleBackColor = False
        '
        'btn_Process
        '
        Me.btn_Process.AutoSize = True
        Me.btn_Process.BackColor = System.Drawing.Color.Salmon
        Me.btn_Process.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_Process.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Process.Location = New System.Drawing.Point(977, 391)
        Me.btn_Process.Name = "btn_Process"
        Me.btn_Process.Size = New System.Drawing.Size(251, 48)
        Me.btn_Process.TabIndex = 11
        Me.btn_Process.Text = "Lista de procesos en ejecucion"
        Me.btn_Process.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-4, -4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1317, 101)
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
        Me.Panel2.Size = New System.Drawing.Size(1317, 82)
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
        'btn_takeScreenShot
        '
        Me.btn_takeScreenShot.BackColor = System.Drawing.Color.HotPink
        Me.btn_takeScreenShot.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_takeScreenShot.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_takeScreenShot.Location = New System.Drawing.Point(38, 596)
        Me.btn_takeScreenShot.Name = "btn_takeScreenShot"
        Me.btn_takeScreenShot.Size = New System.Drawing.Size(208, 74)
        Me.btn_takeScreenShot.TabIndex = 14
        Me.btn_takeScreenShot.Text = "Realizar captura de pantalla"
        Me.btn_takeScreenShot.UseVisualStyleBackColor = False
        '
        'btn_sendMessage
        '
        Me.btn_sendMessage.BackColor = System.Drawing.Color.HotPink
        Me.btn_sendMessage.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_sendMessage.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_sendMessage.Location = New System.Drawing.Point(38, 695)
        Me.btn_sendMessage.Name = "btn_sendMessage"
        Me.btn_sendMessage.Size = New System.Drawing.Size(208, 74)
        Me.btn_sendMessage.TabIndex = 15
        Me.btn_sendMessage.Text = "Enviar mensaje a equipo remoto"
        Me.btn_sendMessage.UseVisualStyleBackColor = False
        '
        'btn_volumeUp
        '
        Me.btn_volumeUp.BackColor = System.Drawing.Color.HotPink
        Me.btn_volumeUp.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_volumeUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_volumeUp.Location = New System.Drawing.Point(339, 596)
        Me.btn_volumeUp.Name = "btn_volumeUp"
        Me.btn_volumeUp.Size = New System.Drawing.Size(208, 74)
        Me.btn_volumeUp.TabIndex = 16
        Me.btn_volumeUp.Text = "Subir volumen"
        Me.btn_volumeUp.UseVisualStyleBackColor = False
        '
        'btn_volumeDown
        '
        Me.btn_volumeDown.BackColor = System.Drawing.Color.HotPink
        Me.btn_volumeDown.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_volumeDown.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_volumeDown.Location = New System.Drawing.Point(339, 695)
        Me.btn_volumeDown.Name = "btn_volumeDown"
        Me.btn_volumeDown.Size = New System.Drawing.Size(208, 74)
        Me.btn_volumeDown.TabIndex = 17
        Me.btn_volumeDown.Text = "Bajar volumen"
        Me.btn_volumeDown.UseVisualStyleBackColor = False
        '
        'btn_mute
        '
        Me.btn_mute.BackColor = System.Drawing.Color.HotPink
        Me.btn_mute.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_mute.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_mute.Location = New System.Drawing.Point(659, 596)
        Me.btn_mute.Name = "btn_mute"
        Me.btn_mute.Size = New System.Drawing.Size(208, 74)
        Me.btn_mute.TabIndex = 18
        Me.btn_mute.Text = "Silenciar sonido"
        Me.btn_mute.UseVisualStyleBackColor = False
        '
        'btn_shutdown
        '
        Me.btn_shutdown.BackColor = System.Drawing.Color.HotPink
        Me.btn_shutdown.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_shutdown.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_shutdown.Location = New System.Drawing.Point(659, 695)
        Me.btn_shutdown.Name = "btn_shutdown"
        Me.btn_shutdown.Size = New System.Drawing.Size(208, 74)
        Me.btn_shutdown.TabIndex = 19
        Me.btn_shutdown.Text = "Apagar el equipo"
        Me.btn_shutdown.UseVisualStyleBackColor = False
        '
        'btn_restart
        '
        Me.btn_restart.BackColor = System.Drawing.Color.HotPink
        Me.btn_restart.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_restart.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_restart.Location = New System.Drawing.Point(977, 596)
        Me.btn_restart.Name = "btn_restart"
        Me.btn_restart.Size = New System.Drawing.Size(208, 74)
        Me.btn_restart.TabIndex = 20
        Me.btn_restart.Text = "Reiniciar equipo"
        Me.btn_restart.UseVisualStyleBackColor = False
        '
        'btn_closeSession
        '
        Me.btn_closeSession.BackColor = System.Drawing.Color.HotPink
        Me.btn_closeSession.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_closeSession.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_closeSession.Location = New System.Drawing.Point(977, 695)
        Me.btn_closeSession.Name = "btn_closeSession"
        Me.btn_closeSession.Size = New System.Drawing.Size(208, 74)
        Me.btn_closeSession.TabIndex = 21
        Me.btn_closeSession.Text = "Cerrar sesion de windows"
        Me.btn_closeSession.UseVisualStyleBackColor = False
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Plum
        Me.btn_back.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_back.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_back.Location = New System.Drawing.Point(38, 806)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(142, 56)
        Me.btn_back.TabIndex = 22
        Me.btn_back.Text = "Regresar"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'ControllerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ClientSize = New System.Drawing.Size(1302, 874)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_closeSession)
        Me.Controls.Add(Me.btn_restart)
        Me.Controls.Add(Me.btn_shutdown)
        Me.Controls.Add(Me.btn_mute)
        Me.Controls.Add(Me.btn_volumeDown)
        Me.Controls.Add(Me.btn_volumeUp)
        Me.Controls.Add(Me.btn_sendMessage)
        Me.Controls.Add(Me.btn_takeScreenShot)
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
        Me.PerformLayout()

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
    Friend WithEvents btn_takeScreenShot As Button
    Friend WithEvents btn_sendMessage As Button
    Friend WithEvents btn_volumeUp As Button
    Friend WithEvents btn_volumeDown As Button
    Friend WithEvents btn_mute As Button
    Friend WithEvents btn_shutdown As Button
    Friend WithEvents btn_restart As Button
    Friend WithEvents btn_closeSession As Button
    Friend WithEvents btn_back As Button
End Class
