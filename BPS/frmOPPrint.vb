Imports MySql.Data.MySqlClient
Public Class frmOPPrint
    Public optreport As String
    Dim d As MySqlDataAdapter, ds As DataSet
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If optreport = "KP" Then
            If rbReport.Checked Then
                Reports.opt = "KP"
                Reports.ShowDialog()
            Else
                Try
                    If KPReport.txtopt.Text = "0" Then
                        Reports.opt = "Form97"
                        Reports.txtNo.Text = KPReport.GridView1.GetFocusedRowCellValue("CaseNo").ToString
                        Reports.ShowDialog()
                    ElseIf KPReport.txtopt.Text = "1" Then
                        Reports.opt = "Form98"
                        Reports.txtNo.Text = KPReport.GridView1.GetFocusedRowCellValue("CaseNo").ToString
                        Reports.ShowDialog()
                    ElseIf KPReport.txtopt.Text = "2" Then
                        Reports.opt = "Form99"
                        Reports.txtNo.Text = KPReport.GridView1.GetFocusedRowCellValue("CaseNo").ToString
                        Reports.ShowDialog()
                    ElseIf KPReport.txtopt.Text = "3" Then
                        Reports.opt = "Form100"
                        Reports.txtNo.Text = KPReport.GridView1.GetFocusedRowCellValue("CaseNo").ToString
                        Reports.ShowDialog()
                    ElseIf KPReport.txtopt.Text = "5" Then
                        Reports.opt = "Form102"
                        Reports.txtNo.Text = KPReport.GridView1.GetFocusedRowCellValue("CaseNo").ToString
                        Reports.ShowDialog()
                    ElseIf KPReport.txtopt.Text = "4" Then
                        Reports.opt = "Form112"
                        Reports.txtNo.Text = KPReport.GridView1.GetFocusedRowCellValue("CaseNo").ToString
                        Reports.ShowDialog()
                    End If
                Catch ex As Exception
                    MsgBox("No record selected! Please click record to select and try again!")
                End Try

            End If
        Else
            If rbReport.Checked Then
                If TransactionReport.txtopt.Text = "0" Then
                    Reports.opt = "ClearanceList"
                    Reports.ShowDialog()
                ElseIf TransactionReport.Text = "1" Then
                    Reports.opt = "BusinessIssued"
                    Reports.ShowDialog()
                ElseIf TransactionReport.Text = "5" Then
                    Reports.opt = "IndigencyList"
                    Reports.ShowDialog()
                ElseIf TransactionReport.Text = "10" Then
                    Reports.opt = "GoodMoralList"
                    Reports.ShowDialog()
                ElseIf TransactionReport.Text = "EndureList" Then
                    Reports.opt = "EndureList"
                    Reports.ShowDialog()
                ElseIf TransactionReport.Text = "EndureList" Then
                    Reports.opt = "EndureList"
                    Reports.ShowDialog()
                ElseIf TransactionReport.Text = "11" Then
                    Reports.opt = "BlotterList"
                    Reports.ShowDialog()
                ElseIf TransactionReport.Text = "4" Then
                    Reports.opt = "ResidencyList"
                    Reports.ShowDialog()
                ElseIf TransactionReport.Text = "6" Then
                    Reports.opt = "LargeAnimalList"
                    Reports.ShowDialog()
                ElseIf TransactionReport.Text = "3" Then
                    Reports.opt = "TransBelongingList"
                    Reports.ShowDialog()
                ElseIf TransactionReport.Text = "8" Then
                    Reports.opt = "TribalMemberList"
                    Reports.ShowDialog()
                ElseIf TransactionReport.Text = "6" Then
                    Reports.opt = "TransAnimalList"
                    Reports.ShowDialog()
                ElseIf TransactionReport.Text = "9" Then
                    Reports.opt = "NonOpList"
                    Reports.ShowDialog()
                ElseIf TransactionReport.Text = "7" Then
                    Reports.opt = "SoloParentList"
                    Reports.ShowDialog()
                End If
            Else
                Try
                    If TransactionReport.txtopt.Text = "0" Then
                        Reports.opt = "Clearance"
                        Reports.txtNo.Text = TransactionReport.GridView1.GetFocusedRowCellValue("No").ToString
                        Reports.ShowDialog()
                    ElseIf TransactionReport.Text = "1" Then
                        Pop(d, ds, "select ID from busclearance where ClearanceNo = '" & TransactionReport.GridView1.GetFocusedRowCellValue("No").ToString & "' and clearanceType = '" & "CORPORATE" & "'", "busclearance")
                        If ds.Tables("busclearance").Rows.Count > 0 Then
                            Reports.opt = "CORPORATE"
                        Else
                            Reports.opt = "MANAGEMENT"
                        End If
                        Reports.txtNo.Text = TransactionReport.GridView1.GetFocusedRowCellValue("No").ToString
                        Reports.ShowDialog()
                    ElseIf TransactionReport.Text = "5" Then
                        Reports.opt = "Indigency"
                        Reports.txtNo.Text = TransactionReport.GridView1.GetFocusedRowCellValue("No").ToString
                        Reports.ShowDialog()
                    ElseIf TransactionReport.Text = "10" Then
                        Reports.opt = "GoodMoral"
                        Reports.txtNo.Text = TransactionReport.GridView1.GetFocusedRowCellValue("No").ToString
                        Reports.ShowDialog()
                    ElseIf TransactionReport.Text = "EndureList" Then
                        Reports.opt = "EndureList"
                        Reports.ShowDialog()
                    ElseIf TransactionReport.Text = "EndureList" Then
                        Reports.opt = "EndureList"
                        Reports.ShowDialog()
                    ElseIf TransactionReport.Text = "11" Then
                        Reports.opt = "BlotterList"
                        Reports.ShowDialog()
                    ElseIf TransactionReport.Text = "4" Then
                        Reports.opt = "Residency"
                        Reports.txtNo.Text = TransactionReport.GridView1.GetFocusedRowCellValue("No").ToString
                        Reports.ShowDialog()
                    ElseIf TransactionReport.Text = "6" Then
                        Reports.opt = "Animal"
                        Reports.txtNo.Text = TransactionReport.GridView1.GetFocusedRowCellValue("No").ToString
                        Reports.ShowDialog()
                    ElseIf TransactionReport.Text = "3" Then
                        Reports.opt = "Belongings"
                        Reports.txtNo.Text = TransactionReport.GridView1.GetFocusedRowCellValue("No").ToString
                        Reports.ShowDialog()
                    ElseIf TransactionReport.Text = "8" Then
                        Reports.opt = "TribalMember"
                        Reports.txtNo.Text = TransactionReport.GridView1.GetFocusedRowCellValue("No").ToString
                        Reports.ShowDialog()
                    ElseIf TransactionReport.Text = "6" Then
                        Reports.opt = "AnimalTransport"
                        Reports.txtNo.Text = TransactionReport.GridView1.GetFocusedRowCellValue("No").ToString
                        Reports.ShowDialog()
                    ElseIf TransactionReport.Text = "9" Then
                        Reports.opt = "BusNonOp"
                        Reports.txtNo.Text = TransactionReport.GridView1.GetFocusedRowCellValue("No").ToString
                        Reports.ShowDialog()
                    ElseIf TransactionReport.Text = "7" Then
                        Reports.opt = "SoloParent"
                        Reports.txtNo.Text = TransactionReport.GridView1.GetFocusedRowCellValue("No").ToString
                        Reports.ShowDialog()
                    End If
                Catch ex As Exception
                    MsgBox("No record selected! Please click record to select and try again!")
                End Try
            End If
        End If
    End Sub
End Class