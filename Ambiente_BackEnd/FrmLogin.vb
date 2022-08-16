Imports FirebirdSql.Data.FirebirdClient

Public Class FrmLogin
    Dim codFuncionairo As String
    Dim nomeFuncionaro As String
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean

        If msg.WParam.ToInt32() = CInt(Keys.Enter) Then
            SendKeys.Send("{Tab}")
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    Private Sub ValidaLogin()
        Dim str As String

        str = "SELECT * FROM FUNCIONARIO WHERE USUARIO = @USUARIO AND SENHA = @SENHA"

        Try
            conexaoLocal.Close()
            conexaoLocal.Open()

            Dim command As FbCommand = New FbCommand(str, conexaoLocal)

            command.Parameters.Add("@USUARIO", FbDbType.VarChar).Value = txtusuario.Text
            command.Parameters.Add("@SENHA", FbDbType.VarChar).Value = txtsenha.Text

            Dim da As New FbDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            drLocal = command.ExecuteReader
            If dt.Rows.Count() <= 0 Then
                txtusuario.Focus()
                MsgBox("Usuário ou/e Senha inválidos !", MsgBoxStyle.Critical, "Falha na operação")
                Exit Sub
            Else
                While drLocal.Read()
                    codFuncionairo = drLocal("CODFUNCIONARIO").ToString
                    nomeFuncionaro = drLocal("NOMEFUNCIONARIO").ToString
                End While

                Dim data As DateTime = DateTime.Now
                FrmMenuPrincipal.lblFuncLogado.Text = nomeFuncionaro
                FrmMenuPrincipal.codFuncionario = codFuncionairo
                FrmMenuPrincipal.nomeFuncionario = nomeFuncionaro

                MsgBox("LOGIN EFETUADO COM SUCESSO", MsgBoxStyle.Information)
                FrmMenuPrincipal.lblMenu.Text = ""
                Close()
            End If
        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Exclamation, "Ambiente Informa")
        End Try
    End Sub

    Private Sub btnentrar_Click(sender As Object, e As EventArgs) Handles btnentrar.Click
        ValidaLogin()
    End Sub

    Private Sub txtsenha_Leave(sender As Object, e As EventArgs) Handles txtsenha.Leave
        ValidaLogin()
    End Sub

    Private Sub btnsair_Click(sender As Object, e As EventArgs) Handles btnsair.Click
        Application.Exit()
    End Sub
End Class