Imports DevExpress.XtraEditors.Controls
Imports MySql.Data.MySqlClient
Public Class form100
    Dim d As MySqlDataAdapter, ds As DataSet
    Private Sub form100_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clear()
        txtDate.Text = Date.Now
    End Sub
    Function clear()
        txtofficer.Text = ""
        txtCaseNo.Text = ""
        txtOffice.Text = ""
        txtDwell.Text = ""
        rbInPerson.Checked = False
        rbRefuse.Checked = False
        rbDwell.Checked = False
        rbOffice.Checked = False
        txtDwell.Enabled = False
        txtOffice.Enabled = False
        Return True
    End Function
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If txtCaseNo.Text = "" Or txtofficer.Text = "" Then
            MsgBox("Required field missing!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        com = New MySqlCommand("insert into form100 (CaseNo,ServedDate,PrintDate,Officer,ServedBy,Dwell,Office) values ('" & txtCaseNo.Text _
            & "',@CDate,@PDate,'" & txtofficer.Text & "'," & txtServed.Text & ",'" & txtDwell.Text & "','" & txtOffice.Text & "')", MysqlConnect)
        com.Parameters.AddWithValue("@PDate", Date.Now)
        com.Parameters.AddWithValue("@CDate", txtDate.Value)
        com.ExecuteNonQuery()
        activity("SAVED AND PRINTED A OFFICER''S RETURN FORM CaseNo: " & txtCaseNo.Text)
        Reports.opt = "Form100"
        Reports.txtNo.Text = txtCaseNo.Text
        MsgBox("Record Saved!", MsgBoxStyle.Information, "System Message")
        clear()
        Reports.ShowDialog()
    End Sub
    Private Sub txtCaseNo_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtCaseNo.ButtonClick
        CaseSearch.opCase = "Form100"
        CaseSearch.ShowDialog()
    End Sub

    Private Sub rbRefuse_CheckedChanged(sender As Object, e As EventArgs) Handles rbRefuse.CheckedChanged
        If rbInPerson.Checked = True Then
            txtServed.Text = "2"
        End If
    End Sub

    Private Sub rbDwell_CheckedChanged(sender As Object, e As EventArgs) Handles rbDwell.CheckedChanged
        If rbDwell.Checked = True Then
            txtServed.Text = "3"
            txtDwell.Enabled = True
        Else
            txtDwell.Text = ""
            txtDwell.Enabled = False
        End If
    End Sub

    Private Sub rbOffice_CheckedChanged(sender As Object, e As EventArgs) Handles rbOffice.CheckedChanged
        If rbOffice.Checked = True Then
            txtServed.Text = "4"
            txtOffice.Enabled = True
        Else
            txtOffice.Text = ""
            txtOffice.Enabled = False
        End If
    End Sub

    Private Sub rbInPerson_CheckedChanged(sender As Object, e As EventArgs) Handles rbInPerson.CheckedChanged
        If rbInPerson.Checked = True Then
            txtServed.Text = "1"
        End If
    End Sub

    Private Sub txtofficer_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtofficer.ButtonClick
        Opt = "Form100"
        Search.ShowDialog()
    End Sub
    Private Sub txtDwell_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtDwell.ButtonClick
        Opt = "Form100Dwell"
        Search.ShowDialog()
    End Sub
    Private Sub txtOffice_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtOffice.ButtonClick
        Opt = "Form100Office"
        Search.ShowDialog()
    End Sub
    Private Sub form100_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form1.DashboardViewer1.Visible = True
    End Sub
End Class