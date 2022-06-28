Imports System.Data.SqlClient
Public Class MASTER

#Region "MASTER"
    Public Shared Function GETDATA_RUNNO() As DataTable

        Connection.Openconnect("BILL", connect)
        Dim sql1 As String = ""
        Dim dataSt = New DataSet()
        Try
            sql1 = "SELECT * " & vbCrLf
            sql1 &= "FROM FMSMASTERRUNING" & vbCrLf
            sql1 &= "WHERE COMP = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "'"
            Command = New SqlCommand(sql1, connect)
            adapter = New SqlDataAdapter(Command)
            adapter.Fill(dataSt, "Data")
        Catch ex As Exception
            WriteLog("Error 20 (GETDATA_RUNNO) :" & ex.Message & sql1)
        End Try
        connect.Close()
        Return dataSt.Tables("Data")

    End Function

    Public Shared Function GET_RUNNING(ByVal Doctype As String) As String
        Dim DOCRUNNO As String = ""
        Call DATACLASS.CREATEFMSMASTERRUNNING()
        Connection.Openconnect("BILL", connect)
        Dim sql1 As String
        Dim vDoctype As String
        Select Case Doctype
            Case "Bill"
                vDoctype = "Billing Note"
            Case "Receipt"
                vDoctype = "Receipt"
            Case "TaxReceipt"
                vDoctype = "Tax Receipt"
            Case Else
                vDoctype = ""
        End Select
        sql1 = "SELECT RUNNO AS VALUE FROM FMSMASTERRUNING WHERE DOCTYPE =  '" & vDoctype & "' " & Environment.NewLine
        sql1 &= " AND COMP = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "' " & Environment.NewLine
        Dim cmd As SqlCommand = New SqlCommand(sql1, connect)
        Dim result As SqlDataReader = cmd.ExecuteReader()

        While result.Read()
            DOCRUNNO = result("VALUE").ToString.TrimEnd

        End While

        Return DOCRUNNO
    End Function

    Public Shared Function GET_PREFIX(ByVal Doctype As String) As String
        Dim DOCRUNNO As String = ""
        Call DATACLASS.CREATEFMSMASTERRUNNING()
        Connection.Openconnect("BILL", connect)
        Dim sql1 As String
        Dim vDoctype As String
        Select Case Doctype
            Case "Bill"
                vDoctype = "Billing Note"
            Case "Receipt"
                vDoctype = "Receipt"
            Case "TaxReceipt"
                vDoctype = "Tax Receipt"
            Case Else
                vDoctype = ""
        End Select
        sql1 = "SELECT PREFIX AS VALUE FROM FMSMASTERRUNING WHERE DOCTYPE =  '" & vDoctype & "' "
        sql1 &= "AND COMP = '" & MAIN.txtDBSOURCE.Text.TrimEnd.TrimEnd & "'"

        Dim cmd As SqlCommand = New SqlCommand(sql1, connect)
        Dim result As SqlDataReader = cmd.ExecuteReader()

        While result.Read()
            DOCRUNNO = result("VALUE").ToString.TrimEnd
        End While
        connect.Close()
        Return DOCRUNNO
    End Function

    Public Shared Function GET_FORMAT(ByVal Doctype As String) As Decimal
        Dim DOCRUNNO As Decimal
        Call DATACLASS.CREATEFMSMASTERRUNNING()
        Connection.Openconnect("BILL", connect)
        Dim sql1 As String
        Dim vDoctype As String
        Select Case Doctype
            Case "Bill"
                vDoctype = "Billing Note"
            Case "Receipt"
                vDoctype = "Receipt"
            Case "TaxReceipt"
                vDoctype = "Tax Receipt"
            Case Else
                vDoctype = ""
        End Select
        sql1 = "SELECT [LENGTH] AS VALUE FROM FMSMASTERRUNING WHERE DOCTYPE =  '" & vDoctype & "' "
        sql1 &= "AND COMP = '" & MAIN.txtDBSOURCE.Text.TrimEnd.TrimEnd & "'"

        Dim cmd As SqlCommand = New SqlCommand(sql1, connect)
        Dim result As SqlDataReader = cmd.ExecuteReader()

        While result.Read()
            DOCRUNNO = result("VALUE").ToString.TrimEnd
        End While
        connect.Close()
        Return DOCRUNNO
    End Function

    Public Shared Function GET_SEQ(ByVal DocTYPE As String) As String
        Dim SEQ As String = ""
        Connection.Openconnect("BILL", connect)
        Dim sql1 As String
        Select Case DocTYPE
            Case "BILLHEAD"
                sql1 = "SELECT MAX(BILLSEQ) AS VALUE FROM FMSBILLHEAD" & Environment.NewLine
                sql1 &= " WHERE AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "' " & Environment.NewLine
            Case "RCPHEAD"
                sql1 = "SELECT MAX(RCPSEQ) AS VALUE FROM FMSRCPHEAD" & Environment.NewLine
                sql1 &= " WHERE AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "' " & Environment.NewLine
            Case Else
                sql1 = ""
        End Select


        Dim cmd As SqlCommand = New SqlCommand(sql1, connect)
        Dim result As SqlDataReader = cmd.ExecuteReader()

        While result.Read()
            SEQ = result("VALUE").ToString.TrimEnd
            If SEQ = "" Or IsDBNull(SEQ) = True Then
                SEQ = DateTime.Now.Year & Format(1, "00000")
            Else
                SEQ = SEQ + 1
            End If
        End While
        connect.Close()
        Return SEQ
    End Function

    Public Shared Function GETDATA_OPTFD(Optional ByVal CONDITION As String = Nothing) As DataTable
        Call DATACLASS.CREATEFMSMASTEROPTFD()
        Connection.Openconnect("BILL", connect)
        Dim sql1 As String = ""
        Dim dataSt = New DataSet()
        Try
            sql1 = "SELECT * " & vbCrLf
            sql1 &= "FROM FMSMASTEROPTFD" & vbCrLf

            If CONDITION = Nothing Then
                sql1 &= " WHERE AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "' " & Environment.NewLine
            Else
                sql1 &= CONDITION
                sql1 &= " AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "' " & Environment.NewLine
            End If

            Command = New SqlCommand(sql1, connect)
            adapter = New SqlDataAdapter(Command)
            adapter.Fill(dataSt, "Data")
        Catch ex As Exception
            WriteLog("Error 120 (GETDATA_OPTFD) :" & ex.Message & sql1)
        End Try
        connect.Close()
        Return dataSt.Tables("Data")

    End Function

    Public Shared Function GET_IDCUST(ByVal IDCUST As String) As String
        Dim vIDCUST As String = ""
        Connection.Openconnect("Source", connect)
        Dim sql1 As String

        sql1 = "SELECT NAMECUST AS NAMECUST FROM ARCUS WHERE IDCUST = '" & IDCUST & "' " & Environment.NewLine
        sql1 &= " AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "' " & Environment.NewLine
        Dim cmd As SqlCommand = New SqlCommand(sql1, connect)
        Dim result As SqlDataReader = cmd.ExecuteReader()

        While result.Read()
            vIDCUST = result("NAMECUST").ToString.TrimEnd
            If vIDCUST = "" Or IsDBNull(vIDCUST) = True Then
                vIDCUST = ""
            Else
                vIDCUST = vIDCUST
            End If
        End While
        connect.Close()
        Return vIDCUST
    End Function

    Public Shared Function GET_CNTINV(ByVal BILLNO As String) As Decimal
        Dim vVALUE As Decimal
        Connection.Openconnect("BILL", connect)
        Dim sql1 As String

        sql1 = "SELECT COUNT(BILLNO) AS VALUE FROM FMSBILLDETAIL WHERE BILLNO = '" & BILLNO & "' "
        sql1 &= " AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "' " & Environment.NewLine

        Dim cmd As SqlCommand = New SqlCommand(sql1, connect)
        Dim result As SqlDataReader = cmd.ExecuteReader()

        While result.Read()
            vVALUE = result("VALUE")
            If IsDBNull(vVALUE) = True Then
                vVALUE = 0
            Else
                vVALUE = vVALUE
            End If
        End While
        connect.Close()
        Return vVALUE
    End Function

    Public Shared Function GET_CNTINVRCP(ByVal RCPNO As String) As Decimal
        Dim vVALUE As Decimal
        Connection.Openconnect("BILL", connect)
        Dim sql1 As String

        sql1 = "SELECT COUNT(RCPNO) AS VALUE FROM FMSRCPDETAIL WHERE RCPNO = '" & RCPNO & "' " & Environment.NewLine
        sql1 &= " AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "' " & Environment.NewLine

        Dim cmd As SqlCommand = New SqlCommand(sql1, connect)
        Dim result As SqlDataReader = cmd.ExecuteReader()

        While result.Read()
            vVALUE = result("VALUE")
            If IsDBNull(vVALUE) = True Then
                vVALUE = 0
            Else
                vVALUE = vVALUE
            End If
        End While
        connect.Close()
        Return vVALUE
    End Function

    Public Shared Function GETDATABASE(ByVal SERVER As String, ByVal USER As String, ByVal PASS As String) As DataTable
        Dim sql1 As String = ""
        Dim dataSt = New DataSet()

        Try
            Dim strcon As String = "Data Source= " & SERVER & "  ;Initial Catalog= master  ;User ID=" & USER & " ;Password= " & PASS & ";Connect Timeout=0 "

            Dim connect = New SqlConnection(strcon)

            If connect.State = ConnectionState.Closed Then

                connect.Open()
            Else
            End If

            sql1 = "select name from sys.databases"
            Command = New SqlCommand(sql1, connect)
            adapter = New SqlDataAdapter(Command)
            adapter.Fill(dataSt, "Data")
            connect.Close()
        Catch ex As Exception
            WriteLog("Error 230 (GETDATABASE) :" & ex.Message & sql1)
        End Try

        Return dataSt.Tables("Data")

    End Function

    Public Shared Function GET_COMPNAME(ByVal ORGID As String) As String
        Dim vIDCUST As String = ""
        Connection.Openconnect("BILL", connect)
        Dim sql1 As String

        sql1 = "SELECT * FROM FMSCSCOMMASTER WHERE ORGID = '" & ORGID & "' " & Environment.NewLine
        sql1 &= " AND AUDTORG = '" & ORGID & "' " & Environment.NewLine
        Dim cmd As SqlCommand = New SqlCommand(sql1, connect)
        Dim result As SqlDataReader = cmd.ExecuteReader()

        While result.Read()
            vIDCUST = result("CONAME").ToString.TrimEnd
            If vIDCUST = "" Or IsDBNull(vIDCUST) = True Then
                vIDCUST = ""
            Else
                vIDCUST = vIDCUST
            End If
        End While
        connect.Close()
        Return vIDCUST
    End Function

    Public Shared Function GET_ORGID(ByVal CONAME As String) As String
        Dim vIDCUST As String = ""
        Connection.Openconnect("BILL", connect)
        Dim sql1 As String

        sql1 = "SELECT * FROM FMSCSCOMMASTER WHERE CONAME LIKE '" & CONAME & "' " & Environment.NewLine
        'sql1 &= " AND AUDTORG = '" & ORGID & "' " & Environment.NewLine
        Dim cmd As SqlCommand = New SqlCommand(sql1, connect)
        Dim result As SqlDataReader = cmd.ExecuteReader()

        While result.Read()
            vIDCUST = result("ORGID").ToString.TrimEnd
            If vIDCUST = "" Or IsDBNull(vIDCUST) = True Then
                vIDCUST = ""
            Else
                vIDCUST = vIDCUST
            End If
        End While
        connect.Close()
        Return vIDCUST
    End Function



#End Region

