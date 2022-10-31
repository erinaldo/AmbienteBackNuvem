Imports FirebirdSql.Data.FirebirdClient
Imports Boleto2Net
Imports System.IO
Module mdl_boleto
    Dim objBoletos As New Boletos
    Dim cnpjColaborador As String
    Dim bairroColaborador As String
    Dim cepColaborador As String
    Dim municipioColaborador As String
    Dim enderecoColaborador As String
    Dim numeroColaborador As String
    Dim ufColaborador As String
    Dim nomeColaborador As String

    Public Sub buscaCliente(codCliente As String, valorTotal As String)
        Dim str As String
        Try

            str = "SELECT * FROM COLABORADOR WHERE CODCOLABORADOR = " & codCliente

            conexaoLocal.Close()
            conexaoLocal.ConnectionString = bancoLocal
            conexaoLocal.Open()

            Dim cmdItens As FbCommand = New FbCommand(str, conexaoLocal)
            drLocal = cmdItens.ExecuteReader

            While drLocal.Read()
                cnpjColaborador = drLocal("CNPJ_CPF").ToString
                bairroColaborador = drLocal("BAIRRO").ToString
                cepColaborador = drLocal("CEP").ToString
                municipioColaborador = drLocal("MUNICIPIO").ToString
                enderecoColaborador = drLocal("LOGRADOURO").ToString
                numeroColaborador = drLocal("NUMERO").ToString
                ufColaborador = drLocal("ESTADO").ToString
                nomeColaborador = drLocal("RAZAOSOCIAL").ToString
            End While
            geraBoleto(valorTotal)
        Catch ex As Exception
            MsgBox("Erro ao gerar boleto: " + ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub
    Public Sub geraBoleto(valorTotal As String)
        Try
        objBoletos.Banco = Banco.Instancia(756)
        objBoletos.Banco.Cedente = New Cedente
        objBoletos.Banco.Cedente.CPFCNPJ = LerIni("Empresa", "cnpj")
        objBoletos.Banco.Cedente.Nome = LerIni("Empresa", "RazaoSocial")
        objBoletos.Banco.Cedente.Observacoes = ""

        Dim conta As New ContaBancaria
        conta.Agencia = LerIni("EMPRESA", "ContaAgencia")
        conta.DigitoAgencia = ""
        conta.OperacaoConta = String.Empty
        conta.Conta = LerIni("EMPRESA", "Conta")
        conta.DigitoConta = LerIni("EMPRESA", "DigitoConta")
        conta.CarteiraPadrao = "1"

        conta.VariacaoCarteiraPadrao = "01"
        conta.TipoCarteiraPadrao = TipoCarteira.CarteiraCobrancaSimples
        conta.TipoFormaCadastramento = TipoFormaCadastramento.ComRegistro
        conta.TipoImpressaoBoleto = TipoImpressaoBoleto.Empresa
        conta.TipoDocumento = TipoDocumento.Tradicional

        Dim ender As New Endereco
        ender.LogradouroEndereco = LerIni("EMPRESA", "Endereco")
        ender.LogradouroNumero = LerIni("EMPRESA", "Numero")
        ender.LogradouroComplemento = ""
        ender.Bairro = LerIni("EMPRESA", "Bairro")
        ender.Cidade = LerIni("EMPRESA", "Cidade")
        ender.UF = LerIni("EMPRESA", "UF")
        ender.CEP = LerIni("EMPRESA", "CEP")


        objBoletos.Banco.Cedente.Codigo = LerIni("EMPRESA", "CodigoCedente")
        objBoletos.Banco.Cedente.CodigoDV = "0"
        objBoletos.Banco.Cedente.CodigoTransmissao = "000000"
        objBoletos.Banco.Cedente.ContaBancaria = conta
        objBoletos.Banco.Cedente.Endereco = ender
        objBoletos.Banco.FormataCedente()


        For i = 1 To 1

            Dim Titulo As New Boleto(objBoletos.Banco)
            Titulo.Sacado = New Sacado With {
        .CPFCNPJ = cnpjColaborador,
        .Endereco = New Boleto2Net.Endereco With {
        .Bairro = bairroColaborador,
        .CEP = cepColaborador,
        .Cidade = municipioColaborador,
        .LogradouroComplemento = "",
        .LogradouroEndereco = enderecoColaborador,
        .LogradouroNumero = numeroColaborador,
        .UF = ufColaborador},
             .Nome = nomeColaborador,
         .Observacoes = ""
                }
            Titulo.CodigoOcorrencia = "01"
            Titulo.DescricaoOcorrencia = "Remessa Registrar"
            Titulo.NumeroDocumento = "112454"
            Titulo.NumeroControleParticipante = "12"
            Titulo.NossoNumero = "1111215"
            Titulo.DataEmissao = Now.Date
            Titulo.DataVencimento = "29/08/2022"
            Titulo.ValorTitulo = valorTotal
            Titulo.Aceite = "N"
            Titulo.EspecieDocumento = TipoEspecieDocumento.DM
            Titulo.DataDesconto = Now.Date.AddDays(15)
            Titulo.ValorDesconto = 0

            'PARTE DA MULTA
            Dim dtmulta As Date
            dtmulta = Titulo.DataVencimento.AddDays(1)


            Titulo.DataMulta = Now.Date.AddDays(15)
            Titulo.PercentualMulta = 2
            Titulo.ValorMulta = Titulo.ValorTitulo * Titulo.PercentualMulta / 100
            Titulo.MensagemInstrucoesCaixa = $"A partir de {FormatDateTime(dtmulta, 2)} cobrar multa de 2.20% "


            'PARTE JUROS DE MORA
            Titulo.DataJuros = Now.Date.AddDays(15)
            Titulo.PercentualJurosDia = 10 / 30
            Titulo.ValorJurosDia = Titulo.ValorTitulo * Titulo.PercentualJurosDia / 100

            Dim instrucoes As String = $" e cobrar juros de 0,07% por dia
------Não conceder descontos"
            If String.IsNullOrEmpty(Titulo.MensagemInstrucoesCaixa) Then
                Titulo.MensagemInstrucoesCaixa += Environment.NewLine + instrucoes
            Else
                Titulo.MensagemInstrucoesCaixa += Environment.NewLine + instrucoes
            End If
            '
            Titulo.CodigoInstrucao1 = ""
            Titulo.ComplementoInstrucao1 = ""

            'Titulo.ComplementoInstrucao3 = String.Empty
            Titulo.CodigoProtesto = TipoCodigoProtesto.NaoProtestar
            Titulo.DiasProtesto = 0
            Titulo.CodigoBaixaDevolucao = TipoCodigoBaixaDevolucao.NaoBaixarNaoDevolver
            Titulo.DiasBaixaDevolucao = 0
            Titulo.ValidarDados()

            objBoletos.Add(Titulo)

        Next
        If MessageBox.Show("Deseja visualizar os boletos agora?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            'Gera boletos
            Dim numBoletos As Integer = 0
            For Each linha In objBoletos
                numBoletos += 1
                Dim NovoBoleto = New BoletoBancario
                NovoBoleto.Boleto = linha
                Dim pdf = NovoBoleto.MontaBytesPDF(False)
                Dim data As String
                data = Now.Date
                data = Replace(data, "/", "")

                Dim caminhoboleto As String

                caminhoboleto = "C:\Boleto\EMISSOR\Boletos\boleto-" & CStr(data) & "-" & "1111215" & ".pdf"



                Dim nomeArquivoBoleto As String = caminhoboleto

                File.WriteAllBytes(nomeArquivoBoleto, pdf)

                Dim MyProcess As New Process
                ' MyProcess.StartInfo.CreateNoWindow = False
                ' MyProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                ' MyProcess.StartInfo.Verb = "print"
                ' MyProcess.StartInfo.Arguments = strImpressora

                MyProcess.StartInfo.FileName = nomeArquivoBoleto
                MyProcess.Start()
                'MyProcess.WaitForExit(10000)
                MyProcess.WaitForInputIdle()

                If MyProcess.Responding Then
                    MyProcess.CloseMainWindow()
                Else
                    MyProcess.Kill()
                End If

                'MyProcess.Close()
            Next

        End If

        Catch ex As Exception
        MessageBox.Show(ex.Message)
        End Try
#Disable Warning BC42105 ' A função não retorna um valor em todos os caminhos de código

#Enable Warning BC42105 ' A função não retorna um valor em todos os caminhos de código

    End Sub

End Module
