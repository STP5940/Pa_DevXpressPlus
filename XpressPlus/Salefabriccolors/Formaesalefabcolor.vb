Public Class Formaesalefabcolor
    Private Sub Formaesalefabcolor_Load(sender As Object, e As EventArgs) Handles Me.Load
        Tbwgtkg.Select()
    End Sub
    Private Sub Tbkongno_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Tbwgtkg.Focus()
        End If
    End Sub
    Private Sub Tbwgtkg_KeyDown(sender As Object, e As KeyEventArgs) Handles Tbwgtkg.KeyDown
        If e.KeyCode = Keys.Enter Then
            Btok.Focus()
        End If
    End Sub
    Private Sub Btok_Click(sender As Object, e As EventArgs) Handles Btok.Click
        If Validinput() = False Then
            Informmessage("กรุณาตรวจสอบข้อมูลให้ถูกต้อง ครบถ้วน")
            Exit Sub
        End If
        If Validnumber() = False Then
            Informmessage("กรุณาตรวจจำนวนให้ถูกต้อง ครบถ้วน")
            Exit Sub
        End If
        Me.Close()
    End Sub
    Private Sub Btcancel_Click(sender As Object, e As EventArgs) Handles Btcancel.Click
        Tbcancel.Text = "C"
        Me.Close()
    End Sub
    Private Function Validinput() As Boolean
        Dim Valid As Boolean = False
        If Tbwgtkg.Text <> "" Then
            Valid = True
        End If
        Return Valid
    End Function
    Private Function Validnumber() As Boolean
        Dim Valid As Boolean = False
        If CDbl(Tbwgtkg.Text) > 0 Then
            Valid = True
        End If
        Return Valid
    End Function

    Private Sub Btfindyarn_Click(sender As Object, e As EventArgs) Handles Btfindyarn.Click
        Dim frm As New Formsalefablotnolist
        Showdiaformcenter(frm, Me)
        If frm.Tbcancel.Text = "C" Then
            Exit Sub
        End If
        Tbfabno.Text = Trim(frm.Dgvmas.CurrentRow.Cells("Mlotno").Value)
        Normtextbox1.Text = Trim(frm.Dgvmas.CurrentRow.Cells("Kongno").Value)
    End Sub
End Class