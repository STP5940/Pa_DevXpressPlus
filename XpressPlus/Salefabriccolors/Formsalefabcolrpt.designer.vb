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
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.Tbremark = New Normtextbox.Normtextbox()
        Me.FilterLotarray = New System.Windows.Forms.TextBox()
        Me.DataReport = New System.Windows.Forms.DataGridView()
        Me.No1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kg1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.No2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kg2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.No3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kg3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.No4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kg4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        CType(Me.DataReport, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.TabIndex = 24
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.TabItem1)
        Me.TabControl1.Text = "TabControl1"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.Tbremark)
        Me.TabControlPanel1.Controls.Add(Me.FilterLotarray)
        Me.TabControlPanel1.Controls.Add(Me.DataReport)
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
        'Tbremark
        '
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
        Me.FilterLotarray.Location = New System.Drawing.Point(894, 231)
        Me.FilterLotarray.Name = "FilterLotarray"
        Me.FilterLotarray.Size = New System.Drawing.Size(100, 22)
        Me.FilterLotarray.TabIndex = 195
        Me.FilterLotarray.Visible = False
        '
        'DataReport
        '
        Me.DataReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataReport.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No1, Me.Kg1, Me.No2, Me.Kg2, Me.No3, Me.Kg3, Me.No4, Me.Kg4})
        Me.DataReport.Location = New System.Drawing.Point(109, 91)
        Me.DataReport.Name = "DataReport"
        Me.DataReport.Size = New System.Drawing.Size(643, 155)
        Me.DataReport.TabIndex = 194
        Me.DataReport.Visible = False
        '
        'No1
        '
        Me.No1.HeaderText = "No1"
        Me.No1.Name = "No1"
        Me.No1.ReadOnly = True
        '
        'Kg1
        '
        Me.Kg1.HeaderText = "Kg1"
        Me.Kg1.Name = "Kg1"
        Me.Kg1.ReadOnly = True
        '
        'No2
        '
        Me.No2.HeaderText = "No2"
        Me.No2.Name = "No2"
        Me.No2.ReadOnly = True
        '
        'Kg2
        '
        Me.Kg2.HeaderText = "Kg2"
        Me.Kg2.Name = "Kg2"
        Me.Kg2.ReadOnly = True
        '
        'No3
        '
        Me.No3.HeaderText = "No3"
        Me.No3.Name = "No3"
        Me.No3.ReadOnly = True
        '
        'Kg3
        '
        Me.Kg3.HeaderText = "Kg3"
        Me.Kg3.Name = "Kg3"
        Me.Kg3.ReadOnly = True
        '
        'No4
        '
        Me.No4.HeaderText = "No4"
        Me.No4.Name = "No4"
        Me.No4.ReadOnly = True
        '
        'Kg4
        '
        Me.Kg4.HeaderText = "Kg4"
        Me.Kg4.Name = "Kg4"
        Me.Kg4.ReadOnly = True
        '
        'FilterKongarray
        '
        Me.FilterKongarray.Location = New System.Drawing.Point(788, 203)
        Me.FilterKongarray.Name = "FilterKongarray"
        Me.FilterKongarray.Size = New System.Drawing.Size(100, 22)
        Me.FilterKongarray.TabIndex = 192
        Me.FilterKongarray.Visible = False
        '
        'Pricesum
        '
        Me.Pricesum.Location = New System.Drawing.Point(894, 203)
        Me.Pricesum.Name = "Pricesum"
        Me.Pricesum.Size = New System.Drawing.Size(100, 22)
        Me.Pricesum.TabIndex = 191
        Me.Pricesum.Visible = False
        '
        'Tstbsumkg
        '
        Me.Tstbsumkg.Location = New System.Drawing.Point(894, 175)
        Me.Tstbsumkg.Name = "Tstbsumkg"
        Me.Tstbsumkg.Size = New System.Drawing.Size(100, 22)
        Me.Tstbsumkg.TabIndex = 190
        Me.Tstbsumkg.Visible = False
        '
        'Tbsumprice
        '
        Me.Tbsumprice.Location = New System.Drawing.Point(788, 175)
        Me.Tbsumprice.Name = "Tbsumprice"
        Me.Tbsumprice.Size = New System.Drawing.Size(100, 22)
        Me.Tbsumprice.TabIndex = 189
        Me.Tbsumprice.Visible = False
        '
        'Tbkgprice
        '
        Me.Tbkgprice.Location = New System.Drawing.Point(788, 147)
        Me.Tbkgprice.Name = "Tbkgprice"
        Me.Tbkgprice.Size = New System.Drawing.Size(100, 22)
        Me.Tbkgprice.TabIndex = 188
        Me.Tbkgprice.Visible = False
        '
        'Tbsumkg
        '
        Me.Tbsumkg.Location = New System.Drawing.Point(894, 119)
        Me.Tbsumkg.Name = "Tbsumkg"
        Me.Tbsumkg.Size = New System.Drawing.Size(100, 22)
        Me.Tbsumkg.TabIndex = 187
        Me.Tbsumkg.Visible = False
        '
        'Tbclothno
        '
        Me.Tbclothno.Location = New System.Drawing.Point(788, 91)
        Me.Tbclothno.Name = "Tbclothno"
        Me.Tbclothno.Size = New System.Drawing.Size(100, 22)
        Me.Tbclothno.TabIndex = 186
        Me.Tbclothno.Visible = False
        '
        'Tbshade
        '
        Me.Tbshade.Location = New System.Drawing.Point(788, 119)
        Me.Tbshade.Name = "Tbshade"
        Me.Tbshade.Size = New System.Drawing.Size(100, 22)
        Me.Tbshade.TabIndex = 185
        Me.Tbshade.Visible = False
        '
        'Tbwidth
        '
        Me.Tbwidth.Location = New System.Drawing.Point(894, 91)
        Me.Tbwidth.Name = "Tbwidth"
        Me.Tbwidth.Size = New System.Drawing.Size(100, 22)
        Me.Tbwidth.TabIndex = 184
        Me.Tbwidth.Visible = False
        '
        'Tbcolor
        '
        Me.Tbcolor.Location = New System.Drawing.Point(894, 147)
        Me.Tbcolor.Name = "Tbcolor"
        Me.Tbcolor.Size = New System.Drawing.Size(100, 22)
        Me.Tbcolor.TabIndex = 183
        Me.Tbcolor.Visible = False
        '
        'Tbdlvno
        '
        Me.Tbdlvno.Location = New System.Drawing.Point(894, 35)
        Me.Tbdlvno.Name = "Tbdlvno"
        Me.Tbdlvno.Size = New System.Drawing.Size(100, 22)
        Me.Tbdlvno.TabIndex = 182
        Me.Tbdlvno.Visible = False
        '
        'Tbdate
        '
        Me.Tbdate.Location = New System.Drawing.Point(894, 63)
        Me.Tbdate.Name = "Tbdate"
        Me.Tbdate.Size = New System.Drawing.Size(100, 22)
        Me.Tbdate.TabIndex = 181
        Me.Tbdate.Visible = False
        '
        'Tbcustname
        '
        Me.Tbcustname.Location = New System.Drawing.Point(788, 35)
        Me.Tbcustname.Name = "Tbcustname"
        Me.Tbcustname.Size = New System.Drawing.Size(100, 22)
        Me.Tbcustname.TabIndex = 180
        Me.Tbcustname.Visible = False
        '
        'Tbcustaddr
        '
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
        Me.ReportViewer1.Size = New System.Drawing.Size(1006, 701)
        Me.ReportViewer1.TabIndex = 0
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel1
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "ใบส่งผ้าสี(ขาย)"
        '
        'Formsalefabcolrpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Formsalefabcolrpt"
        Me.Text = "ใบส่งผ้าสี"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.TabControlPanel1.PerformLayout()
        CType(Me.DataReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Tbclothno As TextBox
    Friend WithEvents Tbshade As TextBox
    Friend WithEvents Tbwidth As TextBox
    Friend WithEvents Tbcolor As TextBox
    Friend WithEvents Tbdlvno As TextBox
    Friend WithEvents Tbdate As TextBox
    Friend WithEvents Tbcustname As TextBox
    Friend WithEvents Tbcustaddr As TextBox
    Friend WithEvents Tbsumprice As TextBox
    Friend WithEvents Tbkgprice As TextBox
    Friend WithEvents Tbsumkg As TextBox
    Friend WithEvents Tstbsumkg As TextBox
    Friend WithEvents Pricesum As TextBox
    Friend WithEvents FilterKongarray As TextBox
    Friend WithEvents DataReport As DataGridView
    Friend WithEvents No1 As DataGridViewTextBoxColumn
    Friend WithEvents Kg1 As DataGridViewTextBoxColumn
    Friend WithEvents No2 As DataGridViewTextBoxColumn
    Friend WithEvents Kg2 As DataGridViewTextBoxColumn
    Friend WithEvents No3 As DataGridViewTextBoxColumn
    Friend WithEvents Kg3 As DataGridViewTextBoxColumn
    Friend WithEvents No4 As DataGridViewTextBoxColumn
    Friend WithEvents Kg4 As DataGridViewTextBoxColumn
    Friend WithEvents FilterLotarray As TextBox
    Friend WithEvents Tbremark As Normtextbox.Normtextbox
End Class
