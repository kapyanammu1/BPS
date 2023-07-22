Imports MySql.Data.MySqlClient
Public Class adedReligion
    Dim d As MySqlDataAdapter, ds As DataSet
    Public adds As Boolean
    Private Sub clear()
        txtID.Text = ""
        txtReligion.Text = ""
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            If txtReligion.Text = "" Then
                MsgBox("Required Field Missing!", MsgBoxStyle.Critical, "System Message")
            Else
                Scan("Religion", "where Religion = '" & txtReligion.Text & "' and ID <> " & Val(txtID.Text) & "")
                If queryResult1 > 0 Then
                    MsgBox("This Religion already exist! Please enter another.", MsgBoxStyle.Critical, "Duplicate Record")
                Else
                    If adds = True Then
                        insert("Religion", "Religion", "'" & txtReligion.Text & "'")
                        MsgBox("Record Saved!", MsgBoxStyle.Information, "System Message")
                        Form1.frmReligion.reload()
                        clear()
                    Else

                        Edit("Religion", "Religion='" & txtReligion.Text & "'", "where ID = " & txtID.Text & "")
                        MsgBox("Record Updated!", MsgBoxStyle.Information, "System Message")
                        Form1.frmReligion.reload()
                        clear()
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
    Private Sub adedReligion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If adds = True Then
                clear()
            Else
                Pop(d, ds, "select * from Religion Where Id = " & txtID.Text & "", "Religion")
                txtReligion.Text = ds.Tables("Religion").Rows(0).Item(1)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class