<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adedBusiness
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adedBusiness))
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBusinessName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBusinessType = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtProprietor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCStatus = New System.Windows.Forms.ComboBox()
        Me.cbZone = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(413, 12)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(49, 33)
        Me.txtID.TabIndex = 14
        Me.txtID.Visible = False
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton2.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton2.Location = New System.Drawing.Point(233, 383)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(82, 34)
        Me.SimpleButton2.TabIndex = 8
        Me.SimpleButton2.Text = "CANCEL"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton1.Location = New System.Drawing.Point(136, 383)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(82, 34)
        Me.SimpleButton1.TabIndex = 7
        Me.SimpleButton1.Text = "SAVE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Business Name"
        '
        'txtBusinessName
        '
        Me.txtBusinessName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBusinessName.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusinessName.Location = New System.Drawing.Point(172, 40)
        Me.txtBusinessName.Name = "txtBusinessName"
        Me.txtBusinessName.Size = New System.Drawing.Size(256, 33)
        Me.txtBusinessName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 23)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Business Type"
        '
        'txtBusinessType
        '
        Me.txtBusinessType.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBusinessType.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusinessType.Location = New System.Drawing.Point(172, 89)
        Me.txtBusinessType.Name = "txtBusinessType"
        Me.txtBusinessType.Size = New System.Drawing.Size(256, 33)
        Me.txtBusinessType.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(109, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 23)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Purok"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(74, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 23)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Proprietor"
        '
        'txtProprietor
        '
        Me.txtProprietor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProprietor.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProprietor.Location = New System.Drawing.Point(172, 189)
        Me.txtProprietor.Name = "txtProprietor"
        Me.txtProprietor.Size = New System.Drawing.Size(256, 33)
        Me.txtProprietor.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(2, 281)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 23)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Proprietor Address"
        '
        'txtAddress
        '
        Me.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddress.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(172, 281)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(256, 33)
        Me.txtAddress.TabIndex = 5
        '
        'cbStatus
        '
        Me.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"ACTIVE", "INACTIVE"})
        Me.cbStatus.Location = New System.Drawing.Point(172, 329)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(256, 32)
        Me.cbStatus.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(104, 329)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 23)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Status"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(66, 241)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 23)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Civil Status"
        '
        'txtCStatus
        '
        Me.txtCStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtCStatus.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCStatus.FormattingEnabled = True
        Me.txtCStatus.Items.AddRange(New Object() {"SINGLE", "MARRIED", "WIDOWED"})
        Me.txtCStatus.Location = New System.Drawing.Point(172, 237)
        Me.txtCStatus.Name = "txtCStatus"
        Me.txtCStatus.Size = New System.Drawing.Size(256, 31)
        Me.txtCStatus.TabIndex = 27
        '
        'cbZone
        '
        Me.cbZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbZone.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbZone.FormattingEnabled = True
        Me.cbZone.Items.AddRange(New Object() {"SINGLE", "MARRIED", "WIDOWED"})
        Me.cbZone.Location = New System.Drawing.Point(172, 141)
        Me.cbZone.Name = "cbZone"
        Me.cbZone.Size = New System.Drawing.Size(256, 31)
        Me.cbZone.TabIndex = 114
        '
        'adedBusiness
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 437)
        Me.Controls.Add(Me.cbZone)
        Me.Controls.Add(Me.txtCStatus)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbStatus)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtProprietor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBusinessType)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBusinessName)
        Me.Name = "adedBusiness"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adedBusiness"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtID As TextBox
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBusinessName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBusinessType As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtProprietor As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCStatus As ComboBox
    Friend WithEvents cbZone As ComboBox
End Class