#Region "BILLING"

    Public Shared Function GETDATA_BATCHBILL(ByVal ShowSTA_0 As String, Optional ByVal BILLNO As String = "") As DataTable
        Connection.Openconnect("BILL", connect)
        Dim sql1 As String = ""
        Dim dataSt = New DataSet()
        Try

            sql1 = "SELECT DISTINCT " & vbCrLf
            sql1 &= "BILLNO AS BILLNO " & vbCrLf
            sql1 &= ",IDCUST AS IDCUST " & vbCrLf
            sql1 &= ",'' AS CUSTNAME" & vbCrLf
            sql1 &= ",SUBSTRING(CAST(INVDATE AS CHAR),7,2) + '/' + SUBSTRING(CAST(INVDATE AS CHAR),5,2) + '/' + SUBSTRING(CAST(INVDATE AS CHAR),1,4) AS BILLDOCDATE " & vbCrLf
            sql1 &= ",SUBSTRING(CAST(DUEDATE AS CHAR),7,2) + '/' + SUBSTRING(CAST(DUEDATE AS CHAR),5,2) + '/' + SUBSTRING(CAST(DUEDATE AS CHAR),1,4) AS DUEDATE" & vbCrLf
            sql1 &= ",NETAMT AS AMOUNT" & vbCrLf
            sql1 &= ",CASE WHEN STA_0 = 1 THEN 'Open' ELSE CASE WHEN STA_0 = 2 THEN 'Posted' ELSE CASE WHEN STA_0 = 3 THEN 'RECEIPT' ELSE CASE WHEN STA_0 = 4 THEN 'Reverse' ELSE 'Delete'  END END END END  AS STATUS" & vbCrLf
            sql1 &= ",'' AS CNTINV" & vbCrLf

            sql1 &= "FROM FMSBILLHEAD" & vbCrLf

            If ShowSTA_0 = "False" Then
                sql1 &= "WHERE STA_0 = '1' "
                sql1 &= " AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "' " & Environment.NewLine
            Else
                sql1 &= " WHERE AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "' " & Environment.NewLine
            End If

            If BILLNO <> "" Then
                sql1 &= "AND BILLNO = '" & BILLNO & "'"
            End If

            Command = New SqlCommand(sql1, connect)
            adapter = New SqlDataAdapter(Command)
            adapter.Fill(dataSt, "Data")

        Catch ex As Exception
            WriteLog("Error 277 (GETDATA_BATCHBILL) :" & ex.Message & sql1)
        End Try
        connect.Close()
        Return dataSt.Tables("Data")

    End Function

    Public Shared Function BK_GETDATA_SOURCEBILLDETAIL(ByVal IDCUST As String, ByVal DATEF As String, ByVal DATET As String, Optional ByVal ShowPostCon As String = Nothing) As DataTable
        Connection.Openconnect("Source", connect)
        Dim sql1 As String = ""
        Dim dataSt = New DataSet()
        Dim DBBILL = MAIN.txtDBBILL.Text.TrimEnd
        Try

            sql1 = "SELECT" & Environment.NewLine
            sql1 &= "AROBL.IDCUST AS IDCUST --AROBL.IDCUST" & Environment.NewLine
            sql1 &= ",AROBL.IDINVC AS INVNO -- AROBL.IDINVC " & Environment.NewLine
            sql1 &= ",SUBSTRING(CAST(ARIBH.DATEINVC AS CHAR),7,2) + '/' + SUBSTRING(CAST(ARIBH.DATEINVC AS CHAR),5,2) + '/' + SUBSTRING(CAST(ARIBH.DATEINVC AS CHAR),1,4) AS INVDATE --> ARIBH.DATEINVC " & Environment.NewLine
            sql1 &= ",SUBSTRING(CAST(ARIBH.DATEDUE AS CHAR),7,2) + '/' + SUBSTRING(CAST(ARIBH.DATEDUE AS CHAR),5,2) + '/' + SUBSTRING(CAST(ARIBH.DATEDUE AS CHAR),1,4)  AS DUEDATE --> ARIBH.DATEDUE " & Environment.NewLine
            sql1 &= ",AROBL.IDCUSTPO AS PONUM -->AROBL.IDCUSTPO " & Environment.NewLine

            sql1 &= ",AROBL.AMTDUETC AS LINEAMOUNT --> AROBL.AMTDUETC - Sum(FMSBILLDETAIL.LINEAMOUNT) " & Environment.NewLine

            'sql1 &= ",ISNULL(" & DBBILL & ".dbo.FMSBILLDETAIL.AMTOUTSTAND,AROBL.AMTDUETC) AS AMTOUTSTAND " & Environment.NewLine

            'sql1 &= ",CASE WHEN FMSBILLDETAIL.LINEAMOUNT IS NULL THEN AROBL.AMTDUETC " & Environment.NewLine
            'sql1 &= "	ELSE CASE WHEN  (FMSBILLDETAIL.LINEAMOUNT - ISNULL((SELECT SUM(FMSBILLDETAIL.NETAMT) AS VALUE FROM " & DBBILL & ".dbo.FMSBILLDETAIL WHERE FMSBILLDETAIL.INVNO = AROBL.IDINVC),0)) = 0 THEN AROBL.AMTDUETC " & Environment.NewLine
            'sql1 &= "		ELSE (FMSBILLDETAIL.LINEAMOUNT - ISNULL((SELECT SUM(FMSBILLDETAIL.NETAMT) AS VALUE FROM " & DBBILL & ".dbo.FMSBILLDETAIL WHERE FMSBILLDETAIL.INVNO = AROBL.IDINVC),0))  " & Environment.NewLine
            'sql1 &= "			END END AS NETAMT" & Environment.NewLine

            sql1 &= ",CASE WHEN FMSBILLDETAIL.LINEAMOUNT Is NULL THEN AROBL.AMTDUETC " & Environment.NewLine
            sql1 &= "	Else Case When  (FMSBILLDETAIL.LINEAMOUNT - ISNULL((Select SUM(FMSBILLDETAIL.NETAMT) As VALUE FROM " & DBBILL & ".dbo.FMSBILLDETAIL WHERE FMSBILLDETAIL.INVNO = AROBL.IDINVC And FMSBILLDETAIL.STA_0 <> 5),0)) = 0 Then 0 " & Environment.NewLine
            'sql1 &= "		Else (FMSBILLDETAIL.LINEAMOUNT - ISNULL((Select SUM(FMSBILLDETAIL.NETAMT) As VALUE FROM " & DBBILL & ".dbo.FMSBILLDETAIL WHERE FMSBILLDETAIL.INVNO = AROBL.IDINVC And FMSBILLDETAIL.STA_0 <> 5),0))  " & Environment.NewLine
            sql1 &= "		Else (FMSBILLDETAIL.LINEAMOUNT - ISNULL((Select SUM(FMSBILLDETAIL.NETAMT) As VALUE FROM " & DBBILL & ".dbo.FMSBILLDETAIL WHERE FMSBILLDETAIL.INVNO = AROBL.IDINVC And FMSBILLDETAIL.STA_0 NOT IN (4,5)),0))  " & Environment.NewLine
            sql1 &= "			End End As AMTOUTSTAND " & Environment.NewLine

            sql1 &= ",CASE WHEN FMSBILLDETAIL.LINEAMOUNT Is NULL THEN AROBL.AMTDUETC " & Environment.NewLine
            sql1 &= "	ELSE CASE WHEN (FMSBILLDETAIL.LINEAMOUNT - ISNULL((Select SUM(FMSBILLDETAIL.NETAMT) As VALUE FROM " & DBBILL & ".dbo.FMSBILLDETAIL WHERE FMSBILLDETAIL.INVNO = AROBL.IDINVC And FMSBILLDETAIL.STA_0 <> 5),0)) = 0 Then AROBL.AMTDUETC " & Environment.NewLine
            'sql1 &= "		ELSE (FMSBILLDETAIL.LINEAMOUNT - ISNULL((Select SUM(FMSBILLDETAIL.NETAMT) As VALUE FROM " & DBBILL & ".dbo.FMSBILLDETAIL WHERE FMSBILLDETAIL.INVNO = AROBL.IDINVC And FMSBILLDETAIL.STA_0 <> 5),0))  " & Environment.NewLine
            sql1 &= "		ELSE (FMSBILLDETAIL.LINEAMOUNT - ISNULL((Select SUM(FMSBILLDETAIL.NETAMT) As VALUE FROM " & DBBILL & ".dbo.FMSBILLDETAIL WHERE FMSBILLDETAIL.INVNO = AROBL.IDINVC And FMSBILLDETAIL.STA_0 NOT IN (4,5)),0))  " & Environment.NewLine
            sql1 &= "			END END AS NETAMT " & Environment.NewLine

            sql1 &= ",CASE WHEN FMSBILLDETAIL.BILLNO IS NULL THEN 'False' ELSE 'False' END  AS CHECK_0 --> KEY-IN " & Environment.NewLine
            sql1 &= ",'' AS STA_0 --> KEY-IN " & Environment.NewLine
            sql1 &= ",AROBL.CODETERM AS TERMCODE" & Environment.NewLine
            sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT1,'') AS BILLDTEXT1 --> KEY-IN " & Environment.NewLine
            sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT2,'') AS BILLDTEXT2--> KEY-IN " & Environment.NewLine
            sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT3,'') AS BILLDTEXT3--> KEY-IN " & Environment.NewLine
            sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT4,'') AS BILLDTEXT4--> KEY-IN " & Environment.NewLine
            sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT5,'') AS BILLDTEXT5--> KEY-IN " & Environment.NewLine
            sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT6,'') AS BILLDTEXT6--> KEY-IN " & Environment.NewLine
            sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT7,'') AS BILLDTEXT7--> KEY-IN" & Environment.NewLine
            sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT8,'') AS BILLDTEXT8--> KEY-IN " & Environment.NewLine
            sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT9,'') AS BILLDTEXT9--> KEY-IN " & Environment.NewLine
            sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT10,'') AS BILLDTEXT10--> KEY-IN " & Environment.NewLine

            sql1 &= "FROM AROBL " & Environment.NewLine
            sql1 &= "LEFT OUTER JOIN ARIBH ON AROBL.IDINVC = ARIBH.IDINVC AND AROBL.IDCUST = ARIBH.IDCUST " & Environment.NewLine
            sql1 &= "AND AROBL.CNTBTCH = ARIBH.CNTBTCH AND AROBL.CNTITEM = ARIBH.CNTITEM " & Environment.NewLine
            sql1 &= "LEFT OUTER JOIN " & DBBILL & ".dbo.FMSBILLDETAIL  ON FMSBILLDETAIL.INVNO = AROBL.IDINVC AND FMSBILLDETAIL.IDCUST = AROBL.IDCUST" & Environment.NewLine
            sql1 &= "AND FMSBILLDETAIL.BILLSEQ = (SELECT MAX(FMSBILLDETAIL.BILLSEQ) FROM " & DBBILL & ".dbo.FMSBILLDETAIL WHERE FMSBILLDETAIL.INVNO = AROBL.IDINVC)" & Environment.NewLine & Environment.NewLine
            sql1 &= "WHERE AROBL.IDCUST = '" & IDCUST & "'  " & Environment.NewLine
            sql1 &= " AND ARIBH.DATEINVC BETWEEN '" & DATEF & "' AND '" & DATET & "' " & Environment.NewLine
            sql1 &= "AND (AROBL.TRXTYPETXT = 1 OR AROBL.TRXTYPETXT = 2 OR AROBL.TRXTYPETXT = 3) " & Environment.NewLine
            sql1 &= "AND AROBL.AMTDUETC <> 0 " & Environment.NewLine
            If ShowPostCon = Nothing Then

            Else
                sql1 &= ShowPostCon
            End If

            Select Case FrmBillingNote.CbmBOI.Text
                Case "BOI"
                    sql1 = sql1 & "AND ARIBH.SPECINST = 'BOI'" & Environment.NewLine
                Case "NON BOI"
                    sql1 = sql1 & "AND ARIBH.SPECINST IN ('NON BOI','NONBOI','')  " & Environment.NewLine
                Case "ALL"
                    sql1 = sql1
                Case Else
                    sql1 = sql1 & "AND ARIBH.SPECINST IN ('NON BOI','NONBOI','')  " & Environment.NewLine
            End Select

            'sql1 &= "UNION ALL" & Environment.NewLine
            'sql1 &= "SELECT" & Environment.NewLine
            'sql1 &= " FMSBILLDETAIL.IDCUST AS IDCUST --AROBL.IDCUST " & Environment.NewLine
            'sql1 &= ",FMSBILLDETAIL.INVNO AS INVNO -- AROBL.IDINVC " & Environment.NewLine
            'sql1 &= ",SUBSTRING(CAST(FMSBILLDETAIL.INVDATE AS CHAR),7,2) + '/' + SUBSTRING(CAST(FMSBILLDETAIL.INVDATE AS CHAR),5,2) + '/' + SUBSTRING(CAST(FMSBILLDETAIL.INVDATE AS CHAR),1,4) AS INVDATE --> ARIBH.DATEINVC " & Environment.NewLine
            'sql1 &= ",SUBSTRING(CAST(FMSBILLDETAIL.DUEDATE AS CHAR),7,2) + '/' + SUBSTRING(CAST(FMSBILLDETAIL.DUEDATE AS CHAR),5,2) + '/' + SUBSTRING(CAST(FMSBILLDETAIL.DUEDATE AS CHAR),1,4)  AS DUEDATE --> ARIBH.DATEDUE " & Environment.NewLine
            'sql1 &= ",FMSBILLDETAIL.PONUM AS PONUM -->AROBL.IDCUSTPO " & Environment.NewLine
            'sql1 &= ",FMSBILLDETAIL.LINEAMOUNT AS LINEAMOUNT --> AROBL.AMTDUETC - Sum(FMSBILLDETAIL.LINEAMOUNT) " & Environment.NewLine
            'sql1 &= ",FMSBILLDETAIL.AMTOUTSTAND AS AMTOUTSTAND " & Environment.NewLine
            'sql1 &= ",FMSBILLDETAIL.NETAMT AS NETAMT " & Environment.NewLine
            'sql1 &= ",CASE WHEN FMSBILLDETAIL.BILLNO IS NULL THEN 'False' ELSE 'False' END  AS CHECK_0 --> KEY-IN " & Environment.NewLine
            'sql1 &= ",'' AS STA_0 --> KEY-IN " & Environment.NewLine
            'sql1 &= ",'' AS TERMCODE " & Environment.NewLine
            'sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT1,'') AS BILLDTEXT1 --> KEY-IN " & Environment.NewLine
            'sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT2,'') AS BILLDTEXT2--> KEY-IN " & Environment.NewLine
            'sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT3,'') AS BILLDTEXT3--> KEY-IN " & Environment.NewLine
            'sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT4,'') AS BILLDTEXT4--> KEY-IN " & Environment.NewLine
            'sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT5,'') AS BILLDTEXT5--> KEY-IN " & Environment.NewLine
            'sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT6,'') AS BILLDTEXT6--> KEY-IN " & Environment.NewLine
            'sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT7,'') AS BILLDTEXT7--> KEY-IN " & Environment.NewLine
            'sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT8,'') AS BILLDTEXT8--> KEY-IN " & Environment.NewLine
            'sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT9,'') AS BILLDTEXT9--> KEY-IN " & Environment.NewLine
            'sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT10,'') AS BILLDTEXT10--> KEY-IN " & Environment.NewLine
            'sql1 &= "FROM " & DBBILL & ".dbo.FMSBILLDETAIL " & Environment.NewLine
            'sql1 &= "WHERE FMSBILLDETAIL.IDCUST = '" & IDCUST & "'" & Environment.NewLine
            'sql1 &= "AND STA_0 = 4 "

            sql1 &= "UNION ALL" & Environment.NewLine
            sql1 &= "SELECT" & Environment.NewLine
            sql1 &= " FMSBILLDETAILREV.IDCUST AS IDCUST --AROBL.IDCUST " & Environment.NewLine
            sql1 &= ",FMSBILLDETAILREV.INVNO AS INVNO -- AROBL.IDINVC " & Environment.NewLine
            sql1 &= ",SUBSTRING(CAST(FMSBILLDETAILREV.INVDATE AS CHAR),7,2) + '/' + SUBSTRING(CAST(FMSBILLDETAILREV.INVDATE AS CHAR),5,2) + '/' + SUBSTRING(CAST(FMSBILLDETAILREV.INVDATE AS CHAR),1,4) AS INVDATE --> ARIBH.DATEINVC " & Environment.NewLine
            sql1 &= ",SUBSTRING(CAST(FMSBILLDETAILREV.DUEDATE AS CHAR),7,2) + '/' + SUBSTRING(CAST(FMSBILLDETAILREV.DUEDATE AS CHAR),5,2) + '/' + SUBSTRING(CAST(FMSBILLDETAILREV.DUEDATE AS CHAR),1,4)  AS DUEDATE --> ARIBH.DATEDUE " & Environment.NewLine
            sql1 &= ",FMSBILLDETAILREV.PONUM AS PONUM -->AROBL.IDCUSTPO " & Environment.NewLine
            sql1 &= ",FMSBILLDETAILREV.LINEAMOUNT AS LINEAMOUNT --> AROBL.AMTDUETC - Sum(FMSBILLDETAILREV.LINEAMOUNT) " & Environment.NewLine
            sql1 &= ",FMSBILLDETAILREV.AMTOUTSTAND AS AMTOUTSTAND " & Environment.NewLine
            sql1 &= ",FMSBILLDETAILREV.NETAMT AS NETAMT " & Environment.NewLine
            sql1 &= ",CASE WHEN FMSBILLDETAILREV.BILLNO IS NULL THEN 'False' ELSE 'False' END  AS CHECK_0 --> KEY-IN " & Environment.NewLine
            sql1 &= ",'' AS STA_0 --> KEY-IN " & Environment.NewLine
            sql1 &= ",'' AS TERMCODE " & Environment.NewLine
            sql1 &= ",ISNULL(FMSBILLDETAILREV.BILLDTEXT1,'') AS BILLDTEXT1 --> KEY-IN " & Environment.NewLine
            sql1 &= ",ISNULL(FMSBILLDETAILREV.BILLDTEXT2,'') AS BILLDTEXT2--> KEY-IN " & Environment.NewLine
            sql1 &= ",ISNULL(FMSBILLDETAILREV.BILLDTEXT3,'') AS BILLDTEXT3--> KEY-IN " & Environment.NewLine
            sql1 &= ",ISNULL(FMSBILLDETAILREV.BILLDTEXT4,'') AS BILLDTEXT4--> KEY-IN " & Environment.NewLine
            sql1 &= ",ISNULL(FMSBILLDETAILREV.BILLDTEXT5,'') AS BILLDTEXT5--> KEY-IN " & Environment.NewLine
            sql1 &= ",ISNULL(FMSBILLDETAILREV.BILLDTEXT6,'') AS BILLDTEXT6--> KEY-IN " & Environment.NewLine
            sql1 &= ",ISNULL(FMSBILLDETAILREV.BILLDTEXT7,'') AS BILLDTEXT7--> KEY-IN " & Environment.NewLine
            sql1 &= ",ISNULL(FMSBILLDETAILREV.BILLDTEXT8,'') AS BILLDTEXT8--> KEY-IN " & Environment.NewLine
            sql1 &= ",ISNULL(FMSBILLDETAILREV.BILLDTEXT9,'') AS BILLDTEXT9--> KEY-IN " & Environment.NewLine
            sql1 &= ",ISNULL(FMSBILLDETAILREV.BILLDTEXT10,'') AS BILLDTEXT10--> KEY-IN " & Environment.NewLine
            sql1 &= "FROM " & DBBILL & ".dbo.FMSBILLDETAILREV " & Environment.NewLine
            sql1 &= "WHERE FMSBILLDETAILREV.IDCUST = '" & IDCUST & "'" & Environment.NewLine
            'sql1 &= "AND STA_0 = 4 "

            Command = New SqlCommand(sql1, connect)
            adapter = New SqlDataAdapter(Command)
            adapter.Fill(dataSt, "Data")

        Catch ex As Exception
            WriteLog("Error 417 (GETDATA_SOURCEBILLDETAIL) :" & ex.Message & sql1)
        End Try
        connect.Close()
        Return dataSt.Tables("Data")

    End Function

    Public Shared Function GETDATA_SOURCEBILLDETAIL(ByVal IDCUST As String, ByVal DATEF As String, ByVal DATET As String, Optional ByVal ShowPostCon As String = Nothing) As DataTable
        Connection.Openconnect("Source", connect)
        Dim sql1 As String = ""
        Dim dataSt = New DataSet()
        Dim DBBILL = MAIN.txtDBBILL.Text.TrimEnd
        Try

            sql1 = "SELECT" & Environment.NewLine
            sql1 &= "AROBL.IDCUST AS IDCUST --AROBL.IDCUST" & Environment.NewLine
            sql1 &= ",AROBL.IDINVC AS INVNO -- AROBL.IDINVC " & Environment.NewLine
            sql1 &= ",SUBSTRING(CAST(ARIBH.DATEINVC AS CHAR),7,2) + '/' + SUBSTRING(CAST(ARIBH.DATEINVC AS CHAR),5,2) + '/' + SUBSTRING(CAST(ARIBH.DATEINVC AS CHAR),1,4) AS INVDATE --> ARIBH.DATEINVC " & Environment.NewLine
            sql1 &= ",SUBSTRING(CAST(ARIBH.DATEDUE AS CHAR),7,2) + '/' + SUBSTRING(CAST(ARIBH.DATEDUE AS CHAR),5,2) + '/' + SUBSTRING(CAST(ARIBH.DATEDUE AS CHAR),1,4)  AS DUEDATE --> ARIBH.DATEDUE " & Environment.NewLine
            sql1 &= ",AROBL.IDCUSTPO AS PONUM -->AROBL.IDCUSTPO " & Environment.NewLine

            sql1 &= ",AROBL.AMTDUETC AS LINEAMOUNT --> AROBL.AMTDUETC - Sum(FMSBILLDETAIL.LINEAMOUNT) " & Environment.NewLine

            'sql1 &= ",ISNULL(" & DBBILL & ".dbo.FMSBILLDETAIL.AMTOUTSTAND,AROBL.AMTDUETC) AS AMTOUTSTAND " & Environment.NewLine

            'sql1 &= ",CASE WHEN FMSBILLDETAIL.LINEAMOUNT IS NULL THEN AROBL.AMTDUETC " & Environment.NewLine
            'sql1 &= "	ELSE CASE WHEN  (FMSBILLDETAIL.LINEAMOUNT - ISNULL((SELECT SUM(FMSBILLDETAIL.NETAMT) AS VALUE FROM " & DBBILL & ".dbo.FMSBILLDETAIL WHERE FMSBILLDETAIL.INVNO = AROBL.IDINVC),0)) = 0 THEN AROBL.AMTDUETC " & Environment.NewLine
            'sql1 &= "		ELSE (FMSBILLDETAIL.LINEAMOUNT - ISNULL((SELECT SUM(FMSBILLDETAIL.NETAMT) AS VALUE FROM " & DBBILL & ".dbo.FMSBILLDETAIL WHERE FMSBILLDETAIL.INVNO = AROBL.IDINVC),0))  " & Environment.NewLine
            'sql1 &= "			END END AS NETAMT" & Environment.NewLine

            sql1 &= ",CASE WHEN FMSBILLDETAIL.LINEAMOUNT Is NULL THEN AROBL.AMTDUETC " & Environment.NewLine
            sql1 &= "	Else Case When  (FMSBILLDETAIL.LINEAMOUNT - ISNULL((Select SUM(FMSBILLDETAIL.NETAMT) As VALUE FROM " & DBBILL & ".dbo.FMSBILLDETAIL WHERE FMSBILLDETAIL.INVNO = AROBL.IDINVC And FMSBILLDETAIL.STA_0 <> 5),0)) = 0 Then 0 " & Environment.NewLine
            'sql1 &= "		Else (FMSBILLDETAIL.LINEAMOUNT - ISNULL((Select SUM(FMSBILLDETAIL.NETAMT) As VALUE FROM " & DBBILL & ".dbo.FMSBILLDETAIL WHERE FMSBILLDETAIL.INVNO = AROBL.IDINVC And FMSBILLDETAIL.STA_0 <> 5),0))  " & Environment.NewLine
            sql1 &= "		Else (FMSBILLDETAIL.LINEAMOUNT - ISNULL((Select SUM(FMSBILLDETAIL.NETAMT) As VALUE FROM " & DBBILL & ".dbo.FMSBILLDETAIL WHERE FMSBILLDETAIL.INVNO = AROBL.IDINVC And FMSBILLDETAIL.STA_0 NOT IN (4,5)),0))  " & Environment.NewLine
            sql1 &= "			End End As AMTOUTSTAND " & Environment.NewLine

            sql1 &= ",CASE WHEN FMSBILLDETAIL.LINEAMOUNT Is NULL THEN AROBL.AMTDUETC " & Environment.NewLine
            sql1 &= "	ELSE CASE WHEN (FMSBILLDETAIL.LINEAMOUNT - ISNULL((Select SUM(FMSBILLDETAIL.NETAMT) As VALUE FROM " & DBBILL & ".dbo.FMSBILLDETAIL WHERE FMSBILLDETAIL.INVNO = AROBL.IDINVC And FMSBILLDETAIL.STA_0 <> 5),0)) = 0 Then AROBL.AMTDUETC " & Environment.NewLine
            'sql1 &= "		ELSE (FMSBILLDETAIL.LINEAMOUNT - ISNULL((Select SUM(FMSBILLDETAIL.NETAMT) As VALUE FROM " & DBBILL & ".dbo.FMSBILLDETAIL WHERE FMSBILLDETAIL.INVNO = AROBL.IDINVC And FMSBILLDETAIL.STA_0 <> 5),0))  " & Environment.NewLine
            sql1 &= "		ELSE (FMSBILLDETAIL.LINEAMOUNT - ISNULL((Select SUM(FMSBILLDETAIL.NETAMT) As VALUE FROM " & DBBILL & ".dbo.FMSBILLDETAIL WHERE FMSBILLDETAIL.INVNO = AROBL.IDINVC And FMSBILLDETAIL.STA_0 NOT IN (4,5)),0))  " & Environment.NewLine
            sql1 &= "			END END AS NETAMT " & Environment.NewLine

            sql1 &= ",CASE WHEN FMSBILLDETAIL.BILLNO IS NULL THEN 'False' ELSE 'False' END  AS CHECK_0 --> KEY-IN " & Environment.NewLine
            sql1 &= ",'' AS STA_0 --> KEY-IN " & Environment.NewLine
            sql1 &= ",AROBL.CODETERM AS TERMCODE" & Environment.NewLine
            sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT1,'') AS BILLDTEXT1 --> KEY-IN " & Environment.NewLine
            sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT2,'') AS BILLDTEXT2--> KEY-IN " & Environment.NewLine
            sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT3,'') AS BILLDTEXT3--> KEY-IN " & Environment.NewLine
            sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT4,'') AS BILLDTEXT4--> KEY-IN " & Environment.NewLine
            sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT5,'') AS BILLDTEXT5--> KEY-IN " & Environment.NewLine
            sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT6,'') AS BILLDTEXT6--> KEY-IN " & Environment.NewLine
            sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT7,'') AS BILLDTEXT7--> KEY-IN" & Environment.NewLine
            sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT8,'') AS BILLDTEXT8--> KEY-IN " & Environment.NewLine
            sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT9,'') AS BILLDTEXT9--> KEY-IN " & Environment.NewLine
            sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT10,'') AS BILLDTEXT10--> KEY-IN " & Environment.NewLine
            sql1 &= ",ISNULL(FMSBILLDETAIL.BILLNO,'') AS BILLNO" & Environment.NewLine
            sql1 &= "FROM AROBL " & Environment.NewLine
            sql1 &= "LEFT OUTER JOIN ARIBH ON AROBL.IDINVC = ARIBH.IDINVC AND AROBL.IDCUST = ARIBH.IDCUST " & Environment.NewLine
            sql1 &= "AND AROBL.CNTBTCH = ARIBH.CNTBTCH AND AROBL.CNTITEM = ARIBH.CNTITEM " & Environment.NewLine
            sql1 &= "LEFT OUTER JOIN " & DBBILL & ".dbo.FMSBILLDETAIL  ON FMSBILLDETAIL.INVNO = AROBL.IDINVC AND FMSBILLDETAIL.IDCUST = AROBL.IDCUST" & Environment.NewLine
            sql1 &= "AND FMSBILLDETAIL.BILLSEQ = (SELECT MAX(FMSBILLDETAIL.BILLSEQ) FROM " & DBBILL & ".dbo.FMSBILLDETAIL WHERE FMSBILLDETAIL.INVNO = AROBL.IDINVC)" & Environment.NewLine & Environment.NewLine
            sql1 &= "WHERE AROBL.IDCUST = '" & IDCUST & "'  " & Environment.NewLine
            sql1 &= " AND ARIBH.DATEINVC BETWEEN '" & DATEF & "' AND '" & DATET & "' " & Environment.NewLine
            sql1 &= "AND (AROBL.TRXTYPETXT = 1 OR AROBL.TRXTYPETXT = 2 OR AROBL.TRXTYPETXT = 3) " & Environment.NewLine
            sql1 &= "AND AROBL.AMTDUETC <> 0 " & Environment.NewLine
            If ShowPostCon = Nothing Then

            Else
                sql1 &= ShowPostCon & Environment.NewLine
            End If

            Select Case FrmBillingNote.CbmBOI.Text
                Case "BOI"
                    sql1 = sql1 & "AND ARIBH.SPECINST = 'BOI'" & Environment.NewLine
                Case "NON BOI"
                    sql1 = sql1 & "AND ARIBH.SPECINST IN ('NON BOI','NONBOI','')  " & Environment.NewLine
                Case "ALL"
                    sql1 = sql1
                Case Else
                    sql1 = sql1 & "AND ARIBH.SPECINST IN ('NON BOI','NONBOI','')  " & Environment.NewLine
            End Select

            'sql1 &= "UNION ALL" & Environment.NewLine
            'sql1 &= "SELECT" & Environment.NewLine
            'sql1 &= " FMSBILLDETAIL.IDCUST AS IDCUST --AROBL.IDCUST " & Environment.NewLine
            'sql1 &= ",FMSBILLDETAIL.INVNO AS INVNO -- AROBL.IDINVC " & Environment.NewLine
            'sql1 &= ",SUBSTRING(CAST(FMSBILLDETAIL.INVDATE AS CHAR),7,2) + '/' + SUBSTRING(CAST(FMSBILLDETAIL.INVDATE AS CHAR),5,2) + '/' + SUBSTRING(CAST(FMSBILLDETAIL.INVDATE AS CHAR),1,4) AS INVDATE --> ARIBH.DATEINVC " & Environment.NewLine
            'sql1 &= ",SUBSTRING(CAST(FMSBILLDETAIL.DUEDATE AS CHAR),7,2) + '/' + SUBSTRING(CAST(FMSBILLDETAIL.DUEDATE AS CHAR),5,2) + '/' + SUBSTRING(CAST(FMSBILLDETAIL.DUEDATE AS CHAR),1,4)  AS DUEDATE --> ARIBH.DATEDUE " & Environment.NewLine
            'sql1 &= ",FMSBILLDETAIL.PONUM AS PONUM -->AROBL.IDCUSTPO " & Environment.NewLine
            'sql1 &= ",FMSBILLDETAIL.LINEAMOUNT AS LINEAMOUNT --> AROBL.AMTDUETC - Sum(FMSBILLDETAIL.LINEAMOUNT) " & Environment.NewLine
            'sql1 &= ",FMSBILLDETAIL.AMTOUTSTAND AS AMTOUTSTAND " & Environment.NewLine
            'sql1 &= ",FMSBILLDETAIL.NETAMT AS NETAMT " & Environment.NewLine
            'sql1 &= ",CASE WHEN FMSBILLDETAIL.BILLNO IS NULL THEN 'False' ELSE 'False' END  AS CHECK_0 --> KEY-IN " & Environment.NewLine
            'sql1 &= ",'' AS STA_0 --> KEY-IN " & Environment.NewLine
            'sql1 &= ",'' AS TERMCODE " & Environment.NewLine
            'sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT1,'') AS BILLDTEXT1 --> KEY-IN " & Environment.NewLine
            'sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT2,'') AS BILLDTEXT2--> KEY-IN " & Environment.NewLine
            'sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT3,'') AS BILLDTEXT3--> KEY-IN " & Environment.NewLine
            'sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT4,'') AS BILLDTEXT4--> KEY-IN " & Environment.NewLine
            'sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT5,'') AS BILLDTEXT5--> KEY-IN " & Environment.NewLine
            'sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT6,'') AS BILLDTEXT6--> KEY-IN " & Environment.NewLine
            'sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT7,'') AS BILLDTEXT7--> KEY-IN " & Environment.NewLine
            'sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT8,'') AS BILLDTEXT8--> KEY-IN " & Environment.NewLine
            'sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT9,'') AS BILLDTEXT9--> KEY-IN " & Environment.NewLine
            'sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT10,'') AS BILLDTEXT10--> KEY-IN " & Environment.NewLine
            'sql1 &= "FROM " & DBBILL & ".dbo.FMSBILLDETAIL " & Environment.NewLine
            'sql1 &= "WHERE FMSBILLDETAIL.IDCUST = '" & IDCUST & "'" & Environment.NewLine
            'sql1 &= "AND STA_0 = 4 "

            sql1 &= "UNION ALL" & Environment.NewLine
            sql1 &= "SELECT" & Environment.NewLine
            sql1 &= " FMSBILLDETAIL.IDCUST AS IDCUST --AROBL.IDCUST " & Environment.NewLine
            sql1 &= ",FMSBILLDETAIL.INVNO AS INVNO -- AROBL.IDINVC " & Environment.NewLine
            sql1 &= ",SUBSTRING(CAST(FMSBILLDETAIL.INVDATE AS CHAR),7,2) + '/' + SUBSTRING(CAST(FMSBILLDETAIL.INVDATE AS CHAR),5,2) + '/' + SUBSTRING(CAST(FMSBILLDETAIL.INVDATE AS CHAR),1,4) AS INVDATE --> ARIBH.DATEINVC " & Environment.NewLine
            sql1 &= ",SUBSTRING(CAST(FMSBILLDETAIL.DUEDATE AS CHAR),7,2) + '/' + SUBSTRING(CAST(FMSBILLDETAIL.DUEDATE AS CHAR),5,2) + '/' + SUBSTRING(CAST(FMSBILLDETAIL.DUEDATE AS CHAR),1,4)  AS DUEDATE --> ARIBH.DATEDUE " & Environment.NewLine
            sql1 &= ",FMSBILLDETAIL.PONUM AS PONUM -->AROBL.IDCUSTPO " & Environment.NewLine
            sql1 &= ",FMSBILLDETAIL.LINEAMOUNT AS LINEAMOUNT --> AROBL.AMTDUETC - Sum(FMSBILLDETAIL.LINEAMOUNT) " & Environment.NewLine
            sql1 &= ",FMSBILLDETAIL.AMTOUTSTAND AS AMTOUTSTAND " & Environment.NewLine
            sql1 &= ",FMSBILLDETAIL.NETAMT AS NETAMT " & Environment.NewLine
            sql1 &= ",CASE WHEN FMSBILLDETAIL.BILLNO IS NULL THEN 'False' ELSE 'False' END  AS CHECK_0 --> KEY-IN " & Environment.NewLine
            sql1 &= ",'' AS STA_0 --> KEY-IN " & Environment.NewLine
            sql1 &= ",'' AS TERMCODE " & Environment.NewLine
            sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT1,'') AS BILLDTEXT1 --> KEY-IN " & Environment.NewLine
            sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT2,'') AS BILLDTEXT2--> KEY-IN " & Environment.NewLine
            sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT3,'') AS BILLDTEXT3--> KEY-IN " & Environment.NewLine
            sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT4,'') AS BILLDTEXT4--> KEY-IN " & Environment.NewLine
            sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT5,'') AS BILLDTEXT5--> KEY-IN " & Environment.NewLine
            sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT6,'') AS BILLDTEXT6--> KEY-IN " & Environment.NewLine
            sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT7,'') AS BILLDTEXT7--> KEY-IN " & Environment.NewLine
            sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT8,'') AS BILLDTEXT8--> KEY-IN " & Environment.NewLine
            sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT9,'') AS BILLDTEXT9--> KEY-IN " & Environment.NewLine
            sql1 &= ",ISNULL(FMSBILLDETAIL.BILLDTEXT10,'') AS BILLDTEXT10--> KEY-IN " & Environment.NewLine
            sql1 &= ",CASE WHEN FMSBILLDETAIL.STA_0 = 4 OR FMSBILLDETAIL.STA_0 = 5  THEN '' ELSE FMSBILLDETAIL.BILLNO  END AS BILLNO" & Environment.NewLine

            sql1 &= "FROM " & DBBILL & ".dbo.FMSBILLDETAIL " & Environment.NewLine
            sql1 &= "WHERE FMSBILLDETAIL.IDCUST = '" & IDCUST & "'" & Environment.NewLine
            sql1 &= "AND FMSBILLDETAIL.STA_0 = 4 " & Environment.NewLine
            sql1 &= " AND FMSBILLDETAIL.INVDATE BETWEEN '" & DATEF & "' AND '" & DATET & "' " & Environment.NewLine
            sql1 &= "ORDER BY INVNO,INVDATE" & Environment.NewLine
            Command = New SqlCommand(sql1, connect)
            adapter = New SqlDataAdapter(Command)
            adapter.Fill(dataSt, "Data")
            WriteLog(" 633 (GETDATA_SOURCEBILLDETAIL) :" & sql1)
        Catch ex As Exception
            WriteLog("Error 417 (GETDATA_SOURCEBILLDETAIL) :" & ex.Message & sql1)
        End Try
        connect.Close()
        Return dataSt.Tables("Data")

    End Function

    Public Shared Function GETDATA_BILLHEADER(ByVal BILLNO As String, ByVal IDCUST As String) As DataTable
        Connection.Openconnect("BILL", connect)
        Dim sql1 As String = ""
        Dim dataSt = New DataSet()
        Dim DBBILL = MAIN.txtDBBILL.Text.TrimEnd
        Try
            sql1 = "SELECT * " & Environment.NewLine
            sql1 &= "FROM FMSBILLHEAD" & Environment.NewLine
            sql1 &= "WHERE BILLNO = '" & BILLNO & "' AND  IDCUST = '" & IDCUST & "' " & Environment.NewLine
            sql1 &= "AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "' " & Environment.NewLine
            Command = New SqlCommand(sql1, connect)
            adapter = New SqlDataAdapter(Command)
            adapter.Fill(dataSt, "Data")
        Catch ex As Exception
            WriteLog("Error 438 (GETDATA_BILLHEADER) :" & ex.Message & sql1)
        End Try
        connect.Close()
        Return dataSt.Tables("Data")

    End Function
    Public Shared Function GETDATA_BILLDETAIL(ByVal BILLNO As String, ByVal IDCUST As String, Optional ByVal INVNO As String = "") As DataTable
        Connection.Openconnect("BILL", connect)
        Dim sql1 As String = ""
        Dim dataSt = New DataSet()
        Dim DBBILL = MAIN.txtDBBILL.Text.TrimEnd
        Try
            sql1 = "SELECT" & Environment.NewLine
            sql1 &= "IDCUST," & Environment.NewLine
            sql1 &= "INVNO, " & Environment.NewLine
            sql1 &= "SUBSTRING(CAST(INVDATE AS CHAR),7,2) + '/' + SUBSTRING(CAST(INVDATE AS CHAR),5,2) + '/' + SUBSTRING(CAST(INVDATE AS CHAR),1,4) AS INVDATE ,  " & Environment.NewLine
            sql1 &= "SUBSTRING(CAST(DUEDATE AS CHAR),7,2) + '/' + SUBSTRING(CAST(DUEDATE AS CHAR),5,2) + '/' + SUBSTRING(CAST(DUEDATE AS CHAR),1,4)  AS DUEDATE,  " & Environment.NewLine
            sql1 &= "PONUM," & Environment.NewLine
            sql1 &= "LINEAMOUNT," & Environment.NewLine
            sql1 &= "AMTOUTSTAND," & Environment.NewLine
            sql1 &= "NETAMT," & Environment.NewLine
            sql1 &= "CHECK_0," & Environment.NewLine
            sql1 &= "CAST(STA_0 AS nchar(1)) AS STA_0 ," & Environment.NewLine
            sql1 &= "'' AS TERMCODE," & Environment.NewLine
            sql1 &= "BILLDTEXT1," & Environment.NewLine
            sql1 &= "BILLDTEXT2," & Environment.NewLine
            sql1 &= "BILLDTEXT3," & Environment.NewLine
            sql1 &= "BILLDTEXT4," & Environment.NewLine
            sql1 &= "BILLDTEXT5," & Environment.NewLine
            sql1 &= "BILLDTEXT6," & Environment.NewLine
            sql1 &= "BILLDTEXT7, " & Environment.NewLine
            sql1 &= "BILLDTEXT8," & Environment.NewLine
            sql1 &= "BILLDTEXT9," & Environment.NewLine
            sql1 &= "BILLDTEXT10," & Environment.NewLine
            sql1 &= "BILLNO" & Environment.NewLine

            sql1 &= "FROM FMSBILLDETAIL" & Environment.NewLine
            sql1 &= "WHERE BILLNO = '" & BILLNO & "' " & Environment.NewLine
            sql1 &= "AND IDCUST = '" & IDCUST & "' " & Environment.NewLine
            sql1 &= "AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "' " & Environment.NewLine

            If INVNO <> "" Then
                sql1 &= "AND INVNO = '" & INVNO & "'" & Environment.NewLine
            End If

            Command = New SqlCommand(sql1, connect)
            adapter = New SqlDataAdapter(Command)
            adapter.Fill(dataSt, "Data")

        Catch ex As Exception
            WriteLog("Error 487 (GETDATA_BILLDETAIL) :" & ex.Message & sql1)
        End Try
        connect.Close()
        Return dataSt.Tables("Data")

    End Function

    Public Shared Function GETDATA_SUMNETAMT(ByVal INVNO As String, Optional ByVal RCP As String = "") As Decimal
        Dim vVALUE As Decimal
        Connection.Openconnect("BILL", connect)
        Dim sql1 As String
        If RCP = "" Then
            sql1 = "SELECT SUM(NETAMT) AS VALUE FROM FMSBILLDETAIL WHERE INVNO  = '" & INVNO & "' AND STA_0 NOT IN (4,5)  AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "' "
        Else
            sql1 = "Select SUM(NETAMT) As VALUE FROM FMSRCPDETAIL WHERE BILLNO = '" & INVNO & "' AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "' AND STA_0 IN (1,2)"

        End If

        Dim cmd As SqlCommand = New SqlCommand(sql1, connect)
        Dim result As SqlDataReader = cmd.ExecuteReader()

        While result.Read()

            If IsDBNull(result("VALUE")) = True Then
                vVALUE = 0
            Else
                vVALUE = result("VALUE")
            End If
        End While
        connect.Close()
        Return vVALUE

    End Function

    Public Shared Function GETDATA_TERMCODE(ByVal IDCUST As String) As String
        Dim vVALUE As String = ""
        Connection.Openconnect("Source", connect)
        Dim sql1 As String

        sql1 = "SELECT TOP 1 CODETERM AS VALUE FROM ARCUS WHERE IDCUST  = '" & IDCUST & "' "


        Dim cmd As SqlCommand = New SqlCommand(sql1, connect)
        Dim result As SqlDataReader = cmd.ExecuteReader()

        While result.Read()

            If IsDBNull(result("VALUE")) = True Then
                vVALUE = 0
            Else
                vVALUE = result("VALUE")
            End If

        End While
        connect.Close()
        Return vVALUE
    End Function

    Public Shared Function GETDATA_REVBILL(ByVal IDCUST As String, ByVal RCPF As String, ByVal RCPT As String, Optional ByVal ShowPostCon As String = Nothing) As DataTable
        Connection.Openconnect("BILL", connect)
        Dim sql1 As String = ""
        Dim dataSt = New DataSet()
        Dim DBBILL = MAIN.txtDBBILL.Text.TrimEnd
        Try

            sql1 = "SELECT FMSRCPDETAIL.BILLNO,FMSRCPDETAIL.INVNO,FMSRCPDETAIL.IDCUST,'' AS CUSTNAME --, FMSBILLDETAIL.INVDATE AS RECEIVEDATE, FMSBILLDETAIL.DUEDATE AS PAYDATE, " & Environment.NewLine
            sql1 &= ",SUBSTRING(CAST(FMSBILLDETAIL.INVDATE AS CHAR),7,2) + '/' + SUBSTRING(CAST(FMSBILLDETAIL.INVDATE AS CHAR),5,2) + '/' + SUBSTRING(CAST(FMSBILLDETAIL.INVDATE AS CHAR),1,4) AS RECEIVEDATE " & Environment.NewLine
            sql1 &= ",SUBSTRING(CAST(FMSBILLDETAIL.DUEDATE AS CHAR),7,2) + '/' + SUBSTRING(CAST(FMSBILLDETAIL.DUEDATE AS CHAR),5,2) + '/' + SUBSTRING(CAST(FMSBILLDETAIL.DUEDATE AS CHAR),1,4) AS PAYDATE," & Environment.NewLine
            sql1 &= " FMSRCPDETAIL.RCPNO,  " & Environment.NewLine
            sql1 &= " 'False' AS CHECK_0 , FMSRCPDETAIL.NETAMT,FMSRCPDETAIL.AMT, 0 AS AMTOUTSTAND  " & Environment.NewLine
            sql1 &= "FROM FMSRCPDETAIL " & Environment.NewLine
            sql1 &= "INNER JOIN FMSBILLDETAIL ON FMSBILLDETAIL.BILLNO = FMSRCPDETAIL.BILLNO AND FMSBILLDETAIL.INVNO = FMSRCPDETAIL.INVNO AND FMSBILLDETAIL.IDCUST = FMSRCPDETAIL.IDCUST" & Environment.NewLine
            sql1 &= "WHERE NOT EXISTS(SELECT * FROM FMSRCPDETAIL RCPDETAIL " & Environment.NewLine
            sql1 &= "WHERE FMSRCPDETAIL.BILLNO = RCPDETAIL.BILLNO AND RCPDETAIL.STA_0 = 2)  " & Environment.NewLine
            sql1 &= " AND FMSRCPDETAIL.STA_0 = 4 " & Environment.NewLine
            sql1 &= " AND FMSBILLDETAIL.IDCUST = '" & IDCUST & "'" & Environment.NewLine
            sql1 &= " AND FMSBILLDETAIL.AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "' " & Environment.NewLine
            If RCPT.TrimEnd = "" Then
                sql1 &= " AND FMSBILLDETAIL.BILLNO BETWEEN '' AND 'zzzzzzz'"
            Else
                sql1 &= "  AND FMSBILLDETAIL.BILLNO BETWEEN '" & RCPF & "' AND '" & RCPT & "'"
            End If


            sql1 &= " UNION " & Environment.NewLine
            sql1 &= "        Select  FMSBILLHEAD.BILLNO,'' AS INVNO, FMSBILLHEAD.IDCUST, '' AS CUSTNAME "
            sql1 &= ",SUBSTRING(CAST(FMSBILLHEAD.INVDATE AS CHAR),7,2) + '/' + SUBSTRING(CAST(FMSBILLHEAD.INVDATE AS CHAR),5,2) + '/' + SUBSTRING(CAST(FMSBILLHEAD.INVDATE AS CHAR),1,4) AS RECEIVEDATE "
            sql1 &= ",SUBSTRING(CAST(FMSBILLHEAD.DUEDATE AS CHAR),7,2) + '/' + SUBSTRING(CAST(FMSBILLHEAD.DUEDATE AS CHAR),5,2) + '/' + SUBSTRING(CAST(FMSBILLHEAD.DUEDATE AS CHAR),1,4) AS PAYDATE, "
            sql1 &= " '' AS RCPNO,  "
            sql1 &= "'False' AS CHECK_0 , FMSBILLHEAD.NETAMT, FMSBILLHEAD.AMT, '' AS AMTOUTSTAND  "
            sql1 &= "From FMSBILLHEAD" & Environment.NewLine

            sql1 &= " WHERE FMSBILLHEAD.STA_0 = '2' AND FMSBILLHEAD.BILLNO  NOT IN (select BILLNO from FMSRCPDETAIL where  FMSBILLHEAD.BILLNO = FMSRCPDETAIL.BILLNO)  " & Environment.NewLine
            sql1 &= " AND FMSBILLHEAD.IDCUST = '" & IDCUST & "'" & Environment.NewLine
            sql1 &= " AND FMSBILLHEAD.AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "' " & Environment.NewLine
            If RCPT.TrimEnd = "" Then
                sql1 &= " AND FMSBILLHEAD.BILLNO BETWEEN '' AND 'zzzzzzz'"
            Else
                sql1 &= "  AND FMSBILLHEAD.BILLNO BETWEEN '" & RCPF & "' AND '" & RCPT & "'"
            End If

            'sql1 &= " ORDER BY FMSRCPDETAIL.RCPNO, FMSRCPDETAIL.BILLNO, FMSRCPDETAIL.INVNO  " & Environment.NewLine

            sql1 &= " ORDER BY  BILLNO  " & Environment.NewLine

            Command = New SqlCommand(sql1, connect)
            adapter = New SqlDataAdapter(Command)
            adapter.Fill(dataSt, "Data")

        Catch ex As Exception
            WriteLog("Error 595 (GETDATA_REVBILL) :" & ex.Message & sql1)
        End Try
        connect.Close()
        Return dataSt.Tables("Data")

    End Function

    Public Shared Function GETDATA_MININVDATE(ByVal BILLNO As String) As String
        Dim vVALUE As String = ""
        Connection.Openconnect("BILL", connect)
        Dim sql1 As String

        sql1 = "SELECT MIN(INVDATE) AS VALUE FROM FMSBILLDETAIL  WHERE BILLNO  = '" & BILLNO & "' "


        Dim cmd As SqlCommand = New SqlCommand(sql1, connect)
        Dim result As SqlDataReader = cmd.ExecuteReader()

        While result.Read()

            If IsDBNull(result("VALUE")) = True Then
                vVALUE = 0
            Else
                vVALUE = result("VALUE")
            End If

        End While
        connect.Close()
        Return vVALUE
    End Function
    Public Shared Function GETDATA_MAXINVDATE(ByVal BILLNO As String) As String
        Dim vVALUE As String = ""
        Connection.Openconnect("BILL", connect)
        Dim sql1 As String

        sql1 = "SELECT MAX(INVDATE) AS VALUE FROM FMSBILLDETAIL  WHERE BILLNO  = '" & BILLNO & "' "


        Dim cmd As SqlCommand = New SqlCommand(sql1, connect)
        Dim result As SqlDataReader = cmd.ExecuteReader()

        While result.Read()

            If IsDBNull(result("VALUE")) = True Then
                vVALUE = 0
            Else
                vVALUE = result("VALUE")
            End If

        End While
        connect.Close()
        Return vVALUE
    End Function

    Public Shared Function GETDATA_BILLNO(ByVal BILLNO As String) As Boolean
        Dim vVALUE As Boolean
        Connection.Openconnect("BILL", connect)
        Dim sql1 As String

        sql1 = "SELECT ISNULL(BILLNO,'') AS VALUE FROM FMSBILLHEAD  WHERE BILLNO  = '" & BILLNO & "' "


        Dim cmd As SqlCommand = New SqlCommand(sql1, connect)
        Dim result As SqlDataReader = cmd.ExecuteReader()

        While result.Read()

            If (result("VALUE")) = "" Then
                vVALUE = False
            Else
                vVALUE = True
            End If

        End While
        connect.Close()
        Return vVALUE
    End Function

