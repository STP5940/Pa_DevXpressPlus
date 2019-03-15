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
        Dim Frm As New Formwaitdialoque
        Frm.Show()
        Tlist = New DataTable
        Tlist = SQLCommand($"SELECT Comid, Jobno, Clothid, Clothno, Ftype, Dozen, Dlvno,
	                               Knitcomno, Qtyroll, Dyedcomno, Shadeid, Shadedesc,
	                               Qtyrollsum, Reid, Lotno, Kongno, Qtyrollresum,
	                               Salewgtkgsum, Dlvnosale, Wgtkgsale, Dlvnocount
                             FROM Vsumsale WHERE (Jobno = '{Tbjobno.Text}') AND (Comid = '{Gscomid}') ")
        Dgvmas.DataSource = Tlist

        Dim Btndel() As Object = {Color.LightSkyBlue, Color.Green, Color.GreenYellow}
        Dim Knitcomno As String = ""
        Dim Colors As Integer = 0

        For i = 0 To Dgvmas.RowCount - 1
            If Colors = 2 Then
                Colors = 0
            End If
            If Dgvmas.Rows(i).Cells("Knitcomno").Value <> Knitcomno Then
                Colors += 1
                Knitcomno = Dgvmas.Rows(i).Cells("Knitcomno").Value
                Dgvmas.Rows(i).DefaultCellStyle.BackColor = Btndel(Colors)
            Else
                Dgvmas.Rows(i).DefaultCellStyle.BackColor = Btndel(Colors)
            End If
        Next

        Dim Ords As Integer = 0
        For i = 0 To Dgvmas.RowCount - 1
            Ords = i + 1
            Dgvmas.Rows(i).Cells("Ord").Value = Ords
        Next
        Frm.Close()
    End Sub

    Private Sub Btmclose_Click(sender As Object, e As EventArgs) Handles Btmclose.Click
        Close()
    End Sub

    Private Sub Btrefresh_Click(sender As Object, e As EventArgs) Handles Btrefresh.Click
        Bindinglist()
    End Sub
End Class