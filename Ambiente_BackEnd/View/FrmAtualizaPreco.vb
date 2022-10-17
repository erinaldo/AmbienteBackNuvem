Imports FirebirdSql.Data.FirebirdClient
Imports MySql.Data.MySqlClient

Public Class FrmAtualizaPreco
    Private Sub carregaDados()
        Dim ds As New DataSet
        daNuvem = New MySqlDataAdapter("SELECT ProdutosNuvem.idProdutos,ProdutosNuvem.codigobarra,ProdutosNuvem.produto,ProdutosNuvem.precovenda,ProdutosNuvem.ATIVO FROM ProdutosNuvem WHERE ativo = 'SIM'", conexaoAtualiza)
        daNuvem.Fill(ds)

        dgProdutos.DataSource = ds.Tables(0)
    End Sub
    Private Sub btnAtualizaPreco_Click(sender As Object, e As EventArgs) Handles btnAtualizaPreco.Click
        Dim sql As String
        Dim codproduto As String
        Dim preco As String = InputBox("Digite o valor")
        If preco <> "" Then
            For Each linha As DataGridViewRow In dgProdutos.Rows
                codproduto = linha.Cells(0).Value
                If linha.Cells(4).Value = True Then
                    Try
                        sql = "UPDATE ProdutosNuvem SET precovenda = @precovenda WHERE idProdutos = @idProdutos"
                        comandoNuvem = New MySqlCommand(sql, conexaoAtualiza)

                        comandoNuvem.Parameters.AddWithValue("@idProdutos", codproduto)
                        comandoNuvem.Parameters.AddWithValue("@precovenda", preco)

                        conexaoAtualiza.Close()
                        conexaoAtualiza.Open()
                        comandoNuvem.ExecuteNonQuery()
                        conexaoAtualiza.Close()
                    Catch ex As Exception
                        MsgBox("Erro ao atualizar preço do produto: " + ex.Message)
                    End Try
                End If
            Next
        End If
    End Sub

    Private Sub FrmAtualizaPreco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregaDados()
    End Sub

    Private Sub txtPesquisar_TextChanged(sender As Object, e As EventArgs) Handles txtPesquisar.TextChanged
        Dim str As String = 0
        Dim ds As New DataSet
        If (txtPesquisar.Text <> "") Then
            str = "SELECT ProdutosNuvem.idProdutos,ProdutosNuvem.codigobarra,ProdutosNuvem.produto,ProdutosNuvem.precovenda,ProdutosNuvem.ATIVO FROM ProdutosNuvem WHERE ATIVO = 'SIM' and produto  LIKE  '%" & txtPesquisar.Text & "%'"

            daNuvem = New MySqlDataAdapter(str, conexaoAtualiza)
            daNuvem.Fill(ds)

            conexaoAtualiza.Close()
            conexaoAtualiza.ConnectionString = bancoAtualiza
            conexaoAtualiza.Open()

            Dim cmd As MySqlCommand = New MySqlCommand(str, conexaoAtualiza)
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable
            da.Fill(dt)
            dgProdutos.DataSource = dt

            conexaoLocal.Close()
        Else
            carregaDados()
        End If
    End Sub
End Class