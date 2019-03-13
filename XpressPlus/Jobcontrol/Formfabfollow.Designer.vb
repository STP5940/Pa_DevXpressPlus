<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formfabfollow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formfabfollow))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Btmclose = New System.Windows.Forms.ToolStripButton()
        Me.Tstbdocpre = New System.Windows.Forms.ToolStripTextBox()
        Me.Tstbdocpreid = New System.Windows.Forms.ToolStripTextBox()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.miniToolStrip = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Dgvmas = New System.Windows.Forms.DataGridView()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStrip8 = New System.Windows.Forms.ToolStrip()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.Tbjobno = New Normtextbox.Normtextbox()
        Me.TabItem2 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.Ord = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jobno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Clothid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Clothno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ftype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dozen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dlvno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Knitcomno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qtyroll = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dyedcomno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Shadeid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Shadedesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qtyrollsum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Reid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lotno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kongno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qtyrollresum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Salewgtkgsum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dlvnosale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Wgtkgsale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dlvnocount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.miniToolStrip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabControlPanel2.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
        CType(Me.Dgvmas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabItem1
        '
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "รายละเอียด"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Btmclose, Me.Tstbdocpre, Me.Tstbdocpreid})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1008, 49)
        Me.ToolStrip1.TabIndex = 76
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Btmclose
        '
        Me.Btmclose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Btmclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btmclose.Image = CType(resources.GetObject("Btmclose.Image"), System.Drawing.Image)
        Me.Btmclose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btmclose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btmclose.Name = "Btmclose"
        Me.Btmclose.Size = New System.Drawing.Size(63, 46)
        Me.Btmclose.Text = "ปิดฟอร์ม"
        Me.Btmclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Tstbdocpre
        '
        Me.Tstbdocpre.Name = "Tstbdocpre"
        Me.Tstbdocpre.Size = New System.Drawing.Size(50, 49)
        Me.Tstbdocpre.Visible = False
        '
        'Tstbdocpreid
        '
        Me.Tstbdocpreid.Name = "Tstbdocpreid"
        Me.Tstbdocpreid.Size = New System.Drawing.Size(50, 49)
        Me.Tstbdocpreid.Visible = False
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer)))
        '
        'miniToolStrip
        '
        Me.miniToolStrip.AddNewItem = Nothing
        Me.miniToolStrip.AutoSize = False
        Me.miniToolStrip.CanOverflow = False
        Me.miniToolStrip.CountItem = Nothing
        Me.miniToolStrip.DeleteItem = Nothing
        Me.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.miniToolStrip.Enabled = False
        Me.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.miniToolStrip.Location = New System.Drawing.Point(206, 3)
        Me.miniToolStrip.MoveFirstItem = Nothing
        Me.miniToolStrip.MoveLastItem = Nothing
        Me.miniToolStrip.MoveNextItem = Nothing
        Me.miniToolStrip.MovePreviousItem = Nothing
        Me.miniToolStrip.Name = "miniToolStrip"
        Me.miniToolStrip.PositionItem = Nothing
        Me.miniToolStrip.Size = New System.Drawing.Size(1006, 25)
        Me.miniToolStrip.TabIndex = 163
        '
        'TabControl1
        '
        Me.TabControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControl1.CanReorderTabs = True
        Me.TabControl1.Controls.Add(Me.TabControlPanel2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TabControl1.ForeColor = System.Drawing.Color.Black
        Me.TabControl1.Location = New System.Drawing.Point(0, 49)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.SelectedTabIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1008, 680)
        Me.TabControl1.TabIndex = 77
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.TabItem2)
        Me.TabControl1.Text = "TabControl1"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.GroupPanel3)
        Me.TabControlPanel2.Controls.Add(Me.GroupPanel1)
        Me.TabControlPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(1008, 654)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 5
        Me.TabControlPanel2.TabItem = Me.TabItem2
        '
        'GroupPanel3
        '
        Me.GroupPanel3.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel3.CanvasColor = System.Drawing.Color.Transparent
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.GroupPanel3.Controls.Add(Me.Dgvmas)
        Me.GroupPanel3.Controls.Add(Me.ToolStrip3)
        Me.GroupPanel3.Controls.Add(Me.ToolStrip8)
        Me.GroupPanel3.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupPanel3.Location = New System.Drawing.Point(1, 80)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(1006, 573)
        '
        '
        '
        Me.GroupPanel3.Style.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel3.Style.BackColor2 = System.Drawing.Color.Transparent
        Me.GroupPanel3.Style.BackColorGradientAngle = 90
        Me.GroupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderBottomWidth = 1
        Me.GroupPanel3.Style.BorderColor = System.Drawing.Color.Black
        Me.GroupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderLeftWidth = 1
        Me.GroupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderRightWidth = 1
        Me.GroupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderTopWidth = 1
        Me.GroupPanel3.Style.CornerDiameter = 4
        Me.GroupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel3.TabIndex = 177
        Me.GroupPanel3.Text = "รายละเอียด job control"
        '
        'Dgvmas
        '
        Me.Dgvmas.AllowUserToAddRows = False
        Me.Dgvmas.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgvmas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgvmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvmas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ord, Me.Comid, Me.Jobno, Me.Clothid, Me.Clothno, Me.Ftype, Me.Dozen, Me.Dlvno, Me.Knitcomno, Me.Qtyroll, Me.Dyedcomno, Me.Shadeid, Me.Shadedesc, Me.Qtyrollsum, Me.Reid, Me.Lotno, Me.Kongno, Me.Qtyrollresum, Me.Salewgtkgsum, Me.Dlvnosale, Me.Wgtkgsale, Me.Dlvnocount})
        Me.Dgvmas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgvmas.Location = New System.Drawing.Point(0, 25)
        Me.Dgvmas.Name = "Dgvmas"
        Me.Dgvmas.ReadOnly = True
        Me.Dgvmas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgvmas.Size = New System.Drawing.Size(1000, 500)
        Me.Dgvmas.TabIndex = 129
        '
        'ToolStrip3
        '
        Me.ToolStrip3.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 525)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(1000, 25)
        Me.ToolStrip3.TabIndex = 128
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'ToolStrip8
        '
        Me.ToolStrip8.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip8.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip8.Name = "ToolStrip8"
        Me.ToolStrip8.Size = New System.Drawing.Size(1000, 25)
        Me.ToolStrip8.TabIndex = 126
        Me.ToolStrip8.Text = "ToolStrip8"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel1.CanvasColor = System.Drawing.Color.Transparent
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.GroupPanel1.Controls.Add(Me.Panel5)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(1, 1)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(1006, 79)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel1.Style.BackColor2 = System.Drawing.Color.Transparent
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColor = System.Drawing.Color.Black
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 175
        Me.GroupPanel1.Text = "ข้อมูล job controls"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.LabelX2)
        Me.Panel5.Controls.Add(Me.Tbjobno)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1000, 56)
        Me.Panel5.TabIndex = 89
        '
        'LabelX2
        '
        Me.LabelX2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(749, 14)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(81, 23)
        Me.LabelX2.TabIndex = 41
        Me.LabelX2.Text = "เลขที่เอกสาร"
        '
        'Tbjobno
        '
        Me.Tbjobno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tbjobno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Tbjobno.Enabled = False
        Me.Tbjobno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Tbjobno.Location = New System.Drawing.Point(834, 15)
        Me.Tbjobno.MaxLength = 150
        Me.Tbjobno.Name = "Tbjobno"
        Me.Tbjobno.Size = New System.Drawing.Size(149, 24)
        Me.Tbjobno.TabIndex = 40
        Me.Tbjobno.Text = "NEW"
        '
        'TabItem2
        '
        Me.TabItem2.AttachedControl = Me.TabControlPanel2
        Me.TabItem2.Name = "TabItem2"
        Me.TabItem2.Text = "รายการทั้งหมด"
        '
        'Ord
        '
        Me.Ord.DataPropertyName = "Ord"
        Me.Ord.HeaderText = "ลำดับที่"
        Me.Ord.Name = "Ord"
        Me.Ord.ReadOnly = True
        Me.Ord.Width = 75
        '
        'Comid
        '
        Me.Comid.DataPropertyName = "Comid"
        Me.Comid.HeaderText = "Comid"
        Me.Comid.Name = "Comid"
        Me.Comid.ReadOnly = True
        Me.Comid.Visible = False
        '
        'Jobno
        '
        Me.Jobno.DataPropertyName = "Jobno"
        Me.Jobno.HeaderText = "เลขที่ใบ Job Control"
        Me.Jobno.Name = "Jobno"
        Me.Jobno.ReadOnly = True
        Me.Jobno.Width = 200
        '
        'Clothid
        '
        Me.Clothid.DataPropertyName = "Clothid"
        Me.Clothid.HeaderText = "Clothid"
        Me.Clothid.Name = "Clothid"
        Me.Clothid.ReadOnly = True
        Me.Clothid.Visible = False
        '
        'Clothno
        '
        Me.Clothno.DataPropertyName = "Clothno"
        Me.Clothno.HeaderText = "Description"
        Me.Clothno.Name = "Clothno"
        Me.Clothno.ReadOnly = True
        Me.Clothno.Width = 180
        '
        'Ftype
        '
        Me.Ftype.DataPropertyName = "Ftype"
        Me.Ftype.HeaderText = "Fabric type"
        Me.Ftype.Name = "Ftype"
        Me.Ftype.ReadOnly = True
        Me.Ftype.Width = 150
        '
        'Dozen
        '
        Me.Dozen.DataPropertyName = "Dozen"
        Me.Dozen.HeaderText = "Dozen"
        Me.Dozen.Name = "Dozen"
        Me.Dozen.ReadOnly = True
        '
        'Dlvno
        '
        Me.Dlvno.DataPropertyName = "Dlvno"
        Me.Dlvno.HeaderText = "เลขที่ใบส่งด้าย"
        Me.Dlvno.Name = "Dlvno"
        Me.Dlvno.ReadOnly = True
        Me.Dlvno.Width = 200
        '
        'Knitcomno
        '
        Me.Knitcomno.DataPropertyName = "Knitcomno"
        Me.Knitcomno.HeaderText = "เลขที่ใบสั่งทอ"
        Me.Knitcomno.Name = "Knitcomno"
        Me.Knitcomno.ReadOnly = True
        Me.Knitcomno.Width = 200
        '
        'Qtyroll
        '
        Me.Qtyroll.DataPropertyName = "Qtyroll"
        Me.Qtyroll.HeaderText = "QTY(Rolls/พับ)"
        Me.Qtyroll.Name = "Qtyroll"
        Me.Qtyroll.ReadOnly = True
        Me.Qtyroll.Width = 150
        '
        'Dyedcomno
        '
        Me.Dyedcomno.DataPropertyName = "Dyedcomno"
        Me.Dyedcomno.HeaderText = "เลขที่ใบสั่งย้อม"
        Me.Dyedcomno.Name = "Dyedcomno"
        Me.Dyedcomno.ReadOnly = True
        Me.Dyedcomno.Width = 200
        '
        'Shadeid
        '
        Me.Shadeid.DataPropertyName = "Shadeid"
        Me.Shadeid.HeaderText = "Shadeid"
        Me.Shadeid.Name = "Shadeid"
        Me.Shadeid.ReadOnly = True
        Me.Shadeid.Visible = False
        '
        'Shadedesc
        '
        Me.Shadedesc.DataPropertyName = "Shadedesc"
        Me.Shadedesc.HeaderText = "Shade"
        Me.Shadedesc.Name = "Shadedesc"
        Me.Shadedesc.ReadOnly = True
        Me.Shadedesc.Width = 150
        '
        'Qtyrollsum
        '
        Me.Qtyrollsum.DataPropertyName = "Qtyrollsum"
        Me.Qtyrollsum.HeaderText = "QTY(Rolls/พับ)"
        Me.Qtyrollsum.Name = "Qtyrollsum"
        Me.Qtyrollsum.ReadOnly = True
        Me.Qtyrollsum.Width = 150
        '
        'Reid
        '
        Me.Reid.DataPropertyName = "Reid"
        Me.Reid.HeaderText = "เลขที่ใบรับเส้นด้าย"
        Me.Reid.Name = "Reid"
        Me.Reid.ReadOnly = True
        Me.Reid.Width = 200
        '
        'Lotno
        '
        Me.Lotno.DataPropertyName = "Lotno"
        Me.Lotno.HeaderText = "Lot No."
        Me.Lotno.Name = "Lotno"
        Me.Lotno.ReadOnly = True
        Me.Lotno.Width = 150
        '
        'Kongno
        '
        Me.Kongno.DataPropertyName = "Kongno"
        Me.Kongno.HeaderText = "เบอร์กอง"
        Me.Kongno.Name = "Kongno"
        Me.Kongno.ReadOnly = True
        '
        'Qtyrollresum
        '
        Me.Qtyrollresum.DataPropertyName = "Qtyrollresum"
        Me.Qtyrollresum.HeaderText = "จำนวนพับรวม"
        Me.Qtyrollresum.Name = "Qtyrollresum"
        Me.Qtyrollresum.ReadOnly = True
        Me.Qtyrollresum.Width = 150
        '
        'Salewgtkgsum
        '
        Me.Salewgtkgsum.DataPropertyName = "Salewgtkgsum"
        Me.Salewgtkgsum.HeaderText = "น้ำหนักรวม(กก.)"
        Me.Salewgtkgsum.Name = "Salewgtkgsum"
        Me.Salewgtkgsum.ReadOnly = True
        Me.Salewgtkgsum.Width = 150
        '
        'Dlvnosale
        '
        Me.Dlvnosale.DataPropertyName = "Dlvnosale"
        Me.Dlvnosale.HeaderText = "เลขที่ใบส่งผ้าสี"
        Me.Dlvnosale.Name = "Dlvnosale"
        Me.Dlvnosale.ReadOnly = True
        Me.Dlvnosale.Width = 150
        '
        'Wgtkgsale
        '
        Me.Wgtkgsale.DataPropertyName = "Wgtkgsale"
        Me.Wgtkgsale.HeaderText = "น้ำหนักรวม"
        Me.Wgtkgsale.Name = "Wgtkgsale"
        Me.Wgtkgsale.ReadOnly = True
        '
        'Dlvnocount
        '
        Me.Dlvnocount.DataPropertyName = "Dlvnocount"
        Me.Dlvnocount.HeaderText = "ขายผ้ารวม"
        Me.Dlvnocount.Name = "Dlvnocount"
        Me.Dlvnocount.ReadOnly = True
        '
        'Formfabfollow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Formfabfollow"
        Me.Text = "Formfabfollow"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.miniToolStrip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabControlPanel2.ResumeLayout(False)
        Me.GroupPanel3.ResumeLayout(False)
        Me.GroupPanel3.PerformLayout()
        CType(Me.Dgvmas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Btmclose As ToolStripButton
    Friend WithEvents Tstbdocpre As ToolStripTextBox
    Friend WithEvents Tstbdocpreid As ToolStripTextBox
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents miniToolStrip As BindingNavigator
    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem2 As DevComponents.DotNetBar.TabItem
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents ToolStrip8 As ToolStrip
    Friend WithEvents Dgvmas As DataGridView
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents Panel5 As Panel
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Tbjobno As Normtextbox.Normtextbox
    Friend WithEvents Ord As DataGridViewTextBoxColumn
    Friend WithEvents Comid As DataGridViewTextBoxColumn
    Friend WithEvents Jobno As DataGridViewTextBoxColumn
    Friend WithEvents Clothid As DataGridViewTextBoxColumn
    Friend WithEvents Clothno As DataGridViewTextBoxColumn
    Friend WithEvents Ftype As DataGridViewTextBoxColumn
    Friend WithEvents Dozen As DataGridViewTextBoxColumn
    Friend WithEvents Dlvno As DataGridViewTextBoxColumn
    Friend WithEvents Knitcomno As DataGridViewTextBoxColumn
    Friend WithEvents Qtyroll As DataGridViewTextBoxColumn
    Friend WithEvents Dyedcomno As DataGridViewTextBoxColumn
    Friend WithEvents Shadeid As DataGridViewTextBoxColumn
    Friend WithEvents Shadedesc As DataGridViewTextBoxColumn
    Friend WithEvents Qtyrollsum As DataGridViewTextBoxColumn
    Friend WithEvents Reid As DataGridViewTextBoxColumn
    Friend WithEvents Lotno As DataGridViewTextBoxColumn
    Friend WithEvents Kongno As DataGridViewTextBoxColumn
    Friend WithEvents Qtyrollresum As DataGridViewTextBoxColumn
    Friend WithEvents Salewgtkgsum As DataGridViewTextBoxColumn
    Friend WithEvents Dlvnosale As DataGridViewTextBoxColumn
    Friend WithEvents Wgtkgsale As DataGridViewTextBoxColumn
    Friend WithEvents Dlvnocount As DataGridViewTextBoxColumn
End Class
