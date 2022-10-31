Imports FirebirdSql.Data.FirebirdClient
Imports Org.BouncyCastle.X509

Public Class FrmAgruparPendencias
    Dim codCliente As String
    Dim codAgrupa As String
    Private Sub IniciarNota()
        FrmNotaFiscalEletronica.tipoFuncao = "2"
        FrmNotaFiscalEletronica.btnNovaNota.PerformClick()
        FrmNotaFiscalEletronica.txtCodCliente.Text = codCliente

        For Each linha As DataGridViewRow In dgVales.Rows
            If linha.Cells(0).Value = True Then
                Dim strItens As String
                Dim dsItens As New DataSet

                strItens = "SELECT * FROM DEBITO_ITEM WHERE CODORCAMENTO =" & linha.Cells(2).Value & "and CODCAIXA =" & linha.Cells(4).Value & "and CODABERTURA =" & linha.Cells(3).Value

                If (conexaoLocal.State <> ConnectionState.Closed) Then
                    conexaoLocal.Close()
                End If

                daLocal = New FbDataAdapter(strItens, conexaoLocal)
                daLocal.Fill(dsItens)
                dgMovimentoItem.DataSource = dsItens.Tables(0)

                For Each linha1 As DataGridViewRow In dgMovimentoItem.Rows
                    Dim precoVenda As Decimal = linha1.Cells(4).Value
                    Dim quantidade As Decimal = linha1.Cells(3).Value
                    Dim totalItem As Decimal = linha1.Cells(5).Value
                    Dim strProdutos As String
                    strProdutos = "SELECT * FROM PRODUTOS WHERE CODBARRA = '" & linha1.Cells(6).Value & "'"

                    conexaoLocal.Close()
                    conexaoLocal.ConnectionString = bancoLocal
                    conexaoLocal.Open()

                    Dim cmdItens As FbCommand = New FbCommand(strProdutos, conexaoLocal)
                    drLocal = cmdItens.ExecuteReader

                    While drLocal.Read()
                        FrmNotaFiscalEletronica.dgNotaFiscal.Rows.Add(drLocal("CODPRODUTO").ToString, drLocal("DESCRICAO").ToString, drLocal("CODCFOP").ToString, drLocal("CODCSOSN").ToString, drLocal("NCM").ToString, "", precoVenda, quantidade, totalItem)
                    End While
                Next
            End If
        Next
        Close()
        FrmNotaFiscalEletronica.ShowDialog()
    End Sub
    Private Sub btnAgrupar_Click(sender As Object, e As EventArgs) Handles btnAgrupar.Click
        Dim codCaixa As String = LerIni("Dados", "Caixa")
        Dim sql As String
        Dim dataatual As String
        Dim horaatual As String
        Dim dataHoje As DateTime = DateTime.Now
        dataatual = FormatDateTime(dataHoje, DateFormat.ShortDate)
        horaatual = FormatDateTime(dataHoje, DateFormat.ShortTime)

        dataatual = Replace(dataatual, "/", "")
        horaatual = Replace(horaatual, ":", "")

        codAgrupa = dataatual + horaatual
        If MessageBox.Show("Deseja Agrupar Pendências Selecionadas?", "Ambiente Soft", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            For Each linha As DataGridViewRow In dgVales.Rows
                If linha.Cells(0).Value = True Then
                    codCliente = linha.Cells(5).Value
                    Try

                        sql = "UPDATE DEBITO SET NUM_AGRUPA = @NUM_AGRUPA WHERE CODCAIXA = @CODCAIXA and CODORCAMENTO = @CODORCAMENTO and CODABERTURA = @CODABERTURA"
                        comandoLocal = New FbCommand(sql, conexaoLocal)

                        comandoLocal.Parameters.AddWithValue("@CODORCAMENTO", linha.Cells(2).Value)
                        comandoLocal.Parameters.AddWithValue("@CODCAIXA", linha.Cells(4).Value)
                        comandoLocal.Parameters.AddWithValue("@CODABERTURA", linha.Cells(3).Value)
                        comandoLocal.Parameters.AddWithValue("@NUM_AGRUPA", codAgrupa)

                        conexaoLocal.Close()
                        conexaoLocal.Open()
                        comandoLocal.ExecuteNonQuery()
                        conexaoLocal.Close()
                    Catch ex As Exception
                        MsgBox("Erro: " + ex.Message, MsgBoxStyle.Exclamation)
                        Exit Sub
                    End Try
                End If
            Next
            IniciarNota()
        Else

        End If
    End Sub
    Private Sub CarregaDados()
        Dim ds As New DataSet
        Dim periodoConverte As String
        Dim ateConverte As String
        Dim str As String
        periodoConverte = Replace("'" & txtperiodo.Text & "'", "/", ".")
        ateConverte = Replace("'" & txtate.Text & "'", "/", ".")
        If (txtCodigoCliente.Text <> "" And periodoConverte = "'  .  .'") Then
            daLocal = New FbDataAdapter("SELECT D.CODDEBITO,D.CODORCAMENTO,D.CODABERTURA, D.CODCAIXA, D.CODCLIENTE,C.RAZAOSOCIAL,D.DATA,D.TOTAL AS D FROM DEBITO AS D JOIN COLABORADOR AS C ON ( C.CODCOLABORADOR = D.CODCLIENTE ) WHERE D.CODCLIENTE = " & txtCodigoCliente.Text & " and D.TIPO = 'COMPRA' GROUP BY  D.CODDEBITO,D.CODORCAMENTO,D.CODABERTURA, D.CODCAIXA, D.CODCLIENTE,C.RAZAOSOCIAL,D.DATA,D.TOTAL ORDER BY D.CODORCAMENTO DESC", conexaoLocal)
        ElseIf (txtCodigoCliente.Text <> "" AndAlso periodoConverte <> "'  .  .'") Then
            daLocal = New FbDataAdapter("SELECT  D.CODDEBITO,D.CODORCAMENTO,D.CODABERTURA, D.CODCAIXA, D.CODCLIENTE,C.RAZAOSOCIAL,D.DATA,D.TOTAL AS D FROM DEBITO AS D JOIN COLABORADOR AS C ON ( C.CODCOLABORADOR = D.CODCLIENTE ) WHERE D.CODCLIENTE = " & txtCodigoCliente.Text & " and D.DATA BETWEEN " & periodoConverte & " AND " & ateConverte & " and D.TIPO = 'COMPRA' GROUP BY  D.CODDEBITO,D.CODORCAMENTO,D.CODABERTURA, D.CODCAIXA, D.CODCLIENTE,C.RAZAOSOCIAL,D.DATA,D.TOTAL ORDER BY D.CODORCAMENTO DESC", conexaoLocal)
        ElseIf (periodoConverte <> "'  .  .'" And txtCodigoCliente.Text = "") Then
            daLocal = New FbDataAdapter("SELECT  D.CODDEBITO,D.CODORCAMENTO,D.CODABERTURA,D.CODCAIXA, D.CODCLIENTE,C.RAZAOSOCIAL,D.DATA,D.TOTAL AS D FROM DEBITO AS D JOIN COLABORADOR AS C ON ( C.CODCOLABORADOR = D.CODCLIENTE ) WHERE D.DATA BETWEEN " & periodoConverte & " AND " & ateConverte & " and D.TIPO = 'COMPRA' GROUP BY  D.CODDEBITO,D.CODORCAMENTO,D.CODABERTURA, D.CODCAIXA, D.CODCLIENTE,C.RAZAOSOCIAL,D.DATA,S.TOTAL ORDER BY D.CODORCAMENTO DESC", conexaoLocal)
        ElseIf (periodoConverte = "'  .  .'" Or txtCodigoCliente.Text = "") Then
            daLocal = New FbDataAdapter("SELECT  D.CODDEBITO,D.CODORCAMENTO,D.CODABERTURA, D.CODCAIXA, D.CODCLIENTE,C.RAZAOSOCIAL,D.DATA,D.TOTAL AS D FROM DEBITO AS D JOIN COLABORADOR AS C ON ( C.CODCOLABORADOR = D.CODCLIENTE ) WHERE D.TIPO = 'COMPRA' GROUP BY  D.CODDEBITO,D.CODORCAMENTO,D.CODABERTURA, D.CODCAIXA, D.CODCLIENTE,C.RAZAOSOCIAL,D.DATA,D.TOTAL ORDER BY D.CODORCAMENTO DESC", conexaoLocal)
        End If

        daLocal.Fill(ds)
        dgVales.DataSource = ds.Tables(0)

        If dgVales.RowCount = 0 Then
            MsgBox("Nenhum registro encontrado", MsgBoxStyle.Exclamation, "Aviso !")
        End If
    End Sub

    Private Sub btnPesqusiar_Click(sender As Object, e As EventArgs) Handles btnPesqusiar.Click
        CarregaDados()
    End Sub
End Class