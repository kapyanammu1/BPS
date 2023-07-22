Imports DevExpress.XtraEditors.Controls
Imports MySql.Data.MySqlClient
Public Class frmAnimalTransport
    Dim d As MySqlDataAdapter, ds As DataSet
    Private Sub AnimalTransport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtORDate.Text = Date.Now
        txtCTCDate.Text = Date.Now
        txtTransDate.Text = Date.Now
        clear()
    End Sub
    Function clear()
        txtORno.Clear()
        txtRes.Text = ""
        txtID.Clear()
        txtPurpose.Clear()
        txtLocation.Clear()
        txtCTC.Clear()
        txtBrand.Clear()
        txtActivity.Clear()
        txtClass.Clear()
        txtOpt.Clear()
        txtColor.Clear()
        txtAge.Text = 0
        txtCTCAmount.Text = 0
        txtOrAmount.Text = 0
        txtORno.Clear()
        cbGender.Items.Clear()
        cbGender.Items.Add("Male")
        cbGender.Items.Add("Female")
        GetNo("ClearanceNo")
        Return True
    End Function
    Private Sub GetNo(ByVal field As String)
        Pop(d, ds, "select " & field & " from count", "count")
        txtNo.Text = Date.Now.Year & "-" & ds.Tables("count").Rows(0).Item(0)
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Try
            If txtAge.Text = "" Then
                txtAge.Text = 0
            End If
            If txtCTCAmount.Text = "" Then
                txtCTCAmount.Text = "0.00"
            End If
            If txtOrAmount.Text = "" Then
                txtOrAmount.Text = "0.00"
            End If
            If txtRes.Text = Trim("") Or txtORno.Text = Trim("") Or txtBrand.Text = Trim("") Or txtClass.Text = Trim("") Or txtAge.Text = Trim("") Or cbGender.Text = Trim("") Then
                MsgBox("Required Field Missing!", MsgBoxStyle.Exclamation, "System Message")
            Else
                Dim count As String
                count = (Val(txtNo.Text.Substring(6)) + 1).ToString("0000")
                Pop(d, ds, "select ResidentID from brgyOfficials", "brgyOfficials")
                com = New MySqlCommand("insert into AnimalTransport (No,AnimalID,ResidentID,Cap,kag1,kag2,kag3,kag4,kag5,kag6,kag7,sec,tres,reckeeper,SK,Purpose,Location,TransDate,ORno,ORAmount,ORDate,CTC,CTCAmount,CTCDate,PrintDate) values ('" &
                                       txtNo.Text & "'," & Val(txtID.Text) & "," & Val(txtResID.Text) & "," &
                                       ds.Tables("brgyOfficials").Rows(0).Item(0) & "," &
                                       ds.Tables("brgyOfficials").Rows(4).Item(0) & "," &
                                       ds.Tables("brgyOfficials").Rows(5).Item(0) & "," &
                                       ds.Tables("brgyOfficials").Rows(6).Item(0) & "," &
                                       ds.Tables("brgyOfficials").Rows(7).Item(0) & "," &
                                       ds.Tables("brgyOfficials").Rows(8).Item(0) & "," &
                                       ds.Tables("brgyOfficials").Rows(9).Item(0) & "," &
                                       ds.Tables("brgyOfficials").Rows(10).Item(0) & "," &
                                       ds.Tables("brgyOfficials").Rows(1).Item(0) & "," &
                                       ds.Tables("brgyOfficials").Rows(2).Item(0) & "," &
                                       ds.Tables("brgyOfficials").Rows(3).Item(0) & "," &
                                       ds.Tables("brgyOfficials").Rows(11).Item(0) & ",'" &
                                       txtPurpose.Text & "','" & txtLocation.Text & "','" & txtTransDate.Text & "','" &
                                       txtORno.Text & "'," & txtOrAmount.Text & ",'" & txtORDate.Text & "','" &
                                       txtCTC.Text & "'," & txtCTCAmount.Text & ",'" & txtCTCDate.Text & "',@PDate)", MysqlConnect)
                com.Parameters.AddWithValue("@PDate", Date.Now)
                com.ExecuteNonQuery()
                activity("" & txtActivity.Text & "" & txtRes.Text)
                Edit("Count", "ClearanceNo = '" & count & "'", "")
                Reports.opt = "AnimalTransport"
                Reports.txtNo.Text = txtNo.Text
                MsgBox("Record Saved!", MsgBoxStyle.Information, "System Message")
                clear()
                Reports.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Invalid Input")
        End Try
    End Sub
    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        Pop(d, ds, "select r.FullName, a.Brand, a.class, a.Color, a.Sex, a.Age, a.Cowlicks from Animal a LEFT JOIN Resident r ON r.ID=a.ResidentID where a.ID = " & Val(txtID.Text) & "", "Animal a")
        If ds.Tables("Animal a").Rows.Count > 0 Then
            txtRes.Text = ds.Tables("Animal a").Rows(0).Item(0)
            txtBrand.Text = ds.Tables("Animal a").Rows(0).Item(1)
            txtClass.Text = ds.Tables("Animal a").Rows(0).Item(2)
            txtColor.Text = ds.Tables("Animal a").Rows(0).Item(3)
            cbGender.Text = ds.Tables("Animal a").Rows(0).Item(4)
            txtAge.Text = ds.Tables("Animal a").Rows(0).Item(5)
            txtCowlicks.Text = ds.Tables("Animal a").Rows(0).Item(6)
        Else

        End If
    End Sub
    Private Sub txtAge_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAge.KeyPress
        NumbersOnly(e)
    End Sub
    Private Sub txtRes_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtRes.ButtonClick
        AnimalSearch.ShowDialog()
    End Sub
    Private Sub frmAnimalTransport_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form1.DashboardViewer1.Visible = True
    End Sub
End Class