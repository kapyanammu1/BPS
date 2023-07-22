Imports MySql.Data.MySqlClient
Public Class Archive
    Dim d As MySqlDataAdapter, ds As DataSet, bi As New BindingSource, dt As New DataTable
    Dim offset As Integer = 0
    Private Sub cbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFilter.SelectedIndexChanged
        GridView1.Columns.Clear()

        If cbFilter.SelectedIndex = 0 Then
            reload("Resident", "select ID,FULLNAME,Gender,Purok from Resident Where Archive = 1")
            GridView1.Columns(0).Visible = False
            GridView1.Columns(1).Visible = True
            GridView1.Columns(2).Visible = True
        Else
            reload("blotter b", "select b.ID,b.ComplianantID,b.PersonToComplainID,b.BlotterNo,r.Fullname Complainant, r1.FullName Accused,b.StatementOfComp, b.LocationOfIncidence, b.BDate, b.`Status`, b.ActionTaken from blotter b LEFT JOIN Resident r ON r.ID=b.ComplianantID LEFT JOIN Resident r1 ON r1.ID=b.PersontoComplainID Where b.Archive = 1")
            GridView1.Columns(0).Visible = False
            GridView1.Columns(1).Visible = False
            GridView1.Columns(2).Visible = False
        End If

    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            If MsgBox("Are you sure you want to restore this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If cbFilter.SelectedIndex = 0 Then
                    Edit("Resident", "Archive=0", "where ID = " & GridView1.GetFocusedDataRow("ID").ToString & "")
                    activity("RESTORED RESIDENT RECORD NAMED " & GridView1.GetFocusedDataRow("Fullname").ToString)
                    reload("Resident", "select ID,FULLNAME,Gender,Purok from Resident Where Archive = 1 LIMIT " & offset & ",20")
                    GridView1.Columns(0).Visible = False
                    GridView1.Columns(1).Visible = True
                    GridView1.Columns(2).Visible = True
                Else
                    Edit("Blotter", "Archive=0", "where ID = " & GridView1.GetFocusedDataRow("ID").ToString & "")
                    activity("RESTORED BLOTTER RECORD NO: " & GridView1.GetFocusedDataRow("BlotterNo").ToString)
                    reload("blotter b", "select b.ID,b.ComplianantID,b.PersonToComplainID,b.BlotterNo,r.Fullname Complainant, r1.FullName PersonToComplain,b.StatementOfComp, b.LocationOfIncidence, b.BDate, b.`Status`, b.ActionTaken from blotter b LEFT JOIN Resident r ON r.ID=b.ComplianantID LEFT JOIN Resident r1 ON r1.ID=b.PersontoComplainID Where b.Archive = 1")
                    GridView1.Columns(0).Visible = False
                    GridView1.Columns(1).Visible = False
                    GridView1.Columns(2).Visible = False
                End If
                MsgBox("Record Restored", MsgBoxStyle.Information)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        offset = 0
        If cbFilter.SelectedIndex = 0 Then
            Pop(d, ds, "select ID,FULLNAME,Gender,Purok from Resident where (Archive = 1) and (Fullname like '%" & txtSearch.Text & "%' or Lname like '%" & txtSearch.Text & "%' or Mname like '%" & txtSearch.Text & "%' or Fname like '%" & txtSearch.Text & "%' or Purok like '%" & txtSearch.Text & "%' or Gender like '%" & txtSearch.Text & "%')", "ActivityLogs", GridControl1)
            GridView1.Columns(0).Visible = False
            GridView1.Columns(1).Visible = True
            GridView1.Columns(2).Visible = True
        Else
            Pop(d, ds, "select b.ID,b.ComplianantID,b.PersonToComplainID,b.BlotterNo,r.Fullname Complainant, r1.FullName Accused,b.StatementOfComp, b.LocationOfIncidence, b.BDate, b.`Status`, b.ActionTaken from blotter b LEFT JOIN Resident r ON r.ID=b.ComplianantID LEFT JOIN Resident r1 ON r1.ID=b.PersontoComplainID Where (b.BlotterNo like '%" & Trim(txtSearch.Text) _
                & "%' or r.fullname like '%" & Trim(txtSearch.Text) & "%' or r1.fullname like '%" & Trim(txtSearch.Text) & "%' or b.LocationOfIncidence like '%" & Trim(txtSearch.Text) & "%' or b.StatementOfComp like '%" & Trim(txtSearch.Text) & "%' or b.bDate like '%" & Trim(txtSearch.Text) & "%') and b.archive = 1", "blotter b", GridControl1)
            GridView1.Columns(0).Visible = False
            GridView1.Columns(1).Visible = False
            GridView1.Columns(2).Visible = False
        End If
        'reloadGrid("" & txtSelect.Text & " " & txttbl.Text & " where archive = 0 LIMIT " & x & ", 3000", "" & txttbl.Text & "")
        GridView1.ClearSelection()
    End Sub
    Private Sub Archive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbFilter.SelectedIndex = 0
        If cbFilter.SelectedIndex = 0 Then
            reload("Resident", "select ID,FULLNAME,Gender,Purok from Resident Where Archive = 1")
            GridView1.Columns(0).Visible = False
            GridView1.Columns(1).Visible = True
            GridView1.Columns(2).Visible = True
        Else
            reload("blotter b", "select b.ID,b.ComplianantID,b.PersonToComplainID,b.BlotterNo,r.Fullname Complainant, r1.FullName Accused,b.StatementOfComp, b.LocationOfIncidence, b.BDate, b.`Status`, b.ActionTaken from blotter b LEFT JOIN Resident r ON r.ID=b.ComplianantID LEFT JOIN Resident r1 ON r1.ID=b.PersontoComplainID Where b.Archive = 1")
            GridView1.Columns(0).Visible = False
            GridView1.Columns(1).Visible = False
            GridView1.Columns(2).Visible = False
        End If
    End Sub
    Private Sub reload(ByVal tbl As String, ByVal qry As String)
        Pop(d, ds, "" & qry & "", "tbl", GridControl1)
        lblRec.Text = GridView1.RowCount & " Record(s) found"
    End Sub
End Class