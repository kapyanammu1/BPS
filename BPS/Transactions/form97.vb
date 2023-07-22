Imports DevExpress.XtraEditors.Controls
Imports MySql.Data.MySqlClient
Public Class form97
    Dim d As MySqlDataAdapter, ds As DataSet
    Private Sub form97_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clear()
    End Sub
    Function clear()
        txtCaseNo.Clear()
        txtComplainant.Text = ""
        txtRespondent.Text = ""
        txtFor.Clear()
        txtRelief.Clear()
        txtStatement.Clear()
        txtDate.Text = Date.Now
        GetNo("CaseNo")
        Return True
    End Function
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If txtCaseNo.Text = "" Or txtComplainant.Text = "" Or txtRespondent.Text = "" Or txtRelief.Text = "" Or txtStatement.Text = "" Then
            MsgBox("Required field missing!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim count As String
        count = (Val(txtCaseNo.Text.Substring(6)) + 1).ToString("0000")
        Pop(d, ds, "select ResidentID from brgyOfficials", "brgyOfficials")
        com = New MySqlCommand("insert into form97 (CaseNo,ComplainantName,RespondentName,Forr,Complaint,Relief,CDate,Cap) values ('" & txtCaseNo.Text _
            & "', '" & txtComplainant.Text & "','" & txtRespondent.Text & "','" & txtFor.Text _
               & "','" & txtStatement.Text & "','" & txtRelief.Text & "',@Date," & ds.Tables("brgyOfficials").Rows(0).Item(0) & ")", MysqlConnect)
        com.Parameters.AddWithValue("@Date", txtDate.Value)
        com.ExecuteNonQuery()
        activity("SAVED AND PRINTED A Complainant Form CaseNo: " & txtCaseNo.Text)
        Edit("Count", "CaseNo = '" & count & "'", "")
        Reports.opt = "Form97"
        Reports.txtNo.Text = txtCaseNo.Text

        MsgBox("Record Saved!", MsgBoxStyle.Information, "System Message")
        clear()
        Reports.ShowDialog()
    End Sub
    Private Sub GetNo(ByVal field As String)
        Pop(d, ds, "select " & field & " from count", "count")
        txtCaseNo.Text = Date.Now.Year & "-" & ds.Tables("count").Rows(0).Item(0)
    End Sub
    Private Sub txtComplainant_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtComplainant.ButtonClick
        Opt = "Form97Comp"
        Search.ShowDialog()
    End Sub
    Private Sub txtRespondent_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtRespondent.ButtonClick
        Opt = "Form97Resp"
        Search.ShowDialog()
    End Sub

    Private Sub form97_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form1.DashboardViewer1.Visible = True
    End Sub
End Class