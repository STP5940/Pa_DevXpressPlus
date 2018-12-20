Public Class Formkongnolist
    Private Tmaster, Countsale, Counthave As DataTable

    Private Sub Formcustomerslist_Load(sender As Object, e As EventArgs) Handles Me.Load
        Bindingmaster()
    End Sub

    Private Sub Bindingmaster()
        Tmaster = New DataTable
        Tmaster = SQLCommand($"SELECT DISTINCT Kongno
                                        FROM Vrecfabcoldet 
                                        WHERE (Comid = '{Gscomid}') AND (Clothid = '{Tbclothid.Text}')
                                                UNION
                                        SELECT DISTINCT Kongno
                                        FROM dbo.Vrebackfabdet
                                        WHERE (Rollstat = 'I') AND (Comid = '{Gscomid}') AND (Clothid = '{Tbclothid.Text}')")
        Dgvmas.DataSource = Tmaster
        FilterDgvmas()
    End Sub
    Private Sub FilterDgvmas()
        Countsale = New DataTable
        Counthave = New DataTable

        For i = 0 To Dgvmas.Rows.Count - 1
            If i > Dgvmas.Rows.Count - 1 Then
                Exit For
            End If
            Countsale = SQLCommand($"SELECT Count(*) As Countsale FROM Tsalefabcoldetxp 
                                         WHERE Kongno = '{Dgvmas.Rows(i).Cells("Kongno").Value}' AND 
                                               Comid = '{Gscomid}' -- รายการที่ขายไป")
            Counthave = SQLCommand($"SELECT SUM(Counthave) AS Counthave 
                                         FROM ( SELECT Count(*) As Counthave FROM Trecfabcoldetxp 
                                                    WHERE  Kongno = '{Dgvmas.Rows(i).Cells("Kongno").Value}' 
                                                    AND Comid = '{Gscomid}'
									            UNION
									            SELECT Count(*) As Counthave
										            FROM Vrebackfabdet 
                                                    WHERE Rollstat = 'I' 
                                                    And Kongno = '{Dgvmas.Rows(i).Cells("Kongno").Value}' 
                                                    AND Comid = '{Gscomid}' 
									          ) AS TabelCounthave -- รายการที่มีอยู่")

                If Countsale(0)(0) = Counthave(0)(0) Then
                    Dgvmas.Rows.RemoveAt(i)
                    i -= 1
                End If
        Next
    End Sub
    Private Sub Filtermastergrid()
        If Tmaster.Rows.Count < 1 Then
            Exit Sub
        End If
        If Tbkeyword.Text = "" Then
            Tmaster.DefaultView.RowFilter = String.Empty
            Exit Sub
        End If
        Tmaster.DefaultView.RowFilter = String.Format("Custid Like '%{0}%' OR Custname LIKE '%{1}%'", Trim(Tbkeyword.Text), Trim(Tbkeyword.Text))
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
    End Sub
    Private Sub Tbkeyword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tbkeyword.KeyPress
        e.Handled = (Asc(e.KeyChar) = 39)
    End Sub
    Private Sub Formcustomerslist_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dgvmas.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        Dgvmas.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
    End Sub
End Class