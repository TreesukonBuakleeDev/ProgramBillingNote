Module PROCESS
    Public DT_TEMPOPTFD As DataTable = New DataTable()
#Region "Setting"
    Sub ShowFrmDbSetup()
        Try

            'FrmDbSetup.TopMost = True

            'MAIN.PanelMain.Controls.Add(FrmDbSetup)
            FrmDbSetup.Show(MAIN)

        Catch ex As Exception
            WriteLog("Error 11 (ShowFrmDbSetup):" & ex.Message)
        End Try
    End Sub
    Sub ShowFrmRunning()
        Try

            FrmRunning.Show(MAIN)

        Catch ex As Exception
            WriteLog("Error 21 (ShowFrmRunning):" & ex.Message)
        End Try
    End Sub
    Sub ShowFrmAuthor()
        Try

            FrmAuthor.Show(MAIN)

        Catch ex As Exception
            WriteLog("Error 31 (ShowFrmAuthor):" & ex.Message)
        End Try
    End Sub

    Sub ShowFrmOPTFD()
        Try

            FrmOPTFD.Show(MAIN)

        Catch ex As Exception
            WriteLog("Error 41 (ShowFrmOPTFD):" & ex.Message)
        End Try
    End Sub

    Sub ShowFrmIMPORTCB()
        Try

            FrmIMPORTCB.Show(MAIN)

        Catch ex As Exception
            WriteLog("Error 51 (ShowFrmIMPORTCB):" & ex.Message)
        End Try
    End Sub

    Sub CREATEALLTABLE()
        Try
            Call DATACLASS.CREATEFMSBILLHEAD()
            Call DATACLASS.CREATEFMSBILLDETAIL("FMSBILLDETAIL")
            Call DATACLASS.CREATEFMSBILLDETAIL("FMSBILLDETAILREV")
            Call DATACLASS.CREATEFMSMASTERRUNNING()

            Call DATACLASS.CREATEFMSRCPHEAD()
            Call DATACLASS.CREATEFMSRCPDETAIL()

            Call DATACLASS.CREATEFMSLOGIMPORT()

            Call DATACLASS.CREATE_FMSARCUSMASTER()
            Call DATACLASS.CREATE_FMSARRTAMASTER()
            Call DATACLASS.CREATE_FMSCSCOMMASTER()
            Call DATACLASS.CREATE_FMSARCUSO()
            Call DATACLASS.INSERTFMSARCUSMASTER()
            Call DATACLASS.INSERTFMSARRTAMASTER()
            Call DATACLASS.INSERTFMSCSCOMMASTER()
        Catch ex As Exception
            WriteLog("Error 76 (CREATEALLTABLE):" & ex.Message)
        End Try
    End Sub

#End Region

