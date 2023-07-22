Public Class AnimalSearch
    Private Sub AnimalSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Bar1.Visible = False
    End Sub
    Public Overrides Sub Search()
        Try
            Pop(d, ds, "select a.ID, a.ResidentID, a.No, r.FullName, a.Brand, a.Class, a.Color, a.Sex, a.Age, a.Cowlicks from Animal a LEFT JOIN Resident r ON r.ID=a.ResidentID where r.Fullname Like '%" & txtSearch1.Text _
                                                                    & "%' or a.Brand Like '%" & txtSearch1.Text _
                                                                    & "%'  or a.Class Like '%" & txtSearch1.Text _
                                                                    & "%'  or a.Color Like '%" & txtSearch1.Text _
                                                                    & "%'  or a.Sex Like '%" & txtSearch1.Text _
                                                                    & "%'or a.Cowlicks Like '%" & txtSearch1.Text _
                                                                    & "%'", "Animal a", GridControl1)
            lblRec1.Text = ds.Tables("Animal a").Rows.Count & " record(s) found"
            GridView1.Columns(0).Visible = False
            GridView1.Columns(1).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Overrides Sub Reload()
        Try
            Pop(d, ds, "select a.ID, a.ResidentID, a.No, r.FullName, a.Brand, a.Class, a.Color, a.Sex, a.Age, a.Cowlicks from Animal a LEFT JOIN Resident r ON r.ID=a.ResidentID", "Animal a", GridControl1)
            lblRec1.Text = ds.Tables("Animal a").Rows.Count & " record(s) found"
            GridView1.Columns(0).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Overrides Sub SelectRes()
        Try
            If GridView1.RowCount > 0 Then
                frmAnimalTransport.txtID.Text = GridView1.GetFocusedRowCellValue("ID").ToString
                frmAnimalTransport.txtResID.Text = GridView1.GetFocusedRowCellValue("ResidentID").ToString
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class