#End Region

#Region "RECEIVE"

    Public Shared Function GETDATA_BATCHRCP(ByVal ShowSTA_0 As String, ByVal ShowComplete As String, Optional ByVal RCPNO As String = "") As DataTable
        Connection.Openconnect("BILL", connect)
        Dim sql1 As String = ""
        Dim dataSt = New DataSet()
        Dim DBSRC = MAIN.txtDBSOURCE.Text.TrimEnd
        Try
            sql1 = "SELECT DISTINCT " & vbCrLf
            sql1 &= "RCPNO AS RCPNO " & vbCrLf
            sql1 &= ",IDCUST AS IDCUST " & vbCrLf
            sql1 &= ",'' AS CUSTNAME" & vbCrLf
            sql1 &= ",SUBSTRING(CAST(RECEIVEDOCDATE AS CHAR),7,2) + '/' + SUBSTRING(CAST(RECEIVEDOCDATE AS CHAR),5,2) + '/' + SUBSTRING(CAST(RECEIVEDOCDATE AS CHAR),1,4) AS RECEIVEDOCDATE " & vbCrLf
            sql1 &= ",SUBSTRING(CAST(RECEIVEDATE AS CHAR),7,2) + '/' + SUBSTRING(CAST(RECEIVEDATE AS CHAR),5,2) + '/' + SUBSTRING(CAST(RECEIVEDATE AS CHAR),1,4) AS RECEIVEDATE" & vbCrLf
            sql1 &= ",NETAMT AS AMOUNT" & vbCrLf
            sql1 &= ",CASE WHEN STA_0 = 1 THEN 'Open' ELSE CASE WHEN STA_0 = 2 THEN 'Posted' ELSE CASE WHEN STA_0 = 3 THEN 'RECEIPT' ELSE CASE WHEN STA_0 = 4 THEN 'Reverse' ELSE 'Delete'  END END END END  AS [STATUS]" & vbCrLf
            sql1 &= ",'' AS CNTINV" & vbCrLf
            sql1 &= ",RCPSEQ " & Environment.NewLine
            sql1 &= ",IMPORTCB" & Environment.NewLine
            sql1 &= ", ISNULL(CBBATCH,'') AS CB_Batch " & Environment.NewLine

            sql1 &= "FROM FMSRCPHEAD" & vbCrLf

            'sql1 &= " LEFT OUTER JOIN " & DBSRC & " .dbo.CBBTHD on CBBTHD.REFERENCE = FMSRCPHEAD.RCPNO " & Environment.NewLine

            If ShowSTA_0 = "False" Then
                sql1 &= "WHERE" & Environment.NewLine



                sql1 &= " FMSRCPHEAD.AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "' " & Environment.NewLine
                'Show post not import
                If ShowComplete = "True" Then
                    'sql1 &= "OR STA_0 = '2'" & Environment.NewLine
                    sql1 &= "AND STA_0 = '2' AND  IMPORTCB = 'N'" & Environment.NewLine
                    'sql1 &= "AND  IMPORTCB = 'N'" & Environment.NewLine
                Else
                    sql1 &= "AND STA_0 = '1' " & Environment.NewLine
                    'sql1 &= "OR STA_0 <> '2'" & Environment.NewLine
                    'sql1 &= "AND  IMPORTCB = 'Y'" & Environment.NewLine
                End If

            Else

                sql1 &= " WHERE FMSRCPHEAD.AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "' " & Environment.NewLine
                'Show post not import
                If ShowComplete = "True" Then
                    'sql1 &= "AND STA_0 = '2' AND  IMPORTCB <> 'Y'" & Environment.NewLine
                Else
                    'sql1 &= "AND  IMPORTCB = 'N'" & Environment.NewLine
                End If
            End If
            If RCPNO <> "" Then
                sql1 &= "AND RCPNO = '" & RCPNO & "'"
            End If


            Command = New SqlCommand(sql1, connect)
            adapter = New SqlDataAdapter(Command)
            adapter.Fill(dataSt, "Data")

        Catch ex As Exception
            WriteLog("Error 846 (GETDATA_BATCHRCP) :" & ex.Message & sql1)
        End Try
        connect.Close()
        Return dataSt.Tables("Data")

    End Function
    Public Shared Function GETDATA_RCPHEADER(ByVal RCPNO As String, ByVal IDCUST As String) As DataTable
        Connection.Openconnect("BILL", connect)
        Dim sql1 As String = ""
        Dim dataSt = New DataSet()
        Dim DBBILL = MAIN.txtDBBILL.Text.TrimEnd
        Dim DBSRC = MAIN.txtDBSOURCE.Text.TrimEnd
        Try

            sql1 = "SELECT * " & Environment.NewLine
            sql1 &= "FROM FMSRCPHEAD" & Environment.NewLine

            sql1 &= "WHERE RCPNO = '" & RCPNO & "' AND  IDCUST = '" & IDCUST & "' " & Environment.NewLine
            sql1 &= " AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "' " & Environment.NewLine
            Command = New SqlCommand(sql1, connect)
            adapter = New SqlDataAdapter(Command)
            adapter.Fill(dataSt, "Data")

        Catch ex As Exception
            WriteLog("Error 678 (GETDATA_RCPHEADER) :" & ex.Message & sql1)
        End Try
        connect.Close()
        Return dataSt.Tables("Data")

    End Function

    Public Shared Function GETDATA_SOURCERCPDETAIL(ByVal IDCUST As String, ByVal BILLNOF As String, ByVal BILLNOT As String, Optional ByVal ShowPostCon As String = Nothing, Optional ByVal STRCON As String = Nothing) As DataTable
        Connection.Openconnect("BILL", connect)
        Dim sql1 As String = ""
        Dim dataSt = New DataSet()
        Dim DBSRC = MAIN.txtDBSOURCE.Text.TrimEnd.TrimEnd
        Try
            sql1 = STRCON

            sql1 &= "SELECT" & Environment.NewLine

            sql1 &= "  FMSBILLHEAD.IDCUST " & Environment.NewLine
            sql1 &= " ,ISNULL(FMSRCPDETAIL.RCPNO,'') AS RCPNO " & Environment.NewLine
            sql1 &= " ,ISNULL(FMSRCPDETAIL.RCPSEQ,'') AS RCPSEQ " & Environment.NewLine
            sql1 &= " ,FMSBILLDETAIL.INVNO AS IDINVC " & Environment.NewLine
            sql1 &= " ,SUBSTRING(CAST(AROBL.DATEINVC AS CHAR),7,2) + '/' + SUBSTRING(CAST(AROBL.DATEINVC AS CHAR),5,2) + '/' + SUBSTRING(CAST(AROBL.DATEINVC AS CHAR),1,4)  AS INVDATE " & Environment.NewLine
            sql1 &= " ,SUBSTRING(CAST(AROBL.DATEDUE AS CHAR),7,2) + '/' + SUBSTRING(CAST(AROBL.DATEDUE AS CHAR),5,2) + '/' + SUBSTRING(CAST(AROBL.DATEDUE AS CHAR),1,4)  AS DUEDATE " & Environment.NewLine
            sql1 &= " ,AROBL.AMTTXBLHC AS UNITPRICE " & Environment.NewLine
            sql1 &= " ,AROBL.AMTTAX1HC AS VATAMT " & Environment.NewLine
            sql1 &= " ,ISNULL(FMSRCPDETAIL.AMTOUTSTAND, FMSBILLDETAIL.NETAMT)  AS RCPAMT" & Environment.NewLine
            sql1 &= " , ISNULL(FMSRCPDETAIL.AMTOUTSTAND, FMSBILLDETAIL.NETAMT)  AS AMTOUTSTAND --> CALCURATE  " & Environment.NewLine
            sql1 &= " , FMSBILLDETAIL.NETAMT AS NETAMT --> CALCURATE " & Environment.NewLine
            sql1 &= " , FMSBILLDETAIL.LINEAMOUNT AS AMT --> AROBL.AROBL.AMTDUETC " & Environment.NewLine
            '13/05/2022
            'sql1 &= " , FMSBILLHEAD.NETAMT AS NETAMT --> CALCURATE " & Environment.NewLine
            'sql1 &= " , FMSBILLHEAD.NETAMT AS AMT --> AROBL.AROBL.AMTDUETC " & Environment.NewLine

            sql1 &= " , 'False' AS CHECK_0 --> KEY-IN " & Environment.NewLine
            sql1 &= " , '' AS STA_0  --> KEY-IN " & Environment.NewLine
            sql1 &= " , '' AS RCPDTEXT1--> KEY-IN " & Environment.NewLine
            sql1 &= " , '' AS RCPDTEXT2--> KEY-IN " & Environment.NewLine
            sql1 &= " , '' AS RCPDTEXT3--> KEY-IN " & Environment.NewLine
            sql1 &= " , '' AS RCPDTEXT4--> KEY-IN " & Environment.NewLine
            sql1 &= " , '' AS RCPDTEXT5--> KEY-IN " & Environment.NewLine
            sql1 &= " , '' AS RCPDTEXT6--> KEY-IN " & Environment.NewLine
            sql1 &= " , '' AS RCPDTEXT7--> KEY-IN " & Environment.NewLine
            sql1 &= " , '' AS RCPDTEXT8--> KEY-IN " & Environment.NewLine
            sql1 &= " , '' AS RCPDTEXT9--> KEY-IN " & Environment.NewLine
            sql1 &= " , '' AS RCPDTEXT10--> KEY-IN " & Environment.NewLine
            sql1 &= " , AROBL.AMTTAX1HC AS VAT" & Environment.NewLine
            sql1 &= " , FMSBILLHEAD.BILLNO AS BILLNO " & Environment.NewLine

            sql1 &= " FROM FMSBILLHEAD " & Environment.NewLine
            sql1 &= " INNER JOIN FMSBILLDETAIL ON FMSBILLDETAIL.BILLSEQ = FMSBILLHEAD.BILLSEQ And FMSBILLDETAIL.BILLNO = FMSBILLHEAD.BILLNO " & Environment.NewLine
            sql1 &= " LEFT OUTER JOIN " & DBSRC & ".dbo.AROBL AROBL ON AROBL.IDINVC = FMSBILLDETAIL.INVNO And AROBL.IDCUST = FMSBILLDETAIL.IDCUST  " & Environment.NewLine
            'sql1 &= " WHERE FMSBILLHEAD.IDCUST = '" & IDCUST & "' " & Environment.NewLine
            'sql1 &= " AND FMSBILLHEAD.BILLNO BETWEEN '" & BILLNOF & "' AND '" & BILLNOT & "' " & Environment.NewLine
            sql1 &= " LEFT OUTER JOIN FMSRCPDETAIL ON FMSRCPDETAIL.BILLNO = FMSBILLDETAIL.BILLNO AND FMSRCPDETAIL.INVNO = FMSBILLDETAIL.INVNO " & Environment.NewLine
            sql1 &= "  AND FMSRCPDETAIL.IDCUST = FMSBILLDETAIL.IDCUST " & Environment.NewLine
            sql1 &= "  AND FMSRCPDETAIL.STA_0 NOT IN ( 4,5)" & Environment.NewLine
            sql1 &= "  --AND FMSRCPDETAIL.RCPSEQ = (SELECT MAX(RCPSEQ) FROM FMSRCPDETAIL WHERE FMSRCPDETAIL.INVNO = FMSBILLDETAIL.INVNO )" & Environment.NewLine

            'sql1 &= " WHERE FMSBILLHEAD.IDCUST = '" & IDCUST & "' " & Environment.NewLine
            sql1 &= " WHERE FMSBILLHEAD.IDCUST BETWEEN  '' AND '" & IDCUST & "' " & Environment.NewLine
            sql1 &= "AND FMSBILLHEAD.STA_0 = 2" & Environment.NewLine
            'sql1 &= "AND FMSRCPHEAD.STA_0 <> 2 "
            sql1 &= "--AND ISNULL(FMSRCPDETAIL.STA_0,0) <> 2" & Environment.NewLine
            sql1 &= "AND ISNULL(FMSRCPDETAIL.AMTOUTSTAND, FMSBILLDETAIL.NETAMT) <> 0" & Environment.NewLine
            If ShowPostCon = Nothing Then
                If BILLNOT.TrimEnd = "" Then
                    BILLNOT = "zzzzz"
                End If

                sql1 &= " AND FMSBILLHEAD.BILLNO BETWEEN '" & BILLNOF & "' AND '" & BILLNOT & "' " & Environment.NewLine
            Else
                sql1 &= ShowPostCon
            End If
            sql1 &= " AND FMSBILLHEAD.AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "' " & Environment.NewLine



            Command = New SqlCommand(sql1, connect)
            adapter = New SqlDataAdapter(Command)
            adapter.Fill(dataSt, "Data")
            WriteLog("1062 (GETDATA_SOURCERCPDETAIL) :" & sql1)
        Catch ex As Exception
            WriteLog("Error 749 (GETDATA_SOURCERCPDETAIL) :" & ex.Message & sql1)
        End Try
        connect.Close()
        Return dataSt.Tables("Data")

    End Function

    Public Shared Function GETDATA_OPENRCPDETAIL(ByVal IDCUST As String, ByVal RCPNO As String) As DataTable
        Connection.Openconnect("BILL", connect)
        Dim sql1 As String = ""
        Dim dataSt = New DataSet()
        Dim DBSRC = MAIN.txtDBSOURCE.Text.TrimEnd.TrimEnd
        Try

            sql1 = "SELECT" & Environment.NewLine

            sql1 &= " FMSRCPHEAD.IDCUST " & Environment.NewLine
            sql1 &= ",FMSRCPHEAD.RCPNO " & Environment.NewLine
            sql1 &= ",FMSRCPHEAD.RCPSEQ " & Environment.NewLine
            sql1 &= ",FMSRCPDETAIL.INVNO AS IDINVC " & Environment.NewLine
            sql1 &= ",SUBSTRING(CAST(FMSRCPDETAIL.INVDATE AS CHAR),7,2) + '/' + SUBSTRING(CAST(FMSRCPDETAIL.INVDATE AS CHAR),5,2) + '/' + SUBSTRING(CAST(FMSRCPDETAIL.INVDATE AS CHAR),1,4)  AS INVDATE " & Environment.NewLine
            sql1 &= ",SUBSTRING(CAST(FMSRCPDETAIL.DUEDATE AS CHAR),7,2) + '/' + SUBSTRING(CAST(FMSRCPDETAIL.DUEDATE AS CHAR),5,2) + '/' + SUBSTRING(CAST(FMSRCPDETAIL.DUEDATE AS CHAR),1,4)  AS DUEDATE " & Environment.NewLine
            sql1 &= ",FMSRCPDETAIL.UNITPRICE AS UNITPRICE " & Environment.NewLine
            sql1 &= ",FMSRCPDETAIL.VATAMT AS VATAMT " & Environment.NewLine
            sql1 &= ",ISNULL(FMSRCPDETAIL.NETAMT, 0)  AS RCPAMT " & Environment.NewLine
            sql1 &= ", ISNULL(FMSRCPDETAIL.AMTOUTSTAND, 0)  AS AMTOUTSTAND --> CALCURATE   " & Environment.NewLine
            sql1 &= ", FMSRCPDETAIL.NETAMT AS NETAMT --> CALCURATE  " & Environment.NewLine
            sql1 &= ", FMSRCPDETAIL.AMT AS AMT --> AROBL.AROBL.AMTDUETC  " & Environment.NewLine
            sql1 &= ", 'False' AS CHECK_0 --> KEY-IN " & Environment.NewLine
            sql1 &= " , CAST(FMSRCPDETAIL.STA_0 AS nchar(1)) AS STA_0 --> KEY-IN " & Environment.NewLine
            sql1 &= " , FMSRCPDETAIL.RCPDTEXT1 AS RCPDTEXT1--> KEY-IN " & Environment.NewLine
            sql1 &= " , FMSRCPDETAIL.RCPDTEXT2 AS RCPDTEXT2--> KEY-IN " & Environment.NewLine
            sql1 &= " , FMSRCPDETAIL.RCPDTEXT3 AS RCPDTEXT3--> KEY-IN " & Environment.NewLine
            sql1 &= " , FMSRCPDETAIL.RCPDTEXT4 AS RCPDTEXT4--> KEY-IN " & Environment.NewLine
            sql1 &= " , FMSRCPDETAIL.RCPDTEXT5 AS RCPDTEXT5--> KEY-IN " & Environment.NewLine
            sql1 &= " , FMSRCPDETAIL.RCPDTEXT6 AS RCPDTEXT6--> KEY-IN " & Environment.NewLine
            sql1 &= " , FMSRCPDETAIL.RCPDTEXT7 AS RCPDTEXT7--> KEY-IN " & Environment.NewLine
            sql1 &= " , FMSRCPDETAIL.RCPDTEXT8 AS RCPDTEXT8--> KEY-IN " & Environment.NewLine
            sql1 &= " , FMSRCPDETAIL.RCPDTEXT9 AS RCPDTEXT9--> KEY-IN " & Environment.NewLine
            sql1 &= " , FMSRCPDETAIL.RCPDTEXT10 AS RCPDTEXT10--> KEY-IN " & Environment.NewLine
            sql1 &= " , FMSRCPDETAIL.VAT AS VAT" & Environment.NewLine
            sql1 &= " , FMSRCPDETAIL.BILLNO AS BILLNO" & Environment.NewLine

            sql1 &= " FROM FMSRCPHEAD" & Environment.NewLine
            sql1 &= " LEFT OUTER JOIN FMSRCPDETAIL ON FMSRCPDETAIL.RCPNO = FMSRCPHEAD.RCPNO And FMSRCPDETAIL.RCPSEQ = FMSRCPHEAD.RCPSEQ " & Environment.NewLine
            sql1 &= " AND FMSRCPDETAIL.IDCUST = FMSRCPHEAD.IDCUST     " & Environment.NewLine

            sql1 &= " WHERE FMSRCPHEAD.IDCUST = '" & IDCUST & "' " & Environment.NewLine
            sql1 &= " AND FMSRCPHEAD.RCPNO  ='" & RCPNO & "'" & Environment.NewLine
            sql1 &= " AND FMSRCPHEAD.AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "' " & Environment.NewLine
            Command = New SqlCommand(sql1, connect)
            adapter = New SqlDataAdapter(Command)
            adapter.Fill(dataSt, "Data")

        Catch ex As Exception
            WriteLog("Error 800 (GETDATA_OPENRCPDETAIL) :" & ex.Message & sql1)
        End Try
        connect.Close()
        Return dataSt.Tables("Data")

    End Function

    Public Shared Function GETDATA_REVRCP(ByVal IDCUST As String, ByVal RCPF As String, ByVal RCPT As String, Optional ByVal ShowPostCon As String = Nothing) As DataTable
        Connection.Openconnect("BILL", connect)
        Dim sql1 As String = ""
        Dim dataSt = New DataSet()
        Dim DBBILL = MAIN.txtDBBILL.Text.TrimEnd
        Try
            sql1 = "SELECT FMSRCPHEAD.RCPNO,FMSRCPHEAD.IDCUST,'' AS CUSTNAME," & Environment.NewLine
            sql1 &= "SUBSTRING(CAST(FMSRCPHEAD.RECEIVEDATE AS CHAR),7,2) + '/' + SUBSTRING(CAST(FMSRCPHEAD.RECEIVEDATE AS CHAR),5,2) + '/' + SUBSTRING(CAST(FMSRCPHEAD.RECEIVEDATE AS CHAR),1,4) AS RECEIVEDATE," & Environment.NewLine
            sql1 &= "SUBSTRING(CAST(FMSRCPHEAD.PAYDATE AS CHAR),7,2) + '/' + SUBSTRING(CAST(FMSRCPHEAD.PAYDATE AS CHAR),5,2) + '/' + SUBSTRING(CAST(FMSRCPHEAD.PAYDATE AS CHAR),1,4) AS PAYDATE,'' AS BILLNO,'' AS INVNO,   " & Environment.NewLine
            sql1 &= "'False' AS CHECK_0 , FMSRCPHEAD.NETAMT,FMSRCPHEAD.AMT, 0 AS AMTOUTSTAND " & Environment.NewLine
            sql1 &= ",CASE WHEN IMPORTCB = 'Y' THEN 'Yes' ELSE 'No' END AS IMPORTCB " & Environment.NewLine
            sql1 &= "FROM FMSRCPHEAD" & Environment.NewLine
            sql1 &= "--INNER JOIN FMSRCPDETAIL ON FMSRCPDETAIL.RCPSEQ = FMSRCPHEAD.RCPSEQ AND FMSRCPDETAIL.RCPNO = FMSRCPHEAD.RCPNO" & Environment.NewLine
            sql1 &= "WHERE FMSRCPHEAD.IDCUST = '" & IDCUST & "' " & Environment.NewLine
            If RCPT.TrimEnd = "" Then

                sql1 &= " AND  FMSRCPHEAD.RCPNO BETWEEN  '" & RCPF & "' AND  'ZZZZZZ' "
            Else
                sql1 &= " AND  FMSRCPHEAD.RCPNO BETWEEN  '" & RCPF & "' AND  '" & RCPT & "' "
            End If

            sql1 &= "AND FMSRCPHEAD.STA_0 = 2" & Environment.NewLine
            sql1 &= " AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "' " & Environment.NewLine
            Command = New SqlCommand(sql1, connect)
            adapter = New SqlDataAdapter(Command)
            adapter.Fill(dataSt, "Data")

        Catch ex As Exception
            WriteLog("Error 835 (GETDATA_RCPHEADER) :" & ex.Message & sql1)
        End Try
        connect.Close()
        Return dataSt.Tables("Data")

    End Function

    Public Shared Function GETDATA_SUMRCPAMTOUTSTAND(ByVal BILLNO As String, ByVal INVNO As String) As Decimal
        Dim vVALUE As Decimal
        Connection.Openconnect("BILL", connect)
        Dim sql1 As String

        sql1 = "SELECT SUM(AMTOUTSTAND) AS VALUE FROM FMSRCPDETAIL WHERE BILLNO = '" & BILLNO & "' AND INVNO = '" & INVNO & "' AND STA_0 <> 2  " & Environment.NewLine
        sql1 &= " AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "' " & Environment.NewLine
        Dim cmd As SqlCommand = New SqlCommand(sql1, connect)
        Dim result As SqlDataReader = cmd.ExecuteReader()

        While result.Read()

            If IsDBNull(result("VALUE")) = True Then
                vVALUE = 0
            Else
                vVALUE = result("VALUE")
            End If
        End While

        Return vVALUE
    End Function

    Public Shared Function GET_RCPSEQ(ByVal RCPNO As String) As String
        Dim RCPSEQ As String = ""
        Connection.Openconnect("BILL", connect)
        Dim sql1 As String = ""

        sql1 &= "SELECT TOP 1 * FROM FMSRCPHEAD WHERE RCPNO = '" & RCPNO & "'  "
        Dim cmd As SqlCommand = New SqlCommand(sql1, connect)
        Dim result As SqlDataReader = cmd.ExecuteReader()

        While result.Read()
            RCPSEQ = result("RCPSEQ").ToString.TrimEnd
            If RCPSEQ = "" Or IsDBNull(RCPSEQ) = True Then
                RCPSEQ = ""
            Else
                RCPSEQ = RCPSEQ
            End If
        End While
        connect.Close()
        Return RCPSEQ
    End Function

    Public Shared Function GET_RCPTYPE(ByVal RCPNO As String) As String
        Dim RCPSEQ As String = ""
        Connection.Openconnect("BILL", connect)
        Dim sql1 As String = ""

        sql1 &= "SELECT TOP 1 * FROM FMSRCPHEAD WHERE RCPNO = '" & RCPNO & "'  "
        Dim cmd As SqlCommand = New SqlCommand(sql1, connect)
        Dim result As SqlDataReader = cmd.ExecuteReader()

        While result.Read()
            RCPSEQ = result("TAXINV").ToString.TrimEnd
            If RCPSEQ = "" Or IsDBNull(RCPSEQ) = True Then
                RCPSEQ = ""
            Else
                RCPSEQ = RCPSEQ
            End If
        End While
        connect.Close()
        Return RCPSEQ
    End Function

