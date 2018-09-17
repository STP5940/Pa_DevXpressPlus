Imports Microsoft.Reporting.WinForms
Public Class Formsalefabcolrpt
    Private Sub Formsalefabcolrpt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportViewer1.LocalReport.ReportEmbeddedResource = "XpressPlus.Rptsalefabric.rdlc"
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        ReportViewer1.ZoomMode = ZoomMode.Percent
        ReportViewer1.ZoomPercent = 100
        Dim Par1, Par2, Par3, Par4, Par5, Par6, Par7, Par8, Par9, Par10, Par11 As ReportParameter
        Par1 = New ReportParameter("Pcustname", Trim(Tbcustname.Text), True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par1})
        Par2 = New ReportParameter("Pdlvno", Trim(Tbdlvno.Text), True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par2})
        Par3 = New ReportParameter("Pcustship", Trim(Tbcustaddr.Text), True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par3})
        Par4 = New ReportParameter("Pdate", Trim(Tbdate.Text), True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par4})
        Par5 = New ReportParameter("Pfab", Trim(Tbclothno.Text), True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par5})
        Par6 = New ReportParameter("Pwidth", Trim(Tbwidth.Text), True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par6})
        Par7 = New ReportParameter("Pcolor", Trim(Tbshade.Text), True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par7})
        Par8 = New ReportParameter("Psumkg", Trim(Tbsumkg.Text), True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par8})
        Par9 = New ReportParameter("Pkgprice", Trim(Tbkgprice.Text), True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par9})
        Par10 = New ReportParameter("Pdyedcol", Trim(Tbcolor.Text), True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par10})
        Par11 = New ReportParameter("Psumprice", Trim(Tbsumprice.Text), True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par11})
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class