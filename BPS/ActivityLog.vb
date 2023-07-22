Imports MySql.Data.MySqlClient
Public Class ActivityLog
    Dim d As MySqlDataAdapter, ds As DataSet, bi As New BindingSource, dt As New DataTable

    Private Sub txtDate_ValueChanged(sender As Object, e As EventArgs) Handles txtDate.ValueChanged
        Pop(d, ds, "select * from ActivityLogs where ADate like '%" & Trim(txtDate.Text) & "%' ORDER BY ID DESC", "ActivityLogs", GridControl1)
        GridView1.Columns(0).Visible = False
        GridView1.Columns(4).Visible = False
        GridView1.Columns(5).Visible = False
        GridView1.Columns(1).Width = 136
        GridView1.Columns(2).Width = 380
        GridView1.Columns(3).Width = 140
        GridView1.Columns(3).Caption = "Date"
        lblRec.Text = GridView1.RowCount & " Record(s) found."
    End Sub

    Private Sub cbAll_CheckedChanged(sender As Object, e As EventArgs) Handles cbAll.CheckedChanged
        If cbAll.Checked = True Then
            txtDate.Enabled = False
            Pop(d, ds, "select * from ActivityLogs ORDER BY ID DESC", "ActivityLogs", GridControl1)
            GridView1.Columns(0).Visible = False
            GridView1.Columns(4).Visible = False
            GridView1.Columns(5).Visible = False
            GridView1.Columns(1).Width = 136
            GridView1.Columns(2).Width = 380
            GridView1.Columns(3).Width = 140
            GridView1.Columns(3).Caption = "Date"
            lblRec.Text = GridView1.RowCount & " Record(s) found."
        Else
            txtDate.Enabled = True
            Pop(d, ds, "select * from ActivityLogs where ADate like '%" & Trim(txtDate.Text) & "%' ORDER BY ID DESC", "ActivityLogs", GridControl1)
            GridView1.Columns(0).Visible = False
            GridView1.Columns(4).Visible = False
            GridView1.Columns(5).Visible = False
            GridView1.Columns(1).Width = 136
            GridView1.Columns(2).Width = 380
            GridView1.Columns(3).Width = 140
            GridView1.Columns(3).Caption = "Date"
            lblRec.Text = GridView1.RowCount & " Record(s) found."
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If cbAll.Checked Then
            Reports.opt = "ActivityLogs"
        Else
            Reports.opt = "ActivityLogsFiltered"
        End If

        Reports.ShowDialog()
    End Sub

    Dim offset As Integer = 0
    Private Sub ActivityLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            offset = 0
            cbAll.Checked = False
            Pop(d, ds, "select * from ActivityLogs where ADate like '%" & Trim(txtDate.Text) & "%' ORDER BY ID DESC", "ActivityLogs", GridControl1)
            GridView1.Columns(0).Visible = False
            GridView1.Columns(4).Visible = False
            GridView1.Columns(5).Visible = False
            GridView1.Columns(1).Width = 136
            GridView1.Columns(2).Width = 380
            GridView1.Columns(3).Width = 140
            GridView1.Columns(3).Caption = "Date"
            lblRec.Text = GridView1.RowCount & " Record(s) found."
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class