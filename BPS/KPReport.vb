Imports MySql.Data.MySqlClient
Public Class KPReport
    Dim d As MySqlDataAdapter, ds As DataSet
    Private Sub KPReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridView1.Columns.Clear()
        txtDate.Text = Date.Now.ToString("MM/dd/yyyy")
        cbAll.Checked = False
        cbOption.SelectedIndex = 0
    End Sub
    Private Sub txtDate_ValueChanged(sender As Object, e As EventArgs) Handles txtDate.ValueChanged
        reloadTrans()
    End Sub
    Private Sub cbOption_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbOption.SelectedIndexChanged
        txtopt.Text = cbOption.SelectedIndex
        reloadTrans()
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        frmOPPrint.optreport = "KP"
        frmOPPrint.ShowDialog()
    End Sub
    Private Sub cbAll_CheckedChanged(sender As Object, e As EventArgs) Handles cbAll.CheckedChanged
        reloadTrans()
    End Sub
    Function reloadTrans()
        GridView1.Columns.Clear()
        If cbAll.Checked Then
            If txtopt.Text = "0" Then
                Pop(d, ds, "select ID,CDate Date,CaseNo,ComplainantName,RespondentName,Complaint,relief from form97", "form97", GridControl1)
                GridView1.Columns(0).Visible = False
                GridView1.Columns(1).Width = 100
                GridView1.Columns(2).Width = 100
                GridView1.Columns(5).Width = 400
            ElseIf txtopt.Text = "1" Then
                Pop(d, ds, "select f98.ID,f98.PrintDate,f98.CaseNo,f97.ComplainantName,f97.RespondentName,f97.Complaint,f97.relief from form98 f98 LEFT JOIN form97 f97 ON f97.CaseNo=f98.CaseNo", "form98 f98", GridControl1)
                GridView1.Columns(0).Visible = False
                GridView1.Columns(1).Width = 100
                GridView1.Columns(2).Width = 100
                GridView1.Columns(5).Width = 400
            ElseIf txtopt.Text = "2" Then
                Pop(d, ds, "select f99.ID,f99.PrintDate,f99.CaseNo,f97.ComplainantName,f97.RespondentName,f97.Complaint,f97.relief from form99 f99 LEFT JOIN form97 f97 ON f97.CaseNo=f99.CaseNo", "form99 f99", GridControl1)
                GridView1.Columns(0).Visible = False
                GridView1.Columns(1).Width = 100
                GridView1.Columns(2).Width = 100
                GridView1.Columns(5).Width = 400
            ElseIf txtopt.Text = "3" Then
                Pop(d, ds, "select ID,PrintDate,CaseNo,Officer OfficerInCharge,ServedDate from form100", "form100", GridControl1)
                GridView1.Columns(0).Visible = False
                GridView1.Columns(1).Width = 100
                GridView1.Columns(2).Width = 100
                GridView1.Columns(3).Width = 282
            ElseIf txtopt.Text = "4" Then
                Pop(d, ds, "select f102.ID,f102.PrintDate,f102.CaseNo,f97.ComplainantName,f97.RespondentName,f97.Complaint,f97.relief,f102.Chosen ChosenPangkat from form102 f102 LEFT JOIN form97 f97 ON f97.CaseNo=f102.CaseNo", "form102 f102", GridControl1)
                GridView1.Columns(0).Visible = False
                GridView1.Columns(1).Width = 100
                GridView1.Columns(2).Width = 100
                GridView1.Columns(5).Width = 400
            ElseIf txtopt.Text = "5" Then
                Pop(d, ds, "select f112.ID,f112.PrintDate,f112.CaseNo,f97.ComplainantName,f97.RespondentName,f97.Complaint,f97.relief from form112 f112 LEFT JOIN form97 f97 ON f97.CaseNo=f112.CaseNo", "form112 f112", GridControl1)
                GridView1.Columns(0).Visible = False
                GridView1.Columns(1).Width = 100
                GridView1.Columns(2).Width = 100
                GridView1.Columns(5).Width = 400
            End If
            txtDate.Enabled = False
            'Button1.Enabled = False
        Else
            If txtopt.Text = "0" Then
                Pop(d, ds, "select ID,CDate Date,CaseNo,ComplainantName,RespondentName,Complaint,relief from form97 where CDate like '%" & Trim(txtDate.Text) & "%'", "form97", GridControl1)
                GridView1.Columns(0).Visible = False
                GridView1.Columns(1).Width = 100
                GridView1.Columns(2).Width = 100
                GridView1.Columns(5).Width = 400
            ElseIf txtopt.Text = "1" Then
                Pop(d, ds, "select f98.ID,f98.PrintDate,f98.CaseNo,f97.ComplainantName,f97.RespondentName,f97.Complaint,f97.relief from form98 f98 LEFT JOIN form97 f97 ON f97.CaseNo=f98.CaseNo where f98.PrintDate like '%" & Trim(txtDate.Text) & "%'", "form98 f98", GridControl1)
                GridView1.Columns(0).Visible = False
                GridView1.Columns(1).Width = 100
                GridView1.Columns(2).Width = 100
                GridView1.Columns(5).Width = 400
            ElseIf txtopt.Text = "2" Then
                Pop(d, ds, "select f99.ID,f99.PrintDate,f99.CaseNo,f97.ComplainantName,f97.RespondentName,f97.Complaint,f97.relief from form99 f99 LEFT JOIN form97 f97 ON f97.CaseNo=f99.CaseNo where f99.PrintDate like '%" & Trim(txtDate.Text) & "%'", "form99 f99", GridControl1)
                GridView1.Columns(0).Visible = False
                GridView1.Columns(1).Width = 100
                GridView1.Columns(2).Width = 100
                GridView1.Columns(5).Width = 400
            ElseIf txtopt.Text = "3" Then
                Pop(d, ds, "select ID,PrintDate,CaseNo,Officer OfficerInCharge,ServedDate from form100 where PrintDate like '%" & Trim(txtDate.Text) & "%'", "form100", GridControl1)
                GridView1.Columns(0).Visible = False
                GridView1.Columns(1).Width = 100
                GridView1.Columns(2).Width = 100
                GridView1.Columns(3).Width = 282
            ElseIf txtopt.Text = "4" Then
                Pop(d, ds, "select f102.ID,f102.PrintDate,f102.CaseNo,f97.ComplainantName,f97.RespondentName,f97.Complaint,f97.relief,f102.Chosen ChosenPangkat from form102 f102 LEFT JOIN form97 f97 ON f97.CaseNo=f102.CaseNo where f102.PrintDate like '%" & Trim(txtDate.Text) & "%'", "form102 f102", GridControl1)
                GridView1.Columns(0).Visible = False
                GridView1.Columns(1).Width = 100
                GridView1.Columns(2).Width = 100
                GridView1.Columns(5).Width = 400
            ElseIf txtopt.Text = "5" Then
                Pop(d, ds, "select f112.ID,f112.PrintDate,f112.CaseNo,f97.ComplainantName,f97.RespondentName,f97.Complaint,f97.relief from form112 f112 LEFT JOIN form97 f97 ON f97.CaseNo=f112.CaseNo where f112.PrintDate like '%" & Trim(txtDate.Text) & "%'", "form112 f112", GridControl1)
                GridView1.Columns(0).Visible = False
                GridView1.Columns(1).Width = 100
                GridView1.Columns(2).Width = 100
                GridView1.Columns(5).Width = 400
            End If
            txtDate.Enabled = True
        End If
        lblRec.Text = GridView1.RowCount & " Record(s) Found!"
        Return True
    End Function
End Class