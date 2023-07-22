﻿Imports DevExpress.XtraEditors.Controls
Imports MySql.Data.MySqlClient
Public Class BusinessClearance
    Dim d, d1 As MySqlDataAdapter, ds, ds1 As DataSet
    Private Sub BusinessClearance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clear()
    End Sub
    Function clear()
        txtNo.Clear()
        txtCTCAmount.Text = "0.00"
        txtOrAmount.Text = "0.00"
        txtID.Clear()
        txtCTC.Clear()
        txtORNo.Clear()
        txtORDate.Text = Date.Now
        txtCTCDate.Text = Date.Now
        GetNo("ClearanceNo")
        Return True
    End Function
    Private Sub GetNo(ByVal field As String)
        Pop(d, ds, "select " & field & " from count", "count")
        txtNo.Text = Date.Now.Year & "-" & ds.Tables("count").Rows(0).Item(0)
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            If cbType.Text = Trim("") Or txtNo.Text = Trim("") Or txtCTCAmount.Text = Trim("") Or txtOrAmount.Text = Trim("") Or txtCTC.Text = Trim("") Or txtORno.Text = Trim("") Then
                MsgBox("Required Field Missing!", MsgBoxStyle.Exclamation, "System Message")
            Else

                Dim count As String
                count = (Val(txtNo.Text.Substring(6)) + 1).ToString("0000")

                Pop(d, ds, "select ResidentID from brgyOfficials", "brgyOfficials")

                com = New MySqlCommand("insert into busclearance (clearanceNo,BusinessID,Cap,kag1,kag2,kag3,kag4,kag5,kag6,kag7,sec,tres,reckeeper,Sk,ClearanceType,ORno,ORAmount,ORDate,CTC,CTCAmount,CTCDate,PrintDate) values ('" & txtNo.Text & "'," & txtID.Text & "," &
                       ds.Tables("brgyOfficials").Rows(0).Item(0) & "," & ds.Tables("brgyOfficials").Rows(4).Item(0) _
                       & "," & ds.Tables("brgyOfficials").Rows(5).Item(0) & "," & ds.Tables("brgyOfficials").Rows(6).Item(0) _
                       & "," & ds.Tables("brgyOfficials").Rows(7).Item(0) & "," & ds.Tables("brgyOfficials").Rows(8).Item(0) & "," & ds.Tables("brgyOfficials").Rows(9).Item(0) _
                       & "," & ds.Tables("brgyOfficials").Rows(10).Item(0) & "," & ds.Tables("brgyOfficials").Rows(1).Item(0) _
                       & "," & ds.Tables("brgyOfficials").Rows(2).Item(0) & "," & ds.Tables("brgyOfficials").Rows(3).Item(0) _
                       & "," & ds.Tables("brgyOfficials").Rows(11).Item(0) & ",'" & cbType.Text & "','" & txtORno.Text & "'," & Val(txtOrAmount.Text) & ",'" & txtORDate.Text & "','" & txtCTC.Text _
                       & "'," & Val(txtCTCAmount.Text) & ",'" & txtCTCDate.Text & "',@PDate)", MysqlConnect)
                com.Parameters.AddWithValue("@PDate", Date.Now)
                com.ExecuteNonQuery()

                activity("SAVED AND PRINTED A BRGY BUSINESS CLEARANCE FOR " & txtBusinessName.Text)
                Edit("Count", "ClearanceNo = '" & count & "'", "")
                If cbType.Text = "MANAGEMENT BUSINESS" Then
                    Reports.opt = "MANAGEMENT"
                Else
                    Reports.opt = "CORPORATE"
                End If

                Reports.txtNo.Text = txtNo.Text

                MsgBox("Record Saved!", MsgBoxStyle.Information, "System Message")
                clear()
                Reports.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtORNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        NumbersOnly(e)
    End Sub
    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        Pop(d, ds, "select BusinessName from Business where ID = " & Val(txtID.Text) & "", "Business")
        If ds.Tables("Business").Rows.Count > 0 Then
            txtBusinessName.Text = ds.Tables("Business").Rows(0).Item(0)
        Else
            txtBusinessName.Text = ""
        End If
    End Sub
    Private Sub txtCedulaNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        NumbersOnly(e)
    End Sub
    Private Sub txtAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        NumbersOnly(e)
    End Sub
    Private Sub txtBusinessName_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtBusinessName.ButtonClick
        BusinessSearch.op = "BusinessClearance"
        BusinessSearch.ShowDialog()
    End Sub
    Private Sub BusinessClearance_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form1.DashboardViewer1.Visible = True
    End Sub
End Class