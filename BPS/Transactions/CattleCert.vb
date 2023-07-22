Imports DevExpress.XtraEditors.Controls
Imports MySql.Data.MySqlClient
Public Class CattleCert
    Dim d As MySqlDataAdapter, ds As DataSet
    Private Sub CattleCert_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtDate.Text = Date.Now
        clear()
    End Sub
    Function clear()
        txtPurpose.Clear()
        txtRes.Text = ""
        txtResID.Clear()
        txtCattle.Clear()
        txtActivity.Clear()
        txtAddress.Clear()
        txtVendee.Clear()
        txtOpt.Clear()
        txtAge.Text = 0
        cbCattleType.Items.Clear()
        cbCattleType.Items.Add("Branded")
        cbCattleType.Items.Add("Unbranded")
        cbGender.Items.Clear()
        cbGender.Items.Add("Male")
        cbGender.Items.Add("Female")
        GetNo("CattleNo")
        Return True
    End Function
    Private Sub GetNo(ByVal field As String)
        Pop(d, ds, "select " & field & " from count", "count")
        txtNo.Text = ds.Tables("count").Rows(0).Item(0)
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Try
            If txtAge.Text = "" Then
                txtAge.Text = 0
            End If
            If txtRes.Text = Trim("") Or txtPurpose.Text = Trim("") Or txtCattle.Text = Trim("") Or txtAddress.Text = Trim("") Or txtAge.Text = Trim("") Or cbCattleType.Text = Trim("") Or cbGender.Text = Trim("") Then
                MsgBox("Required Field Missing!", MsgBoxStyle.Exclamation, "System Message")
            Else
                Dim count As String
                count = (Val(txtNo.Text) + 1).ToString("000000")
                Pop(d, ds, "select ResidentID from brgyOfficials", "brgyOfficials")
                insert("" & txttbl.Text & "", "" & txtdbNo.Text & ",ResidentID,Vendee,VendeeAddress,Cattle,Type,Gender,Age,Cap,Purpose,CDate,Term", "'" & txtNo.Text & "'," & txtResID.Text & ",'" & txtVendee.Text & "','" &
                       txtAddress.Text & "','" &
                       txtCattle.Text & "','" &
                       cbCattleType.Text & "','" &
                       cbGender.Text & "','" &
                       txtAge.Text & "'," &
                       ds.Tables("brgyOfficials").Rows(0).Item(0) & ",'" &
                       txtPurpose.Text & "','" & txtDate.Text & "','" & "2018-2021" & "'")
                activity("" & txtActivity.Text & "" & txtRes.Text)
                Edit("Count", "" & txtdbNo.Text & " = '" & count & "'", "")
                Reports.opt = txttbl.Text
                Reports.txtNo.Text = txtNo.Text
                MsgBox("Record Saved!", MsgBoxStyle.Information, "System Message")
                clear()
                Reports.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox("Invalid Input! Please Try again!", MsgBoxStyle.Critical, "Invalid Input")
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
    Private Sub txtAge_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAge.KeyPress
        NumbersOnly(e)
    End Sub
    Private Sub txtCattle_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCattle.KeyPress
        LettersOnly(e)
    End Sub
    Private Sub txtVendee_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVendee.KeyPress
        LettersOnly(e)
    End Sub
    Private Sub txtRes_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtRes.ButtonClick
        Opt = "Cattle"
        Search.ShowDialog()
    End Sub
    Private Sub CattleCert_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form1.DashboardViewer1.Visible = True
    End Sub
End Class