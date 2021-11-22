<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RemoteForm
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
        Me.lb_status = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lb_status
        '
        Me.lb_status.AutoSize = True
        Me.lb_status.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lb_status.Location = New System.Drawing.Point(27, 18)
        Me.lb_status.Name = "lb_status"
        Me.lb_status.Size = New System.Drawing.Size(55, 15)
        Me.lb_status.TabIndex = 0
        Me.lb_status.Text = "ESTADO: "
        '
        'RemoteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 599)
        Me.Controls.Add(Me.lb_status)
        Me.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "RemoteForm"
        Me.Text = "Remote App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lb_status As Label
End Class
