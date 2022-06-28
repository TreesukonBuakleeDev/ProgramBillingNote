Public Class FrmSearch
    Public dtSearch As DataTable = New DataTable()
    Private Sub FrmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            BTN_AutoSearch.Checked = True
            'Me.TopMost = True

        Catch ex As Exception
            WriteLog("ERROR 8 FrmSearch_Load() : " & ex.Message)
        End Try
    End Sub
    Private Sub BTN_SEARCH_Click(sender As Object, e As EventArgs) Handles BTN_SEARCH.Click
        'SearchData("", COMBO_FIELDS.Text)
        Try
            FILTERDATA()
        Catch ex As Exception
            WriteLog("ERROR 16 BTN_SEARCH_Click() : " & ex.Message)
        End Try
    End Sub

    Sub SearchShow(ByVal FIELD1 As String, ByVal FIELD2 As String, strField1 As String, strField2 As String, ByVal FIELD3 As String, ByVal strField3 As String)
        Try
            Me.Show(MAIN)
            COMBO_FIELDS.Items.Add(strField1)
            COMBO_FIELDS.Items.Add(strField2)
            If strField3 = "" Then
            Else
                COMBO_FIELDS.Items.Add(strField3)
            End If

            COMBO_CONDITION.Items.Add("Starts With")
            COMBO_CONDITION.Items.Add("Contains")
            COMBO_CONDITION.Text = "Contains"
            COMBO_FIELDS.Text = strField1
            BTN_SEARCH_Click(Nothing, Nothing)

        Catch ex As Exception
            WriteLog("ERROR 30 SearchShow() : " & ex.Message)
        End Try
    End Sub
    Sub BK_FILTERDATA()
        Try
            'Billing
            If COMBO_FIELDS.Text.StartsWith("Customer Number") = True Then
                SearchData("IDCUST", COMBO_FIELDS.Text)
            ElseIf COMBO_FIELDS.Text.StartsWith("Customer Name") = True Then
                SearchData("NAMECUST", COMBO_FIELDS.Text)
            ElseIf COMBO_FIELDS.Text.StartsWith("From_Billing Number") = True Then
                SearchDataBill("BILLNO", COMBO_FIELDS.Text, FrmReceipt.TXTRCP_IDCUST.Text)
            ElseIf COMBO_FIELDS.Text.StartsWith("To_Billing Number") = True Then
                SearchDataBill("BILLNO", COMBO_FIELDS.Text, FrmReceipt.TXTRCP_IDCUST.Text)

            ElseIf COMBO_FIELDS.Text.StartsWith("Batch Billing Number") Then
                SearchDataBill("BILLNO", COMBO_FIELDS.Text, "zzzzzz")

            ElseIf COMBO_FIELDS.Text.StartsWith("Batch Billing Customer Number") Then
                SearchDataBill("IDCUST", COMBO_FIELDS.Text, "zzzzzz")
            ElseIf COMBO_FIELDS.Text.StartsWith("Batch Billing Customer Name") Then
                SearchDataBill("NAMECUST", COMBO_FIELDS.Text, "zzzzzz")

                'Batch Receipt

            ElseIf COMBO_FIELDS.Text.StartsWith("Batch Receipt Number") Then
                SearchDataRCP("RCPNO", COMBO_FIELDS.Text, "zzzzzz")
            ElseIf COMBO_FIELDS.Text.StartsWith("Batch RCP Customer Number") Then
                SearchDataRCP("IDCUST", COMBO_FIELDS.Text, "zzzzzz")
            ElseIf COMBO_FIELDS.Text.StartsWith("Batch RCP Customer Name") Then
                SearchDataRCP("NAMECUST", COMBO_FIELDS.Text, "zzzzzz")

                'Receipt

            ElseIf COMBO_FIELDS.Text.StartsWith("Billing Note Number") Then

                SearchDataRCPBill("BILLNO", COMBO_FIELDS.Text, FrmReceipt.TXTRCP_IDCUST.Text.TrimEnd)

            ElseIf COMBO_FIELDS.Text.StartsWith("To Billing Note Number") Then

                SearchDataRCPBill("BILLNO", COMBO_FIELDS.Text, FrmReceipt.TXTRCP_IDCUST.Text.TrimEnd)

            ElseIf COMBO_FIELDS.Text.StartsWith("Receipt Customer Number") Then
                SearchDataRCPBill("IDCUST", COMBO_FIELDS.Text, FrmReceipt.TXTRCP_IDCUST.Text.TrimEnd)

            ElseIf COMBO_FIELDS.Text.StartsWith("To Receipt Customer Number") Then
                SearchDataRCPBill("IDCUST", COMBO_FIELDS.Text, FrmReceipt.TXTRCP_IDCUST.Text.TrimEnd)

            ElseIf COMBO_FIELDS.Text.StartsWith("Receipt Customer Name") Then
                SearchDataRCPBill("TEXTSNAM", COMBO_FIELDS.Text, FrmReceipt.TXTRCP_IDCUST.Text.TrimEnd)

            ElseIf COMBO_FIELDS.Text.StartsWith("To Receipt Customer Name") Then
                SearchDataRCPBill("TEXTSNAM", COMBO_FIELDS.Text, FrmReceipt.TXTRCP_IDCUST.Text.TrimEnd)
                '>>
            ElseIf COMBO_FIELDS.Text.StartsWith("From Receipt Number") = True Then
                SearchDataRCP("RCPNO", COMBO_FIELDS.Text, FrmReceiptReverse.TXTREVRCP_BILLNOFrom.Text)
            ElseIf COMBO_FIELDS.Text.StartsWith("To Receipt Number") Then
                SearchDataRCP("RCPNO", COMBO_FIELDS.Text, FrmReceiptReverse.TXTREVRCP_BILLNOTo.Text)


                'Reverse Billing
            ElseIf COMBO_FIELDS.Text.StartsWith("Billling Number From") Then
                SearchDataBillREV("BILLNO", COMBO_FIELDS.Text, FrmBillingReverse.TXTREVBILL_IDCUST.Text)
            ElseIf COMBO_FIELDS.Text.StartsWith("Billing Customer Number") Then
                SearchDataBillREV("IDCUST", COMBO_FIELDS.Text, FrmBillingReverse.TXTREVBILL_IDCUST.Text)
            ElseIf COMBO_FIELDS.Text.StartsWith("Billing Customer Name") Then
                SearchDataBillREV("NAMECUST", COMBO_FIELDS.Text, FrmBillingReverse.TXTREVBILL_IDCUST.Text)

            ElseIf COMBO_FIELDS.Text.StartsWith("Billing Number To") Then
                SearchDataBillREV("BILLNO", COMBO_FIELDS.Text, FrmBillingReverse.TXTREVBILL_IDCUST.Text)
            ElseIf COMBO_FIELDS.Text.StartsWith("Billing Customer Number To") Then
                SearchDataBillREV("IDCUST", COMBO_FIELDS.Text, FrmBillingReverse.TXTREVBILL_IDCUST.Text)
            ElseIf COMBO_FIELDS.Text.StartsWith("Billing Customer Name To") Then
                SearchDataBillREV("NAMECUST", COMBO_FIELDS.Text, FrmBillingReverse.TXTREVBILL_IDCUST.Text)


                'Reverse RCP
            ElseIf COMBO_FIELDS.Text.StartsWith("Receipt Number From") Then
                SearchDataRCPREV("RCPNO", COMBO_FIELDS.Text, FrmReceiptReverse.TXTREVRCP_BILLNOFrom.Text)
            ElseIf COMBO_FIELDS.Text.StartsWith("Receipt Number To") Then
                SearchDataRCPREV("RCPNO", COMBO_FIELDS.Text, FrmReceiptReverse.TXTREVRCP_BILLNOTo.Text)

            ElseIf COMBO_FIELDS.Text.StartsWith("RCP Customer Number From") Then
                SearchDataRCPREV("IDCUST", COMBO_FIELDS.Text, FrmReceiptReverse.TXTREVRCP_BILLNOTo.Text)
            ElseIf COMBO_FIELDS.Text.StartsWith("Receipt Customer Name From") Then
                SearchDataRCPREV("NAMECUST", COMBO_FIELDS.Text, FrmReceiptReverse.TXTREVRCP_BILLNOTo.Text)

            ElseIf COMBO_FIELDS.Text.StartsWith("RCP Customer Number To") Then
                SearchDataRCPREV("IDCUST", COMBO_FIELDS.Text, FrmReceiptReverse.TXTREVRCP_BILLNOTo.Text)
            ElseIf COMBO_FIELDS.Text.StartsWith("Receipt Customer Name To") Then
                SearchDataRCPREV("NAMECUST", COMBO_FIELDS.Text, FrmReceiptReverse.TXTREVRCP_BILLNOTo.Text)


                'Report
            ElseIf COMBO_FIELDS.Text.StartsWith("To Report Customer Number") Then
                SearchData("IDCUST", COMBO_FIELDS.Text)
            ElseIf COMBO_FIELDS.Text.StartsWith("From Report Customer Number") Then
                SearchData("IDCUST", COMBO_FIELDS.Text)
            ElseIf COMBO_FIELDS.Text.StartsWith("To Report Customer Name") Then
                SearchData("NAMECUST", COMBO_FIELDS.Text)
            ElseIf COMBO_FIELDS.Text.StartsWith("From Report Customer Name") Then
                SearchData("NAMECUST", COMBO_FIELDS.Text)
                '------------------
            ElseIf COMBO_FIELDS.Text.StartsWith("From Report Billing Note Number") Then
                SearchDataBill("BILLNO", COMBO_FIELDS.Text, "zzzzzz")
            ElseIf COMBO_FIELDS.Text.StartsWith("To Report Billing Note Number") Then
                SearchDataBill("BILLNO", COMBO_FIELDS.Text, "zzzzzz")
            ElseIf COMBO_FIELDS.Text.StartsWith("From Report Billing Customer Number") Then
                SearchDataBill("IDCUST", COMBO_FIELDS.Text, "zzzzzz")
            ElseIf COMBO_FIELDS.Text.StartsWith("From Report Billing Customer Name") Then
                SearchDataBill("NAMECUST", COMBO_FIELDS.Text, "zzzzzz")
            ElseIf COMBO_FIELDS.Text.StartsWith("To Report Billing Customer Number") Then
                SearchDataBill("IDCUST", COMBO_FIELDS.Text, "zzzzzz")
            ElseIf COMBO_FIELDS.Text.StartsWith("To Report Billing Customer Name") Then
                SearchDataBill("NAMECUST", COMBO_FIELDS.Text, "zzzzzz")

                'rcp
            ElseIf COMBO_FIELDS.Text.StartsWith("From Report Receipt Number") Or COMBO_FIELDS.Text.StartsWith("To Report Receipt Number") Then
                SearchDataRCP("RCPNO", COMBO_FIELDS.Text, "zzzzzz")
            ElseIf COMBO_FIELDS.Text.StartsWith("From Report Receipt Customer Number") Or COMBO_FIELDS.Text.StartsWith("To Report Receipt Customer Number") Then
                SearchDataRCP("IDCUST", COMBO_FIELDS.Text, "zzzzzz")
            ElseIf COMBO_FIELDS.Text.StartsWith("From Report Receipt Customer Name") Or COMBO_FIELDS.Text.StartsWith("To Report Receipt Customer Name") Then
                SearchDataRCP("NAMECUST", COMBO_FIELDS.Text, "zzzzzz")




                'INV REPORT 
            ElseIf COMBO_FIELDS.Text.StartsWith("From Invoice Report Customer Number") Then
                SearchData("IDCUST", COMBO_FIELDS.Text)
            ElseIf COMBO_FIELDS.Text.StartsWith("To Invoice Report Customer Number") Then
                SearchData("IDCUST", COMBO_FIELDS.Text)
            ElseIf COMBO_FIELDS.Text.StartsWith("From Invoice Report Customer Name") Then
                SearchData("NAMECUST", COMBO_FIELDS.Text)
            ElseIf COMBO_FIELDS.Text.StartsWith("To Invoice Report Customer Name") Then
                SearchData("NAMECUST", COMBO_FIELDS.Text)


            ElseIf COMBO_FIELDS.Text.StartsWith("From Invoice Report Billing Note Number") Then
                SearchDataBill("BILLNO", COMBO_FIELDS.Text, "zzzzzz")
            ElseIf COMBO_FIELDS.Text.StartsWith("From Invoice Billing Report Customer Number") Then
                SearchDataBill("IDCUST", COMBO_FIELDS.Text, "zzzzzz")
            ElseIf COMBO_FIELDS.Text.StartsWith("From Invoice Billing Report Customer Name") Then
                SearchDataBill("NAMECUST", COMBO_FIELDS.Text, "zzzzzz")

            ElseIf COMBO_FIELDS.Text.StartsWith("To Invoice Report Billing Note Number") Then
                SearchDataBill("BILLNO", COMBO_FIELDS.Text, "zzzzzz")
            ElseIf COMBO_FIELDS.Text.StartsWith("To Invoice Report Bill Customer Number") Then
                SearchDataBill("IDCUST", COMBO_FIELDS.Text, "zzzzzz")
            ElseIf COMBO_FIELDS.Text.StartsWith("To Invoice Report Bill Customer Name") Then
                SearchDataBill("NAMECUST", COMBO_FIELDS.Text, "zzzzzz")

                'INV STATUS REPORT 
            ElseIf COMBO_FIELDS.Text.StartsWith("From Status Report Customer Number") Then
                SearchData("IDCUST", COMBO_FIELDS.Text)
            ElseIf COMBO_FIELDS.Text.StartsWith("To Status Report Customer Number") Then
                SearchData("IDCUST", COMBO_FIELDS.Text)
            ElseIf COMBO_FIELDS.Text.StartsWith("From Status Report Customer Name") Then
                SearchData("NAMECUST", COMBO_FIELDS.Text)
            ElseIf COMBO_FIELDS.Text.StartsWith("To Status Report Customer Name") Then
                SearchData("NAMECUST", COMBO_FIELDS.Text)


                ' 
            ElseIf COMBO_FIELDS.Text.StartsWith("From Invoice Report Receipt Number") Then
                SearchDataRCP("RCPNO", COMBO_FIELDS.Text, "zzzzzz")
            ElseIf COMBO_FIELDS.Text.StartsWith("To Invoice Report Receipt Number") Then
                SearchDataRCP("RCPNO", COMBO_FIELDS.Text, "zzzzzz")

            ElseIf COMBO_FIELDS.Text.StartsWith("From Invoice Report Receipt Customer Number") Then
                SearchDataRCP("IDCUST", COMBO_FIELDS.Text, "zzzzzz")
            ElseIf COMBO_FIELDS.Text.StartsWith("From Invoice Report Receipt Customer Name") Then
                SearchDataRCP("NAMECUST", COMBO_FIELDS.Text, "zzzzzz")

            ElseIf COMBO_FIELDS.Text.StartsWith("To Invoice Report Receipt Customer Number") Then
                SearchDataRCP("IDCUST", COMBO_FIELDS.Text, "zzzzzz")
            ElseIf COMBO_FIELDS.Text.StartsWith("To Invoice Report Receipt Customer Name") Then
                SearchDataRCP("NAMECUST", COMBO_FIELDS.Text, "zzzzzz")


            ElseIf COMBO_FIELDS.Text.StartsWith("From Invoice Report Customer Number") Then
                SearchDataRCP("IDCUST", COMBO_FIELDS.Text, "zzzzzz")
            ElseIf COMBO_FIELDS.Text.StartsWith("From Invoice Report Customer Name") Then
                SearchDataRCP("NAMECUST", COMBO_FIELDS.Text, "zzzzzz")

            ElseIf COMBO_FIELDS.Text.StartsWith("To Invoice Report Receipt Customer Number") Then
                SearchDataRCP("IDCUST", COMBO_FIELDS.Text, "zzzzzz")
            ElseIf COMBO_FIELDS.Text.StartsWith("To Invoice Report Receipt Customer Name") Then
                SearchDataRCP("NAMECUST", COMBO_FIELDS.Text, "zzzzzz")

            Else
                SearchData("", COMBO_FIELDS.Text)
            End If

            'Display 
            Call DisplayDGVSearch()

            'COMBO_FIELDS.IsReadOnly = True


        Catch ex As Exception
            WriteLog("Error 229 FILTERDATA() Then :  " & ex.Message)
        End Try
    End Sub

    Sub FILTERDATA()
        '----------BatchBillingNote---------------
        If txtSearch.Text.StartsWith("BatchBillingNote") = True Then
            If COMBO_FIELDS.Text.StartsWith("Billing Number") = True Then
                SearchDataBill("BILLNO", COMBO_FIELDS.Text, "zzzzzz")
            End If
            If COMBO_FIELDS.Text.StartsWith("Customer Number") = True Then
                SearchDataBill("IDCUST", COMBO_FIELDS.Text, "zzzzzz")
            End If
            If COMBO_FIELDS.Text.StartsWith("Customer Name") = True Then
                SearchDataBill("NAMECUST", COMBO_FIELDS.Text, "zzzzzz")
            End If
        End If
        '------------FrmBillingNote-----------------
        If txtSearch.Text.StartsWith("FrmBillingNote") = True Then
            If COMBO_FIELDS.Text.StartsWith("Customer Number") = True Then
                SearchData("IDCUST", COMBO_FIELDS.Text)
            End If
            If COMBO_FIELDS.Text.StartsWith("Customer Name") = True Then
                SearchData("NAMECUST", COMBO_FIELDS.Text)
            End If
        End If

        '------------FrmBillingReverse----------------
        If txtSearch.Text.StartsWith("FrmBillingReverse") = True Then
            If COMBO_FIELDS.Text.StartsWith("Customer Number") = True Then
                SearchData("IDCUST", COMBO_FIELDS.Text)
            End If
            If COMBO_FIELDS.Text.StartsWith("Customer Name") = True Then
                SearchData("NAMECUST", COMBO_FIELDS.Text)
            End If
        End If

        If txtSearch.Text.StartsWith("REV Billling Number From") = True Or txtSearch.Text.StartsWith("REV Billing Number To") = True Then
            SearchDataBillREV("BILLNO", COMBO_FIELDS.Text, FrmBillingReverse.TXTREVBILL_IDCUST.Text)
        End If

        '-----------BatchReceipt---------------------
        If txtSearch.Text.StartsWith("Batch Receipt Number") = True Then
            If COMBO_FIELDS.Text.StartsWith("Receipt No") Then
                SearchDataRCP("RCPNO", COMBO_FIELDS.Text, "zzzzzz")
            ElseIf COMBO_FIELDS.Text.StartsWith("Customer Number") Then
                SearchDataRCP("IDCUST", COMBO_FIELDS.Text, "zzzzzz")
            ElseIf COMBO_FIELDS.Text.StartsWith("Customer Name") Then
                SearchDataRCP("NAMECUST", COMBO_FIELDS.Text, "zzzzzz")
            End If
        End If

        '-----------FrmReceipt-----------------------
        If txtSearch.Text.StartsWith("RCP Billing Note Number") = True Or txtSearch.Text.StartsWith("RCP To Billing Note Number") = True Then
            If COMBO_FIELDS.Text.StartsWith("Billing Number") = True Then
                SearchDataRCPBill("BILLNO", COMBO_FIELDS.Text, FrmReceipt.TXTRCP_IDCUST.Text.TrimEnd)
            End If
            If COMBO_FIELDS.Text.StartsWith("Customer Number") = True Then
                SearchDataRCPBill("IDCUST", COMBO_FIELDS.Text, FrmReceipt.TXTRCP_IDCUST.Text.TrimEnd)
            End If
            If COMBO_FIELDS.Text.StartsWith("Customer Name") = True Then
                SearchDataRCPBill("TEXTSNAM", COMBO_FIELDS.Text, FrmReceipt.TXTRCP_IDCUST.Text.TrimEnd)
            End If
        End If

        If txtSearch.Text.StartsWith("FrmReceiptCUST") = True Then
            If COMBO_FIELDS.Text.StartsWith("Customer Number") = True Then
                SearchData("IDCUST", COMBO_FIELDS.Text)
            End If
            If COMBO_FIELDS.Text.StartsWith("Customer Name") = True Then
                SearchData("TEXTSNAM", COMBO_FIELDS.Text)
            End If
        End If

        '------------FrmRevReceipt--------------------
        If txtSearch.Text.StartsWith("FrmReceiptReverse") = True Then
            If COMBO_FIELDS.Text.StartsWith("Customer Number") = True Then
                SearchData("IDCUST", COMBO_FIELDS.Text)
            End If
            If COMBO_FIELDS.Text.StartsWith("Customer Name") = True Then
                SearchData("NAMECUST", COMBO_FIELDS.Text)
            End If
        End If
        If txtSearch.Text.StartsWith("REV Receipt Number From") = True Or txtSearch.Text.StartsWith("REV Receipt Number To") = True Then

            If COMBO_FIELDS.Text.StartsWith("Receipt No") = True Then
                SearchDataRCPREV("RCPNO", COMBO_FIELDS.Text, FrmReceiptReverse.TXTREVRCP_IDCUST.Text)
            End If
            If COMBO_FIELDS.Text.StartsWith("Customer Number") = True Then
                SearchDataRCPREV("IDCUST", COMBO_FIELDS.Text, FrmReceiptReverse.TXTREVRCP_IDCUST.Text)
            End If

            If COMBO_FIELDS.Text.StartsWith("Customer Name") Then
                SearchDataRCPREV("NAMECUST", COMBO_FIELDS.Text, FrmReceiptReverse.TXTREVRCP_IDCUST.Text)
            End If


        End If

        '------------FrmPrintInvoice-------------------
        If txtSearch.Text.StartsWith("From Invoice Report Customer Number") = True Or txtSearch.Text.StartsWith("To Invoice Report Customer Number") = True Then
            If COMBO_FIELDS.Text.StartsWith("Customer Number") Then
                SearchData("IDCUST", COMBO_FIELDS.Text)
            End If
            If COMBO_FIELDS.Text.StartsWith("Customer Name") Then
                SearchData("NAMECUST", COMBO_FIELDS.Text)
            End If
        End If

        'Bill
        If txtSearch.Text.StartsWith("From Invoice Report Billing Note Number") = True Or txtSearch.Text.StartsWith("To Invoice Report Billing Note Number") = True Then
            If COMBO_FIELDS.Text.StartsWith("Billing Number") Then
                SearchDataBill("BILLNO", COMBO_FIELDS.Text, "zzzzzz")
            ElseIf COMBO_FIELDS.Text.StartsWith("Customer Number") Then
                SearchDataBill("IDCUST", COMBO_FIELDS.Text, "zzzzzz")
            ElseIf COMBO_FIELDS.Text.StartsWith("Customer Name") Then
                SearchDataBill("NAMECUST", COMBO_FIELDS.Text, "zzzzzz")
            End If
        End If


        'RCP
        If txtSearch.Text.StartsWith("From Invoice Report Receipt Number") = True Or txtSearch.Text.StartsWith("To Invoice Report Receipt Number") = True Then
            If COMBO_FIELDS.Text.StartsWith("Receipt No") Then
                SearchDataRCP("RCPNO", COMBO_FIELDS.Text, "zzzzzz")
            ElseIf COMBO_FIELDS.Text.StartsWith("Customer Number") Then
                SearchDataRCP("IDCUST", COMBO_FIELDS.Text, "zzzzzz")
            ElseIf COMBO_FIELDS.Text.StartsWith("Customer Name") Then
                SearchDataRCP("NAMECUST", COMBO_FIELDS.Text, "zzzzzz")
            End If
        End If

        '----------FrmPrintBillSummary---------------------

        If txtSearch.Text.StartsWith("From Report Customer Number") = True Or txtSearch.Text.StartsWith("To Report Customer Number") = True Then
            If COMBO_FIELDS.Text.StartsWith("Customer Number") Then
                SearchData("IDCUST", COMBO_FIELDS.Text)
            End If
            If COMBO_FIELDS.Text.StartsWith("Customer Name") Then
                SearchData("NAMECUST", COMBO_FIELDS.Text)
            End If
        End If
        'Bill
        If txtSearch.Text.StartsWith("From Report Billing Note Number") = True Or txtSearch.Text.StartsWith("To Report Billing Note Number") = True Then
            If COMBO_FIELDS.Text.StartsWith("Billing Number") Then
                SearchDataBill("BILLNO", COMBO_FIELDS.Text, "zzzzzz")
            ElseIf COMBO_FIELDS.Text.StartsWith("Customer Number") Then
                SearchDataBill("IDCUST", COMBO_FIELDS.Text, "zzzzzz")
            ElseIf COMBO_FIELDS.Text.StartsWith("Customer Name") Then
                SearchDataBill("NAMECUST", COMBO_FIELDS.Text, "zzzzzz")
            End If
        End If

        'RCP
        If txtSearch.Text.StartsWith("From Report Receipt Number") = True Or txtSearch.Text.StartsWith("To Report Receipt Number") = True Then
            If COMBO_FIELDS.Text.StartsWith("Receipt No") Then
                SearchDataRCP("RCPNO", COMBO_FIELDS.Text, "zzzzzz")
            ElseIf COMBO_FIELDS.Text.StartsWith("Customer Number") Then
                SearchDataRCP("IDCUST", COMBO_FIELDS.Text, "zzzzzz")
            ElseIf COMBO_FIELDS.Text.StartsWith("Customer Name") Then
                SearchDataRCP("NAMECUST", COMBO_FIELDS.Text, "zzzzzz")
            End If
        End If

        '--------FrmPrintBillSTATUS------------------------
        If txtSearch.Text.StartsWith("From Status Report Customer Number") = True Or txtSearch.Text.StartsWith("To Status Report Customer Number") = True Then
            If COMBO_FIELDS.Text.StartsWith("Customer Number") Then
                SearchData("IDCUST", COMBO_FIELDS.Text)
            End If
            If COMBO_FIELDS.Text.StartsWith("Customer Name") Then
                SearchData("NAMECUST", COMBO_FIELDS.Text)
            End If
        End If

    End Sub

    Sub DisplayDGVSearch()
        Try
            'If COMBO_FIELDS.Text.StartsWith("Batch Billing No") Or COMBO_FIELDS.Text.StartsWith("Batch Billing Customer Number") Or COMBO_FIELDS.Text.StartsWith("Batch Billing Customer Name") Then
            If txtSearch.Text = "BatchBillingNote" Then
                With DGV_CUSTSEARCH
                    .RowHeadersVisible = False
                    .Columns(0).HeaderCell.Value = "Billing Number"
                    .Columns(1).HeaderCell.Value = "Customer Number"
                    .Columns(2).HeaderCell.Value = "Customer Name"
                End With
            End If

            If COMBO_FIELDS.Text.StartsWith("Batch Receipt Number") Or COMBO_FIELDS.Text.StartsWith("Batch RCP Customer Number") Or COMBO_FIELDS.Text.StartsWith("Batch RCP Customer Name") Then
                With DGV_CUSTSEARCH
                    .RowHeadersVisible = False
                    .Columns(0).HeaderCell.Value = "Batch Receipt Number"
                    .Columns(1).HeaderCell.Value = "Batch RCP Customer Number"
                    .Columns(2).HeaderCell.Value = "Batch RCP Customer Name"
                End With
            End If


            If COMBO_FIELDS.Text.StartsWith("Billing Note Number") Or COMBO_FIELDS.Text.StartsWith("Receipt Customer Number") Or COMBO_FIELDS.Text.StartsWith("Receipt Customer Name") Then
                With DGV_CUSTSEARCH
                    .RowHeadersVisible = False
                    .Columns(0).HeaderCell.Value = "Billing Note Number"
                    .Columns(1).HeaderCell.Value = "Receipt Customer Number"
                    .Columns(2).HeaderCell.Value = "Receipt Customer Name"
                End With
            End If

            If COMBO_FIELDS.Text.StartsWith("To Billing Note Number") Or COMBO_FIELDS.Text.StartsWith("To Receipt Customer Number") Or COMBO_FIELDS.Text.StartsWith("To Receipt Customer Name") Then
                With DGV_CUSTSEARCH
                    .RowHeadersVisible = False
                    .Columns(0).HeaderCell.Value = "To Billing Note Number"
                    .Columns(1).HeaderCell.Value = "To Receipt Customer Number"
                    .Columns(2).HeaderCell.Value = "To Receipt Customer Name"
                End With
            End If

            If COMBO_FIELDS.Text.StartsWith("Billling Number From") Or COMBO_FIELDS.Text.StartsWith("Billing Customer Number") Or COMBO_FIELDS.Text.StartsWith("Billing Customer Name") Then
                With DGV_CUSTSEARCH
                    .RowHeadersVisible = False
                    .Columns(0).HeaderCell.Value = "Billling Number From"
                    .Columns(1).HeaderCell.Value = "Billing Customer Number"
                    .Columns(2).HeaderCell.Value = "Billing Customer Name"
                End With
            End If

            If COMBO_FIELDS.Text.StartsWith("Billing Number To") Or COMBO_FIELDS.Text.StartsWith("Billing Customer Number To") Or COMBO_FIELDS.Text.StartsWith("Billing Customer Name To") Then
                With DGV_CUSTSEARCH
                    .RowHeadersVisible = False
                    .Columns(0).HeaderCell.Value = "Billing Number To"
                    .Columns(1).HeaderCell.Value = "Billing Customer Number To"
                    .Columns(2).HeaderCell.Value = "Billing Customer Name To"
                End With
            End If

            If COMBO_FIELDS.Text.StartsWith("Receipt Number From") Or COMBO_FIELDS.Text.StartsWith("RCP Customer Number From") Or COMBO_FIELDS.Text.StartsWith("Receipt Customer Name From") Then
                With DGV_CUSTSEARCH
                    .RowHeadersVisible = False
                    .Columns(0).HeaderCell.Value = "Receipt Number From"
                    .Columns(1).HeaderCell.Value = "RCP Customer Number From"
                    .Columns(2).HeaderCell.Value = "Receipt Customer Name From"
                End With
            End If

            If COMBO_FIELDS.Text.StartsWith("Receipt Number To") Or COMBO_FIELDS.Text.StartsWith("RCP Customer Number To") Or COMBO_FIELDS.Text.StartsWith("Receipt Customer Name To") Then
                With DGV_CUSTSEARCH
                    .RowHeadersVisible = False
                    .Columns(0).HeaderCell.Value = "Receipt Number To"
                    .Columns(1).HeaderCell.Value = "RCP Customer Number To"
                    .Columns(2).HeaderCell.Value = "Receipt Customer Name To"
                End With
            End If

            If COMBO_FIELDS.Text.StartsWith("From Report Billing Note Number") Or COMBO_FIELDS.Text.StartsWith("From Report Billing Customer Number") Or COMBO_FIELDS.Text.StartsWith("From Report Billing Customer Name") Then
                With DGV_CUSTSEARCH
                    .RowHeadersVisible = False
                    .Columns(0).HeaderCell.Value = "From Report Billing Note Number"
                    .Columns(1).HeaderCell.Value = "From Report Billing Customer Number"
                    .Columns(2).HeaderCell.Value = "From Report Billing Customer Name"
                End With
            End If

            If COMBO_FIELDS.Text.StartsWith("To Report Billing Note Number") Or COMBO_FIELDS.Text.StartsWith("To Report Billing Customer Number") Or COMBO_FIELDS.Text.StartsWith("To Report Billing Customer Name") Then
                With DGV_CUSTSEARCH
                    .RowHeadersVisible = False
                    .Columns(0).HeaderCell.Value = "To Report Billing Note Number"
                    .Columns(1).HeaderCell.Value = "To Report Billing Customer Numbe"
                    .Columns(2).HeaderCell.Value = "To Report Billing Customer Name"
                End With
            End If
            '-----------FrmPrintInvoice--------------------------------------------------------------------------------------
            If txtSearch.Text.StartsWith("From Invoice Report Customer Number") = True Then
                If COMBO_FIELDS.Text.StartsWith("Customer Number") Or COMBO_FIELDS.Text.StartsWith("Customer Name") Then
                    With DGV_CUSTSEARCH
                        .RowHeadersVisible = False
                        .Columns(0).HeaderCell.Value = "Customer Number"
                        .Columns(1).HeaderCell.Value = "Customer Name"

                    End With
                End If
            End If
            If txtSearch.Text.StartsWith("To Invoice Report Customer Number") = True Then
                If COMBO_FIELDS.Text.StartsWith("Customer Number") Or COMBO_FIELDS.Text.StartsWith("Customer Name") Then
                    With DGV_CUSTSEARCH
                        .RowHeadersVisible = False
                        .Columns(0).HeaderCell.Value = "Customer Number"
                        .Columns(1).HeaderCell.Value = "Customer Name"
                    End With
                End If
            End If

            If COMBO_FIELDS.Text.StartsWith("From Invoice Report Billing Note Number") Or COMBO_FIELDS.Text.StartsWith("From Invoice Billing Report Customer Number") Or COMBO_FIELDS.Text.StartsWith("From Invoice Billing Report Customer Name") Then
                With DGV_CUSTSEARCH
                    .RowHeadersVisible = False
                    .Columns(0).HeaderCell.Value = "From Invoice Report Billing Note Number"
                    .Columns(1).HeaderCell.Value = "From Invoice Billing Report Customer Number"
                    .Columns(2).HeaderCell.Value = "From Invoice Billing Report Customer Name"
                End With
            End If

            If COMBO_FIELDS.Text.StartsWith("To Invoice Report Billing Note Number") Or COMBO_FIELDS.Text.StartsWith("To Invoice Report Bill Customer Number") Or COMBO_FIELDS.Text.StartsWith("To Invoice Report Bill Customer Name") Then
                With DGV_CUSTSEARCH
                    .RowHeadersVisible = False
                    .Columns(0).HeaderCell.Value = "To Invoice Report Billing Note Number"
                    .Columns(1).HeaderCell.Value = "To Invoice Report Bill Customer Number"
                    .Columns(2).HeaderCell.Value = "To Invoice Report Bill Customer Name"
                End With
            End If


            '---------FrmPrintSummary----------------------------------------------------------------------------------------

            If COMBO_FIELDS.Text.Contains("From Report Customer Number") Or COMBO_FIELDS.Text.Contains("From Report Customer Name") Then
                With DGV_CUSTSEARCH
                    .RowHeadersVisible = False
                    .Columns(0).HeaderCell.Value = "From Report Customer Number"
                    .Columns(1).HeaderCell.Value = "From Report Customer Name"

                End With
            End If

            If COMBO_FIELDS.Text.Contains("To Report Customer Number") Or COMBO_FIELDS.Text.Contains("To Report Customer Name") Then
                With DGV_CUSTSEARCH
                    .RowHeadersVisible = False
                    .Columns(0).HeaderCell.Value = "To Report Customer Number"
                    .Columns(1).HeaderCell.Value = "To Report Customer Name"

                End With
            End If

            If COMBO_FIELDS.Text.StartsWith("From Report Billing Note Number") Or COMBO_FIELDS.Text.StartsWith("From Report Billing Customer Number") Or COMBO_FIELDS.Text.StartsWith("From Report Billing Customer Name") Then
                With DGV_CUSTSEARCH
                    .RowHeadersVisible = False
                    .Columns(0).HeaderCell.Value = "From Report Billing Note Number"
                    .Columns(1).HeaderCell.Value = "From Report Billing Customer Number"
                    .Columns(2).HeaderCell.Value = "From Report Billing Customer Name"
                End With
            End If

            If COMBO_FIELDS.Text.StartsWith("To Report Billing Note Number") Or COMBO_FIELDS.Text.StartsWith("To Report Billing Customer Number") Or COMBO_FIELDS.Text.StartsWith("To Report Billing Customer Name") Then
                With DGV_CUSTSEARCH
                    .RowHeadersVisible = False
                    .Columns(0).HeaderCell.Value = "To Report Billing Note Number"
                    .Columns(1).HeaderCell.Value = "To Report Billing Customer Number"
                    .Columns(2).HeaderCell.Value = "To Report Billing Customer Name"
                End With
            End If

            If COMBO_FIELDS.Text.Contains("From Report Receipt Number") Or COMBO_FIELDS.Text.Contains("From Report Receipt Customer Number") Or COMBO_FIELDS.Text.Contains("From Report Receipt Customer Name") Then
                With DGV_CUSTSEARCH
                    .RowHeadersVisible = False
                    .Columns(0).HeaderCell.Value = "From Report Receipt Number"
                    .Columns(1).HeaderCell.Value = "From Report Receipt Customer Number"
                    .Columns(2).HeaderCell.Value = "From Report Receipt Customer Name"
                End With
            End If

            If COMBO_FIELDS.Text.Contains("To Report Receipt Number") Or COMBO_FIELDS.Text.Contains("To Report Receipt Customer Number") Or COMBO_FIELDS.Text.Contains("To Report Receipt Customer Name") Then
                With DGV_CUSTSEARCH
                    .RowHeadersVisible = False
                    .Columns(0).HeaderCell.Value = "To Report Receipt Number"
                    .Columns(1).HeaderCell.Value = "To Report Receipt Customer Number"
                    .Columns(2).HeaderCell.Value = "To Report Receipt Customer Name"
                End With
            End If

            '------FrmPrintBillStatusInv-------------------------------------------------------------------------------------------

            If COMBO_FIELDS.Text.StartsWith("From Status Report Customer Name") Or COMBO_FIELDS.Text.StartsWith("From Status Report Customer Number") Then
                With DGV_CUSTSEARCH
                    .RowHeadersVisible = False
                    .Columns(0).HeaderCell.Value = "From Status Report Customer Name"
                    .Columns(1).HeaderCell.Value = "From Status Report Customer Number"

                End With
            End If

            If COMBO_FIELDS.Text.StartsWith("To Status Report Customer Number") Or COMBO_FIELDS.Text.StartsWith("To Status Report Customer Name") Then
                With DGV_CUSTSEARCH
                    .RowHeadersVisible = False
                    .Columns(0).HeaderCell.Value = "To Status Report Customer Number"
                    .Columns(1).HeaderCell.Value = "To Status Report Customer Name"

                End With
            End If

            '-------------------------------------------------------------------------------------------------


        Catch ex As Exception
            WriteLog("Error 445 FILTERDATA() Then :  " & ex.Message)
        End Try
    End Sub

    Sub SearchData(ByVal FIELD As String, ByVal strField As String)
        Try
            dtSearch = Nothing
            'dtSearch.Rows.Clear()
            'dtSearch.Columns.Clear()

            Dim strGetReceipt As String
            strGetReceipt = "SELECT IDCUST AS [Customer Number],NAMECUST AS [Customer Name] FROM ARCUS " & Environment.NewLine

            If COMBO_FIELDS.Text = strField Or COMBO_FIELDS.Text = strField Then
                Select Case COMBO_CONDITION.Text
                    Case "Starts With"
                        strGetReceipt &= " WHERE " & FIELD & " LIKE '" & RTrim(TXTFILTER.Text) & "%'  AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "' ORDER BY [Customer Number] "
                    Case "Contains"
                        strGetReceipt &= " WHERE " & FIELD & " LIKE '%" & RTrim(TXTFILTER.Text) & "%'  AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "' ORDER BY [Customer Number] "
                    Case Else
                        If BTN_AutoSearch.Checked = True Then
                            strGetReceipt &= " WHERE " & FIELD & " LIKE '" & RTrim(TXTFILTER.Text) & "%'  AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "' ORDER BY [Customer Number] "
                        Else
                            strGetReceipt &= " WHERE " & FIELD & " LIKE '%" & RTrim(TXTFILTER.Text) & "%'  AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "' ORDER BY [Customer Number]"
                        End If
                End Select
            Else

            End If

            Try

                dtSearch = MASTER.GETDATA_SEARCH(strGetReceipt)
                DGV_CUSTSEARCH.DataSource = dtSearch
                DGV_CUSTSEARCH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                'DGV_CUSTSEARCH.Columns(0).Width = 200
                'DGV_CUSTSEARCH.Columns(1).Width = 500

            Catch ex As Exception
                WriteLog("ERROR 138 SearchData() : " & ex.Message)
            End Try
        Catch ex As Exception
            WriteLog("ERROR 142 SearchData() : " & ex.Message)
        End Try
    End Sub

    Sub SearchDataBill(ByVal FIELD As String, ByVal strField As String, ByVal strIDCUST As String)
        Try

            dtSearch = Nothing

            Dim strGetReceipt As String



            If strIDCUST = "zzzzzz" Then
                strGetReceipt = "SELECT DISTINCT  BILLNO AS [Billing Number] , FMSBILLHEAD.IDCUST AS [Customer Number] , NAMECUST AS [Customer Name] FROM FMSBILLHEAD LEFT OUTER JOIN FMSARCUSMASTER ON FMSBILLHEAD.IDCUST = FMSARCUSMASTER.IDCUST  WHERE FMSBILLHEAD.IDCUST = FMSBILLHEAD.IDCUST AND FMSBILLHEAD.AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "'" & Environment.NewLine
            Else
                strGetReceipt = "SELECT DISTINCT  BILLNO AS [Billing Number] , FMSBILLHEAD.IDCUST AS [Customer Number] , NAMECUST AS [Customer Name] FROM FMSBILLHEAD LEFT OUTER JOIN FMSARCUSMASTER ON FMSBILLHEAD.IDCUST = FMSARCUSMASTER.IDCUST  WHERE FMSBILLHEAD.IDCUST = '" & strIDCUST & "' AND FMSBILLHEAD.AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "'" & Environment.NewLine
            End If


            If COMBO_FIELDS.Text.ToUpper = strField.ToUpper Or COMBO_FIELDS.Text.ToUpper = strField.ToUpper Then

                'Select Case COMBO_CONDITION.Text
                '    Case "Starts With"
                '        strGetReceipt &= " AND FMSBILLHEAD." & FIELD & " LIKE '" & RTrim(TXTFILTER.Text) & "%' ORDER BY " & FIELD & ""
                '    Case "Contains"
                '        strGetReceipt &= " AND FMSBILLHEAD." & FIELD & " LIKE '%" & RTrim(TXTFILTER.Text) & "%' ORDER BY " & FIELD & ""
                '    Case Else
                '        If BTN_AutoSearch.Checked = True Then
                '            strGetReceipt &= " AND FMSBILLHEAD." & FIELD & " LIKE '" & RTrim(TXTFILTER.Text) & "%' ORDER BY " & FIELD & ""
                '        Else
                '            strGetReceipt &= " AND FMSBILLHEAD." & FIELD & " LIKE '%" & RTrim(TXTFILTER.Text) & "%' ORDER BY " & FIELD & ""
                '        End If
                'End Select
                If FIELD.Contains("NAME") = False Then
                    Select Case COMBO_CONDITION.Text
                        Case "Starts With"
                            strGetReceipt &= " AND FMSBILLHEAD." & FIELD & " LIKE '" & RTrim(TXTFILTER.Text) & "%' ORDER BY  [Billing Number] "
                        Case "Contains"
                            strGetReceipt &= " And FMSBILLHEAD." & FIELD & " Like '%" & RTrim(TXTFILTER.Text) & "%' ORDER BY  [Billing Number]"
                        Case Else
                            If BTN_AutoSearch.Checked = True Then
                                strGetReceipt &= " AND FMSBILLHEAD." & FIELD & " LIKE '" & RTrim(TXTFILTER.Text) & "%' ORDER BY [Billing Number]"
                            Else
                                strGetReceipt &= " AND FMSBILLHEAD." & FIELD & " LIKE '%" & RTrim(TXTFILTER.Text) & "%' ORDER BY  [Billing Number]"
                            End If
                    End Select
                Else

                    Select Case COMBO_CONDITION.Text
                        Case "Starts With"
                            strGetReceipt &= " AND NAMECUST  LIKE '" & RTrim(TXTFILTER.Text) & "%' ORDER BY  [Billing Number] "
                        Case "Contains"
                            strGetReceipt &= " And NAMECUST  LIKE '%" & RTrim(TXTFILTER.Text) & "%' ORDER BY  [Billing Number]"
                        Case Else
                            If BTN_AutoSearch.Checked = True Then
                                strGetReceipt &= " AND NAMECUST  LIKE '" & RTrim(TXTFILTER.Text) & "%' ORDER BY [Billing Number]"
                            Else
                                strGetReceipt &= " AND NAMECUST  LIKE '%" & RTrim(TXTFILTER.Text) & "%' ORDER BY  [Billing Number]"
                            End If
                    End Select
                End If
            Else

            End If

            Try

                dtSearch = MASTER.GETDATA_SEARCHRCP(strGetReceipt)
                DGV_CUSTSEARCH.DataSource = dtSearch
                DGV_CUSTSEARCH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                'DGV_CUSTSEARCH.Columns(0).Width = 200

            Catch ex As Exception
                WriteLog("ERROR 184 SearchDataBill() : " & ex.Message)
            End Try
        Catch ex As Exception
            WriteLog("ERROR 188 SearchDataBill() : " & ex.Message)
        End Try
    End Sub

    Sub SearchDataRCP(ByVal FIELD As String, ByVal strField As String, ByVal strIDCUST As String)
        Try
            dtSearch = Nothing
            Dim strGetReceipt As String
            If strIDCUST = "zzzzzz" Then
                strGetReceipt = "SELECT DISTINCT  RCPNO AS [Receipt No] ,FMSRCPHEAD.IDCUST AS [Customer Number] , NAMECUST AS [Customer Name] FROM FMSRCPHEAD LEFT OUTER JOIN FMSARCUSMASTER ON FMSRCPHEAD.IDCUST = FMSARCUSMASTER.IDCUST  WHERE FMSRCPHEAD.IDCUST = FMSRCPHEAD.IDCUST AND FMSRCPHEAD.AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "' " & Environment.NewLine
            Else
                strGetReceipt = "SELECT DISTINCT  RCPNO AS [Receipt No] ,FMSRCPHEAD.IDCUST AS [Customer Number] , NAMECUST AS [Customer Name] FROM FMSRCPHEAD LEFT OUTER JOIN FMSARCUSMASTER ON FMSRCPHEAD.IDCUST = FMSARCUSMASTER.IDCUST  WHERE FMSRCPHEAD.IDCUST = '" & strIDCUST & "' AND FMSRCPHEAD.AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "'" & Environment.NewLine
            End If


            If COMBO_FIELDS.Text.ToUpper = strField.ToUpper Or COMBO_FIELDS.Text.ToUpper = strField.ToUpper Then
                If FIELD.Contains("NAME") = True Then
                    Select Case COMBO_CONDITION.Text
                        Case "Starts With"
                            strGetReceipt &= " AND NAMECUST LIKE '" & RTrim(TXTFILTER.Text) & "%' ORDER BY [Receipt No] "
                        Case "Contains"
                            strGetReceipt &= " AND NAMECUST LIKE '%" & RTrim(TXTFILTER.Text) & "%' ORDER BY [Receipt No]"
                        Case Else
                            If BTN_AutoSearch.Checked = True Then
                                strGetReceipt &= " AND NAMECUST LIKE '" & RTrim(TXTFILTER.Text) & "%' ORDER BY [Receipt No] "
                            Else
                                strGetReceipt &= " AND NAMECUST LIKE '%" & RTrim(TXTFILTER.Text) & "%' ORDER BY  [Receipt No] "
                            End If
                    End Select

                Else
                    Select Case COMBO_CONDITION.Text
                        Case "Starts With"
                            strGetReceipt &= " AND FMSRCPHEAD." & FIELD & " LIKE '" & RTrim(TXTFILTER.Text) & "%' ORDER BY [Receipt No] "
                        Case "Contains"
                            strGetReceipt &= " AND FMSRCPHEAD." & FIELD & " LIKE '%" & RTrim(TXTFILTER.Text) & "%' ORDER BY [Receipt No]"
                        Case Else
                            If BTN_AutoSearch.Checked = True Then
                                strGetReceipt &= " AND FMSRCPHEAD." & FIELD & " LIKE '" & RTrim(TXTFILTER.Text) & "%' ORDER BY [Receipt No] "
                            Else
                                strGetReceipt &= " AND FMSRCPHEAD." & FIELD & " LIKE '%" & RTrim(TXTFILTER.Text) & "%' ORDER BY  [Receipt No] "
                            End If
                    End Select
                End If

            Else

            End If

            Try

                dtSearch = MASTER.GETDATA_SEARCHRCP(strGetReceipt)
                DGV_CUSTSEARCH.DataSource = dtSearch
                DGV_CUSTSEARCH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                'DGV_CUSTSEARCH.Columns(0).Width = 200

            Catch ex As Exception
                WriteLog("ERROR 229 SearchDataRCP() : " & ex.Message)
            End Try
        Catch ex As Exception
            WriteLog("ERROR 232 SearchDataRCP() : " & ex.Message)
        End Try
    End Sub

    Sub SearchDataBillREV(ByVal FIELD As String, ByVal strField As String, ByVal strIDCUST As String)
        Try

            dtSearch = Nothing

            Dim strGetReceipt As String
            If strIDCUST = "zzzzzz" Or strIDCUST.TrimEnd = "" Then
                strGetReceipt = "SELECT DISTINCT  BILLNO AS [Billing Number] , FMSBILLHEAD.IDCUST AS [Customer Number] , NAMECUST AS [Customer Name]  FROM FMSBILLHEAD LEFT OUTER JOIN FMSARCUSMASTER ON FMSBILLHEAD.IDCUST = FMSARCUSMASTER.IDCUST  WHERE FMSBILLHEAD.BILLNO NOT IN (SELECT BILLNO FROM FMSRCPDETAIL WHERE STA_0  IN (1,2)) AND FMSBILLHEAD.IDCUST = FMSBILLHEAD.IDCUST AND FMSBILLHEAD.AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "' AND STA_0 = 2 " & Environment.NewLine
            Else
                strGetReceipt = "SELECT DISTINCT  BILLNO AS [Billing Number] , FMSBILLHEAD.IDCUST AS [Customer Number]  , NAMECUST AS [Customer Name] FROM FMSBILLHEAD LEFT OUTER JOIN FMSARCUSMASTER ON FMSBILLHEAD.IDCUST = FMSARCUSMASTER.IDCUST  WHERE FMSBILLHEAD.BILLNO NOT IN (SELECT BILLNO FROM FMSRCPDETAIL WHERE STA_0  IN (1,2)) AND FMSBILLHEAD.IDCUST = '" & strIDCUST & "' AND FMSBILLHEAD.AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "' AND STA_0 = 2 " & Environment.NewLine
            End If


            If COMBO_FIELDS.Text.ToUpper = strField.ToUpper Or COMBO_FIELDS.Text.ToUpper = strField.ToUpper Then
                If FIELD.Contains("NAME") = True Then
                    Select Case COMBO_CONDITION.Text
                        Case "Starts With"
                            strGetReceipt &= " AND NAMECUST LIKE '" & RTrim(TXTFILTER.Text) & "%' ORDER BY [Billing Number] "
                        Case "Contains"
                            strGetReceipt &= " AND NAMECUST LIKE '%" & RTrim(TXTFILTER.Text) & "%' ORDER BY [Billing Number] "
                        Case Else
                            If BTN_AutoSearch.Checked = True Then
                                strGetReceipt &= " AND NAMECUST LIKE '" & RTrim(TXTFILTER.Text) & "%' ORDER BY [Billing Number] "
                            Else
                                strGetReceipt &= " AND NAMECUST LIKE '%" & RTrim(TXTFILTER.Text) & "%' ORDER BY [Billing Number] "
                            End If
                    End Select
                Else
                    Select Case COMBO_CONDITION.Text
                        Case "Starts With"
                            strGetReceipt &= " AND FMSBILLHEAD." & FIELD & " LIKE '" & RTrim(TXTFILTER.Text) & "%' ORDER BY [Billing Number] "
                        Case "Contains"
                            strGetReceipt &= " AND FMSBILLHEAD." & FIELD & " LIKE '%" & RTrim(TXTFILTER.Text) & "%' ORDER BY  [Billing Number]"
                        Case Else
                            If BTN_AutoSearch.Checked = True Then
                                strGetReceipt &= " AND FMSBILLHEAD." & FIELD & " LIKE '" & RTrim(TXTFILTER.Text) & "%' ORDER BY  [Billing Number]"
                            Else
                                strGetReceipt &= " AND FMSBILLHEAD." & FIELD & " LIKE '%" & RTrim(TXTFILTER.Text) & "%' ORDER BY [Billing Number] "
                            End If
                    End Select
                End If

            Else

            End If

            Try

                dtSearch = MASTER.GETDATA_SEARCHRCP(strGetReceipt)
                DGV_CUSTSEARCH.DataSource = dtSearch
                DGV_CUSTSEARCH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                'DGV_CUSTSEARCH.Columns(0).Width = 200

            Catch ex As Exception
                WriteLog("ERROR 275 SearchDataBillREV() : " & ex.Message)
            End Try
        Catch ex As Exception
            WriteLog("ERROR 278 SearchDataBillREV() : " & ex.Message)
        End Try
    End Sub

    Sub SearchDataRCPREV(ByVal FIELD As String, ByVal strField As String, ByVal strIDCUST As String)
        Try
            dtSearch = Nothing
            Dim strGetReceipt As String
            If strIDCUST = "zzzzzz" Or strIDCUST = "" Then
                strGetReceipt = "SELECT DISTINCT  RCPNO AS [Receipt No] ,FMSRCPHEAD.IDCUST AS [Customer Number] , NAMECUST AS [Customer Name] FROM FMSRCPHEAD LEFT OUTER JOIN FMSARCUSMASTER ON FMSRCPHEAD.IDCUST = FMSARCUSMASTER.IDCUST  WHERE FMSRCPHEAD.IDCUST = FMSRCPHEAD.IDCUST  AND STA_0 = 2 AND FMSRCPHEAD.AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "' " & Environment.NewLine
            Else
                strGetReceipt = "SELECT DISTINCT  RCPNO AS [Receipt No] ,FMSRCPHEAD.IDCUST AS [Customer Number] , NAMECUST AS [Customer Name] FROM FMSRCPHEAD LEFT OUTER JOIN FMSARCUSMASTER ON FMSRCPHEAD.IDCUST = FMSARCUSMASTER.IDCUST  WHERE FMSRCPHEAD.IDCUST = '" & strIDCUST & "' AND STA_0 = 2 AND FMSRCPHEAD.AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "' " & Environment.NewLine
            End If


            If COMBO_FIELDS.Text.ToUpper = strField.ToUpper Or COMBO_FIELDS.Text.ToUpper = strField.ToUpper Then
                If FIELD.Contains("NAME") = True Then
                    Select Case COMBO_CONDITION.Text
                        Case "Starts With"
                            strGetReceipt &= " AND NAMECUST LIKE '" & RTrim(TXTFILTER.Text) & "%' ORDER BY [Receipt No] "
                        Case "Contains"
                            strGetReceipt &= " AND NAMECUST LIKE '%" & RTrim(TXTFILTER.Text) & "%' ORDER BY [Receipt No] "
                        Case Else
                            If BTN_AutoSearch.Checked = True Then
                                strGetReceipt &= " AND NAMECUST LIKE '" & RTrim(TXTFILTER.Text) & "%' ORDER BY [Receipt No] "
                            Else
                                strGetReceipt &= " AND NAMECUST LIKE '%" & RTrim(TXTFILTER.Text) & "%' ORDER BY  [Receipt No]"
                            End If
                    End Select
                Else
                    Select Case COMBO_CONDITION.Text
                        Case "Starts With"
                            strGetReceipt &= " AND FMSRCHEAD." & FIELD & " LIKE '" & RTrim(TXTFILTER.Text) & "%' ORDER BY [Receipt No] "
                        Case "Contains"
                            strGetReceipt &= " AND FMSRCPHEAD." & FIELD & " LIKE '%" & RTrim(TXTFILTER.Text) & "%' ORDER BY [Receipt No] "
                        Case Else
                            If BTN_AutoSearch.Checked = True Then
                                strGetReceipt &= " AND FMSRCPHEAD." & FIELD & " LIKE '" & RTrim(TXTFILTER.Text) & "%' ORDER BY [Receipt No] "
                            Else
                                strGetReceipt &= " AND FMSRCPHEAD." & FIELD & " LIKE '%" & RTrim(TXTFILTER.Text) & "%' ORDER BY  [Receipt No]"
                            End If
                    End Select
                End If

            Else

            End If

            Try

                dtSearch = MASTER.GETDATA_SEARCHRCP(strGetReceipt)
                DGV_CUSTSEARCH.DataSource = dtSearch
                DGV_CUSTSEARCH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                'DGV_CUSTSEARCH.Columns(0).Width = 200

            Catch ex As Exception

            End Try
        Catch ex As Exception

        End Try
    End Sub


    Sub SearchDataRCPBill(ByVal FIELD As String, ByVal strField As String, ByVal strIDCUST As String)
        Try

            dtSearch = Nothing

            Dim strGetReceipt As String



            'If strIDCUST = "zzzzzz" Then
            '    strGetReceipt = "SELECT DISTINCT  BILLNO  FROM FMSBILLHEAD WHERE IDCUST = IDCUST AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "'" & Environment.NewLine
            'Else
            '    strGetReceipt = "SELECT DISTINCT  BILLNO  FROM FMSBILLHEAD WHERE IDCUST = '" & strIDCUST & "' AND AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "'" & Environment.NewLine
            'End If
            Dim strIDCUSTF As String = ""
            If strIDCUST.TrimEnd = "" Then
                strIDCUST = "ZZZZZZ"
                strIDCUSTF = ""
            Else
                strIDCUSTF = strIDCUST
            End If

            strGetReceipt = "SELECT DISTINCT  FMSBILLHEAD.BILLNO AS [Billing Note Number], FMSBILLHEAD.IDCUST AS [Customer Number], NAMECUST AS [Customer Name], FORMAT(FMSBILLHEAD.NETAMT,'N') AS [Amount]
                             FROM FMSBILLHEAD 
                             LEFT OUTER JOIN FMSRCPDETAIL ON  FMSBILLHEAD.IDCUST = FMSRCPDETAIL.IDCUST AND FMSRCPDETAIL.BILLNO = FMSBILLHEAD.BILLNO
                             LEFT OUTER JOIN FMSARCUSMASTER ON FMSBILLHEAD.IDCUST = FMSARCUSMASTER.IDCUST 
                             WHERE 
                              FMSBILLHEAD.STA_0 = 2 
                              --AND FMSRCPDETAIL.RCPNO IS NULL
                                --AND (FMSRCPDETAIL.AMTOUTSTAND <> 0 OR FMSRCPDETAIL.AMTOUTSTAND IS NULL)
                                --14/06/2022
                                and FMSBILLHEAD.BILLNO not in (select BILLNO from FMSRCPDETAIL where STA_0 = 2)
