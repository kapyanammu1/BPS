<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Officials
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Officials))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BarLargeButtonItem3 = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSearch = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.lblRec = New DevExpress.XtraBars.BarStaticItem()
        Me.RepositoryItemSearchControl1 = New DevExpress.XtraEditors.Repository.RepositoryItemSearchControl()
        Me.txtID = New System.Windows.Forms.TextBox()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.BackColor = System.Drawing.Color.LightGray
        Me.LabelControl1.Appearance.Options.UseBackColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(715, 585)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(210, 13)
        Me.LabelControl1.TabIndex = 101
        Me.LabelControl1.Text = "NOTE: PLEASE DOUBLE CLICK TO CHOOSE."
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 67)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(926, 512)
        Me.GridControl1.TabIndex = 102
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 67)
        Me.barDockControlTop.Manager = Nothing
        Me.barDockControlTop.Size = New System.Drawing.Size(926, 0)
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.BarDockControl1)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarLargeButtonItem3, Me.btnSearch, Me.lblRec})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 9
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSearchControl1})
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 1
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarLargeButtonItem3, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar1.Text = "Tools"
        '
        'BarLargeButtonItem3
        '
        Me.BarLargeButtonItem3.Caption = "EDIT/UPDATE"
        Me.BarLargeButtonItem3.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right
        Me.BarLargeButtonItem3.Id = 5
        Me.BarLargeButtonItem3.ImageOptions.SvgImage = CType(resources.GetObject("BarLargeButtonItem3.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarLargeButtonItem3.Name = "BarLargeButtonItem3"
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
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Manager = Me.BarManager1
        Me.BarDockControl1.Size = New System.Drawing.Size(926, 67)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 579)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(926, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 67)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 512)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(926, 67)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 512)
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
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(555, 40)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(66, 21)
        Me.txtID.TabIndex = 108
        Me.txtID.Visible = False
        '
        'Officials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 602)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Name = "Officials"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barangay Officials"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents BarLargeButtonItem3 As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSearch As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents lblRec As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents RepositoryItemSearchControl1 As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
    Friend WithEvents txtID As TextBox
End Class
