Imports DevExpress.XtraEditors.Controls
Imports MySql.Data.MySqlClient
Public Class adedBlotter
    Dim d, d1 As MySqlDataAdapter, ds, ds1 As DataSet
    Public adds As Boolean
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            If txtCN.Text = "" Or txtPTC.Text = "" Or txtPTC.Text = "" Or txtLocation.Text = "" Or txtStatement.Text = "" Or cbStatus.Text = "" Then
                MsgBox("Required Field Missing!", MsgBoxStyle.Exclamation, "System Message")
            Else
                If adds = True Then
                    Dim count As String
                    count = (Val(txtNo.Text) + 1).ToString("000000")
                    Edit("Count", "BlotterNo = '" & count & "'", "")
                    insert("Blotter", "BlotterNo,ComplianantID,PersontoComplainID,StatementOfComp,ActionTaken,Status,Locationofincidence,Bdate", "'" & txtNo.Text _
                                    & "'," & txtCNID.Text & ", " & txtPTCID.Text & ", '" & txtStatement.Text _
                                    & "', '" & txtaction.Text & "', '" & cbStatus.Text & "', '" & txtLocation.Text _
                                    & "', '" & txtDate.Text & "'")
                    activity("ADDED NEW A BLOTTER RECORD NO: " & txtNo.Text)
                    MsgBox("Record Saved!", MsgBoxStyle.Information, "System Message")
                    clear()
                Else

                    Edit("Blotter", "BlotterNo='" & txtNo.Text & "',ComplianantID = " & txtCNID.Text & ",persontocomplainID = " & txtPTCID.Text _
                             & ", StatementOfComp = '" & txtStatement.Text & "', ActionTaken = '" & txtaction.Text _
                             & "', status = '" & cbStatus.Text & "', LocationofIncidence = '" & txtLocation.Text _
                             & "', Bdate = '" & txtDate.Text & "'", "where Id = " & txtID.Text & "")
                    activity("UPDATED A BLOTTER RECORD NO: " & txtNo.Text)
                    MsgBox("Record Updated!", MsgBoxStyle.Information, "System Message")

                    Me.Close()



                End If
                Form1.frmBlotter.Reload()

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        Try
            If adds = True Then
                clear()
            Else
                Pop(d1, ds1, "select * from Blotter Where Id = " & Val(txtID.Text) & "", "Blotter")
                If ds1.Tables("Blotter").Rows.Count > 0 Then
                    txtNo.Text = ds1.Tables("Blotter").Rows(0).Item(1)
                    txtCNID.Text = ds1.Tables("Blotter").Rows(0).Item(2)
                    txtPTCID.Text = ds1.Tables("Blotter").Rows(0).Item(3)
                    txtStatement.Text = ds1.Tables("Blotter").Rows(0).Item(4)
                    txtaction.Text = ds1.Tables("Blotter").Rows(0).Item(5)
                    cbStatus.Text = ds1.Tables("Blotter").Rows(0).Item(6)
                    txtLocation.Text = ds1.Tables("Blotter").Rows(0).Item(7)
                    txtDate.Text = ds1.Tables("Blotter").Rows(0).Item(8)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtPTCID_TextChanged(sender As Object, e As EventArgs) Handles txtPTCID.TextChanged
        Pop(d, ds, "select Fullname from Resident Where Id = " & Val(txtPTCID.Text) & "", "Resident")
        If ds.Tables("Resident").Rows.Count > 0 Then
            txtPTC.Text = ds.Tables("Resident").Rows(0).Item(0)
        Else
            txtPTC.Text = ""
        End If
    End Sub

    Private Sub txtCNID_TextChanged(sender As Object, e As EventArgs) Handles txtCNID.TextChanged
        Pop(d, ds, "select Fullname from Resident Where Id = " & Val(txtCNID.Text) & "", "Resident")
        If ds.Tables("Resident").Rows.Count > 0 Then
            txtCN.Text = ds.Tables("Resident").Rows(0).Item(0)
        Else
            txtCN.Text = ""
        End If
    End Sub
    Private Sub clear()
        txtaction.Clear()
        txtCN.Text = ""
        txtCNID.Clear()
        txtID.Clear()
        txtLocation.Clear()
        txtPTC.Text = ""
        txtPTCID.Clear()
        txtStatement.Clear()
        cbStatus.Items.Clear()
        cbStatus.Items.Add("SOLVED")
        cbStatus.Items.Add("UNSOLVED")
    End Sub
    Private Sub adedBlotter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If adds = True Then
            clear()
            Pop(d, ds, "select Blotterno from count", "count")
            txtNo.Text = (Val(ds.Tables("Count").Rows(0).Item(0)) + 1).ToString("000000")
        Else
            ' Endis(False)
        End If
    End Sub
    Private Sub Endis(ByVal bol As Boolean)
        txtCN.Enabled = bol
        txtDate.Enabled = bol
        txtLocation.Enabled = bol
        txtNo.Enabled = bol
        txtPTC.Enabled = bol
        txtStatement.Enabled = bol
        cbStatus.Enabled = bol
        txtaction.Enabled = bol
        txtNo.Enabled = bol
    End Sub
    Private Sub txtCN_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtCN.ButtonClick
        Opt = "CN"
        Search.ShowDialog()
    End Sub
    Private Sub txtPTC_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtPTC.ButtonClick
        Opt = "PTC"
        Search.ShowDialog()
    End Sub
End Class