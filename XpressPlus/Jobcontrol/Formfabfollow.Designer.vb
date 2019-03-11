<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formfabfollow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formfabfollow))
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
        Me.ToolStrip4 = New System.Windows.Forms.ToolStrip()
        Me.TabItem2 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Btmclose = New System.Windows.Forms.ToolStripButton()
        Me.Btmfind = New System.Windows.Forms.ToolStripButton()
        Me.Btmreports = New System.Windows.Forms.ToolStripButton()
        Me.Btmcancel = New System.Windows.Forms.ToolStripButton()
        Me.Btmsave = New System.Windows.Forms.ToolStripButton()
        Me.Btmdel = New System.Windows.Forms.ToolStripButton()
        Me.Btmedit = New System.Windows.Forms.ToolStripButton()
        Me.Btmnew = New System.Windows.Forms.ToolStripButton()
        Me.Tstbdocpre = New System.Windows.Forms.ToolStripTextBox()
        Me.Tstbdocpreid = New System.Windows.Forms.ToolStripTextBox()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabControlPanel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.TabControlPanel2.Controls.Add(Me.ToolStrip4)
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
        'ToolStrip4
        '
        Me.ToolStrip4.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip4.Location = New System.Drawing.Point(1, 1)
        Me.ToolStrip4.Name = "ToolStrip4"
        Me.ToolStrip4.Size = New System.Drawing.Size(1006, 25)
        Me.ToolStrip4.TabIndex = 68
        Me.ToolStrip4.Text = "ToolStrip4"
        '
        'TabItem2
        '
        Me.TabItem2.AttachedControl = Me.TabControlPanel2
        Me.TabItem2.Name = "TabItem2"
        Me.TabItem2.Text = "รายการทั้งหมด"
        '
        'TabItem1
        '
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "รายละเอียด"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Btmclose, Me.Btmfind, Me.Btmreports, Me.Btmcancel, Me.Btmsave, Me.Btmdel, Me.Btmedit, Me.Btmnew, Me.Tstbdocpre, Me.Tstbdocpreid})
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
        'Btmfind
        '
        Me.Btmfind.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Btmfind.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btmfind.Image = CType(resources.GetObject("Btmfind.Image"), System.Drawing.Image)
        Me.Btmfind.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btmfind.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btmfind.Name = "Btmfind"
        Me.Btmfind.Size = New System.Drawing.Size(44, 46)
        Me.Btmfind.Text = "ค้นหา"
        Me.Btmfind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Btmreports
        '
        Me.Btmreports.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Btmreports.Enabled = False
        Me.Btmreports.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btmreports.Image = CType(resources.GetObject("Btmreports.Image"), System.Drawing.Image)
        Me.Btmreports.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btmreports.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btmreports.Name = "Btmreports"
        Me.Btmreports.Size = New System.Drawing.Size(41, 46)
        Me.Btmreports.Text = "พิมพ์"
        Me.Btmreports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Btmcancel
        '
        Me.Btmcancel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Btmcancel.Enabled = False
        Me.Btmcancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btmcancel.Image = CType(resources.GetObject("Btmcancel.Image"), System.Drawing.Image)
        Me.Btmcancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btmcancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btmcancel.Name = "Btmcancel"
        Me.Btmcancel.Size = New System.Drawing.Size(47, 46)
        Me.Btmcancel.Text = "ยกเลิก"
        Me.Btmcancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Btmsave
        '
        Me.Btmsave.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Btmsave.Enabled = False
        Me.Btmsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btmsave.Image = CType(resources.GetObject("Btmsave.Image"), System.Drawing.Image)
        Me.Btmsave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btmsave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btmsave.Name = "Btmsave"
        Me.Btmsave.Size = New System.Drawing.Size(47, 46)
        Me.Btmsave.Text = "บันทึก"
        Me.Btmsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Btmdel
        '
        Me.Btmdel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Btmdel.Enabled = False
        Me.Btmdel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btmdel.Image = CType(resources.GetObject("Btmdel.Image"), System.Drawing.Image)
        Me.Btmdel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btmdel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btmdel.Name = "Btmdel"
        Me.Btmdel.Size = New System.Drawing.Size(28, 46)
        Me.Btmdel.Text = "ลบ"
        Me.Btmdel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Btmedit
        '
        Me.Btmedit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Btmedit.Enabled = False
        Me.Btmedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btmedit.Image = CType(resources.GetObject("Btmedit.Image"), System.Drawing.Image)
        Me.Btmedit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btmedit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btmedit.Name = "Btmedit"
        Me.Btmedit.Size = New System.Drawing.Size(44, 46)
        Me.Btmedit.Text = "แก้ไข"
        Me.Btmedit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Btmnew
        '
        Me.Btmnew.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Btmnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btmnew.Image = CType(resources.GetObject("Btmnew.Image"), System.Drawing.Image)
        Me.Btmnew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btmnew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btmnew.Name = "Btmnew"
        Me.Btmnew.Size = New System.Drawing.Size(63, 46)
        Me.Btmnew.Text = "สร้างใหม่"
        Me.Btmnew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'Formfabfollow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Formfabfollow"
        Me.Text = "Formfabfollow"
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabControlPanel2.ResumeLayout(False)
        Me.TabControlPanel2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents ToolStrip4 As ToolStrip
    Friend WithEvents TabItem2 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Btmclose As ToolStripButton
    Friend WithEvents Btmfind As ToolStripButton
    Friend WithEvents Btmreports As ToolStripButton
    Friend WithEvents Btmcancel As ToolStripButton
    Friend WithEvents Btmsave As ToolStripButton
    Friend WithEvents Btmdel As ToolStripButton
    Friend WithEvents Btmedit As ToolStripButton
    Friend WithEvents Btmnew As ToolStripButton
    Friend WithEvents Tstbdocpre As ToolStripTextBox
    Friend WithEvents Tstbdocpreid As ToolStripTextBox
End Class
