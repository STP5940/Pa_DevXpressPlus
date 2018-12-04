Imports Microsoft.Reporting.WinForms
Public Class Formrebackfabcolrpt
    Public Sub VersionReport()
        Informmessage("Report: 30/11/2018 15:00")
    End Sub
    Private Sub Formknitingfrmrpt_Load(sender As Object, e As EventArgs) Handles Me.Load
        ReportViewer1.LocalReport.ReportEmbeddedResource = "XpressPlus.Rptrebackfabcolr.rdlc"
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        ReportViewer1.ZoomMode = ZoomMode.Percent
        ReportViewer1.ZoomPercent = 100

        Dim Parameter As ReportParameter
        Dim ParameterString() As String = {"Tbdhname", "Tbdyedbillno", "Tbkgprice", "Tbsummoney", "Tbdyedcomno",
                                           "Dtprecdate", "Tbremark", "Tbsumwgt"}
        Dim ParameterTextbox As TextBox() = {Tbdhname, Tbdyedbillno, Tbkgprice, Tbsummoney, Tbdyedcomno,
                                             Dtprecdate, Tbremark, Tbsumwgt}

        For i = 0 To ParameterString.Length - 1
            Parameter = New ReportParameter(ParameterString(i), ParameterTextbox(i).Text, True)
            Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Parameter})
        Next

        Dim Dgvmas As New DataTable
        'Dgvmas = SQLCommand("")
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class