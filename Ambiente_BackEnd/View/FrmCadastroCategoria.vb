Imports FirebirdSql.Data.FirebirdClient

Public Class FrmCadastroCategoria
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

            str = "Select CODCATEGORIA From CATEGORIA ORDER BY CODCATEGORIA DESC"
            conexaoLocal.ConnectionString = bancoLocal
            Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)
            conexaoLocal.Close()
            conexaoLocal.Open()
            drLocal = cmd.ExecuteReader(CommandBehavior.SingleRow)
            If drLocal.HasRows Then
                drLocal.Read()
                txtCodCategoria.Text = drLocal.Item("CODCATEGORIA") + 1
            End If
            If (txtCodCategoria.Text = "") Then
                txtCodCategoria.Text = "1"
            End If
        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Exclamation, "Ambiente Informa")
        Finally
            drLocal.Close()
            conexaoLocal.Close()
        End Try

        MudarOperacao(OperacoesCrud.Inserir)
        tbCategoria.TabPages.Add(tpCadastrar)

        tbCategoria.TabPages.Remove(tpPesquisa)
        txtCodCategoria.Focus()
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim str As String
        Dim codCategoria As Integer
        INDEX = dg_funcionario.SelectedRows(0).Index
        Dim selectedRow As DataGridViewRow

        selectedRow = dg_funcionario.Rows(INDEX)
        codCategoria = selectedRow.Cells(0).Value.ToString()
        str = "SELECT * FROM CATEGORIA WHERE CODCATEGORIA =" & codCategoria
        conexaoLocal.Close()
        conexaoLocal.Open()

        Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)

        drLocal = cmd.ExecuteReader
        While drLocal.Read()

            txtCodCategoria.Text = drLocal("CODCATEGORIA").ToString
            txtDescricao.Text = drLocal("DESCRICAO").ToString
            cbxAtivo.Text = drLocal("ATIVO").ToString

        End While
        tbCategoria.TabPages.Remove(tpPesquisa)
        tbCategoria.TabPages.Add(tpCadastrar)
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
            MsgBox("Erro ao salvar a categoria: " + Environment.NewLine + mensagem, MsgBoxStyle.Exclamation, "AVISO")
            Exit Sub
        End If
        Dim sql As String
        If Operacao = OperacoesCrud.Editar Then
            sql = "UPDATE CATEGORIA SET DESCRICAO = @DESCRICAO,ATIVO = @ATIVO  WHERE CODCATEGORIA = @CODCATEGORIA"
        Else
            sql = "INSERT INTO CATEGORIA (CODCATEGORIA,DESCRICAO,ATIVO) VALUES
                                          (@CODCATEGORIA,@DESCRICAO,@ATIVO)"
        End If
        comandoLocal = New FbCommand(sql, conexaoLocal)

        comandoLocal.Parameters.AddWithValue("@CODCATEGORIA", txtCodCategoria.Text)
        comandoLocal.Parameters.AddWithValue("@DESCRICAO", txtDescricao.Text)
        comandoLocal.Parameters.AddWithValue("@ATIVO", cbxAtivo.Text)


        conexaoLocal.Close()
        conexaoLocal.Open()
        comandoLocal.ExecuteNonQuery()
        conexaoLocal.Close()

        MsgBox("REGISTRO SALVO COM SUCESSO", MsgBoxStyle.Information, "Ambiente Soft")

        limparTextBoxes(Me)
        tbCategoria.TabPages.Remove(tpCadastrar)
        MudarOperacao(OperacoesCrud.Consulta)
        btnpesquisar.PerformClick()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        limparTextBoxes(Me)
        MudarOperacao(OperacoesCrud.Consulta)

        tbCategoria.TabPages.Add(tpPesquisa)
        tbCategoria.TabPages.Remove(tpCadastrar)
    End Sub

    Private Sub btnpesquisar_Click(sender As Object, e As EventArgs) Handles btnpesquisar.Click
        cbxFiltro.Text = "NOME"
        If tbCategoria.TabPages.Contains(tpPesquisa) Then

        Else
            tbCategoria.TabPages.Remove(tpCadastrar)
            tbCategoria.TabPages.Add(tpPesquisa)
        End If
        Dim ds As New DataSet

        If (conexaoLocal.State <> ConnectionState.Closed) Then
            conexaoLocal.Close()
        End If

        daLocal = New FbDataAdapter("SELECT CATEGORIA.CODCATEGORIA,CATEGORIA.DESCRICAO,CATEGORIA.ATIVO FROM CATEGORIA", conexaoLocal)
        daLocal.Fill(ds)

        dg_funcionario.DataSource = ds.Tables(0)
        MudarOperacao(OperacoesCrud.Consulta)
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Close()
    End Sub

    Private Sub FrmCadastroCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MudarOperacao(OperacoesCrud.Consulta)

        tbCategoria.TabPages.Remove(tpPesquisa)
        tbCategoria.TabPages.Remove(tpCadastrar)
        tbCategoria.TabPages.Add(tpPesquisa)
    End Sub
End Class