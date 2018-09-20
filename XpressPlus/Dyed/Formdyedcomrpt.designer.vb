<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formdyedcomrpt
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
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.Tbpickarea = New System.Windows.Forms.TextBox()
        Me.Tbremark = New System.Windows.Forms.TextBox()
        Me.Tbdate = New System.Windows.Forms.TextBox()
        Me.Tbdyedno = New System.Windows.Forms.TextBox()
        Me.Tbdhname = New System.Windows.Forms.TextBox()
        Me.Tbcustname = New System.Windows.Forms.TextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.SendTo = New System.Windows.Forms.TextBox()
        Me.PickupArea = New System.Windows.Forms.TextBox()
        Me.Note = New System.Windows.Forms.TextBox()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
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
        Me.TabControl1.TabIndex = 22
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.TabItem1)
        Me.TabControl1.Text = "TabControl1"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.Note)
        Me.TabControlPanel1.Controls.Add(Me.PickupArea)
        Me.TabControlPanel1.Controls.Add(Me.SendTo)
        Me.TabControlPanel1.Controls.Add(Me.Tbpickarea)
        Me.TabControlPanel1.Controls.Add(Me.Tbremark)
        Me.TabControlPanel1.Controls.Add(Me.Tbdate)
        Me.TabControlPanel1.Controls.Add(Me.Tbdyedno)
        Me.TabControlPanel1.Controls.Add(Me.Tbdhname)
        Me.TabControlPanel1.Controls.Add(Me.Tbcustname)
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
        'Tbpickarea
        '
        Me.Tbpickarea.Location = New System.Drawing.Point(896, 84)
        Me.Tbpickarea.Name = "Tbpickarea"
        Me.Tbpickarea.Size = New System.Drawing.Size(100, 22)
        Me.Tbpickarea.TabIndex = 6
        Me.Tbpickarea.Visible = False
        '
        'Tbremark
        '
        Me.Tbremark.Location = New System.Drawing.Point(790, 84)
        Me.Tbremark.Name = "Tbremark"
        Me.Tbremark.Size = New System.Drawing.Size(100, 22)
        Me.Tbremark.TabIndex = 5
        Me.Tbremark.Visible = False
        '
        'Tbdate
        '
        Me.Tbdate.Location = New System.Drawing.Point(896, 56)
        Me.Tbdate.Name = "Tbdate"
        Me.Tbdate.Size = New System.Drawing.Size(100, 22)
        Me.Tbdate.TabIndex = 4
        Me.Tbdate.Visible = False
        '
        'Tbdyedno
        '
        Me.Tbdyedno.Location = New System.Drawing.Point(790, 56)
        Me.Tbdyedno.Name = "Tbdyedno"
        Me.Tbdyedno.Size = New System.Drawing.Size(100, 22)
        Me.Tbdyedno.TabIndex = 3
        Me.Tbdyedno.Visible = False
        '
        'Tbdhname
        '
        Me.Tbdhname.Location = New System.Drawing.Point(790, 28)
        Me.Tbdhname.Name = "Tbdhname"
        Me.Tbdhname.Size = New System.Drawing.Size(100, 22)
        Me.Tbdhname.TabIndex = 2
        Me.Tbdhname.Visible = False
        '
        'Tbcustname
        '
        Me.Tbcustname.Location = New System.Drawing.Point(896, 28)
        Me.Tbcustname.Name = "Tbcustname"
        Me.Tbcustname.Size = New System.Drawing.Size(100, 22)
        Me.Tbcustname.TabIndex = 1
        Me.Tbcustname.Visible = False
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
        Me.TabItem1.Text = "ใบสั่งย้อม"
        '
        'SendTo
        '
        Me.SendTo.Location = New System.Drawing.Point(896, 112)
        Me.SendTo.Name = "SendTo"
        Me.SendTo.Size = New System.Drawing.Size(100, 22)
        Me.SendTo.TabIndex = 7
        Me.SendTo.Visible = False
        '
        'PickupArea
        '
        Me.PickupArea.Location = New System.Drawing.Point(790, 112)
        Me.PickupArea.Name = "PickupArea"
        Me.PickupArea.Size = New System.Drawing.Size(100, 22)
        Me.PickupArea.TabIndex = 8
        Me.PickupArea.Visible = False
        '
        'Note
        '
        Me.Note.Location = New System.Drawing.Point(896, 140)
        Me.Note.Name = "Note"
        Me.Note.Size = New System.Drawing.Size(100, 22)
        Me.Note.TabIndex = 9
        Me.Note.Visible = False
        '
        'Formdyedcomrpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Formdyedcomrpt"
        Me.Text = "ใบสั่งย้อม"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.TabControlPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents Tbdate As TextBox
    Friend WithEvents Tbdyedno As TextBox
    Friend WithEvents Tbdhname As TextBox
    Friend WithEvents Tbcustname As TextBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents Tbremark As TextBox
    Friend WithEvents Tbpickarea As TextBox
    Friend WithEvents SendTo As TextBox
    Friend WithEvents PickupArea As TextBox
    Friend WithEvents Note As TextBox
End Class
