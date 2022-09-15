Imports FirebirdSql.Data.FirebirdClient

Public Class FrmConsultaCliente
    Private Sub FrmConsultaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As New DataSet

        If (conexaoLocal.State <> ConnectionState.Closed) Then
            conexaoLocal.Close()
        End If

        daLocal = New FbDataAdapter("SELECT COLABORADOR.CODCOLABORADOR,COLABORADOR.RAZAOSOCIAL,COLABORADOR.NOMEFANTASIA FROM COLABORADOR WHERE ATIVO = 'SIM'", conexaoLocal)
        daLocal.Fill(ds)

        dgConsultaCliente.DataSource = ds.Tables(0)
    End Sub

    Private Sub dgConsultaCliente_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgConsultaCliente.CellContentDoubleClick

        Dim str As String
        Dim currentRow As DataGridViewRow = dgConsultaCliente.Rows(e.RowIndex)

        str = "SELECT * FROM COLABORADOR WHERE CODCOLABORADOR = " & currentRow.Cells(0).Value.ToString()

        conexaoLocal.Close()
        conexaoLocal.ConnectionString = bancoLocal
        conexaoLocal.Open()

        Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)
        drLocal = cmd.ExecuteReader


        Dim FrmVisualizaCliente As New FrmVisualizaCliente
        While drLocal.Read()
            FrmVisualizaCliente.txtCodigoCliente.Text = drLocal("CODCOLABORADOR").ToString
            FrmVisualizaCliente.txtRazaoSocial.Text = drLocal("RAZAOSOCIAL").ToString
            FrmVisualizaCliente.txtNomeFantasia.Text = drLocal("NOMEFANTASIA").ToString
            FrmVisualizaCliente.txtTelefoneCelular.Text = drLocal("TELEFONE_1").ToString
            FrmVisualizaCliente.txtEmail.Text = drLocal("EMAIL").ToString
            FrmVisualizaCliente.txtCpfCnpj.Text = drLocal("CNPJ_CPF").ToString
            FrmVisualizaCliente.txtInscEstadual.Text = drLocal("INSCESTADUAL").ToString
            FrmVisualizaCliente.txtCep.Text = drLocal("CEP").ToString
            FrmVisualizaCliente.txtEndereco.Text = drLocal("LOGRADOURO").ToString
            FrmVisualizaCliente.txtNumero.Text = drLocal("NUMERO").ToString
            FrmVisualizaCliente.txtBairro.Text = drLocal("BAIRRO").ToString
            FrmVisualizaCliente.txtCidade.Text = drLocal("MUNICIPIO").ToString
            'FrmVisualizaCliente.txtUf.Text = drLocal("MUNICIPIO").ToString
            FrmVisualizaCliente.txtCodigoIbge.Text = drLocal("CODIGOIBGE").ToString

        End While
        FrmVisualizaCliente.ShowDialog()
        ' If (mensagem <> "") Then
        'MsgBox("Dados do Cliente" + Environment.NewLine + mensagem, MsgBoxStyle.Information, "AVISO")
        ' Exit Sub
        ' End If
    End Sub
End Class