Public Class FrmRunning
    Private Sub FrmRunning_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Call GETRUNNO()
        Catch ex As Exception
            WriteLog("ERROR 6 FrmRunning_Load() : " & ex.Message)
        End Try
    End Sub

    Sub GETRUNNO()
        Try
            Dim dtRun As DataTable = New DataTable
            dtRun = MASTER.GETDATA_RUNNO()

            If dtRun.Rows.Count = 0 Then
                If dtRun.Columns.Count = 0 Then
                    dtRun.Columns.Add("DOCTYPE")
                    dtRun.Columns.Add("LENGTH")
                    dtRun.Columns.Add("PREFIX")
                    dtRun.Columns.Add("RUNNO")
                    dtRun.Columns.Add("COMP")
                End If

                Dim rowBill As String() = New String() {"Billing Note", 5, "BTS-", "00001", "" & MAIN.txtDBSOURCE.Text & ""}
                Dim rowReceipt As String() = New String() {"Receipt", 5, "RCIV-", "00001", "" & MAIN.txtDBSOURCE.Text & ""}
                Dim rowReceiptTAX As String() = New String() {"Tax Receipt", 5, "RCT-", "00001", "" & MAIN.txtDBSOURCE.Text & ""}
                dtRun.Rows.Add(rowBill)
                dtRun.Rows.Add(rowReceipt)
                dtRun.Rows.Add(rowReceiptTAX)
                dtRun.AcceptChanges()

            End If

            DGV_RUNNO.DataSource = dtRun

            With DGV_RUNNO
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "Document Types"
                .Columns(1).HeaderCell.Value = "Length"
                .Columns(2).HeaderCell.Value = "Prefix"
                .Columns(3).HeaderCell.Value = "Next Number"
                .Columns(4).Visible = False
                .Columns(5).Visible = False
                .Columns(6).Visible = False
            End With

            If dtRun.Rows.Count > 0 Then
                Select Case dtRun.Rows(0).Item("RCPTYPE").ToString.TrimEnd
                    Case "TAX"
                        BTN_ReceiptTYPE.Checked = False
                        BTN_TAXReceiptTYPE.Checked = True
                    Case "RC"
                        BTN_ReceiptTYPE.Checked = True
                        BTN_TAXReceiptTYPE.Checked = False

                    Case Else
                        BTN_ReceiptTYPE.Checked = False
                        BTN_TAXReceiptTYPE.Checked = True

                End Select
            End If


        Catch ex As Exception
            WriteLog("Error 48 GETRUNNO() :" & ex.Message)
        End Try
    End Sub

    Private Sub BTNBill_POST_Click(sender As Object, e As EventArgs) Handles BTNBill_POST.Click
        Try
            Dim dtFormatRunno As DataTable
            'dtFormatRunno = CType(DGV_RUNNO.DataSource, DataTable).Copy
            dtFormatRunno = CONVERTDGVtoDATATABLE(DGV_RUNNO)
            If dtFormatRunno.Columns.Contains("RCPTYPE") = False Then

                dtFormatRunno.Columns.Add("RCPTYPE")
            End If

            If dtFormatRunno.Rows.Count > 0 Then
                Dim RCPTYPE As String = ""
                If BTN_TAXReceiptTYPE.Checked = True And BTN_ReceiptTYPE.Checked = True Then
                    MessageBox.Show("Save Failed. Please decide on one of Receipt or Tax receipt!")
                    Exit Try
                End If
                If BTN_TAXReceiptTYPE.Checked = True Then
                    RCPTYPE = "TAX"
                Else
                    RCPTYPE = "RC"
                End If
                For i = 0 To dtFormatRunno.Rows.Count - 1

                    dtFormatRunno.Rows(i).Item("RCPTYPE") = RCPTYPE
                Next
            End If
            Call DATACLASS.INSERTFMSMASTERRUNING(dtFormatRunno)

        Catch ex As Exception
            WriteLog("ERROR 58 BTNBill_OPTFDSAVE_Click() : " & ex.Message)
        End Try
    End Sub

    Private Sub BTNBill_REFRESH_Click(sender As Object, e As EventArgs) Handles BTNBill_REFRESH.Click
        Me.Close()
    End Sub


End Class