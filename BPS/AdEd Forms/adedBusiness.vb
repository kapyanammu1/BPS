Imports MySql.Data.MySqlClient
Public Class adedBusiness
    Dim d As MySqlDataAdapter, ds As DataSet
    Public adds As Boolean
    Private Sub adedBusiness_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadZone()
            If adds = True Then
                clear()
            Else
                Pop(d, ds, "select * from Business Where Id = " & txtID.Text & "", "Business")
                txtBusinessName.Text = ds.Tables("Business").Rows(0).Item(1)
                txtBusinessType.Text = ds.Tables("Business").Rows(0).Item(2)
                cbZone.Text = ds.Tables("Business").Rows(0).Item(3)
                txtProprietor.Text = ds.Tables("Business").Rows(0).Item(4)
                txtCStatus.Text = ds.Tables("Business").Rows(0).Item(5)
                txtAddress.Text = ds.Tables("Business").Rows(0).Item(6)
                cbStatus.Text = ds.Tables("Business").Rows(0).Item(7)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub clear()
        txtID.Clear()
        txtAddress.Clear()
        txtBusinessName.Clear()
        txtBusinessType.Clear()
        LoadZone()
        txtProprietor.Clear()
    End Sub
    Function LoadZone()
        cbZone.Items.Clear()
        Pop(d, ds, "select PurokName from Purok", "Purok")
        For i = 0 To ds.Tables("Purok").Rows.Count - 1
            If ds.Tables("Purok").Rows.Count > 0 Then
                cbZone.Items.Add(ds.Tables("Purok").Rows(i).Item(0))
            End If
        Next i
        Return True
    End Function
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            If txtBusinessName.Text = "" Or txtBusinessType.Text = "" Or txtProprietor.Text = "" Or cbZone.Text = "" Or txtAddress.Text = "" Or cbStatus.Text = "" Then
                MsgBox("Required Field Missing!", MsgBoxStyle.Critical, "System Message")
            Else
                Scan("Business", "where BusinessName = '" & txtBusinessName.Text & "' and ID <> " & Val(txtID.Text) & "")
                If queryResult1 > 0 Then
                    MsgBox("This Business already exist! Please enter another.", MsgBoxStyle.Critical, "Duplicate Record")
                Else
                    If adds = True Then
                        insert("Business", "BusinessName,BusinessType,Purok,Proprietor,CivilStatus,Address,Status", "'" & txtBusinessName.Text _
                               & "','" & txtBusinessType.Text & "','" & cbZone.Text & "','" &
                               txtProprietor.Text & "','" & txtCStatus.Text & "','" & txtAddress.Text & "','" & cbStatus.Text & "'")
                        MsgBox("Record Saved!", MsgBoxStyle.Information, "System Message")
                        Form1.frmBusiness.reload()
                        clear()
                    Else
                        Edit("Business", "BusinessName='" & txtBusinessName.Text _
                                            & "',BusinessType='" & txtBusinessType.Text _
                                            & "',Purok='" & cbZone.Text _
                                            & "',Proprietor='" & txtProprietor.Text _
                                            & "',CivilStatus='" & txtCStatus.Text _
                                            & "',address='" & txtAddress.Text _
                                            & "',Status='" & cbStatus.Text _
                                            & "'", "where ID = " & txtID.Text & "")
                        MsgBox("Record Updated!", MsgBoxStyle.Information, "System Message")
                        Form1.frmBusiness.reload()
                        Me.Close()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Something went wrong! Please Try Again!", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
End Class