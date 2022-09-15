Public Class FrmVisualizaCliente
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
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
            MsgBox("Erro ao Confirmar Cliente
" + Environment.NewLine + mensagem, MsgBoxStyle.Exclamation, "AVISO")
            Exit Sub
        End If
    End Sub
End Class