Imports FirebirdSql.Data.FirebirdClient

Public Class FrmEscolheEtiqueta
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String
        For Each dr As DataGridViewRow In dgProdutos.Rows

            If dr.Cells(4).Value IsNot Nothing Then
                sql = "UPDATE PRODUTOS SET GERAETIQUETA = @GERAETIQUETA WHERE CODPRODUTO = @CODPRODUTO"

                comandoLocal = New FbCommand(sql, conexaoLocal)

                comandoLocal.Parameters.AddWithValue("@CODPRODUTO", dr.Cells(4).Value)
                comandoLocal.Parameters.AddWithValue("@GERAETIQUETA", "SIM")

                conexaoLocal.Close()
                conexaoLocal.Open()
                comandoLocal.ExecuteNonQuery()
                conexaoLocal.Close()

                Dim ds As New DataSet
                daLocal = New FbDataAdapter("SELECT PRODUTOS.CODPRODUTO,PRODUTOS.CODBARRA,PRODUTOS.DESCRICAO,PRODUTOS.PRECO_VENDA,PRODUTOS.ATIVO FROM PRODUTOS WHERE GERAETIQUETA = 'SIM' and ATIVO = 'SIM'", conexaoLocal)
                daLocal.Fill(ds)


                'essageBox.Show("Linha " & dr.Cells(2).Value & " foi selecionada")
            End If
        Next
        FrmRelEtiqueta.ShowDialog()

        Close()
    End Sub

    Private Sub FrmEscolheEtiqueta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As New DataSet
        daLocal = New FbDataAdapter("SELECT PRODUTOS.CODPRODUTO,PRODUTOS.CODBARRA,PRODUTOS.DESCRICAO,PRODUTOS.PRECO_VENDA,PRODUTOS.ATIVO FROM PRODUTOS WHERE ATIVO = 'SIM'", conexaoLocal)
        daLocal.Fill(ds)

        dgProdutos.DataSource = ds.Tables(0)
    End Sub
End Class