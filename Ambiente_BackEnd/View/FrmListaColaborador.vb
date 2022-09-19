Imports FirebirdSql.Data.FirebirdClient

Public Class FrmListaColaborador
    Private Sub ListaColaborador()
        Dim ds As New DataSet

        If (conexaoLocal.State <> ConnectionState.Closed) Then
            conexaoLocal.Close()
        End If

        daLocal = New FbDataAdapter("SELECT COLABORADOR.CODCOLABORADOR,COLABORADOR.RAZAOSOCIAL,COLABORADOR.NOMEFANTASIA FROM COLABORADOR WHERE ATIVO = 'SIM'", conexaoLocal)
        daLocal.Fill(ds)

        dgConsultaCliente.DataSource = ds.Tables(0)
    End Sub
    Private Sub FrmListaColaborador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListaColaborador()
    End Sub

    Private Sub dgConsultaCliente_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgConsultaCliente.CellContentDoubleClick
        Dim str As String
        Dim currentRow As DataGridViewRow = dgConsultaCliente.Rows(e.RowIndex)

        str = "SELECT * FROM COLABORADOR WHERE CODCOLABORADOR = " & currentRow.Cells(0).Value.ToString()

        conexaoLocal.Close()
        conexaoLocal.ConnectionString = bancoLocal
        conexaoLocal.Open()

        Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)
        drLocal = cmd.ExecuteReader

        Dim FrmCadastroColaborador As New FrmCadastroColaborador

        While drLocal.Read()
            FrmCadastroColaborador.txtCodigoCliente.Text = drLocal("CODCOLABORADOR").ToString
            FrmCadastroColaborador.txtCpfCnpj.Text = drLocal("CNPJ_CPF").ToString
            FrmCadastroColaborador.txtRazaoSocial.Text = drLocal("RAZAOSOCIAL").ToString
            FrmCadastroColaborador.txtNomeFantasia.Text = drLocal("NOMEFANTASIA").ToString
            FrmCadastroColaborador.txtTelefoneCelular.Text = drLocal("TELEFONE_1").ToString
            FrmCadastroColaborador.txtTelefone2.Text = drLocal("TELEFONE_2").ToString
            FrmCadastroColaborador.dtpDataNascimento.Value = drLocal("DATANASCIMENTO").ToString
            FrmCadastroColaborador.txtContato.Text = drLocal("CONTATO").ToString
            FrmCadastroColaborador.txtEmail.Text = drLocal("EMAIL").ToString
            FrmCadastroColaborador.txtInscEstadual.Text = drLocal("INSCESTADUAL").ToString
            FrmCadastroColaborador.txtInscMun.Text = drLocal("INSCMUNICIPAL").ToString
            FrmCadastroColaborador.txtCep.Text = drLocal("CEP").ToString
            FrmCadastroColaborador.txtEndereco.Text = drLocal("LOGRADOURO").ToString
            FrmCadastroColaborador.txtNumero.Text = drLocal("NUMERO").ToString
            FrmCadastroColaborador.txtBairro.Text = drLocal("BAIRRO").ToString
            FrmCadastroColaborador.txtCidade.Text = drLocal("MUNICIPIO").ToString
            FrmCadastroColaborador.txtUf.Text = drLocal("ESTADO").ToString
            FrmCadastroColaborador.txtCodigoIbge.Text = drLocal("CODIGOIBGE").ToString
            FrmCadastroColaborador.cbxCheque.Text = drLocal("CHEQUE").ToString
            FrmCadastroColaborador.cbxCartao.Text = drLocal("CARTAO").ToString
            FrmCadastroColaborador.cbxBoleto.Text = drLocal("BOLETO").ToString
            FrmCadastroColaborador.cbxVale.Text = drLocal("VALE").ToString
            'FrmCadastroColaborador.nLimite.Value = drLocal("LIMITE").ToString
            FrmCadastroColaborador.cbxAtivo.Text = drLocal("ATIVO").ToString

            If (drLocal("CLIENTE").ToString = "SIM") Then
                FrmCadastroColaborador.cbxCliente.Checked = True
            End If

            If (drLocal("FORNECEDOR").ToString = "SIM") Then
                FrmCadastroColaborador.cbxFornecedor.Checked = True
            End If

            If (drLocal("TRANSPORTADOR").ToString = "SIM") Then
                FrmCadastroColaborador.cbxTransportador.Checked = True
            End If
        End While
        FrmCadastroColaborador.tipoFuncao = 1
        FrmCadastroColaborador.ShowDialog()
        ListaColaborador()
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Dim FrmCadastroColaborador As New FrmCadastroColaborador
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
                FrmCadastroColaborador.txtCodigoCliente.Text = drLocal.Item("CODCOLABORADOR") + 1
            End If
            If (FrmCadastroColaborador.txtCodigoCliente.Text = "") Then
                FrmCadastroColaborador.txtCodigoCliente.Text = "1"
            End If
        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Exclamation, "Ambiente Informa")
        Finally
            drLocal.Close()
            conexaoLocal.Close()
        End Try
        FrmCadastroColaborador.tipoFuncao = 2
        FrmCadastroColaborador.txtCpfCnpj.Focus()
        FrmCadastroColaborador.ShowDialog()
    End Sub
End Class