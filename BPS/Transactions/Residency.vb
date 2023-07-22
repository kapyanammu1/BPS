﻿Imports DevExpress.XtraEditors.Controls
Imports MySql.Data.MySqlClient
Public Class Residency
    Dim d As MySqlDataAdapter, ds As DataSet
    Public clearances As Boolean
    Private Sub Residency_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDate.Text = Date.Now
        clear()
        If clearances = True Then
            Me.Text = "BARANGAY CLEARANCE"
        Else
            Me.Text = "CERTIFICATE OF INDIGENCY"
        End If
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            If txtRes.Text = Trim("") Or txtCTC.Text = Trim("") Then
                MsgBox("Required Field Missing!", MsgBoxStyle.Exclamation, "System Message")
            Else
                If txtAmount.Text = "" Then
                    MsgBox("Invalid Amount!", MsgBoxStyle.Critical)
                    txtAmount.Focus()
                    Exit Sub
                End If
                Dim count As String
                count = (Val(txtNo.Text.Substring(6)) + 1).ToString("0000")

                Pop(d, ds, "select ResidentID from brgyOfficials", "brgyOfficials")
                insert("Residency", "ResidencyNo,ResidentID,Cap,kag1,kag2,kag3,kag4,kag5,kag6,kag7,sec,tres,reckeeper,Purpose,CDate,CTC,Amount,Orno,PrintDate,CTCDate", "'" & txtNo.Text & "'," & txtResID.Text & "," &
                       ds.Tables("brgyOfficials").Rows(0).Item(0) & "," & ds.Tables("brgyOfficials").Rows(4).Item(0) _
                       & "," & ds.Tables("brgyOfficials").Rows(5).Item(0) & "," & ds.Tables("brgyOfficials").Rows(6).Item(0) _
                       & "," & ds.Tables("brgyOfficials").Rows(7).Item(0) & "," & ds.Tables("brgyOfficials").Rows(8).Item(0) & "," & ds.Tables("brgyOfficials").Rows(9).Item(0) _
                       & "," & ds.Tables("brgyOfficials").Rows(10).Item(0) & "," & ds.Tables("brgyOfficials").Rows(1).Item(0) _
                       & "," & ds.Tables("brgyOfficials").Rows(2).Item(0) & "," & ds.Tables("brgyOfficials").Rows(3).Item(0) _
                       & ",'" & txtPurpose.Text & "','" & txtDate.Text & "','" & txtCTC.Text _
                       & "'," & txtAmount.Text & ",'" & txtORno.Text & "','" & Date.Now & "','" & txtCTCDate.Text & "'")
                activity("SAVED AND PRINTED A CERTIFICATE OF RESIDENCY FOR " & txtRes.Text)
                Edit("Count", "CertificateNo = '" & count & "'", "")
                Reports.opt = "Residency"

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
        txtResID.Text = ""
        'cbType.SelectedIndex = 0
        txtAmount.Text = "0.00"
        txtPurpose.Text = ""
        GetNo("CertificateNo")
        Return True
    End Function
    Private Sub GetNo(ByVal field As String)
        Pop(d, ds, "select " & field & " from count", "count")
        txtNo.Text = Date.Now.Year & "-" & ds.Tables("count").Rows(0).Item(0)
    End Sub
    Private Sub txtRes_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtRes.ButtonClick
        Opt = "Residency"
        Search.ShowDialog()
    End Sub
    Private Sub Residency_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form1.DashboardViewer1.Visible = True
    End Sub
End Class