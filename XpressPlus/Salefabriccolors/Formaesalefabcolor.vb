Public Class Formaesalefabcolor
    Private Tmaster As DataTable
    Private Sub Formaesalefabcolor_Load(sender As Object, e As EventArgs) Handles Me.Load
        Bindingmaster()
    End Sub
    Private Sub Bindingmaster()
        'MessageBox.Show(Tbclothid.Text)
        Tmaster = New DataTable
        Tmaster = SQLCommand($"SELECT Pubno,Lotno,Kongno,Rollwage FROM Vrecfabcoldet where Comid = '{Gscomid}' ")
        Dgvmas.DataSource = Tmaster
    End Sub

    Private Sub Btcancel_Click(sender As Object, e As EventArgs) Handles Btcancel.Click
        Tbcancel.Text = "C"
        Me.Close()
    End Sub

    Private Sub Formsalefablotnolist_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dgvmas.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        Dgvmas.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
    End Sub

End Class