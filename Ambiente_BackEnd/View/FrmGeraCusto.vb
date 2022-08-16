Imports FirebirdSql.Data.FirebirdClient

Public Class FrmGeraCusto
    Public total As Decimal
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        If msg.WParam.ToInt32() = CInt(Keys.Enter) Then
            SendKeys.Send("{Tab}")
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    Private Function CalculaCusto()
        Dim valor As Decimal

        For Each col As DataGridViewRow In dgGeraCusto.Rows
            valor = valor + col.Cells(1).Value
        Next
        nTotal.Value = valor
        Return valor
    End Function
    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click
        If (txtDescricao.Text = "") Then
            dgGeraCusto.Rows.Add(cbxdesc.Text, txtPercentual.Text)
            txtDescricao.Text = ""
            txtPercentual.Text = ""
            txtDescricao.Focus()
            CalculaCusto()
        Else
            dgGeraCusto.Rows.Add(txtDescricao.Text, txtPercentual.Text)
            txtDescricao.Text = ""
            txtPercentual.Text = ""
            txtDescricao.Focus()
            CalculaCusto()
        End If
    End Sub

    Private Sub FrmGeraCusto_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            total = nTotal.Value
            Close()
        End If
    End Sub
    Public Sub CarregaCombobox()
        Try
            Dim geraCusto As String


            geraCusto = "SELECT GERA_CUSTO.* From GERA_CUSTO"

            conexaoLocal.Close()
            conexaoLocal.ConnectionString = bancoLocal
            conexaoLocal.Open()

            Dim cmd As FbCommand = New FbCommand(geraCusto, conexaoLocal)
            Dim da As FbDataAdapter = New FbDataAdapter(cmd)
            Dim dt As DataTable = New DataTable
            da.Fill(dt)
            cbxdesc.ValueMember = "CODGERACUSTO"
            cbxdesc.DisplayMember = "DESCRICAO"


            cbxdesc.DataSource = dt

            conexaoLocal.Close()

        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub PegaPercentual()
        Dim str As String
        Try
            str = "SELECT * FROM GERA_CUSTO WHERE DESCRICAO = '" + cbxdesc.Text + "'"

            conexaoLocal.Close()
            conexaoLocal.Open()

            Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)

            drLocal = cmd.ExecuteReader
            While drLocal.Read()
                txtPercentual.Text = drLocal("PERCENTUAL").ToString
            End While
        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub cbxdesc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxdesc.SelectedIndexChanged
        PegaPercentual()
    End Sub
End Class