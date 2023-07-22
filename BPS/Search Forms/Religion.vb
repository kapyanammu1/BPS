
Public Class Religion
    Private Sub Religion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Overrides Sub reload()
        Try
            Pop(d, ds, "select * from Religion", "Religion", GridControl1)
            lblRec1.Text = ds.Tables("Religion").Rows.Count & " record(s) found"
            GridView1.Columns(0).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Overrides Sub Search()
        Try
            Pop(d, ds, "select * from Religion where Religion Like '%" & txtSearch1.Text & "%'", "Religion", GridControl1)
            lblRec1.Text = ds.Tables("Religion").Rows.Count & " record(s) found"
            GridView1.Columns(0).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Overrides Sub Addbtn()
        Try
            adedReligion.adds = True
            adedReligion.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Overrides Sub Editbtn()
        Try
            adedReligion.adds = False
            adedReligion.txtID.Text = GridView1.GetFocusedRowCellValue("ID").ToString
            adedReligion.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Overrides Sub Deletebtn()
        Try
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Delete("Religion", "Where ID = " & GridView1.GetFocusedRowCellValue("ID").ToString & "")
                MsgBox("Record Successfully Deleted!", MsgBoxStyle.Information)
                reload()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class