Imports DevExpress.XtraEditors.Controls
Imports MySql.Data.MySqlClient

Public Class UpdateOfficials
    Dim d As MySqlDataAdapter, ds As DataSet
    Private Sub ButtonEdit1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtName.ButtonClick
        Opt = "UpdOfficials"
        Search.ShowDialog()
    End Sub
    Friend Shared Function UpdateOfficials() As Object
        Throw New NotImplementedException()
    End Function
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            Pop(d, ds, "select ID from brgyOfficials where ResidentID = " & txtResID.Text & " and ID <> " & txtOID.Text & "", "brgyOfficials")
            If ds.Tables("brgyOfficials").Rows.Count > 0 Then
                MsgBox("This Resident is already a brgy officals.", MsgBoxStyle.Critical, "Invalid input.")
            Else
                Edit("brgyOfficials", "ResidentID =" & txtResID.Text & "", "where ID = " & txtOID.Text & "")
                MainForm.formOfficials.reload()
                MsgBox("Record Saved!", MsgBoxStyle.Information, "Saved Successfully!")
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtName_EditValueChanged(sender As Object, e As EventArgs) Handles txtName.EditValueChanged
        If txtName.Text = "" Then
            txtResID.Text = "0"
        End If
    End Sub

    Private Sub UpdateOfficials_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtResID_TextChanged(sender As Object, e As EventArgs) Handles txtResID.TextChanged
        Pop(d, ds, "select Fullname, image from Resident where ID = " & txtResID.Text & "", "Resident")
        If ds.Tables("resident").Rows.Count > 0 Then
            txtName.Text = ds.Tables("Resident").Rows(0).Item(0).ToString

            Try
                Dim mstream As New System.IO.MemoryStream()
                Dim photo As Byte() = ds.Tables("Resident").Rows(0).Item("Image")
                Dim lstr As New System.IO.MemoryStream(photo)
                PictureEdit1.Image = Image.FromStream(lstr)
                mstream.Close()
            Catch ex As Exception
                PictureEdit1.Image = Nothing
            End Try
        Else
            txtName.Text = ""
            PictureEdit1.Image = Nothing
        End If
    End Sub
End Class