#Region "IMPORT CB"
    Public Shared Function GET_ACCTIDSRC(ByVal SRCECODE As String) As String
        Dim ACCTID_CLEARING As String = ""
        Connection.Openconnect("Source", connect)
        Dim sql1 As String = ""

        sql1 &= "SELECT TOP 1 * FROM CBSRCE WHERE SRCECODE = '" & SRCECODE & "'  "
        Dim cmd As SqlCommand = New SqlCommand(sql1, connect)
        Dim result As SqlDataReader = cmd.ExecuteReader()

        While result.Read()
            ACCTID_CLEARING = result("ACCTDFLT").ToString.TrimEnd
            If ACCTID_CLEARING = "" Or IsDBNull(ACCTID_CLEARING) = True Then
                ACCTID_CLEARING = ""
            Else
                ACCTID_CLEARING = ACCTID_CLEARING
            End If
        End While
        connect.Close()
        Return ACCTID_CLEARING
    End Function

    Public Shared Function GET_PAYTYPE(ByVal RCPNO As String) As String
        Dim PAYTYPE As String = ""
        Connection.Openconnect("DB", connect)
        Dim sql1 As String = ""

        sql1 &= "SELECT TOP 1 * FROM FMSRCPHEAD WHERE RCPNO = '" & RCPNO & "'  "
        Dim cmd As SqlCommand = New SqlCommand(sql1, connect)
        Dim result As SqlDataReader = cmd.ExecuteReader()

        While result.Read()
            PAYTYPE = result("PAYTYPE").ToString.TrimEnd
            If PAYTYPE = "" Or IsDBNull(PAYTYPE) = True Then
                PAYTYPE = ""
            Else
                PAYTYPE = PAYTYPE
            End If
        End While
        connect.Close()
        Return PAYTYPE
    End Function

    Public Shared Function GETDATA_FMSRCPDETAIL(ByVal sql1 As String) As DataTable
        Connection.Openconnect("DB", connect)
        Dim dataSt = New DataSet()
        Try
            Command = New SqlCommand(sql1, connect)
            adapter = New SqlDataAdapter(Command)
            adapter.Fill(dataSt, "Data")
        Catch ex As Exception
            WriteLog("Error 915 (GETDATA_FMSRCPDETAIL) : " & ex.Message & sql1)
        End Try
        connect.Close()
        Return dataSt.Tables("Data")

    End Function

    Public Shared Function GET_BANKBATCH(ByVal RCPNO As String) As String
        Dim PAYTYPE As String = ""
        Connection.Openconnect("DB", connect)
        Dim sql1 As String = ""

        sql1 &= "SELECT TOP 1 * FROM FMSRCPHEAD WHERE RCPNO = '" & RCPNO & "'  "
        Dim cmd As SqlCommand = New SqlCommand(sql1, connect)
        Dim result As SqlDataReader = cmd.ExecuteReader()

        While result.Read()
            PAYTYPE = result("BANKBATCH").ToString.TrimEnd
            If PAYTYPE = "" Or IsDBNull(PAYTYPE) = True Then
                PAYTYPE = ""
            Else
                PAYTYPE = PAYTYPE
            End If
        End While
        connect.Close()
        Return PAYTYPE
    End Function

    Public Shared Function GET_CBDATE(ByVal RCPNO As String) As String
        Dim PAYTYPE As String = ""
        Connection.Openconnect("DB", connect)
        Dim sql1 As String = ""

        sql1 &= "SELECT TOP 1 * FROM FMSRCPHEAD WHERE RCPNO = '" & RCPNO & "'  "
        Dim cmd As SqlCommand = New SqlCommand(sql1, connect)
        Dim result As SqlDataReader = cmd.ExecuteReader()

        While result.Read()
            PAYTYPE = result("CBDATE").ToString.TrimEnd
            If PAYTYPE = "" Or IsDBNull(PAYTYPE) = True Then
                PAYTYPE = ""
            Else
                PAYTYPE = PAYTYPE
            End If
        End While
        connect.Close()
        Return PAYTYPE
    End Function

    Public Shared Function GET_CONFIGCB() As DataTable

        Connection.Openconnect("BILL", connect)
        Dim sql1 As String = ""
        Dim dataSt = New DataSet()
        Try
            sql1 = "SELECT * " & vbCrLf
            sql1 &= "FROM FMSMASTERIMPORT" & vbCrLf
            sql1 &= "WHERE COMP = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "'"
            Command = New SqlCommand(sql1, connect)
            adapter = New SqlDataAdapter(Command)
            adapter.Fill(dataSt, "Data")
        Catch ex As Exception
            WriteLog("Error 955 (GETDATA_RUNNO) :" & ex.Message & sql1)
        End Try
        connect.Close()
        Return dataSt.Tables("Data")

    End Function

