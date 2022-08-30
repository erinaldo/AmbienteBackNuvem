Public Class FrmNotaFiscalEletronica
    Dim funcao As String = ""
    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        If funcao = "" Then
            rtbInformaçõesComplementares.Text = ""
            funcao = "1"
            btnLimpar.Text = "Preencher"
        ElseIf funcao = "1" Then
            rtbInformaçõesComplementares.Text = "DOCUMENTO EMITIDO POR ME OU EPP,OPTANTE PELO SIMPLES NACIONAL NAO GERA DIREITO A CREDITO FINAL DE IPI. " + rtbInformaçõesComplementares.Text
            funcao = ""
            btnLimpar.Text = "Enviar"
        End If
    End Sub



    Private Sub FrmNotaFiscalEletronica_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.Control + Keys.I Then
            btnImportarItem.PerformClick()
        End If
        If e.KeyData = Keys.Control + Keys.L Then
            btnLancarItem.PerformClick()
        End If
        If e.KeyData = Keys.Control + Keys.A Then
            btnEditarItem.PerformClick()
        End If
        If e.KeyData = Keys.Delete Then
            btnDeletarItem.PerformClick()
        End If
    End Sub

    Private Sub btnImportarItem_Click(sender As Object, e As EventArgs) Handles btnImportarItem.Click
        MsgBox("Em Desenvolvimento")
    End Sub

    Private Sub btnLancarItem_Click(sender As Object, e As EventArgs) Handles btnLancarItem.Click
        MsgBox("Em Desenvolvimento")
    End Sub

    Private Sub btnEditarItem_Click(sender As Object, e As EventArgs) Handles btnEditarItem.Click
        MsgBox("Em Desenvolvimento")
    End Sub

    Private Sub btnDeletarItem_Click(sender As Object, e As EventArgs) Handles btnDeletarItem.Click
        MsgBox("Em Desenvolvimento")
    End Sub
End Class