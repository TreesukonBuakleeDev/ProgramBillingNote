Imports System.Xml
Imports Excel = Microsoft.Office.Interop.Excel


Public Class IMPORTSAGE

#Region "GEN EXCEL"

    Public Shared Sub GenEXCEL(ByVal dt As DataTable)
        Try

            Try
                Dim xlApp As Excel.Application
                Dim xlWorkBook As Excel.Workbook
                Dim xlWorkSheet As Excel.Worksheet
                Dim status As Boolean = False
                Dim pathExport As String
                Dim IDCUST As String = ""
                Dim OPTFD_HEAD As String = ""
                Dim OPTFD_DETAIL As String = ""

                Dim dtCHK As DataTable = New DataTable()
                Dim drRowss As DataRow()

                drRowss = dt.[Select]("CHECK_0 = 'True'")
                dtCHK = dt.Clone

                If drRowss Is Nothing = False Then
                    For Each ROWSS As DataRow In drRowss
                        dtCHK.ImportRow(ROWSS)
                    Next
                End If

                Dim DTCB As DataTable = New DataTable()

                DTCB = MASTER.GET_CONFIGCB()

                'CONFIG CASHBOOK
                If DTCB.Rows.Count > 0 Then
                    OPTFD_HEAD = DTCB.Rows(0).Item("OPTFD_HEAD").ToString
                    OPTFD_DETAIL = DTCB.Rows(0).Item("OPTFD_DETAIL").ToString
                Else
                    MessageBox.Show("Please Check Setting Import cash book Or Connection")
                    Exit Try
                End If


                If dtCHK.Rows.Count > 0 Then

                    System.IO.File.Copy(Application.StartupPath & "\Template\CBImport.xls", Application.StartupPath & "\IMPORTCB\CBImport.xls", True)
                    If Application.StartupPath.EndsWith("\") = True Then
                        pathExport = Application.StartupPath & "IMPORTCB\CBImport.xls"
                    Else
                        pathExport = Application.StartupPath & "\IMPORTCB\CBImport.xls"
                    End If

                    xlApp = New Excel.Application
                    xlApp.Visible = True
                    xlApp.WindowState = Excel.XlWindowState.xlMinimized
                    xlWorkBook = xlApp.Workbooks.Open(pathExport)


                    For Each xlWorkSheet In xlWorkBook.Worksheets
                        Select Case xlWorkSheet.Name
                            Case "Batch_Header"
                                '    '>> Concern case Header more than 1 tranaction <<
                                Batch_Header(xlWorkSheet, dtCHK)

                            Case "Batch_Detail"

                                Batch_Detail(xlWorkSheet, dtCHK) 'send >>IDCUST 

                                'Case "Batch_Miscellaneous"
                                '    Batch_Miscellaneous(xlWorkSheet)

                            Case "Batch_Sub_Detail"

                                Batch_Sub_Detail(xlWorkSheet, dtCHK)

                            Case "Batch_Header_Optional_Fields"
                                If OPTFD_HEAD.TrimEnd = "/" Then
                                    Batch_Header_Optional_Fields(xlWorkSheet, dtCHK)
                                Else

                                End If

                            Case "Batch_Detail_Optional_Fields"
                                If OPTFD_DETAIL.TrimEnd = "/" Then
                                    Batch_Detail_Optional_Fields(xlWorkSheet, dtCHK)
                                Else

                                End If

                            Case Else

                        End Select
                    Next

                    xlWorkBook.Save()
                    xlWorkBook.Close()
                    xlApp.Quit()
                End If


            Catch ex As Exception
                Call WriteLog("Error 83: " & ex.Message)
            End Try

        Catch ex As Exception
            WriteLog("Error 87: GenEXCEL" & ex.Message)
        End Try
    End Sub
    Public Shared Sub Batch_Header(ByRef xlWorkSheet As Excel.Worksheet, ByVal dtHead As DataTable)
        Try
            'Write Excel
            For i = 0 To dtHead.Rows.Count - 1
                Dim BATCHID As String = Format(i + 1, "000000")
                Dim ENTRYNO As String = Format(1, "00000")
                Dim ENTRYTYPE As String = 2
                Dim REFERENCE As String = dtHead.Rows(i).Item("RCPNO").ToString
                Dim DATECB As Date

                Dim vDATECB = MASTER.GET_CBDATE(REFERENCE)

                DATECB = vDATECB.ToString.Substring(6, 2) & "/" & vDATECB.ToString.Substring(4, 2) & "/" & vDATECB.ToString.Substring(0, 4)
                Dim MISCCODE As String = "'" & dtHead.Rows(i).Item("IDCUST").ToString
                Dim TEXTDESC As String = dtHead.Rows(i).Item("RCPNO").ToString & " - " & dtHead.Rows(i).Item("CUSTNAME").ToString
                Dim TOTAMOUNT As String = dtHead.Rows(i).Item("AMOUNT").ToString
                Dim CUSTCHQNO As String = dtHead.Rows(i).Item("RCPNO").ToString
                Dim SWPOSTED As String = "FALSE"



                xlWorkSheet.Cells(2 + i, 1) = "'" & BATCHID
                xlWorkSheet.Cells(2 + i, 2) = "'" & ENTRYNO
                xlWorkSheet.Cells(2 + i, 3) = ENTRYTYPE
                xlWorkSheet.Cells(2 + i, 4) = REFERENCE
                xlWorkSheet.Cells(2 + i, 5) = DATECB
                xlWorkSheet.Cells(2 + i, 6) = MISCCODE
                xlWorkSheet.Cells(2 + i, 7) = TEXTDESC
                xlWorkSheet.Cells(2 + i, 8) = TOTAMOUNT
                xlWorkSheet.Cells(2 + i, 9) = CUSTCHQNO
                xlWorkSheet.Cells(2 + i, 10) = SWPOSTED
            Next


        Catch ex As Exception
            WriteLog("Error 120 : Batch_Header" & ex.Message)
        End Try

    End Sub
    Public Shared Sub Batch_Detail(ByRef xlWorkSheet As Excel.Worksheet, ByVal dtHead As DataTable)
        Try
            Dim rnd As Integer

            Dim DTDETAIL As DataTable = New DataTable

            'PROCESS DETAIL 
            DTDETAIL = COL_DTDETAIL(DTDETAIL)

            For j = 0 To dtHead.Rows.Count - 1

                Dim RCPNO As String = dtHead.Rows(j).Item("RCPNO").ToString
                Dim BANKCODE As String = MASTER.GET_BANKBATCH(RCPNO)
                Dim TEXTDESC As String = BANKCODE & "-" & dtHead.Rows(j).Item("RCPNO").ToString
                Dim TEXTDESC_CNDN As String = dtHead.Rows(j).Item("RCPNO").ToString & "-" & dtHead.Rows(j).Item("CUSTNAME").ToString
                Select Case MASTER.GET_PAYTYPE(RCPNO)
                    Case "1"
                        TEXTDESC = TEXTDESC & ";Cash" & ";;" & RCPNO
                    Case "2"
                        TEXTDESC = TEXTDESC & ";Cheque" & ";;" & RCPNO
                    Case "3"
                        TEXTDESC = TEXTDESC & ";Credit Card" & ";;" & RCPNO
                    Case "4"
                        TEXTDESC = TEXTDESC & ";Transfer" & ";;" & RCPNO
                    Case Else
                        TEXTDESC = TEXTDESC
                End Select

                Dim SRCCODE_DN As String = IIf(FrmIMPORTCB.txtDNSRCCODE.Text.TrimEnd = "", "OPVT", FrmIMPORTCB.txtDNSRCCODE.Text.TrimEnd)
                Dim SRCCODE_CN As String = IIf(FrmIMPORTCB.txtCNSRCCODE.Text.TrimEnd = "", "OPVU", FrmIMPORTCB.txtCNSRCCODE.Text.TrimEnd)
                Dim ACCTID As String = MASTER.GET_ACCTIDSRC("AR")
                Dim ACCCID_DN As String = MASTER.GET_ACCTIDSRC(SRCCODE_DN)
                Dim ACCTID_CN As String = MASTER.GET_ACCTIDSRC(SRCCODE_CN)
                Dim RCPAMT As String = dtHead.Rows(j).Item("AMOUNT").ToString
                'Cal VAT 

                Dim CALVAT As String = RCPAMT - ((RCPAMT * 100) / 107)
                Dim DOCNBER = dtHead.Rows(j).Item("RCPNO").ToString

                DTDETAIL.Rows.Add(Format(j + 1, "000000"), Format(1, "00000"), "0000000" & "200", "AR", TEXTDESC, ACCTID, RCPAMT, 0, RCPAMT, 0, RCPNO)
                DTDETAIL.Rows.Add(Format(j + 1, "000000"), Format(1, "00000"), "0000000" & "400", SRCCODE_DN, TEXTDESC_CNDN, ACCCID_DN, CALVAT, 0, CALVAT, 0, RCPNO)
                DTDETAIL.Rows.Add(Format(j + 1, "000000"), Format(1, "00000"), "0000000" & "600", SRCCODE_CN, TEXTDESC_CNDN, ACCTID_CN, (CALVAT * -1), 0, 0, CALVAT, RCPNO)
            Next

            'WRITE EXCEL 
            For i = 0 To DTDETAIL.Rows.Count - 1
                Dim BATCHID As String = DTDETAIL.Rows(i).Item("BATCHID").ToString.TrimEnd
                Dim ENTRYNO As String = DTDETAIL.Rows(i).Item("ENTRYNO").ToString.TrimEnd
                Dim DETAILNO As String = DTDETAIL.Rows(i).Item("DETAILNO").ToString.TrimEnd
                Dim SRCCODE As String = DTDETAIL.Rows(i).Item("SRCECODE").ToString.TrimEnd
                Dim TEXTDESC As String = DTDETAIL.Rows(i).Item("TEXTDESC").ToString.TrimEnd
                Dim ACCTID As String = DTDETAIL.Rows(i).Item("ACCTID").ToString.TrimEnd
                Dim DTLAMOUNT As String = DTDETAIL.Rows(i).Item("DTLAMOUNT").ToString.TrimEnd
                Dim QUANTITY As String = DTDETAIL.Rows(i).Item("QUANTITY").ToString.TrimEnd
                Dim DEBITAMT As String = DTDETAIL.Rows(i).Item("DEBITAMT").ToString.TrimEnd
                Dim CREDITAMT As String = DTDETAIL.Rows(i).Item("CREDITAMT").ToString.TrimEnd
                Dim DOCNUMBER As String = DTDETAIL.Rows(i).Item("DOCNUMBER").ToString.TrimEnd

                If i = 0 Then
                    rnd = 1
                    xlWorkSheet.Cells(2 + i, 1) = "'" & BATCHID
                    xlWorkSheet.Cells(2 + i, 2) = "'" & ENTRYNO
                    xlWorkSheet.Cells(2 + i, 3) = "'" & DETAILNO
                    xlWorkSheet.Cells(2 + i, 4) = SRCCODE
                    xlWorkSheet.Cells(2 + i, 5) = TEXTDESC
                    xlWorkSheet.Cells(2 + i, 6) = ACCTID
                    xlWorkSheet.Cells(2 + i, 7) = DTLAMOUNT
                    xlWorkSheet.Cells(2 + i, 8) = QUANTITY

                    xlWorkSheet.Cells(2 + i, 9) = DEBITAMT
                    xlWorkSheet.Cells(2 + i, 10) = CREDITAMT
                    xlWorkSheet.Cells(2 + i, 11) = DOCNUMBER
                Else

                    xlWorkSheet.Cells(2 + i, 1) = "'" & BATCHID
                    xlWorkSheet.Cells(2 + i, 2) = "'" & ENTRYNO
                    xlWorkSheet.Cells(2 + i, 3) = "'" & DETAILNO
                    xlWorkSheet.Cells(2 + i, 4) = SRCCODE
                    xlWorkSheet.Cells(2 + i, 5) = TEXTDESC
                    xlWorkSheet.Cells(2 + i, 6) = ACCTID
                    xlWorkSheet.Cells(2 + i, 7) = DTLAMOUNT
                    xlWorkSheet.Cells(2 + i, 8) = QUANTITY

                    xlWorkSheet.Cells(2 + i, 9) = DEBITAMT
                    xlWorkSheet.Cells(2 + i, 10) = CREDITAMT
                    xlWorkSheet.Cells(2 + i, 11) = DOCNUMBER

                End If
                rnd = rnd + 1
            Next
        Catch ex As Exception
            WriteLog("Error 214: Batch_Detail" & ex.Message)
        End Try
    End Sub

    Public Shared Sub Batch_Sub_Detail(ByRef xlWorkSheet As Excel.Worksheet, ByVal dtHead As DataTable)
        Try
            Dim dttemp As DataTable = New DataTable()
            Dim RCPNO As String
            Dim str As String = "SELECT * FROM FMSRCPDETAIL WHERE RCPNO IN "
            Dim strFilter As String = ""
            For i = 0 To dtHead.Rows.Count - 1
                RCPNO = dtHead.Rows(i).Item("RCPNO").ToString
                Select Case i
                    Case 0
                        strFilter = strFilter & "('" & RCPNO & "'" & Environment.NewLine
                    Case dtHead.Rows.Count - 1
                        strFilter = strFilter & ",'" & RCPNO & "'" & Environment.NewLine
                    Case Else
                        strFilter = strFilter & ",'" & RCPNO & "'" & Environment.NewLine
                End Select
            Next

            str = str & strFilter
            str = str & ") ORDER BY RCPSEQ "
            dttemp = MASTER.GETDATA_FMSRCPDETAIL(str)

            Dim CNT As Decimal
            For i = 0 To dttemp.Rows.Count - 1
                Dim RCPSEQ_BF As String

                If i = 0 Then
                    RCPSEQ_BF = ""

                Else
                    RCPSEQ_BF = dttemp.Rows(i - 1).Item("RCPSEQ").ToString
                End If

                Dim RCPSEQ As String = dttemp.Rows(i).Item("RCPSEQ").ToString

                Dim BATCHNO As Decimal
                Dim ENTRYNO As Decimal
                Dim DETAILNO As Decimal

                If RCPSEQ = RCPSEQ_BF Then
                    CNT = CNT
                    DETAILNO = Format(200, "0000000000")
                Else
                    CNT = CNT + 1
                    DETAILNO = Format(200, "0000000000")
                End If

                BATCHNO = Format((CNT), "000000")
                ENTRYNO = Format(1, "00000")

                WriteLog(dttemp.Rows(i).Item("INVDATE").ToString.Substring(6, 2) & "/" & dttemp.Rows(i).Item("INVDATE").ToString.Substring(4, 2) & "/" & dttemp.Rows(i).Item("INVDATE").ToString.Substring(0, 4))

                xlWorkSheet.Cells(2 + i, 1) = "'" & Format((BATCHNO), "000000")
                xlWorkSheet.Cells(2 + i, 2) = "'" & Format(ENTRYNO, "00000")
                xlWorkSheet.Cells(2 + i, 3) = "'" & Format(DETAILNO, "0000000000")
                xlWorkSheet.Cells(2 + i, 4) = "'" & dttemp.Rows(i).Item("INVNO").ToString.TrimEnd
                xlWorkSheet.Cells(2 + i, 5) = 1
                xlWorkSheet.Cells(2 + i, 6) = "'000001"
                xlWorkSheet.Cells(2 + i, 7) = 1
                xlWorkSheet.Cells(2 + i, 8) = dttemp.Rows(i).Item("RCPAMT").ToString.TrimEnd
                xlWorkSheet.Cells(2 + i, 9) = 0
                xlWorkSheet.Cells(2 + i, 10) = dttemp.Rows(i).Item("INVDATE").ToString.Substring(6, 2) & "/" & dttemp.Rows(i).Item("INVDATE").ToString.Substring(4, 2) & "/" & dttemp.Rows(i).Item("INVDATE").ToString.Substring(0, 4)
                xlWorkSheet.Cells(2 + i, 11) = "'" & dttemp.Rows(i).Item("IDCUST").ToString.TrimEnd
                xlWorkSheet.Cells(2 + i, 12) = ""
                xlWorkSheet.Cells(2 + i, 13) = "FALSE"
                xlWorkSheet.Cells(2 + i, 14) = "FALSE"
                xlWorkSheet.Cells(2 + i, 15) = 2


            Next
        Catch ex As Exception
            WriteLog("Error 288: Batch_Sub_Detail" & ex.Message)
        End Try
    End Sub

    Public Shared Sub Batch_Header_Optional_Fields(ByRef xlWorkSheet As Excel.Worksheet, ByVal dtHead As DataTable)
        Try
            For i = 0 To dtHead.Rows.Count - 1
                If i = 0 Then
                    xlWorkSheet.Cells(2 + i, 1) = "'" & Format((i + 1), "000000")
                    xlWorkSheet.Cells(2 + i, 2) = "'" & Format(1, "00000")
                    xlWorkSheet.Cells(2 + i, 3) = "VOUCHER"
                    xlWorkSheet.Cells(2 + i, 4) = ""
                    xlWorkSheet.Cells(2 + i, 5) = "1"
                    xlWorkSheet.Cells(2 + i, 6) = "60"
                    xlWorkSheet.Cells(2 + i, 7) = "0"
                    xlWorkSheet.Cells(2 + i, 8) = "FALSE"
                    xlWorkSheet.Cells(2 + i, 9) = "FALSE"
                    xlWorkSheet.Cells(2 + i, 10) = "1"
                    xlWorkSheet.Cells(2 + i, 11) = ""
                    xlWorkSheet.Cells(2 + i, 12) = ""
                    xlWorkSheet.Cells(2 + i, 13) = "0"
                    xlWorkSheet.Cells(2 + i, 14) = "0"
                    xlWorkSheet.Cells(2 + i, 15) = "0"
                    xlWorkSheet.Cells(2 + i, 16) = "FALSE"
                    xlWorkSheet.Cells(2 + i, 17) = ""
                    xlWorkSheet.Cells(2 + i, 18) = "00/01/1900"
                    xlWorkSheet.Cells(2 + i, 19) = "VOUCHER"
                    xlWorkSheet.Cells(2 + i, 20) = ""


                    'xlWorkSheet.Cells(2 + i + 1, 1) = "'" & Format((i + 1), "000000")
                    'xlWorkSheet.Cells(2 + i + 1, 2) = "'" & Format(1, "00000")
                    'xlWorkSheet.Cells(2 + i + 1, 3) = "VOUCHER"
                    'xlWorkSheet.Cells(2 + i + 1, 4) = ""
                    'xlWorkSheet.Cells(2 + i + 1, 5) = "1"
                    'xlWorkSheet.Cells(2 + i + 1, 6) = "60"
                    'xlWorkSheet.Cells(2 + i + 1, 7) = "0"
                    'xlWorkSheet.Cells(2 + i + 1, 8) = "FALSE"
                    'xlWorkSheet.Cells(2 + i + 1, 9) = "FALSE"
                    'xlWorkSheet.Cells(2 + i + 1, 10) = "1"
                    'xlWorkSheet.Cells(2 + i + 1, 11) = ""
                    'xlWorkSheet.Cells(2 + i + 1, 12) = ""
                    'xlWorkSheet.Cells(2 + i + 1, 13) = "0"
                    'xlWorkSheet.Cells(2 + i + 1, 14) = "0"
                    'xlWorkSheet.Cells(2 + i + 1, 15) = "0"
                    'xlWorkSheet.Cells(2 + i + 1, 16) = "FALSE"
                    'xlWorkSheet.Cells(2 + i + 1, 17) = ""
                    'xlWorkSheet.Cells(2 + i + 1, 18) = "00/01/1900"
                    'xlWorkSheet.Cells(2 + i + 1, 19) = "VOUCHER"
                    'xlWorkSheet.Cells(2 + i + 1, 20) = ""
                Else
                    xlWorkSheet.Cells(2 + i + 1, 1) = "'" & Format((i + 1), "000000")
                    xlWorkSheet.Cells(2 + i + 1, 2) = "'" & Format(1, "00000")
                    xlWorkSheet.Cells(2 + i + 1, 3) = "VOUCHER"
                    xlWorkSheet.Cells(2 + i + 1, 4) = ""
                    xlWorkSheet.Cells(2 + i + 1, 5) = "1"
                    xlWorkSheet.Cells(2 + i + 1, 6) = "60"
                    xlWorkSheet.Cells(2 + i + 1, 7) = "0"
                    xlWorkSheet.Cells(2 + i + 1, 8) = "FALSE"
                    xlWorkSheet.Cells(2 + i + 1, 9) = "FALSE"
                    xlWorkSheet.Cells(2 + i + 1, 10) = "1"
                    xlWorkSheet.Cells(2 + i + 1, 11) = ""
                    xlWorkSheet.Cells(2 + i + 1, 12) = ""
                    xlWorkSheet.Cells(2 + i + 1, 13) = "0"
                    xlWorkSheet.Cells(2 + i + 1, 14) = "0"
                    xlWorkSheet.Cells(2 + i + 1, 15) = "0"
                    xlWorkSheet.Cells(2 + i + 1, 16) = "FALSE"
                    xlWorkSheet.Cells(2 + i + 1, 17) = ""
                    xlWorkSheet.Cells(2 + i + 1, 18) = "00/01/1900"
                    xlWorkSheet.Cells(2 + i + 1, 19) = "VOUCHER"
                    xlWorkSheet.Cells(2 + i + 1, 20) = ""


                    'xlWorkSheet.Cells(2 + i + 2, 1) = "'" & Format((i + 1), "000000")
                    'xlWorkSheet.Cells(2 + i + 2, 2) = "'" & Format(1, "00000")
                    'xlWorkSheet.Cells(2 + i + 2, 3) = "VOUCHER"
                    'xlWorkSheet.Cells(2 + i + 2, 4) = ""
                    'xlWorkSheet.Cells(2 + i + 2, 5) = "1"
                    'xlWorkSheet.Cells(2 + i + 2, 6) = "60"
                    'xlWorkSheet.Cells(2 + i + 2, 7) = "0"
                    'xlWorkSheet.Cells(2 + i + 2, 8) = "FALSE"
                    'xlWorkSheet.Cells(2 + i + 2, 9) = "FALSE"
                    'xlWorkSheet.Cells(2 + i + 2, 10) = "1"
                    'xlWorkSheet.Cells(2 + i + 2, 11) = ""
                    'xlWorkSheet.Cells(2 + i + 2, 12) = ""
                    'xlWorkSheet.Cells(2 + i + 2, 13) = "0"
                    'xlWorkSheet.Cells(2 + i + 2, 14) = "0"
                    'xlWorkSheet.Cells(2 + i + 2, 15) = "0"
                    'xlWorkSheet.Cells(2 + i + 2, 16) = "FALSE"
                    'xlWorkSheet.Cells(2 + i + 2, 17) = ""
                    'xlWorkSheet.Cells(2 + i + 2, 18) = "00/01/1900"
                    'xlWorkSheet.Cells(2 + i + 2, 19) = "VOUCHER"
                    'xlWorkSheet.Cells(2 + i + 2, 20) = ""
                End If

            Next
        Catch ex As Exception
            WriteLog("Error 385: Batch_Header_Optional_Fields" & ex.Message)
        End Try
    End Sub

    Public Shared Sub Batch_Detail_Optional_Fields(ByRef xlWorkSheet As Excel.Worksheet, ByVal dtHead As DataTable)

        Try


            Dim n As Integer = 1
                Dim r As Integer
                Dim rnd As Integer = 0

            Dim sign As Integer = 0

            For i = 0 To dtHead.Rows.Count - 1
                Dim RCPSEQ As String = dtHead.Rows(i).Item("RCPNO").ToString
                Dim batchno = 1

                Select Case i
                    Case 0
                        r = 0
                        Do While r >= 0 And r <= 4
                            Dim arrOPT(5) As String
                            arrOPT(0) = "TAXBASE"
                            arrOPT(1) = "TAXDATE"
                            arrOPT(2) = "TAXID"
                            arrOPT(3) = "TAXINVNO"
                            arrOPT(4) = "TAXNAME"

                            Dim arrOPTVal(5) As String

                            arrOPTVal(0) = "'0.000"
                            arrOPTVal(1) = "'00000000"
                            arrOPTVal(2) = ""
                            arrOPTVal(3) = ""
                            arrOPTVal(4) = ""

                            'xlWorkSheet.Cells(2 + r + rnd, 1) = batchno
                            'xlWorkSheet.Cells(2 + r + rnd, 2) = n
                            'xlWorkSheet.Cells(2 + r + rnd, 3) = 20
                            'xlWorkSheet.Cells(2 + r + rnd, 4) = arrOPT(r)
                            'xlWorkSheet.Cells(2 + r + rnd, 5) = ""
                            'xlWorkSheet.Cells(2 + r + rnd, 6) = "1"
                            'xlWorkSheet.Cells(2 + r + rnd, 7) = "60"


                            xlWorkSheet.Cells(2 + r + rnd, 1) = "'" & Format((i + 1), "000000")
                            xlWorkSheet.Cells(2 + r + rnd, 2) = "'" & Format(1, "00000")
                            xlWorkSheet.Cells(2 + r + rnd, 3) = "'" & Format(200, "0000000000")
                            xlWorkSheet.Cells(2 + r + rnd, 4) = arrOPT(r)
                            xlWorkSheet.Cells(2 + r + rnd, 5) = arrOPTVal(r)
                            xlWorkSheet.Cells(2 + r + rnd, 6) = "1"
                            xlWorkSheet.Cells(2 + r + rnd, 7) = "60"
                            xlWorkSheet.Cells(2 + r + rnd, 8) = "0"
                            xlWorkSheet.Cells(2 + r + rnd, 9) = "FALSE"
                            xlWorkSheet.Cells(2 + r + rnd, 10) = "FALSE"
                            xlWorkSheet.Cells(2 + r + rnd, 11) = "1"
                            xlWorkSheet.Cells(2 + r + rnd, 12) = ""
                            xlWorkSheet.Cells(2 + r + rnd, 13) = ""
                            xlWorkSheet.Cells(2 + r + rnd, 14) = "0"
                            xlWorkSheet.Cells(2 + r + rnd, 15) = "0"
                            xlWorkSheet.Cells(2 + r + rnd, 16) = "0"
                            xlWorkSheet.Cells(2 + r + rnd, 17) = "FALSE"
                            xlWorkSheet.Cells(2 + r + rnd, 18) = ""
                            xlWorkSheet.Cells(2 + r + rnd, 19) = "00/01/1900"
                            xlWorkSheet.Cells(2 + r + rnd, 20) = arrOPT(r)
                            xlWorkSheet.Cells(2 + r + rnd, 21) = ""
                            r = r + 1
                        Loop
                        n = n + 1
                        rnd = rnd + 5
                        sign = 0

                        r = 0
                        Do While r >= 0 And r <= 4
                            Dim arrOPT(5) As String
                            arrOPT(0) = "TAXBASE"
                            arrOPT(1) = "TAXDATE"
                            arrOPT(2) = "TAXID"
                            arrOPT(3) = "TAXINVNO"
                            arrOPT(4) = "TAXNAME"


                            Dim arrOPTVal(5) As String

                            arrOPTVal(0) = "'" & (CDec(dtHead.Rows(i).Item("AMOUNT").ToString) * 100) / 107
                            arrOPTVal(1) = "'" & CDate(dtHead.Rows(i).Item("RECEIVEDOCDATE").ToString).ToString("yyyyMMdd")
                            arrOPTVal(2) = ""
                            arrOPTVal(3) = "'" & dtHead.Rows(i).Item("RCPNO").ToString
                            arrOPTVal(4) = ""

                            xlWorkSheet.Cells(2 + r + rnd, 1) = "'" & Format((i + 1), "000000")
                            xlWorkSheet.Cells(2 + r + rnd, 2) = "'" & Format(1, "00000")
                            xlWorkSheet.Cells(2 + r + rnd, 3) = "'" & Format(400, "0000000000")
                            xlWorkSheet.Cells(2 + r + rnd, 4) = arrOPT(r)
                            xlWorkSheet.Cells(2 + r + rnd, 5) = arrOPTVal(r)
                            xlWorkSheet.Cells(2 + r + rnd, 6) = "1"
                            xlWorkSheet.Cells(2 + r + rnd, 7) = "60"
                            xlWorkSheet.Cells(2 + r + rnd, 8) = "0"
                            xlWorkSheet.Cells(2 + r + rnd, 9) = "FALSE"
                            xlWorkSheet.Cells(2 + r + rnd, 10) = "FALSE"
                            xlWorkSheet.Cells(2 + r + rnd, 11) = "1"
                            xlWorkSheet.Cells(2 + r + rnd, 12) = ""
                            If r <> 3 Then
                                xlWorkSheet.Cells(2 + r + rnd, 13) = ""
                            Else
                                xlWorkSheet.Cells(2 + r + rnd, 13) = arrOPTVal(r)
                            End If

                            xlWorkSheet.Cells(2 + r + rnd, 14) = "0"
                            xlWorkSheet.Cells(2 + r + rnd, 15) = "0"
                            xlWorkSheet.Cells(2 + r + rnd, 16) = "0"
                            xlWorkSheet.Cells(2 + r + rnd, 17) = "FALSE"
                            'xlWorkSheet.Cells(2 + r + rnd, 18) = ""
                            If r <> 1 Then
                                xlWorkSheet.Cells(2 + r + rnd, 18) = ""
                            Else
                                xlWorkSheet.Cells(2 + r + rnd, 18) = dtHead.Rows(i).Item("RECEIVEDOCDATE").ToString
                            End If

                            xlWorkSheet.Cells(2 + r + rnd, 19) = "00/01/1900"


                                xlWorkSheet.Cells(2 + r + rnd, 20) = arrOPT(r)
                            xlWorkSheet.Cells(2 + r + rnd, 21) = ""
                            r = r + 1
                        Loop
                        n = n
                        rnd = rnd + 5

                    Case Else
                        If RCPSEQ = dtHead.Rows(i - 1).Item("RCPSEQ").ToString Then
                            sign = sign + 1
                            r = 0
                            Do While r >= 0 And r <= 4
                                Dim arrOPT(5) As String
                                arrOPT(0) = "TAXBASE"
                                arrOPT(1) = "TAXDATE"
                                arrOPT(2) = "TAXID"
                                arrOPT(3) = "TAXINVNO"
                                arrOPT(4) = "TAXNAME"


                                Dim arrOPTVal(5) As String

                                arrOPTVal(0) = (CDec(dtHead.Rows(i).Item("AMOUNT").ToString) * 100) / 107
                                arrOPTVal(1) = CDate(dtHead.Rows(i).Item("RECEIVEDOCDATE").ToString).ToString("yyyyMMdd")
                                arrOPTVal(2) = ""
                                arrOPTVal(3) = "'" & dtHead.Rows(i).Item("RCPNO").ToString
                                arrOPTVal(4) = ""

                                xlWorkSheet.Cells(2 + r + rnd, 1) = "'" & Format((i + 1), "000000")
                                xlWorkSheet.Cells(2 + r + rnd, 2) = "'" & Format(1, "00000")
                                xlWorkSheet.Cells(2 + r + rnd, 3) = "'" & Format(400, "0000000000")
                                xlWorkSheet.Cells(2 + r + rnd, 4) = arrOPT(r)
                                xlWorkSheet.Cells(2 + r + rnd, 5) = arrOPTVal(r)
                                xlWorkSheet.Cells(2 + r + rnd, 6) = "1"
                                xlWorkSheet.Cells(2 + r + rnd, 7) = "60"
                                xlWorkSheet.Cells(2 + r + rnd, 8) = "0"
                                xlWorkSheet.Cells(2 + r + rnd, 9) = "FALSE"
                                xlWorkSheet.Cells(2 + r + rnd, 10) = "FALSE"
                                xlWorkSheet.Cells(2 + r + rnd, 11) = "1"
                                xlWorkSheet.Cells(2 + r + rnd, 12) = ""
                                If r <> 3 Then
                                    xlWorkSheet.Cells(2 + r + rnd, 13) = ""
                                Else
                                    xlWorkSheet.Cells(2 + r + rnd, 13) = arrOPTVal(r)
                                End If
                                xlWorkSheet.Cells(2 + r + rnd, 14) = "0"
                                xlWorkSheet.Cells(2 + r + rnd, 15) = "0"
                                xlWorkSheet.Cells(2 + r + rnd, 16) = "0"
                                xlWorkSheet.Cells(2 + r + rnd, 17) = "FALSE"
                                xlWorkSheet.Cells(2 + r + rnd, 18) = ""
                                If r <> 1 Then
                                    xlWorkSheet.Cells(2 + r + rnd, 19) = "00/01/1900"
                                Else
                                    xlWorkSheet.Cells(2 + r + rnd, 19) = dtHead.Rows(i).Item("RECEIVEDOCDATE").ToString
                                End If
                                xlWorkSheet.Cells(2 + r + rnd, 20) = arrOPT(r)
                                xlWorkSheet.Cells(2 + r + rnd, 21) = ""
                                r = r + 1
                            Loop
                            n = n
                            rnd = rnd + 5

                        Else
                            r = 0
                            Do While r >= 0 And r <= 4
                                Dim arrOPT(5) As String
                                arrOPT(0) = "TAXBASE"
                                arrOPT(1) = "TAXDATE"
                                arrOPT(2) = "TAXID"
                                arrOPT(3) = "TAXINVNO"
                                arrOPT(4) = "TAXNAME"


                                xlWorkSheet.Cells(2 + r + rnd, 1) = "'" & Format((i + 1), "000000")
                                xlWorkSheet.Cells(2 + r + rnd, 2) = "'" & Format(1, "00000")
                                xlWorkSheet.Cells(2 + r + rnd, 3) = Format(200, "0000000000")
                                xlWorkSheet.Cells(2 + r + rnd, 4) = arrOPT(r)
                                xlWorkSheet.Cells(2 + r + rnd, 5) = ""
                                xlWorkSheet.Cells(2 + r + rnd, 6) = "1"
                                xlWorkSheet.Cells(2 + r + rnd, 7) = "60"
                                xlWorkSheet.Cells(2 + r + rnd, 8) = "0"
                                xlWorkSheet.Cells(2 + r + rnd, 9) = "FALSE"
                                xlWorkSheet.Cells(2 + r + rnd, 10) = "FALSE"
                                xlWorkSheet.Cells(2 + r + rnd, 11) = "1"
                                xlWorkSheet.Cells(2 + r + rnd, 12) = ""
                                xlWorkSheet.Cells(2 + r + rnd, 13) = ""
                                xlWorkSheet.Cells(2 + r + rnd, 14) = "0"
                                xlWorkSheet.Cells(2 + r + rnd, 15) = "0"
                                xlWorkSheet.Cells(2 + r + rnd, 16) = "0"
                                xlWorkSheet.Cells(2 + r + rnd, 17) = "FALSE"
                                xlWorkSheet.Cells(2 + r + rnd, 18) = ""
                                xlWorkSheet.Cells(2 + r + rnd, 19) = "00/01/1900"
                                xlWorkSheet.Cells(2 + r + rnd, 20) = arrOPT(r)
                                xlWorkSheet.Cells(2 + r + rnd, 21) = ""
                                r = r + 1
                            Loop
                            n = n + 1
                            rnd = rnd + 5
                            sign = 0

                        End If

                End Select
            Next

        Catch ex As Exception
            WriteLog("Error 530: Batch_Detail_Optional_Fields" & ex.Message)
        End Try
    End Sub

    Public Shared Function COL_DTDETAIL(ByVal DTDETAIL As DataTable) As DataTable
        If DTDETAIL.Columns.Count = 0 Then
            DTDETAIL.Columns.Add("BATCHID")
            DTDETAIL.Columns.Add("ENTRYNO")
            DTDETAIL.Columns.Add("DETAILNO")
            DTDETAIL.Columns.Add("SRCECODE")
            DTDETAIL.Columns.Add("TEXTDESC")
            DTDETAIL.Columns.Add("ACCTID")
            DTDETAIL.Columns.Add("DTLAMOUNT")
            DTDETAIL.Columns.Add("QUANTITY")
            DTDETAIL.Columns.Add("DEBITAMT")
            DTDETAIL.Columns.Add("CREDITAMT")
            DTDETAIL.Columns.Add("DOCNUMBER")
        End If
        Return DTDETAIL

    End Function


    Public Shared Function KillAllExcelProcess() As Boolean
        Dim ExcelProcess As Boolean = True

        Try
            For Each proc As System.Diagnostics.Process In System.Diagnostics.Process.GetProcessesByName("EXCEL")
                proc.Kill()

                ExcelProcess = False

            Next
        Catch ex As Exception
            Call WriteLog("Error 559 KillAllExcelProcess():  " & ex.Message)
        End Try
        Return ExcelProcess
    End Function


#End Region

#Region "IMPORT SAGE"

    Public Shared Sub EditXML()
        'Sub ใช้แก้ไข File .xml
        Dim strXMLFile As String = Application.StartupPath & "\IMPORTCB\CBImport.xml"
        Try
            Dim xmlDoc As New XmlDocument
            Dim xnod As XmlNode
            xmlDoc.Load(strXMLFile)
            xnod = xmlDoc.DocumentElement("DBNAME")
            'แก้ไข Path ที่ xml ชี้
            xnod.InnerText = Application.StartupPath & "\IMPORTCB\CBImport.xls"
            xnod = xnod
            'บันทึก xml
            xmlDoc.Save(strXMLFile)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Shared Function ImportAccpac(ByVal BANKCODE As String, ByVal RCPNO As String, ByVal ACCPACVERSION As String, ByVal ACCPACID As String, ByVal ACCPACPASS As String, ByVal ACCPACCOMP As String) As Boolean
        Dim CreArr As System.Array
        ' Dim mDBLinkCmpRWApp As Object
        Dim mSession As New AccpacCOMAPI.AccpacSession
        Dim mSessionSH As New AccpacCOMAPI.AccpacSession
        Dim SaveSucess As Boolean = False

        Try
            Dim mDBLinkCmpRWApp As Object
            Dim mDBLinkCmpRW As AccpacCOMAPI.AccpacDBLink
            Dim mDBLinkSysRw As AccpacCOMAPI.AccpacDBLink
            Dim Acc As New AccpacImportExport.ImportExport


            'mSession.Init("", "CB", "CB1200", FrmIMPORTCB.txtCBVersion.Text)
            'mSession.Open(FrmIMPORTCB.txtCBAccpacID.Text, FrmIMPORTCB.txtCBPassword.Text, FrmIMPORTCB.txtCBCompany.Text.TrimEnd, Today, 0, "")
            mSession.Init("", "CB", "CB1200", ACCPACVERSION)
            mSession.Open(ACCPACID, ACCPACPASS, ACCPACCOMP.TrimEnd, Today, 0, "")
            mDBLinkCmpRW = mSession.OpenDBLink(AccpacCOMAPI.tagDBLinkTypeEnum.DBLINK_COMPANY, AccpacCOMAPI.tagDBLinkFlagsEnum.DBLINK_FLG_READWRITE)
            mDBLinkSysRw = mSession.OpenDBLink(AccpacCOMAPI.tagDBLinkTypeEnum.DBLINK_SYSTEM, AccpacCOMAPI.tagDBLinkFlagsEnum.DBLINK_FLG_READWRITE)
            mDBLinkCmpRWApp = mSession.OpenDBLink(AccpacCOMAPI.tagDBLinkTypeEnum.DBLINK_COMPANY, AccpacCOMAPI.tagDBLinkFlagsEnum.DBLINK_FLG_READWRITE)
            Acc.Open(mDBLinkCmpRWApp)
            CreArr = CreateBatchCBEntry("Import From ProgramBill to C/B Entry ", BANKCODE, ACCPACVERSION, ACCPACID, ACCPACPASS, ACCPACCOMP)
            Acc.SetBatchNumber(CreArr)

            '------------------------
            EditXML()

            Dim A = Application.StartupPath & "\IMPORTCB\CBImport.xml"
            Acc.ExecuteImportScript(A, SaveSucess)

            If Acc.ImpExpStatus <> AccpacImportExport.tagImportExportStatus.IE_SUCCESS Then

                Call DATACLASS.INSERTFMSLOGIMPORT(ReturnErrorDT(mSession.Errors, RCPNO), RCPNO)
                Dim frm As New FrmShowError
                frm.SetGrid(mSession, ReturnErrorDT(mSession.Errors, RCPNO))
                frm.ShowDialog()

            End If

            If SaveSucess = True Then
                Call DATACLASS.UPDATEFMSRCPHEAD_IMPORTCB(RCPNO)
                WriteLog("<ImportAccpac>" & "Import Complete " & RCPNO)
                Dim DT = ReturnErrorDT(mSession.Errors, RCPNO)
            Else

                WriteLog("<ImportAccpac>" & "Import Error " & RCPNO)

            End If


            '------------------------

            mDBLinkCmpRWApp = Nothing
            mDBLinkCmpRW.Close()
            mDBLinkCmpRW = Nothing
            mDBLinkSysRw.Close()
            mDBLinkSysRw = Nothing

            Acc.Close()
            Acc = Nothing
            mSession.Close()
            mSession = Nothing
        Catch ex As Exception
            mSession.Close()
            WriteLog("<ImportAccpac>" & ex.Message.ToString())
        End Try
        Return SaveSucess
    End Function

    Public Shared Function CreateBatchCBEntry(ByVal DESC As String, ByVal BANKCODE As String, ByVal ACCPACVERSION As String, ByVal ACCPACID As String, ByVal ACCPACPASS As String, ByVal ACCPACCOMP As String) As System.Array
        'Sub ที่ใช้ CreateBatch CB ก่อน Import Accpac  (ตัวแปรที่มีเส้นใต้เขียวๆ ไม่ต้องสนใจและไม่ต้องทำอะไร)
        'ก๊อปไปให้ได้เลย
        Dim ar As System.Array
        Dim temp As Boolean
        Dim mSession As New AccpacCOMAPI.AccpacSession
        Dim mDBLinkCmpRW As AccpacCOMAPI.AccpacDBLink
        Dim mDBLinkSysRW As AccpacCOMAPI.AccpacDBLink

        'mSession.Init("", "CB", "CB1200", ACCVERSION_im.Trim)
        'mSession.Open(ACCUSERID_im.Trim, ACCPASSWORD_im.Trim, ACCCOMPANY_im.Trim, Today, 0, "")
        'mSession.Init("", "CB", "CB1200", FrmIMPORTCB.txtCBVersion.Text)
        'mSession.Open(FrmIMPORTCB.txtCBAccpacID.Text, FrmIMPORTCB.txtCBPassword.Text, FrmIMPORTCB.txtCBCompany.Text.TrimEnd, Today, 0, "")
        mSession.Init("", "CB", "CB1200", ACCPACVERSION)
        mSession.Open(ACCPACID, ACCPACPASS, ACCPACCOMP.TrimEnd, Today, 0, "")
        mDBLinkCmpRW = mSession.OpenDBLink(AccpacCOMAPI.tagDBLinkTypeEnum.DBLINK_COMPANY, AccpacCOMAPI.tagDBLinkFlagsEnum.DBLINK_FLG_READWRITE)
        mDBLinkSysRW = mSession.OpenDBLink(AccpacCOMAPI.tagDBLinkTypeEnum.DBLINK_SYSTEM, AccpacCOMAPI.tagDBLinkFlagsEnum.DBLINK_FLG_READWRITE)

        Dim CBBTCH2batch As AccpacCOMAPI.AccpacView
        Dim CBBTCH2batchFields As AccpacCOMAPI.AccpacViewFields
        mDBLinkCmpRW.OpenView("CB0009", CBBTCH2batch)
        CBBTCH2batchFields = CBBTCH2batch.Fields

        Dim CBBTCH2header As AccpacCOMAPI.AccpacView
        Dim CBBTCH2headerFields As AccpacCOMAPI.AccpacViewFields
        mDBLinkCmpRW.OpenView("CB0010", CBBTCH2header)
        CBBTCH2headerFields = CBBTCH2header.Fields

        Dim CBBTCH2detail1 As AccpacCOMAPI.AccpacView
        Dim CBBTCH2detail1Fields As AccpacCOMAPI.AccpacViewFields
        mDBLinkCmpRW.OpenView("CB0011", CBBTCH2detail1)
        CBBTCH2detail1Fields = CBBTCH2detail1.Fields

        Dim CBBTCH2detail2 As AccpacCOMAPI.AccpacView
        Dim CBBTCH2detail2Fields As AccpacCOMAPI.AccpacViewFields
        mDBLinkCmpRW.OpenView("CB0012", CBBTCH2detail2)
        CBBTCH2detail2Fields = CBBTCH2detail2.Fields

        Dim CBBTCH2detail3 As AccpacCOMAPI.AccpacView
        Dim CBBTCH2detail3Fields As AccpacCOMAPI.AccpacViewFields
        mDBLinkCmpRW.OpenView("CB0013", CBBTCH2detail3)
        CBBTCH2detail3Fields = CBBTCH2detail3.Fields

        Dim CBBTCH2detail4 As AccpacCOMAPI.AccpacView
        Dim CBBTCH2detail4Fields As AccpacCOMAPI.AccpacViewFields
        mDBLinkCmpRW.OpenView("CB0014", CBBTCH2detail4)
        CBBTCH2detail4Fields = CBBTCH2detail4.Fields

        Dim CBBTCH2detail5 As AccpacCOMAPI.AccpacView
        Dim CBBTCH2detail5Fields As AccpacCOMAPI.AccpacViewFields
        mDBLinkCmpRW.OpenView("CB0015", CBBTCH2detail5)
        CBBTCH2detail5Fields = CBBTCH2detail5.Fields

        Dim CBBTCH2detail6 As AccpacCOMAPI.AccpacView
        Dim CBBTCH2detail6Fields As AccpacCOMAPI.AccpacViewFields
        mDBLinkCmpRW.OpenView("CB0016", CBBTCH2detail6)
        CBBTCH2detail6Fields = CBBTCH2detail6.Fields

        Dim CBBTCH2detail7 As AccpacCOMAPI.AccpacView
        Dim CBBTCH2detail7Fields As AccpacCOMAPI.AccpacViewFields
        mDBLinkCmpRW.OpenView("CB0403", CBBTCH2detail7)
        CBBTCH2detail7Fields = CBBTCH2detail7.Fields

        Dim CBBTCH2detail8 As AccpacCOMAPI.AccpacView
        Dim CBBTCH2detail8Fields As AccpacCOMAPI.AccpacViewFields
        mDBLinkCmpRW.OpenView("CB0404", CBBTCH2detail8)
        CBBTCH2detail8Fields = CBBTCH2detail8.Fields

        CBBTCH2batch.Compose(New Object() {CBBTCH2header})

        CBBTCH2header.Compose(New Object() {CBBTCH2batch, CBBTCH2detail1, CBBTCH2detail4, CBBTCH2detail8})

        CBBTCH2detail1.Compose(New Object() {CBBTCH2header, CBBTCH2detail2, CBBTCH2detail5, CBBTCH2detail7})

        CBBTCH2detail2.Compose(New Object() {CBBTCH2detail1, CBBTCH2detail3, CBBTCH2detail6})

        CBBTCH2detail3.Compose(New Object() {CBBTCH2detail2})

        CBBTCH2detail4.Compose(New Object() {CBBTCH2header})

        CBBTCH2detail5.Compose(New Object() {CBBTCH2detail1})

        CBBTCH2detail6.Compose(New Object() {CBBTCH2detail2})

        CBBTCH2detail7.Compose(New Object() {CBBTCH2detail1})

        CBBTCH2detail8.Compose(New Object() {CBBTCH2header})


        '  CBBTCH2batch.Browse("((STATUS = 1) ", 1)
        CBBTCH2batch.RecordCreate(1)
        ar = CType(CBBTCH2batch.RecordBookMark, System.Array)
        CBBTCH2headerFields.Item("PROCESSCMD").PutWithoutVerification("1")
        CBBTCH2batch.Process()
        CBBTCH2batch.Read()
        CBBTCH2header.RecordCreate(2)
        CBBTCH2batchFields.FieldByName("TEXTDESC").PutWithoutVerification(DESC)
        CBBTCH2batchFields.FieldByName("BANKCODE").PutWithoutVerification(BANKCODE)
        CBBTCH2batch.Update()
        CBBTCH2batch.Cancel()

        mDBLinkCmpRW.Close()
        mDBLinkCmpRW = Nothing
        mDBLinkSysRW.Close()
        mDBLinkSysRW = Nothing
        mSession.Close()
        mSession = Nothing

        Return ar
    End Function

    Public Shared Function ReturnErrorDT(ByRef AccpacError As AccpacCOMAPI.AccpacErrors, ByVal RCPNO As String) As DataTable
        Dim lCount As Long
        Dim lIndex As Long
        Dim DT As New DataTable
        DT.Columns.Add("Index")
        DT.Columns.Add("Priority")
        DT.Columns.Add("Description")
        DT.Columns.Add("Source")
        DT.Columns.Add("PriorityType")
        If AccpacError Is Nothing Then
            MsgBox(Err.Description)
        Else
            lCount = AccpacError.Count

            If lCount = 0 Then
                'MsgBox(Err.Description)
            Else
                Dim Count As Integer = 1
                For lIndex = 0 To lCount - 1
                    If AccpacError.Item(lIndex).IndexOf("Compose wrong in ") = -1 Then
                        DT.Rows.Add()
                        DT.Rows(DT.Rows.Count - 1).Item(0) = Count
                        If AccpacError.GetPriority(lIndex) = AccpacCOMAPI.tagErrorPriority.ERRPRI_ERROR Then
                            DT.Rows(DT.Rows.Count - 1).Item(1) = "ERROR"
                        ElseIf AccpacError.GetPriority(lIndex) = AccpacCOMAPI.tagErrorPriority.ERRPRI_WARNING Then
                            DT.Rows(DT.Rows.Count - 1).Item(1) = "WARNING"
                        ElseIf AccpacError.GetPriority(lIndex) = AccpacCOMAPI.tagErrorPriority.ERRPRI_MESSAGE Then
                            DT.Rows(DT.Rows.Count - 1).Item(1) = "MESSAGE"
                        End If
                        DT.Rows(DT.Rows.Count - 1).Item(2) = RCPNO & " " & AccpacError.Item(lIndex) & Environment.NewLine
                        DT.Rows(DT.Rows.Count - 1).Item(3) = Now.ToString("hh:mm:ss")
                        DT.Rows(DT.Rows.Count - 1).Item(4) = Convert.ToInt32(AccpacError.GetPriority(lIndex))
                        Count += 1
                    End If
                Next
                'AccpacError.Clear()
            End If
        End If
        Return DT
    End Function
#End Region

End Class
