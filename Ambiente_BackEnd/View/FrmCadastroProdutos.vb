Imports FirebirdSql.Data.FirebirdClient

Public Class FrmCadastroProdutos
    Private Operacao As OperacoesCrud
    Dim INDEX As Integer
    Dim estoqueAnterior As String
    Private Sub MudarOperacao(ByVal novaOperacao As OperacoesCrud)
        If novaOperacao = OperacoesCrud.Consulta Then
            btnpesquisar.Enabled = True
            btnimprimir.Enabled = True
            btnsalvar.Enabled = False
            btncancelar.Enabled = False
            btneditar.Enabled = True
            btninserir.Enabled = True
        ElseIf novaOperacao = OperacoesCrud.Inserir OrElse novaOperacao = OperacoesCrud.Editar Then
            btnpesquisar.Enabled = False
            btnimprimir.Enabled = False
            btnsalvar.Enabled = True
            btncancelar.Enabled = True
            btneditar.Enabled = False
            btninserir.Enabled = False
        End If
        Operacao = novaOperacao
    End Sub
    Private Sub FrmCadastroProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MudarOperacao(OperacoesCrud.Consulta)

        tbProduto.TabPages.Remove(tpPesquisa)
        tbProduto.TabPages.Remove(tpCadastrar)
        tbProduto.TabPages.Add(tpPesquisa)
    End Sub

    Private Sub btninserir_Click(sender As Object, e As EventArgs) Handles btninserir.Click
        Try
            Dim str As String

            str = "Select CODPRODUTO From PRODUTOS ORDER BY CODPRODUTO DESC"
            conexaoLocal.ConnectionString = bancoLocal
            Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)
            conexaoLocal.Close()
            conexaoLocal.Open()
            drLocal = cmd.ExecuteReader(CommandBehavior.SingleRow)
            If drLocal.HasRows Then
                drLocal.Read()
                txtCodProduto.Text = drLocal.Item("CODPRODUTO") + 1
            End If
            If (txtCodProduto.Text = "") Then
                txtCodProduto.Text = "1"
            End If
        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Exclamation, "Ambiente Informa")
        Finally
            drLocal.Close()
            conexaoLocal.Close()
        End Try

        MudarOperacao(OperacoesCrud.Inserir)
        tbProduto.TabPages.Add(tpCadastrar)

        tbProduto.TabPages.Remove(tpPesquisa)
        txtCodProduto.Focus()
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim str As String
        Dim codProduto As Integer
        INDEX = dgProdutos.SelectedRows(0).Index
        Dim selectedRow As DataGridViewRow

        selectedRow = dgProdutos.Rows(INDEX)
        codProduto = selectedRow.Cells(0).Value.ToString()
        str = "SELECT * FROM PRODUTOS WHERE CODPRODUTO =" & codProduto
        conexaoLocal.Close()
        conexaoLocal.Open()

        Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)

        drLocal = cmd.ExecuteReader
        While drLocal.Read()

            txtCodProduto.Text = drLocal("CODPRODUTO").ToString
            txtcodbarra.Text = drLocal("CODBARRA").ToString
            txtDescricao.Text = drLocal("DESCRICAO").ToString
            txtdescricaopdv.Text = drLocal("DESCRICAOPDV").ToString
            txtEstoque.Text = drLocal("SALDOATUAL").ToString
            txtcodCfop.Text = drLocal("CODCFOP").ToString

            drLocal = cmd.ExecuteReader
            While drLocal.Read
                txtCodCsosn.Text = drLocal("CODCSOSN").ToString
            End While
            drLocal = cmd.ExecuteReader
            While drLocal.Read
                txtCodIcmsCst.Text = drLocal("CODICMSCST").ToString
            End While
            drLocal = cmd.ExecuteReader
            While drLocal.Read
                txtCodpiscst.Text = drLocal("CODPISCST").ToString
            End While
            drLocal = cmd.ExecuteReader
            While drLocal.Read
                txtCodIpi.Text = drLocal("CODIPI").ToString
            End While
            drLocal = cmd.ExecuteReader
            While drLocal.Read
                txtNcm.Text = drLocal("NCM").ToString
            End While
            drLocal = cmd.ExecuteReader
            While drLocal.Read
                nAliqIcms.Value = drLocal("ALIQICMS").ToString
                nAliqBc.Value = drLocal("ALIQICMSBC").ToString
                nCofins.Value = drLocal("ALIQCOFINS").ToString
                nAliqPis.Value = drLocal("ALIQPIS").ToString
                nAliqIpi.Value = drLocal("ALIQIPI").ToString
                nAliqNcmFederal.Value = drLocal("ALIQNCMFEDERAL").ToString
                nAliqNcmEstadual.Value = drLocal("ALIQNCMESTADUAL").ToString
                nAliqNcmMunicipal.Value = drLocal("ALIQNCMMUNICIPAL").ToString
                nAliqTotal.Value = drLocal("ALIQTOTAL").ToString
                cbxAtivo.Text = drLocal("ATIVO").ToString
                nCompra.Value = (CDec(drLocal("PRECO_COMPRA")))
                nvenda.Value = (CDec(drLocal("PRECO_VENDA")))
                nDescMax.Value = (CDec(drLocal("DESCONTO_MAXIMO")))
                nCusto.Value = (CDec(drLocal("PRECO_CUSTO")))
                nPcusto.Value = (CDec(drLocal("CUSTO_PERCENTUAL")))
                cbxBalanca.Text = drLocal("BALANCA").ToString
                txtDiasValido.Text = drLocal("VALIDADEATUAL").ToString
                cbxPerecivel.Text = drLocal("PERECIVEL").ToString
                txtTipoProduto.Text = drLocal("TIPOPRODUTO").ToString
                cbxInformacaoExtra.Text = drLocal("CODINFEXTRA").ToString
                cbxCargaBalanca.Text = drLocal("CARGABALANCA").ToString


                estoqueAnterior = drLocal("SALDOATUAL").ToString
                txtCodCofinsCst.Text = drLocal("CODCOFINSCST").ToString
            End While
        End While
        tbProduto.TabPages.Remove(tpPesquisa)
        tbProduto.TabPages.Add(tpCadastrar)
        MudarOperacao(OperacoesCrud.Editar)
    End Sub

    Private Sub btnsalvar_Click(sender As Object, e As EventArgs) Handles btnsalvar.Click
        Dim data As DateTime
        Dim dataCadastro As String
        Dim mensagem As String = String.Empty

        data = DateTime.Now

        dataCadastro = data.ToString("yyyy-M-dd")

        If txtDescricao.Text = "" Then mensagem += "CAMPO DESCRIÇÃO ESTÁ VAZIO" + Environment.NewLine

        If txtdescricaopdv.Text = "" Then mensagem += "CAMPO DESCRIÇÃO PDV ESTÁ VAZIO" + Environment.NewLine

        If txtcodbarra.Text = "" Then mensagem += "CAMPO COD BARRA ESTÁ VAZIO" + Environment.NewLine

        If txtEstoque.Text = "" Then mensagem += "CAMPO ESTOQUE ESTÁ VAZIO" + Environment.NewLine

        If cbxBalanca.Text = "" Then mensagem += "CAMPO BALANCA ESTÁ VAZIO" + Environment.NewLine

        If cbxBalanca.Text = "SIM" Then
            If txtDiasValido.Text = "" Then mensagem += "CAMPO DIAS VALIDOS ESTÁ VAZIO" + Environment.NewLine

            If cbxPerecivel.Text = "" Then mensagem += "CAMPO PERECIVEL ESTÁ VAZIO" + Environment.NewLine

            If cbxCargaBalanca.Text = "" Then mensagem += "CAMPO CARGA BALANCA ESTÁ VAZIO" + Environment.NewLine

            If txtTipoProduto.Text = "" Then mensagem += "CAMPO TIPO PRODUTO ESTÁ VAZIO" + Environment.NewLine

            If cbxInformacaoExtra.Text = "" Then mensagem += "CAMPO INFORMAÇÃO EXTRA ESTÁ VAZIO" + Environment.NewLine
        End If

        ' If txtcodCfop.Text = "" Then mensagem += "CAMPO CFOP ESTÁ VAZIO" + Environment.NewLine

        ' If txtCodCsosn.Text = "" Then mensagem += "CAMPO CSOSN ESTÁ VAZIO" + Environment.NewLine

        ' If txtNcm.Text = "" Then mensagem += "CAMPO NCM ESTÁ VAZIO" + Environment.NewLine


        If (mensagem <> "") Then
            MsgBox("Erro ao salvar o produto: " + Environment.NewLine + mensagem, MsgBoxStyle.Exclamation, "AVISO")
            Exit Sub
        End If
        Dim sql As String
        If Operacao = OperacoesCrud.Editar Then
            sql = "UPDATE PRODUTOS SET CODBARRA = @CODBARRA,DESCRICAO = @DESCRICAO, DESCRICAOPDV = @DESCRICAOPDV,SALDOATUAL = @SALDOATUAL,SALDOANTERIOR = @SALDOANTERIOR,
                                          CODCFOP = @CODCFOP,CODCSOSN = @CODCSOSN, CODICMSCST = @CODICMSCST,CODCOFINSCST = @CODCOFINSCST, CODPISCST = @CODPISCST,
                                          CODIPI = @CODIPI,NCM = @NCM,ALIQICMS = @ALIQICMS,ALIQICMSBC = @ALIQICMSBC,ALIQCOFINS = @ALIQCOFINS,ALIQPIS = @ALIQPIS,ALIQIPI = @ALIQIPI,
                                          ALIQNCMFEDERAL = @ALIQNCMFEDERAL,ALIQNCMESTADUAL = @ALIQNCMESTADUAL,ALIQNCMMUNICIPAL = @ALIQNCMMUNICIPAL,ALIQTOTAL = @ALIQTOTAL,ATIVO = @ATIVO,DATAALTERACAO = @DATAALTERACAO,PRECO_COMPRA = @PRECO_COMPRA,DESCONTO_MAXIMO = @DESCONTO_MAXIMO,PRECO_CUSTO = @PRECO_CUSTO,CUSTO_PERCENTUAL = @CUSTO_PERCENTUAL,LUCRO = @LUCRO,PRECO_VENDA = @PRECO_VENDA,BALANCA  = @BALANCA,VALIDADEATUAL = @VALIDADEATUAL,PERECIVEL = @PERECIVEL,TIPOPRODUTO = @TIPOPRODUTO,CODINFEXTRA = @CODINFEXTRA,CARGABALANCA = @CARGABALANCA  WHERE CODPRODUTO = @CODPRODUTO"
        Else
            sql = "INSERT INTO PRODUTOS (CODPRODUTO,CODBARRA,DESCRICAO,DESCRICAOPDV,SALDOATUAL,CODCFOP,CODCSOSN,CODICMSCST,CODCOFINSCST,CODPISCST,CODIPI,NCM,ALIQICMS,ALIQICMSBC,ALIQCOFINS,ALIQPIS,ALIQIPI,ALIQNCMFEDERAL,ALIQNCMESTADUAL,ALIQNCMMUNICIPAL,ALIQTOTAL,ATIVO,DATACADASTRO,PRECO_COMPRA,DESCONTO_MAXIMO,PRECO_CUSTO,CUSTO_PERCENTUAL,LUCRO,PRECO_VENDA,BALANCA,VALIDADEATUAL,PERECIVEL,TIPOPRODUTO,CODINFEXTRA,CARGABALANCA) VALUES
                                          (@CODPRODUTO,@CODBARRA,@DESCRICAO,@DESCRICAOPDV,@SALDOATUAL,@CODCFOP,@CODCSOSN,@CODICMSCST,@CODCOFINSCST,@CODPISCST,@CODIPI,@NCM,@ALIQICMS,@ALIQICMSBC,@ALIQCOFINS,@ALIQPIS,@ALIQIPI,@ALIQNCMFEDERAL,@ALIQNCMESTADUAL,@ALIQNCMMUNICIPAL,@ALIQTOTAL,@ATIVO,@DATACADASTRO,@PRECO_COMPRA,@DESCONTO_MAXIMO,@PRECO_CUSTO,@CUSTO_PERCENTUAL,@LUCRO,@PRECO_VENDA,@BALANCA,@VALIDADEATUAL,@PERECIVEL,@TIPOPRODUTO,@CODINFEXTRA,@CARGABALANCA)"
        End If
        comandoLocal = New FbCommand(sql, conexaoLocal)

        If Operacao = OperacoesCrud.Editar Then
            comandoLocal.Parameters.AddWithValue("@DATAALTERACAO", dataCadastro)
            comandoLocal.Parameters.AddWithValue("@SALDOANTERIOR", estoqueAnterior)
        End If

        comandoLocal.Parameters.AddWithValue("@CODPRODUTO", txtCodProduto.Text)
        comandoLocal.Parameters.AddWithValue("@CODBARRA", txtcodbarra.Text)
        comandoLocal.Parameters.AddWithValue("@DESCRICAO", txtDescricao.Text)
        comandoLocal.Parameters.AddWithValue("@DESCRICAOPDV", txtdescricaopdv.Text)
        comandoLocal.Parameters.AddWithValue("@SALDOATUAL", txtEstoque.Text)

        comandoLocal.Parameters.AddWithValue("@CODCFOP", txtcodCfop.Text)
        comandoLocal.Parameters.AddWithValue("@CODCSOSN", txtCodCsosn.Text)
        comandoLocal.Parameters.AddWithValue("@CODICMSCST", txtCodIcmsCst.Text)
        comandoLocal.Parameters.AddWithValue("@CODCOFINSCST", txtCodCofinsCst.Text)
        comandoLocal.Parameters.AddWithValue("@CODPISCST", txtCodpiscst.Text)
        comandoLocal.Parameters.AddWithValue("@CODIPI", txtCodIpi.Text)
        comandoLocal.Parameters.AddWithValue("@NCM", txtNcm.Text)
        comandoLocal.Parameters.AddWithValue("@ALIQICMS", nAliqIcms.Value)
        comandoLocal.Parameters.AddWithValue("@ALIQICMSBC", nAliqBc.Value)
        comandoLocal.Parameters.AddWithValue("@ALIQCOFINS", nCofins.Value)
        comandoLocal.Parameters.AddWithValue("@ALIQPIS", nAliqPis.Value)
        comandoLocal.Parameters.AddWithValue("@ALIQIPI", nAliqIpi.Value)
        comandoLocal.Parameters.AddWithValue("@ALIQNCMFEDERAL", nAliqNcmFederal.Value)
        comandoLocal.Parameters.AddWithValue("@ALIQNCMESTADUAL", nAliqNcmEstadual.Value)
        comandoLocal.Parameters.AddWithValue("@ALIQNCMMUNICIPAL", nAliqNcmMunicipal.Value)
        comandoLocal.Parameters.AddWithValue("@ALIQTOTAL", nAliqTotal.Value)
        comandoLocal.Parameters.AddWithValue("@ATIVO", cbxAtivo.Text)
        comandoLocal.Parameters.AddWithValue("@DATACADASTRO", dataCadastro)
        comandoLocal.Parameters.AddWithValue("@PRECO_VENDA", nvenda.Value)
        comandoLocal.Parameters.AddWithValue("@PRECO_COMPRA", nCompra.Value)
        comandoLocal.Parameters.AddWithValue("@DESCONTO_MAXIMO", lblDescMax.Text)
        comandoLocal.Parameters.AddWithValue("@PRECO_CUSTO", nCusto.Value)
        comandoLocal.Parameters.AddWithValue("@CUSTO_PERCENTUAL", nPcusto.Value)
        comandoLocal.Parameters.AddWithValue("@LUCRO", nLucroM.Value)
        comandoLocal.Parameters.AddWithValue("@BALANCA", cbxBalanca.Text)
        comandoLocal.Parameters.AddWithValue("@VALIDADEATUAL", txtDiasValido.Text)
        comandoLocal.Parameters.AddWithValue("@PERECIVEL", cbxPerecivel.Text)
        comandoLocal.Parameters.AddWithValue("@TIPOPRODUTO", txtTipoProduto.Text)
        comandoLocal.Parameters.AddWithValue("@CODINFEXTRA", cbxInformacaoExtra.SelectedValue)
        comandoLocal.Parameters.AddWithValue("@CARGABALANCA", cbxCargaBalanca.Text)

        conexaoLocal.Close()
        conexaoLocal.Open()
        comandoLocal.ExecuteNonQuery()
        conexaoLocal.Close()

        MsgBox("REGISTRO SALVO COM SUCESSO", MsgBoxStyle.Information, "Ambiente Soft")

        limparTextBoxes(Me)
        tbProduto.TabPages.Add(tpPesquisa)
        tbProduto.TabPages.Remove(tpCadastrar)
        MudarOperacao(OperacoesCrud.Consulta)
        btnpesquisar.PerformClick()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        limparTextBoxes(Me)
        MudarOperacao(OperacoesCrud.Consulta)

        tbProduto.TabPages.Add(tpPesquisa)
        tbProduto.TabPages.Remove(tpCadastrar)
    End Sub
    Private Sub carregaDados()
        If tbProduto.TabPages.Contains(tpPesquisa) Then

        Else
            tbProduto.TabPages.Remove(tpCadastrar)
            tbProduto.TabPages.Add(tpPesquisa)
        End If
        Dim ds As New DataSet

        If (conexaoLocal.State <> ConnectionState.Closed) Then
            conexaoLocal.Close()
        End If

        daLocal = New FbDataAdapter("SELECT PRODUTOS.CODPRODUTO,PRODUTOS.CODBARRA,PRODUTOS.DESCRICAO,PRODUTOS.PRECO_VENDA,PRODUTOS.ATIVO FROM PRODUTOS WHERE ATIVO = 'SIM'", conexaoLocal)
        daLocal.Fill(ds)

        dgProdutos.DataSource = ds.Tables(0)
        MudarOperacao(OperacoesCrud.Consulta)
    End Sub
    Private Sub btnpesquisar_Click(sender As Object, e As EventArgs) Handles btnpesquisar.Click
        carregaDados()
    End Sub

    Private Sub txtPesquisar_TextChanged(sender As Object, e As EventArgs) Handles txtPesquisar.TextChanged
        Dim str As String = 0
        Dim ds As New DataSet
        If (txtPesquisar.Text <> "") Then
            If cbxFiltro.Text = "Codigo Barra" Then str = "SELECT PRODUTOS.CODPRODUTO,PRODUTOS.CODBARRA,PRODUTOS.DESCRICAO,PRODUTOS.PRECO_VENDA,PRODUTOS.ATIVO FROM PRODUTOS WHERE ATIVO = 'SIM' and CODBARRA = '" + txtPesquisar.Text + "'"
            If cbxFiltro.Text = "Descricao" Then str = "Select PRODUTOS.CODPRODUTO,PRODUTOS.CODBARRA,PRODUTOS.DESCRICAO,PRODUTOS.PRECO_VENDA,PRODUTOS.ATIVO FROM PRODUTOS WHERE ATIVO = 'SIM' and DESCRICAO  LIKE  '%" & txtPesquisar.Text & "%'"

            daLocal = New FbDataAdapter(str, conexaoLocal)
            daLocal.Fill(ds)

            conexaoLocal.Close()
            conexaoLocal.ConnectionString = bancoLocal
            conexaoLocal.Open()

            Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)
            Dim da As FbDataAdapter = New FbDataAdapter(cmd)
            Dim dt As DataTable = New DataTable
            da.Fill(dt)
            dgProdutos.DataSource = dt

            conexaoLocal.Close()
        Else
            CarregaDados()
        End If
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Close()
    End Sub

    Private Sub nPcusto_Enter(sender As Object, e As EventArgs) Handles nPcusto.Enter
        If MessageBox.Show("Deseja gerar custo?", "Ambiente Soft", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            FrmGeraCusto.lblPrecoCompra.Text = nCompra.Value
            FrmGeraCusto.CarregaCombobox()
            FrmGeraCusto.ShowDialog()
            nPcusto.Value = FrmGeraCusto.total
            lblCusto.Text = (CDec(nCompra.Value)) * (CDec(nPcusto.Value)) / 100
            lblCusto.Text = FormatNumber(lblCusto.Text, 2)
            nCusto.Value = (CDec(nCompra.Value)) + (CDec(lblCusto.Text))
        End If
    End Sub
    Private Sub ValidaCodBarra()
        If txtcodbarra.Text = "" Then

        Else
            If Operacao = OperacoesCrud.Inserir Then
                Dim str As String
                Dim mensagem As String = String.Empty

                str = "SELECT * FROM PRODUTOS WHERE CODBARRA =" & txtcodbarra.Text

                conexaoLocal.Close()
                conexaoLocal.ConnectionString = bancoLocal
                conexaoLocal.Open()

                Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)


                drLocal = cmd.ExecuteReader

                Dim codBarra As String

                While drLocal.Read()

                    codBarra = drLocal("CODBARRA").ToString

                    If codBarra <> "" Then mensagem += "Já existe um produto com este codigo barra cadastrado" + Environment.NewLine
                    If codBarra <> "" Then mensagem += "Codigo: " + drLocal("CODPRODUTO").ToString + Environment.NewLine
                    If codBarra <> "" Then mensagem += "Descrição: " + drLocal("DESCRICAO").ToString + Environment.NewLine
                    If codBarra <> "" Then mensagem += "Codigo Baraa: " + txtcodbarra.Text + Environment.NewLine

                    If (codBarra <> "") Then
                        MsgBox(Environment.NewLine + mensagem, MsgBoxStyle.Information, "AVISO")
                        txtcodbarra.Focus()
                        Exit Sub
                    End If
                End While
            End If
        End If
    End Sub
    Private Sub txtcodbarra_Leave(sender As Object, e As EventArgs) Handles txtcodbarra.Leave
        ValidaCodBarra()
    End Sub

    Private Sub txtDescricao_Leave(sender As Object, e As EventArgs) Handles txtDescricao.Leave
        txtdescricaopdv.Text = txtDescricao.Text
    End Sub

    Private Sub txtcodCfop_TextChanged(sender As Object, e As EventArgs) Handles txtcodCfop.TextChanged
        If txtcodCfop.Text = "" Then
        Else

            'txtdesccfop.Text = ""
            Dim str As String
            str = "SELECT * From CFOP where CODCFOP =" & txtcodCfop.Text

            conexaoLocal.Close()
            conexaoLocal.ConnectionString = bancoLocal
            conexaoLocal.Open()

            Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)

            drLocal = cmd.ExecuteReader

            While drLocal.Read()
                txtdesccfop.Text = drLocal("NOME_CFO").ToString
            End While

        End If
    End Sub

    Private Sub txtCodCsosn_TextChanged(sender As Object, e As EventArgs) Handles txtCodCsosn.TextChanged
        If txtCodCsosn.Text = "" Then
        Else

            Dim str As String
            str = "SELECT * From GRUPO_ICMS where CSOSN =" & txtCodCsosn.Text

            conexaoLocal.Close()
            conexaoLocal.ConnectionString = bancoLocal
            conexaoLocal.Open()

            Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)

            drLocal = cmd.ExecuteReader

            While drLocal.Read()
                txtDescCsosn.Text = drLocal("DESCRICAO").ToString
            End While
        End If
    End Sub

    Private Sub txtCodIcmsCst_TextChanged(sender As Object, e As EventArgs) Handles txtCodIcmsCst.TextChanged
        If txtCodIcmsCst.Text = "" Then

        Else

            Dim str As String
            str = "SELECT * From GRUPO_CSTRN where COD =" & txtCodIcmsCst.Text

            conexaoLocal.Close()
            conexaoLocal.ConnectionString = bancoLocal
            conexaoLocal.Open()

            Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)

            drLocal = cmd.ExecuteReader

            While drLocal.Read()
                txtdescicmscst.Text = drLocal("DESCRICAO").ToString
            End While
        End If
    End Sub

    Private Sub txtCodCofinsCst_TextChanged(sender As Object, e As EventArgs) Handles txtCodCofinsCst.TextChanged
        If txtCodCofinsCst.Text = "" Then
        Else

            Dim str As String
            str = "SELECT * From GRUPO_COFINS where COD =" & txtCodCofinsCst.Text

            conexaoLocal.Close()
            conexaoLocal.ConnectionString = bancoLocal
            conexaoLocal.Open()

            Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)

            drLocal = cmd.ExecuteReader

            While drLocal.Read()
                txtDescConfinsCst.Text = drLocal("DESCRICAO").ToString
            End While
        End If
    End Sub

    Private Sub txtCodpiscst_TextChanged(sender As Object, e As EventArgs) Handles txtCodpiscst.TextChanged
        If txtCodpiscst.Text = "" Then
        Else

            Dim str As String
            str = "SELECT * From GRUPO_PIS where COD =" & txtCodpiscst.Text

            conexaoLocal.Close()
            conexaoLocal.ConnectionString = bancoLocal
            conexaoLocal.Open()

            Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)

            drLocal = cmd.ExecuteReader

            While drLocal.Read()
                txtDescpiscst.Text = drLocal("DESCRICAO").ToString
            End While

        End If
    End Sub

    Private Sub txtCodIpi_TextChanged(sender As Object, e As EventArgs) Handles txtCodIpi.TextChanged
        If txtCodIpi.Text = "" Then
        Else

            Dim str As String
            str = "SELECT * From GRUPO_IPI where COD =" & txtCodIpi.Text

            conexaoLocal.Close()
            conexaoLocal.ConnectionString = bancoLocal
            conexaoLocal.Open()

            Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)

            drLocal = cmd.ExecuteReader

            While drLocal.Read()
                txtDescipi.Text = drLocal("DESCRICAO").ToString
            End While
        End If
    End Sub

    Private Sub txtNcm_TextChanged(sender As Object, e As EventArgs) Handles txtNcm.TextChanged
        If txtNcm.Text = "" Then
        Else

            Dim str As String
            str = "SELECT * From PRODUTO_NCM where NCM = " & txtNcm.Text

            conexaoLocal.Close()
            conexaoLocal.ConnectionString = bancoLocal
            conexaoLocal.Open()

            Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)

            drLocal = cmd.ExecuteReader

            While drLocal.Read()
                txtDescNcm.Text = drLocal("DESCRICAO").ToString
                nAliqNcmFederal.Value = CDec(drLocal("NFEDERAL"))
                nAliqNcmEstadual.Value = CDec(drLocal("ESTADUAL"))
                nAliqNcmMunicipal.Value = CDec(drLocal("MUNICIPAL"))


            End While
            Dim ALIQ_NCM_FEDERAL As Decimal
            Dim ALIQ_NCM_ESTADUAL As Decimal
            Dim ALIQ_NCM_MUNICIPAL As Decimal
            Dim ALIQ_TOTAL As Decimal

            ALIQ_NCM_FEDERAL = nAliqNcmFederal.Value
            ALIQ_NCM_ESTADUAL = nAliqNcmEstadual.Value
            ALIQ_NCM_MUNICIPAL = nAliqNcmMunicipal.Value

            ALIQ_TOTAL = ALIQ_NCM_FEDERAL + ALIQ_NCM_MUNICIPAL + ALIQ_NCM_ESTADUAL

            nAliqTotal.Value = ALIQ_TOTAL
        End If
    End Sub

    Private Sub imgCfop_Click(sender As Object, e As EventArgs) Handles imgCfop.Click
        Dim FrmConsultaImposto As New FrmConsultaImposto
        FrmConsultaImposto.tipoConsulta = "1"
        FrmConsultaImposto.ShowDialog()
        txtcodCfop.Text = FrmConsultaImposto.codImposto
    End Sub

    Private Sub imgCsosn_Click(sender As Object, e As EventArgs) Handles imgCsosn.Click

        Dim FrmConsultaImpostos As New FrmConsultaImposto
        FrmConsultaImpostos.tipoConsulta = "2"
        FrmConsultaImpostos.ShowDialog()
        txtCodCsosn.Text = FrmConsultaImpostos.codImposto
    End Sub

    Private Sub imgicmscst_Click(sender As Object, e As EventArgs) Handles imgicmscst.Click
        Dim FrmConsultaImpostos As New FrmConsultaImposto
        FrmConsultaImpostos.tipoConsulta = "3"
        FrmConsultaImpostos.ShowDialog()
        txtCodIcmsCst.Text = FrmConsultaImpostos.codImposto

    End Sub

    Private Sub imgPiscst_Click(sender As Object, e As EventArgs) Handles imgPiscst.Click
        Dim FrmConsultaImpostos As New FrmConsultaImposto
        FrmConsultaImpostos.tipoConsulta = "5"
        FrmConsultaImpostos.ShowDialog()
        txtCodpiscst.Text = FrmConsultaImpostos.codImposto
    End Sub

    Private Sub imgIpi_Click(sender As Object, e As EventArgs) Handles imgIpi.Click
        Dim FrmConsultaImpostos As New FrmConsultaImposto
        FrmConsultaImpostos.tipoConsulta = "6"
        FrmConsultaImpostos.ShowDialog()
        txtCodIpi.Text = FrmConsultaImpostos.codImposto
    End Sub

    Private Sub imgNcm_Click(sender As Object, e As EventArgs) Handles imgNcm.Click
        Dim FrmConsultaImpostos As New FrmConsultaImposto
        FrmConsultaImpostos.tipoConsulta = "7"
        FrmConsultaImpostos.ShowDialog()
        txtNcm.Text = FrmConsultaImpostos.codImposto
    End Sub
    Private Sub cbxInformacaoExtra_Enter(sender As Object, e As EventArgs) Handles cbxInformacaoExtra.Enter
        Try
            Dim informacaoExtra As String

            informacaoExtra = "SELECT TOLEDO_INFORMACOES.* From TOLEDO_INFORMACOES"

            conexaoLocal.Close()
            conexaoLocal.ConnectionString = bancoLocal
            conexaoLocal.Open()

            Dim cmd As FbCommand = New FbCommand(informacaoExtra, conexaoLocal)
            Dim da As FbDataAdapter = New FbDataAdapter(cmd)
            Dim dt As DataTable = New DataTable
            da.Fill(dt)
            cbxInformacaoExtra.ValueMember = "CODIGOINFORMACAO"
            cbxInformacaoExtra.DisplayMember = "CODIGOINFORMACAO"

            cbxInformacaoExtra.DataSource = dt

            conexaoLocal.Close()
        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
    Private Sub GeraArquivoBalanca()
        Dim str As String
        Dim caminhoArquivo As String
        Dim codDepartamento As String
        Dim sbec As String = 0
        Dim informacaoExtra As String
        Dim caminhoBalanca As String = LerIni("Balanca", "CaminhoBalanca")
        Dim tipoProduto As String = LerIni("Balanca", "ExportaBalanca")

        Try


            str = "Select PRODUTOS.*,TOLEDO_INFORMACOES.INFORMACAO " &
                                             "FROM PRODUTOS LEFT JOIN TOLEDO_INFORMACOES On PRODUTOS.CODINFEXTRA = TOLEDO_INFORMACOES.CODIGOINFORMACAO " &
                                             "WHERE (((PRODUTOS.BALANCA)='SIM') And ((PRODUTOS.CARGABALANCA) = 'SIM') And" &
                                             "(Not (PRODUTOS.DESCRICAO) Is Null));"

            conexaoLocal.Close()
            conexaoLocal.ConnectionString = bancoLocal
            conexaoLocal.Open()

            Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)

            drLocal = cmd.ExecuteReader

            caminhoArquivo = caminhoBalanca + "balanca.bal"

            FileOpen(1, caminhoArquivo, OpenMode.Output)
            While drLocal.Read()
                codDepartamento = "1"

                Select Case tipoProduto
                    Case "CodigoDoProduto"
                        sbec = drLocal("CODPRODUTO").ToString
                    Case "CodigoBarra"
                        sbec = drLocal("CODBARRA").ToString
                End Select

                informacaoExtra = drLocal("INFORMACAO").ToString

                PrintLine(1,
                          codDepartamento & "|" &
                          drLocal("TIPOPRODUTO").ToString & "|" &
                          sbec & "|" &
                          drLocal("DESCRICAO").ToString & "|" &
                          Replace(drLocal("PRECO_VENDA").ToString, ",", ".") & "|" &
                          drLocal("VALIDADEATUAL").ToString & "|" &
                          "46" & "|" &
                          informacaoExtra)
            End While
            FileClose(1)

            MsgBox("Produtos Exportados com Sucesso!", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Erro ao Gerar Arquivo de Balanca: " + ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
    Private Sub btnGerarArquivoBalanca_Click(sender As Object, e As EventArgs) Handles btnGerarArquivoBalanca.Click
        GeraArquivoBalanca()
    End Sub

    Private Sub btnGeraEtiqueta_Click(sender As Object, e As EventArgs) Handles btnGeraEtiqueta.Click
        'FrmRelEtiqueta.ShowDialog()
        FrmEscolheEtiqueta.ShowDialog()
    End Sub
End Class