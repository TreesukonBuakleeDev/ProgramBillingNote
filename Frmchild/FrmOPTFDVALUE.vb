Public Class FrmOPTFDVALUE

    Private Sub FrmOPTFDVALUE_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub GET_OPTFDVALUE(ByVal OPTFDID As String, ByVal NO As String, ByVal IDCUST As String)
        Try
            Me.Show()
            Dim DTOPTFDV As DataTable = New DataTable
            Dim ColHEADER1, ColHEADER2, ColHEADER3, ColHEADER4, ColHEADER5 As String
            Dim ColHEADER6, ColHEADER7, ColHEADER8, ColHEADER9, ColHEADER10 As String
            Dim CONDITION As String = " WHERE OPTFDID LIKE '%" & OPTFDID & "%'"

            DTOPTFDV = MASTER.GETDATA_OPTFD(CONDITION)
            Dim DTHEADER As DataTable = New DataTable

            Select Case OPTFDID
                Case "BILLHTEXT"
                    DTHEADER = MASTER.GETDATA_BILLHEADER(NO, IDCUST)
                Case "RCPHTEXT"
                    DTHEADER = MASTER.GETDATA_RCPHEADER(NO, IDCUST)
            End Select


            If DTHEADER.Rows.Count = 0 Then
            Else

                For I = 0 To DTHEADER.Rows.Count - 1
                    ColHEADER1 = DTHEADER.Rows(I).Item("" & OPTFDID & "1").ToString
                    ColHEADER2 = DTHEADER.Rows(I).Item("" & OPTFDID & "2").ToString
                    ColHEADER3 = DTHEADER.Rows(I).Item("" & OPTFDID & "3").ToString
                    ColHEADER4 = DTHEADER.Rows(I).Item("" & OPTFDID & "4").ToString
                    ColHEADER5 = DTHEADER.Rows(I).Item("" & OPTFDID & "5").ToString
                    ColHEADER6 = DTHEADER.Rows(I).Item("" & OPTFDID & "6").ToString
                    ColHEADER7 = DTHEADER.Rows(I).Item("" & OPTFDID & "7").ToString
                    ColHEADER8 = DTHEADER.Rows(I).Item("" & OPTFDID & "8").ToString
                    ColHEADER9 = DTHEADER.Rows(I).Item("" & OPTFDID & "9").ToString
                    ColHEADER10 = DTHEADER.Rows(I).Item("" & OPTFDID & "10").ToString
                Next
            End If
            If DTOPTFDV.Columns.Contains("VALUE") = False Then
                DTOPTFDV.Columns.Add("VALUE")
            End If

            If DTHEADER.Rows.Count <> 0 Then
                DTOPTFDV.Rows(0).Item("VALUE") = ColHEADER1
                DTOPTFDV.Rows(1).Item("VALUE") = ColHEADER2
                DTOPTFDV.Rows(2).Item("VALUE") = ColHEADER3
                DTOPTFDV.Rows(3).Item("VALUE") = ColHEADER4
                DTOPTFDV.Rows(4).Item("VALUE") = ColHEADER5
                DTOPTFDV.Rows(5).Item("VALUE") = ColHEADER6
                DTOPTFDV.Rows(6).Item("VALUE") = ColHEADER7
                DTOPTFDV.Rows(7).Item("VALUE") = ColHEADER8
                DTOPTFDV.Rows(8).Item("VALUE") = ColHEADER9
                DTOPTFDV.Rows(9).Item("VALUE") = ColHEADER10
            End If

            DGV_OPTFDVALUE.DataSource = DTOPTFDV

            With DGV_OPTFDVALUE
                DGV_OPTFDVALUE.Columns(0).Visible = False
                DGV_OPTFDVALUE.Columns(2).Visible = False
            End With

        Catch ex As Exception
            WriteLog("ERROR 67 GET_OPTFDVALUE() : " & ex.Message)
        End Try
    End Sub

    Private Sub BTNBill_OPTFDSAVE_Click(sender As Object, e As EventArgs) Handles BTNBill_OPTFDSAVE.Click
        Try
            DT_TEMPOPTFD = New DataTable
            'DT_TEMPOPTFD = CType(DGV_OPTFDVALUE.DataSource, DataTable).Copy
            DT_TEMPOPTFD = CONVERTDGVtoDATATABLE(DGV_OPTFDVALUE)
        Catch ex As Exception
            WriteLog("ERROR 75 BTNBill_OPTFDSAVE_Click() : " & ex.Message)
        End Try

    End Sub

    Private Sub BTNBill_OPTFDCLOSE_Click(sender As Object, e As EventArgs) Handles BTNBill_OPTFDCLOSE.Click
        Me.Close()
    End Sub
End Class