#Region "Billing"

    Sub ShowFrmBillingBatch()
        Try
            FrmBatchBillingNote.Show(MAIN)
        Catch ex As Exception
            WriteLog("Error 91 (ShowFrmBillingBatch):" & ex.Message)
        End Try
    End Sub
    Sub ShowFrmBillingNote()
        Try
            FrmBillingNote.Show(MAIN)
        Catch ex As Exception
            WriteLog("Error 88 (ShowFrmBillingNote):" & ex.Message)
        End Try
    End Sub

    Sub ShowFrmBillingNoteREVERSE()
        Try

            FrmBillingReverse.Show(MAIN)

        Catch ex As Exception
            WriteLog("Error 115 (ShowFrmBillingNoteREVERSE):" & ex.Message)
        End Try
    End Sub

    Sub ShowFrmPrintBILLSTATUSINV()
        Try

            FrmPrintBillSTATUSINV.Show(MAIN)

        Catch ex As Exception
            WriteLog("Error 123 (ShowFrmPrintBILLSTATUSINV):" & ex.Message)
        End Try
    End Sub
    Public Function ProcessChkAMTOUTSTAND(ByVal DTGET As DataTable, Optional ByVal CHKONLY_AMTOUT As String = "") As DataTable
        Dim DT As DataTable = New DataTable
        DT = DTGET.Copy

        If CHKONLY_AMTOUT = "" Then
            For I = 0 To DT.Rows.Count - 1
                Dim ChkAMTOUTSTAND As Decimal = CDec(DT.Rows(I).Item("AMTOUTSTAND").ToString.TrimEnd)
                Dim BILLNO As String = DT.Rows(I).Item("BILLNO").ToString.TrimEnd

                If ChkAMTOUTSTAND = 0 Then
                    If BILLNO <> "" Then
                        DT.Rows(I).Item("CHECK_0") = "True"
                    Else
                        DT.Rows(I).Delete()
                    End If
                Else
                    If BILLNO <> "" Then
                        DT.Rows(I).Item("CHECK_0") = "True"
                    End If
                End If
            Next
            DT.AcceptChanges()
            For j = 0 To DT.Rows.Count - 1
                Dim LINETOTAL As Decimal = DT.Rows(j).Item("LINEAMOUNT").ToString.TrimEnd
                Dim INVNO = DT.Rows(j).Item("INVNO").ToString.TrimEnd
                Dim SUMNETAMT As Decimal = MASTER.GETDATA_SUMNETAMT(INVNO, "")
                If SUMNETAMT = 0 Then
                Else
                    DT.Rows(j).Item("AMTOUTSTAND") = LINETOTAL - SUMNETAMT
                End If

            Next
            DT.AcceptChanges()
        Else
            For I = 0 To DT.Rows.Count - 1
                Dim ChkAMTOUTSTAND As Decimal = CDec(DT.Rows(I).Item("AMTOUTSTAND").ToString.TrimEnd)

                If ChkAMTOUTSTAND = 0 Then

                    DT.Rows(I).Delete()
                End If
            Next
            DT.AcceptChanges()
            For j = 0 To DT.Rows.Count - 1
                Dim LINETOTAL As Decimal = DT.Rows(j).Item("LINEAMOUNT").ToString.TrimEnd
                Dim INVNO = DT.Rows(j).Item("INVNO").ToString.TrimEnd
                Dim SUMNETAMT As Decimal = MASTER.GETDATA_SUMNETAMT(INVNO, "")
                If SUMNETAMT = 0 Then
                Else
                    DT.Rows(j).Item("AMTOUTSTAND") = LINETOTAL - SUMNETAMT
                End If

            Next
            DT.AcceptChanges()
        End If

        Return DT
    End Function

    Public Function ProcessDetailChkAMTOUTSTAND(ByVal DTGET As DataTable, Optional ByVal CHKONLY_AMTOUT As String = "") As DataTable
        Dim DT As DataTable = New DataTable
        DT = DTGET.Copy

        If CHKONLY_AMTOUT = "" Then
            For I = 0 To DT.Rows.Count - 1
                Dim ChkAMTOUTSTAND As Decimal = CDec(DT.Rows(I).Item("AMTOUTSTAND").ToString.TrimEnd)
                If ChkAMTOUTSTAND = 0 Then
                    DT.Rows(I).Delete()
                End If
            Next
            DT.AcceptChanges()
            For j = 0 To DT.Rows.Count - 1
                Dim LINETOTAL As Decimal = DT.Rows(j).Item("LINEAMOUNT").ToString.TrimEnd
                Dim INVNO = DT.Rows(j).Item("INVNO").ToString.TrimEnd
                Dim SUMNETAMT As Decimal = MASTER.GETDATA_SUMNETAMT(INVNO, "")
                If SUMNETAMT = 0 Then
                Else
                    DT.Rows(j).Item("AMTOUTSTAND") = LINETOTAL - SUMNETAMT
                End If

            Next
            DT.AcceptChanges()
        Else
            For j = 0 To DT.Rows.Count - 1
                Dim LINETOTAL As Decimal = DT.Rows(j).Item("AMT").ToString.TrimEnd
                Dim INVNO = DT.Rows(j).Item("IDINVC").ToString.TrimEnd
                Dim SUMNETAMT As Decimal = MASTER.GETDATA_SUMNETAMT(INVNO, "")
                If SUMNETAMT = 0 Then
                Else
                    DT.Rows(j).Item("AMTOUTSTAND") = LINETOTAL - SUMNETAMT
                End If

            Next
            DT.AcceptChanges()
        End If

        Return DT
    End Function

    Public Function ProcessCALOUTSTANDING(ByVal DTGET As DataTable, Optional ByVal RCP As String = "") As DataTable
        Dim DT As DataTable = New DataTable
        DT = DTGET.Copy

        For I = 0 To DT.Rows.Count - 1
            Dim CHK As String = DT.Rows(I).Item("CHECK_0").ToString
            Dim ChkLINEAMOUNT As Decimal
            Dim ChkTEMPOUT As Decimal
            Dim ChkRCPAMT As Decimal
            If CHK = "True" Then

                If RCP = "" Then
                    Dim INVNO As String = DT.Rows(I).Item("INVNO").ToString.TrimEnd
                    ChkLINEAMOUNT = CDec(DT.Rows(I).Item("LINEAMOUNT").ToString.TrimEnd)
                    ChkTEMPOUT = MASTER.GETDATA_SUMNETAMT(INVNO)
                Else
                    Dim BILLNO As String = DT.Rows(I).Item("BILLNO").ToString.TrimEnd
                    ChkLINEAMOUNT = CDec(DT.Rows(I).Item("AMT").ToString.TrimEnd)
                    ChkTEMPOUT = MASTER.GETDATA_SUMNETAMT(BILLNO, "RCP")
                    ChkRCPAMT = CDec(DT.Rows(I).Item("RCPAMT").ToString.TrimEnd)

                End If

                Dim ChkAMTOUTSTAND As Decimal = CDec(DT.Rows(I).Item("AMTOUTSTAND").ToString.TrimEnd)
                Dim ChkNETAMT As Decimal = CDec(DT.Rows(I).Item("NETAMT").ToString.TrimEnd)


                If ChkAMTOUTSTAND = ChkNETAMT Then
                    DT.Rows(I).Item("AMTOUTSTAND") = CDec(DT.Rows(I).Item("AMTOUTSTAND").ToString) - CDec(DT.Rows(I).Item("NETAMT").ToString)
                Else
                    If (ChkLINEAMOUNT - ChkTEMPOUT) > 0 Then
                        '    ''04/05/2022
                        If RCP = "" Then
                            DT.Rows(I).Item("AMTOUTSTAND") = ChkLINEAMOUNT - ChkTEMPOUT - ChkNETAMT
                        Else
                            DT.Rows(I).Item("AMTOUTSTAND") = ChkLINEAMOUNT - ChkTEMPOUT - ChkRCPAMT
                        End If

                    End If
                End If
            End If

        Next
        DT.AcceptChanges()
        Return DT
    End Function
    Sub DisplayDGVBILL(ByVal dtGETBILL As DataTable, Optional ByVal OPENBATCH As String = "")
        FrmBillingNote.DGV_BILL.DataSource = Nothing
        Try
            If OPENBATCH = "" Then
                'Merge 
                dtGETBILL = MergeTransactionBill(dtGETBILL)
            End If
            'Display Line No
            If dtGETBILL.Columns.Contains("No") = False Then
                dtGETBILL.Columns.Add("No")
                If dtGETBILL.Rows.Count > 0 Then
                    For i = 0 To dtGETBILL.Rows.Count - 1
                        dtGETBILL.Rows(i).Item("No") = i + 1
                    Next
                End If
            Else
                're-line No After Save bill
                If dtGETBILL.Rows.Count > 0 Then
                    Dim j = 0
                    For i = 0 To dtGETBILL.Rows.Count - 1
                        If dtGETBILL.Rows(i).Item("CHECK_0").ToString = "True" Then
                            j = j + 1
                            dtGETBILL.Rows(i).Item("No") = j
                        End If
                    Next
                End If
            End If

            FrmBillingNote.DGV_BILL.DataSource = dtGETBILL

            If FrmBillingNote.DGV_BILL.Columns.Contains("CHECK_0") = True Then
                Dim dtgTextbox As New DataGridViewTextBoxColumn
                Dim dtgCheckbox As New DataGridViewCheckBoxColumn
                'Add column check
                dtgCheckbox = New DataGridViewCheckBoxColumn
                dtgCheckbox.DataPropertyName = "CHECK_0"
                dtgCheckbox.HeaderText = "Select"
                dtgTextbox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                dtgCheckbox.Name = "CHECK_0"
                dtgCheckbox.AutoSizeMode = False
                dtgCheckbox.Width = 30
                dtgCheckbox.ReadOnly = False
                dtgCheckbox.DisplayIndex = 1

                FrmBillingNote.DGV_BILL.Columns.Add(dtgCheckbox)
            End If


            With FrmBillingNote.DGV_BILL
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "รหัสลูกค้า"
                .Columns(1).HeaderCell.Value = "เลขที่เอกสาร"
                .Columns(2).HeaderCell.Value = "วันที่ใบแจ้งหนี้"
                .Columns(3).HeaderCell.Value = "วันที่ครบกำหนด"
                .Columns(4).HeaderCell.Value = "เลขที่ใบสั่งซื้อ"
                .Columns(5).HeaderCell.Value = "จำนวนเงินตามใบแจ้งหนี้"
                .Columns(6).HeaderCell.Value = "ยอดค้างชำระ"
                .Columns(7).HeaderCell.Value = "จำนวนเงินวางบิล"

                .Columns(9).HeaderCell.Value = "สถานะ"
                .Columns(9).Width = 30

                .Columns(2).Width = 40
                .Columns(3).Width = 40
                .Columns(5).Width = 60
                .Columns(6).Width = 60
                .Columns(7).Width = 60
                .Columns(22).Width = 18
                .Columns(23).Width = 30

                ''Optional Field 
                Dim dtHEADEROPTFD As DataTable = New DataTable
                Dim CONDITION As String = "WHERE OPTFDID LIKE '%BILLDTEXT%'"
                dtHEADEROPTFD = MASTER.GETDATA_OPTFD(CONDITION)
                If dtHEADEROPTFD.Rows.Count <> 0 Then
                    For I = 0 To dtHEADEROPTFD.Rows.Count - 1
                        Dim OPTFDID As String = dtHEADEROPTFD.Rows(I).Item("OPTFDID").ToString
                        Dim OPTFDNAME As String = dtHEADEROPTFD.Rows(I).Item("OPTFDNAME").ToString
                        Dim OPTFDACTIVE As String = dtHEADEROPTFD.Rows(I).Item("ACTIVE").ToString
                        Select Case OPTFDID
                            Case "BILLDTEXT1"
                                .Columns(11).HeaderCell.Value = OPTFDNAME
                                If OPTFDACTIVE = "0" Then
                                    .Columns(11).Visible = False
                                End If
                            Case "BILLDTEXT2"
                                .Columns(12).HeaderCell.Value = OPTFDNAME
                                If OPTFDACTIVE = "0" Then
                                    .Columns(12).Visible = False
                                End If
                            Case "BILLDTEXT3"
                                .Columns(13).HeaderCell.Value = OPTFDNAME
                                If OPTFDACTIVE = "0" Then
                                    .Columns(13).Visible = False
                                End If
                            Case "BILLDTEXT4"
                                .Columns(14).HeaderCell.Value = OPTFDNAME
                                If OPTFDACTIVE = "0" Then
                                    .Columns(14).Visible = False
                                End If
                            Case "BILLDTEXT5"
                                .Columns(15).HeaderCell.Value = OPTFDNAME
                                If OPTFDACTIVE = "0" Then
                                    .Columns(15).Visible = False
                                End If
                            Case "BILLDTEXT6"
                                .Columns(16).HeaderCell.Value = OPTFDNAME
                                If OPTFDACTIVE = "0" Then
                                    .Columns(16).Visible = False
                                End If
                            Case "BILLDTEXT7"
                                .Columns(17).HeaderCell.Value = OPTFDNAME
                                If OPTFDACTIVE = "0" Then
                                    .Columns(17).Visible = False
                                End If
                            Case "BILLDTEXT8"
                                .Columns(18).HeaderCell.Value = OPTFDNAME
                                If OPTFDACTIVE = "0" Then
                                    .Columns(18).Visible = False
                                End If
                            Case "BILLDTEXT9"
                                .Columns(19).HeaderCell.Value = OPTFDNAME
                                If OPTFDACTIVE = "0" Then
                                    .Columns(19).Visible = False
                                End If
                            Case "BILLDTEXT10"
                                .Columns(20).HeaderCell.Value = OPTFDNAME
                                If OPTFDACTIVE = "0" Then
                                    .Columns(20).Visible = False
                                End If
                        End Select
                    Next
                Else
                    'Case initial 
                    .Columns(11).Visible = False
                    .Columns(12).Visible = False
                    .Columns(13).Visible = False
                    .Columns(14).Visible = False
                    .Columns(15).Visible = False
                    .Columns(16).Visible = False
                    .Columns(17).Visible = False
                    .Columns(18).Visible = False
                    .Columns(19).Visible = False
                    .Columns(20).Visible = False
                    .Columns(21).Visible = False

                End If
            End With

            With FrmBillingNote.DGV_BILL
                '.Columns(6).Visible = False
                .Columns(0).Visible = False
                .Columns(9).Visible = False
                .Columns(8).Visible = False
                .Columns(10).Visible = False
                .Columns(21).Visible = False
            End With

            With FrmBillingNote.DGV_BILL
                .Columns(22).DisplayIndex = 1
                .Columns(9).DisplayIndex = 3
                .Columns(0).DisplayIndex = 4
                .Columns(1).DisplayIndex = 5
                .Columns(4).DisplayIndex = 6
                .Columns(2).DisplayIndex = 7
                .Columns(3).DisplayIndex = 8

                .Columns(5).DisplayIndex = 9
                .Columns(6).DisplayIndex = 10
                .Columns(7).DisplayIndex = 11


            End With

            With FrmBillingNote.DGV_BILL

                .Columns(0).ReadOnly = True
                .Columns(1).ReadOnly = True
                .Columns(4).ReadOnly = True
                .Columns(2).ReadOnly = True
                .Columns(3).ReadOnly = True

                .Columns(5).ReadOnly = True
                .Columns(6).ReadOnly = True
                .Columns(7).ReadOnly = True
                .Columns(9).ReadOnly = True
            End With

            With FrmBillingNote.DGV_BILL


                .EnableHeadersVisualStyles = False
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray

                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(5).DefaultCellStyle.Format = "N2"
                .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(6).DefaultCellStyle.Format = "N2"
                .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(7).DefaultCellStyle.Format = "N2"
                .Columns(22).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(22).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            End With
            With FrmBillingNote.DGV_BILL
                .Columns(22).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With
            If FrmBillingNote.DGV_BILL.Rows.Count > 0 Then
                For J = 0 To FrmBillingNote.DGV_BILL.Rows.Count - 1
                    If FrmBillingNote.DGV_BILL.Rows(J).Cells(9).Value = "2" Then
                        FrmBillingNote.DGV_BILL.Rows(J).Cells(9).ReadOnly = True
                    End If
                Next


            End If

        Catch ex As Exception
            WriteLog("Error 455 DisplayDGVBILL()  : " & ex.Message)
        End Try
    End Sub

    Sub DisplayDGV_BATCHBILL(ByVal dtBATCHBILL As DataTable)
        Try
            For I = 0 To dtBATCHBILL.Rows.Count - 1
                Dim IDCUST As String = dtBATCHBILL.Rows(I).Item("IDCUST").ToString
                Dim BILLNO As String = dtBATCHBILL.Rows(I).Item("BILLNO").ToString
                Dim CUSTNAME As String = ""
                Dim CNTLINE As Decimal

                CUSTNAME = MASTER.GET_IDCUST(IDCUST)
                CNTLINE = MASTER.GET_CNTINV(BILLNO)

                dtBATCHBILL.Rows(I).Item("CUSTNAME") = CUSTNAME
                dtBATCHBILL.Rows(I).Item("CNTINV") = CNTLINE

            Next

            FrmBatchBillingNote.DGV_BATCHBILL.DataSource = dtBATCHBILL

            With FrmBatchBillingNote.DGV_BATCHBILL
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "เลขที่ใบวางบิล"
                .Columns(1).HeaderCell.Value = "รหัสลูกค้า"
                .Columns(2).HeaderCell.Value = "ชื่อลูกค้า"
                .Columns(3).HeaderCell.Value = "วันที่เอกสาร"
                .Columns(4).HeaderCell.Value = "วันที่นัดชำระ"
                .Columns(5).HeaderCell.Value = "จำนวนเงิน"
                .Columns(6).HeaderCell.Value = "สถานะ"
                .Columns(7).HeaderCell.Value = "จำนวนใบแจ้งหนี้"
            End With

            With FrmBatchBillingNote.DGV_BATCHBILL
                .Columns(0).Width = 100
                .Columns(1).Width = 100
                .Columns(2).Width = 200
                .Columns(3).Width = 100
                .Columns(4).Width = 100
                .Columns(5).Width = 100
                .Columns(6).Width = 50
                .Columns(7).Width = 120
            End With

            With FrmBatchBillingNote.DGV_BATCHBILL
                .ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray
                .EnableHeadersVisualStyles = False
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(5).DefaultCellStyle.Format = "N2"
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With



        Catch ex As Exception
            WriteLog("Error 510 DisplayDGV_BATCHBILL: " & ex.Message)
        End Try
    End Sub

    Public Function ProcessBILLDATA(ByRef BILLSEQ As String, ByRef BILLNO As String, ByVal DTsum As DataTable, Optional ByVal UPDATE As String = "") As DataTable
        Dim DTBILLHEAD As DataTable = New DataTable
        Dim STRCOL As String = PROCESS.COLNAME("BILLHEAD")
        Dim ArrSTRCOL() As String = STRCOL.Split(",")

        'add columns
        If DTBILLHEAD.Columns.Count = 0 Then
            For i = 0 To ArrSTRCOL.Length - 1
                DTBILLHEAD.Columns.Add(ArrSTRCOL(i))
            Next
        End If
        'add rows 
        Dim IDCUST, INVDATE, DueDate, BILLDOCDATE, AMT, NETAMT, REF_0, COMMENT, STA_0, TERMCODE, BILLHTEXT1, BILLHTEXT2, BILLHTEXT3, BILLHTEXT4, BILLHTEXT5, BILLHTEXT6, BILLHTEXT7, BILLHTEXT8, BILLHTEXT9, BILLHTEXT10 As String
        If UPDATE = "" Then
            BILLSEQ = RUNSEQ("BILLHEAD")
            BILLNO = DOCRUNNO("BILLHEAD")

        Else
            BILLSEQ = ""
            BILLNO = FrmBillingNote.TXTBILL_BILLNO.Text
        End If

        If BILLNO = Nothing Then
            Return Nothing
            Exit Function
        End If

        IDCUST = FrmBillingNote.TXTBILL_IDCUST.Text
        INVDATE = Format(FrmBillingNote.txtBILL_INVDATE.Value, "yyyyMMdd")
        DueDate = Format(FrmBillingNote.txtBILL_DueDate.Value, "yyyyMMdd")
        BILLDOCDATE = Format(FrmBillingNote.txtBill_DOCDATE.Value, "yyyyMMdd")
        REF_0 = FrmBillingNote.TXTBILL_REF.Text
        COMMENT = FrmBillingNote.txtBILL_Comment.Text
        AMT = SUM_AMT(DTsum)
        NETAMT = SUM_AMTNET(DTsum)
        STA_0 = 1
        TERMCODE = FrmBillingNote.txtBILL_TERMCODE.Text
        Dim VBILLHTEXT1, VBILLHTEXT2, VBILLHTEXT3, VBILLHTEXT4, VBILLHTEXT5, VBILLHTEXT6, VBILLHTEXT7, VBILLHTEXT8, VBILLHTEXT9, VBILLHTEXT10 As String
        For J = 0 To DT_TEMPOPTFD.Rows.Count - 1
            Select Case J
                Case 0
                    VBILLHTEXT1 = DT_TEMPOPTFD.Rows(J).Item("VALUE").ToString
                Case 1
                    VBILLHTEXT2 = DT_TEMPOPTFD.Rows(J).Item("VALUE").ToString
                Case 2
                    VBILLHTEXT3 = DT_TEMPOPTFD.Rows(J).Item("VALUE").ToString
                Case 3
                    VBILLHTEXT4 = DT_TEMPOPTFD.Rows(J).Item("VALUE").ToString
                Case 4
                    VBILLHTEXT5 = DT_TEMPOPTFD.Rows(J).Item("VALUE").ToString
                Case 5
                    VBILLHTEXT6 = DT_TEMPOPTFD.Rows(J).Item("VALUE").ToString
                Case 6
                    VBILLHTEXT7 = DT_TEMPOPTFD.Rows(J).Item("VALUE").ToString
                Case 7
                    VBILLHTEXT8 = DT_TEMPOPTFD.Rows(J).Item("VALUE").ToString
                Case 8
                    VBILLHTEXT9 = DT_TEMPOPTFD.Rows(J).Item("VALUE").ToString
                Case 9
                    VBILLHTEXT10 = DT_TEMPOPTFD.Rows(J).Item("VALUE").ToString
            End Select

        Next
        BILLHTEXT1 = VBILLHTEXT1
        BILLHTEXT2 = VBILLHTEXT2
        BILLHTEXT3 = VBILLHTEXT3
        BILLHTEXT4 = VBILLHTEXT4
        BILLHTEXT5 = VBILLHTEXT5
        BILLHTEXT6 = VBILLHTEXT6
        BILLHTEXT7 = VBILLHTEXT7
        BILLHTEXT8 = VBILLHTEXT8
        BILLHTEXT9 = VBILLHTEXT9
        BILLHTEXT10 = VBILLHTEXT10

        Dim row As String() = New String() {BILLSEQ, BILLNO, IDCUST, INVDATE, DueDate, BILLDOCDATE, AMT, NETAMT, REF_0, COMMENT, STA_0, TERMCODE, BILLHTEXT1, BILLHTEXT2, BILLHTEXT3, BILLHTEXT4, BILLHTEXT5, BILLHTEXT6, BILLHTEXT7, BILLHTEXT8, BILLHTEXT9, BILLHTEXT10, ""}
        DTBILLHEAD.Rows.Add(row)
        Return DTBILLHEAD
    End Function

    Public Function ProcessBILLDETAILDATA(ByVal BILLSEQ As String, ByVal BILLNO As String, ByVal DT As DataTable) As DataTable
        Dim DTBILLHEAD As DataTable = New DataTable
        Dim STRCOL As String = PROCESS.COLNAME("BILLDETAIL")
        Dim ArrSTRCOL() As String = STRCOL.Split(",")
        'add columns
        If DTBILLHEAD.Columns.Count = 0 Then
            For i = 0 To ArrSTRCOL.Length - 1
                DTBILLHEAD.Columns.Add(ArrSTRCOL(i))
            Next
        End If
        'add rows 
        Dim DETAILLINE, IDCUST, INVNO, INVDATE, DUEDATE, PONUM, LINEAMOUNT, AMTOUTSTAND, NETAMT, CHECK_0, STA_0, BILLDTEXT1, BILLDTEXT2, BILLDTEXT3, BILLDTEXT4, BILLDTEXT5, BILLDTEXT6, BILLDTEXT7, BILLDTEXT8, BILLDTEXT9, BILLDTEXT10 As String
        'DT FILTER SELECT INVOICE

        For J = 0 To DT.Rows.Count - 1
            If DT.Rows(J).Item("CHECK_0").ToString <> "True" Then
                DT.Rows(J).Delete()
            End If
        Next
        DT.AcceptChanges()

        For I = 0 To DT.Rows.Count - 1
            DETAILLINE = I + 1
            IDCUST = DT.Rows(I).Item("IDCUST").ToString.TrimEnd
            INVNO = DT.Rows(I).Item("INVNO").ToString.TrimEnd
            INVDATE = CDate(DT.Rows(I).Item("INVDATE").ToString).ToString("yyyyMMdd")
            DUEDATE = CDate(DT.Rows(I).Item("DUEDATE").ToString).ToString("yyyyMMdd")
            PONUM = DT.Rows(I).Item("PONUM").ToString.TrimEnd
            LINEAMOUNT = DT.Rows(I).Item("LINEAMOUNT").ToString.TrimEnd
            NETAMT = DT.Rows(I).Item("NETAMT").ToString.TrimEnd
            AMTOUTSTAND = DT.Rows(I).Item("AMTOUTSTAND").ToString.TrimEnd
            CHECK_0 = "True"
            STA_0 = 1
            BILLDTEXT1 = DT.Rows(I).Item("BILLDTEXT1").ToString.TrimEnd
            BILLDTEXT2 = DT.Rows(I).Item("BILLDTEXT2").ToString.TrimEnd
            BILLDTEXT3 = DT.Rows(I).Item("BILLDTEXT3").ToString.TrimEnd
            BILLDTEXT4 = DT.Rows(I).Item("BILLDTEXT4").ToString.TrimEnd
            BILLDTEXT5 = DT.Rows(I).Item("BILLDTEXT5").ToString.TrimEnd
            BILLDTEXT6 = DT.Rows(I).Item("BILLDTEXT6").ToString.TrimEnd
            BILLDTEXT7 = DT.Rows(I).Item("BILLDTEXT7").ToString.TrimEnd
            BILLDTEXT8 = DT.Rows(I).Item("BILLDTEXT8").ToString.TrimEnd
            BILLDTEXT9 = DT.Rows(I).Item("BILLDTEXT9").ToString.TrimEnd
            BILLDTEXT10 = DT.Rows(I).Item("BILLDTEXT10").ToString.TrimEnd
            Dim row As String() = New String() {BILLSEQ, BILLNO, DETAILLINE, IDCUST, INVNO, INVDATE, DUEDATE, PONUM, LINEAMOUNT, AMTOUTSTAND, NETAMT, CHECK_0, STA_0, BILLDTEXT1, BILLDTEXT2, BILLDTEXT3, BILLDTEXT4, BILLDTEXT5, BILLDTEXT6, BILLDTEXT7, BILLDTEXT8, BILLDTEXT9, BILLDTEXT10, ""}
            DTBILLHEAD.Rows.Add(row)
        Next
        Return DTBILLHEAD
    End Function

    Public Function COLNAME(ByVal FUCNTIONS As String) As String
        Dim STR As String
        Select Case FUCNTIONS
            Case "BILLHEAD"
                STR = "BILLSEQ,BILLNO,IDCUST,INVDATE,DueDate,BILLDOCDATE,AMT,NETAMT,REF_0,COMMENT,STA_0,TERMCODE,BILLHTEXT1,BILLHTEXT2,BILLHTEXT3,BILLHTEXT4,BILLHTEXT5,BILLHTEXT6,BILLHTEXT7,BILLHTEXT8,BILLHTEXT9,BILLHTEXT10,AUDTORG,BOI"
            Case "BILLDETAIL"
                STR = "BILLSEQ,BILLNO,DETAILLINE,IDCUST,INVNO,INVDATE,DUEDATE,PONUM,LINEAMOUNT,AMTOUTSTAND,NETAMT,CHECK_0,STA_0,BILLDTEXT1,BILLDTEXT2,BILLDTEXT3,BILLDTEXT4,BILLDTEXT5,BILLDTEXT6,BILLDTEXT7,BILLDTEXT8,BILLDTEXT9,BILLDTEXT10,AUDTORG"
            Case "RCPHEAD"
                STR = "RCPSEQ,RCPNO,IDCUST,RECEIVEDOCDATE,RECEIVEDATE,BANKCODE,AMT,NETAMT,REF_0,COMMENT,PAYTYPE,PAYDATE,CRCARDNO,TRANSBANKCODE,TRANSBANKNO,TRANSFEE,CHEQNO,CHEQBRANCH,CHEQACCT,CHEQDATE,SHOWCHEQDATE,SHOWRECEIVEDATE,STA_0,RCPHTEXT1,RCPHTEXT2,RCPHTEXT3,RCPHTEXT4,RCPHTEXT5,RCPHTEXT6,RCPHTEXT7,RCPHTEXT8,RCPHTEXT9,RCPHTEXT10,AUDTORG,IMPORTCB,BANKBATCH,CHEQBANK,CBDATE"
            Case "RCPDETAIL"
                STR = "RCPSEQ,RCPNO,DETAILLINE,BILLNO,IDCUST,INVNO,INVDATE,DueDate,PONUM,UNITPRICE,VATAMT,RCPAMT,AMTOUTSTAND,NETAMT,AMT,CHECK_0,STA_0,RCPDTEXT1,RCPDTEXT2,RCPDTEXT3,RCPDTEXT4,RCPDTEXT5,RCPDTEXT6,RCPDTEXT7,RCPDTEXT8,RCPDTEXT9,RCPDTEXT10,AUDTORG,VAT"
            Case Else
                STR = ""
        End Select

        Return STR

    End Function

    Public Function RUNSEQ(ByVal DocTYPE As String) As String
        Dim STR As String = ""
        Select Case DocTYPE
            Case "BILLHEAD"
                STR = MASTER.GET_SEQ(DocTYPE)
            Case "RCPHEAD"
                STR = MASTER.GET_SEQ(DocTYPE)
            Case Else

        End Select

        Return STR

    End Function

    Public Function BK_DOCRUNNO(ByVal DocTYPE As String) As String
        Dim STR As String
        Dim STRPrefix As String
        Select Case DocTYPE
            Case "BILLHEAD"
                STR = MASTER.GET_RUNNING("Bill")
                STRPrefix = MASTER.GET_PREFIX("Bill")


                If STR = "" Or IsDBNull(STR) = True Then
                    STR = Format(1, "00000")
                Else
                    STR = Format(CInt(STR), "00000")
                    STR = String.Format(STR, "00000")
                End If

                '>>update Running
                Dim RUNNO As Decimal = CDec(STR) + 1
                Call DATACLASS.UPDATEFMSMASTERRUNING("Billing Note", RUNNO)
                STR = STRPrefix & STR

            Case "RCPHEAD"
                STR = MASTER.GET_RUNNING("Receipt")
                STRPrefix = MASTER.GET_PREFIX("Receipt")


                If STR = "" Or IsDBNull(STR) = True Then
                    STR = Format(1, "00000")
                Else
                    STR = Format(CInt(STR), "00000")
                    STR = String.Format(STR, "00000")
                End If

                '>>update Running
                Dim RUNNO As Decimal = CDec(STR) + 1
                Call DATACLASS.UPDATEFMSMASTERRUNING("Receipt", String.Format(RUNNO, "00000"))
                STR = STRPrefix & STR

            Case "RCPTAX"
                STR = MASTER.GET_RUNNING("TaxReceipt")
                STRPrefix = MASTER.GET_PREFIX("TaxReceipt")

                If STR = "" Or IsDBNull(STR) = True Then
                    STR = Format(1, "00000")
                Else
                    STR = Format(CInt(STR), "00000")
                    STR = String.Format(STR, "00000")
                End If

                '>>update Running
                Dim RUNNO As Decimal = CDec(STR) + 1
                Call DATACLASS.UPDATEFMSMASTERRUNING("Tax Receipt", String.Format(RUNNO, "00000"))
                STR = STRPrefix & STR

            Case Else
                STR = ""
        End Select

        Return STR

    End Function

    Public Function DOCRUNNO(ByVal DocTYPE As String) As String
        Dim STR As String
        Dim STRPrefix As String
        Dim STRFormat As String = ""
        Select Case DocTYPE
            Case "BILLHEAD"
                STR = MASTER.GET_RUNNING("Bill")
                STRPrefix = MASTER.GET_PREFIX("Bill")
                Dim vSTRFormat As Decimal = MASTER.GET_FORMAT("Bill")
                Dim LastSTRFormat As Decimal
                For i = 0 To vSTRFormat - 1
                    STRFormat = STRFormat & "0"
                    LastSTRFormat = LastSTRFormat & "9"
                Next

                If STR = "" Or IsDBNull(STR) = True Then
                    STR = Format(1, STRFormat)
                Else
                    STR = Format(CInt(STR), STRFormat)
                    STR = String.Format(STR, STRFormat)
                End If

                '>>update Running
                If CDec(STR) <= LastSTRFormat Then
                    Dim RUNNO As Decimal = CDec(STR) + 1
                    Call DATACLASS.UPDATEFMSMASTERRUNING("Billing Note", String.Format(RUNNO, STRFormat))
                    STR = STRPrefix & STR
                Else

                    MessageBox.Show("Running Document out of setup limit.")
                    Return Nothing
                    FrmRunning.Show(MAIN)
                End If
            Case "RCPHEAD"
                STR = MASTER.GET_RUNNING("Receipt")
                STRPrefix = MASTER.GET_PREFIX("Receipt")
                Dim vSTRFormat As Decimal = MASTER.GET_FORMAT("Receipt")
                Dim LastSTRFormat As Decimal
                For i = 0 To vSTRFormat - 1
                    STRFormat = STRFormat & "0"
                    LastSTRFormat = LastSTRFormat & "9"
                Next


                If STR = "" Or IsDBNull(STR) = True Then
                    STR = Format(1, STRFormat)
                Else
                    STR = Format(CInt(STR), STRFormat)
                    STR = String.Format(STR, STRFormat)
                End If

                '>>update Running
                If CDec(STR) <= LastSTRFormat Then
                    Dim RUNNO As Decimal = CDec(STR) + 1
                    Call DATACLASS.UPDATEFMSMASTERRUNING("Receipt", String.Format(RUNNO, STRFormat))
                    STR = STRPrefix & STR
                Else

                    MessageBox.Show("Running Document out of setup limit.")
                    Return Nothing
                    FrmRunning.Show(MAIN)
                End If
            Case "RCPTAX"
                STR = MASTER.GET_RUNNING("TaxReceipt")
                STRPrefix = MASTER.GET_PREFIX("TaxReceipt")
                Dim vSTRFormat As Decimal = MASTER.GET_FORMAT("TaxReceipt")
                Dim LastSTRFormat As Decimal
                For i = 0 To vSTRFormat - 1
                    STRFormat = STRFormat & "0"
                    LastSTRFormat = LastSTRFormat & "9"
                Next

                If STR = "" Or IsDBNull(STR) = True Then
                    STR = Format(1, STRFormat)
                Else
                    STR = Format(CInt(STR), STRFormat)
                    STR = String.Format(STR, STRFormat)
                End If

                '>>update Running
                If CDec(STR) <= LastSTRFormat Then
                    Dim RUNNO As Decimal = CDec(STR) + 1
                    Call DATACLASS.UPDATEFMSMASTERRUNING("Tax Receipt", String.Format(RUNNO, STRFormat))
                    STR = STRPrefix & STR
                Else

                    MessageBox.Show("Running Document out of setup limit.")
                    Return Nothing
                    FrmRunning.Show(MAIN)
                End If

            Case Else
                STR = ""
        End Select

        Return STR

    End Function
    Public Function SUM_AMT(ByVal DT As DataTable) As Decimal
        Dim STR As Decimal
        For I = 0 To DT.Rows.Count - 1
            Dim CHK As String = DT.Rows(I).Item("CHECK_0").ToString
            If CHK = "True" Then
                STR = STR + DT.Rows(I).Item("LINEAMOUNT").ToString
            End If
        Next

        Return STR

    End Function
    Public Function SUM_RCPAMT(ByVal DT As DataTable) As Decimal
        Dim STR As Decimal
        For I = 0 To DT.Rows.Count - 1
            Dim CHK As String = DT.Rows(I).Item("CHECK_0").ToString
            If CHK = "True" Then
                STR = STR + DT.Rows(I).Item("RCPAMT").ToString
            End If
        Next

        Return STR

    End Function
    Public Function SUM_AMTNET(ByVal DT As DataTable) As Decimal
        Dim STR As Decimal
        For I = 0 To DT.Rows.Count - 1
            Dim CHK As String = DT.Rows(I).Item("CHECK_0").ToString
            If CHK = "True" Then
                STR = STR + DT.Rows(I).Item("NETAMT").ToString
            End If
        Next

        Return STR

    End Function

    Public Function MergeTransactionBill(ByVal dt As DataTable, Optional ByVal REVERSE As String = Nothing) As DataTable
        Dim dtduplicate As DataTable = New DataTable
        Dim DistinctColumn As String = "INVNO"
        Dim DistinctColumnBILL As String = "BILLNO"
        Try
            '1. filter 
            dtduplicate = dt.Clone
            Dim UniqueRecords As New ArrayList()
            Dim DuplicateRecords As New ArrayList()
            For Each dRow As DataRow In dt.Rows
                If REVERSE = "" Then
                    If dRow.Item("INVNO").ToString <> "" Then
                        If UniqueRecords.Contains(dRow(DistinctColumn).ToString.TrimEnd) Then

                            DuplicateRecords.Add(dRow)
                        Else
                            UniqueRecords.Add(dRow(DistinctColumn).ToString.TrimEnd)
                        End If
                    End If
                Else
                    If dRow.Item("INVNO").ToString <> "" Then
                        If UniqueRecords.Contains(dRow(DistinctColumn).ToString.TrimEnd & UniqueRecords.Contains(dRow(DistinctColumnBILL.ToString.TrimEnd))) Then

                            DuplicateRecords.Add(dRow)
                        Else
                            UniqueRecords.Add(dRow(DistinctColumn).ToString.TrimEnd)
                        End If
                    End If
                End If


            Next

            For Each dRowDup As DataRow In DuplicateRecords
                dtduplicate.ImportRow(dRowDup)
            Next

            For Each dRow As DataRow In DuplicateRecords
                dt.Rows.Remove(dRow)
            Next

            For i = 0 To dt.Rows.Count - 1

                'Dim BILLNO As String = dt.Rows(i).Item("BILLNO").ToString
                Dim IDINVC As String = dt.Rows(i).Item("INVNO").ToString

                Dim vAMTOUTSTAND As Decimal
                Dim vNETAMT As Decimal = 0
                Dim vRevNETAMT As Decimal = 0
                Dim NETAMT As Decimal
                NETAMT = dt.Rows(i).Item("NETAMT").ToString


                Dim drRowss As DataRow()

                drRowss = dtduplicate.[Select](" INVNO = '" & IDINVC & "'  ")

                If drRowss.Count > 0 Then
                    Dim lineAMT As Decimal
                    lineAMT = 0
                    For j = 0 To drRowss.Count - 1
                        If drRowss(j).Item("STA_0").ToString.TrimEnd = 4 Then
                            vRevNETAMT = vRevNETAMT + CDec(drRowss(j).Item("NETAMT").ToString)
                        Else
                            vNETAMT = vNETAMT + CDec(drRowss(j).Item("NETAMT").ToString)
                        End If


                        'vAMTOUTSTAND = vAMTOUTSTAND + CDec(drRowss(j).Item("AMTOUTSTAND").ToString)
                        'Dim NETAMT As Decimal
                        'NETAMT = CDec(drRowss(j).Item("NETAMT").ToString)

                        'If j = 0 Then
                        '    vNETAMT = vNETAMT
                        '    lineAMT = CDec(drRowss(j).Item("LINEAMOUNT").ToString)
                        'Else

                        '    If CDec(drRowss(j - 1).Item("AMTOUTSTAND").ToString) = CDec(drRowss(j).Item("AMTOUTSTAND").ToString) Then
                        '        vNETAMT = vNETAMT
                        '        lineAMT = CDec(drRowss(j).Item("LINEAMOUNT").ToString)
                        '    Else
                        '        vNETAMT = vNETAMT + NETAMT
                        '        lineAMT = CDec(drRowss(j).Item("LINEAMOUNT").ToString)
                        '    End If
                        'End If
                    Next
                    'path1
                    If NETAMT = 0 Then
                        dt.Rows(i).Item("AMTOUTSTAND") = NETAMT + vRevNETAMT
                        dt.Rows(i).Item("NETAMT") = NETAMT + vRevNETAMT
                    Else
                        dt.Rows(i).Item("AMTOUTSTAND") = NETAMT + vNETAMT
                        dt.Rows(i).Item("NETAMT") = NETAMT + vNETAMT
                    End If

                    ''path2
                    'If lineAMT >= vNETAMT Then
                    '    vAMTOUTSTAND = dt.Rows(i).Item("AMTOUTSTAND") + vNETAMT
                    'Else
                    '    vAMTOUTSTAND = vNETAMT
                    'End If
                    'dt.Rows(i).Item("AMTOUTSTAND") = vAMTOUTSTAND
                    'dt.Rows(i).Item("NETAMT") = vAMTOUTSTAND

                End If

            Next
            dt = ProcessChkAMTOUTSTAND(dt) 'CHECK OUTSTANDING <> 0 
        Catch ex As Exception
            WriteLog("Error 875 MergeTransactionBill() :" & ex.Message)
        End Try

        Return dt
    End Function



