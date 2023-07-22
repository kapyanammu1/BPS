<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form99
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form99))
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.asd = New System.Windows.Forms.Label()
        Me.txtCaseNo = New DevExpress.XtraEditors.ButtonEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.txtCaseNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtName.Enabled = False
        Me.txtName.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(205, 50)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(321, 33)
        Me.txtName.TabIndex = 84
        '
        'asd
        '
        Me.asd.AutoSize = True
        Me.asd.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.asd.Location = New System.Drawing.Point(34, 55)
        Me.asd.Name = "asd"
        Me.asd.Size = New System.Drawing.Size(165, 23)
        Me.asd.TabIndex = 83
        Me.asd.Text = "Respondent Name"
        '
        'txtCaseNo
        '
        Me.txtCaseNo.Location = New System.Drawing.Point(205, 12)
        Me.txtCaseNo.Name = "txtCaseNo"
        Me.txtCaseNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaseNo.Properties.Appearance.Options.UseFont = True
        Me.txtCaseNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtCaseNo.Size = New System.Drawing.Size(207, 32)
        Me.txtCaseNo.TabIndex = 78
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton1.Location = New System.Drawing.Point(220, 134)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(120, 54)
        Me.SimpleButton1.TabIndex = 80
        Me.SimpleButton1.Text = "Save and Print"
        '
        'txtDate
        '
        Me.txtDate.CustomFormat = "MM/dd/yyyy hh:mm tt"
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDate.Location = New System.Drawing.Point(205, 89)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(207, 29)
        Me.txtDate.TabIndex = 79
        Me.txtDate.Value = New Date(2018, 10, 27, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(69, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 23)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Summon Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(121, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 23)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Case No"
        '
        'form99
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 200)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.asd)
        Me.Controls.Add(Me.txtCaseNo)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Name = "form99"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "form99"
        CType(Me.txtCaseNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtName As TextBox
    Friend WithEvents asd As Label
    Public WithEvents txtCaseNo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
End Class
