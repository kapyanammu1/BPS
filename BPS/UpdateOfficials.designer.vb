<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateOfficials
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
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.txtName = New DevExpress.XtraEditors.ButtonEdit()
        Me.lblPos = New System.Windows.Forms.Label()
        Me.txtResID = New System.Windows.Forms.TextBox()
        Me.txtOID = New System.Windows.Forms.TextBox()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Location = New System.Drawing.Point(81, 23)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(295, 180)
        Me.PictureEdit1.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(12, 222)
        Me.txtName.Name = "txtName"
        Me.txtName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Properties.Appearance.Options.UseFont = True
        Me.txtName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtName.Size = New System.Drawing.Size(428, 32)
        Me.txtName.TabIndex = 3
        '
        'lblPos
        '
        Me.lblPos.AutoSize = True
        Me.lblPos.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPos.Location = New System.Drawing.Point(171, 257)
        Me.lblPos.Name = "lblPos"
        Me.lblPos.Size = New System.Drawing.Size(104, 19)
        Me.lblPos.TabIndex = 2
        Me.lblPos.Text = "Brgy. Captain"
        Me.lblPos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtResID
        '
        Me.txtResID.Location = New System.Drawing.Point(412, 71)
        Me.txtResID.Name = "txtResID"
        Me.txtResID.Size = New System.Drawing.Size(28, 21)
        Me.txtResID.TabIndex = 4
        Me.txtResID.Visible = False
        '
        'txtOID
        '
        Me.txtOID.Location = New System.Drawing.Point(412, 98)
        Me.txtOID.Name = "txtOID"
        Me.txtOID.Size = New System.Drawing.Size(28, 21)
        Me.txtOID.TabIndex = 5
        Me.txtOID.Visible = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(129, 304)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(86, 38)
        Me.SimpleButton1.TabIndex = 6
        Me.SimpleButton1.Text = "Save"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(230, 304)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(86, 38)
        Me.SimpleButton2.TabIndex = 7
        Me.SimpleButton2.Text = "Cancel"
        '
        'UpdateOfficials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 363)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.txtOID)
        Me.Controls.Add(Me.txtResID)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblPos)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Name = "UpdateOfficials"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UpdateOfficials"
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Public WithEvents txtName As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents lblPos As Label
    Friend WithEvents txtResID As TextBox
    Friend WithEvents txtOID As TextBox
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
End Class
