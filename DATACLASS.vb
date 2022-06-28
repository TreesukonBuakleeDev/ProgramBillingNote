Imports System.Data.SqlClient
Public Class DATACLASS

#Region "CREATE"

#Region "BILL"
    Public Shared Sub CREATEFMSBILLHEAD()
        Dim STREXIST As String = ""
        Dim str As String = ""
        Try
            Connection.Openconnect("BILL", connect)
            'check Exist\
            Dim dtchkTemp As DataTable = New DataTable()

            STREXIST = "SELECT name FROM sys.tables WHERE name = 'FMSBILLHEAD'"
            Dim cmdquery As SqlDataAdapter = New SqlDataAdapter(STREXIST, connect)
            cmdquery.Fill(dtchkTemp)

            'create table 
            If dtchkTemp.Rows.Count = 0 Then
                str = "CREATE TABLE [dbo].[FMSBILLHEAD](" & vbCrLf
                str &= "BILLSEQ     [NVARCHAR](50) NULL, " & vbCrLf
                str &= "BILLNO      [NVARCHAR](50) NOT NULL, " & vbCrLf
                str &= "IDCUST      [NVARCHAR](100) NULL, " & vbCrLf

                str &= "INVDATE     [NUMERIC](18) NULL," & vbCrLf
                str &= "DUEDATE     [NUMERIC](18) NULL, " & vbCrLf
                str &= "BILLDOCDATE [NUMERIC](18) NULL, " & vbCrLf
                str &= "AMT         [NUMERIC](18, 2) NULL, " & vbCrLf
                str &= "NETAMT      [NUMERIC](18, 2) NULL, " & vbCrLf
                str &= "REF_0       [Text] NULL,  " & vbCrLf
                str &= "COMMENT     [Text] NULL,  " & vbCrLf
                str &= "STA_0       [int] NULL, " & vbCrLf
                str &= "TERMCODE    [NVARCHAR](50) NULL, " & vbCrLf
                str &= "BILLHTEXT1  [Text] NULL, " & vbCrLf
                str &= "BILLHTEXT2  [Text] NULL, " & vbCrLf
                str &= "BILLHTEXT3  [Text] NULL, " & vbCrLf
                str &= "BILLHTEXT4  [Text] NULL, " & vbCrLf
                str &= "BILLHTEXT5  [Text] NULL, " & vbCrLf
                str &= "BILLHTEXT6  [Text] NULL, " & vbCrLf
                str &= "BILLHTEXT7  [Text] NULL, " & vbCrLf
                str &= "BILLHTEXT8  [Text] NULL," & vbCrLf
                str &= "BILLHTEXT9  [Text] NULL, " & vbCrLf
                str &= "BILLHTEXT10 [Text] NULL, " & vbCrLf
                str &= "AUDTORG     [char](6) NOT NULL," & vbCrLf
                str &= "BOI         [NVARCHAR](10) NULL," & Environment.NewLine
                str &= "Constraint Constraint_FMSBILLHEAD PRIMARY KEY (BILLNO)" & Environment.NewLine
                str &= ")" & vbCrLf

                Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
                cmd1.ExecuteNonQuery()
            End If
            connect.Close()

        Catch ex As Exception
            WriteLog("Error 55 CREATEFMSBILLHEAD() :" & ex.Message & STREXIST & " ; " & str)
        End Try
    End Sub

    Public Shared Sub CREATEFMSBILLDETAIL(Optional ByVal TABLENAME As String = "")
        Dim STREXIST As String = ""
        Dim str As String = ""
        Try
            Connection.Openconnect("BILL", connect)
            'check Exist\
            Dim dtchkTemp As DataTable = New DataTable()

            STREXIST = "SELECT name FROM sys.tables WHERE name = '" & TABLENAME & "'"
            Dim cmdquery As SqlDataAdapter = New SqlDataAdapter(STREXIST, connect)
            cmdquery.Fill(dtchkTemp)

            'create table 
            If dtchkTemp.Rows.Count = 0 Then
                str = "CREATE TABLE [dbo].[" & TABLENAME & "](" & vbCrLf
                str &= "BILLSEQ     [NVARCHAR](50) NULL, " & vbCrLf
                str &= "BILLNO      [NVARCHAR](50) NULL, " & vbCrLf
                str &= "DETAILLINE  [int] NULL, " & vbCrLf
                str &= "IDCUST      [NVARCHAR](100) NULL, " & vbCrLf
                str &= "INVNO       [NVARCHAR](50) NULL," & vbCrLf
                str &= "INVDATE     [NUMERIC](18) NULL," & vbCrLf
                str &= "DUEDATE     [NUMERIC](18) NULL, " & vbCrLf
                str &= "PONUM       [NVARCHAR](50) NULL," & vbCrLf
                str &= "LINEAMOUNT  [NUMERIC](18,2) NULL, " & vbCrLf
                str &= "AMTOUTSTAND [NUMERIC](18, 2) NULL, " & vbCrLf
                str &= "NETAMT      [NUMERIC](18, 2) NULL, " & vbCrLf
                str &= "CHECK_0     [NVARCHAR](5) NULL,  " & vbCrLf
                str &= "STA_0       [int] NULL, " & vbCrLf
                str &= "BILLDTEXT1  [Text] NULL, " & vbCrLf
                str &= "BILLDTEXT2  [Text] NULL, " & vbCrLf
                str &= "BILLDTEXT3  [Text] NULL, " & vbCrLf
                str &= "BILLDTEXT4  [Text] NULL, " & vbCrLf
                str &= "BILLDTEXT5  [Text] NULL, " & vbCrLf
                str &= "BILLDTEXT6  [Text] NULL, " & vbCrLf
                str &= "BILLDTEXT7  [Text] NULL, " & vbCrLf
                str &= "BILLDTEXT8  [Text] NULL," & vbCrLf
                str &= "BILLDTEXT9  [Text] NULL, " & vbCrLf
                str &= "BILLDTEXT10 [Text] NULL, " & vbCrLf
                str &= "AUDTORG     [char](6) NOT NULL" & vbCrLf
                'str &= "VATAMT      [NUMERIC](18, 2) NULL, " & vbCrLf
                'str &= "VAT         [NUMERIC](18, 2) NULL " & vbCrLf
                'str &= "Constraint Constraint_FMSBILLDETAIL PRIMARY KEY (BILLNO)" & Environment.NewLine
                str &= ")" & vbCrLf

                Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
                cmd1.ExecuteNonQuery()
            End If
            connect.Close()

        Catch ex As Exception
            WriteLog("Error 100 CREATEFMSBILLDETAIL() :" & ex.Message & STREXIST & " ; " & str)
        End Try
    End Sub

    Public Shared Sub CREATEFMSMASTERRUNNING()
        Dim STREXIST As String = ""
        Dim str As String = ""
        Try
            Connection.Openconnect("BILL", connect)
            'check Exist\
            Dim dtchkTemp As DataTable = New DataTable()

            STREXIST = "SELECT name FROM sys.tables WHERE name = 'FMSMASTERRUNING'"
            Dim cmdquery As SqlDataAdapter = New SqlDataAdapter(STREXIST, connect)
            cmdquery.Fill(dtchkTemp)

            'create table 
            If dtchkTemp.Rows.Count = 0 Then
                str = "CREATE TABLE [dbo].[FMSMASTERRUNING](" & vbCrLf
                str &= "DOCTYPE     [NVARCHAR](20) NULL, " & vbCrLf
                str &= "LENGTH      [INT] NULL, " & vbCrLf
                str &= "PREFIX      [NVARCHAR](50) NULL, " & vbCrLf
                str &= "RUNNO       [NVARCHAR](50) NULL, " & vbCrLf
                str &= "COMP        [NVARCHAR](50) NULL," & vbCrLf
                str &= "AUDTORG     [char](6) NOT NULL," & vbCrLf
                str &= "RCPTYPE     [char](6) NULL" & vbCrLf
                str &= ")" & vbCrLf

                Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
                cmd1.ExecuteNonQuery()
            End If
            connect.Close()

        Catch ex As Exception
            WriteLog("Error 139 CREATEFMSMASTERRUNNING():" & ex.Message & STREXIST & " ; " & str)
        End Try
    End Sub

    Public Shared Sub CREATEFMSMASTEROPTFD(Optional ByVal CONDITION As String = Nothing)
        Dim STREXIST As String = ""
        Dim str As String = ""
        Try
            Connection.Openconnect("BILL", connect)
            'check Exist\
            Dim dtchkTemp As DataTable = New DataTable()

            STREXIST = "SELECT name FROM sys.tables WHERE name = 'FMSMASTEROPTFD'"
            Dim cmdquery As SqlDataAdapter = New SqlDataAdapter(STREXIST, connect)
            cmdquery.Fill(dtchkTemp)

            'create table 
            If dtchkTemp.Rows.Count = 0 Then
                str = "CREATE TABLE [dbo].[FMSMASTEROPTFD](" & vbCrLf
                str &= "OPTFDID       [NVARCHAR](20) NULL, " & vbCrLf
                str &= "OPTFDNAME     [NVARCHAR](50) NULL, " & vbCrLf
                str &= "ACTIVE        [INT] NULL, " & vbCrLf
                str &= "AUDTORG       [char](6) NOT NULL" & vbCrLf
                str &= ")" & vbCrLf

                Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
                cmd1.ExecuteNonQuery()
            Else
                If CONDITION <> Nothing Then
                    str = "DELETE FROM [dbo].[FMSMASTEROPTFD]" & Environment.NewLine & Environment.NewLine
                    Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
                    cmd1.ExecuteNonQuery()
                End If
            End If
            connect.Close()

        Catch ex As Exception
            WriteLog("Error 175 CREATEFMSMASTEROPTFD() :" & ex.Message & STREXIST & " ; " & str)
        End Try
    End Sub

    Public Shared Sub CREATEFMSLOGIMPORT()
        Dim STREXIST As String = ""
        Dim str As String = ""
        Try
            Connection.Openconnect("BILL", connect)
            'check Exist\
            Dim dtchkTemp As DataTable = New DataTable()

            STREXIST = "SELECT name FROM sys.tables WHERE name = 'FMSLOGIMPORT'"
            Dim cmdquery As SqlDataAdapter = New SqlDataAdapter(STREXIST, connect)
            cmdquery.Fill(dtchkTemp)

            'create table 
            If dtchkTemp.Rows.Count = 0 Then
                str = "CREATE TABLE [dbo].[FMSLOGIMPORT](" & vbCrLf
                str &= "CREATEDATE          [NVARCHAR](50) NULL," & vbCrLf
                str &= "Priority            [NVARCHAR](20) NULL, " & vbCrLf
                str &= "Description         [TEXT] NULL, " & vbCrLf
                str &= "Source              [NVARCHAR](20) NULL, " & vbCrLf
                str &= "PriorityType        [NVARCHAR](20) NULL, " & vbCrLf
                str &= "RCPNO               [NVARCHAR](10) NULL, " & Environment.NewLine
                str &= "AUDTORG             [char](6) NOT NULL" & vbCrLf
                str &= ")" & vbCrLf

                Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
                cmd1.ExecuteNonQuery()
            End If
            connect.Close()

        Catch ex As Exception
            WriteLog("Error 208 CREATEFMSLOGIMPORT() :" & ex.Message & STREXIST & " ; " & str)
        End Try
    End Sub

    Public Shared Sub CREATEVIEW_FMSREPORTSTATUS(ByVal CUSTF As String, ByVal CUSTT As String, ByVal VDATEFROM As String, ByVal VDATETO As String)
        Dim STREXIST As String = ""
        Dim str As String = ""
        Try
            Connection.Openconnect("BILL", connect)
            'check Exist\
            Dim dtchkTemp As DataTable = New DataTable()
            Dim SRCDB As String = MAIN.txtDBSOURCE.Text.TrimEnd
            STREXIST = "SELECT name FROM sys.VIEWS WHERE name = 'FMSREPORTSTATUS'"
            Dim cmdquery As SqlDataAdapter = New SqlDataAdapter(STREXIST, connect)
            cmdquery.Fill(dtchkTemp)

            'create table 
            If dtchkTemp.Rows.Count = 0 Then
                str = "CREATE VIEW FMSREPORTSTATUS AS 
(
SELECT ARIBH.IDCUST,ARIBH.IDINVC,ARIBH.DATEINVC 
,ARIBH.AMTNETTOT
,FMSBILLDETAIL.BILLNO
,ARIBH.BASETAX1
,ARIBH.AMTTAX1 
,ARIBH.AUDTORG
,ARIBH.SPECINST
,ARCUS.NAMECUST
,CASE WHEN FMSBILLDETAIL.BILLNO IS NULL THEN 'Not Complete' ELSE 'Complete' END AS STA
,ARIBH.SPECINST AS BOI
,FMSCSCOMMASTER.CONAME 
FROM  " & SRCDB & ".dbo.ARIBH 
LEFT OUTER JOIN FMSBILLDETAIL ON ARIBH.IDINVC = FMSBILLDETAIL.INVNO AND FMSBILLDETAIL.AUDTORG = ARIBH.AUDTORG
LEFT OUTER JOIN FMSBILLHEAD ON FMSBILLHEAD.IDCUST = FMSBILLDETAIL.IDCUST AND FMSBILLHEAD.BILLNO = FMSBILLDETAIL.BILLNO AND FMSBILLHEAD.AUDTORG = FMSBILLDETAIL.AUDTORG
LEFT OUTER JOIN " & SRCDB & ".dbo.ARCUS ON ARCUS.IDCUST = ARIBH.IDCUST
LEFT OUTER JOIN FMSCSCOMMASTER ON ARIBH.AUDTORG = FMSCSCOMMASTER.AUDTORG
WHERE ARIBH.IDCUST BETWEEN '" & CUSTF & "' AND '" & CUSTT & "'
AND CAST(ARIBH.DATEINVC AS nvarchar(20)) BETWEEN '20210101' AND '" & VDATETO & "'  
) "

                Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
                cmd1.ExecuteNonQuery()
            End If
            connect.Close()

        Catch ex As Exception
            WriteLog("Error 248 CREATEVIEW_FMSREPORTSTATUS() :" & ex.Message & STREXIST & " ; " & str)
        End Try
    End Sub

