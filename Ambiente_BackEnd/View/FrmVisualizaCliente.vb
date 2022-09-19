Imports System.Web.Script.Serialization
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports FirebirdSql.Data.FirebirdClient

Public Class FrmVisualizaCliente
    Dim pessoaFisica As Boolean
    Dim ser As JavaScriptSerializer = New JavaScriptSerializer()
    Private Sub ValidaCampos()
        Dim mensagem As String = String.Empty

        If txtRazaoSocial.Text = "" Or txtRazaoSocial.Text = "0" Then mensagem += "CAMPO RAZÃO SOCIAL ESTÁ INCORRETO" + Environment.NewLine

        If txtNomeFantasia.Text = "" Or txtNomeFantasia.Text = "0" Then mensagem += "CAMPO NOME FANTASIA ESTÁ INCORRETO" + Environment.NewLine

        If txtTelefoneCelular.Text = "" Or txtTelefoneCelular.Text = "0" Then mensagem += "CAMPO TELEFONE / CELULAR ESTÁ INCORRETO" + Environment.NewLine

        If txtEmail.Text = "" Or txtEmail.Text = "0" Then mensagem += "CAMPO EMAIL ESTÁ INCORRETO" + Environment.NewLine

        If txtCpfCnpj.Text = "" Or txtCpfCnpj.Text = "0" Then mensagem += "CAMPO CNPJ/CPF ESTÁ INCORRETO" + Environment.NewLine

        If txtInscEstadual.Text = "" Or txtInscEstadual.Text = "0" Then mensagem += "CAMPO INSCRIÇÃO ESTADUAL ESTÁ INCORRETO" + Environment.NewLine

        If txtCep.Text = "" Or txtCep.Text = "0" Then mensagem += "CAMPO CEP ESTÁ INCORRETO" + Environment.NewLine

        If txtEndereco.Text = "" Or txtEndereco.Text = "0" Then mensagem += "CAMPO ENDEREÇO ESTÁ INCORRETO" + Environment.NewLine

        If txtNumero.Text = "" Or txtNumero.Text = "0" Then mensagem += "CAMPO NUMERO ESTÁ INCORRETO" + Environment.NewLine

        If txtBairro.Text = "" Or txtBairro.Text = "0" Then mensagem += "CAMPO BAIRRO ESTÁ INCORRETO" + Environment.NewLine

        If txtCidade.Text = "" Or txtCidade.Text = "0" Then mensagem += "CAMPO CIDADE ESTÁ INCORRETO" + Environment.NewLine

        If txtUf.Text = "" Or txtUf.Text = "0" Then mensagem += "CAMPO UF ESTÁ INCORRETO" + Environment.NewLine

        If txtCodigoIbge.Text = "" Or txtCodigoIbge.Text = "0" Then mensagem += "CAMPO CODIGO IBGE ESTÁ INCORRETO" + Environment.NewLine
        If (mensagem <> "") Then
            btnConfirmar.Enabled = False
            Exit Sub
        End If

        btnConfirmar.Enabled = True
    End Sub
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click


        FrmNotaFiscalEletronica.codCliente = txtCodigoCliente.Text
        FrmNotaFiscalEletronica.txtCodCliente.Text = txtCodigoCliente.Text
        FrmNotaFiscalEletronica.txtNomeCliente.Text = txtRazaoSocial.Text

        Close()
    End Sub

    Private Sub btnAtualizarDados_Click(sender As Object, e As EventArgs) Handles btnAtualizarDados.Click
        Dim sql As String

        sql = "UPDATE COLABORADOR SET RAZAOSOCIAL = @RAZAOSOCIAL,NOMEFANTASIA = @NOMEFANTASIA, CNPJ_CPF = @CNPJ_CPF, INSCESTADUAL = @INSCESTADUAL,TELEFONE_1 = @TELEFONE_1,EMAIL = @EMAIL,CEP = @CEP,BAIRRO = @BAIRRO,ESTADO = @ESTADO,MUNICIPIO = @MUNICIPIO,LOGRADOURO = @LOGRADOURO,CODIGOIBGE = @CODIGOIBGE,NUMERO = @NUMERO WHERE CODCOLABORADOR = @CODCOLABORADOR"
        comandoLocal = New FbCommand(sql, conexaoLocal)

        comandoLocal.Parameters.AddWithValue("@CODCOLABORADOR", txtCodigoCliente.Text)
        comandoLocal.Parameters.AddWithValue("@RAZAOSOCIAL", txtRazaoSocial.Text)
        comandoLocal.Parameters.AddWithValue("@NOMEFANTASIA", txtNomeFantasia.Text)
        comandoLocal.Parameters.AddWithValue("@CNPJ_CPF", txtCpfCnpj.Text)
        comandoLocal.Parameters.AddWithValue("@INSCESTADUAL", txtInscEstadual.Text)
        comandoLocal.Parameters.AddWithValue("@TELEFONE_1", txtTelefoneCelular.Text)
        comandoLocal.Parameters.AddWithValue("@EMAIL", txtEmail.Text)
        comandoLocal.Parameters.AddWithValue("@CEP", txtCep.Text)
        comandoLocal.Parameters.AddWithValue("@BAIRRO", txtBairro.Text)
        comandoLocal.Parameters.AddWithValue("@ESTADO", txtUf.Text)
        comandoLocal.Parameters.AddWithValue("@MUNICIPIO", txtCidade.Text)
        comandoLocal.Parameters.AddWithValue("@LOGRADOURO", txtEndereco.Text)
        comandoLocal.Parameters.AddWithValue("@CODIGOIBGE", txtCodigoIbge.Text)
        comandoLocal.Parameters.AddWithValue("@NUMERO", txtNumero.Text)

        conexaoLocal.Close()
        conexaoLocal.Open()
        comandoLocal.ExecuteNonQuery()
        conexaoLocal.Close()

        MsgBox("CLIENTE ATUALIZADO COM SUCESSO", MsgBoxStyle.Information, "Ambiente Soft")
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

    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        ValidaCampos()
    End Sub

    Private Sub txtCpfCnpj_Leave(sender As Object, e As EventArgs) Handles txtCpfCnpj.Leave
        ValidaCampos()
    End Sub

    Private Sub txtInscEstadual_Leave(sender As Object, e As EventArgs) Handles txtInscEstadual.Leave
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

    Private Sub FrmVisualizaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ValidaCampos()
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
        ValidaPessoaJuridicaFisica(False)
        If pessoaFisica = False Then
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
End Class