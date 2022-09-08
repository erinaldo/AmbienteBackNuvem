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
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnNovaNota = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnDeletarItem = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnEditarItem = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnLancarItem = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnImportarItem = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumeroNota = New System.Windows.Forms.TextBox()
        Me.dg_funcionario = New System.Windows.Forms.DataGridView()
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
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_funcionario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.btnNovaNota)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1215, 66)
        Me.Panel1.TabIndex = 0
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel2.Controls.Add(Me.btnDeletarItem)
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Controls.Add(Me.btnEditarItem)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.btnLancarItem)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.btnImportarItem)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 550)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1215, 63)
        Me.Panel2.TabIndex = 1
        '
        'btnDeletarItem
        '
        Me.btnDeletarItem.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDeletarItem.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnDeletarItem.FlatAppearance.BorderSize = 0
        Me.btnDeletarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeletarItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeletarItem.ForeColor = System.Drawing.Color.White
        Me.btnDeletarItem.Image = CType(resources.GetObject("btnDeletarItem.Image"), System.Drawing.Image)
        Me.btnDeletarItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDeletarItem.Location = New System.Drawing.Point(869, 0)
        Me.btnDeletarItem.Name = "btnDeletarItem"
        Me.btnDeletarItem.Size = New System.Drawing.Size(280, 63)
        Me.btnDeletarItem.TabIndex = 40
        Me.btnDeletarItem.Text = "Lançar Item (DELETE)"
        Me.btnDeletarItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDeletarItem.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(859, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(10, 63)
        Me.Panel8.TabIndex = 39
        '
        'btnEditarItem
        '
        Me.btnEditarItem.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEditarItem.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEditarItem.FlatAppearance.BorderSize = 0
        Me.btnEditarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarItem.ForeColor = System.Drawing.Color.White
        Me.btnEditarItem.Image = CType(resources.GetObject("btnEditarItem.Image"), System.Drawing.Image)
        Me.btnEditarItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEditarItem.Location = New System.Drawing.Point(579, 0)
        Me.btnEditarItem.Name = "btnEditarItem"
        Me.btnEditarItem.Size = New System.Drawing.Size(280, 63)
        Me.btnEditarItem.TabIndex = 38
        Me.btnEditarItem.Text = "Editar Item (F4)"
        Me.btnEditarItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEditarItem.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(569, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(10, 63)
        Me.Panel6.TabIndex = 37
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(10, 63)
        Me.Panel7.TabIndex = 38
        '
        'btnLancarItem
        '
        Me.btnLancarItem.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnLancarItem.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnLancarItem.FlatAppearance.BorderSize = 0
        Me.btnLancarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLancarItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLancarItem.ForeColor = System.Drawing.Color.White
        Me.btnLancarItem.Image = CType(resources.GetObject("btnLancarItem.Image"), System.Drawing.Image)
        Me.btnLancarItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLancarItem.Location = New System.Drawing.Point(289, 0)
        Me.btnLancarItem.Name = "btnLancarItem"
        Me.btnLancarItem.Size = New System.Drawing.Size(280, 63)
        Me.btnLancarItem.TabIndex = 36
        Me.btnLancarItem.Text = "Lançar Item (F3)"
        Me.btnLancarItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLancarItem.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(279, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(10, 63)
        Me.Panel5.TabIndex = 35
        '
        'btnImportarItem
        '
        Me.btnImportarItem.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnImportarItem.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnImportarItem.FlatAppearance.BorderSize = 0
        Me.btnImportarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImportarItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportarItem.ForeColor = System.Drawing.Color.White
        Me.btnImportarItem.Image = CType(resources.GetObject("btnImportarItem.Image"), System.Drawing.Image)
        Me.btnImportarItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImportarItem.Location = New System.Drawing.Point(0, 0)
        Me.btnImportarItem.Name = "btnImportarItem"
        Me.btnImportarItem.Size = New System.Drawing.Size(279, 63)
        Me.btnImportarItem.TabIndex = 34
        Me.btnImportarItem.Text = "Importar Venda (F2)"
        Me.btnImportarItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImportarItem.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "icons8-pesquisar (1).gif")
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.GroupBox1)
        Me.Panel4.Controls.Add(Me.btnLimpar)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.rtbInformaçõesComplementares)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.dtpDataSaida)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.dtpDataEmissao)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.TextBox4)
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
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.txtNumeroNota)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 66)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1215, 319)
        Me.Panel4.TabIndex = 50
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
        Me.Label12.Location = New System.Drawing.Point(171, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(122, 29)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "R$140,25"
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(120, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Codigo Nota :"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(123, 28)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(114, 20)
        Me.TextBox4.TabIndex = 49
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
        Me.Label5.Location = New System.Drawing.Point(594, 10)
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
        Me.cbxTipoVenda.Location = New System.Drawing.Point(598, 28)
        Me.cbxTipoVenda.Name = "cbxTipoVenda"
        Me.cbxTipoVenda.Size = New System.Drawing.Size(110, 21)
        Me.cbxTipoVenda.TabIndex = 40
        Me.cbxTipoVenda.Text = "A VISTA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(478, 10)
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
        Me.cbxTipoNfe.Location = New System.Drawing.Point(481, 28)
        Me.cbxTipoNfe.Name = "cbxTipoNfe"
        Me.cbxTipoNfe.Size = New System.Drawing.Size(110, 21)
        Me.cbxTipoNfe.TabIndex = 38
        Me.cbxTipoNfe.Text = "SAIDA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(352, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Finalidade :"
        '
        'cbxFinalidade
        '
        Me.cbxFinalidade.FormattingEnabled = True
        Me.cbxFinalidade.Items.AddRange(New Object() {"VENDA", "TROCA", "BONIFICAÇÃO"})
        Me.cbxFinalidade.Location = New System.Drawing.Point(355, 28)
        Me.cbxFinalidade.Name = "cbxFinalidade"
        Me.cbxFinalidade.Size = New System.Drawing.Size(120, 21)
        Me.cbxFinalidade.TabIndex = 36
        Me.cbxFinalidade.Text = "VENDA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(240, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Codigo Venda :"
        '
        'txtCodigoVenda
        '
        Me.txtCodigoVenda.Location = New System.Drawing.Point(243, 28)
        Me.txtCodigoVenda.Name = "txtCodigoVenda"
        Me.txtCodigoVenda.Size = New System.Drawing.Size(106, 20)
        Me.txtCodigoVenda.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Numero Nota :"
        '
        'txtNumeroNota
        '
        Me.txtNumeroNota.Location = New System.Drawing.Point(25, 28)
        Me.txtNumeroNota.Name = "txtNumeroNota"
        Me.txtNumeroNota.Size = New System.Drawing.Size(92, 20)
        Me.txtNumeroNota.TabIndex = 32
        '
        'dg_funcionario
        '
        Me.dg_funcionario.AllowUserToAddRows = False
        Me.dg_funcionario.AllowUserToDeleteRows = False
        Me.dg_funcionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_funcionario.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg_funcionario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_funcionario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle31.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_funcionario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle31
        Me.dg_funcionario.ColumnHeadersHeight = 20
        Me.dg_funcionario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod, Me.descricao, Me.CFOP, Me.CSOSN, Me.NCM, Me.CEST, Me.UNITARIO, Me.QTDE, Me.TOTAL})
        Me.dg_funcionario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dg_funcionario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_funcionario.GridColor = System.Drawing.SystemColors.HighlightText
        Me.dg_funcionario.Location = New System.Drawing.Point(0, 385)
        Me.dg_funcionario.MultiSelect = False
        Me.dg_funcionario.Name = "dg_funcionario"
        Me.dg_funcionario.ReadOnly = True
        Me.dg_funcionario.RowHeadersVisible = False
        Me.dg_funcionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_funcionario.Size = New System.Drawing.Size(1215, 165)
        Me.dg_funcionario.TabIndex = 52
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
        DataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CEST.DefaultCellStyle = DataGridViewCellStyle32
        Me.CEST.FillWeight = 31.49606!
        Me.CEST.HeaderText = "CEST"
        Me.CEST.Name = "CEST"
        Me.CEST.ReadOnly = True
        '
        'UNITARIO
        '
        Me.UNITARIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle33.Format = "C2"
        DataGridViewCellStyle33.NullValue = Nothing
        Me.UNITARIO.DefaultCellStyle = DataGridViewCellStyle33
        Me.UNITARIO.FillWeight = 31.49606!
        Me.UNITARIO.HeaderText = "UNITARIO(R$)"
        Me.UNITARIO.Name = "UNITARIO"
        Me.UNITARIO.ReadOnly = True
        Me.UNITARIO.Width = 105
        '
        'QTDE
        '
        Me.QTDE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle34.Format = "N2"
        DataGridViewCellStyle34.NullValue = Nothing
        Me.QTDE.DefaultCellStyle = DataGridViewCellStyle34
        Me.QTDE.FillWeight = 31.49606!
        Me.QTDE.HeaderText = "QTDE(x)"
        Me.QTDE.Name = "QTDE"
        Me.QTDE.ReadOnly = True
        Me.QTDE.Width = 90
        '
        'TOTAL
        '
        Me.TOTAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle35.Format = "C2"
        DataGridViewCellStyle35.NullValue = Nothing
        Me.TOTAL.DefaultCellStyle = DataGridViewCellStyle35
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
        'FrmNotaFiscalEletronica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1215, 613)
        Me.Controls.Add(Me.dg_funcionario)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "FrmNotaFiscalEletronica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmNotaFiscalEletronica"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_funcionario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
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
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox4 As TextBox
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
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumeroNota As TextBox
    Friend WithEvents dg_funcionario As DataGridView
    Friend WithEvents cod As DataGridViewTextBoxColumn
    Friend WithEvents descricao As DataGridViewTextBoxColumn
    Friend WithEvents CFOP As DataGridViewTextBoxColumn
    Friend WithEvents CSOSN As DataGridViewTextBoxColumn
    Friend WithEvents NCM As DataGridViewTextBoxColumn
    Friend WithEvents CEST As DataGridViewTextBoxColumn
    Friend WithEvents UNITARIO As DataGridViewTextBoxColumn
    Friend WithEvents QTDE As DataGridViewTextBoxColumn
    Friend WithEvents TOTAL As DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents btnDeletarItem As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents btnEditarItem As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btnLancarItem As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnImportarItem As Button
End Class
