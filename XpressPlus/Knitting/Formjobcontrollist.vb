Public Class Formjobcontrollist
    Private Tmaster, Tdetails As DataTable
    Private Sub Formjobcontrollist_Load(sender As Object, e As EventArgs) Handles Me.Load
        Bindingmaster()
    End Sub
    Private Sub Formjobcontrollist_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dgvmas.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
        Dgvmas.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
    End Sub
    Private Sub Btmsearch_Click(sender As Object, e As EventArgs) Handles Btmsearch.Click
        Filtermastergrid()
    End Sub
    Private Sub Tbkeyword_TextChanged(sender As Object, e As EventArgs) Handles Tbkeyword.TextChanged
        If Me.Created Then
            Btmsearch_Click(sender, e)
        End If
        If Tbkeyword.Text = "--version" Or Tbkeyword.Text = "-V" Then
            Informmessage("07/03/2019 15:00")
        End If
    End Sub
    Private Sub Tbkeyword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tbkeyword.KeyPress
        e.Handled = (Asc(e.KeyChar) = 39)
    End Sub
    Private Sub Dgvmas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvmas.CellClick
        If Dgvmas.RowCount = 0 Then
            Exit Sub
        End If
        Dgvmas.CurrentRow.Selected = True
    End Sub
    Private Sub Dgvmas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvmas.CellDoubleClick
        If Dgvmas.RowCount = 0 Then
            Exit Sub
        End If
        Dgvmas.CurrentRow.Selected = True
        Btok_Click(sender, e)
    End Sub
    Private Sub Btcancel_Click(sender As Object, e As EventArgs) Handles Btcancel.Click
        Tbcancel.Text = "C"
        Me.Close()
    End Sub
    Private Sub Btok_Click(sender As Object, e As EventArgs) Handles Btok.Click
        If Dgvmas.RowCount = 0 Then
            Tbcancel.Text = "C"
        End If
        Me.Close()
    End Sub
    Private Sub Bindingmaster()
        Tmaster = New DataTable
        Tmaster = SQLCommand($"/* รายการทั้งหมด Join รายการรับไปแล้ว (Master) */
                                SELECT DISTINCT Jobno, Custname FROM (
                               /* รายการทั้งหมด Join รายการรับไปแล้ว (Detail) */
                                SELECT Comid, A.Custname, Jobno, ROW_NUMBER() OVER (ORDER BY Jobno) AS Ord, Clothid, Clothno, Ftype, Fwidth, Havedoz, SUM(Qtyroll) AS Qtyroll, SUM(Wgtkg) AS Wgtkg, Finwgt, Dozen, 
                                       Dlvroll, SUM(Remainroll) AS Remainroll 
                                FROM (

					                                SELECT jobxp.Comid, Custname, jobxp.Jobno, jobxp.Clothid, jobxp.Clothno, jobxp.Ftype, jobxp.Fwidth, jobxp.Havedoz, jobxp.Qtyroll - IIF(joblog.Knitcomroll IS NULL , 0, joblog.Knitcomroll) AS Qtyroll,
													 jobxp.Wgtkg - IIF(joblog.Wgtkg IS NULL , 0, joblog.Wgtkg) AS Wgtkg, jobxp.Finwgt, jobxp.Dozen, jobxp.Dlvroll, jobxp.Remainroll, 
													  jobxp.Sstatus   FROM (
													
													                          SELECT jobxp.Comid, jobxp.Jobno, jobxp.Clothid, Tclothxp.Clothno, Tclothxp.Ftype, Tclothxp.Fwidth, 
																					   Tclothxp.Havedoz, SUM(jobxp.Qtyroll) AS Qtyroll, 
																					   SUM(jobxp.Wgtkg) AS Wgtkg, jobxp.Finwgt, 
																					   jobxp.Dozen, SUM(jobxp.Dlvroll) AS Dlvroll, SUM(jobxp.Remainroll) AS Remainroll, jobmasxp.Sstatus
																				FROM Tjobcontroldetxp AS jobxp
																				LEFT OUTER JOIN Tclothxp
																					ON jobxp.Clothid = Tclothxp.Clothid AND jobxp.Comid = Tclothxp.Comid
																				LEFT OUTER JOIN Tjobcontrolxp AS jobmasxp
																					ON jobmasxp.Jobno = jobxp.Jobno AND jobmasxp.Comid = jobxp.Comid
																				GROUP BY jobxp.Comid, jobxp.Jobno, jobxp.Clothid, Tclothxp.Clothno, Tclothxp.Ftype, Tclothxp.Fwidth,
																						 Tclothxp.Havedoz, jobxp.Finwgt, jobxp.Dozen, jobxp.Knitcomno, jobmasxp.Sstatus

													) AS jobxp
					                                LEFT OUTER JOIN (

							                                SELECT Tjobcontroldetlogxp.Comid, Tjobcontroldetlogxp.Jobno, Tknittcomdetxp.Clothid, Tknittcomdetxp.Qtyroll,
								                                   SUM(Tjobcontroldetlogxp.Knitcomroll) AS Knitcomroll, SUM(Tknittcomdetxp.Wgtkg) AS Wgtkg,Tjobcontroldetlogxp.Ord
							                                FROM Tjobcontroldetlogxp
							                                LEFT JOIN Tknittcomdetxp
							                                ON Tjobcontroldetlogxp.Knitcomno = Tknittcomdetxp.Knitcomno AND Tjobcontroldetlogxp.KnitOrd = Tknittcomdetxp.Ord AND
							                                Tjobcontroldetlogxp.Comid = Tknittcomdetxp.Comid
							                                GROUP BY Tjobcontroldetlogxp.Comid, Tjobcontroldetlogxp.Jobno, Tjobcontroldetlogxp.Ord, Tknittcomdetxp.Clothid,
															Tknittcomdetxp.Qtyroll
															--Clothid

					                                ) AS joblog
													    ON jobxp.Jobno = joblog.Jobno AND jobxp.Comid = joblog.Comid AND jobxp.Clothid = joblog.Clothid
					                                LEFT OUTER JOIN Tclothxp
													    ON jobxp.Clothid = Tclothxp.Clothid AND jobxp.Comid = Tclothxp.Comid
					                                LEFT OUTER JOIN Tjobcontrolxp AS jobmasxp
														ON jobmasxp.Jobno = jobxp.Jobno AND jobmasxp.Comid = jobxp.Comid
													LEFT OUTER JOIN Tcustomersxp 
						                                ON jobmasxp.Custid = Tcustomersxp.Custid AND jobmasxp.Comid = Tcustomersxp.Comid 
													 WHERE jobxp.Qtyroll > 0 AND jobxp.Comid = '{Gscomid}' AND jobmasxp.Sstatus = '1'

			                      )AS A WHERE Qtyroll > 0 AND Comid = '{Gscomid}' AND Sstatus = '1'
								  GROUP BY Comid, A.Jobno, A.Clothid, A.Clothno, A.Ftype, A.Fwidth, A.Havedoz, A.Finwgt, A.Dozen, A.Dlvroll, A.Custname

			                                  )AS A WHERE Qtyroll > 0 AND Comid = '{Gscomid}'
                                  ORDER BY Jobno")
        Dgvmas.DataSource = Tmaster
        Bindingdetails()
    End Sub
    Private Sub Bindingdetails()
        If Tmaster.Rows.Count - 1 < 0 Then
            Exit Sub
        End If
        Tdetails = New DataTable

        Tdetails = SQLCommand($"/* รายการทั้งหมด Join รายการรับไปแล้ว (Detail) */
                                SELECT Comid, Jobno, ROW_NUMBER() OVER (ORDER BY Jobno) AS Ord, Clothid, Clothno, Ftype, Fwidth, Havedoz, SUM(Qtyroll) AS Qtyroll, SUM(Wgtkg) AS Wgtkg, Finwgt, Dozen, 
                                       Dlvroll, SUM(Remainroll) AS Remainroll 
                                FROM (

					                                SELECT jobxp.Comid, jobxp.Jobno, jobxp.Clothid, jobxp.Clothno, jobxp.Ftype, jobxp.Fwidth, jobxp.Havedoz, jobxp.Qtyroll - IIF(joblog.Knitcomroll IS NULL , 0, joblog.Knitcomroll) AS Qtyroll,
													 jobxp.Wgtkg - IIF(joblog.Wgtkg IS NULL , 0, joblog.Wgtkg) AS Wgtkg, jobxp.Finwgt, jobxp.Dozen, jobxp.Dlvroll, jobxp.Remainroll, 
													  jobxp.Sstatus   FROM (
													
													                          SELECT jobxp.Comid, jobxp.Jobno, jobxp.Clothid, Tclothxp.Clothno, Tclothxp.Ftype, Tclothxp.Fwidth, 
																					   Tclothxp.Havedoz, SUM(jobxp.Qtyroll) AS Qtyroll, 
																					   SUM(jobxp.Wgtkg) AS Wgtkg, jobxp.Finwgt, 
																					   jobxp.Dozen, SUM(jobxp.Dlvroll) AS Dlvroll, SUM(jobxp.Remainroll) AS Remainroll, jobmasxp.Sstatus
																				FROM Tjobcontroldetxp AS jobxp
																				LEFT OUTER JOIN Tclothxp
																					ON jobxp.Clothid = Tclothxp.Clothid AND jobxp.Comid = Tclothxp.Comid
																				LEFT OUTER JOIN Tjobcontrolxp AS jobmasxp
																					ON jobmasxp.Jobno = jobxp.Jobno AND jobmasxp.Comid = jobxp.Comid
																				WHERE jobxp.Jobno = '{Dgvmas.CurrentRow.Cells("Jobno").Value}'
																				GROUP BY jobxp.Comid, jobxp.Jobno, jobxp.Clothid, Tclothxp.Clothno, Tclothxp.Ftype, Tclothxp.Fwidth,
																						 Tclothxp.Havedoz, jobxp.Finwgt, jobxp.Dozen, jobxp.Knitcomno, jobmasxp.Sstatus

													) AS jobxp
					                                LEFT OUTER JOIN (

							                                SELECT Tjobcontroldetlogxp.Comid, Tjobcontroldetlogxp.Jobno, Tknittcomdetxp.Clothid, Tknittcomdetxp.Qtyroll,
								                                   SUM(Tjobcontroldetlogxp.Knitcomroll) AS Knitcomroll, SUM(Tknittcomdetxp.Wgtkg) AS Wgtkg,Tjobcontroldetlogxp.Ord
							                                FROM Tjobcontroldetlogxp
							                                LEFT JOIN Tknittcomdetxp
							                                ON Tjobcontroldetlogxp.Knitcomno = Tknittcomdetxp.Knitcomno AND Tjobcontroldetlogxp.KnitOrd = Tknittcomdetxp.Ord AND
							                                Tjobcontroldetlogxp.Comid = Tknittcomdetxp.Comid
															WHERE Tjobcontroldetlogxp.Jobno = '{Dgvmas.CurrentRow.Cells("Jobno").Value}'
							                                GROUP BY Tjobcontroldetlogxp.Comid, Tjobcontroldetlogxp.Jobno, Tjobcontroldetlogxp.Ord, Tknittcomdetxp.Clothid,
															Tknittcomdetxp.Qtyroll
															--Clothid

					                                ) AS joblog
					                                ON jobxp.Jobno = joblog.Jobno AND jobxp.Comid = joblog.Comid AND jobxp.Clothid = joblog.Clothid
					                                LEFT OUTER JOIN Tclothxp
					                                ON jobxp.Clothid = Tclothxp.Clothid AND jobxp.Comid = Tclothxp.Comid
					                                LEFT OUTER JOIN Tjobcontrolxp AS jobmasxp
					                                ON jobmasxp.Jobno = jobxp.Jobno AND jobmasxp.Comid = jobxp.Comid
													 WHERE jobxp.Qtyroll > 0 AND jobxp.Comid = '{Gscomid}' AND jobmasxp.Sstatus = '1' AND jobxp.Jobno = '{Dgvmas.CurrentRow.Cells("Jobno").Value}'

			                      )AS A WHERE Qtyroll > 0 AND Comid = '{Gscomid}' AND Sstatus = '1' AND Jobno = '{Dgvmas.CurrentRow.Cells("Jobno").Value}'
								  GROUP BY Comid, A.Jobno, A.Clothid, A.Clothno, A.Ftype, A.Fwidth, A.Havedoz, A.Finwgt, A.Dozen, A.Dlvroll")

        Dgvlist.DataSource = Tdetails
    End Sub
    Private Sub Filtermastergrid()
        If Tmaster.Rows.Count < 1 Then
            Exit Sub
        End If
        If Tbkeyword.Text = "" Then
            Tmaster.DefaultView.RowFilter = String.Empty
            Exit Sub
        End If
        Try
            Tmaster.DefaultView.RowFilter = String.Format("Jobno Like '%{0}%' or Custname Like '%{0}%'", Trim(Tbkeyword.Text))
        Catch ex As Exception
            Tbkeyword.Text = ""
        End Try

    End Sub

    Private Sub Dgvmas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvmas.CellClick
        Bindingdetails()
    End Sub

End Class