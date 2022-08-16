Imports FirebirdSql.Data.FirebirdClient

Public Class FrmCadastroColaboradores
    Dim pessoaFisica As Boolean
    Private Operacao As OperacoesCrud
    Dim INDEX As Integer
    Private Sub MudarOperacao(ByVal novaOperacao As OperacoesCrud)
        If novaOperacao = OperacoesCrud.Consulta Then
            btnpesquisar.Enabled = True
            btnimprimir.Enabled = True
            btnsalvar.Enabled = False
            btncancelar.Enabled = False
            btneditar.Enabled = True
            btninserir.Enabled = True
        ElseIf novaOperacao = OperacoesCrud.Inserir OrElse novaOperacao = OperacoesCrud.Editar Then
            btnpesquisar.Enabled = False
            btnimprimir.Enabled = False
            btnsalvar.Enabled = True
            btncancelar.Enabled = True
            btneditar.Enabled = False
            btninserir.Enabled = False
        End If
        Operacao = novaOperacao
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        If msg.WParam.ToInt32() = CInt(Keys.Enter) Then
            SendKeys.Send("{Tab}")
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    Private Sub btnpesquisar_Click(sender As Object, e As EventArgs) Handles btnpesquisar.Click
        If tbColaborador.TabPages.Contains(tpPesquisa) Then

        Else
            tbColaborador.TabPages.Remove(tpCadastrar)
            tbColaborador.TabPages.Add(tpPesquisa)
        End If
        Dim ds As New DataSet

        If (conexaoLocal.State <> ConnectionState.Closed) Then
            conexaoLocal.Close()
        End If

        daLocal = New FbDataAdapter("SELECT COLABORADOR.CODCOLABORADOR,COLABORADOR.RAZAOSOCIAL FROM COLABORADOR WHERE ATIVO = 'SIM'", conexaoLocal)
        daLocal.Fill(ds)

        dg_cliente.DataSource = ds.Tables(0)
        MudarOperacao(OperacoesCrud.Consulta)
    End Sub

    Private Sub FrmCadastroColaboradores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblvalida.Text = ""
        MudarOperacao(OperacoesCrud.Consulta)

        tbColaborador.TabPages.Remove(tpPesquisa)
        tbColaborador.TabPages.Remove(tpCadastrar)
        tbColaborador.TabPages.Add(tpPesquisa)
    End Sub

    Private Sub btninserir_Click(sender As Object, e As EventArgs) Handles btninserir.Click
        Try
            Dim str As String

            str = "Select CODCOLABORADOR From COLABORADOR ORDER BY CODCOLABORADOR DESC"
            conexaoLocal.ConnectionString = bancoLocal
            Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)
            conexaoLocal.Close()
            conexaoLocal.Open()
            drLocal = cmd.ExecuteReader(CommandBehavior.SingleRow)
            If drLocal.HasRows Then
                drLocal.Read()
                txtCodColaborador.Text = drLocal.Item("CODCOLABORADOR") + 1
            End If
            If (txtCodColaborador.Text = "") Then
                txtCodColaborador.Text = "1"
            End If
        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Exclamation, "Ambiente Informa")
        Finally
            drLocal.Close()
            conexaoLocal.Close()
        End Try

        MudarOperacao(OperacoesCrud.Inserir)
        tbColaborador.TabPages.Add(tpCadastrar)
        tbColaborador.TabPages.Remove(tpPesquisa)
        txtRazaoSocial.Focus()
    End Sub
    Private Sub ValidaPessoaJuridicaFisica(Optional carregandoFormulario As Boolean = False)
        Dim documento As String

        documento = txtcpfcnpj.Text.Replace(".", "").Replace("-", "").Replace("/", "").Trim()
        If Len(documento) <> 14 AndAlso Len(documento) <> 11 Then
            lblvalida.Text = "DOCUMENTO INVÁLIDO"
            lblvalida.ForeColor = ForeColor.Red
            Exit Sub
        End If

        If Len(documento) = 14 Then
            If ValidaCNPJ(documento) = False Then
                lblvalida.Text = "CNPJ INVÁLIDO"
                lblvalida.ForeColor = ForeColor.Red
                txtcpfcnpj.Text = ""
                txtcpfcnpj.Focus()

                Exit Sub
            Else
                lblvalida.Text = "PESSOA JURÍDICA"
                lblvalida.ForeColor = ForeColor.Green
                txtInscEst.Enabled = True
                pessoaFisica = False

                If carregandoFormulario = False Then

                    txtInscEst.Text = ""
                End If

                Exit Sub
            End If
        Else

            If FU_ValidaCPF(documento) = False Then
                lblvalida.Text = "CPF INVÁLIDO"
                lblvalida.ForeColor = ForeColor.Red
                txtcpfcnpj.Text = ""
                txtcpfcnpj.Focus()

                Exit Sub

            Else
                lblvalida.Text = "PESSOA FÍSICA"
                lblvalida.ForeColor = ForeColor.Blue
                txtInscEst.Enabled = False
                pessoaFisica = True

                If carregandoFormulario = False Then

                    txtInscEst.Text = ""
                End If
                Exit Sub
            End If
        End If
    End Sub


    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim str As String
        Dim codColaborador As Integer
        Index = dg_cliente.SelectedRows(0).Index
        Dim selectedRow As DataGridViewRow

        selectedRow = dg_cliente.Rows(Index)
        codColaborador = selectedRow.Cells(0).Value.ToString()
        str = "SELECT * FROM COLABORADOR WHERE CODCOLABORADOR =" & codColaborador

        conexaoLocal.Close()
        conexaoLocal.Open()

        Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)

        drLocal = cmd.ExecuteReader
        While drLocal.Read()

            txtCodColaborador.Text = drLocal("CODCOLABORADOR").ToString
            txtRazaoSocial.Text = drLocal("RAZAOSOCIAL").ToString
            txtNomeFantasia.Text = drLocal("NOMEFANTASIA").ToString
            txtcpfcnpj.Text = drLocal("CNPJ_CPF").ToString
            txtInscEst.Text = drLocal("INSCESTADUAL").ToString
            txtInscMun.Text = drLocal("INSCMUNICIPAL").ToString
            txtTelefone1.Text = drLocal("TELEFONE_1").ToString
            txtTelefone2.Text = drLocal("TELEFONE_2").ToString

            rtObservacao.Text = drLocal("OBSERVACAO").ToString
            txtEmail.Text = drLocal("EMAIL").ToString
            txtContato.Text = drLocal("CONTATO").ToString
            txtcep.Text = drLocal("CEP").ToString
            txtuf.Text = drLocal("ESTADO").ToString
            txtCidade.Text = drLocal("MUNICIPIO").ToString
            txtbairro.Text = drLocal("BAIRRO").ToString
            txtendereco.Text = drLocal("LOGRADOURO").ToString
            txtcodibge.Text = drLocal("CODIGOIBGE").ToString
            txtNumero.Text = drLocal("NUMERO").ToString
            cbxAtivo.Text = drLocal("ATIVO").ToString

            cbxCheque.Text = drLocal("CHEQUE").ToString
            cbxCartao.Text = drLocal("CARTAO").ToString
            cbxBoleto.Text = drLocal("BOLETO").ToString
            cbxVale.Text = drLocal("VALE").ToString
            nLimite.Value = CDec(drLocal("LIMITE"))
            If (Not IsDBNull(drLocal("DATANASCIMENTO"))) Then
                dtpDataNascimento.Value = CDate(drLocal("DATANASCIMENTO"))
            End If

            If (drLocal("CLIENTE").ToString = "SIM") Then
                cbxCliente.Checked = True
            End If

            If (drLocal("FORNECEDOR").ToString = "SIM") Then
                cbxFornecedor.Checked = True
            End If

            If (drLocal("TRANSPORTADOR").ToString = "SIM") Then
                cbxTransportador.Checked = True
            End If
        End While

        tbColaborador.TabPages.Remove(tpPesquisa)
        tbColaborador.TabPages.Add(tpCadastrar)
        MudarOperacao(OperacoesCrud.Editar)
        ValidaPessoaJuridicaFisica(True)
    End Sub

    Private Sub btnsalvar_Click(sender As Object, e As EventArgs) Handles btnsalvar.Click
        Dim data As DateTime
        Dim dataCadastro As String
        Dim mensagem As String = String.Empty


        data = DateTime.Now

        dataCadastro = data.ToString("yyyy-M-dd")

        If txtRazaoSocial.Text = "" Then mensagem += "CAMPO RAZÃO SOCIAL ESTÁ VAZIO" + Environment.NewLine

        If txtcpfcnpj.Text = "" Then mensagem += "CAMPO CNPJ/CPF ESTÁ VAZIO" + Environment.NewLine

        If txtTelefone1.Text = "" Then mensagem += "CAMPO TELEFONE ESTÁ VAZIO" + Environment.NewLine

        If txtEmail.Text = "" Then mensagem += "CAMPO EMAIL ESTÁ VAZIO" + Environment.NewLine

        If (mensagem <> "") Then
            MsgBox("Erro ao salvar o cliente: " + Environment.NewLine + mensagem, MsgBoxStyle.Exclamation, "AVISO")
            Exit Sub
        End If
        Dim sql As String
        If Operacao = OperacoesCrud.Editar Then
            sql = "UPDATE COLABORADOR SET RAZAOSOCIAL = @RAZAOSOCIAL,NOMEFANTASIA = @NOMEFANTASIA, CNPJ_CPF = @CNPJ_CPF, INSCESTADUAL = @INSCESTADUAL,
                                          INSCMUNICIPAL = @INSCMUNICIPAL,TELEFONE_1 = @TELEFONE_1, TELEFONE_2 = @TELEFONE_2, DATANASCIMENTO = @DATANASCIMENTO,
                                          OBSERVACAO = @OBSERVACAO,EMAIL = @EMAIL,CONTATO = @CONTATO,CEP = @CEP,BAIRRO = @BAIRRO,ESTADO = @ESTADO,MUNICIPIO = @MUNICIPIO,
                                          LOGRADOURO = @LOGRADOURO,CODIGOIBGE = @CODIGOIBGE,NUMERO = @NUMERO,ATIVO = @ATIVO,DATA_ALTERACAO = @DATA_ALTERACAO,CHEQUE = @CHEQUE,
                                          CARTAO = @CARTAO,BOLETO = @BOLETO,VALE = @VALE,LIMITE = @LIMITE,CLIENTE = @CLIENTE,FORNECEDOR = @FORNECEDOR,TRANSPORTADOR = @TRANSPORTADOR WHERE CODCOLABORADOR = @CODCOLABORADOR"
        Else
            sql = "INSERT INTO COLABORADOR (CODCOLABORADOR,RAZAOSOCIAL,NOMEFANTASIA,CNPJ_CPF,INSCESTADUAL,INSCMUNICIPAL,TELEFONE_1,TELEFONE_2,DATANASCIMENTO,OBSERVACAO,EMAIL,CONTATO,CEP,BAIRRO,ESTADO,MUNICIPIO,LOGRADOURO,CODIGOIBGE,NUMERO,ATIVO,DATA_CADASTRO,CHEQUE,CARTAO,BOLETO,VALE,LIMITE,CLIENTE,FORNECEDOR,TRANSPORTADOR) VALUES
                                          (@CODCOLABORADOR,@RAZAOSOCIAL,@NOMEFANTASIA,@CNPJ_CPF,@INSCESTADUAL,@INSCMUNICIPAL,@TELEFONE_1,@TELEFONE_2,@DATANASCIMENTO,@OBSERVACAO,@EMAIL,@CONTATO,@CEP,@BAIRRO,@ESTADO,@MUNICIPIO,@LOGRADOURO,@CODIGOIBGE,@NUMERO,@ATIVO,@DATA_CADASTRO,@CHEQUE,@CARTAO,@BOLETO,@VALE,@LIMITE,@CLIENTE,@FORNECEDOR,@TRANSPORTADOR)"
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

        comandoLocal.Parameters.AddWithValue("@CODCOLABORADOR", txtCodColaborador.Text)
        comandoLocal.Parameters.AddWithValue("@RAZAOSOCIAL", txtRazaoSocial.Text)
        comandoLocal.Parameters.AddWithValue("@NOMEFANTASIA", txtNomeFantasia.Text)
        comandoLocal.Parameters.AddWithValue("@CNPJ_CPF", txtcpfcnpj.Text)
        comandoLocal.Parameters.AddWithValue("@INSCESTADUAL", txtInscEst.Text)
        comandoLocal.Parameters.AddWithValue("@INSCMUNICIPAL", txtInscMun.Text)
        comandoLocal.Parameters.AddWithValue("@TELEFONE_1", txtTelefone1.Text)
        comandoLocal.Parameters.AddWithValue("@TELEFONE_2", txtTelefone2.Text)
        comandoLocal.Parameters.AddWithValue("@DATANASCIMENTO", dtpDataNascimento.Value)
        comandoLocal.Parameters.AddWithValue("@OBSERVACAO", rtObservacao.Text)
        comandoLocal.Parameters.AddWithValue("@EMAIL", txtEmail.Text)
        comandoLocal.Parameters.AddWithValue("@CONTATO", txtContato.Text)
        comandoLocal.Parameters.AddWithValue("@CEP", txtcep.Text)
        comandoLocal.Parameters.AddWithValue("@BAIRRO", txtbairro.Text)
        comandoLocal.Parameters.AddWithValue("@ESTADO", txtuf.Text)
        comandoLocal.Parameters.AddWithValue("@MUNICIPIO", txtCidade.Text)
        comandoLocal.Parameters.AddWithValue("@LOGRADOURO", txtendereco.Text)
        comandoLocal.Parameters.AddWithValue("@CODIGOIBGE", txtcodibge.Text)
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
        tbColaborador.TabPages.Add(tpPesquisa)
        tbColaborador.TabPages.Remove(tpCadastrar)
        MudarOperacao(OperacoesCrud.Consulta)
        btnpesquisar.PerformClick()

    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        limparTextBoxes(Me)
        MudarOperacao(OperacoesCrud.Consulta)

        tbColaborador.TabPages.Add(tpPesquisa)
        tbColaborador.TabPages.Remove(tpCadastrar)
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Close()
    End Sub

    Private Sub txtPesquisar_TextChanged(sender As Object, e As EventArgs) Handles txtPesquisar.TextChanged
        Dim str As String = 0

        If cbxFiltro.Text = "CODIGO" Then str = "SELECT COLABORADOR.CODCOLABORADOR,COLABORADOR.RAZAOSOCIAL,COLABORADOR.NOMEFANTASIA,COLABORADOR.CNPJ_CPF FROM COLABORADOR WHERE ATIVO = 'SIM' and CODCOLABORADOR LIKE  '%" & txtPesquisar.Text & "%'"
        If cbxFiltro.Text = "RAZAO SOCIAL" Then str = "SELECT COLABORADOR.CODCOLABORADOR,COLABORADOR.RAZAOSOCIAL,COLABORADOR.NOMEFANTASIA,COLABORADOR.CNPJ_CPF FROM COLABORADOR WHERE ATIVO = 'SIM' and RAZAOSOCIAL  LIKE  '%" & txtPesquisar.Text & "%'"
        If cbxFiltro.Text = "FANTASIA" Then str = "SELECT COLABORADOR.CODCOLABORADOR,COLABORADOR.RAZAOSOCIAL,COLABORADOR.NOMEFANTASIA,COLABORADOR.CNPJ_CPF FROM COLABORADOR WHERE ATIVO = 'SIM' and NOMEFANTASIA  LIKE  '%" & txtPesquisar.Text & "%'"
        If cbxFiltro.Text = "CNPJ/CPF" Then str = "SELECT COLABORADOR.CODCOLABORADOR,COLABORADOR.RAZAOSOCIAL,COLABORADOR.NOMEFANTASIA,COLABORADOR.CNPJ_CPF FROM COLABORADOR WHERE ATIVO = 'SIM' and CNPJ_CPF  LIKE  '%" & txtPesquisar.Text & "%'"

        conexaoLocal.Close()
        conexaoLocal.ConnectionString = bancoLocal
        conexaoLocal.Open()

        Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)
        Dim da As FbDataAdapter = New FbDataAdapter(cmd)
        Dim dt As DataTable = New DataTable
        da.Fill(dt)
        dg_cliente.DataSource = dt

        conexaoLocal.Close()
    End Sub
    Private Sub ValidaCnpjCPf()
        If txtcpfcnpj.Text = "" Then

        Else
            If Operacao = OperacoesCrud.Inserir Then
                Dim str As String
                Dim mensagem As String = String.Empty

                str = "SELECT * FROM COLABORADOR WHERE CNPJ_CPF =" & txtcpfcnpj.Text

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
                    If cnpjCpf <> "" Then mensagem += "CNPJ/CPF: " + txtcpfcnpj.Text + Environment.NewLine

                    If (cnpjCpf <> "") Then
                        MsgBox(Environment.NewLine + mensagem, MsgBoxStyle.Information, "AVISO")
                        txtcpfcnpj.Focus()
                        Exit Sub
                    End If
                End While
            End If
        End If
    End Sub

    Private Sub txtcpfcnpj_Leave(sender As Object, e As EventArgs) Handles txtcpfcnpj.Leave
        ValidaPessoaJuridicaFisica(False)
        ValidaCnpjCPf()
    End Sub

    Private Sub txtcep_Leave(sender As Object, e As EventArgs) Handles txtcep.Leave
        If My.Computer.Network.IsAvailable Then
            Try
                Dim ds As New DataSet()
                Dim xml As String = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", txtcep.Text)
                ds.ReadXml(xml)
                txtendereco.Text = ds.Tables(0).Rows(0)("logradouro").ToString()
                txtbairro.Text = ds.Tables(0).Rows(0)("bairro").ToString()
                txtCidade.Text = ds.Tables(0).Rows(0)("cidade").ToString()
                txtuf.Text = ds.Tables(0).Rows(0)("uf").ToString()

                txtNumero.Focus()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Erro")
            End Try
            If txtendereco.Text = "" Then
                MsgBox("CEP NÃO ENCONTRADO", MsgBoxStyle.Critical, "AVISO")
                txtcep.Focus()
            End If
        ElseIf MessageBox.Show("REDE DESCONECTADA DESEJA CADASTRAR MANUAL?", "AMBIENTE INFORMA", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) = vbYes Then
            txtendereco.Enabled = True
            txtbairro.Enabled = True
            txtCidade.Enabled = True
            txtuf.Enabled = True
            txtendereco.Focus()
        End If
    End Sub
End Class