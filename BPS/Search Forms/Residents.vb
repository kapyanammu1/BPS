Public Class Residents
    Private Sub Residents_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Friend Shared Function Residents() As Object
        Throw New NotImplementedException()
    End Function
    Public Overrides Sub reload()
        Try
            Pop(d, ds, "select ID, Fullname, Gender, Address, ContactNo, Birthdate, BirthPlace, CivilStatus, Religion, Purok from Resident where archive = 0 ORDER BY Purok ASC, FullName ASC", "Resident", GridControl1)
            GridView1.Columns(0).Visible = False
            lblRec1.Text = ds.Tables("Resident").Rows.Count & " record(s) found"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Overrides Sub Search()
        Try
            Pop(d, ds, "select ID, Fullname, Gender, Address, ContactNo, Birthdate, BirthPlace, CivilStatus, Religion, Purok from Resident where Fullname like '%" & txtSearch1.Text & "%' and archive = 0 ORDER BY Purok ASC, FullName ASC", "Resident", GridControl1)
            GridView1.Columns(0).Visible = False
            lblRec1.Text = ds.Tables("Resident").Rows.Count & " record(s) found"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Overrides Sub Addbtn()
        Try
            adedRes.adds = True
            adedRes.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Overrides Sub Editbtn()
        Try
            adedRes.adds = False
            adedRes.txtID.Text = GridView1.GetFocusedRowCellValue("ID").ToString
            adedRes.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Overrides Sub Deletebtn()
        Try
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Edit("Resident", "Archive=1", "Where ID = " & GridView1.GetFocusedRowCellValue("ID").ToString & "")
                MsgBox("Record Successfully Deleted!", MsgBoxStyle.Information)
                reload()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class