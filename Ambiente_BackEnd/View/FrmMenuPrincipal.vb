Imports System.IO
Imports FirebirdSql.Data.FirebirdClient
Imports MySql.Data.MySqlClient

Public Class FrmMenuPrincipal
    Dim aumentapanel As String
    Public codFuncionario As String
    Public nomeFuncionario As String
    Dim download As New Net.WebClient
    Public Sub DiminuiMenu()
        If aumentapanel = "1" Then
            Panel1.Size = New Size(214, 766)
            btnCadastros.ImageAlign = ContentAlignment.MiddleLeft
            btnMoviementacao.ImageAlign = ContentAlignment.MiddleLeft
            btnCadastroColaborador.ImageAlign = ContentAlignment.MiddleLeft

            btnFuncionarios.ImageAlign = ContentAlignment.MiddleLeft
            btnFuncao.ImageAlign = ContentAlignment.MiddleLeft

            btnCadastroProdutos.ImageAlign = ContentAlignment.MiddleLeft
            btnCusto.ImageAlign = ContentAlignment.MiddleLeft
            btnOperadoresCartao.ImageAlign = ContentAlignment.MiddleLeft
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft
            aumentapanel = 0
        Else
            Panel1.Size = New Size(72, 766)
            btnCadastros.ImageAlign = ContentAlignment.MiddleCenter
            btnMoviementacao.ImageAlign = ContentAlignment.MiddleCenter
            btnCadastroColaborador.ImageAlign = ContentAlignment.MiddleCenter

            btnFuncionarios.ImageAlign = ContentAlignment.MiddleCenter
            btnFuncao.ImageAlign = ContentAlignment.MiddleCenter

            btnCadastroProdutos.ImageAlign = ContentAlignment.MiddleCenter
            btnCusto.ImageAlign = ContentAlignment.MiddleCenter
            btnOperadoresCartao.ImageAlign = ContentAlignment.MiddleCenter
            btnLogout.ImageAlign = ContentAlignment.MiddleCenter
            aumentapanel = 1
            pCadastros.Visible = False
        End If
    End Sub
    Private Sub btnCadastros_Click(sender As Object, e As EventArgs) Handles btnCadastros.Click
        If (pCadastros.Visible = False) Then
            pCadastros.Visible = True
            pMovimentacao.Visible = False
        ElseIf (pCadastros.Visible = True) Then
            pCadastros.Visible = False
        End If
    End Sub
    Private Sub btnMoviementacao_Click(sender As Object, e As EventArgs) Handles btnMoviementacao.Click
        If (pMovimentacao.Visible = False) Then
            pMovimentacao.Visible = True
            pCadastros.Visible = False
        ElseIf (pMovimentacao.Visible = True) Then
            pMovimentacao.Visible = False
        End If
    End Sub
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Close()
    End Sub
    Private Sub btnCadastroColaborador_Click(sender As Object, e As EventArgs) Handles btnCadastroColaborador.Click
        With FrmListaColaborador
            '.TopLevel = False
            'Panel5.Controls.Add(FrmCadastroColaboradores)
            '.Left = (Panel5.Width - .Width) / 2
            '.Top = (Panel5.Height - .Height) / 2
            '.BringToFront()
            DiminuiMenu()
            .ShowDialog()
        End With
    End Sub
    Private Sub btnCadastroProdutos_Click(sender As Object, e As EventArgs) Handles btnCadastroProdutos.Click
        Dim FrmCadastroProdutos As New FrmCadastroProdutos
        With FrmCadastroProdutos
            '.TopLevel = False
            'Panel5.Controls.Add(FrmCadastroProdutos)
            '.Left = (Panel5.Width - .Width) / 2
            '.Top = (Panel5.Height - .Height) / 2
            '.BringToFront()
            DiminuiMenu()
            .ShowDialog()
            DiminuiMenu()
        End With
    End Sub
    Private Sub btnOperadoresCartao_Click(sender As Object, e As EventArgs) Handles btnOperadoresCartao.Click
        With FrmCadastroOperadoresCartao
            '.TopLevel = False
            'Panel5.Controls.Add(FrmCadastroOperadoresCartao)
            '.Left = (Panel5.Width - .Width) / 2
            '.Top = (Panel5.Height - .Height) / 2
            '.BringToFront()
            DiminuiMenu()
            .ShowDialog()
            DiminuiMenu()
        End With
    End Sub
    Private Sub btnCusto_Click(sender As Object, e As EventArgs) Handles btnCusto.Click
        With FrmCadastroCusto
            '.TopLevel = False
            'Panel5.Controls.Add(FrmCadastroCusto)
            '.Left = (Panel5.Width - .Width) / 2
            '.Top = (Panel5.Height - .Height) / 2
            '.BringToFront()
            DiminuiMenu()
            .ShowDialog()
            DiminuiMenu()
        End With
    End Sub
    Private Sub btnFuncionarios_Click(sender As Object, e As EventArgs) Handles btnFuncionarios.Click
        With FrmCadastroFuncionario
            '.TopLevel = False
            'Panel5.Controls.Add(FrmCadastroFuncionario)
            '.Left = (Panel5.Width - .Width) / 2
            '.Top = (Panel5.Height - .Height) / 2
            '.BringToFront()
            DiminuiMenu()
            .ShowDialog()
            DiminuiMenu()
        End With
    End Sub
    Private Sub btnFuncao_Click(sender As Object, e As EventArgs) Handles btnFuncao.Click
        With FrmCadastroFuncao
            '.TopLevel = False
            'Panel5.Controls.Add(FrmCadastroFuncao)
            '.Left = (Panel5.Width - .Width) / 2
            '.Top = (Panel5.Height - .Height) / 2
            '.BringToFront()
            DiminuiMenu()
            .ShowDialog()
            DiminuiMenu()
        End With
    End Sub
    Private Sub btnCategoria_Click(sender As Object, e As EventArgs) Handles btnCategoria.Click
        With FrmCadastroCategoria
            '.TopLevel = False
            'Panel5.Controls.Add(FrmCadastroCategoria)
            '.Left = (Panel5.Width - .Width) / 2
            '.Top = (Panel5.Height - .Height) / 2
            '.BringToFront()
            DiminuiMenu()
            .ShowDialog()
            DiminuiMenu()
        End With
    End Sub
    Private Sub btnFormasPagamento_Click(sender As Object, e As EventArgs) Handles btnFormasPagamento.Click
        With FrmCadastroFormaPagamento
            '.TopLevel = False
            'Panel5.Controls.Add(FrmCadastroFormaPagamento)
            '.Left = (Panel5.Width - .Width) / 2
            '.Top = (Panel5.Height - .Height) / 2
            '.BringToFront()
            DiminuiMenu()
            'DiminuiMenu()
            .ShowDialog()
            DiminuiMenu()
        End With
    End Sub

    Private Sub imgMenu_Click(sender As Object, e As EventArgs) Handles imgMenu.Click
        DiminuiMenu()
    End Sub

    Private Sub btnRelOrcVenda_Click(sender As Object, e As EventArgs) Handles btnRelOrcVenda.Click
        With FrmRelatorioOrcVendas
            '.TopLevel = False
            'Panel5.Controls.Add(FrmRelatorioOrcVendas)
            '.Left = (Panel5.Width - .Width) / 2
            '.Top = (Panel5.Height - .Height) / 2
            '.BringToFront()
            DiminuiMenu()
            'DiminuiMenu()
            .ShowDialog()
            DiminuiMenu()

        End With
    End Sub

    Private Sub btnEntregador_Click(sender As Object, e As EventArgs) Handles btnEntregador.Click
        With FrmCadastroEntregador
            '.TopLevel = False
            'Panel5.Controls.Add(FrmCadastroEntregador)
            '.Left = (Panel5.Width - .Width) / 2
            '.Top = (Panel5.Height - .Height) / 2
            '.BringToFront()
            DiminuiMenu()
            'DiminuiMenu()
            .ShowDialog()
            DiminuiMenu()
        End With
    End Sub
    Private Sub IniciaDownload(ByVal Arquivo As String, ByVal Destino As String)
        Try
            Dim uriOrigem As New Uri(Arquivo)
            download.DownloadFileAsync(uriOrigem, Destino)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Sub FrmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim FrmLogin As New FrmLogin
        lblMenu.Text = "Aguardando Autenticação...."

        Dim str As String
        Dim codCliente As String = LerIni("Empresa", "CodigoCliente")
        Dim importaProdutos As String = LerIni("Banco", "ImportaNuvem")
        str = "SELECT * FROM Cliente WHERE CODCLIENTE = " & codCliente

        conexaoNuvem.Close()
        conexaoNuvem.ConnectionString = bancoNuvem
        conexaoNuvem.Open()

        Dim cmd As MySqlCommand = New MySqlCommand(str, conexaoNuvem)
        drNuvem = cmd.ExecuteReader

        While drNuvem.Read()
            If drNuvem("ATERPBACK").ToString = "SIM" Then
                'If MessageBox.Show("Uma nova versão foi encontrada, deseja atualizar ?", "Nova Versão", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = vbYes Then
                MsgBox("Inciando Atualização Clique em OK e aguarde alguns instantes.....", MsgBoxStyle.Information, "Aviso Importante!")
                File.Delete(Environment.CurrentDirectory + "\Ambiente_BackEnd_Backup.exe")
                My.Computer.FileSystem.RenameFile(Environment.CurrentDirectory + "\Ambiente_BackEnd.exe", "Ambiente_BackEnd_Backup.exe")

                Dim url As String
                url = "http://ambientesoft.com.br/AtualizaSistema/Ambiente_BackEnd.exe"

                IniciaDownload(url, Environment.CurrentDirectory + "\Ambiente_BackEnd.exe")
                System.Threading.Thread.Sleep(5000)
                Try
                    Dim sql As String
                    sql = "UPDATE Cliente Set ATERPBACK = @ATERPBACK where CODCLIENTE  = " & codCliente

                    comandoNuvem = New MySqlCommand(sql, conexaoNuvem)
                    comandoNuvem.Parameters.AddWithValue("@ATERPBACK", "NAO")

                    conexaoNuvem.Close()
                    conexaoNuvem.Open()
                    comandoNuvem.ExecuteNonQuery()

                    MsgBox("Atualização efetuada com sucesso!", MsgBoxStyle.Information, "Aviso Importante!")
                    Application.Exit()
                    Exit While
                Catch ex As Exception
                    MsgBox("Erro ao atualizar sistema: " + ex.Message, MsgBoxStyle.Exclamation)
                End Try
            End If
            If (importaProdutos = "SIM") Then
                btnImportarProdutos.Visible = True
            ElseIf (importaProdutos = "NAO") Then
                btnImportarProdutos.Visible = False
            End If
        End While
        FrmLogin.ShowDialog()
    End Sub

    Private Sub btnNotaFiscalEletronica_Click(sender As Object, e As EventArgs) Handles btnNotaFiscalEletronica.Click
        FrmNotaFiscalEletronica.ShowDialog()
    End Sub

    Public Sub LimpaProdutos()
        Dim sql As String

        sql = "DELETE FROM PRODUTOS"

        comandoLocal = New FbCommand(sql, conexaoLocal)

        conexaoLocal.Close()
        conexaoLocal.Open()
        comandoLocal.ExecuteNonQuery()
        conexaoLocal.Close()
        pImportarProdutos.Value = 50
    End Sub
    Public Sub ImportaProdutos()
        Dim str As String
        Dim descricaoPdv As String
        str = "SELECT * FROM ProdutosNuvem WHERE ATIVO = 'SIM'"

        conexaoAtualiza.Close()
        conexaoAtualiza.ConnectionString = bancoAtualiza
        conexaoAtualiza.Open()

        Dim cmd As MySqlCommand = New MySqlCommand(str, conexaoAtualiza)
        drNuvem = cmd.ExecuteReader
        Try

            While drNuvem.Read()
                Dim sql As String

                'sql = "INSERT INTO PRODUTOS (CODPRODUTO,DESCRICAO) VALUES (@CODPRODUTO,@DESCRICAO)"
                sql = "INSERT INTO PRODUTOS (CODPRODUTO,CODBARRA,DESCRICAO,DESCRICAOPDV,SALDOATUAL,CODCFOP,CODCSOSN,CODICMSCST,CODCOFINSCST,CODPISCST,CODIPI,NCM,ALIQICMS,ALIQICMSBC,ALIQCOFINS,ALIQPIS,ALIQIPI,ALIQNCMFEDERAL,ALIQNCMESTADUAL,ALIQNCMMUNICIPAL,ALIQTOTAL,ATIVO,DATACADASTRO,PRECO_COMPRA,DESCONTO_MAXIMO,PRECO_CUSTO,CUSTO_PERCENTUAL,LUCRO,PRECO_VENDA,BALANCA) VALUES
                                          (@CODPRODUTO,@CODBARRA,@DESCRICAO,@DESCRICAOPDV,@SALDOATUAL,@CODCFOP,@CODCSOSN,@CODICMSCST,@CODCOFINSCST,@CODPISCST,@CODIPI,@NCM,@ALIQICMS,@ALIQICMSBC,@ALIQCOFINS,@ALIQPIS,@ALIQIPI,@ALIQNCMFEDERAL,@ALIQNCMESTADUAL,@ALIQNCMMUNICIPAL,@ALIQTOTAL,@ATIVO,@DATACADASTRO,@PRECO_COMPRA,@DESCONTO_MAXIMO,@PRECO_CUSTO,@CUSTO_PERCENTUAL,@LUCRO,@PRECO_VENDA,@BALANCA)"


                comandoLocal = New FbCommand(sql, conexaoLocal)

                comandoLocal.Parameters.AddWithValue("@CODPRODUTO", drNuvem("idProdutos").ToString)
                comandoLocal.Parameters.AddWithValue("@CODBARRA", drNuvem("codigobarra").ToString)
                comandoLocal.Parameters.AddWithValue("@DESCRICAO", drNuvem("produto").ToString)
                descricaoPdv = drNuvem("produto").ToString
                If descricaoPdv.Length > 19 Then
                    descricaoPdv = descricaoPdv.Substring(0, 20)
                End If
                comandoLocal.Parameters.AddWithValue("@DESCRICAOPDV", descricaoPdv)
                comandoLocal.Parameters.AddWithValue("@SALDOATUAL", "0")
                If (drNuvem("cfop").ToString = "") Then
                    comandoLocal.Parameters.AddWithValue("@CODCFOP", "0")
                Else
                    comandoLocal.Parameters.AddWithValue("@CODCFOP", drNuvem("cfop").ToString)
                End If

                If (drNuvem("csons").ToString = "") Then
                    comandoLocal.Parameters.AddWithValue("@CODCSOSN", "0")
                Else
                    comandoLocal.Parameters.AddWithValue("@CODCSOSN", drNuvem("csons").ToString)
                End If

                If (drNuvem("icms").ToString = "") Then
                    comandoLocal.Parameters.AddWithValue("@CODICMSCST", "0")
                Else
                    comandoLocal.Parameters.AddWithValue("@CODICMSCST", drNuvem("icms").ToString)
                End If

                If (drNuvem("cofins").ToString = "") Then
                    comandoLocal.Parameters.AddWithValue("@CODCOFINSCST", "0")
                Else
                    comandoLocal.Parameters.AddWithValue("@CODCOFINSCST", drNuvem("cofins").ToString)
                End If

                If (drNuvem("pis").ToString = "") Then
                    comandoLocal.Parameters.AddWithValue("@CODPISCST", "0")
                Else
                    comandoLocal.Parameters.AddWithValue("@CODPISCST", drNuvem("pis").ToString)
                End If

                If (drNuvem("ncm").ToString = "") Then
                    comandoLocal.Parameters.AddWithValue("@NCM", "0")
                Else
                    comandoLocal.Parameters.AddWithValue("@NCM", drNuvem("NCM").ToString)
                End If

                If (drNuvem("aliquota").ToString = "") Then
                    comandoLocal.Parameters.AddWithValue("@ALIQTOTAL", "0")
                Else
                    comandoLocal.Parameters.AddWithValue("@ALIQTOTAL", drNuvem("aliquota").ToString)
                End If

                comandoLocal.Parameters.AddWithValue("@CODIPI", "0")
                comandoLocal.Parameters.AddWithValue("@ALIQICMS", "0")
                comandoLocal.Parameters.AddWithValue("@ALIQICMSBC", "0")
                comandoLocal.Parameters.AddWithValue("@ALIQCOFINS", "0")
                comandoLocal.Parameters.AddWithValue("@ALIQPIS", "0")
                comandoLocal.Parameters.AddWithValue("@ALIQIPI", "0")
                comandoLocal.Parameters.AddWithValue("@ALIQNCMFEDERAL", "0")
                comandoLocal.Parameters.AddWithValue("@ALIQNCMESTADUAL", "0")
                comandoLocal.Parameters.AddWithValue("@ALIQNCMMUNICIPAL", "0")
                comandoLocal.Parameters.AddWithValue("@ATIVO", drNuvem("ativo").ToString)
                comandoLocal.Parameters.AddWithValue("@DATACADASTRO", Date.now)
                comandoLocal.Parameters.AddWithValue("@PRECO_VENDA", CDec(drNuvem("precovenda")))
                comandoLocal.Parameters.AddWithValue("@PRECO_COMPRA", "0")
                comandoLocal.Parameters.AddWithValue("@DESCONTO_MAXIMO", "0")
                comandoLocal.Parameters.AddWithValue("@PRECO_CUSTO", CDec(drNuvem("precocusto")))
                comandoLocal.Parameters.AddWithValue("@CUSTO_PERCENTUAL", "0")
                comandoLocal.Parameters.AddWithValue("@LUCRO", "0")
                comandoLocal.Parameters.AddWithValue("@BALANCA", drNuvem("balanca").ToString)

                conexaoLocal.Close()
                conexaoLocal.Open()
                comandoLocal.ExecuteNonQuery()
                conexaoLocal.Close()
            End While
            tImportarProdutos.Enabled = False
            MsgBox("Produtos importados com sucesso", MsgBoxStyle.Information, "Ambiente Soft")
            pImportarProdutos.Value = 100
        Catch ex As Exception
            MsgBox("Erro ao importar produtos: " + ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub btnImportarProdutos_Click(sender As Object, e As EventArgs) Handles btnImportarProdutos.Click
        pImportarProdutos.Visible = True
        pImportarProdutos.Value = 10
        System.Threading.Thread.Sleep(2500)
        LimpaProdutos()
        System.Threading.Thread.Sleep(2000)
        pImportarProdutos.Value = 75
        System.Threading.Thread.Sleep(1000)
        tImportarProdutos.Enabled = True
    End Sub

    Private Sub tImportarProdutos_Tick(sender As Object, e As EventArgs) Handles tImportarProdutos.Tick
        ImportaProdutos()
    End Sub
End Class
