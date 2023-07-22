Imports MySql.Data.MySqlClient
Imports System.IO
Public Class backUp
    Dim d As MySqlDataAdapter, ds As DataSet, bi As New BindingSource, dt As New DataTable
    Private Sub backUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dbFile As String
        Try
            SaveFileDialog1.Filter = "SQL Dump File (*.sql)|*.sql|all files (*.*)|*.*"
            SaveFileDialog1.FileName = "Database Backup " + DateTime.Now.ToString("yyyy-MM-dd") + ".sql"
            If SaveFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                CONNECTION()
                dbFile = SaveFileDialog1.FileName
                Dim backUpProccess As New Process
                backUpProccess.StartInfo.FileName = "cmd.exe"
                backUpProccess.StartInfo.UseShellExecute = False
                backUpProccess.StartInfo.WorkingDirectory = "C:\Program Files (x86)\MySQL\MySQL Server 5.0\bin"
                backUpProccess.StartInfo.RedirectStandardInput = True
                backUpProccess.StartInfo.RedirectStandardOutput = True
                backUpProccess.Start()
                Dim backupstream As StreamWriter = backUpProccess.StandardInput
                Dim StreamReader As StreamReader = backUpProccess.StandardOutput
                backupstream.WriteLine("mysqldump -uroot -pkapyanammuPassword -hlocalhost brgydata > """ + dbFile + """")
                backupstream.Close()
                backUpProccess.WaitForExit()
                backUpProccess.Close()
                MsgBox("Database backup Successfull!", MsgBoxStyle.Information, "Success!")
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim dbFile As String
        Try
            OpenFileDialog1.Filter = "SQL Dump File (*.sql)|*.sql|all files (*.*)|*.*"
            If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                CONNECTION()
                dbFile = OpenFileDialog1.FileName
                Dim backUpProccess As New Process
                backUpProccess.StartInfo.FileName = "cmd.exe"
                backUpProccess.StartInfo.UseShellExecute = False
                backUpProccess.StartInfo.WorkingDirectory = "C:\Program Files (x86)\MySQL\MySQL Server 5.0\bin"
                backUpProccess.StartInfo.RedirectStandardInput = True
                backUpProccess.StartInfo.RedirectStandardOutput = True
                backUpProccess.Start()
                Dim backupstream As StreamWriter = backUpProccess.StandardInput
                Dim StreamReader As StreamReader = backUpProccess.StandardOutput
                backupstream.WriteLine("mysql -uroot -pkapyanammuPassword -hlocalhost brgydata < """ + dbFile + """")
                backupstream.Close()
                backUpProccess.WaitForExit()
                backUpProccess.Close()
                MsgBox("Databse Resored!", MsgBoxStyle.Information, "Success!")
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class