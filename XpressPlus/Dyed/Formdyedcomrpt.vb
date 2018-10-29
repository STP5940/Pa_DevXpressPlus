Imports Microsoft.Reporting.WinForms
Public Class Formdyedcomrpt
    Private Sub Formdyedcomrpt_Load(sender As Object, e As EventArgs) Handles Me.Load
        ReportViewer1.LocalReport.ReportEmbeddedResource = "XpressPlus.Rpdyedform.rdlc"
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        ReportViewer1.ZoomMode = ZoomMode.Percent
        ReportViewer1.ZoomPercent = 100
        Dim Par3, Par4, Par5, Par6 As ReportParameter
        Par3 = New ReportParameter("Pardate", Trim(Tbdate.Text), True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par3})
        Par4 = New ReportParameter("ParSendTo", Trim(SendTo.Text), True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par4})
        Par5 = New ReportParameter("PickupArea", PickupArea.Text, True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par5})
        Par6 = New ReportParameter("Note", Note.Text, True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par6})
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Btmclose_Click_1(sender As Object, e As EventArgs) Handles Btmclose.Click
        Me.Close()
    End Sub
End Class