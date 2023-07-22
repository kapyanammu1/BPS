Public Class Zone
    Private Sub Zone_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Overrides Sub reload()
        Try
            Pop(d, ds, "select * from Purok", "Purok", GridControl1)
            lblRec1.Text = ds.Tables("Purok").Rows.Count & " record(s) found"
            GridView1.Columns(0).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Overrides Sub Search()
        Try
            Pop(d, ds, "select * from Purok where PurokName like '%" & txtSearch1.Text & "%' or Description like '%" & txtSearch1.Text & "%'", "Purok", GridControl1)
            lblRec1.Text = ds.Tables("Purok").Rows.Count & " record(s) found"
            GridView1.Columns(0).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Overrides Sub Addbtn()
        Try
            adedZone.adds = True
            adedZone.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Overrides Sub Editbtn()
        Try
            adedZone.adds = False
            adedZone.txtID.Text = GridView1.GetFocusedRowCellValue("ID").ToString
            adedZone.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Overrides Sub Deletebtn()
        Try
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Delete("Purok", "Where ID = " & GridView1.GetFocusedRowCellValue("ID").ToString & "")
                MsgBox("Record Successfully Deleted!", MsgBoxStyle.Information)
                reload()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class