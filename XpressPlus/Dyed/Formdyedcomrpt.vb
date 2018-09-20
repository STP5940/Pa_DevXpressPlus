Imports Microsoft.Reporting.WinForms
Public Class Formdyedcomrpt
    Private Sub Formdyedcomrpt_Load(sender As Object, e As EventArgs) Handles Me.Load
        ReportViewer1.LocalReport.ReportEmbeddedResource = "XpressPlus.Rpdyedform.rdlc"
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        ReportViewer1.ZoomMode = ZoomMode.Percent
        ReportViewer1.ZoomPercent = 100
        Dim Par1, Par2, Par3, Par4, Par5, Par6 As ReportParameter
        'Par1 = New ReportParameter("Parfrm", Trim(Tbcustname.Text), True)
        'Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par1})
        'Par2 = New ReportParameter("Parto", Trim(Tbdhname.Text), True)
        'Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par2})
        Par3 = New ReportParameter("Pardate", Trim(Tbdate.Text), True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par3})
        Par4 = New ReportParameter("ParSendTo", Trim(SendTo.Text), True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par4})
        Par5 = New ReportParameter("PickupArea", Trim(PickupArea.Text), True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par5})
        Par6 = New ReportParameter("Note", Trim(Note.Text), True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par6})
        'Par4 = New ReportParameter("Parbill", Trim(Tbdyedno.Text), True)
        'Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par4})
        'Par5 = New ReportParameter("Parremark", Trim(Tbremark.Text), True)
        'Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par5})
        'Par6 = New ReportParameter("Parpickarea", Trim(Tbpickarea.Text), True)
        ' Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par6})
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class