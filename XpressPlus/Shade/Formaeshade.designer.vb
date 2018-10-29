<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formaeshade
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.Tbcolorsample = New System.Windows.Forms.Label()
        Me.Tbfinddhid = New DevComponents.DotNetBar.ButtonX()
        Me.Normtextbox4 = New Normtextbox.Normtextbox()
        Me.Normtextbox3 = New Normtextbox.Normtextbox()
        Me.Normtextbox2 = New Normtextbox.Normtextbox()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.Cbactive = New System.Windows.Forms.CheckBox()
        Me.Tbmdesc = New Normtextbox.Normtextbox()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.Tbaddedit = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Tbcancel = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.Tbmid = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Btcancel = New DevComponents.DotNetBar.ButtonX()
        Me.Btok = New DevComponents.DotNetBar.ButtonX()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControl1.CanReorderTabs = True
        Me.TabControl1.Controls.Add(Me.TabControlPanel1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.ForeColor = System.Drawing.Color.Black
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.SelectedTabIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(384, 211)
        Me.TabControl1.TabIndex = 8
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.TabItem1)
        Me.TabControl1.Text = "TabControl1"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.Tbcolorsample)
        Me.TabControlPanel1.Controls.Add(Me.Tbfinddhid)
        Me.TabControlPanel1.Controls.Add(Me.Normtextbox4)
        Me.TabControlPanel1.Controls.Add(Me.Normtextbox3)
        Me.TabControlPanel1.Controls.Add(Me.Normtextbox2)
        Me.TabControlPanel1.Controls.Add(Me.LabelX7)
        Me.TabControlPanel1.Controls.Add(Me.LabelX4)
        Me.TabControlPanel1.Controls.Add(Me.LabelX2)
        Me.TabControlPanel1.Controls.Add(Me.LabelX1)
        Me.TabControlPanel1.Controls.Add(Me.LabelX6)
        Me.TabControlPanel1.Controls.Add(Me.Cbactive)
        Me.TabControlPanel1.Controls.Add(Me.Tbmdesc)
        Me.TabControlPanel1.Controls.Add(Me.LabelX5)
        Me.TabControlPanel1.Controls.Add(Me.Tbaddedit)
        Me.TabControlPanel1.Controls.Add(Me.Tbcancel)
        Me.TabControlPanel1.Controls.Add(Me.LabelX3)
        Me.TabControlPanel1.Controls.Add(Me.Tbmid)
        Me.TabControlPanel1.Controls.Add(Me.Btcancel)
        Me.TabControlPanel1.Controls.Add(Me.Btok)
        Me.TabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(384, 185)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 1
        Me.TabControlPanel1.TabItem = Me.TabItem1
        '
        'Tbcolorsample
        '
        Me.Tbcolorsample.BackColor = System.Drawing.Color.White
        Me.Tbcolorsample.Location = New System.Drawing.Point(78, 64)
        Me.Tbcolorsample.Name = "Tbcolorsample"
        Me.Tbcolorsample.Size = New System.Drawing.Size(123, 23)
        Me.Tbcolorsample.TabIndex = 84
        '
        'Tbfinddhid
        '
        Me.Tbfinddhid.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Tbfinddhid.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Tbfinddhid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Tbfinddhid.Image = Global.XpressPlus.My.Resources.Resources.Find16
        Me.Tbfinddhid.Location = New System.Drawing.Point(207, 63)
        Me.Tbfinddhid.Name = "Tbfinddhid"
        Me.Tbfinddhid.Size = New System.Drawing.Size(36, 24)
        Me.Tbfinddhid.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.Tbfinddhid.TabIndex = 83
        '
        'Normtextbox4
        '
        Me.Normtextbox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Normtextbox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Normtextbox4.Location = New System.Drawing.Point(353, 93)
        Me.Normtextbox4.MaxLength = 150
        Me.Normtextbox4.Name = "Normtextbox4"
        Me.Normtextbox4.Size = New System.Drawing.Size(28, 24)
        Me.Normtextbox4.TabIndex = 55
        Me.Normtextbox4.Visible = False
        '
        'Normtextbox3
        '
        Me.Normtextbox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Normtextbox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Normtextbox3.Location = New System.Drawing.Point(275, 92)
        Me.Normtextbox3.MaxLength = 150
        Me.Normtextbox3.Name = "Normtextbox3"
        Me.Normtextbox3.Size = New System.Drawing.Size(28, 24)
        Me.Normtextbox3.TabIndex = 54
        Me.Normtextbox3.Visible = False
        '
        'Normtextbox2
        '
        Me.Normtextbox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Normtextbox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Normtextbox2.Location = New System.Drawing.Point(188, 92)
        Me.Normtextbox2.MaxLength = 150
        Me.Normtextbox2.Name = "Normtextbox2"
        Me.Normtextbox2.Size = New System.Drawing.Size(28, 24)
        Me.Normtextbox2.TabIndex = 53
        Me.Normtextbox2.Visible = False
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX7.Location = New System.Drawing.Point(309, 93)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(55, 23)
        Me.LabelX7.TabIndex = 52
        Me.LabelX7.Text = "Blue"
        Me.LabelX7.Visible = False
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(222, 92)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(64, 23)
        Me.LabelX4.TabIndex = 51
        Me.LabelX4.Text = "Green"
        Me.LabelX4.Visible = False
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(148, 91)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(38, 23)
        Me.LabelX2.TabIndex = 50
        Me.LabelX2.Text = "Red"
        Me.LabelX2.Visible = False
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(12, 64)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(64, 23)
        Me.LabelX1.TabIndex = 48
        Me.LabelX1.Text = "สีตัวอย่าง"
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX6.Location = New System.Drawing.Point(12, 93)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(60, 23)
        Me.LabelX6.TabIndex = 47
        Me.LabelX6.Text = "สถานะ"
        '
        'Cbactive
        '
        Me.Cbactive.AutoSize = True
        Me.Cbactive.BackColor = System.Drawing.Color.Transparent
        Me.Cbactive.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Cbactive.Location = New System.Drawing.Point(78, 95)
        Me.Cbactive.Name = "Cbactive"
        Me.Cbactive.Size = New System.Drawing.Size(66, 22)
        Me.Cbactive.TabIndex = 46
        Me.Cbactive.Text = "Active"
        Me.Cbactive.UseVisualStyleBackColor = False
        '
        'Tbmdesc
        '
        Me.Tbmdesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Tbmdesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Tbmdesc.Location = New System.Drawing.Point(78, 34)
        Me.Tbmdesc.MaxLength = 150
        Me.Tbmdesc.Name = "Tbmdesc"
        Me.Tbmdesc.Size = New System.Drawing.Size(219, 24)
        Me.Tbmdesc.TabIndex = 37
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(12, 31)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(64, 23)
        Me.LabelX5.TabIndex = 33
        Me.LabelX5.Text = "ชื่อ"
        '
        'Tbaddedit
        '
        Me.Tbaddedit.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Tbaddedit.Border.Class = "TextBoxBorder"
        Me.Tbaddedit.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tbaddedit.DisabledBackColor = System.Drawing.Color.White
        Me.Tbaddedit.Enabled = False
        Me.Tbaddedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Tbaddedit.ForeColor = System.Drawing.Color.Black
        Me.Tbaddedit.Location = New System.Drawing.Point(348, 0)
        Me.Tbaddedit.Name = "Tbaddedit"
        Me.Tbaddedit.PreventEnterBeep = True
        Me.Tbaddedit.Size = New System.Drawing.Size(33, 22)
        Me.Tbaddedit.TabIndex = 26
        '
        'Tbcancel
        '
        Me.Tbcancel.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Tbcancel.Border.Class = "TextBoxBorder"
        Me.Tbcancel.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tbcancel.DisabledBackColor = System.Drawing.Color.White
        Me.Tbcancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Tbcancel.ForeColor = System.Drawing.Color.Black
        Me.Tbcancel.Location = New System.Drawing.Point(348, 28)
        Me.Tbcancel.Name = "Tbcancel"
        Me.Tbcancel.PreventEnterBeep = True
        Me.Tbcancel.Size = New System.Drawing.Size(33, 22)
        Me.Tbcancel.TabIndex = 25
        Me.Tbcancel.Visible = False
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(12, 4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(62, 23)
        Me.LabelX3.TabIndex = 21
        Me.LabelX3.Text = "รหัส"
        '
        'Tbmid
        '
        Me.Tbmid.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Tbmid.Border.Class = "TextBoxBorder"
        Me.Tbmid.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tbmid.DisabledBackColor = System.Drawing.Color.White
        Me.Tbmid.Enabled = False
        Me.Tbmid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Tbmid.ForeColor = System.Drawing.Color.Black
        Me.Tbmid.Location = New System.Drawing.Point(78, 4)
        Me.Tbmid.Name = "Tbmid"
        Me.Tbmid.PreventEnterBeep = True
        Me.Tbmid.Size = New System.Drawing.Size(123, 24)
        Me.Tbmid.TabIndex = 2
        Me.Tbmid.Text = "NEW"
        '
        'Btcancel
        '
        Me.Btcancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btcancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Btcancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Btcancel.Location = New System.Drawing.Point(245, 131)
        Me.Btcancel.Name = "Btcancel"
        Me.Btcancel.Size = New System.Drawing.Size(73, 34)
        Me.Btcancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.Btcancel.TabIndex = 1
        Me.Btcancel.Text = "ยกเลิก"
        '
        'Btok
        '
        Me.Btok.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btok.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Btok.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Btok.Location = New System.Drawing.Point(78, 131)
        Me.Btok.Name = "Btok"
        Me.Btok.Size = New System.Drawing.Size(73, 34)
        Me.Btok.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.Btok.TabIndex = 0
        Me.Btok.Text = "ตกลง"
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel1
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "Shade"
        '
        'Formaeshade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 211)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Formaeshade"
        Me.Text = "เพิ่ม แก้ไข Shade"
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.TabControlPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents Tbmdesc As Normtextbox.Normtextbox
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Tbaddedit As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Tbcancel As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Tbmid As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Btcancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Btok As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Cbactive As CheckBox
    Friend WithEvents Normtextbox4 As Normtextbox.Normtextbox
    Friend WithEvents Normtextbox3 As Normtextbox.Normtextbox
    Friend WithEvents Normtextbox2 As Normtextbox.Normtextbox
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Tbfinddhid As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Tbcolorsample As Label
End Class
