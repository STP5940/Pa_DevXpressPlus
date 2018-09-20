Imports System.ComponentModel
Imports Microsoft.Reporting.WinForms
Public Class Formknittingform
    Private Tmasterknit, Tdetailsknit, Tmasterdlv, Tdetailsdlv, Tlist, Dttemp As DataTable
    Private Pagecount, Maxrec, Pagesize, Currentpage, Recno As Integer
    Private WithEvents Dtplistfm As New DateTimePicker
    Private WithEvents Dtplistto As New DateTimePicker
    Private Sub Formknittingform_Load(sender As Object, e As EventArgs) Handles Me.Load
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
    Private Sub Formknittingform_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dgvlist.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        Dgvlist.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        Dgvmas.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        Dgvmas.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        Bindinglist()
    End Sub
    Private Sub Btmnew_Click(sender As Object, e As EventArgs) Handles Btmnew.Click
        Clrdgrid()
        Clrtxtbox()
        TabControl1.SelectedTabIndex = 1
    End Sub
    Private Sub Btmsave_Click(sender As Object, e As EventArgs) Handles Btmsave.Click
        If Tstbdocpre.Text = "" Then
            Informmessage("กรุณาติดต่อ Admin เพื่อกำหนด Prefix ของเลขที่เอกสาร")
            Exit Sub
        End If
        If Validmas() = False Then
            Informmessage("กรุณาตรวจสอบข้อมูลในการสั่งทอให้ครบถ้วน")
            Exit Sub
        End If
        If Validdet() = False Then
            Informmessage("กรุณาตรวจสอบรายละเอียดในการสั่งทอให้ครบถ้วน")
            Exit Sub
        End If
        If Trim(Tbknitcomno.Text) = "NEW" Then
            Newdoc()
        Else
            Editdoc()
        End If
        Tsbwsave.Visible = False
        Clrdgrid()
        Clrtxtbox()
        TabControl1.SelectedTabIndex = 0
        Bindinglist()
    End Sub
    Private Sub Btmdel_Click(sender As Object, e As EventArgs) Handles Btmdel.Click
        If Trim(Tbknitcomno.Text) = "NEW" Then
            Exit Sub
        End If
        If Trim(Tbknitcomno.Text) = "" Then
            Exit Sub
        End If
        If Confirmdelete() = True Then
            Deldetails(Trim(Tbknitcomno.Text))
            SQLCommand("DELETE FROM Tknittcomxp WHERE Comid = '" & Gscomid & "' AND Knitcomno = '" & Trim(Tbknitcomno.Text) & "'")
            Clrdgrid()
            Clrtxtbox()
        End If
    End Sub
    Private Sub Btmreports_Click(sender As Object, e As EventArgs) Handles Btmreports.Click
        If Dgvmas.RowCount = 0 Then
            Exit Sub
        End If
        If Tsbwsave.Visible = True Then
            Informmessage("มีการเปลี่ยนแปลงและยังไม่ทำการบันทึก")
            Exit Sub
        End If
        Binddetailsdlv()
        Binddetailsknit()
        Dim Frm As New Formknitingfrmrpt
        Frm.ReportViewer1.Reset()
        Frm.Tbdate.Text = Format(Dtpknitcomdate.Value, "dd/MM/yyyy")
        Frm.Tbto.Text = Trim(Tbknitname.Text)
        Frm.Tbknitcomno.Text = Trim(Tbknitcomno.Text)
        Frm.Tbredate.Text = Format(Dtprecdate.Value, "dd/MM/yyyy")
        Frm.Tbremark.Text = Trim(Tbremark.Text)
        If Gsexpau = False Then
            Frm.ReportViewer1.ShowExportButton = False
        End If
        If Gspriau = False Then
            Frm.ReportViewer1.ShowPrintButton = False
        End If
        Dim Rds, Rds1 As New ReportDataSource()
        Rds.Name = "DataSet1"
        Rds.Value = Tdetailsdlv
        Frm.ReportViewer1.LocalReport.DataSources.Add(Rds)
        Rds1.Name = "DataSet2"
        Rds1.Value = Tdetailsknit
        Frm.ReportViewer1.LocalReport.DataSources.Add(Rds1)
        'showform(frm)
        Frm.Show()
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
    Private Sub Tstbkeyword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tstbkeyword.KeyPress
        e.Handled = (Asc(e.KeyChar) = 39)
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
        Clrdgrid()
        Clrtxtbox()
        Tbknitcomno.Text = Trim(Dgvlist.CurrentRow.Cells("Knitcomno").Value)
        Tbknitcomno.Enabled = False
        Bindmasterknit()
        Bindmasterdlv()
        Binddetailsdlv()
        TabControl1.SelectedTabIndex = 1
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
    Private Sub Btfinddlvno_Click(sender As Object, e As EventArgs) Handles Btfinddlvno.Click
        Dim Frm As New Formdlvnoknittlist
        Showdiaformcenter(Frm, Me)
        If Frm.Tbcancel.Text = "C" Then
            Exit Sub
        End If
        Tbdlvyarnno.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Mdevno").Value)
        Bindmasterdlv()
    End Sub
    Private Sub Dgvyarn_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvyarn.CellClick
        If Dgvyarn.RowCount = 0 Then
            Exit Sub
        End If
        Dgvyarn.CurrentRow.Selected = True
    End Sub
    Private Sub Btfindfabtypeid_Click(sender As Object, e As EventArgs) Handles Btfindfabtypeid.Click
        If Validmas() = False Then
            Informmessage("กรุณากรอกข้อมูลใบส่งด้าย ")
            Exit Sub
        End If
        Dim Frm As New Formfabrictypelist
        Showdiaformcenter(Frm, Me)
        If Frm.Tbcancel.Text = "C" Then
            Exit Sub
        End If
        Tbclothid.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Mid").Value)
        Tbclothno.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Mname").Value)
        Tbtypename.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Ftype").Value)
        Tbwidth.Text = Trim(Frm.Dgvmas.CurrentRow.Cells("Fwidth").Value)
        Tbqtyroll.Focus()
    End Sub
    Private Sub Tbqtyroll_KeyDown(sender As Object, e As KeyEventArgs) Handles Tbqtyroll.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Tbwgtkg.Focus()
        End If
    End Sub
    Private Sub Tbwgtkg_KeyDown(sender As Object, e As KeyEventArgs) Handles Tbwgtkg.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Tbfinwgt.Focus()
        End If
    End Sub
    Private Sub Tbfinwgt_KeyDown(sender As Object, e As KeyEventArgs) Handles Tbfinwgt.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Btdadd_Click(sender, e)
        End If
    End Sub
    Private Sub Btdadd_Click(sender As Object, e As EventArgs) Handles Btdadd.Click
        If Validinput() = False Then
            Informmessage("กรุณาตรวจสอบข้อมูลให้ถูกต้อง ครบถ้วน")
            Exit Sub
        End If
        If Validnumber() = False Then
            Informmessage("กรุณาตรวจจำนวนให้ถูกต้อง ครบถ้วน(พับ,ก.ก.)")
            Exit Sub
        End If
        If Tbaddedit.Text = "เพิ่ม" Then
            If Chkdupyarnidingrid() = True Then
                Informmessage("ผ้าเบอร์นี้ มีแล้ว")
                Exit Sub
            End If
        End If
        Select Case Trim(Tbaddedit.Text)
            Case "เพิ่ม"
                If Tbknitcomno.Text = "NEW" Then
                    Dgvmas.Rows.Add()
                Else
                    Tdetailsknit.Rows.Add()
                End If
                Tsbwsave.Visible = True
                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Mcomid").Value = Gscomid
                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Mclothid").Value = Trim(Tbclothid.Text)
                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Mclothno").Value = Trim(Tbclothno.Text)
                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Mftypename").Value = Trim(Tbtypename.Text)
                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Mwidt").Value = Trim(Tbwidth.Text)
                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Mqty").Value = CLng(Tbqtyroll.Text)
                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Mkg").Value = CDbl(Tbwgtkg.Text)
                Dgvmas.Rows(Dgvmas.RowCount - 1).Cells("Mfin").Value = Trim(Tbfinwgt.Text)
            Case "แก้ไข"
                Tsbwsave.Visible = True
                Dgvmas.CurrentRow.Cells("Mcomid").Value = Gscomid
                Dgvmas.CurrentRow.Cells("Mclothid").Value = Trim(Tbclothid.Text)
                Dgvmas.CurrentRow.Cells("Mclothno").Value = Trim(Tbclothno.Text)
                Dgvmas.CurrentRow.Cells("Mftypename").Value = Trim(Tbtypename.Text)
                Dgvmas.CurrentRow.Cells("Mwidt").Value = Trim(Tbwidth.Text)
                Dgvmas.CurrentRow.Cells("Mqty").Value = CLng(Tbqtyroll.Text)
                Dgvmas.CurrentRow.Cells("Mkg").Value = CDbl(Tbwgtkg.Text)
                Dgvmas.CurrentRow.Cells("Mfin").Value = Trim(Tbfinwgt.Text)
        End Select
        Sumall()
        Btdcancel_Click(sender, e)
        Tbremark.Focus()
    End Sub
    Private Sub Btdcancel_Click(sender As Object, e As EventArgs) Handles Btdcancel.Click
        Tbclothid.Text = ""
        Tbclothno.Text = ""
        Tbtypename.Text = ""
        Tbwidth.Text = ""
        Tbqtyroll.Text = ""
        Tbwgtkg.Text = ""
        Tbfinwgt.Text = ""
    End Sub
    Private Sub Btdedit_Click(sender As Object, e As EventArgs) Handles Btdedit.Click
        If Dgvmas.RowCount = 0 Then
            Exit Sub
        End If
        If Validmas() = False Then
            Informmessage("กรุณาตรวจสอบข้อมูลในการสั่งทอให้ครบถ้วน")
            Exit Sub
        End If
        Tbaddedit.Text = "แก้ไข"
        Tbclothid.Text = Trim(Dgvmas.CurrentRow.Cells("Mclothid").Value)
        Tbclothno.Text = Trim(Dgvmas.CurrentRow.Cells("Mclothno").Value)
        Tbtypename.Text = Trim(Dgvmas.CurrentRow.Cells("Mftypename").Value)
        Tbwidth.Text = Trim(Dgvmas.CurrentRow.Cells("Mwidt").Value)
        Tbqtyroll.Text = Format(CLng(Dgvmas.CurrentRow.Cells("Mqty").Value), "###,###")
        Tbwgtkg.Text = Format(CDbl(Dgvmas.CurrentRow.Cells("Mkg").Value), "###,###")
        Tbfinwgt.Text = Trim(Dgvmas.CurrentRow.Cells("Mfin").Value)
        Tbqtyroll.Focus()
    End Sub
    Private Sub Btddel_Click(sender As Object, e As EventArgs) Handles Btddel.Click
        If Dgvmas.RowCount = 0 Then
            Exit Sub
        End If
        Dgvmas.Rows.Remove(Dgvmas.CurrentRow)
        Sumall()
        Btdcancel_Click(sender, e)
        Tsbwsave.Visible = True
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
            Dgvmas.CurrentCell = Dgvmas(4, e.RowIndex)
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
    Private Sub Tbremark_KeyDown(sender As Object, e As KeyEventArgs) Handles Tbremark.KeyDown
        If (e.KeyCode = Keys.Enter) Then
        End If
    End Sub
    Private Sub Formknittingform_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Tbknitcomno.Text = "NEW" And Dgvmas.RowCount = 0 Then
            'My.Forms.Formmain.Panel1.Visible = True
            Exit Sub
        End If
        If Confirmcloseform("สั่งทอ") Then
            e.Cancel = False
            'My.Forms.Formmain.Panel1.Visible = True
        Else
            e.Cancel = True
        End If
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
    Private Sub Bindinglist()
        Tlist = New DataTable
        Tlist = SQLCommand("SELECT '' AS Stat,* FROM Vknitcommas 
                            WHERE Comid = '" & Gscomid & "'")
        Dgvlist.DataSource = Tlist
        FillGrid()
        ShowRecordDetail()
    End Sub
    Private Sub Bindmasterknit()
        Tmasterknit = New DataTable
        Tmasterknit = SQLCommand("SELECT * FROM Tknittcomxp 
                                WHERE Comid = '" & Gscomid & "' AND Knitcomno = '" & Trim(Tbknitcomno.Text) & "'")
        If Tmasterknit.Rows.Count > 0 Then
            Dtpknitcomdate.Value = Tmasterknit.Rows(0)("Knitcomdate")
            Dtprecdate.Value = Tmasterknit.Rows(0)("Rcdate")
            Tbdlvyarnno.Text = Trim(Tmasterknit.Rows(0)("Dlvno"))
            Tbremark.Text = Trim(Tmasterknit.Rows(0)("Dremark"))
            Binddetailsknit()
        End If
    End Sub
    Private Sub Bindmasterdlv()
        Tmasterdlv = New DataTable
        Tmasterdlv = SQLCommand("SELECT * FROM Vdeliyarnmas 
                                WHERE Comid = '" & Gscomid & "' AND Dlvno = '" & Trim(Tbdlvyarnno.Text) & "'")
        If Tmasterdlv.Rows.Count > 0 Then
            Tbknitid.Text = Trim(Tmasterdlv.Rows(0)("Knitid"))
            Tbknitname.Text = Trim(Tmasterdlv.Rows(0)("Knitdesc"))
            Binddetailsdlv()
        End If
    End Sub
    Private Sub Binddetailsdlv()
        Tdetailsdlv = New DataTable
        Tdetailsdlv = SQLCommand("SELECT * FROM Vdeliyarndet
                                WHERE Comid = '" & Gscomid & "' AND Dlvno = '" & Trim(Tbdlvyarnno.Text) & "'")
        Dgvyarn.DataSource = Tdetailsdlv
        Sumdlvyarn()
    End Sub
    Private Sub Binddetailsknit()
        Tdetailsknit = New DataTable
        Tdetailsknit = SQLCommand("SELECT * FROM Vknitcomdet
                                WHERE Comid = '" & Gscomid & "' AND Knitcomno = '" & Trim(Tbknitcomno.Text) & "'")
        Dgvmas.DataSource = Tdetailsknit
        Sumall()
    End Sub
    Private Sub Deldetails(Tdlvno As String)
        SQLCommand("DELETE FROM Tknittcomdetxp
                    WHERE Comid = '" & Gscomid & "' AND Knitcomno = '" & Tdlvno & "'")
    End Sub
    Private Sub Newdoc()
        Tbknitcomno.Text = Trim(Tstbdocpre.Text) & Genid()
        Insertmaster()
        SQLCommand("UPDATE Tdocprexp SET Lvalue = '" & Trim(Tbknitcomno.Text).Remove(0, 2) & "',Updusr = '" & Gsuserid & "',Uptype = 'E',Uptime = '" & Formatdatesave(Now) & "' 
                        WHERE  Comid = '" & Gscomid & "' AND Docid = '" & Tstbdocpreid.Text & "' AND Prefix = '" & Trim(Tstbdocpre.Text) & "'")
        Upddetails("A")
        If Gsusername = "SUPHATS" Then
        Else
            Insertlog(Gscomid, Gsusergroupid, Gsuserid, Gsusername, "F121", Trim(Tbknitcomno.Text), "A", "สร้างรายการ ใบสั่งทอ", Formatdatesave(Now), Computername, Usrproname)
        End If
    End Sub
    Private Sub Editdoc()
        If Tbknitcomno.Text = "NEW" Then
            Exit Sub
        End If
        Editmaster()
        Upddetails("E")
        If Gsusername = "SUPHATS" Then
        Else
            Insertlog(Gscomid, Gsusergroupid, Gsuserid, Gsusername, "F121", Trim(Tbknitcomno.Text), "E", "แก้ไขรายการ ใบสั่งทอ", Formatdatesave(Now), Computername, Usrproname)
        End If
    End Sub
    Private Sub Insertmaster()
        SQLCommand("INSERT INTO Tknittcomxp(Comid,Knitcomdate,Knitcomno,Rcdate,Dlvno,
                    Dremark,Updusr,Uptype,Uptime)
                    VALUES('" & Gscomid & "','" & Formatshortdatesave(Dtpknitcomdate.Value) & "','" & Trim(Tbknitcomno.Text) & "','" & Formatshortdatesave(Dtprecdate.Value) & "','" & Trim(Tbdlvyarnno.Text) & "',
                    '" & Trim(Tbremark.Text) & "','" & Gsuserid & "','A','" & Formatdatesave(Now) & "')")
    End Sub
    Private Sub Editmaster()
        SQLCommand("UPDATE Tknittcomxp SET Knitcomdate = '" & Formatshortdatesave(Dtpknitcomdate.Value) & "',Rcdate = '" & Formatshortdatesave(Dtprecdate.Value) & "',
                    Dlvno = '" & Trim(Tbdlvyarnno.Text) & "',Dremark = '" & Trim(Tbremark.Text) & "',Updusr = '" & Gsuserid & "',Uptype = 'E',
                    Uptime = '" & Formatdatesave(Now) & "'
                    WHERE Comid = '" & Gscomid & "' AND Knitcomno = '" & Tbknitcomno.Text & "'")
    End Sub
    Private Sub Upddetails(Etype As String)
        Deldetails(Tbknitcomno.Text)
        Dim I As Integer
        ProgressBarX1.Value = 0
        Dim Frm As New Formwaitdialoque
        Frm.Show()
        Dim Tclothid, Tfinw As String
        Dim Tqtyroll As Long
        Dim Twgkg As Double
        For I = 0 To Dgvmas.RowCount - 1
            Tclothid = Trim(Dgvmas.Rows(I).Cells("Mclothid").Value)
            Tqtyroll = Dgvmas.Rows(I).Cells("Mqty").Value
            Twgkg = Dgvmas.Rows(I).Cells("Mkg").Value
            Tfinw = Trim(Dgvmas.Rows(I).Cells("Mfin").Value)
            SQLCommand("INSERT INTO Tknittcomdetxp(Comid,Knitcomno,Clothid,Qtyroll,Wgtkg,
                        Finwgt,Updusr,Uptype,Uptime)
                        VALUES ('" & Gscomid & "','" & Trim(Tbknitcomno.Text) & "','" & Tclothid & "'," & Tqtyroll & "," & Twgkg & ",
                                '" & Tfinw & "','" & Gsuserid & "','" & Etype & "','" & Formatdatesave(Now) & "')")
            ProgressBarX1.Value = ((I + 1) / Dgvmas.Rows.Count) * 100
            ProgressBarX1.Text = "Saving ... " & ProgressBarX1.Value & "%"
        Next
        Frm.Close()
        ProgressBarX1.Text = "Ready"
        ProgressBarX1.Value = 0
    End Sub
    Private Sub Searchlistbyoth(Sval As String)
        If Sval = "" Then
            Bindinglist()
            Exit Sub
        End If
        Tlist = SQLCommand("SELECT '' AS Stat,* FROM Vknitcommas
                                WHERE Comid = '" & Gscomid & "' AND  
                                (Knitcomno LIKE '%' + '" & Sval & "' + '%' OR Knitdesc LIKE '%' + '" & Sval & "' + '%')")
        FillGrid()
        ShowRecordDetail()
    End Sub
    Private Sub Searchlistbydate()
        Tlist = SQLCommand("SELECT '' AS Stat,* FROM Vknitcommas
                                WHERE Comid = '" & Gscomid & "' AND 
                                (Knitcomdate BETWEEN '" & Formatshortdatesave(Dtplistfm.Value) & "' AND '" & Formatshortdatesave(Dtplistto.Value) & "')")
        FillGrid()
        ShowRecordDetail()
    End Sub
    Private Function Validmas() As Boolean
        Dim Valid As Boolean = False
        If Tbdlvyarnno.Text <> "" And Tbknitcomno.Text <> "" Then
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
    Private Function Validinput() As Boolean
        Dim Valid As Boolean = False
        If Tbclothid.Text <> "" And Tbclothno.Text <> "" And Tbtypename.Text <> "" And Tbwidth.Text <> "" And Tbqtyroll.Text <> "" And Tbwgtkg.Text <> "" And Tbfinwgt.Text <> "" Then
            Valid = True
        End If
        Return Valid
    End Function
    Private Function Validnumber() As Boolean
        Dim Valid As Boolean = False
        If CLng(Tbqtyroll.Text) > 0 And CDbl(Tbwgtkg.Text) > 0 Then
            Valid = True
        End If
        Return Valid
    End Function
    Private Function Chkdupyarnidingrid() As Boolean
        Dim Dup As Boolean = False
        If Dgvmas.RowCount = 0 Then
            Dup = False
        Else
            Dim I As Integer
            For I = 0 To Dgvmas.RowCount - 1
                If Trim(Tbclothid.Text) = Trim(Dgvmas.Rows(I).Cells("Mclothid").Value) Then
                    Dup = True
                    Exit For
                End If
            Next
        End If
        Return Dup
    End Function
    Private Sub Sumdlvyarn()
        Dim Sumnwkg, Sumgwkg As Double
        Dim Sumctn As Long
        Sumnwkg = 0.0
        Sumgwkg = 0.0
        Sumctn = 0
        If Dgvyarn.RowCount = 0 Then
            Tbsumdlvnwkg.Text = Sumnwkg
            Tbsumdlvgwkg.Text = Sumgwkg
            Tbsumdlvctn.Text = Sumctn
            Exit Sub
        End If
        ProgressBarX1.Value = 0
        Dim Frm As New Formwaitdialoque
        Frm.Show()
        Dim I As Integer
        For I = 0 To Dgvyarn.RowCount - 1
            Sumnwkg = Sumnwkg + Dgvyarn.Rows(I).Cells("Nwkgpc").Value
            Sumgwkg = Sumgwkg + Dgvyarn.Rows(I).Cells("Gwkgpc").Value
            Sumctn = Sumctn + Dgvyarn.Rows(I).Cells("Dynopack").Value
            ProgressBarX1.Value = ((I + 1) / Dgvyarn.Rows.Count) * 100
            ProgressBarX1.Text = "Caculating sumyarn ... " & ProgressBarX1.Value & "%"
        Next
        Frm.Close()
        ProgressBarX1.Text = "Ready"
        ProgressBarX1.Value = 0
        Tbsumdlvnwkg.Text = Format(Sumnwkg, "###,####.#0")
        Tbsumdlvgwkg.Text = Format(Sumgwkg, "###,###.#0")
        Tbsumdlvctn.Text = Sumctn
    End Sub
    Private Sub Sumall()
        Dim Sumkg As Double
        Dim Sumroll As Long
        Sumkg = 0.0
        Sumroll = 0
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
            ProgressBarX1.Text = "Caculating sum(LB) ... " & ProgressBarX1.Value & "%"
        Next
        Frm.Close()
        ProgressBarX1.Text = "Ready"
        ProgressBarX1.Value = 0
        Tstbsumroll.Text = Sumroll
        Tstbsumkg.Text = Format(Sumkg, "###,###.#0")
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
    Private Sub Clrdgrid()
        Dgvmas.AutoGenerateColumns = False
        Dgvmas.DataSource = Nothing
        Dgvmas.Rows.Clear()
        Dgvyarn.AutoGenerateColumns = False
        Dgvyarn.DataSource = Nothing
        Dgvyarn.Rows.Clear()
    End Sub
    Private Sub Clrtxtbox()
        Tbdlvyarnno.Text = ""
        Tbknitid.Text = ""
        Tbknitname.Text = ""
        Tbknitcomno.Text = "NEW"
        Dtpknitcomdate.Value = Now
        Dtprecdate.Value = Now
        Tbsumdlvgwkg.Text = ""
        Tbsumdlvnwkg.Text = ""
        Tbsumdlvctn.Text = ""
        Tstbsumroll.Text = ""
        Tstbsumkg.Text = ""
        Tbremark.Text = ""
        Tsbwsave.Visible = False
    End Sub
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
    Private Sub Editcontextdetmenu()
        Ctmmenudetgrid.Displayed = False
        Ctmmenudetgrid.PopupMenu(Control.MousePosition)
    End Sub
    Private Sub Editcontextlistmenu()
        Ctmmenugrid.Displayed = False
        Ctmmenugrid.PopupMenu(Control.MousePosition)
    End Sub


End Class