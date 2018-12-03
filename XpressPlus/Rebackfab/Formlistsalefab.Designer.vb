<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formlistsalefab
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.Btcancel = New DevComponents.DotNetBar.ButtonX()
        Me.Btok = New DevComponents.DotNetBar.ButtonX()
        Me.Dgvmas = New System.Windows.Forms.DataGridView()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Checked = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Comid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dlvno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lotno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kongno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rollno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Clothid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Clothno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ftype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fwidth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Shadeid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Shadedesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HaveWgtkg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Wgtkg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SendWgtkg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Btmsearch = New System.Windows.Forms.ToolStripButton()
        Me.Tbkeyword = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripTextBox3 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.Tscball = New XpressPlus.ToolStripCheckBox()
        Me.Tbdyedbillno = New System.Windows.Forms.ToolStripTextBox()
        Me.Tbcancel = New System.Windows.Forms.ToolStripTextBox()
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1.SuspendLayout()
        CType(Me.Dgvmas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel1
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "รายละเอียดผ้า"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.Btcancel)
        Me.TabControlPanel1.Controls.Add(Me.Btok)
        Me.TabControlPanel1.Controls.Add(Me.Dgvmas)
        Me.TabControlPanel1.Controls.Add(Me.ToolStrip1)
        Me.TabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(1098, 343)
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
        'Btcancel
        '
        Me.Btcancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btcancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Btcancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Btcancel.Location = New System.Drawing.Point(596, 286)
        Me.Btcancel.Name = "Btcancel"
        Me.Btcancel.Size = New System.Drawing.Size(101, 37)
        Me.Btcancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.Btcancel.TabIndex = 90
        Me.Btcancel.Text = "ยกเลิก"
        '
        'Btok
        '
        Me.Btok.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btok.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Btok.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Btok.Location = New System.Drawing.Point(354, 286)
        Me.Btok.Name = "Btok"
        Me.Btok.Size = New System.Drawing.Size(101, 37)
        Me.Btok.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.Btok.TabIndex = 89
        Me.Btok.Text = "ตกลง"
        '
        'Dgvmas
        '
        Me.Dgvmas.AllowUserToAddRows = False
        Me.Dgvmas.AllowUserToDeleteRows = False
        Me.Dgvmas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgvmas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgvmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvmas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Status, Me.Checked, Me.Comid, Me.Dlvno, Me.Lotno, Me.Kongno, Me.Rollno, Me.Clothid, Me.Clothno, Me.Ftype, Me.Fwidth, Me.Shadeid, Me.Shadedesc, Me.HaveWgtkg, Me.Wgtkg, Me.SendWgtkg})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgvmas.DefaultCellStyle = DataGridViewCellStyle4
        Me.Dgvmas.Location = New System.Drawing.Point(1, 50)
        Me.Dgvmas.Name = "Dgvmas"
        Me.Dgvmas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgvmas.Size = New System.Drawing.Size(1097, 219)
        Me.Dgvmas.TabIndex = 30
        '
        'Status
        '
        Me.Status.DataPropertyName = "Stat"
        Me.Status.HeaderText = ""
        Me.Status.Name = "Status"
        Me.Status.Width = 20
        '
        'Checked
        '
        Me.Checked.FalseValue = "False"
        Me.Checked.HeaderText = ""
        Me.Checked.MinimumWidth = 70
        Me.Checked.Name = "Checked"
        Me.Checked.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Checked.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Checked.TrueValue = "True"
        Me.Checked.Width = 70
        '
        'Comid
        '
        Me.Comid.DataPropertyName = "Comid"
        Me.Comid.HeaderText = "Comid"
        Me.Comid.Name = "Comid"
        Me.Comid.Visible = False
        '
        'Dlvno
        '
        Me.Dlvno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Dlvno.DataPropertyName = "Dlvno"
        Me.Dlvno.HeaderText = "เลขที่ใบขาย"
        Me.Dlvno.Name = "Dlvno"
        '
        'Lotno
        '
        Me.Lotno.DataPropertyName = "Lotno"
        Me.Lotno.HeaderText = "Lot  No."
        Me.Lotno.Name = "Lotno"
        '
        'Kongno
        '
        Me.Kongno.DataPropertyName = "Kongno"
        Me.Kongno.HeaderText = "เบอร์กอง"
        Me.Kongno.Name = "Kongno"
        '
        'Rollno
        '
        Me.Rollno.DataPropertyName = "Rollno"
        Me.Rollno.HeaderText = "พับที่"
        Me.Rollno.Name = "Rollno"
        '
        'Clothid
        '
        Me.Clothid.DataPropertyName = "Clothid"
        Me.Clothid.HeaderText = "Clothid"
        Me.Clothid.Name = "Clothid"
        Me.Clothid.Visible = False
        '
        'Clothno
        '
        Me.Clothno.DataPropertyName = "Clothno"
        Me.Clothno.HeaderText = "เบอร์ผ้า"
        Me.Clothno.Name = "Clothno"
        Me.Clothno.Width = 130
        '
        'Ftype
        '
        Me.Ftype.DataPropertyName = "Ftype"
        Me.Ftype.HeaderText = "ประเภทผ้า"
        Me.Ftype.Name = "Ftype"
        Me.Ftype.Width = 120
        '
        'Fwidth
        '
        Me.Fwidth.DataPropertyName = "Fwidth"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Fwidth.DefaultCellStyle = DataGridViewCellStyle2
        Me.Fwidth.HeaderText = "Fwidth"
        Me.Fwidth.Name = "Fwidth"
        Me.Fwidth.Width = 80
        '
        'Shadeid
        '
        Me.Shadeid.DataPropertyName = "Shadeid"
        Me.Shadeid.HeaderText = "Shadeid"
        Me.Shadeid.Name = "Shadeid"
        Me.Shadeid.Visible = False
        '
        'Shadedesc
        '
        Me.Shadedesc.DataPropertyName = "Shadedesc"
        Me.Shadedesc.HeaderText = "Shaded"
        Me.Shadedesc.Name = "Shadedesc"
        '
        'HaveWgtkg
        '
        Me.HaveWgtkg.DataPropertyName = "HaveWgtkg"
        Me.HaveWgtkg.HeaderText = "น้ำหนัก"
        Me.HaveWgtkg.Name = "HaveWgtkg"
        '
        'Wgtkg
        '
        Me.Wgtkg.DataPropertyName = "Wgtkg"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Wgtkg.DefaultCellStyle = DataGridViewCellStyle3
        Me.Wgtkg.HeaderText = "Wgtkg"
        Me.Wgtkg.Name = "Wgtkg"
        Me.Wgtkg.Visible = False
        '
        'SendWgtkg
        '
        Me.SendWgtkg.DataPropertyName = "SendWgtkg"
        Me.SendWgtkg.HeaderText = "SendWgtkg"
        Me.SendWgtkg.Name = "SendWgtkg"
        Me.SendWgtkg.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Btmsearch, Me.Tbkeyword, Me.ToolStripTextBox2, Me.ToolStripTextBox3, Me.ToolStripTextBox1, Me.Tscball, Me.Tbdyedbillno, Me.Tbcancel})
        Me.ToolStrip1.Location = New System.Drawing.Point(1, 1)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1096, 49)
        Me.ToolStrip1.TabIndex = 29
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
        Me.Tbkeyword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbkeyword.Name = "Tbkeyword"
        Me.Tbkeyword.Size = New System.Drawing.Size(120, 49)
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ToolStripTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ToolStripTextBox2.Enabled = False
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(25, 49)
        '
        'ToolStripTextBox3
        '
        Me.ToolStripTextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ToolStripTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ToolStripTextBox3.Enabled = False
        Me.ToolStripTextBox3.Name = "ToolStripTextBox3"
        Me.ToolStripTextBox3.Size = New System.Drawing.Size(25, 49)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ToolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ToolStripTextBox1.Enabled = False
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(25, 49)
        '
        'Tscball
        '
        Me.Tscball.BackColor = System.Drawing.Color.Transparent
        Me.Tscball.Checked = False
        Me.Tscball.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Tscball.Name = "Tscball"
        Me.Tscball.Size = New System.Drawing.Size(73, 46)
        Me.Tscball.Text = "ทั้งหมด"
        Me.Tscball.ToolStripCheckBoxEnabled = True
        '
        'Tbdyedbillno
        '
        Me.Tbdyedbillno.Name = "Tbdyedbillno"
        Me.Tbdyedbillno.Size = New System.Drawing.Size(50, 49)
        Me.Tbdyedbillno.Visible = False
        '
        'Tbcancel
        '
        Me.Tbcancel.Name = "Tbcancel"
        Me.Tbcancel.Size = New System.Drawing.Size(25, 49)
        Me.Tbcancel.Visible = False
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
        Me.TabControl1.Size = New System.Drawing.Size(1098, 369)
        Me.TabControl1.TabIndex = 5
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.TabItem1)
        Me.TabControl1.Text = "TabControl1"
        '
        'Formlistsalefab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1098, 369)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Formlistsalefab"
        Me.Text = "รายการผ้าที่ขาย"
        Me.TabControlPanel1.ResumeLayout(False)
        Me.TabControlPanel1.PerformLayout()
        CType(Me.Dgvmas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents Btcancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Btok As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Dgvmas As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Btmsearch As ToolStripButton
    Friend WithEvents Tbkeyword As ToolStripTextBox
    Friend WithEvents ToolStripTextBox2 As ToolStripTextBox
    Friend WithEvents ToolStripTextBox3 As ToolStripTextBox
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents Tscball As ToolStripCheckBox
    Friend WithEvents Tbdyedbillno As ToolStripTextBox
    Friend WithEvents Tbcancel As ToolStripTextBox
    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents Checked As DataGridViewCheckBoxColumn
    Friend WithEvents Comid As DataGridViewTextBoxColumn
    Friend WithEvents Dlvno As DataGridViewTextBoxColumn
    Friend WithEvents Lotno As DataGridViewTextBoxColumn
    Friend WithEvents Kongno As DataGridViewTextBoxColumn
    Friend WithEvents Rollno As DataGridViewTextBoxColumn
    Friend WithEvents Clothid As DataGridViewTextBoxColumn
    Friend WithEvents Clothno As DataGridViewTextBoxColumn
    Friend WithEvents Ftype As DataGridViewTextBoxColumn
    Friend WithEvents Fwidth As DataGridViewTextBoxColumn
    Friend WithEvents Shadeid As DataGridViewTextBoxColumn
    Friend WithEvents Shadedesc As DataGridViewTextBoxColumn
    Friend WithEvents HaveWgtkg As DataGridViewTextBoxColumn
    Friend WithEvents Wgtkg As DataGridViewTextBoxColumn
    Friend WithEvents SendWgtkg As DataGridViewTextBoxColumn
End Class
