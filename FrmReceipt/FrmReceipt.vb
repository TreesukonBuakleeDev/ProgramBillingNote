Public Class FrmReceipt
    Public TEMPRCP_AMTOUSTAND As Decimal
    Private Sub FrmReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'FrmBatchReceipt.WindowState = FormWindowState.Minimized
            WindowState = FormWindowState.Maximized
            'BTNRCP_CASH.Checked = True
            BTNRCP_Cheque.Checked = True
            BTNRCP_SHOWRECEIVEDATE.Checked = True
            'BTN_Receipt.Checked = True
            Dim dtRun As DataTable = New DataTable
            dtRun = MASTER.GETDATA_RUNNO()
            If dtRun.Rows.Count > 0 Then
                Select Case dtRun.Rows(0).Item("RCPTYPE").ToString.TrimEnd
                    Case "TAX"
                        BTN_TAXReceipt.Checked = True
                    Case "RC"
                        BTN_Receipt.Checked = True
                    Case Else
                        BTN_TAXReceipt.Checked = True
                End Select
            Else
                BTN_TAXReceipt.Checked = True
            End If

            TXTRCP_BILLNOTo.Text = "ZZZZZZ"
        Catch ex As Exception
            WriteLog("ERROR 10 (FrmReceipt_Load) : " & ex.Message)
        End Try
    End Sub

