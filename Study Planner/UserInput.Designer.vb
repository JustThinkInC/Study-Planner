<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserInput
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCncl = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.Location = New System.Drawing.Point(103, 19)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(50, 13)
        Me.lblMsg.TabIndex = 0
        Me.lblMsg.Text = "Message"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(56, 48)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(157, 20)
        Me.txtInput.TabIndex = 1
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(36, 89)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCncl
        '
        Me.btnCncl.Location = New System.Drawing.Point(157, 89)
        Me.btnCncl.Name = "btnCncl"
        Me.btnCncl.Size = New System.Drawing.Size(75, 23)
        Me.btnCncl.TabIndex = 3
        Me.btnCncl.Text = "Cancel"
        Me.btnCncl.UseVisualStyleBackColor = True
        '
        'UserInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Controls.Add(Me.btnCncl)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblMsg)
        Me.Name = "UserInput"
        Me.Size = New System.Drawing.Size(272, 124)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMsg As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCncl As Button
End Class
