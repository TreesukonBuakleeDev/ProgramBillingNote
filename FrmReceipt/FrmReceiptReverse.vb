Public Class FrmReceiptReverse
    Private Sub BTN_GETRCP_Click(sender As Object, e As EventArgs) Handles BTN_GETRCP.Click
        Try
            If TXTREVRCP_IDCUST.Text.TrimEnd = "" Then
                MessageBox.Show("Warning : Please enter Customer again ")
            Else
                Dim dtRCP As DataTable = New DataTable
                dtRCP = MASTER.GETDATA_REVRCP(TXTREVRCP_IDCUST.Text, TXTREVRCP_BILLNOFrom.Text, TXTREVRCP_BILLNOTo.Text)
                Call DisplayDGV_BATCHREVRCP(dtRCP)
            End If

        Catch ex As Exception
            WriteLog("Error 13 (BTN_GETRCP_Click) : " & ex.Message)
        End Try
    End Sub

    Private Sub BTN_GETRCPREV_Click(sender As Object, e As EventArgs) Handles BTN_GETRCPREV.Click
        Try
            If TXTREVRCP_IDCUST.Text.TrimEnd = "" Then
                MessageBox.Show("Warning : Please enter Customer again ")
            Else
                Dim dtRCP As DataTable = New DataTable
                dtRCP = MASTER.GETDATA_REVRCP(TXTREVRCP_IDCUST.Text, TXTREVRCP_BILLNOFrom.Text, TXTREVRCP_BILLNOTo.Text)
                Call DisplayDGV_BATCHREVRCP(dtRCP)
            End If

        Catch ex As Exception
            WriteLog("Error 13 (BTN_GETRCP_Click) : " & ex.Message)
        End Try
    End Sub

    Sub DisplayDGV_BATCHREVRCP(ByVal dtBATCHRCP As DataTable)
        Try
            DGV_REVRECEIPT.DataSource = Nothing

            For I = 0 To dtBATCHRCP.Rows.Count - 1
                Dim IDCUST As String = dtBATCHRCP.Rows(I).Item("IDCUST").ToString
                Dim RCPNO As String = dtBATCHRCP.Rows(I).Item("RCPNO").ToString
                Dim CUSTNAME As String = ""

                CUSTNAME = MASTER.GET_IDCUST(IDCUST)
                dtBATCHRCP.Rows(I).Item("CUSTNAME") = CUSTNAME
            Next

            DGV_REVRECEIPT.DataSource = dtBATCHRCP


            If DGV_REVRECEIPT.Columns.Contains("CHECK_0") = True Then
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

                DGV_REVRECEIPT.Columns.Add(dtgCheckbox)
            End If

            With DGV_REVRECEIPT
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "เลขที่ใบเสร็จ"
                .Columns(1).HeaderCell.Value = "รหัสลูกค้า"
                .Columns(2).HeaderCell.Value = "ชื่อลูกค้า"
                .Columns(3).HeaderCell.Value = "วันที่เอกสาร"
                .Columns(4).HeaderCell.Value = "วันที่ครบกำหนด"
                '.Columns(5).HeaderCell.Value = "เลขที่บิล"
                '.Columns(6).HeaderCell.Value = "เลขที่ใบแจ้งหนี้"
                .Columns(8).HeaderCell.Value = "จำนวนเงิน"
                .Columns(11).HeaderCell.Value = "Import CB"
            End With

            With DGV_REVRECEIPT
                .Columns(0).Width = 100
                .Columns(1).Width = 100
                .Columns(2).Width = 200
                .Columns(3).Width = 80
                .Columns(4).Width = 80
                '.Columns(5).Width = 100
                '.Columns(6).Width = 100
                .Columns(8).Width = 100
                .Columns(11).Width = 50
            End With

            With DGV_REVRECEIPT

                .Columns(5).Visible = False
                .Columns(6).Visible = False
                .Columns(7).Visible = False
                .Columns(9).Visible = False
                .Columns(10).Visible = False
            End With

            With DGV_REVRECEIPT
                .Columns(0).DisplayIndex = 2
                .Columns(1).DisplayIndex = 3
                .Columns(2).DisplayIndex = 4
                .Columns(3).DisplayIndex = 5
                .Columns(4).DisplayIndex = 6
                '.Columns(5).DisplayIndex = 7
                '.Columns(6).DisplayIndex = 8
                .Columns(8).DisplayIndex = 9
                .Columns(11).DisplayIndex = 10
            End With

            With DGV_REVRECEIPT
                .ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray
                .EnableHeadersVisualStyles = False
                .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(8).DefaultCellStyle.Format = "N2"

                .Columns(4).DefaultCellStyle.WrapMode = DataGridViewTriState.True
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns(3).DefaultCellStyle.WrapMode = DataGridViewTriState.True
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns(11).DefaultCellStyle.WrapMode = DataGridViewTriState.True
                .Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                '.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With

            With DGV_REVRECEIPT
                .Columns(0).ReadOnly = True
                .Columns(1).ReadOnly = True
                .Columns(2).ReadOnly = True
                .Columns(3).ReadOnly = True
                .Columns(4).ReadOnly = True
                '.Columns(5).ReadOnly = True
                '.Columns(6).ReadOnly = True
                .Columns(7).ReadOnly = False

            End With

        Catch ex As Exception
            WriteLog("Error 108 (DisplayDGV_BATCHREVRCP) :  " & ex.Message)
        End Try
    End Sub

    Private Sub BTNREVRCP_SAVE_Click(sender As Object, e As EventArgs) Handles BTNREVRCP_SAVE.Click
        Dim cntCheck As Decimal
        Dim cntRev As Decimal
        Try
            Dim DTREV As DataTable = New DataTable
            'DTREV = CType(DGV_REVRECEIPT.DataSource, DataTable).Copy
            DTREV = CONVERTDGVtoDATATABLE(DGV_REVRECEIPT)
            Dim dialogOK As DialogResult = MsgBox("Do you confirm to reverse receipt ?", MessageBoxButtons.OKCancel)
            If dialogOK = DialogResult.OK Then
                For I = 0 To DTREV.Rows.Count - 1
                    Dim RCPNO As String
                    RCPNO = DTREV.Rows(I).Item("RCPNO").ToString
                    Dim CHECK_0 As String = DTREV.Rows(I).Item("CHECK_0").ToString
                    If CHECK_0.ToUpper = "TRUE" Then
                        cntCheck = cntCheck + 1
                        'UPDATE STA_0 = 4 //REVERSE
                        If DATACLASS.UPDATEFMSRCPHEAD_REV(RCPNO) = True Then
                            cntRev = cntRev + 1
                        End If
                    End If
                Next
            End If
            Dim dtRCP As DataTable = New DataTable
            dtRCP = MASTER.GETDATA_REVRCP(TXTREVRCP_IDCUST.Text, TXTREVRCP_BILLNOFrom.Text, TXTREVRCP_BILLNOTo.Text)
            Call DisplayDGV_BATCHREVRCP(dtRCP)

        Catch ex As Exception
            WriteLog("Error 130 : " & ex.Message)
        End Try
        FrmBatchReceipt.CBX_BTCHRCP.Checked = True
        FrmBatchReceipt.BTNBTCH_REFRESHRCP_Click(Nothing, Nothing)
        MessageBox.Show("Receipt reverse  " & cntRev & "/" & cntCheck)
    End Sub

    Private Sub BTN_REVRCPFINDCUST_Click(sender As Object, e As EventArgs) Handles BTN_REVRCPFINDCUST.Click
        Try

            MAIN.txtForm.Text = "FrmReceiptReverse"
            FrmSearch.txtSearch.Text = "FrmReceiptReverse"
            Call FrmSearch.SearchShow("IDCUST", "NAMECUST", "Customer Number", "Customer Name", "", "")
        Catch ex As Exception
            WriteLog("Error 140 (BTN_REVRCPFINDCUST_Click) :  " & ex.Message)
        End Try
    End Sub

    Private Sub BTN_REVRCPBILLFROM_Click(sender As Object, e As EventArgs) Handles BTN_REVRCPBILLFROM.Click
        Try
            MAIN.txtForm.Text = "FrmReceiptReverse"

            FrmSearch.txtSearch.Text = "REV Receipt Number From"
            Call FrmSearch.SearchShow("BILLNO", "IDCUST", "Receipt No", "Customer Number", "NAMECUST", "Customer Name")
            'End If
        Catch ex As Exception
            WriteLog("ERROR 150 (BTN_REVRCPBILLFROM_Click)" & ex.Message)
        End Try
    End Sub
    Private Sub BTN_REVRCPBILLTO_Click(sender As Object, e As EventArgs) Handles BTN_REVRCPBILLTO.Click
        Try
            MAIN.txtForm.Text = "FrmReceiptReverse"

            FrmSearch.txtSearch.Text = "REV Receipt Number To"
            Call FrmSearch.SearchShow("BILLNO", "IDCUST", "Receipt No", "Customer Number", "NAMECUST", "Customer Name")
            'End If
        Catch ex As Exception
            WriteLog("ERROR 165 (BTN_REVRCPBILLTO_Click)" & ex.Message)
        End Try
    End Sub

    Private Sub FrmReceiptReverse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

        Catch ex As Exception
            WriteLog("ERROR 178 (FrmReceiptReverse_Load)" & ex.Message)
        End Try
    End Sub

    Private Sub BTNBill_REFRESH_Click(sender As Object, e As EventArgs) Handles BTNBill_REFRESH.Click
        Me.Close()
    End Sub


End Class