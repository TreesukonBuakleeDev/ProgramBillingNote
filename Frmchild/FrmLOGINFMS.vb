Public Class FrmLOGINFMS
    Private Sub BTN_LOGINFMS_Click(sender As Object, e As EventArgs) Handles BTN_LOGINFMS.Click
        Try

            If (txtUser.Text.Trim.ToUpper <> "FMSADMIN" Or txtPassword.Text.Trim.ToUpper <> "FMSADMIN") Then

                MessageBox.Show(txtUser.Text & "UserName or Password Invalid")

            Else

                Call FrmDbSetup.EnableDBSetup(True)

                Me.Close()
                'Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show(txtUser.Text & " UserName or Password Invalid")
        End Try

    End Sub
End Class