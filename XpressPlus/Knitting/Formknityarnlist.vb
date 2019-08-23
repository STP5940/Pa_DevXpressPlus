﻿Public Class Formknityarnlist
    Private Tmaster As DataTable
    Private Sub Bindingmaster()
        Tmaster = New DataTable
        Tmaster = SQLCommand("SELECT '' AS Stat,Comid,Yarnid,Yarndesc FROM Tyarnxp
                                WHERE Comid = '" & Gscomid & "' AND Sstatus = 1 AND Sactive = '1'")
        Dgvmas.DataSource = Tmaster
    End Sub
    Private Sub Filtermastergrid()
        If Tmaster.Rows.Count < 1 Then
            Exit Sub
        End If
        If Tbkeyword.Text = "" Then
            Tmaster.DefaultView.RowFilter = String.Empty
            Exit Sub
        End If
        Try
            Tmaster.DefaultView.RowFilter = String.Format("Yarnid Like '%{0}%' OR Yarndesc LIKE '%{1}%'", Trim(Tbkeyword.Text), Trim(Tbkeyword.Text))
        Catch ex As Exception
            Tbkeyword.Text = ""
        End Try

    End Sub
    Private Sub Dgvmas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvmas.CellClick
        If Dgvmas.RowCount = 0 Then
            Exit Sub
        End If
        Dgvmas.CurrentRow.Selected = True
    End Sub
    Private Sub Dgvmas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvmas.CellDoubleClick
        If Dgvmas.RowCount = 0 Then
            Exit Sub
        End If
        Dgvmas.CurrentRow.Selected = True
        Btok_Click(sender, e)
    End Sub
    Private Sub Btcancel_Click(sender As Object, e As EventArgs) Handles Btcancel.Click
        Tbcancel.Text = "C"
        Me.Close()
    End Sub
    Private Sub Btok_Click(sender As Object, e As EventArgs) Handles Btok.Click
        If Dgvmas.RowCount = 0 Then
            Tbcancel.Text = "C"
        End If
        Me.Close()
    End Sub
    Private Sub Btmsearch_Click(sender As Object, e As EventArgs) Handles Btmsearch.Click
        Filtermastergrid()
    End Sub
    Private Sub Tbkeyword_TextChanged(sender As Object, e As EventArgs) Handles Tbkeyword.TextChanged
        If Me.Created Then
            Btmsearch_Click(sender, e)
        End If
        If Tbkeyword.Text = "--version" Or Tbkeyword.Text = "-V" Then
            Informmessage("26/11/2018 12:00")
        End If
    End Sub
    Private Sub Formknityarnlist_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Tbjobcontrol.Text = "" Then
            Bindingmaster()
        Else
            Tmaster = New DataTable
            Tmaster = SQLCommand($"SELECT DISTINCT Tjobcontroldetxp.Comid, Tyarnxp.Yarnid, Tyarnxp.Yarndesc 
										    FROM Tyarnxp 
											RIGHT OUTER JOIN Tclothxp 
											ON Tyarnxp.Comid = Tclothxp.Comid AND (Tyarnxp.Yarnid = Tclothxp.Yarnid1  OR Tyarnxp.Yarnid = Tclothxp.Yarnid2)
											RIGHT OUTER JOIN Tjobcontroldetxp 
											ON Tclothxp.Clothid = Tjobcontroldetxp.Clothid AND Tclothxp.Comid = Tjobcontroldetxp.Comid 
											LEFT OUTER JOIN Tshadexp 
											ON Tjobcontroldetxp.Comid = Tshadexp.Comid AND Tshadexp.Shadeid = Tjobcontroldetxp.Shadeid
											WHERE (dbo.Tjobcontroldetxp.Comid = '{Gscomid}') AND (dbo.Tjobcontroldetxp.Jobno = '{Trim(Tbjobcontrol.Text)}')  AND 
												  (Tyarnxp.Sstatus = 1) AND (Tyarnxp.Sactive = '1')")
            Dgvmas.DataSource = Tmaster
        End If
    End Sub
    Private Sub Tbkeyword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tbkeyword.KeyPress
        e.Handled = (Asc(e.KeyChar) = 39)
    End Sub
    Private Sub Formknityarnlist_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dgvmas.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        Dgvmas.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
    End Sub
End Class