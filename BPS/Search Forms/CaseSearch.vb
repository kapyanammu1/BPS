Public Class CaseSearch
    Public opCase As String = ""
    Private Sub CaseSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Bar1.Visible = False
    End Sub
    Public Overrides Sub Search()
        Try
            Pop(d, ds, "select * from form97 where CaseNo Like '%" & txtSearch1.Text _
                                                                    & "%' or ComplainantName Like '%" & txtSearch1.Text _
                                                                    & "%'  or RespondentName Like '%" & txtSearch1.Text _
                                                                    & "%'  or Forr Like '%" & txtSearch1.Text _
                                                                    & "%'  or Complaint Like '%" & txtSearch1.Text _
                                                                    & "%'", "form97", GridControl1)
            lblRec1.Text = ds.Tables("form97").Rows.Count & " record(s) found"
            GridView1.Columns(0).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Overrides Sub Reload()
        Try
            Pop(d, ds, "select * from form97", "form97", GridControl1)
            lblRec1.Text = ds.Tables("form97").Rows.Count & " record(s) found"
            GridView1.Columns(0).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Overrides Sub SelectRes()
        Try
            If GridView1.RowCount > 0 Then
                If opCase = "Form98" Then
                    form98.txtCaseNo.Text = GridView1.GetFocusedRowCellValue("CaseNo").ToString
                    form98.txtName.Text = GridView1.GetFocusedRowCellValue("ComplainantName").ToString
                    Me.Close()
                ElseIf opCase = "Form99" Then
                    form99.txtCaseNo.Text = GridView1.GetFocusedRowCellValue("CaseNo").ToString
                    form99.txtName.Text = GridView1.GetFocusedRowCellValue("RespondentName").ToString
                    Me.Close()
                ElseIf opCase = "Form102" Then
                    form102.txtCaseNo.Text = GridView1.GetFocusedRowCellValue("CaseNo").ToString
                    Me.Close()
                ElseIf opCase = "Form112" Then
                    form112.txtCaseNo.Text = GridView1.GetFocusedRowCellValue("CaseNo").ToString
                    form112.txtName.Text = GridView1.GetFocusedRowCellValue("ComplainantName").ToString
                    Me.Close()
                ElseIf opCase = "Form100" Then
                    form100.txtCaseNo.Text = GridView1.GetFocusedRowCellValue("CaseNo").ToString
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class