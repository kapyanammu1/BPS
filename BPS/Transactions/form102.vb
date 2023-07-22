Imports DevExpress.XtraEditors.Controls
Imports MySql.Data.MySqlClient
Public Class form102
    Dim d As MySqlDataAdapter, ds As DataSet
    Private Sub form102_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clear()
    End Sub
    Function clear()
        txtChosen.Text = ""
        txtCaseNo.Text = ""
        Return True
    End Function
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If txtCaseNo.Text = "" Then
            MsgBox("Required field missing!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Pop(d, ds, "select ResidentID from brgyOfficials", "brgyOfficials")
        com = New MySqlCommand("insert into form102 (CaseNo,Chosen,PrintDate,Cap) values ('" & txtCaseNo.Text _
            & "','" & txtChosen.Text & "',@PDate," & ds.Tables("brgyOfficials").Rows(0).Item(0) & ")", MysqlConnect)
        com.Parameters.AddWithValue("@PDate", Date.Now)
        com.ExecuteNonQuery()
        activity("SAVED AND PRINTED A NOTICE TO CHOSEN PANGKAT MEMBER FORM CaseNo: " & txtCaseNo.Text)
        Reports.opt = "Form102"
        Reports.txtNo.Text = txtCaseNo.Text
        MsgBox("Record Saved!", MsgBoxStyle.Information, "System Message")
        clear()
        Reports.ShowDialog()
    End Sub
    Private Sub txtCaseNo_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtCaseNo.ButtonClick
        CaseSearch.opCase = "Form102"
        CaseSearch.ShowDialog()
    End Sub
    Private Sub txtchosen_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtChosen.ButtonClick
        Opt = "Form102"
        Search.ShowDialog()
    End Sub

    Private Sub form102_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form1.DashboardViewer1.Visible = True
    End Sub
End Class