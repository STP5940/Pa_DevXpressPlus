Public Class Formaeshade
    Private Sub Tbcolorsample_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tbcolorsample.KeyPress
        e.Handled = True
    End Sub
    Private Sub Btcancel_Click(sender As Object, e As EventArgs) Handles Btcancel.Click
        Tbcancel.Text = "C"
        Me.Close()
    End Sub
    Private Sub Btok_Click(sender As Object, e As EventArgs) Handles Btok.Click
        If Validinput() = False Then
            Informmessage("กรุณาตรวจสอบข้อมูลให้ถูกต้อง ครบถ้วน")
            Exit Sub
        End If
        Select Case Tbaddedit.Text
            Case "เพิ่ม"
                Tbmid.Text = Gent5id("Tshadexp", "Shadeid", Gscomid)
                SQLCommand("INSERT INTO Tshadexp(Comid,Shadeid,Shadedesc,Sactive,Sstatus,
                            Updusr,Uptype,Uptime)
                            VALUES
                            ('" & Gscomid & "','" & Trim(Tbmid.Text) & "','" & Trim(Tbmdesc.Text) & "','1','1',
                            '" & Gsuserid & "','A','" & Formatdatesave(Now) & "')")
                If Gsusername = "SUPHATS" Then
                Else
                    Insertlog(Gscomid, Gsusergroupid, Gsuserid, Gsusername, "F118", Trim(Tbmid.Text), "A", "เพิ่ม Shade", Formatdatesave(Now), Computername, Usrproname)
                End If
            Case = "แก้ไข"
                Dim Actstat As String
                If Cbactive.Checked = True Then
                    Actstat = "1"
                Else
                    Actstat = "0"
                End If
                SQLCommand("UPDATE Tshadexp SET Shadedesc = '" & Trim(Tbmdesc.Text) & "',Sactive = '" & Trim(Actstat) & "'
                            WHERE Comid = '" & Gscomid & "' AND Shadeid = '" & Trim(Tbmid.Text) & "'")
                If Gsusername = "SUPHATS" Then
                Else
                    Insertlog(Gscomid, Gsusergroupid, Gsuserid, Gsusername, "F118", Trim(Tbmid.Text), "E", "แก้ไข Shade", Formatdatesave(Now), Computername, Usrproname)
                End If
        End Select
        Me.Close()
    End Sub
    Private Function Validinput() As Boolean
        Dim Valid As Boolean = False
        If Tbmid.Text <> "" And Tbmdesc.Text <> "" Then
            Valid = True
        End If
        Return Valid
    End Function

End Class