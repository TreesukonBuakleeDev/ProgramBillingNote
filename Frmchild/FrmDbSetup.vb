Public Class FrmDbSetup
    Private Sub FrmDbSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dtConfigDB = New DataTable
            dtConfigDB = Connection.READDB()
            If dtConfigDB.Rows.Count <> 0 Then

            End If
            EnableDBSetup(False)
        Catch ex As Exception
            WriteLog("Error 10 FrmDbSetup_Load() :" & ex.Message)
        End Try
    End Sub

    Private Sub BTNSAVE_DB_Click(sender As Object, e As EventArgs) Handles BTNSAVE_DB.Click
        Try
            Connection.SAVEDB(dtConfigDB)
            If MAIN.WindowState = FormWindowState.Maximized Or MAIN.WindowState = FormWindowState.Minimized Or MAIN.WindowState = FormWindowState.Normal Then
                MAIN.Hide()
                FrmOPEN.Show()
            Else
                FrmOPEN.Show()

            End If
            DATACLASS.CREATE_FMSCSCOMMASTER()
            DATACLASS.INSERTFMSCSCOMMASTER()
            Me.Close()
        Catch ex As Exception
            WriteLog("Error 26  BTNSAVE_DB_Click() :" & ex.Message)
        End Try
    End Sub

    Private Sub BTNDB_NEWT_Click(sender As Object, e As EventArgs) Handles BTNDB_NEW.Click
        Try
            txtDBID.Text = "***New***"
            txtDBID.Visible = True
            txtConfirmPass.Visible = True
            LB_Confirm.Visible = True
            EnableDBSetup(True)
        Catch ex As Exception
            WriteLog("Error 38 BTNDB_NEWT_Click():" & ex.Message)
        End Try
    End Sub

    Private Sub BTNDB_EDIT_Click(sender As Object, e As EventArgs) Handles BTNDB_EDIT.Click
        Try
            EnableDBSetup(True)
        Catch ex As Exception
            WriteLog("Error 46 BTNDB_EDIT_Click() :" & ex.Message)
        End Try
    End Sub

    Private Sub BTNDB_DEL_Click(sender As Object, e As EventArgs) Handles BTNDB_DEL.Click
        Try
            'delete
            dtConfigDB = New DataTable
            dtConfigDB = Connection.READDB()

            For i = 0 To dtConfigDB.Rows.Count
                Dim vServer As String = dtConfigDB.Rows(i).Item("SERVER").ToString.TrimEnd
                If vServer = Acc_Company.Text.TrimEnd Then
                    dtConfigDB.Rows(i).Delete()
                End If
            Next

            'save
            Connection.SAVEDB(dtConfigDB)
        Catch ex As Exception
            WriteLog("ERROR 66 BTNDB_DEL_Click() : " & ex.Message)
        End Try
    End Sub

    Private Sub BTN_DBNext_Click(sender As Object, e As EventArgs) Handles BTN_DBNext.Click
        Try
            Dim DTAPP As DataTable = Connection.READDB()
            DTAPP.DefaultView.Sort = "ID ASC"
            DTAPP = DTAPP.DefaultView.ToTable
            If DTAPP.Rows.Count > 0 Then
                For i = 0 To DTAPP.Rows.Count - 1
                    If txtDBID.Text = "" Then

                        txtDBID.Text = DTAPP.Rows(0).Item("ID").ToString

                        Acc_Company.Text = DTAPP.Rows(0).Item("SERVER").ToString
                        Acc_UserID.Text = DTAPP.Rows(0).Item("USER").ToString
                        Acc_Password.Text = DTAPP.Rows(0).Item("PASSWORD").ToString
                        Acc_Source.Text = DTAPP.Rows(0).Item("DBSource").ToString
                        Acc_DB.Text = DTAPP.Rows(0).Item("DBBILL").ToString
                        Dim author As String = DTAPP.Rows(0).Item("AUTHOR").ToString
                        If author = 1 Then
                            BTNAUTHEN_YES.Checked = True
                            BTNAUTHEN_NO.Checked = False
                        Else
                            BTNAUTHEN_YES.Checked = False
                            BTNAUTHEN_NO.Checked = True
                        End If
                    Else

                        Dim rowIndex = DTAPP.AsEnumerable().[Select](Function(r) r.Field(Of Integer)("ID")).ToList().FindIndex(Function(col) col = CInt(txtDBID.Text))

                        Select Case rowIndex + 1
                            Case Is < DTAPP.Rows.Count - 1
                                txtDBID.Text = DTAPP.Rows(rowIndex + 1).Item("ID").ToString
                                Acc_Company.Text = DTAPP.Rows(rowIndex + 1).Item("SERVER").ToString
                                Acc_UserID.Text = DTAPP.Rows(rowIndex + 1).Item("USER").ToString
                                Acc_Password.Text = DTAPP.Rows(rowIndex + 1).Item("PASSWORD").ToString
                                Acc_Source.Text = DTAPP.Rows(rowIndex + 1).Item("DBSource").ToString
                                Acc_DB.Text = DTAPP.Rows(rowIndex + 1).Item("DBBILL").ToString
                                Dim author As String = DTAPP.Rows(rowIndex + 1).Item("AUTHOR").ToString
                                If author = 1 Then
                                    BTNAUTHEN_YES.Checked = True
                                    BTNAUTHEN_NO.Checked = False
                                Else
                                    BTNAUTHEN_YES.Checked = False
                                    BTNAUTHEN_NO.Checked = True
                                End If
                            Case Is = DTAPP.Rows.Count - 1
                                txtDBID.Text = DTAPP.Rows(rowIndex + 1).Item("ID").ToString
                                Acc_Company.Text = DTAPP.Rows(rowIndex + 1).Item("SERVER").ToString
                                Acc_UserID.Text = DTAPP.Rows(rowIndex + 1).Item("USER").ToString
                                Acc_Password.Text = DTAPP.Rows(rowIndex + 1).Item("PASSWORD").ToString
                                Acc_Source.Text = DTAPP.Rows(rowIndex + 1).Item("DBSource").ToString
                                Acc_DB.Text = DTAPP.Rows(rowIndex + 1).Item("DBBILL").ToString
                                Dim author As String = DTAPP.Rows(rowIndex + 1).Item("AUTHOR").ToString
                                If author = 1 Then
                                    BTNAUTHEN_YES.Checked = True
                                    BTNAUTHEN_NO.Checked = False
                                Else
                                    BTNAUTHEN_YES.Checked = False
                                    BTNAUTHEN_NO.Checked = True
                                End If

                            Case Else
                                txtDBID.Text = DTAPP.Rows(0).Item("ID").ToString
                                Acc_Company.Text = DTAPP.Rows(0).Item("SERVER").ToString
                                Acc_UserID.Text = DTAPP.Rows(0).Item("USER").ToString
                                Acc_Password.Text = DTAPP.Rows(0).Item("PASSWORD").ToString
                                Acc_Source.Text = DTAPP.Rows(0).Item("DBSource").ToString
                                Acc_DB.Text = DTAPP.Rows(0).Item("DBBILL").ToString
                                Dim author As String = DTAPP.Rows(0).Item("AUTHOR").ToString
                                If author = 1 Then
                                    BTNAUTHEN_YES.Checked = True
                                    BTNAUTHEN_NO.Checked = False
                                Else
                                    BTNAUTHEN_YES.Checked = False
                                    BTNAUTHEN_NO.Checked = True
                                End If
                        End Select
                    End If
                    Exit For
                Next

            Else
                MessageBox.Show("Records Not found")
            End If
        Catch ex As Exception
            WriteLog("Error 155 (BTN_DBNext_Click) :" & ex.Message)
        End Try
    End Sub

    Private Sub BTNDB_CLOSE_Click(sender As Object, e As EventArgs) Handles BTNDB_CLOSE.Click
        If MAIN.WindowState = FormWindowState.Maximized Or MAIN.WindowState = FormWindowState.Minimized Or MAIN.WindowState = FormWindowState.Normal Then
            MAIN.Hide()
            FrmOPEN.Show()
        Else
            FrmOPEN.Show()
        End If
        Me.Close()

    End Sub

    Sub EnableDBSetup(ByVal mode As Boolean)
        Try
            Acc_Company.Enabled = mode
            Acc_UserID.Enabled = mode
            Acc_Password.Enabled = mode
            txtConfirmPass.Enabled = mode
            Acc_Source.Enabled = mode
            Acc_DB.Enabled = mode
            BTNAUTHEN_YES.Enabled = mode
            BTNAUTHEN_NO.Enabled = mode
            BTNDB_NEW.Enabled = mode
            BTNDB_EDIT.Enabled = mode
            BTNDB_DEL.Enabled = mode
        Catch ex As Exception
            WriteLog("ERROR 183 EnableDBSetup() : " & ex.Message)
        End Try
    End Sub

    Private Sub Acc_Source_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Acc_Source.DropDown
        Try
            Dim DTLIST As DataTable = New DataTable
            DTLIST = MASTER.GETDATABASE(Acc_Company.Text.TrimEnd, Acc_UserID.Text.TrimEnd, Acc_Password.Text.TrimEnd)

            For i = 0 To DTLIST.Rows.Count - 1
                Acc_Source.Items.Add(DTLIST.Rows(i).Item("name").ToString.TrimEnd)
            Next
        Catch ex As Exception
            WriteLog("ERROR 195 Acc_Source_SelectedIndexChanged() : " & ex.Message)
        End Try
    End Sub

    Private Sub Acc_DB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Acc_DB.DropDown
        Try
            Dim DTLIST As DataTable = New DataTable
            DTLIST = MASTER.GETDATABASE(Acc_Company.Text.TrimEnd, Acc_UserID.Text.TrimEnd, Acc_Password.Text.TrimEnd)

            For i = 0 To DTLIST.Rows.Count - 1
                Acc_DB.Items.Add(DTLIST.Rows(i).Item("name").ToString.TrimEnd)
            Next
        Catch ex As Exception
            WriteLog("ERROR 209 Acc_DB.DropDown() : " & ex.Message)
        End Try
    End Sub

    Private Sub BTN_FMSADMIN_Click(sender As Object, e As EventArgs) Handles BTN_FMSADMIN.Click
        Try
            FrmLOGINFMS.Show()
        Catch ex As Exception
            WriteLog("ERROR 219 BTN_FMSADMIN_Click() : " & ex.Message)
        End Try
    End Sub
End Class