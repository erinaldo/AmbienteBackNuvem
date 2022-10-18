Imports FirebirdSql.Data.FirebirdClient

Public Class FrmConsultaGeraDebitos
    Public Sub calculaTotal()
        Dim valor As Decimal

        For Each col As DataGridViewRow In dg_recebimento.Rows
            valor = valor + col.Cells(3).Value
        Next

        txtTotal.Text = valor
        txtTotal.Text = valor
        txtTotal.Text = FormatCurrency(txtTotal.Text, 2)
    End Sub
    Private Sub FrmConsultaGeraDebitos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String



        'str = "SELECT D.CODCAIXA, D.CODCLIENTE,C.RAZAOSOCIAL,D.DATA,sum(D.TOTAL) AS TOTAL FROM DEBITO AS D JOIN COLABORADOR AS C On ( C.CODCOLABORADOR = D.CODCLIENTE ) WHERE GROUP BY  D.CODCAIXA, D.CODCLIENTE,C.RAZAOSOCIAL,D.DATA ORDER BY TOTAL DESC"
        str = "SELECT D.CODCLIENTE,C.RAZAOSOCIAL,sum(D.TOTAL) AS TOTAL FROM DEBITO AS D JOIN COLABORADOR AS C On ( C.CODCOLABORADOR = D.CODCLIENTE )  GROUP BY D.CODCLIENTE,C.RAZAOSOCIAL ORDER BY TOTAL DESC"
        conexaoLocal.Close()
        conexaoLocal.ConnectionString = bancoLocal
        conexaoLocal.Open()

        Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)
        Dim da As FbDataAdapter = New FbDataAdapter(cmd)
        Dim dt As DataTable = New DataTable
        da.Fill(dt)

        dg_recebimento.DataSource = dt
        conexaoLocal.Close()

        If Me.dg_recebimento.Rows.Count <= 0 Then
            MsgBox("Não a pendencias para este cliente!!!", MsgBoxStyle.Information, "SCA - Sistema de controle administrativo")
            Close()
        Else
            calculaTotal()
        End If
    End Sub


    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Close()
    End Sub
End Class