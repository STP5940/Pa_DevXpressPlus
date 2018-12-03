Public Class Formlistsalefab
    Private Tmaster, FilterFab As DataTable
    Private CheckedOne As Byte = 0
    Private Sub Formlistsalefab_Load(sender As Object, e As EventArgs) Handles Me.Load
        Bindingmaster()
    End Sub
    Private Sub Bindingmaster()

        Tmaster = New DataTable
        If Trim(Tbdyedbillno.Text) = "" Then
            Tmaster = SQLCommand($"SELECT Comid,Dlvno,Lotno,Kongno,Rollno,Shadeid,Shadedesc,
						                                    Clothid,Clothno,Ftype,Fwidth,Wgtkg,
						                                    SendWgtkg,Wgtkg-SendWgtkg As HaveWgtkg 
						                                    FROM VrebackfabSale 
						                                WHERE SendWgtkg < Wgtkg AND Comid = '{Gscomid}' ")
        Else
            Tmaster = SQLCommand($"SELECT Comid,Dlvno,Lotno,Kongno,Rollno,Shadeid,Shadedesc,
					                                    	Clothid,Clothno,Ftype,Fwidth,Wgtkg,
						                                    SendWgtkg,Wgtkg-SendWgtkg As HaveWgtkg 
					                                    	FROM VrebackfabSale 
						                                WHERE SendWgtkg < Wgtkg AND Comid = '{Gscomid}' 
                                                        AND Dlvno = '{Trim(Tbdyedbillno.Text)}' ")
        End If
        Dgvmas.DataSource = Tmaster

    End Sub

    Private Sub Formlistsalefab_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dgvmas.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        Dgvmas.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
    End Sub

    Private Sub Btcancel_Click(sender As Object, e As EventArgs) Handles Btcancel.Click
        Tbcancel.Text = "C"
        Me.Close()
    End Sub

    Private Sub Btok_Click(sender As Object, e As EventArgs) Handles Btok.Click
        Me.Close()
    End Sub

    Private Sub Tscball_Click(sender As Object, e As EventArgs) Handles Tscball.Click
        If CheckedOne = 0 Then
            For i = 0 To Dgvmas.RowCount - 1
                Dgvmas.Rows(i).Cells("Checked").Value = True
            Next
            CheckedOne = 1
        Else
            For i = 0 To Dgvmas.RowCount - 1
                Dgvmas.Rows(i).Cells("Checked").Value = False
            Next
            CheckedOne = 0
        End If
    End Sub

    Private Sub Tbkeyword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tbkeyword.KeyPress
        e.Handled = (Asc(e.KeyChar) = 39)
    End Sub
    Private Sub Tbkeyword_TextChanged(sender As Object, e As EventArgs) Handles Tbkeyword.TextChanged
        Btmsearch_Click(sender, e)
        If Tbkeyword.Text = "--version" Or Tbkeyword.Text = "-V" Then
            Informmessage("30/11/2018 15:00")
        End If
    End Sub
    Private Sub Btmsearch_Click(sender As Object, e As EventArgs) Handles Btmsearch.Click
        Filtermastergrid(Tbkeyword.Text)
    End Sub
    Private Sub Filtermastergrid(Sval As String)
        If Trim(Sval) = "" Then
            Bindingmaster()
            Exit Sub
        End If
        Try
            Tmaster.DefaultView.RowFilter = String.Format("Dlvno Like '%{0}%' OR Lotno Like '%{0}%' OR Kongno Like '%{0}%'", Trim(Sval))
        Catch ex As Exception
            Sval = ""
        End Try
    End Sub
End Class