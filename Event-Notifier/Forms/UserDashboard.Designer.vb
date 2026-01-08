<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        pnlSidebar = New Panel()
        btnevtregistration = New Button()
        btnlogin = New Button()
        Panel1 = New Panel()
        pnllogo = New Panel()
        pblogo = New PictureBox()
        btnEvents = New Button()
        pnlDisplay = New Panel()
        lblContent = New Label()
        btnacademics = New Button()
        btnConcerts = New Button()
        btnfestivals = New Button()
        pnlSidebar.SuspendLayout()
        pnllogo.SuspendLayout()
        CType(pblogo, ComponentModel.ISupportInitialize).BeginInit()
        pnlDisplay.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.DarkSlateGray
        pnlSidebar.BorderStyle = BorderStyle.Fixed3D
        pnlSidebar.Controls.Add(btnevtregistration)
        pnlSidebar.Controls.Add(btnlogin)
        pnlSidebar.Controls.Add(Panel1)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(200, 450)
        pnlSidebar.TabIndex = 0
        ' 
        ' btnevtregistration
        ' 
        btnevtregistration.BackgroundImageLayout = ImageLayout.None
        btnevtregistration.Cursor = Cursors.Hand
        btnevtregistration.FlatStyle = FlatStyle.Flat
        btnevtregistration.ForeColor = SystemColors.InactiveBorder
        btnevtregistration.Location = New Point(-2, 162)
        btnevtregistration.Name = "btnevtregistration"
        btnevtregistration.Size = New Size(200, 50)
        btnevtregistration.TabIndex = 2
        btnevtregistration.Text = "Register for an Event"
        btnevtregistration.TextAlign = ContentAlignment.MiddleLeft
        btnevtregistration.UseVisualStyleBackColor = True
        ' 
        ' btnlogin
        ' 
        btnlogin.BackgroundImageLayout = ImageLayout.None
        btnlogin.Cursor = Cursors.Hand
        btnlogin.FlatStyle = FlatStyle.Flat
        btnlogin.ForeColor = SystemColors.InactiveBorder
        btnlogin.Location = New Point(-2, 106)
        btnlogin.Name = "btnlogin"
        btnlogin.Size = New Size(200, 50)
        btnlogin.TabIndex = 1
        btnlogin.Text = "Login"
        btnlogin.TextAlign = ContentAlignment.MiddleLeft
        btnlogin.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.InactiveBorder
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(196, 100)
        Panel1.TabIndex = 0
        ' 
        ' pnllogo
        ' 
        pnllogo.BackColor = SystemColors.InactiveBorder
        pnllogo.Controls.Add(pblogo)
        pnllogo.Dock = DockStyle.Top
        pnllogo.Location = New Point(200, 0)
        pnllogo.Name = "pnllogo"
        pnllogo.Size = New Size(600, 100)
        pnllogo.TabIndex = 1
        ' 
        ' pblogo
        ' 
        pblogo.BackColor = SystemColors.InactiveBorder
        pblogo.BackgroundImage = My.Resources.Resources.Gemini_Generated_Image_a38oq9a38oq9a38o
        pblogo.BackgroundImageLayout = ImageLayout.Zoom
        pblogo.Dock = DockStyle.Top
        pblogo.Location = New Point(0, 0)
        pblogo.Name = "pblogo"
        pblogo.Size = New Size(600, 100)
        pblogo.TabIndex = 0
        pblogo.TabStop = False
        ' 
        ' btnEvents
        ' 
        btnEvents.BackColor = Color.DarkSlateGray
        btnEvents.FlatStyle = FlatStyle.Flat
        btnEvents.ForeColor = SystemColors.InactiveBorder
        btnEvents.Location = New Point(206, 108)
        btnEvents.Name = "btnEvents"
        btnEvents.Size = New Size(200, 50)
        btnEvents.TabIndex = 2
        btnEvents.Text = "Sporting Events"
        btnEvents.TextAlign = ContentAlignment.MiddleLeft
        btnEvents.UseVisualStyleBackColor = False
        ' 
        ' pnlDisplay
        ' 
        pnlDisplay.Controls.Add(lblContent)
        pnlDisplay.Location = New Point(487, 219)
        pnlDisplay.Name = "pnlDisplay"
        pnlDisplay.Size = New Size(300, 150)
        pnlDisplay.TabIndex = 3
        pnlDisplay.Visible = False
        ' 
        ' lblContent
        ' 
        lblContent.AutoSize = True
        lblContent.Location = New Point(76, 17)
        lblContent.Name = "lblContent"
        lblContent.Size = New Size(63, 25)
        lblContent.TabIndex = 0
        lblContent.Text = "Label1"
        ' 
        ' btnacademics
        ' 
        btnacademics.BackColor = Color.DarkSlateGray
        btnacademics.FlatStyle = FlatStyle.Flat
        btnacademics.ForeColor = SystemColors.InactiveBorder
        btnacademics.Location = New Point(206, 279)
        btnacademics.Name = "btnacademics"
        btnacademics.Size = New Size(200, 50)
        btnacademics.TabIndex = 4
        btnacademics.Text = "Academic Events"
        btnacademics.TextAlign = ContentAlignment.MiddleLeft
        btnacademics.UseVisualStyleBackColor = False
        ' 
        ' btnConcerts
        ' 
        btnConcerts.BackColor = Color.DarkSlateGray
        btnConcerts.FlatStyle = FlatStyle.Flat
        btnConcerts.ForeColor = SystemColors.InactiveBorder
        btnConcerts.Location = New Point(206, 223)
        btnConcerts.Name = "btnConcerts"
        btnConcerts.Size = New Size(200, 50)
        btnConcerts.TabIndex = 5
        btnConcerts.Text = "Upcoming Concerts"
        btnConcerts.TextAlign = ContentAlignment.MiddleLeft
        btnConcerts.UseVisualStyleBackColor = False
        ' 
        ' btnfestivals
        ' 
        btnfestivals.BackColor = Color.DarkSlateGray
        btnfestivals.FlatStyle = FlatStyle.Flat
        btnfestivals.ForeColor = SystemColors.InactiveBorder
        btnfestivals.Location = New Point(206, 164)
        btnfestivals.Name = "btnfestivals"
        btnfestivals.Size = New Size(200, 50)
        btnfestivals.TabIndex = 6
        btnfestivals.Text = "Upcoming Festivals"
        btnfestivals.TextAlign = ContentAlignment.MiddleLeft
        btnfestivals.UseVisualStyleBackColor = False
        ' 
        ' UserDashboard
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(800, 450)
        Controls.Add(btnfestivals)
        Controls.Add(btnConcerts)
        Controls.Add(btnacademics)
        Controls.Add(pnlDisplay)
        Controls.Add(btnEvents)
        Controls.Add(pnllogo)
        Controls.Add(pnlSidebar)
        Name = "UserDashboard"
        Text = "Form1"
        pnlSidebar.ResumeLayout(False)
        pnllogo.ResumeLayout(False)
        CType(pblogo, ComponentModel.ISupportInitialize).EndInit()
        pnlDisplay.ResumeLayout(False)
        pnlDisplay.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnllogo As Panel
    Friend WithEvents pblogo As PictureBox
    Friend WithEvents btnevtregistration As Button
    Friend WithEvents btnlogin As Button
    Friend WithEvents btnEvents As Button
    Friend WithEvents pnlDisplay As Panel
    Friend WithEvents lblContent As Label
    Friend WithEvents btnacademics As Button
    Friend WithEvents btnConcerts As Button
    Friend WithEvents btnfestivals As Button

End Class
