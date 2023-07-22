Public Class BusinessSearch
    Public op As String = ""
    Private Sub BusinessSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Bar1.Visible = False
    End Sub
    Public Overrides Sub Search()
        Try
            Pop(d, ds, "select * from Business where BusinessName Like '%" & txtSearch1.Text _
                                                                    & "%' or BusinessType Like '%" & txtSearch1.Text _
                                                                    & "%'  or Purok Like '%" & txtSearch1.Text _
                                                                    & "%'  or Proprietor Like '%" & txtSearch1.Text _
                                                                    & "%'  or Address Like '%" & txtSearch1.Text _
                                                                    & "%'", "Business", GridControl1)
            lblRec1.Text = ds.Tables("Business").Rows.Count & " record(s) found"
            GridView1.Columns(0).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Overrides Sub Reload()
        Try
            Pop(d, ds, "select * from Business", "Business", GridControl1)
            lblRec1.Text = ds.Tables("Business").Rows.Count & " record(s) found"
            GridView1.Columns(0).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Overrides Sub SelectRes()
        Try
            If GridView1.RowCount > 0 Then
                If op = "BusNonOp" Then
                    NonOp.txtID.Text = GridView1.GetFocusedRowCellValue("ID").ToString
                    Me.Close()
                ElseIf op = "BusinessClearance" Then
                    BusinessClearance.txtID.Text = GridView1.GetFocusedRowCellValue("ID").ToString
                    Me.Close()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class