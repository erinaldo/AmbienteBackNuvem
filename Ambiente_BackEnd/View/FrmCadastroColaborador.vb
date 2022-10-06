Imports System.Web.Script.Serialization
Imports FirebirdSql.Data.FirebirdClient

Public Class FrmCadastroColaborador
    Private Operacao As OperacoesCrud
    Dim pessoaFisica As Boolean
    Public tipoFuncao As Integer
    Dim ser As JavaScriptSerializer = New JavaScriptSerializer()
    Dim cnpjExistente As String
    Private Sub MudarOperacao(ByVal novaOperacao As OperacoesCrud)
        If novaOperacao = OperacoesCrud.Consulta Then
            btnSalvar.Enabled = False
        ElseIf novaOperacao = OperacoesCrud.Inserir OrElse novaOperacao = OperacoesCrud.Editar Then
            ' btnSalvar.Enabled = True
        End If
        Operacao = novaOperacao
    End Sub
    Private Sub ValidaCampos()
        'Dim mensagem As String = String.Empty

        'If txtRazaoSocial.Text = "" Or txtRazaoSocial.Text = "0" Then mensagem += "CAMPO RAZÃO SOCIAL ESTÁ INCORRETO" + Environment.NewLine

        'If txtNomeFantasia.Text = "" Or txtNomeFantasia.Text = "0" Then mensagem += "CAMPO NOME FANTASIA ESTÁ INCORRETO" + Environment.NewLine

        'If txtTelefoneCelular.Text = "" Or txtTelefoneCelular.Text = "0" Then mensagem += "CAMPO TELEFONE / CELULAR ESTÁ INCORRETO" + Environment.NewLine

        'If txtEmail.Text = "" Or txtEmail.Text = "0" Then mensagem += "CAMPO EMAIL ESTÁ INCORRETO" + Environment.NewLine

        'If txtCpfCnpj.Text = "" Or txtCpfCnpj.Text = "0" Then mensagem += "CAMPO CNPJ/CPF ESTÁ INCORRETO" + Environment.NewLine

        'If txtInscEstadual.Text = "" Or txtInscEstadual.Text = "0" And lblvalida.Text <> "PESSOA FÍSICA" Then mensagem += "CAMPO INSCRIÇÃO ESTADUAL ESTÁ INCORRETO" + Environment.NewLine

        '    If txtCep.Text = "" Or txtCep.Text = "0" Then mensagem += "CAMPO CEP ESTÁ INCORRETO" + Environment.NewLine

        'If txtEndereco.Text = "" Or txtEndereco.Text = "0" Then mensagem += "CAMPO ENDEREÇO ESTÁ INCORRETO" + Environment.NewLine

        'If txtNumero.Text = "" Or txtNumero.Text = "0" Then mensagem += "CAMPO NUMERO ESTÁ INCORRETO" + Environment.NewLine

        'If txtBairro.Text = "" Or txtBairro.Text = "0" Then mensagem += "CAMPO BAIRRO ESTÁ INCORRETO" + Environment.NewLine

        'If txtCidade.Text = "" Or txtCidade.Text = "0" Then mensagem += "CAMPO CIDADE ESTÁ INCORRETO" + Environment.NewLine

        'If txtUf.Text = "" Or txtUf.Text = "0" Then mensagem += "CAMPO UF ESTÁ INCORRETO" + Environment.NewLine

        'If txtCodigoIbge.Text = "" Or txtCodigoIbge.Text = "0" Then mensagem += "CAMPO CODIGO IBGE ESTÁ INCORRETO" + Environment.NewLine

        'If cbxAtivo.Text = "" Then mensagem += "2" + Environment.NewLine

        'If cbxCliente.Checked = False And cbxFornecedor.Checked = False And cbxTransportador.Checked = False Then mensagem += "a" + Environment.NewLine

        'If (mensagem <> "") Then
        '    btnSalvar.Enabled = False
        '    Exit Sub
        'End If

        btnSalvar.Enabled = True
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim data As DateTime
        Dim dataCadastro As String
        Dim mensagem As String = String.Empty


        data = DateTime.Now

        dataCadastro = data.ToString("yyyy-M-dd")

        If (mensagem <> "") Then
            MsgBox("Erro ao salvar o cliente: " + Environment.NewLine + mensagem, MsgBoxStyle.Exclamation, "AVISO")
            Exit Sub
        End If
        Dim sql As String
        If Operacao = OperacoesCrud.Editar Then
            sql = "UPDATE COLABORADOR SET RAZAOSOCIAL = @RAZAOSOCIAL,NOMEFANTASIA = @NOMEFANTASIA, CNPJ_CPF = @CNPJ_CPF, INSCESTADUAL = @INSCESTADUAL,
                                          INSCMUNICIPAL = @INSCMUNICIPAL,TELEFONE_1 = @TELEFONE_1, TELEFONE_2 = @TELEFONE_2, DATANASCIMENTO = @DATANASCIMENTO,
                                          EMAIL = @EMAIL,CONTATO = @CONTATO,CEP = @CEP,BAIRRO = @BAIRRO,ESTADO = @ESTADO,MUNICIPIO = @MUNICIPIO,
                                          LOGRADOURO = @LOGRADOURO,CODIGOIBGE = @CODIGOIBGE,NUMERO = @NUMERO,ATIVO = @ATIVO,DATA_ALTERACAO = @DATA_ALTERACAO,CHEQUE = @CHEQUE,
                                          CARTAO = @CARTAO,BOLETO = @BOLETO,VALE = @VALE,LIMITE = @LIMITE,CLIENTE = @CLIENTE,FORNECEDOR = @FORNECEDOR,TRANSPORTADOR = @TRANSPORTADOR WHERE CODCOLABORADOR = @CODCOLABORADOR"
        Else
            sql = "INSERT INTO COLABORADOR (CODCOLABORADOR,RAZAOSOCIAL,NOMEFANTASIA,CNPJ_CPF,INSCESTADUAL,INSCMUNICIPAL,TELEFONE_1,TELEFONE_2,DATANASCIMENTO,EMAIL,CONTATO,CEP,BAIRRO,ESTADO,MUNICIPIO,LOGRADOURO,CODIGOIBGE,NUMERO,ATIVO,DATA_CADASTRO,CHEQUE,CARTAO,BOLETO,VALE,LIMITE,CLIENTE,FORNECEDOR,TRANSPORTADOR) VALUES
                                          (@CODCOLABORADOR,@RAZAOSOCIAL,@NOMEFANTASIA,@CNPJ_CPF,@INSCESTADUAL,@INSCMUNICIPAL,@TELEFONE_1,@TELEFONE_2,@DATANASCIMENTO,@EMAIL,@CONTATO,@CEP,@BAIRRO,@ESTADO,@MUNICIPIO,@LOGRADOURO,@CODIGOIBGE,@NUMERO,@ATIVO,@DATA_CADASTRO,@CHEQUE,@CARTAO,@BOLETO,@VALE,@LIMITE,@CLIENTE,@FORNECEDOR,@TRANSPORTADOR)"
        End If
        comandoLocal = New FbCommand(sql, conexaoLocal)

        If Operacao = OperacoesCrud.Editar Then
            comandoLocal.Parameters.AddWithValue("@DATA_ALTERACAO", dataCadastro)
        End If

        If cbxCliente.Checked = True Then
            comandoLocal.Parameters.AddWithValue("@CLIENTE", "SIM")
        Else
            comandoLocal.Parameters.AddWithValue("@CLIENTE", "")
        End If

        If cbxFornecedor.Checked = True Then
            comandoLocal.Parameters.AddWithValue("@FORNECEDOR", "SIM")
        Else
            comandoLocal.Parameters.AddWithValue("@FORNECEDOR", "")
        End If

        If cbxTransportador.Checked = True Then
            comandoLocal.Parameters.AddWithValue("@TRANSPORTADOR", "SIM")
        Else
            comandoLocal.Parameters.AddWithValue("@TRANSPORTADOR", "")
        End If

        comandoLocal.Parameters.AddWithValue("@CODCOLABORADOR", txtCodigoCliente.Text)
        comandoLocal.Parameters.AddWithValue("@RAZAOSOCIAL", txtRazaoSocial.Text)
        comandoLocal.Parameters.AddWithValue("@NOMEFANTASIA", txtNomeFantasia.Text)
        comandoLocal.Parameters.AddWithValue("@CNPJ_CPF", txtCpfCnpj.Text)
        comandoLocal.Parameters.AddWithValue("@INSCESTADUAL", txtInscEstadual.Text)
        comandoLocal.Parameters.AddWithValue("@INSCMUNICIPAL", txtInscMun.Text)
        comandoLocal.Parameters.AddWithValue("@TELEFONE_1", txtTelefoneCelular.Text)
        comandoLocal.Parameters.AddWithValue("@TELEFONE_2", txtTelefone2.Text)
        comandoLocal.Parameters.AddWithValue("@DATANASCIMENTO", dtpDataNascimento.Value)
        comandoLocal.Parameters.AddWithValue("@EMAIL", txtEmail.Text)
        comandoLocal.Parameters.AddWithValue("@CONTATO", txtContato.Text)
        comandoLocal.Parameters.AddWithValue("@CEP", txtCep.Text)
        comandoLocal.Parameters.AddWithValue("@BAIRRO", txtBairro.Text)
        comandoLocal.Parameters.AddWithValue("@ESTADO", txtUf.Text)
        comandoLocal.Parameters.AddWithValue("@MUNICIPIO", txtCidade.Text)
        comandoLocal.Parameters.AddWithValue("@LOGRADOURO", txtEndereco.Text)
        comandoLocal.Parameters.AddWithValue("@CODIGOIBGE", txtCodigoIbge.Text)
        comandoLocal.Parameters.AddWithValue("@NUMERO", txtNumero.Text)
        comandoLocal.Parameters.AddWithValue("@ATIVO", cbxAtivo.Text)
        comandoLocal.Parameters.AddWithValue("@DATA_CADASTRO", data)
        comandoLocal.Parameters.AddWithValue("@CHEQUE", cbxCheque.Text)
        comandoLocal.Parameters.AddWithValue("@CARTAO", cbxCartao.Text)
        comandoLocal.Parameters.AddWithValue("@BOLETO", cbxBoleto.Text)
        comandoLocal.Parameters.AddWithValue("@VALE", cbxVale.Text)
        comandoLocal.Parameters.AddWithValue("@LIMITE", nLimite.Value)



        conexaoLocal.Close()
        conexaoLocal.Open()
        comandoLocal.ExecuteNonQuery()
        conexaoLocal.Close()

        MsgBox("REGISTRO SALVO COM SUCESSO", MsgBoxStyle.Information, "Ambiente Soft")
        limparTextBoxes(Me)
        Close()
    End Sub

    Private Sub FrmCadastroColaborador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ValidaCampos()
        If tipoFuncao = 1 Then
            MudarOperacao(OperacoesCrud.Editar)
        ElseIf tipoFuncao = 2 Then
            MudarOperacao(OperacoesCrud.Inserir)
        End If
    End Sub
    Private Sub ValidaPessoaJuridicaFisica(Optional carregandoFormulario As Boolean = False)
        Dim documento As String

        documento = txtCpfCnpj.Text.Replace(".", "").Replace("-", "").Replace("/", "").Trim()
        If Len(documento) <> 14 AndAlso Len(documento) <> 11 Then
            lblvalida.Text = "DOCUMENTO INVÁLIDO"
            lblvalida.ForeColor = ForeColor.Red
            Exit Sub
        End If

        If Len(documento) = 14 Then
            If ValidaCNPJ(documento) = False Then
                lblvalida.Text = "CNPJ INVÁLIDO"
                lblvalida.ForeColor = ForeColor.Red
                txtCpfCnpj.Text = ""
                txtCpfCnpj.Focus()

                Exit Sub
            Else
                lblvalida.Text = "PESSOA JURÍDICA"
                lblvalida.ForeColor = ForeColor.Green
                txtInscEstadual.Enabled = True
                pessoaFisica = False

                If carregandoFormulario = False Then

                    txtInscEstadual.Text = ""
                End If

                Exit Sub
            End If
        Else

            If FU_ValidaCPF(documento) = False Then
                lblvalida.Text = "CPF INVÁLIDO"
                lblvalida.ForeColor = ForeColor.Red
                txtCpfCnpj.Text = ""
                txtCpfCnpj.Focus()

                Exit Sub

            Else
                lblvalida.Text = "PESSOA FÍSICA"
                lblvalida.ForeColor = ForeColor.Blue
                txtInscEstadual.Enabled = False
                pessoaFisica = True

                If carregandoFormulario = False Then

                    txtInscEstadual.Text = ""
                End If
                Exit Sub
            End If
        End If
    End Sub
    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        cnpjExistente = ""
        ValidaCnpjCPf()
        ValidaPessoaJuridicaFisica(False)
        If pessoaFisica = False And cnpjExistente = "" Then
            Dim consultas As consulta = New consulta()

            Dim jsonString As String = New System.Net.WebClient().DownloadString("https://receitaws.com.br/v1/cnpj/" + txtCpfCnpj.Text)
            consultas = ser.Deserialize(Of consulta)(jsonString)

            txtRazaoSocial.Text = consultas.nome
            txtNomeFantasia.Text = consultas.nome
            txtCep.Text = consultas.cep
            txtEndereco.Text = consultas.logradouro
            txtNumero.Text = consultas.numero
            txtBairro.Text = consultas.bairro
            txtCidade.Text = consultas.municipio
            txtUf.Text = consultas.uf
        End If
    End Sub
    Class consulta
        Public Property nome As String
        Public Property tipo As String
        Public Property cep As String
        Public Property logradouro As String
        Public Property numero As String
        Public Property bairro As String
        Public Property municipio As String
        Public Property uf As String
    End Class
    Private Sub ValidaCnpjCPf()
        If txtCpfCnpj.Text = "" Then

        Else
            If Operacao = OperacoesCrud.Inserir Then
                Dim str As String
                Dim mensagem As String = String.Empty

                str = "SELECT * FROM COLABORADOR WHERE CNPJ_CPF =" & txtCpfCnpj.Text

                conexaoLocal.Close()
                conexaoLocal.ConnectionString = bancoLocal
                conexaoLocal.Open()

                Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)
                drLocal = cmd.ExecuteReader

                Dim cnpjCpf As String

                While drLocal.Read()

                    cnpjCpf = drLocal("CNPJ_CPF").ToString

                    If cnpjCpf <> "" Then mensagem += "Já existe um cliente com este documento cadastrado" + Environment.NewLine
                    If cnpjCpf <> "" Then mensagem += "Codigo: " + drLocal("CODCOLABORADOR").ToString + Environment.NewLine
                    If cnpjCpf <> "" Then mensagem += "Razão: " + drLocal("RAZAOSOCIAL").ToString + Environment.NewLine
                    If cnpjCpf <> "" Then mensagem += "Fantasia: " + drLocal("NOMEFANTASIA").ToString + Environment.NewLine
                    If cnpjCpf <> "" Then mensagem += "CNPJ/CPF: " + txtCpfCnpj.Text + Environment.NewLine

                    If (cnpjCpf <> "") Then
                        MsgBox(Environment.NewLine + mensagem, MsgBoxStyle.Information, "AVISO")
                        txtCpfCnpj.Focus()
                        cnpjExistente = "SIM"
                        Exit Sub
                    End If
                    Exit Sub
                End While
            End If
        End If
    End Sub
    Private Sub txtCpfCnpj_Leave(sender As Object, e As EventArgs) Handles txtCpfCnpj.Leave
        ValidaCampos()

    End Sub

    Private Sub txtRazaoSocial_Leave(sender As Object, e As EventArgs) Handles txtRazaoSocial.Leave
        ValidaCampos()
    End Sub

    Private Sub txtNomeFantasia_Leave(sender As Object, e As EventArgs) Handles txtNomeFantasia.Leave
        ValidaCampos()
    End Sub

    Private Sub txtTelefoneCelular_Leave(sender As Object, e As EventArgs) Handles txtTelefoneCelular.Leave
        ValidaCampos()
    End Sub

    Private Sub txtTelefone2_Leave(sender As Object, e As EventArgs) Handles txtTelefone2.Leave
        ValidaCampos()
    End Sub

    Private Sub dtpDataNascimento_Leave(sender As Object, e As EventArgs) Handles dtpDataNascimento.Leave
        ValidaCampos()
    End Sub

    Private Sub txtContato_Leave(sender As Object, e As EventArgs) Handles txtContato.Leave
        ValidaCampos()
    End Sub

    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        ValidaCampos()
    End Sub

    Private Sub txtInscEstadual_Leave(sender As Object, e As EventArgs) Handles txtInscEstadual.Leave
        ValidaCampos()
    End Sub

    Private Sub txtInscMun_Leave(sender As Object, e As EventArgs) Handles txtInscMun.Leave
        ValidaCampos()
    End Sub

    Private Sub txtCep_Leave(sender As Object, e As EventArgs) Handles txtCep.Leave
        ValidaCampos()
    End Sub

    Private Sub txtEndereco_Leave(sender As Object, e As EventArgs) Handles txtEndereco.Leave
        ValidaCampos()
    End Sub

    Private Sub txtNumero_Leave(sender As Object, e As EventArgs) Handles txtNumero.Leave
        ValidaCampos()
    End Sub

    Private Sub txtBairro_Leave(sender As Object, e As EventArgs) Handles txtBairro.Leave
        ValidaCampos()
    End Sub

    Private Sub txtCidade_Leave(sender As Object, e As EventArgs) Handles txtCidade.Leave
        ValidaCampos()
    End Sub

    Private Sub txtUf_Leave(sender As Object, e As EventArgs) Handles txtUf.Leave
        ValidaCampos()
    End Sub

    Private Sub txtCodigoIbge_Leave(sender As Object, e As EventArgs) Handles txtCodigoIbge.Leave
        ValidaCampos()
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        'ValidaCampos()
    End Sub
End Class