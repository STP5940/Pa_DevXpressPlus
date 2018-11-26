Public Class Formknitfordyelist
    Private Tmaster As DataTable
    Private Sub Formknitfordyelist_Load(sender As Object, e As EventArgs) Handles Me.Load
        Bindingmaster()
    End Sub
    Private Sub Tbkeyword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tbkeyword.KeyPress
        e.Handled = (Asc(e.KeyChar) = 39)
    End Sub
    Private Sub Tbkeyword_TextChanged(sender As Object, e As EventArgs) Handles Tbkeyword.TextChanged
        If Me.Created Then
            Btmsearch_Click(sender, e)
        End If
        If Tbkeyword.Text = "--version" Or Tbkeyword.Text = "-V" Then
            Informmessage("26/11/2018 15:00")
        End If
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
        'Dim Knitcomno = Dgvmas.CurrentRow.Cells("Knitcomno").Value
        'Dim Clothid = Dgvmas.CurrentRow.Cells("Clothid").Value
        'Dim Qtyroll = Dgvmas.CurrentRow.Cells("Qtyroll").Value

        Tmaster = New DataTable
        Tmaster = SQLCommand("SELECT * FROM Vknitcomdet  WHERE Comid = '" & Gscomid & "' order by Knitcomno")
        'SELECT SUM(Qtyroll) AS Qtyroll FROM Tdyedcomdetxp WHERE Knittcomid = 'VC180900008'
        'Dim PriceSell = New DataTable
        'PriceSell = SQLCommand("SELECT SUM(Qtyroll) AS Qtyroll FROM Tdyedcomdetxp WHERE Knittcomid = 'VC180900008'")
        Dgvmas.DataSource = Tmaster

        'Dim SellSum = New DataTable
        'For I = 0 To Dgvmas.RowCount - 1
        '    'MessageBox.Show(Dgvmas.Rows(I).Cells("Knitcomno").Value)
        '    SellSum = SQLCommand($"SELECT SUM(Qtyroll) AS Sum FROM Tdyedcomdetxp WHERE Knittcomid = '{Knitcomno}' and Clothid= '{Clothid}'")
        '    SumAll.DataSource = SellSum
        '    'CountStock
        'Next
    End Sub
    Private Sub Filtermastergrid()
        If Tmaster.Rows.Count = 0 Then
            Exit Sub
        End If
        If Tbkeyword.Text = "" Then
            Tmaster.DefaultView.RowFilter = String.Empty
            Exit Sub
        End If
        Try
            Tmaster.DefaultView.RowFilter = String.Format($"Knitcomno Like '%{Trim(Tbkeyword.Text)}%' OR Clothno LIKE '%{Trim(Tbkeyword.Text)}%'")
        Catch ex As Exception
            Tbkeyword.Text = ""
        End Try
    End Sub

    Private Sub Formknitfordyelist_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dgvmas.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        Dgvmas.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
    End Sub

    Private Sub Dgvmas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvmas.CellClick
        Dim Knitcomno = Dgvmas.CurrentRow.Cells("Knitcomno").Value
        Dim Clothid = Dgvmas.CurrentRow.Cells("Clothid").Value
        Dim Qtyroll = Dgvmas.CurrentRow.Cells("Qtyroll").Value
        'MessageBox.Show(Knitcomno)
        'MessageBox.Show(Clothid)

        Dim SellSum = New DataTable
        SellSum = SQLCommand($"SELECT SUM(Qtyroll) AS Sum FROM Tdyedcomdetxp WHERE Knittcomid = '{Knitcomno}' and Clothid= '{Clothid}'")
        DataSum.DataSource = SellSum
        SellSums.Text = If(IsDBNull(DataSum.Rows(0).Cells("Sum").Value), Qtyroll, (Qtyroll - DataSum.Rows(0).Cells("Sum").Value))
        Send.Text = If(IsDBNull(DataSum.Rows(0).Cells("Sum").Value), 0, DataSum.Rows(0).Cells("Sum").Value)

        If SellSums.Text < "1" Then
            SellSums.BackColor = Color.FromArgb(255, 224, 192)
        Else
            SellSums.BackColor = Color.FromArgb(192, 255, 192)
        End If
    End Sub

End Class