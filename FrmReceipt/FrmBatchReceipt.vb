Imports System.IO
Public Class FrmBatchReceipt

    Public RCPTEMP As String

#Region "EVENT"
    Private Sub FrmBatchReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            GET_BATCHRCP()
            'WindowState = FormWindowState.Maximized
        Catch ex As Exception
            WriteLog("ERROR 11 (FrmBatchReceipt_Load) : " & ex.Message)
        End Try
    End Sub

    Sub GET_BATCHRCP()
        Try
            Dim dtBATCHRCP As DataTable = New DataTable
            Dim STA_0 As String
            Dim STA_SHOWCOMPLETE As String
            If CBX_BTCHRCP.Checked = True Then
                STA_0 = "True"
            Else
                STA_0 = "False"
            End If

            If CBX_BTCHRCPComplt.Checked = True Then
                STA_SHOWCOMPLETE = "True"
            Else
                STA_SHOWCOMPLETE = "False"
            End If

            dtBATCHRCP = MASTER.GETDATA_BATCHRCP(STA_0, STA_SHOWCOMPLETE)

            Call DisplayDGV_BATCHRCP(dtBATCHRCP)
        Catch ex As Exception
            WriteLog("ERROR 35 (GET_BATCHRCP) : " & ex.Message)
        End Try
    End Sub

#End Region

