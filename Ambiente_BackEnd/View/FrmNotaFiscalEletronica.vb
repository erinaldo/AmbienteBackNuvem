Imports FirebirdSql.Data.FirebirdClient

Public Class FrmNotaFiscalEletronica
    Dim funcao As String = ""
    Dim cnpjEmitente As String = LerIni("EMPRESA", "CNPJ")
    Dim numeroNota As String = LerIni("SEQNOTA", "numero")
    Public codCliente As String
    Public tipoFuncao As String
    Private Operacao As OperacoesCrud
    Public FormaPagamento As String
    Public IndicativoPresenca As String
    Public IndicadorIntermediario As String
    Public modeloFrete As String
    Public xChaveAcesso As String
    Public cNF As String
    Public proxnumero As String
    Private Sub MudarOperacao(ByVal novaOperacao As OperacoesCrud)
        If novaOperacao = OperacoesCrud.IniciarNota Then
            mdl_bloquearcampos.funcao = "LIBERAR"
        ElseIf novaOperacao = OperacoesCrud.BloquearNota Then
            mdl_bloquearcampos.funcao = "BLOQUEAR"
        End If
        bloquearcampos(Me)
        Operacao = novaOperacao
    End Sub
    Public Sub calculaTotal()
        Dim valor As Decimal

        For Each col As DataGridViewRow In dgNotaFiscal.Rows
            valor = valor + col.Cells(8).Value
        Next

        nTotalNFe.Value = valor
        lblTotalNfe.Text = FormatCurrency(valor, 2)
    End Sub
    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        If funcao = "" Then
            rtbInformaçõesComplementares.Text = ""
            funcao = "1"
            btnLimpar.Text = "Preencher"
        ElseIf funcao = "1" Then
            rtbInformaçõesComplementares.Text = "DOCUMENTO EMITIDO POR ME OU EPP,OPTANTE PELO SIMPLES NACIONAL NAO GERA DIREITO A CREDITO FINAL DE IPI. " + rtbInformaçõesComplementares.Text
            funcao = ""
            btnLimpar.Text = "Enviar"
        End If
    End Sub



    Private Sub FrmNotaFiscalEletronica_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                'btnImportarItem.PerformClick()
            Case Keys.F3
                'FrmConsultaProduto.ShowDialog()
            Case Keys.F4
                FrmConsultaProduto.ShowDialog()
            Case Keys.Delete
                'btnDeletarItem.PerformClick()
        End Select
    End Sub

    Private Sub btnImportarItem_Click(sender As Object, e As EventArgs)
        Dim FrmImportaVenda As New FrmImportarVenda
        FrmImportarVenda.ShowDialog()
    End Sub

    Private Sub btnLancarItem_Click(sender As Object, e As EventArgs)
        FrmConsultaProduto.ShowDialog()
    End Sub

    Private Sub btnEditarItem_Click(sender As Object, e As EventArgs)
        MsgBox("Em Desenvolvimento")
    End Sub

    Private Sub btnDeletarItem_Click(sender As Object, e As EventArgs)
        MsgBox("Em Desenvolvimento")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim FrmConsultaCliente As New FrmConsultaCliente
        FrmConsultaCliente.ShowDialog()
    End Sub

    Private Sub btnNovaNota_Click(sender As Object, e As EventArgs) Handles btnNovaNota.Click
        MudarOperacao(Operacao.IniciarNota)
        txtNumeroNota.Text = LerIni("SEQNOTA", "numero")
        txtNumeroNota.Text = txtNumeroNota.Text + 1
    End Sub

    Private Sub FrmNotaFiscalEletronica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim formasPagamento As Dictionary(Of String, String)
        Dim indicadorPresenca As Dictionary(Of String, String)
        Dim indicadorIntermediario As Dictionary(Of String, String)
        Dim modeloFrete As Dictionary(Of String, String)
        If (tipoFuncao <> "2") Then
            MudarOperacao(Operacao.BloquearNota)
            btnNovaNota.Enabled = True
        End If

        FormasPagamento = New Dictionary(Of String, String) From {
            {"01", "Dinheiro"},
            {"02", "Cheque"},
            {"03", "Cartão de Crédito"},
            {"04", "Cartão de Débito"},
            {"05", "Crédito Loja"},
            {"10", "Vale Alimentação"},
            {"11", "Vale Refeição"},
            {"12", "Vale Presente"},
            {"13", "Vale Combustível"},
            {"14", "Duplicata Mercantil"},
            {"15", "Boleto Bancário"},
            {"16", "Deposito Bancario"},
            {"17", "Pagamento PIX"},
            {"18", "Transf bancaria,Carteira Digital"},
            {"19", "Programa de finalidade,CashBack"},
            {"90", "Sem Pagamentos"},
            {"99", "Outros"}
        }
        cbxFormaPagamento.DataSource = New BindingSource(FormasPagamento, Nothing)
        cbxFormaPagamento.ValueMember = "Key"
        cbxFormaPagamento.DisplayMember = "Value"

        IndicadorPresenca = New Dictionary(Of String, String) From {
           {"0", "Não se aplica (por exemplo, Nota Fiscal complementar ou de ajuste)"},
           {"1", "Operação presencial"},
           {"2", "Operação não presencial, pela Internet"},
           {"3", "Operação não presencial, tele atendimento"},
           {"4", "NFC-e em operação com entrega a domicílio"},
           {"5", " Operação presencial, fora do estabelecimento"},
           {"9", "Operação não presencial, outros"}
           }

        cbxIndicativoPresenca.DataSource = New BindingSource(IndicadorPresenca, Nothing)
        cbxIndicativoPresenca.ValueMember = "Key"
        cbxIndicativoPresenca.DisplayMember = "Value"

        IndicadorIntermediario = New Dictionary(Of String, String) From {
           {"0", "NÃO"},
           {"1", "SIM"}
           }

        cbxIntermediario.DataSource = New BindingSource(IndicadorIntermediario, Nothing)
        cbxIntermediario.ValueMember = "Key"
        cbxIntermediario.DisplayMember = "Value"

        modeloFrete = New Dictionary(Of String, String) From {
        {"0", "Contratação do Frete por conta do Remetente (CIF)"},
        {"1", "Contratação do Frete por conta do Destinatário (FOB)"},
        {"2", "Contratação do Frete por conta de Terceiros"},
        {"3", "Transporte Próprio por conta do Remetente"},
        {"4", "Transporte Próprio por conta do Destinatário"},
        {"9", "Sem Ocorrência de Transporte"}
        }
        cbxModeloFrete.DataSource = New BindingSource(modeloFrete, Nothing)
        cbxModeloFrete.ValueMember = "Key"
        cbxModeloFrete.DisplayMember = "Value"

    End Sub

    Private Sub txtCodCliente_TextChanged(sender As Object, e As EventArgs) Handles txtCodCliente.TextChanged
        Dim sql As String
        If (txtCodCliente.Text = "") Then
            txtNomeCliente.Text = ""
        Else
            sql = "SELECT * FROM COLABORADOR WHERE CODCOLABORADOR = " & txtCodCliente.Text

            conexaoLocal.Close()
            conexaoLocal.ConnectionString = bancoLocal
            conexaoLocal.Open()

            Dim cmd As FbCommand = New FbCommand(sql, conexaoLocal)
            drLocal = cmd.ExecuteReader

            While drLocal.Read()
                txtNomeCliente.Text = drLocal("RAZAOSOCIAL").ToString
            End While
        End If
    End Sub

    Private Sub txtCfop_TextChanged(sender As Object, e As EventArgs) Handles txtCfop.TextChanged
        If txtCfop.Text = "" Then
            txtDescricaoCfop.Text = ""
        Else
            Dim str As String
            str = "SELECT * From CFOP where CODCFOP =" & txtCfop.Text

            conexaoLocal.Close()
            conexaoLocal.ConnectionString = bancoLocal
            conexaoLocal.Open()

            Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)

            drLocal = cmd.ExecuteReader

            While drLocal.Read()
                txtDescricaoCfop.Text = drLocal("NOME_CFO").ToString
            End While
        End If
    End Sub
    Private Sub cbxFormaPagamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxFormaPagamento.SelectedIndexChanged
        FormaPagamento = CInt((CType(cbxFormaPagamento.SelectedItem, KeyValuePair(Of String, String)).Key))
    End Sub
    Private Sub btnEmitir_Click(sender As Object, e As EventArgs) Handles btnEmitir.Click
        'If MessageBox.Show("Deseja lançar outro produto?", "Ambiente Soft", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = vbYes Then
        '    dataCadastro = Data.ToString("yyyy-M-dd")
        Dim mensagem As String = String.Empty
        Dim sequencia As String = ""
        If sequencia = "" Then mensagem += "Ultimas notas emitidas" + Environment.NewLine

        Dim str As String
        Dim registro As Double = 0
        str = "SELECT * FROM NOTAFISCAL ORDER BY NUMNOTA DESC"

        conexaoLocal.Close()
        conexaoLocal.ConnectionString = bancoLocal
        conexaoLocal.Open()

        Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)

        drLocal = cmd.ExecuteReader

        While drLocal.Read()
            If registro <> 5 Then
                'Dim numero As String = drLocal("NUMNOT")
                If sequencia = "" Then mensagem += CStr(drLocal("NUMNOTA").ToString) + Environment.NewLine
                registro = registro + 1
            Else

            End If
        End While

        If sequencia = "" Then mensagem += "Nota a ser emitida : " + txtNumeroNota.Text + Environment.NewLine

        If sequencia = "" Then mensagem += "Confirmar a emissão da nota ?" + Environment.NewLine

        If (mensagem <> "") Then

            If MessageBox.Show(mensagem, "Ambiente Soft", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = vbYes Then
                mdl_emitirnfe.BuscaCliente(txtCodCliente.Text)
                mdl_emitirnfe.GeraChaveAcesso(txtNumeroNota.Text, txtCfop.Text, IndicativoPresenca, IndicadorIntermediario)
                'mdl_emitirnfe.EmitirRegimeSimplesNacional(xChaveAcesso, "", txtNumeroNota.Text, cNF, "55", txtCfop.Text, IndicativoPresenca, IndicadorIntermediario, 20.3)
                System.Threading.Thread.Sleep(3400)
            Else
            End If

            Exit Sub
        End If
    End Sub

    Private Sub cbxIndicativoPresenca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxIndicativoPresenca.SelectedIndexChanged
        IndicativoPresenca = CInt((CType(cbxIndicativoPresenca.SelectedItem, KeyValuePair(Of String, String)).Key))
    End Sub

    Private Sub cbxIntermediario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxIntermediario.SelectedIndexChanged
        IndicadorIntermediario = CInt((CType(cbxIntermediario.SelectedItem, KeyValuePair(Of String, String)).Key))
    End Sub

    Private Sub cbxModeloFrete_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxModeloFrete.SelectedIndexChanged
        modeloFrete = CInt((CType(cbxModeloFrete.SelectedItem, KeyValuePair(Of String, String)).Key))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Retorno()
    End Sub
End Class