#End Region

#Region "RECEIPT"
    Public Shared Sub CREATEFMSRCPHEAD()
        Dim STREXIST As String = ""
        Dim str As String = ""
        Try
            Connection.Openconnect("BILL", connect)
            'check Exist\
            Dim dtchkTemp As DataTable = New DataTable()

            STREXIST = "SELECT name FROM sys.tables WHERE name = 'FMSRCPHEAD'"
            Dim cmdquery As SqlDataAdapter = New SqlDataAdapter(STREXIST, connect)
            cmdquery.Fill(dtchkTemp)

            'create table 
            If dtchkTemp.Rows.Count = 0 Then
                str = "CREATE TABLE [dbo].[FMSRCPHEAD](" & Environment.NewLine

                str &= " RCPSEQ  [NVARCHAR](50) NULL, " & Environment.NewLine
                str &= " RCPNO [NVARCHAR](50) NOT NULL," & Environment.NewLine
                str &= " IDCUST  [NVARCHAR](50) NULL," & Environment.NewLine
                str &= " RECEIVEDOCDATE  [NUMERIC](18) NULL," & Environment.NewLine
                str &= " RECEIVEDATE  [NUMERIC](18) NULL," & Environment.NewLine
                str &= " BANKCODE  [NVARCHAR](20) NULL," & Environment.NewLine
                str &= " AMT  [NUMERIC](18, 2)," & Environment.NewLine
                str &= " NETAMT  [NUMERIC](18, 2)," & Environment.NewLine
                str &= " REF_0  [Text] NULL," & Environment.NewLine
                str &= " COMMENT  [Text] NULL," & Environment.NewLine
                str &= " PAYTYPE [Int] NULL," & Environment.NewLine
                str &= " PAYDATE [NUMERIC](18) NULL," & Environment.NewLine
                str &= " CRCARDNO [NVARCHAR](20) NULL," & Environment.NewLine
                str &= " TRANSBANKCODE [NVARCHAR](20) NULL," & Environment.NewLine
                str &= " TRANSBANKNO [NVARCHAR](20) NULL," & Environment.NewLine
                str &= " TRANSFEE  [NUMERIC](18, 2)," & Environment.NewLine
                str &= " CHEQNO [NVARCHAR](20) NULL," & Environment.NewLine
                str &= " CHEQBRANCH [NVARCHAR](20) NULL," & Environment.NewLine
                str &= " CHEQACCT [NVARCHAR](20) NULL, " & Environment.NewLine
                str &= " CHEQDATE [NUMERIC](18) NULL, " & Environment.NewLine
                str &= " SHOWCHEQDATE [Int] NULL, " & Environment.NewLine
                str &= " SHOWRECEIVEDATE [Int] NULL," & Environment.NewLine
                str &= " STA_0  [Int] NULL," & Environment.NewLine
                str &= " RCPHTEXT1   [Text] NULL," & Environment.NewLine
                str &= " RCPHTEXT2   [Text] NULL," & Environment.NewLine
                str &= " RCPHTEXT3   [Text] NULL," & Environment.NewLine
                str &= " RCPHTEXT4   [Text] NULL," & Environment.NewLine
                str &= " RCPHTEXT5   [Text] NULL," & Environment.NewLine
                str &= " RCPHTEXT6   [Text] NULL," & Environment.NewLine
                str &= " RCPHTEXT7   [Text] NULL," & Environment.NewLine
                str &= " RCPHTEXT8   [Text] NULL," & Environment.NewLine
                str &= " RCPHTEXT9   [Text] NULL," & Environment.NewLine
                str &= " RCPHTEXT10  [Text] NULL," & Environment.NewLine
                str &= " AUDTORG     [char](6) NOT NULL," & Environment.NewLine
                str &= " IMPORTCB    [nvarchar](2) NULL," & Environment.NewLine
                str &= " BANKBATCH   [nvarchar](20)," & Environment.NewLine
                str &= " CHEQBANK [NVARCHAR](200) NULL," & Environment.NewLine
                str &= " CBDATE   [NUMERIC](18) NULL," & Environment.NewLine
                str &= " TAXINV     [char](6) NULL," & Environment.NewLine
                str &= " CBBATCH     [char](50) NULL," & Environment.NewLine
                str &= "Constraint Constraint_FMSRCPHEAD PRIMARY KEY (RCPNO)" & Environment.NewLine
                str &= ")" & vbCrLf

                Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
                cmd1.ExecuteNonQuery()
            End If
            connect.Close()

        Catch ex As Exception
            WriteLog("Error 316 CREATEFMSRCPHEAD() :" & ex.Message & STREXIST & " ; " & str)
        End Try
    End Sub

    Public Shared Sub CREATEFMSRCPDETAIL()
        Dim STREXIST As String = ""
        Dim str As String = ""
        Try
            Connection.Openconnect("BILL", connect)
            'check Exist\
            Dim dtchkTemp As DataTable = New DataTable()

            STREXIST = "SELECT name FROM sys.tables WHERE name = 'FMSRCPDETAIL'"
            Dim cmdquery As SqlDataAdapter = New SqlDataAdapter(STREXIST, connect)
            cmdquery.Fill(dtchkTemp)

            'create table 
            If dtchkTemp.Rows.Count = 0 Then
                str = "CREATE TABLE [dbo].[FMSRCPDETAIL](" & Environment.NewLine
                str &= "RCPSEQ  [NVARCHAR](50) NULL, " & Environment.NewLine
                str &= "RCPNO [NVARCHAR](50) NOT NULL," & Environment.NewLine
                str &= "DETAILLINE [Int] NULL," & Environment.NewLine
                str &= "BILLNO [NVARCHAR](50) NULL," & Environment.NewLine
                str &= "IDCUST  [NVARCHAR](50) NULL," & Environment.NewLine
                str &= "INVNO [NVARCHAR](50) NULL," & Environment.NewLine
                str &= "INVDATE [NUMERIC](18) NULL," & Environment.NewLine
                str &= "DueDate  [NUMERIC](18) NULL," & Environment.NewLine
                str &= "PONUM [NVARCHAR](50) NULL," & Environment.NewLine
                str &= "UNITPRICE [NUMERIC](18, 2)," & Environment.NewLine
                str &= "VATAMT [NUMERIC](18, 2)," & Environment.NewLine
                str &= "RCPAMT [NUMERIC](18, 2)," & Environment.NewLine
                str &= "AMTOUTSTAND [NUMERIC](18, 2)," & Environment.NewLine
                str &= "NETAMT [NUMERIC](18, 2)," & Environment.NewLine
                str &= "AMT [NUMERIC](18, 2)," & Environment.NewLine
                str &= "CHECK_0 [nvarchar](5) NULL," & Environment.NewLine
                str &= "STA_0 [Int] NULL," & Environment.NewLine
                str &= "RCPDTEXT1 [Text] NULL," & Environment.NewLine
                str &= "RCPDTEXT2 [Text] NULL," & Environment.NewLine
                str &= "RCPDTEXT3 [Text] NULL," & Environment.NewLine
                str &= "RCPDTEXT4 [Text] NULL," & Environment.NewLine
                str &= "RCPDTEXT5 [Text] NULL," & Environment.NewLine
                str &= "RCPDTEXT6 [Text] NULL," & Environment.NewLine
                str &= "RCPDTEXT7 [Text] NULL," & Environment.NewLine
                str &= "RCPDTEXT8 [Text] NULL," & Environment.NewLine
                str &= "RCPDTEXT9 [Text] NULL," & Environment.NewLine
                str &= "RCPDTEXT10 [Text] NULL," & Environment.NewLine
                str &= "AUDTORG    [char](6) NOT NULL," & vbCrLf & Environment.NewLine
                str &= "VAT [numeric](18, 2) NULL," & Environment.NewLine
                'str &= "Constraint Constraint_FMSRCPDETAIL PRIMARY KEY (RCPNO)" & Environment.NewLine
                str &= ")" & Environment.NewLine

                Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
                cmd1.ExecuteNonQuery()
            End If
            connect.Close()

        Catch ex As Exception
            WriteLog("Error 372 CREATEFMSRCPDETAIL() :" & ex.Message & STREXIST & " ; " & str)
        End Try
    End Sub

    Public Shared Sub CREATEFMSMASTERIMPORT()
        Dim STREXIST As String = ""
        Dim str As String = ""
        Try
            Connection.Openconnect("BILL", connect)
            'check Exist\
            Dim dtchkTemp As DataTable = New DataTable()

            STREXIST = "SELECT name FROM sys.tables WHERE name = 'FMSMASTERIMPORT'"
            Dim cmdquery As SqlDataAdapter = New SqlDataAdapter(STREXIST, connect)
            cmdquery.Fill(dtchkTemp)

            'create table 
            If dtchkTemp.Rows.Count = 0 Then
                str = "CREATE TABLE [dbo].[FMSMASTERIMPORT]( " & Environment.NewLine
                str &= " [ACCPACID] [nvarchar](50) NULL, " & Environment.NewLine
                str &= " [ACCPACPASSWORD] [nvarchar](50) NULL,  " & Environment.NewLine
                str &= " [COMPANY] [nvarchar](50) NOT NULL,  " & Environment.NewLine
                str &= " [ACCPACVERSION] [nvarchar](5) NULL, " & Environment.NewLine
                str &= " [DNSRCCODE] [nvarchar](10) NULL, " & Environment.NewLine
                str &= " [CNSRCCODE] [nvarchar](10) NULL, " & Environment.NewLine
                str &= " [PATHBACKUP] [Text] NULL, " & Environment.NewLine
                str &= " [PATHERROR] [Text] NULL, " & Environment.NewLine
                str &= " [COMP] [nvarchar](50) NULL, " & Environment.NewLine
                str &= " [AUDTORG] [Char](10) NULL," & Environment.NewLine
                str &= " [OPTFD_HEAD] [Char](5) NULL," & Environment.NewLine
                str &= " [OPTFD_DETAIL] [Char](5) NULL," & Environment.NewLine
                str &= " CONSTRAINT Constraint_FMSMASTERIMPORT PRIMARY KEY (COMPANY)" & Environment.NewLine
                str &= ")" & Environment.NewLine

                Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
                cmd1.ExecuteNonQuery()
            End If
            connect.Close()

        Catch ex As Exception
            WriteLog("Error 409 CREATEFMSMASTERIMPORT : " & ex.Message & STREXIST & " ; " & str)
        End Try
    End Sub

#End Region

