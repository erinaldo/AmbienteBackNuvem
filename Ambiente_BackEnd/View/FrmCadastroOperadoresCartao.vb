Imports FirebirdSql.Data.FirebirdClient

Public Class FrmCadastroOperadoresCartao
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

    Private Sub btninserir_Click(sender As Object, e As EventArgs) Handles btninserir.Click
        Try
            Dim str As String

            str = "Select CODOPERADORACARTAO From OPERADORA_CARTAO ORDER BY CODOPERADORACARTAO DESC"
            conexaoLocal.ConnectionString = bancoLocal
            Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)
            conexaoLocal.Close()
            conexaoLocal.Open()
            drLocal = cmd.ExecuteReader(CommandBehavior.SingleRow)
            If drLocal.HasRows Then
                drLocal.Read()
                txtCodProduto.Text = drLocal.Item("CODOPERADORACARTAO") + 1
            End If
            If (txtCodProduto.Text = "") Then
                txtCodProduto.Text = "1"
            End If
        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Exclamation, "Ambiente Informa")
        Finally
            drLocal.Close()
            conexaoLocal.Close()
        End Try

        MudarOperacao(OperacoesCrud.Inserir)
        tbOperadora.TabPages.Add(tpCadastrar)
        tbOperadora.TabPages.Remove(tpPesquisa)
        txtDescricao.Focus()
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim str As String
        Dim codCusto As Integer
        INDEX = dg_funcionario.SelectedRows(0).Index
        Dim selectedRow As DataGridViewRow

        selectedRow = dg_funcionario.Rows(INDEX)
        codCusto = selectedRow.Cells(0).Value.ToString()
        str = "SELECT * FROM OPERADORA_CARTAO WHERE CODOPERADORACARTAO =" & codCusto
        conexaoLocal.Close()
        conexaoLocal.Open()

        Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)

        drLocal = cmd.ExecuteReader
        While drLocal.Read()

            txtCodProduto.Text = drLocal("CODOPERADORACARTAO").ToString
            txtDescricao.Text = drLocal("DESCRICAO").ToString
            nTaxa.Value = drLocal("TAXA").ToString

        End While
        tbOperadora.TabPages.Remove(tpPesquisa)
        tbOperadora.TabPages.Add(tpCadastrar)
        MudarOperacao(OperacoesCrud.Editar)
    End Sub

    Private Sub btnsalvar_Click(sender As Object, e As EventArgs) Handles btnsalvar.Click
        Dim data As DateTime
        Dim dataCadastro As String
        Dim mensagem As String = String.Empty

        data = DateTime.Now

        dataCadastro = data.ToString("yyyy-M-dd")

        If txtDescricao.Text = "" Then mensagem += "CAMPO DESCRIÇÃO ESTÁ VAZIO" + Environment.NewLine

        If (mensagem <> "") Then
            MsgBox("Erro ao salvar o operadora: " + Environment.NewLine + mensagem, MsgBoxStyle.Exclamation, "AVISO")
            Exit Sub
        End If
        Dim sql As String
        If Operacao = OperacoesCrud.Editar Then
            sql = "UPDATE OPERADORA_CARTAO SET DESCRICAO = @DESCRICAO,TAXA = @TAXA  WHERE CODOPERADORACARTAO = @CODOPERADORACARTAO"
        Else
            sql = "INSERT INTO OPERADORA_CARTAO (CODOPERADORACARTAO,DESCRICAO,TAXA) VALUES
                                          (@CODOPERADORACARTAO,@DESCRICAO,@TAXA)"
        End If
        comandoLocal = New FbCommand(sql, conexaoLocal)

        comandoLocal.Parameters.AddWithValue("@CODOPERADORACARTAO", txtCodProduto.Text)
        comandoLocal.Parameters.AddWithValue("@DESCRICAO", txtDescricao.Text)
        comandoLocal.Parameters.AddWithValue("@TAXA", nTaxa.Value)


        conexaoLocal.Close()
        conexaoLocal.Open()
        comandoLocal.ExecuteNonQuery()
        conexaoLocal.Close()

        MsgBox("REGISTRO SALVO COM SUCESSO", MsgBoxStyle.Information, "Ambiente Soft")

        limparTextBoxes(Me)
        tbOperadora.TabPages.Remove(tpCadastrar)
        MudarOperacao(OperacoesCrud.Consulta)
        btnpesquisar.PerformClick()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        limparTextBoxes(Me)
        'tbOperadora.TabPages.Add(tpPesquisa)
        MudarOperacao(OperacoesCrud.Consulta)

        tbOperadora.TabPages.Add(tpPesquisa)
        tbOperadora.TabPages.Remove(tpCadastrar)
    End Sub

    Private Sub btnpesquisar_Click(sender As Object, e As EventArgs) Handles btnpesquisar.Click
        cbxFiltro.Text = "DESCRICAO"
        If tbOperadora.TabPages.Contains(tpPesquisa) Then

        Else
            tbOperadora.TabPages.Remove(tpCadastrar)
            tbOperadora.TabPages.Add(tpPesquisa)
        End If
        Dim ds As New DataSet

        If (conexaoLocal.State <> ConnectionState.Closed) Then
            conexaoLocal.Close()
        End If

        daLocal = New FbDataAdapter("SELECT OPERADORA_CARTAO.CODOPERADORACARTAO,OPERADORA_CARTAO.DESCRICAO,OPERADORA_CARTAO.TAXA FROM OPERADORA_CARTAO", conexaoLocal)
        daLocal.Fill(ds)

        dg_funcionario.DataSource = ds.Tables(0)
        MudarOperacao(OperacoesCrud.Consulta)
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Close()
    End Sub

    Private Sub FrmCadastroOperadoresCartao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MudarOperacao(OperacoesCrud.Consulta)

        tbOperadora.TabPages.Remove(tpPesquisa)
        tbOperadora.TabPages.Remove(tpCadastrar)
        tbOperadora.TabPages.Add(tpPesquisa)
    End Sub

    Private Sub txtPesquisar_TextChanged(sender As Object, e As EventArgs) Handles txtPesquisar.TextChanged
        Dim str As String = 0

        If cbxFiltro.Text = "DESCRICAO" Then str = "SELECT OPERADORA_CARTAO.CODOPERADORACARTAO,OPERADORA_CARTAO.DESCRICAO,OPERADORA_CARTAO.TAXA FROM OPERADORA_CARTAO WHERE DESCRICAO LIKE  '%" & txtPesquisar.Text & "%'"

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