#End Region

#End Region

#Region "SEARCH"
    Public Shared Function GETDATA_SEARCH(ByVal sql1 As String) As DataTable
        Connection.Openconnect("Source", connect)
        Dim dataSt = New DataSet()
        Try
            Command = New SqlCommand(sql1, connect)
            adapter = New SqlDataAdapter(Command)
            adapter.Fill(dataSt, "Data")
        Catch ex As Exception
            WriteLog("Error 977 (GETDATA_SEARCH) : " & ex.Message & sql1)
        End Try
        connect.Close()
        Return dataSt.Tables("Data")

    End Function

    Public Shared Function GETDATA_SEARCHRCP(ByVal sql1 As String) As DataTable

        Connection.Openconnect("BILL", connect)

        Dim dataSt = New DataSet()
        Try
            Command = New SqlCommand(sql1, connect)
            adapter = New SqlDataAdapter(Command)
            adapter.Fill(dataSt, "Data")
        Catch ex As Exception
            WriteLog("Error 994 (GETDATA_SEARCHRCP) : " & ex.Message & sql1)
        End Try
        connect.Close()
        Return dataSt.Tables("Data")

    End Function

    Public Shared Function GETDATA_SEARCHBANK(ByVal sql1 As String) As DataTable
        Connection.Openconnect("Source", connect)
        Dim dataSt = New DataSet()
        Try
            Command = New SqlCommand(sql1, connect)
            adapter = New SqlDataAdapter(Command)
            adapter.Fill(dataSt, "Data")
        Catch ex As Exception
            WriteLog("Error 1009 (GETDATA_SEARCHBANK) : " & ex.Message & sql1)
        End Try
        connect.Close()
        Return dataSt.Tables("Data")

    End Function
