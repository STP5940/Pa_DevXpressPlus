<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formshade
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.Dgvmas = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Btmclose = New System.Windows.Forms.ToolStripButton()
        Me.Btmsearch = New System.Windows.Forms.ToolStripButton()
        Me.Tbmkeyword = New System.Windows.Forms.ToolStripTextBox()
        Me.Btmdel = New System.Windows.Forms.ToolStripButton()
        Me.Btmedit = New System.Windows.Forms.ToolStripButton()
        Me.Btmadd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.Btfirst = New System.Windows.Forms.ToolStripButton()
        Me.Btprev = New System.Windows.Forms.ToolStripButton()
        Me.Tbpage = New System.Windows.Forms.ToolStripTextBox()
        Me.Btnext = New System.Windows.Forms.ToolStripButton()
        Me.Btlast = New System.Windows.Forms.ToolStripButton()
        Me.Tbmrecord = New System.Windows.Forms.ToolStripTextBox()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mcomid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mdesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rcolor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gcolor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bcolor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mact = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Mdel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Musr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mtype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mtime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        CType(Me.Dgvmas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControl1.CanReorderTabs = True
        Me.TabControl1.Controls.Add(Me.TabControlPanel1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TabControl1.ForeColor = System.Drawing.Color.Black
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.SelectedTabIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1008, 729)
        Me.TabControl1.TabIndex = 20
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.TabItem1)
        Me.TabControl1.Text = "TabControl1"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.Dgvmas)
        Me.TabControlPanel1.Controls.Add(Me.ToolStrip1)
        Me.TabControlPanel1.Controls.Add(Me.ToolStrip2)
        Me.TabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(1008, 703)
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
        Me.Dgvmas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Status, Me.Mcomid, Me.Mid, Me.Mdesc, Me.Rcolor, Me.Gcolor, Me.Bcolor, Me.Mact, Me.Mdel, Me.Musr, Me.Mtype, Me.Mtime})
        Me.Dgvmas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgvmas.Location = New System.Drawing.Point(1, 50)
        Me.Dgvmas.Name = "Dgvmas"
        Me.Dgvmas.ReadOnly = True
        Me.Dgvmas.Size = New System.Drawing.Size(1006, 613)
        Me.Dgvmas.TabIndex = 20
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Btmclose, Me.Btmsearch, Me.Tbmkeyword, Me.Btmdel, Me.Btmedit, Me.Btmadd})
        Me.ToolStrip1.Location = New System.Drawing.Point(1, 1)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1006, 49)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Btmclose
        '
        Me.Btmclose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Btmclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btmclose.Image = Global.XpressPlus.My.Resources.Resources.Closewin
        Me.Btmclose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btmclose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btmclose.Name = "Btmclose"
        Me.Btmclose.Size = New System.Drawing.Size(31, 46)
        Me.Btmclose.Text = "ปิด"
        Me.Btmclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Btmsearch
        '
        Me.Btmsearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Btmsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btmsearch.Image = Global.XpressPlus.My.Resources.Resources.Findicon
        Me.Btmsearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btmsearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btmsearch.Name = "Btmsearch"
        Me.Btmsearch.Size = New System.Drawing.Size(48, 46)
        Me.Btmsearch.Text = "ค้นหา"
        Me.Btmsearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Tbmkeyword
        '
        Me.Tbmkeyword.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Tbmkeyword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Tbmkeyword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbmkeyword.Name = "Tbmkeyword"
        Me.Tbmkeyword.Size = New System.Drawing.Size(120, 49)
        '
        'Btmdel
        '
        Me.Btmdel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Btmdel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btmdel.Image = Global.XpressPlus.My.Resources.Resources.Deleteicon
        Me.Btmdel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btmdel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btmdel.Name = "Btmdel"
        Me.Btmdel.Size = New System.Drawing.Size(30, 46)
        Me.Btmdel.Text = "ลบ"
        Me.Btmdel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Btmedit
        '
        Me.Btmedit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Btmedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btmedit.Image = Global.XpressPlus.My.Resources.Resources.Editicon
        Me.Btmedit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btmedit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btmedit.Name = "Btmedit"
        Me.Btmedit.Size = New System.Drawing.Size(48, 46)
        Me.Btmedit.Text = "แก้ไข"
        Me.Btmedit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Btmadd
        '
        Me.Btmadd.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Btmadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btmadd.Image = Global.XpressPlus.My.Resources.Resources.Addicon
        Me.Btmadd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btmadd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btmadd.Name = "Btmadd"
        Me.Btmadd.Size = New System.Drawing.Size(38, 46)
        Me.Btmadd.Text = "เพิ่ม"
        Me.Btmadd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Btfirst, Me.Btprev, Me.Tbpage, Me.Btnext, Me.Btlast, Me.Tbmrecord})
        Me.ToolStrip2.Location = New System.Drawing.Point(1, 663)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1006, 39)
        Me.ToolStrip2.TabIndex = 3
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'Btfirst
        '
        Me.Btfirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btfirst.Image = Global.XpressPlus.My.Resources.Resources.Firsticon
        Me.Btfirst.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btfirst.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btfirst.Name = "Btfirst"
        Me.Btfirst.Size = New System.Drawing.Size(50, 36)
        Me.Btfirst.Text = "หน้าแรก"
        Me.Btfirst.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Btprev
        '
        Me.Btprev.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btprev.Image = Global.XpressPlus.My.Resources.Resources.Lefticon
        Me.Btprev.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btprev.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btprev.Name = "Btprev"
        Me.Btprev.Size = New System.Drawing.Size(51, 36)
        Me.Btprev.Text = "ก่อนหน้า"
        Me.Btprev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Tbpage
        '
        Me.Tbpage.Enabled = False
        Me.Tbpage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbpage.Name = "Tbpage"
        Me.Tbpage.Size = New System.Drawing.Size(120, 39)
        Me.Tbpage.Text = "หน้า 0/0"
        '
        'Btnext
        '
        Me.Btnext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnext.Image = Global.XpressPlus.My.Resources.Resources.Righticon
        Me.Btnext.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btnext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btnext.Name = "Btnext"
        Me.Btnext.Size = New System.Drawing.Size(37, 36)
        Me.Btnext.Text = "ถัดไป"
        Me.Btnext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Btlast
        '
        Me.Btlast.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btlast.Image = Global.XpressPlus.My.Resources.Resources.Lasticon
        Me.Btlast.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btlast.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btlast.Name = "Btlast"
        Me.Btlast.Size = New System.Drawing.Size(45, 36)
        Me.Btlast.Text = "สุดท้าย"
        Me.Btlast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Tbmrecord
        '
        Me.Tbmrecord.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Tbmrecord.Enabled = False
        Me.Tbmrecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbmrecord.Name = "Tbmrecord"
        Me.Tbmrecord.Size = New System.Drawing.Size(200, 39)
        Me.Tbmrecord.Text = "แสดง 0 รายการ จาก 0 รายการ"
        Me.Tbmrecord.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel1
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "Shade"
        '
        'Status
        '
        Me.Status.DataPropertyName = "Stat"
        Me.Status.HeaderText = ""
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        Me.Status.Width = 20
        '
        'Mcomid
        '
        Me.Mcomid.DataPropertyName = "Comid"
        Me.Mcomid.HeaderText = "Comid"
        Me.Mcomid.Name = "Mcomid"
        Me.Mcomid.ReadOnly = True
        Me.Mcomid.Visible = False
        '
        'Mid
        '
        Me.Mid.DataPropertyName = "Shadeid"
        Me.Mid.HeaderText = "รหัส"
        Me.Mid.Name = "Mid"
        Me.Mid.ReadOnly = True
        '
        'Mdesc
        '
        Me.Mdesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Mdesc.DataPropertyName = "Shadedesc"
        Me.Mdesc.HeaderText = "ชื่อ"
        Me.Mdesc.Name = "Mdesc"
        Me.Mdesc.ReadOnly = True
        '
        'Rcolor
        '
        Me.Rcolor.DataPropertyName = "Rcolor"
        Me.Rcolor.HeaderText = "Rcolor"
        Me.Rcolor.Name = "Rcolor"
        Me.Rcolor.ReadOnly = True
        Me.Rcolor.Visible = False
        '
        'Gcolor
        '
        Me.Gcolor.DataPropertyName = "Gcolor"
        Me.Gcolor.HeaderText = "Gcolor"
        Me.Gcolor.Name = "Gcolor"
        Me.Gcolor.ReadOnly = True
        Me.Gcolor.Visible = False
        '
        'Bcolor
        '
        Me.Bcolor.DataPropertyName = "Bcolor"
        Me.Bcolor.HeaderText = "Bcolor"
        Me.Bcolor.Name = "Bcolor"
        Me.Bcolor.ReadOnly = True
        Me.Bcolor.Visible = False
        '
        'Mact
        '
        Me.Mact.DataPropertyName = "Sactive"
        Me.Mact.HeaderText = "Active"
        Me.Mact.Name = "Mact"
        Me.Mact.ReadOnly = True
        Me.Mact.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Mact.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Mact.Width = 80
        '
        'Mdel
        '
        Me.Mdel.DataPropertyName = "Sstatus"
        Me.Mdel.HeaderText = "Sstatus"
        Me.Mdel.Name = "Mdel"
        Me.Mdel.ReadOnly = True
        Me.Mdel.Visible = False
        '
        'Musr
        '
        Me.Musr.DataPropertyName = "Updusr"
        Me.Musr.HeaderText = "Updusr"
        Me.Musr.Name = "Musr"
        Me.Musr.ReadOnly = True
        Me.Musr.Visible = False
        '
        'Mtype
        '
        Me.Mtype.DataPropertyName = "Uptype"
        Me.Mtype.HeaderText = "Uptype"
        Me.Mtype.Name = "Mtype"
        Me.Mtype.ReadOnly = True
        Me.Mtype.Visible = False
        '
        'Mtime
        '
        Me.Mtime.DataPropertyName = "Uptime"
        Me.Mtime.HeaderText = "Uptime"
        Me.Mtime.Name = "Mtime"
        Me.Mtime.ReadOnly = True
        Me.Mtime.Visible = False
        '
        'Formshade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Formshade"
        Me.Tag = "F118"
        Me.Text = "Shade"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.TabControlPanel1.PerformLayout()
        CType(Me.Dgvmas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Btmsearch As ToolStripButton
    Friend WithEvents Tbmkeyword As ToolStripTextBox
    Friend WithEvents Btmdel As ToolStripButton
    Friend WithEvents Btmedit As ToolStripButton
    Friend WithEvents Btmadd As ToolStripButton
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents Btfirst As ToolStripButton
    Friend WithEvents Btprev As ToolStripButton
    Friend WithEvents Tbpage As ToolStripTextBox
    Friend WithEvents Btnext As ToolStripButton
    Friend WithEvents Btlast As ToolStripButton
    Friend WithEvents Tbmrecord As ToolStripTextBox
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents Dgvmas As DataGridView
    Friend WithEvents Btmclose As ToolStripButton
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents Mcomid As DataGridViewTextBoxColumn
    Friend WithEvents Mid As DataGridViewTextBoxColumn
    Friend WithEvents Mdesc As DataGridViewTextBoxColumn
    Friend WithEvents Rcolor As DataGridViewTextBoxColumn
    Friend WithEvents Gcolor As DataGridViewTextBoxColumn
    Friend WithEvents Bcolor As DataGridViewTextBoxColumn
    Friend WithEvents Mact As DataGridViewCheckBoxColumn
    Friend WithEvents Mdel As DataGridViewTextBoxColumn
    Friend WithEvents Musr As DataGridViewTextBoxColumn
    Friend WithEvents Mtype As DataGridViewTextBoxColumn
    Friend WithEvents Mtime As DataGridViewTextBoxColumn
End Class
