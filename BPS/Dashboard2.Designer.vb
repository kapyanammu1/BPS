Namespace Win_Dashboards
    Partial Public Class Dashboard2
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
            Dim Column25 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression25 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
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
            Dim Table2 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
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
            Dim Join1 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim RelationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard2))
            Dim Measure1 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Card1 As DevExpress.DashboardCommon.Card = New DevExpress.DashboardCommon.Card()
            Dim CardCenteredLayoutTemplate1 As DevExpress.DashboardCommon.CardCenteredLayoutTemplate = New DevExpress.DashboardCommon.CardCenteredLayoutTemplate()
            Dim Measure2 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Card2 As DevExpress.DashboardCommon.Card = New DevExpress.DashboardCommon.Card()
            Dim CardCenteredLayoutTemplate2 As DevExpress.DashboardCommon.CardCenteredLayoutTemplate = New DevExpress.DashboardCommon.CardCenteredLayoutTemplate()
            Dim Measure3 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Card3 As DevExpress.DashboardCommon.Card = New DevExpress.DashboardCommon.Card()
            Dim CardCenteredLayoutTemplate3 As DevExpress.DashboardCommon.CardCenteredLayoutTemplate = New DevExpress.DashboardCommon.CardCenteredLayoutTemplate()
            Dim Measure4 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Card4 As DevExpress.DashboardCommon.Card = New DevExpress.DashboardCommon.Card()
            Dim CardCenteredLayoutTemplate4 As DevExpress.DashboardCommon.CardCenteredLayoutTemplate = New DevExpress.DashboardCommon.CardCenteredLayoutTemplate()
            Dim Measure5 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Card5 As DevExpress.DashboardCommon.Card = New DevExpress.DashboardCommon.Card()
            Dim CardCenteredLayoutTemplate5 As DevExpress.DashboardCommon.CardCenteredLayoutTemplate = New DevExpress.DashboardCommon.CardCenteredLayoutTemplate()
            Dim Measure6 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Card6 As DevExpress.DashboardCommon.Card = New DevExpress.DashboardCommon.Card()
            Dim CardCenteredLayoutTemplate6 As DevExpress.DashboardCommon.CardCenteredLayoutTemplate = New DevExpress.DashboardCommon.CardCenteredLayoutTemplate()
            Dim SelectQuery2 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim Column40 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression40 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Table3 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
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
            Dim Table4 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
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
            Dim Table5 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim Column57 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression57 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
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
            Dim Table6 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim Column63 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression63 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column64 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression64 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
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
            Dim Table7 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
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
            Dim Table8 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim Column76 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression76 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column77 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression77 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column78 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression78 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column79 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression79 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Join2 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim RelationColumnInfo2 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim Join3 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim RelationColumnInfo3 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim Join4 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim RelationColumnInfo4 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim Join5 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim RelationColumnInfo5 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim Join6 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim RelationColumnInfo6 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim SelectQuery3 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim Column80 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression80 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Table9 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
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
            Dim Column96 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression96 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column97 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression97 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column98 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression98 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column99 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression99 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column100 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression100 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column101 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression101 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column102 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression102 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column103 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression103 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column104 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression104 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column105 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression105 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column106 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression106 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column107 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression107 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column108 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression108 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column109 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression109 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column110 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression110 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column111 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression111 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim SelectQuery4 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim Column112 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression112 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Table10 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim Column113 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression113 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column114 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression114 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column115 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression115 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column116 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression116 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column117 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression117 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column118 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression118 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column119 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression119 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column120 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression120 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column121 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression121 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column122 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression122 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Table11 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim Column123 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression123 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column124 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression124 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column125 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression125 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column126 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression126 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column127 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression127 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column128 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression128 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column129 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression129 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column130 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression130 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column131 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression131 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column132 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression132 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column133 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression133 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Table12 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim Column134 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression134 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column135 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression135 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column136 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression136 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column137 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression137 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column138 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression138 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column139 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression139 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column140 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression140 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column141 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression141 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column142 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression142 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column143 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression143 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Table13 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim Column144 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression144 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column145 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression145 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column146 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression146 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column147 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression147 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column148 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression148 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column149 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression149 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column150 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression150 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Table14 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim Column151 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression151 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column152 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression152 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column153 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression153 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column154 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression154 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column155 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression155 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column156 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression156 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column157 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression157 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column158 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression158 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column159 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression159 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column160 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression160 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column161 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression161 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column162 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression162 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Join7 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim RelationColumnInfo7 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim RelationColumnInfo8 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim Join8 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim RelationColumnInfo9 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim RelationColumnInfo10 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim Join9 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim RelationColumnInfo11 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim RelationColumnInfo12 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim Join10 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim RelationColumnInfo13 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim RelationColumnInfo14 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim Dimension1 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure7 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim ChartPane1 As DevExpress.DashboardCommon.ChartPane = New DevExpress.DashboardCommon.ChartPane()
            Dim SimpleSeries1 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim Dimension2 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure8 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim RunningTotalCalculation1 As DevExpress.DashboardCommon.RunningTotalCalculation = New DevExpress.DashboardCommon.RunningTotalCalculation()
            Dim DashboardLayoutGroup1 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutGroup2 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem1 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem2 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem3 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Me.DashboardSqlDataSource1 = New DevExpress.DashboardCommon.DashboardSqlDataSource()
            Me.CardDashboardItem1 = New DevExpress.DashboardCommon.CardDashboardItem()
            Me.DashboardSqlDataSource2 = New DevExpress.DashboardCommon.DashboardSqlDataSource()
            Me.DashboardResident = New DevExpress.DashboardCommon.DashboardSqlDataSource()
            Me.DashboardSqlDataSource3 = New DevExpress.DashboardCommon.DashboardSqlDataSource()
            Me.ResidentChart = New DevExpress.DashboardCommon.ChartDashboardItem()
            Me.HouseholdChart = New DevExpress.DashboardCommon.PieDashboardItem()
            CType(Me.DashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CardDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DashboardSqlDataSource2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DashboardResident, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DashboardSqlDataSource3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ResidentChart, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.HouseholdChart, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'DashboardSqlDataSource1
            '
            Me.DashboardSqlDataSource1.ComponentName = "DashboardSqlDataSource1"
            Me.DashboardSqlDataSource1.ConnectionName = "BrgyConnection"
            Me.DashboardSqlDataSource1.Name = "MysqlFamily"
            ColumnExpression1.ColumnName = "ID"
            Table1.MetaSerializable = "<Meta X=""185"" Y=""30"" Width=""125"" Height=""666"" />"
            Table1.Name = "resident"
            ColumnExpression1.Table = Table1
            Column1.Expression = ColumnExpression1
            ColumnExpression2.ColumnName = "Brgy"
            ColumnExpression2.Table = Table1
            Column2.Expression = ColumnExpression2
            ColumnExpression3.ColumnName = "LName"
            ColumnExpression3.Table = Table1
            Column3.Expression = ColumnExpression3
            ColumnExpression4.ColumnName = "FName"
            ColumnExpression4.Table = Table1
            Column4.Expression = ColumnExpression4
            ColumnExpression5.ColumnName = "MName"
            ColumnExpression5.Table = Table1
            Column5.Expression = ColumnExpression5
            ColumnExpression6.ColumnName = "Gender"
            ColumnExpression6.Table = Table1
            Column6.Expression = ColumnExpression6
            ColumnExpression7.ColumnName = "Age"
            ColumnExpression7.Table = Table1
            Column7.Expression = ColumnExpression7
            ColumnExpression8.ColumnName = "ContactNo"
            ColumnExpression8.Table = Table1
            Column8.Expression = ColumnExpression8
            ColumnExpression9.ColumnName = "Birthdate"
            ColumnExpression9.Table = Table1
            Column9.Expression = ColumnExpression9
            ColumnExpression10.ColumnName = "BirthPlace"
            ColumnExpression10.Table = Table1
            Column10.Expression = ColumnExpression10
            ColumnExpression11.ColumnName = "CivilStatus"
            ColumnExpression11.Table = Table1
            Column11.Expression = ColumnExpression11
            ColumnExpression12.ColumnName = "Religion"
            ColumnExpression12.Table = Table1
            Column12.Expression = ColumnExpression12
            ColumnExpression13.ColumnName = "Citizenship"
            ColumnExpression13.Table = Table1
            Column13.Expression = ColumnExpression13
            ColumnExpression14.ColumnName = "Purok"
            ColumnExpression14.Table = Table1
            Column14.Expression = ColumnExpression14
            ColumnExpression15.ColumnName = "Address"
            ColumnExpression15.Table = Table1
            Column15.Expression = ColumnExpression15
            ColumnExpression16.ColumnName = "Profession"
            ColumnExpression16.Table = Table1
            Column16.Expression = ColumnExpression16
            ColumnExpression17.ColumnName = "Educattainment"
            ColumnExpression17.Table = Table1
            Column17.Expression = ColumnExpression17
            ColumnExpression18.ColumnName = "Image"
            ColumnExpression18.Table = Table1
            Column18.Expression = ColumnExpression18
            ColumnExpression19.ColumnName = "FullName"
            ColumnExpression19.Table = Table1
            Column19.Expression = ColumnExpression19
            ColumnExpression20.ColumnName = "Archive"
            ColumnExpression20.Table = Table1
            Column20.Expression = ColumnExpression20
            ColumnExpression21.ColumnName = "Deceased"
            ColumnExpression21.Table = Table1
            Column21.Expression = ColumnExpression21
            ColumnExpression22.ColumnName = "Income"
            ColumnExpression22.Table = Table1
            Column22.Expression = ColumnExpression22
            ColumnExpression23.ColumnName = "OFW"
            ColumnExpression23.Table = Table1
            Column23.Expression = ColumnExpression23
            ColumnExpression24.ColumnName = "PassportNo"
            ColumnExpression24.Table = Table1
            Column24.Expression = ColumnExpression24
            ColumnExpression25.ColumnName = "Country"
            ColumnExpression25.Table = Table1
            Column25.Expression = ColumnExpression25
            ColumnExpression26.ColumnName = "HouseNo"
            ColumnExpression26.Table = Table1
            Column26.Expression = ColumnExpression26
            ColumnExpression27.ColumnName = "PWD"
            ColumnExpression27.Table = Table1
            Column27.Expression = ColumnExpression27
            ColumnExpression28.ColumnName = "DP"
            ColumnExpression28.Table = Table1
            Column28.Expression = ColumnExpression28
            ColumnExpression29.ColumnName = "OSY"
            ColumnExpression29.Table = Table1
            Column29.Expression = ColumnExpression29
            ColumnExpression30.ColumnName = "SP"
            ColumnExpression30.Table = Table1
            Column30.Expression = ColumnExpression30
            ColumnExpression31.ColumnName = "Voter"
            ColumnExpression31.Table = Table1
            Column31.Expression = ColumnExpression31
            ColumnExpression32.ColumnName = "CR"
            ColumnExpression32.Table = Table1
            Column32.Expression = ColumnExpression32
            Column33.Alias = "family_ID"
            ColumnExpression33.ColumnName = "ID"
            Table2.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""191"" />"
            Table2.Name = "family"
            ColumnExpression33.Table = Table2
            Column33.Expression = ColumnExpression33
            ColumnExpression34.ColumnName = "Code"
            ColumnExpression34.Table = Table2
            Column34.Expression = ColumnExpression34
            Column35.Alias = "family_HouseNo"
            ColumnExpression35.ColumnName = "HouseNo"
            ColumnExpression35.Table = Table2
            Column35.Expression = ColumnExpression35
            ColumnExpression36.ColumnName = "HouseType"
            ColumnExpression36.Table = Table2
            Column36.Expression = ColumnExpression36
            ColumnExpression37.ColumnName = "ResID"
            ColumnExpression37.Table = Table2
            Column37.Expression = ColumnExpression37
            ColumnExpression38.ColumnName = "Relation"
            ColumnExpression38.Table = Table2
            Column38.Expression = ColumnExpression38
            ColumnExpression39.ColumnName = "Head"
            ColumnExpression39.Table = Table2
            Column39.Expression = ColumnExpression39
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
            SelectQuery1.Columns.Add(Column25)
            SelectQuery1.Columns.Add(Column26)
            SelectQuery1.Columns.Add(Column27)
            SelectQuery1.Columns.Add(Column28)
            SelectQuery1.Columns.Add(Column29)
            SelectQuery1.Columns.Add(Column30)
            SelectQuery1.Columns.Add(Column31)
            SelectQuery1.Columns.Add(Column32)
            SelectQuery1.Columns.Add(Column33)
            SelectQuery1.Columns.Add(Column34)
            SelectQuery1.Columns.Add(Column35)
            SelectQuery1.Columns.Add(Column36)
            SelectQuery1.Columns.Add(Column37)
            SelectQuery1.Columns.Add(Column38)
            SelectQuery1.Columns.Add(Column39)
            SelectQuery1.Name = "family"
            RelationColumnInfo1.NestedKeyColumn = "ID"
            RelationColumnInfo1.ParentKeyColumn = "ResID"
            Join1.KeyColumns.Add(RelationColumnInfo1)
            Join1.Nested = Table1
            Join1.Parent = Table2
            SelectQuery1.Relations.Add(Join1)
            SelectQuery1.Tables.Add(Table2)
            SelectQuery1.Tables.Add(Table1)
            Me.DashboardSqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery1})
            Me.DashboardSqlDataSource1.ResultSchemaSerializable = resources.GetString("DashboardSqlDataSource1.ResultSchemaSerializable")
            '
            'CardDashboardItem1
            '
            Measure1.DataMember = "CaseNo"
            Measure1.Name = "Complaint(s)"
            Measure1.SummaryType = DevExpress.DashboardCommon.SummaryType.CountDistinct
            CardCenteredLayoutTemplate1.BottomSubValue1.DimensionIndex = 0
            CardCenteredLayoutTemplate1.BottomSubValue1.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.AbsoluteVariation
            CardCenteredLayoutTemplate1.BottomSubValue1.Visible = True
            CardCenteredLayoutTemplate1.BottomSubValue2.DimensionIndex = 0
            CardCenteredLayoutTemplate1.BottomSubValue2.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.PercentVariation
            CardCenteredLayoutTemplate1.BottomSubValue2.Visible = True
            CardCenteredLayoutTemplate1.BottomValue.DimensionIndex = 0
            CardCenteredLayoutTemplate1.BottomValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.ActualValue
            CardCenteredLayoutTemplate1.BottomValue.Visible = True
            CardCenteredLayoutTemplate1.DeltaIndicator.Visible = True
            CardCenteredLayoutTemplate1.MainValue.DimensionIndex = 0
            CardCenteredLayoutTemplate1.MainValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.Title
            CardCenteredLayoutTemplate1.MainValue.Visible = True
            CardCenteredLayoutTemplate1.MaxWidth = 270
            CardCenteredLayoutTemplate1.MinWidth = 270
            CardCenteredLayoutTemplate1.Sparkline.Visible = True
            CardCenteredLayoutTemplate1.SubValue.DimensionIndex = 0
            CardCenteredLayoutTemplate1.SubValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.Subtitle
            CardCenteredLayoutTemplate1.SubValue.Visible = True
            Card1.LayoutTemplate = CardCenteredLayoutTemplate1
            Card1.AddDataItem("ActualValue", Measure1)
            Measure2.DataMember = "form98_CaseNo"
            Measure2.Name = "Notice of Hearing"
            Measure2.SummaryType = DevExpress.DashboardCommon.SummaryType.CountDistinct
            CardCenteredLayoutTemplate2.BottomSubValue1.DimensionIndex = 0
            CardCenteredLayoutTemplate2.BottomSubValue1.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.AbsoluteVariation
            CardCenteredLayoutTemplate2.BottomSubValue1.Visible = True
            CardCenteredLayoutTemplate2.BottomSubValue2.DimensionIndex = 0
            CardCenteredLayoutTemplate2.BottomSubValue2.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.PercentVariation
            CardCenteredLayoutTemplate2.BottomSubValue2.Visible = True
            CardCenteredLayoutTemplate2.BottomValue.DimensionIndex = 0
            CardCenteredLayoutTemplate2.BottomValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.ActualValue
            CardCenteredLayoutTemplate2.BottomValue.Visible = True
            CardCenteredLayoutTemplate2.DeltaIndicator.Visible = True
            CardCenteredLayoutTemplate2.MainValue.DimensionIndex = 0
            CardCenteredLayoutTemplate2.MainValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.Title
            CardCenteredLayoutTemplate2.MainValue.Visible = True
            CardCenteredLayoutTemplate2.MaxWidth = 270
            CardCenteredLayoutTemplate2.MinWidth = 270
            CardCenteredLayoutTemplate2.Sparkline.Visible = True
            CardCenteredLayoutTemplate2.SubValue.DimensionIndex = 0
            CardCenteredLayoutTemplate2.SubValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.Subtitle
            CardCenteredLayoutTemplate2.SubValue.Visible = True
            Card2.LayoutTemplate = CardCenteredLayoutTemplate2
            Card2.AddDataItem("ActualValue", Measure2)
            Measure3.DataMember = "CaseNO"
            Measure3.Name = "Summon"
            Measure3.SummaryType = DevExpress.DashboardCommon.SummaryType.CountDistinct
            CardCenteredLayoutTemplate3.BottomSubValue1.DimensionIndex = 0
            CardCenteredLayoutTemplate3.BottomSubValue1.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.AbsoluteVariation
            CardCenteredLayoutTemplate3.BottomSubValue1.Visible = True
            CardCenteredLayoutTemplate3.BottomSubValue2.DimensionIndex = 0
            CardCenteredLayoutTemplate3.BottomSubValue2.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.PercentVariation
            CardCenteredLayoutTemplate3.BottomSubValue2.Visible = True
            CardCenteredLayoutTemplate3.BottomValue.DimensionIndex = 0
            CardCenteredLayoutTemplate3.BottomValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.ActualValue
            CardCenteredLayoutTemplate3.BottomValue.Visible = True
            CardCenteredLayoutTemplate3.DeltaIndicator.Visible = True
            CardCenteredLayoutTemplate3.MainValue.DimensionIndex = 0
            CardCenteredLayoutTemplate3.MainValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.Title
            CardCenteredLayoutTemplate3.MainValue.Visible = True
            CardCenteredLayoutTemplate3.MaxWidth = 270
            CardCenteredLayoutTemplate3.MinWidth = 270
            CardCenteredLayoutTemplate3.Sparkline.Visible = True
            CardCenteredLayoutTemplate3.SubValue.DimensionIndex = 0
            CardCenteredLayoutTemplate3.SubValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.Subtitle
            CardCenteredLayoutTemplate3.SubValue.Visible = True
            Card3.LayoutTemplate = CardCenteredLayoutTemplate3
            Card3.AddDataItem("ActualValue", Measure3)
            Measure4.DataMember = "form100_CaseNO"
            Measure4.Name = "Officer's Return"
            Measure4.SummaryType = DevExpress.DashboardCommon.SummaryType.CountDistinct
            CardCenteredLayoutTemplate4.BottomSubValue1.DimensionIndex = 0
            CardCenteredLayoutTemplate4.BottomSubValue1.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.AbsoluteVariation
            CardCenteredLayoutTemplate4.BottomSubValue1.Visible = True
            CardCenteredLayoutTemplate4.BottomSubValue2.DimensionIndex = 0
            CardCenteredLayoutTemplate4.BottomSubValue2.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.PercentVariation
            CardCenteredLayoutTemplate4.BottomSubValue2.Visible = True
            CardCenteredLayoutTemplate4.BottomValue.DimensionIndex = 0
            CardCenteredLayoutTemplate4.BottomValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.ActualValue
            CardCenteredLayoutTemplate4.BottomValue.Visible = True
            CardCenteredLayoutTemplate4.DeltaIndicator.Visible = True
            CardCenteredLayoutTemplate4.MainValue.DimensionIndex = 0
            CardCenteredLayoutTemplate4.MainValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.Title
            CardCenteredLayoutTemplate4.MainValue.Visible = True
            CardCenteredLayoutTemplate4.MaxWidth = 270
            CardCenteredLayoutTemplate4.MinWidth = 270
            CardCenteredLayoutTemplate4.Sparkline.Visible = True
            CardCenteredLayoutTemplate4.SubValue.DimensionIndex = 0
            CardCenteredLayoutTemplate4.SubValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.Subtitle
            CardCenteredLayoutTemplate4.SubValue.Visible = True
            Card4.LayoutTemplate = CardCenteredLayoutTemplate4
            Card4.AddDataItem("ActualValue", Measure4)
            Measure5.DataMember = "form102_CaseNO"
            Measure5.Name = "Certificate to File Action"
            Measure5.SummaryType = DevExpress.DashboardCommon.SummaryType.CountDistinct
            CardCenteredLayoutTemplate5.BottomSubValue1.DimensionIndex = 0
            CardCenteredLayoutTemplate5.BottomSubValue1.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.AbsoluteVariation
            CardCenteredLayoutTemplate5.BottomSubValue1.Visible = True
            CardCenteredLayoutTemplate5.BottomSubValue2.DimensionIndex = 0
            CardCenteredLayoutTemplate5.BottomSubValue2.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.PercentVariation
            CardCenteredLayoutTemplate5.BottomSubValue2.Visible = True
            CardCenteredLayoutTemplate5.BottomValue.DimensionIndex = 0
            CardCenteredLayoutTemplate5.BottomValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.ActualValue
            CardCenteredLayoutTemplate5.BottomValue.Visible = True
            CardCenteredLayoutTemplate5.DeltaIndicator.Visible = True
            CardCenteredLayoutTemplate5.MainValue.DimensionIndex = 0
            CardCenteredLayoutTemplate5.MainValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.Title
            CardCenteredLayoutTemplate5.MainValue.Visible = True
            CardCenteredLayoutTemplate5.MaxWidth = 270
            CardCenteredLayoutTemplate5.MinWidth = 270
            CardCenteredLayoutTemplate5.Sparkline.Visible = True
            CardCenteredLayoutTemplate5.SubValue.DimensionIndex = 0
            CardCenteredLayoutTemplate5.SubValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.Subtitle
            CardCenteredLayoutTemplate5.SubValue.Visible = True
            Card5.LayoutTemplate = CardCenteredLayoutTemplate5
            Card5.AddDataItem("ActualValue", Measure5)
            Measure6.DataMember = "form112_CaseNo"
            Measure6.Name = "Notice to Chosen Pangkat Members"
            Measure6.SummaryType = DevExpress.DashboardCommon.SummaryType.CountDistinct
            CardCenteredLayoutTemplate6.BottomSubValue1.DimensionIndex = 0
            CardCenteredLayoutTemplate6.BottomSubValue1.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.AbsoluteVariation
            CardCenteredLayoutTemplate6.BottomSubValue1.Visible = True
            CardCenteredLayoutTemplate6.BottomSubValue2.DimensionIndex = 0
            CardCenteredLayoutTemplate6.BottomSubValue2.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.PercentVariation
            CardCenteredLayoutTemplate6.BottomSubValue2.Visible = True
            CardCenteredLayoutTemplate6.BottomValue.DimensionIndex = 0
            CardCenteredLayoutTemplate6.BottomValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.ActualValue
            CardCenteredLayoutTemplate6.BottomValue.Visible = True
            CardCenteredLayoutTemplate6.DeltaIndicator.Visible = True
            CardCenteredLayoutTemplate6.MainValue.DimensionIndex = 0
            CardCenteredLayoutTemplate6.MainValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.Title
            CardCenteredLayoutTemplate6.MainValue.Visible = True
            CardCenteredLayoutTemplate6.MaxWidth = 270
            CardCenteredLayoutTemplate6.MinWidth = 270
            CardCenteredLayoutTemplate6.Sparkline.Visible = True
            CardCenteredLayoutTemplate6.SubValue.DimensionIndex = 0
            CardCenteredLayoutTemplate6.SubValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.Subtitle
            CardCenteredLayoutTemplate6.SubValue.Visible = True
            Card6.LayoutTemplate = CardCenteredLayoutTemplate6
            Card6.AddDataItem("ActualValue", Measure6)
            Me.CardDashboardItem1.Cards.AddRange(New DevExpress.DashboardCommon.Card() {Card1, Card2, Card3, Card4, Card5, Card6})
            Me.CardDashboardItem1.ComponentName = "CardDashboardItem1"
            Me.CardDashboardItem1.DataItemRepository.Clear()
            Me.CardDashboardItem1.DataItemRepository.Add(Measure1, "DataItem0")
            Me.CardDashboardItem1.DataItemRepository.Add(Measure2, "DataItem1")
            Me.CardDashboardItem1.DataItemRepository.Add(Measure3, "DataItem2")
            Me.CardDashboardItem1.DataItemRepository.Add(Measure4, "DataItem3")
            Me.CardDashboardItem1.DataItemRepository.Add(Measure5, "DataItem4")
            Me.CardDashboardItem1.DataItemRepository.Add(Measure6, "DataItem5")
            Me.CardDashboardItem1.DataMember = "form97"
            Me.CardDashboardItem1.DataSource = Me.DashboardSqlDataSource2
            Me.CardDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.CardDashboardItem1.Name = "Katarungang PamBarangay Cases Count"
            Me.CardDashboardItem1.ShowCaption = True
            '
            'DashboardSqlDataSource2
            '
            Me.DashboardSqlDataSource2.ComponentName = "DashboardSqlDataSource2"
            Me.DashboardSqlDataSource2.ConnectionName = "BrgyConnection"
            Me.DashboardSqlDataSource2.Name = "MysqlKatarungan"
            ColumnExpression40.ColumnName = "ID"
            Table3.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""248"" />"
            Table3.Name = "form97"
            ColumnExpression40.Table = Table3
            Column40.Expression = ColumnExpression40
            ColumnExpression41.ColumnName = "CaseNo"
            ColumnExpression41.Table = Table3
            Column41.Expression = ColumnExpression41
            ColumnExpression42.ColumnName = "ComplainantName"
            ColumnExpression42.Table = Table3
            Column42.Expression = ColumnExpression42
            ColumnExpression43.ColumnName = "RespondentName"
            ColumnExpression43.Table = Table3
            Column43.Expression = ColumnExpression43
            ColumnExpression44.ColumnName = "Forr"
            ColumnExpression44.Table = Table3
            Column44.Expression = ColumnExpression44
            ColumnExpression45.ColumnName = "Complaint"
            ColumnExpression45.Table = Table3
            Column45.Expression = ColumnExpression45
            ColumnExpression46.ColumnName = "relief"
            ColumnExpression46.Table = Table3
            Column46.Expression = ColumnExpression46
            ColumnExpression47.ColumnName = "CDate"
            ColumnExpression47.Table = Table3
            Column47.Expression = ColumnExpression47
            ColumnExpression48.ColumnName = "Cap"
            ColumnExpression48.Table = Table3
            Column48.Expression = ColumnExpression48
            ColumnExpression49.ColumnName = "Sec"
            ColumnExpression49.Table = Table3
            Column49.Expression = ColumnExpression49
            Column50.Alias = "form98_ID"
            ColumnExpression50.ColumnName = "ID"
            Table4.MetaSerializable = "<Meta X=""220"" Y=""40"" Width=""125"" Height=""172"" />"
            Table4.Name = "form98"
            ColumnExpression50.Table = Table4
            Column50.Expression = ColumnExpression50
            Column51.Alias = "form98_CaseNo"
            ColumnExpression51.ColumnName = "CaseNo"
            ColumnExpression51.Table = Table4
            Column51.Expression = ColumnExpression51
            ColumnExpression52.ColumnName = "PrintDate"
            ColumnExpression52.Table = Table4
            Column52.Expression = ColumnExpression52
            Column53.Alias = "form98_CDate"
            ColumnExpression53.ColumnName = "CDate"
            ColumnExpression53.Table = Table4
            Column53.Expression = ColumnExpression53
            Column54.Alias = "form98_Cap"
            ColumnExpression54.ColumnName = "Cap"
            ColumnExpression54.Table = Table4
            Column54.Expression = ColumnExpression54
            Column55.Alias = "form98_Sec"
            ColumnExpression55.ColumnName = "Sec"
            ColumnExpression55.Table = Table4
            Column55.Expression = ColumnExpression55
            Column56.Alias = "form99_ID"
            ColumnExpression56.ColumnName = "ID"
            Table5.MetaSerializable = "<Meta X=""375"" Y=""30"" Width=""125"" Height=""172"" />"
            Table5.Name = "form99"
            ColumnExpression56.Table = Table5
            Column56.Expression = ColumnExpression56
            ColumnExpression57.ColumnName = "CaseNO"
            ColumnExpression57.Table = Table5
            Column57.Expression = ColumnExpression57
            Column58.Alias = "form99_PrintDate"
            ColumnExpression58.ColumnName = "PrintDate"
            ColumnExpression58.Table = Table5
            Column58.Expression = ColumnExpression58
            Column59.Alias = "form99_CDate"
            ColumnExpression59.ColumnName = "CDate"
            ColumnExpression59.Table = Table5
            Column59.Expression = ColumnExpression59
            Column60.Alias = "form99_Cap"
            ColumnExpression60.ColumnName = "Cap"
            ColumnExpression60.Table = Table5
            Column60.Expression = ColumnExpression60
            Column61.Alias = "form99_Sec"
            ColumnExpression61.ColumnName = "Sec"
            ColumnExpression61.Table = Table5
            Column61.Expression = ColumnExpression61
            Column62.Alias = "form100_ID"
            ColumnExpression62.ColumnName = "ID"
            Table6.MetaSerializable = "<Meta X=""260"" Y=""240"" Width=""125"" Height=""210"" />"
            Table6.Name = "form100"
            ColumnExpression62.Table = Table6
            Column62.Expression = ColumnExpression62
            Column63.Alias = "form100_CaseNO"
            ColumnExpression63.ColumnName = "CaseNO"
            ColumnExpression63.Table = Table6
            Column63.Expression = ColumnExpression63
            ColumnExpression64.ColumnName = "ServedDate"
            ColumnExpression64.Table = Table6
            Column64.Expression = ColumnExpression64
            Column65.Alias = "form100_PrintDate"
            ColumnExpression65.ColumnName = "PrintDate"
            ColumnExpression65.Table = Table6
            Column65.Expression = ColumnExpression65
            ColumnExpression66.ColumnName = "Officer"
            ColumnExpression66.Table = Table6
            Column66.Expression = ColumnExpression66
            ColumnExpression67.ColumnName = "ServedBy"
            ColumnExpression67.Table = Table6
            Column67.Expression = ColumnExpression67
            ColumnExpression68.ColumnName = "Dwell"
            ColumnExpression68.Table = Table6
            Column68.Expression = ColumnExpression68
            ColumnExpression69.ColumnName = "Office"
            ColumnExpression69.Table = Table6
            Column69.Expression = ColumnExpression69
            Column70.Alias = "form102_ID"
            ColumnExpression70.ColumnName = "ID"
            Table7.MetaSerializable = "<Meta X=""420"" Y=""230"" Width=""125"" Height=""153"" />"
            Table7.Name = "form102"
            ColumnExpression70.Table = Table7
            Column70.Expression = ColumnExpression70
            Column71.Alias = "form102_CaseNO"
            ColumnExpression71.ColumnName = "CaseNO"
            ColumnExpression71.Table = Table7
            Column71.Expression = ColumnExpression71
            ColumnExpression72.ColumnName = "Chosen"
            ColumnExpression72.Table = Table7
            Column72.Expression = ColumnExpression72
            Column73.Alias = "form102_PrintDate"
            ColumnExpression73.ColumnName = "PrintDate"
            ColumnExpression73.Table = Table7
            Column73.Expression = ColumnExpression73
            Column74.Alias = "form102_Cap"
            ColumnExpression74.ColumnName = "Cap"
            ColumnExpression74.Table = Table7
            Column74.Expression = ColumnExpression74
            Column75.Alias = "form112_ID"
            ColumnExpression75.ColumnName = "ID"
            Table8.MetaSerializable = "<Meta X=""100"" Y=""300"" Width=""125"" Height=""153"" />"
            Table8.Name = "form112"
            ColumnExpression75.Table = Table8
            Column75.Expression = ColumnExpression75
            Column76.Alias = "form112_CaseNo"
            ColumnExpression76.ColumnName = "CaseNo"
            ColumnExpression76.Table = Table8
            Column76.Expression = ColumnExpression76
            Column77.Alias = "form112_PrintDate"
            ColumnExpression77.ColumnName = "PrintDate"
            ColumnExpression77.Table = Table8
            Column77.Expression = ColumnExpression77
            Column78.Alias = "form112_Cap"
            ColumnExpression78.ColumnName = "Cap"
            ColumnExpression78.Table = Table8
            Column78.Expression = ColumnExpression78
            Column79.Alias = "form112_Sec"
            ColumnExpression79.ColumnName = "Sec"
            ColumnExpression79.Table = Table8
            Column79.Expression = ColumnExpression79
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
            SelectQuery2.Columns.Add(Column57)
            SelectQuery2.Columns.Add(Column58)
            SelectQuery2.Columns.Add(Column59)
            SelectQuery2.Columns.Add(Column60)
            SelectQuery2.Columns.Add(Column61)
            SelectQuery2.Columns.Add(Column62)
            SelectQuery2.Columns.Add(Column63)
            SelectQuery2.Columns.Add(Column64)
            SelectQuery2.Columns.Add(Column65)
            SelectQuery2.Columns.Add(Column66)
            SelectQuery2.Columns.Add(Column67)
            SelectQuery2.Columns.Add(Column68)
            SelectQuery2.Columns.Add(Column69)
            SelectQuery2.Columns.Add(Column70)
            SelectQuery2.Columns.Add(Column71)
            SelectQuery2.Columns.Add(Column72)
            SelectQuery2.Columns.Add(Column73)
            SelectQuery2.Columns.Add(Column74)
            SelectQuery2.Columns.Add(Column75)
            SelectQuery2.Columns.Add(Column76)
            SelectQuery2.Columns.Add(Column77)
            SelectQuery2.Columns.Add(Column78)
            SelectQuery2.Columns.Add(Column79)
            SelectQuery2.Name = "form97"
            RelationColumnInfo2.NestedKeyColumn = "CaseNo"
            RelationColumnInfo2.ParentKeyColumn = "CaseNo"
            Join2.KeyColumns.Add(RelationColumnInfo2)
            Join2.Nested = Table4
            Join2.Parent = Table3
            Join2.Type = DevExpress.Xpo.DB.JoinType.LeftOuter
            RelationColumnInfo3.NestedKeyColumn = "CaseNO"
            RelationColumnInfo3.ParentKeyColumn = "CaseNo"
            Join3.KeyColumns.Add(RelationColumnInfo3)
            Join3.Nested = Table5
            Join3.Parent = Table3
            Join3.Type = DevExpress.Xpo.DB.JoinType.LeftOuter
            RelationColumnInfo4.NestedKeyColumn = "CaseNO"
            RelationColumnInfo4.ParentKeyColumn = "CaseNo"
            Join4.KeyColumns.Add(RelationColumnInfo4)
            Join4.Nested = Table6
            Join4.Parent = Table3
            Join4.Type = DevExpress.Xpo.DB.JoinType.LeftOuter
            RelationColumnInfo5.NestedKeyColumn = "CaseNO"
            RelationColumnInfo5.ParentKeyColumn = "CaseNo"
            Join5.KeyColumns.Add(RelationColumnInfo5)
            Join5.Nested = Table7
            Join5.Parent = Table3
            Join5.Type = DevExpress.Xpo.DB.JoinType.LeftOuter
            RelationColumnInfo6.NestedKeyColumn = "CaseNo"
            RelationColumnInfo6.ParentKeyColumn = "CaseNo"
            Join6.KeyColumns.Add(RelationColumnInfo6)
            Join6.Nested = Table8
            Join6.Parent = Table3
            Join6.Type = DevExpress.Xpo.DB.JoinType.LeftOuter
            SelectQuery2.Relations.Add(Join2)
            SelectQuery2.Relations.Add(Join3)
            SelectQuery2.Relations.Add(Join4)
            SelectQuery2.Relations.Add(Join5)
            SelectQuery2.Relations.Add(Join6)
            SelectQuery2.Tables.Add(Table3)
            SelectQuery2.Tables.Add(Table4)
            SelectQuery2.Tables.Add(Table5)
            SelectQuery2.Tables.Add(Table6)
            SelectQuery2.Tables.Add(Table7)
            SelectQuery2.Tables.Add(Table8)
            Me.DashboardSqlDataSource2.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery2})
            Me.DashboardSqlDataSource2.ResultSchemaSerializable = resources.GetString("DashboardSqlDataSource2.ResultSchemaSerializable")
            '
            'DashboardResident
            '
            Me.DashboardResident.ComponentName = "DashboardResident"
            Me.DashboardResident.ConnectionName = "BrgyConnection"
            Me.DashboardResident.Name = "MysqlResident"
            ColumnExpression80.ColumnName = "ID"
            Table9.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""666"" />"
            Table9.Name = "resident"
            ColumnExpression80.Table = Table9
            Column80.Expression = ColumnExpression80
            ColumnExpression81.ColumnName = "Brgy"
            ColumnExpression81.Table = Table9
            Column81.Expression = ColumnExpression81
            ColumnExpression82.ColumnName = "LName"
            ColumnExpression82.Table = Table9
            Column82.Expression = ColumnExpression82
            ColumnExpression83.ColumnName = "FName"
            ColumnExpression83.Table = Table9
            Column83.Expression = ColumnExpression83
            ColumnExpression84.ColumnName = "MName"
            ColumnExpression84.Table = Table9
            Column84.Expression = ColumnExpression84
            ColumnExpression85.ColumnName = "Gender"
            ColumnExpression85.Table = Table9
            Column85.Expression = ColumnExpression85
            ColumnExpression86.ColumnName = "Age"
            ColumnExpression86.Table = Table9
            Column86.Expression = ColumnExpression86
            ColumnExpression87.ColumnName = "ContactNo"
            ColumnExpression87.Table = Table9
            Column87.Expression = ColumnExpression87
            ColumnExpression88.ColumnName = "Birthdate"
            ColumnExpression88.Table = Table9
            Column88.Expression = ColumnExpression88
            ColumnExpression89.ColumnName = "BirthPlace"
            ColumnExpression89.Table = Table9
            Column89.Expression = ColumnExpression89
            ColumnExpression90.ColumnName = "CivilStatus"
            ColumnExpression90.Table = Table9
            Column90.Expression = ColumnExpression90
            ColumnExpression91.ColumnName = "Religion"
            ColumnExpression91.Table = Table9
            Column91.Expression = ColumnExpression91
            ColumnExpression92.ColumnName = "Citizenship"
            ColumnExpression92.Table = Table9
            Column92.Expression = ColumnExpression92
            ColumnExpression93.ColumnName = "Purok"
            ColumnExpression93.Table = Table9
            Column93.Expression = ColumnExpression93
            ColumnExpression94.ColumnName = "Address"
            ColumnExpression94.Table = Table9
            Column94.Expression = ColumnExpression94
            ColumnExpression95.ColumnName = "Profession"
            ColumnExpression95.Table = Table9
            Column95.Expression = ColumnExpression95
            ColumnExpression96.ColumnName = "Educattainment"
            ColumnExpression96.Table = Table9
            Column96.Expression = ColumnExpression96
            ColumnExpression97.ColumnName = "Image"
            ColumnExpression97.Table = Table9
            Column97.Expression = ColumnExpression97
            ColumnExpression98.ColumnName = "FullName"
            ColumnExpression98.Table = Table9
            Column98.Expression = ColumnExpression98
            ColumnExpression99.ColumnName = "Archive"
            ColumnExpression99.Table = Table9
            Column99.Expression = ColumnExpression99
            ColumnExpression100.ColumnName = "Deceased"
            ColumnExpression100.Table = Table9
            Column100.Expression = ColumnExpression100
            ColumnExpression101.ColumnName = "Income"
            ColumnExpression101.Table = Table9
            Column101.Expression = ColumnExpression101
            ColumnExpression102.ColumnName = "OFW"
            ColumnExpression102.Table = Table9
            Column102.Expression = ColumnExpression102
            ColumnExpression103.ColumnName = "PassportNo"
            ColumnExpression103.Table = Table9
            Column103.Expression = ColumnExpression103
            ColumnExpression104.ColumnName = "Country"
            ColumnExpression104.Table = Table9
            Column104.Expression = ColumnExpression104
            ColumnExpression105.ColumnName = "HouseNo"
            ColumnExpression105.Table = Table9
            Column105.Expression = ColumnExpression105
            ColumnExpression106.ColumnName = "PWD"
            ColumnExpression106.Table = Table9
            Column106.Expression = ColumnExpression106
            ColumnExpression107.ColumnName = "DP"
            ColumnExpression107.Table = Table9
            Column107.Expression = ColumnExpression107
            ColumnExpression108.ColumnName = "OSY"
            ColumnExpression108.Table = Table9
            Column108.Expression = ColumnExpression108
            ColumnExpression109.ColumnName = "SP"
            ColumnExpression109.Table = Table9
            Column109.Expression = ColumnExpression109
            ColumnExpression110.ColumnName = "Voter"
            ColumnExpression110.Table = Table9
            Column110.Expression = ColumnExpression110
            ColumnExpression111.ColumnName = "CR"
            ColumnExpression111.Table = Table9
            Column111.Expression = ColumnExpression111
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
            SelectQuery3.Columns.Add(Column96)
            SelectQuery3.Columns.Add(Column97)
            SelectQuery3.Columns.Add(Column98)
            SelectQuery3.Columns.Add(Column99)
            SelectQuery3.Columns.Add(Column100)
            SelectQuery3.Columns.Add(Column101)
            SelectQuery3.Columns.Add(Column102)
            SelectQuery3.Columns.Add(Column103)
            SelectQuery3.Columns.Add(Column104)
            SelectQuery3.Columns.Add(Column105)
            SelectQuery3.Columns.Add(Column106)
            SelectQuery3.Columns.Add(Column107)
            SelectQuery3.Columns.Add(Column108)
            SelectQuery3.Columns.Add(Column109)
            SelectQuery3.Columns.Add(Column110)
            SelectQuery3.Columns.Add(Column111)
            SelectQuery3.Name = "resident"
            SelectQuery3.Tables.Add(Table9)
            Me.DashboardResident.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery3})
            Me.DashboardResident.ResultSchemaSerializable = resources.GetString("DashboardResident.ResultSchemaSerializable")
            '
            'DashboardSqlDataSource3
            '
            Me.DashboardSqlDataSource3.ComponentName = "DashboardSqlDataSource3"
            Me.DashboardSqlDataSource3.ConnectionName = "BrgyConnection"
            Me.DashboardSqlDataSource3.Name = "MysqlIncome"
            ColumnExpression112.ColumnName = "ORDate"
            Table10.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""590"" />"
            Table10.Name = "animal"
            ColumnExpression112.Table = Table10
            Column112.Expression = ColumnExpression112
            ColumnExpression113.ColumnName = "CTC"
            ColumnExpression113.Table = Table10
            Column113.Expression = ColumnExpression113
            ColumnExpression114.ColumnName = "CTCAmount"
            ColumnExpression114.Table = Table10
            Column114.Expression = ColumnExpression114
            ColumnExpression115.ColumnName = "CTCDate"
            ColumnExpression115.Table = Table10
            Column115.Expression = ColumnExpression115
            ColumnExpression116.ColumnName = "PrintDate"
            ColumnExpression116.Table = Table10
            Column116.Expression = ColumnExpression116
            ColumnExpression117.ColumnName = "ID"
            ColumnExpression117.Table = Table10
            Column117.Expression = ColumnExpression117
            ColumnExpression118.ColumnName = "ResidentID"
            ColumnExpression118.Table = Table10
            Column118.Expression = ColumnExpression118
            ColumnExpression119.ColumnName = "ORAmount"
            ColumnExpression119.Table = Table10
            Column119.Expression = ColumnExpression119
            ColumnExpression120.ColumnName = "ORno"
            ColumnExpression120.Table = Table10
            Column120.Expression = ColumnExpression120
            ColumnExpression121.ColumnName = "No"
            ColumnExpression121.Table = Table10
            Column121.Expression = ColumnExpression121
            Column122.Alias = "animaltransport_ID"
            ColumnExpression122.ColumnName = "ID"
            Table11.MetaSerializable = "<Meta X=""185"" Y=""30"" Width=""125"" Height=""552"" />"
            Table11.Name = "animaltransport"
            ColumnExpression122.Table = Table11
            Column122.Expression = ColumnExpression122
            Column123.Alias = "animaltransport_No"
            ColumnExpression123.ColumnName = "No"
            ColumnExpression123.Table = Table11
            Column123.Expression = ColumnExpression123
            ColumnExpression124.ColumnName = "AnimalID"
            ColumnExpression124.Table = Table11
            Column124.Expression = ColumnExpression124
            Column125.Alias = "animaltransport_ResidentID"
            ColumnExpression125.ColumnName = "ResidentID"
            ColumnExpression125.Table = Table11
            Column125.Expression = ColumnExpression125
            Column126.Alias = "animaltransport_ORno"
            ColumnExpression126.ColumnName = "ORno"
            ColumnExpression126.Table = Table11
            Column126.Expression = ColumnExpression126
            Column127.Alias = "animaltransport_ORAmount"
            ColumnExpression127.ColumnName = "ORAmount"
            ColumnExpression127.Table = Table11
            Column127.Expression = ColumnExpression127
            Column128.Alias = "animaltransport_ORDate"
            ColumnExpression128.ColumnName = "ORDate"
            ColumnExpression128.Table = Table11
            Column128.Expression = ColumnExpression128
            Column129.Alias = "animaltransport_CTC"
            ColumnExpression129.ColumnName = "CTC"
            ColumnExpression129.Table = Table11
            Column129.Expression = ColumnExpression129
            Column130.Alias = "animaltransport_CTCAmount"
            ColumnExpression130.ColumnName = "CTCAmount"
            ColumnExpression130.Table = Table11
            Column130.Expression = ColumnExpression130
            Column131.Alias = "animaltransport_CTCDate"
            ColumnExpression131.ColumnName = "CTCDate"
            ColumnExpression131.Table = Table11
            Column131.Expression = ColumnExpression131
            Column132.Alias = "animaltransport_PrintDate"
            ColumnExpression132.ColumnName = "PrintDate"
            ColumnExpression132.Table = Table11
            Column132.Expression = ColumnExpression132
            Column133.Alias = "belongings_PrintDate"
            ColumnExpression133.ColumnName = "PrintDate"
            Table12.MetaSerializable = "<Meta X=""340"" Y=""30"" Width=""125"" Height=""552"" />"
            Table12.Name = "belongings"
            ColumnExpression133.Table = Table12
            Column133.Expression = ColumnExpression133
            Column134.Alias = "belongings_CTCDate"
            ColumnExpression134.ColumnName = "CTCDate"
            ColumnExpression134.Table = Table12
            Column134.Expression = ColumnExpression134
            Column135.Alias = "belongings_CTCAmount"
            ColumnExpression135.ColumnName = "CTCAmount"
            ColumnExpression135.Table = Table12
            Column135.Expression = ColumnExpression135
            Column136.Alias = "belongings_CTC"
            ColumnExpression136.ColumnName = "CTC"
            ColumnExpression136.Table = Table12
            Column136.Expression = ColumnExpression136
            Column137.Alias = "belongings_ORDate"
            ColumnExpression137.ColumnName = "ORDate"
            ColumnExpression137.Table = Table12
            Column137.Expression = ColumnExpression137
            Column138.Alias = "belongings_ORno"
            ColumnExpression138.ColumnName = "ORno"
            ColumnExpression138.Table = Table12
            Column138.Expression = ColumnExpression138
            Column139.Alias = "belongings_ID"
            ColumnExpression139.ColumnName = "ID"
            ColumnExpression139.Table = Table12
            Column139.Expression = ColumnExpression139
            Column140.Alias = "belongings_No"
            ColumnExpression140.ColumnName = "No"
            ColumnExpression140.Table = Table12
            Column140.Expression = ColumnExpression140
            Column141.Alias = "belongings_ResidentID"
            ColumnExpression141.ColumnName = "ResidentID"
            ColumnExpression141.Table = Table12
            Column141.Expression = ColumnExpression141
            Column142.Alias = "belongings_ORAmount"
            ColumnExpression142.ColumnName = "ORAmount"
            ColumnExpression142.Table = Table12
            Column142.Expression = ColumnExpression142
            Column143.Alias = "brgyclearance_PrintDate"
            ColumnExpression143.ColumnName = "PrintDate"
            Table13.MetaSerializable = "<Meta X=""495"" Y=""30"" Width=""125"" Height=""514"" />"
            Table13.Name = "brgyclearance"
            ColumnExpression143.Table = Table13
            Column143.Expression = ColumnExpression143
            Column144.Alias = "brgyclearance_CTCDate"
            ColumnExpression144.ColumnName = "CTCDate"
            ColumnExpression144.Table = Table13
            Column144.Expression = ColumnExpression144
            Column145.Alias = "brgyclearance_CTCAmount"
            ColumnExpression145.ColumnName = "CTCAmount"
            ColumnExpression145.Table = Table13
            Column145.Expression = ColumnExpression145
            Column146.Alias = "brgyclearance_CTC"
            ColumnExpression146.ColumnName = "CTC"
            ColumnExpression146.Table = Table13
            Column146.Expression = ColumnExpression146
            Column147.Alias = "brgyclearance_ORAmount"
            ColumnExpression147.ColumnName = "ORAmount"
            ColumnExpression147.Table = Table13
            Column147.Expression = ColumnExpression147
            Column148.Alias = "brgyclearance_ORno"
            ColumnExpression148.ColumnName = "ORno"
            ColumnExpression148.Table = Table13
            Column148.Expression = ColumnExpression148
            Column149.Alias = "brgyclearance_ORDate"
            ColumnExpression149.ColumnName = "ORDate"
            ColumnExpression149.Table = Table13
            Column149.Expression = ColumnExpression149
            Column150.Alias = "busclearance_ORno"
            ColumnExpression150.ColumnName = "ORno"
            Table14.MetaSerializable = "<Meta X=""650"" Y=""30"" Width=""125"" Height=""514"" />"
            Table14.Name = "busclearance"
            ColumnExpression150.Table = Table14
            Column150.Expression = ColumnExpression150
            Column151.Alias = "busclearance_ORAmount"
            ColumnExpression151.ColumnName = "ORAmount"
            ColumnExpression151.Table = Table14
            Column151.Expression = ColumnExpression151
            Column152.Alias = "busclearance_ORDate"
            ColumnExpression152.ColumnName = "ORDate"
            ColumnExpression152.Table = Table14
            Column152.Expression = ColumnExpression152
            Column153.Alias = "busclearance_CTC"
            ColumnExpression153.ColumnName = "CTC"
            ColumnExpression153.Table = Table14
            Column153.Expression = ColumnExpression153
            Column154.Alias = "busclearance_CTCAmount"
            ColumnExpression154.ColumnName = "CTCAmount"
            ColumnExpression154.Table = Table14
            Column154.Expression = ColumnExpression154
            Column155.Alias = "busclearance_CTCDate"
            ColumnExpression155.ColumnName = "CTCDate"
            ColumnExpression155.Table = Table14
            Column155.Expression = ColumnExpression155
            Column156.Alias = "busclearance_PrintDate"
            ColumnExpression156.ColumnName = "PrintDate"
            ColumnExpression156.Table = Table14
            Column156.Expression = ColumnExpression156
            Column157.Alias = "busclearance_ID"
            ColumnExpression157.ColumnName = "ID"
            ColumnExpression157.Table = Table14
            Column157.Expression = ColumnExpression157
            ColumnExpression158.ColumnName = "ClearanceNo"
            ColumnExpression158.Table = Table14
            Column158.Expression = ColumnExpression158
            ColumnExpression159.ColumnName = "BusinessID"
            ColumnExpression159.Table = Table14
            Column159.Expression = ColumnExpression159
            Column160.Alias = "brgyclearance_ID"
            ColumnExpression160.ColumnName = "ID"
            ColumnExpression160.Table = Table13
            Column160.Expression = ColumnExpression160
            Column161.Alias = "brgyclearance_ClearanceNo"
            ColumnExpression161.ColumnName = "ClearanceNo"
            ColumnExpression161.Table = Table13
            Column161.Expression = ColumnExpression161
            Column162.Alias = "brgyclearance_ResidentID"
            ColumnExpression162.ColumnName = "ResidentID"
            ColumnExpression162.Table = Table13
            Column162.Expression = ColumnExpression162
            SelectQuery4.Columns.Add(Column112)
            SelectQuery4.Columns.Add(Column113)
            SelectQuery4.Columns.Add(Column114)
            SelectQuery4.Columns.Add(Column115)
            SelectQuery4.Columns.Add(Column116)
            SelectQuery4.Columns.Add(Column117)
            SelectQuery4.Columns.Add(Column118)
            SelectQuery4.Columns.Add(Column119)
            SelectQuery4.Columns.Add(Column120)
            SelectQuery4.Columns.Add(Column121)
            SelectQuery4.Columns.Add(Column122)
            SelectQuery4.Columns.Add(Column123)
            SelectQuery4.Columns.Add(Column124)
            SelectQuery4.Columns.Add(Column125)
            SelectQuery4.Columns.Add(Column126)
            SelectQuery4.Columns.Add(Column127)
            SelectQuery4.Columns.Add(Column128)
            SelectQuery4.Columns.Add(Column129)
            SelectQuery4.Columns.Add(Column130)
            SelectQuery4.Columns.Add(Column131)
            SelectQuery4.Columns.Add(Column132)
            SelectQuery4.Columns.Add(Column133)
            SelectQuery4.Columns.Add(Column134)
            SelectQuery4.Columns.Add(Column135)
            SelectQuery4.Columns.Add(Column136)
            SelectQuery4.Columns.Add(Column137)
            SelectQuery4.Columns.Add(Column138)
            SelectQuery4.Columns.Add(Column139)
            SelectQuery4.Columns.Add(Column140)
            SelectQuery4.Columns.Add(Column141)
            SelectQuery4.Columns.Add(Column142)
            SelectQuery4.Columns.Add(Column143)
            SelectQuery4.Columns.Add(Column144)
            SelectQuery4.Columns.Add(Column145)
            SelectQuery4.Columns.Add(Column146)
            SelectQuery4.Columns.Add(Column147)
            SelectQuery4.Columns.Add(Column148)
            SelectQuery4.Columns.Add(Column149)
            SelectQuery4.Columns.Add(Column150)
            SelectQuery4.Columns.Add(Column151)
            SelectQuery4.Columns.Add(Column152)
            SelectQuery4.Columns.Add(Column153)
            SelectQuery4.Columns.Add(Column154)
            SelectQuery4.Columns.Add(Column155)
            SelectQuery4.Columns.Add(Column156)
            SelectQuery4.Columns.Add(Column157)
            SelectQuery4.Columns.Add(Column158)
            SelectQuery4.Columns.Add(Column159)
            SelectQuery4.Columns.Add(Column160)
            SelectQuery4.Columns.Add(Column161)
            SelectQuery4.Columns.Add(Column162)
            SelectQuery4.Name = "animal"
            RelationColumnInfo7.NestedKeyColumn = "ORDate"
            RelationColumnInfo7.ParentKeyColumn = "ORDate"
            RelationColumnInfo8.NestedKeyColumn = "CTCDate"
            RelationColumnInfo8.ParentKeyColumn = "CTCDate"
            Join7.KeyColumns.Add(RelationColumnInfo7)
            Join7.KeyColumns.Add(RelationColumnInfo8)
            Join7.Nested = Table11
            Join7.Parent = Table10
            RelationColumnInfo9.NestedKeyColumn = "ORDate"
            RelationColumnInfo9.ParentKeyColumn = "ORDate"
            RelationColumnInfo10.NestedKeyColumn = "CTCDate"
            RelationColumnInfo10.ParentKeyColumn = "CTCDate"
            Join8.KeyColumns.Add(RelationColumnInfo9)
            Join8.KeyColumns.Add(RelationColumnInfo10)
            Join8.Nested = Table12
            Join8.Parent = Table11
            RelationColumnInfo11.NestedKeyColumn = "ORDate"
            RelationColumnInfo11.ParentKeyColumn = "ORDate"
            RelationColumnInfo12.NestedKeyColumn = "CTCDate"
            RelationColumnInfo12.ParentKeyColumn = "CTCDate"
            Join9.KeyColumns.Add(RelationColumnInfo11)
            Join9.KeyColumns.Add(RelationColumnInfo12)
            Join9.Nested = Table13
            Join9.Parent = Table12
            RelationColumnInfo13.NestedKeyColumn = "ORDate"
            RelationColumnInfo13.ParentKeyColumn = "ORDate"
            RelationColumnInfo14.NestedKeyColumn = "CTCDate"
            RelationColumnInfo14.ParentKeyColumn = "CTCDate"
            Join10.KeyColumns.Add(RelationColumnInfo13)
            Join10.KeyColumns.Add(RelationColumnInfo14)
            Join10.Nested = Table14
            Join10.Parent = Table13
            SelectQuery4.Relations.Add(Join7)
            SelectQuery4.Relations.Add(Join8)
            SelectQuery4.Relations.Add(Join9)
            SelectQuery4.Relations.Add(Join10)
            SelectQuery4.Tables.Add(Table10)
            SelectQuery4.Tables.Add(Table11)
            SelectQuery4.Tables.Add(Table12)
            SelectQuery4.Tables.Add(Table13)
            SelectQuery4.Tables.Add(Table14)
            Me.DashboardSqlDataSource3.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery4})
            Me.DashboardSqlDataSource3.ResultSchemaSerializable = resources.GetString("DashboardSqlDataSource3.ResultSchemaSerializable")
            '
            'ResidentChart
            '
            Dimension1.DataMember = "Purok"
            Me.ResidentChart.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension1})
            Me.ResidentChart.AxisX.TitleVisible = False
            Me.ResidentChart.ComponentName = "ResidentChart"
            Measure7.DataMember = "ID"
            Measure7.Name = "Resident (Count)"
            Measure7.SummaryType = DevExpress.DashboardCommon.SummaryType.Count
            Me.ResidentChart.DataItemRepository.Clear()
            Me.ResidentChart.DataItemRepository.Add(Measure7, "DataItem0")
            Me.ResidentChart.DataItemRepository.Add(Dimension1, "DataItem2")
            Me.ResidentChart.DataMember = "resident"
            Me.ResidentChart.DataSource = Me.DashboardResident
            Me.ResidentChart.InteractivityOptions.IgnoreMasterFilters = False
            Me.ResidentChart.IsMasterFilterCrossDataSource = True
            Me.ResidentChart.Name = "Resident per Zone"
            ChartPane1.Name = "Pane 1"
            ChartPane1.PrimaryAxisY.AlwaysShowZeroLevel = True
            ChartPane1.PrimaryAxisY.ShowGridLines = True
            ChartPane1.PrimaryAxisY.TitleVisible = True
            ChartPane1.SecondaryAxisY.AlwaysShowZeroLevel = True
            ChartPane1.SecondaryAxisY.ShowGridLines = False
            ChartPane1.SecondaryAxisY.TitleVisible = True
            SimpleSeries1.AddDataItem("Value", Measure7)
            ChartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() {SimpleSeries1})
            Me.ResidentChart.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() {ChartPane1})
            Me.ResidentChart.ShowCaption = True
            '
            'HouseholdChart
            '
            Dimension2.DataMember = "Purok"
            Me.HouseholdChart.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension2})
            Me.HouseholdChart.ComponentName = "HouseholdChart"
            Measure8.Calculation = RunningTotalCalculation1
            Measure8.DataMember = "Code"
            Measure8.Name = "Household (Count)"
            Measure8.SummaryType = DevExpress.DashboardCommon.SummaryType.CountDistinct
            Me.HouseholdChart.DataItemRepository.Clear()
            Me.HouseholdChart.DataItemRepository.Add(Measure8, "DataItem0")
            Me.HouseholdChart.DataItemRepository.Add(Dimension2, "DataItem1")
            Me.HouseholdChart.DataMember = "family"
            Me.HouseholdChart.DataSource = Me.DashboardSqlDataSource1
            Me.HouseholdChart.InteractivityOptions.IgnoreMasterFilters = False
            Me.HouseholdChart.Name = "Household(s) per Zone"
            Me.HouseholdChart.PieType = DevExpress.DashboardCommon.PieType.Donut
            Me.HouseholdChart.ShowCaption = True
            Me.HouseholdChart.Values.AddRange(New DevExpress.DashboardCommon.Measure() {Measure8})
            '
            'Dashboard2
            '
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() {Me.DashboardResident, Me.DashboardSqlDataSource1, Me.DashboardSqlDataSource2, Me.DashboardSqlDataSource3})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() {Me.ResidentChart, Me.HouseholdChart, Me.CardDashboardItem1})
            DashboardLayoutItem1.DashboardItem = Me.HouseholdChart
            DashboardLayoutItem1.Weight = 50.0R
            DashboardLayoutItem2.DashboardItem = Me.CardDashboardItem1
            DashboardLayoutItem2.Weight = 50.0R
            DashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem1, DashboardLayoutItem2})
            DashboardLayoutGroup2.DashboardItem = Nothing
            DashboardLayoutGroup2.Weight = 51.405622489959839R
            DashboardLayoutItem3.DashboardItem = Me.ResidentChart
            DashboardLayoutItem3.Weight = 48.594377510040161R
            DashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutGroup2, DashboardLayoutItem3})
            DashboardLayoutGroup1.DashboardItem = Nothing
            DashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            DashboardLayoutGroup1.Weight = 100.0R
            Me.LayoutRoot = DashboardLayoutGroup1
            Me.Title.Text = "Dashboard"
            CType(Me.DashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CardDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DashboardSqlDataSource2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DashboardResident, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DashboardSqlDataSource3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ResidentChart, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.HouseholdChart, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        Friend WithEvents DashboardResident As DevExpress.DashboardCommon.DashboardSqlDataSource
        Friend WithEvents DashboardSqlDataSource1 As DevExpress.DashboardCommon.DashboardSqlDataSource
        Friend WithEvents DashboardSqlDataSource2 As DevExpress.DashboardCommon.DashboardSqlDataSource
        Friend WithEvents CardDashboardItem1 As DevExpress.DashboardCommon.CardDashboardItem
        Friend WithEvents DashboardSqlDataSource3 As DevExpress.DashboardCommon.DashboardSqlDataSource
        Friend WithEvents ResidentChart As DevExpress.DashboardCommon.ChartDashboardItem
        Friend WithEvents HouseholdChart As DevExpress.DashboardCommon.PieDashboardItem

#End Region
    End Class
End Namespace