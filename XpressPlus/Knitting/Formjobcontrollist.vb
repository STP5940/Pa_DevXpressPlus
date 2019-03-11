Public Class Formjobcontrollist
    Private Tmaster, Tdetails As DataTable
    Private Sub Formjobcontrollist_Load(sender As Object, e As EventArgs) Handles Me.Load
        Bindingmaster()
    End Sub
    Private Sub Formjobcontrollist_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dgvmas.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        Dgvmas.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
    End Sub
    Private Sub Btmsearch_Click(sender As Object, e As EventArgs) Handles Btmsearch.Click
        Filtermastergrid()
    End Sub
    Private Sub Tbkeyword_TextChanged(sender As Object, e As EventArgs) Handles Tbkeyword.TextChanged
        If Me.Created Then
            Btmsearch_Click(sender, e)
        End If
        If Tbkeyword.Text = "--version" Or Tbkeyword.Text = "-V" Then
            Informmessage("07/03/2019 15:00")
        End If
    End Sub
    Private Sub Tbkeyword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tbkeyword.KeyPress
        e.Handled = (Asc(e.KeyChar) = 39)
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
    Private Sub Bindingmaster()
        Tmaster = New DataTable
        Tmaster = SQLCommand($"SELECT Jobno,Custname
                                      FROM Tjobcontrolxp
                                      LEFT OUTER JOIN Tcustomersxp
	                                       ON Tjobcontrolxp.Custid = Tcustomersxp.Custid AND Tjobcontrolxp.Comid = Tcustomersxp.Comid
                                      WHERE Tjobcontrolxp.Comid = '{Gscomid}' AND Tjobcontrolxp.Sstatus = '1'")
        Dgvmas.DataSource = Tmaster
        Bindingdetails()
    End Sub
    Private Sub Bindingdetails()
        If Tmaster.Rows.Count - 1 < 0 Then
            Exit Sub
        End If
        Tdetails = New DataTable
        Tdetails = SQLCommand($"SELECT Tjobcontroldetxp.Comid, Tjobcontroldetxp.Jobno, Tjobcontroldetxp.Ord, 
                                       Tjobcontroldetxp.Clothid, Tclothxp.Clothno, Tjobcontroldetxp.Qtyroll, 
                                       Tjobcontroldetxp.Wgtkg, Tjobcontroldetxp.Finwgt, Tjobcontroldetxp.Dozen, 
                                       Tjobcontroldetxp.Dlvroll, Tjobcontroldetxp.Remainroll, Tclothxp.Ftype, 
                                       Tclothxp.Fwidth, Tclothxp.Havedoz
					            FROM dbo.Tjobcontroldetxp 
					            LEFT OUTER JOIN dbo.Tclothxp 
					                 ON dbo.Tjobcontroldetxp.Clothid = dbo.Tclothxp.Clothid AND dbo.Tjobcontroldetxp.Comid = dbo.Tclothxp.Comid
					            WHERE Tjobcontroldetxp.Comid = '{Gscomid}' AND Tjobcontroldetxp.Jobno = '{Dgvmas.CurrentRow.Cells("Jobno").Value}'")
        Dgvlist.DataSource = Tdetails
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
            Tmaster.DefaultView.RowFilter = String.Format("Jobno Like '%{0}%' or Custname Like '%{0}%'", Trim(Tbkeyword.Text))
        Catch ex As Exception
            Tbkeyword.Text = ""
        End Try

    End Sub

    Private Sub Dgvmas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvmas.CellClick
        Bindingdetails()
    End Sub

End Class