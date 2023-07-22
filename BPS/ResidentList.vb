Public Class ResidentList
    Private Sub ResidentList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbAll.Checked = True
        GridView1.Columns.Clear()
        Bar1.Visible = False
        'GroupControl1.Visible = False
        GridControl1.BringToFront()
        loadZone()
        Search()
        txtTo.Text = "1"
        txtTo.Enabled = False
    End Sub
    Public Overrides Sub IDval()

    End Sub
    Function loadZone()
        cboZone.Items.Clear()
        cboZone.Items.Add("")
        Pop(d, ds, "select PurokName from Purok", "Purok")
        If ds.Tables("Purok").Rows.Count > 0 Then
            For i = 0 To ds.Tables("Purok").Rows.Count - 1
                cboZone.Items.Add(ds.Tables("Purok").Rows(i).Item(0))
            Next i
        End If
        Return True
    End Function
    Public Overrides Sub Search()
        Try
            Pop(d, ds, "select ID, Fullname, Gender, Address, ContactNo, Birthdate, BirthPlace, CivilStatus, Religion, Purok from Resident where (Fullname like '%" & txtSearch1.Text & "%' and Purok like '%" & Trim(cboZone.Text) & "%') and (archive = 0 " & txtfilter.Text & ")", "Resident", GridControl1)
            GridView1.Columns(0).Visible = False
            GridView1.BestFitColumns()
            lblRec1.Text = ds.Tables("Resident").Rows.Count & " record(s) found"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub OFW_CheckedChanged(sender As Object, e As EventArgs) Handles OFW.CheckedChanged
        txtfilter.Text = " and OFW = 1 and Deceased = 0"
    End Sub
    Private Sub PWD_CheckedChanged(sender As Object, e As EventArgs) Handles PWD.CheckedChanged
        txtfilter.Text = " and PWD = 1 and Deceased = 0"
    End Sub
    Private Sub DP_CheckedChanged(sender As Object, e As EventArgs) Handles DP.CheckedChanged
        txtfilter.Text = " and DP = 1 and Deceased = 0"
    End Sub
    Private Sub SP_CheckedChanged(sender As Object, e As EventArgs) Handles SP.CheckedChanged
        txtfilter.Text = " and SP = 1 and Deceased = 0"
    End Sub
    Private Sub rbCS_CheckedChanged(sender As Object, e As EventArgs) Handles rbCS.CheckedChanged
        txtfilter.Text = ""
        txtfilter.Text = " and Age >= 60 and Deceased = 0"
    End Sub
    Private Sub rbAll_CheckedChanged(sender As Object, e As EventArgs) Handles rbAll.CheckedChanged
        txtfilter.Text = " and Deceased = 0"
    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Search()
    End Sub
    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click

        If rbAll.Checked Then
            Reports.txt.Text = "List of Residents"
        ElseIf rbCS.Checked Then
            Reports.txt.Text = "List of Senior Citizen"
        ElseIf OFW.Checked Then
            Reports.txt.Text = "List of OFW"
        ElseIf OSY.Checked Then
            Reports.txt.Text = "List of Out of School Youth"
        ElseIf PWD.Checked Then
            Reports.txt.Text = "List of PWD"
        ElseIf DP.Checked Then
            Reports.txt.Text = "List of Dialysis Patients"
        ElseIf SP.Checked Then
            Reports.txt.Text = "List of Solo Parents"
        ElseIf NewBorn.Checked Then
            Reports.txt.Text = "List of New Born Babies"
        ElseIf Voter.Checked Then
            Reports.txt.Text = "List of Voters"
        ElseIf CR.Checked Then
            Reports.txt.Text = "List of Residents with CR"
        ElseIf Deceased.Checked Then
            Reports.txt.Text = "List of Deceased Resident"
        ElseIf Indigent.Checked Then
            Reports.txt.Text = "List of Indigent People (Monthly income below 5000)"
        End If
        Reports.opt = "Resident"
        Reports.cbPurok.Text = cboZone.Text
        Reports.txtNo.Text = txtfilter.Text
        Reports.ShowDialog()
    End Sub

    Private Sub NewBorn_CheckedChanged(sender As Object, e As EventArgs) Handles NewBorn.CheckedChanged
        If NewBorn.Checked = True Then
            txtTo.Enabled = True
        Else
            txtTo.Enabled = False
        End If
        txtfilter.Text = ""
        txtfilter.Text = " and Age <= " & Val(txtTo.Text) & " and Deceased = 0"
    End Sub
    Private Sub Indigent_CheckedChanged(sender As Object, e As EventArgs) Handles Indigent.CheckedChanged
        txtfilter.Text = " and Income <= 5000 and Deceased = 0"
    End Sub
    Private Sub cboZone_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboZone.SelectedIndexChanged

    End Sub
    Private Sub Deceased_CheckedChanged(sender As Object, e As EventArgs) Handles Deceased.CheckedChanged
        txtfilter.Text = " and Deceased = 1"
    End Sub
    Private Sub OSY_CheckedChanged(sender As Object, e As EventArgs) Handles OSY.CheckedChanged
        txtfilter.Text = " and OSY = 1 and Deceased = 0"
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

    End Sub

    Private Sub Voter_CheckedChanged(sender As Object, e As EventArgs) Handles Voter.CheckedChanged
        txtfilter.Text = " and Voter = 1 and Deceased = 0"
    End Sub

    Private Sub CR_CheckedChanged(sender As Object, e As EventArgs) Handles CR.CheckedChanged
        txtfilter.Text = " and CR = 1 and Deceased = 0"
    End Sub
    Private Sub txtTo_TextChanged(sender As Object, e As EventArgs) Handles txtTo.TextChanged
        txtfilter.Text = ""
        txtfilter.Text = " and Age <= " & Val(txtTo.Text) & " and Deceased = 0"
    End Sub
End Class