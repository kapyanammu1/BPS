<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form97
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form97))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRelief = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRespondent = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtComplainant = New DevExpress.XtraEditors.ButtonEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtStatement = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCaseNo = New System.Windows.Forms.TextBox()
        Me.asd = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFor = New System.Windows.Forms.TextBox()
        CType(Me.txtRespondent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComplainant.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(73, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 23)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Relief/s"
        '
        'txtRelief
        '
        Me.txtRelief.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.txtRelief.Location = New System.Drawing.Point(150, 268)
        Me.txtRelief.Multiline = True
        Me.txtRelief.Name = "txtRelief"
        Me.txtRelief.Size = New System.Drawing.Size(387, 67)
        Me.txtRelief.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 46)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Statement of " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Complainant"
        '
        'txtRespondent
        '
        Me.txtRespondent.Location = New System.Drawing.Point(216, 147)
        Me.txtRespondent.Name = "txtRespondent"
        Me.txtRespondent.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRespondent.Properties.Appearance.Options.UseFont = True
        Me.txtRespondent.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtRespondent.Size = New System.Drawing.Size(321, 32)
        Me.txtRespondent.TabIndex = 52
        '
        'txtComplainant
        '
        Me.txtComplainant.Location = New System.Drawing.Point(216, 109)
        Me.txtComplainant.Name = "txtComplainant"
        Me.txtComplainant.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComplainant.Properties.Appearance.Options.UseFont = True
        Me.txtComplainant.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtComplainant.Size = New System.Drawing.Size(321, 32)
        Me.txtComplainant.TabIndex = 51
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton1.Location = New System.Drawing.Point(216, 376)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(120, 54)
        Me.SimpleButton1.TabIndex = 58
        Me.SimpleButton1.Text = "Save and Print"
        '
        'txtDate
        '
        Me.txtDate.CustomFormat = "MM/dd/yyyy"
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDate.Location = New System.Drawing.Point(216, 341)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(321, 29)
        Me.txtDate.TabIndex = 57
        Me.txtDate.Value = New Date(2018, 10, 27, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(161, 345)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 23)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(100, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 23)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Respondent"
        '
        'txtStatement
        '
        Me.txtStatement.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.txtStatement.Location = New System.Drawing.Point(150, 185)
        Me.txtStatement.Multiline = True
        Me.txtStatement.Name = "txtStatement"
        Me.txtStatement.Size = New System.Drawing.Size(387, 77)
        Me.txtStatement.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 23)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Complainant Name"
        '
        'txtCaseNo
        '
        Me.txtCaseNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCaseNo.Enabled = False
        Me.txtCaseNo.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaseNo.Location = New System.Drawing.Point(216, 12)
        Me.txtCaseNo.Name = "txtCaseNo"
        Me.txtCaseNo.Size = New System.Drawing.Size(321, 33)
        Me.txtCaseNo.TabIndex = 60
        '
        'asd
        '
        Me.asd.AutoSize = True
        Me.asd.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.asd.Location = New System.Drawing.Point(41, 17)
        Me.asd.Name = "asd"
        Me.asd.Size = New System.Drawing.Size(169, 23)
        Me.asd.TabIndex = 59
        Me.asd.Text = "Barangay Case No."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(166, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 23)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "For:"
        '
        'txtFor
        '
        Me.txtFor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFor.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.txtFor.Location = New System.Drawing.Point(216, 51)
        Me.txtFor.Multiline = True
        Me.txtFor.Name = "txtFor"
        Me.txtFor.Size = New System.Drawing.Size(321, 52)
        Me.txtFor.TabIndex = 66
        '
        'form97
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 435)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtFor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtRelief)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRespondent)
        Me.Controls.Add(Me.txtComplainant)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtStatement)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCaseNo)
        Me.Controls.Add(Me.asd)
        Me.Name = "form97"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "form97"
        CType(Me.txtRespondent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComplainant.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRelief As TextBox
    Friend WithEvents Label1 As Label
    Public WithEvents txtRespondent As DevExpress.XtraEditors.ButtonEdit
    Public WithEvents txtComplainant As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtStatement As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCaseNo As TextBox
    Friend WithEvents asd As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtFor As TextBox
End Class