#End Region

#Region "Receive"
    Sub ShowFrmBatchReceipt()
        Try

            FrmBatchReceipt.Show(MAIN)

        Catch ex As Exception
            WriteLog("Error 949 ShowFrmBatchReceipt() :" & ex.Message)
        End Try
    End Sub
    Sub ShowFrmReceipt()
        Try

            FrmReceipt.Show(MAIN)

        Catch ex As Exception
            WriteLog("Error 958 ShowFrmBatchReceipt() :" & ex.Message)
        End Try
    End Sub

    Sub ShowFrmReceiptReverse()
        Try

            FrmReceiptReverse.Show(MAIN)

        Catch ex As Exception
            WriteLog("Error 970 ShowFrmReceiptReverse() :" & ex.Message)
        End Try
    End Sub

    Sub DisplayDGV_BATCHRCP(ByVal dtBATCHRCP As DataTable)
        Try
            FrmBatchReceipt.DGV_BATCHRECEIP.DataSource = Nothing
            FrmBatchReceipt.DGV_BATCHRECEIP.Columns.Clear()
            FrmBatchReceipt.DGV_BATCHRECEIP.Rows.Clear()
            For I = 0 To dtBATCHRCP.Rows.Count - 1
                Dim IDCUST As String = dtBATCHRCP.Rows(I).Item("IDCUST").ToString
                Dim RCPNO As String = dtBATCHRCP.Rows(I).Item("RCPNO").ToString
                Dim CUSTNAME As String = ""
                Dim CNTLINE As Decimal

                CUSTNAME = MASTER.GET_IDCUST(IDCUST)
                CNTLINE = MASTER.GET_CNTINVRCP(RCPNO)

                dtBATCHRCP.Rows(I).Item("CUSTNAME") = CUSTNAME
                dtBATCHRCP.Rows(I).Item("CNTINV") = CNTLINE

            Next

            FrmBatchReceipt.DGV_BATCHRECEIP.DataSource = dtBATCHRCP

            With FrmBatchReceipt.DGV_BATCHRECEIP
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "เลขที่ใบเสร็จ"
                .Columns(1).HeaderCell.Value = "รหัสลูกค้า"
                .Columns(2).HeaderCell.Value = "ชื่อลูกค้า"
                .Columns(3).HeaderCell.Value = "วันที่เอกสาร"
                .Columns(4).HeaderCell.Value = "วันที่ทำรายการ"
                .Columns(5).HeaderCell.Value = "จำนวนเงิน"
                .Columns(6).HeaderCell.Value = "สถานะ"
                .Columns(7).HeaderCell.Value = "จำนวนใบแจ้งหนี้"
                .Columns(9).HeaderCell.Value = "สถานะ Import"
            End With


            With FrmBatchReceipt.DGV_BATCHRECEIP
                .Columns(8).Visible = False
            End With


            Dim dtgTextbox As New DataGridViewTextBoxColumn
            Dim dtgCheckbox As New DataGridViewCheckBoxColumn
            'Add column check
            dtgCheckbox = New DataGridViewCheckBoxColumn
            dtgCheckbox.DataPropertyName = "CHECK_0"
            dtgCheckbox.HeaderText = "Import to Cash Book"
            dtgTextbox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtgCheckbox.Name = "CHECK_0"
            dtgCheckbox.AutoSizeMode = False
            dtgCheckbox.Width = 100
            dtgCheckbox.ReadOnly = False
            dtgCheckbox.DisplayIndex = 9

            FrmBatchReceipt.DGV_BATCHRECEIP.Columns.Add(dtgCheckbox)

            With FrmBatchReceipt.DGV_BATCHRECEIP
                .ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray
                .EnableHeadersVisualStyles = False
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(5).DefaultCellStyle.Format = "N2"

            End With

            With FrmBatchReceipt.DGV_BATCHRECEIP
                .Columns(0).ReadOnly = True
                .Columns(1).ReadOnly = True
                .Columns(2).ReadOnly = True
                .Columns(3).ReadOnly = True
                .Columns(4).ReadOnly = True
                .Columns(5).ReadOnly = True
                .Columns(6).ReadOnly = True
                .Columns(7).ReadOnly = True
                .Columns(8).ReadOnly = True
                .Columns(9).ReadOnly = True
                '.Columns(11).ReadOnly = True

            End With

            If FrmBatchReceipt.DGV_BATCHRECEIP.Rows.Count > 0 Then
                For I = 0 To FrmBatchReceipt.DGV_BATCHRECEIP.Rows.Count - 1
                    If FrmBatchReceipt.DGV_BATCHRECEIP.Rows(I).Cells("IMPORTCB").Value.ToString.TrimEnd = "Y" Then
                        FrmBatchReceipt.DGV_BATCHRECEIP.Rows(I).ReadOnly = True
                        FrmBatchReceipt.DGV_BATCHRECEIP.Rows(I).Cells("IMPORTCB").Value = "Yes"
                    Else
                        FrmBatchReceipt.DGV_BATCHRECEIP.Rows(I).Cells("IMPORTCB").Value = "No"
                    End If
                Next

            End If

            FrmBatchReceipt.DGV_BATCHRECEIP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            With FrmBatchReceipt.DGV_BATCHRECEIP
                '    .Columns(0).Width = 100
                .Columns(1).Width = 100
                .Columns(2).Width = 200
                .Columns(3).Width = 80
                .Columns(4).Width = 80
                .Columns(5).Width = 120
                .Columns(6).Width = 60
                .Columns(7).Width = 75
                .Columns(9).Width = 80
                .Columns("CHECK_0").Width = 105
                .Columns("CHECK_0").DefaultCellStyle.WrapMode = DataGridViewTriState.True
                .Columns("CHECK_0").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns(3).DefaultCellStyle.WrapMode = DataGridViewTriState.True
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns(4).DefaultCellStyle.WrapMode = DataGridViewTriState.True
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


                .Columns(7).DefaultCellStyle.WrapMode = DataGridViewTriState.True
                .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(9).DefaultCellStyle.WrapMode = DataGridViewTriState.True

            End With

            With FrmBatchReceipt.DGV_BATCHRECEIP
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With

            FrmBatchReceipt.DGV_BATCHRECEIP.ScrollBars = ScrollBars.Both

        Catch ex As Exception
            WriteLog("Error 1127 DisplayDGV_BATCHRCP() : " & ex.Message)
        End Try
    End Sub

    Public Function ProcessRCPDATA(ByRef RCPSEQ As String, ByRef RCPNO As String, ByVal DTsum As DataTable) As DataTable
        Dim DTRCPHEAD As DataTable = New DataTable
        Dim STRCOL As String = PROCESS.COLNAME("RCPHEAD")
        Dim ArrSTRCOL() As String = STRCOL.Split(",")

        'add columns
        If DTRCPHEAD.Columns.Count = 0 Then
            For i = 0 To ArrSTRCOL.Length - 1
                DTRCPHEAD.Columns.Add(ArrSTRCOL(i))
            Next
        End If
        'add rows 
        Dim IDCUST, INVDATE, RECEIVEDOCDATE, RECEIVEDATE, AMT, NETAMT, REF_0, COMMENT, STA_0, PAYDATE, CRCARDNO, TRANSBANKCODE, TRANSBANKNO, TRANSFEE As String
        Dim CHEQNO, CHEQBRANCH, CHEQACCT, CHEQDATE As String
        Dim BILLHTEXT1, BILLHTEXT2, BILLHTEXT3, BILLHTEXT4, BILLHTEXT5, BILLHTEXT6, BILLHTEXT7, BILLHTEXT8, BILLHTEXT9, BILLHTEXT10 As String
        Dim BANKBATCH, CHEQBANK, CBDATE As String
        If FrmReceipt.TXTRCP_RCPNO.Text.TrimEnd = "***New***" Then
            RCPSEQ = RUNSEQ("RCPHEAD")
            If FrmReceipt.BTN_Receipt.Checked = True Then
                RCPNO = DOCRUNNO("RCPHEAD")

            Else
                RCPNO = DOCRUNNO("RCPTAX")
            End If
            If RCPNO = Nothing Then
                Return Nothing
                Exit Function
            End If
        Else

            RCPNO = FrmReceipt.TXTRCP_RCPNO.Text
            RCPSEQ = MASTER.GET_RCPSEQ(RCPNO)
        End If

        IDCUST = FrmReceipt.TXTRCP_IDCUST.Text.TrimEnd
        RECEIVEDOCDATE = Format(FrmReceipt.txtRCP_INVDATE.Value, "yyyyMMdd")
        RECEIVEDATE = Format(FrmReceipt.txtRCP_DOCDATE.Value, "yyyyMMdd")
        REF_0 = FrmReceipt.TXTRCP_REF.Text.TrimEnd
        COMMENT = FrmReceipt.txtRCP_Comment.Text.TrimEnd
        NETAMT = SUM_RCPAMT(DTsum)
        AMT = SUM_AMTNET(DTsum)
        Dim PAYTYPE As Integer
        If FrmReceipt.BTNRCP_CASH.Checked = True Then
            PAYTYPE = 2
            PAYTYPE = 1
        ElseIf FrmReceipt.BTNRCP_Cheque.Checked = True Then
        ElseIf FrmReceipt.BTNRCP_Credit.Checked = True Then
            PAYTYPE = 3
        ElseIf FrmReceipt.BTNRCP_TRANSFER.Checked = True Then
            PAYTYPE = 4

        End If
        PAYDATE = Format(FrmReceipt.TXTRCP_PAYDATE.Value, "yyyyMMdd")
        CRCARDNO = FrmReceipt.TXTRCP_CRCARDNO.Text.TrimEnd
        TRANSBANKCODE = FrmReceipt.TXTRCP_TRANSBANKCODE.Text.TrimEnd
        TRANSBANKNO = FrmReceipt.TXTRCP_TRANSBANKNO.Text.TrimEnd
        If FrmReceipt.TXTRCP_TRANSFEE.Text.TrimEnd = "" Then
            TRANSFEE = 0
        Else
            TRANSFEE = FrmReceipt.TXTRCP_TRANSFEE.Text.TrimEnd
        End If
        CHEQNO = FrmReceipt.TXTRCP_CHEQNO.Text.TrimEnd
        CHEQBRANCH = FrmReceipt.TXTRCP_CHEQBRANCH.Text.TrimEnd
        CHEQACCT = FrmReceipt.TXTRCP_CHEQACCT.Text.TrimEnd
        CHEQDATE = Format(FrmReceipt.TXTRCP_PAYDATE.Value, "yyyyMMdd")
        Dim SHOWCHEQDATE, SHOWRECEIVEDATE As Integer
        If FrmReceipt.BTN_SHOWCHEQDATE.Checked = True Then
            SHOWCHEQDATE = 1
        Else
            SHOWCHEQDATE = 0
        End If

        If FrmReceipt.BTNRCP_SHOWRECEIVEDATE.Checked = True Then
            SHOWRECEIVEDATE = 1
        Else
            SHOWRECEIVEDATE = 0
        End If


        STA_0 = 1
        Dim VBILLHTEXT1, VBILLHTEXT2, VBILLHTEXT3, VBILLHTEXT4, VBILLHTEXT5, VBILLHTEXT6, VBILLHTEXT7, VBILLHTEXT8, VBILLHTEXT9, VBILLHTEXT10 As String
        For J = 0 To DT_TEMPOPTFD.Rows.Count - 1
            Select Case J
                Case 0
                    VBILLHTEXT1 = DT_TEMPOPTFD.Rows(J).Item("VALUE").ToString
                Case 1
                    VBILLHTEXT2 = DT_TEMPOPTFD.Rows(J).Item("VALUE").ToString
                Case 2
                    VBILLHTEXT3 = DT_TEMPOPTFD.Rows(J).Item("VALUE").ToString
                Case 3
                    VBILLHTEXT4 = DT_TEMPOPTFD.Rows(J).Item("VALUE").ToString
                Case 4
                    VBILLHTEXT5 = DT_TEMPOPTFD.Rows(J).Item("VALUE").ToString
                Case 5
                    VBILLHTEXT6 = DT_TEMPOPTFD.Rows(J).Item("VALUE").ToString
                Case 6
                    VBILLHTEXT7 = DT_TEMPOPTFD.Rows(J).Item("VALUE").ToString
                Case 7
                    VBILLHTEXT8 = DT_TEMPOPTFD.Rows(J).Item("VALUE").ToString
                Case 8
                    VBILLHTEXT9 = DT_TEMPOPTFD.Rows(J).Item("VALUE").ToString
                Case 9
                    VBILLHTEXT10 = DT_TEMPOPTFD.Rows(J).Item("VALUE").ToString
            End Select

        Next
        BILLHTEXT1 = VBILLHTEXT1
        BILLHTEXT2 = VBILLHTEXT2
        BILLHTEXT3 = VBILLHTEXT3
        BILLHTEXT4 = VBILLHTEXT4
        BILLHTEXT5 = VBILLHTEXT5
        BILLHTEXT6 = VBILLHTEXT6
        BILLHTEXT7 = VBILLHTEXT7
        BILLHTEXT8 = VBILLHTEXT8
        BILLHTEXT9 = VBILLHTEXT9
        BILLHTEXT10 = VBILLHTEXT10

        BANKBATCH = FrmReceipt.txtBANKBATCH.Text.TrimEnd
        CHEQBANK = FrmReceipt.BTNRCP_CHQBANKCODE.Text.TrimEnd
        CBDATE = Format(FrmReceipt.txt_RCPDATECB.Value, "yyyyMMdd")

        Dim row As String() = New String() {RCPSEQ, RCPNO, IDCUST, RECEIVEDOCDATE, RECEIVEDATE, "", AMT, NETAMT, REF_0, COMMENT, PAYTYPE, PAYDATE, CRCARDNO, TRANSBANKCODE, TRANSBANKNO, TRANSFEE, CHEQNO, CHEQBRANCH, CHEQACCT, CHEQDATE, SHOWCHEQDATE, SHOWRECEIVEDATE, STA_0, BILLHTEXT1, BILLHTEXT2, BILLHTEXT3, BILLHTEXT4, BILLHTEXT5, BILLHTEXT6, BILLHTEXT7, BILLHTEXT8, BILLHTEXT9, BILLHTEXT10, "", "", BANKBATCH, CHEQBANK, CBDATE}
        DTRCPHEAD.Rows.Add(row)
        Return DTRCPHEAD
    End Function

    Public Function ProcessRCPDETAILDATA(ByVal RCPSEQ As String, ByVal RCPNO As String, ByVal DT As DataTable, ByRef DTT As DataTable) As DataTable
        Dim DTRCPDETAIL As DataTable = New DataTable
        Dim STRCOL As String = PROCESS.COLNAME("RCPDETAIL")
        Dim ArrSTRCOL() As String = STRCOL.Split(",")
        'add columns
        If DTRCPDETAIL.Columns.Count = 0 Then
            For i = 0 To ArrSTRCOL.Length - 1
                DTRCPDETAIL.Columns.Add(ArrSTRCOL(i))
            Next
        End If
        'add rows 
        Dim DETAILLINE, IDCUST, BILLNO, INVNO, INVDATE, DUEDATE, PONUM, LINEAMOUNT, AMTOUTSTAND, NETAMT, CHECK_0, STA_0, RCPDTEXT1, RCPDTEXT2, RCPDTEXT3, RCPDTEXT4, RCPDTEXT5, RCPDTEXT6, RCPDTEXT7, RCPDTEXT8, RCPDTEXT9, RCPDTEXT10 As String
        Dim UNITPRICE, VATAMT, RCPAMT, AMT, VAT As String
        'DT FILTER SELECT INVOICE
        'If FrmReceipt.TXTRCP_RCPNO.Text.TrimEnd = "***New***" Then

        DTT = DT.Clone
        If DT.Rows.Count > 0 Then

            'For J = 0 To DT.Rows.Count - 1

            '    If DT.Rows(J).Item("CHECK_0").ToString <> "True" Then
            '        DT.Rows(J).Delete()

            '    End If
            'Next


            For Each rows As DataRow In DT.Rows
                If rows.Item("CHECK_0").ToString = "True" Then
                    DTT.ImportRow(rows)
                End If
            Next

        Else
            Return DT
            Exit Function
        End If

        'DT.AcceptChanges()

        If DTT.Rows.Count > 0 Then
            For I = 0 To DTT.Rows.Count - 1
                DETAILLINE = I + 1
                IDCUST = DTT.Rows(I).Item("IDCUST").ToString.TrimEnd
                BILLNO = DTT.Rows(I).Item("BILLNO").ToString.TrimEnd
                INVNO = DTT.Rows(I).Item("IDINVC").ToString.TrimEnd
                INVDATE = CDate(DTT.Rows(I).Item("INVDATE").ToString).ToString("yyyyMMdd")
                DUEDATE = CDate(DTT.Rows(I).Item("DUEDATE").ToString).ToString("yyyyMMdd")
                'PONUM = DT.Rows(I).Item("PONUM").ToString.TrimEnd
                'LINEAMOUNT = DT.Rows(I).Item("LINEAMOUNT").ToString.TrimEnd
                NETAMT = DTT.Rows(I).Item("NETAMT").ToString.TrimEnd
                AMTOUTSTAND = DTT.Rows(I).Item("AMTOUTSTAND").ToString.TrimEnd
                UNITPRICE = DTT.Rows(I).Item("UNITPRICE").ToString.TrimEnd
                VATAMT = DTT.Rows(I).Item("VATAMT").ToString.TrimEnd
                RCPAMT = DTT.Rows(I).Item("RCPAMT").ToString.TrimEnd
                AMT = DTT.Rows(I).Item("AMT").ToString.TrimEnd
                CHECK_0 = "True"
                STA_0 = 1
                RCPDTEXT1 = DTT.Rows(I).Item("RCPDTEXT1").ToString.TrimEnd
                RCPDTEXT2 = DTT.Rows(I).Item("RCPDTEXT2").ToString.TrimEnd
                RCPDTEXT3 = DTT.Rows(I).Item("RCPDTEXT3").ToString.TrimEnd
                RCPDTEXT4 = DTT.Rows(I).Item("RCPDTEXT4").ToString.TrimEnd
                RCPDTEXT5 = DTT.Rows(I).Item("RCPDTEXT5").ToString.TrimEnd
                RCPDTEXT6 = DTT.Rows(I).Item("RCPDTEXT6").ToString.TrimEnd
                RCPDTEXT7 = DTT.Rows(I).Item("RCPDTEXT7").ToString.TrimEnd
                RCPDTEXT8 = DTT.Rows(I).Item("RCPDTEXT8").ToString.TrimEnd
                RCPDTEXT9 = DTT.Rows(I).Item("RCPDTEXT9").ToString.TrimEnd
                RCPDTEXT10 = DTT.Rows(I).Item("RCPDTEXT10").ToString.TrimEnd
                VAT = DTT.Rows(I).Item("VAT").ToString.TrimEnd
                Dim row As String() = New String() {RCPSEQ, RCPNO, DETAILLINE, BILLNO, IDCUST, INVNO, INVDATE, DUEDATE, PONUM, UNITPRICE, VATAMT, RCPAMT, AMTOUTSTAND, NETAMT, AMT, CHECK_0, STA_0, RCPDTEXT1, RCPDTEXT2, RCPDTEXT3, RCPDTEXT4, RCPDTEXT5, RCPDTEXT6, RCPDTEXT7, RCPDTEXT8, RCPDTEXT9, RCPDTEXT10, "", VAT}
                DTRCPDETAIL.Rows.Add(row)
            Next
            DTRCPDETAIL.AcceptChanges()
        End If
        Return DTRCPDETAIL
    End Function

