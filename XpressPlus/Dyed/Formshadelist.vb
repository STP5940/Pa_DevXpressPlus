Public Class Formshadelist
    Private Tmaster As DataTable
    Private Sub Formshadelist_Load(sender As Object, e As EventArgs) Handles Me.Load
        Bindingmaster()
    End Sub
    Private Sub Formshadelist_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dgvmas.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        Dgvmas.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
    End Sub
    Private Sub Tbkeyword_TextChanged(sender As Object, e As EventArgs) Handles Tbkeyword.TextChanged
        If Me.Created Then
            Btmsearch_Click(sender, e)
        End If
        If Tbkeyword.Text = "--version" Or Tbkeyword.Text = "-V" Then
            Informmessage("26/11/2018 15:00")
        End If
    End Sub
    Private Sub Tbkeyword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tbkeyword.KeyPress
        e.Handled = (Asc(e.KeyChar) = 39)
    End Sub
    Private Sub Btmsearch_Click(sender As Object, e As EventArgs) Handles Btmsearch.Click
        Filtermastergrid()
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

        If Tbknitcomno.Text <> "" Then
            Dim shadeinjob = SQLCommand($"SELECT DISTINCT '' AS Stat,dbo.Tjobcontroldetxp.Shadeid, dbo.Tshadexp.Shadedesc
	                                             FROM dbo.Tshadexp 
				                                 RIGHT OUTER JOIN Tjobcontroldetxp 
				                                    ON Tshadexp.Shadeid = Tjobcontroldetxp.Shadeid AND Tshadexp.Comid = Tjobcontroldetxp.Comid 
			                                     RIGHT OUTER JOIN dbo.Vsumsale 
				                                    ON dbo.Tjobcontroldetxp.Comid = dbo.Vsumsale.Comid AND dbo.Tjobcontroldetxp.Jobno = dbo.Vsumsale.Jobno AND 
				                                    dbo.Tjobcontroldetxp.Clothid = dbo.Vsumsale.Clothid
                                             WHERE (dbo.Vsumsale.Knitcomno = '{Tbknitcomno.Text}') AND (dbo.Vsumsale.Comid = '{Gscomid}') 
                                                   AND (dbo.Vsumsale.Jobno <> '') AND (Vsumsale.Clothid = '{Tbclothid.Text}') AND Tjobcontroldetxp.Knitcomno = '{Tbknitcomno.Text}' ")

            If shadeinjob.Rows.Count > 0 AndAlso shadeinjob(0)("Shadeid").ToString <> "" Then
                Dgvmas.DataSource = shadeinjob
                Exit Sub
            End If
        End If

        Tmaster = SQLCommand("SELECT '' AS Stat,Comid,Shadeid,Shadedesc FROM Tshadexp
                                WHERE Comid = '" & Gscomid & "' AND Sstatus = '1' AND Sactive = '1'")
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
            Tmaster.DefaultView.RowFilter = String.Format("Shadeid Like '%{0}%' OR Shadedesc LIKE '%{1}%'", Trim(Tbkeyword.Text), Trim(Tbkeyword.Text))
        Catch ex As Exception
            Tbkeyword.Text = ""
        End Try
    End Sub
End Class