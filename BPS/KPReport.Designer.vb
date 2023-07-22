<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KPReport
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
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KPReport))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.cbOption = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.cbAll = New System.Windows.Forms.CheckBox()
        Me.txtDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtopt = New System.Windows.Forms.TextBox()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.lblRec = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cbOption.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 62)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1050, 338)
        Me.GridControl1.TabIndex = 116
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.LayoutView1})
        '
        'GridView1
        '
        GridFormatRule1.Name = "Format0"
        GridFormatRule1.Rule = Nothing
        Me.GridView1.FormatRules.Add(GridFormatRule1)
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace
        Me.GridView1.OptionsCustomization.AllowMergedGrouping = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsDetail.AllowExpandEmptyDetails = True
        Me.GridView1.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GridView1.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsView.RowAutoHeight = True
        '
        'LayoutView1
        '
        Me.LayoutView1.GridControl = Me.GridControl1
        Me.LayoutView1.Name = "LayoutView1"
        Me.LayoutView1.TemplateCard = Nothing
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.cbOption)
        Me.GroupControl1.Controls.Add(Me.SimpleButton1)
        Me.GroupControl1.Controls.Add(Me.cbAll)
        Me.GroupControl1.Controls.Add(Me.txtDate)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Title
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1050, 62)
        Me.GroupControl1.TabIndex = 117
        '
        'cbOption
        '
        Me.cbOption.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbOption.Location = New System.Drawing.Point(298, 31)
        Me.cbOption.Name = "cbOption"
        Me.cbOption.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.cbOption.Properties.Appearance.Options.UseFont = True
        Me.cbOption.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbOption.Properties.Items.AddRange(New Object() {"Complaint Form", "Notice of Hearing", "Summon", "Officers Return", "Notice to Chosen Pangkat", "Certificate to File Action"})
        Me.cbOption.Size = New System.Drawing.Size(400, 26)
        Me.cbOption.TabIndex = 116
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton1.Location = New System.Drawing.Point(952, 32)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(93, 26)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "Print"
        '
        'cbAll
        '
        Me.cbAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbAll.AutoSize = True
        Me.cbAll.Location = New System.Drawing.Point(884, 36)
        Me.cbAll.Name = "cbAll"
        Me.cbAll.Size = New System.Drawing.Size(66, 17)
        Me.cbAll.TabIndex = 114
        Me.cbAll.Text = "Show All"
        Me.cbAll.UseVisualStyleBackColor = True
        '
        'txtDate
        '
        Me.txtDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDate.CustomFormat = "yyyy-MM-dd"
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDate.Location = New System.Drawing.Point(765, 30)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(114, 26)
        Me.txtDate.TabIndex = 112
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.Label1.Location = New System.Drawing.Point(714, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 22)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "DATE"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.Label2.Location = New System.Drawing.Point(36, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 22)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "Katarungang PamBarangay List"
        '
        'txtopt
        '
        Me.txtopt.Location = New System.Drawing.Point(835, 68)
        Me.txtopt.Name = "txtopt"
        Me.txtopt.Size = New System.Drawing.Size(29, 21)
        Me.txtopt.TabIndex = 119
        Me.txtopt.Visible = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.lblRec)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 400)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1050, 33)
        Me.PanelControl1.TabIndex = 118
        '
        'lblRec
        '
        Me.lblRec.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.lblRec.Appearance.Options.UseFont = True
        Me.lblRec.Location = New System.Drawing.Point(6, 11)
        Me.lblRec.Name = "lblRec"
        Me.lblRec.Size = New System.Drawing.Size(0, 18)
        Me.lblRec.TabIndex = 1
        '
        'KPReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 433)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.txtopt)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "KPReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Katarungang PamBarangay Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cbOption.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Public WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutView1 As DevExpress.XtraGrid.Views.Layout.LayoutView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cbOption As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbAll As CheckBox
    Friend WithEvents txtDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtopt As TextBox
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblRec As DevExpress.XtraEditors.LabelControl
End Class
