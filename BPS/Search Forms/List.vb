Imports System.ComponentModel
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports MySql.Data.MySqlClient
Public Class List
    Public d, d1 As MySqlDataAdapter, ds, ds1 As DataSet
    Public strTbl As String = ""
    Private Sub List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.DashboardViewer1.Visible = False
        reload()
        GridView1.BestFitColumns()
        lblRec1.Location = New Point(2, Me.Height - 56)
        txtSearch1.Select()
    End Sub
    Private Sub BarLargeButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarLargeButtonItem1.ItemClick
        Addbtn()
    End Sub
    Private Sub btnSearch_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSearch.ItemClick
        Search()
    End Sub
    Public Overridable Sub reload()
        Try
            Pop(d, ds, "select ID, Fullname, Gender, Address, ContactNo, Birthdate, BirthPlace, CivilStatus, Religion, Purok from Resident where archive = 0 ORDER BY Purok ASC, FullName ASC", "Resident", GridControl1)
            GridView1.Columns(0).Visible = False
            lblRec1.Text = ds.Tables("Resident").Rows.Count & " record(s) found"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Overridable Sub Search()
        Try
            Pop(d, ds, "select ID, Fullname, Gender, Address, ContactNo, Birthdate, BirthPlace, CivilStatus, Religion, Purok from Resident where Fullname like '%" & txtSearch1.Text & "%' and archive = 0 ORDER BY Purok ASC, FullName ASC", "Resident", GridControl1)
            GridView1.Columns(0).Visible = False
            lblRec1.Text = ds.Tables("Resident").Rows.Count & " record(s) found"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Overridable Sub Deletebtn()

    End Sub
    Public Overridable Sub Addbtn()

    End Sub
    Private Sub BarLargeButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarLargeButtonItem3.ItemClick
        Editbtn()
    End Sub
    Private Sub BarLargeButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarLargeButtonItem4.ItemClick
        Deletebtn()
    End Sub
    Public Overridable Sub Editbtn()

    End Sub
    Private Sub GridView1_Click(sender As Object, e As EventArgs) Handles GridView1.Click
        IDval()
    End Sub
    Public Overridable Sub IDval()
        Try
            txtID.Text = GridView1.GetFocusedRowCellValue("ID").ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Overridable Sub SelectRes()
        Try
            txtID.Text = GridView1.GetFocusedRowCellValue("ID").ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub GridView1_LostFocus(sender As Object, e As EventArgs) Handles GridView1.LostFocus

    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Search()
    End Sub
    Private Sub txtSearch1_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Search()
    End Sub
    Private Sub txtSearch1_ButtonPressed(sender As Object, e As ButtonPressedEventArgs)
        Search()
    End Sub
    Private Sub txtSearch1_Enter(sender As Object, e As EventArgs)
        Search()
    End Sub
    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        SelectRes()
    End Sub
    Private Sub List_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If Form1.MdiChildren.Count = 1 Then
            Form1.DashboardViewer1.Visible = True
        Else
            Form1.DashboardViewer1.Visible = False
        End If
    End Sub
End Class