#Region "MASTER"

    Public Shared Sub CREATE_FMSARCUSMASTER()
        Dim STREXIST As String = ""
        Dim str As String = ""
        Try
            Connection.Openconnect("BILL", connect)
            'check Exist\
            Dim dtchkTemp As DataTable = New DataTable()

            STREXIST = "Select name FROM sys.tables WHERE name = 'FMSARCUSMASTER'"
            Dim cmdquery As SqlDataAdapter = New SqlDataAdapter(STREXIST, connect)
            cmdquery.Fill(dtchkTemp)

            'create table 
            If dtchkTemp.Rows.Count = 0 Then
                str = "CREATE TABLE [dbo].[FMSARCUSMASTER]("
                str &= "[IDCUST] [char](12) NOT NULL,"
                str &= "[AUDTDATE] [decimal](9, 0) NOT NULL,"
                str &= "[AUDTTIME] [decimal](9, 0) NOT NULL,"
                str &= "[AUDTUSER] [char](8) NOT NULL,"
                str &= "[AUDTORG] [char](6) NOT NULL,"
                str &= "[TEXTSNAM] [char](10) NOT NULL,"
                str &= "[IDGRP] [char](6) NOT NULL,"
                str &= "[IDNATACCT] [char](12) NOT NULL,"
                str &= "[SWACTV] [smallint] NOT NULL,"
                str &= "[DATEINAC] [decimal](9, 0) NOT NULL,"
                str &= "[DATELASTMN] [decimal](9, 0) NOT NULL,"
                str &= "[SWHOLD] [smallint] NOT NULL,"
                str &= "[DATESTART] [decimal](9, 0) NOT NULL,"
                str &= "[IDPPNT] [char](12) NOT NULL,"
                str &= "[CODEDAB] [char](9) NOT NULL,"
                str &= "[CODEDABRTG] [char](5) NOT NULL,"
                str &= "[DATEDAB] [decimal](9, 0) NOT NULL,"
                str &= "[NAMECUST] [char](60) NOT NULL,"
                str &= "[TEXTSTRE1] [char](60) NOT NULL,"
                str &= "[TEXTSTRE2] [char](60) NOT NULL,"
                str &= "[TEXTSTRE3] [char](60) NOT NULL,"
                str &= "[TEXTSTRE4] [char](60) NOT NULL,"
                str &= "[NAMECITY] [char](30) NOT NULL,"
                str &= "[CODESTTE] [char](30) NOT NULL,"
                str &= "[CODEPSTL] [char](20) NOT NULL,"
                str &= "[CODECTRY] [char](30) NOT NULL,"
                str &= "[NAMECTAC] [char](60) NOT NULL,"
                str &= "[TEXTPHON1] [char](30) NOT NULL,"
                str &= "[TEXTPHON2] [char](30) NOT NULL,"
                str &= "[CODETERR] [char](6) NOT NULL,"
                str &= "[IDACCTSET] [char](6) NOT NULL,"
                str &= "[IDAUTOCASH] [char](6) NOT NULL,"
                str &= "[IDBILLCYCL] [char](6) NOT NULL,"
                str &= "[IDSVCCHRG] [char](6) NOT NULL,"
                str &= "[IDDLNQ] [char](6) NOT NULL,"
                str &= "[CODECURN] [char](3) NOT NULL,"
                str &= "[SWPRTSTMT] [smallint] NOT NULL,"
                str &= "[SWPRTDLNQ] [smallint] NOT NULL,"
                str &= "[SWBALFWD] [smallint] NOT NULL,"
                str &= "[CODETERM] [char](6) NOT NULL,"
                str &= "[IDRATETYPE] [char](2) NOT NULL,"
                str &= "[CODETAXGRP] [char](12) NOT NULL,"
                str &= "[IDTAXREGI1] [char](20) NOT NULL,"
                str &= "[IDTAXREGI2] [char](20) NOT NULL,"
                str &= "[IDTAXREGI3] [char](20) NOT NULL,"
                str &= "[IDTAXREGI4] [char](20) NOT NULL,"
                str &= "[IDTAXREGI5] [char](20) NOT NULL,"
                str &= "[TAXSTTS1] [smallint] NOT NULL,"
                str &= "[TAXSTTS2] [smallint] NOT NULL,"
                str &= "[TAXSTTS3] [smallint] NOT NULL,"
                str &= "[TAXSTTS4] [smallint] NOT NULL,"
                str &= "[TAXSTTS5] [smallint] NOT NULL,"
                str &= "[AMTCRLIMT] [decimal](19, 3) NOT NULL,"
                str &= "[AMTBALDUET] [decimal](19, 3) NOT NULL,"
                str &= "[AMTBALDUEH] [decimal](19, 3) NOT NULL,"
                str &= "[DATELASTST] [decimal](9, 0) NOT NULL,"
                str &= "[AMTLASTSTT] [decimal](19, 3) NOT NULL,"
                str &= "[AMTLASTSTH] [decimal](19, 3) NOT NULL,"
                str &= "[DTBEGBALFW] [decimal](9, 0) NOT NULL,"
                str &= "[AMTBALFWDT] [decimal](19, 3) NOT NULL,"
                str &= "[AMTBALFWDH] [decimal](19, 3) NOT NULL,"
                str &= "[DTLASTRVAL] [decimal](9, 0) NOT NULL,"
                str &= "[AMTBALLARV] [decimal](19, 3) NOT NULL,"
                str &= "[CNTOPENINV] [decimal](7, 0) NOT NULL,"
                str &= "[CNTINVPAID] [decimal](7, 0) NOT NULL,"
                str &= "[DAYSTOPAY] [decimal](7, 0) NOT NULL,"
                str &= "[DATEINVCHI] [decimal](9, 0) NOT NULL,"
                str &= "[DATEBALHI] [decimal](9, 0) NOT NULL,"
                str &= "[DATEINVHIL] [decimal](9, 0) NOT NULL,"
                str &= "[DATEBALHIL] [decimal](9, 0) NOT NULL,"
                str &= "[DATELASTAC] [decimal](9, 0) NOT NULL,"
                str &= "[DATELASTIV] [decimal](9, 0) NOT NULL,"
                str &= "[DATELASTCR] [decimal](9, 0) NOT NULL,"
                str &= "[DATELASTDR] [decimal](9, 0) NOT NULL,"
                str &= "[DATELASTPA] [decimal](9, 0) NOT NULL,"
                str &= "[DATELASTDI] [decimal](9, 0) NOT NULL,"
                str &= "[DATELASTAD] [decimal](9, 0) NOT NULL,"
                str &= "[DATELASTWR] [decimal](9, 0) NOT NULL,"
                str &= "[DATELASTRI] [decimal](9, 0) NOT NULL,"
                str &= "[DATELASTIN] [decimal](9, 0) NOT NULL,"
                str &= "[DATELASTDQ] [decimal](9, 0) NOT NULL,"
                str &= "[IDINVCHI] [char](22) NOT NULL,"
                str &= "[IDINVCHILY] [char](22) NOT NULL,"
                str &= "[AMTINVHIT] [decimal](19, 3) NOT NULL,"
                str &= "[AMTBALHIT] [decimal](19, 3) NOT NULL,"
                str &= "[AMTINVHILT] [decimal](19, 3) NOT NULL,"
                str &= "[AMTBALHILT] [decimal](19, 3) NOT NULL,"
                str &= "[AMTLASTIVT] [decimal](19, 3) NOT NULL,"
                str &= "[AMTLASTCRT] [decimal](19, 3) NOT NULL,"
                str &= "[AMTLASTDRT] [decimal](19, 3) NOT NULL,"
                str &= "[AMTLASTPYT] [decimal](19, 3) NOT NULL,"
                str &= "[AMTLASTDIT] [decimal](19, 3) NOT NULL,"
                str &= "[AMTLASTADT] [decimal](19, 3) NOT NULL,"
                str &= "[AMTLASTWRT] [decimal](19, 3) NOT NULL,"
                str &= "[AMTLASTRIT] [decimal](19, 3) NOT NULL,"
                str &= "[AMTLASTINT] [decimal](19, 3) NOT NULL,"
                str &= "[AMTINVHIH] [decimal](19, 3) NOT NULL,"
                str &= "[AMTBALHIH] [decimal](19, 3) NOT NULL,"
                str &= "[AMTINVHILH] [decimal](19, 3) NOT NULL,"
                str &= "[AMTBALHILH] [decimal](19, 3) NOT NULL,"
                str &= "[AMTLASTIVH] [decimal](19, 3) NOT NULL,"
                str &= "[AMTLASTCRH] [decimal](19, 3) NOT NULL,"
                str &= "[AMTLASTDRH] [decimal](19, 3) NOT NULL,"
                str &= "[AMTLASTPYH] [decimal](19, 3) NOT NULL,"
                str &= "[AMTLASTDIH] [decimal](19, 3) NOT NULL,"
                str &= "[AMTLASTADH] [decimal](19, 3) NOT NULL,"
                str &= "[AMTLASTWRH] [decimal](19, 3) NOT NULL,"
                str &= "[AMTLASTRIH] [decimal](19, 3) NOT NULL,"
                str &= "[AMTLASTINH] [decimal](19, 3) NOT NULL,"
                str &= "[CODESLSP1] [char](8) NOT NULL,"
                str &= "[CODESLSP2] [char](8) NOT NULL,"
                str &= "[CODESLSP3] [char](8) NOT NULL,"
                str &= "[CODESLSP4] [char](8) NOT NULL,"
                str &= "[CODESLSP5] [char](8) NOT NULL,"
                str &= "[PCTSASPLT1] [decimal](9, 5) NOT NULL,"
                str &= "[PCTSASPLT2] [decimal](9, 5) NOT NULL,"
                str &= "[PCTSASPLT3] [decimal](9, 5) NOT NULL,"
                str &= "[PCTSASPLT4] [decimal](9, 5) NOT NULL,"
                str &= "[PCTSASPLT5] [decimal](9, 5) NOT NULL,"
                str &= "[PRICLIST] [char](6) NOT NULL,"
                str &= "[CUSTTYPE] [smallint] NOT NULL,"
                str &= "[AMTPDUE] [decimal](19, 3) NOT NULL,"
                str &= "[EMAIL1] [char](50) NOT NULL,"
                str &= "[EMAIL2] [char](50) NOT NULL,"
                str &= "[WEBSITE] [char](100) NOT NULL,"
                str &= "[BILLMETHOD] [smallint] NOT NULL,"
                str &= "[PAYMCODE] [char](12) NOT NULL,"
                str &= "[FOB] [char](60) NOT NULL,"
                str &= "[SHPVIACODE] [char](6) NOT NULL,"
                str &= "[SHPVIADESC] [char](60) NOT NULL,"
                str &= "[DELMETHOD] [smallint] NOT NULL,"
                str &= "[PRIMSHIPTO] [char](6) NOT NULL,"
                str &= "[CTACPHONE] [char](30) NOT NULL,"
                str &= "[CTACFAX] [char](30) NOT NULL,"
                str &= "[SWPARTSHIP] [smallint] NOT NULL,"
                str &= "[SWWEBSHOP] [smallint] NOT NULL,"
                str &= "[RTGPERCENT] [decimal](9, 5) NOT NULL,"
                str &= "[RTGDAYS] [smallint] NOT NULL,"
                str &= "[RTGTERMS] [char](6) NOT NULL,"
                str &= "[RTGAMTTC] [decimal](19, 3) NOT NULL,"
                str &= "[RTGAMTHC] [decimal](19, 3) NOT NULL,"
                str &= "[VALUES] [int] NOT NULL,"
                str &= "[CNTPPDINVC] [decimal](7, 0) NOT NULL,"
                str &= "[AMTPPDINVT] [decimal](19, 3) NOT NULL,"
                str &= "[AMTPPDINVH] [decimal](19, 3) NOT NULL,"
                str &= "[DATELASTRF] [decimal](9, 0) NOT NULL,"
                str &= "[AMTLASTRFT] [decimal](19, 3) NOT NULL,"
                str &= "[AMTLASTRFH] [decimal](19, 3) NOT NULL,"
                str &= "[CODECHECK] [char](3) NOT NULL,"
                str &= "[NEXTCUID] [int] NOT NULL,"
                str &= "[LOCATION] [char](6) NOT NULL,"
                str &= "[SWCHKLIMIT] [smallint] NOT NULL,"
                str &= "[SWCHKOVER] [smallint] NOT NULL,"
                str &= "[OVERDAYS] [smallint] NOT NULL,"
                str &= "[OVERAMT] [decimal](19, 3) NOT NULL,"
                str &= "[SWBACKORDR] [smallint] NOT NULL,"
                str &= "[SWCHKDUPPO] [smallint] NOT NULL,"
                str &= "[CATEGORY] [smallint] NOT NULL,"
                str &= "[BRN] [char](30) NOT NULL"

                str &= " )"

                Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
                cmd1.ExecuteNonQuery()
            End If
            connect.Close()

        Catch ex As Exception
            WriteLog("Error 600  CREATE_FMSARCUSMASTER() :" & ex.Message & STREXIST & " ; " & str)
        End Try
    End Sub

    Public Shared Sub CREATE_FMSARRTAMASTER()
        Dim STREXIST As String = ""
        Dim str As String = ""
        Try
            Connection.Openconnect("BILL", connect)
            'check Exist\
            Dim dtchkTemp As DataTable = New DataTable()

            STREXIST = "SELECT name FROM sys.tables WHERE name = 'FMSARRTAMASTER'"
            Dim cmdquery As SqlDataAdapter = New SqlDataAdapter(STREXIST, connect)
            cmdquery.Fill(dtchkTemp)

            'create table 
            If dtchkTemp.Rows.Count = 0 Then
                str = "CREATE TABLE [dbo].[FMSARRTAMASTER](" & Environment.NewLine
                str &= "[CODETERM] [char](6) NOT NULL,"
                str &= "[AUDTDATE] [decimal](9, 0) NOT NULL,"
                str &= "[AUDTTIME] [decimal](9, 0) NOT NULL,"
                str &= "[AUDTUSER] [char](8) NOT NULL,"
                str &= "[AUDTORG] [char](6) NOT NULL,"
                str &= "[TEXTDESC] [char](60) NOT NULL,"
                str &= "[ACTIVESW] [smallint] NOT NULL,"
                str &= "[INACDATE] [decimal](9, 0) NOT NULL,"
                str &= "[LASTMNTN] [decimal](9, 0) NOT NULL,"
                str &= "[MULTIPAYM] [smallint] NOT NULL,"
                str &= "[VATCODEM] [smallint] NOT NULL,"
                str &= "[DISCTYPE] [smallint] NOT NULL,"
                str &= "[DISCPCT] [decimal](9, 5) NOT NULL,"
                str &= "[DISCNBR] [decimal](3, 0) NOT NULL,"
                str &= "[DISCDAY] [decimal](3, 0) NOT NULL,"
                str &= "[DDAYSTRT1] [decimal](3, 0) NOT NULL,"
                str &= "[DDAYSTRT2] [decimal](3, 0) NOT NULL,"
                str &= "[DDAYSTRT3] [decimal](3, 0) NOT NULL,"
                str &= "[DDAYSTRT4] [decimal](3, 0) NOT NULL,"
                str &= "[DDAYEND1] [decimal](3, 0) NOT NULL,"
                str &= "[DDAYEND2] [decimal](3, 0) NOT NULL,"
                str &= "[DDAYEND3] [decimal](3, 0) NOT NULL,"
                str &= "[DDAYEND4] [decimal](3, 0) NOT NULL,"
                str &= "[DMNTHADD1] [decimal](3, 0) NOT NULL,"
                str &= "[DMNTHADD2] [decimal](3, 0) NOT NULL,"
                str &= "[DMNTHADD3] [decimal](3, 0) NOT NULL,"
                str &= "[DMNTHADD4] [decimal](3, 0) NOT NULL,"
                str &= "[DDAYUSE1] [decimal](3, 0) NOT NULL,"
                str &= "[DDAYUSE2] [decimal](3, 0) NOT NULL,"
                str &= "[DDAYUSE3] [decimal](3, 0) NOT NULL,"
                str &= "[DDAYUSE4] [decimal](3, 0) NOT NULL,"
                str &= "[DUETYPE] [smallint] NOT NULL,"
                str &= "[CNTDUEDAY] [decimal](3, 0) NOT NULL,"
                str &= "[DUENBRDAYS] [decimal](3, 0) NOT NULL,"
                str &= "[DUDAYST1] [decimal](3, 0) NOT NULL,"
                str &= "[DUDAYST2] [decimal](3, 0) NOT NULL,"
                str &= "[DUDAYST3] [decimal](3, 0) NOT NULL,"
                str &= "[DUDAYST4] [decimal](3, 0) NOT NULL,"
                str &= "[DUDAYEND1] [decimal](3, 0) NOT NULL,"
                str &= "[DUDAYEND2] [decimal](3, 0) NOT NULL,"
                str &= "[DUDAYEND3] [decimal](3, 0) NOT NULL,"
                str &= "[DUDAYEND4] [decimal](3, 0) NOT NULL,"
                str &= "[DUMNTHAD1] [decimal](3, 0) NOT NULL,"
                str &= "[DUMNTHAD2] [decimal](3, 0) NOT NULL,"
                str &= "[DUMNTHAD3] [decimal](3, 0) NOT NULL,"
                str &= "[DUMNTHAD4] [decimal](3, 0) NOT NULL,"
                str &= "[DUDAYUSE1] [decimal](3, 0) NOT NULL,"
                str &= "[DUDAYUSE2] [decimal](3, 0) NOT NULL,"
                str &= "[DUDAYUSE3] [decimal](3, 0) NOT NULL,"
                str &= "[DUDAYUSE4] [decimal](3, 0) NOT NULL,"
                str &= "[DTEDUESYNC] [smallint] NOT NULL,"
                str &= "[DTEDSCSYNC] [smallint] NOT NULL,"
                str &= "[CNTENTERED] [decimal](7, 0) NOT NULL,"
                str &= "[PCTDUETOT] [decimal](9, 5) NOT NULL" & Environment.NewLine
                str &= ")"
                Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
                cmd1.ExecuteNonQuery()
            End If
            connect.Close()

        Catch ex As Exception
            WriteLog("Error 680 CREATE_FMSARRTAMASTER() :" & ex.Message & STREXIST & " ; " & str)
        End Try
    End Sub

    Public Shared Sub CREATE_FMSCSCOMMASTER()
        Dim STREXIST As String = ""
        Dim str As String = ""
        Try
            Connection.Openconnect("BILL", connect)
            'check Exist\
            Dim dtchkTemp As DataTable = New DataTable()

            STREXIST = "SELECT name FROM sys.tables WHERE name = 'FMSCSCOMMASTER'"
            Dim cmdquery As SqlDataAdapter = New SqlDataAdapter(STREXIST, connect)
            cmdquery.Fill(dtchkTemp)

            'create table 
            If dtchkTemp.Rows.Count = 0 Then
                str = "CREATE TABLE [dbo].[FMSCSCOMMASTER](" & Environment.NewLine
                str &= "    [ORGID] [Char](6) Not NULL, " & Environment.NewLine
                str &= "    [AUDTDATE] [Decimal](9, 0) Not NULL, " & Environment.NewLine
                str &= "    [AUDTTIME] [Decimal](9, 0) Not NULL," & Environment.NewLine
                str &= "    [AUDTUSER] [Char](8) Not NULL," & Environment.NewLine
                str &= "    [AUDTORG] [Char](6) Not NULL," & Environment.NewLine
                str &= "    [CONAME] [Char](60) Not NULL," & Environment.NewLine
                str &= "    [ADDR01] [Char](60) Not NULL," & Environment.NewLine
                str &= "    [ADDR02] [Char](60) Not NULL," & Environment.NewLine
                str &= "    [ADDR03] [Char](60) Not NULL," & Environment.NewLine
                str &= "    [ADDR04] [Char](60) Not NULL," & Environment.NewLine
                str &= "    [CITY] [Char](30) Not NULL," & Environment.NewLine
                str &= "    [STATE] [Char](30) Not NULL," & Environment.NewLine
                str &= "    [POSTAL] [Char](20) Not NULL," & Environment.NewLine
                str &= "    [COUNTRY] [Char](30) Not NULL," & Environment.NewLine
                str &= "    [LOCTYPE] [Char](6) Not NULL," & Environment.NewLine
                str &= "    [LOCCODE] [Char](30) Not NULL," & Environment.NewLine
                str &= "    [PHONEFMT] [smallint] Not NULL," & Environment.NewLine
                str &= "    [PHONE] [Char](30) Not NULL," & Environment.NewLine
                str &= "    [FAX] [Char](30) Not NULL," & Environment.NewLine
                str &= "    [CONTACT] [Char](60) Not NULL," & Environment.NewLine
                str &= "    [CNTRYCODE] [Char](6) Not NULL," & Environment.NewLine
                str &= "    [BRANCH] [Char](6) Not NULL," & Environment.NewLine
                str &= "    [PERDFSC] [smallint] Not NULL," & Environment.NewLine
                str &= "    [QTR4PERD] [smallint] Not NULL," & Environment.NewLine
                str &= "    [HOMECUR] [Char](3) Not NULL," & Environment.NewLine
                str &= "    [MULTICURSW] [smallint] Not NULL," & Environment.NewLine
                str &= "    [RATETYPE] [Char](2) Not NULL," & Environment.NewLine
                str &= "    [WARNDAYS] [smallint] Not NULL," & Environment.NewLine
                str &= "    [EUROCURSW] [smallint] Not NULL," & Environment.NewLine
                str &= "    [REPORTCUR] [Char](3) Not NULL," & Environment.NewLine
                str &= "    [HNDLCKFSC] [smallint] Not NULL," & Environment.NewLine
                str &= "    [HNDINAACCT] [smallint] Not NULL," & Environment.NewLine
                str &= "    [HNDNEXACCT] [smallint] Not NULL," & Environment.NewLine
                str &= "    [GNLSSMTHD] [smallint] Not NULL," & Environment.NewLine
                str &= "    [TAXNBR] [Char](20) Not NULL," & Environment.NewLine
                str &= "    [LEGALNAME] [Char](60) Not NULL," & Environment.NewLine
                str &= "    [BRN] [Char](30) Not NULL," & Environment.NewLine
                str &= "    [EMAILHOST] [Char](50) Not NULL," & Environment.NewLine
                str &= "    [EMAILUSER] [Char](50) Not NULL," & Environment.NewLine
                str &= "    [EMAILPSWD] [binary](50) Not NULL," & Environment.NewLine
                str &= "    [EMAILPORT] [smallint] Not NULL," & Environment.NewLine
                str &= "    [EMAILSSL] [smallint] Not NULL," & Environment.NewLine
                str &= "    [EMAILADDR] [Char](50) Not NULL," & Environment.NewLine
                str &= "    [USESMTP] [smallint] Not NULL," & Environment.NewLine
                str &= "    [CCADDR] [Char](250) Not NULL," & Environment.NewLine
                str &= "    [BCCADDR] [Char](250) Not NULL)" & Environment.NewLine

                Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
                cmd1.ExecuteNonQuery()
            End If
            connect.Close()

        Catch ex As Exception
            WriteLog("Error 752 CREATE_FMSCSCOMMASTER() :" & ex.Message & STREXIST & " ; " & str)
        End Try
    End Sub

    Public Shared Sub CREATE_FMSARCUSO()
        Dim STREXIST As String = ""
        Dim str As String = ""
        Try
            Connection.Openconnect("BILL", connect)
            'check Exist\
            Dim dtchkTemp As DataTable = New DataTable()

            STREXIST = "SELECT name FROM sys.tables WHERE name = 'FMSARCUSO'"
            Dim cmdquery As SqlDataAdapter = New SqlDataAdapter(STREXIST, connect)
            cmdquery.Fill(dtchkTemp)
            Dim DBSRC = MAIN.txtDBSOURCE.Text.TrimEnd.TrimEnd
            'create table 
            If dtchkTemp.Rows.Count = 0 Then
                str = "Select * into FMSARCUSO  from " & DBSRC & ".dbo.ARCUSO"
                Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
                cmd1.ExecuteNonQuery()
            End If
            connect.Close()

        Catch ex As Exception
            WriteLog("Error 752 CREATE_FMSCSCOMMASTER() :" & ex.Message & STREXIST & " ; " & str)
        End Try
    End Sub

