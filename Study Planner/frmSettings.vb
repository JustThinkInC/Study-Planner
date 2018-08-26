Public Class FrmSettings
    Private Const SECOND As Integer = 1000
    Public folder As String = My.Settings.FolderLocation
    Public WithEvents BtnOK As Button
    Public WithEvents BtnCancel As Button


    Private Sub FrmSettings_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddHandler subjInput.btnOK.Click, AddressOf BtnOK_Click
        AddHandler subjInput.btnCncl.Click, AddressOf BtnCncl_Click
        subjInput.Hide()
        lblPath.Text += vbNewLine & folder
        Dim Subjects As String() = My.Settings.Subjects.Split(New Char() {"&"c})
        lstSbj.Items.AddRange(Subjects)
        toneInterval.Value = My.Settings.Duration / SECOND
    End Sub


    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        If lstSbj.Items.Item(0).ToString = "Add subjects using 'Add' button" Then
            lstSbj.Items.Item(0) = subjInput.txtInput.Text
        Else
            lstSbj.Items.Add(subjInput.txtInput.Text)
        End If

        SubjectStringSave()
        subjInput.txtInput.ResetText()
        subjInput.Hide()
    End Sub


    Private Sub BtnCncl_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        subjInput.txtInput.ResetText()
        subjInput.Hide()
    End Sub


    Private Sub RdCstm_Click(sender As Object, e As EventArgs) Handles radioCustom.Click
        radioCustom.Checked = True
        If brwse.ShowDialog = DialogResult.OK Then
            My.Settings.FolderLocation = brwse.SelectedPath
            My.Settings.Save()
            folder = My.Settings.FolderLocation
            lblPath.Text = "Currently writing in:" & vbNewLine & folder
        Else
            radioCustom.Checked = False
            radioDefault.Checked = True
        End If
    End Sub


    Private Sub RdDefault_CheckedChanged(sender As Object, e As EventArgs) Handles radioDefault.Click
        radioDefault.Checked = True
        My.Settings.FolderLocation = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        folder = My.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString
    End Sub


    Private Sub Interval_ValueChanged(sender As Object, e As EventArgs) Handles toneInterval.ValueChanged
        My.Settings.Duration = toneInterval.Value * SECOND
        My.Settings.Save()
        mainWindow.ToneStop.Interval = My.Settings.Duration
    End Sub


    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        subjInput.lblMsg.ForeColor = Color.FromArgb(255, 128, 0)
        subjInput.lblMsg.Font = New Font("Calibri", 12, FontStyle.Bold)
        subjInput.lblMsg.Text = "Enter Subject"
        subjInput.lblMsg.Location = New Point(subjInput.txtInput.Width / 1.75, subjInput.lblMsg.Location.Y)
        subjInput.Show()
    End Sub


    Private Sub BtnRmv_Click(sender As Object, e As EventArgs) Handles btnRmv.Click
        If lstSbj.Items.Count <= 1 Then
            MessageBox.Show("Cannot have no subjects. Please add another subject before removing this one.",
                                "Cannot Remove Subject", MessageBoxButtons.OK)
            Return
        End If
        While lstSbj.CheckedItems.Count > 0
            lstSbj.Items.Remove(lstSbj.CheckedItems(0))
        End While
        SubjectStringSave()
    End Sub


    Private Function SubjectStringSave()
        Dim subject As String = ""
        Try
            For i = 0 To lstSbj.Items.Count - 1
                subject += lstSbj.Items.Item(i).ToString & "&"
            Next
            subject = subject.Trim().Remove(subject.Length - 1)
        Catch ex As Exception
            'MessageBox.Show("You cannot remove the first subject template. It is natural for it to appear blank.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            subject = ""
        End Try
        My.Settings.Subjects = subject.ToString
        My.Settings.Save()
        mainWindow.subjects = My.Settings.Subjects.Split(New Char() {"&"c})
        mainWindow.LoadSubjects()

        Return subject
    End Function


    Private Sub LstSbj_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSbj.SelectedIndexChanged
        lstSbj.ClearSelected()
    End Sub

End Class