Imports FirebirdSql.Data.FirebirdClient

Public Class FrmItensMovimento
    Public codigoAbertura As String
    Public codigoOrcamento As String
    Public codigoCaixa As String
    Private Sub FrmItensMovimento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As New DataSet

        If (conexaoLocal.State <> ConnectionState.Closed) Then
            conexaoLocal.Close()
        End If

        daLocal = New FbDataAdapter("SELECT MOVIMENTO_ITEM.CODORCAMENTO,MOVIMENTO_ITEM.CODCAIXA,MOVIMENTO_ITEM.NOMEFANTASIA,MOVIMENTO_ITEM.CODABERTURA,MOVIMENTO_ITEM.QUANTIDADE,MOVIMENTO_ITEM.PRECO_VENDA,MOVIMENTO_ITEM.TOTAL_ITEM FROM MOVIMENTO_ITEM WHERE CODABERTURA =" & codigoAbertura & " and CODORCAMENTO =" & codigoOrcamento & " and CODCAIXA =" & codigoCaixa, conexaoLocal)
        daLocal.Fill(ds)

        dgConsultaCliente.DataSource = ds.Tables(0)
    End Sub
End Class