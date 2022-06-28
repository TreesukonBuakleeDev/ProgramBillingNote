Public Class FrmBillingReverse
    Private Sub BTN_GETREVBILL_Click(sender As Object, e As EventArgs) Handles BTN_GETREVBILL.Click
        Try
            If TXTREVBILL_IDCUST.Text.TrimEnd = "" Then
                MessageBox.Show("Warning : Please enter Customer again ")
            Else
                Dim dtREVBILL As DataTable = New DataTable
                dtREVBILL = MASTER.GETDATA_REVBILL(TXTREVBILL_IDCUST.Text, TXTREVBILL_BILLNOFrom.Text, TXTREVBILL_BILLNOTo.Text)
                Call DisplayDGV_BATCHREVBILL(dtREVBILL)
            End If

        Catch ex As Exception
            WriteLog("Error 13 (BTN_GETREVBILL_Click) : " & ex.Message)
        End Try
    End Sub

    Private Sub BTNREVBILL_SAVE_Click(sender As Object, e As EventArgs) Handles BTNREVBILL_SAVE.Click
        Dim cntCheck As Decimal
        Dim cntRev As Decimal
        Try


            Dim DTREV As DataTable = New DataTable

            DTREV = CONVERTDGVtoDATATABLE(DGV_REVBILL)
            '>>SORTING DTREV BY INVNO  
            Dim dialogOK As DialogResult = MsgBox("Do you confirm to reverse Billing note ?", MessageBoxButtons.OKCancel)
            If dialogOK = DialogResult.OK Then

                For I = 0 To DTREV.Rows.Count - 1
                    Dim RCPNO As String
                    RCPNO = DTREV.Rows(I).Item("RCPNO").ToString
                    Dim CHECK_0 As String = DTREV.Rows(I).Item("CHECK_0").ToString
                    If CHECK_0.ToUpper = "TRUE" Then
                        Dim BILLNO As String = DTREV.Rows(I).Item("BILLNO").ToString.TrimEnd
                        Dim INVNO As String = DTREV.Rows(I).Item("INVNO").ToString.TrimEnd
                        Dim IDCUST As String = DTREV.Rows(I).Item("IDCUST").ToString.TrimEnd
                        cntCheck = cntCheck + 1
                        If DATACLASS.UPDATEFMSBILLDETAIL_REVERSE(BILLNO, INVNO, IDCUST) = True Then
                            cntRev = cntRev + 1
                        End If
                    End If
                Next

            End If

            Dim dtREVBILL As DataTable = New DataTable
            dtREVBILL = MASTER.GETDATA_REVBILL(TXTREVBILL_IDCUST.Text, TXTREVBILL_BILLNOFrom.Text, TXTREVBILL_BILLNOTo.Text)
            Call DisplayDGV_BATCHREVBILL(dtREVBILL)
            FrmBatchBillingNote.CBX_BTCHBILL.Checked = True
            FrmBatchBillingNote.CBX_BTCHBILL_CheckedChanged(Nothing, Nothing)
        Catch ex As Exception
            WriteLog("Error 51 (BTNREVBILL_SAVE_Click) : " & ex.Message)
        End Try
        MessageBox.Show("Billing Note reverse  " & cntRev & "/" & cntCheck)
    End Sub

    Private Sub BTN_REVBILLFINDCUST_Click(sender As Object, e As EventArgs) Handles BTN_REVBILLFINDCUST.Click
        Try
            MAIN.txtForm.Text = "FrmBillingReverse"
            FrmSearch.txtSearch.Text = "FrmBillingReverse"
            Call FrmSearch.SearchShow("IDCUST", "NAMECUST", "Customer Number", "Customer Name", "", "")
        Catch ex As Exception
            WriteLog("Error 60 (BTN_REVBILLFINDCUST_Click) : " & ex.Message)
        End Try
    End Sub

