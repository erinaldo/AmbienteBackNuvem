Imports FirebirdSql.Data.FirebirdClient
Imports MySql.Data.MySqlClient

Public Class FrmEtiquetaNuvem
    Private Sub carregaDados()
        Dim ds As New DataSet
        daLocal = New FbDataAdapter("SELECT PRODUTOS.CODPRODUTO,PRODUTOS.CODBARRA,PRODUTOS.DESCRICAO,PRODUTOS.PRECO_VENDA,PRODUTOS.ATIVO FROM PRODUTOS WHERE ATIVO = 'SIM' and ETIQUETASNUVEM = 'SIM'", conexaoLocal)
        daLocal.Fill(ds)

        dgProdutos.DataSource = ds.Tables(0)
    End Sub
    Public Sub AtualizaEtiqueta()
        Dim sql As String
        For Each col As DataGridViewRow In dgProdutos.Rows
            sql = "UPDATE PRODUTOS SET GERAETIQUETA = @GERAETIQUETA WHERE CODPRODUTO = @CODPRODUTO"

            comandoLocal = New FbCommand(sql, conexaoLocal)

            comandoLocal.Parameters.AddWithValue("@CODPRODUTO", col.Cells(0).Value)
            comandoLocal.Parameters.AddWithValue("@GERAETIQUETA", "SIM")

            conexaoLocal.Close()
            conexaoLocal.Open()
            comandoLocal.ExecuteNonQuery()
            conexaoLocal.Close()

            Dim ds As New DataSet
            daLocal = New FbDataAdapter("SELECT PRODUTOS.CODPRODUTO,PRODUTOS.CODBARRA,PRODUTOS.DESCRICAO,PRODUTOS.PRECO_VENDA,PRODUTOS.ATIVO FROM PRODUTOS WHERE GERAETIQUETA = 'SIM' and ATIVO = 'SIM'", conexaoLocal)
            daLocal.Fill(ds)
        Next
    End Sub
    Private Sub txtPesquisar_TextChanged(sender As Object, e As EventArgs) Handles txtPesquisar.TextChanged
        Dim str As String = 0
        Dim ds As New DataSet
        If (txtPesquisar.Text <> "") Then
            str = "SELECT PRODUTOS.CODPRODUTO,PRODUTOS.CODBARRA,PRODUTOS.DESCRICAO,PRODUTOS.PRECO_VENDA,PRODUTOS.ATIVO FROM PRODUTOS WHERE ATIVO = 'SIM' and ETIQUETASNUVEM = 'SIM' and CODBARRA = '" + txtPesquisar.Text + "'"

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
    Public Sub AtualizaEtiquetaNuvem()
        Dim sql As String
        Dim condicao As String = "etiquetaloja" + LerIni("Dados", "Loja")
        sql = "UPDATE ProdutosNuvem Set " & condicao & " = @" & condicao

        comandoNuvem = New MySqlCommand(sql, conexaoAtualiza)

        comandoNuvem.Parameters.AddWithValue("@" + condicao, "")

        conexaoAtualiza.Close()
        conexaoAtualiza.Open()
        comandoNuvem.ExecuteNonQuery()
        conexaoAtualiza.Close()
        conexaoAtualiza.Open()
    End Sub
    Private Sub btnConfimarEtiqueta_Click(sender As Object, e As EventArgs) Handles btnConfimarEtiqueta.Click
        If MessageBox.Show("ETIQUETAS FORAM ATUALIZADAS COM SUCESSO?", "Ambiente Soft", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = vbYes Then
            Dim sql As String

            AtualizaEtiquetaNuvem()
            Try

                sql = "UPDATE PRODUTOS SET GERAETIQUETA = @GERAETIQUETA,ETIQUETASNUVEM = @ETIQUETASNUVEM WHERE GERAETIQUETA = 'SIM'"

                comandoLocal = New FbCommand(sql, conexaoLocal)

                comandoLocal.Parameters.AddWithValue("@GERAETIQUETA", "NAO")
                comandoLocal.Parameters.AddWithValue("@ETIQUETASNUVEM", "NAO")

                conexaoLocal.Close()
                conexaoLocal.Open()
                comandoLocal.ExecuteNonQuery()
                conexaoLocal.Close()

                MsgBox("Efetuado com Sucesso", MsgBoxStyle.Information, "Ambiente Soft")
                Close()
            Catch ex As Exception
                MsgBox("Erro ao confirmar: " + ex.Message, MsgBoxStyle.Critical)
            End Try
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnGerarEtiqueta_Click(sender As Object, e As EventArgs) Handles btnGerarEtiqueta.Click
        AtualizaEtiqueta()
        FrmRelEtiqueta.ShowDialog()
    End Sub

    Private Sub FrmEtiquetaNuvem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregaDados()
    End Sub
End Class