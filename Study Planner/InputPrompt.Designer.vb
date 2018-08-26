<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputPrompt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InputPrompt))
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCncl = New System.Windows.Forms.Button()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblMsg
        '
        resources.ApplyResources(Me.lblMsg, "lblMsg")
        Me.lblMsg.Name = "lblMsg"
        '
        'btnOK
        '
        resources.ApplyResources(Me.btnOK, "btnOK")
        Me.btnOK.Name = "btnOK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCncl
        '
        resources.ApplyResources(Me.btnCncl, "btnCncl")
        Me.btnCncl.Name = "btnCncl"
        Me.btnCncl.UseVisualStyleBackColor = True
        '
        'txtInput
        '
        resources.ApplyResources(Me.txtInput, "txtInput")
        Me.txtInput.Name = "txtInput"
        '
        'InputPrompt
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.btnCncl)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblMsg)
        Me.Name = "InputPrompt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMsg As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCncl As Button
    Friend WithEvents txtInput As TextBox
End Class
