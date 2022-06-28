Public Class FrmBillingNote
    Public TEMP_AMTOUSTAND As Decimal
    Private Sub FrmBillingNote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TXTBILL_DATEF.Value = New DateTime(TXTBILL_DATEF.Value.Year, TXTBILL_DATEF.Value.Month, 1)
        Catch ex As Exception
            WriteLog("ERROR 9 (FrmBillingNote_Load) " & ex.Message)
        End Try
    End Sub

#Region "BUUTON"
    Private Sub BTN_GETBILL_Click(sender As Object, e As EventArgs) Handles BTN_GETBILL.Click
        Try
            GETBILL()
        Catch ex As Exception
            WriteLog("ERROR 20 (BTN_GETBILL_Click) " & ex.Message)
        End Try
    End Sub

    Private Sub BTNBill_POST_Click(sender As Object, e As EventArgs) Handles BTNBill_POST.Click
        Try
            Dim dialogOK As DialogResult = MsgBox("Do you confirm to save the billing ?", MessageBoxButtons.OKCancel)
            'Save New 
            If TXTBILL_BILLNO.Text = "***New***" Then
                If dialogOK = DialogResult.OK Then
                    Dim DTBILLHEAD As DataTable = New DataTable
                    Dim DTBILLDETAIL As DataTable = New DataTable
                    Dim BILLSEQ As String = ""
                    Dim BILLNO As String = ""
                    Dim DT As DataTable = New DataTable

                    DT = CONVERTDGVtoDATATABLE(DGV_BILL)
                    If PROCESS.CHECK_selectDetail(DT) = False Then
                        MessageBox.Show("Please select at least one invoice.")
                        Exit Sub
                    End If
                    DT = ProcessCALOUTSTANDING(DT)
                    DGV_BILL.DataSource = Nothing

                    DisplayDGVBILL(DT, "OPENBATCH")
                    DTBILLHEAD = ProcessBILLDATA(BILLSEQ, BILLNO, DT)
                    If DTBILLHEAD Is Nothing Then
                        Exit Try
                    End If
                    If MASTER.GETDATA_BILLNO(BILLNO) = True Then
                        MessageBox.Show(BILLNO & " is duplicated.")
                        Call BTN_BILLNEWNEW_Click(Nothing, Nothing)
                        FrmRunning.Show(MAIN)
                        Exit Sub
                    End If
                    DTBILLDETAIL = ProcessBILLDETAILDATA(BILLSEQ, BILLNO, DT)
                        Call DATACLASS.INSERTBILLHEADER(DTBILLHEAD)
                        Call DATACLASS.INSERTBILLDETAIL(DTBILLDETAIL)
                        Call DATACLASS.UPDATEFMSBILLDETAIL_AMTOUTSTAND(DTBILLDETAIL)
                        TXTBILL_BILLNO.Text = BILLNO
                    Else
                        Exit Try
                    End If

                Else
                'Save Update

                Dim DTBILLHEAD As DataTable = New DataTable
                Dim DTBILLDETAIL As DataTable = New DataTable
                Dim BILLSEQ As String = ""
                Dim BILLNO As String = ""
                Dim DT As DataTable = New DataTable

                DT = CONVERTDGVtoDATATABLE(DGV_BILL)
                If PROCESS.CHECK_selectDetail(DT) = False Then
                    MessageBox.Show("Please select at least one invoice.")
                    Exit Sub
                End If
                DT = ProcessCALOUTSTANDING(DT)
                DGV_BILL.DataSource = Nothing

                DisplayDGVBILL(DT, "OPENBATCH")
                Call AMTCHANGE(0)
                DTBILLHEAD = ProcessBILLDATA(BILLSEQ, BILLNO, DT, "UPDATE")
                DTBILLDETAIL = ProcessBILLDETAILDATA(BILLSEQ, BILLNO, DT)
                Call DATACLASS.DELETEFMSBILL(BILLNO)
                Dim SAVESTATUS As Boolean
                SAVESTATUS = DATACLASS.INSERTBILLHEADER(DTBILLHEAD)
                If SAVESTATUS = True Then
                    Call DATACLASS.INSERTBILLDETAIL(DTBILLDETAIL)
                    Call DATACLASS.UPDATEFMSBILLDETAIL_AMTOUTSTAND(DTBILLDETAIL)
                    TXTBILL_BILLNO.Text = BILLNO

                End If

            End If

            FrmBatchBillingNote.BTNBTCH_REFRESH_Click(Nothing, Nothing)
        Catch ex As Exception
            WriteLog("Error 74 (BTNBill_POST_Click) " & ex.Message)
        End Try
    End Sub

    Private Sub BTNBill_NEW_Click(sender As Object, e As EventArgs) Handles BTNBill_NEW.Click
        Try
            TXTBILL_BILLNO.Text = "***New***"
            BTNBill_POST.Enabled = True
            BTNBill_DELETE.Enabled = True
            DGV_BILL.DataSource = Nothing
            CbmBOI.Enabled = True
            GETBILL()
        Catch ex As Exception
            WriteLog("Error 88 (BTNBill_NEW_Click) " & ex.Message)
        End Try
    End Sub

    Private Sub BTNBill_PRINT_Click(sender As Object, e As EventArgs) Handles BTNBill_PRINT.Click
        Try
            FrmPrintBill.ShowReport(TXTBILL_BILLNO.Text.TrimEnd)
        Catch ex As Exception
            WriteLog("Error 95 (BTNBill_PRINT_Click) " & ex.Message)
        End Try
    End Sub

    Private Sub BTNBill_REFRESH_Click(sender As Object, e As EventArgs) Handles BTNBill_REFRESH.Click
        Me.Close()
        TopMost = False
    End Sub

    Private Sub BTNBill_DELETE_Click(sender As Object, e As EventArgs) Handles BTNBill_DELETE.Click
        Try
            Dim BILLNO As String = TXTBILL_BILLNO.Text
            Dim dialogOK As DialogResult = MsgBox("Do you confirm to delete billing " & BILLNO & " ?", MessageBoxButtons.OKCancel)
            If dialogOK = DialogResult.OK Then
                Call DATACLASS.DELETEFMSBILLHEAD(BILLNO)
                TXTBILL_BILLNO.Text = "***New***"
                DGV_BILL.DataSource = Nothing
                Call GETBILL()
            Else
                Exit Try
            End If
        Catch ex As Exception
            WriteLog("Error 117 (BTNBill_DELETE_Click) " & ex.Message)
        End Try
    End Sub

    Private Sub BTN_BILLOPTFD_Click(sender As Object, e As EventArgs) Handles BTN_BILLOPTFD.Click
        Try
            FrmOPTFDVALUE.GET_OPTFDVALUE("BILLHTEXT", TXTBILL_BILLNO.Text, TXTBILL_IDCUST.Text)
        Catch ex As Exception
            WriteLog("Error 125 (BTN_BILLOPTFD_Click) " & ex.Message)
        End Try
    End Sub

    Private Sub BTN_BILLFINDCUST_Click(sender As Object, e As EventArgs) Handles BTN_BILLFINDCUST.Click
        Try
            MAIN.txtForm.Text = "FrmBillingNote"
            FrmSearch.txtSearch.Text = "FrmBillingNote"
            Call FrmSearch.SearchShow("IDCUST", "NAMECUST", "Customer Number", "Customer Name", "", "")
        Catch ex As Exception
            WriteLog("Error 135 (BTN_BILLFINDCUST_Click) " & ex.Message)
        End Try
    End Sub

    Private Sub BTN_BILLALL_CheckedChanged(sender As Object, e As EventArgs) Handles BTN_BILLALL.CheckedChanged
        Try
            Dim dt As DataTable = New DataTable
            Dim index As Integer

            dt = CONVERTDGVtoDATATABLE(DGV_BILL)

            If dt IsNot Nothing Then

                index = dt.Columns.Count
                Dim SumBillAMOUNT As Decimal
                For i = 0 To dt.Rows.Count - 1
                    SumBillAMOUNT = SumBillAMOUNT + dt.Rows(i).Item("NETAMT").ToString
                Next
                txtBILLAMOUNT.Text = SumBillAMOUNT.ToString("N")
            Else
                index = 21
                txtBILLAMOUNT.Text = "0.00"
            End If

            SelectALL(DGV_BILL, BTN_BILLALL.Checked, index)



        Catch ex As Exception
            WriteLog("Error 161 (BTN_BILLALL_CheckedChanged) " & ex.Message)
        End Try
    End Sub

