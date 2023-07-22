Public Class Search
    Private Sub Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Bar1.Visible = False
    End Sub
    Public Overrides Sub SelectRes()
        Try
            If GridView1.RowCount > 0 Then
                If Opt = "UpdOfficials" Then
                    UpdateOfficials.txtResID.Text = GridView1.GetFocusedRowCellValue("ID").ToString
                    Me.Close()
                ElseIf Opt = "Form97Comp" Then
                    form97.txtComplainant.Text = GridView1.GetFocusedRowCellValue("Fullname").ToString
                    Me.Close()
                ElseIf Opt = "Form97Resp" Then
                    form97.txtRespondent.Text = GridView1.GetFocusedRowCellValue("Fullname").ToString
                    Me.Close()
                ElseIf Opt = "Form102" Then
                    form102.txtChosen.Text = GridView1.GetFocusedRowCellValue("Fullname").ToString
                    Me.Close()
                ElseIf Opt = "Form100" Then
                    form100.txtofficer.Text = GridView1.GetFocusedRowCellValue("Fullname").ToString
                    Me.Close()
                ElseIf Opt = "Form100Dwell" Then
                    form100.txtDwell.Text = GridView1.GetFocusedRowCellValue("Fullname").ToString
                    Me.Close()
                ElseIf Opt = "Form100Office" Then
                    form100.txtOffice.Text = GridView1.GetFocusedRowCellValue("Fullname").ToString
                    Me.Close()
                ElseIf Opt = "BrgyClearance" Then
                    BrgyClearance.txtResID.Text = GridView1.GetFocusedRowCellValue("ID").ToString
                    Me.Close()
                ElseIf Opt = "Belongings" Then
                    Belongings.txtResID.Text = GridView1.GetFocusedRowCellValue("ID").ToString
                    Me.Close()
                ElseIf Opt = "Residency" Then
                    Residency.txtResID.Text = GridView1.GetFocusedRowCellValue("ID").ToString
                    Me.Close()
                ElseIf Opt = "TribalMember" Then
                    TribalMember.txtResID.Text = GridView1.GetFocusedRowCellValue("ID").ToString
                    Me.Close()
                ElseIf Opt = "Mother" Then
                    TribalMember.txtMotherID.Text = GridView1.GetFocusedRowCellValue("ID").ToString
                    Me.Close()
                ElseIf Opt = "SoloParent" Then
                    SoloParent.txtResID.Text = GridView1.GetFocusedRowCellValue("ID").ToString
                    Me.Close()
                ElseIf Opt = "Certificate" Then
                    Certificate.txtResID.Text = GridView1.GetFocusedRowCellValue("ID").ToString
                    Me.Close()
                ElseIf Opt = "Cattle" Then
                    LargeAnimal.txtResID.Text = GridView1.GetFocusedRowCellValue("ID").ToString
                    Me.Close()
                ElseIf Opt = "PTC" Then
                    adedBlotter.txtPTCID.Text = GridView1.GetFocusedRowCellValue("ID").ToString
                    Me.Close()
                ElseIf Opt = "CN" Then
                    adedBlotter.txtCNID.Text = GridView1.GetFocusedRowCellValue("ID").ToString
                    Me.Close()
                ElseIf Opt = "h" Then
                    Pop(d, ds, "select * from family where ResID = " & GridView1.GetFocusedRowCellValue("ID").ToString & " or Head = " & GridView1.GetFocusedRowCellValue("ID").ToString & "", "family")
                    If adedFam.adds = True Then

                        If ds.Tables("family").Rows.Count > 0 Then
                            MsgBox("This person is already part of another family! Please choose another.", MsgBoxStyle.Exclamation)
                        Else
                            adedFam.txtHeadID.Text = GridView1.GetFocusedRowCellValue("ID").ToString
                            Me.Close()
                        End If
                    Else
                        'Pop(d, ds, "select * from family where (ResID = " & GridView1.GetFocusedRowCellValue("ID").ToString & " or Head = " & GridView1.GetFocusedRowCellValue("ID").ToString & ") and (ResID <> " & adedFam.txtHeadID.Text & ")", "family")
                        If ds.Tables("family").Rows.Count > 0 Then
                            MsgBox("This person is already part of another family or already part of its members. Please choose another.", MsgBoxStyle.Exclamation)
                        Else
                            Edit("family", "Head=" & GridView1.GetFocusedRowCellValue("ID").ToString & "", "where code = " & adedFam.txtCode.Text & "")
                            adedFam.txtHeadID.Text = GridView1.GetFocusedRowCellValue("ID").ToString
                            Me.Close()
                        End If
                    End If

                ElseIf Opt = "m" Then
                    Pop(d, ds, "select * from family where ResID = " & GridView1.GetFocusedRowCellValue("ID").ToString & " or Head = " & GridView1.GetFocusedRowCellValue("ID").ToString & "", "family")
                    If ds.Tables("family").Rows.Count > 0 Then
                        MsgBox("This person is already part of another family or already its head! Please choose another.", MsgBoxStyle.Exclamation)
                    Else
                        adedFam.txtMemberID.Text = GridView1.GetFocusedRowCellValue("ID").ToString
                        Me.Close()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class