Imports System.ComponentModel
Imports Microsoft.Reporting.WinForms
Public Class Formdyeform
    Private Tmaster, Tdetails, Tlist, TFablist, TbFabric, FabricTlist, Dttemp As DataTable
    Private Pagecount, Maxrec, Pagesize, Currentpage, Recno As Integer
    Private WithEvents Dtplistfm As New DateTimePicker
    Private WithEvents Dtplistto As New DateTimePicker
    Private WithEvents DtplistFabricfm As New DateTimePicker
    Private WithEvents DtplistFabric As New DateTimePicker
    Private Bs As BindingSource
    Private Cheng = 0

    Private Sub Formdyeform_Load(sender As Object, e As EventArgs) Handles Me.Load
        BindingNavigator1.Enabled = False
        GroupPanel2.Visible = False
        Tbfinddhid.Enabled = False
        Tbpickup.Enabled = False
        Tbremark.Enabled = False
        Dtpdate.Enabled = False
        Dgvmas.Enabled = False
        Btdbadd.Enabled = False
        Btdedit.Enabled = False
        Btddel.Enabled = False
        Tbqtyroll.Enabled = False
        'Tbwgtkg.Enabled = False
        Tbfinwgt.Enabled = False
        Tbfinwidth.Enabled = False
        'Controls.Add(Dtplistfm)
        'Dtplistfm.Value = Now
        'Dtplistfm.Width = 130
        'Me.ToolStrip4.Items.Insert(5, New ToolStripControlHost(Dtplistfm))
        'Me.ToolStrip4.Items(5).Alignment = ToolStripItemAlignment.Right
        'Controls.Add(Dtplistto)
        'Dtplistto.Value = Now
        'Dtplistto.Width = 130
        'Me.ToolStrip4.Items.Insert(4, New ToolStripControlHost(Dtplistto))
        'Me.ToolStrip4.Items(4).Alignment = ToolStripItemAlignment.Right
        '  Setauthorize()
        Retdocprefix()
        Tbmycom.Text = Trim(Gscomname)
        FabricList.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        FabricList.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        FabricList.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        FabricList.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        FabricList.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
        FabricList.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
        FabricList.Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
        FabricList.Columns(7).SortMode = DataGridViewColumnSortMode.NotSortable
        FabricList.Columns(8).SortMode = DataGridViewColumnSortMode.NotSortable
        'ToolStrip6.Visible = False
        Dtplistfm.Visible = False
        Dtplistto.Visible = False

        '------------- Tab Fabric -------------'
        Controls.Add(Dtplistfm)
        Dtplistfm.Value = Now
        Dtplistfm.Width = 130
        Me.ToolStrip4.Items.Insert(5, New ToolStripControlHost(Dtplistfm))
        Me.ToolStrip4.Items(5).Alignment = ToolStripItemAlignment.Right
        Dtplistfm.Visible = False

        Controls.Add(Dtplistto)
        Dtplistto.Value = Now
        Dtplistto.Width = 130
        Me.ToolStrip4.Items.Insert(4, New ToolStripControlHost(Dtplistto))
        Me.ToolStrip4.Items(4).Alignment = ToolStripItemAlignment.Right
        Dtplistto.Visible = False
        '------------- End Tab Fabric -------------'

        'ToolStrip7.Visible = False
    End Sub
    Private Sub Formdyeform_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dgvmas.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        Dgvmas.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        Dgvlist.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        Dgvlist.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        FabricList.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        FabricList.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        BindingFabriclist()
        Bindinglist()
    End Sub
    Private Sub Btmnew_Click(sender As Object, e As EventArgs) Handles Btmnew.Click
        Clrtextmaster()
        Clrtextdetails()
        Clrgridmaster()
        TabControl1.SelectedTabIndex = 2
        BindingNavigator1.Enabled = False
        Tbqtyroll.Enabled = False
        Tbfinddhid.Enabled = True
        Tbpickup.Enabled = True
        Tbremark.Enabled = True
        Dtpdate.Enabled = True
        Dgvmas.Enabled = True
        Btfindshade.Enabled = True
        Mainbuttonaddedit()
    End Sub
    Private Sub Btmedit_Click(sender As Object, e As EventArgs) Handles Btmedit.Click
        Btdedit_Click(sender, e)
        DemoColor(Tbshadeid.Text)
        Tbfinddhid.Enabled = True
        Tbpickup.Enabled = True
        Tbremark.Enabled = True
        Dtpdate.Enabled = True
        Ctdedit.Enabled = True
        Ctddel.Enabled = True
        Btmnew.Enabled = False
        BindingNavigator1.Enabled = False
        Mainbuttonaddedit()
    End Sub
    Private Sub Btmdel_Click(sender As Object, e As EventArgs) Handles Btmdel.Click
        If Trim(Tbdyedcomno.Text) = "NEW" Then
            Exit Sub
        End If
        If Trim(Tbdyedcomno.Text) = "" Then
            Exit Sub
        End If
        If Confirmdelete() = True Then
            Deldetails(Trim(Tbdyedcomno.Text))
            SQLCommand("DELETE FROM Tdyedcomxp WHERE Comid = '" & Gscomid & "' AND Dyecomno = '" & Trim(Tbdyedcomno.Text) & "'")
            Clrtextmaster()
            Clrtextdetails()
            Clrgridmaster()
            BindingFabriclist()
            Bindinglist()
            TabControl1.SelectedTabIndex = 0
            BindingNavigator1.Enabled = False
            Mainbuttoncancel()
        End If
    End Sub
    Private Sub Btmsave_Click(sender As Object, e As EventArgs) Handles Btmsave.Click
        If Tstbdocpre.Text = "" Then
            Informmessage("กรุณาติดต่อ Admin เพื่อกำหนด Prefix ของเลขที่เอกสาร")
            Exit Sub
        End If
        If Validmas() = False Then
            Informmessage("กรุณาตรวจสอบข้อมูลในการส่งให้ครบถ้วน")
            Exit Sub
        End If
        If Validdet() = False Then
            Informmessage("กรุณาตรวจสอบรายละเอียดในการส่งให้ครบถ้วน")
            Exit Sub
        End If

        CountDgvmas.Text = 0
        Tbfinddhid.Enabled = False
        Tbremark.Enabled = False
        Tbpickup.Enabled = False
        Dtpdate.Enabled = False
        Dgvmas.Enabled = False

        If Tbdyedcomno.Text = "NEW" Then
            Newdoc()
            ' Updatestk()
        Else
            Editdoc()
            'Updatestk()
        End If
        Tsbwsave.Visible = False
        Btmreports_Click(sender, e)
        Clrtextmaster()
        Clrtextdetails()
        Clrgridmaster()
        BindingFabriclist()
        Bindinglist()
        TabControl1.SelectedTabIndex = 0
        BindingNavigator1.Enabled = False
        Mainbuttoncancel()
    End Sub
    Private Sub Btmcancel_Click(sender As Object, e As EventArgs) Handles Btmcancel.Click
        Clrtextmaster()
        Clrtextdetails()
        Clrgridmaster()
        TabControl1.SelectedTabIndex = 0
        CountDgvmas.Text = 0
        BindingNavigator1.Enabled = False
        Tbfinddhid.Enabled = False
        Tbremark.Enabled = False
        Tbpickup.Enabled = False
        Dtpdate.Enabled = False
        Dgvmas.Enabled = False
        Mainbuttoncancel()
        'Bindmaster()
    End Sub
    Private Sub Btmreports_Click(sender As Object, e As EventArgs) Handles Btmreports.Click
        If Dgvmas.RowCount = 0 Then
            Exit Sub
        End If
        If Tsbwsave.Visible = True Then
            Informmessage("มีการเปลี่ยนแปลงและยังไม่ทำการบันทึก")
            Exit Sub
        End If
        Binddetails()
        Tsbwsave.Visible = False
        Dim Frm As New Formdyedcomrpt
        Frm.ReportViewer1.Reset()
        'Frm.Tbshipping.Text = Trim(Tbshippingname.Text)
        'Frm.Tbsuplier.Text = Trim(Tbsuppliername.Text)
        Frm.Tbdate.Text = Format(Dtpdate.Value, "dd/MM/yyyy")
        Frm.SendTo.Text = Tbdhname.Text
        'Frm.PickupArea.Text = Tbpickup.Text

        If Tbpickup.Text <> "" Then
            Frm.PickupArea.Text = Tbpickup.Text
        Else
            Frm.PickupArea.Text = " "
        End If

        If Tbremark.Text <> "" Then
            Frm.Note.Text = Tbremark.Text
        Else
            Frm.Note.Text = " "
        End If
        'Frm.Tbsumctn.Text = Tstbsumctn.Text
        'Frm.Tbsumgw.Text = Tstbsumgw.Text
        'Frm.Tbsumnw.Text = Tstbsumnw.Text
        'Frm.Tbsumqty.Text = Tstbsumqty.Text
        'Frm.Tbdlvno.Text = Tbdlvno.Text

        If Gsexpau = False Then
            Frm.ReportViewer1.ShowExportButton = False
        End If
        If Gspriau = False Then
            Frm.ReportViewer1.ShowPrintButton = False
        End If
        Dim rds As New ReportDataSource()
        rds.Name = "DataSet1"
        rds.Value = Tdetails
        Frm.ReportViewer1.LocalReport.DataSources.Add(rds)
        '  Showform(Frm)
        Frm.Show()
        Sumall()
        Clrtextmaster()
        Clrtextdetails()
        Clrgridmaster()
        BindingNavigator1.Enabled = False
        Mainbuttoncancel()
        TabControl1.SelectedTabIndex = 0
    End Sub
    Private Sub Btmfind_Click(sender As Object, e As EventArgs) Handles Btmfind.Click
        Clrtextmaster()
        Clrtextdetails()
        Clrgridmaster()
        TabControl1.SelectedTabIndex = 0
        BindingNavigator1.Enabled = False
        Mainbuttoncancel()
        Tscboth.Checked = True
        Tstbkeyword.Focus()
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
            ToolStripLabel4.Visible = False
            Tscbdate.Checked = False
            Btrefresh.Visible = False
            Dtplistfm.Visible = False
            Dtplistto.Visible = False
            Tstbkeyword.Visible = True
            Tstbkeyword.Select()
            Tstbkeyword.Focus()
        Else
            ToolStripLabel4.Visible = True
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
    Private Sub FabricKeyword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FabricKeyword.KeyPress
        e.Handled = (Asc(e.KeyChar) = 39)
    End Sub
    Private Sub Tstbkeyword_TextChanged(sender As Object, e As EventArgs) Handles Tstbkeyword.TextChanged
        If Me.Created Then
            Btlistfind_Click(sender, e)
        End If
    End Sub
    Private Sub FabricKeyword_TextChanged(sender As Object, e As EventArgs) Handles FabricKeyword.TextChanged
        If Me.Created Then
            FabricSearch_Click(sender, e)
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

    Private Sub FabricSearch_Click(sender As Object, e As EventArgs) Handles FabricSearch.Click
        SearchlistFabric(Trim(FabricKeyword.Text))
    End Sub

    Private Sub Btrefresh_Click(sender As Object, e As EventArgs) Handles Btrefresh.Click
        Bindinglist()
    End Sub
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
    Private Sub Ctmledit_Click(sender As Object, e As EventArgs) Handles Ctmledit.Click
        OriginalTbqtyroll.Text = ""
        Clrtextmaster()
        Clrtextdetails()
        Clrgridmaster()
        TabControl1.SelectedTabIndex = 2
        Tbdyedcomno.DataBindings.Clear()
        Tbdyedcomno.Text = ""
        Bs.Position = Bs.Find("Dyecomno", Trim(Dgvlist.CurrentRow.Cells("Ldyecomno").Value))
        Tbdyedcomno.DataBindings.Add("Text", Bs, "Dyecomno")
        Tbdyedcomno.Enabled = False
        Bindmaster()
        Tbqtyroll.Enabled = False
        Dtpdate.Enabled = False
        Tbpickup.Enabled = False
        Btmreports.Enabled = True
        BindingNavigator1.Enabled = True
        Btmnew.Enabled = False
        Btmedit.Enabled = True
        Btmdel.Enabled = True
        Btmsave.Enabled = False
        Btmcancel.Enabled = False
        Btmreports.Enabled = True
        Btdbadd.Enabled = False
        Btdedit.Enabled = False
        Btddel.Enabled = False
        Ctdedit.Enabled = False
        Ctddel.Enabled = False
        Dgvmas.Enabled = True

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
    Private Sub BindingNavigator1_RefreshItems(sender As Object, e As EventArgs) Handles BindingNavigator1.RefreshItems
        Tsbwsave.Visible = False
        Tbdyedcomno.Enabled = False
        If Btmedit.Enabled = True Then
            Bindmaster()
        End If
    End Sub
    Private Sub Tbfinddhid_Click(sender As Object, e As EventArgs) Handles Tbfinddhid.Click
        Dim Frm As New Formdyedlist
        Showdiaformcenter(Frm, Me)
        If Frm.Tbcancel.Text = "C" Then
            Exit Sub
        End If
        Tbdhid.Text = Frm.Dgvmas.CurrentRow.Cells("Mid").Value
        Tbdhname.Text = Frm.Dgvmas.CurrentRow.Cells("Mname").Value
        Tbpickup.Focus()
    End Sub
    Private Sub Tbfindknitcomno_Click(sender As Object, e As EventArgs) Handles Tbfindknitcomno.Click
        Dim Frm As New Formknitfordyelist
        Showdiaformcenter(Frm, Me)
        If Frm.Tbcancel.Text = "C" Then
            Exit Sub
        End If
        If Frm.SellSums.Text = "" Then
            Exit Sub
        End If

        Tbknitcomno.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Knitcomno").Value)
        Tbclothid.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Clothid").Value)
        Tbclothno.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Clothno").Value)
        Tbclothtype.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Ftype").Value)
        AllFebric.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Qtyroll").Value)
        'Tbqtyroll.Text = Format(Frm.Dgvmas.CurrentRow.Cells("Qtyroll").Value, "###,###")
        If Frm.SellSums.Text > 0 Then
            Tbqtyroll.Enabled = True
            Tbqtyroll.Text = Format(Val(Frm.SellSums.Text), "###,###")
            TbqtyrollTemp.Text = Format(Val(Frm.SellSums.Text), "###,###")
        Else
            Tbqtyroll.Enabled = False
            Tbqtyroll.Text = 0
            TbqtyrollTemp.Text = Format(Val(Frm.SellSums.Text), "###,###")
        End If

        AllWgtkg.Text = Format(Frm.Dgvmas.CurrentRow.Cells("Wgtkg").Value, "###,###.#0")

        CalOneroll.Text = CDbl(AllWgtkg.Text) / CDbl(AllFebric.Text)
        CalOnerollShow.Text = Format(CDbl(CalOneroll.Text), "###,###.#0") 'แสดงทศนิยม 2 ตำแหน่งอย่างเดียว
        If TbqtyrollTemp.Text = "" Then
            TbqtyrollTemp.Text = 0
        End If
        Tbwgtkg.Text = Format(TbqtyrollTemp.Text * CalOneroll.Text, "###,###.#0") ' น้ำหนัก จำนวนปัจจุบันตามจำนวนที่เลือก

        Tbfinwgt.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Finwgt").Value)
        Tbfinwidth.Text = Frm.Dgvmas.CurrentRow.Cells("Fwidth").Value
        Tbqtyroll.Focus()
        If Dgvmas.RowCount > 0 Then
            Btfindshade.Enabled = False
            Tbshadeid.Text = Trim(Dgvmas.Rows(0).Cells("Shid").Value)
            Tbshadename.Text = Trim(Dgvmas.Rows(0).Cells("Mshade").Value)
        Else
            Btfindshade.Enabled = True
        End If

    End Sub
    Private Sub Tbqtyroll_KeyDown(sender As Object, e As KeyEventArgs) Handles Tbqtyroll.KeyDown
        If e.KeyCode = Keys.Enter Then
            Tbwgtkg.Focus()
        End If
    End Sub
    Private Sub Tbwgtkg_KeyDown(sender As Object, e As KeyEventArgs) Handles Tbwgtkg.KeyDown
        If e.KeyCode = Keys.Enter Then
            Tbfinwgt.Focus()
        End If
    End Sub
    Private Sub Tbfinwgt_KeyDown(sender As Object, e As KeyEventArgs) Handles Tbfinwgt.KeyDown
        If e.KeyCode = Keys.Enter Then
            Tbfinwidth.Focus()
        End If
    End Sub
    Private Sub Btfindshade_Click(sender As Object, e As EventArgs) Handles Btfindshade.Click
        Dim Frm As New Formshadelist
        Showdiaformcenter(Frm, Me)
        If Frm.Tbcancel.Text = "C" Then
            Exit Sub
        End If
        If Dgvmas.RowCount > 0 Then
            'Tbshadeid.Text = Trim(Dgvmas.Rows(0).Cells("Shid").Value)
            'Tbshadename.Text = Trim(Dgvmas.Rows(0).Cells("Mshade").Value)

            If Trim(Frm.Dgvmas.CurrentRow.Cells("Mid").Value) <> Trim(Dgvmas.Rows(0).Cells("Shid").Value) AndAlso Dgvmas.RowCount > 1 Then
                Informmessage("Shade ไม่ตรงกันโปรดตรวจสอบอีกครั้ง")
                Exit Sub
            End If
        End If

        Tbshadeid.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Mid").Value)
        Tbshadename.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Mname").Value)
        DemoColor(Tbshadeid.Text)
        Tbfabbill.Focus()
    End Sub
    Private Sub DemoColor(RBGColor As Object)

        Try
            If Dgvmas.RowCount <> 0 OrElse Tbdyedcomno.Text = "NEW" Then
                Dim EBGColor As New DataTable
                EBGColor = SQLCommand($"SELECT Rcolor,Gcolor,Bcolor FROM Tshadexp WHERE Shadeid = '{RBGColor}'")

                If IsDBNull(EBGColor(0)(0)) OrElse IsDBNull(EBGColor(0)(1)) OrElse IsDBNull(EBGColor(0)(2)) Then
                    Informmessage("Shade นี้ยังไม่มีสีตัวอย่าง")
                    DemoCode.BackColor = Color.White
                    Exit Sub
                End If
                DemoCode.BackColor = Color.FromArgb(EBGColor(0)(0), EBGColor(0)(1), EBGColor(0)(2))
            End If
        Catch ex As Exception
            If Tbdyedcomno.Text <> "NEW" Then
                Informmessage("เกิดข้อผิดพลาดในการเปลี่ยนสีตัวอย่าง")
            End If
            DemoCode.BackColor = Color.White
        End Try


    End Sub
    Private Sub Tbfabbill_KeyDown(sender As Object, e As KeyEventArgs) Handles Tbfabbill.KeyDown
        If e.KeyCode = Keys.Enter Then
            Btdadd_Click(sender, e)
        End If
    End Sub
    Private Sub Btdadd_Click(sender As Object, e As EventArgs) Handles Btdadd.Click

        If Validmas() = False Then
            Informmessage("กรุณาเลือกที่โรงย้อม")
            Exit Sub
        End If

        '---------------- New Informmessage ----------------'
        If Tbknitcomno.Text = "" Then
            Informmessage("กรุณาเลือก ใบสั่งทอ")
            Exit Sub
        End If
        If Tbqtyroll.Text = "" Then
            Informmessage("กรุณาตรวจสอบข้อมูลช่องจำนวนพับ")
            Tbqtyroll.Focus()
            Exit Sub
        End If
        If Validnumber() = False Then
            Informmessage("ข้อมูลช่องจำนวนพับหรือน้ำหนักต้องมากกว่า 0")
            Exit Sub
        End If
        If Tbshadeid.Text = "" Then
            Informmessage("กรุณาเลือก Shade")
            Exit Sub
        End If
        If Tbfabbill.Text = "" Then
            Informmessage("กรุณาตรวจสอบข้อมูลช่องบิลผ้าดิบ")
            Tbfabbill.Focus()
            Exit Sub
        End If
        '---------------- End New Informmessage ----------------'

        If Validinput() = False Then
            Informmessage("กรุณาตรวจสอบข้อมูลให้ถูกต้อง ครบถ้วน")
            Exit Sub
        End If

        If Tbaddedit.Text = "เพิ่ม" Then
            If Chkdupyarnidingrid() = True Then
                Informmessage("เลขที่สั่งทอและผ้าเบอร์นี้มีแล้ว")
                Exit Sub
            End If
        End If

        Dim SumSell = New DataTable
        SumSell = SQLCommand($"SELECT SUM(Qtyroll) As SumSell, SUM(Qtykg) As Qtykg FROM Tdyedcomdetxp WHERE Knittcomid = '{Tbknitcomno.Text}' and Clothid= '{Tbclothid.Text}'")
        SumSellEdit.DataSource = SumSell
        Dim SumSellCash = If(IsDBNull(SumSellEdit.Rows(0).Cells("SumSell").Value), "0", SumSellEdit.Rows(0).Cells("SumSell").Value - TbqtyrollTemp.Text)
        'MessageBox.Show(Tbqtyroll.Text)

        If Tbaddedit.Text = "เพิ่ม" AndAlso CLng(Tbqtyroll.Text) > CLng(TbqtyrollTemp.Text) Then
            Informmessage("จำนวนพับคงเหลือน้อยกว่าที่ระบุ") 'เพิ่มใหม่ใส่เกิน
            Exit Sub
        End If
        'Label1.Text = AllWgtkg.Text - SumSell(0)(1)

        Dim Frm As New Formknitfordyelist
        'MessageBox.Show($"{Tbqtyroll.Text }:{ TbqtyrollTemp.Text}")


        'TbqtyrollTemp คงเหลือ
        'SumSellCash ทั้งหมด
        'Tbqtyroll ค่าที่ใส่


        'If CLng(Tbqtyroll.Text) > CLng(SumSellCash) Then
        '    Informmessage("จำนวนพับคงเหลือน้อยกว่าที่ระบุ A") 'แก้ไขใส่เกิน
        '    Exit Sub
        'End If

        If Tbdyedcomno.Text = "NEW" Then
            If OriginalTbqtyroll.Text = "" And Tbaddedit.Text = "แก้ไข" Then
                OriginalTbqtyroll.Text = Format(CLng(Dgvmas.CurrentRow.Cells("Mqty").Value), "###,###")
                If Tbaddedit.Text = "แก้ไข" AndAlso CLng(Tbqtyroll.Text) > CLng(TbqtyrollTemp.Text) Then
                    Informmessage("จำนวนพับคงเหลือน้อยกว่าที่ระบุ") 'เพิ่มใหม่ใส่เกิน
                    Exit Sub
                End If
            Else
                If Tbaddedit.Text = "แก้ไข" AndAlso CLng(Tbqtyroll.Text) > CLng(TbqtyrollTemp.Text) Then
                    Informmessage("จำนวนพับคงเหลือน้อยกว่าที่ระบุ") 'เพิ่มใหม่ใส่เกิน
                    Exit Sub
                End If
            End If
        Else
            If OriginalTbqtyroll.Text = "" And Tbaddedit.Text = "แก้ไข" Then
                OriginalTbqtyroll.Text = Format(CLng(Dgvmas.CurrentRow.Cells("Mqty").Value), "###,###")
                If Tbaddedit.Text = "แก้ไข" AndAlso CLng(Tbqtyroll.Text) > CLng(OriginalTbqtyroll.Text) + CLng(TbqtyrollTemp.Text) Then
                    Informmessage("จำนวนพับคงเหลือน้อยกว่าที่ระบุ") 'เพิ่มใหม่ใส่เกิน
                    'Exit Sub
                End If
            Else
                If Tbaddedit.Text = "แก้ไข" AndAlso CLng(Tbqtyroll.Text) > CLng(OriginalTbqtyroll.Text) + CLng(TbqtyrollTemp.Text) Then
                    Informmessage("จำนวนพับคงเหลือน้อยกว่าที่ระบุ") 'เพิ่มใหม่ใส่เกิน
                    'Exit Sub
                End If
            End If
        End If

        If AllWgtkg.Text < Tbwgtkg.Text + SumSell(0)(1) AndAlso Tbaddedit.Text = "เพิ่ม" Then
            Informmessage($"น้ำหนักรวมผ้า น้อยกว่าที่ระบุ")
        End If

        'If Tbwgtkg.Text + SumSell(0)(1) > AllWgtkg.Text AndAlso Tbaddedit.Text = "แก้ไข" Then
        '    AllWgtkg

        'If OriginalTbqtyroll.Text = "" And Tbaddedit.Text = "แก้ไข" Then
        '    OriginalTbqtyroll.Text = Format(CLng(Dgvmas.CurrentRow.Cells("Mqty").Value), "###,###")
        '    If Tbaddedit.Text = "แก้ไข" AndAlso CLng(Tbqtyroll.Text) > CLng(OriginalTbqtyroll.Text) + CLng(TbqtyrollTemp.Text) Then
        '        Informmessage("จำนวนพับคงเหลือน้อยกว่าที่ระบุ C") 'เพิ่มใหม่ใส่เกิน
        '        Exit Sub
        '    End If
        'Else
        '    If Tbaddedit.Text = "แก้ไข" AndAlso CLng(Tbqtyroll.Text) > CLng(OriginalTbqtyroll.Text) + CLng(TbqtyrollTemp.Text) Then
        '        Informmessage("จำนวนพับคงเหลือน้อยกว่าที่ระบุ D") 'เพิ่มใหม่ใส่เกิน
        '        Exit Sub
        '    End If
        'End If

        Select Case Trim(Tbaddedit.Text)
            Case "เพิ่ม"
                If Tbdyedcomno.Text = "NEW" Then
                    Dgvmas.Rows.Add()
                Else
                    Tdetails.Rows.Add()
                End If
                Tsbwsave.Visible = True
                CountDgvmas.Text = CountDgvmas.Text + 1
                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("ord").Value = Trim(CountDgvmas.Text)
                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Dknittno").Value = Trim(Tbknitcomno.Text)
                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Clothid").Value = Trim(Tbclothid.Text)
                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Clothno").Value = Trim(Tbclothno.Text)
                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Ftype").Value = Trim(Tbclothtype.Text)
                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Mfinwid").Value = Trim(Tbfinwidth.Text)
                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Shid").Value = Trim(Tbshadeid.Text)
                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Mshade").Value = Trim(Tbshadename.Text)
                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Mqty").Value = CLng(Tbqtyroll.Text)
                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Mkg").Value = CDbl(Tbwgtkg.Text)
                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Mfinwgt").Value = Trim(Tbfinwgt.Text)
                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Mbrawfab").Value = Trim(Tbfabbill.Text)
            Case "แก้ไข"
                Tsbwsave.Visible = True
                Dgvmas.CurrentRow.Cells("Dknittno").Value = Trim(Tbknitcomno.Text)
                Dgvmas.CurrentRow.Cells("Clothid").Value = Trim(Tbclothid.Text)
                Dgvmas.CurrentRow.Cells("Clothno").Value = Trim(Tbclothno.Text)
                Dgvmas.CurrentRow.Cells("Ftype").Value = Trim(Tbclothtype.Text)
                Dgvmas.CurrentRow.Cells("Mfinwid").Value = Trim(Tbfinwidth.Text)
                Dgvmas.CurrentRow.Cells("Shid").Value = Trim(Tbshadeid.Text)
                Dgvmas.CurrentRow.Cells("Mshade").Value = Trim(Tbshadename.Text)
                Dgvmas.CurrentRow.Cells("Mqty").Value = CLng(Tbqtyroll.Text)
                Dgvmas.CurrentRow.Cells("Mkg").Value = CDbl(Tbwgtkg.Text)
                Dgvmas.CurrentRow.Cells("Mfinwgt").Value = Trim(Tbfinwgt.Text)
                Dgvmas.CurrentRow.Cells("Mbrawfab").Value = Trim(Tbfabbill.Text)
        End Select
        Sumall()
        Btdcancel_Click(sender, e)
        Tbremark.Focus()

        Tbknitcomno.Text = ""
        Tbclothid.Text = ""
        Tbclothno.Text = ""
        Tbclothtype.Text = ""
        Tbqtyroll.Text = ""
        Tbwgtkg.Text = ""
        Tbfinwgt.Text = ""
        Tbfinwidth.Text = ""
        Tbshadeid.Text = ""
        Tbshadename.Text = ""
        Tbfabbill.Text = ""
        Tbqtyroll.Enabled = False
    End Sub
    Private Sub Btdcancel_Click(sender As Object, e As EventArgs) Handles Btdcancel.Click
        Tbknitcomno.Text = ""
        Tbclothtype.Text = ""
        Tbqtyroll.Text = ""
        Tbfinwgt.Text = ""
        Tbshadeid.Text = ""
        Tbclothid.Text = ""
        Tbclothno.Text = ""
        ItemNo.Text = ""
        Tbwgtkg.Text = ""
        Tbfinwidth.Text = ""
        Tbshadename.Text = ""
        Tbfabbill.Text = ""
        AllFebric.Text = ""
        AllWgtkg.Text = ""
        TbqtyrollTemp.Text = ""
        CalOneroll.Text = ""
        Tbqtyroll.Enabled = False
    End Sub
    Private Sub Btdbadd_Click(sender As Object, e As EventArgs) Handles Btdbadd.Click
        Btdcancel_Click(sender, e)
        GroupPanel2.Visible = True
        Tbqtyroll.Enabled = False
        Tbaddedit.Text = "เพิ่ม"
        Tbknitcomno.Text = ""
        Tbclothid.Text = ""
        Tbclothno.Text = ""
        Tbclothtype.Text = ""
        Tbqtyroll.Text = ""
        Tbwgtkg.Text = ""
        Tbfinwgt.Text = ""
        Tbfinwidth.Text = ""
        Tbshadeid.Text = ""
        Tbshadename.Text = ""
        Tbfabbill.Text = ""
        TbqtyrollTemp.Text = ""
    End Sub
    Private Sub Btdedit_Click(sender As Object, e As EventArgs) Handles Btdedit.Click
        Cheng = 0
        GroupPanel2.Visible = True
        If Dgvmas.RowCount = 0 Then
            Exit Sub
        End If
        If Validmas() = False Then
            Informmessage("กรุณาเลือกที่โรงย้อม")
            Exit Sub
        End If
        Tbaddedit.Text = "แก้ไข"
        Tbqtyroll.Enabled = True
        Tbknitcomno.Text = Trim(Dgvmas.CurrentRow.Cells("Dknittno").Value)
        Tbclothid.Text = Trim(Dgvmas.CurrentRow.Cells("Clothid").Value)
        Tbclothno.Text = Trim(Dgvmas.CurrentRow.Cells("Clothno").Value)
        Tbclothtype.Text = Trim(Dgvmas.CurrentRow.Cells("Ftype").Value)
        Tbfinwidth.Text = Trim(Dgvmas.CurrentRow.Cells("Mfinwid").Value)
        Tbshadeid.Text = Trim(Dgvmas.CurrentRow.Cells("Shid").Value)
        Tbshadename.Text = Trim(Dgvmas.CurrentRow.Cells("Mshade").Value)
        Tbqtyroll.Text = Format(CLng(Dgvmas.CurrentRow.Cells("Mqty").Value), "###,###")
        Tbfinwgt.Text = Trim(Dgvmas.CurrentRow.Cells("Mfinwgt").Value)
        Tbfabbill.Text = Trim(Dgvmas.CurrentRow.Cells("Mbrawfab").Value)

        If OriginalTbqtyroll.Text = "" Then
            OriginalTbqtyroll.Text = Format(CLng(Dgvmas.CurrentRow.Cells("Mqty").Value), "###,###")
        End If


        Tbqtyroll.Focus()

        Dim SumSell = New DataTable
        SumSell = SQLCommand($"SELECT SUM(Qtyroll) As SumSell FROM Tdyedcomdetxp WHERE Knittcomid = '{Tbknitcomno.Text}' and Clothid= '{Tbclothid.Text}'")
        SumSellEdit.DataSource = SumSell
        Dim SumSellCash = If(IsDBNull(SumSellEdit.Rows(0).Cells("SumSell").Value), "0", SumSellEdit.Rows(0).Cells("SumSell").Value)

        'MessageBox.Show(SumSellCash)

        Dim EditCheckStock = New DataTable
        EditCheckStock = SQLCommand($"Select SUM(Qtyroll) As Sum FROM Vknitcomdet WHERE Knitcomno = '{Tbknitcomno.Text}' and Clothid= '{Tbclothid.Text}'")
        CheckStock.DataSource = EditCheckStock
        TbqtyrollTemp.Text = If(IsDBNull(CheckStock.Rows(0).Cells("Sum").Value), "", (CheckStock.Rows(0).Cells("Sum").Value - SumSellCash))

        If TbqtyrollTemp.Text = "" Then
            TbqtyrollTemp.Text = 0
        End If

        Dim CountFabricAll = New DataTable
        CountFabricAll = SQLCommand($"SELECT Qtyroll,Wgtkg FROM Vknitcomdet  WHERE Knitcomno = '{Tbknitcomno.Text}' And Clothid = '{Tbclothid.Text}'")
        'MessageBox.Show(CountFabricAll(0)(0))
        Try
            AllFebric.Text = CountFabricAll(0)(0)
            AllWgtkg.Text = Format(CountFabricAll(0)(1), "###,###.#0")
        Catch ex As Exception
            If AllFebric.Text = "" Then
                MessageBox.Show($"ไม่พบข้อมูลใบสั่งทอเลขที่: {Tbknitcomno.Text}", "ข้อผิดพลาดร้ายแรง", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'Informmessage($"ไม่พบใบสั่งทอเลขที่: {Tbknitcomno.Text} อาจมีการลบใบสั่งทอนี้แล้ว")
                AllFebric.Text = 0
                AllWgtkg.Text = 0
            End If
        End Try
        CalOneroll.Text = CDbl(AllWgtkg.Text) / CDbl(AllFebric.Text)
        CalOnerollShow.Text = Format(CDbl(CalOneroll.Text), "###,###.#0") 'แสดงทศนิยม 2 ตำแหน่งอย่างเดียว
        If CalOnerollShow.Text = "NaN" Then
            CalOnerollShow.Text = 0
        End If
        'AllWgtkg.Text = Format(CDbl(Dgvmas.CurrentRow.Cells("Mkg").Value), "###,###.#0")
        If Tbaddedit.Text = "แก้ไข" Then
            Tbwgtkg.Text = Format(CDbl(Dgvmas.CurrentRow.Cells("Mkg").Value), "###,###.#0")
        End If

        'If Cheng = 2 Then
        '    Tbwgtkg.Text = Format(Tbqtyroll.Text * CalOneroll.Text, "###,###.#0") ' น้ำหนัก จำนวนปัจจุบันตามจำนวนที่เลือก
        '    Cheng = 0
        'End If
        'MessageBox.Show(Tbclothid.Text)

        'Dim EditCheckStock = New DataTable
        'EditCheckStock = SQLCommand($"SELECT SUM(Qtyroll) AS Sum FROM Tdyedcomdetxp WHERE Knittcomid = '{Tbknitcomno.Text}' and Clothid= '{Tbclothid.Text}'")
        'CheckStock.DataSource = EditCheckStock

        'SellSums.Text = If(IsDBNull(CheckStock.Rows(0).Cells("Sum").Value), Qtyroll, (Qtyroll - DataSum.Rows(0).Cells("Sum").Value))

        'SELECT Qtyroll FROM Vknitcomdet WHERE Knitcomno = 'Tbknitcomno.Text' and Clothid= 'Tbclothid.Text' --ที่มีอยู่ในระบบ
    End Sub
    Private Sub Btddel_Click(sender As Object, e As EventArgs) Handles Btddel.Click
        If Dgvmas.RowCount = 0 Then
            Exit Sub
        End If
        If Dgvmas.RowCount = 1 Then
            DemoCode.BackColor = Color.White
        End If

        Tbaddedit.Text = "เพิ่ม"
        Btdcancel_Click(sender, e)
        Tsbwsave.Visible = True
        Dgvmas.Rows.Remove(Dgvmas.CurrentRow)
        Sumall()

        For i = 0 To Dgvmas.RowCount - 1
            Dim Rows As Integer = i + 1
            Dgvmas.Rows(i).Cells("ord").Value = Rows
            'MessageBox.Show(Rows)
        Next
    End Sub
    Private Sub Dgvmas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvmas.CellClick
        If Tbaddedit.Text = "แก้ไข" Then
            Tbqtyroll.Enabled = False
            OriginalTbqtyroll.Text = ""
            Tbknitcomno.Text = ""
            Tbclothtype.Text = ""
            Tbqtyroll.Text = ""
            Tbfinwgt.Text = ""
            Tbshadeid.Text = ""
            Tbclothid.Text = ""
            Tbclothno.Text = ""
            ItemNo.Text = ""
            Tbwgtkg.Text = ""
            Tbfinwidth.Text = ""
            Tbshadename.Text = ""
            Tbfabbill.Text = ""
            AllFebric.Text = ""
            AllWgtkg.Text = ""
            TbqtyrollTemp.Text = ""
            CalOneroll.Text = ""
            Tbaddedit.Text = "เพิ่ม"
        End If

        If Dgvmas.RowCount = 0 Then
            Exit Sub
        End If
        Dgvmas.CurrentRow.Selected = True
    End Sub
    Private Sub Dgvmas_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Dgvmas.CellMouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If Me.Dgvmas.Rows.Count < 1 Then Exit Sub
            If e.RowIndex < 0 Then Exit Sub
            'Dgvmas.CurrentCell = Dgvmas(3, e.RowIndex)
            Me.Dgvmas.Rows(e.RowIndex).Selected = True
            Editcontextdetmenu()
        End If
    End Sub
    Private Sub Ctdedit_Click(sender As Object, e As EventArgs) Handles Ctdedit.Click
        Btdedit_Click(sender, e)
    End Sub
    Private Sub Ctddel_Click(sender As Object, e As EventArgs) Handles Ctddel.Click
        Btddel_Click(sender, e)
    End Sub
    Private Sub Formdyeform_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Tbdyedcomno.Text = "NEW" And Dgvmas.RowCount = 0 Then
            'My.Forms.Formmain.Panel1.Visible = True
            Exit Sub
        End If
        If Confirmcloseform("ใบสั่งย้อม") Then
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
        Tlist = SQLCommand("SELECT '' AS Stat,* FROM Vdyedcommas
                                WHERE Comid = '" & Gscomid & "' AND (Dyecomno LIKE '%' + '" & Sval & "' + '%' OR Dyedhdesc LIKE '%' + '" & Sval & "' + '%')")
        FillGrid()
        ShowRecordDetail()
    End Sub
    Private Sub SearchlistFabric(Sval As String)
        If Sval = "" Then
            BindingFabriclist()
            Exit Sub
        End If
        TFablist = SQLCommand("SELECT '' AS Stat,* FROM Vknitcomdet
                                WHERE Comid = '" & Gscomid & "' AND (Knitcomno LIKE '%' + '" & Sval & "' + '%' OR Clothno LIKE '%' + '" & Sval & "' + '%' OR Ftype LIKE '%' + '" & Sval & "' + '%' OR Qtyroll LIKE '%' + '" & Sval & "' + '%')")
        FabricList.DataSource = TFablist

        InsertDataFab()

        'FillGrid()
        'ShowRecordDetail()
    End Sub
    Private Sub Searchlistbydate()
        Tlist = SQLCommand("SELECT '' AS Stat,* FROM Vdyedcommas
                                WHERE Comid = '" & Gscomid & "' AND (Dyeddate BETWEEN '" & Formatshortdatesave(Dtplistfm.Value) & "' AND '" & Formatshortdatesave(Dtplistto.Value) & "')")
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
        Tbdyedcomno.Text = Trim(Tstbdocpre.Text) & Genid()
        Insertmaster()
        SQLCommand("UPDATE Tdocprexp SET Lvalue = '" & Trim(Tbdyedcomno.Text).Remove(0, 2) & "',Updusr = '" & Gsuserid & "',Uptype = 'E',Uptime = '" & Formatdatesave(Now) & "' 
                        WHERE  Comid = '" & Gscomid & "' AND Docid = '" & Tstbdocpreid.Text & "' AND Prefix = '" & Trim(Tstbdocpre.Text) & "'")
        Upddetails("A")
        If Gsusername = "SUPHATS" Then
        Else
            Insertlog(Gscomid, Gsusergroupid, Gsuserid, Gsusername, "F122", Trim(Tbdyedcomno.Text), "A", "สร้างรายการ ใบสั่งทอ", Formatdatesave(Now), Computername, Usrproname)
        End If
    End Sub
    Private Sub Editdoc()
        If Tbdyedcomno.Text = "NEW" Then
            Exit Sub
        End If
        Editmaster()
        Upddetails("E")
        If Gsusername = "SUPHATS" Then
        Else
            Insertlog(Gscomid, Gsusergroupid, Gsuserid, Gsusername, "F122", Trim(Tbdyedcomno.Text), "E", "แก้ไขรายการ ใบสั่งทอ", Formatdatesave(Now), Computername, Usrproname)
        End If
    End Sub
    Private Sub Insertmaster()
        SQLCommand("INSERT INTO Tdyedcomxp(Comid,Dyecomno,Dyeddate,Dhid,Pickarea,
                    Dremark,Updusr,Uptype,Uptime)     
                    VALUES('" & Gscomid & "','" & Trim(Tbdyedcomno.Text) & "','" & Formatshortdatesave(Dtpdate.Value) & "','" & Tbdhid.Text & "','" & Trim(Tbpickup.Text) & "',
                    '" & Trim(Tbremark.Text) & "','" & Gsuserid & "','A','" & Formatdatesave(Now) & "')")
    End Sub
    Private Sub Editmaster()
        SQLCommand("UPDATE Tdyedcomxp SET Dyeddate = '" & Formatshortdatesave(Dtpdate.Value) & "',Dhid = '" & Trim(Tbdhid.Text) & "',Pickarea = '" & Trim(Tbpickup.Text) & "',
                    Dremark = '" & Trim(Tbremark.Text) & "',Updusr = '" & Gsuserid & "',Uptype = 'E',Uptime = '" & Formatdatesave(Now) & "'
                    WHERE Comid = '" & Gscomid & "' AND Dyecomno = '" & Trim(Tbdyedcomno.Text) & "'")
    End Sub
    Private Sub Deldetails(Tdlvno As String)
        SQLCommand("DELETE FROM Tdyedcomdetxp
                    WHERE Comid = '" & Gscomid & "' AND  Dyedcomno = '" & Tdlvno & "'")
    End Sub
    Private Sub Upddetails(Etype As String)
        Deldetails(Trim(Tbdyedcomno.Text))
        Dim I As Integer
        ProgressBarX1.Value = 0
        Dim Frm As New Formwaitdialoque
        Frm.Show()
        Dim Tknitcomno, Tclotid, Tshadeid, Tfinwgt, Tknitbill As String
        Dim Tqtyroll As Long
        Dim Tqtykg As Double
        For I = 0 To Dgvmas.RowCount - 1
            Tknitcomno = Trim(Dgvmas.Rows(I).Cells("Dknittno").Value)
            Tclotid = Trim(Dgvmas.Rows(I).Cells("Clothid").Value)
            Tshadeid = Trim(Dgvmas.Rows(I).Cells("Shid").Value)
            Tqtyroll = Dgvmas.Rows(I).Cells("Mqty").Value
            Tqtykg = Dgvmas.Rows(I).Cells("Mkg").Value
            Tfinwgt = Trim(Dgvmas.Rows(I).Cells("Mfinwgt").Value)
            Tknitbill = Dgvmas.Rows(I).Cells("Mbrawfab").Value
            Dim numrow = I + 1
            SQLCommand("INSERT INTO Tdyedcomdetxp(Comid,Dyedcomno,Ord,Knittcomid,Clothid,Shadeid,
                        Qtyroll,Qtykg,Finwgt,Knittbill,
                        Updusr,Uptype,Uptime)
                        VALUES('" & Gscomid & "','" & Trim(Tbdyedcomno.Text) & "'," & numrow & ",'" & Tknitcomno & "','" & Tclotid & "','" & Tshadeid & "'
                        ," & Tqtyroll & "," & Tqtykg & ",'" & Tfinwgt & "','" & Tknitbill & "',
                        '" & Gsuserid & "','" & Etype & "','" & Formatdatesave(Now) & "')")
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
        Tmaster = SQLCommand("SELECT * FROM Vdyedcommas 
                                WHERE Comid = '" & Gscomid & "' AND Dyecomno = '" & Trim(Tbdyedcomno.Text) & "'")
        If Tmaster.Rows.Count > 0 Then
            Dtpdate.Value = Tmaster.Rows(0)("Dyeddate")
            Tbdhid.Text = Tmaster.Rows(0)("Dhid")
            Tbdhname.Text = Trim(Tmaster.Rows(0)("Dyedhdesc"))
            Tbpickup.Text = Trim(Tmaster.Rows(0)("Pickarea"))
            Tbremark.Text = Trim(Tmaster.Rows(0)("Dremark"))
            Binddetails()
            Sumall()
        End If
    End Sub
    Private Sub Binddetails()
        Tdetails = New DataTable
        Tdetails = SQLCommand("SELECT '' AS Stat,* FROM Vdyedcomdet
                                WHERE Comid = '" & Gscomid & "' AND Dyedcomno = '" & Trim(Tbdyedcomno.Text) & "' ORDER BY Ord")
        Dgvmas.DataSource = Tdetails
        CountDgvmas.Text = Dgvmas.Rows.Count
    End Sub
    Private Sub Bindinglist()
        Tlist = New DataTable
        Tlist = SQLCommand("SELECT '' AS Stat,* FROM Vdyedcommas WHERE Comid = '" & Gscomid & "'")
        Dgvlist.DataSource = Tlist
        Bs = New BindingSource
        Bs.DataSource = Tlist
        BindingNavigator1.BindingSource = Bs
        FillGrid()
        ShowRecordDetail()
    End Sub
    Private Sub BindingFabriclist()

        TFablist = New DataTable
        TFablist = SQLCommand("SELECT '' AS Stat,* FROM Vknitcomdet 
                            WHERE Comid = '" & Gscomid & "'")
        FabricList.DataSource = TFablist
        'Tlist = TFablist
        InsertDataFab()


        'FillGrid()
        'ShowRecordDetail()
    End Sub

    Private Sub InsertDataFab()
        Dim SumQtyroll As New DataTable
        'SumQtyroll = SQLCommand("SELECT SUM(Qtyroll) AS SUM FROM Tdyedcomdetxp WHERE Knittcomid ='VC180900008' AND Clothid = '10001' --ส่งไปย้อม แล้วนับจำนวน")
        'SumQtyrolls.DataSource = SumQtyroll
        'SumQtyroll.Rows.Add()
        'SumQtyrolls.Rows(1).Cells("SUM").Value = 0

        For I = 0 To FabricList.RowCount - 1
            'MessageBox.Show(" VC:" & FabricList.Rows(I).Cells("Knitcomno").Value & " Lot:" & FabricList.Rows(I).Cells("Clothids").Value)
            SumQtyroll = SQLCommand($"SELECT '' AS Stat, SUM(Qtyroll) AS SUM FROM Tdyedcomdetxp WHERE Knittcomid ='{FabricList.Rows(I).Cells("Knitcomno").Value}' AND Clothid = '{FabricList.Rows(I).Cells("Clothids").Value}' --ส่งไปย้อม แล้วนับจำนวน")
            SumQtyrolls.DataSource = SumQtyroll
            FabricList.Rows(I).Cells("Dye").Value = IIf((IsDBNull(SumQtyrolls.Rows(0).Cells("Sum").Value) = True), 0, SumQtyrolls.Rows(0).Cells("Sum").Value)
            FabricList.Rows(I).Cells("Balance").Value = FabricList.Rows(I).Cells("Qtyroll").Value - FabricList.Rows(I).Cells("Dye").Value
        Next

        For I = FabricList.RowCount - 1 To 0 Step -1
            If FabricList.Rows(I).Cells("Balance").Value <= 0 Then
                'MessageBox.Show(FabricList.Rows(I).Cells("Knitcomno").Value)
                FabricList.Rows.Remove(FabricList.Rows(I))
            End If
        Next
    End Sub

    Private Sub Sumall()
        Dim Sumkg As Double
        Dim Sumroll As Long
        Sumroll = 0
        Sumkg = 0.0
        If Dgvmas.RowCount = 0 Then
            Tstbsumroll.Text = Sumroll
            Tstbsumkg.Text = Sumkg
            Exit Sub
        End If
        ProgressBarX1.Value = 0
        Dim Frm As New Formwaitdialoque
        Frm.Show()
        Dim I As Integer
        For I = 0 To Dgvmas.RowCount - 1
            Sumroll = Sumroll + CLng(Dgvmas.Rows(I).Cells("Mqty").Value)
            Sumkg = Sumkg + CDbl(Dgvmas.Rows(I).Cells("Mkg").Value)
            ProgressBarX1.Value = ((I + 1) / Dgvmas.Rows.Count) * 100
            ProgressBarX1.Text = "Caculating sum ... " & ProgressBarX1.Value & "%"
        Next
        Frm.Close()
        ProgressBarX1.Text = "Ready"
        ProgressBarX1.Value = 0
        Tstbsumroll.Text = Sumroll
        Tstbsumkg.Text = Format(Sumkg, "###,###.#0")
    End Sub
    Private Sub Clrgridmaster()
        Dgvmas.AutoGenerateColumns = False
        Dgvmas.DataSource = Nothing
        Dgvmas.Rows.Clear()
    End Sub
    Private Sub Clrtextmaster()
        Tbdhid.Text = ""
        Tbdhname.Text = ""
        Tbdyedcomno.Text = "NEW"
        Dtpdate.Value = Now
        Tbpickup.Text = ""
        Tstbsumroll.Text = ""
        Tstbsumkg.Text = ""
        Tbremark.Text = ""
        AllFebric.Text = ""
        AllWgtkg.Text = ""
        TbqtyrollTemp.Text = ""
        CalOneroll.Text = ""
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
    Private Function Validinput() As Boolean
        Dim Valid As Boolean = False
        If Tbclothid.Text <> "" And Tbclothno.Text <> "" And Tbclothtype.Text <> "" And
            Tbwgtkg.Text <> "" And Tbfinwgt.Text <> "" And Tbfinwidth.Text <> "" And Tbshadename.Text <> "" Then
            Valid = True
        End If
        Return Valid
    End Function
    Private Function Validnumber() As Boolean
        Dim Valid As Boolean = False
        If CLng(Tbqtyroll.Text) > 0 And CDbl(Tbwgtkg.Text > 0) Then
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
    Private Sub DisplayPageInfo()
        Tbpage.Text = "หน้า " & Currentpage.ToString & "/" & Pagecount.ToString
    End Sub
    Private Sub ShowRecordDetail()
        Tbrecord.Text = "แสดง " & (Dgvlist.RowCount) & " รายการ จาก " & Tlist.Rows.Count & " รายการ"
        'ToolStripTextBox4.Text = "แสดง " & (FabricList.RowCount) & " รายการ จาก " & Tlist.Rows.Count & " รายการ"
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

    Private Sub ButtonItem2_Click(sender As Object, e As EventArgs) Handles ButtonItem2.Click
        TabControl1.SelectedTabIndex = 2
        Btmnew_Click(sender, e)
        Btdbadd_Click(sender, e)
        Tbknitcomno.Text = Trim(FabricList.CurrentRow.Cells("Knitcomno").Value)
        Tbclothid.Text = Trim(FabricList.CurrentRow.Cells("Clothids").Value)
        Tbclothno.Text = Trim(FabricList.CurrentRow.Cells("Clothnos").Value)
        Tbclothtype.Text = Trim(FabricList.CurrentRow.Cells("Ftypes").Value)
        'ItemNo.Text = 0
        Tbqtyroll.Enabled = True
        Tbqtyroll.Text = Trim(FabricList.CurrentRow.Cells("Balance").Value)
        TbqtyrollTemp.Text = Trim(FabricList.CurrentRow.Cells("Balance").Value)
        AllFebric.Text = Trim(FabricList.CurrentRow.Cells("Qtyroll").Value)
        AllWgtkg.Text = Format(FabricList.CurrentRow.Cells("Wgtkg").Value, "###,###.#0")
        CalOneroll.Text = CDbl(AllWgtkg.Text) / CDbl(AllFebric.Text)
        CalOnerollShow.Text = Format(CDbl(CalOneroll.Text), "###,###.#0") 'แสดงทศนิยม 2 ตำแหน่งอย่างเดียว
        Tbfinwgt.Text = Format(FabricList.CurrentRow.Cells("Finwgt").Value)
        Tbfinwidth.Text = Format(FabricList.CurrentRow.Cells("Fwidth").Value)
        Tbwgtkg.Text = Format(TbqtyrollTemp.Text * CalOneroll.Text, "###,###.#0") ' น้ำหนัก จำนวนปัจจุบันตามจำนวนที่เลือก


        'MessageBox.Show(0)
    End Sub

    Private Sub FabricList_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles FabricList.CellMouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If Me.FabricList.Rows.Count < 1 Then Exit Sub
            If e.RowIndex < 0 Then Exit Sub
            'FabricList.CurrentCell = FabricList(2, e.RowIndex)
            Me.FabricList.Rows(e.RowIndex).Selected = True
            EditcontextFabricList()
        End If
    End Sub

    Private Sub BtrefreshFabric_Click(sender As Object, e As EventArgs) Handles BtrefreshFabric.Click
        BindingFabriclist()
    End Sub

    'Private Sub Tbqtyroll_TextChanged(sender As Object, e As EventArgs) Handles Tbqtyroll.KeyPress
    '    MessageBox.Show("Hello My Proscess")
    'End Sub


    Private Sub EditcontextFabricList()
        ButtonItem1.Displayed = False
        ButtonItem1.PopupMenu(Control.MousePosition)
    End Sub

    Private Sub Tbqtyroll_TextChanged(sender As Object, e As EventArgs) Handles Tbqtyroll.TextChanged
        'MsgBox(Cheng) 'ถ้ามีการแก้ไขตัวเลขพับ จะถูก +1 และถ้ามากกว่า 1 จะมีการคำนวนน้ำหนักใหม่
        Cheng = Cheng + 1
    End Sub

    Private Function Validmas() As Boolean
        Dim Valid As Boolean = False
        If Tbdhid.Text <> "" And Tbdhname.Text <> "" Then
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
        If Gscreau = False Then
            Btmnew.Visible = False
            Btmsave.Visible = False
        End If
        If Gswriau = False Then
            Btmsave.Visible = False
            Btmedit.Visible = False
        End If
        If Gsdelau = False Then
            Btmdel.Visible = False
        End If
        If Gspriau = False Then
            Btmreports.Visible = False
        End If
        If Gsseaau = False Then
            Btmfind.Visible = False
            Tstbkeyword.Visible = False
            Btlistfind.Visible = False
            Btrefresh.Visible = False
        End If
    End Sub

    Private Function Chkdupyarnidingrid() As Boolean
        Dim Dup As Boolean = False
        If Dgvmas.RowCount = 0 Then
            Dup = False
        Else
            Dim I As Integer
            For I = 0 To Dgvmas.RowCount - 1
                If Trim(Tbknitcomno.Text) = Trim(Dgvmas.Rows(I).Cells("Dknittno").Value) And Trim(Tbclothid.Text) = Trim(Dgvmas.Rows(I).Cells("Clothid").Value) Then
                    Dup = True
                    Exit For
                End If
            Next
        End If
        Return Dup
    End Function
    Private Sub Clrtextdetails()
        DemoCode.BackColor = Color.White
        Tbknitcomno.Text = ""
        Tbclothid.Text = ""
        Tbclothno.Text = ""
        Tbclothtype.Text = ""
        Tbqtyroll.Text = ""
        Tbwgtkg.Text = ""
        Tbfinwgt.Text = ""
        Tbfinwidth.Text = ""
        Tbshadeid.Text = ""
        Tbshadename.Text = ""
        Tbfabbill.Text = ""
        GroupPanel2.Visible = False
    End Sub
    Private Sub Enabledbutton()
        Btdbadd.Enabled = True
        Btdedit.Enabled = True
        Btddel.Enabled = True
    End Sub
    Private Sub Disbaledbutton()
        Btdbadd.Enabled = False
        Btdedit.Enabled = False
        Btddel.Enabled = False
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

    Private Sub Tbqtyroll_LostFocus(sender As Object, e As EventArgs) Handles Tbqtyroll.LostFocus
        If CalOneroll.Text = "" OrElse Tbqtyroll.Text = "" Then
            Exit Sub
        End If
        'MsgBox("0")
        If Cheng > 1 Then
            Tbwgtkg.Text = Format(CDbl(CalOneroll.Text) * CDbl(Tbqtyroll.Text), "###,###.#0")
        End If
    End Sub
End Class