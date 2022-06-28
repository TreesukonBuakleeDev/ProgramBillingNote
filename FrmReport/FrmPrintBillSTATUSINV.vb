Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Public Class FrmPrintBillSTATUSINV

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
    Private Sub BTNReportINV_CUSTF_Click(sender As Object, e As EventArgs) Handles BTNReportINV_CUSTF.Click
        Try
            MAIN.txtForm.Text = "FrmPrintBillSTATUSINV"
            FrmSearch.txtSearch.Text = "From Status Report Customer Number"
            Call FrmSearch.SearchShow("IDCUST", "NAMECUST", "Customer Number", "Customer Name", "", "")
        Catch ex As Exception
            MessageBox.Show("Error 25 (BTNReportINV_CUSTF_Click): " & ex.Message)
        End Try
    End Sub

    Private Sub BTNReportINV_CUSTT_Click(sender As Object, e As EventArgs) Handles BTNReportINV_CUSTT.Click
        Try
            MAIN.txtForm.Text = "FrmPrintBillSTATUSINV"
            FrmSearch.txtSearch.Text = "To Status Report Customer Number"
            Call FrmSearch.SearchShow("IDCUST", "NAMECUST", "Customer Number", "Customer Name", "", "")
        Catch ex As Exception
            MessageBox.Show("Error 33 (BTNReportINV_CUSTT_Click): " & ex.Message)
        End Try
    End Sub

    Private Sub BTN_PrintINV_Click(sender As Object, e As EventArgs) Handles BTN_PrintStatusINV.Click
        Try
            Dim VDATEFROM As String = RPT_DATEF.Value.ToString("yyyyMMdd")
            Dim VDATETO As String = RPT_DATET.Value.ToString("yyyyMMdd")

            Dim CUSTF As String = txtReportINV_CUSTF.Text
            Dim CUSTT As String = txtReportINV_CUSTT.Text
            Dim STA As String = txtReportINV_STA.Text
            Dim rptfilename As String = ""

            rptfilename = My.Application.Info.DirectoryPath & "\Reports\FMSBILLSTD_ReportStatusInv.rpt"

            'Call Create View
            DATACLASS.CREATEVIEW_FMSREPORTSTATUS(CUSTF, CUSTT, VDATEFROM, VDATETO)

            'Call Alter View 
            Call MASTER.ALTERVIEW_FMSREPORTSTATUS(CUSTF, CUSTT, VDATEFROM, VDATETO)

            'Call print 
            Call FrmPrintSTATUSINV_Load(VDATEFROM, VDATETO, CUSTF, CUSTT, rptfilename, STA)

            'Close()
        Catch ex As Exception
            MessageBox.Show("Error 55 (BTN_PrintStatusINV): " & ex.Message)
        End Try
    End Sub

    Sub FrmPrintSTATUSINV_Load(ByVal VDATEFROM As String, ByVal VDATETO As String, ByVal CUSTF As String, ByVal CUSTT As String, ByVal rptfilename As String, ByVal STA As String)

        Dim strFormula As String = ""
        Dim clsRptViewer As New FrmPrintBillSTATUSINV
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
            WriteLog("Error 85 (FrmPrintSTATUSINV_Load) :" & ex.Message)
        End Try


        connection = New SqlConnection(strcon)

        Dim conStrREPORT As New SqlClient.SqlConnectionStringBuilder(strcon)

        rpt.Load(rptfilename)
        clsRptViewer.ReportAttribute.Fomula = strFormula

        ReDim clsRptViewer.ReportAttributeParameter(6)

        clsRptViewer.ReportAttributeParameter(1).ParameterName = "DATEFROM"
        clsRptViewer.ReportAttributeParameter(1).ParameterValue = VDATEFROM
        clsRptViewer.ReportAttributeParameter(2).ParameterName = "DATETO"
        clsRptViewer.ReportAttributeParameter(2).ParameterValue = VDATETO

        clsRptViewer.ReportAttributeParameter(3).ParameterName = "CustomerFrom"
        clsRptViewer.ReportAttributeParameter(3).ParameterValue = CUSTF
        clsRptViewer.ReportAttributeParameter(4).ParameterName = "CustomerTo"
        clsRptViewer.ReportAttributeParameter(4).ParameterValue = CUSTT

        Dim AUDTORG As String = MAIN.txtDBSOURCE.Text.TrimEnd
        clsRptViewer.ReportAttributeParameter(5).ParameterName = "AUDTORG"
        clsRptViewer.ReportAttributeParameter(5).ParameterValue = AUDTORG

        clsRptViewer.ReportAttributeParameter(6).ParameterName = "STATUSINV"
        clsRptViewer.ReportAttributeParameter(6).ParameterValue = STA

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
                objForm.Text = rptfilename
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

    Private Sub BTN_ReportINVClose_Click(sender As Object, e As EventArgs) Handles BTN_ReportINVClose.Click
        Me.Close()
    End Sub


End Class