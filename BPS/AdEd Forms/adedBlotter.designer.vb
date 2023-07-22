<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adedBlotter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adedBlotter))
        Me.txtCNID = New System.Windows.Forms.TextBox()
        Me.txtCN = New DevExpress.XtraEditors.ButtonEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtStatement = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.asd = New System.Windows.Forms.Label()
        Me.txtPTC = New DevExpress.XtraEditors.ButtonEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtaction = New System.Windows.Forms.TextBox()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPTCID = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        CType(Me.txtCN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPTC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCNID
        '
        Me.txtCNID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCNID.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCNID.Location = New System.Drawing.Point(485, 76)
        Me.txtCNID.Name = "txtCNID"
        Me.txtCNID.Size = New System.Drawing.Size(37, 33)
        Me.txtCNID.TabIndex = 42
        Me.txtCNID.Visible = False
        '
        'txtCN
        '
        Me.txtCN.Location = New System.Drawing.Point(185, 81)
        Me.txtCN.Name = "txtCN"
        Me.txtCN.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCN.Properties.Appearance.Options.UseFont = True
        Me.txtCN.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtCN.Properties.ReadOnly = True
        Me.txtCN.Size = New System.Drawing.Size(256, 32)
        Me.txtCN.TabIndex = 1
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton1.Location = New System.Drawing.Point(164, 464)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(120, 54)
        Me.SimpleButton1.TabIndex = 8
        Me.SimpleButton1.Text = "Save and Print"
        '
        'txtDate
        '
        Me.txtDate.CustomFormat = "MM/dd/yyyy"
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDate.Location = New System.Drawing.Point(185, 424)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(256, 29)
        Me.txtDate.TabIndex = 7
        Me.txtDate.Value = New Date(2018, 10, 27, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(130, 428)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 23)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(102, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 23)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Accused"
        '
        'txtStatement
        '
        Me.txtStatement.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStatement.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatement.Location = New System.Drawing.Point(185, 157)
        Me.txtStatement.Multiline = True
        Me.txtStatement.Name = "txtStatement"
        Me.txtStatement.Size = New System.Drawing.Size(256, 77)
        Me.txtStatement.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 23)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Complainant Name"
        '
        'txtNo
        '
        Me.txtNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNo.Enabled = False
        Me.txtNo.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNo.Location = New System.Drawing.Point(185, 42)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(256, 33)
        Me.txtNo.TabIndex = 34
        '
        'asd
        '
        Me.asd.AutoSize = True
        Me.asd.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.asd.Location = New System.Drawing.Point(86, 42)
        Me.asd.Name = "asd"
        Me.asd.Size = New System.Drawing.Size(93, 23)
        Me.asd.TabIndex = 33
        Me.asd.Text = "Blotter No"
        '
        'txtPTC
        '
        Me.txtPTC.Location = New System.Drawing.Point(185, 119)
        Me.txtPTC.Name = "txtPTC"
        Me.txtPTC.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPTC.Properties.Appearance.Options.UseFont = True
        Me.txtPTC.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtPTC.Properties.ReadOnly = True
        Me.txtPTC.Size = New System.Drawing.Size(256, 32)
        Me.txtPTC.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 46)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Statement of " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Complainant"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(74, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 46)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Location of " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Incident"
        '
        'txtLocation
        '
        Me.txtLocation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLocation.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocation.Location = New System.Drawing.Point(185, 240)
        Me.txtLocation.Multiline = True
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(256, 67)
        Me.txtLocation.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(61, 313)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 23)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Action Taken"
        '
        'txtaction
        '
        Me.txtaction.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtaction.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaction.Location = New System.Drawing.Point(185, 313)
        Me.txtaction.Multiline = True
        Me.txtaction.Name = "txtaction"
        Me.txtaction.Size = New System.Drawing.Size(256, 67)
        Me.txtaction.TabIndex = 5
        '
        'cbStatus
        '
        Me.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatus.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"SOLVED", "UNSOLVED"})
        Me.cbStatus.Location = New System.Drawing.Point(185, 386)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(256, 33)
        Me.cbStatus.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(119, 386)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 23)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Status"
        '
        'txtPTCID
        '
        Me.txtPTCID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPTCID.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPTCID.Location = New System.Drawing.Point(485, 115)
        Me.txtPTCID.Name = "txtPTCID"
        Me.txtPTCID.Size = New System.Drawing.Size(37, 33)
        Me.txtPTCID.TabIndex = 51
        Me.txtPTCID.Visible = False
        '
        'txtID
        '
        Me.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtID.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(485, 197)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(37, 33)
        Me.txtID.TabIndex = 52
        Me.txtID.Visible = False
        '
        'adedBlotter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 530)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtPTCID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbStatus)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtaction)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPTC)
        Me.Controls.Add(Me.txtCNID)
        Me.Controls.Add(Me.txtCN)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtStatement)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNo)
        Me.Controls.Add(Me.asd)
        Me.Name = "adedBlotter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adedBlotter"
        CType(Me.txtCN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPTC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCNID As TextBox
    Public WithEvents txtCN As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtStatement As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNo As TextBox
    Friend WithEvents asd As Label
    Public WithEvents txtPTC As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtaction As TextBox
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPTCID As TextBox
    Friend WithEvents txtID As TextBox
End Class
