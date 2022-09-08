Imports FirebirdSql.Data.FirebirdClient

Public Class FrmLancarProduto
    Private Sub CarregaProduto(codigoBarra As String)
        Dim str As String
        str = "SELECT * FROM PRODUTOS WHERE CODBARRA = '" + codigoBarra + "'"

        conexaoLocal.Close()
        conexaoLocal.Open()

        Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)

        drLocal = cmd.ExecuteReader

        While drLocal.Read()
            txtNomeProduto.Text = drLocal("DESCRICAO")
            txtCodigoNcm.Text = drLocal("NCM")
            txtCodigoCfop.Text = drLocal("CODCFOP")
        End While
    End Sub

    Private Sub txtCodProduto_Leave(sender As Object, e As EventArgs) Handles txtCodProduto.Leave
        CarregaProduto(txtCodProduto.Text)
    End Sub
End Class