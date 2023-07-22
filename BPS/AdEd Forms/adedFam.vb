Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class adedFam
    Dim d As MySqlDataAdapter, ds As DataSet
    Public adds As Boolean
    Private Sub adedFam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If adds = True Then
            clear()
        Else
            'txtHeadID.Text = Family.txtHead.Text
        End If

        relation()
        reload()
    End Sub
    Function clear()
        txtHeadID.Text = 0
        'txtCode.Text = ""
        Pop(d, ds, "select famcode from count", "count")
        txtCode.Text = ds.Tables("count").Rows(0).Item(0) + 1
        txtMemberID.Text = 0
        txtRelation.Text = ""
    End Function
    Function relation()
        txtRelation.Items.Clear()
        Pop(d, ds, "select * from famrel", "famrel")
        For i As Integer = 0 To ds.Tables("famrel").Rows.Count - 1
            txtRelation.Items.Add(ds.Tables("famrel").Rows(i).Item(1))
            txtRelation.AutoCompleteCustomSource.Add(ds.Tables("famrel").Rows(i).Item(1).ToString)
        Next i

        Return True
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Opt = "h"
        Search.ShowDialog()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Opt = "m"
        Search.ShowDialog()
    End Sub
    Private Sub txtMemberID_TextChanged(sender As Object, e As EventArgs) Handles txtMemberID.TextChanged
        Pop(d, ds, "select Fullname from resident where ID = " & txtMemberID.Text & "", "resident")
        If ds.Tables("Resident").Rows.Count > 0 Then
            txtMember.Text = ds.Tables("Resident").Rows(0).Item(0)
        Else
            txtMember.Clear()
        End If
    End Sub
    Private Sub txtHeadID_TextChanged(sender As Object, e As EventArgs) Handles txtHeadID.TextChanged
        Pop(d, ds, "select Fullname from resident where ID = " & txtHeadID.Text & "", "resident")
        If ds.Tables("Resident").Rows.Count > 0 Then
            txtHead.Text = ds.Tables("Resident").Rows(0).Item(0)
        Else
            txtHead.Clear()
        End If
        reload()
    End Sub
    Function reload()
        Pop(d, ds, "select f.ID, fh.Fullname, r.Fullname, f.Relation, r.Age, r.Gender, r.Educattainment, r.Profession from family f LEFT JOIN Resident fh on fh.ID=f.Head LEFT JOIN Resident r on r.ID=f.ResID where f.Code = " & Val(txtCode.Text) & " and f.Relation <> '" & "Head" & "'", "family f", GridControl1)
        GridView1.Columns(0).Visible = False
        GridView1.Columns(1).Visible = False
        GridView1.Columns(2).Caption = "MEMBERS"
        Return True
    End Function
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If MsgBox("Are you sure you want to remove this member?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Delete("family", "where ID = " & GridView1.GetFocusedRowCellValue("ID").ToString & "")
            reload()
        End If
    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If txtHouseType.Text = "" Or txtHouseNo.Text = "" Then
            MsgBox("Required Field Missing!.", MsgBoxStyle.Critical, "Invalid")
            Exit Sub
        End If
        If txtMemberID.Text = txtHeadID.Text Then
            MsgBox("This person is the head of the family already! Please try again.", MsgBoxStyle.Critical, "Invalid")
            Exit Sub
        End If
        If txtHeadID.Text = "" Or txtRelation.Text = "" Or txtMember.Text = "" Then
            MsgBox("Required Field Missing!", MsgBoxStyle.Critical)
        Else
            insert("Family", "code,HouseNo,HouseType,ResID,Relation,Head", "" & txtCode.Text & ",'" & txtHouseNo.Text & "','" & txtHouseType.Text & "'," & txtMemberID.Text & ",'" & txtRelation.Text & "'," & txtHeadID.Text & "")
            If adds = True Then
                Edit("count", "famcode = " & txtCode.Text & "", "")
            End If
            txtMemberID.Text = 0
                reload()
            End If
    End Sub
    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        If GridView1.RowCount = 0 Then
            MsgBox("No record(s) found!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If MsgBox("Are you sure you want to remove this member?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Delete("family", "where ID = " & GridView1.GetFocusedRowCellValue("ID").ToString & "")
            reload()
        End If
    End Sub
    Private Sub txtCode_TextChanged(sender As Object, e As EventArgs) Handles txtCode.TextChanged
        Pop(d, ds, "select Head, HouseNo, HouseType from family where Code = " & Val(txtCode.Text) & "", "family")
        If ds.Tables("family").Rows.Count > 0 Then
            txtHouseNo.Text = ds.Tables("family").Rows(0).Item("HouseNo").ToString
            txtHouseType.Text = ds.Tables("family").Rows(0).Item("HouseType").ToString
            txtHeadID.Text = ds.Tables("family").Rows(0).Item(0)

        Else
            txtHead.Clear()
            txtHouseNo.Clear()
            txtHouseType.Text = ""
        End If
    End Sub

    Private Sub txtCount_TextChanged(sender As Object, e As EventArgs) Handles txtCount.TextChanged

    End Sub

    Private Sub txtHouseNo_TextChanged(sender As Object, e As EventArgs) Handles txtHouseNo.TextChanged

    End Sub

    Private Sub adedFam_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If txtHead.Text <> "" And GridView1.RowCount = 0 Then
            insert("family", "Code, HouseNO, HouseType, ResID,Relation,Head", "" & txtCode.Text & ",'" & txtHouseNo.Text & "','" & txtHouseType.Text & "'," & txtHeadID.Text & ", '" & "Head" & "', " & txtHeadID.Text & "")
            Family.GridView1.Columns.Clear()
            If adds = True Then
                Edit("count", "famcode = " & txtCode.Text & "", "")
            End If
        ElseIf txtHead.Text <> "" And GridView1.RowCount > 0 Then
            Delete("family", "where ResID = " & txtHeadID.Text & "")
            Family.GridView1.Columns.Clear()
        End If
        Family.GridView1.Columns.Clear()
        Form1.DashboardViewer1.ReloadData()
    End Sub

    Private Sub adedFam_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.DashboardViewer1.ReloadData()
    End Sub
End Class