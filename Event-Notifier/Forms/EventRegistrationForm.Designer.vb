<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EventRegistrationForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 300)
        Me.Text = "Event Registration"

        ' Event ID
        Me.lblEventIDInfo = New System.Windows.Forms.Label()
        Me.lblEventID = New System.Windows.Forms.Label()
        Me.lblEventIDInfo.AutoSize = True
        Me.lblEventIDInfo.Location = New System.Drawing.Point(30, 30)
        Me.lblEventIDInfo.Name = "lblEventIDInfo"
        Me.lblEventIDInfo.Text = "Event ID:"
        Me.lblEventID.Location = New System.Drawing.Point(150, 30)
        Me.lblEventID.Name = "lblEventID"
        Me.lblEventID.Text = "[EventID]"

        ' User ID
        Me.lblUserIDInfo = New System.Windows.Forms.Label()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.lblUserIDInfo.AutoSize = True
        Me.lblUserIDInfo.Location = New System.Drawing.Point(30, 70)
        Me.lblUserIDInfo.Name = "lblUserIDInfo"
        Me.lblUserIDInfo.Text = "User ID:"
        Me.lblUserID.Location = New System.Drawing.Point(150, 70)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Text = "[UserID]"
        
        ' Notes
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Location = New System.Drawing.Point(30, 110)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Text = "Notes:"
        Me.txtNotes.Location = New System.Drawing.Point(150, 110)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(200, 100)

        ' Register Button
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnRegister.Location = New System.Drawing.Point(150, 230)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(90, 30)
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True

        ' Cancel Button
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnCancel.Location = New System.Drawing.Point(260, 230)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 30)
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True

        Me.Controls.Add(Me.lblEventIDInfo)
        Me.Controls.Add(Me.lblEventID)
        Me.Controls.Add(Me.lblUserIDInfo)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnCancel)
    End Sub

    Friend WithEvents lblEventIDInfo As System.Windows.Forms.Label
    Friend WithEvents lblEventID As System.Windows.Forms.Label
    Friend WithEvents lblUserIDInfo As System.Windows.Forms.Label
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
