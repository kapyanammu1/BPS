﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BrgyClearance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BrgyClearance))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.asd = New System.Windows.Forms.Label()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtRes = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtResID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbType = New System.Windows.Forms.ComboBox()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.txtCTC = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCTCDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCTCAmount = New System.Windows.Forms.TextBox()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtORDate = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtORno = New System.Windows.Forms.TextBox()
        Me.txtOrAmount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.txtPurpose = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.txtRes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 23)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Resident Name"
        '
        'txtNo
        '
        Me.txtNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNo.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNo.Location = New System.Drawing.Point(149, 30)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(256, 33)
        Me.txtNo.TabIndex = 1
        '
        'asd
        '
        Me.asd.AutoSize = True
        Me.asd.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.asd.Location = New System.Drawing.Point(22, 32)
        Me.asd.Name = "asd"
        Me.asd.Size = New System.Drawing.Size(121, 23)
        Me.asd.TabIndex = 22
        Me.asd.Text = "Clearance No"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton1.Location = New System.Drawing.Point(161, 500)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(120, 54)
        Me.SimpleButton1.TabIndex = 9
        Me.SimpleButton1.Text = "Save and Print"
        '
        'txtRes
        '
        Me.txtRes.Location = New System.Drawing.Point(149, 106)
        Me.txtRes.Name = "txtRes"
        Me.txtRes.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRes.Properties.Appearance.Options.UseFont = True
        Me.txtRes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtRes.Size = New System.Drawing.Size(256, 32)
        Me.txtRes.TabIndex = 3
        '
        'txtResID
        '
        Me.txtResID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtResID.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResID.Location = New System.Drawing.Point(447, 1)
        Me.txtResID.Name = "txtResID"
        Me.txtResID.Size = New System.Drawing.Size(37, 33)
        Me.txtResID.TabIndex = 32
        Me.txtResID.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 23)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Clearance Type"
        '
        'cbType
        '
        Me.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbType.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbType.FormattingEnabled = True
        Me.cbType.Items.AddRange(New Object() {"PERSONAL", "LARGE SCALE BUSINESS", "MEDIUM SCALE BUSINESS", "SMALL SCALE BUSINESS", "MICRO SCALE BUSINESS"})
        Me.cbType.Location = New System.Drawing.Point(149, 69)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(256, 31)
        Me.cbType.TabIndex = 2
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.txtCTC)
        Me.GroupControl2.Controls.Add(Me.Label3)
        Me.GroupControl2.Controls.Add(Me.Label4)
        Me.GroupControl2.Controls.Add(Me.txtCTCDate)
        Me.GroupControl2.Controls.Add(Me.Label5)
        Me.GroupControl2.Controls.Add(Me.txtCTCAmount)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 351)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(417, 144)
        Me.GroupControl2.TabIndex = 156
        Me.GroupControl2.Text = "Cedula"
        '
        'txtCTC
        '
        Me.txtCTC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCTC.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCTC.Location = New System.Drawing.Point(149, 33)
        Me.txtCTC.Name = "txtCTC"
        Me.txtCTC.Size = New System.Drawing.Size(256, 33)
        Me.txtCTC.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(65, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 23)
        Me.Label3.TabIndex = 140
        Me.Label3.Text = "CTC No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(94, 114)
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
        Me.txtCTCDate.Location = New System.Drawing.Point(149, 110)
        Me.txtCTCDate.Name = "txtCTCDate"
        Me.txtCTCDate.Size = New System.Drawing.Size(256, 29)
        Me.txtCTCDate.TabIndex = 6
        Me.txtCTCDate.Value = New Date(2018, 10, 27, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(68, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 23)
        Me.Label5.TabIndex = 144
        Me.Label5.Text = "Amount"
        '
        'txtCTCAmount
        '
        Me.txtCTCAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCTCAmount.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCTCAmount.Location = New System.Drawing.Point(149, 72)
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
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 201)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(417, 144)
        Me.GroupControl1.TabIndex = 155
        Me.GroupControl1.Text = "OR Number"
        '
        'txtORDate
        '
        Me.txtORDate.CustomFormat = "MM/dd/yyyy"
        Me.txtORDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtORDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtORDate.Location = New System.Drawing.Point(149, 108)
        Me.txtORDate.Name = "txtORDate"
        Me.txtORDate.Size = New System.Drawing.Size(256, 29)
        Me.txtORDate.TabIndex = 150
        Me.txtORDate.Value = New Date(2018, 10, 27, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(94, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 23)
        Me.Label8.TabIndex = 151
        Me.Label8.Text = "Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(68, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 23)
        Me.Label7.TabIndex = 151
        Me.Label7.Text = "Amount"
        '
        'txtORno
        '
        Me.txtORno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtORno.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtORno.Location = New System.Drawing.Point(149, 30)
        Me.txtORno.Name = "txtORno"
        Me.txtORno.Size = New System.Drawing.Size(256, 33)
        Me.txtORno.TabIndex = 5
        '
        'txtOrAmount
        '
        Me.txtOrAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOrAmount.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrAmount.Location = New System.Drawing.Point(149, 69)
        Me.txtOrAmount.Name = "txtOrAmount"
        Me.txtOrAmount.Size = New System.Drawing.Size(256, 33)
        Me.txtOrAmount.TabIndex = 150
        Me.txtOrAmount.Text = "0.00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(61, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 23)
        Me.Label6.TabIndex = 148
        Me.Label6.Text = "O.R. No."
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.txtPurpose)
        Me.GroupControl3.Controls.Add(Me.Label9)
        Me.GroupControl3.Controls.Add(Me.txtNo)
        Me.GroupControl3.Controls.Add(Me.asd)
        Me.GroupControl3.Controls.Add(Me.Label2)
        Me.GroupControl3.Controls.Add(Me.cbType)
        Me.GroupControl3.Controls.Add(Me.txtRes)
        Me.GroupControl3.Controls.Add(Me.Label1)
        Me.GroupControl3.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(417, 183)
        Me.GroupControl3.TabIndex = 156
        Me.GroupControl3.Text = "Clearance Details"
        '
        'txtPurpose
        '
        Me.txtPurpose.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPurpose.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurpose.Location = New System.Drawing.Point(149, 144)
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.Size = New System.Drawing.Size(256, 33)
        Me.txtPurpose.TabIndex = 38
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(66, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 23)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Purpose"
        '
        'BrgyClearance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 559)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.txtResID)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Name = "BrgyClearance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BrgyClearance"
        CType(Me.txtRes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNo As TextBox
    Friend WithEvents asd As Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Public WithEvents txtRes As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtResID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbType As ComboBox
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtCTC As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCTCDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCTCAmount As TextBox
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtORDate As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtORno As TextBox
    Friend WithEvents txtOrAmount As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtPurpose As TextBox
    Friend WithEvents Label9 As Label
End Class
