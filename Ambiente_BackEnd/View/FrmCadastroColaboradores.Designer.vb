<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadastroColaboradores
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCadastroColaboradores))
        Me.grbFormaPagtoSug = New System.Windows.Forms.GroupBox()
        Me.txtFormaPagamento = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtCodFormaPagamento = New System.Windows.Forms.TextBox()
        Me.grbTipo = New System.Windows.Forms.GroupBox()
        Me.cbxTransportador = New System.Windows.Forms.CheckBox()
        Me.cbxFornecedor = New System.Windows.Forms.CheckBox()
        Me.cbxCliente = New System.Windows.Forms.CheckBox()
        Me.txtContato = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.cbxAtivo = New System.Windows.Forms.ComboBox()
        Me.rtObservacao = New System.Windows.Forms.RichTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.dtpDataNascimento = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTelefone2 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtInscMun = New System.Windows.Forms.TextBox()
        Me.txtTelefone1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblvalida = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cbxFiltro = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtPesquisar = New System.Windows.Forms.TextBox()
        Me.dg_cliente = New System.Windows.Forms.DataGridView()
        Me.tpPesquisa = New System.Windows.Forms.TabPage()
        Me.txtcpfcnpj = New System.Windows.Forms.TextBox()
        Me.txtInscEst = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRazaoSocial = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodColaborador = New System.Windows.Forms.TextBox()
        Me.txtNomeFantasia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcep = New System.Windows.Forms.TextBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnimprimir = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnpesquisar = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnsalvar = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.grbEndereco = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtuf = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtcodibge = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtendereco = New System.Windows.Forms.TextBox()
        Me.txtbairro = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.nLimite = New System.Windows.Forms.NumericUpDown()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cbxVale = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cbxBoleto = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cbxCartao = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cbxCheque = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tpCadastrar = New System.Windows.Forms.TabPage()
        Me.tbColaborador = New System.Windows.Forms.TabControl()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btninserir = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DsAmbiente = New Ambiente_BackEnd.dsAmbiente()
        Me.COLABORADORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CODCOLABORADORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RAZAOSOCIALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grbFormaPagtoSug.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbTipo.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.dg_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpPesquisa.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.grbEndereco.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.nLimite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpCadastrar.SuspendLayout()
        Me.tbColaborador.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DsAmbiente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COLABORADORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbFormaPagtoSug
        '
        Me.grbFormaPagtoSug.Controls.Add(Me.txtFormaPagamento)
        Me.grbFormaPagtoSug.Controls.Add(Me.PictureBox1)
        Me.grbFormaPagtoSug.Controls.Add(Me.txtCodFormaPagamento)
        Me.grbFormaPagtoSug.Location = New System.Drawing.Point(860, 145)
        Me.grbFormaPagtoSug.Name = "grbFormaPagtoSug"
        Me.grbFormaPagtoSug.Size = New System.Drawing.Size(208, 45)
        Me.grbFormaPagtoSug.TabIndex = 213
        Me.grbFormaPagtoSug.TabStop = False
        Me.grbFormaPagtoSug.Text = "Forma Pagamento Sugerida :"
        '
        'txtFormaPagamento
        '
        Me.txtFormaPagamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFormaPagamento.Location = New System.Drawing.Point(72, 19)
        Me.txtFormaPagamento.Name = "txtFormaPagamento"
        Me.txtFormaPagamento.Size = New System.Drawing.Size(126, 21)
        Me.txtFormaPagamento.TabIndex = 17
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(43, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'txtCodFormaPagamento
        '
        Me.txtCodFormaPagamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodFormaPagamento.Location = New System.Drawing.Point(6, 19)
        Me.txtCodFormaPagamento.Name = "txtCodFormaPagamento"
        Me.txtCodFormaPagamento.Size = New System.Drawing.Size(35, 21)
        Me.txtCodFormaPagamento.TabIndex = 15
        '
        'grbTipo
        '
        Me.grbTipo.Controls.Add(Me.cbxTransportador)
        Me.grbTipo.Controls.Add(Me.cbxFornecedor)
        Me.grbTipo.Controls.Add(Me.cbxCliente)
        Me.grbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grbTipo.Location = New System.Drawing.Point(859, 42)
        Me.grbTipo.Name = "grbTipo"
        Me.grbTipo.Size = New System.Drawing.Size(208, 99)
        Me.grbTipo.TabIndex = 212
        Me.grbTipo.TabStop = False
        Me.grbTipo.Text = "Tipo :"
        '
        'cbxTransportador
        '
        Me.cbxTransportador.AutoSize = True
        Me.cbxTransportador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTransportador.Location = New System.Drawing.Point(10, 70)
        Me.cbxTransportador.Name = "cbxTransportador"
        Me.cbxTransportador.Size = New System.Drawing.Size(112, 20)
        Me.cbxTransportador.TabIndex = 2
        Me.cbxTransportador.Text = "Transportador"
        Me.cbxTransportador.UseVisualStyleBackColor = True
        '
        'cbxFornecedor
        '
        Me.cbxFornecedor.AutoSize = True
        Me.cbxFornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxFornecedor.Location = New System.Drawing.Point(10, 45)
        Me.cbxFornecedor.Name = "cbxFornecedor"
        Me.cbxFornecedor.Size = New System.Drawing.Size(96, 20)
        Me.cbxFornecedor.TabIndex = 1
        Me.cbxFornecedor.Text = "Fornecedor"
        Me.cbxFornecedor.UseVisualStyleBackColor = True
        '
        'cbxCliente
        '
        Me.cbxCliente.AutoSize = True
        Me.cbxCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCliente.Location = New System.Drawing.Point(10, 19)
        Me.cbxCliente.Name = "cbxCliente"
        Me.cbxCliente.Size = New System.Drawing.Size(67, 20)
        Me.cbxCliente.TabIndex = 0
        Me.cbxCliente.Text = "Cliente"
        Me.cbxCliente.UseVisualStyleBackColor = True
        '
        'txtContato
        '
        Me.txtContato.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContato.Location = New System.Drawing.Point(654, 286)
        Me.txtContato.Name = "txtContato"
        Me.txtContato.Size = New System.Drawing.Size(183, 21)
        Me.txtContato.TabIndex = 10
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(112, 227)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(93, 17)
        Me.Label24.TabIndex = 208
        Me.Label24.Text = "Observação :"
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
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel8.Controls.Add(Me.cbxAtivo)
        Me.Panel8.Controls.Add(Me.Label9)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 592)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1086, 40)
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
        'rtObservacao
        '
        Me.rtObservacao.Location = New System.Drawing.Point(226, 227)
        Me.rtObservacao.Name = "rtObservacao"
        Me.rtObservacao.Size = New System.Drawing.Size(611, 53)
        Me.rtObservacao.TabIndex = 8
        Me.rtObservacao.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(155, 289)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 17)
        Me.Label10.TabIndex = 173
        Me.Label10.Text = "Email :"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(226, 286)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(357, 21)
        Me.txtEmail.TabIndex = 9
        '
        'dtpDataNascimento
        '
        Me.dtpDataNascimento.AllowDrop = True
        Me.dtpDataNascimento.CustomFormat = ""
        Me.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataNascimento.Location = New System.Drawing.Point(222, 198)
        Me.dtpDataNascimento.Name = "dtpDataNascimento"
        Me.dtpDataNascimento.RightToLeftLayout = True
        Me.dtpDataNascimento.Size = New System.Drawing.Size(171, 20)
        Me.dtpDataNascimento.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(585, 289)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 16)
        Me.Label5.TabIndex = 206
        Me.Label5.Text = "Contato :"
        '
        'txtTelefone2
        '
        Me.txtTelefone2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefone2.Location = New System.Drawing.Point(667, 171)
        Me.txtTelefone2.Name = "txtTelefone2"
        Me.txtTelefone2.Size = New System.Drawing.Size(171, 21)
        Me.txtTelefone2.TabIndex = 6
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(81, 202)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(124, 17)
        Me.Label19.TabIndex = 203
        Me.Label19.Text = "Data Nascimento :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(115, 174)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 16)
        Me.Label8.TabIndex = 169
        Me.Label8.Text = "Telefone 1 :"
        '
        'txtInscMun
        '
        Me.txtInscMun.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInscMun.Location = New System.Drawing.Point(741, 139)
        Me.txtInscMun.Name = "txtInscMun"
        Me.txtInscMun.Size = New System.Drawing.Size(111, 21)
        Me.txtInscMun.TabIndex = 4
        '
        'txtTelefone1
        '
        Me.txtTelefone1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefone1.Location = New System.Drawing.Point(222, 171)
        Me.txtTelefone1.Name = "txtTelefone1"
        Me.txtTelefone1.Size = New System.Drawing.Size(171, 21)
        Me.txtTelefone1.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(663, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 204
        Me.Label4.Text = "Insc. Mun.:"
        '
        'lblvalida
        '
        Me.lblvalida.AutoSize = True
        Me.lblvalida.Location = New System.Drawing.Point(352, 146)
        Me.lblvalida.Name = "lblvalida"
        Me.lblvalida.Size = New System.Drawing.Size(36, 13)
        Me.lblvalida.TabIndex = 201
        Me.lblvalida.Text = "Valida"
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
        Me.cbxFiltro.Items.AddRange(New Object() {"CODIGO", "RAZAO SOCIAL", "FANTASIA", "CNPJ/CPF"})
        Me.cbxFiltro.Location = New System.Drawing.Point(6, 29)
        Me.cbxFiltro.Name = "cbxFiltro"
        Me.cbxFiltro.Size = New System.Drawing.Size(113, 21)
        Me.cbxFiltro.TabIndex = 51
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
        'dg_cliente
        '
        Me.dg_cliente.AllowUserToAddRows = False
        Me.dg_cliente.AllowUserToDeleteRows = False
        Me.dg_cliente.AutoGenerateColumns = False
        Me.dg_cliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_cliente.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg_cliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_cliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_cliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dg_cliente.ColumnHeadersHeight = 20
        Me.dg_cliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODCOLABORADORDataGridViewTextBoxColumn, Me.RAZAOSOCIALDataGridViewTextBoxColumn})
        Me.dg_cliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dg_cliente.DataSource = Me.COLABORADORBindingSource
        Me.dg_cliente.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dg_cliente.GridColor = System.Drawing.SystemColors.HighlightText
        Me.dg_cliente.Location = New System.Drawing.Point(3, 79)
        Me.dg_cliente.Name = "dg_cliente"
        Me.dg_cliente.ReadOnly = True
        Me.dg_cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_cliente.Size = New System.Drawing.Size(1086, 556)
        Me.dg_cliente.TabIndex = 48
        '
        'tpPesquisa
        '
        Me.tpPesquisa.Controls.Add(Me.Label27)
        Me.tpPesquisa.Controls.Add(Me.cbxFiltro)
        Me.tpPesquisa.Controls.Add(Me.Label26)
        Me.tpPesquisa.Controls.Add(Me.txtPesquisar)
        Me.tpPesquisa.Controls.Add(Me.dg_cliente)
        Me.tpPesquisa.Location = New System.Drawing.Point(4, 22)
        Me.tpPesquisa.Name = "tpPesquisa"
        Me.tpPesquisa.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPesquisa.Size = New System.Drawing.Size(1092, 638)
        Me.tpPesquisa.TabIndex = 1
        Me.tpPesquisa.Text = "Pesquisar Colaborador"
        Me.tpPesquisa.UseVisualStyleBackColor = True
        '
        'txtcpfcnpj
        '
        Me.txtcpfcnpj.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcpfcnpj.Location = New System.Drawing.Point(222, 141)
        Me.txtcpfcnpj.Name = "txtcpfcnpj"
        Me.txtcpfcnpj.Size = New System.Drawing.Size(126, 21)
        Me.txtcpfcnpj.TabIndex = 2
        '
        'txtInscEst
        '
        Me.txtInscEst.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInscEst.Location = New System.Drawing.Point(548, 138)
        Me.txtInscEst.Name = "txtInscEst"
        Me.txtInscEst.Size = New System.Drawing.Size(111, 21)
        Me.txtInscEst.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(476, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 17)
        Me.Label7.TabIndex = 167
        Me.Label7.Text = "Insc. Est.:"
        '
        'txtRazaoSocial
        '
        Me.txtRazaoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRazaoSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazaoSocial.Location = New System.Drawing.Point(222, 77)
        Me.txtRazaoSocial.Name = "txtRazaoSocial"
        Me.txtRazaoSocial.Size = New System.Drawing.Size(631, 21)
        Me.txtRazaoSocial.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(50, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 16)
        Me.Label3.TabIndex = 200
        Me.Label3.Text = "Razão Social/Nome :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(50, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 199
        Me.Label2.Text = "Código :"
        '
        'txtCodColaborador
        '
        Me.txtCodColaborador.Enabled = False
        Me.txtCodColaborador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodColaborador.Location = New System.Drawing.Point(222, 42)
        Me.txtCodColaborador.Name = "txtCodColaborador"
        Me.txtCodColaborador.Size = New System.Drawing.Size(57, 21)
        Me.txtCodColaborador.TabIndex = 198
        '
        'txtNomeFantasia
        '
        Me.txtNomeFantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomeFantasia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeFantasia.Location = New System.Drawing.Point(222, 111)
        Me.txtNomeFantasia.Name = "txtNomeFantasia"
        Me.txtNomeFantasia.Size = New System.Drawing.Size(631, 21)
        Me.txtNomeFantasia.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(43, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 17)
        Me.Label1.TabIndex = 201
        Me.Label1.Text = "Nome Fantasia/Apelido :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(108, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 165
        Me.Label6.Text = "CPF / CNPJ :"
        '
        'txtcep
        '
        Me.txtcep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcep.Location = New System.Drawing.Point(226, 19)
        Me.txtcep.Name = "txtcep"
        Me.txtcep.Size = New System.Drawing.Size(142, 21)
        Me.txtcep.TabIndex = 11
        '
        'txtCidade
        '
        Me.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCidade.Enabled = False
        Me.txtCidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCidade.Location = New System.Drawing.Point(226, 106)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(367, 21)
        Me.txtCidade.TabIndex = 14
        '
        'btnFechar
        '
        Me.btnFechar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnFechar.FlatAppearance.BorderSize = 0
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.ForeColor = System.Drawing.Color.Black
        Me.btnFechar.Image = CType(resources.GetObject("btnFechar.Image"), System.Drawing.Image)
        Me.btnFechar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFechar.Location = New System.Drawing.Point(982, 0)
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
        Me.btnimprimir.Location = New System.Drawing.Point(654, 0)
        Me.btnimprimir.Name = "btnimprimir"
        Me.btnimprimir.Size = New System.Drawing.Size(118, 67)
        Me.btnimprimir.TabIndex = 160
        Me.btnimprimir.Text = "F6 - Imprimir"
        Me.btnimprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnimprimir.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(632, 0)
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
        Me.btnpesquisar.Location = New System.Drawing.Point(509, 0)
        Me.btnpesquisar.Name = "btnpesquisar"
        Me.btnpesquisar.Size = New System.Drawing.Size(123, 67)
        Me.btnpesquisar.TabIndex = 158
        Me.btnpesquisar.Text = "F5 - Pesquisar"
        Me.btnpesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnpesquisar.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(487, 0)
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
        Me.btncancelar.Location = New System.Drawing.Point(372, 0)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(115, 67)
        Me.btncancelar.TabIndex = 39
        Me.btncancelar.Text = "F4 - Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(350, 0)
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
        Me.btnsalvar.Location = New System.Drawing.Point(251, 0)
        Me.btnsalvar.Name = "btnsalvar"
        Me.btnsalvar.Size = New System.Drawing.Size(99, 67)
        Me.btnsalvar.TabIndex = 37
        Me.btnsalvar.Text = "F3 - Salvar"
        Me.btnsalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsalvar.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(583, 174)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(77, 16)
        Me.Label25.TabIndex = 216
        Me.Label25.Text = "Telefone 2 :"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Label25)
        Me.Panel7.Controls.Add(Me.grbEndereco)
        Me.Panel7.Controls.Add(Me.Panel9)
        Me.Panel7.Controls.Add(Me.grbFormaPagtoSug)
        Me.Panel7.Controls.Add(Me.grbTipo)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Controls.Add(Me.txtContato)
        Me.Panel7.Controls.Add(Me.Label24)
        Me.Panel7.Controls.Add(Me.rtObservacao)
        Me.Panel7.Controls.Add(Me.Label10)
        Me.Panel7.Controls.Add(Me.txtEmail)
        Me.Panel7.Controls.Add(Me.dtpDataNascimento)
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Controls.Add(Me.txtTelefone2)
        Me.Panel7.Controls.Add(Me.Label19)
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Controls.Add(Me.txtInscMun)
        Me.Panel7.Controls.Add(Me.txtTelefone1)
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Controls.Add(Me.lblvalida)
        Me.Panel7.Controls.Add(Me.Label6)
        Me.Panel7.Controls.Add(Me.txtcpfcnpj)
        Me.Panel7.Controls.Add(Me.txtInscEst)
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Controls.Add(Me.txtRazaoSocial)
        Me.Panel7.Controls.Add(Me.Label3)
        Me.Panel7.Controls.Add(Me.Label2)
        Me.Panel7.Controls.Add(Me.txtCodColaborador)
        Me.Panel7.Controls.Add(Me.txtNomeFantasia)
        Me.Panel7.Controls.Add(Me.Label1)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(3, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1086, 632)
        Me.Panel7.TabIndex = 159
        '
        'grbEndereco
        '
        Me.grbEndereco.Controls.Add(Me.txtcep)
        Me.grbEndereco.Controls.Add(Me.Label11)
        Me.grbEndereco.Controls.Add(Me.txtCidade)
        Me.grbEndereco.Controls.Add(Me.Label12)
        Me.grbEndereco.Controls.Add(Me.txtuf)
        Me.grbEndereco.Controls.Add(Me.Label17)
        Me.grbEndereco.Controls.Add(Me.Label13)
        Me.grbEndereco.Controls.Add(Me.txtNumero)
        Me.grbEndereco.Controls.Add(Me.txtcodibge)
        Me.grbEndereco.Controls.Add(Me.Label16)
        Me.grbEndereco.Controls.Add(Me.Label14)
        Me.grbEndereco.Controls.Add(Me.txtendereco)
        Me.grbEndereco.Controls.Add(Me.txtbairro)
        Me.grbEndereco.Controls.Add(Me.Label15)
        Me.grbEndereco.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grbEndereco.Location = New System.Drawing.Point(0, 337)
        Me.grbEndereco.Name = "grbEndereco"
        Me.grbEndereco.Size = New System.Drawing.Size(1086, 215)
        Me.grbEndereco.TabIndex = 11
        Me.grbEndereco.TabStop = False
        Me.grbEndereco.Text = "Dados Endereço"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(163, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 17)
        Me.Label11.TabIndex = 175
        Me.Label11.Text = "CEP :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(146, 110)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 17)
        Me.Label12.TabIndex = 177
        Me.Label12.Text = "Cidade :"
        '
        'txtuf
        '
        Me.txtuf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtuf.Enabled = False
        Me.txtuf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuf.Location = New System.Drawing.Point(226, 132)
        Me.txtuf.Name = "txtuf"
        Me.txtuf.Size = New System.Drawing.Size(59, 21)
        Me.txtuf.TabIndex = 14
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(152, 162)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 17)
        Me.Label17.TabIndex = 187
        Me.Label17.Text = "Numero :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(172, 136)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 17)
        Me.Label13.TabIndex = 179
        Me.Label13.Text = "UF :"
        '
        'txtNumero
        '
        Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(226, 159)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(59, 21)
        Me.txtNumero.TabIndex = 15
        '
        'txtcodibge
        '
        Me.txtcodibge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodibge.Location = New System.Drawing.Point(373, 132)
        Me.txtcodibge.Name = "txtcodibge"
        Me.txtcodibge.Size = New System.Drawing.Size(81, 21)
        Me.txtcodibge.TabIndex = 16
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(129, 51)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 17)
        Me.Label16.TabIndex = 185
        Me.Label16.Text = "Endereco :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(287, 135)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 17)
        Me.Label14.TabIndex = 181
        Me.Label14.Text = "Cod IBGE :"
        '
        'txtendereco
        '
        Me.txtendereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtendereco.Enabled = False
        Me.txtendereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtendereco.Location = New System.Drawing.Point(227, 46)
        Me.txtendereco.Name = "txtendereco"
        Me.txtendereco.Size = New System.Drawing.Size(366, 21)
        Me.txtendereco.TabIndex = 12
        '
        'txtbairro
        '
        Me.txtbairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbairro.Enabled = False
        Me.txtbairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbairro.Location = New System.Drawing.Point(227, 74)
        Me.txtbairro.Name = "txtbairro"
        Me.txtbairro.Size = New System.Drawing.Size(366, 21)
        Me.txtbairro.TabIndex = 13
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(152, 78)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 17)
        Me.Label15.TabIndex = 183
        Me.Label15.Text = "Bairro :"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel9.Controls.Add(Me.nLimite)
        Me.Panel9.Controls.Add(Me.Label23)
        Me.Panel9.Controls.Add(Me.cbxVale)
        Me.Panel9.Controls.Add(Me.Label22)
        Me.Panel9.Controls.Add(Me.cbxBoleto)
        Me.Panel9.Controls.Add(Me.Label21)
        Me.Panel9.Controls.Add(Me.cbxCartao)
        Me.Panel9.Controls.Add(Me.Label18)
        Me.Panel9.Controls.Add(Me.cbxCheque)
        Me.Panel9.Controls.Add(Me.Label20)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Panel9.Location = New System.Drawing.Point(0, 552)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1086, 40)
        Me.Panel9.TabIndex = 214
        '
        'nLimite
        '
        Me.nLimite.DecimalPlaces = 2
        Me.nLimite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nLimite.Location = New System.Drawing.Point(856, 11)
        Me.nLimite.Maximum = New Decimal(New Integer() {999999, 0, 0, 196608})
        Me.nLimite.Name = "nLimite"
        Me.nLimite.Size = New System.Drawing.Size(116, 22)
        Me.nLimite.TabIndex = 21
        Me.nLimite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Lime
        Me.Label23.Location = New System.Drawing.Point(760, 13)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(97, 16)
        Me.Label23.TabIndex = 213
        Me.Label23.Text = "Limite (R$)  : "
        '
        'cbxVale
        '
        Me.cbxVale.FormattingEnabled = True
        Me.cbxVale.Items.AddRange(New Object() {"SIM", "NAO"})
        Me.cbxVale.Location = New System.Drawing.Point(640, 12)
        Me.cbxVale.Name = "cbxVale"
        Me.cbxVale.Size = New System.Drawing.Size(114, 21)
        Me.cbxVale.TabIndex = 20
        Me.cbxVale.Text = "NAO"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Lime
        Me.Label22.Location = New System.Drawing.Point(584, 13)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(55, 16)
        Me.Label22.TabIndex = 212
        Me.Label22.Text = "Vale  : "
        '
        'cbxBoleto
        '
        Me.cbxBoleto.FormattingEnabled = True
        Me.cbxBoleto.Items.AddRange(New Object() {"SIM", "NAO"})
        Me.cbxBoleto.Location = New System.Drawing.Point(461, 12)
        Me.cbxBoleto.Name = "cbxBoleto"
        Me.cbxBoleto.Size = New System.Drawing.Size(114, 21)
        Me.cbxBoleto.TabIndex = 19
        Me.cbxBoleto.Text = "NAO"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Lime
        Me.Label21.Location = New System.Drawing.Point(393, 13)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(68, 16)
        Me.Label21.TabIndex = 210
        Me.Label21.Text = "Boleto  : "
        '
        'cbxCartao
        '
        Me.cbxCartao.FormattingEnabled = True
        Me.cbxCartao.Items.AddRange(New Object() {"SIM", "NAO"})
        Me.cbxCartao.Location = New System.Drawing.Point(274, 12)
        Me.cbxCartao.Name = "cbxCartao"
        Me.cbxCartao.Size = New System.Drawing.Size(114, 21)
        Me.cbxCartao.TabIndex = 18
        Me.cbxCartao.Text = "NAO"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Lime
        Me.Label18.Location = New System.Drawing.Point(204, 13)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 16)
        Me.Label18.TabIndex = 208
        Me.Label18.Text = "Cartão  : "
        '
        'cbxCheque
        '
        Me.cbxCheque.FormattingEnabled = True
        Me.cbxCheque.Items.AddRange(New Object() {"SIM", "NAO"})
        Me.cbxCheque.Location = New System.Drawing.Point(79, 12)
        Me.cbxCheque.Name = "cbxCheque"
        Me.cbxCheque.Size = New System.Drawing.Size(114, 21)
        Me.cbxCheque.TabIndex = 17
        Me.cbxCheque.Text = "NAO"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Lime
        Me.Label20.Location = New System.Drawing.Point(4, 13)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 16)
        Me.Label20.TabIndex = 206
        Me.Label20.Text = "Cheque  :"
        '
        'tpCadastrar
        '
        Me.tpCadastrar.Controls.Add(Me.Panel7)
        Me.tpCadastrar.Location = New System.Drawing.Point(4, 22)
        Me.tpCadastrar.Name = "tpCadastrar"
        Me.tpCadastrar.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCadastrar.Size = New System.Drawing.Size(1092, 638)
        Me.tpCadastrar.TabIndex = 0
        Me.tpCadastrar.Text = "Cadastrar Colaborador"
        Me.tpCadastrar.UseVisualStyleBackColor = True
        '
        'tbColaborador
        '
        Me.tbColaborador.Controls.Add(Me.tpCadastrar)
        Me.tbColaborador.Controls.Add(Me.tpPesquisa)
        Me.tbColaborador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbColaborador.Location = New System.Drawing.Point(0, 67)
        Me.tbColaborador.Name = "tbColaborador"
        Me.tbColaborador.SelectedIndex = 0
        Me.tbColaborador.Size = New System.Drawing.Size(1100, 664)
        Me.tbColaborador.TabIndex = 161
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(229, 0)
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
        Me.btneditar.Location = New System.Drawing.Point(124, 0)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(105, 67)
        Me.btneditar.TabIndex = 35
        Me.btneditar.Text = "F2 - Editar"
        Me.btneditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(102, 0)
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
        Me.btninserir.Size = New System.Drawing.Size(102, 67)
        Me.btninserir.TabIndex = 32
        Me.btninserir.Text = "F1 - Inserir"
        Me.btninserir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btninserir.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
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
        Me.Panel2.Size = New System.Drawing.Size(1100, 67)
        Me.Panel2.TabIndex = 159
        '
        'DsAmbiente
        '
        Me.DsAmbiente.DataSetName = "dsAmbiente"
        Me.DsAmbiente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'COLABORADORBindingSource
        '
        Me.COLABORADORBindingSource.DataMember = "COLABORADOR"
        Me.COLABORADORBindingSource.DataSource = Me.DsAmbiente
        '
        'CODCOLABORADORDataGridViewTextBoxColumn
        '
        Me.CODCOLABORADORDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CODCOLABORADORDataGridViewTextBoxColumn.DataPropertyName = "CODCOLABORADOR"
        Me.CODCOLABORADORDataGridViewTextBoxColumn.FillWeight = 5.076142!
        Me.CODCOLABORADORDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CODCOLABORADORDataGridViewTextBoxColumn.Name = "CODCOLABORADORDataGridViewTextBoxColumn"
        Me.CODCOLABORADORDataGridViewTextBoxColumn.ReadOnly = True
        Me.CODCOLABORADORDataGridViewTextBoxColumn.Width = 70
        '
        'RAZAOSOCIALDataGridViewTextBoxColumn
        '
        Me.RAZAOSOCIALDataGridViewTextBoxColumn.DataPropertyName = "RAZAOSOCIAL"
        Me.RAZAOSOCIALDataGridViewTextBoxColumn.FillWeight = 194.9239!
        Me.RAZAOSOCIALDataGridViewTextBoxColumn.HeaderText = "Nome"
        Me.RAZAOSOCIALDataGridViewTextBoxColumn.Name = "RAZAOSOCIALDataGridViewTextBoxColumn"
        Me.RAZAOSOCIALDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FrmCadastroColaboradores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 731)
        Me.Controls.Add(Me.tbColaborador)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCadastroColaboradores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCadastroColaboradores"
        Me.grbFormaPagtoSug.ResumeLayout(False)
        Me.grbFormaPagtoSug.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbTipo.ResumeLayout(False)
        Me.grbTipo.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.dg_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpPesquisa.ResumeLayout(False)
        Me.tpPesquisa.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.grbEndereco.ResumeLayout(False)
        Me.grbEndereco.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.nLimite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpCadastrar.ResumeLayout(False)
        Me.tbColaborador.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DsAmbiente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COLABORADORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbFormaPagtoSug As GroupBox
    Friend WithEvents txtFormaPagamento As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtCodFormaPagamento As TextBox
    Friend WithEvents grbTipo As GroupBox
    Friend WithEvents cbxTransportador As CheckBox
    Friend WithEvents cbxFornecedor As CheckBox
    Friend WithEvents cbxCliente As CheckBox
    Friend WithEvents txtContato As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents cbxAtivo As ComboBox
    Friend WithEvents rtObservacao As RichTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents dtpDataNascimento As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTelefone2 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtInscMun As TextBox
    Friend WithEvents txtTelefone1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblvalida As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents cbxFiltro As ComboBox
    Friend WithEvents Label26 As Label
    Friend WithEvents txtPesquisar As TextBox
    Friend WithEvents dg_cliente As DataGridView
    Friend WithEvents tpPesquisa As TabPage
    Friend WithEvents txtcpfcnpj As TextBox
    Friend WithEvents txtInscEst As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtRazaoSocial As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodColaborador As TextBox
    Friend WithEvents txtNomeFantasia As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtcep As TextBox
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents btnFechar As Button
    Friend WithEvents btnimprimir As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnpesquisar As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btncancelar As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnsalvar As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents grbEndereco As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtuf As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtcodibge As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtendereco As TextBox
    Friend WithEvents txtbairro As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents nLimite As NumericUpDown
    Friend WithEvents Label23 As Label
    Friend WithEvents cbxVale As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents cbxBoleto As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents cbxCartao As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents cbxCheque As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents tpCadastrar As TabPage
    Friend WithEvents tbColaborador As TabControl
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btneditar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btninserir As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CODCOLABORADORDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RAZAOSOCIALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents COLABORADORBindingSource As BindingSource
    Friend WithEvents DsAmbiente As dsAmbiente
End Class
