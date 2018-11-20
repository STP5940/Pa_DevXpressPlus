Imports Microsoft.Reporting.WinForms
Public Class Formsalefabcolrpt
    Private Sub Formsalefabcolrpt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportViewer1.LocalReport.ReportEmbeddedResource = "XpressPlus.Rptsalefabric.rdlc"
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        ReportViewer1.ZoomMode = ZoomMode.Percent
        ReportViewer1.ZoomPercent = 100
        Dim Par1, Par2, Par3, Par4, Par5, Par6, Par7, Par8, Par9, Par10, Par11, Par12, Par13, Kongarray, Lotarray, Tbremark As ReportParameter
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
        'Par8 = New ReportParameter("Psumkg", Trim(Tbsumkg.Text), True)
        'Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par8})
        Par9 = New ReportParameter("Pkgprice", Trim(Tbkgprice.Text), True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par9})
        'Par10 = New ReportParameter("Pdyedcol", Trim(Tbcolor.Text), True)
        'Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par10})
        'Par11 = New ReportParameter("Psumprice", Trim(Tbsumprice.Text), True)
        'Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par11})
        Par12 = New ReportParameter("Kgsum", Trim(Tstbsumkg.Text), True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par12})
        Pricesum.Text = Format(Trim(Tbkgprice.Text) * Trim(Tstbsumkg.Text), "###,###.#0")
        Par13 = New ReportParameter("Pricesum", Trim(Pricesum.Text), True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par13})
        Kongarray = New ReportParameter("Kongarray", Trim(Me.FilterKongarray.Text), True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Kongarray})
        Lotarray = New ReportParameter("Lotarray", Trim(Me.FilterLotarray.Text), True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Lotarray})
        Tbremark = New ReportParameter("Tbremark", Trim(Me.Tbremark.Text), True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Tbremark})


        Dim No1, Kg1, No2, Kg2, No3, Kg3, No4, Kg4 As String
        Dim Datareport As New DataTable
        With Datareport
            .Columns.Add("No1")
            .Columns.Add("Kg1")
            .Columns.Add("No2")
            .Columns.Add("Kg2")
            .Columns.Add("No3")
            .Columns.Add("Kg3")
            .Columns.Add("No4")
            .Columns.Add("Kg4")
        End With
        Datareport.Rows.Clear()
        For i = 0 To Me.DataReport.RowCount - 1
            No1 = Me.DataReport.Rows(i).Cells("No1").Value
            Kg1 = Me.DataReport.Rows(i).Cells("Kg1").Value
            No2 = Me.DataReport.Rows(i).Cells("No2").Value
            Kg2 = Me.DataReport.Rows(i).Cells("Kg2").Value
            No3 = Me.DataReport.Rows(i).Cells("No3").Value
            Kg3 = Me.DataReport.Rows(i).Cells("Kg3").Value
            No4 = Me.DataReport.Rows(i).Cells("No4").Value
            Kg4 = Me.DataReport.Rows(i).Cells("Kg4").Value
            Datareport.Rows.Add(No1, Kg1, No2, Kg2, No3, Kg3, No4, Kg4)
        Next
        Datareport.Rows.RemoveAt(Datareport.Rows.Count - 1)
        Datareport.Rows.RemoveAt(Datareport.Rows.Count - 1)

        Dim Rds As New ReportDataSource()
        Rds.Name = "Datareport"
        Rds.Value = Datareport
        ReportViewer1.LocalReport.DataSources.Add(Rds)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class