and FMSBILLHEAD.BILLNO not in (select  FMSRCPDETAIL.BILLNO
from FMSRCPDETAIL inner join FMSBILLHEAD on FMSRCPDETAIL.BILLNO = FMSBILLHEAD.BILLNO 
where FMSRCPDETAIL.STA_0 = 1 and FMSBILLHEAD.NETAMT - (select sum(FMSRCPDETAIL.NETAMT) from FMSRCPDETAIL where FMSRCPDETAIL.BILLNO = FMSBILLHEAD.BILLNO and FMSRCPDETAIL.STA_0 = 1   ) = 0
)

                             AND FMSBILLHEAD.AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "'
                             AND FMSBILLHEAD.IDCUST BETWEEN '" & strIDCUSTF & "' AND  '" & strIDCUST & "' 
                            "

            If COMBO_FIELDS.Text.ToUpper = strField.ToUpper Or COMBO_FIELDS.Text.ToUpper = strField.ToUpper Then
                If FIELD = "TEXTSNAM" Then
                    Select Case COMBO_CONDITION.Text
                        Case "Starts With"
                            strGetReceipt &= " AND  NAMECUST LIKE '" & RTrim(TXTFILTER.Text) & "%'  "
                        Case "Contains"
                            strGetReceipt &= " AND  NAMECUST  LIKE '%" & RTrim(TXTFILTER.Text) & "%' "
                        Case Else
                            If BTN_AutoSearch.Checked = True Then
                                strGetReceipt &= " AND  NAMECUST  LIKE '" & RTrim(TXTFILTER.Text) & "%' "
                            Else
                                strGetReceipt &= " AND  NAMECUST  LIKE '%" & RTrim(TXTFILTER.Text) & "%' "
                            End If
                    End Select
                Else
                    Select Case COMBO_CONDITION.Text
                        Case "Starts With"
                            strGetReceipt &= " AND  FMSBILLHEAD." & FIELD & " LIKE '" & RTrim(TXTFILTER.Text) & "%'  "
                        Case "Contains"
                            strGetReceipt &= " AND FMSBILLHEAD." & FIELD & " LIKE '%" & RTrim(TXTFILTER.Text) & "%' "
                        Case Else
                            If BTN_AutoSearch.Checked = True Then
                                strGetReceipt &= " AND FMSBILLHEAD." & FIELD & " LIKE '" & RTrim(TXTFILTER.Text) & "%' "
                            Else
                                strGetReceipt &= " AND FMSBILLHEAD." & FIELD & " LIKE '%" & RTrim(TXTFILTER.Text) & "%' "
                            End If
                    End Select
                End If
            Else

            End If

            strGetReceipt &= Environment.NewLine & " UNION 
							 SELECT DISTINCT  FMSBILLHEAD.BILLNO AS [Billing Note Number] , FMSBILLHEAD.IDCUST AS [Customer Number], NAMECUST AS [Customer Name], FORMAT(FMSBILLHEAD.NETAMT,'N') AS [Amount]
                             FROM FMSBILLHEAD 
                             LEFT OUTER JOIN FMSRCPDETAIL ON  FMSBILLHEAD.IDCUST = FMSRCPDETAIL.IDCUST 
                             LEFT OUTER JOIN FMSARCUSMASTER ON FMSBILLHEAD.IDCUST = FMSARCUSMASTER.IDCUST 
                             WHERE 
                              FMSBILLHEAD.STA_0 = 2 
                             AND FMSRCPDETAIL.STA_0 = 5
                                AND FMSRCPDETAIL.BILLNO not in (select BILLNO from FMSRCPDETAIL where STA_0 = 1 and FMSBILLHEAD.NETAMT - (select sum(FMSRCPDETAIL.NETAMT) from FMSRCPDETAIL where FMSRCPDETAIL.BILLNO = FMSBILLHEAD.BILLNO and FMSRCPDETAIL.STA_0 = 1   ) = 0)
                             AND FMSBILLHEAD.AUDTORG = '" & MAIN.txtDBSOURCE.Text.TrimEnd & "'
                             AND FMSBILLHEAD.IDCUST BETWEEN '" & strIDCUSTF & "' AND  '" & strIDCUST & "' " & Environment.NewLine

            If COMBO_FIELDS.Text.ToUpper = strField.ToUpper Or COMBO_FIELDS.Text.ToUpper = strField.ToUpper Then

                'Select Case COMBO_CONDITION.Text
                '    Case "Starts With"
                '        strGetReceipt &= " AND  FMSBILLHEAD." & FIELD & " LIKE '" & RTrim(TXTFILTER.Text) & "%' ORDER BY  " & FIELD & ""
                '    Case "Contains"
                '        strGetReceipt &= " AND FMSBILLHEAD." & FIELD & " LIKE '%" & RTrim(TXTFILTER.Text) & "%' ORDER BY " & FIELD & ""
                '    Case Else
                '        If BTN_AutoSearch.Checked = True Then
                '            strGetReceipt &= " AND FMSBILLHEAD." & FIELD & " LIKE '" & RTrim(TXTFILTER.Text) & "%' ORDER BY " & FIELD & ""
                '        Else
                '            strGetReceipt &= " AND FMSBILLHEAD." & FIELD & " LIKE '%" & RTrim(TXTFILTER.Text) & "%' ORDER BY " & FIELD & ""
                '        End If
                'End Select
                If FIELD = "TEXTSNAM" Then
                    Select Case COMBO_CONDITION.Text
                        Case "Starts With"
                            strGetReceipt &= " AND  NAMECUST LIKE '" & RTrim(TXTFILTER.Text) & "%' ORDER BY  [Billing Note Number]"
                        Case "Contains"
                            strGetReceipt &= " AND NAMECUST LIKE '%" & RTrim(TXTFILTER.Text) & "%' ORDER BY [Billing Note Number]"
                        Case Else
                            If BTN_AutoSearch.Checked = True Then
                                strGetReceipt &= " AND NAMECUST LIKE '" & RTrim(TXTFILTER.Text) & "%' ORDER BY [Billing Note Number]"
                            Else
                                strGetReceipt &= " AND NAMECUST LIKE '%" & RTrim(TXTFILTER.Text) & "%' ORDER BY [Billing Note Number]"
                            End If
                    End Select
                Else
                    Select Case COMBO_CONDITION.Text
                        Case "Starts With"
                            strGetReceipt &= " AND  FMSBILLHEAD." & FIELD & " LIKE '" & RTrim(TXTFILTER.Text) & "%' ORDER BY  [Billing Note Number]"
                        Case "Contains"
                            strGetReceipt &= " AND FMSBILLHEAD." & FIELD & " LIKE '%" & RTrim(TXTFILTER.Text) & "%' ORDER BY [Billing Note Number]"
                        Case Else
                            If BTN_AutoSearch.Checked = True Then
                                strGetReceipt &= " AND FMSBILLHEAD." & FIELD & " LIKE '" & RTrim(TXTFILTER.Text) & "%' ORDER BY [Billing Note Number]"
                            Else
                                strGetReceipt &= " AND FMSBILLHEAD." & FIELD & " LIKE '%" & RTrim(TXTFILTER.Text) & "%' ORDER BY [Billing Note Number]"
                            End If
                    End Select


                End If
            Else

            End If

            Try

                dtSearch = MASTER.GETDATA_SEARCHRCP(strGetReceipt)
                DGV_CUSTSEARCH.DataSource = dtSearch
                DGV_CUSTSEARCH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                'DGV_CUSTSEARCH.Columns(0).Width = 200
                WriteLog(strGetReceipt)
            Catch ex As Exception
                WriteLog("ERROR 184 SearchDataBill() : " & ex.Message)
            End Try
        Catch ex As Exception
            WriteLog("ERROR 188 SearchDataBill() : " & ex.Message)
        End Try
    End Sub

    Private Sub TXTFILTER_Click(sender As Object, e As EventArgs) Handles TXTFILTER.TextChanged
        Try
            If BTN_AutoSearch.Checked = True Then
                FILTERDATA()
            End If
        Catch ex As Exception
            WriteLog("ERROR 332 TXTFILTER_Click() : " & ex.Message)
        End Try
    End Sub

    Private Sub TXTFILTER_Click_1(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TXTFILTER.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                FILTERDATA()
            End If
        Catch ex As Exception
            WriteLog("ERROR 342 TXTFILTER_Click() : " & ex.Message)
        End Try
    End Sub

    Private Sub DGV_CUSTSEARCH_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_CUSTSEARCH.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.DGV_CUSTSEARCH.Rows(e.RowIndex)

                If MAIN.txtForm.Text.TrimEnd = "FrmBillingNote" Then

                    'If FrmBillingNote.WindowState = FormWindowState.Normal Or FrmBillingNote.WindowState = FormWindowState.Maximized Then
                    If COMBO_FIELDS.Text.Contains("Customer Name") Or COMBO_FIELDS.Text.Contains("Customer Number") Then
                        FrmBillingNote.TXTBILL_IDCUST.Text = row.Cells(0).Value.ToString
                        FrmBillingNote.txtNAMECUST.Text = row.Cells(1).Value.ToString
                    End If
                End If

                If MAIN.txtForm.Text.TrimEnd = "FrmReceipt" Then
                    'If FrmReceipt.WindowState = FormWindowState.Normal Or FrmReceipt.WindowState = FormWindowState.Maximized Then
                    If COMBO_FIELDS.Text.Contains("Customer Name") Or COMBO_FIELDS.Text.Contains("Customer Number") Then
                        FrmReceipt.TXTRCP_IDCUST.Text = row.Cells(0).Value.ToString
                        FrmReceipt.txtNAMECUST.Text = row.Cells(1).Value.ToString
                    End If
                End If

                If MAIN.txtForm.Text.TrimEnd = "FrmReceiptReverse" Then

                    'If FrmReceiptReverse.WindowState = FormWindowState.Normal Or FrmReceiptReverse.WindowState = FormWindowState.Maximized Then
                    If COMBO_FIELDS.Text.Contains("Customer Name") Or COMBO_FIELDS.Text.Contains("Customer Number") Then
                        FrmReceiptReverse.TXTREVRCP_IDCUST.Text = row.Cells(0).Value.ToString
                        FrmReceiptReverse.TXTREVRCP_NAMECUST.Text = row.Cells(1).Value.ToString
                    End If
                End If

                If MAIN.txtForm.Text.TrimEnd = "FrmBillingReverse" Then
                    ' If FrmBillingReverse.WindowState = FormWindowState.Normal Or FrmBillingReverse.WindowState = FormWindowState.Maximized Then
                    If COMBO_FIELDS.Text.StartsWith("Customer Name") Or COMBO_FIELDS.Text.Contains("Customer Number") Then
                        FrmBillingReverse.TXTREVBILL_IDCUST.Text = row.Cells(0).Value.ToString
                        FrmBillingReverse.TXTREVBILL__NAMECUST.Text = row.Cells(1).Value.ToString
                    End If
                End If

                If MAIN.txtForm.Text.TrimEnd = "FrmBillingReverse" Then
                    '  If FrmBillingReverse.WindowState = FormWindowState.Normal Or FrmBillingReverse.WindowState = FormWindowState.Maximized Then
                    If txtSearch.Text = "Billling Number From" Then
                        If COMBO_FIELDS.Text.StartsWith("Billing Number") Then
                            FrmBillingReverse.TXTREVBILL_BILLNOFrom.Text = row.Cells(0).Value.ToString
                            FrmBillingReverse.TXTREVBILL_IDCUST.Text = row.Cells(1).Value.ToString
                            FrmBillingReverse.TXTREVBILL__NAMECUST.Text = row.Cells(2).Value.ToString
                        Else
                            'ElseIf COMBO_FIELDS.Text.StartsWith("Billing No") Then
                            FrmBillingReverse.TXTREVBILL_BILLNOTo.Text = row.Cells(0).Value.ToString
                            FrmBillingReverse.TXTREVBILL_IDCUST.Text = row.Cells(1).Value.ToString
                            FrmBillingReverse.TXTREVBILL__NAMECUST.Text = row.Cells(2).Value.ToString
                        End If
                    End If
                End If

                If MAIN.txtForm.Text.TrimEnd = "FrmBillingReverse" Then
                    '  If FrmBillingReverse.WindowState = FormWindowState.Normal Or FrmBillingReverse.WindowState = FormWindowState.Maximized Then
                    If txtSearch.Text.StartsWith("REV Billling Number From") = True Then
                        If COMBO_FIELDS.Text.Contains("Billing Number") Or COMBO_FIELDS.Text.Contains("Customer Number") Or COMBO_FIELDS.Text.Contains("Customer Name") Then
                            FrmBillingReverse.TXTREVBILL_BILLNOFrom.Text = row.Cells(0).Value.ToString
                            FrmBillingReverse.TXTREVBILL_IDCUST.Text = row.Cells(1).Value.ToString
                            FrmBillingReverse.TXTREVBILL__NAMECUST.Text = row.Cells(2).Value.ToString
                        End If
                    End If
                    If txtSearch.Text.StartsWith("REV Billing Number To") = True Then
                        If COMBO_FIELDS.Text.Contains("Billing Number") Or COMBO_FIELDS.Text.Contains("Customer Number") Or COMBO_FIELDS.Text.Contains("Customer Name") Then
                            FrmBillingReverse.TXTREVBILL_BILLNOTo.Text = row.Cells(0).Value.ToString
                            FrmBillingReverse.TXTREVBILL_IDCUST.Text = row.Cells(1).Value.ToString
                            FrmBillingReverse.TXTREVBILL__NAMECUST.Text = row.Cells(2).Value.ToString
                        End If
                    End If
                End If

                If MAIN.txtForm.Text.TrimEnd = "FrmReceipt" Then
                    'If FrmReceipt.WindowState = FormWindowState.Normal Or FrmReceipt.WindowState = FormWindowState.Maximized Then
                    If txtSearch.Text.StartsWith("RCP Billing Note Number") = True Then
                        If COMBO_FIELDS.Text.Contains("Billing Number") = True Then
                            FrmReceipt.TXTRCP_BILLNOFrom.Text = row.Cells(0).Value.ToString
                            FrmReceipt.TXTRCP_IDCUST.Text = row.Cells(1).Value.ToString
                            FrmReceipt.txtNAMECUST.Text = row.Cells(2).Value.ToString
                        End If
                        If COMBO_FIELDS.Text.Contains("Customer Number") = True Or COMBO_FIELDS.Text.Contains("Customer Name") = True Then
                            FrmReceipt.TXTRCP_BILLNOFrom.Text = row.Cells(0).Value.ToString
                            FrmReceipt.TXTRCP_IDCUST.Text = row.Cells(1).Value.ToString
                            FrmReceipt.txtNAMECUST.Text = row.Cells(2).Value.ToString

                        End If
                    End If

                    If txtSearch.Text.StartsWith("RCP To Billing Note Number") = True Then
                        If COMBO_FIELDS.Text.Contains("Billing Number") = True Then
                            FrmReceipt.TXTRCP_BILLNOTo.Text = row.Cells(0).Value.ToString
                            FrmReceipt.TXTRCP_IDCUST.Text = row.Cells(1).Value.ToString
                            FrmReceipt.txtNAMECUST.Text = row.Cells(2).Value.ToString
                        End If
                        If COMBO_FIELDS.Text.Contains("Customer Number") = True Or COMBO_FIELDS.Text.Contains("Customer Name") = True Then
                            FrmReceipt.TXTRCP_BILLNOTo.Text = row.Cells(0).Value.ToString
                            FrmReceipt.TXTRCP_IDCUST.Text = row.Cells(1).Value.ToString
                            FrmReceipt.txtNAMECUST.Text = row.Cells(2).Value.ToString

                        End If
                    End If

                    If txtSearch.Text.StartsWith("FrmReceiptCUST") = True Then
                        If COMBO_FIELDS.Text.Contains("Customer Number") = True Or COMBO_FIELDS.Text.Contains("Customer Name") = True Then

                            FrmReceipt.TXTRCP_IDCUST.Text = row.Cells(0).Value.ToString
                            FrmReceipt.txtNAMECUST.Text = row.Cells(1).Value.ToString

                        End If
                    End If

                End If

                If MAIN.txtForm.Text.TrimEnd = "FrmReceiptReverse" Then
                    ' If FrmReceiptReverse.WindowState = FormWindowState.Normal Or FrmReceiptReverse.WindowState = FormWindowState.Maximized Then
                    If txtSearch.Text.StartsWith("FrmReceiptReverse") = True Then
                        If COMBO_FIELDS.Text.Contains("Customer Name") = True Or COMBO_FIELDS.Text.Contains("Customer Number") = True Then
                            FrmReceiptReverse.TXTREVRCP_IDCUST.Text = row.Cells(0).Value.ToString
                            FrmReceiptReverse.TXTREVRCP_NAMECUST.Text = row.Cells(1).Value.ToString

                        End If
                    End If
                End If

                If MAIN.txtForm.Text.TrimEnd = "FrmReceiptReverse" Then
                    If txtSearch.Text.StartsWith("REV Receipt Number From") = True Then
                        ' If FrmReceiptReverse.WindowState = FormWindowState.Normal Or FrmReceiptReverse.WindowState = FormWindowState.Maximized Then
                        If COMBO_FIELDS.Text.Contains("Receipt No") = True Or COMBO_FIELDS.Text.Contains("Customer Number") = True Or COMBO_FIELDS.Text.Contains("Customer Name") = True Then
                            FrmReceiptReverse.TXTREVRCP_BILLNOFrom.Text = row.Cells(0).Value.ToString
                            FrmReceiptReverse.TXTREVRCP_IDCUST.Text = row.Cells(1).Value.ToString
                            FrmReceiptReverse.TXTREVRCP_NAMECUST.Text = row.Cells(2).Value.ToString

                        End If
                    End If
                    If txtSearch.Text.StartsWith("REV Receipt Number To") = True Then
                        ' If FrmReceiptReverse.WindowState = FormWindowState.Normal Or FrmReceiptReverse.WindowState = FormWindowState.Maximized Then
                        If COMBO_FIELDS.Text.Contains("Receipt No") = True Or COMBO_FIELDS.Text.Contains("Customer Number") = True Or COMBO_FIELDS.Text.Contains("Customer Name") = True Then
                            FrmReceiptReverse.TXTREVRCP_BILLNOTo.Text = row.Cells(0).Value.ToString
                            FrmReceiptReverse.TXTREVRCP_IDCUST.Text = row.Cells(1).Value.ToString
                            FrmReceiptReverse.TXTREVRCP_NAMECUST.Text = row.Cells(2).Value.ToString

                        End If
                    End If
                End If


                '    If MAIN.txtForm.Text.TrimEnd = "FrmReceiptReverse" Then
                '    ' If FrmReceiptReverse.WindowState = FormWindowState.Normal Or FrmReceiptReverse.WindowState = FormWindowState.Maximized Then
                '    If txtSearch.Text.StartsWith("REV Receipt Number From") = True Then
                '        If COMBO_FIELDS.Text.Contains("RCP Customer Number From") Then
                '            FrmReceiptReverse.TXTREVRCP_BILLNOFrom.Text = row.Cells(0).Value.ToString
                '        ElseIf COMBO_FIELDS.Text.Contains("RCP Customer Number To") Then
                '            FrmReceiptReverse.TXTREVRCP_BILLNOTo.Text = row.Cells(0).Value.ToString
                '        End If
                '    End If
                'End If


                If MAIN.txtForm.Text.TrimEnd = "FrmPrintBillSummary" Then
                    '  If FrmPrintBillSummary.WindowState = FormWindowState.Normal Or FrmPrintBillSummary.WindowState = FormWindowState.Maximized Then
                    'If COMBO_FIELDS.Text.Contains("From Report Customer Number") Or COMBO_FIELDS.Text.Contains("From Report Customer Name") Then
                    '    FrmPrintBillSummary.txtReport_CUSTF.Text = row.Cells(0).Value.ToString
                    'End If
                    'If COMBO_FIELDS.Text.Contains("To Report Customer Number") Or COMBO_FIELDS.Text.Contains("To Report Customer Name") Then
                    '    FrmPrintBillSummary.txtReport_CUSTT.Text = row.Cells(0).Value.ToString
                    'End If

                    If txtSearch.Text.StartsWith("From Report Customer Number") = True Then
                        If COMBO_FIELDS.Text.StartsWith("Customer Number") Or COMBO_FIELDS.Text.Contains("Customer Name") Then
                            FrmPrintBillSummary.txtReport_CUSTF.Text = row.Cells(0).Value.ToString
                        End If

                    End If
                    If txtSearch.Text.StartsWith("To Report Customer Number") = True Then
                        If COMBO_FIELDS.Text.StartsWith("Customer Number") Or COMBO_FIELDS.Text.Contains("Customer Name") Then
                            FrmPrintBillSummary.txtReport_CUSTT.Text = row.Cells(0).Value.ToString
                        End If

                    End If

                    'BILL
                    If txtSearch.Text.StartsWith("From Report Billing Note Number") = True Then
                        If COMBO_FIELDS.Text.StartsWith("Billing Number") Then
                            FrmPrintBillSummary.txtReport_BILLNOF.Text = row.Cells(0).Value.ToString
                        End If
                        If COMBO_FIELDS.Text.StartsWith("Customer Number") Or COMBO_FIELDS.Text.Contains("Customer Name") Then
                            FrmPrintBillSummary.txtReport_BILLNOF.Text = row.Cells(0).Value.ToString
                        End If
                    End If

                    If txtSearch.Text.StartsWith("To Report Billing Note Number") = True Then
                        If COMBO_FIELDS.Text.StartsWith("Billing Number") Then
                            FrmPrintBillSummary.txtReport_BILLNOT.Text = row.Cells(0).Value.ToString
                        End If
                        If COMBO_FIELDS.Text.StartsWith("Customer Number") Or COMBO_FIELDS.Text.Contains("Customer Name") Then
                            FrmPrintBillSummary.txtReport_BILLNOT.Text = row.Cells(0).Value.ToString
                        End If
                    End If

                    'RCP
                    If txtSearch.Text.StartsWith("From Report Receipt Number") = True Then
                        If COMBO_FIELDS.Text.StartsWith("Receipt No") Then
                            FrmPrintBillSummary.txtReport_BILLNOF.Text = row.Cells(0).Value.ToString
                        End If
                        If COMBO_FIELDS.Text.StartsWith("Customer Number") Or COMBO_FIELDS.Text.Contains("Customer Name") Then
                            FrmPrintBillSummary.txtReport_BILLNOF.Text = row.Cells(0).Value.ToString
                        End If
                    End If

                    If txtSearch.Text.StartsWith("To Report Receipt Number") = True Then
                        If COMBO_FIELDS.Text.StartsWith("Receipt No") Then
                            FrmPrintBillSummary.txtReport_BILLNOT.Text = row.Cells(0).Value.ToString
                        End If
                        If COMBO_FIELDS.Text.StartsWith("Customer Number") Or COMBO_FIELDS.Text.Contains("Customer Name") Then
                            FrmPrintBillSummary.txtReport_BILLNOT.Text = row.Cells(0).Value.ToString
                        End If
                    End If

                    If COMBO_FIELDS.Text.StartsWith("From Report Billing Note Number") Then
                        FrmPrintBillSummary.txtReport_BILLNOF.Text = row.Cells(0).Value.ToString
                    End If
                    If COMBO_FIELDS.Text.StartsWith("To Report Billing Note Number") Then
                        FrmPrintBillSummary.txtReport_BILLNOT.Text = row.Cells(0).Value.ToString
                    End If

                    If COMBO_FIELDS.Text.StartsWith("From Report Billing Customer Number") Or COMBO_FIELDS.Text.StartsWith("From Report Billing Customer Name") Then
                        FrmPrintBillSummary.txtReport_BILLNOF.Text = row.Cells(0).Value.ToString
                    End If
                    If COMBO_FIELDS.Text.StartsWith("To Report Billing Customer Number") Or COMBO_FIELDS.Text.StartsWith("To Report Billing Customer Name") Then
                        FrmPrintBillSummary.txtReport_BILLNOT.Text = row.Cells(0).Value.ToString
                    End If

                    'rcp
                    If COMBO_FIELDS.Text.Contains("From Report Receipt Number") Or COMBO_FIELDS.Text.Contains("From Report Receipt Customer Number") Or COMBO_FIELDS.Text.Contains("From Report Receipt Customer Name") Then
                        FrmPrintBillSummary.txtReport_BILLNOF.Text = row.Cells(0).Value.ToString
                    End If

                    If COMBO_FIELDS.Text.Contains("To Report Receipt Number") Or COMBO_FIELDS.Text.Contains("To Report Receipt Customer Number") Or COMBO_FIELDS.Text.Contains("To Report Receipt Customer Name") Then
                        FrmPrintBillSummary.txtReport_BILLNOT.Text = row.Cells(0).Value.ToString
                    End If

                End If

                If MAIN.txtForm.Text.TrimEnd = "FrmPrintInvoice" Then
                    If txtSearch.Text.StartsWith("From Invoice Report Customer Number") = True Then
                        If COMBO_FIELDS.Text.StartsWith("Customer Number") Or COMBO_FIELDS.Text.Contains("Customer Name") Then
                            FrmPrintInvoice.txtReportINV_CUSTF.Text = row.Cells(0).Value.ToString
                        End If
                    End If

                    If txtSearch.Text.StartsWith("To Invoice Report Customer Number") = True Then
                        If COMBO_FIELDS.Text.StartsWith("Customer Number") Or COMBO_FIELDS.Text.Contains("Customer Name") Then
                            FrmPrintInvoice.txtReportINV_CUSTT.Text = row.Cells(0).Value.ToString
                        End If
                    End If

                    'Bill

                    If txtSearch.Text.StartsWith("From Invoice Report Billing Note Number") = True Then
                        If COMBO_FIELDS.Text.StartsWith("Billing Number") Then
                            FrmPrintInvoice.txtReportINV_BILLNOF.Text = row.Cells(0).Value.ToString
                        End If
                        If COMBO_FIELDS.Text.StartsWith("Customer Number") Or COMBO_FIELDS.Text.Contains("Customer Name") Then
                            FrmPrintInvoice.txtReportINV_BILLNOF.Text = row.Cells(0).Value.ToString
                        End If

                    End If

                    If txtSearch.Text.StartsWith("To Invoice Report Billing Note Number") = True Then
                        If COMBO_FIELDS.Text.StartsWith("Billing Number") Then
                            FrmPrintInvoice.txtReportINV_BILLNOT.Text = row.Cells(0).Value.ToString
                        End If
                        If COMBO_FIELDS.Text.StartsWith("Customer Number") Or COMBO_FIELDS.Text.Contains("Customer Name") Then
                            FrmPrintInvoice.txtReportINV_BILLNOT.Text = row.Cells(0).Value.ToString
                        End If

                    End If

                    'RCP
                    If txtSearch.Text.StartsWith("From Invoice Report Receipt Number") Then
                        If COMBO_FIELDS.Text.StartsWith("Receipt No") Then
                            FrmPrintInvoice.txtReportINV_BILLNOF.Text = row.Cells(0).Value.ToString
                        End If
                        If COMBO_FIELDS.Text.StartsWith("Customer Number") Or COMBO_FIELDS.Text.Contains("Customer Name") Then
                            FrmPrintInvoice.txtReportINV_BILLNOF.Text = row.Cells(0).Value.ToString
                        End If
                    End If

                    If txtSearch.Text.StartsWith("To Invoice Report Receipt Number") Then
                        If COMBO_FIELDS.Text.StartsWith("Receipt No") Then
                            FrmPrintInvoice.txtReportINV_BILLNOT.Text = row.Cells(0).Value.ToString
                        End If
                        If COMBO_FIELDS.Text.StartsWith("Customer Number") Or COMBO_FIELDS.Text.Contains("Customer Name") Then
                            FrmPrintInvoice.txtReportINV_BILLNOT.Text = row.Cells(0).Value.ToString
                        End If
                    End If


                End If

                If MAIN.txtForm.Text.TrimEnd = "FrmBatchReceipt" Then
                    '   If FrmBatchReceipt.WindowState = FormWindowState.Normal Or FrmBatchReceipt.WindowState = FormWindowState.Maximized Then

                    If COMBO_FIELDS.Text.Contains("Receipt No") Then
                        FrmBatchReceipt.txtBatchRCP_SEARCH.Text = row.Cells(0).Value.ToString
                    ElseIf COMBO_FIELDS.Text.Contains("Customer Number") Then
                        FrmBatchReceipt.txtBatchRCP_SEARCH.Text = row.Cells(0).Value.ToString
                    ElseIf COMBO_FIELDS.Text.Contains("Customer Name") Then
                        FrmBatchReceipt.txtBatchRCP_SEARCH.Text = row.Cells(0).Value.ToString
                    End If
                End If

                If MAIN.txtForm.Text.TrimEnd = "FrmBatchBillingNote" Then
                    '    If FrmBatchBillingNote.WindowState = FormWindowState.Normal Or FrmBatchBillingNote.WindowState = FormWindowState.Maximized Then
                    If COMBO_FIELDS.Text.Contains("Billing Number") Then
                        FrmBatchBillingNote.txtBatchBILL_SEARCH.Text = row.Cells(0).Value.ToString
                    ElseIf COMBO_FIELDS.Text.StartsWith("Customer Number") Then
                        FrmBatchBillingNote.txtBatchBILL_SEARCH.Text = row.Cells(0).Value.ToString
                    ElseIf COMBO_FIELDS.Text.StartsWith("Customer Name") Then
                        FrmBatchBillingNote.txtBatchBILL_SEARCH.Text = row.Cells(0).Value.ToString
                    End If
                End If


                If MAIN.txtForm.Text.TrimEnd = "FrmPrintBillSTATUSINV" Then
                    If txtSearch.Text.StartsWith("From Status Report Customer Number") = True Then

                        If COMBO_FIELDS.Text.StartsWith("Customer Number") Or COMBO_FIELDS.Text.Contains("Customer Name") Then
                            FrmPrintBillSTATUSINV.txtReportINV_CUSTF.Text = row.Cells(0).Value.ToString
                        End If
                    End If

                    If txtSearch.Text.StartsWith("To Status Report Customer Number") = True Then
                        If COMBO_FIELDS.Text.StartsWith("Customer Number") Or COMBO_FIELDS.Text.Contains("Customer Name") Then
                            FrmPrintBillSTATUSINV.txtReportINV_CUSTT.Text = row.Cells(0).Value.ToString
                        End If
                    End If
                End If

            End If
            Me.Close()
        Catch ex As Exception
            WriteLog("ERROR 1390 DGV_CUSTSEARCH_CellContentClick() : " & ex.Message)
        End Try
    End Sub


End Class