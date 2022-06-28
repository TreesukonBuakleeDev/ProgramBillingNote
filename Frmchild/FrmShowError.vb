Imports AccpacCOMAPI
Public Class FrmShowError
    Dim mSession As AccpacCOMAPI.AccpacSession
    Private Sub FrmShowError_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub SetGrid(ByVal mSession_ As AccpacCOMAPI.AccpacSession, ByVal DT As DataTable)
        Try
            mSession = mSession_
            mSession = mSession_

            DGV_ERR.DataSource = DT.DefaultView
            DGV_ERR.Columns(1).ReadOnly = True
            DGV_ERR.Columns(2).ReadOnly = True
            DGV_ERR.Columns(3).ReadOnly = True
            DGV_ERR.Columns(0).Width = 50
            DGV_ERR.Columns(1).Width = 80
            DGV_ERR.Columns(2).Width = 300
            DGV_ERR.Columns(3).Width = 50
            DGV_ERR.Columns(4).Visible = False

        Catch ex As Exception
            WriteLog("ERROR 24 SetGrid() : " & ex.Message)
        End Try
    End Sub
End Class