Public Class FrmAuthor

    Private Sub FrmAuthor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub BTN_AuthorNext_Click(sender As Object, e As EventArgs) Handles BTN_AuthorNext.Click
        Try
            Dim DTAPP As DataTable = Connection.READAUTHOR
            DTAPP.DefaultView.Sort = "ID ASC"
            DTAPP = DTAPP.DefaultView.ToTable
            If DTAPP.Rows.Count > 0 Then
                For i = 0 To DTAPP.Rows.Count - 1
                    If txtAuthorUserID.Text = "" Then
                        txtAuthorUserID.Text = DTAPP.Rows(0).Item("ID").ToString
                        txtAuthorUser.Text = DTAPP.Rows(0).Item("USER").ToString
                        txtAuthorPassword.Text = DTAPP.Rows(0).Item("PASSWORD").ToString
                        txtAuthorized.Text = DTAPP.Rows(0).Item("AUTHOR").ToString
                    Else
                        'Dim index As Integer
                        Dim rowIndex = DTAPP.AsEnumerable().[Select](Function(r) r.Field(Of Integer)("ID")).ToList().FindIndex(Function(col) col = CInt(txtAuthorUserID.Text))
                        'MessageBox.Show(rowIndex)

                        Select Case rowIndex + 1
                            Case Is < DTAPP.Rows.Count - 1
                                txtAuthorUserID.Text = DTAPP.Rows(rowIndex + 1).Item("ID").ToString
                                txtAuthorUser.Text = DTAPP.Rows(rowIndex + 1).Item("USER").ToString
                                txtAuthorPassword.Text = DTAPP.Rows(rowIndex + 1).Item("PASSWORD").ToString
                                txtAuthorized.Text = DTAPP.Rows(rowIndex + 1).Item("AUTHOR").ToString
                            Case Is = DTAPP.Rows.Count - 1
                                txtAuthorUserID.Text = DTAPP.Rows(rowIndex + 1).Item("ID").ToString
                                txtAuthorUser.Text = DTAPP.Rows(rowIndex + 1).Item("USER").ToString
                                txtAuthorPassword.Text = DTAPP.Rows(rowIndex + 1).Item("PASSWORD").ToString
                                txtAuthorized.Text = DTAPP.Rows(rowIndex + 1).Item("AUTHOR").ToString

                            Case Else
                                txtAuthorUserID.Text = DTAPP.Rows(0).Item("ID").ToString
                                txtAuthorUser.Text = DTAPP.Rows(0).Item("USER").ToString
                                txtAuthorPassword.Text = DTAPP.Rows(0).Item("PASSWORD").ToString
                                txtAuthorized.Text = DTAPP.Rows(0).Item("AUTHOR").ToString

                        End Select
                    End If
                    Exit For
                Next
            Else
                MessageBox.Show("Records Not found")
            End If
        Catch ex As Exception
            WriteLog("Error 49 (BTN_AuthorNext_Click) :" & ex.Message)
        End Try
    End Sub

    Private Sub BTN_AUTHNEW_Click(sender As Object, e As EventArgs) Handles BTN_AUTHNEW.Click
        Try
            txtAuthorUserID.Text = "***New***"
            txtAuthorUser.Text = ""
            txtAuthorPassword.Text = ""
            Lb_ConfirmPass.Visible = True
            txtConfirmPass.Visible = True
            txtAuthorUser.ReadOnly = False
            txtAuthorPassword.ReadOnly = False
            txtConfirmPass.ReadOnly = False
        Catch ex As Exception
            WriteLog("Error 63 (BTN_AUTHNEW_Click) :" & ex.Message)
        End Try
    End Sub

    Private Sub BTN_AUTHEDIT_Click(sender As Object, e As EventArgs) Handles BTN_AUTHEDIT.Click
        Try
            txtAuthorUser.ReadOnly = False
            txtAuthorPassword.ReadOnly = False
            txtConfirmPass.ReadOnly = False
        Catch ex As Exception
            WriteLog("Error 73 (BTN_AUTHNEW_Click) :" & ex.Message)
        End Try
    End Sub

    Private Sub BTN_AUTHDEL_Click(sender As Object, e As EventArgs) Handles BTN_AUTHDEL.Click
        Try
            Dim dialogOK As DialogResult = MsgBox("Do you want to delete user ?", MessageBoxButtons.OKCancel)
            If dialogOK = DialogResult.OK Then
                Dim DTAPP As DataTable = Connection.READAUTHOR
                For i = 0 To DTAPP.Rows.Count - 1
                    If DTAPP.Rows(i).Item("ID").ToString.TrimEnd = txtAuthorUserID.Text.TrimEnd Then
                        DTAPP.Rows(i).Delete()
                        DTAPP.AcceptChanges()
                        Exit For
                    End If
                Next

                SAVEAUTHOR(DTAPP)
                txtAuthorUserID.Text = ""
                txtAuthorUser.Text = ""
                txtAuthorPassword.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show("Error 98" & ex.Message)
            WriteLog("Error 98 (BTN_AUTHDEL_Click) :" & ex.Message)
        End Try
    End Sub

    Private Sub BTN_SAVEAUTHOR_Click(sender As Object, e As EventArgs) Handles BTN_SAVEAUTHOR.Click
        Try
            Dim DTAPP As DataTable = Connection.READAUTHOR
            DTAPP.DefaultView.Sort = "ID ASC"
            DTAPP = DTAPP.DefaultView.ToTable
            SAVEAUTHOR(DTAPP)
        Catch ex As Exception
            WriteLog("Error 109 (BTN_AUTHNEW_Click) :" & ex.Message)
        End Try
    End Sub

    Private Sub BTN_AUTHCLOSE_Click(sender As Object, e As EventArgs) Handles BTN_AUTHCLOSE.Click
        Me.Close()
    End Sub
End Class