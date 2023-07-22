<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form100
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form100))
        Me.txtofficer = New DevExpress.XtraEditors.ButtonEdit()
        Me.asd = New System.Windows.Forms.Label()
        Me.txtCaseNo = New DevExpress.XtraEditors.ButtonEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbInPerson = New System.Windows.Forms.RadioButton()
        Me.rbRefuse = New System.Windows.Forms.RadioButton()
        Me.rbDwell = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbOffice = New System.Windows.Forms.RadioButton()
        Me.txtServed = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDwell = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtOffice = New DevExpress.XtraEditors.ButtonEdit()
        CType(Me.txtofficer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCaseNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDwell.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOffice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtofficer
        '
        Me.txtofficer.Location = New System.Drawing.Point(116, 50)
        Me.txtofficer.Name = "txtofficer"
        Me.txtofficer.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtofficer.Properties.Appearance.Options.UseFont = True
        Me.txtofficer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtofficer.Properties.ReadOnly = True
        Me.txtofficer.Size = New System.Drawing.Size(319, 32)
        Me.txtofficer.TabIndex = 96
        '
        'asd
        '
        Me.asd.AutoSize = True
        Me.asd.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.asd.Location = New System.Drawing.Point(45, 55)
        Me.asd.Name = "asd"
        Me.asd.Size = New System.Drawing.Size(65, 23)
        Me.asd.TabIndex = 95
        Me.asd.Text = "Officer"
        '
        'txtCaseNo
        '
        Me.txtCaseNo.Location = New System.Drawing.Point(116, 12)
        Me.txtCaseNo.Name = "txtCaseNo"
        Me.txtCaseNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaseNo.Properties.Appearance.Options.UseFont = True
        Me.txtCaseNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtCaseNo.Size = New System.Drawing.Size(319, 32)
        Me.txtCaseNo.TabIndex = 92
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton1.Location = New System.Drawing.Point(205, 362)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(120, 54)
        Me.SimpleButton1.TabIndex = 93
        Me.SimpleButton1.Text = "Save and Print"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 23)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "Case No"
        '
        'rbInPerson
        '
        Me.rbInPerson.AutoSize = True
        Me.rbInPerson.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.rbInPerson.Location = New System.Drawing.Point(116, 163)
        Me.rbInPerson.Name = "rbInPerson"
        Me.rbInPerson.Size = New System.Drawing.Size(134, 23)
        Me.rbInPerson.TabIndex = 97
        Me.rbInPerson.TabStop = True
        Me.rbInPerson.Text = "Handed in person"
        Me.rbInPerson.UseVisualStyleBackColor = True
        '
        'rbRefuse
        '
        Me.rbRefuse.AutoSize = True
        Me.rbRefuse.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.rbRefuse.Location = New System.Drawing.Point(116, 195)
        Me.rbRefuse.Name = "rbRefuse"
        Me.rbRefuse.Size = New System.Drawing.Size(279, 23)
        Me.rbRefuse.TabIndex = 98
        Me.rbRefuse.TabStop = True
        Me.rbRefuse.Text = "Handed in person but refused to receive it"
        Me.rbRefuse.UseVisualStyleBackColor = True
        '
        'rbDwell
        '
        Me.rbDwell.AutoSize = True
        Me.rbDwell.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.rbDwell.Location = New System.Drawing.Point(116, 224)
        Me.rbDwell.Name = "rbDwell"
        Me.rbDwell.Size = New System.Drawing.Size(303, 23)
        Me.rbDwell.TabIndex = 99
        Me.rbDwell.TabStop = True
        Me.rbDwell.Text = "Leaving said summon at his/their dwelling with"
        Me.rbDwell.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 257)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 23)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 325)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 23)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "Name"
        '
        'rbOffice
        '
        Me.rbOffice.AutoSize = True
        Me.rbOffice.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.rbOffice.Location = New System.Drawing.Point(116, 291)
        Me.rbOffice.Name = "rbOffice"
        Me.rbOffice.Size = New System.Drawing.Size(393, 23)
        Me.rbOffice.TabIndex = 102
        Me.rbOffice.TabStop = True
        Me.rbOffice.Text = "Leaving said summon at his/their office/place of business with"
        Me.rbOffice.UseVisualStyleBackColor = True
        '
        'txtServed
        '
        Me.txtServed.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtServed.Enabled = False
        Me.txtServed.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServed.Location = New System.Drawing.Point(61, 421)
        Me.txtServed.Name = "txtServed"
        Me.txtServed.Size = New System.Drawing.Size(26, 33)
        Me.txtServed.TabIndex = 105
        Me.txtServed.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(-1, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(518, 23)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "Please Choose the mode by which he/they was/were served."
        '
        'txtDate
        '
        Me.txtDate.CustomFormat = "MM/dd/yyyy"
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDate.Location = New System.Drawing.Point(180, 88)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(257, 29)
        Me.txtDate.TabIndex = 107
        Me.txtDate.Value = New Date(2018, 10, 27, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(61, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 23)
        Me.Label5.TabIndex = 108
        Me.Label5.Text = "Date Served"
        '
        'txtDwell
        '
        Me.txtDwell.Location = New System.Drawing.Point(116, 254)
        Me.txtDwell.Name = "txtDwell"
        Me.txtDwell.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDwell.Properties.Appearance.Options.UseFont = True
        Me.txtDwell.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtDwell.Size = New System.Drawing.Size(319, 32)
        Me.txtDwell.TabIndex = 109
        '
        'txtOffice
        '
        Me.txtOffice.Location = New System.Drawing.Point(116, 324)
        Me.txtOffice.Name = "txtOffice"
        Me.txtOffice.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOffice.Properties.Appearance.Options.UseFont = True
        Me.txtOffice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtOffice.Size = New System.Drawing.Size(319, 32)
        Me.txtOffice.TabIndex = 110
        '
        'form100
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 426)
        Me.Controls.Add(Me.txtOffice)
        Me.Controls.Add(Me.txtDwell)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtServed)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rbOffice)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rbDwell)
        Me.Controls.Add(Me.rbRefuse)
        Me.Controls.Add(Me.rbInPerson)
        Me.Controls.Add(Me.txtofficer)
        Me.Controls.Add(Me.asd)
        Me.Controls.Add(Me.txtCaseNo)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "form100"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "form100"
        CType(Me.txtofficer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCaseNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDwell.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOffice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents txtofficer As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents asd As Label
    Public WithEvents txtCaseNo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As Label
    Friend WithEvents rbInPerson As RadioButton
    Friend WithEvents rbRefuse As RadioButton
    Friend WithEvents rbDwell As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents rbOffice As RadioButton
    Friend WithEvents txtServed As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Public WithEvents txtDwell As DevExpress.XtraEditors.ButtonEdit
    Public WithEvents txtOffice As DevExpress.XtraEditors.ButtonEdit
End Class
