Public Class FrmBatchBillingNote

#Region "EVENT"
    Private Sub FrmBatchBillingNote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            GET_BATCHBILL()

        Catch ex As Exception
            WriteLog("ERROR 8 (FrmBatchBillingNote_Load) " & ex.Message)
        End Try

    End Sub

    Sub GET_BATCHBILL()
        Try
            Dim dtBATCHBILL As DataTable = New DataTable
            Dim STA_0 As String
            If CBX_BTCHBILL.Checked = True Then
                STA_0 = "True"
            Else
                STA_0 = "False"
            End If
            dtBATCHBILL = MASTER.GETDATA_BATCHBILL(STA_0)
            Call DisplayDGV_BATCHBILL(dtBATCHBILL)

        Catch ex As Exception
            WriteLog("ERROR 25 (GET_BATCHBILL) " & ex.Message)
        End Try
    End Sub

    Sub CBX_BTCHBILL_CheckedChanged(sender As Object, e As EventArgs) Handles CBX_BTCHBILL.CheckedChanged
        Try
            GET_BATCHBILL()
        Catch ex As Exception
            WriteLog("ERROR 33 (CBX_BTCHBILL_CheckedChanged) " & ex.Message)
        End Try
    End Sub

    Sub BTNBTCH_REFRESH_Click(sender As Object, e As EventArgs) Handles BTNBTCH_REFRESH.Click
        Try
            GET_BATCHBILL()
        Catch ex As Exception
            WriteLog("ERROR 40 (BTNBTCH_REFRESH_Click) " & ex.Message)
        End Try
    End Sub

#End Region

