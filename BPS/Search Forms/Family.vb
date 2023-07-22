Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Public Class Family
    Public op As Boolean
    Private Sub Family_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupControl1.SendToBack()
    End Sub
    Public Overrides Sub reload()

    End Sub
    Public Overrides Sub SelectRes()

    End Sub
    Public Overrides Sub Search()
        Try
            Pop(d, ds, "select f.Head, f.code, rh.Fullname, r.Fullname, f.Relation from family f left join Resident rh on rh.ID=f.Head left join Resident r on r.ID=f.ResID  where rh.Fullname like '%" & txtSearch1.Text _
                                                                                                                                                             & "%' or r.Fullname like '%" & txtSearch1.Text _
                                                                                                                                                                       & "%'", "family f", GridControl1)
            Pop(d1, ds1, "select count(DISTINCT code) from family", "family")
            GridView1.Columns(2).Caption = "Head of the Family"
            GridView1.Columns(3).Caption = "Family Memmbers"
            GridView1.Columns(0).Visible = False
            GridView1.Columns(1).Visible = False
            GridView1.Columns(2).Visible = False
            Dim q As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns("Fullname")
            q.GroupIndex = 0
            GridView1.ExpandAllGroups()
            lblRec1.Text = (ds1.Tables("family").Rows(0).Item(0)).ToString & " Total Household(s) found!"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub getChildRows(ByVal view As GridView)
        For Each rowHandle As Integer In view.GetSelectedRows()
            If (Not view.IsGroupRow(rowHandle)) Then
                Return
            End If
            Dim childCount As Integer = view.GetChildRowCount(rowHandle)
            For i As Integer = 0 To childCount - 1
                Dim childHandle As Integer = view.GetChildRowHandle(rowHandle, i)
                Dim val As Object = view.GetRowCellValue(childHandle, "code")
                Dim val1 As Object = view.GetRowCellValue(childHandle, "FullName")
            Next i
        Next rowHandle
    End Sub
    Public Overrides Sub IDval()
        Try
            Dim selctedRowsCount As Integer = GridView1.SelectedRowsCount
            Dim rowHandle As Integer = GridView1.GetSelectedRows()(selctedRowsCount - 1)
            Dim childCount As Integer = GridView1.GetChildRowCount(rowHandle)
            Dim val As Object = GridView1.GetGroupRowValue(rowHandle)
            Dim childHandle As Integer = GridView1.GetChildRowHandle(rowHandle, 1)
            'Dim childval As Object = GridView1.GetRowCellValue(childHandle, "ID")
            Dim childval1 As Object = GridView1.GetRowCellValue(childHandle, "code")
            If (Not GridView1.IsGroupRow(rowHandle)) Then
                'txtID.Text = GridView1.GetFocusedRowCellValue("ID").ToString
                txtCode.Text = GridView1.GetFocusedRowCellValue("code").ToString

            Else
                'txtID.Text = childval.ToString
                txtCode.Text = childval1.ToString
            End If
            'MsgBox(txtHead.Text)
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

    End Sub
    Public Overrides Sub Addbtn()
        Try
            adedFam.adds = True
            adedFam.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Overrides Sub Editbtn()
        If GridView1.RowCount = 0 Then
            Exit Sub
        End If
        'Try
        adedFam.adds = False

            Dim selctedRowsCount As Integer = GridView1.SelectedRowsCount
            Dim rowHandle As Integer = GridView1.GetSelectedRows()(selctedRowsCount - 1)
            Dim childCount As Integer = GridView1.GetChildRowCount(rowHandle)
            Dim val As Object = GridView1.GetGroupRowValue(rowHandle)
            Dim childHandle As Integer = GridView1.GetChildRowHandle(rowHandle, 0)
            Dim childval As Object = GridView1.GetRowCellValue(childHandle, "code")
            If (Not GridView1.IsGroupRow(rowHandle)) Then
                adedFam.txtHeadID.Text = GridView1.GetFocusedRowCellValue("Head").ToString
                adedFam.txtCode.Text = GridView1.GetFocusedRowCellValue("code").ToString
            Else
                'adedFam.txtHeadID.Text = childval.ToString
                adedFam.txtCode.Text = childval.ToString
            End If

            adedFam.ShowDialog()
        'Catch ex As Exception
        'MsgBox("Yays!")
        'End Try

    End Sub
    Public Overrides Sub Deletebtn()
        If GridView1.RowCount = 0 Then
            Exit Sub
        End If
        Try
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim selctedRowsCount As Integer = GridView1.SelectedRowsCount
                Delete("family", "Where Code = " & Val(txtCode.Text) & "")
                MsgBox("Record Successfully Deleted!", MsgBoxStyle.Information)
                GridView1.Columns.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

    End Sub
End Class