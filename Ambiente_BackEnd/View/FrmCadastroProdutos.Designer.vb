<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCadastroProdutos
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCadastroProdutos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tbProduto = New System.Windows.Forms.TabControl()
        Me.tpCadastrar = New System.Windows.Forms.TabPage()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbxCargaBalanca = New System.Windows.Forms.ComboBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.cbxInformacaoExtra = New System.Windows.Forms.ComboBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtTipoProduto = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.cbxBalanca = New System.Windows.Forms.ComboBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.cbxPerecivel = New System.Windows.Forms.ComboBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtDiasValido = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.txtEstoque = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.grpPreco = New System.Windows.Forms.GroupBox()
        Me.nPcusto = New System.Windows.Forms.NumericUpDown()
        Me.lblCusto = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.nLucroM = New System.Windows.Forms.NumericUpDown()
        Me.nvenda = New System.Windows.Forms.NumericUpDown()
        Me.nLucro = New System.Windows.Forms.NumericUpDown()
        Me.nCusto = New System.Windows.Forms.NumericUpDown()
        Me.nDescMax = New System.Windows.Forms.NumericUpDown()
        Me.nCompra = New System.Windows.Forms.NumericUpDown()
        Me.lblDescMax = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.nAliqTotal = New System.Windows.Forms.NumericUpDown()
        Me.nAliqIpi = New System.Windows.Forms.NumericUpDown()
        Me.nAliqPis = New System.Windows.Forms.NumericUpDown()
        Me.nCofins = New System.Windows.Forms.NumericUpDown()
        Me.nAliqBc = New System.Windows.Forms.NumericUpDown()
        Me.nAliqIcms = New System.Windows.Forms.NumericUpDown()
        Me.nAliqNcmMunicipal = New System.Windows.Forms.NumericUpDown()
        Me.nAliqNcmEstadual = New System.Windows.Forms.NumericUpDown()
        Me.nAliqNcmFederal = New System.Windows.Forms.NumericUpDown()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.imgIpi = New System.Windows.Forms.PictureBox()
        Me.txtDescipi = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.imgNcm = New System.Windows.Forms.PictureBox()
        Me.txtDescNcm = New System.Windows.Forms.TextBox()
        Me.txtNcm = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtCodIpi = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.imgPiscst = New System.Windows.Forms.PictureBox()
        Me.txtDescpiscst = New System.Windows.Forms.TextBox()
        Me.txtCodpiscst = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.imgCofinscst = New System.Windows.Forms.PictureBox()
        Me.txtDescConfinsCst = New System.Windows.Forms.TextBox()
        Me.txtcodCfop = New System.Windows.Forms.TextBox()
        Me.txtCodCofinsCst = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.imgicmscst = New System.Windows.Forms.PictureBox()
        Me.txtdescicmscst = New System.Windows.Forms.TextBox()
        Me.txtCodIcmsCst = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.imgCsosn = New System.Windows.Forms.PictureBox()
        Me.txtDescCsosn = New System.Windows.Forms.TextBox()
        Me.txtCodCsosn = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.imgCfop = New System.Windows.Forms.PictureBox()
        Me.txtdesccfop = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtdescricaopdv = New System.Windows.Forms.TextBox()
        Me.txtcodbarra = New System.Windows.Forms.TextBox()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.txtCodProduto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.cbxAtivo = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tpPesquisa = New System.Windows.Forms.TabPage()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cbxFiltro = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtPesquisar = New System.Windows.Forms.TextBox()
        Me.dgProdutos = New System.Windows.Forms.DataGridView()
        Me.CODPRODUTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODBARRADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRICAODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECO_VENDA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ATIVODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAmbiente = New Ambiente_BackEnd.dsAmbiente()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnGeraEtiqueta = New System.Windows.Forms.Button()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.btnGerarArquivoBalanca = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnimprimir = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnpesquisar = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnsalvar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btninserir = New System.Windows.Forms.Button()
        Me.tbProduto.SuspendLayout()
        Me.tpCadastrar.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpPreco.SuspendLayout()
        CType(Me.nPcusto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nLucroM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nvenda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nLucro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nCusto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nDescMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nAliqTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nAliqIpi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nAliqPis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nCofins, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nAliqBc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nAliqIcms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nAliqNcmMunicipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nAliqNcmEstadual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nAliqNcmFederal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgIpi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgNcm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPiscst, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgCofinscst, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgicmscst, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgCsosn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgCfop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.tpPesquisa.SuspendLayout()
        CType(Me.dgProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAmbiente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbProduto
        '
        Me.tbProduto.Controls.Add(Me.tpCadastrar)
        Me.tbProduto.Controls.Add(Me.tpPesquisa)
        Me.tbProduto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbProduto.Location = New System.Drawing.Point(0, 67)
        Me.tbProduto.Name = "tbProduto"
        Me.tbProduto.SelectedIndex = 0
        Me.tbProduto.Size = New System.Drawing.Size(1093, 614)
        Me.tbProduto.TabIndex = 165
        '
        'tpCadastrar
        '
        Me.tpCadastrar.Controls.Add(Me.Panel7)
        Me.tpCadastrar.Location = New System.Drawing.Point(4, 22)
        Me.tpCadastrar.Name = "tpCadastrar"
        Me.tpCadastrar.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCadastrar.Size = New System.Drawing.Size(1085, 588)
        Me.tpCadastrar.TabIndex = 0
        Me.tpCadastrar.Text = "Cadastrar Produto"
        Me.tpCadastrar.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.GroupBox2)
        Me.Panel7.Controls.Add(Me.Panel10)
        Me.Panel7.Controls.Add(Me.txtEstoque)
        Me.Panel7.Controls.Add(Me.Label11)
        Me.Panel7.Controls.Add(Me.grpPreco)
        Me.Panel7.Controls.Add(Me.GroupBox1)
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Controls.Add(Me.txtdescricaopdv)
        Me.Panel7.Controls.Add(Me.txtcodbarra)
        Me.Panel7.Controls.Add(Me.txtDescricao)
        Me.Panel7.Controls.Add(Me.txtCodProduto)
        Me.Panel7.Controls.Add(Me.Label3)
        Me.Panel7.Controls.Add(Me.Label2)
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(3, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1079, 582)
        Me.Panel7.TabIndex = 159
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.cbxCargaBalanca)
        Me.GroupBox2.Controls.Add(Me.Label40)
        Me.GroupBox2.Controls.Add(Me.cbxInformacaoExtra)
        Me.GroupBox2.Controls.Add(Me.Label39)
        Me.GroupBox2.Controls.Add(Me.Label38)
        Me.GroupBox2.Controls.Add(Me.txtTipoProduto)
        Me.GroupBox2.Controls.Add(Me.Label37)
        Me.GroupBox2.Controls.Add(Me.cbxBalanca)
        Me.GroupBox2.Controls.Add(Me.Label36)
        Me.GroupBox2.Controls.Add(Me.cbxPerecivel)
        Me.GroupBox2.Controls.Add(Me.Label35)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.Controls.Add(Me.txtDiasValido)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 235)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1079, 54)
        Me.GroupBox2.TabIndex = 2266
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Balança"
        '
        'cbxCargaBalanca
        '
        Me.cbxCargaBalanca.DisplayMember = "0"
        Me.cbxCargaBalanca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCargaBalanca.Items.AddRange(New Object() {"SIM", "NAO"})
        Me.cbxCargaBalanca.Location = New System.Drawing.Point(526, 23)
        Me.cbxCargaBalanca.Name = "cbxCargaBalanca"
        Me.cbxCargaBalanca.Size = New System.Drawing.Size(75, 21)
        Me.cbxCargaBalanca.TabIndex = 13
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(440, 26)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(80, 13)
        Me.Label40.TabIndex = 12
        Me.Label40.Text = "Carga Balança:"
        '
        'cbxInformacaoExtra
        '
        Me.cbxInformacaoExtra.DisplayMember = "0"
        Me.cbxInformacaoExtra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxInformacaoExtra.Location = New System.Drawing.Point(1017, 23)
        Me.cbxInformacaoExtra.Name = "cbxInformacaoExtra"
        Me.cbxInformacaoExtra.Size = New System.Drawing.Size(55, 21)
        Me.cbxInformacaoExtra.TabIndex = 11
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(851, 26)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(160, 13)
        Me.Label39.TabIndex = 10
        Me.Label39.Text = "Cod Receita / Informação Extra:"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(736, 26)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(108, 13)
        Me.Label38.TabIndex = 9
        Me.Label38.Text = "0 - Peso / 1 - Unitário"
        '
        'txtTipoProduto
        '
        Me.txtTipoProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoProduto.Location = New System.Drawing.Point(683, 23)
        Me.txtTipoProduto.Name = "txtTipoProduto"
        Me.txtTipoProduto.Size = New System.Drawing.Size(48, 20)
        Me.txtTipoProduto.TabIndex = 8
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(606, 26)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(71, 13)
        Me.Label37.TabIndex = 7
        Me.Label37.Text = "Tipo Produto:"
        '
        'cbxBalanca
        '
        Me.cbxBalanca.DisplayMember = "0"
        Me.cbxBalanca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxBalanca.Items.AddRange(New Object() {"NAO", "SIM"})
        Me.cbxBalanca.Location = New System.Drawing.Point(359, 23)
        Me.cbxBalanca.Name = "cbxBalanca"
        Me.cbxBalanca.Size = New System.Drawing.Size(75, 21)
        Me.cbxBalanca.TabIndex = 6
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(304, 26)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(49, 13)
        Me.Label36.TabIndex = 5
        Me.Label36.Text = "Balança:"
        '
        'cbxPerecivel
        '
        Me.cbxPerecivel.DisplayMember = "0"
        Me.cbxPerecivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxPerecivel.Items.AddRange(New Object() {"SIM", "NAO"})
        Me.cbxPerecivel.Location = New System.Drawing.Point(234, 23)
        Me.cbxPerecivel.Name = "cbxPerecivel"
        Me.cbxPerecivel.Size = New System.Drawing.Size(64, 21)
        Me.cbxPerecivel.TabIndex = 4
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(174, 26)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(54, 13)
        Me.Label35.TabIndex = 3
        Me.Label35.Text = "Perecivél:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(142, 26)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(28, 13)
        Me.Label34.TabIndex = 2
        Me.Label34.Text = "Dias"
        '
        'txtDiasValido
        '
        Me.txtDiasValido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiasValido.Location = New System.Drawing.Point(90, 23)
        Me.txtDiasValido.Name = "txtDiasValido"
        Me.txtDiasValido.Size = New System.Drawing.Size(49, 20)
        Me.txtDiasValido.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Validade Atual :"
        '
        'Panel10
        '
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel10.Location = New System.Drawing.Point(0, 289)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1079, 15)
        Me.Panel10.TabIndex = 2265
        '
        'txtEstoque
        '
        Me.txtEstoque.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstoque.Location = New System.Drawing.Point(140, 113)
        Me.txtEstoque.Name = "txtEstoque"
        Me.txtEstoque.Size = New System.Drawing.Size(82, 21)
        Me.txtEstoque.TabIndex = 2264
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(54, 113)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 16)
        Me.Label11.TabIndex = 2263
        Me.Label11.Text = "Estoque :"
        '
        'grpPreco
        '
        Me.grpPreco.Controls.Add(Me.nPcusto)
        Me.grpPreco.Controls.Add(Me.lblCusto)
        Me.grpPreco.Controls.Add(Me.Label33)
        Me.grpPreco.Controls.Add(Me.nLucroM)
        Me.grpPreco.Controls.Add(Me.nvenda)
        Me.grpPreco.Controls.Add(Me.nLucro)
        Me.grpPreco.Controls.Add(Me.nCusto)
        Me.grpPreco.Controls.Add(Me.nDescMax)
        Me.grpPreco.Controls.Add(Me.nCompra)
        Me.grpPreco.Controls.Add(Me.lblDescMax)
        Me.grpPreco.Controls.Add(Me.Label19)
        Me.grpPreco.Controls.Add(Me.Label18)
        Me.grpPreco.Controls.Add(Me.Label17)
        Me.grpPreco.Controls.Add(Me.Label16)
        Me.grpPreco.Controls.Add(Me.Label12)
        Me.grpPreco.Controls.Add(Me.Label8)
        Me.grpPreco.Location = New System.Drawing.Point(585, 19)
        Me.grpPreco.Name = "grpPreco"
        Me.grpPreco.Size = New System.Drawing.Size(487, 134)
        Me.grpPreco.TabIndex = 16
        Me.grpPreco.TabStop = False
        Me.grpPreco.Text = "Preço"
        '
        'nPcusto
        '
        Me.nPcusto.DecimalPlaces = 2
        Me.nPcusto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nPcusto.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.nPcusto.Location = New System.Drawing.Point(113, 30)
        Me.nPcusto.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nPcusto.Name = "nPcusto"
        Me.nPcusto.Size = New System.Drawing.Size(84, 21)
        Me.nPcusto.TabIndex = 46
        Me.nPcusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCusto
        '
        Me.lblCusto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblCusto.ForeColor = System.Drawing.Color.Blue
        Me.lblCusto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCusto.Location = New System.Drawing.Point(126, 54)
        Me.lblCusto.Name = "lblCusto"
        Me.lblCusto.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblCusto.Size = New System.Drawing.Size(70, 17)
        Me.lblCusto.TabIndex = 53
        Me.lblCusto.Text = "0,00"
        Me.lblCusto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(389, 71)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(85, 15)
        Me.Label33.TabIndex = 52
        Me.Label33.Text = "Desc. Max % :"
        '
        'nLucroM
        '
        Me.nLucroM.DecimalPlaces = 2
        Me.nLucroM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nLucroM.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.nLucroM.Location = New System.Drawing.Point(384, 30)
        Me.nLucroM.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nLucroM.Name = "nLucroM"
        Me.nLucroM.Size = New System.Drawing.Size(84, 21)
        Me.nLucroM.TabIndex = 49
        Me.nLucroM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nvenda
        '
        Me.nvenda.DecimalPlaces = 2
        Me.nvenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nvenda.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.nvenda.Location = New System.Drawing.Point(23, 89)
        Me.nvenda.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nvenda.Name = "nvenda"
        Me.nvenda.Size = New System.Drawing.Size(84, 21)
        Me.nvenda.TabIndex = 50
        Me.nvenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nLucro
        '
        Me.nLucro.DecimalPlaces = 2
        Me.nLucro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nLucro.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.nLucro.Location = New System.Drawing.Point(293, 30)
        Me.nLucro.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nLucro.Name = "nLucro"
        Me.nLucro.Size = New System.Drawing.Size(84, 21)
        Me.nLucro.TabIndex = 48
        Me.nLucro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nCusto
        '
        Me.nCusto.DecimalPlaces = 2
        Me.nCusto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nCusto.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.nCusto.Location = New System.Drawing.Point(203, 30)
        Me.nCusto.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nCusto.Name = "nCusto"
        Me.nCusto.Size = New System.Drawing.Size(84, 21)
        Me.nCusto.TabIndex = 47
        Me.nCusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nDescMax
        '
        Me.nDescMax.DecimalPlaces = 2
        Me.nDescMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nDescMax.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.nDescMax.Location = New System.Drawing.Point(384, 89)
        Me.nDescMax.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nDescMax.Name = "nDescMax"
        Me.nDescMax.Size = New System.Drawing.Size(84, 21)
        Me.nDescMax.TabIndex = 47
        Me.nDescMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nCompra
        '
        Me.nCompra.DecimalPlaces = 2
        Me.nCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nCompra.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.nCompra.Location = New System.Drawing.Point(23, 30)
        Me.nCompra.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nCompra.Name = "nCompra"
        Me.nCompra.Size = New System.Drawing.Size(84, 21)
        Me.nCompra.TabIndex = 45
        Me.nCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDescMax
        '
        Me.lblDescMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblDescMax.ForeColor = System.Drawing.Color.Blue
        Me.lblDescMax.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDescMax.Location = New System.Drawing.Point(399, 112)
        Me.lblDescMax.Name = "lblDescMax"
        Me.lblDescMax.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblDescMax.Size = New System.Drawing.Size(70, 17)
        Me.lblDescMax.TabIndex = 44
        Me.lblDescMax.Text = "0,00"
        Me.lblDescMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(381, 12)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(71, 15)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "Lucro (R$) :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(20, 71)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 15)
        Me.Label18.TabIndex = 42
        Me.Label18.Text = "Venda (R$) :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(290, 12)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 15)
        Me.Label17.TabIndex = 41
        Me.Label17.Text = "Lucro % :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(200, 12)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 15)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "Custo (R$) :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(110, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 15)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Custo % :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(24, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 15)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Compra (R$) :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.nAliqTotal)
        Me.GroupBox1.Controls.Add(Me.nAliqIpi)
        Me.GroupBox1.Controls.Add(Me.nAliqPis)
        Me.GroupBox1.Controls.Add(Me.nCofins)
        Me.GroupBox1.Controls.Add(Me.nAliqBc)
        Me.GroupBox1.Controls.Add(Me.nAliqIcms)
        Me.GroupBox1.Controls.Add(Me.nAliqNcmMunicipal)
        Me.GroupBox1.Controls.Add(Me.nAliqNcmEstadual)
        Me.GroupBox1.Controls.Add(Me.nAliqNcmFederal)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.imgIpi)
        Me.GroupBox1.Controls.Add(Me.txtDescipi)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.imgNcm)
        Me.GroupBox1.Controls.Add(Me.txtDescNcm)
        Me.GroupBox1.Controls.Add(Me.txtNcm)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.txtCodIpi)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.imgPiscst)
        Me.GroupBox1.Controls.Add(Me.txtDescpiscst)
        Me.GroupBox1.Controls.Add(Me.txtCodpiscst)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.imgCofinscst)
        Me.GroupBox1.Controls.Add(Me.txtDescConfinsCst)
        Me.GroupBox1.Controls.Add(Me.txtcodCfop)
        Me.GroupBox1.Controls.Add(Me.txtCodCofinsCst)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.imgicmscst)
        Me.GroupBox1.Controls.Add(Me.txtdescicmscst)
        Me.GroupBox1.Controls.Add(Me.txtCodIcmsCst)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.imgCsosn)
        Me.GroupBox1.Controls.Add(Me.txtDescCsosn)
        Me.GroupBox1.Controls.Add(Me.txtCodCsosn)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.imgCfop)
        Me.GroupBox1.Controls.Add(Me.txtdesccfop)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 304)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1079, 238)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "IMPOSTOS - "
        '
        'nAliqTotal
        '
        Me.nAliqTotal.DecimalPlaces = 2
        Me.nAliqTotal.Enabled = False
        Me.nAliqTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nAliqTotal.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.nAliqTotal.Location = New System.Drawing.Point(936, 216)
        Me.nAliqTotal.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nAliqTotal.Name = "nAliqTotal"
        Me.nAliqTotal.Size = New System.Drawing.Size(115, 21)
        Me.nAliqTotal.TabIndex = 255
        Me.nAliqTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nAliqIpi
        '
        Me.nAliqIpi.DecimalPlaces = 2
        Me.nAliqIpi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nAliqIpi.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.nAliqIpi.Location = New System.Drawing.Point(854, 160)
        Me.nAliqIpi.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nAliqIpi.Name = "nAliqIpi"
        Me.nAliqIpi.Size = New System.Drawing.Size(84, 21)
        Me.nAliqIpi.TabIndex = 14
        Me.nAliqIpi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nAliqPis
        '
        Me.nAliqPis.DecimalPlaces = 2
        Me.nAliqPis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nAliqPis.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.nAliqPis.Location = New System.Drawing.Point(854, 133)
        Me.nAliqPis.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nAliqPis.Name = "nAliqPis"
        Me.nAliqPis.Size = New System.Drawing.Size(84, 21)
        Me.nAliqPis.TabIndex = 12
        Me.nAliqPis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nCofins
        '
        Me.nCofins.DecimalPlaces = 2
        Me.nCofins.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nCofins.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.nCofins.Location = New System.Drawing.Point(853, 108)
        Me.nCofins.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nCofins.Name = "nCofins"
        Me.nCofins.Size = New System.Drawing.Size(84, 21)
        Me.nCofins.TabIndex = 10
        Me.nCofins.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nAliqBc
        '
        Me.nAliqBc.DecimalPlaces = 2
        Me.nAliqBc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nAliqBc.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.nAliqBc.Location = New System.Drawing.Point(853, 80)
        Me.nAliqBc.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nAliqBc.Name = "nAliqBc"
        Me.nAliqBc.Size = New System.Drawing.Size(84, 21)
        Me.nAliqBc.TabIndex = 8
        Me.nAliqBc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nAliqIcms
        '
        Me.nAliqIcms.DecimalPlaces = 2
        Me.nAliqIcms.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nAliqIcms.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.nAliqIcms.Location = New System.Drawing.Point(853, 51)
        Me.nAliqIcms.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nAliqIcms.Name = "nAliqIcms"
        Me.nAliqIcms.Size = New System.Drawing.Size(84, 21)
        Me.nAliqIcms.TabIndex = 6
        Me.nAliqIcms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nAliqNcmMunicipal
        '
        Me.nAliqNcmMunicipal.DecimalPlaces = 2
        Me.nAliqNcmMunicipal.Enabled = False
        Me.nAliqNcmMunicipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nAliqNcmMunicipal.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.nAliqNcmMunicipal.Location = New System.Drawing.Point(734, 218)
        Me.nAliqNcmMunicipal.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nAliqNcmMunicipal.Name = "nAliqNcmMunicipal"
        Me.nAliqNcmMunicipal.Size = New System.Drawing.Size(84, 21)
        Me.nAliqNcmMunicipal.TabIndex = 248
        Me.nAliqNcmMunicipal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nAliqNcmEstadual
        '
        Me.nAliqNcmEstadual.DecimalPlaces = 2
        Me.nAliqNcmEstadual.Enabled = False
        Me.nAliqNcmEstadual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nAliqNcmEstadual.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.nAliqNcmEstadual.Location = New System.Drawing.Point(458, 218)
        Me.nAliqNcmEstadual.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nAliqNcmEstadual.Name = "nAliqNcmEstadual"
        Me.nAliqNcmEstadual.Size = New System.Drawing.Size(84, 21)
        Me.nAliqNcmEstadual.TabIndex = 247
        Me.nAliqNcmEstadual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nAliqNcmFederal
        '
        Me.nAliqNcmFederal.DecimalPlaces = 2
        Me.nAliqNcmFederal.Enabled = False
        Me.nAliqNcmFederal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nAliqNcmFederal.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.nAliqNcmFederal.Location = New System.Drawing.Point(184, 218)
        Me.nAliqNcmFederal.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nAliqNcmFederal.Name = "nAliqNcmFederal"
        Me.nAliqNcmFederal.Size = New System.Drawing.Size(84, 21)
        Me.nAliqNcmFederal.TabIndex = 246
        Me.nAliqNcmFederal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(824, 219)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(105, 16)
        Me.Label15.TabIndex = 245
        Me.Label15.Text = "ALIQ_TOTAL :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(550, 220)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(177, 16)
        Me.Label14.TabIndex = 243
        Me.Label14.Text = "ALIQ_NCM_MUNICIPAL :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(274, 220)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(177, 16)
        Me.Label13.TabIndex = 241
        Me.Label13.Text = "ALIQ_NCM_ESTADUAL :"
        '
        'imgIpi
        '
        Me.imgIpi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgIpi.Image = CType(resources.GetObject("imgIpi.Image"), System.Drawing.Image)
        Me.imgIpi.Location = New System.Drawing.Point(266, 159)
        Me.imgIpi.Name = "imgIpi"
        Me.imgIpi.Size = New System.Drawing.Size(32, 21)
        Me.imgIpi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgIpi.TabIndex = 239
        Me.imgIpi.TabStop = False
        '
        'txtDescipi
        '
        Me.txtDescipi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescipi.Enabled = False
        Me.txtDescipi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescipi.Location = New System.Drawing.Point(299, 159)
        Me.txtDescipi.Name = "txtDescipi"
        Me.txtDescipi.Size = New System.Drawing.Size(428, 21)
        Me.txtDescipi.TabIndex = 238
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(8, 218)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(166, 16)
        Me.Label31.TabIndex = 237
        Me.Label31.Text = "ALIQ_NCM_FEDERAL :"
        '
        'imgNcm
        '
        Me.imgNcm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgNcm.Image = CType(resources.GetObject("imgNcm.Image"), System.Drawing.Image)
        Me.imgNcm.Location = New System.Drawing.Point(266, 188)
        Me.imgNcm.Name = "imgNcm"
        Me.imgNcm.Size = New System.Drawing.Size(32, 21)
        Me.imgNcm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgNcm.TabIndex = 235
        Me.imgNcm.TabStop = False
        '
        'txtDescNcm
        '
        Me.txtDescNcm.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescNcm.Enabled = False
        Me.txtDescNcm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescNcm.Location = New System.Drawing.Point(299, 188)
        Me.txtDescNcm.Name = "txtDescNcm"
        Me.txtDescNcm.Size = New System.Drawing.Size(428, 21)
        Me.txtDescNcm.TabIndex = 234
        '
        'txtNcm
        '
        Me.txtNcm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNcm.Location = New System.Drawing.Point(184, 188)
        Me.txtNcm.Name = "txtNcm"
        Me.txtNcm.Size = New System.Drawing.Size(81, 21)
        Me.txtNcm.TabIndex = 15
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(8, 188)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(40, 16)
        Me.Label32.TabIndex = 233
        Me.Label32.Text = "NCM"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(733, 163)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(64, 16)
        Me.Label30.TabIndex = 231
        Me.Label30.Text = "ALIQ_IPI :"
        '
        'txtCodIpi
        '
        Me.txtCodIpi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodIpi.Location = New System.Drawing.Point(184, 159)
        Me.txtCodIpi.Name = "txtCodIpi"
        Me.txtCodIpi.Size = New System.Drawing.Size(81, 21)
        Me.txtCodIpi.TabIndex = 13
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(7, 162)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(28, 16)
        Me.Label29.TabIndex = 229
        Me.Label29.Text = "IPI :"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(733, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 227
        Me.Label1.Text = "ALIQ_PIS :"
        '
        'imgPiscst
        '
        Me.imgPiscst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgPiscst.Image = CType(resources.GetObject("imgPiscst.Image"), System.Drawing.Image)
        Me.imgPiscst.Location = New System.Drawing.Point(266, 132)
        Me.imgPiscst.Name = "imgPiscst"
        Me.imgPiscst.Size = New System.Drawing.Size(32, 21)
        Me.imgPiscst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgPiscst.TabIndex = 225
        Me.imgPiscst.TabStop = False
        '
        'txtDescpiscst
        '
        Me.txtDescpiscst.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescpiscst.Enabled = False
        Me.txtDescpiscst.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescpiscst.Location = New System.Drawing.Point(299, 132)
        Me.txtDescpiscst.Name = "txtDescpiscst"
        Me.txtDescpiscst.Size = New System.Drawing.Size(428, 21)
        Me.txtDescpiscst.TabIndex = 224
        '
        'txtCodpiscst
        '
        Me.txtCodpiscst.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodpiscst.Location = New System.Drawing.Point(183, 132)
        Me.txtCodpiscst.Name = "txtCodpiscst"
        Me.txtCodpiscst.Size = New System.Drawing.Size(82, 21)
        Me.txtCodpiscst.TabIndex = 11
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(7, 135)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(65, 16)
        Me.Label28.TabIndex = 223
        Me.Label28.Text = "PIS/CST :"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(732, 110)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(98, 16)
        Me.Label25.TabIndex = 221
        Me.Label25.Text = "ALIQ_COFINS :"
        '
        'imgCofinscst
        '
        Me.imgCofinscst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgCofinscst.Image = CType(resources.GetObject("imgCofinscst.Image"), System.Drawing.Image)
        Me.imgCofinscst.Location = New System.Drawing.Point(265, 107)
        Me.imgCofinscst.Name = "imgCofinscst"
        Me.imgCofinscst.Size = New System.Drawing.Size(32, 21)
        Me.imgCofinscst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCofinscst.TabIndex = 219
        Me.imgCofinscst.TabStop = False
        '
        'txtDescConfinsCst
        '
        Me.txtDescConfinsCst.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescConfinsCst.Enabled = False
        Me.txtDescConfinsCst.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescConfinsCst.Location = New System.Drawing.Point(298, 107)
        Me.txtDescConfinsCst.Name = "txtDescConfinsCst"
        Me.txtDescConfinsCst.Size = New System.Drawing.Size(428, 21)
        Me.txtDescConfinsCst.TabIndex = 218
        '
        'txtcodCfop
        '
        Me.txtcodCfop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodCfop.Location = New System.Drawing.Point(183, 21)
        Me.txtcodCfop.Name = "txtcodCfop"
        Me.txtcodCfop.Size = New System.Drawing.Size(81, 21)
        Me.txtcodCfop.TabIndex = 4
        '
        'txtCodCofinsCst
        '
        Me.txtCodCofinsCst.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodCofinsCst.Location = New System.Drawing.Point(183, 107)
        Me.txtCodCofinsCst.Name = "txtCodCofinsCst"
        Me.txtCodCofinsCst.Size = New System.Drawing.Size(81, 21)
        Me.txtCodCofinsCst.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(7, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 16)
        Me.Label7.TabIndex = 217
        Me.Label7.Text = "COFINS/CST :"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(732, 82)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(103, 16)
        Me.Label23.TabIndex = 215
        Me.Label23.Text = "ALIQ_ICMS_BC:"
        '
        'imgicmscst
        '
        Me.imgicmscst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgicmscst.Image = CType(resources.GetObject("imgicmscst.Image"), System.Drawing.Image)
        Me.imgicmscst.Location = New System.Drawing.Point(265, 79)
        Me.imgicmscst.Name = "imgicmscst"
        Me.imgicmscst.Size = New System.Drawing.Size(32, 21)
        Me.imgicmscst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgicmscst.TabIndex = 213
        Me.imgicmscst.TabStop = False
        '
        'txtdescicmscst
        '
        Me.txtdescicmscst.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdescicmscst.Enabled = False
        Me.txtdescicmscst.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescicmscst.Location = New System.Drawing.Point(298, 79)
        Me.txtdescicmscst.Name = "txtdescicmscst"
        Me.txtdescicmscst.Size = New System.Drawing.Size(428, 21)
        Me.txtdescicmscst.TabIndex = 212
        '
        'txtCodIcmsCst
        '
        Me.txtCodIcmsCst.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodIcmsCst.Location = New System.Drawing.Point(183, 79)
        Me.txtCodIcmsCst.Name = "txtCodIcmsCst"
        Me.txtCodIcmsCst.Size = New System.Drawing.Size(81, 21)
        Me.txtCodIcmsCst.TabIndex = 7
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(7, 79)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(76, 16)
        Me.Label24.TabIndex = 211
        Me.Label24.Text = "ICMS/CST :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(732, 53)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(81, 16)
        Me.Label22.TabIndex = 209
        Me.Label22.Text = "ALIQ_ICMS :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(77, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(299, 13)
        Me.Label20.TabIndex = 207
        Me.Label20.Text = "Obs: Campos que estiver em negrito são obrigatorio"
        '
        'imgCsosn
        '
        Me.imgCsosn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgCsosn.Image = CType(resources.GetObject("imgCsosn.Image"), System.Drawing.Image)
        Me.imgCsosn.Location = New System.Drawing.Point(265, 50)
        Me.imgCsosn.Name = "imgCsosn"
        Me.imgCsosn.Size = New System.Drawing.Size(32, 21)
        Me.imgCsosn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCsosn.TabIndex = 206
        Me.imgCsosn.TabStop = False
        '
        'txtDescCsosn
        '
        Me.txtDescCsosn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescCsosn.Enabled = False
        Me.txtDescCsosn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescCsosn.Location = New System.Drawing.Point(298, 50)
        Me.txtDescCsosn.Name = "txtDescCsosn"
        Me.txtDescCsosn.Size = New System.Drawing.Size(428, 21)
        Me.txtDescCsosn.TabIndex = 205
        '
        'txtCodCsosn
        '
        Me.txtCodCsosn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodCsosn.Location = New System.Drawing.Point(183, 50)
        Me.txtCodCsosn.Name = "txtCodCsosn"
        Me.txtCodCsosn.Size = New System.Drawing.Size(81, 21)
        Me.txtCodCsosn.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(7, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 16)
        Me.Label10.TabIndex = 204
        Me.Label10.Text = "CSOSN :"
        '
        'imgCfop
        '
        Me.imgCfop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgCfop.Image = CType(resources.GetObject("imgCfop.Image"), System.Drawing.Image)
        Me.imgCfop.Location = New System.Drawing.Point(265, 21)
        Me.imgCfop.Name = "imgCfop"
        Me.imgCfop.Size = New System.Drawing.Size(32, 21)
        Me.imgCfop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCfop.TabIndex = 202
        Me.imgCfop.TabStop = False
        '
        'txtdesccfop
        '
        Me.txtdesccfop.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdesccfop.Enabled = False
        Me.txtdesccfop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesccfop.Location = New System.Drawing.Point(298, 21)
        Me.txtdesccfop.Name = "txtdesccfop"
        Me.txtdesccfop.Size = New System.Drawing.Size(428, 21)
        Me.txtdesccfop.TabIndex = 201
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(7, 21)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(55, 16)
        Me.Label21.TabIndex = 200
        Me.Label21.Text = "CFOP :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(23, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 16)
        Me.Label5.TabIndex = 2260
        Me.Label5.Text = "Descrição PDV :"
        '
        'txtdescricaopdv
        '
        Me.txtdescricaopdv.Enabled = False
        Me.txtdescricaopdv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescricaopdv.Location = New System.Drawing.Point(140, 81)
        Me.txtdescricaopdv.MaxLength = 15
        Me.txtdescricaopdv.Name = "txtdescricaopdv"
        Me.txtdescricaopdv.Size = New System.Drawing.Size(419, 21)
        Me.txtdescricaopdv.TabIndex = 2
        '
        'txtcodbarra
        '
        Me.txtcodbarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodbarra.Location = New System.Drawing.Point(303, 19)
        Me.txtcodbarra.Name = "txtcodbarra"
        Me.txtcodbarra.Size = New System.Drawing.Size(131, 21)
        Me.txtcodbarra.TabIndex = 0
        '
        'txtDescricao
        '
        Me.txtDescricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescricao.Location = New System.Drawing.Point(140, 54)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(421, 21)
        Me.txtDescricao.TabIndex = 1
        '
        'txtCodProduto
        '
        Me.txtCodProduto.Enabled = False
        Me.txtCodProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodProduto.Location = New System.Drawing.Point(140, 21)
        Me.txtCodProduto.Name = "txtCodProduto"
        Me.txtCodProduto.Size = New System.Drawing.Size(67, 21)
        Me.txtCodProduto.TabIndex = 2246
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(216, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 2249
        Me.Label3.Text = "Cód Barra :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(54, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 2248
        Me.Label2.Text = "Descrição :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(70, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 2247
        Me.Label4.Text = "Código :"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel8.Controls.Add(Me.cbxAtivo)
        Me.Panel8.Controls.Add(Me.Label9)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 542)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1079, 40)
        Me.Panel8.TabIndex = 210
        '
        'cbxAtivo
        '
        Me.cbxAtivo.FormattingEnabled = True
        Me.cbxAtivo.Items.AddRange(New Object() {"SIM", "NAO"})
        Me.cbxAtivo.Location = New System.Drawing.Point(80, 7)
        Me.cbxAtivo.Name = "cbxAtivo"
        Me.cbxAtivo.Size = New System.Drawing.Size(114, 21)
        Me.cbxAtivo.TabIndex = 21
        Me.cbxAtivo.Text = "SIM"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Yellow
        Me.Label9.Location = New System.Drawing.Point(27, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 17)
        Me.Label9.TabIndex = 204
        Me.Label9.Text = "Ativo :"
        '
        'tpPesquisa
        '
        Me.tpPesquisa.Controls.Add(Me.Label27)
        Me.tpPesquisa.Controls.Add(Me.cbxFiltro)
        Me.tpPesquisa.Controls.Add(Me.Label26)
        Me.tpPesquisa.Controls.Add(Me.txtPesquisar)
        Me.tpPesquisa.Controls.Add(Me.dgProdutos)
        Me.tpPesquisa.Location = New System.Drawing.Point(4, 22)
        Me.tpPesquisa.Name = "tpPesquisa"
        Me.tpPesquisa.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPesquisa.Size = New System.Drawing.Size(1085, 588)
        Me.tpPesquisa.TabIndex = 1
        Me.tpPesquisa.Text = "Pesquisar Produto"
        Me.tpPesquisa.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(3, 11)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(35, 13)
        Me.Label27.TabIndex = 52
        Me.Label27.Text = "Filtro :"
        '
        'cbxFiltro
        '
        Me.cbxFiltro.FormattingEnabled = True
        Me.cbxFiltro.Items.AddRange(New Object() {"Codigo Barra", "Descricao"})
        Me.cbxFiltro.Location = New System.Drawing.Point(6, 29)
        Me.cbxFiltro.Name = "cbxFiltro"
        Me.cbxFiltro.Size = New System.Drawing.Size(113, 21)
        Me.cbxFiltro.TabIndex = 51
        Me.cbxFiltro.Text = "Codigo Barra"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(122, 11)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(53, 13)
        Me.Label26.TabIndex = 50
        Me.Label26.Text = "Pesquisar"
        '
        'txtPesquisar
        '
        Me.txtPesquisar.Location = New System.Drawing.Point(125, 29)
        Me.txtPesquisar.Name = "txtPesquisar"
        Me.txtPesquisar.Size = New System.Drawing.Size(503, 20)
        Me.txtPesquisar.TabIndex = 52
        '
        'dgProdutos
        '
        Me.dgProdutos.AllowUserToAddRows = False
        Me.dgProdutos.AllowUserToDeleteRows = False
        Me.dgProdutos.AutoGenerateColumns = False
        Me.dgProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgProdutos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgProdutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgProdutos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgProdutos.ColumnHeadersHeight = 20
        Me.dgProdutos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODPRODUTODataGridViewTextBoxColumn, Me.CODBARRADataGridViewTextBoxColumn, Me.DESCRICAODataGridViewTextBoxColumn, Me.PRECO_VENDA, Me.ATIVODataGridViewTextBoxColumn})
        Me.dgProdutos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgProdutos.DataSource = Me.PRODUTOBindingSource
        Me.dgProdutos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgProdutos.GridColor = System.Drawing.SystemColors.HighlightText
        Me.dgProdutos.Location = New System.Drawing.Point(3, 56)
        Me.dgProdutos.Name = "dgProdutos"
        Me.dgProdutos.ReadOnly = True
        Me.dgProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgProdutos.Size = New System.Drawing.Size(1079, 529)
        Me.dgProdutos.TabIndex = 48
        '
        'CODPRODUTODataGridViewTextBoxColumn
        '
        Me.CODPRODUTODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CODPRODUTODataGridViewTextBoxColumn.DataPropertyName = "CODPRODUTO"
        Me.CODPRODUTODataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CODPRODUTODataGridViewTextBoxColumn.Name = "CODPRODUTODataGridViewTextBoxColumn"
        Me.CODPRODUTODataGridViewTextBoxColumn.ReadOnly = True
        Me.CODPRODUTODataGridViewTextBoxColumn.Width = 70
        '
        'CODBARRADataGridViewTextBoxColumn
        '
        Me.CODBARRADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CODBARRADataGridViewTextBoxColumn.DataPropertyName = "CODBARRA"
        Me.CODBARRADataGridViewTextBoxColumn.HeaderText = "Codigo Barra"
        Me.CODBARRADataGridViewTextBoxColumn.Name = "CODBARRADataGridViewTextBoxColumn"
        Me.CODBARRADataGridViewTextBoxColumn.ReadOnly = True
        Me.CODBARRADataGridViewTextBoxColumn.Width = 160
        '
        'DESCRICAODataGridViewTextBoxColumn
        '
        Me.DESCRICAODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DESCRICAODataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO"
        Me.DESCRICAODataGridViewTextBoxColumn.HeaderText = "Descrição"
        Me.DESCRICAODataGridViewTextBoxColumn.Name = "DESCRICAODataGridViewTextBoxColumn"
        Me.DESCRICAODataGridViewTextBoxColumn.ReadOnly = True
        Me.DESCRICAODataGridViewTextBoxColumn.Width = 600
        '
        'PRECO_VENDA
        '
        Me.PRECO_VENDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PRECO_VENDA.DataPropertyName = "PRECO_VENDA"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.PRECO_VENDA.DefaultCellStyle = DataGridViewCellStyle2
        Me.PRECO_VENDA.HeaderText = "Preço Venda"
        Me.PRECO_VENDA.Name = "PRECO_VENDA"
        Me.PRECO_VENDA.ReadOnly = True
        Me.PRECO_VENDA.Width = 125
        '
        'ATIVODataGridViewTextBoxColumn
        '
        Me.ATIVODataGridViewTextBoxColumn.DataPropertyName = "ATIVO"
        Me.ATIVODataGridViewTextBoxColumn.HeaderText = "Ativo"
        Me.ATIVODataGridViewTextBoxColumn.Name = "ATIVODataGridViewTextBoxColumn"
        Me.ATIVODataGridViewTextBoxColumn.ReadOnly = True
        '
        'PRODUTOBindingSource
        '
        Me.PRODUTOBindingSource.DataMember = "PRODUTO"
        Me.PRODUTOBindingSource.DataSource = Me.DsAmbiente
        '
        'DsAmbiente
        '
        Me.DsAmbiente.DataSetName = "dsAmbiente"
        Me.DsAmbiente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnGeraEtiqueta)
        Me.Panel2.Controls.Add(Me.Panel12)
        Me.Panel2.Controls.Add(Me.btnGerarArquivoBalanca)
        Me.Panel2.Controls.Add(Me.Panel9)
        Me.Panel2.Controls.Add(Me.btnFechar)
        Me.Panel2.Controls.Add(Me.btnimprimir)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.btnpesquisar)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.btncancelar)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.btnsalvar)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.btneditar)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.btninserir)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1093, 67)
        Me.Panel2.TabIndex = 164
        '
        'btnGeraEtiqueta
        '
        Me.btnGeraEtiqueta.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnGeraEtiqueta.FlatAppearance.BorderSize = 0
        Me.btnGeraEtiqueta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGeraEtiqueta.ForeColor = System.Drawing.Color.Black
        Me.btnGeraEtiqueta.Image = CType(resources.GetObject("btnGeraEtiqueta.Image"), System.Drawing.Image)
        Me.btnGeraEtiqueta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGeraEtiqueta.Location = New System.Drawing.Point(789, 0)
        Me.btnGeraEtiqueta.Name = "btnGeraEtiqueta"
        Me.btnGeraEtiqueta.Size = New System.Drawing.Size(90, 67)
        Me.btnGeraEtiqueta.TabIndex = 165
        Me.btnGeraEtiqueta.Text = "F8 - Gerar Etiquetas"
        Me.btnGeraEtiqueta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGeraEtiqueta.UseVisualStyleBackColor = True
        '
        'Panel12
        '
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel12.Location = New System.Drawing.Point(767, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(22, 67)
        Me.Panel12.TabIndex = 164
        '
        'btnGerarArquivoBalanca
        '
        Me.btnGerarArquivoBalanca.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnGerarArquivoBalanca.FlatAppearance.BorderSize = 0
        Me.btnGerarArquivoBalanca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGerarArquivoBalanca.ForeColor = System.Drawing.Color.Black
        Me.btnGerarArquivoBalanca.Image = CType(resources.GetObject("btnGerarArquivoBalanca.Image"), System.Drawing.Image)
        Me.btnGerarArquivoBalanca.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGerarArquivoBalanca.Location = New System.Drawing.Point(672, 0)
        Me.btnGerarArquivoBalanca.Name = "btnGerarArquivoBalanca"
        Me.btnGerarArquivoBalanca.Size = New System.Drawing.Size(95, 67)
        Me.btnGerarArquivoBalanca.TabIndex = 163
        Me.btnGerarArquivoBalanca.Text = "F7 - Gerar Arquivo Balança"
        Me.btnGerarArquivoBalanca.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGerarArquivoBalanca.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.Panel11)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel9.Location = New System.Drawing.Point(650, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(22, 67)
        Me.Panel9.TabIndex = 162
        '
        'Panel11
        '
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(22, 67)
        Me.Panel11.TabIndex = 163
        '
        'btnFechar
        '
        Me.btnFechar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnFechar.FlatAppearance.BorderSize = 0
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.ForeColor = System.Drawing.Color.Black
        Me.btnFechar.Image = CType(resources.GetObject("btnFechar.Image"), System.Drawing.Image)
        Me.btnFechar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFechar.Location = New System.Drawing.Point(975, 0)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(118, 67)
        Me.btnFechar.TabIndex = 161
        Me.btnFechar.Text = "F12 - Fechar"
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'btnimprimir
        '
        Me.btnimprimir.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnimprimir.FlatAppearance.BorderSize = 0
        Me.btnimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnimprimir.ForeColor = System.Drawing.Color.Black
        Me.btnimprimir.Image = CType(resources.GetObject("btnimprimir.Image"), System.Drawing.Image)
        Me.btnimprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnimprimir.Location = New System.Drawing.Point(560, 0)
        Me.btnimprimir.Name = "btnimprimir"
        Me.btnimprimir.Size = New System.Drawing.Size(90, 67)
        Me.btnimprimir.TabIndex = 160
        Me.btnimprimir.Text = "F6 - Imprimir"
        Me.btnimprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnimprimir.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(538, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(22, 67)
        Me.Panel6.TabIndex = 159
        '
        'btnpesquisar
        '
        Me.btnpesquisar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnpesquisar.FlatAppearance.BorderSize = 0
        Me.btnpesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpesquisar.ForeColor = System.Drawing.Color.Black
        Me.btnpesquisar.Image = CType(resources.GetObject("btnpesquisar.Image"), System.Drawing.Image)
        Me.btnpesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnpesquisar.Location = New System.Drawing.Point(448, 0)
        Me.btnpesquisar.Name = "btnpesquisar"
        Me.btnpesquisar.Size = New System.Drawing.Size(90, 67)
        Me.btnpesquisar.TabIndex = 158
        Me.btnpesquisar.Text = "F5 - Pesquisar"
        Me.btnpesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnpesquisar.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(426, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(22, 67)
        Me.Panel5.TabIndex = 40
        '
        'btncancelar
        '
        Me.btncancelar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btncancelar.FlatAppearance.BorderSize = 0
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.ForeColor = System.Drawing.Color.Black
        Me.btncancelar.Image = CType(resources.GetObject("btncancelar.Image"), System.Drawing.Image)
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncancelar.Location = New System.Drawing.Point(336, 0)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(90, 67)
        Me.btncancelar.TabIndex = 39
        Me.btncancelar.Text = "F4 - Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(314, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(22, 67)
        Me.Panel4.TabIndex = 38
        '
        'btnsalvar
        '
        Me.btnsalvar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnsalvar.FlatAppearance.BorderSize = 0
        Me.btnsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsalvar.ForeColor = System.Drawing.Color.Black
        Me.btnsalvar.Image = CType(resources.GetObject("btnsalvar.Image"), System.Drawing.Image)
        Me.btnsalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsalvar.Location = New System.Drawing.Point(224, 0)
        Me.btnsalvar.Name = "btnsalvar"
        Me.btnsalvar.Size = New System.Drawing.Size(90, 67)
        Me.btnsalvar.TabIndex = 37
        Me.btnsalvar.Text = "F3 - Salvar"
        Me.btnsalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsalvar.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(202, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(22, 67)
        Me.Panel3.TabIndex = 36
        '
        'btneditar
        '
        Me.btneditar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btneditar.FlatAppearance.BorderSize = 0
        Me.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneditar.ForeColor = System.Drawing.Color.Black
        Me.btneditar.Image = CType(resources.GetObject("btneditar.Image"), System.Drawing.Image)
        Me.btneditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btneditar.Location = New System.Drawing.Point(112, 0)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(90, 67)
        Me.btneditar.TabIndex = 35
        Me.btneditar.Text = "F2 - Editar"
        Me.btneditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(90, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(22, 67)
        Me.Panel1.TabIndex = 34
        '
        'btninserir
        '
        Me.btninserir.Dock = System.Windows.Forms.DockStyle.Left
        Me.btninserir.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btninserir.FlatAppearance.BorderSize = 0
        Me.btninserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninserir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninserir.ForeColor = System.Drawing.Color.Black
        Me.btninserir.Image = CType(resources.GetObject("btninserir.Image"), System.Drawing.Image)
        Me.btninserir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btninserir.Location = New System.Drawing.Point(0, 0)
        Me.btninserir.Name = "btninserir"
        Me.btninserir.Size = New System.Drawing.Size(90, 67)
        Me.btninserir.TabIndex = 32
        Me.btninserir.Text = "F1 - Inserir"
        Me.btninserir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btninserir.UseVisualStyleBackColor = True
        '
        'FrmCadastroProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1093, 681)
        Me.Controls.Add(Me.tbProduto)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCadastroProdutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCadastroProdutos"
        Me.tbProduto.ResumeLayout(False)
        Me.tpCadastrar.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpPreco.ResumeLayout(False)
        Me.grpPreco.PerformLayout()
        CType(Me.nPcusto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nLucroM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nvenda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nLucro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nCusto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nDescMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nAliqTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nAliqIpi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nAliqPis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nCofins, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nAliqBc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nAliqIcms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nAliqNcmMunicipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nAliqNcmEstadual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nAliqNcmFederal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgIpi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgNcm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPiscst, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgCofinscst, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgicmscst, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgCsosn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgCfop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.tpPesquisa.ResumeLayout(False)
        Me.tpPesquisa.PerformLayout()
        CType(Me.dgProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAmbiente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbProduto As TabControl
    Friend WithEvents tpCadastrar As TabPage
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txtEstoque As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents grpPreco As GroupBox
    Public WithEvents nPcusto As NumericUpDown
    Friend WithEvents lblCusto As Label
    Friend WithEvents Label33 As Label
    Public WithEvents nLucroM As NumericUpDown
    Public WithEvents nvenda As NumericUpDown
    Public WithEvents nLucro As NumericUpDown
    Public WithEvents nCusto As NumericUpDown
    Public WithEvents nDescMax As NumericUpDown
    Public WithEvents nCompra As NumericUpDown
    Friend WithEvents lblDescMax As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Public WithEvents nAliqTotal As NumericUpDown
    Public WithEvents nAliqIpi As NumericUpDown
    Public WithEvents nAliqPis As NumericUpDown
    Public WithEvents nCofins As NumericUpDown
    Public WithEvents nAliqBc As NumericUpDown
    Public WithEvents nAliqIcms As NumericUpDown
    Public WithEvents nAliqNcmMunicipal As NumericUpDown
    Public WithEvents nAliqNcmEstadual As NumericUpDown
    Public WithEvents nAliqNcmFederal As NumericUpDown
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents imgIpi As PictureBox
    Friend WithEvents txtDescipi As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents imgNcm As PictureBox
    Friend WithEvents txtDescNcm As TextBox
    Friend WithEvents txtNcm As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents txtCodIpi As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents imgPiscst As PictureBox
    Friend WithEvents txtDescpiscst As TextBox
    Friend WithEvents txtCodpiscst As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents imgCofinscst As PictureBox
    Friend WithEvents txtDescConfinsCst As TextBox
    Friend WithEvents txtcodCfop As TextBox
    Friend WithEvents txtCodCofinsCst As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents imgicmscst As PictureBox
    Friend WithEvents txtdescicmscst As TextBox
    Friend WithEvents txtCodIcmsCst As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents imgCsosn As PictureBox
    Friend WithEvents txtDescCsosn As TextBox
    Friend WithEvents txtCodCsosn As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents imgCfop As PictureBox
    Friend WithEvents txtdesccfop As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtdescricaopdv As TextBox
    Friend WithEvents txtcodbarra As TextBox
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents txtCodProduto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents cbxAtivo As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tpPesquisa As TabPage
    Friend WithEvents Label27 As Label
    Friend WithEvents cbxFiltro As ComboBox
    Friend WithEvents Label26 As Label
    Friend WithEvents txtPesquisar As TextBox
    Friend WithEvents dgProdutos As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnFechar As Button
    Friend WithEvents btnimprimir As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnpesquisar As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btncancelar As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnsalvar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btneditar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btninserir As Button
    Friend WithEvents PRODUTOBindingSource As BindingSource
    Friend WithEvents DsAmbiente As dsAmbiente
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtDiasValido As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents btnGerarArquivoBalanca As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label37 As Label
    Friend WithEvents cbxBalanca As ComboBox
    Friend WithEvents Label36 As Label
    Friend WithEvents cbxPerecivel As ComboBox
    Friend WithEvents Label35 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents txtTipoProduto As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents cbxInformacaoExtra As ComboBox
    Friend WithEvents Label39 As Label
    Friend WithEvents cbxCargaBalanca As ComboBox
    Friend WithEvents Label40 As Label
    Friend WithEvents btnGeraEtiqueta As Button
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents CODPRODUTODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CODBARRADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DESCRICAODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRECO_VENDA As DataGridViewTextBoxColumn
    Friend WithEvents ATIVODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
