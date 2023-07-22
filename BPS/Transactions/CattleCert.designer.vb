<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CattleCert
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CattleCert))
        Me.txtRes = New DevExpress.XtraEditors.ButtonEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPurpose = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.asd = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCattle = New System.Windows.Forms.TextBox()
        Me.cbCattleType = New System.Windows.Forms.ComboBox()
        Me.cbGender = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtVendee = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtActivity = New System.Windows.Forms.TextBox()
        Me.txtResID = New System.Windows.Forms.TextBox()
        Me.txtOpt = New System.Windows.Forms.TextBox()
        Me.txttbl = New System.Windows.Forms.TextBox()
        Me.txtdbNo = New System.Windows.Forms.TextBox()
        CType(Me.txtRes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtRes
        '
        Me.txtRes.Location = New System.Drawing.Point(175, 68)
        Me.txtRes.Name = "txtRes"
        Me.txtRes.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRes.Properties.Appearance.Options.UseFont = True
        Me.txtRes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtRes.Properties.ReadOnly = True
        Me.txtRes.Size = New System.Drawing.Size(256, 32)
        Me.txtRes.TabIndex = 2
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton1.Location = New System.Drawing.Point(184, 416)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(120, 54)
        Me.SimpleButton1.TabIndex = 11
        Me.SimpleButton1.Text = "Save and Print"
        '
        'txtDate
        '
        Me.txtDate.CustomFormat = "MM/dd/yyyy"
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDate.Location = New System.Drawing.Point(175, 377)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(256, 29)
        Me.txtDate.TabIndex = 10
        Me.txtDate.Value = New Date(2018, 10, 27, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(120, 377)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 23)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(92, 338)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 23)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Purpose"
        '
        'txtPurpose
        '
        Me.txtPurpose.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPurpose.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurpose.Location = New System.Drawing.Point(175, 338)
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.Size = New System.Drawing.Size(256, 33)
        Me.txtPurpose.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 23)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Vendor's Name"
        '
        'txtNo
        '
        Me.txtNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNo.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNo.Location = New System.Drawing.Point(175, 29)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.ReadOnly = True
        Me.txtNo.Size = New System.Drawing.Size(256, 33)
        Me.txtNo.TabIndex = 1
        '
        'asd
        '
        Me.asd.AutoSize = True
        Me.asd.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.asd.Location = New System.Drawing.Point(48, 29)
        Me.asd.Name = "asd"
        Me.asd.Size = New System.Drawing.Size(121, 23)
        Me.asd.TabIndex = 42
        Me.asd.Text = "Clearance No"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(112, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 23)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Cattle"
        '
        'txtCattle
        '
        Me.txtCattle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCattle.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCattle.Location = New System.Drawing.Point(175, 106)
        Me.txtCattle.Name = "txtCattle"
        Me.txtCattle.Size = New System.Drawing.Size(256, 33)
        Me.txtCattle.TabIndex = 3
        '
        'cbCattleType
        '
        Me.cbCattleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCattleType.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCattleType.FormattingEnabled = True
        Me.cbCattleType.Items.AddRange(New Object() {"Branded", "Unbranded"})
        Me.cbCattleType.Location = New System.Drawing.Point(175, 145)
        Me.cbCattleType.Name = "cbCattleType"
        Me.cbCattleType.Size = New System.Drawing.Size(256, 32)
        Me.cbCattleType.TabIndex = 4
        '
        'cbGender
        '
        Me.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbGender.Location = New System.Drawing.Point(175, 183)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(256, 32)
        Me.cbGender.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(65, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 23)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Cattle Type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(44, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 23)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Cattle Gender"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(74, 221)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 23)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Cattle Age"
        '
        'txtAge
        '
        Me.txtAge.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAge.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(175, 221)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(152, 33)
        Me.txtAge.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(327, 226)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 23)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "(Years Old)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(32, 265)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 23)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "Vendee's Name"
        '
        'txtVendee
        '
        Me.txtVendee.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVendee.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVendee.Location = New System.Drawing.Point(175, 260)
        Me.txtVendee.Name = "txtVendee"
        Me.txtVendee.Size = New System.Drawing.Size(256, 33)
        Me.txtVendee.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 304)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(157, 23)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "Vendee's Address"
        '
        'txtAddress
        '
        Me.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddress.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(175, 299)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(256, 33)
        Me.txtAddress.TabIndex = 8
        '
        'txtActivity
        '
        Me.txtActivity.Location = New System.Drawing.Point(465, 460)
        Me.txtActivity.Name = "txtActivity"
        Me.txtActivity.Size = New System.Drawing.Size(102, 21)
        Me.txtActivity.TabIndex = 136
        Me.txtActivity.Visible = False
        '
        'txtResID
        '
        Me.txtResID.Location = New System.Drawing.Point(449, 487)
        Me.txtResID.Name = "txtResID"
        Me.txtResID.Size = New System.Drawing.Size(102, 21)
        Me.txtResID.TabIndex = 135
        Me.txtResID.Visible = False
        '
        'txtOpt
        '
        Me.txtOpt.Location = New System.Drawing.Point(443, 540)
        Me.txtOpt.Name = "txtOpt"
        Me.txtOpt.Size = New System.Drawing.Size(102, 21)
        Me.txtOpt.TabIndex = 134
        Me.txtOpt.Visible = False
        '
        'txttbl
        '
        Me.txttbl.Location = New System.Drawing.Point(366, 514)
        Me.txttbl.Name = "txttbl"
        Me.txttbl.Size = New System.Drawing.Size(102, 21)
        Me.txttbl.TabIndex = 133
        Me.txttbl.Visible = False
        '
        'txtdbNo
        '
        Me.txtdbNo.Location = New System.Drawing.Point(210, 514)
        Me.txtdbNo.Name = "txtdbNo"
        Me.txtdbNo.Size = New System.Drawing.Size(102, 21)
        Me.txtdbNo.TabIndex = 132
        Me.txtdbNo.Visible = False
        '
        'CattleCert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 478)
        Me.Controls.Add(Me.txtActivity)
        Me.Controls.Add(Me.txtResID)
        Me.Controls.Add(Me.txtOpt)
        Me.Controls.Add(Me.txttbl)
        Me.Controls.Add(Me.txtdbNo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtVendee)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbCattleType)
        Me.Controls.Add(Me.cbGender)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCattle)
        Me.Controls.Add(Me.txtRes)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPurpose)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNo)
        Me.Controls.Add(Me.asd)
        Me.Name = "CattleCert"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CattleCert"
        CType(Me.txtRes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents txtRes As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPurpose As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNo As TextBox
    Friend WithEvents asd As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCattle As TextBox
    Friend WithEvents cbCattleType As ComboBox
    Friend WithEvents cbGender As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtVendee As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtActivity As TextBox
    Friend WithEvents txtResID As TextBox
    Friend WithEvents txtOpt As TextBox
    Friend WithEvents txttbl As TextBox
    Friend WithEvents txtdbNo As TextBox
End Class
