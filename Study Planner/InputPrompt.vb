Public Class InputPrompt
    Public Event BtnOK_Click()
    Public Event BtnCn_Click()
    Private Sub SBtnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        RaiseEvent BtnOK_Click()
    End Sub

    Private Sub BtnCncl_Click(sender As Object, e As EventArgs) Handles btnCncl.Click
        RaiseEvent BtnCn_Click()
    End Sub

    Private Sub TxtInput_TextChanged(sender As Object, e As KeyEventArgs) Handles txtInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnOK.PerformClick()
        End If
    End Sub
End Class
