Imports FirebirdSql.Data.FirebirdClient
Imports MySql.Data.MySqlClient

Public Class FrmAtualizaPreco
    Dim importaProdutos As String = LerIni("Banco", "ImportaNuvem")
    Private Sub carregaDados()
        Dim ds As New DataSet
        If (importaProdutos = "SIM") Then
            daNuvem = New MySqlDataAdapter("SELECT ProdutosNuvem.idProdutos,ProdutosNuvem.codigobarra,ProdutosNuvem.produto,ProdutosNuvem.precovenda FROM ProdutosNuvem WHERE ativo = 'SIM'", conexaoAtualiza)
            daNuvem.Fill(ds)

            dgProdutos.DataSource = ds.Tables(0)
        ElseIf (importaProdutos = "NAO") Then
            daLocal = New FbDataAdapter("SELECT PRODUTOS.CODPRODUTO,PRODUTOS.CODBARRA,PRODUTOS.DESCRICAO,PRODUTOS.PRECO_VENDA FROM PRODUTOS WHERE ATIVO = 'SIM'", conexaoLocal)
            daLocal.Fill(ds)

            dgProdutos.DataSource = ds.Tables(0)
        End If
        dgProdutos.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dgProdutos.Columns(1).HeaderText = "Codigo Produto"
        dgProdutos.Columns(1).Width = 70

        dgProdutos.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dgProdutos.Columns(2).HeaderText = "Codigo Barra"
        dgProdutos.Columns(2).Width = 135

        dgProdutos.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgProdutos.Columns(3).HeaderText = "Descrição"

        dgProdutos.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dgProdutos.Columns(4).HeaderText = "Preço Venda"
        dgProdutos.Columns(4).DefaultCellStyle.Format = "C2"
        dgProdutos.Columns(4).Width = 115
    End Sub
    Private Sub btnAtualizaPreco_Click(sender As Object, e As EventArgs) Handles btnAtualizaPreco.Click
        Dim sql As String
        Dim codproduto As String
        Dim preco As String = InputBox("Digite o valor")

        If preco <> "" Then
            Try
                For Each linha As DataGridViewRow In dgProdutos.Rows
                    codproduto = linha.Cells(1).Value
                    If linha.Cells(0).Value = True Then
                        If (importaProdutos = "SIM") Then
                            sql = "UPDATE ProdutosNuvem SET precovenda = @precovenda WHERE idProdutos = @idProdutos"
                            comandoNuvem = New MySqlCommand(sql, conexaoAtualiza)

                            comandoNuvem.Parameters.AddWithValue("@idProdutos", codproduto)
                            comandoNuvem.Parameters.AddWithValue("@precovenda", preco)

                            conexaoAtualiza.Close()
                            conexaoAtualiza.Open()
                            comandoNuvem.ExecuteNonQuery()
                            conexaoAtualiza.Close()
                        ElseIf (importaProdutos = "NAO") Then
                            preco = Replace(preco, ",", ".")
                            sql = "UPDATE PRODUTOS SET PRECO_VENDA = @PRECO_VENDA WHERE CODPRODUTO = @CODPRODUTO"

                            comandoLocal = New FbCommand(sql, conexaoLocal)

                            comandoLocal.Parameters.AddWithValue("@CODPRODUTO", codproduto)
                            comandoLocal.Parameters.AddWithValue("@PRECO_VENDA", preco)

                            conexaoLocal.Close()
                            conexaoLocal.Open()
                            comandoLocal.ExecuteNonQuery()
                            conexaoLocal.Close()
                        End If
                    End If
                Next
                AtualizaPreco()
                MsgBox("Preço Atualiazado com Sucesso", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox("Erro ao atualizar preço do produto: " + ex.Message)
            End Try
        End If
    End Sub

    Private Sub FrmAtualizaPreco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregaDados()
    End Sub

    Private Sub txtPesquisar_TextChanged(sender As Object, e As EventArgs) Handles txtPesquisar.TextChanged
        Dim str As String = 0
        Dim ds As New DataSet
        If (txtPesquisar.Text <> "") Then
            If (importaProdutos = "SIM") Then
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
            ElseIf (importaProdutos = "NAO") Then
                str = "SELECT PRODUTOS.CODPRODUTO,PRODUTOS.CODBARRA,PRODUTOS.DESCRICAO,PRODUTOS.PRECO_VENDA,PRODUTOS.ATIVO FROM PRODUTOS WHERE ATIVO = 'SIM'and DESCRICAO  LIKE  '%" & txtPesquisar.Text & "%'"

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
            End If

        Else
            carregaDados()
        End If
    End Sub
End Class