Imports FirebirdSql.Data.FirebirdClient

Public Class FrmCadastroFuncao
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

            str = "Select CODFUNCAO From FUNCAO ORDER BY CODFUNCAO DESC"
            conexaoLocal.ConnectionString = bancoLocal
            Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)
            conexaoLocal.Close()
            conexaoLocal.Open()
            drLocal = cmd.ExecuteReader(CommandBehavior.SingleRow)
            If drLocal.HasRows Then
                drLocal.Read()
                txtCodFuncao.Text = drLocal.Item("CODFUNCAO") + 1
            End If
            If (txtCodFuncao.Text = "") Then
                txtCodFuncao.Text = "1"
            End If
        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Exclamation, "Ambiente Informa")
        Finally
            drLocal.Close()
            conexaoLocal.Close()
        End Try

        MudarOperacao(OperacoesCrud.Inserir)
        tbFuncao.TabPages.Add(tpCadastrar)
        tbFuncao.TabPages.Remove(tpPesquisa)
        txtFuncao.Focus()
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim str As String
        Dim codMatriz As Integer
        INDEX = dgFuncao.SelectedRows(0).Index
        Dim selectedRow As DataGridViewRow

        selectedRow = dgFuncao.Rows(INDEX)
        codMatriz = selectedRow.Cells(0).Value.ToString()
        str = "SELECT * FROM FUNCAO WHERE CODFUNCAO =" & codMatriz

        conexaoLocal.Close()
        conexaoLocal.Open()

        Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)

        drLocal = cmd.ExecuteReader
        While drLocal.Read()
            txtCodFuncao.Text = drLocal("CODFUNCAO").ToString
            txtFuncao.Text = drLocal("FUNCAO").ToString
        End While

        tbFuncao.TabPages.Remove(tpPesquisa)
        tbFuncao.TabPages.Add(tpCadastrar)
        MudarOperacao(OperacoesCrud.Editar)

    End Sub

    Private Sub btnsalvar_Click(sender As Object, e As EventArgs) Handles btnsalvar.Click
        Dim data As DateTime
        Dim dataCadastro As String
        Dim mensagem As String = String.Empty


        data = DateTime.Now

        dataCadastro = data.ToString("yyyy-M-dd")

        If txtFuncao.Text = "" Then mensagem += "CAMPO FUNÇÃO ESTÁ VAZIO" + Environment.NewLine

        If (mensagem <> "") Then
            MsgBox("Erro ao salvar a função: " + Environment.NewLine + mensagem, MsgBoxStyle.Exclamation, "AVISO")
            Exit Sub
        End If
        Dim sql As String
        If Operacao = OperacoesCrud.Editar Then
            sql = "UPDATE FUNCAO SET FUNCAO = @FUNCAO,ATIVO = @ATIVO WHERE CODFUNCAO = @CODFUNCAO"
        Else
            sql = "INSERT INTO FUNCAO (CODFUNCAO,FUNCAO,ATIVO) VALUES (@CODFUNCAO,@FUNCAO,@ATIVO)"
        End If
        comandoLocal = New FbCommand(sql, conexaoLocal)

        comandoLocal.Parameters.AddWithValue("@CODFUNCAO", txtCodFuncao.Text)
        comandoLocal.Parameters.AddWithValue("@FUNCAO", txtFuncao.Text)
        comandoLocal.Parameters.AddWithValue("@ATIVO", cbxAtivo.Text)

        conexaoLocal.Close()
        conexaoLocal.Open()
        comandoLocal.ExecuteNonQuery()
        conexaoLocal.Close()

        MsgBox("REGISTRO SALVO COM SUCESSO", MsgBoxStyle.Information, "Ambiente Soft")
        limparTextBoxes(Me)
        tbFuncao.TabPages.Add(tpPesquisa)
        tbFuncao.TabPages.Remove(tpCadastrar)
        MudarOperacao(OperacoesCrud.Consulta)
        btnpesquisar.PerformClick()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        limparTextBoxes(Me)
        MudarOperacao(OperacoesCrud.Consulta)

        tbFuncao.TabPages.Add(tpPesquisa)
        tbFuncao.TabPages.Remove(tpCadastrar)
    End Sub

    Private Sub btnpesquisar_Click(sender As Object, e As EventArgs) Handles btnpesquisar.Click
        cbxFiltro.Text = "FUNÇÃO"
        If tbFuncao.TabPages.Contains(tpPesquisa) Then

        Else
            tbFuncao.TabPages.Remove(tpCadastrar)
            tbFuncao.TabPages.Add(tpPesquisa)
        End If
        Dim ds As New DataSet

        If (conexaoLocal.State <> ConnectionState.Closed) Then
            conexaoLocal.Close()
        End If

        daLocal = New FbDataAdapter("SELECT FUNCAO.CODFUNCAO,FUNCAO.FUNCAO,FUNCAO.ATIVO FROM FUNCAO WHERE ATIVO = 'SIM'", conexaoLocal)
        daLocal.Fill(ds)

        dgFuncao.DataSource = ds.Tables(0)
        MudarOperacao(OperacoesCrud.Consulta)
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Close()
    End Sub

    Private Sub txtPesquisar_TextChanged(sender As Object, e As EventArgs) Handles txtPesquisar.TextChanged
        Dim str As String = 0

        If cbxFiltro.Text = "CODIGO" Then str = "SELECT FUNCAO.CODFUNCAO,FUNCAO.FUNCAO,FUNCAO.ATIVO FROM FUNCAO WHERE ATIVO = 'SIM' and CODFUNCAO LIKE  '%" & txtPesquisar.Text & "%'"
        If cbxFiltro.Text = "FUNÇÃO" Then str = "SELECT FUNCAO.CODFUNCAO,FUNCAO.FUNCAO,FUNCAO.ATIVO FROM FUNCAO WHERE ATIVO = 'SIM' and FUNCAO  LIKE  '%" & txtPesquisar.Text & "%'"

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

    Private Sub FrmCadastroFuncao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MudarOperacao(OperacoesCrud.Consulta)

        tbFuncao.TabPages.Remove(tpPesquisa)
        tbFuncao.TabPages.Remove(tpCadastrar)
        tbFuncao.TabPages.Add(tpPesquisa)
    End Sub
End Class