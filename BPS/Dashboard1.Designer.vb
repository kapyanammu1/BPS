Namespace Win_Dashboards
    Partial Public Class Dashboard1
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim Dimension1 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim GridDimensionColumn1 As DevExpress.DashboardCommon.GridDimensionColumn = New DevExpress.DashboardCommon.GridDimensionColumn()
            Dim Measure1 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim GridMeasureColumn1 As DevExpress.DashboardCommon.GridMeasureColumn = New DevExpress.DashboardCommon.GridMeasureColumn()
            Dim Measure2 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim GridMeasureColumn2 As DevExpress.DashboardCommon.GridMeasureColumn = New DevExpress.DashboardCommon.GridMeasureColumn()
            Dim MySqlConnectionParameters2 As DevExpress.DataAccess.ConnectionParameters.MySqlConnectionParameters = New DevExpress.DataAccess.ConnectionParameters.MySqlConnectionParameters()
            Dim SelectQuery2 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim Column25 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression25 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Table2 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim Column26 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression26 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column27 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression27 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column28 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression28 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column29 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression29 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column30 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression30 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column31 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression31 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column32 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression32 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column33 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression33 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column34 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression34 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column35 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression35 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column36 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression36 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column37 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression37 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column38 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression38 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column39 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression39 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column40 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression40 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column41 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression41 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column42 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression42 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column43 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression43 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column44 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression44 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column45 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression45 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column46 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression46 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column47 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression47 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column48 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression48 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column49 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression49 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column50 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression50 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column51 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression51 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column52 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression52 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column53 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression53 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column54 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression54 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column55 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression55 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column56 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression56 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim MySqlConnectionParameters3 As DevExpress.DataAccess.ConnectionParameters.MySqlConnectionParameters = New DevExpress.DataAccess.ConnectionParameters.MySqlConnectionParameters()
            Dim SelectQuery3 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim Column57 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression57 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Table3 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim Column58 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression58 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column59 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression59 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column60 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression60 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column61 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression61 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column62 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression62 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column63 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression63 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column64 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression64 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Table4 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim Column65 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression65 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column66 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression66 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column67 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression67 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column68 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression68 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column69 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression69 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column70 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression70 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column71 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression71 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column72 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression72 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column73 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression73 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column74 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression74 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column75 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression75 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column76 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression76 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column77 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression77 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column78 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression78 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column79 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression79 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column80 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression80 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column81 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression81 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column82 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression82 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column83 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression83 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column84 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression84 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column85 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression85 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column86 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression86 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column87 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression87 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column88 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression88 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column89 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression89 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column90 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression90 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column91 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression91 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column92 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression92 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column93 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression93 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column94 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression94 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column95 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression95 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Join1 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim RelationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim MySqlConnectionParameters1 As DevExpress.DataAccess.ConnectionParameters.MySqlConnectionParameters = New DevExpress.DataAccess.ConnectionParameters.MySqlConnectionParameters()
            Dim SelectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim Column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim Column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column5 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression5 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column6 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression6 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column7 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression7 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column8 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression8 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column9 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression9 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column10 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression10 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column11 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression11 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column12 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression12 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column13 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression13 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column14 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression14 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column15 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression15 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column16 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression16 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column17 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression17 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column18 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression18 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column19 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression19 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column20 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression20 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column21 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression21 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column22 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression22 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column23 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression23 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column24 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression24 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard1))
            Dim Dimension2 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension3 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure3 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim ChartPane1 As DevExpress.DashboardCommon.ChartPane = New DevExpress.DashboardCommon.ChartPane()
            Dim SimpleSeries1 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim Dimension4 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure4 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim DashboardLayoutGroup1 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutGroup2 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem1 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem2 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem3 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Me.gridDashboardItem1 = New DevExpress.DashboardCommon.GridDashboardItem()
            Me.dashboardSqlDataSource1 = New DevExpress.DashboardCommon.DashboardSqlDataSource()
            Me.dashboardSqlDataSource2 = New DevExpress.DashboardCommon.DashboardSqlDataSource()
            Me.dashboardSqlDataSource3 = New DevExpress.DashboardCommon.DashboardSqlDataSource()
            Me.ChartDashboardItem2 = New DevExpress.DashboardCommon.ChartDashboardItem()
            Me.HouseholdChart = New DevExpress.DashboardCommon.PieDashboardItem()
            CType(Me.gridDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dashboardSqlDataSource2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dashboardSqlDataSource3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ChartDashboardItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.HouseholdChart, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'gridDashboardItem1
            '
            Dimension1.DataMember = "ClearanceNo"
            Dimension1.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
            GridDimensionColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            GridDimensionColumn1.AddDataItem("Dimension", Dimension1)
            Measure1.DataMember = "CTCAmount"
            GridMeasureColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            GridMeasureColumn1.AddDataItem("Measure", Measure1)
            Measure2.DataMember = "ORAmount"
            GridMeasureColumn2.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            GridMeasureColumn2.AddDataItem("Measure", Measure2)
            Me.gridDashboardItem1.Columns.AddRange(New DevExpress.DashboardCommon.GridColumnBase() {GridDimensionColumn1, GridMeasureColumn1, GridMeasureColumn2})
            Me.gridDashboardItem1.ComponentName = "gridDashboardItem1"
            Me.gridDashboardItem1.DataItemRepository.Clear()
            Me.gridDashboardItem1.DataItemRepository.Add(Dimension1, "DataItem0")
            Me.gridDashboardItem1.DataItemRepository.Add(Measure1, "DataItem1")
            Me.gridDashboardItem1.DataItemRepository.Add(Measure2, "DataItem2")
            Me.gridDashboardItem1.DataMember = "brgyclearance"
            Me.gridDashboardItem1.DataSource = Me.dashboardSqlDataSource3
            Me.gridDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.gridDashboardItem1.Name = "Barangay Clearance Lists"
            Me.gridDashboardItem1.ShowCaption = True
            '
            'dashboardSqlDataSource1
            '
            Me.dashboardSqlDataSource1.ComponentName = "dashboardSqlDataSource1"
            Me.dashboardSqlDataSource1.ConnectionName = "localhost_brgydata_Connection"
            MySqlConnectionParameters2.DatabaseName = "brgydata"
            MySqlConnectionParameters2.ServerName = "localhost"
            Me.dashboardSqlDataSource1.ConnectionParameters = MySqlConnectionParameters2
            Me.dashboardSqlDataSource1.Name = "SQL Data Source 1"
            ColumnExpression25.ColumnName = "ID"
            Table2.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""666"" />"
            Table2.Name = "resident"
            ColumnExpression25.Table = Table2
            Column25.Expression = ColumnExpression25
            ColumnExpression26.ColumnName = "Brgy"
            ColumnExpression26.Table = Table2
            Column26.Expression = ColumnExpression26
            ColumnExpression27.ColumnName = "LName"
            ColumnExpression27.Table = Table2
            Column27.Expression = ColumnExpression27
            ColumnExpression28.ColumnName = "FName"
            ColumnExpression28.Table = Table2
            Column28.Expression = ColumnExpression28
            ColumnExpression29.ColumnName = "MName"
            ColumnExpression29.Table = Table2
            Column29.Expression = ColumnExpression29
            ColumnExpression30.ColumnName = "Gender"
            ColumnExpression30.Table = Table2
            Column30.Expression = ColumnExpression30
            ColumnExpression31.ColumnName = "Age"
            ColumnExpression31.Table = Table2
            Column31.Expression = ColumnExpression31
            ColumnExpression32.ColumnName = "ContactNo"
            ColumnExpression32.Table = Table2
            Column32.Expression = ColumnExpression32
            ColumnExpression33.ColumnName = "Birthdate"
            ColumnExpression33.Table = Table2
            Column33.Expression = ColumnExpression33
            ColumnExpression34.ColumnName = "BirthPlace"
            ColumnExpression34.Table = Table2
            Column34.Expression = ColumnExpression34
            ColumnExpression35.ColumnName = "CivilStatus"
            ColumnExpression35.Table = Table2
            Column35.Expression = ColumnExpression35
            ColumnExpression36.ColumnName = "Religion"
            ColumnExpression36.Table = Table2
            Column36.Expression = ColumnExpression36
            ColumnExpression37.ColumnName = "Citizenship"
            ColumnExpression37.Table = Table2
            Column37.Expression = ColumnExpression37
            ColumnExpression38.ColumnName = "Purok"
            ColumnExpression38.Table = Table2
            Column38.Expression = ColumnExpression38
            ColumnExpression39.ColumnName = "Address"
            ColumnExpression39.Table = Table2
            Column39.Expression = ColumnExpression39
            ColumnExpression40.ColumnName = "Profession"
            ColumnExpression40.Table = Table2
            Column40.Expression = ColumnExpression40
            ColumnExpression41.ColumnName = "Educattainment"
            ColumnExpression41.Table = Table2
            Column41.Expression = ColumnExpression41
            ColumnExpression42.ColumnName = "Image"
            ColumnExpression42.Table = Table2
            Column42.Expression = ColumnExpression42
            ColumnExpression43.ColumnName = "FullName"
            ColumnExpression43.Table = Table2
            Column43.Expression = ColumnExpression43
            ColumnExpression44.ColumnName = "Archive"
            ColumnExpression44.Table = Table2
            Column44.Expression = ColumnExpression44
            ColumnExpression45.ColumnName = "Deceased"
            ColumnExpression45.Table = Table2
            Column45.Expression = ColumnExpression45
            ColumnExpression46.ColumnName = "Income"
            ColumnExpression46.Table = Table2
            Column46.Expression = ColumnExpression46
            ColumnExpression47.ColumnName = "OFW"
            ColumnExpression47.Table = Table2
            Column47.Expression = ColumnExpression47
            ColumnExpression48.ColumnName = "PassportNo"
            ColumnExpression48.Table = Table2
            Column48.Expression = ColumnExpression48
            ColumnExpression49.ColumnName = "Country"
            ColumnExpression49.Table = Table2
            Column49.Expression = ColumnExpression49
            ColumnExpression50.ColumnName = "HouseNo"
            ColumnExpression50.Table = Table2
            Column50.Expression = ColumnExpression50
            ColumnExpression51.ColumnName = "PWD"
            ColumnExpression51.Table = Table2
            Column51.Expression = ColumnExpression51
            ColumnExpression52.ColumnName = "DP"
            ColumnExpression52.Table = Table2
            Column52.Expression = ColumnExpression52
            ColumnExpression53.ColumnName = "OSY"
            ColumnExpression53.Table = Table2
            Column53.Expression = ColumnExpression53
            ColumnExpression54.ColumnName = "SP"
            ColumnExpression54.Table = Table2
            Column54.Expression = ColumnExpression54
            ColumnExpression55.ColumnName = "Voter"
            ColumnExpression55.Table = Table2
            Column55.Expression = ColumnExpression55
            ColumnExpression56.ColumnName = "CR"
            ColumnExpression56.Table = Table2
            Column56.Expression = ColumnExpression56
            SelectQuery2.Columns.Add(Column25)
            SelectQuery2.Columns.Add(Column26)
            SelectQuery2.Columns.Add(Column27)
            SelectQuery2.Columns.Add(Column28)
            SelectQuery2.Columns.Add(Column29)
            SelectQuery2.Columns.Add(Column30)
            SelectQuery2.Columns.Add(Column31)
            SelectQuery2.Columns.Add(Column32)
            SelectQuery2.Columns.Add(Column33)
            SelectQuery2.Columns.Add(Column34)
            SelectQuery2.Columns.Add(Column35)
            SelectQuery2.Columns.Add(Column36)
            SelectQuery2.Columns.Add(Column37)
            SelectQuery2.Columns.Add(Column38)
            SelectQuery2.Columns.Add(Column39)
            SelectQuery2.Columns.Add(Column40)
            SelectQuery2.Columns.Add(Column41)
            SelectQuery2.Columns.Add(Column42)
            SelectQuery2.Columns.Add(Column43)
            SelectQuery2.Columns.Add(Column44)
            SelectQuery2.Columns.Add(Column45)
            SelectQuery2.Columns.Add(Column46)
            SelectQuery2.Columns.Add(Column47)
            SelectQuery2.Columns.Add(Column48)
            SelectQuery2.Columns.Add(Column49)
            SelectQuery2.Columns.Add(Column50)
            SelectQuery2.Columns.Add(Column51)
            SelectQuery2.Columns.Add(Column52)
            SelectQuery2.Columns.Add(Column53)
            SelectQuery2.Columns.Add(Column54)
            SelectQuery2.Columns.Add(Column55)
            SelectQuery2.Columns.Add(Column56)
            SelectQuery2.Name = "resident"
            SelectQuery2.Tables.Add(Table2)
            Me.dashboardSqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery2})
            Me.dashboardSqlDataSource1.ResultSchemaSerializable = resources.GetString("dashboardSqlDataSource1.ResultSchemaSerializable")
            '
            'dashboardSqlDataSource2
            '
            Me.dashboardSqlDataSource2.ComponentName = "dashboardSqlDataSource2"
            Me.dashboardSqlDataSource2.ConnectionName = "localhost_brgydata_Connection"
            MySqlConnectionParameters3.DatabaseName = "brgydata"
            MySqlConnectionParameters3.ServerName = "localhost"
            Me.dashboardSqlDataSource2.ConnectionParameters = MySqlConnectionParameters3
            Me.dashboardSqlDataSource2.Name = "SQL Data Source 2"
            ColumnExpression57.ColumnName = "ID"
            Table3.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""191"" />"
            Table3.Name = "family"
            ColumnExpression57.Table = Table3
            Column57.Expression = ColumnExpression57
            ColumnExpression58.ColumnName = "Code"
            ColumnExpression58.Table = Table3
            Column58.Expression = ColumnExpression58
            ColumnExpression59.ColumnName = "HouseNo"
            ColumnExpression59.Table = Table3
            Column59.Expression = ColumnExpression59
            ColumnExpression60.ColumnName = "HouseType"
            ColumnExpression60.Table = Table3
            Column60.Expression = ColumnExpression60
            ColumnExpression61.ColumnName = "ResID"
            ColumnExpression61.Table = Table3
            Column61.Expression = ColumnExpression61
            ColumnExpression62.ColumnName = "Relation"
            ColumnExpression62.Table = Table3
            Column62.Expression = ColumnExpression62
            ColumnExpression63.ColumnName = "Head"
            ColumnExpression63.Table = Table3
            Column63.Expression = ColumnExpression63
            Column64.Alias = "resident_ID"
            ColumnExpression64.ColumnName = "ID"
            Table4.MetaSerializable = "<Meta X=""185"" Y=""30"" Width=""125"" Height=""666"" />"
            Table4.Name = "resident"
            ColumnExpression64.Table = Table4
            Column64.Expression = ColumnExpression64
            ColumnExpression65.ColumnName = "Brgy"
            ColumnExpression65.Table = Table4
            Column65.Expression = ColumnExpression65
            ColumnExpression66.ColumnName = "LName"
            ColumnExpression66.Table = Table4
            Column66.Expression = ColumnExpression66
            ColumnExpression67.ColumnName = "FName"
            ColumnExpression67.Table = Table4
            Column67.Expression = ColumnExpression67
            ColumnExpression68.ColumnName = "MName"
            ColumnExpression68.Table = Table4
            Column68.Expression = ColumnExpression68
            ColumnExpression69.ColumnName = "Gender"
            ColumnExpression69.Table = Table4
            Column69.Expression = ColumnExpression69
            ColumnExpression70.ColumnName = "Age"
            ColumnExpression70.Table = Table4
            Column70.Expression = ColumnExpression70
            ColumnExpression71.ColumnName = "ContactNo"
            ColumnExpression71.Table = Table4
            Column71.Expression = ColumnExpression71
            ColumnExpression72.ColumnName = "Birthdate"
            ColumnExpression72.Table = Table4
            Column72.Expression = ColumnExpression72
            ColumnExpression73.ColumnName = "BirthPlace"
            ColumnExpression73.Table = Table4
            Column73.Expression = ColumnExpression73
            ColumnExpression74.ColumnName = "CivilStatus"
            ColumnExpression74.Table = Table4
            Column74.Expression = ColumnExpression74
            ColumnExpression75.ColumnName = "Religion"
            ColumnExpression75.Table = Table4
            Column75.Expression = ColumnExpression75
            ColumnExpression76.ColumnName = "Citizenship"
            ColumnExpression76.Table = Table4
            Column76.Expression = ColumnExpression76
            ColumnExpression77.ColumnName = "Purok"
            ColumnExpression77.Table = Table4
            Column77.Expression = ColumnExpression77
            ColumnExpression78.ColumnName = "Address"
            ColumnExpression78.Table = Table4
            Column78.Expression = ColumnExpression78
            ColumnExpression79.ColumnName = "Profession"
            ColumnExpression79.Table = Table4
            Column79.Expression = ColumnExpression79
            ColumnExpression80.ColumnName = "Educattainment"
            ColumnExpression80.Table = Table4
            Column80.Expression = ColumnExpression80
            ColumnExpression81.ColumnName = "Image"
            ColumnExpression81.Table = Table4
            Column81.Expression = ColumnExpression81
            ColumnExpression82.ColumnName = "FullName"
            ColumnExpression82.Table = Table4
            Column82.Expression = ColumnExpression82
            ColumnExpression83.ColumnName = "Archive"
            ColumnExpression83.Table = Table4
            Column83.Expression = ColumnExpression83
            ColumnExpression84.ColumnName = "Deceased"
            ColumnExpression84.Table = Table4
            Column84.Expression = ColumnExpression84
            ColumnExpression85.ColumnName = "Income"
            ColumnExpression85.Table = Table4
            Column85.Expression = ColumnExpression85
            ColumnExpression86.ColumnName = "OFW"
            ColumnExpression86.Table = Table4
            Column86.Expression = ColumnExpression86
            ColumnExpression87.ColumnName = "PassportNo"
            ColumnExpression87.Table = Table4
            Column87.Expression = ColumnExpression87
            ColumnExpression88.ColumnName = "Country"
            ColumnExpression88.Table = Table4
            Column88.Expression = ColumnExpression88
            Column89.Alias = "resident_HouseNo"
            ColumnExpression89.ColumnName = "HouseNo"
            ColumnExpression89.Table = Table4
            Column89.Expression = ColumnExpression89
            ColumnExpression90.ColumnName = "PWD"
            ColumnExpression90.Table = Table4
            Column90.Expression = ColumnExpression90
            ColumnExpression91.ColumnName = "DP"
            ColumnExpression91.Table = Table4
            Column91.Expression = ColumnExpression91
            ColumnExpression92.ColumnName = "OSY"
            ColumnExpression92.Table = Table4
            Column92.Expression = ColumnExpression92
            ColumnExpression93.ColumnName = "SP"
            ColumnExpression93.Table = Table4
            Column93.Expression = ColumnExpression93
            ColumnExpression94.ColumnName = "Voter"
            ColumnExpression94.Table = Table4
            Column94.Expression = ColumnExpression94
            ColumnExpression95.ColumnName = "CR"
            ColumnExpression95.Table = Table4
            Column95.Expression = ColumnExpression95
            SelectQuery3.Columns.Add(Column57)
            SelectQuery3.Columns.Add(Column58)
            SelectQuery3.Columns.Add(Column59)
            SelectQuery3.Columns.Add(Column60)
            SelectQuery3.Columns.Add(Column61)
            SelectQuery3.Columns.Add(Column62)
            SelectQuery3.Columns.Add(Column63)
            SelectQuery3.Columns.Add(Column64)
            SelectQuery3.Columns.Add(Column65)
            SelectQuery3.Columns.Add(Column66)
            SelectQuery3.Columns.Add(Column67)
            SelectQuery3.Columns.Add(Column68)
            SelectQuery3.Columns.Add(Column69)
            SelectQuery3.Columns.Add(Column70)
            SelectQuery3.Columns.Add(Column71)
            SelectQuery3.Columns.Add(Column72)
            SelectQuery3.Columns.Add(Column73)
            SelectQuery3.Columns.Add(Column74)
            SelectQuery3.Columns.Add(Column75)
            SelectQuery3.Columns.Add(Column76)
            SelectQuery3.Columns.Add(Column77)
            SelectQuery3.Columns.Add(Column78)
            SelectQuery3.Columns.Add(Column79)
            SelectQuery3.Columns.Add(Column80)
            SelectQuery3.Columns.Add(Column81)
            SelectQuery3.Columns.Add(Column82)
            SelectQuery3.Columns.Add(Column83)
            SelectQuery3.Columns.Add(Column84)
            SelectQuery3.Columns.Add(Column85)
            SelectQuery3.Columns.Add(Column86)
            SelectQuery3.Columns.Add(Column87)
            SelectQuery3.Columns.Add(Column88)
            SelectQuery3.Columns.Add(Column89)
            SelectQuery3.Columns.Add(Column90)
            SelectQuery3.Columns.Add(Column91)
            SelectQuery3.Columns.Add(Column92)
            SelectQuery3.Columns.Add(Column93)
            SelectQuery3.Columns.Add(Column94)
            SelectQuery3.Columns.Add(Column95)
            SelectQuery3.Name = "family"
            RelationColumnInfo1.NestedKeyColumn = "ID"
            RelationColumnInfo1.ParentKeyColumn = "ResID"
            Join1.KeyColumns.Add(RelationColumnInfo1)
            Join1.Nested = Table4
            Join1.Parent = Table3
            Join1.Type = DevExpress.Xpo.DB.JoinType.LeftOuter
            SelectQuery3.Relations.Add(Join1)
            SelectQuery3.Tables.Add(Table3)
            SelectQuery3.Tables.Add(Table4)
            Me.dashboardSqlDataSource2.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery3})
            Me.dashboardSqlDataSource2.ResultSchemaSerializable = resources.GetString("dashboardSqlDataSource2.ResultSchemaSerializable")
            '
            'dashboardSqlDataSource3
            '
            Me.dashboardSqlDataSource3.ComponentName = "dashboardSqlDataSource3"
            Me.dashboardSqlDataSource3.ConnectionName = "localhost_brgydata_Connection"
            MySqlConnectionParameters1.DatabaseName = "brgydata"
            MySqlConnectionParameters1.ServerName = "localhost"
            Me.dashboardSqlDataSource3.ConnectionParameters = MySqlConnectionParameters1
            Me.dashboardSqlDataSource3.Name = "SQL Data Source 3"
            ColumnExpression1.ColumnName = "ID"
            Table1.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""514"" />"
            Table1.Name = "brgyclearance"
            ColumnExpression1.Table = Table1
            Column1.Expression = ColumnExpression1
            ColumnExpression2.ColumnName = "ClearanceNo"
            ColumnExpression2.Table = Table1
            Column2.Expression = ColumnExpression2
            ColumnExpression3.ColumnName = "ResidentID"
            ColumnExpression3.Table = Table1
            Column3.Expression = ColumnExpression3
            ColumnExpression4.ColumnName = "Cap"
            ColumnExpression4.Table = Table1
            Column4.Expression = ColumnExpression4
            ColumnExpression5.ColumnName = "kag1"
            ColumnExpression5.Table = Table1
            Column5.Expression = ColumnExpression5
            ColumnExpression6.ColumnName = "kag2"
            ColumnExpression6.Table = Table1
            Column6.Expression = ColumnExpression6
            ColumnExpression7.ColumnName = "kag3"
            ColumnExpression7.Table = Table1
            Column7.Expression = ColumnExpression7
            ColumnExpression8.ColumnName = "kag4"
            ColumnExpression8.Table = Table1
            Column8.Expression = ColumnExpression8
            ColumnExpression9.ColumnName = "kag5"
            ColumnExpression9.Table = Table1
            Column9.Expression = ColumnExpression9
            ColumnExpression10.ColumnName = "kag6"
            ColumnExpression10.Table = Table1
            Column10.Expression = ColumnExpression10
            ColumnExpression11.ColumnName = "kag7"
            ColumnExpression11.Table = Table1
            Column11.Expression = ColumnExpression11
            ColumnExpression12.ColumnName = "sec"
            ColumnExpression12.Table = Table1
            Column12.Expression = ColumnExpression12
            ColumnExpression13.ColumnName = "tres"
            ColumnExpression13.Table = Table1
            Column13.Expression = ColumnExpression13
            ColumnExpression14.ColumnName = "RecKeeper"
            ColumnExpression14.Table = Table1
            Column14.Expression = ColumnExpression14
            ColumnExpression15.ColumnName = "Sk"
            ColumnExpression15.Table = Table1
            Column15.Expression = ColumnExpression15
            ColumnExpression16.ColumnName = "Purpose"
            ColumnExpression16.Table = Table1
            Column16.Expression = ColumnExpression16
            ColumnExpression17.ColumnName = "Type"
            ColumnExpression17.Table = Table1
            Column17.Expression = ColumnExpression17
            ColumnExpression18.ColumnName = "ORno"
            ColumnExpression18.Table = Table1
            Column18.Expression = ColumnExpression18
            ColumnExpression19.ColumnName = "ORAmount"
            ColumnExpression19.Table = Table1
            Column19.Expression = ColumnExpression19
            ColumnExpression20.ColumnName = "ORDate"
            ColumnExpression20.Table = Table1
            Column20.Expression = ColumnExpression20
            ColumnExpression21.ColumnName = "CTC"
            ColumnExpression21.Table = Table1
            Column21.Expression = ColumnExpression21
            ColumnExpression22.ColumnName = "CTCAmount"
            ColumnExpression22.Table = Table1
            Column22.Expression = ColumnExpression22
            ColumnExpression23.ColumnName = "CTCDate"
            ColumnExpression23.Table = Table1
            Column23.Expression = ColumnExpression23
            ColumnExpression24.ColumnName = "PrintDate"
            ColumnExpression24.Table = Table1
            Column24.Expression = ColumnExpression24
            SelectQuery1.Columns.Add(Column1)
            SelectQuery1.Columns.Add(Column2)
            SelectQuery1.Columns.Add(Column3)
            SelectQuery1.Columns.Add(Column4)
            SelectQuery1.Columns.Add(Column5)
            SelectQuery1.Columns.Add(Column6)
            SelectQuery1.Columns.Add(Column7)
            SelectQuery1.Columns.Add(Column8)
            SelectQuery1.Columns.Add(Column9)
            SelectQuery1.Columns.Add(Column10)
            SelectQuery1.Columns.Add(Column11)
            SelectQuery1.Columns.Add(Column12)
            SelectQuery1.Columns.Add(Column13)
            SelectQuery1.Columns.Add(Column14)
            SelectQuery1.Columns.Add(Column15)
            SelectQuery1.Columns.Add(Column16)
            SelectQuery1.Columns.Add(Column17)
            SelectQuery1.Columns.Add(Column18)
            SelectQuery1.Columns.Add(Column19)
            SelectQuery1.Columns.Add(Column20)
            SelectQuery1.Columns.Add(Column21)
            SelectQuery1.Columns.Add(Column22)
            SelectQuery1.Columns.Add(Column23)
            SelectQuery1.Columns.Add(Column24)
            SelectQuery1.Name = "brgyclearance"
            SelectQuery1.Tables.Add(Table1)
            Me.dashboardSqlDataSource3.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery1})
            Me.dashboardSqlDataSource3.ResultSchemaSerializable = resources.GetString("dashboardSqlDataSource3.ResultSchemaSerializable")
            '
            'ChartDashboardItem2
            '
            Dimension2.DataMember = "Purok"
            Dimension3.DataMember = "Gender"
            Me.ChartDashboardItem2.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension2, Dimension3})
            Me.ChartDashboardItem2.AxisX.TitleVisible = False
            Me.ChartDashboardItem2.ComponentName = "ChartDashboardItem2"
            Measure3.DataMember = "FullName"
            Measure3.Name = "Residents (Count)"
            Measure3.SummaryType = DevExpress.DashboardCommon.SummaryType.Count
            Me.ChartDashboardItem2.DataItemRepository.Clear()
            Me.ChartDashboardItem2.DataItemRepository.Add(Dimension2, "DataItem0")
            Me.ChartDashboardItem2.DataItemRepository.Add(Measure3, "DataItem1")
            Me.ChartDashboardItem2.DataItemRepository.Add(Dimension3, "DataItem2")
            Me.ChartDashboardItem2.DataMember = "resident"
            Me.ChartDashboardItem2.DataSource = Me.dashboardSqlDataSource1
            Me.ChartDashboardItem2.InteractivityOptions.IgnoreMasterFilters = False
            Me.ChartDashboardItem2.Name = "No. Of Residents per Zone"
            ChartPane1.Name = "Pane 1"
            ChartPane1.PrimaryAxisY.AlwaysShowZeroLevel = True
            ChartPane1.PrimaryAxisY.ShowGridLines = True
            ChartPane1.PrimaryAxisY.TitleVisible = True
            ChartPane1.SecondaryAxisY.AlwaysShowZeroLevel = True
            ChartPane1.SecondaryAxisY.ShowGridLines = False
            ChartPane1.SecondaryAxisY.TitleVisible = True
            SimpleSeries1.AddDataItem("Value", Measure3)
            ChartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() {SimpleSeries1})
            Me.ChartDashboardItem2.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() {ChartPane1})
            Me.ChartDashboardItem2.ShowCaption = True
            '
            'HouseholdChart
            '
            Dimension4.DataMember = "Purok"
            Me.HouseholdChart.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension4})
            Me.HouseholdChart.ComponentName = "HouseholdChart"
            Measure4.DataMember = "Code"
            Measure4.Name = "Household Count"
            Measure4.SummaryType = DevExpress.DashboardCommon.SummaryType.CountDistinct
            Me.HouseholdChart.DataItemRepository.Clear()
            Me.HouseholdChart.DataItemRepository.Add(Dimension4, "DataItem0")
            Me.HouseholdChart.DataItemRepository.Add(Measure4, "DataItem1")
            Me.HouseholdChart.DataMember = "family"
            Me.HouseholdChart.DataSource = Me.dashboardSqlDataSource2
            Me.HouseholdChart.InteractivityOptions.IgnoreMasterFilters = False
            Me.HouseholdChart.Name = "Percentage of Household per Zone"
            Me.HouseholdChart.ShowCaption = True
            Me.HouseholdChart.ShowPieCaptions = False
            Me.HouseholdChart.Values.AddRange(New DevExpress.DashboardCommon.Measure() {Measure4})
            '
            'Dashboard1
            '
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() {Me.dashboardSqlDataSource1, Me.dashboardSqlDataSource2, Me.dashboardSqlDataSource3})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() {Me.ChartDashboardItem2, Me.HouseholdChart, Me.gridDashboardItem1})
            DashboardLayoutItem1.DashboardItem = Me.ChartDashboardItem2
            DashboardLayoutItem1.Weight = 50.0R
            DashboardLayoutItem2.DashboardItem = Me.gridDashboardItem1
            DashboardLayoutItem2.Weight = 50.0R
            DashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem1, DashboardLayoutItem2})
            DashboardLayoutGroup2.DashboardItem = Nothing
            DashboardLayoutGroup2.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            DashboardLayoutGroup2.Weight = 50.0R
            DashboardLayoutItem3.DashboardItem = Me.HouseholdChart
            DashboardLayoutItem3.Weight = 50.0R
            DashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutGroup2, DashboardLayoutItem3})
            DashboardLayoutGroup1.DashboardItem = Nothing
            DashboardLayoutGroup1.Weight = 100.0R
            Me.LayoutRoot = DashboardLayoutGroup1
            Me.Title.Text = "Dashboard"
            CType(Dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dashboardSqlDataSource2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dashboardSqlDataSource3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ChartDashboardItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.HouseholdChart, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        Friend WithEvents dashboardSqlDataSource1 As DevExpress.DashboardCommon.DashboardSqlDataSource
        Friend WithEvents dashboardSqlDataSource2 As DevExpress.DashboardCommon.DashboardSqlDataSource
        Friend WithEvents gridDashboardItem1 As DevExpress.DashboardCommon.GridDashboardItem
        Friend WithEvents dashboardSqlDataSource3 As DevExpress.DashboardCommon.DashboardSqlDataSource
        Friend WithEvents ChartDashboardItem2 As DevExpress.DashboardCommon.ChartDashboardItem
        Friend WithEvents HouseholdChart As DevExpress.DashboardCommon.PieDashboardItem

#End Region
    End Class
End Namespace