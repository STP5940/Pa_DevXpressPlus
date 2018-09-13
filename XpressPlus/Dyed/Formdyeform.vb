Imports System.ComponentModel
Imports Microsoft.Reporting.WinForms
Public Class Formdyeform
    Private Tmaster, Tdetails, Tlist, Dttemp As DataTable
    Private Pagecount, Maxrec, Pagesize, Currentpage, Recno As Integer
    Private WithEvents Dtplistfm As New DateTimePicker
    Private WithEvents Dtplistto As New DateTimePicker
    Private Bs As BindingSource
    Private Sub Formdyeform_Load(sender As Object, e As EventArgs) Handles Me.Load
        Controls.Add(Dtplistfm)
        Dtplistfm.Value = Now
        Dtplistfm.Width = 130
        Me.ToolStrip4.Items.Insert(5, New ToolStripControlHost(Dtplistfm))
        Me.ToolStrip4.Items(5).Alignment = ToolStripItemAlignment.Right
        Controls.Add(Dtplistto)
        Dtplistto.Value = Now
        Dtplistto.Width = 130
        Me.ToolStrip4.Items.Insert(4, New ToolStripControlHost(Dtplistto))
        Me.ToolStrip4.Items(4).Alignment = ToolStripItemAlignment.Right
        Dtplistfm.Visible = False
        Dtplistto.Visible = False
        '  Setauthorize()
        Retdocprefix()
        Tbmycom.Text = Trim(Gscomname)
    End Sub
    Private Sub Formdyeform_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dgvmas.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        Dgvmas.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        Dgvlist.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        Dgvlist.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        Bindinglist()
    End Sub
    Private Sub Btmnew_Click(sender As Object, e As EventArgs) Handles Btmnew.Click
        Clrtextmaster()
        Clrtextdetails()
        Clrgridmaster()
        TabControl1.SelectedTabIndex = 1
        BindingNavigator1.Enabled = False
        Mainbuttonaddedit()
    End Sub
    Private Sub Btmedit_Click(sender As Object, e As EventArgs) Handles Btmedit.Click
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
        BindingNavigator1.Enabled = False
        Mainbuttoncancel()
    End Sub
    Private Sub Btmreports_Click(sender As Object, e As EventArgs) Handles Btmreports.Click
        'If Dgvmas.RowCount = 0 Then
        '    Exit Sub
        'End If
        'If Tsbwsave.Visible = True Then
        '    Informmessage("มีการเปลี่ยนแปลงและยังไม่ทำการบันทึก")
        '    Exit Sub
        'End If
        'Binddetails()
        'Tsbwsave.Visible = False
        'Dim Frm As New Formdyedcomrpt
        'Frm.ReportViewer1.Reset()
        'Frm.Tbshipping.Text = Trim(Tbshippingname.Text)
        'Frm.Tbsuplier.Text = Trim(Tbsuppliername.Text)
        'Frm.Tbdate.Text = Format(Dtpdate.Value, "dd/MM/yyyy")
        'Frm.Tbsumctn.Text = Tstbsumctn.Text
        'Frm.Tbsumgw.Text = Tstbsumgw.Text
        'Frm.Tbsumnw.Text = Tstbsumnw.Text
        'Frm.Tbsumqty.Text = Tstbsumqty.Text
        'Frm.Tbdlvno.Text = Tbdlvno.Text
        'If Gsexpau = False Then
        '    Frm.ReportViewer1.ShowExportButton = False
        'End If
        'If Gspriau = False Then
        '    Frm.ReportViewer1.ShowPrintButton = False
        'End If
        'Dim rds As New ReportDataSource()
        'rds.Name = "DataSet1"
        'rds.Value = Tdetails
        'Frm.ReportViewer1.LocalReport.DataSources.Add(rds)
        'Showform(Frm)
        'Sumall()
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
        Clrtextmaster()
        Clrtextdetails()
        Clrgridmaster()
        TabControl1.SelectedTabIndex = 1
        Tbdyedcomno.DataBindings.Clear()
        Tbdyedcomno.Text = ""
        Bs.Position = Bs.Find("Dyecomno", Trim(Dgvlist.CurrentRow.Cells("Ldyecomno").Value))
        Tbdyedcomno.DataBindings.Add("Text", Bs, "Dyecomno")
        Tbdyedcomno.Enabled = False
        Bindmaster()
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
        Bindmaster()
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
        Tbknitcomno.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Knitcomno").Value)
        Tbclothid.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Clothid").Value)
        Tbclothno.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Clothno").Value)
        Tbclothtype.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Ftype").Value)
        Tbqtyroll.Text = Format(Frm.Dgvmas.CurrentRow.Cells("Qtyroll").Value, "###,###")
        Tbwgtkg.Text = Format(Frm.Dgvmas.CurrentRow.Cells("Wgtkg").Value, "###,###.#0")
        Tbfinwgt.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Finwgt").Value)
        Tbfinwidth.Text = Frm.Dgvmas.CurrentRow.Cells("Fwidth").Value
        Tbqtyroll.Focus()
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
        Tbshadeid.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Mid").Value)
        Tbshadename.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Mname").Value)
        Tbfabbill.Focus()
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
        If Validinput() = False Then
            Informmessage("กรุณาตรวจสอบข้อมูลให้ถูกต้อง ครบถ้วน")
            Exit Sub
        End If
        If Validnumber() = False Then
            Informmessage("กรุณาตรวจจำนวนให้ถูกต้อง ครบถ้วน")
            Exit Sub
        End If
        If Tbaddedit.Text = "เพิ่ม" Then
            If Chkdupyarnidingrid() = True Then
                Informmessage("เลขที่สั่งทอและผ้าเบอร์นี้มีแล้ว")
                Exit Sub
            End If
        End If
        Select Case Trim(Tbaddedit.Text)
            Case "เพิ่ม"
                If Tbdyedcomno.Text = "NEW" Then
                    Dgvmas.Rows.Add()
                Else
                    Tdetails.Rows.Add()
                End If
                Tsbwsave.Visible = True
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
    End Sub
    Private Sub Btdcancel_Click(sender As Object, e As EventArgs) Handles Btdcancel.Click

    End Sub
    Private Sub Btdbadd_Click(sender As Object, e As EventArgs) Handles Btdbadd.Click
        Btdcancel_Click(sender, e)
        GroupPanel2.Visible = True
        Tbaddedit.Text = "เพิ่ม"
    End Sub
    Private Sub Btdedit_Click(sender As Object, e As EventArgs) Handles Btdedit.Click
        If Dgvmas.RowCount = 0 Then
            Exit Sub
        End If
        If Validmas() = False Then
            Informmessage("กรุณาเลือกที่โรงย้อม")
            Exit Sub
        End If
        Tbaddedit.Text = "แก้ไข"
        Tbknitcomno.Text = Trim(Dgvmas.CurrentRow.Cells("Dknittno").Value)
        Tbclothid.Text = Trim(Dgvmas.CurrentRow.Cells("Clothid").Value)
        Tbclothno.Text = Trim(Dgvmas.CurrentRow.Cells("Clothno").Value)
        Tbclothtype.Text = Trim(Dgvmas.CurrentRow.Cells("Ftype").Value)
        Tbfinwidth.Text = Trim(Dgvmas.CurrentRow.Cells("Mfinwid").Value)
        Tbshadeid.Text = Trim(Dgvmas.CurrentRow.Cells("Shid").Value)
        Tbshadename.Text = Trim(Dgvmas.CurrentRow.Cells("Mshade").Value)
        Tbqtyroll.Text = Format(CLng(Dgvmas.CurrentRow.Cells("Mqty").Value), "###,###")
        Tbwgtkg.Text = Format(CDbl(Dgvmas.CurrentRow.Cells("Mkg").Value), "###,###.#0")
        Tbfinwgt.Text = Trim(Dgvmas.CurrentRow.Cells("Mfinwgt").Value)
        Tbfabbill.Text = Trim(Dgvmas.CurrentRow.Cells("Mbrawfab").Value)
        Tbqtyroll.Focus()
    End Sub
    Private Sub Btddel_Click(sender As Object, e As EventArgs) Handles Btddel.Click
        If Dgvmas.RowCount = 0 Then
            Exit Sub
        End If
        Btdcancel_Click(sender, e)
        Tsbwsave.Visible = True
        Dgvmas.Rows.Remove(Dgvmas.CurrentRow)
        Sumall()
    End Sub
    Private Sub Dgvmas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvmas.CellClick
        If Dgvmas.RowCount = 0 Then
            Exit Sub
        End If
        Dgvmas.CurrentRow.Selected = True
    End Sub
    Private Sub Dgvmas_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Dgvmas.CellMouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If Me.Dgvmas.Rows.Count < 1 Then Exit Sub
            If e.RowIndex < 0 Then Exit Sub
            Dgvmas.CurrentCell = Dgvmas(3, e.RowIndex)
            Me.Dgvlist.Rows(e.RowIndex).Selected = True
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
            SQLCommand("INSERT INTO Tdyedcomdetxp(Comid,Dyedcomno,Knittcomid,Clothid,Shadeid,
                        Qtyroll,Qtykg,Finwgt,Knittbill,
                        Updusr,Uptype,Uptime)
                        VALUES('" & Gscomid & "','" & Trim(Tbdyedcomno.Text) & "','" & Tknitcomno & "','" & Tclotid & "','" & Tshadeid & "'
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
                                WHERE Comid = '" & Gscomid & "' AND Dyedcomno = '" & Trim(Tbdyedcomno.Text) & "'")
        Dgvmas.DataSource = Tdetails
    End Sub
    Private Sub Bindinglist()
        Tlist = New DataTable
        Tlist = SQLCommand("SELECT '' AS Stat,* FROM Vdyedcommas
                                WHERE Comid = '" & Gscomid & "'")
        Dgvlist.DataSource = Tlist
        Bs = New BindingSource
        Bs.DataSource = Tlist
        BindingNavigator1.BindingSource = Bs
        FillGrid()
        ShowRecordDetail()
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
        If Tbknitcomno.Text <> "" And Tbclothid.Text <> "" And Tbclothno.Text <> "" And Tbclothtype.Text <> "" And Tbqtyroll.Text <> "" And
            Tbwgtkg.Text <> "" And Tbfinwgt.Text <> "" And Tbfinwidth.Text <> "" And Tbshadeid.Text <> "" And Tbshadename.Text <> "" And Tbfabbill.Text <> "" Then
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
End Class