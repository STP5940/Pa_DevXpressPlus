Imports System.ComponentModel
Public Class Formfabfollow
    Private Tlist As DataTable
    Private Sub MetroTileItem5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Formfabfollow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dgvmas.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        Dgvmas.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        Me.WindowState = FormWindowState.Maximized
        Bindinglist()
    End Sub
    Private Sub Bindinglist()
        Tlist = New DataTable
        Tlist = SQLCommand($"SELECT Comid, Jobno, Clothid, Clothno, Ftype, Dozen, Dlvno,
	                               Knitcomno, Qtyroll, Dyedcomno, Shadeid, Shadedesc,
	                               Qtyrollsum, Reid, Lotno, Kongno, Qtyrollresum,
	                               Salewgtkgsum, Dlvnosale, Wgtkgsale, Dlvnocount
                             FROM Vsumsale WHERE (Jobno = '{Tbjobno.Text}') AND (Comid = '{Gscomid}') ")
        Dgvmas.DataSource = Tlist

        Dim Ords As Integer = 0
        For i = 0 To Dgvmas.RowCount - 1
            Ords = i + 1
            Dgvmas.Rows(i).Cells("Ord").Value = Ords
        Next
    End Sub
End Class