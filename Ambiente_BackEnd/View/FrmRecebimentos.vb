Imports FirebirdSql.Data.FirebirdClient

Public Class FrmRecebimentos
    Public codAbertura As String
    Public codCaixa As String = LerIni("Dados", "Caixa")
    Public codFuncionario As String
    Dim dataAtual As String
    Private Sub Verificacaixa(codFuncionario As String)
        Dim fechado As String
        Dim dataAbertura As String
        Try
            Dim str As String

            str = "SELECT * FROM CAIXA_MOVIMENTO WHERE CODCAIXA = " & codCaixa & " AND FECHADO = 'N' "
            conexaoLocal.Close()
            conexaoLocal.Open()

            Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)

            drLocal = cmd.ExecuteReader
            While drLocal.Read()
                fechado = drLocal("FECHADO").ToString
                dataAbertura = drLocal("DATA_ABERTURA").ToString
                codAbertura = drLocal("CODCAIXAABERTURA").ToString
            End While
            If (fechado = "N") Then
                dataAbertura = Mid(dataAbertura, 1, 10)
                If (dataAbertura <> dataAtual) Then
                    MsgBox("o caixa é do dia " & dataAbertura & " feche-o antes de continuar", MsgBoxStyle.Information, "Ambiente Informa")
                    Close()
                    Exit Sub
                End If
            Else
                MsgBox("o caixa esta fechado!", MsgBoxStyle.Information, "Ambiente Informa")
                Close()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
    Private Function pegaCodAbertura()
        Dim str As String
        Try
            str = "SELECT * FROM CAIXA_MOVIMENTO WHERE FECHADO = 'N' and CODCAIXA = '" + codCaixa + "'"

            conexaoLocal.Close()
            conexaoLocal.Open()

            Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)

            drLocal = cmd.ExecuteReader
            While drLocal.Read()
                codAbertura = drLocal("CODCAIXAABERTURA").ToString
            End While
        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Function
    Public Function calculaTotal()
        Dim str As String
        Try
            str = "SELECT SUM(TOTAL) AS TOTAL FROM DEBITO WHERE CANCELADO is null and CODCLIENTE = " & lblcodigocliente.Text

            conexaoLocal.Close()
            conexaoLocal.ConnectionString = bancoLocal
            conexaoLocal.Open()

            Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)
            drLocal = cmd.ExecuteReader

            While drLocal.Read
                nTotal.Value = drLocal("TOTAL").ToString
                txtTotal.Text = FormatCurrency(nTotal.Value, 2)
            End While
        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Function
    Private Function verificaPendencias()
        Dim str As String
        Try
            If (lblcodigocliente.Text <> "..") Then

                str = "SELECT DEBITO.CODORCAMENTO,DEBITO.CODCAIXA,DEBITO.CODCLIENTE,DEBITO.DATA,DEBITO.TOTAL,DEBITO.TIPO FROM DEBITO WHERE DEBITO.CANCELADO is null and CODCLIENTE = " & lblcodigocliente.Text

                conexaoLocal.Close()
                conexaoLocal.ConnectionString = bancoLocal
                conexaoLocal.Open()

                Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)
                Dim da As FbDataAdapter = New FbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)

                dg_recebimento.DataSource = dt
                conexaoLocal.Close()

                If Me.dg_recebimento.Rows.Count <= 0 Then
                    MsgBox("Não a pendencias para este cliente!!!", MsgBoxStyle.Information, "SCA - Sistema de controle administrativo")
                    Close()
                Else
                    calculaTotal()
                End If
            ElseIf (lblcodigocliente.Text = "..") Then
                Close()
            End If
            For Each linha As DataGridViewRow In dg_recebimento.Rows
                linha.Cells(5).Value = "Visualizar"
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Function

    Private Sub FrmRecebimentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dataHoje As DateTime = DateTime.Now

        dataAtual = FormatDateTime(dataHoje, DateFormat.ShortDate)
        'pegaCodAbertura()
        'Verificacaixa(codFuncionario)

        verificaPendencias()
    End Sub

    Private Sub dg_recebimento_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dg_recebimento.CellFormatting
        For Each Linha As DataGridViewRow In dg_recebimento.Rows
            'Se a célula for do tipo Integer e não aceitar valores Null
            If Linha.Cells(4).Value Is DBNull.Value Then
                Linha.Cells(4).Value = False
            End If

            'Verifica se a célula do teu DataGridView tem o valor = "0"
            If Linha.Cells(4).Value > "0" Then
                'Linha.DefaultCellStyle.BackColor = Color.Lightblack
                Linha.DefaultCellStyle.ForeColor = Color.Black

            ElseIf Linha.Cells(4).Value < 0 Then
                'Linha.DefaultCellStyle.BackColor = Color.Lightred
                Me.dg_recebimento.Columns(4).DefaultCellStyle.ForeColor = DefaultForeColor.Red
            End If
        Next
    End Sub

    Private Sub dg_recebimento_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_recebimento.CellClick
        If e.ColumnIndex = Me.btnVerItens.Index AndAlso e.RowIndex >= 0 Then
            Dim currentRow As DataGridViewRow = Me.dg_recebimento.Rows(e.RowIndex)
            If currentRow.Cells(0).Value.ToString = "" Then
                MsgBox("ESTA LINHA É DE PAGAMENTO", MsgBoxStyle.Information)
                Exit Sub
            Else
                Dim FrmHistoricoMovimentacaoItens As New FrmHistoricoMovementacaoItens
                FrmHistoricoMovimentacaoItens.lblNmrVale.Text = currentRow.Cells(0).Value.ToString
                FrmHistoricoMovimentacaoItens.ShowDialog()
            End If
        End If
    End Sub

    Private Sub FrmRecebimentos_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F5
                btnQuitarRecebimento.PerformClick()
        End Select
    End Sub

    Private Sub btnQuitarRecebimento_Click(sender As Object, e As EventArgs) Handles btnQuitarRecebimento.Click
        'Dim FrmQuitarRecebimento As New FrmQuitarRecebimento

        '       FrmQuitarRecebimento.codAbertura = codAbertura
        '    FrmQuitarRecebimento.codCliente = lblcodigocliente.Text
        '   FrmQuitarRecebimento.debitoAntigo = nTotal.Value
        '  FrmQuitarRecebimento.ShowDialog()
        '    dg_recebimento.Rows.Clear()
        ' verificaPendencias()
    End Sub
End Class