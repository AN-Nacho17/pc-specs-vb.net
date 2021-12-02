<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BigForm
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
        Me.btn_close = New System.Windows.Forms.Button()
        Me.txt_display = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.Red
        Me.btn_close.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_close.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_close.Location = New System.Drawing.Point(647, 690)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(140, 56)
        Me.btn_close.TabIndex = 1
        Me.btn_close.Text = "Cerrar"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'txt_display
        '
        Me.txt_display.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_display.Font = New System.Drawing.Font("JetBrains Mono", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_display.ForeColor = System.Drawing.Color.SpringGreen
        Me.txt_display.Location = New System.Drawing.Point(34, 33)
        Me.txt_display.Name = "txt_display"
        Me.txt_display.Size = New System.Drawing.Size(1294, 615)
        Me.txt_display.TabIndex = 2
        Me.txt_display.Text = ""
        '
        'BigForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1383, 768)
        Me.Controls.Add(Me.txt_display)
        Me.Controls.Add(Me.btn_close)
        Me.Name = "BigForm"
        Me.Text = "Big Form Display"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_close As Button
    Friend WithEvents txt_display As RichTextBox
End Class
