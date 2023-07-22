<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adedUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adedUser))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtConfirmPass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNewPass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOldPass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.cbAcclvl = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 23)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Confirm Password"
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPass.Location = New System.Drawing.Point(172, 200)
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPass.Size = New System.Drawing.Size(256, 33)
        Me.txtConfirmPass.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 23)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "New Password"
        '
        'txtNewPass
        '
        Me.txtNewPass.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPass.Location = New System.Drawing.Point(172, 150)
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPass.Size = New System.Drawing.Size(256, 33)
        Me.txtNewPass.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 23)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Old Password"
        '
        'txtOldPass
        '
        Me.txtOldPass.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldPass.Location = New System.Drawing.Point(172, 100)
        Me.txtOldPass.Name = "txtOldPass"
        Me.txtOldPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOldPass.Size = New System.Drawing.Size(256, 33)
        Me.txtOldPass.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 23)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Username"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(172, 51)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(256, 33)
        Me.txtUsername.TabIndex = 1
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton2.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton2.Location = New System.Drawing.Point(235, 315)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(82, 34)
        Me.SimpleButton2.TabIndex = 7
        Me.SimpleButton2.Text = "CANCEL"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton1.Location = New System.Drawing.Point(138, 315)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(82, 34)
        Me.SimpleButton1.TabIndex = 6
        Me.SimpleButton1.Text = "SAVE"
        '
        'cbAcclvl
        '
        Me.cbAcclvl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAcclvl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAcclvl.FormattingEnabled = True
        Me.cbAcclvl.Items.AddRange(New Object() {"ADMINISTRATOR", "USER"})
        Me.cbAcclvl.Location = New System.Drawing.Point(172, 254)
        Me.cbAcclvl.Name = "cbAcclvl"
        Me.cbAcclvl.Size = New System.Drawing.Size(256, 32)
        Me.cbAcclvl.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(53, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 23)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Access Level"
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(396, 12)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(49, 33)
        Me.txtID.TabIndex = 33
        Me.txtID.Visible = False
        '
        'adedUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 365)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbAcclvl)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtConfirmPass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNewPass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtOldPass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUsername)
        Me.Name = "adedUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adedUser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents txtConfirmPass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNewPass As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtOldPass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbAcclvl As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtID As TextBox
End Class
