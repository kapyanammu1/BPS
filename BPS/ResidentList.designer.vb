<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ResidentList
    Inherits BPS.List

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ResidentList))
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.Voter = New System.Windows.Forms.RadioButton()
        Me.CR = New System.Windows.Forms.RadioButton()
        Me.Deceased = New System.Windows.Forms.RadioButton()
        Me.Indigent = New System.Windows.Forms.RadioButton()
        Me.NewBorn = New System.Windows.Forms.RadioButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.cboZone = New System.Windows.Forms.ComboBox()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtfilter = New System.Windows.Forms.TextBox()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SP = New System.Windows.Forms.RadioButton()
        Me.PWD = New System.Windows.Forms.RadioButton()
        Me.OSY = New System.Windows.Forms.RadioButton()
        Me.OFW = New System.Windows.Forms.RadioButton()
        Me.rbCS = New System.Windows.Forms.RadioButton()
        Me.rbAll = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DP = New System.Windows.Forms.RadioButton()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtSearch1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Location = New System.Drawing.Point(0, 141)
        Me.GroupControl1.Size = New System.Drawing.Size(1057, 68)
        Me.GroupControl1.Text = "SEARCH"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton1.Visible = False
        '
        'txtSearch1
        '
        Me.txtSearch1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch1.Properties.Appearance.Options.UseFont = True
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.txtTo)
        Me.GroupControl2.Controls.Add(Me.Voter)
        Me.GroupControl2.Controls.Add(Me.CR)
        Me.GroupControl2.Controls.Add(Me.Deceased)
        Me.GroupControl2.Controls.Add(Me.Indigent)
        Me.GroupControl2.Controls.Add(Me.NewBorn)
        Me.GroupControl2.Controls.Add(Me.SimpleButton3)
        Me.GroupControl2.Controls.Add(Me.GroupControl3)
        Me.GroupControl2.Controls.Add(Me.txtfilter)
        Me.GroupControl2.Controls.Add(Me.SimpleButton2)
        Me.GroupControl2.Controls.Add(Me.SP)
        Me.GroupControl2.Controls.Add(Me.PWD)
        Me.GroupControl2.Controls.Add(Me.OSY)
        Me.GroupControl2.Controls.Add(Me.OFW)
        Me.GroupControl2.Controls.Add(Me.rbCS)
        Me.GroupControl2.Controls.Add(Me.rbAll)
        Me.GroupControl2.Controls.Add(Me.Label1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl2.Location = New System.Drawing.Point(0, 44)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1057, 97)
        Me.GroupControl2.TabIndex = 31
        Me.GroupControl2.Text = "FILTER"
        '
        'txtTo
        '
        Me.txtTo.Location = New System.Drawing.Point(469, 72)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(29, 21)
        Me.txtTo.TabIndex = 117
        Me.txtTo.Text = "1"
        '
        'Voter
        '
        Me.Voter.AutoSize = True
        Me.Voter.Location = New System.Drawing.Point(704, 28)
        Me.Voter.Name = "Voter"
        Me.Voter.Size = New System.Drawing.Size(56, 17)
        Me.Voter.TabIndex = 15
        Me.Voter.TabStop = True
        Me.Voter.Text = "Voters"
        Me.Voter.UseVisualStyleBackColor = True
        '
        'CR
        '
        Me.CR.AutoSize = True
        Me.CR.Location = New System.Drawing.Point(704, 50)
        Me.CR.Name = "CR"
        Me.CR.Size = New System.Drawing.Size(64, 17)
        Me.CR.TabIndex = 14
        Me.CR.TabStop = True
        Me.CR.Text = "With CR"
        Me.CR.UseVisualStyleBackColor = True
        '
        'Deceased
        '
        Me.Deceased.AutoSize = True
        Me.Deceased.Location = New System.Drawing.Point(705, 74)
        Me.Deceased.Name = "Deceased"
        Me.Deceased.Size = New System.Drawing.Size(72, 17)
        Me.Deceased.TabIndex = 13
        Me.Deceased.TabStop = True
        Me.Deceased.Text = "Deceased"
        Me.Deceased.UseVisualStyleBackColor = True
        '
        'Indigent
        '
        Me.Indigent.AutoSize = True
        Me.Indigent.Location = New System.Drawing.Point(603, 74)
        Me.Indigent.Name = "Indigent"
        Me.Indigent.Size = New System.Drawing.Size(65, 17)
        Me.Indigent.TabIndex = 12
        Me.Indigent.TabStop = True
        Me.Indigent.Text = "Indigent"
        Me.Indigent.UseVisualStyleBackColor = True
        '
        'NewBorn
        '
        Me.NewBorn.AutoSize = True
        Me.NewBorn.Location = New System.Drawing.Point(343, 74)
        Me.NewBorn.Name = "NewBorn"
        Me.NewBorn.Size = New System.Drawing.Size(71, 17)
        Me.NewBorn.TabIndex = 11
        Me.NewBorn.TabStop = True
        Me.NewBorn.Text = "New Born"
        Me.NewBorn.UseVisualStyleBackColor = True
        '
        'SimpleButton3
        '
        Me.SimpleButton3.ImageOptions.SvgImage = Global.BPS.My.Resources.Resources.print
        Me.SimpleButton3.Location = New System.Drawing.Point(913, 29)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(93, 62)
        Me.SimpleButton3.TabIndex = 10
        Me.SimpleButton3.Text = "PRINT"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.cboZone)
        Me.GroupControl3.Controls.Add(Me.LabelControl9)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupControl3.Location = New System.Drawing.Point(2, 27)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(323, 68)
        Me.GroupControl3.TabIndex = 9
        Me.GroupControl3.Text = "BARANGAY"
        '
        'cboZone
        '
        Me.cboZone.AutoCompleteCustomSource.AddRange(New String() {"APAYAO", "AQUIB", "BAUNG", "CALAOAGAN", "CATARUAN", "DUGAYUNG", "GUMARUENG", "MACAPIL", "MAGUILLING", "MINANGA", "POBLACION I", "POBLACION II", "SANTA BARBARA", "SANTO DOMINGO", "SICATNA", "VILLA REY (SAN GASPAR)", "VILLA REYNO", "WARAT"})
        Me.cboZone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboZone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboZone.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboZone.FormattingEnabled = True
        Me.cboZone.Items.AddRange(New Object() {"APAYAO", "AQUIB", "BAUNG", "CALAOAGAN", "CATARUAN", "DUGAYUNG", "GUMARUENG", "MACAPIL", "MAGUILLING", "MINANGA", "POBLACION I", "POBLACION II", "SANTA BARBARA", "SANTO DOMINGO", "SICATNA", "VILLA REY (SAN GASPAR)", "VILLA REYNO", "WARAT"})
        Me.cboZone.Location = New System.Drawing.Point(62, 23)
        Me.cboZone.Name = "cboZone"
        Me.cboZone.Size = New System.Drawing.Size(256, 31)
        Me.cboZone.TabIndex = 102
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(13, 30)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(37, 18)
        Me.LabelControl9.TabIndex = 103
        Me.LabelControl9.Text = "ZONE"
        '
        'txtfilter
        '
        Me.txtfilter.Location = New System.Drawing.Point(997, 42)
        Me.txtfilter.Name = "txtfilter"
        Me.txtfilter.Size = New System.Drawing.Size(28, 21)
        Me.txtfilter.TabIndex = 8
        Me.txtfilter.Visible = False
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.SvgImage = Global.BPS.My.Resources.Resources.quickfilter
        Me.SimpleButton2.Location = New System.Drawing.Point(814, 30)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(93, 62)
        Me.SimpleButton2.TabIndex = 7
        Me.SimpleButton2.Text = "FILTER"
        '
        'SP
        '
        Me.SP.AutoSize = True
        Me.SP.Location = New System.Drawing.Point(603, 28)
        Me.SP.Name = "SP"
        Me.SP.Size = New System.Drawing.Size(85, 17)
        Me.SP.TabIndex = 6
        Me.SP.TabStop = True
        Me.SP.Text = "Solo Parents"
        Me.SP.UseVisualStyleBackColor = True
        '
        'PWD
        '
        Me.PWD.AutoSize = True
        Me.PWD.Location = New System.Drawing.Point(433, 51)
        Me.PWD.Name = "PWD"
        Me.PWD.Size = New System.Drawing.Size(165, 17)
        Me.PWD.TabIndex = 4
        Me.PWD.TabStop = True
        Me.PWD.Text = "Persons with Disability (PWD)"
        Me.PWD.UseVisualStyleBackColor = True
        '
        'OSY
        '
        Me.OSY.AutoSize = True
        Me.OSY.Location = New System.Drawing.Point(433, 28)
        Me.OSY.Name = "OSY"
        Me.OSY.Size = New System.Drawing.Size(121, 17)
        Me.OSY.TabIndex = 3
        Me.OSY.TabStop = True
        Me.OSY.Text = "Out of School Youth"
        Me.OSY.UseVisualStyleBackColor = True
        '
        'OFW
        '
        Me.OFW.AutoSize = True
        Me.OFW.Location = New System.Drawing.Point(603, 51)
        Me.OFW.Name = "OFW"
        Me.OFW.Size = New System.Drawing.Size(49, 17)
        Me.OFW.TabIndex = 2
        Me.OFW.TabStop = True
        Me.OFW.Text = "OFW"
        Me.OFW.UseVisualStyleBackColor = True
        '
        'rbCS
        '
        Me.rbCS.AutoSize = True
        Me.rbCS.Location = New System.Drawing.Point(343, 51)
        Me.rbCS.Name = "rbCS"
        Me.rbCS.Size = New System.Drawing.Size(90, 17)
        Me.rbCS.TabIndex = 1
        Me.rbCS.TabStop = True
        Me.rbCS.Text = "Senior Citizen"
        Me.rbCS.UseVisualStyleBackColor = True
        '
        'rbAll
        '
        Me.rbAll.AutoSize = True
        Me.rbAll.Location = New System.Drawing.Point(343, 28)
        Me.rbAll.Name = "rbAll"
        Me.rbAll.Size = New System.Drawing.Size(42, 17)
        Me.rbAll.TabIndex = 0
        Me.rbAll.TabStop = True
        Me.rbAll.Text = "ALL"
        Me.rbAll.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(417, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 118
        Me.Label1.Text = "From 0 To"
        '
        'DP
        '
        Me.DP.AutoSize = True
        Me.DP.Enabled = False
        Me.DP.Location = New System.Drawing.Point(808, 12)
        Me.DP.Name = "DP"
        Me.DP.Size = New System.Drawing.Size(102, 17)
        Me.DP.TabIndex = 5
        Me.DP.TabStop = True
        Me.DP.Text = "Dialysis Patients"
        Me.DP.UseVisualStyleBackColor = True
        Me.DP.Visible = False
        '
        'ResidentList
        '
        Me.AcceptButton = Me.SimpleButton2
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1057, 448)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.DP)
        Me.Name = "ResidentList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.DP, 0)
        Me.Controls.SetChildIndex(Me.GroupControl2, 0)
        Me.Controls.SetChildIndex(Me.GroupControl1, 0)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.txtSearch1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cboZone As ComboBox
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtfilter As TextBox
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SP As RadioButton
    Friend WithEvents DP As RadioButton
    Friend WithEvents PWD As RadioButton
    Friend WithEvents OSY As RadioButton
    Friend WithEvents OFW As RadioButton
    Friend WithEvents rbCS As RadioButton
    Friend WithEvents rbAll As RadioButton
    Friend WithEvents NewBorn As RadioButton
    Friend WithEvents Indigent As RadioButton
    Friend WithEvents Deceased As RadioButton
    Friend WithEvents Voter As RadioButton
    Friend WithEvents CR As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTo As TextBox
End Class
