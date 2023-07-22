Public Class Business
    Public Overrides Sub Search()
        Try
            Pop(d, ds, "select * from Business where BusinessName Like '%" & txtSearch1.Text _
                                           & "%' or Purok like '%" & txtSearch1.Text & "%' or BusinessType Like '%" & txtSearch1.Text _
                                           & "%' or Proprietor Like '%" & txtSearch1.Text & "%'", "Business", GridControl1)
            lblRec1.Text = ds.Tables("Business").Rows.Count & " record(s) found"
            GridView1.Columns(0).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Overrides Sub reload()
        Try
            Pop(d, ds, "select * from Business", "Business", GridControl1)
            lblRec1.Text = ds.Tables("Business").Rows.Count & " record(s) found"
            GridView1.Columns(0).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Business_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Overrides Sub Addbtn()
        Try
            adedBusiness.adds = True
            adedBusiness.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Overrides Sub Editbtn()
        Try
            adedBusiness.adds = False
            adedBusiness.txtID.Text = GridView1.GetFocusedRowCellValue("ID").ToString
            adedBusiness.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Overrides Sub Deletebtn()
        Try
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Delete("Business", "Where ID = " & GridView1.GetFocusedRowCellValue("ID").ToString & "")
                MsgBox("Record Successfully Deleted!", MsgBoxStyle.Information)
                reload()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

    End Sub
End Class