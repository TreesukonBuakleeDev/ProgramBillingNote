Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Public Class FrmPrintInvoice

    Structure Parameter
        Dim ParameterName As String
        Dim ParameterValue As String
    End Structure
    Structure ReportCondition
        Dim ConnectionString As String
        Dim ReportFile As String
        Dim Fomula As String
    End Structure
    Public ReportAttribute As ReportCondition
    Public ReportAttributeParameter() As Parameter
    Friend conStr As String
    Friend connection As SqlConnection
    Friend dataSt As DataSet
    Friend adapter As SqlDataAdapter

    'Sub ShowFrmPrintINV(ByVal DocType)
    '    Try
    '        'Me.TopLevel = False
    '        Me.TopMost = True

    '        'MAIN.PanelMain.Controls.Add(Me)
    '        Show()
    '        If DocType = "BILL" Then
    '            Show()
    '            Me.Text = "BILL"
    '            txtHeaderINV.Text = "รายงานใบวางบิล"
    '        Else
    '            Show()
    '            Me.Text = "RECEIPT"
    '            txtHeaderINV.Text = "รายงานใบเสร็จรับเงิน"
    '        End If


    '    Catch ex As Exception
    '        MessageBox.Show("Error 40 (ShowFrmPrintINV): " & ex.Message)
    '    End Try
    'End Sub

    Private Sub BTN_ReportINVClose_Click(sender As Object, e As EventArgs) Handles BTN_ReportINVClose.Click
        Me.Close()
    End Sub

    Private Sub BTN_PrintINV_Click(sender As Object, e As EventArgs) Handles BTN_PrintINV.Click
        Try
            Dim BILLNOF As String = txtReportINV_BILLNOF.Text
            Dim BILLNOT As String = txtReportINV_BILLNOT.Text

            Dim CUSTF As String = txtReportINV_CUSTF.Text
            Dim CUSTT As String = txtReportINV_CUSTT.Text
            Dim rptfilename As String
            Me.TopMost = False
            If Me.Text = "BILL" Then
                rptfilename = My.Application.Info.DirectoryPath & "\Reports\FMSBILLSTD_ReportInvoice.rpt"
            Else
                rptfilename = My.Application.Info.DirectoryPath & "\Reports\FMSRCPSTD_ReportInvoice.rpt"
            End If

            Call FrmPrintINV_Load(BILLNOF, BILLNOT, CUSTF, CUSTT, rptfilename)
            'Close()
        Catch ex As Exception
            MessageBox.Show("Error 66 (BTN_PrintINV_Click): " & ex.Message)
        End Try
    End Sub

    Sub FrmPrintINV_Load(ByVal INVF As String, ByVal INVT As String, ByVal CUSTF As String, ByVal CUSTT As String, ByVal rptfilename As String)

        Dim strFormula As String = ""
        Dim clsRptViewer As New FrmPrintInvoice
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim strcon As String = ""
        Try
            If dtConfigDB.Rows.Count = 0 Then
                dtConfigDB = READDB()
            Else
            End If

            If dtConfigDB.Rows.Count <> 0 Then
                strcon = "Data Source= " & dtConfigDB.Rows(0).Item("SERVER").ToString & "  ;Initial Catalog=" & dtConfigDB.Rows(0).Item("DBBILL").ToString & " ;User ID=" & dtConfigDB.Rows(0).Item("USER").ToString & " ;Password= " & dtConfigDB.Rows(0).Item("PASSWORD").ToString & ";Connect Timeout=0 "

                connection = New SqlConnection(strcon)

                If connection.State = ConnectionState.Closed Then

                    connection.Open()
                Else
                End If
            Else
                Exit Sub
            End If
        Catch ex As Exception
            WriteLog("Error 96 (FrmPrintINV_Load) :" & ex.Message)
        End Try


        connection = New SqlConnection(strcon)

        Dim conStrREPORT As New SqlClient.SqlConnectionStringBuilder(strcon)

        rpt.Load(rptfilename)
        clsRptViewer.ReportAttribute.Fomula = strFormula

        ReDim clsRptViewer.ReportAttributeParameter(5)

        clsRptViewer.ReportAttributeParameter(1).ParameterName = "INVF"
        clsRptViewer.ReportAttributeParameter(1).ParameterValue = INVF
        clsRptViewer.ReportAttributeParameter(2).ParameterName = "INVT"
        clsRptViewer.ReportAttributeParameter(2).ParameterValue = INVT

        clsRptViewer.ReportAttributeParameter(3).ParameterName = "CUSTF"
        clsRptViewer.ReportAttributeParameter(3).ParameterValue = CUSTF
        clsRptViewer.ReportAttributeParameter(4).ParameterName = "CUSTT"
        clsRptViewer.ReportAttributeParameter(4).ParameterValue = CUSTT

        Dim AUDTORG As String = MAIN.txtDBSOURCE.Text.TrimEnd
        clsRptViewer.ReportAttributeParameter(5).ParameterName = "AUDTORG"
        clsRptViewer.ReportAttributeParameter(5).ParameterValue = AUDTORG

        Dim crTable As CrystalDecisions.CrystalReports.Engine.Table
        Dim crTableLogonInfo As CrystalDecisions.Shared.TableLogOnInfo
        Dim ConnInfo As New CrystalDecisions.Shared.ConnectionInfo

        ConnInfo.ServerName = conStrREPORT.DataSource
        ConnInfo.UserID = conStrREPORT.UserID
        ConnInfo.Password = conStrREPORT.Password
        ConnInfo.DatabaseName = conStrREPORT.InitialCatalog
        ConnInfo.IntegratedSecurity = False

        Try
            For Each crTable In rpt.Database.Tables
                crTableLogonInfo = crTable.LogOnInfo
                crTableLogonInfo.ConnectionInfo = ConnInfo
                crTable.ApplyLogOnInfo(crTableLogonInfo)
            Next
            If (clsRptViewer.ReportAttributeParameter IsNot Nothing) Then
                For Each obj As Parameter In clsRptViewer.ReportAttributeParameter
                    If (obj.ParameterValue <> String.Empty) OrElse (obj.ParameterName <> String.Empty) Then
                        rpt.SetParameterValue(obj.ParameterName, obj.ParameterValue)
                    End If
                Next
            End If

            ''rpt.RecordSelectionFormula = clsRptViewer.ReportAttribute.Fomula

            'Open Crystal report viewer' 
            Using objForm As New Windows.Forms.Form
                objForm.StartPosition = FormStartPosition.CenterScreen
                objForm.Text = rptfilename & " - " & INVF & INVT
                objForm.WindowState = FormWindowState.Maximized

                Using rptViewer As New CrystalDecisions.Windows.Forms.CrystalReportViewer

                    rptViewer.DisplayGroupTree = True
                    rptViewer.ShowCloseButton = False
                    rptViewer.ShowGroupTreeButton = True
                    rptViewer.ShowTextSearchButton = True
                    rptViewer.ShowZoomButton = True

                    rptViewer.Dock = DockStyle.Fill

                    objForm.Controls.Add(rptViewer)

                    rptViewer.ReportSource = rpt

                    objForm.ShowDialog()

                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error 171 : " & ex.Message)
        End Try

    End Sub

    Private Sub BTNReportINV_CUSTF_Click(sender As Object, e As EventArgs) Handles BTNReportINV_CUSTF.Click
        Try

            MAIN.txtForm.Text = "FrmPrintInvoice"
            FrmSearch.txtSearch.Text = "From Invoice Report Customer Number"
            Call FrmSearch.SearchShow("IDCUST", "NAMECUST", "Customer Number", "Customer Name", "", "")
        Catch ex As Exception
            MessageBox.Show("Error 180 (BTNReportINV_CUSTF_Click): " & ex.Message)
        End Try
    End Sub

    Private Sub BTNReportINV_CUSTT_Click(sender As Object, e As EventArgs) Handles BTNReportINV_CUSTT.Click
        Try
            MAIN.txtForm.Text = "FrmPrintInvoice"
            FrmSearch.txtSearch.Text = "To Invoice Report Customer Number"
            Call FrmSearch.SearchShow("IDCUST", "NAMECUST", "Customer Number", "Customer Name", "", "")
        Catch ex As Exception
            MessageBox.Show("Error 192 (BTNReportINV_CUSTT_Click): " & ex.Message)
        End Try
    End Sub

    Private Sub BTNReportINV_BILLF_Click(sender As Object, e As EventArgs) Handles BTNReportINV_BILLF.Click
        Try
            MAIN.txtForm.Text = "FrmPrintInvoice"
            If Me.Text = "BILL" Then
                FrmSearch.txtSearch.Text = "From Invoice Report Billing Note Number"
                Call FrmSearch.SearchShow("BILLNO", "IDCUST", "Billing Number", "Customer Number", "NAMECUST", "Customer Name")
            Else
                FrmSearch.txtSearch.Text = "From Invoice Report Receipt Number"
                Call FrmSearch.SearchShow("RCPNO", "IDCUST", "Receipt No", "Customer Number", "NAMECUST", "Customer Name")
            End If
        Catch ex As Exception
            MessageBox.Show("Error 206 (BTNReportINV_CUSTT_Click): " & ex.Message)
        End Try
    End Sub

    Private Sub BTNReportINV_BILLT_Click(sender As Object, e As EventArgs) Handles BTNReportINV_BILLT.Click
        Try
            MAIN.txtForm.Text = "FrmPrintInvoice"
            If Me.Text = "BILL" Then
                FrmSearch.txtSearch.Text = "To Invoice Report Billing Note Number"
                Call FrmSearch.SearchShow("BILLNO", "IDCUST", "Billing Number", "Customer Number", "NAMECUST", "Customer Name")
            Else
                FrmSearch.txtSearch.Text = "To Invoice Report Receipt Number"
                Call FrmSearch.SearchShow("RCPNO", "IDCUST", "Receipt No", "Customer Number", "NAMECUST", "Customer Name")
            End If
        Catch ex As Exception
            MessageBox.Show("Error 216 (BTNReportINV_BILLT_Click): " & ex.Message)
        End Try
    End Sub
End Class