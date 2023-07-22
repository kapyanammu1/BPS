<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class List
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
        Me.components = New System.ComponentModel.Container()
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(List))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BarLargeButtonItem1 = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.BarLargeButtonItem3 = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.BarLargeButtonItem4 = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSearch = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.lblRec = New DevExpress.XtraBars.BarStaticItem()
        Me.RepositoryItemSearchControl1 = New DevExpress.XtraEditors.Repository.RepositoryItemSearchControl()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarLargeButtonItem2 = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtSearch1 = New DevExpress.XtraEditors.SearchControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.lblRec1 = New System.Windows.Forms.Label()
        Me.txtHouseNo = New System.Windows.Forms.TextBox()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtSearch1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 112)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1037, 270)
        Me.GridControl1.TabIndex = 3
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
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarLargeButtonItem1, Me.BarLargeButtonItem3, Me.BarLargeButtonItem4, Me.btnSearch, Me.lblRec})
        Me.BarManager1.MaxItemId = 9
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSearchControl1})
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarLargeButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarLargeButtonItem3, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.BarLargeButtonItem4)})
        Me.Bar1.Text = "Tools"
        '
        'BarLargeButtonItem1
        '
        Me.BarLargeButtonItem1.Caption = "ADD"
        Me.BarLargeButtonItem1.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right
        Me.BarLargeButtonItem1.Id = 4
        Me.BarLargeButtonItem1.ImageOptions.SvgImage = CType(resources.GetObject("BarLargeButtonItem1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarLargeButtonItem1.Name = "BarLargeButtonItem1"
        '
        'BarLargeButtonItem3
        '
        Me.BarLargeButtonItem3.Caption = "EDIT/UPDATE"
        Me.BarLargeButtonItem3.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right
        Me.BarLargeButtonItem3.Id = 5
        Me.BarLargeButtonItem3.ImageOptions.SvgImage = CType(resources.GetObject("BarLargeButtonItem3.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarLargeButtonItem3.Name = "BarLargeButtonItem3"
        '
        'BarLargeButtonItem4
        '
        Me.BarLargeButtonItem4.Caption = "DELETE"
        Me.BarLargeButtonItem4.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right
        Me.BarLargeButtonItem4.Id = 6
        Me.BarLargeButtonItem4.ImageOptions.SvgImage = CType(resources.GetObject("BarLargeButtonItem4.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarLargeButtonItem4.Name = "BarLargeButtonItem4"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1037, 44)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 382)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1037, 18)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 44)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 338)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1037, 44)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 338)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Save"
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "BarButtonItem2"
        Me.BarButtonItem2.Id = 2
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "BarButtonItem3"
        Me.BarButtonItem3.Id = 3
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'btnSearch
        '
        Me.btnSearch.Caption = "Search"
        Me.btnSearch.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right
        Me.btnSearch.Id = 7
        Me.btnSearch.ImageOptions.SvgImage = CType(resources.GetObject("btnSearch.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnSearch.Name = "btnSearch"
        '
        'lblRec
        '
        Me.lblRec.Caption = "Record(s) found."
        Me.lblRec.Id = 8
        Me.lblRec.Name = "lblRec"
        '
        'RepositoryItemSearchControl1
        '
        Me.RepositoryItemSearchControl1.AllowAutoApply = False
        Me.RepositoryItemSearchControl1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.RepositoryItemSearchControl1.Client = Me.GridControl1
        Me.RepositoryItemSearchControl1.FindDelay = 100
        Me.RepositoryItemSearchControl1.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.RepositoryItemSearchControl1.ItemAutoHeight = True
        Me.RepositoryItemSearchControl1.Name = "RepositoryItemSearchControl1"
        Me.RepositoryItemSearchControl1.NullValuePromptShowForEmptyValue = False
        Me.RepositoryItemSearchControl1.ShowClearButton = False
        Me.RepositoryItemSearchControl1.Sorted = True
        Me.RepositoryItemSearchControl1.Tag = ""
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        Me.Bar2.Visible = False
        '
        'BarLargeButtonItem2
        '
        Me.BarLargeButtonItem2.Caption = "ADD"
        Me.BarLargeButtonItem2.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right
        Me.BarLargeButtonItem2.Id = 4
        Me.BarLargeButtonItem2.ImageOptions.SvgImage = CType(resources.GetObject("BarLargeButtonItem2.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarLargeButtonItem2.Name = "BarLargeButtonItem2"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(1018, 40)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(100, 21)
        Me.txtID.TabIndex = 14
        Me.txtID.Visible = False
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtSearch1)
        Me.GroupControl1.Controls.Add(Me.SimpleButton1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Title
        Me.GroupControl1.Location = New System.Drawing.Point(0, 44)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1037, 68)
        Me.GroupControl1.TabIndex = 19
        '
        'txtSearch1
        '
        Me.txtSearch1.Client = Me.GridControl1
        Me.txtSearch1.Location = New System.Drawing.Point(3, 32)
        Me.txtSearch1.MenuManager = Me.BarManager1
        Me.txtSearch1.Name = "txtSearch1"
        Me.txtSearch1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch1.Properties.Appearance.Options.UseFont = True
        Me.txtSearch1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.txtSearch1.Properties.Client = Me.GridControl1
        Me.txtSearch1.Properties.ImmediatePopup = False
        Me.txtSearch1.Properties.ValidateOnEnterKey = False
        Me.txtSearch1.Size = New System.Drawing.Size(322, 30)
        Me.txtSearch1.TabIndex = 1
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton1.Location = New System.Drawing.Point(331, 31)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(76, 31)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "Search"
        '
        'lblRec1
        '
        Me.lblRec1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblRec1.AutoSize = True
        Me.lblRec1.BackColor = System.Drawing.Color.Transparent
        Me.lblRec1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRec1.Location = New System.Drawing.Point(2, 383)
        Me.lblRec1.Name = "lblRec1"
        Me.lblRec1.Size = New System.Drawing.Size(0, 18)
        Me.lblRec1.TabIndex = 20
        '
        'txtHouseNo
        '
        Me.txtHouseNo.Location = New System.Drawing.Point(994, 25)
        Me.txtHouseNo.Name = "txtHouseNo"
        Me.txtHouseNo.ReadOnly = True
        Me.txtHouseNo.Size = New System.Drawing.Size(100, 21)
        Me.txtHouseNo.TabIndex = 25
        Me.txtHouseNo.Visible = False
        '
        'List
        '
        Me.AcceptButton = Me.SimpleButton1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1037, 400)
        Me.Controls.Add(Me.txtHouseNo)
        Me.Controls.Add(Me.lblRec1)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.DoubleBuffered = True
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow
        Me.Name = "List"
        Me.ShowMdiChildCaptionInParentTitle = True
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.txtSearch1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    'Friend WithEvents txtSearch As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemSearchControl1 As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
    Friend WithEvents btnSearch As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents BarLargeButtonItem1 As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents BarLargeButtonItem3 As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents BarLargeButtonItem4 As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarLargeButtonItem2 As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents LayoutView1 As DevExpress.XtraGrid.Views.Layout.LayoutView
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblRec As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lblRec1 As Label
    Public WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Public WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtHouseNo As TextBox
    Public WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Public WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Public WithEvents txtSearch1 As DevExpress.XtraEditors.SearchControl
End Class
