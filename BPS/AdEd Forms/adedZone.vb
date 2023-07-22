Imports MySql.Data.MySqlClient
Public Class adedZone
    Dim d As MySqlDataAdapter, ds As DataSet
    Public adds As Boolean
    Private Sub adedZone_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If adds = True Then

                clear()
            Else
                Pop(d, ds, "select * from Purok Where Id = " & txtID.Text & "", "Purok")
                txtZone.Text = ds.Tables("Purok").Rows(0).Item(1)
                txtDesc.Text = ds.Tables("Purok").Rows(0).Item(2)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            If txtZone.Text = "" Then
                MsgBox("Required Field Missing!", MsgBoxStyle.Critical, "System Message")
            Else
                Scan("purok", "where PurokName = '" & txtZone.Text & "' and ID <> " & Val(txtID.Text) & "")
                If queryResult1 > 0 Then
                    MsgBox("This Purok already exist! Please enter another.", MsgBoxStyle.Critical, "Duplicate Record")
                Else
                    If adds = True Then
                        insert("Purok", "PurokName,Description,Population", "'" & txtZone.Text & "','" & txtDesc.Text & "'," & 0 & "")
                        MsgBox("Record Saved!", MsgBoxStyle.Information, "System Message")
                        Form1.frmZone.reload()
                        clear()
                    Else
                        Edit("Purok", "PurokName='" & txtZone.Text & "',Description='" & txtDesc.Text & "'", "where ID = " & txtID.Text & "")
                        MsgBox("Record Updated!", MsgBoxStyle.Information, "System Message")
                        Form1.frmZone.reload()
                        Me.Close()
                    End If

                End If

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub

    Private Sub clear()
        txtID.Clear()
        txtZone.Clear()
        txtDesc.Clear()
    End Sub
End Class