#End Region

#End Region

#Region "INSERT"

#Region "BILL"
    Public Shared Function INSERTBILLHEADER(ByVal DTBILLHEAD As DataTable) As Boolean
        Dim STREXIST As String = ""
        Dim str As String = ""
        Try
            Connection.Openconnect("BILL", connect)
            Dim STRCOL As String = PROCESS.COLNAME("BILLHEAD")
            'check Exist\
            For i = 0 To DTBILLHEAD.Rows.Count - 1
                str = "INSERT INTO [dbo].[FMSBILLHEAD] " & Environment.NewLine
                str &= "           ( " & Environment.NewLine
                str &= STRCOL & Environment.NewLine
                str &= "           ) " & Environment.NewLine
                str &= "     VALUES " & Environment.NewLine
                str &= "           ('" & DTBILLHEAD.Rows(i).Item("BILLSEQ").ToString.TrimEnd & "' --<BILLSEQ, nvarchar(50),> " & Environment.NewLine
                str &= "           ,'" & DTBILLHEAD.Rows(i).Item("BILLNO").ToString.TrimEnd & "' --<BILLNO, nvarchar(50),> " & Environment.NewLine
                str &= "           ,'" & DTBILLHEAD.Rows(i).Item("IDCUST").ToString.TrimEnd & "' --<IDCUST, nvarchar(100),> " & Environment.NewLine
                str &= "          ,'" & DTBILLHEAD.Rows(i).Item("INVDATE").ToString.TrimEnd & "' --<INVDATE, numeric(18,2),> " & Environment.NewLine
                str &= "           ,'" & DTBILLHEAD.Rows(i).Item("DUEDATE").ToString.TrimEnd & "' --<DUEDATE, numeric(18,2),> " & Environment.NewLine
                str &= "           ,'" & DTBILLHEAD.Rows(i).Item("BILLDOCDATE").ToString.TrimEnd & "' --<BILLDOCDATE, numeric(18,2),> " & Environment.NewLine
                str &= "           ,'" & DTBILLHEAD.Rows(i).Item("AMT").ToString.TrimEnd & "' --<AMT, numeric(18,2),> " & Environment.NewLine
                str &= "           ,'" & DTBILLHEAD.Rows(i).Item("NETAMT").ToString.TrimEnd & "' --<NETAMT, numeric(18,2),> " & Environment.NewLine
                str &= "           ,'" & DTBILLHEAD.Rows(i).Item("REF_0").ToString.TrimEnd & "' --<REF_0, text,> " & Environment.NewLine
                str &= "           ,'" & DTBILLHEAD.Rows(i).Item("COMMENT").ToString.TrimEnd & "' --<COMMENT, text,> " & Environment.NewLine
                str &= "           ,'" & DTBILLHEAD.Rows(i).Item("STA_0").ToString.TrimEnd & "' --<STA_0, int,> " & Environment.NewLine
                str &= "           ,'" & DTBILLHEAD.Rows(i).Item("TERMCODE").ToString.TrimEnd & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLHEAD.Rows(i).Item("BILLHTEXT1").ToString.TrimEnd & "' --<BILLHTEXT1, text,> " & Environment.NewLine
                str &= "           ,'" & DTBILLHEAD.Rows(i).Item("BILLHTEXT2").ToString.TrimEnd & "' --<BILLHTEXT2, text,> " & Environment.NewLine
                str &= "           ,'" & DTBILLHEAD.Rows(i).Item("BILLHTEXT3").ToString.TrimEnd & "' --<BILLHTEXT3, text,>" & Environment.NewLine
                str &= "           ,'" & DTBILLHEAD.Rows(i).Item("BILLHTEXT4").ToString.TrimEnd & "' --<BILLHTEXT4, text,>" & Environment.NewLine
                str &= "           ,'" & DTBILLHEAD.Rows(i).Item("BILLHTEXT5").ToString.TrimEnd & "' --<BILLHTEXT5, text,>" & Environment.NewLine
                str &= "           ,'" & DTBILLHEAD.Rows(i).Item("BILLHTEXT6").ToString.TrimEnd & "' --<BILLHTEXT6, text,>" & Environment.NewLine
                str &= "           ,'" & DTBILLHEAD.Rows(i).Item("BILLHTEXT7").ToString.TrimEnd & "' --<BILLHTEXT7, text,>" & Environment.NewLine
                str &= "           ,'" & DTBILLHEAD.Rows(i).Item("BILLHTEXT8").ToString.TrimEnd & "' --<BILLHTEXT8, text,>" & Environment.NewLine
                str &= "           ,'" & DTBILLHEAD.Rows(i).Item("BILLHTEXT9").ToString.TrimEnd & "' --<BILLHTEXT9, text,>" & Environment.NewLine
                str &= "           ,'" & DTBILLHEAD.Rows(i).Item("BILLHTEXT10").ToString.TrimEnd & "' --<BILLHTEXT10, text,>)" & Environment.NewLine
                str &= "           ,'" & MAIN.txtDBSOURCE.Text.TrimEnd & "'" & Environment.NewLine
                str &= "           ,'" & FrmBillingNote.CbmBOI.Text & "'" & Environment.NewLine
                str &= "           )"
                Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
                cmd1.ExecuteNonQuery()
            Next
            connect.Close()
            Return True
        Catch ex As Exception
            WriteLog("Error 808 INSERTBILLHEADER() :" & ex.Message & STREXIST & " ; " & str)
            Return False
        End Try
    End Function
    Public Shared Sub INSERTBILLDETAIL(ByVal DTBILLDETAIL As DataTable)
        Dim STREXIST As String = ""
        Dim str As String = ""
        Try
            Connection.Openconnect("BILL", connect)
            'check Exist\
            For i = 0 To DTBILLDETAIL.Rows.Count - 1
                str = "INSERT INTO [dbo].[FMSBILLDETAIL] " & Environment.NewLine
                str &= "           ([BILLSEQ] " & Environment.NewLine
                str &= "           ,[BILLNO] " & Environment.NewLine
                str &= "           ,[DETAILLINE] " & Environment.NewLine
                str &= "           ,[IDCUST] " & Environment.NewLine
                str &= "           ,[INVNO] " & Environment.NewLine
                str &= "           ,[INVDATE] " & Environment.NewLine
                str &= "           ,[DUEDATE] " & Environment.NewLine
                str &= "           ,[PONUM] " & Environment.NewLine
                str &= "           ,[LINEAMOUNT] " & Environment.NewLine
                str &= "           ,[AMTOUTSTAND]" & Environment.NewLine
                str &= "           ,[NETAMT] " & Environment.NewLine
                str &= "           ,[CHECK_0] " & Environment.NewLine
                str &= "           ,[STA_0] " & Environment.NewLine
                str &= "           ,[BILLDTEXT1] " & Environment.NewLine
                str &= "           ,[BILLDTEXT2] " & Environment.NewLine
                str &= "           ,[BILLDTEXT3] " & Environment.NewLine
                str &= "           ,[BILLDTEXT4] " & Environment.NewLine
                str &= "           ,[BILLDTEXT5] " & Environment.NewLine
                str &= "           ,[BILLDTEXT6] " & Environment.NewLine
                str &= "           ,[BILLDTEXT7] " & Environment.NewLine
                str &= "           ,[BILLDTEXT8] " & Environment.NewLine
                str &= "           ,[BILLDTEXT9] " & Environment.NewLine
                str &= "           ,[BILLDTEXT10] " & Environment.NewLine
                str &= "           ,[AUDTORG])" & Environment.NewLine
                str &= "     VALUES " & Environment.NewLine
                str &= "           ('" & DTBILLDETAIL.Rows(i).Item("BILLSEQ").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("BILLNO").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("DETAILLINE").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("IDCUST").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("INVNO").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("INVDATE").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("DUEDATE").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("PONUM").ToString & "'" & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("LINEAMOUNT").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("AMTOUTSTAND").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("NETAMT").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("CHECK_0").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("STA_0").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("BILLDTEXT1").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("BILLDTEXT2").ToString & "'" & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("BILLDTEXT3").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("BILLDTEXT4").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("BILLDTEXT5").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("BILLDTEXT6").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("BILLDTEXT7").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("BILLDTEXT8").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("BILLDTEXT9").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("BILLDTEXT10").ToString & "' " & Environment.NewLine
                str &= "           ,'" & MAIN.txtDBSOURCE.Text.TrimEnd & "'" & Environment.NewLine
                str &= "            ) " & Environment.NewLine

                Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
                cmd1.ExecuteNonQuery()
            Next
            connect.Close()

        Catch ex As Exception
            WriteLog("Error 875 INSERTBILLDETAIL() :" & ex.Message & STREXIST & " ; " & str)
            'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Shared Sub INSERTBILLDETAILREV(ByVal BILLNO As String, ByVal INVNO As String)
        Dim STREXIST As String = ""
        Dim str As String = ""
        Try
            Connection.Openconnect("BILL", connect)
            'check Exist\

            str &= "INSERT INTO FMSBILLDETAILREV " & Environment.NewLine
            str &= "SELECT * FROM FMSBILLDETAIL " & Environment.NewLine
            str &= "WHERE BILLNO = '" & BILLNO & "' AND INVNO = '" & INVNO & "' " & Environment.NewLine & Environment.NewLine
            str &= "UPDATE FMSBILLDETAILREV SET AMTOUTSTAND  = NETAMT " & Environment.NewLine
            str &= "WHERE BILLNO = '" & BILLNO & "' AND INVNO = '" & INVNO & "' " & Environment.NewLine
            Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
            cmd1.ExecuteNonQuery()

            connect.Close()

        Catch ex As Exception
            WriteLog("Error 897  INSERTBILLDETAILREV:" & ex.Message & STREXIST & " ; " & str)
        End Try
    End Sub


