<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Archive
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Archive))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtSearch = New DevExpress.XtraEditors.SearchControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.cbFilter = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.lblRec = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GridControl1.Size = New System.Drawing.Size(696, 393)
        Me.GridControl1.TabIndex = 26
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
        Me.GridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full
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
        Me.GroupControl1.Controls.Add(Me.txtSearch)
        Me.GroupControl1.Controls.Add(Me.SimpleButton2)
        Me.GroupControl1.Controls.Add(Me.cbFilter)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Title
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(696, 62)
        Me.GroupControl1.TabIndex = 27
        '
        'txtSearch
        '
        Me.txtSearch.Client = Me.GridControl1
        Me.txtSearch.Location = New System.Drawing.Point(281, 29)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Properties.Appearance.Options.UseFont = True
        Me.txtSearch.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.txtSearch.Properties.Client = Me.GridControl1
        Me.txtSearch.Properties.ImmediatePopup = False
        Me.txtSearch.Properties.ValidateOnEnterKey = False
        Me.txtSearch.Size = New System.Drawing.Size(322, 30)
        Me.txtSearch.TabIndex = 116
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton2.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton2.Location = New System.Drawing.Point(609, 28)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(83, 31)
        Me.SimpleButton2.TabIndex = 117
        Me.SimpleButton2.Text = "Search"
        '
        'cbFilter
        '
        Me.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFilter.FormattingEnabled = True
        Me.cbFilter.Items.AddRange(New Object() {"RESIDENT", "BLOTTER"})
        Me.cbFilter.Location = New System.Drawing.Point(47, 29)
        Me.cbFilter.Name = "cbFilter"
        Me.cbFilter.Size = New System.Drawing.Size(198, 28)
        Me.cbFilter.TabIndex = 115
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "FILTER"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.lblRec)
        Me.PanelControl1.Controls.Add(Me.SimpleButton1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 455)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(696, 37)
        Me.PanelControl1.TabIndex = 28
        '
        'lblRec
        '
        Me.lblRec.Location = New System.Drawing.Point(5, 12)
        Me.lblRec.Name = "lblRec"
        Me.lblRec.Size = New System.Drawing.Size(0, 13)
        Me.lblRec.TabIndex = 1
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton1.Location = New System.Drawing.Point(598, 5)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(93, 26)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "Restore"
        '
        'Archive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 492)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "Archive"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Archive"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Public WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutView1 As DevExpress.XtraGrid.Views.Layout.LayoutView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblRec As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbFilter As ComboBox
    Friend WithEvents txtSearch As DevExpress.XtraEditors.SearchControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
End Class
