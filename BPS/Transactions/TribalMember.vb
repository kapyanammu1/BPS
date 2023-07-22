Imports DevExpress.XtraEditors.Controls
Imports MySql.Data.MySqlClient
Public Class TribalMember
    Dim d As MySqlDataAdapter, ds As DataSet
    Private Sub TribalMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCTCDate.Text = Date.Now
        txtORDate.Text = Date.Now
        clear()
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            If txtRes.Text = Trim("") Or txtCTC.Text = Trim("") Then
                MsgBox("Required Field Missing!", MsgBoxStyle.Exclamation, "System Message")
            Else
                If txtCTCAmount.Text = "" Then
                    txtCTCAmount.Text = "0"
                End If
                If txtOrAmount.Text = "" Then
                    txtOrAmount.Text = "0"
                End If
                Dim count As String
                count = (Val(txtNo.Text.Substring(6)) + 1).ToString("0000")

                Pop(d, ds, "select ResidentID from brgyOfficials", "brgyOfficials")
                com = New MySqlCommand("insert into TribalMember (No,ResidentID,MotherID,Cap,kag1,kag2,kag3,kag4,kag5,kag6,kag7,sec,tres,reckeeper,Sk,Tribe,ORno,ORAmount,ORDate,CTC,CTCAmount,CTCDate,PrintDate) values ('" & txtNo.Text _
                       & "'," & txtResID.Text & "," & txtMotherID.Text & "," & ds.Tables("brgyOfficials").Rows(0).Item(0) & "," & ds.Tables("brgyOfficials").Rows(4).Item(0) _
                       & "," & ds.Tables("brgyOfficials").Rows(5).Item(0) & "," & ds.Tables("brgyOfficials").Rows(6).Item(0) _
                       & "," & ds.Tables("brgyOfficials").Rows(7).Item(0) & "," & ds.Tables("brgyOfficials").Rows(8).Item(0) & "," & ds.Tables("brgyOfficials").Rows(9).Item(0) _
                       & "," & ds.Tables("brgyOfficials").Rows(10).Item(0) & "," & ds.Tables("brgyOfficials").Rows(1).Item(0) _
                       & "," & ds.Tables("brgyOfficials").Rows(2).Item(0) & "," & ds.Tables("brgyOfficials").Rows(3).Item(0) _
                       & "," & ds.Tables("brgyOfficials").Rows(11).Item(0) & ",'" & txtTribal.Text & "','" & txtORno.Text & "'," & txtOrAmount.Text & ",'" & txtORDate.Text & "','" & txtCTC.Text _
                       & "'," & txtCTCAmount.Text & ",'" & txtCTCDate.Text & "',@PDate)", MysqlConnect)
                com.Parameters.AddWithValue("@PDate", Date.Now)
                com.ExecuteNonQuery()

                activity("SAVED AND PRINTED A CERTIFICATE OF TRIBAL MEMBERSHIP FOR " & txtRes.Text)
                Edit("Count", "CertificateNo = '" & count & "'", "")
                Reports.opt = "TribalMember"

                Reports.txtNo.Text = txtNo.Text

                MsgBox("Record Saved!", MsgBoxStyle.Information, "System Message")
                clear()
                Reports.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtResID_TextChanged(sender As Object, e As EventArgs) Handles txtResID.TextChanged
        Pop(d, ds, "select FulLname from Resident where ID = " & Val(txtResID.Text) & "", "Resident")
        If ds.Tables("Resident").Rows.Count > 0 Then
            txtRes.Text = ds.Tables("Resident").Rows(0).Item(0)
        Else
            txtRes.Text = ""
        End If

    End Sub
    Function clear()
        txtCTC.Clear()
        txtRes.Text = ""
        txtMother.Text = ""
        txtResID.Text = ""
        txtMotherID.Text = ""
        'cbType.SelectedIndex = 0
        txtCTCAmount.Text = "0.00"
        txtOrAmount.Text = "0.00"
        txtTribal.Text = ""
        txtORno.Clear()
        GetNo("CertificateNo")
        Return True
    End Function
    Private Sub GetNo(ByVal field As String)
        Pop(d, ds, "select " & field & " from count", "count")
        txtNo.Text = Date.Now.Year & "-" & ds.Tables("count").Rows(0).Item(0)
    End Sub

    Private Sub txtMotherID_TextChanged(sender As Object, e As EventArgs) Handles txtMotherID.TextChanged
        Pop(d, ds, "select FulLname from Resident where ID = " & Val(txtResID.Text) & "", "Resident")
        If ds.Tables("Resident").Rows.Count > 0 Then
            txtMother.Text = ds.Tables("Resident").Rows(0).Item(0)
        Else
            txtMother.Text = ""
        End If
    End Sub

    Private Sub txtRes_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtRes.ButtonClick
        Opt = "TribalMember"
        Search.ShowDialog()
    End Sub
    Private Sub txtMother_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtMother.ButtonClick
        Opt = "Mother"
        Search.ShowDialog()
    End Sub
    Private Sub TribalMember_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form1.DashboardViewer1.Visible = True
    End Sub
End Class