#End Region

#Region "RCP"
    Public Shared Sub INSERTRCPHEADER(ByVal DTBILLHEAD As DataTable)
        Dim STREXIST As String = ""
        Dim str As String = ""
        Try
            Connection.Openconnect("BILL", connect)
            Dim STRCOL As String = PROCESS.COLNAME("RCPHEAD")
            Dim TAXINV As String
            If FrmReceipt.BTN_Receipt.Checked.ToString = True Then
                TAXINV = "RCP"
            Else
                TAXINV = "TAX"
            End If
            'check Exist\
            For i = 0 To DTBILLHEAD.Rows.Count - 1
                str = "INSERT INTO [dbo].[FMSRCPHEAD] " & Environment.NewLine
                str &= "           ( " & Environment.NewLine
                str &= STRCOL & ",TAXINV" & Environment.NewLine
                str &= "           ) " & Environment.NewLine
                str &= "     VALUES " & Environment.NewLine
                str &= "('" & DTBILLHEAD.Rows(i).Item("RCPSEQ").ToString & "' --<RCPSEQ, nvarchar(50),> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("RCPNO").ToString & "' --<RCPNO, nvarchar(50),> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("IDCUST").ToString & "' --<IDCUST, nvarchar(50),> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("RECEIVEDOCDATE").ToString & "' --<RECEIVEDOCDATE, numeric(18,0),> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("RECEIVEDATE").ToString & "' --<RECEIVEDATE, numeric(18,0),> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("BANKCODE").ToString & "' --<BANKCODE, nvarchar(20),> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("AMT").ToString & "' --<AMT, numeric(18,2),> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("NETAMT").ToString & "' --<NETAMT, numeric(18,2),> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("REF_0").ToString & "' --<REF_0, text,> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("COMMENT").ToString & "' --<COMMENT, text,> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("PAYTYPE").ToString & "' --<PAYTYPE, int,> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("PAYDATE").ToString & "' --<PAYDATE, numeric(18,0),> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("CRCARDNO").ToString & "' --<CRCARDNO, nvarchar(20),> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("TRANSBANKCODE").ToString & "' --<TRANSBANKCODE, nvarchar(20),> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("TRANSBANKNO").ToString & "' --<TRANSBANKNO, nvarchar(20),> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("TRANSFEE").ToString & "' --<TRANSFEE, numeric(18,2),> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("CHEQNO").ToString & "' --<CHEQNO, nvarchar(20),> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("CHEQBRANCH").ToString & "' --<CHEQBRANCH, nvarchar(20),> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("CHEQACCT").ToString & "' --<CHEQACCT, nvarchar(20),> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("CHEQDATE").ToString & "' --<CHEQDATE, numeric(18,0),> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("SHOWCHEQDATE").ToString & "' --<SHOWCHEQDATE, int,> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("SHOWRECEIVEDATE").ToString & "' --<SHOWRECEIVEDATE, int,>" & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("STA_0").ToString & "' --<STA_0, int,>" & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("RCPHTEXT1").ToString & "' --<RCPHTEXT1, text,> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("RCPHTEXT2").ToString & "' --<RCPHTEXT2, text,> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("RCPHTEXT3").ToString & "' --<RCPHTEXT3, text,> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("RCPHTEXT4").ToString & "' --<RCPHTEXT4, text,>" & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("RCPHTEXT5").ToString & "' --<RCPHTEXT5, text,>" & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("RCPHTEXT6").ToString & "' --<RCPHTEXT6, text,>" & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("RCPHTEXT7").ToString & "' --<RCPHTEXT7, text,>" & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("RCPHTEXT8").ToString & "' --<RCPHTEXT8, text,>" & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("RCPHTEXT9").ToString & "' --<RCPHTEXT9, text,>" & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("RCPHTEXT10").ToString & "' --<RCPHTEXT10, text,>" & Environment.NewLine
                str &= ",'" & MAIN.txtDBSOURCE.Text.TrimEnd & "'" & Environment.NewLine
                str &= ",'N' --Import CB status Yes,NO " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("BANKBATCH").ToString & "'" & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("CHEQBANK").ToString & "'" & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("CBDATE").ToString.TrimEnd & "'" & Environment.NewLine
                str &= ",'" & TAXINV & "'" & Environment.NewLine
                str &= ")"
                Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
                cmd1.ExecuteNonQuery()
            Next
            connect.Close()
        Catch ex As Exception
            WriteLog("Error 960 INSERTRCPHEADER:" & ex.Message & STREXIST & " ; " & str)
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Shared Sub INSERTRCPDETAIL(ByVal DTBILLDETAIL As DataTable)
        Dim STREXIST As String = ""
        Dim str As String = ""
        Try
            Connection.Openconnect("BILL", connect)
            'check Exist\
            For i = 0 To DTBILLDETAIL.Rows.Count - 1
                str = "INSERT INTO [dbo].[FMSRCPDETAIL] " & Environment.NewLine
                str &= "            ([RCPSEQ]" & Environment.NewLine
                str &= "            ,[RCPNO] " & Environment.NewLine
                str &= "            ,[DETAILLINE] " & Environment.NewLine
                str &= "            ,[BILLNO] " & Environment.NewLine
                str &= "            ,[IDCUST]" & Environment.NewLine
                str &= "            ,[INVNO]" & Environment.NewLine
                str &= "            ,[INVDATE]" & Environment.NewLine
                str &= "            ,[DueDate]" & Environment.NewLine
                str &= "            ,[PONUM]" & Environment.NewLine
                str &= "            ,[UNITPRICE]" & Environment.NewLine
                str &= "            ,[VATAMT]" & Environment.NewLine
                str &= "            ,[RCPAMT]" & Environment.NewLine
                str &= "            ,[AMTOUTSTAND]" & Environment.NewLine
                str &= "            ,[NETAMT]" & Environment.NewLine
                str &= "            ,[AMT]" & Environment.NewLine
                str &= "            ,[CHECK_0]" & Environment.NewLine
                str &= "            ,[STA_0]" & Environment.NewLine
                str &= "            ,[RCPDTEXT1]" & Environment.NewLine
                str &= "            ,[RCPDTEXT2]" & Environment.NewLine
                str &= "            ,[RCPDTEXT3]" & Environment.NewLine
                str &= "            ,[RCPDTEXT4]" & Environment.NewLine
                str &= "            ,[RCPDTEXT5]" & Environment.NewLine
                str &= "            ,[RCPDTEXT6]" & Environment.NewLine
                str &= "            ,[RCPDTEXT7]" & Environment.NewLine
                str &= "            ,[RCPDTEXT8]" & Environment.NewLine
                str &= "            ,[RCPDTEXT9]" & Environment.NewLine
                str &= "            ,[RCPDTEXT10]" & Environment.NewLine
                str &= "            ,[AUDTORG]" & Environment.NewLine
                str &= "            ,[VAT])" & Environment.NewLine
                str &= "     VALUES " & Environment.NewLine
                str &= "           ('" & DTBILLDETAIL.Rows(i).Item("RCPSEQ").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("RCPNO").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("DETAILLINE").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("BILLNO").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("IDCUST").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("INVNO").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("INVDATE").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("DUEDATE").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("PONUM").ToString & "'" & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("UNITPRICE").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("VATAMT").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("RCPAMT").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("AMTOUTSTAND").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("RCPAMT").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("AMT").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("CHECK_0").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("STA_0").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("RCPDTEXT1").ToString & "'" & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("RCPDTEXT2").ToString & "'" & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("RCPDTEXT3").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("RCPDTEXT4").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("RCPDTEXT5").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("RCPDTEXT6").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("RCPDTEXT7").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("RCPDTEXT8").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("RCPDTEXT9").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("RCPDTEXT10").ToString & "' " & Environment.NewLine
                str &= "           ,'" & MAIN.txtDBSOURCE.Text.TrimEnd & "'" & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("VAT").ToString & "'" & Environment.NewLine
                str &= "            ) " & Environment.NewLine

                Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
                cmd1.ExecuteNonQuery()
            Next
            connect.Close()

        Catch ex As Exception
            WriteLog("Error 1035 INSERTRCPDETAIL() :" & ex.Message & STREXIST & " ; " & str)
        End Try
    End Sub

