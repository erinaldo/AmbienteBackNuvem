Imports FirebirdSql.Data.FirebirdClient

Public Class FrmEscolheEtiqueta

    Private Sub carregaDados()
        Dim ds As New DataSet
        daLocal = New FbDataAdapter("SELECT PRODUTOS.CODPRODUTO,PRODUTOS.CODBARRA,PRODUTOS.DESCRICAO,PRODUTOS.PRECO_VENDA,PRODUTOS.ATIVO FROM PRODUTOS WHERE ATIVO = 'SIM'", conexaoLocal)
        daLocal.Fill(ds)

        dgProdutos.DataSource = ds.Tables(0)
    End Sub
    Private Sub FrmEscolheEtiqueta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregaDados()
    End Sub

    Private Sub btnGerarEtiqueta_Click(sender As Object, e As EventArgs) Handles btnGerarEtiqueta.Click
        Dim sql As String

        FrmRelEtiqueta.ShowDialog()
        sql = "UPDATE PRODUTOS SET GERAETIQUETA = @GERAETIQUETA WHERE GERAETIQUETA = 'SIM'"

        comandoLocal = New FbCommand(sql, conexaoLocal)

        comandoLocal.Parameters.AddWithValue("@GERAETIQUETA", "NAO")

        conexaoLocal.Close()
        conexaoLocal.Open()
        comandoLocal.ExecuteNonQuery()
        conexaoLocal.Close()
    End Sub

    Private Sub txtPesquisar_TextChanged(sender As Object, e As EventArgs) Handles txtPesquisar.TextChanged
        Dim str As String = 0
        Dim ds As New DataSet
        If (txtPesquisar.Text <> "") Then
            str = "SELECT PRODUTOS.CODPRODUTO,PRODUTOS.CODBARRA,PRODUTOS.DESCRICAO,PRODUTOS.PRECO_VENDA,PRODUTOS.ATIVO FROM PRODUTOS WHERE ATIVO = 'SIM' and CODBARRA = '" + txtPesquisar.Text + "'"

            daLocal = New FbDataAdapter(str, conexaoLocal)
            daLocal.Fill(ds)

            conexaoLocal.Close()
            conexaoLocal.ConnectionString = bancoLocal
            conexaoLocal.Open()

            Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)
            Dim da As FbDataAdapter = New FbDataAdapter(cmd)
            Dim dt As DataTable = New DataTable
            da.Fill(dt)
            dgProdutos.DataSource = dt

            conexaoLocal.Close()
        Else
            carregaDados()
        End If
    End Sub

    Private Sub dgProdutos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgProdutos.CellClick
        If e.ColumnIndex = etiqueta.Index AndAlso e.RowIndex >= 0 Then
            Dim sql As String
            Dim currentRow As DataGridViewRow = dgProdutos.Rows(e.RowIndex)
            sql = "UPDATE PRODUTOS SET GERAETIQUETA = @GERAETIQUETA WHERE CODPRODUTO = @CODPRODUTO"

            comandoLocal = New FbCommand(Sql, conexaoLocal)

            comandoLocal.Parameters.AddWithValue("@CODPRODUTO", currentRow.Cells(0).Value.ToString)
            comandoLocal.Parameters.AddWithValue("@GERAETIQUETA", "SIM")

            conexaoLocal.Close()
            conexaoLocal.Open()
            comandoLocal.ExecuteNonQuery()
            conexaoLocal.Close()

            Dim ds As New DataSet
            daLocal = New FbDataAdapter("SELECT PRODUTOS.CODPRODUTO,PRODUTOS.CODBARRA,PRODUTOS.DESCRICAO,PRODUTOS.PRECO_VENDA,PRODUTOS.ATIVO FROM PRODUTOS WHERE GERAETIQUETA = 'SIM' and ATIVO = 'SIM'", conexaoLocal)
            daLocal.Fill(ds)
        End If
    End Sub
End Class