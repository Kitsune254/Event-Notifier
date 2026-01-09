<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EventInputForm
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

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEventName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rtbDescription = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpEventDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpEventTime = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtVenue = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtOrganiserContact = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtOrganiserName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.nudMaxParticipants = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pbEventImage = New System.Windows.Forms.PictureBox()
        Me.btnUploadImage = New System.Windows.Forms.Button()
        Me.btnRemoveImage = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblImageInfo = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudMaxParticipants, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEventImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Event Name:"
        '
        'txtEventName
        '
        Me.txtEventName.Location = New System.Drawing.Point(26, 54)
        Me.txtEventName.Name = "txtEventName"
        Me.txtEventName.Size = New System.Drawing.Size(466, 26)
        Me.txtEventName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Description:"
        '
        'rtbDescription
        '
        Me.rtbDescription.Location = New System.Drawing.Point(26, 119)
        Me.rtbDescription.Name = "rtbDescription"
        Me.rtbDescription.Size = New System.Drawing.Size(466, 96)
        Me.rtbDescription.TabIndex = 2
        Me.rtbDescription.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Category:"
        '
        'cmbCategory
        '
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(26, 256)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(264, 28)
        Me.cmbCategory.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 303)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Date:"
        '
        'dtpEventDate
        '
        Me.dtpEventDate.Location = New System.Drawing.Point(26, 327)
        Me.dtpEventDate.Name = "dtpEventDate"
        Me.dtpEventDate.Size = New System.Drawing.Size(294, 26)
        Me.dtpEventDate.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(340, 303)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Time:"
        '
        'dtpEventTime
        '
        Me.dtpEventTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEventTime.Location = New System.Drawing.Point(344, 327)
        Me.dtpEventTime.Name = "dtpEventTime"
        Me.dtpEventTime.ShowUpDown = True
        Me.dtpEventTime.Size = New System.Drawing.Size(148, 26)
        Me.dtpEventTime.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 372)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Venue:"
        '
        'txtVenue
        '
        Me.txtVenue.Location = New System.Drawing.Point(26, 396)
        Me.txtVenue.Name = "txtVenue"
        Me.txtVenue.Size = New System.Drawing.Size(466, 26)
        Me.txtVenue.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtOrganiserContact)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtOrganiserName)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(544, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(370, 189)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Organiser Details"
        '
        'txtOrganiserContact
        '
        Me.txtOrganiserContact.Location = New System.Drawing.Point(19, 131)
        Me.txtOrganiserContact.Name = "txtOrganiserContact"
        Me.txtOrganiserContact.Size = New System.Drawing.Size(325, 26)
        Me.txtOrganiserContact.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 20)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Contact (Email/Tel):"
        '
        'txtOrganiserName
        '
        Me.txtOrganiserName.Location = New System.Drawing.Point(19, 61)
        Me.txtOrganiserName.Name = "txtOrganiserName"
        Me.txtOrganiserName.Size = New System.Drawing.Size(325, 26)
        Me.txtOrganiserName.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 25)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Name:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(544, 232)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 20)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Max Participants:"
        '
        'nudMaxParticipants
        '
        Me.nudMaxParticipants.Location = New System.Drawing.Point(544, 258)
        Me.nudMaxParticipants.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudMaxParticipants.Name = "nudMaxParticipants"
        Me.nudMaxParticipants.Size = New System.Drawing.Size(120, 26)
        Me.nudMaxParticipants.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(544, 303)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 20)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Event Poster:"
        '
        'pbEventImage
        '
        Me.pbEventImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbEventImage.Location = New System.Drawing.Point(544, 327)
        Me.pbEventImage.Name = "pbEventImage"
        Me.pbEventImage.Size = New System.Drawing.Size(370, 219)
        Me.pbEventImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbEventImage.TabIndex = 16
        Me.pbEventImage.TabStop = False
        '
        'btnUploadImage
        '
        Me.btnUploadImage.Location = New System.Drawing.Point(544, 552)
        Me.btnUploadImage.Name = "btnUploadImage"
        Me.btnUploadImage.Size = New System.Drawing.Size(127, 34)
        Me.btnUploadImage.TabIndex = 10
        Me.btnUploadImage.Text = "Upload..."
        Me.btnUploadImage.UseVisualStyleBackColor = True
        '
        'btnRemoveImage
        '
        Me.btnRemoveImage.Location = New System.Drawing.Point(677, 552)
        Me.btnRemoveImage.Name = "btnRemoveImage"
        Me.btnRemoveImage.Size = New System.Drawing.Size(127, 34)
        Me.btnRemoveImage.TabIndex = 11
        Me.btnRemoveImage.Text = "Remove"
        Me.btnRemoveImage.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.SeaGreen
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(26, 523)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(199, 53)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "SAVE EVENT"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(240, 523)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(155, 53)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblImageInfo
        '
        Me.lblImageInfo.AutoSize = True
        Me.lblImageInfo.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImageInfo.ForeColor = System.Drawing.Color.DimGray
        Me.lblImageInfo.Location = New System.Drawing.Point(811, 560)
        Me.lblImageInfo.Name = "lblImageInfo"
        Me.lblImageInfo.Size = New System.Drawing.Size(0, 21)
        Me.lblImageInfo.TabIndex = 21
        '
        'EventInputForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 620)
        Me.Controls.Add(Me.lblImageInfo)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnRemoveImage)
        Me.Controls.Add(Me.btnUploadImage)
        Me.Controls.Add(Me.pbEventImage)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.nudMaxParticipants)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtVenue)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpEventTime)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtpEventDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rtbDescription)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtEventName)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EventInputForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create / Edit Event"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nudMaxParticipants, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEventImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEventName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rtbDescription As System.Windows.Forms.RichTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpEventDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpEventTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtVenue As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtOrganiserContact As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtOrganiserName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents nudMaxParticipants As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents pbEventImage As System.Windows.Forms.PictureBox
    Friend WithEvents btnUploadImage As System.Windows.Forms.Button
    Friend WithEvents btnRemoveImage As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblImageInfo As System.Windows.Forms.Label
End Class
