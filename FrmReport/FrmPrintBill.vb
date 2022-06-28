Imports System.IO
Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Public Class FrmPrintBill
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

    Sub ShowReport(ByVal BILLNO As String)
        Try
            'CALL PRINT FUNCTION
            Call FrmPromtPrint.CallPromptPrint(BILLNO, "BILL")
        Catch ex As Exception
            MessageBox.Show("Error 27 (ShowReport) : " & ex.Message)
        End Try

    End Sub


    Sub FrmPrintBill_Load(ByVal BILLNO As String, ByVal rptfilename As String)

        Dim strFormula As String = ""
        Dim clsRptViewer As New FrmPrintBill
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
            WriteLog("Error 59 (FrmPrintBill_Load) :" & ex.Message)
        End Try


        connection = New SqlConnection(strcon)

        Dim conStrREPORT As New SqlClient.SqlConnectionStringBuilder(strcon)

        'rpt.Load(My.Application.Info.DirectoryPath & "\Reports\FMSBILLSTD.rpt")
        ' rpt.Load(My.Application.Info.DirectoryPath & "\Reports\" & rptfilename & " ")
        rpt.Load(rptfilename)
        clsRptViewer.ReportAttribute.Fomula = strFormula

        ReDim clsRptViewer.ReportAttributeParameter(2)

        clsRptViewer.ReportAttributeParameter(1).ParameterName = "BILLNO"
        clsRptViewer.ReportAttributeParameter(1).ParameterValue = BILLNO

        Dim AUDTORG As String = MAIN.txtDBSOURCE.Text.TrimEnd
        clsRptViewer.ReportAttributeParameter(2).ParameterName = "AUDTORG"
        clsRptViewer.ReportAttributeParameter(2).ParameterValue = AUDTORG



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
                objForm.Text = rptfilename & " - " & BILLNO
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

                    objForm.TopMost = True

                    objForm.ShowDialog()

                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error 135 FrmPrintBill_Load() : " & ex.Message)
        End Try

    End Sub

    Private Sub FrmPrintBill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub
End Class