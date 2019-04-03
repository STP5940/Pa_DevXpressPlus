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
        Tlist = SQLCommand($"SELECT Vsumsale.Comid, Vsumsale.Jobno, Vsumsale.Ord, Vsumsale.Clothid, Vsumsale.Clothno, 
                                    Vsumsale.Ftype, Vsumsale.Dozen, Vsumsale.Dlvno, Vsumsale.Knitcomno, Vsumsale.Qtyroll, 
                                    Vsumsale.Dyedcomno, Vsumsale.Shadeid, Vsumsale.Shadedesc, Vsumsale.Qtyrollsum, 
                                    Vsumsale.Reid, Vsumsale.Lotno, Vsumsale.Kongno, Vsumsale.Qtyrollresum, 
                                    Vsumsale.Salewgtkgsum, Vsumsale.Dlvnosale, Vsumsale.Wgtkgsale, Vsumsale.Dlvnocount
                             FROM Vsumsale 
							 INNER JOIN Tjobcontroldetlogxp
							       ON Vsumsale.Comid = Tjobcontroldetlogxp.Comid AND Vsumsale.Jobno = Tjobcontroldetlogxp.Jobno AND 
								      Vsumsale.Ord = Tjobcontroldetlogxp.KnitOrd AND Vsumsale.Knitcomno = Tjobcontroldetlogxp.Knitcomno
							 WHERE (Vsumsale.Jobno = '{Tbjobno.Text}') AND (Vsumsale.Comid = '{Gscomid}')")
        Dgvmas.DataSource = Tlist
        Changecolor()

        Dim Ords As Integer = 0
        For i = 0 To Dgvmas.RowCount - 1
            Ords = i + 1
            Dgvmas.Rows(i).Cells("Ord").Value = Ords
        Next
        Frm.Close()
    End Sub

    Private Sub Changecolor()
        Dim Btndel() As Object = {Color.FromArgb(239, 228, 176), Color.FromArgb(198, 255, 226),
                                  Color.FromArgb(255, 255, 196), Color.FromArgb(255, 187, 187)}

        Dim Knitcomno As String = ""
        Dim Colors As Integer = 0

        For i = 0 To Dgvmas.RowCount - 1
            If Dgvmas.Rows(i).Cells("Knitcomno").Value <> Knitcomno Then
                Knitcomno = Dgvmas.Rows(i).Cells("Knitcomno").Value
                Colors += IIf(Colors = Btndel.Count - 1, -(Btndel.Count - 1), 1)
                Dgvmas.Rows(i).DefaultCellStyle.BackColor = Btndel(Colors)
            Else
                Dgvmas.Rows(i).DefaultCellStyle.BackColor = Btndel(Colors)
            End If
        Next
    End Sub

    Private Sub Btmclose_Click(sender As Object, e As EventArgs) Handles Btmclose.Click
        Close()
    End Sub

    Private Sub Btrefresh_Click(sender As Object, e As EventArgs) Handles Btrefresh.Click
        Bindinglist()
    End Sub

    Private Sub Dgvmas_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Dgvmas.ColumnHeaderMouseClick
        Changecolor()
    End Sub
End Class