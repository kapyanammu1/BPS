Public Class Users
    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Overrides Sub reload()
        Try
            Pop(d, ds, "select ID, Username, Accesslvl from Users", "Users", GridControl1)
            lblRec1.Text = ds.Tables("Users").Rows.Count & " record(s) found"
            GridView1.Columns(0).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Overrides Sub Search()
        Try
            Pop(d, ds, "select ID, Username, Accesslvl from Users where Username Like '%" & txtSearch1.Text & "%'", "Users", GridControl1)
            lblRec1.Text = ds.Tables("Users").Rows.Count & " record(s) found"
            GridView1.Columns(0).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Overrides Sub Addbtn()
        Try
            adedUser.adds = True
            adedUser.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Overrides Sub Editbtn()
        Try
            adedUser.adds = False
            adedUser.txtID.Text = GridView1.GetFocusedRowCellValue("ID").ToString
            adedUser.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Overrides Sub Deletebtn()
        Try
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Delete("users", "Where ID = " & GridView1.GetFocusedRowCellValue("ID").ToString & "")
                MsgBox("Record Successfully Deleted!", MsgBoxStyle.Information)
                reload()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class