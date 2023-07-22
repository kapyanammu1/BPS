Imports DevExpress.XtraEditors.Controls
Imports MySql.Data.MySqlClient
Public Class Certificate
    Dim d, d1 As MySqlDataAdapter, ds, ds1 As DataSet
    Private Sub Certificate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtORDate.Text = Date.Now
        txtCTCDate.Text = Date.Now
        clear()
        If txttbl.Text = "Indigency" Then
            Me.Text = "CERTIFICATE OF INDIGENCY"
        ElseIf txttbl.Text = "GoodMoral" Then
            Me.Text = "CERTIFICATE OF GOOD MORAL"
        ElseIf txttbl.Text = "Residency" Then
            Me.Text = "CERTIFICATE OF RESIDENCY"
        End If
    End Sub
    Function clear()
        txtPurpose.Clear()
        txtRes.Text = ""
        txtResID.Clear()
        txtOpt.Clear()
        txtOrAmount.Text = 0.00
        txtCTC.Clear()
        txtCTCAmount.Text = 0.00
        txtORno.Clear()
        GetNo("CertificateNo")
        Return True
    End Function
    Private Sub txtResID_TextChanged(sender As Object, e As EventArgs) Handles txtResID.TextChanged
        Pop(d, ds, "select FulLname from Resident where ID = " & Val(txtResID.Text) & "", "Resident")
        If ds.Tables("Resident").Rows.Count > 0 Then
            txtRes.Text = ds.Tables("Resident").Rows(0).Item(0)
        Else
            txtRes.Text = ""
        End If
    End Sub
    Private Sub GetNo(ByVal field As String)
        Pop(d, ds, "select " & field & " from count", "count")
        txtNo.Text = Date.Now.Year & "-" & ds.Tables("count").Rows(0).Item(0)
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Try
            If txtCTCAmount.Text = "" Then
                txtCTCAmount.Text = "0.00"
            End If
            If txtOrAmount.Text = "" Then
                txtOrAmount.Text = "0.00"
            End If

            If txtRes.Text = Trim("") Then
                MsgBox("Required Field Missing!", MsgBoxStyle.Exclamation, "System Message")
            Else
                Dim count As String
                count = (Val(txtNo.Text.Substring(6)) + 1).ToString("0000")
                Pop(d, ds, "select ResidentID from brgyOfficials", "brgyOfficials")
                com = New MySqlCommand("insert into " & txttbl.Text & " (" & txtdbNo.Text & ",ResidentID,Cap,kag1,kag2,kag3,kag4,kag5,kag6,kag7,sec,tres,reckeeper,SK,Purpose,ORno,ORAmount,ORDate,CTC,CTCAmount,CTCDate,PrintDate) values ('" & txtNo.Text _
                       & "'," & txtResID.Text & "," & ds.Tables("brgyOfficials").Rows(0).Item(0) & "," & ds.Tables("brgyOfficials").Rows(4).Item(0) _
                       & "," & ds.Tables("brgyOfficials").Rows(5).Item(0) & "," & ds.Tables("brgyOfficials").Rows(6).Item(0) _
                       & "," & ds.Tables("brgyOfficials").Rows(7).Item(0) & "," & ds.Tables("brgyOfficials").Rows(8).Item(0) & "," & ds.Tables("brgyOfficials").Rows(9).Item(0) _
                       & "," & ds.Tables("brgyOfficials").Rows(10).Item(0) & "," & ds.Tables("brgyOfficials").Rows(1).Item(0) _
                       & "," & ds.Tables("brgyOfficials").Rows(2).Item(0) & "," & ds.Tables("brgyOfficials").Rows(3).Item(0) _
                       & "," & ds.Tables("brgyOfficials").Rows(11).Item(0) & ",'" & txtPurpose.Text & "','" & txtORno.Text & "'," & txtOrAmount.Text & ",'" & txtORDate.Text & "','" & txtCTC.Text _
                       & "'," & txtCTCAmount.Text & ",'" & txtCTCDate.Text & "',@PDate)", MysqlConnect)
                com.Parameters.AddWithValue("@PDate", Date.Now)
                com.ExecuteNonQuery()
                activity("" & txtActivity.Text & "" & txtRes.Text)
                Edit("Count", "CertificateNo = '" & count & "'", "")
                Reports.opt = txttbl.Text
                Reports.txtNo.Text = txtNo.Text
                MsgBox("Record Saved!", MsgBoxStyle.Information, "System Message")
                clear()
                Reports.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtRes_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtRes.ButtonClick
        Opt = "Certificate"
        Search.ShowDialog()
    End Sub

    Private Sub Certificate_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form1.DashboardViewer1.Visible = True
    End Sub
End Class