#Region "BUTTON"
    Private Sub BTNBTCH_NEWRCP_Click(sender As Object, e As EventArgs) Handles BTNBTCH_NEWRCP.Click
        Try
            ShowFrmReceipt()
            FrmReceipt.TXTRCP_RCPNO.Text = "***New***"
            FrmReceipt.DGV_RCP.DataSource = Nothing

            FrmReceipt.txtRCPAMOUNT.Text = "0.00"

            Dim dtRCP As DataTable = New DataTable
            dtRCP = MASTER.GETDATA_SOURCERCPDETAIL("", "", "")
            Call FrmReceipt.DisplayDGVRCP(dtRCP)

        Catch ex As Exception
            WriteLog("ERROR 50 (BTNBTCH_NEWRCP_Click) " & ex.Message)
        End Try
    End Sub

    Private Sub BTNBTCH_OPENRCP_Click(sender As Object, e As EventArgs) Handles BTNBTCH_OPENRCP.Click
        Try
            ShowFrmReceipt()

            'SHOW HEADER
            'GETDATA 
            Dim RowINDX As Integer = DGV_BATCHRECEIP.CurrentRow.Index
            Dim RCPNO As String = ""
            Dim IDCUST As String = ""
            Dim dtcopyBATCHBILL As DataTable
            dtcopyBATCHBILL = CType(DGV_BATCHRECEIP.DataSource, DataTable)

            For i = 0 To dtcopyBATCHBILL.Rows.Count - 1
                If i = RowINDX Then

                    Dim BILLDOCDATE As String = ""
                    Dim DUEDATE As String = ""
                    Dim REF As String = ""
                    Dim COMMENT As String = ""
                    RCPNO = dtcopyBATCHBILL.Rows(i).Item("RCPNO").ToString
                    IDCUST = dtcopyBATCHBILL.Rows(i).Item("IDCUST").ToString

                    FrmReceipt.TXTRCP_RCPNO.Text = RCPNO
                    FrmReceipt.TXTRCP_IDCUST.Text = IDCUST
                    Dim DTRCPHEADER As DataTable = New DataTable
                    DTRCPHEADER = MASTER.GETDATA_RCPHEADER(RCPNO, IDCUST)
                    FrmReceipt.TXTRCP_REF.Text = DTRCPHEADER.Rows(0).Item("REF_0").ToString.TrimEnd
                    FrmReceipt.txtRCP_Comment.Text = DTRCPHEADER.Rows(0).Item("COMMENT").ToString.TrimEnd
                    FrmReceipt.TXTRCP_PAYDATE.Value = DTRCPHEADER.Rows(0).Item("PAYDATE").ToString.TrimEnd.Substring(6, 2) & "/" & DTRCPHEADER.Rows(0).Item("PAYDATE").ToString.TrimEnd.Substring(4, 2) & "/" & DTRCPHEADER.Rows(0).Item("PAYDATE").ToString.TrimEnd.Substring(0, 4)
                    FrmReceipt.txtRCP_DOCDATE.Value = DTRCPHEADER.Rows(0).Item("RECEIVEDATE").ToString.TrimEnd.Substring(6, 2) & "/" & DTRCPHEADER.Rows(0).Item("RECEIVEDATE").ToString.TrimEnd.Substring(4, 2) & "/" & DTRCPHEADER.Rows(0).Item("RECEIVEDATE").ToString.TrimEnd.Substring(0, 4)
                    FrmReceipt.txtRCP_INVDATE.Value = DTRCPHEADER.Rows(0).Item("RECEIVEDOCDATE").ToString.TrimEnd.Substring(6, 2) & "/" & DTRCPHEADER.Rows(0).Item("RECEIVEDOCDATE").ToString.TrimEnd.Substring(4, 2) & "/" & DTRCPHEADER.Rows(0).Item("RECEIVEDOCDATE").ToString.TrimEnd.Substring(0, 4)
                    FrmReceipt.txt_RCPDATECB.Value = DTRCPHEADER.Rows(0).Item("CBDATE").ToString.TrimEnd.Substring(6, 2) & "/" & DTRCPHEADER.Rows(0).Item("CBDATE").ToString.TrimEnd.Substring(4, 2) & "/" & DTRCPHEADER.Rows(0).Item("CBDATE").ToString.TrimEnd.Substring(0, 4)

                    FrmReceipt.txtBANKBATCH.Text = DTRCPHEADER.Rows(0).Item("BANKBATCH").ToString.TrimEnd
                    FrmReceipt.BTNRCP_CHQBANKCODE.Text = DTRCPHEADER.Rows(0).Item("CHEQBANK").ToString.TrimEnd
                    Dim RCPAMT As Decimal = DTRCPHEADER.Rows(0).Item("NETAMT").ToString
                    FrmReceipt.txtRCPAMOUNT.Text = RCPAMT.ToString("N")

                    Select Case DTRCPHEADER.Rows(0).Item("STA_0").ToString.TrimEnd
                        Case "1"
                            FrmReceipt.txtRCPSTA.Text = "Open"
                            FrmReceipt.BTNRCP_ALL.Enabled = True
                        Case "2"
                            FrmReceipt.BTNBill_POST.Enabled = False
                            FrmReceipt.BTNBill_DELETE.Enabled = False
                            FrmReceipt.txtRCPSTA.Text = "Posted"
                            FrmReceipt.BTNRCP_ALL.Enabled = False
                            FrmReceipt.DGV_RCP.Enabled = False
                            FrmReceipt.GroupPAYTYPE.Enabled = False
                            FrmReceipt.TabControl1.Enabled = False
                        Case "3"
                            FrmReceipt.BTNBill_POST.Enabled = False
                            FrmReceipt.BTNBill_DELETE.Enabled = False
                            FrmReceipt.txtRCPSTA.Text = "Receipt"
                            FrmReceipt.GroupPAYTYPE.Enabled = False
                            FrmReceipt.TabControl1.Enabled = False
                        Case "4"
                            FrmReceipt.BTNBill_POST.Enabled = False
                            FrmReceipt.BTNBill_DELETE.Enabled = False
                            FrmReceipt.txtRCPSTA.Text = "Reverse"
                            FrmReceipt.BTNRCP_ALL.Enabled = False
                            FrmReceipt.DGV_RCP.Enabled = False
                            FrmReceipt.GroupPAYTYPE.Enabled = False
                            FrmReceipt.TabControl1.Enabled = False
                        Case "5"
                            FrmReceipt.BTNBill_POST.Enabled = False
                            FrmReceipt.BTNBill_DELETE.Enabled = False
                            FrmReceipt.txtRCPSTA.Text = "Delete"
                            FrmReceipt.BTNRCP_ALL.Enabled = False
                            FrmReceipt.DGV_RCP.Enabled = False
                            FrmReceipt.GroupPAYTYPE.Enabled = False
                            FrmReceipt.TabControl1.Enabled = False
                        Case Else
                    End Select

                    Select Case DTRCPHEADER.Rows(0).Item("PAYTYPE").ToString.TrimEnd

                        Case "0"
                            FrmReceipt.BTNRCP_CASH.Checked = False
                            FrmReceipt.BTNRCP_Cheque.Checked = True
                            FrmReceipt.BTNRCP_Credit.Checked = False
                            FrmReceipt.BTNRCP_TRANSFER.Checked = False
                            FrmReceipt.TXTRCP_CHEQNO.Text = DTRCPHEADER.Rows(0).Item("CHEQNO").ToString.TrimEnd
                            FrmReceipt.TXTRCP_CHEQACCT.Text = DTRCPHEADER.Rows(0).Item("CHEQBRANCH").ToString.TrimEnd
                            FrmReceipt.TXTRCP_CHEQBRANCH.Text = DTRCPHEADER.Rows(0).Item("CHEQBRANCH").ToString.TrimEnd
                            FrmReceipt.TXTRCP_PAYDATE.Value = DTRCPHEADER.Rows(0).Item("CHEQDATE").ToString.TrimEnd.Substring(6, 2) & "/" & DTRCPHEADER.Rows(0).Item("CHEQDATE").ToString.TrimEnd.Substring(4, 2) & "/" & DTRCPHEADER.Rows(0).Item("CHEQDATE").ToString.TrimEnd.Substring(0, 4)
                            If DTRCPHEADER.Rows(0).Item("SHOWCHEQDATE").ToString.TrimEnd = 1 Then
                                FrmReceipt.BTN_SHOWCHEQDATE.Checked = True
                            Else
                                FrmReceipt.BTN_SHOWCHEQDATE.Checked = False
                            End If
                        Case "1"
                            FrmReceipt.BTNRCP_CASH.Checked = True
                            FrmReceipt.BTNRCP_Cheque.Checked = False
                            FrmReceipt.BTNRCP_Credit.Checked = False
                            FrmReceipt.BTNRCP_TRANSFER.Checked = False
                        Case "2"
                            FrmReceipt.BTNRCP_CASH.Checked = False
                            FrmReceipt.BTNRCP_Cheque.Checked = True
                            FrmReceipt.BTNRCP_Credit.Checked = False
                            FrmReceipt.BTNRCP_TRANSFER.Checked = False
                            FrmReceipt.TXTRCP_CHEQNO.Text = DTRCPHEADER.Rows(0).Item("CHEQNO").ToString.TrimEnd
                            FrmReceipt.TXTRCP_CHEQACCT.Text = DTRCPHEADER.Rows(0).Item("CHEQACCT").ToString.TrimEnd
                            FrmReceipt.TXTRCP_CHEQBRANCH.Text = DTRCPHEADER.Rows(0).Item("CHEQBRANCH").ToString.TrimEnd
                            FrmReceipt.TXTRCP_PAYDATE.Value = DTRCPHEADER.Rows(0).Item("CHEQDATE").ToString.TrimEnd.Substring(6, 2) & "/" & DTRCPHEADER.Rows(0).Item("CHEQDATE").ToString.TrimEnd.Substring(4, 2) & "/" & DTRCPHEADER.Rows(0).Item("CHEQDATE").ToString.TrimEnd.Substring(0, 4)
                            If DTRCPHEADER.Rows(0).Item("SHOWCHEQDATE").ToString.TrimEnd = 1 Then
                                FrmReceipt.BTN_SHOWCHEQDATE.Checked = True
                            Else
                                FrmReceipt.BTN_SHOWCHEQDATE.Checked = False
                            End If

                        Case "3"
                            FrmReceipt.BTNRCP_CASH.Checked = False
                            FrmReceipt.BTNRCP_Cheque.Checked = False
                            FrmReceipt.BTNRCP_Credit.Checked = True
                            FrmReceipt.BTNRCP_TRANSFER.Checked = False
                            FrmReceipt.TXTRCP_CRCARDNO.Text = DTRCPHEADER.Rows(0).Item("CRCARDNO").ToString.TrimEnd

                        Case "4"
                            FrmReceipt.BTNRCP_CASH.Checked = False
                            FrmReceipt.BTNRCP_Cheque.Checked = False
                            FrmReceipt.BTNRCP_Credit.Checked = False
                            FrmReceipt.BTNRCP_TRANSFER.Checked = True
                            FrmReceipt.TXTRCP_TRANSBANKCODE.Text = DTRCPHEADER.Rows(0).Item("TRANSBANKCODE").ToString.TrimEnd
                            FrmReceipt.TXTRCP_TRANSBANKNO.Text = DTRCPHEADER.Rows(0).Item("TRANSBANKNO").ToString.TrimEnd
                            FrmReceipt.TXTRCP_TRANSFEE.Text = DTRCPHEADER.Rows(0).Item("TRANSFEE").ToString.TrimEnd

                        Case Else
                            FrmReceipt.BTNRCP_CASH.Checked = False
                            FrmReceipt.BTNRCP_Cheque.Checked = False
                            FrmReceipt.BTNRCP_Credit.Checked = False
                            FrmReceipt.BTNRCP_TRANSFER.Checked = False
                    End Select

                    If DTRCPHEADER.Rows(0).Item("TAXINV").ToString.TrimEnd = "TAX" Then
                        FrmReceipt.BTN_TAXReceipt.Checked = True
                        FrmReceipt.BTN_Receipt.Enabled = False
                    Else
                        FrmReceipt.BTN_Receipt.Checked = True
                        FrmReceipt.BTN_TAXReceipt.Enabled = False
                    End If

                End If
            Next

            'SHOW DETAIL 

            Dim dtRCPdetail As DataTable = MASTER.GETDATA_OPENRCPDETAIL(IDCUST, RCPNO)
            If dtRCPdetail.Rows.Count > 0 Then
                For j = 0 To dtRCPdetail.Rows.Count - 1

                    Select Case dtRCPdetail.Rows(j).Item("STA_0").ToString
                        Case "1"
                            dtRCPdetail.Rows(j).Item("STA_0") = "Open"
                        Case "2"
                            dtRCPdetail.Rows(j).Item("STA_0") = "Posted"
                        Case "3"
                        Case "4"
                            dtRCPdetail.Rows(j).Item("STA_0") = "Reverse"
                        Case "5"
                            dtRCPdetail.Rows(j).Item("STA_0") = "Delete"
                    End Select
                Next

            End If

            Call FrmReceipt.DisplayDGVRCP(dtRCPdetail)

            FrmReceipt.TXTRCP_RCPNO.ReadOnly = True
            FrmReceipt.TXTRCP_IDCUST.ReadOnly = True
            'FrmReceipt.txtBANKBATCH.Enabled = False
            FrmReceipt.BTNRCP_ALL.Checked = True
            'FrmReceipt.BTNRCP_ALL.Enabled = False

        Catch ex As Exception
            WriteLog("ERROR 175 (BTNBTCH_OPENRCP_Click) " & ex.Message)
        End Try

    End Sub

    Private Sub BTNBTCH_POSTRCP_Click(sender As Object, e As EventArgs) Handles BTNBTCH_POSTRCP.Click
        Try
            Dim RowINDX As Integer = DGV_BATCHRECEIP.CurrentRow.Index
            Dim RCPNO As String
            Dim IDCUST As String = ""
            Dim dtcopyBATCHBILL As DataTable
            dtcopyBATCHBILL = CType(DGV_BATCHRECEIP.DataSource, DataTable)
            Dim dialogOK As DialogResult = MsgBox("Do you confirm to post the receipt ?", MessageBoxButtons.OKCancel)
            If dialogOK = DialogResult.OK Then
                For i = 0 To dtcopyBATCHBILL.Rows.Count - 1
                    If i = RowINDX Then

                        RCPNO = dtcopyBATCHBILL.Rows(i).Item("RCPNO").ToString
                        Dim BANKCODE As String = MASTER.GET_BANKBATCH(RCPNO)
                        If BANKCODE.TrimEnd = "" Then ' CHECK CB BANK CODE
                            MessageBox.Show("Cannot post receipt " & RCPNO & " because Cashbook Bankcode is empty. ")
                            Exit For
                        Else
                            Call DATACLASS.UPDATEFMSRCPHEAD_POST(RCPNO)
                            Exit For
                        End If

                    End If

                Next
                GET_BATCHRCP()
            Else
                Exit Try
            End If
        Catch ex As Exception
            WriteLog("ERROR 204 (BTNBTCH_POSTRCP_Click) " & ex.Message)
        End Try
    End Sub

    Sub BTNBTCH_REFRESHRCP_Click(sender As Object, e As EventArgs) Handles BTNBTCH_REFRESHRCP.Click
        Try
            GET_BATCHRCP()
        Catch ex As Exception
            WriteLog("ERROR 212 (BTNBTCH_REFRESHRCP_Click) " & ex.Message)
        End Try
    End Sub

    Private Sub CBX_BTCHRCP_CheckedChanged(sender As Object, e As EventArgs) Handles CBX_BTCHRCP.CheckedChanged
        Try
            GET_BATCHRCP()
        Catch ex As Exception
            WriteLog("ERROR 220 (CBX_BTCHRCP_CheckedChanged) " & ex.Message)
        End Try
    End Sub

    Private Sub BTNBTCH_PRINTRCP_Click(sender As Object, e As EventArgs) Handles BTNBTCH_PRINTRCP.Click
        Try
            Dim RowINDX As Integer = DGV_BATCHRECEIP.CurrentRow.Index
            Dim RCPNO As String
            Dim IDCUST As String
            Dim dtcopyBATCHBILL As DataTable
            dtcopyBATCHBILL = CType(DGV_BATCHRECEIP.DataSource, DataTable)
            For i = 0 To dtcopyBATCHBILL.Rows.Count - 1
                If i = RowINDX Then

                    RCPNO = dtcopyBATCHBILL.Rows(i).Item("RCPNO").ToString
                    Call FrmPrintRCP.ShowRCPReport(RCPNO)
                    Exit For
                End If
            Next
        Catch ex As Exception
            WriteLog("ERROR 240 (BTNBTCH_PRINTRCP_Click) : " & ex.Message)
        End Try
    End Sub

    Private Sub BTNBTCHRCP_CLOSE_Click(sender As Object, e As EventArgs) Handles BTNBTCHRCP_CLOSE.Click
        Me.Close()
    End Sub

    Private Sub BTNBatchRCP_SEARCH_Click(sender As Object, e As EventArgs) Handles BTNBatchRCP_SEARCH.Click
        Try
            MAIN.txtForm.Text = "FrmBatchReceipt"
            FrmSearch.txtSearch.Text = "Batch Receipt Number"
            Call FrmSearch.SearchShow("RCPNO", "IDCUST", "Receipt No", "Customer Number", "NAMECUST", "Customer Name")
        Catch ex As Exception
            WriteLog("ERROR 252 (BTNBatchRCP_SEARCH_Click)" & ex.Message)
        End Try
    End Sub

    Private Sub BTNBTCH_DELETERCP_Click(sender As Object, e As EventArgs) Handles BTNBTCH_DELETERCP.Click
        Try
            Dim RowINDX As Integer = DGV_BATCHRECEIP.CurrentRow.Index
            Dim BILLNO As String = ""
            Dim IDCUST As String = ""
            Dim dtcopyBATCHBILL As DataTable
            dtcopyBATCHBILL = CType(DGV_BATCHRECEIP.DataSource, DataTable)
            Dim dialogOK As DialogResult = MsgBox("Do you confirm to delete the receipt ?", MessageBoxButtons.OKCancel)
            If dialogOK = DialogResult.OK Then
                For i = 0 To dtcopyBATCHBILL.Rows.Count - 1
                    If i = RowINDX Then

                        BILLNO = dtcopyBATCHBILL.Rows(i).Item("RCPNO").ToString.TrimEnd
                        If dtcopyBATCHBILL.Rows(i).Item("STATUS").ToString.TrimEnd = "Open" Then
                            ' Call DATACLASS.DELETEFMSRCPHEAD(BILLNO)
                            Call DATACLASS.DELETEFMSRCPHEAD_REVISE(BILLNO)
                            Exit For
                        Else
                            MessageBox.Show("The program will not accept the deleted transaction.")
                            Exit For
                        End If
                    End If
                Next
            Else
                Exit Try
            End If
            CBX_BTCHRCP.Checked = True
            GET_BATCHRCP()
        Catch ex As Exception
            WriteLog("ERROR 284 (BTNBTCH_DELETERCP_Click) : " & ex.Message)
        End Try
    End Sub

    Private Sub txtBatchRCP_SEARCH_TextChanged(sender As Object, e As EventArgs) Handles txtBatchRCP_SEARCH.TextChanged
        Try
            Dim dtBATCHRCP As DataTable = New DataTable
            Dim STA_0 As String = ""
            Dim RCPNO As String = ""
            RCPNO = txtBatchRCP_SEARCH.Text

            dtBATCHRCP = MASTER.GETDATA_BATCHRCP(STA_0, "", RCPNO)

            Call DisplayDGV_BATCHRCP(dtBATCHRCP)
        Catch ex As Exception
            WriteLog("ERROR 299 (txtBatchRCP_SEARCH_TextChanged) : " & ex.Message)
        End Try
    End Sub

    Private Sub BTN_IMPORTCB_Click(sender As Object, e As EventArgs) Handles BTN_IMPORTCB.Click
        Try
            '1.Gen EXCEL 
            If IMPORTSAGE.KillAllExcelProcess() = False Then
                MessageBox.Show("Please Closed Microsoft Excel before Import data to Cashbook.")
                Exit Try
            End If
            RCP_PROGRESSBAR.Visible = True
            TXTRCP_PROGRESS.Text = "1/3 Data Processing"
            RCP_PROGRESSBAR.Value = 5
            '2.Copy datagridview to datatable
            Dim dt = CONVERTDGVtoDATATABLE(DGV_BATCHRECEIP)

            Dim dtCHK As DataTable = New DataTable()
            Dim drRowss As DataRow()

            drRowss = dt.[Select]("CHECK_0 = 'True' AND STATUS = 'Posted' AND IMPORTCB = 'No'  ")
            dtCHK = dt.Clone


            If drRowss Is Nothing = False Then
                For Each ROWSS As DataRow In drRowss
                    dtCHK.ImportRow(ROWSS)
                Next
            Else

            End If



            Dim DTCONFIG As DataTable = MASTER.GET_CONFIGCB()
            Dim ACCPACVERSION As String = ""
            Dim ACCPACID As String = ""
            Dim ACCPACPASS As String = ""
            Dim ACCPACCOMP As String = ""
            Dim PATHBACKUP As String = ""
            Dim PATHERROR As String = ""

            If DTCONFIG.Rows.Count > 0 Then
                ACCPACVERSION = DTCONFIG.Rows(0).Item("ACCPACVERSION").ToString.TrimEnd
                ACCPACID = DTCONFIG.Rows(0).Item("ACCPACID").ToString.TrimEnd
                ACCPACPASS = DTCONFIG.Rows(0).Item("ACCPACPASSWORD").ToString.TrimEnd
                ACCPACCOMP = DTCONFIG.Rows(0).Item("COMPANY").ToString.TrimEnd
                PATHBACKUP = DTCONFIG.Rows(0).Item("PATHBACKUP").ToString.TrimEnd
                PATHERROR = DTCONFIG.Rows(0).Item("PATHERROR").ToString.TrimEnd
            End If

            'Create Backup directory
            If Not Directory.Exists(PATHBACKUP & "\BackupImport") Then
                Directory.CreateDirectory(PATHBACKUP & "\BackupImport")
            End If

            'Create Error directory
            If Not Directory.Exists(PATHERROR & "\ErrorImport") Then
                Directory.CreateDirectory(PATHERROR & "\ErrorImport")
            End If


            If dtCHK.Rows.Count > 0 Then
                RCP_PROGRESSBAR.Value = 20
                For i = 0 To dtCHK.Rows.Count - 1

                    Dim RCPNO As String = ""
                    RCPNO = dtCHK.Rows(i).Item("RCPNO").ToString.TrimEnd
                    Dim dtImport As DataTable = New DataTable
                    dtImport = dtCHK.Clone
                    dtImport.ImportRow(dtCHK.Rows(i))
                    '3.Write Excel 
                    Call IMPORTSAGE.GenEXCEL(dtImport)
                    If i = dtCHK.Rows.Count - 1 Then
                        TXTRCP_PROGRESS.Text = "2/3 Generate Excel for Import to Cashbook " & RCPNO
                        RCP_PROGRESSBAR.Value = 50
                    Else
                        TXTRCP_PROGRESS.Text = "2/3 Generate Excel for Import to Cashbook " & RCPNO
                        RCP_PROGRESSBAR.Value = 30
                    End If

                    '4.Import CB
                    Dim BANKCODE As String = MASTER.GET_BANKBATCH(RCPNO)

                    Dim ImportSTATUS As Boolean
                    ImportSTATUS = IMPORTSAGE.ImportAccpac(BANKCODE, RCPNO, ACCPACVERSION, ACCPACID, ACCPACPASS, ACCPACCOMP)



                    '5.Manage file

                    'Copy file


                    If ImportSTATUS = True Then
                        If i = dtCHK.Rows.Count - 1 Then
                            TXTRCP_PROGRESS.Text = "3/3 Import to Cashbook " & RCPNO & " Success."
                            RCP_PROGRESSBAR.Value = 100
                        Else

                            TXTRCP_PROGRESS.Text = "3/3 Import to Cashbook " & RCPNO & " Success."
                            RCP_PROGRESSBAR.Value = 75
                        End If
                        System.IO.File.Copy(Application.StartupPath & "\IMPORTCB\CBImport.xls", PATHBACKUP & "\BackupImport\" & RCPNO & "_" & Now.Year & Now.Month & Now.Day & Now.Hour & Now.Minute & ".xls")

                    Else
                        If i = dtCHK.Rows.Count - 1 Then
                            TXTRCP_PROGRESS.Text = "3/3 Import to Cashbook " & RCPNO & " Failed."
                            RCP_PROGRESSBAR.Value = 100
                        Else

                            TXTRCP_PROGRESS.Text = "3/3 Import to Cashbook " & RCPNO & " Failed."
                            RCP_PROGRESSBAR.Value = 75
                        End If
                        System.IO.File.Copy(Application.StartupPath & "\IMPORTCB\CBImport.xls", PATHERROR & "\ErrorImport\ERROR" & RCPNO & "_" & Now.Year & Now.Month & Now.Day & Now.Hour & Now.Minute & ".xls")

                    End If
                    'Move file import
                    System.IO.File.Delete(Application.StartupPath & "\IMPORTCB\CBImport.xls")

                Next
                'REFRESH
                Call BTNBTCH_REFRESHRCP_Click(Nothing, Nothing)
            Else

                'MessageBox.Show("Please select transaction import to Cashbook.")
                'MessageBox.Show("You must post receipt before import to Cashbook.")
                Dim drErrStatus As DataRow()
                Dim drErrStatus_0 As DataRow()
                Dim drErrCheck_0 As DataRow()
                drErrCheck_0 = dt.[Select]("CHECK_0 = 'True' ")

                drErrStatus = dt.[Select]("CHECK_0 = 'True' AND STATUS = 'Open' AND IMPORTCB = 'No'  ")

                drErrStatus_0 = dt.[Select]("CHECK_0 = 'False' AND STATUS = 'Posted' AND IMPORTCB = 'No'  ")


                If drErrCheck_0.Length = 0 Then
                    MessageBox.Show("Please select transaction import to Cashbook.")
                End If

                If drErrStatus.Length > 0 Then
                    MessageBox.Show("You must post receipt before import to Cashbook.")
                End If

                If drErrStatus_0.Length > 0 Then
                    MessageBox.Show("Please select transaction import to Cashbook.")
                End If


            End If

            Call DATACLASS.UPDATEFMSRCPHEAD_CBBATCH()

        Catch ex As Exception
            WriteLog("ERROR 415 (BTN_IMPORTCB_Click) : " & ex.Message)
        End Try
    End Sub

    Private Sub DGV_BATCHRECEIP_Click(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_BATCHRECEIP.CellContentClick

        Try
            RCPTEMP = ""
            RCPTEMP = DGV_BATCHRECEIP.Rows(e.RowIndex).Cells(8).Value

            Select Case DGV_BATCHRECEIP.Rows(e.RowIndex).Cells("STATUS").Value
                Case "Open"
                    BTNBTCH_DELETERCP.Enabled = True
                    BTNBTCH_POSTRCP.Enabled = True
                    BTN_IMPORTCB.Enabled = True
                Case Else
                    BTNBTCH_DELETERCP.Enabled = False
                    BTNBTCH_POSTRCP.Enabled = False
                    'BTN_IMPORTCB.Enabled = False
            End Select


        Catch ex As Exception
            WriteLog("ERROR 400 (DGV_BATCHRECEIP_Click) : " & ex.Message)
        End Try

    End Sub

    Private Sub CBX_BTCHRCPComplt_CheckedChanged(sender As Object, e As EventArgs) Handles CBX_BTCHRCPComplt.CheckedChanged
        Try
            GET_BATCHRCP()
        Catch ex As Exception
            WriteLog("ERROR 410 (CBX_BTCHRCPComplt_CheckedChanged) " & ex.Message)
        End Try
    End Sub


#End Region

End Class