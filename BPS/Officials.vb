Imports MySql.Data.MySqlClient
Public Class Officials
    Friend d As MySqlDataAdapter, ds As DataSet
    Private Sub frmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.DashboardViewer1.Visible = False
        reload()
    End Sub
    Private Sub BarLargeButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarLargeButtonItem3.ItemClick
        UpdateOfficials.txtOID.Text = GridView1.GetFocusedRowCellValue("ID").ToString
        UpdateOfficials.txtResID.Text = GridView1.GetFocusedRowCellValue("ResidentID").ToString
        UpdateOfficials.lblPos.Text = GridView1.GetFocusedRowCellValue("Position").ToString
        UpdateOfficials.ShowDialog()
    End Sub
    Friend Shared Function Officials() As Object
        Throw New NotImplementedException()
    End Function
    Public Sub reload()
        Pop(d, ds, "select o.ID, o.ResidentID, r.Fullname, p.Position from brgyOfficials o LEFT JOIN Resident r on r.ID=o.ResidentID LEFT JOIN Position p on p.ID=o.Position", "brgyOfficials o", GridControl1)
        GridView1.Columns(0).Visible = False
        GridView1.Columns(1).Visible = False
    End Sub

    Private Sub Officials_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Form1.MdiChildren.Count = 1 Then
            Form1.DashboardViewer1.Visible = True
        Else
            Form1.DashboardViewer1.Visible = False
        End If
    End Sub
End Class