'Update 1.1.0 (2016): 
'- Removed "Completed Checkboxing system". Application automatically marks subject as "completed" or not        (pending).
'- Add/Remove subject option now available.
'- No pre-loaded subjects
'- Application now shows where timetables are saved in settings
'- Settings automatically applied once changed, no need for OK/Cancel
'- Improved the loading wheel design (& code)

'Update 1.2.0 (2018):
'- Cleaned up the code to a significantly more professional standard.
'- Much more lightweight, removal of unneccessary timers and objects
'- This project will no longer be maintained.

Imports System.IO
Imports System.Threading

Public Class mainWindow
    Private Const DEFAULT_SUBJECT_TEXT = "Select Subject"
    Private Const DEFAULT_TIME_TEXT = "Select Time"
    Private stopWatch As New Stopwatch
    Private player As New WMPLib.WindowsMediaPlayer
    Private musicFilePath As String = Path.GetDirectoryName(Application.ExecutablePath)
    Private Const SECOND As Integer = 1000 '1 second = 1000 milliseconds
    Private Const HOUR As Integer = 3600 '1 hour = 3600 seconds
    'Get the subjects, this variable is auto-updated by the frmSettings on a change
    Public subjects As String() = My.Settings.Subjects.Split(New Char() {"&"c})


    Private Sub StudyPlanner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load the timer's value based on the last saved user input
        FrmSettings.toneInterval.Value = My.Settings.Duration / SECOND

        'Folder check
        If FrmSettings.folder.ToString = "" Then
            FrmSettings.folder = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            My.Settings.FolderLocation = FrmSettings.folder
            My.Settings.Save()
        End If

        'Music/Tones
        Dim appName() As Char = {"Study Planner.exe"}
        musicFilePath = musicFilePath.TrimEnd(appName)
        musicFilePath = musicFilePath.ToString & "\music.txt"
        ReadMusic()

        'ToneStop Interval
        If My.Settings.Duration > SECOND Then
            ToneStop.Interval = FrmSettings.toneInterval.Value * SECOND
        End If

        'Stopwatch text location
        StpWtchText.Location = New Point(520, 150)

        LoadSubjects()

        'Add the time
        For Each timeBox As ComboBox In timePanel.Controls
            timeBox.Items.AddRange({"0.5 hr", "0.5-1 hr", "1 hr", "1-1.5 hrs", "1.5 hrs", "1-2 hrs", "2 hrs"})
        Next
    End Sub


    Public Sub LoadSubjects()
        'Iterate through panel, getting each subject combobox
        'Clear it (for safety) and then add the subjects
        For Each subjectBox As ComboBox In subjectPanel.Controls
            subjectBox.Items.Clear()
            subjectBox.Items.AddRange(subjects)
        Next
    End Sub

    'Show the settings form
    Private Sub Settings_Click(sender As Object, e As EventArgs) Handles settings.Click
        FrmSettings.Show()
    End Sub

    'Clear all selections, recorded times and reset the stopwatch
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Set the default text
        For Each subjectBox As ComboBox In subjectPanel.Controls
            subjectBox.Text = DEFAULT_SUBJECT_TEXT
        Next
        For Each timeBox As ComboBox In timePanel.Controls
            timeBox.Text = DEFAULT_TIME_TEXT
        Next

        listTms.Items.Clear()
        StpWtchText.Location = New Point(520, 150)

    End Sub

    'Button load event handler
    'Loads a timetable file
    Private Sub BtnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        loadFileDialog.ShowDialog()
        Dim dataFile = loadFileDialog.FileName
        Try
            Dim reader As New StreamReader(dataFile, True)

            If loadFileDialog.FileName IsNot "" AndAlso loadFileDialog.CheckFileExists = True Then
                'Reading
                For Each subjectBox As ComboBox In subjectPanel.Controls
                    subjectBox.Text = reader.ReadLine
                Next
                For Each timeBox As ComboBox In timePanel.Controls
                    timeBox.Text = reader.ReadLine
                Next

                'Loop to update status if completed
                For Each status As Label In statusPanel.Controls
                    If reader.ReadLine = "Completed" Then
                        status.Text = "Completed"
                    End If
                Next

                'Set the tone
                toneSelect.SelectedItem = reader.ReadLine

                'Check which timer to start
                subjectTimer.Start()

                'Clear the recorded times
                listTms.Items.Clear()
                Try
                    'Check for and load any recorded times
                    For count As Integer = 1 To 6
                        StpWtchText.Location = New Point(523, 96)
                        listTms.Items.Add(reader.ReadLine.ToString)
                    Next
                Catch ex As Exception
                    'Preserve position if there are no records
                    If listTms.Items.Count < 1 Then
                        StpWtchText.Location = New Point(520, 150)
                    End If
                    reader.Close()
                    Return
                End Try
                reader.Close()
            End If
        Catch ex2 As Exception
            Return
        End Try
    End Sub
    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim dateTimeCur = DateTime.Today
        'Declare the filepath
        Dim filePath = FrmSettings.folder.ToString & "\Study Planner\Timetables\" &
                                dateTimeCur.ToString("MMM") & "-" & dateTimeCur.ToString("yy") & "\"

        Dim writePath = filePath & dateTimeCur.DayOfWeek.ToString & " " & dateTimeCur.ToString("dd") &
                    " " & dateTimeCur.ToString("MMM") & " " & dateTimeCur.ToString("yy") & ".txt"


        'Create file path if it doesn't exist
        If Not Directory.Exists(filePath) Then
            Directory.CreateDirectory(filePath)
        End If

        Using Writer As New StreamWriter(File.Open(writePath, FileMode.OpenOrCreate))
            'Writing the data
            For Each subjectBox As ComboBox In subjectPanel.Controls
                Writer.WriteLine(subjectBox.SelectedItem)
            Next
            For Each timerBox As ComboBox In timePanel.Controls
                Writer.WriteLine(timerBox.SelectedItem)
            Next
            For Each statusLabel As Label In statusPanel.Controls
                Writer.WriteLine(statusLabel.Text)
            Next

            Writer.WriteLine(toneSelect.Text)

            'If times have been recorded, write them
            If listTms.Items.Count > 0 Then
                For count As Integer = 0 To listTms.Items.Count - 1
                    If listTms.Items.Item(count).ToString <> "" Then
                        Writer.WriteLine(listTms.Items.Item(count).ToString)
                    End If
                Next
            End If
            Writer.Close()
        End Using
    End Sub

    'Updat the stopwatch text per tick
    Private Sub StpWtch_Tick(sender As Object, e As EventArgs) Handles stopWatchTimer.Tick
        Dim elapsed As TimeSpan = stopWatch.Elapsed
        StpWtchText.Text = String.Format("{0:00}:{1:00}:{2:00}", Math.Floor(elapsed.TotalHours),
                                         elapsed.Minutes, elapsed.Seconds)
    End Sub

    'Start the time
    Private Sub BtnStrt_Click(sender As Object, e As EventArgs) Handles btnStrt.Click
        stopWatchTimer.Start()
        stopWatch.Start()
        subjectTimer.Start()
    End Sub

    'Stop the time
    Private Sub BtnStp_Click(sender As Object, e As EventArgs) Handles btnStp.Click
        stopWatchTimer.Stop()
        stopWatch.Stop()
    End Sub

    'Reset the stopwatch
    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        stopWatch.Reset()
    End Sub

    'Register a time
    Private Sub BtnLap_Click(sender As Object, e As EventArgs) Handles btnLap.Click
        StpWtchText.Location = New Point(523, 96)
        listTms.Items.Add(vbTab & StpWtchText.Text)
        btnSubmit.PerformClick()
    End Sub

    'Add tones to the app
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        LoadMP3Dialog.Filter = "MP3 Files|*.mp3"
        Dim result As DialogResult = LoadMP3Dialog.ShowDialog()
        Dim toneList As New List(Of String)
        If result = Windows.Forms.DialogResult.OK Then
            For Each track As String In LoadMP3Dialog.FileNames
                toneList.Add(track)
                toneSelect.Items.Add(track.Substring(track.LastIndexOf("\") + 1))
                'Add to text file for later on
                Using Writer As New StreamWriter(File.Open(musicFilePath, FileMode.OpenOrCreate))
                    For Each item As String In toneList
                        Writer.WriteLine(item)
                    Next
                    Writer.Close()
                End Using
            Next
        End If
    End Sub

    'Subject timer tick handler
    'Checks if a subject has been completed
    'when it is, moves onto the next subject
    Private Sub SubjectTimer_Tick(sender As Object, e As EventArgs) Handles subjectTimer.Tick
        'Index of control item, control indexing is last to first
        Static index As Integer = statusPanel.Controls.Count - 1
        Dim pair As KeyValuePair(Of String, Integer)    'pair of key, value for dictionary iteration
        Dim currentTime = stopWatch.Elapsed.TotalSeconds
        Static newTime As Integer = 0   'Time since last subject completion, used as an offset

        Dim timeDict As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer) From
            {{"0.5 hr", HOUR / 2}, {"0.5-1 hr", HOUR / 2}, {"1 hr", HOUR}, {"1-1.5 hrs", HOUR},
            {"1.5 hrs", HOUR * 1.5}, {"1-2 hrs", HOUR}, {"2 hrs", HOUR * 2}}

        For Each pair In timeDict
            'Check if the timer has been completed for the current subject
            If statusPanel.Controls(index).Text = "Completed" Then
                'Move onto the next available subject
                If index - 1 >= 0 Then
                    index -= 1
                Else
                    'All following subjects complete
                    subjectTimer.Enabled = False
                End If
            ElseIf pair.Key = timePanel.Controls(index).Text AndAlso (currentTime - newTime) >= pair.Value Then
                Play()
                Dim subject As String = subjectPanel.Controls(index).Text.ToString
                Notify(subject)
                statusPanel.Controls(index).Text = "Completed"
                'Ensure we are not at the first index already
                If index - 1 >= 0 Then
                    index -= 1
                    newTime = stopWatch.Elapsed.TotalSeconds
                Else
                    btnSubmit.PerformClick()
                    subjectTimer.Enabled = False
                    Return
                End If
                'Submit the current timetable state
                btnSubmit.PerformClick()
                'Restart the timer
                subjectTimer.Enabled = False
                subjectTimer.Enabled = True
                Return
            End If
        Next
    End Sub

    'Play the tone
    Private Sub Play()
        Dim reader As New StreamReader(musicFilePath)
        Try
            For i As Integer = 0 To 100
                'Read line in file
                Dim line = reader.ReadLine
                'Check line exists
                If line <> Nothing Then
                    'if first tone, use current line as tone path
                    If toneSelect.SelectedIndex = 0 Then
                        player.URL = line.ToString
                        ToneStop.Start()
                        Return
                        'If line is previous item, then read one more
                    ElseIf line.Contains(toneSelect.Items.Item(toneSelect.SelectedIndex - 1)) Then
                        player.URL = reader.ReadLine.ToString
                        ToneStop.Start()
                        Return
                    End If
                End If
            Next
            reader.Close()
        Catch ex As Exception
#If DEBUG Then
            System.Console.WriteLine(ex)
#End If
            'Create new thread, otherwise message box instantiates infinitely.
            '.NET MessageBox is blocking
            Dim thread As New Thread(Sub()
                                         MessageBox.Show("The tone could not be found. Ensure that it exists.",
                                                         "Tone Not Found", MessageBoxButtons.OK)
                                     End Sub)
            thread.Start()
        End Try
    End Sub

    'Handles the balloon tip notification
    'Input param: completed subject name as string
    Private Sub Notify(subject As String)
        'Make the notification visible again to show BalloonTip
        notification.Visible = True
        Using notification As New NotifyIcon
            Me.notification.Icon = (My.Resources.App_Logo)
            Me.notification.BalloonTipTitle = subject & " Finished!"
            Me.notification.BalloonTipText = "You have completed the set time for the " & subject
            Me.notification.ShowBalloonTip(5)
            'Stop it from showing in notification area
            Me.notification.Visible = False
        End Using
    End Sub

    'Stop the tone
    Private Sub ToneStop_Tick(sender As Object, e As EventArgs) Handles ToneStop.Tick
        player.close()
        ToneStop.Stop()
    End Sub

    'Add tones from the music file
    Private Sub ReadMusic()
        toneSelect.Items.AddRange(File.ReadAllLines(musicFilePath))
        'Show only the track name
        For i As Integer = 0 To toneSelect.Items.Count - 1
            toneSelect.Items(i) = (toneSelect.Items(i).ToString.Substring(
                toneSelect.Items(i).ToString.LastIndexOf("\") + 1))
        Next
    End Sub

    'Play the tone
    Private Sub BtnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Play()
    End Sub

End Class