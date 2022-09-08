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
        Select Case e.KeyCode
            Case Keys.F2
                btnImportarItem.PerformClick()
            Case Keys.F3
                btnLancarItem.PerformClick()
            Case Keys.F4
                btnEditarItem.PerformClick()
            Case Keys.Delete
                btnDeletarItem.PerformClick()
        End Select
    End Sub

    Private Sub btnImportarItem_Click(sender As Object, e As EventArgs) Handles btnImportarItem.Click
        'MsgBox("Em Desenvolvimento")

    End Sub

    Private Sub btnLancarItem_Click(sender As Object, e As EventArgs) Handles btnLancarItem.Click
        'MsgBox("Em Desenvolvimento")
        Dim FrmLancaProduto As New FrmLancarProduto
        FrmLancarProduto.ShowDialog()
    End Sub

    Private Sub btnEditarItem_Click(sender As Object, e As EventArgs) Handles btnEditarItem.Click
        MsgBox("Em Desenvolvimento")
    End Sub

    Private Sub btnDeletarItem_Click(sender As Object, e As EventArgs) Handles btnDeletarItem.Click
        MsgBox("Em Desenvolvimento")
    End Sub
End Class