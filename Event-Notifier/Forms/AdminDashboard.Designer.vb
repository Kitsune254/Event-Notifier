<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
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
        Me.menuMain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EventsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateNewEventToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAllEventsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewRegistrationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.statusMain = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pnlStats = New System.Windows.Forms.Panel()
        Me.lblTotalRegistrations = New System.Windows.Forms.Label()
        Me.lblTotalEvents = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvRecentEvents = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCreateEvent = New System.Windows.Forms.Button()
        Me.menuMain.SuspendLayout()
        Me.statusMain.SuspendLayout()
        Me.pnlStats.SuspendLayout()
        CType(Me.dgvRecentEvents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menuMain
        '
        Me.menuMain.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.menuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EventsToolStripMenuItem, Me.RegistrationsToolStripMenuItem, Me.AccountToolStripMenuItem})
        Me.menuMain.Location = New System.Drawing.Point(0, 0)
        Me.menuMain.Name = "menuMain"
        Me.menuMain.Size = New System.Drawing.Size(1100, 33)
        Me.menuMain.TabIndex = 0
        Me.menuMain.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(141, 34)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EventsToolStripMenuItem
        '
        Me.EventsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateNewEventToolStripMenuItem, Me.ViewAllEventsToolStripMenuItem})
        Me.EventsToolStripMenuItem.Name = "EventsToolStripMenuItem"
        Me.EventsToolStripMenuItem.Size = New System.Drawing.Size(79, 29)
        Me.EventsToolStripMenuItem.Text = "Events"
        '
        'CreateNewEventToolStripMenuItem
        '
        Me.CreateNewEventToolStripMenuItem.Name = "CreateNewEventToolStripMenuItem"
        Me.CreateNewEventToolStripMenuItem.Size = New System.Drawing.Size(250, 34)
        Me.CreateNewEventToolStripMenuItem.Text = "Create New Event"
        '
        'ViewAllEventsToolStripMenuItem
        '
        Me.ViewAllEventsToolStripMenuItem.Name = "ViewAllEventsToolStripMenuItem"
        Me.ViewAllEventsToolStripMenuItem.Size = New System.Drawing.Size(250, 34)
        Me.ViewAllEventsToolStripMenuItem.Text = "View All Events"
        '
        'RegistrationsToolStripMenuItem
        '
        Me.RegistrationsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewRegistrationsToolStripMenuItem})
        Me.RegistrationsToolStripMenuItem.Name = "RegistrationsToolStripMenuItem"
        Me.RegistrationsToolStripMenuItem.Size = New System.Drawing.Size(130, 29)
        Me.RegistrationsToolStripMenuItem.Text = "Registrations"
        '
        'ViewRegistrationsToolStripMenuItem
        '
        Me.ViewRegistrationsToolStripMenuItem.Name = "ViewRegistrationsToolStripMenuItem"
        Me.ViewRegistrationsToolStripMenuItem.Size = New System.Drawing.Size(257, 34)
        Me.ViewRegistrationsToolStripMenuItem.Text = "View Registrations"
        '
        'AccountToolStripMenuItem
        '
        Me.AccountToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem"
        Me.AccountToolStripMenuItem.Size = New System.Drawing.Size(93, 29)
        Me.AccountToolStripMenuItem.Text = "Account"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(171, 34)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'statusMain
        '
        Me.statusMain.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.statusMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.statusMain.Location = New System.Drawing.Point(0, 618)
        Me.statusMain.Name = "statusMain"
        Me.statusMain.Size = New System.Drawing.Size(1100, 32)
        Me.statusMain.TabIndex = 1
        Me.statusMain.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(60, 25)
        Me.lblStatus.Text = "Ready"
        '
        'pnlStats
        '
        Me.pnlStats.BackColor = System.Drawing.Color.White
        Me.pnlStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlStats.Controls.Add(Me.lblTotalRegistrations)
        Me.pnlStats.Controls.Add(Me.lblTotalEvents)
        Me.pnlStats.Controls.Add(Me.Label2)
        Me.pnlStats.Controls.Add(Me.Label1)
        Me.pnlStats.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlStats.Location = New System.Drawing.Point(0, 33)
        Me.pnlStats.Name = "pnlStats"
        Me.pnlStats.Size = New System.Drawing.Size(1100, 126)
        Me.pnlStats.TabIndex = 2
        '
        'lblTotalRegistrations
        '
        Me.lblTotalRegistrations.AutoSize = True
        Me.lblTotalRegistrations.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRegistrations.ForeColor = System.Drawing.Color.SeaGreen
        Me.lblTotalRegistrations.Location = New System.Drawing.Point(344, 52)
        Me.lblTotalRegistrations.Name = "lblTotalRegistrations"
        Me.lblTotalRegistrations.Size = New System.Drawing.Size(42, 48)
        Me.lblTotalRegistrations.TabIndex = 3
        Me.lblTotalRegistrations.Text = "0"
        '
        'lblTotalEvents
        '
        Me.lblTotalEvents.AutoSize = True
        Me.lblTotalEvents.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalEvents.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblTotalEvents.Location = New System.Drawing.Point(39, 52)
        Me.lblTotalEvents.Name = "lblTotalEvents"
        Me.lblTotalEvents.Size = New System.Drawing.Size(42, 48)
        Me.lblTotalEvents.TabIndex = 2
        Me.lblTotalEvents.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(347, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total Registrations"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(42, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total Events"
        '
        'dgvRecentEvents
        '
        Me.dgvRecentEvents.AllowUserToAddRows = False
        Me.dgvRecentEvents.AllowUserToDeleteRows = False
        Me.dgvRecentEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRecentEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecentEvents.Location = New System.Drawing.Point(26, 203)
        Me.dgvRecentEvents.Name = "dgvRecentEvents"
        Me.dgvRecentEvents.ReadOnly = True
        Me.dgvRecentEvents.RowHeadersWidth = 62
        Me.dgvRecentEvents.RowTemplate.Height = 28
        Me.dgvRecentEvents.Size = New System.Drawing.Size(1046, 396)
        Me.dgvRecentEvents.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 32)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Recent Events"
        '
        'btnCreateEvent
        '
        Me.btnCreateEvent.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCreateEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateEvent.ForeColor = System.Drawing.Color.White
        Me.btnCreateEvent.Location = New System.Drawing.Point(884, 162)
        Me.btnCreateEvent.Name = "btnCreateEvent"
        Me.btnCreateEvent.Size = New System.Drawing.Size(188, 48)
        Me.btnCreateEvent.TabIndex = 5
        Me.btnCreateEvent.Text = "+ Create Event"
        Me.btnCreateEvent.UseVisualStyleBackColor = False
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 650)
        Me.Controls.Add(Me.btnCreateEvent)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvRecentEvents)
        Me.Controls.Add(Me.pnlStats)
        Me.Controls.Add(Me.statusMain)
        Me.Controls.Add(Me.menuMain)
        Me.MainMenuStrip = Me.menuMain
        Me.Name = "AdminDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Dashboard - University Event Platform"
        Me.menuMain.ResumeLayout(False)
        Me.menuMain.PerformLayout()
        Me.statusMain.ResumeLayout(False)
        Me.statusMain.PerformLayout()
        Me.pnlStats.ResumeLayout(False)
        Me.pnlStats.PerformLayout()
        CType(Me.dgvRecentEvents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
    
    Friend WithEvents menuMain As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EventsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateNewEventToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewAllEventsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewRegistrationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents statusMain As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents pnlStats As Panel
    Friend WithEvents lblTotalRegistrations As Label
    Friend WithEvents lblTotalEvents As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvRecentEvents As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCreateEvent As Button
    
End Class
