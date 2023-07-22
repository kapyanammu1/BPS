<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusinessClearance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BusinessClearance))
        Me.txtActivity = New System.Windows.Forms.TextBox()
        Me.txtResID = New System.Windows.Forms.TextBox()
        Me.txtOpt = New System.Windows.Forms.TextBox()
        Me.txttbl = New System.Windows.Forms.TextBox()
        Me.txtdbNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.txtBusinessName = New DevExpress.XtraEditors.ButtonEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.cbType = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.txtCTC = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCTCDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCTCAmount = New System.Windows.Forms.TextBox()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtORDate = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtORno = New System.Windows.Forms.TextBox()
        Me.txtOrAmount = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.txtBusinessName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtActivity
        '
        Me.txtActivity.Location = New System.Drawing.Point(458, 452)
        Me.txtActivity.Name = "txtActivity"
        Me.txtActivity.Size = New System.Drawing.Size(102, 21)
        Me.txtActivity.TabIndex = 163
        Me.txtActivity.Visible = False
        '
        'txtResID
        '
        Me.txtResID.Location = New System.Drawing.Point(442, 479)
        Me.txtResID.Name = "txtResID"
        Me.txtResID.Size = New System.Drawing.Size(102, 21)
        Me.txtResID.TabIndex = 162
        Me.txtResID.Visible = False
        '
        'txtOpt
        '
        Me.txtOpt.Location = New System.Drawing.Point(436, 532)
        Me.txtOpt.Name = "txtOpt"
        Me.txtOpt.Size = New System.Drawing.Size(102, 21)
        Me.txtOpt.TabIndex = 161
        Me.txtOpt.Visible = False
        '
        'txttbl
        '
        Me.txttbl.Location = New System.Drawing.Point(359, 506)
        Me.txttbl.Name = "txttbl"
        Me.txttbl.Size = New System.Drawing.Size(102, 21)
        Me.txttbl.TabIndex = 160
        Me.txttbl.Visible = False
        '
        'txtdbNo
        '
        Me.txtdbNo.Location = New System.Drawing.Point(203, 506)
        Me.txtdbNo.Name = "txtdbNo"
        Me.txtdbNo.Size = New System.Drawing.Size(102, 21)
        Me.txtdbNo.TabIndex = 159
        Me.txtdbNo.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 23)
        Me.Label1.TabIndex = 147
        Me.Label1.Text = "Business Name"
        '
        'txtNo
        '
        Me.txtNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNo.Enabled = False
        Me.txtNo.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNo.Location = New System.Drawing.Point(209, 32)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(203, 33)
        Me.txtNo.TabIndex = 1
        '
        'txtBusinessName
        '
        Me.txtBusinessName.Location = New System.Drawing.Point(156, 104)
        Me.txtBusinessName.Name = "txtBusinessName"
        Me.txtBusinessName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusinessName.Properties.Appearance.Options.UseFont = True
        Me.txtBusinessName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtBusinessName.Properties.ReadOnly = True
        Me.txtBusinessName.Size = New System.Drawing.Size(256, 32)
        Me.txtBusinessName.TabIndex = 2
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SimpleButton1.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton1.Location = New System.Drawing.Point(149, 451)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(120, 54)
        Me.SimpleButton1.TabIndex = 7
        Me.SimpleButton1.Text = "Save and Print"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 23)
        Me.Label2.TabIndex = 139
        Me.Label2.Text = "Business Clearance No"
        '
        'txtID
        '
        Me.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(497, 328)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(38, 33)
        Me.txtID.TabIndex = 164
        Me.txtID.Visible = False
        '
        'cbType
        '
        Me.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbType.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbType.FormattingEnabled = True
        Me.cbType.Items.AddRange(New Object() {"MANAGEMENT BUSINESS", "CORPORATE BUSINESS"})
        Me.cbType.Location = New System.Drawing.Point(156, 69)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(256, 31)
        Me.cbType.TabIndex = 165
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 23)
        Me.Label5.TabIndex = 166
        Me.Label5.Text = "Clearance Type"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.txtNo)
        Me.GroupControl3.Controls.Add(Me.Label2)
        Me.GroupControl3.Controls.Add(Me.txtBusinessName)
        Me.GroupControl3.Controls.Add(Me.cbType)
        Me.GroupControl3.Controls.Add(Me.Label1)
        Me.GroupControl3.Controls.Add(Me.Label5)
        Me.GroupControl3.Location = New System.Drawing.Point(8, 8)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(417, 142)
        Me.GroupControl3.TabIndex = 169
        Me.GroupControl3.Text = "Clearance Details"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.txtCTC)
        Me.GroupControl2.Controls.Add(Me.Label3)
        Me.GroupControl2.Controls.Add(Me.Label4)
        Me.GroupControl2.Controls.Add(Me.txtCTCDate)
        Me.GroupControl2.Controls.Add(Me.Label6)
        Me.GroupControl2.Controls.Add(Me.txtCTCAmount)
        Me.GroupControl2.Location = New System.Drawing.Point(8, 303)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(417, 144)
        Me.GroupControl2.TabIndex = 171
        Me.GroupControl2.Text = "Cedula"
        '
        'txtCTC
        '
        Me.txtCTC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCTC.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCTC.Location = New System.Drawing.Point(156, 32)
        Me.txtCTC.Name = "txtCTC"
        Me.txtCTC.Size = New System.Drawing.Size(256, 33)
        Me.txtCTC.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(75, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 23)
        Me.Label3.TabIndex = 140
        Me.Label3.Text = "CTC No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(104, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 23)
        Me.Label4.TabIndex = 141
        Me.Label4.Text = "Date"
        '
        'txtCTCDate
        '
        Me.txtCTCDate.CustomFormat = "MM/dd/yyyy"
        Me.txtCTCDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCTCDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtCTCDate.Location = New System.Drawing.Point(156, 109)
        Me.txtCTCDate.Name = "txtCTCDate"
        Me.txtCTCDate.Size = New System.Drawing.Size(256, 29)
        Me.txtCTCDate.TabIndex = 6
        Me.txtCTCDate.Value = New Date(2018, 10, 27, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(78, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 23)
        Me.Label6.TabIndex = 144
        Me.Label6.Text = "Amount"
        '
        'txtCTCAmount
        '
        Me.txtCTCAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCTCAmount.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCTCAmount.Location = New System.Drawing.Point(156, 71)
        Me.txtCTCAmount.Name = "txtCTCAmount"
        Me.txtCTCAmount.Size = New System.Drawing.Size(256, 33)
        Me.txtCTCAmount.TabIndex = 4
        Me.txtCTCAmount.Text = "0.00"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtORDate)
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.txtORno)
        Me.GroupControl1.Controls.Add(Me.txtOrAmount)
        Me.GroupControl1.Controls.Add(Me.Label9)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 156)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(417, 144)
        Me.GroupControl1.TabIndex = 170
        Me.GroupControl1.Text = "OR Number"
        '
        'txtORDate
        '
        Me.txtORDate.CustomFormat = "MM/dd/yyyy"
        Me.txtORDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtORDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtORDate.Location = New System.Drawing.Point(156, 110)
        Me.txtORDate.Name = "txtORDate"
        Me.txtORDate.Size = New System.Drawing.Size(256, 29)
        Me.txtORDate.TabIndex = 150
        Me.txtORDate.Value = New Date(2018, 10, 27, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(104, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 23)
        Me.Label8.TabIndex = 151
        Me.Label8.Text = "Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(78, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 23)
        Me.Label7.TabIndex = 151
        Me.Label7.Text = "Amount"
        '
        'txtORno
        '
        Me.txtORno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtORno.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtORno.Location = New System.Drawing.Point(156, 32)
        Me.txtORno.Name = "txtORno"
        Me.txtORno.Size = New System.Drawing.Size(256, 33)
        Me.txtORno.TabIndex = 5
        '
        'txtOrAmount
        '
        Me.txtOrAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOrAmount.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrAmount.Location = New System.Drawing.Point(156, 71)
        Me.txtOrAmount.Name = "txtOrAmount"
        Me.txtOrAmount.Size = New System.Drawing.Size(256, 33)
        Me.txtOrAmount.TabIndex = 150
        Me.txtOrAmount.Text = "0.00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(71, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 23)
        Me.Label9.TabIndex = 148
        Me.Label9.Text = "O.R. No."
        '
        'BusinessClearance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 509)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtActivity)
        Me.Controls.Add(Me.txtResID)
        Me.Controls.Add(Me.txtOpt)
        Me.Controls.Add(Me.txttbl)
        Me.Controls.Add(Me.txtdbNo)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Name = "BusinessClearance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BusinessClearance"
        CType(Me.txtBusinessName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtActivity As TextBox
    Friend WithEvents txtResID As TextBox
    Friend WithEvents txtOpt As TextBox
    Friend WithEvents txttbl As TextBox
    Friend WithEvents txtdbNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNo As TextBox
    Public WithEvents txtBusinessName As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents cbType As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtCTC As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCTCDate As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCTCAmount As TextBox
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtORDate As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtORno As TextBox
    Friend WithEvents txtOrAmount As TextBox
    Friend WithEvents Label9 As Label
End Class
