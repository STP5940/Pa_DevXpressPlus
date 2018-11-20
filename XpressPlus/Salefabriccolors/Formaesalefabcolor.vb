Public Class Formaesalefabcolor
    Private Tmaster, FilterFab As DataTable
    Private CheckedOne As Byte = 0
    Private Sub Formaesalefabcolor_Load(sender As Object, e As EventArgs) Handles Me.Load
        Bindingmaster()

    End Sub
    Private Sub Bindingmaster()
        'MessageBox.Show(Tbclothid.Text)
        Tmaster = New DataTable
        'Tmaster = SQLCommand($"SELECT Pubno,Lotno,Kongno,Rollwage FROM Vrecfabcoldet where Comid = '{Gscomid}' ")

        If Trim(Tbkongno.Text) = "" Then
            Tmaster = SQLCommand($"SELECT Pubno,Lotno,Kongno,Rollwage,Clothid,Clothno,Ftype,Fwidth
                               From Vrecfabcoldet where Comid = '{Gscomid}' AND Clothid = '{Trim(Tbclothid.Text)}'")
        Else
            If RS.Text = "RS" Then
                Tmaster = SQLCommand($"SELECT Pubno,Lotno,Kongno,Rollwage,Clothid,Clothno,Ftype,Fwidth
                               From Vrecfabcoldet where Comid = '{Gscomid}' AND Clothid = '{Trim(Tbclothid.Text)}' AND Kongno = '{Trim(Tbkongno.Text)}'")
            Else
                Tmaster = SQLCommand($"SELECT Pubno,Lotno,Kongno,Rollwage,Clothid,Clothno,Ftype,Fwidth
                               From Vrecfabcoldet where Comid = '{Gscomid}' AND Clothid = '{Trim(Tbclothid.Text)}' AND Kongno = '{Trim(Tbkongno.Text)}' AND Billdyedno = '{Trim(RS.Text)}'")
            End If
        End If

        Dgvmas.DataSource = Tmaster
        FilterDgvmas()

    End Sub

    Private Sub Formsalefablotnolist_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dgvmas.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        Dgvmas.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
    End Sub

    Private Sub Btcancel_Click(sender As Object, e As EventArgs) Handles Btcancel.Click
        Tbcancel.Text = "C"
        Me.Close()
    End Sub

    Private Sub Btok_Click(sender As Object, e As EventArgs) Handles Btok.Click
        'MsgBox(Dgvmas.Rows(0).Cells("Checked").Value)
        'MsgBox(Dgvmas.Rows(1).Cells("Checked").Value)
        'If Dgvmas.Rows(0).Cells("Checked").Value = 1 Then
        '    MsgBox(1)
        'End If
        'Exit Sub
        Me.Close()

        'Dim frm As New Formsalefabric
        'frm.Dgvmas.Rows(0).Cells("Dlot").Value = 0

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

    Private Sub FilterDgvmas()
        FilterFab = New DataTable
        For i = 0 To Dgvmas.Rows.Count - 1
            If i > Dgvmas.Rows.Count - 1 Then
                Exit For
            End If
            FilterFab = SQLCommand($"SELECT * FROM Tsalefabcoldetxp WHERE Lotno = '{Dgvmas.Rows(i).Cells("Mlotno").Value}' AND Kongno = '{Dgvmas.Rows(i).Cells("Kongno").Value}' And Rollno = '{Dgvmas.Rows(i).Cells("Pubno").Value}' And Comid = '{Gscomid}'")
            If FilterFab.Rows.Count > 0 Then
                Dgvmas.Rows.RemoveAt(i)
                i -= 1
            End If
        Next
    End Sub
End Class