<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RemoteForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lb_status = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lb_ipServer = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_output = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Orange
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-7, -5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1047, 89)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(360, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(337, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Equipo remoto "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(21, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(631, 50)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Estado de la conexion al equipo controlador: "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_status
        '
        Me.lb_status.BackColor = System.Drawing.Color.PowderBlue
        Me.lb_status.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lb_status.ForeColor = System.Drawing.Color.Black
        Me.lb_status.Location = New System.Drawing.Point(658, 153)
        Me.lb_status.Name = "lb_status"
        Me.lb_status.Size = New System.Drawing.Size(334, 50)
        Me.lb_status.TabIndex = 2
        Me.lb_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SteelBlue
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Orange
        Me.Label3.Location = New System.Drawing.Point(21, 275)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(471, 50)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Direccion IP del equipo servidor:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_ipServer
        '
        Me.lb_ipServer.BackColor = System.Drawing.Color.PowderBlue
        Me.lb_ipServer.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lb_ipServer.ForeColor = System.Drawing.Color.Black
        Me.lb_ipServer.Location = New System.Drawing.Point(644, 275)
        Me.lb_ipServer.Name = "lb_ipServer"
        Me.lb_ipServer.Size = New System.Drawing.Size(348, 50)
        Me.lb_ipServer.TabIndex = 4
        Me.lb_ipServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Orange
        Me.Label4.Location = New System.Drawing.Point(21, 388)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(322, 50)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Ventana de Output:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_output
        '
        Me.txt_output.BackColor = System.Drawing.Color.LightSlateGray
        Me.txt_output.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_output.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.txt_output.Location = New System.Drawing.Point(37, 471)
        Me.txt_output.Multiline = True
        Me.txt_output.Name = "txt_output"
        Me.txt_output.Size = New System.Drawing.Size(971, 221)
        Me.txt_output.TabIndex = 6
        '
        'RemoteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1041, 752)
        Me.Controls.Add(Me.txt_output)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lb_ipServer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lb_status)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RemoteForm"
        Me.Text = "Remote App"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lb_status As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lb_ipServer As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_output As TextBox
End Class
