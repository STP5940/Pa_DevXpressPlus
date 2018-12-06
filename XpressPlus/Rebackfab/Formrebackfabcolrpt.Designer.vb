<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formrebackfabcolrpt
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.Tbkgprice = New Dectextbox.Dectextbox()
        Me.CountDgvmas = New Normtextbox.Normtextbox()
        Me.Dtprecdate = New System.Windows.Forms.TextBox()
        Me.Dgvmas = New System.Windows.Forms.DataGridView()
        Me.Mstat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ord = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mkong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rollno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mcomid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Order = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dhid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mdyedhdesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Billdyedno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lotno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Clothid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mclothno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Clothtype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dwidth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Shadeid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Shadedesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rollwage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Instk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.News = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tbsumwgt = New Dectextbox.Dectextbox()
        Me.Tbdyedcomno = New Normtextbox.Normtextbox()
        Me.Tbsummoney = New Dectextbox.Dectextbox()
        Me.Tbdyedbillno = New Normtextbox.Normtextbox()
        Me.Tbdhname = New Normtextbox.Normtextbox()
        Me.Tbremark = New Normtextbox.Normtextbox()
        Me.FilterLotarray = New System.Windows.Forms.TextBox()
        Me.FilterKongarray = New System.Windows.Forms.TextBox()
        Me.Pricesum = New System.Windows.Forms.TextBox()
        Me.Tstbsumkg = New System.Windows.Forms.TextBox()
        Me.Tbsumprice = New System.Windows.Forms.TextBox()
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
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1.SuspendLayout()
        CType(Me.Dgvmas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel1
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "ใบส่งผ้าสี(ขาย)"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.Tbkgprice)
        Me.TabControlPanel1.Controls.Add(Me.CountDgvmas)
        Me.TabControlPanel1.Controls.Add(Me.Dtprecdate)
        Me.TabControlPanel1.Controls.Add(Me.Dgvmas)
        Me.TabControlPanel1.Controls.Add(Me.Tbsumwgt)
        Me.TabControlPanel1.Controls.Add(Me.Tbdyedcomno)
        Me.TabControlPanel1.Controls.Add(Me.Tbsummoney)
        Me.TabControlPanel1.Controls.Add(Me.Tbdyedbillno)
        Me.TabControlPanel1.Controls.Add(Me.Tbdhname)
        Me.TabControlPanel1.Controls.Add(Me.Tbremark)
        Me.TabControlPanel1.Controls.Add(Me.FilterLotarray)
        Me.TabControlPanel1.Controls.Add(Me.FilterKongarray)
        Me.TabControlPanel1.Controls.Add(Me.Pricesum)
        Me.TabControlPanel1.Controls.Add(Me.Tstbsumkg)
        Me.TabControlPanel1.Controls.Add(Me.Tbsumprice)
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
        'Tbkgprice
        '
        Me.Tbkgprice.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Tbkgprice.Enabled = False
        Me.Tbkgprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbkgprice.Location = New System.Drawing.Point(24, 113)
        Me.Tbkgprice.MaxLength = 12
        Me.Tbkgprice.Name = "Tbkgprice"
        Me.Tbkgprice.Size = New System.Drawing.Size(109, 24)
        Me.Tbkgprice.TabIndex = 208
        Me.Tbkgprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Tbkgprice.Visible = False
        '
        'CountDgvmas
        '
        Me.CountDgvmas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CountDgvmas.Enabled = False
        Me.CountDgvmas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CountDgvmas.Location = New System.Drawing.Point(24, 293)
        Me.CountDgvmas.MaxLength = 150
        Me.CountDgvmas.Name = "CountDgvmas"
        Me.CountDgvmas.Size = New System.Drawing.Size(109, 24)
        Me.CountDgvmas.TabIndex = 207
        Me.CountDgvmas.Visible = False
        '
        'Dtprecdate
        '
        Me.Dtprecdate.Location = New System.Drawing.Point(24, 207)
        Me.Dtprecdate.Name = "Dtprecdate"
        Me.Dtprecdate.Size = New System.Drawing.Size(109, 22)
        Me.Dtprecdate.TabIndex = 206
        Me.Dtprecdate.Visible = False
        '
        'Dgvmas
        '
        Me.Dgvmas.AllowUserToAddRows = False
        Me.Dgvmas.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgvmas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Dgvmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvmas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Mstat, Me.Ord, Me.Mkong, Me.Rollno, Me.Mcomid, Me.Order, Me.Dhid, Me.Mdyedhdesc, Me.Billdyedno, Me.Lotno, Me.Clothid, Me.Mclothno, Me.Clothtype, Me.Dwidth, Me.Shadeid, Me.Shadedesc, Me.Rollwage, Me.Instk, Me.News})
        Me.Dgvmas.Location = New System.Drawing.Point(3, 473)
        Me.Dgvmas.Name = "Dgvmas"
        Me.Dgvmas.ReadOnly = True
        Me.Dgvmas.Size = New System.Drawing.Size(1000, 227)
        Me.Dgvmas.TabIndex = 205
        Me.Dgvmas.Visible = False
        '
        'Mstat
        '
        Me.Mstat.DataPropertyName = "Stat"
        Me.Mstat.HeaderText = ""
        Me.Mstat.Name = "Mstat"
        Me.Mstat.ReadOnly = True
        Me.Mstat.Width = 20
        '
        'Ord
        '
        Me.Ord.DataPropertyName = "Ord"
        Me.Ord.HeaderText = "Ord"
        Me.Ord.Name = "Ord"
        Me.Ord.ReadOnly = True
        Me.Ord.Width = 70
        '
        'Mkong
        '
        Me.Mkong.DataPropertyName = "Kongno"
        Me.Mkong.HeaderText = "เบอร์กอง"
        Me.Mkong.Name = "Mkong"
        Me.Mkong.ReadOnly = True
        Me.Mkong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Rollno
        '
        Me.Rollno.DataPropertyName = "Rollno"
        Me.Rollno.HeaderText = "เบอร์พับ"
        Me.Rollno.Name = "Rollno"
        Me.Rollno.ReadOnly = True
        '
        'Mcomid
        '
        Me.Mcomid.DataPropertyName = "Comid"
        Me.Mcomid.HeaderText = "Comid"
        Me.Mcomid.Name = "Mcomid"
        Me.Mcomid.ReadOnly = True
        Me.Mcomid.Visible = False
        '
        'Order
        '
        Me.Order.DataPropertyName = "Pubno"
        Me.Order.HeaderText = "ลำดับที่"
        Me.Order.Name = "Order"
        Me.Order.ReadOnly = True
        Me.Order.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Order.Visible = False
        '
        'Dhid
        '
        Me.Dhid.DataPropertyName = "Dhid"
        Me.Dhid.HeaderText = "Dhid"
        Me.Dhid.Name = "Dhid"
        Me.Dhid.ReadOnly = True
        Me.Dhid.Visible = False
        '
        'Mdyedhdesc
        '
        Me.Mdyedhdesc.DataPropertyName = "Dyedhdesc"
        Me.Mdyedhdesc.HeaderText = "Dyedhdesc"
        Me.Mdyedhdesc.Name = "Mdyedhdesc"
        Me.Mdyedhdesc.ReadOnly = True
        Me.Mdyedhdesc.Visible = False
        '
        'Billdyedno
        '
        Me.Billdyedno.DataPropertyName = "Billdyedno"
        Me.Billdyedno.HeaderText = "Billdyedno"
        Me.Billdyedno.Name = "Billdyedno"
        Me.Billdyedno.ReadOnly = True
        Me.Billdyedno.Visible = False
        '
        'Lotno
        '
        Me.Lotno.DataPropertyName = "Lotno"
        Me.Lotno.HeaderText = "Lotno"
        Me.Lotno.Name = "Lotno"
        Me.Lotno.ReadOnly = True
        Me.Lotno.Visible = False
        '
        'Clothid
        '
        Me.Clothid.DataPropertyName = "Clothid"
        Me.Clothid.HeaderText = "Clothid"
        Me.Clothid.Name = "Clothid"
        Me.Clothid.ReadOnly = True
        Me.Clothid.Visible = False
        '
        'Mclothno
        '
        Me.Mclothno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Mclothno.DataPropertyName = "Clothno"
        Me.Mclothno.HeaderText = "เบอร์ผ้า"
        Me.Mclothno.Name = "Mclothno"
        Me.Mclothno.ReadOnly = True
        Me.Mclothno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Clothtype
        '
        Me.Clothtype.DataPropertyName = "Ftype"
        Me.Clothtype.HeaderText = "ประเภท"
        Me.Clothtype.Name = "Clothtype"
        Me.Clothtype.ReadOnly = True
        Me.Clothtype.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Clothtype.Width = 130
        '
        'Dwidth
        '
        Me.Dwidth.DataPropertyName = "Fwidth"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Dwidth.DefaultCellStyle = DataGridViewCellStyle5
        Me.Dwidth.HeaderText = "หน้ากว้าง"
        Me.Dwidth.Name = "Dwidth"
        Me.Dwidth.ReadOnly = True
        Me.Dwidth.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        Me.Shadedesc.Width = 140
        '
        'Rollwage
        '
        Me.Rollwage.DataPropertyName = "Rollwage"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.Rollwage.DefaultCellStyle = DataGridViewCellStyle6
        Me.Rollwage.HeaderText = "น้ำหนัก(ก.ก.)"
        Me.Rollwage.Name = "Rollwage"
        Me.Rollwage.ReadOnly = True
        Me.Rollwage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Instk
        '
        Me.Instk.DataPropertyName = "Instk"
        Me.Instk.HeaderText = "Instk"
        Me.Instk.Name = "Instk"
        Me.Instk.ReadOnly = True
        Me.Instk.Visible = False
        '
        'News
        '
        Me.News.HeaderText = "News"
        Me.News.Name = "News"
        Me.News.ReadOnly = True
        Me.News.Visible = False
        '
        'Tbsumwgt
        '
        Me.Tbsumwgt.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Tbsumwgt.Enabled = False
        Me.Tbsumwgt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbsumwgt.Location = New System.Drawing.Point(24, 263)
        Me.Tbsumwgt.MaxLength = 12
        Me.Tbsumwgt.Name = "Tbsumwgt"
        Me.Tbsumwgt.Size = New System.Drawing.Size(109, 24)
        Me.Tbsumwgt.TabIndex = 204
        Me.Tbsumwgt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Tbsumwgt.Visible = False
        '
        'Tbdyedcomno
        '
        Me.Tbdyedcomno.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Tbdyedcomno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Tbdyedcomno.Enabled = False
        Me.Tbdyedcomno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbdyedcomno.Location = New System.Drawing.Point(24, 175)
        Me.Tbdyedcomno.MaxLength = 150
        Me.Tbdyedcomno.Name = "Tbdyedcomno"
        Me.Tbdyedcomno.Size = New System.Drawing.Size(109, 24)
        Me.Tbdyedcomno.TabIndex = 201
        Me.Tbdyedcomno.Visible = False
        '
        'Tbsummoney
        '
        Me.Tbsummoney.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Tbsummoney.Enabled = False
        Me.Tbsummoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbsummoney.Location = New System.Drawing.Point(24, 143)
        Me.Tbsummoney.MaxLength = 12
        Me.Tbsummoney.Name = "Tbsummoney"
        Me.Tbsummoney.Size = New System.Drawing.Size(109, 24)
        Me.Tbsummoney.TabIndex = 200
        Me.Tbsummoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Tbsummoney.Visible = False
        '
        'Tbdyedbillno
        '
        Me.Tbdyedbillno.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Tbdyedbillno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Tbdyedbillno.Enabled = False
        Me.Tbdyedbillno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Tbdyedbillno.Location = New System.Drawing.Point(24, 82)
        Me.Tbdyedbillno.MaxLength = 150
        Me.Tbdyedbillno.Name = "Tbdyedbillno"
        Me.Tbdyedbillno.Size = New System.Drawing.Size(109, 24)
        Me.Tbdyedbillno.TabIndex = 198
        Me.Tbdyedbillno.Visible = False
        '
        'Tbdhname
        '
        Me.Tbdhname.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Tbdhname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Tbdhname.Enabled = False
        Me.Tbdhname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Tbdhname.Location = New System.Drawing.Point(24, 52)
        Me.Tbdhname.MaxLength = 150
        Me.Tbdhname.Name = "Tbdhname"
        Me.Tbdhname.Size = New System.Drawing.Size(109, 24)
        Me.Tbdhname.TabIndex = 197
        Me.Tbdhname.Visible = False
        '
        'Tbremark
        '
        Me.Tbremark.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Tbremark.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Tbremark.Enabled = False
        Me.Tbremark.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbremark.Location = New System.Drawing.Point(24, 235)
        Me.Tbremark.MaxLength = 150
        Me.Tbremark.Multiline = True
        Me.Tbremark.Name = "Tbremark"
        Me.Tbremark.Size = New System.Drawing.Size(109, 22)
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
        Me.TabControl1.TabIndex = 25
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.TabItem1)
        Me.TabControl1.Text = "TabControl1"
        '
        'Formrebackfabcolrpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Formrebackfabcolrpt"
        Me.Text = "ใบรับคืนผ้าสี"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControlPanel1.ResumeLayout(False)
        Me.TabControlPanel1.PerformLayout()
        CType(Me.Dgvmas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents Tbremark As Normtextbox.Normtextbox
    Friend WithEvents FilterLotarray As TextBox
    Friend WithEvents FilterKongarray As TextBox
    Friend WithEvents Pricesum As TextBox
    Friend WithEvents Tstbsumkg As TextBox
    Friend WithEvents Tbsumprice As TextBox
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
    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents Tbdhname As Normtextbox.Normtextbox
    Friend WithEvents Tbdyedbillno As Normtextbox.Normtextbox
    Friend WithEvents Tbsummoney As Dectextbox.Dectextbox
    Friend WithEvents Tbdyedcomno As Normtextbox.Normtextbox
    Friend WithEvents Tbsumwgt As Dectextbox.Dectextbox
    Friend WithEvents Dgvmas As DataGridView
    Friend WithEvents Dtprecdate As TextBox
    Friend WithEvents Mstat As DataGridViewTextBoxColumn
    Friend WithEvents Ord As DataGridViewTextBoxColumn
    Friend WithEvents Mkong As DataGridViewTextBoxColumn
    Friend WithEvents Rollno As DataGridViewTextBoxColumn
    Friend WithEvents Mcomid As DataGridViewTextBoxColumn
    Friend WithEvents Order As DataGridViewTextBoxColumn
    Friend WithEvents Dhid As DataGridViewTextBoxColumn
    Friend WithEvents Mdyedhdesc As DataGridViewTextBoxColumn
    Friend WithEvents Billdyedno As DataGridViewTextBoxColumn
    Friend WithEvents Lotno As DataGridViewTextBoxColumn
    Friend WithEvents Clothid As DataGridViewTextBoxColumn
    Friend WithEvents Mclothno As DataGridViewTextBoxColumn
    Friend WithEvents Clothtype As DataGridViewTextBoxColumn
    Friend WithEvents Dwidth As DataGridViewTextBoxColumn
    Friend WithEvents Shadeid As DataGridViewTextBoxColumn
    Friend WithEvents Shadedesc As DataGridViewTextBoxColumn
    Friend WithEvents Rollwage As DataGridViewTextBoxColumn
    Friend WithEvents Instk As DataGridViewTextBoxColumn
    Friend WithEvents News As DataGridViewTextBoxColumn
    Friend WithEvents CountDgvmas As Normtextbox.Normtextbox
    Friend WithEvents Tbkgprice As Dectextbox.Dectextbox
End Class