#Region "BUTTON"
    Private Sub BTNBTCH_NEW_Click(sender As Object, e As EventArgs) Handles BTNBTCH_NEW.Click
        Try
            ShowFrmBillingNote()
            FrmBillingNote.TXTBILL_BILLNO.Text = "***New***"
            FrmBillingNote.TXTBILL_BILLNO.Enabled = False
            FrmBillingNote.DGV_BILL.DataSource = Nothing
            FrmBillingNote.CbmBOI.Text = "NON BOI"
            FrmBillingNote.TXTBILL_DATEF.Value = New DateTime(FrmBillingNote.TXTBILL_DATEF.Value.Year, FrmBillingNote.TXTBILL_DATEF.Value.Month, 1)
            FrmBillingNote.txtBILLAMOUNT.Text = "0.00"
            FrmBillingNote.GETBILL()
        Catch ex As Exception
            WriteLog("ERROR 54 (BTNBTCH_NEW_Click) " & ex.Message)
        End Try
    End Sub

    Private Sub BTNBTCH_OPEN_Click(sender As Object, e As EventArgs) Handles BTNBTCH_OPEN.Click
        Try
            ShowFrmBillingNote()
            'SHOW HEADER
            'GETDATA 
            Dim RowINDX As Integer = DGV_BATCHBILL.CurrentRow.Index
            Dim BILLNO As String = ""
            Dim IDCUST As String = ""
            Dim dtcopyBATCHBILL As DataTable
            dtcopyBATCHBILL = CType(DGV_BATCHBILL.DataSource, DataTable)
            For i = 0 To dtcopyBATCHBILL.Rows.Count - 1
                If i = RowINDX Then

                    Dim BILLDOCDATE As String = ""
                    Dim DUEDATE As String = ""
                    Dim REF As String = ""
                    Dim COMMENT As String = ""
                    BILLNO = dtcopyBATCHBILL.Rows(i).Item("BILLNO").ToString
                    IDCUST = dtcopyBATCHBILL.Rows(i).Item("IDCUST").ToString

                    FrmBillingNote.TXTBILL_BILLNO.Text = BILLNO
                    FrmBillingNote.TXTBILL_IDCUST.Text = IDCUST
                    Dim DTBILLHEADER As DataTable = New DataTable
                    DTBILLHEADER = MASTER.GETDATA_BILLHEADER(BILLNO, IDCUST)
                    Dim INVDATE As String = DTBILLHEADER.Rows(0).Item("INVDATE").ToString.TrimEnd
                    Dim DATEDUE As String = DTBILLHEADER.Rows(0).Item("DUEDATE").ToString.TrimEnd
                    FrmBillingNote.TXTBILL_REF.Text = DTBILLHEADER.Rows(0).Item("REF_0").ToString.TrimEnd
                    FrmBillingNote.txtBILL_Comment.Text = DTBILLHEADER.Rows(0).Item("COMMENT").ToString.TrimEnd
                    FrmBillingNote.txtBILL_TERMCODE.Text = DTBILLHEADER.Rows(0).Item("TERMCODE").ToString.TrimEnd
                    FrmBillingNote.CbmBOI.Text = DTBILLHEADER.Rows(0).Item("BOI").ToString.TrimEnd
                    FrmBillingNote.txtNAMECUST.Text = MASTER.GET_IDCUST(IDCUST)
                    FrmBillingNote.txtBILLAMOUNT.Text = CDec(DTBILLHEADER.Rows(0).Item("NETAMT").ToString.TrimEnd).ToString("N")
                    FrmBillingNote.txtBILL_INVDATE.Value = INVDATE.Substring(6, 2) & "/" & INVDATE.Substring(4, 2) & "/" & INVDATE.Substring(0, 4)
                    FrmBillingNote.txtBILL_DueDate.Value = DATEDUE.Substring(6, 2) & "/" & DATEDUE.Substring(4, 2) & "/" & DATEDUE.Substring(0, 4)

                    Select Case DTBILLHEADER.Rows(0).Item("STA_0").ToString.TrimEnd
                        Case "1"
                            FrmBillingNote.txtSTA.Text = "Open"

                        Case "2"
                            FrmBillingNote.BTNBill_POST.Enabled = False
                            FrmBillingNote.BTNBill_DELETE.Enabled = False
                            FrmBillingNote.CbmBOI.Enabled = False
                            FrmBillingNote.txtSTA.Text = "Posted"
                            FrmBillingNote.DGV_BILL.ReadOnly = True
                            FrmBillingNote.DGV_BILL.DefaultCellStyle.BackColor = Color.LightGray
                        Case "3"
                            FrmBillingNote.BTNBill_POST.Enabled = False
                            FrmBillingNote.BTNBill_DELETE.Enabled = False
                            FrmBillingNote.CbmBOI.Enabled = False
                            FrmBillingNote.txtSTA.Text = "RECEIPT"
                        Case "4"
                            FrmBillingNote.BTNBill_POST.Enabled = False
                            FrmBillingNote.BTNBill_DELETE.Enabled = False
                            FrmBillingNote.CbmBOI.Enabled = False
                            FrmBillingNote.txtSTA.Text = "Reverse"
                            FrmBillingNote.DGV_BILL.ReadOnly = True
                            FrmBillingNote.DGV_BILL.DefaultCellStyle.BackColor = Color.LightGray
                        Case "5"
                            FrmBillingNote.BTNBill_POST.Enabled = False
                            FrmBillingNote.BTNBill_DELETE.Enabled = False
                            FrmBillingNote.CbmBOI.Enabled = False
                            FrmBillingNote.txtSTA.Text = "Delete"
                            FrmBillingNote.DGV_BILL.ReadOnly = True
                            FrmBillingNote.DGV_BILL.DefaultCellStyle.BackColor = Color.LightGray

                        Case Else
                    End Select


                End If
            Next

            If BILLNO <> "" Then
                'SHOW DETAIL 
                Dim dtBILLdetail As DataTable = MASTER.GETDATA_BILLDETAIL(BILLNO, IDCUST)
                'dtBILLdetail = ProcessDetailChkAMTOUTSTAND(dtBILLdetail, "")

                If dtBILLdetail.Rows.Count > 0 Then
                    For j = 0 To dtBILLdetail.Rows.Count - 1

                        Select Case dtBILLdetail.Rows(j).Item("STA_0").ToString
                            Case "1"
                                dtBILLdetail.Rows(j).Item("STA_0") = "Open"
                            Case "2"
                                dtBILLdetail.Rows(j).Item("STA_0") = "Posted"
                            Case "3"
                            Case "4"
                                dtBILLdetail.Rows(j).Item("STA_0") = "Reverse"
                            Case "5"
                                dtBILLdetail.Rows(j).Item("STA_0") = "Delete"
                        End Select
                    Next

                End If
                DisplayDGVBILL(dtBILLdetail, "OPENBATCH")


                Dim vDateF = MASTER.GETDATA_MININVDATE(BILLNO)
                Dim vDateT = MASTER.GETDATA_MAXINVDATE(BILLNO)


                FrmBillingNote.TXTBILL_DATEF.Value = vDateF.Substring(6, 2) & "/" & vDateF.Substring(4, 2) & "/" & vDateF.Substring(0, 4)
                FrmBillingNote.TXTBILL_DATET.Value = vDateT.Substring(6, 2) & "/" & vDateT.Substring(4, 2) & "/" & vDateT.Substring(0, 4)


            Else
                FrmBillingNote.CbmBOI.Text = "NON BOI"
            End If


            FrmBillingNote.TXTBILL_BILLNO.ReadOnly = True
            FrmBillingNote.TXTBILL_IDCUST.ReadOnly = True


        Catch ex As Exception
            WriteLog("ERROR 139 (BTNBTCH_OPEN_Click) " & ex.Message)
        End Try
        'DisplayDGVBILL()
    End Sub

    Private Sub BTNBTCH_POST_Click(sender As Object, e As EventArgs) Handles BTNBTCH_POST.Click
        Try
            Dim RowINDX As Integer = DGV_BATCHBILL.CurrentRow.Index

            Dim BILLNO As String
            Dim IDCUST As String = ""
            Dim dtcopyBATCHBILL As DataTable
            dtcopyBATCHBILL = CType(DGV_BATCHBILL.DataSource, DataTable)
            For i = 0 To dtcopyBATCHBILL.Rows.Count - 1

                If i = RowINDX Then
                    BILLNO = dtcopyBATCHBILL.Rows(i).Item("BILLNO").ToString
                    Dim dialogOK As DialogResult = MsgBox("Do you post billing " & BILLNO & " ?", MessageBoxButtons.OKCancel)
                    If dialogOK = DialogResult.OK Then

                        Call DATACLASS.UPDATEFMSBILLHEAD_POST(BILLNO)
                        Exit For
                    Else
                        Exit Try
                    End If
                End If
            Next
            'CBX_BTCHBILL.Checked = True
            GET_BATCHBILL()
        Catch ex As Exception
            WriteLog("ERROR 170 (BTNBTCH_POST_Click) " & ex.Message)
        End Try
    End Sub

    Private Sub BTNBTCH_DELETE_Click(sender As Object, e As EventArgs) Handles BTNBTCH_DELETE.Click
        Try

            Dim RowINDX As Integer = DGV_BATCHBILL.CurrentRow.Index

            Dim BILLNO As String = ""
            Dim IDCUST As String = ""
            Dim dtcopyBATCHBILL As DataTable
            dtcopyBATCHBILL = CType(DGV_BATCHBILL.DataSource, DataTable)

            For i = 0 To dtcopyBATCHBILL.Rows.Count - 1
                If i = RowINDX Then
                    BILLNO = dtcopyBATCHBILL.Rows(i).Item("BILLNO").ToString
                    Dim dialogOK As DialogResult = MsgBox("Do you confirm to delete billing " & BILLNO & " ?", MessageBoxButtons.OKCancel)
                    If dialogOK = DialogResult.OK Then

                        Call DATACLASS.DELETEFMSBILLHEAD(BILLNO)
                        Exit For
                    Else
                        Exit Try
                    End If

                End If
            Next
            CBX_BTCHBILL.Checked = True
            GET_BATCHBILL()

        Catch ex As Exception
            WriteLog("ERROR 200 (BTNBTCH_DELETE_Click) : " & ex.Message)
        End Try
    End Sub

    Private Sub BTNBTCH_PRINT_Click(sender As Object, e As EventArgs) Handles BTNBTCH_PRINT.Click
        Try
            Dim RowINDX As Integer = DGV_BATCHBILL.CurrentRow.Index
            Dim BILLNO As String = ""
            Dim IDCUST As String = ""
            Dim dtcopyBATCHBILL As DataTable
            dtcopyBATCHBILL = CType(DGV_BATCHBILL.DataSource, DataTable)
            MAIN.txtForm.Text = "FrmBatchBillingNote"
            For i = 0 To dtcopyBATCHBILL.Rows.Count - 1
                If i = RowINDX Then

                    BILLNO = dtcopyBATCHBILL.Rows(i).Item("BILLNO").ToString
                    Call FrmPrintBill.ShowReport(BILLNO)
                    Exit For
                End If
            Next
        Catch ex As Exception
            WriteLog("ERROR 222 (BTNBTCH_PRINT_Click) : " & ex.Message)
        End Try
    End Sub

    Private Sub BTNBatchBILL_SEARCH_Click(sender As Object, e As EventArgs) Handles BTNBatchBILL_SEARCH.Click
        Try
            MAIN.txtForm.Text = "FrmBatchBillingNote"
            FrmSearch.txtSearch.Text = "BatchBillingNote"
            Call FrmSearch.SearchShow("BILLNO", "IDCUST", "Billing Number", "Customer Number", "TEXTSNAM", "Customer Name")
        Catch ex As Exception
            WriteLog("ERROR 230 (BTNBatchBILL_SEARCH_Click)" & ex.Message)
        End Try
    End Sub
    Private Sub BTNBTCHBILL_CLOSE_Click(sender As Object, e As EventArgs) Handles BTNBTCHBILL_CLOSE.Click
        Me.Close()
        TopMost = False
    End Sub

    Private Sub txtBatchBILL_SEARCH_TextChanged(sender As Object, e As EventArgs) Handles txtBatchBILL_SEARCH.TextChanged
        Try
            Dim dtBATCHBILL As DataTable = New DataTable
            Dim STA_0 As String = ""
            dtBATCHBILL = MASTER.GETDATA_BATCHBILL(STA_0, txtBatchBILL_SEARCH.Text)
            Call DisplayDGV_BATCHBILL(dtBATCHBILL)

        Catch ex As Exception
            WriteLog("ERROR 244 (txtBatchBILL_SEARCH_TextChanged) " & ex.Message)
        End Try
    End Sub

    Private Sub DGV_BATCHBILL_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_BATCHBILL.CellContentClick
        Try
            Select Case DGV_BATCHBILL.Rows(e.RowIndex).Cells("STATUS").Value
                Case "Open"
                    BTNBTCH_DELETE.Enabled = True
                    BTNBTCH_POST.Enabled = True

                Case Else
                    BTNBTCH_DELETE.Enabled = False
                    BTNBTCH_POST.Enabled = False

            End Select
        Catch ex As Exception
            WriteLog("ERROR 265 (DGV_BATCHBILL_CellContentClick) " & ex.Message)
        End Try
    End Sub





#End Region

#Region "UTILITY"


#End Region

End Class