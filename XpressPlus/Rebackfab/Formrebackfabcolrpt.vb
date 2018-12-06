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
                                           "Dtprecdate", "Tbremark", "Tbsumwgt", "CountDgvmas"}
        Dim ParameterTextbox As TextBox() = {Tbdhname, Tbdyedbillno, Tbkgprice, Tbsummoney, Tbdyedcomno,
                                             Dtprecdate, Tbremark, Tbsumwgt, CountDgvmas}

        For i = 0 To ParameterString.Length - 1
            Parameter = New ReportParameter(ParameterString(i), ParameterTextbox(i).Text, True)
            Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Parameter})
        Next

        Dim Tdetails As New DataTable
        Tdetails = SQLCommand($"SELECT fab.Comid,fab.Rbid,fab.Ord,fab.Kongno,fab.Rollno,fab.Clothid, cloth.Clothno, cloth.Ftype, 
							           cloth.Fwidth, fab.Shadeid, shad.Shadedesc, fab.Rollwage,fab.Unitprice,
							           fab.Unit,fab.Rollstat,fab.Updusr,fab.Uptype,fab.Uptime
						            FROM  dbo.Trebackfabdet As fab 
						            INNER JOIN dbo.Tclothxp As cloth 
						            ON fab.Comid = cloth.Comid AND fab.Clothid = cloth.Clothid
						            INNER JOIN dbo.Tshadexp As shad 
							        ON fab.Comid = shad.Comid AND fab.Shadeid = shad.Shadeid WHERE fab.Rbid = '{Tbdyedcomno.Text}'")
        Dgvmas.DataSource = Tdetails

        Dim Kongno, Rollno, Mclothno, Clothtype, Dwidth, Shadedesc, Rollwage As String
        Dim Datarebackfab As New DataTable
        With Datarebackfab
            .Columns.Add("Kongno")
            .Columns.Add("Rollno")
            .Columns.Add("Mclothno")
            .Columns.Add("Clothtype")
            .Columns.Add("Dwidth")
            .Columns.Add("Shadedesc")
            .Columns.Add("Rollwage")
        End With
        Datarebackfab.Rows.Clear()
        For i = 0 To Me.Dgvmas.RowCount - 1
            Kongno = Me.Dgvmas.Rows(i).Cells("Mkong").Value
            Rollno = Me.Dgvmas.Rows(i).Cells("Rollno").Value
            Mclothno = Me.Dgvmas.Rows(i).Cells("Mclothno").Value
            Clothtype = Me.Dgvmas.Rows(i).Cells("Clothtype").Value
            Dwidth = Me.Dgvmas.Rows(i).Cells("Dwidth").Value
            Shadedesc = Me.Dgvmas.Rows(i).Cells("Shadedesc").Value
            Rollwage = Format(Me.Dgvmas.Rows(i).Cells("Rollwage").Value, "###,###.#0")
            Datarebackfab.Rows.Add(Kongno, Rollno, Mclothno, Clothtype, Dwidth, Shadedesc, Rollwage)
        Next

        Dim Rds As New ReportDataSource()
        Rds.Name = "Datarebackfab"
        Rds.Value = Datarebackfab
        ReportViewer1.LocalReport.DataSources.Add(Rds)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class