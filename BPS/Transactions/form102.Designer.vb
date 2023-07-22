<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form102
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form102))
        Me.asd = New System.Windows.Forms.Label()
        Me.txtCaseNo = New DevExpress.XtraEditors.ButtonEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtChosen = New DevExpress.XtraEditors.ButtonEdit()
        CType(Me.txtCaseNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChosen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'asd
        '
        Me.asd.AutoSize = True
        Me.asd.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.asd.Location = New System.Drawing.Point(55, 55)
        Me.asd.Name = "asd"
        Me.asd.Size = New System.Drawing.Size(144, 23)
        Me.asd.TabIndex = 90
        Me.asd.Text = "Chosen Pangkat"
        '
        'txtCaseNo
        '
        Me.txtCaseNo.Location = New System.Drawing.Point(205, 12)
        Me.txtCaseNo.Name = "txtCaseNo"
        Me.txtCaseNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaseNo.Properties.Appearance.Options.UseFont = True
        Me.txtCaseNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtCaseNo.Size = New System.Drawing.Size(207, 32)
        Me.txtCaseNo.TabIndex = 85
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton1.Location = New System.Drawing.Point(219, 94)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(120, 54)
        Me.SimpleButton1.TabIndex = 87
        Me.SimpleButton1.Text = "Save and Print"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(121, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 23)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Case No"
        '
        'txtChosen
        '
        Me.txtChosen.Location = New System.Drawing.Point(205, 50)
        Me.txtChosen.Name = "txtChosen"
        Me.txtChosen.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChosen.Properties.Appearance.Options.UseFont = True
        Me.txtChosen.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtChosen.Properties.ReadOnly = True
        Me.txtChosen.Size = New System.Drawing.Size(289, 32)
        Me.txtChosen.TabIndex = 91
        '
        'form102
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 155)
        Me.Controls.Add(Me.txtChosen)
        Me.Controls.Add(Me.asd)
        Me.Controls.Add(Me.txtCaseNo)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "form102"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "form102"
        CType(Me.txtCaseNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChosen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents asd As Label
    Public WithEvents txtCaseNo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As Label
    Public WithEvents txtChosen As DevExpress.XtraEditors.ButtonEdit
End Class
