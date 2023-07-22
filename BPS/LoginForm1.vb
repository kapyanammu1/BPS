Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO, MadMilkman, MadMilkman.Ini
Public Class LoginForm1
    Dim d As MySqlDataAdapter, ds As DataSet
    Dim startpath As String = Application.StartupPath
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Pop(d, ds, "select * from users where username='" & txtUsername.Text & "' and pword = '" & encrypt() & "'", "users")
        'Scan("users", "where Username = '" & txtUsername.Text & "' and pword = '" & encrypt() & "'")
        If ds.Tables("users").Rows.Count > 0 Then
            Form1.lblAcclvl.Caption = ds.Tables("users").Rows(0).Item("Accesslvl")
            Form1.lblUser.Caption = txtUsername.Text
            Call clear()
            Form1.ShowDialog()
        Else
            MsgBox("Username and Password did not match. Please Try again.", MsgBoxStyle.Critical)
        End If
    End Sub
    Function encrypt()
        Dim plaintext As String = txtPassword.Text
        Dim password As String = "Kapyanammu"
        Dim wrapper As New Simple3Des(password)
        Dim cipherText As String = wrapper.encryptData(plaintext)
        Return cipherText
    End Function
    Sub clear()
        txtPassword.Clear()
        txtUsername.Clear()
    End Sub
    Sub endis(ByVal bol As Boolean)
        txtPassword.Enabled = bol
        txtUsername.Enabled = bol
        OK.Enabled = bol
        Cancel.Enabled = bol
    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub
    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Focus()
        txtUsername.Select()
        Try
            Dim INI As New IniFile
            INI.Load(startpath & "\Kons.ini")
            My.Settings.Server = INI.Sections("Connection").Keys("Server").Value.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Call CONNECTION()
        Try
            Pop(d, ds, "select ID,Birthdate from Resident where birthdate like '%" & Date.Now.ToString("MM/dd/") & "%'", "Resident")
            For i As Integer = 0 To ds.Tables("Resident").Rows.Count - 1
                Dim ResID, Age As Integer
                ResID = ds.Tables("Resident").Rows(i).Item(0)
                txtBday.Text = ds.Tables("Resident").Rows(i).Item(1)
                If (Month(Date.Today) > Month(txtBday.Value)) Then
                    Age = DateDiff(DateInterval.Year, txtBday.Value, Date.Now)
                ElseIf (Month(Date.Today) = Month(txtBday.Value)) Then
                    If (Date.Today.Day >= txtBday.Value.Day) Then
                        Age = DateDiff(DateInterval.Year, txtBday.Value, Date.Now)
                    Else
                        Age = DateDiff(DateInterval.Year, txtBday.Value, Date.Now) - 1
                    End If
                Else
                    Age = DateDiff(DateInterval.Year, txtBday.Value, Date.Now) - 1
                End If
                Edit("Resident", "age=" & Age & "", "where ID = " & ResID & "")
            Next i
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
