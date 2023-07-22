Imports DevExpress.XtraEditors.Controls
Imports MySql.Data.MySqlClient
Public Class form98
    Dim d As MySqlDataAdapter, ds As DataSet
    Private Sub form98_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clear()
    End Sub
    Function clear()
        txtName.Clear()
        txtCaseNo.Text = ""
        txtDate.Text = Date.Now
        txtPDate.Text = Date.Now
        Return True
    End Function
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If txtCaseNo.Text = "" Then
            MsgBox("Required field missing!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Pop(d, ds, "select ResidentID from brgyOfficials", "brgyOfficials")
        com = New MySqlCommand("insert into form98 (CaseNo,PrintDate,CDate,Cap) values ('" & txtCaseNo.Text _
            & "',@PDate,@CDate," & ds.Tables("brgyOfficials").Rows(0).Item(0) & ")", MysqlConnect)
        com.Parameters.AddWithValue("@CDate", txtDate.Value)
        com.Parameters.AddWithValue("@PDate", Date.Now)
        com.ExecuteNonQuery()
        activity("SAVED AND PRINTED A NOTICE OF HEARING FORM CaseNo: " & txtCaseNo.Text)
        Reports.opt = "Form98"
        Reports.txtNo.Text = txtCaseNo.Text
        MsgBox("Record Saved!", MsgBoxStyle.Information, "System Message")
        clear()
        Reports.ShowDialog()
    End Sub
    Private Sub txtCaseNo_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtCaseNo.ButtonClick
        CaseSearch.opCase = "Form98"
        CaseSearch.ShowDialog()
    End Sub

    Private Sub form98_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form1.DashboardViewer1.Visible = True
    End Sub
End Class