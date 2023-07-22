<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adedReligion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adedReligion))
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtReligion = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtID = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txtReligion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton1.Location = New System.Drawing.Point(82, 79)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(82, 34)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "SAVE"
        '
        'txtReligion
        '
        Me.txtReligion.Location = New System.Drawing.Point(22, 12)
        Me.txtReligion.Name = "txtReligion"
        Me.txtReligion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReligion.Properties.Appearance.Options.UseFont = True
        Me.txtReligion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReligion.Size = New System.Drawing.Size(306, 36)
        Me.txtReligion.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(126, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "RELIGION"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton2.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton2.Location = New System.Drawing.Point(179, 79)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(82, 34)
        Me.SimpleButton2.TabIndex = 3
        Me.SimpleButton2.Text = "CANCEL"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(313, 131)
        Me.txtID.Name = "txtID"
        Me.txtID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Properties.Appearance.Options.UseFont = True
        Me.txtID.Size = New System.Drawing.Size(24, 36)
        Me.txtID.TabIndex = 4
        Me.txtID.Visible = False
        '
        'adedReligion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 123)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtReligion)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Name = "adedReligion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adedReligion"
        CType(Me.txtReligion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtReligion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtID As DevExpress.XtraEditors.TextEdit
End Class
