Imports Microsoft.Reporting.WinForms
Public Class Formsalefabcolrpt
    Private Tmaster, Tdetails As DataTable
    Public Sub VersionReport()
        Informmessage("Report: 27/11/2018 15:00")
    End Sub
    Private Sub Formsalefabcolrpt_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        'Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub Formsaleprint_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim Ord = 0

        Tmaster = New DataTable
        Tmaster = SQLCommand($"SELECT '' AS Ord, dbo.Tsalefabcoldetxp.Lotno, dbo.Tsalefabcoldetxp.Kongno, dbo.Tsalefabcoldetxp.Shadeid, 
											  dbo.Tsalefabcoldetxp.Clothid, dbo.Tclothxp.Clothno, dbo.Tclothxp.Ftype, 
											  dbo.Tclothxp.Fwidth, dbo.Tsalefabcoldetxp.Comid, COUNT(*) AS Counts, dbo.Tshadexp.Shadedesc
								FROM dbo.Tsalefabcoldetxp 
								INNER JOIN dbo.Tclothxp 
								ON dbo.Tsalefabcoldetxp.Comid = dbo.Tclothxp.Comid AND dbo.Tsalefabcoldetxp.Clothid = dbo.Tclothxp.Clothid 
								INNER JOIN dbo.Tshadexp 
								ON dbo.Tsalefabcoldetxp.Comid = dbo.Tshadexp.Comid AND dbo.Tsalefabcoldetxp.Shadeid = dbo.Tshadexp.Shadeid
								WHERE (dbo.Tsalefabcoldetxp.Comid = '{Gscomid}') AND (dbo.Tsalefabcoldetxp.Dlvno = '{Tbdlvno.Text}')
								GROUP BY dbo.Tsalefabcoldetxp.Clothid, dbo.Tsalefabcoldetxp.Kongno, dbo.Tsalefabcoldetxp.Lotno, dbo.Tsalefabcoldetxp.Shadeid, 
										 dbo.Tsalefabcoldetxp.Comid, dbo.Tclothxp.Clothno, dbo.Tclothxp.Ftype, dbo.Tclothxp.Fwidth, dbo.Tshadexp.Shadedesc")
        DataGridView2.DataSource = Tmaster

        If Tmaster.Rows.Count > 0 Then
            Dim Toprow As Integer

            For I = 0 To Tmaster.Rows.Count - 1
                Ord = Ord + 1

                Tdetails = New DataTable
                Tdetails = SQLCommand($"SELECT Tsalefabcoldetxp.Wgtkg FROM Tsalefabcoldetxp 
                                              INNER JOIN Tclothxp 
	                                          ON Tsalefabcoldetxp.Comid = Tclothxp.Comid 
                                                 AND Tsalefabcoldetxp.Clothid = Tclothxp.Clothid
	                                   WHERE Tsalefabcoldetxp.Comid = '{Gscomid}' 
                                                 AND Dlvno = '{Tbdlvno.Text}' 
                                                 AND Tsalefabcoldetxp.Lotno = '{Tmaster.Rows(I)("Lotno")}' 
                                                 AND Tsalefabcoldetxp.Kongno = '{Tmaster.Rows(I)("Kongno")}' 
                                                 AND Tsalefabcoldetxp.Clothid = '{Tmaster.Rows(I)("Clothid")}' 
                                                 AND Tsalefabcoldetxp.Shadeid = '{Tmaster.Rows(I)("Shadeid")}' 
                                                 AND Tsalefabcoldetxp.Comid = '{Gscomid}'")

                Dim Sumvol As Double = 0
                For J = 0 To Tdetails.Rows.Count - 1
                    Sumvol = Sumvol + Tdetails.Rows(J)("Wgtkg")
                Next

                For Toprow = 0 To Tdetails.Rows.Count - 1

                    Dim K = Toprow Mod 7

                    Select Case K
                        Case 0
                            DataGridView1.Rows.Add()
                            DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("Column1").Value = Ord
                            DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("Lotno").Value = Tmaster.Rows(I)("Lotno")
                            DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("Kongno").Value = Tmaster.Rows(I)("Kongno")
                            DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("Sumvol").Value = Sumvol
                            DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("Shadedesc").Value = Tmaster.Rows(I)("Shadedesc")
                            DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("Column2").Value = Tmaster.Rows(I)("Clothid")
                            DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("Column3").Value = Tmaster.Rows(I)("Clothno")
                            DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("Column4").Value = Tmaster.Rows(I)("Ftype")
                            DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("Column5").Value = Tmaster.Rows(I)("Fwidth")
                            DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("Column6").Value = Tbkgprice.Text
                            DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("Column7").Value = Tmaster.Rows(I)("Counts")
                            DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("Column8").Value = Tdetails.Rows(Toprow)("Wgtkg")
                        Case 1
                            DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("Column9").Value = Tdetails.Rows(Toprow)("Wgtkg")
                            'DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("Column7").Value += 1
                        Case 2
                            DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("Column10").Value = Tdetails.Rows(Toprow)("Wgtkg")
                            'DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("Column7").Value += 1
                        Case 3
                            DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("Column11").Value = Tdetails.Rows(Toprow)("Wgtkg")
                            'DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("Column7").Value += 1
                        Case 4
                            DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("Column12").Value = Tdetails.Rows(Toprow)("Wgtkg")
                            'DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("Column7").Value += 1
                        Case 5
                            DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("Column13").Value = Tdetails.Rows(Toprow)("Wgtkg")
                            'DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("Column7").Value += 1
                        Case 6
                            DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("Column14").Value = Tdetails.Rows(Toprow)("Wgtkg")
                            'DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("Column7").Value += 1
                            ''Case 7
                            ''    DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("Column15").Value = Tdetails.Rows(Toprow)("Wgtkg")
                            ''    'DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("Column7").Value += 1
                            ''Case 8
                            ''    DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("Column16").Value = Tdetails.Rows(Toprow)("Wgtkg")
                            ''    'DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("Column7").Value += 1
                            ''Case 9
                            ''    DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("Column17").Value = Tdetails.Rows(Toprow)("Wgtkg")
                            ''    'DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("Column7").Value += 1
                    End Select

                Next
            Next
        End If

        Createrptdt()

    End Sub

    Private Sub Createrptdt()
        Dim C1, Lotno, Kongno, Sumvol, Shadedesc, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17 As String
        Dim Dtrpt As New DataTable
        With Dtrpt
            .Columns.Add("Column1")
            .Columns.Add("Lotno")
            .Columns.Add("Kongno")
            .Columns.Add("Sumvol")
            .Columns.Add("Shadedesc")
            .Columns.Add("Column2")
            .Columns.Add("Column3")
            .Columns.Add("Column4")
            .Columns.Add("Column5")
            .Columns.Add("Column6")
            .Columns.Add("Column7")
            .Columns.Add("Column8")
            .Columns.Add("Column9")
            .Columns.Add("Column10")
            .Columns.Add("Column11")
            .Columns.Add("Column12")
            .Columns.Add("Column13")
            .Columns.Add("Column14")
            ''.Columns.Add("Column15")
            ''.Columns.Add("Column16")
            ''.Columns.Add("Column17")
        End With
        Dtrpt.Rows.Clear()
        For I = 0 To DataGridView1.RowCount - 1
            C1 = DataGridView1.Rows(I).Cells("Column1").Value
            Lotno = DataGridView1.Rows(I).Cells("Lotno").Value
            Kongno = DataGridView1.Rows(I).Cells("Kongno").Value
            Sumvol = DataGridView1.Rows(I).Cells("Sumvol").Value
            Shadedesc = DataGridView1.Rows(I).Cells("Shadedesc").Value
            C2 = DataGridView1.Rows(I).Cells("Column2").Value
            C3 = DataGridView1.Rows(I).Cells("Column3").Value
            C4 = DataGridView1.Rows(I).Cells("Column4").Value
            C5 = DataGridView1.Rows(I).Cells("Column5").Value
            C6 = DataGridView1.Rows(I).Cells("Column6").Value
            C7 = DataGridView1.Rows(I).Cells("Column7").Value
            C8 = DataGridView1.Rows(I).Cells("Column8").Value
            C9 = DataGridView1.Rows(I).Cells("Column9").Value
            C10 = DataGridView1.Rows(I).Cells("Column10").Value
            C11 = DataGridView1.Rows(I).Cells("Column11").Value
            C12 = DataGridView1.Rows(I).Cells("Column12").Value
            C13 = DataGridView1.Rows(I).Cells("Column13").Value
            C14 = DataGridView1.Rows(I).Cells("Column14").Value
            ''C15 = DataGridView1.Rows(I).Cells("Column15").Value
            ''C16 = DataGridView1.Rows(I).Cells("Column16").Value
            ''C17 = DataGridView1.Rows(I).Cells("Column17").Value
            Dtrpt.Rows.Add(C1, Lotno, Kongno, Sumvol, Shadedesc, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14)
        Next
        'If Gsexpau = False Then
        '    ReportViewer1.ShowExportButton = False
        'End If
        'If Gspriau = False Then
        '    ReportViewer1.ShowPrintButton = False
        'End If
        Dim Rds As New ReportDataSource()
        Rds.Name = "DatareportSale"
        Rds.Value = Dtrpt
        ReportViewer1.Reset()
        ReportViewer1.LocalReport.DataSources.Add(Rds)

        ReportViewer1.LocalReport.ReportEmbeddedResource = "XpressPlus.Rptsalefabric.rdlc"
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        ReportViewer1.ZoomMode = ZoomMode.Percent
        ReportViewer1.ZoomPercent = 100
        Dim Par1, Par2, Par3, Par4, Par5, Par6, Par7, Par8, Par9, Par10, Par11, Par12, Par13, Par14, Tbremark As ReportParameter
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
        Par11 = New ReportParameter("Sumnetkg", Trim(Tbsumnetkg.Text), True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par11})
        Par12 = New ReportParameter("Kgsum", Trim(Tstbsumkg.Text), True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par12})
        Par13 = New ReportParameter("Pricesum", Trim(Tbsumprice.Text), True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par13})

        Par14 = New ReportParameter("Bagwgt", Trim(TbBagwgt.Text), True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par14})

        Tbremark = New ReportParameter("Tbremark", Trim(Me.Tbremark.Text), True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Tbremark})
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class