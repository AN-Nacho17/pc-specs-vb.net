<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetupForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_ip4 = New System.Windows.Forms.TextBox()
        Me.txt_ip3 = New System.Windows.Forms.TextBox()
        Me.txt_ip2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_ip1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.btn_localHost = New System.Windows.Forms.Button()
        Me.btn_test = New System.Windows.Forms.Button()
        Me.btn_clean = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightCoral
        Me.Panel1.Controls.Add(Me.txt_ip4)
        Me.Panel1.Controls.Add(Me.txt_ip3)
        Me.Panel1.Controls.Add(Me.txt_ip2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txt_ip1)
        Me.Panel1.Location = New System.Drawing.Point(83, 172)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(688, 125)
        Me.Panel1.TabIndex = 0
        '
        'txt_ip4
        '
        Me.txt_ip4.BackColor = System.Drawing.Color.White
        Me.txt_ip4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_ip4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_ip4.Location = New System.Drawing.Point(564, 49)
        Me.txt_ip4.MaxLength = 3
        Me.txt_ip4.Multiline = True
        Me.txt_ip4.Name = "txt_ip4"
        Me.txt_ip4.Size = New System.Drawing.Size(98, 45)
        Me.txt_ip4.TabIndex = 8
        Me.txt_ip4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_ip3
        '
        Me.txt_ip3.BackColor = System.Drawing.Color.White
        Me.txt_ip3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_ip3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_ip3.Location = New System.Drawing.Point(388, 49)
        Me.txt_ip3.MaxLength = 3
        Me.txt_ip3.Multiline = True
        Me.txt_ip3.Name = "txt_ip3"
        Me.txt_ip3.Size = New System.Drawing.Size(98, 45)
        Me.txt_ip3.TabIndex = 7
        Me.txt_ip3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_ip2
        '
        Me.txt_ip2.BackColor = System.Drawing.Color.White
        Me.txt_ip2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_ip2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_ip2.Location = New System.Drawing.Point(192, 49)
        Me.txt_ip2.MaxLength = 3
        Me.txt_ip2.Multiline = True
        Me.txt_ip2.Name = "txt_ip2"
        Me.txt_ip2.Size = New System.Drawing.Size(98, 45)
        Me.txt_ip2.TabIndex = 6
        Me.txt_ip2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(510, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 81)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(319, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 81)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(124, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 81)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_ip1
        '
        Me.txt_ip1.BackColor = System.Drawing.Color.White
        Me.txt_ip1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_ip1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_ip1.Location = New System.Drawing.Point(20, 49)
        Me.txt_ip1.MaxLength = 3
        Me.txt_ip1.Multiline = True
        Me.txt_ip1.Name = "txt_ip1"
        Me.txt_ip1.Size = New System.Drawing.Size(98, 45)
        Me.txt_ip1.TabIndex = 0
        Me.txt_ip1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(83, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(688, 79)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Digite un direccion IPv4"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_start
        '
        Me.btn_start.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_start.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_start.Location = New System.Drawing.Point(594, 410)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(177, 68)
        Me.btn_start.TabIndex = 2
        Me.btn_start.Text = "Comenzar"
        Me.btn_start.UseVisualStyleBackColor = False
        '
        'btn_localHost
        '
        Me.btn_localHost.BackColor = System.Drawing.Color.SandyBrown
        Me.btn_localHost.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_localHost.Location = New System.Drawing.Point(24, 410)
        Me.btn_localHost.Name = "btn_localHost"
        Me.btn_localHost.Size = New System.Drawing.Size(290, 68)
        Me.btn_localHost.TabIndex = 3
        Me.btn_localHost.Text = "Conectar a LOCALHOST"
        Me.btn_localHost.UseVisualStyleBackColor = False
        '
        'btn_test
        '
        Me.btn_test.BackColor = System.Drawing.Color.Teal
        Me.btn_test.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_test.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_test.Location = New System.Drawing.Point(451, 317)
        Me.btn_test.Name = "btn_test"
        Me.btn_test.Size = New System.Drawing.Size(153, 40)
        Me.btn_test.TabIndex = 4
        Me.btn_test.Text = "Probar"
        Me.btn_test.UseVisualStyleBackColor = False
        '
        'btn_clean
        '
        Me.btn_clean.BackColor = System.Drawing.Color.Firebrick
        Me.btn_clean.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_clean.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_clean.Location = New System.Drawing.Point(248, 317)
        Me.btn_clean.Name = "btn_clean"
        Me.btn_clean.Size = New System.Drawing.Size(153, 40)
        Me.btn_clean.TabIndex = 5
        Me.btn_clean.Text = "Limpiar"
        Me.btn_clean.UseVisualStyleBackColor = False
        '
        'SetupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(827, 506)
        Me.Controls.Add(Me.btn_clean)
        Me.Controls.Add(Me.btn_test)
        Me.Controls.Add(Me.btn_localHost)
        Me.Controls.Add(Me.btn_start)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SetupForm"
        Me.Text = "Setup Window"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_ip1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_ip4 As TextBox
    Friend WithEvents txt_ip3 As TextBox
    Friend WithEvents txt_ip2 As TextBox
    Friend WithEvents btn_start As Button
    Friend WithEvents btn_localHost As Button
    Friend WithEvents btn_test As Button
    Friend WithEvents btn_clean As Button
End Class
