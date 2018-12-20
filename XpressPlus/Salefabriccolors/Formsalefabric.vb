Imports System.ComponentModel
Imports Microsoft.Reporting.WinForms
Public Class Formsalefabric
    Private Tmaster, Tdetails, Tlist, Stocklist, Dttemp, Dtstocktemp, Kongno, KongnoKg, REData As DataTable
    Private Pagecount, Pagestockcount, Maxrec, Maxstockrec, Pagesize, Pagestocksize, Currentpage, Currenstocktpage, Recno, Restockcno As Integer
    Private WithEvents Dtplistfm As New DateTimePicker
    Private WithEvents Dtplistto As New DateTimePicker
    Private Bs As BindingSource

    Private Sub Formsalefabric_Load(sender As Object, e As EventArgs) Handles Me.Load
        Mainbuttoncancel()
        Controls.Add(Dtplistfm)
        Controls.Add(Dtplistto)
        Dtplistfm.Value = Now
        Dtplistto.Value = Now
        Dtplistfm.Width = 130
        Dtplistto.Width = 130
        Me.ToolStrip4.Items.Insert(4, New ToolStripControlHost(Dtplistto))
        Me.ToolStrip4.Items(4).Alignment = ToolStripItemAlignment.Right
        Me.ToolStrip4.Items.Insert(6, New ToolStripControlHost(Dtplistfm))
        Me.ToolStrip4.Items(6).Alignment = ToolStripItemAlignment.Right
        Me.ToolStrip4.Items(6).Visible = False
        Me.ToolStrip4.Items(4).Visible = False
        '  Setauthorize()
        Retdocprefix()
        Tbmycom.Text = Trim(Gscomname)
    End Sub
    Private Sub Formsalefabric_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dgvlist.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        Dgvlist.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        Dgvmas.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        Dgvmas.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        Dgvstock.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        Dgvstock.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        Bindingstock()
        Bindinglist()
    End Sub
    Private Sub Btmnew_Click(sender As Object, e As EventArgs) Handles Btmnew.Click
        Clrdgrid()
        Clrtxtbox()
        TabControl1.SelectedTabIndex = 2

        Clrtextmaster()
        Clrtextdetails()
        Clrgridmaster()
        TabControl1.SelectedTabIndex = 2
        Btfindshade.Enabled = True
        BindingNavigator1.Enabled = False
        'Tbfinddhid.Enabled = True
        'Tbpickup.Enabled = True
        Btfindcustid.Enabled = True
        Btfindcusship.Enabled = True
        Btfindclothno.Enabled = True
        Tbkgprice.Enabled = True
        Tbcolorno.Enabled = True
        Btfindlotno.Enabled = True
        'Btdadd.Enabled = True
        Btdcancel.Enabled = True
        Btdbadd.Enabled = True
        Btdedit.Enabled = True
        Btddel.Enabled = True

        Tbkgprice.Enabled = True
        Tbremark.Enabled = True
        Dtpdate.Enabled = True
        Dgvmas.Enabled = True
        Mainbuttonaddedit()
    End Sub
    Private Sub Btmsave_Click(sender As Object, e As EventArgs) Handles Btmsave.Click
        If Tstbdocpre.Text = "" Then
            Informmessage("กรุณาติดต่อ Admin เพื่อกำหนด Prefix ของเลขที่เอกสาร")
            Exit Sub
        End If
        If Validmas() = False Then
            Informmessage("กรุณาตรวจสอบข้อมูลในการขายผ้าสีให้ครบถ้วน")
            Exit Sub
        End If
        If Validdet() = False Then
            Informmessage("กรุณาตรวจสอบรายละเอียดในการขายผ้าสีให้ครบถ้วน")
            Exit Sub
        End If
        If Tbdlvno.Text = "NEW" Then
            Newdoc()
        Else
            Editdoc()
        End If
        Tsbwsave.Visible = False
        Btmreports_Click(sender, e)
        Btdcancel_Click(sender, e)
        Tsbwsave.Visible = False
        Clrtextmaster()
        Clrtextdetails()
        Clrgridmaster()
        Bindingstock()
        Bindinglist()
        TabControl1.SelectedTabIndex = 0
        BindingNavigator1.Enabled = False
        Mainbuttoncancel()
    End Sub
    Private Sub Btmdel_Click(sender As Object, e As EventArgs) Handles Btmdel.Click
        If Trim(Tbdlvno.Text) = "NEW" Then
            Exit Sub
        End If
        If Trim(Tbdlvno.Text) = "" Then
            Exit Sub
        End If
        If Confirmdelete() = True Then
            Deldetails(Trim(Tbdlvno.Text))
            SQLCommand("DELETE FROM Tsalefabcolxp WHERE Comid = '" & Gscomid & "' AND Dlvno = '" & Trim(Tbdlvno.Text) & "'")
            Clrdgrid()
            Clrtxtbox()
            Clrtextmaster()
            Clrtextdetails()
            Clrgridmaster()
            Bindingstock()
            Bindinglist()
            TabControl1.SelectedTabIndex = 0
            BindingNavigator1.Enabled = False
            Mainbuttoncancel()
        End If

        '------
        'If Confirmdelete() = True Then
        '    Deldetails(Trim(Tbdyedcomno.Text))
        '    SQLCommand("DELETE FROM Tdyedcomxp WHERE Comid = '" & Gscomid & "' AND Dyecomno = '" & Trim(Tbdyedcomno.Text) & "'")
        '    Clrtextmaster()
        '    Clrtextdetails()
        '    Clrgridmaster()
        '    Bindinglist()
        '    TabControl1.SelectedTabIndex = 0
        '    BindingNavigator1.Enabled = False
        '    Mainbuttoncancel()
        'End If
    End Sub
    Private Sub Btmreports_Click(sender As Object, e As EventArgs) Handles Btmreports.Click
        'Dgvmas.Sort(SaleFtype, System.ComponentModel.ListSortDirection.Descending)
        Dgvmas.Sort(Dgvmas.Columns(5), ListSortDirection.Ascending)

        If Dgvmas.RowCount = 0 Then
            Exit Sub
        End If
        If Tsbwsave.Visible = True Then
            Informmessage("มีการเปลี่ยนแปลงและยังไม่ทำการบันทึก")
            Exit Sub
        End If
        Binddetails()
        ''Salefab()
        'Exit Sub

        Dim Frm As New Formsalefabcolrpt
        'Frm.ReportViewer1.ShowPrintButton = True
        'Frm.DataReport.Rows(0).Cells("Kg1").Value = DataSalefab.Rows(0).Cells("Kg1").Value

        ''For i = 0 To DataSalefab.Rows.Count - 1
        ''    Frm.DataReport.Rows.Add()
        ''    Frm.DataReport.Rows(i).Cells("No1").Value = DataSalefab.Rows(i).Cells("No1").Value
        ''    Frm.DataReport.Rows(i).Cells("Kg1").Value = DataSalefab.Rows(i).Cells("Kg1").Value
        ''    Frm.DataReport.Rows(i).Cells("No2").Value = DataSalefab.Rows(i).Cells("No2").Value
        ''    Frm.DataReport.Rows(i).Cells("Kg2").Value = DataSalefab.Rows(i).Cells("Kg2").Value
        ''    Frm.DataReport.Rows(i).Cells("No3").Value = DataSalefab.Rows(i).Cells("No3").Value
        ''    Frm.DataReport.Rows(i).Cells("Kg3").Value = DataSalefab.Rows(i).Cells("Kg3").Value
        ''    Frm.DataReport.Rows(i).Cells("No4").Value = DataSalefab.Rows(i).Cells("No4").Value
        ''    Frm.DataReport.Rows(i).Cells("Kg4").Value = DataSalefab.Rows(i).Cells("Kg4").Value
        ''Next

        ''ClearSalefab()

        Frm.ReportViewer1.Reset()
        Frm.Tbcustname.Text = Trim(Tbcustname.Text)
        Frm.Tbcustaddr.Text = Trim(Tbcustship.Text)
        Frm.Tbclothno.Text = Trim(Tbclothno.Text)
        Frm.Tbwidth.Text = Trim(Tbwidth.Text)
        Frm.Tbdlvno.Text = Trim(Tbdlvno.Text)
        'MsgBox(Format(Dtpdate.Value, "dd/MM/yyyy"))
        Frm.Tbdate.Text = Format(Dtpdate.Value, "dd/MM/yyyy")
        Frm.Tbshade.Text = Trim(Tbshadename.Text)
        Frm.Tbcolor.Text = Trim(Tbcolorno.Text)
        Frm.Tbsumkg.Text = Trim(Tbsumwgt.Text)
        Frm.Tbkgprice.Text = Trim(Tbkgprice.Text)
        Frm.Tbsumprice.Text = Trim(Tbsummoney.Text)
        Frm.Tstbsumkg.Text = Trim(Tstbsumkg.Text)
        Frm.Tbremark.Text = Trim(Tbremark.Text)

        '--------'
        Dim FilterKongarray As New List(Of String)()
        For I = 0 To Dgvmas.RowCount - 1
            If I = 0 Then
                FilterKongarray.Add(Dgvmas.Rows(I).Cells("Mkongno").Value)
                Continue For
            End If
            For x = 0 To FilterKongarray.Count - 1
                If FilterKongarray(x) = Dgvmas.Rows(I).Cells("Mkongno").Value Then
                    Exit For
                Else
                    If x = FilterKongarray.Count - 1 Then
                        FilterKongarray.Add(Dgvmas.Rows(I).Cells("Mkongno").Value)
                    End If
                End If
            Next
        Next
        For I = 0 To FilterKongarray.Count - 1
            If I = 0 Then
                Frm.FilterKongarray.Text = FilterKongarray(I)
            Else
                Frm.FilterKongarray.Text += $",{FilterKongarray(I)}"
            End If
        Next

        '--------'
        Dim FilterLotarray As New List(Of String)()
        For I = 0 To Dgvmas.RowCount - 1
            If I = 0 Then
                FilterLotarray.Add(Dgvmas.Rows(I).Cells("Mkongno").Value)
                Continue For
            End If
            For x = 0 To FilterLotarray.Count - 1
                If FilterLotarray(x) = Dgvmas.Rows(I).Cells("Mkongno").Value Then
                    Exit For
                Else
                    If x = FilterLotarray.Count - 1 Then
                        FilterLotarray.Add(Dgvmas.Rows(I).Cells("Mkongno").Value)
                    End If
                End If
            Next
        Next
        For I = 0 To FilterLotarray.Count - 1
            If I = 0 Then
                Frm.FilterLotarray.Text = FilterLotarray(I)
            Else
                Frm.FilterLotarray.Text += $",{FilterLotarray(I)}"
            End If
        Next

        '--------'

        'If Gsexpau = False Then
        '    Frm.ReportViewer1.ShowExportButton = False
        'End If
        'If Gspriau = False Then
        '    Frm.ReportViewer1.ShowPrintButton = False
        'End If

        Dim Rds, Rds1 As New ReportDataSource()
        Rds.Name = "DataSetSale"
        Rds.Value = Tdetails
        Frm.ReportViewer1.LocalReport.DataSources.Add(Rds)

        'Rds1.Name = "DataGridReport"
        'Rds1.Value = DataSalefab.DataSource
        'Frm.ReportViewer1.LocalReport.DataSources.Add(Rds1)
        'Showform(Frm)
        Frm.Show()
        Sumall()
        Clrtextmaster()
        Clrtextdetails()
        Clrgridmaster()
        BindingNavigator1.Enabled = False
        Mainbuttoncancel()
        TabControl1.SelectedTabIndex = 1
    End Sub
    Private Sub Btmfind_Click(sender As Object, e As EventArgs) Handles Btmfind.Click
        TabControl1.SelectedTabIndex = 0
        Tstbstockkeyword.Select()
        Tstbstockkeyword.Focus()
    End Sub
    Private Sub Btmclose_Click(sender As Object, e As EventArgs) Handles Btmclose.Click
        Me.Close()
    End Sub
    Private Sub Tscbdate_CheckedChanged(sender As Object, e As EventArgs) Handles Tscbdate.CheckedChanged
        If Tscbdate.Checked = True Then
            Tscboth.Checked = False
            Tstbkeyword.Visible = False
            Dtplistfm.Visible = True
            Dtplistto.Visible = True
            Btrefresh.Visible = True
        Else
            Tscboth.Checked = True
            Btrefresh.Visible = False
            Dtplistfm.Visible = False
            Dtplistto.Visible = False
            Tstbkeyword.Visible = True
            Tstbkeyword.Select()
            Tstbkeyword.Focus()
        End If
    End Sub
    Private Sub Tscboth_CheckedChanged(sender As Object, e As EventArgs) Handles Tscboth.CheckedChanged
        If Tscboth.Checked = True Then
            Tscbdate.Checked = False
            Btrefresh.Visible = False
            Dtplistfm.Visible = False
            Dtplistto.Visible = False
            Tstbkeyword.Visible = True
            Tstbkeyword.Select()
            Tstbkeyword.Focus()
        Else
            Tstbkeyword.Visible = False
            Tscbdate.Checked = True
            Dtplistfm.Visible = True
            Dtplistto.Visible = True
            Btrefresh.Visible = True
        End If
    End Sub
    Private Sub Tstbkeyword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tstbkeyword.KeyPress
        e.Handled = (Asc(e.KeyChar) = 39)
    End Sub
    Private Sub Tstbkeyword_TextChanged(sender As Object, e As EventArgs) Handles Tstbkeyword.TextChanged
        If Me.Created Then
            Btlistfind_Click(sender, e)
        End If
    End Sub
    Private Sub Tstbstockkeyword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tstbstockkeyword.KeyPress
        e.Handled = (Asc(e.KeyChar) = 39)
    End Sub
    Private Sub Tstbstockkeyword_TextChanged(sender As Object, e As EventArgs) Handles Tstbstockkeyword.TextChanged
        If Me.Created Then
            Btliststockfind_Click(sender, e)
        End If
        If Tstbstockkeyword.Text = "--version" Or Tstbstockkeyword.Text = "-V" Then
            Informmessage("28/11/2018 15:00")
        End If
        If Tstbstockkeyword.Text = "--report" Then
            Dim frm As New Formsalefabcolrpt
            frm.VersionReport()
        End If
    End Sub
    Private Sub Btlistfind_Click(sender As Object, e As EventArgs) Handles Btlistfind.Click
        If Tscbdate.Checked = True Then
            Searchlistbydate()
        End If
        If Tscboth.Checked = True Then
            Searchlistbyoth(Trim(Tstbkeyword.Text))
        End If
    End Sub
    Private Sub Btrefresh_Click(sender As Object, e As EventArgs) Handles Btrefresh.Click
        Bindinglist()
    End Sub
    Private Sub Ctmledit_Click(sender As Object, e As EventArgs) Handles Ctmledit.Click
        Clrdgrid()
        Clrtxtbox()
        Btdcancel_Click(sender, e)
        TabControl1.SelectedTabIndex = 2
        Tbdlvno.Text = Trim(Dgvlist.CurrentRow.Cells("Dlvno").Value)
        Tbdlvno.DataBindings.Clear()
        Tbdlvno.Text = ""
        Bs.Position = Bs.Find("Dlvno", Trim(Dgvlist.CurrentRow.Cells("Dlvno").Value))
        Tbdlvno.DataBindings.Add("Text", Bs, "Dlvno")
        Tbdlvno.Enabled = False
        Bindmaster()
        BindingNavigator1.Enabled = True
        'Btmnew.Enabled = False
        Btmnew.Enabled = False
        Btmedit.Enabled = True
        Btmdel.Enabled = True
        Btmsave.Enabled = False
        Btmcancel.Enabled = False
        Btmreports.Enabled = True
        Btfindcustid.Enabled = False
        Btfindcusship.Enabled = False
        Btfindclothno.Enabled = False
        Btfindshade.Enabled = False
        Tbcolorno.Enabled = False
        Tbkgprice.Enabled = False
        Tbremark.Enabled = False
        Dtpdate.Enabled = False
        Btdbadd.Enabled = False
        Btddel.Enabled = False
        'Btdadd.Enabled = False
        'Btdedit.Enabled = False
        'Btddel.Enabled = False
        'Ctdedit.Enabled = False
        'Ctddel.Enabled = False
        'Dgvmas.Enabled = True
    End Sub
    Friend Sub Showtransaction(transactionRefab As String)
        Clrdgrid()
        Clrdetails()
        TabControl1.SelectedTabIndex = 2
        Tbdlvno.Text = Trim(transactionRefab)
        Tbdlvno.Enabled = False
        Bindmaster()
        If Dgvmas.RowCount > 0 Then
            Dgvmas.Rows(0).Selected = False
        End If
        BindingNavigator1.Enabled = True
        Btmnew.Enabled = False
        Btmedit.Enabled = True
        Btmdel.Enabled = True
        Btmsave.Enabled = False
        Btmcancel.Enabled = True
        Btmreports.Enabled = True
        Tbremark.Enabled = False
        Btdedit.Enabled = False
        Btdcancel.Enabled = False
        GroupPanel2.Visible = False
        Btdbadd.Enabled = False
        Btddel.Enabled = False
        Dgvmas.Enabled = False
        Tbremark.Enabled = False
    End Sub
    'Private Sub Ctmldel_Click(sender As Object, e As EventArgs)
    '    Ctmledit_Click(sender, e)
    '    Btmdel_Click(sender, e)
    '    Bindingstock()
    '    Bindinglist()
    '    TabControl1.SelectedTabIndex = 0
    'End Sub
    Private Sub Dgvlist_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvlist.CellClick
        If Dgvlist.RowCount = 0 Then
            Exit Sub
        End If
        Dgvlist.CurrentRow.Selected = True
    End Sub
    Private Sub Dgvlist_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Dgvlist.CellMouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If Me.Dgvlist.Rows.Count < 1 Then Exit Sub
            If e.RowIndex < 0 Then Exit Sub
            Dgvlist.CurrentCell = Dgvlist(3, e.RowIndex)
            Me.Dgvlist.Rows(e.RowIndex).Selected = True
            Editcontextlistmenu()
        End If
    End Sub
    Private Sub Dgvstock_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Dgvstock.CellMouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If Me.Dgvstock.Rows.Count < 1 Then Exit Sub
            If e.RowIndex < 0 Then Exit Sub
            Me.Dgvstock.Rows(e.RowIndex).Selected = True
            Editcontextstockmenu()
        End If
    End Sub
    Private Sub Btfirst_Click(sender As Object, e As EventArgs) Handles Btfirst.Click
        Befirst()
    End Sub
    Private Sub Btprev_Click(sender As Object, e As EventArgs) Handles Btprev.Click
        Beprev()
    End Sub
    Private Sub Btnext_Click(sender As Object, e As EventArgs) Handles Btnext.Click
        Benext()
    End Sub
    Private Sub Btlast_Click(sender As Object, e As EventArgs) Handles Btlast.Click
        Belast()
    End Sub

    '---------------------- Start footer Stock -------------------'
    Private Sub Btstockfirst_Click(sender As Object, e As EventArgs) Handles Btstockfirst.Click
        Bestockfirst()
    End Sub

    Private Sub Btstockprev_Click(sender As Object, e As EventArgs) Handles Btstockprev.Click
        Bestockprev()
    End Sub

    Private Sub Btstocknext_Click(sender As Object, e As EventArgs) Handles Btstocknext.Click
        Bestocknext()
    End Sub

    Private Sub Btstocklast_Click(sender As Object, e As EventArgs) Handles Btstocklast.Click
        Bestocklast()
    End Sub
    '---------------------- End footer Stock -------------------'

    Private Sub Btfindcustid_Click(sender As Object, e As EventArgs)
        Dim Frm As New Formcustomerslist
        Showdiaformcenter(Frm, Me)
        If Frm.Tbcancel.Text = "C" Then
            Exit Sub
        End If
        Tbcustid.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Mid").Value)
        Tbcustname.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Mname").Value)
        Btfindcusship.Focus()
    End Sub
    Private Sub Btfindcusship_Click(sender As Object, e As EventArgs)
        If Tbcustid.Text = "" Then
            Informmessage("กรุณาเลือกข้อมูลลูกค้า")
            Exit Sub
        End If
        Dim Frm As New Formcustshiplist
        Frm.Tbcustid.Text = Tbcustid.Text
        Showdiaformcenter(Frm, Me)
        If Frm.Tbcancel.Text = "C" Then
            Exit Sub
        End If
        Tbcusadd.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Mord").Value)
        Tbcustship.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Mshaddr").Value)
    End Sub
    Private Sub Btfindclothno_Click(sender As Object, e As EventArgs)
        Dim Frm As New Formfabrictypelist
        Showdiaformcenter(Frm, Me)
        If Frm.Tbcancel.Text = "C" Then
            Exit Sub
        End If
        Tbclothid.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Mid").Value)
        Tbclothno.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Mname").Value)
        Tbwidth.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Fwidth").Value)
        Tbkgprice.Focus()
    End Sub
    Private Sub Btfindlotno_Click(sender As Object, e As EventArgs)
        Dim Frm As New Formsalefablotnolist
        Frm.Tbclothid.Text = Trim(Tbclothid.Text)
        Showdiaformcenter(Frm, Me)
        If Frm.Tbcancel.Text = "C" Then
            Exit Sub
        End If
        Tblotno.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Mlotno").Value)
        Tbkongno.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Kongno").Value)
        Tbshadeid.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Mshadeid").Value)
        Tbshadename.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Shadedesc").Value)
        Findshadeanddyecolor()
    End Sub
    Private Sub Btdadd_Click(sender As Object, e As EventArgs)
        Dim Frm As New Formfabrolllist
        Frm.Tblotno.Text = Trim(Tblotno.Text)
        Frm.Tbkongno.Text = Trim(Tbkongno.Text)
        Frm.Tbclothid.Text = Trim(Tbclothid.Text)
        Showdiaformcenter(Frm, Me)
        If Frm.Tbcancel.Text = "C" Then
            Exit Sub
        End If
        Dim I As Integer
        For I = 0 To Frm.Dgvmas.RowCount - 1
            If Frm.Dgvmas.Rows(I).Cells("Mchoose").Value = True Then
                Dim Trollno As String
                Trollno = Frm.Dgvmas.Rows(I).Cells("Rollno").Value
                If Chkdupyarnidingrid(Trim(Tblotno.Text), Trim(Tbkongno.Text), Trollno) = True Then
                Else
                    If Tbdlvno.Text = "NEW" Then
                        Dgvmas.Rows.Add()
                    Else
                        Tdetails.Rows.Add()
                    End If
                    Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Dlot").Value = Trim(Tblotno.Text)
                    Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Mkongno").Value = Trim(Tbkongno.Text)
                    Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Rollno").Value = Trollno
                    Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Qtykg").Value = CDbl(Frm.Dgvmas.Rows(I).Cells("Rollwage").Value)
                End If
            End If
        Next
        'If Validmas() = False Then
        '    Informmessage("กรุณาเลือกลูกค้าและที่ส่ง")
        '    Exit Sub
        'End If
        'If Validinput() = False Then
        '    Informmessage("กรุณาตรวจสอบข้อมูลให้ถูกต้อง ครบถ้วน")
        '    Exit Sub
        'End If
        'If Validnumber() = False Then
        '    Informmessage("กรุณาตรวจจำนวนให้ถูกต้อง ครบถ้วน")
        '    Exit Sub
        'End If
        If Tbaddedit.Text = "เพิ่ม" Then

        End If

        Sumall()
        'Btdcancel_Click(sender, e)
        'Tbremark.Focus()
    End Sub
    Private Sub Btddel_Click(sender As Object, e As EventArgs)
        If Dgvmas.RowCount = 0 Then
            Exit Sub
        End If
        Btdcancel_Click(sender, e)
        Tsbwsave.Visible = True
        Dgvmas.Rows.Remove(Dgvmas.CurrentRow)
        Sumall()
    End Sub
    Private Sub Dgvmas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvmas.CellClick
        If e.RowIndex <> -1 Then
            Tblotno.Text = Dgvmas.Rows(e.RowIndex).Cells("Dlot").Value
            Tbkongno.Text = Dgvmas.Rows(e.RowIndex).Cells("Mkongno").Value
            Rollnobox.Text = Dgvmas.Rows(e.RowIndex).Cells("Rollno").Value
            Qtykgbox.Text = Dgvmas.Rows(e.RowIndex).Cells("Qtykg").Value
        End If

        If Dgvmas.RowCount = 0 Then
            Exit Sub
        End If
        Dgvmas.CurrentRow.Selected = True
    End Sub
    Private Sub Dgvmas_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If Me.Dgvmas.Rows.Count < 1 Then Exit Sub
            If e.RowIndex < 0 Then Exit Sub
            Dgvmas.CurrentCell = Dgvmas(3, e.RowIndex)
            Me.Dgvmas.Rows(e.RowIndex).Selected = True
            Editcontextdetmenu()
        End If
    End Sub
    Private Sub Ctddel_Click(sender As Object, e As EventArgs)
        Btddel_Click(sender, e)
    End Sub
    Private Sub Formsalefabric_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Tbdlvno.Text = "NEW" And Dgvmas.RowCount = 0 Then
            '  My.Forms.Formmain.Panel1.Visible = True
            Exit Sub
        End If
        If Confirmcloseform("ขายผ้าสี") Then
            e.Cancel = False
            ' My.Forms.Formmain.Panel1.Visible = True
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub Searchlistbyoth(Sval As String)
        If Sval = "" Then
            Bindinglist()
            Exit Sub
        End If
        Tlist = SQLCommand("SELECT '' AS Stat,* FROM Vsalefabcolmas
                                WHERE Comid = '" & Gscomid & "' AND (Custname LIKE '%' + '" & Sval & "' + '%' OR Dlvno LIKE '%' + '" & Sval & "' + '%' OR Clothno LIKE '%' + '" & Sval & "' + '%' OR Dremark LIKE '%' + '" & Sval & "' + '%')")
        'Custname LIKE '%' + '" & Sval & "' + '%' OR Dlvno LIKE '%' + '" & Sval & "' + '%' OR Clothno LIKE '%' + '" & Sval & "' + '%' OR Dremark LIKE '%' + '" & Sval & "' + '%'
        FillGrid()
        ShowRecordDetail()
    End Sub
    Private Sub Searchstocklistbyoth(Sval As String)
        If Sval = "" Then
            Bindingstock()
            Exit Sub
        End If
        Stocklist = SQLCommand($"SELECT dbo.Vsalestock.Comid, dbo.Trecfabcolxp.Reid, dbo.Vsalestock.Dhid, 
                                    dbo.Vsalestock.Dyedhdesc, dbo.Vsalestock.Lotno, dbo.Vsalestock.Kongno, 
                                    dbo.Vsalestock.Clothid, dbo.Vsalestock.Clothno, dbo.Vsalestock.Ftype, 
                                    dbo.Vsalestock.Fwidth, dbo.Vsalestock.Shadeid, dbo.Vsalestock.Shadedesc, 
                                    COUNT(*) AS Cunt, SUM(dbo.Vsalestock.Rollwage) AS Rollwage
                            FROM dbo.Vsalestock INNER JOIN dbo.Trecfabcolxp 
                                    ON dbo.Vsalestock.Comid = dbo.Trecfabcolxp.Comid 
                                    AND dbo.Vsalestock.Lotno = dbo.Trecfabcolxp.Lotno
                                    AND (Reid LIKE '%{Sval}%' OR 
                                         dbo.Vsalestock.Lotno LIKE '%{Sval}%' OR 
                                         Kongno LIKE '%{Sval}%' OR 
                                         Ftype LIKE '%{Sval}%' OR 
                                         Shadedesc LIKE '%{Sval}%' OR 
                                         Rollwage LIKE '%{Sval}%' OR 
                                         Clothno LIKE '%{Sval}%')
                            WHERE (dbo.Vsalestock.Comid = '{Gscomid}')
                            GROUP BY dbo.Vsalestock.Comid, dbo.Vsalestock.Dyedhdesc, dbo.Vsalestock.Lotno, 
                                    dbo.Vsalestock.Kongno, dbo.Vsalestock.Clothid, dbo.Vsalestock.Clothno, 
                                    dbo.Vsalestock.Ftype, dbo.Vsalestock.Fwidth, dbo.Vsalestock.Shadeid, 
                                    dbo.Vsalestock.Shadedesc, dbo.Trecfabcolxp.Reid, dbo.Vsalestock.Dhid")

        'Custname LIKE '%' + '" & Sval & "' + '%' OR Dlvno LIKE '%' + '" & Sval & "' + '%' OR Clothno LIKE '%' + '" & Sval & "' + '%' OR Dremark LIKE '%' + '" & Sval & "' + '%'
        FillstockGrid()
        ShowRecordStockDetail()
    End Sub
    Private Sub Searchlistbydate()
        Tlist = SQLCommand("SELECT '' AS Stat,* FROM Vsalefabcolmas
                                WHERE Comid = '" & Gscomid & "' AND (Dfabdate BETWEEN '" & Formatshortdatesave(Dtplistfm.Value) & "' AND '" & Formatshortdatesave(Dtplistto.Value) & "')")
        FillGrid()
        ShowRecordDetail()
    End Sub
    Private Sub Retdocprefix()
        Dim Tdocpre = New DataTable
        Tdocpre = SQLCommand("SELECT Docid,Prefix FROM Tdocprexp WHERE Comid = '" & Gscomid & "' AND 
                            Docid = (SELECT Docid FROM Tdocpredetxp WHERE Comid = '" & Gscomid & "' AND Mid = '" & Trim(Me.Tag) & "')")
        If Tdocpre.Rows.Count > 0 Then
            Tstbdocpreid.Text = Trim(Tdocpre.Rows(0)("Docid"))
            Tstbdocpre.Text = Trim(Tdocpre.Rows(0)("Prefix"))
        Else
            Tstbdocpreid.Text = ""
            Tstbdocpre.Text = ""
        End If
    End Sub
    Private Sub Newdoc()
        Tbdlvno.Text = Trim(Tstbdocpre.Text) & Genid()
        Insertmaster()
        SQLCommand("UPDATE Tdocprexp SET Lvalue = '" & Trim(Tbdlvno.Text).Remove(0, 2) & "',Updusr = '" & Gsuserid & "',Uptype = 'E',Uptime = '" & Formatdatesave(Now) & "' 
                        WHERE  Comid = '" & Gscomid & "' AND Docid = '" & Tstbdocpreid.Text & "' AND Prefix = '" & Trim(Tstbdocpre.Text) & "'")
        Upddetails("A")
        If Gsusername = "SUPHATS" Then
        Else
            Insertlog(Gscomid, Gsusergroupid, Gsuserid, Gsusername, "F124", Trim(Tbdlvno.Text), "A", "สร้างรายการ ใบส่งด้าย", Formatdatesave(Now), Computername, Usrproname)
        End If
    End Sub
    Private Sub Editdoc()
        If Tbdlvno.Text = "NEW" Then
            Exit Sub
        End If
        Editmaster()
        Upddetails("E")
        If Gsusername = "SUPHATS" Then
        Else
            Insertlog(Gscomid, Gsusergroupid, Gsuserid, Gsusername, "F124", Trim(Tbdlvno.Text), "E", "แก้ไขรายการ ใบส่งด้าย", Formatdatesave(Now), Computername, Usrproname)
        End If
    End Sub
    Private Sub Insertmaster()
        SQLCommand("INSERT INTO Tsalefabcolxp(Comid,Dfabdate,Dlvno,Clothid,
                    Custid,Custadd,Shadid,Colorno,
                    Kgprice,Sumkg,Sumprice,Dremark,
                    Sremark,Updusr,Uptype,Uptime)
                    VALUES('" & Gscomid & "','" & Formatshortdatesave(Dtpdate.Value) & "','" & Trim(Tbdlvno.Text) & "','" & Trim(Tbclothid.Text) & "',
                    '" & Trim(Tbcustid.Text) & "'," & Trim(Tbcusadd.Text) & ",'" & Trim(Tbshadeid.Text) & "','" & Trim(Tbcolorno.Text) & "',
                    " & CDbl(Tbkgprice.Text) & "," & CDbl(Tbsumwgt.Text) & "," & CDbl(Tbsummoney.Text) & ",'" & Trim(Tbremark.Text) & "',
                    'ขายผ้าสี','" & Gsuserid & "','A','" & Formatdatesave(Now) & "')")
    End Sub
    Private Sub Editmaster()
        SQLCommand("UPDATE Tsalefabcolxp SET Dfabdate = '" & Formatdatesave(Dtpdate.Value) & "',Clothid = '" & Tbclothid.Text & "',Custid = '" & Trim(Tbcustid.Text) & "',
                    Custadd = " & Trim(Tbcusadd.Text) & ",Shadid = '" & Trim(Tbshadeid.Text) & "',Colorno = '" & Trim(Tbcolorno.Text) & "',Kgprice = " & Trim(Tbkgprice.Text) & ",Sumkg = " & CDbl(Tbsumwgt.Text) & ",
                    Sumprice = " & CDbl(Tbsummoney.Text) & ",Dremark = '" & Trim(Tbremark.Text) & "',Updusr = '" & Gsuserid & "',Uptype = 'E',Uptime = '" & Formatdatesave(Now) & "'
                    WHERE Comid = '" & Gscomid & "' AND Dlvno = '" & Tbdlvno.Text & "'")
    End Sub
    Private Sub Deldetails(Tdlvno As String)
        SQLCommand("DELETE FROM Tsalefabcoldetxp
                    WHERE Comid = '" & Gscomid & "' AND Dlvno = '" & Tdlvno & "'")
    End Sub
    Private Sub Upddetails(Etype As String)
        Deldetails(Trim(Tbdlvno.Text))
        Dim I As Integer
        ProgressBarX1.Value = 0
        Dim Frm As New Formwaitdialoque
        Frm.Show()
        Dim Tlotno, Tkongo, Trollno, SaleClothid, Shadeid As String
        Dim Twgkg As Double
        For I = 0 To Dgvmas.RowCount - 1
            Tkongo = Dgvmas.Rows(I).Cells("Mkongno").Value
            Trollno = Dgvmas.Rows(I).Cells("Rollno").Value
            Twgkg = Dgvmas.Rows(I).Cells("Qtykg").Value
            SaleClothid = Dgvmas.Rows(I).Cells("SaleClothid").Value
            Shadeid = Dgvmas.Rows(I).Cells("Shadeid").Value
            Tlotno = Trim(Dgvmas.Rows(I).Cells("Dlot").Value)
            If Tlotno = "" Then
                MsgBox("NO LOT")
                'UPDATE Trebackfabdet SET Rollstat = 'O' WHERE Rollno = '{Trollno}' AND Rbid = '{Tbdyedcomno.text}' AND Comid = '101'
                'ขายผ้าที่รับคืนมาจะไม่สามารวมกับการขายผ้าที่รับจากโรงย้อมได้ เพราะผ้าที่จะถูกขายไม่มีการเก็บ Lot NO
            End If

            SQLCommand("INSERT INTO Tsalefabcoldetxp(Comid,Dlvno,Lotno,Kongno,Rollno,
                        Clothid,Shadeid,Wgtkg,Updusr,Uptype,Uptime)
                        VALUES('" & Gscomid & "','" & Trim(Tbdlvno.Text) & "','" & Tlotno & "','" & Tkongo & "','" & Trollno & "'
                        ,'" & SaleClothid & "','" & Shadeid & "'," & Twgkg & ",'" & Gsuserid & "','" & Etype & "','" & Formatdatesave(Now) & "')")
            ProgressBarX1.Value = ((I + 1) / Dgvmas.Rows.Count) * 100
            ProgressBarX1.Text = "Saving ... " & ProgressBarX1.Value & "%"
        Next
        Frm.Close()
        ProgressBarX1.Text = "Ready"
        ProgressBarX1.Value = 0
    End Sub
    Private Function Genid() As String
        Dim Genbill As New DataTable
        Dim Sautoid, Tmpyear, Tmpmonth, Tmpday, Tmpsearch As String
        Tmpyear = Now.Year - 2000
        If Now.Month < 10 Then
            Tmpmonth = "0" & Now.Month
        Else
            Tmpmonth = Now.Month
        End If
        If Now.Day < 10 Then
            Tmpday = "0" & Now.Day
        Else
            Tmpday = Now.Day
        End If
        Tmpsearch = Tmpyear & Tmpmonth
        Sautoid = ""
        Genbill = SQLCommand("SELECT ISNULL(MAX(CAST(Lvalue as BIGINT)), 0) + 1 as Autoid FROM Tdocprexp 
                                WHERE LEFT(Lvalue,4) = '" & Tmpsearch & "' AND  Comid = '" & Gscomid & "' 
                                AND Docid = '" & Trim(Tstbdocpreid.Text) & "' AND Prefix = '" & Trim(Tstbdocpre.Text) & "'")
        If Genbill.Rows.Count > 0 Then
            Sautoid = Genbill.Rows(0)("Autoid")
        Else
            Sautoid = "1"
        End If
        If Sautoid = "1" Then
            Sautoid = Tmpsearch & "00001"
        Else
            Sautoid = Sautoid
        End If
        Return Sautoid
    End Function
    Private Sub Bindmaster()
        Tmaster = New DataTable
        Tmaster = SQLCommand("SELECT * FROM Vsalefabcolmas 
                                WHERE Comid = '" & Gscomid & "' AND Dlvno = '" & Trim(Tbdlvno.Text) & "'")
        If Tmaster.Rows.Count > 0 Then
            Tbcustid.Text = Tmaster.Rows(0)("Custid")
            Tbcustname.Text = Tmaster.Rows(0)("Custname")
            Tbcusadd.Text = Tmaster.Rows(0)("Custadd")
            Tbcustship.Text = Tmaster.Rows(0)("Custshipadd")
            Tbclothid.Text = Tmaster.Rows(0)("Clothid")
            Tbclothno.Text = Tmaster.Rows(0)("Clothno")
            Tbwidth.Text = Tmaster.Rows(0)("Fwidth")
            Tbshadeid.Text = Tmaster.Rows(0)("Shadid")
            Tbshadename.Text = InputGrid(Tmaster.Rows(0)("Shadedesc"))
            'Tbshadename.Text = Tmaster.Rows(0)("Shadedesc") ' เป้
            Dtpdate.Value = Tmaster.Rows(0)("Dfabdate")
            Tbcolorno.Text = Tmaster.Rows(0)("Colorno")
            Tbkgprice.Text = Format(Tmaster.Rows(0)("Kgprice"), "###,###.#0")
            Tbremark.Text = Trim(Tmaster.Rows(0)("Dremark"))
            Binddetails()
            Sumall()
        End If
    End Sub
    Private Function InputGrid(Data As Object)
        Dim Redata As String = IIf(IsDBNull(Data), "", Data)
        Return Trim(Redata)
    End Function
    Private Sub Binddetails()
        Tdetails = New DataTable
        Tdetails = SQLCommand($"SELECT dbo.Tsalefabcoldetxp.Comid, dbo.Tsalefabcoldetxp.Dlvno,
                                       dbo.Tsalefabcoldetxp.Lotno, dbo.Tsalefabcoldetxp.Kongno, 
                                       dbo.Tsalefabcoldetxp.Rollno, dbo.Tsalefabcoldetxp.Wgtkg, 
                                       dbo.Tsalefabcoldetxp.Updusr, dbo.Tsalefabcoldetxp.Uptype, 
                                       dbo.Tsalefabcoldetxp.Uptime, dbo.Tsalefabcoldetxp.Shadeid, 
                                       dbo.Tshadexp.Shadedesc, dbo.Tshadexp.Rcolor, dbo.Tshadexp.Gcolor, 
                                       dbo.Tshadexp.Bcolor, dbo.Tsalefabcoldetxp.Clothid, dbo.Tclothxp.Clothno, 
                                       dbo.Tclothxp.Ftype, dbo.Tclothxp.Fwidth FROM dbo.Tsalefabcoldetxp 
                               LEFT OUTER JOIN dbo.Tclothxp
                                       ON dbo.Tsalefabcoldetxp.Clothid = dbo.Tclothxp.Clothid 
                                       AND dbo.Tsalefabcoldetxp.Comid = dbo.Tclothxp.Comid 
						       LEFT OUTER JOIN dbo.Tshadexp 
                                       ON dbo.Tsalefabcoldetxp.Shadeid = dbo.Tshadexp.Shadeid 
                                       AND dbo.Tsalefabcoldetxp.Comid = dbo.Tshadexp.Comid
						       WHERE Tsalefabcoldetxp.Comid = '{Gscomid}' 
                                       AND Tsalefabcoldetxp.Dlvno = '{Trim(Tbdlvno.Text)}' ORDER BY Tclothxp.Ftype DESC")

        Dgvmas.DataSource = Tdetails
    End Sub
    ''Private Sub Salefab()
    ''    Dim HeaderOne() As String = {"No1", "No2", "No3", "No4"}
    ''    Dim Header() As String = {"Kg1", "Kg2", "Kg3", "Kg4"}

    ''    Dim FilterKongarray As New List(Of String)()
    ''    Dim KongnoListarray As New List(Of String)()
    ''    Dim TypeListarray As New List(Of String)()
    ''    Dim ClothnoListarray As New List(Of String)()
    ''    Dim Rollnoarray As New List(Of String)()
    ''    Dim Dlotarray As New List(Of String)()
    ''    'Dim SaleFtypeListarray As New List(Of String)()

    ''    Dim IndexHeader As Integer = 0
    ''    Dim Countkongno As Integer = 0
    ''    Dim FirstGrid As Long = 1
    ''    Dim CountProduc As Long = 1
    ''    Dim StartFirstGrid As Long = 1
    ''    Dim ChashIndex As Long = -1
    ''    Dim Listrecheck As Integer = 0


    ''    FilterKongarray.Add("")
    ''    TypeListarray.Add("")
    ''    ClothnoListarray.Add("")
    ''    Rollnoarray.Add("")
    ''    Dlotarray.Add("")
    ''    'SaleFtypeListarray.Add("")
    ''    For I = 0 To Dgvmas.RowCount - 1
    ''        For Filters = 0 To FilterKongarray.Count - 1
    ''            If FilterKongarray(Filters) = Dgvmas.Rows(I).Cells("Mkongno").Value And TypeListarray(Filters) = Dgvmas.Rows(I).Cells("SaleFtype").Value And
    ''                    Dlotarray(Filters) = Dgvmas.Rows(I).Cells("Dlot").Value Then
    ''                Exit For
    ''            End If

    ''            If Filters = FilterKongarray.Count - 1 Then
    ''                FilterKongarray.Add(Dgvmas.Rows(I).Cells("Mkongno").Value)
    ''                TypeListarray.Add(Dgvmas.Rows(I).Cells("SaleFtype").Value)
    ''                ClothnoListarray.Add(Dgvmas.Rows(I).Cells("SaleClothno").Value)
    ''                Dlotarray.Add(Dgvmas.Rows(I).Cells("Dlot").Value)
    ''                'SaleFtypeListarray.Add(Dgvmas.Rows(I).Cells("SaleFtype").Value)
    ''            End If
    ''        Next
    ''        Rollnoarray.Add(Dgvmas.Rows(I).Cells("Rollno").Value)
    ''    Next

    ''    For i = 1 To FilterKongarray.Count - 1
    ''        If IndexHeader = 0 Then
    ''            For List = 1 To 26
    ''                DataSalefab.Rows.Insert(DataSalefab.RowCount - 1, $"") ' สร้าง 20 แถว
    ''            Next
    ''        End If

    ''        For x = 1 To Rollnoarray.Count - 1
    ''            KongnoKg = New DataTable
    ''            'KongnoKg = SQLCommand($"SELECT Wgtkg FROM Tsalefabcoldetxp WHERE 
    ''            '                    Kongno = '{FilterKongarray(i)}'")
    ''            KongnoKg = SQLCommand($"SELECT dbo.Tsalefabcoldetxp.Wgtkg, dbo.Tclothxp.Ftype FROM dbo.Tsalefabcoldetxp 
    ''    					  LEFT OUTER JOIN dbo.Tclothxp 
    ''    					  ON dbo.Tsalefabcoldetxp.Comid = dbo.Tclothxp.Comid 
    ''    						AND dbo.Tsalefabcoldetxp.Clothid = dbo.Tclothxp.Clothid
    ''    					  WHERE Tsalefabcoldetxp.Comid = '{Gscomid}' 
    ''    						AND Kongno = '{FilterKongarray(i)}' AND Ftype = '{TypeListarray(i)}' AND Lotno = '{Dlotarray(i)}' AND Rollno = '{Rollnoarray(x)}' ")
    ''            For KongLoop = 0 To KongnoKg.Rows.Count - 1
    ''                KongnoListarray.Add(KongnoKg(KongLoop)(0))
    ''            Next
    ''        Next

    ''        Countkongno = 0
    ''        If Listrecheck <> 0 Then

    ''            For List = Listrecheck To KongnoListarray.Count - 1
    ''                Listrecheck += 1

    ''                Countkongno += 1
    ''                If Countkongno = 25 Then
    ''                    IndexHeader += 1
    ''                    Countkongno = 0
    ''                    FirstGrid = StartFirstGrid
    ''                End If
    ''                ''''''''''''''Format(Me.DataReport.Rows(i).Cells("Kg1").Value, "###,###.#0")
    ''                FirstGrid += 1
    ''                DataSalefab.Rows(StartFirstGrid).Cells(Header(IndexHeader)).Value = FilterKongarray(i) ' ใส่หัวเลขที่กอง
    ''                DataSalefab.Rows(StartFirstGrid - 1).Cells(Header(IndexHeader)).Value = ClothnoListarray(i)

    ''                If ChashIndex <> IndexHeader Then
    ''                    'DataSalefab.Rows(FirstGrid - 2).Cells(HeaderOne(IndexHeader)).Value = ClothnoListarray(i)
    ''                    DataSalefab.Rows(FirstGrid - 1).Cells(HeaderOne(IndexHeader)).Value = "No."
    ''                    ChashIndex = IndexHeader
    ''                End If
    ''                If TypeListarray(i) = "RIB" Then
    ''                    DataSalefab.Rows(FirstGrid).Cells(HeaderOne(IndexHeader)).Value = CountProduc & "(บุ้ง)"
    ''                Else
    ''                    DataSalefab.Rows(FirstGrid).Cells(HeaderOne(IndexHeader)).Value = CountProduc
    ''                End If
    ''                DataSalefab.Rows(FirstGrid).Cells(Header(IndexHeader)).Value = Format(CDec(Val(KongnoListarray(List))), "###,###.#0")

    ''                CountProduc += 1
    ''                If List = KongnoListarray.Count - 1 Then
    ''                    FirstGrid = StartFirstGrid
    ''                End If
    ''            Next
    ''        Else
    ''            For List = 0 To KongnoListarray.Count - 1
    ''                Listrecheck += 1

    ''                Countkongno += 1
    ''                If Countkongno = 25 Then
    ''                    IndexHeader += 1
    ''                    Countkongno = 0
    ''                    FirstGrid = StartFirstGrid
    ''                End If
    ''                ''''''''''''''Format(Me.DataReport.Rows(i).Cells("Kg1").Value, "###,###.#0")
    ''                FirstGrid += 1
    ''                DataSalefab.Rows(StartFirstGrid).Cells(Header(IndexHeader)).Value = FilterKongarray(i) ' ใส่หัวเลขที่กอง
    ''                DataSalefab.Rows(StartFirstGrid - 1).Cells(Header(IndexHeader)).Value = ClothnoListarray(i)

    ''                If ChashIndex <> IndexHeader Then
    ''                    'DataSalefab.Rows(FirstGrid - 2).Cells(HeaderOne(IndexHeader)).Value = ClothnoListarray(i)
    ''                    DataSalefab.Rows(FirstGrid - 1).Cells(HeaderOne(IndexHeader)).Value = "No."
    ''                    ChashIndex = IndexHeader
    ''                End If
    ''                If TypeListarray(i) = "RIB" Then
    ''                    DataSalefab.Rows(FirstGrid).Cells(HeaderOne(IndexHeader)).Value = CountProduc & "(บุ้ง)"
    ''                Else
    ''                    DataSalefab.Rows(FirstGrid).Cells(HeaderOne(IndexHeader)).Value = CountProduc
    ''                End If
    ''                DataSalefab.Rows(FirstGrid).Cells(Header(IndexHeader)).Value = Format(CDec(Val(KongnoListarray(List))), "###,###.#0")

    ''                CountProduc += 1
    ''                If List = KongnoListarray.Count - 1 Then
    ''                    FirstGrid = StartFirstGrid
    ''                End If
    ''            Next
    ''        End If

    ''        IndexHeader += 1
    ''        If IndexHeader = 4 Then
    ''            IndexHeader = 0
    ''            FirstGrid += 25
    ''            StartFirstGrid += 25
    ''        End If

    ''        For KongLoop = 0 To KongnoKg.Rows.Count - 1
    ''            KongnoListarray.RemoveAt(0)
    ''        Next
    ''    Next

    ''End Sub

    Private Sub ClearSalefab()
        ''DataSalefab.Rows.Clear()
        'FilterKong.Rows.Clear()
        'KongnoList.Rows.Clear()
    End Sub
    Private Sub Bindinglist()
        Tlist = New DataTable
        Tlist = SQLCommand("SELECT '' AS Stat,* FROM Vsalefabcolmas
                                WHERE Comid = '" & Gscomid & "'")
        Dgvlist.DataSource = Tlist
        Bs = New BindingSource
        Bs.DataSource = Tlist
        BindingNavigator1.BindingSource = Bs
        FillGrid()
        ShowRecordDetail()
    End Sub
    Private Sub Bindingstock()
        Stocklist = New DataTable
        Stocklist = SQLCommand($"SELECT dbo.Vsalestock.Comid, dbo.Trecfabcolxp.Reid, dbo.Vsalestock.Dhid, 
                                        dbo.Vsalestock.Dyedhdesc, dbo.Vsalestock.Lotno, dbo.Vsalestock.Kongno, 
                                        dbo.Vsalestock.Clothid, dbo.Vsalestock.Clothno, dbo.Vsalestock.Ftype, 
                                        dbo.Vsalestock.Fwidth, dbo.Vsalestock.Shadeid, dbo.Vsalestock.Shadedesc, 
                                        COUNT(*) AS Cunt, SUM(dbo.Vsalestock.Rollwage) AS Rollwage
                                 FROM dbo.Vsalestock INNER JOIN dbo.Trecfabcolxp 
                                        ON dbo.Vsalestock.Comid = dbo.Trecfabcolxp.Comid 
                                        AND dbo.Vsalestock.Lotno = dbo.Trecfabcolxp.Lotno
                                WHERE (dbo.Vsalestock.Comid = '{Gscomid}')
                                GROUP BY dbo.Vsalestock.Comid, dbo.Vsalestock.Dyedhdesc, dbo.Vsalestock.Lotno, 
                                         dbo.Vsalestock.Kongno, dbo.Vsalestock.Clothid, dbo.Vsalestock.Clothno, 
                                         dbo.Vsalestock.Ftype, dbo.Vsalestock.Fwidth, dbo.Vsalestock.Shadeid, 
                                         dbo.Vsalestock.Shadedesc, dbo.Trecfabcolxp.Reid, dbo.Vsalestock.Dhid
                                UNION
                                SELECT Comid,Rbid,Custid,Custname,Lotno,Kongno,Clothid,Clothno,Ftype,Fwidth,
                                       Shadeid, Shadedesc,COUNT(*) As Cunt,SUM(Rollwage) As Rollwage 
	                            FROM Vrebackfabdet 
                                WHERE Rollstat = 'I' AND Comid = '{Gscomid}' 
                                GROUP BY Comid, Rbid, Custid, Custname, Custname, Lotno, Kongno, Clothid, Clothno, Ftype, Fwidth, Shadeid, Shadedesc")

        Dgvstock.DataSource = Stocklist
        '    Bs = New BindingSource
        '    Bs.DataSource = Tlist
        '    BindingNavigator1.BindingSource = Bs
        FillstockGrid()
        ShowRecordStockDetail()
    End Sub
    Private Function Haveknittform() As Boolean
        Dim Haveform As Boolean = False
        Dim Haveknitfrm As New DataTable
        Haveknitfrm = SQLCommand("SELECT Dlvno FROM Tknittcomxp
                                WHERE Dlvno = '" & Trim(Tbdlvno.Text) & "' AND  Comid = '" & Gscomid & "'")
        If Haveknitfrm.Rows.Count > 0 Then
            Haveform = True
        Else
            Haveform = False
        End If
        Return Haveform
    End Function
    Private Sub Sumall()
        Dim Sumkg, Sumprice As Double
        Sumkg = 0.0
        Sumprice = 0.0
        If Dgvmas.RowCount = 0 Then
            Tstbsumkg.Text = Format(Sumkg, "###,###.#0")
            Tbsumwgt.Text = Format(Sumkg, "0.#0")
            Tbsummoney.Text = Format(Sumprice, "0.#0")
            Tstbsumroll.Text = 0
            Exit Sub
        End If
        ProgressBarX1.Value = 0
        Dim Frm As New Formwaitdialoque
        Frm.Show()
        Dim I As Integer
        For I = 0 To Dgvmas.RowCount - 1
            Sumkg = Sumkg + CDbl(Dgvmas.Rows(I).Cells("Qtykg").Value)
            ProgressBarX1.Value = ((I + 1) / Dgvmas.Rows.Count) * 100
            ProgressBarX1.Text = "Caculating sum ... " & ProgressBarX1.Value & "%"
        Next
        Frm.Close()
        ProgressBarX1.Text = "Ready"
        ProgressBarX1.Value = 0
        Tstbsumkg.Text = Format(Sumkg, "###,###.#0")
        Tbsumwgt.Text = Format(Sumkg, "###,###.#0")
        Tstbsumroll.Text = Dgvmas.RowCount
        'Tbsummoney.Text = Format(Sumkg * CDbl(Tbkgprice.Text), "###,###.#0")
    End Sub
    Private Sub Clrdgrid()
        Dgvmas.AutoGenerateColumns = False
        Dgvmas.DataSource = Nothing
        Dgvmas.Rows.Clear()
    End Sub
    Private Sub Clrtxtbox()
        Tbdlvno.Text = "NEW"
        Dtpdate.Value = Now
        Tstbsumroll.Text = ""
        Tstbsumkg.Text = ""
        Tbremark.Text = ""
        Tsbwsave.Visible = False
    End Sub
    Private Sub Editcontextdetmenu()
        Ctmmenudetgrid.Displayed = False
        Ctmmenudetgrid.PopupMenu(Control.MousePosition)
    End Sub
    Private Sub Editcontextlistmenu()
        Ctmmenugrid.Displayed = False
        Ctmmenugrid.PopupMenu(Control.MousePosition)
    End Sub
    Private Sub Editcontextstockmenu()
        Ctmstockid.Displayed = False
        Ctmstockid.PopupMenu(Control.MousePosition)
    End Sub
    Private Function Validinput() As Boolean
        Dim Valid As Boolean = False
        If Tblotno.Text <> "" And Tbkongno.Text <> "" Then
            Valid = True
        End If
        Return Valid
    End Function
    Private Function Checkfillbutton() As Boolean
        If Pagesize = 0 Then
            Informmessage("Set the Page Size, And Then click the ""Fill Grid"" button!")
            Checkfillbutton = False
        Else
            Checkfillbutton = True
        End If
    End Function
    Private Function Checkstockfillbutton() As Boolean
        If Pagestocksize = 0 Then
            Informmessage("Set the Page Size, And Then click the ""Fill Grid"" button!")
            Checkstockfillbutton = False
        Else
            Checkstockfillbutton = True
        End If
    End Function
    Private Sub Befirst()
        Try
            If Not Checkfillbutton() Then Return
            If Currentpage = 1 Then
                Informmessage("You are at the First Page!")
                Return
            End If
            Currentpage = 1
            Recno = 0
            LoadPage()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Bestockfirst()
        Try
            If Not Checkstockfillbutton() Then Return
            If Currenstocktpage = 1 Then
                Informmessage("You are at the First Page!")
                Return
            End If
            Currenstocktpage = 1
            Restockcno = 0
            LoadstockPage()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Beprev()
        Try
            If Not Checkfillbutton() Then Return
            Currentpage = Currentpage - 1
            If Currentpage < 1 Then
                Informmessage("You are at the First Page!")
                Currentpage = 1
                Return
            Else
                Recno = Pagesize * (Currentpage - 1)
            End If
            LoadPage()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Bestockprev()
        Try
            If Not Checkstockfillbutton() Then Return
            Currenstocktpage = Currenstocktpage - 1
            If Currenstocktpage < 1 Then
                Informmessage("You are at the First Page!")
                Currenstocktpage = 1
                Return
            Else
                Restockcno = Pagestocksize * (Currenstocktpage - 1)
            End If
            LoadstockPage()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Benext()
        Try
            If Not Checkfillbutton() Then Return
            If Pagesize = 0 Then
                Informmessage("Set the Page Size, and then click the ""Fill Grid"" button!")
                Return
            End If
            Currentpage = Currentpage + 1
            If Currentpage > Pagecount Then
                Currentpage = Pagecount
                If Recno = Maxrec Then
                    Informmessage("You are at the Last Page!")
                    Return
                End If
            End If
            LoadPage()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Bestocknext()
        Try
            If Not Checkstockfillbutton() Then Return
            If Pagestocksize = 0 Then
                Informmessage("Set the Page Size, and then click the ""Fill Grid"" button!")
                Return
            End If
            Currenstocktpage = Currenstocktpage + 1
            If Currenstocktpage > Pagestockcount Then
                Currenstocktpage = Pagestockcount
                If Restockcno = Maxstockrec Then
                    Informmessage("You are at the Last Page!")
                    Return
                End If
            End If
            LoadstockPage()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Belast()
        Try
            If Not Checkfillbutton() Then Return
            If Recno = Maxrec Then
                Informmessage("You are at the Last Page!")
                Return
            End If
            Currentpage = Pagecount
            Recno = Pagesize * (Currentpage - 1)
            LoadPage()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Bestocklast()
        Try
            If Not Checkstockfillbutton() Then Return
            If Restockcno = Maxstockrec Then
                Informmessage("You are at the Last Page!")
                Return
            End If
            Currenstocktpage = Pagestockcount
            Restockcno = Pagestocksize * (Currenstocktpage - 1)
            LoadstockPage()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub LoadPage()
        Dim I, Startrec, Endrec As Integer
        Dttemp = Tlist.Clone
        If Currentpage = Pagecount Then
            Endrec = Maxrec
        Else
            Endrec = Pagesize * Currentpage
        End If
        Startrec = Recno
        If Tlist.Rows.Count > 0 Then
            For I = Startrec To Endrec - 1
                Dttemp.ImportRow(Tlist.Rows(I))
                Recno = Recno + 1
            Next
        End If
        Dgvlist.DataSource = Dttemp
        DisplayPageInfo()
        ShowRecordDetail()
    End Sub
    Private Sub LoadstockPage()
        Dim I, Startrec, Endrec As Integer
        Dtstocktemp = Stocklist.Clone
        If Currenstocktpage = Pagestockcount Then
            Endrec = Maxstockrec
        Else
            Endrec = Pagestocksize * Currenstocktpage
        End If
        Startrec = Restockcno
        If Stocklist.Rows.Count > 0 Then
            For I = Startrec To Endrec - 1
                Dtstocktemp.ImportRow(Stocklist.Rows(I))
                Restockcno = Restockcno + 1
            Next
        End If
        Dgvstock.DataSource = Dtstocktemp
        DisplayStockPageInfo()
        ShowRecordStockDetail()
    End Sub
    Private Sub FillGrid()
        Pagesize = (CInt(Dgvlist.Height) \ CInt(Dgvlist.RowTemplate.Height)) - 2
        Maxrec = Tlist.Rows.Count
        Pagecount = Maxrec \ Pagesize
        If (Maxrec Mod Pagesize) > 0 Then
            Pagecount = Pagecount + 1
        End If
        Currentpage = 1
        Recno = 0
        LoadPage()
    End Sub
    Private Sub FillstockGrid()
        Pagestocksize = (CInt(Dgvstock.Height) \ CInt(Dgvstock.RowTemplate.Height)) - 2
        Maxstockrec = Stocklist.Rows.Count
        Pagestockcount = Maxstockrec \ Pagestocksize
        If (Maxstockrec Mod Pagestocksize) > 0 Then
            Pagestockcount = Pagestockcount + 1
        End If
        Currenstocktpage = 1
        Restockcno = 0
        LoadstockPage()
    End Sub
    Private Sub DisplayPageInfo()
        Tbpage.Text = "หน้า " & Currentpage.ToString & "/" & Pagecount.ToString
    End Sub
    Private Sub DisplayStockPageInfo()
        Tbstockpage.Text = "หน้า " & Currenstocktpage.ToString & "/" & Pagestockcount.ToString
    End Sub

    Private Sub Btmedit_Click(sender As Object, e As EventArgs) Handles Btmedit.Click
        'Tbfinddhid.Enabled = True
        'Tbpickup.Enabled = True
        Btdbadd.Enabled = True
        Btfindlotno.Enabled = True
        Tbkgprice.Enabled = True
        Tbcolorno.Enabled = True
        Btdcancel.Enabled = True
        Tbremark.Enabled = True
        Dtpdate.Enabled = True
        Ctdedit.Enabled = True
        Ctddel.Enabled = True
        Btmnew.Enabled = False
        Btfindcustid.Enabled = True
        Btfindcusship.Enabled = True
        Btfindclothno.Enabled = True
        Btfindshade.Enabled = True
        'Btdadd.Enabled = True
        BindingNavigator1.Enabled = False
        Mainbuttonaddedit()
    End Sub

    Private Sub Btmcancel_Click(sender As Object, e As EventArgs) Handles Btmcancel.Click
        Clrmaster()
        Clrdetails()
        Clrdgrid()
        TabControl1.SelectedTabIndex = 0
        BindingNavigator1.Enabled = False
        Mainbuttoncancel()
    End Sub

    Private Sub ShowRecordDetail()
        Tbrecord.Text = "แสดง " & (Dgvlist.RowCount) & " รายการ จาก " & Tlist.Rows.Count & " รายการ"
    End Sub
    Private Sub ShowRecordStockDetail()
        TbrecordStock.Text = "แสดง " & (Dgvstock.RowCount) & " รายการ จาก " & Stocklist.Rows.Count & " รายการ"
    End Sub
    Private Function Findpoud(Tkg As String) As Double
        Dim Rpound As Double = 0.0
        If Tkg = "" Then
            Rpound = 0
        Else
            Rpound = CDbl(Tkg) * 2.2046
        End If
        Return Rpound
    End Function
    Private Function Validmas() As Boolean
        Dim Valid As Boolean = False
        'Tbmycom.Text <> "" And 
        If Tbcustid.Text <> "" And Tbcustname.Text <> "" And Tbdlvno.Text <> "" And
        Tbcusadd.Text <> "" And Tbcustship.Text <> "" And Tbclothid.Text <> "" And Tbclothno.Text <> "" And
        Tbwidth.Text <> "" And Tbshadeid.Text <> "" And Tbshadename.Text <> "" And Tbcolorno.Text <> "" And
        Tbkgprice.Text <> "" Then
            Valid = True
        End If
        Return Valid
    End Function
    Private Function Validdet() As Boolean
        Dim Valid As Boolean = False
        If Dgvmas.RowCount > 0 Then
            Valid = True
        End If
        Return Valid
    End Function
    Private Sub Setauthorize()
        If Gswriau = False Then
            Btmsave.Visible = False
            'Btdadd.Visible = False
            Btdedit.Visible = False
            Ctdedit.Visible = False
        End If
        If Gscreau = False Then
            'Btdadd.Visible = False
        End If
        If Gsdelau = False Then
            Btmdel.Visible = False
            Btddel.Visible = False
            Ctddel.Visible = False
        End If
        If Gspriau = False Then
            Btmreports.Visible = False
        End If
    End Sub
    Private Function Chkdupyarnidingrid(Tlot As String, Tkong As String, Troll As String) As Boolean
        Dim Dup As Boolean = False
        If Dgvmas.RowCount = 0 Then
            Dup = False
        Else
            Dim I As Integer
            For I = 0 To Dgvmas.RowCount - 1
                If Tlot = Trim(Dgvmas.Rows(I).Cells("Dlot").Value) And Tkong = Trim(Dgvmas.Rows(I).Cells("Mkongno").Value) And Troll = Trim(Dgvmas.Rows(I).Cells("Rollno").Value) Then
                    Dup = True
                    Exit For
                End If
            Next
        End If
        Return Dup
    End Function
    Private Sub Findshadeanddyecolor()
        Dim Tshdyedcol As New DataTable
        Tshdyedcol = SQLCommand("SELECT * FROM Vrecfabcolmas
                                WHERE Comid = '" & Gscomid & "' AND Lotno = '" & Trim(Tblotno.Text) & "'")
        If Tshdyedcol.Rows.Count = 0 Then
        Else
            Tbcolorno.Text = Tshdyedcol.Rows(0)("Dyedcolor")
        End If
    End Sub

    Private Sub Btfindlotno_Click_1(sender As Object, e As EventArgs) Handles Btfindlotno.Click
        If Tbkgprice.Text = "" Then
            Informmessage("กรุณาใส่ ราคา/กก.")
            Exit Sub
        End If

        If CDbl(Tbkgprice.Text) = 0 Then
            Informmessage("คำเตือน กรุณาตรวจสอบอีกครั้งคุณใส่ราคา 0")
        End If

        If Trim(Tbclothid.Text) = "" Then
            Informmessage("กรุณาเลือกเบอร์ผ้า")
            Exit Sub
        End If

        'Dgvmas.Rows(0).Cells("Dlot").Value = 0
        Dim Frm As New Formaesalefabcolor

        Frm.Tbclothid.Text = Trim(Tbclothid.Text)
        Frm.Tbkongno.Text = Trim(Tbkongno.Text)
        Frm.RS.Text = Trim(RS.Text)
        Frm.BoxShadeid.Text = Trim(Tbshadeid.Text)

        Showdiaformcenter(Frm, Me)
        If Frm.Tbcancel.Text = "C" Then
            Exit Sub
        End If

        Dim DatainGride = 0
        For i = 0 To Frm.Dgvmas.RowCount - 1
            If Frm.Dgvmas.Rows(i).Cells("Checked").Value = True Then
                'Dim dRow As DataRow
                If Tbdlvno.Text = "NEW" Then

                    'MessageBox.Show(Dgvmas.RowCount - 1)

                    If (Dgvmas.RowCount - 1) = -1 Then
                        'MessageBox.Show("Nooooooo")
                        For CheckLot = 0 To Frm.Dgvmas.RowCount - 1
                            If Frm.Dgvmas.Rows(CheckLot).Cells("Checked").Value = True Then
                                Dgvmas.Rows.Add()
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Dlot").Value = Frm.Dgvmas.Rows(CheckLot).Cells("Mlotno").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Mkongno").Value = Frm.Dgvmas.Rows(CheckLot).Cells("Kongno").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Rollno").Value = Frm.Dgvmas.Rows(CheckLot).Cells("Pubno").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Qtykg").Value = Frm.Dgvmas.Rows(CheckLot).Cells("Rollwage").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("SaleFtype").Value = Frm.Dgvmas.Rows(CheckLot).Cells("Ftype").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("SaleClothid").Value = Frm.Dgvmas.Rows(CheckLot).Cells("Clothid").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Shadeid").Value = Frm.Dgvmas.Rows(CheckLot).Cells("Shadeid").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Shadedesc").Value = Frm.Dgvmas.Rows(CheckLot).Cells("Shadedesc").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("SaleClothno").Value = Trim(Tbclothno.Text)
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("SaleFwidth").Value = Trim(Tbwidth.Text)
                                DatainGride = 1
                            End If
                        Next

                    Else
                        'MessageBox.Show("Yessssss")

                        For CheckLot = 0 To Dgvmas.RowCount - 1
                            'MessageBox.Show($"{Dgvmas.Rows(CheckLot).Cells("Mkongno").Value} : {Frm.Dgvmas.Rows(i).Cells("Kongno").Value}")
                            'If Dgvmas.Rows(CheckLot).Cells("Mkongno").Value <> Frm.Dgvmas.Rows(i).Cells("Kongno").Value Then
                            If Dgvmas.Rows(CheckLot).Cells("Dlot").Value = Frm.Dgvmas.Rows(i).Cells("Mlotno").Value AndAlso 'เลข Lot No
                                Dgvmas.Rows(CheckLot).Cells("Rollno").Value = Frm.Dgvmas.Rows(i).Cells("Pubno").Value AndAlso 'เลขพับที่
                                Dgvmas.Rows(CheckLot).Cells("shadeid").Value = Frm.Dgvmas.Rows(i).Cells("shadeid").Value AndAlso 'เลขพับที่
                                Dgvmas.Rows(CheckLot).Cells("Qtykg").Value = Frm.Dgvmas.Rows(i).Cells("Rollwage").Value Then 'เลขน้ำหนัก
                                'MessageBox.Show("มีข้อมูลแล้ว")
                                'Informmessage($"มีข้อมูล Lot No: {Dgvmas.Rows(CheckLot).Cells("Dlot").Value} อยู่ในรายการแล้ว")
                                If DatainGride = 0 Then
                                    Informmessage("มีบางรายการถูกเลือกอยู่แล้ว")
                                    DatainGride = 1
                                End If
                                Exit For
                            Else
                                'MessageBox.Show("ไม่ซ้ำ")
                                If CheckLot = Dgvmas.RowCount - 1 Then
                                    'MessageBox.Show("เขียนได้")
                                    Dgvmas.Rows.Add()
                                    Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Dlot").Value = Frm.Dgvmas.Rows(i).Cells("Mlotno").Value
                                    Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Mkongno").Value = Frm.Dgvmas.Rows(i).Cells("Kongno").Value
                                    Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Rollno").Value = Frm.Dgvmas.Rows(i).Cells("Pubno").Value
                                    Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Qtykg").Value = Frm.Dgvmas.Rows(i).Cells("Rollwage").Value
                                    Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("SaleFtype").Value = Frm.Dgvmas.Rows(i).Cells("Ftype").Value
                                    Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("SaleClothid").Value = Frm.Dgvmas.Rows(i).Cells("Clothid").Value
                                    Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Shadeid").Value = Frm.Dgvmas.Rows(i).Cells("Shadeid").Value
                                    Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Shadedesc").Value = Frm.Dgvmas.Rows(i).Cells("Shadedesc").Value
                                    Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("SaleClothno").Value = Trim(Tbclothno.Text)
                                    Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("SaleFwidth").Value = Trim(Tbwidth.Text)
                                End If

                            End If
                        Next

                    End If


                Else

                    If (Dgvmas.RowCount - 1) = -1 Then
                        'MessageBox.Show("Nooooooo")
                        For CheckLot = 0 To Frm.Dgvmas.RowCount - 1
                            If Frm.Dgvmas.Rows(CheckLot).Cells("Checked").Value = True Then
                                Tdetails.Rows.Add()
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Dlot").Value = Frm.Dgvmas.Rows(CheckLot).Cells("Mlotno").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Mkongno").Value = Frm.Dgvmas.Rows(CheckLot).Cells("Kongno").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Rollno").Value = Frm.Dgvmas.Rows(CheckLot).Cells("Pubno").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Qtykg").Value = Frm.Dgvmas.Rows(CheckLot).Cells("Rollwage").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("SaleFtype").Value = Frm.Dgvmas.Rows(CheckLot).Cells("Ftype").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("SaleClothid").Value = Frm.Dgvmas.Rows(CheckLot).Cells("Clothid").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Shadeid").Value = Frm.Dgvmas.Rows(CheckLot).Cells("Shadeid").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Shadedesc").Value = Frm.Dgvmas.Rows(CheckLot).Cells("Shadedesc").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("SaleClothno").Value = Trim(Tbclothno.Text)
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("SaleFwidth").Value = Trim(Tbwidth.Text)
                                DatainGride = 1
                            End If
                        Next
                    End If

                    For CheckLot = 0 To Dgvmas.RowCount - 1
                        'MessageBox.Show($"{Dgvmas.Rows(CheckLot).Cells("Mkongno").Value} : {Frm.Dgvmas.Rows(i).Cells("Kongno").Value}")
                        'If Dgvmas.Rows(CheckLot).Cells("Mkongno").Value <> Frm.Dgvmas.Rows(i).Cells("Kongno").Value Then
                        If Dgvmas.Rows(CheckLot).Cells("Dlot").Value = Frm.Dgvmas.Rows(i).Cells("Mlotno").Value AndAlso 'เลข Lot No
                            Dgvmas.Rows(CheckLot).Cells("Rollno").Value = Frm.Dgvmas.Rows(i).Cells("Pubno").Value AndAlso 'เลขพับที่
                            Dgvmas.Rows(CheckLot).Cells("Shadeid").Value = Frm.Dgvmas.Rows(i).Cells("Shadeid").Value AndAlso 'สีผ้า
                            Dgvmas.Rows(CheckLot).Cells("Qtykg").Value = Frm.Dgvmas.Rows(i).Cells("Rollwage").Value Then 'เลขน้ำหนัก
                            'MessageBox.Show("มีข้อมูลแล้ว")
                            'Informmessage($"มีข้อมูล Lot No: {Dgvmas.Rows(CheckLot).Cells("Dlot").Value} อยู่ในรายการแล้ว")
                            If DatainGride = 0 Then
                                Informmessage("มีบางรายการถูกเลือกอยู่แล้ว")
                                DatainGride = 1
                            End If
                            Exit For
                        Else
                            'MessageBox.Show("ไม่ซ้ำ")
                            If CheckLot = Dgvmas.RowCount - 1 Then
                                'MessageBox.Show("เขียนได้")
                                Tdetails.Rows.Add()
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Dlot").Value = Frm.Dgvmas.Rows(i).Cells("Mlotno").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Mkongno").Value = Frm.Dgvmas.Rows(i).Cells("Kongno").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Rollno").Value = Frm.Dgvmas.Rows(i).Cells("Pubno").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Qtykg").Value = Frm.Dgvmas.Rows(i).Cells("Rollwage").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("SaleFtype").Value = Frm.Dgvmas.Rows(i).Cells("Ftype").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("SaleClothid").Value = Frm.Dgvmas.Rows(i).Cells("Clothid").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Shadeid").Value = Frm.Dgvmas.Rows(i).Cells("Shadeid").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Shadedesc").Value = Frm.Dgvmas.Rows(i).Cells("Shadedesc").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("SaleClothno").Value = Trim(Tbclothno.Text)
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("SaleFwidth").Value = Trim(Tbwidth.Text)
                            End If

                        End If
                    Next

                    'Tdetails.Rows.Add()

                    'MessageBox.Show(0)
                End If

                'Dgvmas.Rows(i).Cells("Dlot").Value = Frm.Dgvmas.Rows(i).Cells("Mlotno").Value
            End If
        Next
        Sumall()

        'MessageBox.Show(CDbl(Tbkgprice.Text))
        'Dim Coverprice As Long = CDbl(Tbkgprice.Text)
        Dim Summoney As Double = CDbl(Tbkgprice.Text) * CDbl(Tbsumwgt.Text)
        'MessageBox.Show(Summoney)
        Tbsummoney.Text = Format(Summoney, "###,###.#0")

        'Dgvmas.Rows(0).Cells("Dlot").Value = 0


        'Tblotno.Text = Trim(Frm.Tbfabno.Text)
        'Tbkongno.Text = Trim(Frm.Normtextbox1.Text)
        'Btdadd.Focus()

    End Sub

    Private Sub Clrmaster()
        Tbdlvno.Text = ""
        'Tbdlvno.Enabled = True
        Dtpdate.Value = Now
        Tbremark.Text = ""
        Tsbwsave.Visible = False
        Tbcustid.Text = ""
        Tbcusadd.Text = ""
        Tbclothid.Text = ""
        Tbshadeid.Text = ""
        Tbkgprice.Text = ""
        Tbcustname.Text = ""
        Tbcustship.Text = ""
        Tbclothno.Text = ""
        Tbshadename.Text = ""
        Tbmycom.Text = ""
        Tbwidth.Text = ""
        Tbcolorno.Text = ""
    End Sub


    Private Sub Btdcancel_Click(sender As Object, e As EventArgs) Handles Btdcancel.Click
        Tbaddedit.Text = "เพิ่ม"
        Tbdyedcomno.Text = ""
        RS.Text = "RS"
        Qtykgbox.Text = ""
        Rollnobox.Text = ""
        Tbkongno.Text = ""
        Tblotno.Text = ""
        GroupPanel2.Visible = False
        Btdbadd.Enabled = True
    End Sub

    Private Sub Clrdetails()
        'Tbyarnid.Text = ""
        'Tbyarnname.Text = ""
        Qtykgbox.Text = ""
        Rollnobox.Text = ""
        Tblotno.Text = ""
        Tbkongno.Text = ""
        Tbsumwgt.Text = "0.00"
        Tbsummoney.Text = "0.00"
        Tbdyedcomno.Text = ""
        RS.Text = "RS"
        'Tbnwpcotkg.Text = ""
        'Tbnwpcotp.Text = ""
        'Tbgrwpcotkg.Text = ""
        'Tbgrwpcotp.Text = ""
        'Tbamtcotton.Text = ""
        GroupPanel2.Visible = False
    End Sub

    Private Sub Btdbadd_Click(sender As Object, e As EventArgs) Handles Btdbadd.Click
        Btfindlotno.Enabled = True
        GroupPanel2.Visible = True
        Tbaddedit.Text = "เพิ่ม"

        If Tbkgprice.Text = "" OrElse Tbkgprice.Text = "." Then
            Tbsummoney.Text = "0.00"
            Exit Sub
        ElseIf CDbl(Tbkgprice.Text) = 0 Then
            Tbsummoney.Text = "0.00"
        End If

        Dim Summoney As Double = CDbl(Tbkgprice.Text) * CDbl(Tbsumwgt.Text)
        Tbsummoney.Text = Format(Summoney, "###,##0.#0")
        Btdbadd.Enabled = False
    End Sub

    Private Sub Btddel_Click_1(sender As Object, e As EventArgs) Handles Btddel.Click
        If Dgvmas.RowCount = 0 Then
            Exit Sub
        End If
        Btdcancel_Click(sender, e)
        Tsbwsave.Visible = True
        Dgvmas.Rows.Remove(Dgvmas.CurrentRow)
        Sumall()

        If Tbkgprice.Text = "" OrElse Tbkgprice.Text = "." Then
            Tbsummoney.Text = "0.00"
            Exit Sub
        End If

        If CDbl(Tbkgprice.Text) = 0 Then
            Tbsummoney.Text = "0.00"
        End If

        Dim Summoney As Double = CDbl(Tbkgprice.Text) * CDbl(Tbsumwgt.Text)
        Tbsummoney.Text = Format(Summoney, "###,##0.#0")

        'For i = 0 To Dgvmas.RowCount - 1
        '    Dim Rows As Integer = i + 1
        '    Dgvmas.Rows(i).Cells("ord").Value = Rows
        '    'MessageBox.Show(Rows)
        'Next
    End Sub

    Private Sub Btdedit_Click(sender As Object, e As EventArgs) Handles Btdedit.Click
        If Dgvmas.RowCount > 0 Then
            Btfindlotno.Enabled = False
            GroupPanel2.Visible = True
            Tbaddedit.Text = "แก้ไข"
            Tblotno.Text = Trim(Dgvmas.CurrentRow.Cells("Dlot").Value)
            Tbkongno.Text = Trim(Dgvmas.CurrentRow.Cells("Mkongno").Value)
            Rollnobox.Text = Trim(Dgvmas.CurrentRow.Cells("Rollno").Value)
            Qtykgbox.Text = Trim(Dgvmas.CurrentRow.Cells("Qtykg").Value)
        End If
    End Sub


    Private Sub Btfindcustid_Click_1(sender As Object, e As EventArgs) Handles Btfindcustid.Click
        Dim Frm As New Formcustomerslist
        Showdiaformcenter(Frm, Me)
        If Frm.Tbcancel.Text = "C" Then
            Exit Sub
        End If
        Tbcustid.Text = CLng(Frm.Dgvmas.CurrentRow.Cells("Mid").Value)
        Tbcustname.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Mname").Value)
        Tbcusadd.Text = ""
        Tbcustship.Text = ""

    End Sub

    Private Sub ButtonItem1_Click(sender As Object, e As EventArgs) Handles ButtonItem1.Click
        If Dgvlist.CurrentRow.Cells("Dlvno").Value = "" Then
            Exit Sub
        End If
        If Confirmdelete() = True Then
            Deldetails(Trim(Tbdlvno.Text))
            SQLCommand("DELETE FROM Tsalefabcolxp WHERE Comid = '" & Gscomid & "' AND Dlvno = '" & Dgvlist.CurrentRow.Cells("Dlvno").Value & "'")
            Clrdgrid()
            Clrtxtbox()
            Clrtextmaster()
            Clrtextdetails()
            Clrgridmaster()
            Bindingstock()
            Bindinglist()
            TabControl1.SelectedTabIndex = 1
            BindingNavigator1.Enabled = False
            Mainbuttoncancel()
        End If
    End Sub

    Private Sub Btfindcusship_Click_1(sender As Object, e As EventArgs) Handles Btfindcusship.Click
        If Tbcustid.Text = "" Or Tbcustname.Text = "" Then
            Informmessage("กรุณาเลือกลูกค้า")
            Exit Sub
        End If
        Dim Frm As New Formcustshiplist
        Frm.Tbcustid.Text = Tbcustid.Text
        Showdiaformcenter(Frm, Me)
        If Frm.Tbcancel.Text = "C" Then
            Exit Sub
        End If
        Tbcusadd.Text = CLng(Frm.Dgvmas.CurrentRow.Cells("Mord").Value)
        Tbcustship.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Mshaddr").Value)

    End Sub

    Private Sub Btliststockfind_Click(sender As Object, e As EventArgs) Handles Btliststockfind.Click
        Searchstocklistbyoth(Trim(Tstbstockkeyword.Text))
    End Sub

    Private Sub Btfindclothno_Click_1(sender As Object, e As EventArgs) Handles Btfindclothno.Click
        Dim Frm As New Formfabrictypelist
        Showdiaformcenter(Frm, Me)
        If Frm.Tbcancel.Text = "C" Then
            Exit Sub
        End If
        Tbclothid.Text = CLng(Frm.Dgvmas.CurrentRow.Cells("Mid").Value)
        Tbclothno.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Mname").Value)
        Tbwidth.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Fwidth").Value)
        Tbkongno.Text = ""
        Tbdyedcomno.Text = ""
        RS.Text = "RS"
    End Sub

    Private Sub Btfindshade_Click(sender As Object, e As EventArgs) Handles Btfindshade.Click
        Dim Frm As New Formsheadbyfab
        Showdiaformcenter(Frm, Me)
        If Frm.Tbcancel.Text = "C" Then
            Exit Sub
        End If
        Tbshadeid.Text = CLng(Frm.Dgvmas.CurrentRow.Cells("Mid").Value)
        Tbshadename.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Shade").Value)

    End Sub

    Private Sub Ctddel_Click_1(sender As Object, e As EventArgs) Handles Ctddel.Click
        Btddel_Click_1(sender, e)
    End Sub

    Private Sub ButtonItem2_Click(sender As Object, e As EventArgs) Handles Ctmstockedit.Click
        Clrdgrid()
        Clrtxtbox()
        Btdcancel_Click(sender, e)
        Btmnew_Click(sender, e)
        Tbkongno.Text = InputGrid(Dgvstock.CurrentRow.Cells("SKongno").Value)

        Tbdyedcomno.Text = InputGrid(Dgvstock.CurrentRow.Cells("Reid").Value)
        REData = New DataTable
        REData = SQLCommand($"SELECT Billdyedno FROM Vrecfabcolmas WHERE Reid = '{Tbdyedcomno.Text}' AND Comid = '{Gscomid}'
                                    UNION
                              SELECT Rbid AS Billdyedno FROM Vrebackfabdet WHERE Rollstat = 'I' AND Comid = '{Gscomid}' 
                                    AND Rbid = '{Tbdyedcomno.Text}' ")
        Try
            RS.Text = REData(0)(0)
        Catch ex As Exception
            RS.Text = "RS"
        End Try

        Tbclothid.Text = InputGrid(Dgvstock.CurrentRow.Cells("SClothid").Value)
        Tbclothno.Text = InputGrid(Dgvstock.CurrentRow.Cells("SClothno").Value)
        Tbwidth.Text = InputGrid(Dgvstock.CurrentRow.Cells("SFwidth").Value)
        Tbshadeid.Text = InputGrid(Dgvstock.CurrentRow.Cells("SShadeid").Value)
        Tbshadename.Text = InputGrid(Dgvstock.CurrentRow.Cells("SShadedesc").Value)
        Btmedit_Click(sender, e)
        Btdbadd_Click(sender, e)
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        If Tbclothid.Text = "" Then
            Informmessage("กรุณาเลือกเบอร์ผ้า")
            Exit Sub
        End If

        Dim Frm As New Formkongnolist
        Frm.Tbclothid.Text = Tbclothid.Text
        Showdiaformcenter(Frm, Me)
        If Frm.Tbcancel.Text = "C" Then
            Exit Sub
        End If
        Tbkongno.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Kongno").Value)
        RS.Text = "RS"
        Tbdyedcomno.Text = ""
    End Sub

    Private Sub Findyedcomno_Click(sender As Object, e As EventArgs) Handles Findyedcomno.Click
        If Tbkongno.Text = "" Then
            Informmessage("กรุณาเลือกเบอร์กอง")
            Exit Sub
        End If

        Dim Frm As New Formyedcomno
        Frm.Tbkongno.Text = Tbkongno.Text
        Showdiaformcenter(Frm, Me)
        If Frm.Tbcancel.Text = "C" Then
            Exit Sub
        End If
        Tbdyedcomno.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Reid").Value)
        REData = New DataTable
        REData = SQLCommand($"SELECT Billdyedno FROM Vrecfabcolmas WHERE Reid = '{Tbdyedcomno.Text}' AND Comid = '{Gscomid}'
                                    UNION
                              SELECT Rbid AS Billdyedno FROM Vrebackfabdet WHERE Rollstat = 'I' AND Comid = '{Gscomid}' 
                                    AND Rbid = '{Tbdyedcomno.Text}' ")
        RS.Text = REData(0)(0)
    End Sub

    Private Sub Tbkgprice_TextChanged(sender As Object, e As EventArgs) Handles Tbkgprice.TextChanged
        If Tbkgprice.Text = "" OrElse Tbkgprice.Text = "." Then
            Tbsummoney.Text = "0.00"
            Exit Sub
        End If

        If CDbl(Tbkgprice.Text) = 0 Then
            Tbsummoney.Text = "0.00"
        End If

        Dim Summoney As Double = CDbl(Tbkgprice.Text) * CDbl(Tbsumwgt.Text)
        Tbsummoney.Text = Format(Summoney, "###,##0.#0")
    End Sub

    Private Sub BindingNavigator1_RefreshItems(sender As Object, e As EventArgs) Handles BindingNavigator1.RefreshItems
        Tsbwsave.Visible = False
        Tbdlvno.Enabled = False
        If Btmedit.Enabled = True Then
            Bindmaster()
        End If
    End Sub


    Private Sub Clrgridmaster()
        Dgvmas.AutoGenerateColumns = False
        Dgvmas.DataSource = Nothing
        Dgvmas.Rows.Clear()
    End Sub

    Private Sub Clrtextmaster()

        'Tbdhid.Text = ""
        'Tbdhname.Text = ""
        Clrmaster()
        Clrdetails()
        Tbdlvno.Text = "NEW"
        Dtpdate.Value = Now
        'Tbpickup.Text = ""
        'Tstbsumroll.Text = ""
        'Tstbsumkg.Text = ""
        'Tbremark.Text = ""
        'Tsbwsave.Visible = False
    End Sub

    Private Sub Clrtextdetails()
        'Tbknitcomno.Text = ""
        Tbclothid.Text = ""
        Tbclothno.Text = ""
        'Tbclothtype.Text = ""
        'Tbqtyroll.Text = ""
        'Tbwgtkg.Text = ""
        'Tbfinwgt.Text = ""
        'Tbfinwidth.Text = ""
        Tbshadeid.Text = ""
        Tbshadename.Text = ""
        'Tbfabbill.Text = ""
        GroupPanel2.Visible = False
    End Sub
    Private Sub Enabledbutton()
        Btdbadd.Enabled = True
        Btdedit.Enabled = True
        Btddel.Enabled = True
    End Sub
    Private Sub Disbaledbutton()
        'Btdbadd.Enabled = False
        Btfindclothno.Enabled = False
        Btfindcusship.Enabled = False
        Btfindcustid.Enabled = False
        Btfindshade.Enabled = False
        Btfindlotno.Enabled = False
        Btdcancel.Enabled = False
        Tbkgprice.Enabled = False
        Tbcolorno.Enabled = False
        Tbremark.Enabled = False
        Dtpdate.Enabled = False
        'Btdadd.Enabled = False
        Btdedit.Enabled = False
        Btddel.Enabled = False
        Btdbadd.Enabled = False
        GroupPanel2.Visible = False
    End Sub
    Private Sub Mainbuttonaddedit()
        Btmnew.Enabled = False
        Btmedit.Enabled = False
        Btmdel.Enabled = False
        Btmsave.Enabled = True
        Btmcancel.Enabled = True
        Btmreports.Enabled = False
        Enabledbutton()
    End Sub
    Private Sub Mainbuttoncancel()
        Btmnew.Enabled = True
        Btmedit.Enabled = False
        Btmdel.Enabled = False
        Btmsave.Enabled = False
        Btmcancel.Enabled = False
        Btmreports.Enabled = False
        Disbaledbutton()

    End Sub

End Class