Imports MySql.Data.MySqlClient
Public Class adedUser
    Dim d As MySqlDataAdapter, ds As DataSet
    Public adds As Boolean = True
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub

    Private Sub adedUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If adds = True Then
            clear()
            txtOldPass.Enabled = False
        Else
            txtOldPass.Enabled = True
            Pop(d, ds, "select * from users where ID = " & Val(txtID.Text) & "", "Users")
            If ds.Tables("users").Rows.Count > 0 Then
                txtOldPass.Clear()
                txtNewPass.Clear()
                txtUsername.Text = ds.Tables("users").Rows(0).Item(1)
                cbAcclvl.Text = ds.Tables("users").Rows(0).Item(3)
            End If
        End If
    End Sub
    Sub clear()
        txtID.Clear()
        txtUsername.Clear()
        txtNewPass.Clear()
        txtConfirmPass.Clear()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If txtNewPass.Text.Length < 8 Then
            MsgBox("Password is too short! Password must be atleast 8 characters", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If txtNewPass.Text <> txtConfirmPass.Text Then
            MsgBox("Password did not match!", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If txtNewPass.Text = "" Or txtUsername.Text = "" Or cbAcclvl.Text = "" Then
            MsgBox("Required Field Missing!", MsgBoxStyle.Critical)
        Else
            Scan("users", "where Username = '" & txtUsername.Text & "' and ID <> " & Val(txtID.Text) & "")
            If queryResult1 > 0 Then
                MsgBox("Username already taken!", MsgBoxStyle.Critical)
            Else
                If adds = True Then

                    insert("users", "username,Pword,accesslvl", "'" & txtUsername.Text & "','" & encrypt(txtNewPass.Text) & "','" & cbAcclvl.Text & "'")
                    Form1.frmUsers.reload()
                    clear()
                    Me.Close()
                    MsgBox("User account saved!", MsgBoxStyle.Information)
                Else
                    Pop(d, ds, "select pword from Users where Id = " & Val(txtID.Text) & "", "users")
                    If ds.Tables("users").Rows(0).Item(0) = encrypt(txtOldPass.Text) Then
                        Edit("users", "username='" & txtUsername.Text & "',pword='" & encrypt(txtNewPass.Text) & "',accesslvl='" & cbAcclvl.Text & "'", "where ID = " & txtID.Text & "")
                        Form1.frmUsers.reload()
                        clear()
                        Me.Close()
                        MsgBox("User account Updated!", MsgBoxStyle.Information)
                    Else
                        MsgBox("Old Password did not match!", MsgBoxStyle.Critical)
                    End If

                End If

            End If

        End If
    End Sub

    Function encrypt(ByVal txt As String)
        Dim plaintext As String = txt
        Dim password As String = "Kapyanammu"
        Dim wrapper As New Simple3Des(password)
        Dim cipherText As String = wrapper.encryptData(plaintext)
        Return cipherText
    End Function
End Class