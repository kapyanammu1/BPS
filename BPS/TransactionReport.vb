Imports MySql.Data.MySqlClient
Public Class TransactionReport
    Dim d As MySqlDataAdapter, ds As DataSet
    Private Sub reload(ByVal WhereVal As String)
        Pop(d, ds, "select c.ID,c.ClearanceNo,r.Fullname,c.Purpose,c.CDate from brgyClearance c LEFT JOIN Resident r ON r.ID=c.ResidentID " & WhereVal & "", "brgyClearance c", GridControl1)
        GridView1.Columns(0).Visible = False
        GridView1.Columns(2).Width = 382
    End Sub
    Private Sub cbDetail_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAll.CheckedChanged
        reloadTrans()
    End Sub
    Function reloadTrans()
        GridView1.Columns.Clear()
        If cbAll.Checked Then
            If txtopt.Text = "0" Then
                Pop(d, ds, "select c.ID,c.PrintDate,c.ClearanceNo No,c.Type,r.Fullname,c.ORno,c.ORAmount,c.CTC,c.CTCAmount from brgyClearance c LEFT JOIN Resident r ON r.ID=c.ResidentID", "brgyClearance c", GridControl1)
                GridView1.Columns(0).Visible = False
                GridView1.Columns(2).Width = 382
            ElseIf txtopt.Text = "4" Then
                Pop(d, ds, "select bc.ID,bc.PrintDate,bc.ResidencyNo No,b.Fullname,bc.ORno,bc.ORAmount,bc.CTC,bc.CTCAmount from Residency bc LEFT JOIN Resident b ON b.ID=bc.ResidentID", "Residency bc", GridControl1)
                GridView1.Columns(0).Visible = False
                GridView1.Columns(3).Width = 282
            ElseIf txtopt.Text = "6" Then
                Pop(d, ds, "select bc.ID,bc.PrintDate,bc.No,b.Fullname,bc.ORno,bc.ORAmount,bc.CTC,bc.CTCAmount from animal bc LEFT JOIN Resident b ON b.ID=bc.ResidentID", "Animal bc", GridControl1)
                GridView1.Columns(0).Visible = False
                GridView1.Columns(3).Width = 282
            ElseIf txtopt.Text = "3" Then
                Pop(d, ds, "select bc.ID,bc.PrintDate,bc.No,b.Fullname,bc.ORno,bc.ORAmount,bc.CTC,bc.CTCAmount from belongings bc LEFT JOIN Resident b ON b.ID=bc.ResidentID", "belongings bc", GridControl1)
                GridView1.Columns(0).Visible = False
                GridView1.Columns(3).Width = 282
            ElseIf txtopt.Text = "8" Then
                Pop(d, ds, "select bc.ID,bc.PrintDate,bc.No,bc.Description,b.Fullname,bc.ORno,bc.ORAmount,bc.CTC,bc.CTCAmount from Belongings bc LEFT JOIN Resident b ON b.ID=bc.ResidentID", "TribalMember bc", GridControl1)
                GridView1.Columns(0).Visible = False
                GridView1.Columns(3).Width = 282
            ElseIf txtopt.Text = "2" Then
                Pop(d, ds, "select bc.ID,bc.PrintDate,bc.No,a.Brand,a.class,b.Fullname,bc.ORno,bc.ORAmount,bc.CTC,bc.CTCAmount from animalTransport bc LEFT JOIN Resident b ON b.ID=bc.ResidentID LEFT JOIN animal a ON a.ID=bc.AnimalID", "animaltransport bc", GridControl1)
                GridView1.Columns(0).Visible = False
                GridView1.Columns(3).Width = 282
            ElseIf txtopt.Text = "9" Then
                Pop(d, ds, "select bc.ID,bc.PrintDate,bc.No,b.BusinessName,bc.ORno,bc.ORAmount,bc.CTC,bc.CTCAmount from NonOperation bc LEFT JOIN Business b ON b.ID=bc.BusinessID", "NonOperation bc", GridControl1)
                GridView1.Columns(0).Visible = False
                GridView1.Columns(3).Width = 282
            ElseIf txtopt.Text = "7" Then
                Pop(d, ds, "select bc.ID,bc.PrintDate,bc.SoloParentNo No,b.Fullname,bc.ORno,bc.ORAmount,bc.CTC,bc.CTCAmount from SoloParent bc LEFT JOIN Resident b ON b.ID=bc.ResidentID", "SoloParent bc", GridControl1)
                GridView1.Columns(0).Visible = False
                GridView1.Columns(3).Width = 282
            ElseIf txtopt.Text = "1" Then
                Pop(d, ds, "select bc.ID,bc.PrintDate,bc.ClearanceNo No,bc.ORNo,b.BusinessName,bc.ORno,bc.ORAmount,bc.CTC,bc.CTCAmount from busClearance bc LEFT JOIN Business b ON b.ID=bc.BusinessID", "busClearance bc", GridControl1)
                GridView1.Columns(0).Visible = False
                GridView1.Columns(3).Width = 282
            ElseIf txtopt.Text = "5" Then
                Pop(d, ds, "select i.ID,i.PrintDate,i.IndigencyNo No,r.Fullname,i.ORno,i.ORAmount,i.CTC,i.CTCAmount from Indigency i LEFT JOIN Resident r ON r.ID=i.ResidentID", "Indigency i", GridControl1)
                GridView1.Columns(0).Visible = False
                GridView1.Columns(2).Width = 282
            ElseIf txtopt.Text = "10" Then
                Pop(d, ds, "select g.ID,g.PrintDate,g.GoodMoralNo No,r.Fullname,g.ORno,g.ORAmount,g.CTC,g.CTCAmount from GoodMoral g LEFT JOIN Resident r ON r.ID=g.ResidentID", "GoodMoral g", GridControl1)
                GridView1.Columns(0).Visible = False
                GridView1.Columns(2).Width = 282
            ElseIf txtopt.Text = "GoodMoralList" Then
                Pop(d, ds, "select g.ID,g.PrintDate,g.GoodMoralNo No,r.Fullname,g.ORno,g.ORAmount,g.CTC,g.CTCAmount from GoodMoral g LEFT JOIN Resident r ON r.ID=g.ResidentID", "GoodMoral g", GridControl1)
                GridView1.Columns(0).Visible = False
                GridView1.Columns(2).Width = 282
            ElseIf txtopt.Text = "EndureList" Then
                Pop(d, ds, "select e.ID,e.EndureNo No,r.Fullname,e.Purpose,e.CDate from Endure e LEFT JOIN Resident r ON r.ID=e.ResidentID", "Endure e", GridControl1)
                GridView1.Columns(0).Visible = False
                GridView1.Columns(2).Width = 282
            ElseIf txtopt.Text = "11" Then
                Pop(d, ds, "select b.ID,b.ComplianantID,b.PersonToComplainID,b.BlotterNo,r.Fullname Complainant, r1.FullName PersonToComplain,b.StatementOfComp, b.LocationOfIncidence, b.BDate, b.`Status`, b.ActionTaken from blotter b LEFT JOIN Resident r ON r.ID=b.ComplianantID LEFT JOIN Resident r1 ON r1.ID=b.PersontoComplainID where b.archive = 0 ORDER by r.fullname", "blotter b", GridControl1)
                GridView1.Columns(0).Visible = False
                GridView1.Columns(1).Visible = False
                GridView1.Columns(2).Visible = False
                GridView1.Columns(4).Width = 150
                GridView1.Columns(5).Width = 150
            End If
            txtDate.Enabled = False
            'Button1.Enabled = False
        Else
            If txtopt.Text = "0" Then
                Pop(d, ds, "select c.ID,c.PrintDate,c.ClearanceNo No,c.Type,r.Fullname,c.ORno,c.ORAmount,c.CTC,c.CTCAmount from brgyClearance c LEFT JOIN Resident r ON r.ID=c.ResidentID where c.PrintDate like '%" & Trim(txtDate.Text) & "%'", "brgyClearance c", GridControl1)
                GridView1.Columns(0).Visible = False
                GridView1.Columns(2).Width = 282
            ElseIf txtopt.Text = "4" Then
                Pop(d, ds, "select bc.ID,bc.PrintDate,bc.ResidencyNo No,b.Fullname,bc.ORno,bc.ORAmount,bc.CTC,bc.CTCAmount from Residency bc LEFT JOIN Resident b ON b.ID=bc.ResidentID where bc.PrintDate like '%" & Trim(txtDate.Text) & "%'", "Residency bc", GridControl1)
                GridView1.Columns(0).Visible = False
                GridView1.Columns(2).Width = 282
            ElseIf txtopt.Text = "6" Then
                Pop(d, ds, "select bc.ID,bc.PrintDate,bc.No,b.Fullname,bc.ORno,bc.ORAmount,bc.CTC,bc.CTCAmount from animal bc LEFT JOIN Resident b ON b.ID=bc.ResidentID where bc.PrintDate like '%" & Trim(txtDate.Text) & "%'", "Animal bc", GridControl1)
                GridView1.Columns(0).Visible = False
                GridView1.Columns(2).Width = 282
            ElseIf txtopt.Text = "3" Then
                Pop(d, ds, "select bc.ID,bc.PrintDate,bc.No,b.Fullname,bc.ORno,bc.ORAmount,bc.CTC,bc.CTCAmount from belongings bc LEFT JOIN Resident b ON b.ID=bc.ResidentID where bc.PrintDate like '%" & Trim(txtDate.Text) & "%'", "belongings bc", GridControl1)
                GridView1.Columns(0).Visible = False
                GridView1.Columns(2).Width = 282
            ElseIf txtopt.Text = "8" Then
                Pop(d, ds, "select bc.ID,bc.PrintDate,bc.No,b.Fullname,bc.ORno,bc.ORAmount,bc.CTC,bc.CTCAmount from Belongings bc LEFT JOIN Resident b ON b.ID=bc.ResidentID where bc.PrintDate like '%" & Trim(txtDate.Text) & "%'", "TribalMember bc", GridControl1)
                GridView1.Columns(0).Visible = False
                GridView1.Columns(2).Width = 282
            ElseIf txtopt.Text = "2" Then
                Pop(d, ds, "select bc.ID,bc.PrintDate,bc.No,b.Fullname,bc.ORno,bc.ORAmount,bc.CTC,bc.CTCAmount from animalTransport bc LEFT JOIN Resident b ON b.ID=bc.ResidentID LEFT JOIN animal a ON a.ID=bc.AnimalID where bc.PrintDate like '%" & Trim(txtDate.Text) & "%'", "AnimalTransport bc", GridControl1)
                GridView1.Columns(0).Visible = False
                GridView1.Columns(2).Width = 282
            ElseIf txtopt.Text = "9" Then
                Pop(d, ds, "select bc.ID,bc.PrintDate,bc.No,b.BusinessName,bc.ORno,bc.ORAmount,bc.CTC,bc.CTCAmount from NonOperation bc LEFT JOIN Business b ON b.ID=bc.BusinessID where bc.PrintDate like '%" & Trim(txtDate.Text) & "%'", "NonOperation bc", GridControl1)
                GridView1.Columns(0).Visible = False
                GridView1.Columns(2).Width = 282
            ElseIf txtopt.Text = "7" Then
                Pop(d, ds, "select bc.ID,bc.PrintDate,bc.SoloParentNo No,b.Fullname,bc.ORno,bc.ORAmount,bc.CTC,bc.CTCAmount from SoloParent bc LEFT JOIN Resident b ON b.ID=bc.ResidentID where bc.PrintDate like '%" & Trim(txtDate.Text) & "%'", "SoloParent bc", GridControl1)
                GridView1.Columns(0).Visible = False
                GridView1.Columns(2).Width = 282
            ElseIf txtopt.Text = "1" Then
                Pop(d, ds, "select bc.ID,bc.PrintDate,bc.ClearanceNo No,b.BusinessName,bc.ORno,bc.ORAmount,bc.CTC,bc.CTCAmount from busClearance bc LEFT JOIN Business b ON b.ID=bc.BusinessID where bc.PrintDate like '%" & txtDate.Text & "%'", "busClearance bc", GridControl1)
                GridView1.Columns(0).Visible = False
                GridView1.Columns(2).Width = 282
            ElseIf txtopt.Text = "5" Then
                Pop(d, ds, "select i.ID,i.PrintDate,i.IndigencyNo No,r.Fullname,i.ORno,i.ORAmount,i.CTC,i.CTCAmount from Indigency i LEFT JOIN Resident r ON r.ID=i.ResidentID where i.PrintDate like '%" & Trim(txtDate.Text) & "%'", "Indigency i", GridControl1)
                GridView1.Columns(0).Visible = False
                GridView1.Columns(2).Width = 282
            ElseIf txtopt.Text = "GoodMoralList" Then
                Pop(d, ds, "select g.ID,g.PrintDate,g.GoodMoralNo No,r.Fullname,g.ORno,g.ORAmount,g.CTC,g.CTCAmount from GoodMoral g LEFT JOIN Resident r ON r.ID=g.ResidentID where g.PrintDate like '%" & Trim(txtDate.Text) & "%'", "GoodMoral g", GridControl1)
                GridView1.Columns(0).Visible = False
                GridView1.Columns(2).Width = 282
            ElseIf txtopt.Text = "10" Then
                Pop(d, ds, "select g.ID,g.PrintDate,g.GoodMoralNo No,r.Fullname,g.ORno,g.ORAmount,g.CTC,g.CTCAmount from GoodMoral g LEFT JOIN Resident r ON r.ID=g.ResidentID where g.PrintDate like '%" & Trim(txtDate.Text) & "%'", "GoodMoral g", GridControl1)
                GridView1.Columns(0).Visible = False
                GridView1.Columns(2).Width = 282
            ElseIf txtopt.Text = "EndureList" Then
                Pop(d, ds, "select e.ID,e.PrintDate,e.EndureNo No,r.Fullname from Endure e LEFT JOIN Resident r ON r.ID=e.ResidentID where e.PrintDate like '%" & Trim(txtDate.Text) & "%'", "Endure e", GridControl1)
                GridView1.Columns(0).Visible = False
                GridView1.Columns(2).Width = 282
            ElseIf txtopt.Text = "11" Then
                Pop(d, ds, "select b.ID,b.ComplianantID,b.PersonToComplainID,b.BlotterNo,r.Fullname Complainant, r1.FullName Respondent,b.StatementOfComp, b.LocationOfIncidence, b.BDate, b.`Status`, b.ActionTaken from blotter b LEFT JOIN Resident r ON r.ID=b.ComplianantID LEFT JOIN Resident r1 ON r1.ID=b.PersontoComplainID where b.archive = 0 and b.BDate like '%" & Trim(txtDate.Text) & "%' ORDER by r.fullname", "blotter b", GridControl1)
                GridView1.Columns(0).Visible = False
                GridView1.Columns(1).Visible = False
                GridView1.Columns(2).Visible = False
                GridView1.Columns(4).Width = 150
                GridView1.Columns(5).Width = 150
            End If
            txtDate.Enabled = True
        End If

        lblRec.Text = GridView1.RowCount & " Record(s) Found!"
        Try
            lblCTCAmount.Text = "0"
            lblORAmount.Text = "0"
            For i = 0 To GridView1.RowCount - 1
                lblORAmount.Text += Val(GridView1.GetRowCellValue(i, "ORAmount"))
                lblCTCAmount.Text += Val(GridView1.GetRowCellValue(i, "CTCAmount"))
            Next i
            lblCTCAmount.Text = "CTC Total Amount: " & lblCTCAmount.Text
            lblORAmount.Text = "OR Total Amount " & lblORAmount.Text
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return True
    End Function
    Private Sub TransactionReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridView1.Columns.Clear()
        txtDate.Text = Date.Now.ToString("MM/dd/yyyy")
        cbAll.Checked = False
        cbOption.SelectedIndex = 0
    End Sub
    Private Sub txtDate_ValueChanged(sender As Object, e As EventArgs) Handles txtDate.ValueChanged
        'reload("Where c.CDate = '" & txtDate.Text & "'")
        reloadTrans()
    End Sub
    Private Sub cbOption_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbOption.SelectedIndexChanged
        txtopt.Text = cbOption.SelectedIndex
        reloadTrans()
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        frmOPPrint.optreport = "Trans"
        frmOPPrint.ShowDialog()
    End Sub
End Class