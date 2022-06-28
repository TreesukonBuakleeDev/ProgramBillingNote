Public Class FrmOPEN
    Private Sub FrmOPEN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dtDB As DataTable = New DataTable
            dtDB = Connection.READDB()
            If dtDB.Rows.Count = 0 Then
                FrmDbSetup.Show()
            Else
                For i = 0 To dtDB.Rows.Count - 1
                    Dim Comp As String = ""
                    Comp = MASTER.GET_COMPNAME(dtDB.Rows(i).Item("DBSource").ToString)
                    If Comp = "" Then
                        txtComName.Items.Add(dtDB.Rows(i).Item("DBSource").ToString)
                    Else
                        txtComName.Items.Add(Comp)
                    End If

                Next
            End If
        Catch ex As Exception
            WriteLog("Error 15 (FrmOPEN_Load) :" & ex.Message)
        End Try
    End Sub
    Private Sub BTN_LOGIN_Click(sender As Object, e As EventArgs) Handles BTN_LOGIN.Click
        Try
            Dim COMPANY As String = MASTER.GET_ORGID(txtComName.Text).TrimEnd
            dtConfigDB = Connection.READDB(COMPANY)
            If dtConfigDB.Rows.Count <> 0 Then
                For i = 0 To dtConfigDB.Rows.Count - 1
                    MAIN.txtDBBILL.Text = dtConfigDB.Rows(i).Item("DBBILL").ToString.TrimEnd
                    MAIN.txtDBSOURCE.Text = dtConfigDB.Rows(i).Item("DBSource").ToString.TrimEnd
                    MAIN.txtServer.Text = dtConfigDB.Rows(i).Item("SERVER").ToString.TrimEnd
                Next
            End If
            MAIN.Visible = True
            MAIN.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
            MAIN.Text = "Program Billing Note Version " & Application.ProductVersion & " - " & txtComName.Text
            Call PROCESS.CREATEALLTABLE()
            Me.Close()
        Catch ex As Exception
            WriteLog("Error 32 (BTN_LOGIN_Click) :" & ex.Message)
        End Try
    End Sub

    Private Sub BTN_CONFIG_Click(sender As Object, e As EventArgs) Handles BTN_CONFIG.Click
        Try
            FrmDbSetup.Show()
            FrmDbSetup.EnableDBSetup(False)
        Catch ex As Exception
            WriteLog("Error 41 (BTN_CONFIG_Click) :" & ex.Message)
        End Try
    End Sub

    Private Sub BTN_EXIT_Click(sender As Object, e As EventArgs) Handles BTN_EXIT.Click
        Application.Exit()
    End Sub

    Private Sub txtComName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtComName.Click
        txtComName.Items.Clear()
        Try

            Dim dtDB As DataTable = New DataTable
            dtDB = Connection.READDB()
            If dtDB.Rows.Count = 0 Then
                FrmDbSetup.Show()
            Else
                For i = 0 To dtDB.Rows.Count - 1
                    Dim Comp As String = ""
                    Comp = MASTER.GET_COMPNAME(dtDB.Rows(i).Item("DBSource").ToString)
                    If Comp = "" Then
                        txtComName.Items.Add(dtDB.Rows(i).Item("DBSource").ToString)
                    Else
                        txtComName.Items.Add(Comp)
                    End If
                Next
            End If
        Catch ex As Exception
            WriteLog("Error 15 (FrmOPEN_Load) :" & ex.Message)
        End Try
    End Sub


End Class