#Region "BUTTON"
    Private Sub BTN_GETRCP_Click(sender As Object, e As EventArgs) Handles BTN_RCPGET.Click
        Try
            txtRCPAMOUNT.Text = ""
            Dim IDCUST As String = TXTRCP_IDCUST.Text
            If IDCUST = "" Then
                IDCUST = "ZZZZZZ"
            End If
            Dim dtRCP As DataTable = New DataTable
            If TXTRCP_RCPNO.Text = "***New***" Then
                dtRCP = MASTER.GETDATA_SOURCERCPDETAIL(IDCUST, TXTRCP_BILLNOFrom.Text, TXTRCP_BILLNOTo.Text)
            Else
                Dim StrCONDITION As String
                StrCONDITION = Text_UNIONRCP(TXTRCP_RCPNO.Text)

                dtRCP = MASTER.GETDATA_SOURCERCPDETAIL(IDCUST, TXTRCP_BILLNOFrom.Text, TXTRCP_BILLNOTo.Text, "", StrCONDITION)
            End If
            Call DisplayDGVRCP(dtRCP)

        Catch ex As Exception
            WriteLog("Error 27 (BTN_GETRCP_Click) : " & ex.Message)
        End Try
    End Sub

    Private Sub BTN_RCPOPTFD_Click(sender As Object, e As EventArgs) Handles BTN_RCPOPTFD.Click
        Try
            FrmOPTFDVALUE.GET_OPTFDVALUE("RCPHTEXT", TXTRCP_RCPNO.Text, TXTRCP_IDCUST.Text)
        Catch ex As Exception
            WriteLog("ERROR 33 (FrmReceipt_Load) : " & ex.Message)
        End Try
    End Sub
    Private Sub BTNBill_POST_Click(sender As Object, e As EventArgs) Handles BTNBill_POST.Click
        Try
            Dim dialogOK As DialogResult = MsgBox("Do you confirm to save the receipt ?", MessageBoxButtons.OKCancel)
            If dialogOK = DialogResult.OK Then

                If TXTRCP_RCPNO.Text.TrimEnd = "***New***" Then

                    'CHECK SAVE
                    If BTNRCP_Cheque.Checked = True Then
                        If TXTRCP_CHEQNO.Text.TrimEnd = "" Or BTNRCP_CHQBANKCODE.Text.TrimEnd = "" Or TXTRCP_CHEQBRANCH.Text.TrimEnd = "" Then
                            MessageBox.Show("Please enter cheque information")
                            Exit Try
                        End If
                    End If
                    If BTNRCP_Credit.Checked = True Then
                        If TXTRCP_CRCARDNO.Text.TrimEnd = "" Then
                            MessageBox.Show("Please enter credit card information")
                            Exit Try
                        End If
                    End If

                    If BTNRCP_TRANSFER.Checked = True Then
                        If TXTRCP_TRANSBANKCODE.Text.TrimEnd = "" Or TXTRCP_TRANSBANKNO.Text.TrimEnd = "" Or TXTRCP_TRANSFEE.Text.TrimEnd = "" Then
                            MessageBox.Show("Please enter bank transfer information")
                            Exit Try
                        End If
                    End If

                    Try
                        Dim DTRCPHEAD As DataTable
                        Dim DTRCPDETAIL As DataTable
                        Dim RCPSEQ As String = ""
                        Dim RCPNO As String = ""
                        Dim DT As DataTable = New DataTable
                        Dim DTDISPLAY As DataTable = New DataTable
                        'DT = CType(DGV_RCP.DataSource, DataTable).Copy
                        DT = CONVERTDGVtoDATATABLE(DGV_RCP)

                        If DT.Rows.Count > 0 Then
                            If PROCESS.CHECK_selectDetail(DT) = False Then
                                MessageBox.Show("Please select at least one transaction.")
                                Exit Sub
                            End If
                            DT = ProcessCALOUTSTANDING(DT, "RCP")

                            DGV_RCP.DataSource = Nothing


                            DTRCPHEAD = ProcessRCPDATA(RCPSEQ, RCPNO, DT)
                            If DTRCPHEAD Is Nothing Then
                                Exit Try
                            End If
                            DTRCPDETAIL = ProcessRCPDETAILDATA(RCPSEQ, RCPNO, DT, DTDISPLAY)
                            Call DATACLASS.INSERTRCPHEADER(DTRCPHEAD)
                            Call DATACLASS.INSERTRCPDETAIL(DTRCPDETAIL)
                            Call DATACLASS.UPDATEFMSRCPDETAIL_AMTOUTSTAND(DTRCPDETAIL)

                            DisplayDGVRCP(DTDISPLAY)
                            Call AMOUNTCHANGE(0)
                            'DisplayDGVRCP(DTRCPDETAIL)

                            TXTRCP_RCPNO.Text = RCPNO
                        Else

                        End If

                    Catch ex As Exception
                        WriteLog("ERROR 88 " & ex.Message)
                    End Try
                Else
                    'CHK UPDATE 
                    Try
                        Dim DTRCPHEAD As DataTable
                        Dim DTRCPDETAIL As DataTable
                        Dim RCPSEQ As String = ""
                        Dim RCPNO As String = ""
                        Dim DT As DataTable = New DataTable
                        Dim DTDISPLAY As DataTable = New DataTable
                        ''DT = CType(DGV_RCP.DataSource, DataTable).Copy
                        'DT = CONVERTDGVtoDATATABLE(DGV_RCP)

                        ''DT = ProcessCALOUTSTANDING(DT, "RCP")
                        'DGV_RCP.DataSource = Nothing


                        'DTRCPHEAD = ProcessRCPDATA(RCPSEQ, RCPNO, DT)
                        ''DTRCPDETAIL = ProcessRCPDETAILDATA(RCPSEQ, RCPNO, DT)

                        ''UPDATE


                        'Call DATACLASS.INSERTUpdateRCPHEADER(DTRCPHEAD)
                        ''Call DATACLASS.INSERTUpdateRCPDETAIL(DTRCPDETAIL)
                        ''Call DATACLASS.UPDATEFMSRCPDETAIL_AMTOUTSTAND(DTRCPDETAIL)
                        'DisplayDGVRCP(DT)
                        ''DisplayDGVRCP(DTRCPDETAIL)
                        'TXTRCP_RCPNO.Text = RCPNO

                        'Update Header

                        DT = CONVERTDGVtoDATATABLE(DGV_RCP)
                        If PROCESS.CHECK_selectDetail(DT) = False Then
                            MessageBox.Show("Please select at least one transaction.")
                            Exit Sub
                        End If
                        DGV_RCP.DataSource = Nothing
                        DTRCPHEAD = ProcessRCPDATA(RCPSEQ, RCPNO, DT)
                        If DTRCPHEAD Is Nothing Then
                            Exit Try
                        End If
                        DTRCPDETAIL = ProcessRCPDETAILDATA(RCPSEQ, RCPNO, DT, DTDISPLAY)
                        Call DATACLASS.INSERTUpdateRCPHEADER(DTRCPHEAD)
                        Call DATACLASS.INSERTUpdateRCPDETAIL(DTRCPDETAIL)
                        Call DATACLASS.UPDATEFMSRCPDETAIL_AMTOUTSTAND(DTRCPDETAIL)
                        DisplayDGVRCP(DTDISPLAY)

                        '  DisplayDGVRCP(DTRCPDETAIL)
                        TXTRCP_RCPNO.Text = RCPNO
                        FrmBatchReceipt.BTNBTCH_REFRESHRCP_Click(Nothing, Nothing)
                        Call AMOUNTCHANGE(0)

                    Catch ex As Exception
                        WriteLog("ERROR 160 " & ex.Message)
                    End Try


                End If

            Else
                Exit Try
            End If

            'Call AMOUNTCHANGE(0)
        Catch ex As Exception
            WriteLog("ERROR 180 " & ex.Message)
        End Try
        'REFRESH BATCH LIST FORM
        FrmBatchReceipt.BTNBTCH_REFRESHRCP_Click(Nothing, Nothing)
    End Sub
    Private Sub BTN_BILLFINDCUST_Click(sender As Object, e As EventArgs) Handles BTN_BILLFINDCUST.Click
        Try
            MAIN.txtForm.Text = "FrmReceipt"
            FrmSearch.txtSearch.Text = "FrmReceiptCUST"
            Call FrmSearch.SearchShow("IDCUST", "NAMECUST", "Customer Number", "Customer Name", "", "")
        Catch ex As Exception
            WriteLog("ERROR 145 (FrmReceipt_Load) : " & ex.Message)
        End Try
    End Sub
    Private Sub BTN_RCPBILLFROM_Click(sender As Object, e As EventArgs) Handles BTN_RCPBILLFROM.Click
        Try

            MAIN.txtForm.Text = "FrmReceipt"
            FrmSearch.txtSearch.Text = "RCP Billing Note Number"
            Call FrmSearch.SearchShow("RCPNO", "IDCUST", "Billing Number", "Customer Number", "NAMECUST", "Customer Name")

        Catch ex As Exception
            WriteLog("ERROR 154 (BTN_RCPBILLFROM_Click)" & ex.Message)
        End Try
    End Sub

    Private Sub BTN_RCPBILLTO_Click(sender As Object, e As EventArgs) Handles BTN_RCPBILLTO.Click
        Try

            MAIN.txtForm.Text = "FrmReceipt"
            FrmSearch.txtSearch.Text = "RCP To Billing Note Number"
            Call FrmSearch.SearchShow("RCPNO", "IDCUST", "Billing Number", "Customer Number", "NAMECUST", "Customer Name")

        Catch ex As Exception
            WriteLog("ERROR 175 (BTN_RCPBILLTO_Click)" & ex.Message)
        End Try
    End Sub

    Private Sub BTNBill_NEW_Click(sender As Object, e As EventArgs) Handles BTNBill_NEW.Click
        Try
            TXTRCP_RCPNO.Text = "***New***"
            BTNBill_POST.Enabled = True
            BTNBill_DELETE.Enabled = True
            DGV_RCP.DataSource = Nothing
            Dim dtRCP As DataTable = New DataTable
            Dim clonedtRCP = MASTER.GETDATA_SOURCERCPDETAIL(TXTRCP_IDCUST.Text, TXTRCP_BILLNOFrom.Text, TXTRCP_BILLNOTo.Text)
            dtRCP = clonedtRCP.Clone
            Call DisplayDGVRCP(dtRCP)
        Catch ex As Exception
            WriteLog("ERROR 142 " & ex.Message)
        End Try
    End Sub

    Private Sub BTNBill_DELETE_Click(sender As Object, e As EventArgs) Handles BTNBill_DELETE.Click
        Try
            Dim dialogOK As DialogResult = MsgBox("Do you confirm to delete the receipt ?", MessageBoxButtons.OKCancel)
            If dialogOK = DialogResult.OK Then
                Dim BILLNO As String = TXTRCP_RCPNO.Text
                ' Call DATACLASS.DELETEFMSRCPHEAD(BILLNO)
                Call DATACLASS.DELETEFMSRCPHEAD_REVISE(BILLNO)
                TXTRCP_RCPNO.Text = "***New***"
                DGV_RCP.DataSource = Nothing
                'REFRESH 
                Dim dtRCP As DataTable = New DataTable
                dtRCP = MASTER.GETDATA_SOURCERCPDETAIL(TXTRCP_IDCUST.Text, TXTRCP_BILLNOFrom.Text, TXTRCP_BILLNOTo.Text)
                Call DisplayDGVRCP(dtRCP)
            Else
            End If
        Catch ex As Exception
            WriteLog("ERROR 161 " & ex.Message)
        End Try
    End Sub

    Private Sub BTNBill_PRINT_Click(sender As Object, e As EventArgs) Handles BTNRCP_PRINT.Click
        Try
            Dim rcpno As String = TXTRCP_RCPNO.Text
            Call FrmPrintRCP.ShowRCPReport(rcpno)
        Catch ex As Exception
            WriteLog("ERROR 170 (BTNBill_PRINT_Click) : " & ex.Message)
        End Try
    End Sub

    Sub BTNRCP_ALL_CheckedChanged(sender As Object, e As EventArgs) Handles BTNRCP_ALL.CheckedChanged
        Try
            Dim dt As DataTable = New DataTable
            Dim index As Integer
            'dt = CType(DGV_RCP.DataSource, DataTable).Copy
            dt = CONVERTDGVtoDATATABLE(DGV_RCP)
            If dt IsNot Nothing Then
                index = dt.Columns.Count
            Else
                index = 25
            End If
            SelectALL(DGV_RCP, BTNRCP_ALL.Checked, index)
        Catch ex As Exception
            WriteLog("ERROR  186 : " & ex.Message)
        End Try
    End Sub

    Private Sub BTNBill_REFRESH_Click(sender As Object, e As EventArgs) Handles BTNBill_REFRESH.Click
        Me.Close()
    End Sub

