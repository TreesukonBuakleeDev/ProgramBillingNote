Public Class FrmPrintRCP
    Private Sub FrmPrintRCP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub ShowRCPReport(ByVal RCPNO As String)
        Try
            'Classify Type

            Dim RCPTYPE As String = MASTER.GET_RCPTYPE(RCPNO)

            'CALL PRINT FUNCTION

            Call FrmPromtPrint.CallPromptPrint(RCPNO, "RECEIPT", RCPTYPE)

        Catch ex As Exception
            MessageBox.Show("Error 12 (ShowRCPReport) : " & ex.Message)
        End Try

    End Sub
End Class