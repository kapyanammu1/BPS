Imports MySql.Data.MySqlClient
Public Class adedRes
    Dim d As MySqlDataAdapter, ds As DataSet
    Dim filepath, Fullname As String
    Public adds As Boolean
    Friend Shared Function UpdateOfficials() As Object
        Throw New NotImplementedException()
    End Function
    Private Sub adedRes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbOFW.Checked = False
        txtCountry.Enabled = False
        cbDeceased.Checked = False
        If adds = True Then
            EnDis(True)
            SimpleButton2.Text = "SAVE"
            clear()
            txtCountry.Enabled = False
        Else
            LoadReligion()
            LoadZone()
            loadDetails()
            'EnDis(False)
        End If
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
    Function LoadReligion()
        cboReligion.Items.Clear()
        Pop(d, ds, "select Religion from Religion", "Religion")
        For i = 0 To ds.Tables("Religion").Rows.Count - 1
            If ds.Tables("Religion").Rows.Count > 0 Then
                cboReligion.Items.Add(ds.Tables("Religion").Rows(i).Item(0))
            End If
        Next i
        Return True
    End Function
    Function clear()
        LoadReligion()
        LoadZone()
        txtID.Text = ""
        'txtimage.Clear()
        txtLName.Text = ""
        txtFName.Text = ""
        txtMName.Text = ""
        cbGender.Text = ""
        txtAge.Text = ""
        txtCPno.Text = ""
        txtBPlace.Text = ""
        txtCStatus.Text = ""
        txtCitiz.Text = ""
        txtAddress.Text = ""
        txtProfession.Text = ""
        txtEducAtt.Text = ""
        'txtimage = ""
        cbOFW.Checked = False
        cbOSY.Checked = False
        cbPWD.Checked = False
        cbDialysis.Checked = False
        cbSoloP.Checked = False
        cbDeceased.Checked = False
        txtIncome.Text = ""
        txtCountry.Text = ""
        PictureBox1.Image = Nothing
        Return True
    End Function
    Private Sub btnPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPhoto.Click

        OpenFileDialog1.Filter = "JPEG|*.jpg|Bitmap|*.bmp|PNG|*.PNG"
        OpenFileDialog1.Title = "Please select a file"
        OpenFileDialog1.InitialDirectory = "c:"
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Try
            If txtLName.Text = "" Or txtFName.Text = "" Or txtMName.Text = "" Then
                MsgBox("Required Field Missing!", MsgBoxStyle.Critical)
                Exit Sub
            End If
            If cbVoter.Checked Then
                txtVoter.Text = 1
            Else
                txtVoter.Text = 0
            End If
            If cbCR.Checked Then
                txtCR.Text = 1
            Else
                txtCR.Text = 0
            End If
            If cbDeceased.Checked Then
                txtDeceased.Text = 1
            Else
                txtDeceased.Text = 0
            End If
            If cbOFW.Checked Then
                txtOFW.Text = 1
            Else
                txtOFW.Text = 0
            End If
            If txtIncome.Text = "" Then
                txtIncome.Text = 0
            End If

            If cbOSY.Checked Then
                txtOSY.Text = 1
            Else
                txtOSY.Text = 0
            End If
            If cbPWD.Checked Then
                txtPWD.Text = 1
            Else
                txtPWD.Text = 0
            End If
            If cbDialysis.Checked Then
                txtDP.Text = 1
            Else
                txtDP.Text = 0
            End If
            If cbSoloP.Checked Then
                txtSP.Text = 1
            Else
                txtSP.Text = 0
            End If


            If (Date.Today.Day >= txtBday.Value.Day) And (Month(Date.Today) >= Month(txtBday.Value)) Then
                txtAge.Text = DateDiff(DateInterval.Year, txtBday.Value, Date.Now)
            Else
                txtAge.Text = DateDiff(DateInterval.Year, txtBday.Value, Date.Now) - 1
            End If
            Fullname = txtLName.Text & ", " & txtFName.Text & " " & txtMName.Text
            If adds = True Then
                Scan("Resident", "where Lname = '" & txtLName.Text & "' and Fname = '" & txtFName.Text & "' and Mname = '" & txtMName.Text & "' and ID <> " & Val(txtID.Text) & "")
                If queryResult1 > 0 Then
                    MsgBox("This Resident already exist! Please enter another.", MsgBoxStyle.Critical, "Duplicate Record")
                Else

                    Dim arrImage() As Byte
                    If PictureBox1.Image Is Nothing Then
                        com = New MySqlCommand("insert into resident (Lname,fname,mname,gender,age,contactno,birthdate,birthplace,civilstatus,religion,citizenship,purok,address,profession,Educattainment,Fullname,Deceased,Income,OFW,Country,HouseNo,OSY,PWD,DP,SP,CR,Voter) values ('" & txtLName.Text & "','" & txtFName.Text & "','" & txtMName.Text & "','" & cbGender.Text & "'," &
                                     Val(txtAge.Text) & ",'" & txtCPno.Text & "','" & txtBday.Text & "','" & txtBPlace.Text & "','" &
                                     txtCStatus.Text & "','" & cboReligion.Text & "','" & txtCitiz.Text & "','" & cbZone.Text & "','" &
                                     txtAddress.Text & "','" & txtProfession.Text & "','" & txtEducAtt.Text & "','" &
                                     Fullname & "'," & txtDeceased.Text & "," & txtIncome.Text & "," & txtOFW.Text & ",'" & txtCountry.Text & "','" &
                                     "" & "'," & txtOSY.Text & "," & txtPWD.Text & "," & txtDP.Text & "," & txtSP.Text & "," & txtCR.Text & "," & txtVoter.Text & ")", MysqlConnect)
                        com.ExecuteNonQuery()

                    Else
                        Dim mstream As New System.IO.MemoryStream
                        PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                        arrImage = mstream.GetBuffer()
                        mstream.Close()
                        com = New MySqlCommand("insert into resident (Lname,fname,mname,gender,age,contactno,birthdate,birthplace,civilstatus,religion,citizenship,purok,address,profession,Educattainment,image,Fullname,Deceased,Income,OFW,Country,HouseNo,OSY,PWD,DP,SP,CR,Voter) values ('" & txtLName.Text & "','" & txtFName.Text & "','" & txtMName.Text & "','" & cbGender.Text & "'," &
                                     Val(txtAge.Text) & ",'" & txtCPno.Text & "','" & txtBday.Text & "','" & txtBPlace.Text & "','" &
                                     txtCStatus.Text & "','" & cboReligion.Text & "','" & txtCitiz.Text & "','" & cbZone.Text & "','" &
                                     txtAddress.Text & "','" & txtProfession.Text & "','" & txtEducAtt.Text & "',@photo,'" &
                                     Fullname & "'," & txtDeceased.Text & "," & txtIncome.Text & "," & txtOFW.Text & ",'" & txtCountry.Text & "','" &
                                     "" & "'," & txtOSY.Text & "," & txtPWD.Text & "," & txtDP.Text & "," & txtSP.Text & "," & txtCR.Text & "," & txtVoter.Text & ")", MysqlConnect)
                        com.Parameters.AddWithValue("@photo", arrImage)
                        com.ExecuteNonQuery()

                    End If

                    'activity("ADDED NEW A RESIDENT NAMED " & Fullname)
                    MsgBox("Record Saved!", MsgBoxStyle.Information, "NEW RESIDENT SAVED")
                    Me.Close()
                End If
            Else
                If SimpleButton2.Text = "SAVE" Then
                    Scan("Resident", "where Lname = '" & txtLName.Text & "' and Fname = '" & txtFName.Text & "' and Mname = '" & txtMName.Text & "' and ID <> " & Val(txtID.Text) & "")
                    If queryResult1 > 0 Then
                        MsgBox("This Resident already exist! Please enter another.", MsgBoxStyle.Critical, "Duplicate Record")
                    Else

                        Dim arrImage() As Byte
                        If PictureBox1.Image Is Nothing Then
                            com = New MySqlCommand("UPDATE Resident set Lname = '" & txtLName.Text & "',Fname = '" & txtFName.Text _
                                               & "',Mname = '" & txtMName.Text & "',Gender = '" & cbGender.Text _
                                               & "',Age = " & Val(txtAge.Text) & ",ContactNo = '" & txtCPno.Text _
                                               & "',Birthdate = '" & txtBday.Text & "',BirthPlace = '" & txtBPlace.Text _
                                                   & "',CivilStatus = '" & txtCStatus.Text & "',Religion = '" & cboReligion.Text _
                                                   & "',Citizenship = '" & txtCitiz.Text & "',purok = '" & cbZone.Text _
                                                   & "', Address = '" & txtAddress.Text & "',profession = '" & txtProfession.Text _
                                                   & "',EducAttainment = '" & txtEducAtt.Text & "',image = @photo,Fullname = '" &
                                                   Fullname & "',Deceased = " & txtDeceased.Text & ",Income = " & txtIncome.Text _
                                                   & ",OFW = " & txtOFW.Text & ",Country = '" & txtCountry.Text & "', OSY = " & txtOSY.Text _
                                                   & ", PWD = " & txtPWD.Text & ", DP = " & txtDP.Text & ", SP = " & txtSP.Text & ", CR = " & txtCR.Text & ", Voter = " & txtVoter.Text & " where ID = " & txtID.Text & "", MysqlConnect)

                            com.Parameters.AddWithValue("@photo", DBNull.Value)
                            com.ExecuteNonQuery()

                        Else
                            Dim mstream As New System.IO.MemoryStream
                            PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                            arrImage = mstream.GetBuffer()
                            mstream.Close()
                            com = New MySqlCommand("UPDATE Resident set Lname = '" & txtLName.Text & "',Fname = '" & txtFName.Text _
                                               & "',Mname = '" & txtMName.Text & "',Gender = '" & cbGender.Text _
                                               & "',Age = " & Val(txtAge.Text) & ",ContactNo = '" & txtCPno.Text _
                                               & "',Birthdate = '" & txtBday.Text & "',BirthPlace = '" & txtBPlace.Text _
                                                   & "',CivilStatus = '" & txtCStatus.Text & "',Religion = '" & cboReligion.Text _
                                                   & "',Citizenship = '" & txtCitiz.Text & "',purok = '" & cbZone.Text _
                                                   & "', Address = '" & txtAddress.Text & "',profession = '" & txtProfession.Text _
                                                   & "',EducAttainment = '" & txtEducAtt.Text & "',image = @photo,Fullname = '" &
                                                   Fullname & "',Deceased = " & txtDeceased.Text & ",Income = " & txtIncome.Text _
                                                   & ",OFW = " & txtOFW.Text & ",Country = '" & txtCountry.Text & "', OSY = " & txtOSY.Text _
                                                   & ", PWD = " & txtPWD.Text & ", DP = " & txtDP.Text & ", SP = " & txtSP.Text & ", CR = " & txtCR.Text & ", Voter = " & txtVoter.Text & " where ID = " & txtID.Text & "", MysqlConnect)

                            com.Parameters.AddWithValue("@photo", arrImage)
                            com.ExecuteNonQuery()
                        End If


                        'activity("UPDATED THE RECORD OF " & Fullname)
                        MsgBox("Record Updated!", MsgBoxStyle.Information, "RECORD UPDATED")
                        'SimpleButton2.Text = "EDIT"
                        'EnDis(False)
                        Me.Close()
                    End If
                Else
                    EnDis(True)
                    SimpleButton2.Text = "SAVE"
                End If
            End If
            Form1.frmRes.GridView1.Columns.Clear()
            'MainForm.frmRes.reload()
            'DelSearch.x = 0
            'DelSearch.reloadGrid("" & DelSearch.txtSelect.Text & " " & DelSearch.txttbl.Text & " where archive = 0 LIMIT 0, 20", "" & DelSearch.txttbl.Text & "")
            'DelSearch.reloadGrid("select " & de & " " & DelSearch.txttbl.Text & " where archive = 0", "" & DelSearch.txttbl.Text & "")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Form1.DashboardViewer1.ReloadData()
    End Sub

    Private Sub EnDis(ByVal bol As Boolean)
        txtAddress.Enabled = bol
        'txtAge.Enabled = bol
        txtBday.Enabled = bol
        txtBPlace.Enabled = bol
        txtCitiz.Enabled = bol
        txtCPno.Enabled = bol
        txtCStatus.Enabled = bol
        txtEducAtt.Enabled = bol
        txtLName.Enabled = bol
        txtMName.Enabled = bol
        txtFName.Enabled = bol
        txtProfession.Enabled = bol
        'txtYrsStay.Enabled = bol
        cbGender.Enabled = bol
        cbZone.Enabled = bol
        btnPhoto.Enabled = bol
        cbDeceased.Enabled = bol
        txtIncome.Enabled = bol
        cbOFW.Enabled = bol
        txtCountry.Enabled = bol
    End Sub
    Private Sub txtBday_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Month(Date.Today) <= Month(txtBday.Value) Then

        If (Date.Today.Day >= txtBday.Value.Day) And (Month(Date.Today) >= Month(txtBday.Value)) Then
            txtAge.Text = DateDiff(DateInterval.Year, txtBday.Value, Date.Now)
        Else
            txtAge.Text = DateDiff(DateInterval.Year, txtBday.Value, Date.Now) - 1
        End If

        ' Else
        'txtAge.Text = DateDiff(DateInterval.Year, txtBday.Value, Date.Now)
        'End If
    End Sub
    Private Sub loadDetails()
        'On Error Resume Next
        Try
            Pop(d, ds, "select * from Resident where ID = " & txtID.Text & "", "Resident")
            If ds.Tables("Resident").Rows.Count > 0 Then

                'cboBrgy.Text = ds.Tables("Resident").Rows(0).Item("Brgy")
                txtLName.Text = ds.Tables("Resident").Rows(0).Item("LName")
                txtFName.Text = ds.Tables("Resident").Rows(0).Item("FName")
                txtMName.Text = ds.Tables("Resident").Rows(0).Item("MName")
                cbGender.Text = ds.Tables("Resident").Rows(0).Item("Gender")
                'txtAge.Text = ds.Tables("Resident").Rows(0).Item("Age")
                txtCPno.Text = ds.Tables("Resident").Rows(0).Item("ContactNo")
                txtBday.Text = ds.Tables("Resident").Rows(0).Item("Birthdate")
                txtBPlace.Text = ds.Tables("Resident").Rows(0).Item("BirthPlace")
                txtCStatus.Text = ds.Tables("Resident").Rows(0).Item("CivilStatus")
                cboReligion.Text = ds.Tables("Resident").Rows(0).Item("Religion")
                txtCitiz.Text = ds.Tables("Resident").Rows(0).Item("Citizenship")
                cbZone.Text = ds.Tables("Resident").Rows(0).Item("Purok")
                txtAddress.Text = ds.Tables("Resident").Rows(0).Item("Address")
                txtProfession.Text = ds.Tables("Resident").Rows(0).Item("Profession")
                txtEducAtt.Text = ds.Tables("Resident").Rows(0).Item("Educattainment")
                'txtYrsStay.Text = Val(ds.Tables("Resident").Rows(0).Item(17))
                txtIncome.Text = Val(ds.Tables("Resident").Rows(0).Item("Income"))
                cbDeceased.Checked = ds.Tables("Resident").Rows(0).Item("Deceased")
                cbOFW.Checked = ds.Tables("Resident").Rows(0).Item("OFW")
                txtCountry.Text = ds.Tables("Resident").Rows(0).Item("Country")
                cbOSY.Checked = ds.Tables("Resident").Rows(0).Item("OSY")
                cbDialysis.Checked = ds.Tables("Resident").Rows(0).Item("DP")
                cbPWD.Checked = ds.Tables("Resident").Rows(0).Item("PWD")
                cbSoloP.Checked = ds.Tables("Resident").Rows(0).Item("SP")
                cbVoter.Checked = ds.Tables("Resident").Rows(0).Item("Voter")
                cbCR.Checked = ds.Tables("Resident").Rows(0).Item("CR")

                Pop(d, ds, "select image from Resident where ID = " & txtID.Text & "", "Resident")
                If ds.Tables("Resident").Rows(0).Item(0) Is DBNull.Value Then
                    'Dim photo As Byte() = Nothing
                    'Dim lstr As New System.IO.MemoryStream(photo)
                    PictureBox1.Image = Nothing
                Else
                    Dim photo As Byte() = ds.Tables("Resident").Rows(0).Item("Image")
                    Dim lstr As New System.IO.MemoryStream(photo)
                    PictureBox1.Image = Image.FromStream(lstr)
                End If

            Else
                clear()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub txtLname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLName.KeyPress
        LettersOnly(e)
    End Sub
    Private Sub txtMname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMName.KeyPress
        LettersOnly(e)
    End Sub
    Private Sub txtFname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFName.KeyPress
        LettersOnly(e)
    End Sub
    Private Sub txtAge_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAge.KeyPress
        NumbersOnly(e)
    End Sub
    Private Sub txtCPno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCPno.KeyPress
        NumbersOnly(e)
    End Sub
    Private Sub txtBPlace_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBPlace.KeyPress
        LettersOnly(e)
    End Sub
    Private Sub txtLname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLName.Leave
        txtLName.Text = UCase(txtLName.Text)
    End Sub
    Private Sub txtMname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMName.Leave
        txtMName.Text = UCase(txtMName.Text)
    End Sub
    Private Sub txtFname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFName.Leave
        txtFName.Text = UCase(txtFName.Text)
    End Sub
    Private Sub txtBPlace_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBPlace.Leave
        txtBPlace.Text = UCase(txtBPlace.Text)
    End Sub
    Private Sub txtAddress_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAddress.Leave
        txtAddress.Text = UCase(txtAddress.Text)
    End Sub
    Private Sub txtCitiz_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCitiz.Leave
        txtCitiz.Text = UCase(txtCitiz.Text)
    End Sub
    Private Sub txtProfession_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProfession.Leave
        txtProfession.Text = UCase(txtProfession.Text)
    End Sub
    Private Sub txtEducAtt_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEducAtt.Leave
        txtEducAtt.Text = UCase(txtEducAtt.Text)
    End Sub
    Private Sub txtYrsStay_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        NumbersOnly(e)
    End Sub
    Private Sub OpenFileDialog1_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles OpenFileDialog1.Disposed
        If txtID.Text = "" Then
            PictureBox1.Image = Nothing
        Else
            Dim mstream As New System.IO.MemoryStream()
            Pop(d, ds, "select image from Resident where ID = " & Val(txtID.Text) & "", "Resident")
            If ds.Tables("Resident").Rows.Count > 0 Then
                Dim photo As Byte() = ds.Tables("Resident").Rows(0).Item("Image")
                Dim lstr As New System.IO.MemoryStream(photo)
                PictureBox1.Image = Image.FromStream(lstr)
                'PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            End If
            mstream.Close()
        End If
    End Sub
    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        filepath = OpenFileDialog1.FileName
        PictureBox1.Image = Image.FromFile(filepath)
    End Sub
    Private Sub txtIncome_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIncome.KeyPress
        NumbersOnly(e)
    End Sub
    Private Sub txtBday_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBday.ValueChanged
        'If (Date.Today.Day >= txtBday.Value.Day) And (Month(Date.Today) >= Month(txtBday.Value)) Then
        'txtAge.Text = DateDiff(DateInterval.Year, txtBday.Value, Date.Now)
        ' Else
        'txtAge.Text = DateDiff(DateInterval.Year, txtBday.Value, Date.Now) - 1
        ' End If
        If (Date.Today.Day >= txtBday.Value.Day) And (Month(Date.Today) >= Month(txtBday.Value)) Then
            txtAge.Text = DateDiff(DateInterval.Year, txtBday.Value, Date.Now)
        Else
            txtAge.Text = DateDiff(DateInterval.Year, txtBday.Value, Date.Now) - 1
        End If
    End Sub
    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Me.Close()
    End Sub
    Private Sub cbOFW_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbOFW.CheckedChanged
        If cbOFW.Checked Then
            txtCountry.Enabled = True
            txtOFW.Text = 1
        Else
            txtCountry.Enabled = False
            txtOFW.Text = 0
        End If
    End Sub
End Class