#Region "UPDATE RCP"
    Public Shared Sub INSERTUpdateRCPHEADER(ByVal DTBILLHEAD As DataTable)
        Dim STREXIST As String = ""
        Dim str As String = ""
        Try
            Connection.Openconnect("BILL", connect)
            Dim STRCOL As String = PROCESS.COLNAME("RCPHEAD")
            Dim TAXINV As String
            If FrmReceipt.BTN_Receipt.Checked.ToString = True Then
                TAXINV = "RCP"
            Else
                TAXINV = "TAX"
            End If
            'check Exist\
            For i = 0 To DTBILLHEAD.Rows.Count - 1
                str &= "DELETE FROM FMSRCPHEAD WHERE RCPSEQ = '" & DTBILLHEAD.Rows(i).Item("RCPSEQ").ToString & "' AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "'" & Environment.NewLine
                str &= "INSERT INTO [dbo].[FMSRCPHEAD] " & Environment.NewLine
                str &= "           ( " & Environment.NewLine
                str &= STRCOL & ",TAXINV" & Environment.NewLine
                str &= "           ) " & Environment.NewLine
                str &= "     VALUES " & Environment.NewLine
                str &= "('" & DTBILLHEAD.Rows(i).Item("RCPSEQ").ToString & "' --<RCPSEQ, nvarchar(50),> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("RCPNO").ToString & "' --<RCPNO, nvarchar(50),> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("IDCUST").ToString & "' --<IDCUST, nvarchar(50),> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("RECEIVEDOCDATE").ToString & "' --<RECEIVEDOCDATE, numeric(18,0),> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("RECEIVEDATE").ToString & "' --<RECEIVEDATE, numeric(18,0),> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("BANKCODE").ToString & "' --<BANKCODE, nvarchar(20),> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("AMT").ToString & "' --<AMT, numeric(18,2),> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("NETAMT").ToString & "' --<NETAMT, numeric(18,2),> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("REF_0").ToString & "' --<REF_0, text,> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("COMMENT").ToString & "' --<COMMENT, text,> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("PAYTYPE").ToString & "' --<PAYTYPE, int,> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("PAYDATE").ToString & "' --<PAYDATE, numeric(18,0),> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("CRCARDNO").ToString & "' --<CRCARDNO, nvarchar(20),> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("TRANSBANKCODE").ToString & "' --<TRANSBANKCODE, nvarchar(20),> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("TRANSBANKNO").ToString & "' --<TRANSBANKNO, nvarchar(20),> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("TRANSFEE").ToString & "' --<TRANSFEE, numeric(18,2),> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("CHEQNO").ToString & "' --<CHEQNO, nvarchar(20),> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("CHEQBRANCH").ToString & "' --<CHEQBRANCH, nvarchar(20),> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("CHEQACCT").ToString & "' --<CHEQACCT, nvarchar(20),> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("CHEQDATE").ToString & "' --<CHEQDATE, numeric(18,0),> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("SHOWCHEQDATE").ToString & "' --<SHOWCHEQDATE, int,> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("SHOWRECEIVEDATE").ToString & "' --<SHOWRECEIVEDATE, int,>" & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("STA_0").ToString & "' --<STA_0, int,>" & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("RCPHTEXT1").ToString & "' --<RCPHTEXT1, text,> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("RCPHTEXT2").ToString & "' --<RCPHTEXT2, text,> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("RCPHTEXT3").ToString & "' --<RCPHTEXT3, text,> " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("RCPHTEXT4").ToString & "' --<RCPHTEXT4, text,>" & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("RCPHTEXT5").ToString & "' --<RCPHTEXT5, text,>" & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("RCPHTEXT6").ToString & "' --<RCPHTEXT6, text,>" & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("RCPHTEXT7").ToString & "' --<RCPHTEXT7, text,>" & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("RCPHTEXT8").ToString & "' --<RCPHTEXT8, text,>" & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("RCPHTEXT9").ToString & "' --<RCPHTEXT9, text,>" & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("RCPHTEXT10").ToString & "' --<RCPHTEXT10, text,>" & Environment.NewLine
                str &= ",'" & MAIN.txtDBSOURCE.Text.TrimEnd & "'" & Environment.NewLine
                str &= ",'N' --Import CB status Yes,NO " & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("BANKBATCH").ToString & "'" & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("CHEQBANK").ToString & "'" & Environment.NewLine
                str &= ",'" & DTBILLHEAD.Rows(i).Item("CBDATE").ToString & "'" & Environment.NewLine
                str &= ",'" & TAXINV & "'" & Environment.NewLine
                str &= ")"
                Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
                cmd1.ExecuteNonQuery()
            Next
            connect.Close()
        Catch ex As Exception
            WriteLog("Error 1100 INSERTUpdateRCPHEADER:" & ex.Message & STREXIST & " ; " & str)
        End Try
    End Sub
    Public Shared Sub INSERTUpdateRCPDETAIL(ByVal DTBILLDETAIL As DataTable)
        Dim STREXIST As String = ""
        Dim str As String = ""
        Try
            Connection.Openconnect("BILL", connect)
            'check Exist\

            For i = 0 To DTBILLDETAIL.Rows.Count - 1
                If i = 0 Then
                    str &= "DELETE FROM FMSRCPDETAIL WHERE RCPNO = '" & DTBILLDETAIL.Rows(0).Item("RCPNO").ToString & "' AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "'" & Environment.NewLine
                End If

                str &= "INSERT INTO [dbo].[FMSRCPDETAIL] " & Environment.NewLine
                str &= "            ([RCPSEQ]" & Environment.NewLine
                str &= "            ,[RCPNO] " & Environment.NewLine
                str &= "            ,[DETAILLINE] " & Environment.NewLine
                str &= "            ,[BILLNO] " & Environment.NewLine
                str &= "            ,[IDCUST]" & Environment.NewLine
                str &= "            ,[INVNO]" & Environment.NewLine
                str &= "            ,[INVDATE]" & Environment.NewLine
                str &= "            ,[DueDate]" & Environment.NewLine
                str &= "            ,[PONUM]" & Environment.NewLine
                str &= "            ,[UNITPRICE]" & Environment.NewLine
                str &= "            ,[VATAMT]" & Environment.NewLine
                str &= "            ,[RCPAMT]" & Environment.NewLine
                str &= "            ,[AMTOUTSTAND]" & Environment.NewLine
                str &= "            ,[NETAMT]" & Environment.NewLine
                str &= "            ,[AMT]" & Environment.NewLine
                str &= "            ,[CHECK_0]" & Environment.NewLine
                str &= "            ,[STA_0]" & Environment.NewLine
                str &= "            ,[RCPDTEXT1]" & Environment.NewLine
                str &= "            ,[RCPDTEXT2]" & Environment.NewLine
                str &= "            ,[RCPDTEXT3]" & Environment.NewLine
                str &= "            ,[RCPDTEXT4]" & Environment.NewLine
                str &= "            ,[RCPDTEXT5]" & Environment.NewLine
                str &= "            ,[RCPDTEXT6]" & Environment.NewLine
                str &= "            ,[RCPDTEXT7]" & Environment.NewLine
                str &= "            ,[RCPDTEXT8]" & Environment.NewLine
                str &= "            ,[RCPDTEXT9]" & Environment.NewLine
                str &= "            ,[RCPDTEXT10]" & Environment.NewLine
                str &= "            ,[VAT]" & Environment.NewLine
                str &= "            ,[AUDTORG])" & Environment.NewLine
                str &= "     VALUES " & Environment.NewLine
                str &= "           ('" & DTBILLDETAIL.Rows(i).Item("RCPSEQ").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("RCPNO").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("DETAILLINE").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("BILLNO").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("IDCUST").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("INVNO").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("INVDATE").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("DUEDATE").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("PONUM").ToString & "'" & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("UNITPRICE").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("VATAMT").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("RCPAMT").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("AMTOUTSTAND").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("RCPAMT").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("AMT").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("CHECK_0").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("STA_0").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("RCPDTEXT1").ToString & "'" & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("RCPDTEXT2").ToString & "'" & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("RCPDTEXT3").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("RCPDTEXT4").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("RCPDTEXT5").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("RCPDTEXT6").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("RCPDTEXT7").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("RCPDTEXT8").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("RCPDTEXT9").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("RCPDTEXT10").ToString & "' " & Environment.NewLine
                str &= "           ,'" & DTBILLDETAIL.Rows(i).Item("VAT").ToString & "' " & Environment.NewLine
                str &= "           ,'" & MAIN.txtDBSOURCE.Text.TrimEnd & "'" & Environment.NewLine
                str &= "            ) " & Environment.NewLine

                Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
                cmd1.ExecuteNonQuery()
            Next
            connect.Close()

        Catch ex As Exception
            WriteLog("Error 1180 INSERTUpdateRCPDETAIL() :" & ex.Message & STREXIST & " ; " & str)
        End Try
    End Sub
#End Region

#End Region

#Region "IMPORT CB"
    Public Shared Sub INSERTFMSMASTERIMPORT()
        Dim STREXIST As String = ""
        Dim str As String = ""
        Call DATACLASS.CREATEFMSMASTERIMPORT()
        Try
            Connection.Openconnect("BILL", connect)
            'check Exist\ 
            str &= "DELETE FROM FMSMASTERIMPORT WHERE COMPANY = '" & FrmIMPORTCB.txtCBCompany.Text.TrimEnd & "' AND ACCPACVERSION = '" & FrmIMPORTCB.txtCBVersion.Text & "'" & Environment.NewLine
            str &= "INSERT INTO [dbo].[FMSMASTERIMPORT]  " & Environment.NewLine
            str &= "           ([ACCPACID]  " & Environment.NewLine
            str &= "           ,[ACCPACPASSWORD]  " & Environment.NewLine
            str &= "           ,[COMPANY]  " & Environment.NewLine
            str &= "           ,[ACCPACVERSION]  " & Environment.NewLine
            str &= "           ,[DNSRCCODE]  " & Environment.NewLine
            str &= "           ,[CNSRCCODE]  " & Environment.NewLine
            str &= "           ,[PATHBACKUP]  " & Environment.NewLine
            str &= "           ,[PATHERROR]  " & Environment.NewLine
            str &= "           ,[COMP]  " & Environment.NewLine
            str &= "           ,[AUDTORG]  " & Environment.NewLine
            str &= "           ,[OPTFD_HEAD] " & Environment.NewLine
            str &= "           ,[OPTFD_DETAIL]) " & Environment.NewLine
            str &= "     VALUES  " & Environment.NewLine
            str &= "           ('" & FrmIMPORTCB.txtCBAccpacID.Text.TrimEnd & "' --<ACCPACID, nvarchar(50),>  " & Environment.NewLine
            str &= "           ,'" & FrmIMPORTCB.txtCBPassword.Text.TrimEnd.ToUpper() & "' --<ACCPACPASSWORD, nvarchar(50),>  " & Environment.NewLine
            str &= "           ,'" & FrmIMPORTCB.txtCBCompany.Text.TrimEnd & "' --<COMPANY, nvarchar(50),>  " & Environment.NewLine
            str &= "           ,'" & FrmIMPORTCB.txtCBVersion.Text.TrimEnd & "' --<ACCPACVERSION, nvarchar(5),>  " & Environment.NewLine
            str &= "           ,'" & FrmIMPORTCB.txtDNSRCCODE.Text.TrimEnd & "' --<DNSRCCODE, nvarchar(10),>  " & Environment.NewLine
            str &= "           ,'" & FrmIMPORTCB.txtCNSRCCODE.Text.TrimEnd & "' --<CNSRCCODE, nvarchar(10),> " & Environment.NewLine
            str &= "           ,'" & FrmIMPORTCB.txtCBPathBK.Text.TrimEnd & "' --<PATHBACKUP, text,> " & Environment.NewLine
            str &= "           ,'" & FrmIMPORTCB.txtCBPathErr.Text.TrimEnd & "' --<PATHERROR, text,> " & Environment.NewLine
            str &= "           ,'" & MAIN.txtDBSOURCE.Text.TrimEnd & "' --<COMP, nvarchar(50),> " & Environment.NewLine
            str &= "           ,'" & MAIN.txtDBSOURCE.Text.TrimEnd & "' --<AUDTORG, char(10),> " & Environment.NewLine

            If FrmIMPORTCB.OPTFD_HEADER.CheckState = CheckState.Checked Then
                str &= "           ,'/'" & Environment.NewLine
            Else
                str &= "           ,''" & Environment.NewLine
            End If

            If FrmIMPORTCB.OPTFD_DETAIL.CheckState = CheckState.Checked Then
                str &= "           ,'/'" & Environment.NewLine
            Else
                str &= "           ,''" & Environment.NewLine
            End If

            str &= "		   )" & Environment.NewLine

            Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
            cmd1.ExecuteNonQuery()

            connect.Close()

        Catch ex As Exception
            WriteLog("Error 1080 INSERTFMSMASTERIMPORT() :" & ex.Message & STREXIST & " ; " & str)
        End Try
    End Sub

    Public Shared Sub INSERTFMSLOGIMPORT(ByVal dtFormatRunno As DataTable, ByVal RCPNO As String)
        Dim STREXIST As String = ""
        Dim str As String = ""
        Call DATACLASS.CREATEFMSLOGIMPORT()
        Try
            Connection.Openconnect("BILL", connect)
            'check Exist\
            If dtFormatRunno.Rows.Count > 0 Then

                For i = 0 To dtFormatRunno.Rows.Count - 1
                    str &= "INSERT INTO [dbo].[FMSLOGIMPORT] " & Environment.NewLine
                    str &= "           ([CREATEDATE] " & Environment.NewLine
                    str &= "           ,[Priority] " & Environment.NewLine
                    str &= "           ,[Description] " & Environment.NewLine
                    str &= "           ,[Source]" & Environment.NewLine
                    str &= "           ,[PriorityType]" & Environment.NewLine
                    str &= "           ,[RCPNO]" & Environment.NewLine
                    str &= "           ,[AUDTORG] " & Environment.NewLine
                    str &= "            )"
                    str &= "     VALUES " & Environment.NewLine
                    str &= "           (" & Environment.NewLine
                    str &= "           " & CDate(Now).ToString("yyyyMMdd") & "  "
                    str &= "           ,'" & dtFormatRunno.Rows(i).Item(1).ToString.TrimEnd & "' " & Environment.NewLine
                    str &= "           ,'" & dtFormatRunno.Rows(i).Item(2).ToString.TrimEnd & "' " & Environment.NewLine
                    str &= "           ,'" & dtFormatRunno.Rows(i).Item(3).ToString.TrimEnd & "' " & Environment.NewLine
                    str &= "           ,'" & dtFormatRunno.Rows(i).Item(4).ToString.TrimEnd & "' " & Environment.NewLine
                    str &= "           ,'" & RCPNO & "'" & Environment.NewLine
                    str &= "           ,'" & MAIN.txtDBSOURCE.Text.TrimEnd & "'" & Environment.NewLine
                    str &= "            ) " & Environment.NewLine
                Next
                Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
                cmd1.ExecuteNonQuery()

            End If
            connect.Close()

        Catch ex As Exception
            WriteLog("Error 1122 INSERTFMSLOGIMPORT() :" & ex.Message & STREXIST & " ; " & str)
        End Try
    End Sub

