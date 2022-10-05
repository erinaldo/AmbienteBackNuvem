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
    Public xChaveAcesso As String
    Public cNF As String
    Public proxnumero As Integer

    Private Sub MudarOperacao(ByVal novaOperacao As OperacoesCrud)
        If novaOperacao = OperacoesCrud.IniciarNota Then
            mdl_bloquearcampos.funcao = "LIBERAR"
        ElseIf novaOperacao = OperacoesCrud.BloquearNota Then
            mdl_bloquearcampos.funcao = "BLOQUEAR"
        End If
        bloquearcampos(Me)
        Operacao = novaOperacao
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
                'btnLancarItem.PerformClick()
            Case Keys.F4
                'btnEditarItem.PerformClick()
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
    End Sub

    Private Sub FrmNotaFiscalEletronica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim FormasPagamento As Dictionary(Of String, String)
        Dim IndicadorPresenca As Dictionary(Of String, String)
        Dim IndicadorIntermediario As Dictionary(Of String, String)
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
    Public Sub aleatorio()
        Dim inicio As Integer
        Dim fim As Integer
        Dim result As Integer
        inicio = 0
        fim = 100000000
        Dim numero As Integer
        Dim GeradorDeNumerosAleatorios As Random = New Random()
        numero = GeradorDeNumerosAleatorios.Next(inicio, fim)
        result = numero
        cNF = result
    End Sub
    Private Sub btnEmitir_Click(sender As Object, e As EventArgs) Handles btnEmitir.Click
        Dim serie As String = "001"
        Dim tpamb As Integer
        Dim datachave As DateTime = DateTime.Now
        Dim Dataconvertida As String

        proxnumero = numeroNota + 1
        txtNumeroNota.Text = proxnumero


        Dataconvertida = datachave.ToString("yyMM")
        xChaveAcesso = 35 & Format(Dataconvertida) & cnpjEmitente & 55 & serie & proxnumero & tpamb & cNF
    End Sub

    Private Sub cbxIndicativoPresenca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxIndicativoPresenca.SelectedIndexChanged
        IndicativoPresenca = CInt((CType(cbxIndicativoPresenca.SelectedItem, KeyValuePair(Of String, String)).Key))
    End Sub

    Private Sub cbxIntermediario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxIntermediario.SelectedIndexChanged
        IndicadorIntermediario = CInt((CType(cbxIntermediario.SelectedItem, KeyValuePair(Of String, String)).Key))
    End Sub
End Class