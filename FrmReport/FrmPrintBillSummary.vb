Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Public Class FrmPrintBillSummary
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


    Private Sub BTN_PrintSumm_Click(sender As Object, e As EventArgs) Handles BTN_PrintSumm.Click
        Try
            Dim BILLNOF As String = txtReport_BILLNOF.Text
            Dim BILLNOT As String = txtReport_BILLNOT.Text
            Dim DATEF As String = txtReport_DATEF.Value.ToString("yyyyMMdd")
            Dim DATET As String = txtReport_DATET.Value.ToString("yyyyMMdd")
            Dim CUSTF As String = txtReport_CUSTF.Text
            Dim CUSTT As String = txtReport_CUSTT.Text
            Dim rptfilename As String
            Dim IMPORTCB As String
            Me.TopMost = False
            If Me.Text = "BILL" Then
                rptfilename = My.Application.Info.DirectoryPath & "\Reports\FMSBILLSTD_ReportSummary.rpt"
                IMPORTCB = ""
            Else
                rptfilename = My.Application.Info.DirectoryPath & "\Reports\FMSRCPSTD_ReportSummary.rpt"
                If txtReport_CBIMPORT.Checked = True Then
                    IMPORTCB = "Y"

                Else
                    IMPORTCB = "N"
                End If
            End If

            Call FrmPrintSummary_Load(BILLNOF, BILLNOT, DATEF, DATET, CUSTF, CUSTT, rptfilename, IMPORTCB)

        Catch ex As Exception
            MessageBox.Show("Error 42 (BTN_PrintSumm_Click): " & ex.Message)
        End Try
        'Close()
    End Sub

    Sub FrmPrintSummary_Load(ByVal BILLNOF As String, ByVal BILLNOT As String, ByVal DATEF As String, ByVal DATET As String, ByVal CUSTF As String, ByVal CUSTT As String, ByVal rptfilename As String, ByVal IMPORTCB As String)

        Dim strFormula As String = ""
        Dim clsRptViewer As New FrmPrintBillSummary
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
            WriteLog("Error 73 (FrmPrintSummary_Load) :" & ex.Message)
        End Try


        connection = New SqlConnection(strcon)

        Dim conStrREPORT As New SqlClient.SqlConnectionStringBuilder(strcon)

        'rpt.Load(My.Application.Info.DirectoryPath & "\Reports\FMSBILLSTD.rpt")
        ' rpt.Load(My.Application.Info.DirectoryPath & "\Reports\" & rptfilename & " ")
        rpt.Load(rptfilename)
        clsRptViewer.ReportAttribute.Fomula = strFormula

        ReDim clsRptViewer.ReportAttributeParameter(8)

        clsRptViewer.ReportAttributeParameter(1).ParameterName = "BILLNOF"
        clsRptViewer.ReportAttributeParameter(1).ParameterValue = BILLNOF
        clsRptViewer.ReportAttributeParameter(2).ParameterName = "BILLNOT"
        clsRptViewer.ReportAttributeParameter(2).ParameterValue = BILLNOT

        clsRptViewer.ReportAttributeParameter(3).ParameterName = "DATEF"
        clsRptViewer.ReportAttributeParameter(3).ParameterValue = DATEF
        clsRptViewer.ReportAttributeParameter(4).ParameterName = "DATET"
        clsRptViewer.ReportAttributeParameter(4).ParameterValue = DATET

        clsRptViewer.ReportAttributeParameter(5).ParameterName = "CUSTF"
        clsRptViewer.ReportAttributeParameter(5).ParameterValue = CUSTF
        clsRptViewer.ReportAttributeParameter(6).ParameterName = "CUSTT"
        clsRptViewer.ReportAttributeParameter(6).ParameterValue = CUSTT

        Dim AUDTORG As String = MAIN.txtDBSOURCE.Text.TrimEnd
        clsRptViewer.ReportAttributeParameter(7).ParameterName = "AUDTORG"
        clsRptViewer.ReportAttributeParameter(7).ParameterValue = AUDTORG

        clsRptViewer.ReportAttributeParameter(8).ParameterName = "IMPORTCB"
        clsRptViewer.ReportAttributeParameter(8).ParameterValue = IMPORTCB

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
                objForm.Text = rptfilename & " - " & BILLNOF & BILLNOT
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
            MessageBox.Show("Error 153 FrmPrintSummary_Load() : " & ex.Message)
        End Try

    End Sub
    Private Sub BTN_ReportClose_Click(sender As Object, e As EventArgs) Handles BTN_ReportClose.Click
        Me.Close()
    End Sub



    Private Sub BTNReportS_CUSTF_Click(sender As Object, e As EventArgs) Handles BTNReportS_CUSTF.Click
        Try
            MAIN.txtForm.Text = "FrmPrintBillSummary"
            FrmSearch.txtSearch.Text = "From Report Customer Number"
            Call FrmSearch.SearchShow("IDCUST", "NAMECUST", "Customer Number", "Customer Name", "", "")
        Catch ex As Exception
            MessageBox.Show("Error 197 (BTNReportS_CUSTF_Click): " & ex.Message)
        End Try
    End Sub

    Private Sub BTNReportS_CUSTTO_Click(sender As Object, e As EventArgs) Handles BTNReportS_CUSTTO.Click
        Try
            MAIN.txtForm.Text = "FrmPrintBillSummary"
            FrmSearch.txtSearch.Text = "To Report Customer Number"
            Call FrmSearch.SearchShow("IDCUST", "NAMECUST", "Customer Number", "Customer Name", "", "")
        Catch ex As Exception
            MessageBox.Show("Error 205 (BTNReportS_CUSTTO_Click): " & ex.Message)
        End Try
    End Sub

    Private Sub BTNReportS_BILLF_Click(sender As Object, e As EventArgs) Handles BTNReportS_BILLF.Click
        Try
            MAIN.txtForm.Text = "FrmPrintBillSummary"
            If Me.Text = "BILL" Then
                FrmSearch.txtSearch.Text = "From Report Billing Note Number"
                Call FrmSearch.SearchShow("BILLNO", "IDCUST", "Billing Number", "Customer Number", "NAMECUST", "Customer Name")
            Else
                FrmSearch.txtSearch.Text = "From Report Receipt Number"
                Call FrmSearch.SearchShow("RCPNO", "IDCUST", "Receipt No", "Customer Number", "NAMECUST", "Customer Name")
            End If
        Catch ex As Exception
            MessageBox.Show("Error 217 (BTNReportS_BILLF_Click): " & ex.Message)
        End Try
    End Sub

    Private Sub BTNReportS_BILLTO_Click(sender As Object, e As EventArgs) Handles BTNReportS_BILLTO.Click
        Try
            MAIN.txtForm.Text = "FrmPrintBillSummary"
            If Me.Text = "BILL" Then
                FrmSearch.txtSearch.Text = "To Report Billing Note Number"
                Call FrmSearch.SearchShow("BILLNO", "IDCUST", "Billing Number", "Customer Number", "NAMECUST", "Customer Name")
            Else
                FrmSearch.txtSearch.Text = "To Report Receipt Number"
                Call FrmSearch.SearchShow("RCPNO", "IDCUST", "Receipt No", "Customer Number", "NAMECUST", "Customer Name")
            End If
        Catch ex As Exception
            MessageBox.Show("Error 229 (BTNReportS_BILLTO_Click): " & ex.Message)
        End Try
    End Sub

    Private Sub FrmPrintBillSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class