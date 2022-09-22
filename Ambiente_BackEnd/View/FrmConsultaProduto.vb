Imports FirebirdSql.Data.FirebirdClient

Public Class FrmConsultaProduto
    Public continuaLancando As String
    Private Sub FrmConsultaProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As New DataSet

        FrmLancarProduto.Close()

        If (conexaoLocal.State <> ConnectionState.Closed) Then
            conexaoLocal.Close()
        End If

        daLocal = New FbDataAdapter("SELECT PRODUTOS.CODPRODUTO,PRODUTOS.DESCRICAO,PRODUTOS.CODBARRA,PRODUTOS.PRECO_VENDA FROM PRODUTOS WHERE ATIVO = 'SIM'", conexaoLocal)
        daLocal.Fill(ds)

        dgConsultaProduto.DataSource = ds.Tables(0)
    End Sub

    Private Sub dgConsultaProduto_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgConsultaProduto.CellContentDoubleClick
        Dim str As String
        Dim currentRow As DataGridViewRow = dgConsultaProduto.Rows(e.RowIndex)

        str = "SELECT * FROM PRODUTOS WHERE CODPRODUTO = " & currentRow.Cells(0).Value.ToString()

        conexaoLocal.Close()
        conexaoLocal.ConnectionString = bancoLocal
        conexaoLocal.Open()

        Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)
        drLocal = cmd.ExecuteReader

        'Dim FrmLancarProduto As New FrmLancarProduto

        While drLocal.Read()
            FrmLancarProduto.codProduto = drLocal("CODPRODUTO").ToString
            FrmLancarProduto.txtCodigoProduto.Text = drLocal("CODPRODUTO").ToString
        End While
        'Close()

        FrmLancarProduto.ShowDialog()
        If continuaLancando = "NAO" Then
            Close()
        End If
    End Sub
End Class