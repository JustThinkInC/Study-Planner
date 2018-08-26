<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainWindow
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainWindow))
        Me.subject1 = New System.Windows.Forms.ComboBox()
        Me.subject2 = New System.Windows.Forms.ComboBox()
        Me.subject3 = New System.Windows.Forms.ComboBox()
        Me.subject4 = New System.Windows.Forms.ComboBox()
        Me.subject5 = New System.Windows.Forms.ComboBox()
        Me.subject6 = New System.Windows.Forms.ComboBox()
        Me.time1 = New System.Windows.Forms.ComboBox()
        Me.time2 = New System.Windows.Forms.ComboBox()
        Me.time3 = New System.Windows.Forms.ComboBox()
        Me.time4 = New System.Windows.Forms.ComboBox()
        Me.time5 = New System.Windows.Forms.ComboBox()
        Me.time6 = New System.Windows.Forms.ComboBox()
        Me.lblSbjct = New System.Windows.Forms.Label()
        Me.lblTme = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.loadFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.StpWtchText = New System.Windows.Forms.Label()
        Me.stopWatchTimer = New System.Windows.Forms.Timer(Me.components)
        Me.btnStrt = New System.Windows.Forms.Button()
        Me.btnStp = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblStpWtch = New System.Windows.Forms.Label()
        Me.toneSelect = New System.Windows.Forms.ComboBox()
        Me.LoadMP3Dialog = New System.Windows.Forms.OpenFileDialog()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.subjectTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ToneStop = New System.Windows.Forms.Timer(Me.components)
        Me.notification = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.listTms = New System.Windows.Forms.ListBox()
        Me.btnLap = New System.Windows.Forms.Button()
        Me.settings = New System.Windows.Forms.Label()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.status1 = New System.Windows.Forms.Label()
        Me.status2 = New System.Windows.Forms.Label()
        Me.status3 = New System.Windows.Forms.Label()
        Me.status4 = New System.Windows.Forms.Label()
        Me.status5 = New System.Windows.Forms.Label()
        Me.status6 = New System.Windows.Forms.Label()
        Me.subjectPanel = New System.Windows.Forms.Panel()
        Me.timePanel = New System.Windows.Forms.Panel()
        Me.statusPanel = New System.Windows.Forms.Panel()
        Me.subjectPanel.SuspendLayout()
        Me.timePanel.SuspendLayout()
        Me.statusPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'subject1
        '
        Me.subject1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subject1.FormattingEnabled = True
        Me.subject1.Location = New System.Drawing.Point(16, 17)
        Me.subject1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.subject1.Name = "subject1"
        Me.subject1.Size = New System.Drawing.Size(143, 27)
        Me.subject1.TabIndex = 0
        Me.subject1.Text = "Select Subject"
        '
        'subject2
        '
        Me.subject2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subject2.FormattingEnabled = True
        Me.subject2.Location = New System.Drawing.Point(16, 67)
        Me.subject2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.subject2.Name = "subject2"
        Me.subject2.Size = New System.Drawing.Size(143, 27)
        Me.subject2.TabIndex = 1
        Me.subject2.Text = "Select Subject"
        '
        'subject3
        '
        Me.subject3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subject3.FormattingEnabled = True
        Me.subject3.Location = New System.Drawing.Point(16, 116)
        Me.subject3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.subject3.Name = "subject3"
        Me.subject3.Size = New System.Drawing.Size(143, 27)
        Me.subject3.TabIndex = 2
        Me.subject3.Text = "Select Subject"
        '
        'subject4
        '
        Me.subject4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subject4.FormattingEnabled = True
        Me.subject4.Location = New System.Drawing.Point(16, 164)
        Me.subject4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.subject4.Name = "subject4"
        Me.subject4.Size = New System.Drawing.Size(143, 27)
        Me.subject4.TabIndex = 3
        Me.subject4.Text = "Select Subject"
        '
        'subject5
        '
        Me.subject5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subject5.FormattingEnabled = True
        Me.subject5.Location = New System.Drawing.Point(16, 210)
        Me.subject5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.subject5.Name = "subject5"
        Me.subject5.Size = New System.Drawing.Size(143, 27)
        Me.subject5.TabIndex = 4
        Me.subject5.Text = "Select Subject"
        '
        'subject6
        '
        Me.subject6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subject6.FormattingEnabled = True
        Me.subject6.Location = New System.Drawing.Point(16, 256)
        Me.subject6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.subject6.Name = "subject6"
        Me.subject6.Size = New System.Drawing.Size(143, 27)
        Me.subject6.TabIndex = 5
        Me.subject6.Text = "Select Subject"
        '
        'time1
        '
        Me.time1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time1.FormattingEnabled = True
        Me.time1.Location = New System.Drawing.Point(18, 12)
        Me.time1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.time1.Name = "time1"
        Me.time1.Size = New System.Drawing.Size(143, 27)
        Me.time1.TabIndex = 6
        Me.time1.Text = "Select Time"
        '
        'time2
        '
        Me.time2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time2.FormattingEnabled = True
        Me.time2.Location = New System.Drawing.Point(18, 62)
        Me.time2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.time2.Name = "time2"
        Me.time2.Size = New System.Drawing.Size(143, 27)
        Me.time2.TabIndex = 7
        Me.time2.Text = "Select Time"
        '
        'time3
        '
        Me.time3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time3.FormattingEnabled = True
        Me.time3.Location = New System.Drawing.Point(18, 111)
        Me.time3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.time3.Name = "time3"
        Me.time3.Size = New System.Drawing.Size(143, 27)
        Me.time3.TabIndex = 8
        Me.time3.Text = "Select Time"
        '
        'time4
        '
        Me.time4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time4.FormattingEnabled = True
        Me.time4.Location = New System.Drawing.Point(18, 159)
        Me.time4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.time4.Name = "time4"
        Me.time4.Size = New System.Drawing.Size(143, 27)
        Me.time4.TabIndex = 9
        Me.time4.Text = "Select Time"
        '
        'time5
        '
        Me.time5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time5.FormattingEnabled = True
        Me.time5.Location = New System.Drawing.Point(18, 205)
        Me.time5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.time5.Name = "time5"
        Me.time5.Size = New System.Drawing.Size(143, 27)
        Me.time5.TabIndex = 10
        Me.time5.Text = "Select Time"
        '
        'time6
        '
        Me.time6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time6.FormattingEnabled = True
        Me.time6.Location = New System.Drawing.Point(18, 251)
        Me.time6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.time6.Name = "time6"
        Me.time6.Size = New System.Drawing.Size(143, 27)
        Me.time6.TabIndex = 11
        Me.time6.Text = "Select Time"
        '
        'lblSbjct
        '
        Me.lblSbjct.AutoSize = True
        Me.lblSbjct.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSbjct.Location = New System.Drawing.Point(88, 22)
        Me.lblSbjct.Name = "lblSbjct"
        Me.lblSbjct.Size = New System.Drawing.Size(60, 20)
        Me.lblSbjct.TabIndex = 18
        Me.lblSbjct.Text = "Subject"
        '
        'lblTme
        '
        Me.lblTme.AutoSize = True
        Me.lblTme.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTme.Location = New System.Drawing.Point(339, 22)
        Me.lblTme.Name = "lblTme"
        Me.lblTme.Size = New System.Drawing.Size(44, 20)
        Me.lblTme.TabIndex = 19
        Me.lblTme.Text = "Time"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(549, 22)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(53, 20)
        Me.lblStatus.TabIndex = 20
        Me.lblStatus.Text = "Status"
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(531, 364)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(117, 26)
        Me.btnClear.TabIndex = 21
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(83, 364)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(117, 26)
        Me.btnSubmit.TabIndex = 22
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(323, 364)
        Me.btnLoad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(117, 26)
        Me.btnLoad.TabIndex = 23
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'StpWtchText
        '
        Me.StpWtchText.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StpWtchText.ForeColor = System.Drawing.Color.Lime
        Me.StpWtchText.Location = New System.Drawing.Point(697, 124)
        Me.StpWtchText.Name = "StpWtchText"
        Me.StpWtchText.Size = New System.Drawing.Size(284, 52)
        Me.StpWtchText.TabIndex = 24
        Me.StpWtchText.Text = "00:00:00"
        Me.StpWtchText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'stopWatchTimer
        '
        '
        'btnStrt
        '
        Me.btnStrt.Location = New System.Drawing.Point(705, 331)
        Me.btnStrt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnStrt.Name = "btnStrt"
        Me.btnStrt.Size = New System.Drawing.Size(117, 26)
        Me.btnStrt.TabIndex = 25
        Me.btnStrt.Text = "Start"
        Me.btnStrt.UseVisualStyleBackColor = True
        '
        'btnStp
        '
        Me.btnStp.Location = New System.Drawing.Point(852, 331)
        Me.btnStp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnStp.Name = "btnStp"
        Me.btnStp.Size = New System.Drawing.Size(117, 26)
        Me.btnStp.TabIndex = 26
        Me.btnStp.Text = "Stop"
        Me.btnStp.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(705, 364)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(117, 26)
        Me.btnReset.TabIndex = 27
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblStpWtch
        '
        Me.lblStpWtch.AutoSize = True
        Me.lblStpWtch.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStpWtch.Location = New System.Drawing.Point(767, 22)
        Me.lblStpWtch.Name = "lblStpWtch"
        Me.lblStpWtch.Size = New System.Drawing.Size(83, 20)
        Me.lblStpWtch.TabIndex = 28
        Me.lblStpWtch.Text = "Stopwatch"
        '
        'toneSelect
        '
        Me.toneSelect.FormattingEnabled = True
        Me.toneSelect.Location = New System.Drawing.Point(711, 68)
        Me.toneSelect.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.toneSelect.Name = "toneSelect"
        Me.toneSelect.Size = New System.Drawing.Size(143, 24)
        Me.toneSelect.TabIndex = 29
        Me.toneSelect.Text = "Select Tone"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(879, 55)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(117, 26)
        Me.btnAdd.TabIndex = 30
        Me.btnAdd.Text = "Add Tone"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'subjectTimer
        '
        Me.subjectTimer.Enabled = True
        Me.subjectTimer.Interval = 1000
        '
        'ToneStop
        '
        Me.ToneStop.Interval = 5000
        '
        'notification
        '
        Me.notification.Text = "notifyCmplt"
        Me.notification.Visible = True
        '
        'listTms
        '
        Me.listTms.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listTms.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listTms.ForeColor = System.Drawing.Color.Fuchsia
        Me.listTms.FormattingEnabled = True
        Me.listTms.ItemHeight = 20
        Me.listTms.Location = New System.Drawing.Point(720, 192)
        Me.listTms.Margin = New System.Windows.Forms.Padding(4)
        Me.listTms.Name = "listTms"
        Me.listTms.Size = New System.Drawing.Size(197, 100)
        Me.listTms.TabIndex = 31
        Me.listTms.Tag = ""
        '
        'btnLap
        '
        Me.btnLap.Location = New System.Drawing.Point(852, 364)
        Me.btnLap.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLap.Name = "btnLap"
        Me.btnLap.Size = New System.Drawing.Size(117, 26)
        Me.btnLap.TabIndex = 32
        Me.btnLap.Text = "Record Time"
        Me.btnLap.UseVisualStyleBackColor = True
        '
        'settings
        '
        Me.settings.Image = Global.Study_Planner.My.Resources.Resources.WinSettings
        Me.settings.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.settings.Location = New System.Drawing.Point(0, -4)
        Me.settings.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.settings.Name = "settings"
        Me.settings.Size = New System.Drawing.Size(40, 46)
        Me.settings.TabIndex = 33
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(879, 89)
        Me.btnPlay.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(117, 26)
        Me.btnPlay.TabIndex = 34
        Me.btnPlay.Text = "Play Tone"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'status1
        '
        Me.status1.AutoSize = True
        Me.status1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status1.Location = New System.Drawing.Point(20, 12)
        Me.status1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.status1.Name = "status1"
        Me.status1.Size = New System.Drawing.Size(72, 23)
        Me.status1.TabIndex = 35
        Me.status1.Text = "Pending"
        '
        'status2
        '
        Me.status2.AutoSize = True
        Me.status2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status2.Location = New System.Drawing.Point(20, 62)
        Me.status2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.status2.Name = "status2"
        Me.status2.Size = New System.Drawing.Size(72, 23)
        Me.status2.TabIndex = 36
        Me.status2.Text = "Pending"
        '
        'status3
        '
        Me.status3.AutoSize = True
        Me.status3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status3.Location = New System.Drawing.Point(20, 112)
        Me.status3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.status3.Name = "status3"
        Me.status3.Size = New System.Drawing.Size(72, 23)
        Me.status3.TabIndex = 37
        Me.status3.Text = "Pending"
        '
        'status4
        '
        Me.status4.AutoSize = True
        Me.status4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status4.Location = New System.Drawing.Point(20, 160)
        Me.status4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.status4.Name = "status4"
        Me.status4.Size = New System.Drawing.Size(72, 23)
        Me.status4.TabIndex = 38
        Me.status4.Text = "Pending"
        '
        'status5
        '
        Me.status5.AutoSize = True
        Me.status5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status5.Location = New System.Drawing.Point(20, 205)
        Me.status5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.status5.Name = "status5"
        Me.status5.Size = New System.Drawing.Size(72, 23)
        Me.status5.TabIndex = 39
        Me.status5.Text = "Pending"
        '
        'status6
        '
        Me.status6.AutoSize = True
        Me.status6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status6.Location = New System.Drawing.Point(20, 251)
        Me.status6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.status6.Name = "status6"
        Me.status6.Size = New System.Drawing.Size(72, 23)
        Me.status6.TabIndex = 40
        Me.status6.Text = "Pending"
        '
        'subjectPanel
        '
        Me.subjectPanel.Controls.Add(Me.subject6)
        Me.subjectPanel.Controls.Add(Me.subject5)
        Me.subjectPanel.Controls.Add(Me.subject4)
        Me.subjectPanel.Controls.Add(Me.subject3)
        Me.subjectPanel.Controls.Add(Me.subject2)
        Me.subjectPanel.Controls.Add(Me.subject1)
        Me.subjectPanel.Location = New System.Drawing.Point(51, 46)
        Me.subjectPanel.Name = "subjectPanel"
        Me.subjectPanel.Size = New System.Drawing.Size(188, 310)
        Me.subjectPanel.TabIndex = 41
        '
        'timePanel
        '
        Me.timePanel.Controls.Add(Me.time6)
        Me.timePanel.Controls.Add(Me.time5)
        Me.timePanel.Controls.Add(Me.time4)
        Me.timePanel.Controls.Add(Me.time3)
        Me.timePanel.Controls.Add(Me.time2)
        Me.timePanel.Controls.Add(Me.time1)
        Me.timePanel.Location = New System.Drawing.Point(289, 51)
        Me.timePanel.Name = "timePanel"
        Me.timePanel.Size = New System.Drawing.Size(176, 293)
        Me.timePanel.TabIndex = 42
        '
        'statusPanel
        '
        Me.statusPanel.Controls.Add(Me.status6)
        Me.statusPanel.Controls.Add(Me.status5)
        Me.statusPanel.Controls.Add(Me.status4)
        Me.statusPanel.Controls.Add(Me.status3)
        Me.statusPanel.Controls.Add(Me.status2)
        Me.statusPanel.Controls.Add(Me.status1)
        Me.statusPanel.Location = New System.Drawing.Point(529, 52)
        Me.statusPanel.Name = "statusPanel"
        Me.statusPanel.Size = New System.Drawing.Size(136, 291)
        Me.statusPanel.TabIndex = 43
        '
        'mainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1035, 405)
        Me.Controls.Add(Me.statusPanel)
        Me.Controls.Add(Me.timePanel)
        Me.Controls.Add(Me.subjectPanel)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.settings)
        Me.Controls.Add(Me.StpWtchText)
        Me.Controls.Add(Me.listTms)
        Me.Controls.Add(Me.btnLap)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.toneSelect)
        Me.Controls.Add(Me.lblStpWtch)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnStp)
        Me.Controls.Add(Me.btnStrt)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblTme)
        Me.Controls.Add(Me.lblSbjct)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "mainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Study Planner"
        Me.subjectPanel.ResumeLayout(False)
        Me.timePanel.ResumeLayout(False)
        Me.statusPanel.ResumeLayout(False)
        Me.statusPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents subject1 As ComboBox
    Friend WithEvents subject2 As ComboBox
    Friend WithEvents subject3 As ComboBox
    Friend WithEvents subject4 As ComboBox
    Friend WithEvents subject5 As ComboBox
    Friend WithEvents subject6 As ComboBox
    Friend WithEvents time1 As ComboBox
    Friend WithEvents time2 As ComboBox
    Friend WithEvents time3 As ComboBox
    Friend WithEvents time4 As ComboBox
    Friend WithEvents time5 As ComboBox
    Friend WithEvents time6 As ComboBox
    Friend WithEvents lblSbjct As Label
    Friend WithEvents lblTme As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents loadFileDialog As OpenFileDialog
    Friend WithEvents StpWtchText As Label
    Friend WithEvents stopWatchTimer As Timer
    Friend WithEvents btnStrt As Button
    Friend WithEvents btnStp As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblStpWtch As Label
    Friend WithEvents toneSelect As ComboBox
    Friend WithEvents LoadMP3Dialog As OpenFileDialog
    Friend WithEvents btnAdd As Button
    Friend WithEvents subjectTimer As Timer
    Friend WithEvents ToneStop As Timer
    Friend WithEvents notification As NotifyIcon
    Friend WithEvents listTms As ListBox
    Friend WithEvents btnLap As Button
    Friend WithEvents settings As Label
    Friend WithEvents btnPlay As Button
    Friend WithEvents status1 As Label
    Friend WithEvents status2 As Label
    Friend WithEvents status3 As Label
    Friend WithEvents status4 As Label
    Friend WithEvents status5 As Label
    Friend WithEvents status6 As Label
    Friend WithEvents subjectPanel As Panel
    Friend WithEvents timePanel As Panel
    Friend WithEvents statusPanel As Panel
End Class
