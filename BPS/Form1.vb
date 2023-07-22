Imports DevExpress.XtraTabbedMdi
Imports MySql.Data.MySqlClient
Public Class Form1
    Dim d As MySqlDataAdapter, ds As DataSet
    Public formOfficials As New Officials
    Public frmBusiness As New Business
    Public frmFamily As New Family
    Public frmReligion As New Religion
    Public frmRes As New Residents
    Public frmZone As New Zone
    Public frmUsers As New Users
    Public frmBlotter As New Blotter
    Public frmResList As New ResidentList
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mdiManager As XtraTabbedMdiManager = New XtraTabbedMdiManager()
        mdiManager.MdiParent = Me

    End Sub
    Private Sub AccordionControlElement10_Click(sender As Object, e As EventArgs) Handles AccordionControlElement10.Click
        For Each f As Form In Application.OpenForms
            If TypeOf f Is Officials Then
                f.Activate()
                Return
            End If
        Next
        formOfficials = New Officials
        formOfficials.Text = "Barangay Officials"
        formOfficials.MdiParent = Me
        formOfficials.Show()
    End Sub
    Private Sub AccordionControlElement9_Click(sender As Object, e As EventArgs) Handles AccordionControlElement9.Click
        For Each f As Form In Application.OpenForms
            If TypeOf f Is Business Then
                f.Activate()
                Return
            End If
        Next
        frmBusiness = New Business
        frmBusiness.Text = "Business"
        frmBusiness.MdiParent = Me
        frmBusiness.Show()
    End Sub
    Private Sub AccordionControlElement8_Click(sender As Object, e As EventArgs) Handles AccordionControlElement8.Click
        For Each f As Form In Application.OpenForms
            If TypeOf f Is Family Then
                f.Activate()
                Return
            End If
        Next
        frmFamily = New Family
        frmFamily.Text = "HouseHold"
        frmFamily.MdiParent = Me
        frmFamily.Show()
    End Sub
    Private Sub AccordionControlElement5_Click(sender As Object, e As EventArgs) Handles AccordionControlElement5.Click
        For Each f As Form In Application.OpenForms
            If TypeOf f Is Religion Then
                f.Activate()
                Return
            End If
        Next
        frmReligion = New Religion
        frmReligion.Text = "Religion"
        frmReligion.MdiParent = Me
        frmReligion.Show()
    End Sub
    Private Sub AccordionControlElement7_Click(sender As Object, e As EventArgs) Handles AccordionControlElement7.Click
        For Each f As Form In Application.OpenForms
            If TypeOf f Is Residents Then
                f.Activate()
                Return
            End If
        Next
        frmRes = New Residents
        frmRes.Text = "Residents"
        frmRes.MdiParent = Me
        frmRes.Show()
    End Sub
    Private Sub AccordionControlElement6_Click(sender As Object, e As EventArgs) Handles AccordionControlElement6.Click
        For Each f As Form In Application.OpenForms
            If TypeOf f Is Zone Then
                f.Activate()
                Return
            End If
        Next
        frmZone = New Zone
        frmZone.Text = "Zone"
        frmZone.MdiParent = Me
        frmZone.Show()
    End Sub
    Private Sub AccordionControlElement11_Click(sender As Object, e As EventArgs) Handles AccordionControlElement11.Click
        For Each f As Form In Application.OpenForms
            If TypeOf f Is Users Then
                f.Activate()
                Return
            End If
        Next
        frmUsers = New Users
        frmUsers.Text = "Users"
        frmUsers.MdiParent = Me
        frmUsers.Show()
    End Sub
    Private Sub btnBrgyClearance_Click(sender As Object, e As EventArgs) Handles btnBrgyClearance.Click
        BrgyClearance.clearances = True
        BrgyClearance.ShowDialog()
    End Sub
    Private Sub cTransHousehold_Click(sender As Object, e As EventArgs) Handles cTransHousehold.Click
        Belongings.ShowDialog()
    End Sub
    Private Sub CTransAnimal_Click(sender As Object, e As EventArgs) Handles CTransAnimal.Click
        frmAnimalTransport.ShowDialog()
    End Sub
    Private Sub CertRes_Click(sender As Object, e As EventArgs) Handles CertRes.Click
        Certificate.txttbl.Text = "Residency"
        Certificate.txtdbNo.Text = "ResidencyNo"
        Certificate.txtActivity.Text = "SAVED AND PRINTED A CERTIFICATE OF RESIDENCY FOR "
        Certificate.ShowDialog()
    End Sub
    Private Sub CertTribe_Click(sender As Object, e As EventArgs) Handles CertTribe.Click
        TribalMember.ShowDialog()
    End Sub
    Private Sub CertNonOp_Click(sender As Object, e As EventArgs) Handles CertNonOp.Click
        NonOp.ShowDialog()
    End Sub
    Private Sub CertSolo_Click(sender As Object, e As EventArgs) Handles CertSolo.Click
        Certificate.txttbl.Text = "SoloParent"
        Certificate.txtdbNo.Text = "SoloParentNo"
        Certificate.txtActivity.Text = "SAVED AND PRINTED A CERTIFICATE OF SOLO PARENT FOR "
        Certificate.ShowDialog()
    End Sub
    Private Sub CertInd_Click(sender As Object, e As EventArgs) Handles CertInd.Click
        Certificate.txttbl.Text = "Indigency"
        Certificate.txtdbNo.Text = "IndigencyNo"
        Certificate.txtActivity.Text = "SAVED AND PRINTED A CERTIFICATE OF INDIGENCY FOR "
        Certificate.ShowDialog()
    End Sub
    Private Sub CertGood_Click(sender As Object, e As EventArgs)
        Certificate.txttbl.Text = "GoodMoral"
        Certificate.txtdbNo.Text = "GoodMoralNo"
        Certificate.txtActivity.Text = "SAVED AND PRINTED A CERTIFICATE OF GOOD MORAL FOR "
        Certificate.ShowDialog()
    End Sub
    Private Sub BusClearance_Click(sender As Object, e As EventArgs) Handles BusClearance.Click
        BusinessClearance.ShowDialog()
    End Sub
    Private Sub AccordionControlElement32_Click(sender As Object, e As EventArgs) Handles AccordionControlElement32.Click
        ActivityLog.ShowDialog()
    End Sub
    Private Sub AccordionControlElement33_Click(sender As Object, e As EventArgs) Handles AccordionControlElement33.Click
        Archive.ShowDialog()
    End Sub
    Private Sub AccordionControlElement34_Click(sender As Object, e As EventArgs) Handles AccordionControlElement34.Click
        backUp.ShowDialog()
    End Sub
    Private Sub Blo_Click(sender As Object, e As EventArgs) Handles Blo.Click
        For Each f As Form In Application.OpenForms
            If TypeOf f Is Blotter Then
                f.Activate()
                Return
            End If
        Next
        frmBlotter = New Blotter
        frmBlotter.Text = "Blotter"
        frmBlotter.MdiParent = Me
        frmBlotter.Show()
        DashboardViewer1.Visible = False
    End Sub
    Private Sub CertOwnLarge_Click(sender As Object, e As EventArgs) Handles CertOwnLarge.Click
        LargeAnimal.ShowDialog()
    End Sub
    Private Sub AccordionControlElement53_Click(sender As Object, e As EventArgs) Handles AccordionControlElement53.Click
        form97.ShowDialog()
    End Sub
    Private Sub AccordionControlElement54_Click(sender As Object, e As EventArgs) Handles AccordionControlElement54.Click
        form98.ShowDialog()
    End Sub
    Private Sub AccordionControlElement55_Click(sender As Object, e As EventArgs) Handles AccordionControlElement55.Click
        form99.ShowDialog()
    End Sub
    Private Sub AccordionControlElement65_Click(sender As Object, e As EventArgs) Handles AccordionControlElement65.Click
        form100.ShowDialog()
    End Sub
    Private Sub AccordionControlElement57_Click(sender As Object, e As EventArgs) Handles AccordionControlElement57.Click
        form102.ShowDialog()
    End Sub
    Private Sub AccordionControlElement41_Click(sender As Object, e As EventArgs) Handles AccordionControlElement41.Click
        frmOPZone.ShowDialog()
    End Sub
    Private Sub AccordionControlElement46_Click(sender As Object, e As EventArgs) Handles AccordionControlElement46.Click
        TransactionReport.Text = "BUSINESS CLEARANCE LIST"
        TransactionReport.txtopt.Text = "BusinessClearance"
        TransactionReport.ShowDialog()
    End Sub
    Private Sub AccordionControlElement42_Click(sender As Object, e As EventArgs) Handles AccordionControlElement42.Click
        Pop(d, ds, "select PurokName from Purok", "Purok")
        Dim qryCount As Integer
        For i As Integer = 0 To ds.Tables("Purok").Rows.Count - 1
            Scan("Resident", "where Purok = '" & ds.Tables("Purok").Rows(i).Item(0) & "' and Archive = 0 and Deceased = 0")
            Edit("Purok", "Population = " & queryResult1 & "", "where Purokname = '" & ds.Tables("Purok").Rows(i).Item(0) & "'")
            Scan("Resident", "where Purok = '" & ds.Tables("Purok").Rows(i).Item(0) & "' and Gender = '" & "MALE" & "' and Archive = 0 and Deceased = 0")
            Edit("Purok", "Male = " & queryResult1 & "", "where Purokname = '" & ds.Tables("Purok").Rows(i).Item(0) & "'")
            Scan("Resident", "where Purok = '" & ds.Tables("Purok").Rows(i).Item(0) & "' and Gender = '" & "FEMALE" & "' and Archive = 0 and Deceased = 0")
            Edit("Purok", "Female = " & queryResult1 & "", "where Purokname = '" & ds.Tables("Purok").Rows(i).Item(0) & "'")
            'Pop(d1, ds1, "select count(Distinct f.code from family f LEFT JOIN resident r on r.ID=f.ResID where r.Purok='" & ds.Tables("Purok").Rows(i).Item(0) & "')", "")
            Dim sqlcom1 As New MySqlCommand("select count(Distinct f.code) from family f LEFT JOIN resident r on r.ID=f.ResID where r.Purok='" & ds.Tables("Purok").Rows(i).Item(0) & "' and r.Archive = 0 and Deceased = 0", MysqlConnect)
            qryCount = sqlcom1.ExecuteScalar()
            Edit("Purok", "Household = " & qryCount & "", "where Purokname = '" & ds.Tables("Purok").Rows(i).Item(0) & "'")
        Next i
        Reports.opt = "Purok"
        Reports.ShowDialog()
    End Sub
    Private Sub AccordionControlElement43_Click(sender As Object, e As EventArgs) Handles AccordionControlElement43.Click
        TransactionReport.Text = "BLOTTER LIST"
        TransactionReport.txtopt.Text = "BlotterList"
        TransactionReport.ShowDialog()
    End Sub
    Private Sub AccordionControlElement38_Click(sender As Object, e As EventArgs) Handles AccordionControlElement38.Click
        ResidentList.ShowDialog()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        DashboardViewer1.ReloadData()
    End Sub
    Private Sub AccordionControlElement47_Click(sender As Object, e As EventArgs) Handles AccordionControlElement47.Click
        TransactionReport.ShowDialog()
    End Sub
    Private Sub AccordionControlElement12_Click(sender As Object, e As EventArgs) Handles AccordionControlElement12.Click
        Certificate.txttbl.Text = "GoodMoral"
        Certificate.txtdbNo.Text = "GoodMoralNo"
        Certificate.txtActivity.Text = "SAVED AND PRINTED A CERTIFICATE OF GOOD MORAL FOR "
        Certificate.ShowDialog()
    End Sub
    Private Sub AccordionControlElement48_Click(sender As Object, e As EventArgs) Handles AccordionControlElement48.Click
        KPReport.ShowDialog()
    End Sub
    Private Sub AccordionControlElement56_Click(sender As Object, e As EventArgs) Handles AccordionControlElement56.Click
        form112.ShowDialog()
    End Sub
End Class