Public Class FrmOPTFD
    Private Sub FrmOPTFD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dtGETOPTFD As DataTable = New DataTable
            dtGETOPTFD = MASTER.GETDATA_OPTFD()
            ShowOPTFD(dtGETOPTFD)
        Catch ex As Exception
            WriteLog("Error 8 FrmOPTFD_Load() :" & ex.Message)
        End Try
    End Sub
    Private Sub BTNOPTFD_SAVE_Click(sender As Object, e As EventArgs) Handles BTNOPTFD_SAVE.Click
        Try
            Dim dtOPTFD As DataTable = New DataTable
            dtOPTFD = ADDVALUEOPTFD()
            Call DATACLASS.INSERTFMSMASTEROPTFD(dtOPTFD)
        Catch ex As Exception
            WriteLog("Error 17 BTNOPTFD_SAVE_Click() :" & ex.Message)
        End Try
    End Sub

    Public Shared Function ADDVALUEOPTFD() As DataTable
        Dim dtOPTFD As DataTable = New DataTable
        Try
            If dtOPTFD.Columns.Count = 0 Then
                dtOPTFD.Columns.Add("OPTFDID")
                dtOPTFD.Columns.Add("OPTFDNAME")
                dtOPTFD.Columns.Add("ACTIVE")
            End If
            Dim OPTVALUE1(9) As String

            OPTVALUE1(0) = FrmOPTFD.txtBILLHTEXT1.Text
            OPTVALUE1(1) = FrmOPTFD.txtBILLHTEXT2.Text
            OPTVALUE1(2) = FrmOPTFD.txtBILLHTEXT3.Text
            OPTVALUE1(3) = FrmOPTFD.txtBILLHTEXT4.Text
            OPTVALUE1(4) = FrmOPTFD.txtBILLHTEXT5.Text
            OPTVALUE1(5) = FrmOPTFD.txtBILLHTEXT6.Text
            OPTVALUE1(6) = FrmOPTFD.txtBILLHTEXT7.Text
            OPTVALUE1(7) = FrmOPTFD.txtBILLHTEXT8.Text
            OPTVALUE1(8) = FrmOPTFD.txtBILLHTEXT9.Text
            OPTVALUE1(9) = FrmOPTFD.txtBILLHTEXT10.Text

            Dim OPTVALUE2(9) As String
            OPTVALUE2(0) = FrmOPTFD.txtBILLDTEXT1.Text
            OPTVALUE2(1) = FrmOPTFD.txtBILLDTEXT2.Text
            OPTVALUE2(2) = FrmOPTFD.txtBILLDTEXT3.Text
            OPTVALUE2(3) = FrmOPTFD.txtBILLDTEXT4.Text
            OPTVALUE2(4) = FrmOPTFD.txtBILLDTEXT5.Text
            OPTVALUE2(5) = FrmOPTFD.txtBILLDTEXT6.Text
            OPTVALUE2(6) = FrmOPTFD.txtBILLDTEXT7.Text
            OPTVALUE2(7) = FrmOPTFD.txtBILLDTEXT8.Text
            OPTVALUE2(8) = FrmOPTFD.txtBILLDTEXT9.Text
            OPTVALUE2(9) = FrmOPTFD.txtBILLDTEXT10.Text

            Dim OPTVALUE3(9) As String
            OPTVALUE3(0) = FrmOPTFD.txtRCPHTEXT1.Text
            OPTVALUE3(1) = FrmOPTFD.txtRCPHTEXT2.Text
            OPTVALUE3(2) = FrmOPTFD.txtRCPHTEXT3.Text
            OPTVALUE3(3) = FrmOPTFD.txtRCPHTEXT4.Text
            OPTVALUE3(4) = FrmOPTFD.txtRCPHTEXT5.Text
            OPTVALUE3(5) = FrmOPTFD.txtRCPHTEXT6.Text
            OPTVALUE3(6) = FrmOPTFD.txtRCPHTEXT7.Text
            OPTVALUE3(7) = FrmOPTFD.txtRCPHTEXT8.Text
            OPTVALUE3(8) = FrmOPTFD.txtRCPHTEXT9.Text
            OPTVALUE3(9) = FrmOPTFD.txtRCPHTEXT10.Text

            Dim OPTVALUE4(9) As String
            OPTVALUE4(0) = FrmOPTFD.txtRCPDTEXT1.Text
            OPTVALUE4(1) = FrmOPTFD.txtRCPDTEXT2.Text
            OPTVALUE4(2) = FrmOPTFD.txtRCPDTEXT3.Text
            OPTVALUE4(3) = FrmOPTFD.txtRCPDTEXT4.Text
            OPTVALUE4(4) = FrmOPTFD.txtRCPDTEXT5.Text
            OPTVALUE4(5) = FrmOPTFD.txtRCPDTEXT6.Text
            OPTVALUE4(6) = FrmOPTFD.txtRCPDTEXT7.Text
            OPTVALUE4(7) = FrmOPTFD.txtRCPDTEXT8.Text
            OPTVALUE4(8) = FrmOPTFD.txtRCPDTEXT9.Text
            OPTVALUE4(9) = FrmOPTFD.txtRCPDTEXT10.Text
            Dim ID As String = ""

            Dim ACTVALUE1(9) As String
            ACTVALUE1(0) = FrmOPTFD.CBX_BH01.CheckState
            ACTVALUE1(1) = FrmOPTFD.CBX_BH02.CheckState
            ACTVALUE1(2) = FrmOPTFD.CBX_BH03.CheckState
            ACTVALUE1(3) = FrmOPTFD.CBX_BH04.CheckState
            ACTVALUE1(4) = FrmOPTFD.CBX_BH05.CheckState
            ACTVALUE1(5) = FrmOPTFD.CBX_BH06.CheckState
            ACTVALUE1(6) = FrmOPTFD.CBX_BH07.CheckState
            ACTVALUE1(7) = FrmOPTFD.CBX_BH08.CheckState
            ACTVALUE1(8) = FrmOPTFD.CBX_BH09.CheckState
            ACTVALUE1(9) = FrmOPTFD.CBX_BH10.CheckState

            Dim ACTVALUE2(9) As String
            ACTVALUE2(0) = FrmOPTFD.CBX_BD01.CheckState
            ACTVALUE2(1) = FrmOPTFD.CBX_BD02.CheckState
            ACTVALUE2(2) = FrmOPTFD.CBX_BD03.CheckState
            ACTVALUE2(3) = FrmOPTFD.CBX_BD04.CheckState
            ACTVALUE2(4) = FrmOPTFD.CBX_BD05.CheckState
            ACTVALUE2(5) = FrmOPTFD.CBX_BD06.CheckState
            ACTVALUE2(6) = FrmOPTFD.CBX_BD07.CheckState
            ACTVALUE2(7) = FrmOPTFD.CBX_BD08.CheckState
            ACTVALUE2(8) = FrmOPTFD.CBX_BD09.CheckState
            ACTVALUE2(9) = FrmOPTFD.CBX_BD10.CheckState

            Dim ACTVALUE3(9) As String
            ACTVALUE3(0) = FrmOPTFD.CBX_RH01.CheckState
            ACTVALUE3(1) = FrmOPTFD.CBX_RH02.CheckState
            ACTVALUE3(2) = FrmOPTFD.CBX_RH03.CheckState
            ACTVALUE3(3) = FrmOPTFD.CBX_RH04.CheckState
            ACTVALUE3(4) = FrmOPTFD.CBX_RH05.CheckState
            ACTVALUE3(5) = FrmOPTFD.CBX_RH06.CheckState
            ACTVALUE3(6) = FrmOPTFD.CBX_RH07.CheckState
            ACTVALUE3(7) = FrmOPTFD.CBX_RH08.CheckState
            ACTVALUE3(8) = FrmOPTFD.CBX_RH09.CheckState
            ACTVALUE3(9) = FrmOPTFD.CBX_RH10.CheckState

            Dim ACTVALUE4(9) As String
            ACTVALUE4(0) = FrmOPTFD.CBX_RD01.CheckState
            ACTVALUE4(1) = FrmOPTFD.CBX_RD02.CheckState
            ACTVALUE4(2) = FrmOPTFD.CBX_RD03.CheckState
            ACTVALUE4(3) = FrmOPTFD.CBX_RD04.CheckState
            ACTVALUE4(4) = FrmOPTFD.CBX_RD05.CheckState
            ACTVALUE4(5) = FrmOPTFD.CBX_RD06.CheckState
            ACTVALUE4(6) = FrmOPTFD.CBX_RD07.CheckState
            ACTVALUE4(7) = FrmOPTFD.CBX_RD08.CheckState
            ACTVALUE4(8) = FrmOPTFD.CBX_RD09.CheckState
            ACTVALUE4(9) = FrmOPTFD.CBX_RD10.CheckState

            'BillHead
            For i = 0 To 9
                ID = "BILLHTEXT" & i + 1

                Dim row As String() = New String() {ID, OPTVALUE1(i), IIf(ACTVALUE1(i) = True, 1, 0)}
                dtOPTFD.Rows.Add(row)
            Next

            For i = 0 To 9
                ID = "BILLDTEXT" & i + 1

                Dim row As String() = New String() {ID, OPTVALUE2(i), IIf(ACTVALUE2(i) = True, 1, 0)}
                dtOPTFD.Rows.Add(row)
            Next
            'Receipt 
            For i = 0 To 9
                ID = "RCPHTEXT" & i + 1

                Dim row As String() = New String() {ID, OPTVALUE3(i), IIf(ACTVALUE3(i) = True, 1, 0)}
                dtOPTFD.Rows.Add(row)
            Next
            For i = 0 To 9
                ID = "RCPDTEXT" & i + 1

                Dim row As String() = New String() {ID, OPTVALUE4(i), IIf(ACTVALUE4(i) = True, 1, 0)}
                dtOPTFD.Rows.Add(row)
            Next
        Catch ex As Exception
            WriteLog("Error 155 ADDVALUEOPTFD() :" & ex.Message)
        End Try
        Return dtOPTFD
    End Function

    Sub ShowOPTFD(ByVal dtGETOPTFD As DataTable)
        Try
            If dtGETOPTFD.Rows.Count <> 0 Or IsDBNull(dtGETOPTFD) = False Then
                For i = 0 To dtGETOPTFD.Rows.Count - 1
                    Dim OPTFDID As String = dtGETOPTFD.Rows(i).Item("OPTFDID").ToString
                    Dim OPTFDNAME As String = dtGETOPTFD.Rows(i).Item("OPTFDNAME").ToString
                    Dim OPTFDACTIVE As String = dtGETOPTFD.Rows(i).Item("ACTIVE").ToString
                    Dim ACTCHK As Boolean
                    If OPTFDACTIVE = "0" Then
                        ACTCHK = False
                    Else
                        ACTCHK = True
                    End If

                    Select Case OPTFDID
                        Case "BILLHTEXT1"
                            txtBILLHTEXT1.Text = OPTFDNAME
                            CBX_BH01.Checked = ACTCHK
                        Case "BILLHTEXT2"
                            txtBILLHTEXT2.Text = OPTFDNAME
                            CBX_BH02.Checked = ACTCHK
                        Case "BILLHTEXT3"
                            txtBILLHTEXT3.Text = OPTFDNAME
                            CBX_BH03.Checked = ACTCHK
                        Case "BILLHTEXT4"
                            txtBILLHTEXT4.Text = OPTFDNAME
                            CBX_BH04.Checked = ACTCHK
                        Case "BILLHTEXT5"
                            txtBILLHTEXT5.Text = OPTFDNAME
                            CBX_BH05.Checked = ACTCHK
                        Case "BILLHTEXT6"
                            txtBILLHTEXT6.Text = OPTFDNAME
                            CBX_BH06.Checked = ACTCHK
                        Case "BILLHTEXT7"
                            txtBILLHTEXT7.Text = OPTFDNAME
                            CBX_BH07.Checked = ACTCHK
                        Case "BILLHTEXT8"
                            txtBILLHTEXT8.Text = OPTFDNAME
                            CBX_BH08.Checked = ACTCHK
                        Case "BILLHTEXT9"
                            txtBILLHTEXT9.Text = OPTFDNAME
                            CBX_BH09.Checked = ACTCHK
                        Case "BILLHTEXT10"
                            txtBILLHTEXT10.Text = OPTFDNAME
                            CBX_BH10.Checked = ACTCHK
                    End Select

                    Select Case OPTFDID
                        Case "BILLDTEXT1"
                            txtBILLDTEXT1.Text = OPTFDNAME
                            CBX_BD01.Checked = ACTCHK
                        Case "BILLDTEXT2"
                            txtBILLDTEXT2.Text = OPTFDNAME
                            CBX_BD02.Checked = ACTCHK
                        Case "BILLDTEXT3"
                            txtBILLDTEXT3.Text = OPTFDNAME
                            CBX_BD03.Checked = ACTCHK
                        Case "BILLDTEXT4"
                            txtBILLDTEXT4.Text = OPTFDNAME
                            CBX_BD04.Checked = ACTCHK
                        Case "BILLDTEXT5"
                            txtBILLDTEXT5.Text = OPTFDNAME
                            CBX_BD05.Checked = ACTCHK
                        Case "BILLDTEXT6"
                            txtBILLDTEXT6.Text = OPTFDNAME
                            CBX_BD06.Checked = ACTCHK
                        Case "BILLDTEXT7"
                            txtBILLDTEXT7.Text = OPTFDNAME
                            CBX_BD07.Checked = ACTCHK
                        Case "BILLDTEXT8"
                            txtBILLDTEXT8.Text = OPTFDNAME
                            CBX_BD08.Checked = ACTCHK
                        Case "BILLDTEXT9"
                            txtBILLDTEXT9.Text = OPTFDNAME
                            CBX_BD09.Checked = ACTCHK
                        Case "BILLDTEXT10"
                            txtBILLDTEXT10.Text = OPTFDNAME
                            CBX_BD10.Checked = ACTCHK
                    End Select

                    Select Case OPTFDID
                        Case "RCPHTEXT1"
                            txtRCPHTEXT1.Text = OPTFDNAME
                            CBX_RH01.Checked = ACTCHK
                        Case "RCPHTEXT2"
                            txtRCPHTEXT2.Text = OPTFDNAME
                            CBX_RH02.Checked = ACTCHK
                        Case "RCPHTEXT3"
                            txtRCPHTEXT3.Text = OPTFDNAME
                            CBX_RH03.Checked = ACTCHK
                        Case "RCPHTEXT4"
                            txtRCPHTEXT4.Text = OPTFDNAME
                            CBX_RH04.Checked = ACTCHK
                        Case "RCPHTEXT5"
                            txtRCPHTEXT5.Text = OPTFDNAME
                            CBX_RH05.Checked = ACTCHK
                        Case "RCPHTEXT6"
                            txtRCPHTEXT6.Text = OPTFDNAME
                            CBX_RH06.Checked = ACTCHK
                        Case "RCPHTEXT7"
                            txtRCPHTEXT7.Text = OPTFDNAME
                            CBX_RH07.Checked = ACTCHK
                        Case "RCPHTEXT8"
                            txtRCPHTEXT8.Text = OPTFDNAME
                            CBX_RH08.Checked = ACTCHK
                        Case "RCPHTEXT9"
                            txtRCPHTEXT9.Text = OPTFDNAME
                            CBX_RH09.Checked = ACTCHK
                        Case "RCPHTEXT10"
                            txtRCPHTEXT10.Text = OPTFDNAME
                            CBX_RH10.Checked = ACTCHK
                    End Select

                    Select Case OPTFDID
                        Case "RCPDTEXT1"
                            txtRCPDTEXT1.Text = OPTFDNAME
                            CBX_RD01.Checked = ACTCHK
                        Case "RCPDTEXT2"
                            txtRCPDTEXT2.Text = OPTFDNAME
                            CBX_RD02.Checked = ACTCHK
                        Case "RCPDTEXT3"
                            txtRCPDTEXT3.Text = OPTFDNAME
                            CBX_RD03.Checked = ACTCHK
                        Case "RCPDTEXT4"
                            txtRCPDTEXT4.Text = OPTFDNAME
                            CBX_RD04.Checked = ACTCHK
                        Case "RCPDTEXT5"
                            txtRCPDTEXT5.Text = OPTFDNAME
                            CBX_RD05.Checked = ACTCHK
                        Case "RCPDTEXT6"
                            txtRCPDTEXT6.Text = OPTFDNAME
                            CBX_RD06.Checked = ACTCHK
                        Case "RCPDTEXT7"
                            txtRCPDTEXT7.Text = OPTFDNAME
                            CBX_RD07.Checked = ACTCHK
                        Case "RCPDTEXT8"
                            txtRCPDTEXT8.Text = OPTFDNAME
                            CBX_RD08.Checked = ACTCHK
                        Case "RCPDTEXT9"
                            txtRCPDTEXT9.Text = OPTFDNAME
                            CBX_RD09.Checked = ACTCHK
                        Case "RCPDTEXT10"
                            txtRCPDTEXT10.Text = OPTFDNAME
                            CBX_RD10.Checked = ACTCHK
                    End Select
                Next
            End If
        Catch ex As Exception
            WriteLog("Error 309 ShowOPTFD() : " & ex.Message)
        End Try
    End Sub

    Private Sub BTNBill_REFRESH_Click(sender As Object, e As EventArgs) Handles BTNBill_REFRESH.Click
        Me.Close()
    End Sub
End Class