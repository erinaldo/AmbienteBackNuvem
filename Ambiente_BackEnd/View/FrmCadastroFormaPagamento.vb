Imports FirebirdSql.Data.FirebirdClient

Public Class FrmCadastroFormaPagamento
    Private Operacao As OperacoesCrud
    Dim INDEX As Integer
    Private Sub MudarOperacao(ByVal novaOperacao As OperacoesCrud)
        If novaOperacao = OperacoesCrud.Consulta Then
            btnpesquisar.Enabled = True
            btnsalvar.Enabled = False
            btncancelar.Enabled = False
            btneditar.Enabled = True
            btninserir.Enabled = True
        ElseIf novaOperacao = OperacoesCrud.Inserir OrElse novaOperacao = OperacoesCrud.Editar Then
            btnpesquisar.Enabled = False
            btnsalvar.Enabled = True
            btncancelar.Enabled = True
            btneditar.Enabled = False
            btninserir.Enabled = False
        End If
        Operacao = novaOperacao
    End Sub
    Private Sub btninserir_Click(sender As Object, e As EventArgs) Handles btninserir.Click
        Try
            Dim str As String

            str = "Select CODPAGAMENTO From FORMA_PAGAMENTO ORDER BY CODPAGAMENTO DESC"
            conexaoLocal.ConnectionString = bancoLocal
            Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)
            conexaoLocal.Close()
            conexaoLocal.Open()
            drLocal = cmd.ExecuteReader(CommandBehavior.SingleRow)
            If drLocal.HasRows Then
                drLocal.Read()
                txtCodFormaPagamento.Text = drLocal.Item("CODPAGAMENTO") + 1
            End If
            If (txtCodFormaPagamento.Text = "") Then
                txtCodFormaPagamento.Text = "1"
            End If
        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Exclamation, "Ambiente Informa")
        Finally
            drLocal.Close()
            conexaoLocal.Close()
        End Try

        MudarOperacao(OperacoesCrud.Inserir)
        tbFomaPagamento.TabPages.Add(tpCadastrar)
        tbFomaPagamento.TabPages.Remove(tpPesquisa)
        txtFormaPagamento.Focus()
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim str As String
        Dim codFormaPagamento As Integer
        INDEX = dgFuncao.SelectedRows(0).Index
        Dim selectedRow As DataGridViewRow

        selectedRow = dgFuncao.Rows(INDEX)
        codFormaPagamento = selectedRow.Cells(0).Value.ToString()
        str = "SELECT * FROM FORMA_PAGAMENTO WHERE CODPAGAMENTO =" & codFormaPagamento

        conexaoLocal.Close()
        conexaoLocal.Open()

        Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)

        drLocal = cmd.ExecuteReader
        While drLocal.Read()
            txtCodFormaPagamento.Text = drLocal("CODPAGAMENTO").ToString
            txtFormaPagamento.Text = drLocal("DESCRICAOFORMA").ToString
            cbxAtivo.Text = drLocal("ATIVO").ToString
        End While

        tbFomaPagamento.TabPages.Remove(tpPesquisa)
        tbFomaPagamento.TabPages.Add(tpCadastrar)
        MudarOperacao(OperacoesCrud.Editar)
    End Sub

    Private Sub btnsalvar_Click(sender As Object, e As EventArgs) Handles btnsalvar.Click
        Dim data As DateTime
        Dim dataCadastro As String
        Dim mensagem As String = String.Empty

        data = DateTime.Now

        dataCadastro = data.ToString("yyyy-M-dd")

        If txtFormaPagamento.Text = "" Then mensagem += "CAMPO FORMA PAGAMENTO ESTÁ VAZIO" + Environment.NewLine

        If (mensagem <> "") Then
            MsgBox("Erro ao salvar a função: " + Environment.NewLine + mensagem, MsgBoxStyle.Exclamation, "AVISO")
            Exit Sub
        End If
        Dim sql As String
        Try

            If Operacao = OperacoesCrud.Editar Then
                sql = "UPDATE FORMA_PAGAMENTO SET DESCRICAOFORMA = @DESCRICAOFORMA,ATIVO = @ATIVO WHERE CODPAGAMENTO = @CODPAGAMENTO"
            Else
                sql = "INSERT INTO FORMA_PAGAMENTO (CODPAGAMENTO,DESCRICAOFORMA,ATIVO) VALUES (@CODPAGAMENTO,@DESCRICAOFORMA,@ATIVO)"
            End If
            comandoLocal = New FbCommand(sql, conexaoLocal)

            comandoLocal.Parameters.AddWithValue("@CODPAGAMENTO", txtCodFormaPagamento.Text)
            comandoLocal.Parameters.AddWithValue("@DESCRICAOFORMA", txtFormaPagamento.Text)
            comandoLocal.Parameters.AddWithValue("@ATIVO", cbxAtivo.Text)

            conexaoLocal.Close()
            conexaoLocal.Open()
            comandoLocal.ExecuteNonQuery()
            conexaoLocal.Close()

            MsgBox("REGISTRO SALVO COM SUCESSO", MsgBoxStyle.Information, "Ambiente Soft")
            limparTextBoxes(Me)
            tbFomaPagamento.TabPages.Add(tpPesquisa)
            tbFomaPagamento.TabPages.Remove(tpCadastrar)
            MudarOperacao(OperacoesCrud.Consulta)
            btnpesquisar.PerformClick()
        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Exclamation, "Ambiente Informa")
        End Try
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        limparTextBoxes(Me)
        MudarOperacao(OperacoesCrud.Consulta)

        tbFomaPagamento.TabPages.Add(tpPesquisa)
        tbFomaPagamento.TabPages.Remove(tpCadastrar)
    End Sub

    Private Sub btnpesquisar_Click(sender As Object, e As EventArgs) Handles btnpesquisar.Click
        cbxFiltro.Text = "DESCRICAO"
        If tbFomaPagamento.TabPages.Contains(tpPesquisa) Then

        Else
            tbFomaPagamento.TabPages.Remove(tpCadastrar)
            tbFomaPagamento.TabPages.Add(tpPesquisa)
        End If
        Dim ds As New DataSet

        If (conexaoLocal.State <> ConnectionState.Closed) Then
            conexaoLocal.Close()
        End If

        daLocal = New FbDataAdapter("SELECT FORMA_PAGAMENTO.CODPAGAMENTO,FORMA_PAGAMENTO.DESCRICAOFORMA,FORMA_PAGAMENTO.ATIVO FROM FORMA_PAGAMENTO WHERE ATIVO = 'SIM'", conexaoLocal)
        daLocal.Fill(ds)

        dgFuncao.DataSource = ds.Tables(0)
        MudarOperacao(OperacoesCrud.Consulta)
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Close()
    End Sub

    Private Sub FrmCadastroFormaPagamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MudarOperacao(OperacoesCrud.Consulta)

        tbFomaPagamento.TabPages.Remove(tpPesquisa)
        tbFomaPagamento.TabPages.Remove(tpCadastrar)
        tbFomaPagamento.TabPages.Add(tpPesquisa)
    End Sub

    Private Sub txtPesquisar_TextChanged(sender As Object, e As EventArgs) Handles txtPesquisar.TextChanged
        Dim str As String = 0

        If cbxFiltro.Text = "DESCRICAO" Then str = "SELECT FORMA_PAGAMENTO.CODPAGAMENTO,FORMA_PAGAMENTO.DESCRICAOFORMA,FORMA_PAGAMENTO.ATIVO FROM FORMA_PAGAMENTO WHERE ATIVO = 'SIM' and DESCRICAOFORMA LIKE  '%" & txtPesquisar.Text & "%'"

        conexaoLocal.Close()
        conexaoLocal.ConnectionString = bancoLocal
        conexaoLocal.Open()

        Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)
        Dim da As FbDataAdapter = New FbDataAdapter(cmd)
        Dim dt As DataTable = New DataTable
        da.Fill(dt)
        dgFuncao.DataSource = dt

        conexaoLocal.Close()
    End Sub
End Class