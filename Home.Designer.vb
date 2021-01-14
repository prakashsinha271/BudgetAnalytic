<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewTransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewTransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotepadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StickyNotesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebBrowserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneralHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeedbackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComplainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1360, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewTransactionToolStripMenuItem, Me.ViewTransactionToolStripMenuItem, Me.GenerateReportToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewTransactionToolStripMenuItem
        '
        Me.NewTransactionToolStripMenuItem.Name = "NewTransactionToolStripMenuItem"
        Me.NewTransactionToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.NewTransactionToolStripMenuItem.Text = "New Transaction"
        '
        'ViewTransactionToolStripMenuItem
        '
        Me.ViewTransactionToolStripMenuItem.Name = "ViewTransactionToolStripMenuItem"
        Me.ViewTransactionToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ViewTransactionToolStripMenuItem.Text = "View Transaction"
        '
        'GenerateReportToolStripMenuItem
        '
        Me.GenerateReportToolStripMenuItem.Name = "GenerateReportToolStripMenuItem"
        Me.GenerateReportToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.GenerateReportToolStripMenuItem.Text = "Generate Report"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NotepadToolStripMenuItem, Me.StickyNotesToolStripMenuItem, Me.CalculatorToolStripMenuItem, Me.WebBrowserToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'NotepadToolStripMenuItem
        '
        Me.NotepadToolStripMenuItem.Name = "NotepadToolStripMenuItem"
        Me.NotepadToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.NotepadToolStripMenuItem.Text = "Notepad"
        '
        'StickyNotesToolStripMenuItem
        '
        Me.StickyNotesToolStripMenuItem.Name = "StickyNotesToolStripMenuItem"
        Me.StickyNotesToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.StickyNotesToolStripMenuItem.Text = "Sticky Notes"
        '
        'CalculatorToolStripMenuItem
        '
        Me.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        Me.CalculatorToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.CalculatorToolStripMenuItem.Text = "Calculator"
        '
        'WebBrowserToolStripMenuItem
        '
        Me.WebBrowserToolStripMenuItem.Name = "WebBrowserToolStripMenuItem"
        Me.WebBrowserToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.WebBrowserToolStripMenuItem.Text = "Web Browser"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeneralHelpToolStripMenuItem, Me.FeedbackToolStripMenuItem, Me.ComplainToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'GeneralHelpToolStripMenuItem
        '
        Me.GeneralHelpToolStripMenuItem.Name = "GeneralHelpToolStripMenuItem"
        Me.GeneralHelpToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.GeneralHelpToolStripMenuItem.Text = "General Help"
        '
        'FeedbackToolStripMenuItem
        '
        Me.FeedbackToolStripMenuItem.Name = "FeedbackToolStripMenuItem"
        Me.FeedbackToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.FeedbackToolStripMenuItem.Text = "Feedback"
        '
        'ComplainToolStripMenuItem
        '
        Me.ComplainToolStripMenuItem.Name = "ComplainToolStripMenuItem"
        Me.ComplainToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ComplainToolStripMenuItem.Text = "Complain"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 716)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Budget Analytic"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewTransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewTransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerateReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotepadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StickyNotesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WebBrowserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GeneralHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeedbackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComplainToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
