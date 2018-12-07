<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formyedcomno
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.Dgvmas = New System.Windows.Forms.DataGridView()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mcomid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Reid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dhid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Billdyedno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Billknitt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Recdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lotno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kongno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dyedcolor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dremark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Updusr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Uptype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Uptime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Btmsearch = New System.Windows.Forms.ToolStripButton()
        Me.Tbkeyword = New System.Windows.Forms.ToolStripTextBox()
        Me.Tbclothid = New System.Windows.Forms.ToolStripTextBox()
        Me.Tbcancel = New System.Windows.Forms.ToolStripTextBox()
        Me.Tbkongno = New System.Windows.Forms.ToolStripTextBox()
        Me.Btcancel = New DevComponents.DotNetBar.ButtonX()
        Me.Btok = New DevComponents.DotNetBar.ButtonX()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        CType(Me.Dgvmas, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.Size = New System.Drawing.Size(384, 331)
        Me.TabControl1.TabIndex = 9
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.TabItem1)
        Me.TabControl1.Text = "TabControl1"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.Dgvmas)
        Me.TabControlPanel1.Controls.Add(Me.ToolStrip1)
        Me.TabControlPanel1.Controls.Add(Me.Btcancel)
        Me.TabControlPanel1.Controls.Add(Me.Btok)
        Me.TabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(384, 305)
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
        Me.Dgvmas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Status, Me.Mcomid, Me.Reid, Me.Dhid, Me.Billdyedno, Me.Billknitt, Me.Recdate, Me.Lotno, Me.Kongno, Me.Dyedcolor, Me.Dremark, Me.Updusr, Me.Uptype, Me.Uptime})
        Me.Dgvmas.Dock = System.Windows.Forms.DockStyle.Top
        Me.Dgvmas.Location = New System.Drawing.Point(1, 50)
        Me.Dgvmas.Name = "Dgvmas"
        Me.Dgvmas.ReadOnly = True
        Me.Dgvmas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgvmas.Size = New System.Drawing.Size(382, 181)
        Me.Dgvmas.TabIndex = 29
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
        'Reid
        '
        Me.Reid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Reid.DataPropertyName = "Reid"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Reid.DefaultCellStyle = DataGridViewCellStyle2
        Me.Reid.HeaderText = "เลขที่ใบรับผ้าสี"
        Me.Reid.Name = "Reid"
        Me.Reid.ReadOnly = True
        '
        'Dhid
        '
        Me.Dhid.DataPropertyName = "Dhid"
        Me.Dhid.HeaderText = "Dhid"
        Me.Dhid.Name = "Dhid"
        Me.Dhid.ReadOnly = True
        Me.Dhid.Visible = False
        '
        'Billdyedno
        '
        Me.Billdyedno.DataPropertyName = "Billdyedno"
        Me.Billdyedno.HeaderText = "Billdyedno"
        Me.Billdyedno.Name = "Billdyedno"
        Me.Billdyedno.ReadOnly = True
        Me.Billdyedno.Visible = False
        '
        'Billknitt
        '
        Me.Billknitt.DataPropertyName = "Billknitt"
        Me.Billknitt.HeaderText = "Billknitt"
        Me.Billknitt.Name = "Billknitt"
        Me.Billknitt.ReadOnly = True
        Me.Billknitt.Visible = False
        '
        'Recdate
        '
        Me.Recdate.DataPropertyName = "Recdate"
        Me.Recdate.HeaderText = "Recdate"
        Me.Recdate.Name = "Recdate"
        Me.Recdate.ReadOnly = True
        Me.Recdate.Visible = False
        '
        'Lotno
        '
        Me.Lotno.DataPropertyName = "Lotno"
        Me.Lotno.HeaderText = "Lotno"
        Me.Lotno.Name = "Lotno"
        Me.Lotno.ReadOnly = True
        Me.Lotno.Visible = False
        '
        'Kongno
        '
        Me.Kongno.DataPropertyName = "Kongno"
        Me.Kongno.HeaderText = "Kongno"
        Me.Kongno.Name = "Kongno"
        Me.Kongno.ReadOnly = True
        Me.Kongno.Visible = False
        '
        'Dyedcolor
        '
        Me.Dyedcolor.DataPropertyName = "Dyedcolor"
        Me.Dyedcolor.HeaderText = "Dyedcolor"
        Me.Dyedcolor.Name = "Dyedcolor"
        Me.Dyedcolor.ReadOnly = True
        Me.Dyedcolor.Visible = False
        '
        'Dremark
        '
        Me.Dremark.DataPropertyName = "Dremark"
        Me.Dremark.HeaderText = "Dremark"
        Me.Dremark.Name = "Dremark"
        Me.Dremark.ReadOnly = True
        Me.Dremark.Visible = False
        '
        'Updusr
        '
        Me.Updusr.DataPropertyName = "Updusr"
        Me.Updusr.HeaderText = "Updusr"
        Me.Updusr.Name = "Updusr"
        Me.Updusr.ReadOnly = True
        Me.Updusr.Visible = False
        '
        'Uptype
        '
        Me.Uptype.DataPropertyName = "Uptype"
        Me.Uptype.HeaderText = "Uptype"
        Me.Uptype.Name = "Uptype"
        Me.Uptype.ReadOnly = True
        Me.Uptype.Visible = False
        '
        'Uptime
        '
        Me.Uptime.DataPropertyName = "Uptime"
        Me.Uptime.HeaderText = "Uptime"
        Me.Uptime.Name = "Uptime"
        Me.Uptime.ReadOnly = True
        Me.Uptime.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Btmsearch, Me.Tbkeyword, Me.Tbclothid, Me.Tbcancel, Me.Tbkongno})
        Me.ToolStrip1.Location = New System.Drawing.Point(1, 1)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(382, 49)
        Me.ToolStrip1.TabIndex = 28
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Btmsearch
        '
        Me.Btmsearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Btmsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Btmsearch.Image = Global.XpressPlus.My.Resources.Resources.Findicon
        Me.Btmsearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btmsearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btmsearch.Name = "Btmsearch"
        Me.Btmsearch.Size = New System.Drawing.Size(48, 46)
        Me.Btmsearch.Text = "ค้นหา"
        Me.Btmsearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Tbkeyword
        '
        Me.Tbkeyword.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Tbkeyword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Tbkeyword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbkeyword.Name = "Tbkeyword"
        Me.Tbkeyword.Size = New System.Drawing.Size(120, 49)
        '
        'Tbclothid
        '
        Me.Tbclothid.Name = "Tbclothid"
        Me.Tbclothid.Size = New System.Drawing.Size(25, 49)
        Me.Tbclothid.Visible = False
        '
        'Tbcancel
        '
        Me.Tbcancel.Name = "Tbcancel"
        Me.Tbcancel.Size = New System.Drawing.Size(25, 49)
        Me.Tbcancel.Visible = False
        '
        'Tbkongno
        '
        Me.Tbkongno.Name = "Tbkongno"
        Me.Tbkongno.Size = New System.Drawing.Size(100, 49)
        Me.Tbkongno.Visible = False
        '
        'Btcancel
        '
        Me.Btcancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btcancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Btcancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Btcancel.Location = New System.Drawing.Point(233, 249)
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
        Me.Btok.Location = New System.Drawing.Point(87, 249)
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
        Me.TabItem1.Text = "เลขที่ใบรับผ้าสี"
        '
        'Formyedcomno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 331)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Formyedcomno"
        Me.Text = "รายการ เลขที่ใบรับผ้าสี"
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.TabControlPanel1.PerformLayout()
        CType(Me.Dgvmas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents Dgvmas As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Btmsearch As ToolStripButton
    Friend WithEvents Tbkeyword As ToolStripTextBox
    Friend WithEvents Tbclothid As ToolStripTextBox
    Friend WithEvents Tbcancel As ToolStripTextBox
    Friend WithEvents Btcancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Btok As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents Tbkongno As ToolStripTextBox
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents Mcomid As DataGridViewTextBoxColumn
    Friend WithEvents Reid As DataGridViewTextBoxColumn
    Friend WithEvents Dhid As DataGridViewTextBoxColumn
    Friend WithEvents Billdyedno As DataGridViewTextBoxColumn
    Friend WithEvents Billknitt As DataGridViewTextBoxColumn
    Friend WithEvents Recdate As DataGridViewTextBoxColumn
    Friend WithEvents Lotno As DataGridViewTextBoxColumn
    Friend WithEvents Kongno As DataGridViewTextBoxColumn
    Friend WithEvents Dyedcolor As DataGridViewTextBoxColumn
    Friend WithEvents Dremark As DataGridViewTextBoxColumn
    Friend WithEvents Updusr As DataGridViewTextBoxColumn
    Friend WithEvents Uptype As DataGridViewTextBoxColumn
    Friend WithEvents Uptime As DataGridViewTextBoxColumn
End Class
