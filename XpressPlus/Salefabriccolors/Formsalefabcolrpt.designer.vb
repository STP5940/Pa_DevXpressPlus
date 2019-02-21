<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formsalefabcolrpt
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Btmclose = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.Tstbsumdoz = New Normtextbox.Normtextbox()
        Me.Tbsumnetkg = New Normtextbox.Normtextbox()
        Me.TbBagwgt = New Normtextbox.Normtextbox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Tbremark = New Normtextbox.Normtextbox()
        Me.FilterLotarray = New System.Windows.Forms.TextBox()
        Me.FilterKongarray = New System.Windows.Forms.TextBox()
        Me.Pricesum = New System.Windows.Forms.TextBox()
        Me.Tstbsumkg = New System.Windows.Forms.TextBox()
        Me.Tbsumprice = New System.Windows.Forms.TextBox()
        Me.Tbkgprice = New System.Windows.Forms.TextBox()
        Me.Tbsumkg = New System.Windows.Forms.TextBox()
        Me.Tbclothno = New System.Windows.Forms.TextBox()
        Me.Tbshade = New System.Windows.Forms.TextBox()
        Me.Tbwidth = New System.Windows.Forms.TextBox()
        Me.Tbcolor = New System.Windows.Forms.TextBox()
        Me.Tbdlvno = New System.Windows.Forms.TextBox()
        Me.Tbdate = New System.Windows.Forms.TextBox()
        Me.Tbcustname = New System.Windows.Forms.TextBox()
        Me.Tbcustaddr = New System.Windows.Forms.TextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lotno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kongno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sumvol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sumdoz = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Shadedesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Btmclose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1008, 47)
        Me.ToolStrip1.TabIndex = 71
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Btmclose
        '
        Me.Btmclose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Btmclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btmclose.Image = Global.XpressPlus.My.Resources.Resources.Closewin
        Me.Btmclose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btmclose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btmclose.Name = "Btmclose"
        Me.Btmclose.Size = New System.Drawing.Size(28, 44)
        Me.Btmclose.Text = "ปิด"
        Me.Btmclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TabControl1
        '
        Me.TabControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControl1.CanReorderTabs = True
        Me.TabControl1.Controls.Add(Me.TabControlPanel1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TabControl1.ForeColor = System.Drawing.Color.Black
        Me.TabControl1.Location = New System.Drawing.Point(0, 47)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.SelectedTabIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1008, 682)
        Me.TabControl1.TabIndex = 72
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.TabItem1)
        Me.TabControl1.Text = "TabControl1"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.Tstbsumdoz)
        Me.TabControlPanel1.Controls.Add(Me.Tbsumnetkg)
        Me.TabControlPanel1.Controls.Add(Me.TbBagwgt)
        Me.TabControlPanel1.Controls.Add(Me.DataGridView2)
        Me.TabControlPanel1.Controls.Add(Me.DataGridView1)
        Me.TabControlPanel1.Controls.Add(Me.Tbremark)
        Me.TabControlPanel1.Controls.Add(Me.FilterLotarray)
        Me.TabControlPanel1.Controls.Add(Me.FilterKongarray)
        Me.TabControlPanel1.Controls.Add(Me.Pricesum)
        Me.TabControlPanel1.Controls.Add(Me.Tstbsumkg)
        Me.TabControlPanel1.Controls.Add(Me.Tbsumprice)
        Me.TabControlPanel1.Controls.Add(Me.Tbkgprice)
        Me.TabControlPanel1.Controls.Add(Me.Tbsumkg)
        Me.TabControlPanel1.Controls.Add(Me.Tbclothno)
        Me.TabControlPanel1.Controls.Add(Me.Tbshade)
        Me.TabControlPanel1.Controls.Add(Me.Tbwidth)
        Me.TabControlPanel1.Controls.Add(Me.Tbcolor)
        Me.TabControlPanel1.Controls.Add(Me.Tbdlvno)
        Me.TabControlPanel1.Controls.Add(Me.Tbdate)
        Me.TabControlPanel1.Controls.Add(Me.Tbcustname)
        Me.TabControlPanel1.Controls.Add(Me.Tbcustaddr)
        Me.TabControlPanel1.Controls.Add(Me.ReportViewer1)
        Me.TabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(1008, 656)
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
        'Tstbsumdoz
        '
        Me.Tstbsumdoz.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tstbsumdoz.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Tstbsumdoz.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tstbsumdoz.Location = New System.Drawing.Point(894, 287)
        Me.Tstbsumdoz.MaxLength = 150
        Me.Tstbsumdoz.Multiline = True
        Me.Tstbsumdoz.Name = "Tstbsumdoz"
        Me.Tstbsumdoz.Size = New System.Drawing.Size(100, 22)
        Me.Tstbsumdoz.TabIndex = 203
        Me.Tstbsumdoz.Visible = False
        '
        'Tbsumnetkg
        '
        Me.Tbsumnetkg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tbsumnetkg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Tbsumnetkg.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbsumnetkg.Location = New System.Drawing.Point(788, 259)
        Me.Tbsumnetkg.MaxLength = 150
        Me.Tbsumnetkg.Multiline = True
        Me.Tbsumnetkg.Name = "Tbsumnetkg"
        Me.Tbsumnetkg.Size = New System.Drawing.Size(100, 22)
        Me.Tbsumnetkg.TabIndex = 202
        Me.Tbsumnetkg.Visible = False
        '
        'TbBagwgt
        '
        Me.TbBagwgt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbBagwgt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbBagwgt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbBagwgt.Location = New System.Drawing.Point(894, 259)
        Me.TbBagwgt.MaxLength = 150
        Me.TbBagwgt.Multiline = True
        Me.TbBagwgt.Name = "TbBagwgt"
        Me.TbBagwgt.Size = New System.Drawing.Size(100, 22)
        Me.TbBagwgt.TabIndex = 200
        Me.TbBagwgt.Visible = False
        '
        'DataGridView2
        '
        Me.DataGridView2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(47, 337)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(916, 150)
        Me.DataGridView2.TabIndex = 198
        Me.DataGridView2.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Lotno, Me.Kongno, Me.Sumvol, Me.Sumdoz, Me.Shadedesc, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15, Me.Column16, Me.Column17})
        Me.DataGridView1.Location = New System.Drawing.Point(47, 522)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(916, 254)
        Me.DataGridView1.TabIndex = 197
        Me.DataGridView1.Visible = False
        '
        'Tbremark
        '
        Me.Tbremark.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tbremark.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Tbremark.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbremark.Location = New System.Drawing.Point(788, 231)
        Me.Tbremark.MaxLength = 150
        Me.Tbremark.Multiline = True
        Me.Tbremark.Name = "Tbremark"
        Me.Tbremark.Size = New System.Drawing.Size(100, 22)
        Me.Tbremark.TabIndex = 196
        Me.Tbremark.Visible = False
        '
        'FilterLotarray
        '
        Me.FilterLotarray.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FilterLotarray.Location = New System.Drawing.Point(894, 231)
        Me.FilterLotarray.Name = "FilterLotarray"
        Me.FilterLotarray.Size = New System.Drawing.Size(100, 22)
        Me.FilterLotarray.TabIndex = 195
        Me.FilterLotarray.Visible = False
        '
        'FilterKongarray
        '
        Me.FilterKongarray.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FilterKongarray.Location = New System.Drawing.Point(788, 203)
        Me.FilterKongarray.Name = "FilterKongarray"
        Me.FilterKongarray.Size = New System.Drawing.Size(100, 22)
        Me.FilterKongarray.TabIndex = 192
        Me.FilterKongarray.Visible = False
        '
        'Pricesum
        '
        Me.Pricesum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pricesum.Location = New System.Drawing.Point(894, 203)
        Me.Pricesum.Name = "Pricesum"
        Me.Pricesum.Size = New System.Drawing.Size(100, 22)
        Me.Pricesum.TabIndex = 191
        Me.Pricesum.Visible = False
        '
        'Tstbsumkg
        '
        Me.Tstbsumkg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tstbsumkg.Location = New System.Drawing.Point(894, 175)
        Me.Tstbsumkg.Name = "Tstbsumkg"
        Me.Tstbsumkg.Size = New System.Drawing.Size(100, 22)
        Me.Tstbsumkg.TabIndex = 190
        Me.Tstbsumkg.Visible = False
        '
        'Tbsumprice
        '
        Me.Tbsumprice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tbsumprice.Location = New System.Drawing.Point(788, 175)
        Me.Tbsumprice.Name = "Tbsumprice"
        Me.Tbsumprice.Size = New System.Drawing.Size(100, 22)
        Me.Tbsumprice.TabIndex = 189
        Me.Tbsumprice.Visible = False
        '
        'Tbkgprice
        '
        Me.Tbkgprice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tbkgprice.Location = New System.Drawing.Point(788, 147)
        Me.Tbkgprice.Name = "Tbkgprice"
        Me.Tbkgprice.Size = New System.Drawing.Size(100, 22)
        Me.Tbkgprice.TabIndex = 188
        Me.Tbkgprice.Visible = False
        '
        'Tbsumkg
        '
        Me.Tbsumkg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tbsumkg.Location = New System.Drawing.Point(894, 119)
        Me.Tbsumkg.Name = "Tbsumkg"
        Me.Tbsumkg.Size = New System.Drawing.Size(100, 22)
        Me.Tbsumkg.TabIndex = 187
        Me.Tbsumkg.Visible = False
        '
        'Tbclothno
        '
        Me.Tbclothno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tbclothno.Location = New System.Drawing.Point(788, 91)
        Me.Tbclothno.Name = "Tbclothno"
        Me.Tbclothno.Size = New System.Drawing.Size(100, 22)
        Me.Tbclothno.TabIndex = 186
        Me.Tbclothno.Visible = False
        '
        'Tbshade
        '
        Me.Tbshade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tbshade.Location = New System.Drawing.Point(788, 119)
        Me.Tbshade.Name = "Tbshade"
        Me.Tbshade.Size = New System.Drawing.Size(100, 22)
        Me.Tbshade.TabIndex = 185
        Me.Tbshade.Visible = False
        '
        'Tbwidth
        '
        Me.Tbwidth.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tbwidth.Location = New System.Drawing.Point(894, 91)
        Me.Tbwidth.Name = "Tbwidth"
        Me.Tbwidth.Size = New System.Drawing.Size(100, 22)
        Me.Tbwidth.TabIndex = 184
        Me.Tbwidth.Visible = False
        '
        'Tbcolor
        '
        Me.Tbcolor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tbcolor.Location = New System.Drawing.Point(894, 147)
        Me.Tbcolor.Name = "Tbcolor"
        Me.Tbcolor.Size = New System.Drawing.Size(100, 22)
        Me.Tbcolor.TabIndex = 183
        Me.Tbcolor.Visible = False
        '
        'Tbdlvno
        '
        Me.Tbdlvno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tbdlvno.Location = New System.Drawing.Point(894, 35)
        Me.Tbdlvno.Name = "Tbdlvno"
        Me.Tbdlvno.Size = New System.Drawing.Size(100, 22)
        Me.Tbdlvno.TabIndex = 182
        Me.Tbdlvno.Visible = False
        '
        'Tbdate
        '
        Me.Tbdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tbdate.Location = New System.Drawing.Point(894, 63)
        Me.Tbdate.Name = "Tbdate"
        Me.Tbdate.Size = New System.Drawing.Size(100, 22)
        Me.Tbdate.TabIndex = 181
        Me.Tbdate.Visible = False
        '
        'Tbcustname
        '
        Me.Tbcustname.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tbcustname.Location = New System.Drawing.Point(788, 35)
        Me.Tbcustname.Name = "Tbcustname"
        Me.Tbcustname.Size = New System.Drawing.Size(100, 22)
        Me.Tbcustname.TabIndex = 180
        Me.Tbcustname.Visible = False
        '
        'Tbcustaddr
        '
        Me.Tbcustaddr.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tbcustaddr.Location = New System.Drawing.Point(788, 63)
        Me.Tbcustaddr.Name = "Tbcustaddr"
        Me.Tbcustaddr.Size = New System.Drawing.Size(100, 22)
        Me.Tbcustaddr.TabIndex = 179
        Me.Tbcustaddr.Visible = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.Location = New System.Drawing.Point(1, 1)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1006, 654)
        Me.ReportViewer1.TabIndex = 0
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel1
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "ใบส่งผ้าสี(ขาย)"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Ord"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Lotno
        '
        Me.Lotno.DataPropertyName = "(none)"
        Me.Lotno.HeaderText = "Lotno"
        Me.Lotno.Name = "Lotno"
        Me.Lotno.ReadOnly = True
        '
        'Kongno
        '
        Me.Kongno.DataPropertyName = "(none)"
        Me.Kongno.HeaderText = "Kongno"
        Me.Kongno.Name = "Kongno"
        Me.Kongno.ReadOnly = True
        '
        'Sumvol
        '
        Me.Sumvol.HeaderText = "Sumvol"
        Me.Sumvol.Name = "Sumvol"
        Me.Sumvol.ReadOnly = True
        '
        'Sumdoz
        '
        Me.Sumdoz.HeaderText = "Sumdoz"
        Me.Sumdoz.Name = "Sumdoz"
        Me.Sumdoz.ReadOnly = True
        '
        'Shadedesc
        '
        Me.Shadedesc.HeaderText = "Shadedesc"
        Me.Shadedesc.Name = "Shadedesc"
        Me.Shadedesc.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Column3"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Column4"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Column5"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Unitprice"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Rollcount"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Column8"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "Column9"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "Column10"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.HeaderText = "Column11"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Column12
        '
        Me.Column12.HeaderText = "Column12"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'Column13
        '
        Me.Column13.HeaderText = "Column13"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        '
        'Column14
        '
        Me.Column14.HeaderText = "Column14"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        '
        'Column15
        '
        Me.Column15.HeaderText = "Column15"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        '
        'Column16
        '
        Me.Column16.HeaderText = "Column16"
        Me.Column16.Name = "Column16"
        Me.Column16.ReadOnly = True
        '
        'Column17
        '
        Me.Column17.HeaderText = "Column17"
        Me.Column17.Name = "Column17"
        Me.Column17.ReadOnly = True
        '
        'Formsalefabcolrpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Formsalefabcolrpt"
        Me.Text = "ใบส่งผ้าสี"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.TabControlPanel1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Btmclose As ToolStripButton
    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents Tbsumnetkg As Normtextbox.Normtextbox
    Friend WithEvents TbBagwgt As Normtextbox.Normtextbox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Tbremark As Normtextbox.Normtextbox
    Friend WithEvents FilterLotarray As TextBox
    Friend WithEvents FilterKongarray As TextBox
    Friend WithEvents Pricesum As TextBox
    Friend WithEvents Tstbsumkg As TextBox
    Friend WithEvents Tbsumprice As TextBox
    Friend WithEvents Tbkgprice As TextBox
    Friend WithEvents Tbsumkg As TextBox
    Friend WithEvents Tbclothno As TextBox
    Friend WithEvents Tbshade As TextBox
    Friend WithEvents Tbwidth As TextBox
    Friend WithEvents Tbcolor As TextBox
    Friend WithEvents Tbdlvno As TextBox
    Friend WithEvents Tbdate As TextBox
    Friend WithEvents Tbcustname As TextBox
    Friend WithEvents Tbcustaddr As TextBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents Tstbsumdoz As Normtextbox.Normtextbox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Lotno As DataGridViewTextBoxColumn
    Friend WithEvents Kongno As DataGridViewTextBoxColumn
    Friend WithEvents Sumvol As DataGridViewTextBoxColumn
    Friend WithEvents Sumdoz As DataGridViewTextBoxColumn
    Friend WithEvents Shadedesc As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
End Class
