Public Class Formaddeditjoblist
    Friend Havedoz As Boolean = False

    Private Sub Formaddeditjoblist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Havedoz = True Then
            Tbdozen.Visible = True
            LabelX1.Visible = True
        Else
            Tbdozen.Text = "0"
            Tbdozen.Visible = False
            LabelX1.Visible = False
        End If
    End Sub

    Private Sub Btcancel_Click(sender As Object, e As EventArgs) Handles Btcancel.Click
        Tbcancel.Text = "C"
        Close()
    End Sub

    Private Sub Btfindfabtypeid_Click(sender As Object, e As EventArgs) Handles Btfindfabtypeid.Click
        Dim frm As New Formfabrictypelistforjob
        Showdiaformcenter(frm, Me)
        If frm.Tbcancel.Text = "C" Then
            Exit Sub
        End If
        Tbclothid.Text = Trim(frm.Dgvmas.CurrentRow.Cells("Clothid").Value)
        Tbclothno.Text = Trim(frm.Dgvmas.CurrentRow.Cells("Clothno").Value)
        Tbfinwidth.Text = Trim(frm.Dgvmas.CurrentRow.Cells("Fwidth").Value)
        Tbtype.Text = Trim(frm.Dgvmas.CurrentRow.Cells("Ftype").Value)
        If Trim(frm.Dgvmas.CurrentRow.Cells("Havedoz").Value) = True Then
            Tbdozen.Text = ""
            Tbdozen.Visible = True
            LabelX1.Visible = True
            Havedoz = True
        Else
            Tbdozen.Text = "0"
            Tbdozen.Visible = False
            LabelX1.Visible = False
            Havedoz = False
            Exit Sub
        End If
    End Sub

    Private Sub Btok_Click(sender As Object, e As EventArgs) Handles Btok.Click
        If Validatebox(Tbclothid, Tbqtyroll, TbwgtKg, Tbfinwgt, Tbdozen) = False Then
            Exit Sub
        End If
        Close()
    End Sub

    ' ============  Validate input box MsgShows  ============ '
    Friend Function Validatebox(ByVal ParamArray values() As Object)
        For i As Integer = 0 To UBound(values, 1)
            If values(i).text = "" OrElse values(i).text = ".00" Then
                Informmessage($"กรุณา{values(i).Tag}")
                Return False
            End If
        Next i
        Return True
    End Function
End Class