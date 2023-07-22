Public Class Blotter
    Private Sub Blotter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Overrides Sub Search()
        Try
            Pop(d, ds, "select b.ID,b.ComplianantID,b.PersonToComplainID,b.BlotterNo,r.Fullname Complainant, r1.FullName Accused,b.StatementOfComp, b.LocationOfIncidence, b.BDate, b.`Status`, b.ActionTaken from blotter b LEFT JOIN Resident r ON r.ID=b.ComplianantID LEFT JOIN Resident r1 ON r1.ID=b.PersontoComplainID where (b.StatementOfComp like '%" & txtSearch1.Text & "%' or r.Fullname like '%" & txtSearch1.Text & "%' or r1.Fullname like '%" & txtSearch1.Text & "%') and b.archive=0", "blotter b", GridControl1)
            lblRec1.Text = ds.Tables("blotter b").Rows.Count & " record(s) found"
            GridView1.Columns(0).Visible = False
            GridView1.Columns(1).Visible = False
            GridView1.Columns(2).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Overrides Sub Reload()
        Try
            Pop(d, ds, "select b.ID,b.ComplianantID,b.PersonToComplainID,b.BlotterNo,r.Fullname Complainant, r1.FullName Accused,b.StatementOfComp, b.LocationOfIncidence, b.BDate, b.`Status`, b.ActionTaken from blotter b LEFT JOIN Resident r ON r.ID=b.ComplianantID LEFT JOIN Resident r1 ON r1.ID=b.PersontoComplainID where b.archive=0", "blotter b", GridControl1)
            lblRec1.Text = ds.Tables("blotter b").Rows.Count & " record(s) found"
            GridView1.Columns(0).Visible = False
            GridView1.Columns(1).Visible = False
            GridView1.Columns(2).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Overrides Sub Addbtn()
        Try
            adedBlotter.adds = True
            adedBlotter.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Overrides Sub Editbtn()
        Try
            adedBlotter.adds = False
            adedBlotter.txtID.Text = GridView1.GetFocusedRowCellValue("ID").ToString
            adedBlotter.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Overrides Sub Deletebtn()
        Try
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Edit("blotter", "Archive=1", "Where ID = " & GridView1.GetFocusedRowCellValue("ID").ToString & "")
                MsgBox("Record Successfully Deleted!", MsgBoxStyle.Information)
                Reload()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class