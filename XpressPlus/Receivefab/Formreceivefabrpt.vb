﻿Imports Microsoft.Reporting.WinForms

Public Class Formreceivefabrpt
    Public Sub VersionReport()
        Informmessage("Report: 26/11/2018 15:00")
    End Sub
    Private Sub Formknitingfrmrpt_Load(sender As Object, e As EventArgs) Handles Me.Load
        ReportViewer1.LocalReport.ReportEmbeddedResource = "XpressPlus.Rptreceivefabform.rdlc"
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        ReportViewer1.ZoomMode = ZoomMode.Percent
        ReportViewer1.ZoomPercent = 100
        Dim Par2, Par3, Par4, Par5, Par6, Par7, Par8, Par9, Par10 As ReportParameter
        Par2 = New ReportParameter("Tbdhid", Trim(Tbdhid.Text), True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par2})
        Par3 = New ReportParameter("Tbdhname", Trim(Tbdhname.Text), True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par3})
        Par4 = New ReportParameter("Tbdyedbillno", Trim(Tbdyedbillno.Text), True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par4})
        Par5 = New ReportParameter("Tbknittno", Trim(Tbknittno.Text), True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par5})
        Par6 = New ReportParameter("Tbcolorno", Trim(Tbcolorno.Text), True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par6})
        Par7 = New ReportParameter("Tbrefablotno", Trim(Tbrefablotno.Text), True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par7})
        Par8 = New ReportParameter("Tbdyedcomno", Trim(Tbdyedcomno.Text), True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par8})
        Par9 = New ReportParameter("Tbremark", Tbremark.Text, True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par9})
        Par10 = New ReportParameter("Tbdate", Tbdate.Text, True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par10})


        Dim rollid, Mclothno, Clothtype, Dwidth, Mkong, Rollwage As String
        Dim Datareportfab As New DataTable
        With Datareportfab
            .Columns.Add("rollid")
            .Columns.Add("Mclothno")
            .Columns.Add("Clothtype")
            .Columns.Add("Dwidth")
            .Columns.Add("Mkong")
            .Columns.Add("Rollwage")
        End With
        Datareportfab.Rows.Clear()
        For i = 0 To Me.Dgvmas.RowCount - 1
            rollid = Me.Dgvmas.Rows(i).Cells("rollid").Value
            Mclothno = Me.Dgvmas.Rows(i).Cells("Mclothno").Value
            Clothtype = Me.Dgvmas.Rows(i).Cells("Clothtype").Value
            Dwidth = Me.Dgvmas.Rows(i).Cells("Dwidth").Value
            Mkong = Me.Dgvmas.Rows(i).Cells("Mkong").Value
            Rollwage = Me.Dgvmas.Rows(i).Cells("Rollwage").Value
            Datareportfab.Rows.Add(rollid, Mclothno, Clothtype, Dwidth, Mkong, Rollwage)
        Next

        Dim Rds As New ReportDataSource()
        Rds.Name = "Datareportfab"
        Rds.Value = Datareportfab
        ReportViewer1.LocalReport.DataSources.Add(Rds)

        Dim Cclothno, Cclothtype, CDwidth, CShadedesc, Count, CRollwage, CDozen As String
        Dim DataCountreport As New DataTable
        With DataCountreport
            .Columns.Add("Cclothno")
            .Columns.Add("Cclothtype")
            .Columns.Add("CDwidth") 'CShadedesc
            .Columns.Add("CShadedesc")
            .Columns.Add("Count")
            .Columns.Add("CRollwage")
            .Columns.Add("CDozen")
        End With
        DataCountreport.Rows.Clear()
        For i = 0 To Me.Countfabric.RowCount - 1
            Cclothno = Me.Countfabric.Rows(i).Cells("Cclothno").Value
            Cclothtype = Me.Countfabric.Rows(i).Cells("Cclothtype").Value
            CDwidth = Me.Countfabric.Rows(i).Cells("CDwidth").Value
            CShadedesc = InputGrid(Me.Countfabric.Rows(i).Cells("CShadedesc").Value)
            Count = Me.Countfabric.Rows(i).Cells("Count").Value
            CRollwage = Format(Me.Countfabric.Rows(i).Cells("CRollwage").Value, "###,###.#0")
            CDozen = Format(CDbl(Me.Countfabric.Rows(i).Cells("CDozen").Value), "###,##0.#0")
            DataCountreport.Rows.Add(Cclothno, Cclothtype, CDwidth, CShadedesc, Count, CRollwage, CDozen)
        Next

        Dim CRds As New ReportDataSource()
        CRds.Name = "DataCountreport"
        CRds.Value = DataCountreport
        ReportViewer1.LocalReport.DataSources.Add(CRds)

        Me.ReportViewer1.RefreshReport()

        'For i = 0 To Me.Datareportfab.RowCount - 1
        '    Kg4 = Me.Dgvmas.Rows(i).Cells("rollid").Value
        '    Dgvmas.Rows.Add()
        'Next


    End Sub
    Private Function InputGrid(Data As Object)
        Dim Redata As String = IIf(IsDBNull(Data), "", Data)
        Return Trim(Redata)
    End Function
    Private Sub Btmclose_Click(sender As Object, e As EventArgs) Handles Btmclose.Click
        Me.Close()
    End Sub
End Class