Imports System.IO
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
        With FrmCadastroColaboradores
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
            ' End If
        End While
        FrmLogin.ShowDialog()
    End Sub

    Private Sub btnNotaFiscalEletronica_Click(sender As Object, e As EventArgs) 
        FrmNotaFiscalEletronica.ShowDialog()
    End Sub
End Class
