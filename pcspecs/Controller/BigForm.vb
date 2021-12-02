Public Class BigForm
    Private Sub BigForm_Load(sender As Object, e As EventArgs)
        Me.CenterToScreen()
        txt_display.Enabled = False
    End Sub

    Public Sub SetText(Text As String)
        txt_display.Text = Text
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Hide()
    End Sub


End Class