<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formjobcontrollist
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.Dgvlist = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Clothid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Clothno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ftype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dozen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Finwgt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fwidth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qtyroll = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Wgtkg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dlvroll = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Havedoz = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dgvmas = New System.Windows.Forms.DataGridView()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jobno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Custname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Btmsearch = New System.Windows.Forms.ToolStripButton()
        Me.Tbkeyword = New System.Windows.Forms.ToolStripTextBox()
        Me.Tbcancel = New System.Windows.Forms.ToolStripTextBox()
        Me.Btcancel = New DevComponents.DotNetBar.ButtonX()
        Me.Btok = New DevComponents.DotNetBar.ButtonX()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        CType(Me.Dgvlist, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.TabIndex = 11
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.TabItem1)
        Me.TabControl1.Text = "TabControl1"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.Dgvlist)
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
        'Dgvlist
        '
        Me.Dgvlist.AllowUserToAddRows = False
        Me.Dgvlist.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgvlist.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgvlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvlist.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Clothid, Me.Clothno, Me.Ftype, Me.Dozen, Me.Finwgt, Me.Fwidth, Me.Qtyroll, Me.Wgtkg, Me.Dlvroll, Me.Havedoz})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgvlist.DefaultCellStyle = DataGridViewCellStyle2
        Me.Dgvlist.Dock = System.Windows.Forms.DockStyle.Top
        Me.Dgvlist.Location = New System.Drawing.Point(1, 203)
        Me.Dgvlist.Name = "Dgvlist"
        Me.Dgvlist.ReadOnly = True
        Me.Dgvlist.Size = New System.Drawing.Size(382, 28)
        Me.Dgvlist.TabIndex = 30
        Me.Dgvlist.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Stat"
        Me.DataGridViewTextBoxColumn1.HeaderText = ""
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 20
        '
        'Clothid
        '
        Me.Clothid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Clothid.DataPropertyName = "Clothid"
        Me.Clothid.HeaderText = "Clothid"
        Me.Clothid.Name = "Clothid"
        Me.Clothid.ReadOnly = True
        '
        'Clothno
        '
        Me.Clothno.DataPropertyName = "Clothno"
        Me.Clothno.HeaderText = "Clothno"
        Me.Clothno.Name = "Clothno"
        Me.Clothno.ReadOnly = True
        '
        'Ftype
        '
        Me.Ftype.DataPropertyName = "Ftype"
        Me.Ftype.HeaderText = "Ftype"
        Me.Ftype.Name = "Ftype"
        Me.Ftype.ReadOnly = True
        '
        'Dozen
        '
        Me.Dozen.DataPropertyName = "Dozen"
        Me.Dozen.HeaderText = "Dozen"
        Me.Dozen.Name = "Dozen"
        Me.Dozen.ReadOnly = True
        '
        'Finwgt
        '
        Me.Finwgt.DataPropertyName = "Finwgt"
        Me.Finwgt.HeaderText = "Finwgt"
        Me.Finwgt.Name = "Finwgt"
        Me.Finwgt.ReadOnly = True
        '
        'Fwidth
        '
        Me.Fwidth.DataPropertyName = "Fwidth"
        Me.Fwidth.HeaderText = "Fwidth"
        Me.Fwidth.Name = "Fwidth"
        Me.Fwidth.ReadOnly = True
        '
        'Qtyroll
        '
        Me.Qtyroll.DataPropertyName = "Qtyroll"
        Me.Qtyroll.HeaderText = "Qtyroll"
        Me.Qtyroll.Name = "Qtyroll"
        Me.Qtyroll.ReadOnly = True
        '
        'Wgtkg
        '
        Me.Wgtkg.DataPropertyName = "Wgtkg"
        Me.Wgtkg.HeaderText = "Wgtkg"
        Me.Wgtkg.Name = "Wgtkg"
        Me.Wgtkg.ReadOnly = True
        '
        'Dlvroll
        '
        Me.Dlvroll.DataPropertyName = "Dlvroll"
        Me.Dlvroll.HeaderText = "Dlvroll"
        Me.Dlvroll.Name = "Dlvroll"
        Me.Dlvroll.ReadOnly = True
        '
        'Havedoz
        '
        Me.Havedoz.DataPropertyName = "Havedoz"
        Me.Havedoz.HeaderText = "Havedoz"
        Me.Havedoz.Name = "Havedoz"
        Me.Havedoz.ReadOnly = True
        '
        'Dgvmas
        '
        Me.Dgvmas.AllowUserToAddRows = False
        Me.Dgvmas.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgvmas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Dgvmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvmas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Status, Me.Jobno, Me.Custname})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgvmas.DefaultCellStyle = DataGridViewCellStyle5
        Me.Dgvmas.Dock = System.Windows.Forms.DockStyle.Top
        Me.Dgvmas.Location = New System.Drawing.Point(1, 50)
        Me.Dgvmas.Name = "Dgvmas"
        Me.Dgvmas.ReadOnly = True
        Me.Dgvmas.Size = New System.Drawing.Size(382, 153)
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
        'Jobno
        '
        Me.Jobno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Jobno.DataPropertyName = "Jobno"
        Me.Jobno.HeaderText = "เลขที่ใบ Jobcontrol"
        Me.Jobno.Name = "Jobno"
        Me.Jobno.ReadOnly = True
        '
        'Custname
        '
        Me.Custname.DataPropertyName = "Custname"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Custname.DefaultCellStyle = DataGridViewCellStyle4
        Me.Custname.HeaderText = "ลูกค้า"
        Me.Custname.Name = "Custname"
        Me.Custname.ReadOnly = True
        Me.Custname.Width = 150
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Btmsearch, Me.Tbkeyword, Me.Tbcancel})
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
        Me.Tbkeyword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbkeyword.Name = "Tbkeyword"
        Me.Tbkeyword.Size = New System.Drawing.Size(120, 49)
        '
        'Tbcancel
        '
        Me.Tbcancel.Name = "Tbcancel"
        Me.Tbcancel.Size = New System.Drawing.Size(25, 49)
        Me.Tbcancel.Visible = False
        '
        'Btcancel
        '
        Me.Btcancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btcancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Btcancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Btcancel.Location = New System.Drawing.Point(253, 237)
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
        Me.Btok.Location = New System.Drawing.Point(78, 237)
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
        Me.TabItem1.Text = "Jobcontrol"
        '
        'Formjobcontrollist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 331)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Formjobcontrollist"
        Me.Text = "เลขที่ใบ Jobcontrol"
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.TabControlPanel1.PerformLayout()
        CType(Me.Dgvlist, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Tbcancel As ToolStripTextBox
    Friend WithEvents Btcancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Btok As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents Dgvlist As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Clothid As DataGridViewTextBoxColumn
    Friend WithEvents Clothno As DataGridViewTextBoxColumn
    Friend WithEvents Ftype As DataGridViewTextBoxColumn
    Friend WithEvents Dozen As DataGridViewTextBoxColumn
    Friend WithEvents Finwgt As DataGridViewTextBoxColumn
    Friend WithEvents Fwidth As DataGridViewTextBoxColumn
    Friend WithEvents Qtyroll As DataGridViewTextBoxColumn
    Friend WithEvents Wgtkg As DataGridViewTextBoxColumn
    Friend WithEvents Dlvroll As DataGridViewTextBoxColumn
    Friend WithEvents Havedoz As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents Jobno As DataGridViewTextBoxColumn
    Friend WithEvents Custname As DataGridViewTextBoxColumn
End Class
