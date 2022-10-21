Imports FirebirdSql.Data.FirebirdClient

Public Class FrmLancarProduto
    Public codProduto As String
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean

        If msg.WParam.ToInt32() = CInt(Keys.Enter) Then
            SendKeys.Send("{Tab}")
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    Private Sub txtCodigoProduto_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoProduto.TextChanged
        Dim sql As String
        If (txtCodigoProduto.Text = "") Then
            conexaoLocal.Close()
        Else

            sql = "SELECT * FROM PRODUTOS WHERE CODPRODUTO = " & txtCodigoProduto.Text

            conexaoLocal.Close()
            conexaoLocal.ConnectionString = bancoLocal
            conexaoLocal.Open()

            Dim cmd As FbCommand = New FbCommand(sql, conexaoLocal)
            drLocal = cmd.ExecuteReader

            While drLocal.Read()
                txtNomeProduto.Text = drLocal("DESCRICAO").ToString
                nValorUnitario.Value = CDec(drLocal("PRECO_VENDA"))
                txtCodigoCfop.Text = drLocal("CODCFOP").ToString

                drLocal = cmd.ExecuteReader
                While drLocal.Read
                    txtCodigoNCM.Text = drLocal("NCM").ToString
                End While

                drLocal = cmd.ExecuteReader
                While drLocal.Read
                    txtCodigoCsosn.Text = drLocal("CODCSOSN").ToString
                End While
            End While
        End If
    End Sub

    Private Sub txtCodigoNCM_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoNCM.TextChanged
        If txtCodigoNCM.Text = "" Then
        Else

            Dim str As String
            txtCodigoNCM.Text = Replace(txtCodigoNCM.Text, ".", "")
            str = "SELECT * From PRODUTO_NCM where NCM = '" & txtCodigoNCM.Text & "'"

            conexaoLocal.Close()
            conexaoLocal.ConnectionString = bancoLocal
            conexaoLocal.Open()

            Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)

            drLocal = cmd.ExecuteReader

            While drLocal.Read()
                txtNCM.Text = drLocal("DESCRICAO").ToString
            End While
        End If
    End Sub

    Private Sub txtCodigoCfop_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoCfop.TextChanged
        If txtCodigoCfop.Text = "" Then
        Else
            Dim str As String
            str = "SELECT * From CFOP where CODCFOP =" & txtCodigoCfop.Text

            conexaoLocal.Close()
            conexaoLocal.ConnectionString = bancoLocal
            conexaoLocal.Open()

            Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)

            drLocal = cmd.ExecuteReader

            While drLocal.Read()
                txtCfop.Text = drLocal("NOME_CFO").ToString
            End While
        End If
    End Sub

    Private Sub FrmLancarProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtQuantidade.SelectAll()
        txtQuantidade.Focus()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Close()
    End Sub

    Private Sub txtCodigoCsosn_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoCsosn.TextChanged
        If txtCodigoCsosn.Text = "" Then
        Else

            Dim str As String
            str = "SELECT * From GRUPO_ICMS where CSOSN =" & txtCodigoCsosn.Text

            conexaoLocal.Close()
            conexaoLocal.ConnectionString = bancoLocal
            conexaoLocal.Open()

            Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)

            drLocal = cmd.ExecuteReader

            While drLocal.Read()
                txtCsosn.Text = drLocal("DESCRICAO").ToString
            End While
        End If
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        FrmNotaFiscalEletronica.dgNotaFiscal.Rows.Add(txtCodigoProduto.Text, txtNomeProduto.Text, txtCodigoCfop.Text, txtCodigoCsosn.Text, txtCodigoNCM.Text, txtCodigoCest.Text, nValorUnitario.Value, txtQuantidade.Text, nValorTotal.Value)
        If MessageBox.Show("Deseja lançar outro produto?", "Ambiente Soft", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = vbYes Then
            Close()
            limparTextBoxes(Me)
            txtQuantidade.Text = "0,000"
        Else
            Close()
            FrmConsultaProduto.Close()
        End If
        FrmNotaFiscalEletronica.calculaTotal()
    End Sub

    Private Sub nValorUnitario_Leave(sender As Object, e As EventArgs) Handles nValorUnitario.Leave
        nValorTotal.Value = txtQuantidade.Text * nValorUnitario.Value
    End Sub
    Private Sub FrmLancarProduto_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            MessageBox.Show("Enter key pressed")
        End If
        If e.KeyCode = Keys.F3 Then
            btnConfirmar.PerformClick()
        End If
        If e.KeyCode = Keys.F4 Then
            btnCancelar.PerformClick()
        End If
    End Sub

    Private Sub txtQuantidade_Leave(sender As Object, e As EventArgs) Handles txtQuantidade.Leave
        txtQuantidade.Text = FormatNumber(txtQuantidade.Text, 3)
        nValorTotal.Value = txtQuantidade.Text * nValorUnitario.Value
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
        limparTextBoxes(Me)
    End Sub
End Class