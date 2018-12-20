Imports System.ComponentModel
Imports Microsoft.Reporting.WinForms
Public Class Formrebackfabcolors
    Private Tmaster, Tdetails, Tlist, TSendDyelist, Dttemp, tlistfab, tlistyed, tlistnittno, tlistnamebill, ListLotNo, billnoLotNo As DataTable
    Private Pagecount, Maxrec, Pagesize, Currentpage, Recno As Integer
    Private WithEvents Dtplistfm As New DateTimePicker
    Private WithEvents Dtplistto As New DateTimePicker
    Private RestatusBtmnew As Byte = 0
    Private Bs As BindingSource
    Private Sub Formreceivefabcolors_Load(sender As Object, e As EventArgs) Handles Me.Load
        Controls.Add(Dtplistfm)
        Dtplistfm.Value = Now
        Dtplistfm.Width = 130
        Me.ToolStrip4.Items.Insert(5, New ToolStripControlHost(Dtplistfm))
        Me.ToolStrip4.Items(5).Alignment = ToolStripItemAlignment.Right
        'Dtplistfm.Visible = False

        Controls.Add(Dtplistto)
        Dtplistto.Value = Now
        Dtplistto.Width = 130
        Me.ToolStrip4.Items.Insert(4, New ToolStripControlHost(Dtplistto))
        Me.ToolStrip4.Items(4).Alignment = ToolStripItemAlignment.Right
        'Dtplistto.Visible = False

        GroupPanel2.Visible = False
        Retdocprefix()
        'Setauthorize()
        Mainbuttoncancel()

    End Sub
    Private Sub Formreceivefabcolors_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dgvmas.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        Dgvmas.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        ''SendDyelist.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        ''SendDyelist.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        Dgvlist.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        Dgvlist.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        Bindinglist()
        'TabControl1.SelectedTabIndex = 0
        Dtplistfm.Visible = False
        Dtplistto.Visible = False
        'BindingSendDyelist()
    End Sub
    Private Sub Btmnew_Click(sender As Object, e As EventArgs) Handles Btmnew.Click
        Clrdgrid()
        Clrtxtbox()
        Tbkongno.Text = ""
        Clrupdet()
        Btdcancel_Click(sender, e)
        TabControl1.SelectedTabIndex = 1

        BindingNavigator1.Enabled = False
        Tbkgprice.Enabled = True
        Mainbuttonaddedit()
        Tbrollid.Text = 1
        Tbrefablotno.Enabled = True
        'FindShade.Visible = False
        'Tbshadeid.Size = New Size(116, 24)
    End Sub
    Private Sub Btmsave_Click(sender As Object, e As EventArgs) Handles Btmsave.Click
        If Tbdhid.Text = "" Then
            Informmessage("กรุณาเลือกลูกค้า")
        End If
        If Tbdyedbillno.Text = "" Then
            Informmessage("กรุณาเลือกเลขที่ไบขาย")
        End If

        If Validmas() = False Then
            Informmessage("กรุณาตรวจสอบข้อมูลในการรับผ้าสีให้ครบถ้วน")
            Exit Sub
        End If
        If Validdet() = False Then
            Informmessage("กรุณาตรวจสอบรายละเอียดในการส่งให้ครบถ้วน")
            Exit Sub
        End If
        If Tbrefablotno.Text = "" Then
            Informmessage("กรุณาใส่ Lot No.")
            Exit Sub
        End If

        If Tbdyedcomno.Text = "NEW" Then
            Newdoc()
        Else
            Editdoc()
        End If
        Tsbwsave.Visible = False
        Btmreports_Click(sender, e)
        Btdcancel_Click(sender, e)
        Tbkongno.Text = ""
        Clrupdet()
        Mainbuttoncancel()
        Bindinglist()
        Btmcancel_Click(sender, e)
    End Sub

    Private Sub Btmdel_Click(sender As Object, e As EventArgs) Handles Btmdel.Click
        'If Trim(Tbknittno.Text) = "" Then
        '    Exit Sub
        'End If
        If Confirmdelete() = True Then
            Deldetails(Tbdyedcomno.Text)
            SQLCommand($"UPDATE Trebackfab SET Sstatus = '0', Updusr = '{Gsuserid}', Uptype = 'D'  WHERE Rbid = '{Trim(Tbdyedcomno.Text)}'") 'Pa comment
            Clrdgrid()
            Clrtxtbox()
            Mainbuttoncancel()
            Tstbsumroll.Text = ""
            TabControl1.SelectedTabIndex = 0
            GroupPanel2.Visible = False
            Bindinglist()
        End If
    End Sub

    Private Sub Btmfind_Click(sender As Object, e As EventArgs) Handles Btmfind.Click
        TabControl1.SelectedTabIndex = 0
        Tscboth.Checked = True
        Tstbkeyword.Select()
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
            Me.Dgvlist.Rows(e.RowIndex).Selected = True
            Editcontextlistmenu()
        End If
    End Sub
    Private Sub Ctmledit_Click(sender As Object, e As EventArgs) Handles Ctmledit.Click
        Clrdgrid()
        'Clrtxtbox() 'เป้
        Btdcancel_Click(sender, e)
        Mainbuttoncancel()
        GroupPanel2.Visible = False
        TabControl1.SelectedTabIndex = 1
        Btmedit.Enabled = True
        Tbdyedbillno.Enabled = False
        Btmnew.Enabled = False
        Btmdel.Enabled = True
        Btmreports.Enabled = True
        Tbdyedcomno.Text = Trim(Dgvlist.CurrentRow.Cells("Rbid").Value)
        Bindmaster()

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
    Private Sub Btfinddyedh_Click(sender As Object, e As EventArgs) Handles Btfinddyedh.Click
        Dim Frm As New Formcustomerslist
        Showdiaformcenter(Frm, Me)
        If Frm.Tbcancel.Text = "C" Then
            Exit Sub
        End If
        Tbdhid.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Mid").Value)
        Tbdhname.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Mname").Value)
        Tbdyedbillno.Focus()
    End Sub
    Private Function InputGrid(Data As Object)
        Dim Redata As String = IIf(IsDBNull(Data), "", Data)
        Return Trim(Redata)
    End Function
    Private Sub DemoColor(RBGColor As Object)
        Try
            If Dgvmas.RowCount <> 0 OrElse Tbdyedcomno.Text = "NEW" Then
                Dim EBGColor As New DataTable
                EBGColor = SQLCommand($"SELECT Rcolor,Gcolor,Bcolor FROM Tshadexp WHERE Shadeid = '{RBGColor}' AND Comid = '{Gscomid}' ")
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

    Private Sub Tbkongno_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Tbkg.Focus()
        End If
    End Sub
    Private Sub Tbkg_KeyDown(sender As Object, e As KeyEventArgs) Handles Tbkg.KeyDown
        If e.KeyCode = Keys.Enter Then
            Btdadd_Click(sender, e)
        End If
    End Sub

    Private Sub Btdadd_Click(sender As Object, e As EventArgs) Handles Btdadd.Click

        If Trim(Tbdhid.Text) = "" OrElse Trim(Tbdhname.Text) = "" Then
            Informmessage("กรุณาเลือกโรงย้อม")
            Exit Sub
        End If
        If Trim(Tbdyedbillno.Text) = "" And RestatusBtmnew = 1 Then
            Informmessage("กรุณาเลือกเลขที่ใบสั่งย้อม")
            Exit Sub
        ElseIf Trim(Tbdyedbillno.Text) = "" And RestatusBtmnew = 0 Then
            Informmessage("กรุณาใส่เลขที่ใบสั่งย้อม")
            Exit Sub
        End If
        If Trim(Tbclothid.Text) = "" OrElse Trim(Tbclothno.Text) = "" _
        OrElse Trim(Tbclothtype.Text) = "" OrElse Trim(Tbwidht.Text) = "" _
        OrElse Trim(Tbshadeid.Text) = "" OrElse Trim(Tbshadename.Text) = "" Then
            Informmessage("กรุณาใส่ข้อมูลผ้าให้ครบ")
            Exit Sub
        End If
        If Trim(Tbkongno.Text) = "" Then
            Informmessage("กรุณาใส่เบอร์กอง")
            Tbkongno.Focus()
            Exit Sub
        End If
        If Trim(Tbrollid.Text) = "" Then
            Informmessage("กรุณาใส่เบอร์พับ")
            Tbrollid.Focus()
            Exit Sub
        End If
        If Trim(Tbkg.Text) = "" Or Trim(Tbkg.Text) = ".00" Then
            Informmessage("กรุณาใส่น้ำหนัก")
            Tbkg.Focus()
            Exit Sub
        End If




        If Validmas() = False Then
            Informmessage("กรุณากรอกข้อมูลการรับผ้าสี")
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
        Select Case Trim(Tbaddedit.Text)
            Case "แก้ไข"
                Dgvmas.CurrentRow.Cells("Rollwage").Value = Trim(Tbkg.Text)

                Tsbwsave.Visible = True
                Btdadd.Enabled = False
                Btdcancel.Enabled = False
                Tbkongno.Enabled = False
                Tbrollid.Enabled = False
                Tbkg.Enabled = False
                Dgvmas.CurrentRow.Cells("Clothid").Value = Trim(Tbclothid.Text)
                Dgvmas.CurrentRow.Cells("Mclothno").Value = Trim(Tbclothno.Text)
                Dgvmas.CurrentRow.Cells("Clothtype").Value = Trim(Tbclothtype.Text)
                Dgvmas.CurrentRow.Cells("Dwidth").Value = Trim(Tbwidht.Text)
                Dgvmas.CurrentRow.Cells("Shadeid").Value = Trim(Tbshadeid.Text)
                Dgvmas.CurrentRow.Cells("Shadedesc").Value = Trim(Tbshadename.Text)
                Dgvmas.CurrentRow.Cells("Mkong").Value = Trim(Tbkongno.Text)
                Dgvmas.CurrentRow.Cells("Rollno").Value = Trim(Tbrollid.Text)
                Dgvmas.CurrentRow.Cells("Rollwage").Value = CDbl(Tbkg.Text)
                Dgvmas.CurrentRow.Cells("LotNoDetail").Value = Trim(Tbrefablotno.Text)

                ClearDetail()
                DemoCode.BackColor = Color.White
        End Select
        Sumall()
        GroupPanel2.Visible = False
    End Sub
    Private Sub Btdcancel_Click(sender As Object, e As EventArgs) Handles Btdcancel.Click
        ClearDetail()
        Clrupdet()
        DemoCode.BackColor = Color.White
        Tbkg.Text = ""
        GroupPanel2.Visible = False
    End Sub

    Private Sub ClearMaster()
        Tbkgprice.Text = ""
        Tbdhid.Text = ""
        Tbdhname.Text = ""
        Tbdyedbillno.Text = ""
        Dtprecdate.Value = Now
    End Sub
    Private Sub ClearDetail()
        Tbkongno.Text = ""
        Tbrollid.Text = ""
        Tbclothid.Text = ""
        Tbclothno.Text = ""
        Tbclothtype.Text = ""
        Tbwidht.Text = ""
        Tbshadeid.Text = ""
        Tbshadename.Text = ""
        'Tbkongno.Text = ""
        Tbkg.Text = ""
    End Sub

    Private Sub Btdedit_Click(sender As Object, e As EventArgs)
        If Dgvmas.RowCount = 0 Then
            Exit Sub
        End If
        If Validmas() = False Then
            Informmessage("กรุณากรอกเลือกที่ส่ง")
            Exit Sub
        End If
        'GroupPanel2.Visible = True
        Tbaddedit.Text = "แก้ไข"
        Tbclothid.Text = Trim(Dgvmas.CurrentRow.Cells("Clothid").Value)
        Tbclothno.Text = Trim(Dgvmas.CurrentRow.Cells("Mclothno").Value)
        Tbclothtype.Text = Trim(Dgvmas.CurrentRow.Cells("Clothtype").Value)
        Tbwidht.Text = Trim(Dgvmas.CurrentRow.Cells("Dwidth").Value)
        Tbshadeid.Text = Trim(Dgvmas.CurrentRow.Cells("Shadeid").Value)
        Tbshadename.Text = Trim(Dgvmas.CurrentRow.Cells("Shadedesc").Value)
        Tbkongno.Text = Trim(Dgvmas.CurrentRow.Cells("Mkong").Value)
        Tbkg.Text = Format(CDbl(Dgvmas.CurrentRow.Cells("Rollwage").Value), "###,###.#0")
        Tbkg.Focus()
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
    Private Sub Dgvmas_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        If Dgvmas.RowCount = 0 Then
            Exit Sub
        End If
        Dgvmas.CurrentRow.Selected = True
    End Sub
    Private Sub Dgvmas_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If Me.Dgvmas.Rows.Count < 1 Then Exit Sub
            If e.RowIndex < 0 Then Exit Sub
            Dgvmas.CurrentCell = Dgvmas(9, e.RowIndex)
            Me.Dgvmas.Rows(e.RowIndex).Selected = True
            Editcontextdetmenu()
        End If
    End Sub
    Private Sub Ctdedit_Click(sender As Object, e As EventArgs)
        Btdedit_Click(sender, e)
    End Sub
    Private Sub Ctddel_Click(sender As Object, e As EventArgs)
        Btddel_Click(sender, e)
    End Sub
    Private Sub Formreceivefabcolors_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Tbdyedcomno.Text = "NEW" And Dgvmas.RowCount = 0 Then
            'My.Forms.Formmain.Panel1.Visible = True
            Exit Sub
        End If
        If Confirmcloseform("รับผ้าสี") Then
            e.Cancel = False
            'My.Forms.Formmain.Panel1.Visible = True
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub Searchlistbyoth(Sval As String)
        If Sval = "" Then
            Bindinglist()
            Exit Sub
        End If
        Tlist = SQLCommand($"SELECT dbo.Trebackfab.Rbid, dbo.Trebackfab.Custid, dbo.Tcustomersxp.Custname, dbo.Trebackfab.Docref, 
							dbo.Trebackfab.Sumroll, dbo.Trebackfab.Sumwgt, dbo.Trebackfab.Sumprice,
							dbo.Trebackfab.Remark, dbo.Trebackfab.Indate
							FROM dbo.Tcustomersxp INNER JOIN
							dbo.Trebackfab ON dbo.Tcustomersxp.Comid = dbo.Trebackfab.Comid 
							AND dbo.Tcustomersxp.Custid = dbo.Trebackfab.Custid
							WHERE dbo.Trebackfab.Comid = '{Gscomid}' AND dbo.Trebackfab.Sstatus = '1' 
							AND (Rbid LIKE '%{Sval}%' OR dbo.Trebackfab.Custid LIKE '%{Sval}%' OR Custname LIKE '%{Sval}%'
							OR Docref LIKE '%{Sval}%' OR Sumroll LIKE '%{Sval}%' OR Sumwgt LIKE '%{Sval}%' 
							OR Sumprice LIKE '%{Sval}%' OR Remark LIKE '%{Sval}%' OR Indate LIKE '%{Sval}%')")
        FillGrid()
        ShowRecordDetail()
    End Sub
    Private Sub Searchlistbydate()
        Tlist = SQLCommand($"SELECT dbo.Trebackfab.Rbid, dbo.Trebackfab.Custid, dbo.Tcustomersxp.Custname, dbo.Trebackfab.Docref, 
							dbo.Trebackfab.Sumroll, dbo.Trebackfab.Sumwgt, dbo.Trebackfab.Sumprice,
							dbo.Trebackfab.Remark, dbo.Trebackfab.Indate
							FROM dbo.Tcustomersxp INNER JOIN
							dbo.Trebackfab ON dbo.Tcustomersxp.Comid = dbo.Trebackfab.Comid 
							AND dbo.Tcustomersxp.Custid = dbo.Trebackfab.Custid
							WHERE dbo.Trebackfab.Comid = '{Gscomid}' AND dbo.Trebackfab.Sstatus = '1' AND (Indate BETWEEN '{Formatshortdatesave(Dtplistfm.Value)}' AND '{Formatshortdatesave(Dtplistto.Value)}')")
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
        If Trim(Tstbdocpre.Text) = "" Then
            Informmessage("กรุณาติดต่อ Admin เพื่อขอเลข Prefix")
            Exit Sub
        End If
        Tbdyedcomno.Text = Trim(Tstbdocpre.Text) & Genid()
        Insertmaster()
        SQLCommand("UPDATE Tdocprexp SET Lvalue = '" & Trim(Tbdyedcomno.Text).Remove(0, 2) & "',Updusr = '" & Gsuserid & "',Uptype = 'E',Uptime = '" & Formatdatesave(Now) & "' 
                        WHERE  Comid = '" & Gscomid & "' AND Docid = '" & Tstbdocpreid.Text & "' AND Prefix = '" & Trim(Tstbdocpre.Text) & "'")
        Upddetails("A")
        If Gsusername = "SUPHATS" Then
        Else
            Insertlog(Gscomid, Gsusergroupid, Gsuserid, Gsusername, "F123", Trim(Tbdyedbillno.Text), "A", "สร้างรายการ รับผ้าสี", Formatdatesave(Now), Computername, Usrproname)
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
            Insertlog(Gscomid, Gsusergroupid, Gsuserid, Gsusername, "F124", Trim(Tbdyedbillno.Text), "E", "แก้ไขรายการ รับคืนผ้า", Formatdatesave(Now), Computername, Usrproname)
        End If
    End Sub
    Private Sub Insertmaster()
        SQLCommand($"INSERT INTO Trebackfab(Comid,Rbid,Indate,
                                            Custid,Docref,Sumroll,
                                            Sumwgt,Sumprice,Remark,
                                            Restat,Sstatus,Updusr,Uptype,Uptime)
                                     VALUES('{Trim(Gscomid)}','{Trim(Tbdyedcomno.Text)}','{Formatdatesave(Dtprecdate.Value)}',
                                            '{Trim(Tbdhid.Text)}','{Trim(Tbdyedbillno.Text)}','{Trim(Tstbsumroll.Text)}',
                                            '{Trim(Tstbsumkg.Text)}','{Trim(Tbsummoney.Text)}','{Trim(Tbremark.Text)}',
                                            '','1','{Gsuserid }','A','{Formatdatesave(Now)}')") 'Pa comment
        'SQLCommand("INSERT INTO Trecfabcolxp(Comid,Reid,Dhid,Billdyedno,Billknitt,Recdate,Lotno,
        '            Dyedcolor,Dremark,Updusr,Uptype,Uptime)
        '            VALUES('" & Gscomid & "','" & Trim(Tbdyedcomno.Text) & "','" & Trim(Tbdhid.Text) & "','" & Tbdyedbillno.Text & "','" & Tbknittno.Text & "','" & Formatshortdatesave(Dtprecdate.Value) & "','" & Trim(Tbrefablotno.Text) & "',
        '            '" & Tbcolorno.Text & "','" & Trim(Tbremark.Text) & "','" & Gsuserid & "','A','" & Formatdatesave(Now) & "')") 'Pa comment
    End Sub
    Private Sub Editmaster()
        SQLCommand($"UPDATE Trebackfab SET Indate = '{Formatdatesave(Dtprecdate.Value)}', 
                                           Custid = '{Trim(Tbdhid.Text)}', Docref = '{Trim(Tbdyedbillno.Text)}', 
                                           Sumroll = '{Trim(Tstbsumroll.Text)}', Sumwgt = '{Trim(Tstbsumkg.Text)}', 
                                           Sumprice = '{Trim(Tbsummoney.Text)}', Remark = '{Trim(Tbremark.Text)}', 
                                           Restat = '', Sstatus = '1' , Updusr = '{Gsuserid }', Uptype = 'E', 
                                           Uptime = '{Formatdatesave(Now)}'
                     WHERE Rbid = '{Trim(Tbdyedcomno.Text)}' AND Comid = '{Gscomid}'")
    End Sub
    Private Sub Deldetails(Tdlvno As String)
        SQLCommand($"DELETE From Trebackfabdet Where Comid = '{Gscomid}' AND Rbid = '{Trim(Tdlvno)}'")
    End Sub
    Private Sub Upddetails(Etype As String)
        Deldetails(Tbdyedcomno.Text)
        Dim I As Integer
        ProgressBarX1.Value = 0
        Dim Frm As New Formwaitdialoque
        Frm.Show()
        Dim Ord, LotNo, Mkong, Rollno, Clothid, Shadeid, Rollwage, pricekg As String
        'Dim Trollwgt As Double
        For I = 0 To Dgvmas.RowCount - 1
            '    Tkongno = Trim(Dgvmas.Rows(I).Cells("Mkong").Value)
            'Tclothid = Trim(Dgvmas.Rows(I).Cells("Clothid").Value)
            '    Tshadeid = Dgvmas.Rows(I).Cells("Shadeid").Value
            '    Trollwgt = Dgvmas.Rows(I).Cells("Rollwage").Value
            '    Tbrollid = Dgvmas.Rows(I).Cells("rollid").Value

            Ord = Trim(Dgvmas.Rows(I).Cells("Ord").Value)
            Lotno = Trim(Dgvmas.Rows(I).Cells("LotNoDetail").Value)
            Mkong = Trim(Dgvmas.Rows(I).Cells("Mkong").Value)
            Rollno = Trim(Dgvmas.Rows(I).Cells("Rollno").Value)
            Clothid = Trim(Dgvmas.Rows(I).Cells("Clothid").Value)
            Shadeid = Trim(Dgvmas.Rows(I).Cells("Shadeid").Value)
            Rollwage = Trim(Dgvmas.Rows(I).Cells("Rollwage").Value)
            pricekg = Tbkgprice.Text
            SQLCommand($"INSERT INTO Trebackfabdet(Comid,Rbid,Ord,Kongno,Rollno,Clothid,
                                                   Shadeid,Rollwage,Unitprice,Unit,Rollstat,
                                                    Updusr,Uptype,Uptime,Lotno)
                                            VALUES('{Gscomid}','{Trim(Tbdyedcomno.Text)}','{Ord}','{Mkong}','{Rollno}','{Clothid}',
                                                    '{Shadeid}','{Rollwage}','{pricekg}','kg','I',
                                                    '{Gsuserid}','{Etype}','{Formatdatesave(Now)}','{LotNo}')") 'Pa comment
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
        Tmaster = SQLCommand($"SELECT dbo.Trebackfab.Rbid, dbo.Trebackfab.Custid, dbo.Tcustomersxp.Custname, dbo.Trebackfab.Docref, 
                                                  dbo.Trebackfab.Sumroll, dbo.Trebackfab.Sumwgt, dbo.Trebackfab.Sumprice, dbo.Trebackfab.Remark, 
                                                  dbo.Trebackfab.Indate, dbo.Trebackfabdet.Lotno
							               FROM dbo.Tcustomersxp 
                                           INNER JOIN dbo.Trebackfab 
                                                 ON dbo.Tcustomersxp.Comid = dbo.Trebackfab.Comid 
                                                 AND dbo.Tcustomersxp.Custid = dbo.Trebackfab.Custid 
                                           INNER JOIN dbo.Trebackfabdet 
                                                 ON dbo.Tcustomersxp.Comid = dbo.Trebackfabdet.Comid 
                                                 AND dbo.Trebackfab.Rbid = dbo.Trebackfabdet.Rbid
                                           WHERE (dbo.Trebackfab.Comid = '{Gscomid}') 
                                                 AND (dbo.Trebackfab.Sstatus = '1') 
                                                 AND Trebackfab.Rbid = '{Trim(Tbdyedcomno.Text)}' 
                                                 AND Trebackfab.Sstatus = '1'
                                           GROUP BY Trebackfab.Rbid, Trebackfab.Custid, Custname, Docref, Sumroll, 
                                                    Sumwgt, Sumprice, Remark, Indate, Lotno") 'Pa comment

        If Tmaster.Rows.Count > 0 Then
            Tbrefablotno.Text = Tmaster.Rows(0)("Lotno")
            Tbdhid.Text = Tmaster.Rows(0)("Custid")
            Tbdhname.Text = Tmaster.Rows(0)("Custname")
            Tbdyedbillno.Text = Tmaster.Rows(0)("Docref")
            Tbremark.Text = Tmaster.Rows(0)("Remark")
            Dtprecdate.Value = Tmaster.Rows(0)("Indate")
            Kgprice(Tbdyedbillno.Text)
            Binddetails()
            Sumall()
        End If
    End Sub
    Private Sub Kgprice(Tbdyedbillno As String)
        Dim Kgprice = New DataTable
        Kgprice = SQLCommand($"SELECT Kgprice FROM Tsalefabcolxp WHERE Dlvno = '{Trim(Tbdyedbillno)}' AND Comid = '{Gscomid}' ")
        If Kgprice.Rows.Count > 0 Then
            Tbkgprice.Text = Format(Kgprice(0)(0), "###,###.#0")
            Tbkgprice.Enabled = False
        Else
            Tbkgprice.Enabled = True
        End If
    End Sub
    Private Sub Binddetails()
        Tdetails = New DataTable
        Tdetails = SQLCommand($"SELECT fab.Comid,fab.Rbid,fab.Ord,fab.Kongno,fab.Rollno,fab.Clothid, cloth.Clothno, cloth.Ftype, 
							           cloth.Fwidth, fab.Shadeid, shad.Shadedesc, fab.Rollwage,fab.Unitprice,
							           fab.Unit,fab.Rollstat,fab.Updusr,fab.Uptype,fab.Uptime,fab.Lotno
						            FROM  dbo.Trebackfabdet As fab 
						            INNER JOIN dbo.Tclothxp As cloth 
						            ON fab.Comid = cloth.Comid AND fab.Clothid = cloth.Clothid
						            INNER JOIN dbo.Tshadexp As shad 
							        ON fab.Comid = shad.Comid AND fab.Shadeid = shad.Shadeid WHERE fab.Rbid = '{Tbdyedcomno.Text}'")

        Dgvmas.DataSource = Tdetails 'Pa comment
    End Sub
    Private Sub Bindinglist()
        Tlist = New DataTable
        Tlist = SQLCommand($"SELECT dbo.Trebackfab.Rbid, dbo.Trebackfab.Custid, dbo.Tcustomersxp.Custname, dbo.Trebackfab.Docref, 
                                    dbo.Trebackfab.Sumroll, dbo.Trebackfab.Sumwgt, dbo.Trebackfab.Sumprice, dbo.Trebackfab.Remark, 
                                    dbo.Trebackfab.Indate, dbo.Trebackfabdet.Lotno
							 FROM dbo.Tcustomersxp INNER JOIN dbo.Trebackfab 
                                    ON dbo.Tcustomersxp.Comid = dbo.Trebackfab.Comid AND 
                                    dbo.Tcustomersxp.Custid = dbo.Trebackfab.Custid 
                             INNER JOIN dbo.Trebackfabdet 
                                    ON dbo.Tcustomersxp.Comid = dbo.Trebackfabdet.Comid AND 
                                    dbo.Trebackfab.Rbid = dbo.Trebackfabdet.Rbid
                             WHERE (dbo.Trebackfab.Comid = '{Gscomid}') AND 
                                   (dbo.Trebackfab.Sstatus = '1') 
                             GROUP BY Trebackfab.Rbid, Trebackfab.Custid, Custname, Docref, Sumroll, 
                                      Sumwgt, Sumprice, Remark, Indate, Lotno ")

        Dgvlist.DataSource = Tlist
        FillGrid()
        ShowRecordDetail()
    End Sub
    'Private Sub Filterdocpre(Docpre As String)
    '    RemoveCount = 0
    '    For i = 0 To Dgvlist.Rows.Count - 1
    '        If i > Dgvlist.Rows.Count - 1 Then
    '            Exit For
    '        End If
    '        If Dgvlist.Rows(i).Cells("Reid").Value.Substring(0, Trim(Docpre.Length)) <> Trim(Docpre) Then
    '            Dgvlist.Rows.RemoveAt(i)
    '            RemoveCount += 1
    '            i = 0
    '        End If
    '    Next
    'End Sub
    ''Private Sub BindingSendDyelist()
    ''    TSendDyelist = New DataTable
    ''    TSendDyelist = SQLCommand("SELECT '' AS Stat,* FROM Vdyedcommas WHERE Comid = '" & Gscomid & "'")
    ''    SendDyelist.DataSource = TSendDyelist
    ''    Bs = New BindingSource
    ''    Bs.DataSource = TSendDyelist
    ''    BindingNavigator1.BindingSource = Bs
    ''    'FillGrid()
    ''    'ShowRecordDetail()
    ''End Sub
    Private Sub Sumall()
        Dim Sumkg As Double
        Dim Sumroll As Long
        Sumkg = 0.0
        Sumroll = 0
        If Dgvmas.RowCount = 0 Then
            Tstbsumkg.Text = Sumkg
            Tstbsumroll.Text = Sumroll
            Tbsumwgt.Text = Tstbsumkg.Text
            Exit Sub
        End If
        ProgressBarX1.Value = 0
        Dim Frm As New Formwaitdialoque
        Frm.Show()
        Dim I As Integer
        For I = 0 To Dgvmas.RowCount - 1
            Sumkg = Sumkg + CDbl(Dgvmas.Rows(I).Cells("Rollwage").Value)
            ProgressBarX1.Value = ((I + 1) / Dgvmas.Rows.Count) * 100
            ProgressBarX1.Text = "Caculating sum ... " & ProgressBarX1.Value & "%"
        Next
        Sumroll = Dgvmas.RowCount
        Frm.Close()
        ProgressBarX1.Text = "Ready"
        ProgressBarX1.Value = 0
        Tstbsumkg.Text = Format(Sumkg, "###,###.#0")
        Tstbsumroll.Text = Format(Sumroll, "###,###")
        Tbsumwgt.Text = Tstbsumkg.Text
    End Sub
    Private Sub Clrdgrid()
        Dgvmas.AutoGenerateColumns = False
        Dgvmas.DataSource = Nothing
        Dgvmas.Rows.Clear()
    End Sub
    Private Sub Clrtxtbox()
        'Tbdyedbillno.Enabled = True
        Tbdyedcomno.Text = "NEW"
        Tbkongno.Enabled = False
        Tbkg.Enabled = True
        Dtprecdate.Enabled = True
        Tbremark.Enabled = True
        Tbrefablotno.Text = ""
        Tbdhid.Text = ""
        Tbdhname.Text = ""
        Tbkgprice.Text = ""
        Tbdyedbillno.Text = ""
        'Tbkongno.Text = ""
        Tbkg.Text = ""
        Tbremark.Text = ""
        Dtprecdate.Value = Now
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
        If Tbclothid.Text <> "" And Tbclothno.Text <> "" And Tbclothno.Text <> "" And Tbclothtype.Text <> "" And Tbwidht.Text <> "" And
            Tbshadeid.Text <> "" And Tbshadename.Text <> "" And Tbkongno.Text <> "" And Tbkg.Text <> "" Then
            Valid = True
        End If
        Return Valid
    End Function
    Private Function Validnumber() As Boolean
        Dim Valid As Boolean = False
        If CDbl(Tbkg.Text) > 0 Then
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
    'Test
    Private Sub Btmcancel_Click(sender As Object, e As EventArgs) Handles Btmcancel.Click
        Clrtxtbox()
        Clrupdet()
        Tbrefablotno.Text = ""
        Tstbsumroll.Text = ""
        Tstbsumkg.Text = ""
        Tbkongno.Text = ""
        Tbrollid.Text = 0
        Tbkg.Text = ""
        Clrdgrid()
        TabControl1.SelectedTabIndex = 0

        Mainbuttoncancel()
        GroupPanel2.Visible = False
        Tbkgprice.Enabled = False
        Tbsumwgt.Text = "0.00"
        Bindinglist()
        DemoCode.BackColor = Color.White
        'BindingNavigator1.Enabled = False
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
        If Tbdhid.Text <> "" And Tbdhname.Text <> "" And Tbdyedbillno.Text <> "" Then
            Valid = True
        End If
        Return Valid
    End Function

    Private Sub Btdedit_Click_1(sender As Object, e As EventArgs) Handles Btdedit.Click
        If Dgvmas.RowCount = 0 Then
            If Dgvmas.RowCount = 0 Then
                Exit Sub
            End If
        End If

        GroupPanel2.Visible = True
        Tbaddedit.Text = "แก้ไข"
        If Dgvmas.RowCount > 0 Then
            Tbrollid.Text = Trim(Dgvmas.CurrentRow.Cells("Rollno").Value)
            Tbclothid.Text = Trim(Dgvmas.CurrentRow.Cells("Clothid").Value)
            Tbclothno.Text = Trim(Dgvmas.CurrentRow.Cells("Mclothno").Value)
            Tbclothtype.Text = Trim(Dgvmas.CurrentRow.Cells("Clothtype").Value)
            Tbwidht.Text = Trim(Dgvmas.CurrentRow.Cells("Dwidth").Value)
            Tbshadeid.Text = Trim(Dgvmas.CurrentRow.Cells("Shadeid").Value)
            Tbshadename.Text = Trim(InputGrid(Dgvmas.CurrentRow.Cells("Shadedesc").Value))
            Tbkongno.Text = Trim(Dgvmas.CurrentRow.Cells("Mkong").Value)
            Tbkg.Text = Format(Dgvmas.CurrentRow.Cells("Rollwage").Value, "###,###.#0")
            Tbrefablotno.Text = Trim(Dgvmas.CurrentRow.Cells("LotNoDetail").Value)
            DemoColor(Tbshadeid.Text)
        Else
            ClearDetail()
            Tbkongno.Enabled = False
            Tbrollid.Enabled = False
            Tbkg.Enabled = False
            Btdadd.Enabled = False
            Btdcancel.Enabled = False
            Tbkg.Text = ""
            DemoCode.BackColor = Color.White
            Exit Sub
        End If

        Btdadd.Enabled = True
        Btdcancel.Enabled = True
        Tbkongno.Enabled = False
        Tbrollid.Enabled = False
        Tbkg.Enabled = True
        Btmnew.Enabled = False
    End Sub

    Private Sub Btfindbillno_Click(sender As Object, e As EventArgs) Handles Btfindbillno.Click
        Dim Frm As New Formbillsalelist
        Showdiaformcenter(Frm, Me)
        If Frm.Tbcancel.Text = "C" Then
            Exit Sub
        End If
        Tbdyedbillno.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Dlvno").Value)
        Kgprice(Tbdyedbillno.Text)
    End Sub

    Private Sub Btmedit_Click(sender As Object, e As EventArgs) Handles Btmedit.Click
        BtEdit()
    End Sub

    Private Sub BtEdit()
        Btmcancel.Enabled = True
        Btmedit.Enabled = False
        'Tbdyedbillno.Enabled = True
        Tbkongno.Enabled = False
        Tbkg.Enabled = True
        Dtprecdate.Enabled = True
        Tbremark.Enabled = True
        Tbkongno.Text = ""
        Tbkg.Text = ""
        'Dtprecdate.Value = Now
        Findlistsale.Enabled = True
        Tsbwsave.Visible = False
        Btmsave.Enabled = True
        Btmreports.Enabled = False
        Btmdel.Enabled = False
        Btfinddyedh.Enabled = True
        Btfindbillno.Enabled = False
        Tbrollid.Enabled = True
        Btdadd.Enabled = True
        Btdcancel.Enabled = True
        Btdedit.Enabled = True
        Btddel.Enabled = True
        Btdbadd.Enabled = True
    End Sub

    Private Sub Btdbadd_Click(sender As Object, e As EventArgs) Handles Btdbadd.Click
        Findlistsale_Click(sender, e)
        If Dgvmas.RowCount = 0 Then
            Exit Sub
        End If

        Tbaddedit.Text = "เพิ่ม"
        ClearDetail()

        If Dgvmas.RowCount > 0 Then
            Tbkongno.Enabled = False
            Tbkongno.Text = Dgvmas.Rows(0).Cells("Mkong").Value
        Else
            Exit Sub
        End If
        Tbrollid.Text = Dgvmas.CurrentRow.Cells("Rollno").Value
        Btdadd.Enabled = True
        Btdcancel.Enabled = True
        'Tbkongno.Enabled = True
        Tbrollid.Enabled = True
        Tbkg.Enabled = True
        DemoCode.BackColor = Color.White
        Btmnew.Enabled = False
    End Sub

    Private Function rollidnew(GridName As Object, RowsName As String)
        Dim MaxNum = 0
        For i = 0 To GridName.RowCount - 2
            If Trim(GridName.Rows(i).Cells(RowsName).Value) > MaxNum Then
                MaxNum = Trim(GridName.Rows(i).Cells(RowsName).Value)
            End If
        Next
        Return MaxNum
    End Function

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

    Private Sub Tbsumwgt_TextChanged(sender As Object, e As EventArgs) Handles Tbsumwgt.TextChanged
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

    Private Sub ButtonItem1_Click(sender As Object, e As EventArgs) Handles ButtonItem1.Click
        If Confirmdelete() = True Then
            Deldetails(Dgvlist.CurrentRow.Cells("Rbid").Value)
            SQLCommand($"UPDATE Trebackfab SET Sstatus = '0', Updusr = '{Gsuserid}', Uptype = 'D'  WHERE Rbid = '{Trim(Dgvlist.CurrentRow.Cells("Rbid").Value)}'") 'Pa comment
            Clrdgrid()
            Clrtxtbox()
            Mainbuttoncancel()
            Tstbsumroll.Text = ""
            TabControl1.SelectedTabIndex = 0
            GroupPanel2.Visible = False
            Bindinglist()
        End If
    End Sub

    Private Sub Findlistsale_Click(sender As Object, e As EventArgs) Handles Findlistsale.Click
        If Tbdyedbillno.Text = "" Then
            Informmessage("กรุณาเลือกเลขที่ใบขาย")
            Btfindbillno_Click(sender, e)
            Exit Sub
        End If
        If Tbrefablotno.Text = "" Then
            Informmessage("กรุณาใส่เลข Lot No. ใหม่ที่ต้องการ")
            Exit Sub
        End If

        ListLotNo = SQLCommand($"SELECT Lotno FROM Trecfabcoldetxp where Lotno = '{Trim(Tbrefablotno.Text)}'")
        If ListLotNo.Rows.Count > 0 Then
            Informmessage("มีเลข Lot No นี้แล้วในระบบ")
            Exit Sub
        End If

        Dim Frm As New Formlistsalefab
        Frm.Tbdyedbillno.Text = Tbdyedbillno.Text
        Showdiaformcenter(Frm, Me)
        If Frm.Tbcancel.Text = "C" Then
            If Dgvmas.Rows.Count > 0 Then
                Btfindbillno.Enabled = False
            End If
            GroupPanel2.Visible = False
            Exit Sub
        End If

        GroupPanel2.Visible = False
        Dim DatainGride = 0
        For i = 0 To Frm.Dgvmas.RowCount - 1

            If Frm.Dgvmas.Rows(i).Cells("Checked").Value = True Then

                If Tbdyedcomno.Text = "NEW" Then

                    If (Dgvmas.RowCount - 1) = -1 Then ' ถ้า Dgvmas ยังไม่มีข้อมูล
                        For CheckLot = 0 To Frm.Dgvmas.RowCount - 1
                            If Frm.Dgvmas.Rows(CheckLot).Cells("Checked").Value = True Then
                                Dgvmas.Rows.Add()
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("LotNoDetail").Value = Trim(Tbrefablotno.Text)
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Mkong").Value = Frm.Dgvmas.Rows(CheckLot).Cells("Kongno").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Rollno").Value = Frm.Dgvmas.Rows(CheckLot).Cells("Rollno").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Clothid").Value = Frm.Dgvmas.Rows(CheckLot).Cells("Clothid").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Mclothno").Value = Frm.Dgvmas.Rows(CheckLot).Cells("Clothno").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Clothtype").Value = Frm.Dgvmas.Rows(CheckLot).Cells("Ftype").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Dwidth").Value = Frm.Dgvmas.Rows(CheckLot).Cells("Fwidth").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Shadeid").Value = Frm.Dgvmas.Rows(CheckLot).Cells("Shadeid").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Shadedesc").Value = Frm.Dgvmas.Rows(CheckLot).Cells("Shadedesc").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Rollwage").Value = Frm.Dgvmas.Rows(CheckLot).Cells("HaveWgtkg").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Ord").Value = Trim(rollidnew(Dgvmas, "Ord") + 1)
                                DatainGride = 1
                            End If
                        Next
                    Else
                        For CheckLot = 0 To Dgvmas.RowCount - 1
                            If Dgvmas.Rows(CheckLot).Cells("Mkong").Value = Frm.Dgvmas.Rows(i).Cells("Kongno").Value AndAlso 'เบอร์กอง
                                Dgvmas.Rows(CheckLot).Cells("Rollno").Value = Frm.Dgvmas.Rows(i).Cells("Rollno").Value AndAlso 'พับที่
                                Dgvmas.Rows(CheckLot).Cells("Shadeid").Value = Frm.Dgvmas.Rows(i).Cells("Shadeid").Value Then 'สีผ้า
                                If DatainGride = 0 Then
                                    Informmessage("มีบางรายการถูกเลือกอยู่แล้ว")
                                    DatainGride = 1
                                End If
                                Exit For
                            Else
                                If CheckLot = Dgvmas.RowCount - 1 Then
                                    Dgvmas.Rows.Add()
                                    Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("LotNoDetail").Value = Trim(Tbrefablotno.Text)
                                    Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Mkong").Value = Frm.Dgvmas.Rows(i).Cells("Kongno").Value
                                    Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Rollno").Value = Frm.Dgvmas.Rows(i).Cells("Rollno").Value
                                    Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Clothid").Value = Frm.Dgvmas.Rows(i).Cells("Clothid").Value
                                    Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Mclothno").Value = Frm.Dgvmas.Rows(i).Cells("Clothno").Value
                                    Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Clothtype").Value = Frm.Dgvmas.Rows(i).Cells("Ftype").Value
                                    Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Dwidth").Value = Frm.Dgvmas.Rows(i).Cells("Fwidth").Value
                                    Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Shadeid").Value = Frm.Dgvmas.Rows(i).Cells("Shadeid").Value
                                    Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Shadedesc").Value = Frm.Dgvmas.Rows(i).Cells("Shadedesc").Value
                                    Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Rollwage").Value = Frm.Dgvmas.Rows(i).Cells("HaveWgtkg").Value
                                    Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Ord").Value = Trim(rollidnew(Dgvmas, "Ord") + 1)
                                End If
                            End If
                        Next
                    End If

                Else

                    If (Dgvmas.RowCount - 1) = -1 Then
                        For CheckLot = 0 To Frm.Dgvmas.RowCount - 1
                            If Frm.Dgvmas.Rows(CheckLot).Cells("Checked").Value = True Then
                                Tdetails.Rows.Add()
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("LotNoDetail").Value = Trim(Tbrefablotno.Text)
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Mkong").Value = Frm.Dgvmas.Rows(CheckLot).Cells("Kongno").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Rollno").Value = Frm.Dgvmas.Rows(CheckLot).Cells("Rollno").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Clothid").Value = Frm.Dgvmas.Rows(CheckLot).Cells("Clothid").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Mclothno").Value = Frm.Dgvmas.Rows(CheckLot).Cells("Clothno").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Clothtype").Value = Frm.Dgvmas.Rows(CheckLot).Cells("Ftype").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Dwidth").Value = Frm.Dgvmas.Rows(CheckLot).Cells("Fwidth").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Shadeid").Value = Frm.Dgvmas.Rows(CheckLot).Cells("Shadeid").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Shadedesc").Value = Frm.Dgvmas.Rows(CheckLot).Cells("Shadedesc").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Rollwage").Value = Frm.Dgvmas.Rows(CheckLot).Cells("HaveWgtkg").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Ord").Value = Trim(rollidnew(Dgvmas, "Ord") + 1)
                                DatainGride = 1
                            End If
                        Next
                    End If

                    For CheckLot = 0 To Dgvmas.RowCount - 1
                        If Dgvmas.Rows(CheckLot).Cells("Mkong").Value = Frm.Dgvmas.Rows(i).Cells("Kongno").Value AndAlso 'เบอร์กอง
                            Dgvmas.Rows(CheckLot).Cells("Rollno").Value = Frm.Dgvmas.Rows(i).Cells("Rollno").Value AndAlso 'พับที่
                            Dgvmas.Rows(CheckLot).Cells("Shadeid").Value = Frm.Dgvmas.Rows(i).Cells("Shadeid").Value Then 'สีผ้า
                            If DatainGride = 0 Then
                                Informmessage("มีบางรายการถูกเลือกอยู่แล้ว")
                                DatainGride = 1
                            End If
                            Exit For
                        Else
                            If CheckLot = Dgvmas.RowCount - 1 Then
                                Tdetails.Rows.Add()
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("LotNoDetail").Value = Trim(Tbrefablotno.Text)
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Mkong").Value = Frm.Dgvmas.Rows(i).Cells("Kongno").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Rollno").Value = Frm.Dgvmas.Rows(i).Cells("Rollno").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Clothid").Value = Frm.Dgvmas.Rows(i).Cells("Clothid").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Mclothno").Value = Frm.Dgvmas.Rows(i).Cells("Clothno").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Clothtype").Value = Frm.Dgvmas.Rows(i).Cells("Ftype").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Dwidth").Value = Frm.Dgvmas.Rows(i).Cells("Fwidth").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Shadeid").Value = Frm.Dgvmas.Rows(i).Cells("Shadeid").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Shadedesc").Value = Frm.Dgvmas.Rows(i).Cells("Shadedesc").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Rollwage").Value = Frm.Dgvmas.Rows(i).Cells("HaveWgtkg").Value
                                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Ord").Value = Trim(rollidnew(Dgvmas, "Ord") + 1)
                            End If
                        End If
                    Next

                End If

            End If
        Next

        Tbrefablotno.Enabled = False
        If Dgvmas.Rows.Count > 0 Then
            Btfindbillno.Enabled = False
        End If
        Sumall()
    End Sub

    Private Sub Btmreports_Click(sender As Object, e As EventArgs) Handles Btmreports.Click
        If Dgvmas.RowCount = 0 Then
            Exit Sub
        End If
        If Tsbwsave.Visible = True Then
            Informmessage("มีการเปลี่ยนแปลงและยังไม่ทำการบันทึก")
            Exit Sub
        End If
        Dim Frm As New Formrebackfabcolrpt ' เป้
        Frm.Tbdhname.Text = Tbdhname.Text
        Frm.Tbdyedbillno.Text = Tbdyedbillno.Text
        Frm.Tbdhname.Text = Tbdhname.Text
        Frm.Tbdyedbillno.Text = Tbdyedbillno.Text
        Frm.Tbkgprice.Text = Tbkgprice.Text
        Frm.Tbsummoney.Text = Tbsummoney.Text
        Frm.Tbdyedcomno.Text = Tbdyedcomno.Text
        Frm.Dtprecdate.Text = Format(Dtprecdate.Value, "dd/MM/yyyy")
        Frm.Tbsumwgt.Text = Tbsumwgt.Text
        Frm.Tbremark.Text = Tbremark.Text
        CountDgvmas.Text = Dgvmas.RowCount
        Frm.CountDgvmas.Text = CountDgvmas.Text

        ''For i = 0 To Dgvmas.Rows.Count - 1

        ''    Frm.Dgvmas.Rows.Add()
        ''    Frm.Dgvmas.Rows(i).Cells("rollid").Value = Dgvmas.Rows(i).Cells("rollid").Value
        ''    Frm.Dgvmas.Rows(i).Cells("Mclothno").Value = Dgvmas.Rows(i).Cells("Mclothno").Value
        ''    Frm.Dgvmas.Rows(i).Cells("Clothtype").Value = Dgvmas.Rows(i).Cells("Clothtype").Value
        ''    Frm.Dgvmas.Rows(i).Cells("Dwidth").Value = Dgvmas.Rows(i).Cells("Dwidth").Value
        ''    Frm.Dgvmas.Rows(i).Cells("Mkong").Value = Dgvmas.Rows(i).Cells("Mkong").Value
        ''    Frm.Dgvmas.Rows(i).Cells("Rollwage").Value = Dgvmas.Rows(i).Cells("Rollwage").Value
        ''Next
        ''Frm.Tbdhid.Text = Tbdhid.Text
        ''Frm.Tbdhname.Text = Tbdhname.Text
        ''Frm.Tbdyedbillno.Text = Tbdyedbillno.Text

        ''Frm.Tbdyedcomno.Text = Tbdyedcomno.Text
        ''Frm.Tbremark.Text = Tbremark.Text
        ''Frm.Tbdate.Text = Dtprecdate.Text

        ''Frm.ReportViewer1.Reset()
        Frm.Show()
        Clrtxtbox()
        Clrdgrid()
        BindingNavigator1.Enabled = False
        Mainbuttoncancel()
        TabControl1.SelectedTabIndex = 0
        Btmcancel_Click(sender, e)
    End Sub

    Private Sub Ctmtransaction_Click(sender As Object, e As EventArgs) Handles Ctmtransaction.Click
        Opentransaction(Dgvlist.CurrentRow.Cells("Docref").Value)
    End Sub
    Private Sub Opentransaction(Gridrows As String)
        Dim frm As New Formsalefabric
        Dim Tmasterdyed = New DataTable
        Tmasterdyed = SQLCommand($"SELECT '' AS Stat,* FROM Vsalefabcolmas
                                WHERE Comid = '{Gscomid}' AND Dlvno = '{Trim(Gridrows)}' ")
        If Tmasterdyed.Rows.Count > 0 Then
            frm.Showtransaction($"{Gridrows}")
            frm.TabItem2.Visible = False
            frm.Btmnew.Visible = False
            frm.Btmedit.Visible = False
            frm.Btmdel.Visible = False
            frm.Btmsave.Visible = False
            frm.Btmcancel.Visible = False
            frm.Btmreports.Visible = False
            frm.Btmfind.Visible = False
            frm.Show()
        Else
            Informmessage("ไม่พบข้อมูลใบสั่งย้อม")
        End If
    End Sub
    Private Sub Bindingnamebill()
        tlistnamebill = New DataTable
        tlistnamebill = SQLCommand($"SELECT Dyedhid, Dyedhdesc FROM Tdyedhousexp
                                        WHERE Comid = '101' AND Dyedhid = (SELECT Dhid FROM Tdyedcomxp
                                        WHERE Dyecomno = '{Tbdyedbillno.Text}' AND Comid = '101')
                                        AND Sstatus = 1 AND Sactive = '1'")
        'MsgBox(tlistnamebill(0)(0))
        Tbdhid.Text = tlistnamebill(0)(0)
        Tbdhname.Text = tlistnamebill(0)(1)
    End Sub

    Private Sub ToolStripTextBox3_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = (Asc(e.KeyChar) = 39)
    End Sub

    'Private Sub ToolStripTextBox3_TextChanged(sender As Object, e As EventArgs)
    '    Balancefind_Click(sender, e)
    '    If ToolStripTextBox3.Text = "--version" Or ToolStripTextBox3.Text = "-V" Then
    '        Informmessage("26/11/2018 17:00")
    '    End If
    '    If ToolStripTextBox3.Text = "--report" Then
    '        Dim frm As New Formreceivefabrpt
    '        frm.VersionReport()
    '    End If
    'End Sub

    Private Sub Btddel_Click_1(sender As Object, e As EventArgs) Handles Btddel.Click
        If Dgvmas.RowCount = 0 Then
            Exit Sub
        End If

        If Dgvmas.RowCount = 1 Then
            Btfindbillno.Enabled = True
            Tbrefablotno.Enabled = True
        End If

        Dgvmas.Rows.Remove(Dgvmas.CurrentRow)
        Sumall()
        Btdcancel_Click(sender, e)
        Tsbwsave.Visible = True

        Tbkongno.Enabled = False
        Tbrollid.Enabled = False
        Tbkg.Enabled = False
        Btdadd.Enabled = False
        Btdcancel.Enabled = False
        DemoCode.BackColor = Color.White
    End Sub

    Friend Sub Showtransaction(transactionRefab As String)
        Clrdgrid()
        TabControl1.SelectedTabIndex = 1
        Tbdyedcomno.Text = Trim(transactionRefab)
        BindingNavigator1.Enabled = True
        Btmnew.Enabled = False
        Btmedit.Enabled = True
        Btmdel.Enabled = True
        Btmsave.Enabled = False
        Btmcancel.Enabled = True
        Btmreports.Enabled = True
        Tbremark.Enabled = False
        Btdedit.Enabled = False
        Btdadd.Enabled = False
        Btdcancel.Enabled = False
        GroupPanel2.Visible = False
        Btdbadd.Enabled = False
        Btddel.Enabled = False
        Dgvmas.Enabled = False
        Tbremark.Enabled = False
        Bindmaster()
    End Sub

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
            Btdadd.Visible = False
            Btdedit.Visible = False
            Ctdedit.Visible = False
        End If
        If Gscreau = False Then
            Btdadd.Visible = False
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
    Private Sub Clrupdet()
        Tbclothid.Text = ""
        Tbclothno.Text = ""
        Tbclothtype.Text = ""
        Tbwidht.Text = ""
        Tbshadeid.Text = ""
        Tbshadename.Text = ""
    End Sub

    'Test
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
        Findlistsale.Enabled = True
        Btdedit.Enabled = True
        Btddel.Enabled = True
        Ctdedit.Enabled = True
        Ctddel.Enabled = True
        Btfinddyedh.Enabled = True
        Btdadd.Enabled = True
        Btdcancel.Enabled = True
        Btfinddyedh.Enabled = True
        Btfindbillno.Enabled = True
        Btdbadd.Enabled = True
    End Sub
    Private Sub Mainbuttoncancel()
        'Btfindbillno.Visible = True
        'Tbdyedbillno.Size = New Size(99, 24)
        'FindShade.Visible = True
        'Tbshadeid.Size = New Size(72, 24)
        Tbrefablotno.Enabled = False
        Tbkgprice.Enabled = False
        Btfinddyedh.Enabled = False
        Findlistsale.Enabled = False
        Tbdyedbillno.Enabled = False
        Tbkongno.Enabled = False
        Tbkg.Enabled = False
        Btdadd.Enabled = False
        Btdcancel.Enabled = False
        Dtprecdate.Enabled = False
        Btmnew.Enabled = True
        Btmedit.Enabled = False
        Btmdel.Enabled = False
        Btmsave.Enabled = False
        Btmcancel.Enabled = False
        Btmreports.Enabled = False
        Tbremark.Enabled = False
        Btfindbillno.Enabled = False
        Tbrollid.Enabled = False
        Tbdyedcomno.Text = "NEW"
        Disbaledbutton()
    End Sub
    Private Sub Disbaledbutton()
        Btdbadd.Enabled = False
        Btdedit.Enabled = False
        Btddel.Enabled = False
        Ctdedit.Enabled = False
        Ctddel.Enabled = False
    End Sub

End Class