Public Class FrmPromtPrint

    Private Sub BTNBILL_PRNTBROWSE_Click(sender As Object, e As EventArgs) Handles BTNBILL_PRNTBROWSE.Click
        Try
            Dim BrwfileIm As OpenFileDialog = New OpenFileDialog()
            If BrwfileIm.ShowDialog() = DialogResult.OK Then
                txtBillPrintFileName.Text = BrwfileIm.SafeFileName
                txtBillrptFile.Text = BrwfileIm.FileName
            End If
        Catch ex As Exception
            MessageBox.Show("Error 10 BTNBILL_PRNTBROWSE_Click() : " & ex.Message)
        End Try
    End Sub

    Private Sub BTNBILLPROMT_PRINTING_Click(sender As Object, e As EventArgs) Handles BTNBILLPROMT_PRINTING.Click
        Try
            If txtBillPrintFileName.Text.TrimEnd = "" Then
                MessageBox.Show("Please specific report file name again. ")
                Exit Sub
            Else
                Dim vtxtBillno As String = txtBillno.Text
                Dim vtxtBillrptFile As String = txtBillrptFile.Text
                Close()
                FrmPrintBill.TopMost = True
                Call FrmPrintBill.FrmPrintBill_Load(vtxtBillno, vtxtBillrptFile)

            End If
        Catch ex As Exception
            MessageBox.Show("Error 27 BTNBILLPROMT_PRINTING_Click() : " & ex.Message)
        End Try
    End Sub

    Private Sub FrmPromtPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub

    Sub CallPromptPrint(ByVal BILLNO As String, ByVal FORM As String, Optional ByVal RCPTYPE As String = "")
        Try
            Show()
            txtBillno.Text = BILLNO
            txtBillno.ReadOnly = True
            Select Case FORM
                Case "BILL"
                    txtBillPrintFileName.Text = "FMSBILLSTD.rpt"
                    txtBillrptFile.Text = My.Application.Info.DirectoryPath & "\Reports\FMSBILLSTD.rpt"
                Case "RECEIPT"
                    Select Case RCPTYPE
                        Case "RCP"
                            txtBillPrintFileName.Text = "FMSRC.rpt"
                            txtBillrptFile.Text = My.Application.Info.DirectoryPath & "\Reports\FMSRC.rpt"

                        Case "TAX"

                            txtBillPrintFileName.Text = "FMSTAXRC.rpt"
                            txtBillrptFile.Text = My.Application.Info.DirectoryPath & "\Reports\FMSTAXRC.rpt"

                        Case Else
                            txtBillPrintFileName.Text = "FMSRC.rpt"
                            txtBillrptFile.Text = My.Application.Info.DirectoryPath & "\Reports\FMSRC.rpt"
                    End Select
                Case Else
                            txtBillPrintFileName.Text = ""

                    End Select
        Catch ex As Exception
            MessageBox.Show("Error 52 (CallPromptPrint): " & ex.Message)
        End Try
    End Sub

    Private Sub BTN_PromtCLOSE_Click(sender As Object, e As EventArgs) Handles BTN_PromtCLOSE.Click
        Me.Close()
    End Sub
End Class