#Region "PAY METHOD"
    Private Sub BTNRCP_CASH_CheckedChanged(sender As Object, e As EventArgs) Handles BTNRCP_CASH.CheckedChanged
        Try
            'BTNRCP_CASH.Checked = False
            BTNRCP_Cheque.Checked = False
            BTNRCP_Credit.Checked = False
            BTNRCP_TRANSFER.Checked = False
            TabControl1.Enabled = False
            BTNRCP_CHQBANKCODE.Text = ""
            TXTRCP_CHEQBRANCH.Text = ""
            TXTRCP_CHEQNO.Text = ""
            TXTRCP_CRCARDNO.Text = ""
            TXTRCP_TRANSBANKCODE.Text = ""
            TXTRCP_TRANSBANKNO.Text = ""
            TXTRCP_TRANSFEE.Text = ""
        Catch ex As Exception
            WriteLog("ERROR 203 (BTNRCP_CASH_CheckedChanged) :" & ex.Message)
        End Try
    End Sub

    Private Sub BTNRCP_Cheque_CheckedChanged(sender As Object, e As EventArgs) Handles BTNRCP_Cheque.CheckedChanged
        Try
            BTNRCP_CASH.Checked = False
            'BTNRCP_Cheque.Checked = False
            BTNRCP_Credit.Checked = False
            BTNRCP_TRANSFER.Checked = False
            TabControl1.Enabled = True
        Catch ex As Exception
            WriteLog("ERROR 215 (BTNRCP_Cheque_CheckedChanged :" & ex.Message)
        End Try
    End Sub

    Private Sub BTNRCP_Credit_CheckedChanged(sender As Object, e As EventArgs) Handles BTNRCP_Credit.CheckedChanged
        Try
            BTNRCP_CASH.Checked = False
            BTNRCP_Cheque.Checked = False
            'BTNRCP_Credit.Checked = False
            BTNRCP_TRANSFER.Checked = False
            TabControl1.Enabled = True
        Catch ex As Exception
            WriteLog("ERROR 227 ( BTNRCP_Credit_CheckedChanged :" & ex.Message)
        End Try
    End Sub

    Private Sub BTNRCP_TRANSFER_CheckedChanged(sender As Object, e As EventArgs) Handles BTNRCP_TRANSFER.CheckedChanged
        Try
            BTNRCP_CASH.Checked = False
            BTNRCP_Cheque.Checked = False
            BTNRCP_Credit.Checked = False
            TabControl1.Enabled = True
        Catch ex As Exception
            WriteLog("ERROR 238) BTNRCP_TRANSFER_CheckedChanged :" & ex.Message)
        End Try
    End Sub


