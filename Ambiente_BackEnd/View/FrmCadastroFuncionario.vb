Imports FirebirdSql.Data.FirebirdClient

Public Class FrmCadastroFuncionario
    Dim pessoaFisica As Boolean
    Private Operacao As OperacoesCrud
    Dim INDEX As Integer
    Private Sub CarregaFuncao(codFuncao As String)
        Dim str As String

        str = "SELECT * FROM FUNCAO WHERE CODFUNCAO =" & codFuncao

        conexaoLocal.Close()
        conexaoLocal.Open()

        Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)

        drLocal = cmd.ExecuteReader
        While drLocal.Read()
            txtFuncao.Text = drLocal("FUNCAO").ToString
        End While
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean

        If msg.WParam.ToInt32() = CInt(Keys.Enter) Then
            SendKeys.Send("{Tab}")
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
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
    Private Sub ValidandoCPF(Optional carregandoFormulario As Boolean = False)
        Dim documento As String

        documento = txtcpf.Text.Replace(".", "").Replace("-", "").Replace("/", "").Trim()
        If Len(documento) <> 14 AndAlso Len(documento) <> 11 Then
            lblvalida.Text = "DOCUMENTO INVÁLIDO"
            lblvalida.ForeColor = ForeColor.Red
            Exit Sub
        End If

        If Len(documento) = 14 Then
            lblvalida.Text = "DOCUMENTO INVÁLIDO"
            lblvalida.ForeColor = ForeColor.Red
        Else

            If FU_ValidaCPF(documento) = False Then
                lblvalida.Text = "CPF INVÁLIDO"
                lblvalida.ForeColor = ForeColor.Red
                txtcpf.Text = ""
                txtcpf.Focus()

                Exit Sub

            Else
                lblvalida.Text = "CPF VALIDO"
                lblvalida.ForeColor = ForeColor.Blue

                pessoaFisica = True

                If carregandoFormulario = False Then
                End If
                Exit Sub
            End If
        End If
    End Sub
    Private Sub btninserir_Click(sender As Object, e As EventArgs) Handles btninserir.Click
        Try
            Dim str As String

            str = "Select CODFUNCIONARIO From FUNCIONARIO ORDER BY CODFUNCIONARIO DESC"
            conexaoLocal.ConnectionString = bancoLocal
            Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)
            conexaoLocal.Close()
            conexaoLocal.Open()
            drLocal = cmd.ExecuteReader(CommandBehavior.SingleRow)
            If drLocal.HasRows Then
                drLocal.Read()
                txtCodFuncionario.Text = drLocal.Item("CODFUNCIONARIO") + 1
            End If
            If (txtCodFuncionario.Text = "") Then
                txtCodFuncionario.Text = "1"
            End If
        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Exclamation, "Ambiente Informa")
        Finally
            drLocal.Close()
            conexaoLocal.Close()
        End Try

        MudarOperacao(OperacoesCrud.Inserir)
        tbFuncionario.TabPages.Add(tpCadastrar)
        tbFuncionario.TabPages.Remove(tpPesquisa)

    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim str As String
        Dim codFuncionario As Integer

        INDEX = dg_funcionario.SelectedRows(0).Index
        Dim selectedRow As DataGridViewRow

        selectedRow = dg_funcionario.Rows(INDEX)
        codFuncionario = selectedRow.Cells(0).Value.ToString()
        str = "SELECT * FROM FUNCIONARIO WHERE CODFUNCIONARIO =" & codFuncionario
        conexaoLocal.Close()
        conexaoLocal.Open()

        Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)

        drLocal = cmd.ExecuteReader
        While drLocal.Read()
            txtCodFuncionario.Text = drLocal("CODFUNCIONARIO").ToString
            txtFuncionario.Text = drLocal("NOMEFUNCIONARIO").ToString
            txtcpf.Text = drLocal("CPF").ToString
            txtRg.Text = drLocal("RG").ToString
            txtTelefone.Text = drLocal("TELEFONE").ToString
            txtCelular.Text = drLocal("CELULAR").ToString

            dtpDataNascimento.Text = drLocal("DATA_NASCIMENTO").ToString
            txtcep.Text = drLocal("CEP").ToString
            txtbairro.Text = drLocal("BAIRRO").ToString
            txtuf.Text = drLocal("ESTADO").ToString
            txtCidade.Text = drLocal("MUNICIPIO").ToString
            txtendereco.Text = drLocal("LOGRADOURO").ToString
            txtcodibge.Text = drLocal("CODIGOIBGE").ToString
            txtNumero.Text = drLocal("NUMERO").ToString
            cbxAtivo.Text = drLocal("ATIVO").ToString
            txtUsuario.Text = drLocal("USUARIO").ToString
            txtSenha.Text = drLocal("SENHA").ToString
            txtCodigoFuncao.Text = drLocal("CODFUNCAO").ToString
        End While
        tbFuncionario.TabPages.Remove(tpPesquisa)
        tbFuncionario.TabPages.Add(tpCadastrar)
        MudarOperacao(OperacoesCrud.Editar)
        ValidandoCPF(True)
    End Sub

    Private Sub btnsalvar_Click(sender As Object, e As EventArgs) Handles btnsalvar.Click
        Dim data As DateTime
        Dim dataCadastro As String
        Dim mensagem As String = String.Empty

        data = DateTime.Now

        dataCadastro = data.ToString("yyyy-M-dd")


        If txtFuncionario.Text = "" Then mensagem += "CAMPO FUNCIONARIO ESTÁ VAZIO" + Environment.NewLine

        If txtcpf.Text = "" Then mensagem += "CAMPO CPF ESTÁ VAZIO" + Environment.NewLine


        If (mensagem <> "") Then
            MsgBox("Erro ao salvar o funcionario: " + Environment.NewLine + mensagem, MsgBoxStyle.Exclamation, "AVISO")
            Exit Sub
        End If
        Dim sql As String
        If Operacao = OperacoesCrud.Editar Then
            sql = "UPDATE FUNCIONARIO SET NOMEFUNCIONARIO = @NOMEFUNCIONARIO, CPF = @CPF, RG = @RG,
                                          TELEFONE = @TELEFONE,CELULAR = @CELULAR, DATA_NASCIMENTO = @DATA_NASCIMENTO, CEP = @CEP,
                                          BAIRRO = @BAIRRO,ESTADO = @ESTADO,MUNICIPIO = @MUNICIPIO,LOGRADOURO = @LOGRADOURO,CODIGOIBGE = @CODIGOIBGE,NUMERO = @NUMERO,DATA_ALTERACAO = @DATA_ALTERACAO,
                                          ATIVO = @ATIVO,CODFUNCAO = @CODFUNCAO,USUARIO = @USUARIO,SENHA = @SENHA WHERE CODFUNCIONARIO = @CODFUNCIONARIO"
        Else
            sql = "INSERT INTO FUNCIONARIO (CODFUNCIONARIO,NOMEFUNCIONARIO,CPF,RG,TELEFONE,CELULAR,DATA_NASCIMENTO,CEP,BAIRRO,ESTADO,MUNICIPIO,LOGRADOURO,CODIGOIBGE,NUMERO,ATIVO,DATA_CADASTRO,CODFUNCAO,USUARIO,SENHA) VALUES
                                          (@CODFUNCIONARIO,@NOMEFUNCIONARIO,@CPF,@RG,@TELEFONE,@CELULAR,@DATA_NASCIMENTO,@CEP,@BAIRRO,@ESTADO,@MUNICIPIO,@LOGRADOURO,@CODIGOIBGE,@NUMERO,@ATIVO,@DATA_CADASTRO,@CODFUNCAO,@USUARIO,@SENHA)"
        End If
        comandoLocal = New FbCommand(sql, conexaoLocal)

        If Operacao = OperacoesCrud.Editar Then
            comandoLocal.Parameters.AddWithValue("@DATA_ALTERACAO", dataCadastro)
        End If


        comandoLocal.Parameters.AddWithValue("@CODFUNCIONARIO", txtCodFuncionario.Text)
        comandoLocal.Parameters.AddWithValue("@NOMEFUNCIONARIO", txtFuncionario.Text)
        comandoLocal.Parameters.AddWithValue("@CPF", txtcpf.Text)
        comandoLocal.Parameters.AddWithValue("@RG", txtRg.Text)
        comandoLocal.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text)
        comandoLocal.Parameters.AddWithValue("@CELULAR", txtCelular.Text)
        comandoLocal.Parameters.AddWithValue("@DATA_NASCIMENTO", dtpDataNascimento.Value)
        comandoLocal.Parameters.AddWithValue("@CEP", txtcep.Text)
        comandoLocal.Parameters.AddWithValue("@BAIRRO", txtbairro.Text)
        comandoLocal.Parameters.AddWithValue("@ESTADO", txtuf.Text)
        comandoLocal.Parameters.AddWithValue("@MUNICIPIO", txtCidade.Text)
        comandoLocal.Parameters.AddWithValue("@LOGRADOURO", txtendereco.Text)
        comandoLocal.Parameters.AddWithValue("@CODIGOIBGE", txtcodibge.Text)
        comandoLocal.Parameters.AddWithValue("@NUMERO", txtNumero.Text)
        comandoLocal.Parameters.AddWithValue("@ATIVO", cbxAtivo.Text)
        comandoLocal.Parameters.AddWithValue("@DATA_CADASTRO", data)
        comandoLocal.Parameters.AddWithValue("@CODFUNCAO", txtCodigoFuncao.Text)
        comandoLocal.Parameters.AddWithValue("@USUARIO", txtUsuario.Text)
        comandoLocal.Parameters.AddWithValue("@SENHA", txtSenha.Text)

        conexaoLocal.Close()
        conexaoLocal.Open()
        comandoLocal.ExecuteNonQuery()
        conexaoLocal.Close()

        MsgBox("REGISTRO SALVO COM SUCESSO", MsgBoxStyle.Information, "Ambiente Soft")
        limparTextBoxes(Me)
        tbFuncionario.TabPages.Add(tpPesquisa)
        tbFuncionario.TabPages.Remove(tpCadastrar)
        MudarOperacao(OperacoesCrud.Consulta)
        btnpesquisar.PerformClick()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        limparTextBoxes(Me)
        MudarOperacao(OperacoesCrud.Consulta)

        tbFuncionario.TabPages.Add(tpPesquisa)
        tbFuncionario.TabPages.Remove(tpCadastrar)
    End Sub

    Private Sub btnpesquisar_Click(sender As Object, e As EventArgs) Handles btnpesquisar.Click
        cbxFiltro.Text = "NOME"
        If tbFuncionario.TabPages.Contains(tpPesquisa) Then

        Else
            tbFuncionario.TabPages.Remove(tpCadastrar)
            tbFuncionario.TabPages.Add(tpPesquisa)
        End If
        Dim ds As New DataSet

        If (conexaoLocal.State <> ConnectionState.Closed) Then
            conexaoLocal.Close()
        End If

        daLocal = New FbDataAdapter("SELECT FUNCIONARIO.CODFUNCIONARIO,FUNCIONARIO.NOMEFUNCIONARIO,FUNCIONARIO.CPF FROM FUNCIONARIO WHERE ATIVO = 'SIM'", conexaoLocal)
        daLocal.Fill(ds)

        dg_funcionario.DataSource = ds.Tables(0)
        MudarOperacao(OperacoesCrud.Consulta)
    End Sub

    Private Sub FrmCadastroFuncionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblvalida.Text = ""
        MudarOperacao(OperacoesCrud.Consulta)

        tbFuncionario.TabPages.Remove(tpPesquisa)
        tbFuncionario.TabPages.Remove(tpCadastrar)
        tbFuncionario.TabPages.Add(tpPesquisa)
    End Sub

    Private Sub txtCodigoFuncao_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoFuncao.TextChanged
        If (txtCodFuncionario.Text = "") Then

        ElseIf (txtCodigoFuncao.Text <> "") Then
            CarregaFuncao(txtCodigoFuncao.Text)
        End If
    End Sub

    Private Sub txtcpf_Leave(sender As Object, e As EventArgs) Handles txtcpf.Leave
        ValidandoCPF(True)
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

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Close()
    End Sub

    Private Sub txtPesquisar_TextChanged(sender As Object, e As EventArgs) Handles txtPesquisar.TextChanged
        Dim str As String = 0

        If cbxFiltro.Text = "CODIGO" Then str = "SELECT FUNCIONARIO.CODFUNCIONARIO,FUNCIONARIO.NOMEFUNCIONARIO,FUNCIONARIO.CPF FROM FUNCIONARIO WHERE ATIVO = 'SIM' and CODFUNCIONARIO LIKE  '%" & txtPesquisar.Text & "%'"
        If cbxFiltro.Text = "NOME" Then str = "SELECT FUNCIONARIO.CODFUNCIONARIO,FUNCIONARIO.NOMEFUNCIONARIO,FUNCIONARIO.CPF FROM FUNCIONARIO WHERE ATIVO = 'SIM' and NOMEFUNCIONARIO  LIKE  '%" & txtPesquisar.Text & "%'"
        If cbxFiltro.Text = "CPF" Then str = "SELECT FUNCIONARIO.CODFUNCIONARIO,FUNCIONARIO.NOMEFUNCIONARIO,FUNCIONARIO.CPF FROM FUNCIONARIO WHERE ATIVO = 'SIM' and CPF  LIKE  '%" & txtPesquisar.Text & "%'"

        conexaoLocal.Close()
        conexaoLocal.ConnectionString = bancoLocal
        conexaoLocal.Open()

        Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)
        Dim da As FbDataAdapter = New FbDataAdapter(cmd)
        Dim dt As DataTable = New DataTable
        da.Fill(dt)
        dg_funcionario.DataSource = dt

        conexaoLocal.Close()
    End Sub
End Class