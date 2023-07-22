Imports DevExpress.XtraBars
Imports DevExpress.XtraTabbedMdi
Imports MySql.Data.MySqlClient
Public Class MainForm
    Public formOfficials As New Officials
    Public frmBusiness As New Business
    Public frmFamily As New Family
    Public frmReligion As New Religion
    Public frmRes As New Residents
    Public frmZone As New Zone
    Public frmUsers As New Users
    Public frmBlotter As New Blotter
    Public frmResList As New ResidentList
    Dim d, d1 As MySqlDataAdapter, ds, ds1 As DataSet
    Private Sub btnBrgyOfficials_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnBrgyOfficials.ItemClick
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
    Private Sub btnBusiness_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnBusiness.ItemClick
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
    Private Sub btnHouseholds_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnHouseholds.ItemClick
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
    Private Sub btnLogOut_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnLogOut.ItemClick
        Me.Close()
    End Sub
    Private Sub btnReligion_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnReligion.ItemClick

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
    Private Sub btnResidents_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnResidents.ItemClick
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
    Private Sub btnZone_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnZone.ItemClick
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
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.IsMdiContainer = True
        Dim barManager As BarManager = New BarManager()
        barManager.Form = Me
        barManager.BeginUpdate()
        Dim barItem As BarItem = New BarButtonItem(barManager, "New")
        AddHandler barItem.ItemClick, AddressOf btnResidents_ItemClick
        barManager.EndUpdate()
        Dim mdiManager As XtraTabbedMdiManager = New XtraTabbedMdiManager()
        mdiManager.MdiParent = Me
    End Sub
    Private Sub btnUser_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnUser.ItemClick
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
    Private Sub btnBrgyClearance_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnBrgyClearance.ItemClick
        BrgyClearance.clearances = True
        BrgyClearance.ShowDialog()
    End Sub
    Private Sub btnBelongings_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnBelongings.ItemClick
        Belongings.ShowDialog()
    End Sub
    Private Sub btnTransport_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnTransport.ItemClick
        'AnimalTransport.clearances = True
        frmAnimalTransport.ShowDialog()
    End Sub
    Private Sub btnResidency_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnResidency.ItemClick
        Certificate.txttbl.Text = "Residency"
        Certificate.txtdbNo.Text = "ResidencyNo"
        Certificate.txtActivity.Text = "SAVED AND PRINTED A CERTIFICATE OF RESIDENCY FOR "
        Certificate.ShowDialog()
    End Sub
    Private Sub btnTribalMembership_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnTribalMembership.ItemClick
        TribalMember.ShowDialog()
    End Sub
    Private Sub btnNonOp_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnNonOP.ItemClick
        NonOp.ShowDialog()
    End Sub
    Private Sub btnSoloParent_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnSoloParent.ItemClick
        Certificate.txttbl.Text = "SoloParent"
        Certificate.txtdbNo.Text = "SoloParentNo"
        Certificate.txtActivity.Text = "SAVED AND PRINTED A CERTIFICATE OF SOLO PARENT FOR "
        Certificate.ShowDialog()
    End Sub
    Private Sub btnIndigency_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnIndigency.ItemClick
        Certificate.txttbl.Text = "Indigency"
        Certificate.txtdbNo.Text = "IndigencyNo"
        Certificate.txtActivity.Text = "SAVED AND PRINTED A CERTIFICATE OF INDIGENCY FOR "
        Certificate.ShowDialog()
    End Sub
    Private Sub btnGoodMoral_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnGoodMoral.ItemClick
        Certificate.txttbl.Text = "GoodMoral"
        Certificate.txtdbNo.Text = "GoodMoralNo"
        Certificate.txtActivity.Text = "SAVED AND PRINTED A CERTIFICATE OF GOOD MORAL FOR "
        Certificate.ShowDialog()
    End Sub
    Private Sub btnCattle_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCattle.ItemClick
        LargeAnimal.txttbl.Text = "Animal"
        LargeAnimal.txtdbNo.Text = "No"
        LargeAnimal.txtActivity.Text = "SAVED AND PRINTED A CERTIFICATE OF OWNERSHIP OF LARGE ANIMAL FOR "
        LargeAnimal.ShowDialog()
    End Sub
    Private Sub btnBusinessC_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnBusinessC.ItemClick
        BusinessClearance.ShowDialog()
    End Sub
    Private Sub btnBlotter_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnBlotter.ItemClick
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
    End Sub
    Private Sub btnExit_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnExit.ItemClick
        End
    End Sub
    Private Sub btnAct_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnAct.ItemClick
        ActivityLog.ShowDialog()
    End Sub
    Private Sub btnArchive_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnArchive.ItemClick
        Archive.ShowDialog()
    End Sub
    Private Sub btnBackUp_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnBackUp.ItemClick
        backUp.ShowDialog()
    End Sub
    Private Sub btnRRel_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnRRel.ItemClick
        Reports.opt = "Religion"
        Reports.ShowDialog()
    End Sub
    Private Sub btnAllHH_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnAllHH.ItemClick
        Reports.opt = "Household"
        Reports.ShowDialog()
    End Sub
    Private Sub btnHHperZone_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnHHperZone.ItemClick
        Reports.opt = "HouseholdZone"
        Reports.ShowDialog()
    End Sub
    Private Sub btnPop_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnPop.ItemClick
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
    Private Sub btnBrgyCList_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnBrgyCList.ItemClick
        TransactionReport.Text = "BARANGAY CLEARANCE LIST"
        TransactionReport.txtopt.Text = "BrgyClearance"
        TransactionReport.ShowDialog()
    End Sub
    Private Sub btnIndCList_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnIndCList.ItemClick
        TransactionReport.Text = "CERTIFICATE OF INDIGENCY LIST"
        TransactionReport.txtopt.Text = "Indigency"
        TransactionReport.ShowDialog()
    End Sub
    Private Sub btnForm97_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnForm97.ItemClick
        form97.ShowDialog()
    End Sub
    Private Sub btnForm98_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnForm98.ItemClick
        form98.ShowDialog()
    End Sub
    Private Sub btnForm99_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnForm99.ItemClick
        form99.ShowDialog()
    End Sub
    Private Sub btnForm102_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnForm102.ItemClick
        form102.ShowDialog()
    End Sub
    Private Sub btnForm112_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnForm112.ItemClick
        form112.ShowDialog()
    End Sub
    Private Sub btnForm100_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnForm100.ItemClick
        form100.ShowDialog()
    End Sub
    Private Sub btnBusCList_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnBusCList.ItemClick
        TransactionReport.Text = "BUSINESS CLEARANCE LIST"
        TransactionReport.txtopt.Text = "BusinessClearance"
        TransactionReport.ShowDialog()
    End Sub
    Private Sub btnOwnership_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnOwnership.ItemClick
        TransactionReport.Text = "LARGE ANIMAL OWNERSHIP CERTIFICATE LIST"
        TransactionReport.txtopt.Text = "LargeAnimal"
        TransactionReport.ShowDialog()
    End Sub
    Private Sub btnRClist_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnRClist.ItemClick
        TransactionReport.Text = "RESIDENCY CERTIFICATE LIST"
        TransactionReport.txtopt.Text = "Residency"
        TransactionReport.ShowDialog()
    End Sub
    Private Sub btnSPCList_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnSPClist.ItemClick
        TransactionReport.Text = "SOLO PARENT CERTIFICATE LIST"
        TransactionReport.txtopt.Text = "SoloParent"
        TransactionReport.ShowDialog()
    End Sub
    Private Sub btnLAClist_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnLAClist.ItemClick
        TransactionReport.Text = "TRANSPORTATION OF LARGE ANIMAL CERTIFICATE LIST"
        TransactionReport.txtopt.Text = "TransAnimal"
        TransactionReport.ShowDialog()
    End Sub
    Private Sub btnHCBList_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnHBClist.ItemClick
        TransactionReport.Text = "TRANSPORTATION OF HOUSEHOLD BELONGINGS CERTIFICATE LIST"
        TransactionReport.txtopt.Text = "TransBelonging"
        TransactionReport.ShowDialog()
    End Sub
    Private Sub btntribalClist_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btntribalClist.ItemClick
        TransactionReport.Text = "TRIBAL MEMBERSHIP CERTIFICATE LIST"
        TransactionReport.txtopt.Text = "TribalMember"
        TransactionReport.ShowDialog()
    End Sub
    Private Sub btnNOClist_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnNOClist.ItemClick
        TransactionReport.Text = "NON-OPERATION OF BUSINESS CERTIFICATE LIST"
        TransactionReport.txtopt.Text = "NonOp"
        TransactionReport.ShowDialog()
    End Sub
    Private Sub btnGoodCList_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnGoodCList.ItemClick
        TransactionReport.Text = "CERTIFICATE OF GOOD MORAL LIST"
        TransactionReport.txtopt.Text = "GoodMoralList"
        TransactionReport.ShowDialog()
    End Sub
    Private Sub btnBlotterList_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnBlotterList.ItemClick
        TransactionReport.Text = "BLOTTER LIST"
        TransactionReport.txtopt.Text = "BlotterList"
        TransactionReport.ShowDialog()
    End Sub
    Private Sub btnBusinessList_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnBusinessList.ItemClick
        Reports.opt = "Business"
        Reports.ShowDialog()
    End Sub
    Private Sub btnResident_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnResident.ItemClick
        For Each f As Form In Application.OpenForms
            If TypeOf f Is ResidentList Then
                f.Activate()
                Return
            End If
        Next
        frmResList = New ResidentList
        frmResList.Text = "ResidentList"
        frmResList.MdiParent = Me
        frmResList.Show()
    End Sub
End Class