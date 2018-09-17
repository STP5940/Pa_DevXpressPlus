Public Class Formfabrolllist
    Private Tmaster As DataTable
    Private Sub Formfabrolllist_Load(sender As Object, e As EventArgs) Handles Me.Load
        Bindingmaster()
    End Sub
    Private Sub Tbkeyword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tbkeyword.KeyPress
        e.Handled = (Asc(e.KeyChar) = 39)
    End Sub
    Private Sub Tbkeyword_TextChanged(sender As Object, e As EventArgs) Handles Tbkeyword.TextChanged
        Btmsearch_Click(sender, e)
    End Sub
    Private Sub Btmsearch_Click(sender As Object, e As EventArgs) Handles Btmsearch.Click
        Filtermastergrid()
    End Sub
    Private Sub Tscball_CheckedChanged(sender As Object, e As EventArgs) Handles Tscball.CheckedChanged
        If Dgvmas.RowCount = 0 Then
            Exit Sub
        End If
        Dim I As Integer
        If Tscball.Checked = True Then
            For I = 0 To Dgvmas.RowCount - 1
                Dgvmas.Rows(I).Cells("Mchoose").Value = True
            Next
        Else
            For I = 0 To Dgvmas.RowCount - 1
                Dgvmas.Rows(I).Cells("Mchoose").Value = False
            Next
        End If
    End Sub
    Private Sub Dgvmas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvmas.CellClick
        If Dgvmas.RowCount = 0 Then
            Exit Sub
        End If
        Dgvmas.CurrentRow.Selected = True
    End Sub
    Private Sub Dgvmas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvmas.CellContentClick
        If Dgvmas.RowCount = 0 Then
            Exit Sub
        End If
        Dgvmas.EndEdit()
    End Sub
    Private Sub Btok_Click(sender As Object, e As EventArgs) Handles Btok.Click
        If Dgvmas.RowCount = 0 Then
            Tbcancel.Text = "C"
        End If
        Me.Close()
    End Sub
    Private Sub Btcancel_Click(sender As Object, e As EventArgs) Handles Btcancel.Click
        Tbcancel.Text = "C"
        Me.Close()
    End Sub
    Private Sub Bindingmaster()
        Tmaster = New DataTable
        Tmaster = SQLCommand("SELECT 'False'  AS Choo, Pubno,CONVERT(VARCHAR(20),Rollwage) AS  Rollwage FROM Vrecfabcoldet
                            WHERE Comid = '" & Gscomid & "' AND Clothid = '" & Tbclothid.Text & "' AND Lotno = '" & Tblotno.Text & "' 
                            AND Kongno = '" & Tbkongno.Text & "'")
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
        Tmaster.DefaultView.RowFilter = String.Format("Pubno Like '%{0}%' OR Rollwage LIKE '%{1}%'", Trim(Tbkeyword.Text), Trim(Tbkeyword.Text))
    End Sub

    Private Sub Formfabrolllist_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dgvmas.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        Dgvmas.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
    End Sub
End Class