#End Region

#Region "MASTER"

    Public Shared Sub INSERTFMSMASTERRUNING(ByVal dtFormatRunno As DataTable)
        Dim STREXIST As String = ""
        Dim str As String = ""
        Call DATACLASS.CREATEFMSMASTERRUNNING()
        Try
            Connection.Openconnect("BILL", connect)
            'check Exist\
            If dtFormatRunno.Rows.Count > 0 Then
                str = "DELETE FROM [FMSMASTERRUNING] WHERE COMP = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "'"
                For i = 0 To dtFormatRunno.Rows.Count - 1
                    str &= "INSERT INTO [dbo].[FMSMASTERRUNING] " & Environment.NewLine
                    str &= "           ([DOCTYPE] " & Environment.NewLine
                    str &= "           ,[LENGTH] " & Environment.NewLine
                    str &= "           ,[PREFIX] " & Environment.NewLine
                    str &= "           ,[RUNNO] " & Environment.NewLine
                    str &= "           ,[COMP]" & Environment.NewLine
                    str &= "           ,[AUDTORG] " & Environment.NewLine
                    str &= "           ,[RCPTYPE]" & Environment.NewLine
                    str &= "            )"
                    str &= "     VALUES " & Environment.NewLine
                    str &= "           ('" & dtFormatRunno.Rows(i).Item("DOCTYPE").ToString.TrimEnd & "' " & Environment.NewLine
                    str &= "           ,'" & dtFormatRunno.Rows(i).Item("LENGTH").ToString.TrimEnd & "' " & Environment.NewLine
                    str &= "           ,'" & dtFormatRunno.Rows(i).Item("PREFIX").ToString.TrimEnd & "' " & Environment.NewLine
                    str &= "           ,'" & dtFormatRunno.Rows(i).Item("RUNNO").ToString.TrimEnd & "' " & Environment.NewLine
                    str &= "           ,'" & MAIN.txtDBSOURCE.Text.TrimEnd & "'" & Environment.NewLine
                    str &= "           ,'" & MAIN.txtDBSOURCE.Text.TrimEnd & "'" & Environment.NewLine
                    str &= "           ,'" & dtFormatRunno.Rows(i).Item("RCPTYPE").ToString.TrimEnd & "' " & Environment.NewLine
                    str &= "            ) " & Environment.NewLine


                Next
                Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
                cmd1.ExecuteNonQuery()

            End If
            connect.Close()

        Catch ex As Exception
            WriteLog("Error 1166 INSERTFMSMASTERRUNING():" & ex.Message & STREXIST & " ; " & str)
        End Try
    End Sub

    Public Shared Sub INSERTFMSMASTEROPTFD(ByVal dtOPTFD As DataTable)
        Dim STREXIST As String = ""
        Dim str As String = ""
        Call DATACLASS.CREATEFMSMASTEROPTFD("INSERT")
        Try
            Connection.Openconnect("BILL", connect)
            'check Exist\
            If dtOPTFD.Rows.Count > 0 Then

                For i = 0 To dtOPTFD.Rows.Count - 1

                    str = "INSERT INTO [dbo].[FMSMASTEROPTFD] " & Environment.NewLine
                    str &= "           ([OPTFDID] " & Environment.NewLine
                    str &= "           ,[OPTFDNAME] " & Environment.NewLine
                    str &= "           ,[ACTIVE] " & Environment.NewLine
                    str &= "           ,[AUDTORG]" & Environment.NewLine
                    str &= "           ) " & Environment.NewLine
                    str &= "     VALUES " & Environment.NewLine
                    str &= "           ('" & dtOPTFD.Rows(i).Item("OPTFDID").ToString.TrimEnd & "' " & Environment.NewLine
                    str &= "           ,'" & dtOPTFD.Rows(i).Item("OPTFDNAME").ToString.TrimEnd & "' " & Environment.NewLine
                    str &= "           ,'" & dtOPTFD.Rows(i).Item("ACTIVE").ToString.TrimEnd & "' " & Environment.NewLine
                    str &= "           ,'" & MAIN.txtDBSOURCE.Text & "' " & Environment.NewLine
                    str &= "            ) " & Environment.NewLine

                    Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
                    cmd1.ExecuteNonQuery()
                Next
            End If
            connect.Close()
            MessageBox.Show("Save Success")
        Catch ex As Exception
            WriteLog("Error 1420 INSERTFMSMASTEROPTFD() :" & ex.Message & STREXIST & " ; " & str)
            MessageBox.Show("Save failed")
        End Try
    End Sub

    Public Shared Sub INSERTFMSARCUSMASTER()
        Dim STREXIST As String = ""
        Dim str As String = ""
        Dim DBSource As String = MAIN.txtDBSOURCE.Text.TrimEnd
        Try
            Connection.Openconnect("BILL", connect)
            'check Exist\
            Dim dtchkTemp As DataTable = New DataTable()

            STREXIST = "SELECT name FROM sys.tables WHERE name = 'FMSARCUSMASTER'"
            Dim cmdquery As SqlDataAdapter = New SqlDataAdapter(STREXIST, connect)
            cmdquery.Fill(dtchkTemp)

            'create table 
            If dtchkTemp.Rows.Count <> 0 Then
                str = "DELETE FROM FMSARCUSMASTER WHERE AUDTORG = '" & MAIN.txtDBSOURCE.Text & "'" & Environment.NewLine
                str &= "INSERT INTO FMSARCUSMASTER SELECT DISTINCT * FROM " & DBSource & ".dbo.ARCUS"
                Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
                cmd1.ExecuteNonQuery()
            End If
            connect.Close()

        Catch ex As Exception
            WriteLog("Error 1228 INSERTFMSARCUSMASTER() :" & ex.Message & STREXIST & " ; " & str)
        End Try
    End Sub

    Public Shared Sub INSERTFMSARRTAMASTER()
        Dim STREXIST As String = ""
        Dim str As String = ""
        Dim DBSource As String = MAIN.txtDBSOURCE.Text.TrimEnd
        Try
            Connection.Openconnect("BILL", connect)
            'check Exist\
            Dim dtchkTemp As DataTable = New DataTable()

            STREXIST = "SELECT name FROM sys.tables WHERE name = 'FMSARRTAMASTER'"
            Dim cmdquery As SqlDataAdapter = New SqlDataAdapter(STREXIST, connect)
            cmdquery.Fill(dtchkTemp)

            'create table 
            If dtchkTemp.Rows.Count <> 0 Then
                str = "DELETE FROM FMSARRTAMASTER WHERE AUDTORG = '" & MAIN.txtDBSOURCE.Text & "' " & Environment.NewLine
                str &= "INSERT INTO FMSARRTAMASTER SELECT * FROM " & DBSource & ".dbo.ARRTA"
                Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
                cmd1.ExecuteNonQuery()
            End If
            connect.Close()

        Catch ex As Exception
            WriteLog("Error 1255 INSERTFMSARRTAMASTER() :" & ex.Message & STREXIST & " ; " & str)
        End Try
    End Sub

    Public Shared Sub INSERTFMSCSCOMMASTER()
        Dim STREXIST As String = ""
        Dim str As String = ""
        Dim DBSource As String = MAIN.txtDBSOURCE.Text.TrimEnd
        Try
            Connection.Openconnect("BILL", connect)
            'check Exist\
            Dim dtchkTemp As DataTable = New DataTable()

            STREXIST &= "SELECT name FROM sys.tables WHERE name = 'FMSCSCOMMASTER'"
            Dim cmdquery As SqlDataAdapter = New SqlDataAdapter(STREXIST, connect)
            cmdquery.Fill(dtchkTemp)

            'create table 
            If dtchkTemp.Rows.Count <> 0 Then
                str = "DELETE FROM FMSCSCOMMASTER WHERE AUDTORG = '" & MAIN.txtDBSOURCE.Text & "' " & Environment.NewLine
                str &= "INSERT INTO FMSCSCOMMASTER SELECT ORGID,	AUDTDATE,	AUDTTIME,	AUDTUSER,	AUDTORG,	CONAME,	ADDR01,	ADDR02,	ADDR03,	ADDR04,	CITY,	STATE,	POSTAL,	COUNTRY,	LOCTYPE,	LOCCODE,	PHONEFMT,	PHONE,	FAX,	CONTACT,	CNTRYCODE,	BRANCH,	PERDFSC,	QTR4PERD,	HOMECUR,	MULTICURSW,	RATETYPE,	WARNDAYS,	EUROCURSW,	REPORTCUR,	HNDLCKFSC,	HNDINAACCT,	HNDNEXACCT,	GNLSSMTHD,	TAXNBR,	" & Environment.NewLine
                str &= "LEGALNAME,	BRN,	EMAILHOST,	EMAILUSER,	EMAILPSWD,	EMAILPORT,	EMAILSSL,	EMAILADDR,	USESMTP,	CCADDR,	BCCADDR " & Environment.NewLine
                str &= "FROM " & DBSource & ".dbo.CSCOM"
                Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
                cmd1.ExecuteNonQuery()
            End If
            connect.Close()

        Catch ex As Exception
            WriteLog("Error 1285 INSERTFMSCSCOMMASTER() :" & ex.Message & STREXIST & " ; " & str)
        End Try
    End Sub

#End Region

#End Region

#Region "UPDATE"

#Region "BILLING"
    Public Shared Sub UPDATEFMSBILLDETAIL_AMTOUTSTAND(ByVal DTBILLDETAIL As DataTable)
        Dim STREXIST As String = ""
        Dim str As String = ""
        Try
            Connection.Openconnect("BILL", connect)

            For I = 0 To DTBILLDETAIL.Rows.Count - 1
                Dim INVNO As String = DTBILLDETAIL.Rows(I).Item("INVNO").ToString
                Dim AMTOUTSTAND As String = DTBILLDETAIL.Rows(I).Item("AMTOUTSTAND").ToString

                str = "UPDATE FMSBILLDETAIL SET AMTOUTSTAND = '" & AMTOUTSTAND & "' WHERE INVNO =  '" & INVNO & "' " & vbCrLf

                Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
                cmd1.ExecuteNonQuery()
            Next
            connect.Close()

        Catch ex As Exception
            WriteLog("Error 1312 UPDATEFMSBILLDETAIL_AMTOUTSTAND() :" & ex.Message & STREXIST & " ; " & str)
        End Try
    End Sub

#Region "POST BILL"
    Public Shared Sub UPDATEFMSBILLHEAD_POST(ByVal BILLNO As String)
        Dim STREXIST As String = ""
        Dim str As String = ""
        Try
            Connection.Openconnect("BILL", connect)
            str = "UPDATE FMSBILLHEAD SET STA_0 = 2 WHERE BILLNO =  '" & BILLNO & "' AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "'" & vbCrLf
            str &= "UPDATE FMSBILLDETAIL SET STA_0 = 2 WHERE BILLNO =  '" & BILLNO & "' AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "'"

            Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
            cmd1.ExecuteNonQuery()

            connect.Close()

        Catch ex As Exception
            WriteLog("Error 1332 UPDATEFMSBILLHEAD_POST() :" & ex.Message & STREXIST & " ; " & str)
        End Try
    End Sub

#End Region

