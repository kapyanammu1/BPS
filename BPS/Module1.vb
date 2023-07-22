Imports MySql.Data.MySqlClient
Module Module1
    Public Server As String
    'Public strMysqlConnection As String = "Provider=Microsoft.jet.Mysql.4.0;data source=C:\Users\Kapyanammu\Desktop\BAC_Ver3.0\BAC_Ver3.0\bin\Debug\dbMalupet.mdb;"
    Public strMySqlConnection As String = "server=" & My.Settings.Server & "; user id=Kapyanammu; password=kapyanammuPassword; database=brgyData"
    'Public strMysqlConnection As String = "server=" & ServerName & "; user id=" & ServerUser & "; password=" & ServerPass & "; database=" & dbName
    Public MysqlConnect As New MySqlConnection(strMySqlConnection)
    Public com As MySqlCommand
    Public dr As MySqlDataReader
    Public queryResult1 As Integer
    'Dim d, dCheck As MySqlDataAdapter, ds, dsCheck As DataSet, MySqlCom As MySqlCommand
    Public Opt As String = ""
    Function Pops(ByRef strAdapter As MySqlDataAdapter, ByRef strDataSet As DataSet, ByVal strSQL As String, ByVal strTable As String, ByVal DataGrid As DataGridView) ', Optional ByRef count As Label)
        strAdapter = New MySqlDataAdapter(strSQL, MysqlConnect)
        strDataSet = New DataSet
        strAdapter.Fill(strDataSet, strTable)
        DataGrid.DataSource = strDataSet.Tables(strTable).DefaultView
        Return True
    End Function
    Function Pop(ByRef strAdapter As MySqlDataAdapter, ByRef strDataSet As DataSet, ByVal strSQL As String, ByVal strTable As String, ByVal DataGrid As DevExpress.XtraGrid.GridControl) ', Optional ByRef count As Label)
        strAdapter = New MySqlDataAdapter(strSQL, MysqlConnect)
        strDataSet = New DataSet
        strAdapter.Fill(strDataSet, strTable)
        DataGrid.DataSource = strDataSet.Tables(strTable).DefaultView
        Return True
    End Function
    Function Pop(ByRef strAdapter As MySqlDataAdapter, ByRef strDataSet As DataSet, ByVal strSQL As String, ByVal strTable As String)
        strAdapter = New MySqlDataAdapter(strSQL, MysqlConnect)
        strDataSet = New DataSet
        strAdapter.Fill(strDataSet, strTable)
        Return True
    End Function
    Function Scan(ByVal TableName As String, ByVal wherevalues As String)
        Dim sqlQRY1 As String = "SELECT COUNT(*) as numRows from " & TableName & " " & wherevalues & ""
        Dim sqlcom1 As New MySqlCommand(sqlQRY1, MysqlConnect)
        queryResult1 = sqlcom1.ExecuteScalar()
        Return True
    End Function
    Function InitDT(ByRef strAdapter As MySqlDataAdapter, ByRef strDataSet As DataSet, ByVal strSQL As String, ByVal strTable As String, ByRef bi As BindingSource, ByRef dt As DataTable, ByVal DataGrid As DataGridView)
        strAdapter = New MySqlDataAdapter(strSQL, MysqlConnect)
        strDataSet = New DataSet
        strAdapter.Fill(strDataSet)
        dt = strDataSet.Tables(0)
        bi.DataSource = dt
        DataGrid.DataSource = bi
        Return True
    End Function
    Function MergeDT(ByRef strAdapter As MySqlDataAdapter, ByRef strDataSet As DataSet, ByVal strSQL As String, ByVal strTable As String, ByRef bi As BindingSource, ByRef dt As DataTable, ByVal DataGrid As DataGridView)
        strAdapter = New MySqlDataAdapter(strSQL, MysqlConnect)
        strDataSet = New DataSet
        strAdapter.Fill(strDataSet)
        dt.Merge(strDataSet.Tables(0))
        bi.DataSource = dt
        DataGrid.DataSource = bi
        Return True
    End Function
    Public Sub SQLstatement(ByVal com As MySqlCommand, ByVal strSQL As String)
        com = New MySqlCommand
        com.Connection = MysqlConnect
        com.CommandText = strSQL
        com.ExecuteNonQuery()
    End Sub
    Function insert(ByVal TableName As String, ByVal fields As String, ByVal values As String)
        com = New MySqlCommand("insert into " & TableName & "(" & fields & ") values (" & values & ")", MysqlConnect)
        com.ExecuteNonQuery()
        Return True
    End Function
    Function Edit(ByVal TableName As String, ByVal fields As String, ByVal wherevalues As String)
        com = New MySqlCommand("UPDATE " & TableName & " set " & fields & " " & wherevalues & "", MysqlConnect)
        com.ExecuteNonQuery()
        Return True
    End Function
    Function Delete(ByVal TableName As String, ByVal Whereval As String)
        com = New MySqlCommand("delete from " & TableName & " " & Whereval & "", MysqlConnect)
        com.ExecuteNonQuery()
        Return True
    End Function
    Function Create(ByVal qry As String)
        com = New MySqlCommand("" & qry & "", MysqlConnect)
        com.ExecuteNonQuery()
        Return True
    End Function
    Function CONNECTION()
        If MysqlConnect.State = ConnectionState.Closed Then MysqlConnect.Open()
        Return True
    End Function
    Function NumbersOnly(ByVal i As System.Windows.Forms.KeyPressEventArgs)
        If Not (Asc(i.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890."
            If Not allowedChars.Contains(i.KeyChar.ToString.ToLower) Then
                i.KeyChar = ChrW(0)
                i.Handled = True
            End If
        End If
        Return True
    End Function
    Function activity(ByVal UserAct As String) As Integer
        Dim action As String
        action = UserAct
        insert("activitylogs", "User,Action,Adate", "'" & MainForm.lblUser.Caption & "','" & action & "','" & Date.Now & "'")
        Return True
    End Function
    Function LettersOnly(ByVal i As System.Windows.Forms.KeyPressEventArgs)
        If Not (Asc(i.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZÑ-., "
            If Not allowedChars.Contains(i.KeyChar.ToString.ToLower) Then
                i.KeyChar = ChrW(0)
                i.Handled = True
            End If
        End If
        Return True
    End Function
End Module
