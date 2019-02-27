<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Balance = New System.Windows.Forms.DataGridView()
        Me.Stat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BDyedcomno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BClothidyed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BClothnoyed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BFtypeyed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BFwidthyed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BQtykg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BShadedesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BQtyroll = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BShadeid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Balance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(176, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 47)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "ใบสั่งย้อม"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button2.Location = New System.Drawing.Point(39, 65)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 47)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "ใบสั่งทอ"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button3.Location = New System.Drawing.Point(313, 65)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(170, 47)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "รับผ้าสีจากโรงย้อม"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button4.Location = New System.Drawing.Point(504, 65)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(116, 47)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "ขายผ้าสี"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button5.Location = New System.Drawing.Point(635, 65)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(170, 47)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "รับผ้าคืนจากลูกค้า"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Balance
        '
        Me.Balance.AllowUserToAddRows = False
        Me.Balance.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Balance.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Balance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Balance.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Stat, Me.BDyedcomno, Me.BClothidyed, Me.BClothnoyed, Me.BFtypeyed, Me.BFwidthyed, Me.BQtykg, Me.BShadedesc, Me.BQtyroll, Me.BShadeid})
        Me.Balance.Location = New System.Drawing.Point(72, 148)
        Me.Balance.Name = "Balance"
        Me.Balance.ReadOnly = True
        Me.Balance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Balance.Size = New System.Drawing.Size(733, 205)
        Me.Balance.TabIndex = 76
        '
        'Stat
        '
        Me.Stat.HeaderText = ""
        Me.Stat.Name = "Stat"
        Me.Stat.ReadOnly = True
        Me.Stat.Width = 20
        '
        'BDyedcomno
        '
        Me.BDyedcomno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.BDyedcomno.HeaderText = "เลขที่ใบสั่งย้อม"
        Me.BDyedcomno.Name = "BDyedcomno"
        Me.BDyedcomno.ReadOnly = True
        '
        'BClothidyed
        '
        Me.BClothidyed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.BClothidyed.HeaderText = "Clothidyed"
        Me.BClothidyed.Name = "BClothidyed"
        Me.BClothidyed.ReadOnly = True
        Me.BClothidyed.Visible = False
        '
        'BClothnoyed
        '
        Me.BClothnoyed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.BClothnoyed.HeaderText = "เบอร์ผ้า"
        Me.BClothnoyed.Name = "BClothnoyed"
        Me.BClothnoyed.ReadOnly = True
        '
        'BFtypeyed
        '
        Me.BFtypeyed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.BFtypeyed.HeaderText = "ประเภท"
        Me.BFtypeyed.Name = "BFtypeyed"
        Me.BFtypeyed.ReadOnly = True
        '
        'BFwidthyed
        '
        Me.BFwidthyed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.BFwidthyed.DefaultCellStyle = DataGridViewCellStyle2
        Me.BFwidthyed.HeaderText = "หน้ากว้าง"
        Me.BFwidthyed.Name = "BFwidthyed"
        Me.BFwidthyed.ReadOnly = True
        '
        'BQtykg
        '
        Me.BQtykg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.BQtykg.HeaderText = "น้ำหนักคงเหลือ"
        Me.BQtykg.Name = "BQtykg"
        Me.BQtykg.ReadOnly = True
        Me.BQtykg.Visible = False
        '
        'BShadedesc
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.BShadedesc.DefaultCellStyle = DataGridViewCellStyle3
        Me.BShadedesc.HeaderText = "Shade"
        Me.BShadedesc.Name = "BShadedesc"
        Me.BShadedesc.ReadOnly = True
        Me.BShadedesc.Width = 130
        '
        'BQtyroll
        '
        Me.BQtyroll.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.BQtyroll.DefaultCellStyle = DataGridViewCellStyle4
        Me.BQtyroll.HeaderText = "จำนวนพับคงเหลือ"
        Me.BQtyroll.Name = "BQtyroll"
        Me.BQtyroll.ReadOnly = True
        '
        'BShadeid
        '
        Me.BShadeid.HeaderText = "BShadeid"
        Me.BShadeid.Name = "BShadeid"
        Me.BShadeid.ReadOnly = True
        Me.BShadeid.Visible = False
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 387)
        Me.Controls.Add(Me.Balance)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FormMain"
        Me.Text = "FormMain"
        CType(Me.Balance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Balance As DataGridView
    Friend WithEvents Stat As DataGridViewTextBoxColumn
    Friend WithEvents BDyedcomno As DataGridViewTextBoxColumn
    Friend WithEvents BClothidyed As DataGridViewTextBoxColumn
    Friend WithEvents BClothnoyed As DataGridViewTextBoxColumn
    Friend WithEvents BFtypeyed As DataGridViewTextBoxColumn
    Friend WithEvents BFwidthyed As DataGridViewTextBoxColumn
    Friend WithEvents BQtykg As DataGridViewTextBoxColumn
    Friend WithEvents BShadedesc As DataGridViewTextBoxColumn
    Friend WithEvents BQtyroll As DataGridViewTextBoxColumn
    Friend WithEvents BShadeid As DataGridViewTextBoxColumn
End Class
