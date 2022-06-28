Public Class MAIN
    Private Sub MAIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Visible = False
            FrmOPEN.Show()
            Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        Catch ex As Exception
            WriteLog("Error 5 (MAIN_Load) : " & ex.Message)
        End Try
    End Sub

    Private Sub BTN_CLOSE_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub BTN_MAX_Click(sender As Object, e As EventArgs) Handles BTN_MAX.Click
        Try
            If Me.WindowState = 2 Then
                Me.WindowState = FormWindowState.Normal

            Else
                Me.WindowState = FormWindowState.Maximized
            End If
        Catch ex As Exception
            WriteLog("Error 5 (BTN_MAX_Click) : " & ex.Message)
        End Try
    End Sub

    Private Sub BTN_MIN_Click(sender As Object, e As EventArgs) Handles BTN_MIN.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub LISTMENU_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles LISTMENU.AfterSelect
        Try
            Select Case e.Node.Name
                Case "BILLINGNOTE"
                    ShowFrmBillingBatch()
                Case "REVBILLINGNOTE"
                    ShowFrmBillingNoteREVERSE()
                Case "REPORTBILL"
                    ShowFrmPrintINV("BILL")
                Case "REPORTSUMBILL"
                    ShowFrmPrintBillSummary("BILL")

                Case "REPORTSTATUSINV"
                    ShowFrmPrintBILLSTATUSINV()

                Case "RECEIVEBILL"
                    ShowFrmBatchReceipt()
                Case "REVRECEIVEBILL"
                    ShowFrmReceiptReverse()

                Case "REPORTRECEIPT"
                    ShowFrmPrintINV("RECEIPT")
                Case "REPORTSUMRECEIVE"
                    ShowFrmPrintBillSummary("RECEIPT")

                Case "SETDB"
                    ShowFrmDbSetup()
                Case "SETFORMAT"
                    ShowFrmRunning()
                Case "SETAUTHEN"
                    ShowFrmAuthor()
                Case "SETOPTFD"
                    ShowFrmOPTFD()
                Case "IMPORTCB"
                    ShowFrmIMPORTCB()
                Case "HELP"
                    ShowHelp()
                Case ""

                Case Else

            End Select

        Catch ex As Exception
            WriteLog("Error 77 (LISTMENU_AfterSelect) : " & ex.Message)
        End Try
        LISTMENU.SelectedNode = Nothing
    End Sub

    Private Sub MAIN_Move(sender As Object, e As EventArgs) Handles MyBase.Move
        If Me.WindowState = FormWindowState.Minimized Then
            For Each frm In Application.OpenForms
                Select Case frm.name
                    Case "FrmBatchBillingNote"
                        FrmBatchBillingNote.WindowState = FormWindowState.Minimized
                    Case "FrmBillingNote"
                        FrmBillingNote.WindowState = FormWindowState.Minimized
                    Case "FrmBillingReverse"
                        FrmBillingReverse.WindowState = FormWindowState.Minimized
                    Case "FrmAuthor"
                        FrmAuthor.WindowState = FormWindowState.Minimized
                    Case "FrmDbSetup"
                        FrmDbSetup.WindowState = FormWindowState.Minimized
                    Case "FrmIMPORTCB"
                        FrmIMPORTCB.WindowState = FormWindowState.Minimized
                    Case "FrmLOGINFMS"
                        FrmLOGINFMS.WindowState = FormWindowState.Minimized
                    Case "FrmOPTFD"
                        FrmOPTFD.WindowState = FormWindowState.Minimized
                    Case "FrmOPTFDVALUE"
                        FrmOPTFDVALUE.WindowState = FormWindowState.Minimized
                    Case "FrmRunning"
                        FrmRunning.WindowState = FormWindowState.Minimized
                    Case "FrmSearch"
                        FrmSearch.WindowState = FormWindowState.Minimized
                    Case "FrmShowError"
                        FrmShowError.WindowState = FormWindowState.Minimized
                    Case "FrmBatchReceipt"
                        FrmBatchReceipt.WindowState = FormWindowState.Minimized
                    Case "FrmReceipt"
                        FrmReceipt.WindowState = FormWindowState.Minimized
                    Case "FrmReceiptReverse"
                        FrmReceiptReverse.WindowState = FormWindowState.Minimized
                    Case "FrmPrintBill"
                        FrmPrintBill.WindowState = FormWindowState.Minimized
                    Case "FrmPrintBillSTATUSINV"
                        FrmPrintBillSTATUSINV.WindowState = FormWindowState.Minimized
                    Case "FrmPrintBillSummary"
                        FrmPrintBillSummary.WindowState = FormWindowState.Minimized
                    Case "FrmPrintInvoice"
                        FrmPrintInvoice.WindowState = FormWindowState.Minimized
                    Case "FrmPrintRCP"
                        FrmPrintRCP.WindowState = FormWindowState.Minimized
                    Case "FrmPromtPrint"
                        FrmPromtPrint.WindowState = FormWindowState.Minimized
                    Case "FrmOPEN"
                        FrmOPEN.WindowState = FormWindowState.Minimized

                End Select


            Next
        Else
            For Each frm In Application.OpenForms
                Select Case frm.name
                    Case "FrmBatchBillingNote"
                        FrmBatchBillingNote.WindowState = FormWindowState.Normal
                    Case "FrmBillingNote"
                        FrmBillingNote.WindowState = FormWindowState.Normal
                    Case "FrmBillingReverse"
                        FrmBillingReverse.WindowState = FormWindowState.Normal
                    Case "FrmAuthor"
                        FrmAuthor.WindowState = FormWindowState.Normal
                    Case "FrmDbSetup"
                        FrmDbSetup.WindowState = FormWindowState.Normal
                    Case "FrmIMPORTCB"
                        FrmIMPORTCB.WindowState = FormWindowState.Normal
                    Case "FrmLOGINFMS"
                        FrmLOGINFMS.WindowState = FormWindowState.Normal
                    Case "FrmOPTFD"
                        FrmOPTFD.WindowState = FormWindowState.Normal
                    Case "FrmOPTFDVALUE"
                        FrmOPTFDVALUE.WindowState = FormWindowState.Normal
                    Case "FrmRunning"
                        FrmRunning.WindowState = FormWindowState.Normal
                    Case "FrmSearch"
                        FrmSearch.WindowState = FormWindowState.Normal
                    Case "FrmShowError"
                        FrmShowError.WindowState = FormWindowState.Normal
                    Case "FrmBatchReceipt"
                        FrmBatchReceipt.WindowState = FormWindowState.Normal
                    Case "FrmReceipt"
                        FrmReceipt.WindowState = FormWindowState.Normal
                    Case "FrmReceiptReverse"
                        FrmReceiptReverse.WindowState = FormWindowState.Normal
                    Case "FrmPrintBill"
                        FrmPrintBill.WindowState = FormWindowState.Normal
                    Case "FrmPrintBillSTATUSINV"
                        FrmPrintBillSTATUSINV.WindowState = FormWindowState.Normal
                    Case "FrmPrintBillSummary"
                        FrmPrintBillSummary.WindowState = FormWindowState.Normal
                    Case "FrmPrintInvoice"
                        FrmPrintInvoice.WindowState = FormWindowState.Normal
                    Case "FrmPrintRCP"
                        FrmPrintRCP.WindowState = FormWindowState.Normal
                    Case "FrmPromtPrint"
                        FrmPromtPrint.WindowState = FormWindowState.Normal
                    Case "FrmOPEN"
                        FrmOPEN.WindowState = FormWindowState.Normal

                End Select


            Next
        End If
    End Sub


    'Private Sub MAIN_MinimumSizeChanged_1(sender As Object, e As EventArgs) Handles MyBase.MinimumSizeChanged
    '    For Each frm In Application.OpenForms
    '        'frm.Name
    '        Select Case frm.name
    '            Case "FrmBatchBillingNote"
    '                FrmBatchBillingNote.WindowState = FormWindowState.Minimized
    '            Case "FrmBillingNote"
    '                FrmBillingNote.WindowState = FormWindowState.Minimized
    '            Case "FrmBillingReverse"
    '                FrmBillingReverse.WindowState = FormWindowState.Minimized
    '            Case "FrmAuthor"
    '                FrmAuthor.WindowState = FormWindowState.Minimized
    '            Case "FrmDbSetup"
    '                FrmDbSetup.WindowState = FormWindowState.Minimized
    '            Case "FrmIMPORTCB"
    '                FrmIMPORTCB.WindowState = FormWindowState.Minimized
    '            Case "FrmLOGINFMS"
    '                FrmLOGINFMS.WindowState = FormWindowState.Minimized
    '            Case "FrmOPTFD"
    '                FrmOPTFD.WindowState = FormWindowState.Minimized
    '            Case "FrmOPTFDVALUE"
    '                FrmOPTFDVALUE.WindowState = FormWindowState.Minimized
    '            Case "FrmRunning"
    '                FrmRunning.WindowState = FormWindowState.Minimized
    '            Case "FrmSearch"
    '                FrmSearch.WindowState = FormWindowState.Minimized
    '            Case "FrmShowError"
    '                FrmShowError.WindowState = FormWindowState.Minimized
    '            Case "FrmBatchReceipt"
    '                FrmBatchReceipt.WindowState = FormWindowState.Minimized
    '            Case "FrmReceipt"
    '                FrmReceipt.WindowState = FormWindowState.Minimized
    '            Case "FrmReceiptReverse"
    '                FrmReceiptReverse.WindowState = FormWindowState.Minimized
    '            Case "FrmPrintBill"
    '                FrmPrintBill.WindowState = FormWindowState.Minimized
    '            Case "FrmPrintBillSTATUSINV"
    '                FrmPrintBillSTATUSINV.WindowState = FormWindowState.Minimized
    '            Case "FrmPrintBillSummary"
    '                FrmPrintBillSummary.WindowState = FormWindowState.Minimized
    '            Case "FrmPrintInvoice"
    '                FrmPrintInvoice.WindowState = FormWindowState.Minimized
    '            Case "FrmPrintRCP"
    '                FrmPrintRCP.WindowState = FormWindowState.Minimized
    '            Case "FrmPromtPrint"
    '                FrmPromtPrint.WindowState = FormWindowState.Minimized
    '            Case "FrmOPEN"
    '                FrmOPEN.WindowState = FormWindowState.Minimized

    '        End Select


    '    Next
    'End Sub


End Class