#End Region

#Region "EVENT"

    Sub SelectALL(ByVal DGV As DataGridView, ByVal CHECKSTATE As Boolean, ByVal INDEX As Integer)
        Try
            If CHECKSTATE = True Then

                For i = 0 To DGV.Rows.Count - 1

                    DGV.Rows(i).Cells(INDEX).Value = True

                Next
                'Call FrmReceipt.AMOUNTCHANGE(0)
            Else
                For i = 0 To DGV.Rows.Count - 1
                    DGV.Rows(i).Cells(INDEX).Value = False
                Next
                FrmBillingNote.txtBILLAMOUNT.Text = "0.00"
                FrmReceipt.txtRCPAMOUNT.Text = "0.00"

            End If
        Catch ex As Exception
            WriteLog("ERROR 1060 SelectALL(): " & ex.Message)
        End Try
    End Sub

    Public Function CONVERTDGVtoDATATABLE(ByVal DGV As DataGridView) As DataTable
        Dim dt As DataTable = New DataTable()
        Try

            For Each col As DataGridViewColumn In DGV.Columns
                If dt.Columns.Contains(col.Name) = False Then
                    dt.Columns.Add(col.Name)
                End If
                Select Case col.Name
                    Case "LINEAMOUNT"
                        dt.Columns("LINEAMOUNT").DataType = GetType(Decimal)
                    Case "AMTOUTSTAND"
                        dt.Columns("AMTOUTSTAND").DataType = GetType(Decimal)
                    Case "NETAMT"
                        dt.Columns("NETAMT").DataType = GetType(Decimal)
                    Case "UNITPRICE"
                        dt.Columns("UNITPRICE").DataType = GetType(Decimal)
                    Case "VATAMT"
                        dt.Columns("VATAMT").DataType = GetType(Decimal)
                    Case "RCPAMT"
                        dt.Columns("RCPAMT").DataType = GetType(Decimal)
                    Case "AMT"
                        dt.Columns("AMT").DataType = GetType(Decimal)
                    Case "VAT"
                        dt.Columns("VAT").DataType = GetType(Decimal)
                End Select
            Next


            For Each row As DataGridViewRow In DGV.Rows
                Dim dRow As DataRow = dt.NewRow()

                For Each cell As DataGridViewCell In row.Cells
                    If cell.ColumnIndex = dt.Columns.Count Then

                    Else
                        dRow(cell.ColumnIndex) = cell.Value
                    End If

                Next

                dt.Rows.Add(dRow)
            Next

        Catch ex As Exception
            WriteLog("ERROR 1225 CONVERTDGVtoDATATABLE():  " & ex.Message)
        End Try

        Return dt
    End Function

    Sub ShowFrmPrintINV(ByVal DocType)
        Try

            'FrmPrintInvoice.Show(MAIN)
            If FrmPrintInvoice.WindowState = FormWindowState.Maximized Or FrmPrintInvoice.WindowState = FormWindowState.Normal Or FrmPrintInvoice.WindowState = FormWindowState.Minimized Then
                FrmPrintInvoice.Close()
                FrmPrintInvoice.Show(MAIN)
            Else
                FrmPrintInvoice.Show(MAIN)
            End If
            If DocType = "BILL" Then
                'FrmPrintInvoice.Show()
                FrmPrintInvoice.Text = "BILL"
                FrmPrintInvoice.txtHeaderINV.Text = "รายงานใบวางบิล"
            Else
                'FrmPrintInvoice.Show()
                FrmPrintInvoice.Text = "RECEIPT"
                FrmPrintInvoice.txtHeaderINV.Text = "รายงานใบเสร็จรับเงิน"
            End If


        Catch ex As Exception
            MessageBox.Show("Error 1385 (ShowFrmPrintINV): " & ex.Message)
        End Try
    End Sub

    Sub ShowFrmPrintBillSummary(ByVal DocType)
        Try

            If FrmPrintBillSummary.WindowState = FormWindowState.Maximized Or FrmPrintBillSummary.WindowState = FormWindowState.Normal Or FrmPrintBillSummary.WindowState = FormWindowState.Minimized Then
                FrmPrintBillSummary.Close()
                FrmPrintBillSummary.Show(MAIN)
            Else
                FrmPrintBillSummary.Show(MAIN)
            End If

            If DocType = "BILL" Then

                FrmPrintBillSummary.Text = "BILL"
                FrmPrintBillSummary.txtHeader.Text = "รายงานสรุปใบวางบิล"
                FrmPrintBillSummary.lb_date.Text = "วันที่ใบวางบิล"
                FrmPrintBillSummary.lb_Doc.Text = "เลขที่ใบวางบิล"
            Else
                'FrmPrintBillSummary.Show()
                FrmPrintBillSummary.Text = "RECEIPT"
                FrmPrintBillSummary.txtHeader.Text = "รายงานสรุปใบเสร็จรับเงิน"
                FrmPrintBillSummary.lb_date.Text = "วันที่ใบเสร็จรับเงิน"
                FrmPrintBillSummary.lb_Doc.Text = "เลขที่ใบเสร็จรับเงิน"
                FrmPrintBillSummary.txtReport_CBIMPORT.Visible = True
                FrmPrintBillSummary.txtReport_CBIMPORT.Checked = True
            End If

        Catch ex As Exception
            MessageBox.Show("Error 1400 (ShowFrmPrintBillSummary): " & ex.Message)
        End Try
    End Sub

    Public Function CHECK_selectDetail(ByVal dt As DataTable) As Boolean
        Dim bool As Boolean = False
        If dt.Rows.Count > 0 Then
            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i).Item("CHECK_0").ToString = "True" Then
                    bool = True
                End If
            Next
        End If
        Return bool
    End Function

    Sub ShowHelp()
        System.Diagnostics.Process.Start(My.Application.Info.DirectoryPath & "\Configure\FMSBILLING_MANUAL.PDF")
    End Sub

#End Region



End Module