#Region "EVENT"
    Sub DisplayDGV_BATCHREVBILL(ByVal dtREVBILL As DataTable)

        Try
            DGV_REVBILL.DataSource = Nothing

            For I = 0 To dtREVBILL.Rows.Count - 1
                Dim IDCUST As String = dtREVBILL.Rows(I).Item("IDCUST").ToString
                Dim RCPNO As String = dtREVBILL.Rows(I).Item("RCPNO").ToString
                Dim CUSTNAME As String = ""

                CUSTNAME = MASTER.GET_IDCUST(IDCUST)
                dtREVBILL.Rows(I).Item("CUSTNAME") = CUSTNAME
            Next
            'dtREVBILL = MergeTransactionBill(dtREVBILL, "Reverse")
            DGV_REVBILL.DataSource = dtREVBILL

            If DGV_REVBILL.Columns.Contains("CHECK_0") = True Then
                Dim dtgTextbox As New DataGridViewTextBoxColumn
                Dim dtgCheckbox As New DataGridViewCheckBoxColumn
                'Add column check
                dtgCheckbox = New DataGridViewCheckBoxColumn
                dtgCheckbox.DataPropertyName = "CHECK_0"
                dtgCheckbox.HeaderText = ""
                dtgTextbox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                dtgCheckbox.Name = "CHECK_0"
                dtgCheckbox.AutoSizeMode = False
                dtgCheckbox.Width = 30
                dtgCheckbox.ReadOnly = False
                dtgCheckbox.DisplayIndex = 1

                DGV_REVBILL.Columns.Add(dtgCheckbox)
            End If

            With DGV_REVBILL
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "ใบวางบิล"
                .Columns(1).HeaderCell.Value = "เลขที่เอกสาร"
                .Columns(2).HeaderCell.Value = "รหัสลูกค้า"
                .Columns(3).HeaderCell.Value = "ชื่อลูกค้า"
                .Columns(4).HeaderCell.Value = "วันที่เอกสาร"
                .Columns(5).HeaderCell.Value = "วันที่ครบกำหนด"
                .Columns(0).HeaderCell.Value = "เลขที่บิล"
                .Columns(6).HeaderCell.Value = "เลขที่ใบเสร็จ"
                .Columns(8).HeaderCell.Value = "ยอดเงิน"
            End With

            With DGV_REVBILL
                .Columns(0).Width = 100
                .Columns(1).Width = 100
                .Columns(2).Width = 150
                .Columns(3).Width = 100
                .Columns(4).Width = 80
                .Columns(5).Width = 80
                .Columns(6).Width = 100
                .Columns(8).Width = 100
            End With

            With DGV_REVBILL
                .Columns(9).Visible = False
                .Columns(10).Visible = False
                .Columns(7).Visible = False
            End With

            With DGV_REVBILL
                .Columns(0).DisplayIndex = 2
                .Columns(1).DisplayIndex = 3
                .Columns(2).DisplayIndex = 4
                .Columns(3).DisplayIndex = 5
                .Columns(4).DisplayIndex = 6
                .Columns(5).DisplayIndex = 7
                .Columns(6).DisplayIndex = 8
            End With

            With DGV_REVBILL
                .ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray
                .EnableHeadersVisualStyles = False
                .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(8).DefaultCellStyle.Format = "N2"
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns(5).DefaultCellStyle.WrapMode = DataGridViewTriState.True
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With

            With DGV_REVBILL
                .Columns(0).ReadOnly = True
                .Columns(1).ReadOnly = True
                .Columns(2).ReadOnly = True
                .Columns(3).ReadOnly = True
                .Columns(4).ReadOnly = True
                .Columns(5).ReadOnly = True
                .Columns(6).ReadOnly = True
                .Columns(7).ReadOnly = False
            End With

        Catch ex As Exception
            WriteLog("Error 155 (DisplayDGV_BATCHREVBILL) : " & ex.Message)
        End Try
    End Sub

    Private Sub BTN_REVBILLFROM_Click(sender As Object, e As EventArgs) Handles BTN_REVBILLFROM.Click
        Try
            MAIN.txtForm.Text = "FrmBillingReverse"
            'If TXTREVBILL_IDCUST.Text.TrimEnd = "" Then
            '    MessageBox.Show("Warning : Please Enter Customer ID.")
            'Else
            FrmSearch.txtSearch.Text = "REV Billling Number From"
            Call FrmSearch.SearchShow("BILLNO", "IDCUST", "Billing Number", "Customer Number", "NAMECUST", "Customer Name")
            'End If
        Catch ex As Exception
            WriteLog("Error 166 (BTN_REVBILLFROM_Click) : " & ex.Message)
        End Try
    End Sub

    Private Sub BTN_REVBILLTO_Click(sender As Object, e As EventArgs) Handles BTN_REVBILLTO.Click
        Try
            MAIN.txtForm.Text = "FrmBillingReverse"
            'If TXTREVBILL_IDCUST.Text.TrimEnd = "" Then
            '    MessageBox.Show("Warning : Please Enter Customer ID.")
            'Else
            FrmSearch.txtSearch.Text = "REV Billing Number To"
            Call FrmSearch.SearchShow("BILLNO", "IDCUST", "Billing Number", "Customer Number", "NAMECUST", "Customer Name")
            'End If
        Catch ex As Exception
            WriteLog("Error 180 (BTN_REVBILLTO_Click) : " & ex.Message)
        End Try
    End Sub

    Private Sub BTNREVBill_CLOSE_Click(sender As Object, e As EventArgs) Handles BTNREVBill_CLOSE.Click
        Close()
        TopMost = False
    End Sub

    Private Sub FrmBillingReverse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Me.TopMost = True
        Catch ex As Exception
            WriteLog("Error 196 (FrmBillingReverse_Load) : " & ex.Message)
        End Try
    End Sub
#End Region
End Class