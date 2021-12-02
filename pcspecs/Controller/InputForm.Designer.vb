<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputForm
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
        Me.txt_input = New System.Windows.Forms.TextBox()
        Me.btn_send = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_input
        '
        Me.txt_input.Font = New System.Drawing.Font("JetBrains Mono", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_input.Location = New System.Drawing.Point(46, 27)
        Me.txt_input.Multiline = True
        Me.txt_input.Name = "txt_input"
        Me.txt_input.Size = New System.Drawing.Size(728, 347)
        Me.txt_input.TabIndex = 0
        '
        'btn_send
        '
        Me.btn_send.BackColor = System.Drawing.Color.Yellow
        Me.btn_send.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_send.Location = New System.Drawing.Point(341, 413)
        Me.btn_send.Name = "btn_send"
        Me.btn_send.Size = New System.Drawing.Size(118, 46)
        Me.btn_send.TabIndex = 1
        Me.btn_send.Text = "Enviar"
        Me.btn_send.UseVisualStyleBackColor = False
        '
        'InputForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(810, 471)
        Me.Controls.Add(Me.btn_send)
        Me.Controls.Add(Me.txt_input)
        Me.Name = "InputForm"
        Me.Text = "Input Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_input As TextBox
    Friend WithEvents btn_send As Button
End Class
