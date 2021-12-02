Public Class InputForm

    Private UserMessageInput As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_send.Click
        UserMessageInput = txt_input.Text
    End Sub

    Public Function GetUserInput()
        Return UserMessageInput
    End Function

    Private Sub InputForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        UserMessageInput = ""
        txt_input.Text = ""
    End Sub
End Class