<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reports
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.cbYear = New System.Windows.Forms.TextBox()
        Me.cbMonth = New System.Windows.Forms.TextBox()
        Me.txt = New System.Windows.Forms.TextBox()
        Me.txtService = New System.Windows.Forms.TextBox()
        Me.cbPurok = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(710, 403)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'txtNo
        '
        Me.txtNo.Location = New System.Drawing.Point(657, 80)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(219, 21)
        Me.txtNo.TabIndex = 9
        Me.txtNo.Visible = False
        '
        'cbYear
        '
        Me.cbYear.Location = New System.Drawing.Point(657, 168)
        Me.cbYear.Name = "cbYear"
        Me.cbYear.Size = New System.Drawing.Size(219, 21)
        Me.cbYear.TabIndex = 120
        Me.cbYear.Visible = False
        '
        'cbMonth
        '
        Me.cbMonth.Location = New System.Drawing.Point(657, 141)
        Me.cbMonth.Name = "cbMonth"
        Me.cbMonth.Size = New System.Drawing.Size(219, 21)
        Me.cbMonth.TabIndex = 119
        Me.cbMonth.Visible = False
        '
        'txt
        '
        Me.txt.Location = New System.Drawing.Point(657, 224)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(73, 21)
        Me.txt.TabIndex = 118
        Me.txt.Visible = False
        '
        'txtService
        '
        Me.txtService.Location = New System.Drawing.Point(657, 197)
        Me.txtService.Name = "txtService"
        Me.txtService.Size = New System.Drawing.Size(73, 21)
        Me.txtService.TabIndex = 117
        Me.txtService.Visible = False
        '
        'cbPurok
        '
        Me.cbPurok.Location = New System.Drawing.Point(657, 112)
        Me.cbPurok.Name = "cbPurok"
        Me.cbPurok.Size = New System.Drawing.Size(73, 21)
        Me.cbPurok.TabIndex = 116
        Me.cbPurok.Visible = False
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 403)
        Me.Controls.Add(Me.cbYear)
        Me.Controls.Add(Me.cbMonth)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.txtService)
        Me.Controls.Add(Me.cbPurok)
        Me.Controls.Add(Me.txtNo)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "Reports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "u  "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents txtNo As TextBox
    Friend WithEvents cbYear As TextBox
    Friend WithEvents cbMonth As TextBox
    Friend WithEvents txt As TextBox
    Friend WithEvents txtService As TextBox
    Friend WithEvents cbPurok As TextBox
End Class
