<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNotaFiscalEletronica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNotaFiscalEletronica))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnEmitir = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNovaNota = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtNumeroNota = New System.Windows.Forms.TextBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbxIntermediario = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.cbxFormaPagamento = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cbxIndicativoPresenca = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtValorFrete = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtPesoB = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtNumeroVolume = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPesoLiquido = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtEspecie = New System.Windows.Forms.TextBox()
        Me.txtQuantidadeVolume = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbxTransportador = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbxModeloFrete = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.rtbInformaçõesComplementares = New System.Windows.Forms.RichTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpDataSaida = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpDataEmissao = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDescricaoCfop = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtCfop = New System.Windows.Forms.TextBox()
        Me.txtNomeCliente = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxTipoVenda = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxTipoNfe = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxFinalidade = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigoVenda = New System.Windows.Forms.TextBox()
        Me.dgNotaFiscal = New System.Windows.Forms.DataGridView()
        Me.cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CFOP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CSOSN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NCM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CEST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNITARIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QTDE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgNotaFiscal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.btnEmitir)
        Me.Panel1.Controls.Add(Me.Panel9)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnNovaNota)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.txtNumeroNota)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1215, 66)
        Me.Panel1.TabIndex = 0
        '
        'btnEmitir
        '
        Me.btnEmitir.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEmitir.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEmitir.FlatAppearance.BorderSize = 0
        Me.btnEmitir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmitir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmitir.ForeColor = System.Drawing.Color.White
        Me.btnEmitir.Image = CType(resources.GetObject("btnEmitir.Image"), System.Drawing.Image)
        Me.btnEmitir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEmitir.Location = New System.Drawing.Point(150, 0)
        Me.btnEmitir.Name = "btnEmitir"
        Me.btnEmitir.Size = New System.Drawing.Size(102, 66)
        Me.btnEmitir.TabIndex = 36
        Me.btnEmitir.Text = "Emitir"
        Me.btnEmitir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEmitir.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel9.Location = New System.Drawing.Point(126, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(24, 66)
        Me.Panel9.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(956, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 33)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Nota Nº :"
        '
        'btnNovaNota
        '
        Me.btnNovaNota.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnNovaNota.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnNovaNota.FlatAppearance.BorderSize = 0
        Me.btnNovaNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovaNota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovaNota.ForeColor = System.Drawing.Color.White
        Me.btnNovaNota.Image = CType(resources.GetObject("btnNovaNota.Image"), System.Drawing.Image)
        Me.btnNovaNota.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNovaNota.Location = New System.Drawing.Point(24, 0)
        Me.btnNovaNota.Name = "btnNovaNota"
        Me.btnNovaNota.Size = New System.Drawing.Size(102, 66)
        Me.btnNovaNota.TabIndex = 33
        Me.btnNovaNota.Text = "Nova Nota (F1)"
        Me.btnNovaNota.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNovaNota.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(24, 66)
        Me.Panel3.TabIndex = 0
        '
        'txtNumeroNota
        '
        Me.txtNumeroNota.BackColor = System.Drawing.Color.MidnightBlue
        Me.txtNumeroNota.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNumeroNota.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtNumeroNota.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroNota.ForeColor = System.Drawing.Color.White
        Me.txtNumeroNota.Location = New System.Drawing.Point(1088, 0)
        Me.txtNumeroNota.Name = "txtNumeroNota"
        Me.txtNumeroNota.Size = New System.Drawing.Size(127, 37)
        Me.txtNumeroNota.TabIndex = 32
        Me.txtNumeroNota.Text = "1254"
        Me.txtNumeroNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "icons8-pesquisar (1).gif")
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.GroupBox3)
        Me.Panel4.Controls.Add(Me.GroupBox2)
        Me.Panel4.Controls.Add(Me.GroupBox1)
        Me.Panel4.Controls.Add(Me.btnLimpar)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.rtbInformaçõesComplementares)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.dtpDataSaida)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.dtpDataEmissao)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.txtDescricaoCfop)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Controls.Add(Me.txtCfop)
        Me.Panel4.Controls.Add(Me.txtNomeCliente)
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.txtCodCliente)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.cbxTipoVenda)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.cbxTipoNfe)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.cbxFinalidade)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.txtCodigoVenda)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 66)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1215, 348)
        Me.Panel4.TabIndex = 50
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.cbxIntermediario)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.cbxFormaPagamento)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.cbxIndicativoPresenca)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(714, 181)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(491, 161)
        Me.GroupBox3.TabIndex = 61
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Extras"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(18, 118)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(96, 13)
        Me.Label20.TabIndex = 5
        Me.Label20.Text = "Forma Pagamento:"
        '
        'cbxIntermediario
        '
        Me.cbxIntermediario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxIntermediario.FormattingEnabled = True
        Me.cbxIntermediario.Location = New System.Drawing.Point(21, 87)
        Me.cbxIntermediario.Name = "cbxIntermediario"
        Me.cbxIntermediario.Size = New System.Drawing.Size(376, 21)
        Me.cbxIntermediario.TabIndex = 4
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(18, 70)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(70, 13)
        Me.Label26.TabIndex = 3
        Me.Label26.Text = "Intermediario:"
        '
        'cbxFormaPagamento
        '
        Me.cbxFormaPagamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxFormaPagamento.FormattingEnabled = True
        Me.cbxFormaPagamento.Items.AddRange(New Object() {"Contratação do Frete por conta do Remetente (CIF)", "Contratação do Frete por conta do Destinatário (FOB)", "Contratação do Frete por conta de Terceiros", "Transporte Próprio por conta do Remetente", "Transporte Próprio por conta do DestinatárioSem Ocorrência de Transporte"})
        Me.cbxFormaPagamento.Location = New System.Drawing.Point(21, 134)
        Me.cbxFormaPagamento.Name = "cbxFormaPagamento"
        Me.cbxFormaPagamento.Size = New System.Drawing.Size(376, 21)
        Me.cbxFormaPagamento.TabIndex = 2
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(18, 25)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(119, 13)
        Me.Label27.TabIndex = 1
        Me.Label27.Text = "Indicativo de Presença:"
        '
        'cbxIndicativoPresenca
        '
        Me.cbxIndicativoPresenca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxIndicativoPresenca.FormattingEnabled = True
        Me.cbxIndicativoPresenca.Items.AddRange(New Object() {""})
        Me.cbxIndicativoPresenca.Location = New System.Drawing.Point(21, 42)
        Me.cbxIndicativoPresenca.Name = "cbxIndicativoPresenca"
        Me.cbxIndicativoPresenca.Size = New System.Drawing.Size(376, 21)
        Me.cbxIndicativoPresenca.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtValorFrete)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txtPesoB)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.txtNumeroVolume)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtPesoLiquido)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtEspecie)
        Me.GroupBox2.Controls.Add(Me.txtQuantidadeVolume)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.cbxTransportador)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cbxModeloFrete)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(714, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(491, 170)
        Me.GroupBox2.TabIndex = 60
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transportador"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(273, 146)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 13)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "VALOR:"
        '
        'txtValorFrete
        '
        Me.txtValorFrete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorFrete.Location = New System.Drawing.Point(325, 141)
        Me.txtValorFrete.Name = "txtValorFrete"
        Me.txtValorFrete.Size = New System.Drawing.Size(64, 20)
        Me.txtValorFrete.TabIndex = 32
        Me.txtValorFrete.Text = "0"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(120, 144)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 13)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "PESO BRUTO:"
        '
        'txtPesoB
        '
        Me.txtPesoB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesoB.Location = New System.Drawing.Point(206, 141)
        Me.txtPesoB.Name = "txtPesoB"
        Me.txtPesoB.Size = New System.Drawing.Size(47, 20)
        Me.txtPesoB.TabIndex = 30
        Me.txtPesoB.Text = "0"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(9, 146)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(42, 13)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "N VOL:"
        '
        'txtNumeroVolume
        '
        Me.txtNumeroVolume.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroVolume.Location = New System.Drawing.Point(67, 141)
        Me.txtNumeroVolume.Name = "txtNumeroVolume"
        Me.txtNumeroVolume.Size = New System.Drawing.Size(43, 20)
        Me.txtNumeroVolume.TabIndex = 28
        Me.txtNumeroVolume.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(141, 117)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "PESO LIQ:"
        '
        'txtPesoLiquido
        '
        Me.txtPesoLiquido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesoLiquido.Location = New System.Drawing.Point(206, 114)
        Me.txtPesoLiquido.Name = "txtPesoLiquido"
        Me.txtPesoLiquido.Size = New System.Drawing.Size(47, 20)
        Me.txtPesoLiquido.TabIndex = 26
        Me.txtPesoLiquido.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(288, 120)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(31, 13)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "ESP:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(21, 117)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(31, 13)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "VOL:"
        '
        'txtEspecie
        '
        Me.txtEspecie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEspecie.Location = New System.Drawing.Point(325, 117)
        Me.txtEspecie.Name = "txtEspecie"
        Me.txtEspecie.Size = New System.Drawing.Size(64, 20)
        Me.txtEspecie.TabIndex = 23
        Me.txtEspecie.Text = "CX"
        '
        'txtQuantidadeVolume
        '
        Me.txtQuantidadeVolume.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantidadeVolume.Location = New System.Drawing.Point(67, 114)
        Me.txtQuantidadeVolume.Name = "txtQuantidadeVolume"
        Me.txtQuantidadeVolume.Size = New System.Drawing.Size(44, 20)
        Me.txtQuantidadeVolume.TabIndex = 22
        Me.txtQuantidadeVolume.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(18, 71)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Transportador:"
        '
        'cbxTransportador
        '
        Me.cbxTransportador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTransportador.FormattingEnabled = True
        Me.cbxTransportador.Location = New System.Drawing.Point(21, 87)
        Me.cbxTransportador.Name = "cbxTransportador"
        Me.cbxTransportador.Size = New System.Drawing.Size(376, 21)
        Me.cbxTransportador.TabIndex = 2
        Me.cbxTransportador.Text = "O MESMO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Modelo Frete:"
        '
        'cbxModeloFrete
        '
        Me.cbxModeloFrete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxModeloFrete.FormattingEnabled = True
        Me.cbxModeloFrete.Items.AddRange(New Object() {"Contratação do Frete por conta do Remetente (CIF)", "Contratação do Frete por conta do Destinatário (FOB)", "Contratação do Frete por conta de Terceiros", "Transporte Próprio por conta do Remetente", "Transporte Próprio por conta do DestinatárioSem Ocorrência de Transporte"})
        Me.cbxModeloFrete.Location = New System.Drawing.Point(21, 42)
        Me.cbxModeloFrete.Name = "cbxModeloFrete"
        Me.cbxModeloFrete.Size = New System.Drawing.Size(376, 21)
        Me.cbxModeloFrete.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox1.Location = New System.Drawing.Point(24, 259)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 54)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Total NFe (R$)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(199, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 29)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "R$0,00"
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(105, 157)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpar.TabIndex = 58
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(21, 163)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 13)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "Data Emissao :"
        '
        'rtbInformaçõesComplementares
        '
        Me.rtbInformaçõesComplementares.Location = New System.Drawing.Point(24, 181)
        Me.rtbInformaçõesComplementares.Name = "rtbInformaçõesComplementares"
        Me.rtbInformaçõesComplementares.Size = New System.Drawing.Size(684, 60)
        Me.rtbInformaçõesComplementares.TabIndex = 56
        Me.rtbInformaçõesComplementares.Text = "DOCUMENTO EMITIDO POR ME OU EPP,OPTANTE PELO SIMPLES NACIONAL NAO GERA DIREITO A " &
    "CREDITO FINAL DE IPI. "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(120, 112)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Data Saida :"
        '
        'dtpDataSaida
        '
        Me.dtpDataSaida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataSaida.Location = New System.Drawing.Point(123, 130)
        Me.dtpDataSaida.Name = "dtpDataSaida"
        Me.dtpDataSaida.Size = New System.Drawing.Size(93, 20)
        Me.dtpDataSaida.TabIndex = 54
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Data Emissao :"
        '
        'dtpDataEmissao
        '
        Me.dtpDataEmissao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataEmissao.Location = New System.Drawing.Point(24, 130)
        Me.dtpDataEmissao.Name = "dtpDataEmissao"
        Me.dtpDataEmissao.Size = New System.Drawing.Size(93, 20)
        Me.dtpDataEmissao.TabIndex = 52
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(352, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Nat. da Op.:"
        '
        'txtDescricaoCfop
        '
        Me.txtDescricaoCfop.Location = New System.Drawing.Point(467, 79)
        Me.txtDescricaoCfop.Name = "txtDescricaoCfop"
        Me.txtDescricaoCfop.Size = New System.Drawing.Size(241, 20)
        Me.txtDescricaoCfop.TabIndex = 48
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(435, 75)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 25)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 47
        Me.PictureBox2.TabStop = False
        '
        'txtCfop
        '
        Me.txtCfop.Location = New System.Drawing.Point(356, 79)
        Me.txtCfop.Name = "txtCfop"
        Me.txtCfop.Size = New System.Drawing.Size(78, 20)
        Me.txtCfop.TabIndex = 46
        Me.txtCfop.Text = "5102"
        '
        'txtNomeCliente
        '
        Me.txtNomeCliente.Location = New System.Drawing.Point(149, 79)
        Me.txtNomeCliente.Name = "txtNomeCliente"
        Me.txtNomeCliente.Size = New System.Drawing.Size(200, 20)
        Me.txtNomeCliente.TabIndex = 45
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(118, 75)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Cliente :"
        '
        'txtCodCliente
        '
        Me.txtCodCliente.Location = New System.Drawing.Point(24, 79)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.Size = New System.Drawing.Size(93, 20)
        Me.txtCodCliente.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(263, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Tipo Venda :"
        '
        'cbxTipoVenda
        '
        Me.cbxTipoVenda.DisplayMember = "0"
        Me.cbxTipoVenda.FormattingEnabled = True
        Me.cbxTipoVenda.Items.AddRange(New Object() {"A VISTA", "A PRAZO", "OUTROS"})
        Me.cbxTipoVenda.Location = New System.Drawing.Point(267, 27)
        Me.cbxTipoVenda.Name = "cbxTipoVenda"
        Me.cbxTipoVenda.Size = New System.Drawing.Size(110, 21)
        Me.cbxTipoVenda.TabIndex = 40
        Me.cbxTipoVenda.Text = "A VISTA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(147, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Tipo NFe :"
        '
        'cbxTipoNfe
        '
        Me.cbxTipoNfe.DisplayMember = "0"
        Me.cbxTipoNfe.FormattingEnabled = True
        Me.cbxTipoNfe.Items.AddRange(New Object() {"SAIDA", "ENTRADA"})
        Me.cbxTipoNfe.Location = New System.Drawing.Point(150, 27)
        Me.cbxTipoNfe.Name = "cbxTipoNfe"
        Me.cbxTipoNfe.Size = New System.Drawing.Size(110, 21)
        Me.cbxTipoNfe.TabIndex = 38
        Me.cbxTipoNfe.Text = "SAIDA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Finalidade :"
        '
        'cbxFinalidade
        '
        Me.cbxFinalidade.FormattingEnabled = True
        Me.cbxFinalidade.Items.AddRange(New Object() {"VENDA", "TROCA", "BONIFICAÇÃO"})
        Me.cbxFinalidade.Location = New System.Drawing.Point(24, 27)
        Me.cbxFinalidade.Name = "cbxFinalidade"
        Me.cbxFinalidade.Size = New System.Drawing.Size(120, 21)
        Me.cbxFinalidade.TabIndex = 36
        Me.cbxFinalidade.Text = "VENDA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(380, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Codigo Venda :"
        '
        'txtCodigoVenda
        '
        Me.txtCodigoVenda.Location = New System.Drawing.Point(383, 28)
        Me.txtCodigoVenda.Name = "txtCodigoVenda"
        Me.txtCodigoVenda.Size = New System.Drawing.Size(106, 20)
        Me.txtCodigoVenda.TabIndex = 34
        '
        'dgNotaFiscal
        '
        Me.dgNotaFiscal.AllowUserToAddRows = False
        Me.dgNotaFiscal.AllowUserToDeleteRows = False
        Me.dgNotaFiscal.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgNotaFiscal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgNotaFiscal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgNotaFiscal.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgNotaFiscal.ColumnHeadersHeight = 20
        Me.dgNotaFiscal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod, Me.descricao, Me.CFOP, Me.CSOSN, Me.NCM, Me.CEST, Me.UNITARIO, Me.QTDE, Me.TOTAL})
        Me.dgNotaFiscal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgNotaFiscal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgNotaFiscal.GridColor = System.Drawing.SystemColors.HighlightText
        Me.dgNotaFiscal.Location = New System.Drawing.Point(0, 414)
        Me.dgNotaFiscal.MultiSelect = False
        Me.dgNotaFiscal.Name = "dgNotaFiscal"
        Me.dgNotaFiscal.ReadOnly = True
        Me.dgNotaFiscal.RowHeadersVisible = False
        Me.dgNotaFiscal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgNotaFiscal.Size = New System.Drawing.Size(1215, 199)
        Me.dgNotaFiscal.TabIndex = 52
        '
        'cod
        '
        Me.cod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.cod.HeaderText = "COD"
        Me.cod.Name = "cod"
        Me.cod.ReadOnly = True
        Me.cod.Width = 70
        '
        'descricao
        '
        Me.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.descricao.FillWeight = 579.5276!
        Me.descricao.HeaderText = "DESCRIÇÃO"
        Me.descricao.Name = "descricao"
        Me.descricao.ReadOnly = True
        Me.descricao.Width = 190
        '
        'CFOP
        '
        Me.CFOP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CFOP.FillWeight = 31.49606!
        Me.CFOP.HeaderText = "CFOP"
        Me.CFOP.Name = "CFOP"
        Me.CFOP.ReadOnly = True
        Me.CFOP.Width = 60
        '
        'CSOSN
        '
        Me.CSOSN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CSOSN.FillWeight = 31.49606!
        Me.CSOSN.HeaderText = "CSOSN"
        Me.CSOSN.Name = "CSOSN"
        Me.CSOSN.ReadOnly = True
        Me.CSOSN.Width = 60
        '
        'NCM
        '
        Me.NCM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.NCM.FillWeight = 31.49606!
        Me.NCM.HeaderText = "NCM"
        Me.NCM.Name = "NCM"
        Me.NCM.ReadOnly = True
        '
        'CEST
        '
        Me.CEST.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CEST.DefaultCellStyle = DataGridViewCellStyle2
        Me.CEST.FillWeight = 31.49606!
        Me.CEST.HeaderText = "CEST"
        Me.CEST.Name = "CEST"
        Me.CEST.ReadOnly = True
        Me.CEST.Width = 80
        '
        'UNITARIO
        '
        Me.UNITARIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.UNITARIO.DefaultCellStyle = DataGridViewCellStyle3
        Me.UNITARIO.FillWeight = 31.49606!
        Me.UNITARIO.HeaderText = "UNITARIO(R$)"
        Me.UNITARIO.Name = "UNITARIO"
        Me.UNITARIO.ReadOnly = True
        Me.UNITARIO.Width = 105
        '
        'QTDE
        '
        Me.QTDE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.QTDE.DefaultCellStyle = DataGridViewCellStyle4
        Me.QTDE.FillWeight = 31.49606!
        Me.QTDE.HeaderText = "QTDE(x)"
        Me.QTDE.Name = "QTDE"
        Me.QTDE.ReadOnly = True
        Me.QTDE.Width = 90
        '
        'TOTAL
        '
        Me.TOTAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.TOTAL.DefaultCellStyle = DataGridViewCellStyle5
        Me.TOTAL.FillWeight = 31.49606!
        Me.TOTAL.HeaderText = "TOTAL(R$)"
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.ReadOnly = True
        Me.TOTAL.Width = 105
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 583)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1215, 30)
        Me.StatusStrip1.TabIndex = 53
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(180, 25)
        Me.ToolStripStatusLabel1.Text = "F2 - Importar Venda"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(218, 25)
        Me.ToolStripStatusLabel5.Text = "F3 - Importar Agrupadas"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(147, 25)
        Me.ToolStripStatusLabel2.Text = "F4 - Lançar Item"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(140, 25)
        Me.ToolStripStatusLabel3.Text = "F5 - Editar Item"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel4.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
        Me.ToolStripStatusLabel4.MergeIndex = 3
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(205, 25)
        Me.ToolStripStatusLabel4.Text = " DELETE - Deletar Item "
        Me.ToolStripStatusLabel4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'FrmNotaFiscalEletronica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1215, 613)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.dgNotaFiscal)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "FrmNotaFiscalEletronica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmNotaFiscalEletronica"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgNotaFiscal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents btnNovaNota As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnLimpar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents rtbInformaçõesComplementares As RichTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpDataSaida As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpDataEmissao As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDescricaoCfop As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtCfop As TextBox
    Friend WithEvents txtNomeCliente As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCodCliente As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbxTipoVenda As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbxTipoNfe As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbxFinalidade As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodigoVenda As TextBox
    Friend WithEvents txtNumeroNota As TextBox
    Friend WithEvents dgNotaFiscal As DataGridView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEmitir As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtValorFrete As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtPesoB As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtNumeroVolume As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtPesoLiquido As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtEspecie As TextBox
    Friend WithEvents txtQuantidadeVolume As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cbxTransportador As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbxModeloFrete As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label26 As Label
    Friend WithEvents cbxFormaPagamento As ComboBox
    Friend WithEvents Label27 As Label
    Friend WithEvents cbxIndicativoPresenca As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents cbxIntermediario As ComboBox
    Friend WithEvents cod As DataGridViewTextBoxColumn
    Friend WithEvents descricao As DataGridViewTextBoxColumn
    Friend WithEvents CFOP As DataGridViewTextBoxColumn
    Friend WithEvents CSOSN As DataGridViewTextBoxColumn
    Friend WithEvents NCM As DataGridViewTextBoxColumn
    Friend WithEvents CEST As DataGridViewTextBoxColumn
    Friend WithEvents UNITARIO As DataGridViewTextBoxColumn
    Friend WithEvents QTDE As DataGridViewTextBoxColumn
    Friend WithEvents TOTAL As DataGridViewTextBoxColumn
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
End Class