#Region "Reverse"
    Public Shared Function UPDATEFMSBILLDETAIL_REVERSE(ByVal BILLNO As String, ByVal INVNO As String, ByVal IDCUST As String) As Boolean
        Dim STREXIST As String = ""
        Dim str As String = ""
        Dim Bool As Boolean = True
        Try
            Connection.Openconnect("BILL", connect)
            '4 = REVERSE
            'str = "UPDATE  FMSBILLDETAIL SET STA_0 = 4 , AMTOUTSTAND = NETAMT WHERE  BILLNO = '" & BILLNO & "' and INVNO = '" & INVNO & "' " & Environment.NewLine
            'str = "UPDATE  FMSBILLDETAIL SET STA_0 = 4  WHERE  BILLNO = '" & BILLNO & "' and INVNO = '" & INVNO & "' AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "'" & Environment.NewLine
            str = "UPDATE  FMSBILLDETAIL SET STA_0 = 4, AMTOUTSTAND = LINEAMOUNT WHERE  BILLNO = '" & BILLNO & "' AND IDCUST = '" & IDCUST & "' AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "'" & Environment.NewLine

            str &= "UPDATE FMSBILLHEAD SET STA_0 = 4   WHERE  BILLNO = '" & BILLNO & "' AND IDCUST = '" & IDCUST & "' AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "' "
            Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
            cmd1.ExecuteNonQuery()
            connect.Close()

        Catch ex As Exception
            WriteLog("Error 1353 UPDATEFMSBILLDETAIL_REVERSE() :" & ex.Message & STREXIST & " ; " & str)
            Bool = False
        End Try
        Return Bool
    End Function


#End Region

#End Region

#Region "RCP"
    Public Shared Sub UPDATEFMSRCPDETAIL_AMTOUTSTAND(ByVal DTRCPDETAIL As DataTable)
        Dim STREXIST As String = ""
        Dim str As String = ""
        Try
            Connection.Openconnect("BILL", connect)

            For I = 0 To DTRCPDETAIL.Rows.Count - 1
                Dim INVNO As String = DTRCPDETAIL.Rows(I).Item("INVNO").ToString
                Dim AMTOUTSTAND As String = DTRCPDETAIL.Rows(I).Item("AMTOUTSTAND").ToString

                str = "UPDATE FMSRCPDETAIL SET AMTOUTSTAND = '" & AMTOUTSTAND & "' WHERE INVNO =  '" & INVNO & "' AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "' " & vbCrLf

                Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
                cmd1.ExecuteNonQuery()
            Next
            connect.Close()

        Catch ex As Exception
            WriteLog("Error 1170:" & ex.Message & STREXIST & " ; " & str)
        End Try
    End Sub

#Region "POST RCP"
    Public Shared Sub UPDATEFMSRCPHEAD_POST(ByVal RCPNO As String)
        Dim STREXIST As String = ""
        Dim str As String = ""
        Try
            Connection.Openconnect("BILL", connect)
            str = "UPDATE FMSRCPHEAD SET STA_0 = 2 WHERE RCPNO =  '" & RCPNO & "' AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "' " & vbCrLf
            str &= "UPDATE FMSRCPDETAIL SET STA_0 = 2 WHERE RCPNO =  '" & RCPNO & "' AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "'"
            Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
            cmd1.ExecuteNonQuery()

            connect.Close()

        Catch ex As Exception
            WriteLog("Error 1188:" & ex.Message & STREXIST & " ; " & str)
        End Try
    End Sub

#End Region

    Public Shared Function UPDATEFMSRCPHEAD_REV(ByVal RCPNO As String) As Boolean
        Dim bool As Boolean = True
        Dim STREXIST As String = ""
        Dim str As String = ""
        Try
            Connection.Openconnect("BILL", connect)
            str = "UPDATE FMSRCPHEAD SET STA_0 = 4 WHERE RCPNO =  '" & RCPNO & "' AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "' " & vbCrLf
            str &= "UPDATE FMSRCPDETAIL SET STA_0 = 4 WHERE RCPNO =  '" & RCPNO & "' AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "'"
            str &= "UPDATE FMSRCPDETAIL SET AMTOUTSTAND = NETAMT WHERE RCPNO = '" & RCPNO & "' AND STA_0 <> 2 AND AMTOUTSTAND = 0 AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "' "
            'str &= "UPDATE FMSRCPDETAIL SET AMTOUTSTAND = AMTOUTSTAND + RCPAMT , NETAMT = AMTOUTSTAND + RCPAMT WHERE RCPNO = '" & RCPNO & "' AND STA_0 <> 2 AND AMTOUTSTAND <> 0"
            str &= "UPDATE FMSRCPDETAIL SET AMTOUTSTAND = RCPAMT , NETAMT = RCPAMT WHERE RCPNO = '" & RCPNO & "' AND STA_0 <> 2 AND AMTOUTSTAND <> 0 AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "'"
            Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
            cmd1.ExecuteNonQuery()

            connect.Close()

        Catch ex As Exception
            WriteLog("Error 1210 :" & ex.Message & STREXIST & " ; " & str)
            bool = False
        End Try
        Return bool
    End Function


#End Region

#Region "IMPORT CB"
    Public Shared Sub UPDATEFMSRCPHEAD_IMPORTCB(ByVal RCPNO As String)
        Dim STREXIST As String = ""
        Dim str As String = ""
        Try
            Connection.Openconnect("BILL", connect)


            str = "UPDATE FMSRCPHEAD SET IMPORTCB = 'Y' WHERE RCPNO =  '" & RCPNO & "' AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "' " & vbCrLf

            Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
            cmd1.ExecuteNonQuery()

            connect.Close()

        Catch ex As Exception
            WriteLog("Error 1444 UPDATEFMSRCPHEAD_IMPORTCB() :" & ex.Message & STREXIST & " ; " & str)
        End Try
    End Sub

    Public Shared Sub UPDATEFMSRCPHEAD_BANKBATCH(ByVal RCPNO As String, ByVal BANKBATCH As String)
        Dim STREXIST As String = ""
        Dim str As String = ""
        Try
            Connection.Openconnect("BILL", connect)


            str = "UPDATE FMSRCPHEAD SET BANKBATCH = '" & BANKBATCH & "' WHERE RCPNO =  '" & RCPNO & "' AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "' " & vbCrLf

            Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
            cmd1.ExecuteNonQuery()

            connect.Close()

        Catch ex As Exception
            WriteLog("Error 1690 UPDATEFMSRCPHEAD_IMPORTCB() :" & ex.Message & STREXIST & " ; " & str)
        End Try
    End Sub

    Public Shared Sub UPDATEFMSRCPHEAD_CBBATCH()
        Dim str As String = ""
        Try
            Connection.Openconnect("BILL", connect)
            str = "MERGE FMSRCPHEAD AS A
USING SAM69L.dbo.CBBTHD B ON A.RCPNO = B.REFERENCE
WHEN MATCHED  THEN 
UPDATE SET A.CBBATCH = B.BATCHID + '-' + B.ENTRYNO;
"

            Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
            cmd1.ExecuteNonQuery()

            connect.Close()
        Catch ex As Exception
            WriteLog("Error 1710 UPDATEFMSRCPHEAD_CBBATCH() :" & ex.Message & " ; " & str)
        End Try
    End Sub

#End Region

#Region "MASTER"
    Public Shared Sub UPDATEFMSMASTERRUNING(ByVal vDoctype As String, ByVal RUNNO As String)
        Dim STREXIST As String = ""
        Dim str As String = ""
        Try
            Connection.Openconnect("BILL", connect)
            str = "UPDATE FMSMASTERRUNING SET RUNNO = '" & RUNNO & "' WHERE DOCTYPE =  '" & vDoctype & "' "
            str &= "AND COMP = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "'"

            Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
            cmd1.ExecuteNonQuery()

            connect.Close()

        Catch ex As Exception
            WriteLog("Error 1730 UPDATEFMSMASTERRUNING():" & ex.Message & STREXIST & " ; " & str)
        End Try
    End Sub

#End Region

#End Region

#Region "Delete"

#Region "BILL"
    Public Shared Sub DELETEFMSBILLHEAD(ByVal BILLNO As String)
        Dim STREXIST As String = ""
        Dim str As String = ""
        Try
            Connection.Openconnect("BILL", connect)
            str = "UPDATE FMSBILLHEAD SET STA_0 = 5 WHERE BILLNO =  '" & BILLNO & "' AND STA_0 <> 2  AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "'"
            str &= "UPDATE FMSBILLDETAIL SET STA_0 = 5 WHERE BILLNO =  '" & BILLNO & "' AND STA_0 <> 2 AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "'" & Environment.NewLine
            str &= "UPDATE FMSBILLDETAIL SET AMTOUTSTAND = NETAMT WHERE BILLNO = '" & BILLNO & "' AND STA_0 <> 2 AND AMTOUTSTAND = 0  AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "'"
            str &= "UPDATE FMSBILLDETAIL SET AMTOUTSTAND = LINEAMOUNT , NETAMT = LINEAMOUNT WHERE BILLNO = '" & BILLNO & "' AND STA_0 <> 2 AND AMTOUTSTAND <> 0 AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "'"
            Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
            cmd1.ExecuteNonQuery()

            connect.Close()

        Catch ex As Exception
            WriteLog("Error 1758 DELETEFMSBILLHEAD() :" & ex.Message & STREXIST & " ; " & str)
        End Try
    End Sub

    Public Shared Sub DELETEFMSBILLDETAILREV(ByVal INVNO As String)
        Dim STREXIST As String = ""
        Dim str As String = ""
        Try
            Connection.Openconnect("BILL", connect)
            str = "DELETE FROM FMSBILLDETAILREV WHERE INVNO = '" & INVNO & "' AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "'" & Environment.NewLine
            Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
            cmd1.ExecuteNonQuery()

            connect.Close()

        Catch ex As Exception
            WriteLog("Error 1775 DELETEFMSBILLDETAILREV() :" & ex.Message & STREXIST & " ; " & str)
        End Try
    End Sub
    Public Shared Sub DELETEFMSBILL(ByVal BILLNO As String)
        Dim STREXIST As String = ""
        Dim str As String = ""
        Try
            Connection.Openconnect("BILL", connect)
            str = "DELETE FROM FMSBILLHEAD WHERE BILLNO = '" & BILLNO & "' AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "'" & Environment.NewLine
            str &= "DELETE FROM FMSBILLDETAIL WHERE BILLNO = '" & BILLNO & "' AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "'" & Environment.NewLine
            Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
            cmd1.ExecuteNonQuery()

            connect.Close()

        Catch ex As Exception
            WriteLog("Error 1507 DELETEFMSBILL() :" & ex.Message & STREXIST & " ; " & str)
        End Try
    End Sub
#End Region

#Region "RCP"
    Public Shared Sub DELETEFMSRCPHEAD(ByVal RCPNO As String)
        Dim STREXIST As String = ""
        Dim str As String = ""
        Try
            Connection.Openconnect("BILL", connect)
            str = "UPDATE FMSRCPHEAD SET STA_0 = 5 WHERE RCPNO =  '" & RCPNO & "' AND STA_0 <> 2  AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "'"
            str &= "UPDATE FMSRCPDETAIL SET STA_0 = 5 WHERE RCPNO =  '" & RCPNO & "' AND STA_0 <> 2 AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "'" & Environment.NewLine
            str &= "UPDATE FMSRCPDETAIL SET AMTOUTSTAND = NETAMT WHERE RCPNO = '" & RCPNO & "' AND STA_0 <> 2 AND AMTOUTSTAND = 0  AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "'"
            str &= "UPDATE FMSRCPDETAIL SET AMTOUTSTAND = AMT , NETAMT = AMT WHERE RCPNO = '" & RCPNO & "' AND STA_0 <> 2 AND AMTOUTSTAND <> 0 AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "'"
            Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
            cmd1.ExecuteNonQuery()
            WriteLog(str)
            connect.Close()

        Catch ex As Exception
            WriteLog("Error 1528  DELETEFMSRCPHEAD() :" & ex.Message & STREXIST & " ; " & str)
        End Try
    End Sub

    Public Shared Sub DELETEFMSRCPHEAD_REVISE(ByVal RCPNO As String)
        Dim STREXIST As String = ""
        Dim str As String = ""
        Try
            Connection.Openconnect("BILL", connect)
            str = "UPDATE FMSRCPHEAD SET STA_0 = 5 WHERE RCPNO =  '" & RCPNO & "' AND STA_0 <> 2  AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "'"
            str &= "UPDATE FMSRCPDETAIL SET STA_0 = 5 WHERE RCPNO =  '" & RCPNO & "' AND STA_0 <> 2 AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "'" & Environment.NewLine
            str &= "UPDATE T2 SET T2.AMTOUTSTAND = T1.RCPAMT FROM 
                    (SELECT * FROM FMSRCPDETAIL WHERE RCPNO = '" & RCPNO & "') AS T1
                    LEFT OUTER JOIN FMSRCPDETAIL AS T2 ON T1.INVNO = T2.INVNO" & Environment.NewLine
            'str &= "UPDATE FMSRCPDETAIL SET AMTOUTSTAND = NETAMT WHERE RCPNO = '" & RCPNO & "' AND STA_0 <> 2 AND AMTOUTSTAND = 0  AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "'"
            'str &= "UPDATE FMSRCPDETAIL SET AMTOUTSTAND = AMT , NETAMT = AMT WHERE RCPNO = '" & RCPNO & "' AND STA_0 <> 2 AND AMTOUTSTAND <> 0 AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "'"
            Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
            cmd1.ExecuteNonQuery()
            WriteLog(str)
            connect.Close()

        Catch ex As Exception
            WriteLog("Error 1528  DELETEFMSRCPHEAD() :" & ex.Message & STREXIST & " ; " & str)
        End Try
    End Sub

#End Region

#End Region

End Class
