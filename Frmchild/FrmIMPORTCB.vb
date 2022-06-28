Public Class FrmIMPORTCB

    Private Sub FrmIMPORTCB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Call DATACLASS.CREATEFMSMASTERIMPORT()
            Dim DTCONFIG As DataTable = New DataTable()
            DTCONFIG = MASTER.GET_CONFIGCB()

            If DTCONFIG.Rows.Count > 0 Then
                txtCBAccpacID.Text = DTCONFIG.Rows(0).Item("ACCPACID").ToString.TrimEnd
                txtCBPassword.Text = DTCONFIG.Rows(0).Item("ACCPACPASSWORD").ToString.TrimEnd
                txtCBCompany.Text = DTCONFIG.Rows(0).Item("COMPANY").ToString.TrimEnd
                txtCBVersion.Text = DTCONFIG.Rows(0).Item("ACCPACVERSION").ToString.TrimEnd
                txtDNSRCCODE.Text = DTCONFIG.Rows(0).Item("DNSRCCODE").ToString.TrimEnd
                txtCNSRCCODE.Text = DTCONFIG.Rows(0).Item("CNSRCCODE").ToString.TrimEnd
                txtCBPathBK.Text = DTCONFIG.Rows(0).Item("PATHBACKUP").ToString.TrimEnd
                txtCBPathErr.Text = DTCONFIG.Rows(0).Item("PATHERROR").ToString.TrimEnd
                Dim OPTFDHEAD As String = DTCONFIG.Rows(0).Item("OPTFD_HEAD").ToString.TrimEnd
                Dim OPTFDDETAIL As String = DTCONFIG.Rows(0).Item("OPTFD_DETAIL").ToString.TrimEnd
                If OPTFDHEAD = "/" Then
                    OPTFD_HEADER.Checked = True
                Else
                    OPTFD_HEADER.Checked = False
                End If

                If OPTFDDETAIL = "/" Then
                    OPTFD_DETAIL.Checked = True
                Else
                    OPTFD_DETAIL.Checked = False
                End If

            End If
        Catch ex As Exception
            WriteLog("Error 21 FrmIMPORTCB_Load():" & ex.Message)
        End Try
    End Sub
    Private Sub BTN_SAVECB_Click(sender As Object, e As EventArgs) Handles BTN_SAVECB.Click
        Try
            Call DATACLASS.INSERTFMSMASTERIMPORT()
        Catch ex As Exception
            WriteLog("Error 27 BTN_SAVECB_Click():" & ex.Message)
        End Try
    End Sub

    Private Sub BTNCB_BROWSEBK_Click(sender As Object, e As EventArgs) Handles BTNCB_BROWSEBK.Click
        Try
            Dim BrwfileIm As FolderBrowserDialog = New FolderBrowserDialog()
            If BrwfileIm.ShowDialog() = DialogResult.OK Then
                txtCBPathBK.Text = BrwfileIm.SelectedPath.ToString
            End If
        Catch ex As Exception
            WriteLog("Error 37 BTN_SAVECB_Click():" & ex.Message)
        End Try
    End Sub

    Private Sub BTNCB_BrowseErr_Click(sender As Object, e As EventArgs) Handles BTNCB_BrowseErr.Click
        Try
            Dim BrwfileEx As FolderBrowserDialog = New FolderBrowserDialog()
            If BrwfileEx.ShowDialog() = DialogResult.OK Then
                txtCBPathErr.Text = BrwfileEx.SelectedPath.ToString
            End If
        Catch ex As Exception
            WriteLog("Error 49 BTN_SAVECB_Click():" & ex.Message)
        End Try
    End Sub

    Private Sub BTN_CBCLOSE_Click(sender As Object, e As EventArgs) Handles BTN_CBCLOSE.Click
        Me.Close()
    End Sub
End Class