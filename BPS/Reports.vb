Imports MySql.Data.MySqlClient
Imports System.ComponentModel
Public Class Reports
    Dim d As MySqlDataAdapter, ds As DataSet
    Dim bw As BackgroundWorker = New BackgroundWorker
    Public opt As String
    Private Sub Reports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If opt = "Clearance" Then
            Reports("brgyClearance", "where ClearanceNo = '" & txtNo.Text & "'")
            Dim crep As New rptClearance
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()
        ElseIf opt = "Residency" Then
            Reports("Residency", "where ResidencyNo = '" & txtNo.Text & "'")
            Dim crep As New rptResidency
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()
        ElseIf opt = "Form97" Then
            Reports("Form97", "where CaseNo = '" & txtNo.Text & "'")
            Dim crep As New rptform97
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()
        ElseIf opt = "Form98" Then
            Reports("Form98", "where CaseNo = '" & txtNo.Text & "'")
            Dim crep As New rptform98
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()
        ElseIf opt = "Form99" Then
            Reports("Form99", "where CaseNo = '" & txtNo.Text & "'")
            Dim crep As New rptform99
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()
        ElseIf opt = "Form102" Then
            Reports("Form102", "where CaseNo = '" & txtNo.Text & "'")
            Dim crep As New rptform102
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()
        ElseIf opt = "Form112" Then
            Reports("Form112", "where CaseNo = '" & txtNo.Text & "'")
            Dim crep As New rptform112
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()
        ElseIf opt = "Form100" Then
            Reports("Form100", "where CaseNo = '" & txtNo.Text & "'")
            Dim crep As New rptform100
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()


        ElseIf opt = "ResidencyList" Then
            If TransactionReport.cbAll.Checked Then
                Reports("Residency", "")
            Else
                Reports("Residency", "where PrintDate like '%" & TransactionReport.txtDate.Text & "%'")
            End If

            Dim crep As New rptResidencyList
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()
        ElseIf opt = "LargeAnimalList" Then
            If TransactionReport.cbAll.Checked Then
                Reports("Animal", "")
            Else
                Reports("Animal", "where PrintDate like '%" & TransactionReport.txtDate.Text & "%'")
            End If
            'Reports("Animal", "")
            Dim crep As New rptAnimalList
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()
        ElseIf opt = "TransBelongingList" Then
            If TransactionReport.cbAll.Checked Then
                Reports("Belongings", "")
            Else
                Reports("Belongings", "where PrintDate like '%" & TransactionReport.txtDate.Text & "%'")
            End If
            'Reports("Belongings", "")
            Dim crep As New rptBelongingList
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()
        ElseIf opt = "TribalMemberList" Then
            If TransactionReport.cbAll.Checked Then
                Reports("TribalMember", "")
            Else
                Reports("TribalMember", "where PrintDate like '%" & TransactionReport.txtDate.Text & "%'")
            End If
            'Reports("TribalMember", "")
            Dim crep As New rptTribalList
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()
        ElseIf opt = "TransAnimalList" Then
            If TransactionReport.cbAll.Checked Then
                Reports("Animaltransport", "")
            Else
                Reports("Animaltransport", "where PrintDate like '%" & TransactionReport.txtDate.Text & "%'")
            End If
            'Reports("Animaltransport", "")
            Dim crep As New rptAnimalTransList
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()
        ElseIf opt = "NonOpList" Then
            If TransactionReport.cbAll.Checked Then
                Reports("Nonoperation", "")
            Else
                Reports("Nonoperation", "where PrintDate like '%" & TransactionReport.txtDate.Text & "%'")
            End If
            'Reports("Nonoperation", "")
            Dim crep As New rptNonOpList
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()
        ElseIf opt = "SoloParentList" Then
            If TransactionReport.cbAll.Checked Then
                Reports("SoloParent", "")
            Else
                Reports("SoloParent", "where PrintDate like '%" & TransactionReport.txtDate.Text & "%' ")
            End If
            'Reports("SoloParent", "")
            Dim crep As New rptSoloParentList
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()


        ElseIf opt = "TribalMember" Then
            Reports("TribalMember", "where No = '" & txtNo.Text & "'")
            Dim crep As New rptTribalMember
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()
        ElseIf opt = "SoloParent" Then
            Reports("SoloParent", "where SoloParentNo = '" & txtNo.Text & "'")
            Dim crep As New rptSoloParent
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()
        ElseIf opt = "WaterBill" Then
            'Reports("waterbill", "where MonthDue = '" & WaterBills.txtMonth.Text & "'")
            Dim crep As New rptwaterbill
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()
        ElseIf opt = "Resident" Then
            Reports("Resident", "where Purok like '%" & cbPurok.Text & "%' and (archive = 0 " & txtNo.Text & ") ORDER BY Purok ASC, FullName ASC")
            Dim crep As New rptResidents
            Dim myTextObject, myTextObject1 As CrystalDecisions.CrystalReports.Engine.TextObject
            myTextObject = crep.Section1.ReportObjects.Item("txtTitle")
            myTextObject1 = crep.Section1.ReportObjects.Item("txtZone")
            myTextObject.Text = txt.Text
            myTextObject1.Text = cbPurok.Text
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()
        ElseIf opt = "Religion" Then
            Reports("Resident", "where Religion = '" & cbPurok.Text & "' and archive = 0 and Deceased = 0 ORDER BY Purok ASC, FullName ASC")
            Dim crep As New rptResidents
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()
        ElseIf opt = "Business" Then
            Reports("Business", "")
            Dim crep As New rptListOfBusiness
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()
        ElseIf opt = "BusinessIssued" Then
            If TransactionReport.cbAll.Checked Then
                Reports("BusinessClearance", "")
            Else
                Reports("BusinessClearance", "where DateIssued like '%" & TransactionReport.txtDate.Text & "%'")
            End If
            Dim crep As New rptClearanceIssued
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()
        ElseIf opt = "Cedula" Then
            Reports("Cedula", "where CedulaNo = '" & txtNo.Text & "'")
            Dim crep As New rptCedula
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()
        ElseIf opt = "Purok" Then
            Reports("Purok", "")
            Dim crep As New rptPurok
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()
        ElseIf opt = "ClearanceList" Then
            If TransactionReport.cbAll.Checked Then
                Reports("brgyClearance", "")
            Else
                Reports("brgyClearance", "where PrintDate like '%" & TransactionReport.txtDate.Text & "%'")
            End If
            Dim crep As New ClearanceList
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()
        ElseIf opt = "IndigencyList" Then
            If TransactionReport.cbAll.Checked Then
                Reports("Indigency", "")
            Else
                Reports("Indigency", "where PrintDate like '%" & TransactionReport.txtDate.Text & "%'")
            End If

            Dim crep As New rptIndigencyList
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()
        ElseIf opt = "GoodMoralList" Then
            If TransactionReport.cbAll.Checked Then
                Reports("Goodmoral", "")
            Else
                Reports("Goodmoral", "where PrintDate like '%" & TransactionReport.txtDate.Text & "%'")
            End If

            Dim crep As New GoodMoralList
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()
        ElseIf opt = "EndureList" Then
            If TransactionReport.cbAll.Checked Then
                Reports("Endure", "")
            Else
                Reports("Endure", "where CDate = '" & TransactionReport.txtDate.Text & "'")
            End If

            'Dim crep As New EndureList
            'crep.SetDataSource(ds)
            'CrystalReportViewer1.ReportSource = crep
            'CrystalReportViewer1.Refresh()
        ElseIf opt = "BlotterList" Then
            If TransactionReport.cbAll.Checked Then
                Reports("Blotter", "where archive = 0")
            Else
                Reports("Blotter", "where BDate = '" & TransactionReport.txtDate.Text & "' and archive = 0")
            End If
            Dim crep As New rptBlotterList
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()
        ElseIf opt = "CedulaList" Then
            Reports("Cedula", "")
            'Dim crep As New rptCedulaList
            'crep.SetDataSource(ds)
            'CrystalReportViewer1.ReportSource = crep
            'CrystalReportViewer1.Refresh()
        ElseIf opt = "Household" Then
            Reports("resident", "ORDER BY Purok ASC")
            Dim crep As New rptHousehold
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()
        ElseIf opt = "HouseholdZone" Then
            'Pop(d, ds, "Select * from Family f LEFT JOIN Resident r ON r.ID=f.ResID LEFT JOIN Resident r1 ON r1.ID=f.Head where r1.Purok='" & cbZone.Text & "'", "family f")
            Reports("resident", "where Purok like '%" & Trim(frmOPZone.cbZone.Text) & "%'")
            Dim crep As New rptHousehold
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()
        ElseIf opt = "BusinessClearance" Then
            Reports("BusClearance", "Where ClearanceNo = '" & txtNo.Text & "'")
            Dim crep As New rptBusinessC
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()
        ElseIf opt = "Animal" Then
            Reports("Animal", "Where No = '" & txtNo.Text & "'")
            Dim crep As New Animal
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()
        ElseIf opt = "MANAGEMENT" Then
            Reports("Busclearance", "Where ClearanceNo = '" & txtNo.Text & "'")
            Dim crep As New rptManagementBus
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()
        ElseIf opt = "CORPORATE" Then
            Reports("Busclearance", "Where ClearanceNo = '" & txtNo.Text & "'")
            Dim crep As New rptCorpBus
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()
        ElseIf opt = "AnimalTransport" Then
            'Pop(d, ds, "select bc.ID,bc.No,a.Brand,a.class,b.Fullname,bc.CDate,bc.Amount from animalTransport bc LEFT JOIN Resident b ON b.ID=bc.ResidentID LEFT JOIN animal a ON a.ID=bc.AnimalID where bc.No = '" & Trim(txtNo.Text) & "'", "AnimalTransport bc")
            Reports("AnimalTransport", "Where No = '" & txtNo.Text & "'")
            Dim crep As New rptAnimalTransport
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()
        ElseIf opt = "Belongings" Then
            Reports("Belongings", "Where No = '" & txtNo.Text & "'")
            Dim crep As New rptBelongings
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()
        ElseIf opt = "BusNonOp" Then
            Reports("BusNonOp", "Where No = '" & txtNo.Text & "'")
            Dim crep As New rptNonOp
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()
        ElseIf opt = "GoodMoral" Then
            Reports("Goodmoral", "Where GoodmoralNo = '" & txtNo.Text & "'")
            Dim crep As New rptGoodMoral
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()
        ElseIf opt = "Cattle" Then
            Reports("Cattle", "Where CattleNo = '" & txtNo.Text & "'")
            Dim crep As New Cattle
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()

        ElseIf opt = "Endure" Then
            Reports("Endure", "Where EndureNo = '" & txtNo.Text & "'")
            Dim crep As New rptEndure
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()
        ElseIf opt = "Indigency" Then
            Reports("Indigency", "where IndigencyNo = '" & txtNo.Text & "'")
            Dim crep As New rptIndigentCert
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()
        ElseIf opt = "ActivityLogs" Then
            Reports("ActivityLogs", "")
            Dim crep As New rptActivityLogs
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()
        ElseIf opt = "ActivityLogsFiltered" Then
            Reports("ActivityLogs", "where ADate like '%" & ActivityLog.txtDate.Text & "%' ORDER BY ID DESC")
            Dim crep As New rptActivityLogs
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()
        ElseIf opt = "KP" Then
            Reports("form97", " ORDER BY CaseNo DESC")
            Dim crep As New rptKP
            crep.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crep
            CrystalReportViewer1.Refresh()
        End If
    End Sub
    Function Reports(ByVal TableName As String, ByVal whereValues As String)
        d = New MySqlDataAdapter("Select * from " & TableName & " " & whereValues & "", MysqlConnect)
        ds = New DataSet
        d.Fill(ds, "" & TableName & "")
        Return True
    End Function
End Class