<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSettings))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.radioDefault = New System.Windows.Forms.RadioButton()
        Me.radioCustom = New System.Windows.Forms.RadioButton()
        Me.Docs = New System.Windows.Forms.PictureBox()
        Me.imgBrwse = New System.Windows.Forms.PictureBox()
        Me.brwse = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.toneInterval = New System.Windows.Forms.NumericUpDown()
        Me.lblSbjEdit = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRmv = New System.Windows.Forms.Button()
        Me.lstSbj = New System.Windows.Forms.CheckedListBox()
        Me.lblPath = New System.Windows.Forms.Label()
        Me.subjInput = New Study_Planner.InputPrompt()
        CType(Me.Docs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgBrwse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.toneInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(44, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Write Timetables in:"
        '
        'radioDefault
        '
        Me.radioDefault.AutoSize = True
        Me.radioDefault.Location = New System.Drawing.Point(59, 74)
        Me.radioDefault.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radioDefault.Name = "radioDefault"
        Me.radioDefault.Size = New System.Drawing.Size(122, 21)
        Me.radioDefault.TabIndex = 1
        Me.radioDefault.TabStop = True
        Me.radioDefault.Text = "My Documents"
        Me.radioDefault.UseVisualStyleBackColor = True
        '
        'radioCustom
        '
        Me.radioCustom.AutoSize = True
        Me.radioCustom.Location = New System.Drawing.Point(59, 133)
        Me.radioCustom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radioCustom.Name = "radioCustom"
        Me.radioCustom.Size = New System.Drawing.Size(121, 21)
        Me.radioCustom.TabIndex = 2
        Me.radioCustom.TabStop = True
        Me.radioCustom.Text = "Choose Folder"
        Me.radioCustom.UseVisualStyleBackColor = True
        '
        'Docs
        '
        Me.Docs.Image = Global.Study_Planner.My.Resources.Resources.Docs
        Me.Docs.Location = New System.Drawing.Point(217, 68)
        Me.Docs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Docs.Name = "Docs"
        Me.Docs.Size = New System.Drawing.Size(55, 39)
        Me.Docs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Docs.TabIndex = 3
        Me.Docs.TabStop = False
        '
        'imgBrwse
        '
        Me.imgBrwse.Image = Global.Study_Planner.My.Resources.Resources.Browse
        Me.imgBrwse.Location = New System.Drawing.Point(220, 121)
        Me.imgBrwse.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.imgBrwse.Name = "imgBrwse"
        Me.imgBrwse.Size = New System.Drawing.Size(49, 41)
        Me.imgBrwse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgBrwse.TabIndex = 4
        Me.imgBrwse.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(321, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Tone Duration (seconds):"
        '
        'toneInterval
        '
        Me.toneInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.toneInterval.Location = New System.Drawing.Point(405, 96)
        Me.toneInterval.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.toneInterval.Name = "toneInterval"
        Me.toneInterval.Size = New System.Drawing.Size(72, 22)
        Me.toneInterval.TabIndex = 8
        Me.toneInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSbjEdit
        '
        Me.lblSbjEdit.AutoSize = True
        Me.lblSbjEdit.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSbjEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSbjEdit.Location = New System.Drawing.Point(615, 26)
        Me.lblSbjEdit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSbjEdit.Name = "lblSbjEdit"
        Me.lblSbjEdit.Size = New System.Drawing.Size(142, 24)
        Me.lblSbjEdit.TabIndex = 9
        Me.lblSbjEdit.Text = "Edit Subject List"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(600, 215)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(92, 25)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRmv
        '
        Me.btnRmv.Location = New System.Drawing.Point(713, 215)
        Me.btnRmv.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRmv.Name = "btnRmv"
        Me.btnRmv.Size = New System.Drawing.Size(92, 25)
        Me.btnRmv.TabIndex = 12
        Me.btnRmv.Text = "Remove"
        Me.btnRmv.UseVisualStyleBackColor = True
        '
        'lstSbj
        '
        Me.lstSbj.CheckOnClick = True
        Me.lstSbj.FormattingEnabled = True
        Me.lstSbj.Location = New System.Drawing.Point(600, 63)
        Me.lstSbj.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstSbj.Name = "lstSbj"
        Me.lstSbj.Size = New System.Drawing.Size(204, 123)
        Me.lstSbj.TabIndex = 13
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPath.Location = New System.Drawing.Point(40, 182)
        Me.lblPath.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(184, 24)
        Me.lblPath.TabIndex = 14
        Me.lblPath.Text = "Currently writing in: "
        '
        'subjInput
        '
        Me.subjInput.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.subjInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.subjInput.Location = New System.Drawing.Point(213, 53)
        Me.subjInput.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.subjInput.Name = "subjInput"
        Me.subjInput.Size = New System.Drawing.Size(378, 160)
        Me.subjInput.TabIndex = 15
        '
        'FrmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(848, 255)
        Me.Controls.Add(Me.subjInput)
        Me.Controls.Add(Me.lblPath)
        Me.Controls.Add(Me.lstSbj)
        Me.Controls.Add(Me.btnRmv)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblSbjEdit)
        Me.Controls.Add(Me.toneInterval)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.imgBrwse)
        Me.Controls.Add(Me.Docs)
        Me.Controls.Add(Me.radioCustom)
        Me.Controls.Add(Me.radioDefault)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        CType(Me.Docs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgBrwse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.toneInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents radioDefault As RadioButton
    Friend WithEvents radioCustom As RadioButton
    Friend WithEvents Docs As PictureBox
    Friend WithEvents imgBrwse As PictureBox
    Friend WithEvents brwse As FolderBrowserDialog
    Friend WithEvents Label2 As Label
    Friend WithEvents toneInterval As NumericUpDown
    Friend WithEvents lblSbjEdit As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRmv As Button
    Friend WithEvents lstSbj As CheckedListBox
    Friend WithEvents lblPath As Label
    Friend WithEvents subjInput As InputPrompt
End Class
