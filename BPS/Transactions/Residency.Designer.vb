<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Residency
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Residency))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPurpose = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtResID = New System.Windows.Forms.TextBox()
        Me.txtRes = New DevExpress.XtraEditors.ButtonEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCTC = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.asd = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtORno = New System.Windows.Forms.TextBox()
        Me.txtCTCDate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.txtRes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(443, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 23)
        Me.Label6.TabIndex = 132
        Me.Label6.Text = "Purpose"
        Me.Label6.Visible = False
        '
        'txtPurpose
        '
        Me.txtPurpose.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPurpose.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurpose.Location = New System.Drawing.Point(537, 230)
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.Size = New System.Drawing.Size(256, 33)
        Me.txtPurpose.TabIndex = 131
        Me.txtPurpose.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(80, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 23)
        Me.Label5.TabIndex = 130
        Me.Label5.Text = "Amount"
        '
        'txtAmount
        '
        Me.txtAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAmount.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(161, 218)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(256, 33)
        Me.txtAmount.TabIndex = 4
        Me.txtAmount.Text = "0.00"
        '
        'txtResID
        '
        Me.txtResID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtResID.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResID.Location = New System.Drawing.Point(416, 10)
        Me.txtResID.Name = "txtResID"
        Me.txtResID.Size = New System.Drawing.Size(37, 33)
        Me.txtResID.TabIndex = 126
        Me.txtResID.Visible = False
        '
        'txtRes
        '
        Me.txtRes.Location = New System.Drawing.Point(161, 88)
        Me.txtRes.Name = "txtRes"
        Me.txtRes.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRes.Properties.Appearance.Options.UseFont = True
        Me.txtRes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtRes.Size = New System.Drawing.Size(256, 32)
        Me.txtRes.TabIndex = 2
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton1.Location = New System.Drawing.Point(161, 344)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(120, 54)
        Me.SimpleButton1.TabIndex = 7
        Me.SimpleButton1.Text = "Save and Print"
        '
        'txtDate
        '
        Me.txtDate.CustomFormat = "MM/dd/yyyy"
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDate.Location = New System.Drawing.Point(161, 309)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(256, 29)
        Me.txtDate.TabIndex = 6
        Me.txtDate.Value = New Date(2018, 10, 27, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(106, 313)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 23)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(77, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 23)
        Me.Label3.TabIndex = 124
        Me.Label3.Text = "CTC No."
        '
        'txtCTC
        '
        Me.txtCTC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCTC.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCTC.Location = New System.Drawing.Point(161, 135)
        Me.txtCTC.Name = "txtCTC"
        Me.txtCTC.Size = New System.Drawing.Size(256, 33)
        Me.txtCTC.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 23)
        Me.Label2.TabIndex = 123
        Me.Label2.Text = "Resident Name"
        '
        'txtNo
        '
        Me.txtNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNo.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNo.Location = New System.Drawing.Point(161, 39)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(256, 33)
        Me.txtNo.TabIndex = 1
        '
        'asd
        '
        Me.asd.AutoSize = True
        Me.asd.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.asd.Location = New System.Drawing.Point(32, 39)
        Me.asd.Name = "asd"
        Me.asd.Size = New System.Drawing.Size(123, 23)
        Me.asd.TabIndex = 122
        Me.asd.Text = "Residency No"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 269)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 23)
        Me.Label1.TabIndex = 134
        Me.Label1.Text = "O.R. No."
        '
        'txtORno
        '
        Me.txtORno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtORno.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtORno.Location = New System.Drawing.Point(161, 264)
        Me.txtORno.Name = "txtORno"
        Me.txtORno.Size = New System.Drawing.Size(256, 33)
        Me.txtORno.TabIndex = 5
        '
        'txtCTCDate
        '
        Me.txtCTCDate.CustomFormat = "MM/dd/yyyy"
        Me.txtCTCDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCTCDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtCTCDate.Location = New System.Drawing.Point(161, 179)
        Me.txtCTCDate.Name = "txtCTCDate"
        Me.txtCTCDate.Size = New System.Drawing.Size(256, 29)
        Me.txtCTCDate.TabIndex = 145
        Me.txtCTCDate.Value = New Date(2018, 10, 27, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 23)
        Me.Label7.TabIndex = 146
        Me.Label7.Text = "CTC Date Issued"
        '
        'Residency
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 415)
        Me.Controls.Add(Me.txtCTCDate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtORno)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPurpose)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtResID)
        Me.Controls.Add(Me.txtRes)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCTC)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNo)
        Me.Controls.Add(Me.asd)
        Me.Name = "Residency"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Residency"
        CType(Me.txtRes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents txtPurpose As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents txtResID As TextBox
    Public WithEvents txtRes As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCTC As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNo As TextBox
    Friend WithEvents asd As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtORno As TextBox
    Friend WithEvents txtCTCDate As DateTimePicker
    Friend WithEvents Label7 As Label
End Class
