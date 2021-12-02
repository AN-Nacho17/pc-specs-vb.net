Public Class InputForm

    Private UserMessageInput As String
    Private IsHide As Boolean = False

    Public Function GetIsHide()
        Return IsHide
    End Function

    Private Sub btn_send_Click(sender As Object, e As EventArgs) Handles btn_send.Click
        UserMessageInput = txt_input.Text
        Me.Hide()
        IsHide = True
    End Sub

    Public Function GetUserInput() As String
        Return UserMessageInput
    End Function

    Private Sub InputForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Control.CheckForIllegalCrossThreadCalls = False
        UserMessageInput = ""
        txt_input.Text = ""
    End Sub
End Class