<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EventsDetailsView
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
        lbldata = New Label()
        btnClose = New Button()
        SuspendLayout()
        ' 
        ' lbldata
        ' 
        lbldata.AutoSize = True
        lbldata.BackColor = SystemColors.ControlText
        lbldata.ForeColor = SystemColors.InactiveBorder
        lbldata.Location = New Point(342, 9)
        lbldata.Name = "lbldata"
        lbldata.Size = New Size(63, 25)
        lbldata.TabIndex = 0
        lbldata.Text = "Label1"
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.Red
        btnClose.FlatStyle = FlatStyle.Popup
        btnClose.ForeColor = SystemColors.Control
        btnClose.Location = New Point(755, 4)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(33, 34)
        btnClose.TabIndex = 1
        btnClose.Text = "X"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' EventsDetailsView
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlText
        ClientSize = New Size(800, 450)
        Controls.Add(btnClose)
        Controls.Add(lbldata)
        ForeColor = SystemColors.InactiveBorder
        Name = "EventsDetailsView"
        Text = "EventsDetailsView"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbldata As Label
    Friend WithEvents btnClose As Button
End Class
