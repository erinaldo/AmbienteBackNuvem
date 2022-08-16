Imports FirebirdSql.Data.FirebirdClient

Public Class FrmCadastroEntregador
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

            str = "Select CODENTREGADOR From ENTREGADOR ORDER BY CODENTREGADOR DESC"
            conexaoLocal.ConnectionString = bancoLocal
            Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)
            conexaoLocal.Close()
            conexaoLocal.Open()
            drLocal = cmd.ExecuteReader(CommandBehavior.SingleRow)
            If drLocal.HasRows Then
                drLocal.Read()
                txtCodEntregador.Text = drLocal.Item("CODENTREGADOR") + 1
            End If
            If (txtCodEntregador.Text = "") Then
                txtCodEntregador.Text = "1"
            End If

        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Exclamation, "Ambiente Informa")
        Finally
            drLocal.Close()
            conexaoLocal.Close()
        End Try

        MudarOperacao(OperacoesCrud.Inserir)
        tbEntregador.TabPages.Add(tpCadastrar)
        tbEntregador.TabPages.Remove(tpPesquisa)
        txtCodEntregador.Focus()
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim str As String
        Dim codEntregador As Integer
        INDEX = dgEntregador.SelectedRows(0).Index
        Dim selectedRow As DataGridViewRow

        selectedRow = dgEntregador.Rows(INDEX)
        codEntregador = selectedRow.Cells(0).Value.ToString()
        str = "SELECT * FROM ENTREGADOR WHERE CODENTREGADOR =" & codEntregador
        conexaoLocal.Close()
        conexaoLocal.Open()

        Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)

        drLocal = cmd.ExecuteReader
        While drLocal.Read()

            txtCodEntregador.Text = drLocal("CODENTREGADOR").ToString
            txtNome.Text = drLocal("NOME").ToString
            txtEmpresa.Text = drLocal("EMPRESA").ToString
            txtTelefone.Text = drLocal("TELEFONE").ToString
            cbxAtivo.Text = drLocal("ATIVO").ToString

        End While
        tbEntregador.TabPages.Remove(tpPesquisa)
        tbEntregador.TabPages.Add(tpCadastrar)
        MudarOperacao(OperacoesCrud.Editar)
    End Sub

    Private Sub btnpesquisar_Click(sender As Object, e As EventArgs) Handles btnpesquisar.Click
        cbxFiltro.Text = "NOME"
        If tbEntregador.TabPages.Contains(tpPesquisa) Then

        Else
            tbEntregador.TabPages.Remove(tpCadastrar)
            tbEntregador.TabPages.Add(tpPesquisa)
        End If
        Dim ds As New DataSet

        If (conexaoLocal.State <> ConnectionState.Closed) Then
            conexaoLocal.Close()
        End If

        daLocal = New FbDataAdapter("SELECT ENTREGADOR.CODENTREGADOR,ENTREGADOR.NOME,ENTREGADOR.EMPRESA,ENTREGADOR.ATIVO FROM ENTREGADOR", conexaoLocal)
        daLocal.Fill(ds)

        dgEntregador.DataSource = ds.Tables(0)
        MudarOperacao(OperacoesCrud.Consulta)
    End Sub

    Private Sub btnsalvar_Click(sender As Object, e As EventArgs) Handles btnsalvar.Click
        Dim data As DateTime
        Dim dataCadastro As String
        Dim mensagem As String = String.Empty

        data = DateTime.Now

        dataCadastro = data.ToString("yyyy-M-dd")

        If txtNome.Text = "" Then mensagem += "CAMPO NOME ESTÁ VAZIO" + Environment.NewLine

        If txtEmpresa.Text = "" Then mensagem += "CAMPO EMPRESA ESTÁ VAZIO" + Environment.NewLine

        If txtTelefone.Text = "" Then mensagem += "CAMPO TELEFONE ESTÁ VAZIO" + Environment.NewLine

        If (mensagem <> "") Then
            MsgBox("Erro ao salvar o entregador: " + Environment.NewLine + mensagem, MsgBoxStyle.Exclamation, "AVISO")
            Exit Sub
        End If
        Dim sql As String
        If Operacao = OperacoesCrud.Editar Then
            sql = "UPDATE ENTREGADOR SET NOME = @NOME,EMPRESA = @EMPRESA,TELEFONE = @TELEFONE,ATIVO = @ATIVO  WHERE CODENTREGADOR = @CODENTREGADOR"
        Else
            sql = "INSERT INTO ENTREGADOR (NOME,EMPRESA,TELEFONE,ATIVO) VALUES
                                          (@NOME,@EMPRESA,@TELEFONE,@ATIVO)"
        End If
        comandoLocal = New FbCommand(sql, conexaoLocal)



        comandoLocal.Parameters.AddWithValue("@CODENTREGADOR", txtCodEntregador.Text)
        comandoLocal.Parameters.AddWithValue("@NOME", txtNome.Text)
        comandoLocal.Parameters.AddWithValue("@EMPRESA", txtEmpresa.Text)
        comandoLocal.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text)
        comandoLocal.Parameters.AddWithValue("@ATIVO", cbxAtivo.Text)


        conexaoLocal.Close()
        conexaoLocal.Open()
        comandoLocal.ExecuteNonQuery()
        conexaoLocal.Close()

        MsgBox("REGISTRO SALVO COM SUCESSO", MsgBoxStyle.Information, "Ambiente Soft")

        limparTextBoxes(Me)
        tbEntregador.TabPages.Remove(tpCadastrar)
        MudarOperacao(OperacoesCrud.Consulta)
        btnpesquisar.PerformClick()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        limparTextBoxes(Me)
        MudarOperacao(OperacoesCrud.Consulta)

        tbEntregador.TabPages.Add(tpPesquisa)
        tbEntregador.TabPages.Remove(tpCadastrar)
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Close()
    End Sub

    Private Sub FrmCadastroEntregador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MudarOperacao(OperacoesCrud.Consulta)

        tbEntregador.TabPages.Remove(tpPesquisa)
        tbEntregador.TabPages.Remove(tpCadastrar)
        tbEntregador.TabPages.Add(tpPesquisa)
    End Sub
End Class