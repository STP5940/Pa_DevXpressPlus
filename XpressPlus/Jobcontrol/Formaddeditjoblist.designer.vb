<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formaddeditjoblist
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DemoCode = New DevComponents.DotNetBar.LabelX()
        Me.Tbshadename = New Normtextbox.Normtextbox()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.Btfindshade = New DevComponents.DotNetBar.ButtonX()
        Me.Tbshadeid = New Normtextbox.Normtextbox()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.Tbord = New Normtextbox.Normtextbox()
        Me.TbwgtKg = New Dectextbox.Dectextbox()
        Me.Tbqtyroll = New Inttextbox.Inttextbox()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.Tbfinwgt = New Normtextbox.Normtextbox()
        Me.LabelX16 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX()
        Me.Tbdozen = New Normtextbox.Normtextbox()
        Me.Tbfinwidth = New Normtextbox.Normtextbox()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.Tbtype = New Normtextbox.Normtextbox()
        Me.Btfindfabtypeid = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.Tbclothid = New Normtextbox.Normtextbox()
        Me.Tbclothno = New Normtextbox.Normtextbox()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.Btcancel = New DevComponents.DotNetBar.ButtonX()
        Me.Btok = New DevComponents.DotNetBar.ButtonX()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tbcancel = New System.Windows.Forms.ToolStripTextBox()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.Tbaddedit = New DevComponents.DotNetBar.Controls.TextBoxX()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
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
        Me.TabControl1.Size = New System.Drawing.Size(539, 326)
        Me.TabControl1.TabIndex = 9
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.TabItem1)
        Me.TabControl1.Text = "TabControl1"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.Panel4)
        Me.TabControlPanel1.Controls.Add(Me.ToolStrip1)
        Me.TabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(539, 300)
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
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Tbaddedit)
        Me.Panel4.Controls.Add(Me.DemoCode)
        Me.Panel4.Controls.Add(Me.Tbshadename)
        Me.Panel4.Controls.Add(Me.LabelX3)
        Me.Panel4.Controls.Add(Me.Btfindshade)
        Me.Panel4.Controls.Add(Me.Tbshadeid)
        Me.Panel4.Controls.Add(Me.LabelX2)
        Me.Panel4.Controls.Add(Me.Tbord)
        Me.Panel4.Controls.Add(Me.TbwgtKg)
        Me.Panel4.Controls.Add(Me.Tbqtyroll)
        Me.Panel4.Controls.Add(Me.LabelX1)
        Me.Panel4.Controls.Add(Me.Tbfinwgt)
        Me.Panel4.Controls.Add(Me.LabelX16)
        Me.Panel4.Controls.Add(Me.LabelX10)
        Me.Panel4.Controls.Add(Me.LabelX15)
        Me.Panel4.Controls.Add(Me.Tbdozen)
        Me.Panel4.Controls.Add(Me.Tbfinwidth)
        Me.Panel4.Controls.Add(Me.LabelX8)
        Me.Panel4.Controls.Add(Me.Tbtype)
        Me.Panel4.Controls.Add(Me.Btfindfabtypeid)
        Me.Panel4.Controls.Add(Me.LabelX9)
        Me.Panel4.Controls.Add(Me.Tbclothid)
        Me.Panel4.Controls.Add(Me.Tbclothno)
        Me.Panel4.Controls.Add(Me.LabelX14)
        Me.Panel4.Controls.Add(Me.Btcancel)
        Me.Panel4.Controls.Add(Me.Btok)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(1, 26)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(537, 273)
        Me.Panel4.TabIndex = 90
        '
        'DemoCode
        '
        Me.DemoCode.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.DemoCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DemoCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DemoCode.ForeColor = System.Drawing.Color.Gray
        Me.DemoCode.Location = New System.Drawing.Point(442, 41)
        Me.DemoCode.Name = "DemoCode"
        Me.DemoCode.SingleLineColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DemoCode.Size = New System.Drawing.Size(67, 23)
        Me.DemoCode.SymbolColor = System.Drawing.Color.Black
        Me.DemoCode.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.DemoCode.TabIndex = 179
        Me.DemoCode.Text = "สีตัวอย่าง"
        Me.DemoCode.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'Tbshadename
        '
        Me.Tbshadename.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Tbshadename.Enabled = False
        Me.Tbshadename.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbshadename.Location = New System.Drawing.Point(292, 41)
        Me.Tbshadename.MaxLength = 120
        Me.Tbshadename.Name = "Tbshadename"
        Me.Tbshadename.Size = New System.Drawing.Size(144, 24)
        Me.Tbshadename.TabIndex = 178
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(18, 42)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(58, 23)
        Me.LabelX3.TabIndex = 177
        Me.LabelX3.Text = "Shade"
        '
        'Btfindshade
        '
        Me.Btfindshade.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btfindshade.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Btfindshade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Btfindshade.Image = Global.XpressPlus.My.Resources.Resources.Find16
        Me.Btfindshade.Location = New System.Drawing.Point(236, 41)
        Me.Btfindshade.Name = "Btfindshade"
        Me.Btfindshade.Size = New System.Drawing.Size(36, 24)
        Me.Btfindshade.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.Btfindshade.TabIndex = 176
        Me.Btfindshade.Tooltip = "ค้นหา Shade"
        '
        'Tbshadeid
        '
        Me.Tbshadeid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Tbshadeid.Enabled = False
        Me.Tbshadeid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbshadeid.Location = New System.Drawing.Point(139, 41)
        Me.Tbshadeid.MaxLength = 120
        Me.Tbshadeid.Name = "Tbshadeid"
        Me.Tbshadeid.Size = New System.Drawing.Size(91, 24)
        Me.Tbshadeid.TabIndex = 175
        Me.Tbshadeid.Tag = "เลือก Shade"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.LabelX2.Location = New System.Drawing.Point(410, 204)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(29, 23)
        Me.LabelX2.TabIndex = 174
        Me.LabelX2.Text = "Ord"
        Me.LabelX2.Visible = False
        '
        'Tbord
        '
        Me.Tbord.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Tbord.Location = New System.Drawing.Point(445, 205)
        Me.Tbord.MaxLength = 120
        Me.Tbord.Name = "Tbord"
        Me.Tbord.Size = New System.Drawing.Size(64, 24)
        Me.Tbord.TabIndex = 173
        Me.Tbord.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Tbord.Visible = False
        '
        'TbwgtKg
        '
        Me.TbwgtKg.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TbwgtKg.Location = New System.Drawing.Point(379, 137)
        Me.TbwgtKg.MaxLength = 12
        Me.TbwgtKg.Name = "TbwgtKg"
        Me.TbwgtKg.Size = New System.Drawing.Size(130, 24)
        Me.TbwgtKg.TabIndex = 172
        Me.TbwgtKg.Tag = "ใส่จำนวนน้ำหนัก"
        Me.TbwgtKg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Tbqtyroll
        '
        Me.Tbqtyroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Tbqtyroll.Location = New System.Drawing.Point(139, 137)
        Me.Tbqtyroll.MaxLength = 10
        Me.Tbqtyroll.Name = "Tbqtyroll"
        Me.Tbqtyroll.Size = New System.Drawing.Size(133, 24)
        Me.Tbqtyroll.TabIndex = 171
        Me.Tbqtyroll.Tag = "ใส่จำนวนพับ"
        Me.Tbqtyroll.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.LabelX1.Location = New System.Drawing.Point(292, 170)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(55, 23)
        Me.LabelX1.TabIndex = 170
        Me.LabelX1.Text = "Dozen"
        '
        'Tbfinwgt
        '
        Me.Tbfinwgt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Tbfinwgt.Location = New System.Drawing.Point(139, 170)
        Me.Tbfinwgt.MaxLength = 50
        Me.Tbfinwgt.Name = "Tbfinwgt"
        Me.Tbfinwgt.Size = New System.Drawing.Size(133, 24)
        Me.Tbfinwgt.TabIndex = 169
        Me.Tbfinwgt.Tag = "ใส่ Weigth"
        Me.Tbfinwgt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelX16
        '
        Me.LabelX16.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.LabelX16.Location = New System.Drawing.Point(18, 170)
        Me.LabelX16.Name = "LabelX16"
        Me.LabelX16.Size = New System.Drawing.Size(123, 23)
        Me.LabelX16.TabIndex = 168
        Me.LabelX16.Text = "Finished Weigth"
        '
        'LabelX10
        '
        Me.LabelX10.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.LabelX10.Location = New System.Drawing.Point(18, 140)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(107, 23)
        Me.LabelX10.TabIndex = 163
        Me.LabelX10.Text = "จำนวนพับ (Roll)"
        '
        'LabelX15
        '
        Me.LabelX15.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.LabelX15.Location = New System.Drawing.Point(292, 141)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(86, 23)
        Me.LabelX15.TabIndex = 160
        Me.LabelX15.Text = "น้ำหนัก (KG)"
        '
        'Tbdozen
        '
        Me.Tbdozen.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Tbdozen.Location = New System.Drawing.Point(379, 170)
        Me.Tbdozen.MaxLength = 120
        Me.Tbdozen.Name = "Tbdozen"
        Me.Tbdozen.Size = New System.Drawing.Size(130, 24)
        Me.Tbdozen.TabIndex = 158
        Me.Tbdozen.Tag = "ใส่จำนวนโหล"
        Me.Tbdozen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Tbfinwidth
        '
        Me.Tbfinwidth.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Tbfinwidth.Enabled = False
        Me.Tbfinwidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Tbfinwidth.Location = New System.Drawing.Point(139, 105)
        Me.Tbfinwidth.MaxLength = 120
        Me.Tbfinwidth.Name = "Tbfinwidth"
        Me.Tbfinwidth.Size = New System.Drawing.Size(133, 24)
        Me.Tbfinwidth.TabIndex = 154
        Me.Tbfinwidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.LabelX8.Location = New System.Drawing.Point(292, 106)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(71, 23)
        Me.LabelX8.TabIndex = 153
        Me.LabelX8.Text = "ประเภทผ้า"
        '
        'Tbtype
        '
        Me.Tbtype.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Tbtype.Enabled = False
        Me.Tbtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Tbtype.Location = New System.Drawing.Point(379, 105)
        Me.Tbtype.MaxLength = 120
        Me.Tbtype.Name = "Tbtype"
        Me.Tbtype.Size = New System.Drawing.Size(130, 24)
        Me.Tbtype.TabIndex = 152
        '
        'Btfindfabtypeid
        '
        Me.Btfindfabtypeid.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btfindfabtypeid.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Btfindfabtypeid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Btfindfabtypeid.Image = Global.XpressPlus.My.Resources.Resources.Find16
        Me.Btfindfabtypeid.Location = New System.Drawing.Point(236, 74)
        Me.Btfindfabtypeid.Name = "Btfindfabtypeid"
        Me.Btfindfabtypeid.Size = New System.Drawing.Size(36, 24)
        Me.Btfindfabtypeid.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.Btfindfabtypeid.TabIndex = 151
        Me.Btfindfabtypeid.Tooltip = "ค้นหา เบอร์ผ้า"
        '
        'LabelX9
        '
        Me.LabelX9.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.LabelX9.Location = New System.Drawing.Point(18, 106)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(115, 23)
        Me.LabelX9.TabIndex = 150
        Me.LabelX9.Text = "Finished Width"
        '
        'Tbclothid
        '
        Me.Tbclothid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Tbclothid.Enabled = False
        Me.Tbclothid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Tbclothid.Location = New System.Drawing.Point(139, 74)
        Me.Tbclothid.MaxLength = 200
        Me.Tbclothid.Name = "Tbclothid"
        Me.Tbclothid.Size = New System.Drawing.Size(91, 24)
        Me.Tbclothid.TabIndex = 149
        Me.Tbclothid.Tag = "เลือกเบอร์ผ้า"
        '
        'Tbclothno
        '
        Me.Tbclothno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Tbclothno.Enabled = False
        Me.Tbclothno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Tbclothno.Location = New System.Drawing.Point(292, 74)
        Me.Tbclothno.MaxLength = 120
        Me.Tbclothno.Name = "Tbclothno"
        Me.Tbclothno.Size = New System.Drawing.Size(217, 24)
        Me.Tbclothno.TabIndex = 148
        '
        'LabelX14
        '
        Me.LabelX14.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.LabelX14.Location = New System.Drawing.Point(18, 75)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(63, 23)
        Me.LabelX14.TabIndex = 147
        Me.LabelX14.Text = "เบอร์ผ้า"
        '
        'Btcancel
        '
        Me.Btcancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btcancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Btcancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Btcancel.Location = New System.Drawing.Point(292, 221)
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
        Me.Btok.Location = New System.Drawing.Point(157, 221)
        Me.Btok.Name = "Btok"
        Me.Btok.Size = New System.Drawing.Size(73, 34)
        Me.Btok.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.Btok.TabIndex = 0
        Me.Btok.Text = "ตกลง"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tbcancel})
        Me.ToolStrip1.Location = New System.Drawing.Point(1, 1)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(537, 25)
        Me.ToolStrip1.TabIndex = 28
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Tbcancel
        '
        Me.Tbcancel.Name = "Tbcancel"
        Me.Tbcancel.Size = New System.Drawing.Size(25, 25)
        Me.Tbcancel.Visible = False
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel1
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "รายการลูกค้า"
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
        Me.Tbaddedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Tbaddedit.ForeColor = System.Drawing.Color.Black
        Me.Tbaddedit.Location = New System.Drawing.Point(466, 8)
        Me.Tbaddedit.Name = "Tbaddedit"
        Me.Tbaddedit.PreventEnterBeep = True
        Me.Tbaddedit.Size = New System.Drawing.Size(43, 22)
        Me.Tbaddedit.TabIndex = 130
        Me.Tbaddedit.Text = "เพิ่ม"
        Me.Tbaddedit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Formaddeditjoblist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 326)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Formaddeditjoblist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formaddeditjoblist"
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.TabControlPanel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Tbcancel As ToolStripTextBox
    Friend WithEvents Btcancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Btok As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents Panel4 As Panel
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Tbdozen As Normtextbox.Normtextbox
    Friend WithEvents Tbfinwidth As Normtextbox.Normtextbox
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Tbtype As Normtextbox.Normtextbox
    Friend WithEvents Btfindfabtypeid As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Tbclothid As Normtextbox.Normtextbox
    Friend WithEvents Tbclothno As Normtextbox.Normtextbox
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Tbfinwgt As Normtextbox.Normtextbox
    Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Tbqtyroll As Inttextbox.Inttextbox
    Friend WithEvents TbwgtKg As Dectextbox.Dectextbox
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Tbord As Normtextbox.Normtextbox
    Friend WithEvents DemoCode As DevComponents.DotNetBar.LabelX
    Friend WithEvents Tbshadename As Normtextbox.Normtextbox
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Btfindshade As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Tbshadeid As Normtextbox.Normtextbox
    Friend WithEvents Tbaddedit As DevComponents.DotNetBar.Controls.TextBoxX
End Class
