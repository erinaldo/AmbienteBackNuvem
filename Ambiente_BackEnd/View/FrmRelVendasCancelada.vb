Imports FirebirdSql.Data.FirebirdClient

Public Class FrmRelVendasCancelada
    Private FormasPagamento As Dictionary(Of String, String)
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limparTextBoxes(Me)
        btnPesqusiar.PerformClick()
    End Sub
    Public Sub calculaTotal()
        Dim valor As Decimal

        For Each col As DataGridViewRow In dgProdutosVendidos.Rows
            valor = valor + col.Cells(7).Value
        Next

        lblTotal.Text = valor
        lblTotal.Text = valor
        lblTotal.Text = FormatCurrency(lblTotal.Text, 2)
    End Sub

    Private Sub btnPesqusiar_Click(sender As Object, e As EventArgs) Handles btnPesqusiar.Click
        Dim ds As New DataSet
        Dim periodoConverte As String
        Dim ateConverte As String

        periodoConverte = Replace("'" & txtperiodo.Text & "'", "/", ".")
        ateConverte = Replace("'" & txtate.Text & "'", "/", ".")

        Try
            If (txtCodigoFormaPagto.Text = "" And cbxTipo.Text = "" And periodoConverte = "'  .  .'" And cbxTipoCartao.Text = "") Then
                daLocal = New FbDataAdapter("SELECT V.CODMOVIMENTO,V.CODVENDA,V.CODCAIXA,V.OPERADOR,V.DATA,V.HORA,V.MOTIVOCANCEL,V.FORMAPAGTO,V.TOTALMOVIMENTO FROM MOVIMENTO_VENDA V WHERE FINALIZADO = 'S' and CANCELADA = 'SIM'", conexaoLocal)
            ElseIf (txtCodigoFormaPagto.Text <> "" And cbxTipo.Text = "" And periodoConverte = "'  .  .'" And cbxTipoCartao.Text = "") Then
                daLocal = New FbDataAdapter("SELECT V.CODMOVIMENTO,V.CODVENDA,V.CODCAIXA,V.OPERADOR,V.DATA,V.HORA,V.MOTIVOCANCEL,V.FORMAPAGTO,V.TOTALMOVIMENTO FROM MOVIMENTO_VENDA V WHERE FINALIZADO = 'S' and FORMAPAGTO = " & txtCodigoFormaPagto.Text & " and CANCELADA = 'SIM'", conexaoLocal)
            ElseIf (txtCodigoFormaPagto.Text = "" And cbxTipo.Text <> "" And periodoConverte = "'  .  .'" And cbxTipoCartao.Text = "") Then
                If (cbxTipo.Text = "Orçamento") Then
                    daLocal = New FbDataAdapter("SELECT V.CODMOVIMENTO,V.CODVENDA,V.CODCAIXA,V.OPERADOR,V.DATA,V.HORA,V.MOTIVOCANCEL,V.FORMAPAGTO,V.TOTALMOVIMENTO FROM MOVIMENTO_VENDA V WHERE FINALIZADO = 'S' and CODVENDA is null and CANCELADA = 'SIM'", conexaoLocal)
                ElseIf (cbxTipo.Text = "Venda") Then
                    daLocal = New FbDataAdapter("SELECT V.CODMOVIMENTO,V.CODVENDA,V.CODCAIXA,V.OPERADOR,V.DATA,V.HORA,V.MOTIVOCANCEL,V.FORMAPAGTO,V.TOTALMOVIMENTO FROM MOVIMENTO_VENDA V WHERE FINALIZADO = 'S' and CODVENDA is not null  and CANCELADA = 'SIM'", conexaoLocal)
                End If
            ElseIf (txtCodigoFormaPagto.Text = "" And cbxTipo.Text <> "" And periodoConverte = "'  .  .'" And cbxTipoCartao.Text <> "") Then
                If (cbxTipoCartao.Text = "Debito") Then
                    daLocal = New FbDataAdapter("SELECT V.CODMOVIMENTO,V.CODVENDA,V.CODCAIXA,V.OPERADOR,V.DATA,V.HORA,V.MOTIVOCANCEL,V.FORMAPAGTO,V.TOTALMOVIMENTO FROM MOVIMENTO_VENDA V WHERE FINALIZADO = 'S' and FORMAPAGTO = '3' and OPERADORA = '2'  and CANCELADA = 'SIM'", conexaoLocal)
                ElseIf (cbxTipoCartao.Text = "Credito") Then
                    daLocal = New FbDataAdapter("SELECT V.CODMOVIMENTO,V.CODVENDA,V.CODCAIXA,V.OPERADOR,V.DATA,V.HORA,V.MOTIVOCANCEL,V.FORMAPAGTO,V.TOTALMOVIMENTO FROM MOVIMENTO_VENDA V WHERE FINALIZADO = 'S' and FORMAPAGTO = '3' and OPERADORA = '1'  and CANCELADA = 'SIM'", conexaoLocal)
                End If
            ElseIf (txtCodigoFormaPagto.Text = "" And cbxTipo.Text = "" And periodoConverte <> "'  .  .'" And cbxTipoCartao.Text = "") Then
                daLocal = New FbDataAdapter("SELECT V.CODMOVIMENTO,V.CODVENDA,V.CODCAIXA,V.OPERADOR,V.DATA,V.HORA,V.MOTIVOCANCEL,V.FORMAPAGTO,V.TOTALMOVIMENTO FROM MOVIMENTO_VENDA V WHERE FINALIZADO = 'S' and DATA BETWEEN " & periodoConverte & " and " & ateConverte & " and CANCELADA = 'SIM'", conexaoLocal)
            ElseIf (txtCodigoFormaPagto.Text = "" And cbxTipo.Text = "" And periodoConverte = "'  .  .'" And cbxTipoCartao.Text <> "") Then
                If (cbxTipoCartao.Text = "Debito") Then
                    daLocal = New FbDataAdapter("SELECT V.CODMOVIMENTO,V.CODVENDA,V.CODCAIXA,V.OPERADOR,V.DATA,V.HORA,V.MOTIVOCANCEL,V.FORMAPAGTO,V.TOTALMOVIMENTO FROM MOVIMENTO_VENDA V WHERE FINALIZADO = 'S' and FORMAPAGTO = '3' and OPERADORA = '2' and CANCELADA = 'SIM'", conexaoLocal)
                ElseIf (cbxTipoCartao.Text = "Credito") Then
                    daLocal = New FbDataAdapter("SELECT V.CODMOVIMENTO,V.CODVENDA,V.CODCAIXA,V.OPERADOR,V.DATA,V.HORA,V.MOTIVOCANCEL,V.FORMAPAGTO,V.TOTALMOVIMENTO FROM MOVIMENTO_VENDA V WHERE FINALIZADO = 'S' and FORMAPAGTO = '3' and OPERADORA = '1' and CANCELADA = 'SIM'", conexaoLocal)
                End If
            ElseIf (txtCodigoFormaPagto.Text <> "" And cbxTipo.Text <> "" And periodoConverte = "'  .  .'" And cbxTipoCartao.Text = "") Then
                If (cbxTipo.Text = "Orçamento") Then
                    daLocal = New FbDataAdapter("SELECT V.CODMOVIMENTO,V.CODVENDA,V.CODCAIXA,V.OPERADOR,V.DATA,V.HORA,V.MOTIVOCANCEL,V.FORMAPAGTO,V.TOTALMOVIMENTO FROM MOVIMENTO_VENDA V WHERE FINALIZADO = 'S' and FORMAPAGTO = " & txtCodigoFormaPagto.Text & " and CODVENDA is null and CANCELADA = 'SIM'", conexaoLocal)
                ElseIf (cbxTipo.Text = "Venda") Then
                    daLocal = New FbDataAdapter("SELECT V.CODMOVIMENTO,V.CODVENDA,V.CODCAIXA,V.OPERADOR,V.DATA,V.HORA,V.MOTIVOCANCEL,V.FORMAPAGTO,V.TOTALMOVIMENTO FROM MOVIMENTO_VENDA V WHERE FINALIZADO = 'S' and FORMAPAGTO = " & txtCodigoFormaPagto.Text & " and CODVENDA is not null and CANCELADA = 'SIM'", conexaoLocal)
                End If
            ElseIf (txtCodigoFormaPagto.Text <> "" And cbxTipo.Text = "" And periodoConverte <> "'  .  .'" And cbxTipoCartao.Text = "") Then
                daLocal = New FbDataAdapter("SELECT V.CODMOVIMENTO,V.CODVENDA,V.CODCAIXA,V.OPERADOR,V.DATA,V.HORA,V.MOTIVOCANCEL,V.FORMAPAGTO,V.TOTALMOVIMENTO FROM MOVIMENTO_VENDA V WHERE FINALIZADO = 'S' and FORMAPAGTO = " & txtCodigoFormaPagto.Text & " and DATA BETWEEN " & periodoConverte & " and " & ateConverte & " and CANCELADA = 'SIM'", conexaoLocal)
            ElseIf (txtCodigoFormaPagto.Text = "" And cbxTipo.Text <> "" And periodoConverte <> "'  .  .'" And cbxTipoCartao.Text = "") Then
                If (cbxTipo.Text = "Orçamento") Then
                    daLocal = New FbDataAdapter("SELECT V.CODMOVIMENTO,V.CODVENDA,V.CODCAIXA,V.OPERADOR,V.DATA,V.HORA,V.MOTIVOCANCEL,V.FORMAPAGTO,V.TOTALMOVIMENTO FROM MOVIMENTO_VENDA V WHERE FINALIZADO = 'S' and DATA BETWEEN " & periodoConverte & " and " & ateConverte & " and CODVENDA is null and CANCELADA = 'SIM'", conexaoLocal)
                ElseIf (cbxTipo.Text = "Venda") Then
                    daLocal = New FbDataAdapter("SELECT V.CODMOVIMENTO,V.CODVENDA,V.CODCAIXA,V.OPERADOR,V.DATA,V.HORA,V.MOTIVOCANCEL,V.FORMAPAGTO,V.TOTALMOVIMENTO FROM MOVIMENTO_VENDA V WHERE FINALIZADO = 'S' and DATA BETWEEN " & periodoConverte & " and " & ateConverte & " and CODVENDA is not null and CANCELADA = 'SIM'", conexaoLocal)
                End If
            ElseIf (txtCodigoFormaPagto.Text <> "" And cbxTipo.Text <> "" And periodoConverte <> "'  .  .'" And cbxTipoCartao.Text = "") Then
                If (cbxTipo.Text = "Orçamento") Then
                    daLocal = New FbDataAdapter("SELECT V.CODMOVIMENTO,V.CODVENDA,V.CODCAIXA,V.OPERADOR,V.DATA,V.HORA,V.MOTIVOCANCEL,V.FORMAPAGTO,V.TOTALMOVIMENTO FROM MOVIMENTO_VENDA V WHERE FINALIZADO = 'S' and FORMAPAGTO = " & txtCodigoFormaPagto.Text & " and DATA BETWEEN " & periodoConverte & " and " & ateConverte & " and CODVENDA is null and CANCELADA = 'SIM'", conexaoLocal)
                ElseIf (cbxTipo.Text = "Venda") Then
                    daLocal = New FbDataAdapter("SELECT V.CODMOVIMENTO,V.CODVENDA,V.CODCAIXA,V.OPERADOR,V.DATA,V.HORA,V.MOTIVOCANCEL,V.FORMAPAGTO,V.TOTALMOVIMENTO FROM MOVIMENTO_VENDA V WHERE FINALIZADO = 'S' and FORMAPAGTO = " & txtCodigoFormaPagto.Text & " and DATA BETWEEN " & periodoConverte & " and " & ateConverte & " and CODVENDA is not null and CANCELADA = 'SIM'", conexaoLocal)
                End If
            ElseIf (txtCodigoFormaPagto.Text = "" And cbxTipo.Text <> "" And periodoConverte <> "'  .  .'" And cbxTipoCartao.Text <> "") Then
                If (cbxTipo.Text = "Orçamento") Then
                    If (cbxTipoCartao.Text = "Debito") Then
                        daLocal = New FbDataAdapter("SELECT V.CODMOVIMENTO,V.CODVENDA,V.CODCAIXA,V.OPERADOR,V.DATA,V.HORA,V.MOTIVOCANCEL,V.FORMAPAGTO,V.TOTALMOVIMENTO FROM MOVIMENTO_VENDA V WHERE FINALIZADO = 'S' and DATA BETWEEN " & periodoConverte & " and " & ateConverte & " and CODVENDA is null and OPERADORA = '2' and CANCELADA = 'SIM'", conexaoLocal)
                    ElseIf (cbxTipoCartao.Text = "Credito") Then
                        daLocal = New FbDataAdapter("SELECT V.CODMOVIMENTO,V.CODVENDA,V.CODCAIXA,V.OPERADOR,V.DATA,V.HORA,V.MOTIVOCANCEL,V.FORMAPAGTO,V.TOTALMOVIMENTO FROM MOVIMENTO_VENDA V WHERE FINALIZADO = 'S' and DATA BETWEEN " & periodoConverte & " and " & ateConverte & " and CODVENDA is null and OPERADORA = '1' and CANCELADA = 'SIM'", conexaoLocal)
                    End If
                ElseIf (cbxTipo.Text = "Venda") Then
                    If (cbxTipoCartao.Text = "Debito") Then
                        daLocal = New FbDataAdapter("SELECT V.CODMOVIMENTO,V.CODVENDA,V.CODCAIXA,V.OPERADOR,V.DATA,V.HORA,V.MOTIVOCANCEL,V.FORMAPAGTO,V.TOTALMOVIMENTO FROM MOVIMENTO_VENDA V WHERE FINALIZADO = 'S' and DATA BETWEEN " & periodoConverte & " and " & ateConverte & " and CODVENDA is null and OPERADORA = '2' and CANCELADA = 'SIM'", conexaoLocal)
                    ElseIf (cbxTipoCartao.Text = "Credito") Then
                        daLocal = New FbDataAdapter("SELECT V.CODMOVIMENTO,V.CODVENDA,V.CODCAIXA,V.OPERADOR,V.DATA,V.HORA,V.MOTIVOCANCEL,V.FORMAPAGTO,V.TOTALMOVIMENTO FROM MOVIMENTO_VENDA V WHERE FINALIZADO = 'S' and DATA BETWEEN " & periodoConverte & " and " & ateConverte & " and CODVENDA is null and OPERADORA = '1' and CANCELADA = 'SIM'", conexaoLocal)
                    End If
                End If
            End If
            daLocal.Fill(ds)
            dgProdutosVendidos.DataSource = ds.Tables(0)
            calculaTotal()
            If dgProdutosVendidos.RowCount = 0 Then
                MsgBox("Nenhum registro encontrado", MsgBoxStyle.Exclamation, "Aviso !")
            End If
        Catch ex As Exception
            MsgBox("Erro ao filtrar movimento: " + ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Close()
    End Sub

    Private Sub cbxFormaPagamento_Enter(sender As Object, e As EventArgs) Handles cbxFormaPagamento.Enter
        FormasPagamento = New Dictionary(Of String, String) From {
          {"1", "Dinheiro"},
          {"2", "Prazo"},
          {"3", "Cartão"},
          {"5", "Pix"},
          {"6", "Desmembrado"}
      }

        cbxFormaPagamento.DataSource = New BindingSource(FormasPagamento, Nothing)
        cbxFormaPagamento.ValueMember = "Key"
        cbxFormaPagamento.DisplayMember = "Value"
    End Sub

    Private Sub cbxFormaPagamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxFormaPagamento.SelectedIndexChanged
        txtCodigoFormaPagto.Text = (CType(cbxFormaPagamento.SelectedItem, KeyValuePair(Of String, String)).Key)
    End Sub
End Class