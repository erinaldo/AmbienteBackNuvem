Imports FirebirdSql.Data.FirebirdClient

Public Class FrmNotaFiscalEletronica
    Dim funcao As String = ""
    Public codCliente As String
    Private Operacao As OperacoesCrud
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
                btnImportarItem.PerformClick()
            Case Keys.F3
                btnLancarItem.PerformClick()
            Case Keys.F4
                btnEditarItem.PerformClick()
            Case Keys.Delete
                btnDeletarItem.PerformClick()
        End Select
    End Sub

    Private Sub btnImportarItem_Click(sender As Object, e As EventArgs) Handles btnImportarItem.Click
        'MsgBox("Em Desenvolvimento")

    End Sub

    Private Sub btnLancarItem_Click(sender As Object, e As EventArgs) Handles btnLancarItem.Click
        'MsgBox("Em Desenvolvimento")
        'Dim FrmConsultaProduto As New FrmConsultaProduto
        FrmConsultaProduto.ShowDialog()
    End Sub

    Private Sub btnEditarItem_Click(sender As Object, e As EventArgs) Handles btnEditarItem.Click
        MsgBox("Em Desenvolvimento")
    End Sub

    Private Sub btnDeletarItem_Click(sender As Object, e As EventArgs) Handles btnDeletarItem.Click
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
        MudarOperacao(Operacao.BloquearNota)
        btnNovaNota.Enabled = True
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
End Class