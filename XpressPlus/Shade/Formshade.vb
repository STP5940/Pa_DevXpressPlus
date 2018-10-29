Imports System.ComponentModel
Public Class Formshade
    Private Tmaster, Dttemp As DataTable
    Private Pagecount, Maxrec, Pagesize, Currentpage, Recno As Integer
    Private Sub Formshade_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dgvmas.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        Dgvmas.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        'Setauthorize() 'เป้
        Bindingmaster()
    End Sub
    Private Sub Bindingmaster()
        Tmaster = New DataTable
        Tmaster = SQLCommand("SELECT '' AS Stat,  * FROM Tshadexp
                                WHERE Comid = '" & Gscomid & "' AND Sstatus = 1")
        Dgvmas.DataSource = Tmaster
        FillGrid()
        ShowRecordDetail()
    End Sub
    Private Sub Searchmaster(Sval As String)
        If Sval = "" Then
            Bindingmaster()
            Exit Sub
        End If
        Tmaster = SQLCommand("SELECT '' AS Stat,  * FROM Tshadexp 
                                WHERE Sstatus = 1 AND Comid = '" & Gscomid & "' AND   
                                (Shadeid LIKE '%' + '" & Sval & "' + '%' OR Shadedesc LIKE '%' + '" & Sval & "' + '%')")
        FillGrid()
        ShowRecordDetail()
    End Sub
    Private Sub Btmadd_Click(sender As Object, e As EventArgs) Handles Btmadd.Click
        Dim Frm As New Formaeshade
        Frm.Tbaddedit.Text = "เพิ่ม"
        Frm.Cbactive.Checked = True
        Frm.Cbactive.Enabled = False
        Showdiaformcenter(Frm, Me)
        If Frm.Tbcancel.Text = "C" Then
            Exit Sub
        End If
        Bindingmaster()
    End Sub
    Private Sub Btmedit_Click(sender As Object, e As EventArgs) Handles Btmedit.Click
        If Dgvmas.RowCount = 0 Then
            Exit Sub
        End If
        Dim Frm As New Formaeshade
        Frm.Tbaddedit.Text = "แก้ไข"
        Frm.Tbmid.Text = Trim(Dgvmas.CurrentRow.Cells("Mid").Value)
        Frm.Tbmdesc.Text = Trim(Dgvmas.CurrentRow.Cells("Mdesc").Value)
        If Dgvmas.CurrentRow.Cells("Mact").Value = True Then
            Frm.Cbactive.Checked = True
        Else
            Frm.Cbactive.Checked = False
        End If
        Showdiaformcenter(Frm, Me)
        If Frm.Tbcancel.Text = "C" Then
            Exit Sub
        End If
        Bindingmaster()
    End Sub
    Private Sub Btmdel_Click(sender As Object, e As EventArgs) Handles Btmdel.Click
        If Dgvmas.RowCount = 0 Then
            Exit Sub
        End If
        If Confirmdelete() = True Then
            Dim Tshadeid = Trim(Dgvmas.CurrentRow.Cells("Mid").Value)
            SQLCommand("UPDATE Tshadexp SET Sstatus = '0',Sactive = '0',Updusr = '" & Gsuserid & "',Uptype = 'D',
                        Uptime = '" & Formatdatesave(Now) & "'  
                        WHERE Comid = '" & Gscomid & "' AND Shadeid = '" & Tshadeid & "'")
            If Gsusername = "SUPHATS" Then
            Else
                Insertlog(Gscomid, Gsusergroupid, Gsuserid, Gsusername, "F118", Tshadeid, "D", "ลบ Shade", Formatdatesave(Now), Computername, Usrproname)
            End If
            Bindingmaster()
        End If
    End Sub
    Private Sub Btmsearch_Click(sender As Object, e As EventArgs) Handles Btmsearch.Click
        Searchmaster(Trim(Tbmkeyword.Text))
    End Sub
    Private Sub Btmclose_Click(sender As Object, e As EventArgs) Handles Btmclose.Click
        Me.Close()
    End Sub
    Private Sub Tbmkeyword_TextChanged(sender As Object, e As EventArgs) Handles Tbmkeyword.TextChanged
        Btmsearch_Click(sender, e)
    End Sub
    Private Sub Dgvmas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvmas.CellClick
        If Dgvmas.RowCount = 0 Then
            Exit Sub
        End If
        Dgvmas.CurrentRow.Selected = True
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
    Private Sub Formshade_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        '  My.Forms.Formmain.Panel1.Visible = True
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
            If Statusmodify(Dgvmas) = True Then
                If Confirmnextstage() = True Then
                    Currentpage = 1
                    Recno = 0
                    LoadPage()
                Else
                    Exit Sub
                End If
            Else
                Currentpage = 1
                Recno = 0
                LoadPage()
            End If
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
                If Statusmodify(Dgvmas) = True Then
                    If Confirmnextstage() = True Then
                        Recno = Pagesize * (Currentpage - 1)
                    Else
                        Currentpage = Currentpage + 1
                        Exit Sub
                    End If
                Else
                    Recno = Pagesize * (Currentpage - 1)
                End If
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
            If Statusmodify(Dgvmas) = True Then
                If Confirmnextstage() = True Then
                    LoadPage()
                Else
                    Currentpage = Currentpage - 1
                    Exit Sub
                End If
            Else
                LoadPage()
            End If
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
            If Statusmodify(Dgvmas) = True Then
                If Confirmnextstage() = True Then
                    Currentpage = Pagecount
                    Recno = Pagesize * (Currentpage - 1)
                    LoadPage()
                Else
                    Exit Sub
                End If
            Else
                Currentpage = Pagecount
                Recno = Pagesize * (Currentpage - 1)
                LoadPage()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub LoadPage()
        Dim i, startRec, endRec As Integer
        Dttemp = Tmaster.Clone
        If Currentpage = Pagecount Then
            endRec = Maxrec
        Else
            endRec = Pagesize * Currentpage
        End If
        startRec = Recno
        If Tmaster.Rows.Count > 0 Then
            For i = startRec To endRec - 1
                Dttemp.ImportRow(Tmaster.Rows(i))
                Recno = Recno + 1
            Next
        End If
        Dgvmas.DataSource = Dttemp
        DisplayPageInfo()
        ShowRecordDetail()
    End Sub
    Private Sub FillGrid()
        Pagesize = (CInt(Dgvmas.Height) \ CInt(Dgvmas.RowTemplate.Height)) - 2
        Maxrec = Tmaster.Rows.Count
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
        Tbmrecord.Text = "แสดง " & (Dgvmas.RowCount) & " รายการ จาก " & Tmaster.Rows.Count & " รายการ"
    End Sub
    Private Sub Setauthorize()
        If Gscreau = False Then
            Btmadd.Visible = False
        End If
        If Gswriau = False Then
            Btmedit.Visible = False
        End If
        If Gsdelau = False Then
            Btmdel.Visible = False
        End If
        If Gsseaau = False Then
            Tbmkeyword.Visible = False
            Btmsearch.Visible = False
        End If
    End Sub
End Class