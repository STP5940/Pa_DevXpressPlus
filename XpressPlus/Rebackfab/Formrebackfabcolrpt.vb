Imports Microsoft.Reporting.WinForms
Public Class Formrebackfabcolrpt
    Dim TextCash As ReportParameter
    Public Sub VersionReport()
        Informmessage("Report: 30/11/2018 15:00")
    End Sub
    Private Sub Formrebackfabcolrpt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ReportViewer1.LocalReport.ReportEmbeddedResource = "XpressPlus.Rptrebackfabcolr.rdlc"
        'ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        'ReportViewer1.ZoomMode = ZoomMode.Percent
        'ReportViewer1.ZoomPercent = 100
        'TextCash = New ReportParameter("TextCash", Trim(Tbcustname.Text), True)
        'Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {TextCash})
        'ReportViewer1.RefreshReport()
    End Sub
End Class