#End Region

#Region "Event"

    Private Sub DGV_BILL_CellEndEditk(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_BILL.CellEndEdit
        Try
            If e.ColumnIndex = 7 Then
                If DGV_BILL.Rows(e.RowIndex).Cells(23).Value = True Then
                    Dim CAL_AMTOUSTAND As Decimal = DGV_BILL.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value
                    Dim CAL_NETAMOUNT As Decimal = DGV_BILL.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
                    Call AMTCHANGE(CAL_NETAMOUNT)
                    If DGV_BILL.Rows(e.RowIndex).Cells(e.ColumnIndex).Value > CAL_AMTOUSTAND Then
                        MessageBox.Show("OVER LIMIT OUSTANDING")
                        DGV_BILL.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value = CAL_AMTOUSTAND
                    Else
                        If CAL_AMTOUSTAND > 0 Then
                            If CAL_AMTOUSTAND = TEMP_AMTOUSTAND Then
                                DGV_BILL.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value = CAL_AMTOUSTAND - CAL_NETAMOUNT
                            Else
                                DGV_BILL.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value = TEMP_AMTOUSTAND - CAL_NETAMOUNT
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            WriteLog("Error 196 (DGV_BILL_CellEndEditk) : " & ex.Message)
        End Try
    End Sub

    Private Sub DGV_BILL_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_BILL.CellContentClick
        Try
            If e.ColumnIndex = 23 Then
                TEMP_AMTOUSTAND = DGV_BILL.Rows(e.RowIndex).Cells(6).Value

                DGV_BILL.Rows(e.RowIndex).Cells(7).ReadOnly = False

                Call AMTCHANGE(TEMP_AMTOUSTAND)
                SendKeys.Send("{TAB}")
                SendKeys.Send("{RIGHT}")

            End If

        Catch ex As Exception
            WriteLog("Error 211 (DGV_BILL_CellContentClick) : " & ex.Message)
        End Try
    End Sub

    Private Sub TXTBILL_DATEF_ValueChanged(sender As Object, e As EventArgs) Handles TXTBILL_DATEF.ValueChanged
        SendKeys.Send("{DIVIDE}")
    End Sub

    Private Sub TXTBILL_DATET_ValueChanged(sender As Object, e As EventArgs) Handles TXTBILL_DATET.ValueChanged
        SendKeys.Send("{DIVIDE}")
    End Sub

    Private Sub txtBill_DOCDATE_ValueChanged(sender As Object, e As EventArgs) Handles txtBill_DOCDATE.ValueChanged
        SendKeys.Send("{DIVIDE}")
    End Sub

    Private Sub txtBILL_INVDATE_ValueChanged(sender As Object, e As EventArgs) Handles txtBILL_INVDATE.ValueChanged
        SendKeys.Send("{DIVIDE}")
    End Sub

    Private Sub txtBILL_DueDate_ValueChanged(sender As Object, e As EventArgs) Handles txtBILL_DueDate.ValueChanged
        SendKeys.Send("{DIVIDE}")
    End Sub

    Sub GETBILL()
        Try
            Dim dtGETBILL As DataTable = New DataTable
            Dim IDCUST As String = TXTBILL_IDCUST.Text
            Dim DATEF As String = Format(TXTBILL_DATEF.Value, "yyyyMMdd")
            Dim DATET As String = Format(TXTBILL_DATET.Value, "yyyyMMdd")
            Dim BILLNO As String = TXTBILL_BILLNO.Text.TrimEnd
            Dim vBILLNO As String = ""
            txtBILL_TERMCODE.Text = MASTER.GETDATA_TERMCODE(IDCUST)

            DGV_BILL.DataSource = Nothing
            If BILLNO = "***New***" Then
                If CHBXBILL_SHOW.CheckState = True Then
                    Dim ShowPostCon As String = "AND FMSBILLDETAIL.STA_0 <> '2'"
                    dtGETBILL = MASTER.GETDATA_SOURCEBILLDETAIL(IDCUST, DATEF, DATET, ShowPostCon)
                Else
                    dtGETBILL = MASTER.GETDATA_SOURCEBILLDETAIL(IDCUST, DATEF, DATET)
                End If
                vBILLNO = "***New***"
                dtGETBILL = ProcessChkAMTOUTSTAND(dtGETBILL, vBILLNO) 'CHECK OUTSTANDING <> 0 
            Else
                If CHBXBILL_SHOW.CheckState = True Then
                    Dim ShowPostCon As String = "AND FMSBILLDETAIL.STA_0 <> '2' AND (FMSBILLDETAIL.BILLNO = '" & BILLNO & "' or FMSBILLDETAIL.BILLNO IS NULL )"
                    dtGETBILL = MASTER.GETDATA_SOURCEBILLDETAIL(IDCUST, DATEF, DATET, ShowPostCon)
                Else
                    Dim ShowPostCon As String = "AND (FMSBILLDETAIL.BILLNO = '" & BILLNO & "' or FMSBILLDETAIL.BILLNO IS NULL )"
                    dtGETBILL = MASTER.GETDATA_SOURCEBILLDETAIL(IDCUST, DATEF, DATET, ShowPostCon)
                End If
            End If

            Call PROCESS.DisplayDGVBILL(dtGETBILL, vBILLNO)
        Catch ex As Exception
            WriteLog("ERROR 265 GETBILL() : " & ex.Message)
        End Try
    End Sub


    Private Sub BTN_BILLNEWNEW_Click(sender As Object, e As EventArgs) Handles BTN_BILLNEWNEW.Click
        Try
            TXTBILL_BILLNO.Text = "***New***"
            BTNBill_POST.Enabled = True
            BTNBill_DELETE.Enabled = True
            DGV_BILL.DataSource = Nothing
            CbmBOI.Enabled = True
            CbmBOI.Text = "NON BOI"
            txtBILLAMOUNT.Text = "0.00"
            TXTBILL_IDCUST.Text = ""
            txtNAMECUST.Text = ""
            TXTBILL_DATEF.Value = New DateTime(TXTBILL_DATEF.Value.Year, TXTBILL_DATEF.Value.Month, 1)
            TXTBILL_DATET.Value = Now.ToShortDateString
            txtBILL_INVDATE.Value = Now.ToShortDateString
            txtBILL_DueDate.Value = Now.ToShortDateString
            TXTBILL_IDCUST.Enabled = True
            BTN_BILLALL.Checked = False
            TXTBILL_REF.Text = ""
            txtBILL_Comment.Text = ""

            GETBILL()
        Catch ex As Exception
            WriteLog("Error 283 (BTN_BILLNEWNEW_Click) " & ex.Message)
        End Try
    End Sub



    Private Sub TXTBILL_IDCUST_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles TXTBILL_IDCUST.PreviewKeyDown
        Try
            If e.KeyCode = Keys.Tab Then
                txtNAMECUST.Text = MASTER.GET_IDCUST(TXTBILL_IDCUST.Text)
                BTN_GETBILL_Click(Nothing, Nothing)
            End If
        Catch ex As Exception
            WriteLog("Error 263 (TXTBILL_IDCUST_PreviewKeyDown) " & ex.Message)
        End Try
    End Sub

    Sub AMTCHANGE(ByVal CAL_NETAMOUNT As Decimal)
        Try
            Dim BILLAMT As Decimal = 0
            Dim DT As DataTable = New DataTable

            'DT = CType(DGV_BILL.DataSource, DataTable).Copy

            DT = CONVERTDGVtoDATATABLE(DGV_BILL)

            For i = 0 To DT.Rows.Count - 1
                If DT.Rows(i).Item("CHECK_0").ToString = "True" Then
                    BILLAMT = BILLAMT + CDec(DT.Rows(i).Item("NETAMT").ToString)
                End If
            Next
            Dim SUMBILLAMOUNT As Decimal = BILLAMT + CAL_NETAMOUNT
            txtBILLAMOUNT.Text = SUMBILLAMOUNT.ToString("N")

        Catch ex As Exception
            WriteLog("Error 323 : (AMTCHANGE) " & ex.Message)
        End Try

    End Sub





#End Region

End Class