Imports MySql.Data.MySqlClient
Public Class frmOPZone
    Dim d As MySqlDataAdapter, ds As DataSet
    Public opt As String
    Private Sub frmOPZone_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadZone()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Reports.opt = "HouseholdZone"
        Reports.ShowDialog()
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
End Class