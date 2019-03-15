Imports System.ComponentModel

Public Class Formfabjobcontrol
    Private Tmaster, Tdetails, Tlist, Dttemp As DataTable
    Private Pagecount, Maxrec, Pagesize, Currentpage, Recno As Integer
    Private WithEvents Dtplistfm As New DateTimePicker
    Private WithEvents Dtplistto As New DateTimePicker
    Private Bs As BindingSource
    Private Sub Formfabjobcontrol_Load(sender As Object, e As EventArgs) Handles Me.Load
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
        Tbmycom.Text = Trim(Gscomname)
        Dtpgenid.Format = DateTimePickerFormat.Custom
        Dtpgenid.CustomFormat = "MMMM yyyy"
        Dgvmas.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        Dgvmas.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        Dgvlist.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        Dgvlist.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        'Setauthorize()
        Retdocprefix()
        Bindinglist()
        Disbaledbutton()
        Enabledbuttondetail(False)
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub Btmnew_Click(sender As Object, e As EventArgs) Handles Btmnew.Click
        Clrtextmaster()
        Clrgridmaster()
        TabControl1.SelectedTabIndex = 1
        BindingNavigator1.Enabled = False
        Mainbuttonaddedit()
        Enabledbuttondetail(True)
        Dtpgenid.Enabled = True
        Dtpdate.Enabled = True
        Countrows()
    End Sub
    Private Sub Btmedit_Click(sender As Object, e As EventArgs) Handles Btmedit.Click
        If TabControl1.SelectedTabIndex = 0 Then
            Exit Sub
        End If
        BindingNavigator1.Enabled = False
        Mainbuttonaddedit()
        Countrows()
    End Sub
    Private Sub Btmdel_Click(sender As Object, e As EventArgs) Handles Btmdel.Click
        If TabControl1.SelectedTabIndex = 0 Then
            Exit Sub
        End If
        If Tbjobno.Text = "NEW" Then
            Exit Sub
        End If
        If Trim(Tbjobno.Text) = "" Then
            Exit Sub
        End If
        If Confirmdelete() = True Then
            SQLCommand("DELETE FROM Tjobcontrolxp
                        WHERE Comid = '" & Gscomid & "' AND Jobno = '" & Trim(Tbjobno.Text) & "'") ' ลบหัว
            'SQLCommand("UPDATE Tjobcontrolxp SET Sstatus = '0',Updusr = '" & Gsuserid & "',Uptype = 'D',Uptime = '" & Formatdatesave(Now) & "'
            '            WHERE Comid = '" & Gscomid & "' AND Jobno = '" & Trim(Tbjobno.Text) & "'")
            Insertlog(Gscomid, Gsusergroupid, Gsuserid, Gsusername, $"{Me.Tag}", Trim(Tbjobno.Text), "D", "ลบรายการ job control ", Formatdatesave(Now), Computername, Usrproname)
            Clrtextmaster()
            Clrgridmaster()
            Bindinglist()
            TabControl1.SelectedTabIndex = 0
            BindingNavigator1.Enabled = False
            Mainbuttoncancel()
        End If
    End Sub
    Private Sub Btmsave_Click(sender As Object, e As EventArgs) Handles Btmsave.Click
        If Validmas() = False Then
            Informmessage("กรุณาตรวจสอบลูกค้า")
            Exit Sub
        End If
        If Validdetlist() = False Then
            Informmessage("กรุณาตรวจสอบรายการให้ครบถ้วน")
            'If Confirmsave() = False Then
            Exit Sub
            'End If
        End If
        If (Tbjobno.Text = "NEW") Then
            Newdoc()
        Else
            Editdoc()
        End If
        Tsbwsave.Visible = False
        Btmreports_Click(sender, e)
        Clrtextmaster()
        Clrgridmaster()
        Bindinglist()
        TabControl1.SelectedTabIndex = 0
        BindingNavigator1.Enabled = False
        Mainbuttoncancel()
    End Sub
    Private Sub Btmcancel_Click(sender As Object, e As EventArgs) Handles Btmcancel.Click
        Clrtextmaster()
        Clrgridmaster()
        TabControl1.SelectedTabIndex = 0
        BindingNavigator1.Enabled = False
        Mainbuttoncancel()
        Enabledbuttondetail(False)
    End Sub
    Private Sub Btmreports_Click(sender As Object, e As EventArgs) Handles Btmreports.Click
        If Gspriau = False Then
            Exit Sub
        End If
        'Dim Frm As New Formbillingrpt
        'Frm.Tbbillid.Text = Trim(Tbbillno.Text)
        'Frm.Tbbilldate.Text = Format(Dtpdate.Value, "dd/MM/yyyy")
        'Frm.Tbcustid.Text = Trim(Tbcustid.Text)
        'Frm.Tbcustname.Text = Trim(Tbcustname.Text)
        'Frm.Tbsalename.Text = Trim(Tbsalename.Text)
        'Showform(Frm)
        'Clrtextmaster()
        'Clrgridmaster()
        'BindingNavigator1.Enabled = False
        'Mainbuttoncancel()
        'TabControl1.SelectedTabIndex = 0
    End Sub
    Private Sub Btmfind_Click(sender As Object, e As EventArgs) Handles Btmfind.Click
        Clrtextmaster()
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
    Private Sub Dgvlist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvlist.CellContentClick
        If Dgvlist.RowCount = 0 Then
            Exit Sub
        End If
        Select Case Dgvlist.Columns(e.ColumnIndex).Name
            Case "Jobno"
                Btmcancel_Click(sender, e)
                Dgvlist.EndEdit()
                Ctmledit_Click(sender, e)
        End Select
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
        Clrgridmaster()
        TabControl1.SelectedTabIndex = 1
        Tbjobno.DataBindings.Clear()
        Tbjobno.Text = ""
        Bs.Position = Bs.Find("Jobno", Trim(Dgvlist.CurrentRow.Cells("Jobno").Value))
        Tbjobno.DataBindings.Add("Text", Bs, "Jobno")
        Tbjobno.Enabled = False
        Bindmaster()
        BindingNavigator1.Enabled = True
        Btmnew.Enabled = False
        Btmedit.Enabled = True
        Btmdel.Enabled = True
        Btmsave.Enabled = False
        Btmcancel.Enabled = True
        Btmreports.Enabled = True
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
        Tbjobno.Enabled = False
        Bindmaster()
    End Sub
    Private Sub Btfindcustid_Click(sender As Object, e As EventArgs) Handles Btfindcustid.Click
        Dim Frm As New Formcustlistforjob
        Showdiaformcenter(Frm, Me)
        If Frm.Tbcancel.Text = "C" Then
            Exit Sub
        End If
        Clrtextmaster()
        Clrgridmaster()
        Tbcustid.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Mid").Value)
        Tbcustname.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Mname").Value)
        Countrows()
    End Sub
    Private Sub Dtpdate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Dtpdate.KeyPress
        e.Handled = True
    End Sub
    Private Sub Dtpgenid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Dtpgenid.KeyPress
        e.Handled = True
    End Sub
    Private Sub Dgvmas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvmas.CellClick
        If Dgvmas.RowCount = 0 Then
            Exit Sub
        End If
        Dgvmas.CurrentRow.Selected = True
    End Sub
    Private Sub Formfabjobcontrol_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Tbjobno.Text = "NEW" And Dgvmas.RowCount = 0 Then
            'My.Forms.Formmain.Panel1.Visible = True
            Exit Sub
        End If
        If Confirmcloseform("Job control") Then
            e.Cancel = False
            'My.Forms.Formmain.Panel1.Visible = True
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub Newdoc()
        Insertmaster()
        If Dtpgenid.Value.Year = Now.Year And Dtpgenid.Value.Month = Now.Month Then
            SQLCommand("UPDATE Tdocprexp SET Lvalue = '" & Trim(Tbjobno.Text).Remove(0, 2) & "',Updusr = '" & Gsuserid & "',Uptype = 'E',Uptime = '" & Formatdatesave(Now) & "' 
                       WHERE  Comid = '" & Gscomid & "' AND Docid = '" & Tstbdocpreid.Text & "' AND Prefix = '" & Trim(Tstbdocpre.Text) & "'")
        End If
        Updlist("A")
        If Gsusername = "SUPHATS" Then
        Else
            Insertlog(Gscomid, Gsusergroupid, Gsuserid, Gsusername, $"{Me.Tag}", Trim(Tbjobno.Text), "A", "สร้างรายการ Job Control", Formatdatesave(Now), Computername, Usrproname)
        End If
    End Sub
    Private Sub Editdoc()
        If Tbjobno.Text = "NEW" Then
            Exit Sub
        End If
        Editmaster()
        Updlist("E")
        If Gsusername = "SUPHATS" Then
        Else
            Insertlog(Gscomid, Gsusergroupid, Gsuserid, Gsusername, $"{Me.Tag}", Trim(Tbjobno.Text), "E", "แก้ไขรายการ Job Control", Formatdatesave(Now), Computername, Usrproname)
        End If
    End Sub
    Private Sub Insertmaster()
        Tbjobno.Text = Trim(Tstbdocpre.Text) & Genid()
        Dim Tmpyear, Tmpmonth, Tmpaprd As String
        Tmpyear = Dtpgenid.Value.Year - 2000
        If Dtpgenid.Value.Month < 10 Then
            Tmpmonth = "0" & Dtpgenid.Value.Month
        Else
            Tmpmonth = Dtpgenid.Value.Month
        End If
        Tmpaprd = Tmpyear & Tmpmonth
        SQLCommand($"INSERT INTO Tjobcontrolxp(Comid,Jobno,Jobdate,Custid,Jobremark,
                                 Atperiod,Jobclose,Sstatus,Updusr,Uptype,Uptime)
                    VALUES('{Gscomid}','{Trim(Tbjobno.Text)}','{Formatshortdatesave(Dtpdate.Value)}','{Trim(Tbcustid.Text)}','{Trim(Tbremark.Text)}',
                           '{Tmpaprd}','0','1','{Gsuserid}','A','{Formatdatesave(Now)}')")
    End Sub
    Private Sub Editmaster()
        Dim Tmpyear, Tmpmonth, Tmpaprd As String
        Tmpyear = Dtpgenid.Value.Year - 2000
        If Dtpgenid.Value.Month < 10 Then
            Tmpmonth = "0" & Dtpgenid.Value.Month
        Else
            Tmpmonth = Dtpgenid.Value.Month
        End If
        Tmpaprd = Tmpyear & Tmpmonth
        SQLCommand($"UPDATE Tjobcontrolxp SET Jobdate = '{Formatshortdatesave(Dtpdate.Value)}', Custid = '{Trim(Tbcustid.Text)}',
                     Jobremark = '{Trim(Tbremark.Text)}', Atperiod = '{Tmpaprd}', Jobclose = '0', Sstatus = '1', Updusr = '{Gsuserid}',
                     Uptype = 'E', Uptime = '{Formatdatesave(Now)}' WHERE Comid = '{Gscomid}' AND Jobno = '{Trim(Tbjobno.Text)}' ")
    End Sub
    Private Sub Updlist(Etype As String)
        SQLCommand("DELETE FROM Tjobcontroldetxp
                    WHERE Comid = '" & Gscomid & "' AND Jobno = '" & Trim(Tbjobno.Text) & "'")
        Dim I As Integer
        ProgressBarX1.Value = 0
        Dim Frm As New Formwaitdialoque
        Frm.Show()
        Dim Tmord As Integer
        Dim Tclothid, TFinwgt, TDozen, Tshade, TKnitcomno As String
        Dim Tqtyroll As Integer
        Dim Twgtkg As Double
        For I = 0 To Dgvmas.RowCount - 1
            Tmord = I + 1
            Tclothid = Trim(Dgvmas.Rows(I).Cells("Clothid").Value.ToString)
            Tqtyroll = Trim(Dgvmas.Rows(I).Cells("Qtyroll").Value.ToString)
            Twgtkg = Trim(Dgvmas.Rows(I).Cells("Wgtkg").Value.ToString)
            TFinwgt = Trim(Dgvmas.Rows(I).Cells("Finwgt").Value.ToString)
            TDozen = Trim(Dgvmas.Rows(I).Cells("Dozen").Value.ToString)
            Tshade = Trim(Dgvmas.Rows(I).Cells("Shadeid").Value.ToString)
            TKnitcomno = Trim(Dgvmas.Rows(I).Cells("Knitcomno").Value.ToString)

            SQLCommand($"INSERT INTO Tjobcontroldetxp(Comid, Jobno, Ord, Clothid,
                        Shadeid, Qtyroll, Wgtkg, Finwgt, Dozen, Dlvroll, Remainroll,
                    Updusr, Uptype, Uptime, Knitcomno)
                    VALUES('{Gscomid}','{Trim(Tbjobno.Text)}','{Tmord}','{Tclothid}',
                            '{Tshade}','{Tqtyroll}','{Twgtkg}','{TFinwgt}','{TDozen}','0','{Tqtyroll}',
                            '{Gsuserid}','{Etype}', '{Formatdatesave(Now)}', '{TKnitcomno}' )")

            ProgressBarX1.Value = ((I + 1) / Dgvmas.Rows.Count) * 100
            ProgressBarX1.Text = "Saving ... " & ProgressBarX1.Value & "%"
        Next
        Frm.Close()
        ProgressBarX1.Text = "Ready"
        ProgressBarX1.Value = 0
    End Sub
    Private Sub Bindinglist()
        Tlist = New DataTable
        Tlist = SQLCommand($"SELECT '' AS Stat,* FROM Vjobcontrol
                                WHERE Comid = '{Gscomid}' AND Sstatus = '1' ")
        Dgvlist.DataSource = Tlist
        Bs = New BindingSource
        Bs.DataSource = Tlist
        BindingNavigator1.BindingSource = Bs
        FillGrid()
        ShowRecordDetail()
    End Sub
    Private Sub Bindmaster()
        Tmaster = New DataTable
        Tmaster = SQLCommand("SELECT * FROM Vjobcontrol
                                WHERE Comid = '" & Gscomid & "' AND Jobno = '" & Trim(Tbjobno.Text) & "'")
        If Tmaster.Rows.Count > 0 Then
            Tbcustid.Text = Tmaster.Rows(0)("Custid")
            Tbcustname.Text = Tmaster.Rows(0)("Custname")
            Dtpdate.Value = Tmaster.Rows(0)("Jobdate")
            Dim Tyear, Tmonth As Integer
            Dim Tmontstr As String
            Tyear = CInt(Trim(Tmaster.Rows(0)("Atperiod")).ToString.Substring(0, 2)) + 2000
            Tmontstr = Trim(Tmaster.Rows(0)("Atperiod")).ToString
            Tmonth = CInt(Tmontstr.Substring(Tmontstr.Length - 2, 2))
            Dim Cvalue As DateTime = New DateTime(Tyear, Tmonth, 1)
            Dtpgenid.Value = Cvalue
            If IsDBNull(Tmaster.Rows(0)("Jobremark")) Then
            Else
                Tbremark.Text = Tmaster.Rows(0)("Jobremark")
            End If
            Bindjobdetailslist()
        End If
    End Sub
    Private Sub Bindjobdetailslist()
        Tdetails = New DataTable
        Tdetails = SQLCommand($"SELECT Tjobcontroldetxp.Comid, Tjobcontroldetxp.Jobno, Tjobcontroldetxp.Ord, 
                                       Tjobcontroldetxp.Clothid, Tclothxp.Clothno, Tjobcontroldetxp.Qtyroll, 
                                       Tjobcontroldetxp.Wgtkg, Tjobcontroldetxp.Finwgt, Tjobcontroldetxp.Dozen, 
                                       Tjobcontroldetxp.Dlvroll, Tjobcontroldetxp.Remainroll, Tclothxp.Ftype, 
                                       Tclothxp.Fwidth, Tjobcontroldetxp.Shadeid, Shadedesc, Tclothxp.Havedoz, 
                                       Tjobcontroldetxp.Knitcomno
					            FROM dbo.Tjobcontroldetxp 
					            LEFT OUTER JOIN dbo.Tclothxp 
					                 ON dbo.Tjobcontroldetxp.Clothid = dbo.Tclothxp.Clothid AND dbo.Tjobcontroldetxp.Comid = dbo.Tclothxp.Comid
							    LEFT OUTER JOIN dbo.Tshadexp 
									 ON dbo.Tjobcontroldetxp.Comid = dbo.Tshadexp.Comid AND dbo.Tshadexp.Shadeid = dbo.Tjobcontroldetxp.Shadeid
					            WHERE Tjobcontroldetxp.Comid = '{Gscomid}' AND Tjobcontroldetxp.Jobno = '{Trim(Tbjobno.Text)}' ")
        Dgvmas.DataSource = Tdetails
        Findsumamt()
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
    Private Function Genid() As String
        Dim Genbill As New DataTable
        Dim Sautoid, Tmpyear, Tmpmonth, Tmpday, Tmpsearch As String
        Tmpyear = Dtpgenid.Value.Year
        If Dtpgenid.Value.Month <10 Then
            Tmpmonth="0" & Dtpgenid.Value.Month
        Else
            Tmpmonth= Dtpgenid.Value.Month
        End If
        If Dtpgenid.Value.Day < 10 Then
            Tmpday = "0" & Dtpgenid.Value.Day
        Else
            Tmpday = Dtpgenid.Value.Day
        End If
        Tmpsearch = Tmpyear & Tmpmonth
        Sautoid = ""
        If (Dtpgenid.Value.Year = Now.Year) And (Dtpgenid.Value.Month = Now.Month) Then
            Genbill = SQLCommand("SELECT ISNULL(MAX(CAST(Lvalue as BIGINT)), 0) + 1 as Autoid FROM Tdocprexp 
                                WHERE LEFT(Lvalue,6) = '" & Tmpsearch & "' AND  Comid = '" & Gscomid & "' 
                                AND Docid = '" & Trim(Tstbdocpreid.Text) & "' AND Prefix = '" & Trim(Tstbdocpre.Text) & "'")
        Else
            Genbill = SQLCommand("SELECT ISNULL(MAX(CAST(RIGHT(Jobno,11) as BIGINT)), 0) + 1 as Autoid FROM Tjobcontrolxp
                                WHERE RIGHT(LEFT(Jobno,8),6) = '" & Tmpsearch & "'  AND  Comid = '" & Gscomid & "'")
        End If
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
    Private Sub Searchlistbydate()
        Tlist = SQLCommand("SELECT '' AS Stat,* FROM Vjobcontrol
                                WHERE Comid = '" & Gscomid & "' AND Sstatus = '1' AND 
                                (Jobdate BETWEEN '" & Formatshortdatesave(Dtplistfm.Value) & "' AND '" & Formatshortdatesave(Dtplistto.Value) & "')")
        Bs = New BindingSource
        Bs.DataSource = Tlist
        BindingNavigator1.BindingSource = Bs
        FillGrid()
        ShowRecordDetail()
    End Sub
    Private Sub Searchlistbyoth(Sval As String)
        If Sval = "" Then
            Bindinglist()
            Exit Sub
        End If
        Tlist = SQLCommand("SELECT '' AS Stat,* FROM Vjobcontrol
                                WHERE Comid = '" & Gscomid & "' AND Sstatus = '1' AND 
                                (Jobno LIKE '%' + '" & Sval & "' + '%' OR Custname LIKE '%' + '" & Sval & "' + '%')")
        Bs = New BindingSource
        Bs.DataSource = Tlist
        BindingNavigator1.BindingSource = Bs
        FillGrid()
        ShowRecordDetail()
    End Sub
    Private Sub Setauthorize()
        If Gscreau = False Then
            Btmnew.Visible = False
        End If
        If Gswriau = False Then
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
            Tscbdate.Visible = False
            Tscboth.Visible = False
        End If
    End Sub
    Private Sub Findsumamt()
        If Dgvmas.RowCount = 0 Then
            Tstbsumqtyroll.Text = 0
            Tstbsumwgtkg.Text = 0
            Tstbsumdlvroll.Text = 0
            Exit Sub
        End If
        Dim I As Integer
        Dim Tsumwgtkg As Double
        Dim Tsumqtyroll, Tsumdlvroll As UInteger

        Tsumqtyroll = 0
        Tsumwgtkg = 0
        Tsumdlvroll = 0

        For I = 0 To Dgvmas.RowCount - 1
            Tsumqtyroll += CDbl(Dgvmas.Rows(I).Cells("qtyroll").Value)
            Tsumwgtkg += CDbl(Dgvmas.Rows(I).Cells("Wgtkg").Value)
            Tsumdlvroll += CDbl(Dgvmas.Rows(I).Cells("dlvroll").Value)
        Next
        Tstbsumqtyroll.Text = Format(Tsumqtyroll, "###,##0")
        Tstbsumwgtkg.Text = Format(Tsumwgtkg, "###,##0.#0")
        Tstbsumdlvroll.Text = Format(Tsumdlvroll, "###,##0")
    End Sub
    Private Sub Clrtextmaster()
        Tbcustid.Text = ""
        Tbcustname.Text = ""
        Tbjobno.Text = "NEW"
        Dtpdate.Value = Now
        Dtpgenid.Value = Now
    End Sub
    Private Sub Clrgridmaster()
        Dgvmas.AutoGenerateColumns = False
        Dgvmas.DataSource = Nothing
        Dgvmas.Rows.Clear()
        Tstbsumwgtkg.Text = ""
        Tbremark.Text = ""
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
    Private Sub Enabledbutton()
        Dgvmas.Enabled = True
        Btfindcustid.Enabled = True
        Tbremark.Enabled = True
        Dtpdate.Enabled = True
    End Sub
    Private Sub Enabledbuttondetail(Enbool As Boolean)
        Btdbadd.Enabled = Enbool
        Btdedit.Enabled = Enbool
        Btddel.Enabled = Enbool
        Tbremark.Enabled = Enbool
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
    Private Sub Disbaledbutton()
        Dgvmas.Enabled = False
        Dtpgenid.Enabled = False
        Dtpdate.Enabled = False
        Btfindcustid.Enabled = False
    End Sub
    Private Sub Editcontextlistmenu()
        Ctmmenugrid.Displayed = False
        Ctmmenugrid.PopupMenu(Control.MousePosition)
    End Sub
    Private Function Validmas() As Boolean
        Dim Valid As Boolean = False
        If Tbcustid.Text <> "" And Tbcustname.Text <> "" Then
            Valid = True
        End If
        Return Valid
    End Function
    Private Function Validdetlist() As Boolean
        Dim Valid As Boolean = False
        If Dgvmas.RowCount > 0 Then
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

    Private Sub Btdbadd_Click(sender As Object, e As EventArgs) Handles Btdbadd.Click
        Dim frm As New Formaddeditjoblist
        If Dgvmas.RowCount - 1 < 0 Then
            frm.Tbord.Text = Dgvmas.RowCount + 1
        Else
            frm.Tbord.Text = Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Ord").Value + 1
        End If
Showformadd:
        Showdiaformcenter(frm, Me)
        If frm.Tbcancel.Text = "C" Then
            Exit Sub
        End If

        If Countdatagrid(Dgvmas, "Clothid", Trim(frm.Tbclothid.Text)) = 1 AndAlso Countdatagrid(Dgvmas, "Finwgt", Trim(frm.Tbfinwgt.Text)) = 0 Then
            Informmessage("ผ้าประเภทเดียวกันต้องมี Finished Weigth เหมือนกัน")
            GoTo Showformadd
        End If

        If Countdatagrid(Dgvmas, "Clothid", Trim(frm.Tbclothid.Text)) = 1 AndAlso Countdatagrid(Dgvmas, "Shadeid", Trim(frm.Tbshadeid.Text)) = 1 Then
            Informmessage("ไม่สามารถเพิ่มรายการผ้าที่มีประเภทและสีเดียวกันได้")
            GoTo Showformadd
        End If


        If Tbjobno.Text = "NEW" Then
            Dgvmas.Rows.Add()
        Else
            Tdetails.Rows.Add()
        End If
        Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Ord").Value = Trim(frm.Tbord.Text)
        Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Clothid").Value = Trim(frm.Tbclothid.Text)
        Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Clothno").Value = Trim(frm.Tbclothno.Text)
        Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Ftype").Value = Trim(frm.Tbtype.Text)
        Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Dozen").Value = Trim(frm.Tbdozen.Text)
        Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Finwgt").Value = Trim(frm.Tbfinwgt.Text)
        Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("finwidth").Value = Trim(frm.Tbfinwidth.Text)
        Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Shadeid").Value = Trim(frm.Tbshadeid.Text)
        Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Shadedesc").Value = Trim(frm.Tbshadename.Text)
        Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Qtyroll").Value = CLng(frm.Tbqtyroll.Text)
        Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Wgtkg").Value = CDbl(frm.TbwgtKg.Text)
        Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Havedoz").Value = CLng(frm.Havedoz)
        Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Knitcomno").Value = ""
        Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Dlvroll").Value = 0
        Countrows()
    End Sub

    Private Sub Countrows()
        If Tbcustid.Text = "" Then
            Btdbadd.Enabled = False
        Else
            Btdbadd.Enabled = True
        End If
        If Dgvmas.RowCount - 1 < 0 Then
            Btdedit.Enabled = False
            Btddel.Enabled = False
        Else
            Btdedit.Enabled = True
            Btddel.Enabled = True
        End If
        Findsumamt()
    End Sub

    Private Sub Btdedit_Click(sender As Object, e As EventArgs) Handles Btdedit.Click
        Dim frm As New Formaddeditjoblist

        frm.Tbclothid.Text = Dgvmas.CurrentRow.Cells("Clothid").Value.ToString
        frm.Tbclothno.Text = Dgvmas.CurrentRow.Cells("Clothno").Value.ToString
        frm.Tbtype.Text = Dgvmas.CurrentRow.Cells("Ftype").Value.ToString
        frm.Tbdozen.Text = Dgvmas.CurrentRow.Cells("Dozen").Value.ToString
        frm.Tbfinwgt.Text = Dgvmas.CurrentRow.Cells("Finwgt").Value.ToString
        frm.Tbfinwidth.Text = Dgvmas.CurrentRow.Cells("finwidth").Value.ToString
        frm.Tbshadeid.Text = Dgvmas.CurrentRow.Cells("Shadeid").Value.ToString
        frm.Tbshadename.Text = Dgvmas.CurrentRow.Cells("Shadedesc").Value.ToString
        frm.Tbqtyroll.Text = Dgvmas.CurrentRow.Cells("Qtyroll").Value.ToString
        frm.TbwgtKg.Text = Format(CDbl(Dgvmas.CurrentRow.Cells("Wgtkg").Value), "###,###.#0")
        frm.Tbaddedit.Text = "แก้ไข"

        If Dgvmas.CurrentRow.Cells("Havedoz").Value = True Then
            frm.Havedoz = True
            frm.Tbdozen.Text = Dgvmas.CurrentRow.Cells("Dozen").Value
        Else
            frm.Havedoz = False
            frm.Tbdozen.Text = "0"
        End If
Showformedit:
        Showdiaformcenter(frm, Me)
        If frm.Tbcancel.Text = "C" Then
            Exit Sub
        End If

        If Countdatagrid(Dgvmas, "Clothid", Trim(frm.Tbclothid.Text), "Edit") = 1 AndAlso Countdatagrid(Dgvmas, "Finwgt", Trim(frm.Tbfinwgt.Text), "Edit") = 0 Then
            Informmessage("ผ้าประเภทเดียวกันต้องมี Finished Weigth เหมือนกัน")
            GoTo Showformedit
        End If

        If Countdatagrid(Dgvmas, "Clothid", Trim(frm.Tbclothid.Text), "Edit") = 1 AndAlso Countdatagrid(Dgvmas, "Shadeid", Trim(frm.Tbshadeid.Text), "Edit") = 1 Then
            Informmessage("ไม่สามารถเพิ่มรายการผ้าที่มีประเภทและสีเดียวกันได้")
            GoTo Showformedit
        End If

        Dgvmas.CurrentRow.Cells("Clothid").Value = Trim(frm.Tbclothid.Text)
        Dgvmas.CurrentRow.Cells("Clothno").Value = Trim(frm.Tbclothno.Text)
        Dgvmas.CurrentRow.Cells("Ftype").Value = Trim(frm.Tbtype.Text)
        Dgvmas.CurrentRow.Cells("Dozen").Value = Trim(frm.Tbdozen.Text)
        Dgvmas.CurrentRow.Cells("Finwgt").Value = Trim(frm.Tbfinwgt.Text)
        Dgvmas.CurrentRow.Cells("Shadeid").Value = Trim(frm.Tbshadeid.Text)
        Dgvmas.CurrentRow.Cells("Shadedesc").Value = Trim(frm.Tbshadename.Text)
        Dgvmas.CurrentRow.Cells("Qtyroll").Value = CLng(frm.Tbqtyroll.Text)
        Dgvmas.CurrentRow.Cells("Wgtkg").Value = CDbl(frm.TbwgtKg.Text)
        Dgvmas.CurrentRow.Cells("Havedoz").Value = CLng(frm.Havedoz)
        Countrows()
    End Sub

    Private Sub Btddel_Click(sender As Object, e As EventArgs) Handles Btddel.Click
        Dgvmas.Rows.Remove(Dgvmas.CurrentRow)
        'Sumall()
        Tsbwsave.Visible = True
        Countrows()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If Tbjobno.Text = "NEW" Then
            Exit Sub
        End If
        Dim Frm As New Formfabfollow
        Frm.Tbjobno.Text = Tbjobno.Text
        Frm.Show()
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

    Private Function Countdatagrid(Grid As Object, Cells As String, Value As String, Optional Status As String = "Add")
        Dim Valuereturn = 0
        If Grid.RowCount = 0 Then
            Return Valuereturn
            Exit Function
        End If
        Dim iRowIndex As Integer = Grid.CurrentRow.Index.ToString()
        For i = 0 To Grid.RowCount - 1
            If Grid.rows(i).cells(Cells).value = Value Then
                If Status = "Edit" And iRowIndex = i Then
                    Valuereturn = 0
                    Continue For
                End If
                Valuereturn = 1
                Exit For
            End If
        Next
        Return Valuereturn
    End Function

End Class