#End Region

#End Region

#Region "EVENT"

    Sub DisplayDGVRCP(ByVal dtRCP As DataTable)
        DGV_RCP.DataSource = Nothing
        Try
            Dim DTmerge As DataTable = New DataTable
            DTmerge = MergeTransaction(dtRCP)

            'Display Line No
            If DTmerge.Columns.Contains("No") = False Then
                DTmerge.Columns.Add("No")
                If DTmerge.Rows.Count > 0 Then
                    For i = 0 To DTmerge.Rows.Count - 1
                        DTmerge.Rows(i).Item("No") = i + 1
                    Next
                End If
            Else
                're-line No After Save bill
                If DTmerge.Rows.Count > 0 Then
                    Dim j = 0
                    For i = 0 To DTmerge.Rows.Count - 1
                        If DTmerge.Rows(i).Item("CHECK_0").ToString = "True" Then
                            j = j + 1
                            DTmerge.Rows(i).Item("No") = j
                        End If
                    Next
                End If
            End If

            DGV_RCP.DataSource = DTmerge

            If DGV_RCP.Columns.Contains("CHECK_0") = True Then
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
                'dtgCheckbox.DisplayIndex = 1

                DGV_RCP.Columns.Add(dtgCheckbox)
            End If

            With DGV_RCP
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "รหัสลูกค้า"
                .Columns("BILLNO").HeaderCell.Value = "เลขที่บิล"
                .Columns(3).HeaderCell.Value = "เลขที่ใบแจ้งหนี้"
                .Columns(4).HeaderCell.Value = "วันที่ใบแจ้งหนี้"
                .Columns(5).HeaderCell.Value = "วันที่ครบกำหนด"
                .Columns(6).HeaderCell.Value = "จำนวนเงินก่อน VAT"
                .Columns(7).HeaderCell.Value = "ภาษีมูลค่าเพิ่ม"
                .Columns(9).HeaderCell.Value = "ยอดคงเหลือ"
                .Columns(8).HeaderCell.Value = "จำนวนเงินรับ"
                .Columns(11).HeaderCell.Value = "จำนวนเงินรวม"

                .Columns(13).HeaderCell.Value = "สถานะ"
                .Columns(24).HeaderCell.Value = "ภาษี"

                .Columns(4).Width = 50
                .Columns(6).Width = 80
                .Columns(13).Width = 30
                .Columns(26).Width = 20
                .Columns(27).Width = 30

                ''Optional Field 
                Dim dtHEADEROPTFD As DataTable = New DataTable
                Dim CONDITION As String = "WHERE OPTFDID LIKE '%RCPDTEXT%'"
                dtHEADEROPTFD = MASTER.GETDATA_OPTFD(CONDITION)
                If dtHEADEROPTFD.Rows.Count <> 0 Then
                    For I = 0 To dtHEADEROPTFD.Rows.Count - 1
                        Dim OPTFDID As String = dtHEADEROPTFD.Rows(I).Item("OPTFDID").ToString
                        Dim OPTFDNAME As String = dtHEADEROPTFD.Rows(I).Item("OPTFDNAME").ToString
                        Dim OPTFDACTIVE As String = dtHEADEROPTFD.Rows(I).Item("ACTIVE").ToString
                        Select Case OPTFDID
                            Case "RCPDTEXT1"
                                .Columns(14).HeaderCell.Value = OPTFDNAME
                                If OPTFDACTIVE = "0" Then
                                    .Columns(14).Visible = False
                                End If
                            Case "RCPDTEXT2"
                                .Columns(15).HeaderCell.Value = OPTFDNAME
                                If OPTFDACTIVE = "0" Then
                                    .Columns(15).Visible = False
                                End If
                            Case "RCPDTEXT3"
                                .Columns(16).HeaderCell.Value = OPTFDNAME
                                If OPTFDACTIVE = "0" Then
                                    .Columns(16).Visible = False
                                End If
                            Case "RCPDTEXT4"
                                .Columns(17).HeaderCell.Value = OPTFDNAME
                                If OPTFDACTIVE = "0" Then
                                    .Columns(17).Visible = False
                                End If
                            Case "RCPDTEXT5"
                                .Columns(18).HeaderCell.Value = OPTFDNAME
                                If OPTFDACTIVE = "0" Then
                                    .Columns(18).Visible = False
                                End If
                            Case "RCPDTEXT6"
                                .Columns(19).HeaderCell.Value = OPTFDNAME
                                If OPTFDACTIVE = "0" Then
                                    .Columns(19).Visible = False
                                End If
                            Case "RCPDTEXT7"
                                .Columns(20).HeaderCell.Value = OPTFDNAME
                                If OPTFDACTIVE = "0" Then
                                    .Columns(20).Visible = False
                                End If
                            Case "RCPDTEXT8"
                                .Columns(21).HeaderCell.Value = OPTFDNAME
                                If OPTFDACTIVE = "0" Then
                                    .Columns(21).Visible = False
                                End If
                            Case "RCPDTEXT9"
                                .Columns(22).HeaderCell.Value = OPTFDNAME
                                If OPTFDACTIVE = "0" Then
                                    .Columns(22).Visible = False
                                End If
                            Case "RCPDTEXT10"
                                .Columns(23).HeaderCell.Value = OPTFDNAME
                                If OPTFDACTIVE = "0" Then
                                    .Columns(23).Visible = False
                                End If
                        End Select
                    Next
                Else
                    'Case initial 

                    .Columns(14).Visible = False
                    .Columns(15).Visible = False
                    .Columns(16).Visible = False
                    .Columns(17).Visible = False
                    .Columns(18).Visible = False
                    .Columns(19).Visible = False
                    .Columns(20).Visible = False
                    .Columns(21).Visible = False
                    .Columns(22).Visible = False
                    .Columns(23).Visible = False


                End If
            End With

            With DGV_RCP
                If .Columns.Contains("RCPNO") = True Then
                    .Columns("RCPNO").Visible = False
                End If


                .Columns(2).Visible = False
                .Columns(10).Visible = False
                .Columns(12).Visible = False
                .Columns(13).Visible = False
                .Columns(0).Visible = False

            End With

            With DGV_RCP
                .Columns(26).DisplayIndex = 0
                .Columns(27).DisplayIndex = 1
                .Columns(13).DisplayIndex = 2
                .Columns(0).DisplayIndex = 3
                .Columns("BILLNO").DisplayIndex = 4
                .Columns(3).DisplayIndex = 5
                .Columns(4).DisplayIndex = 6
                .Columns(5).DisplayIndex = 7

                .Columns(6).DisplayIndex = 8
                .Columns(7).DisplayIndex = 9
                .Columns(11).DisplayIndex = 10
                .Columns(8).DisplayIndex = 12
                .Columns(9).DisplayIndex = 11

            End With

            With DGV_RCP

                .Columns(0).ReadOnly = True
                .Columns(1).ReadOnly = True
                .Columns(4).ReadOnly = True
                .Columns(2).ReadOnly = True
                .Columns(3).ReadOnly = True

                .Columns(5).ReadOnly = True
                .Columns(6).ReadOnly = True
                .Columns(7).ReadOnly = True
                .Columns(8).ReadOnly = False
                .Columns(9).ReadOnly = True
                .Columns(11).ReadOnly = True
                .Columns(24).ReadOnly = False
                .Columns("BILLNO").ReadOnly = True
            End With

            With DGV_RCP
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray
                .EnableHeadersVisualStyles = False
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(5).DefaultCellStyle.Format = "N2"
                .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(6).DefaultCellStyle.Format = "N2"
                .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(7).DefaultCellStyle.Format = "N2"
                .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(8).DefaultCellStyle.Format = "N2"
                .Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(9).DefaultCellStyle.Format = "N2"
                .Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(11).DefaultCellStyle.Format = "N2"
                .Columns(24).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(24).DefaultCellStyle.Format = "N2"
                .Columns(26).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With
            For J = 0 To FrmBillingNote.DGV_BILL.Rows.Count - 1
                If FrmBillingNote.DGV_BILL.Rows(J).Cells(9).Value = 2 Then
                    FrmBillingNote.DGV_BILL.Rows(J).Cells(9).ReadOnly = True
                End If
            Next

        Catch ex As Exception
            WriteLog("Error 430 DisplayDGVRCP() : " & ex.Message)
        End Try
    End Sub

    Sub DisplayDGV_BATCHRCP(ByVal dtBATCHBILL As DataTable)
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
                .Columns(4).HeaderCell.Value = "วันที่ครบกำหนด"
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
                .Columns(6).Width = 100
                .Columns(7).Width = 100
            End With

            With FrmBatchBillingNote.DGV_BATCHBILL
                .ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray
                .EnableHeadersVisualStyles = False
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(5).DefaultCellStyle.Format = "N2"
            End With

        Catch ex As Exception
            WriteLog("Error 480 : (DisplayDGV_BATCHRCP) " & ex.Message)
        End Try
    End Sub

    Private Sub DGV_RCP_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_RCP.CellEndEdit
        Try
            If e.ColumnIndex = 8 Then '8 - RCPAMT
                'If DGV_RCP.Rows(e.RowIndex).Cells(24).Value = True Then
                Dim CAL_AMTOUSTAND As Decimal = DGV_RCP.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value
                Dim CAL_NETAMOUNT As Decimal = DGV_RCP.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
                Call AMOUNTCHANGE(CAL_NETAMOUNT)

                If DGV_RCP.Rows(e.RowIndex).Cells(e.ColumnIndex).Value > CAL_AMTOUSTAND Then
                    MessageBox.Show("OVER LIMIT OUSTANDING")
                    DGV_RCP.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value = CAL_AMTOUSTAND
                Else
                    If CAL_AMTOUSTAND > 0 Then
                        If CAL_AMTOUSTAND = TEMPRCP_AMTOUSTAND Then
                            DGV_RCP.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value = CAL_AMTOUSTAND - CAL_NETAMOUNT
                        Else
                            DGV_RCP.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value = TEMPRCP_AMTOUSTAND - CAL_NETAMOUNT
                        End If

                        Dim CAl_VATAMT As Decimal
                        Dim BASEAMT_NEW As Decimal = DGV_RCP.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString

                        'CAl_VATAMT = (BASEAMT_NEW * DGV_RCP.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value.ToString) / DGV_RCP.Rows(e.RowIndex).Cells(e.ColumnIndex - 2).Value.ToString
                        CAl_VATAMT = (BASEAMT_NEW * 7) / 107
                        DGV_RCP.Rows(e.RowIndex).Cells(24).Value = Math.Round(CAl_VATAMT, 2)
                    End If
                End If
                'End If
            End If
        Catch ex As Exception
            WriteLog("ERROR 510 (DGV_RCP_CellEndEdit) " & sender & e.RowIndex & ex.Message)
        End Try

        '6 UNITPRICE
        '7 VATAMT
        '8 RCPAMT
        '9 AMTOUTSTAND
        '10 NETAMT
        '11 AMT
        '24 VAT
        '25 CHECK_0
    End Sub
    Private Sub DGV_RCP_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_RCP.CellContentClick
        Try
            If e.ColumnIndex = 27 Then '25 CHECK_0
                TEMPRCP_AMTOUSTAND = DGV_RCP.Rows(e.RowIndex).Cells(9).Value   '9 AMTOUTSTAND

                Call AMOUNTCHANGE(TEMPRCP_AMTOUSTAND)


                DGV_RCP.Rows(e.RowIndex).Cells(8).ReadOnly = False   '8 RCPAMT
                SendKeys.Send("{TAB}")
                SendKeys.Send("{RIGHT}")
            End If
        Catch ex As Exception
            WriteLog("Error 525 : (DGV_RCP_CellContentClick) " & ex.Message)
        End Try
    End Sub

    Sub AMOUNTCHANGE(ByVal CAL_NETAMOUNT As Decimal)
        Try
            Dim RCPAMT As Decimal = 0
            Dim DT As DataTable = New DataTable

            DT = CType(DGV_RCP.DataSource, DataTable).Copy

            'DT = CONVERTDGVtoDATATABLE(DGV_RCP)

            For i = 0 To DT.Rows.Count - 1
                If DT.Rows(i).Item("CHECK_0").ToString = "True" Then
                    RCPAMT = RCPAMT + CDec(DT.Rows(i).Item("RCPAMT").ToString)
                End If
            Next
            Dim SUMRCPAMOUNT As Decimal = RCPAMT + CAL_NETAMOUNT
            txtRCPAMOUNT.Text = SUMRCPAMOUNT.ToString("N")

        Catch ex As Exception
            WriteLog("Error 543 : (AMOUNTCHANGE) " & ex.Message)
        End Try
    End Sub

    Public Function MergeTransaction(ByVal dt As DataTable) As DataTable
        Dim dtduplicate As DataTable = New DataTable
        Dim DistinctColumn As String = "IDINVC"
        Dim DistinctColumnBILL As String = "BILLNO"
        Try
            '1. filter 
            dtduplicate = dt.Clone
            Dim UniqueRecords As New ArrayList()
            Dim DuplicateRecords As New ArrayList()
            For Each dRow As DataRow In dt.Rows

                If dRow.Item("IDINVC").ToString <> "" Then
                    If UniqueRecords.Contains(dRow(DistinctColumn).ToString.TrimEnd & dRow(DistinctColumnBILL).ToString.TrimEnd) Then

                        DuplicateRecords.Add(dRow)
                    Else
                        UniqueRecords.Add(dRow(DistinctColumn).ToString.TrimEnd & dRow(DistinctColumnBILL).ToString.TrimEnd)
                    End If
                End If
            Next

            For Each dRowDup As DataRow In DuplicateRecords
                dtduplicate.ImportRow(dRowDup)
            Next

            For Each dRow As DataRow In DuplicateRecords
                dt.Rows.Remove(dRow)
            Next

            '2.Merge duplicate record into dt datatable
            For Each dRowMerge As DataRow In dtduplicate.Rows
                Dim dtBillNo As String = dRowMerge.Item("BILLNO").ToString
                Dim dtIDINVC As String = dRowMerge.Item("IDINVC").ToString
                Dim dtAMTOUTSTAND As Decimal = dRowMerge.Item("AMTOUTSTAND").ToString
                Dim dtRCPAMT As Decimal = dRowMerge.Item("RCPAMT").ToString
                Dim dtNETAMT As Decimal = dRowMerge.Item("NETAMT").ToString
                Dim dtAMT As Decimal = dRowMerge.Item("AMT").ToString

                Dim RCPAMT As Decimal
                For i = 0 To dt.Rows.Count - 1
                    Dim BILLNO As String = dt.Rows(i).Item("BILLNO").ToString
                    Dim IDINVC As String = dt.Rows(i).Item("IDINVC").ToString
                    Dim AMTOUTSTAND As Decimal = CDec(dt.Rows(i).Item("AMTOUTSTAND").ToString)
                    Dim NETAMT As Decimal = CDec(dt.Rows(i).Item("NETAMT").ToString)
                    Dim AMT As Decimal = CDec(dt.Rows(i).Item("AMT").ToString)

                    'If docNo <> "" Then
                    If BILLNO = dtBillNo And IDINVC = dtIDINVC Then
                        RCPAMT = MASTER.GETDATA_SUMRCPAMTOUTSTAND(BILLNO, IDINVC)
                        'dt.Rows(i).Item("AMTOUTSTAND") = dtRCPAMT + RCPAMT
                        'dt.Rows(i).Item("RCPAMT") = dtRCPAMT + RCPAMT
                        'dt.Rows(i).Item("NETAMT") = dtRCPAMT + RCPAMT

                        'dt.Rows(i).Item("AMTOUTSTAND") = RCPAMT
                        'dt.Rows(i).Item("RCPAMT") = RCPAMT
                        'dt.Rows(i).Item("NETAMT") = RCPAMT
                        dt.Rows(i).Item("AMTOUTSTAND") = AMTOUTSTAND
                        dt.Rows(i).Item("RCPAMT") = AMTOUTSTAND
                        dt.Rows(i).Item("NETAMT") = AMTOUTSTAND
                        dt.AcceptChanges()
                    End If
                    'End If
                Next

            Next


        Catch ex As Exception
            WriteLog("Error 611: MergeTransaction" & ex.Message)
        End Try

        Return dt
    End Function

    Private Sub TXTRCP_IDCUST_TextChanged(sender As Object, e As EventArgs) Handles TXTRCP_IDCUST.TextChanged
        Try
            txtRCPAMOUNT.Text = ""
            'Call BTN_GETRCP_Click(Nothing, Nothing)
        Catch ex As Exception
            WriteLog("Error 622: TXTRCP_IDCUST_TextChanged" & ex.Message)
        End Try
    End Sub



    Private Sub txtBANKBATCH_Click(sender As Object, e As EventArgs) Handles txtBANKBATCH.Click
        Dim dt As DataTable = New DataTable()
        Dim str As String = "SELECT * FROM BKACCT"
        txtBANKBATCH.Items.Clear()
        Try
            dt = MASTER.GETDATA_SEARCHBANK(str)
            If dt.Rows.Count > 0 Then
                For I = 0 To dt.Rows.Count - 1
                    Dim BANKCODE As String = dt.Rows(I).Item("BANK").ToString
                    txtBANKBATCH.Items.Add(BANKCODE)
                Next
            End If
        Catch ex As Exception
            WriteLog("Error 657: txtBANKBATCH_Click" & ex.Message & str)
        End Try

    End Sub

    Private Sub BTN_RCPNEWNEW_Click(sender As Object, e As EventArgs) Handles BTN_RCPNEWNEW.Click
        Try
            TXTRCP_RCPNO.Text = "***New***"

            Call ClearRCPHEADTEXTBOX()
            BTNBill_POST.Enabled = True
            BTNBill_DELETE.Enabled = True
            DGV_RCP.DataSource = Nothing
            BTNRCP_ALL.Enabled = True
            DGV_RCP.Enabled = True
            GroupPAYTYPE.Enabled = True
            TabControl1.Enabled = True

            Dim dtRCP As DataTable = New DataTable
            Dim clonedtRCP = MASTER.GETDATA_SOURCERCPDETAIL(TXTRCP_IDCUST.Text, TXTRCP_BILLNOFrom.Text, TXTRCP_BILLNOTo.Text)
            dtRCP = clonedtRCP.Clone
            Call DisplayDGVRCP(dtRCP)
            BTNRCP_Cheque.Checked = True
        Catch ex As Exception
            WriteLog("ERROR 722 : BTN_RCPNEWNEW_Click  " & ex.Message)
        End Try
    End Sub

    Sub ClearRCPHEADTEXTBOX()
        TXTRCP_IDCUST.Text = ""
        txtNAMECUST.Text = ""
        TXTRCP_BILLNOFrom.Text = ""
        TXTRCP_BILLNOTo.Text = ""
        TXTRCP_REF.Text = ""
        txtRCP_Comment.Text = ""
        TXTRCP_CHEQNO.Text = ""
        TXTRCP_CHEQBRANCH.Text = ""
        TXTRCP_CHEQACCT.Text = ""
        txtRCPAMOUNT.Text = ""
        TXTRCP_CRCARDNO.Text = ""
        TXTRCP_TRANSBANKCODE.Text = ""
        TXTRCP_TRANSBANKNO.Text = ""
        TXTRCP_TRANSFEE.Text = ""
        txtBANKBATCH.Text = ""

        BTNRCP_CASH.Checked = False
        BTNRCP_Cheque.Checked = False
        BTNRCP_Credit.Checked = False
        BTNRCP_TRANSFER.Checked = False

        BTN_Receipt.Enabled = True
        BTN_TAXReceipt.Enabled = True

    End Sub



    Private Sub BTNRCP_CHQBANKCODE_Click(sender As Object, e As EventArgs) Handles BTNRCP_CHQBANKCODE.Click
        Try
            Dim dt As DataTable = New DataTable()
            Dim str As String = "SELECT * FROM CSOPTFD WHERE OPTFIELD = 'bankcode'"
            BTNRCP_CHQBANKCODE.Items.Clear()
            Try
                dt = MASTER.GETDATA_SEARCHBANK(str)
                If dt.Rows.Count > 0 Then
                    For I = 0 To dt.Rows.Count - 1
                        Dim BANKCODE As String = dt.Rows(I).Item("VDESC").ToString.TrimEnd
                        BTNRCP_CHQBANKCODE.Items.Add(BANKCODE)
                    Next
                End If
            Catch ex As Exception
                WriteLog("Error 777: BTNRCP_CHQBANKCODE_Click" & ex.Message & str)
            End Try
        Catch ex As Exception
            WriteLog("ERROR 780 : BTNRCP_CHQBANKCODE_Click  " & ex.Message)
        End Try
    End Sub

    Private Sub TXTRCP_IDCUST_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles TXTRCP_IDCUST.PreviewKeyDown
        Try
            If e.KeyCode = Keys.Tab Then
                txtNAMECUST.Text = MASTER.GET_IDCUST(TXTRCP_IDCUST.Text)
                BTN_GETRCP_Click(Nothing, Nothing)
            End If
        Catch ex As Exception
            WriteLog("Error 823 (TXTRCP_IDCUST_PreviewKeyDown) " & ex.Message)
        End Try
    End Sub

    Public Shared Function Text_UNIONRCP(ByVal RCPNO As String) As String
        Dim STR As String = ""
        STR = " SELECT   IDCUST,
                        RCPNO,
                        RCPSEQ,
                        FMSRCPDETAIL.INVNO AS IDINVC,
                        SUBSTRING(CAST(INVDATE AS CHAR),7,2) + '/' + SUBSTRING(CAST(INVDATE AS CHAR),5,2) + '/' + SUBSTRING(CAST(INVDATE AS CHAR),1,4)  AS INVDATE ,
                        SUBSTRING(CAST(DUEDATE AS CHAR),7,2) + '/' + SUBSTRING(CAST(DUEDATE AS CHAR),5,2) + '/' + SUBSTRING(CAST(DUEDATE AS CHAR),1,4)  AS DUEDATE ,
                        UNITPRICE,
                        VATAMT,
                        RCPAMT,
                        AMTOUTSTAND,
                        NETAMT,
                        AMT,
                        CHECK_0,
                        CASE WHEN STA_0 = '1' THEN 'Open' ELSE 
							CASE WHEN STA_0 = '2' THEN 'Post' ELSE 
								CASE WHEN STA_0 = '3' THEN 'Receipt' ELSE
									CASE WHEN STA_0 = '4' THEN 'Reverse'  ELSE
										CASE WHEN STA_0 = '5' THEN 'Delete' ELSE '' END END END END END AS STA_0,
                        RCPDTEXT1,
                        RCPDTEXT2,
                        RCPDTEXT3,
                        RCPDTEXT4,
                        RCPDTEXT5,
                        RCPDTEXT6,
                        RCPDTEXT7,
                        RCPDTEXT8,
                        RCPDTEXT9,
                        RCPDTEXT10,
                        VAT,
                        BILLNO
                        FROM FMSRCPDETAIL" & Environment.NewLine
        STR &= "WHERE FMSRCPDETAIL.RCPNO = '" & RCPNO & "'" & Environment.NewLine
        STR &= "UNION  ALL" & Environment.NewLine

        Return STR
    End Function



#End Region


End Class