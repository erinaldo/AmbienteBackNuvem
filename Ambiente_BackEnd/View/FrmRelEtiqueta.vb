Imports Microsoft.Reporting.WinForms

Public Class FrmRelEtiqueta

    Private Sub FrmRelEtiqueta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DTT As New DataTable
        conexaoLocal.Close()
        conexaoLocal.ConnectionString = bancoLocal

        Try
            conexaoLocal.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        daLocal.Fill(DTT)

        ReportViewer1.LocalReport.DataSources.Clear()
        Dim Rpt As New ReportDataSource("dsProdutos", DTT)
        ReportViewer1.LocalReport.DataSources.Add(Rpt)

        ReportViewer1.RefreshReport()

    End Sub

    Private Sub ReportViewer1_Layout(sender As Object, e As LayoutEventArgs) Handles ReportViewer1.Layout
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
    End Sub
End Class