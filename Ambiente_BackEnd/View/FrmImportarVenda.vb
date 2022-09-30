Imports FirebirdSql.Data.FirebirdClient

Public Class FrmImportarVenda
    Private Sub dgProdutosVendidos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgProdutosVendidos.CellContentDoubleClick
        Dim str As String
        Dim currentRow As DataGridViewRow = dgProdutosVendidos.Rows(e.RowIndex)
        Dim ds As New DataSet
        str = "SELECT * FROM MOVIMENTO_ITEM WHERE CODORCAMENTO = " & currentRow.Cells(0).Value.ToString() & "and CODABERTURA = " & currentRow.Cells(1).Value.ToString()
        If (conexaoLocal.State <> ConnectionState.Closed) Then
            conexaoLocal.Close()
        End If

        daLocal = New FbDataAdapter(str, conexaoLocal)

        daLocal.Fill(ds)
        dgMovimentoItem.DataSource = ds.Tables(0)


        For Each col As DataGridViewRow In dgMovimentoItem.Rows
            Dim quantidade As Decimal = CDec(col.Cells(3).Value)
            Dim valorUnitario As Decimal = CDec(col.Cells(4).Value)
            Dim totalItem As Decimal = CDec(col.Cells(5).Value)
            Dim strProdutos As String
            strProdutos = "SELECT * FROM PRODUTOS WHERE CODBARRA = '" & col.Cells(1).Value & "'"

            conexaoLocal.Close()
            conexaoLocal.ConnectionString = bancoLocal
            conexaoLocal.Open()

            Dim cmdProduto As FbCommand = New FbCommand(strProdutos, conexaoLocal)
            drLocal = cmdProduto.ExecuteReader

            While drLocal.Read()

                FrmNotaFiscalEletronica.dgNotaFiscal.Rows.Add(drLocal("CODPRODUTO").ToString, drLocal("DESCRICAO").ToString, drLocal("CODCFOP").ToString, drLocal("CODCSOSN").ToString, drLocal("NCM").ToString, "", quantidade, valorUnitario, totalItem)
            End While
        Next
        Close()
        '        FrmLancarProduto.ShowDialog()

    End Sub
    Private Sub btnPesqusiar_Click(sender As Object, e As EventArgs) Handles btnPesqusiar.Click
        Dim ds As New DataSet
        Dim periodoConverte As String
        Dim ateConverte As String

        periodoConverte = Replace("'" & txtperiodo.Text & "'", "/", ".")
        ateConverte = Replace("'" & txtate.Text & "'", "/", ".")

        Try
            If (txtCodigoFormaPagto.Text = "" And cbxTipo.Text = "" And periodoConverte = "'  .  .'") Then
                daLocal = New FbDataAdapter("SELECT V.CODORCAMENTO,V.CODABERTURA,V.CODVENDA,V.CODCAIXA,V.OPERADOR,V.DATA,V.HORA,V.FORMAPAGTO,V.TOTALMOVIMENTO FROM MOVIMENTO_VENDA V WHERE FINALIZADO = 'S'", conexaoLocal)
            ElseIf (txtCodigoFormaPagto.Text <> "" And cbxTipo.Text = "" And periodoConverte = "'  .  .'") Then
                daLocal = New FbDataAdapter("SELECT V.CODORCAMENTO,V.CODABERTURA,V.CODVENDA,V.CODCAIXA,V.OPERADOR,V.DATA,V.HORA,V.FORMAPAGTO,V.TOTALMOVIMENTO FROM MOVIMENTO_VENDA V WHERE FINALIZADO = 'S' and FORMAPAGTO = " & txtCodigoFormaPagto.Text, conexaoLocal)
            ElseIf (txtCodigoFormaPagto.Text = "" And cbxTipo.Text <> "" And periodoConverte = "'  .  .'") Then
                If (cbxTipo.Text = "Orçamento") Then
                    daLocal = New FbDataAdapter("SELECT V.CODORCAMENTO,V.CODABERTURA,V.CODVENDA,V.CODCAIXA,V.OPERADOR,V.DATA,V.HORA,V.FORMAPAGTO,V.TOTALMOVIMENTO FROM MOVIMENTO_VENDA V WHERE FINALIZADO = 'S' and CODVENDA is null", conexaoLocal)
                ElseIf (cbxTipo.Text = "Venda") Then
                    daLocal = New FbDataAdapter("SELECT V.CODORCAMENTO,V.CODABERTURA,V.CODVENDA,V.CODCAIXA,V.OPERADOR,V.DATA,V.HORA,V.FORMAPAGTO,V.TOTALMOVIMENTO FROM MOVIMENTO_VENDA V WHERE FINALIZADO = 'S' and CODVENDA is not null", conexaoLocal)
                End If
            ElseIf (txtCodigoFormaPagto.Text = "" And cbxTipo.Text = "" And periodoConverte <> "'  .  .'") Then
                daLocal = New FbDataAdapter("SELECT V.CODORCAMENTO,V.CODABERTURA,V.CODVENDA,V.CODCAIXA,V.OPERADOR,V.DATA,V.HORA,V.FORMAPAGTO,V.TOTALMOVIMENTO FROM MOVIMENTO_VENDA V WHERE FINALIZADO = 'S' and DATA BETWEEN " & periodoConverte & " and " & ateConverte, conexaoLocal)
            ElseIf (txtCodigoFormaPagto.Text <> "" And cbxTipo.Text <> "" And periodoConverte = "'  .  .'") Then
                If (cbxTipo.Text = "Orçamento") Then
                    daLocal = New FbDataAdapter("SELECT V.CODORCAMENTO,V.CODABERTURA,V.CODABERTURA,V.CODVENDA,V.CODCAIXA,V.OPERADOR,V.DATA,V.HORA,V.FORMAPAGTO,V.TOTALMOVIMENTO FROM MOVIMENTO_VENDA V WHERE FINALIZADO = 'S' and FORMAPAGTO = " & txtCodigoFormaPagto.Text & " and CODVENDA is null", conexaoLocal)
                ElseIf (cbxTipo.Text = "Venda") Then
                    daLocal = New FbDataAdapter("SELECT V.CODORCAMENTO,V.CODABERTURA,V.CODVENDA,V.CODCAIXA,V.OPERADOR,V.DATA,V.HORA,V.FORMAPAGTO,V.TOTALMOVIMENTO FROM MOVIMENTO_VENDA V WHERE FINALIZADO = 'S' and FORMAPAGTO = " & txtCodigoFormaPagto.Text & " and CODVENDA is not null", conexaoLocal)
                End If
            ElseIf (txtCodigoFormaPagto.Text <> "" And cbxTipo.Text = "" And periodoConverte <> "'  .  .'") Then
                daLocal = New FbDataAdapter("SELECT V.CODORCAMENTO,V.CODABERTURA,V.CODVENDA,V.CODCAIXA,V.OPERADOR,V.DATA,V.HORA,V.FORMAPAGTO,V.TOTALMOVIMENTO FROM MOVIMENTO_VENDA V WHERE FINALIZADO = 'S' and FORMAPAGTO = " & txtCodigoFormaPagto.Text & " and DATA BETWEEN " & periodoConverte & " and " & ateConverte, conexaoLocal)
            ElseIf (txtCodigoFormaPagto.Text = "" And cbxTipo.Text <> "" And periodoConverte <> "'  .  .'") Then
                If (cbxTipo.Text = "Orçamento") Then
                    daLocal = New FbDataAdapter("SELECT V.CODORCAMENTO,V.CODABERTURA,V.CODVENDA,V.CODCAIXA,V.OPERADOR,V.DATA,V.HORA,V.FORMAPAGTO,V.TOTALMOVIMENTO FROM MOVIMENTO_VENDA V WHERE FINALIZADO = 'S' and DATA BETWEEN " & periodoConverte & " and " & ateConverte & " and CODVENDA is null", conexaoLocal)
                ElseIf (cbxTipo.Text = "Venda") Then
                    daLocal = New FbDataAdapter("SELECT V.CODORCAMENTO,V.CODABERTURA,V.CODVENDA,V.CODCAIXA,V.OPERADOR,V.DATA,V.HORA,V.FORMAPAGTO,V.TOTALMOVIMENTO FROM MOVIMENTO_VENDA V WHERE FINALIZADO = 'S' and DATA BETWEEN " & periodoConverte & " and " & ateConverte & " and CODVENDA is not null", conexaoLocal)
                End If
            ElseIf (txtCodigoFormaPagto.Text <> "" And cbxTipo.Text <> "" And periodoConverte <> "'  .  .'") Then
                If (cbxTipo.Text = "Orçamento") Then
                    daLocal = New FbDataAdapter("SELECT V.CODORCAMENTO,V.CODABERTURA,V.CODVENDA,V.CODCAIXA,V.OPERADOR,V.DATA,V.HORA,V.FORMAPAGTO,V.TOTALMOVIMENTO FROM MOVIMENTO_VENDA V WHERE FINALIZADO = 'S' and FORMAPAGTO = " & txtCodigoFormaPagto.Text & " and DATA BETWEEN " & periodoConverte & " and " & ateConverte & " and CODVENDA is null", conexaoLocal)
                ElseIf (cbxTipo.Text = "Venda") Then
                    daLocal = New FbDataAdapter("SELECT V.CODORCAMENTO,V.CODABERTURA,V.CODVENDA,V.CODCAIXA,V.OPERADOR,V.DATA,V.HORA,V.FORMAPAGTO,V.TOTALMOVIMENTO FROM MOVIMENTO_VENDA V WHERE FINALIZADO = 'S' and FORMAPAGTO = " & txtCodigoFormaPagto.Text & " and DATA BETWEEN " & periodoConverte & " and " & ateConverte & " and CODVENDA is not null", conexaoLocal)
                End If
            End If

            daLocal.Fill(ds)
            dgProdutosVendidos.DataSource = ds.Tables(0)
            If dgProdutosVendidos.RowCount = 0 Then
                MsgBox("Nenhum registro encontrado", MsgBoxStyle.Exclamation, "Aviso !")
            End If
        Catch ex As Exception
            MsgBox("Erro ao filtrar movimento: " + ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub
End Class