#End Region

#Region "REPORT"
    Public Shared Sub ALTERVIEW_FMSREPORTSTATUS(ByVal CUSTF As String, ByVal CUSTT As String, ByVal DATEF As String, ByVal DATET As String)
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
            If dtchkTemp.Rows.Count <> 0 Then
                str = "ALTER VIEW FMSREPORTSTATUS AS 
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
LEFT OUTER JOIN FMSBILLDETAIL ON ARIBH.IDINVC = FMSBILLDETAIL.INVNO AND FMSBILLDETAIL.AUDTORG = ARIBH.AUDTORG AND FMSBILLDETAIL.STA_0 NOT IN (4,5) 
LEFT OUTER JOIN FMSBILLHEAD ON FMSBILLHEAD.IDCUST = FMSBILLDETAIL.IDCUST AND FMSBILLHEAD.BILLNO = FMSBILLDETAIL.BILLNO AND FMSBILLHEAD.AUDTORG = FMSBILLDETAIL.AUDTORG
LEFT OUTER JOIN FMSCSCOMMASTER ON ARIBH.AUDTORG = FMSCSCOMMASTER.AUDTORG
LEFT OUTER JOIN " & SRCDB & ".dbo.ARCUS ON ARCUS.IDCUST = ARIBH.IDCUST
WHERE ARIBH.IDCUST BETWEEN '" & CUSTF & "' AND '" & CUSTT & "'
AND CAST(ARIBH.DATEINVC AS nvarchar(20)) BETWEEN '" & DATEF & "' AND '" & DATET & " '  
) "

                Dim cmd1 As SqlCommand = New SqlCommand(str, connect)
                cmd1.ExecuteNonQuery()
            End If
            connect.Close()

        Catch ex As Exception
            WriteLog("Error 1053:" & ex.Message & STREXIST & " ; " & str)
        End Try
    End Sub

#End Region


End Class
