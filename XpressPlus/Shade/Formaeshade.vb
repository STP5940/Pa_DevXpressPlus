Public Class Formaeshade

    Private colors As DataTable
    Private Sub Tbcolorsample_KeyPress(sender As Object, e As KeyPressEventArgs)
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
        If Trim(Normtextbox2.Text) = "" OrElse Trim(Normtextbox3.Text) = "" OrElse Trim(Normtextbox4.Text) = "" Then
            Informmessage("กรุณาเลือกสีที่ตัวอย่าง")
            Exit Sub
        End If

        Select Case Tbaddedit.Text
            Case "เพิ่ม"
                Tbmid.Text = Gent5id("Tshadexp", "Shadeid", Gscomid)
                SQLCommand("INSERT INTO Tshadexp(Comid,Shadeid,Shadedesc,Rcolor,Gcolor,Bcolor,Sactive,Sstatus,
                            Updusr,Uptype,Uptime)
                            VALUES
                            ('" & Gscomid & "','" & Trim(Tbmid.Text) & "','" & Trim(Tbmdesc.Text) & "','" & Trim(Normtextbox2.Text) & "','" & Trim(Normtextbox3.Text) & "','" & Trim(Normtextbox4.Text) & "','1','1',
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
                SQLCommand("UPDATE Tshadexp SET Shadedesc = '" & Trim(Tbmdesc.Text) & "',Sactive = '" & Trim(Actstat) & "',Rcolor = '" & Trim(Normtextbox2.Text) & "',Gcolor = '" & Trim(Normtextbox3.Text) & "',Bcolor = '" & Trim(Normtextbox4.Text) & "'
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

    Private Sub Tbfinddhid_Click(sender As Object, e As EventArgs) Handles Tbfinddhid.Click
        Dim ColorDialog As DialogResult
        ColorDialog = ColorDialog1.ShowDialog()
        If ColorDialog = Windows.Forms.DialogResult.OK Then
            Normtextbox2.Text = ColorDialog1.Color.R
            Normtextbox3.Text = ColorDialog1.Color.G
            Normtextbox4.Text = ColorDialog1.Color.B
            Tbcolorsample.BackColor = Color.FromArgb(Normtextbox2.Text, Normtextbox3.Text, Normtextbox4.Text)
        End If
    End Sub

    Private Sub Formaeshade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If Tbaddedit.Text = "แก้ไข" Then
                colors = SQLCommand($"SELECT Rcolor,Gcolor,Bcolor FROM Tshadexp WHERE Shadeid = '{Tbmid.Text}' ")
                Normtextbox2.Text = colors(0)("Rcolor")
                Normtextbox3.Text = colors(0)("Gcolor")
                Normtextbox4.Text = colors(0)("Bcolor")
                Tbcolorsample.BackColor = Color.FromArgb(Normtextbox2.Text, Normtextbox3.Text, Normtextbox4.Text)
            End If
        Catch ex As Exception
            Tbcolorsample.BackColor = Color.FromArgb(255, 255, 255)
        End Try
    End Sub
End Class